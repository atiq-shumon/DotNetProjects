namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    partial class frmEmployeeOthersReport
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
            this.rdoConfDueDate = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoResigDate = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoJoiningDate = new AtiqsControlLibrary.SmartRadioButton();
            this.gbSelectOptions = new System.Windows.Forms.GroupBox();
            this.rdoGrpDeptUnit = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptGrp = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAll = new AtiqsControlLibrary.SmartRadioButton();
            this.gbDept = new System.Windows.Forms.GroupBox();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.lblDropType = new AtiqsControlLibrary.SmartLabel();
            this.cboDropType = new AtiqsControlLibrary.SmartComboBox();
            this.rdoEmpListByDropType = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.gbSelectOptions.SuspendLayout();
            this.gbDept.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(757, 560);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(643, 560);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(276, 9);
            this.frmLabel.Size = new System.Drawing.Size(313, 32);
            this.frmLabel.Text = "Employee Others Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblDropType);
            this.pnlMain.Controls.Add(this.cboDropType);
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.gbDept);
            this.pnlMain.Controls.Add(this.gbSelectOptions);
            this.pnlMain.Controls.Add(this.rdoDepartment);
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Size = new System.Drawing.Size(871, 498);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(871, 57);
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoEmpListByDropType);
            this.rdoDepartment.Controls.Add(this.rdoConfDueDate);
            this.rdoDepartment.Controls.Add(this.rdoResigDate);
            this.rdoDepartment.Controls.Add(this.rdoJoiningDate);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(1, 2);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(328, 491);
            this.rdoDepartment.TabIndex = 22;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoConfDueDate
            // 
            this.rdoConfDueDate.AutoSize = true;
            this.rdoConfDueDate.BackColor = System.Drawing.Color.Transparent;
            this.rdoConfDueDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoConfDueDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoConfDueDate.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoConfDueDate.ForeColor = System.Drawing.Color.Gray;
            this.rdoConfDueDate.Location = new System.Drawing.Point(6, 89);
            this.rdoConfDueDate.Name = "rdoConfDueDate";
            this.rdoConfDueDate.Size = new System.Drawing.Size(299, 22);
            this.rdoConfDueDate.TabIndex = 6;
            this.rdoConfDueDate.Text = "Employee List by Confirmation Due Date";
            this.rdoConfDueDate.UseVisualStyleBackColor = false;
            this.rdoConfDueDate.CheckedChanged += new System.EventHandler(this.rdoConfDueDate_CheckedChanged);
            // 
            // rdoResigDate
            // 
            this.rdoResigDate.AutoSize = true;
            this.rdoResigDate.BackColor = System.Drawing.Color.Transparent;
            this.rdoResigDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoResigDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoResigDate.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoResigDate.ForeColor = System.Drawing.Color.Gray;
            this.rdoResigDate.Location = new System.Drawing.Point(6, 56);
            this.rdoResigDate.Name = "rdoResigDate";
            this.rdoResigDate.Size = new System.Drawing.Size(259, 22);
            this.rdoResigDate.TabIndex = 5;
            this.rdoResigDate.Text = "Employee List By Resignation Date";
            this.rdoResigDate.UseVisualStyleBackColor = false;
            this.rdoResigDate.CheckedChanged += new System.EventHandler(this.rdoResigDate_CheckedChanged);
            // 
            // rdoJoiningDate
            // 
            this.rdoJoiningDate.AutoSize = true;
            this.rdoJoiningDate.BackColor = System.Drawing.Color.Transparent;
            this.rdoJoiningDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoJoiningDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoJoiningDate.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoJoiningDate.ForeColor = System.Drawing.Color.Gray;
            this.rdoJoiningDate.Location = new System.Drawing.Point(6, 23);
            this.rdoJoiningDate.Name = "rdoJoiningDate";
            this.rdoJoiningDate.Size = new System.Drawing.Size(230, 22);
            this.rdoJoiningDate.TabIndex = 4;
            this.rdoJoiningDate.Text = "Employee List By Joining Date";
            this.rdoJoiningDate.UseVisualStyleBackColor = false;
            this.rdoJoiningDate.CheckedChanged += new System.EventHandler(this.rdoJoiningDate_CheckedChanged);
            // 
            // gbSelectOptions
            // 
            this.gbSelectOptions.Controls.Add(this.rdoGrpDeptUnit);
            this.gbSelectOptions.Controls.Add(this.rdoDeptGrp);
            this.gbSelectOptions.Controls.Add(this.rdoAll);
            this.gbSelectOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbSelectOptions.Location = new System.Drawing.Point(341, 52);
            this.gbSelectOptions.Name = "gbSelectOptions";
            this.gbSelectOptions.Size = new System.Drawing.Size(521, 60);
            this.gbSelectOptions.TabIndex = 228;
            this.gbSelectOptions.TabStop = false;
            this.gbSelectOptions.Text = "Select Options";
            // 
            // rdoGrpDeptUnit
            // 
            this.rdoGrpDeptUnit.AutoSize = true;
            this.rdoGrpDeptUnit.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoGrpDeptUnit.ForeColor = System.Drawing.Color.Gray;
            this.rdoGrpDeptUnit.Location = new System.Drawing.Point(275, 24);
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
            this.rdoDeptGrp.Location = new System.Drawing.Point(105, 24);
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
            this.rdoAll.Location = new System.Drawing.Point(17, 24);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(44, 22);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
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
            this.gbDept.Location = new System.Drawing.Point(341, 118);
            this.gbDept.Name = "gbDept";
            this.gbDept.Size = new System.Drawing.Size(521, 136);
            this.gbDept.TabIndex = 229;
            this.gbDept.TabStop = false;
            this.gbDept.Text = "Department";
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(275, 40);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(235, 26);
            this.cboDepartmentGroup.TabIndex = 218;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(276, 74);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(38, 13);
            this.smartLabel5.TabIndex = 224;
            this.smartLabel5.Text = "Unit :";
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(17, 19);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(112, 13);
            this.smartLabel21.TabIndex = 219;
            this.smartLabel21.Text = "Department Type :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(275, 95);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(236, 26);
            this.cboUnit.TabIndex = 222;
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(17, 40);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(228, 26);
            this.cboDepartmentType.TabIndex = 217;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(19, 74);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(80, 13);
            this.smartLabel7.TabIndex = 223;
            this.smartLabel7.Text = "Department :";
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(272, 19);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(118, 13);
            this.smartLabel22.TabIndex = 220;
            this.smartLabel22.Text = "Department Group :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(17, 95);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(228, 26);
            this.cboDepartment.TabIndex = 221;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Location = new System.Drawing.Point(341, 264);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(521, 92);
            this.gbDateRange.TabIndex = 230;
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
            this.lvlStartDate.Location = new System.Drawing.Point(272, 26);
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
            this.lvlEndDate.Location = new System.Drawing.Point(404, 26);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(62, 15);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date :";
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(407, 46);
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
            this.dtStartDate.Location = new System.Drawing.Point(275, 46);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(115, 24);
            this.dtStartDate.TabIndex = 0;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblDropType
            // 
            this.lblDropType.AutoSize = true;
            this.lblDropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDropType.Location = new System.Drawing.Point(356, 4);
            this.lblDropType.Name = "lblDropType";
            this.lblDropType.Size = new System.Drawing.Size(74, 13);
            this.lblDropType.TabIndex = 276;
            this.lblDropType.Text = "Drop Type :";
            // 
            // cboDropType
            // 
            this.cboDropType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDropType.ForeColor = System.Drawing.Color.Blue;
            this.cboDropType.FormattingEnabled = true;
            this.cboDropType.Location = new System.Drawing.Point(358, 21);
            this.cboDropType.Name = "cboDropType";
            this.cboDropType.Size = new System.Drawing.Size(228, 26);
            this.cboDropType.TabIndex = 275;
            // 
            // rdoEmpListByDropType
            // 
            this.rdoEmpListByDropType.AutoSize = true;
            this.rdoEmpListByDropType.BackColor = System.Drawing.Color.Transparent;
            this.rdoEmpListByDropType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEmpListByDropType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmpListByDropType.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoEmpListByDropType.ForeColor = System.Drawing.Color.Gray;
            this.rdoEmpListByDropType.Location = new System.Drawing.Point(6, 122);
            this.rdoEmpListByDropType.Name = "rdoEmpListByDropType";
            this.rdoEmpListByDropType.Size = new System.Drawing.Size(261, 22);
            this.rdoEmpListByDropType.TabIndex = 7;
            this.rdoEmpListByDropType.Text = "Employee List by Others Drop Type";
            this.rdoEmpListByDropType.UseVisualStyleBackColor = false;
            this.rdoEmpListByDropType.CheckedChanged += new System.EventHandler(this.rdoEmpListByDropType_CheckedChanged);
            // 
            // frmEmployeeOthersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(871, 626);
            this.Name = "frmEmployeeOthersReport";
            this.Load += new System.EventHandler(this.frmEmployeeOthersReport_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.rdoDepartment.ResumeLayout(false);
            this.rdoDepartment.PerformLayout();
            this.gbSelectOptions.ResumeLayout(false);
            this.gbSelectOptions.PerformLayout();
            this.gbDept.ResumeLayout(false);
            this.gbDept.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rdoDepartment;
        private AtiqsControlLibrary.SmartRadioButton rdoConfDueDate;
        private AtiqsControlLibrary.SmartRadioButton rdoResigDate;
        private AtiqsControlLibrary.SmartRadioButton rdoJoiningDate;
        private System.Windows.Forms.GroupBox gbSelectOptions;
        private AtiqsControlLibrary.SmartRadioButton rdoGrpDeptUnit;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptGrp;
        private AtiqsControlLibrary.SmartRadioButton rdoAll;
        private System.Windows.Forms.GroupBox gbDept;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartLabel lblDropType;
        private AtiqsControlLibrary.SmartComboBox cboDropType;
        private AtiqsControlLibrary.SmartRadioButton rdoEmpListByDropType;
    }
}
