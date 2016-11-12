namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmPurchaseReturn
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
            this.treeviewPurchaseReturn = new AtiqsControlLibrary.SmartTreeView();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtStoreName = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtReturnID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtSupplierName = new AtiqsControlLibrary.SmartLabel();
            this.txtSupplierID = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtStoreID = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtReturnTypeID = new AtiqsControlLibrary.SmartTextBox();
            this.txtRetCauseID = new AtiqsControlLibrary.SmartTextBox();
            this.txtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtMrrID = new AtiqsControlLibrary.SmartTextBox();
            this.lblNo = new AtiqsControlLibrary.SmartLabel();
            this.grpPODetails = new System.Windows.Forms.GroupBox();
            this.dgvMrrDetails = new System.Windows.Forms.DataGridView();
            this.grpPurchaseReturn = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseReturn = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtPOID = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpPODetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrrDetails)).BeginInit();
            this.grpPurchaseReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(339, 9);
            this.frmLabel.Size = new System.Drawing.Size(210, 33);
            this.frmLabel.Tag = "4";
            this.frmLabel.Text = "Purchase Return";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtPOID);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.grpPurchaseReturn);
            this.pnlMain.Controls.Add(this.grpPODetails);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtReturnID);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtReturnTypeID);
            this.pnlMain.Controls.Add(this.txtRetCauseID);
            this.pnlMain.Controls.Add(this.txtReturnDate);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtMrrID);
            this.pnlMain.Controls.Add(this.lblNo);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(897, 661);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(899, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(58, 722);
            this.btnEdit.Size = new System.Drawing.Size(43, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(670, 722);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(107, 722);
            this.btnDelete.Size = new System.Drawing.Size(45, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(557, 722);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(781, 722);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(158, 722);
            this.btnPrint.Size = new System.Drawing.Size(38, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 761);
            this.groupBox1.Size = new System.Drawing.Size(899, 25);
            // 
            // treeviewPurchaseReturn
            // 
            this.treeviewPurchaseReturn.BackColor = System.Drawing.Color.LightYellow;
            this.treeviewPurchaseReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeviewPurchaseReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeviewPurchaseReturn.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeviewPurchaseReturn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeviewPurchaseReturn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.treeviewPurchaseReturn.LineColor = System.Drawing.Color.Crimson;
            this.treeviewPurchaseReturn.Location = new System.Drawing.Point(6, 731);
            this.treeviewPurchaseReturn.Name = "treeviewPurchaseReturn";
            this.treeviewPurchaseReturn.Size = new System.Drawing.Size(40, 24);
            this.treeviewPurchaseReturn.TabIndex = 220;
            this.treeviewPurchaseReturn.Visible = false;
            this.treeviewPurchaseReturn.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeviewPurchaseReturn_AfterSelect);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(213, 46);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(97, 14);
            this.smartLabel6.TabIndex = 247;
            this.smartLabel6.Text = "Supplier Name :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(6, 46);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(79, 14);
            this.smartLabel4.TabIndex = 245;
            this.smartLabel4.Text = "Store Name :";
            // 
            // txtStoreName
            // 
            this.txtStoreName.AutoSize = true;
            this.txtStoreName.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStoreName.ForeColor = System.Drawing.Color.Black;
            this.txtStoreName.Location = new System.Drawing.Point(84, 46);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(73, 14);
            this.txtStoreName.TabIndex = 229;
            this.txtStoreName.Text = "Store Name";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(379, 16);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(72, 15);
            this.smartLabel7.TabIndex = 255;
            this.smartLabel7.Text = "Return ID : ";
            this.smartLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.smartLabel7.Click += new System.EventHandler(this.smartLabel7_Click);
            // 
            // txtReturnID
            // 
            this.txtReturnID.BackColor = System.Drawing.Color.Linen;
            this.txtReturnID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtReturnID.Location = new System.Drawing.Point(459, 13);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.ReadOnly = true;
            this.txtReturnID.Size = new System.Drawing.Size(156, 24);
            this.txtReturnID.TabIndex = 254;
            this.txtReturnID.TabStop = false;
            this.txtReturnID.TextChanged += new System.EventHandler(this.txtReturnID_TextChanged);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(227, 21);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(78, 14);
            this.smartLabel5.TabIndex = 246;
            this.smartLabel5.Text = "Supplier ID :";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.AutoSize = true;
            this.txtSupplierName.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSupplierName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierName.Location = new System.Drawing.Point(307, 46);
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
            this.txtSupplierID.Location = new System.Drawing.Point(307, 21);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(54, 14);
            this.txtSupplierID.TabIndex = 228;
            this.txtSupplierID.Text = "Supplier";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(561, 101);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(68, 15);
            this.smartLabel8.TabIndex = 257;
            this.smartLabel8.Text = "Remarks : ";
            this.smartLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(20, 21);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(60, 14);
            this.smartLabel3.TabIndex = 244;
            this.smartLabel3.Text = "Store ID :";
            // 
            // txtStoreID
            // 
            this.txtStoreID.AutoSize = true;
            this.txtStoreID.BackColor = System.Drawing.Color.Transparent;
            this.txtStoreID.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStoreID.Location = new System.Drawing.Point(84, 21);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(36, 14);
            this.txtStoreID.TabIndex = 227;
            this.txtStoreID.Text = "Store";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.smartLabel6);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.txtStoreID);
            this.groupBox2.Controls.Add(this.txtStoreName);
            this.groupBox2.Controls.Add(this.txtSupplierName);
            this.groupBox2.Controls.Add(this.txtSupplierID);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 72);
            this.groupBox2.TabIndex = 253;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GRN Details";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(234, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSearch_KeyPress);
            // 
            // txtReturnTypeID
            // 
            this.txtReturnTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnTypeID.Location = new System.Drawing.Point(333, 390);
            this.txtReturnTypeID.Name = "txtReturnTypeID";
            this.txtReturnTypeID.Size = new System.Drawing.Size(33, 24);
            this.txtReturnTypeID.TabIndex = 251;
            this.txtReturnTypeID.Text = "001";
            this.txtReturnTypeID.Visible = false;
            // 
            // txtRetCauseID
            // 
            this.txtRetCauseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRetCauseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetCauseID.Location = new System.Drawing.Point(294, 390);
            this.txtRetCauseID.Name = "txtRetCauseID";
            this.txtRetCauseID.Size = new System.Drawing.Size(33, 24);
            this.txtRetCauseID.TabIndex = 250;
            this.txtRetCauseID.Text = "001";
            this.txtRetCauseID.Visible = false;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtReturnDate.Location = new System.Drawing.Point(734, 15);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(123, 20);
            this.txtReturnDate.TabIndex = 2;
            this.txtReturnDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReturnDate_KeyPress);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(679, 19);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(42, 13);
            this.smartLabel1.TabIndex = 248;
            this.smartLabel1.Text = "Date :";
            // 
            // txtMrrID
            // 
            this.txtMrrID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMrrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrrID.Location = new System.Drawing.Point(85, 13);
            this.txtMrrID.Name = "txtMrrID";
            this.txtMrrID.Size = new System.Drawing.Size(149, 24);
            this.txtMrrID.TabIndex = 0;
            this.txtMrrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMrrID_KeyPress);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNo.Location = new System.Drawing.Point(17, 16);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(62, 15);
            this.lblNo.TabIndex = 247;
            this.lblNo.Text = "GRN No : ";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpPODetails
            // 
            this.grpPODetails.Controls.Add(this.dgvMrrDetails);
            this.grpPODetails.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPODetails.ForeColor = System.Drawing.Color.Black;
            this.grpPODetails.Location = new System.Drawing.Point(11, 167);
            this.grpPODetails.Name = "grpPODetails";
            this.grpPODetails.Size = new System.Drawing.Size(842, 217);
            this.grpPODetails.TabIndex = 258;
            this.grpPODetails.TabStop = false;
            this.grpPODetails.Text = "GRN Details";
            // 
            // dgvMrrDetails
            // 
            this.dgvMrrDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMrrDetails.Location = new System.Drawing.Point(9, 19);
            this.dgvMrrDetails.Name = "dgvMrrDetails";
            this.dgvMrrDetails.Size = new System.Drawing.Size(826, 186);
            this.dgvMrrDetails.TabIndex = 60;
            // 
            // grpPurchaseReturn
            // 
            this.grpPurchaseReturn.Controls.Add(this.dgvPurchaseReturn);
            this.grpPurchaseReturn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPurchaseReturn.ForeColor = System.Drawing.Color.Black;
            this.grpPurchaseReturn.Location = new System.Drawing.Point(10, 415);
            this.grpPurchaseReturn.Name = "grpPurchaseReturn";
            this.grpPurchaseReturn.Size = new System.Drawing.Size(873, 237);
            this.grpPurchaseReturn.TabIndex = 259;
            this.grpPurchaseReturn.TabStop = false;
            this.grpPurchaseReturn.Text = "Purchase Return";
            // 
            // dgvPurchaseReturn
            // 
            this.dgvPurchaseReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseReturn.Location = new System.Drawing.Point(10, 20);
            this.dgvPurchaseReturn.Name = "dgvPurchaseReturn";
            this.dgvPurchaseReturn.Size = new System.Drawing.Size(853, 209);
            this.dgvPurchaseReturn.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(856, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 25);
            this.btnAdd.TabIndex = 260;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(17, 58);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(52, 13);
            this.smartLabel2.TabIndex = 261;
            this.smartLabel2.Text = "PO No :";
            // 
            // txtPOID
            // 
            this.txtPOID.AutoSize = true;
            this.txtPOID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPOID.Location = new System.Drawing.Point(85, 58);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(75, 13);
            this.txtPOID.TabIndex = 262;
            this.txtPOID.Text = "smartLabel9";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(558, 123);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(325, 24);
            this.txtRemarks.TabIndex = 263;
            // 
            // frmPurchaseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(899, 786);
            this.Controls.Add(this.treeviewPurchaseReturn);
            this.isEnterTabAllow = true;
            this.Name = "frmPurchaseReturn";
            this.Load += new System.EventHandler(this.frmPurchaseReturn_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.treeviewPurchaseReturn, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpPODetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrrDetails)).EndInit();
            this.grpPurchaseReturn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTreeView treeviewPurchaseReturn;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtReturnID;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel txtStoreID;
        private AtiqsControlLibrary.SmartLabel txtStoreName;
        private AtiqsControlLibrary.SmartLabel txtSupplierName;
        private AtiqsControlLibrary.SmartLabel txtSupplierID;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartTextBox txtReturnTypeID;
        private AtiqsControlLibrary.SmartTextBox txtRetCauseID;
        private System.Windows.Forms.DateTimePicker txtReturnDate;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtMrrID;
        private AtiqsControlLibrary.SmartLabel lblNo;
        private System.Windows.Forms.GroupBox grpPODetails;
        private System.Windows.Forms.GroupBox grpPurchaseReturn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMrrDetails;
        private System.Windows.Forms.DataGridView dgvPurchaseReturn;
        private AtiqsControlLibrary.SmartLabel txtPOID;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
    }
}
