namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmTreeView
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
            this.trList = new AtiqsControlLibrary.SmartTreeView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.trList);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 609);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // trList
            // 
            this.trList.BackColor = System.Drawing.Color.LightYellow;
            this.trList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trList.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.trList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trList.ForeColor = System.Drawing.Color.RoyalBlue;
            this.trList.LineColor = System.Drawing.Color.Crimson;
            this.trList.Location = new System.Drawing.Point(129, 166);
            this.trList.Name = "trList";
            this.trList.Size = new System.Drawing.Size(164, 317);
            this.trList.TabIndex = 0;
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmTreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTreeView trList;
    }
}
