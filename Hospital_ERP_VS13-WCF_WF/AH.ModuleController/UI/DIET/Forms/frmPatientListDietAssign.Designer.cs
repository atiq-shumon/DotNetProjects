namespace AH.ModuleController.UI.DIET.Forms
{
    partial class frmPatientListDietAssign
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
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboReceivingNurseStation = new AtiqsControlLibrary.SmartComboBox();
            this.dgvDietList = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvPatientList = new AtiqsControlLibrary.SmartDataGridView();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.txtDeitID = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1128, 12);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(393, 9);
            this.frmLabel.Size = new System.Drawing.Size(406, 33);
            this.frmLabel.Text = "Assign Diet For Admitted Patient ";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvDietList);
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Controls.Add(this.dgvPatientList);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(1260, 606);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtDeitID);
            this.pnlTop.Controls.Add(this.txtAdmissionID);
            this.pnlTop.Size = new System.Drawing.Size(1260, 58);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAdmissionID, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtDeitID, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(110, 673);
            this.btnEdit.Size = new System.Drawing.Size(19, 27);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 681);
            this.btnSave.Size = new System.Drawing.Size(33, 17);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 673);
            this.btnDelete.Size = new System.Drawing.Size(21, 27);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1026, 670);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1140, 670);
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
            this.groupBox1.Size = new System.Drawing.Size(1260, 25);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Controls.Add(this.smartLabel4);
            this.groupBox4.Controls.Add(this.cboReceivingNurseStation);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1256, 104);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.MouseHover += new System.EventHandler(this.groupBox4_MouseHover);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnShow.Location = new System.Drawing.Point(540, 40);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(238, 30);
            this.btnShow.TabIndex = 158;
            this.btnShow.Text = "Click Patient List to Add Diet";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(42, 46);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(120, 15);
            this.smartLabel4.TabIndex = 157;
            this.smartLabel4.Text = "Select Nurse Station";
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
            this.cboReceivingNurseStation.Location = new System.Drawing.Point(168, 43);
            this.cboReceivingNurseStation.Name = "cboReceivingNurseStation";
            this.cboReceivingNurseStation.Size = new System.Drawing.Size(356, 26);
            this.cboReceivingNurseStation.TabIndex = 156;
            // 
            // dgvDietList
            // 
            this.dgvDietList.AllowUserToAddRows = false;
            this.dgvDietList.AllowUserToDeleteRows = false;
            this.dgvDietList.AllowUserToOrderColumns = true;
            this.dgvDietList.AllowUserToResizeColumns = false;
            this.dgvDietList.AllowUserToResizeRows = false;
            this.dgvDietList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDietList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDietList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDietList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDietList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDietList.Location = new System.Drawing.Point(865, 75);
            this.dgvDietList.MultiSelect = false;
            this.dgvDietList.Name = "dgvDietList";
            this.dgvDietList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvDietList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDietList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDietList.Size = new System.Drawing.Size(272, 395);
            this.dgvDietList.TabIndex = 159;
            this.dgvDietList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDietList_CellMouseDoubleClick);
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
            this.dgvPatientList.Location = new System.Drawing.Point(2, 106);
            this.dgvPatientList.MultiSelect = false;
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvPatientList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientList.Size = new System.Drawing.Size(1253, 497);
            this.dgvPatientList.TabIndex = 6;
            this.dgvPatientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientList_CellClick);
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
            // frmPatientListDietAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1260, 734);
            this.isEnterTabAllow = true;
            this.Name = "frmPatientListDietAssign";
            this.Load += new System.EventHandler(this.frmPatientList_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietList)).EndInit();
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
        private AtiqsControlLibrary.SmartDataGridView dgvDietList;

    }
}
