namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOTTeamAssign
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartTextBox1 = new AtiqsControlLibrary.SmartTextBox();
            this.DG = new System.Windows.Forms.DataGridView();
            this.smartTextBox2 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtNetTotal = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboDoctorsCategory = new AtiqsControlLibrary.SmartComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DGdisplay = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGdisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(267, 9);
            this.frmLabel.Size = new System.Drawing.Size(375, 33);
            this.frmLabel.Text = "Operation Team Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.DGdisplay);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboDoctorsCategory);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtNetTotal);
            this.pnlMain.Controls.Add(this.smartTextBox2);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Controls.Add(this.smartTextBox1);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 62);
            this.pnlMain.Size = new System.Drawing.Size(863, 701);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(413, 769);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 769);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(526, 769);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(187, 769);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(748, 769);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(637, 769);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 808);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(38, 17);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(113, 14);
            this.smartLabel1.TabIndex = 53;
            this.smartLabel1.Text = "OT Team Name:";
            // 
            // smartTextBox1
            // 
            this.smartTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox1.Location = new System.Drawing.Point(166, 17);
            this.smartTextBox1.Name = "smartTextBox1";
            this.smartTextBox1.Size = new System.Drawing.Size(237, 24);
            this.smartTextBox1.TabIndex = 15;
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(20, 401);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(833, 266);
            this.DG.TabIndex = 54;
            // 
            // smartTextBox2
            // 
            this.smartTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox2.Location = new System.Drawing.Point(602, 17);
            this.smartTextBox2.Name = "smartTextBox2";
            this.smartTextBox2.Size = new System.Drawing.Size(237, 24);
            this.smartTextBox2.TabIndex = 55;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(492, 17);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(104, 14);
            this.smartLabel2.TabIndex = 56;
            this.smartLabel2.Text = "No of Persons:";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetTotal.Location = new System.Drawing.Point(758, 672);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(100, 24);
            this.txtNetTotal.TabIndex = 15;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(711, 677);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(40, 13);
            this.smartLabel3.TabIndex = 57;
            this.smartLabel3.Text = "Total:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(213, 62);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(108, 14);
            this.smartLabel4.TabIndex = 59;
            this.smartLabel4.Text = "Category Type:";
            // 
            // cboDoctorsCategory
            // 
            this.cboDoctorsCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctorsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctorsCategory.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctorsCategory.FormattingEnabled = true;
            this.cboDoctorsCategory.Items.AddRange(new object[] {
            "Surgeon",
            "Assistant Surgeon",
            "RMO",
            "OT Nurse",
            "OT Technisian",
            "General Nurse",
            "Anesthesiologist",
            "OT Helper",
            "Others"});
            this.cboDoctorsCategory.Location = new System.Drawing.Point(330, 59);
            this.cboDoctorsCategory.Name = "cboDoctorsCategory";
            this.cboDoctorsCategory.Size = new System.Drawing.Size(341, 26);
            this.cboDoctorsCategory.TabIndex = 58;
            this.cboDoctorsCategory.SelectedIndexChanged += new System.EventHandler(this.cboDoctorsCategory_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(810, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 31);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "++";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DGdisplay
            // 
            this.DGdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdisplay.Location = new System.Drawing.Point(22, 92);
            this.DGdisplay.Name = "DGdisplay";
            this.DGdisplay.Size = new System.Drawing.Size(833, 272);
            this.DGdisplay.TabIndex = 62;
            // 
            // frmOTTeamAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 833);
            this.Name = "frmOTTeamAssign";
            this.Load += new System.EventHandler(this.frmOTTeamAssign_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGdisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox smartTextBox1;
        private AtiqsControlLibrary.SmartTextBox smartTextBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.DataGridView DG;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtNetTotal;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboDoctorsCategory;
        private System.Windows.Forms.DataGridView DGdisplay;
    }
}
