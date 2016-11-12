namespace AH.ModuleController.UI.InvMS.Reports.ParameterForms
{
    partial class frmInvMSReportManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbReportOption = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabselector = new AtiqsControlLibrary.SmartTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdoItemList = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoItemStrtypeGrpwise = new AtiqsControlLibrary.SmartRadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdoDrReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoGRNReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPOReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPrReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoPOReportDateWise = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoOpeningReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoMrrReport = new AtiqsControlLibrary.SmartRadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rdoIssueReportGroupwise = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoIssueReportDatewise = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoIssueReport = new AtiqsControlLibrary.SmartRadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rdoProductLedger = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoStockReport = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoStockReportGroupwise = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoStockDetailsReport = new AtiqsControlLibrary.SmartRadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rdoPOTerms = new AtiqsControlLibrary.SmartRadioButton();
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
            this.cboParam1 = new AtiqsControlLibrary.SmartComboBox();
            this.lblParam1 = new AtiqsControlLibrary.SmartLabel();
            this.txtParam1 = new AtiqsControlLibrary.SmartTextBox();
            this.lblParam4 = new AtiqsControlLibrary.SmartLabel();
            this.txtParam2 = new AtiqsControlLibrary.SmartTextBox();
            this.lblParam5 = new AtiqsControlLibrary.SmartLabel();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.dgvItemList = new AtiqsControlLibrary.SmartDataGridView();
            this.txtParam3 = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblParam6 = new AtiqsControlLibrary.SmartLabel();
            this.cboParam4 = new AtiqsControlLibrary.SmartComboBox();
            this.lblParam7 = new AtiqsControlLibrary.SmartLabel();
            this.cboParam5 = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbReportOption.SuspendLayout();
            this.tabselector.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbDateRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(853, 630);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(739, 630);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(355, 9);
            this.frmLabel.Size = new System.Drawing.Size(223, 32);
            this.frmLabel.Text = "Inventory Report";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboParam5);
            this.pnlMain.Controls.Add(this.dgvItemList);
            this.pnlMain.Controls.Add(this.lblParam7);
            this.pnlMain.Controls.Add(this.lblParam6);
            this.pnlMain.Controls.Add(this.txtParam3);
            this.pnlMain.Controls.Add(this.lblParam5);
            this.pnlMain.Controls.Add(this.gbDateRange);
            this.pnlMain.Controls.Add(this.txtParam2);
            this.pnlMain.Controls.Add(this.gbReportOption);
            this.pnlMain.Controls.Add(this.lblParam4);
            this.pnlMain.Controls.Add(this.cboParam1);
            this.pnlMain.Controls.Add(this.txtParam1);
            this.pnlMain.Controls.Add(this.lblParam1);
            this.pnlMain.Controls.Add(this.cboParam3);
            this.pnlMain.Controls.Add(this.lblParam3);
            this.pnlMain.Controls.Add(this.cboParam2);
            this.pnlMain.Controls.Add(this.lblParam2);
            this.pnlMain.Controls.Add(this.cboParam4);
            this.pnlMain.Location = new System.Drawing.Point(0, 53);
            this.pnlMain.Size = new System.Drawing.Size(965, 574);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            this.pnlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseClick);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(965, 51);
            // 
            // gbReportOption
            // 
            this.gbReportOption.Controls.Add(this.panel2);
            this.gbReportOption.Controls.Add(this.tabselector);
            this.gbReportOption.Location = new System.Drawing.Point(3, 7);
            this.gbReportOption.Name = "gbReportOption";
            this.gbReportOption.Size = new System.Drawing.Size(463, 557);
            this.gbReportOption.TabIndex = 8;
            this.gbReportOption.TabStop = false;
            this.gbReportOption.Text = "Report Option";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 2);
            this.panel2.TabIndex = 65;
            // 
            // tabselector
            // 
            this.tabselector.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabselector.Controls.Add(this.tabPage1);
            this.tabselector.Controls.Add(this.tabPage2);
            this.tabselector.Controls.Add(this.tabPage3);
            this.tabselector.Controls.Add(this.tabPage4);
            this.tabselector.Controls.Add(this.tabPage5);
            this.tabselector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabselector.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabselector.Location = new System.Drawing.Point(8, 21);
            this.tabselector.Name = "tabselector";
            this.tabselector.SelectedIndex = 0;
            this.tabselector.Size = new System.Drawing.Size(446, 530);
            this.tabselector.TabIndex = 65;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.rdoItemList);
            this.tabPage1.Controls.Add(this.rdoItemStrtypeGrpwise);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            // 
            // rdoItemList
            // 
            this.rdoItemList.AutoSize = true;
            this.rdoItemList.BackColor = System.Drawing.Color.Transparent;
            this.rdoItemList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoItemList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoItemList.ForeColor = System.Drawing.Color.Gray;
            this.rdoItemList.Location = new System.Drawing.Point(13, 24);
            this.rdoItemList.Name = "rdoItemList";
            this.rdoItemList.Size = new System.Drawing.Size(162, 22);
            this.rdoItemList.TabIndex = 14;
            this.rdoItemList.Text = "Groupwise Item List";
            this.rdoItemList.UseVisualStyleBackColor = false;
            this.rdoItemList.CheckedChanged += new System.EventHandler(this.rdoItemList_CheckedChanged);
            // 
            // rdoItemStrtypeGrpwise
            // 
            this.rdoItemStrtypeGrpwise.AutoSize = true;
            this.rdoItemStrtypeGrpwise.BackColor = System.Drawing.Color.Transparent;
            this.rdoItemStrtypeGrpwise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoItemStrtypeGrpwise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoItemStrtypeGrpwise.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoItemStrtypeGrpwise.ForeColor = System.Drawing.Color.Gray;
            this.rdoItemStrtypeGrpwise.Location = new System.Drawing.Point(13, 64);
            this.rdoItemStrtypeGrpwise.Name = "rdoItemStrtypeGrpwise";
            this.rdoItemStrtypeGrpwise.Size = new System.Drawing.Size(262, 22);
            this.rdoItemStrtypeGrpwise.TabIndex = 33;
            this.rdoItemStrtypeGrpwise.Text = "Item List(Store Type && GroupWise)";
            this.rdoItemStrtypeGrpwise.UseVisualStyleBackColor = false;
            this.rdoItemStrtypeGrpwise.CheckedChanged += new System.EventHandler(this.rdoItemStrtypeGrpwise_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rdoDrReport);
            this.tabPage2.Controls.Add(this.rdoGRNReport);
            this.tabPage2.Controls.Add(this.rdoPOReport);
            this.tabPage2.Controls.Add(this.rdoPrReport);
            this.tabPage2.Controls.Add(this.rdoPOReportDateWise);
            this.tabPage2.Controls.Add(this.rdoOpeningReport);
            this.tabPage2.Controls.Add(this.rdoMrrReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transaction";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdoDrReport
            // 
            this.rdoDrReport.AutoSize = true;
            this.rdoDrReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoDrReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDrReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDrReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDrReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoDrReport.Location = new System.Drawing.Point(17, 18);
            this.rdoDrReport.Name = "rdoDrReport";
            this.rdoDrReport.Size = new System.Drawing.Size(96, 22);
            this.rdoDrReport.TabIndex = 36;
            this.rdoDrReport.Text = "DR Report";
            this.rdoDrReport.UseVisualStyleBackColor = false;
            this.rdoDrReport.CheckedChanged += new System.EventHandler(this.rdoDrReport_CheckedChanged);
            // 
            // rdoGRNReport
            // 
            this.rdoGRNReport.AutoSize = true;
            this.rdoGRNReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoGRNReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoGRNReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoGRNReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoGRNReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoGRNReport.Location = new System.Drawing.Point(17, 178);
            this.rdoGRNReport.Name = "rdoGRNReport";
            this.rdoGRNReport.Size = new System.Drawing.Size(181, 22);
            this.rdoGRNReport.TabIndex = 35;
            this.rdoGRNReport.Text = "GRN Report(Datewise)";
            this.rdoGRNReport.UseVisualStyleBackColor = false;
            this.rdoGRNReport.CheckedChanged += new System.EventHandler(this.rdoGRNReport_CheckedChanged);
            // 
            // rdoPOReport
            // 
            this.rdoPOReport.AutoSize = true;
            this.rdoPOReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoPOReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPOReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPOReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPOReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoPOReport.Location = new System.Drawing.Point(17, 82);
            this.rdoPOReport.Name = "rdoPOReport";
            this.rdoPOReport.Size = new System.Drawing.Size(95, 22);
            this.rdoPOReport.TabIndex = 27;
            this.rdoPOReport.Text = "PO Report";
            this.rdoPOReport.UseVisualStyleBackColor = false;
            this.rdoPOReport.CheckedChanged += new System.EventHandler(this.rdoPOReport_CheckedChanged);
            // 
            // rdoPrReport
            // 
            this.rdoPrReport.AutoSize = true;
            this.rdoPrReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoPrReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPrReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPrReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPrReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoPrReport.Location = new System.Drawing.Point(17, 51);
            this.rdoPrReport.Name = "rdoPrReport";
            this.rdoPrReport.Size = new System.Drawing.Size(94, 22);
            this.rdoPrReport.TabIndex = 34;
            this.rdoPrReport.Text = "PR Report";
            this.rdoPrReport.UseVisualStyleBackColor = false;
            this.rdoPrReport.CheckedChanged += new System.EventHandler(this.rdoPrReport_CheckedChanged);
            // 
            // rdoPOReportDateWise
            // 
            this.rdoPOReportDateWise.AutoSize = true;
            this.rdoPOReportDateWise.BackColor = System.Drawing.Color.Transparent;
            this.rdoPOReportDateWise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPOReportDateWise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPOReportDateWise.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPOReportDateWise.ForeColor = System.Drawing.Color.Gray;
            this.rdoPOReportDateWise.Location = new System.Drawing.Point(17, 112);
            this.rdoPOReportDateWise.Name = "rdoPOReportDateWise";
            this.rdoPOReportDateWise.Size = new System.Drawing.Size(170, 22);
            this.rdoPOReportDateWise.TabIndex = 25;
            this.rdoPOReportDateWise.Text = "PO Report(DateWise)";
            this.rdoPOReportDateWise.UseVisualStyleBackColor = false;
            this.rdoPOReportDateWise.CheckedChanged += new System.EventHandler(this.rdoPOReportDateWise_CheckedChanged);
            // 
            // rdoOpeningReport
            // 
            this.rdoOpeningReport.AutoSize = true;
            this.rdoOpeningReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoOpeningReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOpeningReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoOpeningReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoOpeningReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoOpeningReport.Location = new System.Drawing.Point(17, 211);
            this.rdoOpeningReport.Name = "rdoOpeningReport";
            this.rdoOpeningReport.Size = new System.Drawing.Size(131, 22);
            this.rdoOpeningReport.TabIndex = 29;
            this.rdoOpeningReport.Text = "Opening Report";
            this.rdoOpeningReport.UseVisualStyleBackColor = false;
            this.rdoOpeningReport.CheckedChanged += new System.EventHandler(this.rdoOpeningReport_CheckedChanged);
            // 
            // rdoMrrReport
            // 
            this.rdoMrrReport.AutoSize = true;
            this.rdoMrrReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoMrrReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMrrReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMrrReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoMrrReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoMrrReport.Location = new System.Drawing.Point(17, 145);
            this.rdoMrrReport.Name = "rdoMrrReport";
            this.rdoMrrReport.Size = new System.Drawing.Size(109, 22);
            this.rdoMrrReport.TabIndex = 28;
            this.rdoMrrReport.Text = "GRN Report";
            this.rdoMrrReport.UseVisualStyleBackColor = false;
            this.rdoMrrReport.CheckedChanged += new System.EventHandler(this.rdoMrrReport_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rdoIssueReportGroupwise);
            this.tabPage3.Controls.Add(this.rdoIssueReportDatewise);
            this.tabPage3.Controls.Add(this.rdoIssueReport);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(438, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rdoIssueReportGroupwise
            // 
            this.rdoIssueReportGroupwise.AutoSize = true;
            this.rdoIssueReportGroupwise.BackColor = System.Drawing.Color.Transparent;
            this.rdoIssueReportGroupwise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoIssueReportGroupwise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoIssueReportGroupwise.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoIssueReportGroupwise.ForeColor = System.Drawing.Color.Gray;
            this.rdoIssueReportGroupwise.Location = new System.Drawing.Point(19, 81);
            this.rdoIssueReportGroupwise.Name = "rdoIssueReportGroupwise";
            this.rdoIssueReportGroupwise.Size = new System.Drawing.Size(196, 22);
            this.rdoIssueReportGroupwise.TabIndex = 36;
            this.rdoIssueReportGroupwise.Text = "Issue Report(GroupWise)";
            this.rdoIssueReportGroupwise.UseVisualStyleBackColor = false;
            this.rdoIssueReportGroupwise.CheckedChanged += new System.EventHandler(this.rdoIssueReportGroupwise_CheckedChanged);
            // 
            // rdoIssueReportDatewise
            // 
            this.rdoIssueReportDatewise.AutoSize = true;
            this.rdoIssueReportDatewise.BackColor = System.Drawing.Color.Transparent;
            this.rdoIssueReportDatewise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoIssueReportDatewise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoIssueReportDatewise.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoIssueReportDatewise.ForeColor = System.Drawing.Color.Gray;
            this.rdoIssueReportDatewise.Location = new System.Drawing.Point(19, 48);
            this.rdoIssueReportDatewise.Name = "rdoIssueReportDatewise";
            this.rdoIssueReportDatewise.Size = new System.Drawing.Size(184, 22);
            this.rdoIssueReportDatewise.TabIndex = 26;
            this.rdoIssueReportDatewise.Text = "Issue Report(DateWise)";
            this.rdoIssueReportDatewise.UseVisualStyleBackColor = false;
            this.rdoIssueReportDatewise.CheckedChanged += new System.EventHandler(this.rdoIssueReportDatewise_CheckedChanged);
            // 
            // rdoIssueReport
            // 
            this.rdoIssueReport.AutoSize = true;
            this.rdoIssueReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoIssueReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoIssueReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoIssueReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoIssueReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoIssueReport.Location = new System.Drawing.Point(19, 20);
            this.rdoIssueReport.Name = "rdoIssueReport";
            this.rdoIssueReport.Size = new System.Drawing.Size(109, 22);
            this.rdoIssueReport.TabIndex = 30;
            this.rdoIssueReport.Text = "Issue Report";
            this.rdoIssueReport.UseVisualStyleBackColor = false;
            this.rdoIssueReport.CheckedChanged += new System.EventHandler(this.rdoIssueReport_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rdoProductLedger);
            this.tabPage4.Controls.Add(this.rdoStockReport);
            this.tabPage4.Controls.Add(this.rdoStockReportGroupwise);
            this.tabPage4.Controls.Add(this.rdoStockDetailsReport);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(438, 495);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stock";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rdoProductLedger
            // 
            this.rdoProductLedger.AutoSize = true;
            this.rdoProductLedger.BackColor = System.Drawing.Color.Transparent;
            this.rdoProductLedger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoProductLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoProductLedger.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoProductLedger.ForeColor = System.Drawing.Color.Gray;
            this.rdoProductLedger.Location = new System.Drawing.Point(17, 145);
            this.rdoProductLedger.Name = "rdoProductLedger";
            this.rdoProductLedger.Size = new System.Drawing.Size(126, 22);
            this.rdoProductLedger.TabIndex = 36;
            this.rdoProductLedger.Text = "Product Ledger";
            this.rdoProductLedger.UseVisualStyleBackColor = false;
            this.rdoProductLedger.CheckedChanged += new System.EventHandler(this.rdoProductLedger_CheckedChanged_1);
            // 
            // rdoStockReport
            // 
            this.rdoStockReport.AutoSize = true;
            this.rdoStockReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoStockReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoStockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoStockReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoStockReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoStockReport.Location = new System.Drawing.Point(17, 29);
            this.rdoStockReport.Name = "rdoStockReport";
            this.rdoStockReport.Size = new System.Drawing.Size(110, 22);
            this.rdoStockReport.TabIndex = 23;
            this.rdoStockReport.Text = "Stock Report";
            this.rdoStockReport.UseVisualStyleBackColor = false;
            this.rdoStockReport.CheckedChanged += new System.EventHandler(this.rdoStockReport_CheckedChanged);
            // 
            // rdoStockReportGroupwise
            // 
            this.rdoStockReportGroupwise.AutoSize = true;
            this.rdoStockReportGroupwise.BackColor = System.Drawing.Color.Transparent;
            this.rdoStockReportGroupwise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoStockReportGroupwise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoStockReportGroupwise.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoStockReportGroupwise.ForeColor = System.Drawing.Color.Gray;
            this.rdoStockReportGroupwise.Location = new System.Drawing.Point(17, 108);
            this.rdoStockReportGroupwise.Name = "rdoStockReportGroupwise";
            this.rdoStockReportGroupwise.Size = new System.Drawing.Size(197, 22);
            this.rdoStockReportGroupwise.TabIndex = 35;
            this.rdoStockReportGroupwise.Text = "Stock Report(GroupWise)";
            this.rdoStockReportGroupwise.UseVisualStyleBackColor = false;
            this.rdoStockReportGroupwise.CheckedChanged += new System.EventHandler(this.rdoStockReportGroupwise_CheckedChanged);
            // 
            // rdoStockDetailsReport
            // 
            this.rdoStockDetailsReport.AutoSize = true;
            this.rdoStockDetailsReport.BackColor = System.Drawing.Color.Transparent;
            this.rdoStockDetailsReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoStockDetailsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoStockDetailsReport.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoStockDetailsReport.ForeColor = System.Drawing.Color.Gray;
            this.rdoStockDetailsReport.Location = new System.Drawing.Point(17, 67);
            this.rdoStockDetailsReport.Name = "rdoStockDetailsReport";
            this.rdoStockDetailsReport.Size = new System.Drawing.Size(159, 22);
            this.rdoStockDetailsReport.TabIndex = 31;
            this.rdoStockDetailsReport.Text = "Stock Details Report";
            this.rdoStockDetailsReport.UseVisualStyleBackColor = false;
            this.rdoStockDetailsReport.CheckedChanged += new System.EventHandler(this.rdoStockDetailsReport_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rdoPOTerms);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(438, 495);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Others";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // rdoPOTerms
            // 
            this.rdoPOTerms.AutoSize = true;
            this.rdoPOTerms.BackColor = System.Drawing.Color.Transparent;
            this.rdoPOTerms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPOTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPOTerms.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPOTerms.ForeColor = System.Drawing.Color.Gray;
            this.rdoPOTerms.Location = new System.Drawing.Point(26, 57);
            this.rdoPOTerms.Name = "rdoPOTerms";
            this.rdoPOTerms.Size = new System.Drawing.Size(191, 22);
            this.rdoPOTerms.TabIndex = 32;
            this.rdoPOTerms.Text = "PO Terms && Conditions :";
            this.rdoPOTerms.UseVisualStyleBackColor = false;
            this.rdoPOTerms.Visible = false;
            this.rdoPOTerms.CheckedChanged += new System.EventHandler(this.rdoPOTerms_CheckedChanged);
            // 
            // gbDateRange
            // 
            this.gbDateRange.Controls.Add(this.cboDateType);
            this.gbDateRange.Controls.Add(this.lvlDate);
            this.gbDateRange.Controls.Add(this.lvlStartDate);
            this.gbDateRange.Controls.Add(this.lvlEndDate);
            this.gbDateRange.Controls.Add(this.dtEndDate);
            this.gbDateRange.Controls.Add(this.dtStartDate);
            this.gbDateRange.Location = new System.Drawing.Point(523, 450);
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
            this.lblParam2.Location = new System.Drawing.Point(525, 47);
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
            this.lblParam3.Location = new System.Drawing.Point(525, 77);
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
            this.cboParam2.Location = new System.Drawing.Point(646, 43);
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
            this.cboParam3.Location = new System.Drawing.Point(646, 73);
            this.cboParam3.Name = "cboParam3";
            this.cboParam3.Size = new System.Drawing.Size(304, 26);
            this.cboParam3.TabIndex = 5;
            this.cboParam3.SelectedIndexChanged += new System.EventHandler(this.cboParam3_SelectedIndexChanged);
            // 
            // cboParam1
            // 
            this.cboParam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParam1.ForeColor = System.Drawing.Color.Blue;
            this.cboParam1.FormattingEnabled = true;
            this.cboParam1.Items.AddRange(new object[] {
            "R0114-0000004",
            "R0114-0000005",
            "R0114-0000006",
            "R0114-0000007"});
            this.cboParam1.Location = new System.Drawing.Point(646, 11);
            this.cboParam1.Name = "cboParam1";
            this.cboParam1.Size = new System.Drawing.Size(304, 26);
            this.cboParam1.TabIndex = 5;
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.BackColor = System.Drawing.Color.Transparent;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam1.Location = new System.Drawing.Point(526, 15);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(50, 15);
            this.lblParam1.TabIndex = 4;
            this.lblParam1.Text = "Param1";
            // 
            // txtParam1
            // 
            this.txtParam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam1.Location = new System.Drawing.Point(646, 164);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(304, 24);
            this.txtParam1.TabIndex = 6;
            this.txtParam1.TextChanged += new System.EventHandler(this.txtParam1_TextChanged);
            this.txtParam1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParam1_KeyDown);
            this.txtParam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParam1_KeyPress);
            // 
            // lblParam4
            // 
            this.lblParam4.AutoSize = true;
            this.lblParam4.BackColor = System.Drawing.Color.Transparent;
            this.lblParam4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam4.Location = new System.Drawing.Point(524, 167);
            this.lblParam4.Name = "lblParam4";
            this.lblParam4.Size = new System.Drawing.Size(50, 15);
            this.lblParam4.TabIndex = 7;
            this.lblParam4.Text = "Param4";
            // 
            // txtParam2
            // 
            this.txtParam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam2.Location = new System.Drawing.Point(646, 190);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(185, 24);
            this.txtParam2.TabIndex = 48;
            this.txtParam2.TextChanged += new System.EventHandler(this.txtParam2_TextChanged);
            this.txtParam2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParam2_KeyDown);
            // 
            // lblParam5
            // 
            this.lblParam5.AutoSize = true;
            this.lblParam5.BackColor = System.Drawing.Color.Transparent;
            this.lblParam5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam5.Location = new System.Drawing.Point(523, 193);
            this.lblParam5.Name = "lblParam5";
            this.lblParam5.Size = new System.Drawing.Size(50, 15);
            this.lblParam5.TabIndex = 49;
            this.lblParam5.Text = "Param5";
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Location = new System.Drawing.Point(70, 628);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(166, 34);
            this.gbInformationControlls.TabIndex = 15;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            this.gbInformationControlls.Visible = false;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.AllowUserToOrderColumns = true;
            this.dgvItemList.AllowUserToResizeColumns = false;
            this.dgvItemList.AllowUserToResizeRows = false;
            this.dgvItemList.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemList.Location = new System.Drawing.Point(646, 242);
            this.dgvItemList.MultiSelect = false;
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvItemList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(260, 31);
            this.dgvItemList.TabIndex = 59;
            this.dgvItemList.TabStop = false;
            this.dgvItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellClick);
            this.dgvItemList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvItemList_KeyPress);
            // 
            // txtParam3
            // 
            this.txtParam3.BackColor = System.Drawing.Color.Linen;
            this.txtParam3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtParam3.Location = new System.Drawing.Point(646, 217);
            this.txtParam3.Name = "txtParam3";
            this.txtParam3.ReadOnly = true;
            this.txtParam3.Size = new System.Drawing.Size(305, 24);
            this.txtParam3.TabIndex = 60;
            this.txtParam3.TabStop = false;
            // 
            // lblParam6
            // 
            this.lblParam6.AutoSize = true;
            this.lblParam6.BackColor = System.Drawing.Color.Transparent;
            this.lblParam6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam6.Location = new System.Drawing.Point(523, 223);
            this.lblParam6.Name = "lblParam6";
            this.lblParam6.Size = new System.Drawing.Size(50, 15);
            this.lblParam6.TabIndex = 61;
            this.lblParam6.Text = "Param6";
            // 
            // cboParam4
            // 
            this.cboParam4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParam4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParam4.ForeColor = System.Drawing.Color.Blue;
            this.cboParam4.FormattingEnabled = true;
            this.cboParam4.Items.AddRange(new object[] {
            "0001"});
            this.cboParam4.Location = new System.Drawing.Point(646, 104);
            this.cboParam4.Name = "cboParam4";
            this.cboParam4.Size = new System.Drawing.Size(305, 26);
            this.cboParam4.TabIndex = 63;
            // 
            // lblParam7
            // 
            this.lblParam7.AutoSize = true;
            this.lblParam7.BackColor = System.Drawing.Color.Transparent;
            this.lblParam7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblParam7.Location = new System.Drawing.Point(526, 108);
            this.lblParam7.Name = "lblParam7";
            this.lblParam7.Size = new System.Drawing.Size(50, 15);
            this.lblParam7.TabIndex = 62;
            this.lblParam7.Text = "Param7";
            // 
            // cboParam5
            // 
            this.cboParam5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParam5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParam5.ForeColor = System.Drawing.Color.Blue;
            this.cboParam5.FormattingEnabled = true;
            this.cboParam5.Items.AddRange(new object[] {
            "0001"});
            this.cboParam5.Location = new System.Drawing.Point(646, 134);
            this.cboParam5.Name = "cboParam5";
            this.cboParam5.Size = new System.Drawing.Size(305, 26);
            this.cboParam5.TabIndex = 64;
            // 
            // frmInvMSReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(965, 692);
            this.Controls.Add(this.gbInformationControlls);
            this.KeyPreview = false;
            this.Name = "frmInvMSReportManager";
            this.Load += new System.EventHandler(this.frmInvMSReportManager_Load);
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
            this.tabselector.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.gbDateRange.ResumeLayout(false);
            this.gbDateRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReportOption;
        private AtiqsControlLibrary.SmartRadioButton rdoItemList;
        private System.Windows.Forms.GroupBox gbDateRange;
        private AtiqsControlLibrary.SmartComboBox cboDateType;
        private AtiqsControlLibrary.SmartLabel lvlDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtEndDate;
        private AtiqsControlLibrary.SmartDateTextBox dtStartDate;
        private AtiqsControlLibrary.SmartLabel lblParam5;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartTextBox txtParam2;
        private AtiqsControlLibrary.SmartLabel lblParam4;
        private AtiqsControlLibrary.SmartComboBox cboParam1;
        private AtiqsControlLibrary.SmartTextBox txtParam1;
        private AtiqsControlLibrary.SmartLabel lblParam1;
        private AtiqsControlLibrary.SmartComboBox cboParam3;
        private AtiqsControlLibrary.SmartLabel lblParam3;
        private AtiqsControlLibrary.SmartComboBox cboParam2;
        private AtiqsControlLibrary.SmartLabel lblParam2;
        private AtiqsControlLibrary.SmartDataGridView dgvItemList;
        private AtiqsControlLibrary.SmartRadioButton rdoStockReport;
        private AtiqsControlLibrary.SmartRadioButton rdoPOReportDateWise;
        private AtiqsControlLibrary.SmartRadioButton rdoIssueReportDatewise;
        private AtiqsControlLibrary.SmartLabel lblParam6;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtParam3;
        private AtiqsControlLibrary.SmartRadioButton rdoPOReport;
        private AtiqsControlLibrary.SmartRadioButton rdoMrrReport;
        private AtiqsControlLibrary.SmartRadioButton rdoOpeningReport;
        private AtiqsControlLibrary.SmartRadioButton rdoIssueReport;
        private AtiqsControlLibrary.SmartRadioButton rdoStockDetailsReport;
        private AtiqsControlLibrary.SmartRadioButton rdoPOTerms;
        private AtiqsControlLibrary.SmartRadioButton rdoItemStrtypeGrpwise;
        private AtiqsControlLibrary.SmartComboBox cboParam4;
        private AtiqsControlLibrary.SmartLabel lblParam7;
        private AtiqsControlLibrary.SmartComboBox cboParam5;
        private AtiqsControlLibrary.SmartRadioButton rdoPrReport;
        private AtiqsControlLibrary.SmartRadioButton rdoStockReportGroupwise;
        private AtiqsControlLibrary.SmartRadioButton rdoIssueReportGroupwise;
        private AtiqsControlLibrary.SmartTab tabselector;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private AtiqsControlLibrary.SmartRadioButton rdoGRNReport;
        private System.Windows.Forms.Panel panel2;
        private AtiqsControlLibrary.SmartRadioButton rdoProductLedger;
        private AtiqsControlLibrary.SmartRadioButton rdoDrReport;
    }
}
