namespace frmApmsTest
{
    partial class frmApms
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
            this.dgvPatientAppoint = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientAppoint)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatientAppoint
            // 
            this.dgvPatientAppoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientAppoint.Location = new System.Drawing.Point(165, 180);
            this.dgvPatientAppoint.Name = "dgvPatientAppoint";
            this.dgvPatientAppoint.Size = new System.Drawing.Size(402, 181);
            this.dgvPatientAppoint.TabIndex = 0;
            // 
            // frmApms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 473);
            this.Controls.Add(this.dgvPatientAppoint);
            this.Name = "frmApms";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientAppoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatientAppoint;
    }
}

