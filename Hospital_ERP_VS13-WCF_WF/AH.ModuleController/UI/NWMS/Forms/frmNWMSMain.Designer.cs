namespace AH.ModuleController.UI.NWMS.Forms
{
    partial class frmNWMSMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNWMSMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoctorVisiting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveVisitingDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditVisitingDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDischargeAdvice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveDischargeAdvice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDischargeAdvice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIPDRequisition = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIPDDoctorSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDemandRequisition = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnDoctorDutyTiming = new System.Windows.Forms.Button();
            this.btnNurseRequisition = new System.Windows.Forms.Button();
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
            this.mnuFile,
            this.mnuReport,
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
            this.mnuDoctorVisiting,
            this.mnuDischargeAdvice,
            this.mnuIPDRequisition});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuDoctorVisiting
            // 
            this.mnuDoctorVisiting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveVisitingDetails,
            this.mnuEditVisitingDetails});
            this.mnuDoctorVisiting.Name = "mnuDoctorVisiting";
            this.mnuDoctorVisiting.Size = new System.Drawing.Size(156, 22);
            this.mnuDoctorVisiting.Text = "Doctor\'s Visiting";
            this.mnuDoctorVisiting.Visible = false;
            this.mnuDoctorVisiting.Click += new System.EventHandler(this.mnuDoctorVisiting_Click);
            // 
            // mnuSaveVisitingDetails
            // 
            this.mnuSaveVisitingDetails.Name = "mnuSaveVisitingDetails";
            this.mnuSaveVisitingDetails.Size = new System.Drawing.Size(169, 22);
            this.mnuSaveVisitingDetails.Text = "Save Visiting Details";
            this.mnuSaveVisitingDetails.Click += new System.EventHandler(this.mnuSaveVisitingDetails_Click);
            // 
            // mnuEditVisitingDetails
            // 
            this.mnuEditVisitingDetails.Name = "mnuEditVisitingDetails";
            this.mnuEditVisitingDetails.Size = new System.Drawing.Size(169, 22);
            this.mnuEditVisitingDetails.Text = "Edit Visiting Details";
            this.mnuEditVisitingDetails.Click += new System.EventHandler(this.mnuEditVisitingDetails_Click);
            // 
            // mnuDischargeAdvice
            // 
            this.mnuDischargeAdvice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveDischargeAdvice,
            this.mnuEditDischargeAdvice});
            this.mnuDischargeAdvice.Name = "mnuDischargeAdvice";
            this.mnuDischargeAdvice.Size = new System.Drawing.Size(156, 22);
            this.mnuDischargeAdvice.Text = "Discharge Advice";
            this.mnuDischargeAdvice.Click += new System.EventHandler(this.mnuDischargeAdvice_Click);
            // 
            // mnuSaveDischargeAdvice
            // 
            this.mnuSaveDischargeAdvice.Name = "mnuSaveDischargeAdvice";
            this.mnuSaveDischargeAdvice.Size = new System.Drawing.Size(183, 22);
            this.mnuSaveDischargeAdvice.Text = "Save Discharge Advice";
            this.mnuSaveDischargeAdvice.Click += new System.EventHandler(this.mnuSaveDischargeAdvice_Click);
            // 
            // mnuEditDischargeAdvice
            // 
            this.mnuEditDischargeAdvice.Name = "mnuEditDischargeAdvice";
            this.mnuEditDischargeAdvice.Size = new System.Drawing.Size(183, 22);
            this.mnuEditDischargeAdvice.Text = "Edit Discharge Advice";
            this.mnuEditDischargeAdvice.Click += new System.EventHandler(this.mnuEditDischargeAdvice_Click);
            // 
            // mnuIPDRequisition
            // 
            this.mnuIPDRequisition.Name = "mnuIPDRequisition";
            this.mnuIPDRequisition.Size = new System.Drawing.Size(156, 22);
            this.mnuIPDRequisition.Text = "IPD Requisition";
            this.mnuIPDRequisition.Click += new System.EventHandler(this.mnuIPDRequisition_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportManager});
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(52, 20);
            this.mnuReport.Text = "Report";
            // 
            // mnuReportManager
            // 
            this.mnuReportManager.Name = "mnuReportManager";
            this.mnuReportManager.Size = new System.Drawing.Size(152, 22);
            this.mnuReportManager.Text = "Report Manager";
            this.mnuReportManager.Click += new System.EventHandler(this.mnuReportManager_Click);
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIPDDoctorSetup});
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(47, 20);
            this.mnuSetup.Text = "Setup";
            // 
            // mnuIPDDoctorSetup
            // 
            this.mnuIPDDoctorSetup.Name = "mnuIPDDoctorSetup";
            this.mnuIPDDoctorSetup.Size = new System.Drawing.Size(157, 22);
            this.mnuIPDDoctorSetup.Text = "IPD Doctor Setup";
            this.mnuIPDDoctorSetup.Visible = false;
            this.mnuIPDDoctorSetup.Click += new System.EventHandler(this.mnuIPDDoctorSetup_Click);
            // 
            // mnuUtility
            // 
            this.mnuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangePassword,
            this.mnuDemandRequisition});
            this.mnuUtility.Name = "mnuUtility";
            this.mnuUtility.Size = new System.Drawing.Size(46, 20);
            this.mnuUtility.Text = "Utility";
            // 
            // mnuChangePassword
            // 
            this.mnuChangePassword.Name = "mnuChangePassword";
            this.mnuChangePassword.Size = new System.Drawing.Size(168, 22);
            this.mnuChangePassword.Text = "Change Password";
            this.mnuChangePassword.Click += new System.EventHandler(this.mnuChangePassword_Click);
            // 
            // mnuDemandRequisition
            // 
            this.mnuDemandRequisition.Name = "mnuDemandRequisition";
            this.mnuDemandRequisition.Size = new System.Drawing.Size(168, 22);
            this.mnuDemandRequisition.Text = "Demand Requisition";
            this.mnuDemandRequisition.Click += new System.EventHandler(this.mnuDemandRequisition_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.Controls.Add(this.btnDoctorDutyTiming);
            this.pnlPatientRegistration.Controls.Add(this.btnNurseRequisition);
            this.pnlPatientRegistration.Controls.Add(this.btnCloseModule);
            this.pnlPatientRegistration.Location = new System.Drawing.Point(125, 164);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(835, 429);
            this.pnlPatientRegistration.TabIndex = 37;
            // 
            // btnDoctorDutyTiming
            // 
            this.btnDoctorDutyTiming.BackColor = System.Drawing.Color.Orchid;
            this.btnDoctorDutyTiming.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDoctorDutyTiming.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorDutyTiming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorDutyTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorDutyTiming.ForeColor = System.Drawing.Color.White;
            this.btnDoctorDutyTiming.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoctorDutyTiming.ImageList = this.imageList1;
            this.btnDoctorDutyTiming.Location = new System.Drawing.Point(178, 108);
            this.btnDoctorDutyTiming.Name = "btnDoctorDutyTiming";
            this.btnDoctorDutyTiming.Size = new System.Drawing.Size(247, 102);
            this.btnDoctorDutyTiming.TabIndex = 33;
            this.btnDoctorDutyTiming.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoctorDutyTiming.UseVisualStyleBackColor = false;
            this.btnDoctorDutyTiming.Visible = false;
            this.btnDoctorDutyTiming.Click += new System.EventHandler(this.btnDoctorDutyTiming_Click);
            // 
            // btnNurseRequisition
            // 
            this.btnNurseRequisition.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNurseRequisition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNurseRequisition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNurseRequisition.FlatAppearance.BorderSize = 0;
            this.btnNurseRequisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNurseRequisition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNurseRequisition.ForeColor = System.Drawing.Color.White;
            this.btnNurseRequisition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNurseRequisition.ImageIndex = 3;
            this.btnNurseRequisition.ImageList = this.imageList1;
            this.btnNurseRequisition.Location = new System.Drawing.Point(178, 0);
            this.btnNurseRequisition.Name = "btnNurseRequisition";
            this.btnNurseRequisition.Size = new System.Drawing.Size(247, 102);
            this.btnNurseRequisition.TabIndex = 32;
            this.btnNurseRequisition.Text = "Requisition";
            this.btnNurseRequisition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNurseRequisition.UseVisualStyleBackColor = false;
            this.btnNurseRequisition.Click += new System.EventHandler(this.btnAppointmentRegistration_Click);
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
            this.btnCloseModule.Location = new System.Drawing.Point(433, 0);
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
            this.pnlModuleName.Location = new System.Drawing.Point(121, 109);
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
            this.label1.Location = new System.Drawing.Point(210, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nursing Workbench Management System";
            // 
            // frmNWMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1199, 758);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.pnlPatientRegistration);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlModuleName);
            this.Controls.Add(this.userWidgetMetro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNWMSMain";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNWMSMain_Load);
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
        private System.Windows.Forms.Button btnCloseModule;
        private System.Windows.Forms.Button btnDoctorDutyTiming;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private AtiqsControlLibrary.UserWidgetMetro userWidgetMetro1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.Panel pnlModuleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timermain;
        private System.Windows.Forms.ToolStripMenuItem mnuUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuDoctorVisiting;
        private System.Windows.Forms.ToolStripMenuItem mnuIPDRequisition;
        private System.Windows.Forms.Button btnNurseRequisition;
        private System.Windows.Forms.ToolStripMenuItem mnuDemandRequisition;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuReportManager;
        private System.Windows.Forms.ToolStripMenuItem mnuDischargeAdvice;
        private System.Windows.Forms.ToolStripMenuItem mnuIPDDoctorSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveDischargeAdvice;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDischargeAdvice;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveVisitingDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuEditVisitingDetails;
    }
}
