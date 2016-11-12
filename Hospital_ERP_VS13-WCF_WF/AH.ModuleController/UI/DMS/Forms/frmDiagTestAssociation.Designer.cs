namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmDiagTestAssociation
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
            this.btnShow = new System.Windows.Forms.Button();
            this.cboMainID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboFeeCatID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboGroupID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboDetailID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvDiagMain = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(803, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(259, 10);
            this.frmLabel.Size = new System.Drawing.Size(336, 33);
            this.frmLabel.Text = "Diagnostic Test Association";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvDiagMain);
            this.pnlMain.Controls.Add(this.cboDetailID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.cboMainID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboFeeCatID);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboDeptID);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboGroupID);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 52);
            this.pnlMain.Size = new System.Drawing.Size(880, 533);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(880, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(427, 591);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 591);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(541, 591);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(199, 590);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(769, 591);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(655, 591);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 630);
            this.groupBox1.Size = new System.Drawing.Size(880, 23);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(781, 103);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(68, 28);
            this.btnShow.TabIndex = 85;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // cboMainID
            // 
            this.cboMainID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMainID.ForeColor = System.Drawing.Color.Blue;
            this.cboMainID.FormattingEnabled = true;
            this.cboMainID.Location = new System.Drawing.Point(568, 39);
            this.cboMainID.Name = "cboMainID";
            this.cboMainID.Size = new System.Drawing.Size(282, 26);
            this.cboMainID.TabIndex = 79;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(580, 80);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(91, 18);
            this.smartLabel3.TabIndex = 84;
            this.smartLabel3.Text = "Fee Category :";
            // 
            // cboFeeCatID
            // 
            this.cboFeeCatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFeeCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFeeCatID.ForeColor = System.Drawing.Color.Blue;
            this.cboFeeCatID.FormattingEnabled = true;
            this.cboFeeCatID.Location = new System.Drawing.Point(582, 105);
            this.cboFeeCatID.Name = "cboFeeCatID";
            this.cboFeeCatID.Size = new System.Drawing.Size(193, 26);
            this.cboFeeCatID.TabIndex = 80;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(29, 16);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(87, 18);
            this.smartLabel7.TabIndex = 83;
            this.smartLabel7.Text = "Department :";
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(29, 39);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(229, 26);
            this.cboDeptID.TabIndex = 77;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(275, 16);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(53, 18);
            this.smartLabel6.TabIndex = 82;
            this.smartLabel6.Text = "Group :";
            // 
            // cboGroupID
            // 
            this.cboGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupID.ForeColor = System.Drawing.Color.Blue;
            this.cboGroupID.FormattingEnabled = true;
            this.cboGroupID.Location = new System.Drawing.Point(264, 39);
            this.cboGroupID.Name = "cboGroupID";
            this.cboGroupID.Size = new System.Drawing.Size(298, 26);
            this.cboGroupID.TabIndex = 78;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(573, 18);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(46, 18);
            this.smartLabel2.TabIndex = 81;
            this.smartLabel2.Text = "Main :";
            // 
            // cboDetailID
            // 
            this.cboDetailID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDetailID.ForeColor = System.Drawing.Color.Blue;
            this.cboDetailID.FormattingEnabled = true;
            this.cboDetailID.Location = new System.Drawing.Point(28, 105);
            this.cboDetailID.Name = "cboDetailID";
            this.cboDetailID.Size = new System.Drawing.Size(548, 26);
            this.cboDetailID.TabIndex = 86;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(29, 82);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 18);
            this.smartLabel1.TabIndex = 87;
            this.smartLabel1.Text = "Test Details :";
            // 
            // lvDiagMain
            // 
            this.lvDiagMain.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDiagMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDiagMain.CheckBoxes = true;
            this.lvDiagMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDiagMain.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDiagMain.FullRowSelect = true;
            this.lvDiagMain.GridLines = true;
            this.lvDiagMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDiagMain.Location = new System.Drawing.Point(-1, 171);
            this.lvDiagMain.Name = "lvDiagMain";
            this.lvDiagMain.Size = new System.Drawing.Size(880, 360);
            this.lvDiagMain.TabIndex = 88;
            this.lvDiagMain.TabStop = false;
            this.lvDiagMain.UseCompatibleStateImageBehavior = false;
            this.lvDiagMain.View = System.Windows.Forms.View.Details;
            this.lvDiagMain.Click += new System.EventHandler(this.lvDiagMain_Click);
            // 
            // frmDiagTestAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(880, 653);
            this.Name = "frmDiagTestAssociation";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartComboBox cboMainID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboFeeCatID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboGroupID;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboDetailID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvDiagMain;
    }
}
