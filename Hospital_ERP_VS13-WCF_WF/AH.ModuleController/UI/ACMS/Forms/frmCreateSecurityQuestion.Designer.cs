namespace AH.ModuleController.UI.ACMS.Forms
{
    partial class frmCreateSecurityQuestion
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
            this.txtQTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtQTitleBangla = new AtiqsControlLibrary.SmartTextBox();
            this.txtQRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvSecQuestion = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtQID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(222, 33);
            this.frmLabel.Text = "Security Question";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtQID);
            this.pnlMain.Controls.Add(this.lvSecQuestion);
            this.pnlMain.Controls.Add(this.txtQRemarks);
            this.pnlMain.Controls.Add(this.txtQTitleBangla);
            this.pnlMain.Controls.Add(this.txtQTitle);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(849, 491);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(849, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(509, 555);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(396, 555);
            this.btnSave.TabIndex = 0;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(622, 555);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(283, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(736, 555);
            this.btnClose.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(22, 553);
            this.btnPrint.Size = new System.Drawing.Size(30, 26);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 594);
            this.groupBox1.Size = new System.Drawing.Size(849, 23);
            // 
            // txtQTitle
            // 
            this.txtQTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTitle.Location = new System.Drawing.Point(205, 40);
            this.txtQTitle.Name = "txtQTitle";
            this.txtQTitle.Size = new System.Drawing.Size(357, 24);
            this.txtQTitle.TabIndex = 1;
            this.txtQTitle.TextChanged += new System.EventHandler(this.txtQTitle_TextChanged);
            this.txtQTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQTitle_KeyDown);
            // 
            // txtQTitleBangla
            // 
            this.txtQTitleBangla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQTitleBangla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTitleBangla.Location = new System.Drawing.Point(205, 68);
            this.txtQTitleBangla.Name = "txtQTitleBangla";
            this.txtQTitleBangla.Size = new System.Drawing.Size(357, 24);
            this.txtQTitleBangla.TabIndex = 2;
            this.txtQTitleBangla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQTitleBangla_KeyDown);
            // 
            // txtQRemarks
            // 
            this.txtQRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQRemarks.Location = new System.Drawing.Point(205, 102);
            this.txtQRemarks.Multiline = true;
            this.txtQRemarks.Name = "txtQRemarks";
            this.txtQRemarks.Size = new System.Drawing.Size(357, 30);
            this.txtQRemarks.TabIndex = 3;
            this.txtQRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQRemarks_KeyDown);
            // 
            // lvSecQuestion
            // 
            this.lvSecQuestion.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvSecQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSecQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSecQuestion.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSecQuestion.FullRowSelect = true;
            this.lvSecQuestion.GridLines = true;
            this.lvSecQuestion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSecQuestion.Location = new System.Drawing.Point(-1, 141);
            this.lvSecQuestion.Name = "lvSecQuestion";
            this.lvSecQuestion.Size = new System.Drawing.Size(849, 347);
            this.lvSecQuestion.TabIndex = 6;
            this.lvSecQuestion.UseCompatibleStateImageBehavior = false;
            this.lvSecQuestion.View = System.Windows.Forms.View.Details;
            this.lvSecQuestion.SelectedIndexChanged += new System.EventHandler(this.lvSecQuestion_SelectedIndexChanged);
            // 
            // txtQID
            // 
            this.txtQID.BackColor = System.Drawing.Color.Linen;
            this.txtQID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtQID.Location = new System.Drawing.Point(205, 10);
            this.txtQID.Name = "txtQID";
            this.txtQID.ReadOnly = true;
            this.txtQID.Size = new System.Drawing.Size(216, 24);
            this.txtQID.TabIndex = 0;
            this.txtQID.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(91, 107);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(56, 13);
            this.smartLabel1.TabIndex = 9;
            this.smartLabel1.Text = "Remarks";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(18, 73);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(129, 13);
            this.smartLabel2.TabIndex = 10;
            this.smartLabel2.Text = "Question Title Bangla";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(57, 47);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(86, 13);
            this.smartLabel3.TabIndex = 11;
            this.smartLabel3.Text = "Question Title";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(123, 16);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(20, 13);
            this.smartLabel4.TabIndex = 12;
            this.smartLabel4.Text = "ID";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(157, 16);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(12, 16);
            this.smartLabel5.TabIndex = 13;
            this.smartLabel5.Text = ":";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(157, 46);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(12, 16);
            this.smartLabel6.TabIndex = 13;
            this.smartLabel6.Text = ":";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(157, 72);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(12, 16);
            this.smartLabel7.TabIndex = 13;
            this.smartLabel7.Text = ":";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(157, 104);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(12, 16);
            this.smartLabel8.TabIndex = 13;
            this.smartLabel8.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(566, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 194;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(566, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 195;
            this.label1.Text = "*";
            // 
            // frmCreateSecurityQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 617);
            this.isEnterTabAllow = true;
            this.Name = "frmCreateSecurityQuestion";
            this.Load += new System.EventHandler(this.frmCreateSecurityQuestion_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvSecQuestion;
        private AtiqsControlLibrary.SmartTextBox txtQRemarks;
        private AtiqsControlLibrary.SmartTextBox txtQTitleBangla;
        private AtiqsControlLibrary.SmartTextBox txtQTitle;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtQID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
