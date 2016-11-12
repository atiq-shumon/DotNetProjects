namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmCategoryTreeview
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
            this.tvwcostcategory = new AtiqsControlLibrary.SmartTreeView();
            this.tvwPrint = new System.Windows.Forms.TreeView();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(201, 7);
            this.frmLabel.Size = new System.Drawing.Size(293, 33);
            this.frmLabel.Text = "Chart of Cost  Category";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tvwPrint);
            this.pnlMain.Controls.Add(this.tvwcostcategory);
            this.pnlMain.Size = new System.Drawing.Size(644, 738);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(645, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(188, 651);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 651);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(301, 651);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(-38, 651);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(526, 653);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(415, 653);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 692);
            this.groupBox1.Size = new System.Drawing.Size(645, 25);
            // 
            // tvwcostcategory
            // 
            this.tvwcostcategory.BackColor = System.Drawing.Color.SteelBlue;
            this.tvwcostcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvwcostcategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvwcostcategory.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwcostcategory.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.tvwcostcategory.LineColor = System.Drawing.Color.BlanchedAlmond;
            this.tvwcostcategory.Location = new System.Drawing.Point(6, 150);
            this.tvwcostcategory.Name = "tvwcostcategory";
            this.tvwcostcategory.Size = new System.Drawing.Size(630, 579);
            this.tvwcostcategory.TabIndex = 0;
            // 
            // tvwPrint
            // 
            this.tvwPrint.Location = new System.Drawing.Point(350, 155);
            this.tvwPrint.Name = "tvwPrint";
            this.tvwPrint.Size = new System.Drawing.Size(274, 569);
            this.tvwPrint.TabIndex = 15;
            this.tvwPrint.Visible = false;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnPreview.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.Navy;
            this.btnPreview.Location = new System.Drawing.Point(304, 653);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(108, 39);
            this.btnPreview.TabIndex = 48;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Visible = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frmCategoryTreeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(645, 717);
            this.Controls.Add(this.btnPreview);
            this.Name = "frmCategoryTreeview";
            this.Load += new System.EventHandler(this.frmCategoryTreeview_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTreeView tvwcostcategory;
        private System.Windows.Forms.TreeView tvwPrint;
        private System.Windows.Forms.Button btnPreview;
    }
}
