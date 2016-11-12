namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmAssetTracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMrrDetails = new AtiqsControlLibrary.SmartDataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrrDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(187, 33);
            this.frmLabel.Text = "Asset Tracking";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvMrrDetails);
            // 
            // dgvMrrDetails
            // 
            this.dgvMrrDetails.AllowUserToAddRows = false;
            this.dgvMrrDetails.AllowUserToDeleteRows = false;
            this.dgvMrrDetails.AllowUserToOrderColumns = true;
            this.dgvMrrDetails.AllowUserToResizeColumns = false;
            this.dgvMrrDetails.AllowUserToResizeRows = false;
            this.dgvMrrDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvMrrDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMrrDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMrrDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMrrDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMrrDetails.Location = new System.Drawing.Point(-1, 180);
            this.dgvMrrDetails.MultiSelect = false;
            this.dgvMrrDetails.Name = "dgvMrrDetails";
            this.dgvMrrDetails.RowHeadersVisible = false;
            this.dgvMrrDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMrrDetails.Size = new System.Drawing.Size(863, 455);
            this.dgvMrrDetails.TabIndex = 167;
            // 
            // frmAssetTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.Name = "frmAssetTracker";
            this.Load += new System.EventHandler(this.frmAssetTracker_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrrDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartDataGridView dgvMrrDetails;
    }
}
