namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmSpecimenCancellation
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
            this.lvMRTests = new AtiqsControlLibrary.SmartListViewDetails();
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
            this.txtAgeHours = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtAgeDays = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtAgeMonths = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtAgeYears = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSpcCollId = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtMrNo = new System.Windows.Forms.TextBox();
            this.txtAge = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.tvNursStnMoneyReceipt = new AtiqsControlLibrary.SmartTreeView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDepartment = new AtiqsControlLibrary.SmartTextBox();
            this.txtReportGroup = new AtiqsControlLibrary.SmartTextBox();
            this.tvMoneyReceipt = new AtiqsControlLibrary.SmartTab();
            this.tabOPD = new System.Windows.Forms.TabPage();
            this.lstOPD = new AtiqsControlLibrary.SmartListViewDetails();
            this.tabIPD = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSpecimenColl = new System.Windows.Forms.DataGridView();
            this.tbEmrg = new System.Windows.Forms.TabPage();
            this.tbPageEmergency = new AtiqsControlLibrary.SmartTreeView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tvMoneyReceipt.SuspendLayout();
            this.tabOPD.SuspendLayout();
            this.tabIPD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecimenColl)).BeginInit();
            this.tbEmrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(912, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(322, 6);
            this.frmLabel.Size = new System.Drawing.Size(388, 33);
            this.frmLabel.Text = "Laboratory Sample Cancellation";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvSpecimenColl);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.tvMoneyReceipt);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(1037, 583);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtReportGroup);
            this.pnlTop.Controls.Add(this.txtDepartment);
            this.pnlTop.Controls.Add(this.smartLabel6);
            this.pnlTop.Controls.Add(this.txtAgeHours);
            this.pnlTop.Controls.Add(this.smartLabel7);
            this.pnlTop.Controls.Add(this.txtSpecimenNo);
            this.pnlTop.Controls.Add(this.txtAgeDays);
            this.pnlTop.Controls.Add(this.txtRptPriority);
            this.pnlTop.Controls.Add(this.txtAgeYears);
            this.pnlTop.Controls.Add(this.txtAgeMonths);
            this.pnlTop.Size = new System.Drawing.Size(1037, 51);
            this.pnlTop.Controls.SetChildIndex(this.txtAgeMonths, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAgeYears, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtRptPriority, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAgeDays, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtSpecimenNo, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel7, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAgeHours, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel6, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtDepartment, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtReportGroup, 0);
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
            this.btnSave.Location = new System.Drawing.Point(784, 645);
            this.btnSave.Size = new System.Drawing.Size(128, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(309, 644);
            this.btnDelete.Size = new System.Drawing.Size(22, 42);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(672, 645);
            this.btnNew.Size = new System.Drawing.Size(108, 42);
            this.btnNew.TabIndex = 3;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(916, 645);
            this.btnClose.Size = new System.Drawing.Size(108, 42);
            this.btnClose.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(337, 644);
            this.btnPrint.Size = new System.Drawing.Size(23, 42);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 691);
            this.groupBox1.Size = new System.Drawing.Size(1037, 23);
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
            this.lvMRTests.Location = new System.Drawing.Point(278, 665);
            this.lvMRTests.Name = "lvMRTests";
            this.lvMRTests.Size = new System.Drawing.Size(14, 12);
            this.lvMRTests.TabIndex = 0;
            this.lvMRTests.TabStop = false;
            this.lvMRTests.UseCompatibleStateImageBehavior = false;
            this.lvMRTests.View = System.Windows.Forms.View.Details;
            this.lvMRTests.Visible = false;
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.BackColor = System.Drawing.Color.Transparent;
            this.lblMr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMr.Location = new System.Drawing.Point(8, 9);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(90, 15);
            this.lblMr.TabIndex = 7;
            this.lblMr.Text = "Money Receipt ";
            // 
            // btnPatientMr
            // 
            this.btnPatientMr.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientMr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientMr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientMr.ForeColor = System.Drawing.Color.White;
            this.btnPatientMr.Location = new System.Drawing.Point(8, 103);
            this.btnPatientMr.Name = "btnPatientMr";
            this.btnPatientMr.Size = new System.Drawing.Size(122, 34);
            this.btnPatientMr.TabIndex = 1;
            this.btnPatientMr.TabStop = false;
            this.btnPatientMr.Text = "Find";
            this.btnPatientMr.UseVisualStyleBackColor = false;
            this.btnPatientMr.Click += new System.EventHandler(this.btnPatientMr_Click);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(460, 7);
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
            this.txtPatientName.Location = new System.Drawing.Point(462, 30);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(329, 28);
            this.txtPatientName.TabIndex = 77;
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
            this.txtRemarks.Location = new System.Drawing.Point(462, 137);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(329, 51);
            this.txtRemarks.TabIndex = 1;
            // 
            // txtRptPriority
            // 
            this.txtRptPriority.BackColor = System.Drawing.Color.White;
            this.txtRptPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRptPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtRptPriority.Location = new System.Drawing.Point(807, 9);
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
            this.smartLabel8.Location = new System.Drawing.Point(702, 63);
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
            this.txtSex.Location = new System.Drawing.Point(700, 83);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(91, 24);
            this.txtSex.TabIndex = 107;
            this.txtSex.TabStop = false;
            // 
            // txtAgeHours
            // 
            this.txtAgeHours.BackColor = System.Drawing.Color.Linen;
            this.txtAgeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeHours.Location = new System.Drawing.Point(839, 9);
            this.txtAgeHours.Name = "txtAgeHours";
            this.txtAgeHours.ReadOnly = true;
            this.txtAgeHours.Size = new System.Drawing.Size(10, 24);
            this.txtAgeHours.TabIndex = 105;
            this.txtAgeHours.TabStop = false;
            this.txtAgeHours.Visible = false;
            // 
            // txtAgeDays
            // 
            this.txtAgeDays.BackColor = System.Drawing.Color.Linen;
            this.txtAgeDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeDays.Location = new System.Drawing.Point(823, 9);
            this.txtAgeDays.Name = "txtAgeDays";
            this.txtAgeDays.ReadOnly = true;
            this.txtAgeDays.Size = new System.Drawing.Size(10, 24);
            this.txtAgeDays.TabIndex = 103;
            this.txtAgeDays.TabStop = false;
            this.txtAgeDays.Visible = false;
            // 
            // txtAgeMonths
            // 
            this.txtAgeMonths.BackColor = System.Drawing.Color.Linen;
            this.txtAgeMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeMonths.Location = new System.Drawing.Point(791, 9);
            this.txtAgeMonths.Name = "txtAgeMonths";
            this.txtAgeMonths.ReadOnly = true;
            this.txtAgeMonths.Size = new System.Drawing.Size(10, 24);
            this.txtAgeMonths.TabIndex = 101;
            this.txtAgeMonths.TabStop = false;
            this.txtAgeMonths.Visible = false;
            // 
            // txtAgeYears
            // 
            this.txtAgeYears.BackColor = System.Drawing.Color.Linen;
            this.txtAgeYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeYears.Location = new System.Drawing.Point(775, 9);
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
            this.smartLabel6.Location = new System.Drawing.Point(207, 17);
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
            this.smartLabel12.Location = new System.Drawing.Point(460, 112);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(61, 15);
            this.smartLabel12.TabIndex = 111;
            this.smartLabel12.Text = "Remarks ";
            // 
            // txtMrNo
            // 
            this.txtMrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrNo.ForeColor = System.Drawing.Color.Red;
            this.txtMrNo.Location = new System.Drawing.Point(8, 31);
            this.txtMrNo.MaxLength = 11;
            this.txtMrNo.Multiline = true;
            this.txtMrNo.Name = "txtMrNo";
            this.txtMrNo.Size = new System.Drawing.Size(320, 41);
            this.txtMrNo.TabIndex = 0;
            this.txtMrNo.TextChanged += new System.EventHandler(this.txtMRNo_TextChanged);
            this.txtMrNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMRNo_KeyUp);
            this.txtMrNo.Leave += new System.EventHandler(this.txtMrNo_Leave);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Linen;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAge.Location = new System.Drawing.Point(462, 83);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(237, 24);
            this.txtAge.TabIndex = 113;
            this.txtAge.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(460, 64);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(29, 13);
            this.smartLabel1.TabIndex = 114;
            this.smartLabel1.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(332, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
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
            this.tvNursStnMoneyReceipt.Location = new System.Drawing.Point(1, 3);
            this.tvNursStnMoneyReceipt.Name = "tvNursStnMoneyReceipt";
            this.tvNursStnMoneyReceipt.Size = new System.Drawing.Size(196, 506);
            this.tvNursStnMoneyReceipt.TabIndex = 195;
            this.tvNursStnMoneyReceipt.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNursStnMoneyReceipt_AfterSelect);
            this.tvNursStnMoneyReceipt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvNursStnMoneyReceipt_MouseDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(0, 546);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(210, 33);
            this.btnRefresh.TabIndex = 4;
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
            this.btnSearch.Location = new System.Drawing.Point(136, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 34);
            this.btnSearch.TabIndex = 196;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(855, 9);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(36, 24);
            this.txtDepartment.TabIndex = 113;
            this.txtDepartment.UseWaitCursor = true;
            this.txtDepartment.Visible = false;
            // 
            // txtReportGroup
            // 
            this.txtReportGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportGroup.Location = new System.Drawing.Point(895, 9);
            this.txtReportGroup.Name = "txtReportGroup";
            this.txtReportGroup.Size = new System.Drawing.Size(20, 24);
            this.txtReportGroup.TabIndex = 114;
            this.txtReportGroup.UseWaitCursor = true;
            this.txtReportGroup.Visible = false;
            // 
            // tvMoneyReceipt
            // 
            this.tvMoneyReceipt.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tvMoneyReceipt.Controls.Add(this.tabOPD);
            this.tvMoneyReceipt.Controls.Add(this.tabIPD);
            this.tvMoneyReceipt.Controls.Add(this.tbEmrg);
            this.tvMoneyReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvMoneyReceipt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMoneyReceipt.Location = new System.Drawing.Point(-1, 1);
            this.tvMoneyReceipt.Name = "tvMoneyReceipt";
            this.tvMoneyReceipt.SelectedIndex = 0;
            this.tvMoneyReceipt.Size = new System.Drawing.Size(211, 544);
            this.tvMoneyReceipt.TabIndex = 197;
            this.tvMoneyReceipt.SelectedIndexChanged += new System.EventHandler(this.tvMoneyReceipt_SelectedIndexChanged);
            // 
            // tabOPD
            // 
            this.tabOPD.Controls.Add(this.lstOPD);
            this.tabOPD.Location = new System.Drawing.Point(4, 31);
            this.tabOPD.Name = "tabOPD";
            this.tabOPD.Padding = new System.Windows.Forms.Padding(3);
            this.tabOPD.Size = new System.Drawing.Size(203, 509);
            this.tabOPD.TabIndex = 0;
            this.tabOPD.Text = "OPD";
            this.tabOPD.UseVisualStyleBackColor = true;
            // 
            // lstOPD
            // 
            this.lstOPD.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstOPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOPD.CheckBoxes = true;
            this.lstOPD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstOPD.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOPD.FullRowSelect = true;
            this.lstOPD.GridLines = true;
            this.lstOPD.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstOPD.Location = new System.Drawing.Point(0, 2);
            this.lstOPD.Name = "lstOPD";
            this.lstOPD.Size = new System.Drawing.Size(197, 507);
            this.lstOPD.TabIndex = 1;
            this.lstOPD.TabStop = false;
            this.lstOPD.UseCompatibleStateImageBehavior = false;
            this.lstOPD.View = System.Windows.Forms.View.Details;
            this.lstOPD.SelectedIndexChanged += new System.EventHandler(this.lstOPD_SelectedIndexChanged);
            // 
            // tabIPD
            // 
            this.tabIPD.Controls.Add(this.tvNursStnMoneyReceipt);
            this.tabIPD.Location = new System.Drawing.Point(4, 31);
            this.tabIPD.Name = "tabIPD";
            this.tabIPD.Padding = new System.Windows.Forms.Padding(3);
            this.tabIPD.Size = new System.Drawing.Size(203, 509);
            this.tabIPD.TabIndex = 1;
            this.tabIPD.Text = "IPD";
            this.tabIPD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.lblMr);
            this.groupBox2.Controls.Add(this.txtMrNo);
            this.groupBox2.Controls.Add(this.smartLabel12);
            this.groupBox2.Controls.Add(this.smartLabel8);
            this.groupBox2.Controls.Add(this.txtSex);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Controls.Add(this.btnPatientMr);
            this.groupBox2.Location = new System.Drawing.Point(212, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 194);
            this.groupBox2.TabIndex = 198;
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
            this.dgvSpecimenColl.Location = new System.Drawing.Point(211, 199);
            this.dgvSpecimenColl.Name = "dgvSpecimenColl";
            this.dgvSpecimenColl.RowHeadersVisible = false;
            this.dgvSpecimenColl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSpecimenColl.Size = new System.Drawing.Size(821, 378);
            this.dgvSpecimenColl.TabIndex = 199;
            this.dgvSpecimenColl.TabStop = false;
            this.dgvSpecimenColl.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSpecimenColl_CellFormatting);
            this.dgvSpecimenColl.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSpecimenColl_CellPainting);
            // 
            // tbEmrg
            // 
            this.tbEmrg.Controls.Add(this.tbPageEmergency);
            this.tbEmrg.Location = new System.Drawing.Point(4, 31);
            this.tbEmrg.Name = "tbEmrg";
            this.tbEmrg.Size = new System.Drawing.Size(203, 509);
            this.tbEmrg.TabIndex = 2;
            this.tbEmrg.Text = "Emrg";
            this.tbEmrg.UseVisualStyleBackColor = true;
            // 
            // tbPageEmergency
            // 
            this.tbPageEmergency.BackColor = System.Drawing.Color.LightYellow;
            this.tbPageEmergency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPageEmergency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPageEmergency.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tbPageEmergency.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPageEmergency.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPageEmergency.LineColor = System.Drawing.Color.Crimson;
            this.tbPageEmergency.Location = new System.Drawing.Point(3, 0);
            this.tbPageEmergency.Name = "tbPageEmergency";
            this.tbPageEmergency.Size = new System.Drawing.Size(197, 506);
            this.tbPageEmergency.TabIndex = 196;
            // 
            // frmSpecimenCancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1037, 714);
            this.Controls.Add(this.lvMRTests);
            this.Controls.Add(this.txtSpcCollId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.txtHCN);
            this.Controls.Add(this.txtReportDeliveryDateTime);
            this.Controls.Add(this.txtLabTech);
            this.isEnterTabAllow = true;
            this.Name = "frmSpecimenCancellation";
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
            this.Controls.SetChildIndex(this.lvMRTests, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tvMoneyReceipt.ResumeLayout(false);
            this.tabOPD.ResumeLayout(false);
            this.tabIPD.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecimenColl)).EndInit();
            this.tbEmrg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvMRTests;
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
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeHours;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeDays;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeMonths;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeYears;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AtiqsControlLibrary.SmartTextBox txtSpcCollId;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private System.Windows.Forms.TextBox txtMrNo;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAge;
        private System.Windows.Forms.Label label5;
        private AtiqsControlLibrary.SmartTreeView tvNursStnMoneyReceipt;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        public AtiqsControlLibrary.SmartTextBox txtDepartment;
        public AtiqsControlLibrary.SmartTextBox txtReportGroup;
        private AtiqsControlLibrary.SmartTab tvMoneyReceipt;
        private System.Windows.Forms.TabPage tabOPD;
        private System.Windows.Forms.TabPage tabIPD;
        private AtiqsControlLibrary.SmartListViewDetails lstOPD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSpecimenColl;
        private System.Windows.Forms.TabPage tbEmrg;
        private AtiqsControlLibrary.SmartTreeView tbPageEmergency;
    }
}
