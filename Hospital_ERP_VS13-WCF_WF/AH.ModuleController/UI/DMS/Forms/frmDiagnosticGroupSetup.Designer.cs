namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmDiagnosticGroupSetup
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtGroupTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtGroupTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvDiagGrp = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtGroupID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(827, 4);
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(294, 33);
            this.frmLabel.Text = "Diagnostic Group Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.txtGroupID);
            this.pnlMain.Controls.Add(this.lvDiagGrp);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboDeptID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtGroupTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtGroupTitle);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(898, 465);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(898, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(445, 522);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 522);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(559, 522);
            this.btnDelete.Size = new System.Drawing.Size(108, 40);
            this.btnDelete.TabIndex = 41;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(217, 522);
            this.btnNew.TabIndex = 25;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(787, 522);
            this.btnClose.TabIndex = 50;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(673, 522);
            this.btnPrint.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 562);
            this.groupBox1.Size = new System.Drawing.Size(898, 23);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(169, 19);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(72, 18);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Group ID :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(169, 57);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(84, 18);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Group Title :";
            // 
            // txtGroupTitle
            // 
            this.txtGroupTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupTitle.Location = new System.Drawing.Point(259, 54);
            this.txtGroupTitle.Name = "txtGroupTitle";
            this.txtGroupTitle.Size = new System.Drawing.Size(418, 24);
            this.txtGroupTitle.TabIndex = 1;
            this.txtGroupTitle.TextChanged += new System.EventHandler(this.txtGroupTitle_TextChanged);
            // 
            // txtGroupTitleBeng
            // 
            this.txtGroupTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupTitleBeng.Location = new System.Drawing.Point(259, 95);
            this.txtGroupTitleBeng.Name = "txtGroupTitleBeng";
            this.txtGroupTitleBeng.Size = new System.Drawing.Size(418, 24);
            this.txtGroupTitleBeng.TabIndex = 2;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(137, 95);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(118, 18);
            this.smartLabel3.TabIndex = 6;
            this.smartLabel3.Text = "Group Title Beng :";
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(472, 14);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(205, 26);
            this.cboDeptID.TabIndex = 3;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(379, 18);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(87, 18);
            this.smartLabel4.TabIndex = 8;
            this.smartLabel4.Text = "Department :";
            this.smartLabel4.Click += new System.EventHandler(this.smartLabel4_Click);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(178, 131);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 10;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(259, 131);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(418, 64);
            this.txtRemarks.TabIndex = 4;
            // 
            // lvDiagGrp
            // 
            this.lvDiagGrp.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDiagGrp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDiagGrp.CheckBoxes = true;
            this.lvDiagGrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDiagGrp.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDiagGrp.FullRowSelect = true;
            this.lvDiagGrp.GridLines = true;
            this.lvDiagGrp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDiagGrp.Location = new System.Drawing.Point(-1, 212);
            this.lvDiagGrp.Name = "lvDiagGrp";
            this.lvDiagGrp.Size = new System.Drawing.Size(898, 252);
            this.lvDiagGrp.TabIndex = 44;
            this.lvDiagGrp.TabStop = false;
            this.lvDiagGrp.UseCompatibleStateImageBehavior = false;
            this.lvDiagGrp.View = System.Windows.Forms.View.Details;
            this.lvDiagGrp.SelectedIndexChanged += new System.EventHandler(this.lvDiagGrp_SelectedIndexChanged);
            this.lvDiagGrp.Click += new System.EventHandler(this.lvDiagGrp_Click);
            // 
            // txtGroupID
            // 
            this.txtGroupID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtGroupID.Location = new System.Drawing.Point(259, 15);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.ReadOnly = true;
            this.txtGroupID.Size = new System.Drawing.Size(114, 24);
            this.txtGroupID.TabIndex = 45;
            this.txtGroupID.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(683, 13);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 28);
            this.btnShow.TabIndex = 78;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmDiagnosticGroupSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(898, 585);
            this.isEnterTabAllow = true;
            this.Name = "frmDiagnosticGroupSetup";
            this.Load += new System.EventHandler(this.frmDiagnosticGroupSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtGroupTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtGroupTitleBeng;
        private AtiqsControlLibrary.SmartListViewDetails lvDiagGrp;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtGroupID;
        private System.Windows.Forms.Button btnShow;
    }
}
