namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOPRanesthesiaMaster
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.Cboactive = new AtiqsControlLibrary.SmartComboBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtAnesthesiatitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtAnesthesiaID = new AtiqsControlLibrary.SmartTextBox();
            this.cbogroupID = new AtiqsControlLibrary.SmartComboBox();
            this.lvwAnesthesiaDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(230, 33);
            this.frmLabel.Text = "Anesthesia Master";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwAnesthesiaDetails);
            this.pnlMain.Controls.Add(this.cbogroupID);
            this.pnlMain.Controls.Add(this.Cboactive);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtAnesthesiatitle);
            this.pnlMain.Controls.Add(this.txtAnesthesiaID);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Size = new System.Drawing.Size(839, 529);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(841, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(389, 598);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 598);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 598);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(161, 598);
            this.btnNew.TabIndex = 8;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(731, 598);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(617, 598);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 638);
            this.groupBox1.Size = new System.Drawing.Size(841, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(165, 13);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(90, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Anesthesia ID:";
            this.smartLabel1.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(202, 59);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(62, 13);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Group ID:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(228, 93);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(36, 13);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "Title:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(204, 121);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(60, 13);
            this.smartLabel4.TabIndex = 3;
            this.smartLabel4.Text = "Remarks:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(217, 155);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(47, 13);
            this.smartLabel5.TabIndex = 4;
            this.smartLabel5.Text = "Active:";
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
            this.Cboactive.Location = new System.Drawing.Point(279, 149);
            this.Cboactive.Name = "Cboactive";
            this.Cboactive.Size = new System.Drawing.Size(335, 26);
            this.Cboactive.TabIndex = 3;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(279, 118);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(335, 24);
            this.txtRemarks.TabIndex = 2;
            // 
            // txtAnesthesiatitle
            // 
            this.txtAnesthesiatitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnesthesiatitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnesthesiatitle.Location = new System.Drawing.Point(279, 88);
            this.txtAnesthesiatitle.MaxLength = 200;
            this.txtAnesthesiatitle.Name = "txtAnesthesiatitle";
            this.txtAnesthesiatitle.Size = new System.Drawing.Size(335, 24);
            this.txtAnesthesiatitle.TabIndex = 1;
            // 
            // txtAnesthesiaID
            // 
            this.txtAnesthesiaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnesthesiaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnesthesiaID.Location = new System.Drawing.Point(279, 9);
            this.txtAnesthesiaID.Name = "txtAnesthesiaID";
            this.txtAnesthesiaID.Size = new System.Drawing.Size(334, 24);
            this.txtAnesthesiaID.TabIndex = 5;
            this.txtAnesthesiaID.Visible = false;
            // 
            // cbogroupID
            // 
            this.cbogroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbogroupID.ForeColor = System.Drawing.Color.Blue;
            this.cbogroupID.FormattingEnabled = true;
            this.cbogroupID.Location = new System.Drawing.Point(279, 55);
            this.cbogroupID.Name = "cbogroupID";
            this.cbogroupID.Size = new System.Drawing.Size(335, 26);
            this.cbogroupID.TabIndex = 0;
            // 
            // lvwAnesthesiaDetails
            // 
            this.lvwAnesthesiaDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwAnesthesiaDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwAnesthesiaDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwAnesthesiaDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAnesthesiaDetails.FullRowSelect = true;
            this.lvwAnesthesiaDetails.GridLines = true;
            this.lvwAnesthesiaDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwAnesthesiaDetails.Location = new System.Drawing.Point(11, 216);
            this.lvwAnesthesiaDetails.Name = "lvwAnesthesiaDetails";
            this.lvwAnesthesiaDetails.Size = new System.Drawing.Size(811, 298);
            this.lvwAnesthesiaDetails.TabIndex = 4;
            this.lvwAnesthesiaDetails.UseCompatibleStateImageBehavior = false;
            this.lvwAnesthesiaDetails.View = System.Windows.Forms.View.Details;
            this.lvwAnesthesiaDetails.SelectedIndexChanged += new System.EventHandler(this.lvwAnesthesiaDetails_SelectedIndexChanged);
            // 
            // frmOPRanesthesiaMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(841, 663);
            this.Name = "frmOPRanesthesiaMaster";
            this.Load += new System.EventHandler(this.frmOPRanesthesiaMaster_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox Cboactive;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtAnesthesiatitle;
        private AtiqsControlLibrary.SmartTextBox txtAnesthesiaID;
        private AtiqsControlLibrary.SmartComboBox cbogroupID;
        private AtiqsControlLibrary.SmartListViewDetails lvwAnesthesiaDetails;
    }
}
