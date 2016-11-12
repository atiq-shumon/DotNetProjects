namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmTransferReqNumList
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
            this.dgvRequisitionList = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitionList)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(173, 9);
            this.frmLabel.Size = new System.Drawing.Size(194, 33);
            this.frmLabel.Text = " Requisition No";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvRequisitionList);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(519, 491);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(519, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(138, 555);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(47, 553);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 555);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 553);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(406, 555);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(252, 555);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(519, 25);
            // 
            // dgvRequisitionList
            // 
            this.dgvRequisitionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitionList.Location = new System.Drawing.Point(0, -1);
            this.dgvRequisitionList.Name = "dgvRequisitionList";
            this.dgvRequisitionList.Size = new System.Drawing.Size(516, 491);
            this.dgvRequisitionList.TabIndex = 1;
            this.dgvRequisitionList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisitionList_CellContentDoubleClick);
            // 
            // frmTransferReqNumList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(519, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmTransferReqNumList";
            this.Load += new System.EventHandler(this.frmPurchaseRequisitionList_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequisitionList;
    }
}
