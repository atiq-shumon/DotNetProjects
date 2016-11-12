namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    partial class frmPatientSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtoDOB = new AtiqsControlLibrary.SmartDateTextBox();
            this.txtMobile = new AtiqsControlLibrary.SmartTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPatientSearch = new AtiqsControlLibrary.SmartDataGridView();
            this.txtPatientName = new AtiqsControlLibrary.SmartTextBoxColorful();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new AtiqsControlLibrary.SmartTextBoxColorful();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSpouseName = new AtiqsControlLibrary.SmartTextBoxColorful();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatMother = new AtiqsControlLibrary.SmartTextBoxColorful();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatFather = new AtiqsControlLibrary.SmartTextBoxColorful();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientSearch)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(769, 669);
            this.btnClose.Size = new System.Drawing.Size(107, 46);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(168, 674);
            this.btnPrint.Size = new System.Drawing.Size(26, 37);
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(358, 6);
            this.frmLabel.Size = new System.Drawing.Size(187, 32);
            this.frmLabel.Text = "Patient Search";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvPatientSearch);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Location = new System.Drawing.Point(0, 52);
            this.pnlMain.Size = new System.Drawing.Size(888, 616);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(888, 51);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient Name   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(458, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "DOB       :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(457, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mobile    :";
            // 
            // dtoDOB
            // 
            this.dtoDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtoDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtoDOB.Location = new System.Drawing.Point(551, 99);
            this.dtoDOB.Mask = "00/00/0000";
            this.dtoDOB.Name = "dtoDOB";
            this.dtoDOB.Size = new System.Drawing.Size(150, 24);
            this.dtoDOB.TabIndex = 9;
            this.dtoDOB.ValidatingType = typeof(System.DateTime);
            // 
            // txtMobile
            // 
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(551, 55);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(306, 25);
            this.txtMobile.TabIndex = 11;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(40, 683);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(16, 23);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "l";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(740, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 40);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPatientSearch
            // 
            this.dgvPatientSearch.AllowUserToAddRows = false;
            this.dgvPatientSearch.AllowUserToDeleteRows = false;
            this.dgvPatientSearch.AllowUserToOrderColumns = true;
            this.dgvPatientSearch.AllowUserToResizeColumns = false;
            this.dgvPatientSearch.AllowUserToResizeRows = false;
            this.dgvPatientSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPatientSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientSearch.Location = new System.Drawing.Point(6, 178);
            this.dgvPatientSearch.MultiSelect = false;
            this.dgvPatientSearch.Name = "dgvPatientSearch";
            this.dgvPatientSearch.RowHeadersVisible = false;
            this.dgvPatientSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientSearch.Size = new System.Drawing.Size(875, 429);
            this.dgvPatientSearch.TabIndex = 14;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(149, 18);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(284, 29);
            this.txtPatientName.TabIndex = 15;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtPatientName_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSpouseName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPatMother);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPatFather);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtoDOB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 171);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Crieteria";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(551, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(306, 29);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(457, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Address   :";
            // 
            // txtSpouseName
            // 
            this.txtSpouseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpouseName.Location = new System.Drawing.Point(149, 129);
            this.txtSpouseName.Name = "txtSpouseName";
            this.txtSpouseName.Size = new System.Drawing.Size(284, 29);
            this.txtSpouseName.TabIndex = 21;
            this.txtSpouseName.TextChanged += new System.EventHandler(this.txtSpouseName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(5, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Spouse\'s Name  :";
            // 
            // txtPatMother
            // 
            this.txtPatMother.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatMother.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatMother.Location = new System.Drawing.Point(149, 94);
            this.txtPatMother.Name = "txtPatMother";
            this.txtPatMother.Size = new System.Drawing.Size(284, 29);
            this.txtPatMother.TabIndex = 19;
            this.txtPatMother.TextChanged += new System.EventHandler(this.txtPatMother_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(5, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mother\'s Name :";
            // 
            // txtPatFather
            // 
            this.txtPatFather.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatFather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatFather.Location = new System.Drawing.Point(149, 55);
            this.txtPatFather.Name = "txtPatFather";
            this.txtPatFather.Size = new System.Drawing.Size(284, 29);
            this.txtPatFather.TabIndex = 17;
            this.txtPatFather.TextChanged += new System.EventHandler(this.txtPatFather_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(5, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Father\'s Name   :";
            // 
            // frmPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(888, 736);
            this.Controls.Add(this.lblError);
            this.Name = "frmPatientSearch";
            this.Load += new System.EventHandler(this.frmPatientSearch_Load);
            this.Controls.SetChildIndex(this.lblError, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientSearch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartDateTextBox dtoDOB;
        private AtiqsControlLibrary.SmartTextBox txtMobile;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartDataGridView dgvPatientSearch;
        private AtiqsControlLibrary.SmartTextBoxColorful txtPatientName;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartTextBoxColorful txtAddress;
        private System.Windows.Forms.Label label9;
        private AtiqsControlLibrary.SmartTextBoxColorful txtSpouseName;
        private System.Windows.Forms.Label label8;
        private AtiqsControlLibrary.SmartTextBoxColorful txtPatMother;
        private System.Windows.Forms.Label label6;
        private AtiqsControlLibrary.SmartTextBoxColorful txtPatFather;
        private System.Windows.Forms.Label label5;


    }
}
