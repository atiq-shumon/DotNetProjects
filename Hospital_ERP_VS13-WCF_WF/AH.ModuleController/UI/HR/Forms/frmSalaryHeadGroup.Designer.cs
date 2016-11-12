namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmSalaryHeadGroup
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
            this.txtHeadGroupID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtHeadGroupTitle = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtHeadGroupTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtSerial = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.lvSalHeadGrp = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboHeadType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(314, 9);
            this.frmLabel.Size = new System.Drawing.Size(237, 33);
            this.frmLabel.Text = "Salary Head Group";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.cboHeadType);
            this.pnlMain.Controls.Add(this.lvSalHeadGrp);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtSerial);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtHeadGroupTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtHeadGroupTitle);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtHeadGroupID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(863, 510);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(519, 570);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(405, 570);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 570);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(291, 570);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(747, 570);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(636, 570);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(124, 16);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(81, 13);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Head Type : ";
            // 
            // txtHeadGroupID
            // 
            this.txtHeadGroupID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtHeadGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadGroupID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHeadGroupID.Location = new System.Drawing.Point(215, 41);
            this.txtHeadGroupID.MaxLength = 3;
            this.txtHeadGroupID.Name = "txtHeadGroupID";
            this.txtHeadGroupID.ReadOnly = true;
            this.txtHeadGroupID.Size = new System.Drawing.Size(154, 24);
            this.txtHeadGroupID.TabIndex = 1;
            this.txtHeadGroupID.TabStop = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(105, 41);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(100, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Head Group ID :";
            // 
            // txtHeadGroupTitle
            // 
            this.txtHeadGroupTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadGroupTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadGroupTitle.Location = new System.Drawing.Point(215, 67);
            this.txtHeadGroupTitle.MaxLength = 300;
            this.txtHeadGroupTitle.Name = "txtHeadGroupTitle";
            this.txtHeadGroupTitle.Size = new System.Drawing.Size(367, 24);
            this.txtHeadGroupTitle.TabIndex = 3;
            this.txtHeadGroupTitle.TextChanged += new System.EventHandler(this.txtHeadGroupTitle_TextChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(93, 69);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(112, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Head Group Title :";
            // 
            // txtHeadGroupTitleBeng
            // 
            this.txtHeadGroupTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadGroupTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadGroupTitleBeng.Location = new System.Drawing.Point(215, 95);
            this.txtHeadGroupTitleBeng.MaxLength = 300;
            this.txtHeadGroupTitleBeng.Name = "txtHeadGroupTitleBeng";
            this.txtHeadGroupTitleBeng.Size = new System.Drawing.Size(367, 24);
            this.txtHeadGroupTitleBeng.TabIndex = 4;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(46, 102);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(159, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Head Group Title(Bangla) :";
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(461, 41);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(121, 24);
            this.txtSerial.TabIndex = 2;
            this.txtSerial.Visible = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(408, 47);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(47, 13);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "Serial :";
            this.smartLabel5.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(215, 128);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(367, 64);
            this.txtRemarks.TabIndex = 5;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(141, 132);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(64, 13);
            this.smartLabel6.TabIndex = 11;
            this.smartLabel6.Text = "Remarks :";
            // 
            // lvSalHeadGrp
            // 
            this.lvSalHeadGrp.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvSalHeadGrp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSalHeadGrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSalHeadGrp.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSalHeadGrp.FullRowSelect = true;
            this.lvSalHeadGrp.GridLines = true;
            this.lvSalHeadGrp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSalHeadGrp.Location = new System.Drawing.Point(-1, 232);
            this.lvSalHeadGrp.Name = "lvSalHeadGrp";
            this.lvSalHeadGrp.Size = new System.Drawing.Size(863, 273);
            this.lvSalHeadGrp.TabIndex = 12;
            this.lvSalHeadGrp.UseCompatibleStateImageBehavior = false;
            this.lvSalHeadGrp.View = System.Windows.Forms.View.Details;
            this.lvSalHeadGrp.SelectedIndexChanged += new System.EventHandler(this.lvSalHeadGrp_SelectedIndexChanged);
            this.lvSalHeadGrp.Click += new System.EventHandler(this.lvSalHeadGrp_Click);
            // 
            // cboHeadType
            // 
            this.cboHeadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeadType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHeadType.ForeColor = System.Drawing.Color.Blue;
            this.cboHeadType.FormattingEnabled = true;
            this.cboHeadType.Location = new System.Drawing.Point(215, 9);
            this.cboHeadType.Name = "cboHeadType";
            this.cboHeadType.Size = new System.Drawing.Size(154, 26);
            this.cboHeadType.TabIndex = 0;
            this.cboHeadType.SelectedIndexChanged += new System.EventHandler(this.cboHeadType_SelectedIndexChanged);
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(368, 9);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 193;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.Red;
            this.smartLabel7.Location = new System.Drawing.Point(585, 67);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(21, 22);
            this.smartLabel7.TabIndex = 194;
            this.smartLabel7.Text = "*";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.ForeColor = System.Drawing.Color.Red;
            this.smartLabel8.Location = new System.Drawing.Point(585, 95);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(21, 22);
            this.smartLabel8.TabIndex = 195;
            this.smartLabel8.Text = "*";
            // 
            // frmSalaryHeadGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmSalaryHeadGroup";
            this.Load += new System.EventHandler(this.frmSalaryHeadGroup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtHeadGroupTitleBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtHeadGroupTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHeadGroupID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvSalHeadGrp;
        private AtiqsControlLibrary.SmartComboBox cboHeadType;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
    }
}
