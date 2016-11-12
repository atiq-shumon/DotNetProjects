namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmTermsConditions
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
            this.txtTermsID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboStatus = new AtiqsControlLibrary.SmartComboBox();
            this.chkBold = new AtiqsControlLibrary.SmartCheckBox();
            this.chkAutoSelected = new AtiqsControlLibrary.SmartCheckBox();
            this.txtTermsCondition = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lvwTerms = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(301, 9);
            this.frmLabel.Size = new System.Drawing.Size(262, 33);
            this.frmLabel.Text = "Terms and Condition";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwTerms);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtTermsID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboStatus);
            this.pnlMain.Controls.Add(this.chkBold);
            this.pnlMain.Controls.Add(this.chkAutoSelected);
            this.pnlMain.Controls.Add(this.txtTermsCondition);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnEdit
            // 
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
            this.btnDelete.Location = new System.Drawing.Point(52, 554);
            this.btnDelete.Size = new System.Drawing.Size(38, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(420, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(104, 554);
            this.btnPrint.Size = new System.Drawing.Size(31, 39);
            this.btnPrint.Visible = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(161, 236);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(70, 14);
            this.smartLabel4.TabIndex = 20;
            this.smartLabel4.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(238, 232);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(294, 56);
            this.txtRemarks.TabIndex = 19;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // txtTermsID
            // 
            this.txtTermsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTermsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermsID.Location = new System.Drawing.Point(601, 170);
            this.txtTermsID.Name = "txtTermsID";
            this.txtTermsID.Size = new System.Drawing.Size(100, 24);
            this.txtTermsID.TabIndex = 18;
            this.txtTermsID.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(174, 198);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(54, 14);
            this.smartLabel3.TabIndex = 17;
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
            this.cboStatus.Location = new System.Drawing.Point(238, 195);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(294, 26);
            this.cboStatus.TabIndex = 16;
            this.cboStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboStatus_KeyPress);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.ForeColor = System.Drawing.Color.Black;
            this.chkBold.Location = new System.Drawing.Point(626, 237);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(54, 22);
            this.chkBold.TabIndex = 15;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkAutoSelected
            // 
            this.chkAutoSelected.AutoSize = true;
            this.chkAutoSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoSelected.ForeColor = System.Drawing.Color.Black;
            this.chkAutoSelected.Location = new System.Drawing.Point(626, 200);
            this.chkAutoSelected.Name = "chkAutoSelected";
            this.chkAutoSelected.Size = new System.Drawing.Size(115, 22);
            this.chkAutoSelected.TabIndex = 14;
            this.chkAutoSelected.Text = "Auto Selected";
            this.chkAutoSelected.UseVisualStyleBackColor = true;
            // 
            // txtTermsCondition
            // 
            this.txtTermsCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTermsCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermsCondition.Location = new System.Drawing.Point(238, 161);
            this.txtTermsCondition.Name = "txtTermsCondition";
            this.txtTermsCondition.Size = new System.Drawing.Size(294, 24);
            this.txtTermsCondition.TabIndex = 13;
            this.txtTermsCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTermsCondition_KeyPress);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(100, 165);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(133, 14);
            this.smartLabel2.TabIndex = 12;
            this.smartLabel2.Text = "Terms && Condition:";
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
            this.lvwTerms.Location = new System.Drawing.Point(-1, 298);
            this.lvwTerms.Name = "lvwTerms";
            this.lvwTerms.Size = new System.Drawing.Size(862, 336);
            this.lvwTerms.TabIndex = 21;
            this.lvwTerms.UseCompatibleStateImageBehavior = false;
            this.lvwTerms.View = System.Windows.Forms.View.Details;
            this.lvwTerms.SelectedIndexChanged += new System.EventHandler(this.lvwTerms_SelectedIndexChanged);
            // 
            // frmTermsConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmTermsConditions";
            this.Load += new System.EventHandler(this.frmTermsConditions_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtTermsID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboStatus;
        private AtiqsControlLibrary.SmartCheckBox chkBold;
        private AtiqsControlLibrary.SmartCheckBox chkAutoSelected;
        private AtiqsControlLibrary.SmartTextBox txtTermsCondition;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvwTerms;
    }
}
