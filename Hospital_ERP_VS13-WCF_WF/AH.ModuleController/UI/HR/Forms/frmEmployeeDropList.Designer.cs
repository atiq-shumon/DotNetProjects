namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmEmployeeDropList
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
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmpID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.dtDropDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboDropType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.dtDropEffectiveDate = new System.Windows.Forms.DateTimePicker();
            this.txtListSerial = new AtiqsControlLibrary.SmartTextBox();
            this.lvDropList = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.txtVerifiedBy = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtVerifiedByName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtName = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(390, 9);
            this.frmLabel.Size = new System.Drawing.Size(320, 33);
            this.frmLabel.Text = "Employee Drop List Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtVerifiedByName);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtVerifiedBy);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.lvDropList);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.dtDropEffectiveDate);
            this.pnlMain.Controls.Add(this.smartLabel18);
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.dtDropDate);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboDropType);
            this.pnlMain.Size = new System.Drawing.Size(1132, 800);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1132, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(904, 719);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(791, 719);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(289, 719);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(678, 719);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1018, 719);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(343, 719);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 759);
            this.groupBox1.Size = new System.Drawing.Size(1132, 25);
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.Location = new System.Drawing.Point(17, 152);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(60, 13);
            this.smartLabel18.TabIndex = 263;
            this.smartLabel18.Text = "Emp ID  :";
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(17, 173);
            this.txtEmpID.MaxLength = 45;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(106, 24);
            this.txtEmpID.TabIndex = 0;
            this.txtEmpID.Leave += new System.EventHandler(this.txtEmpID_Leave);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(232, 201);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(73, 13);
            this.smartLabel2.TabIndex = 261;
            this.smartLabel2.Text = "Drop Date :";
            // 
            // dtDropDate
            // 
            this.dtDropDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDropDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDropDate.Location = new System.Drawing.Point(232, 221);
            this.dtDropDate.Name = "dtDropDate";
            this.dtDropDate.Size = new System.Drawing.Size(111, 26);
            this.dtDropDate.TabIndex = 2;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(17, 201);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(74, 13);
            this.smartLabel1.TabIndex = 258;
            this.smartLabel1.Text = "Drop Type :";
            // 
            // cboDropType
            // 
            this.cboDropType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDropType.ForeColor = System.Drawing.Color.Blue;
            this.cboDropType.FormattingEnabled = true;
            this.cboDropType.Location = new System.Drawing.Point(17, 221);
            this.cboDropType.Name = "cboDropType";
            this.cboDropType.Size = new System.Drawing.Size(140, 26);
            this.cboDropType.TabIndex = 1;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(341, 201);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(128, 13);
            this.smartLabel3.TabIndex = 265;
            this.smartLabel3.Text = "Drop Effective Date :";
            // 
            // dtDropEffectiveDate
            // 
            this.dtDropEffectiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDropEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDropEffectiveDate.Location = new System.Drawing.Point(349, 221);
            this.dtDropEffectiveDate.Name = "dtDropEffectiveDate";
            this.dtDropEffectiveDate.Size = new System.Drawing.Size(119, 26);
            this.dtDropEffectiveDate.TabIndex = 3;
            // 
            // txtListSerial
            // 
            this.txtListSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListSerial.Location = new System.Drawing.Point(283, 728);
            this.txtListSerial.MaxLength = 45;
            this.txtListSerial.Name = "txtListSerial";
            this.txtListSerial.Size = new System.Drawing.Size(44, 24);
            this.txtListSerial.TabIndex = 266;
            this.txtListSerial.Visible = false;
            // 
            // lvDropList
            // 
            this.lvDropList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDropList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDropList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDropList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDropList.FullRowSelect = true;
            this.lvDropList.GridLines = true;
            this.lvDropList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDropList.Location = new System.Drawing.Point(-1, 318);
            this.lvDropList.Name = "lvDropList";
            this.lvDropList.Size = new System.Drawing.Size(1132, 477);
            this.lvDropList.TabIndex = 266;
            this.lvDropList.UseCompatibleStateImageBehavior = false;
            this.lvDropList.View = System.Windows.Forms.View.Details;
            this.lvDropList.SelectedIndexChanged += new System.EventHandler(this.lvDropList_SelectedIndexChanged);
            this.lvDropList.Click += new System.EventHandler(this.lvDropList_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(17, 272);
            this.txtRemarks.MaxLength = 45;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(1102, 24);
            this.txtRemarks.TabIndex = 5;
            this.txtRemarks.Text = "N/A";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(14, 253);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(64, 13);
            this.smartLabel4.TabIndex = 268;
            this.smartLabel4.Text = "Remarks :";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(129, 173);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 13);
            this.lblInfo.TabIndex = 269;
            this.lblInfo.Text = "Info";
            // 
            // txtVerifiedBy
            // 
            this.txtVerifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVerifiedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifiedBy.Location = new System.Drawing.Point(474, 221);
            this.txtVerifiedBy.MaxLength = 45;
            this.txtVerifiedBy.Name = "txtVerifiedBy";
            this.txtVerifiedBy.Size = new System.Drawing.Size(112, 24);
            this.txtVerifiedBy.TabIndex = 4;
            this.txtVerifiedBy.Leave += new System.EventHandler(this.txtVerifiedBy_Leave);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(473, 201);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(101, 13);
            this.smartLabel5.TabIndex = 271;
            this.smartLabel5.Text = "Verified By (ID) :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(162, 219);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(59, 29);
            this.btnShow.TabIndex = 272;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtVerifiedByName
            // 
            this.txtVerifiedByName.BackColor = System.Drawing.Color.Linen;
            this.txtVerifiedByName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVerifiedByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifiedByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtVerifiedByName.Location = new System.Drawing.Point(592, 221);
            this.txtVerifiedByName.Name = "txtVerifiedByName";
            this.txtVerifiedByName.ReadOnly = true;
            this.txtVerifiedByName.Size = new System.Drawing.Size(527, 24);
            this.txtVerifiedByName.TabIndex = 273;
            this.txtVerifiedByName.TabStop = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(589, 201);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(120, 13);
            this.smartLabel6.TabIndex = 274;
            this.smartLabel6.Text = "Verified By (Name) :";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(18, 719);
            this.txtName.MaxLength = 45;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(60, 24);
            this.txtName.TabIndex = 275;
            this.txtName.Visible = false;
            // 
            // frmEmployeeDropList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1132, 784);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtListSerial);
            this.isEnterTabAllow = true;
            this.Name = "frmEmployeeDropList";
            this.Load += new System.EventHandler(this.frmEmployeeDropList_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtListSerial, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartTextBox txtEmpID;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.DateTimePicker dtDropDate;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDropType;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.DateTimePicker dtDropEffectiveDate;
        private AtiqsControlLibrary.SmartTextBox txtListSerial;
        private AtiqsControlLibrary.SmartListViewDetails lvDropList;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel lblInfo;
        private AtiqsControlLibrary.SmartTextBox txtVerifiedBy;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtVerifiedByName;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtName;
    }
}
