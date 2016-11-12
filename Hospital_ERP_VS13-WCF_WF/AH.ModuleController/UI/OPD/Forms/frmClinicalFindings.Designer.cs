namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmClinicalFindings
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
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboFindingsGroup = new AtiqsControlLibrary.SmartComboBox();
            this.lvClinicalFindings = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtClinicalFindingNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.txtClinicalFindingName = new AtiqsControlLibrary.SmartTextBox();
            this.txtClinicalFindingID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboFindingsParents = new AtiqsControlLibrary.SmartComboBox();
            this.chkParent = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(202, 33);
            this.frmLabel.Text = "Clinical Findings";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvClinicalFindings);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(884, 536);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(884, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(653, 600);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(540, 600);
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 618);
            this.btnDelete.Size = new System.Drawing.Size(10, 14);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(427, 600);
            this.btnNew.TabIndex = 8;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(766, 600);
            this.btnClose.TabIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(16, 618);
            this.btnPrint.Size = new System.Drawing.Size(10, 14);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 640);
            this.groupBox1.Size = new System.Drawing.Size(884, 25);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(114, 13);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(157, 18);
            this.smartLabel4.TabIndex = 83;
            this.smartLabel4.Text = "Clinical Findings Group :";
            // 
            // cboFindingsGroup
            // 
            this.cboFindingsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFindingsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFindingsGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboFindingsGroup.FormattingEnabled = true;
            this.cboFindingsGroup.Location = new System.Drawing.Point(277, 10);
            this.cboFindingsGroup.Name = "cboFindingsGroup";
            this.cboFindingsGroup.Size = new System.Drawing.Size(195, 26);
            this.cboFindingsGroup.TabIndex = 1;
            this.cboFindingsGroup.SelectedIndexChanged += new System.EventHandler(this.cboFindingsGroup_SelectedIndexChanged);
            // 
            // lvClinicalFindings
            // 
            this.lvClinicalFindings.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvClinicalFindings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvClinicalFindings.CheckBoxes = true;
            this.lvClinicalFindings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvClinicalFindings.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClinicalFindings.FullRowSelect = true;
            this.lvClinicalFindings.GridLines = true;
            this.lvClinicalFindings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvClinicalFindings.Location = new System.Drawing.Point(0, 246);
            this.lvClinicalFindings.Name = "lvClinicalFindings";
            this.lvClinicalFindings.Size = new System.Drawing.Size(882, 288);
            this.lvClinicalFindings.TabIndex = 81;
            this.lvClinicalFindings.TabStop = false;
            this.lvClinicalFindings.UseCompatibleStateImageBehavior = false;
            this.lvClinicalFindings.View = System.Windows.Forms.View.Details;
            this.lvClinicalFindings.SelectedIndexChanged += new System.EventHandler(this.lvClinicalFindings_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(277, 183);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(507, 51);
            this.txtRemarks.TabIndex = 5;
            // 
            // txtClinicalFindingNameBang
            // 
            this.txtClinicalFindingNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinicalFindingNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindingNameBang.Location = new System.Drawing.Point(277, 149);
            this.txtClinicalFindingNameBang.Name = "txtClinicalFindingNameBang";
            this.txtClinicalFindingNameBang.Size = new System.Drawing.Size(507, 24);
            this.txtClinicalFindingNameBang.TabIndex = 4;
            // 
            // txtClinicalFindingName
            // 
            this.txtClinicalFindingName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinicalFindingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindingName.Location = new System.Drawing.Point(277, 115);
            this.txtClinicalFindingName.Name = "txtClinicalFindingName";
            this.txtClinicalFindingName.Size = new System.Drawing.Size(434, 24);
            this.txtClinicalFindingName.TabIndex = 3;
            this.txtClinicalFindingName.TextChanged += new System.EventHandler(this.txtClinicalFindingName_TextChanged);
            this.txtClinicalFindingName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClinicalFindingName_KeyUp);
            this.txtClinicalFindingName.Leave += new System.EventHandler(this.txtClinicalFindingName_Leave);
            // 
            // txtClinicalFindingID
            // 
            this.txtClinicalFindingID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinicalFindingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindingID.Location = new System.Drawing.Point(277, 45);
            this.txtClinicalFindingID.Name = "txtClinicalFindingID";
            this.txtClinicalFindingID.ReadOnly = true;
            this.txtClinicalFindingID.Size = new System.Drawing.Size(195, 24);
            this.txtClinicalFindingID.TabIndex = 73;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(203, 186);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 80;
            this.smartLabel5.Text = "Remarks :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(63, 152);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(208, 18);
            this.smartLabel3.TabIndex = 79;
            this.smartLabel3.Text = "Clinical Findings Name( Bangla) :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(116, 118);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(155, 18);
            this.smartLabel2.TabIndex = 78;
            this.smartLabel2.Text = "Clinical Findings Name :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(137, 48);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(134, 18);
            this.smartLabel1.TabIndex = 77;
            this.smartLabel1.Text = "Clinical Findings ID :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(114, 83);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(157, 18);
            this.smartLabel6.TabIndex = 85;
            this.smartLabel6.Text = "Clinical Findings Parent :";
            // 
            // cboFindingsParents
            // 
            this.cboFindingsParents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFindingsParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFindingsParents.ForeColor = System.Drawing.Color.Blue;
            this.cboFindingsParents.FormattingEnabled = true;
            this.cboFindingsParents.Location = new System.Drawing.Point(277, 79);
            this.cboFindingsParents.Name = "cboFindingsParents";
            this.cboFindingsParents.Size = new System.Drawing.Size(195, 26);
            this.cboFindingsParents.TabIndex = 2;
            this.cboFindingsParents.SelectedIndexChanged += new System.EventHandler(this.cboFindingsParents_SelectedIndexChanged);
            // 
            // chkParent
            // 
            this.chkParent.AutoSize = true;
            this.chkParent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParent.ForeColor = System.Drawing.Color.Black;
            this.chkParent.Location = new System.Drawing.Point(717, 115);
            this.chkParent.Name = "chkParent";
            this.chkParent.Size = new System.Drawing.Size(67, 22);
            this.chkParent.TabIndex = 86;
            this.chkParent.Text = "Parent";
            this.chkParent.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.chkParent);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.smartLabel6);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.cboFindingsParents);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Controls.Add(this.cboFindingsGroup);
            this.groupBox2.Controls.Add(this.txtClinicalFindingID);
            this.groupBox2.Controls.Add(this.txtClinicalFindingName);
            this.groupBox2.Controls.Add(this.txtClinicalFindingNameBang);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 240);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            // 
            // frmClinicalFindings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.isEnterTabAllow = true;
            this.Name = "frmClinicalFindings";
            this.Load += new System.EventHandler(this.frmClinicalFindings_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboFindingsGroup;
        private AtiqsControlLibrary.SmartListViewDetails lvClinicalFindings;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtClinicalFindingNameBang;
        private AtiqsControlLibrary.SmartTextBox txtClinicalFindingName;
        private AtiqsControlLibrary.SmartTextBox txtClinicalFindingID;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboFindingsParents;
        private AtiqsControlLibrary.SmartCheckBox chkParent;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}