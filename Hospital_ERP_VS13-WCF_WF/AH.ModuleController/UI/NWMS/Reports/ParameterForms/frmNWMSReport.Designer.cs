namespace AH.ModuleController.UI.NWMS.Reports.ParameterForms
{
    partial class frmNWMSReport
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
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.txtParam1 = new AtiqsControlLibrary.SmartTextBox();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.gbReportOption = new System.Windows.Forms.GroupBox();
            this.rdoDischargeAdvice = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDischargeSummary = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDateRange = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAdmtdPetDetail = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.gbReportOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(497, 371);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(383, 371);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(150, 9);
            this.frmLabel.Size = new System.Drawing.Size(357, 32);
            this.frmLabel.Text = "Nursing Workbench Report ";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.gbReportOption);
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Size = new System.Drawing.Size(614, 309);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(614, 57);
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
            this.gbDateRange.Location = new System.Drawing.Point(235, 121);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(373, 183);
            this.gbDateRange.TabIndex = 20;
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
            this.cboDateType.Location = new System.Drawing.Point(109, 53);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(253, 26);
            this.cboDateType.TabIndex = 5;
            this.cboDateType.SelectedIndexChanged += new System.EventHandler(this.cboDateType_SelectedIndexChanged);
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(206, 108);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(55, 15);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(264, 103);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(96, 24);
            this.dtEndDate.TabIndex = 1;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtStartDate
            // 
            this.dtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(109, 103);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(91, 24);
            this.dtStartDate.TabIndex = 0;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlDate.Location = new System.Drawing.Point(7, 56);
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
            this.lvlStartDate.Location = new System.Drawing.Point(7, 108);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(63, 15);
            this.lvlStartDate.TabIndex = 2;
            this.lvlStartDate.Text = "Start Date";
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.txtParam1);
            this.gbInformationControlls.Controls.Add(this.lblParam1);
            this.gbInformationControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationControlls.Location = new System.Drawing.Point(236, 2);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(372, 109);
            this.gbInformationControlls.TabIndex = 19;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // txtParam1
            // 
            this.txtParam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam1.Location = new System.Drawing.Point(109, 44);
            this.txtParam1.MaxLength = 11;
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(255, 24);
            this.txtParam1.TabIndex = 1;
            this.txtParam1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParam1_KeyUp);
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(8, 47);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(50, 15);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Param1";
            // 
            // gbReportOption
            // 
            this.gbReportOption.Controls.Add(this.rdoDischargeAdvice);
            this.gbReportOption.Controls.Add(this.rdoDischargeSummary);
            this.gbReportOption.Controls.Add(this.rdoDateRange);
            this.gbReportOption.Controls.Add(this.rdoAdmtdPetDetail);
            this.gbReportOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReportOption.Location = new System.Drawing.Point(4, 2);
            this.gbReportOption.Name = "gbReportOption";
            this.gbReportOption.Size = new System.Drawing.Size(226, 302);
            this.gbReportOption.TabIndex = 18;
            this.gbReportOption.TabStop = false;
            this.gbReportOption.Text = "Report Option";
            // 
            // rdoDischargeAdvice
            // 
            this.rdoDischargeAdvice.AutoSize = true;
            this.rdoDischargeAdvice.BackColor = System.Drawing.Color.Transparent;
            this.rdoDischargeAdvice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDischargeAdvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDischargeAdvice.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDischargeAdvice.ForeColor = System.Drawing.Color.Gray;
            this.rdoDischargeAdvice.Location = new System.Drawing.Point(7, 100);
            this.rdoDischargeAdvice.Name = "rdoDischargeAdvice";
            this.rdoDischargeAdvice.Size = new System.Drawing.Size(139, 22);
            this.rdoDischargeAdvice.TabIndex = 17;
            this.rdoDischargeAdvice.Text = "Discharge Advice";
            this.rdoDischargeAdvice.UseVisualStyleBackColor = false;
            this.rdoDischargeAdvice.CheckedChanged += new System.EventHandler(this.rdoDischargeAdvice_CheckedChanged);
            // 
            // rdoDischargeSummary
            // 
            this.rdoDischargeSummary.AutoSize = true;
            this.rdoDischargeSummary.BackColor = System.Drawing.Color.Transparent;
            this.rdoDischargeSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDischargeSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDischargeSummary.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDischargeSummary.ForeColor = System.Drawing.Color.Gray;
            this.rdoDischargeSummary.Location = new System.Drawing.Point(7, 46);
            this.rdoDischargeSummary.Name = "rdoDischargeSummary";
            this.rdoDischargeSummary.Size = new System.Drawing.Size(162, 22);
            this.rdoDischargeSummary.TabIndex = 16;
            this.rdoDischargeSummary.Text = "Discharge Summary";
            this.rdoDischargeSummary.UseVisualStyleBackColor = false;
            this.rdoDischargeSummary.CheckedChanged += new System.EventHandler(this.rdoDischargeSummary_CheckedChanged);
            // 
            // rdoDateRange
            // 
            this.rdoDateRange.AutoSize = true;
            this.rdoDateRange.BackColor = System.Drawing.Color.Transparent;
            this.rdoDateRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDateRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDateRange.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDateRange.ForeColor = System.Drawing.Color.Gray;
            this.rdoDateRange.Location = new System.Drawing.Point(6, 155);
            this.rdoDateRange.Name = "rdoDateRange";
            this.rdoDateRange.Size = new System.Drawing.Size(171, 22);
            this.rdoDateRange.TabIndex = 15;
            this.rdoDateRange.Text = "Admitted Patients List";
            this.rdoDateRange.UseVisualStyleBackColor = false;
            this.rdoDateRange.CheckedChanged += new System.EventHandler(this.rdoDateRange_CheckedChanged);
            // 
            // rdoAdmtdPetDetail
            // 
            this.rdoAdmtdPetDetail.AutoSize = true;
            this.rdoAdmtdPetDetail.BackColor = System.Drawing.Color.Transparent;
            this.rdoAdmtdPetDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAdmtdPetDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAdmtdPetDetail.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoAdmtdPetDetail.ForeColor = System.Drawing.Color.Gray;
            this.rdoAdmtdPetDetail.Location = new System.Drawing.Point(6, 210);
            this.rdoAdmtdPetDetail.Name = "rdoAdmtdPetDetail";
            this.rdoAdmtdPetDetail.Size = new System.Drawing.Size(192, 22);
            this.rdoAdmtdPetDetail.TabIndex = 14;
            this.rdoAdmtdPetDetail.Text = "Admitted Patients Details";
            this.rdoAdmtdPetDetail.UseVisualStyleBackColor = false;
            this.rdoAdmtdPetDetail.CheckedChanged += new System.EventHandler(this.rdoAdmtdPetDetail_CheckedChanged);
            // 
            // frmNWMSReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 435);
            this.Name = "frmNWMSReport";
            this.Load += new System.EventHandler(this.frmNWMSReport_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            this.gbInformationControlls.ResumeLayout(false);
            this.gbInformationControlls.PerformLayout();
            this.gbReportOption.ResumeLayout(false);
            this.gbReportOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartTextBox txtParam1;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private System.Windows.Forms.GroupBox gbReportOption;
        private AtiqsControlLibrary.SmartRadioButton rdoDischargeSummary;
        private AtiqsControlLibrary.SmartRadioButton rdoDateRange;
        private AtiqsControlLibrary.SmartRadioButton rdoAdmtdPetDetail;
        private AtiqsControlLibrary.SmartRadioButton rdoDischargeAdvice;
    }
}