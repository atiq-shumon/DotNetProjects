namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmSalaryCycle
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtFormDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtToDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtTotalNoDays = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtTotalFriday = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtTotalHoliday = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtTotalWorkDays = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtMonthType = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.cbMonthStatus = new AtiqsControlLibrary.SmartCheckBox();
            this.cbEidFlag = new AtiqsControlLibrary.SmartCheckBox();
            this.cbMonthEndFlag = new AtiqsControlLibrary.SmartCheckBox();
            this.lvSalaryCycle = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboMonthNumber = new AtiqsControlLibrary.SmartComboBox();
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.txtMonthID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel17 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(375, 9);
            this.frmLabel.Size = new System.Drawing.Size(156, 33);
            this.frmLabel.Text = "Salary Cycle";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel18);
            this.pnlMain.Controls.Add(this.smartLabel17);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.txtMonthID);
            this.pnlMain.Controls.Add(this.cboYear);
            this.pnlMain.Controls.Add(this.cboMonthNumber);
            this.pnlMain.Controls.Add(this.lvSalaryCycle);
            this.pnlMain.Controls.Add(this.cbMonthEndFlag);
            this.pnlMain.Controls.Add(this.cbEidFlag);
            this.pnlMain.Controls.Add(this.cbMonthStatus);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.txtMonthType);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtTotalWorkDays);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtTotalHoliday);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtTotalFriday);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtTotalNoDays);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtToDate);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtFormDate);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(887, 515);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(887, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(549, 579);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(435, 579);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 586);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(321, 579);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(776, 579);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(665, 579);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 625);
            this.groupBox1.Size = new System.Drawing.Size(887, 23);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(187, 19);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(63, 13);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Month ID:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(14, 19);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(41, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Year :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(14, 80);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(93, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Month Number:";
            // 
            // txtFormDate
            // 
            this.txtFormDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFormDate.Location = new System.Drawing.Point(350, 103);
            this.txtFormDate.Mask = "00/00/0000";
            this.txtFormDate.Name = "txtFormDate";
            this.txtFormDate.Size = new System.Drawing.Size(120, 24);
            this.txtFormDate.TabIndex = 5;
            this.txtFormDate.ValidatingType = typeof(System.DateTime);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(350, 80);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(73, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Form Date :";
            // 
            // txtToDate
            // 
            this.txtToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtToDate.Location = new System.Drawing.Point(518, 103);
            this.txtToDate.Mask = "00/00/0000";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(125, 24);
            this.txtToDate.TabIndex = 6;
            this.txtToDate.ValidatingType = typeof(System.DateTime);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(518, 80);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(61, 13);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "To Date :";
            // 
            // txtTotalNoDays
            // 
            this.txtTotalNoDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalNoDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNoDays.Location = new System.Drawing.Point(14, 161);
            this.txtTotalNoDays.MaxLength = 3;
            this.txtTotalNoDays.Name = "txtTotalNoDays";
            this.txtTotalNoDays.Size = new System.Drawing.Size(132, 24);
            this.txtTotalNoDays.TabIndex = 7;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(14, 145);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(72, 13);
            this.smartLabel6.TabIndex = 11;
            this.smartLabel6.Text = "Total Days:";
            // 
            // txtTotalFriday
            // 
            this.txtTotalFriday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFriday.Location = new System.Drawing.Point(187, 161);
            this.txtTotalFriday.MaxLength = 3;
            this.txtTotalFriday.Name = "txtTotalFriday";
            this.txtTotalFriday.Size = new System.Drawing.Size(121, 24);
            this.txtTotalFriday.TabIndex = 8;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(187, 145);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(78, 13);
            this.smartLabel7.TabIndex = 13;
            this.smartLabel7.Text = "Total Friday:";
            // 
            // txtTotalHoliday
            // 
            this.txtTotalHoliday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHoliday.Location = new System.Drawing.Point(350, 161);
            this.txtTotalHoliday.MaxLength = 3;
            this.txtTotalHoliday.Name = "txtTotalHoliday";
            this.txtTotalHoliday.Size = new System.Drawing.Size(120, 24);
            this.txtTotalHoliday.TabIndex = 9;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(350, 145);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(86, 13);
            this.smartLabel8.TabIndex = 15;
            this.smartLabel8.Text = "Total Holiday:";
            // 
            // txtTotalWorkDays
            // 
            this.txtTotalWorkDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalWorkDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalWorkDays.Location = new System.Drawing.Point(518, 161);
            this.txtTotalWorkDays.MaxLength = 3;
            this.txtTotalWorkDays.Name = "txtTotalWorkDays";
            this.txtTotalWorkDays.Size = new System.Drawing.Size(125, 24);
            this.txtTotalWorkDays.TabIndex = 10;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(518, 145);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(106, 13);
            this.smartLabel9.TabIndex = 17;
            this.smartLabel9.Text = "Total Work Days:";
            // 
            // txtMonthType
            // 
            this.txtMonthType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonthType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthType.Location = new System.Drawing.Point(187, 103);
            this.txtMonthType.MaxLength = 1;
            this.txtMonthType.Name = "txtMonthType";
            this.txtMonthType.Size = new System.Drawing.Size(121, 24);
            this.txtMonthType.TabIndex = 4;
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(187, 80);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(82, 13);
            this.smartLabel14.TabIndex = 29;
            this.smartLabel14.Text = "Month Type :";
            // 
            // cbMonthStatus
            // 
            this.cbMonthStatus.AutoSize = true;
            this.cbMonthStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMonthStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonthStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonthStatus.ForeColor = System.Drawing.Color.Black;
            this.cbMonthStatus.Location = new System.Drawing.Point(688, 107);
            this.cbMonthStatus.Name = "cbMonthStatus";
            this.cbMonthStatus.Size = new System.Drawing.Size(112, 22);
            this.cbMonthStatus.TabIndex = 14;
            this.cbMonthStatus.Text = "Month Status";
            this.cbMonthStatus.UseVisualStyleBackColor = true;
            // 
            // cbEidFlag
            // 
            this.cbEidFlag.AutoSize = true;
            this.cbEidFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEidFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEidFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEidFlag.ForeColor = System.Drawing.Color.Black;
            this.cbEidFlag.Location = new System.Drawing.Point(689, 135);
            this.cbEidFlag.Name = "cbEidFlag";
            this.cbEidFlag.Size = new System.Drawing.Size(77, 22);
            this.cbEidFlag.TabIndex = 15;
            this.cbEidFlag.Text = "Eid Flag";
            this.cbEidFlag.UseVisualStyleBackColor = true;
            // 
            // cbMonthEndFlag
            // 
            this.cbMonthEndFlag.AutoSize = true;
            this.cbMonthEndFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMonthEndFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonthEndFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonthEndFlag.ForeColor = System.Drawing.Color.Black;
            this.cbMonthEndFlag.Location = new System.Drawing.Point(688, 163);
            this.cbMonthEndFlag.Name = "cbMonthEndFlag";
            this.cbMonthEndFlag.Size = new System.Drawing.Size(128, 22);
            this.cbMonthEndFlag.TabIndex = 16;
            this.cbMonthEndFlag.Text = "Month End Flag";
            this.cbMonthEndFlag.UseVisualStyleBackColor = true;
            // 
            // lvSalaryCycle
            // 
            this.lvSalaryCycle.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvSalaryCycle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSalaryCycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSalaryCycle.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSalaryCycle.FullRowSelect = true;
            this.lvSalaryCycle.GridLines = true;
            this.lvSalaryCycle.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSalaryCycle.Location = new System.Drawing.Point(-1, 229);
            this.lvSalaryCycle.Name = "lvSalaryCycle";
            this.lvSalaryCycle.Size = new System.Drawing.Size(887, 285);
            this.lvSalaryCycle.TabIndex = 36;
            this.lvSalaryCycle.UseCompatibleStateImageBehavior = false;
            this.lvSalaryCycle.View = System.Windows.Forms.View.Details;
            this.lvSalaryCycle.SelectedIndexChanged += new System.EventHandler(this.lvSalaryCycle_SelectedIndexChanged);
            this.lvSalaryCycle.Click += new System.EventHandler(this.lvSalaryCycle_Click);
            // 
            // cboMonthNumber
            // 
            this.cboMonthNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonthNumber.ForeColor = System.Drawing.Color.Blue;
            this.cboMonthNumber.FormattingEnabled = true;
            this.cboMonthNumber.Location = new System.Drawing.Point(14, 103);
            this.cboMonthNumber.Name = "cboMonthNumber";
            this.cboMonthNumber.Size = new System.Drawing.Size(132, 26);
            this.cboMonthNumber.TabIndex = 3;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(14, 40);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(132, 26);
            this.cboYear.TabIndex = 1;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // txtMonthID
            // 
            this.txtMonthID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtMonthID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonthID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMonthID.Location = new System.Drawing.Point(187, 40);
            this.txtMonthID.Name = "txtMonthID";
            this.txtMonthID.ReadOnly = true;
            this.txtMonthID.Size = new System.Drawing.Size(121, 24);
            this.txtMonthID.TabIndex = 37;
            this.txtMonthID.TabStop = false;
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(147, 40);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 193;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.ForeColor = System.Drawing.Color.Red;
            this.smartLabel10.Location = new System.Drawing.Point(146, 103);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(21, 22);
            this.smartLabel10.TabIndex = 194;
            this.smartLabel10.Text = "*";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.ForeColor = System.Drawing.Color.Red;
            this.smartLabel11.Location = new System.Drawing.Point(146, 161);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(21, 22);
            this.smartLabel11.TabIndex = 195;
            this.smartLabel11.Text = "*";
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.ForeColor = System.Drawing.Color.Red;
            this.smartLabel12.Location = new System.Drawing.Point(312, 103);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(21, 22);
            this.smartLabel12.TabIndex = 196;
            this.smartLabel12.Text = "*";
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.ForeColor = System.Drawing.Color.Red;
            this.smartLabel13.Location = new System.Drawing.Point(470, 103);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(21, 22);
            this.smartLabel13.TabIndex = 197;
            this.smartLabel13.Text = "*";
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.ForeColor = System.Drawing.Color.Red;
            this.smartLabel15.Location = new System.Drawing.Point(645, 103);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(21, 22);
            this.smartLabel15.TabIndex = 198;
            this.smartLabel15.Text = "*";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.ForeColor = System.Drawing.Color.Red;
            this.smartLabel16.Location = new System.Drawing.Point(470, 161);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(21, 22);
            this.smartLabel16.TabIndex = 199;
            this.smartLabel16.Text = "*";
            // 
            // smartLabel17
            // 
            this.smartLabel17.AutoSize = true;
            this.smartLabel17.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel17.ForeColor = System.Drawing.Color.Red;
            this.smartLabel17.Location = new System.Drawing.Point(645, 161);
            this.smartLabel17.Name = "smartLabel17";
            this.smartLabel17.Size = new System.Drawing.Size(21, 22);
            this.smartLabel17.TabIndex = 200;
            this.smartLabel17.Text = "*";
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.ForeColor = System.Drawing.Color.Red;
            this.smartLabel18.Location = new System.Drawing.Point(312, 161);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(21, 22);
            this.smartLabel18.TabIndex = 201;
            this.smartLabel18.Text = "*";
            // 
            // frmSalaryCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(887, 648);
            this.Name = "frmSalaryCycle";
            this.Load += new System.EventHandler(this.frmSalaryCycle_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartDateTextBox txtFormDate;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartDateTextBox txtToDate;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartNumericTextBox txtTotalNoDays;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartNumericTextBox txtTotalHoliday;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartNumericTextBox txtTotalFriday;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartNumericTextBox txtTotalWorkDays;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartTextBox txtMonthType;
        private AtiqsControlLibrary.SmartCheckBox cbMonthStatus;
        private AtiqsControlLibrary.SmartCheckBox cbEidFlag;
        private AtiqsControlLibrary.SmartCheckBox cbMonthEndFlag;
        private AtiqsControlLibrary.SmartListViewDetails lvSalaryCycle;
        private AtiqsControlLibrary.SmartComboBox cboMonthNumber;
        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMonthID;
        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartLabel smartLabel17;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
    }
}
