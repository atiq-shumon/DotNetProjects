namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmServiceProviderInformation
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
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtServiceProviderName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtAddress = new AtiqsControlLibrary.SmartTextBox();
            this.txtWeb = new AtiqsControlLibrary.SmartTextBox();
            this.txtPhone = new AtiqsControlLibrary.SmartTextBox();
            this.txtFax = new AtiqsControlLibrary.SmartTextBox();
            this.txtEmail = new AtiqsControlLibrary.SmartTextBox();
            this.txtContactPerson = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.cboAccCode = new AtiqsControlLibrary.SmartComboBox();
            this.cboPriority = new AtiqsControlLibrary.SmartComboBox();
            this.Cbostatus = new AtiqsControlLibrary.SmartComboBox();
            this.lvwService = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtServiceCode = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(294, 8);
            this.frmLabel.Size = new System.Drawing.Size(354, 33);
            this.frmLabel.TabIndex = 15;
            this.frmLabel.Text = "Service Provider Information";
            this.frmLabel.Click += new System.EventHandler(this.frmLabel_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtServiceCode);
            this.pnlMain.Controls.Add(this.lvwService);
            this.pnlMain.Controls.Add(this.Cbostatus);
            this.pnlMain.Controls.Add(this.cboPriority);
            this.pnlMain.Controls.Add(this.cboAccCode);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtContactPerson);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.txtFax);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.txtWeb);
            this.pnlMain.Controls.Add(this.txtAddress);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtServiceProviderName);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // pnlTop
            // 
            this.pnlTop.TabIndex = 16;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(522, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(409, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(635, 555);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(296, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(20, 555);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 603);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(16, 186);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(165, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Service Provider Name:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(510, 186);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(65, 14);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Address:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(521, 215);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(53, 14);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "Phone:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(128, 214);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(42, 14);
            this.smartLabel4.TabIndex = 3;
            this.smartLabel4.Text = "Web:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(135, 247);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(36, 14);
            this.smartLabel5.TabIndex = 4;
            this.smartLabel5.Text = "Fax:";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(521, 243);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(56, 14);
            this.smartLabel6.TabIndex = 5;
            this.smartLabel6.Text = "E_Mail:";
            // 
            // txtServiceProviderName
            // 
            this.txtServiceProviderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceProviderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceProviderName.Location = new System.Drawing.Point(182, 183);
            this.txtServiceProviderName.Name = "txtServiceProviderName";
            this.txtServiceProviderName.Size = new System.Drawing.Size(262, 24);
            this.txtServiceProviderName.TabIndex = 0;
            this.txtServiceProviderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServiceProviderName_KeyPress);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(60, 280);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(112, 14);
            this.smartLabel7.TabIndex = 7;
            this.smartLabel7.Text = "Contact Person:";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(475, 153);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(101, 14);
            this.smartLabel8.TabIndex = 8;
            this.smartLabel8.Text = "Account Code:";
            this.smartLabel8.Visible = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(510, 275);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(70, 14);
            this.smartLabel9.TabIndex = 9;
            this.smartLabel9.Text = "Remarks:";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(113, 313);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(62, 14);
            this.smartLabel10.TabIndex = 10;
            this.smartLabel10.Text = "Priority:";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(520, 307);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(54, 14);
            this.smartLabel11.TabIndex = 11;
            this.smartLabel11.Text = "Status:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(588, 181);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(263, 24);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtWeb
            // 
            this.txtWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeb.Location = new System.Drawing.Point(182, 213);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(262, 24);
            this.txtWeb.TabIndex = 2;
            this.txtWeb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeb_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(588, 210);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(263, 24);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(182, 245);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(262, 24);
            this.txtFax.TabIndex = 4;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFax_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(588, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 24);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.Location = new System.Drawing.Point(182, 275);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(262, 24);
            this.txtContactPerson.TabIndex = 6;
            this.txtContactPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactPerson_KeyPress);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(589, 269);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(265, 24);
            this.txtRemarks.TabIndex = 8;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // cboAccCode
            // 
            this.cboAccCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAccCode.ForeColor = System.Drawing.Color.Blue;
            this.cboAccCode.FormattingEnabled = true;
            this.cboAccCode.Location = new System.Drawing.Point(588, 149);
            this.cboAccCode.Name = "cboAccCode";
            this.cboAccCode.Size = new System.Drawing.Size(263, 26);
            this.cboAccCode.TabIndex = 7;
            this.cboAccCode.Visible = false;
            this.cboAccCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAccCode_KeyPress);
            // 
            // cboPriority
            // 
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPriority.ForeColor = System.Drawing.Color.Blue;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboPriority.Location = new System.Drawing.Point(182, 307);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(264, 26);
            this.cboPriority.TabIndex = 9;
            this.cboPriority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPriority_KeyPress);
            // 
            // Cbostatus
            // 
            this.Cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbostatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbostatus.ForeColor = System.Drawing.Color.Blue;
            this.Cbostatus.FormattingEnabled = true;
            this.Cbostatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.Cbostatus.Location = new System.Drawing.Point(586, 303);
            this.Cbostatus.Name = "Cbostatus";
            this.Cbostatus.Size = new System.Drawing.Size(270, 26);
            this.Cbostatus.TabIndex = 10;
            this.Cbostatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbostatus_KeyPress);
            // 
            // lvwService
            // 
            this.lvwService.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwService.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwService.FullRowSelect = true;
            this.lvwService.GridLines = true;
            this.lvwService.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwService.Location = new System.Drawing.Point(15, 351);
            this.lvwService.Name = "lvwService";
            this.lvwService.Size = new System.Drawing.Size(839, 273);
            this.lvwService.TabIndex = 22;
            this.lvwService.UseCompatibleStateImageBehavior = false;
            this.lvwService.View = System.Windows.Forms.View.Details;
            this.lvwService.SelectedIndexChanged += new System.EventHandler(this.lvwService_SelectedIndexChanged);
            // 
            // txtServiceCode
            // 
            this.txtServiceCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCode.Location = new System.Drawing.Point(182, 151);
            this.txtServiceCode.Name = "txtServiceCode";
            this.txtServiceCode.Size = new System.Drawing.Size(100, 24);
            this.txtServiceCode.TabIndex = 23;
            this.txtServiceCode.Visible = false;
            // 
            // frmServiceProviderInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 628);
            this.KeyPreview = false;
            this.Name = "frmServiceProviderInformation";
            this.Load += new System.EventHandler(this.frmServiceProviderInformation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtServiceProviderName;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvwService;
        private AtiqsControlLibrary.SmartComboBox Cbostatus;
        private AtiqsControlLibrary.SmartComboBox cboPriority;
        private AtiqsControlLibrary.SmartComboBox cboAccCode;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtContactPerson;
        private AtiqsControlLibrary.SmartTextBox txtEmail;
        private AtiqsControlLibrary.SmartTextBox txtFax;
        private AtiqsControlLibrary.SmartTextBox txtPhone;
        private AtiqsControlLibrary.SmartTextBox txtWeb;
        private AtiqsControlLibrary.SmartTextBox txtAddress;
        private AtiqsControlLibrary.SmartTextBox txtServiceCode;
    }
}
