namespace AH.ModuleController.UI.EPMS.Forms
{
    partial class frmEmergencyBilling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTicketType = new AtiqsControlLibrary.SmartLabel();
            this.cboTicketType = new AtiqsControlLibrary.SmartComboBox();
            this.txtHCNNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtMoneyReceiptNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
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
            this.btnRefreshCollHead = new System.Windows.Forms.Button();
            this.btnAddCollHead = new System.Windows.Forms.Button();
            this.lblTestCount = new System.Windows.Forms.Label();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lblTestAmountSummary = new System.Windows.Forms.Label();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.txtTicketNo = new System.Windows.Forms.TextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollectionHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedCollectionHead)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(577, 9);
            this.frmLabel.Size = new System.Drawing.Size(224, 33);
            this.frmLabel.Text = "Emergency Billing";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtTicketNo);
            this.pnlMain.Controls.Add(this.lblTestAmountSummary);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.lblTestCount);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.btnRefreshCollHead);
            this.pnlMain.Controls.Add(this.btnAddCollHead);
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
            this.pnlMain.Controls.Add(this.btnRefreshDoc);
            this.pnlMain.Controls.Add(this.btnAddReffDoc);
            this.pnlMain.Controls.Add(this.btnRefreshOrg);
            this.pnlMain.Controls.Add(this.btnAddReffOrg);
            this.pnlMain.Controls.Add(this.cboReffDoc);
            this.pnlMain.Controls.Add(this.lblReffOrg);
            this.pnlMain.Controls.Add(this.cboReffOrg);
            this.pnlMain.Controls.Add(this.lblDoctor);
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
            this.pnlMain.Size = new System.Drawing.Size(1419, 892);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1419, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(5, 811);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1080, 812);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(118, 811);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(967, 812);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1305, 812);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1194, 812);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 851);
            this.groupBox1.Size = new System.Drawing.Size(1419, 25);
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
            this.cboTicketType.Location = new System.Drawing.Point(6, 170);
            this.cboTicketType.Name = "cboTicketType";
            this.cboTicketType.Size = new System.Drawing.Size(180, 26);
            this.cboTicketType.TabIndex = 37;
            // 
            // txtHCNNo
            // 
            this.txtHCNNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCNNo.Enabled = false;
            this.txtHCNNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCNNo.ForeColor = System.Drawing.Color.Red;
            this.txtHCNNo.Location = new System.Drawing.Point(497, 168);
            this.txtHCNNo.MaxLength = 11;
            this.txtHCNNo.Name = "txtHCNNo";
            this.txtHCNNo.Size = new System.Drawing.Size(240, 29);
            this.txtHCNNo.TabIndex = 80;
            this.txtHCNNo.TextChanged += new System.EventHandler(this.txtHCNNo_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(424, 168);
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
            this.smartLabel2.Location = new System.Drawing.Point(494, 149);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(34, 15);
            this.smartLabel2.TabIndex = 82;
            this.smartLabel2.Text = "HCN";
            // 
            // txtMoneyReceiptNo
            // 
            this.txtMoneyReceiptNo.BackColor = System.Drawing.Color.Linen;
            this.txtMoneyReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyReceiptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyReceiptNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMoneyReceiptNo.Location = new System.Drawing.Point(248, 826);
            this.txtMoneyReceiptNo.Name = "txtMoneyReceiptNo";
            this.txtMoneyReceiptNo.ReadOnly = true;
            this.txtMoneyReceiptNo.Size = new System.Drawing.Size(191, 24);
            this.txtMoneyReceiptNo.TabIndex = 106;
            this.txtMoneyReceiptNo.TabStop = false;
            this.txtMoneyReceiptNo.Visible = false;
            // 
            // smartLabel19
            // 
            this.smartLabel19.AutoSize = true;
            this.smartLabel19.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel19.Location = new System.Drawing.Point(249, 808);
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
            this.smartLabel6.Location = new System.Drawing.Point(666, 201);
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
            this.txtSex.Location = new System.Drawing.Point(669, 221);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(68, 24);
            this.txtSex.TabIndex = 103;
            this.txtSex.TabStop = false;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(973, 201);
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
            this.txtPresentAddress.Location = new System.Drawing.Point(973, 221);
            this.txtPresentAddress.Multiline = true;
            this.txtPresentAddress.Name = "txtPresentAddress";
            this.txtPresentAddress.ReadOnly = true;
            this.txtPresentAddress.Size = new System.Drawing.Size(435, 24);
            this.txtPresentAddress.TabIndex = 101;
            this.txtPresentAddress.TabStop = false;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(914, 201);
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
            this.txtAgeHours.Location = new System.Drawing.Point(917, 221);
            this.txtAgeHours.Name = "txtAgeHours";
            this.txtAgeHours.ReadOnly = true;
            this.txtAgeHours.Size = new System.Drawing.Size(50, 24);
            this.txtAgeHours.TabIndex = 99;
            this.txtAgeHours.TabStop = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(868, 201);
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
            this.txtAgeDays.Location = new System.Drawing.Point(868, 221);
            this.txtAgeDays.Name = "txtAgeDays";
            this.txtAgeDays.ReadOnly = true;
            this.txtAgeDays.Size = new System.Drawing.Size(46, 24);
            this.txtAgeDays.TabIndex = 97;
            this.txtAgeDays.TabStop = false;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(817, 201);
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
            this.txtAgeMonths.Location = new System.Drawing.Point(814, 221);
            this.txtAgeMonths.Name = "txtAgeMonths";
            this.txtAgeMonths.ReadOnly = true;
            this.txtAgeMonths.Size = new System.Drawing.Size(51, 24);
            this.txtAgeMonths.TabIndex = 95;
            this.txtAgeMonths.TabStop = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(740, 201);
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
            this.txtAgeYears.Location = new System.Drawing.Point(743, 221);
            this.txtAgeYears.Name = "txtAgeYears";
            this.txtAgeYears.ReadOnly = true;
            this.txtAgeYears.Size = new System.Drawing.Size(67, 24);
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
            this.txtPatientName.Size = new System.Drawing.Size(657, 24);
            this.txtPatientName.TabIndex = 91;
            this.txtPatientName.TabStop = false;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Enabled = false;
            this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.ForeColor = System.Drawing.Color.Red;
            this.txtMobileNo.Location = new System.Drawing.Point(741, 168);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(226, 29);
            this.txtMobileNo.TabIndex = 121;
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.BackColor = System.Drawing.Color.Transparent;
            this.lblMobileNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMobileNo.Location = new System.Drawing.Point(738, 149);
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
            this.btnRefreshDoc.Location = new System.Drawing.Point(1376, 269);
            this.btnRefreshDoc.Name = "btnRefreshDoc";
            this.btnRefreshDoc.Size = new System.Drawing.Size(33, 26);
            this.btnRefreshDoc.TabIndex = 155;
            this.btnRefreshDoc.TabStop = false;
            this.btnRefreshDoc.Text = "..";
            this.btnRefreshDoc.UseVisualStyleBackColor = false;
            this.btnRefreshDoc.Click += new System.EventHandler(this.btnRefreshDoc_Click);
            // 
            // btnAddReffDoc
            // 
            this.btnAddReffDoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddReffDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReffDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReffDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReffDoc.ForeColor = System.Drawing.Color.White;
            this.btnAddReffDoc.Location = new System.Drawing.Point(1338, 269);
            this.btnAddReffDoc.Name = "btnAddReffDoc";
            this.btnAddReffDoc.Size = new System.Drawing.Size(37, 26);
            this.btnAddReffDoc.TabIndex = 154;
            this.btnAddReffDoc.TabStop = false;
            this.btnAddReffDoc.Text = "+";
            this.btnAddReffDoc.UseVisualStyleBackColor = false;
            this.btnAddReffDoc.Click += new System.EventHandler(this.btnAddReffDoc_Click);
            // 
            // btnRefreshOrg
            // 
            this.btnRefreshOrg.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshOrg.ForeColor = System.Drawing.Color.White;
            this.btnRefreshOrg.Location = new System.Drawing.Point(1054, 269);
            this.btnRefreshOrg.Name = "btnRefreshOrg";
            this.btnRefreshOrg.Size = new System.Drawing.Size(33, 26);
            this.btnRefreshOrg.TabIndex = 153;
            this.btnRefreshOrg.TabStop = false;
            this.btnRefreshOrg.Text = "..";
            this.btnRefreshOrg.UseVisualStyleBackColor = false;
            this.btnRefreshOrg.Click += new System.EventHandler(this.btnRefreshOrg_Click);
            // 
            // btnAddReffOrg
            // 
            this.btnAddReffOrg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddReffOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReffOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReffOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReffOrg.ForeColor = System.Drawing.Color.White;
            this.btnAddReffOrg.Location = new System.Drawing.Point(1016, 269);
            this.btnAddReffOrg.Name = "btnAddReffOrg";
            this.btnAddReffOrg.Size = new System.Drawing.Size(37, 26);
            this.btnAddReffOrg.TabIndex = 152;
            this.btnAddReffOrg.TabStop = false;
            this.btnAddReffOrg.Text = "+";
            this.btnAddReffOrg.UseVisualStyleBackColor = false;
            this.btnAddReffOrg.Click += new System.EventHandler(this.btnAddReffOrg_Click);
            // 
            // cboReffDoc
            // 
            this.cboReffDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReffDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReffDoc.ForeColor = System.Drawing.Color.Blue;
            this.cboReffDoc.FormattingEnabled = true;
            this.cboReffDoc.Location = new System.Drawing.Point(1094, 269);
            this.cboReffDoc.Name = "cboReffDoc";
            this.cboReffDoc.Size = new System.Drawing.Size(243, 26);
            this.cboReffDoc.TabIndex = 151;
            // 
            // lblReffOrg
            // 
            this.lblReffOrg.AutoSize = true;
            this.lblReffOrg.BackColor = System.Drawing.Color.Transparent;
            this.lblReffOrg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReffOrg.Location = new System.Drawing.Point(668, 249);
            this.lblReffOrg.Name = "lblReffOrg";
            this.lblReffOrg.Size = new System.Drawing.Size(132, 15);
            this.lblReffOrg.TabIndex = 150;
            this.lblReffOrg.Text = "Referred Organization";
            // 
            // cboReffOrg
            // 
            this.cboReffOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReffOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReffOrg.ForeColor = System.Drawing.Color.Blue;
            this.cboReffOrg.FormattingEnabled = true;
            this.cboReffOrg.Location = new System.Drawing.Point(669, 269);
            this.cboReffOrg.Name = "cboReffOrg";
            this.cboReffOrg.Size = new System.Drawing.Size(341, 26);
            this.cboReffOrg.TabIndex = 149;
            this.cboReffOrg.SelectedIndexChanged += new System.EventHandler(this.cboReffOrg_SelectedIndexChanged);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.Location = new System.Drawing.Point(1091, 249);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(96, 15);
            this.lblDoctor.TabIndex = 143;
            this.lblDoctor.Text = "Referred Doctor";
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(1094, 170);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(99, 26);
            this.cboDepartmentGroup.TabIndex = 219;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(1091, 149);
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
            this.cboDepartmentType.Location = new System.Drawing.Point(973, 170);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(115, 26);
            this.cboDepartmentType.TabIndex = 218;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(970, 149);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(104, 13);
            this.smartLabel21.TabIndex = 223;
            this.smartLabel21.Text = "Department Type";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(1337, 149);
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
            this.cboUnit.Location = new System.Drawing.Point(1340, 170);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(68, 26);
            this.cboUnit.TabIndex = 220;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(1196, 149);
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
            this.cboDepartment.Location = new System.Drawing.Point(1196, 170);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(141, 26);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCollectionHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCollectionHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCollectionHead.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCollectionHead.Location = new System.Drawing.Point(1, 306);
            this.dgvCollectionHead.MultiSelect = false;
            this.dgvCollectionHead.Name = "dgvCollectionHead";
            this.dgvCollectionHead.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            this.dgvCollectionHead.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCollectionHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCollectionHead.Size = new System.Drawing.Size(662, 558);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAssignedCollectionHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAssignedCollectionHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignedCollectionHead.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAssignedCollectionHead.Location = new System.Drawing.Point(669, 306);
            this.dgvAssignedCollectionHead.MultiSelect = false;
            this.dgvAssignedCollectionHead.Name = "dgvAssignedCollectionHead";
            this.dgvAssignedCollectionHead.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.dgvAssignedCollectionHead.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAssignedCollectionHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedCollectionHead.Size = new System.Drawing.Size(745, 558);
            this.dgvAssignedCollectionHead.TabIndex = 227;
            this.dgvAssignedCollectionHead.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedCollectionHead_CellClick);
            this.dgvAssignedCollectionHead.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAssignedCollectionHead_CellValidating);
            // 
            // txtSearchCollHead
            // 
            this.txtSearchCollHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCollHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCollHead.Location = new System.Drawing.Point(6, 269);
            this.txtSearchCollHead.Name = "txtSearchCollHead";
            this.txtSearchCollHead.Size = new System.Drawing.Size(576, 24);
            this.txtSearchCollHead.TabIndex = 229;
            this.txtSearchCollHead.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchCollHead_KeyUp);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(6, 249);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(197, 15);
            this.smartLabel1.TabIndex = 230;
            this.smartLabel1.Text = "Search Collection Head From Here";
            // 
            // btnRefreshCollHead
            // 
            this.btnRefreshCollHead.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshCollHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCollHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCollHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCollHead.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCollHead.Location = new System.Drawing.Point(627, 269);
            this.btnRefreshCollHead.Name = "btnRefreshCollHead";
            this.btnRefreshCollHead.Size = new System.Drawing.Size(33, 26);
            this.btnRefreshCollHead.TabIndex = 232;
            this.btnRefreshCollHead.TabStop = false;
            this.btnRefreshCollHead.Text = "..";
            this.btnRefreshCollHead.UseVisualStyleBackColor = false;
            this.btnRefreshCollHead.Click += new System.EventHandler(this.btnRefreshCollHead_Click);
            // 
            // btnAddCollHead
            // 
            this.btnAddCollHead.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCollHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCollHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCollHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCollHead.ForeColor = System.Drawing.Color.White;
            this.btnAddCollHead.Location = new System.Drawing.Point(589, 269);
            this.btnAddCollHead.Name = "btnAddCollHead";
            this.btnAddCollHead.Size = new System.Drawing.Size(37, 26);
            this.btnAddCollHead.TabIndex = 231;
            this.btnAddCollHead.TabStop = false;
            this.btnAddCollHead.Text = "+";
            this.btnAddCollHead.UseVisualStyleBackColor = false;
            this.btnAddCollHead.Click += new System.EventHandler(this.btnAddCollHead_Click);
            // 
            // lblTestCount
            // 
            this.lblTestCount.AutoSize = true;
            this.lblTestCount.BackColor = System.Drawing.Color.White;
            this.lblTestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestCount.ForeColor = System.Drawing.Color.Black;
            this.lblTestCount.Location = new System.Drawing.Point(845, 868);
            this.lblTestCount.Name = "lblTestCount";
            this.lblTestCount.Size = new System.Drawing.Size(57, 20);
            this.lblTestCount.TabIndex = 234;
            this.lblTestCount.Text = "label1";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(703, 870);
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
            this.lblTestAmountSummary.Location = new System.Drawing.Point(1164, 868);
            this.lblTestAmountSummary.Name = "lblTestAmountSummary";
            this.lblTestAmountSummary.Size = new System.Drawing.Size(112, 20);
            this.lblTestAmountSummary.TabIndex = 236;
            this.lblTestAmountSummary.Text = " label3          ";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(1069, 870);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(89, 15);
            this.smartLabel16.TabIndex = 235;
            this.smartLabel16.Text = "Total Amount  :";
            // 
            // txtTicketNo
            // 
            this.txtTicketNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTicketNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketNo.ForeColor = System.Drawing.Color.Red;
            this.txtTicketNo.Location = new System.Drawing.Point(192, 168);
            this.txtTicketNo.MaxLength = 11;
            this.txtTicketNo.Name = "txtTicketNo";
            this.txtTicketNo.Size = new System.Drawing.Size(226, 29);
            this.txtTicketNo.TabIndex = 0;
            this.txtTicketNo.TextChanged += new System.EventHandler(this.txtTicketNo_TextChanged);
            this.txtTicketNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTicketNo_KeyUp);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(191, 149);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(89, 15);
            this.smartLabel10.TabIndex = 238;
            this.smartLabel10.Text = "Emergency No.";
            // 
            // frmEmergencyBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1419, 876);
            this.Controls.Add(this.txtMoneyReceiptNo);
            this.Controls.Add(this.smartLabel19);
            this.isEnterTabAllow = true;
            this.Name = "frmEmergencyBilling";
            this.Load += new System.EventHandler(this.frmEmergencyBilling_Load);
            this.Controls.SetChildIndex(this.smartLabel19, 0);
            this.Controls.SetChildIndex(this.txtMoneyReceiptNo, 0);
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
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMoneyReceiptNo;
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
        private System.Windows.Forms.Button btnRefreshCollHead;
        private System.Windows.Forms.Button btnAddCollHead;
        private System.Windows.Forms.Label lblTestCount;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.Label lblTestAmountSummary;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private System.Windows.Forms.TextBox txtTicketNo;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
    }
}
