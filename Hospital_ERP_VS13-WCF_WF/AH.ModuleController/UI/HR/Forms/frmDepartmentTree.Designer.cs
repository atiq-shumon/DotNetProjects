namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmDepartmentTree
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
            this.components = new System.ComponentModel.Container();
            this.DeptTreeView = new AtiqsControlLibrary.SmartTreeView();
            this.ContxMenuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMenuAddDeptGrp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuAddDept = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuAddUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.ContxMenuTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(278, 9);
            this.frmLabel.Size = new System.Drawing.Size(218, 33);
            this.frmLabel.Text = "Department Tree";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.DeptTreeView);
            this.pnlMain.Location = new System.Drawing.Point(3, -87);
            this.pnlMain.Size = new System.Drawing.Size(760, 801);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(763, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(315, 720);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(202, 720);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(428, 720);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(89, 720);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(650, 720);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(539, 720);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 759);
            this.groupBox1.Size = new System.Drawing.Size(763, 25);
            // 
            // DeptTreeView
            // 
            this.DeptTreeView.BackColor = System.Drawing.Color.SteelBlue;
            this.DeptTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeptTreeView.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptTreeView.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.DeptTreeView.LineColor = System.Drawing.Color.BlanchedAlmond;
            this.DeptTreeView.Location = new System.Drawing.Point(3, 148);
            this.DeptTreeView.Name = "DeptTreeView";
            this.DeptTreeView.Size = new System.Drawing.Size(756, 648);
            this.DeptTreeView.TabIndex = 1;
            this.DeptTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeptTreeView_MouseDown);
            // 
            // ContxMenuTree
            // 
            this.ContxMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuAddDeptGrp,
            this.toolStripSeparator1,
            this.btnMenuAddDept,
            this.toolStripSeparator2,
            this.btnMenuAddUnit,
            this.toolStripSeparator4,
            this.btnMenuRefresh,
            this.toolStripSeparator3,
            this.btnMenuClose});
            this.ContxMenuTree.Name = "ContxMenuTree";
            this.ContxMenuTree.Size = new System.Drawing.Size(226, 138);
            // 
            // btnMenuAddDeptGrp
            // 
            this.btnMenuAddDeptGrp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAddDeptGrp.Name = "btnMenuAddDeptGrp";
            this.btnMenuAddDeptGrp.Size = new System.Drawing.Size(225, 22);
            this.btnMenuAddDeptGrp.Text = "Add Department Group";
            this.btnMenuAddDeptGrp.Click += new System.EventHandler(this.btnMenuAddDeptGrp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // btnMenuAddDept
            // 
            this.btnMenuAddDept.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAddDept.Name = "btnMenuAddDept";
            this.btnMenuAddDept.Size = new System.Drawing.Size(225, 22);
            this.btnMenuAddDept.Text = "Add Department";
            this.btnMenuAddDept.Click += new System.EventHandler(this.btnMenuAddDept_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // btnMenuAddUnit
            // 
            this.btnMenuAddUnit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAddUnit.Name = "btnMenuAddUnit";
            this.btnMenuAddUnit.Size = new System.Drawing.Size(225, 22);
            this.btnMenuAddUnit.Text = "Add Unit";
            this.btnMenuAddUnit.Click += new System.EventHandler(this.btnMenuAddUnit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(222, 6);
            // 
            // btnMenuRefresh
            // 
            this.btnMenuRefresh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRefresh.Name = "btnMenuRefresh";
            this.btnMenuRefresh.Size = new System.Drawing.Size(225, 22);
            this.btnMenuRefresh.Text = "Refresh";
            this.btnMenuRefresh.Click += new System.EventHandler(this.btnMenuRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // btnMenuClose
            // 
            this.btnMenuClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuClose.Name = "btnMenuClose";
            this.btnMenuClose.Size = new System.Drawing.Size(225, 22);
            this.btnMenuClose.Text = "Close";
            this.btnMenuClose.Click += new System.EventHandler(this.btnMenuClose_Click);
            // 
            // frmDepartmentTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(763, 784);
            this.isEnterTabAllow = true;
            this.Name = "frmDepartmentTree";
            this.Load += new System.EventHandler(this.frmDepartmentTree_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ContxMenuTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTreeView DeptTreeView;
        private System.Windows.Forms.ContextMenuStrip ContxMenuTree;
        private System.Windows.Forms.ToolStripMenuItem btnMenuAddDept;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRefresh;
        private System.Windows.Forms.ToolStripMenuItem btnMenuClose;
        private System.Windows.Forms.ToolStripMenuItem btnMenuAddDeptGrp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnMenuAddUnit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}
