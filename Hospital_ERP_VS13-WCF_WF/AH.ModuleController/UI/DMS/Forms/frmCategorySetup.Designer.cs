namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmCategorySetup
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtCatNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.txtCategoryID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtCatName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lvCategory = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboBenefit = new AtiqsControlLibrary.SmartComboBox();
            this.txtMR = new AtiqsControlLibrary.SmartTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(256, 33);
            this.frmLabel.Text = "Test Category Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtMR);
            this.pnlMain.Controls.Add(this.cboBenefit);
            this.pnlMain.Controls.Add(this.lvCategory);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtCatNameBeng);
            this.pnlMain.Controls.Add(this.txtCategoryID);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtCatName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(863, 517);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(418, 573);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 573);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 573);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(192, 573);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(753, 573);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(642, 573);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 612);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(15, 100);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(146, 18);
            this.smartLabel3.TabIndex = 55;
            this.smartLabel3.Text = "Category Name(Beng) :";
            // 
            // txtCatNameBeng
            // 
            this.txtCatNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatNameBeng.Location = new System.Drawing.Point(178, 97);
            this.txtCatNameBeng.Name = "txtCatNameBeng";
            this.txtCatNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtCatNameBeng.TabIndex = 2;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCategoryID.Location = new System.Drawing.Point(178, 19);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(138, 24);
            this.txtCategoryID.TabIndex = 0;
            this.txtCategoryID.TabStop = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(93, 135);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 54;
            this.smartLabel5.Text = "Remarks :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(75, 22);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 18);
            this.smartLabel1.TabIndex = 52;
            this.smartLabel1.Text = "Category ID :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(178, 135);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(395, 62);
            this.txtRemarks.TabIndex = 3;
            // 
            // txtCatName
            // 
            this.txtCatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatName.Location = new System.Drawing.Point(178, 58);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(395, 24);
            this.txtCatName.TabIndex = 1;
            this.txtCatName.TextChanged += new System.EventHandler(this.txtCatName_TextChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(54, 61);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(107, 18);
            this.smartLabel2.TabIndex = 53;
            this.smartLabel2.Text = "Category Name :";
            // 
            // lvCategory
            // 
            this.lvCategory.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCategory.CheckBoxes = true;
            this.lvCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCategory.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.GridLines = true;
            this.lvCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCategory.Location = new System.Drawing.Point(-1, 222);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(862, 294);
            this.lvCategory.TabIndex = 56;
            this.lvCategory.TabStop = false;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.SelectedIndexChanged += new System.EventHandler(this.lvCategory_SelectedIndexChanged);
            this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
            // 
            // cboBenefit
            // 
            this.cboBenefit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBenefit.ForeColor = System.Drawing.Color.Blue;
            this.cboBenefit.FormattingEnabled = true;
            this.cboBenefit.Location = new System.Drawing.Point(641, 134);
            this.cboBenefit.Name = "cboBenefit";
            this.cboBenefit.Size = new System.Drawing.Size(161, 26);
            this.cboBenefit.TabIndex = 57;
            this.cboBenefit.Visible = false;
            // 
            // txtMR
            // 
            this.txtMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMR.Location = new System.Drawing.Point(641, 94);
            this.txtMR.Name = "txtMR";
            this.txtMR.Size = new System.Drawing.Size(192, 24);
            this.txtMR.TabIndex = 58;
            this.txtMR.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(641, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 31);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            // 
            // frmCategorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 635);
            this.isEnterTabAllow = true;
            this.Name = "frmCategorySetup";
            this.Load += new System.EventHandler(this.frmCategorySetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtCatNameBeng;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCategoryID;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtCatName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvCategory;
        private AtiqsControlLibrary.SmartComboBox cboBenefit;
        private AtiqsControlLibrary.SmartTextBox txtMR;
        private System.Windows.Forms.Button btnSearch;
    }
}
