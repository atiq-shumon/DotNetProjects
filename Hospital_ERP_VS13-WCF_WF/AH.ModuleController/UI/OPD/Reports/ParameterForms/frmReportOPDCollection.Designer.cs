namespace AH.ModuleController.UI.OPD.Reports.ParameterForms
{
    partial class frmReportOPDCollection
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboDoctor = new AtiqsControlLibrary.SmartComboBox();
            this.smartlabel = new AtiqsControlLibrary.SmartLabel();
            this.lblUnit = new AtiqsControlLibrary.SmartLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.txtParam1 = new AtiqsControlLibrary.SmartTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoDepNDoct = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoVoucher = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoMRCollectionDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDoctorConsFee = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDep = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoCollectionDoctor = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(629, 441);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(515, 441);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(248, 9);
            this.frmLabel.Size = new System.Drawing.Size(292, 32);
            this.frmLabel.Text = "OPD Collection Report";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMain.Controls.Add(this.groupBox5);
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Size = new System.Drawing.Size(752, 379);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(752, 57);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboDateType);
            this.groupBox5.Controls.Add(this.smartLabel3);
            this.groupBox5.Controls.Add(this.dtEndDate);
            this.groupBox5.Controls.Add(this.smartLabel1);
            this.groupBox5.Controls.Add(this.smartLabel2);
            this.groupBox5.Controls.Add(this.dtStartDate);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(341, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(405, 114);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date Range";
            // 
            // cboDateType
            // 
            this.cboDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDateType.ForeColor = System.Drawing.Color.Blue;
            this.cboDateType.FormattingEnabled = true;
            this.cboDateType.Items.AddRange(new object[] {
            "Provide Date",
            "Last One Month",
            "Last Three Month",
            "Last Six Month",
            "Last One Year"});
            this.cboDateType.Location = new System.Drawing.Point(119, 30);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(276, 26);
            this.cboDateType.TabIndex = 25;
            this.cboDateType.SelectedIndexChanged += new System.EventHandler(this.cboDateType_SelectedIndexChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(6, 36);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(66, 13);
            this.smartLabel3.TabIndex = 26;
            this.smartLabel3.Text = "Date Type";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(297, 74);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(100, 24);
            this.dtEndDate.TabIndex = 22;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(6, 80);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(65, 13);
            this.smartLabel1.TabIndex = 23;
            this.smartLabel1.Text = "Start Date";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(227, 79);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(60, 13);
            this.smartLabel2.TabIndex = 24;
            this.smartLabel2.Text = "End Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(119, 74);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(99, 24);
            this.dtStartDate.TabIndex = 21;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboDepartment);
            this.groupBox4.Controls.Add(this.cboUnit);
            this.groupBox4.Controls.Add(this.smartLabel4);
            this.groupBox4.Controls.Add(this.cboDoctor);
            this.groupBox4.Controls.Add(this.smartlabel);
            this.groupBox4.Controls.Add(this.lblUnit);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(341, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 151);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(120, 19);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(276, 26);
            this.cboDepartment.TabIndex = 16;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(120, 63);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(276, 26);
            this.cboUnit.TabIndex = 19;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(7, 113);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(45, 13);
            this.smartLabel4.TabIndex = 28;
            this.smartLabel4.Text = "Doctor";
            // 
            // cboDoctor
            // 
            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctor.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(120, 107);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(276, 26);
            this.cboDoctor.TabIndex = 27;
            // 
            // smartlabel
            // 
            this.smartlabel.AutoSize = true;
            this.smartlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartlabel.Location = new System.Drawing.Point(7, 24);
            this.smartlabel.Name = "smartlabel";
            this.smartlabel.Size = new System.Drawing.Size(72, 13);
            this.smartlabel.TabIndex = 17;
            this.smartlabel.Text = "Department";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(7, 69);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(30, 13);
            this.lblUnit.TabIndex = 20;
            this.lblUnit.Text = "Unit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblParam1);
            this.groupBox3.Controls.Add(this.txtParam1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(341, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 58);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(7, 25);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(49, 13);
            this.lblParam1.TabIndex = 31;
            this.lblParam1.Text = "Param1";
            // 
            // txtParam1
            // 
            this.txtParam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam1.Location = new System.Drawing.Point(120, 19);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(276, 24);
            this.txtParam1.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoDepNDoct);
            this.groupBox2.Controls.Add(this.rdoVoucher);
            this.groupBox2.Controls.Add(this.rdoMRCollectionDetails);
            this.groupBox2.Controls.Add(this.rdoDoctorConsFee);
            this.groupBox2.Controls.Add(this.rdoDep);
            this.groupBox2.Controls.Add(this.rdoCollectionDoctor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 345);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Option";
            // 
            // rdoDepNDoct
            // 
            this.rdoDepNDoct.AutoSize = true;
            this.rdoDepNDoct.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDepNDoct.ForeColor = System.Drawing.Color.Gray;
            this.rdoDepNDoct.Location = new System.Drawing.Point(9, 87);
            this.rdoDepNDoct.Name = "rdoDepNDoct";
            this.rdoDepNDoct.Size = new System.Drawing.Size(283, 22);
            this.rdoDepNDoct.TabIndex = 39;
            this.rdoDepNDoct.TabStop = true;
            this.rdoDepNDoct.Text = "Collection of Departments and Doctors";
            this.rdoDepNDoct.UseVisualStyleBackColor = true;
            this.rdoDepNDoct.CheckedChanged += new System.EventHandler(this.rdoDepNDoct_CheckedChanged);
            // 
            // rdoVoucher
            // 
            this.rdoVoucher.AutoSize = true;
            this.rdoVoucher.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoVoucher.ForeColor = System.Drawing.Color.Gray;
            this.rdoVoucher.Location = new System.Drawing.Point(9, 189);
            this.rdoVoucher.Name = "rdoVoucher";
            this.rdoVoucher.Size = new System.Drawing.Size(131, 22);
            this.rdoVoucher.TabIndex = 38;
            this.rdoVoucher.TabStop = true;
            this.rdoVoucher.Text = "Voucher Report";
            this.rdoVoucher.UseVisualStyleBackColor = true;
            this.rdoVoucher.CheckedChanged += new System.EventHandler(this.rdoVoucher_CheckedChanged);
            // 
            // rdoMRCollectionDetails
            // 
            this.rdoMRCollectionDetails.AutoSize = true;
            this.rdoMRCollectionDetails.BackColor = System.Drawing.Color.Transparent;
            this.rdoMRCollectionDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMRCollectionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMRCollectionDetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoMRCollectionDetails.ForeColor = System.Drawing.Color.Gray;
            this.rdoMRCollectionDetails.Location = new System.Drawing.Point(9, 36);
            this.rdoMRCollectionDetails.Name = "rdoMRCollectionDetails";
            this.rdoMRCollectionDetails.Size = new System.Drawing.Size(169, 22);
            this.rdoMRCollectionDetails.TabIndex = 33;
            this.rdoMRCollectionDetails.Text = "MR Collection Details";
            this.rdoMRCollectionDetails.UseVisualStyleBackColor = false;
            this.rdoMRCollectionDetails.CheckedChanged += new System.EventHandler(this.rdoMRCollectionDetails_CheckedChanged);
            // 
            // rdoDoctorConsFee
            // 
            this.rdoDoctorConsFee.AutoSize = true;
            this.rdoDoctorConsFee.BackColor = System.Drawing.Color.Transparent;
            this.rdoDoctorConsFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDoctorConsFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDoctorConsFee.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDoctorConsFee.ForeColor = System.Drawing.Color.Gray;
            this.rdoDoctorConsFee.Location = new System.Drawing.Point(9, 291);
            this.rdoDoctorConsFee.Name = "rdoDoctorConsFee";
            this.rdoDoctorConsFee.Size = new System.Drawing.Size(234, 22);
            this.rdoDoctorConsFee.TabIndex = 34;
            this.rdoDoctorConsFee.Text = "Individual Collection Of Doctor";
            this.rdoDoctorConsFee.UseVisualStyleBackColor = false;
            this.rdoDoctorConsFee.CheckedChanged += new System.EventHandler(this.rdoDoctorConsFee_CheckedChanged);
            // 
            // rdoDep
            // 
            this.rdoDep.AutoSize = true;
            this.rdoDep.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDep.ForeColor = System.Drawing.Color.Gray;
            this.rdoDep.Location = new System.Drawing.Point(9, 138);
            this.rdoDep.Name = "rdoDep";
            this.rdoDep.Size = new System.Drawing.Size(184, 22);
            this.rdoDep.TabIndex = 15;
            this.rdoDep.TabStop = true;
            this.rdoDep.Text = "Collection(Department)";
            this.rdoDep.UseVisualStyleBackColor = true;
            this.rdoDep.CheckedChanged += new System.EventHandler(this.rdoDep_CheckedChanged);
            // 
            // rdoCollectionDoctor
            // 
            this.rdoCollectionDoctor.AutoSize = true;
            this.rdoCollectionDoctor.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoCollectionDoctor.ForeColor = System.Drawing.Color.Gray;
            this.rdoCollectionDoctor.Location = new System.Drawing.Point(9, 240);
            this.rdoCollectionDoctor.Name = "rdoCollectionDoctor";
            this.rdoCollectionDoctor.Size = new System.Drawing.Size(175, 22);
            this.rdoCollectionDoctor.TabIndex = 18;
            this.rdoCollectionDoctor.TabStop = true;
            this.rdoCollectionDoctor.Text = "Visiting Fee of Doctors";
            this.rdoCollectionDoctor.UseVisualStyleBackColor = true;
            this.rdoCollectionDoctor.CheckedChanged += new System.EventHandler(this.rdoCollectionDoctor_CheckedChanged);
            // 
            // frmReportOPDCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 505);
            this.Name = "frmReportOPDCollection";
            this.Load += new System.EventHandler(this.frmOPDCollection_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboDoctor;
        private AtiqsControlLibrary.SmartLabel smartlabel;
        private AtiqsControlLibrary.SmartLabel lblUnit;
        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private AtiqsControlLibrary.SmartTextBox txtParam1;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartRadioButton rdoDepNDoct;
        private AtiqsControlLibrary.SmartRadioButton rdoVoucher;
        private AtiqsControlLibrary.SmartRadioButton rdoMRCollectionDetails;
        private AtiqsControlLibrary.SmartRadioButton rdoDoctorConsFee;
        private AtiqsControlLibrary.SmartRadioButton rdoDep;
        private AtiqsControlLibrary.SmartRadioButton rdoCollectionDoctor;
    }
}