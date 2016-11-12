namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOprtheter
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
            this.cboStattus = new AtiqsControlLibrary.SmartComboBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtInchargeID = new AtiqsControlLibrary.SmartTextBox();
            this.txtPhoneNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtFloorNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtBuildID = new AtiqsControlLibrary.SmartTextBox();
            this.txttheaterTitle = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txttheaterId = new AtiqsControlLibrary.SmartTextBox();
            this.txtBlockNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtNoofFacilities = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lvwTheaterConfig = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRoomNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepSpeci = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1013, 1);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(386, 6);
            this.frmLabel.Size = new System.Drawing.Size(283, 33);
            this.frmLabel.TabIndex = 17;
            this.frmLabel.Text = "Theater  Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.cboDepID);
            this.pnlMain.Controls.Add(this.cboDepSpeci);
            this.pnlMain.Controls.Add(this.txtRoomNo);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.lvwTheaterConfig);
            this.pnlMain.Controls.Add(this.txtNoofFacilities);
            this.pnlMain.Controls.Add(this.txtBlockNo);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txttheaterId);
            this.pnlMain.Controls.Add(this.cboStattus);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtInchargeID);
            this.pnlMain.Controls.Add(this.txtPhoneNo);
            this.pnlMain.Controls.Add(this.txtFloorNo);
            this.pnlMain.Controls.Add(this.txtBuildID);
            this.pnlMain.Controls.Add(this.txttheaterTitle);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Size = new System.Drawing.Size(1067, 577);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1067, 51);
            this.pnlTop.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(610, 639);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(496, 639);
            this.btnSave.TabIndex = 12;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(724, 639);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(382, 639);
            this.btnNew.TabIndex = 15;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(952, 639);
            this.btnClose.TabIndex = 16;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(838, 639);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 678);
            this.groupBox1.Size = new System.Drawing.Size(1067, 25);
            // 
            // cboStattus
            // 
            this.cboStattus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStattus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStattus.ForeColor = System.Drawing.Color.Blue;
            this.cboStattus.FormattingEnabled = true;
            this.cboStattus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStattus.Location = new System.Drawing.Point(707, 168);
            this.cboStattus.Name = "cboStattus";
            this.cboStattus.Size = new System.Drawing.Size(310, 26);
            this.cboStattus.TabIndex = 10;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(707, 141);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(310, 24);
            this.txtRemarks.TabIndex = 9;
            // 
            // txtInchargeID
            // 
            this.txtInchargeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInchargeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInchargeID.Location = new System.Drawing.Point(707, 228);
            this.txtInchargeID.MaxLength = 30;
            this.txtInchargeID.Name = "txtInchargeID";
            this.txtInchargeID.Size = new System.Drawing.Size(310, 24);
            this.txtInchargeID.TabIndex = 9;
            this.txtInchargeID.Visible = false;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(707, 112);
            this.txtPhoneNo.MaxLength = 100;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(310, 24);
            this.txtPhoneNo.TabIndex = 8;
            // 
            // txtFloorNo
            // 
            this.txtFloorNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloorNo.Location = new System.Drawing.Point(152, 132);
            this.txtFloorNo.MaxLength = 2;
            this.txtFloorNo.Name = "txtFloorNo";
            this.txtFloorNo.Size = new System.Drawing.Size(369, 24);
            this.txtFloorNo.TabIndex = 3;
            // 
            // txtBuildID
            // 
            this.txtBuildID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuildID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildID.Location = new System.Drawing.Point(152, 78);
            this.txtBuildID.MaxLength = 3;
            this.txtBuildID.Name = "txtBuildID";
            this.txtBuildID.Size = new System.Drawing.Size(369, 24);
            this.txtBuildID.TabIndex = 1;
            // 
            // txttheaterTitle
            // 
            this.txttheaterTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttheaterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttheaterTitle.Location = new System.Drawing.Point(152, 51);
            this.txttheaterTitle.MaxLength = 200;
            this.txttheaterTitle.Name = "txttheaterTitle";
            this.txttheaterTitle.Size = new System.Drawing.Size(369, 24);
            this.txttheaterTitle.TabIndex = 0;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(641, 170);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(55, 16);
            this.smartLabel9.TabIndex = 24;
            this.smartLabel9.Text = "Status:";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(622, 144);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(74, 16);
            this.smartLabel8.TabIndex = 23;
            this.smartLabel8.Text = "Remarks:";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(605, 232);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(91, 16);
            this.smartLabel7.TabIndex = 21;
            this.smartLabel7.Text = "Incharge ID:";
            this.smartLabel7.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(616, 116);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(80, 16);
            this.smartLabel6.TabIndex = 19;
            this.smartLabel6.Text = "Phone No:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(41, 54);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(101, 16);
            this.smartLabel5.TabIndex = 17;
            this.smartLabel5.Text = "Theater Title:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(26, 190);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(116, 16);
            this.smartLabel4.TabIndex = 15;
            this.smartLabel4.Text = "No of Facilities:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(70, 135);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(72, 16);
            this.smartLabel3.TabIndex = 13;
            this.smartLabel3.Text = "Floor No:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(76, 81);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(66, 16);
            this.smartLabel2.TabIndex = 11;
            this.smartLabel2.Text = "Build ID:";
            // 
            // txttheaterId
            // 
            this.txttheaterId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttheaterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttheaterId.Location = new System.Drawing.Point(329, 3);
            this.txttheaterId.Name = "txttheaterId";
            this.txttheaterId.Size = new System.Drawing.Size(298, 24);
            this.txttheaterId.TabIndex = 13;
            this.txttheaterId.Visible = false;
            // 
            // txtBlockNo
            // 
            this.txtBlockNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBlockNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlockNo.Location = new System.Drawing.Point(152, 159);
            this.txtBlockNo.MaxLength = 30;
            this.txtBlockNo.Name = "txtBlockNo";
            this.txtBlockNo.Size = new System.Drawing.Size(369, 24);
            this.txtBlockNo.TabIndex = 4;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(63, 165);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(79, 16);
            this.smartLabel1.TabIndex = 26;
            this.smartLabel1.Text = "Block  No:";
            // 
            // txtNoofFacilities
            // 
            this.txtNoofFacilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoofFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoofFacilities.Location = new System.Drawing.Point(152, 187);
            this.txtNoofFacilities.Name = "txtNoofFacilities";
            this.txtNoofFacilities.Size = new System.Drawing.Size(369, 24);
            this.txtNoofFacilities.TabIndex = 5;
            // 
            // lvwTheaterConfig
            // 
            this.lvwTheaterConfig.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwTheaterConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwTheaterConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwTheaterConfig.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTheaterConfig.FullRowSelect = true;
            this.lvwTheaterConfig.GridLines = true;
            this.lvwTheaterConfig.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwTheaterConfig.Location = new System.Drawing.Point(18, 263);
            this.lvwTheaterConfig.Name = "lvwTheaterConfig";
            this.lvwTheaterConfig.Size = new System.Drawing.Size(1032, 295);
            this.lvwTheaterConfig.TabIndex = 27;
            this.lvwTheaterConfig.UseCompatibleStateImageBehavior = false;
            this.lvwTheaterConfig.View = System.Windows.Forms.View.Details;
            this.lvwTheaterConfig.SelectedIndexChanged += new System.EventHandler(this.lvwTheaterConfig_SelectedIndexChanged);
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.Location = new System.Drawing.Point(152, 105);
            this.txtRoomNo.MaxLength = 4;
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(369, 24);
            this.txtRoomNo.TabIndex = 2;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(65, 108);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(77, 16);
            this.smartLabel10.TabIndex = 29;
            this.smartLabel10.Text = "Room No:";
            // 
            // cboDepSpeci
            // 
            this.cboDepSpeci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepSpeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepSpeci.ForeColor = System.Drawing.Color.Blue;
            this.cboDepSpeci.FormattingEnabled = true;
            this.cboDepSpeci.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboDepSpeci.Location = new System.Drawing.Point(707, 54);
            this.cboDepSpeci.Name = "cboDepSpeci";
            this.cboDepSpeci.Size = new System.Drawing.Size(310, 26);
            this.cboDepSpeci.TabIndex = 6;
            // 
            // cboDepID
            // 
            this.cboDepID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepID.ForeColor = System.Drawing.Color.Blue;
            this.cboDepID.FormattingEnabled = true;
            this.cboDepID.Location = new System.Drawing.Point(707, 83);
            this.cboDepID.Name = "cboDepID";
            this.cboDepID.Size = new System.Drawing.Size(310, 26);
            this.cboDepID.TabIndex = 7;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(619, 57);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(77, 16);
            this.smartLabel11.TabIndex = 32;
            this.smartLabel11.Text = "Dep. Spe:";
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(632, 86);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(64, 16);
            this.smartLabel12.TabIndex = 33;
            this.smartLabel12.Text = "Dep. ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOprtheter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1067, 703);
            this.Controls.Add(this.button1);
            this.Name = "frmOprtheter";
            this.Load += new System.EventHandler(this.frmOprtheterNew_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboStattus;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtInchargeID;
        private AtiqsControlLibrary.SmartTextBox txtPhoneNo;
        private AtiqsControlLibrary.SmartTextBox txtFloorNo;
        private AtiqsControlLibrary.SmartTextBox txtBuildID;
        private AtiqsControlLibrary.SmartTextBox txttheaterTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txttheaterId;
        private AtiqsControlLibrary.SmartTextBox txtBlockNo;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartNumericTextBox txtNoofFacilities;
        private AtiqsControlLibrary.SmartListViewDetails lvwTheaterConfig;
        private AtiqsControlLibrary.SmartTextBox txtRoomNo;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartComboBox cboDepID;
        private AtiqsControlLibrary.SmartComboBox cboDepSpeci;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private System.Windows.Forms.Button button1;
    }
}
