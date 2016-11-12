namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmVoucherArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucherArchive));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radFoodBeverage = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radUnpost = new System.Windows.Forms.RadioButton();
            this.radPost = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radAccounts = new System.Windows.Forms.RadioButton();
            this.radInvestigation = new System.Windows.Forms.RadioButton();
            this.radHrm = new System.Windows.Forms.RadioButton();
            this.radPharmacy = new System.Windows.Forms.RadioButton();
            this.radOPD = new System.Windows.Forms.RadioButton();
            this.radIPD = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkVoucher = new AtiqsControlLibrary.SmartCheckBox();
            this.chkLedger = new AtiqsControlLibrary.SmartCheckBox();
            this.cboLedgerName = new System.Windows.Forms.ComboBox();
            this.txtVoucherNo = new AtiqsControlLibrary.SmartTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dteTdate = new System.Windows.Forms.DateTimePicker();
            this.dteFdate = new System.Windows.Forms.DateTimePicker();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radContra = new System.Windows.Forms.RadioButton();
            this.radJournal = new System.Windows.Forms.RadioButton();
            this.radReceipt = new System.Windows.Forms.RadioButton();
            this.radPayment = new System.Windows.Forms.RadioButton();
            this.DG = new System.Windows.Forms.DataGridView();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lblDrTotal = new AtiqsControlLibrary.SmartLabel();
            this.lblCrTotal = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(454, 9);
            this.frmLabel.Size = new System.Drawing.Size(225, 33);
            this.frmLabel.Text = "Searching Archive";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblCrTotal);
            this.pnlMain.Controls.Add(this.lblDrTotal);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Size = new System.Drawing.Size(1243, 833);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1244, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(420, 752);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 752);
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(533, 752);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(194, 752);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1117, 752);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(644, 752);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 793);
            this.groupBox1.Size = new System.Drawing.Size(1244, 25);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.radFoodBeverage);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.radAccounts);
            this.groupBox2.Controls.Add(this.radInvestigation);
            this.groupBox2.Controls.Add(this.radHrm);
            this.groupBox2.Controls.Add(this.radPharmacy);
            this.groupBox2.Controls.Add(this.radOPD);
            this.groupBox2.Controls.Add(this.radIPD);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dteTdate);
            this.groupBox2.Controls.Add(this.dteFdate);
            this.groupBox2.Controls.Add(this.radAll);
            this.groupBox2.Controls.Add(this.radContra);
            this.groupBox2.Controls.Add(this.radJournal);
            this.groupBox2.Controls.Add(this.radReceipt);
            this.groupBox2.Controls.Add(this.radPayment);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1224, 170);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // radFoodBeverage
            // 
            this.radFoodBeverage.AutoSize = true;
            this.radFoodBeverage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFoodBeverage.ForeColor = System.Drawing.Color.Blue;
            this.radFoodBeverage.Location = new System.Drawing.Point(777, 21);
            this.radFoodBeverage.Name = "radFoodBeverage";
            this.radFoodBeverage.Size = new System.Drawing.Size(138, 20);
            this.radFoodBeverage.TabIndex = 133;
            this.radFoodBeverage.TabStop = true;
            this.radFoodBeverage.Text = "Food && Beverage";
            this.radFoodBeverage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radUnpost);
            this.groupBox4.Controls.Add(this.radPost);
            this.groupBox4.Location = new System.Drawing.Point(777, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 88);
            this.groupBox4.TabIndex = 132;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selection";
            // 
            // radUnpost
            // 
            this.radUnpost.AutoSize = true;
            this.radUnpost.Location = new System.Drawing.Point(30, 63);
            this.radUnpost.Name = "radUnpost";
            this.radUnpost.Size = new System.Drawing.Size(70, 18);
            this.radUnpost.TabIndex = 132;
            this.radUnpost.TabStop = true;
            this.radUnpost.Text = "Unpost";
            this.radUnpost.UseVisualStyleBackColor = true;
            this.radUnpost.CheckedChanged += new System.EventHandler(this.radUnpost_CheckedChanged);
            // 
            // radPost
            // 
            this.radPost.AutoSize = true;
            this.radPost.Checked = true;
            this.radPost.Location = new System.Drawing.Point(30, 24);
            this.radPost.Name = "radPost";
            this.radPost.Size = new System.Drawing.Size(53, 18);
            this.radPost.TabIndex = 131;
            this.radPost.TabStop = true;
            this.radPost.Text = "Post";
            this.radPost.UseVisualStyleBackColor = true;
            this.radPost.CheckedChanged += new System.EventHandler(this.radPost_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1002, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 40);
            this.btnSearch.TabIndex = 128;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radAccounts
            // 
            this.radAccounts.AutoSize = true;
            this.radAccounts.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAccounts.ForeColor = System.Drawing.Color.Blue;
            this.radAccounts.Location = new System.Drawing.Point(222, 21);
            this.radAccounts.Name = "radAccounts";
            this.radAccounts.Size = new System.Drawing.Size(88, 20);
            this.radAccounts.TabIndex = 15;
            this.radAccounts.TabStop = true;
            this.radAccounts.Text = "Accounts";
            this.radAccounts.UseVisualStyleBackColor = true;
            // 
            // radInvestigation
            // 
            this.radInvestigation.AutoSize = true;
            this.radInvestigation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInvestigation.ForeColor = System.Drawing.Color.Blue;
            this.radInvestigation.Location = new System.Drawing.Point(652, 21);
            this.radInvestigation.Name = "radInvestigation";
            this.radInvestigation.Size = new System.Drawing.Size(112, 20);
            this.radInvestigation.TabIndex = 14;
            this.radInvestigation.TabStop = true;
            this.radInvestigation.Text = "Investigation";
            this.radInvestigation.UseVisualStyleBackColor = true;
            // 
            // radHrm
            // 
            this.radHrm.AutoSize = true;
            this.radHrm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHrm.ForeColor = System.Drawing.Color.Blue;
            this.radHrm.Location = new System.Drawing.Point(562, 21);
            this.radHrm.Name = "radHrm";
            this.radHrm.Size = new System.Drawing.Size(54, 20);
            this.radHrm.TabIndex = 13;
            this.radHrm.TabStop = true;
            this.radHrm.Text = "HRM";
            this.radHrm.UseVisualStyleBackColor = true;
            // 
            // radPharmacy
            // 
            this.radPharmacy.AutoSize = true;
            this.radPharmacy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPharmacy.ForeColor = System.Drawing.Color.Blue;
            this.radPharmacy.Location = new System.Drawing.Point(463, 21);
            this.radPharmacy.Name = "radPharmacy";
            this.radPharmacy.Size = new System.Drawing.Size(90, 20);
            this.radPharmacy.TabIndex = 12;
            this.radPharmacy.TabStop = true;
            this.radPharmacy.Text = "Pharmacy";
            this.radPharmacy.UseVisualStyleBackColor = true;
            // 
            // radOPD
            // 
            this.radOPD.AutoSize = true;
            this.radOPD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOPD.ForeColor = System.Drawing.Color.Blue;
            this.radOPD.Location = new System.Drawing.Point(389, 21);
            this.radOPD.Name = "radOPD";
            this.radOPD.Size = new System.Drawing.Size(53, 20);
            this.radOPD.TabIndex = 11;
            this.radOPD.TabStop = true;
            this.radOPD.Text = "OPD";
            this.radOPD.UseVisualStyleBackColor = true;
            // 
            // radIPD
            // 
            this.radIPD.AutoSize = true;
            this.radIPD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIPD.ForeColor = System.Drawing.Color.Blue;
            this.radIPD.Location = new System.Drawing.Point(318, 21);
            this.radIPD.Name = "radIPD";
            this.radIPD.Size = new System.Drawing.Size(48, 20);
            this.radIPD.TabIndex = 10;
            this.radIPD.TabStop = true;
            this.radIPD.Text = "IPD";
            this.radIPD.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkVoucher);
            this.groupBox3.Controls.Add(this.chkLedger);
            this.groupBox3.Controls.Add(this.cboLedgerName);
            this.groupBox3.Controls.Add(this.txtVoucherNo);
            this.groupBox3.Location = new System.Drawing.Point(217, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 90);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // chkVoucher
            // 
            this.chkVoucher.AutoSize = true;
            this.chkVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVoucher.ForeColor = System.Drawing.Color.Black;
            this.chkVoucher.Location = new System.Drawing.Point(368, 25);
            this.chkVoucher.Name = "chkVoucher";
            this.chkVoucher.Size = new System.Drawing.Size(79, 22);
            this.chkVoucher.TabIndex = 6;
            this.chkVoucher.Text = "Voucher";
            this.chkVoucher.UseVisualStyleBackColor = true;
            this.chkVoucher.CheckedChanged += new System.EventHandler(this.chkVoucher_CheckedChanged);
            // 
            // chkLedger
            // 
            this.chkLedger.AutoSize = true;
            this.chkLedger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLedger.ForeColor = System.Drawing.Color.Black;
            this.chkLedger.Location = new System.Drawing.Point(16, 25);
            this.chkLedger.Name = "chkLedger";
            this.chkLedger.Size = new System.Drawing.Size(69, 22);
            this.chkLedger.TabIndex = 5;
            this.chkLedger.Text = "Ledger";
            this.chkLedger.UseVisualStyleBackColor = true;
            this.chkLedger.CheckedChanged += new System.EventHandler(this.chkLedger_CheckedChanged);
            // 
            // cboLedgerName
            // 
            this.cboLedgerName.Enabled = false;
            this.cboLedgerName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLedgerName.FormattingEnabled = true;
            this.cboLedgerName.Location = new System.Drawing.Point(6, 51);
            this.cboLedgerName.Name = "cboLedgerName";
            this.cboLedgerName.Size = new System.Drawing.Size(338, 24);
            this.cboLedgerName.TabIndex = 3;
            this.cboLedgerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboLedgerName_KeyUp);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoucherNo.Enabled = false;
            this.txtVoucherNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNo.Location = new System.Drawing.Point(350, 51);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(181, 24);
            this.txtVoucherNo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "To Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(918, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "From Date:";
            // 
            // dteTdate
            // 
            this.dteTdate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTdate.Location = new System.Drawing.Point(1003, 66);
            this.dteTdate.Name = "dteTdate";
            this.dteTdate.Size = new System.Drawing.Size(129, 26);
            this.dteTdate.TabIndex = 6;
            // 
            // dteFdate
            // 
            this.dteFdate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFdate.Location = new System.Drawing.Point(1003, 29);
            this.dteFdate.Name = "dteFdate";
            this.dteFdate.Size = new System.Drawing.Size(129, 26);
            this.dteFdate.TabIndex = 5;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radAll.Checked = true;
            this.radAll.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.ForeColor = System.Drawing.Color.DarkOrchid;
            this.radAll.Location = new System.Drawing.Point(13, 26);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(39, 18);
            this.radAll.TabIndex = 4;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = false;
            // 
            // radContra
            // 
            this.radContra.AutoSize = true;
            this.radContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radContra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radContra.ForeColor = System.Drawing.Color.DarkOrchid;
            this.radContra.Location = new System.Drawing.Point(13, 128);
            this.radContra.Name = "radContra";
            this.radContra.Size = new System.Drawing.Size(68, 18);
            this.radContra.TabIndex = 3;
            this.radContra.Text = "Contra";
            this.radContra.UseVisualStyleBackColor = false;
            // 
            // radJournal
            // 
            this.radJournal.AutoSize = true;
            this.radJournal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radJournal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radJournal.ForeColor = System.Drawing.Color.DarkOrchid;
            this.radJournal.Location = new System.Drawing.Point(13, 103);
            this.radJournal.Name = "radJournal";
            this.radJournal.Size = new System.Drawing.Size(70, 18);
            this.radJournal.TabIndex = 2;
            this.radJournal.Text = "Journal";
            this.radJournal.UseVisualStyleBackColor = false;
            // 
            // radReceipt
            // 
            this.radReceipt.AutoSize = true;
            this.radReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radReceipt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReceipt.ForeColor = System.Drawing.Color.DarkOrchid;
            this.radReceipt.Location = new System.Drawing.Point(13, 77);
            this.radReceipt.Name = "radReceipt";
            this.radReceipt.Size = new System.Drawing.Size(71, 18);
            this.radReceipt.TabIndex = 1;
            this.radReceipt.Text = "Receipt";
            this.radReceipt.UseVisualStyleBackColor = false;
            // 
            // radPayment
            // 
            this.radPayment.AutoSize = true;
            this.radPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radPayment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPayment.ForeColor = System.Drawing.Color.DarkOrchid;
            this.radPayment.Location = new System.Drawing.Point(13, 52);
            this.radPayment.Name = "radPayment";
            this.radPayment.Size = new System.Drawing.Size(80, 18);
            this.radPayment.TabIndex = 0;
            this.radPayment.Text = "Payment";
            this.radPayment.UseVisualStyleBackColor = false;
            // 
            // DG
            // 
            this.DG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DG.Location = new System.Drawing.Point(11, 336);
            this.DG.Name = "DG";
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(1226, 452);
            this.DG.TabIndex = 1;
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(486, 795);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(40, 13);
            this.smartLabel1.TabIndex = 2;
            this.smartLabel1.Text = "Total:";
            // 
            // lblDrTotal
            // 
            this.lblDrTotal.AutoSize = true;
            this.lblDrTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblDrTotal.Location = new System.Drawing.Point(896, 794);
            this.lblDrTotal.Name = "lblDrTotal";
            this.lblDrTotal.Size = new System.Drawing.Size(16, 14);
            this.lblDrTotal.TabIndex = 3;
            this.lblDrTotal.Text = "0";
            // 
            // lblCrTotal
            // 
            this.lblCrTotal.AutoSize = true;
            this.lblCrTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblCrTotal.Location = new System.Drawing.Point(1036, 794);
            this.lblCrTotal.Name = "lblCrTotal";
            this.lblCrTotal.Size = new System.Drawing.Size(16, 14);
            this.lblCrTotal.TabIndex = 4;
            this.lblCrTotal.Text = "0";
            // 
            // frmVoucherArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1244, 818);
            this.isEnterTabAllow = true;
            this.Name = "frmVoucherArchive";
            this.Load += new System.EventHandler(this.frmVoucherArchive_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboLedgerName;
        private AtiqsControlLibrary.SmartTextBox txtVoucherNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dteTdate;
        private System.Windows.Forms.DateTimePicker dteFdate;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radContra;
        private System.Windows.Forms.RadioButton radJournal;
        private System.Windows.Forms.RadioButton radReceipt;
        private System.Windows.Forms.RadioButton radPayment;
        private AtiqsControlLibrary.SmartCheckBox chkVoucher;
        private AtiqsControlLibrary.SmartCheckBox chkLedger;
        private System.Windows.Forms.RadioButton radInvestigation;
        private System.Windows.Forms.RadioButton radHrm;
        private System.Windows.Forms.RadioButton radPharmacy;
        private System.Windows.Forms.RadioButton radOPD;
        private System.Windows.Forms.RadioButton radIPD;
        private AtiqsControlLibrary.SmartLabel lblCrTotal;
        private AtiqsControlLibrary.SmartLabel lblDrTotal;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.RadioButton radAccounts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radUnpost;
        private System.Windows.Forms.RadioButton radPost;
        private System.Windows.Forms.RadioButton radFoodBeverage;
    }
}
