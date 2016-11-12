namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmLeaveApproved
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
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmp = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboLeaveCause = new AtiqsControlLibrary.SmartComboBox();
            this.txtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.txtAddress = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtApprovedByHead = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarksHead = new AtiqsControlLibrary.SmartTextBox();
            this.cboCancelCauseHead = new AtiqsControlLibrary.SmartComboBox();
            this.chkAppHeadYes = new AtiqsControlLibrary.SmartCheckBox();
            this.lblRemarks = new AtiqsControlLibrary.SmartLabel();
            this.lblCancelCauseHd = new AtiqsControlLibrary.SmartLabel();
            this.txtResponsibility = new AtiqsControlLibrary.SmartTextBox();
            this.pnlHead = new System.Windows.Forms.GroupBox();
            this.txtApprovedByHeadName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefreshCauseHD = new System.Windows.Forms.Button();
            this.btnAddCauseHD = new System.Windows.Forms.Button();
            this.chkAppHeadNo = new AtiqsControlLibrary.SmartCheckBox();
            this.pnlHR = new System.Windows.Forms.GroupBox();
            this.txtApprovedByHRName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefreshCauseHR = new System.Windows.Forms.Button();
            this.chkAppHRNo = new AtiqsControlLibrary.SmartCheckBox();
            this.btnAddCauseHR = new System.Windows.Forms.Button();
            this.chkAppHRYes = new AtiqsControlLibrary.SmartCheckBox();
            this.cboCancelCauseHR = new AtiqsControlLibrary.SmartComboBox();
            this.lblCancelCauseHR = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarksHR = new AtiqsControlLibrary.SmartTextBox();
            this.txtApprovedByHR = new AtiqsControlLibrary.SmartTextBox();
            this.cboLeaveType = new AtiqsControlLibrary.SmartComboBox();
            this.txtserial = new AtiqsControlLibrary.SmartTextBox();
            this.txtResponsibilityHolderName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtEmpName = new AtiqsControlLibrary.SmartTextBox();
            this.txtTO = new AtiqsControlLibrary.SmartTextBox();
            this.txtFrom = new AtiqsControlLibrary.SmartTextBox();
            this.pnlRptPrsn = new System.Windows.Forms.GroupBox();
            this.txtApprvdByRptName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRefreshCancelCauseRptPrsn = new System.Windows.Forms.Button();
            this.btnAddCancelCauseRpt = new System.Windows.Forms.Button();
            this.chkAppRptNo = new AtiqsControlLibrary.SmartCheckBox();
            this.chkAppRptYes = new AtiqsControlLibrary.SmartCheckBox();
            this.cboCancelCauseRpt = new AtiqsControlLibrary.SmartComboBox();
            this.lblCancelCauseRpt = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarksRptPrsn = new AtiqsControlLibrary.SmartTextBox();
            this.txtApprovedByRpt = new AtiqsControlLibrary.SmartTextBox();
            this.txtLeaveWithPay = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtLeaveWithoutpay = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.txtTotalDays = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlHR.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlRptPrsn.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(402, 9);
            this.frmLabel.Size = new System.Drawing.Size(274, 33);
            this.frmLabel.Text = "Leave Approved Form";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtTotalDays);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.txtLeaveWithoutpay);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtLeaveWithPay);
            this.pnlMain.Controls.Add(this.pnlRptPrsn);
            this.pnlMain.Controls.Add(this.txtEmpName);
            this.pnlMain.Controls.Add(this.txtResponsibilityHolderName);
            this.pnlMain.Controls.Add(this.pnlHR);
            this.pnlMain.Controls.Add(this.pnlHead);
            this.pnlMain.Controls.Add(this.cboYear);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboLeaveCause);
            this.pnlMain.Controls.Add(this.cboLeaveType);
            this.pnlMain.Controls.Add(this.txtStartDate);
            this.pnlMain.Controls.Add(this.txtAddress);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtEndDate);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(1050, 549);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1050, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(44, 610);
            this.btnEdit.Size = new System.Drawing.Size(51, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(820, 610);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(101, 610);
            this.btnDelete.Size = new System.Drawing.Size(36, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(707, 610);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(934, 609);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(143, 610);
            this.btnPrint.Size = new System.Drawing.Size(28, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 651);
            this.groupBox1.Size = new System.Drawing.Size(1050, 25);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(16, 51);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(86, 26);
            this.cboYear.TabIndex = 177;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(105, 30);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(61, 13);
            this.smartLabel1.TabIndex = 176;
            this.smartLabel1.Text = "Employee";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(16, 30);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(33, 13);
            this.smartLabel2.TabIndex = 179;
            this.smartLabel2.Text = "Year";
            // 
            // txtEmp
            // 
            this.txtEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp.Location = new System.Drawing.Point(136, 610);
            this.txtEmp.MaxLength = 10;
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(39, 24);
            this.txtEmp.TabIndex = 178;
            this.txtEmp.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(16, 95);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(74, 13);
            this.smartLabel3.TabIndex = 181;
            this.smartLabel3.Text = "Leave Type";
            // 
            // cboLeaveCause
            // 
            this.cboLeaveCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaveCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLeaveCause.ForeColor = System.Drawing.Color.Blue;
            this.cboLeaveCause.FormattingEnabled = true;
            this.cboLeaveCause.Location = new System.Drawing.Point(16, 223);
            this.cboLeaveCause.Name = "cboLeaveCause";
            this.cboLeaveCause.Size = new System.Drawing.Size(150, 26);
            this.cboLeaveCause.TabIndex = 182;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtStartDate.Location = new System.Drawing.Point(16, 171);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(152, 24);
            this.txtStartDate.TabIndex = 183;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(16, 399);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(324, 129);
            this.txtAddress.TabIndex = 186;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(16, 152);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(65, 13);
            this.smartLabel4.TabIndex = 185;
            this.smartLabel4.Text = "Start Date";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(16, 317);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(126, 13);
            this.smartLabel8.TabIndex = 190;
            this.smartLabel8.Text = "Responsibility Holder";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEndDate.Location = new System.Drawing.Point(182, 171);
            this.txtEndDate.Mask = "00/00/0000";
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(158, 24);
            this.txtEndDate.TabIndex = 184;
            this.txtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(16, 376);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(143, 13);
            this.smartLabel7.TabIndex = 189;
            this.smartLabel7.Text = "Address While On leave";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(179, 152);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(60, 13);
            this.smartLabel5.TabIndex = 187;
            this.smartLabel5.Text = "End Date";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(16, 203);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(81, 13);
            this.smartLabel6.TabIndex = 188;
            this.smartLabel6.Text = "Leave Cause";
            // 
            // txtApprovedByHead
            // 
            this.txtApprovedByHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprovedByHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedByHead.Location = new System.Drawing.Point(177, 610);
            this.txtApprovedByHead.MaxLength = 10;
            this.txtApprovedByHead.Name = "txtApprovedByHead";
            this.txtApprovedByHead.Size = new System.Drawing.Size(49, 24);
            this.txtApprovedByHead.TabIndex = 194;
            this.txtApprovedByHead.Visible = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(22, 27);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(113, 13);
            this.smartLabel9.TabIndex = 195;
            this.smartLabel9.Text = "Approved By Head";
            // 
            // txtRemarksHead
            // 
            this.txtRemarksHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarksHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarksHead.Location = new System.Drawing.Point(358, 47);
            this.txtRemarksHead.MaxLength = 250;
            this.txtRemarksHead.Multiline = true;
            this.txtRemarksHead.Name = "txtRemarksHead";
            this.txtRemarksHead.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarksHead.Size = new System.Drawing.Size(309, 25);
            this.txtRemarksHead.TabIndex = 198;
            // 
            // cboCancelCauseHead
            // 
            this.cboCancelCauseHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCancelCauseHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCancelCauseHead.ForeColor = System.Drawing.Color.Blue;
            this.cboCancelCauseHead.FormattingEnabled = true;
            this.cboCancelCauseHead.Location = new System.Drawing.Point(338, 33);
            this.cboCancelCauseHead.Name = "cboCancelCauseHead";
            this.cboCancelCauseHead.Size = new System.Drawing.Size(236, 26);
            this.cboCancelCauseHead.TabIndex = 197;
            // 
            // chkAppHeadYes
            // 
            this.chkAppHeadYes.AutoSize = true;
            this.chkAppHeadYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAppHeadYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAppHeadYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAppHeadYes.ForeColor = System.Drawing.Color.Black;
            this.chkAppHeadYes.Location = new System.Drawing.Point(10, 33);
            this.chkAppHeadYes.Name = "chkAppHeadYes";
            this.chkAppHeadYes.Size = new System.Drawing.Size(86, 22);
            this.chkAppHeadYes.TabIndex = 196;
            this.chkAppHeadYes.Text = "Approved";
            this.chkAppHeadYes.UseVisualStyleBackColor = true;
            this.chkAppHeadYes.Click += new System.EventHandler(this.chkAppHead_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.Location = new System.Drawing.Point(355, 27);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(56, 13);
            this.lblRemarks.TabIndex = 200;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblCancelCauseHd
            // 
            this.lblCancelCauseHd.AutoSize = true;
            this.lblCancelCauseHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCancelCauseHd.Location = new System.Drawing.Point(338, 13);
            this.lblCancelCauseHd.Name = "lblCancelCauseHd";
            this.lblCancelCauseHd.Size = new System.Drawing.Size(85, 13);
            this.lblCancelCauseHd.TabIndex = 199;
            this.lblCancelCauseHd.Text = "Cancel Cause";
            // 
            // txtResponsibility
            // 
            this.txtResponsibility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResponsibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsibility.Location = new System.Drawing.Point(19, 610);
            this.txtResponsibility.MaxLength = 10;
            this.txtResponsibility.Name = "txtResponsibility";
            this.txtResponsibility.Size = new System.Drawing.Size(47, 24);
            this.txtResponsibility.TabIndex = 201;
            this.txtResponsibility.Visible = false;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Transparent;
            this.pnlHead.Controls.Add(this.txtApprovedByHeadName);
            this.pnlHead.Controls.Add(this.groupBox2);
            this.pnlHead.Controls.Add(this.smartLabel9);
            this.pnlHead.Controls.Add(this.lblRemarks);
            this.pnlHead.Controls.Add(this.txtRemarksHead);
            this.pnlHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlHead.Location = new System.Drawing.Point(357, 176);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(680, 168);
            this.pnlHead.TabIndex = 202;
            this.pnlHead.TabStop = false;
            this.pnlHead.Text = "Head";
            // 
            // txtApprovedByHeadName
            // 
            this.txtApprovedByHeadName.BackColor = System.Drawing.Color.Linen;
            this.txtApprovedByHeadName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprovedByHeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedByHeadName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtApprovedByHeadName.Location = new System.Drawing.Point(25, 47);
            this.txtApprovedByHeadName.MaxLength = 10;
            this.txtApprovedByHeadName.Name = "txtApprovedByHeadName";
            this.txtApprovedByHeadName.ReadOnly = true;
            this.txtApprovedByHeadName.Size = new System.Drawing.Size(310, 24);
            this.txtApprovedByHeadName.TabIndex = 205;
            this.txtApprovedByHeadName.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshCauseHD);
            this.groupBox2.Controls.Add(this.btnAddCauseHD);
            this.groupBox2.Controls.Add(this.chkAppHeadNo);
            this.groupBox2.Controls.Add(this.chkAppHeadYes);
            this.groupBox2.Controls.Add(this.cboCancelCauseHead);
            this.groupBox2.Controls.Add(this.lblCancelCauseHd);
            this.groupBox2.Location = new System.Drawing.Point(20, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 82);
            this.groupBox2.TabIndex = 204;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Approval of Head";
            // 
            // btnRefreshCauseHD
            // 
            this.btnRefreshCauseHD.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshCauseHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCauseHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCauseHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCauseHD.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCauseHD.Location = new System.Drawing.Point(616, 33);
            this.btnRefreshCauseHD.Name = "btnRefreshCauseHD";
            this.btnRefreshCauseHD.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshCauseHD.TabIndex = 202;
            this.btnRefreshCauseHD.TabStop = false;
            this.btnRefreshCauseHD.Text = "..";
            this.btnRefreshCauseHD.UseVisualStyleBackColor = false;
            this.btnRefreshCauseHD.Click += new System.EventHandler(this.btnRefreshCauseHD_Click);
            // 
            // btnAddCauseHD
            // 
            this.btnAddCauseHD.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCauseHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCauseHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCauseHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCauseHD.ForeColor = System.Drawing.Color.White;
            this.btnAddCauseHD.Location = new System.Drawing.Point(580, 33);
            this.btnAddCauseHD.Name = "btnAddCauseHD";
            this.btnAddCauseHD.Size = new System.Drawing.Size(32, 26);
            this.btnAddCauseHD.TabIndex = 201;
            this.btnAddCauseHD.TabStop = false;
            this.btnAddCauseHD.Text = "+";
            this.btnAddCauseHD.UseVisualStyleBackColor = false;
            this.btnAddCauseHD.Click += new System.EventHandler(this.btnAddCauseHD_Click);
            // 
            // chkAppHeadNo
            // 
            this.chkAppHeadNo.AutoSize = true;
            this.chkAppHeadNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAppHeadNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAppHeadNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAppHeadNo.ForeColor = System.Drawing.Color.Black;
            this.chkAppHeadNo.Location = new System.Drawing.Point(201, 33);
            this.chkAppHeadNo.Name = "chkAppHeadNo";
            this.chkAppHeadNo.Size = new System.Drawing.Size(114, 22);
            this.chkAppHeadNo.TabIndex = 200;
            this.chkAppHeadNo.Text = "Not Approved";
            this.chkAppHeadNo.UseVisualStyleBackColor = true;
            this.chkAppHeadNo.Click += new System.EventHandler(this.chkAppHeadNo_Click);
            // 
            // pnlHR
            // 
            this.pnlHR.BackColor = System.Drawing.Color.Transparent;
            this.pnlHR.Controls.Add(this.txtApprovedByHRName);
            this.pnlHR.Controls.Add(this.groupBox3);
            this.pnlHR.Controls.Add(this.smartLabel10);
            this.pnlHR.Controls.Add(this.smartLabel11);
            this.pnlHR.Controls.Add(this.txtRemarksHR);
            this.pnlHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHR.Location = new System.Drawing.Point(357, 345);
            this.pnlHR.Name = "pnlHR";
            this.pnlHR.Size = new System.Drawing.Size(684, 183);
            this.pnlHR.TabIndex = 203;
            this.pnlHR.TabStop = false;
            this.pnlHR.Text = "HR";
            // 
            // txtApprovedByHRName
            // 
            this.txtApprovedByHRName.BackColor = System.Drawing.Color.Linen;
            this.txtApprovedByHRName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprovedByHRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedByHRName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtApprovedByHRName.Location = new System.Drawing.Point(18, 54);
            this.txtApprovedByHRName.MaxLength = 10;
            this.txtApprovedByHRName.Name = "txtApprovedByHRName";
            this.txtApprovedByHRName.ReadOnly = true;
            this.txtApprovedByHRName.Size = new System.Drawing.Size(310, 24);
            this.txtApprovedByHRName.TabIndex = 206;
            this.txtApprovedByHRName.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefreshCauseHR);
            this.groupBox3.Controls.Add(this.chkAppHRNo);
            this.groupBox3.Controls.Add(this.btnAddCauseHR);
            this.groupBox3.Controls.Add(this.chkAppHRYes);
            this.groupBox3.Controls.Add(this.cboCancelCauseHR);
            this.groupBox3.Controls.Add(this.lblCancelCauseHR);
            this.groupBox3.Location = new System.Drawing.Point(17, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(653, 78);
            this.groupBox3.TabIndex = 205;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Approval of HR";
            // 
            // btnRefreshCauseHR
            // 
            this.btnRefreshCauseHR.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshCauseHR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCauseHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCauseHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCauseHR.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCauseHR.Location = new System.Drawing.Point(611, 36);
            this.btnRefreshCauseHR.Name = "btnRefreshCauseHR";
            this.btnRefreshCauseHR.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshCauseHR.TabIndex = 204;
            this.btnRefreshCauseHR.TabStop = false;
            this.btnRefreshCauseHR.Text = "..";
            this.btnRefreshCauseHR.UseVisualStyleBackColor = false;
            this.btnRefreshCauseHR.Click += new System.EventHandler(this.btnRefreshCauseHR_Click);
            // 
            // chkAppHRNo
            // 
            this.chkAppHRNo.AutoSize = true;
            this.chkAppHRNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAppHRNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAppHRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAppHRNo.ForeColor = System.Drawing.Color.Black;
            this.chkAppHRNo.Location = new System.Drawing.Point(201, 36);
            this.chkAppHRNo.Name = "chkAppHRNo";
            this.chkAppHRNo.Size = new System.Drawing.Size(114, 22);
            this.chkAppHRNo.TabIndex = 200;
            this.chkAppHRNo.Text = "Not Approved";
            this.chkAppHRNo.UseVisualStyleBackColor = true;
            this.chkAppHRNo.Click += new System.EventHandler(this.chkAppHRNo_Click);
            // 
            // btnAddCauseHR
            // 
            this.btnAddCauseHR.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCauseHR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCauseHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCauseHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCauseHR.ForeColor = System.Drawing.Color.White;
            this.btnAddCauseHR.Location = new System.Drawing.Point(575, 36);
            this.btnAddCauseHR.Name = "btnAddCauseHR";
            this.btnAddCauseHR.Size = new System.Drawing.Size(32, 26);
            this.btnAddCauseHR.TabIndex = 203;
            this.btnAddCauseHR.TabStop = false;
            this.btnAddCauseHR.Text = "+";
            this.btnAddCauseHR.UseVisualStyleBackColor = false;
            this.btnAddCauseHR.Click += new System.EventHandler(this.btnAddCauseHR_Click);
            // 
            // chkAppHRYes
            // 
            this.chkAppHRYes.AutoSize = true;
            this.chkAppHRYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAppHRYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAppHRYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAppHRYes.ForeColor = System.Drawing.Color.Black;
            this.chkAppHRYes.Location = new System.Drawing.Point(10, 36);
            this.chkAppHRYes.Name = "chkAppHRYes";
            this.chkAppHRYes.Size = new System.Drawing.Size(86, 22);
            this.chkAppHRYes.TabIndex = 196;
            this.chkAppHRYes.Text = "Approved";
            this.chkAppHRYes.UseVisualStyleBackColor = true;
            this.chkAppHRYes.Click += new System.EventHandler(this.chkAppHRYes_Click);
            // 
            // cboCancelCauseHR
            // 
            this.cboCancelCauseHR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCancelCauseHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCancelCauseHR.ForeColor = System.Drawing.Color.Blue;
            this.cboCancelCauseHR.FormattingEnabled = true;
            this.cboCancelCauseHR.Location = new System.Drawing.Point(337, 36);
            this.cboCancelCauseHR.Name = "cboCancelCauseHR";
            this.cboCancelCauseHR.Size = new System.Drawing.Size(232, 26);
            this.cboCancelCauseHR.TabIndex = 197;
            // 
            // lblCancelCauseHR
            // 
            this.lblCancelCauseHR.AutoSize = true;
            this.lblCancelCauseHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCancelCauseHR.Location = new System.Drawing.Point(334, 16);
            this.lblCancelCauseHR.Name = "lblCancelCauseHR";
            this.lblCancelCauseHR.Size = new System.Drawing.Size(85, 13);
            this.lblCancelCauseHR.TabIndex = 199;
            this.lblCancelCauseHR.Text = "Cancel Cause";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(17, 33);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(101, 13);
            this.smartLabel10.TabIndex = 195;
            this.smartLabel10.Text = "Approved By HR";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(352, 33);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(56, 13);
            this.smartLabel11.TabIndex = 200;
            this.smartLabel11.Text = "Remarks";
            // 
            // txtRemarksHR
            // 
            this.txtRemarksHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarksHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarksHR.Location = new System.Drawing.Point(355, 54);
            this.txtRemarksHR.MaxLength = 250;
            this.txtRemarksHR.Multiline = true;
            this.txtRemarksHR.Name = "txtRemarksHR";
            this.txtRemarksHR.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarksHR.Size = new System.Drawing.Size(305, 24);
            this.txtRemarksHR.TabIndex = 198;
            // 
            // txtApprovedByHR
            // 
            this.txtApprovedByHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprovedByHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedByHR.Location = new System.Drawing.Point(232, 610);
            this.txtApprovedByHR.MaxLength = 10;
            this.txtApprovedByHR.Name = "txtApprovedByHR";
            this.txtApprovedByHR.Size = new System.Drawing.Size(33, 24);
            this.txtApprovedByHR.TabIndex = 194;
            this.txtApprovedByHR.Visible = false;
            // 
            // cboLeaveType
            // 
            this.cboLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLeaveType.ForeColor = System.Drawing.Color.Blue;
            this.cboLeaveType.FormattingEnabled = true;
            this.cboLeaveType.Location = new System.Drawing.Point(16, 114);
            this.cboLeaveType.Name = "cboLeaveType";
            this.cboLeaveType.Size = new System.Drawing.Size(324, 26);
            this.cboLeaveType.TabIndex = 180;
            // 
            // txtserial
            // 
            this.txtserial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtserial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserial.Location = new System.Drawing.Point(72, 610);
            this.txtserial.MaxLength = 10;
            this.txtserial.Name = "txtserial";
            this.txtserial.Size = new System.Drawing.Size(58, 24);
            this.txtserial.TabIndex = 182;
            this.txtserial.Visible = false;
            // 
            // txtResponsibilityHolderName
            // 
            this.txtResponsibilityHolderName.BackColor = System.Drawing.Color.Linen;
            this.txtResponsibilityHolderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResponsibilityHolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsibilityHolderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtResponsibilityHolderName.Location = new System.Drawing.Point(16, 339);
            this.txtResponsibilityHolderName.MaxLength = 10;
            this.txtResponsibilityHolderName.Name = "txtResponsibilityHolderName";
            this.txtResponsibilityHolderName.ReadOnly = true;
            this.txtResponsibilityHolderName.Size = new System.Drawing.Size(324, 24);
            this.txtResponsibilityHolderName.TabIndex = 202;
            this.txtResponsibilityHolderName.TabStop = false;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(108, 52);
            this.txtEmpName.MaxLength = 10;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(232, 24);
            this.txtEmpName.TabIndex = 202;
            // 
            // txtTO
            // 
            this.txtTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTO.Location = new System.Drawing.Point(272, 610);
            this.txtTO.MaxLength = 10;
            this.txtTO.Name = "txtTO";
            this.txtTO.Size = new System.Drawing.Size(49, 24);
            this.txtTO.TabIndex = 202;
            this.txtTO.Visible = false;
            // 
            // txtFrom
            // 
            this.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(327, 610);
            this.txtFrom.MaxLength = 10;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(49, 24);
            this.txtFrom.TabIndex = 203;
            this.txtFrom.Visible = false;
            // 
            // pnlRptPrsn
            // 
            this.pnlRptPrsn.BackColor = System.Drawing.Color.Transparent;
            this.pnlRptPrsn.Controls.Add(this.txtApprvdByRptName);
            this.pnlRptPrsn.Controls.Add(this.groupBox5);
            this.pnlRptPrsn.Controls.Add(this.smartLabel13);
            this.pnlRptPrsn.Controls.Add(this.smartLabel14);
            this.pnlRptPrsn.Controls.Add(this.txtRemarksRptPrsn);
            this.pnlRptPrsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRptPrsn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlRptPrsn.Location = new System.Drawing.Point(357, 7);
            this.pnlRptPrsn.Name = "pnlRptPrsn";
            this.pnlRptPrsn.Size = new System.Drawing.Size(680, 168);
            this.pnlRptPrsn.TabIndex = 206;
            this.pnlRptPrsn.TabStop = false;
            this.pnlRptPrsn.Text = "Reporting Person";
            // 
            // txtApprvdByRptName
            // 
            this.txtApprvdByRptName.BackColor = System.Drawing.Color.Linen;
            this.txtApprvdByRptName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprvdByRptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprvdByRptName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtApprvdByRptName.Location = new System.Drawing.Point(25, 44);
            this.txtApprvdByRptName.MaxLength = 10;
            this.txtApprvdByRptName.Name = "txtApprvdByRptName";
            this.txtApprvdByRptName.ReadOnly = true;
            this.txtApprvdByRptName.Size = new System.Drawing.Size(310, 24);
            this.txtApprvdByRptName.TabIndex = 205;
            this.txtApprvdByRptName.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRefreshCancelCauseRptPrsn);
            this.groupBox5.Controls.Add(this.btnAddCancelCauseRpt);
            this.groupBox5.Controls.Add(this.chkAppRptNo);
            this.groupBox5.Controls.Add(this.chkAppRptYes);
            this.groupBox5.Controls.Add(this.cboCancelCauseRpt);
            this.groupBox5.Controls.Add(this.lblCancelCauseRpt);
            this.groupBox5.Location = new System.Drawing.Point(20, 78);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(654, 78);
            this.groupBox5.TabIndex = 204;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Approval of Reporting Person";
            // 
            // btnRefreshCancelCauseRptPrsn
            // 
            this.btnRefreshCancelCauseRptPrsn.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshCancelCauseRptPrsn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCancelCauseRptPrsn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCancelCauseRptPrsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCancelCauseRptPrsn.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCancelCauseRptPrsn.Location = new System.Drawing.Point(616, 33);
            this.btnRefreshCancelCauseRptPrsn.Name = "btnRefreshCancelCauseRptPrsn";
            this.btnRefreshCancelCauseRptPrsn.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshCancelCauseRptPrsn.TabIndex = 202;
            this.btnRefreshCancelCauseRptPrsn.TabStop = false;
            this.btnRefreshCancelCauseRptPrsn.Text = "..";
            this.btnRefreshCancelCauseRptPrsn.UseVisualStyleBackColor = false;
            this.btnRefreshCancelCauseRptPrsn.Click += new System.EventHandler(this.btnRefreshCancelCauseRptPrsn_Click);
            // 
            // btnAddCancelCauseRpt
            // 
            this.btnAddCancelCauseRpt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCancelCauseRpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCancelCauseRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancelCauseRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancelCauseRpt.ForeColor = System.Drawing.Color.White;
            this.btnAddCancelCauseRpt.Location = new System.Drawing.Point(580, 33);
            this.btnAddCancelCauseRpt.Name = "btnAddCancelCauseRpt";
            this.btnAddCancelCauseRpt.Size = new System.Drawing.Size(32, 26);
            this.btnAddCancelCauseRpt.TabIndex = 201;
            this.btnAddCancelCauseRpt.TabStop = false;
            this.btnAddCancelCauseRpt.Text = "+";
            this.btnAddCancelCauseRpt.UseVisualStyleBackColor = false;
            this.btnAddCancelCauseRpt.Click += new System.EventHandler(this.btnAddCancelCauseRpt_Click);
            // 
            // chkAppRptNo
            // 
            this.chkAppRptNo.AutoSize = true;
            this.chkAppRptNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAppRptNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAppRptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAppRptNo.ForeColor = System.Drawing.Color.Black;
            this.chkAppRptNo.Location = new System.Drawing.Point(201, 33);
            this.chkAppRptNo.Name = "chkAppRptNo";
            this.chkAppRptNo.Size = new System.Drawing.Size(114, 22);
            this.chkAppRptNo.TabIndex = 200;
            this.chkAppRptNo.Text = "Not Approved";
            this.chkAppRptNo.UseVisualStyleBackColor = true;
            this.chkAppRptNo.Click += new System.EventHandler(this.chkAppRptNo_Click);
            // 
            // chkAppRptYes
            // 
            this.chkAppRptYes.AutoSize = true;
            this.chkAppRptYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAppRptYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAppRptYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAppRptYes.ForeColor = System.Drawing.Color.Black;
            this.chkAppRptYes.Location = new System.Drawing.Point(10, 33);
            this.chkAppRptYes.Name = "chkAppRptYes";
            this.chkAppRptYes.Size = new System.Drawing.Size(86, 22);
            this.chkAppRptYes.TabIndex = 196;
            this.chkAppRptYes.Text = "Approved";
            this.chkAppRptYes.UseVisualStyleBackColor = true;
            this.chkAppRptYes.Click += new System.EventHandler(this.chkAppRptYes_Click);
            // 
            // cboCancelCauseRpt
            // 
            this.cboCancelCauseRpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCancelCauseRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCancelCauseRpt.ForeColor = System.Drawing.Color.Blue;
            this.cboCancelCauseRpt.FormattingEnabled = true;
            this.cboCancelCauseRpt.Location = new System.Drawing.Point(338, 33);
            this.cboCancelCauseRpt.Name = "cboCancelCauseRpt";
            this.cboCancelCauseRpt.Size = new System.Drawing.Size(236, 26);
            this.cboCancelCauseRpt.TabIndex = 197;
            // 
            // lblCancelCauseRpt
            // 
            this.lblCancelCauseRpt.AutoSize = true;
            this.lblCancelCauseRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCancelCauseRpt.Location = new System.Drawing.Point(338, 13);
            this.lblCancelCauseRpt.Name = "lblCancelCauseRpt";
            this.lblCancelCauseRpt.Size = new System.Drawing.Size(85, 13);
            this.lblCancelCauseRpt.TabIndex = 199;
            this.lblCancelCauseRpt.Text = "Cancel Cause";
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(22, 24);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(181, 13);
            this.smartLabel13.TabIndex = 195;
            this.smartLabel13.Text = "Approved By Reporting Person";
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(355, 24);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(56, 13);
            this.smartLabel14.TabIndex = 200;
            this.smartLabel14.Text = "Remarks";
            // 
            // txtRemarksRptPrsn
            // 
            this.txtRemarksRptPrsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarksRptPrsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarksRptPrsn.Location = new System.Drawing.Point(358, 44);
            this.txtRemarksRptPrsn.MaxLength = 250;
            this.txtRemarksRptPrsn.Multiline = true;
            this.txtRemarksRptPrsn.Name = "txtRemarksRptPrsn";
            this.txtRemarksRptPrsn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarksRptPrsn.Size = new System.Drawing.Size(309, 25);
            this.txtRemarksRptPrsn.TabIndex = 198;
            // 
            // txtApprovedByRpt
            // 
            this.txtApprovedByRpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprovedByRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedByRpt.Location = new System.Drawing.Point(378, 610);
            this.txtApprovedByRpt.MaxLength = 10;
            this.txtApprovedByRpt.Name = "txtApprovedByRpt";
            this.txtApprovedByRpt.Size = new System.Drawing.Size(49, 24);
            this.txtApprovedByRpt.TabIndex = 204;
            this.txtApprovedByRpt.Visible = false;
            // 
            // txtLeaveWithPay
            // 
            this.txtLeaveWithPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeaveWithPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveWithPay.Location = new System.Drawing.Point(16, 281);
            this.txtLeaveWithPay.Name = "txtLeaveWithPay";
            this.txtLeaveWithPay.Size = new System.Drawing.Size(151, 24);
            this.txtLeaveWithPay.TabIndex = 207;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(16, 260);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(97, 13);
            this.smartLabel12.TabIndex = 208;
            this.smartLabel12.Text = "Leave With Pay";
            // 
            // txtLeaveWithoutpay
            // 
            this.txtLeaveWithoutpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeaveWithoutpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveWithoutpay.Location = new System.Drawing.Point(182, 281);
            this.txtLeaveWithoutpay.Name = "txtLeaveWithoutpay";
            this.txtLeaveWithoutpay.Size = new System.Drawing.Size(158, 24);
            this.txtLeaveWithoutpay.TabIndex = 209;
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.Location = new System.Drawing.Point(179, 260);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(115, 13);
            this.smartLabel15.TabIndex = 210;
            this.smartLabel15.Text = "Leave Without Pay";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(183, 203);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(107, 13);
            this.smartLabel16.TabIndex = 212;
            this.smartLabel16.Text = "Total Leave Days";
            // 
            // txtTotalDays
            // 
            this.txtTotalDays.BackColor = System.Drawing.Color.Linen;
            this.txtTotalDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTotalDays.Location = new System.Drawing.Point(182, 225);
            this.txtTotalDays.MaxLength = 10;
            this.txtTotalDays.Name = "txtTotalDays";
            this.txtTotalDays.ReadOnly = true;
            this.txtTotalDays.Size = new System.Drawing.Size(158, 24);
            this.txtTotalDays.TabIndex = 206;
            this.txtTotalDays.TabStop = false;
            // 
            // frmLeaveApproved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1050, 676);
            this.Controls.Add(this.txtApprovedByRpt);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTO);
            this.Controls.Add(this.txtApprovedByHead);
            this.Controls.Add(this.txtApprovedByHR);
            this.Controls.Add(this.txtserial);
            this.Controls.Add(this.txtResponsibility);
            this.Controls.Add(this.txtEmp);
            this.isEnterTabAllow = true;
            this.Name = "frmLeaveApproved";
            this.Load += new System.EventHandler(this.frmLeaveApprovedByHead_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtEmp, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.txtResponsibility, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.txtserial, 0);
            this.Controls.SetChildIndex(this.txtApprovedByHR, 0);
            this.Controls.SetChildIndex(this.txtApprovedByHead, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtTO, 0);
            this.Controls.SetChildIndex(this.txtFrom, 0);
            this.Controls.SetChildIndex(this.txtApprovedByRpt, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlHR.ResumeLayout(false);
            this.pnlHR.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlRptPrsn.ResumeLayout(false);
            this.pnlRptPrsn.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtEmp;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboLeaveCause;
        private AtiqsControlLibrary.SmartDateTextBox txtStartDate;
        private AtiqsControlLibrary.SmartTextBox txtAddress;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartDateTextBox txtEndDate;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtApprovedByHead;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartTextBox txtRemarksHead;
        private AtiqsControlLibrary.SmartComboBox cboCancelCauseHead;
        private AtiqsControlLibrary.SmartCheckBox chkAppHeadYes;
        private AtiqsControlLibrary.SmartLabel lblRemarks;
        private AtiqsControlLibrary.SmartLabel lblCancelCauseHd;
        private AtiqsControlLibrary.SmartTextBox txtResponsibility;
        private System.Windows.Forms.GroupBox pnlHead;
        private System.Windows.Forms.GroupBox pnlHR;
        private AtiqsControlLibrary.SmartTextBox txtApprovedByHR;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartTextBox txtRemarksHR;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartCheckBox chkAppHeadNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartCheckBox chkAppHRNo;
        private AtiqsControlLibrary.SmartCheckBox chkAppHRYes;
        private AtiqsControlLibrary.SmartComboBox cboCancelCauseHR;
        private AtiqsControlLibrary.SmartLabel lblCancelCauseHR;
        private AtiqsControlLibrary.SmartComboBox cboLeaveType;
        private AtiqsControlLibrary.SmartTextBox txtserial;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtResponsibilityHolderName;
        private AtiqsControlLibrary.SmartTextBox txtEmpName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtApprovedByHeadName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtApprovedByHRName;
        private AtiqsControlLibrary.SmartTextBox txtTO;
        private AtiqsControlLibrary.SmartTextBox txtFrom;
        private System.Windows.Forms.Button btnRefreshCauseHD;
        private System.Windows.Forms.Button btnAddCauseHD;
        private System.Windows.Forms.Button btnRefreshCauseHR;
        private System.Windows.Forms.Button btnAddCauseHR;
        private System.Windows.Forms.GroupBox pnlRptPrsn;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtApprvdByRptName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRefreshCancelCauseRptPrsn;
        private System.Windows.Forms.Button btnAddCancelCauseRpt;
        private AtiqsControlLibrary.SmartCheckBox chkAppRptNo;
        private AtiqsControlLibrary.SmartCheckBox chkAppRptYes;
        private AtiqsControlLibrary.SmartComboBox cboCancelCauseRpt;
        private AtiqsControlLibrary.SmartLabel lblCancelCauseRpt;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartTextBox txtRemarksRptPrsn;
        private AtiqsControlLibrary.SmartTextBox txtApprovedByRpt;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartNumericTextBox txtLeaveWithPay;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartNumericTextBox txtLeaveWithoutpay;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTotalDays;
    }
}
