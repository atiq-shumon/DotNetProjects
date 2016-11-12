namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmSalaryHead
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
            this.cboHeadType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtHeadID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtHeadTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.txtHeadTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.lvSalHead = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtSerial = new AtiqsControlLibrary.SmartNumericTextBox();
            this.cboHeadGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(327, 9);
            this.frmLabel.Size = new System.Drawing.Size(232, 33);
            this.frmLabel.Text = "Salary Head Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboHeadGroup);
            this.pnlMain.Controls.Add(this.txtSerial);
            this.pnlMain.Controls.Add(this.lvSalHead);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtHeadTitle);
            this.pnlMain.Controls.Add(this.txtHeadTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtHeadID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboHeadType);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(883, 510);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(883, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(546, 570);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(432, 570);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 570);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(318, 570);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(771, 570);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(660, 570);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Size = new System.Drawing.Size(883, 23);
            // 
            // cboHeadType
            // 
            this.cboHeadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeadType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHeadType.ForeColor = System.Drawing.Color.Blue;
            this.cboHeadType.FormattingEnabled = true;
            this.cboHeadType.Location = new System.Drawing.Point(153, 19);
            this.cboHeadType.Name = "cboHeadType";
            this.cboHeadType.Size = new System.Drawing.Size(179, 26);
            this.cboHeadType.TabIndex = 1;
            this.cboHeadType.SelectedIndexChanged += new System.EventHandler(this.cboHeadType_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(69, 26);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(69, 13);
            this.smartLabel1.TabIndex = 2;
            this.smartLabel1.Text = "Head Type";
            // 
            // txtHeadID
            // 
            this.txtHeadID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtHeadID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHeadID.Location = new System.Drawing.Point(504, 19);
            this.txtHeadID.MaxLength = 3;
            this.txtHeadID.Name = "txtHeadID";
            this.txtHeadID.ReadOnly = true;
            this.txtHeadID.Size = new System.Drawing.Size(148, 24);
            this.txtHeadID.TabIndex = 4;
            this.txtHeadID.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(436, 25);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(54, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Head ID";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(52, 96);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(86, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Serial Number";
            this.smartLabel4.Visible = false;
            // 
            // txtHeadTitleBeng
            // 
            this.txtHeadTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadTitleBeng.Location = new System.Drawing.Point(504, 90);
            this.txtHeadTitleBeng.MaxLength = 300;
            this.txtHeadTitleBeng.Name = "txtHeadTitleBeng";
            this.txtHeadTitleBeng.Size = new System.Drawing.Size(332, 24);
            this.txtHeadTitleBeng.TabIndex = 6;
            // 
            // txtHeadTitle
            // 
            this.txtHeadTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadTitle.Location = new System.Drawing.Point(504, 54);
            this.txtHeadTitle.MaxLength = 300;
            this.txtHeadTitle.Name = "txtHeadTitle";
            this.txtHeadTitle.Size = new System.Drawing.Size(332, 24);
            this.txtHeadTitle.TabIndex = 5;
            this.txtHeadTitle.TextChanged += new System.EventHandler(this.txtHeadTitle_TextChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(504, 126);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(332, 69);
            this.txtRemarks.TabIndex = 7;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(424, 60);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(66, 13);
            this.smartLabel5.TabIndex = 11;
            this.smartLabel5.Text = "Head Title";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(373, 96);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(117, 13);
            this.smartLabel6.TabIndex = 12;
            this.smartLabel6.Text = "Head Title (Bangla)";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(434, 154);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(56, 13);
            this.smartLabel7.TabIndex = 13;
            this.smartLabel7.Text = "Remarks";
            // 
            // lvSalHead
            // 
            this.lvSalHead.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvSalHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSalHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSalHead.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSalHead.FullRowSelect = true;
            this.lvSalHead.GridLines = true;
            this.lvSalHead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSalHead.Location = new System.Drawing.Point(-1, 221);
            this.lvSalHead.Name = "lvSalHead";
            this.lvSalHead.Size = new System.Drawing.Size(883, 284);
            this.lvSalHead.TabIndex = 14;
            this.lvSalHead.UseCompatibleStateImageBehavior = false;
            this.lvSalHead.View = System.Windows.Forms.View.Details;
            this.lvSalHead.SelectedIndexChanged += new System.EventHandler(this.lvSalHead_SelectedIndexChanged);
            this.lvSalHead.Click += new System.EventHandler(this.lvSalHead_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(153, 90);
            this.txtSerial.MaxLength = 3;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(179, 24);
            this.txtSerial.TabIndex = 3;
            this.txtSerial.Visible = false;
            // 
            // cboHeadGroup
            // 
            this.cboHeadGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeadGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHeadGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboHeadGroup.FormattingEnabled = true;
            this.cboHeadGroup.Location = new System.Drawing.Point(153, 54);
            this.cboHeadGroup.Name = "cboHeadGroup";
            this.cboHeadGroup.Size = new System.Drawing.Size(179, 26);
            this.cboHeadGroup.TabIndex = 2;
            this.cboHeadGroup.SelectedIndexChanged += new System.EventHandler(this.cboHeadGroup_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(63, 61);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(75, 13);
            this.smartLabel2.TabIndex = 19;
            this.smartLabel2.Text = "Head Group";
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(334, 19);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 193;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.ForeColor = System.Drawing.Color.Red;
            this.smartLabel8.Location = new System.Drawing.Point(333, 54);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(21, 22);
            this.smartLabel8.TabIndex = 194;
            this.smartLabel8.Text = "*";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.ForeColor = System.Drawing.Color.Red;
            this.smartLabel9.Location = new System.Drawing.Point(839, 54);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(21, 22);
            this.smartLabel9.TabIndex = 195;
            this.smartLabel9.Text = "*";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.ForeColor = System.Drawing.Color.Red;
            this.smartLabel10.Location = new System.Drawing.Point(838, 90);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(21, 22);
            this.smartLabel10.TabIndex = 196;
            this.smartLabel10.Text = "*";
            // 
            // frmSalaryHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(883, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmSalaryHead";
            this.Load += new System.EventHandler(this.frmSalaryHead_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHeadID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboHeadType;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtHeadTitle;
        private AtiqsControlLibrary.SmartTextBox txtHeadTitleBeng;
        private AtiqsControlLibrary.SmartListViewDetails lvSalHead;
        private AtiqsControlLibrary.SmartNumericTextBox txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboHeadGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
    }
}
