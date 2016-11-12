namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmFinilisedReport
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
            this.lvUndeliveryList = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.txtAdvice = new AtiqsControlLibrary.SmartTextBox();
            this.txtComments = new AtiqsControlLibrary.SmartTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboRptGroup = new AtiqsControlLibrary.SmartComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(41, 12);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(170, 8);
            this.frmLabel.Size = new System.Drawing.Size(282, 33);
            this.frmLabel.Text = "Report  to be Finalised";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Ivory;
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboRptGroup);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.btnPatientSearch);
            this.pnlMain.Controls.Add(this.lvUndeliveryList);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.cboRptSection);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(623, 259);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblDeptID);
            this.pnlTop.Size = new System.Drawing.Size(623, 58);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.lblDeptID, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(73, 320);
            this.btnEdit.Size = new System.Drawing.Size(14, 24);
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(374, 323);
            this.btnSave.Size = new System.Drawing.Size(108, 41);
            this.btnSave.Text = "OK";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(90, 322);
            this.btnDelete.Size = new System.Drawing.Size(10, 24);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(120, 324);
            this.btnNew.Size = new System.Drawing.Size(27, 20);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(491, 323);
            this.btnClose.Size = new System.Drawing.Size(108, 41);
            this.btnClose.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(104, 320);
            this.btnPrint.Size = new System.Drawing.Size(10, 24);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 366);
            this.groupBox1.Size = new System.Drawing.Size(623, 23);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(196, 50);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(311, 26);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboRptSection
            // 
            this.cboRptSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRptSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRptSection.ForeColor = System.Drawing.Color.Blue;
            this.cboRptSection.FormattingEnabled = true;
            this.cboRptSection.Location = new System.Drawing.Point(196, 106);
            this.cboRptSection.Name = "cboRptSection";
            this.cboRptSection.Size = new System.Drawing.Size(311, 26);
            this.cboRptSection.TabIndex = 1;
            this.cboRptSection.SelectedIndexChanged += new System.EventHandler(this.cboRptSection_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 92;
            this.label3.Text = "Department :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 93;
            this.label4.Text = "Report Section :";
            // 
            // lvUndeliveryList
            // 
            this.lvUndeliveryList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvUndeliveryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUndeliveryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvUndeliveryList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvUndeliveryList.FullRowSelect = true;
            this.lvUndeliveryList.GridLines = true;
            this.lvUndeliveryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUndeliveryList.Location = new System.Drawing.Point(23, 18);
            this.lvUndeliveryList.Name = "lvUndeliveryList";
            this.lvUndeliveryList.Size = new System.Drawing.Size(32, 21);
            this.lvUndeliveryList.TabIndex = 94;
            this.lvUndeliveryList.UseCompatibleStateImageBehavior = false;
            this.lvUndeliveryList.View = System.Windows.Forms.View.Details;
            this.lvUndeliveryList.Visible = false;
            this.lvUndeliveryList.SelectedIndexChanged += new System.EventHandler(this.lvUndeliveryList_SelectedIndexChanged);
            this.lvUndeliveryList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvUndeliveryList_MouseDoubleClick);
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(61, 5);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(25, 34);
            this.btnPatientSearch.TabIndex = 3;
            this.btnPatientSearch.Text = "Show";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Visible = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // txtAdvice
            // 
            this.txtAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(7, 331);
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(27, 24);
            this.txtAdvice.TabIndex = 15;
            this.txtAdvice.Visible = false;
            // 
            // txtComments
            // 
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(40, 331);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(27, 24);
            this.txtComments.TabIndex = 16;
            this.txtComments.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(513, 50);
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
            this.label1.Location = new System.Drawing.Point(513, 171);
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
            this.smartLabel3.Location = new System.Drawing.Point(93, 170);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(88, 15);
            this.smartLabel3.TabIndex = 199;
            this.smartLabel3.Text = "Report Group :";
            // 
            // cboRptGroup
            // 
            this.cboRptGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRptGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRptGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboRptGroup.FormattingEnabled = true;
            this.cboRptGroup.Location = new System.Drawing.Point(196, 165);
            this.cboRptGroup.Name = "cboRptGroup";
            this.cboRptGroup.Size = new System.Drawing.Size(311, 26);
            this.cboRptGroup.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(513, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 200;
            this.label6.Text = "*";
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(31, 28);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(83, 13);
            this.lblDeptID.TabIndex = 200;
            this.lblDeptID.Text = "DepartmentId";
            this.lblDeptID.Visible = false;
            // 
            // frmFinilisedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 389);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtAdvice);
            this.isEnterTabAllow = true;
            this.Name = "frmFinilisedReport";
            this.Load += new System.EventHandler(this.frmVerifiedReport_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartComboBox cboRptSection;
        private AtiqsControlLibrary.SmartListViewDetails lvUndeliveryList;
        private System.Windows.Forms.Button btnPatientSearch;
        private AtiqsControlLibrary.SmartTextBox txtAdvice;
        private AtiqsControlLibrary.SmartTextBox txtComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboRptGroup;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblDeptID;
    }
}
