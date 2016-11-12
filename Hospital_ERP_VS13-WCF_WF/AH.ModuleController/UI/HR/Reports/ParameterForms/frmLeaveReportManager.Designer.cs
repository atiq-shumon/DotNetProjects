namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    partial class frmLeaveReportManager
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
            this.rdoDeptWiseLeaveReq = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoHolidayCalender = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoleaveTemplate = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoEmpLeaveRegister = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptWiseLeave = new AtiqsControlLibrary.SmartRadioButton();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.gbSelectOptions = new System.Windows.Forms.GroupBox();
            this.rdoGrpDeptUnit = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptGrp = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAll = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlDepartment = new System.Windows.Forms.Panel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.pnlYear = new System.Windows.Forms.Panel();
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.lblyear = new AtiqsControlLibrary.SmartLabel();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.txtEmpId = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlSerial = new System.Windows.Forms.Panel();
            this.txtSerial = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.gbSelectOptions.SuspendLayout();
            this.pnlDepartment.SuspendLayout();
            this.pnlYear.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(816, 563);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(702, 563);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(296, 8);
            this.frmLabel.Size = new System.Drawing.Size(292, 32);
            this.frmLabel.Text = "Leave Report Manager";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.rdoDepartment);
            this.pnlMain.Location = new System.Drawing.Point(0, 53);
            this.pnlMain.Size = new System.Drawing.Size(930, 504);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(930, 57);
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoDeptWiseLeaveReq);
            this.rdoDepartment.Controls.Add(this.rdoHolidayCalender);
            this.rdoDepartment.Controls.Add(this.rdoleaveTemplate);
            this.rdoDepartment.Controls.Add(this.rdoEmpLeaveRegister);
            this.rdoDepartment.Controls.Add(this.rdoDeptWiseLeave);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(3, 16);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(343, 483);
            this.rdoDepartment.TabIndex = 27;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoDeptWiseLeaveReq
            // 
            this.rdoDeptWiseLeaveReq.AutoSize = true;
            this.rdoDeptWiseLeaveReq.BackColor = System.Drawing.Color.Transparent;
            this.rdoDeptWiseLeaveReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDeptWiseLeaveReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDeptWiseLeaveReq.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDeptWiseLeaveReq.ForeColor = System.Drawing.Color.Gray;
            this.rdoDeptWiseLeaveReq.Location = new System.Drawing.Point(6, 92);
            this.rdoDeptWiseLeaveReq.Name = "rdoDeptWiseLeaveReq";
            this.rdoDeptWiseLeaveReq.Size = new System.Drawing.Size(263, 22);
            this.rdoDeptWiseLeaveReq.TabIndex = 29;
            this.rdoDeptWiseLeaveReq.Text = "Department Wise Leave Requisition";
            this.rdoDeptWiseLeaveReq.UseVisualStyleBackColor = false;
            this.rdoDeptWiseLeaveReq.CheckedChanged += new System.EventHandler(this.rdoDeptWiseLeaveReq_CheckedChanged);
            // 
            // rdoHolidayCalender
            // 
            this.rdoHolidayCalender.AutoSize = true;
            this.rdoHolidayCalender.BackColor = System.Drawing.Color.Transparent;
            this.rdoHolidayCalender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoHolidayCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoHolidayCalender.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoHolidayCalender.ForeColor = System.Drawing.Color.Gray;
            this.rdoHolidayCalender.Location = new System.Drawing.Point(6, 126);
            this.rdoHolidayCalender.Name = "rdoHolidayCalender";
            this.rdoHolidayCalender.Size = new System.Drawing.Size(188, 22);
            this.rdoHolidayCalender.TabIndex = 28;
            this.rdoHolidayCalender.Text = "Yearly Holiday Calender";
            this.rdoHolidayCalender.UseVisualStyleBackColor = false;
            this.rdoHolidayCalender.CheckedChanged += new System.EventHandler(this.rdoHolidayCalender_CheckedChanged);
            // 
            // rdoleaveTemplate
            // 
            this.rdoleaveTemplate.AutoSize = true;
            this.rdoleaveTemplate.BackColor = System.Drawing.Color.Transparent;
            this.rdoleaveTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoleaveTemplate.Enabled = false;
            this.rdoleaveTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoleaveTemplate.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoleaveTemplate.ForeColor = System.Drawing.Color.Gray;
            this.rdoleaveTemplate.Location = new System.Drawing.Point(6, 160);
            this.rdoleaveTemplate.Name = "rdoleaveTemplate";
            this.rdoleaveTemplate.Size = new System.Drawing.Size(200, 22);
            this.rdoleaveTemplate.TabIndex = 27;
            this.rdoleaveTemplate.Text = "Employee Leave Template";
            this.rdoleaveTemplate.UseVisualStyleBackColor = false;
            this.rdoleaveTemplate.Visible = false;
            this.rdoleaveTemplate.CheckedChanged += new System.EventHandler(this.rdoleaveTemplate_CheckedChanged);
            // 
            // rdoEmpLeaveRegister
            // 
            this.rdoEmpLeaveRegister.AutoSize = true;
            this.rdoEmpLeaveRegister.BackColor = System.Drawing.Color.Transparent;
            this.rdoEmpLeaveRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEmpLeaveRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmpLeaveRegister.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoEmpLeaveRegister.ForeColor = System.Drawing.Color.Gray;
            this.rdoEmpLeaveRegister.Location = new System.Drawing.Point(6, 24);
            this.rdoEmpLeaveRegister.Name = "rdoEmpLeaveRegister";
            this.rdoEmpLeaveRegister.Size = new System.Drawing.Size(192, 22);
            this.rdoEmpLeaveRegister.TabIndex = 26;
            this.rdoEmpLeaveRegister.Text = "Employee Leave Register";
            this.rdoEmpLeaveRegister.UseVisualStyleBackColor = false;
            this.rdoEmpLeaveRegister.CheckedChanged += new System.EventHandler(this.rdoEmpLeaveRegister_CheckedChanged);
            // 
            // rdoDeptWiseLeave
            // 
            this.rdoDeptWiseLeave.AutoSize = true;
            this.rdoDeptWiseLeave.BackColor = System.Drawing.Color.Transparent;
            this.rdoDeptWiseLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDeptWiseLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDeptWiseLeave.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDeptWiseLeave.ForeColor = System.Drawing.Color.Gray;
            this.rdoDeptWiseLeave.Location = new System.Drawing.Point(6, 58);
            this.rdoDeptWiseLeave.Name = "rdoDeptWiseLeave";
            this.rdoDeptWiseLeave.Size = new System.Drawing.Size(251, 22);
            this.rdoDeptWiseLeave.TabIndex = 25;
            this.rdoDeptWiseLeave.Text = "Department Wise Leave Approved";
            this.rdoDeptWiseLeave.UseVisualStyleBackColor = false;
            this.rdoDeptWiseLeave.CheckedChanged += new System.EventHandler(this.rdoDeptWiseLeave_CheckedChanged);
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.gbSelectOptions);
            this.gbInformationControlls.Controls.Add(this.pnlDepartment);
            this.gbInformationControlls.Controls.Add(this.pnlYear);
            this.gbInformationControlls.Controls.Add(this.pnlEmployee);
            this.gbInformationControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationControlls.Location = new System.Drawing.Point(352, 17);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(573, 482);
            this.gbInformationControlls.TabIndex = 28;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // gbSelectOptions
            // 
            this.gbSelectOptions.Controls.Add(this.rdoGrpDeptUnit);
            this.gbSelectOptions.Controls.Add(this.rdoDeptGrp);
            this.gbSelectOptions.Controls.Add(this.rdoAll);
            this.gbSelectOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbSelectOptions.Location = new System.Drawing.Point(6, 66);
            this.gbSelectOptions.Name = "gbSelectOptions";
            this.gbSelectOptions.Size = new System.Drawing.Size(559, 60);
            this.gbSelectOptions.TabIndex = 228;
            this.gbSelectOptions.TabStop = false;
            this.gbSelectOptions.Text = "Select Options";
            // 
            // rdoGrpDeptUnit
            // 
            this.rdoGrpDeptUnit.AutoSize = true;
            this.rdoGrpDeptUnit.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoGrpDeptUnit.ForeColor = System.Drawing.Color.Gray;
            this.rdoGrpDeptUnit.Location = new System.Drawing.Point(297, 22);
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
            this.rdoDeptGrp.Location = new System.Drawing.Point(130, 22);
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
            this.rdoAll.Location = new System.Drawing.Point(27, 22);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(44, 22);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
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
            this.pnlDepartment.Location = new System.Drawing.Point(6, 128);
            this.pnlDepartment.Name = "pnlDepartment";
            this.pnlDepartment.Size = new System.Drawing.Size(560, 137);
            this.pnlDepartment.TabIndex = 30;
            this.pnlDepartment.Visible = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(256, 70);
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
            this.cboUnit.Location = new System.Drawing.Point(258, 92);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(277, 26);
            this.cboUnit.TabIndex = 216;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(11, 70);
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
            this.cboDepartment.Location = new System.Drawing.Point(11, 92);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(241, 26);
            this.cboDepartment.TabIndex = 22;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(258, 33);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(277, 26);
            this.cboDepartmentGroup.TabIndex = 213;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(255, 13);
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
            this.cboDepartmentType.Location = new System.Drawing.Point(11, 33);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(241, 26);
            this.cboDepartmentType.TabIndex = 212;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(11, 13);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(112, 13);
            this.smartLabel21.TabIndex = 214;
            this.smartLabel21.Text = "Department Type :";
            // 
            // pnlYear
            // 
            this.pnlYear.Controls.Add(this.cboYear);
            this.pnlYear.Controls.Add(this.lblyear);
            this.pnlYear.Location = new System.Drawing.Point(7, 20);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(148, 42);
            this.pnlYear.TabIndex = 30;
            this.pnlYear.Visible = false;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(50, 8);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(88, 26);
            this.cboYear.TabIndex = 22;
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.BackColor = System.Drawing.Color.Transparent;
            this.lblyear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblyear.Location = new System.Drawing.Point(9, 11);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(39, 15);
            this.lblyear.TabIndex = 6;
            this.lblyear.Text = "Year :";
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.txtEmpId);
            this.pnlEmployee.Controls.Add(this.smartLabel1);
            this.pnlEmployee.Location = new System.Drawing.Point(160, 18);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(224, 41);
            this.pnlEmployee.TabIndex = 30;
            this.pnlEmployee.Visible = false;
            // 
            // txtEmpId
            // 
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(88, 11);
            this.txtEmpId.MaxLength = 10;
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(123, 24);
            this.txtEmpId.TabIndex = 7;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(3, 15);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(81, 15);
            this.smartLabel1.TabIndex = 6;
            this.smartLabel1.Text = "Employee  ID:";
            // 
            // pnlSerial
            // 
            this.pnlSerial.Controls.Add(this.txtSerial);
            this.pnlSerial.Controls.Add(this.smartLabel3);
            this.pnlSerial.Location = new System.Drawing.Point(6, 565);
            this.pnlSerial.Name = "pnlSerial";
            this.pnlSerial.Size = new System.Drawing.Size(198, 41);
            this.pnlSerial.TabIndex = 31;
            this.pnlSerial.Visible = false;
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(127, 7);
            this.txtSerial.MaxLength = 10;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(46, 24);
            this.txtSerial.TabIndex = 7;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(72, 10);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(48, 15);
            this.smartLabel3.TabIndex = 6;
            this.smartLabel3.Text = "Serial :";
            // 
            // frmLeaveReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.pnlSerial);
            this.Name = "frmLeaveReportManager";
            this.Load += new System.EventHandler(this.frmLeaveReportManager_Load);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlSerial, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.rdoDepartment.ResumeLayout(false);
            this.rdoDepartment.PerformLayout();
            this.gbInformationControlls.ResumeLayout(false);
            this.gbSelectOptions.ResumeLayout(false);
            this.gbSelectOptions.PerformLayout();
            this.pnlDepartment.ResumeLayout(false);
            this.pnlDepartment.PerformLayout();
            this.pnlYear.ResumeLayout(false);
            this.pnlYear.PerformLayout();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.pnlSerial.ResumeLayout(false);
            this.pnlSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rdoDepartment;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptWiseLeave;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private System.Windows.Forms.Panel pnlEmployee;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartRadioButton rdoEmpLeaveRegister;
        private AtiqsControlLibrary.SmartTextBox txtEmpId;
        private System.Windows.Forms.Panel pnlYear;
        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartLabel lblyear;
        private AtiqsControlLibrary.SmartRadioButton rdoleaveTemplate;
        private System.Windows.Forms.Panel pnlSerial;
        private AtiqsControlLibrary.SmartTextBox txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartRadioButton rdoHolidayCalender;
        private System.Windows.Forms.Panel pnlDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private System.Windows.Forms.GroupBox gbSelectOptions;
        private AtiqsControlLibrary.SmartRadioButton rdoGrpDeptUnit;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptGrp;
        private AtiqsControlLibrary.SmartRadioButton rdoAll;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptWiseLeaveReq;
    }
}
