namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOTCalender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOTCalender));
            this.txtotDate = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.patientAssignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTheaterName = new System.Windows.Forms.TextBox();
            this.txtEndtime = new System.Windows.Forms.TextBox();
            this.txtStarttime = new System.Windows.Forms.TextBox();
            this.txtstartRowpos = new System.Windows.Forms.TextBox();
            this.txtColpos = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPrintCal = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvwPackage = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCalenderDetails = new System.Windows.Forms.TabPage();
            this.DG = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnbarPrintNew = new System.Windows.Forms.Button();
            this.btnPrintBar = new System.Windows.Forms.Button();
            this.DGbarChart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dteOTSchedulingDate = new System.Windows.Forms.DateTimePicker();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printCal = new System.Drawing.Printing.PrintDocument();
            this.Printpreview = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGbarChart)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(28, 9);
            this.frmLabel.Size = new System.Drawing.Size(0, 33);
            this.frmLabel.Text = "";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Size = new System.Drawing.Size(1507, 795);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnrefresh);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.dteOTSchedulingDate);
            this.pnlTop.Controls.Add(this.txtTheaterName);
            this.pnlTop.Controls.Add(this.txtEndtime);
            this.pnlTop.Controls.Add(this.txtStarttime);
            this.pnlTop.Controls.Add(this.txtstartRowpos);
            this.pnlTop.Controls.Add(this.txtColpos);
            this.pnlTop.Controls.Add(this.txtotDate);
            this.pnlTop.Size = new System.Drawing.Size(1507, 58);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtotDate, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtColpos, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtstartRowpos, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtStarttime, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtEndtime, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtTheaterName, 0);
            this.pnlTop.Controls.SetChildIndex(this.dteOTSchedulingDate, 0);
            this.pnlTop.Controls.SetChildIndex(this.label1, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnrefresh, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(891, 710);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(778, 710);
            this.btnSave.TabIndex = 2;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1004, 710);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(665, 710);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1226, 710);
            this.btnClose.TabIndex = 6;
            this.btnClose.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1115, 709);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 765);
            this.groupBox1.Size = new System.Drawing.Size(1507, 25);
            // 
            // txtotDate
            // 
            this.txtotDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtotDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtotDate.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotDate.ForeColor = System.Drawing.Color.Red;
            this.txtotDate.Location = new System.Drawing.Point(801, 6);
            this.txtotDate.Multiline = true;
            this.txtotDate.Name = "txtotDate";
            this.txtotDate.ReadOnly = true;
            this.txtotDate.Size = new System.Drawing.Size(548, 39);
            this.txtotDate.TabIndex = 1;
            this.txtotDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientAssignToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(123, 26);
            // 
            // patientAssignToolStripMenuItem
            // 
            this.patientAssignToolStripMenuItem.Name = "patientAssignToolStripMenuItem";
            this.patientAssignToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.patientAssignToolStripMenuItem.Text = "OT Assign";
            this.patientAssignToolStripMenuItem.Click += new System.EventHandler(this.patientAssignToolStripMenuItem_Click);
            // 
            // txtTheaterName
            // 
            this.txtTheaterName.Location = new System.Drawing.Point(297, 5);
            this.txtTheaterName.Name = "txtTheaterName";
            this.txtTheaterName.Size = new System.Drawing.Size(38, 20);
            this.txtTheaterName.TabIndex = 42;
            this.txtTheaterName.Visible = false;
            // 
            // txtEndtime
            // 
            this.txtEndtime.Location = new System.Drawing.Point(231, 5);
            this.txtEndtime.Name = "txtEndtime";
            this.txtEndtime.Size = new System.Drawing.Size(60, 20);
            this.txtEndtime.TabIndex = 41;
            this.txtEndtime.Visible = false;
            // 
            // txtStarttime
            // 
            this.txtStarttime.Location = new System.Drawing.Point(160, 5);
            this.txtStarttime.Name = "txtStarttime";
            this.txtStarttime.Size = new System.Drawing.Size(65, 20);
            this.txtStarttime.TabIndex = 40;
            this.txtStarttime.Visible = false;
            // 
            // txtstartRowpos
            // 
            this.txtstartRowpos.Location = new System.Drawing.Point(3, 5);
            this.txtstartRowpos.Name = "txtstartRowpos";
            this.txtstartRowpos.Size = new System.Drawing.Size(94, 20);
            this.txtstartRowpos.TabIndex = 38;
            this.txtstartRowpos.Visible = false;
            // 
            // txtColpos
            // 
            this.txtColpos.Location = new System.Drawing.Point(103, 5);
            this.txtColpos.Name = "txtColpos";
            this.txtColpos.Size = new System.Drawing.Size(51, 20);
            this.txtColpos.TabIndex = 39;
            this.txtColpos.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 635);
            this.tabControl1.TabIndex = 43;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPrintCal);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.DG);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1374, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OT Calender";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPrintCal
            // 
            this.btnPrintCal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrintCal.Location = new System.Drawing.Point(3, 577);
            this.btnPrintCal.Name = "btnPrintCal";
            this.btnPrintCal.Size = new System.Drawing.Size(46, 26);
            this.btnPrintCal.TabIndex = 40;
            this.btnPrintCal.Text = "View";
            this.btnPrintCal.UseVisualStyleBackColor = false;
            this.btnPrintCal.Click += new System.EventHandler(this.btnPrintCal_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabCalenderDetails);
            this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(53, 464);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1297, 141);
            this.tabControl2.TabIndex = 39;
            this.tabControl2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl2_DrawItem);
            this.tabControl2.Click += new System.EventHandler(this.tabControl2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Teal;
            this.tabPage3.Controls.Add(this.lvwPackage);
            this.tabPage3.Controls.Add(this.lvwDetails);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1289, 114);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            // 
            // lvwPackage
            // 
            this.lvwPackage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvwPackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwPackage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvwPackage.ForeColor = System.Drawing.Color.Blue;
            this.lvwPackage.FullRowSelect = true;
            this.lvwPackage.GridLines = true;
            this.lvwPackage.Location = new System.Drawing.Point(6, 10);
            this.lvwPackage.Name = "lvwPackage";
            this.lvwPackage.Size = new System.Drawing.Size(456, 86);
            this.lvwPackage.TabIndex = 42;
            this.lvwPackage.UseCompatibleStateImageBehavior = false;
            this.lvwPackage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Package Code";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Package Name";
            this.columnHeader5.Width = 330;
            // 
            // lvwDetails
            // 
            this.lvwDetails.BackColor = System.Drawing.Color.White;
            this.lvwDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6});
            this.lvwDetails.FullRowSelect = true;
            this.lvwDetails.GridLines = true;
            this.lvwDetails.Location = new System.Drawing.Point(789, 5);
            this.lvwDetails.Name = "lvwDetails";
            this.lvwDetails.Size = new System.Drawing.Size(487, 91);
            this.lvwDetails.TabIndex = 2;
            this.lvwDetails.UseCompatibleStateImageBehavior = false;
            this.lvwDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Scheduling ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reg No";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Doctors Code";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doctors Name";
            this.columnHeader6.Width = 330;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(568, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 107);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabCalenderDetails
            // 
            this.tabCalenderDetails.BackColor = System.Drawing.Color.Lavender;
            this.tabCalenderDetails.Location = new System.Drawing.Point(4, 23);
            this.tabCalenderDetails.Name = "tabCalenderDetails";
            this.tabCalenderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalenderDetails.Size = new System.Drawing.Size(1289, 114);
            this.tabCalenderDetails.TabIndex = 1;
            this.tabCalenderDetails.Text = "tabPage4";
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DG.Location = new System.Drawing.Point(13, 25);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(1354, 434);
            this.DG.TabIndex = 1;
            this.DG.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_CellMouseDown);
            this.DG.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_CellMouseMove);
            this.DG.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DG_CellPainting);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnbarPrintNew);
            this.tabPage2.Controls.Add(this.btnPrintBar);
            this.tabPage2.Controls.Add(this.DGbarChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1374, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bar Chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnbarPrintNew
            // 
            this.btnbarPrintNew.Location = new System.Drawing.Point(9, 644);
            this.btnbarPrintNew.Name = "btnbarPrintNew";
            this.btnbarPrintNew.Size = new System.Drawing.Size(75, 27);
            this.btnbarPrintNew.TabIndex = 10;
            this.btnbarPrintNew.Text = "Print";
            this.btnbarPrintNew.UseVisualStyleBackColor = true;
            this.btnbarPrintNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrintBar
            // 
            this.btnPrintBar.Location = new System.Drawing.Point(11, 729);
            this.btnPrintBar.Name = "btnPrintBar";
            this.btnPrintBar.Size = new System.Drawing.Size(23, 75);
            this.btnPrintBar.TabIndex = 9;
            this.btnPrintBar.Text = "Print";
            this.btnPrintBar.UseVisualStyleBackColor = true;
            this.btnPrintBar.Click += new System.EventHandler(this.btnPrintBar_Click);
            // 
            // DGbarChart
            // 
            this.DGbarChart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGbarChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGbarChart.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.DGbarChart.Location = new System.Drawing.Point(11, 13);
            this.DGbarChart.Name = "DGbarChart";
            this.DGbarChart.Size = new System.Drawing.Size(1357, 584);
            this.DGbarChart.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(369, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "OT Date:";
            // 
            // dteOTSchedulingDate
            // 
            this.dteOTSchedulingDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteOTSchedulingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteOTSchedulingDate.Location = new System.Drawing.Point(445, 14);
            this.dteOTSchedulingDate.Name = "dteOTSchedulingDate";
            this.dteOTSchedulingDate.Size = new System.Drawing.Size(200, 26);
            this.dteOTSchedulingDate.TabIndex = 43;
            this.dteOTSchedulingDate.ValueChanged += new System.EventHandler(this.dteOTSchedulingDate_ValueChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.LightGray;
            this.btnrefresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Blue;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(649, 14);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(26, 27);
            this.btnrefresh.TabIndex = 45;
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // printDoc
            // 
            this.printDoc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDoc_BeginPrint);
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // printCal
            // 
            this.printCal.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printCal_BeginPrint);
            this.printCal.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCal_PrintPage);
            // 
            // Printpreview
            // 
            this.Printpreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Printpreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Printpreview.ClientSize = new System.Drawing.Size(400, 300);
            this.Printpreview.Enabled = true;
            this.Printpreview.Icon = ((System.Drawing.Icon)(resources.GetObject("Printpreview.Icon")));
            this.Printpreview.Name = "Printpreview";
            this.Printpreview.Visible = false;
            // 
            // frmOTCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1410, 806);
            this.isEnterTabAllow = true;
            this.Name = "frmOTCalender";
            this.Text = "OT Calender";
            this.Load += new System.EventHandler(this.frmOTCalender_Load);
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
            this.menuStrip.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGbarChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtotDate;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem patientAssignToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTheaterName;
        private System.Windows.Forms.TextBox txtEndtime;
        private System.Windows.Forms.TextBox txtStarttime;
        private System.Windows.Forms.TextBox txtstartRowpos;
        private System.Windows.Forms.TextBox txtColpos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dteOTSchedulingDate;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvwDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabCalenderDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvwPackage;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridView DGbarChart;
        private System.Windows.Forms.Button btnPrintBar;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.Button btnPrintCal;
        private System.Drawing.Printing.PrintDocument printCal;
        private System.Windows.Forms.PrintPreviewDialog Printpreview;
        private System.Windows.Forms.Button btnbarPrintNew;
    }
}
