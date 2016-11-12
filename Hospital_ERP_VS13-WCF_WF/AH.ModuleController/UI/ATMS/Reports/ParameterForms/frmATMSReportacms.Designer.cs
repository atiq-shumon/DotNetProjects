namespace AH.ModuleController.UI.ATMS.Reports.ParameterForms
{
    partial class frmATMSReportacms
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Mrr");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Issue");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Damage");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Return");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Report", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.smartTreeView1 = new AtiqsControlLibrary.SmartTreeView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(544, 345);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(430, 345);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(283, 9);
            this.frmLabel.Size = new System.Drawing.Size(108, 32);
            this.frmLabel.Text = "Reports";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.lvlStartDate);
            this.pnlMain.Controls.Add(this.lvlEndDate);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.comboBox1);
            this.pnlMain.Controls.Add(this.smartTreeView1);
            this.pnlMain.Size = new System.Drawing.Size(718, 286);
            // 
            // smartTreeView1
            // 
            this.smartTreeView1.BackColor = System.Drawing.Color.SteelBlue;
            this.smartTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTreeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartTreeView1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTreeView1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.smartTreeView1.LineColor = System.Drawing.Color.BlanchedAlmond;
            this.smartTreeView1.Location = new System.Drawing.Point(32, 5);
            this.smartTreeView1.Name = "smartTreeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Mrr";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Issue";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Damage";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Return";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Report";
            this.smartTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.smartTreeView1.Size = new System.Drawing.Size(193, 276);
            this.smartTreeView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(375, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(271, 57);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(78, 13);
            this.smartLabel1.TabIndex = 2;
            this.smartLabel1.Text = "Voucher No:";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(458, 162);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(184, 26);
            this.dtEndDate.TabIndex = 22;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(458, 131);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(184, 26);
            this.dtStartDate.TabIndex = 21;
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(378, 136);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(71, 18);
            this.lvlStartDate.TabIndex = 19;
            this.lvlStartDate.Text = "Start Date:";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(382, 166);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(67, 18);
            this.lvlEndDate.TabIndex = 20;
            this.lvlEndDate.Text = "End Date:";
            // 
            // frmATMSReportacms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 412);
            this.Name = "frmATMSReportacms";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private AtiqsControlLibrary.SmartTreeView smartTreeView1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
    }
}
