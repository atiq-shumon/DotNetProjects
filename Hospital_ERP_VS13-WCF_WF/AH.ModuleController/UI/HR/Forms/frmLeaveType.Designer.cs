namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmLeaveType
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
            this.txtTypeID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtTypeTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtTypeTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.chkFlag = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtSerial = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lvLeaveType = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtsrlNumber = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(225, 33);
            this.frmLabel.Text = "Leave Type Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvLeaveType);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtTypeTitleBeng);
            this.pnlMain.Controls.Add(this.txtTypeTitle);
            this.pnlMain.Controls.Add(this.txtTypeID);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(876, 510);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(876, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(651, 571);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(537, 571);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 570);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(423, 571);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(765, 571);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(38, 569);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Size = new System.Drawing.Size(876, 23);
            // 
            // txtTypeID
            // 
            this.txtTypeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTypeID.Location = new System.Drawing.Point(11, 32);
            this.txtTypeID.MaxLength = 4;
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.ReadOnly = true;
            this.txtTypeID.Size = new System.Drawing.Size(82, 24);
            this.txtTypeID.TabIndex = 0;
            this.txtTypeID.TabStop = false;
            // 
            // txtTypeTitle
            // 
            this.txtTypeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeTitle.Location = new System.Drawing.Point(99, 32);
            this.txtTypeTitle.MaxLength = 50;
            this.txtTypeTitle.Name = "txtTypeTitle";
            this.txtTypeTitle.Size = new System.Drawing.Size(193, 24);
            this.txtTypeTitle.TabIndex = 1;
            this.txtTypeTitle.TextChanged += new System.EventHandler(this.txtTypeTitle_TextChanged);
            // 
            // txtTypeTitleBeng
            // 
            this.txtTypeTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeTitleBeng.Location = new System.Drawing.Point(298, 32);
            this.txtTypeTitleBeng.MaxLength = 50;
            this.txtTypeTitleBeng.Name = "txtTypeTitleBeng";
            this.txtTypeTitleBeng.Size = new System.Drawing.Size(193, 24);
            this.txtTypeTitleBeng.TabIndex = 2;
            // 
            // chkFlag
            // 
            this.chkFlag.AutoSize = true;
            this.chkFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFlag.ForeColor = System.Drawing.Color.Black;
            this.chkFlag.Location = new System.Drawing.Point(6, 583);
            this.chkFlag.Name = "chkFlag";
            this.chkFlag.Size = new System.Drawing.Size(131, 22);
            this.chkFlag.TabIndex = 3;
            this.chkFlag.Text = "Leave Type Flag";
            this.chkFlag.UseVisualStyleBackColor = true;
            this.chkFlag.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(8, 16);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(56, 13);
            this.smartLabel1.TabIndex = 5;
            this.smartLabel1.Text = "Type ID:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(96, 16);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(72, 13);
            this.smartLabel2.TabIndex = 6;
            this.smartLabel2.Text = "Type Title :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(295, 16);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(123, 13);
            this.smartLabel3.TabIndex = 7;
            this.smartLabel3.Text = "Type Title (Bangla) :";
            // 
            // txtSerial
            // 
            this.txtSerial.AutoSize = true;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSerial.Location = new System.Drawing.Point(152, 569);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(94, 13);
            this.txtSerial.TabIndex = 8;
            this.txtSerial.Text = "Serial Number :";
            this.txtSerial.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(497, 32);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(366, 24);
            this.txtRemarks.TabIndex = 3;
            this.txtRemarks.Text = "N/A";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(494, 16);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(64, 13);
            this.smartLabel5.TabIndex = 11;
            this.smartLabel5.Text = "Remarks :";
            // 
            // lvLeaveType
            // 
            this.lvLeaveType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvLeaveType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLeaveType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvLeaveType.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLeaveType.FullRowSelect = true;
            this.lvLeaveType.GridLines = true;
            this.lvLeaveType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLeaveType.Location = new System.Drawing.Point(0, 82);
            this.lvLeaveType.Name = "lvLeaveType";
            this.lvLeaveType.Size = new System.Drawing.Size(872, 423);
            this.lvLeaveType.TabIndex = 12;
            this.lvLeaveType.UseCompatibleStateImageBehavior = false;
            this.lvLeaveType.View = System.Windows.Forms.View.Details;
            this.lvLeaveType.SelectedIndexChanged += new System.EventHandler(this.lvLeaveType_SelectedIndexChanged);
            this.lvLeaveType.Click += new System.EventHandler(this.lvLeaveType_Click);
            // 
            // txtsrlNumber
            // 
            this.txtsrlNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsrlNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsrlNumber.Location = new System.Drawing.Point(155, 585);
            this.txtsrlNumber.Name = "txtsrlNumber";
            this.txtsrlNumber.Size = new System.Drawing.Size(100, 24);
            this.txtsrlNumber.TabIndex = 4;
            this.txtsrlNumber.Visible = false;
            // 
            // frmLeaveType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(876, 634);
            this.Controls.Add(this.txtsrlNumber);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.chkFlag);
            this.isEnterTabAllow = true;
            this.Name = "frmLeaveType";
            this.Load += new System.EventHandler(this.frmLeaveType_Load);
            this.Controls.SetChildIndex(this.chkFlag, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtSerial, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.txtsrlNumber, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartCheckBox chkFlag;
        private AtiqsControlLibrary.SmartTextBox txtTypeTitleBeng;
        private AtiqsControlLibrary.SmartTextBox txtTypeTitle;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTypeID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartListViewDetails lvLeaveType;
        private AtiqsControlLibrary.SmartTextBox txtsrlNumber;
    }
}
