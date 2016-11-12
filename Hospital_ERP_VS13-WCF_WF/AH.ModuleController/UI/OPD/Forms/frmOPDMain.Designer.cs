namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmOPDMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOPDMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrescriptionPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrescriptionEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrescriptionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOPDQueue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicketCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollectedTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicketRefundCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollectionSendToAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedicalSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiseaseCaseSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClinicalDiagnosis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComplaintsSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOPDAdvice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClinicalFindingsGroupSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClinicalFindingsSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClinicalFindingsValueSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClinicalFindingsValueAssign = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRoomSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNurseRoomAllocation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoomGroupAssign = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOPDDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDemandRequisition = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnOPDQueue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnPrescriptionEntry = new System.Windows.Forms.Button();
            this.btnReportManager = new System.Windows.Forms.Button();
            this.btnOPDTIcketModule = new System.Windows.Forms.Button();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.pnlModuleName = new System.Windows.Forms.Panel();
            this.dateWidget1 = new AtiqsControlLibrary.DateWidget();
            this.userWidget1 = new AtiqsControlLibrary.UserWidgetMetro();
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
            this.mnuReport,
            this.mnuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrescriptionPayment,
            this.mnuPrescriptionEntry,
            this.mnuPrescriptionEdit,
            this.toolStripSeparator2,
            this.mnuOPDQueue,
            this.mnuTicketCollection,
            this.mnuClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuPrescriptionPayment
            // 
            this.mnuPrescriptionPayment.Name = "mnuPrescriptionPayment";
            this.mnuPrescriptionPayment.Size = new System.Drawing.Size(175, 22);
            this.mnuPrescriptionPayment.Text = "Prescription Payment";
            this.mnuPrescriptionPayment.Click += new System.EventHandler(this.mnuPrescriptionPayment_Click);
            // 
            // mnuPrescriptionEntry
            // 
            this.mnuPrescriptionEntry.Name = "mnuPrescriptionEntry";
            this.mnuPrescriptionEntry.Size = new System.Drawing.Size(175, 22);
            this.mnuPrescriptionEntry.Text = "Prescription Entry";
            this.mnuPrescriptionEntry.Click += new System.EventHandler(this.mnuPrescriptionEntry_Click);
            // 
            // mnuPrescriptionEdit
            // 
            this.mnuPrescriptionEdit.Name = "mnuPrescriptionEdit";
            this.mnuPrescriptionEdit.Size = new System.Drawing.Size(175, 22);
            this.mnuPrescriptionEdit.Text = "Prescription Edit";
            this.mnuPrescriptionEdit.Click += new System.EventHandler(this.mnuPrescriptionEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuOPDQueue
            // 
            this.mnuOPDQueue.Name = "mnuOPDQueue";
            this.mnuOPDQueue.Size = new System.Drawing.Size(175, 22);
            this.mnuOPDQueue.Text = "OPD Queue";
            this.mnuOPDQueue.Click += new System.EventHandler(this.mnuOPDQueue_Click);
            // 
            // mnuTicketCollection
            // 
            this.mnuTicketCollection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCollectedTickets,
            this.mnuTicketRefundCancel,
            this.mnuCollectionSendToAccounts});
            this.mnuTicketCollection.Name = "mnuTicketCollection";
            this.mnuTicketCollection.Size = new System.Drawing.Size(175, 22);
            this.mnuTicketCollection.Text = "Ticket Collection";
            // 
            // mnuCollectedTickets
            // 
            this.mnuCollectedTickets.Name = "mnuCollectedTickets";
            this.mnuCollectedTickets.Size = new System.Drawing.Size(209, 22);
            this.mnuCollectedTickets.Text = "Collected Tickets";
            this.mnuCollectedTickets.Click += new System.EventHandler(this.mnuCollectedTickets_Click);
            // 
            // mnuTicketRefundCancel
            // 
            this.mnuTicketRefundCancel.Name = "mnuTicketRefundCancel";
            this.mnuTicketRefundCancel.Size = new System.Drawing.Size(209, 22);
            this.mnuTicketRefundCancel.Text = "Ticket Refund/Cancel";
            this.mnuTicketRefundCancel.Click += new System.EventHandler(this.mnuTicketRefundCancel_Click);
            // 
            // mnuCollectionSendToAccounts
            // 
            this.mnuCollectionSendToAccounts.Name = "mnuCollectionSendToAccounts";
            this.mnuCollectionSendToAccounts.Size = new System.Drawing.Size(209, 22);
            this.mnuCollectionSendToAccounts.Text = "Collection Send To Accounts";
            this.mnuCollectionSendToAccounts.Click += new System.EventHandler(this.mnuCollectionSendToAccounts_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(175, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMedicalSetup,
            this.toolStripSeparator1,
            this.mnuRoomSetup,
            this.toolStripSeparator3,
            this.mnuOPDDoctor,
            this.toolStripSeparator4});
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(47, 20);
            this.mnuSetup.Text = "Setup";
            // 
            // mnuMedicalSetup
            // 
            this.mnuMedicalSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDiseaseCaseSetup,
            this.mnuClinicalDiagnosis,
            this.mnuComplaintsSetup,
            this.mnuOPDAdvice,
            this.toolStripSeparator5,
            this.mnuClinicalFindingsGroupSetup,
            this.mnuClinicalFindingsSetup,
            this.mnuClinicalFindingsValueSetup,
            this.mnuClinicalFindingsValueAssign,
            this.toolStripSeparator6});
            this.mnuMedicalSetup.Name = "mnuMedicalSetup";
            this.mnuMedicalSetup.Size = new System.Drawing.Size(161, 22);
            this.mnuMedicalSetup.Text = "Medical Setup";
            // 
            // mnuDiseaseCaseSetup
            // 
            this.mnuDiseaseCaseSetup.Name = "mnuDiseaseCaseSetup";
            this.mnuDiseaseCaseSetup.Size = new System.Drawing.Size(211, 22);
            this.mnuDiseaseCaseSetup.Text = "Disease Case Setup";
            this.mnuDiseaseCaseSetup.Click += new System.EventHandler(this.mnuDiseaseCaseSetup_Click);
            // 
            // mnuClinicalDiagnosis
            // 
            this.mnuClinicalDiagnosis.Name = "mnuClinicalDiagnosis";
            this.mnuClinicalDiagnosis.Size = new System.Drawing.Size(211, 22);
            this.mnuClinicalDiagnosis.Text = "Clinical Diagnosis Setup";
            this.mnuClinicalDiagnosis.Click += new System.EventHandler(this.mnuClinicalDiagnosis_Click);
            // 
            // mnuComplaintsSetup
            // 
            this.mnuComplaintsSetup.Name = "mnuComplaintsSetup";
            this.mnuComplaintsSetup.Size = new System.Drawing.Size(211, 22);
            this.mnuComplaintsSetup.Text = "Complaints Setup";
            this.mnuComplaintsSetup.Click += new System.EventHandler(this.mnuComplaintsSetup_Click);
            // 
            // mnuOPDAdvice
            // 
            this.mnuOPDAdvice.Name = "mnuOPDAdvice";
            this.mnuOPDAdvice.Size = new System.Drawing.Size(211, 22);
            this.mnuOPDAdvice.Text = "OPD Advice Setup";
            this.mnuOPDAdvice.Click += new System.EventHandler(this.mnuOPDAdvice_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(208, 6);
            // 
            // mnuClinicalFindingsGroupSetup
            // 
            this.mnuClinicalFindingsGroupSetup.Name = "mnuClinicalFindingsGroupSetup";
            this.mnuClinicalFindingsGroupSetup.Size = new System.Drawing.Size(211, 22);
            this.mnuClinicalFindingsGroupSetup.Text = "Clinical Findings Group Setup";
            this.mnuClinicalFindingsGroupSetup.Click += new System.EventHandler(this.mnuClinicalFindingsGroupSetup_Click);
            // 
            // mnuClinicalFindingsSetup
            // 
            this.mnuClinicalFindingsSetup.Name = "mnuClinicalFindingsSetup";
            this.mnuClinicalFindingsSetup.Size = new System.Drawing.Size(211, 22);
            this.mnuClinicalFindingsSetup.Text = "Clinical Findings Setup";
            this.mnuClinicalFindingsSetup.Click += new System.EventHandler(this.mnuClinicalFindingsSetup_Click);
            // 
            // mnuClinicalFindingsValueSetup
            // 
            this.mnuClinicalFindingsValueSetup.Name = "mnuClinicalFindingsValueSetup";
            this.mnuClinicalFindingsValueSetup.Size = new System.Drawing.Size(211, 22);
            this.mnuClinicalFindingsValueSetup.Text = "Clinical Findings Value Setup";
            this.mnuClinicalFindingsValueSetup.Click += new System.EventHandler(this.mnuClinicalFindingsValueSetup_Click);
            // 
            // mnuClinicalFindingsValueAssign
            // 
            this.mnuClinicalFindingsValueAssign.Name = "mnuClinicalFindingsValueAssign";
            this.mnuClinicalFindingsValueAssign.Size = new System.Drawing.Size(211, 22);
            this.mnuClinicalFindingsValueAssign.Text = "Clinical Findings Value Assign";
            this.mnuClinicalFindingsValueAssign.Click += new System.EventHandler(this.mnuClinicalFindingsValueAssign_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(208, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuRoomSetup
            // 
            this.mnuRoomSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNurseRoomAllocation,
            this.mnuRoomGroupAssign});
            this.mnuRoomSetup.Name = "mnuRoomSetup";
            this.mnuRoomSetup.Size = new System.Drawing.Size(161, 22);
            this.mnuRoomSetup.Text = "Room Setup";
            // 
            // mnuNurseRoomAllocation
            // 
            this.mnuNurseRoomAllocation.Name = "mnuNurseRoomAllocation";
            this.mnuNurseRoomAllocation.Size = new System.Drawing.Size(181, 22);
            this.mnuNurseRoomAllocation.Text = "Nurse Room Allocaiton";
            this.mnuNurseRoomAllocation.Visible = false;
            // 
            // mnuRoomGroupAssign
            // 
            this.mnuRoomGroupAssign.Name = "mnuRoomGroupAssign";
            this.mnuRoomGroupAssign.Size = new System.Drawing.Size(181, 22);
            this.mnuRoomGroupAssign.Text = "Room Group Assign";
            this.mnuRoomGroupAssign.Click += new System.EventHandler(this.mnuRoomGroupAssign_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuOPDDoctor
            // 
            this.mnuOPDDoctor.Name = "mnuOPDDoctor";
            this.mnuOPDDoctor.Size = new System.Drawing.Size(161, 22);
            this.mnuOPDDoctor.Text = "OPD Doctor Setup";
            this.mnuOPDDoctor.Click += new System.EventHandler(this.mnuOPDDoctor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
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
            this.imageList1.Images.SetKeyName(0, "text_enriched.png");
            this.imageList1.Images.SetKeyName(1, "Prescription_Payment.png");
            this.imageList1.Images.SetKeyName(2, "gnome_logout.png");
            this.imageList1.Images.SetKeyName(3, "text_enriched.png");
            this.imageList1.Images.SetKeyName(4, "text.png");
            this.imageList1.Images.SetKeyName(5, "waiting.png");
            this.imageList1.Images.SetKeyName(6, "opdQueue.png");
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatientRegistration.Controls.Add(this.btnOPDQueue);
            this.pnlPatientRegistration.Controls.Add(this.btnClose);
            this.pnlPatientRegistration.Controls.Add(this.button8);
            this.pnlPatientRegistration.Controls.Add(this.btnPrescriptionEntry);
            this.pnlPatientRegistration.Controls.Add(this.btnReportManager);
            this.pnlPatientRegistration.Controls.Add(this.btnOPDTIcketModule);
            this.pnlPatientRegistration.ForeColor = System.Drawing.Color.Transparent;
            this.pnlPatientRegistration.Location = new System.Drawing.Point(146, 181);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(751, 465);
            this.pnlPatientRegistration.TabIndex = 1;
            // 
            // btnOPDQueue
            // 
            this.btnOPDQueue.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOPDQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOPDQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOPDQueue.FlatAppearance.BorderSize = 0;
            this.btnOPDQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOPDQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPDQueue.ForeColor = System.Drawing.Color.Snow;
            this.btnOPDQueue.ImageIndex = 6;
            this.btnOPDQueue.ImageList = this.imageList1;
            this.btnOPDQueue.Location = new System.Drawing.Point(4, 103);
            this.btnOPDQueue.Name = "btnOPDQueue";
            this.btnOPDQueue.Size = new System.Drawing.Size(247, 102);
            this.btnOPDQueue.TabIndex = 38;
            this.btnOPDQueue.Text = "OPD Queue";
            this.btnOPDQueue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOPDQueue.UseVisualStyleBackColor = false;
            this.btnOPDQueue.Click += new System.EventHandler(this.btnOPDQueue_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.MistyRose;
            this.btnClose.ImageIndex = 2;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(251, 103);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(247, 102);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close Module";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Khaki;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(322, 331);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 102);
            this.button8.TabIndex = 36;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // btnPrescriptionEntry
            // 
            this.btnPrescriptionEntry.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPrescriptionEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrescriptionEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrescriptionEntry.FlatAppearance.BorderSize = 0;
            this.btnPrescriptionEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrescriptionEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescriptionEntry.ForeColor = System.Drawing.Color.Chocolate;
            this.btnPrescriptionEntry.ImageIndex = 4;
            this.btnPrescriptionEntry.ImageList = this.imageList1;
            this.btnPrescriptionEntry.Location = new System.Drawing.Point(251, 1);
            this.btnPrescriptionEntry.Name = "btnPrescriptionEntry";
            this.btnPrescriptionEntry.Size = new System.Drawing.Size(247, 102);
            this.btnPrescriptionEntry.TabIndex = 30;
            this.btnPrescriptionEntry.Text = "Prescription Entry";
            this.btnPrescriptionEntry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrescriptionEntry.UseVisualStyleBackColor = false;
            this.btnPrescriptionEntry.Click += new System.EventHandler(this.btnPatientRegRptManager_Click);
            // 
            // btnReportManager
            // 
            this.btnReportManager.BackColor = System.Drawing.Color.Coral;
            this.btnReportManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReportManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportManager.FlatAppearance.BorderSize = 0;
            this.btnReportManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportManager.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnReportManager.ImageIndex = 3;
            this.btnReportManager.ImageList = this.imageList1;
            this.btnReportManager.Location = new System.Drawing.Point(498, 1);
            this.btnReportManager.Name = "btnReportManager";
            this.btnReportManager.Size = new System.Drawing.Size(247, 102);
            this.btnReportManager.TabIndex = 29;
            this.btnReportManager.Text = "Report Manager";
            this.btnReportManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportManager.UseVisualStyleBackColor = false;
            this.btnReportManager.Click += new System.EventHandler(this.btnReportManager_Click);
            // 
            // btnOPDTIcketModule
            // 
            this.btnOPDTIcketModule.BackColor = System.Drawing.Color.Purple;
            this.btnOPDTIcketModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOPDTIcketModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOPDTIcketModule.FlatAppearance.BorderSize = 0;
            this.btnOPDTIcketModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOPDTIcketModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPDTIcketModule.ForeColor = System.Drawing.Color.Snow;
            this.btnOPDTIcketModule.ImageIndex = 1;
            this.btnOPDTIcketModule.ImageList = this.imageList1;
            this.btnOPDTIcketModule.Location = new System.Drawing.Point(4, 1);
            this.btnOPDTIcketModule.Name = "btnOPDTIcketModule";
            this.btnOPDTIcketModule.Size = new System.Drawing.Size(247, 102);
            this.btnOPDTIcketModule.TabIndex = 28;
            this.btnOPDTIcketModule.Text = "Prescription Payment";
            this.btnOPDTIcketModule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOPDTIcketModule.UseVisualStyleBackColor = false;
            this.btnOPDTIcketModule.Click += new System.EventHandler(this.btnOPDTIcketModule_Click);
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.BackColor = System.Drawing.Color.Transparent;
            this.lblModuleName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModuleName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.ForeColor = System.Drawing.Color.White;
            this.lblModuleName.Location = new System.Drawing.Point(185, 9);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(472, 33);
            this.lblModuleName.TabIndex = 36;
            this.lblModuleName.Text = "Out Patient Management System";
            // 
            // pnlModuleName
            // 
            this.pnlModuleName.BackColor = System.Drawing.Color.Transparent;
            this.pnlModuleName.Controls.Add(this.lblModuleName);
            this.pnlModuleName.Location = new System.Drawing.Point(146, 126);
            this.pnlModuleName.Name = "pnlModuleName";
            this.pnlModuleName.Size = new System.Drawing.Size(751, 54);
            this.pnlModuleName.TabIndex = 40;
            // 
            // dateWidget1
            // 
            this.dateWidget1.BackColor = System.Drawing.Color.Transparent;
            this.dateWidget1.Location = new System.Drawing.Point(757, 652);
            this.dateWidget1.Name = "dateWidget1";
            this.dateWidget1.Size = new System.Drawing.Size(358, 109);
            this.dateWidget1.TabIndex = 43;
            // 
            // userWidget1
            // 
            this.userWidget1.Location = new System.Drawing.Point(757, 24);
            this.userWidget1.Name = "userWidget1";
            this.userWidget1.Size = new System.Drawing.Size(358, 120);
            this.userWidget1.TabIndex = 42;
            this.userWidget1.btnLogout_Clicked += new AtiqsControlLibrary.UserWidgetMetro.LogoutButtonClickHandler(this.userWidget1_btnLogout_Clicked);
            // 
            // frmOPDMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1115, 758);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.pnlPatientRegistration);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userWidget1);
            this.Controls.Add(this.pnlModuleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOPDMain";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOPDMain_Load);
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.Button btnOPDTIcketModule;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnPrescriptionEntry;
        private System.Windows.Forms.Button btnReportManager;
        private System.Windows.Forms.ToolStripMenuItem mnuPrescriptionPayment;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuPrescriptionEntry;
        private System.Windows.Forms.Button btnOPDQueue;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuReportManager;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Panel pnlModuleName;
        private AtiqsControlLibrary.UserWidgetMetro userWidget1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuTicketCollection;
        private System.Windows.Forms.ToolStripMenuItem mnuMedicalSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuRoomSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuCollectedTickets;
        private System.Windows.Forms.ToolStripMenuItem mnuTicketRefundCancel;
        private System.Windows.Forms.ToolStripMenuItem mnuCollectionSendToAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnuDiseaseCaseSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuComplaintsSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuClinicalDiagnosis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuOPDDoctor;
        private System.Windows.Forms.ToolStripMenuItem mnuOPDAdvice;
        private System.Windows.Forms.ToolStripMenuItem mnuNurseRoomAllocation;
        private System.Windows.Forms.ToolStripMenuItem mnuRoomGroupAssign;
        private System.Windows.Forms.ToolStripMenuItem mnuOPDQueue;
        private System.Windows.Forms.ToolStripMenuItem mnuClinicalFindingsGroupSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuClinicalFindingsSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuClinicalFindingsValueSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuClinicalFindingsValueAssign;
        private System.Windows.Forms.ToolStripMenuItem mnuPrescriptionEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDemandRequisition;
    }
}