namespace AH.ModuleController.UI.INVMS.Forms
{
    
    partial class frmDemandRequisition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboDRType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboStoreType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtRequisitionBy = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtItemName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.txtItemID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtQuantity = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemainingQty = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnCloseclk = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvItemList = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtCompanyID = new AtiqsControlLibrary.SmartTextBox();
            this.txtGroupID = new AtiqsControlLibrary.SmartTextBox();
            this.txtUnitID = new AtiqsControlLibrary.SmartTextBox();
            this.txtTypeID = new AtiqsControlLibrary.SmartTextBox();
            this.txtModelID = new AtiqsControlLibrary.SmartTextBox();
            this.txtBrandID = new AtiqsControlLibrary.SmartTextBox();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.txtModelName = new AtiqsControlLibrary.SmartTextBox();
            this.txtBrandName = new AtiqsControlLibrary.SmartTextBox();
            this.txtCompanyName = new AtiqsControlLibrary.SmartTextBox();
            this.txtGroupName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMajorGroup = new AtiqsControlLibrary.SmartTextBox();
            this.txtStoreType = new AtiqsControlLibrary.SmartTextBox();
            this.cboStoreLocation = new AtiqsControlLibrary.SmartComboBox();
            this.cboWarehouse = new AtiqsControlLibrary.SmartComboBox();
            this.txtDrID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.dgvItem = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvDrDetails = new AtiqsControlLibrary.SmartDataGridView();
            this.txtDrQty = new AtiqsControlLibrary.SmartTextBox();
            this.txtDRDate = new System.Windows.Forms.MaskedTextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnReqVerifyList = new System.Windows.Forms.Button();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(990, 4);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(497, 6);
            this.frmLabel.Size = new System.Drawing.Size(252, 33);
            this.frmLabel.Text = "Demand Requisition";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.btnReqVerifyList);
            this.pnlMain.Controls.Add(this.btnPreview);
            this.pnlMain.Controls.Add(this.txtDRDate);
            this.pnlMain.Controls.Add(this.dgvItem);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtGroupName);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtDrID);
            this.pnlMain.Controls.Add(this.cboStoreLocation);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.btnCloseclk);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.txtQuantity);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.txtItemName);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.txtItemID);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtRequisitionBy);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboDRType);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboStoreType);
            this.pnlMain.Controls.Add(this.dgvDrDetails);
            this.pnlMain.Location = new System.Drawing.Point(-1, 51);
            this.pnlMain.Size = new System.Drawing.Size(1172, 593);
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1171, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(387, 658);
            this.btnEdit.Size = new System.Drawing.Size(40, 28);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(947, 648);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(438, 658);
            this.btnDelete.Size = new System.Drawing.Size(34, 29);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(837, 648);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1057, 648);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(478, 661);
            this.btnPrint.Size = new System.Drawing.Size(28, 23);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 687);
            this.groupBox1.Size = new System.Drawing.Size(1171, 23);
            // 
            // cboDRType
            // 
            this.cboDRType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDRType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDRType.ForeColor = System.Drawing.Color.Blue;
            this.cboDRType.FormattingEnabled = true;
            this.cboDRType.Location = new System.Drawing.Point(640, 31);
            this.cboDRType.Name = "cboDRType";
            this.cboDRType.Size = new System.Drawing.Size(30, 26);
            this.cboDRType.TabIndex = 3;
            this.cboDRType.Visible = false;
            this.cboDRType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDRType_KeyDown);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(735, 98);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(65, 15);
            this.smartLabel10.TabIndex = 27;
            this.smartLabel10.Text = "Remarks :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(735, 73);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(60, 15);
            this.smartLabel5.TabIndex = 25;
            this.smartLabel5.Text = "DR Date :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(12, 81);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(72, 15);
            this.smartLabel1.TabIndex = 22;
            this.smartLabel1.Text = "Store Type :";
            // 
            // cboStoreType
            // 
            this.cboStoreType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreType.ForeColor = System.Drawing.Color.Blue;
            this.cboStoreType.FormattingEnabled = true;
            this.cboStoreType.Location = new System.Drawing.Point(119, 75);
            this.cboStoreType.Name = "cboStoreType";
            this.cboStoreType.Size = new System.Drawing.Size(313, 26);
            this.cboStoreType.TabIndex = 35;
            this.cboStoreType.SelectedIndexChanged += new System.EventHandler(this.cboStoreType_SelectedIndexChanged);
            this.cboStoreType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboStoreLocation_KeyDown);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(735, 40);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(95, 15);
            this.smartLabel2.TabIndex = 29;
            this.smartLabel2.Text = "Requisition By :";
            // 
            // txtRequisitionBy
            // 
            this.txtRequisitionBy.BackColor = System.Drawing.Color.Linen;
            this.txtRequisitionBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequisitionBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequisitionBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRequisitionBy.Location = new System.Drawing.Point(848, 37);
            this.txtRequisitionBy.Name = "txtRequisitionBy";
            this.txtRequisitionBy.ReadOnly = true;
            this.txtRequisitionBy.Size = new System.Drawing.Size(100, 24);
            this.txtRequisitionBy.TabIndex = 33;
            this.txtRequisitionBy.TabStop = false;
            this.txtRequisitionBy.TextChanged += new System.EventHandler(this.txtRequisitionBy_TextChanged);
            this.txtRequisitionBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequisitionBy_KeyDown);
            this.txtRequisitionBy.Leave += new System.EventHandler(this.txtRequisitionBy_Leave);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.Linen;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtItemName.Location = new System.Drawing.Point(119, 143);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(613, 24);
            this.txtItemName.TabIndex = 63;
            this.txtItemName.TabStop = false;
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(125, 122);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(72, 15);
            this.smartLabel13.TabIndex = 64;
            this.smartLabel13.Text = "Item Name :";
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(3, 143);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(116, 24);
            this.txtItemID.TabIndex = 4;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            this.txtItemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemID_KeyDown);
            this.txtItemID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemID_KeyPress);
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(3, 122);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(54, 15);
            this.smartLabel12.TabIndex = 62;
            this.smartLabel12.Text = "Item ID :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(1093, 143);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(66, 24);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(1090, 122);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(55, 15);
            this.smartLabel16.TabIndex = 109;
            this.smartLabel16.Text = "Quantity";
            // 
            // txtRemainingQty
            // 
            this.txtRemainingQty.BackColor = System.Drawing.Color.Linen;
            this.txtRemainingQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemainingQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainingQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRemainingQty.Location = new System.Drawing.Point(174, 660);
            this.txtRemainingQty.Name = "txtRemainingQty";
            this.txtRemainingQty.ReadOnly = true;
            this.txtRemainingQty.Size = new System.Drawing.Size(33, 24);
            this.txtRemainingQty.TabIndex = 112;
            this.txtRemainingQty.TabStop = false;
            this.txtRemainingQty.Visible = false;
            // 
            // btnCloseclk
            // 
            this.btnCloseclk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCloseclk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseclk.ForeColor = System.Drawing.Color.White;
            this.btnCloseclk.Location = new System.Drawing.Point(990, 6);
            this.btnCloseclk.Name = "btnCloseclk";
            this.btnCloseclk.Size = new System.Drawing.Size(32, 24);
            this.btnCloseclk.TabIndex = 129;
            this.btnCloseclk.Text = "<<";
            this.btnCloseclk.UseVisualStyleBackColor = false;
            this.btnCloseclk.Visible = false;
            this.btnCloseclk.Click += new System.EventHandler(this.btnCloseclk_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1045, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAdd_KeyDown);
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
            this.lvItemList.Location = new System.Drawing.Point(726, 655);
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.Size = new System.Drawing.Size(23, 23);
            this.lvItemList.TabIndex = 130;
            this.lvItemList.TabStop = false;
            this.lvItemList.UseCompatibleStateImageBehavior = false;
            this.lvItemList.View = System.Windows.Forms.View.Details;
            this.lvItemList.Visible = false;
            this.lvItemList.SelectedIndexChanged += new System.EventHandler(this.lvItemList_SelectedIndexChanged);
            this.lvItemList.DoubleClick += new System.EventHandler(this.lvItemList_DoubleClick);
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyID.Location = new System.Drawing.Point(17, 660);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.ReadOnly = true;
            this.txtCompanyID.Size = new System.Drawing.Size(27, 24);
            this.txtCompanyID.TabIndex = 27;
            this.txtCompanyID.Visible = false;
            // 
            // txtGroupID
            // 
            this.txtGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupID.Location = new System.Drawing.Point(44, 660);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.ReadOnly = true;
            this.txtGroupID.Size = new System.Drawing.Size(27, 24);
            this.txtGroupID.TabIndex = 28;
            this.txtGroupID.Visible = false;
            // 
            // txtUnitID
            // 
            this.txtUnitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitID.Location = new System.Drawing.Point(71, 660);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(27, 24);
            this.txtUnitID.TabIndex = 29;
            this.txtUnitID.Visible = false;
            // 
            // txtTypeID
            // 
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.Location = new System.Drawing.Point(99, 660);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.ReadOnly = true;
            this.txtTypeID.Size = new System.Drawing.Size(27, 24);
            this.txtTypeID.TabIndex = 30;
            this.txtTypeID.Visible = false;
            // 
            // txtModelID
            // 
            this.txtModelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelID.Location = new System.Drawing.Point(126, 660);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.ReadOnly = true;
            this.txtModelID.Size = new System.Drawing.Size(27, 24);
            this.txtModelID.TabIndex = 31;
            this.txtModelID.Visible = false;
            // 
            // txtBrandID
            // 
            this.txtBrandID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandID.Location = new System.Drawing.Point(155, 660);
            this.txtBrandID.Name = "txtBrandID";
            this.txtBrandID.ReadOnly = true;
            this.txtBrandID.Size = new System.Drawing.Size(27, 24);
            this.txtBrandID.TabIndex = 32;
            this.txtBrandID.Visible = false;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(559, 31);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(32, 26);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.Visible = false;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            this.cboDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDepartment_KeyDown);
            // 
            // txtModelName
            // 
            this.txtModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.Location = new System.Drawing.Point(304, 660);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.ReadOnly = true;
            this.txtModelName.Size = new System.Drawing.Size(27, 24);
            this.txtModelName.TabIndex = 46;
            this.txtModelName.Visible = false;
            // 
            // txtBrandName
            // 
            this.txtBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.Location = new System.Drawing.Point(268, 660);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.ReadOnly = true;
            this.txtBrandName.Size = new System.Drawing.Size(27, 24);
            this.txtBrandName.TabIndex = 45;
            this.txtBrandName.Visible = false;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(241, 660);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(27, 24);
            this.txtCompanyName.TabIndex = 44;
            this.txtCompanyName.Visible = false;
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.Color.Linen;
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtGroupName.Location = new System.Drawing.Point(732, 143);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(361, 24);
            this.txtGroupName.TabIndex = 43;
            this.txtGroupName.TabStop = false;
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(594, 31);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(43, 26);
            this.cboUnit.TabIndex = 134;
            this.cboUnit.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(971, 39);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(88, 15);
            this.lblInfo.TabIndex = 227;
            this.lblInfo.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(949, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 228;
            this.label1.Text = "*";
            // 
            // txtMajorGroup
            // 
            this.txtMajorGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMajorGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajorGroup.Location = new System.Drawing.Point(568, 660);
            this.txtMajorGroup.Name = "txtMajorGroup";
            this.txtMajorGroup.ReadOnly = true;
            this.txtMajorGroup.Size = new System.Drawing.Size(27, 24);
            this.txtMajorGroup.TabIndex = 113;
            this.txtMajorGroup.Visible = false;
            // 
            // txtStoreType
            // 
            this.txtStoreType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreType.Location = new System.Drawing.Point(521, 660);
            this.txtStoreType.Name = "txtStoreType";
            this.txtStoreType.ReadOnly = true;
            this.txtStoreType.Size = new System.Drawing.Size(27, 24);
            this.txtStoreType.TabIndex = 114;
            this.txtStoreType.Visible = false;
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreLocation.ForeColor = System.Drawing.Color.Blue;
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(119, 43);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(313, 26);
            this.cboStoreLocation.TabIndex = 230;
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarehouse.ForeColor = System.Drawing.Color.Blue;
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(650, 655);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(44, 26);
            this.cboWarehouse.TabIndex = 232;
            this.cboWarehouse.Visible = false;
            // 
            // txtDrID
            // 
            this.txtDrID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrID.Location = new System.Drawing.Point(119, 12);
            this.txtDrID.Name = "txtDrID";
            this.txtDrID.Size = new System.Drawing.Size(167, 24);
            this.txtDrID.TabIndex = 1;
            this.txtDrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrID_KeyPress);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(12, 15);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(50, 15);
            this.smartLabel4.TabIndex = 235;
            this.smartLabel4.Text = "DR No :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(286, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSearch_KeyPress);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(848, 97);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(312, 24);
            this.txtRemarks.TabIndex = 3;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
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
            this.dgvItem.Location = new System.Drawing.Point(491, 70);
            this.dgvItem.MultiSelect = false;
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvItem.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(158, 31);
            this.dgvItem.TabIndex = 236;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick_1);
            this.dgvItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvItem_KeyPress_1);
            // 
            // dgvDrDetails
            // 
            this.dgvDrDetails.AllowUserToAddRows = false;
            this.dgvDrDetails.AllowUserToDeleteRows = false;
            this.dgvDrDetails.AllowUserToOrderColumns = true;
            this.dgvDrDetails.AllowUserToResizeColumns = false;
            this.dgvDrDetails.AllowUserToResizeRows = false;
            this.dgvDrDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDrDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDrDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDrDetails.Location = new System.Drawing.Point(3, 173);
            this.dgvDrDetails.MultiSelect = false;
            this.dgvDrDetails.Name = "dgvDrDetails";
            this.dgvDrDetails.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvDrDetails.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDrDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrDetails.Size = new System.Drawing.Size(1163, 414);
            this.dgvDrDetails.TabIndex = 237;
            this.dgvDrDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrDetails_CellClick);
            this.dgvDrDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrDetails_CellContentClick);
            this.dgvDrDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDrDetails_CellFormatting);
            this.dgvDrDetails.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDrDetails_CellValidating);
            // 
            // txtDrQty
            // 
            this.txtDrQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrQty.Location = new System.Drawing.Point(337, 660);
            this.txtDrQty.Name = "txtDrQty";
            this.txtDrQty.ReadOnly = true;
            this.txtDrQty.Size = new System.Drawing.Size(27, 24);
            this.txtDrQty.TabIndex = 115;
            this.txtDrQty.Visible = false;
            // 
            // txtDRDate
            // 
            this.txtDRDate.Location = new System.Drawing.Point(848, 70);
            this.txtDRDate.Mask = "00/00/0000";
            this.txtDRDate.Name = "txtDRDate";
            this.txtDRDate.ReadOnly = true;
            this.txtDRDate.Size = new System.Drawing.Size(100, 20);
            this.txtDRDate.TabIndex = 239;
            this.txtDRDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(347, 12);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(85, 25);
            this.btnPreview.TabIndex = 310;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnReqVerifyList
            // 
            this.btnReqVerifyList.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReqVerifyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReqVerifyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqVerifyList.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqVerifyList.ForeColor = System.Drawing.Color.White;
            this.btnReqVerifyList.Location = new System.Drawing.Point(735, 4);
            this.btnReqVerifyList.Name = "btnReqVerifyList";
            this.btnReqVerifyList.Size = new System.Drawing.Size(141, 25);
            this.btnReqVerifyList.TabIndex = 311;
            this.btnReqVerifyList.Text = "Verified Req. List";
            this.btnReqVerifyList.UseVisualStyleBackColor = false;
            this.btnReqVerifyList.Click += new System.EventHandler(this.btnReqVerifyList_Click);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(735, 122);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(48, 15);
            this.smartLabel7.TabIndex = 312;
            this.smartLabel7.Text = "Group :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(12, 49);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(94, 15);
            this.smartLabel3.TabIndex = 313;
            this.smartLabel3.Text = "Store Location :";
            // 
            // frmDemandRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1171, 710);
            this.Controls.Add(this.txtDrQty);
            this.Controls.Add(this.txtStoreType);
            this.Controls.Add(this.txtMajorGroup);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtRemainingQty);
            this.Controls.Add(this.cboWarehouse);
            this.Controls.Add(this.lvItemList);
            this.Controls.Add(this.txtBrandID);
            this.Controls.Add(this.txtModelID);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.txtCompanyID);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmDemandRequisition";
            this.Load += new System.EventHandler(this.frmDemandRequisition_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtCompanyID, 0);
            this.Controls.SetChildIndex(this.txtGroupID, 0);
            this.Controls.SetChildIndex(this.txtUnitID, 0);
            this.Controls.SetChildIndex(this.txtTypeID, 0);
            this.Controls.SetChildIndex(this.txtModelID, 0);
            this.Controls.SetChildIndex(this.txtBrandID, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.lvItemList, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.cboWarehouse, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtRemainingQty, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtCompanyName, 0);
            this.Controls.SetChildIndex(this.txtBrandName, 0);
            this.Controls.SetChildIndex(this.txtModelName, 0);
            this.Controls.SetChildIndex(this.txtMajorGroup, 0);
            this.Controls.SetChildIndex(this.txtStoreType, 0);
            this.Controls.SetChildIndex(this.txtDrQty, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboDRType;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboStoreType;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRequisitionBy;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtItemName;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartTextBox txtItemID;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRemainingQty;
        private AtiqsControlLibrary.SmartNumericTextBox txtQuantity;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private System.Windows.Forms.Button btnCloseclk;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartListViewDetails lvItemList;
        private AtiqsControlLibrary.SmartTextBox txtCompanyID;
        private AtiqsControlLibrary.SmartTextBox txtGroupID;
        private AtiqsControlLibrary.SmartTextBox txtUnitID;
        private AtiqsControlLibrary.SmartTextBox txtTypeID;
        private AtiqsControlLibrary.SmartTextBox txtModelID;
        private AtiqsControlLibrary.SmartTextBox txtBrandID;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartTextBox txtModelName;
        private AtiqsControlLibrary.SmartTextBox txtBrandName;
        private AtiqsControlLibrary.SmartTextBox txtCompanyName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtGroupName;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel lblInfo;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartTextBox txtMajorGroup;
        private AtiqsControlLibrary.SmartTextBox txtStoreType;
        private AtiqsControlLibrary.SmartComboBox cboStoreLocation;
        private AtiqsControlLibrary.SmartComboBox cboWarehouse;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtDrID;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartDataGridView dgvItem;
        private AtiqsControlLibrary.SmartDataGridView dgvDrDetails;
        private AtiqsControlLibrary.SmartTextBox txtDrQty;
        private System.Windows.Forms.MaskedTextBox txtDRDate;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnReqVerifyList;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
    }
}
