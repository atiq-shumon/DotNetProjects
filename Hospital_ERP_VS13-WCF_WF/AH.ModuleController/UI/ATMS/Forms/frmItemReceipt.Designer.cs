namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmItemReceipt
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.DG = new System.Windows.Forms.DataGridView();
            this.cbostoretype = new System.Windows.Forms.ComboBox();
            this.cboWarehouseType = new System.Windows.Forms.ComboBox();
            this.cboGroupName = new System.Windows.Forms.ComboBox();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.dtevDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.chkClean = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtQty = new AtiqsControlLibrary.SmartTextBox();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.cboModuleName = new System.Windows.Forms.ComboBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.cboNsStnId = new System.Windows.Forms.ComboBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.lvwWarehouse = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRefNo = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(453, 8);
            this.frmLabel.Size = new System.Drawing.Size(201, 33);
            this.frmLabel.Text = "Product Receipt";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtRefNo);
            this.pnlMain.Controls.Add(this.lvwWarehouse);
            this.pnlMain.Controls.Add(this.cboNsStnId);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.cboModuleName);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.dtevDate);
            this.pnlMain.Controls.Add(this.cboWarehouse);
            this.pnlMain.Controls.Add(this.cboGroupName);
            this.pnlMain.Controls.Add(this.cboWarehouseType);
            this.pnlMain.Controls.Add(this.cbostoretype);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(1234, 773);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1237, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(777, 692);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(664, 692);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(890, 692);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(551, 692);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1112, 692);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(1001, 692);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 735);
            this.groupBox1.Size = new System.Drawing.Size(1237, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(37, 192);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(104, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Store Type ID:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(18, 227);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(123, 14);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Warehouse Type:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(69, 160);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(72, 14);
            this.smartLabel4.TabIndex = 3;
            this.smartLabel4.Text = "Group ID:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(488, 249);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(87, 14);
            this.smartLabel5.TabIndex = 4;
            this.smartLabel5.Text = "Warehouse:";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(532, 161);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(43, 14);
            this.smartLabel6.TabIndex = 5;
            this.smartLabel6.Text = "Date:";
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(10, 393);
            this.DG.Name = "DG";
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(882, 325);
            this.DG.TabIndex = 6;
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            // 
            // cbostoretype
            // 
            this.cbostoretype.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostoretype.FormattingEnabled = true;
            this.cbostoretype.Location = new System.Drawing.Point(152, 192);
            this.cbostoretype.Name = "cbostoretype";
            this.cbostoretype.Size = new System.Drawing.Size(254, 24);
            this.cbostoretype.TabIndex = 7;
            this.cbostoretype.SelectedIndexChanged += new System.EventHandler(this.cbostoretype_SelectedIndexChanged);
            this.cbostoretype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbostoretype_KeyPress);
            // 
            // cboWarehouseType
            // 
            this.cboWarehouseType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarehouseType.FormattingEnabled = true;
            this.cboWarehouseType.Location = new System.Drawing.Point(152, 222);
            this.cboWarehouseType.Name = "cboWarehouseType";
            this.cboWarehouseType.Size = new System.Drawing.Size(254, 24);
            this.cboWarehouseType.TabIndex = 8;
            this.cboWarehouseType.SelectedIndexChanged += new System.EventHandler(this.cboWarehouseType_SelectedIndexChanged);
            this.cboWarehouseType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboWarehouseType_KeyPress);
            // 
            // cboGroupName
            // 
            this.cboGroupName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupName.FormattingEnabled = true;
            this.cboGroupName.Location = new System.Drawing.Point(152, 157);
            this.cboGroupName.Name = "cboGroupName";
            this.cboGroupName.Size = new System.Drawing.Size(254, 24);
            this.cboGroupName.TabIndex = 10;
            this.cboGroupName.SelectedIndexChanged += new System.EventHandler(this.cboGroupName_SelectedIndexChanged);
            this.cboGroupName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboGroupName_KeyPress);
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(586, 246);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(254, 24);
            this.cboWarehouse.TabIndex = 11;
            this.cboWarehouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboWarehouse_KeyPress);
            // 
            // dtevDate
            // 
            this.dtevDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtevDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtevDate.Location = new System.Drawing.Point(586, 158);
            this.dtevDate.Name = "dtevDate";
            this.dtevDate.Size = new System.Drawing.Size(254, 23);
            this.dtevDate.TabIndex = 12;
            this.dtevDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtevDate_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.chkClean);
            this.groupBox2.Controls.Add(this.smartLabel9);
            this.groupBox2.Controls.Add(this.smartLabel7);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.cboItemName);
            this.groupBox2.Location = new System.Drawing.Point(14, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 73);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(822, 32);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(41, 23);
            this.btnDown.TabIndex = 26;
            this.btnDown.Text = ">>";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkClean.Enabled = false;
            this.chkClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClean.ForeColor = System.Drawing.Color.Black;
            this.chkClean.Location = new System.Drawing.Point(778, 8);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(54, 22);
            this.chkClean.TabIndex = 25;
            this.chkClean.Text = "Dirty";
            this.chkClean.UseVisualStyleBackColor = true;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(597, 14);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(54, 13);
            this.smartLabel9.TabIndex = 24;
            this.smartLabel9.Text = "Quantity";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(12, 13);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(71, 13);
            this.smartLabel7.TabIndex = 22;
            this.smartLabel7.Text = "Item Name:";
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(522, 35);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(222, 24);
            this.txtQty.TabIndex = 21;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // cboItemName
            // 
            this.cboItemName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(8, 35);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(397, 24);
            this.cboItemName.TabIndex = 19;
            this.cboItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboItemName_KeyPress);
            // 
            // cboModuleName
            // 
            this.cboModuleName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModuleName.FormattingEnabled = true;
            this.cboModuleName.Location = new System.Drawing.Point(586, 187);
            this.cboModuleName.Name = "cboModuleName";
            this.cboModuleName.Size = new System.Drawing.Size(254, 24);
            this.cboModuleName.TabIndex = 21;
            this.cboModuleName.SelectedIndexChanged += new System.EventHandler(this.cboModuleName_SelectedIndexChanged);
            this.cboModuleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboModuleName_KeyPress);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(476, 191);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(99, 14);
            this.smartLabel10.TabIndex = 22;
            this.smartLabel10.Text = "Receipt From:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(230, 735);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(70, 14);
            this.smartLabel3.TabIndex = 24;
            this.smartLabel3.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(309, 732);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(391, 24);
            this.txtRemarks.TabIndex = 23;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // cboNsStnId
            // 
            this.cboNsStnId.Enabled = false;
            this.cboNsStnId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNsStnId.FormattingEnabled = true;
            this.cboNsStnId.Location = new System.Drawing.Point(586, 215);
            this.cboNsStnId.Name = "cboNsStnId";
            this.cboNsStnId.Size = new System.Drawing.Size(254, 24);
            this.cboNsStnId.TabIndex = 26;
            this.cboNsStnId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNsStnId_KeyPress);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(461, 218);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(114, 14);
            this.smartLabel8.TabIndex = 25;
            this.smartLabel8.Text = "Nursing Station:";
            // 
            // lvwWarehouse
            // 
            this.lvwWarehouse.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwWarehouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwWarehouse.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwWarehouse.FullRowSelect = true;
            this.lvwWarehouse.GridLines = true;
            this.lvwWarehouse.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwWarehouse.Location = new System.Drawing.Point(897, 154);
            this.lvwWarehouse.Name = "lvwWarehouse";
            this.lvwWarehouse.Size = new System.Drawing.Size(327, 561);
            this.lvwWarehouse.TabIndex = 27;
            this.lvwWarehouse.UseCompatibleStateImageBehavior = false;
            this.lvwWarehouse.View = System.Windows.Forms.View.Details;
            this.lvwWarehouse.SelectedIndexChanged += new System.EventHandler(this.lvwWarehouse_SelectedIndexChanged);
            // 
            // txtRefNo
            // 
            this.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.Location = new System.Drawing.Point(161, 274);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(222, 24);
            this.txtRefNo.TabIndex = 28;
            this.txtRefNo.Visible = false;
            // 
            // frmItemReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1237, 760);
            this.KeyPreview = false;
            this.Name = "frmItemReceipt";
            this.Load += new System.EventHandler(this.frmItemReceipt_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.DateTimePicker dtevDate;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.ComboBox cboGroupName;
        private System.Windows.Forms.ComboBox cboWarehouseType;
        private System.Windows.Forms.ComboBox cbostoretype;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDown;
        private AtiqsControlLibrary.SmartCheckBox chkClean;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtQty;
        private System.Windows.Forms.ComboBox cboItemName;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private System.Windows.Forms.ComboBox cboModuleName;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private System.Windows.Forms.ComboBox cboNsStnId;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartListViewDetails lvwWarehouse;
        private AtiqsControlLibrary.SmartTextBox txtRefNo;
    }
}
