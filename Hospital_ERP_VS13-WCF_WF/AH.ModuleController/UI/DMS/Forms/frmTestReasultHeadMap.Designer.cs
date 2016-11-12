namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmTestReasultHeadMap
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
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboGroupID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboMainID = new AtiqsControlLibrary.SmartComboBox();
            this.cboTestDet = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshResultHeadGrp = new System.Windows.Forms.Button();
            this.btnAddResultHeadGrp = new System.Windows.Forms.Button();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.cboHeadGroupID = new AtiqsControlLibrary.SmartComboBox();
            this.lvResultHead = new AtiqsControlLibrary.SmartListViewDetails();
            this.lvAssociatedResultHead = new AtiqsControlLibrary.SmartListViewDetails();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRptGrpID = new AtiqsControlLibrary.SmartTextBox();
            this.txtRptGrpTitle = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnRefreshResultHead = new System.Windows.Forms.Button();
            this.btnAddResultHead = new System.Windows.Forms.Button();
            this.btnAddTestDet = new System.Windows.Forms.Button();
            this.txtCatagory = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtPanelTitle = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtCatagoryID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtPanelID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtReportSection = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtSecID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.chkTestList = new AtiqsControlLibrary.SmartCheckBox();
            this.chkAssociatedTestList = new AtiqsControlLibrary.SmartCheckBox();
            this.txtSearchResHead = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtSearchTest = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(477, 9);
            this.frmLabel.Size = new System.Drawing.Size(387, 33);
            this.frmLabel.Text = "Result Head Mapping With Test";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtSearchTest);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtSearchResHead);
            this.pnlMain.Controls.Add(this.chkAssociatedTestList);
            this.pnlMain.Controls.Add(this.chkTestList);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtReportSection);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtPanelTitle);
            this.pnlMain.Controls.Add(this.txtCatagory);
            this.pnlMain.Controls.Add(this.btnAddTestDet);
            this.pnlMain.Controls.Add(this.btnRefreshResultHead);
            this.pnlMain.Controls.Add(this.btnAddResultHead);
            this.pnlMain.Controls.Add(this.txtRptGrpTitle);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.lvAssociatedResultHead);
            this.pnlMain.Controls.Add(this.lvResultHead);
            this.pnlMain.Controls.Add(this.btnRefreshResultHeadGrp);
            this.pnlMain.Controls.Add(this.btnAddResultHeadGrp);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.cboHeadGroupID);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboTestDet);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboGroupID);
            this.pnlMain.Controls.Add(this.cboMainID);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.cboDeptID);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Location = new System.Drawing.Point(1, -87);
            this.pnlMain.Size = new System.Drawing.Size(1314, 835);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1315, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(867, 754);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(754, 754);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(980, 754);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(641, 754);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1202, 754);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(1091, 754);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 793);
            this.groupBox1.Size = new System.Drawing.Size(1315, 25);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(1219, 178);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 26);
            this.btnShow.TabIndex = 100;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show Result Head";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(14, 158);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(87, 18);
            this.smartLabel7.TabIndex = 99;
            this.smartLabel7.Text = "Department :";
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(14, 178);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(240, 26);
            this.cboDeptID.TabIndex = 94;
            this.cboDeptID.SelectedIndexChanged += new System.EventHandler(this.cboDeptID_SelectedIndexChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(260, 158);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(53, 18);
            this.smartLabel6.TabIndex = 98;
            this.smartLabel6.Text = "Group :";
            // 
            // cboGroupID
            // 
            this.cboGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupID.ForeColor = System.Drawing.Color.Blue;
            this.cboGroupID.FormattingEnabled = true;
            this.cboGroupID.Location = new System.Drawing.Point(260, 178);
            this.cboGroupID.Name = "cboGroupID";
            this.cboGroupID.Size = new System.Drawing.Size(229, 26);
            this.cboGroupID.TabIndex = 95;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(496, 158);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(75, 18);
            this.smartLabel4.TabIndex = 97;
            this.smartLabel4.Text = "Test Main :";
            // 
            // cboMainID
            // 
            this.cboMainID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMainID.ForeColor = System.Drawing.Color.Blue;
            this.cboMainID.FormattingEnabled = true;
            this.cboMainID.Location = new System.Drawing.Point(496, 178);
            this.cboMainID.Name = "cboMainID";
            this.cboMainID.Size = new System.Drawing.Size(266, 26);
            this.cboMainID.TabIndex = 96;
            this.cboMainID.SelectedIndexChanged += new System.EventHandler(this.cboMainID_SelectedIndexChanged);
            // 
            // cboTestDet
            // 
            this.cboTestDet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTestDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTestDet.ForeColor = System.Drawing.Color.Blue;
            this.cboTestDet.FormattingEnabled = true;
            this.cboTestDet.Location = new System.Drawing.Point(768, 178);
            this.cboTestDet.Name = "cboTestDet";
            this.cboTestDet.Size = new System.Drawing.Size(411, 26);
            this.cboTestDet.TabIndex = 105;
            this.cboTestDet.SelectedIndexChanged += new System.EventHandler(this.cboTestDet_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(768, 158);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 18);
            this.smartLabel1.TabIndex = 106;
            this.smartLabel1.Text = "Test Details :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(260, 210);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(96, 18);
            this.smartLabel2.TabIndex = 125;
            this.smartLabel2.Text = "Report Group :";
            // 
            // btnRefreshResultHeadGrp
            // 
            this.btnRefreshResultHeadGrp.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshResultHeadGrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshResultHeadGrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshResultHeadGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshResultHeadGrp.ForeColor = System.Drawing.Color.White;
            this.btnRefreshResultHeadGrp.Location = new System.Drawing.Point(801, 232);
            this.btnRefreshResultHeadGrp.Name = "btnRefreshResultHeadGrp";
            this.btnRefreshResultHeadGrp.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshResultHeadGrp.TabIndex = 134;
            this.btnRefreshResultHeadGrp.TabStop = false;
            this.btnRefreshResultHeadGrp.Text = "..";
            this.btnRefreshResultHeadGrp.UseVisualStyleBackColor = false;
            this.btnRefreshResultHeadGrp.Click += new System.EventHandler(this.btnRefreshResultHeadGrp_Click);
            // 
            // btnAddResultHeadGrp
            // 
            this.btnAddResultHeadGrp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddResultHeadGrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddResultHeadGrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddResultHeadGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddResultHeadGrp.ForeColor = System.Drawing.Color.White;
            this.btnAddResultHeadGrp.Location = new System.Drawing.Point(767, 232);
            this.btnAddResultHeadGrp.Name = "btnAddResultHeadGrp";
            this.btnAddResultHeadGrp.Size = new System.Drawing.Size(32, 26);
            this.btnAddResultHeadGrp.TabIndex = 133;
            this.btnAddResultHeadGrp.TabStop = false;
            this.btnAddResultHeadGrp.Text = "+";
            this.btnAddResultHeadGrp.UseVisualStyleBackColor = false;
            this.btnAddResultHeadGrp.Click += new System.EventHandler(this.btnAddResultHeadGrp_Click);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(496, 210);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(130, 18);
            this.smartLabel10.TabIndex = 132;
            this.smartLabel10.Text = "Result Head Group :";
            // 
            // cboHeadGroupID
            // 
            this.cboHeadGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeadGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHeadGroupID.ForeColor = System.Drawing.Color.Blue;
            this.cboHeadGroupID.FormattingEnabled = true;
            this.cboHeadGroupID.Location = new System.Drawing.Point(496, 232);
            this.cboHeadGroupID.Name = "cboHeadGroupID";
            this.cboHeadGroupID.Size = new System.Drawing.Size(266, 26);
            this.cboHeadGroupID.TabIndex = 131;
            // 
            // lvResultHead
            // 
            this.lvResultHead.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvResultHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvResultHead.CheckBoxes = true;
            this.lvResultHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvResultHead.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResultHead.FullRowSelect = true;
            this.lvResultHead.GridLines = true;
            this.lvResultHead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResultHead.Location = new System.Drawing.Point(-1, 344);
            this.lvResultHead.Name = "lvResultHead";
            this.lvResultHead.Size = new System.Drawing.Size(490, 487);
            this.lvResultHead.TabIndex = 137;
            this.lvResultHead.UseCompatibleStateImageBehavior = false;
            this.lvResultHead.View = System.Windows.Forms.View.Details;
            // 
            // lvAssociatedResultHead
            // 
            this.lvAssociatedResultHead.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvAssociatedResultHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAssociatedResultHead.CheckBoxes = true;
            this.lvAssociatedResultHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAssociatedResultHead.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAssociatedResultHead.FullRowSelect = true;
            this.lvAssociatedResultHead.GridLines = true;
            this.lvAssociatedResultHead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAssociatedResultHead.Location = new System.Drawing.Point(573, 344);
            this.lvAssociatedResultHead.Name = "lvAssociatedResultHead";
            this.lvAssociatedResultHead.Size = new System.Drawing.Size(740, 487);
            this.lvAssociatedResultHead.TabIndex = 138;
            this.lvAssociatedResultHead.UseCompatibleStateImageBehavior = false;
            this.lvAssociatedResultHead.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(491, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 486);
            this.panel2.TabIndex = 139;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(7, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 28);
            this.btnCancel.TabIndex = 88;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "<<";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(7, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRptGrpID
            // 
            this.txtRptGrpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRptGrpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRptGrpID.Location = new System.Drawing.Point(38, 763);
            this.txtRptGrpID.Name = "txtRptGrpID";
            this.txtRptGrpID.Size = new System.Drawing.Size(50, 24);
            this.txtRptGrpID.TabIndex = 141;
            this.txtRptGrpID.Visible = false;
            // 
            // txtRptGrpTitle
            // 
            this.txtRptGrpTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtRptGrpTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRptGrpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRptGrpTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRptGrpTitle.Location = new System.Drawing.Point(260, 232);
            this.txtRptGrpTitle.Name = "txtRptGrpTitle";
            this.txtRptGrpTitle.ReadOnly = true;
            this.txtRptGrpTitle.Size = new System.Drawing.Size(229, 24);
            this.txtRptGrpTitle.TabIndex = 140;
            this.txtRptGrpTitle.TabStop = false;
            // 
            // btnRefreshResultHead
            // 
            this.btnRefreshResultHead.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshResultHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshResultHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshResultHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshResultHead.ForeColor = System.Drawing.Color.White;
            this.btnRefreshResultHead.Location = new System.Drawing.Point(459, 286);
            this.btnRefreshResultHead.Name = "btnRefreshResultHead";
            this.btnRefreshResultHead.Size = new System.Drawing.Size(30, 26);
            this.btnRefreshResultHead.TabIndex = 142;
            this.btnRefreshResultHead.TabStop = false;
            this.btnRefreshResultHead.Text = "..";
            this.btnRefreshResultHead.UseVisualStyleBackColor = false;
            this.btnRefreshResultHead.Click += new System.EventHandler(this.btnRefreshResultHead_Click);
            // 
            // btnAddResultHead
            // 
            this.btnAddResultHead.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddResultHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddResultHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddResultHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddResultHead.ForeColor = System.Drawing.Color.White;
            this.btnAddResultHead.Location = new System.Drawing.Point(423, 286);
            this.btnAddResultHead.Name = "btnAddResultHead";
            this.btnAddResultHead.Size = new System.Drawing.Size(32, 26);
            this.btnAddResultHead.TabIndex = 141;
            this.btnAddResultHead.TabStop = false;
            this.btnAddResultHead.Text = "+";
            this.btnAddResultHead.UseVisualStyleBackColor = false;
            this.btnAddResultHead.Click += new System.EventHandler(this.btnAddResultHead_Click);
            // 
            // btnAddTestDet
            // 
            this.btnAddTestDet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddTestDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTestDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTestDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTestDet.ForeColor = System.Drawing.Color.White;
            this.btnAddTestDet.Location = new System.Drawing.Point(1181, 178);
            this.btnAddTestDet.Name = "btnAddTestDet";
            this.btnAddTestDet.Size = new System.Drawing.Size(32, 26);
            this.btnAddTestDet.TabIndex = 143;
            this.btnAddTestDet.TabStop = false;
            this.btnAddTestDet.Text = "+";
            this.btnAddTestDet.UseVisualStyleBackColor = false;
            this.btnAddTestDet.Click += new System.EventHandler(this.btnAddTestDet_Click);
            // 
            // txtCatagory
            // 
            this.txtCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtCatagory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCatagory.Location = new System.Drawing.Point(839, 232);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.ReadOnly = true;
            this.txtCatagory.Size = new System.Drawing.Size(168, 24);
            this.txtCatagory.TabIndex = 144;
            this.txtCatagory.TabStop = false;
            // 
            // txtPanelTitle
            // 
            this.txtPanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPanelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPanelTitle.Location = new System.Drawing.Point(1016, 232);
            this.txtPanelTitle.Name = "txtPanelTitle";
            this.txtPanelTitle.ReadOnly = true;
            this.txtPanelTitle.Size = new System.Drawing.Size(281, 24);
            this.txtPanelTitle.TabIndex = 145;
            this.txtPanelTitle.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(839, 210);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(67, 18);
            this.smartLabel3.TabIndex = 146;
            this.smartLabel3.Text = "Catagory :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(1016, 210);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(79, 18);
            this.smartLabel5.TabIndex = 147;
            this.smartLabel5.Text = "Panel Title :";
            // 
            // txtCatagoryID
            // 
            this.txtCatagoryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtCatagoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatagoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatagoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCatagoryID.Location = new System.Drawing.Point(108, 763);
            this.txtCatagoryID.Name = "txtCatagoryID";
            this.txtCatagoryID.ReadOnly = true;
            this.txtCatagoryID.Size = new System.Drawing.Size(49, 24);
            this.txtCatagoryID.TabIndex = 148;
            this.txtCatagoryID.TabStop = false;
            this.txtCatagoryID.Visible = false;
            // 
            // txtPanelID
            // 
            this.txtPanelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPanelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPanelID.Location = new System.Drawing.Point(172, 763);
            this.txtPanelID.Name = "txtPanelID";
            this.txtPanelID.ReadOnly = true;
            this.txtPanelID.Size = new System.Drawing.Size(49, 24);
            this.txtPanelID.TabIndex = 149;
            this.txtPanelID.TabStop = false;
            this.txtPanelID.Visible = false;
            // 
            // txtReportSection
            // 
            this.txtReportSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtReportSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtReportSection.Location = new System.Drawing.Point(14, 232);
            this.txtReportSection.Name = "txtReportSection";
            this.txtReportSection.ReadOnly = true;
            this.txtReportSection.Size = new System.Drawing.Size(240, 24);
            this.txtReportSection.TabIndex = 148;
            this.txtReportSection.TabStop = false;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(14, 210);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(101, 18);
            this.smartLabel8.TabIndex = 149;
            this.smartLabel8.Text = "Report Section :";
            // 
            // txtSecID
            // 
            this.txtSecID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtSecID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSecID.Location = new System.Drawing.Point(227, 763);
            this.txtSecID.Name = "txtSecID";
            this.txtSecID.ReadOnly = true;
            this.txtSecID.Size = new System.Drawing.Size(49, 24);
            this.txtSecID.TabIndex = 150;
            this.txtSecID.TabStop = false;
            this.txtSecID.Visible = false;
            // 
            // chkTestList
            // 
            this.chkTestList.AutoSize = true;
            this.chkTestList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTestList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTestList.ForeColor = System.Drawing.Color.Black;
            this.chkTestList.Location = new System.Drawing.Point(14, 316);
            this.chkTestList.Name = "chkTestList";
            this.chkTestList.Size = new System.Drawing.Size(84, 22);
            this.chkTestList.TabIndex = 150;
            this.chkTestList.Text = "Select All";
            this.chkTestList.UseVisualStyleBackColor = true;
            this.chkTestList.CheckedChanged += new System.EventHandler(this.chkTestList_CheckedChanged);
            // 
            // chkAssociatedTestList
            // 
            this.chkAssociatedTestList.AutoSize = true;
            this.chkAssociatedTestList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAssociatedTestList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAssociatedTestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAssociatedTestList.ForeColor = System.Drawing.Color.Black;
            this.chkAssociatedTestList.Location = new System.Drawing.Point(573, 316);
            this.chkAssociatedTestList.Name = "chkAssociatedTestList";
            this.chkAssociatedTestList.Size = new System.Drawing.Size(84, 22);
            this.chkAssociatedTestList.TabIndex = 151;
            this.chkAssociatedTestList.Text = "Select All";
            this.chkAssociatedTestList.UseVisualStyleBackColor = true;
            this.chkAssociatedTestList.CheckedChanged += new System.EventHandler(this.chkAssociatedTestList_CheckedChanged);
            // 
            // txtSearchResHead
            // 
            this.txtSearchResHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchResHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchResHead.Location = new System.Drawing.Point(14, 286);
            this.txtSearchResHead.Name = "txtSearchResHead";
            this.txtSearchResHead.Size = new System.Drawing.Size(403, 24);
            this.txtSearchResHead.TabIndex = 152;
            this.txtSearchResHead.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchResHead_KeyUp);
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(14, 263);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(129, 18);
            this.smartLabel9.TabIndex = 153;
            this.smartLabel9.Text = "Search Result Head:";
            // 
            // txtSearchTest
            // 
            this.txtSearchTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTest.Location = new System.Drawing.Point(859, 150);
            this.txtSearchTest.Name = "txtSearchTest";
            this.txtSearchTest.Size = new System.Drawing.Size(319, 24);
            this.txtSearchTest.TabIndex = 157;
            this.txtSearchTest.TextChanged += new System.EventHandler(this.txtSearchTest_TextChanged);
            // 
            // frmTestReasultHeadMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1315, 818);
            this.Controls.Add(this.txtSecID);
            this.Controls.Add(this.txtPanelID);
            this.Controls.Add(this.txtCatagoryID);
            this.Controls.Add(this.txtRptGrpID);
            this.isEnterTabAllow = true;
            this.Name = "frmTestReasultHeadMap";
            this.Load += new System.EventHandler(this.frmTestReasultHeadMap_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtRptGrpID, 0);
            this.Controls.SetChildIndex(this.txtCatagoryID, 0);
            this.Controls.SetChildIndex(this.txtPanelID, 0);
            this.Controls.SetChildIndex(this.txtSecID, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboGroupID;
        private AtiqsControlLibrary.SmartComboBox cboMainID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboTestDet;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.Button btnRefreshResultHeadGrp;
        private System.Windows.Forms.Button btnAddResultHeadGrp;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartComboBox cboHeadGroupID;
        private AtiqsControlLibrary.SmartListViewDetails lvResultHead;
        private AtiqsControlLibrary.SmartListViewDetails lvAssociatedResultHead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartTextBox txtRptGrpID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRptGrpTitle;
        private System.Windows.Forms.Button btnRefreshResultHead;
        private System.Windows.Forms.Button btnAddResultHead;
        private System.Windows.Forms.Button btnAddTestDet;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCatagory;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPanelTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCatagoryID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPanelID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtReportSection;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSecID;
        private AtiqsControlLibrary.SmartCheckBox chkTestList;
        private AtiqsControlLibrary.SmartCheckBox chkAssociatedTestList;
        private AtiqsControlLibrary.SmartTextBox txtSearchResHead;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartTextBox txtSearchTest;
    }
}
