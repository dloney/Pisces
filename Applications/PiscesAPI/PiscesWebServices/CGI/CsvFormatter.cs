﻿using Reclamation.TimeSeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiscesWebServices.CGI
{
    /// <summary>
    /// comma separated formatter.
    /// </summary>
     class CsvFormatter:Formatter
    {

         public CsvFormatter(TimeInterval interval, bool printFlags)
             : base(interval, printFlags)
         { 
            ContentType = "Content-type: text/csv\nContent-Disposition: attachment; filename=hydromet.csv\n\n";
         }

         public override void PrintRow(string t0, string[] vals, string[] flags)
         {
             StringBuilder sb = new StringBuilder(vals.Length * 8);
             sb.Append(t0 + ",");
             for (int i = 0; i < vals.Length; i++)
             {
                 sb.Append(vals[i]);
                 if (PrintFlags)
                     sb.Append(flags[i]);
                 if (i != vals.Length - 1)
                     sb.Append(",");
             }
             WriteLine(sb.ToString());

         }
         public override string FormatNumber(object o)
         {
             var rval = "";
             if (o == DBNull.Value || o.ToString() == "")
                 rval = "";//.PadLeft(11);
             else
                 rval = Convert.ToDouble(o).ToString("F02");
             return rval;
         }


         public override string FormatFlag(object o)
         {
             if (o == DBNull.Value)
                 return "";
             else
                 return o.ToString();

         }

        public override string FormatDate(object o)
         {

             var rval = "";
             var t = Convert.ToDateTime(o);
             if (Interval == TimeInterval.Irregular || Interval == TimeInterval.Hourly)
                 rval = t.ToString("yyyy-MM-dd HH:mm");
             else
                 rval = t.ToString("yyyy-MM-dd");
             return rval;
         }
        public override void WriteSeriesHeader(SeriesList list)
        {
            //WriteLine("<PRE>");

            string headLine = "DateTime";

            foreach (var item in list)
            {
                TimeSeriesName tn = new TimeSeriesName(item.Table.TableName);
                headLine += "," + tn.siteid + "_" + tn.pcode;
            }
            
            WriteLine(headLine);
        }

        public override void WriteSeriesTrailer()
        {
            //HydrometWebUtility.PrintHydrometTrailer();
        }

    }
}
