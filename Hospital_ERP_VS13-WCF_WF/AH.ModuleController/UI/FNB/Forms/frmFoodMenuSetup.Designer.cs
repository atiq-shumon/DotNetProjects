namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmFoodMenuSetup
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
            this.txtMenuID = new AtiqsControlLibrary.SmartTextBox();
            this.lvwFoodMenuSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtMenuName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtRate = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(202, 33);
            this.frmLabel.Text = "Set Menu Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtRate);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtMenuID);
            this.pnlMain.Controls.Add(this.lvwFoodMenuSetup);
            this.pnlMain.Controls.Add(this.txtMenuName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(635, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(522, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 553);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(409, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(129, 553);
            this.btnPrint.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(208, 173);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(59, 13);
            this.smartLabel2.TabIndex = 14;
            this.smartLabel2.Text = "Menu ID:";
            this.smartLabel2.Visible = false;
            // 
            // txtMenuID
            // 
            this.txtMenuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMenuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuID.Location = new System.Drawing.Point(278, 167);
            this.txtMenuID.Name = "txtMenuID";
            this.txtMenuID.Size = new System.Drawing.Size(379, 24);
            this.txtMenuID.TabIndex = 13;
            this.txtMenuID.Visible = false;
            // 
            // lvwFoodMenuSetup
            // 
            this.lvwFoodMenuSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwFoodMenuSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwFoodMenuSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwFoodMenuSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFoodMenuSetup.FullRowSelect = true;
            this.lvwFoodMenuSetup.GridLines = true;
            this.lvwFoodMenuSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFoodMenuSetup.Location = new System.Drawing.Point(7, 315);
            this.lvwFoodMenuSetup.Name = "lvwFoodMenuSetup";
            this.lvwFoodMenuSetup.Size = new System.Drawing.Size(847, 306);
            this.lvwFoodMenuSetup.TabIndex = 12;
            this.lvwFoodMenuSetup.UseCompatibleStateImageBehavior = false;
            this.lvwFoodMenuSetup.View = System.Windows.Forms.View.Details;
            this.lvwFoodMenuSetup.SelectedIndexChanged += new System.EventHandler(this.lvwFoodMenuSetup_SelectedIndexChanged);
            // 
            // txtMenuName
            // 
            this.txtMenuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuName.Location = new System.Drawing.Point(278, 200);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(379, 24);
            this.txtMenuName.TabIndex = 11;
            this.txtMenuName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMenuName_KeyPress);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(189, 204);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(78, 13);
            this.smartLabel1.TabIndex = 10;
            this.smartLabel1.Text = "Menu Name:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(278, 256);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(379, 24);
            this.txtRemarks.TabIndex = 16;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(207, 260);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(60, 13);
            this.smartLabel3.TabIndex = 15;
            this.smartLabel3.Text = "Remarks:";
            // 
            // txtRate
            // 
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(278, 228);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(379, 24);
            this.txtRate.TabIndex = 18;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(229, 232);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(38, 13);
            this.smartLabel4.TabIndex = 17;
            this.smartLabel4.Text = "Rate:";
            // 
            // frmFoodMenuSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmFoodMenuSetup";
            this.Load += new System.EventHandler(this.frmFoodMenuSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtMenuID;
        private AtiqsControlLibrary.SmartListViewDetails lvwFoodMenuSetup;
        private AtiqsControlLibrary.SmartTextBox txtMenuName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtRate;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
    }
}
