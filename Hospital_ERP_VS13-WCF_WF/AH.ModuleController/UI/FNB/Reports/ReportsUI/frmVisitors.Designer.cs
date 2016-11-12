namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmVisitors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitors));
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtVisitorsName = new AtiqsControlLibrary.SmartTextBox();
            this.txtNetTotal = new AtiqsControlLibrary.SmartTextBox();
            this.DGdown = new System.Windows.Forms.DataGridView();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtInvoiceNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtDiscount = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtVat = new AtiqsControlLibrary.SmartTextBox();
            this.txtNetPaid = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radSetMenu = new System.Windows.Forms.RadioButton();
            this.radCategory = new System.Windows.Forms.RadioButton();
            this.lvwCategory = new AtiqsControlLibrary.SmartListViewDetails();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwDisplay = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtSearch = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.lvwVisitors = new AtiqsControlLibrary.SmartListViewDetails();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(622, 9);
            this.frmLabel.Size = new System.Drawing.Size(177, 33);
            this.frmLabel.Text = "Visitors Order";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtEmpName);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Controls.Add(this.listView1);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.lvwVisitors);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.lvwDisplay);
            this.pnlMain.Controls.Add(this.lvwCategory);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtNetPaid);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtVat);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtDiscount);
            this.pnlMain.Controls.Add(this.txtInvoiceNo);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.DGdown);
            this.pnlMain.Controls.Add(this.txtNetTotal);
            this.pnlMain.Controls.Add(this.txtVisitorsName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(1520, 863);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1521, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1185, 778);
            this.btnEdit.Text = "List ";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1296, 778);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 778);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(989, 778);
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1407, 778);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(642, 778);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 818);
            this.groupBox1.Size = new System.Drawing.Size(1521, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(817, 767);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(88, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Visitors Name:";
            this.smartLabel1.Visible = false;
            // 
            // txtVisitorsName
            // 
            this.txtVisitorsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitorsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorsName.Location = new System.Drawing.Point(912, 762);
            this.txtVisitorsName.Name = "txtVisitorsName";
            this.txtVisitorsName.Size = new System.Drawing.Size(301, 24);
            this.txtVisitorsName.TabIndex = 1;
            this.txtVisitorsName.Text = "None";
            this.txtVisitorsName.Visible = false;
            this.txtVisitorsName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVisitorsName_KeyPress);
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetTotal.Enabled = false;
            this.txtNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetTotal.Location = new System.Drawing.Point(1291, 737);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(219, 24);
            this.txtNetTotal.TabIndex = 37;
            // 
            // DGdown
            // 
            this.DGdown.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdown.Location = new System.Drawing.Point(826, 190);
            this.DGdown.Name = "DGdown";
            this.DGdown.Size = new System.Drawing.Size(688, 541);
            this.DGdown.TabIndex = 38;
            this.DGdown.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGdown_CellContentClick);
            this.DGdown.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGdown_CellEndEdit);
            this.DGdown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGdown_KeyPress);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(1219, 743);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(64, 13);
            this.smartLabel2.TabIndex = 39;
            this.smartLabel2.Text = "Net Total:";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(16, 364);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(177, 24);
            this.txtInvoiceNo.TabIndex = 41;
            this.txtInvoiceNo.Visible = false;
            this.txtInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNo_KeyPress);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(1222, 773);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(61, 13);
            this.smartLabel4.TabIndex = 43;
            this.smartLabel4.Text = "Discount:";
            this.smartLabel4.Visible = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(1291, 767);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(219, 24);
            this.txtDiscount.TabIndex = 42;
            this.txtDiscount.Visible = false;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(1231, 803);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(47, 13);
            this.smartLabel5.TabIndex = 45;
            this.smartLabel5.Text = "Vat(%):";
            this.smartLabel5.Visible = false;
            // 
            // txtVat
            // 
            this.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(1291, 797);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(219, 24);
            this.txtVat.TabIndex = 44;
            this.txtVat.Visible = false;
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            this.txtVat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVat_KeyPress);
            // 
            // txtNetPaid
            // 
            this.txtNetPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetPaid.Enabled = false;
            this.txtNetPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPaid.Location = new System.Drawing.Point(1291, 827);
            this.txtNetPaid.Name = "txtNetPaid";
            this.txtNetPaid.Size = new System.Drawing.Size(219, 24);
            this.txtNetPaid.TabIndex = 46;
            this.txtNetPaid.Visible = false;
            this.txtNetPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetPaid_KeyPress);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(1222, 833);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(60, 13);
            this.smartLabel6.TabIndex = 47;
            this.smartLabel6.Text = "Net Paid:";
            this.smartLabel6.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radSetMenu);
            this.groupBox2.Controls.Add(this.radCategory);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 60);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // radSetMenu
            // 
            this.radSetMenu.AutoSize = true;
            this.radSetMenu.Location = new System.Drawing.Point(115, 30);
            this.radSetMenu.Name = "radSetMenu";
            this.radSetMenu.Size = new System.Drawing.Size(71, 17);
            this.radSetMenu.TabIndex = 1;
            this.radSetMenu.Text = "Set Menu";
            this.radSetMenu.UseVisualStyleBackColor = true;
            this.radSetMenu.CheckedChanged += new System.EventHandler(this.radSetMenu_CheckedChanged);
            // 
            // radCategory
            // 
            this.radCategory.AutoSize = true;
            this.radCategory.Checked = true;
            this.radCategory.Location = new System.Drawing.Point(17, 30);
            this.radCategory.Name = "radCategory";
            this.radCategory.Size = new System.Drawing.Size(67, 17);
            this.radCategory.TabIndex = 0;
            this.radCategory.TabStop = true;
            this.radCategory.Text = "Category";
            this.radCategory.UseVisualStyleBackColor = true;
            this.radCategory.CheckedChanged += new System.EventHandler(this.radCategory_CheckedChanged);
            // 
            // lvwCategory
            // 
            this.lvwCategory.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvwCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwCategory.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwCategory.FullRowSelect = true;
            this.lvwCategory.GridLines = true;
            this.lvwCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwCategory.Location = new System.Drawing.Point(11, 393);
            this.lvwCategory.Name = "lvwCategory";
            this.lvwCategory.Size = new System.Drawing.Size(188, 460);
            this.lvwCategory.TabIndex = 50;
            this.lvwCategory.UseCompatibleStateImageBehavior = false;
            this.lvwCategory.View = System.Windows.Forms.View.Details;
            this.lvwCategory.SelectedIndexChanged += new System.EventHandler(this.lvwCategory_SelectedIndexChanged);
            this.lvwCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvwCategory_KeyPress);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category Code";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Category Name";
            this.columnHeader4.Width = 185;
            // 
            // lvwDisplay
            // 
            this.lvwDisplay.BackColor = System.Drawing.Color.White;
            this.lvwDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwDisplay.FullRowSelect = true;
            this.lvwDisplay.LargeImageList = this.imageList1;
            this.lvwDisplay.Location = new System.Drawing.Point(205, 215);
            this.lvwDisplay.Name = "lvwDisplay";
            this.lvwDisplay.Size = new System.Drawing.Size(617, 634);
            this.lvwDisplay.TabIndex = 51;
            this.lvwDisplay.UseCompatibleStateImageBehavior = false;
            this.lvwDisplay.DoubleClick += new System.EventHandler(this.lvwDisplay_DoubleClick);
            this.lvwDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvwDisplay_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images.jpg");
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(17, 299);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 24);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.ForeColor = System.Drawing.Color.Blue;
            this.smartLabel3.Location = new System.Drawing.Point(19, 281);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(51, 13);
            this.smartLabel3.TabIndex = 54;
            this.smartLabel3.Text = "Serach:";
            // 
            // lvwVisitors
            // 
            this.lvwVisitors.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwVisitors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwVisitors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwVisitors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwVisitors.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwVisitors.FullRowSelect = true;
            this.lvwVisitors.GridLines = true;
            this.lvwVisitors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwVisitors.Location = new System.Drawing.Point(936, 796);
            this.lvwVisitors.Name = "lvwVisitors";
            this.lvwVisitors.Size = new System.Drawing.Size(258, 35);
            this.lvwVisitors.TabIndex = 55;
            this.lvwVisitors.UseCompatibleStateImageBehavior = false;
            this.lvwVisitors.View = System.Windows.Forms.View.Details;
            this.lvwVisitors.Visible = false;
            this.lvwVisitors.SelectedIndexChanged += new System.EventHandler(this.lvwVisitors_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category Code";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category Name";
            this.columnHeader2.Width = 130;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.Blue;
            this.smartLabel7.Location = new System.Drawing.Point(16, 344);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(73, 13);
            this.smartLabel7.TabIndex = 56;
            this.smartLabel7.Text = "Invoice No:";
            this.smartLabel7.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(845, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(506, 32);
            this.listView1.TabIndex = 57;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "images.jpg");
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(13, 178);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(186, 22);
            this.txtEmpID.TabIndex = 58;
            this.txtEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpID_KeyPress);
            this.txtEmpID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmpID_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Emp. ID:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(233, 177);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(526, 22);
            this.txtEmpName.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Emp Name:";
            // 
            // frmVisitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1521, 843);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmVisitors";
            this.Load += new System.EventHandler(this.frmVisitors_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtVisitorsName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtNetTotal;
        private System.Windows.Forms.DataGridView DGdown;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtInvoiceNo;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtNetPaid;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtVat;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtDiscount;
        private System.Windows.Forms.ListView lvwDisplay;
        private AtiqsControlLibrary.SmartListViewDetails lvwCategory;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radSetMenu;
        private System.Windows.Forms.RadioButton radCategory;
        private AtiqsControlLibrary.SmartTextBox txtSearch;
        private AtiqsControlLibrary.SmartListViewDetails lvwVisitors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpID;
    }
}
