namespace AH.ModuleController.UI.DIET.Forms
{
    partial class frmPatientListDietAssignDetails
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblClon = new AtiqsControlLibrary.SmartLabel();
            this.lblBill = new AtiqsControlLibrary.SmartLabel();
            this.txtBill = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboMealType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboDietType = new AtiqsControlLibrary.SmartComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboReceivingNurseStation = new AtiqsControlLibrary.SmartComboBox();
            this.dgvPatientList = new AtiqsControlLibrary.SmartDataGridView();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboFoodId = new AtiqsControlLibrary.SmartComboBox();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.txtDeitID = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1128, 12);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(493, 9);
            this.frmLabel.Size = new System.Drawing.Size(398, 33);
            this.frmLabel.Text = "Order Diet For Admitted Patient ";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(1298, 606);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnAssign);
            this.pnlTop.Controls.Add(this.lblClon);
            this.pnlTop.Controls.Add(this.txtDeitID);
            this.pnlTop.Controls.Add(this.lblBill);
            this.pnlTop.Controls.Add(this.txtAdmissionID);
            this.pnlTop.Controls.Add(this.txtBill);
            this.pnlTop.Controls.Add(this.smartLabel10);
            this.pnlTop.Controls.Add(this.cboFoodId);
            this.pnlTop.Controls.Add(this.smartLabel9);
            this.pnlTop.Controls.Add(this.smartLabel3);
            this.pnlTop.Controls.Add(this.dtpDate);
            this.pnlTop.Controls.Add(this.smartLabel7);
            this.pnlTop.Size = new System.Drawing.Size(1298, 58);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel7, 0);
            this.pnlTop.Controls.SetChildIndex(this.dtpDate, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel3, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel9, 0);
            this.pnlTop.Controls.SetChildIndex(this.cboFoodId, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel10, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtBill, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAdmissionID, 0);
            this.pnlTop.Controls.SetChildIndex(this.lblBill, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtDeitID, 0);
            this.pnlTop.Controls.SetChildIndex(this.lblClon, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnAssign, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(110, 673);
            this.btnEdit.Size = new System.Drawing.Size(19, 27);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1064, 668);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 673);
            this.btnDelete.Size = new System.Drawing.Size(21, 27);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(951, 668);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1178, 668);
            this.btnClose.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(77, 673);
            this.btnPrint.Size = new System.Drawing.Size(27, 27);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 709);
            this.groupBox1.Size = new System.Drawing.Size(1298, 25);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox4.Controls.Add(this.smartLabel8);
            this.groupBox4.Controls.Add(this.smartLabel6);
            this.groupBox4.Controls.Add(this.smartLabel5);
            this.groupBox4.Controls.Add(this.smartLabel2);
            this.groupBox4.Controls.Add(this.cboMealType);
            this.groupBox4.Controls.Add(this.smartLabel1);
            this.groupBox4.Controls.Add(this.cboDietType);
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Controls.Add(this.smartLabel4);
            this.groupBox4.Controls.Add(this.cboReceivingNurseStation);
            this.groupBox4.Controls.Add(this.dgvPatientList);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1290, 601);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Red;
            this.btnAssign.Location = new System.Drawing.Point(431, 9);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(29, 26);
            this.btnAssign.TabIndex = 175;
            this.btnAssign.Text = "+";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Visible = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblClon
            // 
            this.lblClon.AutoSize = true;
            this.lblClon.BackColor = System.Drawing.Color.Honeydew;
            this.lblClon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblClon.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblClon.Location = new System.Drawing.Point(372, 9);
            this.lblClon.Name = "lblClon";
            this.lblClon.Size = new System.Drawing.Size(11, 15);
            this.lblClon.TabIndex = 174;
            this.lblClon.Text = ":";
            this.lblClon.Visible = false;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.Color.Honeydew;
            this.lblBill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBill.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBill.Location = new System.Drawing.Point(333, 9);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(28, 15);
            this.lblBill.TabIndex = 173;
            this.lblBill.Text = "Bill";
            this.lblBill.Visible = false;
            // 
            // txtBill
            // 
            this.txtBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(391, 9);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(34, 24);
            this.txtBill.TabIndex = 172;
            this.txtBill.Visible = false;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel8.Location = new System.Drawing.Point(459, 29);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(11, 15);
            this.smartLabel8.TabIndex = 168;
            this.smartLabel8.Text = ":";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel6.Location = new System.Drawing.Point(1086, 29);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(11, 15);
            this.smartLabel6.TabIndex = 166;
            this.smartLabel6.Text = ":";
            this.smartLabel6.Visible = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel5.Location = new System.Drawing.Point(103, 31);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(11, 15);
            this.smartLabel5.TabIndex = 165;
            this.smartLabel5.Text = ":";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(394, 29);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(62, 15);
            this.smartLabel2.TabIndex = 162;
            this.smartLabel2.Text = "Meal Type";
            // 
            // cboMealType
            // 
            this.cboMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMealType.ForeColor = System.Drawing.Color.Blue;
            this.cboMealType.FormattingEnabled = true;
            this.cboMealType.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboMealType.Location = new System.Drawing.Point(470, 25);
            this.cboMealType.Name = "cboMealType";
            this.cboMealType.Size = new System.Drawing.Size(261, 26);
            this.cboMealType.TabIndex = 161;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(1017, 30);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(58, 15);
            this.smartLabel1.TabIndex = 160;
            this.smartLabel1.Text = "Diet Type";
            this.smartLabel1.Visible = false;
            // 
            // cboDietType
            // 
            this.cboDietType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDietType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDietType.ForeColor = System.Drawing.Color.Blue;
            this.cboDietType.FormattingEnabled = true;
            this.cboDietType.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboDietType.Location = new System.Drawing.Point(1106, 26);
            this.cboDietType.Name = "cboDietType";
            this.cboDietType.Size = new System.Drawing.Size(28, 26);
            this.cboDietType.TabIndex = 159;
            this.cboDietType.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.YellowGreen;
            this.btnShow.Location = new System.Drawing.Point(737, 22);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(268, 30);
            this.btnShow.TabIndex = 158;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel4.Location = new System.Drawing.Point(16, 31);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(83, 15);
            this.smartLabel4.TabIndex = 157;
            this.smartLabel4.Text = "Nurse Station";
            // 
            // cboReceivingNurseStation
            // 
            this.cboReceivingNurseStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReceivingNurseStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReceivingNurseStation.ForeColor = System.Drawing.Color.Blue;
            this.cboReceivingNurseStation.FormattingEnabled = true;
            this.cboReceivingNurseStation.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboReceivingNurseStation.Location = new System.Drawing.Point(120, 25);
            this.cboReceivingNurseStation.Name = "cboReceivingNurseStation";
            this.cboReceivingNurseStation.Size = new System.Drawing.Size(268, 26);
            this.cboReceivingNurseStation.TabIndex = 156;
            this.cboReceivingNurseStation.SelectedIndexChanged += new System.EventHandler(this.cboReceivingNurseStation_SelectedIndexChanged);
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.AllowUserToAddRows = false;
            this.dgvPatientList.AllowUserToDeleteRows = false;
            this.dgvPatientList.AllowUserToOrderColumns = true;
            this.dgvPatientList.AllowUserToResizeColumns = false;
            this.dgvPatientList.AllowUserToResizeRows = false;
            this.dgvPatientList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPatientList.Location = new System.Drawing.Point(0, 74);
            this.dgvPatientList.MultiSelect = false;
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvPatientList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientList.Size = new System.Drawing.Size(1290, 527);
            this.dgvPatientList.TabIndex = 6;
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel10.Location = new System.Drawing.Point(61, 9);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(11, 15);
            this.smartLabel10.TabIndex = 171;
            this.smartLabel10.Text = ":";
            this.smartLabel10.Visible = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(30, 9);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(32, 15);
            this.smartLabel9.TabIndex = 170;
            this.smartLabel9.Text = "Date";
            this.smartLabel9.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(77, 7);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDate.TabIndex = 169;
            this.dtpDate.Visible = false;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel7.Location = new System.Drawing.Point(277, 9);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(11, 15);
            this.smartLabel7.TabIndex = 167;
            this.smartLabel7.Text = ":";
            this.smartLabel7.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Honeydew;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(239, 9);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(32, 15);
            this.smartLabel3.TabIndex = 164;
            this.smartLabel3.Text = "Food";
            this.smartLabel3.Visible = false;
            // 
            // cboFoodId
            // 
            this.cboFoodId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFoodId.ForeColor = System.Drawing.Color.Blue;
            this.cboFoodId.FormattingEnabled = true;
            this.cboFoodId.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboFoodId.Location = new System.Drawing.Point(294, 7);
            this.cboFoodId.Name = "cboFoodId";
            this.cboFoodId.Size = new System.Drawing.Size(31, 26);
            this.cboFoodId.TabIndex = 163;
            this.cboFoodId.Visible = false;
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Location = new System.Drawing.Point(916, 9);
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.Size = new System.Drawing.Size(100, 20);
            this.txtAdmissionID.TabIndex = 161;
            this.txtAdmissionID.Visible = false;
            // 
            // txtDeitID
            // 
            this.txtDeitID.Location = new System.Drawing.Point(1022, 7);
            this.txtDeitID.Name = "txtDeitID";
            this.txtDeitID.Size = new System.Drawing.Size(100, 20);
            this.txtDeitID.TabIndex = 162;
            this.txtDeitID.Visible = false;
            // 
            // frmPatientListDietAssignDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1298, 734);
            this.isEnterTabAllow = true;
            this.Name = "frmPatientListDietAssignDetails";
            this.Load += new System.EventHandler(this.frmPatientList_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private AtiqsControlLibrary.SmartDataGridView dgvPatientList;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboReceivingNurseStation;
        private System.Windows.Forms.Button btnShow;
        public System.Windows.Forms.TextBox txtAdmissionID;
        public System.Windows.Forms.TextBox txtDeitID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboFoodId;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboMealType;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDietType;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private AtiqsControlLibrary.SmartLabel lblClon;
        private AtiqsControlLibrary.SmartLabel lblBill;
        private AtiqsControlLibrary.SmartNumericTextBox txtBill;
        private System.Windows.Forms.Button btnAssign;

    }
}
