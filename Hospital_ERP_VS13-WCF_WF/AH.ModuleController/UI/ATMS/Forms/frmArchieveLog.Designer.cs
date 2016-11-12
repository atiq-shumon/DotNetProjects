namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmArchieveLog
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
            this.radHousekeeping = new AtiqsControlLibrary.SmartRadioButton();
            this.radCSSD = new AtiqsControlLibrary.SmartRadioButton();
            this.cboWarehouseType = new System.Windows.Forms.ComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.btnDown = new System.Windows.Forms.Button();
            this.txtModuleID = new AtiqsControlLibrary.SmartTextBox();
            this.txtStoreid = new AtiqsControlLibrary.SmartTextBox();
            this.txtgrpID = new AtiqsControlLibrary.SmartTextBox();
            this.dtevDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(391, 9);
            this.frmLabel.Size = new System.Drawing.Size(329, 33);
            this.frmLabel.Text = "Receipt From Maintenance";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.dtevDate);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtModuleID);
            this.pnlMain.Controls.Add(this.txtStoreid);
            this.pnlMain.Controls.Add(this.txtgrpID);
            this.pnlMain.Controls.Add(this.btnDown);
            this.pnlMain.Controls.Add(this.cboWarehouse);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboWarehouseType);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.radCSSD);
            this.pnlMain.Controls.Add(this.radHousekeeping);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Size = new System.Drawing.Size(1024, 723);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1025, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(412, 644);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 644);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(525, 644);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(186, 644);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(747, 644);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(636, 644);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 685);
            this.groupBox1.Size = new System.Drawing.Size(1025, 25);
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(7, 273);
            this.DG.Name = "DG";
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(1011, 389);
            this.DG.TabIndex = 8;
            this.DG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DG_KeyPress);
            // 
            // radHousekeeping
            // 
            this.radHousekeeping.AutoSize = true;
            this.radHousekeeping.Checked = true;
            this.radHousekeeping.Font = new System.Drawing.Font("Georgia", 11F);
            this.radHousekeeping.ForeColor = System.Drawing.Color.Gray;
            this.radHousekeeping.Location = new System.Drawing.Point(26, 167);
            this.radHousekeeping.Name = "radHousekeeping";
            this.radHousekeeping.Size = new System.Drawing.Size(125, 22);
            this.radHousekeeping.TabIndex = 9;
            this.radHousekeeping.TabStop = true;
            this.radHousekeeping.Text = "House Keeping";
            this.radHousekeeping.UseVisualStyleBackColor = true;
            this.radHousekeeping.Visible = false;
            this.radHousekeeping.CheckedChanged += new System.EventHandler(this.radHousekeeping_CheckedChanged);
            // 
            // radCSSD
            // 
            this.radCSSD.AutoSize = true;
            this.radCSSD.Font = new System.Drawing.Font("Georgia", 11F);
            this.radCSSD.ForeColor = System.Drawing.Color.Gray;
            this.radCSSD.Location = new System.Drawing.Point(26, 209);
            this.radCSSD.Name = "radCSSD";
            this.radCSSD.Size = new System.Drawing.Size(63, 22);
            this.radCSSD.TabIndex = 10;
            this.radCSSD.Text = "CSSD";
            this.radCSSD.UseVisualStyleBackColor = true;
            this.radCSSD.Visible = false;
            this.radCSSD.CheckedChanged += new System.EventHandler(this.radCSSD_CheckedChanged);
            // 
            // cboWarehouseType
            // 
            this.cboWarehouseType.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarehouseType.FormattingEnabled = true;
            this.cboWarehouseType.Location = new System.Drawing.Point(321, 179);
            this.cboWarehouseType.Name = "cboWarehouseType";
            this.cboWarehouseType.Size = new System.Drawing.Size(232, 26);
            this.cboWarehouseType.TabIndex = 19;
            this.cboWarehouseType.SelectedIndexChanged += new System.EventHandler(this.cboWarehouseType_SelectedIndexChanged);
            this.cboWarehouseType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboWarehouseType_KeyPress);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(190, 184);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(123, 14);
            this.smartLabel2.TabIndex = 18;
            this.smartLabel2.Text = "Warehouse Type:";
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Location = new System.Drawing.Point(706, 178);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(213, 26);
            this.cboWarehouse.TabIndex = 21;
            this.cboWarehouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboWarehouse_KeyPress);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(608, 181);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(87, 14);
            this.smartLabel5.TabIndex = 20;
            this.smartLabel5.Text = "Warehouse:";
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDown.Location = new System.Drawing.Point(925, 178);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(41, 23);
            this.btnDown.TabIndex = 27;
            this.btnDown.Text = ">>";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // txtModuleID
            // 
            this.txtModuleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModuleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleID.Location = new System.Drawing.Point(321, 231);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(50, 24);
            this.txtModuleID.TabIndex = 30;
            this.txtModuleID.Visible = false;
            // 
            // txtStoreid
            // 
            this.txtStoreid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreid.Location = new System.Drawing.Point(257, 231);
            this.txtStoreid.Name = "txtStoreid";
            this.txtStoreid.Size = new System.Drawing.Size(58, 24);
            this.txtStoreid.TabIndex = 29;
            this.txtStoreid.Visible = false;
            // 
            // txtgrpID
            // 
            this.txtgrpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgrpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrpID.Location = new System.Drawing.Point(201, 222);
            this.txtgrpID.Name = "txtgrpID";
            this.txtgrpID.Size = new System.Drawing.Size(50, 24);
            this.txtgrpID.TabIndex = 28;
            this.txtgrpID.Visible = false;
            // 
            // dtevDate
            // 
            this.dtevDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtevDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtevDate.Location = new System.Drawing.Point(706, 210);
            this.dtevDate.Name = "dtevDate";
            this.dtevDate.Size = new System.Drawing.Size(213, 26);
            this.dtevDate.TabIndex = 32;
            this.dtevDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtevDate_KeyPress);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(601, 215);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(96, 14);
            this.smartLabel6.TabIndex = 31;
            this.smartLabel6.Text = "Receipt Date:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(273, 681);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(70, 14);
            this.smartLabel3.TabIndex = 34;
            this.smartLabel3.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(352, 678);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(391, 24);
            this.txtRemarks.TabIndex = 33;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // frmArchieveLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1025, 710);
            this.isEnterTabAllow = true;
            this.Name = "frmArchieveLog";
            this.Load += new System.EventHandler(this.frmArchieveLog_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private AtiqsControlLibrary.SmartRadioButton radCSSD;
        private AtiqsControlLibrary.SmartRadioButton radHousekeeping;
        private System.Windows.Forms.ComboBox cboWarehouseType;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.Button btnDown;
        private AtiqsControlLibrary.SmartTextBox txtModuleID;
        private AtiqsControlLibrary.SmartTextBox txtStoreid;
        private AtiqsControlLibrary.SmartTextBox txtgrpID;
        private System.Windows.Forms.DateTimePicker dtevDate;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
    }
}
