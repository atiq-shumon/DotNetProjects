namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmMealIssued
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMealIssued));
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtEmpID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtDesName = new AtiqsControlLibrary.SmartTextBox();
            this.txtDepName = new AtiqsControlLibrary.SmartTextBox();
            this.txtEmpName = new AtiqsControlLibrary.SmartTextBox();
            this.txtParticulars = new System.Windows.Forms.TextBox();
            this.txtsystemTime = new System.Windows.Forms.TextBox();
            this.txtWeekDayName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtweekdayno = new AtiqsControlLibrary.SmartTextBox();
            this.txtParID = new AtiqsControlLibrary.SmartTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(238, 9);
            this.frmLabel.Size = new System.Drawing.Size(261, 33);
            this.frmLabel.Text = "Meal Issued Register";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.txtweekdayno);
            this.pnlMain.Controls.Add(this.txtParID);
            this.pnlMain.Controls.Add(this.txtParticulars);
            this.pnlMain.Controls.Add(this.txtsystemTime);
            this.pnlMain.Controls.Add(this.txtWeekDayName);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtDesName);
            this.pnlMain.Controls.Add(this.txtDepName);
            this.pnlMain.Controls.Add(this.txtEmpName);
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(771, 398);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(774, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(349, 314);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(549, 315);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 316);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(439, 315);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(660, 315);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(315, 315);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 361);
            this.groupBox1.Size = new System.Drawing.Size(774, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(8, 211);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(57, 13);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Card No:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(77, 207);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(337, 24);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpID_KeyPress);
            this.txtEmpID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmpID_KeyUp);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(461, 330);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(87, 14);
            this.smartLabel10.TabIndex = 55;
            this.smartLabel10.Text = "Des.  Name:";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(461, 281);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(88, 14);
            this.smartLabel9.TabIndex = 54;
            this.smartLabel9.Text = "Dep.  Name:";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(461, 227);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(86, 14);
            this.smartLabel8.TabIndex = 53;
            this.smartLabel8.Text = "Emp. Name:";
            // 
            // txtDesName
            // 
            this.txtDesName.BackColor = System.Drawing.Color.White;
            this.txtDesName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesName.Enabled = false;
            this.txtDesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDesName.Location = new System.Drawing.Point(461, 353);
            this.txtDesName.Name = "txtDesName";
            this.txtDesName.Size = new System.Drawing.Size(270, 24);
            this.txtDesName.TabIndex = 52;
            // 
            // txtDepName
            // 
            this.txtDepName.BackColor = System.Drawing.Color.White;
            this.txtDepName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepName.Enabled = false;
            this.txtDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDepName.Location = new System.Drawing.Point(461, 301);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(267, 24);
            this.txtDepName.TabIndex = 51;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.Color.White;
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEmpName.Location = new System.Drawing.Point(461, 250);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(266, 24);
            this.txtEmpName.TabIndex = 50;
            // 
            // txtParticulars
            // 
            this.txtParticulars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtParticulars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParticulars.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticulars.Location = new System.Drawing.Point(77, 150);
            this.txtParticulars.Name = "txtParticulars";
            this.txtParticulars.Size = new System.Drawing.Size(221, 39);
            this.txtParticulars.TabIndex = 64;
            // 
            // txtsystemTime
            // 
            this.txtsystemTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtsystemTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsystemTime.Enabled = false;
            this.txtsystemTime.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsystemTime.ForeColor = System.Drawing.Color.Red;
            this.txtsystemTime.Location = new System.Drawing.Point(568, 187);
            this.txtsystemTime.Name = "txtsystemTime";
            this.txtsystemTime.Size = new System.Drawing.Size(177, 37);
            this.txtsystemTime.TabIndex = 63;
            this.txtsystemTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeekDayName
            // 
            this.txtWeekDayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtWeekDayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeekDayName.Enabled = false;
            this.txtWeekDayName.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeekDayName.ForeColor = System.Drawing.Color.Red;
            this.txtWeekDayName.Location = new System.Drawing.Point(554, 148);
            this.txtWeekDayName.Name = "txtWeekDayName";
            this.txtWeekDayName.Size = new System.Drawing.Size(211, 37);
            this.txtWeekDayName.TabIndex = 62;
            this.txtWeekDayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtweekdayno
            // 
            this.txtweekdayno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtweekdayno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweekdayno.Location = new System.Drawing.Point(356, 152);
            this.txtweekdayno.Name = "txtweekdayno";
            this.txtweekdayno.Size = new System.Drawing.Size(42, 24);
            this.txtweekdayno.TabIndex = 66;
            this.txtweekdayno.Visible = false;
            // 
            // txtParID
            // 
            this.txtParID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParID.Location = new System.Drawing.Point(420, 150);
            this.txtParID.Name = "txtParID";
            this.txtParID.Size = new System.Drawing.Size(53, 24);
            this.txtParID.TabIndex = 65;
            this.txtParID.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 111);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // frmMealIssued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(774, 386);
            this.isEnterTabAllow = true;
            this.Name = "frmMealIssued";
            this.Load += new System.EventHandler(this.frmMealIssued_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtEmpID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartTextBox txtDesName;
        private AtiqsControlLibrary.SmartTextBox txtDepName;
        private AtiqsControlLibrary.SmartTextBox txtEmpName;
        private System.Windows.Forms.TextBox txtParticulars;
        private System.Windows.Forms.TextBox txtsystemTime;
        private System.Windows.Forms.TextBox txtWeekDayName;
        private System.Windows.Forms.Timer timer1;
        private AtiqsControlLibrary.SmartTextBox txtweekdayno;
        private AtiqsControlLibrary.SmartTextBox txtParID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
