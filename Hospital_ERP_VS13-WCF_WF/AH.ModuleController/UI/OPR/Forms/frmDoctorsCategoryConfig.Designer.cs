namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmDoctorsCategoryConfig
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
            this.lstLeftList = new System.Windows.Forms.ListBox();
            this.lstRightList = new System.Windows.Forms.ListBox();
            this.cmdPreviousLeft = new System.Windows.Forms.Button();
            this.cmdRightOne = new System.Windows.Forms.Button();
            this.smartCheckBox1 = new AtiqsControlLibrary.SmartCheckBox();
            this.cboDoctorsCategory = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(226, 33);
            this.frmLabel.Text = "Doctor\'s Category";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.listBox1);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboDoctorsCategory);
            this.pnlMain.Controls.Add(this.smartCheckBox1);
            this.pnlMain.Controls.Add(this.cmdPreviousLeft);
            this.pnlMain.Controls.Add(this.cmdRightOne);
            this.pnlMain.Controls.Add(this.lstRightList);
            this.pnlMain.Controls.Add(this.lstLeftList);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(25, 559);
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(525, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(138, 559);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(412, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(752, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(641, 555);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 609);
            // 
            // lstLeftList
            // 
            this.lstLeftList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstLeftList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLeftList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLeftList.ForeColor = System.Drawing.Color.Blue;
            this.lstLeftList.FormattingEnabled = true;
            this.lstLeftList.ItemHeight = 14;
            this.lstLeftList.Location = new System.Drawing.Point(13, 225);
            this.lstLeftList.Name = "lstLeftList";
            this.lstLeftList.Size = new System.Drawing.Size(394, 392);
            this.lstLeftList.TabIndex = 15;
            // 
            // lstRightList
            // 
            this.lstRightList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstRightList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRightList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRightList.ForeColor = System.Drawing.Color.Blue;
            this.lstRightList.FormattingEnabled = true;
            this.lstRightList.ItemHeight = 14;
            this.lstRightList.Location = new System.Drawing.Point(455, 224);
            this.lstRightList.Name = "lstRightList";
            this.lstRightList.Size = new System.Drawing.Size(384, 392);
            this.lstRightList.TabIndex = 16;
            // 
            // cmdPreviousLeft
            // 
            this.cmdPreviousLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdPreviousLeft.ForeColor = System.Drawing.Color.Yellow;
            this.cmdPreviousLeft.Location = new System.Drawing.Point(411, 421);
            this.cmdPreviousLeft.Name = "cmdPreviousLeft";
            this.cmdPreviousLeft.Size = new System.Drawing.Size(40, 25);
            this.cmdPreviousLeft.TabIndex = 44;
            this.cmdPreviousLeft.Text = "<<";
            this.cmdPreviousLeft.UseVisualStyleBackColor = false;
            this.cmdPreviousLeft.Click += new System.EventHandler(this.cmdPreviousLeft_Click);
            // 
            // cmdRightOne
            // 
            this.cmdRightOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdRightOne.ForeColor = System.Drawing.Color.Yellow;
            this.cmdRightOne.Location = new System.Drawing.Point(411, 390);
            this.cmdRightOne.Name = "cmdRightOne";
            this.cmdRightOne.Size = new System.Drawing.Size(40, 25);
            this.cmdRightOne.TabIndex = 43;
            this.cmdRightOne.Text = ">>";
            this.cmdRightOne.UseVisualStyleBackColor = false;
            this.cmdRightOne.Click += new System.EventHandler(this.cmdRightOne_Click);
            // 
            // smartCheckBox1
            // 
            this.smartCheckBox1.AutoSize = true;
            this.smartCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.smartCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.smartCheckBox1.Name = "smartCheckBox1";
            this.smartCheckBox1.Size = new System.Drawing.Size(139, 22);
            this.smartCheckBox1.TabIndex = 45;
            this.smartCheckBox1.Text = "smartCheckBox1";
            this.smartCheckBox1.UseVisualStyleBackColor = true;
            // 
            // cboDoctorsCategory
            // 
            this.cboDoctorsCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctorsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctorsCategory.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctorsCategory.FormattingEnabled = true;
            this.cboDoctorsCategory.Items.AddRange(new object[] {
            "Surgeon",
            "Assistant Surgeon",
            "RMO",
            "OT Nurse",
            "OT Technisian",
            "General Nurse",
            "Anesthesiologist",
            "OT Helper",
            "OT Incharge",
            "Others"});
            this.cboDoctorsCategory.Location = new System.Drawing.Point(308, 164);
            this.cboDoctorsCategory.Name = "cboDoctorsCategory";
            this.cboDoctorsCategory.Size = new System.Drawing.Size(341, 26);
            this.cboDoctorsCategory.TabIndex = 46;
            this.cboDoctorsCategory.SelectedIndexChanged += new System.EventHandler(this.cboDoctorsCategory_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(191, 167);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(108, 14);
            this.smartLabel1.TabIndex = 47;
            this.smartLabel1.Text = "Category Type:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 48;
            this.listBox1.Visible = false;
            // 
            // frmDoctorsCategoryConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmDoctorsCategoryConfig";
            this.Load += new System.EventHandler(this.frmDoctorsCategoryConfig_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeftList;
        private System.Windows.Forms.Button cmdPreviousLeft;
        private System.Windows.Forms.Button cmdRightOne;
        private System.Windows.Forms.ListBox lstRightList;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDoctorsCategory;
        private AtiqsControlLibrary.SmartCheckBox smartCheckBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
