namespace AH.ModuleController.UI.APMS.Forms
{
    partial class frmDoctorDutyTiming
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
            this.cboWeekOnDays = new AtiqsControlLibrary.SmartCheckedListBox();
            this.lblStartTime = new AtiqsControlLibrary.SmartLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTimeInterval = new System.Windows.Forms.NumericUpDown();
            this.cboWeekDays = new AtiqsControlLibrary.SmartComboBox();
            this.lblAppointmentTimeInterval = new AtiqsControlLibrary.SmartLabel();
            this.lblWeekDays = new AtiqsControlLibrary.SmartLabel();
            this.lblTimings = new AtiqsControlLibrary.SmartLabel();
            this.cboInterval = new AtiqsControlLibrary.SmartComboBox();
            this.cboService = new AtiqsControlLibrary.SmartComboBox();
            this.lblService = new AtiqsControlLibrary.SmartLabel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new AtiqsControlLibrary.SmartLabel();
            this.lblDoctorID = new AtiqsControlLibrary.SmartLabel();
            this.lblUnitID = new AtiqsControlLibrary.SmartLabel();
            this.lblDeptID = new AtiqsControlLibrary.SmartLabel();
            this.cboDoctorID = new AtiqsControlLibrary.SmartComboBox();
            this.cboUnitID = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartmentID = new AtiqsControlLibrary.SmartComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvDutyTimings = new System.Windows.Forms.DataGridView();
            this.mnDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkWeekDays = new AtiqsControlLibrary.SmartCheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDeleteCalendar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDutyTimings)).BeginInit();
            this.mnDelete.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(819, 6);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(295, 8);
            this.frmLabel.Size = new System.Drawing.Size(272, 33);
            this.frmLabel.Text = "Doctor\'s  Duty Timing";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Ivory;
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.dgvDutyTimings);
            this.pnlMain.Controls.Add(this.lblDoctorID);
            this.pnlMain.Controls.Add(this.lblUnitID);
            this.pnlMain.Controls.Add(this.lblDeptID);
            this.pnlMain.Controls.Add(this.cboDoctorID);
            this.pnlMain.Controls.Add(this.cboUnitID);
            this.pnlMain.Controls.Add(this.cboDepartmentID);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Location = new System.Drawing.Point(1, 54);
            this.pnlMain.Size = new System.Drawing.Size(912, 492);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cboWeekOnDays);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.cboService);
            this.pnlTop.Controls.Add(this.lblService);
            this.pnlTop.Size = new System.Drawing.Size(913, 56);
            this.pnlTop.Controls.SetChildIndex(this.lblService, 0);
            this.pnlTop.Controls.SetChildIndex(this.cboService, 0);
            this.pnlTop.Controls.SetChildIndex(this.button1, 0);
            this.pnlTop.Controls.SetChildIndex(this.cboWeekOnDays, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(106, 554);
            this.btnEdit.Size = new System.Drawing.Size(15, 40);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(683, 555);
            this.btnSave.TabIndex = 14;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(77, 563);
            this.btnDelete.Size = new System.Drawing.Size(14, 40);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(557, 554);
            this.btnNew.Size = new System.Drawing.Size(120, 40);
            this.btnNew.TabIndex = 16;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(797, 555);
            this.btnClose.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(139, 557);
            this.btnPrint.Size = new System.Drawing.Size(17, 40);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 603);
            this.groupBox1.Size = new System.Drawing.Size(913, 23);
            // 
            // cboWeekOnDays
            // 
            this.cboWeekOnDays.BackColor = System.Drawing.Color.SteelBlue;
            this.cboWeekOnDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cboWeekOnDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboWeekOnDays.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWeekOnDays.ForeColor = System.Drawing.Color.White;
            this.cboWeekOnDays.FormattingEnabled = true;
            this.cboWeekOnDays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cboWeekOnDays.Location = new System.Drawing.Point(662, 13);
            this.cboWeekOnDays.Name = "cboWeekOnDays";
            this.cboWeekOnDays.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.cboWeekOnDays.Size = new System.Drawing.Size(109, 22);
            this.cboWeekOnDays.TabIndex = 1;
            this.cboWeekOnDays.Visible = false;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStartTime.Location = new System.Drawing.Point(232, 26);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(73, 13);
            this.lblStartTime.TabIndex = 8;
            this.lblStartTime.Text = "Start Date :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtTimeInterval);
            this.panel1.Controls.Add(this.cboWeekDays);
            this.panel1.Controls.Add(this.lblAppointmentTimeInterval);
            this.panel1.Controls.Add(this.lblWeekDays);
            this.panel1.Controls.Add(this.lblTimings);
            this.panel1.Location = new System.Drawing.Point(1, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 74);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(680, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 197;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(589, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 196;
            this.label8.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(268, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 195;
            this.label6.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "(Minutes)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpEndTime);
            this.panel2.Controls.Add(this.dtpStartTime);
            this.panel2.Controls.Add(this.lblFrom);
            this.panel2.Controls.Add(this.smartLabel11);
            this.panel2.Location = new System.Drawing.Point(300, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 44);
            this.panel2.TabIndex = 9;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh : mm tt";
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(177, 7);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(93, 24);
            this.dtpEndTime.TabIndex = 11;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh : mm tt";
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(48, 7);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(93, 24);
            this.dtpStartTime.TabIndex = 10;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(4, 11);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 15;
            this.lblFrom.Text = "From";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(147, 12);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(22, 13);
            this.smartLabel11.TabIndex = 14;
            this.smartLabel11.Text = "To";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(700, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 38);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Timing";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTimeInterval
            // 
            this.txtTimeInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeInterval.Location = new System.Drawing.Point(617, 26);
            this.txtTimeInterval.Name = "txtTimeInterval";
            this.txtTimeInterval.Size = new System.Drawing.Size(61, 24);
            this.txtTimeInterval.TabIndex = 12;
            this.txtTimeInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cboWeekDays
            // 
            this.cboWeekDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeekDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWeekDays.ForeColor = System.Drawing.Color.Blue;
            this.cboWeekDays.FormattingEnabled = true;
            this.cboWeekDays.Location = new System.Drawing.Point(6, 30);
            this.cboWeekDays.Name = "cboWeekDays";
            this.cboWeekDays.Size = new System.Drawing.Size(256, 26);
            this.cboWeekDays.TabIndex = 9;
            this.cboWeekDays.SelectedIndexChanged += new System.EventHandler(this.cboWeekDays_SelectedIndexChanged);
            // 
            // lblAppointmentTimeInterval
            // 
            this.lblAppointmentTimeInterval.AutoSize = true;
            this.lblAppointmentTimeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentTimeInterval.Location = new System.Drawing.Point(624, 8);
            this.lblAppointmentTimeInterval.Name = "lblAppointmentTimeInterval";
            this.lblAppointmentTimeInterval.Size = new System.Drawing.Size(54, 13);
            this.lblAppointmentTimeInterval.TabIndex = 23;
            this.lblAppointmentTimeInterval.Text = "Interval ";
            // 
            // lblWeekDays
            // 
            this.lblWeekDays.AutoSize = true;
            this.lblWeekDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblWeekDays.Location = new System.Drawing.Point(85, 5);
            this.lblWeekDays.Name = "lblWeekDays";
            this.lblWeekDays.Size = new System.Drawing.Size(104, 13);
            this.lblWeekDays.TabIndex = 2;
            this.lblWeekDays.Text = "Scheduled Dates";
            // 
            // lblTimings
            // 
            this.lblTimings.AutoSize = true;
            this.lblTimings.BackColor = System.Drawing.Color.Transparent;
            this.lblTimings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTimings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimings.Location = new System.Drawing.Point(424, 5);
            this.lblTimings.Name = "lblTimings";
            this.lblTimings.Size = new System.Drawing.Size(50, 13);
            this.lblTimings.TabIndex = 4;
            this.lblTimings.Text = "Timings";
            // 
            // cboInterval
            // 
            this.cboInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInterval.ForeColor = System.Drawing.Color.Blue;
            this.cboInterval.FormattingEnabled = true;
            this.cboInterval.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.cboInterval.Location = new System.Drawing.Point(511, 19);
            this.cboInterval.Name = "cboInterval";
            this.cboInterval.Size = new System.Drawing.Size(10, 26);
            this.cboInterval.TabIndex = 198;
            this.cboInterval.Visible = false;
            // 
            // cboService
            // 
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.ForeColor = System.Drawing.Color.Blue;
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "Consultation",
            "Room Visit"});
            this.cboService.Location = new System.Drawing.Point(167, 12);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(20, 26);
            this.cboService.TabIndex = 9;
            this.cboService.Visible = false;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblService.Location = new System.Drawing.Point(113, 16);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(58, 13);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service :";
            this.lblService.Visible = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.DarkGreen;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(472, 135);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(81, 30);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Create Calender";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(312, 68);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(153, 24);
            this.dtpEndDate.TabIndex = 5;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(312, 24);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(152, 24);
            this.dtpStartDate.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(237, 72);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(68, 13);
            this.lblEndDate.TabIndex = 14;
            this.lblEndDate.Text = "End Date :";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDoctorID.Location = new System.Drawing.Point(17, 125);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(53, 13);
            this.lblDoctorID.TabIndex = 26;
            this.lblDoctorID.Text = "Doctor :";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnitID.Location = new System.Drawing.Point(17, 68);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(42, 13);
            this.lblUnitID.TabIndex = 25;
            this.lblUnitID.Text = "Unit  :";
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDeptID.Location = new System.Drawing.Point(17, 13);
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
            this.cboDoctorID.Location = new System.Drawing.Point(10, 148);
            this.cboDoctorID.Name = "cboDoctorID";
            this.cboDoctorID.Size = new System.Drawing.Size(283, 26);
            this.cboDoctorID.TabIndex = 2;
            // 
            // cboUnitID
            // 
            this.cboUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnitID.ForeColor = System.Drawing.Color.Blue;
            this.cboUnitID.FormattingEnabled = true;
            this.cboUnitID.Location = new System.Drawing.Point(10, 90);
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
            this.cboDepartmentID.Location = new System.Drawing.Point(10, 36);
            this.cboDepartmentID.Name = "cboDepartmentID";
            this.cboDepartmentID.Size = new System.Drawing.Size(282, 26);
            this.cboDepartmentID.TabIndex = 0;
            this.cboDepartmentID.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentID_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.MediumBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(388, 135);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(81, 30);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show Calender";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvDutyTimings
            // 
            this.dgvDutyTimings.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvDutyTimings.ColumnHeadersHeight = 30;
            this.dgvDutyTimings.Location = new System.Drawing.Point(2, 275);
            this.dgvDutyTimings.Name = "dgvDutyTimings";
            this.dgvDutyTimings.RowHeadersVisible = false;
            this.dgvDutyTimings.RowHeadersWidth = 50;
            this.dgvDutyTimings.Size = new System.Drawing.Size(909, 209);
            this.dgvDutyTimings.TabIndex = 16;
            this.dgvDutyTimings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDutyTimings_CellClick);
            this.dgvDutyTimings.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDutyTimings_CellMouseDown);
            // 
            // mnDelete
            // 
            this.mnDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.mnDelete.Name = "mnDelete";
            this.mnDelete.Size = new System.Drawing.Size(153, 48);
            this.mnDelete.Opening += new System.ComponentModel.CancelEventHandler(this.mnDelete_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // chkWeekDays
            // 
            this.chkWeekDays.BackColor = System.Drawing.Color.SteelBlue;
            this.chkWeekDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkWeekDays.CheckOnClick = true;
            this.chkWeekDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkWeekDays.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWeekDays.ForeColor = System.Drawing.Color.White;
            this.chkWeekDays.FormattingEnabled = true;
            this.chkWeekDays.Location = new System.Drawing.Point(19, 33);
            this.chkWeekDays.Name = "chkWeekDays";
            this.chkWeekDays.Size = new System.Drawing.Size(151, 142);
            this.chkWeekDays.TabIndex = 3;
            this.chkWeekDays.Click += new System.EventHandler(this.chkWeekDays_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(295, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 193;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(295, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 194;
            this.label5.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(295, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 195;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(466, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 196;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(466, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 20);
            this.label12.TabIndex = 197;
            this.label12.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(180, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 198;
            this.label3.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.cboInterval);
            this.groupBox2.Controls.Add(this.btnDeleteCalendar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.chkWeekDays);
            this.groupBox2.Controls.Add(this.dtpEndDate);
            this.groupBox2.Controls.Add(this.dtpStartDate);
            this.groupBox2.Controls.Add(this.lblEndDate);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.lblStartTime);
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox2.Location = new System.Drawing.Point(348, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 185);
            this.groupBox2.TabIndex = 199;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save Day and Date";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(309, 135);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(76, 30);
            this.btnModify.TabIndex = 200;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDeleteCalendar
            // 
            this.btnDeleteCalendar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCalendar.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCalendar.Location = new System.Drawing.Point(228, 135);
            this.btnDeleteCalendar.Name = "btnDeleteCalendar";
            this.btnDeleteCalendar.Size = new System.Drawing.Size(77, 30);
            this.btnDeleteCalendar.TabIndex = 199;
            this.btnDeleteCalendar.Text = "Delete Calender";
            this.btnDeleteCalendar.UseVisualStyleBackColor = false;
            this.btnDeleteCalendar.Click += new System.EventHandler(this.btnDeleteCalendar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(1, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 4);
            this.panel3.TabIndex = 200;
            this.panel3.UseWaitCursor = true;
            this.panel3.Visible = false;
            // 
            // frmDoctorDutyTiming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 626);
            this.isEnterTabAllow = true;
            this.Name = "frmDoctorDutyTiming";
            this.Load += new System.EventHandler(this.frmDoctorDutyTiming_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDutyTimings)).EndInit();
            this.mnDelete.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel lblStartTime;
        private AtiqsControlLibrary.SmartCheckedListBox cboWeekOnDays;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcess;
        private AtiqsControlLibrary.SmartLabel lblTimings;
        private AtiqsControlLibrary.SmartComboBox cboWeekDays;
        private AtiqsControlLibrary.SmartLabel lblWeekDays;
        private AtiqsControlLibrary.SmartComboBox cboService;
        private AtiqsControlLibrary.SmartLabel lblService;
        private AtiqsControlLibrary.SmartLabel lblEndDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private AtiqsControlLibrary.SmartLabel lblAppointmentTimeInterval;
        private System.Windows.Forms.NumericUpDown txtTimeInterval;
        private AtiqsControlLibrary.SmartLabel lblDoctorID;
        private AtiqsControlLibrary.SmartLabel lblUnitID;
        private AtiqsControlLibrary.SmartLabel lblDeptID;
        private AtiqsControlLibrary.SmartComboBox cboDoctorID;
        private AtiqsControlLibrary.SmartComboBox cboUnitID;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentID;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvDutyTimings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip mnDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblFrom;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartCheckedListBox chkWeekDays;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteCalendar;
        private System.Windows.Forms.Button btnModify;
        private AtiqsControlLibrary.SmartComboBox cboInterval;
        private System.Windows.Forms.Panel panel3;
    }
}
