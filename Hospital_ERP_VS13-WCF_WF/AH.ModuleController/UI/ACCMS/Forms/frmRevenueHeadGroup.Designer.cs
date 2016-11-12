namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmRevenueHeadGroup
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
            this.txtRevHdID = new AtiqsControlLibrary.SmartTextBox();
            this.txtRevHdName = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.cboPriority = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvRhgr = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(267, 33);
            this.frmLabel.TabIndex = 6;
            this.frmLabel.Text = "Revenue Head Group";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvRhgr);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboPriority);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtRevHdName);
            this.pnlMain.Controls.Add(this.txtRevHdID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.TabIndex = 2;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 594);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(212, 171);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(62, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Group ID:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(200, 206);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(74, 13);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Group Title:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(214, 238);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(60, 13);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "Remarks:";
            // 
            // txtRevHdID
            // 
            this.txtRevHdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRevHdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevHdID.Location = new System.Drawing.Point(288, 171);
            this.txtRevHdID.Name = "txtRevHdID";
            this.txtRevHdID.ReadOnly = true;
            this.txtRevHdID.Size = new System.Drawing.Size(294, 24);
            this.txtRevHdID.TabIndex = 0;
            // 
            // txtRevHdName
            // 
            this.txtRevHdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRevHdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevHdName.Location = new System.Drawing.Point(288, 200);
            this.txtRevHdName.Name = "txtRevHdName";
            this.txtRevHdName.Size = new System.Drawing.Size(294, 24);
            this.txtRevHdName.TabIndex = 0;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(288, 231);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(294, 24);
            this.txtRemarks.TabIndex = 1;
            // 
            // cboPriority
            // 
            this.cboPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPriority.ForeColor = System.Drawing.Color.Blue;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboPriority.Location = new System.Drawing.Point(288, 263);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(294, 26);
            this.cboPriority.TabIndex = 20;
            this.cboPriority.Visible = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(227, 271);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(47, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Status:";
            this.smartLabel4.Visible = false;
            // 
            // lvRhgr
            // 
            this.lvRhgr.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvRhgr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRhgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvRhgr.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRhgr.FullRowSelect = true;
            this.lvRhgr.GridLines = true;
            this.lvRhgr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRhgr.Location = new System.Drawing.Point(11, 322);
            this.lvRhgr.Name = "lvRhgr";
            this.lvRhgr.Size = new System.Drawing.Size(842, 295);
            this.lvRhgr.TabIndex = 8;
            this.lvRhgr.UseCompatibleStateImageBehavior = false;
            this.lvRhgr.View = System.Windows.Forms.View.Details;
            this.lvRhgr.SelectedIndexChanged += new System.EventHandler(this.lvRhgr_SelectedIndexChanged);
            // 
            // frmRevenueHeadGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 619);
            this.Name = "frmRevenueHeadGroup";
            this.Load += new System.EventHandler(this.frmRevenueHeadGroup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvRhgr;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboPriority;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtRevHdName;
        private AtiqsControlLibrary.SmartTextBox txtRevHdID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
    }
}
