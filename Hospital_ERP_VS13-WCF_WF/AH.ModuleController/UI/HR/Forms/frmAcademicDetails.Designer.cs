namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmAcademicDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtStaffID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegreeName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtInstitute = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtClass = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtCountry = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.cboPassingYear = new AtiqsControlLibrary.SmartComboBox();
            this.grdAcademic = new AtiqsControlLibrary.SmartDataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAcademic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(803, 569);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(575, 569);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(461, 569);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(347, 569);
            this.btnSave.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(233, 569);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(689, 569);
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(858, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(205, 29);
            this.frmLabel.Text = "Academic Details";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grdAcademic);
            this.pnlMain.Controls.Add(this.cboPassingYear);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtCountry);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtClass);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtInstitute);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtDegreeName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtStaffID);
            this.pnlMain.Location = new System.Drawing.Point(12, 57);
            this.pnlMain.Size = new System.Drawing.Size(909, 510);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(909, 51);
            // 
            // txtStaffID
            // 
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffID.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(9, 50);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(96, 25);
            this.txtStaffID.TabIndex = 0;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel1.Location = new System.Drawing.Point(28, 18);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(62, 18);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Staff ID :";
            // 
            // txtDegreeName
            // 
            this.txtDegreeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegreeName.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegreeName.Location = new System.Drawing.Point(105, 50);
            this.txtDegreeName.Name = "txtDegreeName";
            this.txtDegreeName.Size = new System.Drawing.Size(141, 25);
            this.txtDegreeName.TabIndex = 1;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel2.Location = new System.Drawing.Point(118, 18);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(107, 18);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Name of Degree";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel3.Location = new System.Drawing.Point(249, 18);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(85, 18);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Passing Year";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel4.Location = new System.Drawing.Point(413, 18);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(58, 18);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Institute";
            // 
            // txtInstitute
            // 
            this.txtInstitute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstitute.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitute.Location = new System.Drawing.Point(335, 50);
            this.txtInstitute.Name = "txtInstitute";
            this.txtInstitute.Size = new System.Drawing.Size(192, 25);
            this.txtInstitute.TabIndex = 3;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel5.Location = new System.Drawing.Point(527, 18);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(82, 18);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "Class/CGPA";
            // 
            // txtClass
            // 
            this.txtClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClass.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(527, 50);
            this.txtClass.Multiline = true;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(90, 24);
            this.txtClass.TabIndex = 4;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel6.Location = new System.Drawing.Point(637, 18);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(56, 18);
            this.smartLabel6.TabIndex = 11;
            this.smartLabel6.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(617, 50);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 25);
            this.txtCountry.TabIndex = 5;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel7.Location = new System.Drawing.Point(778, 18);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(62, 18);
            this.smartLabel7.TabIndex = 13;
            this.smartLabel7.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("ArialMJ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(717, 50);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(187, 24);
            this.txtRemarks.TabIndex = 6;
            // 
            // cboPassingYear
            // 
            this.cboPassingYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPassingYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPassingYear.Font = new System.Drawing.Font("ArialMJ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPassingYear.ForeColor = System.Drawing.Color.Blue;
            this.cboPassingYear.FormattingEnabled = true;
            this.cboPassingYear.Location = new System.Drawing.Point(247, 50);
            this.cboPassingYear.Name = "cboPassingYear";
            this.cboPassingYear.Size = new System.Drawing.Size(87, 26);
            this.cboPassingYear.TabIndex = 2;
            // 
            // grdAcademic
            // 
            this.grdAcademic.AllowUserToAddRows = false;
            this.grdAcademic.AllowUserToDeleteRows = false;
            this.grdAcademic.AllowUserToOrderColumns = true;
            this.grdAcademic.AllowUserToResizeColumns = false;
            this.grdAcademic.AllowUserToResizeRows = false;
            this.grdAcademic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.grdAcademic.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdAcademic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAcademic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAcademic.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAcademic.Location = new System.Drawing.Point(3, 89);
            this.grdAcademic.MultiSelect = false;
            this.grdAcademic.Name = "grdAcademic";
            this.grdAcademic.RowHeadersVisible = false;
            this.grdAcademic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAcademic.Size = new System.Drawing.Size(895, 416);
            this.grdAcademic.TabIndex = 14;
            // 
            // frmAcademicDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(921, 641);
            this.Name = "frmAcademicDetails";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAcademic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDegreeName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtStaffID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtCountry;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtClass;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtInstitute;
        private AtiqsControlLibrary.SmartDataGridView grdAcademic;
        private AtiqsControlLibrary.SmartComboBox cboPassingYear;

    }
}
