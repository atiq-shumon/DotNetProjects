namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOPRAnesthesiaGroup
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.Cboactive = new AtiqsControlLibrary.SmartComboBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtGroupTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtGroupId = new AtiqsControlLibrary.SmartTextBox();
            this.lvwGroupDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(223, 33);
            this.frmLabel.Text = "Anesthesia Group";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwGroupDetails);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.Cboactive);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtGroupTitle);
            this.pnlMain.Controls.Add(this.txtGroupId);
            this.pnlMain.Location = new System.Drawing.Point(0, 64);
            this.pnlMain.Size = new System.Drawing.Size(839, 407);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(841, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(320, 476);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 476);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(434, 476);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(92, 476);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(662, 476);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(548, 476);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 516);
            this.groupBox1.Size = new System.Drawing.Size(841, 25);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(262, 128);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(55, 16);
            this.smartLabel4.TabIndex = 17;
            this.smartLabel4.Text = "Status:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(243, 96);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(74, 16);
            this.smartLabel3.TabIndex = 16;
            this.smartLabel3.Text = "Remarks:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(228, 61);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(89, 16);
            this.smartLabel2.TabIndex = 15;
            this.smartLabel2.Text = "Group Title:";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(244, 16);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(73, 16);
            this.smartLabel1.TabIndex = 14;
            this.smartLabel1.Text = "Group ID:";
            this.smartLabel1.Visible = false;
            // 
            // Cboactive
            // 
            this.Cboactive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cboactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cboactive.ForeColor = System.Drawing.Color.Blue;
            this.Cboactive.FormattingEnabled = true;
            this.Cboactive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.Cboactive.Location = new System.Drawing.Point(326, 124);
            this.Cboactive.Name = "Cboactive";
            this.Cboactive.Size = new System.Drawing.Size(335, 26);
            this.Cboactive.TabIndex = 13;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(326, 90);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(334, 24);
            this.txtRemarks.TabIndex = 12;
            // 
            // txtGroupTitle
            // 
            this.txtGroupTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupTitle.Location = new System.Drawing.Point(326, 57);
            this.txtGroupTitle.Name = "txtGroupTitle";
            this.txtGroupTitle.Size = new System.Drawing.Size(334, 24);
            this.txtGroupTitle.TabIndex = 11;
            // 
            // txtGroupId
            // 
            this.txtGroupId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupId.Location = new System.Drawing.Point(326, 12);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(334, 24);
            this.txtGroupId.TabIndex = 10;
            this.txtGroupId.Visible = false;
            // 
            // lvwGroupDetails
            // 
            this.lvwGroupDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwGroupDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwGroupDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwGroupDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwGroupDetails.FullRowSelect = true;
            this.lvwGroupDetails.GridLines = true;
            this.lvwGroupDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwGroupDetails.Location = new System.Drawing.Point(6, 161);
            this.lvwGroupDetails.Name = "lvwGroupDetails";
            this.lvwGroupDetails.Size = new System.Drawing.Size(824, 236);
            this.lvwGroupDetails.TabIndex = 18;
            this.lvwGroupDetails.UseCompatibleStateImageBehavior = false;
            this.lvwGroupDetails.View = System.Windows.Forms.View.Details;
            this.lvwGroupDetails.SelectedIndexChanged += new System.EventHandler(this.lvwGroupDetails_SelectedIndexChanged);
            // 
            // frmOPRAnesthesiaGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(841, 541);
            this.Name = "frmOPRAnesthesiaGroup";
            this.Load += new System.EventHandler(this.frmOPRAnesthesiaGroup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox Cboactive;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtGroupTitle;
        private AtiqsControlLibrary.SmartTextBox txtGroupId;
        private AtiqsControlLibrary.SmartListViewDetails lvwGroupDetails;
    }
}
