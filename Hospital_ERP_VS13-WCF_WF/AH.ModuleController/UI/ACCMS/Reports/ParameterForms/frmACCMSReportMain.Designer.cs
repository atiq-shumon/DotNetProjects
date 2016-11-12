namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    partial class frmACCMSReportMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ledger Wise");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Group Wise");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Voucher Wise");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Final Accounts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cost  Category");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Cash Flow");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Reports", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Revenue");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Hospital Revenue", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeview = new AtiqsControlLibrary.SmartTreeView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(652, 491);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(461, 491);
            this.btnPrint.Visible = false;
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(311, 8);
            this.frmLabel.Size = new System.Drawing.Size(108, 32);
            this.frmLabel.Text = "Reports";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.treeview);
            this.pnlMain.Size = new System.Drawing.Size(839, 436);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(801, 57);
            // 
            // treeview
            // 
            this.treeview.BackColor = System.Drawing.Color.LightYellow;
            this.treeview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeview.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeview.ForeColor = System.Drawing.Color.RoyalBlue;
            this.treeview.LineColor = System.Drawing.Color.Crimson;
            this.treeview.Location = new System.Drawing.Point(38, 20);
            this.treeview.Name = "treeview";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Ledger Wise";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Group Wise";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Voucher Wise";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Final Accounts";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Cost  Category";
            treeNode6.Name = "Node8";
            treeNode6.Text = "Cash Flow";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Reports";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Revenue";
            treeNode9.Name = "Node8";
            treeNode9.Text = "Hospital Revenue";
            this.treeview.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9});
            this.treeview.Size = new System.Drawing.Size(175, 400);
            this.treeview.TabIndex = 0;
            this.treeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview_AfterSelect);
            // 
            // frmACCMSReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(801, 551);
            this.KeyPreview = false;
            this.Name = "frmACCMSReportMain";
            this.Load += new System.EventHandler(this.frmACCMSReportMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTreeView treeview;
    }
}
