namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmDietCategory
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
            this.txtDietCategory = new AtiqsControlLibrary.SmartTextBox();
            this.lvwDietCategory = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtDietID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(346, 7);
            this.frmLabel.Size = new System.Drawing.Size(176, 33);
            this.frmLabel.Text = "Diet Category";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtDietID);
            this.pnlMain.Controls.Add(this.lvwDietCategory);
            this.pnlMain.Controls.Add(this.txtDietCategory);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(863, 595);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(641, 512);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(528, 512);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(41, 512);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(415, 512);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(752, 512);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(152, 512);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 554);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(167, 209);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(88, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Diet Category:";
            // 
            // txtDietCategory
            // 
            this.txtDietCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDietCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDietCategory.Location = new System.Drawing.Point(280, 205);
            this.txtDietCategory.Name = "txtDietCategory";
            this.txtDietCategory.Size = new System.Drawing.Size(379, 24);
            this.txtDietCategory.TabIndex = 1;
            this.txtDietCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDietCategory_KeyPress);
            // 
            // lvwDietCategory
            // 
            this.lvwDietCategory.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwDietCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwDietCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwDietCategory.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDietCategory.FullRowSelect = true;
            this.lvwDietCategory.GridLines = true;
            this.lvwDietCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwDietCategory.Location = new System.Drawing.Point(8, 270);
            this.lvwDietCategory.Name = "lvwDietCategory";
            this.lvwDietCategory.Size = new System.Drawing.Size(847, 316);
            this.lvwDietCategory.TabIndex = 2;
            this.lvwDietCategory.UseCompatibleStateImageBehavior = false;
            this.lvwDietCategory.View = System.Windows.Forms.View.Details;
            this.lvwDietCategory.SelectedIndexChanged += new System.EventHandler(this.lvwDietCategory_SelectedIndexChanged);
            // 
            // txtDietID
            // 
            this.txtDietID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDietID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDietID.Location = new System.Drawing.Point(279, 172);
            this.txtDietID.Name = "txtDietID";
            this.txtDietID.Size = new System.Drawing.Size(379, 24);
            this.txtDietID.TabIndex = 3;
            this.txtDietID.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(204, 177);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(51, 13);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "Diet ID:";
            this.smartLabel2.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(279, 235);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(379, 24);
            this.txtRemarks.TabIndex = 6;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(195, 239);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(60, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Remarks:";
            // 
            // frmDietCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 579);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmDietCategory";
            this.Load += new System.EventHandler(this.frmDietCategory_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwDietCategory;
        private AtiqsControlLibrary.SmartTextBox txtDietCategory;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDietID;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
    }
}
