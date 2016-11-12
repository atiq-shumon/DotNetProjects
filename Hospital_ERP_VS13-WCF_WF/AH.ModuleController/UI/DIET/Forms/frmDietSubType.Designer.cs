namespace AH.ModuleController.UI.DIET.Forms
{
    partial class frmDietSubType
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
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtSubMenuName = new AtiqsControlLibrary.SmartTextBox();
            this.cboDietType = new AtiqsControlLibrary.SmartComboBox();
            this.lvwSubItem = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtDietSubType = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(285, 8);
            this.frmLabel.Size = new System.Drawing.Size(181, 33);
            this.frmLabel.Text = "Diet Sub Type";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtDietSubType);
            this.pnlMain.Controls.Add(this.lvwSubItem);
            this.pnlMain.Controls.Add(this.cboDietType);
            this.pnlMain.Controls.Add(this.txtSubMenuName);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Size = new System.Drawing.Size(714, 637);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(714, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(489, 553);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(376, 553);
            this.btnSave.TabIndex = 3;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 552);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(263, 553);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(600, 553);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(128, 552);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 596);
            this.groupBox1.Size = new System.Drawing.Size(714, 25);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.White;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(122, 168);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(100, 15);
            this.smartLabel7.TabIndex = 175;
            this.smartLabel7.Text = "Sub Menu Name:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.White;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(160, 206);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(62, 15);
            this.smartLabel2.TabIndex = 174;
            this.smartLabel2.Text = "Diet Type:";
            // 
            // txtSubMenuName
            // 
            this.txtSubMenuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubMenuName.Location = new System.Drawing.Point(233, 166);
            this.txtSubMenuName.Name = "txtSubMenuName";
            this.txtSubMenuName.Size = new System.Drawing.Size(332, 24);
            this.txtSubMenuName.TabIndex = 0;
            this.txtSubMenuName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubMenuName_KeyPress);
            // 
            // cboDietType
            // 
            this.cboDietType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDietType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDietType.ForeColor = System.Drawing.Color.Blue;
            this.cboDietType.FormattingEnabled = true;
            this.cboDietType.Location = new System.Drawing.Point(233, 204);
            this.cboDietType.Name = "cboDietType";
            this.cboDietType.Size = new System.Drawing.Size(332, 26);
            this.cboDietType.TabIndex = 1;
            this.cboDietType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDietType_KeyPress);
            // 
            // lvwSubItem
            // 
            this.lvwSubItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwSubItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwSubItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwSubItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSubItem.FullRowSelect = true;
            this.lvwSubItem.GridLines = true;
            this.lvwSubItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwSubItem.Location = new System.Drawing.Point(7, 259);
            this.lvwSubItem.Name = "lvwSubItem";
            this.lvwSubItem.Size = new System.Drawing.Size(698, 366);
            this.lvwSubItem.TabIndex = 2;
            this.lvwSubItem.UseCompatibleStateImageBehavior = false;
            this.lvwSubItem.View = System.Windows.Forms.View.Details;
            this.lvwSubItem.SelectedIndexChanged += new System.EventHandler(this.lvwSubItem_SelectedIndexChanged);
            // 
            // txtDietSubType
            // 
            this.txtDietSubType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDietSubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDietSubType.Location = new System.Drawing.Point(21, 206);
            this.txtDietSubType.Name = "txtDietSubType";
            this.txtDietSubType.Size = new System.Drawing.Size(100, 24);
            this.txtDietSubType.TabIndex = 176;
            this.txtDietSubType.Visible = false;
            // 
            // frmDietSubType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(714, 621);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmDietSubType";
            this.Load += new System.EventHandler(this.frmDietSubType_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvwSubItem;
        private AtiqsControlLibrary.SmartComboBox cboDietType;
        private AtiqsControlLibrary.SmartTextBox txtSubMenuName;
        private AtiqsControlLibrary.SmartTextBox txtDietSubType;
    }
}
