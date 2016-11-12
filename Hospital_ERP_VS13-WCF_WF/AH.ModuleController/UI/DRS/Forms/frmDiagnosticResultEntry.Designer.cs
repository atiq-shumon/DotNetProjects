namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmDiagnosticResultEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtSpecimenNo = new System.Windows.Forms.TextBox();
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
            this.tvNursStnMoneyReceipt = new AtiqsControlLibrary.SmartTreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultHeads)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultEntry)).BeginInit();
            this.tvMoneyReceipt.SuspendLayout();
            this.tabOPD.SuspendLayout();
            this.tabIPD.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(942, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(496, 6);
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
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtCommnets);
            this.pnlMain.Controls.Add(this.lvSPCTests);
            this.pnlMain.Controls.Add(this.txtAdvice);
            this.pnlMain.Controls.Add(this.dgvResultHeads);
            this.pnlMain.Controls.Add(this.lblDep);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(1273, 675);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtReportGr);
            this.pnlTop.Controls.Add(this.txtMrNo);
            this.pnlTop.Controls.Add(this.txtRegID);
            this.pnlTop.Controls.Add(this.txtSpcecimenID);
            this.pnlTop.Controls.Add(this.txtHCN);
            this.pnlTop.Size = new System.Drawing.Size(1273, 51);
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
            this.btnEdit.Location = new System.Drawing.Point(192, 733);
            this.btnEdit.Size = new System.Drawing.Size(30, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(916, 732);
            this.btnSave.Size = new System.Drawing.Size(118, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(166, 732);
            this.btnDelete.Size = new System.Drawing.Size(20, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(802, 732);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1150, 732);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1037, 732);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 774);
            this.groupBox1.Size = new System.Drawing.Size(1273, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(257, 6);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(96, 18);
            this.smartLabel3.TabIndex = 76;
            this.smartLabel3.Text = "Patient Name :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(253, 29);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(296, 31);
            this.txtPatientName.TabIndex = 75;
            this.txtPatientName.TabStop = false;
            // 
            // txtSpecimenNo
            // 
            this.txtSpecimenNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecimenNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecimenNo.ForeColor = System.Drawing.Color.Red;
            this.txtSpecimenNo.Location = new System.Drawing.Point(6, 29);
            this.txtSpecimenNo.MaxLength = 11;
            this.txtSpecimenNo.Name = "txtSpecimenNo";
            this.txtSpecimenNo.Size = new System.Drawing.Size(233, 31);
            this.txtSpecimenNo.TabIndex = 0;
            this.txtSpecimenNo.TextChanged += new System.EventHandler(this.txtSpecimenNo_TextChanged);
            this.txtSpecimenNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSpecimenNo_KeyUp);
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(6, 76);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(102, 35);
            this.btnPatientSearch.TabIndex = 1;
            this.btnPatientSearch.Text = "Show";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblText.Location = new System.Drawing.Point(9, 7);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(95, 18);
            this.lblText.TabIndex = 74;
            this.lblText.Text = "Specimen No :";
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
            this.dgvResultHeads.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvResultHeads.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultHeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultHeads.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultHeads.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvResultHeads.Location = new System.Drawing.Point(2, 457);
            this.dgvResultHeads.MultiSelect = false;
            this.dgvResultHeads.Name = "dgvResultHeads";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultHeads.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResultHeads.RowHeadersVisible = false;
            this.dgvResultHeads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultHeads.Size = new System.Drawing.Size(20, 24);
            this.dgvResultHeads.TabIndex = 77;
            this.dgvResultHeads.Visible = false;
            // 
            // txtAdvice
            // 
            this.txtAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(178, 610);
            this.txtAdvice.Multiline = true;
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdvice.Size = new System.Drawing.Size(508, 60);
            this.txtAdvice.TabIndex = 2;
            this.txtAdvice.Text = "N/A";
            // 
            // txtCommnets
            // 
            this.txtCommnets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommnets.Location = new System.Drawing.Point(735, 611);
            this.txtCommnets.Multiline = true;
            this.txtCommnets.Name = "txtCommnets";
            this.txtCommnets.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommnets.Size = new System.Drawing.Size(533, 60);
            this.txtCommnets.TabIndex = 3;
            this.txtCommnets.Text = "N/A";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(182, 589);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(50, 18);
            this.smartLabel1.TabIndex = 80;
            this.smartLabel1.Text = "Advice";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(732, 589);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(73, 18);
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
            this.smartLabel6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(256, 61);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(74, 18);
            this.smartLabel6.TabIndex = 90;
            this.smartLabel6.Text = "Specimen :";
            // 
            // txtSpecimenName
            // 
            this.txtSpecimenName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtSpecimenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecimenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecimenName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSpecimenName.Location = new System.Drawing.Point(253, 82);
            this.txtSpecimenName.Multiline = true;
            this.txtSpecimenName.Name = "txtSpecimenName";
            this.txtSpecimenName.ReadOnly = true;
            this.txtSpecimenName.Size = new System.Drawing.Size(296, 29);
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
            this.button2.Location = new System.Drawing.Point(12, 733);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 74;
            this.button2.Text = "Previous Records";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // txtHCN
            // 
            this.txtHCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
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
            this.txtSpcecimenID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
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
            this.txtRegID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
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
            this.txtMrNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
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
            this.txtReportGr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
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
            this.lvSPCTests.Location = new System.Drawing.Point(734, 42);
            this.lvSPCTests.Name = "lvSPCTests";
            this.lvSPCTests.Size = new System.Drawing.Size(535, 133);
            this.lvSPCTests.TabIndex = 93;
            this.lvSPCTests.TabStop = false;
            this.lvSPCTests.UseCompatibleStateImageBehavior = false;
            this.lvSPCTests.View = System.Windows.Forms.View.Details;
            // 
            // lblRrpGrp
            // 
            this.lblRrpGrp.BackColor = System.Drawing.Color.LightYellow;
            this.lblRrpGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRrpGrp.ForeColor = System.Drawing.Color.Navy;
            this.lblRrpGrp.Location = new System.Drawing.Point(877, 1);
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
            this.lblDep.Location = new System.Drawing.Point(85, 3);
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
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1272, 32);
            this.panel3.TabIndex = 95;
            // 
            // lblReportSection
            // 
            this.lblReportSection.BackColor = System.Drawing.Color.LightYellow;
            this.lblReportSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSection.ForeColor = System.Drawing.Color.Navy;
            this.lblReportSection.Location = new System.Drawing.Point(471, 0);
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
            this.btnSearch.Location = new System.Drawing.Point(137, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 35);
            this.btnSearch.TabIndex = 197;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvResultEntry
            // 
            this.dgvResultEntry.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResultEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultEntry.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvResultEntry.Location = new System.Drawing.Point(179, 178);
            this.dgvResultEntry.Name = "dgvResultEntry";
            this.dgvResultEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResultEntry.Size = new System.Drawing.Size(1090, 392);
            this.dgvResultEntry.TabIndex = 198;
            this.dgvResultEntry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultEntry_CellClick);
            this.dgvResultEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultEntry_CellContentClick);
            this.dgvResultEntry.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResultEntry_CellMouseClick);
            this.dgvResultEntry.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvResultEntry_CurrentCellDirtyStateChanged);
            this.dgvResultEntry.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvResultEntry_Scroll);
            this.dgvResultEntry.SelectionChanged += new System.EventHandler(this.dgvResultEntry_SelectionChanged);
            this.dgvResultEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvResultEntry_KeyDown);
            // 
            // tvMoneyReceipt
            // 
            this.tvMoneyReceipt.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tvMoneyReceipt.Controls.Add(this.tabOPD);
            this.tvMoneyReceipt.Controls.Add(this.tabIPD);
            this.tvMoneyReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvMoneyReceipt.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMoneyReceipt.Location = new System.Drawing.Point(-1, 41);
            this.tvMoneyReceipt.Name = "tvMoneyReceipt";
            this.tvMoneyReceipt.SelectedIndex = 0;
            this.tvMoneyReceipt.Size = new System.Drawing.Size(177, 629);
            this.tvMoneyReceipt.TabIndex = 200;        
            // 
            // tabOPD
            // 
            this.tabOPD.Controls.Add(this.lstOPD);
            this.tabOPD.Location = new System.Drawing.Point(4, 31);
            this.tabOPD.Name = "tabOPD";
            this.tabOPD.Padding = new System.Windows.Forms.Padding(3);
            this.tabOPD.Size = new System.Drawing.Size(169, 594);
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
            this.lstOPD.Location = new System.Drawing.Point(3, 2);
            this.lstOPD.Name = "lstOPD";
            this.lstOPD.Size = new System.Drawing.Size(163, 596);
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
            this.tabIPD.Size = new System.Drawing.Size(169, 594);
            this.tabIPD.TabIndex = 1;
            this.tabIPD.Text = "IPD";
            this.tabIPD.UseVisualStyleBackColor = true;
            // 
            // tvNursStnMoneyReceipt
            // 
            this.tvNursStnMoneyReceipt.BackColor = System.Drawing.Color.SteelBlue;
            this.tvNursStnMoneyReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvNursStnMoneyReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvNursStnMoneyReceipt.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNursStnMoneyReceipt.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.tvNursStnMoneyReceipt.LineColor = System.Drawing.Color.BlanchedAlmond;
            this.tvNursStnMoneyReceipt.Location = new System.Drawing.Point(3, 3);
            this.tvNursStnMoneyReceipt.Name = "tvNursStnMoneyReceipt";
            this.tvNursStnMoneyReceipt.Size = new System.Drawing.Size(165, 599);
            this.tvNursStnMoneyReceipt.TabIndex = 195;
            this.tvNursStnMoneyReceipt.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNursStnMoneyReceipt_AfterSelect);          
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.smartLabel6);
            this.panel2.Controls.Add(this.btnPatientSearch);
            this.panel2.Controls.Add(this.lblText);
            this.panel2.Controls.Add(this.txtSpecimenNo);
            this.panel2.Controls.Add(this.txtSpecimenName);
            this.panel2.Controls.Add(this.smartLabel3);
            this.panel2.Controls.Add(this.txtPatientName);
            this.panel2.Location = new System.Drawing.Point(178, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 133);
            this.panel2.TabIndex = 201;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Location = new System.Drawing.Point(-1, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1272, 6);
            this.panel4.TabIndex = 202;
            // 
            // frmDiagnosticResultEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1273, 797);
            this.Controls.Add(this.button2);
            this.isEnterTabAllow = true;
            this.Name = "frmDiagnosticResultEntry";
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
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private System.Windows.Forms.TextBox txtSpecimenNo;
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
    }
}
