namespace AH.ModuleController.UI.INVMS.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIssueDate = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtIssueTypeName = new AtiqsControlLibrary.SmartLabel();
            this.txtIssueType = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtStoreID = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtStoreName = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtReturnID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtReturnCause = new AtiqsControlLibrary.SmartTextBox();
            this.txtReturnFrom = new AtiqsControlLibrary.SmartTextBox();
            this.txtReturnType = new AtiqsControlLibrary.SmartTextBox();
            this.txtRetDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtIssueID = new AtiqsControlLibrary.SmartTextBox();
            this.grpIssueDetails = new System.Windows.Forms.GroupBox();
            this.dgvIssueDetails = new AtiqsControlLibrary.SmartDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvIssueReturn = new AtiqsControlLibrary.SmartDataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBatchID = new AtiqsControlLibrary.SmartLabel();
            this.dgvSerialNo = new AtiqsControlLibrary.SmartDataGridView();
            this.grpItemSerialNo = new System.Windows.Forms.GroupBox();
            this.btnAddSerial = new System.Windows.Forms.Button();
            this.dgvLoadSerialNo = new AtiqsControlLibrary.SmartDataGridView();
            this.txtItemID = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpIssueDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerialNo)).BeginInit();
            this.grpItemSerialNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadSerialNo)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(521, 9);
            this.frmLabel.Size = new System.Drawing.Size(166, 33);
            this.frmLabel.Text = "Issue Return";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtBatchID);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.grpIssueDetails);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtReturnID);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtReturnCause);
            this.pnlMain.Controls.Add(this.txtReturnFrom);
            this.pnlMain.Controls.Add(this.txtReturnType);
            this.pnlMain.Controls.Add(this.txtRetDate);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtIssueID);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(1114, 636);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1322, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(275, 700);
            this.btnEdit.Size = new System.Drawing.Size(58, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1096, 700);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(477, 700);
            this.btnDelete.Size = new System.Drawing.Size(49, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(987, 700);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1205, 700);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(371, 700);
            this.btnPrint.Size = new System.Drawing.Size(64, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 741);
            this.groupBox1.Size = new System.Drawing.Size(1322, 25);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIssueDate);
            this.groupBox3.Controls.Add(this.smartLabel7);
            this.groupBox3.Controls.Add(this.txtIssueTypeName);
            this.groupBox3.Controls.Add(this.txtIssueType);
            this.groupBox3.Controls.Add(this.smartLabel5);
            this.groupBox3.Controls.Add(this.txtStoreID);
            this.groupBox3.Controls.Add(this.smartLabel4);
            this.groupBox3.Controls.Add(this.txtStoreName);
            this.groupBox3.Location = new System.Drawing.Point(8, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 51);
            this.groupBox3.TabIndex = 254;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pharmacy";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.AutoSize = true;
            this.txtIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIssueDate.Location = new System.Drawing.Point(205, 34);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(64, 13);
            this.txtIssueDate.TabIndex = 242;
            this.txtIssueDate.Text = "IssueDate";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(159, 34);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(42, 13);
            this.smartLabel7.TabIndex = 242;
            this.smartLabel7.Text = "Date :";
            // 
            // txtIssueTypeName
            // 
            this.txtIssueTypeName.AutoSize = true;
            this.txtIssueTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIssueTypeName.Location = new System.Drawing.Point(79, 34);
            this.txtIssueTypeName.Name = "txtIssueTypeName";
            this.txtIssueTypeName.Size = new System.Drawing.Size(67, 13);
            this.txtIssueTypeName.TabIndex = 242;
            this.txtIssueTypeName.Text = "TypeName";
            // 
            // txtIssueType
            // 
            this.txtIssueType.AutoSize = true;
            this.txtIssueType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIssueType.Location = new System.Drawing.Point(7, 34);
            this.txtIssueType.Name = "txtIssueType";
            this.txtIssueType.Size = new System.Drawing.Size(77, 13);
            this.txtIssueType.TabIndex = 242;
            this.txtIssueType.Text = "Issue Type :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(155, 17);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(47, 13);
            this.smartLabel5.TabIndex = 243;
            this.smartLabel5.Text = "Name :";
            // 
            // txtStoreID
            // 
            this.txtStoreID.AutoSize = true;
            this.txtStoreID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtStoreID.Location = new System.Drawing.Point(79, 17);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(50, 13);
            this.txtStoreID.TabIndex = 237;
            this.txtStoreID.Text = "StoreID";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(7, 17);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(28, 13);
            this.smartLabel4.TabIndex = 242;
            this.smartLabel4.Text = "ID :";
            // 
            // txtStoreName
            // 
            this.txtStoreName.AutoSize = true;
            this.txtStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtStoreName.Location = new System.Drawing.Point(206, 17);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(69, 13);
            this.txtStoreName.TabIndex = 238;
            this.txtStoreName.Text = "StoreName";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(441, 14);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(69, 13);
            this.smartLabel3.TabIndex = 253;
            this.smartLabel3.Text = "Return No.";
            // 
            // txtReturnID
            // 
            this.txtReturnID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtReturnID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtReturnID.Location = new System.Drawing.Point(513, 8);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.ReadOnly = true;
            this.txtReturnID.Size = new System.Drawing.Size(152, 24);
            this.txtReturnID.TabIndex = 251;
            this.txtReturnID.TabStop = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(731, 41);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(64, 13);
            this.smartLabel6.TabIndex = 250;
            this.smartLabel6.Text = "Remarks :";
            // 
            // txtReturnCause
            // 
            this.txtReturnCause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnCause.Location = new System.Drawing.Point(546, 59);
            this.txtReturnCause.Name = "txtReturnCause";
            this.txtReturnCause.Size = new System.Drawing.Size(38, 24);
            this.txtReturnCause.TabIndex = 248;
            this.txtReturnCause.Text = "01";
            this.txtReturnCause.Visible = false;
            // 
            // txtReturnFrom
            // 
            this.txtReturnFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnFrom.Location = new System.Drawing.Point(491, 46);
            this.txtReturnFrom.Name = "txtReturnFrom";
            this.txtReturnFrom.Size = new System.Drawing.Size(34, 24);
            this.txtReturnFrom.TabIndex = 247;
            this.txtReturnFrom.Text = "01";
            this.txtReturnFrom.Visible = false;
            // 
            // txtReturnType
            // 
            this.txtReturnType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnType.Location = new System.Drawing.Point(599, 46);
            this.txtReturnType.Name = "txtReturnType";
            this.txtReturnType.Size = new System.Drawing.Size(45, 24);
            this.txtReturnType.TabIndex = 246;
            this.txtReturnType.Text = "01";
            this.txtReturnType.Visible = false;
            // 
            // txtRetDate
            // 
            this.txtRetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtRetDate.Location = new System.Drawing.Point(806, 15);
            this.txtRetDate.Name = "txtRetDate";
            this.txtRetDate.Size = new System.Drawing.Size(98, 20);
            this.txtRetDate.TabIndex = 245;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(731, 19);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(42, 13);
            this.smartLabel2.TabIndex = 244;
            this.smartLabel2.Text = "Date :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(11, 16);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(61, 13);
            this.smartLabel1.TabIndex = 243;
            this.smartLabel1.Text = "Issue No.";
            // 
            // txtIssueID
            // 
            this.txtIssueID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueID.Location = new System.Drawing.Point(103, 10);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(160, 24);
            this.txtIssueID.TabIndex = 242;
            // 
            // grpIssueDetails
            // 
            this.grpIssueDetails.Controls.Add(this.dgvIssueDetails);
            this.grpIssueDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIssueDetails.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grpIssueDetails.Location = new System.Drawing.Point(7, 120);
            this.grpIssueDetails.Name = "grpIssueDetails";
            this.grpIssueDetails.Size = new System.Drawing.Size(1094, 214);
            this.grpIssueDetails.TabIndex = 255;
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
            this.dgvIssueDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvIssueDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssueDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssueDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssueDetails.Location = new System.Drawing.Point(6, 20);
            this.dgvIssueDetails.MultiSelect = false;
            this.dgvIssueDetails.Name = "dgvIssueDetails";
            this.dgvIssueDetails.RowHeadersVisible = false;
            this.dgvIssueDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssueDetails.Size = new System.Drawing.Size(1081, 184);
            this.dgvIssueDetails.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvIssueReturn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(8, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1093, 239);
            this.groupBox2.TabIndex = 256;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Issue Return";
            // 
            // dgvIssueReturn
            // 
            this.dgvIssueReturn.AllowUserToAddRows = false;
            this.dgvIssueReturn.AllowUserToDeleteRows = false;
            this.dgvIssueReturn.AllowUserToOrderColumns = true;
            this.dgvIssueReturn.AllowUserToResizeColumns = false;
            this.dgvIssueReturn.AllowUserToResizeRows = false;
            this.dgvIssueReturn.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssueReturn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvIssueReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssueReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssueReturn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIssueReturn.Location = new System.Drawing.Point(8, 18);
            this.dgvIssueReturn.MultiSelect = false;
            this.dgvIssueReturn.Name = "dgvIssueReturn";
            this.dgvIssueReturn.RowHeadersVisible = false;
            this.dgvIssueReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssueReturn.Size = new System.Drawing.Size(1076, 211);
            this.dgvIssueReturn.TabIndex = 169;
            this.dgvIssueReturn.TabStop = false;
            this.dgvIssueReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssueReturn_CellClick);
            this.dgvIssueReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssueReturn_CellContentClick);
            this.dgvIssueReturn.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvIssueReturn_CellValidating);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(264, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 30);
            this.btnSearch.TabIndex = 257;
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
            this.btnAdd.Location = new System.Drawing.Point(1026, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 25);
            this.btnAdd.TabIndex = 258;
            this.btnAdd.Text = ">>>>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBatchID
            // 
            this.txtBatchID.AutoSize = true;
            this.txtBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtBatchID.Location = new System.Drawing.Point(734, 78);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(56, 13);
            this.txtBatchID.TabIndex = 259;
            this.txtBatchID.Text = "BatchNo";
            this.txtBatchID.Visible = false;
            // 
            // dgvSerialNo
            // 
            this.dgvSerialNo.AllowUserToAddRows = false;
            this.dgvSerialNo.AllowUserToDeleteRows = false;
            this.dgvSerialNo.AllowUserToOrderColumns = true;
            this.dgvSerialNo.AllowUserToResizeColumns = false;
            this.dgvSerialNo.AllowUserToResizeRows = false;
            this.dgvSerialNo.BackgroundColor = System.Drawing.Color.White;
            this.dgvSerialNo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSerialNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSerialNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSerialNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSerialNo.Location = new System.Drawing.Point(6, 21);
            this.dgvSerialNo.MultiSelect = false;
            this.dgvSerialNo.Name = "dgvSerialNo";
            this.dgvSerialNo.RowHeadersVisible = false;
            this.dgvSerialNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSerialNo.Size = new System.Drawing.Size(183, 326);
            this.dgvSerialNo.TabIndex = 0;
            // 
            // grpItemSerialNo
            // 
            this.grpItemSerialNo.Controls.Add(this.btnAddSerial);
            this.grpItemSerialNo.Controls.Add(this.dgvLoadSerialNo);
            this.grpItemSerialNo.Controls.Add(this.dgvSerialNo);
            this.grpItemSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpItemSerialNo.ForeColor = System.Drawing.Color.White;
            this.grpItemSerialNo.Location = new System.Drawing.Point(1119, 58);
            this.grpItemSerialNo.Name = "grpItemSerialNo";
            this.grpItemSerialNo.Size = new System.Drawing.Size(197, 636);
            this.grpItemSerialNo.TabIndex = 223;
            this.grpItemSerialNo.TabStop = false;
            this.grpItemSerialNo.Text = "Item Serial No";
            // 
            // btnAddSerial
            // 
            this.btnAddSerial.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSerial.ForeColor = System.Drawing.Color.White;
            this.btnAddSerial.Location = new System.Drawing.Point(144, 348);
            this.btnAddSerial.Name = "btnAddSerial";
            this.btnAddSerial.Size = new System.Drawing.Size(43, 25);
            this.btnAddSerial.TabIndex = 281;
            this.btnAddSerial.Text = "+";
            this.btnAddSerial.UseVisualStyleBackColor = false;
            this.btnAddSerial.Click += new System.EventHandler(this.btnAddSerial_Click);
            // 
            // dgvLoadSerialNo
            // 
            this.dgvLoadSerialNo.AllowUserToAddRows = false;
            this.dgvLoadSerialNo.AllowUserToDeleteRows = false;
            this.dgvLoadSerialNo.AllowUserToOrderColumns = true;
            this.dgvLoadSerialNo.AllowUserToResizeColumns = false;
            this.dgvLoadSerialNo.AllowUserToResizeRows = false;
            this.dgvLoadSerialNo.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoadSerialNo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLoadSerialNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLoadSerialNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoadSerialNo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLoadSerialNo.Location = new System.Drawing.Point(6, 379);
            this.dgvLoadSerialNo.MultiSelect = false;
            this.dgvLoadSerialNo.Name = "dgvLoadSerialNo";
            this.dgvLoadSerialNo.RowHeadersVisible = false;
            this.dgvLoadSerialNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadSerialNo.Size = new System.Drawing.Size(183, 253);
            this.dgvLoadSerialNo.TabIndex = 280;
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(171, 700);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(84, 24);
            this.txtItemID.TabIndex = 224;
            this.txtItemID.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(806, 39);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(295, 24);
            this.txtRemarks.TabIndex = 260;
            // 
            // frmIssueReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1322, 766);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.grpItemSerialNo);
            this.isEnterTabAllow = true;
            this.Name = "frmIssueReturn";
            this.Load += new System.EventHandler(this.frmIssueReturn_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.grpItemSerialNo, 0);
            this.Controls.SetChildIndex(this.txtItemID, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpIssueDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerialNo)).EndInit();
            this.grpItemSerialNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadSerialNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartLabel txtIssueDate;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel txtIssueTypeName;
        private AtiqsControlLibrary.SmartLabel txtIssueType;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel txtStoreID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel txtStoreName;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtReturnID;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtReturnCause;
        private AtiqsControlLibrary.SmartTextBox txtReturnFrom;
        private AtiqsControlLibrary.SmartTextBox txtReturnType;
        private System.Windows.Forms.DateTimePicker txtRetDate;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtIssueID;
        private System.Windows.Forms.GroupBox grpIssueDetails;
        private AtiqsControlLibrary.SmartDataGridView dgvIssueDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartDataGridView dgvIssueReturn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartLabel txtBatchID;
        private AtiqsControlLibrary.SmartDataGridView dgvSerialNo;
        private System.Windows.Forms.GroupBox grpItemSerialNo;
        private AtiqsControlLibrary.SmartTextBox txtItemID;
        private System.Windows.Forms.Button btnAddSerial;
        private AtiqsControlLibrary.SmartDataGridView dgvLoadSerialNo;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
    }
}
