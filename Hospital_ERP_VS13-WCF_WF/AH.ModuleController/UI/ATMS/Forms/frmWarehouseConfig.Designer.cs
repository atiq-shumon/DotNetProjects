namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmWarehouseConfig
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
            this.lvwWarehouse = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboStatus = new AtiqsControlLibrary.SmartComboBox();
            this.txtWarehouseID = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtWarehouseName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboTypeName = new System.Windows.Forms.ComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboBuildID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboFloorNo = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.cboNsStnId = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.cbocostcategoryName = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.cbocostCenterID = new AtiqsControlLibrary.SmartComboBox();
            this.txtPhoneNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtCantactPerson = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(421, 8);
            this.frmLabel.Size = new System.Drawing.Size(148, 33);
            this.frmLabel.TabIndex = 18;
            this.frmLabel.Text = "Warehouse";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtCantactPerson);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtPhoneNo);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.cbocostCenterID);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.cbocostcategoryName);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.cboNsStnId);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.cboDeptID);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboFloorNo);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboBuildID);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboTypeName);
            this.pnlMain.Controls.Add(this.lvwWarehouse);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboStatus);
            this.pnlMain.Controls.Add(this.txtWarehouseID);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtWarehouseName);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(974, 696);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(976, 58);
            this.pnlTop.TabIndex = 19;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(528, 613);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(415, 613);
            this.btnSave.TabIndex = 14;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(641, 613);
            this.btnDelete.TabIndex = 16;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(302, 613);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(863, 613);
            this.btnClose.TabIndex = 17;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(752, 613);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 653);
            this.groupBox1.Size = new System.Drawing.Size(976, 25);
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
            this.lvwWarehouse.Location = new System.Drawing.Point(10, 388);
            this.lvwWarehouse.Name = "lvwWarehouse";
            this.lvwWarehouse.Size = new System.Drawing.Size(958, 298);
            this.lvwWarehouse.TabIndex = 13;
            this.lvwWarehouse.UseCompatibleStateImageBehavior = false;
            this.lvwWarehouse.View = System.Windows.Forms.View.Details;
            this.lvwWarehouse.SelectedIndexChanged += new System.EventHandler(this.lvwWarehouse_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(91, 338);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(54, 14);
            this.smartLabel4.TabIndex = 16;
            this.smartLabel4.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.Blue;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.ItemHeight = 18;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatus.Location = new System.Drawing.Point(155, 338);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(302, 26);
            this.cboStatus.TabIndex = 6;
            this.cboStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboStatus_KeyPress);
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarehouseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseID.Location = new System.Drawing.Point(156, 146);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(302, 24);
            this.txtWarehouseID.TabIndex = 4;
            this.txtWarehouseID.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(641, 338);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(323, 24);
            this.txtRemarks.TabIndex = 12;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseName.Location = new System.Drawing.Point(155, 238);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(302, 24);
            this.txtWarehouseName.TabIndex = 5;
            this.txtWarehouseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWarehouseName_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(561, 338);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(70, 14);
            this.smartLabel3.TabIndex = 14;
            this.smartLabel3.Text = "Remarks:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(16, 241);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(129, 14);
            this.smartLabel2.TabIndex = 12;
            this.smartLabel2.Text = "Warehouse Name:";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(39, 146);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(107, 14);
            this.smartLabel1.TabIndex = 10;
            this.smartLabel1.Text = "Warehouse ID:";
            this.smartLabel1.Visible = false;
            // 
            // cboTypeName
            // 
            this.cboTypeName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeName.FormattingEnabled = true;
            this.cboTypeName.ItemHeight = 16;
            this.cboTypeName.Location = new System.Drawing.Point(641, 206);
            this.cboTypeName.Name = "cboTypeName";
            this.cboTypeName.Size = new System.Drawing.Size(323, 24);
            this.cboTypeName.TabIndex = 3;
            this.cboTypeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTypeName_KeyPress);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(545, 208);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(86, 14);
            this.smartLabel5.TabIndex = 19;
            this.smartLabel5.Text = "Type Name:";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(60, 179);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(85, 14);
            this.smartLabel6.TabIndex = 21;
            this.smartLabel6.Text = "Building ID:";
            // 
            // cboBuildID
            // 
            this.cboBuildID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuildID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuildID.ForeColor = System.Drawing.Color.Blue;
            this.cboBuildID.FormattingEnabled = true;
            this.cboBuildID.Location = new System.Drawing.Point(155, 175);
            this.cboBuildID.Name = "cboBuildID";
            this.cboBuildID.Size = new System.Drawing.Size(302, 26);
            this.cboBuildID.TabIndex = 0;
            this.cboBuildID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBuildID_KeyPress);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(563, 175);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(68, 14);
            this.smartLabel7.TabIndex = 23;
            this.smartLabel7.Text = "Floor No:";
            // 
            // cboFloorNo
            // 
            this.cboFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorNo.ForeColor = System.Drawing.Color.Blue;
            this.cboFloorNo.FormattingEnabled = true;
            this.cboFloorNo.Location = new System.Drawing.Point(641, 175);
            this.cboFloorNo.Name = "cboFloorNo";
            this.cboFloorNo.Size = new System.Drawing.Size(323, 26);
            this.cboFloorNo.TabIndex = 1;
            this.cboFloorNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboFloorNo_KeyPress);
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(83, 209);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(62, 14);
            this.smartLabel9.TabIndex = 27;
            this.smartLabel9.Text = "Dep. ID:";
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(155, 206);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(302, 26);
            this.cboDeptID.TabIndex = 2;
            this.cboDeptID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDeptID_KeyPress);
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(497, 241);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(134, 14);
            this.smartLabel11.TabIndex = 31;
            this.smartLabel11.Text = "Nursing Station ID:";
            // 
            // cboNsStnId
            // 
            this.cboNsStnId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNsStnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNsStnId.ForeColor = System.Drawing.Color.Blue;
            this.cboNsStnId.FormattingEnabled = true;
            this.cboNsStnId.ItemHeight = 18;
            this.cboNsStnId.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboNsStnId.Location = new System.Drawing.Point(641, 238);
            this.cboNsStnId.Name = "cboNsStnId";
            this.cboNsStnId.Size = new System.Drawing.Size(323, 26);
            this.cboNsStnId.TabIndex = 7;
            this.cboNsStnId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNsStnId_KeyPress);
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(20, 272);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(125, 14);
            this.smartLabel12.TabIndex = 33;
            this.smartLabel12.Text = "Cost Category ID:";
            // 
            // cbocostcategoryName
            // 
            this.cbocostcategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocostcategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocostcategoryName.ForeColor = System.Drawing.Color.Blue;
            this.cbocostcategoryName.FormattingEnabled = true;
            this.cbocostcategoryName.ItemHeight = 18;
            this.cbocostcategoryName.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbocostcategoryName.Location = new System.Drawing.Point(155, 267);
            this.cbocostcategoryName.Name = "cbocostcategoryName";
            this.cbocostcategoryName.Size = new System.Drawing.Size(302, 26);
            this.cbocostcategoryName.TabIndex = 8;
            this.cbocostcategoryName.SelectedIndexChanged += new System.EventHandler(this.cbocostcategoryName_SelectedIndexChanged);
            this.cbocostcategoryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbocostcategoryName_KeyPress);
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(522, 271);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(109, 14);
            this.smartLabel13.TabIndex = 35;
            this.smartLabel13.Text = "Cost Center ID:";
            // 
            // cbocostCenterID
            // 
            this.cbocostCenterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocostCenterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocostCenterID.ForeColor = System.Drawing.Color.Blue;
            this.cbocostCenterID.FormattingEnabled = true;
            this.cbocostCenterID.ItemHeight = 18;
            this.cbocostCenterID.Location = new System.Drawing.Point(641, 267);
            this.cbocostCenterID.Name = "cbocostCenterID";
            this.cbocostCenterID.Size = new System.Drawing.Size(323, 26);
            this.cbocostCenterID.TabIndex = 9;
            this.cbocostCenterID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbocostCenterID_KeyPress);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(155, 304);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(302, 24);
            this.txtPhoneNo.TabIndex = 36;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(70, 307);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(75, 14);
            this.smartLabel8.TabIndex = 37;
            this.smartLabel8.Text = "Phone No:";
            // 
            // txtCantactPerson
            // 
            this.txtCantactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantactPerson.Location = new System.Drawing.Point(641, 300);
            this.txtCantactPerson.Name = "txtCantactPerson";
            this.txtCantactPerson.Size = new System.Drawing.Size(323, 24);
            this.txtCantactPerson.TabIndex = 38;
            this.txtCantactPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantactPerson_KeyPress);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(519, 303);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(112, 14);
            this.smartLabel10.TabIndex = 39;
            this.smartLabel10.Text = "Contact Person:";
            // 
            // frmWarehouseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(976, 678);
            this.KeyPreview = false;
            this.Name = "frmWarehouseConfig";
            this.Load += new System.EventHandler(this.frmWarehouseConfig_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwWarehouse;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboStatus;
        private AtiqsControlLibrary.SmartTextBox txtWarehouseID;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtWarehouseName;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.ComboBox cboTypeName;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboBuildID;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartComboBox cboNsStnId;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboFloorNo;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartComboBox cbocostCenterID;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartComboBox cbocostcategoryName;
        private AtiqsControlLibrary.SmartTextBox txtCantactPerson;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartTextBox txtPhoneNo;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
    }
}
