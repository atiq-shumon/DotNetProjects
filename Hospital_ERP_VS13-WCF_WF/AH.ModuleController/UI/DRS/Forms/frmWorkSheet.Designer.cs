namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmWorkSheet
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
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboRptSection = new AtiqsControlLibrary.SmartComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.txtAdvice = new AtiqsControlLibrary.SmartTextBox();
            this.txtComments = new AtiqsControlLibrary.SmartTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboRptGroup = new AtiqsControlLibrary.SmartComboBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.dgvReportList = new System.Windows.Forms.DataGridView();
            this.txtMRNo = new AtiqsControlLibrary.SmartTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(63, 5);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(556, 9);
            this.frmLabel.Size = new System.Drawing.Size(215, 33);
            this.frmLabel.Text = "Print Work Sheet";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.txtMRNo);
            this.pnlMain.Controls.Add(this.dgvReportList);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.btnPatientSearch);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.cboRptSection);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(1437, 479);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblDeptID);
            this.pnlTop.Controls.Add(this.smartLabel3);
            this.pnlTop.Controls.Add(this.cboDepartment);
            this.pnlTop.Controls.Add(this.cboRptGroup);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Size = new System.Drawing.Size(1437, 58);
            this.pnlTop.Controls.SetChildIndex(this.label3, 0);
            this.pnlTop.Controls.SetChildIndex(this.cboRptGroup, 0);
            this.pnlTop.Controls.SetChildIndex(this.cboDepartment, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel3, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.lblDeptID, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(65, 551);
            this.btnEdit.Size = new System.Drawing.Size(13, 22);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1201, 541);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Print ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(82, 553);
            this.btnDelete.Size = new System.Drawing.Size(13, 22);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(118, 552);
            this.btnNew.Size = new System.Drawing.Size(38, 17);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1317, 541);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(96, 551);
            this.btnPrint.Size = new System.Drawing.Size(19, 22);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 582);
            this.groupBox1.Size = new System.Drawing.Size(1437, 23);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(168, 19);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(255, 26);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.Visible = false;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboRptSection
            // 
            this.cboRptSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRptSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRptSection.ForeColor = System.Drawing.Color.Blue;
            this.cboRptSection.FormattingEnabled = true;
            this.cboRptSection.Location = new System.Drawing.Point(501, 80);
            this.cboRptSection.Name = "cboRptSection";
            this.cboRptSection.Size = new System.Drawing.Size(269, 26);
            this.cboRptSection.TabIndex = 2;
            this.cboRptSection.SelectedIndexChanged += new System.EventHandler(this.cboRptSection_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 92;
            this.label3.Text = "Department :";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 93;
            this.label4.Text = "Report Section ";
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(813, 41);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(173, 46);
            this.btnPatientSearch.TabIndex = 3;
            this.btnPatientSearch.Text = "Show";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // txtAdvice
            // 
            this.txtAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(49, 550);
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(10, 24);
            this.txtAdvice.TabIndex = 15;
            this.txtAdvice.Visible = false;
            // 
            // txtComments
            // 
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(30, 550);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(13, 24);
            this.txtComments.TabIndex = 16;
            this.txtComments.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(776, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 194;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(776, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 195;
            this.label1.Text = "*";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(899, 0);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(88, 15);
            this.smartLabel3.TabIndex = 199;
            this.smartLabel3.Text = "Report Group :";
            this.smartLabel3.Visible = false;
            // 
            // cboRptGroup
            // 
            this.cboRptGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRptGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRptGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboRptGroup.FormattingEnabled = true;
            this.cboRptGroup.Location = new System.Drawing.Point(902, 19);
            this.cboRptGroup.Name = "cboRptGroup";
            this.cboRptGroup.Size = new System.Drawing.Size(305, 26);
            this.cboRptGroup.TabIndex = 2;
            this.cboRptGroup.Visible = false;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(47, 25);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(83, 13);
            this.lblDeptID.TabIndex = 201;
            this.lblDeptID.Text = "DepartmentId";
            this.lblDeptID.Visible = false;
            // 
            // dgvReportList
            // 
            this.dgvReportList.AllowUserToAddRows = false;
            this.dgvReportList.AllowUserToDeleteRows = false;
            this.dgvReportList.AllowUserToResizeRows = false;
            this.dgvReportList.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportList.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvReportList.Location = new System.Drawing.Point(-1, 131);
            this.dgvReportList.Name = "dgvReportList";
            this.dgvReportList.RowHeadersVisible = false;
            this.dgvReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReportList.Size = new System.Drawing.Size(1437, 345);
            this.dgvReportList.TabIndex = 213;
            this.dgvReportList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportList_CellClick);
            // 
            // txtMRNo
            // 
            this.txtMRNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNo.Location = new System.Drawing.Point(501, 21);
            this.txtMRNo.MaxLength = 11;
            this.txtMRNo.Multiline = true;
            this.txtMRNo.Name = "txtMRNo";
            this.txtMRNo.Size = new System.Drawing.Size(269, 35);
            this.txtMRNo.TabIndex = 1;
            this.txtMRNo.Leave += new System.EventHandler(this.txtMRNo_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 215;
            this.label8.Text = "MR No.";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(484, 27);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(11, 13);
            this.smartLabel1.TabIndex = 216;
            this.smartLabel1.Text = ":";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(484, 87);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(11, 13);
            this.smartLabel2.TabIndex = 217;
            this.smartLabel2.Text = ":";
            // 
            // frmWorkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1437, 605);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtAdvice);
            this.isEnterTabAllow = true;
            this.Name = "frmWorkSheet";
            this.Load += new System.EventHandler(this.frmWorkSheet_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtAdvice, 0);
            this.Controls.SetChildIndex(this.txtComments, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartComboBox cboRptSection;
        private System.Windows.Forms.Button btnPatientSearch;
        private AtiqsControlLibrary.SmartTextBox txtAdvice;
        private AtiqsControlLibrary.SmartTextBox txtComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboRptGroup;
        public System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.DataGridView dgvReportList;
        private System.Windows.Forms.Label label8;
        private AtiqsControlLibrary.SmartTextBox txtMRNo;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
    }
}
