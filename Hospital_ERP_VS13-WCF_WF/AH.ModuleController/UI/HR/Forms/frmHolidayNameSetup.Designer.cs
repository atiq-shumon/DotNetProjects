namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmHolidayNameSetup
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
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtNameID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.txtNameTitle = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtNameTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboHolidayType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lvHolidayName = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnRefreshType = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(293, 9);
            this.frmLabel.Size = new System.Drawing.Size(255, 33);
            this.frmLabel.Text = "Holiday Name Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRefreshType);
            this.pnlMain.Controls.Add(this.btnAddType);
            this.pnlMain.Controls.Add(this.lvHolidayName);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboHolidayType);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtNameTitle);
            this.pnlMain.Controls.Add(this.txtNameID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtNameTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel3);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(633, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(11, 553);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(407, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(122, 553);
            this.btnPrint.Visible = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.Color.Red;
            this.smartLabel4.Location = new System.Drawing.Point(498, 275);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(21, 22);
            this.smartLabel4.TabIndex = 210;
            this.smartLabel4.Text = "*";
            // 
            // txtNameID
            // 
            this.txtNameID.BackColor = System.Drawing.Color.Linen;
            this.txtNameID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNameID.Location = new System.Drawing.Point(159, 159);
            this.txtNameID.MaxLength = 4;
            this.txtNameID.Name = "txtNameID";
            this.txtNameID.ReadOnly = true;
            this.txtNameID.Size = new System.Drawing.Size(100, 24);
            this.txtNameID.TabIndex = 203;
            this.txtNameID.TabStop = false;
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(498, 231);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 209;
            this.smartLabel83.Text = "*";
            // 
            // txtNameTitle
            // 
            this.txtNameTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTitle.Location = new System.Drawing.Point(159, 234);
            this.txtNameTitle.MaxLength = 50;
            this.txtNameTitle.Name = "txtNameTitle";
            this.txtNameTitle.Size = new System.Drawing.Size(333, 24);
            this.txtNameTitle.TabIndex = 1;
            this.txtNameTitle.TextChanged += new System.EventHandler(this.txtNameTitle_TextChanged);
            this.txtNameTitle.Leave += new System.EventHandler(this.txtNameTitle_Leave);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(25, 275);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(127, 13);
            this.smartLabel3.TabIndex = 208;
            this.smartLabel3.Text = "Name Title (Bangla) :";
            // 
            // txtNameTitleBeng
            // 
            this.txtNameTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTitleBeng.Location = new System.Drawing.Point(159, 269);
            this.txtNameTitleBeng.MaxLength = 50;
            this.txtNameTitleBeng.Name = "txtNameTitleBeng";
            this.txtNameTitleBeng.Size = new System.Drawing.Size(333, 24);
            this.txtNameTitleBeng.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(76, 240);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(76, 13);
            this.smartLabel2.TabIndex = 207;
            this.smartLabel2.Text = "Name Title :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(92, 165);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(60, 13);
            this.smartLabel1.TabIndex = 206;
            this.smartLabel1.Text = "Name ID:";
            // 
            // cboHolidayType
            // 
            this.cboHolidayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHolidayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHolidayType.ForeColor = System.Drawing.Color.Blue;
            this.cboHolidayType.FormattingEnabled = true;
            this.cboHolidayType.Location = new System.Drawing.Point(159, 196);
            this.cboHolidayType.Name = "cboHolidayType";
            this.cboHolidayType.Size = new System.Drawing.Size(193, 26);
            this.cboHolidayType.TabIndex = 0;
            this.cboHolidayType.SelectedIndexChanged += new System.EventHandler(this.cboHolidayType_SelectedIndexChanged);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(63, 203);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(89, 13);
            this.smartLabel5.TabIndex = 212;
            this.smartLabel5.Text = "Holiday Type :";
            // 
            // lvHolidayName
            // 
            this.lvHolidayName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvHolidayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvHolidayName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvHolidayName.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHolidayName.FullRowSelect = true;
            this.lvHolidayName.GridLines = true;
            this.lvHolidayName.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvHolidayName.Location = new System.Drawing.Point(0, 330);
            this.lvHolidayName.Name = "lvHolidayName";
            this.lvHolidayName.Size = new System.Drawing.Size(863, 305);
            this.lvHolidayName.TabIndex = 213;
            this.lvHolidayName.UseCompatibleStateImageBehavior = false;
            this.lvHolidayName.View = System.Windows.Forms.View.Details;
            this.lvHolidayName.SelectedIndexChanged += new System.EventHandler(this.lvHolidayName_SelectedIndexChanged);
            this.lvHolidayName.Click += new System.EventHandler(this.lvHolidayName_Click);
            // 
            // btnRefreshType
            // 
            this.btnRefreshType.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshType.ForeColor = System.Drawing.Color.White;
            this.btnRefreshType.Location = new System.Drawing.Point(394, 194);
            this.btnRefreshType.Name = "btnRefreshType";
            this.btnRefreshType.Size = new System.Drawing.Size(30, 28);
            this.btnRefreshType.TabIndex = 226;
            this.btnRefreshType.TabStop = false;
            this.btnRefreshType.Text = "..";
            this.btnRefreshType.UseVisualStyleBackColor = false;
            this.btnRefreshType.Click += new System.EventHandler(this.btnRefreshType_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.ForeColor = System.Drawing.Color.White;
            this.btnAddType.Location = new System.Drawing.Point(358, 194);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(32, 28);
            this.btnAddType.TabIndex = 225;
            this.btnAddType.TabStop = false;
            this.btnAddType.Text = "+";
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // frmHolidayNameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmHolidayNameSetup";
            this.Load += new System.EventHandler(this.frmHolidayNameSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtNameTitle;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtNameID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtNameTitleBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboHolidayType;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartListViewDetails lvHolidayName;
        private System.Windows.Forms.Button btnRefreshType;
        private System.Windows.Forms.Button btnAddType;
    }
}
