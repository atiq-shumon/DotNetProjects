namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmOPDTicketIssue
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
            this.txtFee = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtAgeYears = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblAge = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboDoctor = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboCaseID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeMonths = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeDays = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.lblStaff = new AtiqsControlLibrary.SmartLabel();
            this.lblTicketType = new AtiqsControlLibrary.SmartLabel();
            this.cboTicketType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeHours = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtPresentAddress = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtHCNNo = new System.Windows.Forms.TextBox();
            this.txtTicketNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.lblToken = new AtiqsControlLibrary.SmartLabel();
            this.txtRoom = new AtiqsControlLibrary.SmartTextBox();
            this.txtAppointment = new AtiqsControlLibrary.SmartTextBox();
            this.lblLastV = new System.Windows.Forms.Label();
            this.lblmP = new System.Windows.Forms.Label();
            this.lbldrtV = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblComplaints = new System.Windows.Forms.Label();
            this.btnFee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFee = new AtiqsControlLibrary.SmartLabel();
            this.lblRoom = new AtiqsControlLibrary.SmartLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsultantFee = new System.Windows.Forms.TextBox();
            this.txtTo = new AtiqsControlLibrary.SmartTextBox();
            this.lblTo = new AtiqsControlLibrary.SmartLabel();
            this.txtFrom = new AtiqsControlLibrary.SmartTextBox();
            this.lblFrom = new AtiqsControlLibrary.SmartLabel();
            this.cboTokenNo = new AtiqsControlLibrary.SmartComboBox();
            this.lblrequired = new AtiqsControlLibrary.SmartLabel();
            this.txtPatSerial = new AtiqsControlLibrary.SmartNumericTextBox();
            this.btnToCaseRefresh = new System.Windows.Forms.Button();
            this.btnToCase = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(268, 9);
            this.frmLabel.Size = new System.Drawing.Size(318, 33);
            this.frmLabel.Text = "Prescription Bill Collection";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Snow;
            this.pnlMain.Controls.Add(this.btnToCaseRefresh);
            this.pnlMain.Controls.Add(this.btnToCase);
            this.pnlMain.Controls.Add(this.cboTokenNo);
            this.pnlMain.Controls.Add(this.txtFrom);
            this.pnlMain.Controls.Add(this.lblFrom);
            this.pnlMain.Controls.Add(this.txtTo);
            this.pnlMain.Controls.Add(this.lblTo);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.btnFee);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.lblToken);
            this.pnlMain.Controls.Add(this.txtHCNNo);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtPresentAddress);
            this.pnlMain.Controls.Add(this.lblTicketType);
            this.pnlMain.Controls.Add(this.cboTicketType);
            this.pnlMain.Controls.Add(this.btnPatientSearch);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtAgeDays);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtAgeMonths);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboCaseID);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboDoctor);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.lblAge);
            this.pnlMain.Controls.Add(this.txtAgeYears);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtPatientName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.lblrequired);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(846, 442);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(846, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(45, 530);
            this.btnEdit.Size = new System.Drawing.Size(10, 16);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(611, 506);
            this.btnSave.TabIndex = 9;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 530);
            this.btnDelete.Size = new System.Drawing.Size(10, 15);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(497, 506);
            this.btnNew.TabIndex = 10;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(724, 506);
            this.btnClose.TabIndex = 11;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(27, 530);
            this.btnPrint.Size = new System.Drawing.Size(12, 12);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 549);
            this.groupBox1.Size = new System.Drawing.Size(846, 25);
            // 
            // txtFee
            // 
            this.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFee.Enabled = false;
            this.txtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(10, 506);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(16, 24);
            this.txtFee.TabIndex = 199;
            this.txtFee.TextChanged += new System.EventHandler(this.txtFee_TextChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(64, 506);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(91, 15);
            this.smartLabel1.TabIndex = 2;
            this.smartLabel1.Text = "PrescriptionNo";
            this.smartLabel1.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(17, 60);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(52, 15);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "HCN No";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(417, 7);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(80, 15);
            this.smartLabel3.TabIndex = 6;
            this.smartLabel3.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(414, 29);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(419, 24);
            this.txtPatientName.TabIndex = 5;
            this.txtPatientName.TabStop = false;
            // 
            // txtAgeYears
            // 
            this.txtAgeYears.BackColor = System.Drawing.Color.Linen;
            this.txtAgeYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeYears.Location = new System.Drawing.Point(414, 84);
            this.txtAgeYears.Name = "txtAgeYears";
            this.txtAgeYears.ReadOnly = true;
            this.txtAgeYears.Size = new System.Drawing.Size(119, 24);
            this.txtAgeYears.TabIndex = 7;
            this.txtAgeYears.TabStop = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(418, 63);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 15);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age(Y)";
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(14, 232);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(310, 26);
            this.cboDepartment.TabIndex = 5;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(17, 212);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(71, 15);
            this.smartLabel4.TabIndex = 10;
            this.smartLabel4.Text = "Department";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(17, 260);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(30, 15);
            this.smartLabel5.TabIndex = 12;
            this.smartLabel5.Text = "Unit";
            // 
            // cboUnit
            // 
            this.cboUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(14, 280);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(310, 26);
            this.cboUnit.TabIndex = 6;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(17, 308);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(44, 15);
            this.smartLabel6.TabIndex = 14;
            this.smartLabel6.Text = "Doctor";
            // 
            // cboDoctor
            // 
            this.cboDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctor.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(14, 328);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(310, 26);
            this.cboDoctor.TabIndex = 7;
            this.cboDoctor.SelectedIndexChanged += new System.EventHandler(this.cboDoctor_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(17, 163);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(83, 15);
            this.smartLabel7.TabIndex = 16;
            this.smartLabel7.Text = "Primary Case";
            // 
            // cboCaseID
            // 
            this.cboCaseID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCaseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaseID.ForeColor = System.Drawing.Color.Blue;
            this.cboCaseID.FormattingEnabled = true;
            this.cboCaseID.Location = new System.Drawing.Point(14, 183);
            this.cboCaseID.Name = "cboCaseID";
            this.cboCaseID.Size = new System.Drawing.Size(221, 26);
            this.cboCaseID.TabIndex = 4;
            this.cboCaseID.SelectedIndexChanged += new System.EventHandler(this.cboCaseID_SelectedIndexChanged);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(574, 63);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(48, 15);
            this.smartLabel8.TabIndex = 18;
            this.smartLabel8.Text = "Age(M)";
            // 
            // txtAgeMonths
            // 
            this.txtAgeMonths.BackColor = System.Drawing.Color.Linen;
            this.txtAgeMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeMonths.Location = new System.Drawing.Point(571, 84);
            this.txtAgeMonths.Name = "txtAgeMonths";
            this.txtAgeMonths.ReadOnly = true;
            this.txtAgeMonths.Size = new System.Drawing.Size(117, 24);
            this.txtAgeMonths.TabIndex = 17;
            this.txtAgeMonths.TabStop = false;
            this.txtAgeMonths.TextChanged += new System.EventHandler(this.smartNumericTextBox2_TextChanged);
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(722, 63);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(46, 15);
            this.smartLabel9.TabIndex = 20;
            this.smartLabel9.Text = "Age(D)";
            // 
            // txtAgeDays
            // 
            this.txtAgeDays.BackColor = System.Drawing.Color.Linen;
            this.txtAgeDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeDays.Location = new System.Drawing.Point(719, 84);
            this.txtAgeDays.Name = "txtAgeDays";
            this.txtAgeDays.ReadOnly = true;
            this.txtAgeDays.Size = new System.Drawing.Size(114, 24);
            this.txtAgeDays.TabIndex = 19;
            this.txtAgeDays.TabStop = false;
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(340, 80);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(53, 31);
            this.btnPatientSearch.TabIndex = 2;
            this.btnPatientSearch.Text = "Find";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.ForeColor = System.Drawing.Color.Crimson;
            this.smartLabel10.Location = new System.Drawing.Point(6, 32);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(56, 24);
            this.smartLabel10.TabIndex = 22;
            this.smartLabel10.Text = "Fee :";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblStaff.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStaff.Location = new System.Drawing.Point(60, 525);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(33, 15);
            this.lblStaff.TabIndex = 24;
            this.lblStaff.Text = "Staff";
            this.lblStaff.Visible = false;
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTicketType.Location = new System.Drawing.Point(17, 9);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(104, 15);
            this.lblTicketType.TabIndex = 26;
            this.lblTicketType.Text = "Prescription Type";
            // 
            // cboTicketType
            // 
            this.cboTicketType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTicketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTicketType.ForeColor = System.Drawing.Color.Blue;
            this.cboTicketType.FormattingEnabled = true;
            this.cboTicketType.Location = new System.Drawing.Point(14, 29);
            this.cboTicketType.Name = "cboTicketType";
            this.cboTicketType.Size = new System.Drawing.Size(310, 26);
            this.cboTicketType.TabIndex = 0;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(104, 508);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(46, 15);
            this.smartLabel11.TabIndex = 28;
            this.smartLabel11.Text = "Age(H)";
            this.smartLabel11.Visible = false;
            // 
            // txtAgeHours
            // 
            this.txtAgeHours.BackColor = System.Drawing.Color.Linen;
            this.txtAgeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeHours.Location = new System.Drawing.Point(157, 511);
            this.txtAgeHours.Name = "txtAgeHours";
            this.txtAgeHours.ReadOnly = true;
            this.txtAgeHours.Size = new System.Drawing.Size(14, 24);
            this.txtAgeHours.TabIndex = 27;
            this.txtAgeHours.TabStop = false;
            this.txtAgeHours.Visible = false;
            // 
            // txtPresentAddress
            // 
            this.txtPresentAddress.BackColor = System.Drawing.Color.Linen;
            this.txtPresentAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPresentAddress.Location = new System.Drawing.Point(414, 137);
            this.txtPresentAddress.Multiline = true;
            this.txtPresentAddress.Name = "txtPresentAddress";
            this.txtPresentAddress.ReadOnly = true;
            this.txtPresentAddress.Size = new System.Drawing.Size(419, 75);
            this.txtPresentAddress.TabIndex = 30;
            this.txtPresentAddress.TabStop = false;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(417, 118);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(55, 15);
            this.smartLabel12.TabIndex = 31;
            this.smartLabel12.Text = "Address ";
            // 
            // txtHCNNo
            // 
            this.txtHCNNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCNNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCNNo.ForeColor = System.Drawing.Color.Red;
            this.txtHCNNo.Location = new System.Drawing.Point(14, 80);
            this.txtHCNNo.MaxLength = 11;
            this.txtHCNNo.Name = "txtHCNNo";
            this.txtHCNNo.Size = new System.Drawing.Size(310, 31);
            this.txtHCNNo.TabIndex = 1;
            this.txtHCNNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHCNNo_KeyUp);
            // 
            // txtTicketNo
            // 
            this.txtTicketNo.BackColor = System.Drawing.Color.Linen;
            this.txtTicketNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTicketNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTicketNo.Location = new System.Drawing.Point(81, 516);
            this.txtTicketNo.Name = "txtTicketNo";
            this.txtTicketNo.ReadOnly = true;
            this.txtTicketNo.Size = new System.Drawing.Size(10, 24);
            this.txtTicketNo.TabIndex = 200;
            this.txtTicketNo.TabStop = false;
            this.txtTicketNo.Visible = false;
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.ForeColor = System.Drawing.Color.Crimson;
            this.smartLabel13.Location = new System.Drawing.Point(6, 1);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(76, 24);
            this.smartLabel13.TabIndex = 201;
            this.smartLabel13.Text = "Room :";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.BackColor = System.Drawing.Color.Transparent;
            this.lblToken.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblToken.Location = new System.Drawing.Point(17, 117);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(59, 15);
            this.lblToken.TabIndex = 202;
            this.lblToken.Text = "Token No";
            // 
            // txtRoom
            // 
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(43, 506);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(15, 24);
            this.txtRoom.TabIndex = 203;
            // 
            // txtAppointment
            // 
            this.txtAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointment.Location = new System.Drawing.Point(97, 516);
            this.txtAppointment.Name = "txtAppointment";
            this.txtAppointment.Size = new System.Drawing.Size(10, 24);
            this.txtAppointment.TabIndex = 204;
            this.txtAppointment.Visible = false;
            // 
            // lblLastV
            // 
            this.lblLastV.AutoSize = true;
            this.lblLastV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastV.ForeColor = System.Drawing.Color.Blue;
            this.lblLastV.Location = new System.Drawing.Point(20, 12);
            this.lblLastV.Name = "lblLastV";
            this.lblLastV.Size = new System.Drawing.Size(15, 24);
            this.lblLastV.TabIndex = 206;
            this.lblLastV.Text = "l";
            // 
            // lblmP
            // 
            this.lblmP.AutoSize = true;
            this.lblmP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmP.ForeColor = System.Drawing.Color.DarkRed;
            this.lblmP.Location = new System.Drawing.Point(20, 13);
            this.lblmP.Name = "lblmP";
            this.lblmP.Size = new System.Drawing.Size(15, 24);
            this.lblmP.TabIndex = 209;
            this.lblmP.Text = "l";
            this.lblmP.Click += new System.EventHandler(this.lblmP_Click);
            // 
            // lbldrtV
            // 
            this.lbldrtV.AutoSize = true;
            this.lbldrtV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldrtV.ForeColor = System.Drawing.Color.DarkRed;
            this.lbldrtV.Location = new System.Drawing.Point(20, 40);
            this.lbldrtV.Name = "lbldrtV";
            this.lbldrtV.Size = new System.Drawing.Size(15, 24);
            this.lbldrtV.TabIndex = 210;
            this.lbldrtV.Text = "l";
            // 
            // txtStaff
            // 
            this.txtStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.ForeColor = System.Drawing.Color.Red;
            this.txtStaff.Location = new System.Drawing.Point(28, 506);
            this.txtStaff.Multiline = true;
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(11, 24);
            this.txtStaff.TabIndex = 211;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.lblComplaints);
            this.panel1.Controls.Add(this.lblmP);
            this.panel1.Controls.Add(this.lbldrtV);
            this.panel1.Location = new System.Drawing.Point(414, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 74);
            this.panel1.TabIndex = 211;
            // 
            // lblComplaints
            // 
            this.lblComplaints.AutoSize = true;
            this.lblComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaints.ForeColor = System.Drawing.Color.IndianRed;
            this.lblComplaints.Location = new System.Drawing.Point(720, 8);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(51, 16);
            this.lblComplaints.TabIndex = 147;
            this.lblComplaints.Text = "label1";
            // 
            // btnFee
            // 
            this.btnFee.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.ForeColor = System.Drawing.Color.White;
            this.btnFee.Location = new System.Drawing.Point(340, 328);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(53, 31);
            this.btnFee.TabIndex = 8;
            this.btnFee.Text = "Fee";
            this.btnFee.UseVisualStyleBackColor = false;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblLastV);
            this.panel2.Location = new System.Drawing.Point(414, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 62);
            this.panel2.TabIndex = 213;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(720, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 147;
            this.label1.Text = "label1";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.BackColor = System.Drawing.Color.Transparent;
            this.lblFee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblFee.ForeColor = System.Drawing.Color.Blue;
            this.lblFee.Location = new System.Drawing.Point(88, 32);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(44, 24);
            this.lblFee.TabIndex = 214;
            this.lblFee.Text = "Fee";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.Blue;
            this.lblRoom.Location = new System.Drawing.Point(88, 4);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(95, 24);
            this.lblRoom.TabIndex = 215;
            this.lblRoom.Text = "Room No";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblRoom);
            this.panel3.Controls.Add(this.smartLabel13);
            this.panel3.Controls.Add(this.lblFee);
            this.panel3.Controls.Add(this.smartLabel10);
            this.panel3.Location = new System.Drawing.Point(14, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 62);
            this.panel3.TabIndex = 216;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(720, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 147;
            this.label3.Text = "label3";
            // 
            // txtConsultantFee
            // 
            this.txtConsultantFee.Location = new System.Drawing.Point(67, 520);
            this.txtConsultantFee.Name = "txtConsultantFee";
            this.txtConsultantFee.Size = new System.Drawing.Size(10, 20);
            this.txtConsultantFee.TabIndex = 217;
            this.txtConsultantFee.Visible = false;
            // 
            // txtTo
            // 
            this.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(670, 406);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(121, 24);
            this.txtTo.TabIndex = 218;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(637, 409);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 15);
            this.lblTo.TabIndex = 217;
            this.lblTo.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(463, 407);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(121, 24);
            this.txtFrom.TabIndex = 220;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFrom.Location = new System.Drawing.Point(418, 409);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 15);
            this.lblFrom.TabIndex = 219;
            this.lblFrom.Text = "From";
            // 
            // cboTokenNo
            // 
            this.cboTokenNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTokenNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTokenNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTokenNo.ForeColor = System.Drawing.Color.Blue;
            this.cboTokenNo.FormattingEnabled = true;
            this.cboTokenNo.Location = new System.Drawing.Point(14, 137);
            this.cboTokenNo.Name = "cboTokenNo";
            this.cboTokenNo.Size = new System.Drawing.Size(309, 26);
            this.cboTokenNo.TabIndex = 3;
            this.cboTokenNo.SelectedIndexChanged += new System.EventHandler(this.cboTokenNo_SelectedIndexChanged);
            // 
            // lblrequired
            // 
            this.lblrequired.AutoSize = true;
            this.lblrequired.BackColor = System.Drawing.Color.Transparent;
            this.lblrequired.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblrequired.ForeColor = System.Drawing.Color.Red;
            this.lblrequired.Location = new System.Drawing.Point(320, 137);
            this.lblrequired.Name = "lblrequired";
            this.lblrequired.Size = new System.Drawing.Size(24, 26);
            this.lblrequired.TabIndex = 222;
            this.lblrequired.Text = "*";
            // 
            // txtPatSerial
            // 
            this.txtPatSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatSerial.Enabled = false;
            this.txtPatSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatSerial.Location = new System.Drawing.Point(177, 511);
            this.txtPatSerial.Name = "txtPatSerial";
            this.txtPatSerial.Size = new System.Drawing.Size(16, 24);
            this.txtPatSerial.TabIndex = 218;
            this.txtPatSerial.Visible = false;
            // 
            // btnToCaseRefresh
            // 
            this.btnToCaseRefresh.BackColor = System.Drawing.Color.MediumPurple;
            this.btnToCaseRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCaseRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnToCaseRefresh.ForeColor = System.Drawing.Color.White;
            this.btnToCaseRefresh.Location = new System.Drawing.Point(284, 177);
            this.btnToCaseRefresh.Name = "btnToCaseRefresh";
            this.btnToCaseRefresh.Size = new System.Drawing.Size(39, 38);
            this.btnToCaseRefresh.TabIndex = 278;
            this.btnToCaseRefresh.Text = "..";
            this.btnToCaseRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToCaseRefresh.UseVisualStyleBackColor = false;
            this.btnToCaseRefresh.Click += new System.EventHandler(this.btnToCaseRefresh_Click);
            // 
            // btnToCase
            // 
            this.btnToCase.BackColor = System.Drawing.Color.Navy;
            this.btnToCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCase.ForeColor = System.Drawing.Color.White;
            this.btnToCase.Location = new System.Drawing.Point(241, 177);
            this.btnToCase.Name = "btnToCase";
            this.btnToCase.Size = new System.Drawing.Size(39, 38);
            this.btnToCase.TabIndex = 277;
            this.btnToCase.Text = "+";
            this.btnToCase.UseVisualStyleBackColor = false;
            this.btnToCase.Click += new System.EventHandler(this.btnToCase_Click);
            // 
            // frmOPDTicketIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(846, 574);
            this.Controls.Add(this.txtPatSerial);
            this.Controls.Add(this.txtConsultantFee);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtAppointment);
            this.Controls.Add(this.txtTicketNo);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.smartLabel11);
            this.Controls.Add(this.txtAgeHours);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.smartLabel1);
            this.isEnterTabAllow = true;
            this.Name = "frmOPDTicketIssue";
            this.Load += new System.EventHandler(this.frmOPDTicketIssue_Load);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.Controls.SetChildIndex(this.txtFee, 0);
            this.Controls.SetChildIndex(this.lblStaff, 0);
            this.Controls.SetChildIndex(this.txtAgeHours, 0);
            this.Controls.SetChildIndex(this.smartLabel11, 0);
            this.Controls.SetChildIndex(this.txtStaff, 0);
            this.Controls.SetChildIndex(this.txtTicketNo, 0);
            this.Controls.SetChildIndex(this.txtAppointment, 0);
            this.Controls.SetChildIndex(this.txtRoom, 0);
            this.Controls.SetChildIndex(this.txtConsultantFee, 0);
            this.Controls.SetChildIndex(this.txtPatSerial, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboCaseID;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboDoctor;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel lblAge;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeYears;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartNumericTextBox txtFee;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeDays;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeMonths;
        private System.Windows.Forms.Button btnPatientSearch;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel lblStaff;
        private AtiqsControlLibrary.SmartLabel lblTicketType;
        private AtiqsControlLibrary.SmartComboBox cboTicketType;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeHours;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPresentAddress;
        private System.Windows.Forms.TextBox txtHCNNo;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTicketNo;
        private AtiqsControlLibrary.SmartTextBox txtAppointment;
        private AtiqsControlLibrary.SmartTextBox txtRoom;
        private AtiqsControlLibrary.SmartLabel lblToken;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private System.Windows.Forms.Label lblLastV;
        private System.Windows.Forms.Label lblmP;
        private System.Windows.Forms.Label lbldrtV;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblComplaints;
        private AtiqsControlLibrary.SmartLabel lblFee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private AtiqsControlLibrary.SmartLabel lblRoom;
        private System.Windows.Forms.TextBox txtConsultantFee;
        private AtiqsControlLibrary.SmartTextBox txtFrom;
        private AtiqsControlLibrary.SmartLabel lblFrom;
        private AtiqsControlLibrary.SmartTextBox txtTo;
        private AtiqsControlLibrary.SmartLabel lblTo;
        private AtiqsControlLibrary.SmartComboBox cboTokenNo;
        private AtiqsControlLibrary.SmartLabel lblrequired;
        private AtiqsControlLibrary.SmartNumericTextBox txtPatSerial;
        private System.Windows.Forms.Button btnToCaseRefresh;
        private System.Windows.Forms.Button btnToCase;
    }
}
