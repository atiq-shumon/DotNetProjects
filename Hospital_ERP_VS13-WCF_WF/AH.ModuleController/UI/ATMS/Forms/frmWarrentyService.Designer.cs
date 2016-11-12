namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmWarrentyService
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txttagNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductName = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductCode = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtWarrentyDate = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.DG = new System.Windows.Forms.DataGridView();
            this.mskFDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.mskTdate = new AtiqsControlLibrary.SmartDateTextBox();
            this.dteWdate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(428, 7);
            this.frmLabel.Size = new System.Drawing.Size(218, 33);
            this.frmLabel.Text = "Warrenty/Service";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.dteWdate);
            this.pnlMain.Controls.Add(this.mskTdate);
            this.pnlMain.Controls.Add(this.mskFDate);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtWarrentyDate);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtProductCode);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtProductName);
            this.pnlMain.Controls.Add(this.txttagNo);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(1068, 685);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1068, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(131, 599);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(505, 603);
            this.btnSave.TabIndex = 9;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(17, 599);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(201, 599);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(623, 603);
            this.btnClose.TabIndex = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(128, 599);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 642);
            this.groupBox1.Size = new System.Drawing.Size(1068, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel1.Location = new System.Drawing.Point(83, 211);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(56, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Tag No:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel2.Location = new System.Drawing.Point(39, 244);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(100, 14);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Product Name:";
            // 
            // txttagNo
            // 
            this.txttagNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttagNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttagNo.Location = new System.Drawing.Point(156, 211);
            this.txttagNo.Name = "txttagNo";
            this.txttagNo.ReadOnly = true;
            this.txttagNo.Size = new System.Drawing.Size(359, 24);
            this.txttagNo.TabIndex = 2;
            this.txttagNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttagNo_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(156, 244);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(359, 24);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // txtProductCode
            // 
            this.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(668, 150);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(246, 24);
            this.txtProductCode.TabIndex = 5;
            this.txtProductCode.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(525, 156);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(88, 13);
            this.smartLabel3.TabIndex = 4;
            this.smartLabel3.Text = "Product Code:";
            this.smartLabel3.Visible = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel4.Location = new System.Drawing.Point(597, 244);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(126, 14);
            this.smartLabel4.TabIndex = 8;
            this.smartLabel4.Text = "Service Start Date:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel5.Location = new System.Drawing.Point(604, 282);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(119, 14);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "Service End Date:";
            // 
            // txtWarrentyDate
            // 
            this.txtWarrentyDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarrentyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarrentyDate.Location = new System.Drawing.Point(738, 211);
            this.txtWarrentyDate.Name = "txtWarrentyDate";
            this.txtWarrentyDate.ReadOnly = true;
            this.txtWarrentyDate.Size = new System.Drawing.Size(227, 24);
            this.txtWarrentyDate.TabIndex = 5;
            this.txtWarrentyDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWarrentyDate_KeyPress);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel6.Location = new System.Drawing.Point(618, 211);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(105, 14);
            this.smartLabel6.TabIndex = 11;
            this.smartLabel6.Text = "Warrenty Date:";
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column9,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column11});
            this.DG.Location = new System.Drawing.Point(25, 377);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(1023, 301);
            this.DG.TabIndex = 8;
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            this.DG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DG_KeyDown);
            // 
            // mskFDate
            // 
            this.mskFDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mskFDate.Location = new System.Drawing.Point(738, 244);
            this.mskFDate.Mask = "00/00/0000";
            this.mskFDate.Name = "mskFDate";
            this.mskFDate.Size = new System.Drawing.Size(227, 24);
            this.mskFDate.TabIndex = 6;
            this.mskFDate.ValidatingType = typeof(System.DateTime);
            this.mskFDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskFDate_KeyPress);
            // 
            // mskTdate
            // 
            this.mskTdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mskTdate.Location = new System.Drawing.Point(738, 282);
            this.mskTdate.Mask = "00/00/0000";
            this.mskTdate.Name = "mskTdate";
            this.mskTdate.Size = new System.Drawing.Size(227, 24);
            this.mskTdate.TabIndex = 7;
            this.mskTdate.ValidatingType = typeof(System.DateTime);
            this.mskTdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTdate_KeyPress);
            // 
            // dteWdate
            // 
            this.dteWdate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteWdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteWdate.Location = new System.Drawing.Point(156, 282);
            this.dteWdate.Name = "dteWdate";
            this.dteWdate.Size = new System.Drawing.Size(200, 26);
            this.dteWdate.TabIndex = 4;
            this.dteWdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteWdate_KeyPress);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel7.Location = new System.Drawing.Point(97, 282);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(42, 14);
            this.smartLabel7.TabIndex = 16;
            this.smartLabel7.Text = "Date:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(991, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 26);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tag No#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Product Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Date";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "From Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "To Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Warrenty Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Received Date";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Notes";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Del";
            this.Column10.Name = "Column10";
            this.Column10.Width = 30;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Status";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // frmWarrentyService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1068, 667);
            this.KeyPreview = false;
            this.Name = "frmWarrentyService";
            this.Load += new System.EventHandler(this.frmWarrentyService_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtWarrentyDate;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtProductCode;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtProductName;
        private AtiqsControlLibrary.SmartTextBox txttagNo;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.DateTimePicker dteWdate;
        private AtiqsControlLibrary.SmartDateTextBox mskTdate;
        private AtiqsControlLibrary.SmartDateTextBox mskFDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}
