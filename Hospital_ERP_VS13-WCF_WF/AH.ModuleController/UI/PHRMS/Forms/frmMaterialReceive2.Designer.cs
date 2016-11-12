namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmMaterialReceive2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtChallanNo = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtMrrType = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.txtVoucherNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtMrNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPOQty = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtRemQty = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtChallanDate = new System.Windows.Forms.DateTimePicker();
            this.txtMrrDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.txtPharmacyID = new AtiqsControlLibrary.SmartLabel();
            this.txtPharmacyName = new AtiqsControlLibrary.SmartLabel();
            this.txtSupplierName = new AtiqsControlLibrary.SmartLabel();
            this.txtSupplierID = new AtiqsControlLibrary.SmartLabel();
            this.txtPOID = new AtiqsControlLibrary.SmartTextBox();
            this.grpTree = new System.Windows.Forms.GroupBox();
            this.treeviewPurchaseOrder = new AtiqsControlLibrary.SmartTreeView();
            this.dgvPODetails = new AtiqsControlLibrary.SmartDataGridView();
            this.grpPODetails = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMrrDetails = new AtiqsControlLibrary.SmartDataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPRNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCostCenter = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboCostCategoey = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartDateTextBox1 = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartDateTextBox2 = new AtiqsControlLibrary.SmartDateTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPODetails)).BeginInit();
            this.grpPODetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrrDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1056, 4);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(467, 4);
            this.frmLabel.Size = new System.Drawing.Size(337, 33);
            this.frmLabel.Text = "Goods Receive Notes(GRN)";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartDateTextBox1);
            this.pnlMain.Controls.Add(this.cboCostCenter);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboCostCategoey);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtPRNo);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtDateTimePicker);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.grpPODetails);
            this.pnlMain.Controls.Add(this.grpTree);
            this.pnlMain.Controls.Add(this.txtPOID);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.txtMrrDate);
            this.pnlMain.Controls.Add(this.txtChallanDate);
            this.pnlMain.Controls.Add(this.txtMrNo);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtChallanNo);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtVoucherNo);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(1243, 621);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1244, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(358, 677);
            this.btnEdit.Size = new System.Drawing.Size(42, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1020, 676);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(406, 677);
            this.btnDelete.Size = new System.Drawing.Size(43, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(909, 676);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1131, 676);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(455, 677);
            this.btnPrint.Size = new System.Drawing.Size(49, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 717);
            this.groupBox1.Size = new System.Drawing.Size(1244, 23);
            // 
            // txtChallanNo
            // 
            this.txtChallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChallanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanNo.Location = new System.Drawing.Point(942, 89);
            this.txtChallanNo.Name = "txtChallanNo";
            this.txtChallanNo.Size = new System.Drawing.Size(91, 24);
            this.txtChallanNo.TabIndex = 134;
            // 
            // txtMrrType
            // 
            this.txtMrrType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMrrType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrrType.Location = new System.Drawing.Point(320, 691);
            this.txtMrrType.Name = "txtMrrType";
            this.txtMrrType.Size = new System.Drawing.Size(23, 24);
            this.txtMrrType.TabIndex = 137;
            this.txtMrrType.Text = "1";
            this.txtMrrType.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(942, 118);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(277, 32);
            this.txtRemarks.TabIndex = 140;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(837, 118);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(68, 18);
            this.smartLabel10.TabIndex = 153;
            this.smartLabel10.Text = "Remarks :";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoucherNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNo.Location = new System.Drawing.Point(443, 357);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(43, 24);
            this.txtVoucherNo.TabIndex = 139;
            this.txtVoucherNo.Text = "1234";
            this.txtVoucherNo.Visible = false;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(1045, 90);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(93, 18);
            this.smartLabel8.TabIndex = 149;
            this.smartLabel8.Text = "Challan Date :";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(837, 92);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(82, 18);
            this.smartLabel7.TabIndex = 147;
            this.smartLabel7.Text = "Challan No :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(837, 67);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(77, 18);
            this.smartLabel5.TabIndex = 141;
            this.smartLabel5.Text = "MRR Date :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(258, 39);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(52, 18);
            this.smartLabel2.TabIndex = 133;
            this.smartLabel2.Text = "PO ID :";
            // 
            // txtMrNo
            // 
            this.txtMrNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtMrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMrNo.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMrNo.Location = new System.Drawing.Point(624, 3);
            this.txtMrNo.Name = "txtMrNo";
            this.txtMrNo.ReadOnly = true;
            this.txtMrNo.Size = new System.Drawing.Size(148, 25);
            this.txtMrNo.TabIndex = 175;
            this.txtMrNo.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(554, 6);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(69, 18);
            this.smartLabel3.TabIndex = 176;
            this.smartLabel3.Text = "GRN No  :";
            // 
            // txtPOQty
            // 
            this.txtPOQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPOQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPOQty.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPOQty.Location = new System.Drawing.Point(18, 677);
            this.txtPOQty.Name = "txtPOQty";
            this.txtPOQty.ReadOnly = true;
            this.txtPOQty.Size = new System.Drawing.Size(65, 25);
            this.txtPOQty.TabIndex = 15;
            this.txtPOQty.TabStop = false;
            this.txtPOQty.Visible = false;
            // 
            // txtRemQty
            // 
            this.txtRemQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtRemQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemQty.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRemQty.Location = new System.Drawing.Point(217, 685);
            this.txtRemQty.Name = "txtRemQty";
            this.txtRemQty.ReadOnly = true;
            this.txtRemQty.Size = new System.Drawing.Size(31, 25);
            this.txtRemQty.TabIndex = 184;
            this.txtRemQty.TabStop = false;
            this.txtRemQty.Visible = false;
            // 
            // txtChallanDate
            // 
            this.txtChallanDate.CalendarMonthBackground = System.Drawing.Color.DarkTurquoise;
            this.txtChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtChallanDate.Location = new System.Drawing.Point(1137, 91);
            this.txtChallanDate.Name = "txtChallanDate";
            this.txtChallanDate.Size = new System.Drawing.Size(95, 20);
            this.txtChallanDate.TabIndex = 189;
            // 
            // txtMrrDate
            // 
            this.txtMrrDate.CalendarMonthBackground = System.Drawing.Color.DarkTurquoise;
            this.txtMrrDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtMrrDate.Location = new System.Drawing.Point(942, 66);
            this.txtMrrDate.Name = "txtMrrDate";
            this.txtMrrDate.Size = new System.Drawing.Size(109, 20);
            this.txtMrrDate.TabIndex = 190;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.smartLabel11);
            this.groupBox2.Controls.Add(this.smartLabel16);
            this.groupBox2.Controls.Add(this.txtPharmacyID);
            this.groupBox2.Controls.Add(this.txtPharmacyName);
            this.groupBox2.Controls.Add(this.txtSupplierName);
            this.groupBox2.Controls.Add(this.txtSupplierID);
            this.groupBox2.Location = new System.Drawing.Point(262, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 72);
            this.groupBox2.TabIndex = 242;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase Order";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(250, 21);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(78, 14);
            this.smartLabel11.TabIndex = 246;
            this.smartLabel11.Text = "Supplier ID :";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(26, 21);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(86, 14);
            this.smartLabel16.TabIndex = 244;
            this.smartLabel16.Text = "Pharmacy ID :";
            // 
            // txtPharmacyID
            // 
            this.txtPharmacyID.AutoSize = true;
            this.txtPharmacyID.BackColor = System.Drawing.Color.Transparent;
            this.txtPharmacyID.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPharmacyID.Location = new System.Drawing.Point(122, 21);
            this.txtPharmacyID.Name = "txtPharmacyID";
            this.txtPharmacyID.Size = new System.Drawing.Size(62, 14);
            this.txtPharmacyID.TabIndex = 227;
            this.txtPharmacyID.Text = "Pharmacy";
            // 
            // txtPharmacyName
            // 
            this.txtPharmacyName.AutoSize = true;
            this.txtPharmacyName.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPharmacyName.ForeColor = System.Drawing.Color.Black;
            this.txtPharmacyName.Location = new System.Drawing.Point(38, 46);
            this.txtPharmacyName.Name = "txtPharmacyName";
            this.txtPharmacyName.Size = new System.Drawing.Size(99, 14);
            this.txtPharmacyName.TabIndex = 229;
            this.txtPharmacyName.Text = "Pharmacy Name";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.AutoSize = true;
            this.txtSupplierName.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSupplierName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierName.Location = new System.Drawing.Point(222, 46);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(91, 14);
            this.txtSupplierName.TabIndex = 230;
            this.txtSupplierName.Text = "Supplier Name";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.AutoSize = true;
            this.txtSupplierID.BackColor = System.Drawing.Color.Transparent;
            this.txtSupplierID.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSupplierID.Location = new System.Drawing.Point(330, 21);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(54, 14);
            this.txtSupplierID.TabIndex = 228;
            this.txtSupplierID.Text = "Supplier";
            // 
            // txtPOID
            // 
            this.txtPOID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPOID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOID.Location = new System.Drawing.Point(324, 36);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(162, 24);
            this.txtPOID.TabIndex = 243;
            // 
            // grpTree
            // 
            this.grpTree.Controls.Add(this.treeviewPurchaseOrder);
            this.grpTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTree.ForeColor = System.Drawing.Color.Green;
            this.grpTree.Location = new System.Drawing.Point(-1, 2);
            this.grpTree.Name = "grpTree";
            this.grpTree.Size = new System.Drawing.Size(254, 614);
            this.grpTree.TabIndex = 244;
            this.grpTree.TabStop = false;
            this.grpTree.Text = "Pending PO";
            // 
            // treeviewPurchaseOrder
            // 
            this.treeviewPurchaseOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.treeviewPurchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeviewPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeviewPurchaseOrder.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeviewPurchaseOrder.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.treeviewPurchaseOrder.LineColor = System.Drawing.Color.BlanchedAlmond;
            this.treeviewPurchaseOrder.Location = new System.Drawing.Point(5, 21);
            this.treeviewPurchaseOrder.Name = "treeviewPurchaseOrder";
            this.treeviewPurchaseOrder.Size = new System.Drawing.Size(243, 587);
            this.treeviewPurchaseOrder.TabIndex = 220;
            this.treeviewPurchaseOrder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeviewPurchaseOrder_AfterSelect);
            // 
            // dgvPODetails
            // 
            this.dgvPODetails.AllowUserToAddRows = false;
            this.dgvPODetails.AllowUserToDeleteRows = false;
            this.dgvPODetails.AllowUserToOrderColumns = true;
            this.dgvPODetails.AllowUserToResizeColumns = false;
            this.dgvPODetails.AllowUserToResizeRows = false;
            this.dgvPODetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvPODetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPODetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPODetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPODetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPODetails.Location = new System.Drawing.Point(6, 19);
            this.dgvPODetails.MultiSelect = false;
            this.dgvPODetails.Name = "dgvPODetails";
            this.dgvPODetails.RowHeadersVisible = false;
            this.dgvPODetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPODetails.Size = new System.Drawing.Size(952, 173);
            this.dgvPODetails.TabIndex = 0;
            this.dgvPODetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPODetails_CellClick);
            // 
            // grpPODetails
            // 
            this.grpPODetails.Controls.Add(this.dgvPODetails);
            this.grpPODetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPODetails.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grpPODetails.Location = new System.Drawing.Point(259, 152);
            this.grpPODetails.Name = "grpPODetails";
            this.grpPODetails.Size = new System.Drawing.Size(967, 201);
            this.grpPODetails.TabIndex = 245;
            this.grpPODetails.TabStop = false;
            this.grpPODetails.Text = "PO Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.smartDateTextBox2);
            this.groupBox3.Controls.Add(this.dgvMrrDetails);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(260, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(965, 221);
            this.groupBox3.TabIndex = 246;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MRR Details";
            // 
            // dgvMrrDetails
            // 
            this.dgvMrrDetails.AllowUserToAddRows = false;
            this.dgvMrrDetails.AllowUserToDeleteRows = false;
            this.dgvMrrDetails.AllowUserToOrderColumns = true;
            this.dgvMrrDetails.AllowUserToResizeColumns = false;
            this.dgvMrrDetails.AllowUserToResizeRows = false;
            this.dgvMrrDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvMrrDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMrrDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMrrDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMrrDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMrrDetails.Location = new System.Drawing.Point(7, 18);
            this.dgvMrrDetails.MultiSelect = false;
            this.dgvMrrDetails.Name = "dgvMrrDetails";
            this.dgvMrrDetails.RowHeadersVisible = false;
            this.dgvMrrDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMrrDetails.Size = new System.Drawing.Size(952, 197);
            this.dgvMrrDetails.TabIndex = 1;
            this.dgvMrrDetails.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMrrDetails_CellBeginEdit);
            this.dgvMrrDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMrrDetails_CellClick_1);
            this.dgvMrrDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMrrDetails_CellContentClick);
            this.dgvMrrDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMrrDetails_CellEndEdit);
            this.dgvMrrDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMrrDetails_CellFormatting);
            this.dgvMrrDetails.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvMrrDetails_Scroll);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1156, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 25);
            this.btnAdd.TabIndex = 247;
            this.btnAdd.Text = ">>>>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDateTimePicker
            // 
            this.txtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateTimePicker.Location = new System.Drawing.Point(596, 358);
            this.txtDateTimePicker.Name = "txtDateTimePicker";
            this.txtDateTimePicker.Size = new System.Drawing.Size(79, 20);
            this.txtDateTimePicker.TabIndex = 248;
            this.txtDateTimePicker.Visible = false;
            // 
            // txtPRNo
            // 
            this.txtPRNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPRNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPRNo.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPRNo.Location = new System.Drawing.Point(324, 3);
            this.txtPRNo.Name = "txtPRNo";
            this.txtPRNo.ReadOnly = true;
            this.txtPRNo.Size = new System.Drawing.Size(162, 25);
            this.txtPRNo.TabIndex = 249;
            this.txtPRNo.TabStop = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(258, 6);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(55, 18);
            this.smartLabel4.TabIndex = 250;
            this.smartLabel4.Text = "PR No  :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(485, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 30);
            this.btnSearch.TabIndex = 251;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1034, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 259;
            this.label1.Text = "*";
            // 
            // cboCostCenter
            // 
            this.cboCostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCostCenter.Font = new System.Drawing.Font("ArialMJ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCostCenter.ForeColor = System.Drawing.Color.Blue;
            this.cboCostCenter.FormattingEnabled = true;
            this.cboCostCenter.Location = new System.Drawing.Point(942, 36);
            this.cboCostCenter.Name = "cboCostCenter";
            this.cboCostCenter.Size = new System.Drawing.Size(226, 26);
            this.cboCostCenter.TabIndex = 269;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(837, 40);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(83, 18);
            this.smartLabel1.TabIndex = 270;
            this.smartLabel1.Text = "Cost Center :";
            // 
            // cboCostCategoey
            // 
            this.cboCostCategoey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCostCategoey.Font = new System.Drawing.Font("ArialMJ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCostCategoey.ForeColor = System.Drawing.Color.Blue;
            this.cboCostCategoey.FormattingEnabled = true;
            this.cboCostCategoey.Location = new System.Drawing.Point(942, 7);
            this.cboCostCategoey.Name = "cboCostCategoey";
            this.cboCostCategoey.Size = new System.Drawing.Size(226, 26);
            this.cboCostCategoey.TabIndex = 267;
            this.cboCostCategoey.SelectedIndexChanged += new System.EventHandler(this.cboCostCategoey_SelectedIndexChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(837, 11);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(96, 18);
            this.smartLabel6.TabIndex = 268;
            this.smartLabel6.Text = "Cost Category :";
            // 
            // smartDateTextBox1
            // 
            this.smartDateTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.smartDateTextBox1.Location = new System.Drawing.Point(672, 38);
            this.smartDateTextBox1.Mask = "00/00/0000";
            this.smartDateTextBox1.Name = "smartDateTextBox1";
            this.smartDateTextBox1.Size = new System.Drawing.Size(100, 24);
            this.smartDateTextBox1.TabIndex = 271;
            this.smartDateTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // smartDateTextBox2
            // 
            this.smartDateTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.smartDateTextBox2.Location = new System.Drawing.Point(39, 153);
            this.smartDateTextBox2.Mask = "00/00/0000";
            this.smartDateTextBox2.Name = "smartDateTextBox2";
            this.smartDateTextBox2.Size = new System.Drawing.Size(100, 24);
            this.smartDateTextBox2.TabIndex = 2;
            this.smartDateTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // frmMaterialReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1244, 740);
            this.Controls.Add(this.txtPOQty);
            this.Controls.Add(this.txtRemQty);
            this.Controls.Add(this.txtMrrType);
            this.isEnterTabAllow = true;
            this.Name = "frmMaterialReceive";
            this.Load += new System.EventHandler(this.frmMaterialReceive_Load);
            this.Controls.SetChildIndex(this.txtMrrType, 0);
            this.Controls.SetChildIndex(this.txtRemQty, 0);
            this.Controls.SetChildIndex(this.txtPOQty, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPODetails)).EndInit();
            this.grpPODetails.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrrDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartNumericTextBox txtChallanNo;
        private AtiqsControlLibrary.SmartTextBox txtMrrType;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartTextBox txtVoucherNo;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMrNo;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPOQty;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRemQty;
        private System.Windows.Forms.DateTimePicker txtChallanDate;
        private System.Windows.Forms.DateTimePicker txtMrrDate;
        private AtiqsControlLibrary.SmartTextBox txtPOID;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartLabel txtPharmacyID;
        private AtiqsControlLibrary.SmartLabel txtPharmacyName;
        private AtiqsControlLibrary.SmartLabel txtSupplierName;
        private AtiqsControlLibrary.SmartLabel txtSupplierID;
        private System.Windows.Forms.GroupBox grpTree;
        private AtiqsControlLibrary.SmartTreeView treeviewPurchaseOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpPODetails;
        private AtiqsControlLibrary.SmartDataGridView dgvPODetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker txtDateTimePicker;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPRNo;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartComboBox cboCostCenter;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboCostCategoey;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartDataGridView dgvMrrDetails;
        private AtiqsControlLibrary.SmartDateTextBox smartDateTextBox1;
        private AtiqsControlLibrary.SmartDateTextBox smartDateTextBox2;
    }
}
