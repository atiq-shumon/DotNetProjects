namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmDiagPackageMaster
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
            this.txtDiagPkgID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDiagPkgNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lblFeeCatID = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtDiagPkgName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDiagPkgAmt = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lvDiagPackage = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(293, 9);
            this.frmLabel.Size = new System.Drawing.Size(261, 33);
            this.frmLabel.Text = "Diag Package Master";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.lvDiagPackage);
            this.pnlMain.Controls.Add(this.txtDiagPkgAmt);
            this.pnlMain.Controls.Add(this.txtDiagPkgID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDiagPkgNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.lblFeeCatID);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtDiagPkgName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Size = new System.Drawing.Size(863, 681);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(634, 602);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(521, 602);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 600);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(408, 602);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(748, 602);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(120, 600);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 644);
            // 
            // txtDiagPkgID
            // 
            this.txtDiagPkgID.BackColor = System.Drawing.Color.Linen;
            this.txtDiagPkgID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagPkgID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagPkgID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDiagPkgID.Location = new System.Drawing.Point(21, 176);
            this.txtDiagPkgID.Name = "txtDiagPkgID";
            this.txtDiagPkgID.ReadOnly = true;
            this.txtDiagPkgID.Size = new System.Drawing.Size(141, 24);
            this.txtDiagPkgID.TabIndex = 73;
            this.txtDiagPkgID.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(168, 211);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(132, 15);
            this.smartLabel3.TabIndex = 72;
            this.smartLabel3.Text = "Package Name(Beng) :";
            // 
            // txtDiagPkgNameBeng
            // 
            this.txtDiagPkgNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagPkgNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagPkgNameBeng.Location = new System.Drawing.Point(168, 229);
            this.txtDiagPkgNameBeng.Name = "txtDiagPkgNameBeng";
            this.txtDiagPkgNameBeng.Size = new System.Drawing.Size(671, 24);
            this.txtDiagPkgNameBeng.TabIndex = 67;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(21, 260);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(65, 15);
            this.smartLabel5.TabIndex = 71;
            this.smartLabel5.Text = "Remarks :";
            // 
            // lblFeeCatID
            // 
            this.lblFeeCatID.AutoSize = true;
            this.lblFeeCatID.BackColor = System.Drawing.Color.Transparent;
            this.lblFeeCatID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFeeCatID.Location = new System.Drawing.Point(21, 157);
            this.lblFeeCatID.Name = "lblFeeCatID";
            this.lblFeeCatID.Size = new System.Drawing.Size(77, 15);
            this.lblFeeCatID.TabIndex = 69;
            this.lblFeeCatID.Text = "Package ID :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(21, 280);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(818, 32);
            this.txtRemarks.TabIndex = 3;
            // 
            // txtDiagPkgName
            // 
            this.txtDiagPkgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagPkgName.Location = new System.Drawing.Point(168, 176);
            this.txtDiagPkgName.Name = "txtDiagPkgName";
            this.txtDiagPkgName.Size = new System.Drawing.Size(671, 24);
            this.txtDiagPkgName.TabIndex = 1;
            this.txtDiagPkgName.TextChanged += new System.EventHandler(this.txtDiagPkgName_TextChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(168, 157);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(95, 15);
            this.smartLabel2.TabIndex = 70;
            this.smartLabel2.Text = "Package Name :";
            // 
            // txtDiagPkgAmt
            // 
            this.txtDiagPkgAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagPkgAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagPkgAmt.Location = new System.Drawing.Point(21, 229);
            this.txtDiagPkgAmt.Name = "txtDiagPkgAmt";
            this.txtDiagPkgAmt.Size = new System.Drawing.Size(141, 24);
            this.txtDiagPkgAmt.TabIndex = 2;
            // 
            // lvDiagPackage
            // 
            this.lvDiagPackage.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDiagPackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDiagPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDiagPackage.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDiagPackage.FullRowSelect = true;
            this.lvDiagPackage.GridLines = true;
            this.lvDiagPackage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDiagPackage.Location = new System.Drawing.Point(-1, 327);
            this.lvDiagPackage.Name = "lvDiagPackage";
            this.lvDiagPackage.Size = new System.Drawing.Size(864, 353);
            this.lvDiagPackage.TabIndex = 75;
            this.lvDiagPackage.UseCompatibleStateImageBehavior = false;
            this.lvDiagPackage.View = System.Windows.Forms.View.Details;
            this.lvDiagPackage.SelectedIndexChanged += new System.EventHandler(this.lvDiagPackage_SelectedIndexChanged);
            this.lvDiagPackage.Click += new System.EventHandler(this.lvDiagPackage_Click);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(21, 211);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(106, 15);
            this.smartLabel1.TabIndex = 76;
            this.smartLabel1.Text = "Package Amount :";
            // 
            // frmDiagPackageMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 669);
            this.isEnterTabAllow = true;
            this.Name = "frmDiagPackageMaster";
            this.Load += new System.EventHandler(this.frmDiagPackageMaster_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartNumericTextBox txtDiagPkgAmt;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDiagPkgID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDiagPkgNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel lblFeeCatID;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtDiagPkgName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvDiagPackage;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
    }
}
