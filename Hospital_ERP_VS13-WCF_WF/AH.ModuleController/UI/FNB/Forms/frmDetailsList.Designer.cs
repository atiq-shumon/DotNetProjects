namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmDetailsList
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
            this.lvwMenuItemSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(245, 9);
            this.frmLabel.Size = new System.Drawing.Size(262, 33);
            this.frmLabel.Text = "Meal Register Details";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwMenuItemSetup);
            // 
            // btnEdit
            // 
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lvwMenuItemSetup
            // 
            this.lvwMenuItemSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwMenuItemSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwMenuItemSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwMenuItemSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMenuItemSetup.FullRowSelect = true;
            this.lvwMenuItemSetup.GridLines = true;
            this.lvwMenuItemSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwMenuItemSetup.Location = new System.Drawing.Point(4, 149);
            this.lvwMenuItemSetup.Name = "lvwMenuItemSetup";
            this.lvwMenuItemSetup.Size = new System.Drawing.Size(853, 481);
            this.lvwMenuItemSetup.TabIndex = 15;
            this.lvwMenuItemSetup.UseCompatibleStateImageBehavior = false;
            this.lvwMenuItemSetup.View = System.Windows.Forms.View.Details;
            // 
            // frmDetailsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmDetailsList";
            this.Load += new System.EventHandler(this.frmDetailsList_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwMenuItemSetup;
    }
}
