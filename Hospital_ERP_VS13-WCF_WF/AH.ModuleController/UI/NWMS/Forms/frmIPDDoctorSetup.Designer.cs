namespace AH.ModuleController.UI.NWMS.Forms
{
    partial class frmIPDDoctorSetup
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboDoctor = new AtiqsControlLibrary.SmartComboBox();
            this.lblDoctor = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.lblUnit = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lblDept = new AtiqsControlLibrary.SmartLabel();
            this.groupBoxVisitingFee = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.lblVisit = new AtiqsControlLibrary.SmartLabel();
            this.lblDrFirstVisit = new AtiqsControlLibrary.SmartLabel();
            this.txtVisitFee = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtDrVisitFee = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lvIPDDoctors = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxVisitingFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(338, 9);
            this.frmLabel.Size = new System.Drawing.Size(221, 33);
            this.frmLabel.Text = "IPD Doctor Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlMain.Controls.Add(this.groupBoxVisitingFee);
            this.pnlMain.Controls.Add(this.lvIPDDoctors);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(876, 527);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(876, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(637, 591);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(524, 591);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 601);
            this.btnDelete.Size = new System.Drawing.Size(14, 14);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(411, 591);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(749, 591);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(29, 601);
            this.btnPrint.Size = new System.Drawing.Size(14, 14);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 632);
            this.groupBox1.Size = new System.Drawing.Size(876, 25);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboDepartmentType);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.cboDoctor);
            this.groupBox2.Controls.Add(this.lblDoctor);
            this.groupBox2.Controls.Add(this.cboDepartmentGroup);
            this.groupBox2.Controls.Add(this.lblUnit);
            this.groupBox2.Controls.Add(this.cboDepartment);
            this.groupBox2.Controls.Add(this.cboUnit);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.lblDept);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 189);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor\'s Details";
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(155, 17);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(320, 26);
            this.cboDepartmentType.TabIndex = 58;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(33, 22);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(112, 13);
            this.smartLabel2.TabIndex = 59;
            this.smartLabel2.Text = "Department Type :";
            // 
            // cboDoctor
            // 
            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctor.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctor.Location = new System.Drawing.Point(155, 153);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(320, 26);
            this.cboDoctor.TabIndex = 55;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.Location = new System.Drawing.Point(92, 158);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(53, 13);
            this.lblDoctor.TabIndex = 54;
            this.lblDoctor.Text = "Doctor :";
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(155, 51);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(320, 26);
            this.cboDepartmentGroup.TabIndex = 56;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(107, 124);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(38, 13);
            this.lblUnit.TabIndex = 53;
            this.lblUnit.Text = "Unit :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(155, 85);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(320, 26);
            this.cboDepartment.TabIndex = 50;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboUnit
            // 
            this.cboUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(155, 119);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(320, 26);
            this.cboUnit.TabIndex = 51;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(27, 56);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(118, 13);
            this.smartLabel1.TabIndex = 57;
            this.smartLabel1.Text = "Department Group :";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(65, 90);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(80, 13);
            this.lblDept.TabIndex = 52;
            this.lblDept.Text = "Department :";
            // 
            // groupBoxVisitingFee
            // 
            this.groupBoxVisitingFee.Controls.Add(this.txtRemarks);
            this.groupBoxVisitingFee.Controls.Add(this.smartLabel3);
            this.groupBoxVisitingFee.Controls.Add(this.smartLabel7);
            this.groupBoxVisitingFee.Controls.Add(this.lblVisit);
            this.groupBoxVisitingFee.Controls.Add(this.lblDrFirstVisit);
            this.groupBoxVisitingFee.Controls.Add(this.txtVisitFee);
            this.groupBoxVisitingFee.Controls.Add(this.smartLabel5);
            this.groupBoxVisitingFee.Controls.Add(this.txtDrVisitFee);
            this.groupBoxVisitingFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxVisitingFee.Location = new System.Drawing.Point(510, 2);
            this.groupBoxVisitingFee.Name = "groupBoxVisitingFee";
            this.groupBoxVisitingFee.Size = new System.Drawing.Size(359, 189);
            this.groupBoxVisitingFee.TabIndex = 58;
            this.groupBoxVisitingFee.TabStop = false;
            this.groupBoxVisitingFee.Text = "Fee Setup";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(16, 143);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(330, 36);
            this.txtRemarks.TabIndex = 33;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(18, 124);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(68, 13);
            this.smartLabel3.TabIndex = 32;
            this.smartLabel3.Text = "Remarks : ";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(217, 100);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(36, 13);
            this.smartLabel7.TabIndex = 31;
            this.smartLabel7.Text = "Taka";
            // 
            // lblVisit
            // 
            this.lblVisit.AutoSize = true;
            this.lblVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVisit.Location = new System.Drawing.Point(18, 22);
            this.lblVisit.Name = "lblVisit";
            this.lblVisit.Size = new System.Drawing.Size(85, 13);
            this.lblVisit.TabIndex = 16;
            this.lblVisit.Text = "Visiting Fee : ";
            // 
            // lblDrFirstVisit
            // 
            this.lblDrFirstVisit.AutoSize = true;
            this.lblDrFirstVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDrFirstVisit.Location = new System.Drawing.Point(18, 74);
            this.lblDrFirstVisit.Name = "lblDrFirstVisit";
            this.lblDrFirstVisit.Size = new System.Drawing.Size(133, 13);
            this.lblDrFirstVisit.TabIndex = 30;
            this.lblDrFirstVisit.Text = "Doctors Visiting Fee : ";
            // 
            // txtVisitFee
            // 
            this.txtVisitFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitFee.Location = new System.Drawing.Point(16, 42);
            this.txtVisitFee.Name = "txtVisitFee";
            this.txtVisitFee.Size = new System.Drawing.Size(196, 24);
            this.txtVisitFee.TabIndex = 9;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(217, 48);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(36, 13);
            this.smartLabel5.TabIndex = 26;
            this.smartLabel5.Text = "Taka";
            // 
            // txtDrVisitFee
            // 
            this.txtDrVisitFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrVisitFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrVisitFee.Location = new System.Drawing.Point(16, 94);
            this.txtDrVisitFee.Name = "txtDrVisitFee";
            this.txtDrVisitFee.Size = new System.Drawing.Size(196, 24);
            this.txtDrVisitFee.TabIndex = 29;
            // 
            // lvIPDDoctors
            // 
            this.lvIPDDoctors.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvIPDDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvIPDDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvIPDDoctors.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvIPDDoctors.FullRowSelect = true;
            this.lvIPDDoctors.GridLines = true;
            this.lvIPDDoctors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvIPDDoctors.Location = new System.Drawing.Point(0, 197);
            this.lvIPDDoctors.Name = "lvIPDDoctors";
            this.lvIPDDoctors.Size = new System.Drawing.Size(874, 328);
            this.lvIPDDoctors.TabIndex = 57;
            this.lvIPDDoctors.UseCompatibleStateImageBehavior = false;
            this.lvIPDDoctors.View = System.Windows.Forms.View.Details;
            this.lvIPDDoctors.SelectedIndexChanged += new System.EventHandler(this.lvIPDDoctors_SelectedIndexChanged);
            // 
            // frmIPDDoctorSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 657);
            this.isEnterTabAllow = true;
            this.Name = "frmIPDDoctorSetup";
            this.Load += new System.EventHandler(this.frmIPDDoctorSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxVisitingFee.ResumeLayout(false);
            this.groupBoxVisitingFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel lblDept;
        private AtiqsControlLibrary.SmartLabel lblUnit;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartComboBox cboDoctor;
        private AtiqsControlLibrary.SmartLabel lblDoctor;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.GroupBox groupBoxVisitingFee;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel lblVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtVisitFee;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel lblDrFirstVisit;
        private AtiqsControlLibrary.SmartNumericTextBox txtDrVisitFee;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartListViewDetails lvIPDDoctors;
    }
}