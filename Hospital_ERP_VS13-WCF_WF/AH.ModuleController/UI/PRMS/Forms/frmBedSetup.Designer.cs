namespace AH.ModuleController.UI.PRMS.Forms
{
    partial class frmBedSetup
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
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.cboBedTypeID = new AtiqsControlLibrary.SmartComboBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvBedSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboBedStatus = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboBedFacility = new AtiqsControlLibrary.SmartComboBox();
            this.txtBedNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtBedID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtSerialNo = new AtiqsControlLibrary.SmartNumericTextBox();
            this.cboRoomID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.cboBuildID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtBedTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtBedTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.btnRoomRefresh = new System.Windows.Forms.Button();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboFloorNo = new AtiqsControlLibrary.SmartComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboNursingStation = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(865, 6);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(480, 6);
            this.frmLabel.Size = new System.Drawing.Size(136, 33);
            this.frmLabel.Text = "Bed Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboNursingStation);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.cboFloorNo);
            this.pnlMain.Controls.Add(this.btnRoomRefresh);
            this.pnlMain.Controls.Add(this.btnRoomAdd);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtBedTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtBedTitle);
            this.pnlMain.Controls.Add(this.cboBuildID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboRoomID);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.txtBedID);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtBedNo);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboBedFacility);
            this.pnlMain.Controls.Add(this.cboBedStatus);
            this.pnlMain.Controls.Add(this.lvBedSetup);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.cboBedTypeID);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(1120, 634);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1121, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(885, 691);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(771, 691);
            this.btnSave.TabIndex = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 690);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(657, 691);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(999, 691);
            this.btnClose.TabIndex = 20;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(121, 690);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 730);
            this.groupBox1.Size = new System.Drawing.Size(1121, 23);
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(101, 693);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(39, 26);
            this.cboDeptID.TabIndex = 1;
            this.cboDeptID.Visible = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(763, 68);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(78, 18);
            this.smartLabel4.TabIndex = 132;
            this.smartLabel4.Text = "Bed Status :";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(120, 68);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(59, 18);
            this.smartLabel7.TabIndex = 128;
            this.smartLabel7.Text = "Bed No :";
            this.smartLabel7.Click += new System.EventHandler(this.smartLabel7_Click);
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(6, 14);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(72, 18);
            this.smartLabel11.TabIndex = 139;
            this.smartLabel11.Text = "Bed Type :";
            // 
            // cboBedTypeID
            // 
            this.cboBedTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBedTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBedTypeID.ForeColor = System.Drawing.Color.Blue;
            this.cboBedTypeID.FormattingEnabled = true;
            this.cboBedTypeID.Location = new System.Drawing.Point(6, 35);
            this.cboBedTypeID.Name = "cboBedTypeID";
            this.cboBedTypeID.Size = new System.Drawing.Size(245, 26);
            this.cboBedTypeID.TabIndex = 1;
            this.cboBedTypeID.SelectedIndexChanged += new System.EventHandler(this.cboBedTypeID_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(63, 694);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(24, 25);
            this.txtRemarks.TabIndex = 13;
            this.txtRemarks.Visible = false;
            // 
            // lvBedSetup
            // 
            this.lvBedSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvBedSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBedSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvBedSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBedSetup.FullRowSelect = true;
            this.lvBedSetup.GridLines = true;
            this.lvBedSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvBedSetup.Location = new System.Drawing.Point(0, 139);
            this.lvBedSetup.Name = "lvBedSetup";
            this.lvBedSetup.Size = new System.Drawing.Size(1118, 492);
            this.lvBedSetup.TabIndex = 146;
            this.lvBedSetup.TabStop = false;
            this.lvBedSetup.UseCompatibleStateImageBehavior = false;
            this.lvBedSetup.View = System.Windows.Forms.View.Details;
            this.lvBedSetup.SelectedIndexChanged += new System.EventHandler(this.lvBedSetup_SelectedIndexChanged);
            // 
            // cboBedStatus
            // 
            this.cboBedStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBedStatus.ForeColor = System.Drawing.Color.Blue;
            this.cboBedStatus.FormattingEnabled = true;
            this.cboBedStatus.Location = new System.Drawing.Point(763, 91);
            this.cboBedStatus.Name = "cboBedStatus";
            this.cboBedStatus.Size = new System.Drawing.Size(218, 26);
            this.cboBedStatus.TabIndex = 9;
            this.cboBedStatus.SelectedIndexChanged += new System.EventHandler(this.cboBedStatus_SelectedIndexChanged);
            this.cboBedStatus.SelectedValueChanged += new System.EventHandler(this.cboBedStatus_SelectedValueChanged);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(253, 14);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(128, 18);
            this.smartLabel5.TabIndex = 148;
            this.smartLabel5.Text = "Bed Category Type :";
            // 
            // cboBedFacility
            // 
            this.cboBedFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBedFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBedFacility.ForeColor = System.Drawing.Color.Blue;
            this.cboBedFacility.FormattingEnabled = true;
            this.cboBedFacility.Location = new System.Drawing.Point(253, 35);
            this.cboBedFacility.Name = "cboBedFacility";
            this.cboBedFacility.Size = new System.Drawing.Size(208, 26);
            this.cboBedFacility.TabIndex = 2;
            // 
            // txtBedNo
            // 
            this.txtBedNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedNo.Location = new System.Drawing.Point(120, 91);
            this.txtBedNo.Name = "txtBedNo";
            this.txtBedNo.Size = new System.Drawing.Size(159, 24);
            this.txtBedNo.TabIndex = 6;
            this.txtBedNo.TextChanged += new System.EventHandler(this.txtBedNo_TextChanged);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(6, 68);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(57, 18);
            this.smartLabel8.TabIndex = 151;
            this.smartLabel8.Text = "Bed ID :";
            // 
            // txtBedID
            // 
            this.txtBedID.BackColor = System.Drawing.Color.Linen;
            this.txtBedID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBedID.Location = new System.Drawing.Point(6, 91);
            this.txtBedID.Name = "txtBedID";
            this.txtBedID.ReadOnly = true;
            this.txtBedID.Size = new System.Drawing.Size(108, 24);
            this.txtBedID.TabIndex = 3;
            this.txtBedID.TabStop = false;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNo.Location = new System.Drawing.Point(146, 693);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(25, 24);
            this.txtSerialNo.TabIndex = 7;
            this.txtSerialNo.Text = "1";
            this.txtSerialNo.Visible = false;
            // 
            // cboRoomID
            // 
            this.cboRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomID.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomID.FormattingEnabled = true;
            this.cboRoomID.Location = new System.Drawing.Point(896, 35);
            this.cboRoomID.Name = "cboRoomID";
            this.cboRoomID.Size = new System.Drawing.Size(161, 26);
            this.cboRoomID.TabIndex = 5;
            this.cboRoomID.SelectedIndexChanged += new System.EventHandler(this.cboRoomID_SelectedIndexChanged);
            this.cboRoomID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboRoomID_KeyDown);
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel15.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.Location = new System.Drawing.Point(896, 14);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(49, 18);
            this.smartLabel15.TabIndex = 160;
            this.smartLabel15.Text = "Room :";
            this.smartLabel15.Click += new System.EventHandler(this.smartLabel15_Click);
            // 
            // cboBuildID
            // 
            this.cboBuildID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuildID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuildID.ForeColor = System.Drawing.Color.Blue;
            this.cboBuildID.FormattingEnabled = true;
            this.cboBuildID.Location = new System.Drawing.Point(720, 35);
            this.cboBuildID.Name = "cboBuildID";
            this.cboBuildID.Size = new System.Drawing.Size(173, 26);
            this.cboBuildID.TabIndex = 4;
            this.cboBuildID.SelectedIndexChanged += new System.EventHandler(this.cboBuildID_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(285, 68);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(78, 18);
            this.smartLabel1.TabIndex = 161;
            this.smartLabel1.Text = "Bed Name :";
            // 
            // txtBedTitle
            // 
            this.txtBedTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedTitle.Location = new System.Drawing.Point(285, 91);
            this.txtBedTitle.Name = "txtBedTitle";
            this.txtBedTitle.Size = new System.Drawing.Size(208, 24);
            this.txtBedTitle.TabIndex = 7;
            // 
            // txtBedTitleBeng
            // 
            this.txtBedTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBedTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedTitleBeng.Location = new System.Drawing.Point(499, 91);
            this.txtBedTitleBeng.Name = "txtBedTitleBeng";
            this.txtBedTitleBeng.Size = new System.Drawing.Size(257, 24);
            this.txtBedTitleBeng.TabIndex = 8;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(499, 68);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(120, 18);
            this.smartLabel2.TabIndex = 163;
            this.smartLabel2.Text = "Bed Name(Beng)  :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(465, 14);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(44, 18);
            this.smartLabel3.TabIndex = 166;
            this.smartLabel3.Text = "Floor :";
            this.smartLabel3.Click += new System.EventHandler(this.smartLabel3_Click);
            // 
            // btnRoomRefresh
            // 
            this.btnRoomRefresh.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRoomRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRoomRefresh.Location = new System.Drawing.Point(1087, 36);
            this.btnRoomRefresh.Name = "btnRoomRefresh";
            this.btnRoomRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRoomRefresh.TabIndex = 168;
            this.btnRoomRefresh.Text = "..";
            this.btnRoomRefresh.UseVisualStyleBackColor = false;
            this.btnRoomRefresh.Click += new System.EventHandler(this.btnRoomRefresh_Click);
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAdd.ForeColor = System.Drawing.Color.White;
            this.btnRoomAdd.Location = new System.Drawing.Point(1058, 35);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(28, 26);
            this.btnRoomAdd.TabIndex = 167;
            this.btnRoomAdd.Text = "+";
            this.btnRoomAdd.UseVisualStyleBackColor = false;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnRoomAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(176, 695);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 30);
            this.btnSearch.TabIndex = 170;
            this.btnSearch.Text = "Show";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboFloorNo
            // 
            this.cboFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorNo.ForeColor = System.Drawing.Color.Blue;
            this.cboFloorNo.FormattingEnabled = true;
            this.cboFloorNo.Location = new System.Drawing.Point(464, 35);
            this.cboFloorNo.Name = "cboFloorNo";
            this.cboFloorNo.Size = new System.Drawing.Size(55, 26);
            this.cboFloorNo.TabIndex = 3;
            this.cboFloorNo.SelectedIndexChanged += new System.EventHandler(this.cboFloorNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(185, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 172;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(365, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 173;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(638, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 174;
            this.label4.Text = "*";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(720, 14);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(66, 18);
            this.smartLabel6.TabIndex = 175;
            this.smartLabel6.Text = "Building :";
            // 
            // cboNursingStation
            // 
            this.cboNursingStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNursingStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNursingStation.ForeColor = System.Drawing.Color.Blue;
            this.cboNursingStation.FormattingEnabled = true;
            this.cboNursingStation.Location = new System.Drawing.Point(522, 35);
            this.cboNursingStation.Name = "cboNursingStation";
            this.cboNursingStation.Size = new System.Drawing.Size(195, 26);
            this.cboNursingStation.TabIndex = 176;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(535, 14);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(108, 18);
            this.smartLabel9.TabIndex = 177;
            this.smartLabel9.Text = "Nursing Station :";
            // 
            // frmBedSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1121, 753);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.cboDeptID);
            this.isEnterTabAllow = true;
            this.Name = "frmBedSetup";
            this.Load += new System.EventHandler(this.frmBedSetup_Load);
            this.Controls.SetChildIndex(this.cboDeptID, 0);
            this.Controls.SetChildIndex(this.txtSerialNo, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartComboBox cboBedTypeID;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartComboBox cboBedStatus;
        private AtiqsControlLibrary.SmartListViewDetails lvBedSetup;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboBedFacility;
        private AtiqsControlLibrary.SmartTextBox txtBedNo;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtBedID;
        private AtiqsControlLibrary.SmartNumericTextBox txtSerialNo;
        private AtiqsControlLibrary.SmartComboBox cboRoomID;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartComboBox cboBuildID;
        private AtiqsControlLibrary.SmartTextBox txtBedTitleBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtBedTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.Button btnRoomRefresh;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartComboBox cboFloorNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboNursingStation;
        private AtiqsControlLibrary.SmartLabel smartLabel9;

    }
}
