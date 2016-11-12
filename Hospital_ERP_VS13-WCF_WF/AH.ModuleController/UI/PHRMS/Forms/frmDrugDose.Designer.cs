namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmDrugDose
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboAgeGroup = new AtiqsControlLibrary.SmartComboBox();
            this.lvDrugDose = new AtiqsControlLibrary.SmartListViewDetails();
            this.dgvDrugDose = new AtiqsControlLibrary.SmartDataGridView();
            this.txtDrugName = new AtiqsControlLibrary.SmartTextBox();
            this.txtDrugCompany = new AtiqsControlLibrary.SmartTextBox();
            this.txtDrugGroup = new AtiqsControlLibrary.SmartTextBox();
            this.txtDrugUnit = new AtiqsControlLibrary.SmartTextBox();
            this.txtDrugPacket = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDose = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.cboBeforeOrAfter = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.cboHM = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.cboMeal = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel17 = new AtiqsControlLibrary.SmartLabel();
            this.cboDurationIndicator = new AtiqsControlLibrary.SmartComboBox();
            this.txtMinUseDuration = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.cboRoute = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDrugID = new AtiqsControlLibrary.SmartTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboConsumption = new AtiqsControlLibrary.SmartComboBox();
            this.txtConsQty = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel23 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugDose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(853, 6);
            this.btnTopClose.TabIndex = 43;
            this.btnTopClose.TabStop = false;
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(382, 7);
            this.frmLabel.Size = new System.Drawing.Size(140, 33);
            this.frmLabel.Text = "Drug Dose";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboConsumption);
            this.pnlMain.Controls.Add(this.txtConsQty);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel23);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtDrugID);
            this.pnlMain.Controls.Add(this.dgvDrugDose);
            this.pnlMain.Controls.Add(this.smartLabel16);
            this.pnlMain.Controls.Add(this.cboRoute);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel17);
            this.pnlMain.Controls.Add(this.cboDurationIndicator);
            this.pnlMain.Controls.Add(this.txtMinUseDuration);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.smartLabel18);
            this.pnlMain.Controls.Add(this.cboBeforeOrAfter);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.cboHM);
            this.pnlMain.Controls.Add(this.smartLabel15);
            this.pnlMain.Controls.Add(this.cboMeal);
            this.pnlMain.Controls.Add(this.txtDose);
            this.pnlMain.Controls.Add(this.txtDrugName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.lvDrugDose);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboAgeGroup);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Location = new System.Drawing.Point(1, 51);
            this.pnlMain.Size = new System.Drawing.Size(940, 531);
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(941, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(486, 588);
            this.btnEdit.TabIndex = 74;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 588);
            this.btnSave.TabIndex = 9;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(600, 588);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(258, 588);
            this.btnNew.TabIndex = 77;
            this.btnNew.TabStop = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(828, 588);
            this.btnClose.TabIndex = 61;
            this.btnClose.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(714, 588);
            this.btnPrint.TabIndex = 58;
            this.btnPrint.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 627);
            this.groupBox1.Size = new System.Drawing.Size(941, 23);
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(13, 16);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(64, 18);
            this.smartLabel12.TabIndex = 55;
            this.smartLabel12.Text = "Drug ID :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(13, 75);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(80, 18);
            this.smartLabel1.TabIndex = 83;
            this.smartLabel1.Text = "Age Group :";
            // 
            // cboAgeGroup
            // 
            this.cboAgeGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAgeGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboAgeGroup.FormattingEnabled = true;
            this.cboAgeGroup.Location = new System.Drawing.Point(116, 71);
            this.cboAgeGroup.Name = "cboAgeGroup";
            this.cboAgeGroup.Size = new System.Drawing.Size(155, 26);
            this.cboAgeGroup.TabIndex = 0;
            // 
            // lvDrugDose
            // 
            this.lvDrugDose.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDrugDose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDrugDose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDrugDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrugDose.FullRowSelect = true;
            this.lvDrugDose.GridLines = true;
            this.lvDrugDose.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDrugDose.Location = new System.Drawing.Point(-1, 131);
            this.lvDrugDose.Name = "lvDrugDose";
            this.lvDrugDose.Size = new System.Drawing.Size(940, 399);
            this.lvDrugDose.TabIndex = 84;
            this.lvDrugDose.UseCompatibleStateImageBehavior = false;
            this.lvDrugDose.View = System.Windows.Forms.View.Details;
            this.lvDrugDose.SelectedIndexChanged += new System.EventHandler(this.lvDrugDose_SelectedIndexChanged);
            // 
            // dgvDrugDose
            // 
            this.dgvDrugDose.AllowUserToAddRows = false;
            this.dgvDrugDose.AllowUserToDeleteRows = false;
            this.dgvDrugDose.AllowUserToOrderColumns = true;
            this.dgvDrugDose.AllowUserToResizeColumns = false;
            this.dgvDrugDose.AllowUserToResizeRows = false;
            this.dgvDrugDose.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrugDose.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDrugDose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrugDose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrugDose.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDrugDose.Location = new System.Drawing.Point(122, 39);
            this.dgvDrugDose.MultiSelect = false;
            this.dgvDrugDose.Name = "dgvDrugDose";
            this.dgvDrugDose.RowHeadersVisible = false;
            this.dgvDrugDose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugDose.Size = new System.Drawing.Size(256, 29);
            this.dgvDrugDose.TabIndex = 86;
            this.dgvDrugDose.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugDose_CellClick);
            this.dgvDrugDose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDrugDose_KeyPress);
            // 
            // txtDrugName
            // 
            this.txtDrugName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugName.Location = new System.Drawing.Point(116, 43);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.ReadOnly = true;
            this.txtDrugName.Size = new System.Drawing.Size(294, 24);
            this.txtDrugName.TabIndex = 88;
            this.txtDrugName.TabStop = false;
            // 
            // txtDrugCompany
            // 
            this.txtDrugCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugCompany.Location = new System.Drawing.Point(30, 585);
            this.txtDrugCompany.Name = "txtDrugCompany";
            this.txtDrugCompany.Size = new System.Drawing.Size(32, 24);
            this.txtDrugCompany.TabIndex = 15;
            this.txtDrugCompany.Visible = false;
            // 
            // txtDrugGroup
            // 
            this.txtDrugGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugGroup.Location = new System.Drawing.Point(18, 597);
            this.txtDrugGroup.Name = "txtDrugGroup";
            this.txtDrugGroup.Size = new System.Drawing.Size(32, 24);
            this.txtDrugGroup.TabIndex = 16;
            this.txtDrugGroup.Visible = false;
            // 
            // txtDrugUnit
            // 
            this.txtDrugUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugUnit.Location = new System.Drawing.Point(59, 585);
            this.txtDrugUnit.Name = "txtDrugUnit";
            this.txtDrugUnit.Size = new System.Drawing.Size(32, 24);
            this.txtDrugUnit.TabIndex = 17;
            this.txtDrugUnit.Visible = false;
            // 
            // txtDrugPacket
            // 
            this.txtDrugPacket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugPacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugPacket.Location = new System.Drawing.Point(50, 602);
            this.txtDrugPacket.Name = "txtDrugPacket";
            this.txtDrugPacket.Size = new System.Drawing.Size(32, 24);
            this.txtDrugPacket.TabIndex = 18;
            this.txtDrugPacket.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(13, 46);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(85, 18);
            this.smartLabel2.TabIndex = 87;
            this.smartLabel2.Text = "Drug Name :";
            // 
            // txtDose
            // 
            this.txtDose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDose.Location = new System.Drawing.Point(547, 13);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(115, 24);
            this.txtDose.TabIndex = 89;
            this.txtDose.Text = "0+0+0";
            this.txtDose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDose_KeyPress_1);
            this.txtDose.Leave += new System.EventHandler(this.txtDose_Leave_1);
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.Location = new System.Drawing.Point(452, 46);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(71, 18);
            this.smartLabel18.TabIndex = 96;
            this.smartLabel18.Text = "B/A Meal :";
            // 
            // cboBeforeOrAfter
            // 
            this.cboBeforeOrAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBeforeOrAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBeforeOrAfter.ForeColor = System.Drawing.Color.Blue;
            this.cboBeforeOrAfter.FormattingEnabled = true;
            this.cboBeforeOrAfter.Location = new System.Drawing.Point(547, 42);
            this.cboBeforeOrAfter.Name = "cboBeforeOrAfter";
            this.cboBeforeOrAfter.Size = new System.Drawing.Size(115, 26);
            this.cboBeforeOrAfter.TabIndex = 91;
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(696, 46);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(38, 18);
            this.smartLabel14.TabIndex = 95;
            this.smartLabel14.Text = "Dur :";
            // 
            // cboHM
            // 
            this.cboHM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHM.ForeColor = System.Drawing.Color.Blue;
            this.cboHM.FormattingEnabled = true;
            this.cboHM.Location = new System.Drawing.Point(736, 42);
            this.cboHM.Name = "cboHM";
            this.cboHM.Size = new System.Drawing.Size(58, 26);
            this.cboHM.TabIndex = 92;
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.Location = new System.Drawing.Point(796, 46);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(48, 18);
            this.smartLabel15.TabIndex = 94;
            this.smartLabel15.Text = "Meal  :";
            // 
            // cboMeal
            // 
            this.cboMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeal.ForeColor = System.Drawing.Color.Blue;
            this.cboMeal.FormattingEnabled = true;
            this.cboMeal.Location = new System.Drawing.Point(847, 42);
            this.cboMeal.Name = "cboMeal";
            this.cboMeal.Size = new System.Drawing.Size(85, 26);
            this.cboMeal.TabIndex = 93;
            // 
            // smartLabel17
            // 
            this.smartLabel17.AutoSize = true;
            this.smartLabel17.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel17.Location = new System.Drawing.Point(672, 75);
            this.smartLabel17.Name = "smartLabel17";
            this.smartLabel17.Size = new System.Drawing.Size(62, 18);
            this.smartLabel17.TabIndex = 100;
            this.smartLabel17.Text = "Dur Ind :";
            // 
            // cboDurationIndicator
            // 
            this.cboDurationIndicator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDurationIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDurationIndicator.ForeColor = System.Drawing.Color.Blue;
            this.cboDurationIndicator.FormattingEnabled = true;
            this.cboDurationIndicator.Location = new System.Drawing.Point(736, 71);
            this.cboDurationIndicator.Name = "cboDurationIndicator";
            this.cboDurationIndicator.Size = new System.Drawing.Size(196, 26);
            this.cboDurationIndicator.TabIndex = 98;
            // 
            // txtMinUseDuration
            // 
            this.txtMinUseDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinUseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinUseDuration.Location = new System.Drawing.Point(547, 72);
            this.txtMinUseDuration.Name = "txtMinUseDuration";
            this.txtMinUseDuration.Size = new System.Drawing.Size(115, 24);
            this.txtMinUseDuration.TabIndex = 97;
            this.txtMinUseDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinUseDuration_KeyPress);
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(452, 75);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(92, 18);
            this.smartLabel13.TabIndex = 99;
            this.smartLabel13.Text = "Min Use Dur :";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(685, 16);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(49, 18);
            this.smartLabel16.TabIndex = 104;
            this.smartLabel16.Text = "Route :";
            // 
            // cboRoute
            // 
            this.cboRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoute.ForeColor = System.Drawing.Color.Blue;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Items.AddRange(new object[] {
            "select"});
            this.cboRoute.Location = new System.Drawing.Point(736, 12);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(196, 26);
            this.cboRoute.TabIndex = 102;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(452, 16);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(45, 18);
            this.smartLabel3.TabIndex = 103;
            this.smartLabel3.Text = "Dose :";
            // 
            // txtDrugID
            // 
            this.txtDrugID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugID.Location = new System.Drawing.Point(116, 13);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.Size = new System.Drawing.Size(128, 24);
            this.txtDrugID.TabIndex = 105;
            this.txtDrugID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrugID_KeyDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 107;
            this.label3.Text = "*";
            // 
            // cboConsumption
            // 
            this.cboConsumption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConsumption.ForeColor = System.Drawing.Color.Blue;
            this.cboConsumption.FormattingEnabled = true;
            this.cboConsumption.Location = new System.Drawing.Point(736, 99);
            this.cboConsumption.Name = "cboConsumption";
            this.cboConsumption.Size = new System.Drawing.Size(101, 26);
            this.cboConsumption.TabIndex = 167;
            this.cboConsumption.SelectedIndexChanged += new System.EventHandler(this.cboConsumption_SelectedIndexChanged);
            // 
            // txtConsQty
            // 
            this.txtConsQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsQty.Location = new System.Drawing.Point(547, 100);
            this.txtConsQty.Name = "txtConsQty";
            this.txtConsQty.Size = new System.Drawing.Size(69, 24);
            this.txtConsQty.TabIndex = 170;
            this.txtConsQty.TextChanged += new System.EventHandler(this.txtConsQty_TextChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(656, 103);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(78, 18);
            this.smartLabel4.TabIndex = 168;
            this.smartLabel4.Text = "Cons Form :";
            this.smartLabel4.Click += new System.EventHandler(this.smartLabel4_Click);
            // 
            // smartLabel23
            // 
            this.smartLabel23.AutoSize = true;
            this.smartLabel23.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel23.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel23.Location = new System.Drawing.Point(452, 103);
            this.smartLabel23.Name = "smartLabel23";
            this.smartLabel23.Size = new System.Drawing.Size(69, 18);
            this.smartLabel23.TabIndex = 169;
            this.smartLabel23.Text = "Cons Qty :";
            this.smartLabel23.Click += new System.EventHandler(this.smartLabel23_Click);
            // 
            // frmDrugDose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(941, 650);
            this.Controls.Add(this.txtDrugPacket);
            this.Controls.Add(this.txtDrugUnit);
            this.Controls.Add(this.txtDrugGroup);
            this.Controls.Add(this.txtDrugCompany);
            this.KeyPreview = false;
            this.Name = "frmDrugDose";
            this.Load += new System.EventHandler(this.frmDrugDose_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtDrugCompany, 0);
            this.Controls.SetChildIndex(this.txtDrugGroup, 0);
            this.Controls.SetChildIndex(this.txtDrugUnit, 0);
            this.Controls.SetChildIndex(this.txtDrugPacket, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugDose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboAgeGroup;
        private AtiqsControlLibrary.SmartListViewDetails lvDrugDose;
        private AtiqsControlLibrary.SmartDataGridView dgvDrugDose;
        private AtiqsControlLibrary.SmartTextBox txtDrugName;
        private AtiqsControlLibrary.SmartTextBox txtDrugCompany;
        private AtiqsControlLibrary.SmartTextBox txtDrugGroup;
        private AtiqsControlLibrary.SmartTextBox txtDrugUnit;
        private AtiqsControlLibrary.SmartTextBox txtDrugPacket;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDose;
        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartComboBox cboBeforeOrAfter;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartComboBox cboHM;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartComboBox cboMeal;
        private AtiqsControlLibrary.SmartLabel smartLabel17;
        private AtiqsControlLibrary.SmartComboBox cboDurationIndicator;
        private AtiqsControlLibrary.SmartNumericTextBox txtMinUseDuration;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartComboBox cboRoute;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDrugID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private AtiqsControlLibrary.SmartComboBox cboConsumption;
        private AtiqsControlLibrary.SmartNumericTextBox txtConsQty;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel23;
    }
}
