namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    partial class frmPayrollReportManager
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
            this.rdoPayrollDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.cboMonth = new AtiqsControlLibrary.SmartComboBox();
            this.rdoDepartment = new System.Windows.Forms.GroupBox();
            this.rdoEmployeeUnderSalary = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPayrollSummary = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPaySlip = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoSalaryStatement = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptWisePayroll = new AtiqsControlLibrary.SmartRadioButton();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.gbSelectOptions = new System.Windows.Forms.GroupBox();
            this.rdoGrpDeptUnit = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptGrp = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAll = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.txtEmpID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.pnlDepartment = new System.Windows.Forms.Panel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.lblMonth = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.gbSelectOptions.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlDepartment.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(662, 518);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(548, 518);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(232, 9);
            this.frmLabel.Size = new System.Drawing.Size(307, 32);
            this.frmLabel.Text = "Payroll Report Manager";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.rdoDepartment);
            this.pnlMain.Location = new System.Drawing.Point(0, 53);
            this.pnlMain.Size = new System.Drawing.Size(780, 459);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(779, 57);
            // 
            // rdoPayrollDetails
            // 
            this.rdoPayrollDetails.AutoSize = true;
            this.rdoPayrollDetails.BackColor = System.Drawing.Color.Transparent;
            this.rdoPayrollDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPayrollDetails.Enabled = false;
            this.rdoPayrollDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPayrollDetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPayrollDetails.ForeColor = System.Drawing.Color.Gray;
            this.rdoPayrollDetails.Location = new System.Drawing.Point(8, 59);
            this.rdoPayrollDetails.Name = "rdoPayrollDetails";
            this.rdoPayrollDetails.Size = new System.Drawing.Size(121, 22);
            this.rdoPayrollDetails.TabIndex = 24;
            this.rdoPayrollDetails.Text = "Payroll Details";
            this.rdoPayrollDetails.UseVisualStyleBackColor = false;
            this.rdoPayrollDetails.Click += new System.EventHandler(this.rdoPayrollDetails_Click);
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.ForeColor = System.Drawing.Color.Blue;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(103, 26);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(104, 26);
            this.cboMonth.TabIndex = 22;
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoEmployeeUnderSalary);
            this.rdoDepartment.Controls.Add(this.rdoPayrollSummary);
            this.rdoDepartment.Controls.Add(this.rdoPaySlip);
            this.rdoDepartment.Controls.Add(this.rdoSalaryStatement);
            this.rdoDepartment.Controls.Add(this.rdoDeptWisePayroll);
            this.rdoDepartment.Controls.Add(this.rdoPayrollDetails);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(3, 18);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(282, 430);
            this.rdoDepartment.TabIndex = 26;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoEmployeeUnderSalary
            // 
            this.rdoEmployeeUnderSalary.AutoSize = true;
            this.rdoEmployeeUnderSalary.BackColor = System.Drawing.Color.Transparent;
            this.rdoEmployeeUnderSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEmployeeUnderSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmployeeUnderSalary.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoEmployeeUnderSalary.ForeColor = System.Drawing.Color.Gray;
            this.rdoEmployeeUnderSalary.Location = new System.Drawing.Point(8, 24);
            this.rdoEmployeeUnderSalary.Name = "rdoEmployeeUnderSalary";
            this.rdoEmployeeUnderSalary.Size = new System.Drawing.Size(183, 22);
            this.rdoEmployeeUnderSalary.TabIndex = 29;
            this.rdoEmployeeUnderSalary.Text = "Employee Under Salary";
            this.rdoEmployeeUnderSalary.UseVisualStyleBackColor = false;
            this.rdoEmployeeUnderSalary.Click += new System.EventHandler(this.rdoEmployeeUnderSalary_Click);
            // 
            // rdoPayrollSummary
            // 
            this.rdoPayrollSummary.AutoSize = true;
            this.rdoPayrollSummary.BackColor = System.Drawing.Color.Transparent;
            this.rdoPayrollSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPayrollSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPayrollSummary.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPayrollSummary.ForeColor = System.Drawing.Color.Gray;
            this.rdoPayrollSummary.Location = new System.Drawing.Point(8, 129);
            this.rdoPayrollSummary.Name = "rdoPayrollSummary";
            this.rdoPayrollSummary.Size = new System.Drawing.Size(143, 22);
            this.rdoPayrollSummary.TabIndex = 28;
            this.rdoPayrollSummary.Text = "Payroll Summary";
            this.rdoPayrollSummary.UseVisualStyleBackColor = false;
            this.rdoPayrollSummary.Click += new System.EventHandler(this.rdoPayrollSummary_Click);
            // 
            // rdoPaySlip
            // 
            this.rdoPaySlip.AutoSize = true;
            this.rdoPaySlip.BackColor = System.Drawing.Color.Transparent;
            this.rdoPaySlip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPaySlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPaySlip.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPaySlip.ForeColor = System.Drawing.Color.Gray;
            this.rdoPaySlip.Location = new System.Drawing.Point(8, 199);
            this.rdoPaySlip.Name = "rdoPaySlip";
            this.rdoPaySlip.Size = new System.Drawing.Size(78, 22);
            this.rdoPaySlip.TabIndex = 27;
            this.rdoPaySlip.Text = "Pay Slip";
            this.rdoPaySlip.UseVisualStyleBackColor = false;
            this.rdoPaySlip.Click += new System.EventHandler(this.rdoPaySlip_Click);
            // 
            // rdoSalaryStatement
            // 
            this.rdoSalaryStatement.AutoSize = true;
            this.rdoSalaryStatement.BackColor = System.Drawing.Color.Transparent;
            this.rdoSalaryStatement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSalaryStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoSalaryStatement.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoSalaryStatement.ForeColor = System.Drawing.Color.Gray;
            this.rdoSalaryStatement.Location = new System.Drawing.Point(8, 164);
            this.rdoSalaryStatement.Name = "rdoSalaryStatement";
            this.rdoSalaryStatement.Size = new System.Drawing.Size(205, 22);
            this.rdoSalaryStatement.TabIndex = 26;
            this.rdoSalaryStatement.Text = "Salary Statement For Bank";
            this.rdoSalaryStatement.UseVisualStyleBackColor = false;
            this.rdoSalaryStatement.CheckedChanged += new System.EventHandler(this.rdoSalaryStatement_CheckedChanged);
            // 
            // rdoDeptWisePayroll
            // 
            this.rdoDeptWisePayroll.AutoSize = true;
            this.rdoDeptWisePayroll.BackColor = System.Drawing.Color.Transparent;
            this.rdoDeptWisePayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDeptWisePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDeptWisePayroll.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDeptWisePayroll.ForeColor = System.Drawing.Color.Gray;
            this.rdoDeptWisePayroll.Location = new System.Drawing.Point(8, 94);
            this.rdoDeptWisePayroll.Name = "rdoDeptWisePayroll";
            this.rdoDeptWisePayroll.Size = new System.Drawing.Size(241, 22);
            this.rdoDeptWisePayroll.TabIndex = 25;
            this.rdoDeptWisePayroll.Text = "Department Wise Payroll Details";
            this.rdoDeptWisePayroll.UseVisualStyleBackColor = false;
            this.rdoDeptWisePayroll.Click += new System.EventHandler(this.rdoDeptWisePayroll_Click);
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.gbSelectOptions);
            this.gbInformationControlls.Controls.Add(this.pnlEmployee);
            this.gbInformationControlls.Controls.Add(this.pnlDepartment);
            this.gbInformationControlls.Controls.Add(this.pnlMonth);
            this.gbInformationControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationControlls.Location = new System.Drawing.Point(303, 18);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(472, 430);
            this.gbInformationControlls.TabIndex = 27;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // gbSelectOptions
            // 
            this.gbSelectOptions.Controls.Add(this.rdoGrpDeptUnit);
            this.gbSelectOptions.Controls.Add(this.rdoDeptGrp);
            this.gbSelectOptions.Controls.Add(this.rdoAll);
            this.gbSelectOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbSelectOptions.Location = new System.Drawing.Point(13, 20);
            this.gbSelectOptions.Name = "gbSelectOptions";
            this.gbSelectOptions.Size = new System.Drawing.Size(448, 44);
            this.gbSelectOptions.TabIndex = 228;
            this.gbSelectOptions.TabStop = false;
            this.gbSelectOptions.Visible = false;
            // 
            // rdoGrpDeptUnit
            // 
            this.rdoGrpDeptUnit.AutoSize = true;
            this.rdoGrpDeptUnit.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoGrpDeptUnit.ForeColor = System.Drawing.Color.Gray;
            this.rdoGrpDeptUnit.Location = new System.Drawing.Point(224, 12);
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
            this.rdoDeptGrp.Location = new System.Drawing.Point(75, 12);
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
            this.rdoAll.Location = new System.Drawing.Point(15, 12);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(44, 22);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.txtEmpID);
            this.pnlEmployee.Controls.Add(this.smartLabel3);
            this.pnlEmployee.Location = new System.Drawing.Point(231, 71);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(230, 58);
            this.pnlEmployee.TabIndex = 29;
            this.pnlEmployee.Visible = false;
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(7, 26);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(90, 24);
            this.txtEmpID.TabIndex = 7;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(4, 6);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(81, 15);
            this.smartLabel3.TabIndex = 6;
            this.smartLabel3.Text = "Employee ID :";
            // 
            // pnlDepartment
            // 
            this.pnlDepartment.Controls.Add(this.smartLabel5);
            this.pnlDepartment.Controls.Add(this.cboUnit);
            this.pnlDepartment.Controls.Add(this.smartLabel2);
            this.pnlDepartment.Controls.Add(this.cboDepartment);
            this.pnlDepartment.Controls.Add(this.cboDepartmentGroup);
            this.pnlDepartment.Controls.Add(this.smartLabel22);
            this.pnlDepartment.Controls.Add(this.cboDepartmentType);
            this.pnlDepartment.Controls.Add(this.smartLabel21);
            this.pnlDepartment.Location = new System.Drawing.Point(13, 138);
            this.pnlDepartment.Name = "pnlDepartment";
            this.pnlDepartment.Size = new System.Drawing.Size(448, 137);
            this.pnlDepartment.TabIndex = 29;
            this.pnlDepartment.Visible = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(222, 70);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(38, 13);
            this.smartLabel5.TabIndex = 217;
            this.smartLabel5.Text = "Unit :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(225, 92);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(211, 26);
            this.cboUnit.TabIndex = 216;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(20, 70);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(78, 15);
            this.smartLabel2.TabIndex = 6;
            this.smartLabel2.Text = "Department :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(18, 92);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(194, 26);
            this.cboDepartment.TabIndex = 22;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(224, 33);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(212, 26);
            this.cboDepartmentGroup.TabIndex = 213;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(221, 13);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(118, 13);
            this.smartLabel22.TabIndex = 215;
            this.smartLabel22.Text = "Department Group :";
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(18, 33);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(194, 26);
            this.cboDepartmentType.TabIndex = 212;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(18, 13);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(112, 13);
            this.smartLabel21.TabIndex = 214;
            this.smartLabel21.Text = "Department Type :";
            // 
            // pnlMonth
            // 
            this.pnlMonth.Controls.Add(this.smartLabel6);
            this.pnlMonth.Controls.Add(this.cboYear);
            this.pnlMonth.Controls.Add(this.cboMonth);
            this.pnlMonth.Controls.Add(this.lblMonth);
            this.pnlMonth.Location = new System.Drawing.Point(13, 71);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(212, 61);
            this.pnlMonth.TabIndex = 28;
            this.pnlMonth.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(10, 6);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(41, 13);
            this.smartLabel6.TabIndex = 214;
            this.smartLabel6.Text = "Year :";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(13, 26);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(85, 26);
            this.cboYear.TabIndex = 213;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(100, 6);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(49, 15);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Month :";
            // 
            // frmPayrollReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(779, 584);
            this.Name = "frmPayrollReportManager";
            this.Load += new System.EventHandler(this.frmPayrollReportManager_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.rdoDepartment.ResumeLayout(false);
            this.rdoDepartment.PerformLayout();
            this.gbInformationControlls.ResumeLayout(false);
            this.gbSelectOptions.ResumeLayout(false);
            this.gbSelectOptions.PerformLayout();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.pnlDepartment.ResumeLayout(false);
            this.pnlDepartment.PerformLayout();
            this.pnlMonth.ResumeLayout(false);
            this.pnlMonth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartRadioButton rdoPayrollDetails;
        private AtiqsControlLibrary.SmartComboBox cboMonth;
        private System.Windows.Forms.GroupBox rdoDepartment;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartLabel lblMonth;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.Panel pnlDepartment;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptWisePayroll;
        private AtiqsControlLibrary.SmartRadioButton rdoSalaryStatement;
        private AtiqsControlLibrary.SmartRadioButton rdoPaySlip;
        private System.Windows.Forms.Panel pnlEmployee;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtEmpID;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartRadioButton rdoPayrollSummary;
        private AtiqsControlLibrary.SmartRadioButton rdoEmployeeUnderSalary;
        private System.Windows.Forms.GroupBox gbSelectOptions;
        private AtiqsControlLibrary.SmartRadioButton rdoGrpDeptUnit;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptGrp;
        private AtiqsControlLibrary.SmartRadioButton rdoAll;
    }
}
