namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmSearch
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
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(595, 6);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(246, 6);
            this.frmLabel.Size = new System.Drawing.Size(119, 33);
            this.frmLabel.Text = "   Serach";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwVoucherDetails);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(685, 349);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(690, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(236, 355);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 355);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(349, 355);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(10, 355);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(571, 355);
            this.btnClose.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(460, 355);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 403);
            this.groupBox1.Size = new System.Drawing.Size(690, 25);
            // 
            // lvwVoucherDetails
            // 
            this.lvwVoucherDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwVoucherDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwVoucherDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwVoucherDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwVoucherDetails.FullRowSelect = true;
            this.lvwVoucherDetails.GridLines = true;
            this.lvwVoucherDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwVoucherDetails.Location = new System.Drawing.Point(14, 5);
            this.lvwVoucherDetails.Name = "lvwVoucherDetails";
            this.lvwVoucherDetails.Size = new System.Drawing.Size(661, 293);
            this.lvwVoucherDetails.TabIndex = 0;
            this.lvwVoucherDetails.UseCompatibleStateImageBehavior = false;
            this.lvwVoucherDetails.View = System.Windows.Forms.View.Details;
            this.lvwVoucherDetails.DoubleClick += new System.EventHandler(this.lvwVoucherDetails_DoubleClick);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 428);
            this.Name = "frmSearch";
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwVoucherDetails;

    }
}
