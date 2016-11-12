namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmStoreLocation
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
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtStoreID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtPhoneNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtPriority = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lvStoreLocation = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtContactPerson = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtStoreName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtBlockNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboFloorNo = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboBuilding = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.cboStoreType = new AtiqsControlLibrary.SmartComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(315, 10);
            this.frmLabel.Size = new System.Drawing.Size(185, 33);
            this.frmLabel.Text = "Store Location";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.cboStoreType);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtStoreID);
            this.pnlMain.Controls.Add(this.txtPhoneNo);
            this.pnlMain.Controls.Add(this.txtPriority);
            this.pnlMain.Controls.Add(this.lvStoreLocation);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtContactPerson);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtStoreName);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtBlockNo);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboFloorNo);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboBuilding);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(903, 506);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(903, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(673, 569);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(560, 569);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(42, 567);
            this.btnDelete.Size = new System.Drawing.Size(48, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(447, 569);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(787, 568);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(96, 566);
            this.btnPrint.Size = new System.Drawing.Size(43, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 609);
            this.groupBox1.Size = new System.Drawing.Size(903, 23);
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(18, 10);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(64, 18);
            this.smartLabel9.TabIndex = 93;
            this.smartLabel9.Text = "Store ID :";
            // 
            // txtStoreID
            // 
            this.txtStoreID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtStoreID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtStoreID.Location = new System.Drawing.Point(131, 7);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.ReadOnly = true;
            this.txtStoreID.Size = new System.Drawing.Size(172, 24);
            this.txtStoreID.TabIndex = 92;
            this.txtStoreID.TabStop = false;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(770, 70);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(113, 24);
            this.txtPhoneNo.TabIndex = 83;
            // 
            // txtPriority
            // 
            this.txtPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriority.Location = new System.Drawing.Point(770, 38);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(113, 24);
            this.txtPriority.TabIndex = 79;
            // 
            // lvStoreLocation
            // 
            this.lvStoreLocation.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvStoreLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStoreLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvStoreLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStoreLocation.FullRowSelect = true;
            this.lvStoreLocation.GridLines = true;
            this.lvStoreLocation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStoreLocation.Location = new System.Drawing.Point(-1, 130);
            this.lvStoreLocation.Name = "lvStoreLocation";
            this.lvStoreLocation.Size = new System.Drawing.Size(903, 372);
            this.lvStoreLocation.TabIndex = 91;
            this.lvStoreLocation.UseCompatibleStateImageBehavior = false;
            this.lvStoreLocation.View = System.Windows.Forms.View.Details;
            this.lvStoreLocation.SelectedIndexChanged += new System.EventHandler(this.lvStoreLocation_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(595, 100);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(288, 24);
            this.txtRemarks.TabIndex = 86;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(515, 103);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(68, 18);
            this.smartLabel8.TabIndex = 90;
            this.smartLabel8.Text = "Remarks :";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(689, 41);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(58, 18);
            this.smartLabel7.TabIndex = 89;
            this.smartLabel7.Text = "Priority :";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.Location = new System.Drawing.Point(131, 98);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(260, 24);
            this.txtContactPerson.TabIndex = 84;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(18, 101);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(103, 18);
            this.smartLabel6.TabIndex = 88;
            this.smartLabel6.Text = "Contact Person :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(689, 73);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(73, 18);
            this.smartLabel5.TabIndex = 87;
            this.smartLabel5.Text = "Phone No :";
            // 
            // txtStoreName
            // 
            this.txtStoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreName.Location = new System.Drawing.Point(595, 7);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(288, 24);
            this.txtStoreName.TabIndex = 80;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(498, 10);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(85, 18);
            this.smartLabel4.TabIndex = 85;
            this.smartLabel4.Text = "Store Name :";
            // 
            // txtBlockNo
            // 
            this.txtBlockNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBlockNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlockNo.Location = new System.Drawing.Point(595, 70);
            this.txtBlockNo.Name = "txtBlockNo";
            this.txtBlockNo.Size = new System.Drawing.Size(84, 24);
            this.txtBlockNo.TabIndex = 82;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(535, 73);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(48, 18);
            this.smartLabel3.TabIndex = 81;
            this.smartLabel3.Text = "Block :";
            // 
            // cboFloorNo
            // 
            this.cboFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorNo.ForeColor = System.Drawing.Color.Blue;
            this.cboFloorNo.FormattingEnabled = true;
            this.cboFloorNo.Location = new System.Drawing.Point(595, 37);
            this.cboFloorNo.Name = "cboFloorNo";
            this.cboFloorNo.Size = new System.Drawing.Size(84, 26);
            this.cboFloorNo.TabIndex = 77;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(539, 41);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(44, 18);
            this.smartLabel2.TabIndex = 78;
            this.smartLabel2.Text = "Floor :";
            // 
            // cboBuilding
            // 
            this.cboBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuilding.ForeColor = System.Drawing.Color.Blue;
            this.cboBuilding.FormattingEnabled = true;
            this.cboBuilding.Location = new System.Drawing.Point(131, 67);
            this.cboBuilding.Name = "cboBuilding";
            this.cboBuilding.Size = new System.Drawing.Size(260, 26);
            this.cboBuilding.TabIndex = 76;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(18, 71);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(66, 18);
            this.smartLabel1.TabIndex = 75;
            this.smartLabel1.Text = "Building :";
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(18, 40);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(79, 18);
            this.smartLabel14.TabIndex = 290;
            this.smartLabel14.Text = "Store Type :";
            // 
            // cboStoreType
            // 
            this.cboStoreType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreType.ForeColor = System.Drawing.Color.Blue;
            this.cboStoreType.FormattingEnabled = true;
            this.cboStoreType.Location = new System.Drawing.Point(131, 36);
            this.cboStoreType.Name = "cboStoreType";
            this.cboStoreType.Size = new System.Drawing.Size(260, 26);
            this.cboStoreType.TabIndex = 289;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(392, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 30);
            this.btnSearch.TabIndex = 291;
            this.btnSearch.Text = "Show";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmStoreLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(903, 632);
            this.isEnterTabAllow = true;
            this.Name = "frmStoreLocation";
            this.Load += new System.EventHandler(this.frmStoreLocation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtStoreID;
        private AtiqsControlLibrary.SmartTextBox txtPhoneNo;
        private AtiqsControlLibrary.SmartNumericTextBox txtPriority;
        private AtiqsControlLibrary.SmartListViewDetails lvStoreLocation;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtContactPerson;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtStoreName;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtBlockNo;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboFloorNo;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboBuilding;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartComboBox cboStoreType;
        private System.Windows.Forms.Button btnSearch;
    }
}
