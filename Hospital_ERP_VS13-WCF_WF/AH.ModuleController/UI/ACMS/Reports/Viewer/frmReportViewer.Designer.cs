namespace AH.ModuleController.UI.ACMS.Reports.Viewer
{
    partial class frmReportViewer
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
            this.ACMSCRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ACMSCRViewer
            // 
            this.ACMSCRViewer.ActiveViewIndex = -1;
            this.ACMSCRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ACMSCRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ACMSCRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACMSCRViewer.Location = new System.Drawing.Point(0, 0);
            this.ACMSCRViewer.Name = "ACMSCRViewer";
            this.ACMSCRViewer.ShowGroupTreeButton = false;
            this.ACMSCRViewer.Size = new System.Drawing.Size(575, 630);
            this.ACMSCRViewer.TabIndex = 1;
            this.ACMSCRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.ACMSCRViewer.Load += new System.EventHandler(this.ACMSCRViewer_Load);
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 630);
            this.Controls.Add(this.ACMSCRViewer);
            this.Name = "frmReportViewer";
            this.Text = "frmReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ACMSCRViewer;
    }
}