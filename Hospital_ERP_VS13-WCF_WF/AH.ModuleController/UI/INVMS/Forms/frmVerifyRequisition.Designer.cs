namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmVerifyRequisition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReqVerify = new AtiqsControlLibrary.SmartDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRequisition = new AtiqsControlLibrary.SmartDataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.txtDRID = new AtiqsControlLibrary.SmartTextBox();
            this.txtRequisitionBy = new AtiqsControlLibrary.SmartTextBox();
            this.txtDRDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtReqNo = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqVerify)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisition)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(494, 9);
            this.frmLabel.Size = new System.Drawing.Size(285, 33);
            this.frmLabel.Text = "Requisition Verification";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtReqNo);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.btnPreview);
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(1314, 569);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnShow);
            this.pnlTop.Size = new System.Drawing.Size(1317, 58);
            this.pnlTop.Controls.SetChildIndex(this.btnShow, 0);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1087, 633);
            this.btnEdit.Text = "Verify";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 632);
            this.btnSave.Size = new System.Drawing.Size(84, 39);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(110, 632);
            this.btnDelete.Size = new System.Drawing.Size(66, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(973, 633);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1202, 633);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(182, 632);
            this.btnPrint.Size = new System.Drawing.Size(67, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 674);
            this.groupBox1.Size = new System.Drawing.Size(1317, 25);
            // 
            // dgvReqVerify
            // 
            this.dgvReqVerify.AllowUserToAddRows = false;
            this.dgvReqVerify.AllowUserToDeleteRows = false;
            this.dgvReqVerify.AllowUserToOrderColumns = true;
            this.dgvReqVerify.AllowUserToResizeColumns = false;
            this.dgvReqVerify.AllowUserToResizeRows = false;
            this.dgvReqVerify.BackgroundColor = System.Drawing.Color.White;
            this.dgvReqVerify.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvReqVerify.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReqVerify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReqVerify.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReqVerify.Location = new System.Drawing.Point(11, 18);
            this.dgvReqVerify.MultiSelect = false;
            this.dgvReqVerify.Name = "dgvReqVerify";
            this.dgvReqVerify.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvReqVerify.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReqVerify.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReqVerify.Size = new System.Drawing.Size(550, 496);
            this.dgvReqVerify.TabIndex = 0;
            this.dgvReqVerify.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReqVerify_CellClick);
            this.dgvReqVerify.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReqVerify_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRequisition);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(577, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 550);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requisition Details";
            // 
            // dgvRequisition
            // 
            this.dgvRequisition.AllowUserToAddRows = false;
            this.dgvRequisition.AllowUserToDeleteRows = false;
            this.dgvRequisition.AllowUserToOrderColumns = true;
            this.dgvRequisition.AllowUserToResizeColumns = false;
            this.dgvRequisition.AllowUserToResizeRows = false;
            this.dgvRequisition.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequisition.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvRequisition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRequisition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequisition.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRequisition.Location = new System.Drawing.Point(9, 20);
            this.dgvRequisition.MultiSelect = false;
            this.dgvRequisition.Name = "dgvRequisition";
            this.dgvRequisition.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvRequisition.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRequisition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequisition.Size = new System.Drawing.Size(715, 522);
            this.dgvRequisition.TabIndex = 0;
            this.dgvRequisition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisition_CellClick);
            this.dgvRequisition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisition_CellContentClick);
            this.dgvRequisition.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisition_CellEnter);
            this.dgvRequisition.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRequisition_CellFormatting);
            this.dgvRequisition.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvRequisition_CellValidating);
            this.dgvRequisition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRequisition_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvReqVerify);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(4, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(567, 524);
            this.groupBox4.TabIndex = 281;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Requisition No(To Be Verified)";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(343, 638);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(51, 26);
            this.cboUnit.TabIndex = 283;
            this.cboUnit.Visible = false;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(286, 639);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(51, 26);
            this.cboDepartment.TabIndex = 282;
            this.cboDepartment.Visible = false;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // txtDRID
            // 
            this.txtDRID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDRID.Location = new System.Drawing.Point(489, 645);
            this.txtDRID.Name = "txtDRID";
            this.txtDRID.Size = new System.Drawing.Size(49, 24);
            this.txtDRID.TabIndex = 289;
            this.txtDRID.Visible = false;
            // 
            // txtRequisitionBy
            // 
            this.txtRequisitionBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequisitionBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequisitionBy.Location = new System.Drawing.Point(413, 650);
            this.txtRequisitionBy.Name = "txtRequisitionBy";
            this.txtRequisitionBy.Size = new System.Drawing.Size(43, 24);
            this.txtRequisitionBy.TabIndex = 290;
            this.txtRequisitionBy.Visible = false;
            this.txtRequisitionBy.TextChanged += new System.EventHandler(this.txtRequisitionBy_TextChanged);
            this.txtRequisitionBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequisitionBy_KeyDown);
            this.txtRequisitionBy.Leave += new System.EventHandler(this.txtRequisitionBy_Leave);
            // 
            // txtDRDate
            // 
            this.txtDRDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txtDRDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDRDate.Location = new System.Drawing.Point(654, 644);
            this.txtDRDate.Mask = "00/00/0000";
            this.txtDRDate.Name = "txtDRDate";
            this.txtDRDate.Size = new System.Drawing.Size(52, 24);
            this.txtDRDate.TabIndex = 297;
            this.txtDRDate.ValidatingType = typeof(System.DateTime);
            this.txtDRDate.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(302, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(61, 25);
            this.btnShow.TabIndex = 282;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(240, 7);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(85, 25);
            this.btnPreview.TabIndex = 311;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(16, 12);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(50, 15);
            this.smartLabel4.TabIndex = 313;
            this.smartLabel4.Text = "DR No :";
            // 
            // txtReqNo
            // 
            this.txtReqNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReqNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqNo.Location = new System.Drawing.Point(77, 7);
            this.txtReqNo.Name = "txtReqNo";
            this.txtReqNo.Size = new System.Drawing.Size(162, 24);
            this.txtReqNo.TabIndex = 314;
            // 
            // frmVerifyRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1317, 699);
            this.Controls.Add(this.txtDRDate);
            this.Controls.Add(this.txtRequisitionBy);
            this.Controls.Add(this.txtDRID);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.cboDepartment);
            this.isEnterTabAllow = true;
            this.Name = "frmVerifyRequisition";
            this.Load += new System.EventHandler(this.frmVerifyRequisition_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.cboDepartment, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.cboUnit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.txtDRID, 0);
            this.Controls.SetChildIndex(this.txtRequisitionBy, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtDRDate, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqVerify)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisition)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartDataGridView dgvReqVerify;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartDataGridView dgvRequisition;
        private System.Windows.Forms.GroupBox groupBox4;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartTextBox txtDRID;
        private AtiqsControlLibrary.SmartTextBox txtRequisitionBy;
        private AtiqsControlLibrary.SmartDateTextBox txtDRDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnPreview;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtReqNo;
    }
}
