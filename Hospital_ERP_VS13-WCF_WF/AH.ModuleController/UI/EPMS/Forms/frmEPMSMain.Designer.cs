namespace AH.ModuleController.UI.EPMS.Forms
{
    partial class frmEPMSMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEPMSMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmerRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEmergencyBilling = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEmerCollPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmerCollHead = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmergencyReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator31 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLeaveRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator33 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLeaveRequisition = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnEmergencyDiagnosticColl = new System.Windows.Forms.Button();
            this.btnDuePayment = new System.Windows.Forms.Button();
            this.btnEmergencyCollectionPayment = new System.Windows.Forms.Button();
            this.btnEmergencyPatientRegister = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReportManager = new System.Windows.Forms.Button();
            this.btnEmergencyMR = new System.Windows.Forms.Button();
            this.userWidgetMetro1 = new AtiqsControlLibrary.UserWidgetMetro();
            this.dateWidget1 = new AtiqsControlLibrary.DateWidget();
            this.pnlModuleName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmerRegister,
            this.toolStripSeparator2,
            this.mnuEmergencyBilling,
            this.toolStripSeparator1,
            this.mnuEmerCollPayment});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuEmerRegister
            // 
            this.mnuEmerRegister.Name = "mnuEmerRegister";
            this.mnuEmerRegister.Size = new System.Drawing.Size(221, 22);
            this.mnuEmerRegister.Text = "Emergency Patient Register";
            this.mnuEmerRegister.Visible = false;
            this.mnuEmerRegister.Click += new System.EventHandler(this.mnuEmerRegister_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // mnuEmergencyBilling
            // 
            this.mnuEmergencyBilling.Name = "mnuEmergencyBilling";
            this.mnuEmergencyBilling.Size = new System.Drawing.Size(221, 22);
            this.mnuEmergencyBilling.Text = "Emergency Procedure Entry";
            this.mnuEmergencyBilling.Click += new System.EventHandler(this.mnuEmergencyBilling_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // mnuEmerCollPayment
            // 
            this.mnuEmerCollPayment.Name = "mnuEmerCollPayment";
            this.mnuEmerCollPayment.Size = new System.Drawing.Size(221, 22);
            this.mnuEmerCollPayment.Text = "Emergency Collection Payment";
            this.mnuEmerCollPayment.Click += new System.EventHandler(this.mnuEmerCollPayment_Click);
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmerCollHead});
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(47, 20);
            this.mnuSetup.Text = "Setup";
            // 
            // mnuEmerCollHead
            // 
            this.mnuEmerCollHead.Name = "mnuEmerCollHead";
            this.mnuEmerCollHead.Size = new System.Drawing.Size(235, 22);
            this.mnuEmerCollHead.Text = "Emergency Collection Head Setup";
            this.mnuEmerCollHead.Click += new System.EventHandler(this.mnuEmerCollHead_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmergencyReport});
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(52, 20);
            this.mnuReport.Text = "Report";
            // 
            // mnuEmergencyReport
            // 
            this.mnuEmergencyReport.Name = "mnuEmergencyReport";
            this.mnuEmergencyReport.Size = new System.Drawing.Size(168, 22);
            this.mnuEmergencyReport.Text = "Emergency Reports";
            this.mnuEmergencyReport.Click += new System.EventHandler(this.mnuEmergencyReport_Click);
            // 
            // mnuUtility
            // 
            this.mnuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangePassword,
            this.toolStripSeparator31,
            this.mnuLeave});
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
            // toolStripSeparator31
            // 
            this.toolStripSeparator31.Name = "toolStripSeparator31";
            this.toolStripSeparator31.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuLeave
            // 
            this.mnuLeave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLeaveRegister,
            this.toolStripSeparator33,
            this.mnuLeaveRequisition});
            this.mnuLeave.Name = "mnuLeave";
            this.mnuLeave.Size = new System.Drawing.Size(160, 22);
            this.mnuLeave.Text = "Leave";
            // 
            // mnuLeaveRegister
            // 
            this.mnuLeaveRegister.Name = "mnuLeaveRegister";
            this.mnuLeaveRegister.Size = new System.Drawing.Size(229, 22);
            this.mnuLeaveRegister.Text = "Employee Leave Register";
            this.mnuLeaveRegister.Click += new System.EventHandler(this.mnuLeaveRegister_Click);
            // 
            // toolStripSeparator33
            // 
            this.toolStripSeparator33.Name = "toolStripSeparator33";
            this.toolStripSeparator33.Size = new System.Drawing.Size(226, 6);
            // 
            // mnuLeaveRequisition
            // 
            this.mnuLeaveRequisition.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLeaveRequisition.Name = "mnuLeaveRequisition";
            this.mnuLeaveRequisition.Size = new System.Drawing.Size(229, 22);
            this.mnuLeaveRequisition.Text = "Employee Leave Requsition";
            this.mnuLeaveRequisition.Click += new System.EventHandler(this.mnuLeaveRequisition_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gnome_logout.png");
            this.imageList1.Images.SetKeyName(1, "accessories_text_editor.png");
            this.imageList1.Images.SetKeyName(2, "document.png");
            this.imageList1.Images.SetKeyName(3, "documents.png");
            this.imageList1.Images.SetKeyName(4, "file_doc.png");
            this.imageList1.Images.SetKeyName(5, "notepad.png");
            this.imageList1.Images.SetKeyName(6, "receipt.png");
            this.imageList1.Images.SetKeyName(7, "text_x_changelog.png");
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatientRegistration.Controls.Add(this.btnEmergencyDiagnosticColl);
            this.pnlPatientRegistration.Controls.Add(this.btnDuePayment);
            this.pnlPatientRegistration.Controls.Add(this.btnEmergencyCollectionPayment);
            this.pnlPatientRegistration.Controls.Add(this.btnEmergencyPatientRegister);
            this.pnlPatientRegistration.Controls.Add(this.btnClose);
            this.pnlPatientRegistration.Controls.Add(this.btnReportManager);
            this.pnlPatientRegistration.Controls.Add(this.btnEmergencyMR);
            this.pnlPatientRegistration.Location = new System.Drawing.Point(94, 181);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(744, 465);
            this.pnlPatientRegistration.TabIndex = 1;
            // 
            // btnEmergencyDiagnosticColl
            // 
            this.btnEmergencyDiagnosticColl.BackColor = System.Drawing.Color.Green;
            this.btnEmergencyDiagnosticColl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmergencyDiagnosticColl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmergencyDiagnosticColl.FlatAppearance.BorderSize = 0;
            this.btnEmergencyDiagnosticColl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergencyDiagnosticColl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencyDiagnosticColl.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEmergencyDiagnosticColl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmergencyDiagnosticColl.ImageIndex = 6;
            this.btnEmergencyDiagnosticColl.ImageList = this.imageList1;
            this.btnEmergencyDiagnosticColl.Location = new System.Drawing.Point(250, 360);
            this.btnEmergencyDiagnosticColl.Name = "btnEmergencyDiagnosticColl";
            this.btnEmergencyDiagnosticColl.Size = new System.Drawing.Size(247, 102);
            this.btnEmergencyDiagnosticColl.TabIndex = 42;
            this.btnEmergencyDiagnosticColl.Text = "Emergency Diagnostic Collection";
            this.btnEmergencyDiagnosticColl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmergencyDiagnosticColl.UseVisualStyleBackColor = false;
            this.btnEmergencyDiagnosticColl.Visible = false;
            this.btnEmergencyDiagnosticColl.Click += new System.EventHandler(this.btnEmergencyDiagnosticColl_Click);
            // 
            // btnDuePayment
            // 
            this.btnDuePayment.BackColor = System.Drawing.Color.Purple;
            this.btnDuePayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDuePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuePayment.FlatAppearance.BorderSize = 0;
            this.btnDuePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuePayment.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDuePayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuePayment.ImageIndex = 6;
            this.btnDuePayment.ImageList = this.imageList1;
            this.btnDuePayment.Location = new System.Drawing.Point(497, 360);
            this.btnDuePayment.Name = "btnDuePayment";
            this.btnDuePayment.Size = new System.Drawing.Size(247, 102);
            this.btnDuePayment.TabIndex = 41;
            this.btnDuePayment.Text = "Due Payment";
            this.btnDuePayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDuePayment.UseVisualStyleBackColor = false;
            this.btnDuePayment.Visible = false;
            // 
            // btnEmergencyCollectionPayment
            // 
            this.btnEmergencyCollectionPayment.BackColor = System.Drawing.Color.Green;
            this.btnEmergencyCollectionPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmergencyCollectionPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmergencyCollectionPayment.FlatAppearance.BorderSize = 0;
            this.btnEmergencyCollectionPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergencyCollectionPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencyCollectionPayment.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEmergencyCollectionPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmergencyCollectionPayment.ImageIndex = 6;
            this.btnEmergencyCollectionPayment.ImageList = this.imageList1;
            this.btnEmergencyCollectionPayment.Location = new System.Drawing.Point(246, 0);
            this.btnEmergencyCollectionPayment.Name = "btnEmergencyCollectionPayment";
            this.btnEmergencyCollectionPayment.Size = new System.Drawing.Size(247, 102);
            this.btnEmergencyCollectionPayment.TabIndex = 40;
            this.btnEmergencyCollectionPayment.Text = "Specimen Collection";
            this.btnEmergencyCollectionPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmergencyCollectionPayment.UseVisualStyleBackColor = false;
            this.btnEmergencyCollectionPayment.Click += new System.EventHandler(this.btnEmergencyCollectionPayment_Click);
            // 
            // btnEmergencyPatientRegister
            // 
            this.btnEmergencyPatientRegister.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEmergencyPatientRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmergencyPatientRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmergencyPatientRegister.FlatAppearance.BorderSize = 0;
            this.btnEmergencyPatientRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergencyPatientRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencyPatientRegister.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEmergencyPatientRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmergencyPatientRegister.ImageIndex = 6;
            this.btnEmergencyPatientRegister.ImageList = this.imageList1;
            this.btnEmergencyPatientRegister.Location = new System.Drawing.Point(3, 360);
            this.btnEmergencyPatientRegister.Name = "btnEmergencyPatientRegister";
            this.btnEmergencyPatientRegister.Size = new System.Drawing.Size(247, 102);
            this.btnEmergencyPatientRegister.TabIndex = 39;
            this.btnEmergencyPatientRegister.Text = "Emergency Patient Register";
            this.btnEmergencyPatientRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmergencyPatientRegister.UseVisualStyleBackColor = false;
            this.btnEmergencyPatientRegister.Visible = false;
            this.btnEmergencyPatientRegister.Click += new System.EventHandler(this.btnEmergencyPatientRegister_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Brown;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkGray;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.ImageIndex = 0;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(494, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(248, 102);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close Module";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReportManager
            // 
            this.btnReportManager.BackColor = System.Drawing.Color.Purple;
            this.btnReportManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReportManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportManager.FlatAppearance.BorderSize = 0;
            this.btnReportManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportManager.ForeColor = System.Drawing.Color.DarkGray;
            this.btnReportManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportManager.ImageKey = "text_x_changelog.png";
            this.btnReportManager.ImageList = this.imageList1;
            this.btnReportManager.Location = new System.Drawing.Point(494, 1);
            this.btnReportManager.Name = "btnReportManager";
            this.btnReportManager.Size = new System.Drawing.Size(247, 102);
            this.btnReportManager.TabIndex = 31;
            this.btnReportManager.Text = "Report Manager";
            this.btnReportManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportManager.UseVisualStyleBackColor = false;
            this.btnReportManager.Click += new System.EventHandler(this.btnReportManager_Click);
            // 
            // btnEmergencyMR
            // 
            this.btnEmergencyMR.BackColor = System.Drawing.Color.Sienna;
            this.btnEmergencyMR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmergencyMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmergencyMR.FlatAppearance.BorderSize = 0;
            this.btnEmergencyMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergencyMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencyMR.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEmergencyMR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmergencyMR.ImageIndex = 6;
            this.btnEmergencyMR.ImageList = this.imageList1;
            this.btnEmergencyMR.Location = new System.Drawing.Point(1, 1);
            this.btnEmergencyMR.Name = "btnEmergencyMR";
            this.btnEmergencyMR.Size = new System.Drawing.Size(247, 102);
            this.btnEmergencyMR.TabIndex = 30;
            this.btnEmergencyMR.Text = "Emergency Procedure Entry";
            this.btnEmergencyMR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmergencyMR.UseVisualStyleBackColor = false;
            this.btnEmergencyMR.Click += new System.EventHandler(this.btnEmergencyMR_Click);
            // 
            // userWidgetMetro1
            // 
            this.userWidgetMetro1.Location = new System.Drawing.Point(872, 27);
            this.userWidgetMetro1.Name = "userWidgetMetro1";
            this.userWidgetMetro1.Size = new System.Drawing.Size(364, 122);
            this.userWidgetMetro1.TabIndex = 37;
            this.userWidgetMetro1.btnLogout_Clicked += new AtiqsControlLibrary.UserWidgetMetro.LogoutButtonClickHandler(this.userWidgetMetro1_btnLogout_Clicked);
            // 
            // dateWidget1
            // 
            this.dateWidget1.BackColor = System.Drawing.Color.Transparent;
            this.dateWidget1.Location = new System.Drawing.Point(862, 672);
            this.dateWidget1.Name = "dateWidget1";
            this.dateWidget1.Size = new System.Drawing.Size(374, 109);
            this.dateWidget1.TabIndex = 38;
            // 
            // pnlModuleName
            // 
            this.pnlModuleName.BackColor = System.Drawing.Color.Transparent;
            this.pnlModuleName.Controls.Add(this.label1);
            this.pnlModuleName.Location = new System.Drawing.Point(95, 125);
            this.pnlModuleName.Name = "pnlModuleName";
            this.pnlModuleName.Size = new System.Drawing.Size(743, 54);
            this.pnlModuleName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Emergency Patient Management System";
            // 
            // frmEPMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1238, 846);
            this.Controls.Add(this.pnlModuleName);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.pnlPatientRegistration);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userWidgetMetro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEPMSMain";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEPMSMain_Load);
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReportManager;
        private System.Windows.Forms.Button btnEmergencyMR;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuEmergencyReport;
        private System.Windows.Forms.ToolStripMenuItem mnuUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private AtiqsControlLibrary.UserWidgetMetro userWidgetMetro1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.Panel pnlModuleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuLeave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator31;
        private System.Windows.Forms.ToolStripMenuItem mnuLeaveRequisition;
        private System.Windows.Forms.ToolStripMenuItem mnuLeaveRegister;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator33;
        private System.Windows.Forms.Button btnEmergencyPatientRegister;
        private System.Windows.Forms.Button btnEmergencyCollectionPayment;
        private System.Windows.Forms.Button btnDuePayment;
        private System.Windows.Forms.ToolStripMenuItem mnuEmerCollHead;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEmergencyBilling;
        private System.Windows.Forms.ToolStripMenuItem mnuEmerRegister;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnEmergencyDiagnosticColl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuEmerCollPayment;
    }
}