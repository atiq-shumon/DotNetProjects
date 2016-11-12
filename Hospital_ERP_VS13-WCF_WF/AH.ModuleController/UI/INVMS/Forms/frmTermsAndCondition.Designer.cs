namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmTermsandCondition
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboStoreName = new AtiqsControlLibrary.SmartComboBox();
            this.txtTermsCondition = new AtiqsControlLibrary.SmartTextBox();
            this.chkAutoSelected = new AtiqsControlLibrary.SmartCheckBox();
            this.chkBold = new AtiqsControlLibrary.SmartCheckBox();
            this.lvwTerms = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboStatus = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtTermsID = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(262, 33);
            this.frmLabel.Text = "Terms and Condition";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtTermsID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboStatus);
            this.pnlMain.Controls.Add(this.lvwTerms);
            this.pnlMain.Controls.Add(this.chkBold);
            this.pnlMain.Controls.Add(this.chkAutoSelected);
            this.pnlMain.Controls.Add(this.txtTermsCondition);
            this.pnlMain.Controls.Add(this.cboStoreName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(529, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(638, 555);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(311, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(27, 555);
            this.btnPrint.Size = new System.Drawing.Size(46, 39);
            this.btnPrint.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(194, 170);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(90, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Store Name:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(153, 208);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(133, 14);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Terms && Condition:";
            // 
            // cboStoreName
            // 
            this.cboStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreName.ForeColor = System.Drawing.Color.Blue;
            this.cboStoreName.FormattingEnabled = true;
            this.cboStoreName.Location = new System.Drawing.Point(291, 171);
            this.cboStoreName.Name = "cboStoreName";
            this.cboStoreName.Size = new System.Drawing.Size(294, 26);
            this.cboStoreName.TabIndex = 2;
            this.cboStoreName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboStoreName_KeyPress);
            // 
            // txtTermsCondition
            // 
            this.txtTermsCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTermsCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermsCondition.Location = new System.Drawing.Point(291, 204);
            this.txtTermsCondition.Name = "txtTermsCondition";
            this.txtTermsCondition.Size = new System.Drawing.Size(294, 24);
            this.txtTermsCondition.TabIndex = 3;
            this.txtTermsCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTermsCondition_KeyPress);
            // 
            // chkAutoSelected
            // 
            this.chkAutoSelected.AutoSize = true;
            this.chkAutoSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoSelected.ForeColor = System.Drawing.Color.Black;
            this.chkAutoSelected.Location = new System.Drawing.Point(679, 243);
            this.chkAutoSelected.Name = "chkAutoSelected";
            this.chkAutoSelected.Size = new System.Drawing.Size(115, 22);
            this.chkAutoSelected.TabIndex = 4;
            this.chkAutoSelected.Text = "Auto Selected";
            this.chkAutoSelected.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.ForeColor = System.Drawing.Color.Black;
            this.chkBold.Location = new System.Drawing.Point(679, 280);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(54, 22);
            this.chkBold.TabIndex = 5;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // lvwTerms
            // 
            this.lvwTerms.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwTerms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwTerms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTerms.FullRowSelect = true;
            this.lvwTerms.GridLines = true;
            this.lvwTerms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwTerms.Location = new System.Drawing.Point(9, 337);
            this.lvwTerms.Name = "lvwTerms";
            this.lvwTerms.Size = new System.Drawing.Size(846, 294);
            this.lvwTerms.TabIndex = 6;
            this.lvwTerms.UseCompatibleStateImageBehavior = false;
            this.lvwTerms.View = System.Windows.Forms.View.Details;
            this.lvwTerms.SelectedIndexChanged += new System.EventHandler(this.lvwTerms_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.Blue;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatus.Location = new System.Drawing.Point(291, 238);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(294, 26);
            this.cboStatus.TabIndex = 7;
            this.cboStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboStatus_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(227, 241);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(54, 14);
            this.smartLabel3.TabIndex = 8;
            this.smartLabel3.Text = "Status:";
            // 
            // txtTermsID
            // 
            this.txtTermsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTermsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermsID.Location = new System.Drawing.Point(659, 180);
            this.txtTermsID.Name = "txtTermsID";
            this.txtTermsID.Size = new System.Drawing.Size(100, 24);
            this.txtTermsID.TabIndex = 9;
            this.txtTermsID.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(291, 275);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(294, 56);
            this.txtRemarks.TabIndex = 10;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(214, 279);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(70, 14);
            this.smartLabel4.TabIndex = 11;
            this.smartLabel4.Text = "Remarks:";
            // 
            // frmTermsandCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmTermsandCondition";
            this.Load += new System.EventHandler(this.frmTermsandCondition_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwTerms;
        private AtiqsControlLibrary.SmartCheckBox chkBold;
        private AtiqsControlLibrary.SmartCheckBox chkAutoSelected;
        private AtiqsControlLibrary.SmartTextBox txtTermsCondition;
        private AtiqsControlLibrary.SmartComboBox cboStoreName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboStatus;
        private AtiqsControlLibrary.SmartTextBox txtTermsID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
    }
}
