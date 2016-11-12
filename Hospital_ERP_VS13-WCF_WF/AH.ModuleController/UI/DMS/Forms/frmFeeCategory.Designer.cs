namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmFeeCategory
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtFeeCatNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lblFeeCatID = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtFeeCatName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lvFeeCategory = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtFeeCat = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(247, 33);
            this.frmLabel.Text = "Fee Category Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtFeeCat);
            this.pnlMain.Controls.Add(this.lvFeeCategory);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtFeeCatNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.lblFeeCatID);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtFeeCatName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 510);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(416, 574);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 574);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(529, 574);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(190, 574);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(751, 574);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(640, 574);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 613);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(10, 101);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(146, 18);
            this.smartLabel3.TabIndex = 63;
            this.smartLabel3.Text = "Category Name(Beng) :";
            // 
            // txtFeeCatNameBeng
            // 
            this.txtFeeCatNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeeCatNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeeCatNameBeng.Location = new System.Drawing.Point(173, 98);
            this.txtFeeCatNameBeng.Name = "txtFeeCatNameBeng";
            this.txtFeeCatNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtFeeCatNameBeng.TabIndex = 2;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(88, 136);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 62;
            this.smartLabel5.Text = "Remarks :";
            // 
            // lblFeeCatID
            // 
            this.lblFeeCatID.AutoSize = true;
            this.lblFeeCatID.BackColor = System.Drawing.Color.Transparent;
            this.lblFeeCatID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFeeCatID.Location = new System.Drawing.Point(70, 23);
            this.lblFeeCatID.Name = "lblFeeCatID";
            this.lblFeeCatID.Size = new System.Drawing.Size(86, 18);
            this.lblFeeCatID.TabIndex = 60;
            this.lblFeeCatID.Text = "Category ID :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(173, 136);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(395, 62);
            this.txtRemarks.TabIndex = 3;
            // 
            // txtFeeCatName
            // 
            this.txtFeeCatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeeCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeeCatName.Location = new System.Drawing.Point(173, 59);
            this.txtFeeCatName.Name = "txtFeeCatName";
            this.txtFeeCatName.Size = new System.Drawing.Size(395, 24);
            this.txtFeeCatName.TabIndex = 1;
            this.txtFeeCatName.TextChanged += new System.EventHandler(this.txtFeeCatName_TextChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(49, 62);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(107, 18);
            this.smartLabel2.TabIndex = 61;
            this.smartLabel2.Text = "Category Name :";
            // 
            // lvFeeCategory
            // 
            this.lvFeeCategory.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvFeeCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFeeCategory.CheckBoxes = true;
            this.lvFeeCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvFeeCategory.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFeeCategory.FullRowSelect = true;
            this.lvFeeCategory.GridLines = true;
            this.lvFeeCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFeeCategory.Location = new System.Drawing.Point(-1, 232);
            this.lvFeeCategory.Name = "lvFeeCategory";
            this.lvFeeCategory.Size = new System.Drawing.Size(863, 277);
            this.lvFeeCategory.TabIndex = 64;
            this.lvFeeCategory.TabStop = false;
            this.lvFeeCategory.UseCompatibleStateImageBehavior = false;
            this.lvFeeCategory.View = System.Windows.Forms.View.Details;
            this.lvFeeCategory.SelectedIndexChanged += new System.EventHandler(this.lvFeeCategory_SelectedIndexChanged);
            this.lvFeeCategory.Click += new System.EventHandler(this.lvFeeCategory_Click);
            // 
            // txtFeeCat
            // 
            this.txtFeeCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtFeeCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeeCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeeCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtFeeCat.Location = new System.Drawing.Point(173, 23);
            this.txtFeeCat.Name = "txtFeeCat";
            this.txtFeeCat.ReadOnly = true;
            this.txtFeeCat.Size = new System.Drawing.Size(189, 24);
            this.txtFeeCat.TabIndex = 65;
            this.txtFeeCat.TabStop = false;
            // 
            // frmFeeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 636);
            this.isEnterTabAllow = true;
            this.Name = "frmFeeCategory";
            this.Load += new System.EventHandler(this.frmFeeCategory_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtFeeCatNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel lblFeeCatID;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtFeeCatName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvFeeCategory;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtFeeCat;
    }
}
