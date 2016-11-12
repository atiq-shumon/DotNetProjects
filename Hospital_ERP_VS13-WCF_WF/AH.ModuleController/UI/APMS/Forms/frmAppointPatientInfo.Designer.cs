namespace AH.ModuleController.UI.APMS.Forms
{
    partial class frmAppointPatientInfo
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrPhone = new AtiqsControlLibrary.SmartNumericTextBox();
            this.nmrMobile = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lblAge = new AtiqsControlLibrary.SmartLabel();
            this.nmrDay = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartCheckBox1 = new AtiqsControlLibrary.SmartCheckBox();
            this.lblEmail = new AtiqsControlLibrary.SmartLabel();
            this.nmrMonth = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lblDays = new AtiqsControlLibrary.SmartLabel();
            this.txtEmail = new AtiqsControlLibrary.SmartTextBox();
            this.lblMonth = new AtiqsControlLibrary.SmartLabel();
            this.nmrYear = new AtiqsControlLibrary.SmartNumericTextBox();
            this.cboStatus = new AtiqsControlLibrary.SmartComboBox();
            this.lblStatus = new AtiqsControlLibrary.SmartLabel();
            this.lblYear = new AtiqsControlLibrary.SmartLabel();
            this.cboCountry = new AtiqsControlLibrary.SmartComboBox();
            this.lblCountry = new AtiqsControlLibrary.SmartLabel();
            this.lblMobile = new AtiqsControlLibrary.SmartLabel();
            this.lblPhone = new AtiqsControlLibrary.SmartLabel();
            this.cboGender = new AtiqsControlLibrary.SmartComboBox();
            this.lblGender = new AtiqsControlLibrary.SmartLabel();
            this.txtVisitorAddress = new AtiqsControlLibrary.SmartTextBox();
            this.lblVisitorAddress = new AtiqsControlLibrary.SmartLabel();
            this.txtVisitorName = new AtiqsControlLibrary.SmartTextBox();
            this.lblVisitorName = new AtiqsControlLibrary.SmartLabel();
            this.cboVisitorType = new AtiqsControlLibrary.SmartComboBox();
            this.lblVisitorType = new AtiqsControlLibrary.SmartLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHcn = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lblApproxTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTokenNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBookingType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblVisitType = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAppointmentID = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(614, 10);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(172, 7);
            this.frmLabel.Size = new System.Drawing.Size(299, 33);
            this.frmLabel.Text = "Edit Patient Information";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(670, 508);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtAppointmentID);
            this.pnlTop.Size = new System.Drawing.Size(670, 51);
            this.pnlTop.Controls.SetChildIndex(this.txtAppointmentID, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(39, 574);
            this.btnEdit.Size = new System.Drawing.Size(10, 40);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(436, 565);
            this.btnSave.TabIndex = 12;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 571);
            this.btnDelete.Size = new System.Drawing.Size(10, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 572);
            this.btnNew.Size = new System.Drawing.Size(10, 40);
            this.btnNew.TabIndex = 0;
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(550, 565);
            this.btnClose.TabIndex = 13;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(30, 574);
            this.btnPrint.Size = new System.Drawing.Size(10, 40);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 614);
            this.groupBox1.Size = new System.Drawing.Size(670, 23);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.nmrPhone);
            this.panel4.Controls.Add(this.nmrMobile);
            this.panel4.Controls.Add(this.lblAge);
            this.panel4.Controls.Add(this.nmrDay);
            this.panel4.Controls.Add(this.smartCheckBox1);
            this.panel4.Controls.Add(this.lblEmail);
            this.panel4.Controls.Add(this.nmrMonth);
            this.panel4.Controls.Add(this.lblDays);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.lblMonth);
            this.panel4.Controls.Add(this.nmrYear);
            this.panel4.Controls.Add(this.cboStatus);
            this.panel4.Controls.Add(this.lblStatus);
            this.panel4.Controls.Add(this.lblYear);
            this.panel4.Controls.Add(this.cboCountry);
            this.panel4.Controls.Add(this.lblCountry);
            this.panel4.Controls.Add(this.lblMobile);
            this.panel4.Controls.Add(this.lblPhone);
            this.panel4.Controls.Add(this.cboGender);
            this.panel4.Controls.Add(this.lblGender);
            this.panel4.Controls.Add(this.txtVisitorAddress);
            this.panel4.Controls.Add(this.lblVisitorAddress);
            this.panel4.Controls.Add(this.txtVisitorName);
            this.panel4.Controls.Add(this.lblVisitorName);
            this.panel4.Controls.Add(this.cboVisitorType);
            this.panel4.Controls.Add(this.lblVisitorType);
            this.panel4.Location = new System.Drawing.Point(2, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 339);
            this.panel4.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(322, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 20);
            this.label12.TabIndex = 197;
            this.label12.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(322, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 195;
            this.label8.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(615, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 194;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(341, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 193;
            this.label5.Text = "*";
            // 
            // nmrPhone
            // 
            this.nmrPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrPhone.Location = new System.Drawing.Point(124, 292);
            this.nmrPhone.MaxLength = 7;
            this.nmrPhone.Name = "nmrPhone";
            this.nmrPhone.ReadOnly = true;
            this.nmrPhone.Size = new System.Drawing.Size(198, 24);
            this.nmrPhone.TabIndex = 8;
            // 
            // nmrMobile
            // 
            this.nmrMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrMobile.Location = new System.Drawing.Point(124, 258);
            this.nmrMobile.MaxLength = 11;
            this.nmrMobile.Name = "nmrMobile";
            this.nmrMobile.ReadOnly = true;
            this.nmrMobile.Size = new System.Drawing.Size(197, 24);
            this.nmrMobile.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(74, 190);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age :";
            // 
            // nmrDay
            // 
            this.nmrDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrDay.Location = new System.Drawing.Point(260, 186);
            this.nmrDay.MaxLength = 2;
            this.nmrDay.Name = "nmrDay";
            this.nmrDay.ReadOnly = true;
            this.nmrDay.Size = new System.Drawing.Size(61, 24);
            this.nmrDay.TabIndex = 5;
            // 
            // smartCheckBox1
            // 
            this.smartCheckBox1.AutoSize = true;
            this.smartCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox1.Location = new System.Drawing.Point(465, 20);
            this.smartCheckBox1.Name = "smartCheckBox1";
            this.smartCheckBox1.Size = new System.Drawing.Size(139, 22);
            this.smartCheckBox1.TabIndex = 0;
            this.smartCheckBox1.Text = "smartCheckBox1";
            this.smartCheckBox1.UseVisualStyleBackColor = true;
            this.smartCheckBox1.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(352, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email :";
            // 
            // nmrMonth
            // 
            this.nmrMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrMonth.Location = new System.Drawing.Point(194, 186);
            this.nmrMonth.MaxLength = 2;
            this.nmrMonth.Name = "nmrMonth";
            this.nmrMonth.ReadOnly = true;
            this.nmrMonth.Size = new System.Drawing.Size(61, 24);
            this.nmrMonth.TabIndex = 4;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDays.Location = new System.Drawing.Point(268, 171);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(33, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Day ";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(403, 187);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(212, 24);
            this.txtEmail.TabIndex = 9;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(201, 171);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(46, 13);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month ";
            // 
            // nmrYear
            // 
            this.nmrYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrYear.Location = new System.Drawing.Point(124, 186);
            this.nmrYear.MaxLength = 3;
            this.nmrYear.Name = "nmrYear";
            this.nmrYear.ReadOnly = true;
            this.nmrYear.Size = new System.Drawing.Size(61, 24);
            this.nmrYear.TabIndex = 3;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.Blue;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(403, 258);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(213, 26);
            this.cboStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(346, 267);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status :";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(128, 171);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year ";
            // 
            // cboCountry
            // 
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.Enabled = false;
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.ForeColor = System.Drawing.Color.Blue;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(403, 221);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(213, 26);
            this.cboCountry.TabIndex = 10;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCountry.Location = new System.Drawing.Point(336, 228);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(62, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country : ";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMobile.Location = new System.Drawing.Point(59, 263);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(52, 13);
            this.lblMobile.TabIndex = 0;
            this.lblMobile.Text = "Mobile :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(28, 298);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Land Phone :";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Enabled = false;
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.ForeColor = System.Drawing.Color.Blue;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(124, 221);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(198, 26);
            this.cboGender.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(55, 224);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender :";
            // 
            // txtVisitorAddress
            // 
            this.txtVisitorAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorAddress.Location = new System.Drawing.Point(123, 100);
            this.txtVisitorAddress.Multiline = true;
            this.txtVisitorAddress.Name = "txtVisitorAddress";
            this.txtVisitorAddress.ReadOnly = true;
            this.txtVisitorAddress.Size = new System.Drawing.Size(492, 57);
            this.txtVisitorAddress.TabIndex = 2;
            // 
            // lblVisitorAddress
            // 
            this.lblVisitorAddress.AutoSize = true;
            this.lblVisitorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVisitorAddress.Location = new System.Drawing.Point(20, 100);
            this.lblVisitorAddress.Name = "lblVisitorAddress";
            this.lblVisitorAddress.Size = new System.Drawing.Size(99, 13);
            this.lblVisitorAddress.TabIndex = 0;
            this.lblVisitorAddress.Text = "Visitor Address :";
            // 
            // txtVisitorName
            // 
            this.txtVisitorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorName.Location = new System.Drawing.Point(123, 62);
            this.txtVisitorName.Name = "txtVisitorName";
            this.txtVisitorName.ReadOnly = true;
            this.txtVisitorName.Size = new System.Drawing.Size(492, 24);
            this.txtVisitorName.TabIndex = 1;
            // 
            // lblVisitorName
            // 
            this.lblVisitorName.AutoSize = true;
            this.lblVisitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVisitorName.Location = new System.Drawing.Point(33, 64);
            this.lblVisitorName.Name = "lblVisitorName";
            this.lblVisitorName.Size = new System.Drawing.Size(86, 13);
            this.lblVisitorName.TabIndex = 0;
            this.lblVisitorName.Text = "Visitor Name :";
            // 
            // cboVisitorType
            // 
            this.cboVisitorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisitorType.Enabled = false;
            this.cboVisitorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVisitorType.ForeColor = System.Drawing.Color.Blue;
            this.cboVisitorType.FormattingEnabled = true;
            this.cboVisitorType.Location = new System.Drawing.Point(123, 24);
            this.cboVisitorType.Name = "cboVisitorType";
            this.cboVisitorType.Size = new System.Drawing.Size(216, 26);
            this.cboVisitorType.TabIndex = 0;
            // 
            // lblVisitorType
            // 
            this.lblVisitorType.AutoSize = true;
            this.lblVisitorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVisitorType.Location = new System.Drawing.Point(37, 28);
            this.lblVisitorType.Name = "lblVisitorType";
            this.lblVisitorType.Size = new System.Drawing.Size(82, 13);
            this.lblVisitorType.TabIndex = 0;
            this.lblVisitorType.Text = "Visitor Type :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHcn);
            this.panel1.Controls.Add(this.smartLabel1);
            this.panel1.Controls.Add(this.lblApproxTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTokenNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 160);
            this.panel1.TabIndex = 0;
            // 
            // lblHcn
            // 
            this.lblHcn.AutoSize = true;
            this.lblHcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHcn.ForeColor = System.Drawing.Color.Red;
            this.lblHcn.Location = new System.Drawing.Point(132, 47);
            this.lblHcn.Name = "lblHcn";
            this.lblHcn.Size = new System.Drawing.Size(36, 15);
            this.lblHcn.TabIndex = 2;
            this.lblHcn.Text = "HCN";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(81, 47);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(40, 14);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "HCN :";
            // 
            // lblApproxTime
            // 
            this.lblApproxTime.AutoSize = true;
            this.lblApproxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApproxTime.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblApproxTime.Location = new System.Drawing.Point(131, 107);
            this.lblApproxTime.Name = "lblApproxTime";
            this.lblApproxTime.Size = new System.Drawing.Size(127, 25);
            this.lblApproxTime.TabIndex = 0;
            this.lblApproxTime.Text = "ApproxTime";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDate.Location = new System.Drawing.Point(131, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblTokenNo
            // 
            this.lblTokenNo.AutoSize = true;
            this.lblTokenNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTokenNo.Location = new System.Drawing.Point(132, 9);
            this.lblTokenNo.Name = "lblTokenNo";
            this.lblTokenNo.Size = new System.Drawing.Size(114, 29);
            this.lblTokenNo.TabIndex = 0;
            this.lblTokenNo.Text = "Serial No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ApproxTime :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial No :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblBookingType);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblDoctor);
            this.panel2.Controls.Add(this.lblVisitType);
            this.panel2.Controls.Add(this.lblService);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(341, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 160);
            this.panel2.TabIndex = 0;
            // 
            // lblBookingType
            // 
            this.lblBookingType.AutoSize = true;
            this.lblBookingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBookingType.Location = new System.Drawing.Point(127, 109);
            this.lblBookingType.Name = "lblBookingType";
            this.lblBookingType.Size = new System.Drawing.Size(101, 20);
            this.lblBookingType.TabIndex = 0;
            this.lblBookingType.Text = "BookingType";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Booking Type :";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(127, 80);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 0;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblVisitType
            // 
            this.lblVisitType.AutoSize = true;
            this.lblVisitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblVisitType.Location = new System.Drawing.Point(127, 47);
            this.lblVisitType.Name = "lblVisitType";
            this.lblVisitType.Size = new System.Drawing.Size(77, 20);
            this.lblVisitType.TabIndex = 0;
            this.lblVisitType.Text = "Visit Type";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblService.Location = new System.Drawing.Point(127, 15);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(43, 13);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(69, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Doctor :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Visit Type :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(65, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Service :";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentID.Location = new System.Drawing.Point(31, 16);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(10, 24);
            this.txtAppointmentID.TabIndex = 11;
            this.txtAppointmentID.Visible = false;
            // 
            // frmAppointPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(670, 637);
            this.isEnterTabAllow = true;
            this.Name = "frmAppointPatientInfo";
            this.Load += new System.EventHandler(this.frmAppointPatientInfo_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private AtiqsControlLibrary.SmartNumericTextBox nmrPhone;
        private AtiqsControlLibrary.SmartNumericTextBox nmrMobile;
        private AtiqsControlLibrary.SmartLabel lblAge;
        private AtiqsControlLibrary.SmartNumericTextBox nmrDay;
        private AtiqsControlLibrary.SmartNumericTextBox nmrMonth;
        private AtiqsControlLibrary.SmartLabel lblDays;
        private AtiqsControlLibrary.SmartLabel lblMonth;
        private AtiqsControlLibrary.SmartNumericTextBox nmrYear;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox1;
        private AtiqsControlLibrary.SmartLabel lblEmail;
        private AtiqsControlLibrary.SmartTextBox txtEmail;
        private AtiqsControlLibrary.SmartComboBox cboStatus;
        private AtiqsControlLibrary.SmartLabel lblStatus;
        private AtiqsControlLibrary.SmartComboBox cboCountry;
        private AtiqsControlLibrary.SmartLabel lblCountry;
        private AtiqsControlLibrary.SmartLabel lblMobile;
        private AtiqsControlLibrary.SmartLabel lblPhone;
        private AtiqsControlLibrary.SmartLabel lblYear;
        private AtiqsControlLibrary.SmartComboBox cboGender;
        private AtiqsControlLibrary.SmartLabel lblGender;
        private AtiqsControlLibrary.SmartTextBox txtVisitorAddress;
        private AtiqsControlLibrary.SmartLabel lblVisitorAddress;
        private AtiqsControlLibrary.SmartTextBox txtVisitorName;
        private AtiqsControlLibrary.SmartLabel lblVisitorName;
        private AtiqsControlLibrary.SmartComboBox cboVisitorType;
        private AtiqsControlLibrary.SmartLabel lblVisitorType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBookingType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblVisitType;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApproxTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTokenNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private AtiqsControlLibrary.SmartLabel lblHcn;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtAppointmentID;
    }
}
