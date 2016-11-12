namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    partial class frmACCMSReportManager
    {
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
            this.gbReportOption = new System.Windows.Forms.GroupBox();
            this.rdoCollectionSummary = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoCollectionDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.cboParam1 = new AtiqsControlLibrary.SmartComboBox();
            this.cboParam3 = new AtiqsControlLibrary.SmartComboBox();
            this.cboParam2 = new AtiqsControlLibrary.SmartComboBox();
            this.lblParam3 = new AtiqsControlLibrary.SmartLabel();
            this.lblParam2 = new AtiqsControlLibrary.SmartLabel();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbReportOption.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(575, 448);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(461, 448);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(319, 32);
            this.frmLabel.Text = "ACCMS Report Manager";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.gbReportOption);
            this.pnlMain.Location = new System.Drawing.Point(-1, 62);
            this.pnlMain.Size = new System.Drawing.Size(752, 383);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(745, 57);
            // 
            // gbReportOption
            // 
            this.gbReportOption.Controls.Add(this.rdoCollectionSummary);
            this.gbReportOption.Controls.Add(this.rdoCollectionDetails);
            this.gbReportOption.Location = new System.Drawing.Point(3, 3);
            this.gbReportOption.Name = "gbReportOption";
            this.gbReportOption.Size = new System.Drawing.Size(197, 351);
            this.gbReportOption.TabIndex = 8;
            this.gbReportOption.TabStop = false;
            this.gbReportOption.Text = "Report Option";
            // 
            // rdoCollectionSummary
            // 
            this.rdoCollectionSummary.AutoSize = true;
            this.rdoCollectionSummary.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoCollectionSummary.ForeColor = System.Drawing.Color.Gray;
            this.rdoCollectionSummary.Location = new System.Drawing.Point(7, 51);
            this.rdoCollectionSummary.Name = "rdoCollectionSummary";
            this.rdoCollectionSummary.Size = new System.Drawing.Size(163, 22);
            this.rdoCollectionSummary.TabIndex = 1;
            this.rdoCollectionSummary.TabStop = true;
            this.rdoCollectionSummary.Text = "Collection Summary";
            this.rdoCollectionSummary.UseVisualStyleBackColor = true;
            // 
            // rdoCollectionDetails
            // 
            this.rdoCollectionDetails.AutoSize = true;
            this.rdoCollectionDetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoCollectionDetails.ForeColor = System.Drawing.Color.Gray;
            this.rdoCollectionDetails.Location = new System.Drawing.Point(7, 22);
            this.rdoCollectionDetails.Name = "rdoCollectionDetails";
            this.rdoCollectionDetails.Size = new System.Drawing.Size(141, 22);
            this.rdoCollectionDetails.TabIndex = 0;
            this.rdoCollectionDetails.TabStop = true;
            this.rdoCollectionDetails.Text = "Collection Details";
            this.rdoCollectionDetails.UseVisualStyleBackColor = true;
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.lblParam1);
            this.gbInformationControlls.Controls.Add(this.cboParam1);
            this.gbInformationControlls.Controls.Add(this.cboParam3);
            this.gbInformationControlls.Controls.Add(this.cboParam2);
            this.gbInformationControlls.Controls.Add(this.lblParam3);
            this.gbInformationControlls.Controls.Add(this.lblParam2);
            this.gbInformationControlls.Location = new System.Drawing.Point(206, 9);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(435, 141);
            this.gbInformationControlls.TabIndex = 10;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(17, 16);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(54, 18);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Param1";
            // 
            // cboParam1
            // 
            this.cboParam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParam1.ForeColor = System.Drawing.Color.Blue;
            this.cboParam1.FormattingEnabled = true;
            this.cboParam1.Items.AddRange(new object[] {
            "03",
            "1",
            "D-01-01-2014-00000071"});
            this.cboParam1.Location = new System.Drawing.Point(122, 16);
            this.cboParam1.Name = "cboParam1";
            this.cboParam1.Size = new System.Drawing.Size(304, 26);
            this.cboParam1.TabIndex = 5;
            // 
            // cboParam3
            // 
            this.cboParam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParam3.ForeColor = System.Drawing.Color.Blue;
            this.cboParam3.FormattingEnabled = true;
            this.cboParam3.Items.AddRange(new object[] {
            "0001"});
            this.cboParam3.Location = new System.Drawing.Point(122, 99);
            this.cboParam3.Name = "cboParam3";
            this.cboParam3.Size = new System.Drawing.Size(304, 26);
            this.cboParam3.TabIndex = 5;
            // 
            // cboParam2
            // 
            this.cboParam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParam2.ForeColor = System.Drawing.Color.Blue;
            this.cboParam2.FormattingEnabled = true;
            this.cboParam2.Items.AddRange(new object[] {
            "0005"});
            this.cboParam2.Location = new System.Drawing.Point(122, 55);
            this.cboParam2.Name = "cboParam2";
            this.cboParam2.Size = new System.Drawing.Size(304, 26);
            this.cboParam2.TabIndex = 5;
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.BackColor = System.Drawing.Color.Transparent;
            this.lblParam3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam3.Location = new System.Drawing.Point(17, 101);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(54, 18);
            this.lblParam3.TabIndex = 4;
            this.lblParam3.Text = "Param3";
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.BackColor = System.Drawing.Color.Transparent;
            this.lblParam2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam2.Location = new System.Drawing.Point(17, 57);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(54, 18);
            this.lblParam2.TabIndex = 4;
            this.lblParam2.Text = "Param2";
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Location = new System.Drawing.Point(206, 169);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(433, 183);
            this.gbDateRange.TabIndex = 11;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "DateRange";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(299, 68);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(125, 26);
            this.dtEndDate.TabIndex = 36;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(103, 68);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(125, 26);
            this.dtStartDate.TabIndex = 35;
            // 
            // cboDateType
            // 
            this.cboDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDateType.ForeColor = System.Drawing.Color.Blue;
            this.cboDateType.FormattingEnabled = true;
            this.cboDateType.Items.AddRange(new object[] {
            "Last One Month",
            "Last Three Month",
            "Last Six Month",
            "Last One Year"});
            this.cboDateType.Location = new System.Drawing.Point(103, 29);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(321, 26);
            this.cboDateType.TabIndex = 5;
            this.cboDateType.SelectedIndexChanged += new System.EventHandler(this.cboDateType_SelectedIndexChanged);
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlDate.Location = new System.Drawing.Point(16, 33);
            this.lvlDate.Name = "lvlDate";
            this.lvlDate.Size = new System.Drawing.Size(78, 18);
            this.lvlDate.TabIndex = 4;
            this.lvlDate.Text = "Date Range";
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(31, 73);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(68, 18);
            this.lvlStartDate.TabIndex = 2;
            this.lvlStartDate.Text = "Start Date";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(232, 73);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(64, 18);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date";
            // 
            // frmACCMSReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(745, 510);
            this.Name = "frmACCMSReportManager";
            this.Load += new System.EventHandler(this.frmACCMSReportManager_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.gbReportOption.ResumeLayout(false);
            this.gbReportOption.PerformLayout();
            this.gbInformationControlls.ResumeLayout(false);
            this.gbInformationControlls.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReportOption;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private AtiqsControlLibrary.SmartComboBox cboParam1;
        private AtiqsControlLibrary.SmartComboBox cboParam3;
        private AtiqsControlLibrary.SmartComboBox cboParam2;
        private AtiqsControlLibrary.SmartLabel lblParam3;
        private AtiqsControlLibrary.SmartLabel lblParam2;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartRadioButton rdoCollectionDetails;
        private AtiqsControlLibrary.SmartRadioButton rdoCollectionSummary;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
    }
}
