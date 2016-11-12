namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmEmployeeLeaveRequisition
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
            this.cboResponsibility = new AtiqsControlLibrary.SmartComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmp = new AtiqsControlLibrary.SmartTextBox();
            this.cboLeaveCause = new AtiqsControlLibrary.SmartComboBox();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.txtAddress = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.cboLeaveType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvEmpLeaveRegis = new AtiqsControlLibrary.SmartListViewDetails();
            this.lblDeptId = new AtiqsControlLibrary.SmartLabel();
            this.cboMonth = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtserial = new AtiqsControlLibrary.SmartTextBox();
            this.txtReportingPersonID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtReportingPersonTitle = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtDeptHeadID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtDeptHeadTitle = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(380, 9);
            this.frmLabel.Size = new System.Drawing.Size(344, 33);
            this.frmLabel.Text = "Employee Leave Requisition";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtDeptHeadTitle);
            this.pnlMain.Controls.Add(this.txtDeptHeadID);
            this.pnlMain.Controls.Add(this.txtReportingPersonTitle);
            this.pnlMain.Controls.Add(this.txtReportingPersonID);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.cboMonth);
            this.pnlMain.Controls.Add(this.lvEmpLeaveRegis);
            this.pnlMain.Controls.Add(this.cboYear);
            this.pnlMain.Controls.Add(this.cboResponsibility);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtEmp);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboLeaveCause);
            this.pnlMain.Controls.Add(this.cboLeaveType);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.txtStartDate);
            this.pnlMain.Controls.Add(this.txtAddress);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtEndDate);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Location = new System.Drawing.Point(0, 55);
            this.pnlMain.Size = new System.Drawing.Size(1103, 672);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1103, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(874, 732);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(761, 732);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(275, 733);
            this.btnDelete.Size = new System.Drawing.Size(29, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(648, 732);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(988, 732);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(308, 733);
            this.btnPrint.Size = new System.Drawing.Size(28, 39);
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 772);
            this.groupBox1.Size = new System.Drawing.Size(1103, 23);
            // 
            // cboResponsibility
            // 
            this.cboResponsibility.BackColor = System.Drawing.SystemColors.Window;
            this.cboResponsibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboResponsibility.ForeColor = System.Drawing.Color.Blue;
            this.cboResponsibility.FormattingEnabled = true;
            this.cboResponsibility.Location = new System.Drawing.Point(21, 147);
            this.cboResponsibility.Name = "cboResponsibility";
            this.cboResponsibility.Size = new System.Drawing.Size(505, 26);
            this.cboResponsibility.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(142, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 29);
            this.btnSearch.TabIndex = 174;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmp
            // 
            this.txtEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp.Location = new System.Drawing.Point(21, 32);
            this.txtEmp.MaxLength = 10;
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(115, 24);
            this.txtEmp.TabIndex = 1;
            this.txtEmp.Leave += new System.EventHandler(this.txtEmp_Leave);
            // 
            // cboLeaveCause
            // 
            this.cboLeaveCause.BackColor = System.Drawing.SystemColors.Window;
            this.cboLeaveCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaveCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLeaveCause.ForeColor = System.Drawing.Color.Blue;
            this.cboLeaveCause.FormattingEnabled = true;
            this.cboLeaveCause.Location = new System.Drawing.Point(776, 87);
            this.cboLeaveCause.Name = "cboLeaveCause";
            this.cboLeaveCause.Size = new System.Drawing.Size(301, 26);
            this.cboLeaveCause.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(230, 32);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 13);
            this.lblInfo.TabIndex = 173;
            this.lblInfo.Text = "Info";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(532, 148);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(545, 141);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtAddress_PreviewKeyDown);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(21, 128);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(134, 13);
            this.smartLabel8.TabIndex = 172;
            this.smartLabel8.Text = "Responsibility Holder :";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(537, 128);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(143, 13);
            this.smartLabel7.TabIndex = 171;
            this.smartLabel7.Text = "Address While On leave";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(776, 69);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(89, 13);
            this.smartLabel6.TabIndex = 170;
            this.smartLabel6.Text = "Leave Cause :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(649, 69);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 13);
            this.smartLabel5.TabIndex = 169;
            this.smartLabel5.Text = "End Date :";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEndDate.Location = new System.Drawing.Point(655, 87);
            this.txtEndDate.Mask = "00/00/0000";
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(113, 24);
            this.txtEndDate.TabIndex = 5;
            this.txtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(532, 69);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(73, 13);
            this.smartLabel4.TabIndex = 167;
            this.smartLabel4.Text = "Start Date :";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtStartDate.Location = new System.Drawing.Point(532, 87);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(117, 24);
            this.txtStartDate.TabIndex = 4;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // cboLeaveType
            // 
            this.cboLeaveType.BackColor = System.Drawing.SystemColors.Window;
            this.cboLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLeaveType.ForeColor = System.Drawing.Color.Blue;
            this.cboLeaveType.FormattingEnabled = true;
            this.cboLeaveType.Location = new System.Drawing.Point(297, 87);
            this.cboLeaveType.Name = "cboLeaveType";
            this.cboLeaveType.Size = new System.Drawing.Size(229, 26);
            this.cboLeaveType.TabIndex = 3;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(297, 69);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(82, 13);
            this.smartLabel3.TabIndex = 163;
            this.smartLabel3.Text = "Leave Type :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(21, 69);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(41, 13);
            this.smartLabel2.TabIndex = 161;
            this.smartLabel2.Text = "Year :";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(21, 87);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(133, 26);
            this.cboYear.TabIndex = 0;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(21, 14);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(61, 13);
            this.smartLabel1.TabIndex = 158;
            this.smartLabel1.Text = "Employee";
            // 
            // lvEmpLeaveRegis
            // 
            this.lvEmpLeaveRegis.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvEmpLeaveRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmpLeaveRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmpLeaveRegis.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmpLeaveRegis.FullRowSelect = true;
            this.lvEmpLeaveRegis.GridLines = true;
            this.lvEmpLeaveRegis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmpLeaveRegis.Location = new System.Drawing.Point(-1, 310);
            this.lvEmpLeaveRegis.Name = "lvEmpLeaveRegis";
            this.lvEmpLeaveRegis.Size = new System.Drawing.Size(1103, 360);
            this.lvEmpLeaveRegis.TabIndex = 177;
            this.lvEmpLeaveRegis.UseCompatibleStateImageBehavior = false;
            this.lvEmpLeaveRegis.View = System.Windows.Forms.View.Details;
            this.lvEmpLeaveRegis.SelectedIndexChanged += new System.EventHandler(this.lvEmpLeaveRegis_SelectedIndexChanged);
            this.lvEmpLeaveRegis.Click += new System.EventHandler(this.lvEmpLeaveRegis_Click);
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDeptId.Location = new System.Drawing.Point(121, 731);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(34, 13);
            this.lblDeptId.TabIndex = 178;
            this.lblDeptId.Text = "Dept";
            this.lblDeptId.Visible = false;
            // 
            // cboMonth
            // 
            this.cboMonth.BackColor = System.Drawing.SystemColors.Window;
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.ForeColor = System.Drawing.Color.Blue;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(158, 87);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(133, 26);
            this.cboMonth.TabIndex = 2;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(158, 69);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(50, 13);
            this.smartLabel9.TabIndex = 180;
            this.smartLabel9.Text = "Month :";
            // 
            // txtserial
            // 
            this.txtserial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtserial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserial.Location = new System.Drawing.Point(124, 747);
            this.txtserial.MaxLength = 10;
            this.txtserial.Name = "txtserial";
            this.txtserial.Size = new System.Drawing.Size(58, 24);
            this.txtserial.TabIndex = 181;
            this.txtserial.Visible = false;
            // 
            // txtReportingPersonID
            // 
            this.txtReportingPersonID.BackColor = System.Drawing.Color.Linen;
            this.txtReportingPersonID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportingPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportingPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtReportingPersonID.Location = new System.Drawing.Point(21, 204);
            this.txtReportingPersonID.Name = "txtReportingPersonID";
            this.txtReportingPersonID.ReadOnly = true;
            this.txtReportingPersonID.Size = new System.Drawing.Size(131, 24);
            this.txtReportingPersonID.TabIndex = 181;
            this.txtReportingPersonID.TabStop = false;
            // 
            // txtReportingPersonTitle
            // 
            this.txtReportingPersonTitle.BackColor = System.Drawing.Color.Linen;
            this.txtReportingPersonTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportingPersonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportingPersonTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtReportingPersonTitle.Location = new System.Drawing.Point(158, 204);
            this.txtReportingPersonTitle.Name = "txtReportingPersonTitle";
            this.txtReportingPersonTitle.ReadOnly = true;
            this.txtReportingPersonTitle.Size = new System.Drawing.Size(368, 24);
            this.txtReportingPersonTitle.TabIndex = 182;
            this.txtReportingPersonTitle.TabStop = false;
            // 
            // txtDeptHeadID
            // 
            this.txtDeptHeadID.BackColor = System.Drawing.Color.Linen;
            this.txtDeptHeadID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptHeadID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptHeadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDeptHeadID.Location = new System.Drawing.Point(21, 265);
            this.txtDeptHeadID.Name = "txtDeptHeadID";
            this.txtDeptHeadID.ReadOnly = true;
            this.txtDeptHeadID.Size = new System.Drawing.Size(131, 24);
            this.txtDeptHeadID.TabIndex = 183;
            this.txtDeptHeadID.TabStop = false;
            // 
            // txtDeptHeadTitle
            // 
            this.txtDeptHeadTitle.BackColor = System.Drawing.Color.Linen;
            this.txtDeptHeadTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptHeadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptHeadTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDeptHeadTitle.Location = new System.Drawing.Point(158, 265);
            this.txtDeptHeadTitle.Name = "txtDeptHeadTitle";
            this.txtDeptHeadTitle.ReadOnly = true;
            this.txtDeptHeadTitle.Size = new System.Drawing.Size(368, 24);
            this.txtDeptHeadTitle.TabIndex = 184;
            this.txtDeptHeadTitle.TabStop = false;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(18, 186);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(138, 13);
            this.smartLabel10.TabIndex = 185;
            this.smartLabel10.Text = "Reporting Person (ID) :";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(158, 186);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(149, 13);
            this.smartLabel11.TabIndex = 186;
            this.smartLabel11.Text = "Reporting Person Name :";
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(20, 245);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(101, 13);
            this.smartLabel12.TabIndex = 187;
            this.smartLabel12.Text = "Dept Head (ID) :";
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(158, 245);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(112, 13);
            this.smartLabel13.TabIndex = 188;
            this.smartLabel13.Text = "Dept Head Name :";
            // 
            // frmEmployeeLeaveRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1103, 795);
            this.Controls.Add(this.txtserial);
            this.Controls.Add(this.lblDeptId);
            this.isEnterTabAllow = true;
            this.Name = "frmEmployeeLeaveRequisition";
            this.Load += new System.EventHandler(this.frmEmployeeLeaveRegister_Load);
            this.Controls.SetChildIndex(this.lblDeptId, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.txtserial, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboResponsibility;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartTextBox txtEmp;
        private AtiqsControlLibrary.SmartComboBox cboLeaveCause;
        private AtiqsControlLibrary.SmartLabel lblInfo;
        private AtiqsControlLibrary.SmartTextBox txtAddress;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartDateTextBox txtEndDate;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartDateTextBox txtStartDate;
        private AtiqsControlLibrary.SmartComboBox cboLeaveType;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvEmpLeaveRegis;
        private AtiqsControlLibrary.SmartLabel lblDeptId;
        private AtiqsControlLibrary.SmartComboBox cboMonth;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartTextBox txtserial;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtReportingPersonID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtReportingPersonTitle;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDeptHeadID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDeptHeadTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
    }
}
