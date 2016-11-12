namespace AH.ModuleController.UI.APMS.Forms
{
    partial class frmAppointmentRegis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lstTodayDoctorList = new AtiqsControlLibrary.SmartListViewDetails();
            this.lstDoctorName = new AtiqsControlLibrary.SmartListViewDetails();
            this.dptEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeptID = new AtiqsControlLibrary.SmartLabel();
            this.dptStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblDoctorID = new AtiqsControlLibrary.SmartLabel();
            this.lblUnitID = new AtiqsControlLibrary.SmartLabel();
            this.cboDoctorID = new AtiqsControlLibrary.SmartComboBox();
            this.cboUnitID = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartmentID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lblEndDate = new AtiqsControlLibrary.SmartLabel();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDoctorName = new AtiqsControlLibrary.SmartTextBox();
            this.btnDocList = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblService = new AtiqsControlLibrary.SmartLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1317, 6);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(522, 7);
            this.frmLabel.Size = new System.Drawing.Size(317, 33);
            this.frmLabel.Text = "Appointment Registration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(1445, 707);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnShow);
            this.pnlTop.Controls.Add(this.comboBox1);
            this.pnlTop.Controls.Add(this.lblService);
            this.pnlTop.Size = new System.Drawing.Size(1445, 51);
            this.pnlTop.Controls.SetChildIndex(this.lblService, 0);
            this.pnlTop.Controls.SetChildIndex(this.comboBox1, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnShow, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(34, 764);
            this.btnEdit.Size = new System.Drawing.Size(10, 40);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 764);
            this.btnSave.Size = new System.Drawing.Size(10, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 764);
            this.btnDelete.Size = new System.Drawing.Size(10, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 764);
            this.btnNew.Size = new System.Drawing.Size(10, 40);
            this.btnNew.TabIndex = 0;
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1321, 765);
            this.btnClose.Size = new System.Drawing.Size(117, 45);
            this.btnClose.TabIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(66, 764);
            this.btnPrint.Size = new System.Drawing.Size(10, 40);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 810);
            this.groupBox1.Size = new System.Drawing.Size(1445, 30);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel19);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lstTodayDoctorList);
            this.panel1.Controls.Add(this.lstDoctorName);
            this.panel1.Controls.Add(this.dptEndDate);
            this.panel1.Controls.Add(this.lblDeptID);
            this.panel1.Controls.Add(this.dptStartDate);
            this.panel1.Controls.Add(this.btnDisplay);
            this.panel1.Controls.Add(this.lblDoctorID);
            this.panel1.Controls.Add(this.lblUnitID);
            this.panel1.Controls.Add(this.cboDoctorID);
            this.panel1.Controls.Add(this.cboUnitID);
            this.panel1.Controls.Add(this.cboDepartmentID);
            this.panel1.Controls.Add(this.smartLabel1);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.dgvAppointment);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1439, 698);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1285, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 199;
            this.label3.Text = "Prescription Complete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1285, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 198;
            this.label1.Text = "Prescription Billing Complete";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Crimson;
            this.panel19.Location = new System.Drawing.Point(1249, 52);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(30, 20);
            this.panel19.TabIndex = 197;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.GreenYellow;
            this.panel5.Location = new System.Drawing.Point(1249, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 20);
            this.panel5.TabIndex = 196;
            // 
            // lstTodayDoctorList
            // 
            this.lstTodayDoctorList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstTodayDoctorList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTodayDoctorList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstTodayDoctorList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTodayDoctorList.FullRowSelect = true;
            this.lstTodayDoctorList.GridLines = true;
            this.lstTodayDoctorList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstTodayDoctorList.Location = new System.Drawing.Point(386, 89);
            this.lstTodayDoctorList.Name = "lstTodayDoctorList";
            this.lstTodayDoctorList.Size = new System.Drawing.Size(35, 21);
            this.lstTodayDoctorList.TabIndex = 195;
            this.lstTodayDoctorList.UseCompatibleStateImageBehavior = false;
            this.lstTodayDoctorList.View = System.Windows.Forms.View.Details;
            this.lstTodayDoctorList.SelectedIndexChanged += new System.EventHandler(this.lstTodayDoctorList_SelectedIndexChanged);
            // 
            // lstDoctorName
            // 
            this.lstDoctorName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDoctorName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstDoctorName.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDoctorName.FullRowSelect = true;
            this.lstDoctorName.GridLines = true;
            this.lstDoctorName.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDoctorName.Location = new System.Drawing.Point(1252, 79);
            this.lstDoctorName.Name = "lstDoctorName";
            this.lstDoctorName.Size = new System.Drawing.Size(27, 27);
            this.lstDoctorName.TabIndex = 10;
            this.lstDoctorName.UseCompatibleStateImageBehavior = false;
            this.lstDoctorName.View = System.Windows.Forms.View.Details;
            this.lstDoctorName.SelectedIndexChanged += new System.EventHandler(this.lstDoctorName_SelectedIndexChanged);
            // 
            // dptEndDate
            // 
            this.dptEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptEndDate.Location = new System.Drawing.Point(698, 68);
            this.dptEndDate.Name = "dptEndDate";
            this.dptEndDate.Size = new System.Drawing.Size(155, 26);
            this.dptEndDate.TabIndex = 2;
            this.dptEndDate.ValueChanged += new System.EventHandler(this.dptEndDate_ValueChanged);
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDeptID.Location = new System.Drawing.Point(424, 3);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(80, 13);
            this.lblDeptID.TabIndex = 0;
            this.lblDeptID.Text = "Department  ";
            // 
            // dptStartDate
            // 
            this.dptStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptStartDate.Location = new System.Drawing.Point(455, 68);
            this.dptStartDate.Name = "dptStartDate";
            this.dptStartDate.Size = new System.Drawing.Size(165, 26);
            this.dptStartDate.TabIndex = 1;
            this.dptStartDate.ValueChanged += new System.EventHandler(this.dptStartDate_ValueChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(859, 64);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(340, 30);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDoctorID.Location = new System.Drawing.Point(875, 3);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(49, 13);
            this.lblDoctorID.TabIndex = 0;
            this.lblDoctorID.Text = "Doctor ";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnitID.Location = new System.Drawing.Point(702, 3);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(38, 13);
            this.lblUnitID.TabIndex = 0;
            this.lblUnitID.Text = "Unit  ";
            // 
            // cboDoctorID
            // 
            this.cboDoctorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctorID.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctorID.FormattingEnabled = true;
            this.cboDoctorID.Location = new System.Drawing.Point(856, 21);
            this.cboDoctorID.Name = "cboDoctorID";
            this.cboDoctorID.Size = new System.Drawing.Size(346, 26);
            this.cboDoctorID.TabIndex = 5;
            this.cboDoctorID.SelectedIndexChanged += new System.EventHandler(this.cboDoctorID_SelectedIndexChanged);
            // 
            // cboUnitID
            // 
            this.cboUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnitID.ForeColor = System.Drawing.Color.Blue;
            this.cboUnitID.FormattingEnabled = true;
            this.cboUnitID.Location = new System.Drawing.Point(623, 21);
            this.cboUnitID.Name = "cboUnitID";
            this.cboUnitID.Size = new System.Drawing.Size(230, 26);
            this.cboUnitID.TabIndex = 4;
            this.cboUnitID.SelectedIndexChanged += new System.EventHandler(this.cboUnitID_SelectedIndexChanged);
            // 
            // cboDepartmentID
            // 
            this.cboDepartmentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentID.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentID.FormattingEnabled = true;
            this.cboDepartmentID.Items.AddRange(new object[] {
            "select"});
            this.cboDepartmentID.Location = new System.Drawing.Point(386, 21);
            this.cboDepartmentID.Name = "cboDepartmentID";
            this.cboDepartmentID.Size = new System.Drawing.Size(234, 26);
            this.cboDepartmentID.TabIndex = 3;
            this.cboDepartmentID.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentID_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(386, 73);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(65, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(628, 76);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(64, 13);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date ";
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.AllowUserToResizeColumns = false;
            this.dgvAppointment.AllowUserToResizeRows = false;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvAppointment.Location = new System.Drawing.Point(2, 112);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowHeadersVisible = false;
            this.dgvAppointment.RowHeadersWidth = 115;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(1434, 582);
            this.dgvAppointment.TabIndex = 7;
            this.dgvAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellClick);
            this.dgvAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellContentClick);
            this.dgvAppointment.Click += new System.EventHandler(this.dgvAppointment_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.txtDoctorName);
            this.groupBox2.Controls.Add(this.btnDocList);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 110);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find A Doctor";
            this.groupBox2.MouseHover += new System.EventHandler(this.groupBox2_MouseHover);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(129, 20);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(242, 24);
            this.txtDoctorName.TabIndex = 7;
            this.txtDoctorName.TextChanged += new System.EventHandler(this.txtDoctorName_TextChanged);
            this.txtDoctorName.Enter += new System.EventHandler(this.txtDoctorName_Enter);
            this.txtDoctorName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDoctorName_KeyUp);
            // 
            // btnDocList
            // 
            this.btnDocList.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDocList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocList.ForeColor = System.Drawing.Color.White;
            this.btnDocList.Location = new System.Drawing.Point(128, 54);
            this.btnDocList.Name = "btnDocList";
            this.btnDocList.Size = new System.Drawing.Size(242, 40);
            this.btnDocList.TabIndex = 194;
            this.btnDocList.Text = "Today\'s Doctor List";
            this.btnDocList.UseVisualStyleBackColor = false;
            this.btnDocList.Click += new System.EventHandler(this.btnDocList_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.smartLabel2.Location = new System.Drawing.Point(37, 26);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(81, 13);
            this.smartLabel2.TabIndex = 6;
            this.smartLabel2.Text = "Doctor Name";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(13, 6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(73, 20);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Date";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Visible = false;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblService.Location = new System.Drawing.Point(135, 3);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(50, 13);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service";
            this.lblService.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            // 
            // frmAppointmentRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1445, 840);
            this.isEnterTabAllow = true;
            this.Name = "frmAppointmentRegis";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dptEndDate;
        private System.Windows.Forms.DateTimePicker dptStartDate;
        private System.Windows.Forms.Button btnDisplay;
        private AtiqsControlLibrary.SmartLabel lblDoctorID;
        private AtiqsControlLibrary.SmartLabel lblUnitID;
        private AtiqsControlLibrary.SmartLabel lblDeptID;
        private AtiqsControlLibrary.SmartComboBox cboDoctorID;
        private AtiqsControlLibrary.SmartComboBox cboUnitID;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel lblEndDate;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartTextBox txtDoctorName;
        private AtiqsControlLibrary.SmartListViewDetails lstDoctorName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDocList;
        private AtiqsControlLibrary.SmartListViewDetails lstTodayDoctorList;
        private System.Windows.Forms.ComboBox comboBox1;
        private AtiqsControlLibrary.SmartLabel lblService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;


    }
}
