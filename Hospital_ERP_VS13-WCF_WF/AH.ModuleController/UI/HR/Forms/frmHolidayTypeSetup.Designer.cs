namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmHolidayTypeSetup
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
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.txtTypeTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtTypeID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lvHolidayType = new AtiqsControlLibrary.SmartListViewDetails();
            this.chkWeekly = new AtiqsControlLibrary.SmartCheckBox();
            this.ChkMonthly = new AtiqsControlLibrary.SmartCheckBox();
            this.chkYearly = new AtiqsControlLibrary.SmartCheckBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(296, 9);
            this.frmLabel.Size = new System.Drawing.Size(244, 33);
            this.frmLabel.Text = "Holiday Type Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chkYearly);
            this.pnlMain.Controls.Add(this.ChkMonthly);
            this.pnlMain.Controls.Add(this.chkWeekly);
            this.pnlMain.Controls.Add(this.lvHolidayType);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtTypeID);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.txtTypeTitle);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtTypeTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(415, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(302, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(528, 555);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(189, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(639, 555);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.Color.Red;
            this.smartLabel4.Location = new System.Drawing.Point(351, 220);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(21, 22);
            this.smartLabel4.TabIndex = 202;
            this.smartLabel4.Text = "*";
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(351, 190);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 201;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(24, 230);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(123, 13);
            this.smartLabel3.TabIndex = 200;
            this.smartLabel3.Text = "Type Title (Bangla) :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(75, 198);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(72, 13);
            this.smartLabel2.TabIndex = 199;
            this.smartLabel2.Text = "Type Title :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(91, 167);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(56, 13);
            this.smartLabel1.TabIndex = 198;
            this.smartLabel1.Text = "Type ID:";
            // 
            // txtTypeTitleBeng
            // 
            this.txtTypeTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeTitleBeng.Location = new System.Drawing.Point(155, 224);
            this.txtTypeTitleBeng.MaxLength = 50;
            this.txtTypeTitleBeng.Name = "txtTypeTitleBeng";
            this.txtTypeTitleBeng.Size = new System.Drawing.Size(193, 24);
            this.txtTypeTitleBeng.TabIndex = 2;
            // 
            // txtTypeTitle
            // 
            this.txtTypeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeTitle.Location = new System.Drawing.Point(155, 192);
            this.txtTypeTitle.MaxLength = 50;
            this.txtTypeTitle.Name = "txtTypeTitle";
            this.txtTypeTitle.Size = new System.Drawing.Size(193, 24);
            this.txtTypeTitle.TabIndex = 1;
            this.txtTypeTitle.TextChanged += new System.EventHandler(this.txtTypeTitle_TextChanged);
            // 
            // txtTypeID
            // 
            this.txtTypeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTypeID.Location = new System.Drawing.Point(155, 161);
            this.txtTypeID.MaxLength = 4;
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.ReadOnly = true;
            this.txtTypeID.Size = new System.Drawing.Size(100, 24);
            this.txtTypeID.TabIndex = 195;
            this.txtTypeID.TabStop = false;
            // 
            // lvHolidayType
            // 
            this.lvHolidayType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvHolidayType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvHolidayType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvHolidayType.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHolidayType.FullRowSelect = true;
            this.lvHolidayType.GridLines = true;
            this.lvHolidayType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvHolidayType.Location = new System.Drawing.Point(-1, 296);
            this.lvHolidayType.Name = "lvHolidayType";
            this.lvHolidayType.Size = new System.Drawing.Size(863, 339);
            this.lvHolidayType.TabIndex = 203;
            this.lvHolidayType.UseCompatibleStateImageBehavior = false;
            this.lvHolidayType.View = System.Windows.Forms.View.Details;
            this.lvHolidayType.SelectedIndexChanged += new System.EventHandler(this.lvHolidayType_SelectedIndexChanged);
            this.lvHolidayType.Click += new System.EventHandler(this.lvHolidayType_Click);
            // 
            // chkWeekly
            // 
            this.chkWeekly.AutoSize = true;
            this.chkWeekly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWeekly.ForeColor = System.Drawing.Color.Black;
            this.chkWeekly.Location = new System.Drawing.Point(463, 161);
            this.chkWeekly.Name = "chkWeekly";
            this.chkWeekly.Size = new System.Drawing.Size(73, 22);
            this.chkWeekly.TabIndex = 3;
            this.chkWeekly.Text = "Weekly";
            this.chkWeekly.UseVisualStyleBackColor = true;
            // 
            // ChkMonthly
            // 
            this.ChkMonthly.AutoSize = true;
            this.ChkMonthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMonthly.ForeColor = System.Drawing.Color.Black;
            this.ChkMonthly.Location = new System.Drawing.Point(463, 192);
            this.ChkMonthly.Name = "ChkMonthly";
            this.ChkMonthly.Size = new System.Drawing.Size(76, 22);
            this.ChkMonthly.TabIndex = 4;
            this.ChkMonthly.Text = "Monthly";
            this.ChkMonthly.UseVisualStyleBackColor = true;
            // 
            // chkYearly
            // 
            this.chkYearly.AutoSize = true;
            this.chkYearly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkYearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYearly.ForeColor = System.Drawing.Color.Black;
            this.chkYearly.Location = new System.Drawing.Point(463, 224);
            this.chkYearly.Name = "chkYearly";
            this.chkYearly.Size = new System.Drawing.Size(64, 22);
            this.chkYearly.TabIndex = 5;
            this.chkYearly.Text = "Yearly";
            this.chkYearly.UseVisualStyleBackColor = true;
            // 
            // frmHolidayTypeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmHolidayTypeSetup";
            this.Load += new System.EventHandler(this.frmHolidayTypeSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtTypeTitleBeng;
        private AtiqsControlLibrary.SmartTextBox txtTypeTitle;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTypeID;
        private AtiqsControlLibrary.SmartListViewDetails lvHolidayType;
        private AtiqsControlLibrary.SmartCheckBox chkWeekly;
        private AtiqsControlLibrary.SmartCheckBox ChkMonthly;
        private AtiqsControlLibrary.SmartCheckBox chkYearly;
    }
}
