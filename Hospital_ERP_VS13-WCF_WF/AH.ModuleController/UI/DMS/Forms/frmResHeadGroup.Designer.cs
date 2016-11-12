namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmResHeadGroup
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
            this.txtHeadGroupNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtHeadGroupName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lvResHdGr = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtHeadGroupID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboSection = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.chkVisible = new AtiqsControlLibrary.SmartCheckBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(238, 33);
            this.frmLabel.Text = "Result Head Group";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chkVisible);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.lvResHdGr);
            this.pnlMain.Controls.Add(this.cboSection);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtHeadGroupNameBeng);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtHeadGroupName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 504);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(418, 568);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 568);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 568);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(192, 568);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(753, 568);
            this.btnClose.TabIndex = 20;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(642, 568);
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
            this.smartLabel3.Location = new System.Drawing.Point(24, 122);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(168, 18);
            this.smartLabel3.TabIndex = 55;
            this.smartLabel3.Text = "Head Group Name(Beng) :";
            // 
            // txtHeadGroupNameBeng
            // 
            this.txtHeadGroupNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadGroupNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadGroupNameBeng.Location = new System.Drawing.Point(201, 119);
            this.txtHeadGroupNameBeng.Name = "txtHeadGroupNameBeng";
            this.txtHeadGroupNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtHeadGroupNameBeng.TabIndex = 2;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(599, 59);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 54;
            this.smartLabel5.Text = "Remarks :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(24, 568);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(108, 18);
            this.smartLabel1.TabIndex = 52;
            this.smartLabel1.Text = "Head Group ID :";
            this.smartLabel1.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(602, 81);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(248, 62);
            this.txtRemarks.TabIndex = 3;
            // 
            // txtHeadGroupName
            // 
            this.txtHeadGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadGroupName.Location = new System.Drawing.Point(201, 81);
            this.txtHeadGroupName.Name = "txtHeadGroupName";
            this.txtHeadGroupName.Size = new System.Drawing.Size(395, 24);
            this.txtHeadGroupName.TabIndex = 1;
            this.txtHeadGroupName.TextChanged += new System.EventHandler(this.txtHeadGroupName_TextChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(63, 84);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(129, 18);
            this.smartLabel2.TabIndex = 53;
            this.smartLabel2.Text = "Head Group Name :";
            // 
            // lvResHdGr
            // 
            this.lvResHdGr.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvResHdGr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvResHdGr.CheckBoxes = true;
            this.lvResHdGr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvResHdGr.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResHdGr.FullRowSelect = true;
            this.lvResHdGr.GridLines = true;
            this.lvResHdGr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResHdGr.Location = new System.Drawing.Point(-1, 195);
            this.lvResHdGr.Name = "lvResHdGr";
            this.lvResHdGr.Size = new System.Drawing.Size(863, 308);
            this.lvResHdGr.TabIndex = 56;
            this.lvResHdGr.TabStop = false;
            this.lvResHdGr.UseCompatibleStateImageBehavior = false;
            this.lvResHdGr.View = System.Windows.Forms.View.Details;
            this.lvResHdGr.SelectedIndexChanged += new System.EventHandler(this.lvResHdGr_SelectedIndexChanged);
            this.lvResHdGr.Click += new System.EventHandler(this.lvResHdGr_Click);
            // 
            // txtHeadGroupID
            // 
            this.txtHeadGroupID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtHeadGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadGroupID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHeadGroupID.Location = new System.Drawing.Point(27, 589);
            this.txtHeadGroupID.Name = "txtHeadGroupID";
            this.txtHeadGroupID.ReadOnly = true;
            this.txtHeadGroupID.Size = new System.Drawing.Size(65, 24);
            this.txtHeadGroupID.TabIndex = 57;
            this.txtHeadGroupID.TabStop = false;
            this.txtHeadGroupID.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(91, 50);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(101, 18);
            this.smartLabel6.TabIndex = 61;
            this.smartLabel6.Text = "Report Section :";
            // 
            // cboSection
            // 
            this.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSection.ForeColor = System.Drawing.Color.Blue;
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(201, 46);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(263, 26);
            this.cboSection.TabIndex = 60;
            this.cboSection.SelectedIndexChanged += new System.EventHandler(this.cboSection_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(105, 14);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(87, 18);
            this.smartLabel4.TabIndex = 59;
            this.smartLabel4.Text = "Department :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(201, 14);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(263, 26);
            this.cboDepartment.TabIndex = 58;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisible.ForeColor = System.Drawing.Color.Black;
            this.chkVisible.Location = new System.Drawing.Point(202, 150);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(159, 22);
            this.chkVisible.TabIndex = 62;
            this.chkVisible.Text = "Is Visible to Report ?";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // frmResHeadGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 636);
            this.Controls.Add(this.txtHeadGroupID);
            this.Controls.Add(this.smartLabel1);
            this.isEnterTabAllow = true;
            this.Name = "frmResHeadGroup";
            this.Load += new System.EventHandler(this.frmResHeadGroup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtHeadGroupID, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtHeadGroupNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtHeadGroupName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvResHdGr;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHeadGroupID;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboSection;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartCheckBox chkVisible;
    }
}
