namespace AH.ModuleController.UI.IPD.Forms
{
    partial class frmCollectionSendToAccounts
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAmountInCredit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtAmountInDebit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtAmountInCash = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtUserId = new AtiqsControlLibrary.SmartTextBox();
            this.btnShowAmount = new System.Windows.Forms.Button();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtTotalAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(48, 9);
            this.frmLabel.Size = new System.Drawing.Size(349, 33);
            this.frmLabel.Text = "Collection Send To Accounts";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(446, 340);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(446, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(27, 407);
            this.btnEdit.Size = new System.Drawing.Size(10, 16);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 404);
            this.btnSave.Size = new System.Drawing.Size(196, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Send To Accounts";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(37, 407);
            this.btnDelete.Size = new System.Drawing.Size(10, 16);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(17, 407);
            this.btnNew.Size = new System.Drawing.Size(10, 16);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(335, 404);
            this.btnClose.Size = new System.Drawing.Size(108, 38);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(46, 407);
            this.btnPrint.Size = new System.Drawing.Size(10, 16);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 446);
            this.groupBox1.Size = new System.Drawing.Size(446, 25);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox3.Controls.Add(this.txtTotalAmount);
            this.groupBox3.Controls.Add(this.txtAmountInCredit);
            this.groupBox3.Controls.Add(this.txtAmountInDebit);
            this.groupBox3.Controls.Add(this.txtAmountInCash);
            this.groupBox3.Controls.Add(this.smartLabel7);
            this.groupBox3.Controls.Add(this.smartLabel6);
            this.groupBox3.Controls.Add(this.smartLabel3);
            this.groupBox3.Controls.Add(this.smartLabel2);
            this.groupBox3.Controls.Add(this.txtRemarks);
            this.groupBox3.Controls.Add(this.smartLabel5);
            this.groupBox3.Location = new System.Drawing.Point(3, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 226);
            this.groupBox3.TabIndex = 239;
            this.groupBox3.TabStop = false;
            // 
            // txtAmountInCredit
            // 
            this.txtAmountInCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountInCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountInCredit.Location = new System.Drawing.Point(188, 91);
            this.txtAmountInCredit.Name = "txtAmountInCredit";
            this.txtAmountInCredit.ReadOnly = true;
            this.txtAmountInCredit.Size = new System.Drawing.Size(209, 24);
            this.txtAmountInCredit.TabIndex = 260;
            // 
            // txtAmountInDebit
            // 
            this.txtAmountInDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountInDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountInDebit.Location = new System.Drawing.Point(188, 56);
            this.txtAmountInDebit.Name = "txtAmountInDebit";
            this.txtAmountInDebit.ReadOnly = true;
            this.txtAmountInDebit.Size = new System.Drawing.Size(209, 24);
            this.txtAmountInDebit.TabIndex = 259;
            // 
            // txtAmountInCash
            // 
            this.txtAmountInCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountInCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountInCash.Location = new System.Drawing.Point(188, 18);
            this.txtAmountInCash.Name = "txtAmountInCash";
            this.txtAmountInCash.ReadOnly = true;
            this.txtAmountInCash.Size = new System.Drawing.Size(209, 24);
            this.txtAmountInCash.TabIndex = 258;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(10, 22);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(136, 13);
            this.smartLabel7.TabIndex = 253;
            this.smartLabel7.Text = "Total Amount in Cash :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(10, 56);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(168, 13);
            this.smartLabel6.TabIndex = 251;
            this.smartLabel6.Text = "Total Amount in Debit Card :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(10, 91);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(171, 13);
            this.smartLabel3.TabIndex = 249;
            this.smartLabel3.Text = "Total Amount in Credit Card :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(10, 167);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(64, 13);
            this.smartLabel2.TabIndex = 248;
            this.smartLabel2.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(188, 161);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(211, 39);
            this.txtRemarks.TabIndex = 3;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(10, 126);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(174, 13);
            this.smartLabel5.TabIndex = 243;
            this.smartLabel5.Text = "Total Collection To Transfer :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.txtUserId);
            this.groupBox2.Controls.Add(this.btnShowAmount);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Location = new System.Drawing.Point(4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 104);
            this.groupBox2.TabIndex = 240;
            this.groupBox2.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(388, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(41, 26);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2015, 5, 9, 14, 10, 6, 0);
            this.dtpDate.Visible = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(385, 22);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(42, 13);
            this.smartLabel4.TabIndex = 238;
            this.smartLabel4.Text = "Date :";
            this.smartLabel4.Visible = false;
            // 
            // txtUserId
            // 
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(99, 11);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(225, 42);
            this.txtUserId.TabIndex = 0;
            // 
            // btnShowAmount
            // 
            this.btnShowAmount.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAmount.ForeColor = System.Drawing.Color.White;
            this.btnShowAmount.Location = new System.Drawing.Point(159, 59);
            this.btnShowAmount.Name = "btnShowAmount";
            this.btnShowAmount.Size = new System.Drawing.Size(108, 32);
            this.btnShowAmount.TabIndex = 2;
            this.btnShowAmount.Text = "Show";
            this.btnShowAmount.UseVisualStyleBackColor = false;
            this.btnShowAmount.Click += new System.EventHandler(this.btnShowAmount_Click);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(35, 22);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(58, 13);
            this.smartLabel1.TabIndex = 3;
            this.smartLabel1.Text = "User ID :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(188, 126);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(209, 24);
            this.txtTotalAmount.TabIndex = 261;
            // 
            // frmCollectionSendToAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 471);
            this.isEnterTabAllow = true;
            this.Name = "frmCollectionSendToAccounts";
            this.Load += new System.EventHandler(this.frmCollectionSendToAccounts_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtUserId;
        private System.Windows.Forms.Button btnShowAmount;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartNumericTextBox txtAmountInCash;
        private AtiqsControlLibrary.SmartNumericTextBox txtAmountInCredit;
        private AtiqsControlLibrary.SmartNumericTextBox txtAmountInDebit;
        private AtiqsControlLibrary.SmartNumericTextBox txtTotalAmount;
    }
}