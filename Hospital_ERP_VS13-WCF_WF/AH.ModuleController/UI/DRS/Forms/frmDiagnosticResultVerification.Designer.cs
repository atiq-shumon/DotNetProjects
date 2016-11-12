namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmDiagnosticResultVerification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.lblText = new AtiqsControlLibrary.SmartLabel();
            this.dgvResultHeads = new AtiqsControlLibrary.SmartDataGridView();
            this.txtAdvice = new AtiqsControlLibrary.SmartTextBox();
            this.txtCommnets = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdDepartment = new System.Windows.Forms.Label();
            this.lblGrop = new System.Windows.Forms.Label();
            this.lblReportGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtSpecimenName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtResultHolder = new AtiqsControlLibrary.SmartTextBox();
            this.btnRe = new System.Windows.Forms.Button();
            this.txtHCN = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtSpcecimenID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtRegID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtMrNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtReportGr = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lvSPCTests = new AtiqsControlLibrary.SmartListViewDetails();
            this.lblDep = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblReportSection = new System.Windows.Forms.Label();
            this.lblRrpGrp = new System.Windows.Forms.Label();
            this.tbResultHd = new System.Windows.Forms.TabControl();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvResultEntry = new System.Windows.Forms.DataGridView();
            this.tvMoneyReceipt = new AtiqsControlLibrary.SmartTab();
            this.tabOPD = new System.Windows.Forms.TabPage();
            this.lstOPD = new AtiqsControlLibrary.SmartListViewDetails();
            this.tabIPD = new System.Windows.Forms.TabPage();
            this.tvNursStnMoneyReceipt = new AtiqsControlLibrary.SmartTreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtGender = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtAge = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtMrID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvLatestResult = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRecentResult = new System.Windows.Forms.Button();
            this.btnVerifiedResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvResultView = new System.Windows.Forms.DataGridView();
            this.btnRptPreview = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLatestResult)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultView)).BeginInit();
            this.tbEmrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1265, 19);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(674, 5);
            this.frmLabel.Size = new System.Drawing.Size(294, 33);
            this.frmLabel.Text = "Diagnostic Result Verify";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Azure;
            this.pnlMain.Controls.Add(this.dgvResultEntry);
            this.pnlMain.Controls.Add(this.dgvResultView);
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.lvSPCTests);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.dgvLatestResult);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.tvMoneyReceipt);
            this.pnlMain.Controls.Add(this.tbResultHd);
            this.pnlMain.Controls.Add(this.txtResultHolder);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtCommnets);
            this.pnlMain.Controls.Add(this.dgvResultHeads);
            this.pnlMain.Controls.Add(this.lblDep);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Location = new System.Drawing.Point(-1, 50);
            this.pnlMain.Size = new System.Drawing.Size(1615, 696);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtReportGr);
            this.pnlTop.Controls.Add(this.txtMrNo);
            this.pnlTop.Controls.Add(this.txtRegID);
            this.pnlTop.Controls.Add(this.txtSpcecimenID);
            this.pnlTop.Controls.Add(this.txtHCN);
            this.pnlTop.Size = new System.Drawing.Size(1614, 51);
            this.pnlTop.Controls.SetChildIndex(this.txtHCN, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtSpcecimenID, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtRegID, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtMrNo, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtReportGr, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(434, 758);
            this.btnEdit.Size = new System.Drawing.Size(10, 10);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1360, 754);
            this.btnSave.Size = new System.Drawing.Size(140, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(408, 758);
            this.btnDelete.Size = new System.Drawing.Size(10, 10);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1251, 754);
            this.btnNew.Size = new System.Drawing.Size(107, 44);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1502, 754);
            this.btnClose.Size = new System.Drawing.Size(107, 44);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(376, 758);
            this.btnPrint.Size = new System.Drawing.Size(16, 34);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 801);
            this.groupBox1.Size = new System.Drawing.Size(1614, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(315, -2);
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
            this.txtPatientName.Location = new System.Drawing.Point(310, 14);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(391, 28);
            this.txtPatientName.TabIndex = 75;
            this.txtPatientName.TabStop = false;
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(3, 80);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(242, 32);
            this.btnPatientSearch.TabIndex = 2;
            this.btnPatientSearch.Text = "Show";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblText.Location = new System.Drawing.Point(3, 6);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvResultHeads.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultHeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultHeads.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultHeads.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvResultHeads.Location = new System.Drawing.Point(2, 457);
            this.dgvResultHeads.MultiSelect = false;
            this.dgvResultHeads.Name = "dgvResultHeads";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultHeads.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultHeads.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvResultHeads.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultHeads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultHeads.Size = new System.Drawing.Size(20, 24);
            this.dgvResultHeads.TabIndex = 77;
            this.dgvResultHeads.Visible = false;
            // 
            // txtAdvice
            // 
            this.txtAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(196, 772);
            this.txtAdvice.MaxLength = 300;
            this.txtAdvice.Multiline = true;
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdvice.Size = new System.Drawing.Size(50, 20);
            this.txtAdvice.TabIndex = 2;
            this.txtAdvice.Visible = false;
            this.txtAdvice.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtAdvice_PreviewKeyDown);
            // 
            // txtCommnets
            // 
            this.txtCommnets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommnets.Location = new System.Drawing.Point(455, 616);
            this.txtCommnets.MaxLength = 1000;
            this.txtCommnets.Multiline = true;
            this.txtCommnets.Name = "txtCommnets";
            this.txtCommnets.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommnets.Size = new System.Drawing.Size(910, 75);
            this.txtCommnets.TabIndex = 3;
            this.txtCommnets.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCommnets_PreviewKeyDown);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(203, 753);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(43, 15);
            this.smartLabel1.TabIndex = 80;
            this.smartLabel1.Text = "Advice";
            this.smartLabel1.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(384, 623);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(65, 15);
            this.smartLabel2.TabIndex = 81;
            this.smartLabel2.Text = "Comments";
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
            this.smartLabel6.Location = new System.Drawing.Point(315, 80);
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
            this.txtSpecimenName.Location = new System.Drawing.Point(310, 96);
            this.txtSpecimenName.Multiline = true;
            this.txtSpecimenName.Name = "txtSpecimenName";
            this.txtSpecimenName.ReadOnly = true;
            this.txtSpecimenName.Size = new System.Drawing.Size(391, 27);
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
            // btnRe
            // 
            this.btnRe.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRe.ForeColor = System.Drawing.Color.White;
            this.btnRe.Location = new System.Drawing.Point(470, 757);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(10, 11);
            this.btnRe.TabIndex = 74;
            this.btnRe.Text = "Previous Records";
            this.btnRe.UseVisualStyleBackColor = false;
            this.btnRe.Visible = false;
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
            this.txtReportGr.Location = new System.Drawing.Point(1090, 13);
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
            this.lvSPCTests.Location = new System.Drawing.Point(917, 41);
            this.lvSPCTests.Name = "lvSPCTests";
            this.lvSPCTests.Size = new System.Drawing.Size(698, 128);
            this.lvSPCTests.TabIndex = 93;
            this.lvSPCTests.TabStop = false;
            this.lvSPCTests.UseCompatibleStateImageBehavior = false;
            this.lvSPCTests.View = System.Windows.Forms.View.Details;
            this.lvSPCTests.SelectedIndexChanged += new System.EventHandler(this.lvSPCTests_SelectedIndexChanged);
            // 
            // lblDep
            // 
            this.lblDep.BackColor = System.Drawing.Color.LightYellow;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ForeColor = System.Drawing.Color.Navy;
            this.lblDep.Location = new System.Drawing.Point(209, 3);
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
            this.panel3.Size = new System.Drawing.Size(1618, 32);
            this.panel3.TabIndex = 95;
            // 
            // lblReportSection
            // 
            this.lblReportSection.BackColor = System.Drawing.Color.LightYellow;
            this.lblReportSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSection.ForeColor = System.Drawing.Color.Navy;
            this.lblReportSection.Location = new System.Drawing.Point(751, 2);
            this.lblReportSection.Name = "lblReportSection";
            this.lblReportSection.Size = new System.Drawing.Size(353, 28);
            this.lblReportSection.TabIndex = 94;
            this.lblReportSection.Text = "Report Section";
            this.lblReportSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRrpGrp
            // 
            this.lblRrpGrp.BackColor = System.Drawing.Color.LightYellow;
            this.lblRrpGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRrpGrp.ForeColor = System.Drawing.Color.Navy;
            this.lblRrpGrp.Location = new System.Drawing.Point(1207, 1);
            this.lblRrpGrp.Name = "lblRrpGrp";
            this.lblRrpGrp.Size = new System.Drawing.Size(379, 28);
            this.lblRrpGrp.TabIndex = 93;
            this.lblRrpGrp.Text = "Report Group";
            this.lblRrpGrp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSearch.Location = new System.Drawing.Point(258, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 32);
            this.btnSearch.TabIndex = 197;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvResultEntry
            // 
            this.dgvResultEntry.AllowUserToAddRows = false;
            this.dgvResultEntry.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResultEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultEntry.GridColor = System.Drawing.Color.LightGreen;
            this.dgvResultEntry.Location = new System.Drawing.Point(210, 200);
            this.dgvResultEntry.Name = "dgvResultEntry";
            this.dgvResultEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResultEntry.Size = new System.Drawing.Size(707, 415);
            this.dgvResultEntry.TabIndex = 198;
            this.dgvResultEntry.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResultEntry_CellFormatting);
            this.dgvResultEntry.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvResultEntry_CellPainting);
            this.dgvResultEntry.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvLatestResult_CurrentCellDirtyStateChanged);
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
            this.tvMoneyReceipt.Size = new System.Drawing.Size(211, 620);
            this.tvMoneyReceipt.TabIndex = 200;
            this.tvMoneyReceipt.SelectedIndexChanged += new System.EventHandler(this.tvMoneyReceipt_SelectedIndexChanged);
            // 
            // tabOPD
            // 
            this.tabOPD.Controls.Add(this.lstOPD);
            this.tabOPD.Location = new System.Drawing.Point(4, 31);
            this.tabOPD.Name = "tabOPD";
            this.tabOPD.Padding = new System.Windows.Forms.Padding(3);
            this.tabOPD.Size = new System.Drawing.Size(203, 585);
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
            this.lstOPD.Location = new System.Drawing.Point(-1, 2);
            this.lstOPD.Name = "lstOPD";
            this.lstOPD.Size = new System.Drawing.Size(201, 582);
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
            this.tabIPD.Size = new System.Drawing.Size(203, 585);
            this.tabIPD.TabIndex = 1;
            this.tabIPD.Text = "IPD";
            this.tabIPD.UseVisualStyleBackColor = true;
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
            this.tvNursStnMoneyReceipt.Location = new System.Drawing.Point(-1, 2);
            this.tvNursStnMoneyReceipt.Name = "tvNursStnMoneyReceipt";
            this.tvNursStnMoneyReceipt.Size = new System.Drawing.Size(201, 581);
            this.tvNursStnMoneyReceipt.TabIndex = 195;
            this.tvNursStnMoneyReceipt.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNursStnMoneyReceipt_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.smartLabel5);
            this.panel2.Controls.Add(this.txtGender);
            this.panel2.Controls.Add(this.smartLabel4);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtMrID);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.smartLabel6);
            this.panel2.Controls.Add(this.btnPatientSearch);
            this.panel2.Controls.Add(this.lblText);
            this.panel2.Controls.Add(this.txtSpecimenName);
            this.panel2.Controls.Add(this.smartLabel3);
            this.panel2.Controls.Add(this.txtPatientName);
            this.panel2.Location = new System.Drawing.Point(210, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 128);
            this.panel2.TabIndex = 201;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(619, 42);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(47, 15);
            this.smartLabel5.TabIndex = 214;
            this.smartLabel5.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Linen;
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtGender.Location = new System.Drawing.Point(611, 58);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(90, 23);
            this.txtGender.TabIndex = 215;
            this.txtGender.TabStop = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(315, 42);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(29, 15);
            this.smartLabel4.TabIndex = 212;
            this.smartLabel4.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Linen;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAge.Location = new System.Drawing.Point(310, 58);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(295, 23);
            this.txtAge.TabIndex = 213;
            this.txtAge.TabStop = false;
            // 
            // txtMrID
            // 
            this.txtMrID.BackColor = System.Drawing.Color.Linen;
            this.txtMrID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMrID.Location = new System.Drawing.Point(3, 28);
            this.txtMrID.Multiline = true;
            this.txtMrID.Name = "txtMrID";
            this.txtMrID.ReadOnly = true;
            this.txtMrID.Size = new System.Drawing.Size(242, 32);
            this.txtMrID.TabIndex = 1;
            this.txtMrID.TabStop = false;
            this.txtMrID.TextChanged += new System.EventHandler(this.txtMrID_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Location = new System.Drawing.Point(-1, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1620, 6);
            this.panel4.TabIndex = 202;
            // 
            // dgvLatestResult
            // 
            this.dgvLatestResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLatestResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLatestResult.GridColor = System.Drawing.Color.BlueViolet;
            this.dgvLatestResult.Location = new System.Drawing.Point(917, 200);
            this.dgvLatestResult.Name = "dgvLatestResult";
            this.dgvLatestResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLatestResult.Size = new System.Drawing.Size(696, 415);
            this.dgvLatestResult.TabIndex = 203;
            this.dgvLatestResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLatestResult_CellFormatting);
            this.dgvLatestResult.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvLatestResult_CellPainting);
            this.dgvLatestResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLatestResult_KeyDown);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(0, 661);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(210, 32);
            this.btnRefresh.TabIndex = 75;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.Controls.Add(this.btnRecentResult);
            this.panel5.Controls.Add(this.btnVerifiedResult);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(209, 169);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1402, 31);
            this.panel5.TabIndex = 204;
            // 
            // btnRecentResult
            // 
            this.btnRecentResult.BackColor = System.Drawing.Color.Lavender;
            this.btnRecentResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecentResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentResult.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRecentResult.Location = new System.Drawing.Point(710, 2);
            this.btnRecentResult.Name = "btnRecentResult";
            this.btnRecentResult.Size = new System.Drawing.Size(347, 28);
            this.btnRecentResult.TabIndex = 4;
            this.btnRecentResult.Text = " Result to be Verified";
            this.btnRecentResult.UseVisualStyleBackColor = false;
            this.btnRecentResult.Click += new System.EventHandler(this.btnRecentResult_Click);
            // 
            // btnVerifiedResult
            // 
            this.btnVerifiedResult.BackColor = System.Drawing.Color.LightCyan;
            this.btnVerifiedResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifiedResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerifiedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifiedResult.ForeColor = System.Drawing.Color.Navy;
            this.btnVerifiedResult.Location = new System.Drawing.Point(1058, 2);
            this.btnVerifiedResult.Name = "btnVerifiedResult";
            this.btnVerifiedResult.Size = new System.Drawing.Size(343, 28);
            this.btnVerifiedResult.TabIndex = 3;
            this.btnVerifiedResult.Text = "Previous Verified Result";
            this.btnVerifiedResult.UseVisualStyleBackColor = false;
            this.btnVerifiedResult.Click += new System.EventHandler(this.btnVerifiedResult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(250, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "All Machine Result";
            // 
            // dgvResultView
            // 
            this.dgvResultView.AllowUserToAddRows = false;
            this.dgvResultView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultView.GridColor = System.Drawing.Color.BlueViolet;
            this.dgvResultView.Location = new System.Drawing.Point(917, 200);
            this.dgvResultView.Name = "dgvResultView";
            this.dgvResultView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResultView.Size = new System.Drawing.Size(695, 415);
            this.dgvResultView.TabIndex = 205;
            // 
            // btnRptPreview
            // 
            this.btnRptPreview.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRptPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRptPreview.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnRptPreview.Location = new System.Drawing.Point(12, 752);
            this.btnRptPreview.Name = "btnRptPreview";
            this.btnRptPreview.Size = new System.Drawing.Size(154, 35);
            this.btnRptPreview.TabIndex = 205;
            this.btnRptPreview.Text = "Report Preview ";
            this.btnRptPreview.UseVisualStyleBackColor = false;
            this.btnRptPreview.Click += new System.EventHandler(this.btnRptPreview_Click);
            // 
            // tbEmrg
            // 
            this.tbEmrg.Controls.Add(this.tvEmergency);
            this.tbEmrg.Location = new System.Drawing.Point(4, 31);
            this.tbEmrg.Name = "tbEmrg";
            this.tbEmrg.Size = new System.Drawing.Size(203, 585);
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
            this.tvEmergency.Location = new System.Drawing.Point(-3, 2);
            this.tvEmergency.Name = "tvEmergency";
            this.tvEmergency.Size = new System.Drawing.Size(203, 581);
            this.tvEmergency.TabIndex = 196;
            this.tvEmergency.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEmergency_AfterSelect);
            // 
            // frmDiagnosticResultVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1614, 824);
            this.Controls.Add(this.btnRptPreview);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.smartLabel1);
            this.Controls.Add(this.txtAdvice);
            this.isEnterTabAllow = true;
            this.Name = "frmDiagnosticResultVerification";
            this.Load += new System.EventHandler(this.frmDiagnosticResultEntry_Load);
            this.Controls.SetChildIndex(this.txtAdvice, 0);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.Controls.SetChildIndex(this.btnRe, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnRptPreview, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLatestResult)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultView)).EndInit();
            this.tbEmrg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private System.Windows.Forms.Button btnPatientSearch;
        private AtiqsControlLibrary.SmartLabel lblText;
        private AtiqsControlLibrary.SmartDataGridView dgvResultHeads;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtCommnets;
        private AtiqsControlLibrary.SmartTextBox txtAdvice;
        private System.Windows.Forms.Label lblGrop;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblReportGroup;
        public System.Windows.Forms.Label lbdDepartment;
        private System.Windows.Forms.Panel panel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSpecimenName;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtResultHolder;
        private System.Windows.Forms.Button btnRe;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHCN;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSpcecimenID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRegID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMrNo;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtReportGr;
        private AtiqsControlLibrary.SmartListViewDetails lvSPCTests;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tbResultHd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvResultEntry;
        private AtiqsControlLibrary.SmartTab tvMoneyReceipt;
        private System.Windows.Forms.TabPage tabOPD;
        private AtiqsControlLibrary.SmartTreeView tvNursStnMoneyReceipt;
        private System.Windows.Forms.TabPage tabIPD;
        private AtiqsControlLibrary.SmartListViewDetails lstOPD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvLatestResult;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblReportSection;
        private System.Windows.Forms.Label lblRrpGrp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecentResult;
        private System.Windows.Forms.Button btnVerifiedResult;
        private System.Windows.Forms.DataGridView dgvResultView;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMrID;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtGender;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAge;
        private System.Windows.Forms.Button btnRptPreview;
        private System.Windows.Forms.TabPage tbEmrg;
        private AtiqsControlLibrary.SmartTreeView tvEmergency;
    }
}
