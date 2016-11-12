namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmFoodItem
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
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtItemID = new AtiqsControlLibrary.SmartTextBox();
            this.lvwFoodItem = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtItemName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cbofoodCat = new System.Windows.Forms.ComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboDietCat = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FoodImage = new System.Windows.Forms.PictureBox();
            this.btnTypeRefresh = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(138, 33);
            this.frmLabel.Text = "Food Item";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnTypeRefresh);
            this.pnlMain.Controls.Add(this.btnType);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboDietCat);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cbofoodCat);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtItemID);
            this.pnlMain.Controls.Add(this.lvwFoodItem);
            this.pnlMain.Controls.Add(this.txtItemName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(863, 730);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(639, 646);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 646);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(22, 645);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(413, 646);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 646);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(133, 645);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 685);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(106, 154);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(52, 13);
            this.smartLabel2.TabIndex = 14;
            this.smartLabel2.Text = "Item ID:";
            this.smartLabel2.Visible = false;
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(165, 150);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(159, 24);
            this.txtItemID.TabIndex = 13;
            this.txtItemID.Visible = false;
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
            this.lvwFoodItem.Location = new System.Drawing.Point(7, 362);
            this.lvwFoodItem.Name = "lvwFoodItem";
            this.lvwFoodItem.Size = new System.Drawing.Size(847, 355);
            this.lvwFoodItem.TabIndex = 12;
            this.lvwFoodItem.UseCompatibleStateImageBehavior = false;
            this.lvwFoodItem.View = System.Windows.Forms.View.Details;
            this.lvwFoodItem.SelectedIndexChanged += new System.EventHandler(this.lvwFoodItem_SelectedIndexChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(165, 194);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(226, 24);
            this.txtItemName.TabIndex = 11;
            this.txtItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemName_KeyPress);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(86, 198);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(71, 13);
            this.smartLabel1.TabIndex = 10;
            this.smartLabel1.Text = "Item Name:";
            // 
            // cbofoodCat
            // 
            this.cbofoodCat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofoodCat.FormattingEnabled = true;
            this.cbofoodCat.Location = new System.Drawing.Point(165, 229);
            this.cbofoodCat.Name = "cbofoodCat";
            this.cbofoodCat.Size = new System.Drawing.Size(226, 24);
            this.cbofoodCat.TabIndex = 15;
            this.cbofoodCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbofoodCat_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(28, 233);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(129, 13);
            this.smartLabel3.TabIndex = 16;
            this.smartLabel3.Text = "Food Category Name:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(35, 269);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(124, 13);
            this.smartLabel4.TabIndex = 18;
            this.smartLabel4.Text = "Diet Category Name:";
            // 
            // cboDietCat
            // 
            this.cboDietCat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDietCat.FormattingEnabled = true;
            this.cboDietCat.Location = new System.Drawing.Point(165, 265);
            this.cboDietCat.Name = "cboDietCat";
            this.cboDietCat.Size = new System.Drawing.Size(226, 24);
            this.cboDietCat.TabIndex = 17;
            this.cboDietCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDietCat_KeyPress);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(165, 306);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(226, 24);
            this.txtRemarks.TabIndex = 20;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(99, 310);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(60, 13);
            this.smartLabel5.TabIndex = 19;
            this.smartLabel5.Text = "Remarks:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FoodImage);
            this.groupBox2.Location = new System.Drawing.Point(620, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 186);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // FoodImage
            // 
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
            this.btnTypeRefresh.Location = new System.Drawing.Point(456, 227);
            this.btnTypeRefresh.Name = "btnTypeRefresh";
            this.btnTypeRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnTypeRefresh.TabIndex = 136;
            this.btnTypeRefresh.Text = "..";
            this.btnTypeRefresh.UseVisualStyleBackColor = false;
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.ForestGreen;
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType.ForeColor = System.Drawing.Color.White;
            this.btnType.Location = new System.Drawing.Point(431, 227);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(19, 26);
            this.btnType.TabIndex = 135;
            this.btnType.Text = "+";
            this.btnType.UseVisualStyleBackColor = false;
            // 
            // frmFoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 710);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmFoodItem";
            this.Load += new System.EventHandler(this.frmFoodItem_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.ComboBox cboDietCat;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.ComboBox cbofoodCat;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtItemID;
        private AtiqsControlLibrary.SmartListViewDetails lvwFoodItem;
        private AtiqsControlLibrary.SmartTextBox txtItemName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox FoodImage;
        private System.Windows.Forms.Button btnTypeRefresh;
        private System.Windows.Forms.Button btnType;
    }
}
