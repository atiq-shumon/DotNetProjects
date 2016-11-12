namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmRevenueHead
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
            this.lvRhgr = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRevHdName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboGrouptitle = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboLedgerName = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtRevHdID = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(186, 33);
            this.frmLabel.TabIndex = 8;
            this.frmLabel.Text = "Revenue Head";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtRevHdID);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboLedgerName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboGrouptitle);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtRevHdName);
            this.pnlMain.Controls.Add(this.lvRhgr);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(869, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 594);
            this.groupBox1.Size = new System.Drawing.Size(869, 25);
            // 
            // lvRhgr
            // 
            this.lvRhgr.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvRhgr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRhgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvRhgr.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRhgr.FullRowSelect = true;
            this.lvRhgr.GridLines = true;
            this.lvRhgr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRhgr.Location = new System.Drawing.Point(8, 309);
            this.lvRhgr.Name = "lvRhgr";
            this.lvRhgr.Size = new System.Drawing.Size(847, 317);
            this.lvRhgr.TabIndex = 5;
            this.lvRhgr.UseCompatibleStateImageBehavior = false;
            this.lvRhgr.View = System.Windows.Forms.View.Details;
            this.lvRhgr.SelectedIndexChanged += new System.EventHandler(this.lvRhgr_SelectedIndexChanged);
            // 
            // txtRevHdName
            // 
            this.txtRevHdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRevHdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevHdName.Location = new System.Drawing.Point(310, 182);
            this.txtRevHdName.Name = "txtRevHdName";
            this.txtRevHdName.Size = new System.Drawing.Size(300, 24);
            this.txtRevHdName.TabIndex = 0;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(229, 187);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(70, 13);
            this.smartLabel1.TabIndex = 17;
            this.smartLabel1.Text = "Head Title:";
            // 
            // cboGrouptitle
            // 
            this.cboGrouptitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cboGrouptitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrouptitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrouptitle.ForeColor = System.Drawing.Color.Blue;
            this.cboGrouptitle.FormattingEnabled = true;
            this.cboGrouptitle.Location = new System.Drawing.Point(310, 210);
            this.cboGrouptitle.Name = "cboGrouptitle";
            this.cboGrouptitle.Size = new System.Drawing.Size(300, 26);
            this.cboGrouptitle.TabIndex = 1;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(225, 215);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(74, 13);
            this.smartLabel2.TabIndex = 19;
            this.smartLabel2.Text = "Group Title:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(202, 244);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(97, 13);
            this.smartLabel3.TabIndex = 21;
            this.smartLabel3.Text = "Accounts Code:";
            // 
            // cboLedgerName
            // 
            this.cboLedgerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cboLedgerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLedgerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLedgerName.ForeColor = System.Drawing.Color.Blue;
            this.cboLedgerName.FormattingEnabled = true;
            this.cboLedgerName.Location = new System.Drawing.Point(310, 239);
            this.cboLedgerName.Name = "cboLedgerName";
            this.cboLedgerName.Size = new System.Drawing.Size(300, 26);
            this.cboLedgerName.TabIndex = 2;
            this.cboLedgerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLedgerName_KeyDown);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(239, 274);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(60, 13);
            this.smartLabel5.TabIndex = 25;
            this.smartLabel5.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(310, 269);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(300, 24);
            this.txtRemarks.TabIndex = 3;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(241, 157);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(58, 13);
            this.smartLabel4.TabIndex = 27;
            this.smartLabel4.Text = "Head ID:";
            // 
            // txtRevHdID
            // 
            this.txtRevHdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRevHdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevHdID.Location = new System.Drawing.Point(310, 152);
            this.txtRevHdID.Name = "txtRevHdID";
            this.txtRevHdID.ReadOnly = true;
            this.txtRevHdID.Size = new System.Drawing.Size(300, 24);
            this.txtRevHdID.TabIndex = 0;
            // 
            // frmRevenueHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(869, 619);
            this.Name = "frmRevenueHead";
            this.Load += new System.EventHandler(this.frmRevenueHead_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvRhgr;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboLedgerName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboGrouptitle;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRevHdName;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtRevHdID;
    }
}
