namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmOPDDoctor
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lblDoctor = new AtiqsControlLibrary.SmartLabel();
            this.cboRoomGroup = new AtiqsControlLibrary.SmartComboBox();
            this.cboRoomNo = new AtiqsControlLibrary.SmartComboBox();
            this.cboDoctor = new AtiqsControlLibrary.SmartComboBox();
            this.lvlDocRoomSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.lbldtpVStart = new AtiqsControlLibrary.SmartLabel();
            this.dtpVStart = new System.Windows.Forms.DateTimePicker();
            this.lbldtpVisitEnd = new AtiqsControlLibrary.SmartLabel();
            this.dtpVisitEnd = new System.Windows.Forms.DateTimePicker();
            this.lblFirstVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblDrFirstVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblSecondVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblDrSecondVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblThirdVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblDrThirdVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblFourthVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblDrForthVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblRptVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblDrReport = new AtiqsControlLibrary.SmartLabel();
            this.lblVisitCycle = new AtiqsControlLibrary.SmartLabel();
            this.lblMaxPat = new AtiqsControlLibrary.SmartLabel();
            this.lblAvgPatTime = new AtiqsControlLibrary.SmartLabel();
            this.txtFirstVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSecondVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtDrSecondVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtThirdVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtDrThirdVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtFourthVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtDrFourthVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtDrFirstVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtRptVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtDrRptVisit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtVisitCycle = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtAvgPatTime = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtMaxPat = new AtiqsControlLibrary.SmartNumericTextBox();
            this.groupBoxVisitingFee = new System.Windows.Forms.GroupBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.groupBoxRoomAndTime = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.lblDept = new AtiqsControlLibrary.SmartLabel();
            this.lblUnit = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblDegree4 = new AtiqsControlLibrary.SmartLabel();
            this.lblDegree3 = new AtiqsControlLibrary.SmartLabel();
            this.lblDegree2 = new AtiqsControlLibrary.SmartLabel();
            this.lblDegree1 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegree4 = new AtiqsControlLibrary.SmartTextBox();
            this.txtDegree3 = new AtiqsControlLibrary.SmartTextBox();
            this.txtDegree2 = new AtiqsControlLibrary.SmartTextBox();
            this.txtDegree1 = new AtiqsControlLibrary.SmartTextBox();
            this.groupBoxIdentity = new System.Windows.Forms.GroupBox();
            this.cachedrptOPDNurseRomAlloc1 = new AH.ModuleController.UI.OPD.Reports.ReportUI.CachedrptOPDNurseRomAlloc();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBoxVisitingFee.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxRoomAndTime.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxIdentity.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1252, 5);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(560, 9);
            this.frmLabel.Size = new System.Drawing.Size(230, 33);
            this.frmLabel.Text = "OPD Doctor Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.groupBoxIdentity);
            this.pnlMain.Controls.Add(this.groupBox6);
            this.pnlMain.Controls.Add(this.groupBoxRoomAndTime);
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Controls.Add(this.groupBox);
            this.pnlMain.Controls.Add(this.lvlDocRoomSetup);
            this.pnlMain.Controls.Add(this.groupBoxVisitingFee);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(1330, 672);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1330, 51);
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1087, 731);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(973, 731);
            this.btnSave.TabIndex = 26;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 728);
            this.btnDelete.Size = new System.Drawing.Size(16, 12);
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(859, 731);
            this.btnNew.TabIndex = 27;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1201, 731);
            this.btnClose.TabIndex = 28;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(28, 728);
            this.btnPrint.Size = new System.Drawing.Size(16, 12);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 772);
            this.groupBox1.Size = new System.Drawing.Size(1330, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(5, 37);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(41, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Group";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(287, 37);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(50, 13);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Number";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.Location = new System.Drawing.Point(912, 16);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(53, 13);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "Doctor :";
            // 
            // cboRoomGroup
            // 
            this.cboRoomGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomGroup.FormattingEnabled = true;
            this.cboRoomGroup.Location = new System.Drawing.Point(47, 31);
            this.cboRoomGroup.Name = "cboRoomGroup";
            this.cboRoomGroup.Size = new System.Drawing.Size(190, 26);
            this.cboRoomGroup.TabIndex = 4;
            this.cboRoomGroup.SelectedIndexChanged += new System.EventHandler(this.cboRoomGroup_SelectedIndexChanged);
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomNo.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomNo.FormattingEnabled = true;
            this.cboRoomNo.Location = new System.Drawing.Point(340, 31);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.Size = new System.Drawing.Size(79, 26);
            this.cboRoomNo.TabIndex = 5;
            // 
            // cboDoctor
            // 
            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctor.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctor.Location = new System.Drawing.Point(971, 10);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(329, 26);
            this.cboDoctor.TabIndex = 3;
            // 
            // lvlDocRoomSetup
            // 
            this.lvlDocRoomSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvlDocRoomSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlDocRoomSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvlDocRoomSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDocRoomSetup.FullRowSelect = true;
            this.lvlDocRoomSetup.GridLines = true;
            this.lvlDocRoomSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvlDocRoomSetup.Location = new System.Drawing.Point(0, 250);
            this.lvlDocRoomSetup.Name = "lvlDocRoomSetup";
            this.lvlDocRoomSetup.Size = new System.Drawing.Size(1328, 420);
            this.lvlDocRoomSetup.TabIndex = 56;
            this.lvlDocRoomSetup.UseCompatibleStateImageBehavior = false;
            this.lvlDocRoomSetup.View = System.Windows.Forms.View.Details;
            this.lvlDocRoomSetup.SelectedIndexChanged += new System.EventHandler(this.lvlDocRoomSetup_SelectedIndexChanged);
            // 
            // lbldtpVStart
            // 
            this.lbldtpVStart.AutoSize = true;
            this.lbldtpVStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbldtpVStart.Location = new System.Drawing.Point(5, 21);
            this.lbldtpVStart.Name = "lbldtpVStart";
            this.lbldtpVStart.Size = new System.Drawing.Size(93, 13);
            this.lbldtpVStart.TabIndex = 12;
            this.lbldtpVStart.Text = "Visit Start Time";
            // 
            // dtpVStart
            // 
            this.dtpVStart.CustomFormat = "hh : mm tt";
            this.dtpVStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVStart.Location = new System.Drawing.Point(110, 16);
            this.dtpVStart.Name = "dtpVStart";
            this.dtpVStart.ShowUpDown = true;
            this.dtpVStart.Size = new System.Drawing.Size(134, 20);
            this.dtpVStart.TabIndex = 7;
            this.dtpVStart.Value = new System.DateTime(2014, 9, 30, 0, 0, 0, 0);
            // 
            // lbldtpVisitEnd
            // 
            this.lbldtpVisitEnd.AutoSize = true;
            this.lbldtpVisitEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbldtpVisitEnd.Location = new System.Drawing.Point(5, 49);
            this.lbldtpVisitEnd.Name = "lbldtpVisitEnd";
            this.lbldtpVisitEnd.Size = new System.Drawing.Size(88, 13);
            this.lbldtpVisitEnd.TabIndex = 14;
            this.lbldtpVisitEnd.Text = "Visit End Time";
            // 
            // dtpVisitEnd
            // 
            this.dtpVisitEnd.CustomFormat = "hh : mm tt";
            this.dtpVisitEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVisitEnd.Location = new System.Drawing.Point(110, 45);
            this.dtpVisitEnd.Name = "dtpVisitEnd";
            this.dtpVisitEnd.ShowUpDown = true;
            this.dtpVisitEnd.Size = new System.Drawing.Size(134, 20);
            this.dtpVisitEnd.TabIndex = 8;
            this.dtpVisitEnd.Value = new System.DateTime(2014, 9, 30, 0, 0, 0, 0);
            // 
            // lblFirstVisit
            // 
            this.lblFirstVisit.AutoSize = true;
            this.lblFirstVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFirstVisit.Location = new System.Drawing.Point(9, 26);
            this.lblFirstVisit.Name = "lblFirstVisit";
            this.lblFirstVisit.Size = new System.Drawing.Size(101, 13);
            this.lblFirstVisit.TabIndex = 16;
            this.lblFirstVisit.Text = "First Visiting Fee";
            // 
            // lblDrFirstVisit
            // 
            this.lblDrFirstVisit.AutoSize = true;
            this.lblDrFirstVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDrFirstVisit.Location = new System.Drawing.Point(14, 26);
            this.lblDrFirstVisit.Name = "lblDrFirstVisit";
            this.lblDrFirstVisit.Size = new System.Drawing.Size(121, 13);
            this.lblDrFirstVisit.TabIndex = 17;
            this.lblDrFirstVisit.Text = "Doctors Visiting Fee";
            // 
            // lblSecondVisit
            // 
            this.lblSecondVisit.AutoSize = true;
            this.lblSecondVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSecondVisit.Location = new System.Drawing.Point(171, 728);
            this.lblSecondVisit.Name = "lblSecondVisit";
            this.lblSecondVisit.Size = new System.Drawing.Size(50, 13);
            this.lblSecondVisit.TabIndex = 18;
            this.lblSecondVisit.Text = "Second";
            this.lblSecondVisit.Visible = false;
            // 
            // lblDrSecondVisit
            // 
            this.lblDrSecondVisit.AutoSize = true;
            this.lblDrSecondVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDrSecondVisit.Location = new System.Drawing.Point(218, 728);
            this.lblDrSecondVisit.Name = "lblDrSecondVisit";
            this.lblDrSecondVisit.Size = new System.Drawing.Size(67, 13);
            this.lblDrSecondVisit.TabIndex = 19;
            this.lblDrSecondVisit.Text = "Dr.Second";
            this.lblDrSecondVisit.Visible = false;
            // 
            // lblThirdVisit
            // 
            this.lblThirdVisit.AutoSize = true;
            this.lblThirdVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblThirdVisit.Location = new System.Drawing.Point(171, 740);
            this.lblThirdVisit.Name = "lblThirdVisit";
            this.lblThirdVisit.Size = new System.Drawing.Size(36, 13);
            this.lblThirdVisit.TabIndex = 20;
            this.lblThirdVisit.Text = "Third";
            this.lblThirdVisit.Visible = false;
            // 
            // lblDrThirdVisit
            // 
            this.lblDrThirdVisit.AutoSize = true;
            this.lblDrThirdVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDrThirdVisit.Location = new System.Drawing.Point(218, 740);
            this.lblDrThirdVisit.Name = "lblDrThirdVisit";
            this.lblDrThirdVisit.Size = new System.Drawing.Size(53, 13);
            this.lblDrThirdVisit.TabIndex = 21;
            this.lblDrThirdVisit.Text = "Dr.Third";
            this.lblDrThirdVisit.Visible = false;
            // 
            // lblFourthVisit
            // 
            this.lblFourthVisit.AutoSize = true;
            this.lblFourthVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFourthVisit.Location = new System.Drawing.Point(171, 753);
            this.lblFourthVisit.Name = "lblFourthVisit";
            this.lblFourthVisit.Size = new System.Drawing.Size(36, 13);
            this.lblFourthVisit.TabIndex = 22;
            this.lblFourthVisit.Text = "Forth";
            this.lblFourthVisit.Visible = false;
            // 
            // lblDrForthVisit
            // 
            this.lblDrForthVisit.AutoSize = true;
            this.lblDrForthVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDrForthVisit.Location = new System.Drawing.Point(218, 753);
            this.lblDrForthVisit.Name = "lblDrForthVisit";
            this.lblDrForthVisit.Size = new System.Drawing.Size(57, 13);
            this.lblDrForthVisit.TabIndex = 23;
            this.lblDrForthVisit.Text = "Dr. Forth";
            this.lblDrForthVisit.Visible = false;
            // 
            // lblRptVisit
            // 
            this.lblRptVisit.AutoSize = true;
            this.lblRptVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRptVisit.Location = new System.Drawing.Point(9, 55);
            this.lblRptVisit.Name = "lblRptVisit";
            this.lblRptVisit.Size = new System.Drawing.Size(122, 13);
            this.lblRptVisit.TabIndex = 24;
            this.lblRptVisit.Text = "Report Showing Fee";
            // 
            // lblDrReport
            // 
            this.lblDrReport.AutoSize = true;
            this.lblDrReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDrReport.Location = new System.Drawing.Point(14, 55);
            this.lblDrReport.Name = "lblDrReport";
            this.lblDrReport.Size = new System.Drawing.Size(122, 13);
            this.lblDrReport.TabIndex = 25;
            this.lblDrReport.Text = "Report Showing Fee";
            // 
            // lblVisitCycle
            // 
            this.lblVisitCycle.AutoSize = true;
            this.lblVisitCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVisitCycle.Location = new System.Drawing.Point(13, 23);
            this.lblVisitCycle.Name = "lblVisitCycle";
            this.lblVisitCycle.Size = new System.Drawing.Size(66, 13);
            this.lblVisitCycle.TabIndex = 26;
            this.lblVisitCycle.Text = "Visit Cycle";
            // 
            // lblMaxPat
            // 
            this.lblMaxPat.AutoSize = true;
            this.lblMaxPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaxPat.Location = new System.Drawing.Point(185, 20);
            this.lblMaxPat.Name = "lblMaxPat";
            this.lblMaxPat.Size = new System.Drawing.Size(53, 13);
            this.lblMaxPat.TabIndex = 27;
            this.lblMaxPat.Text = "Max Pat";
            // 
            // lblAvgPatTime
            // 
            this.lblAvgPatTime.AutoSize = true;
            this.lblAvgPatTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAvgPatTime.Location = new System.Drawing.Point(93, 20);
            this.lblAvgPatTime.Name = "lblAvgPatTime";
            this.lblAvgPatTime.Size = new System.Drawing.Size(79, 13);
            this.lblAvgPatTime.TabIndex = 28;
            this.lblAvgPatTime.Text = "Avg Pat time";
            // 
            // txtFirstVisit
            // 
            this.txtFirstVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstVisit.Location = new System.Drawing.Point(162, 18);
            this.txtFirstVisit.Name = "txtFirstVisit";
            this.txtFirstVisit.Size = new System.Drawing.Size(117, 24);
            this.txtFirstVisit.TabIndex = 9;
            this.txtFirstVisit.TextChanged += new System.EventHandler(this.txtFirstVisit_TextChanged);
            // 
            // txtSecondVisit
            // 
            this.txtSecondVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondVisit.Location = new System.Drawing.Point(59, 731);
            this.txtSecondVisit.Name = "txtSecondVisit";
            this.txtSecondVisit.Size = new System.Drawing.Size(17, 24);
            this.txtSecondVisit.TabIndex = 10;
            this.txtSecondVisit.Visible = false;
            // 
            // txtDrSecondVisit
            // 
            this.txtDrSecondVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrSecondVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrSecondVisit.Location = new System.Drawing.Point(110, 731);
            this.txtDrSecondVisit.Name = "txtDrSecondVisit";
            this.txtDrSecondVisit.Size = new System.Drawing.Size(19, 24);
            this.txtDrSecondVisit.TabIndex = 15;
            this.txtDrSecondVisit.Visible = false;
            // 
            // txtThirdVisit
            // 
            this.txtThirdVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThirdVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdVisit.Location = new System.Drawing.Point(76, 731);
            this.txtThirdVisit.Name = "txtThirdVisit";
            this.txtThirdVisit.Size = new System.Drawing.Size(17, 24);
            this.txtThirdVisit.TabIndex = 11;
            this.txtThirdVisit.Visible = false;
            // 
            // txtDrThirdVisit
            // 
            this.txtDrThirdVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrThirdVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrThirdVisit.Location = new System.Drawing.Point(129, 731);
            this.txtDrThirdVisit.Name = "txtDrThirdVisit";
            this.txtDrThirdVisit.Size = new System.Drawing.Size(19, 24);
            this.txtDrThirdVisit.TabIndex = 16;
            this.txtDrThirdVisit.Visible = false;
            // 
            // txtFourthVisit
            // 
            this.txtFourthVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFourthVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFourthVisit.Location = new System.Drawing.Point(93, 731);
            this.txtFourthVisit.Name = "txtFourthVisit";
            this.txtFourthVisit.Size = new System.Drawing.Size(17, 24);
            this.txtFourthVisit.TabIndex = 12;
            this.txtFourthVisit.Visible = false;
            // 
            // txtDrFourthVisit
            // 
            this.txtDrFourthVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrFourthVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrFourthVisit.Location = new System.Drawing.Point(148, 731);
            this.txtDrFourthVisit.Name = "txtDrFourthVisit";
            this.txtDrFourthVisit.Size = new System.Drawing.Size(19, 24);
            this.txtDrFourthVisit.TabIndex = 17;
            this.txtDrFourthVisit.Visible = false;
            // 
            // txtDrFirstVisit
            // 
            this.txtDrFirstVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrFirstVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrFirstVisit.Location = new System.Drawing.Point(159, 18);
            this.txtDrFirstVisit.Name = "txtDrFirstVisit";
            this.txtDrFirstVisit.Size = new System.Drawing.Size(113, 24);
            this.txtDrFirstVisit.TabIndex = 14;
            this.txtDrFirstVisit.TextChanged += new System.EventHandler(this.txtDrFirstVisit_TextChanged);
            // 
            // txtRptVisit
            // 
            this.txtRptVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRptVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRptVisit.Location = new System.Drawing.Point(162, 49);
            this.txtRptVisit.Name = "txtRptVisit";
            this.txtRptVisit.Size = new System.Drawing.Size(117, 24);
            this.txtRptVisit.TabIndex = 13;
            // 
            // txtDrRptVisit
            // 
            this.txtDrRptVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrRptVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrRptVisit.Location = new System.Drawing.Point(159, 49);
            this.txtDrRptVisit.Name = "txtDrRptVisit";
            this.txtDrRptVisit.Size = new System.Drawing.Size(113, 24);
            this.txtDrRptVisit.TabIndex = 18;
            // 
            // txtVisitCycle
            // 
            this.txtVisitCycle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitCycle.Location = new System.Drawing.Point(9, 39);
            this.txtVisitCycle.Name = "txtVisitCycle";
            this.txtVisitCycle.Size = new System.Drawing.Size(78, 24);
            this.txtVisitCycle.TabIndex = 19;
            // 
            // txtAvgPatTime
            // 
            this.txtAvgPatTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAvgPatTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgPatTime.Location = new System.Drawing.Point(94, 39);
            this.txtAvgPatTime.Name = "txtAvgPatTime";
            this.txtAvgPatTime.Size = new System.Drawing.Size(75, 24);
            this.txtAvgPatTime.TabIndex = 20;
            // 
            // txtMaxPat
            // 
            this.txtMaxPat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPat.Location = new System.Drawing.Point(176, 39);
            this.txtMaxPat.Name = "txtMaxPat";
            this.txtMaxPat.Size = new System.Drawing.Size(75, 24);
            this.txtMaxPat.TabIndex = 21;
            // 
            // groupBoxVisitingFee
            // 
            this.groupBoxVisitingFee.Controls.Add(this.smartLabel5);
            this.groupBoxVisitingFee.Controls.Add(this.smartLabel4);
            this.groupBoxVisitingFee.Controls.Add(this.lblFirstVisit);
            this.groupBoxVisitingFee.Controls.Add(this.txtFirstVisit);
            this.groupBoxVisitingFee.Controls.Add(this.txtRptVisit);
            this.groupBoxVisitingFee.Controls.Add(this.lblRptVisit);
            this.groupBoxVisitingFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVisitingFee.Location = new System.Drawing.Point(11, 152);
            this.groupBoxVisitingFee.Name = "groupBoxVisitingFee";
            this.groupBoxVisitingFee.Size = new System.Drawing.Size(340, 91);
            this.groupBoxVisitingFee.TabIndex = 42;
            this.groupBoxVisitingFee.TabStop = false;
            this.groupBoxVisitingFee.Text = "Visiting Fee";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(285, 26);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(36, 13);
            this.smartLabel5.TabIndex = 26;
            this.smartLabel5.Text = "Taka";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(285, 55);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(36, 13);
            this.smartLabel4.TabIndex = 25;
            this.smartLabel4.Text = "Taka";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.smartLabel6);
            this.groupBox.Controls.Add(this.smartLabel7);
            this.groupBox.Controls.Add(this.lblDrFirstVisit);
            this.groupBox.Controls.Add(this.txtDrFirstVisit);
            this.groupBox.Controls.Add(this.txtDrRptVisit);
            this.groupBox.Controls.Add(this.lblDrReport);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(355, 152);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(340, 91);
            this.groupBox.TabIndex = 43;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Doctors Amount";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(281, 55);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(36, 13);
            this.smartLabel6.TabIndex = 27;
            this.smartLabel6.Text = "Taka";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(281, 26);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(36, 13);
            this.smartLabel7.TabIndex = 28;
            this.smartLabel7.Text = "Taka";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.smartLabel3);
            this.groupBox4.Controls.Add(this.lblVisitCycle);
            this.groupBox4.Controls.Add(this.txtVisitCycle);
            this.groupBox4.Controls.Add(this.lblAvgPatTime);
            this.groupBox4.Controls.Add(this.txtMaxPat);
            this.groupBox4.Controls.Add(this.txtAvgPatTime);
            this.groupBox4.Controls.Add(this.lblMaxPat);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(438, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 88);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Additional";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(20, 66);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(51, 13);
            this.smartLabel3.TabIndex = 29;
            this.smartLabel3.Text = "( Days )";
            // 
            // groupBoxRoomAndTime
            // 
            this.groupBoxRoomAndTime.Controls.Add(this.btnShow);
            this.groupBoxRoomAndTime.Controls.Add(this.smartLabel1);
            this.groupBoxRoomAndTime.Controls.Add(this.cboRoomNo);
            this.groupBoxRoomAndTime.Controls.Add(this.smartLabel2);
            this.groupBoxRoomAndTime.Controls.Add(this.cboRoomGroup);
            this.groupBoxRoomAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRoomAndTime.Location = new System.Drawing.Point(11, 58);
            this.groupBoxRoomAndTime.Name = "groupBoxRoomAndTime";
            this.groupBoxRoomAndTime.Size = new System.Drawing.Size(423, 88);
            this.groupBoxRoomAndTime.TabIndex = 45;
            this.groupBoxRoomAndTime.TabStop = false;
            this.groupBoxRoomAndTime.Text = "Room Group and Number";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(240, 27);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(48, 34);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Find";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.lbldtpVStart);
            this.groupBoxTime.Controls.Add(this.dtpVisitEnd);
            this.groupBoxTime.Controls.Add(this.dtpVStart);
            this.groupBoxTime.Controls.Add(this.lbldtpVisitEnd);
            this.groupBoxTime.Location = new System.Drawing.Point(6, 741);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(52, 25);
            this.groupBoxTime.TabIndex = 16;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Time";
            this.groupBoxTime.Visible = false;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(6, 16);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(80, 13);
            this.lblDept.TabIndex = 47;
            this.lblDept.Text = "Department :";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(513, 15);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(38, 13);
            this.lblUnit.TabIndex = 49;
            this.lblUnit.Text = "Unit :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(98, 10);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(356, 26);
            this.cboDepartment.TabIndex = 1;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboUnit
            // 
            this.cboUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(557, 10);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(314, 26);
            this.cboUnit.TabIndex = 2;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblDegree4);
            this.groupBox6.Controls.Add(this.lblDegree3);
            this.groupBox6.Controls.Add(this.lblDegree2);
            this.groupBox6.Controls.Add(this.lblDegree1);
            this.groupBox6.Controls.Add(this.txtDegree4);
            this.groupBox6.Controls.Add(this.txtDegree3);
            this.groupBox6.Controls.Add(this.txtDegree2);
            this.groupBox6.Controls.Add(this.txtDegree1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(702, 58);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(615, 185);
            this.groupBox6.TabIndex = 52;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Doctor\'s Degrees";
            // 
            // lblDegree4
            // 
            this.lblDegree4.AutoSize = true;
            this.lblDegree4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDegree4.Location = new System.Drawing.Point(15, 151);
            this.lblDegree4.Name = "lblDegree4";
            this.lblDegree4.Size = new System.Drawing.Size(59, 13);
            this.lblDegree4.TabIndex = 7;
            this.lblDegree4.Text = "Degree 4";
            // 
            // lblDegree3
            // 
            this.lblDegree3.AutoSize = true;
            this.lblDegree3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDegree3.Location = new System.Drawing.Point(15, 115);
            this.lblDegree3.Name = "lblDegree3";
            this.lblDegree3.Size = new System.Drawing.Size(59, 13);
            this.lblDegree3.TabIndex = 6;
            this.lblDegree3.Text = "Degree 3";
            // 
            // lblDegree2
            // 
            this.lblDegree2.AutoSize = true;
            this.lblDegree2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDegree2.Location = new System.Drawing.Point(15, 77);
            this.lblDegree2.Name = "lblDegree2";
            this.lblDegree2.Size = new System.Drawing.Size(59, 13);
            this.lblDegree2.TabIndex = 5;
            this.lblDegree2.Text = "Degree 2";
            // 
            // lblDegree1
            // 
            this.lblDegree1.AutoSize = true;
            this.lblDegree1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDegree1.Location = new System.Drawing.Point(15, 41);
            this.lblDegree1.Name = "lblDegree1";
            this.lblDegree1.Size = new System.Drawing.Size(59, 13);
            this.lblDegree1.TabIndex = 4;
            this.lblDegree1.Text = "Degree 1";
            // 
            // txtDegree4
            // 
            this.txtDegree4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree4.Location = new System.Drawing.Point(80, 150);
            this.txtDegree4.MaxLength = 55;
            this.txtDegree4.Name = "txtDegree4";
            this.txtDegree4.Size = new System.Drawing.Size(526, 24);
            this.txtDegree4.TabIndex = 25;
            // 
            // txtDegree3
            // 
            this.txtDegree3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree3.Location = new System.Drawing.Point(80, 111);
            this.txtDegree3.MaxLength = 55;
            this.txtDegree3.Name = "txtDegree3";
            this.txtDegree3.Size = new System.Drawing.Size(526, 24);
            this.txtDegree3.TabIndex = 24;
            // 
            // txtDegree2
            // 
            this.txtDegree2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree2.Location = new System.Drawing.Point(80, 71);
            this.txtDegree2.MaxLength = 55;
            this.txtDegree2.Name = "txtDegree2";
            this.txtDegree2.Size = new System.Drawing.Size(526, 24);
            this.txtDegree2.TabIndex = 23;
            // 
            // txtDegree1
            // 
            this.txtDegree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree1.Location = new System.Drawing.Point(80, 33);
            this.txtDegree1.MaxLength = 55;
            this.txtDegree1.Name = "txtDegree1";
            this.txtDegree1.Size = new System.Drawing.Size(526, 24);
            this.txtDegree1.TabIndex = 22;
            // 
            // groupBoxIdentity
            // 
            this.groupBoxIdentity.Controls.Add(this.cboDepartment);
            this.groupBoxIdentity.Controls.Add(this.lblDept);
            this.groupBoxIdentity.Controls.Add(this.lblUnit);
            this.groupBoxIdentity.Controls.Add(this.cboDoctor);
            this.groupBoxIdentity.Controls.Add(this.cboUnit);
            this.groupBoxIdentity.Controls.Add(this.lblDoctor);
            this.groupBoxIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIdentity.Location = new System.Drawing.Point(11, 9);
            this.groupBoxIdentity.Name = "groupBoxIdentity";
            this.groupBoxIdentity.Size = new System.Drawing.Size(1306, 42);
            this.groupBoxIdentity.TabIndex = 54;
            this.groupBoxIdentity.TabStop = false;
            this.groupBoxIdentity.Text = "Identity";
            // 
            // frmOPDDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1330, 797);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.lblDrSecondVisit);
            this.Controls.Add(this.lblSecondVisit);
            this.Controls.Add(this.lblDrThirdVisit);
            this.Controls.Add(this.lblThirdVisit);
            this.Controls.Add(this.lblDrForthVisit);
            this.Controls.Add(this.txtDrSecondVisit);
            this.Controls.Add(this.lblFourthVisit);
            this.Controls.Add(this.txtSecondVisit);
            this.Controls.Add(this.txtDrFourthVisit);
            this.Controls.Add(this.txtDrThirdVisit);
            this.Controls.Add(this.txtThirdVisit);
            this.Controls.Add(this.txtFourthVisit);
            this.isEnterTabAllow = true;
            this.Name = "frmOPDDoctor";
            this.Load += new System.EventHandler(this.frmDoctorRoomSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.txtFourthVisit, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.txtThirdVisit, 0);
            this.Controls.SetChildIndex(this.txtDrThirdVisit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.txtDrFourthVisit, 0);
            this.Controls.SetChildIndex(this.txtSecondVisit, 0);
            this.Controls.SetChildIndex(this.lblFourthVisit, 0);
            this.Controls.SetChildIndex(this.txtDrSecondVisit, 0);
            this.Controls.SetChildIndex(this.lblDrForthVisit, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.lblThirdVisit, 0);
            this.Controls.SetChildIndex(this.lblDrThirdVisit, 0);
            this.Controls.SetChildIndex(this.lblSecondVisit, 0);
            this.Controls.SetChildIndex(this.lblDrSecondVisit, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.groupBoxTime, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBoxVisitingFee.ResumeLayout(false);
            this.groupBoxVisitingFee.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxRoomAndTime.ResumeLayout(false);
            this.groupBoxRoomAndTime.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBoxIdentity.ResumeLayout(false);
            this.groupBoxIdentity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel lblDoctor;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDoctor;
        private AtiqsControlLibrary.SmartComboBox cboRoomNo;
        private AtiqsControlLibrary.SmartComboBox cboRoomGroup;
        private AtiqsControlLibrary.SmartListViewDetails lvlDocRoomSetup;
        private AtiqsControlLibrary.SmartLabel lbldtpVStart;
        private System.Windows.Forms.DateTimePicker dtpVisitEnd;
        private AtiqsControlLibrary.SmartLabel lbldtpVisitEnd;
        private System.Windows.Forms.DateTimePicker dtpVStart;
        private AtiqsControlLibrary.SmartLabel lblDrFirstVisit;
        private AtiqsControlLibrary.SmartLabel lblFirstVisit;
        private AtiqsControlLibrary.SmartLabel lblDrReport;
        private AtiqsControlLibrary.SmartLabel lblRptVisit;
        private AtiqsControlLibrary.SmartLabel lblDrForthVisit;
        private AtiqsControlLibrary.SmartLabel lblFourthVisit;
        private AtiqsControlLibrary.SmartLabel lblDrThirdVisit;
        private AtiqsControlLibrary.SmartLabel lblThirdVisit;
        private AtiqsControlLibrary.SmartLabel lblDrSecondVisit;
        private AtiqsControlLibrary.SmartLabel lblSecondVisit;
        private AtiqsControlLibrary.SmartLabel lblAvgPatTime;
        private AtiqsControlLibrary.SmartLabel lblMaxPat;
        private AtiqsControlLibrary.SmartLabel lblVisitCycle;
        private AtiqsControlLibrary.SmartNumericTextBox txtMaxPat;
        private AtiqsControlLibrary.SmartNumericTextBox txtAvgPatTime;
        private AtiqsControlLibrary.SmartNumericTextBox txtVisitCycle;
        private AtiqsControlLibrary.SmartNumericTextBox txtDrRptVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtRptVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtDrFirstVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtDrFourthVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtFourthVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtDrThirdVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtThirdVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtDrSecondVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtSecondVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtFirstVisit;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBoxVisitingFee;
        private System.Windows.Forms.GroupBox groupBoxRoomAndTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private AtiqsControlLibrary.SmartLabel lblDept;
        private AtiqsControlLibrary.SmartLabel lblUnit;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private System.Windows.Forms.GroupBox groupBox6;
        private AtiqsControlLibrary.SmartLabel lblDegree1;
        private AtiqsControlLibrary.SmartTextBox txtDegree4;
        private AtiqsControlLibrary.SmartTextBox txtDegree3;
        private AtiqsControlLibrary.SmartTextBox txtDegree2;
        private AtiqsControlLibrary.SmartTextBox txtDegree1;
        private AtiqsControlLibrary.SmartLabel lblDegree2;
        private System.Windows.Forms.GroupBox groupBoxIdentity;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private Reports.ReportUI.CachedrptOPDNurseRomAlloc cachedrptOPDNurseRomAlloc1;
        private AtiqsControlLibrary.SmartLabel lblDegree4;
        private AtiqsControlLibrary.SmartLabel lblDegree3;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
    }
}
