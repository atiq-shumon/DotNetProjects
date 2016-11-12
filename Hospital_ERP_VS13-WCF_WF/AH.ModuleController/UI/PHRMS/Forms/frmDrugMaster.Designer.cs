namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmDrugMaster
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
            this.cboDrugCompany = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboDrugPacket = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboDrugUnit = new AtiqsControlLibrary.SmartComboBox();
            this.txtName = new AtiqsControlLibrary.SmartTextBox();
            this.txtNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.lvDrugMaster = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtDrugID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtReorderQty = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtPriority = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtSerialPriority = new AtiqsControlLibrary.SmartNumericTextBox();
            this.txtUrate = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtVAT = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtDiscount = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtSlrate = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtRackrate = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnCompanyRefresh = new System.Windows.Forms.Button();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.btnTypeRefresh = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnUnitRefresh = new System.Windows.Forms.Button();
            this.btnUnit = new System.Windows.Forms.Button();
            this.btnGroupRefresh = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsFormRefresh = new System.Windows.Forms.Button();
            this.btnConsFormAdd = new System.Windows.Forms.Button();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.cboConsumption = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.cboAgeGroup = new AtiqsControlLibrary.SmartComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.cboRoute = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel17 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.cboDurationIndicator = new AtiqsControlLibrary.SmartComboBox();
            this.txtMinUseDuration = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel19 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel20 = new AtiqsControlLibrary.SmartLabel();
            this.cboBeforeOrAfter = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.cboHM = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboMeal = new AtiqsControlLibrary.SmartComboBox();
            this.txtDose = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel23 = new AtiqsControlLibrary.SmartLabel();
            this.txtConsQty = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lvDrugDose = new AtiqsControlLibrary.SmartListViewDetails();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRouteAdd = new System.Windows.Forms.Button();
            this.btnRouteFormRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDrugGroup = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(842, 3);
            this.btnTopClose.TabIndex = 74;
            this.btnTopClose.TabStop = false;
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(571, 3);
            this.frmLabel.Size = new System.Drawing.Size(161, 33);
            this.frmLabel.Text = "Drug Master";
            this.frmLabel.Click += new System.EventHandler(this.frmLabel_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboDrugGroup);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.smartLabel13);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.btnGroupRefresh);
            this.pnlMain.Controls.Add(this.btnGroup);
            this.pnlMain.Controls.Add(this.btnUnitRefresh);
            this.pnlMain.Controls.Add(this.btnUnit);
            this.pnlMain.Controls.Add(this.btnTypeRefresh);
            this.pnlMain.Controls.Add(this.btnType);
            this.pnlMain.Controls.Add(this.btnCompanyRefresh);
            this.pnlMain.Controls.Add(this.btnCompanyAdd);
            this.pnlMain.Controls.Add(this.txtSerialPriority);
            this.pnlMain.Controls.Add(this.txtPriority);
            this.pnlMain.Controls.Add(this.txtReorderQty);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtDrugID);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.lvDrugMaster);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtNameBeng);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboDrugPacket);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboDrugUnit);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboDrugCompany);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(1272, 695);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1272, 51);
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1044, 751);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(930, 751);
            this.btnSave.TabIndex = 17;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 751);
            this.btnDelete.Size = new System.Drawing.Size(43, 39);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(816, 751);
            this.btnNew.TabIndex = 51;
            this.btnNew.TabStop = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1158, 751);
            this.btnClose.TabIndex = 80;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(348, 749);
            this.btnPrint.Size = new System.Drawing.Size(46, 39);
            this.btnPrint.TabIndex = 70;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 792);
            this.groupBox1.Size = new System.Drawing.Size(1272, 23);
            // 
            // cboDrugCompany
            // 
            this.cboDrugCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrugCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrugCompany.ForeColor = System.Drawing.Color.Blue;
            this.cboDrugCompany.FormattingEnabled = true;
            this.cboDrugCompany.Items.AddRange(new object[] {
            "select"});
            this.cboDrugCompany.Location = new System.Drawing.Point(131, 41);
            this.cboDrugCompany.Name = "cboDrugCompany";
            this.cboDrugCompany.Size = new System.Drawing.Size(338, 26);
            this.cboDrugCompany.TabIndex = 0;
            this.cboDrugCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDrugCompany_KeyDown);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(0, 45);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(96, 15);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Drug Comapny :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(0, 114);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(92, 15);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Generic Name :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(275, 79);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(86, 15);
            this.smartLabel3.TabIndex = 7;
            this.smartLabel3.Text = "Dosage Form :";
            // 
            // cboDrugPacket
            // 
            this.cboDrugPacket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrugPacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrugPacket.ForeColor = System.Drawing.Color.Blue;
            this.cboDrugPacket.FormattingEnabled = true;
            this.cboDrugPacket.Location = new System.Drawing.Point(368, 75);
            this.cboDrugPacket.Name = "cboDrugPacket";
            this.cboDrugPacket.Size = new System.Drawing.Size(189, 26);
            this.cboDrugPacket.TabIndex = 2;
            this.cboDrugPacket.SelectedIndexChanged += new System.EventHandler(this.cboDrugPacket_SelectedIndexChanged);
            this.cboDrugPacket.Click += new System.EventHandler(this.cboDrugPacket_Click);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(0, 79);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(115, 15);
            this.smartLabel4.TabIndex = 5;
            this.smartLabel4.Text = "Measurement Unit :";
            // 
            // cboDrugUnit
            // 
            this.cboDrugUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrugUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrugUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboDrugUnit.FormattingEnabled = true;
            this.cboDrugUnit.Location = new System.Drawing.Point(131, 75);
            this.cboDrugUnit.Name = "cboDrugUnit";
            this.cboDrugUnit.Size = new System.Drawing.Size(100, 26);
            this.cboDrugUnit.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(131, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(338, 24);
            this.txtName.TabIndex = 4;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // txtNameBeng
            // 
            this.txtNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameBeng.Location = new System.Drawing.Point(131, 181);
            this.txtNameBeng.Name = "txtNameBeng";
            this.txtNameBeng.Size = new System.Drawing.Size(338, 24);
            this.txtNameBeng.TabIndex = 5;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(0, 149);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(82, 15);
            this.smartLabel5.TabIndex = 11;
            this.smartLabel5.Text = "Brand Name :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(0, 184);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(119, 15);
            this.smartLabel6.TabIndex = 12;
            this.smartLabel6.Text = "Brand Name(Beng) :";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(235, 219);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(61, 15);
            this.smartLabel7.TabIndex = 13;
            this.smartLabel7.Text = "Remarks ";
            this.smartLabel7.Click += new System.EventHandler(this.smartLabel7_Click);
            // 
            // lvDrugMaster
            // 
            this.lvDrugMaster.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDrugMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDrugMaster.CheckBoxes = true;
            this.lvDrugMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDrugMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrugMaster.FullRowSelect = true;
            this.lvDrugMaster.GridLines = true;
            this.lvDrugMaster.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDrugMaster.Location = new System.Drawing.Point(-1, 287);
            this.lvDrugMaster.Name = "lvDrugMaster";
            this.lvDrugMaster.Size = new System.Drawing.Size(1267, 404);
            this.lvDrugMaster.TabIndex = 44;
            this.lvDrugMaster.TabStop = false;
            this.lvDrugMaster.UseCompatibleStateImageBehavior = false;
            this.lvDrugMaster.View = System.Windows.Forms.View.Details;
            this.lvDrugMaster.SelectedIndexChanged += new System.EventHandler(this.lvDrugMaster_SelectedIndexChanged);
            // 
            // txtDrugID
            // 
            this.txtDrugID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugID.Location = new System.Drawing.Point(131, 10);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.ReadOnly = true;
            this.txtDrugID.Size = new System.Drawing.Size(155, 24);
            this.txtDrugID.TabIndex = 50;
            this.txtDrugID.TabStop = false;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(0, 13);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(64, 15);
            this.smartLabel12.TabIndex = 53;
            this.smartLabel12.Text = "Brand ID :";
            // 
            // txtReorderQty
            // 
            this.txtReorderQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReorderQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorderQty.Location = new System.Drawing.Point(131, 216);
            this.txtReorderQty.Name = "txtReorderQty";
            this.txtReorderQty.Size = new System.Drawing.Size(62, 24);
            this.txtReorderQty.TabIndex = 13;
            this.txtReorderQty.TextChanged += new System.EventHandler(this.txtReorderQty_TextChanged);
            // 
            // txtPriority
            // 
            this.txtPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriority.Location = new System.Drawing.Point(450, 5);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(24, 24);
            this.txtPriority.TabIndex = 15;
            this.txtPriority.Text = "1";
            this.txtPriority.Visible = false;
            this.txtPriority.TextChanged += new System.EventHandler(this.txtPriority_TextChanged);
            // 
            // txtSerialPriority
            // 
            this.txtSerialPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialPriority.Location = new System.Drawing.Point(347, 8);
            this.txtSerialPriority.Name = "txtSerialPriority";
            this.txtSerialPriority.Size = new System.Drawing.Size(29, 24);
            this.txtSerialPriority.TabIndex = 14;
            this.txtSerialPriority.Text = "1";
            this.txtSerialPriority.Visible = false;
            this.txtSerialPriority.TextChanged += new System.EventHandler(this.txtSerialPriority_TextChanged);
            // 
            // txtUrate
            // 
            this.txtUrate.BackColor = System.Drawing.Color.Linen;
            this.txtUrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUrate.Location = new System.Drawing.Point(12, 749);
            this.txtUrate.Name = "txtUrate";
            this.txtUrate.ReadOnly = true;
            this.txtUrate.Size = new System.Drawing.Size(21, 24);
            this.txtUrate.TabIndex = 54;
            this.txtUrate.TabStop = false;
            this.txtUrate.Visible = false;
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.Linen;
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtVAT.Location = new System.Drawing.Point(78, 763);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(21, 24);
            this.txtVAT.TabIndex = 55;
            this.txtVAT.TabStop = false;
            this.txtVAT.Visible = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.Linen;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDiscount.Location = new System.Drawing.Point(105, 755);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(24, 24);
            this.txtDiscount.TabIndex = 56;
            this.txtDiscount.TabStop = false;
            this.txtDiscount.Visible = false;
            // 
            // txtSlrate
            // 
            this.txtSlrate.BackColor = System.Drawing.Color.Linen;
            this.txtSlrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSlrate.Location = new System.Drawing.Point(51, 758);
            this.txtSlrate.Name = "txtSlrate";
            this.txtSlrate.ReadOnly = true;
            this.txtSlrate.Size = new System.Drawing.Size(21, 24);
            this.txtSlrate.TabIndex = 57;
            this.txtSlrate.TabStop = false;
            this.txtSlrate.Visible = false;
            // 
            // txtRackrate
            // 
            this.txtRackrate.BackColor = System.Drawing.Color.Linen;
            this.txtRackrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRackrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRackrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRackrate.Location = new System.Drawing.Point(135, 768);
            this.txtRackrate.Name = "txtRackrate";
            this.txtRackrate.ReadOnly = true;
            this.txtRackrate.Size = new System.Drawing.Size(21, 24);
            this.txtRackrate.TabIndex = 58;
            this.txtRackrate.TabStop = false;
            this.txtRackrate.Visible = false;
            // 
            // btnCompanyRefresh
            // 
            this.btnCompanyRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCompanyRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanyRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnCompanyRefresh.Location = new System.Drawing.Point(487, 41);
            this.btnCompanyRefresh.Name = "btnCompanyRefresh";
            this.btnCompanyRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnCompanyRefresh.TabIndex = 132;
            this.btnCompanyRefresh.Text = "..";
            this.btnCompanyRefresh.UseVisualStyleBackColor = false;
            this.btnCompanyRefresh.Click += new System.EventHandler(this.btnCompanyRefresh_Click);
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCompanyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanyAdd.ForeColor = System.Drawing.Color.White;
            this.btnCompanyAdd.Location = new System.Drawing.Point(468, 40);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(19, 26);
            this.btnCompanyAdd.TabIndex = 131;
            this.btnCompanyAdd.Text = "+";
            this.btnCompanyAdd.UseVisualStyleBackColor = false;
            this.btnCompanyAdd.Click += new System.EventHandler(this.btnCompanyAdd_Click);
            // 
            // btnTypeRefresh
            // 
            this.btnTypeRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTypeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnTypeRefresh.Location = new System.Drawing.Point(576, 76);
            this.btnTypeRefresh.Name = "btnTypeRefresh";
            this.btnTypeRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnTypeRefresh.TabIndex = 134;
            this.btnTypeRefresh.Text = "..";
            this.btnTypeRefresh.UseVisualStyleBackColor = false;
            this.btnTypeRefresh.Click += new System.EventHandler(this.btnTypeRefresh_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.ForestGreen;
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType.ForeColor = System.Drawing.Color.White;
            this.btnType.Location = new System.Drawing.Point(557, 75);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(19, 26);
            this.btnType.TabIndex = 133;
            this.btnType.Text = "+";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnUnitRefresh
            // 
            this.btnUnitRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUnitRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnUnitRefresh.Location = new System.Drawing.Point(248, 76);
            this.btnUnitRefresh.Name = "btnUnitRefresh";
            this.btnUnitRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnUnitRefresh.TabIndex = 136;
            this.btnUnitRefresh.Text = "..";
            this.btnUnitRefresh.UseVisualStyleBackColor = false;
            this.btnUnitRefresh.Click += new System.EventHandler(this.btnUnitRefresh_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnit.ForeColor = System.Drawing.Color.White;
            this.btnUnit.Location = new System.Drawing.Point(229, 75);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(19, 26);
            this.btnUnit.TabIndex = 135;
            this.btnUnit.Text = "+";
            this.btnUnit.UseVisualStyleBackColor = false;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // btnGroupRefresh
            // 
            this.btnGroupRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGroupRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnGroupRefresh.Location = new System.Drawing.Point(576, 111);
            this.btnGroupRefresh.Name = "btnGroupRefresh";
            this.btnGroupRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnGroupRefresh.TabIndex = 138;
            this.btnGroupRefresh.Text = "..";
            this.btnGroupRefresh.UseVisualStyleBackColor = false;
            this.btnGroupRefresh.Click += new System.EventHandler(this.btnGroupRefresh_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.ForeColor = System.Drawing.Color.White;
            this.btnGroup.Location = new System.Drawing.Point(557, 110);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(19, 26);
            this.btnGroup.TabIndex = 137;
            this.btnGroup.Text = "+";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(389, 5);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(54, 15);
            this.smartLabel10.TabIndex = 50;
            this.smartLabel10.Text = "Priority ";
            this.smartLabel10.Visible = false;
            this.smartLabel10.Click += new System.EventHandler(this.smartLabel10_Click);
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(290, 8);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(69, 15);
            this.smartLabel11.TabIndex = 52;
            this.smartLabel11.Text = "Sl Priority ";
            this.smartLabel11.Visible = false;
            this.smartLabel11.Click += new System.EventHandler(this.smartLabel11_Click);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(0, 219);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(96, 15);
            this.smartLabel8.TabIndex = 46;
            this.smartLabel8.Text = "Safety Level Qty";
            this.smartLabel8.Click += new System.EventHandler(this.smartLabel8_Click);
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(293, 219);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(11, 15);
            this.smartLabel9.TabIndex = 139;
            this.smartLabel9.Text = ":";
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(103, 220);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(11, 15);
            this.smartLabel13.TabIndex = 140;
            this.smartLabel13.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(473, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 141;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(474, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 142;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(196, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 143;
            this.label4.Text = "*";
            // 
            // btnConsFormRefresh
            // 
            this.btnConsFormRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnConsFormRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsFormRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsFormRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnConsFormRefresh.Location = new System.Drawing.Point(568, 87);
            this.btnConsFormRefresh.Name = "btnConsFormRefresh";
            this.btnConsFormRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnConsFormRefresh.TabIndex = 147;
            this.btnConsFormRefresh.Text = "..";
            this.btnConsFormRefresh.UseVisualStyleBackColor = false;
            this.btnConsFormRefresh.Click += new System.EventHandler(this.btnConsFormRefresh_Click);
            // 
            // btnConsFormAdd
            // 
            this.btnConsFormAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConsFormAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsFormAdd.ForeColor = System.Drawing.Color.White;
            this.btnConsFormAdd.Location = new System.Drawing.Point(549, 86);
            this.btnConsFormAdd.Name = "btnConsFormAdd";
            this.btnConsFormAdd.Size = new System.Drawing.Size(19, 26);
            this.btnConsFormAdd.TabIndex = 146;
            this.btnConsFormAdd.Text = "+";
            this.btnConsFormAdd.UseVisualStyleBackColor = false;
            this.btnConsFormAdd.Click += new System.EventHandler(this.btnConsFormAdd_Click);
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(450, 65);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(74, 15);
            this.smartLabel14.TabIndex = 145;
            this.smartLabel14.Text = "Cons Form :";
            // 
            // cboConsumption
            // 
            this.cboConsumption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConsumption.ForeColor = System.Drawing.Color.Blue;
            this.cboConsumption.FormattingEnabled = true;
            this.cboConsumption.Location = new System.Drawing.Point(449, 86);
            this.cboConsumption.Name = "cboConsumption";
            this.cboConsumption.Size = new System.Drawing.Size(101, 26);
            this.cboConsumption.TabIndex = 144;
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.Location = new System.Drawing.Point(10, 17);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(73, 15);
            this.smartLabel15.TabIndex = 149;
            this.smartLabel15.Text = "Age Group :";
            // 
            // cboAgeGroup
            // 
            this.cboAgeGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAgeGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboAgeGroup.FormattingEnabled = true;
            this.cboAgeGroup.Location = new System.Drawing.Point(6, 38);
            this.cboAgeGroup.Name = "cboAgeGroup";
            this.cboAgeGroup.Size = new System.Drawing.Size(155, 26);
            this.cboAgeGroup.TabIndex = 148;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(734, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 164;
            this.label5.Text = "*";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(221, 65);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(46, 15);
            this.smartLabel16.TabIndex = 163;
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
            this.cboRoute.Location = new System.Drawing.Point(216, 86);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(118, 26);
            this.cboRoute.TabIndex = 161;
            // 
            // smartLabel17
            // 
            this.smartLabel17.AutoSize = true;
            this.smartLabel17.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel17.Location = new System.Drawing.Point(163, 17);
            this.smartLabel17.Name = "smartLabel17";
            this.smartLabel17.Size = new System.Drawing.Size(41, 15);
            this.smartLabel17.TabIndex = 162;
            this.smartLabel17.Text = "Dose :";
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.Location = new System.Drawing.Point(87, 65);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(56, 15);
            this.smartLabel18.TabIndex = 160;
            this.smartLabel18.Text = "Dur Ind :";
            // 
            // cboDurationIndicator
            // 
            this.cboDurationIndicator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDurationIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDurationIndicator.ForeColor = System.Drawing.Color.Blue;
            this.cboDurationIndicator.FormattingEnabled = true;
            this.cboDurationIndicator.Location = new System.Drawing.Point(86, 86);
            this.cboDurationIndicator.Name = "cboDurationIndicator";
            this.cboDurationIndicator.Size = new System.Drawing.Size(129, 26);
            this.cboDurationIndicator.TabIndex = 158;
            // 
            // txtMinUseDuration
            // 
            this.txtMinUseDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinUseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinUseDuration.Location = new System.Drawing.Point(10, 87);
            this.txtMinUseDuration.Name = "txtMinUseDuration";
            this.txtMinUseDuration.Size = new System.Drawing.Size(75, 24);
            this.txtMinUseDuration.TabIndex = 157;
            // 
            // smartLabel19
            // 
            this.smartLabel19.AutoSize = true;
            this.smartLabel19.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel19.Location = new System.Drawing.Point(12, 65);
            this.smartLabel19.Name = "smartLabel19";
            this.smartLabel19.Size = new System.Drawing.Size(61, 15);
            this.smartLabel19.TabIndex = 159;
            this.smartLabel19.Text = "Min Dur :";
            // 
            // smartLabel20
            // 
            this.smartLabel20.AutoSize = true;
            this.smartLabel20.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel20.Location = new System.Drawing.Point(282, 17);
            this.smartLabel20.Name = "smartLabel20";
            this.smartLabel20.Size = new System.Drawing.Size(65, 15);
            this.smartLabel20.TabIndex = 156;
            this.smartLabel20.Text = "B/A Meal :";
            // 
            // cboBeforeOrAfter
            // 
            this.cboBeforeOrAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBeforeOrAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBeforeOrAfter.ForeColor = System.Drawing.Color.Blue;
            this.cboBeforeOrAfter.FormattingEnabled = true;
            this.cboBeforeOrAfter.Location = new System.Drawing.Point(280, 38);
            this.cboBeforeOrAfter.Name = "cboBeforeOrAfter";
            this.cboBeforeOrAfter.Size = new System.Drawing.Size(136, 26);
            this.cboBeforeOrAfter.TabIndex = 151;
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(418, 17);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(63, 15);
            this.smartLabel21.TabIndex = 155;
            this.smartLabel21.Text = "Duration :";
            // 
            // cboHM
            // 
            this.cboHM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHM.ForeColor = System.Drawing.Color.Blue;
            this.cboHM.FormattingEnabled = true;
            this.cboHM.Location = new System.Drawing.Point(417, 38);
            this.cboHM.Name = "cboHM";
            this.cboHM.Size = new System.Drawing.Size(114, 26);
            this.cboHM.TabIndex = 152;
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(533, 17);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(44, 15);
            this.smartLabel22.TabIndex = 154;
            this.smartLabel22.Text = "Meal  :";
            // 
            // cboMeal
            // 
            this.cboMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeal.ForeColor = System.Drawing.Color.Blue;
            this.cboMeal.FormattingEnabled = true;
            this.cboMeal.Location = new System.Drawing.Point(531, 38);
            this.cboMeal.Name = "cboMeal";
            this.cboMeal.Size = new System.Drawing.Size(123, 26);
            this.cboMeal.TabIndex = 153;
            // 
            // txtDose
            // 
            this.txtDose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDose.Location = new System.Drawing.Point(162, 39);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(115, 24);
            this.txtDose.TabIndex = 150;
            this.txtDose.Text = "0+0+0";
            this.txtDose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDose_KeyPress);
            this.txtDose.Leave += new System.EventHandler(this.txtDose_Leave);
            // 
            // smartLabel23
            // 
            this.smartLabel23.AutoSize = true;
            this.smartLabel23.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel23.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel23.Location = new System.Drawing.Point(377, 65);
            this.smartLabel23.Name = "smartLabel23";
            this.smartLabel23.Size = new System.Drawing.Size(65, 15);
            this.smartLabel23.TabIndex = 165;
            this.smartLabel23.Text = "Cons Qty :";
            // 
            // txtConsQty
            // 
            this.txtConsQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsQty.Location = new System.Drawing.Point(378, 87);
            this.txtConsQty.Name = "txtConsQty";
            this.txtConsQty.Size = new System.Drawing.Size(69, 24);
            this.txtConsQty.TabIndex = 166;
            // 
            // lvDrugDose
            // 
            this.lvDrugDose.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDrugDose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDrugDose.CheckBoxes = true;
            this.lvDrugDose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDrugDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrugDose.FullRowSelect = true;
            this.lvDrugDose.GridLines = true;
            this.lvDrugDose.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDrugDose.Location = new System.Drawing.Point(6, 115);
            this.lvDrugDose.Name = "lvDrugDose";
            this.lvDrugDose.Size = new System.Drawing.Size(650, 158);
            this.lvDrugDose.TabIndex = 167;
            this.lvDrugDose.TabStop = false;
            this.lvDrugDose.UseCompatibleStateImageBehavior = false;
            this.lvDrugDose.View = System.Windows.Forms.View.Details;
            this.lvDrugDose.SelectedIndexChanged += new System.EventHandler(this.lvDrugDose_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btnRouteAdd);
            this.groupBox2.Controls.Add(this.btnRouteFormRefresh);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.smartLabel17);
            this.groupBox2.Controls.Add(this.lvDrugDose);
            this.groupBox2.Controls.Add(this.cboConsumption);
            this.groupBox2.Controls.Add(this.txtConsQty);
            this.groupBox2.Controls.Add(this.smartLabel14);
            this.groupBox2.Controls.Add(this.smartLabel23);
            this.groupBox2.Controls.Add(this.btnConsFormAdd);
            this.groupBox2.Controls.Add(this.btnConsFormRefresh);
            this.groupBox2.Controls.Add(this.smartLabel16);
            this.groupBox2.Controls.Add(this.cboAgeGroup);
            this.groupBox2.Controls.Add(this.cboRoute);
            this.groupBox2.Controls.Add(this.smartLabel15);
            this.groupBox2.Controls.Add(this.txtDose);
            this.groupBox2.Controls.Add(this.smartLabel18);
            this.groupBox2.Controls.Add(this.cboMeal);
            this.groupBox2.Controls.Add(this.cboDurationIndicator);
            this.groupBox2.Controls.Add(this.smartLabel22);
            this.groupBox2.Controls.Add(this.txtMinUseDuration);
            this.groupBox2.Controls.Add(this.cboHM);
            this.groupBox2.Controls.Add(this.smartLabel19);
            this.groupBox2.Controls.Add(this.smartLabel21);
            this.groupBox2.Controls.Add(this.smartLabel20);
            this.groupBox2.Controls.Add(this.cboBeforeOrAfter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(606, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 278);
            this.groupBox2.TabIndex = 168;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dose";
            // 
            // btnRouteAdd
            // 
            this.btnRouteAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRouteAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRouteAdd.ForeColor = System.Drawing.Color.White;
            this.btnRouteAdd.Location = new System.Drawing.Point(334, 86);
            this.btnRouteAdd.Name = "btnRouteAdd";
            this.btnRouteAdd.Size = new System.Drawing.Size(19, 26);
            this.btnRouteAdd.TabIndex = 169;
            this.btnRouteAdd.Text = "+";
            this.btnRouteAdd.UseVisualStyleBackColor = false;
            this.btnRouteAdd.Click += new System.EventHandler(this.btnRouteAdd_Click);
            // 
            // btnRouteFormRefresh
            // 
            this.btnRouteFormRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRouteFormRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRouteFormRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRouteFormRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRouteFormRefresh.Location = new System.Drawing.Point(353, 87);
            this.btnRouteFormRefresh.Name = "btnRouteFormRefresh";
            this.btnRouteFormRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRouteFormRefresh.TabIndex = 170;
            this.btnRouteFormRefresh.Text = "..";
            this.btnRouteFormRefresh.UseVisualStyleBackColor = false;
            this.btnRouteFormRefresh.Click += new System.EventHandler(this.btnRouteFormRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(595, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 24);
            this.btnAdd.TabIndex = 168;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(511, 40);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(53, 25);
            this.btnShow.TabIndex = 169;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(305, 216);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(164, 24);
            this.txtRemarks.TabIndex = 171;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(473, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 172;
            this.label6.Text = "*";
            // 
            // cboDrugGroup
            // 
            this.cboDrugGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrugGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrugGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDrugGroup.FormattingEnabled = true;
            this.cboDrugGroup.Location = new System.Drawing.Point(131, 111);
            this.cboDrugGroup.Name = "cboDrugGroup";
            this.cboDrugGroup.Size = new System.Drawing.Size(426, 26);
            this.cboDrugGroup.TabIndex = 173;
            // 
            // frmDrugMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1272, 815);
            this.Controls.Add(this.txtRackrate);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtSlrate);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtUrate);
            this.isEnterTabAllow = true;
            this.Name = "frmDrugMaster";
            this.Load += new System.EventHandler(this.frmDrugMaster_Load);
            this.Controls.SetChildIndex(this.txtUrate, 0);
            this.Controls.SetChildIndex(this.txtVAT, 0);
            this.Controls.SetChildIndex(this.txtSlrate, 0);
            this.Controls.SetChildIndex(this.txtDiscount, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtRackrate, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDrugCompany;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboDrugPacket;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboDrugUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtNameBeng;
        private AtiqsControlLibrary.SmartTextBox txtName;
        private AtiqsControlLibrary.SmartListViewDetails lvDrugMaster;
        private AtiqsControlLibrary.SmartTextBox txtDrugID;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartNumericTextBox txtSerialPriority;
        private AtiqsControlLibrary.SmartNumericTextBox txtPriority;
        private AtiqsControlLibrary.SmartNumericTextBox txtReorderQty;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRackrate;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSlrate;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDiscount;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtVAT;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtUrate;
        private System.Windows.Forms.Button btnGroupRefresh;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUnitRefresh;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.Button btnTypeRefresh;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnCompanyRefresh;
        private System.Windows.Forms.Button btnCompanyAdd;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsFormRefresh;
        private System.Windows.Forms.Button btnConsFormAdd;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartComboBox cboConsumption;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartComboBox cboAgeGroup;
        private AtiqsControlLibrary.SmartNumericTextBox txtConsQty;
        private AtiqsControlLibrary.SmartLabel smartLabel23;
        private System.Windows.Forms.Label label5;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private AtiqsControlLibrary.SmartComboBox cboRoute;
        private AtiqsControlLibrary.SmartLabel smartLabel17;
        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartComboBox cboDurationIndicator;
        private AtiqsControlLibrary.SmartNumericTextBox txtMinUseDuration;
        private AtiqsControlLibrary.SmartLabel smartLabel19;
        private AtiqsControlLibrary.SmartLabel smartLabel20;
        private AtiqsControlLibrary.SmartComboBox cboBeforeOrAfter;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartComboBox cboHM;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboMeal;
        private AtiqsControlLibrary.SmartTextBox txtDose;
        private AtiqsControlLibrary.SmartListViewDetails lvDrugDose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label6;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartComboBox cboDrugGroup;
        private System.Windows.Forms.Button btnRouteAdd;
        private System.Windows.Forms.Button btnRouteFormRefresh;
    }
}
