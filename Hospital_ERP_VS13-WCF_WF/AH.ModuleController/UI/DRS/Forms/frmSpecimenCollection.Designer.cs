namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmSpecimenCollection
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
            this.lblMr = new AtiqsControlLibrary.SmartLabel();
            this.btnPatientMr = new System.Windows.Forms.Button();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtLabTech = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtSpecimenNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtHCN = new AtiqsControlLibrary.SmartTextBox();
            this.txtRegNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtRptPriority = new AtiqsControlLibrary.SmartTextBox();
            this.txtReportDeliveryDateTime = new AtiqsControlLibrary.SmartTextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSpcCollId = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtMRNo = new System.Windows.Forms.TextBox();
            this.txtAge = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lblWait = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tvNursStnMoneyReceipt = new AtiqsControlLibrary.SmartTreeView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSpecimenColl = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecimenColl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(912, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(330, 5);
            this.frmLabel.Size = new System.Drawing.Size(417, 33);
            this.frmLabel.Text = " Label Print and Sample Collection";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvSpecimenColl);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.tvNursStnMoneyReceipt);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(1037, 583);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.smartLabel6);
            this.pnlTop.Controls.Add(this.smartLabel11);
            this.pnlTop.Controls.Add(this.txtAgeHours);
            this.pnlTop.Controls.Add(this.smartLabel7);
            this.pnlTop.Controls.Add(this.smartLabel9);
            this.pnlTop.Controls.Add(this.txtSpecimenNo);
            this.pnlTop.Controls.Add(this.txtAgeDays);
            this.pnlTop.Controls.Add(this.txtRptPriority);
            this.pnlTop.Controls.Add(this.smartLabel10);
            this.pnlTop.Controls.Add(this.txtAgeYears);
            this.pnlTop.Controls.Add(this.txtAgeMonths);
            this.pnlTop.Controls.Add(this.lblAge);
            this.pnlTop.Size = new System.Drawing.Size(1037, 51);
            this.pnlTop.Controls.SetChildIndex(this.lblAge, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAgeMonths, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAgeYears, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel10, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtRptPriority, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAgeDays, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtSpecimenNo, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel9, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel7, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAgeHours, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel11, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel6, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(121, 641);
            this.btnEdit.Size = new System.Drawing.Size(10, 39);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(803, 646);
            this.btnSave.Size = new System.Drawing.Size(108, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(285, 644);
            this.btnDelete.Size = new System.Drawing.Size(34, 44);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(689, 646);
            this.btnNew.Size = new System.Drawing.Size(108, 44);
            this.btnNew.TabIndex = 2;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(917, 645);
            this.btnClose.Size = new System.Drawing.Size(108, 44);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(325, 641);
            this.btnPrint.Size = new System.Drawing.Size(21, 44);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 691);
            this.groupBox1.Size = new System.Drawing.Size(1037, 23);
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.BackColor = System.Drawing.Color.Transparent;
            this.lblMr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMr.Location = new System.Drawing.Point(10, 12);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(108, 15);
            this.lblMr.TabIndex = 7;
            this.lblMr.Text = "Money Receipt  No";
            // 
            // btnPatientMr
            // 
            this.btnPatientMr.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientMr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientMr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientMr.ForeColor = System.Drawing.Color.White;
            this.btnPatientMr.Location = new System.Drawing.Point(10, 77);
            this.btnPatientMr.Name = "btnPatientMr";
            this.btnPatientMr.Size = new System.Drawing.Size(181, 34);
            this.btnPatientMr.TabIndex = 111;
            this.btnPatientMr.Text = "Find";
            this.btnPatientMr.UseVisualStyleBackColor = false;
            this.btnPatientMr.Click += new System.EventHandler(this.btnPatientMr_Click);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(487, 10);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(80, 15);
            this.smartLabel3.TabIndex = 78;
            this.smartLabel3.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(484, 32);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(347, 26);
            this.txtPatientName.TabIndex = 7777;
            this.txtPatientName.TabStop = false;
            // 
            // txtLabTech
            // 
            this.txtLabTech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLabTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabTech.Location = new System.Drawing.Point(0, 644);
            this.txtLabTech.Name = "txtLabTech";
            this.txtLabTech.Size = new System.Drawing.Size(13, 24);
            this.txtLabTech.TabIndex = 4;
            this.txtLabTech.Text = "1";
            this.txtLabTech.Visible = false;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(119, 12);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(45, 15);
            this.smartLabel7.TabIndex = 90;
            this.smartLabel7.Text = "Lab No";
            this.smartLabel7.Visible = false;
            // 
            // txtSpecimenNo
            // 
            this.txtSpecimenNo.BackColor = System.Drawing.Color.Linen;
            this.txtSpecimenNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecimenNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecimenNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSpecimenNo.Location = new System.Drawing.Point(103, 9);
            this.txtSpecimenNo.Name = "txtSpecimenNo";
            this.txtSpecimenNo.ReadOnly = true;
            this.txtSpecimenNo.Size = new System.Drawing.Size(10, 24);
            this.txtSpecimenNo.TabIndex = 89;
            this.txtSpecimenNo.TabStop = false;
            this.txtSpecimenNo.Visible = false;
            // 
            // txtHCN
            // 
            this.txtHCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCN.Location = new System.Drawing.Point(233, 665);
            this.txtHCN.Name = "txtHCN";
            this.txtHCN.Size = new System.Drawing.Size(39, 24);
            this.txtHCN.TabIndex = 94;
            this.txtHCN.Visible = false;
            // 
            // txtRegNo
            // 
            this.txtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo.Location = new System.Drawing.Point(188, 636);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(32, 24);
            this.txtRegNo.TabIndex = 95;
            this.txtRegNo.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(484, 131);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(347, 63);
            this.txtRemarks.TabIndex = 1;
            this.txtRemarks.Text = "N/A";
            // 
            // txtRptPriority
            // 
            this.txtRptPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRptPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRptPriority.Location = new System.Drawing.Point(688, 9);
            this.txtRptPriority.Name = "txtRptPriority";
            this.txtRptPriority.Size = new System.Drawing.Size(10, 24);
            this.txtRptPriority.TabIndex = 5;
            this.txtRptPriority.Visible = false;
            // 
            // txtReportDeliveryDateTime
            // 
            this.txtReportDeliveryDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportDeliveryDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportDeliveryDateTime.Location = new System.Drawing.Point(231, 636);
            this.txtReportDeliveryDateTime.Name = "txtReportDeliveryDateTime";
            this.txtReportDeliveryDateTime.Size = new System.Drawing.Size(45, 24);
            this.txtReportDeliveryDateTime.TabIndex = 98;
            this.txtReportDeliveryDateTime.Visible = false;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(724, 63);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(47, 15);
            this.smartLabel8.TabIndex = 108;
            this.smartLabel8.Text = "Gender";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.Linen;
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSex.Location = new System.Drawing.Point(723, 83);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(108, 24);
            this.txtSex.TabIndex = 107;
            this.txtSex.TabStop = false;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(814, 0);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(46, 15);
            this.smartLabel11.TabIndex = 106;
            this.smartLabel11.Text = "Age(H)";
            this.smartLabel11.Visible = false;
            // 
            // txtAgeHours
            // 
            this.txtAgeHours.BackColor = System.Drawing.Color.Linen;
            this.txtAgeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeHours.Location = new System.Drawing.Point(814, 19);
            this.txtAgeHours.Name = "txtAgeHours";
            this.txtAgeHours.ReadOnly = true;
            this.txtAgeHours.Size = new System.Drawing.Size(10, 24);
            this.txtAgeHours.TabIndex = 105;
            this.txtAgeHours.TabStop = false;
            this.txtAgeHours.Visible = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(740, 0);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(46, 15);
            this.smartLabel9.TabIndex = 104;
            this.smartLabel9.Text = "Age(D)";
            this.smartLabel9.Visible = false;
            // 
            // txtAgeDays
            // 
            this.txtAgeDays.BackColor = System.Drawing.Color.Linen;
            this.txtAgeDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeDays.Location = new System.Drawing.Point(743, 19);
            this.txtAgeDays.Name = "txtAgeDays";
            this.txtAgeDays.ReadOnly = true;
            this.txtAgeDays.Size = new System.Drawing.Size(10, 24);
            this.txtAgeDays.TabIndex = 103;
            this.txtAgeDays.TabStop = false;
            this.txtAgeDays.Visible = false;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(674, 0);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(48, 15);
            this.smartLabel10.TabIndex = 102;
            this.smartLabel10.Text = "Age(M)";
            this.smartLabel10.Visible = false;
            // 
            // txtAgeMonths
            // 
            this.txtAgeMonths.BackColor = System.Drawing.Color.Linen;
            this.txtAgeMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeMonths.Location = new System.Drawing.Point(672, 19);
            this.txtAgeMonths.Name = "txtAgeMonths";
            this.txtAgeMonths.ReadOnly = true;
            this.txtAgeMonths.Size = new System.Drawing.Size(10, 24);
            this.txtAgeMonths.TabIndex = 101;
            this.txtAgeMonths.TabStop = false;
            this.txtAgeMonths.Visible = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(621, 3);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 15);
            this.lblAge.TabIndex = 100;
            this.lblAge.Text = "Age(Y)";
            this.lblAge.Visible = false;
            // 
            // txtAgeYears
            // 
            this.txtAgeYears.BackColor = System.Drawing.Color.Linen;
            this.txtAgeYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeYears.Location = new System.Drawing.Point(624, 21);
            this.txtAgeYears.Name = "txtAgeYears";
            this.txtAgeYears.ReadOnly = true;
            this.txtAgeYears.Size = new System.Drawing.Size(10, 24);
            this.txtAgeYears.TabIndex = 99;
            this.txtAgeYears.TabStop = false;
            this.txtAgeYears.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 34);
            this.button1.TabIndex = 91;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(70, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 34);
            this.button2.TabIndex = 92;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(137, 646);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 34);
            this.button3.TabIndex = 93;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // txtSpcCollId
            // 
            this.txtSpcCollId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpcCollId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpcCollId.Location = new System.Drawing.Point(188, 666);
            this.txtSpcCollId.Name = "txtSpcCollId";
            this.txtSpcCollId.Size = new System.Drawing.Size(39, 24);
            this.txtSpcCollId.TabIndex = 109;
            this.txtSpcCollId.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(837, 15);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(94, 15);
            this.smartLabel6.TabIndex = 110;
            this.smartLabel6.Text = "Report Priority ";
            this.smartLabel6.Visible = false;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(487, 108);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(61, 15);
            this.smartLabel12.TabIndex = 111;
            this.smartLabel12.Text = "Remarks ";
            // 
            // txtMRNo
            // 
            this.txtMRNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNo.ForeColor = System.Drawing.Color.Red;
            this.txtMRNo.Location = new System.Drawing.Point(10, 33);
            this.txtMRNo.MaxLength = 11;
            this.txtMRNo.Name = "txtMRNo";
            this.txtMRNo.Size = new System.Drawing.Size(320, 31);
            this.txtMRNo.TabIndex = 0;
            this.txtMRNo.TextChanged += new System.EventHandler(this.txtMRNo_TextChanged);
            this.txtMRNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMRNo_KeyUp);
            this.txtMRNo.Leave += new System.EventHandler(this.txtMRNo_Leave);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Linen;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAge.Location = new System.Drawing.Point(484, 83);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(238, 24);
            this.txtAge.TabIndex = 113;
            this.txtAge.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(487, 63);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(29, 13);
            this.smartLabel1.TabIndex = 114;
            this.smartLabel1.Text = "Age";
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.Color.Red;
            this.lblWait.Location = new System.Drawing.Point(20, 155);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(128, 16);
            this.lblWait.TabIndex = 115;
            this.lblWait.Text = "Waiting Message";
            this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(335, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 194;
            this.label5.Text = "*";
            // 
            // tvNursStnMoneyReceipt
            // 
            this.tvNursStnMoneyReceipt.BackColor = System.Drawing.Color.LightYellow;
            this.tvNursStnMoneyReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvNursStnMoneyReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvNursStnMoneyReceipt.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvNursStnMoneyReceipt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNursStnMoneyReceipt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tvNursStnMoneyReceipt.LineColor = System.Drawing.Color.Crimson;
            this.tvNursStnMoneyReceipt.Location = new System.Drawing.Point(1, -1);
            this.tvNursStnMoneyReceipt.Name = "tvNursStnMoneyReceipt";
            this.tvNursStnMoneyReceipt.Size = new System.Drawing.Size(166, 548);
            this.tvNursStnMoneyReceipt.TabIndex = 195;
            this.tvNursStnMoneyReceipt.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNursStnMoneyReceipt_AfterSelect);
            this.tvNursStnMoneyReceipt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvNursStnMoneyReceipt_MouseDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(0, 548);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 33);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(207, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 34);
            this.btnSearch.TabIndex = 196;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblWait);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.txtMRNo);
            this.groupBox2.Controls.Add(this.smartLabel12);
            this.groupBox2.Controls.Add(this.smartLabel8);
            this.groupBox2.Controls.Add(this.txtSex);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Controls.Add(this.btnPatientMr);
            this.groupBox2.Controls.Add(this.lblMr);
            this.groupBox2.Location = new System.Drawing.Point(170, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 201);
            this.groupBox2.TabIndex = 197;
            this.groupBox2.TabStop = false;
            // 
            // dgvSpecimenColl
            // 
            this.dgvSpecimenColl.AllowUserToAddRows = false;
            this.dgvSpecimenColl.AllowUserToDeleteRows = false;
            this.dgvSpecimenColl.AllowUserToResizeColumns = false;
            this.dgvSpecimenColl.AllowUserToResizeRows = false;
            this.dgvSpecimenColl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSpecimenColl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecimenColl.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvSpecimenColl.Location = new System.Drawing.Point(168, 201);
            this.dgvSpecimenColl.Name = "dgvSpecimenColl";
            this.dgvSpecimenColl.RowHeadersVisible = false;
            this.dgvSpecimenColl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSpecimenColl.Size = new System.Drawing.Size(866, 379);
            this.dgvSpecimenColl.TabIndex = 12222;
            this.dgvSpecimenColl.TabStop = false;
            this.dgvSpecimenColl.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSpecimenColl_CellFormatting);
            this.dgvSpecimenColl.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSpecimenColl_CellPainting);
            // 
            // frmSpecimenCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1037, 714);
            this.Controls.Add(this.txtSpcCollId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.txtHCN);
            this.Controls.Add(this.txtReportDeliveryDateTime);
            this.Controls.Add(this.txtLabTech);
            this.isEnterTabAllow = true;
            this.Name = "frmSpecimenCollection";
            this.Load += new System.EventHandler(this.frmSpecimenCollection_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtLabTech, 0);
            this.Controls.SetChildIndex(this.txtReportDeliveryDateTime, 0);
            this.Controls.SetChildIndex(this.txtHCN, 0);
            this.Controls.SetChildIndex(this.txtRegNo, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.txtSpcCollId, 0);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecimenColl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientMr;
        private AtiqsControlLibrary.SmartLabel lblMr;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSpecimenNo;
        private AtiqsControlLibrary.SmartTextBox txtLabTech;
        private AtiqsControlLibrary.SmartTextBox txtRegNo;
        private AtiqsControlLibrary.SmartTextBox txtHCN;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtReportDeliveryDateTime;
        private AtiqsControlLibrary.SmartTextBox txtRptPriority;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AtiqsControlLibrary.SmartTextBox txtSpcCollId;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private System.Windows.Forms.TextBox txtMRNo;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAge;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Label label5;
        private AtiqsControlLibrary.SmartTreeView tvNursStnMoneyReceipt;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSpecimenColl;
    }
}
