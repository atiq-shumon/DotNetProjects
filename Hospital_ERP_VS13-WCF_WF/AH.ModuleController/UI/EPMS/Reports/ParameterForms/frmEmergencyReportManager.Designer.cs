namespace AH.ModuleController.UI.EPMS.Reports.ParameterForms
{
    partial class frmEmergencyReportManager
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoEmerPres = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoEmrColl = new AtiqsControlLibrary.SmartRadioButton();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.txtMRNo = new AtiqsControlLibrary.SmartTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(683, 565);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(569, 565);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(275, 9);
            this.frmLabel.Size = new System.Drawing.Size(240, 32);
            this.frmLabel.Text = "Emergency Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtMRNo);
            this.pnlMain.Controls.Add(this.lblParam1);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Location = new System.Drawing.Point(0, 55);
            this.pnlMain.Size = new System.Drawing.Size(799, 500);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(796, 57);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoEmerPres);
            this.groupBox2.Controls.Add(this.rdoEmrColl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 489);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // rdoEmerPres
            // 
            this.rdoEmerPres.AutoSize = true;
            this.rdoEmerPres.BackColor = System.Drawing.Color.Transparent;
            this.rdoEmerPres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEmerPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmerPres.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoEmerPres.ForeColor = System.Drawing.Color.Gray;
            this.rdoEmerPres.Location = new System.Drawing.Point(8, 46);
            this.rdoEmerPres.Name = "rdoEmerPres";
            this.rdoEmerPres.Size = new System.Drawing.Size(267, 22);
            this.rdoEmerPres.TabIndex = 41;
            this.rdoEmerPres.Text = "Emergency Prescription MR Reprint";
            this.rdoEmerPres.UseVisualStyleBackColor = false;
            this.rdoEmerPres.CheckedChanged += new System.EventHandler(this.rdoEmerPres_CheckedChanged);
            // 
            // rdoEmrColl
            // 
            this.rdoEmrColl.AutoSize = true;
            this.rdoEmrColl.BackColor = System.Drawing.Color.Transparent;
            this.rdoEmrColl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEmrColl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmrColl.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoEmrColl.ForeColor = System.Drawing.Color.Gray;
            this.rdoEmrColl.Location = new System.Drawing.Point(8, 13);
            this.rdoEmrColl.Name = "rdoEmrColl";
            this.rdoEmrColl.Size = new System.Drawing.Size(254, 22);
            this.rdoEmrColl.TabIndex = 40;
            this.rdoEmrColl.Text = "Emergency Collection MR Reprint";
            this.rdoEmrColl.UseVisualStyleBackColor = false;
            this.rdoEmrColl.CheckedChanged += new System.EventHandler(this.rdoEmrColl_CheckedChanged);
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(346, 9);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(94, 15);
            this.lblParam1.TabIndex = 21;
            this.lblParam1.Text = "Money Receipt :";
            // 
            // txtMRNo
            // 
            this.txtMRNo.BackColor = System.Drawing.Color.White;
            this.txtMRNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNo.Location = new System.Drawing.Point(348, 28);
            this.txtMRNo.Name = "txtMRNo";
            this.txtMRNo.Size = new System.Drawing.Size(274, 24);
            this.txtMRNo.TabIndex = 23;
            this.txtMRNo.TextChanged += new System.EventHandler(this.txtMRNo_TextChanged);
            // 
            // dtStartDate
            // 
            this.dtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(113, 73);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(112, 24);
            this.dtStartDate.TabIndex = 0;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(302, 73);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(112, 24);
            this.dtEndDate.TabIndex = 1;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(232, 73);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(55, 15);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date";
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(38, 73);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(63, 15);
            this.lvlStartDate.TabIndex = 2;
            this.lvlStartDate.Text = "Start Date";
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlDate.Location = new System.Drawing.Point(31, 35);
            this.lvlDate.Name = "lvlDate";
            this.lvlDate.Size = new System.Drawing.Size(70, 15);
            this.lvlDate.TabIndex = 4;
            this.lvlDate.Text = "Date Range";
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
            "Last One Year",
            "No Date"});
            this.cboDateType.Location = new System.Drawing.Point(114, 29);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(300, 26);
            this.cboDateType.TabIndex = 5;
            this.cboDateType.SelectedIndexChanged += new System.EventHandler(this.cboDateType_SelectedIndexChanged);
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Location = new System.Drawing.Point(335, 364);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(442, 128);
            this.gbDateRange.TabIndex = 31;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "DateRange";
            this.gbDateRange.Visible = false;
            // 
            // frmEmergencyReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 627);
            this.Name = "frmEmergencyReportManager";
            this.Load += new System.EventHandler(this.frmEmergencyReportManager_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartRadioButton rdoTestDetails;
        private AtiqsControlLibrary.SmartTextBox txtMRNo;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartRadioButton rdoEmrColl;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartRadioButton rdoEmerPres;
    }
}
