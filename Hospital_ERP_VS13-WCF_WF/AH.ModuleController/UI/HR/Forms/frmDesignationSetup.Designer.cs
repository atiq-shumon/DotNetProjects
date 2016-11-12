namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmDesignationSetup
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
            this.txtDesigID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDesigName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDesigNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.cboDesigGroup = new AtiqsControlLibrary.SmartComboBox();
            this.lvDsig = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboDesigParent = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshParent = new System.Windows.Forms.Button();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtDesigLevel = new AtiqsControlLibrary.SmartNumericTextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(735, 4);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(447, 7);
            this.frmLabel.Size = new System.Drawing.Size(230, 33);
            this.frmLabel.Text = "Designation Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnShowAll);
            this.pnlMain.Controls.Add(this.txtDesigLevel);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.btnRefreshParent);
            this.pnlMain.Controls.Add(this.cboDesigParent);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.lvDsig);
            this.pnlMain.Controls.Add(this.cboDesigGroup);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDesigNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtDesigName);
            this.pnlMain.Location = new System.Drawing.Point(0, 52);
            this.pnlMain.Size = new System.Drawing.Size(1082, 714);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1082, 52);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(733, 772);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(619, 772);
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(269, 772);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(505, 772);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(963, 772);
            this.btnClose.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(849, 772);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 812);
            this.groupBox1.Size = new System.Drawing.Size(1082, 23);
            // 
            // txtDesigID
            // 
            this.txtDesigID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtDesigID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesigID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesigID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDesigID.Location = new System.Drawing.Point(131, 782);
            this.txtDesigID.Name = "txtDesigID";
            this.txtDesigID.ReadOnly = true;
            this.txtDesigID.Size = new System.Drawing.Size(85, 24);
            this.txtDesigID.TabIndex = 0;
            this.txtDesigID.TabStop = false;
            this.txtDesigID.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(63, 784);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(68, 18);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Desig ID :";
            this.smartLabel1.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(8, 63);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(89, 18);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Desig Name :";
            // 
            // txtDesigName
            // 
            this.txtDesigName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesigName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesigName.Location = new System.Drawing.Point(8, 85);
            this.txtDesigName.Name = "txtDesigName";
            this.txtDesigName.Size = new System.Drawing.Size(607, 24);
            this.txtDesigName.TabIndex = 1;
            this.txtDesigName.TextChanged += new System.EventHandler(this.txtDesigName_TextChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(8, 113);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(142, 18);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Desig Name (Bangla) :";
            // 
            // txtDesigNameBeng
            // 
            this.txtDesigNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesigNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesigNameBeng.Location = new System.Drawing.Point(8, 135);
            this.txtDesigNameBeng.Name = "txtDesigNameBeng";
            this.txtDesigNameBeng.Size = new System.Drawing.Size(607, 24);
            this.txtDesigNameBeng.TabIndex = 2;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(764, 11);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(91, 18);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Desig Group :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(987, 11);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(85, 18);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "Desig Level :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(620, 63);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(68, 18);
            this.smartLabel6.TabIndex = 12;
            this.smartLabel6.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(621, 85);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(451, 74);
            this.txtRemarks.TabIndex = 6;
            this.txtRemarks.Text = "N/A";
            // 
            // cboDesigGroup
            // 
            this.cboDesigGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesigGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDesigGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDesigGroup.FormattingEnabled = true;
            this.cboDesigGroup.Location = new System.Drawing.Point(767, 32);
            this.cboDesigGroup.Name = "cboDesigGroup";
            this.cboDesigGroup.Size = new System.Drawing.Size(217, 26);
            this.cboDesigGroup.TabIndex = 4;
            // 
            // lvDsig
            // 
            this.lvDsig.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDsig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDsig.CheckBoxes = true;
            this.lvDsig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDsig.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDsig.FullRowSelect = true;
            this.lvDsig.GridLines = true;
            this.lvDsig.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDsig.Location = new System.Drawing.Point(1, 190);
            this.lvDsig.Name = "lvDsig";
            this.lvDsig.Size = new System.Drawing.Size(1078, 523);
            this.lvDsig.TabIndex = 42;
            this.lvDsig.UseCompatibleStateImageBehavior = false;
            this.lvDsig.View = System.Windows.Forms.View.Details;
            this.lvDsig.SelectedIndexChanged += new System.EventHandler(this.lvDsig_SelectedIndexChanged);
            this.lvDsig.Click += new System.EventHandler(this.lvDsig_Click);
            // 
            // cboDesigParent
            // 
            this.cboDesigParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesigParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDesigParent.ForeColor = System.Drawing.Color.Blue;
            this.cboDesigParent.FormattingEnabled = true;
            this.cboDesigParent.Location = new System.Drawing.Point(8, 32);
            this.cboDesigParent.Name = "cboDesigParent";
            this.cboDesigParent.Size = new System.Drawing.Size(392, 26);
            this.cboDesigParent.TabIndex = 0;
            this.cboDesigParent.SelectedIndexChanged += new System.EventHandler(this.cboDesigParent_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(5, 11);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(91, 18);
            this.smartLabel7.TabIndex = 44;
            this.smartLabel7.Text = "Desig Parent :";
            // 
            // btnRefreshParent
            // 
            this.btnRefreshParent.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshParent.ForeColor = System.Drawing.Color.White;
            this.btnRefreshParent.Location = new System.Drawing.Point(406, 31);
            this.btnRefreshParent.Name = "btnRefreshParent";
            this.btnRefreshParent.Size = new System.Drawing.Size(35, 26);
            this.btnRefreshParent.TabIndex = 49;
            this.btnRefreshParent.Text = "--";
            this.btnRefreshParent.UseVisualStyleBackColor = false;
            this.btnRefreshParent.Click += new System.EventHandler(this.btnRefreshParent_Click);
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(621, 32);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(140, 26);
            this.cboDepartmentType.TabIndex = 3;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(620, 11);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(83, 18);
            this.smartLabel9.TabIndex = 196;
            this.smartLabel9.Text = "Desig Type :";
            // 
            // txtDesigLevel
            // 
            this.txtDesigLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesigLevel.Enabled = false;
            this.txtDesigLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesigLevel.Location = new System.Drawing.Point(990, 32);
            this.txtDesigLevel.Name = "txtDesigLevel";
            this.txtDesigLevel.Size = new System.Drawing.Size(82, 24);
            this.txtDesigLevel.TabIndex = 5;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(444, 30);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(171, 27);
            this.btnShowAll.TabIndex = 198;
            this.btnShowAll.Text = "Show All Designation";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // frmDesignationSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1082, 835);
            this.Controls.Add(this.txtDesigID);
            this.Controls.Add(this.smartLabel1);
            this.isEnterTabAllow = true;
            this.Name = "frmDesignationSetup";
            this.Load += new System.EventHandler(this.frmDesignationSetup_Load);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.Controls.SetChildIndex(this.txtDesigID, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDesigNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDesigName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDesigID;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartComboBox cboDesigGroup;
        private AtiqsControlLibrary.SmartListViewDetails lvDsig;
        private AtiqsControlLibrary.SmartComboBox cboDesigParent;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private System.Windows.Forms.Button btnRefreshParent;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartNumericTextBox txtDesigLevel;
        private System.Windows.Forms.Button btnShowAll;
    }
}
