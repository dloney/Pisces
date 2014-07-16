﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reclamation.Core;
using Reclamation.TimeSeries.Parser;
using Reclamation.TimeSeries.Hydromet;
using System.IO;

namespace Reclamation.TimeSeries
{
    /// <summary>
    /// TimeSeriesCalculator manages calculation series. 
    /// Used to compute daily values in a batch type operation.
    /// 
    /// </summary>
    public class TimeSeriesCalculator
    {
        TimeSeriesDatabase m_db;

        public TimeSeriesCalculator(TimeSeriesDatabase db)
        {
            m_db = db;
            // get all daily interval calculation series 
           
        }


        public bool Exists(string siteID, string pcode, TimeInterval interval)
        {
            string tn = interval.ToString().ToLower() + "_" + siteID + "_" + pcode;
            string filter = " tablename = '" + tn.ToLower() + "' and timeinterval = '" + interval + "' and provider = 'CalculationSeries'";

            var sr = m_db.GetSeriesRow(filter);
            if( sr == null)
                return false;

            return true;
        }

        public CalculationSeries Create(string siteID, string pcode, TimeInterval interval)
        {
            string tn = interval.ToString().ToLower() + "_" + siteID + "_" + pcode;
            tn = tn.ToLower();
            string filter = " tablename = '" + tn + "' and timeinterval = '" + interval + "' and provider = 'CalculationSeries'";

            var sr = m_db.GetSeriesRow(filter);
            if (sr == null)
                return null;
            var cs = m_db.GetSeries(sr.id) as CalculationSeries;
            cs.Parser = m_db.Parser; 

            return cs;
        }



        /// <summary>
        /// Calculates a group of daily values.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="propertyFilter">series property filter.  Example  program:agrimet </param>
        /// <param name="simulate">simulate calculations, don't actuually do it.</param>
        public CalculationSeries[] ComputeDailyValues(DateTime t1, DateTime t2, string filter,
            string propertyFilter, bool compareToHydromet=false, string errorFileName="", 
            string detailFileName = "", bool simulate=false)
        {
           

            Performance p = new Performance();
            HydrometInstantSeries.Cache = new HydrometDataCache(); // clear out and make new cache.
            string dailyFileName = GetDailyFileName(propertyFilter);

            bool appendToFile = false; // for output file.
            var list1 = m_db.Factory.GetCalculationSeries(TimeInterval.Daily,filter,propertyFilter);
            TimeSeriesDependency td = new TimeSeriesDependency(list1);
            var sorted = td.Sort();
            foreach (var s in sorted)
            {
                if (!s.Enabled)
                    continue; // calculations turned off

                string originalExpression = s.Expression;
                // compute  Values

                
                if( m_db.Parser.VariableResolver is HydrometVariableResolver)
                    CacheAllParametersForSite(s, t1, t2); // 50% performance boost.

                Console.Write(s.Table.TableName + " = " + s.Expression);
                if (simulate)
                {
                    Console.WriteLine("skipping calc");
                    continue;
                }

                var t1a = t1;
                // for example daily QU calculations default back 7 days (when running previous day)
                if (s.Properties.ContainsKey("DaysBack") && t2.Date == DateTime.Now.AddDays(-1).Date)
                {
                    var daysBack = Convert.ToInt32(s.Properties["DaysBack"]);
                    t1a = t1a.AddDays(-daysBack);
                }

                s.Calculate(t1a, t2); // Calculate() also saves to local time series database.

                
                if (s.Count == 0 || s.CountMissing() > 0)
                {
                    File.AppendAllText(errorFileName, "Error: " + s.Table.TableName + " = " + s.Expression + "\n");
                    string msg = "\nDetails: "+s.Table.TableName + " = " + s.Expression+"\n";
                    foreach (var x in s.Messages)
                    {
                        msg += "\n" + x;
                    }
                    Console.WriteLine(msg);
                    File.AppendAllText(detailFileName, msg);
                }
                else
                {
                 //   File.AppendAllText(errorFileName, " OK. ");
                    Console.WriteLine(" OK. ");
                }

                if (compareToHydromet)
                {
                    CompareToHydromet(s);
                }
                s.Expression = originalExpression;

                TimeSeriesName n = new TimeSeriesName(s.Table.TableName);

                HydrometDailySeries.WriteToArcImportFile(s, n.siteid, n.pcode, dailyFileName, appendToFile);

                if (!appendToFile )
                    appendToFile = true; // append after the first time.
                
            }

            if( appendToFile) // might not have any results
            Console.WriteLine("Results Saved to "+dailyFileName);

          

            p.Report(); // 185 seconds   

            return sorted;
        }

