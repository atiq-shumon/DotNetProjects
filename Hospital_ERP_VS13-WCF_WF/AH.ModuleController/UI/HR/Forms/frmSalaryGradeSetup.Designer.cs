namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmSalaryGradeSetup
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
            this.txtGradeID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtSerialNumber = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtGradeTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtGradeTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvGradeSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboLevels = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(162, 33);
            this.frmLabel.Text = "Grade Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboLevels);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.lvGradeSetup);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtGradeTitleBeng);
            this.pnlMain.Controls.Add(this.txtGradeTitle);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtSerialNumber);
            this.pnlMain.Controls.Add(this.txtGradeID);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(863, 510);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(521, 570);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(407, 570);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 570);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(293, 570);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(753, 570);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(642, 570);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // txtGradeID
            // 
            this.txtGradeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtGradeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGradeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtGradeID.Location = new System.Drawing.Point(722, 61);
            this.txtGradeID.MaxLength = 5;
            this.txtGradeID.Name = "txtGradeID";
            this.txtGradeID.ReadOnly = true;
            this.txtGradeID.Size = new System.Drawing.Size(117, 24);
            this.txtGradeID.TabIndex = 0;
            this.txtGradeID.TabStop = false;
            this.txtGradeID.Visible = false;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.Location = new System.Drawing.Point(722, 18);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(117, 24);
            this.txtSerialNumber.TabIndex = 3;
            this.txtSerialNumber.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(650, 67);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(54, 13);
            this.smartLabel1.TabIndex = 2;
            this.smartLabel1.Text = "GradeID";
            this.smartLabel1.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(609, 24);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(86, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Serial Number";
            this.smartLabel2.Visible = false;
            // 
            // txtGradeTitle
            // 
            this.txtGradeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGradeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeTitle.Location = new System.Drawing.Point(165, 61);
            this.txtGradeTitle.MaxLength = 300;
            this.txtGradeTitle.Name = "txtGradeTitle";
            this.txtGradeTitle.Size = new System.Drawing.Size(195, 24);
            this.txtGradeTitle.TabIndex = 1;
            this.txtGradeTitle.TextChanged += new System.EventHandler(this.txtGradeTitle_TextChanged);
            // 
            // txtGradeTitleBeng
            // 
            this.txtGradeTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGradeTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeTitleBeng.Location = new System.Drawing.Point(165, 106);
            this.txtGradeTitleBeng.MaxLength = 300;
            this.txtGradeTitleBeng.Name = "txtGradeTitleBeng";
            this.txtGradeTitleBeng.Size = new System.Drawing.Size(195, 24);
            this.txtGradeTitleBeng.TabIndex = 2;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(81, 67);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(78, 13);
            this.smartLabel3.TabIndex = 6;
            this.smartLabel3.Text = "Grade Title :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(34, 112);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(125, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Grade Title(Bangla) :";
            // 
            // lvGradeSetup
            // 
            this.lvGradeSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvGradeSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvGradeSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvGradeSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGradeSetup.FullRowSelect = true;
            this.lvGradeSetup.GridLines = true;
            this.lvGradeSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvGradeSetup.Location = new System.Drawing.Point(3, 163);
            this.lvGradeSetup.Name = "lvGradeSetup";
            this.lvGradeSetup.Size = new System.Drawing.Size(863, 342);
            this.lvGradeSetup.TabIndex = 8;
            this.lvGradeSetup.UseCompatibleStateImageBehavior = false;
            this.lvGradeSetup.View = System.Windows.Forms.View.Details;
            this.lvGradeSetup.SelectedIndexChanged += new System.EventHandler(this.lvGradeSetup_SelectedIndexChanged);
            this.lvGradeSetup.Click += new System.EventHandler(this.lvGradeSetup_Click);
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(364, 61);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 193;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.ForeColor = System.Drawing.Color.Red;
            this.smartLabel5.Location = new System.Drawing.Point(364, 108);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(21, 22);
            this.smartLabel5.TabIndex = 194;
            this.smartLabel5.Text = "*";
            // 
            // cboLevels
            // 
            this.cboLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevels.ForeColor = System.Drawing.Color.Blue;
            this.cboLevels.FormattingEnabled = true;
            this.cboLevels.Location = new System.Drawing.Point(165, 18);
            this.cboLevels.Name = "cboLevels";
            this.cboLevels.Size = new System.Drawing.Size(195, 26);
            this.cboLevels.TabIndex = 195;
            this.cboLevels.SelectedIndexChanged += new System.EventHandler(this.cboLevels_SelectedIndexChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(113, 21);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(46, 13);
            this.smartLabel6.TabIndex = 196;
            this.smartLabel6.Text = "Level :";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.Red;
            this.smartLabel7.Location = new System.Drawing.Point(364, 18);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(21, 22);
            this.smartLabel7.TabIndex = 197;
            this.smartLabel7.Text = "*";
            // 
            // frmSalaryGradeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmSalaryGradeSetup";
            this.Load += new System.EventHandler(this.frmSalaryGradeSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtGradeTitleBeng;
        private AtiqsControlLibrary.SmartTextBox txtGradeTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtSerialNumber;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtGradeID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartListViewDetails lvGradeSetup;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboLevels;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
    }
}
