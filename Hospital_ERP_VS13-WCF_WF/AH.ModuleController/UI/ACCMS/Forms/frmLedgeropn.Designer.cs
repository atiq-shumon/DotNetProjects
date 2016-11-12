namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmLedgeropn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedgeropn));
            this.lvwLedgerOpn = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.dteOpeningDate = new System.Windows.Forms.DateTimePicker();
            this.cboCompany = new AtiqsControlLibrary.SmartComboBox();
            this.txtOpnAmount = new AtiqsControlLibrary.SmartTextBox();
            this.txtDrCr = new AtiqsControlLibrary.SmartTextBox();
            this.txtopnID = new AtiqsControlLibrary.SmartTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLedger = new AtiqsControlLibrary.SmartTextBox();
            this.lstLedger = new System.Windows.Forms.ListBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(203, 33);
            this.frmLabel.TabIndex = 10;
            this.frmLabel.Text = "Ledger Opening";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.lstLedger);
            this.pnlMain.Controls.Add(this.txtLedger);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtopnID);
            this.pnlMain.Controls.Add(this.txtDrCr);
            this.pnlMain.Controls.Add(this.txtOpnAmount);
            this.pnlMain.Controls.Add(this.cboCompany);
            this.pnlMain.Controls.Add(this.dteOpeningDate);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.lvwLedgerOpn);
            this.pnlMain.Location = new System.Drawing.Point(0, 63);
            this.pnlMain.Size = new System.Drawing.Size(859, 503);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(859, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(401, 577);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 577);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(515, 577);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(173, 577);
            this.btnNew.TabIndex = 9;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(743, 577);
            this.btnClose.TabIndex = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(629, 577);
            this.btnPrint.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 622);
            this.groupBox1.Size = new System.Drawing.Size(859, 25);
            // 
            // lvwLedgerOpn
            // 
            this.lvwLedgerOpn.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwLedgerOpn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwLedgerOpn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwLedgerOpn.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLedgerOpn.FullRowSelect = true;
            this.lvwLedgerOpn.GridLines = true;
            this.lvwLedgerOpn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwLedgerOpn.Location = new System.Drawing.Point(7, 223);
            this.lvwLedgerOpn.Name = "lvwLedgerOpn";
            this.lvwLedgerOpn.Size = new System.Drawing.Size(822, 257);
            this.lvwLedgerOpn.TabIndex = 16;
            this.lvwLedgerOpn.UseCompatibleStateImageBehavior = false;
            this.lvwLedgerOpn.View = System.Windows.Forms.View.Details;
            this.lvwLedgerOpn.SelectedIndexChanged += new System.EventHandler(this.lvwLedgerOpn_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(198, 62);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(109, 16);
            this.smartLabel1.TabIndex = 14;
            this.smartLabel1.Text = "Ledger Name:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(196, 96);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(111, 16);
            this.smartLabel2.TabIndex = 17;
            this.smartLabel2.Text = "Opening Date:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(197, 130);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(110, 16);
            this.smartLabel3.TabIndex = 18;
            this.smartLabel3.Text = "Branch Name:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(173, 163);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(134, 16);
            this.smartLabel4.TabIndex = 19;
            this.smartLabel4.Text = "Opening Amount:";
            // 
            // dteOpeningDate
            // 
            this.dteOpeningDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteOpeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteOpeningDate.Location = new System.Drawing.Point(314, 92);
            this.dteOpeningDate.Name = "dteOpeningDate";
            this.dteOpeningDate.Size = new System.Drawing.Size(278, 26);
            this.dteOpeningDate.TabIndex = 1;
            this.dteOpeningDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteOpeningDate_KeyPress);
            // 
            // cboCompany
            // 
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompany.ForeColor = System.Drawing.Color.Blue;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(314, 125);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(278, 26);
            this.cboCompany.TabIndex = 2;
            this.cboCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCompany_KeyPress);
            // 
            // txtOpnAmount
            // 
            this.txtOpnAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpnAmount.Location = new System.Drawing.Point(314, 158);
            this.txtOpnAmount.Name = "txtOpnAmount";
            this.txtOpnAmount.Size = new System.Drawing.Size(278, 24);
            this.txtOpnAmount.TabIndex = 3;
            this.txtOpnAmount.Text = "0";
            this.txtOpnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpnAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpnAmount_KeyPress);
            // 
            // txtDrCr
            // 
            this.txtDrCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrCr.Location = new System.Drawing.Point(595, 158);
            this.txtDrCr.MaxLength = 2;
            this.txtDrCr.Name = "txtDrCr";
            this.txtDrCr.ReadOnly = true;
            this.txtDrCr.Size = new System.Drawing.Size(30, 24);
            this.txtDrCr.TabIndex = 4;
            this.txtDrCr.Text = "Dr";
            this.txtDrCr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrCr_KeyDown);
            // 
            // txtopnID
            // 
            this.txtopnID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtopnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopnID.Location = new System.Drawing.Point(313, 15);
            this.txtopnID.Name = "txtopnID";
            this.txtopnID.Size = new System.Drawing.Size(278, 24);
            this.txtopnID.TabIndex = 20;
            this.txtopnID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtopnID.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(603, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 26);
            this.btnSearch.TabIndex = 137;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            // 
            // txtLedger
            // 
            this.txtLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLedger.Location = new System.Drawing.Point(314, 63);
            this.txtLedger.Name = "txtLedger";
            this.txtLedger.Size = new System.Drawing.Size(276, 24);
            this.txtLedger.TabIndex = 0;
            this.txtLedger.TextChanged += new System.EventHandler(this.txtLedger_TextChanged);
            this.txtLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedger_KeyDown);
            this.txtLedger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLedger_KeyPress);
            // 
            // lstLedger
            // 
            this.lstLedger.BackColor = System.Drawing.SystemColors.Info;
            this.lstLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLedger.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLedger.FormattingEnabled = true;
            this.lstLedger.ItemHeight = 16;
            this.lstLedger.Location = new System.Drawing.Point(328, 90);
            this.lstLedger.Name = "lstLedger";
            this.lstLedger.Size = new System.Drawing.Size(459, 178);
            this.lstLedger.TabIndex = 140;
            this.lstLedger.Visible = false;
            this.lstLedger.DoubleClick += new System.EventHandler(this.lstLedger_DoubleClick);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.smartLabel5.Location = new System.Drawing.Point(314, 44);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(165, 13);
            this.smartLabel5.TabIndex = 141;
            this.smartLabel5.Text = "Ctrl + Z for Another Window";
            this.smartLabel5.Visible = false;
            // 
            // frmLedgeropn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(859, 647);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmLedgeropn";
            this.Load += new System.EventHandler(this.frmLedgeropn_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtOpnAmount;
        private AtiqsControlLibrary.SmartComboBox cboCompany;
        private System.Windows.Forms.DateTimePicker dteOpeningDate;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwLedgerOpn;
        private AtiqsControlLibrary.SmartTextBox txtDrCr;
        private AtiqsControlLibrary.SmartTextBox txtopnID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstLedger;
        private AtiqsControlLibrary.SmartTextBox txtLedger;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
    }
}
