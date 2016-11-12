namespace AH.ModuleController.UI.DIET.Forms
{
    partial class frmTotalOrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvTotalDietList = new AtiqsControlLibrary.SmartDataGridView();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboReceivingNurseStation = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.dgvPatientList = new AtiqsControlLibrary.SmartDataGridView();
            this.cboMealType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboDietType = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalDietList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1128, 12);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(159, 11);
            this.frmLabel.Size = new System.Drawing.Size(199, 33);
            this.frmLabel.Text = "Total Order List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(538, 606);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.smartLabel6);
            this.pnlTop.Controls.Add(this.smartLabel1);
            this.pnlTop.Controls.Add(this.cboDietType);
            this.pnlTop.Size = new System.Drawing.Size(538, 58);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.cboDietType, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel1, 0);
            this.pnlTop.Controls.SetChildIndex(this.smartLabel6, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(39, 686);
            this.btnEdit.Size = new System.Drawing.Size(18, 21);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 678);
            this.btnSave.Size = new System.Drawing.Size(20, 16);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(4, 696);
            this.btnDelete.Size = new System.Drawing.Size(21, 10);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(305, 670);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(419, 670);
            this.btnClose.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(38, 673);
            this.btnPrint.Size = new System.Drawing.Size(19, 15);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 709);
            this.groupBox1.Size = new System.Drawing.Size(538, 25);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.dgvTotalDietList);
            this.groupBox4.Controls.Add(this.smartLabel3);
            this.groupBox4.Controls.Add(this.smartLabel7);
            this.groupBox4.Controls.Add(this.dtpDate);
            this.groupBox4.Controls.Add(this.cboReceivingNurseStation);
            this.groupBox4.Controls.Add(this.smartLabel5);
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Controls.Add(this.smartLabel4);
            this.groupBox4.Controls.Add(this.smartLabel2);
            this.groupBox4.Controls.Add(this.dgvPatientList);
            this.groupBox4.Controls.Add(this.cboMealType);
            this.groupBox4.Controls.Add(this.smartLabel8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(535, 601);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // dgvTotalDietList
            // 
            this.dgvTotalDietList.AllowUserToAddRows = false;
            this.dgvTotalDietList.AllowUserToDeleteRows = false;
            this.dgvTotalDietList.AllowUserToOrderColumns = true;
            this.dgvTotalDietList.AllowUserToResizeColumns = false;
            this.dgvTotalDietList.AllowUserToResizeRows = false;
            this.dgvTotalDietList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTotalDietList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTotalDietList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTotalDietList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotalDietList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotalDietList.Location = new System.Drawing.Point(1, 186);
            this.dgvTotalDietList.MultiSelect = false;
            this.dgvTotalDietList.Name = "dgvTotalDietList";
            this.dgvTotalDietList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvTotalDietList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTotalDietList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTotalDietList.Size = new System.Drawing.Size(530, 413);
            this.dgvTotalDietList.TabIndex = 175;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Lavender;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel3.Location = new System.Drawing.Point(146, 26);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(11, 15);
            this.smartLabel3.TabIndex = 174;
            this.smartLabel3.Text = ":";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Lavender;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(114, 26);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(32, 15);
            this.smartLabel7.TabIndex = 173;
            this.smartLabel7.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(161, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(261, 26);
            this.dtpDate.TabIndex = 172;
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
            this.cboReceivingNurseStation.Location = new System.Drawing.Point(35, 148);
            this.cboReceivingNurseStation.Name = "cboReceivingNurseStation";
            this.cboReceivingNurseStation.Size = new System.Drawing.Size(62, 26);
            this.cboReceivingNurseStation.TabIndex = 156;
            this.cboReceivingNurseStation.Visible = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Lavender;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel5.Location = new System.Drawing.Point(113, 126);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(11, 15);
            this.smartLabel5.TabIndex = 165;
            this.smartLabel5.Text = ":";
            this.smartLabel5.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Plum;
            this.btnShow.Location = new System.Drawing.Point(161, 111);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(261, 30);
            this.btnShow.TabIndex = 158;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Lavender;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel4.Location = new System.Drawing.Point(12, 126);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(83, 15);
            this.smartLabel4.TabIndex = 157;
            this.smartLabel4.Text = "Nurse Station";
            this.smartLabel4.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Lavender;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(84, 64);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(62, 15);
            this.smartLabel2.TabIndex = 162;
            this.smartLabel2.Text = "Meal Type";
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
            this.dgvPatientList.Location = new System.Drawing.Point(415, 148);
            this.dgvPatientList.MultiSelect = false;
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvPatientList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientList.Size = new System.Drawing.Size(98, 32);
            this.dgvPatientList.StandardTab = true;
            this.dgvPatientList.TabIndex = 6;
            this.dgvPatientList.Visible = false;
            this.dgvPatientList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPatientList_CellFormatting);
            this.dgvPatientList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPatientList_CellPainting);
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
            this.cboMealType.Location = new System.Drawing.Point(161, 61);
            this.cboMealType.Name = "cboMealType";
            this.cboMealType.Size = new System.Drawing.Size(261, 26);
            this.cboMealType.TabIndex = 161;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Lavender;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel8.Location = new System.Drawing.Point(146, 64);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(11, 15);
            this.smartLabel8.TabIndex = 168;
            this.smartLabel8.Text = ":";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Lavender;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel6.Location = new System.Drawing.Point(65, 21);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(11, 15);
            this.smartLabel6.TabIndex = 171;
            this.smartLabel6.Text = ":";
            this.smartLabel6.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Lavender;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(3, 22);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(58, 15);
            this.smartLabel1.TabIndex = 170;
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
            this.cboDietType.Location = new System.Drawing.Point(81, 18);
            this.cboDietType.Name = "cboDietType";
            this.cboDietType.Size = new System.Drawing.Size(10, 26);
            this.cboDietType.TabIndex = 169;
            this.cboDietType.Visible = false;
            // 
            // frmTotalOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(538, 734);
            this.isEnterTabAllow = true;
            this.Name = "frmTotalOrderList";
            this.Load += new System.EventHandler(this.frmPatientList_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalDietList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private AtiqsControlLibrary.SmartDataGridView dgvPatientList;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboMealType;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDietType;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private AtiqsControlLibrary.SmartDataGridView dgvTotalDietList;
        private AtiqsControlLibrary.SmartComboBox cboReceivingNurseStation;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;

    }
}
