namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmMaterialReceivingReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialReceivingReport));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new AtiqsControlLibrary.SmartTextBox();
            this.dteInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtChallanNo = new AtiqsControlLibrary.SmartTextBox();
            this.dteChallanDate = new System.Windows.Forms.MaskedTextBox();
            this.cboAgainstRefNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgainstRefDate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DG = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.txtNotes = new AtiqsControlLibrary.SmartTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMRRLoad = new System.Windows.Forms.ComboBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.smartTextBox1 = new AtiqsControlLibrary.SmartTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(519, 9);
            this.frmLabel.Size = new System.Drawing.Size(204, 33);
            this.frmLabel.Text = "Material Receipt";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartTextBox1);
            this.pnlMain.Controls.Add(this.cboMRRLoad);
            this.pnlMain.Controls.Add(this.btnSearch2);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.txtNotes);
            this.pnlMain.Controls.Add(this.cboSupplier);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Controls.Add(this.AgainstRefDate);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.cboAgainstRefNo);
            this.pnlMain.Controls.Add(this.dteChallanDate);
            this.pnlMain.Controls.Add(this.txtChallanNo);
            this.pnlMain.Controls.Add(this.dteInvoiceDate);
            this.pnlMain.Controls.Add(this.txtInvoiceNo);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Size = new System.Drawing.Size(1295, 695);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1298, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(601, 613);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(488, 613);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(67, 611);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(264, 613);
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(714, 613);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(375, 613);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 653);
            this.groupBox1.Size = new System.Drawing.Size(1298, 25);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(778, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 138;
            this.label4.Text = "Challan Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 133;
            this.label1.Text = "Voucher  No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 134;
            this.label3.Text = "Voucher Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 136;
            this.label6.Text = "Supplier :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 137;
            this.label8.Text = "Challan No :";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(145, 161);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(283, 24);
            this.txtInvoiceNo.TabIndex = 140;
            // 
            // dteInvoiceDate
            // 
            this.dteInvoiceDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteInvoiceDate.Location = new System.Drawing.Point(145, 190);
            this.dteInvoiceDate.Name = "dteInvoiceDate";
            this.dteInvoiceDate.Size = new System.Drawing.Size(283, 26);
            this.dteInvoiceDate.TabIndex = 141;
            // 
            // txtChallanNo
            // 
            this.txtChallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChallanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanNo.Location = new System.Drawing.Point(145, 260);
            this.txtChallanNo.Name = "txtChallanNo";
            this.txtChallanNo.ReadOnly = true;
            this.txtChallanNo.Size = new System.Drawing.Size(283, 24);
            this.txtChallanNo.TabIndex = 143;
            // 
            // dteChallanDate
            // 
            this.dteChallanDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dteChallanDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteChallanDate.Location = new System.Drawing.Point(889, 260);
            this.dteChallanDate.Mask = "00/00/0000";
            this.dteChallanDate.Name = "dteChallanDate";
            this.dteChallanDate.Size = new System.Drawing.Size(235, 27);
            this.dteChallanDate.TabIndex = 144;
            this.dteChallanDate.ValidatingType = typeof(System.DateTime);
            // 
            // cboAgainstRefNo
            // 
            this.cboAgainstRefNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAgainstRefNo.FormattingEnabled = true;
            this.cboAgainstRefNo.Location = new System.Drawing.Point(889, 190);
            this.cboAgainstRefNo.Name = "cboAgainstRefNo";
            this.cboAgainstRefNo.Size = new System.Drawing.Size(235, 26);
            this.cboAgainstRefNo.TabIndex = 145;
            this.cboAgainstRefNo.SelectedIndexChanged += new System.EventHandler(this.cboAgainstRefNo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(813, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 146;
            this.label5.Text = "Mrr. No :";
            // 
            // AgainstRefDate
            // 
            this.AgainstRefDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgainstRefDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgainstRefDate.Location = new System.Drawing.Point(889, 226);
            this.AgainstRefDate.Mask = "00/00/0000";
            this.AgainstRefDate.Name = "AgainstRefDate";
            this.AgainstRefDate.Size = new System.Drawing.Size(235, 27);
            this.AgainstRefDate.TabIndex = 148;
            this.AgainstRefDate.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(799, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 147;
            this.label9.Text = "Mrr. Date :";
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column1,
            this.Column13,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column27,
            this.Column28,
            this.Column2});
            this.DG.Location = new System.Drawing.Point(11, 337);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(1279, 282);
            this.DG.TabIndex = 149;
            // 
            // Column11
            // 
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Product Code";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Product Name";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column12.Width = 230;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Brand ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Model No";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            this.Column13.Width = 120;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Model Name";
            this.Column18.Name = "Column18";
            this.Column18.Width = 200;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Serial No";
            this.Column19.Name = "Column19";
            this.Column19.Width = 200;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Des1";
            this.Column20.Name = "Column20";
            this.Column20.Width = 80;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Des2";
            this.Column21.Name = "Column21";
            this.Column21.Width = 80;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Des3";
            this.Column22.Name = "Column22";
            this.Column22.Width = 80;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Unit Code";
            this.Column23.Name = "Column23";
            this.Column23.Visible = false;
            this.Column23.Width = 80;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "Unit Name";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Width = 70;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "Qty";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Width = 70;
            // 
            // Column27
            // 
            this.Column27.HeaderText = "Expire Date";
            this.Column27.Name = "Column27";
            this.Column27.Width = 90;
            // 
            // Column28
            // 
            this.Column28.HeaderText = "";
            this.Column28.Name = "Column28";
            this.Column28.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column28.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tag No";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // cboSupplier
            // 
            this.cboSupplier.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(145, 226);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(283, 26);
            this.cboSupplier.TabIndex = 150;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(477, 643);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(455, 24);
            this.txtNotes.TabIndex = 151;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(409, 647);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 152;
            this.label10.Text = "Notes :";
            // 
            // cboMRRLoad
            // 
            this.cboMRRLoad.Enabled = false;
            this.cboMRRLoad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMRRLoad.FormattingEnabled = true;
            this.cboMRRLoad.Location = new System.Drawing.Point(448, 163);
            this.cboMRRLoad.Name = "cboMRRLoad";
            this.cboMRRLoad.Size = new System.Drawing.Size(251, 22);
            this.cboMRRLoad.TabIndex = 154;
            this.cboMRRLoad.SelectedIndexChanged += new System.EventHandler(this.cboMRRLoad_SelectedIndexChanged);
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch2.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch2.Image")));
            this.btnSearch2.Location = new System.Drawing.Point(701, 163);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(34, 20);
            this.btnSearch2.TabIndex = 153;
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // smartTextBox1
            // 
            this.smartTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox1.Location = new System.Drawing.Point(501, 217);
            this.smartTextBox1.Multiline = true;
            this.smartTextBox1.Name = "smartTextBox1";
            this.smartTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.smartTextBox1.Size = new System.Drawing.Size(234, 90);
            this.smartTextBox1.TabIndex = 155;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMaterialReceivingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1298, 678);
            this.Controls.Add(this.button1);
            this.Name = "frmMaterialReceivingReport";
            this.Load += new System.EventHandler(this.frmMaterialReceivingReport_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.MaskedTextBox AgainstRefDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAgainstRefNo;
        private System.Windows.Forms.MaskedTextBox dteChallanDate;
        private AtiqsControlLibrary.SmartTextBox txtChallanNo;
        private System.Windows.Forms.DateTimePicker dteInvoiceDate;
        private AtiqsControlLibrary.SmartTextBox txtInvoiceNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSupplier;
        private AtiqsControlLibrary.SmartTextBox txtNotes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMRRLoad;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewButtonColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private AtiqsControlLibrary.SmartTextBox smartTextBox1;
        private System.Windows.Forms.Button button1;
    }
}
