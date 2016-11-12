namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmScaleMSetup
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
            this.cboGrade = new AtiqsControlLibrary.SmartComboBox();
            this.txtSerialNumber = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtScaleID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtScaleTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtScaleTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lvScaleSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.cboLevels = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(314, 9);
            this.frmLabel.Size = new System.Drawing.Size(232, 33);
            this.frmLabel.Text = "Step Master Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.cboLevels);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.lvScaleSetup);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtScaleTitleBeng);
            this.pnlMain.Controls.Add(this.txtScaleTitle);
            this.pnlMain.Controls.Add(this.txtScaleID);
            this.pnlMain.Controls.Add(this.txtSerialNumber);
            this.pnlMain.Controls.Add(this.cboGrade);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(878, 510);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(878, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(539, 570);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 570);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 570);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(311, 570);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(765, 570);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(654, 570);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Size = new System.Drawing.Size(878, 23);
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.ForeColor = System.Drawing.Color.Blue;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(193, 61);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(198, 26);
            this.cboGrade.TabIndex = 0;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSerialNumber.Location = new System.Drawing.Point(744, 14);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(121, 24);
            this.txtSerialNumber.TabIndex = 2;
            this.txtSerialNumber.TabStop = false;
            this.txtSerialNumber.Visible = false;
            // 
            // txtScaleID
            // 
            this.txtScaleID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtScaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtScaleID.Location = new System.Drawing.Point(744, 44);
            this.txtScaleID.MaxLength = 5;
            this.txtScaleID.Name = "txtScaleID";
            this.txtScaleID.ReadOnly = true;
            this.txtScaleID.Size = new System.Drawing.Size(121, 24);
            this.txtScaleID.TabIndex = 1;
            this.txtScaleID.TabStop = false;
            this.txtScaleID.Visible = false;
            // 
            // txtScaleTitle
            // 
            this.txtScaleTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScaleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleTitle.Location = new System.Drawing.Point(193, 99);
            this.txtScaleTitle.MaxLength = 300;
            this.txtScaleTitle.Name = "txtScaleTitle";
            this.txtScaleTitle.Size = new System.Drawing.Size(294, 24);
            this.txtScaleTitle.TabIndex = 3;
            this.txtScaleTitle.TextChanged += new System.EventHandler(this.txtScaleTitle_TextChanged);
            // 
            // txtScaleTitleBeng
            // 
            this.txtScaleTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScaleTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleTitleBeng.Location = new System.Drawing.Point(193, 143);
            this.txtScaleTitleBeng.MaxLength = 300;
            this.txtScaleTitleBeng.Name = "txtScaleTitleBeng";
            this.txtScaleTitleBeng.Size = new System.Drawing.Size(294, 24);
            this.txtScaleTitleBeng.TabIndex = 4;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(682, 50);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(58, 13);
            this.smartLabel1.TabIndex = 302;
            this.smartLabel1.Text = "Step ID :";
            this.smartLabel1.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(119, 105);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(70, 13);
            this.smartLabel2.TabIndex = 303;
            this.smartLabel2.Text = "Step Title :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(68, 149);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(121, 13);
            this.smartLabel3.TabIndex = 304;
            this.smartLabel3.Text = "Step Title (Bangla) :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(639, 20);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(86, 13);
            this.smartLabel4.TabIndex = 305;
            this.smartLabel4.Text = "Serial Number";
            this.smartLabel4.Visible = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(140, 68);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(49, 13);
            this.smartLabel5.TabIndex = 306;
            this.smartLabel5.Text = "Grade :";
            // 
            // lvScaleSetup
            // 
            this.lvScaleSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvScaleSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvScaleSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvScaleSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvScaleSetup.FullRowSelect = true;
            this.lvScaleSetup.GridLines = true;
            this.lvScaleSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvScaleSetup.Location = new System.Drawing.Point(-1, 211);
            this.lvScaleSetup.Name = "lvScaleSetup";
            this.lvScaleSetup.Size = new System.Drawing.Size(878, 294);
            this.lvScaleSetup.TabIndex = 307;
            this.lvScaleSetup.UseCompatibleStateImageBehavior = false;
            this.lvScaleSetup.View = System.Windows.Forms.View.Details;
            this.lvScaleSetup.SelectedIndexChanged += new System.EventHandler(this.lvScaleSetup_SelectedIndexChanged);
            this.lvScaleSetup.Click += new System.EventHandler(this.lvScaleSetup_Click);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.ForeColor = System.Drawing.Color.Red;
            this.smartLabel6.Location = new System.Drawing.Point(397, 61);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(21, 22);
            this.smartLabel6.TabIndex = 196;
            this.smartLabel6.Text = "*";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.Red;
            this.smartLabel7.Location = new System.Drawing.Point(490, 99);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(21, 22);
            this.smartLabel7.TabIndex = 308;
            this.smartLabel7.Text = "*";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.ForeColor = System.Drawing.Color.Red;
            this.smartLabel8.Location = new System.Drawing.Point(490, 143);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(21, 22);
            this.smartLabel8.TabIndex = 309;
            this.smartLabel8.Text = "*";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.ForeColor = System.Drawing.Color.Red;
            this.smartLabel9.Location = new System.Drawing.Point(397, 20);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(21, 22);
            this.smartLabel9.TabIndex = 311;
            this.smartLabel9.Text = "*";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(140, 27);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(46, 13);
            this.smartLabel10.TabIndex = 312;
            this.smartLabel10.Text = "Level :";
            // 
            // cboLevels
            // 
            this.cboLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevels.ForeColor = System.Drawing.Color.Blue;
            this.cboLevels.FormattingEnabled = true;
            this.cboLevels.Location = new System.Drawing.Point(193, 20);
            this.cboLevels.Name = "cboLevels";
            this.cboLevels.Size = new System.Drawing.Size(198, 26);
            this.cboLevels.TabIndex = 310;
            this.cboLevels.SelectedIndexChanged += new System.EventHandler(this.cboLevels_SelectedIndexChanged);
            // 
            // frmScaleMSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(878, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmScaleMSetup";
            this.Load += new System.EventHandler(this.frmScaleMSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtScaleTitleBeng;
        private AtiqsControlLibrary.SmartTextBox txtScaleTitle;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtScaleID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSerialNumber;
        private AtiqsControlLibrary.SmartComboBox cboGrade;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartListViewDetails lvScaleSetup;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartComboBox cboLevels;
    }
}
