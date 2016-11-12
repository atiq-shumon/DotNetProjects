namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmOranogramSetup
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
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvInitialGrid = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvAssociatedGrid = new AtiqsControlLibrary.SmartDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearchDesig = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshDesig = new System.Windows.Forms.Button();
            this.btnAddDesig = new System.Windows.Forms.Button();
            this.btnRefreshDept = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.btnRefreshUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(471, 9);
            this.frmLabel.Size = new System.Drawing.Size(241, 33);
            this.frmLabel.Text = "Organogram Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.btnRefreshUnit);
            this.pnlMain.Controls.Add(this.btnAddUnit);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.btnRefreshDept);
            this.pnlMain.Controls.Add(this.btnAddDept);
            this.pnlMain.Controls.Add(this.btnRefreshDesig);
            this.pnlMain.Controls.Add(this.btnAddDesig);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtSearchDesig);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.dgvAssociatedGrid);
            this.pnlMain.Controls.Add(this.dgvInitialGrid);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.cboDepartmentGroup);
            this.pnlMain.Controls.Add(this.smartLabel22);
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.smartLabel21);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Size = new System.Drawing.Size(1207, 871);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1207, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(214, 790);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(979, 790);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(296, 790);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(866, 790);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1092, 790);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(407, 790);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 829);
            this.groupBox1.Size = new System.Drawing.Size(1207, 25);
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(181, 172);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(229, 26);
            this.cboDepartmentGroup.TabIndex = 1;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(180, 154);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(118, 13);
            this.smartLabel22.TabIndex = 114;
            this.smartLabel22.Text = "Department Group :";
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(5, 172);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(170, 26);
            this.cboDepartmentType.TabIndex = 0;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(5, 154);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(112, 13);
            this.smartLabel21.TabIndex = 113;
            this.smartLabel21.Text = "Department Type :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(416, 172);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(219, 26);
            this.cboDepartment.TabIndex = 2;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(413, 154);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(80, 13);
            this.smartLabel2.TabIndex = 111;
            this.smartLabel2.Text = "Department :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(1014, 169);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(69, 27);
            this.btnShow.TabIndex = 199;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvInitialGrid
            // 
            this.dgvInitialGrid.AllowUserToAddRows = false;
            this.dgvInitialGrid.AllowUserToDeleteRows = false;
            this.dgvInitialGrid.AllowUserToOrderColumns = true;
            this.dgvInitialGrid.AllowUserToResizeColumns = false;
            this.dgvInitialGrid.AllowUserToResizeRows = false;
            this.dgvInitialGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvInitialGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvInitialGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInitialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInitialGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInitialGrid.Location = new System.Drawing.Point(1, 270);
            this.dgvInitialGrid.MultiSelect = false;
            this.dgvInitialGrid.Name = "dgvInitialGrid";
            this.dgvInitialGrid.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvInitialGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInitialGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInitialGrid.Size = new System.Drawing.Size(558, 600);
            this.dgvInitialGrid.TabIndex = 200;
            // 
            // dgvAssociatedGrid
            // 
            this.dgvAssociatedGrid.AllowUserToAddRows = false;
            this.dgvAssociatedGrid.AllowUserToDeleteRows = false;
            this.dgvAssociatedGrid.AllowUserToOrderColumns = true;
            this.dgvAssociatedGrid.AllowUserToResizeColumns = false;
            this.dgvAssociatedGrid.AllowUserToResizeRows = false;
            this.dgvAssociatedGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssociatedGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAssociatedGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAssociatedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociatedGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAssociatedGrid.Location = new System.Drawing.Point(640, 270);
            this.dgvAssociatedGrid.MultiSelect = false;
            this.dgvAssociatedGrid.Name = "dgvAssociatedGrid";
            this.dgvAssociatedGrid.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvAssociatedGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAssociatedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedGrid.Size = new System.Drawing.Size(566, 600);
            this.dgvAssociatedGrid.TabIndex = 201;
            this.dgvAssociatedGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociatedGrid_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(561, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 600);
            this.panel2.TabIndex = 202;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(4, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearchDesig
            // 
            this.txtSearchDesig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDesig.Location = new System.Drawing.Point(5, 231);
            this.txtSearchDesig.Name = "txtSearchDesig";
            this.txtSearchDesig.Size = new System.Drawing.Size(630, 24);
            this.txtSearchDesig.TabIndex = 203;
            this.txtSearchDesig.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchDesig_KeyUp);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(5, 211);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(126, 13);
            this.smartLabel1.TabIndex = 204;
            this.smartLabel1.Text = "Search Designation :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(716, 231);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(483, 24);
            this.txtRemarks.TabIndex = 205;
            this.txtRemarks.Text = "N/A";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(713, 215);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(64, 13);
            this.smartLabel3.TabIndex = 206;
            this.smartLabel3.Text = "Remarks :";
            // 
            // btnRefreshDesig
            // 
            this.btnRefreshDesig.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshDesig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshDesig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDesig.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDesig.Location = new System.Drawing.Point(680, 231);
            this.btnRefreshDesig.Name = "btnRefreshDesig";
            this.btnRefreshDesig.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshDesig.TabIndex = 208;
            this.btnRefreshDesig.TabStop = false;
            this.btnRefreshDesig.Text = "..";
            this.btnRefreshDesig.UseVisualStyleBackColor = false;
            this.btnRefreshDesig.Click += new System.EventHandler(this.btnRefreshDesig_Click);
            // 
            // btnAddDesig
            // 
            this.btnAddDesig.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDesig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDesig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDesig.ForeColor = System.Drawing.Color.White;
            this.btnAddDesig.Location = new System.Drawing.Point(641, 231);
            this.btnAddDesig.Name = "btnAddDesig";
            this.btnAddDesig.Size = new System.Drawing.Size(35, 26);
            this.btnAddDesig.TabIndex = 207;
            this.btnAddDesig.TabStop = false;
            this.btnAddDesig.Text = "+";
            this.btnAddDesig.UseVisualStyleBackColor = false;
            this.btnAddDesig.Click += new System.EventHandler(this.btnAddDesig_Click);
            // 
            // btnRefreshDept
            // 
            this.btnRefreshDept.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDept.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDept.Location = new System.Drawing.Point(680, 171);
            this.btnRefreshDept.Name = "btnRefreshDept";
            this.btnRefreshDept.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshDept.TabIndex = 210;
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
            this.btnAddDept.Location = new System.Drawing.Point(641, 171);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(35, 26);
            this.btnAddDept.TabIndex = 209;
            this.btnAddDept.TabStop = false;
            this.btnAddDept.Text = "+";
            this.btnAddDept.UseVisualStyleBackColor = false;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnRefreshUnit
            // 
            this.btnRefreshUnit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUnit.ForeColor = System.Drawing.Color.White;
            this.btnRefreshUnit.Location = new System.Drawing.Point(978, 170);
            this.btnRefreshUnit.Name = "btnRefreshUnit";
            this.btnRefreshUnit.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshUnit.TabIndex = 214;
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
            this.btnAddUnit.Location = new System.Drawing.Point(939, 170);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(35, 26);
            this.btnAddUnit.TabIndex = 213;
            this.btnAddUnit.TabStop = false;
            this.btnAddUnit.Text = "+";
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(716, 171);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(219, 26);
            this.cboUnit.TabIndex = 3;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(716, 153);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(38, 13);
            this.smartLabel4.TabIndex = 212;
            this.smartLabel4.Text = "Unit :";
            // 
            // frmOranogramSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1207, 854);
            this.isEnterTabAllow = true;
            this.Name = "frmOranogramSetup";
            this.Load += new System.EventHandler(this.frmOranogramSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartDataGridView dgvInitialGrid;
        private AtiqsControlLibrary.SmartDataGridView dgvAssociatedGrid;
        private AtiqsControlLibrary.SmartTextBox txtSearchDesig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.Button btnRefreshDesig;
        private System.Windows.Forms.Button btnAddDesig;
        private System.Windows.Forms.Button btnRefreshDept;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnRefreshUnit;
        private System.Windows.Forms.Button btnAddUnit;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
    }
}
