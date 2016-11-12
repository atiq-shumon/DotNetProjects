namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmIssueRequisition
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
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboStoreLocation = new AtiqsControlLibrary.SmartComboBox();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.lblWard = new AtiqsControlLibrary.SmartLabel();
            this.lblBedNo = new AtiqsControlLibrary.SmartLabel();
            this.lblRoom = new AtiqsControlLibrary.SmartLabel();
            this.lblBedType = new AtiqsControlLibrary.SmartLabel();
            this.dgvItem = new AtiqsControlLibrary.SmartDataGridView();
            this.cboEmpID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lblNo = new AtiqsControlLibrary.SmartLabel();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.cboSalesTypes = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtIssueDate = new AtiqsControlLibrary.SmartReadOnlyDateTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.txtReceivedBy = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.btnCloseclk = new System.Windows.Forms.Button();
            this.txtAmountSummary = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtQuantity = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDiscount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtvat = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtURate = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtItemName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.txtItemID = new AtiqsControlLibrary.SmartTextBox();
            this.lvItemIssue = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtUnitName = new AtiqsControlLibrary.SmartTextBox();
            this.txtTypeName = new AtiqsControlLibrary.SmartTextBox();
            this.txtModelName = new AtiqsControlLibrary.SmartTextBox();
            this.txtBrandName = new AtiqsControlLibrary.SmartTextBox();
            this.txtCompanyName = new AtiqsControlLibrary.SmartTextBox();
            this.txtGroupName = new AtiqsControlLibrary.SmartTextBox();
            this.txtBrandID = new AtiqsControlLibrary.SmartTextBox();
            this.txtModelID = new AtiqsControlLibrary.SmartTextBox();
            this.txtTypeID = new AtiqsControlLibrary.SmartTextBox();
            this.txtUnitID = new AtiqsControlLibrary.SmartTextBox();
            this.txtGroupID = new AtiqsControlLibrary.SmartTextBox();
            this.txtCompanyID = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1039, 5);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(453, 10);
            this.frmLabel.Size = new System.Drawing.Size(216, 33);
            this.frmLabel.Text = "Issue Requisition";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboStoreLocation);
            this.pnlMain.Controls.Add(this.pnlRegistration);
            this.pnlMain.Controls.Add(this.dgvItem);
            this.pnlMain.Controls.Add(this.cboEmpID);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.lblNo);
            this.pnlMain.Controls.Add(this.txtRegistrationNo);
            this.pnlMain.Controls.Add(this.cboSalesTypes);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.txtIssueDate);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.txtReceivedBy);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.btnCloseclk);
            this.pnlMain.Controls.Add(this.txtAmountSummary);
            this.pnlMain.Controls.Add(this.txtQuantity);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.txtDiscount);
            this.pnlMain.Controls.Add(this.txtvat);
            this.pnlMain.Controls.Add(this.txtURate);
            this.pnlMain.Controls.Add(this.txtItemName);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.txtItemID);
            this.pnlMain.Controls.Add(this.lvItemIssue);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(1091, 729);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1088, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(632, 783);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(518, 783);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(746, 783);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(404, 783);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(974, 783);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(860, 783);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 825);
            this.groupBox1.Size = new System.Drawing.Size(1088, 23);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(351, 7);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(53, 28);
            this.btnShow.TabIndex = 212;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(14, 43);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(99, 18);
            this.smartLabel7.TabIndex = 211;
            this.smartLabel7.Text = "Store Location :";
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreLocation.ForeColor = System.Drawing.Color.Blue;
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(140, 39);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(237, 26);
            this.cboStoreLocation.TabIndex = 210;
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRegistration.Controls.Add(this.lblWard);
            this.pnlRegistration.Controls.Add(this.lblBedNo);
            this.pnlRegistration.Controls.Add(this.lblRoom);
            this.pnlRegistration.Controls.Add(this.lblBedType);
            this.pnlRegistration.Location = new System.Drawing.Point(379, 63);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(366, 50);
            this.pnlRegistration.TabIndex = 209;
            // 
            // lblWard
            // 
            this.lblWard.AutoSize = true;
            this.lblWard.BackColor = System.Drawing.Color.Transparent;
            this.lblWard.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblWard.Location = new System.Drawing.Point(6, 4);
            this.lblWard.Name = "lblWard";
            this.lblWard.Size = new System.Drawing.Size(41, 18);
            this.lblWard.TabIndex = 1;
            this.lblWard.Text = "Ward";
            // 
            // lblBedNo
            // 
            this.lblBedNo.AutoSize = true;
            this.lblBedNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBedNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBedNo.Location = new System.Drawing.Point(227, 28);
            this.lblBedNo.Name = "lblBedNo";
            this.lblBedNo.Size = new System.Drawing.Size(53, 18);
            this.lblBedNo.TabIndex = 3;
            this.lblBedNo.Text = "Bed No";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRoom.Location = new System.Drawing.Point(33, 28);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(43, 18);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Room";
            // 
            // lblBedType
            // 
            this.lblBedType.AutoSize = true;
            this.lblBedType.BackColor = System.Drawing.Color.Transparent;
            this.lblBedType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBedType.Location = new System.Drawing.Point(242, 4);
            this.lblBedType.Name = "lblBedType";
            this.lblBedType.Size = new System.Drawing.Size(66, 18);
            this.lblBedType.TabIndex = 0;
            this.lblBedType.Text = "Bed Type";
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToOrderColumns = true;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItem.Location = new System.Drawing.Point(81, 384);
            this.dgvItem.MultiSelect = false;
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(260, 31);
            this.dgvItem.TabIndex = 208;
            this.dgvItem.TabStop = false;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            this.dgvItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvItem_KeyPress);
            // 
            // cboEmpID
            // 
            this.cboEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpID.ForeColor = System.Drawing.Color.Blue;
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Location = new System.Drawing.Point(140, 124);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(237, 26);
            this.cboEmpID.TabIndex = 207;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(14, 127);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(93, 18);
            this.smartLabel6.TabIndex = 206;
            this.smartLabel6.Text = "Employee ID :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(140, 96);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(237, 26);
            this.cboUnit.TabIndex = 205;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(14, 99);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(116, 18);
            this.smartLabel5.TabIndex = 204;
            this.smartLabel5.Text = "Department Unit :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(140, 68);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(237, 26);
            this.cboDepartment.TabIndex = 203;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(14, 71);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(87, 18);
            this.smartLabel4.TabIndex = 202;
            this.smartLabel4.Text = "Department :";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNo.Location = new System.Drawing.Point(14, 12);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(110, 18);
            this.lblNo.TabIndex = 201;
            this.lblNo.Text = "Registration No : ";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistrationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationNo.ForeColor = System.Drawing.Color.Red;
            this.txtRegistrationNo.Location = new System.Drawing.Point(140, 6);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(211, 31);
            this.txtRegistrationNo.TabIndex = 200;
            // 
            // cboSalesTypes
            // 
            this.cboSalesTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSalesTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSalesTypes.ForeColor = System.Drawing.Color.Blue;
            this.cboSalesTypes.FormattingEnabled = true;
            this.cboSalesTypes.Location = new System.Drawing.Point(502, 8);
            this.cboSalesTypes.Name = "cboSalesTypes";
            this.cboSalesTypes.Size = new System.Drawing.Size(183, 26);
            this.cboSalesTypes.TabIndex = 199;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(410, 12);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(80, 18);
            this.smartLabel11.TabIndex = 198;
            this.smartLabel11.Text = "Issue Type :";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.BackColor = System.Drawing.Color.LightCoral;
            this.txtIssueDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txtIssueDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtIssueDate.ForeColor = System.Drawing.Color.Yellow;
            this.txtIssueDate.Location = new System.Drawing.Point(839, 13);
            this.txtIssueDate.Mask = "00/00/0000";
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.ReadOnly = true;
            this.txtIssueDate.Size = new System.Drawing.Size(100, 24);
            this.txtIssueDate.TabIndex = 195;
            this.txtIssueDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(839, 65);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(247, 26);
            this.txtRemarks.TabIndex = 194;
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(754, 65);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(68, 18);
            this.smartLabel13.TabIndex = 193;
            this.smartLabel13.Text = "Remarks :";
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceivedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedBy.Location = new System.Drawing.Point(839, 39);
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.Size = new System.Drawing.Size(139, 24);
            this.txtReceivedBy.TabIndex = 192;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(734, 42);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(88, 18);
            this.smartLabel10.TabIndex = 191;
            this.smartLabel10.Text = "Received By :";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(744, 16);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(78, 18);
            this.smartLabel9.TabIndex = 190;
            this.smartLabel9.Text = "Issue Date :";
            // 
            // btnCloseclk
            // 
            this.btnCloseclk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCloseclk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseclk.ForeColor = System.Drawing.Color.White;
            this.btnCloseclk.Location = new System.Drawing.Point(1054, 155);
            this.btnCloseclk.Name = "btnCloseclk";
            this.btnCloseclk.Size = new System.Drawing.Size(32, 24);
            this.btnCloseclk.TabIndex = 189;
            this.btnCloseclk.Text = "<<";
            this.btnCloseclk.UseVisualStyleBackColor = false;
            this.btnCloseclk.Click += new System.EventHandler(this.btnCloseclk_Click);
            // 
            // txtAmountSummary
            // 
            this.txtAmountSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountSummary.Location = new System.Drawing.Point(879, 127);
            this.txtAmountSummary.Name = "txtAmountSummary";
            this.txtAmountSummary.ReadOnly = true;
            this.txtAmountSummary.Size = new System.Drawing.Size(25, 24);
            this.txtAmountSummary.TabIndex = 188;
            this.txtAmountSummary.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(989, 180);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(66, 24);
            this.txtQuantity.TabIndex = 186;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(992, 157);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(61, 18);
            this.smartLabel16.TabIndex = 185;
            this.smartLabel16.Text = "Quantity";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(85, 157);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(82, 18);
            this.smartLabel1.TabIndex = 184;
            this.smartLabel1.Text = "Item Name :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1054, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 24);
            this.btnAdd.TabIndex = 183;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(842, 127);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(31, 24);
            this.txtDiscount.TabIndex = 182;
            this.txtDiscount.Visible = false;
            // 
            // txtvat
            // 
            this.txtvat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvat.Location = new System.Drawing.Point(805, 127);
            this.txtvat.Name = "txtvat";
            this.txtvat.ReadOnly = true;
            this.txtvat.Size = new System.Drawing.Size(31, 24);
            this.txtvat.TabIndex = 180;
            this.txtvat.Visible = false;
            // 
            // txtURate
            // 
            this.txtURate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURate.Location = new System.Drawing.Point(774, 127);
            this.txtURate.Name = "txtURate";
            this.txtURate.ReadOnly = true;
            this.txtURate.Size = new System.Drawing.Size(25, 24);
            this.txtURate.TabIndex = 179;
            this.txtURate.Visible = false;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(195)))));
            this.txtItemName.Location = new System.Drawing.Point(85, 180);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(898, 24);
            this.txtItemName.TabIndex = 175;
            this.txtItemName.TabStop = false;
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(8, 157);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(61, 18);
            this.smartLabel14.TabIndex = 176;
            this.smartLabel14.Text = "Item ID :";
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(8, 180);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(74, 24);
            this.txtItemID.TabIndex = 174;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            this.txtItemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemID_KeyDown);
            // 
            // lvItemIssue
            // 
            this.lvItemIssue.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvItemIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvItemIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvItemIssue.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItemIssue.FullRowSelect = true;
            this.lvItemIssue.GridLines = true;
            this.lvItemIssue.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvItemIssue.Location = new System.Drawing.Point(-1, 208);
            this.lvItemIssue.Name = "lvItemIssue";
            this.lvItemIssue.Size = new System.Drawing.Size(1090, 520);
            this.lvItemIssue.TabIndex = 173;
            this.lvItemIssue.UseCompatibleStateImageBehavior = false;
            this.lvItemIssue.View = System.Windows.Forms.View.Details;
            // 
            // txtUnitName
            // 
            this.txtUnitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitName.Location = new System.Drawing.Point(362, 793);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.ReadOnly = true;
            this.txtUnitName.Size = new System.Drawing.Size(27, 24);
            this.txtUnitName.TabIndex = 70;
            this.txtUnitName.Visible = false;
            // 
            // txtTypeName
            // 
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(329, 793);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.ReadOnly = true;
            this.txtTypeName.Size = new System.Drawing.Size(27, 24);
            this.txtTypeName.TabIndex = 69;
            this.txtTypeName.Visible = false;
            // 
            // txtModelName
            // 
            this.txtModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.Location = new System.Drawing.Point(288, 800);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.ReadOnly = true;
            this.txtModelName.Size = new System.Drawing.Size(27, 24);
            this.txtModelName.TabIndex = 68;
            this.txtModelName.Visible = false;
            // 
            // txtBrandName
            // 
            this.txtBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.Location = new System.Drawing.Point(260, 785);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.ReadOnly = true;
            this.txtBrandName.Size = new System.Drawing.Size(27, 24);
            this.txtBrandName.TabIndex = 67;
            this.txtBrandName.Visible = false;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(233, 784);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(27, 24);
            this.txtCompanyName.TabIndex = 66;
            this.txtCompanyName.Visible = false;
            // 
            // txtGroupName
            // 
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Location = new System.Drawing.Point(205, 785);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(27, 24);
            this.txtGroupName.TabIndex = 65;
            this.txtGroupName.Visible = false;
            // 
            // txtBrandID
            // 
            this.txtBrandID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandID.Location = new System.Drawing.Point(147, 784);
            this.txtBrandID.Name = "txtBrandID";
            this.txtBrandID.ReadOnly = true;
            this.txtBrandID.Size = new System.Drawing.Size(27, 24);
            this.txtBrandID.TabIndex = 64;
            this.txtBrandID.Visible = false;
            // 
            // txtModelID
            // 
            this.txtModelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelID.Location = new System.Drawing.Point(118, 784);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.ReadOnly = true;
            this.txtModelID.Size = new System.Drawing.Size(27, 24);
            this.txtModelID.TabIndex = 63;
            this.txtModelID.Visible = false;
            // 
            // txtTypeID
            // 
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.Location = new System.Drawing.Point(91, 784);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.ReadOnly = true;
            this.txtTypeID.Size = new System.Drawing.Size(27, 24);
            this.txtTypeID.TabIndex = 62;
            this.txtTypeID.Visible = false;
            // 
            // txtUnitID
            // 
            this.txtUnitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitID.Location = new System.Drawing.Point(63, 784);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(27, 24);
            this.txtUnitID.TabIndex = 61;
            this.txtUnitID.Visible = false;
            // 
            // txtGroupID
            // 
            this.txtGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupID.Location = new System.Drawing.Point(36, 784);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.ReadOnly = true;
            this.txtGroupID.Size = new System.Drawing.Size(27, 24);
            this.txtGroupID.TabIndex = 60;
            this.txtGroupID.Visible = false;
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyID.Location = new System.Drawing.Point(9, 784);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.ReadOnly = true;
            this.txtCompanyID.Size = new System.Drawing.Size(27, 24);
            this.txtCompanyID.TabIndex = 59;
            this.txtCompanyID.Visible = false;
            // 
            // frmIssueRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1088, 848);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.txtBrandID);
            this.Controls.Add(this.txtModelID);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.txtCompanyID);
            this.KeyPreview = false;
            this.Name = "frmIssueRequisition";
            this.Load += new System.EventHandler(this.frmIssueRequisition_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtCompanyID, 0);
            this.Controls.SetChildIndex(this.txtGroupID, 0);
            this.Controls.SetChildIndex(this.txtUnitID, 0);
            this.Controls.SetChildIndex(this.txtTypeID, 0);
            this.Controls.SetChildIndex(this.txtModelID, 0);
            this.Controls.SetChildIndex(this.txtBrandID, 0);
            this.Controls.SetChildIndex(this.txtGroupName, 0);
            this.Controls.SetChildIndex(this.txtCompanyName, 0);
            this.Controls.SetChildIndex(this.txtBrandName, 0);
            this.Controls.SetChildIndex(this.txtModelName, 0);
            this.Controls.SetChildIndex(this.txtTypeName, 0);
            this.Controls.SetChildIndex(this.txtUnitName, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel pnlRegistration;
        private AtiqsControlLibrary.SmartLabel lblWard;
        private AtiqsControlLibrary.SmartLabel lblBedNo;
        private AtiqsControlLibrary.SmartLabel lblRoom;
        private AtiqsControlLibrary.SmartLabel lblBedType;
        private AtiqsControlLibrary.SmartDataGridView dgvItem;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel lblNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private AtiqsControlLibrary.SmartComboBox cboSalesTypes;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartReadOnlyDateTextBox txtIssueDate;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartTextBox txtReceivedBy;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private System.Windows.Forms.Button btnCloseclk;
        private AtiqsControlLibrary.SmartNumericTextBox txtAmountSummary;
        private AtiqsControlLibrary.SmartNumericTextBox txtQuantity;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartNumericTextBox txtDiscount;
        private AtiqsControlLibrary.SmartNumericTextBox txtvat;
        private AtiqsControlLibrary.SmartNumericTextBox txtURate;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtItemName;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartTextBox txtItemID;
        private AtiqsControlLibrary.SmartListViewDetails lvItemIssue;
        private AtiqsControlLibrary.SmartTextBox txtUnitName;
        private AtiqsControlLibrary.SmartTextBox txtTypeName;
        private AtiqsControlLibrary.SmartTextBox txtModelName;
        private AtiqsControlLibrary.SmartTextBox txtBrandName;
        private AtiqsControlLibrary.SmartTextBox txtCompanyName;
        private AtiqsControlLibrary.SmartTextBox txtGroupName;
        private AtiqsControlLibrary.SmartTextBox txtBrandID;
        private AtiqsControlLibrary.SmartTextBox txtModelID;
        private AtiqsControlLibrary.SmartTextBox txtTypeID;
        private AtiqsControlLibrary.SmartTextBox txtUnitID;
        private AtiqsControlLibrary.SmartTextBox txtGroupID;
        private AtiqsControlLibrary.SmartTextBox txtCompanyID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboStoreLocation;
        private AtiqsControlLibrary.SmartComboBox cboEmpID;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
    }
}
