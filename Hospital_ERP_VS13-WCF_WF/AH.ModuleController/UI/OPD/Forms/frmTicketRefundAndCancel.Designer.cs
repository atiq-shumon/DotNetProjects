namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmTicketRefundAndCancel
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
            this.txtTicketNo = new AtiqsControlLibrary.SmartTextBox();
            this.lblTktNo = new AtiqsControlLibrary.SmartLabel();
            this.btnShowTicketStatus = new System.Windows.Forms.Button();
            this.txtTicketStatus = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTktFee = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtPaidInCash = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.chkAccountFlag = new AtiqsControlLibrary.SmartCheckBox();
            this.txtHcn = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtTktCatgry = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtRefundedTicketNo = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(47, 9);
            this.frmLabel.Size = new System.Drawing.Size(361, 33);
            this.frmLabel.Text = "Ticket Refund or Cancellation";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.MintCream;
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnRefund);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(464, 360);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(464, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 427);
            this.btnEdit.Size = new System.Drawing.Size(10, 10);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(67, 428);
            this.btnSave.Size = new System.Drawing.Size(10, 10);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(22, 428);
            this.btnDelete.Size = new System.Drawing.Size(10, 10);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(52, 428);
            this.btnNew.Size = new System.Drawing.Size(10, 10);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(344, 422);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(37, 428);
            this.btnPrint.Size = new System.Drawing.Size(10, 10);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 462);
            this.groupBox1.Size = new System.Drawing.Size(464, 25);
            // 
            // txtTicketNo
            // 
            this.txtTicketNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTicketNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketNo.Location = new System.Drawing.Point(125, 27);
            this.txtTicketNo.MaxLength = 11;
            this.txtTicketNo.Name = "txtTicketNo";
            this.txtTicketNo.Size = new System.Drawing.Size(228, 24);
            this.txtTicketNo.TabIndex = 1;
            this.txtTicketNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTicketNo_KeyUp);
            // 
            // lblTktNo
            // 
            this.lblTktNo.AutoSize = true;
            this.lblTktNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTktNo.Location = new System.Drawing.Point(14, 32);
            this.lblTktNo.Name = "lblTktNo";
            this.lblTktNo.Size = new System.Drawing.Size(71, 13);
            this.lblTktNo.TabIndex = 5;
            this.lblTktNo.Text = "Ticket No :";
            // 
            // btnShowTicketStatus
            // 
            this.btnShowTicketStatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowTicketStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTicketStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTicketStatus.ForeColor = System.Drawing.Color.White;
            this.btnShowTicketStatus.Location = new System.Drawing.Point(359, 15);
            this.btnShowTicketStatus.Name = "btnShowTicketStatus";
            this.btnShowTicketStatus.Size = new System.Drawing.Size(90, 47);
            this.btnShowTicketStatus.TabIndex = 2;
            this.btnShowTicketStatus.Text = "Find";
            this.btnShowTicketStatus.UseVisualStyleBackColor = false;
            this.btnShowTicketStatus.Click += new System.EventHandler(this.btnShowTicketStatus_Click);
            // 
            // txtTicketStatus
            // 
            this.txtTicketStatus.BackColor = System.Drawing.Color.Linen;
            this.txtTicketStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTicketStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTicketStatus.Location = new System.Drawing.Point(125, 55);
            this.txtTicketStatus.Name = "txtTicketStatus";
            this.txtTicketStatus.ReadOnly = true;
            this.txtTicketStatus.Size = new System.Drawing.Size(228, 24);
            this.txtTicketStatus.TabIndex = 238;
            this.txtTicketStatus.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(14, 130);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(76, 13);
            this.smartLabel1.TabIndex = 245;
            this.smartLabel1.Text = "Ticket Fee :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(14, 60);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(91, 13);
            this.smartLabel2.TabIndex = 247;
            this.smartLabel2.Text = "Ticket Status :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(17, 24);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(49, 13);
            this.smartLabel3.TabIndex = 249;
            this.smartLabel3.Text = "HCN   :";
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.ForeColor = System.Drawing.Color.White;
            this.btnRefund.Location = new System.Drawing.Point(118, 318);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(104, 33);
            this.btnRefund.TabIndex = 250;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(261, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 33);
            this.btnCancel.TabIndex = 251;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.btnShowTicketStatus);
            this.groupBox2.Controls.Add(this.lblTktNo);
            this.groupBox2.Controls.Add(this.txtTicketNo);
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 72);
            this.groupBox2.TabIndex = 252;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox3.Controls.Add(this.txtTktFee);
            this.groupBox3.Controls.Add(this.txtPaidInCash);
            this.groupBox3.Controls.Add(this.smartLabel5);
            this.groupBox3.Controls.Add(this.chkAccountFlag);
            this.groupBox3.Controls.Add(this.txtHcn);
            this.groupBox3.Controls.Add(this.txtTktCatgry);
            this.groupBox3.Controls.Add(this.smartLabel4);
            this.groupBox3.Controls.Add(this.smartLabel2);
            this.groupBox3.Controls.Add(this.smartLabel1);
            this.groupBox3.Controls.Add(this.txtTicketStatus);
            this.groupBox3.Controls.Add(this.smartLabel3);
            this.groupBox3.Location = new System.Drawing.Point(2, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 231);
            this.groupBox3.TabIndex = 253;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ticket\'s Details ";
            // 
            // txtTktFee
            // 
            this.txtTktFee.BackColor = System.Drawing.Color.Linen;
            this.txtTktFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTktFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTktFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTktFee.Location = new System.Drawing.Point(125, 124);
            this.txtTktFee.Name = "txtTktFee";
            this.txtTktFee.ReadOnly = true;
            this.txtTktFee.Size = new System.Drawing.Size(228, 24);
            this.txtTktFee.TabIndex = 257;
            this.txtTktFee.TabStop = false;
            // 
            // txtPaidInCash
            // 
            this.txtPaidInCash.BackColor = System.Drawing.Color.Linen;
            this.txtPaidInCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaidInCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidInCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPaidInCash.Location = new System.Drawing.Point(125, 160);
            this.txtPaidInCash.Name = "txtPaidInCash";
            this.txtPaidInCash.ReadOnly = true;
            this.txtPaidInCash.Size = new System.Drawing.Size(228, 24);
            this.txtPaidInCash.TabIndex = 256;
            this.txtPaidInCash.TabStop = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(14, 165);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(86, 13);
            this.smartLabel5.TabIndex = 255;
            this.smartLabel5.Text = "Paid in Cash :";
            // 
            // chkAccountFlag
            // 
            this.chkAccountFlag.AutoSize = true;
            this.chkAccountFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAccountFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAccountFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccountFlag.ForeColor = System.Drawing.Color.Black;
            this.chkAccountFlag.Location = new System.Drawing.Point(125, 197);
            this.chkAccountFlag.Name = "chkAccountFlag";
            this.chkAccountFlag.Size = new System.Drawing.Size(114, 22);
            this.chkAccountFlag.TabIndex = 254;
            this.chkAccountFlag.Text = "Account Flag ";
            this.chkAccountFlag.UseVisualStyleBackColor = true;
            // 
            // txtHcn
            // 
            this.txtHcn.BackColor = System.Drawing.Color.Linen;
            this.txtHcn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHcn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHcn.Location = new System.Drawing.Point(125, 19);
            this.txtHcn.Name = "txtHcn";
            this.txtHcn.ReadOnly = true;
            this.txtHcn.Size = new System.Drawing.Size(228, 24);
            this.txtHcn.TabIndex = 253;
            this.txtHcn.TabStop = false;
            // 
            // txtTktCatgry
            // 
            this.txtTktCatgry.BackColor = System.Drawing.Color.Linen;
            this.txtTktCatgry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTktCatgry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTktCatgry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTktCatgry.Location = new System.Drawing.Point(125, 90);
            this.txtTktCatgry.Name = "txtTktCatgry";
            this.txtTktCatgry.ReadOnly = true;
            this.txtTktCatgry.Size = new System.Drawing.Size(228, 24);
            this.txtTktCatgry.TabIndex = 251;
            this.txtTktCatgry.TabStop = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(14, 95);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(105, 13);
            this.smartLabel4.TabIndex = 250;
            this.smartLabel4.Text = "Ticket Category :";
            // 
            // txtRefundedTicketNo
            // 
            this.txtRefundedTicketNo.Location = new System.Drawing.Point(86, 424);
            this.txtRefundedTicketNo.Name = "txtRefundedTicketNo";
            this.txtRefundedTicketNo.Size = new System.Drawing.Size(10, 20);
            this.txtRefundedTicketNo.TabIndex = 255;
            this.txtRefundedTicketNo.Visible = false;
            // 
            // frmTicketRefundAndCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 487);
            this.Controls.Add(this.txtRefundedTicketNo);
            this.isEnterTabAllow = true;
            this.Name = "frmTicketRefundAndCancel";
            this.Load += new System.EventHandler(this.frmTicketRefundAndCancel_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtRefundedTicketNo, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtTicketNo;
        private AtiqsControlLibrary.SmartLabel lblTktNo;
        private System.Windows.Forms.Button btnShowTicketStatus;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTicketStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefund;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTktCatgry;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHcn;
        private AtiqsControlLibrary.SmartCheckBox chkAccountFlag;
        private System.Windows.Forms.TextBox txtRefundedTicketNo;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPaidInCash;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTktFee;
    }
}