        private static string GetDailyFileName(string propertyFilter)
        {

             string valueFilter = "";
            if (propertyFilter != "" && propertyFilter.IndexOf(":") >= 0)
            {
                valueFilter = propertyFilter.Split(':')[1];
            }

            return TimeSeriesRouting.GetOutgoingFileName("daily", valueFilter, "all");

        }



        static string debugFileName="";

        /// <summary>
        ///  read computed value from hydromet and compare..
        ///  
        /// </summary>
        /// <param name="s"></param>
        private void CompareToHydromet(CalculationSeries s)
        {
            if (s.Count == 0)
                return;
            // TO DO.. also check instant calcs.
            TimeSeriesName n = new TimeSeriesName(s.Table.TableName);

            if (s.TimeInterval == TimeInterval.Daily)
            {
                var tmp = HydrometDailySeries.Cache;
                HydrometDailySeries.Cache = null; // don't use cache..
                HydrometDailySeries h = new HydrometDailySeries(n.siteid, n.pcode);
                HydrometDailySeries.Cache = tmp;

                h.Read(s.MinDateTime, s.MaxDateTime);

                Series diff = Reclamation.TimeSeries.Math.Abs(h - s);

                var pt = Reclamation.TimeSeries.Math.MaxPoint(diff);
                double tolerance = 0.1;
                if (Array.IndexOf(new string[] { "sr", "wr" }, n.pcode) >= 0)
                {
                    tolerance = 1.0;
                }

                double delta = h[0].Value - s[0].Value;
                double pctError = 0;
                if (System.Math.Abs(delta) > 0)
                    pctError = System.Math.Abs(delta / h[0].Value);

                if (pctError > tolerance)
                {
                    if (debugFileName == "")
                    {
                        debugFileName="calc_errors.csv";
                        if(File.Exists(debugFileName))
                          File.Delete(debugFileName);
                        File.AppendAllText(debugFileName, "site,pcode,interval,openvms,linux,delta,percentError" + "\n");
                    }
                    if (h[0].Value != Point.MissingValueFlag)
                    {
                        string msg = n.siteid + "," + n.pcode + "," + n.interval + "," + h[0].Value + ", " + s[0].Value + ", " + delta + ", " + pctError;
                        Console.WriteLine(msg);
                        File.AppendAllText(debugFileName, msg + "\n");
                    }
                }

            }
            else
            {
                throw new NotImplementedException();
            }


        }

        static HashSet<string> visitedSites = new HashSet<string>();
        

        private static void CacheAllParametersForSite(CalculationSeries s, DateTime t1, DateTime t2)
        {
            // if we need instant data for this site
            // get all instant parameters in memory for future use.

            string  tag = s.TimeInterval.ToString() + s.SiteID;

            if (visitedSites.Contains(tag))
                return;
            if (s.TimeInterval != TimeInterval.Daily)
                return;

            var t2a = t2.AddDays(1); // extra data when midnight next day is needed.


            if ( s.Expression.IndexOf("instant") >= 0)
            { // Instant to Daily Calculation

                var tbl = s.TimeSeriesDatabase.GetSeriesCatalog("siteid = '" + s.SiteID + "' and timeinterval = 'Irrregular'");

                var pcodes = DataTableUtility.Strings(tbl, "", "Parameter");

                var query = s.SiteID + " " + String.Join("," + s.SiteID + " ", pcodes);
                var pairs = query.Split(',');
               // 
                HydrometInstantSeries.Cache.Add(pairs, t1, t2a, HydrometHost.PN, TimeInterval.Irregular);

                visitedSites.Add(tag);
                Console.WriteLine(s.SiteID + " added to the cache");
            }
            else if ( s.Expression.IndexOf("instant") < 0)
            { // Daily to Daily type calculation..
                
                var tbl = s.TimeSeriesDatabase.GetSeriesCatalog("siteid = '" + s.SiteID + "' and timeinterval = 'Daily'");

                var pcodes = DataTableUtility.Strings(tbl, "", "Parameter");
                var query = s.SiteID + " " + String.Join("," + s.SiteID + " ", pcodes);
                var pairs = query.Split(',');

                //HydrometDailySeries.Cache = new HydrometDataCache(); // clear out and make new cache.
                HydrometDailySeries.Cache.Add(pairs, t1, t2a, HydrometHost.PN, TimeInterval.Daily);

                visitedSites.Add(tag);
                Console.WriteLine(s.SiteID + " added to the cache");
            }

        }


        

       


    }
}