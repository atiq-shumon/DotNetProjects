namespace AH.ModuleController.UI.DRS.Reports.ParameterForms
{
    partial class frmDRSReportManager
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
            this.gbReportOption = new System.Windows.Forms.GroupBox();
            this.rdoBtnMultiColumn = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoCultAndSensiReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdStainReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoSpecimenDet = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoSpecimen = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoInvestigationReport = new AtiqsControlLibrary.SmartRadioButton();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.txt3 = new AtiqsControlLibrary.SmartTextBox();
            this.txtSpecimanNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtMoneyRecNo = new AtiqsControlLibrary.SmartTextBox();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.lblParam3 = new AtiqsControlLibrary.SmartLabel();
            this.lblParam2 = new AtiqsControlLibrary.SmartLabel();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbReportOption.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(583, 441);
            this.btnClose.TabIndex = 14;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(469, 441);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(261, 9);
            this.frmLabel.Size = new System.Drawing.Size(168, 32);
            this.frmLabel.Text = "DRS Reports";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.gbReportOption);
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Size = new System.Drawing.Size(694, 382);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(694, 57);
            // 
            // gbReportOption
            // 
            this.gbReportOption.Controls.Add(this.rdoBtnMultiColumn);
            this.gbReportOption.Controls.Add(this.rdoCultAndSensiReport);
            this.gbReportOption.Controls.Add(this.rdStainReport);
            this.gbReportOption.Controls.Add(this.rdoSpecimenDet);
            this.gbReportOption.Controls.Add(this.rdoSpecimen);
            this.gbReportOption.Controls.Add(this.rdoInvestigationReport);
            this.gbReportOption.Location = new System.Drawing.Point(-1, 15);
            this.gbReportOption.Name = "gbReportOption";
            this.gbReportOption.Size = new System.Drawing.Size(266, 323);
            this.gbReportOption.TabIndex = 8;
            this.gbReportOption.TabStop = false;
            this.gbReportOption.Text = "Report Option";
            // 
            // rdoBtnMultiColumn
            // 
            this.rdoBtnMultiColumn.AutoSize = true;
            this.rdoBtnMultiColumn.BackColor = System.Drawing.Color.Transparent;
            this.rdoBtnMultiColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBtnMultiColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoBtnMultiColumn.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoBtnMultiColumn.ForeColor = System.Drawing.Color.Gray;
            this.rdoBtnMultiColumn.Location = new System.Drawing.Point(6, 208);
            this.rdoBtnMultiColumn.Name = "rdoBtnMultiColumn";
            this.rdoBtnMultiColumn.Size = new System.Drawing.Size(115, 22);
            this.rdoBtnMultiColumn.TabIndex = 19;
            this.rdoBtnMultiColumn.Text = "MultiColumn";
            this.rdoBtnMultiColumn.UseVisualStyleBackColor = false;
            this.rdoBtnMultiColumn.Visible = false;
            this.rdoBtnMultiColumn.CheckedChanged += new System.EventHandler(this.rdoBtnMultiColumn_CheckedChanged);
            // 
            // rdoCultAndSensiReport
            // 
            this.rdoCultAndSensiReport.AutoSize = true;
            this.rdoCultAndSensiReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoCultAndSensiReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoCultAndSensiReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoCultAndSensiReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoCultAndSensiReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoCultAndSensiReport.Location = new System.Drawing.Point(6, 133);
            this.rdoCultAndSensiReport.Name = "rdoCultAndSensiReport";
            this.rdoCultAndSensiReport.Size = new System.Drawing.Size(227, 22);
            this.rdoCultAndSensiReport.TabIndex = 18;
            this.rdoCultAndSensiReport.Text = "Culture And Sensitivity Report";
            this.rdoCultAndSensiReport.UseVisualStyleBackColor = false;
            this.rdoCultAndSensiReport.CheckedChanged += new System.EventHandler(this.rdoCultAndSensiReport_CheckedChanged);
            // 
            // rdStainReport
            // 
            this.rdStainReport.AutoSize = true;
            this.rdStainReport.BackColor = System.Drawing.Color.Transparent;
            this.rdStainReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdStainReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdStainReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdStainReport.ForeColor = System.Drawing.Color.Gray;
            this.rdStainReport.Location = new System.Drawing.Point(6, 98);
            this.rdStainReport.Name = "rdStainReport";
            this.rdStainReport.Size = new System.Drawing.Size(108, 22);
            this.rdStainReport.TabIndex = 17;
            this.rdStainReport.Text = "Stain Report";
            this.rdStainReport.UseVisualStyleBackColor = false;
            this.rdStainReport.CheckedChanged += new System.EventHandler(this.rdStainReport_CheckedChanged);
            // 
            // rdoSpecimenDet
            // 
            this.rdoSpecimenDet.AutoSize = true;
            this.rdoSpecimenDet.BackColor = System.Drawing.Color.Transparent;
            this.rdoSpecimenDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSpecimenDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoSpecimenDet.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoSpecimenDet.ForeColor = System.Drawing.Color.Gray;
            this.rdoSpecimenDet.Location = new System.Drawing.Point(6, 22);
            this.rdoSpecimenDet.Name = "rdoSpecimenDet";
            this.rdoSpecimenDet.Size = new System.Drawing.Size(130, 22);
            this.rdoSpecimenDet.TabIndex = 16;
            this.rdoSpecimenDet.Text = "Print Specimen ";
            this.rdoSpecimenDet.UseVisualStyleBackColor = false;
            this.rdoSpecimenDet.CheckedChanged += new System.EventHandler(this.rdoSpecimenDet_CheckedChanged);
            // 
            // rdoSpecimen
            // 
            this.rdoSpecimen.AutoSize = true;
            this.rdoSpecimen.BackColor = System.Drawing.Color.Transparent;
            this.rdoSpecimen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSpecimen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoSpecimen.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoSpecimen.ForeColor = System.Drawing.Color.Gray;
            this.rdoSpecimen.Location = new System.Drawing.Point(6, 171);
            this.rdoSpecimen.Name = "rdoSpecimen";
            this.rdoSpecimen.Size = new System.Drawing.Size(89, 22);
            this.rdoSpecimen.TabIndex = 15;
            this.rdoSpecimen.Text = "Specimen";
            this.rdoSpecimen.UseVisualStyleBackColor = false;
            this.rdoSpecimen.Visible = false;
            this.rdoSpecimen.CheckedChanged += new System.EventHandler(this.rdoSpecimen_CheckedChanged);
            // 
            // rdoInvestigationReport
            // 
            this.rdoInvestigationReport.AutoSize = true;
            this.rdoInvestigationReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoInvestigationReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoInvestigationReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoInvestigationReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoInvestigationReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoInvestigationReport.Location = new System.Drawing.Point(6, 60);
            this.rdoInvestigationReport.Name = "rdoInvestigationReport";
            this.rdoInvestigationReport.Size = new System.Drawing.Size(162, 22);
            this.rdoInvestigationReport.TabIndex = 14;
            this.rdoInvestigationReport.Text = "Investigation Report";
            this.rdoInvestigationReport.UseVisualStyleBackColor = false;
            this.rdoInvestigationReport.CheckedChanged += new System.EventHandler(this.rdoInvestigationReport_CheckedChanged);
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.txt3);
            this.gbInformationControlls.Controls.Add(this.txtSpecimanNo);
            this.gbInformationControlls.Controls.Add(this.txtMoneyRecNo);
            this.gbInformationControlls.Controls.Add(this.lblParam1);
            this.gbInformationControlls.Controls.Add(this.lblParam3);
            this.gbInformationControlls.Controls.Add(this.lblParam2);
            this.gbInformationControlls.Location = new System.Drawing.Point(265, 15);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(425, 175);
            this.gbInformationControlls.TabIndex = 15;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // txt3
            // 
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(129, 22);
            this.txt3.MaxLength = 11;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(289, 24);
            this.txt3.TabIndex = 8;
            this.txt3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt3_KeyUp);
            this.txt3.Leave += new System.EventHandler(this.txt3_Leave);
            // 
            // txtSpecimanNo
            // 
            this.txtSpecimanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecimanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecimanNo.Location = new System.Drawing.Point(129, 98);
            this.txtSpecimanNo.MaxLength = 11;
            this.txtSpecimanNo.Name = "txtSpecimanNo";
            this.txtSpecimanNo.Size = new System.Drawing.Size(289, 24);
            this.txtSpecimanNo.TabIndex = 7;
            this.txtSpecimanNo.Leave += new System.EventHandler(this.txtSpecimanNo_Leave);
            // 
            // txtMoneyRecNo
            // 
            this.txtMoneyRecNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyRecNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyRecNo.Location = new System.Drawing.Point(129, 60);
            this.txtMoneyRecNo.MaxLength = 11;
            this.txtMoneyRecNo.Name = "txtMoneyRecNo";
            this.txtMoneyRecNo.Size = new System.Drawing.Size(289, 24);
            this.txtMoneyRecNo.TabIndex = 6;
            this.txtMoneyRecNo.Leave += new System.EventHandler(this.txtMoneyRecNo_Leave);
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(6, 61);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(50, 15);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Param1";
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.BackColor = System.Drawing.Color.Transparent;
            this.lblParam3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam3.Location = new System.Drawing.Point(6, 25);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(50, 15);
            this.lblParam3.TabIndex = 4;
            this.lblParam3.Text = "Param3";
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.BackColor = System.Drawing.Color.Transparent;
            this.lblParam2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam2.Location = new System.Drawing.Point(6, 102);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(50, 15);
            this.lblParam2.TabIndex = 4;
            this.lblParam2.Text = "Param2";
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Location = new System.Drawing.Point(265, 224);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(433, 114);
            this.gbDateRange.TabIndex = 16;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "DateRange";
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
            this.cboDateType.Location = new System.Drawing.Point(114, 29);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(300, 26);
            this.cboDateType.TabIndex = 5;
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlDate.Location = new System.Drawing.Point(16, 33);
            this.lvlDate.Name = "lvlDate";
            this.lvlDate.Size = new System.Drawing.Size(70, 15);
            this.lvlDate.TabIndex = 4;
            this.lvlDate.Text = "Date Range";
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(26, 73);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(63, 15);
            this.lvlStartDate.TabIndex = 2;
            this.lvlStartDate.Text = "Start Date";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(232, 73);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(55, 15);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(302, 73);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(112, 24);
            this.dtEndDate.TabIndex = 1;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtStartDate
            // 
            this.dtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(113, 73);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(112, 24);
            this.dtStartDate.TabIndex = 0;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // frmDRSReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(694, 506);
            this.Name = "frmDRSReportManager";
            this.Load += new System.EventHandler(this.frmDRSReportManager_Load);
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
        private AtiqsControlLibrary.SmartRadioButton rdoInvestigationReport;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private AtiqsControlLibrary.SmartLabel lblParam3;
        private AtiqsControlLibrary.SmartLabel lblParam2;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartRadioButton rdoSpecimen;
        private AtiqsControlLibrary.SmartRadioButton rdoSpecimenDet;
        private AtiqsControlLibrary.SmartTextBox txt3;
        private AtiqsControlLibrary.SmartTextBox txtSpecimanNo;
        private AtiqsControlLibrary.SmartTextBox txtMoneyRecNo;
        private AtiqsControlLibrary.SmartRadioButton rdStainReport;
        private AtiqsControlLibrary.SmartRadioButton rdoCultAndSensiReport;
        private AtiqsControlLibrary.SmartRadioButton rdoBtnMultiColumn;
    }
}
