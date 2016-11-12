namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmQualitativeDetailsSetup
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
            this.txtDetID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDetNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDetTitle = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvQualitativeGroup = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(235, 9);
            this.frmLabel.Size = new System.Drawing.Size(384, 33);
            this.frmLabel.Text = "Qualitative Group Details Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvQualitativeGroup);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboGroup);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDetNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtDetTitle);
            // 
            // btnEdit
            // 
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
            // txtDetID
            // 
            this.txtDetID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtDetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDetID.Location = new System.Drawing.Point(95, 564);
            this.txtDetID.Name = "txtDetID";
            this.txtDetID.ReadOnly = true;
            this.txtDetID.Size = new System.Drawing.Size(85, 24);
            this.txtDetID.TabIndex = 83;
            this.txtDetID.TabStop = false;
            this.txtDetID.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(34, 253);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(136, 18);
            this.smartLabel3.TabIndex = 82;
            this.smartLabel3.Text = "Details Name(Beng) :";
            // 
            // txtDetNameBeng
            // 
            this.txtDetNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetNameBeng.Location = new System.Drawing.Point(176, 250);
            this.txtDetNameBeng.Name = "txtDetNameBeng";
            this.txtDetNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtDetNameBeng.TabIndex = 77;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(102, 291);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 81;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(176, 288);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(395, 62);
            this.txtRemarks.TabIndex = 78;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(70, 214);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(100, 18);
            this.smartLabel2.TabIndex = 80;
            this.smartLabel2.Text = "Details  Name :";
            // 
            // txtDetTitle
            // 
            this.txtDetTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetTitle.Location = new System.Drawing.Point(176, 211);
            this.txtDetTitle.Name = "txtDetTitle";
            this.txtDetTitle.Size = new System.Drawing.Size(395, 24);
            this.txtDetTitle.TabIndex = 76;
            this.txtDetTitle.TextChanged += new System.EventHandler(this.txtDetTitle_TextChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(17, 570);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(55, 18);
            this.smartLabel1.TabIndex = 79;
            this.smartLabel1.Text = "Det ID :";
            this.smartLabel1.Visible = false;
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(176, 169);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(230, 26);
            this.cboGroup.TabIndex = 83;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.cboGroup_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(47, 173);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(123, 18);
            this.smartLabel4.TabIndex = 84;
            this.smartLabel4.Text = "Qualitative Group :";
            // 
            // lvQualitativeGroup
            // 
            this.lvQualitativeGroup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvQualitativeGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvQualitativeGroup.CheckBoxes = true;
            this.lvQualitativeGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvQualitativeGroup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvQualitativeGroup.FullRowSelect = true;
            this.lvQualitativeGroup.GridLines = true;
            this.lvQualitativeGroup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvQualitativeGroup.Location = new System.Drawing.Point(0, 374);
            this.lvQualitativeGroup.Name = "lvQualitativeGroup";
            this.lvQualitativeGroup.Size = new System.Drawing.Size(863, 261);
            this.lvQualitativeGroup.TabIndex = 77;
            this.lvQualitativeGroup.TabStop = false;
            this.lvQualitativeGroup.UseCompatibleStateImageBehavior = false;
            this.lvQualitativeGroup.View = System.Windows.Forms.View.Details;
            this.lvQualitativeGroup.SelectedIndexChanged += new System.EventHandler(this.lvQualitativeGroup_SelectedIndexChanged);
            this.lvQualitativeGroup.Click += new System.EventHandler(this.lvQualitativeGroup_Click);
            // 
            // frmQualitativeDetailsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.Controls.Add(this.txtDetID);
            this.Controls.Add(this.smartLabel1);
            this.isEnterTabAllow = true;
            this.Name = "frmQualitativeDetailsSetup";
            this.Load += new System.EventHandler(this.frmQualitativeDetailsSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtDetID, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDetID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDetNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDetTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboGroup;
        private AtiqsControlLibrary.SmartListViewDetails lvQualitativeGroup;

    }
}
