﻿namespace HydrometTools.SnowGG
{
    partial class SnowGG
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Reclamation.Core.MonthDayRange monthDayRange1 = new Reclamation.Core.MonthDayRange();
            Reclamation.TimeSeries.Forms.Graphing.GraphSettings graphSettings2 = new Reclamation.TimeSeries.Forms.Graphing.GraphSettings();
            this.panel1 = new System.Windows.Forms.Panel();

            this.checkBoxDeltas = new System.Windows.Forms.CheckBox();
            this.checkBoxAnnotate = new System.Windows.Forms.CheckBox();

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPctls = new System.Windows.Forms.TextBox();
            this.checkBoxPctls = new System.Windows.Forms.CheckBox();
            this.textBoxWY2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWY1 = new System.Windows.Forms.TextBox();
            this.checkBoxAvg = new System.Windows.Forms.CheckBox();
            this.checkBoxMax = new System.Windows.Forms.CheckBox();
            this.checkBoxMin = new System.Windows.Forms.CheckBox();
            this.checkBoxGP = new System.Windows.Forms.CheckBox();
            this.checkBoxMpoll = new System.Windows.Forms.CheckBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSelectGroup = new System.Windows.Forms.Button();
            this.comboBoxCbtt = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxPcode = new System.Windows.Forms.ComboBox();
            this.monthRangePicker1 = new Reclamation.TimeSeries.Forms.MonthRangePicker();
            this.yearSelector1 = new Reclamation.TimeSeries.Forms.YearSelector();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxMultiple = new System.Windows.Forms.TextBox();
            this.checkBoxUseList = new System.Windows.Forms.CheckBox();
            this.timeSeriesGraph1 = new Reclamation.TimeSeries.Graphing.TimeSeriesTeeChartGraph();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxUseList);
            this.panel1.Controls.Add(this.textBoxMultiple);
            this.panel1.Controls.Add(this.checkBoxDeltas);
            this.panel1.Controls.Add(this.checkBoxAnnotate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkBoxGP);
            this.panel1.Controls.Add(this.checkBoxMpoll);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonSelectGroup);
            this.panel1.Controls.Add(this.comboBoxCbtt);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.comboBoxPcode);
            this.panel1.Controls.Add(this.monthRangePicker1);
            this.panel1.Controls.Add(this.yearSelector1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 198);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxAnnotate
            // 
            this.checkBoxAnnotate.AutoSize = true;
            this.checkBoxAnnotate.Checked = true;
            this.checkBoxAnnotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAnnotate.Location = new System.Drawing.Point(154, 174);
            this.checkBoxAnnotate.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxAnnotate.Name = "checkBoxAnnotate";
            this.checkBoxAnnotate.Size = new System.Drawing.Size(138, 21);
            this.checkBoxAnnotate.TabIndex = 13;
            this.checkBoxAnnotate.Text = "date/value tooltip";
            this.checkBoxAnnotate.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeltas
            // 
            this.checkBoxDeltas.AutoSize = true;
            this.checkBoxDeltas.Location = new System.Drawing.Point(339, 172);
            this.checkBoxDeltas.Name = "checkBoxDeltas";
            this.checkBoxDeltas.Size = new System.Drawing.Size(182, 21);
            this.checkBoxDeltas.TabIndex = 14;
            this.checkBoxDeltas.Text = "Apply Deltas to 1st Year";
            this.checkBoxDeltas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPctls);
            this.groupBox1.Controls.Add(this.checkBoxPctls);
            this.groupBox1.Controls.Add(this.textBoxWY2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxWY1);
            this.groupBox1.Controls.Add(this.checkBoxAvg);
            this.groupBox1.Controls.Add(this.checkBoxMax);
            this.groupBox1.Controls.Add(this.checkBoxMin);
            this.groupBox1.Location = new System.Drawing.Point(621, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(580, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // textBoxPctls
            // 
            this.textBoxPctls.Location = new System.Drawing.Point(345, 52);
            this.textBoxPctls.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPctls.Name = "textBoxPctls";
            this.textBoxPctls.Size = new System.Drawing.Size(171, 22);
            this.textBoxPctls.TabIndex = 7;
            this.textBoxPctls.Text = "10, 50, 90";
            // 
            // checkBoxPctls
            // 
            this.checkBoxPctls.AutoSize = true;
            this.checkBoxPctls.Location = new System.Drawing.Point(235, 54);
            this.checkBoxPctls.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxPctls.Name = "checkBoxPctls";
            this.checkBoxPctls.Size = new System.Drawing.Size(100, 21);
            this.checkBoxPctls.TabIndex = 6;
            this.checkBoxPctls.Text = "Percentiles";
            this.checkBoxPctls.UseVisualStyleBackColor = true;
            // 
            // textBoxWY2
            // 
            this.textBoxWY2.Location = new System.Drawing.Point(122, 24);
            this.textBoxWY2.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWY2.Name = "textBoxWY2";
            this.textBoxWY2.Size = new System.Drawing.Size(75, 22);
            this.textBoxWY2.TabIndex = 5;
            this.textBoxWY2.Text = "2010";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // textBoxWY1
            // 
            this.textBoxWY1.Location = new System.Drawing.Point(10, 24);
            this.textBoxWY1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWY1.Name = "textBoxWY1";
            this.textBoxWY1.Size = new System.Drawing.Size(72, 22);
            this.textBoxWY1.TabIndex = 3;
            this.textBoxWY1.Text = "1981";
            // 
            // checkBoxAvg
            // 
            this.checkBoxAvg.AutoSize = true;
            this.checkBoxAvg.Location = new System.Drawing.Point(10, 54);
            this.checkBoxAvg.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxAvg.Name = "checkBoxAvg";
            this.checkBoxAvg.Size = new System.Drawing.Size(54, 21);
            this.checkBoxAvg.TabIndex = 2;
            this.checkBoxAvg.Text = "Avg";
            this.checkBoxAvg.UseVisualStyleBackColor = true;
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.Location = new System.Drawing.Point(86, 54);
            this.checkBoxMax.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(55, 21);
            this.checkBoxMax.TabIndex = 1;
            this.checkBoxMax.Text = "Max";
            this.checkBoxMax.UseVisualStyleBackColor = true;
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.Location = new System.Drawing.Point(163, 54);
            this.checkBoxMin.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(52, 21);
            this.checkBoxMin.TabIndex = 0;
            this.checkBoxMin.Text = "Min";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            // 
            // checkBoxGP
            // 
            this.checkBoxGP.AutoSize = true;
            this.checkBoxGP.Location = new System.Drawing.Point(154, 120);
            this.checkBoxGP.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxGP.Name = "checkBoxGP";
            this.checkBoxGP.Size = new System.Drawing.Size(175, 21);
            this.checkBoxGP.TabIndex = 10;
            this.checkBoxGP.Text = "include  se_avg (2001)";
            this.checkBoxGP.UseVisualStyleBackColor = true;
            // 
            // checkBoxMpoll
            // 
            this.checkBoxMpoll.AutoSize = true;
            this.checkBoxMpoll.Location = new System.Drawing.Point(154, 146);
            this.checkBoxMpoll.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxMpoll.Name = "checkBoxMpoll";
            this.checkBoxMpoll.Size = new System.Drawing.Size(236, 21);
            this.checkBoxMpoll.TabIndex = 9;
            this.checkBoxMpoll.Text = "include monthly 30 year average";
            this.checkBoxMpoll.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(465, 15);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(47, 24);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = ">";
            this.toolTip1.SetToolTip(this.buttonNext, "advance to next site");
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSelectGroup
            // 
            this.buttonSelectGroup.AutoEllipsis = true;
            this.buttonSelectGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectGroup.Location = new System.Drawing.Point(9, 16);
            this.buttonSelectGroup.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSelectGroup.Name = "buttonSelectGroup";
            this.buttonSelectGroup.Size = new System.Drawing.Size(139, 24);
            this.buttonSelectGroup.TabIndex = 7;
            this.buttonSelectGroup.Text = "basin...";
            this.toolTip1.SetToolTip(this.buttonSelectGroup, "select basin or group of sites");
            this.buttonSelectGroup.UseVisualStyleBackColor = true;
            this.buttonSelectGroup.Click += new System.EventHandler(this.buttonSelectGroup_Click);
            // 
            // comboBoxCbtt
            // 
            this.comboBoxCbtt.FormattingEnabled = true;
            this.comboBoxCbtt.Location = new System.Drawing.Point(154, 16);
            this.comboBoxCbtt.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCbtt.Name = "comboBoxCbtt";
            this.comboBoxCbtt.Size = new System.Drawing.Size(301, 24);
            this.comboBoxCbtt.TabIndex = 6;
            this.comboBoxCbtt.Text = "JKPI";
            this.toolTip1.SetToolTip(this.comboBoxCbtt, "enter cbtt such as \'JKPI\'");
            this.comboBoxCbtt.SelectedIndexChanged += new System.EventHandler(this.comboBoxCbtt_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(465, 50);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(79, 55);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxPcode
            // 
            this.comboBoxPcode.FormattingEnabled = true;
            this.comboBoxPcode.Items.AddRange(new object[] {
            "Snow",
            "Storage",
            "Flow",
            "Precipitation",
            "AF",
            "QD",
            "QU"});
            this.comboBoxPcode.Location = new System.Drawing.Point(154, 50);
            this.comboBoxPcode.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxPcode.Name = "comboBoxPcode";
            this.comboBoxPcode.Size = new System.Drawing.Size(301, 24);
            this.comboBoxPcode.TabIndex = 4;
            this.comboBoxPcode.Text = "Snow";
            this.toolTip1.SetToolTip(this.comboBoxPcode, "enter parameter code");
            // 
            // monthRangePicker1
            // 
            this.monthRangePicker1.AutoSize = true;
            this.monthRangePicker1.BeginningMonth = 10;
            this.monthRangePicker1.Location = new System.Drawing.Point(620, 43);
            this.monthRangePicker1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.monthRangePicker1.MonthDayRange = monthDayRange1;
            this.monthRangePicker1.Name = "monthRangePicker1";
            this.monthRangePicker1.Size = new System.Drawing.Size(769, 73);
            this.monthRangePicker1.TabIndex = 1;
            // 
            // yearSelector1
            // 
            this.yearSelector1.Location = new System.Drawing.Point(621, 10);
            this.yearSelector1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.yearSelector1.Name = "yearSelector1";
            this.yearSelector1.SelectedYears = new int[] { 2001, 2005 };


            this.yearSelector1.Size = new System.Drawing.Size(428, 31);
            this.yearSelector1.TabIndex = 2;
            // 
            // timeSeriesGraph1
            // 
            this.timeSeriesGraph1.AnnotationOnMouseMove = false;
            this.timeSeriesGraph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeSeriesGraph1.GraphSettings = graphSettings2;
            this.timeSeriesGraph1.Location = new System.Drawing.Point(0, 131);
            this.timeSeriesGraph1.Margin = new System.Windows.Forms.Padding(4);
            this.timeSeriesGraph1.MissingDataValue = -999D;
            this.timeSeriesGraph1.MonthlySummaryMultiYear = false;
            this.timeSeriesGraph1.MultiLeftAxis = false;
            this.timeSeriesGraph1.Name = "timeSeriesGraph1";
            this.timeSeriesGraph1.Size = new System.Drawing.Size(732, 296);
            this.timeSeriesGraph1.SubTitle = "";
            this.timeSeriesGraph1.TabIndex = 1;
            this.timeSeriesGraph1.Title = "";
            // 
            // textBoxMultiple
            // 
            this.textBoxMultiple.Location = new System.Drawing.Point(154, 83);
            this.textBoxMultiple.Name = "textBoxMultiple";
            this.textBoxMultiple.Size = new System.Drawing.Size(301, 22);
            this.textBoxMultiple.TabIndex = 15;
            this.textBoxMultiple.Enabled = false;
            // 
            // checkBoxUseList
            // 
            this.checkBoxUseList.AutoSize = true;
            this.checkBoxUseList.Location = new System.Drawing.Point(49, 83);
            this.checkBoxUseList.Name = "checkBoxUseList";
            this.checkBoxUseList.Size = new System.Drawing.Size(81, 21);
            this.checkBoxUseList.TabIndex = 16;
            this.checkBoxUseList.Text = "Use List";
            this.checkBoxUseList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUseList.UseVisualStyleBackColor = true;
            this.checkBoxUseList.CheckedChanged += new System.EventHandler(this.useList_CheckedChanged);
            // 
            // SnowGG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeSeriesGraph1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SnowGG";
            this.Size = new System.Drawing.Size(1323, 729);
            this.Load += new System.EventHandler(this.SnowGG_Load);
            this.VisibleChanged += new System.EventHandler(this.SnowGG_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Reclamation.TimeSeries.Forms.YearSelector yearSelector1;
        private Reclamation.TimeSeries.Forms.MonthRangePicker monthRangePicker1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox comboBoxPcode;
        private System.Windows.Forms.ToolTip toolTip1;
        private Reclamation.TimeSeries.Graphing.TimeSeriesTeeChartGraph timeSeriesGraph1;
        private System.Windows.Forms.ComboBox comboBoxCbtt;
        private System.Windows.Forms.Button buttonSelectGroup;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.CheckBox checkBoxMpoll;
        private System.Windows.Forms.CheckBox checkBoxGP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAvg;
        private System.Windows.Forms.CheckBox checkBoxMax;
        private System.Windows.Forms.CheckBox checkBoxMin;
        private System.Windows.Forms.TextBox textBoxWY2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWY1;
        private System.Windows.Forms.CheckBox checkBoxAnnotate;
        private System.Windows.Forms.TextBox textBoxPctls;
        private System.Windows.Forms.CheckBox checkBoxPctls;
        private System.Windows.Forms.CheckBox checkBoxDeltas;
        private System.Windows.Forms.TextBox textBoxMultiple;
        private System.Windows.Forms.CheckBox checkBoxUseList;

    }
}
