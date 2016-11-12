namespace AH.ModuleController.UI.EPMS.Forms
{
    partial class frmEmergencyCollectionEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTicketType = new AtiqsControlLibrary.SmartLabel();
            this.cboTicketType = new AtiqsControlLibrary.SmartComboBox();
            this.txtHCNNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel19 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtSex = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtPresentAddress = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeHours = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeDays = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeMonths = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblAge = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeYears = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblMobileNo = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshDoc = new System.Windows.Forms.Button();
            this.btnAddReffDoc = new System.Windows.Forms.Button();
            this.btnRefreshOrg = new System.Windows.Forms.Button();
            this.btnAddReffOrg = new System.Windows.Forms.Button();
            this.cboReffDoc = new AtiqsControlLibrary.SmartComboBox();
            this.lblReffOrg = new AtiqsControlLibrary.SmartLabel();
            this.cboReffOrg = new AtiqsControlLibrary.SmartComboBox();
            this.lblDoctor = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.dgvCollectionHead = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvAssignedCollectionHead = new AtiqsControlLibrary.SmartDataGridView();
            this.txtSearchCollHead = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lblTestCount = new System.Windows.Forms.Label();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lblTestAmountSummary = new System.Windows.Forms.Label();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.txtMoneyReceiptNo = new System.Windows.Forms.TextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.chkAdmAdv = new AtiqsControlLibrary.SmartCheckBox();
            this.cboAdmDeptGrp = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel20 = new AtiqsControlLibrary.SmartLabel();
            this.cboAdmDept = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.cboAdmUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel23 = new AtiqsControlLibrary.SmartLabel();
            this.cboadmDoctorID = new AtiqsControlLibrary.SmartComboBox();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollectionHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedCollectionHead)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(578, 9);
            this.frmLabel.Size = new System.Drawing.Size(344, 33);
            this.frmLabel.Text = "Emergency Procedure Entry";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.btnAddTest);
            this.pnlMain.Controls.Add(this.smartLabel23);
            this.pnlMain.Controls.Add(this.cboadmDoctorID);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.cboAdmUnit);
            this.pnlMain.Controls.Add(this.cboAdmDeptGrp);
            this.pnlMain.Controls.Add(this.smartLabel18);
            this.pnlMain.Controls.Add(this.smartLabel20);
            this.pnlMain.Controls.Add(this.cboAdmDept);
            this.pnlMain.Controls.Add(this.chkAdmAdv);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtMoneyReceiptNo);
            this.pnlMain.Controls.Add(this.lblTestAmountSummary);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.lblTestCount);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtSearchCollHead);
            this.pnlMain.Controls.Add(this.dgvAssignedCollectionHead);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.dgvCollectionHead);
            this.pnlMain.Controls.Add(this.cboDepartmentGroup);
            this.pnlMain.Controls.Add(this.smartLabel22);
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.smartLabel21);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.lblMobileNo);
            this.pnlMain.Controls.Add(this.txtMobileNo);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtSex);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtPresentAddress);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.txtAgeHours);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtAgeDays);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtAgeMonths);
            this.pnlMain.Controls.Add(this.lblAge);
            this.pnlMain.Controls.Add(this.txtAgeYears);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtPatientName);
            this.pnlMain.Controls.Add(this.txtHCNNo);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.lblTicketType);
            this.pnlMain.Controls.Add(this.cboTicketType);
            this.pnlMain.Size = new System.Drawing.Size(1492, 892);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1492, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(77, 811);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1265, 812);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 811);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(1152, 812);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1377, 812);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(245, 812);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 851);
            this.groupBox1.Size = new System.Drawing.Size(1492, 25);
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTicketType.Location = new System.Drawing.Point(6, 149);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(104, 15);
            this.lblTicketType.TabIndex = 38;
            this.lblTicketType.Text = "Prescription Type";
            // 
            // cboTicketType
            // 
            this.cboTicketType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTicketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTicketType.ForeColor = System.Drawing.Color.Blue;
            this.cboTicketType.FormattingEnabled = true;
            this.cboTicketType.Location = new System.Drawing.Point(6, 169);
            this.cboTicketType.Name = "cboTicketType";
            this.cboTicketType.Size = new System.Drawing.Size(167, 26);
            this.cboTicketType.TabIndex = 37;
            // 
            // txtHCNNo
            // 
            this.txtHCNNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCNNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCNNo.ForeColor = System.Drawing.Color.Red;
            this.txtHCNNo.Location = new System.Drawing.Point(179, 168);
            this.txtHCNNo.MaxLength = 11;
            this.txtHCNNo.Name = "txtHCNNo";
            this.txtHCNNo.Size = new System.Drawing.Size(247, 29);
            this.txtHCNNo.TabIndex = 0;
            this.txtHCNNo.TextChanged += new System.EventHandler(this.txtHCNNo_TextChanged);
            this.txtHCNNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHCNNo_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(432, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 30);
            this.btnSearch.TabIndex = 83;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(176, 149);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(34, 15);
            this.smartLabel2.TabIndex = 82;
            this.smartLabel2.Text = "HCN";
            // 
            // smartLabel19
            // 
            this.smartLabel19.AutoSize = true;
            this.smartLabel19.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel19.Location = new System.Drawing.Point(321, 808);
            this.smartLabel19.Name = "smartLabel19";
            this.smartLabel19.Size = new System.Drawing.Size(105, 15);
            this.smartLabel19.TabIndex = 105;
            this.smartLabel19.Text = "Money Receipt No";
            this.smartLabel19.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(505, 201);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(47, 15);
            this.smartLabel6.TabIndex = 104;
            this.smartLabel6.Text = "Gender";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.Linen;
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSex.Location = new System.Drawing.Point(508, 221);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(114, 24);
            this.txtSex.TabIndex = 103;
            this.txtSex.TabStop = false;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(941, 201);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(55, 15);
            this.smartLabel12.TabIndex = 102;
            this.smartLabel12.Text = "Address ";
            // 
            // txtPresentAddress
            // 
            this.txtPresentAddress.BackColor = System.Drawing.Color.Linen;
            this.txtPresentAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPresentAddress.Location = new System.Drawing.Point(944, 221);
            this.txtPresentAddress.Multiline = true;
            this.txtPresentAddress.Name = "txtPresentAddress";
            this.txtPresentAddress.ReadOnly = true;
            this.txtPresentAddress.Size = new System.Drawing.Size(535, 24);
            this.txtPresentAddress.TabIndex = 101;
            this.txtPresentAddress.TabStop = false;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(863, 203);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(46, 15);
            this.smartLabel11.TabIndex = 100;
            this.smartLabel11.Text = "Age(H)";
            // 
            // txtAgeHours
            // 
            this.txtAgeHours.BackColor = System.Drawing.Color.Linen;
            this.txtAgeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeHours.Location = new System.Drawing.Point(866, 221);
            this.txtAgeHours.Name = "txtAgeHours";
            this.txtAgeHours.ReadOnly = true;
            this.txtAgeHours.Size = new System.Drawing.Size(73, 24);
            this.txtAgeHours.TabIndex = 99;
            this.txtAgeHours.TabStop = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(782, 201);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(46, 15);
            this.smartLabel9.TabIndex = 98;
            this.smartLabel9.Text = "Age(D)";
            // 
            // txtAgeDays
            // 
            this.txtAgeDays.BackColor = System.Drawing.Color.Linen;
            this.txtAgeDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeDays.Location = new System.Drawing.Point(785, 221);
            this.txtAgeDays.Name = "txtAgeDays";
            this.txtAgeDays.ReadOnly = true;
            this.txtAgeDays.Size = new System.Drawing.Size(75, 24);
            this.txtAgeDays.TabIndex = 97;
            this.txtAgeDays.TabStop = false;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(714, 201);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(48, 15);
            this.smartLabel8.TabIndex = 96;
            this.smartLabel8.Text = "Age(M)";
            // 
            // txtAgeMonths
            // 
            this.txtAgeMonths.BackColor = System.Drawing.Color.Linen;
            this.txtAgeMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeMonths.Location = new System.Drawing.Point(717, 221);
            this.txtAgeMonths.Name = "txtAgeMonths";
            this.txtAgeMonths.ReadOnly = true;
            this.txtAgeMonths.Size = new System.Drawing.Size(61, 24);
            this.txtAgeMonths.TabIndex = 95;
            this.txtAgeMonths.TabStop = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(630, 201);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 15);
            this.lblAge.TabIndex = 94;
            this.lblAge.Text = "Age(Y)";
            // 
            // txtAgeYears
            // 
            this.txtAgeYears.BackColor = System.Drawing.Color.Linen;
            this.txtAgeYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeYears.Location = new System.Drawing.Point(628, 221);
            this.txtAgeYears.Name = "txtAgeYears";
            this.txtAgeYears.ReadOnly = true;
            this.txtAgeYears.Size = new System.Drawing.Size(83, 24);
            this.txtAgeYears.TabIndex = 93;
            this.txtAgeYears.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(6, 201);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(80, 15);
            this.smartLabel3.TabIndex = 92;
            this.smartLabel3.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(6, 221);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(494, 24);
            this.txtPatientName.TabIndex = 91;
            this.txtPatientName.TabStop = false;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Enabled = false;
            this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.ForeColor = System.Drawing.Color.Red;
            this.txtMobileNo.Location = new System.Drawing.Point(717, 168);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(222, 29);
            this.txtMobileNo.TabIndex = 121;
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.BackColor = System.Drawing.Color.Transparent;
            this.lblMobileNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMobileNo.Location = new System.Drawing.Point(714, 149);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(62, 15);
            this.lblMobileNo.TabIndex = 123;
            this.lblMobileNo.Text = "Mobile No";
            // 
            // btnRefreshDoc
            // 
            this.btnRefreshDoc.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDoc.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDoc.Location = new System.Drawing.Point(889, 824);
            this.btnRefreshDoc.Name = "btnRefreshDoc";
            this.btnRefreshDoc.Size = new System.Drawing.Size(33, 26);
            this.btnRefreshDoc.TabIndex = 155;
            this.btnRefreshDoc.TabStop = false;
            this.btnRefreshDoc.Text = "..";
            this.btnRefreshDoc.UseVisualStyleBackColor = false;
            this.btnRefreshDoc.Visible = false;
            this.btnRefreshDoc.Click += new System.EventHandler(this.btnRefreshDoc_Click);
            // 
            // btnAddReffDoc
            // 
            this.btnAddReffDoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddReffDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReffDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReffDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReffDoc.ForeColor = System.Drawing.Color.White;
            this.btnAddReffDoc.Location = new System.Drawing.Point(848, 824);
            this.btnAddReffDoc.Name = "btnAddReffDoc";
            this.btnAddReffDoc.Size = new System.Drawing.Size(37, 26);
            this.btnAddReffDoc.TabIndex = 154;
            this.btnAddReffDoc.TabStop = false;
            this.btnAddReffDoc.Text = "+";
            this.btnAddReffDoc.UseVisualStyleBackColor = false;
            this.btnAddReffDoc.Visible = false;
            this.btnAddReffDoc.Click += new System.EventHandler(this.btnAddReffDoc_Click);
            // 
            // btnRefreshOrg
            // 
            this.btnRefreshOrg.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshOrg.ForeColor = System.Drawing.Color.White;
            this.btnRefreshOrg.Location = new System.Drawing.Point(698, 824);
            this.btnRefreshOrg.Name = "btnRefreshOrg";
            this.btnRefreshOrg.Size = new System.Drawing.Size(33, 26);
            this.btnRefreshOrg.TabIndex = 153;
            this.btnRefreshOrg.TabStop = false;
            this.btnRefreshOrg.Text = "..";
            this.btnRefreshOrg.UseVisualStyleBackColor = false;
            this.btnRefreshOrg.Visible = false;
            this.btnRefreshOrg.Click += new System.EventHandler(this.btnRefreshOrg_Click);
            // 
            // btnAddReffOrg
            // 
            this.btnAddReffOrg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddReffOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReffOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReffOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReffOrg.ForeColor = System.Drawing.Color.White;
            this.btnAddReffOrg.Location = new System.Drawing.Point(660, 824);
            this.btnAddReffOrg.Name = "btnAddReffOrg";
            this.btnAddReffOrg.Size = new System.Drawing.Size(37, 26);
            this.btnAddReffOrg.TabIndex = 152;
            this.btnAddReffOrg.TabStop = false;
            this.btnAddReffOrg.Text = "+";
            this.btnAddReffOrg.UseVisualStyleBackColor = false;
            this.btnAddReffOrg.Visible = false;
            this.btnAddReffOrg.Click += new System.EventHandler(this.btnAddReffOrg_Click);
            // 
            // cboReffDoc
            // 
            this.cboReffDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReffDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReffDoc.ForeColor = System.Drawing.Color.Blue;
            this.cboReffDoc.FormattingEnabled = true;
            this.cboReffDoc.Location = new System.Drawing.Point(737, 824);
            this.cboReffDoc.Name = "cboReffDoc";
            this.cboReffDoc.Size = new System.Drawing.Size(101, 26);
            this.cboReffDoc.TabIndex = 151;
            this.cboReffDoc.Visible = false;
            // 
            // lblReffOrg
            // 
            this.lblReffOrg.AutoSize = true;
            this.lblReffOrg.BackColor = System.Drawing.Color.Transparent;
            this.lblReffOrg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReffOrg.Location = new System.Drawing.Point(504, 805);
            this.lblReffOrg.Name = "lblReffOrg";
            this.lblReffOrg.Size = new System.Drawing.Size(132, 15);
            this.lblReffOrg.TabIndex = 150;
            this.lblReffOrg.Text = "Referred Organization";
            this.lblReffOrg.Visible = false;
            // 
            // cboReffOrg
            // 
            this.cboReffOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReffOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReffOrg.ForeColor = System.Drawing.Color.Blue;
            this.cboReffOrg.FormattingEnabled = true;
            this.cboReffOrg.Location = new System.Drawing.Point(505, 825);
            this.cboReffOrg.Name = "cboReffOrg";
            this.cboReffOrg.Size = new System.Drawing.Size(144, 26);
            this.cboReffOrg.TabIndex = 149;
            this.cboReffOrg.Visible = false;
            this.cboReffOrg.SelectedIndexChanged += new System.EventHandler(this.cboReffOrg_SelectedIndexChanged);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.Location = new System.Drawing.Point(734, 804);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(96, 15);
            this.lblDoctor.TabIndex = 143;
            this.lblDoctor.Text = "Referred Doctor";
            this.lblDoctor.Visible = false;
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(1214, 169);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(98, 26);
            this.cboDepartmentGroup.TabIndex = 219;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(1211, 149);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(41, 13);
            this.smartLabel22.TabIndex = 224;
            this.smartLabel22.Text = "Group";
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(1107, 169);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(101, 26);
            this.cboDepartmentType.TabIndex = 218;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(1104, 149);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(104, 13);
            this.smartLabel21.TabIndex = 223;
            this.smartLabel21.Text = "Department Type";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(1428, 149);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(30, 13);
            this.smartLabel5.TabIndex = 222;
            this.smartLabel5.Text = "Unit";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(1431, 169);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(48, 26);
            this.cboUnit.TabIndex = 220;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(1315, 149);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(72, 13);
            this.smartLabel7.TabIndex = 221;
            this.smartLabel7.Text = "Department";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(1318, 169);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(107, 26);
            this.cboDepartment.TabIndex = 217;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // dgvCollectionHead
            // 
            this.dgvCollectionHead.AllowUserToAddRows = false;
            this.dgvCollectionHead.AllowUserToDeleteRows = false;
            this.dgvCollectionHead.AllowUserToOrderColumns = true;
            this.dgvCollectionHead.AllowUserToResizeColumns = false;
            this.dgvCollectionHead.AllowUserToResizeRows = false;
            this.dgvCollectionHead.BackgroundColor = System.Drawing.Color.White;
            this.dgvCollectionHead.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCollectionHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCollectionHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCollectionHead.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCollectionHead.Location = new System.Drawing.Point(1, 308);
            this.dgvCollectionHead.MultiSelect = false;
            this.dgvCollectionHead.Name = "dgvCollectionHead";
            this.dgvCollectionHead.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvCollectionHead.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCollectionHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCollectionHead.Size = new System.Drawing.Size(662, 557);
            this.dgvCollectionHead.TabIndex = 226;
            this.dgvCollectionHead.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCollectionHead_CellDoubleClick);
            // 
            // dgvAssignedCollectionHead
            // 
            this.dgvAssignedCollectionHead.AllowUserToAddRows = false;
            this.dgvAssignedCollectionHead.AllowUserToDeleteRows = false;
            this.dgvAssignedCollectionHead.AllowUserToOrderColumns = true;
            this.dgvAssignedCollectionHead.AllowUserToResizeColumns = false;
            this.dgvAssignedCollectionHead.AllowUserToResizeRows = false;
            this.dgvAssignedCollectionHead.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignedCollectionHead.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAssignedCollectionHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAssignedCollectionHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignedCollectionHead.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAssignedCollectionHead.Location = new System.Drawing.Point(669, 308);
            this.dgvAssignedCollectionHead.MultiSelect = false;
            this.dgvAssignedCollectionHead.Name = "dgvAssignedCollectionHead";
            this.dgvAssignedCollectionHead.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvAssignedCollectionHead.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAssignedCollectionHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedCollectionHead.Size = new System.Drawing.Size(822, 557);
            this.dgvAssignedCollectionHead.TabIndex = 227;
            this.dgvAssignedCollectionHead.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedCollectionHead_CellClick);
            this.dgvAssignedCollectionHead.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAssignedCollectionHead_CellValidating);
            // 
            // txtSearchCollHead
            // 
            this.txtSearchCollHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCollHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCollHead.Location = new System.Drawing.Point(6, 271);
            this.txtSearchCollHead.Name = "txtSearchCollHead";
            this.txtSearchCollHead.Size = new System.Drawing.Size(310, 24);
            this.txtSearchCollHead.TabIndex = 229;
            this.txtSearchCollHead.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchCollHead_KeyUp);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(6, 251);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(197, 15);
            this.smartLabel1.TabIndex = 230;
            this.smartLabel1.Text = "Search Collection Head From Here";
            // 
            // lblTestCount
            // 
            this.lblTestCount.AutoSize = true;
            this.lblTestCount.BackColor = System.Drawing.Color.White;
            this.lblTestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestCount.ForeColor = System.Drawing.Color.Black;
            this.lblTestCount.Location = new System.Drawing.Point(862, 868);
            this.lblTestCount.Name = "lblTestCount";
            this.lblTestCount.Size = new System.Drawing.Size(0, 20);
            this.lblTestCount.TabIndex = 234;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(720, 870);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(136, 15);
            this.smartLabel4.TabIndex = 233;
            this.smartLabel4.Text = "Collection Head Count :";
            // 
            // lblTestAmountSummary
            // 
            this.lblTestAmountSummary.AutoSize = true;
            this.lblTestAmountSummary.BackColor = System.Drawing.Color.White;
            this.lblTestAmountSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestAmountSummary.ForeColor = System.Drawing.Color.Black;
            this.lblTestAmountSummary.Location = new System.Drawing.Point(1234, 868);
            this.lblTestAmountSummary.Name = "lblTestAmountSummary";
            this.lblTestAmountSummary.Size = new System.Drawing.Size(0, 20);
            this.lblTestAmountSummary.TabIndex = 236;
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(1139, 870);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(89, 15);
            this.smartLabel16.TabIndex = 235;
            this.smartLabel16.Text = "Total Amount  :";
            // 
            // txtMoneyReceiptNo
            // 
            this.txtMoneyReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyReceiptNo.Enabled = false;
            this.txtMoneyReceiptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyReceiptNo.ForeColor = System.Drawing.Color.Red;
            this.txtMoneyReceiptNo.Location = new System.Drawing.Point(944, 168);
            this.txtMoneyReceiptNo.MaxLength = 11;
            this.txtMoneyReceiptNo.Name = "txtMoneyReceiptNo";
            this.txtMoneyReceiptNo.Size = new System.Drawing.Size(157, 29);
            this.txtMoneyReceiptNo.TabIndex = 11;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(942, 149);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(126, 15);
            this.smartLabel10.TabIndex = 238;
            this.smartLabel10.Text = "Emergency Token No.";
            // 
            // chkAdmAdv
            // 
            this.chkAdmAdv.AutoSize = true;
            this.chkAdmAdv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAdmAdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAdmAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmAdv.ForeColor = System.Drawing.Color.Black;
            this.chkAdmAdv.Location = new System.Drawing.Point(322, 273);
            this.chkAdmAdv.Name = "chkAdmAdv";
            this.chkAdmAdv.Size = new System.Drawing.Size(183, 22);
            this.chkAdmAdv.TabIndex = 251;
            this.chkAdmAdv.Text = "Is Admission Required ?";
            this.chkAdmAdv.UseVisualStyleBackColor = true;
            // 
            // cboAdmDeptGrp
            // 
            this.cboAdmDeptGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdmDeptGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdmDeptGrp.ForeColor = System.Drawing.Color.Blue;
            this.cboAdmDeptGrp.FormattingEnabled = true;
            this.cboAdmDeptGrp.Location = new System.Drawing.Point(508, 269);
            this.cboAdmDeptGrp.Name = "cboAdmDeptGrp";
            this.cboAdmDeptGrp.Size = new System.Drawing.Size(114, 26);
            this.cboAdmDeptGrp.TabIndex = 268;
            this.cboAdmDeptGrp.SelectedIndexChanged += new System.EventHandler(this.cboAdmDeptGrp_SelectedIndexChanged);
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.Location = new System.Drawing.Point(511, 249);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(41, 13);
            this.smartLabel18.TabIndex = 271;
            this.smartLabel18.Text = "Group";
            // 
            // smartLabel20
            // 
            this.smartLabel20.AutoSize = true;
            this.smartLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel20.Location = new System.Drawing.Point(625, 249);
            this.smartLabel20.Name = "smartLabel20";
            this.smartLabel20.Size = new System.Drawing.Size(72, 13);
            this.smartLabel20.TabIndex = 269;
            this.smartLabel20.Text = "Department";
            // 
            // cboAdmDept
            // 
            this.cboAdmDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdmDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdmDept.ForeColor = System.Drawing.Color.Blue;
            this.cboAdmDept.FormattingEnabled = true;
            this.cboAdmDept.Location = new System.Drawing.Point(628, 269);
            this.cboAdmDept.Name = "cboAdmDept";
            this.cboAdmDept.Size = new System.Drawing.Size(150, 26);
            this.cboAdmDept.TabIndex = 266;
            this.cboAdmDept.SelectedIndexChanged += new System.EventHandler(this.cboAdmDept_SelectedIndexChanged);
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(783, 249);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(30, 13);
            this.smartLabel13.TabIndex = 273;
            this.smartLabel13.Text = "Unit";
            // 
            // cboAdmUnit
            // 
            this.cboAdmUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdmUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdmUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboAdmUnit.FormattingEnabled = true;
            this.cboAdmUnit.Location = new System.Drawing.Point(785, 269);
            this.cboAdmUnit.Name = "cboAdmUnit";
            this.cboAdmUnit.Size = new System.Drawing.Size(154, 26);
            this.cboAdmUnit.TabIndex = 272;
            this.cboAdmUnit.SelectedIndexChanged += new System.EventHandler(this.cboAdmUnit_SelectedIndexChanged);
            // 
            // smartLabel23
            // 
            this.smartLabel23.AutoSize = true;
            this.smartLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel23.Location = new System.Drawing.Point(943, 249);
            this.smartLabel23.Name = "smartLabel23";
            this.smartLabel23.Size = new System.Drawing.Size(45, 13);
            this.smartLabel23.TabIndex = 275;
            this.smartLabel23.Text = "Doctor";
            // 
            // cboadmDoctorID
            // 
            this.cboadmDoctorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboadmDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboadmDoctorID.ForeColor = System.Drawing.Color.Blue;
            this.cboadmDoctorID.FormattingEnabled = true;
            this.cboadmDoctorID.Location = new System.Drawing.Point(944, 269);
            this.cboadmDoctorID.Name = "cboadmDoctorID";
            this.cboadmDoctorID.Size = new System.Drawing.Size(535, 26);
            this.cboadmDoctorID.TabIndex = 274;
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTest.Enabled = false;
            this.btnAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.ForeColor = System.Drawing.Color.White;
            this.btnAddTest.Location = new System.Drawing.Point(508, 168);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(114, 30);
            this.btnAddTest.TabIndex = 276;
            this.btnAddTest.Text = "Add Test";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Enabled = false;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(628, 168);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 30);
            this.btnRefresh.TabIndex = 277;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmEmergencyCollectionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1492, 876);
            this.Controls.Add(this.smartLabel19);
            this.Controls.Add(this.cboReffOrg);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblReffOrg);
            this.Controls.Add(this.cboReffDoc);
            this.Controls.Add(this.btnAddReffOrg);
            this.Controls.Add(this.btnRefreshOrg);
            this.Controls.Add(this.btnAddReffDoc);
            this.Controls.Add(this.btnRefreshDoc);
            this.isEnterTabAllow = true;
            this.Name = "frmEmergencyCollectionEntry";
            this.Load += new System.EventHandler(this.frmEmergencyBilling_Load);
            this.Controls.SetChildIndex(this.btnRefreshDoc, 0);
            this.Controls.SetChildIndex(this.btnAddReffDoc, 0);
            this.Controls.SetChildIndex(this.btnRefreshOrg, 0);
            this.Controls.SetChildIndex(this.btnAddReffOrg, 0);
            this.Controls.SetChildIndex(this.cboReffDoc, 0);
            this.Controls.SetChildIndex(this.lblReffOrg, 0);
            this.Controls.SetChildIndex(this.lblDoctor, 0);
            this.Controls.SetChildIndex(this.cboReffOrg, 0);
            this.Controls.SetChildIndex(this.smartLabel19, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollectionHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedCollectionHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel lblTicketType;
        private AtiqsControlLibrary.SmartComboBox cboTicketType;
        private System.Windows.Forms.TextBox txtHCNNo;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel19;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSex;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPresentAddress;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeHours;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeDays;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeMonths;
        private AtiqsControlLibrary.SmartLabel lblAge;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeYears;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private System.Windows.Forms.TextBox txtMobileNo;
        private AtiqsControlLibrary.SmartLabel lblMobileNo;
        private System.Windows.Forms.Button btnRefreshDoc;
        private System.Windows.Forms.Button btnAddReffDoc;
        private System.Windows.Forms.Button btnRefreshOrg;
        private System.Windows.Forms.Button btnAddReffOrg;
        private AtiqsControlLibrary.SmartComboBox cboReffDoc;
        private AtiqsControlLibrary.SmartLabel lblReffOrg;
        private AtiqsControlLibrary.SmartComboBox cboReffOrg;
        private AtiqsControlLibrary.SmartLabel lblDoctor;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartDataGridView dgvCollectionHead;
        private AtiqsControlLibrary.SmartDataGridView dgvAssignedCollectionHead;
        private AtiqsControlLibrary.SmartTextBox txtSearchCollHead;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Label lblTestCount;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.Label lblTestAmountSummary;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private System.Windows.Forms.TextBox txtMoneyReceiptNo;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartCheckBox chkAdmAdv;
        private AtiqsControlLibrary.SmartComboBox cboAdmDeptGrp;
        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartLabel smartLabel20;
        private AtiqsControlLibrary.SmartComboBox cboAdmDept;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartComboBox cboAdmUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel23;
        private AtiqsControlLibrary.SmartComboBox cboadmDoctorID;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Button btnRefresh;
    }
}
