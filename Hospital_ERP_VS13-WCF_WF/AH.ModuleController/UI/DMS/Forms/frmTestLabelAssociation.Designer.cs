namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmTestLabelAssociation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboGroupID = new AtiqsControlLibrary.SmartComboBox();
            this.cboMainID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.btnAddTestDet = new System.Windows.Forms.Button();
            this.cboTestDet = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRefreshTestDet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAssociatedTestDetails = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvTestDetails = new AtiqsControlLibrary.SmartDataGridView();
            this.cboLabelGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtTestDetails = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.btnNewClose = new System.Windows.Forms.Button();
            this.txtSearchTest = new AtiqsControlLibrary.SmartTextBox();
            this.chkTestList = new AtiqsControlLibrary.SmartCheckBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedTestDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(458, 9);
            this.frmLabel.Size = new System.Drawing.Size(391, 33);
            this.frmLabel.Text = "Test Mapping For Label Printing";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.chkTestList);
            this.pnlMain.Controls.Add(this.txtSearchTest);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtTestDetails);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboLabelGroup);
            this.pnlMain.Controls.Add(this.dgvAssociatedTestDetails);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.dgvTestDetails);
            this.pnlMain.Controls.Add(this.btnRefreshTestDet);
            this.pnlMain.Controls.Add(this.btnAddTestDet);
            this.pnlMain.Controls.Add(this.cboTestDet);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.cboGroupID);
            this.pnlMain.Controls.Add(this.cboMainID);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboDeptID);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Size = new System.Drawing.Size(1335, 796);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1338, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(111, 715);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1112, 715);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(224, 715);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(998, 715);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(16, 715);
            this.btnClose.Size = new System.Drawing.Size(29, 39);
            this.btnClose.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(335, 715);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 755);
            this.groupBox1.Size = new System.Drawing.Size(1338, 25);
            // 
            // cboGroupID
            // 
            this.cboGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupID.ForeColor = System.Drawing.Color.Blue;
            this.cboGroupID.FormattingEnabled = true;
            this.cboGroupID.Location = new System.Drawing.Point(251, 175);
            this.cboGroupID.Name = "cboGroupID";
            this.cboGroupID.Size = new System.Drawing.Size(227, 26);
            this.cboGroupID.TabIndex = 101;
            // 
            // cboMainID
            // 
            this.cboMainID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMainID.ForeColor = System.Drawing.Color.Blue;
            this.cboMainID.FormattingEnabled = true;
            this.cboMainID.Location = new System.Drawing.Point(485, 175);
            this.cboMainID.Name = "cboMainID";
            this.cboMainID.Size = new System.Drawing.Size(284, 26);
            this.cboMainID.TabIndex = 102;
            this.cboMainID.SelectedIndexChanged += new System.EventHandler(this.cboMainID_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(482, 155);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(75, 18);
            this.smartLabel4.TabIndex = 103;
            this.smartLabel4.Text = "Test Main :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(251, 155);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(53, 18);
            this.smartLabel6.TabIndex = 104;
            this.smartLabel6.Text = "Group :";
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(12, 175);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(233, 26);
            this.cboDeptID.TabIndex = 100;
            this.cboDeptID.SelectedIndexChanged += new System.EventHandler(this.cboDeptID_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(12, 155);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(87, 18);
            this.smartLabel7.TabIndex = 105;
            this.smartLabel7.Text = "Department :";
            // 
            // btnAddTestDet
            // 
            this.btnAddTestDet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddTestDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTestDet.Enabled = false;
            this.btnAddTestDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTestDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTestDet.ForeColor = System.Drawing.Color.White;
            this.btnAddTestDet.Location = new System.Drawing.Point(1190, 175);
            this.btnAddTestDet.Name = "btnAddTestDet";
            this.btnAddTestDet.Size = new System.Drawing.Size(32, 26);
            this.btnAddTestDet.TabIndex = 147;
            this.btnAddTestDet.TabStop = false;
            this.btnAddTestDet.Text = "+";
            this.btnAddTestDet.UseVisualStyleBackColor = false;
            // 
            // cboTestDet
            // 
            this.cboTestDet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTestDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTestDet.ForeColor = System.Drawing.Color.Blue;
            this.cboTestDet.FormattingEnabled = true;
            this.cboTestDet.Location = new System.Drawing.Point(777, 175);
            this.cboTestDet.Name = "cboTestDet";
            this.cboTestDet.Size = new System.Drawing.Size(411, 26);
            this.cboTestDet.TabIndex = 145;
            this.cboTestDet.SelectedIndexChanged += new System.EventHandler(this.cboTestDet_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(777, 155);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 18);
            this.smartLabel1.TabIndex = 146;
            this.smartLabel1.Text = "Test Details :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(1260, 175);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(65, 26);
            this.btnShow.TabIndex = 144;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show Result Head";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRefreshTestDet
            // 
            this.btnRefreshTestDet.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshTestDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshTestDet.Enabled = false;
            this.btnRefreshTestDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTestDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTestDet.ForeColor = System.Drawing.Color.White;
            this.btnRefreshTestDet.Location = new System.Drawing.Point(1225, 175);
            this.btnRefreshTestDet.Name = "btnRefreshTestDet";
            this.btnRefreshTestDet.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshTestDet.TabIndex = 148;
            this.btnRefreshTestDet.TabStop = false;
            this.btnRefreshTestDet.Text = "..";
            this.btnRefreshTestDet.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(575, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 528);
            this.panel2.TabIndex = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(7, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAssociatedTestDetails
            // 
            this.dgvAssociatedTestDetails.AllowUserToAddRows = false;
            this.dgvAssociatedTestDetails.AllowUserToDeleteRows = false;
            this.dgvAssociatedTestDetails.AllowUserToOrderColumns = true;
            this.dgvAssociatedTestDetails.AllowUserToResizeColumns = false;
            this.dgvAssociatedTestDetails.AllowUserToResizeRows = false;
            this.dgvAssociatedTestDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssociatedTestDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAssociatedTestDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssociatedTestDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociatedTestDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssociatedTestDetails.Location = new System.Drawing.Point(661, 263);
            this.dgvAssociatedTestDetails.MultiSelect = false;
            this.dgvAssociatedTestDetails.Name = "dgvAssociatedTestDetails";
            this.dgvAssociatedTestDetails.RowHeadersVisible = false;
            this.dgvAssociatedTestDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedTestDetails.Size = new System.Drawing.Size(664, 528);
            this.dgvAssociatedTestDetails.TabIndex = 151;
            this.dgvAssociatedTestDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociatedTestDetails_CellClick);
            this.dgvAssociatedTestDetails.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAssociatedTestDetails_CellValidating);
            // 
            // dgvTestDetails
            // 
            this.dgvTestDetails.AllowUserToAddRows = false;
            this.dgvTestDetails.AllowUserToDeleteRows = false;
            this.dgvTestDetails.AllowUserToOrderColumns = true;
            this.dgvTestDetails.AllowUserToResizeColumns = false;
            this.dgvTestDetails.AllowUserToResizeRows = false;
            this.dgvTestDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTestDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTestDetails.Location = new System.Drawing.Point(12, 263);
            this.dgvTestDetails.MultiSelect = false;
            this.dgvTestDetails.Name = "dgvTestDetails";
            this.dgvTestDetails.RowHeadersVisible = false;
            this.dgvTestDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestDetails.Size = new System.Drawing.Size(557, 528);
            this.dgvTestDetails.TabIndex = 149;
            // 
            // cboLabelGroup
            // 
            this.cboLabelGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLabelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLabelGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboLabelGroup.FormattingEnabled = true;
            this.cboLabelGroup.Location = new System.Drawing.Point(485, 233);
            this.cboLabelGroup.Name = "cboLabelGroup";
            this.cboLabelGroup.Size = new System.Drawing.Size(87, 26);
            this.cboLabelGroup.TabIndex = 152;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(482, 212);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(90, 18);
            this.smartLabel2.TabIndex = 153;
            this.smartLabel2.Text = "Label Group :";
            // 
            // txtTestDetails
            // 
            this.txtTestDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestDetails.Location = new System.Drawing.Point(102, 233);
            this.txtTestDetails.Name = "txtTestDetails";
            this.txtTestDetails.Size = new System.Drawing.Size(376, 24);
            this.txtTestDetails.TabIndex = 154;
            this.txtTestDetails.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTestDetails_KeyUp);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(99, 212);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(124, 18);
            this.smartLabel3.TabIndex = 155;
            this.smartLabel3.Text = "Search Test Name :";
            // 
            // btnNewClose
            // 
            this.btnNewClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnNewClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClose.ForeColor = System.Drawing.Color.Navy;
            this.btnNewClose.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNewClose.ImageIndex = 5;
            this.btnNewClose.Location = new System.Drawing.Point(1226, 715);
            this.btnNewClose.Name = "btnNewClose";
            this.btnNewClose.Size = new System.Drawing.Size(108, 39);
            this.btnNewClose.TabIndex = 16;
            this.btnNewClose.Text = "Close";
            this.btnNewClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewClose.UseVisualStyleBackColor = false;
            this.btnNewClose.Click += new System.EventHandler(this.btnNewClose_Click);
            // 
            // txtSearchTest
            // 
            this.txtSearchTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTest.Location = new System.Drawing.Point(869, 149);
            this.txtSearchTest.Name = "txtSearchTest";
            this.txtSearchTest.Size = new System.Drawing.Size(319, 24);
            this.txtSearchTest.TabIndex = 156;
            this.txtSearchTest.TextChanged += new System.EventHandler(this.txtSearchTest_TextChanged);
            // 
            // chkTestList
            // 
            this.chkTestList.AutoSize = true;
            this.chkTestList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTestList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTestList.ForeColor = System.Drawing.Color.Black;
            this.chkTestList.Location = new System.Drawing.Point(12, 232);
            this.chkTestList.Name = "chkTestList";
            this.chkTestList.Size = new System.Drawing.Size(84, 22);
            this.chkTestList.TabIndex = 157;
            this.chkTestList.Text = "Select All";
            this.chkTestList.UseVisualStyleBackColor = true;
            this.chkTestList.CheckedChanged += new System.EventHandler(this.chkTestList_CheckedChanged);
            // 
            // frmTestLabelAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1338, 780);
            this.Controls.Add(this.btnNewClose);
            this.isEnterTabAllow = true;
            this.Name = "frmTestLabelAssociation";
            this.Load += new System.EventHandler(this.frmTestLabelAssociation_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnNewClose, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedTestDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboGroupID;
        private AtiqsControlLibrary.SmartComboBox cboMainID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.Button btnAddTestDet;
        private AtiqsControlLibrary.SmartComboBox cboTestDet;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRefreshTestDet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartDataGridView dgvAssociatedTestDetails;
        private AtiqsControlLibrary.SmartDataGridView dgvTestDetails;
        private AtiqsControlLibrary.SmartComboBox cboLabelGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtTestDetails;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        public System.Windows.Forms.Button btnNewClose;
        private AtiqsControlLibrary.SmartTextBox txtSearchTest;
        private AtiqsControlLibrary.SmartCheckBox chkTestList;
    }
}
