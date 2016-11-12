namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmDepartmentWiseManualAttendence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.cboMonth = new AtiqsControlLibrary.SmartComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAttendence = new AtiqsControlLibrary.SmartDataGridView();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.gbSelectOptions = new System.Windows.Forms.GroupBox();
            this.rdoGrpDeptUnit = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptGrp = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAll = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).BeginInit();
            this.gbSelectOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(415, 9);
            this.frmLabel.Size = new System.Drawing.Size(584, 33);
            this.frmLabel.Text = "Department Wise Manual Attendence And Leave";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.gbSelectOptions);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboDepartmentGroup);
            this.pnlMain.Controls.Add(this.smartLabel22);
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.smartLabel21);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.dgvAttendence);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.cboMonth);
            this.pnlMain.Controls.Add(this.cboYear);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(1445, 822);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1445, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(151, 882);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1218, 882);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(264, 882);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1105, 882);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1332, 882);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(375, 882);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 922);
            this.groupBox1.Size = new System.Drawing.Size(1445, 25);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(466, 71);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(237, 26);
            this.cboDepartment.TabIndex = 3;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(940, 70);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(85, 26);
            this.cboYear.TabIndex = 1;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.ForeColor = System.Drawing.Color.Blue;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(1031, 70);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(105, 26);
            this.cboMonth.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1215, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 26);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvAttendence
            // 
            this.dgvAttendence.AllowUserToAddRows = false;
            this.dgvAttendence.AllowUserToDeleteRows = false;
            this.dgvAttendence.AllowUserToOrderColumns = true;
            this.dgvAttendence.AllowUserToResizeColumns = false;
            this.dgvAttendence.AllowUserToResizeRows = false;
            this.dgvAttendence.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendence.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAttendence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendence.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendence.Location = new System.Drawing.Point(-1, 114);
            this.dgvAttendence.MultiSelect = false;
            this.dgvAttendence.Name = "dgvAttendence";
            this.dgvAttendence.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvAttendence.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendence.Size = new System.Drawing.Size(1445, 707);
            this.dgvAttendence.TabIndex = 28;
            this.dgvAttendence.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAttendence_CellValidating);
            this.dgvAttendence.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendence_CellValueChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(937, 50);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(41, 13);
            this.smartLabel6.TabIndex = 198;
            this.smartLabel6.Text = "Year :";
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(207, 71);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(253, 26);
            this.cboDepartmentGroup.TabIndex = 187;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(204, 51);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(118, 13);
            this.smartLabel22.TabIndex = 197;
            this.smartLabel22.Text = "Department Group :";
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(7, 71);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(194, 26);
            this.cboDepartmentType.TabIndex = 186;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(7, 51);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(112, 13);
            this.smartLabel21.TabIndex = 196;
            this.smartLabel21.Text = "Department Type :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(1033, 50);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(50, 13);
            this.smartLabel4.TabIndex = 195;
            this.smartLabel4.Text = "Month :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(1142, 69);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(67, 26);
            this.btnShow.TabIndex = 192;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(706, 51);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(38, 13);
            this.smartLabel5.TabIndex = 194;
            this.smartLabel5.Text = "Unit :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(709, 71);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(226, 26);
            this.cboUnit.TabIndex = 189;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(466, 51);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(80, 13);
            this.smartLabel7.TabIndex = 193;
            this.smartLabel7.Text = "Department :";
            // 
            // gbSelectOptions
            // 
            this.gbSelectOptions.Controls.Add(this.rdoGrpDeptUnit);
            this.gbSelectOptions.Controls.Add(this.rdoDeptGrp);
            this.gbSelectOptions.Controls.Add(this.rdoAll);
            this.gbSelectOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbSelectOptions.Location = new System.Drawing.Point(11, 2);
            this.gbSelectOptions.Name = "gbSelectOptions";
            this.gbSelectOptions.Size = new System.Drawing.Size(511, 44);
            this.gbSelectOptions.TabIndex = 228;
            this.gbSelectOptions.TabStop = false;
            // 
            // rdoGrpDeptUnit
            // 
            this.rdoGrpDeptUnit.AutoSize = true;
            this.rdoGrpDeptUnit.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoGrpDeptUnit.ForeColor = System.Drawing.Color.Gray;
            this.rdoGrpDeptUnit.Location = new System.Drawing.Point(262, 13);
            this.rdoGrpDeptUnit.Name = "rdoGrpDeptUnit";
            this.rdoGrpDeptUnit.Size = new System.Drawing.Size(215, 22);
            this.rdoGrpDeptUnit.TabIndex = 2;
            this.rdoGrpDeptUnit.TabStop = true;
            this.rdoGrpDeptUnit.Text = " Group , Dept and Unit Wise";
            this.rdoGrpDeptUnit.UseVisualStyleBackColor = true;
            // 
            // rdoDeptGrp
            // 
            this.rdoDeptGrp.AutoSize = true;
            this.rdoDeptGrp.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDeptGrp.ForeColor = System.Drawing.Color.Gray;
            this.rdoDeptGrp.Location = new System.Drawing.Point(98, 13);
            this.rdoDeptGrp.Name = "rdoDeptGrp";
            this.rdoDeptGrp.Size = new System.Drawing.Size(140, 22);
            this.rdoDeptGrp.TabIndex = 1;
            this.rdoDeptGrp.TabStop = true;
            this.rdoDeptGrp.Text = "Dept Group Wise";
            this.rdoDeptGrp.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoAll.ForeColor = System.Drawing.Color.Gray;
            this.rdoAll.Location = new System.Drawing.Point(22, 13);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(44, 22);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // frmDepartmentWiseManualAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1445, 947);
            this.isEnterTabAllow = true;
            this.Name = "frmDepartmentWiseManualAttendence";
            this.Load += new System.EventHandler(this.frmDepartmentWiseManualAttendence_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).EndInit();
            this.gbSelectOptions.ResumeLayout(false);
            this.gbSelectOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartComboBox cboMonth;
        private System.Windows.Forms.Button btnRefresh;
        private AtiqsControlLibrary.SmartDataGridView dgvAttendence;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.GroupBox gbSelectOptions;
        private AtiqsControlLibrary.SmartRadioButton rdoGrpDeptUnit;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptGrp;
        private AtiqsControlLibrary.SmartRadioButton rdoAll;
    }
}
