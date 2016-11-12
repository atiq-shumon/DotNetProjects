namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmSpecimenHolder
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
            this.txtHolderNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtHolderName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtHolderID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lvSpecHolder = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnRefreshColorCode = new System.Windows.Forms.Button();
            this.btnAddColorCode = new System.Windows.Forms.Button();
            this.cboColorCode = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboPriority = new AtiqsControlLibrary.SmartComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(281, 9);
            this.frmLabel.Size = new System.Drawing.Size(291, 33);
            this.frmLabel.Text = "Specimen Holder Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnShowAll);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.cboPriority);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.btnRefreshColorCode);
            this.pnlMain.Controls.Add(this.lvSpecHolder);
            this.pnlMain.Controls.Add(this.btnAddColorCode);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboColorCode);
            this.pnlMain.Controls.Add(this.txtHolderNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtHolderName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(863, 506);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(414, 566);
            this.btnEdit.TabIndex = 101;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(301, 566);
            this.btnSave.TabIndex = 100;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 566);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(188, 566);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(749, 566);
            this.btnClose.TabIndex = 102;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(638, 566);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 610);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(16, 97);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(135, 18);
            this.smartLabel3.TabIndex = 55;
            this.smartLabel3.Text = "Holder Name(Beng) :";
            // 
            // txtHolderNameBeng
            // 
            this.txtHolderNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHolderNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHolderNameBeng.Location = new System.Drawing.Point(159, 94);
            this.txtHolderNameBeng.Name = "txtHolderNameBeng";
            this.txtHolderNameBeng.Size = new System.Drawing.Size(554, 24);
            this.txtHolderNameBeng.TabIndex = 3;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(83, 132);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 54;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(159, 132);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(554, 62);
            this.txtRemarks.TabIndex = 4;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(55, 58);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(96, 18);
            this.smartLabel2.TabIndex = 53;
            this.smartLabel2.Text = "Holder Name :";
            // 
            // txtHolderName
            // 
            this.txtHolderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHolderName.Location = new System.Drawing.Point(159, 55);
            this.txtHolderName.Name = "txtHolderName";
            this.txtHolderName.Size = new System.Drawing.Size(554, 24);
            this.txtHolderName.TabIndex = 2;
            this.txtHolderName.TextChanged += new System.EventHandler(this.txtHolderName_TextChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(30, 583);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(75, 18);
            this.smartLabel1.TabIndex = 52;
            this.smartLabel1.Text = "Holder ID :";
            this.smartLabel1.Visible = false;
            // 
            // txtHolderID
            // 
            this.txtHolderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtHolderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHolderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHolderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHolderID.Location = new System.Drawing.Point(128, 580);
            this.txtHolderID.Name = "txtHolderID";
            this.txtHolderID.ReadOnly = true;
            this.txtHolderID.Size = new System.Drawing.Size(54, 24);
            this.txtHolderID.TabIndex = 0;
            this.txtHolderID.TabStop = false;
            this.txtHolderID.Visible = false;
            // 
            // lvSpecHolder
            // 
            this.lvSpecHolder.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvSpecHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSpecHolder.CheckBoxes = true;
            this.lvSpecHolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSpecHolder.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSpecHolder.FullRowSelect = true;
            this.lvSpecHolder.GridLines = true;
            this.lvSpecHolder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSpecHolder.Location = new System.Drawing.Point(3, 220);
            this.lvSpecHolder.Name = "lvSpecHolder";
            this.lvSpecHolder.Size = new System.Drawing.Size(859, 281);
            this.lvSpecHolder.TabIndex = 59;
            this.lvSpecHolder.TabStop = false;
            this.lvSpecHolder.UseCompatibleStateImageBehavior = false;
            this.lvSpecHolder.View = System.Windows.Forms.View.Details;
            this.lvSpecHolder.SelectedIndexChanged += new System.EventHandler(this.lvSpecHolder_SelectedIndexChanged);
            // 
            // btnRefreshColorCode
            // 
            this.btnRefreshColorCode.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshColorCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshColorCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshColorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshColorCode.ForeColor = System.Drawing.Color.White;
            this.btnRefreshColorCode.Location = new System.Drawing.Point(370, 22);
            this.btnRefreshColorCode.Name = "btnRefreshColorCode";
            this.btnRefreshColorCode.Size = new System.Drawing.Size(30, 28);
            this.btnRefreshColorCode.TabIndex = 96;
            this.btnRefreshColorCode.TabStop = false;
            this.btnRefreshColorCode.Text = "..";
            this.btnRefreshColorCode.UseVisualStyleBackColor = false;
            this.btnRefreshColorCode.Click += new System.EventHandler(this.btnRefreshColorCode_Click);
            // 
            // btnAddColorCode
            // 
            this.btnAddColorCode.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddColorCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddColorCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddColorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColorCode.ForeColor = System.Drawing.Color.White;
            this.btnAddColorCode.Location = new System.Drawing.Point(335, 22);
            this.btnAddColorCode.Name = "btnAddColorCode";
            this.btnAddColorCode.Size = new System.Drawing.Size(32, 28);
            this.btnAddColorCode.TabIndex = 95;
            this.btnAddColorCode.TabStop = false;
            this.btnAddColorCode.Text = "+";
            this.btnAddColorCode.UseVisualStyleBackColor = false;
            this.btnAddColorCode.Click += new System.EventHandler(this.btnAddColorCode_Click);
            // 
            // cboColorCode
            // 
            this.cboColorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColorCode.ForeColor = System.Drawing.Color.Blue;
            this.cboColorCode.FormattingEnabled = true;
            this.cboColorCode.Location = new System.Drawing.Point(159, 23);
            this.cboColorCode.Name = "cboColorCode";
            this.cboColorCode.Size = new System.Drawing.Size(171, 26);
            this.cboColorCode.TabIndex = 0;
            this.cboColorCode.SelectedIndexChanged += new System.EventHandler(this.cboColorCode_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(71, 23);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(80, 18);
            this.smartLabel4.TabIndex = 97;
            this.smartLabel4.Text = "Color Code :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(577, 24);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(58, 18);
            this.smartLabel6.TabIndex = 98;
            this.smartLabel6.Text = "Priority :";
            // 
            // cboPriority
            // 
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPriority.ForeColor = System.Drawing.Color.Blue;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(637, 24);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(76, 26);
            this.cboPriority.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(406, 22);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(67, 28);
            this.btnShow.TabIndex = 162;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show Result Head";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(479, 23);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(92, 28);
            this.btnShowAll.TabIndex = 163;
            this.btnShowAll.TabStop = false;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // frmSpecimenHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 635);
            this.Controls.Add(this.txtHolderID);
            this.Controls.Add(this.smartLabel1);
            this.isEnterTabAllow = true;
            this.Name = "frmSpecimenHolder";
            this.Load += new System.EventHandler(this.frmSpecimenHolder_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.txtHolderID, 0);
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

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtHolderNameBeng;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHolderID;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtHolderName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvSpecHolder;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.Button btnRefreshColorCode;
        private System.Windows.Forms.Button btnAddColorCode;
        private AtiqsControlLibrary.SmartComboBox cboColorCode;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboPriority;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShowAll;
    }
}
