namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOPRMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOPRMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoctorsCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperationtype = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOprInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperationtheater = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPackageInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnupackageMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPackageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPackageConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOTmap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChecklistInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChecklistItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatientChecklist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperationInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnOTtheater = new System.Windows.Forms.Button();
            this.btnOtScheduling = new System.Windows.Forms.Button();
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
            this.userWidgetMetro1 = new AtiqsControlLibrary.UserWidgetMetro();
            this.dateWidget1 = new AtiqsControlLibrary.DateWidget();
            this.pnlModuleName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timermain = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlPatientRegistration.SuspendLayout();
            this.pnlModuleName.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetup,
            this.mnuReports,
            this.fileToolStripMenuItem,
            this.mnuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoctorsCategory,
            this.mnuOperationtype,
            this.mnuOprInfor,
            this.mnuOperationtheater,
            this.mnuPackageInformation,
            this.mnuOTmap,
            this.mnuDashBoard,
            this.mnuChecklistInformation});
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(47, 20);
            this.mnuSetup.Text = "Setup";
            // 
            // mnuDoctorsCategory
            // 
            this.mnuDoctorsCategory.Name = "mnuDoctorsCategory";
            this.mnuDoctorsCategory.Size = new System.Drawing.Size(181, 22);
            this.mnuDoctorsCategory.Text = "Doctor\'s Category";
            this.mnuDoctorsCategory.Click += new System.EventHandler(this.mnuDoctorsCategory_Click);
            // 
            // mnuOperationtype
            // 
            this.mnuOperationtype.Name = "mnuOperationtype";
            this.mnuOperationtype.Size = new System.Drawing.Size(181, 22);
            this.mnuOperationtype.Text = "Operation Type";
            this.mnuOperationtype.Click += new System.EventHandler(this.mnuOperationtype_Click);
            // 
            // mnuOprInfor
            // 
            this.mnuOprInfor.Name = "mnuOprInfor";
            this.mnuOprInfor.Size = new System.Drawing.Size(181, 22);
            this.mnuOprInfor.Text = "Operation Information";
            this.mnuOprInfor.Click += new System.EventHandler(this.mnuOprInfor_Click);
            // 
            // mnuOperationtheater
            // 
            this.mnuOperationtheater.Name = "mnuOperationtheater";
            this.mnuOperationtheater.Size = new System.Drawing.Size(181, 22);
            this.mnuOperationtheater.Text = "Opeartion Theater";
            this.mnuOperationtheater.Click += new System.EventHandler(this.mnuOperationtheater_Click);
            // 
            // mnuPackageInformation
            // 
            this.mnuPackageInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnupackageMaster,
            this.mnuPackageItem,
            this.mnuPackageConfig});
            this.mnuPackageInformation.Name = "mnuPackageInformation";
            this.mnuPackageInformation.Size = new System.Drawing.Size(181, 22);
            this.mnuPackageInformation.Text = "Package Information";
            // 
            // mnupackageMaster
            // 
            this.mnupackageMaster.Name = "mnupackageMaster";
            this.mnupackageMaster.Size = new System.Drawing.Size(182, 22);
            this.mnupackageMaster.Text = "Package Master";
            this.mnupackageMaster.Visible = false;
            this.mnupackageMaster.Click += new System.EventHandler(this.mnupackageMaster_Click);
            // 
            // mnuPackageItem
            // 
            this.mnuPackageItem.Name = "mnuPackageItem";
            this.mnuPackageItem.Size = new System.Drawing.Size(182, 22);
            this.mnuPackageItem.Text = "Package Item ";
            this.mnuPackageItem.Click += new System.EventHandler(this.mnuPackageItem_Click);
            // 
            // mnuPackageConfig
            // 
            this.mnuPackageConfig.Name = "mnuPackageConfig";
            this.mnuPackageConfig.Size = new System.Drawing.Size(182, 22);
            this.mnuPackageConfig.Text = "Package Configuration";
            this.mnuPackageConfig.Click += new System.EventHandler(this.mnuPackageConfig_Click);
            // 
            // mnuOTmap
            // 
            this.mnuOTmap.Name = "mnuOTmap";
            this.mnuOTmap.Size = new System.Drawing.Size(181, 22);
            this.mnuOTmap.Text = "OT Scheduling";
            this.mnuOTmap.Click += new System.EventHandler(this.mnuOTmap_Click);
            // 
            // mnuDashBoard
            // 
            this.mnuDashBoard.Name = "mnuDashBoard";
            this.mnuDashBoard.Size = new System.Drawing.Size(181, 22);
            this.mnuDashBoard.Text = "Dash Board";
            this.mnuDashBoard.Click += new System.EventHandler(this.mnuDashBoard_Click);
            // 
            // mnuChecklistInformation
            // 
            this.mnuChecklistInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChecklistItem,
            this.mnuPatientChecklist});
            this.mnuChecklistInformation.Name = "mnuChecklistInformation";
            this.mnuChecklistInformation.Size = new System.Drawing.Size(181, 22);
            this.mnuChecklistInformation.Text = "Check List Information";
            // 
            // mnuChecklistItem
            // 
            this.mnuChecklistItem.Name = "mnuChecklistItem";
            this.mnuChecklistItem.Size = new System.Drawing.Size(153, 22);
            this.mnuChecklistItem.Text = "CheckList Item";
            this.mnuChecklistItem.Click += new System.EventHandler(this.mnuChecklistItem_Click);
            // 
            // mnuPatientChecklist
            // 
            this.mnuPatientChecklist.Name = "mnuPatientChecklist";
            this.mnuPatientChecklist.Size = new System.Drawing.Size(153, 22);
            this.mnuPatientChecklist.Text = "Patient Checklist";
            this.mnuPatientChecklist.Click += new System.EventHandler(this.mnuPatientChecklist_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOperationInformation});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(57, 20);
            this.mnuReports.Text = "Reports";
            // 
            // mnuOperationInformation
            // 
            this.mnuOperationInformation.Name = "mnuOperationInformation";
            this.mnuOperationInformation.Size = new System.Drawing.Size(181, 22);
            this.mnuOperationInformation.Text = "Operation Information";
            this.mnuOperationInformation.Click += new System.EventHandler(this.mnuOperationInformation_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientRegistrationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Visible = false;
            // 
            // newPatientRegistrationToolStripMenuItem
            // 
            this.newPatientRegistrationToolStripMenuItem.Name = "newPatientRegistrationToolStripMenuItem";
            this.newPatientRegistrationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newPatientRegistrationToolStripMenuItem.Text = "New Patient Registration";
            // 
            // mnuUtility
            // 
            this.mnuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangePassword});
            this.mnuUtility.Name = "mnuUtility";
            this.mnuUtility.Size = new System.Drawing.Size(46, 20);
            this.mnuUtility.Text = "Utility";
            // 
            // mnuChangePassword
            // 
            this.mnuChangePassword.Name = "mnuChangePassword";
            this.mnuChangePassword.Size = new System.Drawing.Size(160, 22);
            this.mnuChangePassword.Text = "Change Password";
            this.mnuChangePassword.Click += new System.EventHandler(this.mnuChangePassword_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gnome_logout.png");
            this.imageList1.Images.SetKeyName(1, "receptionist-icon.png");
            this.imageList1.Images.SetKeyName(2, "doctor-icon.png");
            this.imageList1.Images.SetKeyName(3, "surgery3.jpg");
            this.imageList1.Images.SetKeyName(4, "Surgey2.jpg");
            this.imageList1.Images.SetKeyName(5, "Dash.png");
            this.imageList1.Images.SetKeyName(6, "Room1.jpg");
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.Controls.Add(this.btnDashBoard);
            this.pnlPatientRegistration.Controls.Add(this.btnOTtheater);
            this.pnlPatientRegistration.Controls.Add(this.btnOtScheduling);
            this.pnlPatientRegistration.Controls.Add(this.btnDoctorDutyTiming);
            this.pnlPatientRegistration.Controls.Add(this.btnAppointmentRegistration);
            this.pnlPatientRegistration.Controls.Add(this.btnCloseModule);
            this.pnlPatientRegistration.Location = new System.Drawing.Point(105, 181);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(584, 232);
            this.pnlPatientRegistration.TabIndex = 37;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.Black;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDashBoard.ImageKey = "Dash.png";
            this.btnDashBoard.ImageList = this.imageList1;
            this.btnDashBoard.Location = new System.Drawing.Point(35, 114);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(247, 102);
            this.btnDashBoard.TabIndex = 36;
            this.btnDashBoard.Text = "Dash Board";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click_1);
            // 
            // btnOTtheater
            // 
            this.btnOTtheater.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOTtheater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOTtheater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOTtheater.FlatAppearance.BorderSize = 0;
            this.btnOTtheater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOTtheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTtheater.ForeColor = System.Drawing.Color.Black;
            this.btnOTtheater.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOTtheater.ImageKey = "Room1.jpg";
            this.btnOTtheater.ImageList = this.imageList1;
            this.btnOTtheater.Location = new System.Drawing.Point(34, 2);
            this.btnOTtheater.Name = "btnOTtheater";
            this.btnOTtheater.Size = new System.Drawing.Size(247, 102);
            this.btnOTtheater.TabIndex = 35;
            this.btnOTtheater.Text = "Opeartion Theater";
            this.btnOTtheater.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOTtheater.UseVisualStyleBackColor = false;
            this.btnOTtheater.Click += new System.EventHandler(this.btnOTtheater_Click);
            // 
            // btnOtScheduling
            // 
            this.btnOtScheduling.BackColor = System.Drawing.SystemColors.Info;
            this.btnOtScheduling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOtScheduling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtScheduling.FlatAppearance.BorderSize = 0;
            this.btnOtScheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtScheduling.ForeColor = System.Drawing.Color.Black;
            this.btnOtScheduling.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOtScheduling.ImageKey = "Surgey2.jpg";
            this.btnOtScheduling.ImageList = this.imageList1;
            this.btnOtScheduling.Location = new System.Drawing.Point(295, 2);
            this.btnOtScheduling.Name = "btnOtScheduling";
            this.btnOtScheduling.Size = new System.Drawing.Size(247, 102);
            this.btnOtScheduling.TabIndex = 34;
            this.btnOtScheduling.Text = "OT Scheduling";
            this.btnOtScheduling.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOtScheduling.UseVisualStyleBackColor = false;
            this.btnOtScheduling.Click += new System.EventHandler(this.btnOtScheduling_Click);
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
            this.btnDoctorDutyTiming.ImageList = this.imageList1;
            this.btnDoctorDutyTiming.Location = new System.Drawing.Point(295, 3);
            this.btnDoctorDutyTiming.Name = "btnDoctorDutyTiming";
            this.btnDoctorDutyTiming.Size = new System.Drawing.Size(247, 102);
            this.btnDoctorDutyTiming.TabIndex = 33;
            this.btnDoctorDutyTiming.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoctorDutyTiming.UseVisualStyleBackColor = false;
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
            this.btnAppointmentRegistration.ImageList = this.imageList1;
            this.btnAppointmentRegistration.Location = new System.Drawing.Point(35, 3);
            this.btnAppointmentRegistration.Name = "btnAppointmentRegistration";
            this.btnAppointmentRegistration.Size = new System.Drawing.Size(247, 102);
            this.btnAppointmentRegistration.TabIndex = 32;
            this.btnAppointmentRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppointmentRegistration.UseVisualStyleBackColor = false;
            this.btnAppointmentRegistration.Click += new System.EventHandler(this.btnAppointmentRegistration_Click);
            // 
            // btnCloseModule
            // 
            this.btnCloseModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnCloseModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseModule.FlatAppearance.BorderSize = 0;
            this.btnCloseModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseModule.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCloseModule.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseModule.ImageKey = "gnome_logout.png";
            this.btnCloseModule.ImageList = this.imageList1;
            this.btnCloseModule.Location = new System.Drawing.Point(296, 113);
            this.btnCloseModule.Name = "btnCloseModule";
            this.btnCloseModule.Size = new System.Drawing.Size(247, 102);
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
            // userWidgetMetro1
            // 
            this.userWidgetMetro1.BackColor = System.Drawing.Color.Transparent;
            this.userWidgetMetro1.Location = new System.Drawing.Point(835, 27);
            this.userWidgetMetro1.Name = "userWidgetMetro1";
            this.userWidgetMetro1.Size = new System.Drawing.Size(364, 122);
            this.userWidgetMetro1.TabIndex = 38;
            this.userWidgetMetro1.btnLogout_Clicked += new AtiqsControlLibrary.UserWidgetMetro.LogoutButtonClickHandler(this.userWidgetMetro1_btnLogout_Clicked);
            // 
            // dateWidget1
            // 
            this.dateWidget1.BackColor = System.Drawing.Color.Transparent;
            this.dateWidget1.Location = new System.Drawing.Point(825, 649);
            this.dateWidget1.Name = "dateWidget1";
            this.dateWidget1.Size = new System.Drawing.Size(374, 109);
            this.dateWidget1.TabIndex = 39;
            // 
            // pnlModuleName
            // 
            this.pnlModuleName.BackColor = System.Drawing.Color.Transparent;
            this.pnlModuleName.Controls.Add(this.label1);
            this.pnlModuleName.Location = new System.Drawing.Point(105, 121);
            this.pnlModuleName.Name = "pnlModuleName";
            this.pnlModuleName.Size = new System.Drawing.Size(839, 54);
            this.pnlModuleName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Operation Management System";
            // 
            // timermain
            // 
            this.timermain.Interval = 10000;
            this.timermain.Tick += new System.EventHandler(this.timermain_Tick);
            // 
            // frmOPRMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1199, 758);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.pnlPatientRegistration);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userWidgetMetro1);
            this.Controls.Add(this.pnlModuleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOPRMain";
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
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
        private System.Windows.Forms.ToolStripMenuItem newPatientRegistrationToolStripMenuItem;
        private System.Windows.Forms.Button btnCloseModule;
        private System.Windows.Forms.Button btnDoctorDutyTiming;
        private System.Windows.Forms.Button btnAppointmentRegistration;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private AtiqsControlLibrary.UserWidgetMetro userWidgetMetro1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.Panel pnlModuleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuOperationtype;
        private System.Windows.Forms.ToolStripMenuItem mnuOperationtheater;
        private System.Windows.Forms.ToolStripMenuItem mnuPackageInformation;
        private System.Windows.Forms.ToolStripMenuItem mnuPackageItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPackageConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuDoctorsCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuChecklistInformation;
        private System.Windows.Forms.ToolStripMenuItem mnuChecklistItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPatientChecklist;
        private System.Windows.Forms.Timer timermain;
        private System.Windows.Forms.ToolStripMenuItem mnuUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnuOTmap;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnOTtheater;
        private System.Windows.Forms.Button btnOtScheduling;
        private System.Windows.Forms.ToolStripMenuItem mnuDashBoard;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuOperationInformation;
        private System.Windows.Forms.ToolStripMenuItem mnuOprInfor;
        private System.Windows.Forms.ToolStripMenuItem mnupackageMaster;
    }
}
