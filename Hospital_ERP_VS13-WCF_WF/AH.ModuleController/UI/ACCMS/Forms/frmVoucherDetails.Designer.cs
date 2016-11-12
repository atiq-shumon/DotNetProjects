namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmVoucherDetails
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
            this.lvwVoucherDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwVoucherDetails);
            this.pnlMain.Location = new System.Drawing.Point(-2, 56);
            this.pnlMain.Size = new System.Drawing.Size(873, 488);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(871, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(243, 548);
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 548);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(514, 550);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(-4, 548);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(742, 550);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(628, 550);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 589);
            this.groupBox1.Size = new System.Drawing.Size(871, 25);
            // 
            // lvwVoucherDetails
            // 
            this.lvwVoucherDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwVoucherDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwVoucherDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwVoucherDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwVoucherDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwVoucherDetails.FullRowSelect = true;
            this.lvwVoucherDetails.GridLines = true;
            this.lvwVoucherDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwVoucherDetails.Location = new System.Drawing.Point(13, 8);
            this.lvwVoucherDetails.Name = "lvwVoucherDetails";
            this.lvwVoucherDetails.Size = new System.Drawing.Size(839, 467);
            this.lvwVoucherDetails.TabIndex = 15;
            this.lvwVoucherDetails.UseCompatibleStateImageBehavior = false;
            this.lvwVoucherDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Voucher No";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Voucher Date";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ledger Name";
            this.columnHeader3.Width = 330;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Net Amount";
            this.columnHeader4.Width = 200;
            // 
            // frmVoucherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(871, 614);
            this.Name = "frmVoucherDetails";
            this.Load += new System.EventHandler(this.frmVoucherDetails_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwVoucherDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
