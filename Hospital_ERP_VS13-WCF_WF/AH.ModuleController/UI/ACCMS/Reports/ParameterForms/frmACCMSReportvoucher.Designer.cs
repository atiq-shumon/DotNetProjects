namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    partial class frmACCMSReportvoucher
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
            this.optIndividual = new AtiqsControlLibrary.SmartRadioButton();
            this.optAll = new AtiqsControlLibrary.SmartRadioButton();
            this.grpIndivudual = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboVoucherNo = new AtiqsControlLibrary.SmartComboBox();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboCompany = new AtiqsControlLibrary.SmartComboBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.optContra = new AtiqsControlLibrary.SmartRadioButton();
            this.optJournal = new AtiqsControlLibrary.SmartRadioButton();
            this.optReceipt = new AtiqsControlLibrary.SmartRadioButton();
            this.optPayment = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpIndivudual.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(477, 322);
            this.btnClose.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(363, 322);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(239, 9);
            this.frmLabel.Size = new System.Drawing.Size(253, 32);
            this.frmLabel.TabIndex = 5;
            this.frmLabel.Text = "Individual Voucher";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboCompany);
            this.pnlMain.Controls.Add(this.lvlStartDate);
            this.pnlMain.Controls.Add(this.lvlEndDate);
            this.pnlMain.Controls.Add(this.grpIndivudual);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Location = new System.Drawing.Point(0, 61);
            this.pnlMain.Size = new System.Drawing.Size(691, 260);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(689, 57);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optIndividual);
            this.groupBox2.Controls.Add(this.optAll);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 75);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Type";
            // 
            // optIndividual
            // 
            this.optIndividual.AutoSize = true;
            this.optIndividual.Font = new System.Drawing.Font("Georgia", 11F);
            this.optIndividual.ForeColor = System.Drawing.Color.Gray;
            this.optIndividual.Location = new System.Drawing.Point(18, 47);
            this.optIndividual.Name = "optIndividual";
            this.optIndividual.Size = new System.Drawing.Size(95, 22);
            this.optIndividual.TabIndex = 1;
            this.optIndividual.Text = "Individual";
            this.optIndividual.UseVisualStyleBackColor = true;
            this.optIndividual.CheckedChanged += new System.EventHandler(this.optIndividual_CheckedChanged);
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.Checked = true;
            this.optAll.Font = new System.Drawing.Font("Georgia", 11F);
            this.optAll.ForeColor = System.Drawing.Color.Gray;
            this.optAll.Location = new System.Drawing.Point(18, 21);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(44, 22);
            this.optAll.TabIndex = 0;
            this.optAll.TabStop = true;
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = true;
            this.optAll.CheckedChanged += new System.EventHandler(this.optAll_CheckedChanged);
            // 
            // grpIndivudual
            // 
            this.grpIndivudual.Controls.Add(this.label1);
            this.grpIndivudual.Controls.Add(this.cboVoucherNo);
            this.grpIndivudual.Location = new System.Drawing.Point(167, 52);
            this.grpIndivudual.Name = "grpIndivudual";
            this.grpIndivudual.Size = new System.Drawing.Size(491, 63);
            this.grpIndivudual.TabIndex = 2;
            this.grpIndivudual.TabStop = false;
            this.grpIndivudual.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voucher No:";
            // 
            // cboVoucherNo
            // 
            this.cboVoucherNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoucherNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVoucherNo.ForeColor = System.Drawing.Color.Blue;
            this.cboVoucherNo.FormattingEnabled = true;
            this.cboVoucherNo.Location = new System.Drawing.Point(133, 19);
            this.cboVoucherNo.Name = "cboVoucherNo";
            this.cboVoucherNo.Size = new System.Drawing.Size(347, 26);
            this.cboVoucherNo.TabIndex = 4;
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(223, 141);
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
            this.lvlEndDate.Location = new System.Drawing.Point(451, 141);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(67, 18);
            this.lvlEndDate.TabIndex = 23;
            this.lvlEndDate.Text = "End Date:";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(169, 24);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(128, 16);
            this.smartLabel1.TabIndex = 25;
            this.smartLabel1.Text = "Company Name:";
            // 
            // cboCompany
            // 
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompany.ForeColor = System.Drawing.Color.Blue;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(301, 20);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(346, 26);
            this.cboCompany.TabIndex = 0;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(300, 141);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(118, 26);
            this.dtStartDate.TabIndex = 1;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(524, 139);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(123, 26);
            this.dtEndDate.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.optContra);
            this.groupBox3.Controls.Add(this.optJournal);
            this.groupBox3.Controls.Add(this.optReceipt);
            this.groupBox3.Controls.Add(this.optPayment);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 156);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voucher Type";
            // 
            // optContra
            // 
            this.optContra.AutoSize = true;
            this.optContra.Font = new System.Drawing.Font("Georgia", 11F);
            this.optContra.ForeColor = System.Drawing.Color.Gray;
            this.optContra.Location = new System.Drawing.Point(18, 118);
            this.optContra.Name = "optContra";
            this.optContra.Size = new System.Drawing.Size(72, 22);
            this.optContra.TabIndex = 19;
            this.optContra.Text = "Contra";
            this.optContra.UseVisualStyleBackColor = true;
            // 
            // optJournal
            // 
            this.optJournal.AutoSize = true;
            this.optJournal.Font = new System.Drawing.Font("Georgia", 11F);
            this.optJournal.ForeColor = System.Drawing.Color.Gray;
            this.optJournal.Location = new System.Drawing.Point(18, 90);
            this.optJournal.Name = "optJournal";
            this.optJournal.Size = new System.Drawing.Size(78, 22);
            this.optJournal.TabIndex = 18;
            this.optJournal.Text = "Journal";
            this.optJournal.UseVisualStyleBackColor = true;
            // 
            // optReceipt
            // 
            this.optReceipt.AutoSize = true;
            this.optReceipt.Font = new System.Drawing.Font("Georgia", 11F);
            this.optReceipt.ForeColor = System.Drawing.Color.Gray;
            this.optReceipt.Location = new System.Drawing.Point(18, 62);
            this.optReceipt.Name = "optReceipt";
            this.optReceipt.Size = new System.Drawing.Size(75, 22);
            this.optReceipt.TabIndex = 17;
            this.optReceipt.Text = "Receipt";
            this.optReceipt.UseVisualStyleBackColor = true;
            // 
            // optPayment
            // 
            this.optPayment.AutoSize = true;
            this.optPayment.Checked = true;
            this.optPayment.Font = new System.Drawing.Font("Georgia", 11F);
            this.optPayment.ForeColor = System.Drawing.Color.Gray;
            this.optPayment.Location = new System.Drawing.Point(18, 34);
            this.optPayment.Name = "optPayment";
            this.optPayment.Size = new System.Drawing.Size(86, 22);
            this.optPayment.TabIndex = 16;
            this.optPayment.TabStop = true;
            this.optPayment.Text = "Payment";
            this.optPayment.UseVisualStyleBackColor = true;
            // 
            // frmACCMSReportvoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(689, 381);
            this.Name = "frmACCMSReportvoucher";
            this.Load += new System.EventHandler(this.frmACCMSReportvoucher_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpIndivudual.ResumeLayout(false);
            this.grpIndivudual.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartRadioButton optIndividual;
        private AtiqsControlLibrary.SmartRadioButton optAll;
        private System.Windows.Forms.GroupBox grpIndivudual;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboCompany;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartRadioButton optContra;
        private AtiqsControlLibrary.SmartRadioButton optJournal;
        private AtiqsControlLibrary.SmartRadioButton optReceipt;
        private AtiqsControlLibrary.SmartRadioButton optPayment;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartComboBox cboVoucherNo;
    }
}
