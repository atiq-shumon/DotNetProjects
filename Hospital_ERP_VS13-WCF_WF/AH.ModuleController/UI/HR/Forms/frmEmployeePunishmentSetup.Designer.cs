namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmEmployeePunishmentSetup
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
            this.txtSerial = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel37 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshBenefit = new System.Windows.Forms.Button();
            this.btnAddBenefit = new System.Windows.Forms.Button();
            this.cboBenefit = new AtiqsControlLibrary.SmartComboBox();
            this.lblStar = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel38 = new AtiqsControlLibrary.SmartLabel();
            this.txtEffectiveDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.smartLabel39 = new AtiqsControlLibrary.SmartLabel();
            this.lblAmount = new AtiqsControlLibrary.SmartLabel();
            this.txtAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshPunishment = new System.Windows.Forms.Button();
            this.cboPunishment = new AtiqsControlLibrary.SmartComboBox();
            this.btnAddPunishment = new System.Windows.Forms.Button();
            this.smartLabel32 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmpId = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDuration = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvPunishementType = new AtiqsControlLibrary.SmartListViewDetails();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(254, 9);
            this.frmLabel.Size = new System.Drawing.Size(353, 33);
            this.frmLabel.Text = "Employee Punishment Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.lvPunishementType);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtDuration);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtEmpId);
            this.pnlMain.Controls.Add(this.lblStar);
            this.pnlMain.Controls.Add(this.smartLabel38);
            this.pnlMain.Controls.Add(this.txtEffectiveDate);
            this.pnlMain.Controls.Add(this.smartLabel39);
            this.pnlMain.Controls.Add(this.lblAmount);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.btnRefreshPunishment);
            this.pnlMain.Controls.Add(this.cboPunishment);
            this.pnlMain.Controls.Add(this.btnAddPunishment);
            this.pnlMain.Controls.Add(this.smartLabel32);
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(12, 570);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(54, 24);
            this.txtSerial.TabIndex = 15;
            this.txtSerial.Visible = false;
            // 
            // smartLabel37
            // 
            this.smartLabel37.AutoSize = true;
            this.smartLabel37.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel37.ForeColor = System.Drawing.Color.Red;
            this.smartLabel37.Location = new System.Drawing.Point(298, 306);
            this.smartLabel37.Name = "smartLabel37";
            this.smartLabel37.Size = new System.Drawing.Size(21, 22);
            this.smartLabel37.TabIndex = 233;
            this.smartLabel37.Text = "*";
            // 
            // btnRefreshBenefit
            // 
            this.btnRefreshBenefit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshBenefit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshBenefit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshBenefit.ForeColor = System.Drawing.Color.White;
            this.btnRefreshBenefit.Location = new System.Drawing.Point(365, 305);
            this.btnRefreshBenefit.Name = "btnRefreshBenefit";
            this.btnRefreshBenefit.Size = new System.Drawing.Size(30, 28);
            this.btnRefreshBenefit.TabIndex = 237;
            this.btnRefreshBenefit.TabStop = false;
            this.btnRefreshBenefit.Text = "..";
            this.btnRefreshBenefit.UseVisualStyleBackColor = false;
            // 
            // btnAddBenefit
            // 
            this.btnAddBenefit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddBenefit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBenefit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBenefit.ForeColor = System.Drawing.Color.White;
            this.btnAddBenefit.Location = new System.Drawing.Point(329, 306);
            this.btnAddBenefit.Name = "btnAddBenefit";
            this.btnAddBenefit.Size = new System.Drawing.Size(32, 28);
            this.btnAddBenefit.TabIndex = 234;
            this.btnAddBenefit.TabStop = false;
            this.btnAddBenefit.Text = "+";
            this.btnAddBenefit.UseVisualStyleBackColor = false;
            // 
            // cboBenefit
            // 
            this.cboBenefit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBenefit.ForeColor = System.Drawing.Color.Blue;
            this.cboBenefit.FormattingEnabled = true;
            this.cboBenefit.Location = new System.Drawing.Point(126, 306);
            this.cboBenefit.Name = "cboBenefit";
            this.cboBenefit.Size = new System.Drawing.Size(171, 26);
            this.cboBenefit.TabIndex = 230;
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Enabled = false;
            this.lblStar.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblStar.ForeColor = System.Drawing.Color.Red;
            this.lblStar.Location = new System.Drawing.Point(362, 261);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(21, 22);
            this.lblStar.TabIndex = 240;
            this.lblStar.Text = "*";
            this.lblStar.Visible = false;
            // 
            // smartLabel38
            // 
            this.smartLabel38.AutoSize = true;
            this.smartLabel38.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel38.ForeColor = System.Drawing.Color.Red;
            this.smartLabel38.Location = new System.Drawing.Point(733, 206);
            this.smartLabel38.Name = "smartLabel38";
            this.smartLabel38.Size = new System.Drawing.Size(21, 22);
            this.smartLabel38.TabIndex = 239;
            this.smartLabel38.Text = "*";
            // 
            // txtEffectiveDate
            // 
            this.txtEffectiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEffectiveDate.Location = new System.Drawing.Point(578, 206);
            this.txtEffectiveDate.Mask = "00/00/0000";
            this.txtEffectiveDate.Name = "txtEffectiveDate";
            this.txtEffectiveDate.Size = new System.Drawing.Size(131, 24);
            this.txtEffectiveDate.TabIndex = 4;
            this.txtEffectiveDate.ValidatingType = typeof(System.DateTime);
            // 
            // smartLabel39
            // 
            this.smartLabel39.AutoSize = true;
            this.smartLabel39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel39.Location = new System.Drawing.Point(475, 212);
            this.smartLabel39.Name = "smartLabel39";
            this.smartLabel39.Size = new System.Drawing.Size(97, 13);
            this.smartLabel39.TabIndex = 236;
            this.smartLabel39.Text = "Effective Date :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Enabled = false;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAmount.Location = new System.Drawing.Point(71, 262);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(57, 13);
            this.lblAmount.TabIndex = 238;
            this.lblAmount.Text = "Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(134, 258);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(224, 24);
            this.txtAmount.TabIndex = 3;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.ForeColor = System.Drawing.Color.Red;
            this.smartLabel2.Location = new System.Drawing.Point(362, 206);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(21, 22);
            this.smartLabel2.TabIndex = 233;
            this.smartLabel2.Text = "*";
            // 
            // btnRefreshPunishment
            // 
            this.btnRefreshPunishment.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshPunishment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshPunishment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPunishment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPunishment.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPunishment.Location = new System.Drawing.Point(420, 206);
            this.btnRefreshPunishment.Name = "btnRefreshPunishment";
            this.btnRefreshPunishment.Size = new System.Drawing.Size(30, 28);
            this.btnRefreshPunishment.TabIndex = 237;
            this.btnRefreshPunishment.TabStop = false;
            this.btnRefreshPunishment.Text = "..";
            this.btnRefreshPunishment.UseVisualStyleBackColor = false;
            this.btnRefreshPunishment.Click += new System.EventHandler(this.btnRefreshPunishment_Click);
            // 
            // cboPunishment
            // 
            this.cboPunishment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPunishment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPunishment.ForeColor = System.Drawing.Color.Blue;
            this.cboPunishment.FormattingEnabled = true;
            this.cboPunishment.Location = new System.Drawing.Point(134, 206);
            this.cboPunishment.Name = "cboPunishment";
            this.cboPunishment.Size = new System.Drawing.Size(224, 26);
            this.cboPunishment.TabIndex = 2;
            this.cboPunishment.SelectedIndexChanged += new System.EventHandler(this.cboPunishment_SelectedIndexChanged);
            // 
            // btnAddPunishment
            // 
            this.btnAddPunishment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPunishment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPunishment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPunishment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPunishment.ForeColor = System.Drawing.Color.White;
            this.btnAddPunishment.Location = new System.Drawing.Point(384, 206);
            this.btnAddPunishment.Name = "btnAddPunishment";
            this.btnAddPunishment.Size = new System.Drawing.Size(32, 28);
            this.btnAddPunishment.TabIndex = 234;
            this.btnAddPunishment.TabStop = false;
            this.btnAddPunishment.Text = "+";
            this.btnAddPunishment.UseVisualStyleBackColor = false;
            this.btnAddPunishment.Click += new System.EventHandler(this.btnAddPunishment_Click);
            // 
            // smartLabel32
            // 
            this.smartLabel32.AutoSize = true;
            this.smartLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel32.Location = new System.Drawing.Point(48, 213);
            this.smartLabel32.Name = "smartLabel32";
            this.smartLabel32.Size = new System.Drawing.Size(80, 13);
            this.smartLabel32.TabIndex = 235;
            this.smartLabel32.Text = "Punishment :";
            // 
            // txtEmpId
            // 
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(134, 162);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(139, 24);
            this.txtEmpId.TabIndex = 1;
            this.txtEmpId.Leave += new System.EventHandler(this.txtEmpId_Leave);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(61, 168);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(56, 13);
            this.smartLabel3.TabIndex = 242;
            this.smartLabel3.Text = "Emp ID :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(279, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 31);
            this.btnSearch.TabIndex = 243;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(578, 251);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(131, 24);
            this.txtDuration.TabIndex = 5;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(475, 257);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(99, 13);
            this.smartLabel1.TabIndex = 245;
            this.smartLabel1.Text = "Duration(Days) :";
            // 
            // lvPunishementType
            // 
            this.lvPunishementType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvPunishementType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPunishementType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPunishementType.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPunishementType.FullRowSelect = true;
            this.lvPunishementType.GridLines = true;
            this.lvPunishementType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPunishementType.Location = new System.Drawing.Point(0, 317);
            this.lvPunishementType.Name = "lvPunishementType";
            this.lvPunishementType.Size = new System.Drawing.Size(863, 315);
            this.lvPunishementType.TabIndex = 247;
            this.lvPunishementType.UseCompatibleStateImageBehavior = false;
            this.lvPunishementType.View = System.Windows.Forms.View.Details;
            this.lvPunishementType.SelectedIndexChanged += new System.EventHandler(this.lvPunishementType_SelectedIndexChanged);
            this.lvPunishementType.Click += new System.EventHandler(this.lvPunishementType_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(377, 158);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 13);
            this.lblInfo.TabIndex = 248;
            this.lblInfo.Text = "Info";
            // 
            // frmEmployeePunishmentSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.Controls.Add(this.smartLabel37);
            this.Controls.Add(this.btnRefreshBenefit);
            this.Controls.Add(this.cboBenefit);
            this.Controls.Add(this.btnAddBenefit);
            this.Controls.Add(this.txtSerial);
            this.Name = "frmEmployeePunishmentSetup";
            this.Load += new System.EventHandler(this.frmEmployeePunishmentSetup_Load);
            this.Controls.SetChildIndex(this.txtSerial, 0);
            this.Controls.SetChildIndex(this.btnAddBenefit, 0);
            this.Controls.SetChildIndex(this.cboBenefit, 0);
            this.Controls.SetChildIndex(this.btnRefreshBenefit, 0);
            this.Controls.SetChildIndex(this.smartLabel37, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel37;
        private System.Windows.Forms.Button btnRefreshBenefit;
        private System.Windows.Forms.Button btnAddBenefit;
        private AtiqsControlLibrary.SmartComboBox cboBenefit;
        private AtiqsControlLibrary.SmartTextBox txtEmpId;
        private AtiqsControlLibrary.SmartLabel lblStar;
        private AtiqsControlLibrary.SmartLabel smartLabel38;
        private AtiqsControlLibrary.SmartDateTextBox txtEffectiveDate;
        private AtiqsControlLibrary.SmartLabel smartLabel39;
        private AtiqsControlLibrary.SmartLabel lblAmount;
        private AtiqsControlLibrary.SmartNumericTextBox txtAmount;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.Button btnRefreshPunishment;
        private AtiqsControlLibrary.SmartComboBox cboPunishment;
        private System.Windows.Forms.Button btnAddPunishment;
        private AtiqsControlLibrary.SmartLabel smartLabel32;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartNumericTextBox txtDuration;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvPunishementType;
        private AtiqsControlLibrary.SmartLabel lblInfo;
    }
}
