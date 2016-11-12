namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmFoodCategory
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
            this.txtFoodID = new AtiqsControlLibrary.SmartTextBox();
            this.lvwFoodCategory = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtFoodCategory = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(188, 33);
            this.frmLabel.Text = "Food Category";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtFoodID);
            this.pnlMain.Controls.Add(this.lvwFoodCategory);
            this.pnlMain.Controls.Add(this.txtFoodCategory);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(211, 164);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(56, 13);
            this.smartLabel2.TabIndex = 9;
            this.smartLabel2.Text = "Food ID:";
            this.smartLabel2.Visible = false;
            // 
            // txtFoodID
            // 
            this.txtFoodID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodID.Location = new System.Drawing.Point(278, 158);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(379, 24);
            this.txtFoodID.TabIndex = 8;
            this.txtFoodID.Visible = false;
            // 
            // lvwFoodCategory
            // 
            this.lvwFoodCategory.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwFoodCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwFoodCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwFoodCategory.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFoodCategory.FullRowSelect = true;
            this.lvwFoodCategory.GridLines = true;
            this.lvwFoodCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFoodCategory.Location = new System.Drawing.Point(7, 269);
            this.lvwFoodCategory.Name = "lvwFoodCategory";
            this.lvwFoodCategory.Size = new System.Drawing.Size(847, 352);
            this.lvwFoodCategory.TabIndex = 7;
            this.lvwFoodCategory.UseCompatibleStateImageBehavior = false;
            this.lvwFoodCategory.View = System.Windows.Forms.View.Details;
            this.lvwFoodCategory.SelectedIndexChanged += new System.EventHandler(this.lvwFoodCategory_SelectedIndexChanged);
            // 
            // txtFoodCategory
            // 
            this.txtFoodCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodCategory.Location = new System.Drawing.Point(278, 191);
            this.txtFoodCategory.Name = "txtFoodCategory";
            this.txtFoodCategory.Size = new System.Drawing.Size(379, 24);
            this.txtFoodCategory.TabIndex = 6;
            this.txtFoodCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodCategory_KeyPress);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(174, 195);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(93, 13);
            this.smartLabel1.TabIndex = 5;
            this.smartLabel1.Text = "Food Category:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(278, 228);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(379, 24);
            this.txtRemarks.TabIndex = 11;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(207, 232);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(60, 13);
            this.smartLabel3.TabIndex = 10;
            this.smartLabel3.Text = "Remarks:";
            // 
            // frmFoodCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmFoodCategory";
            this.Load += new System.EventHandler(this.frmFoodCategory_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtFoodID;
        private AtiqsControlLibrary.SmartListViewDetails lvwFoodCategory;
        private AtiqsControlLibrary.SmartTextBox txtFoodCategory;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
    }
}
