namespace AH.ModuleController.UI.PRMS.Forms
{
    partial class frmWardSetup
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
            this.txtWardID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtWardNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtWardName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.levDepartment = new AtiqsControlLibrary.SmartLabel();
            this.cboGender = new AtiqsControlLibrary.SmartComboBox();
            this.levAllowGender = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeGroupMin = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtWardNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.txtBlockNo = new AtiqsControlLibrary.SmartTextBox();
            this.cboDept = new AtiqsControlLibrary.SmartComboBox();
            this.cboBuildID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.lvWardSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboSerialPriority = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtTotalBed = new AtiqsControlLibrary.SmartNumericTextBox();
            this.cboFloorNo = new AtiqsControlLibrary.SmartComboBox();
            this.txtNoRoom = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.cboBedType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.chkDepartment = new System.Windows.Forms.CheckBox();
            this.chkGender = new System.Windows.Forms.CheckBox();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.txtAgeGroupMax = new AtiqsControlLibrary.SmartTextBox();
            this.chkAge = new System.Windows.Forms.CheckBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(981, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(482, 8);
            this.frmLabel.Size = new System.Drawing.Size(154, 33);
            this.frmLabel.Text = "Ward Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.chkAge);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.txtAgeGroupMax);
            this.pnlMain.Controls.Add(this.chkGender);
            this.pnlMain.Controls.Add(this.chkDepartment);
            this.pnlMain.Controls.Add(this.cboBedType);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.txtNoRoom);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.cboFloorNo);
            this.pnlMain.Controls.Add(this.txtTotalBed);
            this.pnlMain.Controls.Add(this.cboSerialPriority);
            this.pnlMain.Controls.Add(this.lvWardSetup);
            this.pnlMain.Controls.Add(this.txtWardNo);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.cboDept);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.txtBlockNo);
            this.pnlMain.Controls.Add(this.txtWardNameBang);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.txtAgeGroupMin);
            this.pnlMain.Controls.Add(this.levAllowGender);
            this.pnlMain.Controls.Add(this.cboGender);
            this.pnlMain.Controls.Add(this.levDepartment);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtWardName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtWardID);
            this.pnlMain.Location = new System.Drawing.Point(1, 51);
            this.pnlMain.Size = new System.Drawing.Size(1142, 703);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1144, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(912, 760);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(798, 760);
            this.btnSave.TabIndex = 14;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(41, 760);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(684, 760);
            this.btnNew.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1026, 760);
            this.btnClose.TabIndex = 29;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(155, 760);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 800);
            this.groupBox1.Size = new System.Drawing.Size(1144, 23);
            // 
            // txtWardID
            // 
            this.txtWardID.BackColor = System.Drawing.Color.Linen;
            this.txtWardID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWardID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtWardID.Location = new System.Drawing.Point(7, 37);
            this.txtWardID.Name = "txtWardID";
            this.txtWardID.ReadOnly = true;
            this.txtWardID.Size = new System.Drawing.Size(129, 24);
            this.txtWardID.TabIndex = 0;
            this.txtWardID.TabStop = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(8, 14);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(66, 18);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Ward ID :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(142, 14);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(68, 18);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Ward No :";
            // 
            // txtWardNo
            // 
            this.txtWardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWardNo.Location = new System.Drawing.Point(142, 37);
            this.txtWardNo.Name = "txtWardNo";
            this.txtWardNo.Size = new System.Drawing.Size(188, 24);
            this.txtWardNo.TabIndex = 1;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(333, 14);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(87, 18);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Ward Name :";
            // 
            // txtWardName
            // 
            this.txtWardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWardName.Location = new System.Drawing.Point(336, 37);
            this.txtWardName.Name = "txtWardName";
            this.txtWardName.Size = new System.Drawing.Size(386, 24);
            this.txtWardName.TabIndex = 2;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(140, 767);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(66, 18);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "Building :";
            this.smartLabel5.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(336, 70);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(65, 18);
            this.smartLabel6.TabIndex = 11;
            this.smartLabel6.Text = "Floor No :";
            // 
            // levDepartment
            // 
            this.levDepartment.AutoSize = true;
            this.levDepartment.BackColor = System.Drawing.Color.Transparent;
            this.levDepartment.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.levDepartment.Location = new System.Drawing.Point(336, 125);
            this.levDepartment.Name = "levDepartment";
            this.levDepartment.Size = new System.Drawing.Size(87, 18);
            this.levDepartment.TabIndex = 15;
            this.levDepartment.Text = "Department :";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.ForeColor = System.Drawing.Color.Blue;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(868, 93);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(133, 26);
            this.cboGender.TabIndex = 9;
            // 
            // levAllowGender
            // 
            this.levAllowGender.AutoSize = true;
            this.levAllowGender.BackColor = System.Drawing.Color.Transparent;
            this.levAllowGender.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.levAllowGender.Location = new System.Drawing.Point(869, 70);
            this.levAllowGender.Name = "levAllowGender";
            this.levAllowGender.Size = new System.Drawing.Size(114, 18);
            this.levAllowGender.TabIndex = 17;
            this.levAllowGender.Text = "Allowed Gender :";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(4, 125);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(108, 18);
            this.smartLabel10.TabIndex = 19;
            this.smartLabel10.Text = "Age Group Min :";
            this.smartLabel10.Click += new System.EventHandler(this.smartLabel10_Click);
            // 
            // txtAgeGroupMin
            // 
            this.txtAgeGroupMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeGroupMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeGroupMin.Location = new System.Drawing.Point(7, 149);
            this.txtAgeGroupMin.Name = "txtAgeGroupMin";
            this.txtAgeGroupMin.Size = new System.Drawing.Size(105, 24);
            this.txtAgeGroupMin.TabIndex = 10;
            this.txtAgeGroupMin.TextChanged += new System.EventHandler(this.txtAgeGroup_TextChanged);
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(729, 125);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(68, 18);
            this.smartLabel12.TabIndex = 23;
            this.smartLabel12.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(728, 149);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(401, 26);
            this.txtRemarks.TabIndex = 14;
            // 
            // txtWardNameBang
            // 
            this.txtWardNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWardNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWardNameBang.Location = new System.Drawing.Point(728, 37);
            this.txtWardNameBang.Name = "txtWardNameBang";
            this.txtWardNameBang.Size = new System.Drawing.Size(401, 24);
            this.txtWardNameBang.TabIndex = 3;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(481, 70);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(69, 18);
            this.smartLabel11.TabIndex = 28;
            this.smartLabel11.Text = "Block No :";
            // 
            // txtBlockNo
            // 
            this.txtBlockNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBlockNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlockNo.Location = new System.Drawing.Point(481, 93);
            this.txtBlockNo.Name = "txtBlockNo";
            this.txtBlockNo.Size = new System.Drawing.Size(139, 24);
            this.txtBlockNo.TabIndex = 6;
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDept.ForeColor = System.Drawing.Color.Blue;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(339, 149);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(383, 26);
            this.cboDept.TabIndex = 13;
            // 
            // cboBuildID
            // 
            this.cboBuildID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuildID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuildID.ForeColor = System.Drawing.Color.Blue;
            this.cboBuildID.FormattingEnabled = true;
            this.cboBuildID.Location = new System.Drawing.Point(60, 763);
            this.cboBuildID.Name = "cboBuildID";
            this.cboBuildID.Size = new System.Drawing.Size(74, 26);
            this.cboBuildID.TabIndex = 4;
            this.cboBuildID.Visible = false;
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel14.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(227, 125);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(96, 18);
            this.smartLabel14.TabIndex = 32;
            this.smartLabel14.Text = "Serial Priority :";
            // 
            // lvWardSetup
            // 
            this.lvWardSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvWardSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvWardSetup.CheckBoxes = true;
            this.lvWardSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvWardSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvWardSetup.FullRowSelect = true;
            this.lvWardSetup.GridLines = true;
            this.lvWardSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvWardSetup.Location = new System.Drawing.Point(-1, 215);
            this.lvWardSetup.Name = "lvWardSetup";
            this.lvWardSetup.Size = new System.Drawing.Size(1138, 487);
            this.lvWardSetup.TabIndex = 118;
            this.lvWardSetup.TabStop = false;
            this.lvWardSetup.UseCompatibleStateImageBehavior = false;
            this.lvWardSetup.View = System.Windows.Forms.View.Details;
            this.lvWardSetup.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvWardSetup_ItemCheck);
            this.lvWardSetup.SelectedIndexChanged += new System.EventHandler(this.lvWardSetup_SelectedIndexChanged);
            // 
            // cboSerialPriority
            // 
            this.cboSerialPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSerialPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSerialPriority.ForeColor = System.Drawing.Color.Blue;
            this.cboSerialPriority.FormattingEnabled = true;
            this.cboSerialPriority.Location = new System.Drawing.Point(230, 149);
            this.cboSerialPriority.Name = "cboSerialPriority";
            this.cboSerialPriority.Size = new System.Drawing.Size(100, 26);
            this.cboSerialPriority.TabIndex = 12;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(623, 70);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(72, 18);
            this.smartLabel7.TabIndex = 13;
            this.smartLabel7.Text = "Total Bed :";
            // 
            // txtTotalBed
            // 
            this.txtTotalBed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBed.Location = new System.Drawing.Point(626, 93);
            this.txtTotalBed.Name = "txtTotalBed";
            this.txtTotalBed.Size = new System.Drawing.Size(96, 24);
            this.txtTotalBed.TabIndex = 7;
            // 
            // cboFloorNo
            // 
            this.cboFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorNo.ForeColor = System.Drawing.Color.Blue;
            this.cboFloorNo.FormattingEnabled = true;
            this.cboFloorNo.Location = new System.Drawing.Point(336, 93);
            this.cboFloorNo.Name = "cboFloorNo";
            this.cboFloorNo.Size = new System.Drawing.Size(139, 26);
            this.cboFloorNo.TabIndex = 5;
            // 
            // txtNoRoom
            // 
            this.txtNoRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoRoom.Location = new System.Drawing.Point(729, 93);
            this.txtNoRoom.Name = "txtNoRoom";
            this.txtNoRoom.Size = new System.Drawing.Size(133, 24);
            this.txtNoRoom.TabIndex = 8;
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(729, 70);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(85, 18);
            this.smartLabel13.TabIndex = 120;
            this.smartLabel13.Text = "No of Room :";
            // 
            // cboBedType
            // 
            this.cboBedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBedType.ForeColor = System.Drawing.Color.Blue;
            this.cboBedType.FormattingEnabled = true;
            this.cboBedType.Location = new System.Drawing.Point(7, 93);
            this.cboBedType.Name = "cboBedType";
            this.cboBedType.Size = new System.Drawing.Size(323, 26);
            this.cboBedType.TabIndex = 4;
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel15.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.Location = new System.Drawing.Point(9, 70);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(75, 18);
            this.smartLabel15.TabIndex = 122;
            this.smartLabel15.Text = "Bed  Type :";
            // 
            // chkDepartment
            // 
            this.chkDepartment.AutoSize = true;
            this.chkDepartment.Location = new System.Drawing.Point(1008, 97);
            this.chkDepartment.Name = "chkDepartment";
            this.chkDepartment.Size = new System.Drawing.Size(111, 17);
            this.chkDepartment.TabIndex = 123;
            this.chkDepartment.Text = "Is Dept Restricted";
            this.chkDepartment.UseVisualStyleBackColor = true;
            this.chkDepartment.CheckedChanged += new System.EventHandler(this.chkDepartment_CheckedChanged);
            // 
            // chkGender
            // 
            this.chkGender.AutoSize = true;
            this.chkGender.Location = new System.Drawing.Point(1008, 72);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(123, 17);
            this.chkGender.TabIndex = 124;
            this.chkGender.Text = "Is Gender Restricted";
            this.chkGender.UseVisualStyleBackColor = true;
            this.chkGender.CheckedChanged += new System.EventHandler(this.chkGender_CheckedChanged);
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel16.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(118, 125);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(110, 18);
            this.smartLabel16.TabIndex = 126;
            this.smartLabel16.Text = "Age Group Max :";
            this.smartLabel16.Click += new System.EventHandler(this.smartLabel16_Click);
            // 
            // txtAgeGroupMax
            // 
            this.txtAgeGroupMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgeGroupMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeGroupMax.Location = new System.Drawing.Point(118, 149);
            this.txtAgeGroupMax.Name = "txtAgeGroupMax";
            this.txtAgeGroupMax.Size = new System.Drawing.Size(106, 24);
            this.txtAgeGroupMax.TabIndex = 11;
            this.txtAgeGroupMax.TextChanged += new System.EventHandler(this.smartTextBox1_TextChanged);
            // 
            // chkAge
            // 
            this.chkAge.AutoSize = true;
            this.chkAge.Location = new System.Drawing.Point(1008, 125);
            this.chkAge.Name = "chkAge";
            this.chkAge.Size = new System.Drawing.Size(107, 17);
            this.chkAge.TabIndex = 127;
            this.chkAge.Text = "Is Age Restricted";
            this.chkAge.UseVisualStyleBackColor = true;
            this.chkAge.CheckedChanged += new System.EventHandler(this.chkAge_CheckedChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(726, 14);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(137, 18);
            this.smartLabel1.TabIndex = 128;
            this.smartLabel1.Text = "Ward Name (Bangla):";
            // 
            // frmWardSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1144, 823);
            this.Controls.Add(this.cboBuildID);
            this.Controls.Add(this.smartLabel5);
            this.isEnterTabAllow = true;
            this.Name = "frmWardSetup";
            this.Load += new System.EventHandler(this.frmWardSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.smartLabel5, 0);
            this.Controls.SetChildIndex(this.cboBuildID, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtWardName;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtWardNo;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtWardID;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartTextBox txtAgeGroupMin;
        private AtiqsControlLibrary.SmartLabel levAllowGender;
        private AtiqsControlLibrary.SmartComboBox cboGender;
        private AtiqsControlLibrary.SmartLabel levDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartTextBox txtBlockNo;
        private AtiqsControlLibrary.SmartTextBox txtWardNameBang;
        private AtiqsControlLibrary.SmartComboBox cboDept;
        private AtiqsControlLibrary.SmartComboBox cboBuildID;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartListViewDetails lvWardSetup;
        private AtiqsControlLibrary.SmartComboBox cboSerialPriority;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartNumericTextBox txtTotalBed;
        private AtiqsControlLibrary.SmartComboBox cboFloorNo;
        private AtiqsControlLibrary.SmartNumericTextBox txtNoRoom;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private System.Windows.Forms.CheckBox chkDepartment;
        private AtiqsControlLibrary.SmartComboBox cboBedType;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartTextBox txtAgeGroupMax;
        private System.Windows.Forms.CheckBox chkGender;
        private System.Windows.Forms.CheckBox chkAge;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
    }
}
