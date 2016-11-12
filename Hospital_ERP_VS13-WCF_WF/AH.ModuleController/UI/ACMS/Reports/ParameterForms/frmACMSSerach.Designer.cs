namespace AH.ModuleController.UI.ACMS.Reports.ParameterForms
{
    partial class frmACMSSerach
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
            this.txtSearch = new AtiqsControlLibrary.SmartTextBox();
            this.dgvACMS = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvACMS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(616, 472);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(502, 472);
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(275, 32);
            this.frmLabel.Text = "ACMS Employee List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.dgvACMS);
            this.pnlMain.Controls.Add(this.lblSearch);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(727, 414);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(727, 51);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(76, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(312, 24);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvACMS
            // 
            this.dgvACMS.AllowUserToAddRows = false;
            this.dgvACMS.AllowUserToDeleteRows = false;
            this.dgvACMS.AllowUserToOrderColumns = true;
            this.dgvACMS.AllowUserToResizeColumns = false;
            this.dgvACMS.AllowUserToResizeRows = false;
            this.dgvACMS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvACMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvACMS.Location = new System.Drawing.Point(2, 78);
            this.dgvACMS.MultiSelect = false;
            this.dgvACMS.Name = "dgvACMS";
            this.dgvACMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvACMS.Size = new System.Drawing.Size(723, 332);
            this.dgvACMS.TabIndex = 9;
            this.dgvACMS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvACMS_MouseDoubleClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search";
            // 
            // frmACMSSerach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(727, 538);
            this.Name = "frmACMSSerach";
            this.Text = "Emplyee List";
            this.Load += new System.EventHandler(this.frmACMSSerach_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvACMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvACMS;
        private System.Windows.Forms.Label lblSearch;
    }
}
