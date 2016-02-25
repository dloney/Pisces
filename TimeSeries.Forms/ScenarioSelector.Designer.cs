namespace Reclamation.TimeSeries.Forms
{
    partial class ScenarioSelector
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSelectMid20P = new System.Windows.Forms.Button();
            this.buttonSelectLow20P = new System.Windows.Forms.Button();
            this.buttonSelectTop20P = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.linkLabelCustomize = new System.Windows.Forms.LinkLabel();
            this.groupBoxCustomize = new System.Windows.Forms.GroupBox();
            this.labelCustomInfo = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxIncludeSelected = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeBaseline = new System.Windows.Forms.CheckBox();
            this.checkBoxSubtractFromBaseline = new System.Windows.Forms.CheckBox();
            this.checkBoxMerge = new System.Windows.Forms.CheckBox();
            this.groupBoxComparisonn = new System.Windows.Forms.GroupBox();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.groupBoxSorting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelSortOrder = new System.Windows.Forms.LinkLabel();
            this.comboBoxAvailableSeries = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxCustomize.SuspendLayout();
            this.groupBoxComparisonn.SuspendLayout();
            this.groupBoxAll.SuspendLayout();
            this.groupBoxSorting.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(234, 555);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.buttonSelectMid20P);
            this.groupBox1.Controls.Add(this.buttonSelectLow20P);
            this.groupBox1.Controls.Add(this.buttonSelectTop20P);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.buttonClearAll);
            this.groupBox1.Controls.Add(this.buttonSelectAll);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 448);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Scenarios";
            // 
            // buttonSelectMid20P
            // 
            this.buttonSelectMid20P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectMid20P.Location = new System.Drawing.Point(258, 14);
            this.buttonSelectMid20P.Name = "buttonSelectMid20P";
            this.buttonSelectMid20P.Size = new System.Drawing.Size(97, 23);
            this.buttonSelectMid20P.TabIndex = 20;
            this.buttonSelectMid20P.Text = "Select Mid 20%";
            this.buttonSelectMid20P.UseVisualStyleBackColor = true;
            this.buttonSelectMid20P.Click += new System.EventHandler(this.buttonSelectMid20P_Click);
            // 
            // buttonSelectLow20P
            // 
            this.buttonSelectLow20P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectLow20P.Location = new System.Drawing.Point(361, 14);
            this.buttonSelectLow20P.Name = "buttonSelectLow20P";
            this.buttonSelectLow20P.Size = new System.Drawing.Size(97, 23);
            this.buttonSelectLow20P.TabIndex = 19;
            this.buttonSelectLow20P.Text = "Select Low 20%";
            this.buttonSelectLow20P.UseVisualStyleBackColor = true;
            this.buttonSelectLow20P.Click += new System.EventHandler(this.buttonSelectLow20P_Click);
            // 
            // buttonSelectTop20P
            // 
            this.buttonSelectTop20P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectTop20P.Location = new System.Drawing.Point(155, 14);
            this.buttonSelectTop20P.Name = "buttonSelectTop20P";
            this.buttonSelectTop20P.Size = new System.Drawing.Size(97, 23);
            this.buttonSelectTop20P.TabIndex = 18;
            this.buttonSelectTop20P.Text = "Select Top 20%";
            this.buttonSelectTop20P.UseVisualStyleBackColor = true;
            this.buttonSelectTop20P.Click += new System.EventHandler(this.buttonSelectTop20P_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 402);
            this.dataGridView1.TabIndex = 17;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAll.Location = new System.Drawing.Point(73, 14);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(76, 23);
            this.buttonClearAll.TabIndex = 15;
            this.buttonClearAll.Text = "Select None";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectAll.Location = new System.Drawing.Point(4, 14);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(63, 23);
            this.buttonSelectAll.TabIndex = 14;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // linkLabelCustomize
            // 
            this.linkLabelCustomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelCustomize.AutoSize = true;
            this.linkLabelCustomize.Location = new System.Drawing.Point(248, 9);
            this.linkLabelCustomize.Name = "linkLabelCustomize";
            this.linkLabelCustomize.Size = new System.Drawing.Size(54, 13);
            this.linkLabelCustomize.TabIndex = 14;
            this.linkLabelCustomize.TabStop = true;
            this.linkLabelCustomize.Text = "customize";
            this.linkLabelCustomize.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CustomizeClicked);
            // 
            // groupBoxCustomize
            // 
            this.groupBoxCustomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustomize.Controls.Add(this.labelCustomInfo);
            this.groupBoxCustomize.Controls.Add(this.linkLabelCustomize);
            this.groupBoxCustomize.Location = new System.Drawing.Point(180, 0);
            this.groupBoxCustomize.Name = "groupBoxCustomize";
            this.groupBoxCustomize.Size = new System.Drawing.Size(308, 43);
            this.groupBoxCustomize.TabIndex = 15;
            this.groupBoxCustomize.TabStop = false;
            // 
            // labelCustomInfo
            // 
            this.labelCustomInfo.AutoSize = true;
            this.labelCustomInfo.Location = new System.Drawing.Point(7, 13);
            this.labelCustomInfo.Name = "labelCustomInfo";
            this.labelCustomInfo.Size = new System.Drawing.Size(0, 13);
            this.labelCustomInfo.TabIndex = 15;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(406, 555);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 16;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(319, 555);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxIncludeSelected
            // 
            this.checkBoxIncludeSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxIncludeSelected.AutoSize = true;
            this.checkBoxIncludeSelected.Enabled = false;
            this.checkBoxIncludeSelected.Location = new System.Drawing.Point(23, 45);
            this.checkBoxIncludeSelected.Name = "checkBoxIncludeSelected";
            this.checkBoxIncludeSelected.Size = new System.Drawing.Size(103, 17);
            this.checkBoxIncludeSelected.TabIndex = 20;
            this.checkBoxIncludeSelected.Text = "include selected";
            this.toolTip1.SetToolTip(this.checkBoxIncludeSelected, "baseline is the first scenario in this list");
            this.checkBoxIncludeSelected.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeBaseline
            // 
            this.checkBoxIncludeBaseline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxIncludeBaseline.AutoSize = true;
            this.checkBoxIncludeBaseline.Enabled = false;
            this.checkBoxIncludeBaseline.Location = new System.Drawing.Point(23, 28);
            this.checkBoxIncludeBaseline.Name = "checkBoxIncludeBaseline";
            this.checkBoxIncludeBaseline.Size = new System.Drawing.Size(102, 17);
            this.checkBoxIncludeBaseline.TabIndex = 19;
            this.checkBoxIncludeBaseline.Text = "include baseline";
            this.toolTip1.SetToolTip(this.checkBoxIncludeBaseline, "baseline is the first scenario in this list");
            this.checkBoxIncludeBaseline.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubtractFromBaseline
            // 
            this.checkBoxSubtractFromBaseline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSubtractFromBaseline.AutoSize = true;
            this.checkBoxSubtractFromBaseline.Location = new System.Drawing.Point(7, 13);
            this.checkBoxSubtractFromBaseline.Name = "checkBoxSubtractFromBaseline";
            this.checkBoxSubtractFromBaseline.Size = new System.Drawing.Size(106, 17);
            this.checkBoxSubtractFromBaseline.TabIndex = 18;
            this.checkBoxSubtractFromBaseline.Text = "subtract baseline";
            this.toolTip1.SetToolTip(this.checkBoxSubtractFromBaseline, "baseline is the first scenario in this list");
            this.checkBoxSubtractFromBaseline.UseVisualStyleBackColor = true;
            this.checkBoxSubtractFromBaseline.CheckedChanged += new System.EventHandler(this.checkBoxSubtractFromBaseline_CheckedChanged);
            // 
            // checkBoxMerge
            // 
            this.checkBoxMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMerge.AutoSize = true;
            this.checkBoxMerge.Location = new System.Drawing.Point(7, 62);
            this.checkBoxMerge.Name = "checkBoxMerge";
            this.checkBoxMerge.Size = new System.Drawing.Size(103, 17);
            this.checkBoxMerge.TabIndex = 25;
            this.checkBoxMerge.Text = "merge scenarios";
            this.toolTip1.SetToolTip(this.checkBoxMerge, "For operational model runs, less than one year traces, merges data into a single " +
        "series.  Only valid if you select a single series in the tree.");
            this.checkBoxMerge.UseVisualStyleBackColor = true;
            // 
            // groupBoxComparisonn
            // 
            this.groupBoxComparisonn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxComparisonn.Controls.Add(this.checkBoxIncludeSelected);
            this.groupBoxComparisonn.Controls.Add(this.checkBoxMerge);
            this.groupBoxComparisonn.Controls.Add(this.checkBoxIncludeBaseline);
            this.groupBoxComparisonn.Controls.Add(this.checkBoxSubtractFromBaseline);
            this.groupBoxComparisonn.Location = new System.Drawing.Point(11, 460);
            this.groupBoxComparisonn.Name = "groupBoxComparisonn";
            this.groupBoxComparisonn.Size = new System.Drawing.Size(149, 83);
            this.groupBoxComparisonn.TabIndex = 24;
            this.groupBoxComparisonn.TabStop = false;
            this.groupBoxComparisonn.Text = "comparison";
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAll.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxAll.Controls.Add(this.groupBoxSorting);
            this.groupBoxAll.Controls.Add(this.groupBox1);
            this.groupBoxAll.Controls.Add(this.groupBoxComparisonn);
            this.groupBoxAll.Location = new System.Drawing.Point(2, 0);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(494, 549);
            this.groupBoxAll.TabIndex = 25;
            this.groupBoxAll.TabStop = false;
            // 
            // groupBoxSorting
            // 
            this.groupBoxSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSorting.Controls.Add(this.label1);
            this.groupBoxSorting.Controls.Add(this.comboBoxAvailableSeries);
            this.groupBoxSorting.Location = new System.Drawing.Point(166, 460);
            this.groupBoxSorting.Name = "groupBoxSorting";
            this.groupBoxSorting.Size = new System.Drawing.Size(319, 83);
            this.groupBoxSorting.TabIndex = 26;
            this.groupBoxSorting.TabStop = false;
            this.groupBoxSorting.Text = "sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "sort by:";
            // 
            // linkLabelSortOrder
            // 
            this.linkLabelSortOrder.AutoSize = true;
            this.linkLabelSortOrder.Location = new System.Drawing.Point(5, 565);
            this.linkLabelSortOrder.Name = "linkLabelSortOrder";
            this.linkLabelSortOrder.Size = new System.Drawing.Size(123, 13);
            this.linkLabelSortOrder.TabIndex = 18;
            this.linkLabelSortOrder.TabStop = true;
            this.linkLabelSortOrder.Text = "sort scenarios by volume";
            this.linkLabelSortOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSortOrder_LinkClicked);
            // 
            // comboBoxAvailableSeries
            // 
            this.comboBoxAvailableSeries.FormattingEnabled = true;
            this.comboBoxAvailableSeries.Location = new System.Drawing.Point(53, 12);
            this.comboBoxAvailableSeries.Name = "comboBoxAvailableSeries";
            this.comboBoxAvailableSeries.Size = new System.Drawing.Size(256, 21);
            this.comboBoxAvailableSeries.TabIndex = 0;
            // 
            // ScenarioSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 587);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.linkLabelSortOrder);
            this.Controls.Add(this.groupBoxAll);
            this.Controls.Add(this.groupBoxCustomize);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 625);
            this.Name = "ScenarioSelector";
            this.Text = "Scenarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScenarioSelector_FormClosing);
            this.Load += new System.EventHandler(this.ScenarioSelector_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxCustomize.ResumeLayout(false);
            this.groupBoxCustomize.PerformLayout();
            this.groupBoxComparisonn.ResumeLayout(false);
            this.groupBoxComparisonn.PerformLayout();
            this.groupBoxAll.ResumeLayout(false);
            this.groupBoxSorting.ResumeLayout(false);
            this.groupBoxSorting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabelCustomize;
        private System.Windows.Forms.GroupBox groupBoxCustomize;
        private System.Windows.Forms.Label labelCustomInfo;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBoxComparisonn;
        private System.Windows.Forms.CheckBox checkBoxIncludeSelected;
        private System.Windows.Forms.CheckBox checkBoxIncludeBaseline;
        private System.Windows.Forms.CheckBox checkBoxSubtractFromBaseline;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.LinkLabel linkLabelSortOrder;
        private System.Windows.Forms.CheckBox checkBoxMerge;
        private System.Windows.Forms.GroupBox groupBoxSorting;
        private System.Windows.Forms.ComboBox comboBoxAvailableSeries;
        private System.Windows.Forms.Button buttonSelectMid20P;
        private System.Windows.Forms.Button buttonSelectLow20P;
        private System.Windows.Forms.Button buttonSelectTop20P;
        private System.Windows.Forms.Label label1;
    }
}