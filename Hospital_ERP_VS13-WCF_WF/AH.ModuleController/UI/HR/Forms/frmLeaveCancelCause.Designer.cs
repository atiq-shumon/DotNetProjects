namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmLeaveCancelCause
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
            this.txtSerial = new AtiqsControlLibrary.SmartTextBox();
            this.txtCauseID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtCauseTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtCauseTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvLeaveCancelCause = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(326, 8);
            this.frmLabel.Size = new System.Drawing.Size(247, 33);
            this.frmLabel.Text = "Leave Cancel Cause";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.lvLeaveCancelCause);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtCauseTitleBeng);
            this.pnlMain.Controls.Add(this.txtCauseTitle);
            this.pnlMain.Controls.Add(this.txtCauseID);
            this.pnlMain.Controls.Add(this.txtSerial);
            this.pnlMain.Location = new System.Drawing.Point(0, 49);
            this.pnlMain.Size = new System.Drawing.Size(876, 516);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(876, 53);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(431, 571);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(318, 571);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(544, 571);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(205, 571);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(766, 571);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(655, 571);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 616);
            this.groupBox1.Size = new System.Drawing.Size(876, 18);
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(510, 70);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(56, 24);
            this.txtSerial.TabIndex = 0;
            this.txtSerial.Visible = false;
            // 
            // txtCauseID
            // 
            this.txtCauseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtCauseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCauseID.Location = new System.Drawing.Point(166, 9);
            this.txtCauseID.Name = "txtCauseID";
            this.txtCauseID.ReadOnly = true;
            this.txtCauseID.Size = new System.Drawing.Size(136, 24);
            this.txtCauseID.TabIndex = 1;
            this.txtCauseID.TabStop = false;
            // 
            // txtCauseTitle
            // 
            this.txtCauseTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauseTitle.Location = new System.Drawing.Point(166, 41);
            this.txtCauseTitle.Name = "txtCauseTitle";
            this.txtCauseTitle.Size = new System.Drawing.Size(255, 24);
            this.txtCauseTitle.TabIndex = 2;
            this.txtCauseTitle.TextChanged += new System.EventHandler(this.txtCauseTitle_TextChanged);
            // 
            // txtCauseTitleBeng
            // 
            this.txtCauseTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauseTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauseTitleBeng.Location = new System.Drawing.Point(166, 75);
            this.txtCauseTitleBeng.Name = "txtCauseTitleBeng";
            this.txtCauseTitleBeng.Size = new System.Drawing.Size(255, 24);
            this.txtCauseTitleBeng.TabIndex = 3;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(166, 105);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 57);
            this.txtRemarks.TabIndex = 4;
            // 
            // lvLeaveCancelCause
            // 
            this.lvLeaveCancelCause.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvLeaveCancelCause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLeaveCancelCause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvLeaveCancelCause.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLeaveCancelCause.FullRowSelect = true;
            this.lvLeaveCancelCause.GridLines = true;
            this.lvLeaveCancelCause.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLeaveCancelCause.Location = new System.Drawing.Point(-1, 194);
            this.lvLeaveCancelCause.Name = "lvLeaveCancelCause";
            this.lvLeaveCancelCause.Size = new System.Drawing.Size(876, 317);
            this.lvLeaveCancelCause.TabIndex = 5;
            this.lvLeaveCancelCause.UseCompatibleStateImageBehavior = false;
            this.lvLeaveCancelCause.View = System.Windows.Forms.View.Details;
            this.lvLeaveCancelCause.SelectedIndexChanged += new System.EventHandler(this.lvLeaveCancelCause_SelectedIndexChanged);
            this.lvLeaveCancelCause.Click += new System.EventHandler(this.lvLeaveCancelCause_Click);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(85, 15);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(67, 13);
            this.smartLabel1.TabIndex = 6;
            this.smartLabel1.Text = "Cause ID :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(73, 47);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(79, 13);
            this.smartLabel2.TabIndex = 7;
            this.smartLabel2.Text = "Cause Title :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(22, 81);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(130, 13);
            this.smartLabel3.TabIndex = 8;
            this.smartLabel3.Text = "Cause Title (Bangla) :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(519, 52);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(47, 13);
            this.smartLabel4.TabIndex = 9;
            this.smartLabel4.Text = "Serial :";
            this.smartLabel4.Visible = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(88, 120);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(64, 13);
            this.smartLabel5.TabIndex = 10;
            this.smartLabel5.Text = "Remarks :";
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(426, 41);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 193;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.ForeColor = System.Drawing.Color.Red;
            this.smartLabel6.Location = new System.Drawing.Point(426, 75);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(21, 22);
            this.smartLabel6.TabIndex = 194;
            this.smartLabel6.Text = "*";
            // 
            // frmLeaveCancelCause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(876, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmLeaveCancelCause";
            this.Load += new System.EventHandler(this.frmLeaveCancelCause_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCauseID;
        private AtiqsControlLibrary.SmartTextBox txtSerial;
        private AtiqsControlLibrary.SmartTextBox txtCauseTitle;
        private AtiqsControlLibrary.SmartTextBox txtCauseTitleBeng;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartListViewDetails lvLeaveCancelCause;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
    }
}
