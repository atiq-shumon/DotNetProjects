namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmEmployeeTraining
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
            this.txtTrainingTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtTrainingType = new AtiqsControlLibrary.SmartTextBox();
            this.txtOrganizationName = new AtiqsControlLibrary.SmartTextBox();
            this.txtProvidedBy = new AtiqsControlLibrary.SmartTextBox();
            this.txtSubject = new AtiqsControlLibrary.SmartTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvEmployeeTraining = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.txtGrade = new AtiqsControlLibrary.SmartTextBox();
            this.txtSerial = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmp = new AtiqsControlLibrary.SmartTextBox();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel17 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(893, 4);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(384, 4);
            this.frmLabel.Size = new System.Drawing.Size(235, 33);
            this.frmLabel.Text = "Employee Training";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel17);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.txtEmp);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.txtSerial);
            this.pnlMain.Controls.Add(this.txtGrade);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.lvEmployeeTraining);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.txtSubject);
            this.pnlMain.Controls.Add(this.txtProvidedBy);
            this.pnlMain.Controls.Add(this.txtOrganizationName);
            this.pnlMain.Controls.Add(this.txtTrainingType);
            this.pnlMain.Controls.Add(this.txtTrainingTitle);
            this.pnlMain.Location = new System.Drawing.Point(0, 47);
            this.pnlMain.Size = new System.Drawing.Size(985, 583);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(985, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(647, 639);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(533, 639);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 637);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(419, 639);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(873, 639);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(763, 639);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 683);
            this.groupBox1.Size = new System.Drawing.Size(985, 23);
            // 
            // txtTrainingTitle
            // 
            this.txtTrainingTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainingTitle.Location = new System.Drawing.Point(188, 82);
            this.txtTrainingTitle.Name = "txtTrainingTitle";
            this.txtTrainingTitle.Size = new System.Drawing.Size(740, 24);
            this.txtTrainingTitle.TabIndex = 4;
            // 
            // txtTrainingType
            // 
            this.txtTrainingType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainingType.Location = new System.Drawing.Point(25, 82);
            this.txtTrainingType.MaxLength = 2;
            this.txtTrainingType.Name = "txtTrainingType";
            this.txtTrainingType.Size = new System.Drawing.Size(135, 24);
            this.txtTrainingType.TabIndex = 3;
            // 
            // txtOrganizationName
            // 
            this.txtOrganizationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrganizationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationName.Location = new System.Drawing.Point(188, 138);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.Size = new System.Drawing.Size(498, 24);
            this.txtOrganizationName.TabIndex = 6;
            // 
            // txtProvidedBy
            // 
            this.txtProvidedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvidedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvidedBy.Location = new System.Drawing.Point(25, 138);
            this.txtProvidedBy.Name = "txtProvidedBy";
            this.txtProvidedBy.Size = new System.Drawing.Size(135, 24);
            this.txtProvidedBy.TabIndex = 5;
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(25, 191);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(135, 24);
            this.txtSubject.TabIndex = 9;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(719, 136);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(85, 24);
            this.dtStartDate.TabIndex = 7;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(837, 136);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(91, 24);
            this.dtEndDate.TabIndex = 8;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(188, 192);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(740, 73);
            this.txtRemarks.TabIndex = 11;
            this.txtRemarks.Text = "N/A";
            // 
            // lvEmployeeTraining
            // 
            this.lvEmployeeTraining.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvEmployeeTraining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmployeeTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmployeeTraining.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployeeTraining.FullRowSelect = true;
            this.lvEmployeeTraining.GridLines = true;
            this.lvEmployeeTraining.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmployeeTraining.Location = new System.Drawing.Point(-1, 285);
            this.lvEmployeeTraining.Name = "lvEmployeeTraining";
            this.lvEmployeeTraining.Size = new System.Drawing.Size(985, 293);
            this.lvEmployeeTraining.TabIndex = 25;
            this.lvEmployeeTraining.UseCompatibleStateImageBehavior = false;
            this.lvEmployeeTraining.View = System.Windows.Forms.View.Details;
            this.lvEmployeeTraining.SelectedIndexChanged += new System.EventHandler(this.lvEmployeeTraining_SelectedIndexChanged);
            this.lvEmployeeTraining.Click += new System.EventHandler(this.lvEmployeeTraining_Click);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(25, 9);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 13);
            this.smartLabel1.TabIndex = 26;
            this.smartLabel1.Text = "Employee ID :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(188, 65);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(87, 13);
            this.smartLabel2.TabIndex = 27;
            this.smartLabel2.Text = "Traning Title :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(25, 65);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(90, 13);
            this.smartLabel3.TabIndex = 28;
            this.smartLabel3.Text = "Traning Type :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(188, 117);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(86, 13);
            this.smartLabel4.TabIndex = 29;
            this.smartLabel4.Text = "Organization :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(25, 117);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(82, 13);
            this.smartLabel5.TabIndex = 30;
            this.smartLabel5.Text = "Provided by :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(25, 171);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(58, 13);
            this.smartLabel6.TabIndex = 31;
            this.smartLabel6.Text = "Subject :";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(719, 115);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(73, 13);
            this.smartLabel7.TabIndex = 32;
            this.smartLabel7.Text = "Start Date :";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(837, 115);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(68, 13);
            this.smartLabel8.TabIndex = 33;
            this.smartLabel8.Text = "End Date :";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(25, 218);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(49, 13);
            this.smartLabel9.TabIndex = 34;
            this.smartLabel9.Text = "Grade :";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(188, 171);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(64, 13);
            this.smartLabel10.TabIndex = 35;
            this.smartLabel10.Text = "Remarks :";
            // 
            // txtGrade
            // 
            this.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(25, 241);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(135, 24);
            this.txtGrade.TabIndex = 10;
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(760, 25);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(69, 24);
            this.txtSerial.TabIndex = 2;
            this.txtSerial.Visible = false;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(757, 9);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(47, 13);
            this.smartLabel11.TabIndex = 38;
            this.smartLabel11.Text = "Serial :";
            this.smartLabel11.Visible = false;
            // 
            // txtEmp
            // 
            this.txtEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp.Location = new System.Drawing.Point(25, 29);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(135, 24);
            this.txtEmp.TabIndex = 1;
            this.txtEmp.Leave += new System.EventHandler(this.txtEmp_Leave);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(259, 25);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 13);
            this.lblInfo.TabIndex = 39;
            this.lblInfo.Text = "Info";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(171, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 31);
            this.btnSearch.TabIndex = 101;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(164, 82);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 193;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.ForeColor = System.Drawing.Color.Red;
            this.smartLabel12.Location = new System.Drawing.Point(692, 136);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(21, 22);
            this.smartLabel12.TabIndex = 194;
            this.smartLabel12.Text = "*";
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.ForeColor = System.Drawing.Color.Red;
            this.smartLabel13.Location = new System.Drawing.Point(163, 191);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(21, 22);
            this.smartLabel13.TabIndex = 195;
            this.smartLabel13.Text = "*";
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.ForeColor = System.Drawing.Color.Red;
            this.smartLabel14.Location = new System.Drawing.Point(163, 241);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(21, 22);
            this.smartLabel14.TabIndex = 196;
            this.smartLabel14.Text = "*";
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.ForeColor = System.Drawing.Color.Red;
            this.smartLabel15.Location = new System.Drawing.Point(810, 136);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(21, 22);
            this.smartLabel15.TabIndex = 197;
            this.smartLabel15.Text = "*";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.ForeColor = System.Drawing.Color.Red;
            this.smartLabel16.Location = new System.Drawing.Point(934, 137);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(21, 22);
            this.smartLabel16.TabIndex = 198;
            this.smartLabel16.Text = "*";
            // 
            // smartLabel17
            // 
            this.smartLabel17.AutoSize = true;
            this.smartLabel17.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel17.ForeColor = System.Drawing.Color.Red;
            this.smartLabel17.Location = new System.Drawing.Point(934, 81);
            this.smartLabel17.Name = "smartLabel17";
            this.smartLabel17.Size = new System.Drawing.Size(21, 22);
            this.smartLabel17.TabIndex = 199;
            this.smartLabel17.Text = "*";
            // 
            // frmEmployeeTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(985, 706);
            this.isEnterTabAllow = true;
            this.Name = "frmEmployeeTraining";
            this.Load += new System.EventHandler(this.frmEmployeeTraning_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtTrainingTitle;
        private AtiqsControlLibrary.SmartTextBox txtTrainingType;
        private AtiqsControlLibrary.SmartTextBox txtOrganizationName;
        private AtiqsControlLibrary.SmartTextBox txtProvidedBy;
        private AtiqsControlLibrary.SmartTextBox txtSubject;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvEmployeeTraining;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartTextBox txtGrade;
        private AtiqsControlLibrary.SmartNumericTextBox txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartTextBox txtEmp;
        private AtiqsControlLibrary.SmartLabel lblInfo;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
        private AtiqsControlLibrary.SmartLabel smartLabel17;
    }
}
