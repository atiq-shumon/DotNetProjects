namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmQualitativeGroupSetup
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
            this.txtGroupID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtGroupNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtGroupName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvQualitativeGroup = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(284, 9);
            this.frmLabel.Size = new System.Drawing.Size(297, 33);
            this.frmLabel.Text = "Qualitative Group Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvQualitativeGroup);
            this.pnlMain.Controls.Add(this.txtGroupID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtGroupNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtGroupName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(866, 636);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(866, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(420, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(533, 555);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(194, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(755, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(644, 555);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 595);
            this.groupBox1.Size = new System.Drawing.Size(866, 25);
            // 
            // txtGroupID
            // 
            this.txtGroupID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtGroupID.Location = new System.Drawing.Point(165, 150);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.ReadOnly = true;
            this.txtGroupID.Size = new System.Drawing.Size(146, 24);
            this.txtGroupID.TabIndex = 75;
            this.txtGroupID.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(27, 235);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(132, 18);
            this.smartLabel3.TabIndex = 74;
            this.smartLabel3.Text = "Group Name(Beng) :";
            // 
            // txtGroupNameBeng
            // 
            this.txtGroupNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupNameBeng.Location = new System.Drawing.Point(165, 232);
            this.txtGroupNameBeng.Name = "txtGroupNameBeng";
            this.txtGroupNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtGroupNameBeng.TabIndex = 69;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(91, 273);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 73;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(165, 270);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(395, 62);
            this.txtRemarks.TabIndex = 70;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(63, 196);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(96, 18);
            this.smartLabel2.TabIndex = 72;
            this.smartLabel2.Text = "Group  Name :";
            // 
            // txtGroupName
            // 
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Location = new System.Drawing.Point(165, 193);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(395, 24);
            this.txtGroupName.TabIndex = 68;
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(87, 156);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(72, 18);
            this.smartLabel1.TabIndex = 71;
            this.smartLabel1.Text = "Group ID :";
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
            this.lvQualitativeGroup.Location = new System.Drawing.Point(-1, 345);
            this.lvQualitativeGroup.Name = "lvQualitativeGroup";
            this.lvQualitativeGroup.Size = new System.Drawing.Size(863, 290);
            this.lvQualitativeGroup.TabIndex = 76;
            this.lvQualitativeGroup.TabStop = false;
            this.lvQualitativeGroup.UseCompatibleStateImageBehavior = false;
            this.lvQualitativeGroup.View = System.Windows.Forms.View.Details;
            this.lvQualitativeGroup.SelectedIndexChanged += new System.EventHandler(this.lvQualitativeGroup_SelectedIndexChanged);
            this.lvQualitativeGroup.Click += new System.EventHandler(this.lvQualitativeGroup_Click);
            // 
            // frmQualitativeGroupSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(866, 620);
            this.isEnterTabAllow = true;
            this.Name = "frmQualitativeGroupSetup";
            this.Load += new System.EventHandler(this.frmQualitativeGroupSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartReadOnlyTextBox txtGroupID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtGroupNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtGroupName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvQualitativeGroup;
    }
}
