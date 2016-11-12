namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmPurchaseRequisitionList
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
            this.dgvRequisitionList = new System.Windows.Forms.DataGridView();
            this.txtRequisitionBy = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.txtStoreLocationID = new AtiqsControlLibrary.SmartTextBox();
            this.txtStoreTypeID = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitionList)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(163, 9);
            this.frmLabel.Size = new System.Drawing.Size(308, 33);
            this.frmLabel.Text = "Purchase Requisition List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvRequisitionList);
            this.pnlMain.Size = new System.Drawing.Size(639, 636);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtStoreTypeID);
            this.pnlTop.Controls.Add(this.txtStoreLocationID);
            this.pnlTop.Size = new System.Drawing.Size(640, 58);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtStoreLocationID, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtStoreTypeID, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(256, 555);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(386, 555);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(301, 557);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(187, 555);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(530, 557);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(323, 555);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 599);
            this.groupBox1.Size = new System.Drawing.Size(640, 25);
            // 
            // dgvRequisitionList
            // 
            this.dgvRequisitionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitionList.Location = new System.Drawing.Point(2, 144);
            this.dgvRequisitionList.Name = "dgvRequisitionList";
            this.dgvRequisitionList.Size = new System.Drawing.Size(635, 491);
            this.dgvRequisitionList.TabIndex = 1;
            this.dgvRequisitionList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisitionList_CellContentDoubleClick);
            // 
            // txtRequisitionBy
            // 
            this.txtRequisitionBy.BackColor = System.Drawing.Color.Linen;
            this.txtRequisitionBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequisitionBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequisitionBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRequisitionBy.Location = new System.Drawing.Point(139, 562);
            this.txtRequisitionBy.Name = "txtRequisitionBy";
            this.txtRequisitionBy.ReadOnly = true;
            this.txtRequisitionBy.Size = new System.Drawing.Size(42, 24);
            this.txtRequisitionBy.TabIndex = 6;
            this.txtRequisitionBy.TabStop = false;
            this.txtRequisitionBy.Visible = false;
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(66, 563);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(47, 26);
            this.cboUnit.TabIndex = 5;
            this.cboUnit.Visible = false;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(12, 563);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(48, 26);
            this.cboDepartment.TabIndex = 4;
            this.cboDepartment.Visible = false;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // txtStoreLocationID
            // 
            this.txtStoreLocationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreLocationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreLocationID.Location = new System.Drawing.Point(24, 12);
            this.txtStoreLocationID.Name = "txtStoreLocationID";
            this.txtStoreLocationID.Size = new System.Drawing.Size(36, 24);
            this.txtStoreLocationID.TabIndex = 15;
            this.txtStoreLocationID.Visible = false;
            // 
            // txtStoreTypeID
            // 
            this.txtStoreTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreTypeID.Location = new System.Drawing.Point(66, 18);
            this.txtStoreTypeID.Name = "txtStoreTypeID";
            this.txtStoreTypeID.Size = new System.Drawing.Size(39, 24);
            this.txtStoreTypeID.TabIndex = 16;
            this.txtStoreTypeID.Visible = false;
            // 
            // frmPurchaseRequisitionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 624);
            this.Controls.Add(this.txtRequisitionBy);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.cboDepartment);
            this.isEnterTabAllow = true;
            this.Name = "frmPurchaseRequisitionList";
            this.Load += new System.EventHandler(this.frmPurchaseRequisitionList_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.cboDepartment, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.cboUnit, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtRequisitionBy, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequisitionList;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRequisitionBy;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartTextBox txtStoreTypeID;
        private AtiqsControlLibrary.SmartTextBox txtStoreLocationID;
    }
}
