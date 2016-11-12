namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmBedConfiguration
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
            this.lvwGroupDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.cbotheaterID = new AtiqsControlLibrary.SmartComboBox();
            this.txtbedID = new AtiqsControlLibrary.SmartTextBox();
            this.txtBedtTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtLocation = new AtiqsControlLibrary.SmartTextBox();
            this.cboStatus = new AtiqsControlLibrary.SmartComboBox();
            this.cboRegID = new AtiqsControlLibrary.SmartComboBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.cboActive = new AtiqsControlLibrary.SmartComboBox();
            this.cboRoomID = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(228, 33);
            this.frmLabel.TabIndex = 16;
            this.frmLabel.Text = "Bed Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboRoomID);
            this.pnlMain.Controls.Add(this.cboActive);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.cboRegID);
            this.pnlMain.Controls.Add(this.cboStatus);
            this.pnlMain.Controls.Add(this.txtLocation);
            this.pnlMain.Controls.Add(this.txtBedtTitle);
            this.pnlMain.Controls.Add(this.txtbedID);
            this.pnlMain.Controls.Add(this.cbotheaterID);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.lvwGroupDetails);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(-1, 64);
            this.pnlMain.Size = new System.Drawing.Size(839, 547);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(838, 58);
            this.pnlTop.TabIndex = 15;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(387, 616);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 616);
            this.btnSave.TabIndex = 9;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(501, 616);
            this.btnDelete.TabIndex = 12;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(159, 616);
            this.btnNew.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(729, 616);
            this.btnClose.TabIndex = 14;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(615, 616);
            this.btnPrint.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 657);
            this.groupBox1.Size = new System.Drawing.Size(838, 25);
            // 
            // lvwGroupDetails
            // 
            this.lvwGroupDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwGroupDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwGroupDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwGroupDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwGroupDetails.FullRowSelect = true;
            this.lvwGroupDetails.GridLines = true;
            this.lvwGroupDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwGroupDetails.Location = new System.Drawing.Point(6, 182);
            this.lvwGroupDetails.Name = "lvwGroupDetails";
            this.lvwGroupDetails.Size = new System.Drawing.Size(824, 357);
            this.lvwGroupDetails.TabIndex = 9;
            this.lvwGroupDetails.UseCompatibleStateImageBehavior = false;
            this.lvwGroupDetails.View = System.Windows.Forms.View.Details;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(511, 25);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(55, 16);
            this.smartLabel4.TabIndex = 26;
            this.smartLabel4.Text = "Status:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(41, 136);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(71, 16);
            this.smartLabel3.TabIndex = 25;
            this.smartLabel3.Text = "Location:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(40, 55);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(72, 16);
            this.smartLabel2.TabIndex = 24;
            this.smartLabel2.Text = "Room ID:";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(27, 24);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(85, 16);
            this.smartLabel1.TabIndex = 23;
            this.smartLabel1.Text = "Theater ID:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(53, 81);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(59, 16);
            this.smartLabel5.TabIndex = 28;
            this.smartLabel5.Text = "Bed ID:";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(37, 109);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(75, 16);
            this.smartLabel6.TabIndex = 29;
            this.smartLabel6.Text = "Bed Title:";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(508, 55);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(58, 16);
            this.smartLabel7.TabIndex = 30;
            this.smartLabel7.Text = "Reg Id:";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(492, 91);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(74, 16);
            this.smartLabel8.TabIndex = 31;
            this.smartLabel8.Text = "Remarks:";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(511, 132);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(55, 16);
            this.smartLabel9.TabIndex = 32;
            this.smartLabel9.Text = "Active:";
            // 
            // cbotheaterID
            // 
            this.cbotheaterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotheaterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotheaterID.ForeColor = System.Drawing.Color.Blue;
            this.cbotheaterID.FormattingEnabled = true;
            this.cbotheaterID.Location = new System.Drawing.Point(122, 23);
            this.cbotheaterID.Name = "cbotheaterID";
            this.cbotheaterID.Size = new System.Drawing.Size(274, 26);
            this.cbotheaterID.TabIndex = 0;
            this.cbotheaterID.SelectedIndexChanged += new System.EventHandler(this.cbotheaterID_SelectedIndexChanged);
            // 
            // txtbedID
            // 
            this.txtbedID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbedID.Location = new System.Drawing.Point(122, 80);
            this.txtbedID.Name = "txtbedID";
            this.txtbedID.Size = new System.Drawing.Size(274, 24);
            this.txtbedID.TabIndex = 2;
            // 
            // txtBedtTitle
            // 
            this.txtBedtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBedtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedtTitle.Location = new System.Drawing.Point(122, 106);
            this.txtBedtTitle.Name = "txtBedtTitle";
            this.txtBedtTitle.Size = new System.Drawing.Size(274, 24);
            this.txtBedtTitle.TabIndex = 3;
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(122, 132);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(274, 24);
            this.txtLocation.TabIndex = 4;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.Blue;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.ItemHeight = 18;
            this.cboStatus.Items.AddRange(new object[] {
            "Running",
            "Blocked",
            "Unblocked",
            "Closed"});
            this.cboStatus.Location = new System.Drawing.Point(585, 24);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(235, 26);
            this.cboStatus.TabIndex = 5;
            // 
            // cboRegID
            // 
            this.cboRegID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegID.ForeColor = System.Drawing.Color.Blue;
            this.cboRegID.FormattingEnabled = true;
            this.cboRegID.ItemHeight = 18;
            this.cboRegID.Location = new System.Drawing.Point(585, 53);
            this.cboRegID.Name = "cboRegID";
            this.cboRegID.Size = new System.Drawing.Size(235, 26);
            this.cboRegID.TabIndex = 6;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(585, 82);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(235, 44);
            this.txtRemarks.TabIndex = 7;
            // 
            // cboActive
            // 
            this.cboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActive.ForeColor = System.Drawing.Color.Blue;
            this.cboActive.FormattingEnabled = true;
            this.cboActive.ItemHeight = 18;
            this.cboActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboActive.Location = new System.Drawing.Point(585, 129);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(235, 26);
            this.cboActive.TabIndex = 8;
            // 
            // cboRoomID
            // 
            this.cboRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomID.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomID.FormattingEnabled = true;
            this.cboRoomID.Location = new System.Drawing.Point(122, 51);
            this.cboRoomID.Name = "cboRoomID";
            this.cboRoomID.Size = new System.Drawing.Size(273, 26);
            this.cboRoomID.TabIndex = 1;
            // 
            // frmBedConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(838, 682);
            this.Name = "frmBedConfiguration";
            this.Load += new System.EventHandler(this.frmBedConfiguration_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboActive;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartComboBox cboRegID;
        private AtiqsControlLibrary.SmartComboBox cboStatus;
        private AtiqsControlLibrary.SmartTextBox txtLocation;
        private AtiqsControlLibrary.SmartTextBox txtBedtTitle;
        private AtiqsControlLibrary.SmartTextBox txtbedID;
        private AtiqsControlLibrary.SmartComboBox cbotheaterID;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartListViewDetails lvwGroupDetails;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboRoomID;
    }
}
