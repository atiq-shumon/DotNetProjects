namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmClinicalFindingsGroup
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
            this.txtClinicalFindingGrpNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtClinicalFindingGrpName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtClinicalFindingGrpID = new AtiqsControlLibrary.SmartTextBox();
            this.lvClinicalFindingsGrp = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboFindingsCategory = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(278, 9);
            this.frmLabel.Size = new System.Drawing.Size(359, 33);
            this.frmLabel.Text = "Clinical Findings Group Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvClinicalFindingsGrp);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(884, 537);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(884, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(651, 601);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(538, 601);
            this.btnSave.TabIndex = 7;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 619);
            this.btnDelete.Size = new System.Drawing.Size(17, 14);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(425, 601);
            this.btnNew.TabIndex = 9;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(765, 601);
            this.btnClose.TabIndex = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(26, 619);
            this.btnPrint.Size = new System.Drawing.Size(17, 14);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 640);
            this.groupBox1.Size = new System.Drawing.Size(884, 25);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(215, 200);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 68;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(290, 196);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(507, 51);
            this.txtRemarks.TabIndex = 6;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(39, 169);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(244, 18);
            this.smartLabel3.TabIndex = 67;
            this.smartLabel3.Text = "Clinical Finding Group Name( Bangla) :";
            // 
            // txtClinicalFindingGrpNameBang
            // 
            this.txtClinicalFindingGrpNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinicalFindingGrpNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindingGrpNameBang.Location = new System.Drawing.Point(290, 166);
            this.txtClinicalFindingGrpNameBang.Name = "txtClinicalFindingGrpNameBang";
            this.txtClinicalFindingGrpNameBang.Size = new System.Drawing.Size(507, 24);
            this.txtClinicalFindingGrpNameBang.TabIndex = 5;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(92, 138);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(191, 18);
            this.smartLabel2.TabIndex = 66;
            this.smartLabel2.Text = "Clinical Finding Group Name :";
            // 
            // txtClinicalFindingGrpName
            // 
            this.txtClinicalFindingGrpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinicalFindingGrpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindingGrpName.Location = new System.Drawing.Point(290, 136);
            this.txtClinicalFindingGrpName.Name = "txtClinicalFindingGrpName";
            this.txtClinicalFindingGrpName.Size = new System.Drawing.Size(507, 24);
            this.txtClinicalFindingGrpName.TabIndex = 4;
            this.txtClinicalFindingGrpName.TextChanged += new System.EventHandler(this.txtClinicalFindingGrpName_TextChanged);
            this.txtClinicalFindingGrpName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClinicalFindingGrpName_KeyUp);
            this.txtClinicalFindingGrpName.Leave += new System.EventHandler(this.txtClinicalFindingGrpName_Leave);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(113, 107);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(170, 18);
            this.smartLabel1.TabIndex = 65;
            this.smartLabel1.Text = "Clinical Finding Group ID :";
            // 
            // txtClinicalFindingGrpID
            // 
            this.txtClinicalFindingGrpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinicalFindingGrpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindingGrpID.Location = new System.Drawing.Point(290, 106);
            this.txtClinicalFindingGrpID.Name = "txtClinicalFindingGrpID";
            this.txtClinicalFindingGrpID.ReadOnly = true;
            this.txtClinicalFindingGrpID.Size = new System.Drawing.Size(223, 24);
            this.txtClinicalFindingGrpID.TabIndex = 61;
            // 
            // lvClinicalFindingsGrp
            // 
            this.lvClinicalFindingsGrp.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvClinicalFindingsGrp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvClinicalFindingsGrp.CheckBoxes = true;
            this.lvClinicalFindingsGrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvClinicalFindingsGrp.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClinicalFindingsGrp.FullRowSelect = true;
            this.lvClinicalFindingsGrp.GridLines = true;
            this.lvClinicalFindingsGrp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvClinicalFindingsGrp.Location = new System.Drawing.Point(0, 261);
            this.lvClinicalFindingsGrp.Name = "lvClinicalFindingsGrp";
            this.lvClinicalFindingsGrp.Size = new System.Drawing.Size(882, 274);
            this.lvClinicalFindingsGrp.TabIndex = 69;
            this.lvClinicalFindingsGrp.TabStop = false;
            this.lvClinicalFindingsGrp.UseCompatibleStateImageBehavior = false;
            this.lvClinicalFindingsGrp.View = System.Windows.Forms.View.Details;
            this.lvClinicalFindingsGrp.SelectedIndexChanged += new System.EventHandler(this.lvClinicalFindings_SelectedIndexChanged);
            // 
            // cboFindingsCategory
            // 
            this.cboFindingsCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFindingsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFindingsCategory.ForeColor = System.Drawing.Color.Blue;
            this.cboFindingsCategory.FormattingEnabled = true;
            this.cboFindingsCategory.Items.AddRange(new object[] {
            "General Examination",
            "Systemic Examination"});
            this.cboFindingsCategory.Location = new System.Drawing.Point(290, 10);
            this.cboFindingsCategory.Name = "cboFindingsCategory";
            this.cboFindingsCategory.Size = new System.Drawing.Size(223, 26);
            this.cboFindingsCategory.TabIndex = 1;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(112, 14);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(171, 18);
            this.smartLabel4.TabIndex = 72;
            this.smartLabel4.Text = "Clinical Findings Category :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(243, 76);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(40, 18);
            this.smartLabel6.TabIndex = 75;
            this.smartLabel6.Text = "Unit :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.Location = new System.Drawing.Point(290, 74);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(223, 26);
            this.cboUnit.TabIndex = 3;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(196, 45);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(87, 18);
            this.smartLabel7.TabIndex = 74;
            this.smartLabel7.Text = "Department :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(290, 42);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(223, 26);
            this.cboDepartment.TabIndex = 2;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.smartLabel6);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.cboUnit);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.smartLabel7);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.cboDepartment);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.txtClinicalFindingGrpID);
            this.groupBox2.Controls.Add(this.cboFindingsCategory);
            this.groupBox2.Controls.Add(this.txtClinicalFindingGrpName);
            this.groupBox2.Controls.Add(this.txtClinicalFindingGrpNameBang);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 253);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            // 
            // frmClinicalFindingsGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.isEnterTabAllow = true;
            this.Name = "frmClinicalFindingsGroup";
            this.Load += new System.EventHandler(this.frmClinicalFindingsGroup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtClinicalFindingGrpNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtClinicalFindingGrpName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtClinicalFindingGrpID;
        private AtiqsControlLibrary.SmartListViewDetails lvClinicalFindingsGrp;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboFindingsCategory;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}