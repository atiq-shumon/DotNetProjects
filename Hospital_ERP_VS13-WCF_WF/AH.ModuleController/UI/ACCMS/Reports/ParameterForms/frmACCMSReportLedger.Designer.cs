namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    partial class frmACCMSReportLedger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboCompany = new AtiqsControlLibrary.SmartComboBox();
            this.lblLabel = new AtiqsControlLibrary.SmartLabel();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboLedgerName = new System.Windows.Forms.ComboBox();
            this.txtCodeAllocation = new System.Windows.Forms.TextBox();
            this.DGLedger = new AtiqsControlLibrary.SmartDataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtLCode = new System.Windows.Forms.TextBox();
            this.lblName = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(473, 324);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(359, 324);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(240, 9);
            this.frmLabel.Size = new System.Drawing.Size(0, 32);
            this.frmLabel.Text = "";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.DGLedger);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.txtLCode);
            this.pnlMain.Controls.Add(this.txtLName);
            this.pnlMain.Controls.Add(this.txtCodeAllocation);
            this.pnlMain.Controls.Add(this.cboLedgerName);
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.lvlStartDate);
            this.pnlMain.Controls.Add(this.lvlEndDate);
            this.pnlMain.Controls.Add(this.lblLabel);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboCompany);
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Size = new System.Drawing.Size(694, 261);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(584, 57);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(103, 34);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(109, 18);
            this.smartLabel1.TabIndex = 27;
            this.smartLabel1.Text = "Company Name:";
            // 
            // cboCompany
            // 
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompany.ForeColor = System.Drawing.Color.Blue;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(223, 31);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(346, 26);
            this.cboCompany.TabIndex = 26;
            this.cboCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCompany_KeyPress);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLabel.Location = new System.Drawing.Point(125, 81);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(87, 18);
            this.lblLabel.TabIndex = 29;
            this.lblLabel.Text = "Ledger Code:";
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(135, 182);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(71, 18);
            this.lvlStartDate.TabIndex = 32;
            this.lvlStartDate.Text = "Start Date:";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(365, 183);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(67, 18);
            this.lvlEndDate.TabIndex = 33;
            this.lvlEndDate.Text = "End Date:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(223, 179);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(131, 26);
            this.dtStartDate.TabIndex = 34;
            this.dtStartDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtStartDate_KeyPress);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(440, 179);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(129, 26);
            this.dtEndDate.TabIndex = 35;
            this.dtEndDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtEndDate_KeyPress);
            // 
            // cboLedgerName
            // 
            this.cboLedgerName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLedgerName.FormattingEnabled = true;
            this.cboLedgerName.Location = new System.Drawing.Point(11, 59);
            this.cboLedgerName.Name = "cboLedgerName";
            this.cboLedgerName.Size = new System.Drawing.Size(42, 24);
            this.cboLedgerName.TabIndex = 36;
            this.cboLedgerName.Visible = false;
            this.cboLedgerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboLedgerName_KeyUp);
            // 
            // txtCodeAllocation
            // 
            this.txtCodeAllocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodeAllocation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeAllocation.Location = new System.Drawing.Point(223, 78);
            this.txtCodeAllocation.Name = "txtCodeAllocation";
            this.txtCodeAllocation.Size = new System.Drawing.Size(343, 27);
            this.txtCodeAllocation.TabIndex = 37;
            this.txtCodeAllocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLName_KeyDown);
            this.txtCodeAllocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLName_KeyPress);
            this.txtCodeAllocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLName_KeyUp);
            // 
            // DGLedger
            // 
            this.DGLedger.AllowUserToAddRows = false;
            this.DGLedger.AllowUserToDeleteRows = false;
            this.DGLedger.AllowUserToOrderColumns = true;
            this.DGLedger.AllowUserToResizeColumns = false;
            this.DGLedger.AllowUserToResizeRows = false;
            this.DGLedger.BackgroundColor = System.Drawing.Color.White;
            this.DGLedger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DGLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGLedger.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGLedger.Location = new System.Drawing.Point(132, 107);
            this.DGLedger.MultiSelect = false;
            this.DGLedger.Name = "DGLedger";
            this.DGLedger.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGLedger.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGLedger.Size = new System.Drawing.Size(437, 140);
            this.DGLedger.TabIndex = 143;
            this.DGLedger.Visible = false;
            this.DGLedger.DoubleClick += new System.EventHandler(this.DGLedger_DoubleClick);
            this.DGLedger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGLedger_KeyPress);
            // 
            // Column11
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column11.HeaderText = "L Code";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 120;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Code";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // txtLName
            // 
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Enabled = false;
            this.txtLName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLName.Location = new System.Drawing.Point(223, 111);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(343, 27);
            this.txtLName.TabIndex = 144;
            // 
            // txtLCode
            // 
            this.txtLCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLCode.Location = new System.Drawing.Point(48, 2);
            this.txtLCode.Name = "txtLCode";
            this.txtLCode.Size = new System.Drawing.Size(142, 27);
            this.txtLCode.TabIndex = 145;
            this.txtLCode.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(119, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 18);
            this.lblName.TabIndex = 146;
            this.lblName.Text = "Ledger Name:";
            // 
            // frmACCMSReportLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.KeyPreview = false;
            this.Name = "frmACCMSReportLedger";
            this.Load += new System.EventHandler(this.frmACCMSReportLedger_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGLedger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboCompany;
        private AtiqsControlLibrary.SmartLabel lblLabel;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.ComboBox cboLedgerName;
        private System.Windows.Forms.TextBox txtCodeAllocation;
        private AtiqsControlLibrary.SmartDataGridView DGLedger;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtLCode;
        private AtiqsControlLibrary.SmartLabel lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
