namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmTransferReceive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trList = new AtiqsControlLibrary.SmartTreeView();
            this.txtPharmacy = new AtiqsControlLibrary.SmartTextBox();
            this.grpTree = new System.Windows.Forms.GroupBox();
            this.dgvTRDetails = new AtiqsControlLibrary.SmartDataGridView();
            this.grpPRDetails = new System.Windows.Forms.GroupBox();
            this.txtTRID = new AtiqsControlLibrary.SmartTextBox();
            this.dgvStockDetails = new AtiqsControlLibrary.SmartDataGridView();
            this.grpStockDet = new System.Windows.Forms.GroupBox();
            this.btnCloseStockDetails = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTransferReceive = new AtiqsControlLibrary.SmartDataGridView();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtPR = new AtiqsControlLibrary.SmartLabel();
            this.txtPO = new AtiqsControlLibrary.SmartLabel();
            this.txtGRN = new AtiqsControlLibrary.SmartLabel();
            this.txtTransNo = new AtiqsControlLibrary.SmartLabel();
            this.txtChallanNo = new AtiqsControlLibrary.SmartLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtToPhar = new AtiqsControlLibrary.SmartLabel();
            this.txtFromPhar = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtChallanDate = new System.Windows.Forms.MaskedTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.txttoPharmacy = new AtiqsControlLibrary.SmartTextBox();
            this.txtfromPharmacy = new AtiqsControlLibrary.SmartTextBox();
            this.txtTrrQty = new AtiqsControlLibrary.SmartTextBox();
            this.txtSumTrrQty = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.grpTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTRDetails)).BeginInit();
            this.grpPRDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).BeginInit();
            this.grpStockDet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferReceive)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(401, 9);
            this.frmLabel.Size = new System.Drawing.Size(415, 33);
            this.frmLabel.Text = "Pharmacy Drug Transfer(Receive)";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtTransactionDate);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.btnCloseStockDetails);
            this.pnlMain.Controls.Add(this.btnAddItems);
            this.pnlMain.Controls.Add(this.grpStockDet);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.grpPRDetails);
            this.pnlMain.Location = new System.Drawing.Point(0, 59);
            this.pnlMain.Size = new System.Drawing.Size(1210, 636);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1210, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(461, 699);
            this.btnEdit.Size = new System.Drawing.Size(33, 39);
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(986, 699);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 705);
            this.btnDelete.Size = new System.Drawing.Size(32, 33);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(876, 699);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1095, 699);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(63, 705);
            this.btnPrint.Size = new System.Drawing.Size(25, 33);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 739);
            this.groupBox1.Size = new System.Drawing.Size(1210, 25);
            // 
            // trList
            // 
            this.trList.BackColor = System.Drawing.Color.LightYellow;
            this.trList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trList.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.trList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trList.ForeColor = System.Drawing.Color.RoyalBlue;
            this.trList.LineColor = System.Drawing.Color.Crimson;
            this.trList.Location = new System.Drawing.Point(3, 20);
            this.trList.Name = "trList";
            this.trList.Size = new System.Drawing.Size(189, 603);
            this.trList.TabIndex = 1;
            this.trList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trList_AfterSelect);
            // 
            // txtPharmacy
            // 
            this.txtPharmacy.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPharmacy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharmacy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPharmacy.Location = new System.Drawing.Point(113, 708);
            this.txtPharmacy.Name = "txtPharmacy";
            this.txtPharmacy.Size = new System.Drawing.Size(34, 24);
            this.txtPharmacy.TabIndex = 5;
            // 
            // grpTree
            // 
            this.grpTree.BackColor = System.Drawing.Color.White;
            this.grpTree.Controls.Add(this.trList);
            this.grpTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTree.ForeColor = System.Drawing.Color.Green;
            this.grpTree.Location = new System.Drawing.Point(1, 60);
            this.grpTree.Name = "grpTree";
            this.grpTree.Size = new System.Drawing.Size(200, 630);
            this.grpTree.TabIndex = 224;
            this.grpTree.TabStop = false;
            this.grpTree.Text = "Requisition";
            // 
            // dgvTRDetails
            // 
            this.dgvTRDetails.AllowUserToAddRows = false;
            this.dgvTRDetails.AllowUserToDeleteRows = false;
            this.dgvTRDetails.AllowUserToOrderColumns = true;
            this.dgvTRDetails.AllowUserToResizeColumns = false;
            this.dgvTRDetails.AllowUserToResizeRows = false;
            this.dgvTRDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvTRDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTRDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTRDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTRDetails.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTRDetails.Location = new System.Drawing.Point(7, 18);
            this.dgvTRDetails.MultiSelect = false;
            this.dgvTRDetails.Name = "dgvTRDetails";
            this.dgvTRDetails.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvTRDetails.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTRDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTRDetails.Size = new System.Drawing.Size(978, 179);
            this.dgvTRDetails.TabIndex = 0;
            this.dgvTRDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTRDetails_CellClick);
            // 
            // grpPRDetails
            // 
            this.grpPRDetails.Controls.Add(this.dgvTRDetails);
            this.grpPRDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPRDetails.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grpPRDetails.Location = new System.Drawing.Point(209, 108);
            this.grpPRDetails.Name = "grpPRDetails";
            this.grpPRDetails.Size = new System.Drawing.Size(992, 203);
            this.grpPRDetails.TabIndex = 236;
            this.grpPRDetails.TabStop = false;
            this.grpPRDetails.Text = "TR Details";
            // 
            // txtTRID
            // 
            this.txtTRID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRID.Location = new System.Drawing.Point(264, 705);
            this.txtTRID.Name = "txtTRID";
            this.txtTRID.Size = new System.Drawing.Size(67, 24);
            this.txtTRID.TabIndex = 237;
            this.txtTRID.Visible = false;
            // 
            // dgvStockDetails
            // 
            this.dgvStockDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvStockDetails.AllowUserToAddRows = false;
            this.dgvStockDetails.AllowUserToDeleteRows = false;
            this.dgvStockDetails.AllowUserToOrderColumns = true;
            this.dgvStockDetails.AllowUserToResizeColumns = false;
            this.dgvStockDetails.AllowUserToResizeRows = false;
            this.dgvStockDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStockDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockDetails.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvStockDetails.Location = new System.Drawing.Point(8, 19);
            this.dgvStockDetails.MultiSelect = false;
            this.dgvStockDetails.Name = "dgvStockDetails";
            this.dgvStockDetails.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.dgvStockDetails.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvStockDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockDetails.Size = new System.Drawing.Size(568, 67);
            this.dgvStockDetails.TabIndex = 0;
            this.dgvStockDetails.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvStockDetails_CellValidating);
            // 
            // grpStockDet
            // 
            this.grpStockDet.Controls.Add(this.dgvStockDetails);
            this.grpStockDet.Location = new System.Drawing.Point(209, 314);
            this.grpStockDet.Name = "grpStockDet";
            this.grpStockDet.Size = new System.Drawing.Size(585, 97);
            this.grpStockDet.TabIndex = 288;
            this.grpStockDet.TabStop = false;
            this.grpStockDet.Text = "Item Stock Details";
            // 
            // btnCloseStockDetails
            // 
            this.btnCloseStockDetails.BackColor = System.Drawing.Color.Red;
            this.btnCloseStockDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseStockDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseStockDetails.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseStockDetails.ForeColor = System.Drawing.Color.Black;
            this.btnCloseStockDetails.Location = new System.Drawing.Point(868, 373);
            this.btnCloseStockDetails.Name = "btnCloseStockDetails";
            this.btnCloseStockDetails.Size = new System.Drawing.Size(50, 25);
            this.btnCloseStockDetails.TabIndex = 291;
            this.btnCloseStockDetails.Text = "Close";
            this.btnCloseStockDetails.UseVisualStyleBackColor = false;
            this.btnCloseStockDetails.Click += new System.EventHandler(this.btnCloseStockDetails_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItems.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.Black;
            this.btnAddItems.Location = new System.Drawing.Point(866, 342);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(52, 25);
            this.btnAddItems.TabIndex = 290;
            this.btnAddItems.Text = "Add";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(941, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 25);
            this.btnAdd.TabIndex = 289;
            this.btnAdd.Text = ">>>>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTransferReceive);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(209, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 210);
            this.groupBox2.TabIndex = 292;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer Receive";
            // 
            // dgvTransferReceive
            // 
            this.dgvTransferReceive.AllowUserToAddRows = false;
            this.dgvTransferReceive.AllowUserToDeleteRows = false;
            this.dgvTransferReceive.AllowUserToOrderColumns = true;
            this.dgvTransferReceive.AllowUserToResizeColumns = false;
            this.dgvTransferReceive.AllowUserToResizeRows = false;
            this.dgvTransferReceive.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransferReceive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTransferReceive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTransferReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransferReceive.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTransferReceive.Location = new System.Drawing.Point(8, 21);
            this.dgvTransferReceive.MultiSelect = false;
            this.dgvTransferReceive.Name = "dgvTransferReceive";
            this.dgvTransferReceive.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            this.dgvTransferReceive.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTransferReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransferReceive.Size = new System.Drawing.Size(977, 179);
            this.dgvTransferReceive.TabIndex = 0;
            this.dgvTransferReceive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransferReceive_CellContentClick_1);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(4, 13);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(52, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "PR No :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(4, 39);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(52, 13);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "PO No :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(332, 13);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(77, 13);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "Challan No :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(321, 39);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(88, 13);
            this.smartLabel4.TabIndex = 3;
            this.smartLabel4.Text = "Challan Date :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(161, 39);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(64, 13);
            this.smartLabel5.TabIndex = 4;
            this.smartLabel5.Text = "TR Type :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(163, 13);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(62, 13);
            this.smartLabel6.TabIndex = 5;
            this.smartLabel6.Text = "GRN No :";
            // 
            // txtPR
            // 
            this.txtPR.AutoSize = true;
            this.txtPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPR.Location = new System.Drawing.Point(56, 13);
            this.txtPR.Name = "txtPR";
            this.txtPR.Size = new System.Drawing.Size(24, 13);
            this.txtPR.TabIndex = 6;
            this.txtPR.Text = "PR";
            // 
            // txtPO
            // 
            this.txtPO.AutoSize = true;
            this.txtPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPO.Location = new System.Drawing.Point(56, 39);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(24, 13);
            this.txtPO.TabIndex = 7;
            this.txtPO.Text = "PO";
            // 
            // txtGRN
            // 
            this.txtGRN.AutoSize = true;
            this.txtGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtGRN.Location = new System.Drawing.Point(225, 13);
            this.txtGRN.Name = "txtGRN";
            this.txtGRN.Size = new System.Drawing.Size(34, 13);
            this.txtGRN.TabIndex = 8;
            this.txtGRN.Text = "GRN";
            // 
            // txtTransNo
            // 
            this.txtTransNo.AutoSize = true;
            this.txtTransNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTransNo.Location = new System.Drawing.Point(225, 39);
            this.txtTransNo.Name = "txtTransNo";
            this.txtTransNo.Size = new System.Drawing.Size(53, 13);
            this.txtTransNo.TabIndex = 9;
            this.txtTransNo.Text = "Transac";
            // 
            // txtChallanNo
            // 
            this.txtChallanNo.AutoSize = true;
            this.txtChallanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtChallanNo.Location = new System.Drawing.Point(411, 13);
            this.txtChallanNo.Name = "txtChallanNo";
            this.txtChallanNo.Size = new System.Drawing.Size(65, 13);
            this.txtChallanNo.TabIndex = 10;
            this.txtChallanNo.Text = "ChallanNo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtToPhar);
            this.panel2.Controls.Add(this.txtFromPhar);
            this.panel2.Controls.Add(this.smartLabel10);
            this.panel2.Controls.Add(this.smartLabel9);
            this.panel2.Controls.Add(this.txtChallanDate);
            this.panel2.Controls.Add(this.txtChallanNo);
            this.panel2.Controls.Add(this.txtTransNo);
            this.panel2.Controls.Add(this.txtGRN);
            this.panel2.Controls.Add(this.txtPO);
            this.panel2.Controls.Add(this.txtPR);
            this.panel2.Controls.Add(this.smartLabel6);
            this.panel2.Controls.Add(this.smartLabel5);
            this.panel2.Controls.Add(this.smartLabel4);
            this.panel2.Controls.Add(this.smartLabel3);
            this.panel2.Controls.Add(this.smartLabel2);
            this.panel2.Controls.Add(this.smartLabel1);
            this.panel2.Location = new System.Drawing.Point(217, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 69);
            this.panel2.TabIndex = 293;
            // 
            // txtToPhar
            // 
            this.txtToPhar.AutoSize = true;
            this.txtToPhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtToPhar.Location = new System.Drawing.Point(607, 39);
            this.txtToPhar.Name = "txtToPhar";
            this.txtToPhar.Size = new System.Drawing.Size(48, 13);
            this.txtToPhar.TabIndex = 15;
            this.txtToPhar.Text = "ToPhar";
            // 
            // txtFromPhar
            // 
            this.txtFromPhar.AutoSize = true;
            this.txtFromPhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtFromPhar.Location = new System.Drawing.Point(607, 13);
            this.txtFromPhar.Name = "txtFromPhar";
            this.txtFromPhar.Size = new System.Drawing.Size(60, 13);
            this.txtFromPhar.TabIndex = 14;
            this.txtFromPhar.Text = "FromPhar";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(502, 39);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(89, 13);
            this.smartLabel10.TabIndex = 13;
            this.smartLabel10.Text = "To Pharmacy :";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(502, 13);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(101, 13);
            this.smartLabel9.TabIndex = 12;
            this.smartLabel9.Text = "From Pharmacy :";
            // 
            // txtChallanDate
            // 
            this.txtChallanDate.Location = new System.Drawing.Point(411, 35);
            this.txtChallanDate.Mask = "00/00/0000";
            this.txtChallanDate.Name = "txtChallanDate";
            this.txtChallanDate.Size = new System.Drawing.Size(82, 20);
            this.txtChallanDate.TabIndex = 11;
            this.txtChallanDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(934, 62);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(267, 24);
            this.txtRemarks.TabIndex = 294;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(931, 43);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(64, 13);
            this.smartLabel7.TabIndex = 295;
            this.smartLabel7.Text = "Remarks :";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(931, 20);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(113, 13);
            this.smartLabel8.TabIndex = 296;
            this.smartLabel8.Text = "Transaction Date :";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTransactionDate.Location = new System.Drawing.Point(1050, 16);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(101, 20);
            this.txtTransactionDate.TabIndex = 297;
            // 
            // txttoPharmacy
            // 
            this.txttoPharmacy.BackColor = System.Drawing.Color.RoyalBlue;
            this.txttoPharmacy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttoPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoPharmacy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txttoPharmacy.Location = new System.Drawing.Point(153, 708);
            this.txttoPharmacy.Name = "txttoPharmacy";
            this.txttoPharmacy.Size = new System.Drawing.Size(27, 24);
            this.txttoPharmacy.TabIndex = 238;
            // 
            // txtfromPharmacy
            // 
            this.txtfromPharmacy.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtfromPharmacy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfromPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromPharmacy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtfromPharmacy.Location = new System.Drawing.Point(186, 705);
            this.txtfromPharmacy.Name = "txtfromPharmacy";
            this.txtfromPharmacy.Size = new System.Drawing.Size(25, 24);
            this.txtfromPharmacy.TabIndex = 239;
            // 
            // txtTrrQty
            // 
            this.txtTrrQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrrQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrrQty.Location = new System.Drawing.Point(377, 705);
            this.txtTrrQty.Name = "txtTrrQty";
            this.txtTrrQty.Size = new System.Drawing.Size(39, 24);
            this.txtTrrQty.TabIndex = 240;
            this.txtTrrQty.Visible = false;
            // 
            // txtSumTrrQty
            // 
            this.txtSumTrrQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumTrrQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumTrrQty.Location = new System.Drawing.Point(549, 705);
            this.txtSumTrrQty.Name = "txtSumTrrQty";
            this.txtSumTrrQty.Size = new System.Drawing.Size(39, 24);
            this.txtSumTrrQty.TabIndex = 241;
            this.txtSumTrrQty.Visible = false;
            // 
            // frmTransferReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1210, 764);
            this.Controls.Add(this.txtSumTrrQty);
            this.Controls.Add(this.txtTrrQty);
            this.Controls.Add(this.txtfromPharmacy);
            this.Controls.Add(this.txttoPharmacy);
            this.Controls.Add(this.txtTRID);
            this.Controls.Add(this.grpTree);
            this.Controls.Add(this.txtPharmacy);
            this.isEnterTabAllow = true;
            this.Name = "frmTransferReceive";
            this.Load += new System.EventHandler(this.frmTransferReceive_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtPharmacy, 0);
            this.Controls.SetChildIndex(this.grpTree, 0);
            this.Controls.SetChildIndex(this.txtTRID, 0);
            this.Controls.SetChildIndex(this.txttoPharmacy, 0);
            this.Controls.SetChildIndex(this.txtfromPharmacy, 0);
            this.Controls.SetChildIndex(this.txtTrrQty, 0);
            this.Controls.SetChildIndex(this.txtSumTrrQty, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTRDetails)).EndInit();
            this.grpPRDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).EndInit();
            this.grpStockDet.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferReceive)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartTreeView trList;
        private AtiqsControlLibrary.SmartTextBox txtPharmacy;
        private System.Windows.Forms.GroupBox grpTree;
        private System.Windows.Forms.GroupBox grpPRDetails;
        private AtiqsControlLibrary.SmartDataGridView dgvTRDetails;
        private AtiqsControlLibrary.SmartTextBox txtTRID;
        private System.Windows.Forms.GroupBox grpStockDet;
        private AtiqsControlLibrary.SmartDataGridView dgvStockDetails;
        private System.Windows.Forms.Button btnCloseStockDetails;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartDataGridView dgvTransferReceive;
        private System.Windows.Forms.Panel panel2;
        private AtiqsControlLibrary.SmartLabel txtChallanNo;
        private AtiqsControlLibrary.SmartLabel txtTransNo;
        private AtiqsControlLibrary.SmartLabel txtGRN;
        private AtiqsControlLibrary.SmartLabel txtPO;
        private AtiqsControlLibrary.SmartLabel txtPR;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private System.Windows.Forms.DateTimePicker txtTransactionDate;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.MaskedTextBox txtChallanDate;
        private AtiqsControlLibrary.SmartTextBox txttoPharmacy;
        private AtiqsControlLibrary.SmartTextBox txtfromPharmacy;
        private AtiqsControlLibrary.SmartTextBox txtTrrQty;
        private AtiqsControlLibrary.SmartTextBox txtSumTrrQty;
        private AtiqsControlLibrary.SmartLabel txtToPhar;
        private AtiqsControlLibrary.SmartLabel txtFromPhar;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
    }
}
