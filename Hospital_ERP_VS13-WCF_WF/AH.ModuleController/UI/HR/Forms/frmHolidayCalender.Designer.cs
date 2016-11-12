namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmHolidayCalender
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
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboHolidayType = new AtiqsControlLibrary.SmartComboBox();
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboHolidayName = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtHolidayDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.chkMoon = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.lvHolidayCalender = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnRefreshType = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnRefreshName = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(337, 9);
            this.frmLabel.Size = new System.Drawing.Size(290, 33);
            this.frmLabel.Text = "Holiday Calender Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnProcess);
            this.pnlMain.Controls.Add(this.btnRefreshName);
            this.pnlMain.Controls.Add(this.btnAddName);
            this.pnlMain.Controls.Add(this.btnRefreshType);
            this.pnlMain.Controls.Add(this.btnAddType);
            this.pnlMain.Controls.Add(this.lvHolidayCalender);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.chkMoon);
            this.pnlMain.Controls.Add(this.txtHolidayDate);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboHolidayName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboYear);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboHolidayType);
            this.pnlMain.Size = new System.Drawing.Size(959, 797);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(959, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(730, 716);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(617, 716);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(17, 716);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(504, 716);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(844, 716);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(128, 716);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 755);
            this.groupBox1.Size = new System.Drawing.Size(959, 25);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(113, 158);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(89, 13);
            this.smartLabel5.TabIndex = 214;
            this.smartLabel5.Text = "Holiday Type :";
            // 
            // cboHolidayType
            // 
            this.cboHolidayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHolidayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHolidayType.ForeColor = System.Drawing.Color.Blue;
            this.cboHolidayType.FormattingEnabled = true;
            this.cboHolidayType.Location = new System.Drawing.Point(115, 178);
            this.cboHolidayType.Name = "cboHolidayType";
            this.cboHolidayType.Size = new System.Drawing.Size(109, 26);
            this.cboHolidayType.TabIndex = 1;
            this.cboHolidayType.SelectedIndexChanged += new System.EventHandler(this.cboHolidayType_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(11, 178);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(91, 26);
            this.cboYear.TabIndex = 0;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(11, 158);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(41, 13);
            this.smartLabel1.TabIndex = 216;
            this.smartLabel1.Text = "Year :";
            // 
            // cboHolidayName
            // 
            this.cboHolidayName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHolidayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHolidayName.ForeColor = System.Drawing.Color.Blue;
            this.cboHolidayName.FormattingEnabled = true;
            this.cboHolidayName.Location = new System.Drawing.Point(306, 179);
            this.cboHolidayName.Name = "cboHolidayName";
            this.cboHolidayName.Size = new System.Drawing.Size(296, 26);
            this.cboHolidayName.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(305, 159);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(93, 13);
            this.smartLabel2.TabIndex = 218;
            this.smartLabel2.Text = "Holiday Name :";
            // 
            // txtHolidayDate
            // 
            this.txtHolidayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtHolidayDate.Location = new System.Drawing.Point(684, 180);
            this.txtHolidayDate.Mask = "00/00/0000";
            this.txtHolidayDate.Name = "txtHolidayDate";
            this.txtHolidayDate.Size = new System.Drawing.Size(100, 24);
            this.txtHolidayDate.TabIndex = 3;
            this.txtHolidayDate.ValidatingType = typeof(System.DateTime);
            // 
            // chkMoon
            // 
            this.chkMoon.AutoSize = true;
            this.chkMoon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMoon.ForeColor = System.Drawing.Color.Black;
            this.chkMoon.Location = new System.Drawing.Point(791, 180);
            this.chkMoon.Name = "chkMoon";
            this.chkMoon.Size = new System.Drawing.Size(159, 22);
            this.chkMoon.TabIndex = 5;
            this.chkMoon.Text = "Depends on Moon ?";
            this.chkMoon.UseVisualStyleBackColor = true;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(681, 160);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(88, 13);
            this.smartLabel3.TabIndex = 221;
            this.smartLabel3.Text = "Holiday Date :";
            // 
            // lvHolidayCalender
            // 
            this.lvHolidayCalender.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvHolidayCalender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvHolidayCalender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvHolidayCalender.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHolidayCalender.FullRowSelect = true;
            this.lvHolidayCalender.GridLines = true;
            this.lvHolidayCalender.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvHolidayCalender.Location = new System.Drawing.Point(-1, 249);
            this.lvHolidayCalender.Name = "lvHolidayCalender";
            this.lvHolidayCalender.Size = new System.Drawing.Size(959, 543);
            this.lvHolidayCalender.TabIndex = 222;
            this.lvHolidayCalender.UseCompatibleStateImageBehavior = false;
            this.lvHolidayCalender.View = System.Windows.Forms.View.Details;
            this.lvHolidayCalender.SelectedIndexChanged += new System.EventHandler(this.lvHolidayCalender_SelectedIndexChanged);
            this.lvHolidayCalender.Click += new System.EventHandler(this.lvHolidayCalender_Click);
            // 
            // btnRefreshType
            // 
            this.btnRefreshType.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshType.ForeColor = System.Drawing.Color.White;
            this.btnRefreshType.Location = new System.Drawing.Point(266, 176);
            this.btnRefreshType.Name = "btnRefreshType";
            this.btnRefreshType.Size = new System.Drawing.Size(30, 28);
            this.btnRefreshType.TabIndex = 224;
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
            this.btnAddType.Location = new System.Drawing.Point(230, 176);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(32, 28);
            this.btnAddType.TabIndex = 223;
            this.btnAddType.TabStop = false;
            this.btnAddType.Text = "+";
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnRefreshName
            // 
            this.btnRefreshName.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshName.ForeColor = System.Drawing.Color.White;
            this.btnRefreshName.Location = new System.Drawing.Point(644, 176);
            this.btnRefreshName.Name = "btnRefreshName";
            this.btnRefreshName.Size = new System.Drawing.Size(30, 28);
            this.btnRefreshName.TabIndex = 226;
            this.btnRefreshName.TabStop = false;
            this.btnRefreshName.Text = "..";
            this.btnRefreshName.UseVisualStyleBackColor = false;
            this.btnRefreshName.Click += new System.EventHandler(this.btnRefreshName_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddName.ForeColor = System.Drawing.Color.White;
            this.btnAddName.Location = new System.Drawing.Point(608, 176);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(32, 28);
            this.btnAddName.TabIndex = 225;
            this.btnAddName.TabStop = false;
            this.btnAddName.Text = "+";
            this.btnAddName.UseVisualStyleBackColor = false;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(306, 212);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(296, 31);
            this.btnProcess.TabIndex = 227;
            this.btnProcess.Text = "Process Weekend";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // frmHolidayCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(959, 780);
            this.isEnterTabAllow = true;
            this.Name = "frmHolidayCalender";
            this.Load += new System.EventHandler(this.frmHolidayCalender_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboHolidayType;
        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboHolidayName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartDateTextBox txtHolidayDate;
        private AtiqsControlLibrary.SmartCheckBox chkMoon;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartListViewDetails lvHolidayCalender;
        private System.Windows.Forms.Button btnRefreshType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnRefreshName;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnProcess;
    }
}
