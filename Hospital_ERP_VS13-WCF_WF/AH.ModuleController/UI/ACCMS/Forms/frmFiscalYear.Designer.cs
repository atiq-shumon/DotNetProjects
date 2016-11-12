namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmFiscalYear
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtYearID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.dteStartDate = new System.Windows.Forms.DateTimePicker();
            this.dteEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new AtiqsControlLibrary.SmartComboBox();
            this.lvwFiscalYear = new AtiqsControlLibrary.SmartListViewDetails();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(185, 9);
            this.frmLabel.Size = new System.Drawing.Size(347, 33);
            this.frmLabel.Text = "Financial Year Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwFiscalYear);
            this.pnlMain.Controls.Add(this.cboStatus);
            this.pnlMain.Controls.Add(this.dteEndDate);
            this.pnlMain.Controls.Add(this.dteStartDate);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtYearID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(675, 636);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(675, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(343, 551);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(230, 551);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 551);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(117, 551);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(565, 551);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(454, 551);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(675, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(159, 175);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(54, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Year ID:";
            this.smartLabel1.Visible = false;
            // 
            // txtYearID
            // 
            this.txtYearID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearID.Location = new System.Drawing.Point(224, 172);
            this.txtYearID.Name = "txtYearID";
            this.txtYearID.Size = new System.Drawing.Size(293, 24);
            this.txtYearID.TabIndex = 4;
            this.txtYearID.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(63, 215);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(154, 13);
            this.smartLabel2.TabIndex = 2;
            this.smartLabel2.Text = "Financial Year Start Date:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(71, 255);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(142, 13);
            this.smartLabel3.TabIndex = 3;
            this.smartLabel3.Text = "Financial Year To Date:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(166, 293);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(47, 13);
            this.smartLabel4.TabIndex = 4;
            this.smartLabel4.Text = "Status:";
            // 
            // dteStartDate
            // 
            this.dteStartDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteStartDate.Location = new System.Drawing.Point(224, 213);
            this.dteStartDate.Name = "dteStartDate";
            this.dteStartDate.Size = new System.Drawing.Size(293, 22);
            this.dteStartDate.TabIndex = 1;
            this.dteStartDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteStartDate_KeyPress);
            // 
            // dteEndDate
            // 
            this.dteEndDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteEndDate.Location = new System.Drawing.Point(224, 250);
            this.dteEndDate.Name = "dteEndDate";
            this.dteEndDate.Size = new System.Drawing.Size(293, 22);
            this.dteEndDate.TabIndex = 2;
            this.dteEndDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteEndDate_KeyPress);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.Blue;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Active ",
            "Close"});
            this.cboStatus.Location = new System.Drawing.Point(224, 289);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(293, 26);
            this.cboStatus.TabIndex = 3;
            this.cboStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboStatus_KeyPress);
            // 
            // lvwFiscalYear
            // 
            this.lvwFiscalYear.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwFiscalYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwFiscalYear.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwFiscalYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwFiscalYear.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFiscalYear.FullRowSelect = true;
            this.lvwFiscalYear.GridLines = true;
            this.lvwFiscalYear.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFiscalYear.Location = new System.Drawing.Point(8, 335);
            this.lvwFiscalYear.Name = "lvwFiscalYear";
            this.lvwFiscalYear.Size = new System.Drawing.Size(654, 289);
            this.lvwFiscalYear.TabIndex = 8;
            this.lvwFiscalYear.UseCompatibleStateImageBehavior = false;
            this.lvwFiscalYear.View = System.Windows.Forms.View.Details;
            this.lvwFiscalYear.SelectedIndexChanged += new System.EventHandler(this.lvwFiscalYear_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Year ID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Start Date";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "End Date";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 100;
            // 
            // frmFiscalYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(675, 623);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmFiscalYear";
            this.Load += new System.EventHandler(this.frmFiscalYear_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwFiscalYear;
        private AtiqsControlLibrary.SmartComboBox cboStatus;
        private System.Windows.Forms.DateTimePicker dteEndDate;
        private System.Windows.Forms.DateTimePicker dteStartDate;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtYearID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
