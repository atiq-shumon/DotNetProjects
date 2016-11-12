namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmWarehouseIssue
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.cboWarehouseType = new System.Windows.Forms.ComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtgrpID = new AtiqsControlLibrary.SmartTextBox();
            this.txtStoreid = new AtiqsControlLibrary.SmartTextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.dtevDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtModuleID = new AtiqsControlLibrary.SmartTextBox();
            this.lvwIssue = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRefNo = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(342, 8);
            this.frmLabel.Size = new System.Drawing.Size(277, 33);
            this.frmLabel.Text = "Issue for Maintenance";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtRefNo);
            this.pnlMain.Controls.Add(this.lvwIssue);
            this.pnlMain.Controls.Add(this.txtModuleID);
            this.pnlMain.Controls.Add(this.dtevDate);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.btnGen);
            this.pnlMain.Controls.Add(this.txtStoreid);
            this.pnlMain.Controls.Add(this.txtgrpID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.cboWarehouse);
            this.pnlMain.Controls.Add(this.cboWarehouseType);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Size = new System.Drawing.Size(1193, 728);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1193, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(742, 647);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(629, 647);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(855, 647);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(516, 647);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1077, 647);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(966, 647);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 691);
            this.groupBox1.Size = new System.Drawing.Size(1193, 25);
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(6, 249);
            this.DG.Name = "DG";
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(847, 406);
            this.DG.TabIndex = 7;
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            this.DG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DG_KeyPress);
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(562, 180);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(213, 26);
            this.cboWarehouse.TabIndex = 18;
            this.cboWarehouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboWarehouse_KeyPress);
            // 
            // cboWarehouseType
            // 
            this.cboWarehouseType.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarehouseType.FormattingEnabled = true;
            this.cboWarehouseType.Location = new System.Drawing.Point(154, 191);
            this.cboWarehouseType.Name = "cboWarehouseType";
            this.cboWarehouseType.Size = new System.Drawing.Size(232, 26);
            this.cboWarehouseType.TabIndex = 17;
            this.cboWarehouseType.SelectedIndexChanged += new System.EventHandler(this.cboWarehouseType_SelectedIndexChanged);
            this.cboWarehouseType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboWarehouseType_KeyPress);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(464, 183);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(87, 14);
            this.smartLabel5.TabIndex = 16;
            this.smartLabel5.Text = "Warehouse:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(23, 196);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(123, 14);
            this.smartLabel2.TabIndex = 15;
            this.smartLabel2.Text = "Warehouse Type:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(285, 672);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(391, 24);
            this.txtRemarks.TabIndex = 19;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(206, 675);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(70, 14);
            this.smartLabel3.TabIndex = 20;
            this.smartLabel3.Text = "Remarks:";
            // 
            // txtgrpID
            // 
            this.txtgrpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgrpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrpID.Location = new System.Drawing.Point(13, 148);
            this.txtgrpID.Name = "txtgrpID";
            this.txtgrpID.Size = new System.Drawing.Size(50, 24);
            this.txtgrpID.TabIndex = 21;
            this.txtgrpID.Visible = false;
            // 
            // txtStoreid
            // 
            this.txtStoreid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreid.Location = new System.Drawing.Point(69, 157);
            this.txtStoreid.Name = "txtStoreid";
            this.txtStoreid.Size = new System.Drawing.Size(58, 24);
            this.txtStoreid.TabIndex = 22;
            this.txtStoreid.Visible = false;
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGen.Location = new System.Drawing.Point(782, 180);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(55, 25);
            this.btnGen.TabIndex = 23;
            this.btnGen.Text = ">>";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // dtevDate
            // 
            this.dtevDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtevDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtevDate.Location = new System.Drawing.Point(562, 213);
            this.dtevDate.Name = "dtevDate";
            this.dtevDate.Size = new System.Drawing.Size(213, 26);
            this.dtevDate.TabIndex = 25;
            this.dtevDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtevDate_KeyPress);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(468, 218);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(83, 14);
            this.smartLabel6.TabIndex = 24;
            this.smartLabel6.Text = "Issue Date:";
            // 
            // txtModuleID
            // 
            this.txtModuleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModuleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleID.Location = new System.Drawing.Point(133, 157);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(50, 24);
            this.txtModuleID.TabIndex = 26;
            this.txtModuleID.Visible = false;
            // 
            // lvwIssue
            // 
            this.lvwIssue.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwIssue.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwIssue.FullRowSelect = true;
            this.lvwIssue.GridLines = true;
            this.lvwIssue.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwIssue.Location = new System.Drawing.Point(859, 166);
            this.lvwIssue.Name = "lvwIssue";
            this.lvwIssue.Size = new System.Drawing.Size(327, 557);
            this.lvwIssue.TabIndex = 28;
            this.lvwIssue.UseCompatibleStateImageBehavior = false;
            this.lvwIssue.View = System.Windows.Forms.View.Details;
            this.lvwIssue.SelectedIndexChanged += new System.EventHandler(this.lvwIssue_SelectedIndexChanged);
            // 
            // txtRefNo
            // 
            this.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.Location = new System.Drawing.Point(248, 150);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(110, 24);
            this.txtRefNo.TabIndex = 29;
            this.txtRefNo.Visible = false;
            // 
            // frmWarehouseIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1193, 716);
            this.KeyPreview = false;
            this.Name = "frmWarehouseIssue";
            this.Load += new System.EventHandler(this.frmWarehouseIssue_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.ComboBox cboWarehouseType;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtStoreid;
        private AtiqsControlLibrary.SmartTextBox txtgrpID;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.DateTimePicker dtevDate;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtModuleID;
        private AtiqsControlLibrary.SmartListViewDetails lvwIssue;
        private AtiqsControlLibrary.SmartTextBox txtRefNo;
    }
}
