namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmEmployeeLeaveRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLeaveRegister = new AtiqsControlLibrary.SmartDataGridView();
            this.grpLeaveAllotted = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lblPat = new AtiqsControlLibrary.SmartLabel();
            this.lblPatEnj = new AtiqsControlLibrary.SmartLabel();
            this.lblPatRem = new AtiqsControlLibrary.SmartLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lblMatEnj = new AtiqsControlLibrary.SmartLabel();
            this.lblMat = new AtiqsControlLibrary.SmartLabel();
            this.lblMatRem = new AtiqsControlLibrary.SmartLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.lblEarEnj = new AtiqsControlLibrary.SmartLabel();
            this.lblEar = new AtiqsControlLibrary.SmartLabel();
            this.lblEarRem = new AtiqsControlLibrary.SmartLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMedRem = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lblMedEnj = new AtiqsControlLibrary.SmartLabel();
            this.lblMed = new AtiqsControlLibrary.SmartLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCasEnj = new AtiqsControlLibrary.SmartLabel();
            this.lblCas = new AtiqsControlLibrary.SmartLabel();
            this.lblCasRem = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel33 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel32 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel31 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRegister)).BeginInit();
            this.grpLeaveAllotted.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(429, 9);
            this.frmLabel.Size = new System.Drawing.Size(311, 33);
            this.frmLabel.Text = "Employee Leave Register";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.grpLeaveAllotted);
            this.pnlMain.Controls.Add(this.dgvLeaveRegister);
            this.pnlMain.Size = new System.Drawing.Size(1168, 815);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1168, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(720, 734);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(607, 734);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(833, 734);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(494, 734);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1055, 734);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(944, 734);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 778);
            this.groupBox1.Size = new System.Drawing.Size(1168, 25);
            // 
            // dgvLeaveRegister
            // 
            this.dgvLeaveRegister.AllowUserToAddRows = false;
            this.dgvLeaveRegister.AllowUserToDeleteRows = false;
            this.dgvLeaveRegister.AllowUserToOrderColumns = true;
            this.dgvLeaveRegister.AllowUserToResizeColumns = false;
            this.dgvLeaveRegister.AllowUserToResizeRows = false;
            this.dgvLeaveRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaveRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLeaveRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLeaveRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeaveRegister.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLeaveRegister.Location = new System.Drawing.Point(0, 396);
            this.dgvLeaveRegister.MultiSelect = false;
            this.dgvLeaveRegister.Name = "dgvLeaveRegister";
            this.dgvLeaveRegister.RowHeadersVisible = false;
            this.dgvLeaveRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveRegister.Size = new System.Drawing.Size(1164, 414);
            this.dgvLeaveRegister.TabIndex = 0;
            // 
            // grpLeaveAllotted
            // 
            this.grpLeaveAllotted.BackColor = System.Drawing.Color.AliceBlue;
            this.grpLeaveAllotted.Controls.Add(this.panel6);
            this.grpLeaveAllotted.Controls.Add(this.panel5);
            this.grpLeaveAllotted.Controls.Add(this.panel4);
            this.grpLeaveAllotted.Controls.Add(this.panel3);
            this.grpLeaveAllotted.Controls.Add(this.panel2);
            this.grpLeaveAllotted.Controls.Add(this.smartLabel11);
            this.grpLeaveAllotted.Controls.Add(this.smartLabel33);
            this.grpLeaveAllotted.Controls.Add(this.smartLabel32);
            this.grpLeaveAllotted.Controls.Add(this.smartLabel31);
            this.grpLeaveAllotted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLeaveAllotted.Location = new System.Drawing.Point(9, 148);
            this.grpLeaveAllotted.Name = "grpLeaveAllotted";
            this.grpLeaveAllotted.Size = new System.Drawing.Size(493, 242);
            this.grpLeaveAllotted.TabIndex = 1;
            this.grpLeaveAllotted.TabStop = false;
            this.grpLeaveAllotted.Text = "Leave Summary";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Thistle;
            this.panel6.Controls.Add(this.smartLabel5);
            this.panel6.Controls.Add(this.lblPat);
            this.panel6.Controls.Add(this.lblPatEnj);
            this.panel6.Controls.Add(this.lblPatRem);
            this.panel6.Location = new System.Drawing.Point(4, 194);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(485, 30);
            this.panel6.TabIndex = 34;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(28, 7);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(69, 16);
            this.smartLabel5.TabIndex = 4;
            this.smartLabel5.Text = "Paternity";
            // 
            // lblPat
            // 
            this.lblPat.AutoSize = true;
            this.lblPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPat.Location = new System.Drawing.Point(184, 7);
            this.lblPat.Name = "lblPat";
            this.lblPat.Size = new System.Drawing.Size(16, 16);
            this.lblPat.TabIndex = 14;
            this.lblPat.Text = "0";
            // 
            // lblPatEnj
            // 
            this.lblPatEnj.AutoSize = true;
            this.lblPatEnj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPatEnj.Location = new System.Drawing.Point(285, 7);
            this.lblPatEnj.Name = "lblPatEnj";
            this.lblPatEnj.Size = new System.Drawing.Size(16, 16);
            this.lblPatEnj.TabIndex = 19;
            this.lblPatEnj.Text = "0";
            // 
            // lblPatRem
            // 
            this.lblPatRem.AutoSize = true;
            this.lblPatRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPatRem.Location = new System.Drawing.Point(393, 7);
            this.lblPatRem.Name = "lblPatRem";
            this.lblPatRem.Size = new System.Drawing.Size(16, 16);
            this.lblPatRem.TabIndex = 24;
            this.lblPatRem.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PowderBlue;
            this.panel5.Controls.Add(this.smartLabel4);
            this.panel5.Controls.Add(this.lblMatEnj);
            this.panel5.Controls.Add(this.lblMat);
            this.panel5.Controls.Add(this.lblMatRem);
            this.panel5.Location = new System.Drawing.Point(5, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(485, 30);
            this.panel5.TabIndex = 33;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(28, 7);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(71, 16);
            this.smartLabel4.TabIndex = 3;
            this.smartLabel4.Text = "Maternity";
            // 
            // lblMatEnj
            // 
            this.lblMatEnj.AutoSize = true;
            this.lblMatEnj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMatEnj.Location = new System.Drawing.Point(285, 7);
            this.lblMatEnj.Name = "lblMatEnj";
            this.lblMatEnj.Size = new System.Drawing.Size(16, 16);
            this.lblMatEnj.TabIndex = 18;
            this.lblMatEnj.Text = "0";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMat.Location = new System.Drawing.Point(184, 7);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(16, 16);
            this.lblMat.TabIndex = 13;
            this.lblMat.Text = "0";
            // 
            // lblMatRem
            // 
            this.lblMatRem.AutoSize = true;
            this.lblMatRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMatRem.Location = new System.Drawing.Point(393, 7);
            this.lblMatRem.Name = "lblMatRem";
            this.lblMatRem.Size = new System.Drawing.Size(16, 16);
            this.lblMatRem.TabIndex = 23;
            this.lblMatRem.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.smartLabel3);
            this.panel4.Controls.Add(this.lblEarEnj);
            this.panel4.Controls.Add(this.lblEar);
            this.panel4.Controls.Add(this.lblEarRem);
            this.panel4.Location = new System.Drawing.Point(4, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 30);
            this.panel4.TabIndex = 32;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(28, 7);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(40, 16);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "Earn";
            // 
            // lblEarEnj
            // 
            this.lblEarEnj.AutoSize = true;
            this.lblEarEnj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEarEnj.Location = new System.Drawing.Point(285, 7);
            this.lblEarEnj.Name = "lblEarEnj";
            this.lblEarEnj.Size = new System.Drawing.Size(16, 16);
            this.lblEarEnj.TabIndex = 17;
            this.lblEarEnj.Text = "0";
            // 
            // lblEar
            // 
            this.lblEar.AutoSize = true;
            this.lblEar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEar.Location = new System.Drawing.Point(184, 7);
            this.lblEar.Name = "lblEar";
            this.lblEar.Size = new System.Drawing.Size(16, 16);
            this.lblEar.TabIndex = 12;
            this.lblEar.Text = "0";
            // 
            // lblEarRem
            // 
            this.lblEarRem.AutoSize = true;
            this.lblEarRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEarRem.Location = new System.Drawing.Point(393, 7);
            this.lblEarRem.Name = "lblEarRem";
            this.lblEarRem.Size = new System.Drawing.Size(16, 16);
            this.lblEarRem.TabIndex = 22;
            this.lblEarRem.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel3.Controls.Add(this.lblMedRem);
            this.panel3.Controls.Add(this.smartLabel2);
            this.panel3.Controls.Add(this.lblMedEnj);
            this.panel3.Controls.Add(this.lblMed);
            this.panel3.Location = new System.Drawing.Point(5, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 30);
            this.panel3.TabIndex = 31;
            // 
            // lblMedRem
            // 
            this.lblMedRem.AutoSize = true;
            this.lblMedRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMedRem.Location = new System.Drawing.Point(393, 9);
            this.lblMedRem.Name = "lblMedRem";
            this.lblMedRem.Size = new System.Drawing.Size(16, 16);
            this.lblMedRem.TabIndex = 21;
            this.lblMedRem.Text = "0";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(28, 9);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(63, 16);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Medical";
            // 
            // lblMedEnj
            // 
            this.lblMedEnj.AutoSize = true;
            this.lblMedEnj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMedEnj.Location = new System.Drawing.Point(285, 9);
            this.lblMedEnj.Name = "lblMedEnj";
            this.lblMedEnj.Size = new System.Drawing.Size(16, 16);
            this.lblMedEnj.TabIndex = 16;
            this.lblMedEnj.Text = "0";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMed.Location = new System.Drawing.Point(184, 9);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(16, 16);
            this.lblMed.TabIndex = 11;
            this.lblMed.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.lblCasEnj);
            this.panel2.Controls.Add(this.lblCas);
            this.panel2.Controls.Add(this.lblCasRem);
            this.panel2.Controls.Add(this.smartLabel1);
            this.panel2.Location = new System.Drawing.Point(4, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 30);
            this.panel2.TabIndex = 30;
            // 
            // lblCasEnj
            // 
            this.lblCasEnj.AutoSize = true;
            this.lblCasEnj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCasEnj.Location = new System.Drawing.Point(285, 8);
            this.lblCasEnj.Name = "lblCasEnj";
            this.lblCasEnj.Size = new System.Drawing.Size(16, 16);
            this.lblCasEnj.TabIndex = 15;
            this.lblCasEnj.Text = "0";
            // 
            // lblCas
            // 
            this.lblCas.AutoSize = true;
            this.lblCas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCas.Location = new System.Drawing.Point(184, 8);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(16, 16);
            this.lblCas.TabIndex = 10;
            this.lblCas.Text = "0";
            // 
            // lblCasRem
            // 
            this.lblCasRem.AutoSize = true;
            this.lblCasRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCasRem.Location = new System.Drawing.Point(393, 8);
            this.lblCasRem.Name = "lblCasRem";
            this.lblCasRem.Size = new System.Drawing.Size(16, 16);
            this.lblCasRem.TabIndex = 20;
            this.lblCasRem.Text = "0";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(28, 8);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(56, 16);
            this.smartLabel1.TabIndex = 25;
            this.smartLabel1.Text = "Casual";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(30, 22);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(100, 20);
            this.smartLabel11.TabIndex = 29;
            this.smartLabel11.Text = "Leave Type";
            // 
            // smartLabel33
            // 
            this.smartLabel33.AutoSize = true;
            this.smartLabel33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel33.Location = new System.Drawing.Point(368, 22);
            this.smartLabel33.Name = "smartLabel33";
            this.smartLabel33.Size = new System.Drawing.Size(94, 20);
            this.smartLabel33.TabIndex = 28;
            this.smartLabel33.Text = "Remaining";
            // 
            // smartLabel32
            // 
            this.smartLabel32.AutoSize = true;
            this.smartLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel32.Location = new System.Drawing.Point(270, 22);
            this.smartLabel32.Name = "smartLabel32";
            this.smartLabel32.Size = new System.Drawing.Size(73, 20);
            this.smartLabel32.TabIndex = 27;
            this.smartLabel32.Text = "Enjoyed";
            // 
            // smartLabel31
            // 
            this.smartLabel31.AutoSize = true;
            this.smartLabel31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel31.Location = new System.Drawing.Point(172, 22);
            this.smartLabel31.Name = "smartLabel31";
            this.smartLabel31.Size = new System.Drawing.Size(71, 20);
            this.smartLabel31.TabIndex = 26;
            this.smartLabel31.Text = "Allotted";
            // 
            // frmEmployeeLeaveRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1168, 803);
            this.isEnterTabAllow = true;
            this.Name = "frmEmployeeLeaveRegister";
            this.Load += new System.EventHandler(this.frmEmployeeLeaveRegister_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRegister)).EndInit();
            this.grpLeaveAllotted.ResumeLayout(false);
            this.grpLeaveAllotted.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartDataGridView dgvLeaveRegister;
        private System.Windows.Forms.GroupBox grpLeaveAllotted;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel lblCas;
        private AtiqsControlLibrary.SmartLabel lblMed;
        private AtiqsControlLibrary.SmartLabel lblEar;
        private AtiqsControlLibrary.SmartLabel lblMat;
        private AtiqsControlLibrary.SmartLabel lblPat;
        private AtiqsControlLibrary.SmartLabel lblPatRem;
        private AtiqsControlLibrary.SmartLabel lblMatRem;
        private AtiqsControlLibrary.SmartLabel lblEarRem;
        private AtiqsControlLibrary.SmartLabel lblMedRem;
        private AtiqsControlLibrary.SmartLabel lblCasRem;
        private AtiqsControlLibrary.SmartLabel lblPatEnj;
        private AtiqsControlLibrary.SmartLabel lblMatEnj;
        private AtiqsControlLibrary.SmartLabel lblEarEnj;
        private AtiqsControlLibrary.SmartLabel lblMedEnj;
        private AtiqsControlLibrary.SmartLabel lblCasEnj;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel31;
        private AtiqsControlLibrary.SmartLabel smartLabel32;
        private AtiqsControlLibrary.SmartLabel smartLabel33;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
    }
}
