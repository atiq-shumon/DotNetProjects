namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmRosterDutySetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvInitialGrid = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvAssociatedGrid = new AtiqsControlLibrary.SmartDataGridView();
            this.cboMonth = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboShift = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtSearchText = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshShiftTiming = new System.Windows.Forms.Button();
            this.btnAddShiftTiming = new System.Windows.Forms.Button();
            this.btnAddRoster = new System.Windows.Forms.Button();
            this.gbSelectOptions = new System.Windows.Forms.GroupBox();
            this.rdoGrpDeptUnit = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptGrp = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAll = new AtiqsControlLibrary.SmartRadioButton();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.chkList = new AtiqsControlLibrary.SmartCheckBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbSelectOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(620, 8);
            this.frmLabel.Size = new System.Drawing.Size(231, 33);
            this.frmLabel.Text = "Roster Duty Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.chkList);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.gbSelectOptions);
            this.pnlMain.Controls.Add(this.btnAddRoster);
            this.pnlMain.Controls.Add(this.btnRefreshShiftTiming);
            this.pnlMain.Controls.Add(this.btnAddShiftTiming);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboShift);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboYear);
            this.pnlMain.Controls.Add(this.cboDepartmentGroup);
            this.pnlMain.Controls.Add(this.smartLabel22);
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.smartLabel21);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboMonth);
            this.pnlMain.Controls.Add(this.dgvAssociatedGrid);
            this.pnlMain.Controls.Add(this.dgvInitialGrid);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Size = new System.Drawing.Size(1469, 913);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1469, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(21, 832);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1241, 832);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(134, 832);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1128, 832);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1355, 832);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(245, 832);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 871);
            this.groupBox1.Size = new System.Drawing.Size(1469, 25);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(388, 207);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(172, 26);
            this.cboDepartment.TabIndex = 2;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(385, 187);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(80, 13);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Department :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(561, 187);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(38, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Unit :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(564, 207);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(167, 26);
            this.cboUnit.TabIndex = 3;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(1401, 205);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(57, 28);
            this.btnShow.TabIndex = 9;
            this.btnShow.TabStop = false;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvInitialGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInitialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInitialGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInitialGrid.Location = new System.Drawing.Point(3, 238);
            this.dgvInitialGrid.MultiSelect = false;
            this.dgvInitialGrid.Name = "dgvInitialGrid";
            this.dgvInitialGrid.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvInitialGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInitialGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInitialGrid.Size = new System.Drawing.Size(648, 670);
            this.dgvInitialGrid.TabIndex = 79;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAssociatedGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAssociatedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociatedGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAssociatedGrid.Location = new System.Drawing.Point(730, 239);
            this.dgvAssociatedGrid.MultiSelect = false;
            this.dgvAssociatedGrid.Name = "dgvAssociatedGrid";
            this.dgvAssociatedGrid.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvAssociatedGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAssociatedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedGrid.Size = new System.Drawing.Size(738, 669);
            this.dgvAssociatedGrid.TabIndex = 80;
            this.dgvAssociatedGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociatedGrid_CellClick);
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.ForeColor = System.Drawing.Color.Blue;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(826, 207);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(103, 26);
            this.cboMonth.TabIndex = 5;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(826, 187);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(50, 13);
            this.smartLabel3.TabIndex = 82;
            this.smartLabel3.Text = "Month :";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(938, 207);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(105, 26);
            this.dtStartDate.TabIndex = 6;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(935, 187);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(73, 13);
            this.smartLabel4.TabIndex = 84;
            this.smartLabel4.Text = "Start Date :";
            // 
            // cboShift
            // 
            this.cboShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShift.ForeColor = System.Drawing.Color.Blue;
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Location = new System.Drawing.Point(1161, 207);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(188, 26);
            this.cboShift.TabIndex = 7;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(1161, 187);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(71, 13);
            this.smartLabel5.TabIndex = 86;
            this.smartLabel5.Text = "Duty Shift :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(654, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 669);
            this.panel2.TabIndex = 151;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(13, 207);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(181, 26);
            this.cboDepartmentType.TabIndex = 0;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(13, 187);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(112, 13);
            this.smartLabel21.TabIndex = 153;
            this.smartLabel21.Text = "Department Type :";
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(200, 207);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(184, 26);
            this.cboDepartmentGroup.TabIndex = 1;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(197, 187);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(118, 13);
            this.smartLabel22.TabIndex = 155;
            this.smartLabel22.Text = "Department Group :";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(736, 207);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(86, 26);
            this.cboYear.TabIndex = 4;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(736, 187);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(41, 13);
            this.smartLabel6.TabIndex = 157;
            this.smartLabel6.Text = "Year :";
            // 
            // txtSearchText
            // 
            this.txtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(374, 841);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(358, 24);
            this.txtSearchText.TabIndex = 158;
            this.txtSearchText.Visible = false;
            this.txtSearchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchText_KeyUp);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(38, 832);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(149, 13);
            this.smartLabel7.TabIndex = 159;
            this.smartLabel7.Text = "Search Employee Name :";
            this.smartLabel7.Visible = false;
            // 
            // btnRefreshShiftTiming
            // 
            this.btnRefreshShiftTiming.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshShiftTiming.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshShiftTiming.Enabled = false;
            this.btnRefreshShiftTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshShiftTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshShiftTiming.ForeColor = System.Drawing.Color.White;
            this.btnRefreshShiftTiming.Location = new System.Drawing.Point(1319, 205);
            this.btnRefreshShiftTiming.Name = "btnRefreshShiftTiming";
            this.btnRefreshShiftTiming.Size = new System.Drawing.Size(30, 28);
            this.btnRefreshShiftTiming.TabIndex = 210;
            this.btnRefreshShiftTiming.TabStop = false;
            this.btnRefreshShiftTiming.Text = "..";
            this.btnRefreshShiftTiming.UseVisualStyleBackColor = false;
            this.btnRefreshShiftTiming.Visible = false;
            this.btnRefreshShiftTiming.Click += new System.EventHandler(this.btnRefreshShiftTiming_Click);
            // 
            // btnAddShiftTiming
            // 
            this.btnAddShiftTiming.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddShiftTiming.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddShiftTiming.Enabled = false;
            this.btnAddShiftTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShiftTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShiftTiming.ForeColor = System.Drawing.Color.White;
            this.btnAddShiftTiming.Location = new System.Drawing.Point(1285, 205);
            this.btnAddShiftTiming.Name = "btnAddShiftTiming";
            this.btnAddShiftTiming.Size = new System.Drawing.Size(32, 28);
            this.btnAddShiftTiming.TabIndex = 209;
            this.btnAddShiftTiming.TabStop = false;
            this.btnAddShiftTiming.Text = "+";
            this.btnAddShiftTiming.UseVisualStyleBackColor = false;
            this.btnAddShiftTiming.Visible = false;
            this.btnAddShiftTiming.Click += new System.EventHandler(this.btnAddShiftTiming_Click);
            // 
            // btnAddRoster
            // 
            this.btnAddRoster.BackColor = System.Drawing.Color.Olive;
            this.btnAddRoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoster.ForeColor = System.Drawing.Color.White;
            this.btnAddRoster.Location = new System.Drawing.Point(1352, 205);
            this.btnAddRoster.Name = "btnAddRoster";
            this.btnAddRoster.Size = new System.Drawing.Size(47, 28);
            this.btnAddRoster.TabIndex = 8;
            this.btnAddRoster.TabStop = false;
            this.btnAddRoster.Text = "Add";
            this.btnAddRoster.UseVisualStyleBackColor = false;
            this.btnAddRoster.Click += new System.EventHandler(this.btnAddRoster_Click);
            // 
            // gbSelectOptions
            // 
            this.gbSelectOptions.Controls.Add(this.rdoGrpDeptUnit);
            this.gbSelectOptions.Controls.Add(this.rdoDeptGrp);
            this.gbSelectOptions.Controls.Add(this.rdoAll);
            this.gbSelectOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbSelectOptions.Location = new System.Drawing.Point(12, 140);
            this.gbSelectOptions.Name = "gbSelectOptions";
            this.gbSelectOptions.Size = new System.Drawing.Size(511, 44);
            this.gbSelectOptions.TabIndex = 230;
            this.gbSelectOptions.TabStop = false;
            // 
            // rdoGrpDeptUnit
            // 
            this.rdoGrpDeptUnit.AutoSize = true;
            this.rdoGrpDeptUnit.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoGrpDeptUnit.ForeColor = System.Drawing.Color.Gray;
            this.rdoGrpDeptUnit.Location = new System.Drawing.Point(262, 13);
            this.rdoGrpDeptUnit.Name = "rdoGrpDeptUnit";
            this.rdoGrpDeptUnit.Size = new System.Drawing.Size(215, 22);
            this.rdoGrpDeptUnit.TabIndex = 2;
            this.rdoGrpDeptUnit.TabStop = true;
            this.rdoGrpDeptUnit.Text = " Group , Dept and Unit Wise";
            this.rdoGrpDeptUnit.UseVisualStyleBackColor = true;
            // 
            // rdoDeptGrp
            // 
            this.rdoDeptGrp.AutoSize = true;
            this.rdoDeptGrp.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDeptGrp.ForeColor = System.Drawing.Color.Gray;
            this.rdoDeptGrp.Location = new System.Drawing.Point(98, 13);
            this.rdoDeptGrp.Name = "rdoDeptGrp";
            this.rdoDeptGrp.Size = new System.Drawing.Size(140, 22);
            this.rdoDeptGrp.TabIndex = 1;
            this.rdoDeptGrp.TabStop = true;
            this.rdoDeptGrp.Text = "Dept Group Wise";
            this.rdoDeptGrp.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoAll.ForeColor = System.Drawing.Color.Gray;
            this.rdoAll.Location = new System.Drawing.Point(22, 13);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(44, 22);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(1049, 207);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(105, 26);
            this.dtEndDate.TabIndex = 231;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(1046, 187);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(68, 13);
            this.smartLabel8.TabIndex = 232;
            this.smartLabel8.Text = "End Date :";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(386, 847);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(175, 13);
            this.smartLabel9.TabIndex = 233;
            this.smartLabel9.Text = "Search Employee From Here :";
            this.smartLabel9.Visible = false;
            // 
            // chkList
            // 
            this.chkList.AutoSize = true;
            this.chkList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkList.ForeColor = System.Drawing.Color.Black;
            this.chkList.Location = new System.Drawing.Point(529, 153);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(84, 22);
            this.chkList.TabIndex = 233;
            this.chkList.Text = "Select All";
            this.chkList.UseVisualStyleBackColor = true;
            this.chkList.CheckedChanged += new System.EventHandler(this.chkList_CheckedChanged);
            // 
            // frmRosterDutySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1469, 896);
            this.Controls.Add(this.smartLabel9);
            this.Controls.Add(this.smartLabel7);
            this.Controls.Add(this.txtSearchText);
            this.isEnterTabAllow = true;
            this.Name = "frmRosterDutySetup";
            this.Load += new System.EventHandler(this.frmRosterDutySetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.txtSearchText, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.smartLabel7, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.smartLabel9, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbSelectOptions.ResumeLayout(false);
            this.gbSelectOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartDataGridView dgvInitialGrid;
        private AtiqsControlLibrary.SmartDataGridView dgvAssociatedGrid;
        private AtiqsControlLibrary.SmartComboBox cboMonth;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboShift;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartTextBox txtSearchText;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.Button btnRefreshShiftTiming;
        private System.Windows.Forms.Button btnAddShiftTiming;
        private System.Windows.Forms.Button btnAddRoster;
        private System.Windows.Forms.GroupBox gbSelectOptions;
        private AtiqsControlLibrary.SmartRadioButton rdoGrpDeptUnit;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptGrp;
        private AtiqsControlLibrary.SmartRadioButton rdoAll;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartCheckBox chkList;
    }
}
