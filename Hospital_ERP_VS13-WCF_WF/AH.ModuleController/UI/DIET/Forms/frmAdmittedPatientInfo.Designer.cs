namespace AH.ModuleController.UI.DIET.Forms
{
    partial class frmAdmittedPatientInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPatList = new AtiqsControlLibrary.SmartDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoATD = new System.Windows.Forms.RadioButton();
            this.rdoCensus = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.rdoDischargeDate = new System.Windows.Forms.RadioButton();
            this.rdoTransferDate = new System.Windows.Forms.RadioButton();
            this.rdoAdmissionDate = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtSearchItem = new AtiqsControlLibrary.SmartTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDietList = new AtiqsControlLibrary.SmartDataGridView();
            this.txtDeitID = new System.Windows.Forms.TextBox();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.txtNSID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatList)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietList)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(547, 9);
            this.frmLabel.Size = new System.Drawing.Size(361, 33);
            this.frmLabel.Text = "Admitted Patient Information";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.dgvDietList);
            this.pnlMain.Controls.Add(this.lblText);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.txtSearchItem);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.dgvPatList);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Location = new System.Drawing.Point(1, 54);
            this.pnlMain.Size = new System.Drawing.Size(1426, 657);
            this.pnlMain.MouseHover += new System.EventHandler(this.pnlMain_MouseHover);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtNSID);
            this.pnlTop.Controls.Add(this.txtDeitID);
            this.pnlTop.Controls.Add(this.txtAdmissionID);
            this.pnlTop.Size = new System.Drawing.Size(1427, 58);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtAdmissionID, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtDeitID, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtNSID, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(77, 717);
            this.btnEdit.Size = new System.Drawing.Size(30, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 728);
            this.btnSave.Size = new System.Drawing.Size(28, 17);
            this.btnSave.TabIndex = 0;
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(57, 717);
            this.btnDelete.Size = new System.Drawing.Size(14, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(150, 728);
            this.btnNew.Size = new System.Drawing.Size(31, 21);
            this.btnNew.TabIndex = 2;
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1307, 717);
            this.btnClose.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(28, 717);
            this.btnPrint.Size = new System.Drawing.Size(23, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 758);
            this.groupBox1.Size = new System.Drawing.Size(1427, 25);
            // 
            // dgvPatList
            // 
            this.dgvPatList.AllowUserToAddRows = false;
            this.dgvPatList.AllowUserToDeleteRows = false;
            this.dgvPatList.AllowUserToOrderColumns = true;
            this.dgvPatList.AllowUserToResizeColumns = false;
            this.dgvPatList.AllowUserToResizeRows = false;
            this.dgvPatList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPatList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPatList.Location = new System.Drawing.Point(-1, 94);
            this.dgvPatList.MultiSelect = false;
            this.dgvPatList.Name = "dgvPatList";
            this.dgvPatList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvPatList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatList.Size = new System.Drawing.Size(1422, 519);
            this.dgvPatList.TabIndex = 0;
            this.dgvPatList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatList_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdoATD);
            this.panel2.Controls.Add(this.rdoCensus);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 40);
            this.panel2.TabIndex = 1;
            // 
            // rdoATD
            // 
            this.rdoATD.AutoSize = true;
            this.rdoATD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoATD.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdoATD.Location = new System.Drawing.Point(183, 10);
            this.rdoATD.Name = "rdoATD";
            this.rdoATD.Size = new System.Drawing.Size(92, 17);
            this.rdoATD.TabIndex = 4;
            this.rdoATD.TabStop = true;
            this.rdoATD.Text = "ATD Report";
            this.rdoATD.UseVisualStyleBackColor = true;
            this.rdoATD.CheckedChanged += new System.EventHandler(this.rdoATD_CheckedChanged);
            // 
            // rdoCensus
            // 
            this.rdoCensus.AutoSize = true;
            this.rdoCensus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCensus.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdoCensus.Location = new System.Drawing.Point(3, 10);
            this.rdoCensus.Name = "rdoCensus";
            this.rdoCensus.Size = new System.Drawing.Size(160, 17);
            this.rdoCensus.TabIndex = 3;
            this.rdoCensus.TabStop = true;
            this.rdoCensus.Text = "All Admitted Patient List";
            this.rdoCensus.UseVisualStyleBackColor = true;
            this.rdoCensus.CheckedChanged += new System.EventHandler(this.rdoCensus_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(814, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(522, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "From ";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = " dd/MM/ yyyy hh: mm: ss";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(842, 15);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 21);
            this.dtpToDate.TabIndex = 15;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd /MM /yyyy hh: mm :ss";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(586, 15);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 21);
            this.dtpFromDate.TabIndex = 14;
            // 
            // rdoDischargeDate
            // 
            this.rdoDischargeDate.AutoSize = true;
            this.rdoDischargeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDischargeDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.rdoDischargeDate.Location = new System.Drawing.Point(355, 15);
            this.rdoDischargeDate.Name = "rdoDischargeDate";
            this.rdoDischargeDate.Size = new System.Drawing.Size(113, 17);
            this.rdoDischargeDate.TabIndex = 13;
            this.rdoDischargeDate.TabStop = true;
            this.rdoDischargeDate.Text = "Discharge Date";
            this.rdoDischargeDate.UseVisualStyleBackColor = true;
            this.rdoDischargeDate.CheckedChanged += new System.EventHandler(this.rdoDischargeDate_CheckedChanged);
            // 
            // rdoTransferDate
            // 
            this.rdoTransferDate.AutoSize = true;
            this.rdoTransferDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTransferDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.rdoTransferDate.Location = new System.Drawing.Point(226, 15);
            this.rdoTransferDate.Name = "rdoTransferDate";
            this.rdoTransferDate.Size = new System.Drawing.Size(103, 17);
            this.rdoTransferDate.TabIndex = 12;
            this.rdoTransferDate.TabStop = true;
            this.rdoTransferDate.Text = "Transfer Date";
            this.rdoTransferDate.UseVisualStyleBackColor = true;
            this.rdoTransferDate.CheckedChanged += new System.EventHandler(this.rdoTransferDate_CheckedChanged);
            // 
            // rdoAdmissionDate
            // 
            this.rdoAdmissionDate.AutoSize = true;
            this.rdoAdmissionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdmissionDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.rdoAdmissionDate.Location = new System.Drawing.Point(82, 15);
            this.rdoAdmissionDate.Name = "rdoAdmissionDate";
            this.rdoAdmissionDate.Size = new System.Drawing.Size(112, 17);
            this.rdoAdmissionDate.TabIndex = 11;
            this.rdoAdmissionDate.TabStop = true;
            this.rdoAdmissionDate.Text = "Admission Date";
            this.rdoAdmissionDate.UseVisualStyleBackColor = true;
            this.rdoAdmissionDate.CheckedChanged += new System.EventHandler(this.rdoAdmissionDate_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.rdoTransferDate);
            this.groupBox2.Controls.Add(this.rdoAdmissionDate);
            this.groupBox2.Controls.Add(this.rdoDischargeDate);
            this.groupBox2.Controls.Add(this.dtpToDate);
            this.groupBox2.Controls.Add(this.dtpFromDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Location = new System.Drawing.Point(325, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1096, 46);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criteria";
            this.groupBox2.MouseHover += new System.EventHandler(this.groupBox2_MouseHover);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightCoral;
            this.btnRefresh.Location = new System.Drawing.Point(497, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(138, 26);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblText.Location = new System.Drawing.Point(548, 629);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(38, 16);
            this.lblText.TabIndex = 15;
            this.lblText.Text = "Text";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel1.Location = new System.Drawing.Point(376, 18);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(179, 13);
            this.smartLabel1.TabIndex = 19;
            this.smartLabel1.Text = "Search On HCN/Admission No";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(561, 12);
            this.txtSearchItem.MaxLength = 11;
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(232, 24);
            this.txtSearchItem.TabIndex = 20;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            this.txtSearchItem.Leave += new System.EventHandler(this.txtSearchItem_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Location = new System.Drawing.Point(11, 622);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 23);
            this.panel3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "New Patient";
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
            this.dgvDietList.Location = new System.Drawing.Point(681, 101);
            this.dgvDietList.MultiSelect = false;
            this.dgvDietList.Name = "dgvDietList";
            this.dgvDietList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvDietList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDietList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDietList.Size = new System.Drawing.Size(272, 395);
            this.dgvDietList.TabIndex = 160;
            this.dgvDietList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDietList_CellContentClick);
            this.dgvDietList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDietList_CellMouseDoubleClick);
            // 
            // txtDeitID
            // 
            this.txtDeitID.Location = new System.Drawing.Point(163, 10);
            this.txtDeitID.Name = "txtDeitID";
            this.txtDeitID.Size = new System.Drawing.Size(100, 20);
            this.txtDeitID.TabIndex = 164;
            this.txtDeitID.Visible = false;
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Location = new System.Drawing.Point(57, 12);
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.Size = new System.Drawing.Size(100, 20);
            this.txtAdmissionID.TabIndex = 163;
            this.txtAdmissionID.Visible = false;
            // 
            // txtNSID
            // 
            this.txtNSID.Location = new System.Drawing.Point(269, 9);
            this.txtNSID.Name = "txtNSID";
            this.txtNSID.Size = new System.Drawing.Size(100, 20);
            this.txtNSID.TabIndex = 165;
            this.txtNSID.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Location = new System.Drawing.Point(327, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 35);
            this.panel4.TabIndex = 161;
            // 
            // frmAdmittedPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 783);
            this.isEnterTabAllow = true;
            this.Name = "frmAdmittedPatientInfo";
            this.Load += new System.EventHandler(this.frmAdmittedPatientInfo_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoATD;
        private System.Windows.Forms.RadioButton rdoCensus;
        private AtiqsControlLibrary.SmartDataGridView dgvPatList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoTransferDate;
        private System.Windows.Forms.RadioButton rdoAdmissionDate;
        private System.Windows.Forms.RadioButton rdoDischargeDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblText;
        private AtiqsControlLibrary.SmartTextBox txtSearchItem;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private AtiqsControlLibrary.SmartDataGridView dgvDietList;
        public System.Windows.Forms.TextBox txtDeitID;
        public System.Windows.Forms.TextBox txtAdmissionID;
        public System.Windows.Forms.TextBox txtNSID;
        private System.Windows.Forms.Panel panel4;

    }
}