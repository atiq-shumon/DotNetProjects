namespace AH.ModuleController.UI.IPD.Reports.ParameterForms
{
    partial class frmIPDReportManager
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
            this.rdoDeathCertificate = new AtiqsControlLibrary.SmartRadioButton();
            this.rdAdmittedReportList = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDischargeDetailsBillRpt = new AtiqsControlLibrary.SmartRadioButton();
            this.rdAdmissionCard = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoReadvanceMoneyRcpt = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDischargeBillSummaryReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoMoneyReceiptReport = new AtiqsControlLibrary.SmartRadioButton();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.txtRegistrationId = new AtiqsControlLibrary.SmartTextBox();
            this.lblDischargeBillDetailReport = new AtiqsControlLibrary.SmartLabel();
            this.txtAdmissionCard = new AtiqsControlLibrary.SmartTextBox();
            this.lblAdmissionCard = new AtiqsControlLibrary.SmartLabel();
            this.txtTransNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtReg_ID = new AtiqsControlLibrary.SmartTextBox();
            this.txtMoneyReceiptNo = new AtiqsControlLibrary.SmartTextBox();
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
            this.rdoBirthCertificate = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbReportOption.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(659, 426);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(545, 426);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(303, 7);
            this.frmLabel.Size = new System.Drawing.Size(161, 32);
            this.frmLabel.Text = "IPD Reports";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.gbReportOption);
            this.pnlMain.Location = new System.Drawing.Point(-1, 50);
            this.pnlMain.Size = new System.Drawing.Size(773, 370);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(771, 51);
            // 
            // gbReportOption
            // 
            this.gbReportOption.Controls.Add(this.rdoBirthCertificate);
            this.gbReportOption.Controls.Add(this.rdoDeathCertificate);
            this.gbReportOption.Controls.Add(this.rdAdmittedReportList);
            this.gbReportOption.Controls.Add(this.rdoDischargeDetailsBillRpt);
            this.gbReportOption.Controls.Add(this.rdAdmissionCard);
            this.gbReportOption.Controls.Add(this.rdoReadvanceMoneyRcpt);
            this.gbReportOption.Controls.Add(this.rdoDischargeBillSummaryReport);
            this.gbReportOption.Controls.Add(this.rdoMoneyReceiptReport);
            this.gbReportOption.Location = new System.Drawing.Point(8, 15);
            this.gbReportOption.Name = "gbReportOption";
            this.gbReportOption.Size = new System.Drawing.Size(291, 323);
            this.gbReportOption.TabIndex = 8;
            this.gbReportOption.TabStop = false;
            this.gbReportOption.Text = "Report Option";
            // 
            // rdoDeathCertificate
            // 
            this.rdoDeathCertificate.AutoSize = true;
            this.rdoDeathCertificate.BackColor = System.Drawing.Color.Transparent;
            this.rdoDeathCertificate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDeathCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDeathCertificate.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDeathCertificate.ForeColor = System.Drawing.Color.Gray;
            this.rdoDeathCertificate.Location = new System.Drawing.Point(8, 283);
            this.rdoDeathCertificate.Name = "rdoDeathCertificate";
            this.rdoDeathCertificate.Size = new System.Drawing.Size(137, 22);
            this.rdoDeathCertificate.TabIndex = 20;
            this.rdoDeathCertificate.Text = "Death Certificate";
            this.rdoDeathCertificate.UseVisualStyleBackColor = false;
            this.rdoDeathCertificate.CheckedChanged += new System.EventHandler(this.rdoDeathCertificate_CheckedChanged);
            // 
            // rdAdmittedReportList
            // 
            this.rdAdmittedReportList.AutoSize = true;
            this.rdAdmittedReportList.BackColor = System.Drawing.Color.Transparent;
            this.rdAdmittedReportList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdAdmittedReportList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdAdmittedReportList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdAdmittedReportList.ForeColor = System.Drawing.Color.Gray;
            this.rdAdmittedReportList.Location = new System.Drawing.Point(8, 222);
            this.rdAdmittedReportList.Name = "rdAdmittedReportList";
            this.rdAdmittedReportList.Size = new System.Drawing.Size(214, 22);
            this.rdAdmittedReportList.TabIndex = 19;
            this.rdAdmittedReportList.Text = "Admitted Patient Report List";
            this.rdAdmittedReportList.UseVisualStyleBackColor = false;
            this.rdAdmittedReportList.CheckedChanged += new System.EventHandler(this.rdAdmittedReportList_CheckedChanged);
            // 
            // rdoDischargeDetailsBillRpt
            // 
            this.rdoDischargeDetailsBillRpt.AutoSize = true;
            this.rdoDischargeDetailsBillRpt.BackColor = System.Drawing.Color.Transparent;
            this.rdoDischargeDetailsBillRpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDischargeDetailsBillRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDischargeDetailsBillRpt.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDischargeDetailsBillRpt.ForeColor = System.Drawing.Color.Gray;
            this.rdoDischargeDetailsBillRpt.Location = new System.Drawing.Point(8, 182);
            this.rdoDischargeDetailsBillRpt.Name = "rdoDischargeDetailsBillRpt";
            this.rdoDischargeDetailsBillRpt.Size = new System.Drawing.Size(215, 22);
            this.rdoDischargeDetailsBillRpt.TabIndex = 18;
            this.rdoDischargeDetailsBillRpt.Text = "Discharge Details Bill Report";
            this.rdoDischargeDetailsBillRpt.UseVisualStyleBackColor = false;
            this.rdoDischargeDetailsBillRpt.CheckedChanged += new System.EventHandler(this.rdoDischargeDetailsBillRpt_CheckedChanged);
            // 
            // rdAdmissionCard
            // 
            this.rdAdmissionCard.AutoSize = true;
            this.rdAdmissionCard.BackColor = System.Drawing.Color.Transparent;
            this.rdAdmissionCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdAdmissionCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdAdmissionCard.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdAdmissionCard.ForeColor = System.Drawing.Color.Gray;
            this.rdAdmissionCard.Location = new System.Drawing.Point(8, 141);
            this.rdAdmissionCard.Name = "rdAdmissionCard";
            this.rdAdmissionCard.Size = new System.Drawing.Size(130, 22);
            this.rdAdmissionCard.TabIndex = 17;
            this.rdAdmissionCard.Text = "Admission Card";
            this.rdAdmissionCard.UseVisualStyleBackColor = false;
            this.rdAdmissionCard.CheckedChanged += new System.EventHandler(this.rdAdmissionCard_CheckedChanged);
            // 
            // rdoReadvanceMoneyRcpt
            // 
            this.rdoReadvanceMoneyRcpt.AutoSize = true;
            this.rdoReadvanceMoneyRcpt.BackColor = System.Drawing.Color.Transparent;
            this.rdoReadvanceMoneyRcpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoReadvanceMoneyRcpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoReadvanceMoneyRcpt.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoReadvanceMoneyRcpt.ForeColor = System.Drawing.Color.Gray;
            this.rdoReadvanceMoneyRcpt.Location = new System.Drawing.Point(6, 97);
            this.rdoReadvanceMoneyRcpt.Name = "rdoReadvanceMoneyRcpt";
            this.rdoReadvanceMoneyRcpt.Size = new System.Drawing.Size(252, 22);
            this.rdoReadvanceMoneyRcpt.TabIndex = 16;
            this.rdoReadvanceMoneyRcpt.Text = "ReAdvance Money Receipt Report";
            this.rdoReadvanceMoneyRcpt.UseVisualStyleBackColor = false;
            this.rdoReadvanceMoneyRcpt.CheckedChanged += new System.EventHandler(this.rdoReadvanceMoneyRcpt_CheckedChanged);
            // 
            // rdoDischargeBillSummaryReport
            // 
            this.rdoDischargeBillSummaryReport.AutoSize = true;
            this.rdoDischargeBillSummaryReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoDischargeBillSummaryReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDischargeBillSummaryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDischargeBillSummaryReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDischargeBillSummaryReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoDischargeBillSummaryReport.Location = new System.Drawing.Point(6, 55);
            this.rdoDischargeBillSummaryReport.Name = "rdoDischargeBillSummaryReport";
            this.rdoDischargeBillSummaryReport.Size = new System.Drawing.Size(237, 22);
            this.rdoDischargeBillSummaryReport.TabIndex = 15;
            this.rdoDischargeBillSummaryReport.Text = "Discharge Bill Summary Report";
            this.rdoDischargeBillSummaryReport.UseVisualStyleBackColor = false;
            this.rdoDischargeBillSummaryReport.CheckedChanged += new System.EventHandler(this.rdoDischargeBillSummaryReport_CheckedChanged);
            // 
            // rdoMoneyReceiptReport
            // 
            this.rdoMoneyReceiptReport.AutoSize = true;
            this.rdoMoneyReceiptReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoMoneyReceiptReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMoneyReceiptReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMoneyReceiptReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoMoneyReceiptReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoMoneyReceiptReport.Location = new System.Drawing.Point(6, 19);
            this.rdoMoneyReceiptReport.Name = "rdoMoneyReceiptReport";
            this.rdoMoneyReceiptReport.Size = new System.Drawing.Size(173, 22);
            this.rdoMoneyReceiptReport.TabIndex = 14;
            this.rdoMoneyReceiptReport.Text = "Money Receipt Report";
            this.rdoMoneyReceiptReport.UseVisualStyleBackColor = false;
            this.rdoMoneyReceiptReport.CheckedChanged += new System.EventHandler(this.rdoMoneyReceiptReport_CheckedChanged);
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.txtRegistrationId);
            this.gbInformationControlls.Controls.Add(this.lblDischargeBillDetailReport);
            this.gbInformationControlls.Controls.Add(this.txtAdmissionCard);
            this.gbInformationControlls.Controls.Add(this.lblAdmissionCard);
            this.gbInformationControlls.Controls.Add(this.txtTransNo);
            this.gbInformationControlls.Controls.Add(this.txtReg_ID);
            this.gbInformationControlls.Controls.Add(this.txtMoneyReceiptNo);
            this.gbInformationControlls.Controls.Add(this.lblParam1);
            this.gbInformationControlls.Controls.Add(this.lblParam3);
            this.gbInformationControlls.Controls.Add(this.lblParam2);
            this.gbInformationControlls.Location = new System.Drawing.Point(320, 16);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(432, 201);
            this.gbInformationControlls.TabIndex = 15;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // txtRegistrationId
            // 
            this.txtRegistrationId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationId.Location = new System.Drawing.Point(135, 168);
            this.txtRegistrationId.MaxLength = 11;
            this.txtRegistrationId.Name = "txtRegistrationId";
            this.txtRegistrationId.Size = new System.Drawing.Size(260, 24);
            this.txtRegistrationId.TabIndex = 12;
            this.txtRegistrationId.TextChanged += new System.EventHandler(this.txtRegistrationId_TextChanged);
            this.txtRegistrationId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRegistrationId_KeyUp);
            this.txtRegistrationId.Leave += new System.EventHandler(this.txtRegistrationId_Leave);
            // 
            // lblDischargeBillDetailReport
            // 
            this.lblDischargeBillDetailReport.AutoSize = true;
            this.lblDischargeBillDetailReport.BackColor = System.Drawing.Color.Transparent;
            this.lblDischargeBillDetailReport.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDischargeBillDetailReport.Location = new System.Drawing.Point(16, 171);
            this.lblDischargeBillDetailReport.Name = "lblDischargeBillDetailReport";
            this.lblDischargeBillDetailReport.Size = new System.Drawing.Size(50, 15);
            this.lblDischargeBillDetailReport.TabIndex = 11;
            this.lblDischargeBillDetailReport.Text = "Param4";
            // 
            // txtAdmissionCard
            // 
            this.txtAdmissionCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdmissionCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmissionCard.Location = new System.Drawing.Point(135, 132);
            this.txtAdmissionCard.MaxLength = 11;
            this.txtAdmissionCard.Name = "txtAdmissionCard";
            this.txtAdmissionCard.Size = new System.Drawing.Size(260, 24);
            this.txtAdmissionCard.TabIndex = 10;
            this.txtAdmissionCard.TextChanged += new System.EventHandler(this.txtAdmissionCard_TextChanged);
            this.txtAdmissionCard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAdmissionCard_KeyUp);
            this.txtAdmissionCard.Leave += new System.EventHandler(this.txtAdmissionCard_Leave);
            // 
            // lblAdmissionCard
            // 
            this.lblAdmissionCard.AutoSize = true;
            this.lblAdmissionCard.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmissionCard.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAdmissionCard.Location = new System.Drawing.Point(16, 135);
            this.lblAdmissionCard.Name = "lblAdmissionCard";
            this.lblAdmissionCard.Size = new System.Drawing.Size(50, 15);
            this.lblAdmissionCard.TabIndex = 9;
            this.lblAdmissionCard.Text = "Param3";
            // 
            // txtTransNo
            // 
            this.txtTransNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransNo.Location = new System.Drawing.Point(135, 95);
            this.txtTransNo.MaxLength = 11;
            this.txtTransNo.Name = "txtTransNo";
            this.txtTransNo.Size = new System.Drawing.Size(260, 24);
            this.txtTransNo.TabIndex = 8;
            this.txtTransNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTransNo_KeyUp);
            this.txtTransNo.Leave += new System.EventHandler(this.txtTransNo_Leave);
            // 
            // txtReg_ID
            // 
            this.txtReg_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReg_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReg_ID.Location = new System.Drawing.Point(135, 57);
            this.txtReg_ID.MaxLength = 11;
            this.txtReg_ID.Name = "txtReg_ID";
            this.txtReg_ID.Size = new System.Drawing.Size(260, 24);
            this.txtReg_ID.TabIndex = 7;
            this.txtReg_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtReg_ID_KeyUp);
            this.txtReg_ID.Leave += new System.EventHandler(this.txtReg_ID_Leave);
            // 
            // txtMoneyReceiptNo
            // 
            this.txtMoneyReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyReceiptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyReceiptNo.Location = new System.Drawing.Point(135, 23);
            this.txtMoneyReceiptNo.MaxLength = 11;
            this.txtMoneyReceiptNo.Name = "txtMoneyReceiptNo";
            this.txtMoneyReceiptNo.Size = new System.Drawing.Size(260, 24);
            this.txtMoneyReceiptNo.TabIndex = 6;
            this.txtMoneyReceiptNo.TextChanged += new System.EventHandler(this.txtMoneyReceiptNo_TextChanged);
            this.txtMoneyReceiptNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMoneyReceiptNo_KeyUp);
            this.txtMoneyReceiptNo.Leave += new System.EventHandler(this.txtMoneyReceiptNo_Leave);
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(16, 24);
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
            this.lblParam3.Location = new System.Drawing.Point(16, 98);
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
            this.lblParam2.Location = new System.Drawing.Point(16, 61);
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
            this.gbDateRange.Location = new System.Drawing.Point(320, 223);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(432, 114);
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
            // rdoBirthCertificate
            // 
            this.rdoBirthCertificate.AutoSize = true;
            this.rdoBirthCertificate.BackColor = System.Drawing.Color.Transparent;
            this.rdoBirthCertificate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBirthCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoBirthCertificate.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoBirthCertificate.ForeColor = System.Drawing.Color.Gray;
            this.rdoBirthCertificate.Location = new System.Drawing.Point(8, 255);
            this.rdoBirthCertificate.Name = "rdoBirthCertificate";
            this.rdoBirthCertificate.Size = new System.Drawing.Size(131, 22);
            this.rdoBirthCertificate.TabIndex = 21;
            this.rdoBirthCertificate.Text = "Birth Certificate";
            this.rdoBirthCertificate.UseVisualStyleBackColor = false;
            this.rdoBirthCertificate.CheckedChanged += new System.EventHandler(this.rdoBirthCertificate_CheckedChanged);
            // 
            // frmIPDReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(771, 491);
            this.Name = "frmIPDReportManager";
            this.Load += new System.EventHandler(this.frmIPDReportManager_Load);
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
        private AtiqsControlLibrary.SmartRadioButton rdoMoneyReceiptReport;
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
        private AtiqsControlLibrary.SmartRadioButton rdoDischargeBillSummaryReport;
        private AtiqsControlLibrary.SmartRadioButton rdoReadvanceMoneyRcpt;
        private AtiqsControlLibrary.SmartTextBox txtTransNo;
        private AtiqsControlLibrary.SmartTextBox txtReg_ID;
        private AtiqsControlLibrary.SmartTextBox txtMoneyReceiptNo;
        private AtiqsControlLibrary.SmartTextBox txtAdmissionCard;
        private AtiqsControlLibrary.SmartLabel lblAdmissionCard;
        private AtiqsControlLibrary.SmartRadioButton rdAdmissionCard;
        private AtiqsControlLibrary.SmartTextBox txtRegistrationId;
        private AtiqsControlLibrary.SmartLabel lblDischargeBillDetailReport;
        private AtiqsControlLibrary.SmartRadioButton rdoDischargeDetailsBillRpt;
        private AtiqsControlLibrary.SmartRadioButton rdAdmittedReportList;
        private AtiqsControlLibrary.SmartRadioButton rdoDeathCertificate;
        private AtiqsControlLibrary.SmartRadioButton rdoBirthCertificate;
    }
}
