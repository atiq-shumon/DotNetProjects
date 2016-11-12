namespace AH.ModuleController.UI.DMS.Reports.ParameterForms
{
    partial class frmDMSCollectionReport
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAllCollSummary = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoUserWiseCash = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDoctorWiseCollSum = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDoctorWiseCollDet = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoVoucher = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoUserWiseCollection = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoTotalColl = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDueList = new AtiqsControlLibrary.SmartRadioButton();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.lblUserID = new AtiqsControlLibrary.SmartLabel();
            this.txtUserID = new AtiqsControlLibrary.SmartTextBox();
            this.rdoUserWise = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAll = new AtiqsControlLibrary.SmartRadioButton();
            this.lblTicketType = new AtiqsControlLibrary.SmartLabel();
            this.cboTicketType = new AtiqsControlLibrary.SmartComboBox();
            this.lblEmpID = new AtiqsControlLibrary.SmartLabel();
            this.txtEmpID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(624, 544);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(510, 544);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(197, 9);
            this.frmLabel.Size = new System.Drawing.Size(363, 32);
            this.frmLabel.Text = "Diagnostic Collection Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblEmpID);
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Controls.Add(this.lblTicketType);
            this.pnlMain.Controls.Add(this.cboTicketType);
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.lblUserID);
            this.pnlMain.Controls.Add(this.txtUserID);
            this.pnlMain.Controls.Add(this.rdoUserWise);
            this.pnlMain.Controls.Add(this.rdoAll);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Size = new System.Drawing.Size(771, 485);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(741, 57);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAllCollSummary);
            this.groupBox2.Controls.Add(this.rdoUserWiseCash);
            this.groupBox2.Controls.Add(this.rdoDoctorWiseCollSum);
            this.groupBox2.Controls.Add(this.rdoDoctorWiseCollDet);
            this.groupBox2.Controls.Add(this.rdoVoucher);
            this.groupBox2.Controls.Add(this.rdoUserWiseCollection);
            this.groupBox2.Controls.Add(this.rdoTotalColl);
            this.groupBox2.Controls.Add(this.rdoDueList);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 477);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // rdoAllCollSummary
            // 
            this.rdoAllCollSummary.AutoSize = true;
            this.rdoAllCollSummary.BackColor = System.Drawing.Color.Transparent;
            this.rdoAllCollSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAllCollSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAllCollSummary.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoAllCollSummary.ForeColor = System.Drawing.Color.Gray;
            this.rdoAllCollSummary.Location = new System.Drawing.Point(6, 19);
            this.rdoAllCollSummary.Name = "rdoAllCollSummary";
            this.rdoAllCollSummary.Size = new System.Drawing.Size(184, 22);
            this.rdoAllCollSummary.TabIndex = 38;
            this.rdoAllCollSummary.Text = "All Collection Summary";
            this.rdoAllCollSummary.UseVisualStyleBackColor = false;
            this.rdoAllCollSummary.CheckedChanged += new System.EventHandler(this.rdoAllCollSummary_CheckedChanged);
            // 
            // rdoUserWiseCash
            // 
            this.rdoUserWiseCash.AutoSize = true;
            this.rdoUserWiseCash.BackColor = System.Drawing.Color.Transparent;
            this.rdoUserWiseCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoUserWiseCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoUserWiseCash.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoUserWiseCash.ForeColor = System.Drawing.Color.Gray;
            this.rdoUserWiseCash.Location = new System.Drawing.Point(9, 130);
            this.rdoUserWiseCash.Name = "rdoUserWiseCash";
            this.rdoUserWiseCash.Size = new System.Drawing.Size(199, 22);
            this.rdoUserWiseCash.TabIndex = 37;
            this.rdoUserWiseCash.Text = "User Wise Cash Collection";
            this.rdoUserWiseCash.UseVisualStyleBackColor = false;
            this.rdoUserWiseCash.CheckedChanged += new System.EventHandler(this.rdoUserWiseCash_CheckedChanged);
            // 
            // rdoDoctorWiseCollSum
            // 
            this.rdoDoctorWiseCollSum.AutoSize = true;
            this.rdoDoctorWiseCollSum.BackColor = System.Drawing.Color.Transparent;
            this.rdoDoctorWiseCollSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDoctorWiseCollSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDoctorWiseCollSum.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDoctorWiseCollSum.ForeColor = System.Drawing.Color.Gray;
            this.rdoDoctorWiseCollSum.Location = new System.Drawing.Point(9, 282);
            this.rdoDoctorWiseCollSum.Name = "rdoDoctorWiseCollSum";
            this.rdoDoctorWiseCollSum.Size = new System.Drawing.Size(247, 22);
            this.rdoDoctorWiseCollSum.TabIndex = 34;
            this.rdoDoctorWiseCollSum.Text = "Doctor Wise Collection Summary";
            this.rdoDoctorWiseCollSum.UseVisualStyleBackColor = false;
            this.rdoDoctorWiseCollSum.CheckedChanged += new System.EventHandler(this.rdoDoctorWiseCollSum_CheckedChanged);
            // 
            // rdoDoctorWiseCollDet
            // 
            this.rdoDoctorWiseCollDet.AutoSize = true;
            this.rdoDoctorWiseCollDet.BackColor = System.Drawing.Color.Transparent;
            this.rdoDoctorWiseCollDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDoctorWiseCollDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDoctorWiseCollDet.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDoctorWiseCollDet.ForeColor = System.Drawing.Color.Gray;
            this.rdoDoctorWiseCollDet.Location = new System.Drawing.Point(9, 245);
            this.rdoDoctorWiseCollDet.Name = "rdoDoctorWiseCollDet";
            this.rdoDoctorWiseCollDet.Size = new System.Drawing.Size(225, 22);
            this.rdoDoctorWiseCollDet.TabIndex = 33;
            this.rdoDoctorWiseCollDet.Text = "Doctor Wise Collection Details";
            this.rdoDoctorWiseCollDet.UseVisualStyleBackColor = false;
            this.rdoDoctorWiseCollDet.CheckedChanged += new System.EventHandler(this.rdoDoctorWiseCollDet_CheckedChanged);
            // 
            // rdoVoucher
            // 
            this.rdoVoucher.AutoSize = true;
            this.rdoVoucher.BackColor = System.Drawing.Color.Transparent;
            this.rdoVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoVoucher.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoVoucher.ForeColor = System.Drawing.Color.Gray;
            this.rdoVoucher.Location = new System.Drawing.Point(9, 208);
            this.rdoVoucher.Name = "rdoVoucher";
            this.rdoVoucher.Size = new System.Drawing.Size(203, 22);
            this.rdoVoucher.TabIndex = 29;
            this.rdoVoucher.Text = "Integreted Voucher Report";
            this.rdoVoucher.UseVisualStyleBackColor = false;
            this.rdoVoucher.CheckedChanged += new System.EventHandler(this.rdoVoucher_CheckedChanged);
            this.rdoVoucher.Click += new System.EventHandler(this.rdoVoucher_Click);
            // 
            // rdoUserWiseCollection
            // 
            this.rdoUserWiseCollection.AutoSize = true;
            this.rdoUserWiseCollection.BackColor = System.Drawing.Color.Transparent;
            this.rdoUserWiseCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoUserWiseCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoUserWiseCollection.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoUserWiseCollection.ForeColor = System.Drawing.Color.Gray;
            this.rdoUserWiseCollection.Location = new System.Drawing.Point(9, 91);
            this.rdoUserWiseCollection.Name = "rdoUserWiseCollection";
            this.rdoUserWiseCollection.Size = new System.Drawing.Size(162, 22);
            this.rdoUserWiseCollection.TabIndex = 28;
            this.rdoUserWiseCollection.Text = "User Wise Collection";
            this.rdoUserWiseCollection.UseVisualStyleBackColor = false;
            this.rdoUserWiseCollection.CheckedChanged += new System.EventHandler(this.rdoUserWiseCollection_CheckedChanged);
            this.rdoUserWiseCollection.Click += new System.EventHandler(this.rdoUserWiseCollection_Click);
            // 
            // rdoTotalColl
            // 
            this.rdoTotalColl.AutoSize = true;
            this.rdoTotalColl.BackColor = System.Drawing.Color.Transparent;
            this.rdoTotalColl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoTotalColl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoTotalColl.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoTotalColl.ForeColor = System.Drawing.Color.Gray;
            this.rdoTotalColl.Location = new System.Drawing.Point(9, 54);
            this.rdoTotalColl.Name = "rdoTotalColl";
            this.rdoTotalColl.Size = new System.Drawing.Size(129, 22);
            this.rdoTotalColl.TabIndex = 27;
            this.rdoTotalColl.Text = "Total Collection";
            this.rdoTotalColl.UseVisualStyleBackColor = false;
            this.rdoTotalColl.CheckedChanged += new System.EventHandler(this.rdoTotalColl_CheckedChanged);
            // 
            // rdoDueList
            // 
            this.rdoDueList.AutoSize = true;
            this.rdoDueList.BackColor = System.Drawing.Color.Transparent;
            this.rdoDueList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDueList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDueList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDueList.ForeColor = System.Drawing.Color.Gray;
            this.rdoDueList.Location = new System.Drawing.Point(9, 171);
            this.rdoDueList.Name = "rdoDueList";
            this.rdoDueList.Size = new System.Drawing.Size(80, 22);
            this.rdoDueList.TabIndex = 26;
            this.rdoDueList.Text = "Due List";
            this.rdoDueList.UseVisualStyleBackColor = false;
            this.rdoDueList.CheckedChanged += new System.EventHandler(this.rdoDueList_CheckedChanged);
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Location = new System.Drawing.Point(319, 53);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(442, 120);
            this.gbDateRange.TabIndex = 36;
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
            "Today",
            "Last One Week",
            "Last One Month",
            "Last Three Month",
            "Last Six Month",
            "Last One Year"});
            this.cboDateType.Location = new System.Drawing.Point(99, 29);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(315, 26);
            this.cboDateType.TabIndex = 5;
            this.cboDateType.SelectedIndexChanged += new System.EventHandler(this.cboDateType_SelectedIndexChanged);
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlDate.Location = new System.Drawing.Point(14, 30);
            this.lvlDate.Name = "lvlDate";
            this.lvlDate.Size = new System.Drawing.Size(77, 15);
            this.lvlDate.TabIndex = 4;
            this.lvlDate.Text = "Date Range :";
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(25, 73);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(70, 15);
            this.lvlStartDate.TabIndex = 2;
            this.lvlStartDate.Text = "Start Date :";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(235, 70);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(62, 15);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date :";
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(311, 70);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(103, 24);
            this.dtEndDate.TabIndex = 1;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtStartDate
            // 
            this.dtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(99, 70);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(119, 24);
            this.dtStartDate.TabIndex = 0;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(667, 9);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(54, 13);
            this.lblUserID.TabIndex = 35;
            this.lblUserID.Text = "User ID:";
            this.lblUserID.Visible = false;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(668, 29);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(72, 24);
            this.txtUserID.TabIndex = 34;
            this.txtUserID.Visible = false;
            // 
            // rdoUserWise
            // 
            this.rdoUserWise.AutoSize = true;
            this.rdoUserWise.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoUserWise.ForeColor = System.Drawing.Color.Gray;
            this.rdoUserWise.Location = new System.Drawing.Point(559, 30);
            this.rdoUserWise.Name = "rdoUserWise";
            this.rdoUserWise.Size = new System.Drawing.Size(93, 22);
            this.rdoUserWise.TabIndex = 33;
            this.rdoUserWise.TabStop = true;
            this.rdoUserWise.Text = "User Wise";
            this.rdoUserWise.UseVisualStyleBackColor = true;
            this.rdoUserWise.Visible = false;
            this.rdoUserWise.CheckedChanged += new System.EventHandler(this.rdoUserWise_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoAll.ForeColor = System.Drawing.Color.Gray;
            this.rdoAll.Location = new System.Drawing.Point(507, 30);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(44, 22);
            this.rdoAll.TabIndex = 32;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.Visible = false;
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTicketType.Location = new System.Drawing.Point(329, 18);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(80, 15);
            this.lblTicketType.TabIndex = 41;
            this.lblTicketType.Text = "Prescription:";
            this.lblTicketType.Visible = false;
            // 
            // cboTicketType
            // 
            this.cboTicketType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTicketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTicketType.ForeColor = System.Drawing.Color.Blue;
            this.cboTicketType.FormattingEnabled = true;
            this.cboTicketType.Location = new System.Drawing.Point(418, 15);
            this.cboTicketType.Name = "cboTicketType";
            this.cboTicketType.Size = new System.Drawing.Size(315, 26);
            this.cboTicketType.TabIndex = 40;
            this.cboTicketType.Visible = false;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.Location = new System.Drawing.Point(415, 7);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(53, 15);
            this.lblEmpID.TabIndex = 43;
            this.lblEmpID.Text = "Emp ID :";
            // 
            // txtEmpID
            // 
            this.txtEmpID.BackColor = System.Drawing.Color.Linen;
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtEmpID.Location = new System.Drawing.Point(418, 30);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(83, 24);
            this.txtEmpID.TabIndex = 42;
            this.txtEmpID.TabStop = false;
            // 
            // frmDMSCollectionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(741, 609);
            this.Name = "frmDMSCollectionReport";
            this.Load += new System.EventHandler(this.frmDMSCollectionReport_Load);
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

        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartRadioButton rdoDoctorWiseCollSum;
        private AtiqsControlLibrary.SmartRadioButton rdoDoctorWiseCollDet;
        private AtiqsControlLibrary.SmartRadioButton rdoVoucher;
        private AtiqsControlLibrary.SmartRadioButton rdoUserWiseCollection;
        private AtiqsControlLibrary.SmartRadioButton rdoTotalColl;
        private AtiqsControlLibrary.SmartRadioButton rdoDueList;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartLabel lblUserID;
        private AtiqsControlLibrary.SmartTextBox txtUserID;
        private AtiqsControlLibrary.SmartRadioButton rdoUserWise;
        private AtiqsControlLibrary.SmartRadioButton rdoAll;
        private AtiqsControlLibrary.SmartLabel lblTicketType;
        private AtiqsControlLibrary.SmartComboBox cboTicketType;
        private AtiqsControlLibrary.SmartLabel lblEmpID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtEmpID;
        private AtiqsControlLibrary.SmartRadioButton rdoUserWiseCash;
        private AtiqsControlLibrary.SmartRadioButton rdoAllCollSummary;
    }
}
