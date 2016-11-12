namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmAssetsUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssetsUser));
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtPrefix = new AtiqsControlLibrary.SmartTextBox();
            this.txtStartingNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtTotalNoUser = new AtiqsControlLibrary.SmartTextBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lvwAssetsUser = new AtiqsControlLibrary.SmartListViewDetails();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvwDasboard = new System.Windows.Forms.ListView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(429, 9);
            this.frmLabel.Size = new System.Drawing.Size(320, 33);
            this.frmLabel.Text = "Assets User Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwDasboard);
            this.pnlMain.Controls.Add(this.lvwAssetsUser);
            this.pnlMain.Controls.Add(this.btnGenerate);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.txtTotalNoUser);
            this.pnlMain.Controls.Add(this.txtStartingNo);
            this.pnlMain.Controls.Add(this.txtPrefix);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(1125, 636);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1137, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(-18, 555);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(472, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(95, 555);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(585, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(206, 555);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(1137, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(29, 204);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(132, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Department Name:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(76, 238);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(87, 14);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "User Prefix:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(73, 267);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(87, 14);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "Starting No:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(78, 304);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(82, 14);
            this.smartLabel4.TabIndex = 3;
            this.smartLabel4.Text = "No of User:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefix.Location = new System.Drawing.Point(167, 238);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(278, 24);
            this.txtPrefix.TabIndex = 4;
            this.txtPrefix.Text = "PC#";
            // 
            // txtStartingNo
            // 
            this.txtStartingNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingNo.Location = new System.Drawing.Point(167, 269);
            this.txtStartingNo.Name = "txtStartingNo";
            this.txtStartingNo.Size = new System.Drawing.Size(100, 24);
            this.txtStartingNo.TabIndex = 5;
            // 
            // txtTotalNoUser
            // 
            this.txtTotalNoUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalNoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNoUser.Location = new System.Drawing.Point(167, 300);
            this.txtTotalNoUser.Name = "txtTotalNoUser";
            this.txtTotalNoUser.Size = new System.Drawing.Size(100, 24);
            this.txtTotalNoUser.TabIndex = 6;
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(167, 201);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(278, 26);
            this.cboDepartment.TabIndex = 7;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            this.cboDepartment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboDepartment_KeyUp);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(273, 300);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(40, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "...";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lvwAssetsUser
            // 
            this.lvwAssetsUser.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwAssetsUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwAssetsUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwAssetsUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwAssetsUser.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAssetsUser.FullRowSelect = true;
            this.lvwAssetsUser.GridLines = true;
            this.lvwAssetsUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwAssetsUser.Location = new System.Drawing.Point(33, 354);
            this.lvwAssetsUser.Name = "lvwAssetsUser";
            this.lvwAssetsUser.Size = new System.Drawing.Size(355, 269);
            this.lvwAssetsUser.TabIndex = 9;
            this.lvwAssetsUser.UseCompatibleStateImageBehavior = false;
            this.lvwAssetsUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Assets User";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Auto No";
            this.columnHeader2.Width = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folio.JPG");
            this.imageList1.Images.SetKeyName(1, "Depend01.ico");
            this.imageList1.Images.SetKeyName(2, "DELETE.ICO");
            this.imageList1.Images.SetKeyName(3, "01.jpg");
            this.imageList1.Images.SetKeyName(4, "03.jpg");
            this.imageList1.Images.SetKeyName(5, "Bed3.jpeg");
            this.imageList1.Images.SetKeyName(6, "Cancel1.jpeg");
            this.imageList1.Images.SetKeyName(7, "Emer1.jpeg");
            this.imageList1.Images.SetKeyName(8, "Normal.jpeg");
            // 
            // lvwDasboard
            // 
            this.lvwDasboard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lvwDasboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwDasboard.LargeImageList = this.imageList1;
            this.lvwDasboard.Location = new System.Drawing.Point(451, 203);
            this.lvwDasboard.Name = "lvwDasboard";
            this.lvwDasboard.Size = new System.Drawing.Size(665, 420);
            this.lvwDasboard.TabIndex = 10;
            this.lvwDasboard.UseCompatibleStateImageBehavior = false;
            this.lvwDasboard.SelectedIndexChanged += new System.EventHandler(this.lvwDasboard_SelectedIndexChanged);
            this.lvwDasboard.Click += new System.EventHandler(this.lvwDasboard_Click);
            this.lvwDasboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwDasboard_MouseDown);
            // 
            // frmAssetsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1137, 623);
            this.Name = "frmAssetsUser";
            this.Load += new System.EventHandler(this.frmAssetsUser_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwAssetsUser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cboDepartment;
        private AtiqsControlLibrary.SmartTextBox txtTotalNoUser;
        private AtiqsControlLibrary.SmartTextBox txtStartingNo;
        private AtiqsControlLibrary.SmartTextBox txtPrefix;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvwDasboard;
    }
}
