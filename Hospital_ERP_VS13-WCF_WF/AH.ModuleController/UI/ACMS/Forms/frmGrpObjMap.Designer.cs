namespace AH.ModuleController.UI.ACMS.Forms
{
    partial class frmGrpObjMap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboObjectType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboUserGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboModule = new AtiqsControlLibrary.SmartComboBox();
            this.txtMID = new System.Windows.Forms.TextBox();
            this.txtObjID = new System.Windows.Forms.TextBox();
            this.txtGrpID = new System.Windows.Forms.TextBox();
            this.textAuthLevID = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grdAssignObjectName = new AtiqsControlLibrary.SmartDataGridView();
            this.grdAllObjectName = new AtiqsControlLibrary.SmartDataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkListboxAuthenticationLevel = new AtiqsControlLibrary.SmartCheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSelectAllObject = new AtiqsControlLibrary.SmartCheckBox();
            this.chkSelectAll = new AtiqsControlLibrary.SmartCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssignObjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllObjectName)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(917, 12);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(334, 5);
            this.frmLabel.Size = new System.Drawing.Size(370, 33);
            this.frmLabel.Text = "Group and Object Assignment";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.chkSelectAll);
            this.pnlMain.Controls.Add(this.btnRemove);
            this.pnlMain.Controls.Add(this.grdAssignObjectName);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboObjectType);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboUserGroup);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboModule);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(1029, 542);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1029, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(192, 595);
            this.btnEdit.Size = new System.Drawing.Size(10, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(800, 599);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 595);
            this.btnDelete.Size = new System.Drawing.Size(10, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(686, 599);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(914, 599);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(212, 599);
            this.btnPrint.Size = new System.Drawing.Size(34, 34);
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 639);
            this.groupBox1.Size = new System.Drawing.Size(1029, 23);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(124, 101);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(0, 16);
            this.smartLabel5.TabIndex = 46;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(342, 3);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(76, 13);
            this.smartLabel3.TabIndex = 59;
            this.smartLabel3.Text = "Object Type";
            // 
            // cboObjectType
            // 
            this.cboObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboObjectType.ForeColor = System.Drawing.Color.Blue;
            this.cboObjectType.FormattingEnabled = true;
            this.cboObjectType.Location = new System.Drawing.Point(334, 18);
            this.cboObjectType.Name = "cboObjectType";
            this.cboObjectType.Size = new System.Drawing.Size(185, 26);
            this.cboObjectType.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(547, 3);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(63, 13);
            this.smartLabel2.TabIndex = 53;
            this.smartLabel2.Text = "User Role";
            // 
            // cboUserGroup
            // 
            this.cboUserGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboUserGroup.FormattingEnabled = true;
            this.cboUserGroup.Location = new System.Drawing.Point(538, 18);
            this.cboUserGroup.Name = "cboUserGroup";
            this.cboUserGroup.Size = new System.Drawing.Size(214, 26);
            this.cboUserGroup.TabIndex = 4;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(27, 2);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(48, 13);
            this.smartLabel1.TabIndex = 51;
            this.smartLabel1.Text = "Module";
            // 
            // cboModule
            // 
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModule.ForeColor = System.Drawing.Color.Blue;
            this.cboModule.Location = new System.Drawing.Point(3, 18);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(329, 26);
            this.cboModule.TabIndex = 1;
            // 
            // txtMID
            // 
            this.txtMID.Location = new System.Drawing.Point(101, 614);
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(19, 20);
            this.txtMID.TabIndex = 15;
            this.txtMID.Visible = false;
            // 
            // txtObjID
            // 
            this.txtObjID.Location = new System.Drawing.Point(29, 614);
            this.txtObjID.Name = "txtObjID";
            this.txtObjID.Size = new System.Drawing.Size(19, 20);
            this.txtObjID.TabIndex = 16;
            this.txtObjID.Visible = false;
            // 
            // txtGrpID
            // 
            this.txtGrpID.Location = new System.Drawing.Point(70, 614);
            this.txtGrpID.Name = "txtGrpID";
            this.txtGrpID.Size = new System.Drawing.Size(18, 20);
            this.txtGrpID.TabIndex = 17;
            this.txtGrpID.Visible = false;
            // 
            // textAuthLevID
            // 
            this.textAuthLevID.Location = new System.Drawing.Point(141, 614);
            this.textAuthLevID.Name = "textAuthLevID";
            this.textAuthLevID.Size = new System.Drawing.Size(20, 20);
            this.textAuthLevID.TabIndex = 18;
            this.textAuthLevID.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(780, 18);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(101, 31);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(467, 264);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 43);
            this.btnRemove.TabIndex = 63;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grdAssignObjectName
            // 
            this.grdAssignObjectName.AllowUserToAddRows = false;
            this.grdAssignObjectName.AllowUserToDeleteRows = false;
            this.grdAssignObjectName.AllowUserToOrderColumns = true;
            this.grdAssignObjectName.AllowUserToResizeColumns = false;
            this.grdAssignObjectName.AllowUserToResizeRows = false;
            this.grdAssignObjectName.BackgroundColor = System.Drawing.Color.White;
            this.grdAssignObjectName.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdAssignObjectName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAssignObjectName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAssignObjectName.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAssignObjectName.Location = new System.Drawing.Point(540, 53);
            this.grdAssignObjectName.MultiSelect = false;
            this.grdAssignObjectName.Name = "grdAssignObjectName";
            this.grdAssignObjectName.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.grdAssignObjectName.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdAssignObjectName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAssignObjectName.Size = new System.Drawing.Size(466, 460);
            this.grdAssignObjectName.TabIndex = 62;
            // 
            // grdAllObjectName
            // 
            this.grdAllObjectName.AllowUserToAddRows = false;
            this.grdAllObjectName.AllowUserToDeleteRows = false;
            this.grdAllObjectName.AllowUserToOrderColumns = true;
            this.grdAllObjectName.AllowUserToResizeColumns = false;
            this.grdAllObjectName.AllowUserToResizeRows = false;
            this.grdAllObjectName.BackgroundColor = System.Drawing.Color.White;
            this.grdAllObjectName.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdAllObjectName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAllObjectName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAllObjectName.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdAllObjectName.Location = new System.Drawing.Point(3, 9);
            this.grdAllObjectName.MultiSelect = false;
            this.grdAllObjectName.Name = "grdAllObjectName";
            this.grdAllObjectName.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.grdAllObjectName.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdAllObjectName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAllObjectName.Size = new System.Drawing.Size(269, 448);
            this.grdAllObjectName.TabIndex = 61;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(467, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 43);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkListboxAuthenticationLevel
            // 
            this.chkListboxAuthenticationLevel.BackColor = System.Drawing.Color.SteelBlue;
            this.chkListboxAuthenticationLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkListboxAuthenticationLevel.CheckOnClick = true;
            this.chkListboxAuthenticationLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkListboxAuthenticationLevel.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListboxAuthenticationLevel.ForeColor = System.Drawing.Color.White;
            this.chkListboxAuthenticationLevel.FormattingEnabled = true;
            this.chkListboxAuthenticationLevel.Location = new System.Drawing.Point(274, 9);
            this.chkListboxAuthenticationLevel.Name = "chkListboxAuthenticationLevel";
            this.chkListboxAuthenticationLevel.Size = new System.Drawing.Size(189, 102);
            this.chkListboxAuthenticationLevel.TabIndex = 64;
            this.chkListboxAuthenticationLevel.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListboxAuthenticationLevel_ItemCheck);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chkSelectAllObject);
            this.panel2.Controls.Add(this.grdAllObjectName);
            this.panel2.Controls.Add(this.chkListboxAuthenticationLevel);
            this.panel2.Location = new System.Drawing.Point(-1, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 462);
            this.panel2.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(471, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 197;
            this.label4.Text = "*";
            // 
            // chkSelectAllObject
            // 
            this.chkSelectAllObject.AutoSize = true;
            this.chkSelectAllObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSelectAllObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSelectAllObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAllObject.ForeColor = System.Drawing.Color.Black;
            this.chkSelectAllObject.Location = new System.Drawing.Point(8, 12);
            this.chkSelectAllObject.Name = "chkSelectAllObject";
            this.chkSelectAllObject.Size = new System.Drawing.Size(12, 11);
            this.chkSelectAllObject.TabIndex = 67;
            this.chkSelectAllObject.UseVisualStyleBackColor = true;
            this.chkSelectAllObject.CheckedChanged += new System.EventHandler(this.chkSelectAllObject_CheckedChanged);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAll.ForeColor = System.Drawing.Color.Black;
            this.chkSelectAll.Location = new System.Drawing.Point(545, 56);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(12, 11);
            this.chkSelectAll.TabIndex = 66;
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(311, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 194;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(503, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 195;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(758, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 196;
            this.label3.Text = "*";
            // 
            // frmGrpObjMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1029, 662);
            this.Controls.Add(this.textAuthLevID);
            this.Controls.Add(this.txtGrpID);
            this.Controls.Add(this.txtObjID);
            this.Controls.Add(this.txtMID);
            this.isEnterTabAllow = true;
            this.Name = "frmGrpObjMap";
            this.Load += new System.EventHandler(this.frmGrpObjMap_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtMID, 0);
            this.Controls.SetChildIndex(this.txtObjID, 0);
            this.Controls.SetChildIndex(this.txtGrpID, 0);
            this.Controls.SetChildIndex(this.textAuthLevID, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssignObjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllObjectName)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboObjectType;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboUserGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboModule;
        private System.Windows.Forms.TextBox txtMID;
        private System.Windows.Forms.TextBox txtObjID;
        private System.Windows.Forms.TextBox txtGrpID;
        private System.Windows.Forms.TextBox textAuthLevID;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRemove;
        private AtiqsControlLibrary.SmartDataGridView grdAssignObjectName;
        private AtiqsControlLibrary.SmartDataGridView grdAllObjectName;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartCheckedListBox chkListboxAuthenticationLevel;
        private System.Windows.Forms.Panel panel2;
        private AtiqsControlLibrary.SmartCheckBox chkSelectAll;
        private AtiqsControlLibrary.SmartCheckBox chkSelectAllObject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
