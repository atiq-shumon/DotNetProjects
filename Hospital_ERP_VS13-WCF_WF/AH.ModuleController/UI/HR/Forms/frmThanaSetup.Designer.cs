namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmThanaSetup
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
            this.cboDistrict = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtThana = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lvThana = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtThanaOld = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(165, 33);
            this.frmLabel.Text = "Thana Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtThanaOld);
            this.pnlMain.Controls.Add(this.lvThana);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtThana);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboDistrict);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(635, 556);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(522, 556);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 556);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(409, 556);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(747, 556);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(125, 556);
            this.btnPrint.Visible = false;
            // 
            // cboDistrict
            // 
            this.cboDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrict.ForeColor = System.Drawing.Color.Blue;
            this.cboDistrict.FormattingEnabled = true;
            this.cboDistrict.Location = new System.Drawing.Point(11, 176);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Size = new System.Drawing.Size(234, 26);
            this.cboDistrict.TabIndex = 0;
            this.cboDistrict.SelectedIndexChanged += new System.EventHandler(this.cboDistrict_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(11, 154);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(47, 13);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "District";
            // 
            // txtThana
            // 
            this.txtThana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThana.Location = new System.Drawing.Point(251, 177);
            this.txtThana.Name = "txtThana";
            this.txtThana.Size = new System.Drawing.Size(334, 24);
            this.txtThana.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(248, 158);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(43, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Thana";
            // 
            // lvThana
            // 
            this.lvThana.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvThana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvThana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvThana.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThana.FullRowSelect = true;
            this.lvThana.GridLines = true;
            this.lvThana.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvThana.Location = new System.Drawing.Point(-1, 223);
            this.lvThana.Name = "lvThana";
            this.lvThana.Size = new System.Drawing.Size(863, 408);
            this.lvThana.TabIndex = 4;
            this.lvThana.UseCompatibleStateImageBehavior = false;
            this.lvThana.View = System.Windows.Forms.View.Details;
            this.lvThana.SelectedIndexChanged += new System.EventHandler(this.lvThana_SelectedIndexChanged);
            this.lvThana.Click += new System.EventHandler(this.lvThana_Click);
            // 
            // txtThanaOld
            // 
            this.txtThanaOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanaOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanaOld.Location = new System.Drawing.Point(591, 176);
            this.txtThanaOld.Name = "txtThanaOld";
            this.txtThanaOld.Size = new System.Drawing.Size(257, 24);
            this.txtThanaOld.TabIndex = 5;
            this.txtThanaOld.Visible = false;
            // 
            // frmThanaSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmThanaSetup";
            this.Load += new System.EventHandler(this.frmThanaSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboDistrict;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtThana;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvThana;
        private AtiqsControlLibrary.SmartTextBox txtThanaOld;
    }
}
