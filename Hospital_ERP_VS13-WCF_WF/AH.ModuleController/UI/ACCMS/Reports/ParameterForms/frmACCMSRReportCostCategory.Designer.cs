namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    partial class frmACCMSRReportCostCategory
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
            this.radCostcategory = new AtiqsControlLibrary.SmartRadioButton();
            this.radLedgerWise = new AtiqsControlLibrary.SmartRadioButton();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboCompany = new AtiqsControlLibrary.SmartComboBox();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.lblSelection = new AtiqsControlLibrary.SmartLabel();
            this.cboLedgerName = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(544, 257);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(430, 257);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(200, 9);
            this.frmLabel.Size = new System.Drawing.Size(342, 32);
            this.frmLabel.Text = "Cost Category Wise Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboLedgerName);
            this.pnlMain.Controls.Add(this.lblSelection);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboCompany);
            this.pnlMain.Controls.Add(this.lvlStartDate);
            this.pnlMain.Controls.Add(this.lvlEndDate);
            this.pnlMain.Size = new System.Drawing.Size(692, 203);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(661, 57);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radCostcategory);
            this.groupBox2.Controls.Add(this.radLedgerWise);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 124);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Selection";
            // 
            // radCostcategory
            // 
            this.radCostcategory.AutoSize = true;
            this.radCostcategory.Font = new System.Drawing.Font("Georgia", 11F);
            this.radCostcategory.ForeColor = System.Drawing.Color.Gray;
            this.radCostcategory.Location = new System.Drawing.Point(15, 74);
            this.radCostcategory.Name = "radCostcategory";
            this.radCostcategory.Size = new System.Drawing.Size(155, 22);
            this.radCostcategory.TabIndex = 19;
            this.radCostcategory.Text = "Cost Category Wise";
            this.radCostcategory.UseVisualStyleBackColor = true;
            this.radCostcategory.CheckedChanged += new System.EventHandler(this.radCostcategory_CheckedChanged);
            // 
            // radLedgerWise
            // 
            this.radLedgerWise.AutoSize = true;
            this.radLedgerWise.Checked = true;
            this.radLedgerWise.Font = new System.Drawing.Font("Georgia", 11F);
            this.radLedgerWise.ForeColor = System.Drawing.Color.Gray;
            this.radLedgerWise.Location = new System.Drawing.Point(15, 40);
            this.radLedgerWise.Name = "radLedgerWise";
            this.radLedgerWise.Size = new System.Drawing.Size(107, 22);
            this.radLedgerWise.TabIndex = 18;
            this.radLedgerWise.TabStop = true;
            this.radLedgerWise.Text = "Ledger Wise";
            this.radLedgerWise.UseVisualStyleBackColor = true;
            this.radLedgerWise.CheckedChanged += new System.EventHandler(this.radLedgerWise_CheckedChanged);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(350, 142);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(184, 26);
            this.dtEndDate.TabIndex = 26;
            this.dtEndDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtEndDate_KeyPress);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(350, 111);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(184, 26);
            this.dtStartDate.TabIndex = 25;
            this.dtStartDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtStartDate_KeyPress);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(232, 49);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(109, 18);
            this.smartLabel1.TabIndex = 24;
            this.smartLabel1.Text = "Company Name:";
            // 
            // cboCompany
            // 
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompany.ForeColor = System.Drawing.Color.Blue;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(350, 50);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(319, 26);
            this.cboCompany.TabIndex = 21;
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(271, 116);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(71, 18);
            this.lvlStartDate.TabIndex = 22;
            this.lvlStartDate.Text = "Start Date:";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(275, 146);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(67, 18);
            this.lvlEndDate.TabIndex = 23;
            this.lvlEndDate.Text = "End Date:";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.BackColor = System.Drawing.Color.Transparent;
            this.lblSelection.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSelection.Location = new System.Drawing.Point(246, 84);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(93, 18);
            this.lblSelection.TabIndex = 29;
            this.lblSelection.Text = "Ledger Name:";
            // 
            // cboLedgerName
            // 
            this.cboLedgerName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLedgerName.FormattingEnabled = true;
            this.cboLedgerName.Location = new System.Drawing.Point(350, 81);
            this.cboLedgerName.Name = "cboLedgerName";
            this.cboLedgerName.Size = new System.Drawing.Size(319, 24);
            this.cboLedgerName.TabIndex = 30;
            this.cboLedgerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboLedgerName_KeyPress);
            this.cboLedgerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboLedgerName_KeyUp);
            // 
            // frmACCMSRReportCostCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(661, 319);
            this.KeyPreview = false;
            this.Name = "frmACCMSRReportCostCategory";
            this.Load += new System.EventHandler(this.frmACCMSRReportCostCategory_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartRadioButton radCostcategory;
        private AtiqsControlLibrary.SmartRadioButton radLedgerWise;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboCompany;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartLabel lblSelection;
        private System.Windows.Forms.ComboBox cboLedgerName;
    }
}
