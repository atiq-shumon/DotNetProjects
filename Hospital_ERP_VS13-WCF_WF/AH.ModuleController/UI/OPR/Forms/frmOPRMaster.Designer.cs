namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOPRMaster
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
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtOprID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtOperationTitle = new AtiqsControlLibrary.SmartTextBox();
            this.cboOperationType = new AtiqsControlLibrary.SmartComboBox();
            this.cboGradeName = new AtiqsControlLibrary.SmartComboBox();
            this.cboAnesthesiaName = new AtiqsControlLibrary.SmartComboBox();
            this.txtOperationFees = new AtiqsControlLibrary.SmartTextBox();
            this.txtDoctorFees = new AtiqsControlLibrary.SmartTextBox();
            this.txtAnesthesiaFees = new AtiqsControlLibrary.SmartTextBox();
            this.txtexpectedHour = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.cboActive = new AtiqsControlLibrary.SmartComboBox();
            this.lvwOperationMaster = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtAssistantFees = new AtiqsControlLibrary.SmartTextBox();
            this.lblAssistantFees = new AtiqsControlLibrary.SmartLabel();
            this.lblMismatch = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(822, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(324, 6);
            this.frmLabel.Size = new System.Drawing.Size(220, 33);
            this.frmLabel.TabIndex = 15;
            this.frmLabel.Text = "Operation Master";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblMismatch);
            this.pnlMain.Controls.Add(this.txtAssistantFees);
            this.pnlMain.Controls.Add(this.lblAssistantFees);
            this.pnlMain.Controls.Add(this.lvwOperationMaster);
            this.pnlMain.Controls.Add(this.cboActive);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtexpectedHour);
            this.pnlMain.Controls.Add(this.txtAnesthesiaFees);
            this.pnlMain.Controls.Add(this.txtDoctorFees);
            this.pnlMain.Controls.Add(this.txtOperationFees);
            this.pnlMain.Controls.Add(this.cboAnesthesiaName);
            this.pnlMain.Controls.Add(this.cboGradeName);
            this.pnlMain.Controls.Add(this.cboOperationType);
            this.pnlMain.Controls.Add(this.txtOperationTitle);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtOprID);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Size = new System.Drawing.Size(876, 616);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(876, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(401, 679);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 679);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(515, 679);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(173, 679);
            this.btnNew.TabIndex = 13;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(743, 679);
            this.btnClose.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(629, 679);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 718);
            this.groupBox1.Size = new System.Drawing.Size(876, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(72, 48);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(83, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Operation ID:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(48, 73);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(111, 14);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Operation Title:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(44, 101);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(114, 14);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "Operation Type:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(63, 132);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(94, 14);
            this.smartLabel4.TabIndex = 3;
            this.smartLabel4.Text = "Grade Name:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(31, 162);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(126, 14);
            this.smartLabel5.TabIndex = 4;
            this.smartLabel5.Text = "Anesthesia Name:";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(482, 41);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(119, 16);
            this.smartLabel6.TabIndex = 5;
            this.smartLabel6.Text = "Operation Fees:";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(504, 70);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(97, 16);
            this.smartLabel7.TabIndex = 6;
            this.smartLabel7.Text = "Doctor Fees:";
            // 
            // txtOprID
            // 
            this.txtOprID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOprID.Enabled = false;
            this.txtOprID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOprID.Location = new System.Drawing.Point(163, 44);
            this.txtOprID.Name = "txtOprID";
            this.txtOprID.Size = new System.Drawing.Size(249, 24);
            this.txtOprID.TabIndex = 14;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(473, 101);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(128, 16);
            this.smartLabel8.TabIndex = 8;
            this.smartLabel8.Text = "Anesthesia Fees:";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(438, 158);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(163, 16);
            this.smartLabel9.TabIndex = 9;
            this.smartLabel9.Text = "Expected time in Hour:";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(527, 188);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(74, 16);
            this.smartLabel10.TabIndex = 10;
            this.smartLabel10.Text = "Remarks:";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(104, 191);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(53, 14);
            this.smartLabel11.TabIndex = 11;
            this.smartLabel11.Text = "Active:";
            // 
            // txtOperationTitle
            // 
            this.txtOperationTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOperationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperationTitle.Location = new System.Drawing.Point(163, 71);
            this.txtOperationTitle.Name = "txtOperationTitle";
            this.txtOperationTitle.Size = new System.Drawing.Size(249, 24);
            this.txtOperationTitle.TabIndex = 0;
            // 
            // cboOperationType
            // 
            this.cboOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperationType.ForeColor = System.Drawing.Color.Blue;
            this.cboOperationType.FormattingEnabled = true;
            this.cboOperationType.Location = new System.Drawing.Point(163, 98);
            this.cboOperationType.Name = "cboOperationType";
            this.cboOperationType.Size = new System.Drawing.Size(249, 26);
            this.cboOperationType.TabIndex = 1;
            // 
            // cboGradeName
            // 
            this.cboGradeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGradeName.ForeColor = System.Drawing.Color.Blue;
            this.cboGradeName.FormattingEnabled = true;
            this.cboGradeName.Location = new System.Drawing.Point(163, 128);
            this.cboGradeName.Name = "cboGradeName";
            this.cboGradeName.Size = new System.Drawing.Size(249, 26);
            this.cboGradeName.TabIndex = 2;
            // 
            // cboAnesthesiaName
            // 
            this.cboAnesthesiaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnesthesiaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnesthesiaName.ForeColor = System.Drawing.Color.Blue;
            this.cboAnesthesiaName.FormattingEnabled = true;
            this.cboAnesthesiaName.Location = new System.Drawing.Point(163, 159);
            this.cboAnesthesiaName.Name = "cboAnesthesiaName";
            this.cboAnesthesiaName.Size = new System.Drawing.Size(249, 26);
            this.cboAnesthesiaName.TabIndex = 3;
            // 
            // txtOperationFees
            // 
            this.txtOperationFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOperationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperationFees.Location = new System.Drawing.Point(614, 41);
            this.txtOperationFees.Name = "txtOperationFees";
            this.txtOperationFees.Size = new System.Drawing.Size(163, 24);
            this.txtOperationFees.TabIndex = 5;
            // 
            // txtDoctorFees
            // 
            this.txtDoctorFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorFees.Location = new System.Drawing.Point(614, 69);
            this.txtDoctorFees.Name = "txtDoctorFees";
            this.txtDoctorFees.Size = new System.Drawing.Size(163, 24);
            this.txtDoctorFees.TabIndex = 6;
            // 
            // txtAnesthesiaFees
            // 
            this.txtAnesthesiaFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnesthesiaFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnesthesiaFees.Location = new System.Drawing.Point(614, 98);
            this.txtAnesthesiaFees.Name = "txtAnesthesiaFees";
            this.txtAnesthesiaFees.Size = new System.Drawing.Size(163, 24);
            this.txtAnesthesiaFees.TabIndex = 7;
            // 
            // txtexpectedHour
            // 
            this.txtexpectedHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtexpectedHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexpectedHour.Location = new System.Drawing.Point(614, 155);
            this.txtexpectedHour.Name = "txtexpectedHour";
            this.txtexpectedHour.Size = new System.Drawing.Size(163, 24);
            this.txtexpectedHour.TabIndex = 9;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(614, 185);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(255, 52);
            this.txtRemarks.TabIndex = 10;
            // 
            // cboActive
            // 
            this.cboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActive.ForeColor = System.Drawing.Color.Blue;
            this.cboActive.FormattingEnabled = true;
            this.cboActive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboActive.Location = new System.Drawing.Point(163, 189);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(249, 26);
            this.cboActive.TabIndex = 4;
            // 
            // lvwOperationMaster
            // 
            this.lvwOperationMaster.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwOperationMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwOperationMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwOperationMaster.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwOperationMaster.FullRowSelect = true;
            this.lvwOperationMaster.GridLines = true;
            this.lvwOperationMaster.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwOperationMaster.Location = new System.Drawing.Point(5, 243);
            this.lvwOperationMaster.Name = "lvwOperationMaster";
            this.lvwOperationMaster.Size = new System.Drawing.Size(864, 363);
            this.lvwOperationMaster.TabIndex = 22;
            this.lvwOperationMaster.UseCompatibleStateImageBehavior = false;
            this.lvwOperationMaster.View = System.Windows.Forms.View.Details;
            this.lvwOperationMaster.SelectedIndexChanged += new System.EventHandler(this.lvwOperationMaster_SelectedIndexChanged);
            // 
            // txtAssistantFees
            // 
            this.txtAssistantFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssistantFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssistantFees.Location = new System.Drawing.Point(614, 125);
            this.txtAssistantFees.Name = "txtAssistantFees";
            this.txtAssistantFees.Size = new System.Drawing.Size(163, 24);
            this.txtAssistantFees.TabIndex = 8;
            // 
            // lblAssistantFees
            // 
            this.lblAssistantFees.AutoSize = true;
            this.lblAssistantFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAssistantFees.Location = new System.Drawing.Point(487, 128);
            this.lblAssistantFees.Name = "lblAssistantFees";
            this.lblAssistantFees.Size = new System.Drawing.Size(114, 16);
            this.lblAssistantFees.TabIndex = 24;
            this.lblAssistantFees.Text = "Assistant Fees:";
            // 
            // lblMismatch
            // 
            this.lblMismatch.AutoSize = true;
            this.lblMismatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMismatch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMismatch.ForeColor = System.Drawing.Color.Red;
            this.lblMismatch.Location = new System.Drawing.Point(613, 7);
            this.lblMismatch.Name = "lblMismatch";
            this.lblMismatch.Size = new System.Drawing.Size(0, 16);
            this.lblMismatch.TabIndex = 25;
            // 
            // frmOPRMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(876, 743);
            this.isEnterTabAllow = true;
            this.Name = "frmOPRMaster";
            this.Load += new System.EventHandler(this.frmOPRMaster_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboActive;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtexpectedHour;
        private AtiqsControlLibrary.SmartTextBox txtAnesthesiaFees;
        private AtiqsControlLibrary.SmartTextBox txtDoctorFees;
        private AtiqsControlLibrary.SmartTextBox txtOperationFees;
        private AtiqsControlLibrary.SmartComboBox cboAnesthesiaName;
        private AtiqsControlLibrary.SmartComboBox cboGradeName;
        private AtiqsControlLibrary.SmartComboBox cboOperationType;
        private AtiqsControlLibrary.SmartTextBox txtOperationTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartTextBox txtOprID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwOperationMaster;
        private AtiqsControlLibrary.SmartTextBox txtAssistantFees;
        private AtiqsControlLibrary.SmartLabel lblAssistantFees;
        private AtiqsControlLibrary.SmartLabel lblMismatch;
    }
}
