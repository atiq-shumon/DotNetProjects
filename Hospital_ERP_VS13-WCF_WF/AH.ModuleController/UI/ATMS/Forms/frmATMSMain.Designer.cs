namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmATMSMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmATMSMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAssetsUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterialReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTreeView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServiceProviderInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServiceDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTermsNCondition = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStoreType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMajorGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHouseKeeping = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWarehouseType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWarehouseConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHouseKeepingSub = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaintainenceHk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCSSD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCssdReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCssdIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaintaienceCSSD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArchievelog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStoreInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnMaterialReceivingReport = new System.Windows.Forms.Button();
            this.btnCloseModule = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAssets = new System.Windows.Forms.Button();
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
            this.mnuSetup,
            this.mnuHouseKeeping,
            this.mnUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAssetsUser,
            this.mnuMaterialReceipt,
            this.mnuTreeView,
            this.mnuServiceProviderInfor,
            this.mnuServiceDetails,
            this.mnuProductService,
            this.mnuTermsNCondition,
            this.mnuStoreType,
            this.mnuMajorGroup});
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(47, 20);
            this.mnuSetup.Text = "Setup";
            // 
            // mnuAssetsUser
            // 
            this.mnuAssetsUser.Name = "mnuAssetsUser";
            this.mnuAssetsUser.Size = new System.Drawing.Size(211, 22);
            this.mnuAssetsUser.Text = "Configure Assets User";
            this.mnuAssetsUser.Visible = false;
            this.mnuAssetsUser.Click += new System.EventHandler(this.mnuAssetsUser_Click);
            // 
            // mnuMaterialReceipt
            // 
            this.mnuMaterialReceipt.Name = "mnuMaterialReceipt";
            this.mnuMaterialReceipt.Size = new System.Drawing.Size(211, 22);
            this.mnuMaterialReceipt.Text = "MRR";
            this.mnuMaterialReceipt.Visible = false;
            this.mnuMaterialReceipt.Click += new System.EventHandler(this.mnuMaterialReceipt_Click);
            // 
            // mnuTreeView
            // 
            this.mnuTreeView.Name = "mnuTreeView";
            this.mnuTreeView.Size = new System.Drawing.Size(211, 22);
            this.mnuTreeView.Text = "Assets";
            this.mnuTreeView.Visible = false;
            this.mnuTreeView.Click += new System.EventHandler(this.mnuTreeView_Click);
            // 
            // mnuServiceProviderInfor
            // 
            this.mnuServiceProviderInfor.Name = "mnuServiceProviderInfor";
            this.mnuServiceProviderInfor.Size = new System.Drawing.Size(211, 22);
            this.mnuServiceProviderInfor.Text = "Service Provider Information";
            this.mnuServiceProviderInfor.Click += new System.EventHandler(this.mnuServiceProviderInfor_Click);
            // 
            // mnuServiceDetails
            // 
            this.mnuServiceDetails.Name = "mnuServiceDetails";
            this.mnuServiceDetails.Size = new System.Drawing.Size(211, 22);
            this.mnuServiceDetails.Text = "Service Details";
            this.mnuServiceDetails.Click += new System.EventHandler(this.mnuServiceDetails_Click);
            // 
            // mnuProductService
            // 
            this.mnuProductService.Name = "mnuProductService";
            this.mnuProductService.Size = new System.Drawing.Size(211, 22);
            this.mnuProductService.Text = "Product Service Information";
            this.mnuProductService.Click += new System.EventHandler(this.mnuProductService_Click);
            // 
            // mnuTermsNCondition
            // 
            this.mnuTermsNCondition.Name = "mnuTermsNCondition";
            this.mnuTermsNCondition.Size = new System.Drawing.Size(211, 22);
            this.mnuTermsNCondition.Text = "Terms && Conditions";
            this.mnuTermsNCondition.Visible = false;
            this.mnuTermsNCondition.Click += new System.EventHandler(this.mnuTermsNCondition_Click);
            // 
            // mnuStoreType
            // 
            this.mnuStoreType.Name = "mnuStoreType";
            this.mnuStoreType.Size = new System.Drawing.Size(211, 22);
            this.mnuStoreType.Text = "Store Type";
            this.mnuStoreType.Visible = false;
            this.mnuStoreType.Click += new System.EventHandler(this.mnuStoreType_Click);
            // 
            // mnuMajorGroup
            // 
            this.mnuMajorGroup.Name = "mnuMajorGroup";
            this.mnuMajorGroup.Size = new System.Drawing.Size(211, 22);
            this.mnuMajorGroup.Text = "Major Group";
            this.mnuMajorGroup.Visible = false;
            this.mnuMajorGroup.Click += new System.EventHandler(this.mnuMajorGroup_Click);
            // 
            // mnuHouseKeeping
            // 
            this.mnuHouseKeeping.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWarehouseType,
            this.mnuWarehouseConfig,
            this.mnuHouseKeepingSub,
            this.mnuCSSD,
            this.mnuArchievelog,
            this.mnuReports});
            this.mnuHouseKeeping.Name = "mnuHouseKeeping";
            this.mnuHouseKeeping.Size = new System.Drawing.Size(90, 20);
            this.mnuHouseKeeping.Text = "House Keeping";
            // 
            // mnuWarehouseType
            // 
            this.mnuWarehouseType.Name = "mnuWarehouseType";
            this.mnuWarehouseType.Size = new System.Drawing.Size(197, 22);
            this.mnuWarehouseType.Text = "Warehouse Type";
            this.mnuWarehouseType.Click += new System.EventHandler(this.mnuWarehouseType_Click);
            // 
            // mnuWarehouseConfig
            // 
            this.mnuWarehouseConfig.Name = "mnuWarehouseConfig";
            this.mnuWarehouseConfig.Size = new System.Drawing.Size(197, 22);
            this.mnuWarehouseConfig.Text = "Warehouse Configuration";
            this.mnuWarehouseConfig.Click += new System.EventHandler(this.mnuWarehouseConfig_Click);
            // 
            // mnuHouseKeepingSub
            // 
            this.mnuHouseKeepingSub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReceipt,
            this.mnuIssue,
            this.mnuMaintainenceHk});
            this.mnuHouseKeepingSub.Name = "mnuHouseKeepingSub";
            this.mnuHouseKeepingSub.Size = new System.Drawing.Size(197, 22);
            this.mnuHouseKeepingSub.Text = "House Keeping";
            // 
            // mnuReceipt
            // 
            this.mnuReceipt.Name = "mnuReceipt";
            this.mnuReceipt.Size = new System.Drawing.Size(201, 22);
            this.mnuReceipt.Text = "Receipt";
            this.mnuReceipt.Click += new System.EventHandler(this.mnuReceipt_Click);
            // 
            // mnuIssue
            // 
            this.mnuIssue.Name = "mnuIssue";
            this.mnuIssue.Size = new System.Drawing.Size(201, 22);
            this.mnuIssue.Text = "Issue for Maintenance";
            this.mnuIssue.Click += new System.EventHandler(this.mnuIssue_Click);
            // 
            // mnuMaintainenceHk
            // 
            this.mnuMaintainenceHk.Name = "mnuMaintainenceHk";
            this.mnuMaintainenceHk.Size = new System.Drawing.Size(201, 22);
            this.mnuMaintainenceHk.Text = "Receipt From Maintenance";
            this.mnuMaintainenceHk.Click += new System.EventHandler(this.mnuMaintainenceHk_Click);
            // 
            // mnuCSSD
            // 
            this.mnuCSSD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCssdReceipt,
            this.mnuCssdIssue,
            this.mnuMaintaienceCSSD});
            this.mnuCSSD.Name = "mnuCSSD";
            this.mnuCSSD.Size = new System.Drawing.Size(197, 22);
            this.mnuCSSD.Text = "CSSD";
            // 
            // mnuCssdReceipt
            // 
            this.mnuCssdReceipt.Name = "mnuCssdReceipt";
            this.mnuCssdReceipt.Size = new System.Drawing.Size(201, 22);
            this.mnuCssdReceipt.Text = "Receipt";
            this.mnuCssdReceipt.Click += new System.EventHandler(this.mnuCssdReceipt_Click);
            // 
            // mnuCssdIssue
            // 
            this.mnuCssdIssue.Name = "mnuCssdIssue";
            this.mnuCssdIssue.Size = new System.Drawing.Size(201, 22);
            this.mnuCssdIssue.Text = "Issue for Maintenance";
            this.mnuCssdIssue.Click += new System.EventHandler(this.mnuCssdIssue_Click);
            // 
            // mnuMaintaienceCSSD
            // 
            this.mnuMaintaienceCSSD.Name = "mnuMaintaienceCSSD";
            this.mnuMaintaienceCSSD.Size = new System.Drawing.Size(201, 22);
            this.mnuMaintaienceCSSD.Text = "Receipt From Maintenance";
            this.mnuMaintaienceCSSD.Click += new System.EventHandler(this.mnuMaintaienceCSSD_Click);
            // 
            // mnuArchievelog
            // 
            this.mnuArchievelog.Name = "mnuArchievelog";
            this.mnuArchievelog.Size = new System.Drawing.Size(197, 22);
            this.mnuArchievelog.Text = "Archieve Log";
            this.mnuArchievelog.Visible = false;
            this.mnuArchievelog.Click += new System.EventHandler(this.mnuArchievelog_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStoreInformation});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(197, 22);
            this.mnuReports.Text = "Reports";
            // 
            // mnuStoreInformation
            // 
            this.mnuStoreInformation.Name = "mnuStoreInformation";
            this.mnuStoreInformation.Size = new System.Drawing.Size(159, 22);
            this.mnuStoreInformation.Text = "Store Information";
            this.mnuStoreInformation.Click += new System.EventHandler(this.mnuStoreInformation_Click);
            // 
            // mnUtility
            // 
            this.mnUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangePassword});
            this.mnUtility.Name = "mnUtility";
            this.mnUtility.Size = new System.Drawing.Size(46, 20);
            this.mnUtility.Text = "Utility";
            // 
            // mnuChangePassword
            // 
            this.mnuChangePassword.Name = "mnuChangePassword";
            this.mnuChangePassword.Size = new System.Drawing.Size(160, 22);
            this.mnuChangePassword.Text = "Change Password";
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
            this.pnlPatientRegistration.Controls.Add(this.btnMaterialReceivingReport);
            this.pnlPatientRegistration.Controls.Add(this.btnCloseModule);
            this.pnlPatientRegistration.Controls.Add(this.btnReports);
            this.pnlPatientRegistration.Controls.Add(this.btnAssets);
            this.pnlPatientRegistration.Location = new System.Drawing.Point(105, 181);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(612, 465);
            this.pnlPatientRegistration.TabIndex = 1;
            this.pnlPatientRegistration.Visible = false;
            // 
            // btnMaterialReceivingReport
            // 
            this.btnMaterialReceivingReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMaterialReceivingReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaterialReceivingReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterialReceivingReport.FlatAppearance.BorderSize = 0;
            this.btnMaterialReceivingReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Olive;
            this.btnMaterialReceivingReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMaterialReceivingReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialReceivingReport.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialReceivingReport.ForeColor = System.Drawing.Color.Black;
            this.btnMaterialReceivingReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaterialReceivingReport.ImageIndex = 5;
            this.btnMaterialReceivingReport.ImageList = this.imageList1;
            this.btnMaterialReceivingReport.Location = new System.Drawing.Point(29, 15);
            this.btnMaterialReceivingReport.Name = "btnMaterialReceivingReport";
            this.btnMaterialReceivingReport.Size = new System.Drawing.Size(264, 100);
            this.btnMaterialReceivingReport.TabIndex = 45;
            this.btnMaterialReceivingReport.Text = "Service Provider Information";
            this.btnMaterialReceivingReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaterialReceivingReport.UseVisualStyleBackColor = false;
            this.btnMaterialReceivingReport.Visible = false;
            this.btnMaterialReceivingReport.Click += new System.EventHandler(this.btnMaterialReceivingReport_Click);
            // 
            // btnCloseModule
            // 
            this.btnCloseModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCloseModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseModule.FlatAppearance.BorderSize = 0;
            this.btnCloseModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseModule.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseModule.ForeColor = System.Drawing.Color.Black;
            this.btnCloseModule.ImageIndex = 0;
            this.btnCloseModule.ImageList = this.imageList1;
            this.btnCloseModule.Location = new System.Drawing.Point(308, 135);
            this.btnCloseModule.Name = "btnCloseModule";
            this.btnCloseModule.Size = new System.Drawing.Size(264, 100);
            this.btnCloseModule.TabIndex = 44;
            this.btnCloseModule.Text = "Close Module";
            this.btnCloseModule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseModule.UseVisualStyleBackColor = false;
            this.btnCloseModule.Click += new System.EventHandler(this.btnCloseModule_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.Olive;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.ImageIndex = 3;
            this.btnReports.ImageList = this.imageList1;
            this.btnReports.Location = new System.Drawing.Point(29, 135);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(264, 100);
            this.btnReports.TabIndex = 39;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAssets
            // 
            this.btnAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAssets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAssets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssets.FlatAppearance.BorderSize = 0;
            this.btnAssets.FlatAppearance.CheckedBackColor = System.Drawing.Color.Olive;
            this.btnAssets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssets.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssets.ForeColor = System.Drawing.Color.Black;
            this.btnAssets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAssets.ImageIndex = 1;
            this.btnAssets.ImageList = this.imageList1;
            this.btnAssets.Location = new System.Drawing.Point(308, 15);
            this.btnAssets.Name = "btnAssets";
            this.btnAssets.Size = new System.Drawing.Size(264, 100);
            this.btnAssets.TabIndex = 38;
            this.btnAssets.Text = "Service Details";
            this.btnAssets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssets.UseVisualStyleBackColor = false;
            this.btnAssets.Visible = false;
            this.btnAssets.Click += new System.EventHandler(this.btnAssets_Click);
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
            this.pnlModuleName.Size = new System.Drawing.Size(589, 54);
            this.pnlModuleName.TabIndex = 45;
            this.pnlModuleName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Asset Tracking Management System";
            // 
            // frmATMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(914, 846);
            this.Controls.Add(this.pnlModuleName);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.userWidgetMetro1);
            this.Controls.Add(this.pnlPatientRegistration);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmATMSMain";
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
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Button btnCloseModule;
        private System.Windows.Forms.Button btnMaterialReceivingReport;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuTreeView;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterialReceipt;
        private System.Windows.Forms.ToolStripMenuItem mnuAssetsUser;
        private System.Windows.Forms.ToolStripMenuItem mnuServiceProviderInfor;
        private System.Windows.Forms.ToolStripMenuItem mnuServiceDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuProductService;
        private System.Windows.Forms.ToolStripMenuItem mnuTermsNCondition;
        private System.Windows.Forms.ToolStripMenuItem mnuStoreType;
        private System.Windows.Forms.ToolStripMenuItem mnuMajorGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuHouseKeeping;
        private System.Windows.Forms.ToolStripMenuItem mnuWarehouseType;
        private System.Windows.Forms.ToolStripMenuItem mnuWarehouseConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuHouseKeepingSub;
        private System.Windows.Forms.ToolStripMenuItem mnuReceipt;
        private System.Windows.Forms.ToolStripMenuItem mnuIssue;
        private System.Windows.Forms.ToolStripMenuItem mnuCSSD;
        private System.Windows.Forms.ToolStripMenuItem mnuCssdReceipt;
        private System.Windows.Forms.ToolStripMenuItem mnuCssdIssue;
        private System.Windows.Forms.ToolStripMenuItem mnuArchievelog;
        private System.Windows.Forms.ToolStripMenuItem mnuMaintainenceHk;
        private System.Windows.Forms.ToolStripMenuItem mnuMaintaienceCSSD;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuStoreInformation;
    }
}