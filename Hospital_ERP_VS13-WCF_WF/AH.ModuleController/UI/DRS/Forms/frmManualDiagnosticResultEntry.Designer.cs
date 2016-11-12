namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmManualDiagnosticResultEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.lblText = new AtiqsControlLibrary.SmartLabel();
            this.dgvResultHeads = new AtiqsControlLibrary.SmartDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdDepartment = new System.Windows.Forms.Label();
            this.lblGrop = new System.Windows.Forms.Label();
            this.lblReportGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtSpecimenName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtResultHolder = new AtiqsControlLibrary.SmartTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtHCN = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtSpcecimenID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtRegID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtMrNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtReportGr = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lvSPCTests = new AtiqsControlLibrary.SmartListViewDetails();
            this.lblRrpGrp = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblReportSection = new System.Windows.Forms.Label();
            this.tbResultHd = new System.Windows.Forms.TabControl();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvResultEntry = new System.Windows.Forms.DataGridView();
            this.tvMoneyReceipt = new AtiqsControlLibrary.SmartTab();
            this.tabOPD = new System.Windows.Forms.TabPage();
            this.lstOPD = new AtiqsControlLibrary.SmartListViewDetails();
            this.tabIPD = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tvNursStnMoneyReceipt = new AtiqsControlLibrary.SmartTreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtGender = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtAge = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtMrID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboMachine = new AtiqsControlLibrary.SmartComboBox();
            this.btnWorkSheet = new System.Windows.Forms.Button();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtMoneyReceipt = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbEmrg = new System.Windows.Forms.TabPage();
            this.tvEmergency = new AtiqsControlLibrary.SmartTreeView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultHeads)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultEntry)).BeginInit();
            this.tvMoneyReceipt.SuspendLayout();
            this.tabOPD.SuspendLayout();
            this.tabIPD.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbEmrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(942, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(623, 6);
            this.frmLabel.Size = new System.Drawing.Size(288, 33);
            this.frmLabel.Text = "Diagnostic Result Entry";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvResultEntry);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.tvMoneyReceipt);
            this.pnlMain.Controls.Add(this.tbResultHd);
            this.pnlMain.Controls.Add(this.txtResultHolder);
            this.pnlMain.Controls.Add(this.lvSPCTests);
            this.pnlMain.Controls.Add(this.dgvResultHeads);
            this.pnlMain.Controls.Add(this.lblDep);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(1514, 675);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtReportGr);
            this.pnlTop.Controls.Add(this.txtMrNo);
            this.pnlTop.Controls.Add(this.smartLabel4);
            this.pnlTop.Controls.Add(this.txtMoneyReceipt);
            this.pnlTop.Controls.Add(this.txtRegID);
            this.pnlTop.Controls.Add(this.txtSpcecimenID);
            this.pnlTop.Controls.Add(this.txtHCN);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.panel5);
            this.pnlTop.Size = new System.Drawing.Size(1514, 51);
            this.pnlTop.Controls.SetChildIndex(this.panel5, 0);
            this.pnlTop.Controls.SetChildIndex(this.label4, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtHCN, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtSpcecimenID, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtRegID, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtMoneyReceipt, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel4, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtMrNo, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtReportGr, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(688, 730);
            this.btnEdit.Size = new System.Drawing.Size(30, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1258, 729);
            this.btnSave.Size = new System.Drawing.Size(118, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(662, 729);
            this.btnDelete.Size = new System.Drawing.Size(20, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1144, 729);
            this.btnNew.Size = new System.Drawing.Size(108, 43);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1382, 729);
            this.btnClose.Size = new System.Drawing.Size(108, 43);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(486, 734);
            this.btnPrint.Size = new System.Drawing.Size(10, 31);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 774);
            this.groupBox1.Size = new System.Drawing.Size(1514, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(257, 4);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(87, 15);
            this.smartLabel3.TabIndex = 76;
            this.smartLabel3.Text = "Patient Name :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(253, 24);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(348, 31);
            this.txtPatientName.TabIndex = 75;
            this.txtPatientName.TabStop = false;
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(6, 120);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(147, 35);
            this.btnPatientSearch.TabIndex = 1;
            this.btnPatientSearch.Text = "Show";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblText.Location = new System.Drawing.Point(9, 3);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(112, 15);
            this.lblText.TabIndex = 74;
            this.lblText.Text = "Money Receipt No :";
            // 
            // dgvResultHeads
            // 
            this.dgvResultHeads.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvResultHeads.AllowUserToAddRows = false;
            this.dgvResultHeads.AllowUserToDeleteRows = false;
            this.dgvResultHeads.AllowUserToOrderColumns = true;
            this.dgvResultHeads.AllowUserToResizeColumns = false;
            this.dgvResultHeads.AllowUserToResizeRows = false;
            this.dgvResultHeads.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultHeads.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvResultHeads.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvResultHeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultHeads.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvResultHeads.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvResultHeads.Location = new System.Drawing.Point(2, 457);
            this.dgvResultHeads.MultiSelect = false;
            this.dgvResultHeads.Name = "dgvResultHeads";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultHeads.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvResultHeads.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvResultHeads.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvResultHeads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultHeads.Size = new System.Drawing.Size(20, 24);
            this.dgvResultHeads.TabIndex = 77;
            this.dgvResultHeads.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Department :";
            // 
            // lbdDepartment
            // 
            this.lbdDepartment.AutoSize = true;
            this.lbdDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdDepartment.ForeColor = System.Drawing.Color.Blue;
            this.lbdDepartment.Location = new System.Drawing.Point(120, 8);
            this.lbdDepartment.Name = "lbdDepartment";
            this.lbdDepartment.Size = new System.Drawing.Size(57, 20);
            this.lbdDepartment.TabIndex = 84;
            this.lbdDepartment.Text = "label3";
            // 
            // lblGrop
            // 
            this.lblGrop.AutoSize = true;
            this.lblGrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrop.Location = new System.Drawing.Point(542, 9);
            this.lblGrop.Name = "lblGrop";
            this.lblGrop.Size = new System.Drawing.Size(106, 20);
            this.lblGrop.TabIndex = 85;
            this.lblGrop.Text = "Report For :";
            // 
            // lblReportGroup
            // 
            this.lblReportGroup.AutoSize = true;
            this.lblReportGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportGroup.ForeColor = System.Drawing.Color.Blue;
            this.lblReportGroup.Location = new System.Drawing.Point(654, 11);
            this.lblReportGroup.Name = "lblReportGroup";
            this.lblReportGroup.Size = new System.Drawing.Size(57, 20);
            this.lblReportGroup.TabIndex = 86;
            this.lblReportGroup.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(-1, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 38);
            this.panel1.TabIndex = 87;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(257, 108);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(60, 15);
            this.smartLabel6.TabIndex = 90;
            this.smartLabel6.Text = "Specimen";
            // 
            // txtSpecimenName
            // 
            this.txtSpecimenName.BackColor = System.Drawing.Color.Linen;
            this.txtSpecimenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecimenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecimenName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSpecimenName.Location = new System.Drawing.Point(253, 125);
            this.txtSpecimenName.Multiline = true;
            this.txtSpecimenName.Name = "txtSpecimenName";
            this.txtSpecimenName.ReadOnly = true;
            this.txtSpecimenName.Size = new System.Drawing.Size(348, 29);
            this.txtSpecimenName.TabIndex = 91;
            this.txtSpecimenName.TabStop = false;
            // 
            // txtResultHolder
            // 
            this.txtResultHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultHolder.ForeColor = System.Drawing.Color.Red;
            this.txtResultHolder.Location = new System.Drawing.Point(3, 487);
            this.txtResultHolder.Name = "txtResultHolder";
            this.txtResultHolder.Size = new System.Drawing.Size(19, 24);
            this.txtResultHolder.TabIndex = 92;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(508, 730);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 74;
            this.button2.Text = "Previous Records";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // txtHCN
            // 
            this.txtHCN.BackColor = System.Drawing.Color.Linen;
            this.txtHCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHCN.Location = new System.Drawing.Point(1105, 12);
            this.txtHCN.Name = "txtHCN";
            this.txtHCN.ReadOnly = true;
            this.txtHCN.Size = new System.Drawing.Size(29, 24);
            this.txtHCN.TabIndex = 93;
            this.txtHCN.TabStop = false;
            this.txtHCN.Visible = false;
            // 
            // txtSpcecimenID
            // 
            this.txtSpcecimenID.BackColor = System.Drawing.Color.Linen;
            this.txtSpcecimenID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpcecimenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpcecimenID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSpcecimenID.Location = new System.Drawing.Point(1150, 12);
            this.txtSpcecimenID.Name = "txtSpcecimenID";
            this.txtSpcecimenID.ReadOnly = true;
            this.txtSpcecimenID.Size = new System.Drawing.Size(29, 24);
            this.txtSpcecimenID.TabIndex = 94;
            this.txtSpcecimenID.TabStop = false;
            this.txtSpcecimenID.Visible = false;
            // 
            // txtRegID
            // 
            this.txtRegID.BackColor = System.Drawing.Color.Linen;
            this.txtRegID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRegID.Location = new System.Drawing.Point(1185, 12);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.ReadOnly = true;
            this.txtRegID.Size = new System.Drawing.Size(29, 24);
            this.txtRegID.TabIndex = 95;
            this.txtRegID.TabStop = false;
            this.txtRegID.Visible = false;
            // 
            // txtMrNo
            // 
            this.txtMrNo.BackColor = System.Drawing.Color.Linen;
            this.txtMrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMrNo.Location = new System.Drawing.Point(1220, 11);
            this.txtMrNo.Name = "txtMrNo";
            this.txtMrNo.ReadOnly = true;
            this.txtMrNo.Size = new System.Drawing.Size(29, 24);
            this.txtMrNo.TabIndex = 96;
            this.txtMrNo.TabStop = false;
            this.txtMrNo.Visible = false;
            // 
            // txtReportGr
            // 
            this.txtReportGr.BackColor = System.Drawing.Color.Linen;
            this.txtReportGr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportGr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtReportGr.Location = new System.Drawing.Point(1088, 11);
            this.txtReportGr.Name = "txtReportGr";
            this.txtReportGr.ReadOnly = true;
            this.txtReportGr.Size = new System.Drawing.Size(11, 24);
            this.txtReportGr.TabIndex = 97;
            this.txtReportGr.TabStop = false;
            this.txtReportGr.Visible = false;
            // 
            // lvSPCTests
            // 
            this.lvSPCTests.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvSPCTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSPCTests.CheckBoxes = true;
            this.lvSPCTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSPCTests.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSPCTests.FullRowSelect = true;
            this.lvSPCTests.GridLines = true;
            this.lvSPCTests.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSPCTests.Location = new System.Drawing.Point(818, 38);
            this.lvSPCTests.Name = "lvSPCTests";
            this.lvSPCTests.Size = new System.Drawing.Size(693, 160);
            this.lvSPCTests.TabIndex = 93;
            this.lvSPCTests.TabStop = false;
            this.lvSPCTests.UseCompatibleStateImageBehavior = false;
            this.lvSPCTests.View = System.Windows.Forms.View.Details;
            this.lvSPCTests.SelectedIndexChanged += new System.EventHandler(this.lvSPCTests_SelectedIndexChanged);
            // 
            // lblRrpGrp
            // 
            this.lblRrpGrp.BackColor = System.Drawing.Color.LightYellow;
            this.lblRrpGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRrpGrp.ForeColor = System.Drawing.Color.Navy;
            this.lblRrpGrp.Location = new System.Drawing.Point(1035, 1);
            this.lblRrpGrp.Name = "lblRrpGrp";
            this.lblRrpGrp.Size = new System.Drawing.Size(379, 28);
            this.lblRrpGrp.TabIndex = 93;
            this.lblRrpGrp.Text = "Report Group";
            this.lblRrpGrp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDep
            // 
            this.lblDep.BackColor = System.Drawing.Color.LightYellow;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ForeColor = System.Drawing.Color.Navy;
            this.lblDep.Location = new System.Drawing.Point(243, 3);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(232, 27);
            this.lblDep.TabIndex = 94;
            this.lblDep.Text = "Department";
            this.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightYellow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblReportSection);
            this.panel3.Controls.Add(this.lblRrpGrp);
            this.panel3.Location = new System.Drawing.Point(-1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1545, 32);
            this.panel3.TabIndex = 95;
            // 
            // lblReportSection
            // 
            this.lblReportSection.BackColor = System.Drawing.Color.LightYellow;
            this.lblReportSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSection.ForeColor = System.Drawing.Color.Navy;
            this.lblReportSection.Location = new System.Drawing.Point(629, 0);
            this.lblReportSection.Name = "lblReportSection";
            this.lblReportSection.Size = new System.Drawing.Size(353, 28);
            this.lblReportSection.TabIndex = 94;
            this.lblReportSection.Text = "Report Section";
            this.lblReportSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbResultHd
            // 
            this.tbResultHd.Location = new System.Drawing.Point(-1, 309);
            this.tbResultHd.Name = "tbResultHd";
            this.tbResultHd.SelectedIndex = 0;
            this.tbResultHd.Size = new System.Drawing.Size(41, 19);
            this.tbResultHd.TabIndex = 96;
            this.tbResultHd.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(159, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 35);
            this.btnSearch.TabIndex = 197;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvResultEntry
            // 
            this.dgvResultEntry.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResultEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultEntry.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvResultEntry.Location = new System.Drawing.Point(212, 201);
            this.dgvResultEntry.Name = "dgvResultEntry";
            this.dgvResultEntry.RowHeadersVisible = false;
            this.dgvResultEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResultEntry.Size = new System.Drawing.Size(1296, 465);
            this.dgvResultEntry.TabIndex = 198;
            this.dgvResultEntry.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResultEntry_CellFormatting);
            this.dgvResultEntry.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvResultEntry_CellPainting);
            // 
            // tvMoneyReceipt
            // 
            this.tvMoneyReceipt.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tvMoneyReceipt.Controls.Add(this.tabOPD);
            this.tvMoneyReceipt.Controls.Add(this.tabIPD);
            this.tvMoneyReceipt.Controls.Add(this.tbEmrg);
            this.tvMoneyReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvMoneyReceipt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMoneyReceipt.Location = new System.Drawing.Point(-1, 41);
            this.tvMoneyReceipt.Name = "tvMoneyReceipt";
            this.tvMoneyReceipt.SelectedIndex = 0;
            this.tvMoneyReceipt.Size = new System.Drawing.Size(211, 629);
            this.tvMoneyReceipt.TabIndex = 200;
            this.tvMoneyReceipt.SelectedIndexChanged += new System.EventHandler(this.tvMoneyReceipt_SelectedIndexChanged);
            // 
            // tabOPD
            // 
            this.tabOPD.Controls.Add(this.lstOPD);
            this.tabOPD.Location = new System.Drawing.Point(4, 31);
            this.tabOPD.Name = "tabOPD";
            this.tabOPD.Padding = new System.Windows.Forms.Padding(3);
            this.tabOPD.Size = new System.Drawing.Size(203, 594);
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
            this.lstOPD.HideSelection = false;
            this.lstOPD.Location = new System.Drawing.Point(3, 2);
            this.lstOPD.Name = "lstOPD";
            this.lstOPD.Size = new System.Drawing.Size(197, 596);
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
            this.tabIPD.Size = new System.Drawing.Size(203, 594);
            this.tabIPD.TabIndex = 1;
            this.tabIPD.Text = "IPD";
            this.tabIPD.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(3, 727);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(204, 33);
            this.btnRefresh.TabIndex = 205;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.tvNursStnMoneyReceipt.Location = new System.Drawing.Point(3, 3);
            this.tvNursStnMoneyReceipt.Name = "tvNursStnMoneyReceipt";
            this.tvNursStnMoneyReceipt.Size = new System.Drawing.Size(197, 588);
            this.tvNursStnMoneyReceipt.TabIndex = 195;
            this.tvNursStnMoneyReceipt.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNursStnMoneyReceipt_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.smartLabel5);
            this.panel2.Controls.Add(this.txtGender);
            this.panel2.Controls.Add(this.smartLabel2);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtMrID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.smartLabel1);
            this.panel2.Controls.Add(this.cboMachine);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.smartLabel6);
            this.panel2.Controls.Add(this.btnPatientSearch);
            this.panel2.Controls.Add(this.lblText);
            this.panel2.Controls.Add(this.txtSpecimenName);
            this.panel2.Controls.Add(this.smartLabel3);
            this.panel2.Controls.Add(this.txtPatientName);
            this.panel2.Location = new System.Drawing.Point(211, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 160);
            this.panel2.TabIndex = 201;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(512, 56);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(47, 15);
            this.smartLabel5.TabIndex = 210;
            this.smartLabel5.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Linen;
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtGender.Location = new System.Drawing.Point(511, 74);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(90, 29);
            this.txtGender.TabIndex = 211;
            this.txtGender.TabStop = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(257, 56);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(29, 15);
            this.smartLabel2.TabIndex = 208;
            this.smartLabel2.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Linen;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAge.Location = new System.Drawing.Point(253, 74);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(257, 29);
            this.txtAge.TabIndex = 209;
            this.txtAge.TabStop = false;
            // 
            // txtMrID
            // 
            this.txtMrID.BackColor = System.Drawing.Color.Linen;
            this.txtMrID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMrID.Location = new System.Drawing.Point(8, 24);
            this.txtMrID.Multiline = true;
            this.txtMrID.Name = "txtMrID";
            this.txtMrID.ReadOnly = true;
            this.txtMrID.Size = new System.Drawing.Size(218, 32);
            this.txtMrID.TabIndex = 203;
            this.txtMrID.TabStop = false;
            this.txtMrID.TextChanged += new System.EventHandler(this.txtMrID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(228, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 202;
            this.label3.Text = "*";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(8, 61);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(87, 15);
            this.smartLabel1.TabIndex = 201;
            this.smartLabel1.Text = "Machine Name";
            // 
            // cboMachine
            // 
            this.cboMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMachine.ForeColor = System.Drawing.Color.Blue;
            this.cboMachine.FormattingEnabled = true;
            this.cboMachine.Location = new System.Drawing.Point(6, 80);
            this.cboMachine.Name = "cboMachine";
            this.cboMachine.Size = new System.Drawing.Size(220, 26);
            this.cboMachine.TabIndex = 200;
            // 
            // btnWorkSheet
            // 
            this.btnWorkSheet.BackColor = System.Drawing.Color.Aqua;
            this.btnWorkSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkSheet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWorkSheet.Location = new System.Drawing.Point(212, 726);
            this.btnWorkSheet.Name = "btnWorkSheet";
            this.btnWorkSheet.Size = new System.Drawing.Size(175, 35);
            this.btnWorkSheet.TabIndex = 204;
            this.btnWorkSheet.Text = "Preview";
            this.btnWorkSheet.UseVisualStyleBackColor = false;
            this.btnWorkSheet.Click += new System.EventHandler(this.btnWorkSheet_Click);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(259, 6);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(87, 15);
            this.smartLabel4.TabIndex = 198;
            this.smartLabel4.Text = "Money Receipt";
            this.smartLabel4.Visible = false;
            // 
            // txtMoneyReceipt
            // 
            this.txtMoneyReceipt.BackColor = System.Drawing.Color.Linen;
            this.txtMoneyReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMoneyReceipt.Location = new System.Drawing.Point(363, 12);
            this.txtMoneyReceipt.Multiline = true;
            this.txtMoneyReceipt.Name = "txtMoneyReceipt";
            this.txtMoneyReceipt.ReadOnly = true;
            this.txtMoneyReceipt.Size = new System.Drawing.Size(52, 10);
            this.txtMoneyReceipt.TabIndex = 199;
            this.txtMoneyReceipt.TabStop = false;
            this.txtMoneyReceipt.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Location = new System.Drawing.Point(-1, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1545, 6);
            this.panel4.TabIndex = 202;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(55, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 206;
            this.label4.Text = "Spceciman is not collected !";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Location = new System.Drawing.Point(19, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 20);
            this.panel5.TabIndex = 205;
            // 
            // tbEmrg
            // 
            this.tbEmrg.Controls.Add(this.tvEmergency);
            this.tbEmrg.Location = new System.Drawing.Point(4, 31);
            this.tbEmrg.Name = "tbEmrg";
            this.tbEmrg.Size = new System.Drawing.Size(203, 594);
            this.tbEmrg.TabIndex = 2;
            this.tbEmrg.Text = "Emrg";
            this.tbEmrg.UseVisualStyleBackColor = true;
            // 
            // tvEmergency
            // 
            this.tvEmergency.BackColor = System.Drawing.Color.LightYellow;
            this.tvEmergency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvEmergency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvEmergency.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvEmergency.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvEmergency.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tvEmergency.LineColor = System.Drawing.Color.Crimson;
            this.tvEmergency.Location = new System.Drawing.Point(0, 3);
            this.tvEmergency.Name = "tvEmergency";
            this.tvEmergency.Size = new System.Drawing.Size(200, 591);
            this.tvEmergency.TabIndex = 196;
            this.tvEmergency.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEmergency_AfterSelect);
            // 
            // frmManualDiagnosticResultEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1514, 797);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnWorkSheet);
            this.Controls.Add(this.button2);
            this.isEnterTabAllow = true;
            this.Name = "frmManualDiagnosticResultEntry";
            this.Load += new System.EventHandler(this.frmDiagnosticResultEntry_Load);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnWorkSheet, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultHeads)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultEntry)).EndInit();
            this.tvMoneyReceipt.ResumeLayout(false);
            this.tabOPD.ResumeLayout(false);
            this.tabIPD.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tbEmrg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private System.Windows.Forms.Button btnPatientSearch;
        private AtiqsControlLibrary.SmartLabel lblText;
        private AtiqsControlLibrary.SmartDataGridView dgvResultHeads;
        private System.Windows.Forms.Label lblGrop;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblReportGroup;
        public System.Windows.Forms.Label lbdDepartment;
        private System.Windows.Forms.Panel panel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSpecimenName;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtResultHolder;
        private System.Windows.Forms.Button button2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHCN;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSpcecimenID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRegID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMrNo;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtReportGr;
        private AtiqsControlLibrary.SmartListViewDetails lvSPCTests;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblRrpGrp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tbResultHd;
        private System.Windows.Forms.Label lblReportSection;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvResultEntry;
        private AtiqsControlLibrary.SmartTab tvMoneyReceipt;
        private System.Windows.Forms.TabPage tabOPD;
        private AtiqsControlLibrary.SmartTreeView tvNursStnMoneyReceipt;
        private System.Windows.Forms.TabPage tabIPD;
        private AtiqsControlLibrary.SmartListViewDetails lstOPD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMoneyReceipt;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMrID;
        private System.Windows.Forms.Button btnWorkSheet;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtGender;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAge;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabPage tbEmrg;
        private AtiqsControlLibrary.SmartTreeView tvEmergency;
    }
}
