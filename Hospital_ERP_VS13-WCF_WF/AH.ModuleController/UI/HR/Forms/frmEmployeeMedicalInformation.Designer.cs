namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmEmployeeMedicalInformation
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.txtEmpID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel17 = new AtiqsControlLibrary.SmartLabel();
            this.cboBloodGrp = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtSerial = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtEyeSight = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtHeight = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtWeight = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtDisabilities = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.chkDiabitics = new AtiqsControlLibrary.SmartCheckBox();
            this.txtBP = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtXrayReport = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtEcgReport = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtReportDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtMark = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.lvEmployeeMedicalInformation = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel20 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(329, 9);
            this.frmLabel.Size = new System.Drawing.Size(375, 33);
            this.frmLabel.Text = "Employee Medical Information";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.smartLabel20);
            this.pnlMain.Controls.Add(this.lvEmployeeMedicalInformation);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtMark);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtReportDate);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtEcgReport);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtXrayReport);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtBP);
            this.pnlMain.Controls.Add(this.chkDiabitics);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtDisabilities);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtWeight);
            this.pnlMain.Controls.Add(this.txtHeight);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtEyeSight);
            this.pnlMain.Controls.Add(this.smartLabel17);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.cboBloodGrp);
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(1032, 773);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1033, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(583, 692);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 692);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(696, 692);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(357, 692);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(918, 692);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(807, 692);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 733);
            this.groupBox1.Size = new System.Drawing.Size(1033, 25);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(125, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(216, 175);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 13);
            this.lblInfo.TabIndex = 104;
            this.lblInfo.Text = "Info";
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(8, 175);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(111, 24);
            this.txtEmpID.TabIndex = 0;
            this.txtEmpID.Leave += new System.EventHandler(this.txtEmp_Leave);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(8, 155);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 13);
            this.smartLabel1.TabIndex = 103;
            this.smartLabel1.Text = "Employee ID :";
            // 
            // smartLabel17
            // 
            this.smartLabel17.AutoSize = true;
            this.smartLabel17.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel17.Location = new System.Drawing.Point(598, 208);
            this.smartLabel17.Name = "smartLabel17";
            this.smartLabel17.Size = new System.Drawing.Size(91, 18);
            this.smartLabel17.TabIndex = 74;
            this.smartLabel17.Text = "Blood Group :";
            // 
            // cboBloodGrp
            // 
            this.cboBloodGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBloodGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBloodGrp.ForeColor = System.Drawing.Color.Blue;
            this.cboBloodGrp.FormattingEnabled = true;
            this.cboBloodGrp.Location = new System.Drawing.Point(601, 228);
            this.cboBloodGrp.Name = "cboBloodGrp";
            this.cboBloodGrp.Size = new System.Drawing.Size(90, 26);
            this.cboBloodGrp.TabIndex = 6;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(247, 691);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(47, 13);
            this.smartLabel11.TabIndex = 40;
            this.smartLabel11.Text = "Serial :";
            this.smartLabel11.Visible = false;
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(250, 707);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(69, 24);
            this.txtSerial.TabIndex = 39;
            this.txtSerial.Visible = false;
            // 
            // txtEyeSight
            // 
            this.txtEyeSight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEyeSight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEyeSight.Location = new System.Drawing.Point(8, 228);
            this.txtEyeSight.Name = "txtEyeSight";
            this.txtEyeSight.Size = new System.Drawing.Size(191, 24);
            this.txtEyeSight.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(8, 208);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(69, 13);
            this.smartLabel2.TabIndex = 107;
            this.smartLabel2.Text = "Eye Sight :";
            // 
            // txtHeight
            // 
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(225, 228);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(93, 24);
            this.txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(349, 228);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(87, 24);
            this.txtWeight.TabIndex = 4;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(225, 208);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(52, 13);
            this.smartLabel3.TabIndex = 110;
            this.smartLabel3.Text = "Height :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(349, 208);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(55, 13);
            this.smartLabel4.TabIndex = 111;
            this.smartLabel4.Text = "Weight :";
            // 
            // txtDisabilities
            // 
            this.txtDisabilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisabilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisabilities.Location = new System.Drawing.Point(727, 228);
            this.txtDisabilities.Name = "txtDisabilities";
            this.txtDisabilities.Size = new System.Drawing.Size(273, 24);
            this.txtDisabilities.TabIndex = 7;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(727, 208);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(76, 13);
            this.smartLabel5.TabIndex = 113;
            this.smartLabel5.Text = "Disabilities :";
            // 
            // chkDiabitics
            // 
            this.chkDiabitics.AutoSize = true;
            this.chkDiabitics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDiabitics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDiabitics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiabitics.ForeColor = System.Drawing.Color.Black;
            this.chkDiabitics.Location = new System.Drawing.Point(727, 283);
            this.chkDiabitics.Name = "chkDiabitics";
            this.chkDiabitics.Size = new System.Drawing.Size(153, 22);
            this.chkDiabitics.TabIndex = 10;
            this.chkDiabitics.Text = "Is Diabetic Patient ?";
            this.chkDiabitics.UseVisualStyleBackColor = true;
            // 
            // txtBP
            // 
            this.txtBP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBP.Location = new System.Drawing.Point(463, 228);
            this.txtBP.Multiline = true;
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(114, 26);
            this.txtBP.TabIndex = 5;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(463, 208);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(104, 18);
            this.smartLabel6.TabIndex = 116;
            this.smartLabel6.Text = "Blood Pressure :";
            // 
            // txtXrayReport
            // 
            this.txtXrayReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXrayReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXrayReport.Location = new System.Drawing.Point(9, 283);
            this.txtXrayReport.Multiline = true;
            this.txtXrayReport.Name = "txtXrayReport";
            this.txtXrayReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXrayReport.Size = new System.Drawing.Size(309, 67);
            this.txtXrayReport.TabIndex = 8;
            this.txtXrayReport.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtXrayReport_PreviewKeyDown);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(9, 262);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(93, 18);
            this.smartLabel7.TabIndex = 118;
            this.smartLabel7.Text = "X-Ray Report :";
            // 
            // txtEcgReport
            // 
            this.txtEcgReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEcgReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEcgReport.Location = new System.Drawing.Point(349, 283);
            this.txtEcgReport.Multiline = true;
            this.txtEcgReport.Name = "txtEcgReport";
            this.txtEcgReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEcgReport.Size = new System.Drawing.Size(340, 67);
            this.txtEcgReport.TabIndex = 9;
            this.txtEcgReport.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtEcgReport_PreviewKeyDown);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(349, 262);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(85, 18);
            this.smartLabel8.TabIndex = 120;
            this.smartLabel8.Text = "ECG Report :";
            // 
            // txtReportDate
            // 
            this.txtReportDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtReportDate.Location = new System.Drawing.Point(898, 283);
            this.txtReportDate.Mask = "00/00/0000";
            this.txtReportDate.Name = "txtReportDate";
            this.txtReportDate.Size = new System.Drawing.Size(105, 24);
            this.txtReportDate.TabIndex = 11;
            this.txtReportDate.ValidatingType = typeof(System.DateTime);
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(898, 262);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(86, 18);
            this.smartLabel9.TabIndex = 122;
            this.smartLabel9.Text = "Report Date :";
            // 
            // txtMark
            // 
            this.txtMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMark.Location = new System.Drawing.Point(727, 326);
            this.txtMark.Multiline = true;
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(276, 24);
            this.txtMark.TabIndex = 12;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(727, 307);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(47, 18);
            this.smartLabel10.TabIndex = 124;
            this.smartLabel10.Text = "Mark :";
            // 
            // lvEmployeeMedicalInformation
            // 
            this.lvEmployeeMedicalInformation.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvEmployeeMedicalInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmployeeMedicalInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmployeeMedicalInformation.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployeeMedicalInformation.FullRowSelect = true;
            this.lvEmployeeMedicalInformation.GridLines = true;
            this.lvEmployeeMedicalInformation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmployeeMedicalInformation.Location = new System.Drawing.Point(-1, 376);
            this.lvEmployeeMedicalInformation.Name = "lvEmployeeMedicalInformation";
            this.lvEmployeeMedicalInformation.Size = new System.Drawing.Size(1032, 396);
            this.lvEmployeeMedicalInformation.TabIndex = 125;
            this.lvEmployeeMedicalInformation.UseCompatibleStateImageBehavior = false;
            this.lvEmployeeMedicalInformation.View = System.Windows.Forms.View.Details;
            this.lvEmployeeMedicalInformation.SelectedIndexChanged += new System.EventHandler(this.lvEmployeeMedicalInformation_SelectedIndexChanged);
            this.lvEmployeeMedicalInformation.Click += new System.EventHandler(this.lvEmployeeMedicalInformation_Click);
            // 
            // smartLabel20
            // 
            this.smartLabel20.AutoSize = true;
            this.smartLabel20.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel20.ForeColor = System.Drawing.Color.Red;
            this.smartLabel20.Location = new System.Drawing.Point(200, 227);
            this.smartLabel20.Name = "smartLabel20";
            this.smartLabel20.Size = new System.Drawing.Size(21, 22);
            this.smartLabel20.TabIndex = 155;
            this.smartLabel20.Text = "*";
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.ForeColor = System.Drawing.Color.Red;
            this.smartLabel12.Location = new System.Drawing.Point(324, 227);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(21, 22);
            this.smartLabel12.TabIndex = 156;
            this.smartLabel12.Text = "*";
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.ForeColor = System.Drawing.Color.Red;
            this.smartLabel13.Location = new System.Drawing.Point(441, 227);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(21, 22);
            this.smartLabel13.TabIndex = 157;
            this.smartLabel13.Text = "*";
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.ForeColor = System.Drawing.Color.Red;
            this.smartLabel14.Location = new System.Drawing.Point(1009, 280);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(21, 22);
            this.smartLabel14.TabIndex = 158;
            this.smartLabel14.Text = "*";
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.ForeColor = System.Drawing.Color.Red;
            this.smartLabel15.Location = new System.Drawing.Point(580, 227);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(21, 22);
            this.smartLabel15.TabIndex = 159;
            this.smartLabel15.Text = "*";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.ForeColor = System.Drawing.Color.Red;
            this.smartLabel16.Location = new System.Drawing.Point(691, 227);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(21, 22);
            this.smartLabel16.TabIndex = 160;
            this.smartLabel16.Text = "*";
            // 
            // frmEmployeeMedicalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1033, 758);
            this.Controls.Add(this.smartLabel11);
            this.Controls.Add(this.txtSerial);
            this.isEnterTabAllow = true;
            this.Name = "frmEmployeeMedicalInformation";
            this.Load += new System.EventHandler(this.frmEmployeeMedicalInformation_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.txtSerial, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.smartLabel11, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartTextBox txtEmpID;
        private AtiqsControlLibrary.SmartLabel lblInfo;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel17;
        private AtiqsControlLibrary.SmartComboBox cboBloodGrp;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartNumericTextBox txtSerial;
        private AtiqsControlLibrary.SmartTextBox txtEyeSight;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartNumericTextBox txtHeight;
        private AtiqsControlLibrary.SmartNumericTextBox txtWeight;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtDisabilities;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartCheckBox chkDiabitics;
        private AtiqsControlLibrary.SmartTextBox txtBP;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtXrayReport;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtEcgReport;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartDateTextBox txtReportDate;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartTextBox txtMark;
        private AtiqsControlLibrary.SmartListViewDetails lvEmployeeMedicalInformation;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel20;
    }
}
