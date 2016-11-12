namespace AH.ModuleController.UI.APMS.Forms
{
    partial class frmAPMSMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAPMSMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatientInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPatientList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoctorDutyTiming = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAppointmentRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDemandRequisition = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnHcnPendingList = new System.Windows.Forms.Button();
            this.btnIPDPatientSearch = new System.Windows.Forms.Button();
            this.btnDoctorDutyTiming = new System.Windows.Forms.Button();
            this.btnAppointmentRegistration = new System.Windows.Forms.Button();
            this.btnCloseModule = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnSeftDMR = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIPDDMR = new System.Windows.Forms.Button();
            this.btnOutCaseDMR = new System.Windows.Forms.Button();
            this.btnOPDDiagnosticMR = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlModuleName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userWidgetMetro1 = new AtiqsControlLibrary.UserWidgetMetro();
            this.dateWidget1 = new AtiqsControlLibrary.DateWidget();
            this.menuStrip1.SuspendLayout();
            this.pnlPatientRegistration.SuspendLayout();
            this.pnlModuleName.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuSetup,
            this.mnuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPatientInformation,
            this.toolStripSeparator1,
            this.mnuPatientList,
            this.toolStripSeparator2,
            this.mnuClose});
            this.mnuFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(38, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.Click += new System.EventHandler(this.mnuFile_Click);
            // 
            // mnuPatientInformation
            // 
            this.mnuPatientInformation.Name = "mnuPatientInformation";
            this.mnuPatientInformation.Size = new System.Drawing.Size(209, 22);
            this.mnuPatientInformation.Text = "IPD Patient Information";
            this.mnuPatientInformation.Click += new System.EventHandler(this.mnuPatientInformation_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuPatientList
            // 
            this.mnuPatientList.Name = "mnuPatientList";
            this.mnuPatientList.Size = new System.Drawing.Size(209, 22);
            this.mnuPatientList.Text = "HCN Pending List";
            this.mnuPatientList.Click += new System.EventHandler(this.patientListForHCNToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuClose.Size = new System.Drawing.Size(209, 22);
            this.mnuClose.Text = "Close                   ";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoctorDutyTiming,
            this.toolStripSeparator3,
            this.mnuAppointmentRegistration,
            this.toolStripSeparator4});
            this.mnuSetup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(52, 20);
            this.mnuSetup.Text = "Setup";
            // 
            // mnuDoctorDutyTiming
            // 
            this.mnuDoctorDutyTiming.Name = "mnuDoctorDutyTiming";
            this.mnuDoctorDutyTiming.Size = new System.Drawing.Size(192, 22);
            this.mnuDoctorDutyTiming.Text = "Doctor\'s Duty Timing";
            this.mnuDoctorDutyTiming.Click += new System.EventHandler(this.mnuDoctorDutyTiming_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(189, 6);
            // 
            // mnuAppointmentRegistration
            // 
            this.mnuAppointmentRegistration.Name = "mnuAppointmentRegistration";
            this.mnuAppointmentRegistration.Size = new System.Drawing.Size(192, 22);
            this.mnuAppointmentRegistration.Text = "Get Appointment ";
            this.mnuAppointmentRegistration.Click += new System.EventHandler(this.mnuAppointmentRegistration_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(189, 6);
            // 
            // mnuUtility
            // 
            this.mnuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResetPassword,
            this.toolStripSeparator5,
            this.mnuDemandRequisition});
            this.mnuUtility.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUtility.Name = "mnuUtility";
            this.mnuUtility.Size = new System.Drawing.Size(53, 20);
            this.mnuUtility.Text = "Utility";
            this.mnuUtility.Click += new System.EventHandler(this.mnuUtility_Click);
            // 
            // mnuResetPassword
            // 
            this.mnuResetPassword.Name = "mnuResetPassword";
            this.mnuResetPassword.Size = new System.Drawing.Size(187, 22);
            this.mnuResetPassword.Text = "Change Password";
            this.mnuResetPassword.Click += new System.EventHandler(this.mnuResetPassword_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(184, 6);
            // 
            // mnuDemandRequisition
            // 
            this.mnuDemandRequisition.Name = "mnuDemandRequisition";
            this.mnuDemandRequisition.Size = new System.Drawing.Size(187, 22);
            this.mnuDemandRequisition.Text = "Demand Requisition";
            this.mnuDemandRequisition.Click += new System.EventHandler(this.mnuDemandRequisition_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gnome_logout.png");
            this.imageList1.Images.SetKeyName(1, "receptionist-icon.png");
            this.imageList1.Images.SetKeyName(2, "doctor-icon.png");
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.Controls.Add(this.btnHcnPendingList);
            this.pnlPatientRegistration.Controls.Add(this.btnIPDPatientSearch);
            this.pnlPatientRegistration.Controls.Add(this.btnDoctorDutyTiming);
            this.pnlPatientRegistration.Controls.Add(this.btnAppointmentRegistration);
            this.pnlPatientRegistration.Controls.Add(this.btnCloseModule);
            this.pnlPatientRegistration.Location = new System.Drawing.Point(151, 205);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(835, 429);
            this.pnlPatientRegistration.TabIndex = 37;
            // 
            // btnHcnPendingList
            // 
            this.btnHcnPendingList.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnHcnPendingList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHcnPendingList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHcnPendingList.FlatAppearance.BorderSize = 0;
            this.btnHcnPendingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHcnPendingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHcnPendingList.ForeColor = System.Drawing.Color.White;
            this.btnHcnPendingList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHcnPendingList.ImageIndex = 2;
            this.btnHcnPendingList.ImageList = this.imageList1;
            this.btnHcnPendingList.Location = new System.Drawing.Point(534, 3);
            this.btnHcnPendingList.Name = "btnHcnPendingList";
            this.btnHcnPendingList.Size = new System.Drawing.Size(247, 102);
            this.btnHcnPendingList.TabIndex = 46;
            this.btnHcnPendingList.Text = "HCN Pending List";
            this.btnHcnPendingList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHcnPendingList.UseVisualStyleBackColor = false;
            this.btnHcnPendingList.Click += new System.EventHandler(this.btnHcnPendingList_Click);
            // 
            // btnIPDPatientSearch
            // 
            this.btnIPDPatientSearch.BackColor = System.Drawing.Color.Blue;
            this.btnIPDPatientSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIPDPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIPDPatientSearch.FlatAppearance.BorderSize = 0;
            this.btnIPDPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIPDPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPDPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnIPDPatientSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIPDPatientSearch.ImageIndex = 2;
            this.btnIPDPatientSearch.ImageList = this.imageList1;
            this.btnIPDPatientSearch.Location = new System.Drawing.Point(281, 3);
            this.btnIPDPatientSearch.Name = "btnIPDPatientSearch";
            this.btnIPDPatientSearch.Size = new System.Drawing.Size(247, 102);
            this.btnIPDPatientSearch.TabIndex = 34;
            this.btnIPDPatientSearch.Text = "IPD Patient Information";
            this.btnIPDPatientSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIPDPatientSearch.UseVisualStyleBackColor = false;
            this.btnIPDPatientSearch.Click += new System.EventHandler(this.btnIPDPatientSearch_Click);
            // 
            // btnDoctorDutyTiming
            // 
            this.btnDoctorDutyTiming.BackColor = System.Drawing.Color.Orchid;
            this.btnDoctorDutyTiming.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDoctorDutyTiming.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorDutyTiming.FlatAppearance.BorderSize = 0;
            this.btnDoctorDutyTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorDutyTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorDutyTiming.ForeColor = System.Drawing.Color.White;
            this.btnDoctorDutyTiming.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoctorDutyTiming.ImageIndex = 2;
            this.btnDoctorDutyTiming.ImageList = this.imageList1;
            this.btnDoctorDutyTiming.Location = new System.Drawing.Point(281, 110);
            this.btnDoctorDutyTiming.Name = "btnDoctorDutyTiming";
            this.btnDoctorDutyTiming.Size = new System.Drawing.Size(247, 102);
            this.btnDoctorDutyTiming.TabIndex = 33;
            this.btnDoctorDutyTiming.Text = "Doctor Duty Timing";
            this.btnDoctorDutyTiming.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoctorDutyTiming.UseVisualStyleBackColor = false;
            this.btnDoctorDutyTiming.Visible = false;
            this.btnDoctorDutyTiming.Click += new System.EventHandler(this.btnDoctorDutyTiming_Click);
            // 
            // btnAppointmentRegistration
            // 
            this.btnAppointmentRegistration.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAppointmentRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointmentRegistration.FlatAppearance.BorderSize = 0;
            this.btnAppointmentRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentRegistration.ForeColor = System.Drawing.Color.Black;
            this.btnAppointmentRegistration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAppointmentRegistration.ImageIndex = 1;
            this.btnAppointmentRegistration.ImageList = this.imageList1;
            this.btnAppointmentRegistration.Location = new System.Drawing.Point(30, 3);
            this.btnAppointmentRegistration.Name = "btnAppointmentRegistration";
            this.btnAppointmentRegistration.Size = new System.Drawing.Size(247, 102);
            this.btnAppointmentRegistration.TabIndex = 32;
            this.btnAppointmentRegistration.Text = "Get Appointment ";
            this.btnAppointmentRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppointmentRegistration.UseVisualStyleBackColor = false;
            this.btnAppointmentRegistration.Click += new System.EventHandler(this.btnAppointmentRegistration_Click);
            // 
            // btnCloseModule
            // 
            this.btnCloseModule.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseModule.FlatAppearance.BorderSize = 0;
            this.btnCloseModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseModule.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCloseModule.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseModule.ImageKey = "gnome_logout.png";
            this.btnCloseModule.ImageList = this.imageList1;
            this.btnCloseModule.Location = new System.Drawing.Point(31, 110);
            this.btnCloseModule.Name = "btnCloseModule";
            this.btnCloseModule.Size = new System.Drawing.Size(244, 102);
            this.btnCloseModule.TabIndex = 31;
            this.btnCloseModule.Text = "Close Module";
            this.btnCloseModule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseModule.UseVisualStyleBackColor = false;
            this.btnCloseModule.Click += new System.EventHandler(this.btnCloseModule_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 0;
            // 
            // btnSeftDMR
            // 
            this.btnSeftDMR.Location = new System.Drawing.Point(0, 0);
            this.btnSeftDMR.Name = "btnSeftDMR";
            this.btnSeftDMR.Size = new System.Drawing.Size(75, 23);
            this.btnSeftDMR.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DarkGray;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(322, 331);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 102);
            this.button8.TabIndex = 36;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkGray;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(176, 331);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 102);
            this.button7.TabIndex = 35;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DarkGray;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(34, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 102);
            this.button6.TabIndex = 34;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkGray;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(322, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 102);
            this.button5.TabIndex = 33;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkGray;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(176, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 102);
            this.button4.TabIndex = 32;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkGray;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(34, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 102);
            this.button3.TabIndex = 31;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnIPDDMR
            // 
            this.btnIPDDMR.Location = new System.Drawing.Point(0, 0);
            this.btnIPDDMR.Name = "btnIPDDMR";
            this.btnIPDDMR.Size = new System.Drawing.Size(75, 23);
            this.btnIPDDMR.TabIndex = 0;
            // 
            // btnOutCaseDMR
            // 
            this.btnOutCaseDMR.Location = new System.Drawing.Point(0, 0);
            this.btnOutCaseDMR.Name = "btnOutCaseDMR";
            this.btnOutCaseDMR.Size = new System.Drawing.Size(75, 23);
            this.btnOutCaseDMR.TabIndex = 0;
            // 
            // btnOPDDiagnosticMR
            // 
            this.btnOPDDiagnosticMR.Location = new System.Drawing.Point(0, 0);
            this.btnOPDDiagnosticMR.Name = "btnOPDDiagnosticMR";
            this.btnOPDDiagnosticMR.Size = new System.Drawing.Size(75, 23);
            this.btnOPDDiagnosticMR.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlModuleName
            // 
            this.pnlModuleName.BackColor = System.Drawing.Color.Transparent;
            this.pnlModuleName.Controls.Add(this.label1);
            this.pnlModuleName.Location = new System.Drawing.Point(151, 148);
            this.pnlModuleName.Name = "pnlModuleName";
            this.pnlModuleName.Size = new System.Drawing.Size(835, 54);
            this.pnlModuleName.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Appointment Management System";
            // 
            // userWidgetMetro1
            // 
            this.userWidgetMetro1.BackColor = System.Drawing.Color.Transparent;
            this.userWidgetMetro1.Location = new System.Drawing.Point(852, 26);
            this.userWidgetMetro1.Name = "userWidgetMetro1";
            this.userWidgetMetro1.Size = new System.Drawing.Size(347, 122);
            this.userWidgetMetro1.TabIndex = 44;
            this.userWidgetMetro1.btnLogout_Clicked += new AtiqsControlLibrary.UserWidgetMetro.LogoutButtonClickHandler(this.userWidgetMetro1_btnLogout_Clicked);
            this.userWidgetMetro1.Load += new System.EventHandler(this.userWidgetMetro1_Load);
            // 
            // dateWidget1
            // 
            this.dateWidget1.BackColor = System.Drawing.Color.Transparent;
            this.dateWidget1.Location = new System.Drawing.Point(825, 736);
            this.dateWidget1.Name = "dateWidget1";
            this.dateWidget1.Size = new System.Drawing.Size(374, 109);
            this.dateWidget1.TabIndex = 45;
            // 
            // frmAPMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1199, 846);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.pnlModuleName);
            this.Controls.Add(this.pnlPatientRegistration);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userWidgetMetro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAPMSMain";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAPMSMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlPatientRegistration.ResumeLayout(false);
            this.pnlModuleName.ResumeLayout(false);
            this.pnlModuleName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuDoctorDutyTiming;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.Button btnOPDDiagnosticMR;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnSeftDMR;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnIPDDMR;
        private System.Windows.Forms.Button btnOutCaseDMR;
        private System.Windows.Forms.ToolStripMenuItem mnuAppointmentRegistration;
        private System.Windows.Forms.Button btnCloseModule;
        private System.Windows.Forms.Button btnDoctorDutyTiming;
        private System.Windows.Forms.Button btnAppointmentRegistration;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuResetPassword;
        private System.Windows.Forms.Panel pnlModuleName;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.UserWidgetMetro userWidgetMetro1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.ToolStripMenuItem mnuPatientList;
        private System.Windows.Forms.ToolStripMenuItem mnuPatientInformation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuDemandRequisition;
        private System.Windows.Forms.Button btnIPDPatientSearch;
        private System.Windows.Forms.Button btnHcnPendingList;
    }
}
