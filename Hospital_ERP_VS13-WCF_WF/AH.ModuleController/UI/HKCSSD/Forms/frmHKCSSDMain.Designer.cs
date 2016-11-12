namespace AH.ModuleController.UI.HKCSSD.Forms
{
    partial class frmHKCSSDMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHKCSSDMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFnBSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.pnlModuleName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userWidgetMetro1 = new AtiqsControlLibrary.UserWidgetMetro();
            this.dateWidget1 = new AtiqsControlLibrary.DateWidget();
            this.btnSpecimenReceive = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPatientRegRptManager = new System.Windows.Forms.Button();
            this.btnSpecimenCollection = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlPatientRegistration.SuspendLayout();
            this.pnlModuleName.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuFnBSetup,
            this.mnuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // mnuFnBSetup
            // 
            this.mnuFnBSetup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFnBSetup.Name = "mnuFnBSetup";
            this.mnuFnBSetup.Size = new System.Drawing.Size(52, 20);
            this.mnuFnBSetup.Text = "Setup";
            this.mnuFnBSetup.Click += new System.EventHandler(this.mnuSpecimenSetup_Click);
            // 
            // mnuUtility
            // 
            this.mnuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResetPassword});
            this.mnuUtility.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUtility.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuUtility.Name = "mnuUtility";
            this.mnuUtility.Size = new System.Drawing.Size(53, 20);
            this.mnuUtility.Text = "Utility";
            // 
            // mnuResetPassword
            // 
            this.mnuResetPassword.Name = "mnuResetPassword";
            this.mnuResetPassword.Size = new System.Drawing.Size(164, 22);
            this.mnuResetPassword.Text = "Reset Password";
            this.mnuResetPassword.Click += new System.EventHandler(this.mnuResetPassword_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gnome_logout.png");
            this.imageList1.Images.SetKeyName(1, "laboratory.png");
            this.imageList1.Images.SetKeyName(2, "folder_labs.png");
            this.imageList1.Images.SetKeyName(3, "reports.png");
            this.imageList1.Images.SetKeyName(4, "textedit.png");
            this.imageList1.Images.SetKeyName(5, "DefineControls.png");
            this.imageList1.Images.SetKeyName(6, "croos.png");
            this.imageList1.Images.SetKeyName(7, "QualityControl.png");
            this.imageList1.Images.SetKeyName(8, "education32.png");
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatientRegistration.Controls.Add(this.btnSpecimenReceive);
            this.pnlPatientRegistration.Controls.Add(this.btnClose);
            this.pnlPatientRegistration.Controls.Add(this.btnPatientRegRptManager);
            this.pnlPatientRegistration.Controls.Add(this.btnSpecimenCollection);
            this.pnlPatientRegistration.Location = new System.Drawing.Point(133, 204);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(785, 491);
            this.pnlPatientRegistration.TabIndex = 1;
            // 
            // pnlModuleName
            // 
            this.pnlModuleName.BackColor = System.Drawing.Color.Transparent;
            this.pnlModuleName.Controls.Add(this.label1);
            this.pnlModuleName.Location = new System.Drawing.Point(133, 150);
            this.pnlModuleName.Name = "pnlModuleName";
            this.pnlModuleName.Size = new System.Drawing.Size(785, 54);
            this.pnlModuleName.TabIndex = 44;
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
            this.label1.Size = new System.Drawing.Size(632, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "HouseKeeping and CSSD Management System";
            // 
            // userWidgetMetro1
            // 
            this.userWidgetMetro1.BackColor = System.Drawing.Color.Transparent;
            this.userWidgetMetro1.Location = new System.Drawing.Point(951, 27);
            this.userWidgetMetro1.Name = "userWidgetMetro1";
            this.userWidgetMetro1.Size = new System.Drawing.Size(347, 122);
            this.userWidgetMetro1.TabIndex = 45;
            this.userWidgetMetro1.btnLogout_Clicked += new AtiqsControlLibrary.UserWidgetMetro.LogoutButtonClickHandler(this.userWidgetMetro1_btnLogout_Clicked);
            // 
            // dateWidget1
            // 
            this.dateWidget1.BackColor = System.Drawing.Color.Transparent;
            this.dateWidget1.Location = new System.Drawing.Point(924, 716);
            this.dateWidget1.Name = "dateWidget1";
            this.dateWidget1.Size = new System.Drawing.Size(374, 109);
            this.dateWidget1.TabIndex = 46;
            // 
            // btnSpecimenReceive
            // 
            this.btnSpecimenReceive.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSpecimenReceive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpecimenReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpecimenReceive.FlatAppearance.BorderSize = 0;
            this.btnSpecimenReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecimenReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecimenReceive.ForeColor = System.Drawing.Color.White;
            this.btnSpecimenReceive.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSpecimenReceive.ImageIndex = 5;
            this.btnSpecimenReceive.ImageList = this.imageList1;
            this.btnSpecimenReceive.Location = new System.Drawing.Point(269, 22);
            this.btnSpecimenReceive.Name = "btnSpecimenReceive";
            this.btnSpecimenReceive.Size = new System.Drawing.Size(247, 102);
            this.btnSpecimenReceive.TabIndex = 39;
            this.btnSpecimenReceive.Text = "Specimen Label Receive";
            this.btnSpecimenReceive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSpecimenReceive.UseVisualStyleBackColor = false;
            this.btnSpecimenReceive.Visible = false;
            this.btnSpecimenReceive.Click += new System.EventHandler(this.btnSpecimenReceive_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.ImageKey = "croos.png";
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(20, 130);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(247, 102);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close Module";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPatientRegRptManager
            // 
            this.btnPatientRegRptManager.BackColor = System.Drawing.Color.Tomato;
            this.btnPatientRegRptManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPatientRegRptManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientRegRptManager.FlatAppearance.BorderSize = 0;
            this.btnPatientRegRptManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientRegRptManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRegRptManager.ForeColor = System.Drawing.Color.White;
            this.btnPatientRegRptManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatientRegRptManager.ImageIndex = 8;
            this.btnPatientRegRptManager.ImageList = this.imageList1;
            this.btnPatientRegRptManager.Location = new System.Drawing.Point(519, 22);
            this.btnPatientRegRptManager.Name = "btnPatientRegRptManager";
            this.btnPatientRegRptManager.Size = new System.Drawing.Size(247, 102);
            this.btnPatientRegRptManager.TabIndex = 30;
            this.btnPatientRegRptManager.Text = "Diagnostic Result Entry";
            this.btnPatientRegRptManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatientRegRptManager.UseVisualStyleBackColor = false;
            this.btnPatientRegRptManager.Visible = false;
            this.btnPatientRegRptManager.Click += new System.EventHandler(this.btnPatientRegRptManager_Click);
            // 
            // btnSpecimenCollection
            // 
            this.btnSpecimenCollection.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSpecimenCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpecimenCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpecimenCollection.FlatAppearance.BorderSize = 0;
            this.btnSpecimenCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecimenCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecimenCollection.ForeColor = System.Drawing.Color.White;
            this.btnSpecimenCollection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSpecimenCollection.ImageIndex = 1;
            this.btnSpecimenCollection.ImageList = this.imageList1;
            this.btnSpecimenCollection.Location = new System.Drawing.Point(18, 22);
            this.btnSpecimenCollection.Name = "btnSpecimenCollection";
            this.btnSpecimenCollection.Size = new System.Drawing.Size(247, 102);
            this.btnSpecimenCollection.TabIndex = 28;
            this.btnSpecimenCollection.Text = "Specimen Label Collection";
            this.btnSpecimenCollection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSpecimenCollection.UseVisualStyleBackColor = false;
            this.btnSpecimenCollection.Visible = false;
            this.btnSpecimenCollection.Click += new System.EventHandler(this.btnSpecimenCollection_Click);
            // 
            // frmHKCSSDMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1336, 846);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.pnlModuleName);
            this.Controls.Add(this.pnlPatientRegistration);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userWidgetMetro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHKCSSDMain";
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
        private System.Windows.Forms.ToolStripMenuItem mnuFnBSetup;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.Button btnSpecimenCollection;
        private System.Windows.Forms.Button btnPatientRegRptManager;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem mnuUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuResetPassword;
        private System.Windows.Forms.Panel pnlModuleName;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.UserWidgetMetro userWidgetMetro1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.Button btnSpecimenReceive;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}