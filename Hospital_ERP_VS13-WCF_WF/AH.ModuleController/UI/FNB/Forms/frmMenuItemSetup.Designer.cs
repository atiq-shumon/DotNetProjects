namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmMenuItemSetup
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
            this.lvwMenuItemSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.cbotypeId = new System.Windows.Forms.ComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboMenuId = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtNetAmount = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.lvwFoodList = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnTypeRefresh = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnTypeRefresh1 = new System.Windows.Forms.Button();
            this.btnType1 = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(363, 8);
            this.frmLabel.Size = new System.Drawing.Size(266, 33);
            this.frmLabel.Text = "Set Menu Item Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnTypeRefresh1);
            this.pnlMain.Controls.Add(this.btnType1);
            this.pnlMain.Controls.Add(this.btnTypeRefresh);
            this.pnlMain.Controls.Add(this.btnType);
            this.pnlMain.Controls.Add(this.lvwFoodList);
            this.pnlMain.Controls.Add(this.txtNetAmount);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboMenuId);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cbotypeId);
            this.pnlMain.Controls.Add(this.lvwMenuItemSetup);
            this.pnlMain.Size = new System.Drawing.Size(1139, 636);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1140, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(901, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(788, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(96, 553);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(675, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1012, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(207, 553);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(1140, 25);
            // 
            // lvwMenuItemSetup
            // 
            this.lvwMenuItemSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwMenuItemSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwMenuItemSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwMenuItemSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMenuItemSetup.FullRowSelect = true;
            this.lvwMenuItemSetup.GridLines = true;
            this.lvwMenuItemSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwMenuItemSetup.Location = new System.Drawing.Point(7, 261);
            this.lvwMenuItemSetup.Name = "lvwMenuItemSetup";
            this.lvwMenuItemSetup.Size = new System.Drawing.Size(774, 326);
            this.lvwMenuItemSetup.TabIndex = 13;
            this.lvwMenuItemSetup.UseCompatibleStateImageBehavior = false;
            this.lvwMenuItemSetup.View = System.Windows.Forms.View.Details;
            this.lvwMenuItemSetup.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvwMenuItemSetup_ItemCheck);
            this.lvwMenuItemSetup.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwMenuItemSetup_ItemChecked);
            // 
            // cbotypeId
            // 
            this.cbotypeId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotypeId.FormattingEnabled = true;
            this.cbotypeId.Location = new System.Drawing.Point(254, 193);
            this.cbotypeId.Name = "cbotypeId";
            this.cbotypeId.Size = new System.Drawing.Size(370, 24);
            this.cbotypeId.TabIndex = 30;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(185, 199);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(67, 16);
            this.smartLabel1.TabIndex = 31;
            this.smartLabel1.Text = "Type Id:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(153, 164);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(99, 16);
            this.smartLabel2.TabIndex = 33;
            this.smartLabel2.Text = "Set Menu Id:";
            // 
            // cboMenuId
            // 
            this.cboMenuId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMenuId.FormattingEnabled = true;
            this.cboMenuId.Location = new System.Drawing.Point(254, 163);
            this.cboMenuId.Name = "cboMenuId";
            this.cboMenuId.Size = new System.Drawing.Size(370, 24);
            this.cboMenuId.TabIndex = 32;
            this.cboMenuId.SelectedIndexChanged += new System.EventHandler(this.cboMenuId_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(254, 223);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(370, 24);
            this.txtRemarks.TabIndex = 35;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(176, 230);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(76, 16);
            this.smartLabel5.TabIndex = 34;
            this.smartLabel5.Text = "Remarks:";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetAmount.Enabled = false;
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.Location = new System.Drawing.Point(543, 593);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(179, 24);
            this.txtNetAmount.TabIndex = 37;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(487, 597);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(49, 16);
            this.smartLabel3.TabIndex = 36;
            this.smartLabel3.Text = "Total:";
            // 
            // lvwFoodList
            // 
            this.lvwFoodList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwFoodList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwFoodList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwFoodList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFoodList.FullRowSelect = true;
            this.lvwFoodList.GridLines = true;
            this.lvwFoodList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFoodList.Location = new System.Drawing.Point(802, 148);
            this.lvwFoodList.Name = "lvwFoodList";
            this.lvwFoodList.Size = new System.Drawing.Size(332, 469);
            this.lvwFoodList.TabIndex = 38;
            this.lvwFoodList.UseCompatibleStateImageBehavior = false;
            this.lvwFoodList.View = System.Windows.Forms.View.Details;
            this.lvwFoodList.SelectedIndexChanged += new System.EventHandler(this.lvwFoodList_SelectedIndexChanged);
            // 
            // btnTypeRefresh
            // 
            this.btnTypeRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTypeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnTypeRefresh.Location = new System.Drawing.Point(649, 162);
            this.btnTypeRefresh.Name = "btnTypeRefresh";
            this.btnTypeRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnTypeRefresh.TabIndex = 141;
            this.btnTypeRefresh.Text = "..";
            this.btnTypeRefresh.UseVisualStyleBackColor = false;
            this.btnTypeRefresh.Click += new System.EventHandler(this.btnTypeRefresh_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.ForestGreen;
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType.ForeColor = System.Drawing.Color.White;
            this.btnType.Location = new System.Drawing.Point(628, 162);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(19, 26);
            this.btnType.TabIndex = 140;
            this.btnType.Text = "+";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnTypeRefresh1
            // 
            this.btnTypeRefresh1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTypeRefresh1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeRefresh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeRefresh1.ForeColor = System.Drawing.Color.Black;
            this.btnTypeRefresh1.Location = new System.Drawing.Point(649, 191);
            this.btnTypeRefresh1.Name = "btnTypeRefresh1";
            this.btnTypeRefresh1.Size = new System.Drawing.Size(24, 24);
            this.btnTypeRefresh1.TabIndex = 143;
            this.btnTypeRefresh1.Text = "..";
            this.btnTypeRefresh1.UseVisualStyleBackColor = false;
            this.btnTypeRefresh1.Click += new System.EventHandler(this.btnTypeRefresh1_Click);
            // 
            // btnType1
            // 
            this.btnType1.BackColor = System.Drawing.Color.ForestGreen;
            this.btnType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType1.ForeColor = System.Drawing.Color.White;
            this.btnType1.Location = new System.Drawing.Point(628, 191);
            this.btnType1.Name = "btnType1";
            this.btnType1.Size = new System.Drawing.Size(19, 26);
            this.btnType1.TabIndex = 142;
            this.btnType1.Text = "+";
            this.btnType1.UseVisualStyleBackColor = false;
            this.btnType1.Click += new System.EventHandler(this.btnType1_Click);
            // 
            // frmMenuItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1140, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmMenuItemSetup";
            this.Load += new System.EventHandler(this.frmMenuItemSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwMenuItemSetup;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.ComboBox cbotypeId;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.ComboBox cboMenuId;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtNetAmount;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartListViewDetails lvwFoodList;
        private System.Windows.Forms.Button btnTypeRefresh1;
        private System.Windows.Forms.Button btnType1;
        private System.Windows.Forms.Button btnTypeRefresh;
        private System.Windows.Forms.Button btnType;
    }
}
