namespace AH.ModuleController.UI.FNB.Reports.ParameterForms
{
    partial class frmRptMealRegister
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
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.grpSelDate = new System.Windows.Forms.GroupBox();
            this.mskTDate = new System.Windows.Forms.DateTimePicker();
            this.mskFDate = new System.Windows.Forms.DateTimePicker();
            this.lblTdate = new AtiqsControlLibrary.SmartLabel();
            this.lblFDate = new AtiqsControlLibrary.SmartLabel();
            this.chkAll = new AtiqsControlLibrary.SmartCheckBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.grpSelDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(135, 8);
            this.frmLabel.Size = new System.Drawing.Size(427, 33);
            this.frmLabel.Text = "Employee  Meal Register Summary";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chkAll);
            this.pnlMain.Controls.Add(this.grpSelDate);
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboDepartmentGroup);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(629, 425);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(632, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(120, 344);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(81, 344);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(211, 344);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 344);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(519, 344);
            this.btnClose.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(408, 344);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 397);
            this.groupBox1.Size = new System.Drawing.Size(632, 25);
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(185, 191);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(413, 26);
            this.cboDepartmentType.TabIndex = 0;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(85, 223);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(93, 18);
            this.smartLabel6.TabIndex = 155;
            this.smartLabel6.Text = "Group Name :";
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(185, 220);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(413, 26);
            this.cboDepartmentGroup.TabIndex = 1;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(185, 250);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(413, 26);
            this.cboDepartment.TabIndex = 2;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(48, 253);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(130, 18);
            this.smartLabel5.TabIndex = 152;
            this.smartLabel5.Text = "Department  Name :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(101, 192);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(77, 18);
            this.smartLabel1.TabIndex = 150;
            this.smartLabel1.Text = "Dep. Type :";
            // 
            // grpSelDate
            // 
            this.grpSelDate.Controls.Add(this.mskTDate);
            this.grpSelDate.Controls.Add(this.mskFDate);
            this.grpSelDate.Controls.Add(this.lblTdate);
            this.grpSelDate.Controls.Add(this.lblFDate);
            this.grpSelDate.Location = new System.Drawing.Point(189, 303);
            this.grpSelDate.Name = "grpSelDate";
            this.grpSelDate.Size = new System.Drawing.Size(409, 78);
            this.grpSelDate.TabIndex = 157;
            this.grpSelDate.TabStop = false;
            this.grpSelDate.Text = "Date";
            // 
            // mskTDate
            // 
            this.mskTDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskTDate.Location = new System.Drawing.Point(147, 42);
            this.mskTDate.Name = "mskTDate";
            this.mskTDate.Size = new System.Drawing.Size(200, 23);
            this.mskTDate.TabIndex = 4;
            // 
            // mskFDate
            // 
            this.mskFDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskFDate.Location = new System.Drawing.Point(147, 13);
            this.mskFDate.Name = "mskFDate";
            this.mskFDate.Size = new System.Drawing.Size(200, 23);
            this.mskFDate.TabIndex = 3;
            // 
            // lblTdate
            // 
            this.lblTdate.AutoSize = true;
            this.lblTdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTdate.Location = new System.Drawing.Point(80, 46);
            this.lblTdate.Name = "lblTdate";
            this.lblTdate.Size = new System.Drawing.Size(61, 13);
            this.lblTdate.TabIndex = 28;
            this.lblTdate.Text = "To Date:";
            // 
            // lblFDate
            // 
            this.lblFDate.AutoSize = true;
            this.lblFDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFDate.Location = new System.Drawing.Point(62, 17);
            this.lblFDate.Name = "lblFDate";
            this.lblFDate.Size = new System.Drawing.Size(79, 13);
            this.lblFDate.TabIndex = 27;
            this.lblFDate.Text = "From Date:";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.ForeColor = System.Drawing.Color.Black;
            this.chkAll.Location = new System.Drawing.Point(11, 150);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(39, 22);
            this.chkAll.TabIndex = 158;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // frmRptMealRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 422);
            this.isEnterTabAllow = true;
            this.Name = "frmRptMealRegister";
            this.Load += new System.EventHandler(this.frmRptMealRegister_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpSelDate.ResumeLayout(false);
            this.grpSelDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.GroupBox grpSelDate;
        private System.Windows.Forms.DateTimePicker mskTDate;
        private System.Windows.Forms.DateTimePicker mskFDate;
        private AtiqsControlLibrary.SmartLabel lblTdate;
        private AtiqsControlLibrary.SmartLabel lblFDate;
        private AtiqsControlLibrary.SmartCheckBox chkAll;
    }
}
