namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmStoreUserSetup
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
            this.cboStoreLocation = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmployeeID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvStoreUser = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboStore = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmpId = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(375, 9);
            this.frmLabel.Size = new System.Drawing.Size(140, 33);
            this.frmLabel.Text = "Store User";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.lvStoreUser);
            this.pnlMain.Controls.Add(this.cboStore);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtEmpId);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboStoreLocation);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtEmployeeID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(881, 608);
            this.pnlMain.TabIndex = 20;
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(882, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(658, 527);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(545, 527);
            this.btnSave.TabIndex = 3;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(43, 524);
            this.btnDelete.Size = new System.Drawing.Size(44, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(432, 527);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(769, 527);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(93, 527);
            this.btnPrint.Size = new System.Drawing.Size(43, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 569);
            this.groupBox1.Size = new System.Drawing.Size(882, 25);
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreLocation.ForeColor = System.Drawing.Color.Blue;
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(200, 92);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(296, 26);
            this.cboStoreLocation.TabIndex = 8;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(104, 99);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(45, 13);
            this.smartLabel2.TabIndex = 7;
            this.smartLabel2.Text = "Store :";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(200, 66);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(160, 24);
            this.txtEmployeeID.TabIndex = 6;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(104, 72);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 13);
            this.smartLabel1.TabIndex = 5;
            this.smartLabel1.Text = "Employee ID :";
            // 
            // lvStoreUser
            // 
            this.lvStoreUser.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvStoreUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStoreUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvStoreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStoreUser.FullRowSelect = true;
            this.lvStoreUser.GridLines = true;
            this.lvStoreUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStoreUser.Location = new System.Drawing.Point(-1, 226);
            this.lvStoreUser.Name = "lvStoreUser";
            this.lvStoreUser.Size = new System.Drawing.Size(880, 381);
            this.lvStoreUser.TabIndex = 13;
            this.lvStoreUser.UseCompatibleStateImageBehavior = false;
            this.lvStoreUser.View = System.Windows.Forms.View.Details;
            this.lvStoreUser.SelectedIndexChanged += new System.EventHandler(this.lvStoreUser_SelectedIndexChanged);
            // 
            // cboStore
            // 
            this.cboStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStore.ForeColor = System.Drawing.Color.Blue;
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(195, 192);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(296, 26);
            this.cboStore.TabIndex = 2;
            this.cboStore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboStore_KeyDown);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(104, 199);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(45, 13);
            this.smartLabel3.TabIndex = 11;
            this.smartLabel3.Text = "Store :";
            // 
            // txtEmpId
            // 
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(195, 152);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(160, 24);
            this.txtEmpId.TabIndex = 1;
            this.txtEmpId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpId_KeyDown);
            this.txtEmpId.Leave += new System.EventHandler(this.txtUserID_Leave);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(104, 159);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(58, 13);
            this.smartLabel4.TabIndex = 9;
            this.smartLabel4.Text = "User ID :";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(361, 152);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(88, 15);
            this.lblInfo.TabIndex = 227;
            this.lblInfo.Text = "Information";
            // 
            // frmStoreUserSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(882, 594);
            this.isEnterTabAllow = true;
            this.Name = "frmStoreUserSetup";
            this.Load += new System.EventHandler(this.frmStoreUserSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboStoreLocation;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtEmployeeID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvStoreUser;
        private AtiqsControlLibrary.SmartComboBox cboStore;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtEmpId;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel lblInfo;
    }
}
