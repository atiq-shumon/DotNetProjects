namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmLeaveDaysSetup
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
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboLeaveType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDays = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvLeaveDays = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtReqDays = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtReqWithin = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(224, 33);
            this.frmLabel.Text = "Leave Days Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtReqWithin);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtReqDays);
            this.pnlMain.Controls.Add(this.lvLeaveDays);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDays);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboLeaveType);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboYear);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(883, 514);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(883, 54);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(659, 570);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(545, 570);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 570);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(431, 570);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(772, 570);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(74, 570);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Size = new System.Drawing.Size(883, 23);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(9, 35);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(85, 26);
            this.cboYear.TabIndex = 0;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(10, 17);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(41, 13);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Year :";
            // 
            // cboLeaveType
            // 
            this.cboLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLeaveType.ForeColor = System.Drawing.Color.Blue;
            this.cboLeaveType.FormattingEnabled = true;
            this.cboLeaveType.Location = new System.Drawing.Point(102, 35);
            this.cboLeaveType.Name = "cboLeaveType";
            this.cboLeaveType.Size = new System.Drawing.Size(121, 26);
            this.cboLeaveType.TabIndex = 1;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(99, 17);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(82, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Leave Type :";
            // 
            // txtDays
            // 
            this.txtDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(229, 35);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(93, 24);
            this.txtDays.TabIndex = 2;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(226, 17);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(43, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Days :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(536, 35);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(334, 24);
            this.txtRemarks.TabIndex = 5;
            this.txtRemarks.Text = "N/A";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(536, 17);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(64, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Remarks :";
            // 
            // lvLeaveDays
            // 
            this.lvLeaveDays.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvLeaveDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLeaveDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvLeaveDays.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLeaveDays.FullRowSelect = true;
            this.lvLeaveDays.GridLines = true;
            this.lvLeaveDays.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLeaveDays.Location = new System.Drawing.Point(-1, 97);
            this.lvLeaveDays.Name = "lvLeaveDays";
            this.lvLeaveDays.Size = new System.Drawing.Size(883, 412);
            this.lvLeaveDays.TabIndex = 8;
            this.lvLeaveDays.UseCompatibleStateImageBehavior = false;
            this.lvLeaveDays.View = System.Windows.Forms.View.Details;
            this.lvLeaveDays.SelectedIndexChanged += new System.EventHandler(this.lvLeaveDays_SelectedIndexChanged);
            this.lvLeaveDays.Click += new System.EventHandler(this.lvLeaveDays_Click);
            // 
            // txtReqDays
            // 
            this.txtReqDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReqDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqDays.Location = new System.Drawing.Point(330, 35);
            this.txtReqDays.Name = "txtReqDays";
            this.txtReqDays.Size = new System.Drawing.Size(93, 24);
            this.txtReqDays.TabIndex = 3;
            this.txtReqDays.Text = "0";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(327, 17);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(94, 13);
            this.smartLabel5.TabIndex = 10;
            this.smartLabel5.Text = "Request Days :";
            // 
            // txtReqWithin
            // 
            this.txtReqWithin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReqWithin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqWithin.Location = new System.Drawing.Point(429, 35);
            this.txtReqWithin.Name = "txtReqWithin";
            this.txtReqWithin.Size = new System.Drawing.Size(101, 24);
            this.txtReqWithin.TabIndex = 4;
            this.txtReqWithin.Text = "0";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(428, 17);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(102, 13);
            this.smartLabel6.TabIndex = 12;
            this.smartLabel6.Text = "Request Within :";
            // 
            // frmLeaveDaysSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(883, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmLeaveDaysSetup";
            this.Load += new System.EventHandler(this.frmLeaveDaysSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboLeaveType;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartNumericTextBox txtDays;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartListViewDetails lvLeaveDays;
        private AtiqsControlLibrary.SmartNumericTextBox txtReqDays;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartNumericTextBox txtReqWithin;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
    }
}
