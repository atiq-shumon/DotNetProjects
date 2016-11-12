namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmAssetsInformation
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtManufacturerName = new AtiqsControlLibrary.SmartTextBox();
            this.txtChallanadte = new AtiqsControlLibrary.SmartTextBox();
            this.txtchallanNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtCondition = new AtiqsControlLibrary.SmartTextBox();
            this.txtColor = new AtiqsControlLibrary.SmartTextBox();
            this.txtSerialNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtModelName = new AtiqsControlLibrary.SmartTextBox();
            this.txtTagNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtWarrentyDate = new AtiqsControlLibrary.SmartTextBox();
            this.txtMobileNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtContactPerson = new AtiqsControlLibrary.SmartTextBox();
            this.txtSereviceProviderName = new AtiqsControlLibrary.SmartTextBox();
            this.txtInvDate = new AtiqsControlLibrary.SmartTextBox();
            this.txtInvMrr = new AtiqsControlLibrary.SmartTextBox();
            this.txtSupplierName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel15 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel16 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DG = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtModelCode = new AtiqsControlLibrary.SmartTextBox();
            this.txtSupplierCode = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductCode = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(299, 9);
            this.frmLabel.Size = new System.Drawing.Size(239, 33);
            this.frmLabel.TabIndex = 17;
            this.frmLabel.Text = "Assets Information";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Size = new System.Drawing.Size(863, 754);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtProductCode);
            this.pnlTop.Controls.Add(this.txtSupplierCode);
            this.pnlTop.Controls.Add(this.txtModelCode);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtModelCode, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtSupplierCode, 0);
            this.pnlTop.Controls.SetChildIndex(this.txtProductCode, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(91, 677);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(478, 676);
            this.btnSave.TabIndex = 16;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(113, 677);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(36, 677);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(590, 676);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(127, 677);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 717);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtManufacturerName);
            this.groupBox2.Controls.Add(this.txtChallanadte);
            this.groupBox2.Controls.Add(this.txtchallanNo);
            this.groupBox2.Controls.Add(this.txtCondition);
            this.groupBox2.Controls.Add(this.txtColor);
            this.groupBox2.Controls.Add(this.txtSerialNo);
            this.groupBox2.Controls.Add(this.txtModelName);
            this.groupBox2.Controls.Add(this.txtTagNo);
            this.groupBox2.Controls.Add(this.smartLabel8);
            this.groupBox2.Controls.Add(this.smartLabel7);
            this.groupBox2.Controls.Add(this.smartLabel6);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 185);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assets Information";
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturerName.Location = new System.Drawing.Point(578, 143);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(208, 24);
            this.txtManufacturerName.TabIndex = 7;
            // 
            // txtChallanadte
            // 
            this.txtChallanadte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChallanadte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanadte.Location = new System.Drawing.Point(578, 103);
            this.txtChallanadte.Name = "txtChallanadte";
            this.txtChallanadte.ReadOnly = true;
            this.txtChallanadte.Size = new System.Drawing.Size(208, 24);
            this.txtChallanadte.TabIndex = 5;
            // 
            // txtchallanNo
            // 
            this.txtchallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtchallanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchallanNo.Location = new System.Drawing.Point(578, 66);
            this.txtchallanNo.Name = "txtchallanNo";
            this.txtchallanNo.ReadOnly = true;
            this.txtchallanNo.Size = new System.Drawing.Size(208, 24);
            this.txtchallanNo.TabIndex = 3;
            // 
            // txtCondition
            // 
            this.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondition.Location = new System.Drawing.Point(578, 0);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCondition.Size = new System.Drawing.Size(208, 54);
            this.txtCondition.TabIndex = 1;
            // 
            // txtColor
            // 
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(135, 143);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(241, 24);
            this.txtColor.TabIndex = 6;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNo.Location = new System.Drawing.Point(135, 103);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.ReadOnly = true;
            this.txtSerialNo.Size = new System.Drawing.Size(241, 24);
            this.txtSerialNo.TabIndex = 4;
            // 
            // txtModelName
            // 
            this.txtModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.Location = new System.Drawing.Point(135, 66);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.ReadOnly = true;
            this.txtModelName.Size = new System.Drawing.Size(241, 24);
            this.txtModelName.TabIndex = 2;
            // 
            // txtTagNo
            // 
            this.txtTagNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTagNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagNo.Location = new System.Drawing.Point(135, 34);
            this.txtTagNo.Name = "txtTagNo";
            this.txtTagNo.ReadOnly = true;
            this.txtTagNo.Size = new System.Drawing.Size(241, 24);
            this.txtTagNo.TabIndex = 0;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(427, 143);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(142, 14);
            this.smartLabel8.TabIndex = 30;
            this.smartLabel8.Text = "Manufacturer Name:";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(469, 103);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(96, 14);
            this.smartLabel7.TabIndex = 29;
            this.smartLabel7.Text = "Challan Date:";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(482, 66);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(83, 14);
            this.smartLabel6.TabIndex = 28;
            this.smartLabel6.Text = "Challan No:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(490, 34);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(74, 14);
            this.smartLabel5.TabIndex = 27;
            this.smartLabel5.Text = "Condition:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(76, 143);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(47, 14);
            this.smartLabel4.TabIndex = 26;
            this.smartLabel4.Text = "Color:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(53, 103);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(73, 14);
            this.smartLabel3.TabIndex = 25;
            this.smartLabel3.Text = "Serial No:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(51, 66);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(73, 14);
            this.smartLabel2.TabIndex = 24;
            this.smartLabel2.Text = "Model No:";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(65, 34);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(58, 14);
            this.smartLabel1.TabIndex = 23;
            this.smartLabel1.Text = "Tag No:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtWarrentyDate);
            this.groupBox3.Controls.Add(this.txtMobileNo);
            this.groupBox3.Controls.Add(this.txtContactPerson);
            this.groupBox3.Controls.Add(this.txtSereviceProviderName);
            this.groupBox3.Controls.Add(this.txtInvDate);
            this.groupBox3.Controls.Add(this.txtInvMrr);
            this.groupBox3.Controls.Add(this.txtSupplierName);
            this.groupBox3.Controls.Add(this.smartLabel9);
            this.groupBox3.Controls.Add(this.smartLabel10);
            this.groupBox3.Controls.Add(this.smartLabel11);
            this.groupBox3.Controls.Add(this.smartLabel12);
            this.groupBox3.Controls.Add(this.smartLabel14);
            this.groupBox3.Controls.Add(this.smartLabel15);
            this.groupBox3.Controls.Add(this.smartLabel16);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(837, 149);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Information";
            // 
            // txtWarrentyDate
            // 
            this.txtWarrentyDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarrentyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarrentyDate.Location = new System.Drawing.Point(571, 114);
            this.txtWarrentyDate.Name = "txtWarrentyDate";
            this.txtWarrentyDate.ReadOnly = true;
            this.txtWarrentyDate.Size = new System.Drawing.Size(208, 24);
            this.txtWarrentyDate.TabIndex = 14;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(571, 85);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(208, 24);
            this.txtMobileNo.TabIndex = 13;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.Location = new System.Drawing.Point(571, 56);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(208, 24);
            this.txtContactPerson.TabIndex = 11;
            // 
            // txtSereviceProviderName
            // 
            this.txtSereviceProviderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSereviceProviderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSereviceProviderName.Location = new System.Drawing.Point(571, 28);
            this.txtSereviceProviderName.Name = "txtSereviceProviderName";
            this.txtSereviceProviderName.Size = new System.Drawing.Size(208, 24);
            this.txtSereviceProviderName.TabIndex = 9;
            // 
            // txtInvDate
            // 
            this.txtInvDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvDate.Location = new System.Drawing.Point(135, 85);
            this.txtInvDate.Name = "txtInvDate";
            this.txtInvDate.ReadOnly = true;
            this.txtInvDate.Size = new System.Drawing.Size(241, 24);
            this.txtInvDate.TabIndex = 12;
            // 
            // txtInvMrr
            // 
            this.txtInvMrr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvMrr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvMrr.Location = new System.Drawing.Point(135, 56);
            this.txtInvMrr.Name = "txtInvMrr";
            this.txtInvMrr.ReadOnly = true;
            this.txtInvMrr.Size = new System.Drawing.Size(241, 24);
            this.txtInvMrr.TabIndex = 10;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(135, 28);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(241, 24);
            this.txtSupplierName.TabIndex = 8;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(457, 114);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(110, 14);
            this.smartLabel9.TabIndex = 30;
            this.smartLabel9.Text = "Warrenty Date:";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(489, 85);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(77, 14);
            this.smartLabel10.TabIndex = 29;
            this.smartLabel10.Text = "Mobile No:";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(453, 56);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(112, 14);
            this.smartLabel11.TabIndex = 28;
            this.smartLabel11.Text = "Contact Person:";
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(409, 28);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(165, 14);
            this.smartLabel12.TabIndex = 27;
            this.smartLabel12.Text = "Service Provider Name:";
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(47, 85);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(77, 14);
            this.smartLabel14.TabIndex = 25;
            this.smartLabel14.Text = "Inv.  Date:";
            // 
            // smartLabel15
            // 
            this.smartLabel15.AutoSize = true;
            this.smartLabel15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel15.Location = new System.Drawing.Point(61, 56);
            this.smartLabel15.Name = "smartLabel15";
            this.smartLabel15.Size = new System.Drawing.Size(65, 14);
            this.smartLabel15.TabIndex = 24;
            this.smartLabel15.Text = "Inv. Mrr:";
            // 
            // smartLabel16
            // 
            this.smartLabel16.AutoSize = true;
            this.smartLabel16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel16.Location = new System.Drawing.Point(18, 28);
            this.smartLabel16.Name = "smartLabel16";
            this.smartLabel16.Size = new System.Drawing.Size(109, 14);
            this.smartLabel16.TabIndex = 23;
            this.smartLabel16.Text = "Supplier Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DG);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 505);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(837, 232);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Additional Component";
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DG.Location = new System.Drawing.Point(15, 21);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(816, 196);
            this.DG.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Component Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Notes";
            this.Column3.Name = "Column3";
            this.Column3.Width = 230;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Width = 40;
            // 
            // txtModelCode
            // 
            this.txtModelCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelCode.Location = new System.Drawing.Point(38, 21);
            this.txtModelCode.Name = "txtModelCode";
            this.txtModelCode.Size = new System.Drawing.Size(208, 24);
            this.txtModelCode.TabIndex = 38;
            this.txtModelCode.Visible = false;
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierCode.Location = new System.Drawing.Point(615, 21);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(208, 24);
            this.txtSupplierCode.TabIndex = 39;
            this.txtSupplierCode.Visible = false;
            // 
            // txtProductCode
            // 
            this.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(27, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(208, 24);
            this.txtProductCode.TabIndex = 40;
            this.txtProductCode.Visible = false;
            // 
            // frmAssetsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 742);
            this.Name = "frmAssetsInformation";
            this.Load += new System.EventHandler(this.frmAssetsInformation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private AtiqsControlLibrary.SmartTextBox txtWarrentyDate;
        private AtiqsControlLibrary.SmartTextBox txtMobileNo;
        private AtiqsControlLibrary.SmartTextBox txtContactPerson;
        private AtiqsControlLibrary.SmartTextBox txtSereviceProviderName;
        private AtiqsControlLibrary.SmartTextBox txtInvDate;
        private AtiqsControlLibrary.SmartTextBox txtInvMrr;
        private AtiqsControlLibrary.SmartTextBox txtSupplierName;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
        private AtiqsControlLibrary.SmartLabel smartLabel15;
        private AtiqsControlLibrary.SmartLabel smartLabel16;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartTextBox txtManufacturerName;
        private AtiqsControlLibrary.SmartTextBox txtChallanadte;
        private AtiqsControlLibrary.SmartTextBox txtchallanNo;
        private AtiqsControlLibrary.SmartTextBox txtCondition;
        private AtiqsControlLibrary.SmartTextBox txtColor;
        private AtiqsControlLibrary.SmartTextBox txtSerialNo;
        private AtiqsControlLibrary.SmartTextBox txtModelName;
        private AtiqsControlLibrary.SmartTextBox txtTagNo;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DG;
        private AtiqsControlLibrary.SmartTextBox txtSupplierCode;
        private AtiqsControlLibrary.SmartTextBox txtModelCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private AtiqsControlLibrary.SmartTextBox txtProductCode;

    }
}
