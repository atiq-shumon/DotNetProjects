namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmDiagnosticTestFeeSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTestFeeGrid = new AtiqsControlLibrary.SmartDataGridView();
            this.cboGroupID = new AtiqsControlLibrary.SmartComboBox();
            this.cboMainID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboFeeCatID = new AtiqsControlLibrary.SmartComboBox();
            this.UnassignCheck = new AtiqsControlLibrary.SmartCheckBox();
            this.pnlUnassignedTest = new System.Windows.Forms.Panel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.txtDiscount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSearchUnAssignedTest = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtDocAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtVat = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtReffAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtDeptAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtFee = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboDetailID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtAssignedTest = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestFeeGrid)).BeginInit();
            this.pnlUnassignedTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(429, 9);
            this.frmLabel.Size = new System.Drawing.Size(322, 33);
            this.frmLabel.Text = "Diagnostic Test Fee Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.pnlUnassignedTest);
            this.pnlMain.Controls.Add(this.UnassignCheck);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboFeeCatID);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.cboGroupID);
            this.pnlMain.Controls.Add(this.cboMainID);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboDeptID);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.dgvTestFeeGrid);
            this.pnlMain.Size = new System.Drawing.Size(1193, 864);
            this.pnlMain.TabStop = true;
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1193, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(966, 783);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 782);
            this.btnSave.TabIndex = 19;
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(126, 782);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(852, 783);
            this.btnNew.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1080, 783);
            this.btnClose.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(237, 782);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 822);
            this.groupBox1.Size = new System.Drawing.Size(1193, 25);
            // 
            // dgvTestFeeGrid
            // 
            this.dgvTestFeeGrid.AllowUserToAddRows = false;
            this.dgvTestFeeGrid.AllowUserToDeleteRows = false;
            this.dgvTestFeeGrid.AllowUserToOrderColumns = true;
            this.dgvTestFeeGrid.AllowUserToResizeColumns = false;
            this.dgvTestFeeGrid.AllowUserToResizeRows = false;
            this.dgvTestFeeGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestFeeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTestFeeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTestFeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestFeeGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTestFeeGrid.Location = new System.Drawing.Point(-1, 270);
            this.dgvTestFeeGrid.MultiSelect = false;
            this.dgvTestFeeGrid.Name = "dgvTestFeeGrid";
            this.dgvTestFeeGrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvTestFeeGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTestFeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestFeeGrid.Size = new System.Drawing.Size(1191, 592);
            this.dgvTestFeeGrid.TabIndex = 183;
            this.dgvTestFeeGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvTestFeeGrid_CellValidating);
            // 
            // cboGroupID
            // 
            this.cboGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupID.ForeColor = System.Drawing.Color.Blue;
            this.cboGroupID.FormattingEnabled = true;
            this.cboGroupID.Location = new System.Drawing.Point(234, 171);
            this.cboGroupID.Name = "cboGroupID";
            this.cboGroupID.Size = new System.Drawing.Size(191, 26);
            this.cboGroupID.TabIndex = 51;
            this.cboGroupID.SelectedIndexChanged += new System.EventHandler(this.cboGroupID_SelectedIndexChanged);
            // 
            // cboMainID
            // 
            this.cboMainID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMainID.ForeColor = System.Drawing.Color.Blue;
            this.cboMainID.FormattingEnabled = true;
            this.cboMainID.Location = new System.Drawing.Point(431, 171);
            this.cboMainID.Name = "cboMainID";
            this.cboMainID.Size = new System.Drawing.Size(242, 26);
            this.cboMainID.TabIndex = 52;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(431, 149);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(68, 15);
            this.smartLabel4.TabIndex = 187;
            this.smartLabel4.Text = "Test Main :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(234, 149);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(48, 15);
            this.smartLabel6.TabIndex = 188;
            this.smartLabel6.Text = "Group :";
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(8, 171);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(220, 26);
            this.cboDeptID.TabIndex = 50;
            this.cboDeptID.SelectedIndexChanged += new System.EventHandler(this.cboDeptID_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(8, 149);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(78, 15);
            this.smartLabel7.TabIndex = 189;
            this.smartLabel7.Text = "Department :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(800, 171);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(56, 26);
            this.btnShow.TabIndex = 54;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(676, 149);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(86, 15);
            this.smartLabel3.TabIndex = 192;
            this.smartLabel3.Text = "Fee Category :";
            // 
            // cboFeeCatID
            // 
            this.cboFeeCatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFeeCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFeeCatID.ForeColor = System.Drawing.Color.Blue;
            this.cboFeeCatID.FormattingEnabled = true;
            this.cboFeeCatID.Location = new System.Drawing.Point(679, 171);
            this.cboFeeCatID.Name = "cboFeeCatID";
            this.cboFeeCatID.Size = new System.Drawing.Size(115, 26);
            this.cboFeeCatID.TabIndex = 53;
            // 
            // UnassignCheck
            // 
            this.UnassignCheck.AutoSize = true;
            this.UnassignCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnassignCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnassignCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnassignCheck.ForeColor = System.Drawing.Color.Black;
            this.UnassignCheck.Location = new System.Drawing.Point(867, 172);
            this.UnassignCheck.Name = "UnassignCheck";
            this.UnassignCheck.Size = new System.Drawing.Size(178, 22);
            this.UnassignCheck.TabIndex = 55;
            this.UnassignCheck.Text = "Show UnAssigned Test";
            this.UnassignCheck.UseVisualStyleBackColor = true;
            this.UnassignCheck.CheckedChanged += new System.EventHandler(this.UnassignCheck_CheckedChanged);
            // 
            // pnlUnassignedTest
            // 
            this.pnlUnassignedTest.Controls.Add(this.smartLabel10);
            this.pnlUnassignedTest.Controls.Add(this.btnNewSave);
            this.pnlUnassignedTest.Controls.Add(this.txtDiscount);
            this.pnlUnassignedTest.Controls.Add(this.txtSearchUnAssignedTest);
            this.pnlUnassignedTest.Controls.Add(this.smartLabel12);
            this.pnlUnassignedTest.Controls.Add(this.txtDocAmount);
            this.pnlUnassignedTest.Controls.Add(this.smartLabel11);
            this.pnlUnassignedTest.Controls.Add(this.txtVat);
            this.pnlUnassignedTest.Controls.Add(this.txtReffAmount);
            this.pnlUnassignedTest.Controls.Add(this.txtDeptAmount);
            this.pnlUnassignedTest.Controls.Add(this.txtFee);
            this.pnlUnassignedTest.Controls.Add(this.smartLabel9);
            this.pnlUnassignedTest.Controls.Add(this.smartLabel5);
            this.pnlUnassignedTest.Controls.Add(this.smartLabel8);
            this.pnlUnassignedTest.Controls.Add(this.smartLabel2);
            this.pnlUnassignedTest.Controls.Add(this.cboDetailID);
            this.pnlUnassignedTest.Controls.Add(this.smartLabel1);
            this.pnlUnassignedTest.Enabled = false;
            this.pnlUnassignedTest.Location = new System.Drawing.Point(-1, 203);
            this.pnlUnassignedTest.Name = "pnlUnassignedTest";
            this.pnlUnassignedTest.Size = new System.Drawing.Size(1193, 61);
            this.pnlUnassignedTest.TabIndex = 196;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(9, 7);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(145, 15);
            this.smartLabel10.TabIndex = 199;
            this.smartLabel10.Text = "Search UnAssigned Test:";
            // 
            // btnNewSave
            // 
            this.btnNewSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSave.ForeColor = System.Drawing.Color.White;
            this.btnNewSave.Location = new System.Drawing.Point(1114, 29);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(56, 26);
            this.btnNewSave.TabIndex = 63;
            this.btnNewSave.Text = "Save";
            this.btnNewSave.UseVisualStyleBackColor = false;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(1052, 30);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(57, 24);
            this.txtDiscount.TabIndex = 62;
            // 
            // txtSearchUnAssignedTest
            // 
            this.txtSearchUnAssignedTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUnAssignedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUnAssignedTest.Location = new System.Drawing.Point(9, 30);
            this.txtSearchUnAssignedTest.Name = "txtSearchUnAssignedTest";
            this.txtSearchUnAssignedTest.Size = new System.Drawing.Size(220, 24);
            this.txtSearchUnAssignedTest.TabIndex = 198;
            this.txtSearchUnAssignedTest.TextChanged += new System.EventHandler(this.txtSearchUnAssignedTest_TextChanged);
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(1050, 7);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(62, 15);
            this.smartLabel12.TabIndex = 86;
            this.smartLabel12.Text = "Disc(%) :";
            // 
            // txtDocAmount
            // 
            this.txtDocAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocAmount.Location = new System.Drawing.Point(923, 30);
            this.txtDocAmount.Name = "txtDocAmount";
            this.txtDocAmount.Size = new System.Drawing.Size(75, 24);
            this.txtDocAmount.TabIndex = 60;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(922, 7);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(60, 15);
            this.smartLabel11.TabIndex = 85;
            this.smartLabel11.Text = "Doc Amt :";
            // 
            // txtVat
            // 
            this.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(999, 30);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(52, 24);
            this.txtVat.TabIndex = 61;
            // 
            // txtReffAmount
            // 
            this.txtReffAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReffAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReffAmount.Location = new System.Drawing.Point(850, 30);
            this.txtReffAmount.Name = "txtReffAmount";
            this.txtReffAmount.Size = new System.Drawing.Size(72, 24);
            this.txtReffAmount.TabIndex = 59;
            // 
            // txtDeptAmount
            // 
            this.txtDeptAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptAmount.Location = new System.Drawing.Point(779, 30);
            this.txtDeptAmount.Name = "txtDeptAmount";
            this.txtDeptAmount.Size = new System.Drawing.Size(70, 24);
            this.txtDeptAmount.TabIndex = 58;
            // 
            // txtFee
            // 
            this.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(680, 30);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(98, 24);
            this.txtFee.TabIndex = 57;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(998, 7);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(37, 15);
            this.smartLabel9.TabIndex = 84;
            this.smartLabel9.Text = "VAT :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(849, 7);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(65, 15);
            this.smartLabel5.TabIndex = 83;
            this.smartLabel5.Text = "Reff. Amt :";
            // 
            // smartLabel8
            // 
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(778, 7);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(62, 18);
            this.smartLabel8.TabIndex = 82;
            this.smartLabel8.Text = "Dept. Amt :";
            this.smartLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(681, 7);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(33, 15);
            this.smartLabel2.TabIndex = 81;
            this.smartLabel2.Text = "Fee :";
            // 
            // cboDetailID
            // 
            this.cboDetailID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDetailID.ForeColor = System.Drawing.Color.Blue;
            this.cboDetailID.FormattingEnabled = true;
            this.cboDetailID.Location = new System.Drawing.Point(235, 30);
            this.cboDetailID.Name = "cboDetailID";
            this.cboDetailID.Size = new System.Drawing.Size(439, 26);
            this.cboDetailID.TabIndex = 56;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(235, 7);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(148, 15);
            this.smartLabel1.TabIndex = 42;
            this.smartLabel1.Text = "UnAssigned Test Details :";
            // 
            // txtAssignedTest
            // 
            this.txtAssignedTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssignedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignedTest.Location = new System.Drawing.Point(32, 792);
            this.txtAssignedTest.Name = "txtAssignedTest";
            this.txtAssignedTest.Size = new System.Drawing.Size(665, 24);
            this.txtAssignedTest.TabIndex = 200;
            this.txtAssignedTest.Visible = false;
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(512, 782);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(139, 15);
            this.smartLabel13.TabIndex = 200;
            this.smartLabel13.Text = "Search Test From Grid :";
            this.smartLabel13.Visible = false;
            // 
            // frmDiagnosticTestFeeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1193, 847);
            this.Controls.Add(this.smartLabel13);
            this.Controls.Add(this.txtAssignedTest);
            this.isEnterTabAllow = true;
            this.Name = "frmDiagnosticTestFeeSetup";
            this.Load += new System.EventHandler(this.frmTestFeeSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.txtAssignedTest, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.smartLabel13, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestFeeGrid)).EndInit();
            this.pnlUnassignedTest.ResumeLayout(false);
            this.pnlUnassignedTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartDataGridView dgvTestFeeGrid;
        private AtiqsControlLibrary.SmartComboBox cboGroupID;
        private AtiqsControlLibrary.SmartComboBox cboMainID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboFeeCatID;
        private AtiqsControlLibrary.SmartCheckBox UnassignCheck;
        private System.Windows.Forms.Panel pnlUnassignedTest;
        private AtiqsControlLibrary.SmartComboBox cboDetailID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartNumericTextBox txtDiscount;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartNumericTextBox txtDocAmount;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartNumericTextBox txtVat;
        private AtiqsControlLibrary.SmartNumericTextBox txtReffAmount;
        private AtiqsControlLibrary.SmartNumericTextBox txtDeptAmount;
        private AtiqsControlLibrary.SmartNumericTextBox txtFee;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.Button btnNewSave;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartTextBox txtSearchUnAssignedTest;
        private AtiqsControlLibrary.SmartTextBox txtAssignedTest;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
    }
}
