namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmPayrollBaseSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtEmpID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.txtGross = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblNewGross = new AtiqsControlLibrary.SmartLabel();
            this.btnNewClose = new System.Windows.Forms.Button();
            this.txtGender = new AtiqsControlLibrary.SmartTextBox();
            this.txtAge = new AtiqsControlLibrary.SmartTextBox();
            this.txtCash = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lblFinalGross = new AtiqsControlLibrary.SmartLabel();
            this.txtFinalGross = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.dgvSalaryHead = new AtiqsControlLibrary.SmartDataGridView();
            this.txtNewCash = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblCash = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboFiscalYear = new AtiqsControlLibrary.SmartComboBox();
            this.txtTaxFreeLimit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtConveyance = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtMAExm = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtHraExm = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot5 = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot4 = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot3 = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot2 = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot1 = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtInvstTaxRebate = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtInvstLimit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtMinTaxAmt = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot1Limit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot2Limit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot3Limit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot4Limit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSlot5Limit = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtNetBank = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtTotalSal = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtConsolidateFlag = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtJobType = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryHead)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(176, 9);
            this.frmLabel.Size = new System.Drawing.Size(234, 33);
            this.frmLabel.Text = "Payroll Base Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.txtJobType);
            this.pnlMain.Controls.Add(this.txtConsolidateFlag);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtTotalSal);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtNetBank);
            this.pnlMain.Controls.Add(this.txtSlot5Limit);
            this.pnlMain.Controls.Add(this.txtSlot4Limit);
            this.pnlMain.Controls.Add(this.txtSlot3Limit);
            this.pnlMain.Controls.Add(this.txtSlot2Limit);
            this.pnlMain.Controls.Add(this.txtSlot1Limit);
            this.pnlMain.Controls.Add(this.txtMinTaxAmt);
            this.pnlMain.Controls.Add(this.txtSlot5);
            this.pnlMain.Controls.Add(this.txtSlot4);
            this.pnlMain.Controls.Add(this.txtSlot3);
            this.pnlMain.Controls.Add(this.txtSlot2);
            this.pnlMain.Controls.Add(this.txtSlot1);
            this.pnlMain.Controls.Add(this.txtInvstTaxRebate);
            this.pnlMain.Controls.Add(this.txtInvstLimit);
            this.pnlMain.Controls.Add(this.txtTaxFreeLimit);
            this.pnlMain.Controls.Add(this.txtConveyance);
            this.pnlMain.Controls.Add(this.txtMAExm);
            this.pnlMain.Controls.Add(this.txtHraExm);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboFiscalYear);
            this.pnlMain.Controls.Add(this.lblCash);
            this.pnlMain.Controls.Add(this.txtNewCash);
            this.pnlMain.Controls.Add(this.txtFinalGross);
            this.pnlMain.Controls.Add(this.lblFinalGross);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtCash);
            this.pnlMain.Controls.Add(this.lblNewGross);
            this.pnlMain.Controls.Add(this.txtGross);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Controls.Add(this.btnGenerate);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.dgvSalaryHead);
            this.pnlMain.Size = new System.Drawing.Size(609, 749);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(609, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(16, 668);
            this.btnEdit.Size = new System.Drawing.Size(24, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(385, 668);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(46, 668);
            this.btnDelete.Size = new System.Drawing.Size(28, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(272, 668);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(109, 668);
            this.btnClose.Size = new System.Drawing.Size(21, 39);
            this.btnClose.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(76, 668);
            this.btnPrint.Size = new System.Drawing.Size(27, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 707);
            this.groupBox1.Size = new System.Drawing.Size(609, 25);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(332, 222);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(128, 26);
            this.btnGenerate.TabIndex = 215;
            this.btnGenerate.Text = "Generate Base";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(11, 206);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(44, 13);
            this.smartLabel4.TabIndex = 214;
            this.smartLabel4.Text = "Bank :";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(11, 224);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(155, 24);
            this.txtAmount.TabIndex = 2;
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(172, 169);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(123, 24);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.Leave += new System.EventHandler(this.txtEmpID_Leave);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(172, 151);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(56, 13);
            this.smartLabel1.TabIndex = 217;
            this.smartLabel1.Text = "Emp ID :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(299, 167);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(67, 26);
            this.btnShow.TabIndex = 218;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(375, 169);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 219;
            // 
            // txtGross
            // 
            this.txtGross.BackColor = System.Drawing.Color.Linen;
            this.txtGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGross.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtGross.Location = new System.Drawing.Point(222, 719);
            this.txtGross.MaxLength = 10;
            this.txtGross.Multiline = true;
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(130, 24);
            this.txtGross.TabIndex = 220;
            this.txtGross.TabStop = false;
            // 
            // lblNewGross
            // 
            this.lblNewGross.AutoSize = true;
            this.lblNewGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNewGross.Location = new System.Drawing.Point(219, 700);
            this.lblNewGross.Name = "lblNewGross";
            this.lblNewGross.Size = new System.Drawing.Size(132, 13);
            this.lblNewGross.TabIndex = 221;
            this.lblNewGross.Text = "Total Bank Salary (C):";
            // 
            // btnNewClose
            // 
            this.btnNewClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnNewClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClose.ForeColor = System.Drawing.Color.Navy;
            this.btnNewClose.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNewClose.ImageIndex = 5;
            this.btnNewClose.Location = new System.Drawing.Point(497, 668);
            this.btnNewClose.Name = "btnNewClose";
            this.btnNewClose.Size = new System.Drawing.Size(108, 39);
            this.btnNewClose.TabIndex = 16;
            this.btnNewClose.Text = "Close";
            this.btnNewClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewClose.UseVisualStyleBackColor = false;
            this.btnNewClose.Click += new System.EventHandler(this.btnNewClose_Click);
            // 
            // txtGender
            // 
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(136, 677);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(27, 24);
            this.txtGender.TabIndex = 217;
            this.txtGender.Visible = false;
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(169, 677);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(27, 24);
            this.txtAge.TabIndex = 218;
            this.txtAge.Visible = false;
            // 
            // txtCash
            // 
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(172, 224);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(154, 24);
            this.txtCash.TabIndex = 3;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(172, 206);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(43, 13);
            this.smartLabel2.TabIndex = 223;
            this.smartLabel2.Text = "Cash :";
            // 
            // lblFinalGross
            // 
            this.lblFinalGross.AutoSize = true;
            this.lblFinalGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFinalGross.Location = new System.Drawing.Point(483, 700);
            this.lblFinalGross.Name = "lblFinalGross";
            this.lblFinalGross.Size = new System.Drawing.Size(121, 13);
            this.lblFinalGross.TabIndex = 225;
            this.lblFinalGross.Text = "Gross Salary (B+C) :";
            // 
            // txtFinalGross
            // 
            this.txtFinalGross.BackColor = System.Drawing.Color.Linen;
            this.txtFinalGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalGross.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtFinalGross.Location = new System.Drawing.Point(481, 719);
            this.txtFinalGross.Name = "txtFinalGross";
            this.txtFinalGross.ReadOnly = true;
            this.txtFinalGross.Size = new System.Drawing.Size(121, 24);
            this.txtFinalGross.TabIndex = 226;
            this.txtFinalGross.TabStop = false;
            // 
            // dgvSalaryHead
            // 
            this.dgvSalaryHead.AllowUserToAddRows = false;
            this.dgvSalaryHead.AllowUserToDeleteRows = false;
            this.dgvSalaryHead.AllowUserToOrderColumns = true;
            this.dgvSalaryHead.AllowUserToResizeColumns = false;
            this.dgvSalaryHead.AllowUserToResizeRows = false;
            this.dgvSalaryHead.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalaryHead.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSalaryHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryHead.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaryHead.Location = new System.Drawing.Point(2, 256);
            this.dgvSalaryHead.MultiSelect = false;
            this.dgvSalaryHead.Name = "dgvSalaryHead";
            this.dgvSalaryHead.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvSalaryHead.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalaryHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaryHead.Size = new System.Drawing.Size(606, 441);
            this.dgvSalaryHead.TabIndex = 202;
            this.dgvSalaryHead.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSalaryHead_CellValidating);
            this.dgvSalaryHead.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryHead_CellValueChanged);
            // 
            // txtNewCash
            // 
            this.txtNewCash.BackColor = System.Drawing.Color.Linen;
            this.txtNewCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNewCash.Location = new System.Drawing.Point(122, 719);
            this.txtNewCash.Name = "txtNewCash";
            this.txtNewCash.ReadOnly = true;
            this.txtNewCash.Size = new System.Drawing.Size(96, 24);
            this.txtNewCash.TabIndex = 227;
            this.txtNewCash.TabStop = false;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCash.Location = new System.Drawing.Point(120, 700);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(83, 13);
            this.lblCash.TabIndex = 228;
            this.lblCash.Text = "Net Cash (B):";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(11, 149);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(78, 13);
            this.smartLabel3.TabIndex = 230;
            this.smartLabel3.Text = "Fiscal Year :";
            // 
            // cboFiscalYear
            // 
            this.cboFiscalYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiscalYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiscalYear.ForeColor = System.Drawing.Color.Blue;
            this.cboFiscalYear.FormattingEnabled = true;
            this.cboFiscalYear.Location = new System.Drawing.Point(11, 168);
            this.cboFiscalYear.Name = "cboFiscalYear";
            this.cboFiscalYear.Size = new System.Drawing.Size(155, 26);
            this.cboFiscalYear.TabIndex = 0;
            // 
            // txtTaxFreeLimit
            // 
            this.txtTaxFreeLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxFreeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxFreeLimit.Location = new System.Drawing.Point(506, 158);
            this.txtTaxFreeLimit.Name = "txtTaxFreeLimit";
            this.txtTaxFreeLimit.Size = new System.Drawing.Size(37, 24);
            this.txtTaxFreeLimit.TabIndex = 234;
            this.txtTaxFreeLimit.Visible = false;
            // 
            // txtConveyance
            // 
            this.txtConveyance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConveyance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConveyance.Location = new System.Drawing.Point(477, 158);
            this.txtConveyance.Name = "txtConveyance";
            this.txtConveyance.Size = new System.Drawing.Size(32, 24);
            this.txtConveyance.TabIndex = 233;
            this.txtConveyance.Visible = false;
            // 
            // txtMAExm
            // 
            this.txtMAExm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMAExm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAExm.Location = new System.Drawing.Point(444, 158);
            this.txtMAExm.Name = "txtMAExm";
            this.txtMAExm.Size = new System.Drawing.Size(37, 24);
            this.txtMAExm.TabIndex = 232;
            this.txtMAExm.Visible = false;
            // 
            // txtHraExm
            // 
            this.txtHraExm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHraExm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHraExm.Location = new System.Drawing.Point(410, 158);
            this.txtHraExm.Name = "txtHraExm";
            this.txtHraExm.Size = new System.Drawing.Size(34, 24);
            this.txtHraExm.TabIndex = 231;
            this.txtHraExm.Visible = false;
            // 
            // txtSlot5
            // 
            this.txtSlot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot5.Location = new System.Drawing.Point(539, 184);
            this.txtSlot5.MaxLength = 2;
            this.txtSlot5.Name = "txtSlot5";
            this.txtSlot5.Size = new System.Drawing.Size(39, 24);
            this.txtSlot5.TabIndex = 241;
            this.txtSlot5.Visible = false;
            // 
            // txtSlot4
            // 
            this.txtSlot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot4.Location = new System.Drawing.Point(509, 184);
            this.txtSlot4.MaxLength = 2;
            this.txtSlot4.Name = "txtSlot4";
            this.txtSlot4.Size = new System.Drawing.Size(27, 24);
            this.txtSlot4.TabIndex = 240;
            this.txtSlot4.Visible = false;
            // 
            // txtSlot3
            // 
            this.txtSlot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot3.Location = new System.Drawing.Point(473, 184);
            this.txtSlot3.MaxLength = 2;
            this.txtSlot3.Name = "txtSlot3";
            this.txtSlot3.Size = new System.Drawing.Size(35, 24);
            this.txtSlot3.TabIndex = 239;
            this.txtSlot3.Visible = false;
            // 
            // txtSlot2
            // 
            this.txtSlot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot2.Location = new System.Drawing.Point(437, 184);
            this.txtSlot2.MaxLength = 2;
            this.txtSlot2.Name = "txtSlot2";
            this.txtSlot2.Size = new System.Drawing.Size(33, 24);
            this.txtSlot2.TabIndex = 238;
            this.txtSlot2.Visible = false;
            // 
            // txtSlot1
            // 
            this.txtSlot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot1.Location = new System.Drawing.Point(410, 184);
            this.txtSlot1.MaxLength = 2;
            this.txtSlot1.Name = "txtSlot1";
            this.txtSlot1.Size = new System.Drawing.Size(26, 24);
            this.txtSlot1.TabIndex = 237;
            this.txtSlot1.Visible = false;
            // 
            // txtInvstTaxRebate
            // 
            this.txtInvstTaxRebate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvstTaxRebate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvstTaxRebate.Location = new System.Drawing.Point(539, 158);
            this.txtInvstTaxRebate.MaxLength = 2;
            this.txtInvstTaxRebate.Name = "txtInvstTaxRebate";
            this.txtInvstTaxRebate.Size = new System.Drawing.Size(30, 24);
            this.txtInvstTaxRebate.TabIndex = 235;
            this.txtInvstTaxRebate.Visible = false;
            // 
            // txtInvstLimit
            // 
            this.txtInvstLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvstLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvstLimit.Location = new System.Drawing.Point(566, 158);
            this.txtInvstLimit.MaxLength = 2;
            this.txtInvstLimit.Name = "txtInvstLimit";
            this.txtInvstLimit.Size = new System.Drawing.Size(35, 24);
            this.txtInvstLimit.TabIndex = 236;
            this.txtInvstLimit.Visible = false;
            // 
            // txtMinTaxAmt
            // 
            this.txtMinTaxAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinTaxAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinTaxAmt.Location = new System.Drawing.Point(578, 184);
            this.txtMinTaxAmt.MaxLength = 2;
            this.txtMinTaxAmt.Name = "txtMinTaxAmt";
            this.txtMinTaxAmt.Size = new System.Drawing.Size(26, 24);
            this.txtMinTaxAmt.TabIndex = 242;
            this.txtMinTaxAmt.Visible = false;
            // 
            // txtSlot1Limit
            // 
            this.txtSlot1Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot1Limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot1Limit.Location = new System.Drawing.Point(410, 192);
            this.txtSlot1Limit.MaxLength = 2;
            this.txtSlot1Limit.Name = "txtSlot1Limit";
            this.txtSlot1Limit.Size = new System.Drawing.Size(26, 24);
            this.txtSlot1Limit.TabIndex = 243;
            this.txtSlot1Limit.Visible = false;
            // 
            // txtSlot2Limit
            // 
            this.txtSlot2Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot2Limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot2Limit.Location = new System.Drawing.Point(437, 192);
            this.txtSlot2Limit.MaxLength = 2;
            this.txtSlot2Limit.Name = "txtSlot2Limit";
            this.txtSlot2Limit.Size = new System.Drawing.Size(26, 24);
            this.txtSlot2Limit.TabIndex = 244;
            this.txtSlot2Limit.Visible = false;
            // 
            // txtSlot3Limit
            // 
            this.txtSlot3Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot3Limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot3Limit.Location = new System.Drawing.Point(469, 192);
            this.txtSlot3Limit.MaxLength = 2;
            this.txtSlot3Limit.Name = "txtSlot3Limit";
            this.txtSlot3Limit.Size = new System.Drawing.Size(26, 24);
            this.txtSlot3Limit.TabIndex = 245;
            this.txtSlot3Limit.Visible = false;
            // 
            // txtSlot4Limit
            // 
            this.txtSlot4Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot4Limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot4Limit.Location = new System.Drawing.Point(501, 192);
            this.txtSlot4Limit.MaxLength = 2;
            this.txtSlot4Limit.Name = "txtSlot4Limit";
            this.txtSlot4Limit.Size = new System.Drawing.Size(26, 24);
            this.txtSlot4Limit.TabIndex = 246;
            this.txtSlot4Limit.Visible = false;
            // 
            // txtSlot5Limit
            // 
            this.txtSlot5Limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot5Limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot5Limit.Location = new System.Drawing.Point(533, 192);
            this.txtSlot5Limit.MaxLength = 2;
            this.txtSlot5Limit.Name = "txtSlot5Limit";
            this.txtSlot5Limit.Size = new System.Drawing.Size(26, 24);
            this.txtSlot5Limit.TabIndex = 247;
            this.txtSlot5Limit.Visible = false;
            // 
            // txtNetBank
            // 
            this.txtNetBank.BackColor = System.Drawing.Color.Linen;
            this.txtNetBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNetBank.Location = new System.Drawing.Point(7, 719);
            this.txtNetBank.MaxLength = 10;
            this.txtNetBank.Multiline = true;
            this.txtNetBank.Name = "txtNetBank";
            this.txtNetBank.ReadOnly = true;
            this.txtNetBank.Size = new System.Drawing.Size(111, 24);
            this.txtNetBank.TabIndex = 248;
            this.txtNetBank.TabStop = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(8, 700);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(88, 13);
            this.smartLabel5.TabIndex = 249;
            this.smartLabel5.Text = "Net Bank (A) :";
            // 
            // txtTotalSal
            // 
            this.txtTotalSal.BackColor = System.Drawing.Color.Linen;
            this.txtTotalSal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTotalSal.Location = new System.Drawing.Point(356, 719);
            this.txtTotalSal.MaxLength = 10;
            this.txtTotalSal.Multiline = true;
            this.txtTotalSal.Name = "txtTotalSal";
            this.txtTotalSal.ReadOnly = true;
            this.txtTotalSal.Size = new System.Drawing.Size(121, 24);
            this.txtTotalSal.TabIndex = 250;
            this.txtTotalSal.TabStop = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(353, 700);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(118, 13);
            this.smartLabel6.TabIndex = 251;
            this.smartLabel6.Text = "Total Salary (A+B) :";
            // 
            // txtConsolidateFlag
            // 
            this.txtConsolidateFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsolidateFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsolidateFlag.Location = new System.Drawing.Point(566, 222);
            this.txtConsolidateFlag.MaxLength = 2;
            this.txtConsolidateFlag.Name = "txtConsolidateFlag";
            this.txtConsolidateFlag.Size = new System.Drawing.Size(26, 24);
            this.txtConsolidateFlag.TabIndex = 252;
            this.txtConsolidateFlag.Visible = false;
            // 
            // txtJobType
            // 
            this.txtJobType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobType.Location = new System.Drawing.Point(532, 222);
            this.txtJobType.Name = "txtJobType";
            this.txtJobType.Size = new System.Drawing.Size(28, 24);
            this.txtJobType.TabIndex = 253;
            this.txtJobType.Visible = false;
            // 
            // frmPayrollBaseSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(609, 732);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.btnNewClose);
            this.isEnterTabAllow = true;
            this.Name = "frmPayrollBaseSetup";
            this.Load += new System.EventHandler(this.frmPayrollBaseSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnNewClose, 0);
            this.Controls.SetChildIndex(this.txtGender, 0);
            this.Controls.SetChildIndex(this.txtAge, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartNumericTextBox txtAmount;
        private AtiqsControlLibrary.SmartTextBox txtEmpID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel lblInfo;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtGross;
        private AtiqsControlLibrary.SmartLabel lblNewGross;
        public System.Windows.Forms.Button btnNewClose;
        private AtiqsControlLibrary.SmartTextBox txtGender;
        private AtiqsControlLibrary.SmartTextBox txtAge;
        private AtiqsControlLibrary.SmartNumericTextBox txtCash;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel lblFinalGross;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtFinalGross;
        private AtiqsControlLibrary.SmartDataGridView dgvSalaryHead;
        private AtiqsControlLibrary.SmartLabel lblCash;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtNewCash;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboFiscalYear;
        private AtiqsControlLibrary.SmartNumericTextBox txtTaxFreeLimit;
        private AtiqsControlLibrary.SmartNumericTextBox txtConveyance;
        private AtiqsControlLibrary.SmartNumericTextBox txtMAExm;
        private AtiqsControlLibrary.SmartNumericTextBox txtHraExm;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot5;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot4;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot3;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot2;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot1;
        private AtiqsControlLibrary.SmartNumericTextBox txtInvstTaxRebate;
        private AtiqsControlLibrary.SmartNumericTextBox txtInvstLimit;
        private AtiqsControlLibrary.SmartNumericTextBox txtMinTaxAmt;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot1Limit;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot2Limit;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot3Limit;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot4Limit;
        private AtiqsControlLibrary.SmartNumericTextBox txtSlot5Limit;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtNetBank;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTotalSal;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartNumericTextBox txtConsolidateFlag;
        private AtiqsControlLibrary.SmartTextBox txtJobType;
    }
}
