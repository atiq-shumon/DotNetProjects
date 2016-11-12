namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmBankReconcilation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankReconcilation));
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.dteFromDate = new System.Windows.Forms.DateTimePicker();
            this.dteToDate = new System.Windows.Forms.DateTimePicker();
            this.DG = new System.Windows.Forms.DataGridView();
            this.cboLedgerName = new System.Windows.Forms.ComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.uctxtDebitTotal = new AtiqsControlLibrary.SmartLabel();
            this.uctxtCreditTotal = new AtiqsControlLibrary.SmartLabel();
            this.uctxtNotBankDebit = new AtiqsControlLibrary.SmartLabel();
            this.uctxtNotBankCredit = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblBankCharge = new System.Windows.Forms.Label();
            this.chkPosted = new System.Windows.Forms.CheckBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(465, 9);
            this.frmLabel.Size = new System.Drawing.Size(237, 33);
            this.frmLabel.Text = "Bank Reconcilation";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chkPosted);
            this.pnlMain.Controls.Add(this.lblBankCharge);
            this.pnlMain.Controls.Add(this.groupBox5);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.uctxtNotBankCredit);
            this.pnlMain.Controls.Add(this.uctxtNotBankDebit);
            this.pnlMain.Controls.Add(this.uctxtCreditTotal);
            this.pnlMain.Controls.Add(this.uctxtDebitTotal);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboLedgerName);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Controls.Add(this.dteToDate);
            this.pnlMain.Controls.Add(this.dteFromDate);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(1212, 820);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1213, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(286, 738);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(989, 736);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(399, 738);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(278, 738);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1099, 736);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(789, 735);
            this.btnPrint.Text = "View";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 779);
            this.groupBox1.Size = new System.Drawing.Size(1213, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(345, 162);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(109, 16);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Ledger Name:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(361, 197);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(93, 16);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "From  Date:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(386, 231);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(68, 16);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "To Date:";
            // 
            // dteFromDate
            // 
            this.dteFromDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFromDate.Location = new System.Drawing.Point(465, 195);
            this.dteFromDate.Name = "dteFromDate";
            this.dteFromDate.Size = new System.Drawing.Size(200, 22);
            this.dteFromDate.TabIndex = 4;
            this.dteFromDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteFromDate_KeyPress);
            // 
            // dteToDate
            // 
            this.dteToDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteToDate.Location = new System.Drawing.Point(465, 228);
            this.dteToDate.Name = "dteToDate";
            this.dteToDate.Size = new System.Drawing.Size(200, 22);
            this.dteToDate.TabIndex = 5;
            this.dteToDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteToDate_KeyPress);
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(6, 262);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(1196, 458);
            this.DG.TabIndex = 6;
            this.DG.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellEndEdit);
            // 
            // cboLedgerName
            // 
            this.cboLedgerName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLedgerName.FormattingEnabled = true;
            this.cboLedgerName.Location = new System.Drawing.Point(465, 161);
            this.cboLedgerName.Name = "cboLedgerName";
            this.cboLedgerName.Size = new System.Drawing.Size(443, 24);
            this.cboLedgerName.TabIndex = 7;
            this.cboLedgerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboLedgerName_KeyPress);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.Color.Blue;
            this.smartLabel4.Location = new System.Drawing.Point(315, 771);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(228, 16);
            this.smartLabel4.TabIndex = 8;
            this.smartLabel4.Text = "Amount Not Reflected in Bank:";
            // 
            // uctxtDebitTotal
            // 
            this.uctxtDebitTotal.AutoSize = true;
            this.uctxtDebitTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.uctxtDebitTotal.ForeColor = System.Drawing.Color.Fuchsia;
            this.uctxtDebitTotal.Location = new System.Drawing.Point(767, 730);
            this.uctxtDebitTotal.Name = "uctxtDebitTotal";
            this.uctxtDebitTotal.Size = new System.Drawing.Size(14, 13);
            this.uctxtDebitTotal.TabIndex = 9;
            this.uctxtDebitTotal.Text = "0";
            // 
            // uctxtCreditTotal
            // 
            this.uctxtCreditTotal.AutoSize = true;
            this.uctxtCreditTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.uctxtCreditTotal.ForeColor = System.Drawing.Color.Fuchsia;
            this.uctxtCreditTotal.Location = new System.Drawing.Point(907, 730);
            this.uctxtCreditTotal.Name = "uctxtCreditTotal";
            this.uctxtCreditTotal.Size = new System.Drawing.Size(14, 13);
            this.uctxtCreditTotal.TabIndex = 10;
            this.uctxtCreditTotal.Text = "0";
            // 
            // uctxtNotBankDebit
            // 
            this.uctxtNotBankDebit.AutoSize = true;
            this.uctxtNotBankDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.uctxtNotBankDebit.Location = new System.Drawing.Point(767, 772);
            this.uctxtNotBankDebit.Name = "uctxtNotBankDebit";
            this.uctxtNotBankDebit.Size = new System.Drawing.Size(14, 13);
            this.uctxtNotBankDebit.TabIndex = 11;
            this.uctxtNotBankDebit.Text = "0";
            // 
            // uctxtNotBankCredit
            // 
            this.uctxtNotBankCredit.AutoSize = true;
            this.uctxtNotBankCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.uctxtNotBankCredit.Location = new System.Drawing.Point(907, 772);
            this.uctxtNotBankCredit.Name = "uctxtNotBankCredit";
            this.uctxtNotBankCredit.Size = new System.Drawing.Size(14, 13);
            this.uctxtNotBankCredit.TabIndex = 12;
            this.uctxtNotBankCredit.Text = "0";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.ForeColor = System.Drawing.Color.Blue;
            this.smartLabel5.Location = new System.Drawing.Point(302, 730);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(241, 16);
            this.smartLabel5.TabIndex = 15;
            this.smartLabel5.Text = "Balance as per Company Books:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(5, 748);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1197, 8);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(0, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 8);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(0, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(907, 8);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(5, 798);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1197, 8);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(900, 736);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 38);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblBankCharge
            // 
            this.lblBankCharge.AutoSize = true;
            this.lblBankCharge.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankCharge.ForeColor = System.Drawing.Color.Blue;
            this.lblBankCharge.Location = new System.Drawing.Point(1134, 727);
            this.lblBankCharge.Name = "lblBankCharge";
            this.lblBankCharge.Size = new System.Drawing.Size(15, 13);
            this.lblBankCharge.TabIndex = 19;
            this.lblBankCharge.Text = "0";
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPosted.ForeColor = System.Drawing.Color.Blue;
            this.chkPosted.Location = new System.Drawing.Point(1127, 234);
            this.chkPosted.Name = "chkPosted";
            this.chkPosted.Size = new System.Drawing.Size(59, 20);
            this.chkPosted.TabIndex = 20;
            this.chkPosted.Text = "Post";
            this.chkPosted.UseVisualStyleBackColor = true;
            // 
            // frmBankReconcilation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1213, 804);
            this.Controls.Add(this.btnRefresh);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmBankReconcilation";
            this.Load += new System.EventHandler(this.frmBankReconcilation_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DateTimePicker dteToDate;
        private System.Windows.Forms.DateTimePicker dteFromDate;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.ComboBox cboLedgerName;
        private AtiqsControlLibrary.SmartLabel uctxtNotBankCredit;
        private AtiqsControlLibrary.SmartLabel uctxtNotBankDebit;
        private AtiqsControlLibrary.SmartLabel uctxtCreditTotal;
        private AtiqsControlLibrary.SmartLabel uctxtDebitTotal;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblBankCharge;
        private System.Windows.Forms.CheckBox chkPosted;
    }
}
