namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmIssueReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIssueID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.grpIssueDetails = new System.Windows.Forms.GroupBox();
            this.dgvIssueDetails = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvIssueReturn = new AtiqsControlLibrary.SmartDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtRetDate = new System.Windows.Forms.DateTimePicker();
            this.txtReturnType = new AtiqsControlLibrary.SmartTextBox();
            this.txtReturnFrom = new AtiqsControlLibrary.SmartTextBox();
            this.txtReturnCause = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtReturnID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtBatchID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPharmacyName = new AtiqsControlLibrary.SmartLabel();
            this.txtPharmacyID = new AtiqsControlLibrary.SmartLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIssueDate = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtIssueTypeName = new AtiqsControlLibrary.SmartLabel();
            this.txtIssueType = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalItem = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.lblNetTotal = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.grpIssueDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueReturn)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(458, 9);
            this.frmLabel.Size = new System.Drawing.Size(166, 33);
            this.frmLabel.Text = "Issue Return";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtBatchID);
            this.pnlMain.Controls.Add(this.txtReturnID);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtReturnCause);
            this.pnlMain.Controls.Add(this.txtReturnFrom);
            this.pnlMain.Controls.Add(this.txtReturnType);
            this.pnlMain.Controls.Add(this.txtRetDate);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.grpIssueDetails);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtIssueID);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(1113, 620);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1113, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(106, 683);
            this.btnEdit.Size = new System.Drawing.Size(37, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(886, 683);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(149, 683);
            this.btnDelete.Size = new System.Drawing.Size(40, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(773, 683);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(999, 683);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(195, 683);
            this.btnPrint.Size = new System.Drawing.Size(49, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 722);
            this.groupBox1.Size = new System.Drawing.Size(1113, 25);
            // 
            // txtIssueID
            // 
            this.txtIssueID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueID.Location = new System.Drawing.Point(107, 7);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(160, 24);
            this.txtIssueID.TabIndex = 0;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(15, 13);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(75, 13);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Receipt No.";
            // 
            // grpIssueDetails
            // 
            this.grpIssueDetails.Controls.Add(this.dgvIssueDetails);
            this.grpIssueDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIssueDetails.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grpIssueDetails.Location = new System.Drawing.Point(8, 94);
            this.grpIssueDetails.Name = "grpIssueDetails";
            this.grpIssueDetails.Size = new System.Drawing.Size(1094, 214);
            this.grpIssueDetails.TabIndex = 220;
            this.grpIssueDetails.TabStop = false;
            this.grpIssueDetails.Text = "Issue Details";
            // 
            // dgvIssueDetails
            // 
            this.dgvIssueDetails.AllowUserToAddRows = false;
            this.dgvIssueDetails.AllowUserToDeleteRows = false;
            this.dgvIssueDetails.AllowUserToOrderColumns = true;
            this.dgvIssueDetails.AllowUserToResizeColumns = false;
            this.dgvIssueDetails.AllowUserToResizeRows = false;
            this.dgvIssueDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssueDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvIssueDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIssueDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssueDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIssueDetails.Location = new System.Drawing.Point(6, 21);
            this.dgvIssueDetails.MultiSelect = false;
            this.dgvIssueDetails.Name = "dgvIssueDetails";
            this.dgvIssueDetails.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvIssueDetails.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIssueDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssueDetails.Size = new System.Drawing.Size(1081, 184);
            this.dgvIssueDetails.TabIndex = 0;
            // 
            // dgvIssueReturn
            // 
            this.dgvIssueReturn.AllowUserToAddRows = false;
            this.dgvIssueReturn.AllowUserToDeleteRows = false;
            this.dgvIssueReturn.AllowUserToOrderColumns = true;
            this.dgvIssueReturn.AllowUserToResizeColumns = false;
            this.dgvIssueReturn.AllowUserToResizeRows = false;
            this.dgvIssueReturn.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssueReturn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvIssueReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssueReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssueReturn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssueReturn.Location = new System.Drawing.Point(6, 19);
            this.dgvIssueReturn.MultiSelect = false;
            this.dgvIssueReturn.Name = "dgvIssueReturn";
            this.dgvIssueReturn.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvIssueReturn.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssueReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssueReturn.Size = new System.Drawing.Size(1079, 216);
            this.dgvIssueReturn.TabIndex = 169;
            this.dgvIssueReturn.TabStop = false;
            this.dgvIssueReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssueReturn_CellClick);
            this.dgvIssueReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssueReturn_CellContentClick);
            this.dgvIssueReturn.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvIssueReturn_CellValidating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvIssueReturn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(9, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1093, 239);
            this.groupBox2.TabIndex = 221;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Issue Return";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(735, 16);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(42, 13);
            this.smartLabel2.TabIndex = 222;
            this.smartLabel2.Text = "Date :";
            // 
            // txtRetDate
            // 
            this.txtRetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtRetDate.Location = new System.Drawing.Point(810, 12);
            this.txtRetDate.Name = "txtRetDate";
            this.txtRetDate.Size = new System.Drawing.Size(98, 20);
            this.txtRetDate.TabIndex = 223;
            // 
            // txtReturnType
            // 
            this.txtReturnType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnType.Location = new System.Drawing.Point(603, 43);
            this.txtReturnType.Name = "txtReturnType";
            this.txtReturnType.Size = new System.Drawing.Size(45, 24);
            this.txtReturnType.TabIndex = 225;
            this.txtReturnType.Text = "01";
            this.txtReturnType.Visible = false;
            // 
            // txtReturnFrom
            // 
            this.txtReturnFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnFrom.Location = new System.Drawing.Point(495, 43);
            this.txtReturnFrom.Name = "txtReturnFrom";
            this.txtReturnFrom.Size = new System.Drawing.Size(34, 24);
            this.txtReturnFrom.TabIndex = 227;
            this.txtReturnFrom.Text = "01";
            this.txtReturnFrom.Visible = false;
            this.txtReturnFrom.TextChanged += new System.EventHandler(this.txtReturnFrom_TextChanged);
            // 
            // txtReturnCause
            // 
            this.txtReturnCause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnCause.Location = new System.Drawing.Point(550, 56);
            this.txtReturnCause.Name = "txtReturnCause";
            this.txtReturnCause.Size = new System.Drawing.Size(38, 24);
            this.txtReturnCause.TabIndex = 229;
            this.txtReturnCause.Text = "01";
            this.txtReturnCause.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(810, 38);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(247, 26);
            this.txtRemarks.TabIndex = 230;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(735, 38);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(64, 13);
            this.smartLabel6.TabIndex = 231;
            this.smartLabel6.Text = "Remarks :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(267, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 30);
            this.btnSearch.TabIndex = 232;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1037, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 25);
            this.btnAdd.TabIndex = 233;
            this.btnAdd.Text = ">>>>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtReturnID
            // 
            this.txtReturnID.BackColor = System.Drawing.Color.Linen;
            this.txtReturnID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtReturnID.Location = new System.Drawing.Point(517, 5);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.ReadOnly = true;
            this.txtReturnID.Size = new System.Drawing.Size(152, 24);
            this.txtReturnID.TabIndex = 234;
            this.txtReturnID.TabStop = false;
            // 
            // txtBatchID
            // 
            this.txtBatchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchID.Location = new System.Drawing.Point(675, 61);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(38, 24);
            this.txtBatchID.TabIndex = 236;
            this.txtBatchID.Text = "01";
            this.txtBatchID.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(445, 11);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(69, 13);
            this.smartLabel3.TabIndex = 240;
            this.smartLabel3.Text = "Return No.";
            // 
            // txtPharmacyName
            // 
            this.txtPharmacyName.AutoSize = true;
            this.txtPharmacyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPharmacyName.Location = new System.Drawing.Point(55, 33);
            this.txtPharmacyName.Name = "txtPharmacyName";
            this.txtPharmacyName.Size = new System.Drawing.Size(94, 13);
            this.txtPharmacyName.TabIndex = 238;
            this.txtPharmacyName.Text = "PharmacyName";
            // 
            // txtPharmacyID
            // 
            this.txtPharmacyID.AutoSize = true;
            this.txtPharmacyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPharmacyID.Location = new System.Drawing.Point(55, 16);
            this.txtPharmacyID.Name = "txtPharmacyID";
            this.txtPharmacyID.Size = new System.Drawing.Size(75, 13);
            this.txtPharmacyID.TabIndex = 237;
            this.txtPharmacyID.Text = "PharmacyID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIssueDate);
            this.groupBox3.Controls.Add(this.smartLabel7);
            this.groupBox3.Controls.Add(this.txtIssueTypeName);
            this.groupBox3.Controls.Add(this.txtIssueType);
            this.groupBox3.Controls.Add(this.smartLabel5);
            this.groupBox3.Controls.Add(this.txtPharmacyID);
            this.groupBox3.Controls.Add(this.smartLabel4);
            this.groupBox3.Controls.Add(this.txtPharmacyName);
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 51);
            this.groupBox3.TabIndex = 241;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pharmacy";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.AutoSize = true;
            this.txtIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIssueDate.Location = new System.Drawing.Point(229, 33);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(64, 13);
            this.txtIssueDate.TabIndex = 242;
            this.txtIssueDate.Text = "IssueDate";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(159, 33);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(42, 13);
            this.smartLabel7.TabIndex = 242;
            this.smartLabel7.Text = "Date :";
            // 
            // txtIssueTypeName
            // 
            this.txtIssueTypeName.AutoSize = true;
            this.txtIssueTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIssueTypeName.Location = new System.Drawing.Point(234, 16);
            this.txtIssueTypeName.Name = "txtIssueTypeName";
            this.txtIssueTypeName.Size = new System.Drawing.Size(67, 13);
            this.txtIssueTypeName.TabIndex = 242;
            this.txtIssueTypeName.Text = "TypeName";
            // 
            // txtIssueType
            // 
            this.txtIssueType.AutoSize = true;
            this.txtIssueType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIssueType.Location = new System.Drawing.Point(161, 16);
            this.txtIssueType.Name = "txtIssueType";
            this.txtIssueType.Size = new System.Drawing.Size(77, 13);
            this.txtIssueType.TabIndex = 242;
            this.txtIssueType.Text = "Issue Type :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(2, 33);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(47, 13);
            this.smartLabel5.TabIndex = 243;
            this.smartLabel5.Text = "Name :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(7, 16);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(28, 13);
            this.smartLabel4.TabIndex = 242;
            this.smartLabel4.Text = "ID :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalItem);
            this.panel2.Controls.Add(this.smartLabel9);
            this.panel2.Controls.Add(this.lblNetTotal);
            this.panel2.Controls.Add(this.smartLabel8);
            this.panel2.Location = new System.Drawing.Point(792, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 32);
            this.panel2.TabIndex = 304;
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalItem.Location = new System.Drawing.Point(103, 11);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(14, 13);
            this.lblTotalItem.TabIndex = 3;
            this.lblTotalItem.Text = "0";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(16, 11);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(72, 13);
            this.smartLabel9.TabIndex = 2;
            this.smartLabel9.Text = "Total Item :";
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNetTotal.Location = new System.Drawing.Point(248, 11);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(14, 13);
            this.lblNetTotal.TabIndex = 1;
            this.lblNetTotal.Text = "0";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(138, 11);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(90, 13);
            this.smartLabel8.TabIndex = 0;
            this.smartLabel8.Text = "Total Amount :";
            // 
            // frmIssueReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1113, 747);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmIssueReturn";
            this.Load += new System.EventHandler(this.frmIssueReturn_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpIssueDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueReturn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtIssueID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartDataGridView dgvIssueReturn;
        private System.Windows.Forms.GroupBox grpIssueDetails;
        private AtiqsControlLibrary.SmartTextBox txtReturnFrom;
        private AtiqsControlLibrary.SmartTextBox txtReturnType;
        private System.Windows.Forms.DateTimePicker txtRetDate;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtReturnCause;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartDataGridView dgvIssueDetails;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtReturnID;
        private AtiqsControlLibrary.SmartTextBox txtBatchID;
        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartLabel txtPharmacyID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel txtPharmacyName;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel txtIssueTypeName;
        private AtiqsControlLibrary.SmartLabel txtIssueType;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel txtIssueDate;
        private System.Windows.Forms.Panel panel2;
        private AtiqsControlLibrary.SmartLabel lblTotalItem;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel lblNetTotal;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
    }
}
