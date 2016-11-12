namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmPharmacyLocation
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboBuilding = new AtiqsControlLibrary.SmartComboBox();
            this.cboFloorNo = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtBlockNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtPharmacyName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtContactPerson = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.lvPharmacyLocation = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtPriority = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtPhoneNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtPharmacyLocID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.TabIndex = 45;
            this.btnTopClose.TabStop = false;
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(371, 10);
            this.frmLabel.Size = new System.Drawing.Size(139, 33);
            this.frmLabel.Text = "Pharmacy ";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtPharmacyLocID);
            this.pnlMain.Controls.Add(this.txtPhoneNo);
            this.pnlMain.Controls.Add(this.txtPriority);
            this.pnlMain.Controls.Add(this.lvPharmacyLocation);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtContactPerson);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtPharmacyName);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtBlockNo);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboFloorNo);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboBuilding);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 512);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(638, 572);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(528, 572);
            this.btnSave.TabIndex = 8;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(64, 572);
            this.btnDelete.Size = new System.Drawing.Size(39, 39);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.TabStop = false;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(419, 572);
            this.btnNew.TabStop = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(747, 572);
            this.btnClose.TabIndex = 40;
            this.btnClose.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(109, 572);
            this.btnPrint.Size = new System.Drawing.Size(42, 39);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.TabStop = false;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(85, 42);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(62, 15);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Building :";
            // 
            // cboBuilding
            // 
            this.cboBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuilding.ForeColor = System.Drawing.Color.Blue;
            this.cboBuilding.FormattingEnabled = true;
            this.cboBuilding.Location = new System.Drawing.Point(169, 38);
            this.cboBuilding.Name = "cboBuilding";
            this.cboBuilding.Size = new System.Drawing.Size(260, 26);
            this.cboBuilding.TabIndex = 0;
            // 
            // cboFloorNo
            // 
            this.cboFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorNo.ForeColor = System.Drawing.Color.Blue;
            this.cboFloorNo.FormattingEnabled = true;
            this.cboFloorNo.Location = new System.Drawing.Point(525, 38);
            this.cboFloorNo.Name = "cboFloorNo";
            this.cboFloorNo.Size = new System.Drawing.Size(84, 26);
            this.cboFloorNo.TabIndex = 1;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(469, 42);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(43, 15);
            this.smartLabel2.TabIndex = 2;
            this.smartLabel2.Text = "Floor :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(465, 74);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(47, 15);
            this.smartLabel3.TabIndex = 4;
            this.smartLabel3.Text = "Block :";
            // 
            // txtBlockNo
            // 
            this.txtBlockNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBlockNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlockNo.Location = new System.Drawing.Point(525, 71);
            this.txtBlockNo.Name = "txtBlockNo";
            this.txtBlockNo.Size = new System.Drawing.Size(84, 24);
            this.txtBlockNo.TabIndex = 4;
            // 
            // txtPharmacyName
            // 
            this.txtPharmacyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPharmacyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharmacyName.Location = new System.Drawing.Point(169, 71);
            this.txtPharmacyName.Name = "txtPharmacyName";
            this.txtPharmacyName.Size = new System.Drawing.Size(260, 24);
            this.txtPharmacyName.TabIndex = 3;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(37, 74);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(103, 15);
            this.smartLabel4.TabIndex = 6;
            this.smartLabel4.Text = "Pharmacy Name :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(619, 74);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(66, 15);
            this.smartLabel5.TabIndex = 8;
            this.smartLabel5.Text = "Phone No :";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.Location = new System.Drawing.Point(169, 101);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(260, 24);
            this.txtContactPerson.TabIndex = 6;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(48, 104);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(98, 15);
            this.smartLabel6.TabIndex = 10;
            this.smartLabel6.Text = "Contact Person :";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(619, 42);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(58, 15);
            this.smartLabel7.TabIndex = 12;
            this.smartLabel7.Text = "Priority :";
            this.smartLabel7.Click += new System.EventHandler(this.smartLabel7_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(525, 101);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(288, 24);
            this.txtRemarks.TabIndex = 7;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(445, 104);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(65, 15);
            this.smartLabel8.TabIndex = 14;
            this.smartLabel8.Text = "Remarks :";
            // 
            // lvPharmacyLocation
            // 
            this.lvPharmacyLocation.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvPharmacyLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPharmacyLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPharmacyLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPharmacyLocation.FullRowSelect = true;
            this.lvPharmacyLocation.GridLines = true;
            this.lvPharmacyLocation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPharmacyLocation.Location = new System.Drawing.Point(-1, 134);
            this.lvPharmacyLocation.Name = "lvPharmacyLocation";
            this.lvPharmacyLocation.Size = new System.Drawing.Size(863, 377);
            this.lvPharmacyLocation.TabIndex = 16;
            this.lvPharmacyLocation.UseCompatibleStateImageBehavior = false;
            this.lvPharmacyLocation.View = System.Windows.Forms.View.Details;
            this.lvPharmacyLocation.SelectedIndexChanged += new System.EventHandler(this.lvPharmacyLocation_SelectedIndexChanged);
            // 
            // txtPriority
            // 
            this.txtPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriority.Location = new System.Drawing.Point(700, 39);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(113, 24);
            this.txtPriority.TabIndex = 2;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(700, 71);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(113, 24);
            this.txtPhoneNo.TabIndex = 5;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(121, 11);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(27, 15);
            this.smartLabel9.TabIndex = 74;
            this.smartLabel9.Text = "ID :";
            // 
            // txtPharmacyLocID
            // 
            this.txtPharmacyLocID.BackColor = System.Drawing.Color.Linen;
            this.txtPharmacyLocID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPharmacyLocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharmacyLocID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPharmacyLocID.Location = new System.Drawing.Point(169, 8);
            this.txtPharmacyLocID.Name = "txtPharmacyLocID";
            this.txtPharmacyLocID.ReadOnly = true;
            this.txtPharmacyLocID.Size = new System.Drawing.Size(172, 24);
            this.txtPharmacyLocID.TabIndex = 73;
            this.txtPharmacyLocID.TabStop = false;
            // 
            // frmPharmacyLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmPharmacyLocation";
            this.Load += new System.EventHandler(this.frmPharmacyLocation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtContactPerson;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtPharmacyName;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtBlockNo;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboFloorNo;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboBuilding;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvPharmacyLocation;
        private AtiqsControlLibrary.SmartNumericTextBox txtPriority;
        private AtiqsControlLibrary.SmartTextBox txtPhoneNo;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPharmacyLocID;
    }
}
