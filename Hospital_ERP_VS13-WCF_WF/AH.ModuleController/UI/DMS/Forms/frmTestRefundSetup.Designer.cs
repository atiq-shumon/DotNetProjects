namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmTestRefundSetup
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
            this.txtMRNo = new System.Windows.Forms.TextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtSex = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeHours = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeDays = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeMonths = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblAge = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeYears = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.cboPatientMr = new System.Windows.Forms.Button();
            this.lblMr = new AtiqsControlLibrary.SmartLabel();
            this.lvMRTests = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboCause = new AtiqsControlLibrary.SmartComboBox();
            this.txtMoneyReceiptNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtNetAmount = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtNetPaid = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtReturnAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtPreviousAmount = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshRefund = new System.Windows.Forms.Button();
            this.btnAddCause = new System.Windows.Forms.Button();
            this.txtDueStatus = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(293, 9);
            this.frmLabel.Size = new System.Drawing.Size(245, 33);
            this.frmLabel.Text = "Test Money Refund";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRefreshRefund);
            this.pnlMain.Controls.Add(this.btnAddCause);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtPreviousAmount);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtReturnAmount);
            this.pnlMain.Controls.Add(this.btnCalculate);
            this.pnlMain.Controls.Add(this.txtNetPaid);
            this.pnlMain.Controls.Add(this.txtNetAmount);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.lvMRTests);
            this.pnlMain.Controls.Add(this.cboCause);
            this.pnlMain.Controls.Add(this.txtMRNo);
            this.pnlMain.Controls.Add(this.lblMr);
            this.pnlMain.Controls.Add(this.cboPatientMr);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtPatientName);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtSex);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.txtAgeHours);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtAgeYears);
            this.pnlMain.Controls.Add(this.txtAgeDays);
            this.pnlMain.Controls.Add(this.lblAge);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtAgeMonths);
            this.pnlMain.Size = new System.Drawing.Size(863, 681);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(74, 600);
            this.btnEdit.Size = new System.Drawing.Size(29, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(634, 600);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(106, 600);
            this.btnDelete.Size = new System.Drawing.Size(25, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(521, 600);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(747, 600);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(137, 600);
            this.btnPrint.Size = new System.Drawing.Size(14, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 640);
            // 
            // txtMRNo
            // 
            this.txtMRNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNo.ForeColor = System.Drawing.Color.Red;
            this.txtMRNo.Location = new System.Drawing.Point(11, 170);
            this.txtMRNo.Name = "txtMRNo";
            this.txtMRNo.Size = new System.Drawing.Size(329, 31);
            this.txtMRNo.TabIndex = 154;
            this.txtMRNo.TextChanged += new System.EventHandler(this.txtMRNo_TextChanged);
            this.txtMRNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMRNo_KeyUp);
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(730, 149);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(65, 18);
            this.smartLabel12.TabIndex = 153;
            this.smartLabel12.Text = "Remarks ";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(316, 262);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(30, 18);
            this.smartLabel8.TabIndex = 152;
            this.smartLabel8.Text = "Sex";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSex.Location = new System.Drawing.Point(315, 283);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(87, 24);
            this.txtSex.TabIndex = 151;
            this.txtSex.TabStop = false;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(239, 262);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(51, 18);
            this.smartLabel11.TabIndex = 150;
            this.smartLabel11.Text = "Age(H)";
            // 
            // txtAgeHours
            // 
            this.txtAgeHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtAgeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeHours.Location = new System.Drawing.Point(239, 283);
            this.txtAgeHours.Name = "txtAgeHours";
            this.txtAgeHours.ReadOnly = true;
            this.txtAgeHours.Size = new System.Drawing.Size(65, 24);
            this.txtAgeHours.TabIndex = 149;
            this.txtAgeHours.TabStop = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(163, 262);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(51, 18);
            this.smartLabel9.TabIndex = 148;
            this.smartLabel9.Text = "Age(D)";
            // 
            // txtAgeDays
            // 
            this.txtAgeDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtAgeDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeDays.Location = new System.Drawing.Point(163, 283);
            this.txtAgeDays.Name = "txtAgeDays";
            this.txtAgeDays.ReadOnly = true;
            this.txtAgeDays.Size = new System.Drawing.Size(65, 24);
            this.txtAgeDays.TabIndex = 147;
            this.txtAgeDays.TabStop = false;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(87, 262);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(53, 18);
            this.smartLabel10.TabIndex = 146;
            this.smartLabel10.Text = "Age(M)";
            // 
            // txtAgeMonths
            // 
            this.txtAgeMonths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtAgeMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeMonths.Location = new System.Drawing.Point(87, 283);
            this.txtAgeMonths.Name = "txtAgeMonths";
            this.txtAgeMonths.ReadOnly = true;
            this.txtAgeMonths.Size = new System.Drawing.Size(65, 24);
            this.txtAgeMonths.TabIndex = 145;
            this.txtAgeMonths.TabStop = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(11, 262);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(49, 18);
            this.lblAge.TabIndex = 144;
            this.lblAge.Text = "Age(Y)";
            // 
            // txtAgeYears
            // 
            this.txtAgeYears.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtAgeYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeYears.Location = new System.Drawing.Point(11, 283);
            this.txtAgeYears.Name = "txtAgeYears";
            this.txtAgeYears.ReadOnly = true;
            this.txtAgeYears.Size = new System.Drawing.Size(65, 24);
            this.txtAgeYears.TabIndex = 143;
            this.txtAgeYears.TabStop = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(733, 170);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(121, 31);
            this.txtRemarks.TabIndex = 136;
            this.txtRemarks.Text = "N/A";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(11, 208);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(90, 18);
            this.smartLabel3.TabIndex = 140;
            this.smartLabel3.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(11, 227);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(391, 24);
            this.txtPatientName.TabIndex = 139;
            this.txtPatientName.TabStop = false;
            // 
            // cboPatientMr
            // 
            this.cboPatientMr.BackColor = System.Drawing.Color.DodgerBlue;
            this.cboPatientMr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPatientMr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPatientMr.ForeColor = System.Drawing.Color.White;
            this.cboPatientMr.Location = new System.Drawing.Point(343, 170);
            this.cboPatientMr.Name = "cboPatientMr";
            this.cboPatientMr.Size = new System.Drawing.Size(59, 31);
            this.cboPatientMr.TabIndex = 138;
            this.cboPatientMr.Text = "Find";
            this.cboPatientMr.UseVisualStyleBackColor = false;
            this.cboPatientMr.Click += new System.EventHandler(this.cboPatientMr_Click);
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.BackColor = System.Drawing.Color.Transparent;
            this.lblMr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMr.Location = new System.Drawing.Point(11, 150);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(51, 18);
            this.lblMr.TabIndex = 137;
            this.lblMr.Text = "MR No";
            // 
            // lvMRTests
            // 
            this.lvMRTests.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvMRTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMRTests.CheckBoxes = true;
            this.lvMRTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvMRTests.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMRTests.FullRowSelect = true;
            this.lvMRTests.GridLines = true;
            this.lvMRTests.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMRTests.Location = new System.Drawing.Point(1, 344);
            this.lvMRTests.Name = "lvMRTests";
            this.lvMRTests.Size = new System.Drawing.Size(860, 332);
            this.lvMRTests.TabIndex = 155;
            this.lvMRTests.UseCompatibleStateImageBehavior = false;
            this.lvMRTests.View = System.Windows.Forms.View.Details;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(429, 150);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(93, 18);
            this.smartLabel1.TabIndex = 137;
            this.smartLabel1.Text = "Refund Cause";
            // 
            // cboCause
            // 
            this.cboCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCause.ForeColor = System.Drawing.Color.Blue;
            this.cboCause.FormattingEnabled = true;
            this.cboCause.Location = new System.Drawing.Point(429, 170);
            this.cboCause.Name = "cboCause";
            this.cboCause.Size = new System.Drawing.Size(231, 26);
            this.cboCause.TabIndex = 136;
            // 
            // txtMoneyReceiptNo
            // 
            this.txtMoneyReceiptNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtMoneyReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyReceiptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyReceiptNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMoneyReceiptNo.Location = new System.Drawing.Point(16, 609);
            this.txtMoneyReceiptNo.Name = "txtMoneyReceiptNo";
            this.txtMoneyReceiptNo.ReadOnly = true;
            this.txtMoneyReceiptNo.Size = new System.Drawing.Size(49, 24);
            this.txtMoneyReceiptNo.TabIndex = 156;
            this.txtMoneyReceiptNo.TabStop = false;
            this.txtMoneyReceiptNo.Visible = false;
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNetAmount.Location = new System.Drawing.Point(430, 283);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(119, 24);
            this.txtNetAmount.TabIndex = 157;
            this.txtNetAmount.TabStop = false;
            // 
            // txtNetPaid
            // 
            this.txtNetPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtNetPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNetPaid.Location = new System.Drawing.Point(555, 283);
            this.txtNetPaid.Name = "txtNetPaid";
            this.txtNetPaid.ReadOnly = true;
            this.txtNetPaid.Size = new System.Drawing.Size(105, 24);
            this.txtNetPaid.TabIndex = 158;
            this.txtNetPaid.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(666, 225);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(188, 28);
            this.btnCalculate.TabIndex = 159;
            this.btnCalculate.Text = "Calculate Refund";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnAmount.Location = new System.Drawing.Point(666, 283);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.Size = new System.Drawing.Size(188, 24);
            this.txtReturnAmount.TabIndex = 160;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(663, 262);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(101, 18);
            this.smartLabel2.TabIndex = 161;
            this.smartLabel2.Text = "Return Amount";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(430, 262);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(106, 18);
            this.smartLabel4.TabIndex = 162;
            this.smartLabel4.Text = "Current Amount";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(554, 262);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(60, 18);
            this.smartLabel5.TabIndex = 163;
            this.smartLabel5.Text = "Net Paid";
            // 
            // txtPreviousAmount
            // 
            this.txtPreviousAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPreviousAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreviousAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPreviousAmount.Location = new System.Drawing.Point(429, 227);
            this.txtPreviousAmount.Name = "txtPreviousAmount";
            this.txtPreviousAmount.ReadOnly = true;
            this.txtPreviousAmount.Size = new System.Drawing.Size(231, 24);
            this.txtPreviousAmount.TabIndex = 164;
            this.txtPreviousAmount.TabStop = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(429, 206);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(112, 18);
            this.smartLabel6.TabIndex = 165;
            this.smartLabel6.Text = "Previous Amount";
            // 
            // btnRefreshRefund
            // 
            this.btnRefreshRefund.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshRefund.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshRefund.ForeColor = System.Drawing.Color.White;
            this.btnRefreshRefund.Location = new System.Drawing.Point(697, 169);
            this.btnRefreshRefund.Name = "btnRefreshRefund";
            this.btnRefreshRefund.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshRefund.TabIndex = 167;
            this.btnRefreshRefund.TabStop = false;
            this.btnRefreshRefund.Text = "..";
            this.btnRefreshRefund.UseVisualStyleBackColor = false;
            this.btnRefreshRefund.Click += new System.EventHandler(this.btnRefreshRefund_Click);
            // 
            // btnAddCause
            // 
            this.btnAddCause.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCause.ForeColor = System.Drawing.Color.White;
            this.btnAddCause.Location = new System.Drawing.Point(662, 169);
            this.btnAddCause.Name = "btnAddCause";
            this.btnAddCause.Size = new System.Drawing.Size(32, 26);
            this.btnAddCause.TabIndex = 166;
            this.btnAddCause.TabStop = false;
            this.btnAddCause.Text = "+";
            this.btnAddCause.UseVisualStyleBackColor = false;
            this.btnAddCause.Click += new System.EventHandler(this.btnAddCause_Click);
            // 
            // txtDueStatus
            // 
            this.txtDueStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtDueStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDueStatus.Location = new System.Drawing.Point(181, 609);
            this.txtDueStatus.Name = "txtDueStatus";
            this.txtDueStatus.ReadOnly = true;
            this.txtDueStatus.Size = new System.Drawing.Size(49, 24);
            this.txtDueStatus.TabIndex = 157;
            this.txtDueStatus.TabStop = false;
            this.txtDueStatus.Visible = false;
            // 
            // frmTestRefundSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 665);
            this.Controls.Add(this.txtDueStatus);
            this.Controls.Add(this.txtMoneyReceiptNo);
            this.isEnterTabAllow = true;
            this.Name = "frmTestRefundSetup";
            this.Load += new System.EventHandler(this.frmTestRefundSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.txtMoneyReceiptNo, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtDueStatus, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMRNo;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSex;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeHours;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeDays;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeMonths;
        private AtiqsControlLibrary.SmartLabel lblAge;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeYears;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private System.Windows.Forms.Button cboPatientMr;
        private AtiqsControlLibrary.SmartLabel lblMr;
        private AtiqsControlLibrary.SmartListViewDetails lvMRTests;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboCause;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMoneyReceiptNo;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtNetAmount;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtNetPaid;
        private System.Windows.Forms.Button btnCalculate;
        private AtiqsControlLibrary.SmartNumericTextBox txtReturnAmount;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPreviousAmount;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private System.Windows.Forms.Button btnRefreshRefund;
        private System.Windows.Forms.Button btnAddCause;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDueStatus;
    }
}
