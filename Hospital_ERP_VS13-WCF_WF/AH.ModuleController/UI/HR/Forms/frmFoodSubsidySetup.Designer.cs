namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmFoodSubsidySetup
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
            this.cboLevels = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtPercentage = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvFoodSubsidy = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtSerial = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(302, 9);
            this.frmLabel.Size = new System.Drawing.Size(249, 33);
            this.frmLabel.Text = "Food Subsidy Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtSerial);
            this.pnlMain.Controls.Add(this.lvFoodSubsidy);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtPercentage);
            this.pnlMain.Controls.Add(this.cboLevels);
            this.pnlMain.Controls.Add(this.smartLabel5);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(633, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(519, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 555);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(405, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(129, 555);
            this.btnPrint.Visible = false;
            // 
            // cboLevels
            // 
            this.cboLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevels.ForeColor = System.Drawing.Color.Blue;
            this.cboLevels.FormattingEnabled = true;
            this.cboLevels.Location = new System.Drawing.Point(11, 173);
            this.cboLevels.Name = "cboLevels";
            this.cboLevels.Size = new System.Drawing.Size(214, 26);
            this.cboLevels.TabIndex = 0;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(11, 155);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(46, 13);
            this.smartLabel5.TabIndex = 65;
            this.smartLabel5.Text = "Level :";
            // 
            // txtPercentage
            // 
            this.txtPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentage.Location = new System.Drawing.Point(235, 175);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(110, 24);
            this.txtPercentage.TabIndex = 1;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(232, 155);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(80, 13);
            this.smartLabel1.TabIndex = 67;
            this.smartLabel1.Text = "Percent (%) :";
            // 
            // lvFoodSubsidy
            // 
            this.lvFoodSubsidy.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvFoodSubsidy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFoodSubsidy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvFoodSubsidy.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFoodSubsidy.FullRowSelect = true;
            this.lvFoodSubsidy.GridLines = true;
            this.lvFoodSubsidy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFoodSubsidy.Location = new System.Drawing.Point(-1, 226);
            this.lvFoodSubsidy.Name = "lvFoodSubsidy";
            this.lvFoodSubsidy.Size = new System.Drawing.Size(864, 409);
            this.lvFoodSubsidy.TabIndex = 70;
            this.lvFoodSubsidy.UseCompatibleStateImageBehavior = false;
            this.lvFoodSubsidy.View = System.Windows.Forms.View.Details;
            this.lvFoodSubsidy.SelectedIndexChanged += new System.EventHandler(this.lvFoodSubsidy_SelectedIndexChanged);
            this.lvFoodSubsidy.Click += new System.EventHandler(this.lvFoodSubsidy_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(795, 155);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(56, 24);
            this.txtSerial.TabIndex = 206;
            this.txtSerial.Visible = false;
            // 
            // frmFoodSubsidySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmFoodSubsidySetup";
            this.Load += new System.EventHandler(this.frmFoodSubsidySetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartNumericTextBox txtPercentage;
        private AtiqsControlLibrary.SmartComboBox cboLevels;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvFoodSubsidy;
        private AtiqsControlLibrary.SmartTextBox txtSerial;

    }
}
