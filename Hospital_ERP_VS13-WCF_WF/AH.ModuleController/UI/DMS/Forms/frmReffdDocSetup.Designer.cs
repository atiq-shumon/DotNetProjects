namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmReffdDocSetup
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
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtWeb = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmail = new AtiqsControlLibrary.SmartTextBox();
            this.txtPhone = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtAddress = new AtiqsControlLibrary.SmartTextBox();
            this.txtDocID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.cboReffOrg = new AtiqsControlLibrary.SmartComboBox();
            this.txtDoctorName = new AtiqsControlLibrary.SmartTextBox();
            this.txtDoctorNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegreeLine = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.lvReffdDoc = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnRefreshOrg = new System.Windows.Forms.Button();
            this.btnAddOrg = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(521, 9);
            this.frmLabel.Size = new System.Drawing.Size(307, 33);
            this.frmLabel.Text = "Referrence Doctor Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRefreshOrg);
            this.pnlMain.Controls.Add(this.btnAddOrg);
            this.pnlMain.Controls.Add(this.lvReffdDoc);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtDegreeLine);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.txtDoctorNameBeng);
            this.pnlMain.Controls.Add(this.txtDoctorName);
            this.pnlMain.Controls.Add(this.cboReffOrg);
            this.pnlMain.Controls.Add(this.txtDocID);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtWeb);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtAddress);
            this.pnlMain.Size = new System.Drawing.Size(1353, 875);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1353, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(903, 794);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(790, 794);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1016, 794);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(677, 794);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1238, 794);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1127, 794);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 833);
            this.groupBox1.Size = new System.Drawing.Size(1353, 25);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(1070, 208);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(64, 13);
            this.smartLabel8.TabIndex = 25;
            this.smartLabel8.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(1070, 229);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(270, 130);
            this.txtRemarks.TabIndex = 10;
            this.txtRemarks.Text = "N/A";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(822, 314);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(41, 13);
            this.smartLabel7.TabIndex = 24;
            this.smartLabel7.Text = "Web :";
            // 
            // txtWeb
            // 
            this.txtWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeb.Location = new System.Drawing.Point(822, 335);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(240, 24);
            this.txtWeb.TabIndex = 9;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(822, 261);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(45, 13);
            this.smartLabel6.TabIndex = 23;
            this.smartLabel6.Text = "Email :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(822, 208);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(51, 13);
            this.smartLabel5.TabIndex = 22;
            this.smartLabel5.Text = "Phone :";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(822, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(822, 229);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 24);
            this.txtPhone.TabIndex = 7;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(540, 208);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(56, 13);
            this.smartLabel4.TabIndex = 21;
            this.smartLabel4.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(542, 229);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(271, 130);
            this.txtAddress.TabIndex = 6;
            // 
            // txtDocID
            // 
            this.txtDocID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtDocID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDocID.Location = new System.Drawing.Point(13, 176);
            this.txtDocID.Name = "txtDocID";
            this.txtDocID.ReadOnly = true;
            this.txtDocID.Size = new System.Drawing.Size(86, 24);
            this.txtDocID.TabIndex = 26;
            this.txtDocID.TabStop = false;
            // 
            // cboReffOrg
            // 
            this.cboReffOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReffOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReffOrg.ForeColor = System.Drawing.Color.Blue;
            this.cboReffOrg.FormattingEnabled = true;
            this.cboReffOrg.Location = new System.Drawing.Point(105, 176);
            this.cboReffOrg.Name = "cboReffOrg";
            this.cboReffOrg.Size = new System.Drawing.Size(428, 26);
            this.cboReffOrg.TabIndex = 1;
            this.cboReffOrg.SelectedIndexChanged += new System.EventHandler(this.cboReffOrg_SelectedIndexChanged);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(13, 229);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(520, 24);
            this.txtDoctorName.TabIndex = 3;
            this.txtDoctorName.TextChanged += new System.EventHandler(this.txtDoctorName_TextChanged);
            this.txtDoctorName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDoctorName_KeyUp);
            // 
            // txtDoctorNameBeng
            // 
            this.txtDoctorNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorNameBeng.Location = new System.Drawing.Point(13, 282);
            this.txtDoctorNameBeng.Name = "txtDoctorNameBeng";
            this.txtDoctorNameBeng.Size = new System.Drawing.Size(520, 24);
            this.txtDoctorNameBeng.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(611, 174);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(67, 26);
            this.btnShow.TabIndex = 2;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show Result Head";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(13, 155);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(55, 13);
            this.smartLabel1.TabIndex = 163;
            this.smartLabel1.Text = "Doc ID :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(102, 155);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(139, 13);
            this.smartLabel2.TabIndex = 164;
            this.smartLabel2.Text = "Referred Organization :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(13, 208);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(74, 13);
            this.smartLabel3.TabIndex = 165;
            this.smartLabel3.Text = "Doc Name :";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(13, 261);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(125, 13);
            this.smartLabel9.TabIndex = 166;
            this.smartLabel9.Text = "Doc Name (Bangla) :";
            // 
            // txtDegreeLine
            // 
            this.txtDegreeLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegreeLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegreeLine.Location = new System.Drawing.Point(13, 335);
            this.txtDegreeLine.Name = "txtDegreeLine";
            this.txtDegreeLine.Size = new System.Drawing.Size(520, 24);
            this.txtDegreeLine.TabIndex = 5;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(13, 314);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(84, 13);
            this.smartLabel10.TabIndex = 168;
            this.smartLabel10.Text = "Degree Line :";
            // 
            // lvReffdDoc
            // 
            this.lvReffdDoc.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvReffdDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvReffdDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvReffdDoc.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvReffdDoc.FullRowSelect = true;
            this.lvReffdDoc.GridLines = true;
            this.lvReffdDoc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvReffdDoc.Location = new System.Drawing.Point(-1, 391);
            this.lvReffdDoc.Name = "lvReffdDoc";
            this.lvReffdDoc.Size = new System.Drawing.Size(1353, 481);
            this.lvReffdDoc.TabIndex = 169;
            this.lvReffdDoc.UseCompatibleStateImageBehavior = false;
            this.lvReffdDoc.View = System.Windows.Forms.View.Details;
            this.lvReffdDoc.SelectedIndexChanged += new System.EventHandler(this.lvReffdDoc_SelectedIndexChanged);
            this.lvReffdDoc.Click += new System.EventHandler(this.lvReffdDoc_Click);
            // 
            // btnRefreshOrg
            // 
            this.btnRefreshOrg.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshOrg.ForeColor = System.Drawing.Color.White;
            this.btnRefreshOrg.Location = new System.Drawing.Point(576, 174);
            this.btnRefreshOrg.Name = "btnRefreshOrg";
            this.btnRefreshOrg.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshOrg.TabIndex = 171;
            this.btnRefreshOrg.TabStop = false;
            this.btnRefreshOrg.Text = "..";
            this.btnRefreshOrg.UseVisualStyleBackColor = false;
            this.btnRefreshOrg.Click += new System.EventHandler(this.btnRefreshOrg_Click);
            // 
            // btnAddOrg
            // 
            this.btnAddOrg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrg.ForeColor = System.Drawing.Color.White;
            this.btnAddOrg.Location = new System.Drawing.Point(542, 174);
            this.btnAddOrg.Name = "btnAddOrg";
            this.btnAddOrg.Size = new System.Drawing.Size(32, 26);
            this.btnAddOrg.TabIndex = 170;
            this.btnAddOrg.TabStop = false;
            this.btnAddOrg.Text = "+";
            this.btnAddOrg.UseVisualStyleBackColor = false;
            this.btnAddOrg.Click += new System.EventHandler(this.btnAddOrg_Click);
            // 
            // frmReffdDocSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1353, 858);
            this.isEnterTabAllow = true;
            this.Name = "frmReffdDocSetup";
            this.Load += new System.EventHandler(this.frmReffdDocSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtWeb;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtEmail;
        private AtiqsControlLibrary.SmartTextBox txtPhone;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtAddress;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDocID;
        private AtiqsControlLibrary.SmartComboBox cboReffOrg;
        private AtiqsControlLibrary.SmartTextBox txtDoctorNameBeng;
        private AtiqsControlLibrary.SmartTextBox txtDoctorName;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartTextBox txtDegreeLine;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartListViewDetails lvReffdDoc;
        private System.Windows.Forms.Button btnRefreshOrg;
        private System.Windows.Forms.Button btnAddOrg;
    }
}
