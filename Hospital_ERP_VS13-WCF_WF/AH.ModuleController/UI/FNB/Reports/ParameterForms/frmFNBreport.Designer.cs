namespace AH.ModuleController.UI.FNB.Reports
{
    partial class frmFNBreport
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Food Item");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Daily Collection");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Collection From Visitors");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Reports", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.tvReport = new AtiqsControlLibrary.SmartTreeView();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cbofoodCat = new System.Windows.Forms.ComboBox();
            this.GrpDate = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.GrpSelection = new System.Windows.Forms.GroupBox();
            this.radDetails = new System.Windows.Forms.RadioButton();
            this.radSumm = new System.Windows.Forms.RadioButton();
            this.grpuserWiseSelection = new System.Windows.Forms.GroupBox();
            this.radIndividual = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.grpCardNo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.grpSelDate = new System.Windows.Forms.GroupBox();
            this.mskTDate = new System.Windows.Forms.DateTimePicker();
            this.mskFDate = new System.Windows.Forms.DateTimePicker();
            this.lblTdate = new AtiqsControlLibrary.SmartLabel();
            this.lblFDate = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.GrpDate.SuspendLayout();
            this.GrpSelection.SuspendLayout();
            this.grpuserWiseSelection.SuspendLayout();
            this.grpCardNo.SuspendLayout();
            this.grpSelDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(579, 471);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(465, 471);
            this.btnPrint.Size = new System.Drawing.Size(108, 37);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(296, 9);
            this.frmLabel.Size = new System.Drawing.Size(108, 32);
            this.frmLabel.Text = "Reports";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpSelDate);
            this.pnlMain.Controls.Add(this.grpCardNo);
            this.pnlMain.Controls.Add(this.grpuserWiseSelection);
            this.pnlMain.Controls.Add(this.GrpSelection);
            this.pnlMain.Controls.Add(this.GrpDate);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cbofoodCat);
            this.pnlMain.Controls.Add(this.tvReport);
            this.pnlMain.Size = new System.Drawing.Size(721, 416);
            // 
            // tvReport
            // 
            this.tvReport.BackColor = System.Drawing.Color.LightYellow;
            this.tvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvReport.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvReport.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tvReport.LineColor = System.Drawing.Color.Crimson;
            this.tvReport.Location = new System.Drawing.Point(34, 12);
            this.tvReport.Name = "tvReport";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Food Item";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Daily Collection";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Collection From Visitors";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Reports";
            this.tvReport.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvReport.Size = new System.Drawing.Size(255, 366);
            this.tvReport.TabIndex = 0;
            this.tvReport.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvReport_AfterSelect);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(309, 23);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(129, 13);
            this.smartLabel3.TabIndex = 18;
            this.smartLabel3.Text = "Food Category Name:";
            // 
            // cbofoodCat
            // 
            this.cbofoodCat.Enabled = false;
            this.cbofoodCat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofoodCat.FormattingEnabled = true;
            this.cbofoodCat.Location = new System.Drawing.Point(446, 18);
            this.cbofoodCat.Name = "cbofoodCat";
            this.cbofoodCat.Size = new System.Drawing.Size(222, 24);
            this.cbofoodCat.TabIndex = 17;
            this.cbofoodCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbofoodCat_KeyPress);
            // 
            // GrpDate
            // 
            this.GrpDate.Controls.Add(this.label3);
            this.GrpDate.Controls.Add(this.cboDate);
            this.GrpDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDate.Location = new System.Drawing.Point(299, 257);
            this.GrpDate.Name = "GrpDate";
            this.GrpDate.Size = new System.Drawing.Size(411, 64);
            this.GrpDate.TabIndex = 19;
            this.GrpDate.TabStop = false;
            this.GrpDate.Text = "Selection";
            this.GrpDate.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // cboDate
            // 
            this.cboDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Items.AddRange(new object[] {
            "--Select--",
            "Today’s",
            "Yesterday",
            "Last week",
            "Last Month",
            "This Month",
            "Date"});
            this.cboDate.Location = new System.Drawing.Point(135, 24);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(197, 24);
            this.cboDate.TabIndex = 23;
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            // 
            // GrpSelection
            // 
            this.GrpSelection.Controls.Add(this.radDetails);
            this.GrpSelection.Controls.Add(this.radSumm);
            this.GrpSelection.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpSelection.Location = new System.Drawing.Point(299, 69);
            this.GrpSelection.Name = "GrpSelection";
            this.GrpSelection.Size = new System.Drawing.Size(411, 53);
            this.GrpSelection.TabIndex = 20;
            this.GrpSelection.TabStop = false;
            this.GrpSelection.Text = "Selection";
            this.GrpSelection.Visible = false;
            // 
            // radDetails
            // 
            this.radDetails.AutoSize = true;
            this.radDetails.Location = new System.Drawing.Point(286, 21);
            this.radDetails.Name = "radDetails";
            this.radDetails.Size = new System.Drawing.Size(68, 18);
            this.radDetails.TabIndex = 1;
            this.radDetails.Text = "Details";
            this.radDetails.UseVisualStyleBackColor = true;
            // 
            // radSumm
            // 
            this.radSumm.AutoSize = true;
            this.radSumm.Checked = true;
            this.radSumm.Location = new System.Drawing.Point(122, 21);
            this.radSumm.Name = "radSumm";
            this.radSumm.Size = new System.Drawing.Size(83, 18);
            this.radSumm.TabIndex = 0;
            this.radSumm.TabStop = true;
            this.radSumm.Text = "Summary";
            this.radSumm.UseVisualStyleBackColor = true;
            // 
            // grpuserWiseSelection
            // 
            this.grpuserWiseSelection.Controls.Add(this.radIndividual);
            this.grpuserWiseSelection.Controls.Add(this.radAll);
            this.grpuserWiseSelection.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpuserWiseSelection.Location = new System.Drawing.Point(299, 131);
            this.grpuserWiseSelection.Name = "grpuserWiseSelection";
            this.grpuserWiseSelection.Size = new System.Drawing.Size(411, 53);
            this.grpuserWiseSelection.TabIndex = 21;
            this.grpuserWiseSelection.TabStop = false;
            this.grpuserWiseSelection.Text = "User Wise Sales";
            this.grpuserWiseSelection.Visible = false;
            // 
            // radIndividual
            // 
            this.radIndividual.AutoSize = true;
            this.radIndividual.Location = new System.Drawing.Point(286, 21);
            this.radIndividual.Name = "radIndividual";
            this.radIndividual.Size = new System.Drawing.Size(86, 18);
            this.radIndividual.TabIndex = 1;
            this.radIndividual.Text = "Individual";
            this.radIndividual.UseVisualStyleBackColor = true;
            this.radIndividual.CheckedChanged += new System.EventHandler(this.radIndividual_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Location = new System.Drawing.Point(122, 21);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(39, 18);
            this.radAll.TabIndex = 0;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // grpCardNo
            // 
            this.grpCardNo.Controls.Add(this.label1);
            this.grpCardNo.Controls.Add(this.txtUserID);
            this.grpCardNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCardNo.Location = new System.Drawing.Point(299, 190);
            this.grpCardNo.Name = "grpCardNo";
            this.grpCardNo.Size = new System.Drawing.Size(411, 53);
            this.grpCardNo.TabIndex = 22;
            this.grpCardNo.TabStop = false;
            this.grpCardNo.Text = "Selection";
            this.grpCardNo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "LogIn User ID:";
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Location = new System.Drawing.Point(134, 22);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(194, 22);
            this.txtUserID.TabIndex = 0;
            // 
            // grpSelDate
            // 
            this.grpSelDate.Controls.Add(this.mskTDate);
            this.grpSelDate.Controls.Add(this.mskFDate);
            this.grpSelDate.Controls.Add(this.lblTdate);
            this.grpSelDate.Controls.Add(this.lblFDate);
            this.grpSelDate.Location = new System.Drawing.Point(299, 323);
            this.grpSelDate.Name = "grpSelDate";
            this.grpSelDate.Size = new System.Drawing.Size(409, 70);
            this.grpSelDate.TabIndex = 24;
            this.grpSelDate.TabStop = false;
            this.grpSelDate.Visible = false;
            // 
            // mskTDate
            // 
            this.mskTDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskTDate.Location = new System.Drawing.Point(147, 38);
            this.mskTDate.Name = "mskTDate";
            this.mskTDate.Size = new System.Drawing.Size(200, 23);
            this.mskTDate.TabIndex = 30;
            this.mskTDate.Visible = false;
            this.mskTDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTDate_KeyPress);
            // 
            // mskFDate
            // 
            this.mskFDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskFDate.Location = new System.Drawing.Point(147, 9);
            this.mskFDate.Name = "mskFDate";
            this.mskFDate.Size = new System.Drawing.Size(200, 23);
            this.mskFDate.TabIndex = 29;
            this.mskFDate.Visible = false;
            this.mskFDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskFDate_KeyPress);
            // 
            // lblTdate
            // 
            this.lblTdate.AutoSize = true;
            this.lblTdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTdate.Location = new System.Drawing.Point(80, 42);
            this.lblTdate.Name = "lblTdate";
            this.lblTdate.Size = new System.Drawing.Size(61, 13);
            this.lblTdate.TabIndex = 28;
            this.lblTdate.Text = "To Date:";
            this.lblTdate.Visible = false;
            // 
            // lblFDate
            // 
            this.lblFDate.AutoSize = true;
            this.lblFDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFDate.Location = new System.Drawing.Point(62, 13);
            this.lblFDate.Name = "lblFDate";
            this.lblFDate.Size = new System.Drawing.Size(79, 13);
            this.lblFDate.TabIndex = 27;
            this.lblFDate.Text = "From Date:";
            this.lblFDate.Visible = false;
            // 
            // frmFNBreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 529);
            this.KeyPreview = false;
            this.Name = "frmFNBreport";
            this.Load += new System.EventHandler(this.frmFNBreport_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.GrpDate.ResumeLayout(false);
            this.GrpDate.PerformLayout();
            this.GrpSelection.ResumeLayout(false);
            this.GrpSelection.PerformLayout();
            this.grpuserWiseSelection.ResumeLayout(false);
            this.grpuserWiseSelection.PerformLayout();
            this.grpCardNo.ResumeLayout(false);
            this.grpCardNo.PerformLayout();
            this.grpSelDate.ResumeLayout(false);
            this.grpSelDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTreeView tvReport;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.ComboBox cbofoodCat;
        private System.Windows.Forms.GroupBox GrpDate;
        private System.Windows.Forms.GroupBox GrpSelection;
        private System.Windows.Forms.RadioButton radDetails;
        private System.Windows.Forms.RadioButton radSumm;
        private System.Windows.Forms.GroupBox grpuserWiseSelection;
        private System.Windows.Forms.RadioButton radIndividual;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.GroupBox grpCardNo;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpSelDate;
        private System.Windows.Forms.DateTimePicker mskTDate;
        private System.Windows.Forms.DateTimePicker mskFDate;
        private AtiqsControlLibrary.SmartLabel lblTdate;
        private AtiqsControlLibrary.SmartLabel lblFDate;
    }
}
