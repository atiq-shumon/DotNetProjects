namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmDiagnosticMainSetup
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
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboGroupID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtMainTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtMainTitle = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.lvDiagMain = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtMainID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(277, 33);
            this.frmLabel.Text = "Diagnostic Main Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.txtMainID);
            this.pnlMain.Controls.Add(this.lvDiagMain);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboDeptID);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboGroupID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtMainTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtMainTitle);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(863, 508);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(419, 566);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 566);
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(532, 566);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(193, 566);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(754, 566);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(643, 566);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 612);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(38, 130);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 21;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(38, 151);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(673, 63);
            this.txtRemarks.TabIndex = 5;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(372, 11);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(53, 18);
            this.smartLabel4.TabIndex = 19;
            this.smartLabel4.Text = "Group :";
            // 
            // cboGroupID
            // 
            this.cboGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupID.ForeColor = System.Drawing.Color.Blue;
            this.cboGroupID.FormattingEnabled = true;
            this.cboGroupID.Location = new System.Drawing.Point(375, 36);
            this.cboGroupID.Name = "cboGroupID";
            this.cboGroupID.Size = new System.Drawing.Size(336, 26);
            this.cboGroupID.TabIndex = 4;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(372, 77);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(154, 18);
            this.smartLabel3.TabIndex = 17;
            this.smartLabel3.Text = "Test Main Name(Beng) :";
            // 
            // txtMainTitleBeng
            // 
            this.txtMainTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMainTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainTitleBeng.Location = new System.Drawing.Point(375, 98);
            this.txtMainTitleBeng.Name = "txtMainTitleBeng";
            this.txtMainTitleBeng.Size = new System.Drawing.Size(336, 24);
            this.txtMainTitleBeng.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(38, 77);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(115, 18);
            this.smartLabel2.TabIndex = 14;
            this.smartLabel2.Text = "Test Main Name :";
            // 
            // txtMainTitle
            // 
            this.txtMainTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainTitle.Location = new System.Drawing.Point(38, 98);
            this.txtMainTitle.Name = "txtMainTitle";
            this.txtMainTitle.Size = new System.Drawing.Size(328, 24);
            this.txtMainTitle.TabIndex = 1;
            this.txtMainTitle.TextChanged += new System.EventHandler(this.txtMainTitle_TextChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(38, 11);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(94, 18);
            this.smartLabel1.TabIndex = 12;
            this.smartLabel1.Text = "Test Main ID :";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(156, 11);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(87, 18);
            this.smartLabel6.TabIndex = 23;
            this.smartLabel6.Text = "Department :";
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(159, 36);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(210, 26);
            this.cboDeptID.TabIndex = 3;
            this.cboDeptID.SelectedIndexChanged += new System.EventHandler(this.cboDeptID_SelectedIndexChanged);
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
            this.lvDiagMain.Location = new System.Drawing.Point(-1, 238);
            this.lvDiagMain.Name = "lvDiagMain";
            this.lvDiagMain.Size = new System.Drawing.Size(863, 267);
            this.lvDiagMain.TabIndex = 45;
            this.lvDiagMain.TabStop = false;
            this.lvDiagMain.UseCompatibleStateImageBehavior = false;
            this.lvDiagMain.View = System.Windows.Forms.View.Details;
            this.lvDiagMain.SelectedIndexChanged += new System.EventHandler(this.lvDiagMain_SelectedIndexChanged);
            this.lvDiagMain.Click += new System.EventHandler(this.lvDiagMain_Click);
            // 
            // txtMainID
            // 
            this.txtMainID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtMainID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMainID.Location = new System.Drawing.Point(38, 36);
            this.txtMainID.Name = "txtMainID";
            this.txtMainID.ReadOnly = true;
            this.txtMainID.Size = new System.Drawing.Size(112, 24);
            this.txtMainID.TabIndex = 46;
            this.txtMainID.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(717, 34);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 28);
            this.btnShow.TabIndex = 78;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmDiagnosticMainSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 635);
            this.isEnterTabAllow = true;
            this.Name = "frmDiagnosticMainSetup";
            this.Load += new System.EventHandler(this.frmDiagnosticMainSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboGroupID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtMainTitleBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtMainTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartListViewDetails lvDiagMain;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMainID;
        private System.Windows.Forms.Button btnShow;

    }
}
