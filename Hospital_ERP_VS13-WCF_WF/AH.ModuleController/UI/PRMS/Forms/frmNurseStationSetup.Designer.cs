namespace AH.ModuleController.UI.PRMS.Forms
{
    partial class frmNurseStationSetup
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
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtNurseStationNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtNurseStationName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtNurseStationId = new AtiqsControlLibrary.SmartTextBox();
            this.lstViewNurseStation = new AtiqsControlLibrary.SmartListViewDetails();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboRoomId = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboFloorNo = new AtiqsControlLibrary.SmartComboBox();
            this.txtIntercomNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(316, 10);
            this.frmLabel.Size = new System.Drawing.Size(251, 33);
            this.frmLabel.Text = "Nurse Station Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtIntercomNo);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboFloorNo);
            this.pnlMain.Controls.Add(this.cboRoomId);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.lstViewNurseStation);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtNurseStationNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtNurseStationName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtNurseStationId);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(863, 498);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(525, 558);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(639, 558);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(22, 553);
            this.btnDelete.Size = new System.Drawing.Size(30, 20);
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(411, 558);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(753, 558);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(58, 553);
            this.btnPrint.Size = new System.Drawing.Size(26, 20);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(864, 23);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(112, 158);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(65, 15);
            this.smartLabel5.TabIndex = 20;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(182, 150);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(412, 38);
            this.txtRemarks.TabIndex = 3;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(3, 91);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(174, 15);
            this.smartLabel3.TabIndex = 19;
            this.smartLabel3.Text = "Nurse Station Name (Bangla) :";
            // 
            // txtNurseStationNameBeng
            // 
            this.txtNurseStationNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNurseStationNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNurseStationNameBeng.Location = new System.Drawing.Point(182, 88);
            this.txtNurseStationNameBeng.Name = "txtNurseStationNameBeng";
            this.txtNurseStationNameBeng.Size = new System.Drawing.Size(412, 24);
            this.txtNurseStationNameBeng.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(50, 53);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(127, 15);
            this.smartLabel2.TabIndex = 18;
            this.smartLabel2.Text = "Nurse Station  Name :";
            // 
            // txtNurseStationName
            // 
            this.txtNurseStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNurseStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNurseStationName.Location = new System.Drawing.Point(182, 50);
            this.txtNurseStationName.Name = "txtNurseStationName";
            this.txtNurseStationName.Size = new System.Drawing.Size(412, 24);
            this.txtNurseStationName.TabIndex = 1;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(71, 18);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(106, 15);
            this.smartLabel1.TabIndex = 15;
            this.smartLabel1.Text = "Nurse Station ID :";
            // 
            // txtNurseStationId
            // 
            this.txtNurseStationId.BackColor = System.Drawing.SystemColors.Window;
            this.txtNurseStationId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNurseStationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNurseStationId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNurseStationId.Location = new System.Drawing.Point(182, 15);
            this.txtNurseStationId.Name = "txtNurseStationId";
            this.txtNurseStationId.Size = new System.Drawing.Size(112, 24);
            this.txtNurseStationId.TabIndex = 0;
            // 
            // lstViewNurseStation
            // 
            this.lstViewNurseStation.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstViewNurseStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstViewNurseStation.CheckBoxes = true;
            this.lstViewNurseStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstViewNurseStation.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewNurseStation.FullRowSelect = true;
            this.lstViewNurseStation.GridLines = true;
            this.lstViewNurseStation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewNurseStation.Location = new System.Drawing.Point(-3, 200);
            this.lstViewNurseStation.Name = "lstViewNurseStation";
            this.lstViewNurseStation.Size = new System.Drawing.Size(865, 297);
            this.lstViewNurseStation.TabIndex = 42;
            this.lstViewNurseStation.UseCompatibleStateImageBehavior = false;
            this.lstViewNurseStation.View = System.Windows.Forms.View.Details;
            this.lstViewNurseStation.SelectedIndexChanged += new System.EventHandler(this.lvDeliv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(600, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 193;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(599, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 194;
            this.label1.Text = "*";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(671, 15);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(39, 13);
            this.smartLabel4.TabIndex = 195;
            this.smartLabel4.Text = "Room";
            this.smartLabel4.Visible = false;
            // 
            // cboRoomId
            // 
            this.cboRoomId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomId.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomId.FormattingEnabled = true;
            this.cboRoomId.Location = new System.Drawing.Point(716, 13);
            this.cboRoomId.Name = "cboRoomId";
            this.cboRoomId.Size = new System.Drawing.Size(21, 26);
            this.cboRoomId.TabIndex = 196;
            this.cboRoomId.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.smartLabel6.Location = new System.Drawing.Point(318, 19);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(76, 15);
            this.smartLabel6.TabIndex = 198;
            this.smartLabel6.Text = "Floor Name :";
            // 
            // cboFloorNo
            // 
            this.cboFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorNo.ForeColor = System.Drawing.Color.Blue;
            this.cboFloorNo.FormattingEnabled = true;
            this.cboFloorNo.Location = new System.Drawing.Point(398, 15);
            this.cboFloorNo.Name = "cboFloorNo";
            this.cboFloorNo.Size = new System.Drawing.Size(196, 26);
            this.cboFloorNo.TabIndex = 197;
            // 
            // txtIntercomNo
            // 
            this.txtIntercomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIntercomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntercomNo.Location = new System.Drawing.Point(182, 120);
            this.txtIntercomNo.MaxLength = 6;
            this.txtIntercomNo.Multiline = true;
            this.txtIntercomNo.Name = "txtIntercomNo";
            this.txtIntercomNo.Size = new System.Drawing.Size(212, 24);
            this.txtIntercomNo.TabIndex = 199;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(96, 124);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(81, 15);
            this.smartLabel7.TabIndex = 200;
            this.smartLabel7.Text = "Intercom No :";
            // 
            // frmNurseStationSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 621);
            this.isEnterTabAllow = true;
            this.Name = "frmNurseStationSetup";
            this.Load += new System.EventHandler(this.frmDeliveryType_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtNurseStationNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtNurseStationName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtNurseStationId;
        private AtiqsControlLibrary.SmartListViewDetails lstViewNurseStation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartComboBox cboRoomId;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtIntercomNo;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboFloorNo;
    }
}
