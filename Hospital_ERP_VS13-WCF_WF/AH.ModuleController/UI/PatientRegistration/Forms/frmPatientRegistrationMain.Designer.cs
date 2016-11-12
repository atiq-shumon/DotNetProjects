namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    partial class frmPatientRegistrationMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientRegistrationMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewPatientRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatientSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseModule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStaffTypeSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCorporateTypeSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnCloseModule = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnPatientRegRptManager = new System.Windows.Forms.Button();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.btnPatientRegistration = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewPatientRegistration,
            this.mnuPatientSearch,
            this.mnuCloseModule});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNewPatientRegistration
            // 
            this.mnuNewPatientRegistration.Name = "mnuNewPatientRegistration";
            this.mnuNewPatientRegistration.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNewPatientRegistration.Size = new System.Drawing.Size(232, 22);
            this.mnuNewPatientRegistration.Text = "New Patient Registration";
            this.mnuNewPatientRegistration.Click += new System.EventHandler(this.mnuNewPatientRegistration_Click);
            // 
            // mnuPatientSearch
            // 
            this.mnuPatientSearch.Name = "mnuPatientSearch";
            this.mnuPatientSearch.Size = new System.Drawing.Size(232, 22);
            this.mnuPatientSearch.Text = "Patient Search";
            this.mnuPatientSearch.Click += new System.EventHandler(this.mnuPatientSearch_Click);
            // 
            // mnuCloseModule
            // 
            this.mnuCloseModule.Name = "mnuCloseModule";
            this.mnuCloseModule.Size = new System.Drawing.Size(232, 22);
            this.mnuCloseModule.Text = "Close Module";
            this.mnuCloseModule.Click += new System.EventHandler(this.mnuCloseModule_Click);
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStaffTypeSetup,
            this.mnuCorporateTypeSetup});
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(47, 20);
            this.mnuSetup.Text = "Setup";
            // 
            // mnuStaffTypeSetup
            // 
            this.mnuStaffTypeSetup.Name = "mnuStaffTypeSetup";
            this.mnuStaffTypeSetup.Size = new System.Drawing.Size(181, 22);
            this.mnuStaffTypeSetup.Text = "Staff Type Setup";
            this.mnuStaffTypeSetup.Click += new System.EventHandler(this.mnuStaffTypeSetup_Click);
            // 
            // mnuCorporateTypeSetup
            // 
            this.mnuCorporateTypeSetup.Name = "mnuCorporateTypeSetup";
            this.mnuCorporateTypeSetup.Size = new System.Drawing.Size(181, 22);
            this.mnuCorporateTypeSetup.Text = "Corporate Type Setup";
            this.mnuCorporateTypeSetup.Click += new System.EventHandler(this.mnuCorporateTypeSetup_Click);
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
            this.imageList1.Images.SetKeyName(1, "opd.jpg");
            this.imageList1.Images.SetKeyName(2, "the_documents_icon.png");
            this.imageList1.Images.SetKeyName(3, "Patient Search.png");
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatientRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPatientRegistration.Controls.Add(this.btnCloseModule);
            this.pnlPatientRegistration.Controls.Add(this.button8);
            this.pnlPatientRegistration.Controls.Add(this.button7);
            this.pnlPatientRegistration.Controls.Add(this.btnPatientRegRptManager);
            this.pnlPatientRegistration.Controls.Add(this.btnPatientSearch);
            this.pnlPatientRegistration.Controls.Add(this.btnPatientRegistration);
            this.pnlPatientRegistration.Location = new System.Drawing.Point(54, 181);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(769, 401);
            this.pnlPatientRegistration.TabIndex = 1;
            // 
            // btnCloseModule
            // 
            this.btnCloseModule.BackColor = System.Drawing.Color.Tomato;
            this.btnCloseModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseModule.FlatAppearance.BorderSize = 0;
            this.btnCloseModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseModule.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseModule.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCloseModule.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseModule.ImageKey = "gnome_logout.png";
            this.btnCloseModule.ImageList = this.imageList1;
            this.btnCloseModule.Location = new System.Drawing.Point(14, 125);
            this.btnCloseModule.Name = "btnCloseModule";
            this.btnCloseModule.Size = new System.Drawing.Size(247, 102);
            this.btnCloseModule.TabIndex = 37;
            this.btnCloseModule.Text = "Close Module";
            this.btnCloseModule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseModule.UseVisualStyleBackColor = false;
            this.btnCloseModule.Click += new System.EventHandler(this.btnCloseModule_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DarkGray;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(326, 238);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 102);
            this.button8.TabIndex = 36;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkGray;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(394, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 102);
            this.button7.TabIndex = 35;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            // 
            // btnPatientRegRptManager
            // 
            this.btnPatientRegRptManager.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPatientRegRptManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPatientRegRptManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientRegRptManager.FlatAppearance.BorderSize = 0;
            this.btnPatientRegRptManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientRegRptManager.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRegRptManager.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPatientRegRptManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatientRegRptManager.ImageKey = "the_documents_icon.png";
            this.btnPatientRegRptManager.ImageList = this.imageList1;
            this.btnPatientRegRptManager.Location = new System.Drawing.Point(261, 23);
            this.btnPatientRegRptManager.Name = "btnPatientRegRptManager";
            this.btnPatientRegRptManager.Size = new System.Drawing.Size(247, 102);
            this.btnPatientRegRptManager.TabIndex = 30;
            this.btnPatientRegRptManager.Text = "Report Manager";
            this.btnPatientRegRptManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatientRegRptManager.UseVisualStyleBackColor = false;
            this.btnPatientRegRptManager.Click += new System.EventHandler(this.btnPatientRegRptManager_Click);
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnPatientSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientSearch.FlatAppearance.BorderSize = 0;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatientSearch.ImageKey = "Patient Search.png";
            this.btnPatientSearch.ImageList = this.imageList1;
            this.btnPatientSearch.Location = new System.Drawing.Point(508, 23);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(247, 102);
            this.btnPatientSearch.TabIndex = 29;
            this.btnPatientSearch.Text = "Patient Search";
            this.btnPatientSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // btnPatientRegistration
            // 
            this.btnPatientRegistration.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPatientRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPatientRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientRegistration.FlatAppearance.BorderSize = 0;
            this.btnPatientRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientRegistration.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRegistration.ForeColor = System.Drawing.Color.White;
            this.btnPatientRegistration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatientRegistration.ImageKey = "opd.jpg";
            this.btnPatientRegistration.ImageList = this.imageList1;
            this.btnPatientRegistration.Location = new System.Drawing.Point(14, 23);
            this.btnPatientRegistration.Name = "btnPatientRegistration";
            this.btnPatientRegistration.Size = new System.Drawing.Size(247, 102);
            this.btnPatientRegistration.TabIndex = 28;
            this.btnPatientRegistration.Text = "New Registration";
            this.btnPatientRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatientRegistration.UseVisualStyleBackColor = false;
            this.btnPatientRegistration.Click += new System.EventHandler(this.btnPatientRegistrationModule_Click);
            // 
            // userWidgetMetro1
            // 
            this.userWidgetMetro1.BackColor = System.Drawing.Color.Transparent;
            this.userWidgetMetro1.Location = new System.Drawing.Point(782, 27);
            this.userWidgetMetro1.Name = "userWidgetMetro1";
            this.userWidgetMetro1.Size = new System.Drawing.Size(364, 122);
            this.userWidgetMetro1.TabIndex = 2;
            this.userWidgetMetro1.btnLogout_Clicked += new AtiqsControlLibrary.UserWidgetMetro.LogoutButtonClickHandler(this.userWidgetMetro1_btnLogout_Clicked);
            // 
            // dateWidget1
            // 
            this.dateWidget1.BackColor = System.Drawing.Color.Transparent;
            this.dateWidget1.Location = new System.Drawing.Point(772, 551);
            this.dateWidget1.Name = "dateWidget1";
            this.dateWidget1.Size = new System.Drawing.Size(374, 109);
            this.dateWidget1.TabIndex = 3;
            // 
            // pnlModuleName
            // 
            this.pnlModuleName.BackColor = System.Drawing.Color.Transparent;
            this.pnlModuleName.Controls.Add(this.label1);
            this.pnlModuleName.Location = new System.Drawing.Point(54, 131);
            this.pnlModuleName.Name = "pnlModuleName";
            this.pnlModuleName.Size = new System.Drawing.Size(769, 54);
            this.pnlModuleName.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Patient Registration Management System";
            // 
            // frmPatientRegistrationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1146, 660);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.pnlPatientRegistration);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userWidgetMetro1);
            this.Controls.Add(this.pnlModuleName);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPatientRegistrationMain";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPatientRegistrationMain_Load);
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.Button btnPatientRegistration;
        private System.Windows.Forms.Button btnCloseModule;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnPatientRegRptManager;
        private System.Windows.Forms.Button btnPatientSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuNewPatientRegistration;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuReportManager;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseModule;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuPatientSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnuStaffTypeSetup;
        private AtiqsControlLibrary.UserWidgetMetro userWidgetMetro1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.Panel pnlModuleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuCorporateTypeSetup;
    }
}