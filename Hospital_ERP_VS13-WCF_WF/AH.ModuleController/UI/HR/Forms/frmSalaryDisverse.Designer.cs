namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmSalaryDisverse
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
            this.cboYear = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboMonthID = new AtiqsControlLibrary.SmartComboBox();
            this.btnDisburse = new System.Windows.Forms.Button();
            this.chkDisverse = new AtiqsControlLibrary.SmartCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lblBank = new AtiqsControlLibrary.SmartLabel();
            this.lblCash = new AtiqsControlLibrary.SmartLabel();
            this.lblOthers = new AtiqsControlLibrary.SmartLabel();
            this.lblTotal = new AtiqsControlLibrary.SmartLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(169, 9);
            this.frmLabel.Size = new System.Drawing.Size(334, 33);
            this.frmLabel.Text = "Salary Disbursement Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.chkDisverse);
            this.pnlMain.Controls.Add(this.btnDisburse);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboMonthID);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboYear);
            this.pnlMain.Size = new System.Drawing.Size(678, 517);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(679, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(9, 436);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 436);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(6, 440);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(9, 436);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(565, 436);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(454, 436);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 479);
            this.groupBox1.Size = new System.Drawing.Size(679, 25);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(61, 190);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(41, 13);
            this.smartLabel2.TabIndex = 8;
            this.smartLabel2.Text = "Year :";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Blue;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(108, 183);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(143, 26);
            this.cboYear.TabIndex = 7;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(52, 247);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(50, 13);
            this.smartLabel1.TabIndex = 10;
            this.smartLabel1.Text = "Month :";
            // 
            // cboMonthID
            // 
            this.cboMonthID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonthID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonthID.ForeColor = System.Drawing.Color.Blue;
            this.cboMonthID.FormattingEnabled = true;
            this.cboMonthID.Location = new System.Drawing.Point(108, 240);
            this.cboMonthID.Name = "cboMonthID";
            this.cboMonthID.Size = new System.Drawing.Size(143, 26);
            this.cboMonthID.TabIndex = 9;
            // 
            // btnDisburse
            // 
            this.btnDisburse.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDisburse.Enabled = false;
            this.btnDisburse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisburse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisburse.ForeColor = System.Drawing.Color.White;
            this.btnDisburse.Location = new System.Drawing.Point(108, 346);
            this.btnDisburse.Name = "btnDisburse";
            this.btnDisburse.Size = new System.Drawing.Size(143, 32);
            this.btnDisburse.TabIndex = 11;
            this.btnDisburse.Text = "Salary Disburse";
            this.btnDisburse.UseVisualStyleBackColor = false;
            this.btnDisburse.Click += new System.EventHandler(this.btnDisburse_Click);
            // 
            // chkDisverse
            // 
            this.chkDisverse.AutoSize = true;
            this.chkDisverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDisverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDisverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisverse.ForeColor = System.Drawing.Color.Black;
            this.chkDisverse.Location = new System.Drawing.Point(108, 295);
            this.chkDisverse.Name = "chkDisverse";
            this.chkDisverse.Size = new System.Drawing.Size(140, 22);
            this.chkDisverse.TabIndex = 12;
            this.chkDisverse.Text = "Salary Disburse ?";
            this.chkDisverse.UseVisualStyleBackColor = true;
            this.chkDisverse.CheckedChanged += new System.EventHandler(this.chkDisverse_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblOthers);
            this.groupBox2.Controls.Add(this.lblCash);
            this.groupBox2.Controls.Add(this.lblBank);
            this.groupBox2.Controls.Add(this.smartLabel13);
            this.groupBox2.Controls.Add(this.smartLabel11);
            this.groupBox2.Controls.Add(this.smartLabel10);
            this.groupBox2.Controls.Add(this.smartLabel9);
            this.groupBox2.Controls.Add(this.smartLabel8);
            this.groupBox2.Controls.Add(this.smartLabel7);
            this.groupBox2.Controls.Add(this.smartLabel6);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(299, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 245);
            this.groupBox2.TabIndex = 196;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accounts";
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(131, 185);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(13, 18);
            this.smartLabel13.TabIndex = 16;
            this.smartLabel13.Text = ":";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(131, 130);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(13, 18);
            this.smartLabel11.TabIndex = 15;
            this.smartLabel11.Text = ":";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(131, 85);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(13, 18);
            this.smartLabel10.TabIndex = 14;
            this.smartLabel10.Text = ":";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(131, 40);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(13, 18);
            this.smartLabel9.TabIndex = 13;
            this.smartLabel9.Text = ":";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(8, 185);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(108, 18);
            this.smartLabel8.TabIndex = 12;
            this.smartLabel8.Text = "Total Amount";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(8, 130);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(121, 18);
            this.smartLabel7.TabIndex = 11;
            this.smartLabel7.Text = "Others Amount";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(8, 85);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(109, 18);
            this.smartLabel6.TabIndex = 10;
            this.smartLabel6.Text = "Cash Amount";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(8, 40);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(108, 18);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "Bank Amount";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBank.Location = new System.Drawing.Point(150, 40);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(17, 18);
            this.lblBank.TabIndex = 17;
            this.lblBank.Text = "0";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCash.Location = new System.Drawing.Point(150, 85);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(17, 18);
            this.lblCash.TabIndex = 18;
            this.lblCash.Text = "0";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblOthers.Location = new System.Drawing.Point(150, 130);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(17, 18);
            this.lblOthers.TabIndex = 19;
            this.lblOthers.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(150, 185);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 18);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(11, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 2);
            this.panel2.TabIndex = 132;
            // 
            // frmSalaryDisverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(679, 504);
            this.isEnterTabAllow = true;
            this.Name = "frmSalaryDisverse";
            this.Load += new System.EventHandler(this.frmSalaryDisverse_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboYear;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboMonthID;
        private AtiqsControlLibrary.SmartCheckBox chkDisverse;
        private System.Windows.Forms.Button btnDisburse;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel lblBank;
        private AtiqsControlLibrary.SmartLabel lblCash;
        private AtiqsControlLibrary.SmartLabel lblOthers;
        private AtiqsControlLibrary.SmartLabel lblTotal;
        private System.Windows.Forms.Panel panel2;
    }
}
