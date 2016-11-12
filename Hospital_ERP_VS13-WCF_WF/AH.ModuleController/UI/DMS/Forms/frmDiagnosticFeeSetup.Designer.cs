namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmDiagnosticFeeSetup
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
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboGroupID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboFeeCatID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.cboMainID = new AtiqsControlLibrary.SmartComboBox();
            this.cboDetailID = new AtiqsControlLibrary.SmartComboBox();
            this.lvFee = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtFee = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtDeptAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtReffAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtVat = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtDocAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtDiscount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.UnassignCheck = new AtiqsControlLibrary.SmartCheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearchTest = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.txtPanleID = new AtiqsControlLibrary.SmartNumericTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(910, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(322, 33);
            this.frmLabel.Text = "Diagnostic Test Fee Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtSearchTest);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.UnassignCheck);
            this.pnlMain.Controls.Add(this.txtDiscount);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtDocAmount);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.txtVat);
            this.pnlMain.Controls.Add(this.txtReffAmount);
            this.pnlMain.Controls.Add(this.txtDeptAmount);
            this.pnlMain.Controls.Add(this.txtFee);
            this.pnlMain.Controls.Add(this.lvFee);
            this.pnlMain.Controls.Add(this.cboDetailID);
            this.pnlMain.Controls.Add(this.cboMainID);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboFeeCatID);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboDeptID);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboGroupID);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(982, 689);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(984, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(753, 747);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(639, 747);
            this.btnSave.TabIndex = 12;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 748);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(525, 747);
            this.btnNew.TabIndex = 30;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(867, 747);
            this.btnClose.TabIndex = 25;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(127, 748);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 787);
            this.groupBox1.Size = new System.Drawing.Size(984, 23);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(15, 13);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(87, 18);
            this.smartLabel7.TabIndex = 53;
            this.smartLabel7.Text = "Department :";
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(15, 36);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(237, 26);
            this.cboDeptID.TabIndex = 0;
            this.cboDeptID.SelectedIndexChanged += new System.EventHandler(this.cboDeptID_SelectedIndexChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(258, 13);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(82, 18);
            this.smartLabel6.TabIndex = 51;
            this.smartLabel6.Text = "Test Group :";
            // 
            // cboGroupID
            // 
            this.cboGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupID.ForeColor = System.Drawing.Color.Blue;
            this.cboGroupID.FormattingEnabled = true;
            this.cboGroupID.Location = new System.Drawing.Point(258, 36);
            this.cboGroupID.Name = "cboGroupID";
            this.cboGroupID.Size = new System.Drawing.Size(194, 26);
            this.cboGroupID.TabIndex = 1;
            this.cboGroupID.SelectedIndexChanged += new System.EventHandler(this.cboGroupID_SelectedIndexChanged);
            this.cboGroupID.Click += new System.EventHandler(this.cboGroupID_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(455, 13);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(75, 18);
            this.smartLabel2.TabIndex = 42;
            this.smartLabel2.Text = "Test Main :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(15, 78);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 18);
            this.smartLabel1.TabIndex = 40;
            this.smartLabel1.Text = "Test Details :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(766, 13);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(91, 18);
            this.smartLabel3.TabIndex = 55;
            this.smartLabel3.Text = "Fee Category :";
            // 
            // cboFeeCatID
            // 
            this.cboFeeCatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFeeCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFeeCatID.ForeColor = System.Drawing.Color.Blue;
            this.cboFeeCatID.FormattingEnabled = true;
            this.cboFeeCatID.Location = new System.Drawing.Point(769, 36);
            this.cboFeeCatID.Name = "cboFeeCatID";
            this.cboFeeCatID.Size = new System.Drawing.Size(117, 26);
            this.cboFeeCatID.TabIndex = 3;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(458, 78);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(35, 18);
            this.smartLabel4.TabIndex = 57;
            this.smartLabel4.Text = "Fee :";
            // 
            // smartLabel8
            // 
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(544, 78);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(83, 18);
            this.smartLabel8.TabIndex = 59;
            this.smartLabel8.Text = "Dept. Amt :";
            this.smartLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(624, 78);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(72, 18);
            this.smartLabel5.TabIndex = 61;
            this.smartLabel5.Text = "Reff. Amt :";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(778, 78);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(43, 18);
            this.smartLabel9.TabIndex = 63;
            this.smartLabel9.Text = "VAT :";
            // 
            // cboMainID
            // 
            this.cboMainID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMainID.ForeColor = System.Drawing.Color.Blue;
            this.cboMainID.FormattingEnabled = true;
            this.cboMainID.Location = new System.Drawing.Point(457, 36);
            this.cboMainID.Name = "cboMainID";
            this.cboMainID.Size = new System.Drawing.Size(306, 26);
            this.cboMainID.TabIndex = 2;
            // 
            // cboDetailID
            // 
            this.cboDetailID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDetailID.ForeColor = System.Drawing.Color.Blue;
            this.cboDetailID.FormattingEnabled = true;
            this.cboDetailID.Location = new System.Drawing.Point(15, 101);
            this.cboDetailID.Name = "cboDetailID";
            this.cboDetailID.Size = new System.Drawing.Size(437, 26);
            this.cboDetailID.TabIndex = 5;
            // 
            // lvFee
            // 
            this.lvFee.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFee.CheckBoxes = true;
            this.lvFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvFee.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFee.FullRowSelect = true;
            this.lvFee.GridLines = true;
            this.lvFee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFee.Location = new System.Drawing.Point(0, 187);
            this.lvFee.Name = "lvFee";
            this.lvFee.Size = new System.Drawing.Size(982, 501);
            this.lvFee.TabIndex = 67;
            this.lvFee.TabStop = false;
            this.lvFee.UseCompatibleStateImageBehavior = false;
            this.lvFee.View = System.Windows.Forms.View.Details;
            this.lvFee.SelectedIndexChanged += new System.EventHandler(this.lvFee_SelectedIndexChanged);
            this.lvFee.Click += new System.EventHandler(this.lvFee_Click);
            // 
            // txtFee
            // 
            this.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(457, 101);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(98, 24);
            this.txtFee.TabIndex = 6;
            // 
            // txtDeptAmount
            // 
            this.txtDeptAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptAmount.Location = new System.Drawing.Point(556, 101);
            this.txtDeptAmount.Name = "txtDeptAmount";
            this.txtDeptAmount.Size = new System.Drawing.Size(70, 24);
            this.txtDeptAmount.TabIndex = 7;
            // 
            // txtReffAmount
            // 
            this.txtReffAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReffAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReffAmount.Location = new System.Drawing.Point(627, 101);
            this.txtReffAmount.Name = "txtReffAmount";
            this.txtReffAmount.Size = new System.Drawing.Size(72, 24);
            this.txtReffAmount.TabIndex = 8;
            // 
            // txtVat
            // 
            this.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(776, 101);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(52, 24);
            this.txtVat.TabIndex = 10;
            // 
            // txtDocAmount
            // 
            this.txtDocAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocAmount.Location = new System.Drawing.Point(700, 101);
            this.txtDocAmount.Name = "txtDocAmount";
            this.txtDocAmount.Size = new System.Drawing.Size(75, 24);
            this.txtDocAmount.TabIndex = 9;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(697, 78);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(67, 18);
            this.smartLabel11.TabIndex = 72;
            this.smartLabel11.Text = "Doc Amt :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(829, 101);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(57, 24);
            this.txtDiscount.TabIndex = 11;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(826, 78);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(61, 18);
            this.smartLabel12.TabIndex = 74;
            this.smartLabel12.Text = "Disc(%) :";
            // 
            // UnassignCheck
            // 
            this.UnassignCheck.AutoSize = true;
            this.UnassignCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnassignCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnassignCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnassignCheck.ForeColor = System.Drawing.Color.Black;
            this.UnassignCheck.Location = new System.Drawing.Point(277, 73);
            this.UnassignCheck.Name = "UnassignCheck";
            this.UnassignCheck.Size = new System.Drawing.Size(170, 22);
            this.UnassignCheck.TabIndex = 75;
            this.UnassignCheck.TabStop = false;
            this.UnassignCheck.Text = "UnAssigned Test Only";
            this.UnassignCheck.UseVisualStyleBackColor = true;
            this.UnassignCheck.CheckedChanged += new System.EventHandler(this.UnassignCheck_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(892, 34);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(68, 28);
            this.btnShow.TabIndex = 76;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(892, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 28);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearchTest
            // 
            this.txtSearchTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTest.Location = new System.Drawing.Point(15, 157);
            this.txtSearchTest.Name = "txtSearchTest";
            this.txtSearchTest.Size = new System.Drawing.Size(437, 24);
            this.txtSearchTest.TabIndex = 78;
            this.txtSearchTest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchTest_KeyUp);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(16, 134);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(151, 18);
            this.smartLabel10.TabIndex = 79;
            this.smartLabel10.Text = "Search Test From Here :";
            // 
            // txtPanleID
            // 
            this.txtPanleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanleID.Location = new System.Drawing.Point(241, 756);
            this.txtPanleID.Name = "txtPanleID";
            this.txtPanleID.Size = new System.Drawing.Size(57, 24);
            this.txtPanleID.TabIndex = 51;
            this.txtPanleID.Visible = false;
            // 
            // frmDiagnosticFeeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 810);
            this.Controls.Add(this.txtPanleID);
            this.isEnterTabAllow = true;
            this.Name = "frmDiagnosticFeeSetup";
            this.Load += new System.EventHandler(this.frmDiagnosticFeeSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtPanleID, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboGroupID;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboFeeCatID;
        private AtiqsControlLibrary.SmartComboBox cboMainID;
        private AtiqsControlLibrary.SmartComboBox cboDetailID;
        private AtiqsControlLibrary.SmartListViewDetails lvFee;
        private AtiqsControlLibrary.SmartNumericTextBox txtVat;
        private AtiqsControlLibrary.SmartNumericTextBox txtReffAmount;
        private AtiqsControlLibrary.SmartNumericTextBox txtDeptAmount;
        private AtiqsControlLibrary.SmartNumericTextBox txtFee;
        private AtiqsControlLibrary.SmartNumericTextBox txtDocAmount;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartNumericTextBox txtDiscount;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartCheckBox UnassignCheck;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartTextBox txtSearchTest;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartNumericTextBox txtPanleID;
    }
}
