namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmBankSetup
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
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtBankTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.txtBankTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtBankID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtSerial = new AtiqsControlLibrary.SmartTextBox();
            this.lvBankInfo = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(341, 9);
            this.frmLabel.Size = new System.Drawing.Size(149, 33);
            this.frmLabel.Text = "Bank Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvBankInfo);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtSerial);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtBankID);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.txtBankTitle);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtBankTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(633, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(0, 555);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(407, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(111, 555);
            this.btnPrint.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.ForeColor = System.Drawing.Color.Red;
            this.smartLabel6.Location = new System.Drawing.Point(574, 230);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(21, 22);
            this.smartLabel6.TabIndex = 204;
            this.smartLabel6.Text = "*";
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(574, 193);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 203;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(99, 276);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(64, 13);
            this.smartLabel5.TabIndex = 202;
            this.smartLabel5.Text = "Remarks :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(39, 234);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(124, 13);
            this.smartLabel3.TabIndex = 201;
            this.smartLabel3.Text = "Bank Title (Bangla) :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(90, 198);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(73, 13);
            this.smartLabel2.TabIndex = 200;
            this.smartLabel2.Text = "Bank Title :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(102, 166);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(61, 13);
            this.smartLabel1.TabIndex = 199;
            this.smartLabel1.Text = "Bank ID :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(169, 261);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 57);
            this.txtRemarks.TabIndex = 2;
            // 
            // txtBankTitleBeng
            // 
            this.txtBankTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankTitleBeng.Location = new System.Drawing.Point(169, 228);
            this.txtBankTitleBeng.MaxLength = 70;
            this.txtBankTitleBeng.Multiline = true;
            this.txtBankTitleBeng.Name = "txtBankTitleBeng";
            this.txtBankTitleBeng.Size = new System.Drawing.Size(400, 26);
            this.txtBankTitleBeng.TabIndex = 1;
            // 
            // txtBankTitle
            // 
            this.txtBankTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankTitle.Location = new System.Drawing.Point(169, 192);
            this.txtBankTitle.MaxLength = 70;
            this.txtBankTitle.Multiline = true;
            this.txtBankTitle.Name = "txtBankTitle";
            this.txtBankTitle.Size = new System.Drawing.Size(400, 28);
            this.txtBankTitle.TabIndex = 0;
            this.txtBankTitle.TextChanged += new System.EventHandler(this.txtBankTitle_TextChanged);
            // 
            // txtBankID
            // 
            this.txtBankID.BackColor = System.Drawing.Color.Linen;
            this.txtBankID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBankID.Location = new System.Drawing.Point(169, 160);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.ReadOnly = true;
            this.txtBankID.Size = new System.Drawing.Size(136, 24);
            this.txtBankID.TabIndex = 195;
            this.txtBankID.TabStop = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(720, 174);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(47, 13);
            this.smartLabel4.TabIndex = 206;
            this.smartLabel4.Text = "Serial :";
            this.smartLabel4.Visible = false;
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(711, 192);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(56, 24);
            this.txtSerial.TabIndex = 205;
            this.txtSerial.Visible = false;
            // 
            // lvBankInfo
            // 
            this.lvBankInfo.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvBankInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBankInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvBankInfo.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBankInfo.FullRowSelect = true;
            this.lvBankInfo.GridLines = true;
            this.lvBankInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvBankInfo.Location = new System.Drawing.Point(-1, 335);
            this.lvBankInfo.Name = "lvBankInfo";
            this.lvBankInfo.Size = new System.Drawing.Size(863, 296);
            this.lvBankInfo.TabIndex = 207;
            this.lvBankInfo.UseCompatibleStateImageBehavior = false;
            this.lvBankInfo.View = System.Windows.Forms.View.Details;
            this.lvBankInfo.SelectedIndexChanged += new System.EventHandler(this.lvBankInfo_SelectedIndexChanged);
            this.lvBankInfo.Click += new System.EventHandler(this.lvBankInfo_Click);
            // 
            // frmBankSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmBankSetup";
            this.Load += new System.EventHandler(this.frmBankSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtBankTitleBeng;
        private AtiqsControlLibrary.SmartTextBox txtBankTitle;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtBankID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtSerial;
        private AtiqsControlLibrary.SmartListViewDetails lvBankInfo;
    }
}
