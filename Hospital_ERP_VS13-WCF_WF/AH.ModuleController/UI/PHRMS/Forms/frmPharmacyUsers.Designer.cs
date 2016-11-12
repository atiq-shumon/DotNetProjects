namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmPharmacyUsers
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtUserID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboPharmacyLocation = new AtiqsControlLibrary.SmartComboBox();
            this.lvPharmacyUser = new AtiqsControlLibrary.SmartListViewDetails();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(336, 9);
            this.frmLabel.Text = "Pharmacy Users";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.lvPharmacyUser);
            this.pnlMain.Controls.Add(this.cboPharmacyLocation);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtUserID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 59);
            this.pnlMain.Size = new System.Drawing.Size(869, 494);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(869, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(29, 558);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(605, 558);
            this.btnSave.Size = new System.Drawing.Size(146, 39);
            this.btnSave.Text = "Save / Edit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(143, 558);
            this.btnDelete.Size = new System.Drawing.Size(41, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(495, 558);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(753, 558);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(190, 558);
            this.btnPrint.Size = new System.Drawing.Size(42, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(869, 23);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(104, 28);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(63, 15);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "User ID :";
            this.smartLabel1.Click += new System.EventHandler(this.smartLabel1_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(195, 21);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(160, 24);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.TextChanged += new System.EventHandler(this.smartTextBox1_TextChanged);
            this.txtUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyDown);
            this.txtUserID.Leave += new System.EventHandler(this.txtUserID_Leave);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(104, 62);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(78, 15);
            this.smartLabel2.TabIndex = 2;
            this.smartLabel2.Text = "Pharmacy :";
            this.smartLabel2.Click += new System.EventHandler(this.smartLabel2_Click);
            // 
            // cboPharmacyLocation
            // 
            this.cboPharmacyLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPharmacyLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPharmacyLocation.ForeColor = System.Drawing.Color.Blue;
            this.cboPharmacyLocation.FormattingEnabled = true;
            this.cboPharmacyLocation.Location = new System.Drawing.Point(195, 55);
            this.cboPharmacyLocation.Name = "cboPharmacyLocation";
            this.cboPharmacyLocation.Size = new System.Drawing.Size(296, 26);
            this.cboPharmacyLocation.TabIndex = 3;
            this.cboPharmacyLocation.SelectedIndexChanged += new System.EventHandler(this.cboPharmacy_SelectedIndexChanged);
            // 
            // lvPharmacyUser
            // 
            this.lvPharmacyUser.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvPharmacyUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPharmacyUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPharmacyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPharmacyUser.FullRowSelect = true;
            this.lvPharmacyUser.GridLines = true;
            this.lvPharmacyUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPharmacyUser.Location = new System.Drawing.Point(-1, 94);
            this.lvPharmacyUser.Name = "lvPharmacyUser";
            this.lvPharmacyUser.Size = new System.Drawing.Size(868, 398);
            this.lvPharmacyUser.TabIndex = 4;
            this.lvPharmacyUser.UseCompatibleStateImageBehavior = false;
            this.lvPharmacyUser.View = System.Windows.Forms.View.Details;
            this.lvPharmacyUser.SelectedIndexChanged += new System.EventHandler(this.lvPharmacyUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(357, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 258;
            this.label1.Text = "*";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(372, 21);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(88, 15);
            this.lblInfo.TabIndex = 257;
            this.lblInfo.Text = "Information";
            // 
            // frmPharmacyUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(869, 621);
            this.isEnterTabAllow = true;
            this.Name = "frmPharmacyUsers";
            this.Load += new System.EventHandler(this.frmPharmacyUsers_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtUserID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboPharmacyLocation;
        private AtiqsControlLibrary.SmartListViewDetails lvPharmacyUser;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartLabel lblInfo;
    }
}
