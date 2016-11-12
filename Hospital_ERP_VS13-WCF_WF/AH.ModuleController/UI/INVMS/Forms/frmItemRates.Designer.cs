namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmItemRates
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
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboStoreLocation = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtCompanyName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtGroupName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.dgvItem = new AtiqsControlLibrary.SmartDataGridView();
            this.txtItemName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.txtItemID = new AtiqsControlLibrary.SmartTextBox();
            this.lvItemRates = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtSlRate = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.txtRackRate = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.txtDiscount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel20 = new AtiqsControlLibrary.SmartLabel();
            this.txtvat = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtURate = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel19 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeID = new AtiqsControlLibrary.SmartTextBox();
            this.txtUnitID = new AtiqsControlLibrary.SmartTextBox();
            this.txtGroupID = new AtiqsControlLibrary.SmartTextBox();
            this.txtCompanyID = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtBrandID = new AtiqsControlLibrary.SmartTextBox();
            this.txtModelID = new AtiqsControlLibrary.SmartTextBox();
            this.txtBrandName = new AtiqsControlLibrary.SmartTextBox();
            this.txtModelName = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(952, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(435, 10);
            this.frmLabel.Size = new System.Drawing.Size(145, 33);
            this.frmLabel.Text = "Item Rates";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboStoreLocation);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtCompanyName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtGroupName);
            this.pnlMain.Controls.Add(this.dgvItem);
            this.pnlMain.Controls.Add(this.txtItemName);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.txtItemID);
            this.pnlMain.Controls.Add(this.lvItemRates);
            this.pnlMain.Controls.Add(this.txtSlRate);
            this.pnlMain.Controls.Add(this.smartLabel22);
            this.pnlMain.Controls.Add(this.txtRackRate);
            this.pnlMain.Controls.Add(this.smartLabel21);
            this.pnlMain.Controls.Add(this.txtDiscount);
            this.pnlMain.Controls.Add(this.smartLabel20);
            this.pnlMain.Controls.Add(this.txtvat);
            this.pnlMain.Controls.Add(this.txtURate);
            this.pnlMain.Controls.Add(this.smartLabel19);
            this.pnlMain.Controls.Add(this.smartLabel18);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(1005, 507);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1005, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(781, 565);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(671, 565);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(352, 565);
            this.btnDelete.Size = new System.Drawing.Size(40, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(561, 565);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(891, 565);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(301, 565);
            this.btnPrint.Size = new System.Drawing.Size(35, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 614);
            this.groupBox1.Size = new System.Drawing.Size(1005, 23);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(13, 17);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(94, 15);
            this.smartLabel4.TabIndex = 139;
            this.smartLabel4.Text = "Store Location :";
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreLocation.ForeColor = System.Drawing.Color.Blue;
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(116, 14);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(275, 26);
            this.cboStoreLocation.TabIndex = 138;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(579, 42);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(64, 15);
            this.smartLabel2.TabIndex = 137;
            this.smartLabel2.Text = "Company :";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.Linen;
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCompanyName.Location = new System.Drawing.Point(579, 63);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(165, 24);
            this.txtCompanyName.TabIndex = 136;
            this.txtCompanyName.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(374, 42);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(92, 15);
            this.smartLabel1.TabIndex = 135;
            this.smartLabel1.Text = "Generic Name :";
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.Color.Linen;
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtGroupName.Location = new System.Drawing.Point(374, 63);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(201, 24);
            this.txtGroupName.TabIndex = 134;
            this.txtGroupName.TabStop = false;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToOrderColumns = true;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItem.Location = new System.Drawing.Point(179, 427);
            this.dgvItem.MultiSelect = false;
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvItem.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(260, 31);
            this.dgvItem.TabIndex = 131;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            this.dgvItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvItem_KeyPress);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.Linen;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtItemName.Location = new System.Drawing.Point(134, 63);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(237, 24);
            this.txtItemName.TabIndex = 132;
            this.txtItemName.TabStop = false;
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(138, 42);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(82, 15);
            this.smartLabel13.TabIndex = 133;
            this.smartLabel13.Text = "Brand Name :";
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(10, 63);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(118, 24);
            this.txtItemID.TabIndex = 130;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            this.txtItemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemID_KeyDown);
            // 
            // lvItemRates
            // 
            this.lvItemRates.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvItemRates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvItemRates.CheckBoxes = true;
            this.lvItemRates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvItemRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItemRates.FullRowSelect = true;
            this.lvItemRates.GridLines = true;
            this.lvItemRates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvItemRates.Location = new System.Drawing.Point(-1, 90);
            this.lvItemRates.Name = "lvItemRates";
            this.lvItemRates.Size = new System.Drawing.Size(1004, 416);
            this.lvItemRates.TabIndex = 129;
            this.lvItemRates.TabStop = false;
            this.lvItemRates.UseCompatibleStateImageBehavior = false;
            this.lvItemRates.View = System.Windows.Forms.View.Details;
            this.lvItemRates.SelectedIndexChanged += new System.EventHandler(this.lvItemRates_SelectedIndexChanged);
            // 
            // txtSlRate
            // 
            this.txtSlRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlRate.Location = new System.Drawing.Point(953, 63);
            this.txtSlRate.Name = "txtSlRate";
            this.txtSlRate.Size = new System.Drawing.Size(43, 24);
            this.txtSlRate.TabIndex = 128;
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(951, 42);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(47, 15);
            this.smartLabel22.TabIndex = 127;
            this.smartLabel22.Text = "Sl Rate";
            // 
            // txtRackRate
            // 
            this.txtRackRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRackRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRackRate.Location = new System.Drawing.Point(900, 63);
            this.txtRackRate.Name = "txtRackRate";
            this.txtRackRate.Size = new System.Drawing.Size(53, 24);
            this.txtRackRate.TabIndex = 126;
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(900, 42);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(48, 15);
            this.smartLabel21.TabIndex = 125;
            this.smartLabel21.Text = "R_Rate";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(848, 63);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(52, 24);
            this.txtDiscount.TabIndex = 124;
            // 
            // smartLabel20
            // 
            this.smartLabel20.AutoSize = true;
            this.smartLabel20.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel20.Location = new System.Drawing.Point(855, 42);
            this.smartLabel20.Name = "smartLabel20";
            this.smartLabel20.Size = new System.Drawing.Size(35, 15);
            this.smartLabel20.TabIndex = 123;
            this.smartLabel20.Text = "Disc.";
            // 
            // txtvat
            // 
            this.txtvat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvat.Location = new System.Drawing.Point(799, 63);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(49, 24);
            this.txtvat.TabIndex = 122;
            // 
            // txtURate
            // 
            this.txtURate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURate.Location = new System.Drawing.Point(748, 63);
            this.txtURate.Name = "txtURate";
            this.txtURate.Size = new System.Drawing.Size(51, 24);
            this.txtURate.TabIndex = 121;
            // 
            // smartLabel19
            // 
            this.smartLabel19.AutoSize = true;
            this.smartLabel19.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel19.Location = new System.Drawing.Point(803, 42);
            this.smartLabel19.Name = "smartLabel19";
            this.smartLabel19.Size = new System.Drawing.Size(33, 15);
            this.smartLabel19.TabIndex = 120;
            this.smartLabel19.Text = "VAT ";
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.Location = new System.Drawing.Point(754, 42);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(35, 15);
            this.smartLabel18.TabIndex = 119;
            this.smartLabel18.Text = "Rate ";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(10, 42);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(41, 15);
            this.smartLabel3.TabIndex = 118;
            this.smartLabel3.Text = "Code :";
            // 
            // txtTypeID
            // 
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.Location = new System.Drawing.Point(70, 580);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.ReadOnly = true;
            this.txtTypeID.Size = new System.Drawing.Size(31, 24);
            this.txtTypeID.TabIndex = 68;
            this.txtTypeID.Visible = false;
            // 
            // txtUnitID
            // 
            this.txtUnitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitID.Location = new System.Drawing.Point(5, 562);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(27, 24);
            this.txtUnitID.TabIndex = 65;
            this.txtUnitID.Visible = false;
            // 
            // txtGroupID
            // 
            this.txtGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupID.Location = new System.Drawing.Point(46, 559);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.ReadOnly = true;
            this.txtGroupID.Size = new System.Drawing.Size(44, 24);
            this.txtGroupID.TabIndex = 66;
            this.txtGroupID.Visible = false;
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyID.Location = new System.Drawing.Point(96, 559);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.ReadOnly = true;
            this.txtCompanyID.Size = new System.Drawing.Size(29, 24);
            this.txtCompanyID.TabIndex = 67;
            this.txtCompanyID.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(10, 580);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(45, 23);
            this.txtRemarks.TabIndex = 64;
            this.txtRemarks.Visible = false;
            // 
            // txtBrandID
            // 
            this.txtBrandID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandID.Location = new System.Drawing.Point(147, 561);
            this.txtBrandID.Name = "txtBrandID";
            this.txtBrandID.ReadOnly = true;
            this.txtBrandID.Size = new System.Drawing.Size(31, 24);
            this.txtBrandID.TabIndex = 69;
            this.txtBrandID.Visible = false;
            // 
            // txtModelID
            // 
            this.txtModelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelID.Location = new System.Drawing.Point(184, 562);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.ReadOnly = true;
            this.txtModelID.Size = new System.Drawing.Size(31, 24);
            this.txtModelID.TabIndex = 70;
            this.txtModelID.Visible = false;
            // 
            // txtBrandName
            // 
            this.txtBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.Location = new System.Drawing.Point(221, 562);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.ReadOnly = true;
            this.txtBrandName.Size = new System.Drawing.Size(31, 24);
            this.txtBrandName.TabIndex = 71;
            this.txtBrandName.Visible = false;
            // 
            // txtModelName
            // 
            this.txtModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.Location = new System.Drawing.Point(258, 571);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.ReadOnly = true;
            this.txtModelName.Size = new System.Drawing.Size(31, 24);
            this.txtModelName.TabIndex = 72;
            this.txtModelName.Visible = false;
            // 
            // frmItemRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1005, 637);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtModelID);
            this.Controls.Add(this.txtBrandID);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.txtRemarks);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmItemRates";
            this.Load += new System.EventHandler(this.frmItemRates_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.txtCompanyID, 0);
            this.Controls.SetChildIndex(this.txtGroupID, 0);
            this.Controls.SetChildIndex(this.txtUnitID, 0);
            this.Controls.SetChildIndex(this.txtTypeID, 0);
            this.Controls.SetChildIndex(this.txtBrandID, 0);
            this.Controls.SetChildIndex(this.txtModelID, 0);
            this.Controls.SetChildIndex(this.txtBrandName, 0);
            this.Controls.SetChildIndex(this.txtModelName, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboStoreLocation;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCompanyName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtGroupName;
        private AtiqsControlLibrary.SmartDataGridView dgvItem;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtItemName;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartTextBox txtItemID;
        private AtiqsControlLibrary.SmartListViewDetails lvItemRates;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlRate;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartNumericTextBox txtRackRate;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartNumericTextBox txtDiscount;
        private AtiqsControlLibrary.SmartLabel smartLabel20;
        private AtiqsControlLibrary.SmartNumericTextBox txtvat;
        private AtiqsControlLibrary.SmartNumericTextBox txtURate;
        private AtiqsControlLibrary.SmartLabel smartLabel19;
        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtTypeID;
        private AtiqsControlLibrary.SmartTextBox txtUnitID;
        private AtiqsControlLibrary.SmartTextBox txtGroupID;
        private AtiqsControlLibrary.SmartTextBox txtCompanyID;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtBrandID;
        private AtiqsControlLibrary.SmartTextBox txtModelID;
        private AtiqsControlLibrary.SmartTextBox txtBrandName;
        private AtiqsControlLibrary.SmartTextBox txtModelName;
    }
}
