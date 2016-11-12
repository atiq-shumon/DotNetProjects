namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmBranchConfig
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
            this.lblBranchName = new AtiqsControlLibrary.SmartLabel();
            this.lblAddress1 = new AtiqsControlLibrary.SmartLabel();
            this.lbladdress2 = new AtiqsControlLibrary.SmartLabel();
            this.lblOCountry = new AtiqsControlLibrary.SmartLabel();
            this.lblTelephone = new AtiqsControlLibrary.SmartLabel();
            this.lblFax = new AtiqsControlLibrary.SmartLabel();
            this.lblinactive = new AtiqsControlLibrary.SmartLabel();
            this.LvwBranchList = new AtiqsControlLibrary.SmartListViewDetails();
            this.lblComments = new AtiqsControlLibrary.SmartLabel();
            this.txtBranchName = new AtiqsControlLibrary.SmartTextBox();
            this.txtAddress2 = new AtiqsControlLibrary.SmartTextBox();
            this.txtCountry = new AtiqsControlLibrary.SmartTextBox();
            this.txtTelephone = new AtiqsControlLibrary.SmartTextBox();
            this.txtFax = new AtiqsControlLibrary.SmartTextBox();
            this.txtCommnets = new AtiqsControlLibrary.SmartTextBox();
            this.txtAddress1 = new AtiqsControlLibrary.SmartTextBox();
            this.cboInactive = new AtiqsControlLibrary.SmartComboBox();
            this.txtBranchID = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(317, -2);
            this.frmLabel.Size = new System.Drawing.Size(273, 33);
            this.frmLabel.Text = "Branch Configuration ";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtBranchID);
            this.pnlMain.Controls.Add(this.cboInactive);
            this.pnlMain.Controls.Add(this.txtAddress1);
            this.pnlMain.Controls.Add(this.txtCommnets);
            this.pnlMain.Controls.Add(this.txtFax);
            this.pnlMain.Controls.Add(this.txtTelephone);
            this.pnlMain.Controls.Add(this.txtCountry);
            this.pnlMain.Controls.Add(this.txtAddress2);
            this.pnlMain.Controls.Add(this.txtBranchName);
            this.pnlMain.Controls.Add(this.lblComments);
            this.pnlMain.Controls.Add(this.LvwBranchList);
            this.pnlMain.Controls.Add(this.lblinactive);
            this.pnlMain.Controls.Add(this.lblFax);
            this.pnlMain.Controls.Add(this.lblTelephone);
            this.pnlMain.Controls.Add(this.lblOCountry);
            this.pnlMain.Controls.Add(this.lbladdress2);
            this.pnlMain.Controls.Add(this.lblAddress1);
            this.pnlMain.Controls.Add(this.lblBranchName);
            this.pnlMain.Location = new System.Drawing.Point(0, 45);
            this.pnlMain.Size = new System.Drawing.Size(863, 468);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 38);
            this.pnlTop.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(371, 518);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(257, 518);
            this.btnSave.TabIndex = 9;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(485, 518);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(143, 518);
            this.btnNew.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 518);
            this.btnClose.TabIndex = 12;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(599, 518);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 559);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBranchName.Location = new System.Drawing.Point(160, 25);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(94, 18);
            this.lblBranchName.TabIndex = 0;
            this.lblBranchName.Text = "Branch Name:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAddress1.Location = new System.Drawing.Point(177, 50);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(76, 18);
            this.lblAddress1.TabIndex = 1;
            this.lblAddress1.Text = "Adddress1:";
            // 
            // lbladdress2
            // 
            this.lbladdress2.AutoSize = true;
            this.lbladdress2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbladdress2.Location = new System.Drawing.Point(184, 75);
            this.lbladdress2.Name = "lbladdress2";
            this.lbladdress2.Size = new System.Drawing.Size(68, 18);
            this.lbladdress2.TabIndex = 2;
            this.lbladdress2.Text = "Address2:";
            // 
            // lblOCountry
            // 
            this.lblOCountry.AutoSize = true;
            this.lblOCountry.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOCountry.Location = new System.Drawing.Point(193, 100);
            this.lblOCountry.Name = "lblOCountry";
            this.lblOCountry.Size = new System.Drawing.Size(59, 18);
            this.lblOCountry.TabIndex = 3;
            this.lblOCountry.Text = "Country:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTelephone.Location = new System.Drawing.Point(176, 125);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(76, 18);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Telephone:";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFax.Location = new System.Drawing.Point(216, 153);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(32, 18);
            this.lblFax.TabIndex = 5;
            this.lblFax.Text = "Fax:";
            // 
            // lblinactive
            // 
            this.lblinactive.AutoSize = true;
            this.lblinactive.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblinactive.Location = new System.Drawing.Point(190, 179);
            this.lblinactive.Name = "lblinactive";
            this.lblinactive.Size = new System.Drawing.Size(59, 18);
            this.lblinactive.TabIndex = 6;
            this.lblinactive.Text = "Inactive:";
            // 
            // LvwBranchList
            // 
            this.LvwBranchList.BackColor = System.Drawing.Color.LemonChiffon;
            this.LvwBranchList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LvwBranchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LvwBranchList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvwBranchList.FullRowSelect = true;
            this.LvwBranchList.GridLines = true;
            this.LvwBranchList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvwBranchList.Location = new System.Drawing.Point(15, 246);
            this.LvwBranchList.Name = "LvwBranchList";
            this.LvwBranchList.Size = new System.Drawing.Size(831, 202);
            this.LvwBranchList.TabIndex = 8;
            this.LvwBranchList.UseCompatibleStateImageBehavior = false;
            this.LvwBranchList.View = System.Windows.Forms.View.Details;
            this.LvwBranchList.SelectedIndexChanged += new System.EventHandler(this.LvwBranchList_SelectedIndexChanged);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblComments.Location = new System.Drawing.Point(179, 208);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(76, 18);
            this.lblComments.TabIndex = 8;
            this.lblComments.Text = "Comments:";
            // 
            // txtBranchName
            // 
            this.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.Location = new System.Drawing.Point(254, 25);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(404, 24);
            this.txtBranchName.TabIndex = 0;
            // 
            // txtAddress2
            // 
            this.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(254, 75);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(404, 24);
            this.txtAddress2.TabIndex = 2;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(254, 100);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(404, 24);
            this.txtCountry.TabIndex = 3;
            this.txtCountry.Text = "Bangladeshis";
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(254, 128);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(404, 24);
            this.txtTelephone.TabIndex = 4;
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(254, 153);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(404, 24);
            this.txtFax.TabIndex = 5;
            // 
            // txtCommnets
            // 
            this.txtCommnets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommnets.Location = new System.Drawing.Point(254, 208);
            this.txtCommnets.Name = "txtCommnets";
            this.txtCommnets.Size = new System.Drawing.Size(404, 24);
            this.txtCommnets.TabIndex = 7;
            // 
            // txtAddress1
            // 
            this.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(254, 50);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(404, 24);
            this.txtAddress1.TabIndex = 1;
            // 
            // cboInactive
            // 
            this.cboInactive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInactive.ForeColor = System.Drawing.Color.Blue;
            this.cboInactive.FormattingEnabled = true;
            this.cboInactive.Location = new System.Drawing.Point(254, 179);
            this.cboInactive.Name = "cboInactive";
            this.cboInactive.Size = new System.Drawing.Size(404, 26);
            this.cboInactive.TabIndex = 6;
            // 
            // txtBranchID
            // 
            this.txtBranchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchID.Location = new System.Drawing.Point(3, 208);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(100, 24);
            this.txtBranchID.TabIndex = 9;
            this.txtBranchID.Visible = false;
            // 
            // frmBranchConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 584);
            this.isEnterTabAllow = true;
            this.Name = "frmBranchConfig";
            this.Load += new System.EventHandler(this.frmBranchConfig_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboInactive;
        private AtiqsControlLibrary.SmartTextBox txtAddress1;
        private AtiqsControlLibrary.SmartTextBox txtCommnets;
        private AtiqsControlLibrary.SmartTextBox txtFax;
        private AtiqsControlLibrary.SmartTextBox txtTelephone;
        private AtiqsControlLibrary.SmartTextBox txtCountry;
        private AtiqsControlLibrary.SmartTextBox txtAddress2;
        private AtiqsControlLibrary.SmartTextBox txtBranchName;
        private AtiqsControlLibrary.SmartLabel lblComments;
        private AtiqsControlLibrary.SmartListViewDetails LvwBranchList;
        private AtiqsControlLibrary.SmartLabel lblinactive;
        private AtiqsControlLibrary.SmartLabel lblFax;
        private AtiqsControlLibrary.SmartLabel lblTelephone;
        private AtiqsControlLibrary.SmartLabel lblOCountry;
        private AtiqsControlLibrary.SmartLabel lbladdress2;
        private AtiqsControlLibrary.SmartLabel lblAddress1;
        private AtiqsControlLibrary.SmartLabel lblBranchName;
        private AtiqsControlLibrary.SmartTextBox txtBranchID;

    }
}
