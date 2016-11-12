namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmAssignOrganogram
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvDepartment = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvUnit = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvAssociatedGrid = new AtiqsControlLibrary.SmartDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefreshDeptGrp = new System.Windows.Forms.Button();
            this.btnAddDeptGrp = new System.Windows.Forms.Button();
            this.txtSearchDept = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshDept = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.txtSearchUnit = new AtiqsControlLibrary.SmartTextBox();
            this.btnRefreshUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowUnit = new System.Windows.Forms.Button();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(453, 9);
            this.frmLabel.Size = new System.Drawing.Size(296, 33);
            this.frmLabel.Text = "Department Unit Assign";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.btnShowUnit);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.button2);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.btnRefreshUnit);
            this.pnlMain.Controls.Add(this.btnAddUnit);
            this.pnlMain.Controls.Add(this.txtSearchUnit);
            this.pnlMain.Controls.Add(this.btnRefreshDept);
            this.pnlMain.Controls.Add(this.btnAddDept);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtSearchDept);
            this.pnlMain.Controls.Add(this.btnRefreshDeptGrp);
            this.pnlMain.Controls.Add(this.btnAddDeptGrp);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.dgvAssociatedGrid);
            this.pnlMain.Controls.Add(this.dgvUnit);
            this.pnlMain.Controls.Add(this.dgvDepartment);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.cboDepartmentGroup);
            this.pnlMain.Controls.Add(this.smartLabel22);
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.smartLabel21);
            this.pnlMain.Size = new System.Drawing.Size(1219, 877);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1219, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(30, 796);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(992, 796);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(143, 796);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(879, 796);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1106, 796);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(254, 796);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 835);
            this.groupBox1.Size = new System.Drawing.Size(1219, 25);
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(344, 174);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(286, 26);
            this.cboDepartmentGroup.TabIndex = 1;
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(343, 156);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(118, 13);
            this.smartLabel22.TabIndex = 120;
            this.smartLabel22.Text = "Department Group :";
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(8, 174);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(256, 26);
            this.cboDepartmentType.TabIndex = 0;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(8, 156);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(112, 13);
            this.smartLabel21.TabIndex = 119;
            this.smartLabel21.Text = "Department Type :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(707, 174);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(87, 27);
            this.btnShow.TabIndex = 200;
            this.btnShow.Text = "Show All";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.AllowUserToOrderColumns = true;
            this.dgvDepartment.AllowUserToResizeColumns = false;
            this.dgvDepartment.AllowUserToResizeRows = false;
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartment.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDepartment.Location = new System.Drawing.Point(-1, 257);
            this.dgvDepartment.MultiSelect = false;
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.RowHeadersVisible = false;
            this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartment.Size = new System.Drawing.Size(339, 619);
            this.dgvDepartment.TabIndex = 201;
            // 
            // dgvUnit
            // 
            this.dgvUnit.AllowUserToAddRows = false;
            this.dgvUnit.AllowUserToDeleteRows = false;
            this.dgvUnit.AllowUserToOrderColumns = true;
            this.dgvUnit.AllowUserToResizeColumns = false;
            this.dgvUnit.AllowUserToResizeRows = false;
            this.dgvUnit.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnit.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUnit.Location = new System.Drawing.Point(344, 257);
            this.dgvUnit.MultiSelect = false;
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.RowHeadersVisible = false;
            this.dgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnit.Size = new System.Drawing.Size(360, 619);
            this.dgvUnit.TabIndex = 202;
            // 
            // dgvAssociatedGrid
            // 
            this.dgvAssociatedGrid.AllowUserToAddRows = false;
            this.dgvAssociatedGrid.AllowUserToDeleteRows = false;
            this.dgvAssociatedGrid.AllowUserToOrderColumns = true;
            this.dgvAssociatedGrid.AllowUserToResizeColumns = false;
            this.dgvAssociatedGrid.AllowUserToResizeRows = false;
            this.dgvAssociatedGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssociatedGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAssociatedGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAssociatedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociatedGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAssociatedGrid.Location = new System.Drawing.Point(747, 257);
            this.dgvAssociatedGrid.MultiSelect = false;
            this.dgvAssociatedGrid.Name = "dgvAssociatedGrid";
            this.dgvAssociatedGrid.RowHeadersVisible = false;
            this.dgvAssociatedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedGrid.Size = new System.Drawing.Size(471, 619);
            this.dgvAssociatedGrid.TabIndex = 203;
            this.dgvAssociatedGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociatedGrid_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(707, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 615);
            this.panel2.TabIndex = 204;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(-1, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 28);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefreshDeptGrp
            // 
            this.btnRefreshDeptGrp.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshDeptGrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshDeptGrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDeptGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDeptGrp.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDeptGrp.Location = new System.Drawing.Point(675, 174);
            this.btnRefreshDeptGrp.Name = "btnRefreshDeptGrp";
            this.btnRefreshDeptGrp.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshDeptGrp.TabIndex = 210;
            this.btnRefreshDeptGrp.TabStop = false;
            this.btnRefreshDeptGrp.Text = "..";
            this.btnRefreshDeptGrp.UseVisualStyleBackColor = false;
            this.btnRefreshDeptGrp.Click += new System.EventHandler(this.btnRefreshDeptGrp_Click);
            // 
            // btnAddDeptGrp
            // 
            this.btnAddDeptGrp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDeptGrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDeptGrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeptGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDeptGrp.ForeColor = System.Drawing.Color.White;
            this.btnAddDeptGrp.Location = new System.Drawing.Point(636, 174);
            this.btnAddDeptGrp.Name = "btnAddDeptGrp";
            this.btnAddDeptGrp.Size = new System.Drawing.Size(35, 26);
            this.btnAddDeptGrp.TabIndex = 209;
            this.btnAddDeptGrp.TabStop = false;
            this.btnAddDeptGrp.Text = "+";
            this.btnAddDeptGrp.UseVisualStyleBackColor = false;
            this.btnAddDeptGrp.Click += new System.EventHandler(this.btnAddDeptGrp_Click);
            // 
            // txtSearchDept
            // 
            this.txtSearchDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDept.Location = new System.Drawing.Point(8, 225);
            this.txtSearchDept.Name = "txtSearchDept";
            this.txtSearchDept.Size = new System.Drawing.Size(256, 24);
            this.txtSearchDept.TabIndex = 211;
            this.txtSearchDept.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchDept_KeyUp);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(8, 209);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(124, 13);
            this.smartLabel1.TabIndex = 212;
            this.smartLabel1.Text = "Search Department :";
            // 
            // btnRefreshDept
            // 
            this.btnRefreshDept.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDept.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDept.Location = new System.Drawing.Point(308, 225);
            this.btnRefreshDept.Name = "btnRefreshDept";
            this.btnRefreshDept.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshDept.TabIndex = 214;
            this.btnRefreshDept.TabStop = false;
            this.btnRefreshDept.Text = "..";
            this.btnRefreshDept.UseVisualStyleBackColor = false;
            this.btnRefreshDept.Click += new System.EventHandler(this.btnRefreshDept_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDept.ForeColor = System.Drawing.Color.White;
            this.btnAddDept.Location = new System.Drawing.Point(270, 225);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(35, 26);
            this.btnAddDept.TabIndex = 213;
            this.btnAddDept.TabStop = false;
            this.btnAddDept.Text = "+";
            this.btnAddDept.UseVisualStyleBackColor = false;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // txtSearchUnit
            // 
            this.txtSearchUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUnit.Location = new System.Drawing.Point(344, 225);
            this.txtSearchUnit.Name = "txtSearchUnit";
            this.txtSearchUnit.Size = new System.Drawing.Size(286, 24);
            this.txtSearchUnit.TabIndex = 215;
            this.txtSearchUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchUnit_KeyUp);
            // 
            // btnRefreshUnit
            // 
            this.btnRefreshUnit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUnit.ForeColor = System.Drawing.Color.White;
            this.btnRefreshUnit.Location = new System.Drawing.Point(673, 225);
            this.btnRefreshUnit.Name = "btnRefreshUnit";
            this.btnRefreshUnit.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshUnit.TabIndex = 217;
            this.btnRefreshUnit.TabStop = false;
            this.btnRefreshUnit.Text = "..";
            this.btnRefreshUnit.UseVisualStyleBackColor = false;
            this.btnRefreshUnit.Click += new System.EventHandler(this.btnRefreshUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnit.ForeColor = System.Drawing.Color.White;
            this.btnAddUnit.Location = new System.Drawing.Point(636, 225);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(35, 26);
            this.btnAddUnit.TabIndex = 216;
            this.btnAddUnit.TabStop = false;
            this.btnAddUnit.Text = "+";
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(341, 209);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(82, 13);
            this.smartLabel2.TabIndex = 218;
            this.smartLabel2.Text = "Search Unit :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(307, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 26);
            this.button1.TabIndex = 220;
            this.button1.TabStop = false;
            this.button1.Text = "..";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(269, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 26);
            this.button2.TabIndex = 219;
            this.button2.TabStop = false;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnShowUnit
            // 
            this.btnShowUnit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUnit.ForeColor = System.Drawing.Color.White;
            this.btnShowUnit.Location = new System.Drawing.Point(1147, 174);
            this.btnShowUnit.Name = "btnShowUnit";
            this.btnShowUnit.Size = new System.Drawing.Size(66, 27);
            this.btnShowUnit.TabIndex = 221;
            this.btnShowUnit.Text = "Show";
            this.btnShowUnit.UseVisualStyleBackColor = false;
            this.btnShowUnit.Click += new System.EventHandler(this.btnShowUnit_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(800, 174);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(341, 26);
            this.cboDepartment.TabIndex = 2;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(797, 156);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(80, 13);
            this.smartLabel3.TabIndex = 223;
            this.smartLabel3.Text = "Department :";
            // 
            // frmAssignOrganogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1219, 860);
            this.isEnterTabAllow = true;
            this.Name = "frmAssignOrganogram";
            this.Load += new System.EventHandler(this.frmAssignOrganogram_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartDataGridView dgvDepartment;
        private AtiqsControlLibrary.SmartDataGridView dgvUnit;
        private AtiqsControlLibrary.SmartDataGridView dgvAssociatedGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefreshDeptGrp;
        private System.Windows.Forms.Button btnAddDeptGrp;
        private AtiqsControlLibrary.SmartTextBox txtSearchDept;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Button btnRefreshDept;
        private System.Windows.Forms.Button btnAddDept;
        private AtiqsControlLibrary.SmartTextBox txtSearchUnit;
        private System.Windows.Forms.Button btnRefreshUnit;
        private System.Windows.Forms.Button btnAddUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowUnit;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
    }
}
