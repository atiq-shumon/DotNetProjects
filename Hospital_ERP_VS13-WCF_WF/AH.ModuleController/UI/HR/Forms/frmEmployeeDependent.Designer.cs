namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmEmployeeDependent
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
            this.txtEmpID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtSerial = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDependentName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtDependentNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboRelation = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.chkDependStatus = new AtiqsControlLibrary.SmartCheckBox();
            this.txtDOB = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.lvEmployeeDependent = new AtiqsControlLibrary.SmartListViewDetails();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.txtDependID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1030, 6);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(258, 6);
            this.frmLabel.Size = new System.Drawing.Size(416, 33);
            this.frmLabel.Text = "Employee Dependent Information";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.txtDependID);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvEmployeeDependent);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtDOB);
            this.pnlMain.Controls.Add(this.chkDependStatus);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboRelation);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtDependentNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtDependentName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(911, 610);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(911, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(452, 667);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(338, 667);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(566, 667);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(224, 667);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(797, 667);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(683, 667);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 707);
            this.groupBox1.Size = new System.Drawing.Size(911, 23);
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(262, 34);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(193, 24);
            this.txtEmpID.TabIndex = 0;
            this.txtEmpID.Leave += new System.EventHandler(this.txtEmpID_Leave);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(262, 12);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 13);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Employee ID :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(69, 12);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(94, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Dependent ID :";
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(118, 683);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(46, 24);
            this.txtSerial.TabIndex = 5;
            this.txtSerial.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(115, 666);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(47, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Serial :";
            this.smartLabel3.Visible = false;
            // 
            // txtDependentName
            // 
            this.txtDependentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDependentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependentName.Location = new System.Drawing.Point(69, 91);
            this.txtDependentName.Name = "txtDependentName";
            this.txtDependentName.Size = new System.Drawing.Size(386, 24);
            this.txtDependentName.TabIndex = 2;
            this.txtDependentName.TextChanged += new System.EventHandler(this.txtDependentName_TextChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(69, 70);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(113, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Dependent Name :";
            // 
            // txtDependentNameBeng
            // 
            this.txtDependentNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDependentNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependentNameBeng.Location = new System.Drawing.Point(69, 153);
            this.txtDependentNameBeng.Name = "txtDependentNameBeng";
            this.txtDependentNameBeng.Size = new System.Drawing.Size(386, 24);
            this.txtDependentNameBeng.TabIndex = 3;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(69, 133);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(164, 13);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "Dependent Name (Bangla) :";
            // 
            // cboRelation
            // 
            this.cboRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRelation.Enabled = false;
            this.cboRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRelation.ForeColor = System.Drawing.Color.Blue;
            this.cboRelation.FormattingEnabled = true;
            this.cboRelation.Location = new System.Drawing.Point(307, 201);
            this.cboRelation.Name = "cboRelation";
            this.cboRelation.Size = new System.Drawing.Size(148, 26);
            this.cboRelation.TabIndex = 6;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(307, 182);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(128, 13);
            this.smartLabel6.TabIndex = 11;
            this.smartLabel6.Text = "Dependent Relation :";
            // 
            // chkDependStatus
            // 
            this.chkDependStatus.AutoSize = true;
            this.chkDependStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDependStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDependStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDependStatus.ForeColor = System.Drawing.Color.Black;
            this.chkDependStatus.Location = new System.Drawing.Point(181, 202);
            this.chkDependStatus.Name = "chkDependStatus";
            this.chkDependStatus.Size = new System.Drawing.Size(122, 22);
            this.chkDependStatus.TabIndex = 5;
            this.chkDependStatus.Text = "Is Dependent ?";
            this.chkDependStatus.UseVisualStyleBackColor = true;
            this.chkDependStatus.CheckedChanged += new System.EventHandler(this.chkDependStatus_CheckedChanged);
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDOB.Location = new System.Drawing.Point(69, 202);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(94, 24);
            this.txtDOB.TabIndex = 4;
            this.txtDOB.ValidatingType = typeof(System.DateTime);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(69, 181);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(41, 13);
            this.smartLabel7.TabIndex = 14;
            this.smartLabel7.Text = "DOB :";
            // 
            // lvEmployeeDependent
            // 
            this.lvEmployeeDependent.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvEmployeeDependent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmployeeDependent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmployeeDependent.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployeeDependent.FullRowSelect = true;
            this.lvEmployeeDependent.GridLines = true;
            this.lvEmployeeDependent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmployeeDependent.Location = new System.Drawing.Point(-1, 289);
            this.lvEmployeeDependent.Name = "lvEmployeeDependent";
            this.lvEmployeeDependent.Size = new System.Drawing.Size(911, 317);
            this.lvEmployeeDependent.TabIndex = 15;
            this.lvEmployeeDependent.UseCompatibleStateImageBehavior = false;
            this.lvEmployeeDependent.View = System.Windows.Forms.View.Details;
            this.lvEmployeeDependent.SelectedIndexChanged += new System.EventHandler(this.lvEmployeeDependent_SelectedIndexChanged);
            this.lvEmployeeDependent.Click += new System.EventHandler(this.lvEmployeeDependent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUploadImage);
            this.groupBox2.Controls.Add(this.pbImage);
            this.groupBox2.Location = new System.Drawing.Point(698, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 267);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Location = new System.Drawing.Point(26, 226);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(155, 31);
            this.btnUploadImage.TabIndex = 7;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(7, 17);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(185, 204);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(461, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(482, 62);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 13);
            this.lblInfo.TabIndex = 152;
            this.lblInfo.Text = "Info";
            // 
            // txtDependID
            // 
            this.txtDependID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtDependID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDependID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDependID.Location = new System.Drawing.Point(69, 34);
            this.txtDependID.Name = "txtDependID";
            this.txtDependID.ReadOnly = true;
            this.txtDependID.Size = new System.Drawing.Size(152, 24);
            this.txtDependID.TabIndex = 153;
            this.txtDependID.TabStop = false;
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(456, 91);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 192;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.ForeColor = System.Drawing.Color.Red;
            this.smartLabel8.Location = new System.Drawing.Point(456, 148);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(21, 22);
            this.smartLabel8.TabIndex = 193;
            this.smartLabel8.Text = "*";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.ForeColor = System.Drawing.Color.Red;
            this.smartLabel9.Location = new System.Drawing.Point(456, 198);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(21, 22);
            this.smartLabel9.TabIndex = 194;
            this.smartLabel9.Text = "*";
            // 
            // frmEmployeeDependent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(911, 730);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.smartLabel3);
            this.isEnterTabAllow = true;
            this.Name = "frmEmployeeDependent";
            this.Load += new System.EventHandler(this.frmEmployeeDependent_Load);
            this.Controls.SetChildIndex(this.smartLabel3, 0);
            this.Controls.SetChildIndex(this.txtSerial, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtEmpID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartNumericTextBox txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDependentName;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtDependentNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboRelation;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartCheckBox chkDependStatus;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartDateTextBox txtDOB;
        private AtiqsControlLibrary.SmartListViewDetails lvEmployeeDependent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUploadImage;
        private AtiqsControlLibrary.SmartLabel lblInfo;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDependID;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
    }
}
