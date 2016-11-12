namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmLedgerList
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
            this.lvwLedgerList = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtEdit = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(974, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(439, 6);
            this.frmLabel.Size = new System.Drawing.Size(144, 33);
            this.frmLabel.Text = "Ledger List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwLedgerList);
            this.pnlMain.Location = new System.Drawing.Point(0, 52);
            this.pnlMain.Size = new System.Drawing.Size(1051, 499);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1052, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(567, 552);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 553);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(681, 552);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(186, 553);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(909, 552);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(795, 552);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 592);
            this.groupBox1.Size = new System.Drawing.Size(1052, 25);
            // 
            // lvwLedgerList
            // 
            this.lvwLedgerList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwLedgerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwLedgerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwLedgerList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLedgerList.FullRowSelect = true;
            this.lvwLedgerList.GridLines = true;
            this.lvwLedgerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwLedgerList.Location = new System.Drawing.Point(4, 11);
            this.lvwLedgerList.Name = "lvwLedgerList";
            this.lvwLedgerList.Size = new System.Drawing.Size(1040, 471);
            this.lvwLedgerList.TabIndex = 15;
            this.lvwLedgerList.UseCompatibleStateImageBehavior = false;
            this.lvwLedgerList.View = System.Windows.Forms.View.Details;
            this.lvwLedgerList.SelectedIndexChanged += new System.EventHandler(this.lvwLedgerList_SelectedIndexChanged);
            // 
            // txtEdit
            // 
            this.txtEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdit.Location = new System.Drawing.Point(12, 562);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(100, 24);
            this.txtEdit.TabIndex = 15;
            this.txtEdit.Visible = false;
            // 
            // frmLedgerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1052, 617);
            this.Controls.Add(this.txtEdit);
            this.Name = "frmLedgerList";
            this.Load += new System.EventHandler(this.frmLedgerList_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtEdit, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwLedgerList;
        private AtiqsControlLibrary.SmartTextBox txtEdit;
    }
}
