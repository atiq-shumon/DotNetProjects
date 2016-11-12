namespace AH.ModuleController.UI.DIET.Forms
{
    partial class frmDIETMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDIETMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatientInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPatDietOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTotalOrderList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOrderDelevered = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuServedFood = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDietSubType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuWeeklyDietSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnCloseModule = new System.Windows.Forms.Button();
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
            this.mnUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPatientInformation,
            this.toolStripSeparator1,
            this.mnuPatDietOrder,
            this.toolStripSeparator3,
            this.mnuTotalOrderList,
            this.toolStripSeparator2,
            this.mnuOrderDelevered,
            this.toolStripSeparator4,
            this.mnuServedFood,
            this.toolStripSeparator5,
            this.mnuClose});
            this.mnuFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuFile.Size = new System.Drawing.Size(38, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuPatientInformation
            // 
            this.mnuPatientInformation.Name = "mnuPatientInformation";
            this.mnuPatientInformation.Size = new System.Drawing.Size(228, 22);
            this.mnuPatientInformation.Text = "Patient Details Information";
            this.mnuPatientInformation.Click += new System.EventHandler(this.mnuPatientInformation_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuPatDietOrder
            // 
            this.mnuPatDietOrder.Name = "mnuPatDietOrder";
            this.mnuPatDietOrder.Size = new System.Drawing.Size(228, 22);
            this.mnuPatDietOrder.Text = "Patient Diet Order";
            this.mnuPatDietOrder.Click += new System.EventHandler(this.mnuPatDietOrder_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuTotalOrderList
            // 
            this.mnuTotalOrderList.Name = "mnuTotalOrderList";
            this.mnuTotalOrderList.Size = new System.Drawing.Size(228, 22);
            this.mnuTotalOrderList.Text = "Total Order List";
            this.mnuTotalOrderList.Click += new System.EventHandler(this.mnuTotalOrderList_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuOrderDelevered
            // 
            this.mnuOrderDelevered.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuOrderDelevered.Name = "mnuOrderDelevered";
            this.mnuOrderDelevered.Size = new System.Drawing.Size(228, 22);
            this.mnuOrderDelevered.Text = "Order Delivered";
            this.mnuOrderDelevered.Click += new System.EventHandler(this.mnuOrderDelevered_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuServedFood
            // 
            this.mnuServedFood.Name = "mnuServedFood";
            this.mnuServedFood.Size = new System.Drawing.Size(228, 22);
            this.mnuServedFood.Text = "Served Food";
            this.mnuServedFood.Click += new System.EventHandler(this.mnuServedFood_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeyDisplayString = "Ctrl+X";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuClose.Size = new System.Drawing.Size(228, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDietSubType,
            this.toolStripSeparator6,
            this.mnuWeeklyDietSetup});
            this.mnuSetup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(52, 20);
            this.mnuSetup.Text = "Setup";
            // 
            // mnuDietSubType
            // 
            this.mnuDietSubType.Name = "mnuDietSubType";
            this.mnuDietSubType.Size = new System.Drawing.Size(178, 22);
            this.mnuDietSubType.Text = "Diet Sub Type";
            this.mnuDietSubType.Click += new System.EventHandler(this.mnuDietSubType_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(175, 6);
            // 
            // mnuWeeklyDietSetup
            // 
            this.mnuWeeklyDietSetup.Name = "mnuWeeklyDietSetup";
            this.mnuWeeklyDietSetup.Size = new System.Drawing.Size(178, 22);
            this.mnuWeeklyDietSetup.Text = "Weekly Diet Setup";
            this.mnuWeeklyDietSetup.Click += new System.EventHandler(this.mnuWeeklyDietSetup_Click);
            // 
            // mnUtility
            // 
            this.mnUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangePassword});
            this.mnUtility.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnUtility.Name = "mnUtility";
            this.mnUtility.Size = new System.Drawing.Size(53, 20);
            this.mnUtility.Text = "Utility";
            // 
            // mnuChangePassword
            // 
            this.mnuChangePassword.Name = "mnuChangePassword";
            this.mnuChangePassword.Size = new System.Drawing.Size(173, 22);
            this.mnuChangePassword.Text = "Change Password";
            this.mnuChangePassword.Click += new System.EventHandler(this.mnuChangePassword_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "croos.png");
            this.imageList1.Images.SetKeyName(1, "bill.png");
            this.imageList1.Images.SetKeyName(2, "business155.png");
            this.imageList1.Images.SetKeyName(3, "chart44.png");
            this.imageList1.Images.SetKeyName(4, "seo2.png");
            this.imageList1.Images.SetKeyName(5, "family3.png");
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatientRegistration.Controls.Add(this.btnCloseModule);
            this.pnlPatientRegistration.Location = new System.Drawing.Point(105, 181);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(612, 465);
            this.pnlPatientRegistration.TabIndex = 1;
            // 
            // btnCloseModule
            // 
            this.btnCloseModule.BackColor = System.Drawing.Color.Red;
            this.btnCloseModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseModule.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseModule.FlatAppearance.BorderSize = 0;
            this.btnCloseModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseModule.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseModule.ForeColor = System.Drawing.Color.Black;
            this.btnCloseModule.ImageIndex = 0;
            this.btnCloseModule.ImageList = this.imageList1;
            this.btnCloseModule.Location = new System.Drawing.Point(345, 162);
            this.btnCloseModule.Name = "btnCloseModule";
            this.btnCloseModule.Size = new System.Drawing.Size(264, 100);
            this.btnCloseModule.TabIndex = 44;
            this.btnCloseModule.Text = "Close Module";
            this.btnCloseModule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseModule.UseVisualStyleBackColor = false;
            this.btnCloseModule.Click += new System.EventHandler(this.btnCloseModule_Click);
            // 
            // userWidgetMetro1
            // 
            this.userWidgetMetro1.BackColor = System.Drawing.Color.Transparent;
            this.userWidgetMetro1.Location = new System.Drawing.Point(550, 25);
            this.userWidgetMetro1.Name = "userWidgetMetro1";
            this.userWidgetMetro1.Size = new System.Drawing.Size(364, 122);
            this.userWidgetMetro1.TabIndex = 2;
            this.userWidgetMetro1.btnLogout_Clicked += new AtiqsControlLibrary.UserWidgetMetro.LogoutButtonClickHandler(this.userWidgetMetro1_btnLogout_Clicked);
            // 
            // dateWidget1
            // 
            this.dateWidget1.BackColor = System.Drawing.Color.Transparent;
            this.dateWidget1.Location = new System.Drawing.Point(528, 725);
            this.dateWidget1.Name = "dateWidget1";
            this.dateWidget1.Size = new System.Drawing.Size(374, 109);
            this.dateWidget1.TabIndex = 3;
            // 
            // pnlModuleName
            // 
            this.pnlModuleName.BackColor = System.Drawing.Color.Transparent;
            this.pnlModuleName.Controls.Add(this.label1);
            this.pnlModuleName.Location = new System.Drawing.Point(105, 121);
            this.pnlModuleName.Name = "pnlModuleName";
            this.pnlModuleName.Size = new System.Drawing.Size(612, 54);
            this.pnlModuleName.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Diet Management System";
            // 
            // frmDIETMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.CancelButton = this.btnCloseModule;
            this.ClientSize = new System.Drawing.Size(914, 846);
            this.Controls.Add(this.pnlModuleName);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.userWidgetMetro1);
            this.Controls.Add(this.pnlPatientRegistration);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDIETMain";
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.ToolStripMenuItem mnUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private AtiqsControlLibrary.UserWidgetMetro userWidgetMetro1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.Panel pnlModuleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseModule;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuPatDietOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuOrderDelevered;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuServedFood;
        private System.Windows.Forms.ToolStripMenuItem mnuTotalOrderList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuPatientInformation;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuDietSubType;
        private System.Windows.Forms.ToolStripMenuItem mnuWeeklyDietSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}