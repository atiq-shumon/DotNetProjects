namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    partial class frmAttendanceReport
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
            this.rdoDepartment = new System.Windows.Forms.GroupBox();
            this.rdoDailyLeave = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDailyAbsent = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoMonthAttn = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDailyAttendance = new AtiqsControlLibrary.SmartRadioButton();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.gbDept = new System.Windows.Forms.GroupBox();
            this.gbEmp = new System.Windows.Forms.GroupBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmpID = new AtiqsControlLibrary.SmartNumericTextBox();
            this.gbSelectOptions = new System.Windows.Forms.GroupBox();
            this.rdoGrpDeptUnit = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptGrp = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAll = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDailyLate = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.gbDept.SuspendLayout();
            this.gbEmp.SuspendLayout();
            this.gbSelectOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(683, 550);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(569, 550);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(274, 9);
            this.frmLabel.Size = new System.Drawing.Size(244, 32);
            this.frmLabel.Text = "Attendance Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbSelectOptions);
            this.pnlMain.Controls.Add(this.gbEmp);
            this.pnlMain.Controls.Add(this.gbDept);
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.rdoDepartment);
            this.pnlMain.Size = new System.Drawing.Size(827, 491);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(797, 57);
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoDailyLate);
            this.rdoDepartment.Controls.Add(this.rdoDailyLeave);
            this.rdoDepartment.Controls.Add(this.rdoDailyAbsent);
            this.rdoDepartment.Controls.Add(this.rdoMonthAttn);
            this.rdoDepartment.Controls.Add(this.rdoDailyAttendance);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(29, 3);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(277, 487);
            this.rdoDepartment.TabIndex = 21;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoDailyLeave
            // 
            this.rdoDailyLeave.AutoSize = true;
            this.rdoDailyLeave.BackColor = System.Drawing.Color.Transparent;
            this.rdoDailyLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDailyLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDailyLeave.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDailyLeave.ForeColor = System.Drawing.Color.Gray;
            this.rdoDailyLeave.Location = new System.Drawing.Point(6, 155);
            this.rdoDailyLeave.Name = "rdoDailyLeave";
            this.rdoDailyLeave.Size = new System.Drawing.Size(152, 22);
            this.rdoDailyLeave.TabIndex = 7;
            this.rdoDailyLeave.Text = "Daily Leave Report";
            this.rdoDailyLeave.UseVisualStyleBackColor = false;
            this.rdoDailyLeave.CheckedChanged += new System.EventHandler(this.rdoDailyLeave_CheckedChanged);
            // 
            // rdoDailyAbsent
            // 
            this.rdoDailyAbsent.AutoSize = true;
            this.rdoDailyAbsent.BackColor = System.Drawing.Color.Transparent;
            this.rdoDailyAbsent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDailyAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDailyAbsent.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDailyAbsent.ForeColor = System.Drawing.Color.Gray;
            this.rdoDailyAbsent.Location = new System.Drawing.Point(6, 89);
            this.rdoDailyAbsent.Name = "rdoDailyAbsent";
            this.rdoDailyAbsent.Size = new System.Drawing.Size(158, 22);
            this.rdoDailyAbsent.TabIndex = 6;
            this.rdoDailyAbsent.Text = "Daily Absent Report";
            this.rdoDailyAbsent.UseVisualStyleBackColor = false;
            this.rdoDailyAbsent.CheckedChanged += new System.EventHandler(this.rdoDailyAbsent_CheckedChanged);
            // 
            // rdoMonthAttn
            // 
            this.rdoMonthAttn.AutoSize = true;
            this.rdoMonthAttn.BackColor = System.Drawing.Color.Transparent;
            this.rdoMonthAttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMonthAttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMonthAttn.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoMonthAttn.ForeColor = System.Drawing.Color.Gray;
            this.rdoMonthAttn.Location = new System.Drawing.Point(6, 56);
            this.rdoMonthAttn.Name = "rdoMonthAttn";
            this.rdoMonthAttn.Size = new System.Drawing.Size(210, 22);
            this.rdoMonthAttn.TabIndex = 5;
            this.rdoMonthAttn.Text = "Monthly Attendance Report";
            this.rdoMonthAttn.UseVisualStyleBackColor = false;
            this.rdoMonthAttn.CheckedChanged += new System.EventHandler(this.rdoMonthAttn_CheckedChanged);
            // 
            // rdoDailyAttendance
            // 
            this.rdoDailyAttendance.AutoSize = true;
            this.rdoDailyAttendance.BackColor = System.Drawing.Color.Transparent;
            this.rdoDailyAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDailyAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDailyAttendance.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDailyAttendance.ForeColor = System.Drawing.Color.Gray;
            this.rdoDailyAttendance.Location = new System.Drawing.Point(6, 23);
            this.rdoDailyAttendance.Name = "rdoDailyAttendance";
            this.rdoDailyAttendance.Size = new System.Drawing.Size(188, 22);
            this.rdoDailyAttendance.TabIndex = 4;
            this.rdoDailyAttendance.Text = "Daily Attendance Report";
            this.rdoDailyAttendance.UseVisualStyleBackColor = false;
            this.rdoDailyAttendance.CheckedChanged += new System.EventHandler(this.rdoDailyAttendance_CheckedChanged);
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Location = new System.Drawing.Point(309, 283);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(511, 92);
            this.gbDateRange.TabIndex = 216;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "DateRange";
            // 
            // cboDateType
            // 
            this.cboDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDateType.ForeColor = System.Drawing.Color.Blue;
            this.cboDateType.FormattingEnabled = true;
            this.cboDateType.Items.AddRange(new object[] {
            "Today",
            "Last One Week",
            "Last One Month",
            "Last Three Month",
            "Last Six Month",
            "Last One Year"});
            this.cboDateType.Location = new System.Drawing.Point(17, 44);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(228, 26);
            this.cboDateType.TabIndex = 5;
            this.cboDateType.SelectedIndexChanged += new System.EventHandler(this.cboDateType_SelectedIndexChanged);
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlDate.Location = new System.Drawing.Point(15, 24);
            this.lvlDate.Name = "lvlDate";
            this.lvlDate.Size = new System.Drawing.Size(77, 15);
            this.lvlDate.TabIndex = 4;
            this.lvlDate.Text = "Date Range :";
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(257, 24);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(70, 15);
            this.lvlStartDate.TabIndex = 2;
            this.lvlStartDate.Text = "Start Date :";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(389, 24);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(62, 15);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date :";
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(392, 44);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(103, 24);
            this.dtEndDate.TabIndex = 1;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtStartDate
            // 
            this.dtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(260, 44);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(115, 24);
            this.dtStartDate.TabIndex = 0;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(260, 36);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(235, 26);
            this.cboDepartmentGroup.TabIndex = 218;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(257, 15);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(118, 13);
            this.smartLabel22.TabIndex = 220;
            this.smartLabel22.Text = "Department Group :";
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(17, 36);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(228, 26);
            this.cboDepartmentType.TabIndex = 217;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(17, 15);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(112, 13);
            this.smartLabel21.TabIndex = 219;
            this.smartLabel21.Text = "Department Type :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(261, 70);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(38, 13);
            this.smartLabel5.TabIndex = 224;
            this.smartLabel5.Text = "Unit :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(260, 91);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(236, 26);
            this.cboUnit.TabIndex = 222;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(19, 70);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(80, 13);
            this.smartLabel7.TabIndex = 223;
            this.smartLabel7.Text = "Department :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(17, 91);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(228, 26);
            this.cboDepartment.TabIndex = 221;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // gbDept
            // 
            this.gbDept.Controls.Add(this.cboDepartmentGroup);
            this.gbDept.Controls.Add(this.smartLabel5);
            this.gbDept.Controls.Add(this.smartLabel21);
            this.gbDept.Controls.Add(this.cboUnit);
            this.gbDept.Controls.Add(this.cboDepartmentType);
            this.gbDept.Controls.Add(this.smartLabel7);
            this.gbDept.Controls.Add(this.smartLabel22);
            this.gbDept.Controls.Add(this.cboDepartment);
            this.gbDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbDept.Location = new System.Drawing.Point(309, 68);
            this.gbDept.Name = "gbDept";
            this.gbDept.Size = new System.Drawing.Size(511, 136);
            this.gbDept.TabIndex = 225;
            this.gbDept.TabStop = false;
            this.gbDept.Text = "Department";
            // 
            // gbEmp
            // 
            this.gbEmp.Controls.Add(this.smartLabel1);
            this.gbEmp.Controls.Add(this.txtEmpID);
            this.gbEmp.Location = new System.Drawing.Point(309, 208);
            this.gbEmp.Name = "gbEmp";
            this.gbEmp.Size = new System.Drawing.Size(511, 70);
            this.gbEmp.TabIndex = 226;
            this.gbEmp.TabStop = false;
            this.gbEmp.Text = "Employee";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(17, 17);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(81, 15);
            this.smartLabel1.TabIndex = 6;
            this.smartLabel1.Text = "Employee ID :";
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(17, 36);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(228, 24);
            this.txtEmpID.TabIndex = 0;
            // 
            // gbSelectOptions
            // 
            this.gbSelectOptions.Controls.Add(this.rdoGrpDeptUnit);
            this.gbSelectOptions.Controls.Add(this.rdoDeptGrp);
            this.gbSelectOptions.Controls.Add(this.rdoAll);
            this.gbSelectOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbSelectOptions.Location = new System.Drawing.Point(309, 4);
            this.gbSelectOptions.Name = "gbSelectOptions";
            this.gbSelectOptions.Size = new System.Drawing.Size(511, 60);
            this.gbSelectOptions.TabIndex = 227;
            this.gbSelectOptions.TabStop = false;
            this.gbSelectOptions.Text = "Select Options";
            // 
            // rdoGrpDeptUnit
            // 
            this.rdoGrpDeptUnit.AutoSize = true;
            this.rdoGrpDeptUnit.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoGrpDeptUnit.ForeColor = System.Drawing.Color.Gray;
            this.rdoGrpDeptUnit.Location = new System.Drawing.Point(262, 22);
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
            this.rdoDeptGrp.Location = new System.Drawing.Point(98, 22);
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
            this.rdoAll.Location = new System.Drawing.Point(22, 22);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(44, 22);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoDailyLate
            // 
            this.rdoDailyLate.AutoSize = true;
            this.rdoDailyLate.BackColor = System.Drawing.Color.Transparent;
            this.rdoDailyLate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDailyLate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDailyLate.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDailyLate.ForeColor = System.Drawing.Color.Gray;
            this.rdoDailyLate.Location = new System.Drawing.Point(6, 122);
            this.rdoDailyLate.Name = "rdoDailyLate";
            this.rdoDailyLate.Size = new System.Drawing.Size(142, 22);
            this.rdoDailyLate.TabIndex = 8;
            this.rdoDailyLate.Text = "Daily Late Report";
            this.rdoDailyLate.UseVisualStyleBackColor = false;
            this.rdoDailyLate.CheckedChanged += new System.EventHandler(this.rdoDailyLate_CheckedChanged);
            // 
            // frmAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(797, 615);
            this.Name = "frmAttendanceReport";
            this.Load += new System.EventHandler(this.frmDailyAttendance_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.rdoDepartment.ResumeLayout(false);
            this.rdoDepartment.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.gbDept.ResumeLayout(false);
            this.gbDept.PerformLayout();
            this.gbEmp.ResumeLayout(false);
            this.gbEmp.PerformLayout();
            this.gbSelectOptions.ResumeLayout(false);
            this.gbSelectOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rdoDepartment;
        private AtiqsControlLibrary.SmartRadioButton rdoDailyAttendance;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private System.Windows.Forms.GroupBox gbDept;
        private AtiqsControlLibrary.SmartRadioButton rdoMonthAttn;
        private System.Windows.Forms.GroupBox gbEmp;
        private AtiqsControlLibrary.SmartNumericTextBox txtEmpID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartRadioButton rdoDailyAbsent;
        private AtiqsControlLibrary.SmartRadioButton rdoDailyLeave;
        private System.Windows.Forms.GroupBox gbSelectOptions;
        private AtiqsControlLibrary.SmartRadioButton rdoAll;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptGrp;
        private AtiqsControlLibrary.SmartRadioButton rdoGrpDeptUnit;
        private AtiqsControlLibrary.SmartRadioButton rdoDailyLate;
    }
}
