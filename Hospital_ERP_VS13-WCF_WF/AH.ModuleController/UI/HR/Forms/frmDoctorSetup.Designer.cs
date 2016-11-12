namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmDoctorSetup
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
            this.cboUnitID = new AtiqsControlLibrary.SmartComboBox();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDocID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtDocName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegree1 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.cboRoomNo = new AtiqsControlLibrary.SmartComboBox();
            this.cboDesignation = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtDocNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.lvDocSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegree2 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegree3 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegree4 = new AtiqsControlLibrary.SmartTextBox();
            this.cboDoctorType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmpID = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(914, 5);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(378, 12);
            this.frmLabel.Size = new System.Drawing.Size(170, 33);
            this.frmLabel.Text = "Doctor Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.cboDoctorType);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.txtDegree4);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.txtDegree3);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.txtDegree2);
            this.pnlMain.Controls.Add(this.lvDocSetup);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtDocNameBeng);
            this.pnlMain.Controls.Add(this.cboDesignation);
            this.pnlMain.Controls.Add(this.cboRoomNo);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtDegree1);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtDocName);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDocID);
            this.pnlMain.Controls.Add(this.cboDeptID);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboUnitID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 48);
            this.pnlMain.Size = new System.Drawing.Size(991, 519);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(991, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(538, 573);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(424, 573);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(652, 573);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(310, 573);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(880, 573);
            this.btnClose.TabIndex = 12;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(766, 573);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 614);
            this.groupBox1.Size = new System.Drawing.Size(991, 23);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(583, 21);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(87, 18);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Department :";
            // 
            // cboUnitID
            // 
            this.cboUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnitID.ForeColor = System.Drawing.Color.Blue;
            this.cboUnitID.FormattingEnabled = true;
            this.cboUnitID.Location = new System.Drawing.Point(700, 55);
            this.cboUnitID.Name = "cboUnitID";
            this.cboUnitID.Size = new System.Drawing.Size(225, 26);
            this.cboUnitID.TabIndex = 9;
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(700, 17);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(225, 26);
            this.cboDeptID.TabIndex = 8;
            this.cboDeptID.SelectedIndexChanged += new System.EventHandler(this.cboDeptID_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(630, 59);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(40, 18);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Unit :";
            // 
            // txtDocID
            // 
            this.txtDocID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtDocID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(195)))));
            this.txtDocID.Location = new System.Drawing.Point(185, 15);
            this.txtDocID.Name = "txtDocID";
            this.txtDocID.ReadOnly = true;
            this.txtDocID.Size = new System.Drawing.Size(175, 24);
            this.txtDocID.TabIndex = 2;
            this.txtDocID.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(88, 18);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(73, 18);
            this.smartLabel3.TabIndex = 6;
            this.smartLabel3.Text = "Doctor ID :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(67, 55);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(94, 18);
            this.smartLabel4.TabIndex = 8;
            this.smartLabel4.Text = "Doctor Name :";
            // 
            // txtDocName
            // 
            this.txtDocName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocName.Location = new System.Drawing.Point(185, 52);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(336, 24);
            this.txtDocName.TabIndex = 1;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(93, 161);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 10;
            this.smartLabel5.Text = "Degree 1 :";
            // 
            // txtDegree1
            // 
            this.txtDegree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree1.Location = new System.Drawing.Point(185, 158);
            this.txtDegree1.Multiline = true;
            this.txtDegree1.Name = "txtDegree1";
            this.txtDegree1.Size = new System.Drawing.Size(336, 25);
            this.txtDegree1.TabIndex = 4;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(583, 98);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(87, 18);
            this.smartLabel6.TabIndex = 12;
            this.smartLabel6.Text = "Designation :";
            // 
            // smartLabel7
            // 
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(600, 132);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(70, 24);
            this.smartLabel7.TabIndex = 14;
            this.smartLabel7.Text = "      Room  :";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(73, 126);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(88, 18);
            this.smartLabel9.TabIndex = 18;
            this.smartLabel9.Text = "Doctor Type :";
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomNo.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomNo.FormattingEnabled = true;
            this.cboRoomNo.Location = new System.Drawing.Point(700, 131);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.Size = new System.Drawing.Size(225, 26);
            this.cboRoomNo.TabIndex = 11;
            // 
            // cboDesignation
            // 
            this.cboDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDesignation.ForeColor = System.Drawing.Color.Blue;
            this.cboDesignation.FormattingEnabled = true;
            this.cboDesignation.Location = new System.Drawing.Point(700, 94);
            this.cboDesignation.Name = "cboDesignation";
            this.cboDesignation.Size = new System.Drawing.Size(225, 26);
            this.cboDesignation.TabIndex = 10;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(17, 90);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(144, 18);
            this.smartLabel12.TabIndex = 27;
            this.smartLabel12.Text = "Doctor Name(Bangla) :";
            // 
            // txtDocNameBeng
            // 
            this.txtDocNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocNameBeng.Location = new System.Drawing.Point(185, 87);
            this.txtDocNameBeng.Name = "txtDocNameBeng";
            this.txtDocNameBeng.Size = new System.Drawing.Size(336, 24);
            this.txtDocNameBeng.TabIndex = 2;
            // 
            // lvDocSetup
            // 
            this.lvDocSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDocSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDocSetup.CheckBoxes = true;
            this.lvDocSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDocSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDocSetup.FullRowSelect = true;
            this.lvDocSetup.GridLines = true;
            this.lvDocSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDocSetup.Location = new System.Drawing.Point(0, 296);
            this.lvDocSetup.Name = "lvDocSetup";
            this.lvDocSetup.Size = new System.Drawing.Size(990, 222);
            this.lvDocSetup.TabIndex = 42;
            this.lvDocSetup.UseCompatibleStateImageBehavior = false;
            this.lvDocSetup.View = System.Windows.Forms.View.Details;
            this.lvDocSetup.SelectedIndexChanged += new System.EventHandler(this.lvDocSetup_SelectedIndexChanged);
            this.lvDocSetup.Click += new System.EventHandler(this.lvDocSetup_Click);
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(93, 197);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(68, 18);
            this.smartLabel13.TabIndex = 44;
            this.smartLabel13.Text = "Degree 2 :";
            // 
            // txtDegree2
            // 
            this.txtDegree2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree2.Location = new System.Drawing.Point(185, 194);
            this.txtDegree2.Multiline = true;
            this.txtDegree2.Name = "txtDegree2";
            this.txtDegree2.Size = new System.Drawing.Size(336, 25);
            this.txtDegree2.TabIndex = 5;
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(93, 234);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(68, 18);
            this.smartLabel14.TabIndex = 46;
            this.smartLabel14.Text = "Degree 3 :";
            // 
            // txtDegree3
            // 
            this.txtDegree3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree3.Location = new System.Drawing.Point(185, 231);
            this.txtDegree3.Multiline = true;
            this.txtDegree3.Name = "txtDegree3";
            this.txtDegree3.Size = new System.Drawing.Size(336, 25);
            this.txtDegree3.TabIndex = 6;
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.Location = new System.Drawing.Point(90, 268);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(71, 18);
            this.smartLabel15.TabIndex = 48;
            this.smartLabel15.Text = "Degree  4 :";
            // 
            // txtDegree4
            // 
            this.txtDegree4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree4.Location = new System.Drawing.Point(185, 265);
            this.txtDegree4.Multiline = true;
            this.txtDegree4.Name = "txtDegree4";
            this.txtDegree4.Size = new System.Drawing.Size(336, 25);
            this.txtDegree4.TabIndex = 7;
            // 
            // cboDoctorType
            // 
            this.cboDoctorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctorType.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctorType.FormattingEnabled = true;
            this.cboDoctorType.Location = new System.Drawing.Point(185, 122);
            this.cboDoctorType.Name = "cboDoctorType";
            this.cboDoctorType.Size = new System.Drawing.Size(225, 26);
            this.cboDoctorType.TabIndex = 3;
            // 
            // smartLabel16
            // 
            this.smartLabel16.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(600, 184);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(73, 22);
            this.smartLabel16.TabIndex = 52;
            this.smartLabel16.Text = "Emp ID :";
            this.smartLabel16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(700, 182);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(70, 24);
            this.txtEmpID.TabIndex = 12;
            // 
            // frmDoctorSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(991, 637);
            this.Name = "frmDoctorSetup";
            this.Load += new System.EventHandler(this.frmDoctorSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtDegree1;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtDocName;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDocID;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboUnitID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartComboBox cboRoomNo;
        private AtiqsControlLibrary.SmartComboBox cboDesignation;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartTextBox txtDocNameBeng;
        private AtiqsControlLibrary.SmartListViewDetails lvDocSetup;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartTextBox txtDegree4;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartTextBox txtDegree3;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartTextBox txtDegree2;
        private AtiqsControlLibrary.SmartComboBox cboDoctorType;
        private AtiqsControlLibrary.SmartTextBox txtEmpID;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
    }
}
