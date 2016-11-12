namespace AH.ModuleController.UI.ACMS.Forms
{
    partial class frmCreateAccessControl
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
            this.cboEmpName = new AtiqsControlLibrary.SmartComboBox();
            this.cboUserGroup = new AtiqsControlLibrary.SmartComboBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvAccControl = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboObject = new AtiqsControlLibrary.SmartComboBox();
            this.cboModule = new AtiqsControlLibrary.SmartComboBox();
            this.cboAuthLevel = new AtiqsControlLibrary.SmartComboBox();
            this.txtEmpID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(311, 9);
            this.frmLabel.Size = new System.Drawing.Size(187, 33);
            this.frmLabel.Text = "Access Control";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Controls.Add(this.cboAuthLevel);
            this.pnlMain.Controls.Add(this.cboModule);
            this.pnlMain.Controls.Add(this.cboObject);
            this.pnlMain.Controls.Add(this.lvAccControl);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.cboUserGroup);
            this.pnlMain.Controls.Add(this.cboEmpName);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(838, 491);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(838, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(31, 553);
            this.btnEdit.Size = new System.Drawing.Size(14, 39);
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(610, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(60, 564);
            this.btnDelete.Size = new System.Drawing.Size(10, 16);
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(497, 555);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(724, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(81, 564);
            this.btnPrint.Size = new System.Drawing.Size(10, 16);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(838, 23);
            // 
            // cboEmpName
            // 
            this.cboEmpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpName.ForeColor = System.Drawing.Color.Blue;
            this.cboEmpName.FormattingEnabled = true;
            this.cboEmpName.Location = new System.Drawing.Point(151, 33);
            this.cboEmpName.Name = "cboEmpName";
            this.cboEmpName.Size = new System.Drawing.Size(249, 26);
            this.cboEmpName.TabIndex = 4;
            // 
            // cboUserGroup
            // 
            this.cboUserGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboUserGroup.FormattingEnabled = true;
            this.cboUserGroup.Location = new System.Drawing.Point(527, 11);
            this.cboUserGroup.Name = "cboUserGroup";
            this.cboUserGroup.Size = new System.Drawing.Size(300, 26);
            this.cboUserGroup.TabIndex = 6;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(527, 91);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(300, 30);
            this.txtRemarks.TabIndex = 7;
            // 
            // lvAccControl
            // 
            this.lvAccControl.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvAccControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAccControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAccControl.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAccControl.FullRowSelect = true;
            this.lvAccControl.GridLines = true;
            this.lvAccControl.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAccControl.Location = new System.Drawing.Point(-1, 127);
            this.lvAccControl.Name = "lvAccControl";
            this.lvAccControl.Size = new System.Drawing.Size(838, 363);
            this.lvAccControl.TabIndex = 8;
            this.lvAccControl.UseCompatibleStateImageBehavior = false;
            this.lvAccControl.View = System.Windows.Forms.View.Details;
            this.lvAccControl.SelectedIndexChanged += new System.EventHandler(this.lvAccControl_SelectedIndexChanged);
            // 
            // cboObject
            // 
            this.cboObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboObject.ForeColor = System.Drawing.Color.Blue;
            this.cboObject.FormattingEnabled = true;
            this.cboObject.Location = new System.Drawing.Point(527, 54);
            this.cboObject.Name = "cboObject";
            this.cboObject.Size = new System.Drawing.Size(300, 26);
            this.cboObject.TabIndex = 10;
            // 
            // cboModule
            // 
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModule.ForeColor = System.Drawing.Color.Blue;
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboModule.Location = new System.Drawing.Point(151, 63);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(249, 26);
            this.cboModule.TabIndex = 11;
            // 
            // cboAuthLevel
            // 
            this.cboAuthLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAuthLevel.ForeColor = System.Drawing.Color.Blue;
            this.cboAuthLevel.FormattingEnabled = true;
            this.cboAuthLevel.Location = new System.Drawing.Point(151, 94);
            this.cboAuthLevel.Name = "cboAuthLevel";
            this.cboAuthLevel.Size = new System.Drawing.Size(249, 26);
            this.cboAuthLevel.TabIndex = 13;
            // 
            // txtEmpID
            // 
            this.txtEmpID.BackColor = System.Drawing.Color.Linen;
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtEmpID.Location = new System.Drawing.Point(151, 5);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(249, 24);
            this.txtEmpID.TabIndex = 15;
            this.txtEmpID.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(28, 39);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(97, 13);
            this.smartLabel1.TabIndex = 16;
            this.smartLabel1.Text = "Employee Name";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(77, 69);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(48, 13);
            this.smartLabel2.TabIndex = 17;
            this.smartLabel2.Text = "Module";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(1, 99);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(124, 13);
            this.smartLabel3.TabIndex = 18;
            this.smartLabel3.Text = "Authentication Level";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(446, 16);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(41, 13);
            this.smartLabel4.TabIndex = 19;
            this.smartLabel4.Text = "Group";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(446, 59);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(44, 13);
            this.smartLabel5.TabIndex = 20;
            this.smartLabel5.Text = "Object";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(433, 97);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(56, 13);
            this.smartLabel6.TabIndex = 21;
            this.smartLabel6.Text = "Remarks";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(47, 9);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(78, 13);
            this.smartLabel7.TabIndex = 22;
            this.smartLabel7.Text = "Employee ID";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(126, 7);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(12, 16);
            this.smartLabel8.TabIndex = 23;
            this.smartLabel8.Text = ":";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(127, 38);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(12, 16);
            this.smartLabel9.TabIndex = 23;
            this.smartLabel9.Text = ":";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(127, 68);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(12, 16);
            this.smartLabel10.TabIndex = 23;
            this.smartLabel10.Text = ":";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(126, 97);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(12, 16);
            this.smartLabel11.TabIndex = 23;
            this.smartLabel11.Text = ":";
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(497, 15);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(12, 16);
            this.smartLabel12.TabIndex = 24;
            this.smartLabel12.Text = ":";
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(496, 59);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(12, 16);
            this.smartLabel13.TabIndex = 24;
            this.smartLabel13.Text = ":";
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(497, 96);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(12, 16);
            this.smartLabel14.TabIndex = 24;
            this.smartLabel14.Text = ":";
            // 
            // frmCreateAccessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(838, 621);
            this.isEnterTabAllow = true;
            this.Name = "frmCreateAccessControl";
            this.Load += new System.EventHandler(this.frmCreateAccessControl_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvAccControl;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartComboBox cboUserGroup;
        private AtiqsControlLibrary.SmartComboBox cboEmpName;
        private AtiqsControlLibrary.SmartComboBox cboObject;
        private AtiqsControlLibrary.SmartComboBox cboModule;
        private AtiqsControlLibrary.SmartComboBox cboAuthLevel;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtEmpID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
    }
}