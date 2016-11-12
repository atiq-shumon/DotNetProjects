namespace AH.ModuleController.UI.OPD.Reports.ParameterForms
{
    partial class frmOPDReportManager
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
            this.rdoOPDNurRomAlloc = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoOPDDoctor = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDoctorCons = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDoctor = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDep = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPrescription = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoMR = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoMRCollectionDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
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
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.gbInformationControlls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(161, 29);
            this.frmLabel.Text = "OPD Reports";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.rdoDepartment);
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoOPDNurRomAlloc);
            this.rdoDepartment.Controls.Add(this.rdoOPDDoctor);
            this.rdoDepartment.Controls.Add(this.rdoDoctorCons);
            this.rdoDepartment.Controls.Add(this.rdoDoctor);
            this.rdoDepartment.Controls.Add(this.rdoDep);
            this.rdoDepartment.Controls.Add(this.rdoPrescription);
            this.rdoDepartment.Controls.Add(this.rdoMR);
            this.rdoDepartment.Controls.Add(this.rdoMRCollectionDetails);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(8, 21);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(241, 327);
            this.rdoDepartment.TabIndex = 18;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoOPDNurRomAlloc
            // 
            this.rdoOPDNurRomAlloc.AutoSize = true;
            this.rdoOPDNurRomAlloc.BackColor = System.Drawing.Color.Transparent;
            this.rdoOPDNurRomAlloc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOPDNurRomAlloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoOPDNurRomAlloc.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoOPDNurRomAlloc.ForeColor = System.Drawing.Color.Gray;
            this.rdoOPDNurRomAlloc.Location = new System.Drawing.Point(8, 245);
            this.rdoOPDNurRomAlloc.Name = "rdoOPDNurRomAlloc";
            this.rdoOPDNurRomAlloc.Size = new System.Drawing.Size(181, 22);
            this.rdoOPDNurRomAlloc.TabIndex = 7;
            this.rdoOPDNurRomAlloc.Text = "Nurse Room Allocation";
            this.rdoOPDNurRomAlloc.UseVisualStyleBackColor = false;
            this.rdoOPDNurRomAlloc.CheckedChanged += new System.EventHandler(this.rdoOPDNurRomAlloc_CheckedChanged);
            // 
            // rdoOPDDoctor
            // 
            this.rdoOPDDoctor.AutoSize = true;
            this.rdoOPDDoctor.BackColor = System.Drawing.Color.Transparent;
            this.rdoOPDDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOPDDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoOPDDoctor.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoOPDDoctor.ForeColor = System.Drawing.Color.Gray;
            this.rdoOPDDoctor.Location = new System.Drawing.Point(8, 205);
            this.rdoOPDDoctor.Name = "rdoOPDDoctor";
            this.rdoOPDDoctor.Size = new System.Drawing.Size(106, 22);
            this.rdoOPDDoctor.TabIndex = 6;
            this.rdoOPDDoctor.Text = "OPD Doctor";
            this.rdoOPDDoctor.UseVisualStyleBackColor = false;
            this.rdoOPDDoctor.CheckedChanged += new System.EventHandler(this.rdoOPDDoctor_CheckedChanged);
            // 
            // rdoDoctorCons
            // 
            this.rdoDoctorCons.AutoSize = true;
            this.rdoDoctorCons.BackColor = System.Drawing.Color.Transparent;
            this.rdoDoctorCons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDoctorCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDoctorCons.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDoctorCons.ForeColor = System.Drawing.Color.Gray;
            this.rdoDoctorCons.Location = new System.Drawing.Point(6, 166);
            this.rdoDoctorCons.Name = "rdoDoctorCons";
            this.rdoDoctorCons.Size = new System.Drawing.Size(235, 22);
            this.rdoDoctorCons.TabIndex = 5;
            this.rdoDoctorCons.Text = "Collection (Dr Consultaion Fee)";
            this.rdoDoctorCons.UseVisualStyleBackColor = false;
            this.rdoDoctorCons.CheckedChanged += new System.EventHandler(this.rdoDoctorCons_CheckedChanged);
            // 
            // rdoDoctor
            // 
            this.rdoDoctor.AutoSize = true;
            this.rdoDoctor.BackColor = System.Drawing.Color.Transparent;
            this.rdoDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDoctor.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDoctor.ForeColor = System.Drawing.Color.Gray;
            this.rdoDoctor.Location = new System.Drawing.Point(8, 133);
            this.rdoDoctor.Name = "rdoDoctor";
            this.rdoDoctor.Size = new System.Drawing.Size(152, 22);
            this.rdoDoctor.TabIndex = 4;
            this.rdoDoctor.Text = "Collection (Doctor)";
            this.rdoDoctor.UseVisualStyleBackColor = false;
            this.rdoDoctor.CheckedChanged += new System.EventHandler(this.rdoDoctor_CheckedChanged);
            // 
            // rdoDep
            // 
            this.rdoDep.AutoSize = true;
            this.rdoDep.BackColor = System.Drawing.Color.Transparent;
            this.rdoDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDep.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDep.ForeColor = System.Drawing.Color.Gray;
            this.rdoDep.Location = new System.Drawing.Point(8, 105);
            this.rdoDep.Name = "rdoDep";
            this.rdoDep.Size = new System.Drawing.Size(182, 22);
            this.rdoDep.TabIndex = 3;
            this.rdoDep.Text = "Collection(Depertment)";
            this.rdoDep.UseVisualStyleBackColor = false;
            this.rdoDep.CheckedChanged += new System.EventHandler(this.rdoDep_CheckedChanged);
            // 
            // rdoPrescription
            // 
            this.rdoPrescription.AutoSize = true;
            this.rdoPrescription.BackColor = System.Drawing.Color.Transparent;
            this.rdoPrescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPrescription.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPrescription.ForeColor = System.Drawing.Color.Gray;
            this.rdoPrescription.Location = new System.Drawing.Point(8, 49);
            this.rdoPrescription.Name = "rdoPrescription";
            this.rdoPrescription.Size = new System.Drawing.Size(104, 22);
            this.rdoPrescription.TabIndex = 2;
            this.rdoPrescription.Text = "Prescription";
            this.rdoPrescription.UseVisualStyleBackColor = false;
            this.rdoPrescription.CheckedChanged += new System.EventHandler(this.rdoPrescription_CheckedChanged);
            // 
            // rdoMR
            // 
            this.rdoMR.AutoSize = true;
            this.rdoMR.BackColor = System.Drawing.Color.Transparent;
            this.rdoMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMR.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoMR.ForeColor = System.Drawing.Color.Gray;
            this.rdoMR.Location = new System.Drawing.Point(8, 21);
            this.rdoMR.Name = "rdoMR";
            this.rdoMR.Size = new System.Drawing.Size(124, 22);
            this.rdoMR.TabIndex = 1;
            this.rdoMR.Text = "Money Receipt";
            this.rdoMR.UseVisualStyleBackColor = false;
            this.rdoMR.CheckedChanged += new System.EventHandler(this.rdoMR_CheckedChanged);
            // 
            // rdoMRCollectionDetails
            // 
            this.rdoMRCollectionDetails.AutoSize = true;
            this.rdoMRCollectionDetails.BackColor = System.Drawing.Color.Transparent;
            this.rdoMRCollectionDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMRCollectionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMRCollectionDetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoMRCollectionDetails.ForeColor = System.Drawing.Color.Gray;
            this.rdoMRCollectionDetails.Location = new System.Drawing.Point(8, 77);
            this.rdoMRCollectionDetails.Name = "rdoMRCollectionDetails";
            this.rdoMRCollectionDetails.Size = new System.Drawing.Size(169, 22);
            this.rdoMRCollectionDetails.TabIndex = 0;
            this.rdoMRCollectionDetails.Text = "MR Collection Details";
            this.rdoMRCollectionDetails.UseVisualStyleBackColor = false;
            this.rdoMRCollectionDetails.CheckedChanged += new System.EventHandler(this.rdoTicketDetails_CheckedChanged);
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(9, 21);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(54, 18);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Param1";
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
            this.gbDateRange.Location = new System.Drawing.Point(255, 197);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(402, 151);
            this.gbDateRange.TabIndex = 20;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "DateRange";
            // 
            // cboDateType
            // 
            this.cboDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.cboDateType.SelectedIndexChanged += new System.EventHandler(this.cboDateType_SelectedIndexChanged);
            this.cboDateType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDateType_KeyDown);
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.lvlStartDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.lvlEndDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(212, 73);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(64, 18);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(276, 71);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(113, 24);
            this.dtEndDate.TabIndex = 2;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            this.dtEndDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtEndDate_KeyDown);
            // 
            // dtStartDate
            // 
            this.dtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(80, 70);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(128, 24);
            this.dtStartDate.TabIndex = 1;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            this.dtStartDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dtStartDate_MaskInputRejected);
            this.dtStartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtStartDate_KeyDown);
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Controls.Add(this.txtParam1);
            this.gbInformationControlls.Controls.Add(this.btnSearch);
            this.gbInformationControlls.Controls.Add(this.lblParam1);
            this.gbInformationControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationControlls.Location = new System.Drawing.Point(255, 21);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(402, 158);
            this.gbInformationControlls.TabIndex = 19;
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
            this.txtParam1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParam1_KeyDown);
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
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // frmOPDReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(694, 509);
            this.Name = "frmOPDReportManager";
            this.Load += new System.EventHandler(this.frmOPDReportManager_Load);
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
        private AtiqsControlLibrary.SmartRadioButton rdoMR;
        private AtiqsControlLibrary.SmartRadioButton rdoMRCollectionDetails;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private AtiqsControlLibrary.SmartRadioButton rdoPrescription;
        private AtiqsControlLibrary.SmartTextBox txtParam1;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartRadioButton rdoDep;
        private AtiqsControlLibrary.SmartRadioButton rdoDoctor;
        private AtiqsControlLibrary.SmartRadioButton rdoDoctorCons;
        private AtiqsControlLibrary.SmartRadioButton rdoOPDDoctor;
        private AtiqsControlLibrary.SmartRadioButton rdoOPDNurRomAlloc;
    }
}
