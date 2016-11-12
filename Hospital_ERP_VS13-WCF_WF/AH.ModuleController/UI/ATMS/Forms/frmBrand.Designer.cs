namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmBrand
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
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtbrandId = new AtiqsControlLibrary.SmartTextBox();
            this.txtBrandName = new AtiqsControlLibrary.SmartTextBox();
            this.cboGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboGroup);
            this.pnlMain.Controls.Add(this.txtBrandName);
            this.pnlMain.Controls.Add(this.txtbrandId);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(863, 344);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(406, 263);
            this.btnEdit.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(293, 263);
            this.btnSave.TabIndex = 2;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(519, 263);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(180, 263);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(741, 263);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(630, 263);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 316);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(153, 213);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(106, 16);
            this.smartLabel2.TabIndex = 32;
            this.smartLabel2.Text = "Brand Name :";
            this.smartLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(179, 179);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(80, 16);
            this.smartLabel1.TabIndex = 31;
            this.smartLabel1.Text = "Brand ID :";
            this.smartLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbrandId
            // 
            this.txtbrandId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbrandId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbrandId.Location = new System.Drawing.Point(275, 179);
            this.txtbrandId.Name = "txtbrandId";
            this.txtbrandId.ReadOnly = true;
            this.txtbrandId.Size = new System.Drawing.Size(322, 24);
            this.txtbrandId.TabIndex = 33;
            // 
            // txtBrandName
            // 
            this.txtBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.Location = new System.Drawing.Point(275, 213);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(332, 24);
            this.txtBrandName.TabIndex = 0;
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(275, 243);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(332, 26);
            this.cboGroup.TabIndex = 1;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(153, 247);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(106, 16);
            this.smartLabel3.TabIndex = 36;
            this.smartLabel3.Text = "Group Name :";
            this.smartLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 341);
            this.Name = "frmBrand";
            this.Load += new System.EventHandler(this.frmBrand_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboGroup;
        private AtiqsControlLibrary.SmartTextBox txtBrandName;
        private AtiqsControlLibrary.SmartTextBox txtbrandId;
    }
}
