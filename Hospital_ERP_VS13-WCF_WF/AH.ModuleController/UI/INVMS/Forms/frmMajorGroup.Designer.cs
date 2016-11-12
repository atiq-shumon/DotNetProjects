namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmMajorGroup
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
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtmajorId = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboStatus = new AtiqsControlLibrary.SmartComboBox();
            this.lvwTerms = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtMajorGroup = new AtiqsControlLibrary.SmartTextBox();
            this.CboStoretype = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(164, 33);
            this.frmLabel.Text = "Major Group";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtmajorId);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboStatus);
            this.pnlMain.Controls.Add(this.lvwTerms);
            this.pnlMain.Controls.Add(this.txtMajorGroup);
            this.pnlMain.Controls.Add(this.CboStoretype);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(638, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(529, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(33, 555);
            this.btnDelete.Size = new System.Drawing.Size(35, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(420, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(91, 555);
            this.btnPrint.Size = new System.Drawing.Size(34, 39);
            this.btnPrint.Visible = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(206, 275);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(70, 14);
            this.smartLabel4.TabIndex = 23;
            this.smartLabel4.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(289, 271);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(294, 56);
            this.txtRemarks.TabIndex = 22;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // txtmajorId
            // 
            this.txtmajorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmajorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmajorId.Location = new System.Drawing.Point(657, 176);
            this.txtmajorId.Name = "txtmajorId";
            this.txtmajorId.Size = new System.Drawing.Size(100, 24);
            this.txtmajorId.TabIndex = 21;
            this.txtmajorId.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(222, 237);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(54, 14);
            this.smartLabel3.TabIndex = 20;
            this.smartLabel3.Text = "Status:";
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
            this.cboStatus.Location = new System.Drawing.Point(289, 234);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(294, 26);
            this.cboStatus.TabIndex = 19;
            this.cboStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboStatus_KeyPress);
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
            this.lvwTerms.Location = new System.Drawing.Point(4, 335);
            this.lvwTerms.Name = "lvwTerms";
            this.lvwTerms.Size = new System.Drawing.Size(854, 295);
            this.lvwTerms.TabIndex = 18;
            this.lvwTerms.UseCompatibleStateImageBehavior = false;
            this.lvwTerms.View = System.Windows.Forms.View.Details;
            this.lvwTerms.SelectedIndexChanged += new System.EventHandler(this.lvwTerms_SelectedIndexChanged);
            // 
            // txtMajorGroup
            // 
            this.txtMajorGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMajorGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajorGroup.Location = new System.Drawing.Point(289, 200);
            this.txtMajorGroup.Name = "txtMajorGroup";
            this.txtMajorGroup.Size = new System.Drawing.Size(294, 24);
            this.txtMajorGroup.TabIndex = 15;
            this.txtMajorGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMajorGroup_KeyPress);
            // 
            // CboStoretype
            // 
            this.CboStoretype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStoretype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboStoretype.ForeColor = System.Drawing.Color.Blue;
            this.CboStoretype.FormattingEnabled = true;
            this.CboStoretype.Location = new System.Drawing.Point(289, 167);
            this.CboStoretype.Name = "CboStoretype";
            this.CboStoretype.Size = new System.Drawing.Size(294, 26);
            this.CboStoretype.TabIndex = 14;
            this.CboStoretype.SelectedIndexChanged += new System.EventHandler(this.CboStoretype_SelectedIndexChanged);
            this.CboStoretype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboStoretype_KeyPress);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(140, 204);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(136, 14);
            this.smartLabel2.TabIndex = 13;
            this.smartLabel2.Text = "Major Group Name:";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(192, 166);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(84, 14);
            this.smartLabel1.TabIndex = 12;
            this.smartLabel1.Text = "Store Type:";
            // 
            // frmMajorGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmMajorGroup";
            this.Load += new System.EventHandler(this.frmMajorGroup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtmajorId;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboStatus;
        private AtiqsControlLibrary.SmartListViewDetails lvwTerms;
        private AtiqsControlLibrary.SmartTextBox txtMajorGroup;
        private AtiqsControlLibrary.SmartComboBox CboStoretype;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
    }
}
