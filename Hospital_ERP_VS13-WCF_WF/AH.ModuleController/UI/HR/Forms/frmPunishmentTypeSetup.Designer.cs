namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmPunishmentTypeSetup
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
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel20 = new AtiqsControlLibrary.SmartLabel();
            this.chkQuantitive = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtPunishmentTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPunishmentTitle = new AtiqsControlLibrary.SmartTextBox();
            this.lvPunishementType = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtPunishmentID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(271, 9);
            this.frmLabel.Size = new System.Drawing.Size(296, 33);
            this.frmLabel.Text = "Punishment Type Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvPunishementType);
            this.pnlMain.Controls.Add(this.txtPunishmentTitle);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel20);
            this.pnlMain.Controls.Add(this.txtPunishmentTitleBeng);
            this.pnlMain.Controls.Add(this.chkQuantitive);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel5);
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.Red;
            this.smartLabel7.Location = new System.Drawing.Point(408, 192);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(21, 22);
            this.smartLabel7.TabIndex = 168;
            this.smartLabel7.Text = "*";
            // 
            // smartLabel20
            // 
            this.smartLabel20.AutoSize = true;
            this.smartLabel20.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel20.ForeColor = System.Drawing.Color.Red;
            this.smartLabel20.Location = new System.Drawing.Point(408, 160);
            this.smartLabel20.Name = "smartLabel20";
            this.smartLabel20.Size = new System.Drawing.Size(21, 22);
            this.smartLabel20.TabIndex = 167;
            this.smartLabel20.Text = "*";
            // 
            // chkQuantitive
            // 
            this.chkQuantitive.AutoSize = true;
            this.chkQuantitive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkQuantitive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkQuantitive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuantitive.ForeColor = System.Drawing.Color.Black;
            this.chkQuantitive.Location = new System.Drawing.Point(193, 228);
            this.chkQuantitive.Name = "chkQuantitive";
            this.chkQuantitive.Size = new System.Drawing.Size(194, 22);
            this.chkQuantitive.TabIndex = 3;
            this.chkQuantitive.Text = "Is Quantitive Punishment?";
            this.chkQuantitive.UseVisualStyleBackColor = true;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(118, 265);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(64, 13);
            this.smartLabel5.TabIndex = 163;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(191, 259);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(425, 63);
            this.txtRemarks.TabIndex = 4;
            this.txtRemarks.Text = " N/A";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(19, 198);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(163, 13);
            this.smartLabel4.TabIndex = 162;
            this.smartLabel4.Text = "Punishment Name(Bangla) :";
            // 
            // txtPunishmentTitleBeng
            // 
            this.txtPunishmentTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPunishmentTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunishmentTitleBeng.Location = new System.Drawing.Point(191, 192);
            this.txtPunishmentTitleBeng.Name = "txtPunishmentTitleBeng";
            this.txtPunishmentTitleBeng.Size = new System.Drawing.Size(214, 24);
            this.txtPunishmentTitleBeng.TabIndex = 2;
            this.txtPunishmentTitleBeng.Text = " ";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(66, 167);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(116, 13);
            this.smartLabel3.TabIndex = 161;
            this.smartLabel3.Text = "Punishment Name :";
            // 
            // txtPunishmentTitle
            // 
            this.txtPunishmentTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPunishmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunishmentTitle.Location = new System.Drawing.Point(191, 160);
            this.txtPunishmentTitle.Name = "txtPunishmentTitle";
            this.txtPunishmentTitle.Size = new System.Drawing.Size(214, 24);
            this.txtPunishmentTitle.TabIndex = 1;
            this.txtPunishmentTitle.Text = " ";
            this.txtPunishmentTitle.TextChanged += new System.EventHandler(this.txtPunishmentTitle_TextChanged);
            // 
            // lvPunishementType
            // 
            this.lvPunishementType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvPunishementType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPunishementType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPunishementType.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPunishementType.FullRowSelect = true;
            this.lvPunishementType.GridLines = true;
            this.lvPunishementType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPunishementType.Location = new System.Drawing.Point(-1, 346);
            this.lvPunishementType.Name = "lvPunishementType";
            this.lvPunishementType.Size = new System.Drawing.Size(863, 289);
            this.lvPunishementType.TabIndex = 169;
            this.lvPunishementType.UseCompatibleStateImageBehavior = false;
            this.lvPunishementType.View = System.Windows.Forms.View.Details;
            this.lvPunishementType.SelectedIndexChanged += new System.EventHandler(this.lvBenefit_SelectedIndexChanged);
            this.lvPunishementType.Click += new System.EventHandler(this.lvBenefit_Click);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(67, 555);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(97, 13);
            this.smartLabel1.TabIndex = 171;
            this.smartLabel1.Text = "Punishment ID :";
            this.smartLabel1.Visible = false;
            // 
            // txtPunishmentID
            // 
            this.txtPunishmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPunishmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPunishmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunishmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPunishmentID.Location = new System.Drawing.Point(94, 571);
            this.txtPunishmentID.Name = "txtPunishmentID";
            this.txtPunishmentID.ReadOnly = true;
            this.txtPunishmentID.Size = new System.Drawing.Size(36, 24);
            this.txtPunishmentID.TabIndex = 170;
            this.txtPunishmentID.TabStop = false;
            this.txtPunishmentID.Visible = false;
            // 
            // frmPunishmentTypeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.Controls.Add(this.smartLabel1);
            this.Controls.Add(this.txtPunishmentID);
            this.isEnterTabAllow = true;
            this.Name = "frmPunishmentTypeSetup";
            this.Load += new System.EventHandler(this.frmPunishmentTypeSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.txtPunishmentID, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel20;
        private AtiqsControlLibrary.SmartCheckBox chkQuantitive;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtPunishmentTitleBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtPunishmentTitle;
        private AtiqsControlLibrary.SmartListViewDetails lvPunishementType;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPunishmentID;
    }
}
