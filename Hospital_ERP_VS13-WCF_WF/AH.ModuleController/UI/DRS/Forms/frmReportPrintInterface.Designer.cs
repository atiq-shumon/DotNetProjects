namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmReportPrintInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbdDepartment = new System.Windows.Forms.Label();
            this.lblGrop = new System.Windows.Forms.Label();
            this.lblReportGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtHCN = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtAge = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtMoneyRecipt = new System.Windows.Forms.TextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtSex = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnPatientDetails = new System.Windows.Forms.Button();
            this.lblMr = new AtiqsControlLibrary.SmartLabel();
            this.dgvReportList = new System.Windows.Forms.DataGridView();
            this.tvMoneyReceipt = new AtiqsControlLibrary.SmartTab();
            this.tabOPD = new System.Windows.Forms.TabPage();
            this.lstOPD = new AtiqsControlLibrary.SmartListViewDetails();
            this.tabIPD = new System.Windows.Forms.TabPage();
            this.tvNursStnMoneyReceipt = new AtiqsControlLibrary.SmartTreeView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAllTestList = new System.Windows.Forms.DataGridView();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).BeginInit();
            this.tvMoneyReceipt.SuspendLayout();
            this.tabOPD.SuspendLayout();
            this.tabIPD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTestList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(942, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(345, 6);
            this.frmLabel.Size = new System.Drawing.Size(273, 33);
            this.frmLabel.Text = "Report Print Interface";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.dgvAllTestList);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.tvMoneyReceipt);
            this.pnlMain.Controls.Add(this.dgvReportList);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(910, 675);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(910, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(85, 740);
            this.btnEdit.Size = new System.Drawing.Size(30, 25);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(129, 741);
            this.btnSave.Size = new System.Drawing.Size(10, 22);
            this.btnSave.TabIndex = 4;
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(59, 739);
            this.btnDelete.Size = new System.Drawing.Size(20, 25);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(679, 730);
            this.btnNew.Size = new System.Drawing.Size(108, 44);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(793, 730);
            this.btnClose.Size = new System.Drawing.Size(108, 44);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(145, 735);
            this.btnPrint.Size = new System.Drawing.Size(46, 34);
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 774);
            this.groupBox1.Size = new System.Drawing.Size(910, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Department :";
            // 
            // lbdDepartment
            // 
            this.lbdDepartment.AutoSize = true;
            this.lbdDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdDepartment.ForeColor = System.Drawing.Color.Blue;
            this.lbdDepartment.Location = new System.Drawing.Point(120, 8);
            this.lbdDepartment.Name = "lbdDepartment";
            this.lbdDepartment.Size = new System.Drawing.Size(57, 20);
            this.lbdDepartment.TabIndex = 84;
            this.lbdDepartment.Text = "label3";
            // 
            // lblGrop
            // 
            this.lblGrop.AutoSize = true;
            this.lblGrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrop.Location = new System.Drawing.Point(542, 9);
            this.lblGrop.Name = "lblGrop";
            this.lblGrop.Size = new System.Drawing.Size(106, 20);
            this.lblGrop.TabIndex = 85;
            this.lblGrop.Text = "Report For :";
            // 
            // lblReportGroup
            // 
            this.lblReportGroup.AutoSize = true;
            this.lblReportGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportGroup.ForeColor = System.Drawing.Color.Blue;
            this.lblReportGroup.Location = new System.Drawing.Point(654, 11);
            this.lblReportGroup.Name = "lblReportGroup";
            this.lblReportGroup.Size = new System.Drawing.Size(57, 20);
            this.lblReportGroup.TabIndex = 86;
            this.lblReportGroup.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(-1, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 38);
            this.panel1.TabIndex = 87;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.smartLabel2);
            this.panel2.Controls.Add(this.txtHCN);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.smartLabel1);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtMoneyRecipt);
            this.panel2.Controls.Add(this.smartLabel8);
            this.panel2.Controls.Add(this.txtSex);
            this.panel2.Controls.Add(this.smartLabel3);
            this.panel2.Controls.Add(this.txtPatientName);
            this.panel2.Controls.Add(this.btnPatientDetails);
            this.panel2.Controls.Add(this.lblMr);
            this.panel2.Location = new System.Drawing.Point(166, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 149);
            this.panel2.TabIndex = 211;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(395, 53);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(34, 15);
            this.smartLabel2.TabIndex = 219;
            this.smartLabel2.Text = "HCN";
            // 
            // txtHCN
            // 
            this.txtHCN.BackColor = System.Drawing.Color.Linen;
            this.txtHCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHCN.Location = new System.Drawing.Point(391, 75);
            this.txtHCN.Multiline = true;
            this.txtHCN.Name = "txtHCN";
            this.txtHCN.ReadOnly = true;
            this.txtHCN.Size = new System.Drawing.Size(348, 26);
            this.txtHCN.TabIndex = 218;
            this.txtHCN.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(337, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 24);
            this.label5.TabIndex = 217;
            this.label5.Text = "*";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(395, 102);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(29, 13);
            this.smartLabel1.TabIndex = 215;
            this.smartLabel1.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Linen;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAge.Location = new System.Drawing.Point(392, 121);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(253, 24);
            this.txtAge.TabIndex = 214;
            this.txtAge.TabStop = false;
            // 
            // txtMoneyRecipt
            // 
            this.txtMoneyRecipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyRecipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyRecipt.ForeColor = System.Drawing.Color.Red;
            this.txtMoneyRecipt.Location = new System.Drawing.Point(13, 27);
            this.txtMoneyRecipt.MaxLength = 12;
            this.txtMoneyRecipt.Name = "txtMoneyRecipt";
            this.txtMoneyRecipt.Size = new System.Drawing.Size(320, 31);
            this.txtMoneyRecipt.TabIndex = 205;
            this.txtMoneyRecipt.TextChanged += new System.EventHandler(this.txtMoneyRecipt_TextChanged);
            this.txtMoneyRecipt.Leave += new System.EventHandler(this.txtMoneyRecipt_Leave);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(648, 103);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(47, 15);
            this.smartLabel8.TabIndex = 212;
            this.smartLabel8.Text = "Gender";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.Linen;
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSex.Location = new System.Drawing.Point(647, 121);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(92, 24);
            this.txtSex.TabIndex = 211;
            this.txtSex.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(395, 2);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(80, 15);
            this.smartLabel3.TabIndex = 210;
            this.smartLabel3.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(392, 23);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(347, 26);
            this.txtPatientName.TabIndex = 209;
            this.txtPatientName.TabStop = false;
            // 
            // btnPatientDetails
            // 
            this.btnPatientDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDetails.ForeColor = System.Drawing.Color.White;
            this.btnPatientDetails.Location = new System.Drawing.Point(13, 82);
            this.btnPatientDetails.Name = "btnPatientDetails";
            this.btnPatientDetails.Size = new System.Drawing.Size(320, 34);
            this.btnPatientDetails.TabIndex = 206;
            this.btnPatientDetails.Text = "Find";
            this.btnPatientDetails.UseVisualStyleBackColor = false;
            this.btnPatientDetails.Click += new System.EventHandler(this.btnPatientDetails_Click);
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.BackColor = System.Drawing.Color.Transparent;
            this.lblMr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMr.Location = new System.Drawing.Point(13, 6);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(108, 15);
            this.lblMr.TabIndex = 208;
            this.lblMr.Text = "Money Receipt  No";
            // 
            // dgvReportList
            // 
            this.dgvReportList.AllowUserToAddRows = false;
            this.dgvReportList.AllowUserToDeleteRows = false;
            this.dgvReportList.AllowUserToResizeColumns = false;
            this.dgvReportList.AllowUserToResizeRows = false;
            this.dgvReportList.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportList.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvReportList.Location = new System.Drawing.Point(164, 155);
            this.dgvReportList.Name = "dgvReportList";
            this.dgvReportList.RowHeadersVisible = false;
            this.dgvReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReportList.Size = new System.Drawing.Size(744, 243);
            this.dgvReportList.TabIndex = 212;
            this.dgvReportList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportList_CellClick);
            this.dgvReportList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportList_CellContentClick);
            // 
            // tvMoneyReceipt
            // 
            this.tvMoneyReceipt.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tvMoneyReceipt.Controls.Add(this.tabOPD);
            this.tvMoneyReceipt.Controls.Add(this.tabIPD);
            this.tvMoneyReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvMoneyReceipt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMoneyReceipt.Location = new System.Drawing.Point(2, 2);
            this.tvMoneyReceipt.Name = "tvMoneyReceipt";
            this.tvMoneyReceipt.SelectedIndex = 0;
            this.tvMoneyReceipt.Size = new System.Drawing.Size(162, 631);
            this.tvMoneyReceipt.TabIndex = 213;
            // 
            // tabOPD
            // 
            this.tabOPD.Controls.Add(this.lstOPD);
            this.tabOPD.Location = new System.Drawing.Point(4, 31);
            this.tabOPD.Name = "tabOPD";
            this.tabOPD.Padding = new System.Windows.Forms.Padding(3);
            this.tabOPD.Size = new System.Drawing.Size(154, 596);
            this.tabOPD.TabIndex = 0;
            this.tabOPD.Text = "OPD";
            this.tabOPD.UseVisualStyleBackColor = true;
            // 
            // lstOPD
            // 
            this.lstOPD.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstOPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOPD.CheckBoxes = true;
            this.lstOPD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstOPD.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOPD.FullRowSelect = true;
            this.lstOPD.GridLines = true;
            this.lstOPD.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstOPD.HideSelection = false;
            this.lstOPD.Location = new System.Drawing.Point(0, 2);
            this.lstOPD.Name = "lstOPD";
            this.lstOPD.Size = new System.Drawing.Size(153, 592);
            this.lstOPD.TabIndex = 1;
            this.lstOPD.TabStop = false;
            this.lstOPD.UseCompatibleStateImageBehavior = false;
            this.lstOPD.View = System.Windows.Forms.View.Details;
            this.lstOPD.SelectedIndexChanged += new System.EventHandler(this.lstOPD_SelectedIndexChanged);
            // 
            // tabIPD
            // 
            this.tabIPD.Controls.Add(this.tvNursStnMoneyReceipt);
            this.tabIPD.Location = new System.Drawing.Point(4, 31);
            this.tabIPD.Name = "tabIPD";
            this.tabIPD.Padding = new System.Windows.Forms.Padding(3);
            this.tabIPD.Size = new System.Drawing.Size(154, 596);
            this.tabIPD.TabIndex = 1;
            this.tabIPD.Text = "IPD";
            this.tabIPD.UseVisualStyleBackColor = true;
            // 
            // tvNursStnMoneyReceipt
            // 
            this.tvNursStnMoneyReceipt.BackColor = System.Drawing.Color.LightYellow;
            this.tvNursStnMoneyReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvNursStnMoneyReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvNursStnMoneyReceipt.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvNursStnMoneyReceipt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNursStnMoneyReceipt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tvNursStnMoneyReceipt.LineColor = System.Drawing.Color.Crimson;
            this.tvNursStnMoneyReceipt.Location = new System.Drawing.Point(0, 3);
            this.tvNursStnMoneyReceipt.Name = "tvNursStnMoneyReceipt";
            this.tvNursStnMoneyReceipt.Size = new System.Drawing.Size(153, 591);
            this.tvNursStnMoneyReceipt.TabIndex = 195;
            this.tvNursStnMoneyReceipt.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNursStnMoneyReceipt_AfterSelect);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(-1, 634);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(167, 39);
            this.btnRefresh.TabIndex = 214;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvAllTestList
            // 
            this.dgvAllTestList.AllowUserToAddRows = false;
            this.dgvAllTestList.AllowUserToDeleteRows = false;
            this.dgvAllTestList.AllowUserToResizeColumns = false;
            this.dgvAllTestList.AllowUserToResizeRows = false;
            this.dgvAllTestList.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvAllTestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTestList.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvAllTestList.Location = new System.Drawing.Point(165, 429);
            this.dgvAllTestList.Name = "dgvAllTestList";
            this.dgvAllTestList.RowHeadersVisible = false;
            this.dgvAllTestList.Size = new System.Drawing.Size(744, 243);
            this.dgvAllTestList.TabIndex = 215;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.Color.DarkBlue;
            this.smartLabel4.Location = new System.Drawing.Point(168, 404);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(168, 20);
            this.smartLabel4.TabIndex = 216;
            this.smartLabel4.Text = "Pending Report List";
            // 
            // frmReportPrintInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(910, 797);
            this.isEnterTabAllow = true;
            this.Name = "frmReportPrintInterface";
            this.Load += new System.EventHandler(this.frmReportPrintInterface_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).EndInit();
            this.tvMoneyReceipt.ResumeLayout(false);
            this.tabOPD.ResumeLayout(false);
            this.tabIPD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTestList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGrop;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblReportGroup;
        public System.Windows.Forms.Label lbdDepartment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReportList;
        private System.Windows.Forms.Label label5;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAge;
        private System.Windows.Forms.TextBox txtMoneyRecipt;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSex;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
        private System.Windows.Forms.Button btnPatientDetails;
        private AtiqsControlLibrary.SmartLabel lblMr;
        private AtiqsControlLibrary.SmartTab tvMoneyReceipt;
        private System.Windows.Forms.TabPage tabOPD;
        private AtiqsControlLibrary.SmartListViewDetails lstOPD;
        private System.Windows.Forms.TabPage tabIPD;
        private AtiqsControlLibrary.SmartTreeView tvNursStnMoneyReceipt;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHCN;
        private System.Windows.Forms.Button btnRefresh;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.DataGridView dgvAllTestList;
    }
}
