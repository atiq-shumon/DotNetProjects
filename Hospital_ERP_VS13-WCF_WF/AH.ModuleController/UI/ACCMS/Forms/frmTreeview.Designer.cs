namespace AH.ModuleController.UI.ACCMS.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mnuGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChartofAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLedgerEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.tvwGroup = new AtiqsControlLibrary.SmartTreeView();
            this.treeviewprint = new System.Windows.Forms.TreeView();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnScript = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.mnuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(300, 10);
            this.frmLabel.Size = new System.Drawing.Size(225, 33);
            this.frmLabel.Text = "Chart of Accounts";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.treeviewprint);
            this.pnlMain.Controls.Add(this.tvwGroup);
            this.pnlMain.Location = new System.Drawing.Point(1, 58);
            this.pnlMain.Size = new System.Drawing.Size(828, 628);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnScript);
            this.pnlTop.Size = new System.Drawing.Size(830, 58);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnScript, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(181, 687);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 687);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(62, 688);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(477, 687);
            this.btnNew.Size = new System.Drawing.Size(121, 39);
            this.btnNew.Text = "Export";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(711, 688);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(601, 688);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 731);
            this.groupBox1.Size = new System.Drawing.Size(830, 25);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "FOLDRS01.ICO");
            this.imageList1.Images.SetKeyName(1, "DATA16.ICO");
            this.imageList1.Images.SetKeyName(2, "Text.ico");
            // 
            // mnuGroup
            // 
            this.mnuGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.mnuChartofAccounts});
            this.mnuGroup.Name = "mnuGroup";
            this.mnuGroup.Size = new System.Drawing.Size(108, 48);
            this.mnuGroup.Opening += new System.ComponentModel.CancelEventHandler(this.mnuGroup_Opening);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGroupAdd,
            this.mnuEdit,
            this.mnuGDelete});
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // mnuGroupAdd
            // 
            this.mnuGroupAdd.Name = "mnuGroupAdd";
            this.mnuGroupAdd.Size = new System.Drawing.Size(105, 22);
            this.mnuGroupAdd.Text = "Add";
            this.mnuGroupAdd.Click += new System.EventHandler(this.mnuGroupAdd_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(105, 22);
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuGDelete
            // 
            this.mnuGDelete.Name = "mnuGDelete";
            this.mnuGDelete.Size = new System.Drawing.Size(105, 22);
            this.mnuGDelete.Text = "Delete";
            this.mnuGDelete.Visible = false;
            this.mnuGDelete.Click += new System.EventHandler(this.mnuGDelete_Click);
            // 
            // mnuChartofAccounts
            // 
            this.mnuChartofAccounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuLedgerEdit,
            this.mnuDelete});
            this.mnuChartofAccounts.Name = "mnuChartofAccounts";
            this.mnuChartofAccounts.Size = new System.Drawing.Size(107, 22);
            this.mnuChartofAccounts.Text = "Ledger";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(105, 22);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuLedgerEdit
            // 
            this.mnuLedgerEdit.Name = "mnuLedgerEdit";
            this.mnuLedgerEdit.Size = new System.Drawing.Size(105, 22);
            this.mnuLedgerEdit.Text = "Edit";
            this.mnuLedgerEdit.Click += new System.EventHandler(this.mnuLedgerEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(105, 22);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Visible = false;
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnrefresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Blue;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(362, 688);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(113, 39);
            this.btnrefresh.TabIndex = 46;
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // tvwGroup
            // 
            this.tvwGroup.BackColor = System.Drawing.Color.LightYellow;
            this.tvwGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvwGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvwGroup.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvwGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwGroup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tvwGroup.ImageIndex = 0;
            this.tvwGroup.ImageList = this.imageList1;
            this.tvwGroup.LineColor = System.Drawing.Color.Crimson;
            this.tvwGroup.Location = new System.Drawing.Point(9, 4);
            this.tvwGroup.Name = "tvwGroup";
            this.tvwGroup.SelectedImageIndex = 0;
            this.tvwGroup.Size = new System.Drawing.Size(805, 618);
            this.tvwGroup.TabIndex = 15;
            this.tvwGroup.DoubleClick += new System.EventHandler(this.tvwGroup_DoubleClick);
            this.tvwGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvwGroup_MouseDown);
            // 
            // treeviewprint
            // 
            this.treeviewprint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeviewprint.Location = new System.Drawing.Point(407, 7);
            this.treeviewprint.Name = "treeviewprint";
            this.treeviewprint.Size = new System.Drawing.Size(407, 602);
            this.treeviewprint.TabIndex = 16;
            this.treeviewprint.Visible = false;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnPreview.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.Navy;
            this.btnPreview.Location = new System.Drawing.Point(176, 688);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(108, 39);
            this.btnPreview.TabIndex = 47;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Visible = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnScript
            // 
            this.btnScript.Location = new System.Drawing.Point(740, 2);
            this.btnScript.Name = "btnScript";
            this.btnScript.Size = new System.Drawing.Size(32, 7);
            this.btnScript.TabIndex = 48;
            this.btnScript.UseVisualStyleBackColor = true;
            this.btnScript.Visible = false;
            this.btnScript.Click += new System.EventHandler(this.btnScript_Click);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(830, 756);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnrefresh);
            this.isEnterTabAllow = true;
            this.Name = "frmTreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnrefresh, 0);
            this.Controls.SetChildIndex(this.btnPreview, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.mnuGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip mnuGroup;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuChartofAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuGroupAdd;
        private AtiqsControlLibrary.SmartTreeView tvwGroup;
        private System.Windows.Forms.TreeView treeviewprint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuLedgerEdit;
        private System.Windows.Forms.Button btnScript;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuGDelete;
    }
}
