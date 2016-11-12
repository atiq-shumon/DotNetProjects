namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedger));
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtLedgerName = new AtiqsControlLibrary.SmartTextBox();
            this.cboStatus = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDifference = new System.Windows.Forms.Label();
            this.lblDifferenceTitle = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblDebit = new System.Windows.Forms.Label();
            this.lblTotalOpening = new System.Windows.Forms.Label();
            this.txtCurrencySymbol = new AtiqsControlLibrary.SmartTextBox();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.txtDrCr = new AtiqsControlLibrary.SmartTextBox();
            this.btnTreeView = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtComments = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmail = new AtiqsControlLibrary.SmartTextBox();
            this.txtPhoneNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtFax = new AtiqsControlLibrary.SmartTextBox();
            this.txtPostal = new AtiqsControlLibrary.SmartTextBox();
            this.txtCity = new AtiqsControlLibrary.SmartTextBox();
            this.txtAddress2 = new AtiqsControlLibrary.SmartTextBox();
            this.txtAddress1 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lvwLedgerList = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvwVoucherDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnReferesh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.cboCostCenter = new AtiqsControlLibrary.SmartComboBox();
            this.lblSearch = new AtiqsControlLibrary.SmartLabel();
            this.txtSearch = new AtiqsControlLibrary.SmartTextBox();
            this.txtUnder = new AtiqsControlLibrary.SmartTextBox();
            this.lstLedger = new System.Windows.Forms.ListBox();
            this.chkEdit = new AtiqsControlLibrary.SmartCheckBox();
            this.txtCode = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1209, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(307, 5);
            this.frmLabel.Size = new System.Drawing.Size(264, 33);
            this.frmLabel.Text = "Ledger Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtCode);
            this.pnlMain.Controls.Add(this.chkEdit);
            this.pnlMain.Controls.Add(this.lstLedger);
            this.pnlMain.Controls.Add(this.txtUnder);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.lblSearch);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.cboCostCenter);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lvwVoucherDetails);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.txtDrCr);
            this.pnlMain.Controls.Add(this.txtOpeningBalance);
            this.pnlMain.Controls.Add(this.txtCurrencySymbol);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.cboStatus);
            this.pnlMain.Controls.Add(this.txtLedgerName);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(-1, 51);
            this.pnlMain.Size = new System.Drawing.Size(856, 166);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lvwLedgerList);
            this.pnlTop.Size = new System.Drawing.Size(855, 51);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.lvwLedgerList, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(616, 223);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(502, 223);
            this.btnSave.TabIndex = 14;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(74, 219);
            this.btnDelete.Size = new System.Drawing.Size(88, 39);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(234, 223);
            this.btnNew.TabIndex = 14;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(729, 223);
            this.btnClose.TabIndex = 15;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(120, 220);
            this.btnPrint.Size = new System.Drawing.Size(88, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 277);
            this.groupBox1.Size = new System.Drawing.Size(855, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(141, 25);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(106, 16);
            this.smartLabel1.TabIndex = 15;
            this.smartLabel1.Text = "Ledger Name:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(193, 51);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(54, 16);
            this.smartLabel2.TabIndex = 16;
            this.smartLabel2.Text = "Under:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(174, 81);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(73, 16);
            this.smartLabel3.TabIndex = 17;
            this.smartLabel3.Text = "Currency:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(699, 14);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(131, 16);
            this.smartLabel4.TabIndex = 18;
            this.smartLabel4.Text = "Opening Balance:";
            this.smartLabel4.Visible = false;
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLedgerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLedgerName.Location = new System.Drawing.Point(263, 24);
            this.txtLedgerName.MaxLength = 100;
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(400, 24);
            this.txtLedgerName.TabIndex = 0;
            this.txtLedgerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLedgerName_KeyPress);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.Blue;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboStatus.Location = new System.Drawing.Point(264, 134);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(231, 26);
            this.cboStatus.TabIndex = 12;
            this.cboStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboStatus_KeyPress);
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(176, 137);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(71, 16);
            this.smartLabel13.TabIndex = 41;
            this.smartLabel13.Text = "Is Active:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.lblDifference);
            this.groupBox2.Controls.Add(this.lblDifferenceTitle);
            this.groupBox2.Controls.Add(this.lblCredit);
            this.groupBox2.Controls.Add(this.lblDebit);
            this.groupBox2.Controls.Add(this.lblTotalOpening);
            this.groupBox2.Location = new System.Drawing.Point(1064, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 197);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifference.Location = new System.Drawing.Point(140, 148);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(16, 18);
            this.lblDifference.TabIndex = 9;
            this.lblDifference.Text = "0";
            // 
            // lblDifferenceTitle
            // 
            this.lblDifferenceTitle.AutoSize = true;
            this.lblDifferenceTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDifferenceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifferenceTitle.Location = new System.Drawing.Point(86, 125);
            this.lblDifferenceTitle.Name = "lblDifferenceTitle";
            this.lblDifferenceTitle.Size = new System.Drawing.Size(75, 18);
            this.lblDifferenceTitle.TabIndex = 8;
            this.lblDifferenceTitle.Text = "Difference";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(83, 95);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(16, 18);
            this.lblCredit.TabIndex = 7;
            this.lblCredit.Text = "0";
            // 
            // lblDebit
            // 
            this.lblDebit.AutoSize = true;
            this.lblDebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebit.Location = new System.Drawing.Point(80, 67);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(16, 18);
            this.lblDebit.TabIndex = 6;
            this.lblDebit.Text = "0";
            // 
            // lblTotalOpening
            // 
            this.lblTotalOpening.AutoSize = true;
            this.lblTotalOpening.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOpening.ForeColor = System.Drawing.Color.Red;
            this.lblTotalOpening.Location = new System.Drawing.Point(77, 35);
            this.lblTotalOpening.Name = "lblTotalOpening";
            this.lblTotalOpening.Size = new System.Drawing.Size(157, 18);
            this.lblTotalOpening.TabIndex = 5;
            this.lblTotalOpening.Text = "Total Opening Balance";
            // 
            // txtCurrencySymbol
            // 
            this.txtCurrencySymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrencySymbol.Enabled = false;
            this.txtCurrencySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencySymbol.Location = new System.Drawing.Point(264, 79);
            this.txtCurrencySymbol.Name = "txtCurrencySymbol";
            this.txtCurrencySymbol.Size = new System.Drawing.Size(231, 24);
            this.txtCurrencySymbol.TabIndex = 2;
            this.txtCurrencySymbol.Text = "BDT";
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpeningBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpeningBalance.Location = new System.Drawing.Point(750, 41);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(90, 24);
            this.txtOpeningBalance.TabIndex = 3;
            this.txtOpeningBalance.Visible = false;
            this.txtOpeningBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOpeningBalance_KeyDown);
            this.txtOpeningBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpeningBalance_KeyPress);
            this.txtOpeningBalance.Leave += new System.EventHandler(this.txtOpeningBalance_Leave);
            // 
            // txtDrCr
            // 
            this.txtDrCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrCr.Location = new System.Drawing.Point(1054, 45);
            this.txtDrCr.MaxLength = 2;
            this.txtDrCr.Name = "txtDrCr";
            this.txtDrCr.Size = new System.Drawing.Size(38, 24);
            this.txtDrCr.TabIndex = 4;
            this.txtDrCr.Text = "Dr";
            this.txtDrCr.Visible = false;
            this.txtDrCr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrCr_KeyDown);
            this.txtDrCr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrCr_KeyPress);
            // 
            // btnTreeView
            // 
            this.btnTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeView.ForeColor = System.Drawing.Color.Transparent;
            this.btnTreeView.Location = new System.Drawing.Point(181, 221);
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Size = new System.Drawing.Size(68, 40);
            this.btnTreeView.TabIndex = 20;
            this.btnTreeView.Text = "TreeView";
            this.btnTreeView.UseVisualStyleBackColor = false;
            this.btnTreeView.Visible = false;
            this.btnTreeView.Click += new System.EventHandler(this.btnTreeView_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.Navy;
            this.btnDetails.Location = new System.Drawing.Point(392, 223);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(106, 40);
            this.btnDetails.TabIndex = 15;
            this.btnDetails.Text = "View Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtComments);
            this.groupBox3.Controls.Add(this.smartLabel12);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtPhoneNo);
            this.groupBox3.Controls.Add(this.txtFax);
            this.groupBox3.Controls.Add(this.txtPostal);
            this.groupBox3.Controls.Add(this.txtCity);
            this.groupBox3.Controls.Add(this.txtAddress2);
            this.groupBox3.Controls.Add(this.txtAddress1);
            this.groupBox3.Controls.Add(this.smartLabel11);
            this.groupBox3.Controls.Add(this.smartLabel10);
            this.groupBox3.Controls.Add(this.smartLabel9);
            this.groupBox3.Controls.Add(this.smartLabel8);
            this.groupBox3.Controls.Add(this.smartLabel7);
            this.groupBox3.Controls.Add(this.smartLabel6);
            this.groupBox3.Controls.Add(this.smartLabel5);
            this.groupBox3.Location = new System.Drawing.Point(605, 670);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 291);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Visible = false;
            // 
            // txtComments
            // 
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(56, 233);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(328, 24);
            this.txtComments.TabIndex = 40;
            this.txtComments.Visible = false;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(-40, 235);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(84, 16);
            this.smartLabel12.TabIndex = 41;
            this.smartLabel12.Text = "Comments:";
            this.smartLabel12.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(54, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 24);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Visible = false;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(54, 183);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(328, 24);
            this.txtPhoneNo.TabIndex = 31;
            this.txtPhoneNo.Visible = false;
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(54, 158);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(328, 24);
            this.txtFax.TabIndex = 30;
            this.txtFax.Visible = false;
            // 
            // txtPostal
            // 
            this.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostal.Location = new System.Drawing.Point(54, 133);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(328, 24);
            this.txtPostal.TabIndex = 29;
            this.txtPostal.Visible = false;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(54, 108);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(328, 24);
            this.txtCity.TabIndex = 28;
            this.txtCity.Visible = false;
            // 
            // txtAddress2
            // 
            this.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(54, 83);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(328, 24);
            this.txtAddress2.TabIndex = 27;
            this.txtAddress2.Visible = false;
            // 
            // txtAddress1
            // 
            this.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(54, 58);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(328, 24);
            this.txtAddress1.TabIndex = 26;
            this.txtAddress1.Visible = false;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(-17, 212);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(59, 16);
            this.smartLabel11.TabIndex = 39;
            this.smartLabel11.Text = "E_Mail:";
            this.smartLabel11.Visible = false;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(-38, 187);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(80, 16);
            this.smartLabel10.TabIndex = 38;
            this.smartLabel10.Text = "Phone No:";
            this.smartLabel10.Visible = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(5, 165);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(37, 16);
            this.smartLabel9.TabIndex = 37;
            this.smartLabel9.Text = "Fax:";
            this.smartLabel9.Visible = false;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(-14, 136);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(56, 16);
            this.smartLabel8.TabIndex = 36;
            this.smartLabel8.Text = "Postal:";
            this.smartLabel8.Visible = false;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(4, 111);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(38, 16);
            this.smartLabel7.TabIndex = 35;
            this.smartLabel7.Text = "City:";
            this.smartLabel7.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(-36, 86);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(78, 16);
            this.smartLabel6.TabIndex = 34;
            this.smartLabel6.Text = "Address2:";
            this.smartLabel6.Visible = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(-36, 61);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(78, 16);
            this.smartLabel5.TabIndex = 33;
            this.smartLabel5.Text = "Address1:";
            this.smartLabel5.Visible = false;
            // 
            // lvwLedgerList
            // 
            this.lvwLedgerList.Location = new System.Drawing.Point(17, 7);
            this.lvwLedgerList.Name = "lvwLedgerList";
            this.lvwLedgerList.Size = new System.Drawing.Size(121, 10);
            this.lvwLedgerList.TabIndex = 21;
            this.lvwLedgerList.UseCompatibleStateImageBehavior = false;
            this.lvwLedgerList.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "FOLDRS01.ICO");
            this.imageList1.Images.SetKeyName(1, "DATA16.ICO");
            this.imageList1.Images.SetKeyName(2, "Text.ico");
            // 
            // lvwVoucherDetails
            // 
            this.lvwVoucherDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwVoucherDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwVoucherDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwVoucherDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwVoucherDetails.FullRowSelect = true;
            this.lvwVoucherDetails.GridLines = true;
            this.lvwVoucherDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwVoucherDetails.Location = new System.Drawing.Point(8, 164);
            this.lvwVoucherDetails.Name = "lvwVoucherDetails";
            this.lvwVoucherDetails.Size = new System.Drawing.Size(837, 295);
            this.lvwVoucherDetails.TabIndex = 45;
            this.lvwVoucherDetails.UseCompatibleStateImageBehavior = false;
            this.lvwVoucherDetails.View = System.Windows.Forms.View.Details;
            this.lvwVoucherDetails.SelectedIndexChanged += new System.EventHandler(this.lvwVoucherDetails_SelectedIndexChanged);
            // 
            // btnReferesh
            // 
            this.btnReferesh.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnReferesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferesh.ForeColor = System.Drawing.Color.Transparent;
            this.btnReferesh.Location = new System.Drawing.Point(-23, 217);
            this.btnReferesh.Name = "btnReferesh";
            this.btnReferesh.Size = new System.Drawing.Size(68, 40);
            this.btnReferesh.TabIndex = 46;
            this.btnReferesh.Text = "Refresh";
            this.btnReferesh.UseVisualStyleBackColor = false;
            this.btnReferesh.Visible = false;
            this.btnReferesh.Click += new System.EventHandler(this.btnReferesh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(975, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ctrl+Z for another Window";
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.Location = new System.Drawing.Point(155, 110);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(92, 16);
            this.smartLabel15.TabIndex = 51;
            this.smartLabel15.Text = "Cost Center:";
            // 
            // cboCostCenter
            // 
            this.cboCostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCostCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCostCenter.ForeColor = System.Drawing.Color.Blue;
            this.cboCostCenter.FormattingEnabled = true;
            this.cboCostCenter.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboCostCenter.Location = new System.Drawing.Point(264, 107);
            this.cboCostCenter.Name = "cboCostCenter";
            this.cboCostCenter.Size = new System.Drawing.Size(231, 26);
            this.cboCostCenter.TabIndex = 50;
            this.cboCostCenter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCostCenter_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(14, 111);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 14);
            this.lblSearch.TabIndex = 52;
            this.lblSearch.Text = "Search";
            this.lblSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 127);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 24);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.Visible = false;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // txtUnder
            // 
            this.txtUnder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnder.Location = new System.Drawing.Point(264, 51);
            this.txtUnder.Name = "txtUnder";
            this.txtUnder.ReadOnly = true;
            this.txtUnder.Size = new System.Drawing.Size(399, 24);
            this.txtUnder.TabIndex = 54;
            this.txtUnder.TextChanged += new System.EventHandler(this.txtLedger_TextChanged);
            this.txtUnder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedger_KeyDown);
            this.txtUnder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLedger_KeyPress);
            // 
            // lstLedger
            // 
            this.lstLedger.BackColor = System.Drawing.SystemColors.Info;
            this.lstLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLedger.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLedger.FormattingEnabled = true;
            this.lstLedger.ItemHeight = 16;
            this.lstLedger.Location = new System.Drawing.Point(754, 73);
            this.lstLedger.Name = "lstLedger";
            this.lstLedger.Size = new System.Drawing.Size(83, 34);
            this.lstLedger.TabIndex = 55;
            this.lstLedger.Visible = false;
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.BackColor = System.Drawing.Color.White;
            this.chkEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEdit.ForeColor = System.Drawing.Color.Black;
            this.chkEdit.Location = new System.Drawing.Point(9, 35);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(113, 22);
            this.chkEdit.TabIndex = 56;
            this.chkEdit.Text = "View Window";
            this.chkEdit.UseVisualStyleBackColor = false;
            this.chkEdit.Visible = false;
            this.chkEdit.CheckedChanged += new System.EventHandler(this.chkEdit_CheckedChanged);
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(558, 106);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(129, 24);
            this.txtCode.TabIndex = 57;
            this.txtCode.Visible = false;
            // 
            // frmLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(855, 302);
            this.Controls.Add(this.btnReferesh);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnTreeView);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmLedger";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frmLedger_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnTreeView, 0);
            this.Controls.SetChildIndex(this.btnDetails, 0);
            this.Controls.SetChildIndex(this.btnReferesh, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtLedgerName;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.Label lblDifferenceTitle;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.Label lblTotalOpening;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartComboBox cboStatus;
        private AtiqsControlLibrary.SmartTextBox txtCurrencySymbol;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private AtiqsControlLibrary.SmartTextBox txtDrCr;
        private System.Windows.Forms.Button btnTreeView;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartTextBox txtComments;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartTextBox txtEmail;
        private AtiqsControlLibrary.SmartTextBox txtPhoneNo;
        private AtiqsControlLibrary.SmartTextBox txtFax;
        private AtiqsControlLibrary.SmartTextBox txtPostal;
        private AtiqsControlLibrary.SmartTextBox txtCity;
        private AtiqsControlLibrary.SmartTextBox txtAddress2;
        private AtiqsControlLibrary.SmartTextBox txtAddress1;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.ListView lvwLedgerList;
        private AtiqsControlLibrary.SmartListViewDetails lvwVoucherDetails;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnReferesh;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartComboBox cboCostCenter;
        private AtiqsControlLibrary.SmartTextBox txtSearch;
        private AtiqsControlLibrary.SmartLabel lblSearch;
        private System.Windows.Forms.ListBox lstLedger;
        private AtiqsControlLibrary.SmartTextBox txtUnder;
        private AtiqsControlLibrary.SmartCheckBox chkEdit;
        private AtiqsControlLibrary.SmartTextBox txtCode;
    }
}
