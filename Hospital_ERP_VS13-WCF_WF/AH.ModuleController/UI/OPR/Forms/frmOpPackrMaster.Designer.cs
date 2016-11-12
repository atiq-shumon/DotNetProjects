namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOpPackrMaster
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
            this.txtName = new AtiqsControlLibrary.SmartTextBox();
            this.lvwPackage = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtItemCode = new AtiqsControlLibrary.SmartTextBox();
            this.cboUnitName = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(200, 33);
            this.frmLabel.Text = "Package Master";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboUnitName);
            this.pnlMain.Controls.Add(this.txtItemCode);
            this.pnlMain.Controls.Add(this.lvwPackage);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(638, 555);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(525, 555);
            this.btnSave.TabIndex = 2;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 555);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(412, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 555);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(131, 555);
            this.btnPrint.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel1.Location = new System.Drawing.Point(223, 179);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(48, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(280, 173);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 24);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lvwPackage
            // 
            this.lvwPackage.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwPackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwPackage.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPackage.FullRowSelect = true;
            this.lvwPackage.GridLines = true;
            this.lvwPackage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwPackage.Location = new System.Drawing.Point(11, 243);
            this.lvwPackage.Name = "lvwPackage";
            this.lvwPackage.Size = new System.Drawing.Size(844, 382);
            this.lvwPackage.TabIndex = 2;
            this.lvwPackage.UseCompatibleStateImageBehavior = false;
            this.lvwPackage.View = System.Windows.Forms.View.Details;
            this.lvwPackage.SelectedIndexChanged += new System.EventHandler(this.lvwPackage_SelectedIndexChanged);
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(34, 156);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(121, 24);
            this.txtItemCode.TabIndex = 3;
            this.txtItemCode.Visible = false;
            // 
            // cboUnitName
            // 
            this.cboUnitName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnitName.ForeColor = System.Drawing.Color.Blue;
            this.cboUnitName.FormattingEnabled = true;
            this.cboUnitName.Location = new System.Drawing.Point(280, 208);
            this.cboUnitName.Name = "cboUnitName";
            this.cboUnitName.Size = new System.Drawing.Size(384, 26);
            this.cboUnitName.TabIndex = 1;
            this.cboUnitName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUnitName_KeyPress);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel2.Location = new System.Drawing.Point(196, 212);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(77, 14);
            this.smartLabel2.TabIndex = 5;
            this.smartLabel2.Text = "Unit Name:";
            // 
            // frmOpPackrMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmOpPackrMaster";
            this.Load += new System.EventHandler(this.frmOpPackrMaster_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwPackage;
        private AtiqsControlLibrary.SmartTextBox txtName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtItemCode;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboUnitName;
    }
}
