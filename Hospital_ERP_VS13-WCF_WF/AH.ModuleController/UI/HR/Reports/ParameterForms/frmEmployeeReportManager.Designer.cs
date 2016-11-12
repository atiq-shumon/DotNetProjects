namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    partial class frmEmployeeReportManager
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
            this.rdoAllEmpList = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoEmployeeList = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoEmpDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoLeaveDays = new AtiqsControlLibrary.SmartRadioButton();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.txtParam = new AtiqsControlLibrary.SmartTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.panelMultiCombo = new System.Windows.Forms.Panel();
            this.pnlDesig = new System.Windows.Forms.Panel();
            this.cboDesigGrp = new AtiqsControlLibrary.SmartComboBox();
            this.cboDesig = new AtiqsControlLibrary.SmartComboBox();
            this.lblDesigGrp = new AtiqsControlLibrary.SmartLabel();
            this.lblDesig = new AtiqsControlLibrary.SmartLabel();
            this.pnlDept = new System.Windows.Forms.Panel();
            this.lblDept = new AtiqsControlLibrary.SmartLabel();
            this.cboDept = new AtiqsControlLibrary.SmartComboBox();
            this.cboDeptGrp = new AtiqsControlLibrary.SmartComboBox();
            this.lblDeptGrp = new AtiqsControlLibrary.SmartLabel();
            this.chkDesig = new AtiqsControlLibrary.SmartCheckBox();
            this.chkDept = new AtiqsControlLibrary.SmartCheckBox();
            this.cboDeptCatagory = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlType = new System.Windows.Forms.Panel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.panelMultiCombo.SuspendLayout();
            this.pnlDesig.SuspendLayout();
            this.pnlDept.SuspendLayout();
            this.pnlType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(753, 539);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(639, 539);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(273, 9);
            this.frmLabel.Size = new System.Drawing.Size(378, 32);
            this.frmLabel.Text = "Employee Information Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlType);
            this.pnlMain.Controls.Add(this.panelMultiCombo);
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.rdoDepartment);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(863, 482);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 51);
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoAllEmpList);
            this.rdoDepartment.Controls.Add(this.rdoEmployeeList);
            this.rdoDepartment.Controls.Add(this.rdoEmpDetails);
            this.rdoDepartment.Controls.Add(this.rdoLeaveDays);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(3, 3);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(220, 474);
            this.rdoDepartment.TabIndex = 19;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoAllEmpList
            // 
            this.rdoAllEmpList.AutoSize = true;
            this.rdoAllEmpList.BackColor = System.Drawing.Color.Transparent;
            this.rdoAllEmpList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAllEmpList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAllEmpList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoAllEmpList.ForeColor = System.Drawing.Color.Gray;
            this.rdoAllEmpList.Location = new System.Drawing.Point(6, 23);
            this.rdoAllEmpList.Name = "rdoAllEmpList";
            this.rdoAllEmpList.Size = new System.Drawing.Size(141, 22);
            this.rdoAllEmpList.TabIndex = 4;
            this.rdoAllEmpList.Text = "All Employee List";
            this.rdoAllEmpList.UseVisualStyleBackColor = false;
            this.rdoAllEmpList.Click += new System.EventHandler(this.rdoAllEmpList_Click);
            // 
            // rdoEmployeeList
            // 
            this.rdoEmployeeList.AutoSize = true;
            this.rdoEmployeeList.BackColor = System.Drawing.Color.Transparent;
            this.rdoEmployeeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmployeeList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoEmployeeList.ForeColor = System.Drawing.Color.Gray;
            this.rdoEmployeeList.Location = new System.Drawing.Point(6, 89);
            this.rdoEmployeeList.Name = "rdoEmployeeList";
            this.rdoEmployeeList.Size = new System.Drawing.Size(119, 22);
            this.rdoEmployeeList.TabIndex = 3;
            this.rdoEmployeeList.Text = "Employee List";
            this.rdoEmployeeList.UseVisualStyleBackColor = false;
            this.rdoEmployeeList.Click += new System.EventHandler(this.rdoEmployeeList_Click);
            // 
            // rdoEmpDetails
            // 
            this.rdoEmpDetails.AutoSize = true;
            this.rdoEmpDetails.BackColor = System.Drawing.Color.Transparent;
            this.rdoEmpDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEmpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmpDetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoEmpDetails.ForeColor = System.Drawing.Color.Gray;
            this.rdoEmpDetails.Location = new System.Drawing.Point(6, 56);
            this.rdoEmpDetails.Name = "rdoEmpDetails";
            this.rdoEmpDetails.Size = new System.Drawing.Size(140, 22);
            this.rdoEmpDetails.TabIndex = 2;
            this.rdoEmpDetails.Text = "Employee Details";
            this.rdoEmpDetails.UseVisualStyleBackColor = false;
            this.rdoEmpDetails.Click += new System.EventHandler(this.rdoEmpMaster_Click);
            // 
            // rdoLeaveDays
            // 
            this.rdoLeaveDays.AutoSize = true;
            this.rdoLeaveDays.BackColor = System.Drawing.Color.Transparent;
            this.rdoLeaveDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoLeaveDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoLeaveDays.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoLeaveDays.ForeColor = System.Drawing.Color.Gray;
            this.rdoLeaveDays.Location = new System.Drawing.Point(6, 122);
            this.rdoLeaveDays.Name = "rdoLeaveDays";
            this.rdoLeaveDays.Size = new System.Drawing.Size(101, 22);
            this.rdoLeaveDays.TabIndex = 1;
            this.rdoLeaveDays.Text = "Leave Days";
            this.rdoLeaveDays.UseVisualStyleBackColor = false;
            this.rdoLeaveDays.Visible = false;
            this.rdoLeaveDays.Click += new System.EventHandler(this.rdoLeaveDays_Click);
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.txtParam);
            this.gbInformationControlls.Controls.Add(this.btnSearch);
            this.gbInformationControlls.Controls.Add(this.lblParam1);
            this.gbInformationControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationControlls.Location = new System.Drawing.Point(229, 3);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(629, 70);
            this.gbInformationControlls.TabIndex = 20;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // txtParam
            // 
            this.txtParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam.Location = new System.Drawing.Point(293, 18);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(193, 24);
            this.txtParam.TabIndex = 0;
            this.txtParam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpId_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(492, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(186, 21);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(93, 18);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Employee ID :";
            // 
            // panelMultiCombo
            // 
            this.panelMultiCombo.Controls.Add(this.pnlDesig);
            this.panelMultiCombo.Controls.Add(this.pnlDept);
            this.panelMultiCombo.Controls.Add(this.chkDesig);
            this.panelMultiCombo.Controls.Add(this.chkDept);
            this.panelMultiCombo.Location = new System.Drawing.Point(229, 79);
            this.panelMultiCombo.Name = "panelMultiCombo";
            this.panelMultiCombo.Size = new System.Drawing.Size(629, 398);
            this.panelMultiCombo.TabIndex = 21;
            this.panelMultiCombo.Visible = false;
            // 
            // pnlDesig
            // 
            this.pnlDesig.Controls.Add(this.cboDesigGrp);
            this.pnlDesig.Controls.Add(this.cboDesig);
            this.pnlDesig.Controls.Add(this.lblDesigGrp);
            this.pnlDesig.Controls.Add(this.lblDesig);
            this.pnlDesig.Location = new System.Drawing.Point(154, 145);
            this.pnlDesig.Name = "pnlDesig";
            this.pnlDesig.Size = new System.Drawing.Size(472, 65);
            this.pnlDesig.TabIndex = 31;
            this.pnlDesig.Visible = false;
            // 
            // cboDesigGrp
            // 
            this.cboDesigGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesigGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDesigGrp.ForeColor = System.Drawing.Color.Blue;
            this.cboDesigGrp.FormattingEnabled = true;
            this.cboDesigGrp.Location = new System.Drawing.Point(12, 23);
            this.cboDesigGrp.Name = "cboDesigGrp";
            this.cboDesigGrp.Size = new System.Drawing.Size(224, 26);
            this.cboDesigGrp.TabIndex = 7;
            this.cboDesigGrp.SelectedIndexChanged += new System.EventHandler(this.cboDesigGrp_SelectedIndexChanged);
            // 
            // cboDesig
            // 
            this.cboDesig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDesig.ForeColor = System.Drawing.Color.Blue;
            this.cboDesig.FormattingEnabled = true;
            this.cboDesig.Location = new System.Drawing.Point(241, 23);
            this.cboDesig.Name = "cboDesig";
            this.cboDesig.Size = new System.Drawing.Size(222, 26);
            this.cboDesig.TabIndex = 8;
            // 
            // lblDesigGrp
            // 
            this.lblDesigGrp.AutoSize = true;
            this.lblDesigGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesigGrp.Location = new System.Drawing.Point(12, 5);
            this.lblDesigGrp.Name = "lblDesigGrp";
            this.lblDesigGrp.Size = new System.Drawing.Size(127, 15);
            this.lblDesigGrp.TabIndex = 22;
            this.lblDesigGrp.Text = "Designation Group";
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesig.Location = new System.Drawing.Point(241, 5);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(84, 15);
            this.lblDesig.TabIndex = 23;
            this.lblDesig.Text = "Designation";
            // 
            // pnlDept
            // 
            this.pnlDept.Controls.Add(this.smartLabel3);
            this.pnlDept.Controls.Add(this.cboUnit);
            this.pnlDept.Controls.Add(this.lblDept);
            this.pnlDept.Controls.Add(this.cboDept);
            this.pnlDept.Location = new System.Drawing.Point(153, 76);
            this.pnlDept.Name = "pnlDept";
            this.pnlDept.Size = new System.Drawing.Size(473, 65);
            this.pnlDept.TabIndex = 30;
            this.pnlDept.Visible = false;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(12, 7);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(82, 15);
            this.lblDept.TabIndex = 21;
            this.lblDept.Text = "Department";
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDept.ForeColor = System.Drawing.Color.Blue;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(12, 25);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(222, 26);
            this.cboDept.TabIndex = 6;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // cboDeptGrp
            // 
            this.cboDeptGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptGrp.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptGrp.FormattingEnabled = true;
            this.cboDeptGrp.Location = new System.Drawing.Point(241, 29);
            this.cboDeptGrp.Name = "cboDeptGrp";
            this.cboDeptGrp.Size = new System.Drawing.Size(224, 26);
            this.cboDeptGrp.TabIndex = 5;
            this.cboDeptGrp.SelectedIndexChanged += new System.EventHandler(this.cboDeptGrp_SelectedIndexChanged);
            // 
            // lblDeptGrp
            // 
            this.lblDeptGrp.AutoSize = true;
            this.lblDeptGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeptGrp.Location = new System.Drawing.Point(241, 7);
            this.lblDeptGrp.Name = "lblDeptGrp";
            this.lblDeptGrp.Size = new System.Drawing.Size(125, 15);
            this.lblDeptGrp.TabIndex = 9;
            this.lblDeptGrp.Text = "Department Group";
            // 
            // chkDesig
            // 
            this.chkDesig.AutoSize = true;
            this.chkDesig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDesig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDesig.ForeColor = System.Drawing.Color.Black;
            this.chkDesig.Location = new System.Drawing.Point(11, 166);
            this.chkDesig.Name = "chkDesig";
            this.chkDesig.Size = new System.Drawing.Size(140, 22);
            this.chkDesig.TabIndex = 25;
            this.chkDesig.Text = "Designation Wise";
            this.chkDesig.UseVisualStyleBackColor = true;
            this.chkDesig.CheckedChanged += new System.EventHandler(this.chkDesig_CheckedChanged);
            // 
            // chkDept
            // 
            this.chkDept.AutoSize = true;
            this.chkDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDept.ForeColor = System.Drawing.Color.Black;
            this.chkDept.Location = new System.Drawing.Point(11, 105);
            this.chkDept.Name = "chkDept";
            this.chkDept.Size = new System.Drawing.Size(139, 22);
            this.chkDept.TabIndex = 24;
            this.chkDept.Text = "Department Wise";
            this.chkDept.UseVisualStyleBackColor = true;
            this.chkDept.CheckedChanged += new System.EventHandler(this.chkDept_CheckedChanged);
            // 
            // cboDeptCatagory
            // 
            this.cboDeptCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptCatagory.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptCatagory.FormattingEnabled = true;
            this.cboDeptCatagory.Location = new System.Drawing.Point(412, 553);
            this.cboDeptCatagory.Name = "cboDeptCatagory";
            this.cboDeptCatagory.Size = new System.Drawing.Size(139, 26);
            this.cboDeptCatagory.TabIndex = 28;
            this.cboDeptCatagory.Visible = false;
            this.cboDeptCatagory.SelectedIndexChanged += new System.EventHandler(this.cboDeptCatagory_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(409, 535);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(142, 15);
            this.smartLabel2.TabIndex = 29;
            this.smartLabel2.Text = "Department Catagory";
            this.smartLabel2.Visible = false;
            // 
            // cboDeptType
            // 
            this.cboDeptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptType.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptType.FormattingEnabled = true;
            this.cboDeptType.Location = new System.Drawing.Point(12, 29);
            this.cboDeptType.Name = "cboDeptType";
            this.cboDeptType.Size = new System.Drawing.Size(224, 26);
            this.cboDeptType.TabIndex = 26;
            this.cboDeptType.SelectedIndexChanged += new System.EventHandler(this.cboDeptType_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(12, 7);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(124, 15);
            this.smartLabel1.TabIndex = 27;
            this.smartLabel1.Text = "Department Type :";
            // 
            // pnlType
            // 
            this.pnlType.Controls.Add(this.smartLabel1);
            this.pnlType.Controls.Add(this.cboDeptType);
            this.pnlType.Controls.Add(this.cboDeptGrp);
            this.pnlType.Controls.Add(this.lblDeptGrp);
            this.pnlType.Location = new System.Drawing.Point(382, 92);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(473, 59);
            this.pnlType.TabIndex = 31;
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(241, 25);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(224, 26);
            this.cboUnit.TabIndex = 22;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(241, 7);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(33, 15);
            this.smartLabel3.TabIndex = 23;
            this.smartLabel3.Text = "Unit";
            // 
            // frmEmployeeReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 599);
            this.Controls.Add(this.smartLabel2);
            this.Controls.Add(this.cboDeptCatagory);
            this.Name = "frmEmployeeReportManager";
            this.Load += new System.EventHandler(this.frmHRReportManager_Load);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.cboDeptCatagory, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.smartLabel2, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.rdoDepartment.ResumeLayout(false);
            this.rdoDepartment.PerformLayout();
            this.gbInformationControlls.ResumeLayout(false);
            this.gbInformationControlls.PerformLayout();
            this.panelMultiCombo.ResumeLayout(false);
            this.panelMultiCombo.PerformLayout();
            this.pnlDesig.ResumeLayout(false);
            this.pnlDesig.PerformLayout();
            this.pnlDept.ResumeLayout(false);
            this.pnlDept.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox rdoDepartment;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartTextBox txtParam;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private AtiqsControlLibrary.SmartRadioButton rdoLeaveDays;
        private AtiqsControlLibrary.SmartRadioButton rdoEmpDetails;
        private AtiqsControlLibrary.SmartRadioButton rdoEmployeeList;
        private System.Windows.Forms.Panel panelMultiCombo;
        private AtiqsControlLibrary.SmartCheckBox chkDept;
        private AtiqsControlLibrary.SmartCheckBox chkDesig;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboDeptCatagory;
        private AtiqsControlLibrary.SmartRadioButton rdoAllEmpList;
        private System.Windows.Forms.Panel pnlType;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDeptType;
        private System.Windows.Forms.Panel pnlDesig;
        private AtiqsControlLibrary.SmartComboBox cboDesigGrp;
        private AtiqsControlLibrary.SmartComboBox cboDesig;
        private AtiqsControlLibrary.SmartLabel lblDesigGrp;
        private AtiqsControlLibrary.SmartLabel lblDesig;
        private System.Windows.Forms.Panel pnlDept;
        private AtiqsControlLibrary.SmartLabel lblDept;
        private AtiqsControlLibrary.SmartComboBox cboDept;
        private AtiqsControlLibrary.SmartComboBox cboDeptGrp;
        private AtiqsControlLibrary.SmartLabel lblDeptGrp;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
    }
}
