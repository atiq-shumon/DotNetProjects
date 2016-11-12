namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmACCMSMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmACCMSMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFiscalYear = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBranchConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGroupConfigurationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCostCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCostCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLedgerConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevenueHeadgroup = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueHeadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollectionStatement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLedgerOpnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPostVoucherTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuvoucherTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVoucherArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBankReconcilation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFixedAssets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFixedAssetsConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnurptTreeview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModulewiseCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOPDCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIPDCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnChartOfAccounts = new System.Windows.Forms.Button();
            this.btnCloseModule = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.userWidgetMetro1 = new AtiqsControlLibrary.UserWidgetMetro();
            this.dateWidget1 = new AtiqsControlLibrary.DateWidget();
            this.pnlModuleName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuFoodItemMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlPatientRegistration.SuspendLayout();
            this.pnlModuleName.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuSetup,
            this.mnuTransaction,
            this.mnuFixedAssets,
            this.mnuReports,
            this.mnUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFiscalYear,
            this.MnuBranchConfig,
            this.MnuGroupConfigurationItem,
            this.mnuCostCategory,
            this.MnuCostCenter,
            this.MnuLedgerConfig,
            this.mnuRevenueHeadgroup,
            this.revenueHeadToolStripMenuItem,
            this.mnuFoodItemMaster});
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(47, 20);
            this.mnuSetup.Text = "Setup";
            // 
            // mnuFiscalYear
            // 
            this.mnuFiscalYear.Name = "mnuFiscalYear";
            this.mnuFiscalYear.Size = new System.Drawing.Size(177, 22);
            this.mnuFiscalYear.Text = "Financial Year";
            this.mnuFiscalYear.Click += new System.EventHandler(this.mnuFiscalYear_Click);
            // 
            // MnuBranchConfig
            // 
            this.MnuBranchConfig.Name = "MnuBranchConfig";
            this.MnuBranchConfig.Size = new System.Drawing.Size(177, 22);
            this.MnuBranchConfig.Text = "Branch Configuration";
            this.MnuBranchConfig.Visible = false;
            this.MnuBranchConfig.Click += new System.EventHandler(this.MnuBranchConfig_Click);
            // 
            // MnuGroupConfigurationItem
            // 
            this.MnuGroupConfigurationItem.Name = "MnuGroupConfigurationItem";
            this.MnuGroupConfigurationItem.Size = new System.Drawing.Size(177, 22);
            this.MnuGroupConfigurationItem.Text = "Chart of Accounts";
            this.MnuGroupConfigurationItem.Click += new System.EventHandler(this.MnuGroupConfigurationItem_Click);
            // 
            // mnuCostCategory
            // 
            this.mnuCostCategory.Name = "mnuCostCategory";
            this.mnuCostCategory.Size = new System.Drawing.Size(177, 22);
            this.mnuCostCategory.Text = "Cost Category";
            this.mnuCostCategory.Visible = false;
            this.mnuCostCategory.Click += new System.EventHandler(this.mnuCostCategory_Click);
            // 
            // MnuCostCenter
            // 
            this.MnuCostCenter.Name = "MnuCostCenter";
            this.MnuCostCenter.Size = new System.Drawing.Size(177, 22);
            this.MnuCostCenter.Text = "Cost Center";
            this.MnuCostCenter.Click += new System.EventHandler(this.MnuCostCenter_Click);
            // 
            // MnuLedgerConfig
            // 
            this.MnuLedgerConfig.Name = "MnuLedgerConfig";
            this.MnuLedgerConfig.Size = new System.Drawing.Size(177, 22);
            this.MnuLedgerConfig.Text = "Ledger Configuration";
            this.MnuLedgerConfig.Visible = false;
            this.MnuLedgerConfig.Click += new System.EventHandler(this.MnuLedgerConfig_Click);
            // 
            // mnuRevenueHeadgroup
            // 
            this.mnuRevenueHeadgroup.Name = "mnuRevenueHeadgroup";
            this.mnuRevenueHeadgroup.Size = new System.Drawing.Size(177, 22);
            this.mnuRevenueHeadgroup.Text = "Revenue Head Group";
            this.mnuRevenueHeadgroup.Click += new System.EventHandler(this.mnuRevenueHeadgroup_Click);
            // 
            // revenueHeadToolStripMenuItem
            // 
            this.revenueHeadToolStripMenuItem.Name = "revenueHeadToolStripMenuItem";
            this.revenueHeadToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.revenueHeadToolStripMenuItem.Text = "Revenue Head";
            this.revenueHeadToolStripMenuItem.Click += new System.EventHandler(this.revenueHeadToolStripMenuItem_Click);
            // 
            // mnuTransaction
            // 
            this.mnuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCollectionStatement,
            this.mnuLedgerOpnMenu,
            this.mnuPostVoucherTransaction,
            this.mnuvoucherTransaction,
            this.mnuVoucherArchive,
            this.mnuBankReconcilation});
            this.mnuTransaction.Name = "mnuTransaction";
            this.mnuTransaction.Size = new System.Drawing.Size(75, 20);
            this.mnuTransaction.Text = "Transaction";
            // 
            // mnuCollectionStatement
            // 
            this.mnuCollectionStatement.Name = "mnuCollectionStatement";
            this.mnuCollectionStatement.Size = new System.Drawing.Size(209, 22);
            this.mnuCollectionStatement.Text = "Collection Statement";
            this.mnuCollectionStatement.Click += new System.EventHandler(this.mnuCollectionStatement_Click);
            // 
            // mnuLedgerOpnMenu
            // 
            this.mnuLedgerOpnMenu.Name = "mnuLedgerOpnMenu";
            this.mnuLedgerOpnMenu.Size = new System.Drawing.Size(209, 22);
            this.mnuLedgerOpnMenu.Text = "Ledger Opening";
            this.mnuLedgerOpnMenu.Click += new System.EventHandler(this.mnuLedgerOpnMenu_Click);
            // 
            // mnuPostVoucherTransaction
            // 
            this.mnuPostVoucherTransaction.Name = "mnuPostVoucherTransaction";
            this.mnuPostVoucherTransaction.Size = new System.Drawing.Size(209, 22);
            this.mnuPostVoucherTransaction.Text = "Post Voucher Transaction";
            this.mnuPostVoucherTransaction.Click += new System.EventHandler(this.mnuPostVoucherTransaction_Click);
            // 
            // mnuvoucherTransaction
            // 
            this.mnuvoucherTransaction.Name = "mnuvoucherTransaction";
            this.mnuvoucherTransaction.Size = new System.Drawing.Size(209, 22);
            this.mnuvoucherTransaction.Text = "Unpost Voucher Transaction";
            this.mnuvoucherTransaction.Click += new System.EventHandler(this.mnuvoucherTransaction_Click);
            // 
            // mnuVoucherArchive
            // 
            this.mnuVoucherArchive.Name = "mnuVoucherArchive";
            this.mnuVoucherArchive.Size = new System.Drawing.Size(209, 22);
            this.mnuVoucherArchive.Text = "Voucher Archive";
            this.mnuVoucherArchive.Click += new System.EventHandler(this.mnuVoucherArchive_Click);
            // 
            // mnuBankReconcilation
            // 
            this.mnuBankReconcilation.Name = "mnuBankReconcilation";
            this.mnuBankReconcilation.Size = new System.Drawing.Size(209, 22);
            this.mnuBankReconcilation.Text = "Bank Reconcilation";
            this.mnuBankReconcilation.Click += new System.EventHandler(this.mnuBankReconcilation_Click);
            // 
            // mnuFixedAssets
            // 
            this.mnuFixedAssets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFixedAssetsConfiguration});
            this.mnuFixedAssets.Name = "mnuFixedAssets";
            this.mnuFixedAssets.Size = new System.Drawing.Size(80, 20);
            this.mnuFixedAssets.Text = "Fixed Assets";
            // 
            // mnuFixedAssetsConfiguration
            // 
            this.mnuFixedAssetsConfiguration.Name = "mnuFixedAssetsConfiguration";
            this.mnuFixedAssetsConfiguration.Size = new System.Drawing.Size(198, 22);
            this.mnuFixedAssetsConfiguration.Text = "Fixed Asets Configuration";
            this.mnuFixedAssetsConfiguration.Click += new System.EventHandler(this.mnuFixedAssetsConfiguration_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnurptTreeview,
            this.mnuModulewiseCollection});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(57, 20);
            this.mnuReports.Text = "Reports";
            // 
            // mnurptTreeview
            // 
            this.mnurptTreeview.Name = "mnurptTreeview";
            this.mnurptTreeview.Size = new System.Drawing.Size(156, 22);
            this.mnurptTreeview.Text = "Accounts ";
            this.mnurptTreeview.Click += new System.EventHandler(this.mnurptTreeview_Click);
            // 
            // mnuModulewiseCollection
            // 
            this.mnuModulewiseCollection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOPDCollection,
            this.mnuIPDCollection});
            this.mnuModulewiseCollection.Name = "mnuModulewiseCollection";
            this.mnuModulewiseCollection.Size = new System.Drawing.Size(156, 22);
            this.mnuModulewiseCollection.Text = "Collection Report";
            // 
            // mnuOPDCollection
            // 
            this.mnuOPDCollection.Name = "mnuOPDCollection";
            this.mnuOPDCollection.Size = new System.Drawing.Size(144, 22);
            this.mnuOPDCollection.Text = "OPD Collection";
            this.mnuOPDCollection.Click += new System.EventHandler(this.mnuOPDCollection_Click);
            // 
            // mnuIPDCollection
            // 
            this.mnuIPDCollection.Name = "mnuIPDCollection";
            this.mnuIPDCollection.Size = new System.Drawing.Size(144, 22);
            this.mnuIPDCollection.Text = "DMS Collection";
            this.mnuIPDCollection.Click += new System.EventHandler(this.mnuIPDCollection_Click);
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
            this.pnlPatientRegistration.Controls.Add(this.btnChartOfAccounts);
            this.pnlPatientRegistration.Controls.Add(this.btnCloseModule);
            this.pnlPatientRegistration.Controls.Add(this.btnReports);
            this.pnlPatientRegistration.Controls.Add(this.btnTransaction);
            this.pnlPatientRegistration.Location = new System.Drawing.Point(105, 181);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(612, 465);
            this.pnlPatientRegistration.TabIndex = 1;
            // 
            // btnChartOfAccounts
            // 
            this.btnChartOfAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(67)))));
            this.btnChartOfAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChartOfAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChartOfAccounts.FlatAppearance.BorderSize = 0;
            this.btnChartOfAccounts.FlatAppearance.CheckedBackColor = System.Drawing.Color.Olive;
            this.btnChartOfAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnChartOfAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChartOfAccounts.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChartOfAccounts.ForeColor = System.Drawing.Color.White;
            this.btnChartOfAccounts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChartOfAccounts.ImageIndex = 5;
            this.btnChartOfAccounts.ImageList = this.imageList1;
            this.btnChartOfAccounts.Location = new System.Drawing.Point(29, 15);
            this.btnChartOfAccounts.Name = "btnChartOfAccounts";
            this.btnChartOfAccounts.Size = new System.Drawing.Size(264, 100);
            this.btnChartOfAccounts.TabIndex = 45;
            this.btnChartOfAccounts.Text = "Chart of Accounts";
            this.btnChartOfAccounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChartOfAccounts.UseVisualStyleBackColor = false;
            this.btnChartOfAccounts.Click += new System.EventHandler(this.btnChartOfAccounts_Click);
            // 
            // btnCloseModule
            // 
            this.btnCloseModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnCloseModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseModule.FlatAppearance.BorderSize = 0;
            this.btnCloseModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseModule.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseModule.ForeColor = System.Drawing.Color.White;
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
            this.btnReports.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.Olive;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
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
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatAppearance.CheckedBackColor = System.Drawing.Color.Olive;
            this.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransaction.ImageIndex = 1;
            this.btnTransaction.ImageList = this.imageList1;
            this.btnTransaction.Location = new System.Drawing.Point(308, 15);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(264, 100);
            this.btnTransaction.TabIndex = 38;
            this.btnTransaction.Text = "Unpost Transaction";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
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
            this.label1.Size = new System.Drawing.Size(418, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Accounts Management System";
            // 
            // mnuFoodItemMaster
            // 
            this.mnuFoodItemMaster.Name = "mnuFoodItemMaster";
            this.mnuFoodItemMaster.Size = new System.Drawing.Size(177, 22);
            this.mnuFoodItemMaster.Text = "Food Item Master";
            this.mnuFoodItemMaster.Click += new System.EventHandler(this.mnuFoodItemMaster_Click);
            // 
            // frmACCMSMain
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
            this.Name = "frmACCMSMain";
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.ToolStripMenuItem newPatientRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ToolStripMenuItem MnuBranchConfig;
        private System.Windows.Forms.ToolStripMenuItem MnuGroupConfigurationItem;
        private System.Windows.Forms.ToolStripMenuItem MnuLedgerConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuLedgerOpnMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuvoucherTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem MnuCostCenter;
        private System.Windows.Forms.ToolStripMenuItem mnUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnuCostCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuRevenueHeadgroup;
        private System.Windows.Forms.ToolStripMenuItem revenueHeadToolStripMenuItem;
        private AtiqsControlLibrary.UserWidgetMetro userWidgetMetro1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.Panel pnlModuleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnCloseModule;
        private System.Windows.Forms.Button btnChartOfAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnurptTreeview;
        private System.Windows.Forms.ToolStripMenuItem mnuVoucherArchive;
        private System.Windows.Forms.ToolStripMenuItem mnuBankReconcilation;
        private System.Windows.Forms.ToolStripMenuItem mnuPostVoucherTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuFixedAssets;
        private System.Windows.Forms.ToolStripMenuItem mnuFixedAssetsConfiguration;
        private System.Windows.Forms.ToolStripMenuItem mnuFiscalYear;
        private System.Windows.Forms.ToolStripMenuItem mnuCollectionStatement;
        private System.Windows.Forms.ToolStripMenuItem mnuModulewiseCollection;
        private System.Windows.Forms.ToolStripMenuItem mnuOPDCollection;
        private System.Windows.Forms.ToolStripMenuItem mnuIPDCollection;
        private System.Windows.Forms.ToolStripMenuItem mnuFoodItemMaster;
    }
}