namespace  AH.ModuleController.UI.IPD.Forms
{
    partial class frmAdvancePaymentHistory
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.lvAdPay = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtHcnNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.txtTotalAmount = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtRegNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(686, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(192, 10);
            this.frmLabel.Size = new System.Drawing.Size(316, 33);
            this.frmLabel.Text = "Advance Payment History";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtRegNo);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.txtTotalAmount);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtPatientName);
            this.pnlMain.Controls.Add(this.lvAdPay);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Location = new System.Drawing.Point(-1, 55);
            this.pnlMain.Size = new System.Drawing.Size(763, 468);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(762, 57);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(309, 529);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 529);
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(423, 529);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(81, 529);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(651, 529);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(537, 529);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 568);
            this.groupBox1.Size = new System.Drawing.Size(762, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(0, 15);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(101, 15);
            this.smartLabel3.TabIndex = 23;
            this.smartLabel3.Text = "Registration No :";
            // 
            // lvAdPay
            // 
            this.lvAdPay.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvAdPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAdPay.CheckBoxes = true;
            this.lvAdPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAdPay.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAdPay.FullRowSelect = true;
            this.lvAdPay.GridLines = true;
            this.lvAdPay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAdPay.Location = new System.Drawing.Point(0, 111);
            this.lvAdPay.Name = "lvAdPay";
            this.lvAdPay.Size = new System.Drawing.Size(762, 356);
            this.lvAdPay.TabIndex = 45;
            this.lvAdPay.UseCompatibleStateImageBehavior = false;
            this.lvAdPay.View = System.Windows.Forms.View.Details;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(11, 71);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(87, 15);
            this.smartLabel2.TabIndex = 121;
            this.smartLabel2.Text = "Patient Name :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(124, 68);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(546, 24);
            this.txtPatientName.TabIndex = 120;
            this.txtPatientName.TabStop = false;
            // 
            // txtHcnNo
            // 
            this.txtHcnNo.BackColor = System.Drawing.Color.Linen;
            this.txtHcnNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHcnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHcnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHcnNo.Location = new System.Drawing.Point(28, 536);
            this.txtHcnNo.Name = "txtHcnNo";
            this.txtHcnNo.ReadOnly = true;
            this.txtHcnNo.Size = new System.Drawing.Size(33, 24);
            this.txtHcnNo.TabIndex = 136;
            this.txtHcnNo.TabStop = false;
            this.txtHcnNo.Visible = false;
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(410, 13);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(86, 15);
            this.smartLabel14.TabIndex = 170;
            this.smartLabel14.Text = "Total Amount :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.Linen;
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(527, 11);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(139, 24);
            this.txtTotalAmount.TabIndex = 169;
            this.txtTotalAmount.TabStop = false;
            // 
            // txtRegNo
            // 
            this.txtRegNo.BackColor = System.Drawing.Color.Linen;
            this.txtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRegNo.Location = new System.Drawing.Point(124, 14);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.ReadOnly = true;
            this.txtRegNo.Size = new System.Drawing.Size(173, 24);
            this.txtRegNo.TabIndex = 171;
            this.txtRegNo.TabStop = false;
            // 
            // frmAdvancePaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(762, 591);
            this.Controls.Add(this.txtHcnNo);
            this.isEnterTabAllow = true;
            this.Name = "frmAdvancePaymentHistory";
            this.Load += new System.EventHandler(this.frmAdvancePayment_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtHcnNo, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartListViewDetails lvAdPay;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHcnNo;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTotalAmount;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRegNo;
    }
}
