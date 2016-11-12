namespace AH.ModuleController.UI.PHRMS.Reports.ParameterForms
{
    partial class frmPHRMSReportManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbReportOption = new System.Windows.Forms.GroupBox();
            this.tabSelection = new AtiqsControlLibrary.SmartTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoStockDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoStockList = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoProductList = new AtiqsControlLibrary.SmartRadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoOpeningReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPRReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoMrrReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoMrrDetailsReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPOReportDateWise = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPODetails = new AtiqsControlLibrary.SmartRadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoSalesDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoSales = new AtiqsControlLibrary.SmartRadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdoExpireDate = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoItemRatesHistory = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoItemRates = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoProductLedger = new AtiqsControlLibrary.SmartRadioButton();
            this.gbDateRange = new System.Windows.Forms.GroupBox();
            this.cboDateType = new AtiqsControlLibrary.SmartComboBox();
            this.lvlDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtStartDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.lblParam2 = new AtiqsControlLibrary.SmartLabel();
            this.lblParam3 = new AtiqsControlLibrary.SmartLabel();
            this.cboParam2 = new AtiqsControlLibrary.SmartComboBox();
            this.cboParam3 = new AtiqsControlLibrary.SmartComboBox();
            this.cboCompany = new AtiqsControlLibrary.SmartComboBox();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.txtIssueID = new AtiqsControlLibrary.SmartTextBox();
            this.lblParam4 = new AtiqsControlLibrary.SmartLabel();
            this.txtProductName = new AtiqsControlLibrary.SmartTextBox();
            this.lblParam5 = new AtiqsControlLibrary.SmartLabel();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.dgvProductList = new AtiqsControlLibrary.SmartDataGridView();
            this.gbNextDateRange = new System.Windows.Forms.GroupBox();
            this.cboDateTypefrom = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDay = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtStartDay = new AtiqsControlLibrary.SmartDateTextBox();
            this.txtParam1 = new AtiqsControlLibrary.SmartTextBox();
            this.txtParam2 = new AtiqsControlLibrary.SmartTextBox();
            this.rdoSalesRetReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoSalesRetDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbReportOption.SuspendLayout();
            this.tabSelection.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.gbNextDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(833, 630);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(719, 630);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(340, 9);
            this.frmLabel.Size = new System.Drawing.Size(226, 32);
            this.frmLabel.Text = "Pharmacy Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtParam2);
            this.pnlMain.Controls.Add(this.txtParam1);
            this.pnlMain.Controls.Add(this.gbNextDateRange);
            this.pnlMain.Controls.Add(this.dgvProductList);
            this.pnlMain.Controls.Add(this.lblParam5);
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.txtProductName);
            this.pnlMain.Controls.Add(this.gbReportOption);
            this.pnlMain.Controls.Add(this.lblParam4);
            this.pnlMain.Controls.Add(this.cboCompany);
            this.pnlMain.Controls.Add(this.txtIssueID);
            this.pnlMain.Controls.Add(this.lblParam1);
            this.pnlMain.Controls.Add(this.cboParam3);
            this.pnlMain.Controls.Add(this.lblParam3);
            this.pnlMain.Controls.Add(this.cboParam2);
            this.pnlMain.Controls.Add(this.lblParam2);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(945, 575);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            this.pnlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseClick);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(948, 51);
            // 
            // gbReportOption
            // 
            this.gbReportOption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbReportOption.Controls.Add(this.tabSelection);
            this.gbReportOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReportOption.Location = new System.Drawing.Point(3, 4);
            this.gbReportOption.Name = "gbReportOption";
            this.gbReportOption.Size = new System.Drawing.Size(423, 563);
            this.gbReportOption.TabIndex = 8;
            this.gbReportOption.TabStop = false;
            this.gbReportOption.Text = "Report Option";
            // 
            // tabSelection
            // 
            this.tabSelection.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabSelection.Controls.Add(this.tabPage1);
            this.tabSelection.Controls.Add(this.tabPage2);
            this.tabSelection.Controls.Add(this.tabPage3);
            this.tabSelection.Controls.Add(this.tabPage4);
            this.tabSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabSelection.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSelection.Location = new System.Drawing.Point(6, 20);
            this.tabSelection.Name = "tabSelection";
            this.tabSelection.SelectedIndex = 0;
            this.tabSelection.Size = new System.Drawing.Size(407, 540);
            this.tabSelection.TabIndex = 64;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.rdoStockDetails);
            this.tabPage1.Controls.Add(this.rdoStockList);
            this.tabPage1.Controls.Add(this.rdoProductList);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(399, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Drugs";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(4, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 2);
            this.panel3.TabIndex = 38;
            // 
            // rdoStockDetails
            // 
            this.rdoStockDetails.AutoSize = true;
            this.rdoStockDetails.BackColor = System.Drawing.Color.Transparent;
            this.rdoStockDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoStockDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoStockDetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoStockDetails.ForeColor = System.Drawing.Color.Gray;
            this.rdoStockDetails.Location = new System.Drawing.Point(21, 96);
            this.rdoStockDetails.Name = "rdoStockDetails";
            this.rdoStockDetails.Size = new System.Drawing.Size(159, 22);
            this.rdoStockDetails.TabIndex = 25;
            this.rdoStockDetails.Text = "Stock Details Report";
            this.rdoStockDetails.UseVisualStyleBackColor = false;
            this.rdoStockDetails.CheckedChanged += new System.EventHandler(this.rdoStockDetails_CheckedChanged_1);
            // 
            // rdoStockList
            // 
            this.rdoStockList.AutoSize = true;
            this.rdoStockList.BackColor = System.Drawing.Color.Transparent;
            this.rdoStockList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoStockList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoStockList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoStockList.ForeColor = System.Drawing.Color.Gray;
            this.rdoStockList.Location = new System.Drawing.Point(21, 56);
            this.rdoStockList.Name = "rdoStockList";
            this.rdoStockList.Size = new System.Drawing.Size(89, 22);
            this.rdoStockList.TabIndex = 24;
            this.rdoStockList.Text = "Stock List";
            this.rdoStockList.UseVisualStyleBackColor = false;
            this.rdoStockList.CheckedChanged += new System.EventHandler(this.rdoStockList_CheckedChanged_1);
            // 
            // rdoProductList
            // 
            this.rdoProductList.AutoSize = true;
            this.rdoProductList.BackColor = System.Drawing.Color.Transparent;
            this.rdoProductList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoProductList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoProductList.ForeColor = System.Drawing.Color.Gray;
            this.rdoProductList.Location = new System.Drawing.Point(21, 20);
            this.rdoProductList.Name = "rdoProductList";
            this.rdoProductList.Size = new System.Drawing.Size(87, 22);
            this.rdoProductList.TabIndex = 23;
            this.rdoProductList.Text = "Drug List";
            this.rdoProductList.UseVisualStyleBackColor = false;
            this.rdoProductList.CheckedChanged += new System.EventHandler(this.rdoProductList_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.rdoOpeningReport);
            this.tabPage2.Controls.Add(this.rdoPRReport);
            this.tabPage2.Controls.Add(this.rdoMrrReport);
            this.tabPage2.Controls.Add(this.rdoMrrDetailsReport);
            this.tabPage2.Controls.Add(this.rdoPOReportDateWise);
            this.tabPage2.Controls.Add(this.rdoPODetails);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(399, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transaction";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 2);
            this.panel2.TabIndex = 37;
            // 
            // rdoOpeningReport
            // 
            this.rdoOpeningReport.AutoSize = true;
            this.rdoOpeningReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoOpeningReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOpeningReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoOpeningReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoOpeningReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoOpeningReport.Location = new System.Drawing.Point(14, 126);
            this.rdoOpeningReport.Name = "rdoOpeningReport";
            this.rdoOpeningReport.Size = new System.Drawing.Size(131, 22);
            this.rdoOpeningReport.TabIndex = 36;
            this.rdoOpeningReport.Text = "Opening Report";
            this.rdoOpeningReport.UseVisualStyleBackColor = false;
            this.rdoOpeningReport.CheckedChanged += new System.EventHandler(this.rdoOpeningReport_CheckedChanged_1);
            // 
            // rdoPRReport
            // 
            this.rdoPRReport.AutoSize = true;
            this.rdoPRReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoPRReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPRReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPRReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPRReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoPRReport.Location = new System.Drawing.Point(14, 18);
            this.rdoPRReport.Name = "rdoPRReport";
            this.rdoPRReport.Size = new System.Drawing.Size(94, 22);
            this.rdoPRReport.TabIndex = 35;
            this.rdoPRReport.Text = "PR Report";
            this.rdoPRReport.UseVisualStyleBackColor = false;
            this.rdoPRReport.CheckedChanged += new System.EventHandler(this.rdoPRReport_CheckedChanged_1);
            // 
            // rdoMrrReport
            // 
            this.rdoMrrReport.AutoSize = true;
            this.rdoMrrReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoMrrReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMrrReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMrrReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoMrrReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoMrrReport.Location = new System.Drawing.Point(14, 167);
            this.rdoMrrReport.Name = "rdoMrrReport";
            this.rdoMrrReport.Size = new System.Drawing.Size(109, 22);
            this.rdoMrrReport.TabIndex = 34;
            this.rdoMrrReport.Text = "GRN Report";
            this.rdoMrrReport.UseVisualStyleBackColor = false;
            this.rdoMrrReport.CheckedChanged += new System.EventHandler(this.rdoMrrReport_CheckedChanged_1);
            // 
            // rdoMrrDetailsReport
            // 
            this.rdoMrrDetailsReport.AutoSize = true;
            this.rdoMrrDetailsReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoMrrDetailsReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMrrDetailsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMrrDetailsReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoMrrDetailsReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoMrrDetailsReport.Location = new System.Drawing.Point(14, 200);
            this.rdoMrrDetailsReport.Name = "rdoMrrDetailsReport";
            this.rdoMrrDetailsReport.Size = new System.Drawing.Size(158, 22);
            this.rdoMrrDetailsReport.TabIndex = 33;
            this.rdoMrrDetailsReport.Text = "GRN Details Report";
            this.rdoMrrDetailsReport.UseVisualStyleBackColor = false;
            this.rdoMrrDetailsReport.CheckedChanged += new System.EventHandler(this.rdoMrrDetailsReport_CheckedChanged_1);
            // 
            // rdoPOReportDateWise
            // 
            this.rdoPOReportDateWise.AutoSize = true;
            this.rdoPOReportDateWise.BackColor = System.Drawing.Color.Transparent;
            this.rdoPOReportDateWise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPOReportDateWise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPOReportDateWise.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPOReportDateWise.ForeColor = System.Drawing.Color.Gray;
            this.rdoPOReportDateWise.Location = new System.Drawing.Point(14, 93);
            this.rdoPOReportDateWise.Name = "rdoPOReportDateWise";
            this.rdoPOReportDateWise.Size = new System.Drawing.Size(170, 22);
            this.rdoPOReportDateWise.TabIndex = 32;
            this.rdoPOReportDateWise.Text = "PO Report(DateWise)";
            this.rdoPOReportDateWise.UseVisualStyleBackColor = false;
            this.rdoPOReportDateWise.CheckedChanged += new System.EventHandler(this.rdoPOReportDateWise_CheckedChanged_1);
            // 
            // rdoPODetails
            // 
            this.rdoPODetails.AutoSize = true;
            this.rdoPODetails.BackColor = System.Drawing.Color.Transparent;
            this.rdoPODetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPODetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPODetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPODetails.ForeColor = System.Drawing.Color.Gray;
            this.rdoPODetails.Location = new System.Drawing.Point(14, 58);
            this.rdoPODetails.Name = "rdoPODetails";
            this.rdoPODetails.Size = new System.Drawing.Size(95, 22);
            this.rdoPODetails.TabIndex = 31;
            this.rdoPODetails.Text = "PO Details";
            this.rdoPODetails.UseVisualStyleBackColor = false;
            this.rdoPODetails.CheckedChanged += new System.EventHandler(this.rdoPODetails_CheckedChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rdoSalesRetDetails);
            this.tabPage3.Controls.Add(this.rdoSalesRetReport);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.rdoSalesDetails);
            this.tabPage3.Controls.Add(this.rdoSales);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(399, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(4, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 2);
            this.panel4.TabIndex = 38;
            // 
            // rdoSalesDetails
            // 
            this.rdoSalesDetails.AutoSize = true;
            this.rdoSalesDetails.BackColor = System.Drawing.Color.Transparent;
            this.rdoSalesDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSalesDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoSalesDetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoSalesDetails.ForeColor = System.Drawing.Color.Gray;
            this.rdoSalesDetails.Location = new System.Drawing.Point(15, 60);
            this.rdoSalesDetails.Name = "rdoSalesDetails";
            this.rdoSalesDetails.Size = new System.Drawing.Size(156, 22);
            this.rdoSalesDetails.TabIndex = 18;
            this.rdoSalesDetails.Text = "Sales Report Details";
            this.rdoSalesDetails.UseVisualStyleBackColor = false;
            this.rdoSalesDetails.CheckedChanged += new System.EventHandler(this.rdoSalesDetails_CheckedChanged);
            // 
            // rdoSales
            // 
            this.rdoSales.AutoSize = true;
            this.rdoSales.BackColor = System.Drawing.Color.Transparent;
            this.rdoSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoSales.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoSales.ForeColor = System.Drawing.Color.Gray;
            this.rdoSales.Location = new System.Drawing.Point(15, 17);
            this.rdoSales.Name = "rdoSales";
            this.rdoSales.Size = new System.Drawing.Size(107, 22);
            this.rdoSales.TabIndex = 17;
            this.rdoSales.Text = "Sales Report";
            this.rdoSales.UseVisualStyleBackColor = false;
            this.rdoSales.CheckedChanged += new System.EventHandler(this.rdoSales_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Controls.Add(this.rdoExpireDate);
            this.tabPage4.Controls.Add(this.rdoItemRatesHistory);
            this.tabPage4.Controls.Add(this.rdoItemRates);
            this.tabPage4.Controls.Add(this.rdoProductLedger);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(399, 505);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ledger";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(3, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(395, 2);
            this.panel5.TabIndex = 38;
            // 
            // rdoExpireDate
            // 
            this.rdoExpireDate.AutoSize = true;
            this.rdoExpireDate.BackColor = System.Drawing.Color.Transparent;
            this.rdoExpireDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoExpireDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoExpireDate.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoExpireDate.ForeColor = System.Drawing.Color.Gray;
            this.rdoExpireDate.Location = new System.Drawing.Point(12, 131);
            this.rdoExpireDate.Name = "rdoExpireDate";
            this.rdoExpireDate.Size = new System.Drawing.Size(148, 22);
            this.rdoExpireDate.TabIndex = 30;
            this.rdoExpireDate.Text = "ExpireDate Report";
            this.rdoExpireDate.UseVisualStyleBackColor = false;
            this.rdoExpireDate.CheckedChanged += new System.EventHandler(this.rdoExpireDate_CheckedChanged_1);
            // 
            // rdoItemRatesHistory
            // 
            this.rdoItemRatesHistory.AutoSize = true;
            this.rdoItemRatesHistory.BackColor = System.Drawing.Color.Transparent;
            this.rdoItemRatesHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoItemRatesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoItemRatesHistory.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoItemRatesHistory.ForeColor = System.Drawing.Color.Gray;
            this.rdoItemRatesHistory.Location = new System.Drawing.Point(12, 91);
            this.rdoItemRatesHistory.Name = "rdoItemRatesHistory";
            this.rdoItemRatesHistory.Size = new System.Drawing.Size(152, 22);
            this.rdoItemRatesHistory.TabIndex = 29;
            this.rdoItemRatesHistory.Text = "Item Rates History";
            this.rdoItemRatesHistory.UseVisualStyleBackColor = false;
            this.rdoItemRatesHistory.CheckedChanged += new System.EventHandler(this.rdoItemRatesHistory_CheckedChanged_1);
            // 
            // rdoItemRates
            // 
            this.rdoItemRates.AutoSize = true;
            this.rdoItemRates.BackColor = System.Drawing.Color.Transparent;
            this.rdoItemRates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoItemRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoItemRates.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoItemRates.ForeColor = System.Drawing.Color.Gray;
            this.rdoItemRates.Location = new System.Drawing.Point(12, 53);
            this.rdoItemRates.Name = "rdoItemRates";
            this.rdoItemRates.Size = new System.Drawing.Size(99, 22);
            this.rdoItemRates.TabIndex = 28;
            this.rdoItemRates.Text = "Item Rates";
            this.rdoItemRates.UseVisualStyleBackColor = false;
            this.rdoItemRates.CheckedChanged += new System.EventHandler(this.rdoItemRates_CheckedChanged_1);
            // 
            // rdoProductLedger
            // 
            this.rdoProductLedger.AutoSize = true;
            this.rdoProductLedger.BackColor = System.Drawing.Color.Transparent;
            this.rdoProductLedger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoProductLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoProductLedger.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoProductLedger.ForeColor = System.Drawing.Color.Gray;
            this.rdoProductLedger.Location = new System.Drawing.Point(12, 17);
            this.rdoProductLedger.Name = "rdoProductLedger";
            this.rdoProductLedger.Size = new System.Drawing.Size(126, 22);
            this.rdoProductLedger.TabIndex = 27;
            this.rdoProductLedger.Text = "Product Ledger";
            this.rdoProductLedger.UseVisualStyleBackColor = false;
            this.rdoProductLedger.CheckedChanged += new System.EventHandler(this.rdoProductLedger_CheckedChanged_1);
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Location = new System.Drawing.Point(502, 451);
            this.gbDateRange.Name = "gbDateRange";
            this.gbDateRange.Size = new System.Drawing.Size(433, 114);
            this.gbDateRange.TabIndex = 16;
            this.gbDateRange.TabStop = false;
            this.gbDateRange.Text = "DateRange";
            // 
            // cboDateType
            // 
            this.cboDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDateType.ForeColor = System.Drawing.Color.Blue;
            this.cboDateType.FormattingEnabled = true;
            this.cboDateType.Items.AddRange(new object[] {
            "Select Date",
            "Last One Month",
            "Last Three Month",
            "Last Six Month",
            "Last One Year"});
            this.cboDateType.Location = new System.Drawing.Point(114, 29);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(300, 26);
            this.cboDateType.TabIndex = 5;
            this.cboDateType.SelectedIndexChanged += new System.EventHandler(this.cboDateType_SelectedIndexChanged);
            // 
            // lvlDate
            // 
            this.lvlDate.AutoSize = true;
            this.lvlDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlDate.Location = new System.Drawing.Point(16, 33);
            this.lvlDate.Name = "lvlDate";
            this.lvlDate.Size = new System.Drawing.Size(70, 15);
            this.lvlDate.TabIndex = 4;
            this.lvlDate.Text = "Date Range";
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(31, 73);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(63, 15);
            this.lvlStartDate.TabIndex = 2;
            this.lvlStartDate.Text = "Start Date";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(232, 73);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(55, 15);
            this.lvlEndDate.TabIndex = 3;
            this.lvlEndDate.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDate.Location = new System.Drawing.Point(302, 73);
            this.dtEndDate.Mask = "00/00/0000";
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(112, 24);
            this.dtEndDate.TabIndex = 1;
            this.dtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtStartDate
            // 
            this.dtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDate.Location = new System.Drawing.Point(113, 73);
            this.dtStartDate.Mask = "00/00/0000";
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(112, 24);
            this.dtStartDate.TabIndex = 0;
            this.dtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.BackColor = System.Drawing.Color.Transparent;
            this.lblParam2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam2.Location = new System.Drawing.Point(524, 56);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(50, 15);
            this.lblParam2.TabIndex = 4;
            this.lblParam2.Text = "Param2";
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.BackColor = System.Drawing.Color.Transparent;
            this.lblParam3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam3.Location = new System.Drawing.Point(524, 86);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(50, 15);
            this.lblParam3.TabIndex = 4;
            this.lblParam3.Text = "Param3";
            // 
            // cboParam2
            // 
            this.cboParam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParam2.ForeColor = System.Drawing.Color.Blue;
            this.cboParam2.FormattingEnabled = true;
            this.cboParam2.Items.AddRange(new object[] {
            "S01012014-0000008",
            "S01012014-00026",
            "0005"});
            this.cboParam2.Location = new System.Drawing.Point(620, 54);
            this.cboParam2.Name = "cboParam2";
            this.cboParam2.Size = new System.Drawing.Size(304, 26);
            this.cboParam2.TabIndex = 5;
            // 
            // cboParam3
            // 
            this.cboParam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParam3.ForeColor = System.Drawing.Color.Blue;
            this.cboParam3.FormattingEnabled = true;
            this.cboParam3.Items.AddRange(new object[] {
            "0001"});
            this.cboParam3.Location = new System.Drawing.Point(620, 84);
            this.cboParam3.Name = "cboParam3";
            this.cboParam3.Size = new System.Drawing.Size(304, 26);
            this.cboParam3.TabIndex = 5;
            // 
            // cboCompany
            // 
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompany.ForeColor = System.Drawing.Color.Blue;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Items.AddRange(new object[] {
            "R0114-0000004",
            "R0114-0000005",
            "R0114-0000006",
            "R0114-0000007"});
            this.cboCompany.Location = new System.Drawing.Point(621, 24);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(304, 26);
            this.cboCompany.TabIndex = 5;
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(525, 24);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(50, 15);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Param1";
            // 
            // txtIssueID
            // 
            this.txtIssueID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueID.Location = new System.Drawing.Point(619, 113);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(304, 24);
            this.txtIssueID.TabIndex = 6;
            this.txtIssueID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIssueID_KeyDown);
            this.txtIssueID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIssueID_KeyPress);
            // 
            // lblParam4
            // 
            this.lblParam4.AutoSize = true;
            this.lblParam4.BackColor = System.Drawing.Color.Transparent;
            this.lblParam4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam4.Location = new System.Drawing.Point(523, 116);
            this.lblParam4.Name = "lblParam4";
            this.lblParam4.Size = new System.Drawing.Size(50, 15);
            this.lblParam4.TabIndex = 7;
            this.lblParam4.Text = "Param4";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(619, 139);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(304, 24);
            this.txtProductName.TabIndex = 48;
            // 
            // lblParam5
            // 
            this.lblParam5.AutoSize = true;
            this.lblParam5.BackColor = System.Drawing.Color.Transparent;
            this.lblParam5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam5.Location = new System.Drawing.Point(522, 142);
            this.lblParam5.Name = "lblParam5";
            this.lblParam5.Size = new System.Drawing.Size(50, 15);
            this.lblParam5.TabIndex = 49;
            this.lblParam5.Text = "Param5";
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Location = new System.Drawing.Point(51, 641);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(166, 23);
            this.gbInformationControlls.TabIndex = 15;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            this.gbInformationControlls.Visible = false;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AllowUserToOrderColumns = true;
            this.dgvProductList.AllowUserToResizeColumns = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductList.Location = new System.Drawing.Point(620, 206);
            this.dgvProductList.MultiSelect = false;
            this.dgvProductList.Name = "dgvProductList";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductList.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvProductList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(260, 31);
            this.dgvProductList.TabIndex = 59;
            this.dgvProductList.TabStop = false;
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            this.dgvProductList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProductList_KeyPress);
            // 
            // gbNextDateRange
            // 
            this.gbNextDateRange.Controls.Add(this.cboDateTypefrom);
            this.gbNextDateRange.Controls.Add(this.smartLabel1);
            this.gbNextDateRange.Controls.Add(this.smartLabel2);
            this.gbNextDateRange.Controls.Add(this.smartLabel3);
            this.gbNextDateRange.Controls.Add(this.dtEndDay);
            this.gbNextDateRange.Controls.Add(this.dtStartDay);
            this.gbNextDateRange.Location = new System.Drawing.Point(503, 331);
            this.gbNextDateRange.Name = "gbNextDateRange";
            this.gbNextDateRange.Size = new System.Drawing.Size(433, 114);
            this.gbNextDateRange.TabIndex = 60;
            this.gbNextDateRange.TabStop = false;
            this.gbNextDateRange.Text = "DateRange";
            // 
            // cboDateTypefrom
            // 
            this.cboDateTypefrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateTypefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDateTypefrom.ForeColor = System.Drawing.Color.Blue;
            this.cboDateTypefrom.FormattingEnabled = true;
            this.cboDateTypefrom.Items.AddRange(new object[] {
            "Select Date",
            "Next One Month",
            "Next One Week",
            "Next Six Month",
            "Next One Year"});
            this.cboDateTypefrom.Location = new System.Drawing.Point(114, 29);
            this.cboDateTypefrom.Name = "cboDateTypefrom";
            this.cboDateTypefrom.Size = new System.Drawing.Size(300, 26);
            this.cboDateTypefrom.TabIndex = 5;
            this.cboDateTypefrom.SelectedIndexChanged += new System.EventHandler(this.cboDateTypefrom_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(16, 33);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(70, 15);
            this.smartLabel1.TabIndex = 4;
            this.smartLabel1.Text = "Date Range";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(31, 73);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(63, 15);
            this.smartLabel2.TabIndex = 2;
            this.smartLabel2.Text = "Start Date";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(232, 73);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(55, 15);
            this.smartLabel3.TabIndex = 3;
            this.smartLabel3.Text = "End Date";
            // 
            // dtEndDay
            // 
            this.dtEndDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtEndDay.Culture = new System.Globalization.CultureInfo("en-GB");
            this.dtEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtEndDay.Location = new System.Drawing.Point(302, 73);
            this.dtEndDay.Mask = "00/00/0000";
            this.dtEndDay.Name = "dtEndDay";
            this.dtEndDay.Size = new System.Drawing.Size(112, 24);
            this.dtEndDay.TabIndex = 1;
            this.dtEndDay.ValidatingType = typeof(System.DateTime);
            // 
            // dtStartDay
            // 
            this.dtStartDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtStartDay.Culture = new System.Globalization.CultureInfo("en-GB");
            this.dtStartDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtStartDay.Location = new System.Drawing.Point(113, 73);
            this.dtStartDay.Mask = "00/00/0000";
            this.dtStartDay.Name = "dtStartDay";
            this.dtStartDay.Size = new System.Drawing.Size(112, 24);
            this.dtStartDay.TabIndex = 0;
            this.dtStartDay.ValidatingType = typeof(System.DateTime);
            // 
            // txtParam1
            // 
            this.txtParam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam1.Location = new System.Drawing.Point(619, 169);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(304, 24);
            this.txtParam1.TabIndex = 61;
            this.txtParam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParam1_KeyPress);
            // 
            // txtParam2
            // 
            this.txtParam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam2.Location = new System.Drawing.Point(619, 243);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(304, 24);
            this.txtParam2.TabIndex = 62;
            this.txtParam2.TextChanged += new System.EventHandler(this.txtParam2_TextChanged);
            this.txtParam2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParam2_KeyDown);
            // 
            // rdoSalesRetReport
            // 
            this.rdoSalesRetReport.AutoSize = true;
            this.rdoSalesRetReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoSalesRetReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSalesRetReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoSalesRetReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoSalesRetReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoSalesRetReport.Location = new System.Drawing.Point(15, 101);
            this.rdoSalesRetReport.Name = "rdoSalesRetReport";
            this.rdoSalesRetReport.Size = new System.Drawing.Size(158, 22);
            this.rdoSalesRetReport.TabIndex = 39;
            this.rdoSalesRetReport.Text = "Sales Return Report";
            this.rdoSalesRetReport.UseVisualStyleBackColor = false;
            this.rdoSalesRetReport.CheckedChanged += new System.EventHandler(this.rdoSalesRetReport_CheckedChanged);
            // 
            // rdoSalesRetDetails
            // 
            this.rdoSalesRetDetails.AutoSize = true;
            this.rdoSalesRetDetails.BackColor = System.Drawing.Color.Transparent;
            this.rdoSalesRetDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSalesRetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoSalesRetDetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoSalesRetDetails.ForeColor = System.Drawing.Color.Gray;
            this.rdoSalesRetDetails.Location = new System.Drawing.Point(15, 145);
            this.rdoSalesRetDetails.Name = "rdoSalesRetDetails";
            this.rdoSalesRetDetails.Size = new System.Drawing.Size(207, 22);
            this.rdoSalesRetDetails.TabIndex = 40;
            this.rdoSalesRetDetails.Text = "Sales Return Report Details";
            this.rdoSalesRetDetails.UseVisualStyleBackColor = false;
            this.rdoSalesRetDetails.CheckedChanged += new System.EventHandler(this.rdoSalesRetDetails_CheckedChanged);
            // 
            // frmPHRMSReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(948, 694);
            this.Controls.Add(this.gbInformationControlls);
            this.KeyPreview = false;
            this.Name = "frmPHRMSReportManager";
            this.Load += new System.EventHandler(this.frmDRSReportManager_Load);
            this.Controls.SetChildIndex(this.gbInformationControlls, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.gbReportOption.ResumeLayout(false);
            this.tabSelection.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.gbNextDateRange.ResumeLayout(false);
            this.gbNextDateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReportOption;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartLabel lblParam5;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartTextBox txtProductName;
        private AtiqsControlLibrary.SmartLabel lblParam4;
        private AtiqsControlLibrary.SmartComboBox cboCompany;
        private AtiqsControlLibrary.SmartTextBox txtIssueID;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private AtiqsControlLibrary.SmartComboBox cboParam3;
        private AtiqsControlLibrary.SmartLabel lblParam3;
        private AtiqsControlLibrary.SmartComboBox cboParam2;
        private AtiqsControlLibrary.SmartLabel lblParam2;
        private AtiqsControlLibrary.SmartDataGridView dgvProductList;
        private System.Windows.Forms.GroupBox gbNextDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateTypefrom;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDay;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDay;
        private AtiqsControlLibrary.SmartTextBox txtParam1;
        private AtiqsControlLibrary.SmartTab tabSelection;
        private System.Windows.Forms.TabPage tabPage1;
        private AtiqsControlLibrary.SmartRadioButton rdoStockDetails;
        private AtiqsControlLibrary.SmartRadioButton rdoStockList;
        private AtiqsControlLibrary.SmartRadioButton rdoProductList;
        private System.Windows.Forms.TabPage tabPage2;
        private AtiqsControlLibrary.SmartRadioButton rdoOpeningReport;
        private AtiqsControlLibrary.SmartRadioButton rdoPRReport;
        private AtiqsControlLibrary.SmartRadioButton rdoMrrReport;
        private AtiqsControlLibrary.SmartRadioButton rdoMrrDetailsReport;
        private AtiqsControlLibrary.SmartRadioButton rdoPOReportDateWise;
        private AtiqsControlLibrary.SmartRadioButton rdoPODetails;
        private System.Windows.Forms.TabPage tabPage3;
        private AtiqsControlLibrary.SmartRadioButton rdoSalesDetails;
        private AtiqsControlLibrary.SmartRadioButton rdoSales;
        private System.Windows.Forms.TabPage tabPage4;
        private AtiqsControlLibrary.SmartRadioButton rdoExpireDate;
        private AtiqsControlLibrary.SmartRadioButton rdoItemRatesHistory;
        private AtiqsControlLibrary.SmartRadioButton rdoItemRates;
        private AtiqsControlLibrary.SmartRadioButton rdoProductLedger;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private AtiqsControlLibrary.SmartTextBox txtParam2;
        private AtiqsControlLibrary.SmartRadioButton rdoSalesRetReport;
        private AtiqsControlLibrary.SmartRadioButton rdoSalesRetDetails;
    }
}
