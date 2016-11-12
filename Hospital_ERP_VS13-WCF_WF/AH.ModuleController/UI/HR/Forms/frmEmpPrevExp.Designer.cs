namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmEmpPrevExp
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
            this.txtOrganization = new AtiqsControlLibrary.SmartTextBox();
            this.txtJobDesc = new AtiqsControlLibrary.SmartTextBox();
            this.dtDoj = new AtiqsControlLibrary.SmartDateTextBox();
            this.dtDor = new AtiqsControlLibrary.SmartDateTextBox();
            this.txtResignCause = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lblDesignation = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.lblregisncause = new AtiqsControlLibrary.SmartLabel();
            this.lvEmployeePreviousExprience = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtEmp = new AtiqsControlLibrary.SmartTextBox();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.txtDesignation = new AtiqsControlLibrary.SmartTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSerial = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel20 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(868, 6);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(245, 5);
            this.frmLabel.Size = new System.Drawing.Size(374, 33);
            this.frmLabel.Text = "Employee Previous Experience";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel20);
            this.pnlMain.Controls.Add(this.txtSerial);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtDesignation);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.txtEmp);
            this.pnlMain.Controls.Add(this.lvEmployeePreviousExprience);
            this.pnlMain.Controls.Add(this.lblregisncause);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.lblDesignation);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtResignCause);
            this.pnlMain.Controls.Add(this.dtDor);
            this.pnlMain.Controls.Add(this.dtDoj);
            this.pnlMain.Controls.Add(this.txtJobDesc);
            this.pnlMain.Controls.Add(this.txtOrganization);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(860, 582);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(860, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(518, 639);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(404, 639);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 639);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(290, 639);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(748, 639);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(634, 639);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 684);
            this.groupBox1.Size = new System.Drawing.Size(860, 23);
            // 
            // txtOrganization
            // 
            this.txtOrganization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganization.Location = new System.Drawing.Point(255, 92);
            this.txtOrganization.Multiline = true;
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrganization.Size = new System.Drawing.Size(567, 30);
            this.txtOrganization.TabIndex = 4;
            this.txtOrganization.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtOrganization_PreviewKeyDown);
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDesc.Location = new System.Drawing.Point(255, 150);
            this.txtJobDesc.Multiline = true;
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJobDesc.Size = new System.Drawing.Size(567, 75);
            this.txtJobDesc.TabIndex = 8;
            this.txtJobDesc.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtJobDesc_PreviewKeyDown);
            // 
            // dtDoj
            // 
            this.dtDoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtDoj.Location = new System.Drawing.Point(22, 205);
            this.dtDoj.Mask = "00/00/0000";
            this.dtDoj.Name = "dtDoj";
            this.dtDoj.Size = new System.Drawing.Size(86, 24);
            this.dtDoj.TabIndex = 6;
            this.dtDoj.ValidatingType = typeof(System.DateTime);
            // 
            // dtDor
            // 
            this.dtDor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtDor.Location = new System.Drawing.Point(142, 203);
            this.dtDor.Mask = "00/00/0000";
            this.dtDor.Name = "dtDor";
            this.dtDor.Size = new System.Drawing.Size(85, 24);
            this.dtDor.TabIndex = 7;
            this.dtDor.ValidatingType = typeof(System.DateTime);
            // 
            // txtResignCause
            // 
            this.txtResignCause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResignCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResignCause.Location = new System.Drawing.Point(22, 150);
            this.txtResignCause.Multiline = true;
            this.txtResignCause.Name = "txtResignCause";
            this.txtResignCause.Size = new System.Drawing.Size(201, 26);
            this.txtResignCause.TabIndex = 5;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(22, 15);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 13);
            this.smartLabel1.TabIndex = 7;
            this.smartLabel1.Text = "Employee ID :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(255, 71);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(86, 13);
            this.smartLabel2.TabIndex = 8;
            this.smartLabel2.Text = "Organization :";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDesignation.Location = new System.Drawing.Point(22, 71);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(82, 13);
            this.lblDesignation.TabIndex = 9;
            this.lblDesignation.Text = "Designation :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(255, 129);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(103, 13);
            this.smartLabel4.TabIndex = 10;
            this.smartLabel4.Text = "Job Description :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(22, 185);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(86, 13);
            this.smartLabel5.TabIndex = 11;
            this.smartLabel5.Text = "Joining Date :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(142, 183);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(85, 13);
            this.smartLabel6.TabIndex = 12;
            this.smartLabel6.Text = "Resign Date :";
            // 
            // lblregisncause
            // 
            this.lblregisncause.AutoSize = true;
            this.lblregisncause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblregisncause.Location = new System.Drawing.Point(22, 129);
            this.lblregisncause.Name = "lblregisncause";
            this.lblregisncause.Size = new System.Drawing.Size(93, 13);
            this.lblregisncause.TabIndex = 13;
            this.lblregisncause.Text = "Resign Cause :";
            // 
            // lvEmployeePreviousExprience
            // 
            this.lvEmployeePreviousExprience.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvEmployeePreviousExprience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmployeePreviousExprience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmployeePreviousExprience.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployeePreviousExprience.FullRowSelect = true;
            this.lvEmployeePreviousExprience.GridLines = true;
            this.lvEmployeePreviousExprience.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmployeePreviousExprience.Location = new System.Drawing.Point(-1, 247);
            this.lvEmployeePreviousExprience.Name = "lvEmployeePreviousExprience";
            this.lvEmployeePreviousExprience.Size = new System.Drawing.Size(860, 334);
            this.lvEmployeePreviousExprience.TabIndex = 14;
            this.lvEmployeePreviousExprience.UseCompatibleStateImageBehavior = false;
            this.lvEmployeePreviousExprience.View = System.Windows.Forms.View.Details;
            this.lvEmployeePreviousExprience.SelectedIndexChanged += new System.EventHandler(this.lvEmployeePreviousExprience_SelectedIndexChanged);
            this.lvEmployeePreviousExprience.Click += new System.EventHandler(this.lvEmployeePreviousExprience_Click);
            // 
            // txtEmp
            // 
            this.txtEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp.Location = new System.Drawing.Point(22, 34);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(166, 24);
            this.txtEmp.TabIndex = 1;
            this.txtEmp.Leave += new System.EventHandler(this.txtEmp_Leave);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(285, 34);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 13);
            this.lblInfo.TabIndex = 15;
            this.lblInfo.Text = "Info";
            // 
            // txtDesignation
            // 
            this.txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(22, 92);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(201, 24);
            this.txtDesignation.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(205, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(692, 9);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(76, 24);
            this.txtSerial.TabIndex = 102;
            this.txtSerial.Visible = false;
            // 
            // smartLabel20
            // 
            this.smartLabel20.AutoSize = true;
            this.smartLabel20.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel20.ForeColor = System.Drawing.Color.Red;
            this.smartLabel20.Location = new System.Drawing.Point(233, 92);
            this.smartLabel20.Name = "smartLabel20";
            this.smartLabel20.Size = new System.Drawing.Size(21, 22);
            this.smartLabel20.TabIndex = 155;
            this.smartLabel20.Text = "*";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.ForeColor = System.Drawing.Color.Red;
            this.smartLabel3.Location = new System.Drawing.Point(828, 92);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(21, 22);
            this.smartLabel3.TabIndex = 156;
            this.smartLabel3.Text = "*";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.Red;
            this.smartLabel7.Location = new System.Drawing.Point(233, 153);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(21, 22);
            this.smartLabel7.TabIndex = 157;
            this.smartLabel7.Text = "*";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.ForeColor = System.Drawing.Color.Red;
            this.smartLabel8.Location = new System.Drawing.Point(118, 204);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(21, 22);
            this.smartLabel8.TabIndex = 158;
            this.smartLabel8.Text = "*";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.ForeColor = System.Drawing.Color.Red;
            this.smartLabel9.Location = new System.Drawing.Point(233, 203);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(21, 22);
            this.smartLabel9.TabIndex = 159;
            this.smartLabel9.Text = "*";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.ForeColor = System.Drawing.Color.Red;
            this.smartLabel10.Location = new System.Drawing.Point(828, 151);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(21, 22);
            this.smartLabel10.TabIndex = 160;
            this.smartLabel10.Text = "*";
            // 
            // frmEmpPrevExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(860, 707);
            this.isEnterTabAllow = true;
            this.Name = "frmEmpPrevExp";
            this.Load += new System.EventHandler(this.frmEmpPrevExp_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtOrganization;
        private AtiqsControlLibrary.SmartTextBox txtJobDesc;
        private AtiqsControlLibrary.SmartDateTextBox dtDoj;
        private AtiqsControlLibrary.SmartDateTextBox dtDor;
        private AtiqsControlLibrary.SmartTextBox txtResignCause;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel lblDesignation;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel lblregisncause;
        private AtiqsControlLibrary.SmartListViewDetails lvEmployeePreviousExprience;
        private AtiqsControlLibrary.SmartTextBox txtEmp;
        private AtiqsControlLibrary.SmartLabel lblInfo;
        private AtiqsControlLibrary.SmartTextBox txtDesignation;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartTextBox txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel20;
    }
}
