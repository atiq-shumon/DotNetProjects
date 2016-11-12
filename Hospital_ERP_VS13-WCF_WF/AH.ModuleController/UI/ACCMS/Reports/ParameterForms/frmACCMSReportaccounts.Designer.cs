namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    partial class frmACCMSReportaccounts
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
            this.cboCompany = new AtiqsControlLibrary.SmartComboBox();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optProfitLoss = new AtiqsControlLibrary.SmartRadioButton();
            this.optBalanceSheet = new AtiqsControlLibrary.SmartRadioButton();
            this.optTrailBalance = new AtiqsControlLibrary.SmartRadioButton();
            this.grpselectiontype = new System.Windows.Forms.GroupBox();
            this.radLedger = new AtiqsControlLibrary.SmartRadioButton();
            this.radGroup = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpselectiontype.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(494, 243);
            this.btnClose.TabIndex = 4;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(380, 243);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(241, 7);
            this.frmLabel.Size = new System.Drawing.Size(195, 32);
            this.frmLabel.Text = "Final Accounts";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpselectiontype);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboCompany);
            this.pnlMain.Controls.Add(this.lvlStartDate);
            this.pnlMain.Controls.Add(this.lvlEndDate);
            this.pnlMain.Location = new System.Drawing.Point(-1, 52);
            this.pnlMain.Size = new System.Drawing.Size(659, 188);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(656, 51);
            // 
            // cboCompany
            // 
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompany.ForeColor = System.Drawing.Color.Blue;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(307, 60);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(319, 26);
            this.cboCompany.TabIndex = 0;
            this.cboCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCompany_KeyPress);
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(226, 95);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(71, 18);
            this.lvlStartDate.TabIndex = 11;
            this.lvlStartDate.Text = "Start Date:";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(230, 125);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(67, 18);
            this.lvlEndDate.TabIndex = 12;
            this.lvlEndDate.Text = "End Date:";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(188, 59);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(109, 18);
            this.smartLabel1.TabIndex = 13;
            this.smartLabel1.Text = "Company Name:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(306, 90);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(184, 26);
            this.dtStartDate.TabIndex = 17;
            this.dtStartDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtStartDate_KeyPress);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(306, 121);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(184, 26);
            this.dtEndDate.TabIndex = 18;
            this.dtEndDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtEndDate_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optProfitLoss);
            this.groupBox2.Controls.Add(this.optBalanceSheet);
            this.groupBox2.Controls.Add(this.optTrailBalance);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 135);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Selection";
            // 
            // optProfitLoss
            // 
            this.optProfitLoss.AutoSize = true;
            this.optProfitLoss.Font = new System.Drawing.Font("Georgia", 11F);
            this.optProfitLoss.ForeColor = System.Drawing.Color.Gray;
            this.optProfitLoss.Location = new System.Drawing.Point(15, 97);
            this.optProfitLoss.Name = "optProfitLoss";
            this.optProfitLoss.Size = new System.Drawing.Size(111, 22);
            this.optProfitLoss.TabIndex = 20;
            this.optProfitLoss.Text = "Profit && Loss";
            this.optProfitLoss.UseVisualStyleBackColor = true;
            this.optProfitLoss.CheckedChanged += new System.EventHandler(this.optProfitLoss_CheckedChanged);
            // 
            // optBalanceSheet
            // 
            this.optBalanceSheet.AutoSize = true;
            this.optBalanceSheet.Font = new System.Drawing.Font("Georgia", 11F);
            this.optBalanceSheet.ForeColor = System.Drawing.Color.Gray;
            this.optBalanceSheet.Location = new System.Drawing.Point(15, 62);
            this.optBalanceSheet.Name = "optBalanceSheet";
            this.optBalanceSheet.Size = new System.Drawing.Size(119, 22);
            this.optBalanceSheet.TabIndex = 19;
            this.optBalanceSheet.Text = "Balance Sheet";
            this.optBalanceSheet.UseVisualStyleBackColor = true;
            this.optBalanceSheet.CheckedChanged += new System.EventHandler(this.optBalanceSheet_CheckedChanged);
            // 
            // optTrailBalance
            // 
            this.optTrailBalance.AutoSize = true;
            this.optTrailBalance.Checked = true;
            this.optTrailBalance.Font = new System.Drawing.Font("Georgia", 11F);
            this.optTrailBalance.ForeColor = System.Drawing.Color.Gray;
            this.optTrailBalance.Location = new System.Drawing.Point(15, 28);
            this.optTrailBalance.Name = "optTrailBalance";
            this.optTrailBalance.Size = new System.Drawing.Size(114, 22);
            this.optTrailBalance.TabIndex = 18;
            this.optTrailBalance.TabStop = true;
            this.optTrailBalance.Text = "Trail Balance";
            this.optTrailBalance.UseVisualStyleBackColor = true;
            this.optTrailBalance.CheckedChanged += new System.EventHandler(this.optTrailBalance_CheckedChanged);
            // 
            // grpselectiontype
            // 
            this.grpselectiontype.Controls.Add(this.radLedger);
            this.grpselectiontype.Controls.Add(this.radGroup);
            this.grpselectiontype.Location = new System.Drawing.Point(8, 144);
            this.grpselectiontype.Name = "grpselectiontype";
            this.grpselectiontype.Size = new System.Drawing.Size(166, 72);
            this.grpselectiontype.TabIndex = 21;
            this.grpselectiontype.TabStop = false;
            this.grpselectiontype.Text = "Type Selection";
            this.grpselectiontype.Visible = false;
            // 
            // radLedger
            // 
            this.radLedger.AutoSize = true;
            this.radLedger.Font = new System.Drawing.Font("Georgia", 11F);
            this.radLedger.ForeColor = System.Drawing.Color.Gray;
            this.radLedger.Location = new System.Drawing.Point(15, 42);
            this.radLedger.Name = "radLedger";
            this.radLedger.Size = new System.Drawing.Size(71, 22);
            this.radLedger.TabIndex = 1;
            this.radLedger.Text = "Ledger";
            this.radLedger.UseVisualStyleBackColor = true;
            // 
            // radGroup
            // 
            this.radGroup.AutoSize = true;
            this.radGroup.Checked = true;
            this.radGroup.Font = new System.Drawing.Font("Georgia", 11F);
            this.radGroup.ForeColor = System.Drawing.Color.Gray;
            this.radGroup.Location = new System.Drawing.Point(16, 17);
            this.radGroup.Name = "radGroup";
            this.radGroup.Size = new System.Drawing.Size(69, 22);
            this.radGroup.TabIndex = 0;
            this.radGroup.TabStop = true;
            this.radGroup.Text = "Group";
            this.radGroup.UseVisualStyleBackColor = true;
            // 
            // frmACCMSReportaccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(656, 311);
            this.KeyPreview = false;
            this.Name = "frmACCMSReportaccounts";
            this.Load += new System.EventHandler(this.frmACCMSReportaccounts_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpselectiontype.ResumeLayout(false);
            this.grpselectiontype.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboCompany;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartRadioButton optProfitLoss;
        private AtiqsControlLibrary.SmartRadioButton optBalanceSheet;
        private AtiqsControlLibrary.SmartRadioButton optTrailBalance;
        private System.Windows.Forms.GroupBox grpselectiontype;
        private AtiqsControlLibrary.SmartRadioButton radLedger;
        private AtiqsControlLibrary.SmartRadioButton radGroup;
    }
}
