namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmFoodInventoriesVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtFoodCode = new AtiqsControlLibrary.SmartTextBox();
            this.txtFoodName = new AtiqsControlLibrary.SmartTextBox();
            this.txtQty = new AtiqsControlLibrary.SmartTextBox();
            this.DG = new System.Windows.Forms.DataGridView();
            this.DGLedger = new AtiqsControlLibrary.SmartDataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDown = new System.Windows.Forms.Button();
            this.dteDate = new System.Windows.Forms.DateTimePicker();
            this.txtRefNo = new AtiqsControlLibrary.SmartTextBox();
            this.lblNetQty = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lblTotal = new AtiqsControlLibrary.SmartLabel();
            this.lblNeTotal = new AtiqsControlLibrary.SmartLabel();
            this.tvNode = new AtiqsControlLibrary.SmartTreeView();
            this.chkPost = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtIssueRefNo = new AtiqsControlLibrary.SmartTextBox();
            this.lblIssueRefNo = new AtiqsControlLibrary.SmartLabel();
            this.cbofoodCat = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(511, 9);
            this.frmLabel.TabIndex = 8;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cbofoodCat);
            this.pnlMain.Controls.Add(this.lblIssueRefNo);
            this.pnlMain.Controls.Add(this.txtIssueRefNo);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.chkPost);
            this.pnlMain.Controls.Add(this.tvNode);
            this.pnlMain.Controls.Add(this.lblNeTotal);
            this.pnlMain.Controls.Add(this.lblTotal);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.lblNetQty);
            this.pnlMain.Controls.Add(this.txtRefNo);
            this.pnlMain.Controls.Add(this.dteDate);
            this.pnlMain.Controls.Add(this.btnDown);
            this.pnlMain.Controls.Add(this.DGLedger);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Controls.Add(this.txtQty);
            this.pnlMain.Controls.Add(this.txtFoodName);
            this.pnlMain.Controls.Add(this.txtFoodCode);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(1356, 747);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1357, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(1135, 664);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1022, 664);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(438, 661);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(909, 664);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1247, 664);
            this.btnClose.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(549, 663);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 706);
            this.groupBox1.Size = new System.Drawing.Size(1357, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(304, 162);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(56, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Ref No:";
            this.smartLabel1.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(546, 195);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(43, 14);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Date:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(475, 223);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(114, 14);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "Category Name:";
            // 
            // txtFoodCode
            // 
            this.txtFoodCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodCode.Enabled = false;
            this.txtFoodCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodCode.Location = new System.Drawing.Point(287, 328);
            this.txtFoodCode.Name = "txtFoodCode";
            this.txtFoodCode.Size = new System.Drawing.Size(185, 24);
            this.txtFoodCode.TabIndex = 3;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodName.Enabled = false;
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(480, 328);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(601, 24);
            this.txtFoodName.TabIndex = 2;
            this.txtFoodName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFoodName_KeyDown);
            this.txtFoodName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodName_KeyPress);
            this.txtFoodName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFoodName_KeyUp);
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Enabled = false;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(1143, 328);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 24);
            this.txtQty.TabIndex = 3;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(287, 362);
            this.DG.Name = "DG";
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(1063, 344);
            this.DG.TabIndex = 6;
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            this.DG.DoubleClick += new System.EventHandler(this.DG_DoubleClick);
            // 
            // DGLedger
            // 
            this.DGLedger.AllowUserToAddRows = false;
            this.DGLedger.AllowUserToDeleteRows = false;
            this.DGLedger.AllowUserToOrderColumns = true;
            this.DGLedger.AllowUserToResizeColumns = false;
            this.DGLedger.AllowUserToResizeRows = false;
            this.DGLedger.BackgroundColor = System.Drawing.Color.White;
            this.DGLedger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DGLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGLedger.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGLedger.Location = new System.Drawing.Point(483, 358);
            this.DGLedger.MultiSelect = false;
            this.DGLedger.Name = "DGLedger";
            this.DGLedger.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGLedger.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGLedger.Size = new System.Drawing.Size(598, 173);
            this.DGLedger.TabIndex = 144;
            this.DGLedger.Visible = false;
            this.DGLedger.DoubleClick += new System.EventHandler(this.DGLedger_DoubleClick);
            this.DGLedger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGLedger_KeyPress);
            // 
            // Column11
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column11.HeaderText = "Item Code";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 120;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Item Name";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 470;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDown.Location = new System.Drawing.Point(1273, 328);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(48, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = ">>";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // dteDate
            // 
            this.dteDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDate.Location = new System.Drawing.Point(597, 193);
            this.dteDate.Name = "dteDate";
            this.dteDate.Size = new System.Drawing.Size(284, 23);
            this.dteDate.TabIndex = 0;
            this.dteDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteDate_KeyPress);
            // 
            // txtRefNo
            // 
            this.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.Location = new System.Drawing.Point(366, 161);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(135, 24);
            this.txtRefNo.TabIndex = 148;
            this.txtRefNo.Visible = false;
            // 
            // lblNetQty
            // 
            this.lblNetQty.AutoSize = true;
            this.lblNetQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNetQty.Location = new System.Drawing.Point(1102, 714);
            this.lblNetQty.Name = "lblNetQty";
            this.lblNetQty.Size = new System.Drawing.Size(14, 13);
            this.lblNetQty.TabIndex = 149;
            this.lblNetQty.Text = "0";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(977, 714);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(63, 13);
            this.smartLabel4.TabIndex = 150;
            this.smartLabel4.Text = "Total Qty:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(1298, 714);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 13);
            this.lblTotal.TabIndex = 151;
            this.lblTotal.Text = "0";
            // 
            // lblNeTotal
            // 
            this.lblNeTotal.AutoSize = true;
            this.lblNeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNeTotal.Location = new System.Drawing.Point(1166, 714);
            this.lblNeTotal.Name = "lblNeTotal";
            this.lblNeTotal.Size = new System.Drawing.Size(60, 13);
            this.lblNeTotal.TabIndex = 152;
            this.lblNeTotal.Text = "NetTotal:";
            // 
            // tvNode
            // 
            this.tvNode.BackColor = System.Drawing.Color.LightYellow;
            this.tvNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvNode.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvNode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNode.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tvNode.LineColor = System.Drawing.Color.Crimson;
            this.tvNode.Location = new System.Drawing.Point(3, 200);
            this.tvNode.Name = "tvNode";
            this.tvNode.Size = new System.Drawing.Size(278, 527);
            this.tvNode.TabIndex = 153;
            this.tvNode.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNode_AfterSelect);
            // 
            // chkPost
            // 
            this.chkPost.AutoSize = true;
            this.chkPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPost.ForeColor = System.Drawing.Color.Black;
            this.chkPost.Location = new System.Drawing.Point(1135, 201);
            this.chkPost.Name = "chkPost";
            this.chkPost.Size = new System.Drawing.Size(55, 22);
            this.chkPost.TabIndex = 154;
            this.chkPost.Text = "Post";
            this.chkPost.UseVisualStyleBackColor = true;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(288, 309);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(64, 13);
            this.smartLabel5.TabIndex = 156;
            this.smartLabel5.Text = "Item Code";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(478, 309);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(67, 13);
            this.smartLabel6.TabIndex = 157;
            this.smartLabel6.Text = "Item Name";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(1151, 309);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(60, 13);
            this.smartLabel8.TabIndex = 159;
            this.smartLabel8.Text = "Tran. Qty";
            // 
            // txtIssueRefNo
            // 
            this.txtIssueRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssueRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueRefNo.Location = new System.Drawing.Point(597, 250);
            this.txtIssueRefNo.Name = "txtIssueRefNo";
            this.txtIssueRefNo.Size = new System.Drawing.Size(282, 24);
            this.txtIssueRefNo.TabIndex = 160;
            this.txtIssueRefNo.Visible = false;
            this.txtIssueRefNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIssueRefNo_KeyPress);
            // 
            // lblIssueRefNo
            // 
            this.lblIssueRefNo.AutoSize = true;
            this.lblIssueRefNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblIssueRefNo.Location = new System.Drawing.Point(489, 253);
            this.lblIssueRefNo.Name = "lblIssueRefNo";
            this.lblIssueRefNo.Size = new System.Drawing.Size(100, 14);
            this.lblIssueRefNo.TabIndex = 161;
            this.lblIssueRefNo.Text = "Issue Ref. No:";
            this.lblIssueRefNo.Visible = false;
            // 
            // cbofoodCat
            // 
            this.cbofoodCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofoodCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofoodCat.ForeColor = System.Drawing.Color.Blue;
            this.cbofoodCat.FormattingEnabled = true;
            this.cbofoodCat.Location = new System.Drawing.Point(597, 219);
            this.cbofoodCat.Name = "cbofoodCat";
            this.cbofoodCat.Size = new System.Drawing.Size(284, 26);
            this.cbofoodCat.TabIndex = 162;
            this.cbofoodCat.SelectedIndexChanged += new System.EventHandler(this.cbofoodCat_SelectedIndexChanged);
            this.cbofoodCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbofoodCat_KeyPress);
            // 
            // frmFoodInventoriesVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1357, 731);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmFoodInventoriesVoucher";
            this.Load += new System.EventHandler(this.frmFoodInventoriesVoucher_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGLedger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private AtiqsControlLibrary.SmartTextBox txtQty;
        private AtiqsControlLibrary.SmartTextBox txtFoodName;
        private AtiqsControlLibrary.SmartTextBox txtFoodCode;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartDataGridView DGLedger;
        private System.Windows.Forms.Button btnDown;
        private AtiqsControlLibrary.SmartTextBox txtRefNo;
        private System.Windows.Forms.DateTimePicker dteDate;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel lblNetQty;
        private AtiqsControlLibrary.SmartLabel lblNeTotal;
        private AtiqsControlLibrary.SmartLabel lblTotal;
        private AtiqsControlLibrary.SmartTreeView tvNode;
        private AtiqsControlLibrary.SmartCheckBox chkPost;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel lblIssueRefNo;
        private AtiqsControlLibrary.SmartTextBox txtIssueRefNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private AtiqsControlLibrary.SmartComboBox cbofoodCat;
    }
}
