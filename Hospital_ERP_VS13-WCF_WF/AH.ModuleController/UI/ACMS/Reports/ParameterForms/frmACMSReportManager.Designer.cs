namespace AH.ModuleController.UI.ACMS.Reports.ParameterForms
{
    partial class frmACMSReportManager
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
            this.rdoGroup = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoModuleID = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAccessControl = new AtiqsControlLibrary.SmartRadioButton();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.txtParam1 = new AtiqsControlLibrary.SmartTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(544, 420);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(430, 420);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(244, 9);
            this.frmLabel.Size = new System.Drawing.Size(184, 32);
            this.frmLabel.Text = "ACMS Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.rdoDepartment);
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Location = new System.Drawing.Point(-2, 53);
            this.pnlMain.Size = new System.Drawing.Size(659, 361);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(657, 57);
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoGroup);
            this.rdoDepartment.Controls.Add(this.rdoModuleID);
            this.rdoDepartment.Controls.Add(this.rdoAccessControl);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(7, 21);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(235, 327);
            this.rdoDepartment.TabIndex = 21;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoGroup
            // 
            this.rdoGroup.AutoSize = true;
            this.rdoGroup.BackColor = System.Drawing.Color.Transparent;
            this.rdoGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoGroup.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoGroup.ForeColor = System.Drawing.Color.Gray;
            this.rdoGroup.Location = new System.Drawing.Point(8, 77);
            this.rdoGroup.Name = "rdoGroup";
            this.rdoGroup.Size = new System.Drawing.Size(68, 22);
            this.rdoGroup.TabIndex = 3;
            this.rdoGroup.Text = "Group";
            this.rdoGroup.UseVisualStyleBackColor = false;
            this.rdoGroup.CheckedChanged += new System.EventHandler(this.rdoGroup_CheckedChanged);
            // 
            // rdoModuleID
            // 
            this.rdoModuleID.AutoSize = true;
            this.rdoModuleID.BackColor = System.Drawing.Color.Transparent;
            this.rdoModuleID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoModuleID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoModuleID.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoModuleID.ForeColor = System.Drawing.Color.Gray;
            this.rdoModuleID.Location = new System.Drawing.Point(7, 49);
            this.rdoModuleID.Name = "rdoModuleID";
            this.rdoModuleID.Size = new System.Drawing.Size(97, 22);
            this.rdoModuleID.TabIndex = 2;
            this.rdoModuleID.Text = "Module ID";
            this.rdoModuleID.UseVisualStyleBackColor = false;
            this.rdoModuleID.CheckedChanged += new System.EventHandler(this.smartRadioButton1_CheckedChanged);
            // 
            // rdoAccessControl
            // 
            this.rdoAccessControl.AutoSize = true;
            this.rdoAccessControl.BackColor = System.Drawing.Color.Transparent;
            this.rdoAccessControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAccessControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAccessControl.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoAccessControl.ForeColor = System.Drawing.Color.Gray;
            this.rdoAccessControl.Location = new System.Drawing.Point(8, 21);
            this.rdoAccessControl.Name = "rdoAccessControl";
            this.rdoAccessControl.Size = new System.Drawing.Size(113, 22);
            this.rdoAccessControl.TabIndex = 1;
            this.rdoAccessControl.Text = "Employee ID";
            this.rdoAccessControl.UseVisualStyleBackColor = false;
            this.rdoAccessControl.CheckedChanged += new System.EventHandler(this.rdoAccessControl_CheckedChanged);
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDateRange.Location = new System.Drawing.Point(248, 197);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(402, 151);
            this.gbDateRange.TabIndex = 23;
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
            "Select Date",
            "Last One Month",
            "Last Three Month",
            "Last Six Month",
            "Last One Year",
            "Provide Date"});
            this.cboDateType.Location = new System.Drawing.Point(83, 29);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(306, 26);
            this.cboDateType.TabIndex = 0;
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlDate.Location = new System.Drawing.Point(5, 33);
            this.lvlDate.Name = "lvlDate";
            this.lvlDate.Size = new System.Drawing.Size(78, 18);
            this.lvlDate.TabIndex = 4;
            this.lvlDate.Text = "Date Range";
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(6, 73);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(68, 18);
            this.lvlStartDate.TabIndex = 2;
            this.lvlStartDate.Text = "Start Date";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(212, 73);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(64, 18);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(276, 71);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(113, 24);
            this.dtEndDate.TabIndex = 2;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtStartDate
            // 
            this.dtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(80, 70);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(128, 24);
            this.dtStartDate.TabIndex = 1;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.txtParam1);
            this.gbInformationControlls.Controls.Add(this.btnSearch);
            this.gbInformationControlls.Controls.Add(this.lblParam1);
            this.gbInformationControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationControlls.Location = new System.Drawing.Point(248, 22);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(402, 158);
            this.gbInformationControlls.TabIndex = 22;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // txtParam1
            // 
            this.txtParam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam1.Location = new System.Drawing.Point(134, 22);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(193, 24);
            this.txtParam1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(333, 20);
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
            this.lblParam1.Location = new System.Drawing.Point(9, 21);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(54, 18);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Param1";
            // 
            // frmACMSReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(657, 483);
            this.Name = "frmACMSReportManager";
            this.Load += new System.EventHandler(this.frmACMSReportManager_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.rdoDepartment.ResumeLayout(false);
            this.rdoDepartment.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.gbInformationControlls.ResumeLayout(false);
            this.gbInformationControlls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rdoDepartment;
        private AtiqsControlLibrary.SmartRadioButton rdoAccessControl;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartTextBox txtParam1;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private AtiqsControlLibrary.SmartRadioButton rdoModuleID;
        private AtiqsControlLibrary.SmartRadioButton rdoGroup;
    }
}
