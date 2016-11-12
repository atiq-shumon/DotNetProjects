namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOPRDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOPRDashboard));
            this.lvwDasboard = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dteDashboardDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwDoctors = new AtiqsControlLibrary.SmartListViewDetails();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtRegName = new AtiqsControlLibrary.SmartTextBox();
            this.txtEndtime = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtstarttime = new AtiqsControlLibrary.SmartTextBox();
            this.txtTheaterName = new AtiqsControlLibrary.SmartTextBox();
            this.txtPackageName = new AtiqsControlLibrary.SmartTextBox();
            this.txtInchargeName = new AtiqsControlLibrary.SmartTextBox();
            this.txtOTDate = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtRegNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvwPackage = new AtiqsControlLibrary.SmartListViewDetails();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDoctorsTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblItemRate = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNormal = new AtiqsControlLibrary.SmartTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCancel = new AtiqsControlLibrary.SmartTextBox();
            this.txtEmergency = new AtiqsControlLibrary.SmartTextBox();
            this.txtComplete = new AtiqsControlLibrary.SmartTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.mnuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(0, 33);
            this.frmLabel.Text = "";
            this.frmLabel.Visible = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.lblItemRate);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.lblDoctorsTotal);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.lvwPackage);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.lvwDoctors);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.dteDashboardDate);
            this.pnlMain.Controls.Add(this.lvwDasboard);
            this.pnlMain.Location = new System.Drawing.Point(5, 59);
            this.pnlMain.Size = new System.Drawing.Size(1514, 607);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.groupBox2);
            this.pnlTop.Size = new System.Drawing.Size(1521, 58);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(666, 666);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(553, 666);
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(779, 666);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(440, 666);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1001, 666);
            this.btnClose.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(890, 666);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 705);
            this.groupBox1.Size = new System.Drawing.Size(1521, 25);
            // 
            // lvwDasboard
            // 
            this.lvwDasboard.BackColor = System.Drawing.SystemColors.Control;
            this.lvwDasboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwDasboard.LargeImageList = this.imageList1;
            this.lvwDasboard.Location = new System.Drawing.Point(17, 66);
            this.lvwDasboard.Name = "lvwDasboard";
            this.lvwDasboard.Size = new System.Drawing.Size(970, 301);
            this.lvwDasboard.TabIndex = 3;
            this.lvwDasboard.UseCompatibleStateImageBehavior = false;
            this.lvwDasboard.SelectedIndexChanged += new System.EventHandler(this.lvwDasboard_SelectedIndexChanged);
            this.lvwDasboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwDasboard_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folio.JPG");
            this.imageList1.Images.SetKeyName(1, "Depend01.ico");
            this.imageList1.Images.SetKeyName(2, "DELETE.ICO");
            this.imageList1.Images.SetKeyName(3, "01.jpg");
            this.imageList1.Images.SetKeyName(4, "03.jpg");
            this.imageList1.Images.SetKeyName(5, "Bed3.jpeg");
            this.imageList1.Images.SetKeyName(6, "Cancel1.jpeg");
            this.imageList1.Images.SetKeyName(7, "Emer1.jpeg");
            this.imageList1.Images.SetKeyName(8, "Normal.jpeg");
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dteDashboardDate
            // 
            this.dteDashboardDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteDashboardDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDashboardDate.Location = new System.Drawing.Point(475, 28);
            this.dteDashboardDate.Name = "dteDashboardDate";
            this.dteDashboardDate.Size = new System.Drawing.Size(220, 23);
            this.dteDashboardDate.TabIndex = 4;
            this.dteDashboardDate.ValueChanged += new System.EventHandler(this.dteDashboardDate_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.lblDisplay);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(1, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1635, 48);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay.Location = new System.Drawing.Point(1427, 13);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(73, 25);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "None";
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date:";
            // 
            // lvwDoctors
            // 
            this.lvwDoctors.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwDoctors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwDoctors.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDoctors.FullRowSelect = true;
            this.lvwDoctors.GridLines = true;
            this.lvwDoctors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwDoctors.Location = new System.Drawing.Point(1021, 80);
            this.lvwDoctors.Name = "lvwDoctors";
            this.lvwDoctors.Size = new System.Drawing.Size(348, 199);
            this.lvwDoctors.TabIndex = 6;
            this.lvwDoctors.UseCompatibleStateImageBehavior = false;
            this.lvwDoctors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Doctors Code";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doctors Name";
            this.columnHeader2.Width = 480;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Controls.Add(this.smartLabel8);
            this.groupBox3.Controls.Add(this.txtRegName);
            this.groupBox3.Controls.Add(this.txtEndtime);
            this.groupBox3.Controls.Add(this.smartLabel7);
            this.groupBox3.Controls.Add(this.smartLabel6);
            this.groupBox3.Controls.Add(this.smartLabel5);
            this.groupBox3.Controls.Add(this.smartLabel4);
            this.groupBox3.Controls.Add(this.smartLabel3);
            this.groupBox3.Controls.Add(this.txtstarttime);
            this.groupBox3.Controls.Add(this.txtTheaterName);
            this.groupBox3.Controls.Add(this.txtPackageName);
            this.groupBox3.Controls.Add(this.txtInchargeName);
            this.groupBox3.Controls.Add(this.txtOTDate);
            this.groupBox3.Controls.Add(this.smartLabel2);
            this.groupBox3.Controls.Add(this.txtRegNo);
            this.groupBox3.Controls.Add(this.smartLabel1);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox3.Location = new System.Drawing.Point(17, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1002, 141);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details Information";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(27, 105);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 24);
            this.txtStatus.TabIndex = 25;
            this.txtStatus.Visible = false;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(382, 25);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(101, 14);
            this.smartLabel8.TabIndex = 24;
            this.smartLabel8.Text = "Patient Name:";
            // 
            // txtRegName
            // 
            this.txtRegName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtRegName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegName.Location = new System.Drawing.Point(484, 23);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.ReadOnly = true;
            this.txtRegName.Size = new System.Drawing.Size(226, 24);
            this.txtRegName.TabIndex = 23;
            // 
            // txtEndtime
            // 
            this.txtEndtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtEndtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndtime.Location = new System.Drawing.Point(705, 105);
            this.txtEndtime.Name = "txtEndtime";
            this.txtEndtime.ReadOnly = true;
            this.txtEndtime.Size = new System.Drawing.Size(169, 24);
            this.txtEndtime.TabIndex = 22;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(630, 109);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(72, 14);
            this.smartLabel7.TabIndex = 21;
            this.smartLabel7.Text = "End Time:";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(287, 109);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(81, 14);
            this.smartLabel6.TabIndex = 20;
            this.smartLabel6.Text = "Start Time:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(373, 69);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(110, 14);
            this.smartLabel5.TabIndex = 19;
            this.smartLabel5.Text = "Package Name:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(24, 66);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(113, 14);
            this.smartLabel4.TabIndex = 18;
            this.smartLabel4.Text = "Incharge Name:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(723, 69);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(97, 14);
            this.smartLabel3.TabIndex = 17;
            this.smartLabel3.Text = "Theter Name:";
            // 
            // txtstarttime
            // 
            this.txtstarttime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtstarttime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstarttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstarttime.Location = new System.Drawing.Point(368, 106);
            this.txtstarttime.Name = "txtstarttime";
            this.txtstarttime.ReadOnly = true;
            this.txtstarttime.Size = new System.Drawing.Size(169, 24);
            this.txtstarttime.TabIndex = 16;
            // 
            // txtTheaterName
            // 
            this.txtTheaterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTheaterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheaterName.Location = new System.Drawing.Point(825, 63);
            this.txtTheaterName.Name = "txtTheaterName";
            this.txtTheaterName.ReadOnly = true;
            this.txtTheaterName.Size = new System.Drawing.Size(169, 24);
            this.txtTheaterName.TabIndex = 15;
            // 
            // txtPackageName
            // 
            this.txtPackageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPackageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(484, 66);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.ReadOnly = true;
            this.txtPackageName.Size = new System.Drawing.Size(227, 24);
            this.txtPackageName.TabIndex = 14;
            // 
            // txtInchargeName
            // 
            this.txtInchargeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtInchargeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInchargeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInchargeName.Location = new System.Drawing.Point(138, 64);
            this.txtInchargeName.Name = "txtInchargeName";
            this.txtInchargeName.ReadOnly = true;
            this.txtInchargeName.Size = new System.Drawing.Size(216, 24);
            this.txtInchargeName.TabIndex = 13;
            // 
            // txtOTDate
            // 
            this.txtOTDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtOTDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOTDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTDate.Location = new System.Drawing.Point(825, 24);
            this.txtOTDate.Name = "txtOTDate";
            this.txtOTDate.ReadOnly = true;
            this.txtOTDate.Size = new System.Drawing.Size(169, 24);
            this.txtOTDate.TabIndex = 12;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(754, 26);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(66, 14);
            this.smartLabel2.TabIndex = 11;
            this.smartLabel2.Text = "OT Date:";
            // 
            // txtRegNo
            // 
            this.txtRegNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo.Location = new System.Drawing.Point(138, 23);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.ReadOnly = true;
            this.txtRegNo.Size = new System.Drawing.Size(218, 24);
            this.txtRegNo.TabIndex = 10;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(75, 24);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(59, 14);
            this.smartLabel1.TabIndex = 9;
            this.smartLabel1.Text = "Reg No:";
            // 
            // lvwPackage
            // 
            this.lvwPackage.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwPackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwPackage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvwPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwPackage.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPackage.FullRowSelect = true;
            this.lvwPackage.GridLines = true;
            this.lvwPackage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwPackage.Location = new System.Drawing.Point(1021, 311);
            this.lvwPackage.Name = "lvwPackage";
            this.lvwPackage.Size = new System.Drawing.Size(346, 235);
            this.lvwPackage.TabIndex = 8;
            this.lvwPackage.UseCompatibleStateImageBehavior = false;
            this.lvwPackage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Package Item  Name";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item Rate";
            this.columnHeader5.Width = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1021, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doctors Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1024, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Package Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(1180, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "No of Persons:";
            // 
            // lblDoctorsTotal
            // 
            this.lblDoctorsTotal.AutoSize = true;
            this.lblDoctorsTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorsTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDoctorsTotal.Location = new System.Drawing.Point(1300, 288);
            this.lblDoctorsTotal.Name = "lblDoctorsTotal";
            this.lblDoctorsTotal.Size = new System.Drawing.Size(16, 16);
            this.lblDoctorsTotal.TabIndex = 12;
            this.lblDoctorsTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(1172, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Rate:";
            // 
            // lblItemRate
            // 
            this.lblItemRate.AutoSize = true;
            this.lblItemRate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblItemRate.Location = new System.Drawing.Point(1300, 554);
            this.lblItemRate.Name = "lblItemRate";
            this.lblItemRate.Size = new System.Drawing.Size(16, 16);
            this.lblItemRate.TabIndex = 14;
            this.lblItemRate.Text = "0";
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuComplete,
            this.mnuCancel});
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(120, 48);
            // 
            // mnuComplete
            // 
            this.mnuComplete.Name = "mnuComplete";
            this.mnuComplete.Size = new System.Drawing.Size(119, 22);
            this.mnuComplete.Text = "Complete";
            this.mnuComplete.Click += new System.EventHandler(this.mnuComplete_Click);
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(119, 22);
            this.mnuCancel.Text = "Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Blue;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(697, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.txtNormal);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCancel);
            this.panel2.Controls.Add(this.txtEmergency);
            this.panel2.Controls.Add(this.txtComplete);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.ForeColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(17, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 82);
            this.panel2.TabIndex = 16;
            // 
            // txtNormal
            // 
            this.txtNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNormal.Enabled = false;
            this.txtNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNormal.Location = new System.Drawing.Point(289, 12);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(100, 24);
            this.txtNormal.TabIndex = 7;
            this.txtNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(225, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Normal:";
            // 
            // txtCancel
            // 
            this.txtCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCancel.Enabled = false;
            this.txtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancel.Location = new System.Drawing.Point(289, 42);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(100, 24);
            this.txtCancel.TabIndex = 5;
            this.txtCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmergency
            // 
            this.txtEmergency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmergency.Enabled = false;
            this.txtEmergency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergency.ForeColor = System.Drawing.Color.Red;
            this.txtEmergency.Location = new System.Drawing.Point(102, 42);
            this.txtEmergency.Name = "txtEmergency";
            this.txtEmergency.Size = new System.Drawing.Size(100, 24);
            this.txtEmergency.TabIndex = 4;
            this.txtEmergency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComplete
            // 
            this.txtComplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplete.Enabled = false;
            this.txtComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtComplete.Location = new System.Drawing.Point(102, 12);
            this.txtComplete.Name = "txtComplete";
            this.txtComplete.Size = new System.Drawing.Size(100, 24);
            this.txtComplete.TabIndex = 3;
            this.txtComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label10.Location = new System.Drawing.Point(227, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cancel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(15, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "Emergency:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Fuchsia;
            this.label8.Location = new System.Drawing.Point(13, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Complete:";
            // 
            // frmOPRDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1521, 730);
            this.isEnterTabAllow = true;
            this.Name = "frmOPRDashboard";
            this.Load += new System.EventHandler(this.frmOPRDashboard_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.mnuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwDasboard;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dteDashboardDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtstarttime;
        private AtiqsControlLibrary.SmartTextBox txtTheaterName;
        private AtiqsControlLibrary.SmartTextBox txtPackageName;
        private AtiqsControlLibrary.SmartTextBox txtInchargeName;
        private AtiqsControlLibrary.SmartTextBox txtOTDate;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtRegNo;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwDoctors;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartListViewDetails lvwPackage;
        private AtiqsControlLibrary.SmartTextBox txtEndtime;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private AtiqsControlLibrary.SmartTextBox txtRegName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private System.Windows.Forms.Label lblDoctorsTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblItemRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuComplete;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private AtiqsControlLibrary.SmartTextBox txtCancel;
        private AtiqsControlLibrary.SmartTextBox txtEmergency;
        private AtiqsControlLibrary.SmartTextBox txtComplete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private AtiqsControlLibrary.SmartTextBox txtNormal;
        private System.Windows.Forms.Label label11;
        private AtiqsControlLibrary.SmartTextBox txtStatus;
    }
}
