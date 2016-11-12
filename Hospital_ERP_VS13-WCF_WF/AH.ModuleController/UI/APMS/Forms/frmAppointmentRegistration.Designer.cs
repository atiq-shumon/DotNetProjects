namespace AH.ModuleController.UI.APMS.Forms
{
    partial class frmAppointmentRegistration
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
            this.lblAppointmentID = new AtiqsControlLibrary.SmartLabel();
            this.txtAppointmentID = new AtiqsControlLibrary.SmartTextBox();
            this.btnF2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPatientFind = new System.Windows.Forms.Button();
            this.rdTextUnit = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtHCN = new AtiqsControlLibrary.SmartTextBox();
            this.lblUnit = new AtiqsControlLibrary.SmartLabel();
            this.rdTextDepartmentId = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblDepartment = new AtiqsControlLibrary.SmartLabel();
            this.rdTextDoctorId = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblDoctor = new AtiqsControlLibrary.SmartLabel();
            this.HCN = new AtiqsControlLibrary.SmartLabel();
            this.nmrMobile = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lblMobile = new AtiqsControlLibrary.SmartLabel();
            this.cboBookingMode = new AtiqsControlLibrary.SmartComboBox();
            this.lblBookingMode = new AtiqsControlLibrary.SmartLabel();
            this.cboVisitType = new AtiqsControlLibrary.SmartComboBox();
            this.lblVisitType = new AtiqsControlLibrary.SmartLabel();
            this.cboBookingType = new AtiqsControlLibrary.SmartComboBox();
            this.lblBookingType = new AtiqsControlLibrary.SmartLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.brnf2 = new System.Windows.Forms.Button();
            this.txtPMR_ID = new AtiqsControlLibrary.SmartTextBox();
            this.lblPMR_ID = new AtiqsControlLibrary.SmartLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAppointDate = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.lblStartTime = new AtiqsControlLibrary.SmartLabel();
            this.lblAproxTimeFrom = new AtiqsControlLibrary.SmartLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lstPatientList = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDOB = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.nmrPhone = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lblAge = new AtiqsControlLibrary.SmartLabel();
            this.nmrDay = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lblEmail = new AtiqsControlLibrary.SmartLabel();
            this.nmrMonth = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lblDays = new AtiqsControlLibrary.SmartLabel();
            this.txtEmail = new AtiqsControlLibrary.SmartTextBox();
            this.lblMonth = new AtiqsControlLibrary.SmartLabel();
            this.nmrYear = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lblYear = new AtiqsControlLibrary.SmartLabel();
            this.cboCountry = new AtiqsControlLibrary.SmartComboBox();
            this.lblCountry = new AtiqsControlLibrary.SmartLabel();
            this.lblPhone = new AtiqsControlLibrary.SmartLabel();
            this.cboGender = new AtiqsControlLibrary.SmartComboBox();
            this.lblGender = new AtiqsControlLibrary.SmartLabel();
            this.txtVisitorAddress = new AtiqsControlLibrary.SmartTextBox();
            this.lblVisitorAddress = new AtiqsControlLibrary.SmartLabel();
            this.txtVisitorName = new AtiqsControlLibrary.SmartTextBox();
            this.lblVisitorName = new AtiqsControlLibrary.SmartLabel();
            this.cboVisitorType = new AtiqsControlLibrary.SmartComboBox();
            this.lblVisitorType = new AtiqsControlLibrary.SmartLabel();
            this.smartCheckBox1 = new AtiqsControlLibrary.SmartCheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(29, 6);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(349, 10);
            this.frmLabel.Size = new System.Drawing.Size(317, 33);
            this.frmLabel.Text = "Appointment Registration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(795, 488);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblPMR_ID);
            this.pnlTop.Controls.Add(this.lblAppointmentID);
            this.pnlTop.Controls.Add(this.panel2);
            this.pnlTop.Controls.Add(this.txtAppointmentID);
            this.pnlTop.Controls.Add(this.btnF2);
            this.pnlTop.Controls.Add(this.cboBookingType);
            this.pnlTop.Controls.Add(this.lblBookingType);
            this.pnlTop.Size = new System.Drawing.Size(1057, 58);
            this.pnlTop.TabIndex = 1111;
            this.pnlTop.Controls.SetChildIndex(this.lblBookingType, 0);
            this.pnlTop.Controls.SetChildIndex(this.cboBookingType, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnF2, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAppointmentID, 0);
            this.pnlTop.Controls.SetChildIndex(this.panel2, 0);
            this.pnlTop.Controls.SetChildIndex(this.lblAppointmentID, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.lblPMR_ID, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(29, 548);
            this.btnEdit.Size = new System.Drawing.Size(10, 26);
            this.btnEdit.TabIndex = 555;
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(823, 550);
            this.btnSave.Size = new System.Drawing.Size(108, 41);
            this.btnSave.TabIndex = 28;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 548);
            this.btnDelete.Size = new System.Drawing.Size(10, 26);
            this.btnDelete.TabIndex = 555;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(700, 550);
            this.btnNew.Size = new System.Drawing.Size(117, 41);
            this.btnNew.TabIndex = 28555;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(937, 550);
            this.btnClose.Size = new System.Drawing.Size(108, 41);
            this.btnClose.TabIndex = 22222;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(41, 548);
            this.btnPrint.Size = new System.Drawing.Size(10, 26);
            this.btnPrint.TabIndex = 555;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 592);
            this.groupBox1.Size = new System.Drawing.Size(1057, 18);
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentID.Location = new System.Drawing.Point(26, 26);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(102, 13);
            this.lblAppointmentID.TabIndex = 11111;
            this.lblAppointmentID.Text = "Appointment ID :";
            this.lblAppointmentID.Visible = false;
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentID.Location = new System.Drawing.Point(130, 22);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(22, 24);
            this.txtAppointmentID.TabIndex = 5555;
            this.txtAppointmentID.Visible = false;
            // 
            // btnF2
            // 
            this.btnF2.Location = new System.Drawing.Point(260, 24);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(44, 20);
            this.btnF2.TabIndex = 555;
            this.btnF2.Text = "F2";
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPatientFind);
            this.panel1.Controls.Add(this.rdTextUnit);
            this.panel1.Controls.Add(this.txtHCN);
            this.panel1.Controls.Add(this.lblUnit);
            this.panel1.Controls.Add(this.rdTextDepartmentId);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Controls.Add(this.rdTextDoctorId);
            this.panel1.Controls.Add(this.lblDoctor);
            this.panel1.Controls.Add(this.HCN);
            this.panel1.Controls.Add(this.nmrMobile);
            this.panel1.Controls.Add(this.lblMobile);
            this.panel1.Location = new System.Drawing.Point(2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 90);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btnPatientFind
            // 
            this.btnPatientFind.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPatientFind.Location = new System.Drawing.Point(537, 58);
            this.btnPatientFind.Name = "btnPatientFind";
            this.btnPatientFind.Size = new System.Drawing.Size(247, 28);
            this.btnPatientFind.TabIndex = 55;
            this.btnPatientFind.TabStop = false;
            this.btnPatientFind.Text = "Find";
            this.btnPatientFind.UseVisualStyleBackColor = false;
            this.btnPatientFind.Click += new System.EventHandler(this.btnPatientFind_Click);
            // 
            // rdTextUnit
            // 
            this.rdTextUnit.BackColor = System.Drawing.Color.Linen;
            this.rdTextUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rdTextUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTextUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rdTextUnit.Location = new System.Drawing.Point(533, 16);
            this.rdTextUnit.Name = "rdTextUnit";
            this.rdTextUnit.ReadOnly = true;
            this.rdTextUnit.Size = new System.Drawing.Size(251, 24);
            this.rdTextUnit.TabIndex = 1677;
            this.rdTextUnit.TabStop = false;
            // 
            // txtHCN
            // 
            this.txtHCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCN.Location = new System.Drawing.Point(56, 62);
            this.txtHCN.MaxLength = 11;
            this.txtHCN.Name = "txtHCN";
            this.txtHCN.Size = new System.Drawing.Size(204, 24);
            this.txtHCN.TabIndex = 0;
            this.txtHCN.TextChanged += new System.EventHandler(this.txtHCN_TextChanged);
            this.txtHCN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHCN_KeyUp);
            this.txtHCN.Leave += new System.EventHandler(this.txtHCN_Leave);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(534, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(38, 13);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "Unit :";
            // 
            // rdTextDepartmentId
            // 
            this.rdTextDepartmentId.BackColor = System.Drawing.Color.Linen;
            this.rdTextDepartmentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rdTextDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTextDepartmentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rdTextDepartmentId.Location = new System.Drawing.Point(280, 16);
            this.rdTextDepartmentId.Name = "rdTextDepartmentId";
            this.rdTextDepartmentId.ReadOnly = true;
            this.rdTextDepartmentId.Size = new System.Drawing.Size(251, 24);
            this.rdTextDepartmentId.TabIndex = 1577;
            this.rdTextDepartmentId.TabStop = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.Location = new System.Drawing.Point(281, 1);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(80, 13);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department :";
            // 
            // rdTextDoctorId
            // 
            this.rdTextDoctorId.BackColor = System.Drawing.Color.Linen;
            this.rdTextDoctorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rdTextDoctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTextDoctorId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rdTextDoctorId.Location = new System.Drawing.Point(1, 16);
            this.rdTextDoctorId.Name = "rdTextDoctorId";
            this.rdTextDoctorId.ReadOnly = true;
            this.rdTextDoctorId.Size = new System.Drawing.Size(277, 24);
            this.rdTextDoctorId.TabIndex = 1777;
            this.rdTextDoctorId.TabStop = false;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.Location = new System.Drawing.Point(10, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(53, 13);
            this.lblDoctor.TabIndex = 0;
            this.lblDoctor.Text = "Doctor :";
            // 
            // HCN
            // 
            this.HCN.AutoSize = true;
            this.HCN.BackColor = System.Drawing.SystemColors.Info;
            this.HCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.HCN.Location = new System.Drawing.Point(10, 68);
            this.HCN.Name = "HCN";
            this.HCN.Size = new System.Drawing.Size(41, 13);
            this.HCN.TabIndex = 19;
            this.HCN.Text = "HCN :";
            // 
            // nmrMobile
            // 
            this.nmrMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrMobile.Location = new System.Drawing.Point(334, 62);
            this.nmrMobile.MaxLength = 11;
            this.nmrMobile.Name = "nmrMobile";
            this.nmrMobile.Size = new System.Drawing.Size(197, 24);
            this.nmrMobile.TabIndex = 1;
            this.nmrMobile.TextChanged += new System.EventHandler(this.nmrMobile_TextChanged);
            this.nmrMobile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nmrMobile_KeyUp);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.BackColor = System.Drawing.SystemColors.Info;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMobile.Location = new System.Drawing.Point(281, 68);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(52, 13);
            this.lblMobile.TabIndex = 0;
            this.lblMobile.Text = "Mobile :";
            // 
            // cboBookingMode
            // 
            this.cboBookingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBookingMode.ForeColor = System.Drawing.Color.Blue;
            this.cboBookingMode.FormattingEnabled = true;
            this.cboBookingMode.Location = new System.Drawing.Point(445, 259);
            this.cboBookingMode.Name = "cboBookingMode";
            this.cboBookingMode.Size = new System.Drawing.Size(218, 26);
            this.cboBookingMode.TabIndex = 27;
            // 
            // lblBookingMode
            // 
            this.lblBookingMode.AutoSize = true;
            this.lblBookingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBookingMode.Location = new System.Drawing.Point(345, 263);
            this.lblBookingMode.Name = "lblBookingMode";
            this.lblBookingMode.Size = new System.Drawing.Size(96, 13);
            this.lblBookingMode.TabIndex = 0;
            this.lblBookingMode.Text = "Booking Mode :";
            // 
            // cboVisitType
            // 
            this.cboVisitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVisitType.ForeColor = System.Drawing.Color.Blue;
            this.cboVisitType.FormattingEnabled = true;
            this.cboVisitType.Location = new System.Drawing.Point(445, 185);
            this.cboVisitType.Name = "cboVisitType";
            this.cboVisitType.Size = new System.Drawing.Size(218, 26);
            this.cboVisitType.TabIndex = 25;
            // 
            // lblVisitType
            // 
            this.lblVisitType.AutoSize = true;
            this.lblVisitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVisitType.Location = new System.Drawing.Point(370, 193);
            this.lblVisitType.Name = "lblVisitType";
            this.lblVisitType.Size = new System.Drawing.Size(71, 13);
            this.lblVisitType.TabIndex = 0;
            this.lblVisitType.Text = "Visit Type :";
            // 
            // cboBookingType
            // 
            this.cboBookingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBookingType.ForeColor = System.Drawing.Color.Blue;
            this.cboBookingType.FormattingEnabled = true;
            this.cboBookingType.Location = new System.Drawing.Point(48, 3);
            this.cboBookingType.Name = "cboBookingType";
            this.cboBookingType.Size = new System.Drawing.Size(42, 26);
            this.cboBookingType.TabIndex = 555;
            this.cboBookingType.Visible = false;
            // 
            // lblBookingType
            // 
            this.lblBookingType.AutoSize = true;
            this.lblBookingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBookingType.Location = new System.Drawing.Point(97, 3);
            this.lblBookingType.Name = "lblBookingType";
            this.lblBookingType.Size = new System.Drawing.Size(93, 13);
            this.lblBookingType.TabIndex = 1111;
            this.lblBookingType.Text = "Booking Type :";
            this.lblBookingType.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.brnf2);
            this.panel2.Controls.Add(this.txtPMR_ID);
            this.panel2.Location = new System.Drawing.Point(168, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 16);
            this.panel2.TabIndex = 199;
            this.panel2.Visible = false;
            // 
            // brnf2
            // 
            this.brnf2.Location = new System.Drawing.Point(212, 5);
            this.brnf2.Name = "brnf2";
            this.brnf2.Size = new System.Drawing.Size(52, 27);
            this.brnf2.TabIndex = 21;
            this.brnf2.Text = "F2";
            this.brnf2.UseVisualStyleBackColor = true;
            // 
            // txtPMR_ID
            // 
            this.txtPMR_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPMR_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPMR_ID.Location = new System.Drawing.Point(66, 8);
            this.txtPMR_ID.Name = "txtPMR_ID";
            this.txtPMR_ID.Size = new System.Drawing.Size(142, 24);
            this.txtPMR_ID.TabIndex = 20;
            // 
            // lblPMR_ID
            // 
            this.lblPMR_ID.AutoSize = true;
            this.lblPMR_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPMR_ID.Location = new System.Drawing.Point(162, 33);
            this.lblPMR_ID.Name = "lblPMR_ID";
            this.lblPMR_ID.Size = new System.Drawing.Size(62, 13);
            this.lblPMR_ID.TabIndex = 555;
            this.lblPMR_ID.Text = "PMR_ID :";
            this.lblPMR_ID.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Controls.Add(this.lblAppointDate);
            this.panel3.Controls.Add(this.smartLabel10);
            this.panel3.Controls.Add(this.lblStartTime);
            this.panel3.Controls.Add(this.lblAproxTimeFrom);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 53);
            this.panel3.TabIndex = 14;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // lblAppointDate
            // 
            this.lblAppointDate.BackColor = System.Drawing.Color.MintCream;
            this.lblAppointDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAppointDate.ForeColor = System.Drawing.Color.Red;
            this.lblAppointDate.Location = new System.Drawing.Point(250, 17);
            this.lblAppointDate.Name = "lblAppointDate";
            this.lblAppointDate.Size = new System.Drawing.Size(109, 20);
            this.lblAppointDate.TabIndex = 1;
            this.lblAppointDate.Text = "Start Time";
            this.lblAppointDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(126, 24);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(108, 13);
            this.smartLabel10.TabIndex = 2;
            this.smartLabel10.Text = "Appointment Date";
            // 
            // lblStartTime
            // 
            this.lblStartTime.BackColor = System.Drawing.Color.MintCream;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStartTime.ForeColor = System.Drawing.Color.Red;
            this.lblStartTime.Location = new System.Drawing.Point(512, 17);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(109, 20);
            this.lblStartTime.TabIndex = 0;
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAproxTimeFrom
            // 
            this.lblAproxTimeFrom.AutoSize = true;
            this.lblAproxTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAproxTimeFrom.Location = new System.Drawing.Point(381, 24);
            this.lblAproxTimeFrom.Name = "lblAproxTimeFrom";
            this.lblAproxTimeFrom.Size = new System.Drawing.Size(116, 13);
            this.lblAproxTimeFrom.TabIndex = 0;
            this.lblAproxTimeFrom.Text = "Appointment  Time ";
            this.lblAproxTimeFrom.Click += new System.EventHandler(this.lblAproxTimeFrom_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lstPatientList);
            this.panel4.Controls.Add(this.smartLabel3);
            this.panel4.Controls.Add(this.smartLabel4);
            this.panel4.Controls.Add(this.smartLabel2);
            this.panel4.Controls.Add(this.txtDOB);
            this.panel4.Controls.Add(this.smartLabel9);
            this.panel4.Controls.Add(this.smartLabel8);
            this.panel4.Controls.Add(this.smartLabel7);
            this.panel4.Controls.Add(this.smartLabel1);
            this.panel4.Controls.Add(this.cboBookingMode);
            this.panel4.Controls.Add(this.lblBookingMode);
            this.panel4.Controls.Add(this.nmrPhone);
            this.panel4.Controls.Add(this.cboVisitType);
            this.panel4.Controls.Add(this.lblVisitType);
            this.panel4.Controls.Add(this.lblAge);
            this.panel4.Controls.Add(this.nmrDay);
            this.panel4.Controls.Add(this.lblEmail);
            this.panel4.Controls.Add(this.nmrMonth);
            this.panel4.Controls.Add(this.lblDays);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.lblMonth);
            this.panel4.Controls.Add(this.nmrYear);
            this.panel4.Controls.Add(this.lblYear);
            this.panel4.Controls.Add(this.cboCountry);
            this.panel4.Controls.Add(this.lblCountry);
            this.panel4.Controls.Add(this.lblPhone);
            this.panel4.Controls.Add(this.cboGender);
            this.panel4.Controls.Add(this.lblGender);
            this.panel4.Controls.Add(this.txtVisitorAddress);
            this.panel4.Controls.Add(this.lblVisitorAddress);
            this.panel4.Controls.Add(this.txtVisitorName);
            this.panel4.Controls.Add(this.lblVisitorName);
            this.panel4.Controls.Add(this.cboVisitorType);
            this.panel4.Controls.Add(this.lblVisitorType);
            this.panel4.Location = new System.Drawing.Point(2, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 342);
            this.panel4.TabIndex = 0;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            // 
            // lstPatientList
            // 
            this.lstPatientList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstPatientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPatientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPatientList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPatientList.FullRowSelect = true;
            this.lstPatientList.GridLines = true;
            this.lstPatientList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPatientList.Location = new System.Drawing.Point(334, 3);
            this.lstPatientList.Name = "lstPatientList";
            this.lstPatientList.Size = new System.Drawing.Size(449, 85);
            this.lstPatientList.TabIndex = 28556;
            this.lstPatientList.UseCompatibleStateImageBehavior = false;
            this.lstPatientList.View = System.Windows.Forms.View.Details;
            this.lstPatientList.SelectedIndexChanged += new System.EventHandler(this.lstPatientList_SelectedIndexChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.ForeColor = System.Drawing.Color.Red;
            this.smartLabel3.Location = new System.Drawing.Point(333, 144);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(14, 16);
            this.smartLabel3.TabIndex = 29;
            this.smartLabel3.Text = "*";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.Color.Red;
            this.smartLabel4.Location = new System.Drawing.Point(669, 148);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(14, 16);
            this.smartLabel4.TabIndex = 28;
            this.smartLabel4.Text = "*";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(259, 128);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(33, 13);
            this.smartLabel2.TabIndex = 27;
            this.smartLabel2.Text = "DOB";
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDOB.Location = new System.Drawing.Point(232, 144);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 24);
            this.txtDOB.TabIndex = 20;
            this.txtDOB.ValidatingType = typeof(System.DateTime);
            this.txtDOB.TextChanged += new System.EventHandler(this.txtDOB_TextChanged);
            this.txtDOB.Validated += new System.EventHandler(this.txtDOB_Validated);
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.ForeColor = System.Drawing.Color.Red;
            this.smartLabel9.Location = new System.Drawing.Point(669, 63);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(15, 18);
            this.smartLabel9.TabIndex = 25;
            this.smartLabel9.Text = "*";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.ForeColor = System.Drawing.Color.Red;
            this.smartLabel8.Location = new System.Drawing.Point(669, 20);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(15, 18);
            this.smartLabel8.TabIndex = 24;
            this.smartLabel8.Text = "*";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.Red;
            this.smartLabel7.Location = new System.Drawing.Point(333, 183);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(14, 16);
            this.smartLabel7.TabIndex = 23;
            this.smartLabel7.Text = "*";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.ForeColor = System.Drawing.Color.Red;
            this.smartLabel1.Location = new System.Drawing.Point(669, 184);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(14, 16);
            this.smartLabel1.TabIndex = 22;
            this.smartLabel1.Text = "*";
            // 
            // nmrPhone
            // 
            this.nmrPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrPhone.Location = new System.Drawing.Point(127, 261);
            this.nmrPhone.MaxLength = 7;
            this.nmrPhone.Name = "nmrPhone";
            this.nmrPhone.Size = new System.Drawing.Size(205, 24);
            this.nmrPhone.TabIndex = 23;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(79, 148);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age :";
            // 
            // nmrDay
            // 
            this.nmrDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrDay.Location = new System.Drawing.Point(196, 144);
            this.nmrDay.MaxLength = 2;
            this.nmrDay.Name = "nmrDay";
            this.nmrDay.Size = new System.Drawing.Size(29, 24);
            this.nmrDay.TabIndex = 19;
            this.nmrDay.TextChanged += new System.EventHandler(this.nmrDay_TextChanged);
            this.nmrDay.Leave += new System.EventHandler(this.nmrDay_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(71, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email :";
            // 
            // nmrMonth
            // 
            this.nmrMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrMonth.Location = new System.Drawing.Point(162, 144);
            this.nmrMonth.MaxLength = 2;
            this.nmrMonth.Name = "nmrMonth";
            this.nmrMonth.Size = new System.Drawing.Size(29, 24);
            this.nmrMonth.TabIndex = 18;
            this.nmrMonth.TextChanged += new System.EventHandler(this.nmrMonth_TextChanged);
            this.nmrMonth.Leave += new System.EventHandler(this.nmrMonth_Leave);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDays.Location = new System.Drawing.Point(201, 130);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(16, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "D";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(127, 218);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 24);
            this.txtEmail.TabIndex = 22;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(167, 130);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 13);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "M";
            // 
            // nmrYear
            // 
            this.nmrYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrYear.Location = new System.Drawing.Point(127, 144);
            this.nmrYear.MaxLength = 3;
            this.nmrYear.Name = "nmrYear";
            this.nmrYear.Size = new System.Drawing.Size(29, 24);
            this.nmrYear.TabIndex = 17;
            this.nmrYear.TextChanged += new System.EventHandler(this.nmrYear_TextChanged);
            this.nmrYear.Leave += new System.EventHandler(this.nmrYear_Leave);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(133, 130);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(15, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Y";
            // 
            // cboCountry
            // 
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.ForeColor = System.Drawing.Color.Blue;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(445, 144);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(218, 26);
            this.cboCountry.TabIndex = 24;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCountry.Location = new System.Drawing.Point(375, 148);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(66, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country  : ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(29, 265);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Home Phone :";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.ForeColor = System.Drawing.Color.Blue;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(127, 179);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(204, 26);
            this.cboGender.TabIndex = 21;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(60, 182);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender :";
            // 
            // txtVisitorAddress
            // 
            this.txtVisitorAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorAddress.Location = new System.Drawing.Point(126, 61);
            this.txtVisitorAddress.MaxLength = 200;
            this.txtVisitorAddress.Multiline = true;
            this.txtVisitorAddress.Name = "txtVisitorAddress";
            this.txtVisitorAddress.Size = new System.Drawing.Size(537, 57);
            this.txtVisitorAddress.TabIndex = 16;
            // 
            // lblVisitorAddress
            // 
            this.lblVisitorAddress.AutoSize = true;
            this.lblVisitorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVisitorAddress.Location = new System.Drawing.Point(17, 67);
            this.lblVisitorAddress.Name = "lblVisitorAddress";
            this.lblVisitorAddress.Size = new System.Drawing.Size(99, 13);
            this.lblVisitorAddress.TabIndex = 0;
            this.lblVisitorAddress.Text = "Visitor Address :";
            // 
            // txtVisitorName
            // 
            this.txtVisitorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorName.Location = new System.Drawing.Point(127, 17);
            this.txtVisitorName.MaxLength = 50;
            this.txtVisitorName.Name = "txtVisitorName";
            this.txtVisitorName.Size = new System.Drawing.Size(537, 24);
            this.txtVisitorName.TabIndex = 15;
            this.txtVisitorName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtVisitorName_MouseClick);
            // 
            // lblVisitorName
            // 
            this.lblVisitorName.AutoSize = true;
            this.lblVisitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVisitorName.Location = new System.Drawing.Point(30, 19);
            this.lblVisitorName.Name = "lblVisitorName";
            this.lblVisitorName.Size = new System.Drawing.Size(86, 13);
            this.lblVisitorName.TabIndex = 0;
            this.lblVisitorName.Text = "Visitor Name :";
            // 
            // cboVisitorType
            // 
            this.cboVisitorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisitorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVisitorType.ForeColor = System.Drawing.Color.Blue;
            this.cboVisitorType.FormattingEnabled = true;
            this.cboVisitorType.Location = new System.Drawing.Point(445, 222);
            this.cboVisitorType.Name = "cboVisitorType";
            this.cboVisitorType.Size = new System.Drawing.Size(218, 26);
            this.cboVisitorType.TabIndex = 26;
            // 
            // lblVisitorType
            // 
            this.lblVisitorType.AutoSize = true;
            this.lblVisitorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVisitorType.Location = new System.Drawing.Point(359, 229);
            this.lblVisitorType.Name = "lblVisitorType";
            this.lblVisitorType.Size = new System.Drawing.Size(82, 13);
            this.lblVisitorType.TabIndex = 0;
            this.lblVisitorType.Text = "Visitor Type :";
            // 
            // smartCheckBox1
            // 
            this.smartCheckBox1.AutoSize = true;
            this.smartCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox1.Location = new System.Drawing.Point(57, 551);
            this.smartCheckBox1.Name = "smartCheckBox1";
            this.smartCheckBox1.Size = new System.Drawing.Size(139, 22);
            this.smartCheckBox1.TabIndex = 47;
            this.smartCheckBox1.Text = "smartCheckBox1";
            this.smartCheckBox1.UseVisualStyleBackColor = true;
            this.smartCheckBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 9);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.AllowUserToResizeColumns = false;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvAppointment.Location = new System.Drawing.Point(794, 57);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowHeadersVisible = false;
            this.dgvAppointment.RowHeadersWidth = 115;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(263, 487);
            this.dgvAppointment.TabIndex = 48;
            this.dgvAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellClick);
            this.dgvAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellContentClick);
            // 
            // frmAppointmentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1057, 610);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.smartCheckBox1);
            this.isEnterTabAllow = true;
            this.Name = "frmAppointmentRegistration";
            this.Load += new System.EventHandler(this.frmAppointmentRegistration_Load);
            this.Controls.SetChildIndex(this.smartCheckBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dgvAppointment, 0);
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
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AtiqsControlLibrary.SmartLabel lblDoctor;
        private AtiqsControlLibrary.SmartComboBox cboVisitType;
        private AtiqsControlLibrary.SmartLabel lblVisitType;
        private System.Windows.Forms.Button btnF2;
        private AtiqsControlLibrary.SmartTextBox txtAppointmentID;
        private AtiqsControlLibrary.SmartLabel lblAppointmentID;
        private System.Windows.Forms.Panel panel3;
        private AtiqsControlLibrary.SmartLabel lblAproxTimeFrom;
        private AtiqsControlLibrary.SmartComboBox cboBookingMode;
        private AtiqsControlLibrary.SmartLabel lblBookingMode;
        private AtiqsControlLibrary.SmartComboBox cboBookingType;
        private AtiqsControlLibrary.SmartLabel lblBookingType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button brnf2;
        private AtiqsControlLibrary.SmartTextBox txtPMR_ID;
        private AtiqsControlLibrary.SmartLabel lblPMR_ID;
        private System.Windows.Forms.Button button1;
        private AtiqsControlLibrary.SmartLabel lblStartTime;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox rdTextUnit;
        private AtiqsControlLibrary.SmartLabel lblUnit;
        private AtiqsControlLibrary.SmartReadOnlyTextBox rdTextDepartmentId;
        private AtiqsControlLibrary.SmartLabel lblDepartment;
        private AtiqsControlLibrary.SmartReadOnlyTextBox rdTextDoctorId;
        private AtiqsControlLibrary.SmartNumericTextBox nmrPhone;
        private AtiqsControlLibrary.SmartNumericTextBox nmrMobile;
        private AtiqsControlLibrary.SmartLabel lblAge;
        private AtiqsControlLibrary.SmartNumericTextBox nmrDay;
        private AtiqsControlLibrary.SmartLabel lblEmail;
        private AtiqsControlLibrary.SmartNumericTextBox nmrMonth;
        private AtiqsControlLibrary.SmartLabel lblDays;
        private AtiqsControlLibrary.SmartTextBox txtEmail;
        private AtiqsControlLibrary.SmartLabel lblMonth;
        private AtiqsControlLibrary.SmartNumericTextBox nmrYear;
        private AtiqsControlLibrary.SmartLabel lblYear;
        private AtiqsControlLibrary.SmartComboBox cboCountry;
        private AtiqsControlLibrary.SmartLabel lblCountry;
        private AtiqsControlLibrary.SmartLabel lblMobile;
        private AtiqsControlLibrary.SmartLabel lblPhone;
        private AtiqsControlLibrary.SmartComboBox cboGender;
        private AtiqsControlLibrary.SmartLabel lblGender;
        private AtiqsControlLibrary.SmartTextBox txtVisitorAddress;
        private AtiqsControlLibrary.SmartLabel lblVisitorAddress;
        private AtiqsControlLibrary.SmartTextBox txtVisitorName;
        private AtiqsControlLibrary.SmartLabel lblVisitorName;
        private AtiqsControlLibrary.SmartComboBox cboVisitorType;
        private AtiqsControlLibrary.SmartLabel lblVisitorType;
        private AtiqsControlLibrary.SmartLabel HCN;
        private AtiqsControlLibrary.SmartTextBox txtHCN;
        private System.Windows.Forms.Button btnPatientFind;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel lblAppointDate;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartDateTextBox txtDOB;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartListViewDetails lstPatientList;
    }
}
