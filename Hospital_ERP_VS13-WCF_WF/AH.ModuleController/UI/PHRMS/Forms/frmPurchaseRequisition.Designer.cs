namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmPurchaseRequisition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.btnCloseclk = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.txtProductionName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtRequisitionBy = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboPharmacy = new AtiqsControlLibrary.SmartComboBox();
            this.dgvProduction = new AtiqsControlLibrary.SmartDataGridView();
            this.lvItemList = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.labelSlrate = new AtiqsControlLibrary.SmartLabel();
            this.labelRackrate = new AtiqsControlLibrary.SmartLabel();
            this.labelDiscount = new AtiqsControlLibrary.SmartLabel();
            this.labelVat = new AtiqsControlLibrary.SmartLabel();
            this.txtRemQty = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtProdCompName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtProdPackName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtProdUnitName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtProdGroupName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtProductionPacketID = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductionUnitID = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductionGroupID = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductionCompanyID = new AtiqsControlLibrary.SmartTextBox();
            this.labelRate = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductionID = new AtiqsControlLibrary.SmartTextBox();
            this.cboCostCenter = new AtiqsControlLibrary.SmartComboBox();
            this.cboCostCategoey = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDrugCompany = new AtiqsControlLibrary.SmartComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplier = new AtiqsControlLibrary.SmartTextBox();
            this.txtSupplierName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.dgvSupplierList = new AtiqsControlLibrary.SmartDataGridView();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel17 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel19 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel20 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.txtPRID = new AtiqsControlLibrary.SmartTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStock = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtSlNo = new AtiqsControlLibrary.SmartTextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(394, 9);
            this.frmLabel.Size = new System.Drawing.Size(260, 33);
            this.frmLabel.Text = "Purchase Requisition";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnTR);
            this.pnlMain.Controls.Add(this.btnPreview);
            this.pnlMain.Controls.Add(this.dgvSupplierList);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtPRID);
            this.pnlMain.Controls.Add(this.smartLabel22);
            this.pnlMain.Controls.Add(this.smartLabel21);
            this.pnlMain.Controls.Add(this.smartLabel20);
            this.pnlMain.Controls.Add(this.smartLabel19);
            this.pnlMain.Controls.Add(this.smartLabel18);
            this.pnlMain.Controls.Add(this.smartLabel17);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtSupplier);
            this.pnlMain.Controls.Add(this.txtSupplierName);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboDrugCompany);
            this.pnlMain.Controls.Add(this.cboCostCenter);
            this.pnlMain.Controls.Add(this.cboCostCategoey);
            this.pnlMain.Controls.Add(this.txtProductionID);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtDeliveryDate);
            this.pnlMain.Controls.Add(this.dgvProduction);
            this.pnlMain.Controls.Add(this.lvItemList);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.btnCloseclk);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.txtQuantity);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.txtProductionName);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtRequisitionBy);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboPharmacy);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(1017, 602);
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1019, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(419, 667);
            this.btnEdit.Size = new System.Drawing.Size(46, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(792, 665);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 665);
            this.btnDelete.Size = new System.Drawing.Size(37, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(683, 665);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(902, 665);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1, 670);
            this.btnPrint.Size = new System.Drawing.Size(42, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 710);
            this.groupBox1.Size = new System.Drawing.Size(1019, 25);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(638, 132);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(88, 15);
            this.lblInfo.TabIndex = 250;
            this.lblInfo.Text = "Information";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(135, 70);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(260, 26);
            this.cboUnit.TabIndex = 1;
            this.cboUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUnit_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(9, 77);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(33, 15);
            this.smartLabel3.TabIndex = 249;
            this.smartLabel3.Text = "Unit ";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(135, 42);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(260, 26);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            this.cboDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDepartment_KeyPress);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(9, 49);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(74, 15);
            this.smartLabel4.TabIndex = 247;
            this.smartLabel4.Text = "Department ";
            // 
            // btnCloseclk
            // 
            this.btnCloseclk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCloseclk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseclk.ForeColor = System.Drawing.Color.White;
            this.btnCloseclk.Location = new System.Drawing.Point(977, 161);
            this.btnCloseclk.Name = "btnCloseclk";
            this.btnCloseclk.Size = new System.Drawing.Size(32, 24);
            this.btnCloseclk.TabIndex = 246;
            this.btnCloseclk.Text = "<<";
            this.btnCloseclk.UseVisualStyleBackColor = false;
            this.btnCloseclk.Click += new System.EventHandler(this.btnCloseclk_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(977, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 24);
            this.btnAdd.TabIndex = 235;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(878, 183);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 24);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(900, 161);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(55, 15);
            this.smartLabel16.TabIndex = 245;
            this.smartLabel16.Text = "Quantity";
            // 
            // txtProductionName
            // 
            this.txtProductionName.BackColor = System.Drawing.Color.Linen;
            this.txtProductionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProductionName.Location = new System.Drawing.Point(138, 183);
            this.txtProductionName.Name = "txtProductionName";
            this.txtProductionName.ReadOnly = true;
            this.txtProductionName.Size = new System.Drawing.Size(740, 24);
            this.txtProductionName.TabIndex = 243;
            this.txtProductionName.TabStop = false;
            this.txtProductionName.TextChanged += new System.EventHandler(this.txtProductionName_TextChanged);
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(138, 163);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(82, 15);
            this.smartLabel13.TabIndex = 244;
            this.smartLabel13.Text = "Brand Name :";
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(16, 163);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(27, 15);
            this.smartLabel12.TabIndex = 242;
            this.smartLabel12.Text = "ID :";
            // 
            // txtRequisitionBy
            // 
            this.txtRequisitionBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequisitionBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequisitionBy.Location = new System.Drawing.Point(635, 104);
            this.txtRequisitionBy.Name = "txtRequisitionBy";
            this.txtRequisitionBy.Size = new System.Drawing.Size(100, 24);
            this.txtRequisitionBy.TabIndex = 3;
            this.txtRequisitionBy.TextChanged += new System.EventHandler(this.txtRequisitionBy_TextChanged);
            this.txtRequisitionBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequisitionBy_KeyDown);
            this.txtRequisitionBy.Leave += new System.EventHandler(this.txtRequisitionBy_Leave);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(508, 107);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(91, 15);
            this.smartLabel2.TabIndex = 241;
            this.smartLabel2.Text = "Requisition By ";
            this.smartLabel2.Click += new System.EventHandler(this.smartLabel2_Click);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(508, 73);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(61, 15);
            this.smartLabel10.TabIndex = 239;
            this.smartLabel10.Text = "Remarks ";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(9, 105);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(65, 15);
            this.smartLabel1.TabIndex = 236;
            this.smartLabel1.Text = "Pharmacy ";
            // 
            // cboPharmacy
            // 
            this.cboPharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPharmacy.ForeColor = System.Drawing.Color.Blue;
            this.cboPharmacy.FormattingEnabled = true;
            this.cboPharmacy.Location = new System.Drawing.Point(135, 97);
            this.cboPharmacy.Name = "cboPharmacy";
            this.cboPharmacy.Size = new System.Drawing.Size(260, 26);
            this.cboPharmacy.TabIndex = 2;
            this.cboPharmacy.SelectedIndexChanged += new System.EventHandler(this.cboPharmacy_SelectedIndexChanged);
            this.cboPharmacy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPharmacy_KeyPress);
            // 
            // dgvProduction
            // 
            this.dgvProduction.AllowUserToAddRows = false;
            this.dgvProduction.AllowUserToDeleteRows = false;
            this.dgvProduction.AllowUserToOrderColumns = true;
            this.dgvProduction.AllowUserToResizeColumns = false;
            this.dgvProduction.AllowUserToResizeRows = false;
            this.dgvProduction.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduction.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduction.Location = new System.Drawing.Point(204, 255);
            this.dgvProduction.MultiSelect = false;
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvProduction.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduction.Size = new System.Drawing.Size(260, 31);
            this.dgvProduction.TabIndex = 252;
            this.dgvProduction.TabStop = false;
            this.dgvProduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellClick);
            this.dgvProduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProduction_KeyPress);
            // 
            // lvItemList
            // 
            this.lvItemList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvItemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvItemList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItemList.FullRowSelect = true;
            this.lvItemList.GridLines = true;
            this.lvItemList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvItemList.Location = new System.Drawing.Point(0, 212);
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.Size = new System.Drawing.Size(1016, 389);
            this.lvItemList.TabIndex = 251;
            this.lvItemList.TabStop = false;
            this.lvItemList.UseCompatibleStateImageBehavior = false;
            this.lvItemList.View = System.Windows.Forms.View.Details;
            this.lvItemList.SelectedIndexChanged += new System.EventHandler(this.lvItemList_SelectedIndexChanged);
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.CalendarMonthBackground = System.Drawing.Color.DarkTurquoise;
            this.txtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDeliveryDate.Location = new System.Drawing.Point(876, 14);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(82, 20);
            this.txtDeliveryDate.TabIndex = 5;
            this.txtDeliveryDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReqDate_KeyDown);
            // 
            // labelSlrate
            // 
            this.labelSlrate.AutoSize = true;
            this.labelSlrate.BackColor = System.Drawing.Color.Transparent;
            this.labelSlrate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSlrate.Location = new System.Drawing.Point(328, 685);
            this.labelSlrate.Name = "labelSlrate";
            this.labelSlrate.Size = new System.Drawing.Size(14, 15);
            this.labelSlrate.TabIndex = 147;
            this.labelSlrate.Text = "0";
            this.labelSlrate.Visible = false;
            // 
            // labelRackrate
            // 
            this.labelRackrate.AutoSize = true;
            this.labelRackrate.BackColor = System.Drawing.Color.Transparent;
            this.labelRackrate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelRackrate.Location = new System.Drawing.Point(307, 682);
            this.labelRackrate.Name = "labelRackrate";
            this.labelRackrate.Size = new System.Drawing.Size(14, 15);
            this.labelRackrate.TabIndex = 146;
            this.labelRackrate.Text = "0";
            this.labelRackrate.Visible = false;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelDiscount.Location = new System.Drawing.Point(262, 667);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(14, 15);
            this.labelDiscount.TabIndex = 145;
            this.labelDiscount.Text = "0";
            this.labelDiscount.Visible = false;
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.BackColor = System.Drawing.Color.Transparent;
            this.labelVat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelVat.Location = new System.Drawing.Point(241, 677);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(14, 15);
            this.labelVat.TabIndex = 144;
            this.labelVat.Text = "0";
            this.labelVat.Visible = false;
            // 
            // txtRemQty
            // 
            this.txtRemQty.BackColor = System.Drawing.Color.Linen;
            this.txtRemQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRemQty.Location = new System.Drawing.Point(269, 679);
            this.txtRemQty.Name = "txtRemQty";
            this.txtRemQty.ReadOnly = true;
            this.txtRemQty.Size = new System.Drawing.Size(43, 24);
            this.txtRemQty.TabIndex = 143;
            this.txtRemQty.TabStop = false;
            this.txtRemQty.Visible = false;
            // 
            // txtProdCompName
            // 
            this.txtProdCompName.BackColor = System.Drawing.Color.Linen;
            this.txtProdCompName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdCompName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProdCompName.Location = new System.Drawing.Point(205, 679);
            this.txtProdCompName.Name = "txtProdCompName";
            this.txtProdCompName.ReadOnly = true;
            this.txtProdCompName.Size = new System.Drawing.Size(30, 24);
            this.txtProdCompName.TabIndex = 142;
            this.txtProdCompName.TabStop = false;
            this.txtProdCompName.Visible = false;
            // 
            // txtProdPackName
            // 
            this.txtProdPackName.BackColor = System.Drawing.Color.Linen;
            this.txtProdPackName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdPackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPackName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProdPackName.Location = new System.Drawing.Point(169, 679);
            this.txtProdPackName.Name = "txtProdPackName";
            this.txtProdPackName.ReadOnly = true;
            this.txtProdPackName.Size = new System.Drawing.Size(30, 24);
            this.txtProdPackName.TabIndex = 141;
            this.txtProdPackName.TabStop = false;
            this.txtProdPackName.Visible = false;
            // 
            // txtProdUnitName
            // 
            this.txtProdUnitName.BackColor = System.Drawing.Color.Linen;
            this.txtProdUnitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdUnitName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProdUnitName.Location = new System.Drawing.Point(151, 679);
            this.txtProdUnitName.Name = "txtProdUnitName";
            this.txtProdUnitName.ReadOnly = true;
            this.txtProdUnitName.Size = new System.Drawing.Size(30, 24);
            this.txtProdUnitName.TabIndex = 140;
            this.txtProdUnitName.TabStop = false;
            this.txtProdUnitName.Visible = false;
            // 
            // txtProdGroupName
            // 
            this.txtProdGroupName.BackColor = System.Drawing.Color.Linen;
            this.txtProdGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProdGroupName.Location = new System.Drawing.Point(123, 679);
            this.txtProdGroupName.Name = "txtProdGroupName";
            this.txtProdGroupName.ReadOnly = true;
            this.txtProdGroupName.Size = new System.Drawing.Size(30, 24);
            this.txtProdGroupName.TabIndex = 139;
            this.txtProdGroupName.TabStop = false;
            this.txtProdGroupName.Visible = false;
            // 
            // txtProductionPacketID
            // 
            this.txtProductionPacketID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionPacketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionPacketID.Location = new System.Drawing.Point(70, 679);
            this.txtProductionPacketID.Name = "txtProductionPacketID";
            this.txtProductionPacketID.ReadOnly = true;
            this.txtProductionPacketID.Size = new System.Drawing.Size(31, 24);
            this.txtProductionPacketID.TabIndex = 138;
            this.txtProductionPacketID.Visible = false;
            // 
            // txtProductionUnitID
            // 
            this.txtProductionUnitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionUnitID.Location = new System.Drawing.Point(208, 661);
            this.txtProductionUnitID.Name = "txtProductionUnitID";
            this.txtProductionUnitID.ReadOnly = true;
            this.txtProductionUnitID.Size = new System.Drawing.Size(27, 24);
            this.txtProductionUnitID.TabIndex = 135;
            this.txtProductionUnitID.Visible = false;
            // 
            // txtProductionGroupID
            // 
            this.txtProductionGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionGroupID.Location = new System.Drawing.Point(45, 674);
            this.txtProductionGroupID.Name = "txtProductionGroupID";
            this.txtProductionGroupID.ReadOnly = true;
            this.txtProductionGroupID.Size = new System.Drawing.Size(44, 24);
            this.txtProductionGroupID.TabIndex = 136;
            this.txtProductionGroupID.Visible = false;
            // 
            // txtProductionCompanyID
            // 
            this.txtProductionCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionCompanyID.Location = new System.Drawing.Point(95, 679);
            this.txtProductionCompanyID.Name = "txtProductionCompanyID";
            this.txtProductionCompanyID.ReadOnly = true;
            this.txtProductionCompanyID.Size = new System.Drawing.Size(29, 24);
            this.txtProductionCompanyID.TabIndex = 137;
            this.txtProductionCompanyID.Visible = false;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.BackColor = System.Drawing.Color.Transparent;
            this.labelRate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelRate.Location = new System.Drawing.Point(262, 685);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(14, 15);
            this.labelRate.TabIndex = 148;
            this.labelRate.Text = "0";
            this.labelRate.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(768, 15);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(88, 15);
            this.smartLabel6.TabIndex = 253;
            this.smartLabel6.Text = "Delivery Date :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(9, 19);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(94, 15);
            this.smartLabel5.TabIndex = 255;
            this.smartLabel5.Text = "Requisition No. ";
            this.smartLabel5.Click += new System.EventHandler(this.smartLabel5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(739, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 256;
            this.label1.Text = "*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductionID
            // 
            this.txtProductionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionID.Location = new System.Drawing.Point(7, 183);
            this.txtProductionID.Name = "txtProductionID";
            this.txtProductionID.Size = new System.Drawing.Size(131, 24);
            this.txtProductionID.TabIndex = 259;
            this.txtProductionID.TextChanged += new System.EventHandler(this.txtProductionID_TextChanged);
            this.txtProductionID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductionID_KeyDown_1);
            // 
            // cboCostCenter
            // 
            this.cboCostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCostCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCostCenter.ForeColor = System.Drawing.Color.Blue;
            this.cboCostCenter.FormattingEnabled = true;
            this.cboCostCenter.Location = new System.Drawing.Point(418, 131);
            this.cboCostCenter.Name = "cboCostCenter";
            this.cboCostCenter.Size = new System.Drawing.Size(46, 26);
            this.cboCostCenter.TabIndex = 261;
            this.cboCostCenter.Visible = false;
            // 
            // cboCostCategoey
            // 
            this.cboCostCategoey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCostCategoey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCostCategoey.ForeColor = System.Drawing.Color.Blue;
            this.cboCostCategoey.FormattingEnabled = true;
            this.cboCostCategoey.Location = new System.Drawing.Point(418, 77);
            this.cboCostCategoey.Name = "cboCostCategoey";
            this.cboCostCategoey.Size = new System.Drawing.Size(46, 26);
            this.cboCostCategoey.TabIndex = 260;
            this.cboCostCategoey.Visible = false;
            this.cboCostCategoey.SelectedIndexChanged += new System.EventHandler(this.cboCostCategoey_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(9, 131);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(92, 15);
            this.smartLabel7.TabIndex = 263;
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
            this.cboDrugCompany.Location = new System.Drawing.Point(135, 127);
            this.cboDrugCompany.Name = "cboDrugCompany";
            this.cboDrugCompany.Size = new System.Drawing.Size(260, 26);
            this.cboDrugCompany.TabIndex = 262;
            this.cboDrugCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDrugCompany_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(745, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 268;
            this.label3.Text = "*";
            // 
            // txtSupplier
            // 
            this.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(635, 12);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(109, 24);
            this.txtSupplier.TabIndex = 264;
            this.txtSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            this.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_KeyDown);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.Color.Linen;
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSupplierName.Location = new System.Drawing.Point(635, 40);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(324, 24);
            this.txtSupplierName.TabIndex = 267;
            this.txtSupplierName.TabStop = false;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(508, 43);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(91, 15);
            this.smartLabel11.TabIndex = 266;
            this.smartLabel11.Text = "Supplier Name ";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(508, 15);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(57, 15);
            this.smartLabel8.TabIndex = 265;
            this.smartLabel8.Text = "Supplier ";
            // 
            // dgvSupplierList
            // 
            this.dgvSupplierList.AllowUserToAddRows = false;
            this.dgvSupplierList.AllowUserToDeleteRows = false;
            this.dgvSupplierList.AllowUserToOrderColumns = true;
            this.dgvSupplierList.AllowUserToResizeColumns = false;
            this.dgvSupplierList.AllowUserToResizeRows = false;
            this.dgvSupplierList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplierList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSupplierList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplierList.Location = new System.Drawing.Point(497, 286);
            this.dgvSupplierList.MultiSelect = false;
            this.dgvSupplierList.Name = "dgvSupplierList";
            this.dgvSupplierList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvSupplierList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSupplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplierList.Size = new System.Drawing.Size(256, 29);
            this.dgvSupplierList.TabIndex = 269;
            this.dgvSupplierList.TabStop = false;
            this.dgvSupplierList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellClick);
            this.dgvSupplierList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvSupplierList_KeyPress);
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(618, 16);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(11, 13);
            this.smartLabel9.TabIndex = 270;
            this.smartLabel9.Text = ":";
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(618, 44);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(11, 13);
            this.smartLabel14.TabIndex = 271;
            this.smartLabel14.Text = ":";
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.Location = new System.Drawing.Point(618, 74);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(11, 13);
            this.smartLabel15.TabIndex = 272;
            this.smartLabel15.Text = ":";
            // 
            // smartLabel17
            // 
            this.smartLabel17.AutoSize = true;
            this.smartLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel17.Location = new System.Drawing.Point(618, 109);
            this.smartLabel17.Name = "smartLabel17";
            this.smartLabel17.Size = new System.Drawing.Size(11, 13);
            this.smartLabel17.TabIndex = 273;
            this.smartLabel17.Text = ":";
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.Location = new System.Drawing.Point(118, 20);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(11, 13);
            this.smartLabel18.TabIndex = 274;
            this.smartLabel18.Text = ":";
            // 
            // smartLabel19
            // 
            this.smartLabel19.AutoSize = true;
            this.smartLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel19.Location = new System.Drawing.Point(118, 49);
            this.smartLabel19.Name = "smartLabel19";
            this.smartLabel19.Size = new System.Drawing.Size(11, 13);
            this.smartLabel19.TabIndex = 275;
            this.smartLabel19.Text = ":";
            // 
            // smartLabel20
            // 
            this.smartLabel20.AutoSize = true;
            this.smartLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel20.Location = new System.Drawing.Point(118, 76);
            this.smartLabel20.Name = "smartLabel20";
            this.smartLabel20.Size = new System.Drawing.Size(11, 13);
            this.smartLabel20.TabIndex = 276;
            this.smartLabel20.Text = ":";
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(118, 104);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(11, 13);
            this.smartLabel21.TabIndex = 277;
            this.smartLabel21.Text = ":";
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(118, 132);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(11, 13);
            this.smartLabel22.TabIndex = 278;
            this.smartLabel22.Text = ":";
            // 
            // txtPRID
            // 
            this.txtPRID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRID.Location = new System.Drawing.Point(136, 14);
            this.txtPRID.Name = "txtPRID";
            this.txtPRID.Size = new System.Drawing.Size(162, 24);
            this.txtPRID.TabIndex = 279;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(298, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 25);
            this.btnSearch.TabIndex = 280;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtStock.Location = new System.Drawing.Point(512, 677);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(40, 13);
            this.txtStock.TabIndex = 149;
            this.txtStock.Text = "Stock";
            this.txtStock.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(635, 68);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(324, 24);
            this.txtRemarks.TabIndex = 6;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // txtSlNo
            // 
            this.txtSlNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlNo.Location = new System.Drawing.Point(573, 680);
            this.txtSlNo.Name = "txtSlNo";
            this.txtSlNo.ReadOnly = true;
            this.txtSlNo.Size = new System.Drawing.Size(27, 24);
            this.txtSlNo.TabIndex = 150;
            this.txtSlNo.Visible = false;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(360, 14);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(85, 25);
            this.btnPreview.TabIndex = 310;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnTR
            // 
            this.btnTR.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTR.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTR.ForeColor = System.Drawing.Color.White;
            this.btnTR.Location = new System.Drawing.Point(816, 120);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(85, 25);
            this.btnTR.TabIndex = 311;
            this.btnTR.Text = "TR";
            this.btnTR.UseVisualStyleBackColor = false;
            this.btnTR.Visible = false;
            this.btnTR.Click += new System.EventHandler(this.btnTR_Click);
            // 
            // frmPurchaseRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1019, 735);
            this.Controls.Add(this.txtSlNo);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelSlrate);
            this.Controls.Add(this.labelRackrate);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelVat);
            this.Controls.Add(this.txtRemQty);
            this.Controls.Add(this.txtProdCompName);
            this.Controls.Add(this.txtProdPackName);
            this.Controls.Add(this.txtProdUnitName);
            this.Controls.Add(this.txtProdGroupName);
            this.Controls.Add(this.txtProductionPacketID);
            this.Controls.Add(this.txtProductionUnitID);
            this.Controls.Add(this.txtProductionGroupID);
            this.Controls.Add(this.txtProductionCompanyID);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmPurchaseRequisition";
            this.Load += new System.EventHandler(this.frmPurchaseRequisition_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtProductionCompanyID, 0);
            this.Controls.SetChildIndex(this.txtProductionGroupID, 0);
            this.Controls.SetChildIndex(this.txtProductionUnitID, 0);
            this.Controls.SetChildIndex(this.txtProductionPacketID, 0);
            this.Controls.SetChildIndex(this.txtProdGroupName, 0);
            this.Controls.SetChildIndex(this.txtProdUnitName, 0);
            this.Controls.SetChildIndex(this.txtProdPackName, 0);
            this.Controls.SetChildIndex(this.txtProdCompName, 0);
            this.Controls.SetChildIndex(this.txtRemQty, 0);
            this.Controls.SetChildIndex(this.labelVat, 0);
            this.Controls.SetChildIndex(this.labelDiscount, 0);
            this.Controls.SetChildIndex(this.labelRackrate, 0);
            this.Controls.SetChildIndex(this.labelSlrate, 0);
            this.Controls.SetChildIndex(this.labelRate, 0);
            this.Controls.SetChildIndex(this.txtStock, 0);
            this.Controls.SetChildIndex(this.txtSlNo, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel lblInfo;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.Button btnCloseclk;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartNumericTextBox txtQuantity;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtProductionName;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartTextBox txtRequisitionBy;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboPharmacy;
        private AtiqsControlLibrary.SmartDataGridView dgvProduction;
        private AtiqsControlLibrary.SmartListViewDetails lvItemList;
        private System.Windows.Forms.DateTimePicker txtDeliveryDate;
        private AtiqsControlLibrary.SmartLabel labelSlrate;
        private AtiqsControlLibrary.SmartLabel labelRackrate;
        private AtiqsControlLibrary.SmartLabel labelDiscount;
        private AtiqsControlLibrary.SmartLabel labelVat;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRemQty;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtProdCompName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtProdPackName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtProdUnitName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtProdGroupName;
        private AtiqsControlLibrary.SmartTextBox txtProductionPacketID;
        private AtiqsControlLibrary.SmartTextBox txtProductionUnitID;
        private AtiqsControlLibrary.SmartTextBox txtProductionGroupID;
        private AtiqsControlLibrary.SmartTextBox txtProductionCompanyID;
        private AtiqsControlLibrary.SmartLabel labelRate;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartTextBox txtProductionID;
        private AtiqsControlLibrary.SmartComboBox cboCostCenter;
        private AtiqsControlLibrary.SmartComboBox cboCostCategoey;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboDrugCompany;
        private System.Windows.Forms.Label label3;
        private AtiqsControlLibrary.SmartTextBox txtSupplier;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSupplierName;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartDataGridView dgvSupplierList;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartLabel smartLabel20;
        private AtiqsControlLibrary.SmartLabel smartLabel19;
        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartLabel smartLabel17;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartTextBox txtPRID;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartLabel txtStock;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtSlNo;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnTR;
    }
}
