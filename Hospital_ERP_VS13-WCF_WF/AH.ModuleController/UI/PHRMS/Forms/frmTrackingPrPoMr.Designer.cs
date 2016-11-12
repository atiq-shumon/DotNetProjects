namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmTrackingPrPoMr
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
            this.cboPharmacy = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvReqDetails = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPODetails = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMrrDetails = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPODetails)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrrDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(425, 9);
            this.frmLabel.Size = new System.Drawing.Size(263, 33);
            this.frmLabel.Text = "Tracking PR-PO-GRN";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.dtToDate);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.dtFromDate);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboPharmacy);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(1155, 680);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1158, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(785, 743);
            this.btnEdit.Size = new System.Drawing.Size(49, 10);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(736, 743);
            this.btnSave.Size = new System.Drawing.Size(43, 16);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(840, 744);
            this.btnDelete.Size = new System.Drawing.Size(52, 16);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(677, 744);
            this.btnNew.Size = new System.Drawing.Size(46, 15);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.Location = new System.Drawing.Point(1033, 744);
            this.btnClose.Size = new System.Drawing.Size(113, 37);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPrint.Location = new System.Drawing.Point(898, 744);
            this.btnPrint.Size = new System.Drawing.Size(38, 16);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 784);
            this.groupBox1.Size = new System.Drawing.Size(1158, 25);
            // 
            // cboPharmacy
            // 
            this.cboPharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPharmacy.ForeColor = System.Drawing.Color.Blue;
            this.cboPharmacy.FormattingEnabled = true;
            this.cboPharmacy.Location = new System.Drawing.Point(10, 31);
            this.cboPharmacy.Name = "cboPharmacy";
            this.cboPharmacy.Size = new System.Drawing.Size(249, 26);
            this.cboPharmacy.TabIndex = 0;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(15, 11);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(62, 13);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Pharmacy";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(288, 37);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(87, 20);
            this.dtFromDate.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(290, 19);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(65, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "From Date";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(451, 19);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(53, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "To Date";
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(449, 37);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(87, 20);
            this.dtToDate.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(540, 34);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(53, 25);
            this.btnShow.TabIndex = 170;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvReqDetails);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1141, 182);
            this.groupBox2.TabIndex = 171;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PR Details";
            // 
            // dgvReqDetails
            // 
            this.dgvReqDetails.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvReqDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReqDetails.GridColor = System.Drawing.Color.DarkGray;
            this.dgvReqDetails.Location = new System.Drawing.Point(7, 18);
            this.dgvReqDetails.Name = "dgvReqDetails";
            this.dgvReqDetails.Size = new System.Drawing.Size(861, 154);
            this.dgvReqDetails.TabIndex = 0;
            this.dgvReqDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReqDetails_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPODetails);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1139, 175);
            this.groupBox3.TabIndex = 172;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PO Details";
            // 
            // dgvPODetails
            // 
            this.dgvPODetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPODetails.Location = new System.Drawing.Point(7, 17);
            this.dgvPODetails.Name = "dgvPODetails";
            this.dgvPODetails.Size = new System.Drawing.Size(1122, 149);
            this.dgvPODetails.TabIndex = 0;
            this.dgvPODetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPODetails_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMrrDetails);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 485);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(939, 184);
            this.groupBox4.TabIndex = 173;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GRN Details";
            // 
            // dgvMrrDetails
            // 
            this.dgvMrrDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMrrDetails.Location = new System.Drawing.Point(8, 18);
            this.dgvMrrDetails.Name = "dgvMrrDetails";
            this.dgvMrrDetails.Size = new System.Drawing.Size(924, 158);
            this.dgvMrrDetails.TabIndex = 1;
            // 
            // frmTrackingPrPoMr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1158, 809);
            this.isEnterTabAllow = true;
            this.Name = "frmTrackingPrPoMr";
            this.Load += new System.EventHandler(this.frmTrackingPrPoMr_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPODetails)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrrDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboPharmacy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvReqDetails;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvPODetails;
        private System.Windows.Forms.DataGridView dgvMrrDetails;
    }
}
