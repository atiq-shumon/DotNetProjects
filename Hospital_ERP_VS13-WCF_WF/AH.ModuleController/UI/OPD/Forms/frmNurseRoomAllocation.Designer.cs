namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmNurseRoomAllocation
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
            this.lvlNurseRoomSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboNurse = new AtiqsControlLibrary.SmartComboBox();
            this.cboRoomGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboRoomNo = new AtiqsControlLibrary.SmartComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(298, 9);
            this.frmLabel.Size = new System.Drawing.Size(284, 33);
            this.frmLabel.Text = "Nurse Room Allocation";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvlNurseRoomSetup);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 489);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(628, 554);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(515, 554);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 553);
            this.btnDelete.Size = new System.Drawing.Size(11, 14);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(402, 554);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(741, 554);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(29, 553);
            this.btnPrint.Size = new System.Drawing.Size(11, 14);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 595);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // lvlNurseRoomSetup
            // 
            this.lvlNurseRoomSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvlNurseRoomSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlNurseRoomSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvlNurseRoomSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNurseRoomSetup.FullRowSelect = true;
            this.lvlNurseRoomSetup.GridLines = true;
            this.lvlNurseRoomSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvlNurseRoomSetup.Location = new System.Drawing.Point(0, 68);
            this.lvlNurseRoomSetup.Name = "lvlNurseRoomSetup";
            this.lvlNurseRoomSetup.Size = new System.Drawing.Size(863, 420);
            this.lvlNurseRoomSetup.TabIndex = 17;
            this.lvlNurseRoomSetup.UseCompatibleStateImageBehavior = false;
            this.lvlNurseRoomSetup.View = System.Windows.Forms.View.Details;
            this.lvlNurseRoomSetup.SelectedIndexChanged += new System.EventHandler(this.lvlNurseRoomSetup_SelectedIndexChanged);
            // 
            // cboNurse
            // 
            this.cboNurse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNurse.ForeColor = System.Drawing.Color.Blue;
            this.cboNurse.FormattingEnabled = true;
            this.cboNurse.Location = new System.Drawing.Point(584, 19);
            this.cboNurse.Name = "cboNurse";
            this.cboNurse.Size = new System.Drawing.Size(269, 26);
            this.cboNurse.TabIndex = 4;
            // 
            // cboRoomGroup
            // 
            this.cboRoomGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomGroup.FormattingEnabled = true;
            this.cboRoomGroup.Location = new System.Drawing.Point(87, 19);
            this.cboRoomGroup.Name = "cboRoomGroup";
            this.cboRoomGroup.Size = new System.Drawing.Size(135, 26);
            this.cboRoomGroup.TabIndex = 1;
            this.cboRoomGroup.SelectedIndexChanged += new System.EventHandler(this.cboRoomGroup_SelectedIndexChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(538, 26);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(40, 13);
            this.smartLabel3.TabIndex = 13;
            this.smartLabel3.Text = "Nurse";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(4, 25);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(77, 13);
            this.smartLabel1.TabIndex = 11;
            this.smartLabel1.Text = "Room Group";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(316, 26);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(59, 13);
            this.smartLabel2.TabIndex = 19;
            this.smartLabel2.Text = "Room No";
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomNo.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomNo.FormattingEnabled = true;
            this.cboRoomNo.ItemHeight = 18;
            this.cboRoomNo.Location = new System.Drawing.Point(382, 18);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.Size = new System.Drawing.Size(150, 26);
            this.cboRoomNo.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(230, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 28);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Search";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboNurse);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.cboRoomNo);
            this.groupBox2.Controls.Add(this.cboRoomGroup);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 60);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // frmNurseRoomAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 620);
            this.isEnterTabAllow = true;
            this.Name = "frmNurseRoomAllocation";
            this.Load += new System.EventHandler(this.frmNurseRoomAllocation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvlNurseRoomSetup;
        private AtiqsControlLibrary.SmartComboBox cboNurse;
        private AtiqsControlLibrary.SmartComboBox cboRoomGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboRoomNo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
