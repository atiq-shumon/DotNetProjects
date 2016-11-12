namespace AH.ModuleController.UI.PatientRegistration.ParameterForms
{
    partial class frmPetRegReportManager
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
            this.gbReportOption = new System.Windows.Forms.GroupBox();
            this.rdoHealthCard = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDateRange = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPetReg = new AtiqsControlLibrary.SmartRadioButton();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.txtParam1 = new AtiqsControlLibrary.SmartTextBox();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbReportOption.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(493, 316);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(379, 316);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(142, 9);
            this.frmLabel.Size = new System.Drawing.Size(343, 32);
            this.frmLabel.Text = "Patient Registration Report";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.gbReportOption);
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Size = new System.Drawing.Size(612, 254);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(612, 57);
            // 
            // gbReportOption
            // 
            this.gbReportOption.Controls.Add(this.rdoHealthCard);
            this.gbReportOption.Controls.Add(this.rdoDateRange);
            this.gbReportOption.Controls.Add(this.rdoPetReg);
            this.gbReportOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReportOption.Location = new System.Drawing.Point(6, 10);
            this.gbReportOption.Name = "gbReportOption";
            this.gbReportOption.Size = new System.Drawing.Size(226, 229);
            this.gbReportOption.TabIndex = 15;
            this.gbReportOption.TabStop = false;
            this.gbReportOption.Text = "Report Option";
            // 
            // rdoHealthCard
            // 
            this.rdoHealthCard.AutoSize = true;
            this.rdoHealthCard.BackColor = System.Drawing.Color.Transparent;
            this.rdoHealthCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoHealthCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoHealthCard.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoHealthCard.ForeColor = System.Drawing.Color.Gray;
            this.rdoHealthCard.Location = new System.Drawing.Point(6, 31);
            this.rdoHealthCard.Name = "rdoHealthCard";
            this.rdoHealthCard.Size = new System.Drawing.Size(106, 22);
            this.rdoHealthCard.TabIndex = 16;
            this.rdoHealthCard.Text = "Health Card";
            this.rdoHealthCard.UseVisualStyleBackColor = false;
            this.rdoHealthCard.CheckedChanged += new System.EventHandler(this.rdoHealthCard_CheckedChanged);
            // 
            // rdoDateRange
            // 
            this.rdoDateRange.AutoSize = true;
            this.rdoDateRange.BackColor = System.Drawing.Color.Transparent;
            this.rdoDateRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDateRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDateRange.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDateRange.ForeColor = System.Drawing.Color.Gray;
            this.rdoDateRange.Location = new System.Drawing.Point(6, 91);
            this.rdoDateRange.Name = "rdoDateRange";
            this.rdoDateRange.Size = new System.Drawing.Size(106, 22);
            this.rdoDateRange.TabIndex = 15;
            this.rdoDateRange.Text = "Patients List";
            this.rdoDateRange.UseVisualStyleBackColor = false;
            this.rdoDateRange.CheckedChanged += new System.EventHandler(this.smartRadioButton1_CheckedChanged);
            // 
            // rdoPetReg
            // 
            this.rdoPetReg.AutoSize = true;
            this.rdoPetReg.BackColor = System.Drawing.Color.Transparent;
            this.rdoPetReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPetReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPetReg.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPetReg.ForeColor = System.Drawing.Color.Gray;
            this.rdoPetReg.Location = new System.Drawing.Point(6, 150);
            this.rdoPetReg.Name = "rdoPetReg";
            this.rdoPetReg.Size = new System.Drawing.Size(200, 22);
            this.rdoPetReg.TabIndex = 14;
            this.rdoPetReg.Text = "Individual Patients Details";
            this.rdoPetReg.UseVisualStyleBackColor = false;
            this.rdoPetReg.CheckedChanged += new System.EventHandler(this.rdoPetReg_CheckedChanged);
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.txtParam1);
            this.gbInformationControlls.Controls.Add(this.lblParam1);
            this.gbInformationControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationControlls.Location = new System.Drawing.Point(237, 11);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(370, 82);
            this.gbInformationControlls.TabIndex = 16;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // txtParam1
            // 
            this.txtParam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam1.Location = new System.Drawing.Point(83, 29);
            this.txtParam1.MaxLength = 11;
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(273, 24);
            this.txtParam1.TabIndex = 1;
            this.txtParam1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParam1_KeyUp);
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(7, 31);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(50, 15);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Param1";
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDateRange.Location = new System.Drawing.Point(237, 99);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(370, 140);
            this.gbDateRange.TabIndex = 17;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "DateRange";
            // 
            // cboDateType
            // 
            this.cboDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDateType.ForeColor = System.Drawing.Color.Blue;
            this.cboDateType.FormattingEnabled = true;
            this.cboDateType.ItemHeight = 18;
            this.cboDateType.Items.AddRange(new object[] {
            "Last One Month",
            "Last Three Month",
            "Last Six Month",
            "Last One Year",
            "Provide Date"});
            this.cboDateType.Location = new System.Drawing.Point(83, 34);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(273, 26);
            this.cboDateType.TabIndex = 5;
            this.cboDateType.SelectedIndexChanged += new System.EventHandler(this.cboDateType_SelectedIndexChanged);
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(192, 87);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(55, 15);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(252, 83);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(104, 24);
            this.dtEndDate.TabIndex = 1;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtStartDate
            // 
            this.dtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(83, 83);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(99, 24);
            this.dtStartDate.TabIndex = 0;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlDate.Location = new System.Drawing.Point(9, 39);
            this.lvlDate.Name = "lvlDate";
            this.lvlDate.Size = new System.Drawing.Size(70, 15);
            this.lvlDate.TabIndex = 4;
            this.lvlDate.Text = "Date Range";
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(9, 87);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(63, 15);
            this.lvlStartDate.TabIndex = 2;
            this.lvlStartDate.Text = "Start Date";
            // 
            // frmPetRegReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(612, 381);
            this.Name = "frmPetRegReportManager";
            this.Load += new System.EventHandler(this.frmPetRegReportManager_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.gbReportOption.ResumeLayout(false);
            this.gbReportOption.PerformLayout();
            this.gbInformationControlls.ResumeLayout(false);
            this.gbInformationControlls.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReportOption;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartRadioButton rdoDateRange;
        private AtiqsControlLibrary.SmartRadioButton rdoPetReg;
        private AtiqsControlLibrary.SmartTextBox txtParam1;
        private AtiqsControlLibrary.SmartRadioButton rdoHealthCard;
    }
}
