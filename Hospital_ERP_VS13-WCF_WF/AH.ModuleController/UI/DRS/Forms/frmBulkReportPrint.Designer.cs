namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmBulkReportPrint
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbdDepartment = new System.Windows.Forms.Label();
            this.lblGrop = new System.Windows.Forms.Label();
            this.lblReportGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHCN = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtSpcecimenID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtRegID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtMrNo = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtReportGr = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboRptGroup = new AtiqsControlLibrary.SmartComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboRptSection = new AtiqsControlLibrary.SmartComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dptEndDate = new System.Windows.Forms.DateTimePicker();
            this.dptStartDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lblEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dgvReportList = new System.Windows.Forms.DataGridView();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(942, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(350, 6);
            this.frmLabel.Size = new System.Drawing.Size(331, 33);
            this.frmLabel.Text = "Bulk Report Print Interface";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvReportList);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(1026, 675);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblDeptID);
            this.pnlTop.Controls.Add(this.txtReportGr);
            this.pnlTop.Controls.Add(this.txtMrNo);
            this.pnlTop.Controls.Add(this.txtRegID);
            this.pnlTop.Controls.Add(this.txtSpcecimenID);
            this.pnlTop.Controls.Add(this.txtHCN);
            this.pnlTop.Size = new System.Drawing.Size(1026, 51);
            this.pnlTop.Controls.SetChildIndex(this.txtHCN, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtSpcecimenID, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtRegID, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtMrNo, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtReportGr, 0);
            this.pnlTop.Controls.SetChildIndex(this.lblDeptID, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(192, 733);
            this.btnEdit.Size = new System.Drawing.Size(30, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 729);
            this.btnSave.Size = new System.Drawing.Size(10, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(166, 732);
            this.btnDelete.Size = new System.Drawing.Size(20, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(683, 729);
            this.btnNew.Size = new System.Drawing.Size(108, 44);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(910, 729);
            this.btnClose.Size = new System.Drawing.Size(108, 44);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(797, 729);
            this.btnPrint.Size = new System.Drawing.Size(108, 44);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 774);
            this.groupBox1.Size = new System.Drawing.Size(1026, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Department :";
            // 
            // lbdDepartment
            // 
            this.lbdDepartment.AutoSize = true;
            this.lbdDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdDepartment.ForeColor = System.Drawing.Color.Blue;
            this.lbdDepartment.Location = new System.Drawing.Point(120, 8);
            this.lbdDepartment.Name = "lbdDepartment";
            this.lbdDepartment.Size = new System.Drawing.Size(57, 20);
            this.lbdDepartment.TabIndex = 84;
            this.lbdDepartment.Text = "label3";
            // 
            // lblGrop
            // 
            this.lblGrop.AutoSize = true;
            this.lblGrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrop.Location = new System.Drawing.Point(542, 9);
            this.lblGrop.Name = "lblGrop";
            this.lblGrop.Size = new System.Drawing.Size(106, 20);
            this.lblGrop.TabIndex = 85;
            this.lblGrop.Text = "Report For :";
            // 
            // lblReportGroup
            // 
            this.lblReportGroup.AutoSize = true;
            this.lblReportGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportGroup.ForeColor = System.Drawing.Color.Blue;
            this.lblReportGroup.Location = new System.Drawing.Point(654, 11);
            this.lblReportGroup.Name = "lblReportGroup";
            this.lblReportGroup.Size = new System.Drawing.Size(57, 20);
            this.lblReportGroup.TabIndex = 86;
            this.lblReportGroup.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(-1, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 38);
            this.panel1.TabIndex = 87;
            // 
            // txtHCN
            // 
            this.txtHCN.BackColor = System.Drawing.Color.Linen;
            this.txtHCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHCN.Location = new System.Drawing.Point(1105, 12);
            this.txtHCN.Name = "txtHCN";
            this.txtHCN.ReadOnly = true;
            this.txtHCN.Size = new System.Drawing.Size(29, 24);
            this.txtHCN.TabIndex = 93;
            this.txtHCN.TabStop = false;
            this.txtHCN.Visible = false;
            // 
            // txtSpcecimenID
            // 
            this.txtSpcecimenID.BackColor = System.Drawing.Color.Linen;
            this.txtSpcecimenID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpcecimenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpcecimenID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSpcecimenID.Location = new System.Drawing.Point(1150, 12);
            this.txtSpcecimenID.Name = "txtSpcecimenID";
            this.txtSpcecimenID.ReadOnly = true;
            this.txtSpcecimenID.Size = new System.Drawing.Size(29, 24);
            this.txtSpcecimenID.TabIndex = 94;
            this.txtSpcecimenID.TabStop = false;
            this.txtSpcecimenID.Visible = false;
            // 
            // txtRegID
            // 
            this.txtRegID.BackColor = System.Drawing.Color.Linen;
            this.txtRegID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRegID.Location = new System.Drawing.Point(1185, 12);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.ReadOnly = true;
            this.txtRegID.Size = new System.Drawing.Size(29, 24);
            this.txtRegID.TabIndex = 95;
            this.txtRegID.TabStop = false;
            this.txtRegID.Visible = false;
            // 
            // txtMrNo
            // 
            this.txtMrNo.BackColor = System.Drawing.Color.Linen;
            this.txtMrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMrNo.Location = new System.Drawing.Point(1220, 11);
            this.txtMrNo.Name = "txtMrNo";
            this.txtMrNo.ReadOnly = true;
            this.txtMrNo.Size = new System.Drawing.Size(29, 24);
            this.txtMrNo.TabIndex = 96;
            this.txtMrNo.TabStop = false;
            this.txtMrNo.Visible = false;
            // 
            // txtReportGr
            // 
            this.txtReportGr.BackColor = System.Drawing.Color.Linen;
            this.txtReportGr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportGr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtReportGr.Location = new System.Drawing.Point(1090, 13);
            this.txtReportGr.Name = "txtReportGr";
            this.txtReportGr.ReadOnly = true;
            this.txtReportGr.Size = new System.Drawing.Size(11, 24);
            this.txtReportGr.TabIndex = 97;
            this.txtReportGr.TabStop = false;
            this.txtReportGr.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(712, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 210;
            this.label6.Text = "*";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(751, 7);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(88, 15);
            this.smartLabel3.TabIndex = 209;
            this.smartLabel3.Text = "Report Group :";
            // 
            // cboRptGroup
            // 
            this.cboRptGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRptGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRptGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboRptGroup.FormattingEnabled = true;
            this.cboRptGroup.Location = new System.Drawing.Point(752, 24);
            this.cboRptGroup.Name = "cboRptGroup";
            this.cboRptGroup.Size = new System.Drawing.Size(250, 26);
            this.cboRptGroup.TabIndex = 203;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1004, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 208;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(373, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 207;
            this.label5.Text = "*";
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(395, 65);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(311, 34);
            this.btnPatientSearch.TabIndex = 204;
            this.btnPatientSearch.Text = "Show";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 206;
            this.label4.Text = "Report Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 205;
            this.label8.Text = "Department ";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(12, 24);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(355, 26);
            this.cboDepartment.TabIndex = 201;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboRptSection
            // 
            this.cboRptSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRptSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRptSection.ForeColor = System.Drawing.Color.Blue;
            this.cboRptSection.FormattingEnabled = true;
            this.cboRptSection.Location = new System.Drawing.Point(395, 24);
            this.cboRptSection.Name = "cboRptSection";
            this.cboRptSection.Size = new System.Drawing.Size(311, 26);
            this.cboRptSection.TabIndex = 202;
            this.cboRptSection.SelectedIndexChanged += new System.EventHandler(this.cboRptSection_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.dptEndDate);
            this.panel2.Controls.Add(this.dptStartDate);
            this.panel2.Controls.Add(this.smartLabel1);
            this.panel2.Controls.Add(this.lblEndDate);
            this.panel2.Controls.Add(this.cboRptGroup);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cboRptSection);
            this.panel2.Controls.Add(this.smartLabel3);
            this.panel2.Controls.Add(this.cboDepartment);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnPatientSearch);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 133);
            this.panel2.TabIndex = 211;
            // 
            // dptEndDate
            // 
            this.dptEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptEndDate.Location = new System.Drawing.Point(246, 70);
            this.dptEndDate.Name = "dptEndDate";
            this.dptEndDate.Size = new System.Drawing.Size(121, 26);
            this.dptEndDate.TabIndex = 214;
            // 
            // dptStartDate
            // 
            this.dptStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptStartDate.Location = new System.Drawing.Point(69, 70);
            this.dptStartDate.Name = "dptStartDate";
            this.dptStartDate.Size = new System.Drawing.Size(127, 26);
            this.dptStartDate.TabIndex = 213;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(14, 75);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(38, 13);
            this.smartLabel1.TabIndex = 211;
            this.smartLabel1.Text = "From ";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(207, 76);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(26, 13);
            this.lblEndDate.TabIndex = 212;
            this.lblEndDate.Text = "To ";
            // 
            // dgvReportList
            // 
            this.dgvReportList.AllowUserToAddRows = false;
            this.dgvReportList.AllowUserToDeleteRows = false;
            this.dgvReportList.AllowUserToResizeColumns = false;
            this.dgvReportList.AllowUserToResizeRows = false;
            this.dgvReportList.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportList.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvReportList.Location = new System.Drawing.Point(1, 136);
            this.dgvReportList.Name = "dgvReportList";
            this.dgvReportList.RowHeadersVisible = false;
            this.dgvReportList.Size = new System.Drawing.Size(1023, 535);
            this.dgvReportList.TabIndex = 212;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(838, 9);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(83, 13);
            this.lblDeptID.TabIndex = 201;
            this.lblDeptID.Text = "DepartmentId";
            this.lblDeptID.Visible = false;
            // 
            // frmBulkReportPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1026, 797);
            this.isEnterTabAllow = true;
            this.Name = "frmBulkReportPrint";
            this.Load += new System.EventHandler(this.frmBulkReportPrint_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGrop;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblReportGroup;
        public System.Windows.Forms.Label lbdDepartment;
        private System.Windows.Forms.Panel panel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHCN;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSpcecimenID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRegID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMrNo;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtReportGr;
        private System.Windows.Forms.Panel panel2;
        private AtiqsControlLibrary.SmartComboBox cboRptGroup;
        private System.Windows.Forms.Label label6;
        private AtiqsControlLibrary.SmartComboBox cboRptSection;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPatientSearch;
        private System.Windows.Forms.DateTimePicker dptEndDate;
        private System.Windows.Forms.DateTimePicker dptStartDate;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel lblEndDate;
        private System.Windows.Forms.DataGridView dgvReportList;
        public System.Windows.Forms.Label lblDeptID;
    }
}
