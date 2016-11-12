namespace AH.ModuleController.UI.APMS.Forms
{
    partial class frmCreateDoctorSchedule
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
            this.lblDoctorID = new AtiqsControlLibrary.SmartLabel();
            this.lblUnitID = new AtiqsControlLibrary.SmartLabel();
            this.lblDeptID = new AtiqsControlLibrary.SmartLabel();
            this.cboDoctorID = new AtiqsControlLibrary.SmartComboBox();
            this.cboUnitID = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartmentID = new AtiqsControlLibrary.SmartComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDoctorSchedule = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl = new AtiqsControlLibrary.SmartLabel();
            this.lblSt = new AtiqsControlLibrary.SmartLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mnClear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDoctorTiming = new System.Windows.Forms.DataGridView();
            this.tbCalendar = new System.Windows.Forms.TabControl();
            this.tbCreateSchedule = new System.Windows.Forms.TabPage();
            this.chkSameTime = new System.Windows.Forms.CheckBox();
            this.btnSame = new System.Windows.Forms.Button();
            this.lblDateExist = new System.Windows.Forms.Label();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.tbShow = new System.Windows.Forms.TabPage();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.tbUpdate = new System.Windows.Forms.TabPage();
            this.chkSameTimeUpdate = new System.Windows.Forms.CheckBox();
            this.btnClearDateTimePicker = new System.Windows.Forms.Button();
            this.lblUpDateExist = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStatDate = new System.Windows.Forms.Label();
            this.dgvUpdateSchedule = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDelete = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.lblEndD = new System.Windows.Forms.Label();
            this.lblStartd = new System.Windows.Forms.Label();
            this.dgvDeleteSchedule = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mnuClear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoctorName = new AtiqsControlLibrary.SmartTextBox();
            this.lstDoctorName = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorSchedule)).BeginInit();
            this.mnClear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorTiming)).BeginInit();
            this.tbCalendar.SuspendLayout();
            this.tbCreateSchedule.SuspendLayout();
            this.tbShow.SuspendLayout();
            this.tbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateSchedule)).BeginInit();
            this.tbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteSchedule)).BeginInit();
            this.mnuClear.SuspendLayout();
            this.menuClear.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(819, 6);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(438, 9);
            this.frmLabel.Size = new System.Drawing.Size(272, 33);
            this.frmLabel.Text = "Doctor\'s  Duty Timing";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.tbCalendar);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.lblDoctorID);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.lblUnitID);
            this.pnlMain.Controls.Add(this.lblDeptID);
            this.pnlMain.Controls.Add(this.dtpEndDate);
            this.pnlMain.Controls.Add(this.lbl);
            this.pnlMain.Controls.Add(this.cboDoctorID);
            this.pnlMain.Controls.Add(this.cboUnitID);
            this.pnlMain.Controls.Add(this.dtpStartDate);
            this.pnlMain.Controls.Add(this.cboDepartmentID);
            this.pnlMain.Controls.Add(this.lblSt);
            this.pnlMain.Location = new System.Drawing.Point(1, 54);
            this.pnlMain.Size = new System.Drawing.Size(1022, 651);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtDoctorName);
            this.pnlTop.Controls.Add(this.lstDoctorName);
            this.pnlTop.Size = new System.Drawing.Size(1023, 56);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.lstDoctorName, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtDoctorName, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(27, 712);
            this.btnEdit.Size = new System.Drawing.Size(10, 40);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 713);
            this.btnSave.Size = new System.Drawing.Size(25, 39);
            this.btnSave.TabIndex = 14;
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(10, 712);
            this.btnDelete.Size = new System.Drawing.Size(11, 40);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(777, 713);
            this.btnNew.Size = new System.Drawing.Size(120, 40);
            this.btnNew.TabIndex = 16;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(903, 713);
            this.btnClose.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(43, 712);
            this.btnPrint.Size = new System.Drawing.Size(10, 40);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 757);
            this.groupBox1.Size = new System.Drawing.Size(1023, 17);
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDoctorID.Location = new System.Drawing.Point(408, 20);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(53, 13);
            this.lblDoctorID.TabIndex = 26;
            this.lblDoctorID.Text = "Doctor :";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnitID.Location = new System.Drawing.Point(41, 57);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(42, 13);
            this.lblUnitID.TabIndex = 25;
            this.lblUnitID.Text = "Unit  :";
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDeptID.Location = new System.Drawing.Point(-1, 20);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(84, 13);
            this.lblDeptID.TabIndex = 24;
            this.lblDeptID.Text = "Department  :";
            // 
            // cboDoctorID
            // 
            this.cboDoctorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctorID.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctorID.FormattingEnabled = true;
            this.cboDoctorID.Location = new System.Drawing.Point(464, 14);
            this.cboDoctorID.Name = "cboDoctorID";
            this.cboDoctorID.Size = new System.Drawing.Size(392, 26);
            this.cboDoctorID.TabIndex = 2;
            this.cboDoctorID.SelectedIndexChanged += new System.EventHandler(this.cboDoctorID_SelectedIndexChanged);
            // 
            // cboUnitID
            // 
            this.cboUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnitID.ForeColor = System.Drawing.Color.Blue;
            this.cboUnitID.FormattingEnabled = true;
            this.cboUnitID.Location = new System.Drawing.Point(87, 55);
            this.cboUnitID.Name = "cboUnitID";
            this.cboUnitID.Size = new System.Drawing.Size(282, 26);
            this.cboUnitID.TabIndex = 1;
            this.cboUnitID.SelectedIndexChanged += new System.EventHandler(this.cboUnitID_SelectedIndexChanged);
            // 
            // cboDepartmentID
            // 
            this.cboDepartmentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentID.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentID.FormattingEnabled = true;
            this.cboDepartmentID.Items.AddRange(new object[] {
            "select"});
            this.cboDepartmentID.Location = new System.Drawing.Point(87, 16);
            this.cboDepartmentID.Name = "cboDepartmentID";
            this.cboDepartmentID.Size = new System.Drawing.Size(282, 26);
            this.cboDepartmentID.TabIndex = 0;
            this.cboDepartmentID.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(370, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 193;
            this.label4.Text = "*";
            // 
            // dgvDoctorSchedule
            // 
            this.dgvDoctorSchedule.AllowUserToAddRows = false;
            this.dgvDoctorSchedule.AllowUserToDeleteRows = false;
            this.dgvDoctorSchedule.AllowUserToResizeRows = false;
            this.dgvDoctorSchedule.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvDoctorSchedule.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDoctorSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorSchedule.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDoctorSchedule.Location = new System.Drawing.Point(63, 159);
            this.dgvDoctorSchedule.Name = "dgvDoctorSchedule";
            this.dgvDoctorSchedule.RowHeadersVisible = false;
            this.dgvDoctorSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDoctorSchedule.Size = new System.Drawing.Size(894, 223);
            this.dgvDoctorSchedule.TabIndex = 197;
            this.dgvDoctorSchedule.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDoctorSchedule_CellBeginEdit);
            this.dgvDoctorSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorSchedule_CellClick);
            this.dgvDoctorSchedule.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorSchedule_CellEndEdit);
            this.dgvDoctorSchedule.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoctorSchedule_CellMouseDown);
            this.dgvDoctorSchedule.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDoctorSchedule_CellValidating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(619, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 202;
            this.label11.Text = "*";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(703, 60);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(153, 24);
            this.dtpEndDate.TabIndex = 199;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(467, 60);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(152, 24);
            this.dtpStartDate.TabIndex = 198;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl.Location = new System.Drawing.Point(634, 65);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(68, 13);
            this.lbl.TabIndex = 201;
            this.lbl.Text = "End Date :";
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.BackColor = System.Drawing.Color.Transparent;
            this.lblSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSt.Location = new System.Drawing.Point(388, 63);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(73, 13);
            this.lblSt.TabIndex = 200;
            this.lblSt.Text = "Start Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(191, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 204;
            this.label1.Text = "First Time Slot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(499, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 205;
            this.label3.Text = "Second Time Slot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(765, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 206;
            this.label6.Text = "Third Time Slot";
            // 
            // mnClear
            // 
            this.mnClear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.mnClear.Name = "contxtClear";
            this.mnClear.Size = new System.Drawing.Size(100, 26);
            this.mnClear.Text = "Clear";
            this.mnClear.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnClear_ItemClicked);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // dgvDoctorTiming
            // 
            this.dgvDoctorTiming.AllowUserToAddRows = false;
            this.dgvDoctorTiming.AllowUserToDeleteRows = false;
            this.dgvDoctorTiming.AllowUserToResizeColumns = false;
            this.dgvDoctorTiming.AllowUserToResizeRows = false;
            this.dgvDoctorTiming.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvDoctorTiming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorTiming.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDoctorTiming.Location = new System.Drawing.Point(67, 49);
            this.dgvDoctorTiming.Name = "dgvDoctorTiming";
            this.dgvDoctorTiming.ReadOnly = true;
            this.dgvDoctorTiming.RowHeadersVisible = false;
            this.dgvDoctorTiming.Size = new System.Drawing.Size(894, 472);
            this.dgvDoctorTiming.TabIndex = 207;
            this.dgvDoctorTiming.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDoctorTiming_CellPainting);
            // 
            // tbCalendar
            // 
            this.tbCalendar.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbCalendar.Controls.Add(this.tbCreateSchedule);
            this.tbCalendar.Controls.Add(this.tbShow);
            this.tbCalendar.Controls.Add(this.tbUpdate);
            this.tbCalendar.Controls.Add(this.tbDelete);
            this.tbCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCalendar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCalendar.Location = new System.Drawing.Point(3, 87);
            this.tbCalendar.Name = "tbCalendar";
            this.tbCalendar.SelectedIndex = 0;
            this.tbCalendar.Size = new System.Drawing.Size(1019, 559);
            this.tbCalendar.TabIndex = 208;
            this.tbCalendar.SelectedIndexChanged += new System.EventHandler(this.tbCalendar_SelectedIndexChanged);
            // 
            // tbCreateSchedule
            // 
            this.tbCreateSchedule.BackColor = System.Drawing.Color.Snow;
            this.tbCreateSchedule.Controls.Add(this.chkSameTime);
            this.tbCreateSchedule.Controls.Add(this.btnSame);
            this.tbCreateSchedule.Controls.Add(this.lblDateExist);
            this.tbCreateSchedule.Controls.Add(this.smartLabel4);
            this.tbCreateSchedule.Controls.Add(this.buttonCreate);
            this.tbCreateSchedule.Controls.Add(this.lblDoctorName);
            this.tbCreateSchedule.Controls.Add(this.dgvDoctorSchedule);
            this.tbCreateSchedule.Controls.Add(this.label6);
            this.tbCreateSchedule.Controls.Add(this.label3);
            this.tbCreateSchedule.Controls.Add(this.label1);
            this.tbCreateSchedule.Location = new System.Drawing.Point(4, 28);
            this.tbCreateSchedule.Name = "tbCreateSchedule";
            this.tbCreateSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tbCreateSchedule.Size = new System.Drawing.Size(1011, 527);
            this.tbCreateSchedule.TabIndex = 0;
            this.tbCreateSchedule.Text = "Create ";
            // 
            // chkSameTime
            // 
            this.chkSameTime.AutoSize = true;
            this.chkSameTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSameTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.chkSameTime.Location = new System.Drawing.Point(66, 348);
            this.chkSameTime.Name = "chkSameTime";
            this.chkSameTime.Size = new System.Drawing.Size(184, 22);
            this.chkSameTime.TabIndex = 218;
            this.chkSameTime.Text = "Same Time For All Days";
            this.chkSameTime.UseVisualStyleBackColor = true;
            this.chkSameTime.CheckedChanged += new System.EventHandler(this.chkSameTime_CheckedChanged);
            // 
            // btnSame
            // 
            this.btnSame.BackColor = System.Drawing.Color.Orange;
            this.btnSame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSame.Location = new System.Drawing.Point(63, 383);
            this.btnSame.Name = "btnSame";
            this.btnSame.Size = new System.Drawing.Size(132, 30);
            this.btnSame.TabIndex = 217;
            this.btnSame.Text = "Same Time For All Days";
            this.btnSame.UseVisualStyleBackColor = false;
            this.btnSame.Visible = false;
            this.btnSame.Click += new System.EventHandler(this.btnSame_Click);
            // 
            // lblDateExist
            // 
            this.lblDateExist.AutoSize = true;
            this.lblDateExist.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExist.ForeColor = System.Drawing.Color.Red;
            this.lblDateExist.Location = new System.Drawing.Point(125, 22);
            this.lblDateExist.Name = "lblDateExist";
            this.lblDateExist.Size = new System.Drawing.Size(80, 23);
            this.lblDateExist.TabIndex = 216;
            this.lblDateExist.Text = "label17";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.smartLabel4.Location = new System.Drawing.Point(500, 403);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(159, 15);
            this.smartLabel4.TabIndex = 213;
            this.smartLabel4.Text = "Search By Doctor Name";
            this.smartLabel4.Visible = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreate.Location = new System.Drawing.Point(824, 388);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(132, 30);
            this.buttonCreate.TabIndex = 215;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDoctorName.Location = new System.Drawing.Point(400, 64);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(80, 23);
            this.lblDoctorName.TabIndex = 207;
            this.lblDoctorName.Text = "label17";
            // 
            // tbShow
            // 
            this.tbShow.BackColor = System.Drawing.Color.Snow;
            this.tbShow.Controls.Add(this.smartLabel1);
            this.tbShow.Controls.Add(this.lblEnd);
            this.tbShow.Controls.Add(this.lblStart);
            this.tbShow.Controls.Add(this.dgvDoctorTiming);
            this.tbShow.Location = new System.Drawing.Point(4, 28);
            this.tbShow.Name = "tbShow";
            this.tbShow.Padding = new System.Windows.Forms.Padding(3);
            this.tbShow.Size = new System.Drawing.Size(1011, 527);
            this.tbShow.TabIndex = 1;
            this.tbShow.Text = "Show ";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(437, 17);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(31, 19);
            this.smartLabel1.TabIndex = 210;
            this.smartLabel1.Text = "To";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEnd.Location = new System.Drawing.Point(487, 17);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(85, 20);
            this.lblEnd.TabIndex = 209;
            this.lblEnd.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Green;
            this.lblStart.Location = new System.Drawing.Point(279, 17);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(98, 20);
            this.lblStart.TabIndex = 208;
            this.lblStart.Text = "Start Date ";
            // 
            // tbUpdate
            // 
            this.tbUpdate.BackColor = System.Drawing.Color.Snow;
            this.tbUpdate.Controls.Add(this.chkSameTimeUpdate);
            this.tbUpdate.Controls.Add(this.btnClearDateTimePicker);
            this.tbUpdate.Controls.Add(this.lblUpDateExist);
            this.tbUpdate.Controls.Add(this.buttonUpdate);
            this.tbUpdate.Controls.Add(this.smartLabel2);
            this.tbUpdate.Controls.Add(this.lblEndDate);
            this.tbUpdate.Controls.Add(this.lblStatDate);
            this.tbUpdate.Controls.Add(this.dgvUpdateSchedule);
            this.tbUpdate.Controls.Add(this.label10);
            this.tbUpdate.Controls.Add(this.label12);
            this.tbUpdate.Controls.Add(this.label13);
            this.tbUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbUpdate.Location = new System.Drawing.Point(4, 28);
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tbUpdate.Size = new System.Drawing.Size(1011, 527);
            this.tbUpdate.TabIndex = 2;
            this.tbUpdate.Text = "Update";
            // 
            // chkSameTimeUpdate
            // 
            this.chkSameTimeUpdate.AutoSize = true;
            this.chkSameTimeUpdate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSameTimeUpdate.ForeColor = System.Drawing.Color.MediumBlue;
            this.chkSameTimeUpdate.Location = new System.Drawing.Point(59, 357);
            this.chkSameTimeUpdate.Name = "chkSameTimeUpdate";
            this.chkSameTimeUpdate.Size = new System.Drawing.Size(184, 22);
            this.chkSameTimeUpdate.TabIndex = 219;
            this.chkSameTimeUpdate.Text = "Same Time For All Days";
            this.chkSameTimeUpdate.UseVisualStyleBackColor = true;
            this.chkSameTimeUpdate.CheckedChanged += new System.EventHandler(this.chkSameTimeUpdate_CheckedChanged);
            // 
            // btnClearDateTimePicker
            // 
            this.btnClearDateTimePicker.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearDateTimePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.btnClearDateTimePicker.Location = new System.Drawing.Point(796, 6);
            this.btnClearDateTimePicker.Name = "btnClearDateTimePicker";
            this.btnClearDateTimePicker.Size = new System.Drawing.Size(155, 29);
            this.btnClearDateTimePicker.TabIndex = 218;
            this.btnClearDateTimePicker.Text = "Clear Date Time ";
            this.btnClearDateTimePicker.UseVisualStyleBackColor = false;
            this.btnClearDateTimePicker.Visible = false;
            this.btnClearDateTimePicker.Click += new System.EventHandler(this.btnClearDateTimePicker_Click);
            // 
            // lblUpDateExist
            // 
            this.lblUpDateExist.AutoSize = true;
            this.lblUpDateExist.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpDateExist.ForeColor = System.Drawing.Color.Red;
            this.lblUpDateExist.Location = new System.Drawing.Point(213, 22);
            this.lblUpDateExist.Name = "lblUpDateExist";
            this.lblUpDateExist.Size = new System.Drawing.Size(80, 23);
            this.lblUpDateExist.TabIndex = 217;
            this.lblUpDateExist.Text = "label17";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUpdate.Location = new System.Drawing.Point(820, 396);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 36);
            this.buttonUpdate.TabIndex = 216;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Tomato;
            this.smartLabel2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(455, 79);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(31, 19);
            this.smartLabel2.TabIndex = 213;
            this.smartLabel2.Text = "To";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.Crimson;
            this.lblEndDate.Location = new System.Drawing.Point(505, 77);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(96, 24);
            this.lblEndDate.TabIndex = 212;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStatDate
            // 
            this.lblStatDate.AutoSize = true;
            this.lblStatDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatDate.ForeColor = System.Drawing.Color.Crimson;
            this.lblStatDate.Location = new System.Drawing.Point(297, 76);
            this.lblStatDate.Name = "lblStatDate";
            this.lblStatDate.Size = new System.Drawing.Size(105, 24);
            this.lblStatDate.TabIndex = 211;
            this.lblStatDate.Text = "Start Date ";
            // 
            // dgvUpdateSchedule
            // 
            this.dgvUpdateSchedule.AllowUserToAddRows = false;
            this.dgvUpdateSchedule.AllowUserToDeleteRows = false;
            this.dgvUpdateSchedule.AllowUserToResizeRows = false;
            this.dgvUpdateSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpdateSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateSchedule.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUpdateSchedule.Location = new System.Drawing.Point(54, 167);
            this.dgvUpdateSchedule.Name = "dgvUpdateSchedule";
            this.dgvUpdateSchedule.RowHeadersVisible = false;
            this.dgvUpdateSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUpdateSchedule.Size = new System.Drawing.Size(897, 223);
            this.dgvUpdateSchedule.TabIndex = 207;
            this.dgvUpdateSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateSchedule_CellClick);
            this.dgvUpdateSchedule.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUpdateSchedule_CellMouseDown);
            this.dgvUpdateSchedule.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvUpdateSchedule_CellValidating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(778, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 210;
            this.label10.Text = "Third Time Slot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(507, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 20);
            this.label12.TabIndex = 209;
            this.label12.Text = "Second Time Slot";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(213, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 20);
            this.label13.TabIndex = 208;
            this.label13.Text = "First Time Slot";
            // 
            // tbDelete
            // 
            this.tbDelete.BackColor = System.Drawing.Color.Snow;
            this.tbDelete.Controls.Add(this.buttonDelete);
            this.tbDelete.Controls.Add(this.smartLabel3);
            this.tbDelete.Controls.Add(this.lblEndD);
            this.tbDelete.Controls.Add(this.lblStartd);
            this.tbDelete.Controls.Add(this.dgvDeleteSchedule);
            this.tbDelete.Controls.Add(this.label14);
            this.tbDelete.Controls.Add(this.label15);
            this.tbDelete.Controls.Add(this.label16);
            this.tbDelete.Location = new System.Drawing.Point(4, 28);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tbDelete.Size = new System.Drawing.Size(1011, 527);
            this.tbDelete.TabIndex = 3;
            this.tbDelete.Text = "Delete";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(824, 380);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 36);
            this.buttonDelete.TabIndex = 214;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(464, 51);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(31, 19);
            this.smartLabel3.TabIndex = 213;
            this.smartLabel3.Text = "To";
            // 
            // lblEndD
            // 
            this.lblEndD.AutoSize = true;
            this.lblEndD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEndD.Location = new System.Drawing.Point(514, 51);
            this.lblEndD.Name = "lblEndD";
            this.lblEndD.Size = new System.Drawing.Size(85, 20);
            this.lblEndD.TabIndex = 212;
            this.lblEndD.Text = "End Date";
            // 
            // lblStartd
            // 
            this.lblStartd.AutoSize = true;
            this.lblStartd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartd.ForeColor = System.Drawing.Color.Green;
            this.lblStartd.Location = new System.Drawing.Point(306, 51);
            this.lblStartd.Name = "lblStartd";
            this.lblStartd.Size = new System.Drawing.Size(98, 20);
            this.lblStartd.TabIndex = 211;
            this.lblStartd.Text = "Start Date ";
            // 
            // dgvDeleteSchedule
            // 
            this.dgvDeleteSchedule.AllowUserToAddRows = false;
            this.dgvDeleteSchedule.AllowUserToDeleteRows = false;
            this.dgvDeleteSchedule.AllowUserToResizeRows = false;
            this.dgvDeleteSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeleteSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteSchedule.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDeleteSchedule.Location = new System.Drawing.Point(59, 151);
            this.dgvDeleteSchedule.Name = "dgvDeleteSchedule";
            this.dgvDeleteSchedule.RowHeadersVisible = false;
            this.dgvDeleteSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDeleteSchedule.Size = new System.Drawing.Size(895, 223);
            this.dgvDeleteSchedule.TabIndex = 207;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkViolet;
            this.label14.Location = new System.Drawing.Point(790, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 20);
            this.label14.TabIndex = 210;
            this.label14.Text = "Third Time Slot";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label15.Location = new System.Drawing.Point(514, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 20);
            this.label15.TabIndex = 209;
            this.label15.Text = "Second Time Slot";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(190, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 208;
            this.label16.Text = "First Time Slot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(371, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 210;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(857, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 211;
            this.label9.Text = "*";
            // 
            // mnuClear
            // 
            this.mnuClear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnuClear.Name = "contxtClear";
            this.mnuClear.Size = new System.Drawing.Size(100, 26);
            this.mnuClear.Text = "Clear";
            this.mnuClear.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuClear_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItem1.Text = "Clear";
            // 
            // menuClear
            // 
            this.menuClear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuClear.Name = "contxtClear";
            this.menuClear.Size = new System.Drawing.Size(100, 26);
            this.menuClear.Text = "Clear";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItem2.Text = "Clear";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(857, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 212;
            this.label5.Text = "*";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(209, 9);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(51, 24);
            this.txtDoctorName.TabIndex = 214;
            this.txtDoctorName.Visible = false;
            this.txtDoctorName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDoctorName_KeyUp);
            // 
            // lstDoctorName
            // 
            this.lstDoctorName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDoctorName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstDoctorName.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDoctorName.FullRowSelect = true;
            this.lstDoctorName.GridLines = true;
            this.lstDoctorName.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDoctorName.HideSelection = false;
            this.lstDoctorName.Location = new System.Drawing.Point(282, 13);
            this.lstDoctorName.Name = "lstDoctorName";
            this.lstDoctorName.Size = new System.Drawing.Size(51, 13);
            this.lstDoctorName.TabIndex = 215;
            this.lstDoctorName.UseCompatibleStateImageBehavior = false;
            this.lstDoctorName.View = System.Windows.Forms.View.Details;
            this.lstDoctorName.Visible = false;
            this.lstDoctorName.SelectedIndexChanged += new System.EventHandler(this.lstDoctorName_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Salmon;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnRefresh.Location = new System.Drawing.Point(879, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 30);
            this.btnRefresh.TabIndex = 216;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmCreateDoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1023, 774);
            this.isEnterTabAllow = true;
            this.Name = "frmCreateDoctorSchedule";
            this.Load += new System.EventHandler(this.frmDoctorDutyTiming_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorSchedule)).EndInit();
            this.mnClear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorTiming)).EndInit();
            this.tbCalendar.ResumeLayout(false);
            this.tbCreateSchedule.ResumeLayout(false);
            this.tbCreateSchedule.PerformLayout();
            this.tbShow.ResumeLayout(false);
            this.tbShow.PerformLayout();
            this.tbUpdate.ResumeLayout(false);
            this.tbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateSchedule)).EndInit();
            this.tbDelete.ResumeLayout(false);
            this.tbDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteSchedule)).EndInit();
            this.mnuClear.ResumeLayout(false);
            this.menuClear.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel lblDoctorID;
        private AtiqsControlLibrary.SmartLabel lblUnitID;
        private AtiqsControlLibrary.SmartLabel lblDeptID;
        private AtiqsControlLibrary.SmartComboBox cboDoctorID;
        private AtiqsControlLibrary.SmartComboBox cboUnitID;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDoctorSchedule;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private AtiqsControlLibrary.SmartLabel lbl;
        private AtiqsControlLibrary.SmartLabel lblSt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip mnClear;
        private System.Windows.Forms.DataGridView dgvDoctorTiming;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TabControl tbCalendar;
        private System.Windows.Forms.TabPage tbCreateSchedule;
        private System.Windows.Forms.TabPage tbShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.TabPage tbUpdate;
        private System.Windows.Forms.DataGridView dgvUpdateSchedule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tbDelete;
        private System.Windows.Forms.DataGridView dgvDeleteSchedule;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStatDate;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.Label lblEndD;
        private System.Windows.Forms.Label lblStartd;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.ContextMenuStrip mnuClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip menuClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label5;
        private AtiqsControlLibrary.SmartTextBox txtDoctorName;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartListViewDetails lstDoctorName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDateExist;
        private System.Windows.Forms.Label lblUpDateExist;
        private System.Windows.Forms.Button btnClearDateTimePicker;
        private System.Windows.Forms.Button btnSame;
        private System.Windows.Forms.CheckBox chkSameTime;
        private System.Windows.Forms.CheckBox chkSameTimeUpdate;
    }
}
