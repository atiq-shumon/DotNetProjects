namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    partial class frmCorporateType
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
            this.lvCorpType = new AtiqsControlLibrary.SmartListViewDetails();
            this.lblStaffTypeTitleBangla = new AtiqsControlLibrary.SmartLabel();
            this.txtCorpTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.lblCorpTitle = new AtiqsControlLibrary.SmartLabel();
            this.txtCorpTitle = new AtiqsControlLibrary.SmartTextBox();
            this.lblCorpTypeId = new AtiqsControlLibrary.SmartLabel();
            this.txtCorpId = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtCorpTypeId = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtCorpAddrss = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtCorpWeb = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtCorpEmail = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtCorpMobile = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtCorpPhone = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(450, 9);
            this.frmLabel.Size = new System.Drawing.Size(275, 33);
            this.frmLabel.Text = "Corporate Type Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvCorpType);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(1160, 544);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1160, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(928, 608);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(815, 608);
            this.btnSave.TabIndex = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 608);
            this.btnDelete.Size = new System.Drawing.Size(14, 14);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(702, 608);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1040, 608);
            this.btnClose.TabIndex = 13;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(23, 607);
            this.btnPrint.Size = new System.Drawing.Size(14, 14);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 649);
            this.groupBox1.Size = new System.Drawing.Size(1160, 25);
            // 
            // lvCorpType
            // 
            this.lvCorpType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvCorpType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCorpType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCorpType.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCorpType.FullRowSelect = true;
            this.lvCorpType.GridLines = true;
            this.lvCorpType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCorpType.Location = new System.Drawing.Point(0, 141);
            this.lvCorpType.Name = "lvCorpType";
            this.lvCorpType.Size = new System.Drawing.Size(1158, 401);
            this.lvCorpType.TabIndex = 104;
            this.lvCorpType.TabStop = false;
            this.lvCorpType.UseCompatibleStateImageBehavior = false;
            this.lvCorpType.View = System.Windows.Forms.View.Details;
            this.lvCorpType.SelectedIndexChanged += new System.EventHandler(this.lvCorpType_SelectedIndexChanged);
            // 
            // lblStaffTypeTitleBangla
            // 
            this.lblStaffTypeTitleBangla.AutoSize = true;
            this.lblStaffTypeTitleBangla.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffTypeTitleBangla.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStaffTypeTitleBangla.Location = new System.Drawing.Point(432, 21);
            this.lblStaffTypeTitleBangla.Name = "lblStaffTypeTitleBangla";
            this.lblStaffTypeTitleBangla.Size = new System.Drawing.Size(149, 18);
            this.lblStaffTypeTitleBangla.TabIndex = 102;
            this.lblStaffTypeTitleBangla.Text = "Corporate Title Bangla :";
            // 
            // txtCorpTitleBeng
            // 
            this.txtCorpTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpTitleBeng.Location = new System.Drawing.Point(594, 15);
            this.txtCorpTitleBeng.Multiline = true;
            this.txtCorpTitleBeng.Name = "txtCorpTitleBeng";
            this.txtCorpTitleBeng.Size = new System.Drawing.Size(239, 28);
            this.txtCorpTitleBeng.TabIndex = 4;
            // 
            // lblCorpTitle
            // 
            this.lblCorpTitle.AutoSize = true;
            this.lblCorpTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCorpTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCorpTitle.Location = new System.Drawing.Point(31, 92);
            this.lblCorpTitle.Name = "lblCorpTitle";
            this.lblCorpTitle.Size = new System.Drawing.Size(104, 18);
            this.lblCorpTitle.TabIndex = 101;
            this.lblCorpTitle.Text = "Corporate Title :";
            // 
            // txtCorpTitle
            // 
            this.txtCorpTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpTitle.Location = new System.Drawing.Point(143, 89);
            this.txtCorpTitle.Multiline = true;
            this.txtCorpTitle.Name = "txtCorpTitle";
            this.txtCorpTitle.Size = new System.Drawing.Size(239, 28);
            this.txtCorpTitle.TabIndex = 3;
            this.txtCorpTitle.TextChanged += new System.EventHandler(this.txtCorpTitle_TextChanged);
            this.txtCorpTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCorpTitle_KeyUp);
            this.txtCorpTitle.Leave += new System.EventHandler(this.txtCorpTitle_Leave);
            // 
            // lblCorpTypeId
            // 
            this.lblCorpTypeId.AutoSize = true;
            this.lblCorpTypeId.BackColor = System.Drawing.Color.Transparent;
            this.lblCorpTypeId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCorpTypeId.Location = new System.Drawing.Point(43, 22);
            this.lblCorpTypeId.Name = "lblCorpTypeId";
            this.lblCorpTypeId.Size = new System.Drawing.Size(92, 18);
            this.lblCorpTypeId.TabIndex = 98;
            this.lblCorpTypeId.Text = "Corporate ID :";
            // 
            // txtCorpId
            // 
            this.txtCorpId.BackColor = System.Drawing.Color.Linen;
            this.txtCorpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCorpId.Location = new System.Drawing.Point(143, 19);
            this.txtCorpId.Name = "txtCorpId";
            this.txtCorpId.ReadOnly = true;
            this.txtCorpId.Size = new System.Drawing.Size(163, 24);
            this.txtCorpId.TabIndex = 1;
            this.txtCorpId.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.ForeColor = System.Drawing.Color.Red;
            this.smartLabel1.Location = new System.Drawing.Point(384, 92);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(21, 26);
            this.smartLabel1.TabIndex = 106;
            this.smartLabel1.Text = "*";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(9, 58);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(126, 18);
            this.smartLabel2.TabIndex = 108;
            this.smartLabel2.Text = "Corporate Type ID :";
            // 
            // txtCorpTypeId
            // 
            this.txtCorpTypeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpTypeId.Location = new System.Drawing.Point(143, 52);
            this.txtCorpTypeId.Multiline = true;
            this.txtCorpTypeId.Name = "txtCorpTypeId";
            this.txtCorpTypeId.ReadOnly = true;
            this.txtCorpTypeId.Size = new System.Drawing.Size(205, 28);
            this.txtCorpTypeId.TabIndex = 2;
            this.txtCorpTypeId.Text = "00";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.ForeColor = System.Drawing.Color.Red;
            this.smartLabel3.Location = new System.Drawing.Point(352, 53);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(21, 26);
            this.smartLabel3.TabIndex = 109;
            this.smartLabel3.Text = "*";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(455, 57);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(126, 18);
            this.smartLabel4.TabIndex = 111;
            this.smartLabel4.Text = "Corporate Address :";
            // 
            // txtCorpAddrss
            // 
            this.txtCorpAddrss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpAddrss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpAddrss.Location = new System.Drawing.Point(594, 52);
            this.txtCorpAddrss.Multiline = true;
            this.txtCorpAddrss.Name = "txtCorpAddrss";
            this.txtCorpAddrss.Size = new System.Drawing.Size(239, 28);
            this.txtCorpAddrss.TabIndex = 5;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(477, 93);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(104, 18);
            this.smartLabel5.TabIndex = 113;
            this.smartLabel5.Text = "Corporate Web :";
            // 
            // txtCorpWeb
            // 
            this.txtCorpWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpWeb.Location = new System.Drawing.Point(594, 89);
            this.txtCorpWeb.Multiline = true;
            this.txtCorpWeb.Name = "txtCorpWeb";
            this.txtCorpWeb.Size = new System.Drawing.Size(239, 28);
            this.txtCorpWeb.TabIndex = 6;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(870, 22);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(111, 18);
            this.smartLabel6.TabIndex = 115;
            this.smartLabel6.Text = "Corporate Email :";
            // 
            // txtCorpEmail
            // 
            this.txtCorpEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpEmail.Location = new System.Drawing.Point(980, 15);
            this.txtCorpEmail.Multiline = true;
            this.txtCorpEmail.Name = "txtCorpEmail";
            this.txtCorpEmail.Size = new System.Drawing.Size(163, 28);
            this.txtCorpEmail.TabIndex = 7;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(862, 94);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(119, 18);
            this.smartLabel7.TabIndex = 119;
            this.smartLabel7.Text = "Corporate Mobile :";
            // 
            // txtCorpMobile
            // 
            this.txtCorpMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpMobile.Location = new System.Drawing.Point(980, 89);
            this.txtCorpMobile.Multiline = true;
            this.txtCorpMobile.Name = "txtCorpMobile";
            this.txtCorpMobile.Size = new System.Drawing.Size(163, 28);
            this.txtCorpMobile.TabIndex = 9;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(867, 58);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(114, 18);
            this.smartLabel8.TabIndex = 117;
            this.smartLabel8.Text = "Corporate Phone :";
            // 
            // txtCorpPhone
            // 
            this.txtCorpPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorpPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorpPhone.Location = new System.Drawing.Point(980, 52);
            this.txtCorpPhone.Multiline = true;
            this.txtCorpPhone.Name = "txtCorpPhone";
            this.txtCorpPhone.Size = new System.Drawing.Size(163, 28);
            this.txtCorpPhone.TabIndex = 8;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.ForeColor = System.Drawing.Color.Red;
            this.smartLabel9.Location = new System.Drawing.Point(836, 23);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(21, 26);
            this.smartLabel9.TabIndex = 121;
            this.smartLabel9.Text = "*";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.ForeColor = System.Drawing.Color.Red;
            this.smartLabel10.Location = new System.Drawing.Point(836, 62);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(21, 26);
            this.smartLabel10.TabIndex = 120;
            this.smartLabel10.Text = "*";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Location = new System.Drawing.Point(860, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 125);
            this.panel3.TabIndex = 243;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Location = new System.Drawing.Point(406, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 125);
            this.panel2.TabIndex = 244;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCorpId);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.txtCorpMobile);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.txtCorpPhone);
            this.groupBox2.Controls.Add(this.smartLabel9);
            this.groupBox2.Controls.Add(this.txtCorpEmail);
            this.groupBox2.Controls.Add(this.lblCorpTypeId);
            this.groupBox2.Controls.Add(this.smartLabel10);
            this.groupBox2.Controls.Add(this.smartLabel7);
            this.groupBox2.Controls.Add(this.txtCorpTitle);
            this.groupBox2.Controls.Add(this.smartLabel8);
            this.groupBox2.Controls.Add(this.lblCorpTitle);
            this.groupBox2.Controls.Add(this.smartLabel6);
            this.groupBox2.Controls.Add(this.txtCorpTypeId);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.txtCorpWeb);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.txtCorpAddrss);
            this.groupBox2.Controls.Add(this.txtCorpTitleBeng);
            this.groupBox2.Controls.Add(this.lblStaffTypeTitleBangla);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Location = new System.Drawing.Point(4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1152, 133);
            this.groupBox2.TabIndex = 245;
            this.groupBox2.TabStop = false;
            // 
            // frmCorporateType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 674);
            this.isEnterTabAllow = true;
            this.Name = "frmCorporateType";
            this.Load += new System.EventHandler(this.frmCorporateType_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvCorpType;
        private AtiqsControlLibrary.SmartLabel lblStaffTypeTitleBangla;
        private AtiqsControlLibrary.SmartTextBox txtCorpTitleBeng;
        private AtiqsControlLibrary.SmartLabel lblCorpTitle;
        private AtiqsControlLibrary.SmartTextBox txtCorpTitle;
        private AtiqsControlLibrary.SmartLabel lblCorpTypeId;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCorpId;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtCorpTypeId;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtCorpMobile;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartTextBox txtCorpPhone;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtCorpEmail;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtCorpWeb;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtCorpAddrss;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}