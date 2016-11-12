namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmFNBMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFNBMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBasicSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFoodCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServiceSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFoodMenuType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFnBSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReceiptSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusetmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFoodItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFoodMenuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.SetMenuItemSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mealSetupMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMealSetupConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.WeeklySetupMain = new System.Windows.Forms.ToolStripMenuItem();
            this.SetmenuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventories = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemDamage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetmenuVisitors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTotalAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMealIssued = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWeeklyChart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollectionTrasfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFNBReportSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.fNBReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerifyDR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDietOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDietCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubmenuType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWeekleyDietSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlFnB = new System.Windows.Forms.Panel();
            this.btnMealRegister = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCollectionTransfer = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.pnlModuleName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userWidgetMetro1 = new AtiqsControlLibrary.UserWidgetMetro();
            this.dateWidget1 = new AtiqsControlLibrary.DateWidget();
            this.menuStrip1.SuspendLayout();
            this.pnlFnB.SuspendLayout();
            this.pnlModuleName.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBasicSetup,
            this.mnuFnBSetup,
            this.mnuInventories,
            this.mnuTransaction,
            this.mnuFNBReportSetup,
            this.mnuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBasicSetup
            // 
            this.mnuBasicSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFoodCategory,
            this.mnuServiceSetup,
            this.mnuFoodMenuType});
            this.mnuBasicSetup.Name = "mnuBasicSetup";
            this.mnuBasicSetup.Size = new System.Drawing.Size(74, 20);
            this.mnuBasicSetup.Text = "Basic Setup";
            // 
            // mnuFoodCategory
            // 
            this.mnuFoodCategory.Name = "mnuFoodCategory";
            this.mnuFoodCategory.Size = new System.Drawing.Size(154, 22);
            this.mnuFoodCategory.Text = "Food Category";
            this.mnuFoodCategory.Click += new System.EventHandler(this.mnuFoodCategory_Click);
            // 
            // mnuServiceSetup
            // 
            this.mnuServiceSetup.Name = "mnuServiceSetup";
            this.mnuServiceSetup.Size = new System.Drawing.Size(154, 22);
            this.mnuServiceSetup.Text = "Service Setup";
            this.mnuServiceSetup.Click += new System.EventHandler(this.mnuServiceSetup_Click);
            // 
            // mnuFoodMenuType
            // 
            this.mnuFoodMenuType.Name = "mnuFoodMenuType";
            this.mnuFoodMenuType.Size = new System.Drawing.Size(154, 22);
            this.mnuFoodMenuType.Text = "Food Menu Type";
            this.mnuFoodMenuType.Click += new System.EventHandler(this.mnuFoodMenuType_Click);
            // 
            // mnuFnBSetup
            // 
            this.mnuFnBSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReceiptSetup,
            this.mnusetmenu,
            this.mnuFoodItem,
            this.mnuFoodMenuSetup,
            this.SetMenuItemSetup,
            this.mealSetupMain,
            this.WeeklySetupMain});
            this.mnuFnBSetup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFnBSetup.Name = "mnuFnBSetup";
            this.mnuFnBSetup.Size = new System.Drawing.Size(47, 20);
            this.mnuFnBSetup.Text = "Setup";
            // 
            // mnuReceiptSetup
            // 
            this.mnuReceiptSetup.Name = "mnuReceiptSetup";
            this.mnuReceiptSetup.Size = new System.Drawing.Size(184, 22);
            this.mnuReceiptSetup.Text = "Receipt";
            this.mnuReceiptSetup.Visible = false;
            this.mnuReceiptSetup.Click += new System.EventHandler(this.mnuReceiptSetup_Click);
            // 
            // mnusetmenu
            // 
            this.mnusetmenu.Name = "mnusetmenu";
            this.mnusetmenu.Size = new System.Drawing.Size(184, 22);
            this.mnusetmenu.Text = "Set Menu";
            this.mnusetmenu.Visible = false;
            this.mnusetmenu.Click += new System.EventHandler(this.mnusetmenu_Click);
            // 
            // mnuFoodItem
            // 
            this.mnuFoodItem.Name = "mnuFoodItem";
            this.mnuFoodItem.Size = new System.Drawing.Size(184, 22);
            this.mnuFoodItem.Text = "Food Item Master";
            this.mnuFoodItem.Click += new System.EventHandler(this.mnuFoodItem_Click);
            // 
            // mnuFoodMenuSetup
            // 
            this.mnuFoodMenuSetup.Name = "mnuFoodMenuSetup";
            this.mnuFoodMenuSetup.Size = new System.Drawing.Size(184, 22);
            this.mnuFoodMenuSetup.Text = "Set Menu Setup";
            this.mnuFoodMenuSetup.Click += new System.EventHandler(this.mnuFoodMenuSetup_Click);
            // 
            // SetMenuItemSetup
            // 
            this.SetMenuItemSetup.Name = "SetMenuItemSetup";
            this.SetMenuItemSetup.Size = new System.Drawing.Size(184, 22);
            this.SetMenuItemSetup.Text = "Set Menu Item Setup";
            this.SetMenuItemSetup.Click += new System.EventHandler(this.SetMenuItemSetup_Click);
            // 
            // mealSetupMain
            // 
            this.mealSetupMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMealSetupConfig});
            this.mealSetupMain.Name = "mealSetupMain";
            this.mealSetupMain.Size = new System.Drawing.Size(184, 22);
            this.mealSetupMain.Text = "Meal Setup";
            // 
            // mnuMealSetupConfig
            // 
            this.mnuMealSetupConfig.Name = "mnuMealSetupConfig";
            this.mnuMealSetupConfig.Size = new System.Drawing.Size(195, 22);
            this.mnuMealSetupConfig.Text = "Meal Setup Configuration";
            this.mnuMealSetupConfig.Click += new System.EventHandler(this.mnuMealSetupConfig_Click);
            // 
            // WeeklySetupMain
            // 
            this.WeeklySetupMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetmenuConfig});
            this.WeeklySetupMain.Name = "WeeklySetupMain";
            this.WeeklySetupMain.Size = new System.Drawing.Size(184, 22);
            this.WeeklySetupMain.Text = "Setmenu Configuration";
            // 
            // SetmenuConfig
            // 
            this.SetmenuConfig.Name = "SetmenuConfig";
            this.SetmenuConfig.Size = new System.Drawing.Size(184, 22);
            this.SetmenuConfig.Text = "Setmenu Configuration";
            this.SetmenuConfig.Click += new System.EventHandler(this.SetmenuConfig_Click);
            // 
            // mnuInventories
            // 
            this.mnuInventories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemIssue,
            this.toolStripSeparator1,
            this.mnuItemDamage,
            this.toolStripSeparator2,
            this.mnuIssue,
            this.toolStripSeparator3,
            this.mnuItemReturn});
            this.mnuInventories.Name = "mnuInventories";
            this.mnuInventories.Size = new System.Drawing.Size(74, 20);
            this.mnuInventories.Text = "Inventories";
            // 
            // mnuItemIssue
            // 
            this.mnuItemIssue.Name = "mnuItemIssue";
            this.mnuItemIssue.Size = new System.Drawing.Size(152, 22);
            this.mnuItemIssue.Text = "Material Receipt";
            this.mnuItemIssue.Click += new System.EventHandler(this.mnuItemIssue_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuItemDamage
            // 
            this.mnuItemDamage.Name = "mnuItemDamage";
            this.mnuItemDamage.Size = new System.Drawing.Size(152, 22);
            this.mnuItemDamage.Text = "Item Damage";
            this.mnuItemDamage.Click += new System.EventHandler(this.mnuItemDamage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuIssue
            // 
            this.mnuIssue.Name = "mnuIssue";
            this.mnuIssue.Size = new System.Drawing.Size(152, 22);
            this.mnuIssue.Text = "Item Issue";
            this.mnuIssue.Visible = false;
            this.mnuIssue.Click += new System.EventHandler(this.mnuIssue_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            this.toolStripSeparator3.Visible = false;
            // 
            // mnuItemReturn
            // 
            this.mnuItemReturn.Name = "mnuItemReturn";
            this.mnuItemReturn.Size = new System.Drawing.Size(152, 22);
            this.mnuItemReturn.Text = "Sales Return";
            this.mnuItemReturn.Click += new System.EventHandler(this.mnuItemReturn_Click);
            // 
            // mnuTransaction
            // 
            this.mnuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetmenuVisitors,
            this.mnuTotalAttendance,
            this.mnuRegister,
            this.mnuMealIssued,
            this.mnuWeeklyChart,
            this.mnuCollectionTrasfer});
            this.mnuTransaction.Name = "mnuTransaction";
            this.mnuTransaction.Size = new System.Drawing.Size(75, 20);
            this.mnuTransaction.Text = "Transaction";
            // 
            // mnuSetmenuVisitors
            // 
            this.mnuSetmenuVisitors.Name = "mnuSetmenuVisitors";
            this.mnuSetmenuVisitors.Size = new System.Drawing.Size(164, 22);
            this.mnuSetmenuVisitors.Text = "Visitors Order";
            this.mnuSetmenuVisitors.Click += new System.EventHandler(this.mnuSetmenuVisitors_Click);
            // 
            // mnuTotalAttendance
            // 
            this.mnuTotalAttendance.Name = "mnuTotalAttendance";
            this.mnuTotalAttendance.Size = new System.Drawing.Size(164, 22);
            this.mnuTotalAttendance.Text = "Total Attendance";
            this.mnuTotalAttendance.Click += new System.EventHandler(this.mnuTotalAttendance_Click);
            // 
            // mnuRegister
            // 
            this.mnuRegister.Name = "mnuRegister";
            this.mnuRegister.Size = new System.Drawing.Size(164, 22);
            this.mnuRegister.Text = "Meal Register";
            this.mnuRegister.Click += new System.EventHandler(this.mnuRegister_Click);
            // 
            // mnuMealIssued
            // 
            this.mnuMealIssued.Name = "mnuMealIssued";
            this.mnuMealIssued.Size = new System.Drawing.Size(164, 22);
            this.mnuMealIssued.Text = "Meal Issued";
            this.mnuMealIssued.Visible = false;
            this.mnuMealIssued.Click += new System.EventHandler(this.mnuMealIssued_Click);
            // 
            // mnuWeeklyChart
            // 
            this.mnuWeeklyChart.Name = "mnuWeeklyChart";
            this.mnuWeeklyChart.Size = new System.Drawing.Size(164, 22);
            this.mnuWeeklyChart.Text = "Weekly Chart";
            this.mnuWeeklyChart.Click += new System.EventHandler(this.mnuWeeklyChart_Click);
            // 
            // mnuCollectionTrasfer
            // 
            this.mnuCollectionTrasfer.Name = "mnuCollectionTrasfer";
            this.mnuCollectionTrasfer.Size = new System.Drawing.Size(164, 22);
            this.mnuCollectionTrasfer.Text = "Collection Transfer";
            this.mnuCollectionTrasfer.Click += new System.EventHandler(this.mnuCollectionTrasfer_Click);
            // 
            // mnuFNBReportSetup
            // 
            this.mnuFNBReportSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fNBReports});
            this.mnuFNBReportSetup.Name = "mnuFNBReportSetup";
            this.mnuFNBReportSetup.Size = new System.Drawing.Size(57, 20);
            this.mnuFNBReportSetup.Text = "Reports";
            // 
            // fNBReports
            // 
            this.fNBReports.Name = "fNBReports";
            this.fNBReports.Size = new System.Drawing.Size(152, 22);
            this.fNBReports.Text = "FNB";
            this.fNBReports.Click += new System.EventHandler(this.fNBReports_Click);
            // 
            // mnuUtility
            // 
            this.mnuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResetPassword,
            this.mnuDR,
            this.mnuVerifyDR,
            this.mnuDietOrder,
            this.mnuDiet});
            this.mnuUtility.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUtility.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuUtility.Name = "mnuUtility";
            this.mnuUtility.Size = new System.Drawing.Size(46, 20);
            this.mnuUtility.Text = "Utility";
            // 
            // mnuResetPassword
            // 
            this.mnuResetPassword.Name = "mnuResetPassword";
            this.mnuResetPassword.Size = new System.Drawing.Size(199, 22);
            this.mnuResetPassword.Text = "Change Password";
            this.mnuResetPassword.Click += new System.EventHandler(this.mnuResetPassword_Click);
            // 
            // mnuDR
            // 
            this.mnuDR.Name = "mnuDR";
            this.mnuDR.Size = new System.Drawing.Size(199, 22);
            this.mnuDR.Text = "Demand Requisition";
            this.mnuDR.Click += new System.EventHandler(this.mnuDR_Click);
            // 
            // mnuVerifyDR
            // 
            this.mnuVerifyDR.Name = "mnuVerifyDR";
            this.mnuVerifyDR.Size = new System.Drawing.Size(199, 22);
            this.mnuVerifyDR.Text = "Verify Demand Requisition";
            this.mnuVerifyDR.Click += new System.EventHandler(this.mnuVerifyDR_Click);
            // 
            // mnuDietOrder
            // 
            this.mnuDietOrder.Name = "mnuDietOrder";
            this.mnuDietOrder.Size = new System.Drawing.Size(199, 22);
            this.mnuDietOrder.Text = "IPD Diet Order";
            this.mnuDietOrder.Click += new System.EventHandler(this.mnuDietOrder_Click);
            // 
            // mnuDiet
            // 
            this.mnuDiet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDietCategory,
            this.mnuSubmenuType,
            this.mnuWeekleyDietSetup});
            this.mnuDiet.Name = "mnuDiet";
            this.mnuDiet.Size = new System.Drawing.Size(199, 22);
            this.mnuDiet.Text = "Diet";
            // 
            // mnuDietCategory
            // 
            this.mnuDietCategory.Name = "mnuDietCategory";
            this.mnuDietCategory.Size = new System.Drawing.Size(148, 22);
            this.mnuDietCategory.Text = "Diet Category";
            this.mnuDietCategory.Click += new System.EventHandler(this.mnuDietCategory_Click);
            // 
            // mnuSubmenuType
            // 
            this.mnuSubmenuType.Name = "mnuSubmenuType";
            this.mnuSubmenuType.Size = new System.Drawing.Size(148, 22);
            this.mnuSubmenuType.Text = "Sub Menu Type";
            this.mnuSubmenuType.Click += new System.EventHandler(this.mnuSubmenuType_Click);
            // 
            // mnuWeekleyDietSetup
            // 
            this.mnuWeekleyDietSetup.Name = "mnuWeekleyDietSetup";
            this.mnuWeekleyDietSetup.Size = new System.Drawing.Size(148, 22);
            this.mnuWeekleyDietSetup.Text = "Diet Setup";
            this.mnuWeekleyDietSetup.Click += new System.EventHandler(this.mnuWeekleyDietSetup_Click);
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
            this.imageList1.Images.SetKeyName(9, "images1.jpg");
            this.imageList1.Images.SetKeyName(10, "Returning-Visitors.jpg");
            this.imageList1.Images.SetKeyName(11, "images-300x111.jpg");
            // 
            // pnlFnB
            // 
            this.pnlFnB.BackColor = System.Drawing.Color.Transparent;
            this.pnlFnB.Controls.Add(this.btnMealRegister);
            this.pnlFnB.Controls.Add(this.btnClose);
            this.pnlFnB.Controls.Add(this.btnCollectionTransfer);
            this.pnlFnB.Controls.Add(this.btnVisitors);
            this.pnlFnB.Location = new System.Drawing.Point(258, 201);
            this.pnlFnB.Name = "pnlFnB";
            this.pnlFnB.Size = new System.Drawing.Size(787, 491);
            this.pnlFnB.TabIndex = 1;
            // 
            // btnMealRegister
            // 
            this.btnMealRegister.BackColor = System.Drawing.Color.White;
            this.btnMealRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMealRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMealRegister.FlatAppearance.BorderSize = 0;
            this.btnMealRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMealRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealRegister.ForeColor = System.Drawing.Color.Red;
            this.btnMealRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMealRegister.ImageIndex = 9;
            this.btnMealRegister.ImageList = this.imageList1;
            this.btnMealRegister.Location = new System.Drawing.Point(376, 22);
            this.btnMealRegister.Name = "btnMealRegister";
            this.btnMealRegister.Size = new System.Drawing.Size(247, 102);
            this.btnMealRegister.TabIndex = 39;
            this.btnMealRegister.Text = "Meal Register";
            this.btnMealRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMealRegister.UseVisualStyleBackColor = false;
            this.btnMealRegister.Click += new System.EventHandler(this.btnMealRegister_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.ImageKey = "croos.png";
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(376, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(247, 102);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close Module";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCollectionTransfer
            // 
            this.btnCollectionTransfer.BackColor = System.Drawing.Color.White;
            this.btnCollectionTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCollectionTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollectionTransfer.FlatAppearance.BorderSize = 0;
            this.btnCollectionTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollectionTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectionTransfer.ForeColor = System.Drawing.Color.Red;
            this.btnCollectionTransfer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCollectionTransfer.ImageIndex = 11;
            this.btnCollectionTransfer.ImageList = this.imageList1;
            this.btnCollectionTransfer.Location = new System.Drawing.Point(126, 125);
            this.btnCollectionTransfer.Name = "btnCollectionTransfer";
            this.btnCollectionTransfer.Size = new System.Drawing.Size(247, 102);
            this.btnCollectionTransfer.TabIndex = 30;
            this.btnCollectionTransfer.Text = "Collection Transfer";
            this.btnCollectionTransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCollectionTransfer.UseVisualStyleBackColor = false;
            this.btnCollectionTransfer.Click += new System.EventHandler(this.btnCollectionTransfer_Click);
            // 
            // btnVisitors
            // 
            this.btnVisitors.BackColor = System.Drawing.Color.White;
            this.btnVisitors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVisitors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitors.FlatAppearance.BorderSize = 0;
            this.btnVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitors.ForeColor = System.Drawing.Color.Red;
            this.btnVisitors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisitors.ImageIndex = 10;
            this.btnVisitors.ImageList = this.imageList1;
            this.btnVisitors.Location = new System.Drawing.Point(126, 22);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Size = new System.Drawing.Size(247, 102);
            this.btnVisitors.TabIndex = 28;
            this.btnVisitors.Text = "Visitors Order";
            this.btnVisitors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisitors.UseVisualStyleBackColor = false;
            this.btnVisitors.Click += new System.EventHandler(this.btnVisitors_Click);
            // 
            // pnlModuleName
            // 
            this.pnlModuleName.BackColor = System.Drawing.Color.Transparent;
            this.pnlModuleName.Controls.Add(this.label1);
            this.pnlModuleName.Location = new System.Drawing.Point(259, 155);
            this.pnlModuleName.Name = "pnlModuleName";
            this.pnlModuleName.Size = new System.Drawing.Size(787, 54);
            this.pnlModuleName.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Food and Beverage Management System";
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
            // frmFNBMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1338, 846);
            this.Controls.Add(this.dateWidget1);
            this.Controls.Add(this.pnlModuleName);
            this.Controls.Add(this.pnlFnB);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userWidgetMetro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFNBMain";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPatientRegistrationMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlFnB.ResumeLayout(false);
            this.pnlModuleName.ResumeLayout(false);
            this.pnlModuleName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFnBSetup;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlFnB;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.Button btnCollectionTransfer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem mnuUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuResetPassword;
        private System.Windows.Forms.Panel pnlModuleName;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.UserWidgetMetro userWidgetMetro1;
        private AtiqsControlLibrary.DateWidget dateWidget1;
        private System.Windows.Forms.Button btnMealRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuBasicSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuReceiptSetup;
        private System.Windows.Forms.ToolStripMenuItem mnusetmenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFoodItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFoodMenuSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuFNBReportSetup;
        private System.Windows.Forms.ToolStripMenuItem fNBReports;
        private System.Windows.Forms.ToolStripMenuItem SetMenuItemSetup;
        private System.Windows.Forms.ToolStripMenuItem mealSetupMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMealSetupConfig;
        private System.Windows.Forms.ToolStripMenuItem WeeklySetupMain;
        private System.Windows.Forms.ToolStripMenuItem SetmenuConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuSetmenuVisitors;
        private System.Windows.Forms.ToolStripMenuItem mnuRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuWeeklyChart;
        private System.Windows.Forms.ToolStripMenuItem mnuCollectionTrasfer;
        private System.Windows.Forms.ToolStripMenuItem mnuMealIssued;
        private System.Windows.Forms.ToolStripMenuItem mnuFoodCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuServiceSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuFoodMenuType;
        private System.Windows.Forms.ToolStripMenuItem mnuTotalAttendance;
        private System.Windows.Forms.ToolStripMenuItem mnuDR;
        private System.Windows.Forms.ToolStripMenuItem mnuVerifyDR;
        private System.Windows.Forms.ToolStripMenuItem mnuInventories;
        private System.Windows.Forms.ToolStripMenuItem mnuItemIssue;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDamage;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuIssue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuDietOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuDiet;
        private System.Windows.Forms.ToolStripMenuItem mnuSubmenuType;
        private System.Windows.Forms.ToolStripMenuItem mnuWeekleyDietSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuDietCategory;
    }
}