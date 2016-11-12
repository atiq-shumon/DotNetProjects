namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmLabelReprint
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
            this.txtMRNo = new System.Windows.Forms.TextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtSex = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeHours = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeDays = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeMonths = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblAge = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeYears = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtSpecimenNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.cboPatientMr = new System.Windows.Forms.Button();
            this.lblMr = new AtiqsControlLibrary.SmartLabel();
            this.lvMRTests = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRegNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtHCN = new AtiqsControlLibrary.SmartTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(907, 4);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(385, 5);
            this.frmLabel.Size = new System.Drawing.Size(171, 33);
            this.frmLabel.Text = "Label Reprint";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.lvMRTests);
            this.pnlMain.Controls.Add(this.txtMRNo);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtSex);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.txtAgeHours);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtAgeDays);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtAgeMonths);
            this.pnlMain.Controls.Add(this.lblAge);
            this.pnlMain.Controls.Add(this.txtAgeYears);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtSpecimenNo);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtPatientName);
            this.pnlMain.Controls.Add(this.cboPatientMr);
            this.pnlMain.Controls.Add(this.lblMr);
            this.pnlMain.Location = new System.Drawing.Point(1, 51);
            this.pnlMain.Size = new System.Drawing.Size(960, 513);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(961, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(302, 582);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 582);
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(416, 582);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(74, 582);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(848, 580);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(736, 580);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 626);
            this.groupBox1.Size = new System.Drawing.Size(961, 23);
            // 
            // txtMRNo
            // 
            this.txtMRNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNo.ForeColor = System.Drawing.Color.Red;
            this.txtMRNo.Location = new System.Drawing.Point(3, 19);
            this.txtMRNo.MaxLength = 11;
            this.txtMRNo.Name = "txtMRNo";
            this.txtMRNo.Size = new System.Drawing.Size(320, 31);
            this.txtMRNo.TabIndex = 133;
            this.txtMRNo.TextChanged += new System.EventHandler(this.txtMRNo_TextChanged);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(851, 50);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(30, 18);
            this.smartLabel8.TabIndex = 130;
            this.smartLabel8.Text = "Sex";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSex.Location = new System.Drawing.Point(851, 69);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(86, 24);
            this.txtSex.TabIndex = 129;
            this.txtSex.TabStop = false;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(758, 50);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(51, 18);
            this.smartLabel11.TabIndex = 128;
            this.smartLabel11.Text = "Age(H)";
            // 
            // txtAgeHours
            // 
            this.txtAgeHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtAgeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeHours.Location = new System.Drawing.Point(758, 69);
            this.txtAgeHours.Name = "txtAgeHours";
            this.txtAgeHours.ReadOnly = true;
            this.txtAgeHours.Size = new System.Drawing.Size(65, 24);
            this.txtAgeHours.TabIndex = 127;
            this.txtAgeHours.TabStop = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(684, 50);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(51, 18);
            this.smartLabel9.TabIndex = 126;
            this.smartLabel9.Text = "Age(D)";
            // 
            // txtAgeDays
            // 
            this.txtAgeDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtAgeDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeDays.Location = new System.Drawing.Point(687, 69);
            this.txtAgeDays.Name = "txtAgeDays";
            this.txtAgeDays.ReadOnly = true;
            this.txtAgeDays.Size = new System.Drawing.Size(65, 24);
            this.txtAgeDays.TabIndex = 125;
            this.txtAgeDays.TabStop = false;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(618, 50);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(53, 18);
            this.smartLabel10.TabIndex = 124;
            this.smartLabel10.Text = "Age(M)";
            // 
            // txtAgeMonths
            // 
            this.txtAgeMonths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtAgeMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeMonths.Location = new System.Drawing.Point(616, 69);
            this.txtAgeMonths.Name = "txtAgeMonths";
            this.txtAgeMonths.ReadOnly = true;
            this.txtAgeMonths.Size = new System.Drawing.Size(65, 24);
            this.txtAgeMonths.TabIndex = 123;
            this.txtAgeMonths.TabStop = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(540, 50);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(49, 18);
            this.lblAge.TabIndex = 122;
            this.lblAge.Text = "Age(Y)";
            // 
            // txtAgeYears
            // 
            this.txtAgeYears.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtAgeYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAgeYears.Location = new System.Drawing.Point(540, 69);
            this.txtAgeYears.Name = "txtAgeYears";
            this.txtAgeYears.ReadOnly = true;
            this.txtAgeYears.Size = new System.Drawing.Size(65, 24);
            this.txtAgeYears.TabIndex = 121;
            this.txtAgeYears.TabStop = false;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(542, 3);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(52, 18);
            this.smartLabel7.TabIndex = 120;
            this.smartLabel7.Text = "Lab No";
            // 
            // txtSpecimenNo
            // 
            this.txtSpecimenNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtSpecimenNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecimenNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecimenNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSpecimenNo.Location = new System.Drawing.Point(543, 24);
            this.txtSpecimenNo.Name = "txtSpecimenNo";
            this.txtSpecimenNo.ReadOnly = true;
            this.txtSpecimenNo.Size = new System.Drawing.Size(394, 24);
            this.txtSpecimenNo.TabIndex = 119;
            this.txtSpecimenNo.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(3, 51);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(90, 18);
            this.smartLabel3.TabIndex = 118;
            this.smartLabel3.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(3, 70);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(377, 24);
            this.txtPatientName.TabIndex = 117;
            this.txtPatientName.TabStop = false;
            // 
            // cboPatientMr
            // 
            this.cboPatientMr.BackColor = System.Drawing.Color.DodgerBlue;
            this.cboPatientMr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPatientMr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPatientMr.ForeColor = System.Drawing.Color.White;
            this.cboPatientMr.Location = new System.Drawing.Point(324, 17);
            this.cboPatientMr.Name = "cboPatientMr";
            this.cboPatientMr.Size = new System.Drawing.Size(59, 34);
            this.cboPatientMr.TabIndex = 116;
            this.cboPatientMr.Text = "Find";
            this.cboPatientMr.UseVisualStyleBackColor = false;
            this.cboPatientMr.Click += new System.EventHandler(this.cboPatientMr_Click);
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.BackColor = System.Drawing.Color.Transparent;
            this.lblMr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMr.Location = new System.Drawing.Point(3, 3);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(51, 18);
            this.lblMr.TabIndex = 115;
            this.lblMr.Text = "MR No";
            // 
            // lvMRTests
            // 
            this.lvMRTests.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvMRTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMRTests.CheckBoxes = true;
            this.lvMRTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvMRTests.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMRTests.FullRowSelect = true;
            this.lvMRTests.GridLines = true;
            this.lvMRTests.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMRTests.Location = new System.Drawing.Point(-1, 115);
            this.lvMRTests.Name = "lvMRTests";
            this.lvMRTests.Size = new System.Drawing.Size(961, 397);
            this.lvMRTests.TabIndex = 134;
            this.lvMRTests.TabStop = false;
            this.lvMRTests.UseCompatibleStateImageBehavior = false;
            this.lvMRTests.View = System.Windows.Forms.View.Details;
            this.lvMRTests.SelectedIndexChanged += new System.EventHandler(this.lvMRTests_SelectedIndexChanged);
            // 
            // txtRegNo
            // 
            this.txtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo.Location = new System.Drawing.Point(553, 598);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(32, 24);
            this.txtRegNo.TabIndex = 97;
            this.txtRegNo.Visible = false;
            // 
            // txtHCN
            // 
            this.txtHCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCN.Location = new System.Drawing.Point(595, 598);
            this.txtHCN.Name = "txtHCN";
            this.txtHCN.Size = new System.Drawing.Size(39, 24);
            this.txtHCN.TabIndex = 96;
            this.txtHCN.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(302, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 194;
            this.label5.Text = "*";
            // 
            // frmLabelReprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(961, 649);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.txtHCN);
            this.isEnterTabAllow = true;
            this.Name = "frmLabelReprint";
            this.Load += new System.EventHandler(this.frmLabelReprint_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtHCN, 0);
            this.Controls.SetChildIndex(this.txtRegNo, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMRNo;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSex;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeHours;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeDays;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeMonths;
        private AtiqsControlLibrary.SmartLabel lblAge;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAgeYears;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSpecimenNo;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private System.Windows.Forms.Button cboPatientMr;
        private AtiqsControlLibrary.SmartLabel lblMr;
        private AtiqsControlLibrary.SmartListViewDetails lvMRTests;
        private AtiqsControlLibrary.SmartTextBox txtRegNo;
        private AtiqsControlLibrary.SmartTextBox txtHCN;
        private System.Windows.Forms.Label label5;
    }
}
