namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmDiseaseCase
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
            this.lvDisease = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtCaseNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtCaseName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.lblDiseaseGrp = new AtiqsControlLibrary.SmartLabel();
            this.cboDiseaseGroup = new AtiqsControlLibrary.SmartComboBox();
            this.chkShownCheckList = new AtiqsControlLibrary.SmartCheckBox();
            this.txtCaseID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtChkBox = new AtiqsControlLibrary.SmartTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(245, 33);
            this.frmLabel.Text = "Disease Case Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvDisease);
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
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(540, 600);
            this.btnSave.TabIndex = 8;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 619);
            this.btnDelete.Size = new System.Drawing.Size(16, 16);
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(427, 600);
            this.btnNew.TabIndex = 10;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(767, 600);
            this.btnClose.TabIndex = 11;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(30, 619);
            this.btnPrint.Size = new System.Drawing.Size(16, 16);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 640);
            this.groupBox1.Size = new System.Drawing.Size(884, 25);
            // 
            // lvDisease
            // 
            this.lvDisease.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDisease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDisease.CheckBoxes = true;
            this.lvDisease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDisease.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDisease.FullRowSelect = true;
            this.lvDisease.GridLines = true;
            this.lvDisease.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDisease.Location = new System.Drawing.Point(0, 154);
            this.lvDisease.Name = "lvDisease";
            this.lvDisease.Size = new System.Drawing.Size(882, 380);
            this.lvDisease.TabIndex = 52;
            this.lvDisease.TabStop = false;
            this.lvDisease.UseCompatibleStateImageBehavior = false;
            this.lvDisease.View = System.Windows.Forms.View.Details;
            this.lvDisease.SelectedIndexChanged += new System.EventHandler(this.lvDisease_SelectedIndexChanged);
            this.lvDisease.Click += new System.EventHandler(this.lvDisease_Click);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(518, 114);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(65, 15);
            this.smartLabel5.TabIndex = 50;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(593, 100);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(197, 42);
            this.txtRemarks.TabIndex = 7;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(18, 120);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(125, 15);
            this.smartLabel3.TabIndex = 47;
            this.smartLabel3.Text = "Case Name( Bangla) :";
            // 
            // txtCaseNameBang
            // 
            this.txtCaseNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaseNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseNameBang.Location = new System.Drawing.Point(161, 118);
            this.txtCaseNameBang.Name = "txtCaseNameBang";
            this.txtCaseNameBang.Size = new System.Drawing.Size(297, 24);
            this.txtCaseNameBang.TabIndex = 3;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(71, 85);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(75, 15);
            this.smartLabel2.TabIndex = 45;
            this.smartLabel2.Text = "Case Name :";
            // 
            // txtCaseName
            // 
            this.txtCaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseName.Location = new System.Drawing.Point(161, 83);
            this.txtCaseName.MaxLength = 70;
            this.txtCaseName.Name = "txtCaseName";
            this.txtCaseName.Size = new System.Drawing.Size(297, 24);
            this.txtCaseName.TabIndex = 2;
            this.txtCaseName.TextChanged += new System.EventHandler(this.txtCaseName_TextChanged);
            this.txtCaseName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCaseName_KeyUp);
            this.txtCaseName.Leave += new System.EventHandler(this.txtCaseName_Leave);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(88, 50);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(60, 15);
            this.smartLabel1.TabIndex = 44;
            this.smartLabel1.Text = "Case  ID :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(546, 50);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(37, 15);
            this.smartLabel4.TabIndex = 55;
            this.smartLabel4.Text = "Unit :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.Location = new System.Drawing.Point(593, 45);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(197, 26);
            this.cboUnit.TabIndex = 5;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(500, 14);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(78, 15);
            this.smartLabel6.TabIndex = 54;
            this.smartLabel6.Text = "Department :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(593, 11);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(197, 26);
            this.cboDepartment.TabIndex = 4;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // lblDiseaseGrp
            // 
            this.lblDiseaseGrp.AutoSize = true;
            this.lblDiseaseGrp.BackColor = System.Drawing.Color.Transparent;
            this.lblDiseaseGrp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiseaseGrp.Location = new System.Drawing.Point(49, 13);
            this.lblDiseaseGrp.Name = "lblDiseaseGrp";
            this.lblDiseaseGrp.Size = new System.Drawing.Size(94, 15);
            this.lblDiseaseGrp.TabIndex = 57;
            this.lblDiseaseGrp.Text = "Disease Group :";
            // 
            // cboDiseaseGroup
            // 
            this.cboDiseaseGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiseaseGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiseaseGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDiseaseGroup.Location = new System.Drawing.Point(162, 11);
            this.cboDiseaseGroup.Name = "cboDiseaseGroup";
            this.cboDiseaseGroup.Size = new System.Drawing.Size(296, 26);
            this.cboDiseaseGroup.TabIndex = 1;
            // 
            // chkShownCheckList
            // 
            this.chkShownCheckList.AutoSize = true;
            this.chkShownCheckList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShownCheckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShownCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShownCheckList.ForeColor = System.Drawing.Color.Black;
            this.chkShownCheckList.Location = new System.Drawing.Point(593, 75);
            this.chkShownCheckList.Name = "chkShownCheckList";
            this.chkShownCheckList.Size = new System.Drawing.Size(159, 22);
            this.chkShownCheckList.TabIndex = 6;
            this.chkShownCheckList.Text = "Is Shown Check List";
            this.chkShownCheckList.UseVisualStyleBackColor = true;
            // 
            // txtCaseID
            // 
            this.txtCaseID.BackColor = System.Drawing.Color.Linen;
            this.txtCaseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCaseID.Location = new System.Drawing.Point(162, 47);
            this.txtCaseID.Name = "txtCaseID";
            this.txtCaseID.ReadOnly = true;
            this.txtCaseID.Size = new System.Drawing.Size(108, 24);
            this.txtCaseID.TabIndex = 60;
            this.txtCaseID.TabStop = false;
            // 
            // txtChkBox
            // 
            this.txtChkBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChkBox.Location = new System.Drawing.Point(796, 108);
            this.txtChkBox.Multiline = true;
            this.txtChkBox.Name = "txtChkBox";
            this.txtChkBox.Size = new System.Drawing.Size(27, 28);
            this.txtChkBox.TabIndex = 15;
            this.txtChkBox.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.txtChkBox);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.txtCaseID);
            this.groupBox2.Controls.Add(this.txtCaseName);
            this.groupBox2.Controls.Add(this.chkShownCheckList);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.lblDiseaseGrp);
            this.groupBox2.Controls.Add(this.txtCaseNameBang);
            this.groupBox2.Controls.Add(this.cboDiseaseGroup);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Controls.Add(this.cboUnit);
            this.groupBox2.Controls.Add(this.cboDepartment);
            this.groupBox2.Controls.Add(this.smartLabel6);
            this.groupBox2.Location = new System.Drawing.Point(4, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 148);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            // 
            // frmDiseaseCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.isEnterTabAllow = true;
            this.Name = "frmDiseaseCase";
            this.Load += new System.EventHandler(this.frmDiseaseCase_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvDisease;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtCaseNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtCaseName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel lblDiseaseGrp;
        private AtiqsControlLibrary.SmartComboBox cboDiseaseGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartCheckBox chkShownCheckList;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCaseID;
        private AtiqsControlLibrary.SmartTextBox txtChkBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
