namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmFoodMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodMaster));
            this.lvwFoodItem = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtItemID = new AtiqsControlLibrary.SmartTextBox();
            this.txtFoodItem = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.chkNormal = new AtiqsControlLibrary.SmartCheckBox();
            this.chkdiabetic = new AtiqsControlLibrary.SmartCheckBox();
            this.chkhighprotein = new AtiqsControlLibrary.SmartCheckBox();
            this.chklowprotein = new AtiqsControlLibrary.SmartCheckBox();
            this.chkisrenal = new AtiqsControlLibrary.SmartCheckBox();
            this.chkhighfat = new AtiqsControlLibrary.SmartCheckBox();
            this.chkLowFat = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtFoodRate = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.btnshow = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FoodImage = new System.Windows.Forms.PictureBox();
            this.btnTypeRefresh = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.cboFoodCat = new AtiqsControlLibrary.SmartComboBox();
            this.cboUnitId = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(331, 10);
            this.frmLabel.Size = new System.Drawing.Size(162, 33);
            this.frmLabel.Text = "Food Master";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboUnitId);
            this.pnlMain.Controls.Add(this.cboFoodCat);
            this.pnlMain.Controls.Add(this.btnTypeRefresh);
            this.pnlMain.Controls.Add(this.btnType);
            this.pnlMain.Controls.Add(this.btnUpload);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.btnshow);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtFoodRate);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.chkLowFat);
            this.pnlMain.Controls.Add(this.chkhighfat);
            this.pnlMain.Controls.Add(this.chkisrenal);
            this.pnlMain.Controls.Add(this.chklowprotein);
            this.pnlMain.Controls.Add(this.chkhighprotein);
            this.pnlMain.Controls.Add(this.chkdiabetic);
            this.pnlMain.Controls.Add(this.chkNormal);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtFoodItem);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtItemID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.lvwFoodItem);
            this.pnlMain.Size = new System.Drawing.Size(848, 793);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(849, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(623, 709);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(510, 709);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 709);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(397, 709);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(737, 709);
            this.btnClose.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(120, 709);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 748);
            this.groupBox1.Size = new System.Drawing.Size(849, 25);
            // 
            // lvwFoodItem
            // 
            this.lvwFoodItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwFoodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwFoodItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwFoodItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFoodItem.FullRowSelect = true;
            this.lvwFoodItem.GridLines = true;
            this.lvwFoodItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFoodItem.Location = new System.Drawing.Point(9, 454);
            this.lvwFoodItem.Name = "lvwFoodItem";
            this.lvwFoodItem.Size = new System.Drawing.Size(833, 329);
            this.lvwFoodItem.TabIndex = 13;
            this.lvwFoodItem.UseCompatibleStateImageBehavior = false;
            this.lvwFoodItem.View = System.Windows.Forms.View.Details;
            this.lvwFoodItem.SelectedIndexChanged += new System.EventHandler(this.lvwFoodItem_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(75, 167);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(56, 13);
            this.smartLabel1.TabIndex = 14;
            this.smartLabel1.Text = "Food ID:";
            this.smartLabel1.Visible = false;
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(141, 164);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(354, 24);
            this.txtItemID.TabIndex = 15;
            this.txtItemID.Visible = false;
            // 
            // txtFoodItem
            // 
            this.txtFoodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodItem.Location = new System.Drawing.Point(141, 230);
            this.txtFoodItem.Name = "txtFoodItem";
            this.txtFoodItem.Size = new System.Drawing.Size(354, 24);
            this.txtFoodItem.TabIndex = 1;
            this.txtFoodItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodItem_KeyPress);
            this.txtFoodItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFoodItem_KeyUp);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(45, 232);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(86, 14);
            this.smartLabel2.TabIndex = 16;
            this.smartLabel2.Text = "Food Name:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(17, 198);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(114, 14);
            this.smartLabel4.TabIndex = 20;
            this.smartLabel4.Text = "Category Name:";
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNormal.ForeColor = System.Drawing.Color.Black;
            this.chkNormal.Location = new System.Drawing.Point(54, 401);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(73, 22);
            this.chkNormal.TabIndex = 21;
            this.chkNormal.Text = "Normal";
            this.chkNormal.UseVisualStyleBackColor = true;
            this.chkNormal.Visible = false;
            // 
            // chkdiabetic
            // 
            this.chkdiabetic.AutoSize = true;
            this.chkdiabetic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkdiabetic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkdiabetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdiabetic.ForeColor = System.Drawing.Color.Black;
            this.chkdiabetic.Location = new System.Drawing.Point(146, 401);
            this.chkdiabetic.Name = "chkdiabetic";
            this.chkdiabetic.Size = new System.Drawing.Size(77, 22);
            this.chkdiabetic.TabIndex = 22;
            this.chkdiabetic.Text = "Diabetic";
            this.chkdiabetic.UseVisualStyleBackColor = true;
            this.chkdiabetic.Visible = false;
            // 
            // chkhighprotein
            // 
            this.chkhighprotein.AutoSize = true;
            this.chkhighprotein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkhighprotein.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkhighprotein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkhighprotein.ForeColor = System.Drawing.Color.Black;
            this.chkhighprotein.Location = new System.Drawing.Point(247, 401);
            this.chkhighprotein.Name = "chkhighprotein";
            this.chkhighprotein.Size = new System.Drawing.Size(105, 22);
            this.chkhighprotein.TabIndex = 23;
            this.chkhighprotein.Text = "High Protein";
            this.chkhighprotein.UseVisualStyleBackColor = true;
            this.chkhighprotein.Visible = false;
            // 
            // chklowprotein
            // 
            this.chklowprotein.AutoSize = true;
            this.chklowprotein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chklowprotein.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chklowprotein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklowprotein.ForeColor = System.Drawing.Color.Black;
            this.chklowprotein.Location = new System.Drawing.Point(377, 401);
            this.chklowprotein.Name = "chklowprotein";
            this.chklowprotein.Size = new System.Drawing.Size(103, 22);
            this.chklowprotein.TabIndex = 24;
            this.chklowprotein.Text = "Low Protein";
            this.chklowprotein.UseVisualStyleBackColor = true;
            this.chklowprotein.Visible = false;
            // 
            // chkisrenal
            // 
            this.chkisrenal.AutoSize = true;
            this.chkisrenal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkisrenal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkisrenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkisrenal.ForeColor = System.Drawing.Color.Black;
            this.chkisrenal.Location = new System.Drawing.Point(506, 401);
            this.chkisrenal.Name = "chkisrenal";
            this.chkisrenal.Size = new System.Drawing.Size(62, 22);
            this.chkisrenal.TabIndex = 25;
            this.chkisrenal.Text = "Renal";
            this.chkisrenal.UseVisualStyleBackColor = true;
            this.chkisrenal.Visible = false;
            // 
            // chkhighfat
            // 
            this.chkhighfat.AutoSize = true;
            this.chkhighfat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkhighfat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkhighfat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkhighfat.ForeColor = System.Drawing.Color.Black;
            this.chkhighfat.Location = new System.Drawing.Point(584, 401);
            this.chkhighfat.Name = "chkhighfat";
            this.chkhighfat.Size = new System.Drawing.Size(79, 22);
            this.chkhighfat.TabIndex = 26;
            this.chkhighfat.Text = "High Fat";
            this.chkhighfat.UseVisualStyleBackColor = true;
            this.chkhighfat.Visible = false;
            // 
            // chkLowFat
            // 
            this.chkLowFat.AutoSize = true;
            this.chkLowFat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLowFat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLowFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLowFat.ForeColor = System.Drawing.Color.Black;
            this.chkLowFat.Location = new System.Drawing.Point(688, 401);
            this.chkLowFat.Name = "chkLowFat";
            this.chkLowFat.Size = new System.Drawing.Size(77, 22);
            this.chkLowFat.TabIndex = 27;
            this.chkLowFat.Text = "Low Fat";
            this.chkLowFat.UseVisualStyleBackColor = true;
            this.chkLowFat.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(72, 264);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(59, 14);
            this.smartLabel3.TabIndex = 29;
            this.smartLabel3.Text = "Unit ID:";
            // 
            // txtFoodRate
            // 
            this.txtFoodRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodRate.Location = new System.Drawing.Point(141, 296);
            this.txtFoodRate.Name = "txtFoodRate";
            this.txtFoodRate.Size = new System.Drawing.Size(185, 24);
            this.txtFoodRate.TabIndex = 31;
            this.txtFoodRate.Text = "0";
            this.txtFoodRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodRate_KeyPress);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(89, 300);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(42, 14);
            this.smartLabel5.TabIndex = 30;
            this.smartLabel5.Text = "Rate:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(141, 333);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(354, 24);
            this.txtRemarks.TabIndex = 4;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(61, 337);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(70, 14);
            this.smartLabel6.TabIndex = 35;
            this.smartLabel6.Text = "Remarks:";
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Teal;
            this.btnshow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnshow.Location = new System.Drawing.Point(413, 194);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(38, 25);
            this.btnshow.TabIndex = 36;
            this.btnshow.Text = "Find";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DELETE.ICO");
            this.imageList1.Images.SetKeyName(1, "images.jpg");
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpload.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(694, 341);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(32, 26);
            this.btnUpload.TabIndex = 38;
            this.btnUpload.Text = "+";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.FoodImage);
            this.groupBox2.Location = new System.Drawing.Point(590, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 186);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // FoodImage
            // 
            this.FoodImage.BackColor = System.Drawing.Color.LightGray;
            this.FoodImage.Location = new System.Drawing.Point(14, 18);
            this.FoodImage.Name = "FoodImage";
            this.FoodImage.Size = new System.Drawing.Size(201, 154);
            this.FoodImage.TabIndex = 0;
            this.FoodImage.TabStop = false;
            // 
            // btnTypeRefresh
            // 
            this.btnTypeRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTypeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnTypeRefresh.Location = new System.Drawing.Point(476, 194);
            this.btnTypeRefresh.Name = "btnTypeRefresh";
            this.btnTypeRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnTypeRefresh.TabIndex = 138;
            this.btnTypeRefresh.Text = "..";
            this.btnTypeRefresh.UseVisualStyleBackColor = false;
            this.btnTypeRefresh.Click += new System.EventHandler(this.btnTypeRefresh_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.ForestGreen;
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType.ForeColor = System.Drawing.Color.White;
            this.btnType.Location = new System.Drawing.Point(455, 194);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(19, 26);
            this.btnType.TabIndex = 137;
            this.btnType.Text = "+";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // cboFoodCat
            // 
            this.cboFoodCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFoodCat.ForeColor = System.Drawing.Color.Blue;
            this.cboFoodCat.FormattingEnabled = true;
            this.cboFoodCat.Location = new System.Drawing.Point(142, 194);
            this.cboFoodCat.Name = "cboFoodCat";
            this.cboFoodCat.Size = new System.Drawing.Size(267, 26);
            this.cboFoodCat.TabIndex = 139;
            // 
            // cboUnitId
            // 
            this.cboUnitId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnitId.ForeColor = System.Drawing.Color.Blue;
            this.cboUnitId.FormattingEnabled = true;
            this.cboUnitId.Items.AddRange(new object[] {
            "Pcs"});
            this.cboUnitId.Location = new System.Drawing.Point(141, 261);
            this.cboUnitId.Name = "cboUnitId";
            this.cboUnitId.Size = new System.Drawing.Size(184, 26);
            this.cboUnitId.TabIndex = 140;
            this.cboUnitId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUnitId_KeyPress);
            // 
            // frmFoodMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 773);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmFoodMaster";
            this.Load += new System.EventHandler(this.frmFoodMaster_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtFoodItem;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtItemID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwFoodItem;
        private AtiqsControlLibrary.SmartTextBox txtFoodRate;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartCheckBox chkLowFat;
        private AtiqsControlLibrary.SmartCheckBox chkhighfat;
        private AtiqsControlLibrary.SmartCheckBox chkisrenal;
        private AtiqsControlLibrary.SmartCheckBox chklowprotein;
        private AtiqsControlLibrary.SmartCheckBox chkhighprotein;
        private AtiqsControlLibrary.SmartCheckBox chkdiabetic;
        private AtiqsControlLibrary.SmartCheckBox chkNormal;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox FoodImage;
        private System.Windows.Forms.Button btnTypeRefresh;
        private System.Windows.Forms.Button btnType;
        private AtiqsControlLibrary.SmartComboBox cboFoodCat;
        private AtiqsControlLibrary.SmartComboBox cboUnitId;
    }
}
