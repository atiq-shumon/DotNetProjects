namespace AH.ModuleController.UI.PHRMS.Forms
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtSlRate = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtRackRate = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtDiscount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtvat = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtURate = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvItemRates = new AtiqsControlLibrary.SmartListViewDetails();
            this.dgvProduction = new AtiqsControlLibrary.SmartDataGridView();
            this.txtProductionName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.txtProductionID = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductionPacketID = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductionUnitID = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductionGroupID = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductionCompanyID = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductGroupName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtProdCompName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboPharmacy = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDrugCompany = new AtiqsControlLibrary.SmartComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(951, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(429, 10);
            this.frmLabel.Size = new System.Drawing.Size(144, 33);
            this.frmLabel.Text = "MRP Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboDrugCompany);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtProdCompName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtProductGroupName);
            this.pnlMain.Controls.Add(this.dgvProduction);
            this.pnlMain.Controls.Add(this.txtProductionName);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.txtProductionID);
            this.pnlMain.Controls.Add(this.lvItemRates);
            this.pnlMain.Controls.Add(this.txtSlRate);
            this.pnlMain.Controls.Add(this.smartLabel22);
            this.pnlMain.Controls.Add(this.txtURate);
            this.pnlMain.Controls.Add(this.smartLabel18);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Location = new System.Drawing.Point(0, 52);
            this.pnlMain.Size = new System.Drawing.Size(1005, 504);
            this.pnlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseClick);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1005, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(312, 563);
            this.btnEdit.Size = new System.Drawing.Size(37, 39);
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(783, 562);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(355, 564);
            this.btnDelete.Size = new System.Drawing.Size(24, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(673, 562);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(893, 562);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(385, 560);
            this.btnPrint.Size = new System.Drawing.Size(25, 39);
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 605);
            this.groupBox1.Size = new System.Drawing.Size(1005, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(7, 49);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(45, 18);
            this.smartLabel3.TabIndex = 14;
            this.smartLabel3.Text = "Code :";
            // 
            // txtSlRate
            // 
            this.txtSlRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlRate.Location = new System.Drawing.Point(903, 70);
            this.txtSlRate.Name = "txtSlRate";
            this.txtSlRate.Size = new System.Drawing.Size(97, 24);
            this.txtSlRate.TabIndex = 55;
            // 
            // txtRackRate
            // 
            this.txtRackRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRackRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRackRate.Location = new System.Drawing.Point(580, 575);
            this.txtRackRate.Name = "txtRackRate";
            this.txtRackRate.Size = new System.Drawing.Size(53, 24);
            this.txtRackRate.TabIndex = 53;
            this.txtRackRate.Visible = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(521, 572);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(52, 24);
            this.txtDiscount.TabIndex = 51;
            this.txtDiscount.Visible = false;
            // 
            // txtvat
            // 
            this.txtvat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvat.Location = new System.Drawing.Point(444, 571);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(49, 24);
            this.txtvat.TabIndex = 49;
            this.txtvat.Visible = false;
            // 
            // txtURate
            // 
            this.txtURate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURate.Location = new System.Drawing.Point(800, 70);
            this.txtURate.Name = "txtURate";
            this.txtURate.Size = new System.Drawing.Size(103, 24);
            this.txtURate.TabIndex = 48;
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.Location = new System.Drawing.Point(802, 49);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(70, 18);
            this.smartLabel18.TabIndex = 46;
            this.smartLabel18.Text = "Cost Price ";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(26, 579);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(45, 23);
            this.txtRemarks.TabIndex = 57;
            this.txtRemarks.Visible = false;
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
            this.lvItemRates.Location = new System.Drawing.Point(-1, 103);
            this.lvItemRates.Name = "lvItemRates";
            this.lvItemRates.Size = new System.Drawing.Size(1004, 400);
            this.lvItemRates.TabIndex = 58;
            this.lvItemRates.TabStop = false;
            this.lvItemRates.UseCompatibleStateImageBehavior = false;
            this.lvItemRates.View = System.Windows.Forms.View.Details;
            this.lvItemRates.SelectedIndexChanged += new System.EventHandler(this.lvItemRates_SelectedIndexChanged);
            // 
            // dgvProduction
            // 
            this.dgvProduction.AllowUserToAddRows = false;
            this.dgvProduction.AllowUserToDeleteRows = false;
            this.dgvProduction.AllowUserToOrderColumns = true;
            this.dgvProduction.AllowUserToResizeColumns = false;
            this.dgvProduction.AllowUserToResizeRows = false;
            this.dgvProduction.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduction.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduction.Location = new System.Drawing.Point(179, 424);
            this.dgvProduction.MultiSelect = false;
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.RowHeadersVisible = false;
            this.dgvProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduction.Size = new System.Drawing.Size(260, 31);
            this.dgvProduction.TabIndex = 62;
            this.dgvProduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellClick);
            this.dgvProduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProduction_KeyPress);
            // 
            // txtProductionName
            // 
            this.txtProductionName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtProductionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProductionName.Location = new System.Drawing.Point(131, 70);
            this.txtProductionName.Name = "txtProductionName";
            this.txtProductionName.ReadOnly = true;
            this.txtProductionName.Size = new System.Drawing.Size(292, 24);
            this.txtProductionName.TabIndex = 63;
            this.txtProductionName.TabStop = false;
            this.txtProductionName.TextChanged += new System.EventHandler(this.txtProductionName_TextChanged);
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(135, 49);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(91, 18);
            this.smartLabel13.TabIndex = 64;
            this.smartLabel13.Text = "Brand Name :";
            // 
            // txtProductionID
            // 
            this.txtProductionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionID.Location = new System.Drawing.Point(7, 70);
            this.txtProductionID.Name = "txtProductionID";
            this.txtProductionID.Size = new System.Drawing.Size(118, 24);
            this.txtProductionID.TabIndex = 61;
            this.txtProductionID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductionID_KeyDown);
            this.txtProductionID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProductionID_KeyUp);
            // 
            // txtProductionPacketID
            // 
            this.txtProductionPacketID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionPacketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionPacketID.Location = new System.Drawing.Point(86, 579);
            this.txtProductionPacketID.Name = "txtProductionPacketID";
            this.txtProductionPacketID.ReadOnly = true;
            this.txtProductionPacketID.Size = new System.Drawing.Size(31, 24);
            this.txtProductionPacketID.TabIndex = 63;
            this.txtProductionPacketID.Visible = false;
            // 
            // txtProductionUnitID
            // 
            this.txtProductionUnitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionUnitID.Location = new System.Drawing.Point(21, 561);
            this.txtProductionUnitID.Name = "txtProductionUnitID";
            this.txtProductionUnitID.ReadOnly = true;
            this.txtProductionUnitID.Size = new System.Drawing.Size(27, 24);
            this.txtProductionUnitID.TabIndex = 60;
            this.txtProductionUnitID.Visible = false;
            // 
            // txtProductionGroupID
            // 
            this.txtProductionGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionGroupID.Location = new System.Drawing.Point(62, 558);
            this.txtProductionGroupID.Name = "txtProductionGroupID";
            this.txtProductionGroupID.ReadOnly = true;
            this.txtProductionGroupID.Size = new System.Drawing.Size(44, 24);
            this.txtProductionGroupID.TabIndex = 61;
            this.txtProductionGroupID.Visible = false;
            // 
            // txtProductionCompanyID
            // 
            this.txtProductionCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionCompanyID.Location = new System.Drawing.Point(112, 558);
            this.txtProductionCompanyID.Name = "txtProductionCompanyID";
            this.txtProductionCompanyID.ReadOnly = true;
            this.txtProductionCompanyID.Size = new System.Drawing.Size(29, 24);
            this.txtProductionCompanyID.TabIndex = 62;
            this.txtProductionCompanyID.Visible = false;
            // 
            // txtProductGroupName
            // 
            this.txtProductGroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtProductGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProductGroupName.Location = new System.Drawing.Point(427, 70);
            this.txtProductGroupName.Name = "txtProductGroupName";
            this.txtProductGroupName.ReadOnly = true;
            this.txtProductGroupName.Size = new System.Drawing.Size(201, 24);
            this.txtProductGroupName.TabIndex = 64;
            this.txtProductGroupName.TabStop = false;
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(922, 49);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(38, 18);
            this.smartLabel22.TabIndex = 54;
            this.smartLabel22.Text = "MRP";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(427, 49);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(102, 18);
            this.smartLabel1.TabIndex = 65;
            this.smartLabel1.Text = "Generic Name :";
            // 
            // txtProdCompName
            // 
            this.txtProdCompName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtProdCompName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdCompName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProdCompName.Location = new System.Drawing.Point(632, 70);
            this.txtProdCompName.Name = "txtProdCompName";
            this.txtProdCompName.ReadOnly = true;
            this.txtProdCompName.Size = new System.Drawing.Size(165, 24);
            this.txtProdCompName.TabIndex = 114;
            this.txtProdCompName.TabStop = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(632, 49);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(72, 18);
            this.smartLabel2.TabIndex = 115;
            this.smartLabel2.Text = "Company :";
            // 
            // cboPharmacy
            // 
            this.cboPharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPharmacy.ForeColor = System.Drawing.Color.Blue;
            this.cboPharmacy.FormattingEnabled = true;
            this.cboPharmacy.Location = new System.Drawing.Point(180, 567);
            this.cboPharmacy.Name = "cboPharmacy";
            this.cboPharmacy.Size = new System.Drawing.Size(79, 26);
            this.cboPharmacy.TabIndex = 116;
            this.cboPharmacy.Visible = false;
            this.cboPharmacy.SelectedIndexChanged += new System.EventHandler(this.cboPharmacy_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(115, 20);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(11, 13);
            this.smartLabel4.TabIndex = 281;
            this.smartLabel4.Text = ":";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(6, 19);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(103, 18);
            this.smartLabel7.TabIndex = 280;
            this.smartLabel7.Text = "Drug Comapny ";
            // 
            // cboDrugCompany
            // 
            this.cboDrugCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrugCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrugCompany.ForeColor = System.Drawing.Color.Blue;
            this.cboDrugCompany.FormattingEnabled = true;
            this.cboDrugCompany.Items.AddRange(new object[] {
            "select"});
            this.cboDrugCompany.Location = new System.Drawing.Point(132, 15);
            this.cboDrugCompany.Name = "cboDrugCompany";
            this.cboDrugCompany.Size = new System.Drawing.Size(291, 26);
            this.cboDrugCompany.TabIndex = 279;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(425, 15);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(53, 25);
            this.btnShow.TabIndex = 282;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmItemRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1005, 628);
            this.Controls.Add(this.cboPharmacy);
            this.Controls.Add(this.txtProductionPacketID);
            this.Controls.Add(this.txtProductionUnitID);
            this.Controls.Add(this.txtRackRate);
            this.Controls.Add(this.txtProductionGroupID);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtProductionCompanyID);
            this.Controls.Add(this.txtvat);
            this.Controls.Add(this.txtRemarks);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmItemRates";
            this.Load += new System.EventHandler(this.frmItemRates_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.txtvat, 0);
            this.Controls.SetChildIndex(this.txtProductionCompanyID, 0);
            this.Controls.SetChildIndex(this.txtDiscount, 0);
            this.Controls.SetChildIndex(this.txtProductionGroupID, 0);
            this.Controls.SetChildIndex(this.txtRackRate, 0);
            this.Controls.SetChildIndex(this.txtProductionUnitID, 0);
            this.Controls.SetChildIndex(this.txtProductionPacketID, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.cboPharmacy, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlRate;
        private AtiqsControlLibrary.SmartNumericTextBox txtRackRate;
        private AtiqsControlLibrary.SmartNumericTextBox txtDiscount;
        private AtiqsControlLibrary.SmartNumericTextBox txtvat;
        private AtiqsControlLibrary.SmartNumericTextBox txtURate;
        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartListViewDetails lvItemRates;
        private AtiqsControlLibrary.SmartDataGridView dgvProduction;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtProductionName;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartTextBox txtProductionID;
        private AtiqsControlLibrary.SmartTextBox txtProductionPacketID;
        private AtiqsControlLibrary.SmartTextBox txtProductionUnitID;
        private AtiqsControlLibrary.SmartTextBox txtProductionGroupID;
        private AtiqsControlLibrary.SmartTextBox txtProductionCompanyID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtProductGroupName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtProdCompName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboPharmacy;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboDrugCompany;
        private System.Windows.Forms.Button btnShow;
    }
}
