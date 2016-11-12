namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    partial class frmHRReportManager
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
            this.rdoEmployeeList = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoEmpDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoLeaveDays = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptList = new AtiqsControlLibrary.SmartRadioButton();
            this.lblDesig = new AtiqsControlLibrary.SmartLabel();
            this.lblDept = new AtiqsControlLibrary.SmartLabel();
            this.cboDesig = new AtiqsControlLibrary.SmartComboBox();
            this.cboDept = new AtiqsControlLibrary.SmartComboBox();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.txtParam = new AtiqsControlLibrary.SmartTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.lblDesigGrp = new AtiqsControlLibrary.SmartLabel();
            this.lblDeptGrp = new AtiqsControlLibrary.SmartLabel();
            this.cboDesigGrp = new AtiqsControlLibrary.SmartComboBox();
            this.cboDeptGrp = new AtiqsControlLibrary.SmartComboBox();
            this.panelMultiCombo = new System.Windows.Forms.Panel();
            this.chkDesig = new AtiqsControlLibrary.SmartCheckBox();
            this.chkDept = new AtiqsControlLibrary.SmartCheckBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.panelMultiCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(258, 10);
            this.frmLabel.Size = new System.Drawing.Size(135, 29);
            this.frmLabel.Text = "HR Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panelMultiCombo);
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.rdoDepartment);
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoEmployeeList);
            this.rdoDepartment.Controls.Add(this.rdoEmpDetails);
            this.rdoDepartment.Controls.Add(this.rdoLeaveDays);
            this.rdoDepartment.Controls.Add(this.rdoDeptList);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(3, 3);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(186, 327);
            this.rdoDepartment.TabIndex = 19;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoEmployeeList
            // 
            this.rdoEmployeeList.AutoSize = true;
            this.rdoEmployeeList.BackColor = System.Drawing.Color.Transparent;
            this.rdoEmployeeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmployeeList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoEmployeeList.ForeColor = System.Drawing.Color.Gray;
            this.rdoEmployeeList.Location = new System.Drawing.Point(8, 48);
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
            this.rdoEmpDetails.Location = new System.Drawing.Point(8, 20);
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
            this.rdoLeaveDays.Location = new System.Drawing.Point(8, 111);
            this.rdoLeaveDays.Name = "rdoLeaveDays";
            this.rdoLeaveDays.Size = new System.Drawing.Size(101, 22);
            this.rdoLeaveDays.TabIndex = 1;
            this.rdoLeaveDays.Text = "Leave Days";
            this.rdoLeaveDays.UseVisualStyleBackColor = false;
            this.rdoLeaveDays.Click += new System.EventHandler(this.rdoLeaveDays_Click);
            // 
            // rdoDeptList
            // 
            this.rdoDeptList.AutoSize = true;
            this.rdoDeptList.BackColor = System.Drawing.Color.Transparent;
            this.rdoDeptList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDeptList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDeptList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDeptList.ForeColor = System.Drawing.Color.Gray;
            this.rdoDeptList.Location = new System.Drawing.Point(6, 76);
            this.rdoDeptList.Name = "rdoDeptList";
            this.rdoDeptList.Size = new System.Drawing.Size(133, 22);
            this.rdoDeptList.TabIndex = 0;
            this.rdoDeptList.Text = "Department List";
            this.rdoDeptList.UseVisualStyleBackColor = false;
            this.rdoDeptList.Click += new System.EventHandler(this.rdoDeptList_Click);
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesig.Location = new System.Drawing.Point(292, 80);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(84, 15);
            this.lblDesig.TabIndex = 23;
            this.lblDesig.Text = "Designation";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(292, 10);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(82, 15);
            this.lblDept.TabIndex = 21;
            this.lblDept.Text = "Department";
            // 
            // cboDesig
            // 
            this.cboDesig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDesig.ForeColor = System.Drawing.Color.Blue;
            this.cboDesig.FormattingEnabled = true;
            this.cboDesig.Location = new System.Drawing.Point(269, 98);
            this.cboDesig.Name = "cboDesig";
            this.cboDesig.Size = new System.Drawing.Size(178, 26);
            this.cboDesig.TabIndex = 8;
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDept.ForeColor = System.Drawing.Color.Blue;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(269, 28);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(178, 26);
            this.cboDept.TabIndex = 6;
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.txtParam);
            this.gbInformationControlls.Controls.Add(this.btnSearch);
            this.gbInformationControlls.Controls.Add(this.lblParam1);
            this.gbInformationControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationControlls.Location = new System.Drawing.Point(195, 3);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(457, 60);
            this.gbInformationControlls.TabIndex = 20;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // txtParam
            // 
            this.txtParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam.Location = new System.Drawing.Point(190, 22);
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
            this.btnSearch.Location = new System.Drawing.Point(389, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(76, 25);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(47, 18);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Param";
            // 
            // lblDesigGrp
            // 
            this.lblDesigGrp.AutoSize = true;
            this.lblDesigGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesigGrp.Location = new System.Drawing.Point(103, 80);
            this.lblDesigGrp.Name = "lblDesigGrp";
            this.lblDesigGrp.Size = new System.Drawing.Size(127, 15);
            this.lblDesigGrp.TabIndex = 22;
            this.lblDesigGrp.Text = "Designation Group";
            // 
            // lblDeptGrp
            // 
            this.lblDeptGrp.AutoSize = true;
            this.lblDeptGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeptGrp.Location = new System.Drawing.Point(103, 10);
            this.lblDeptGrp.Name = "lblDeptGrp";
            this.lblDeptGrp.Size = new System.Drawing.Size(125, 15);
            this.lblDeptGrp.TabIndex = 9;
            this.lblDeptGrp.Text = "Department Group";
            // 
            // cboDesigGrp
            // 
            this.cboDesigGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesigGrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDesigGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDesigGrp.ForeColor = System.Drawing.Color.Blue;
            this.cboDesigGrp.FormattingEnabled = true;
            this.cboDesigGrp.Location = new System.Drawing.Point(75, 98);
            this.cboDesigGrp.Name = "cboDesigGrp";
            this.cboDesigGrp.Size = new System.Drawing.Size(169, 26);
            this.cboDesigGrp.TabIndex = 7;
            this.cboDesigGrp.SelectedIndexChanged += new System.EventHandler(this.cboDesigGrp_SelectedIndexChanged);
            // 
            // cboDeptGrp
            // 
            this.cboDeptGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptGrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDeptGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptGrp.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptGrp.FormattingEnabled = true;
            this.cboDeptGrp.Location = new System.Drawing.Point(75, 30);
            this.cboDeptGrp.Name = "cboDeptGrp";
            this.cboDeptGrp.Size = new System.Drawing.Size(169, 26);
            this.cboDeptGrp.TabIndex = 5;
            this.cboDeptGrp.SelectedIndexChanged += new System.EventHandler(this.cboDeptGrp_SelectedIndexChanged);
            // 
            // panelMultiCombo
            // 
            this.panelMultiCombo.Controls.Add(this.chkDesig);
            this.panelMultiCombo.Controls.Add(this.chkDept);
            this.panelMultiCombo.Controls.Add(this.lblDeptGrp);
            this.panelMultiCombo.Controls.Add(this.lblDesig);
            this.panelMultiCombo.Controls.Add(this.cboDesigGrp);
            this.panelMultiCombo.Controls.Add(this.cboDeptGrp);
            this.panelMultiCombo.Controls.Add(this.lblDesigGrp);
            this.panelMultiCombo.Controls.Add(this.cboDept);
            this.panelMultiCombo.Controls.Add(this.lblDept);
            this.panelMultiCombo.Controls.Add(this.cboDesig);
            this.panelMultiCombo.Location = new System.Drawing.Point(195, 69);
            this.panelMultiCombo.Name = "panelMultiCombo";
            this.panelMultiCombo.Size = new System.Drawing.Size(457, 139);
            this.panelMultiCombo.TabIndex = 21;
            this.panelMultiCombo.Visible = false;
            // 
            // chkDesig
            // 
            this.chkDesig.AutoSize = true;
            this.chkDesig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDesig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDesig.ForeColor = System.Drawing.Color.Black;
            this.chkDesig.Location = new System.Drawing.Point(57, 105);
            this.chkDesig.Name = "chkDesig";
            this.chkDesig.Size = new System.Drawing.Size(12, 11);
            this.chkDesig.TabIndex = 25;
            this.chkDesig.UseVisualStyleBackColor = true;
            this.chkDesig.Click += new System.EventHandler(this.chkDesig_Click);
            // 
            // chkDept
            // 
            this.chkDept.AutoSize = true;
            this.chkDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDept.ForeColor = System.Drawing.Color.Black;
            this.chkDept.Location = new System.Drawing.Point(57, 37);
            this.chkDept.Name = "chkDept";
            this.chkDept.Size = new System.Drawing.Size(12, 11);
            this.chkDept.TabIndex = 24;
            this.chkDept.UseVisualStyleBackColor = true;
            this.chkDept.Click += new System.EventHandler(this.chkDept_Click);
            // 
            // frmHRReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 506);
            this.Name = "frmHRReportManager";
            this.Load += new System.EventHandler(this.frmHRReportManager_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.rdoDepartment.ResumeLayout(false);
            this.rdoDepartment.PerformLayout();
            this.gbInformationControlls.ResumeLayout(false);
            this.gbInformationControlls.PerformLayout();
            this.panelMultiCombo.ResumeLayout(false);
            this.panelMultiCombo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rdoDepartment;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptList;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartTextBox txtParam;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private AtiqsControlLibrary.SmartRadioButton rdoLeaveDays;
        private AtiqsControlLibrary.SmartRadioButton rdoEmpDetails;
        private AtiqsControlLibrary.SmartRadioButton rdoEmployeeList;
        private AtiqsControlLibrary.SmartComboBox cboDesig;
        private AtiqsControlLibrary.SmartComboBox cboDesigGrp;
        private AtiqsControlLibrary.SmartComboBox cboDept;
        private AtiqsControlLibrary.SmartComboBox cboDeptGrp;
        private AtiqsControlLibrary.SmartLabel lblDeptGrp;
        private AtiqsControlLibrary.SmartLabel lblDept;
        private AtiqsControlLibrary.SmartLabel lblDesigGrp;
        private AtiqsControlLibrary.SmartLabel lblDesig;
        private System.Windows.Forms.Panel panelMultiCombo;
        private AtiqsControlLibrary.SmartCheckBox chkDept;
        private AtiqsControlLibrary.SmartCheckBox chkDesig;
    }
}
