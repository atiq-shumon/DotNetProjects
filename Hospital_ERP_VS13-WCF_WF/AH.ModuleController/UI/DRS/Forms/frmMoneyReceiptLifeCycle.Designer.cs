namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmMoneyReceiptLifeCycle
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
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.txtAdvice = new AtiqsControlLibrary.SmartTextBox();
            this.txtComments = new AtiqsControlLibrary.SmartTextBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.dgvReportList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoneyRecipt = new System.Windows.Forms.TextBox();
            this.lblMr = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtHCN = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtAge = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtSex = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPatientName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(63, 5);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(607, 9);
            this.frmLabel.Size = new System.Drawing.Size(307, 33);
            this.frmLabel.Text = "Money Receipt Life Cycle";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtHCN);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtAge);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.txtSex);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtPatientName);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.txtMoneyRecipt);
            this.pnlMain.Controls.Add(this.lblMr);
            this.pnlMain.Controls.Add(this.dgvReportList);
            this.pnlMain.Controls.Add(this.btnPatientSearch);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(1437, 477);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblDeptID);
            this.pnlTop.Size = new System.Drawing.Size(1437, 58);
            this.pnlTop.Controls.SetChildIndex(this.frmLabel, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnTopClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.lblDeptID, 0);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(66, 536);
            this.btnEdit.Size = new System.Drawing.Size(13, 22);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1077, 542);
            this.btnSave.Text = "OK";
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(83, 538);
            this.btnDelete.Size = new System.Drawing.Size(13, 22);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1203, 542);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1317, 542);
            this.btnClose.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(97, 536);
            this.btnPrint.Size = new System.Drawing.Size(19, 22);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 583);
            this.groupBox1.Size = new System.Drawing.Size(1437, 23);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(260, 25);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(172, 34);
            this.btnPatientSearch.TabIndex = 3;
            this.btnPatientSearch.Text = "Show";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // txtAdvice
            // 
            this.txtAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(50, 535);
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(10, 24);
            this.txtAdvice.TabIndex = 15;
            this.txtAdvice.Visible = false;
            // 
            // txtComments
            // 
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(31, 535);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(13, 24);
            this.txtComments.TabIndex = 16;
            this.txtComments.Visible = false;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(47, 25);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(83, 13);
            this.lblDeptID.TabIndex = 201;
            this.lblDeptID.Text = "DepartmentId";
            this.lblDeptID.Visible = false;
            // 
            // dgvReportList
            // 
            this.dgvReportList.AllowUserToAddRows = false;
            this.dgvReportList.AllowUserToDeleteRows = false;
            this.dgvReportList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvReportList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportList.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvReportList.Location = new System.Drawing.Point(2, 66);
            this.dgvReportList.Name = "dgvReportList";
            this.dgvReportList.RowHeadersVisible = false;
            this.dgvReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReportList.Size = new System.Drawing.Size(1432, 409);
            this.dgvReportList.TabIndex = 213;
            this.dgvReportList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReportList_CellFormatting);
            this.dgvReportList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvReportList_CellPainting);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(236, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 24);
            this.label5.TabIndex = 220;
            this.label5.Text = "*";
            // 
            // txtMoneyRecipt
            // 
            this.txtMoneyRecipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyRecipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyRecipt.ForeColor = System.Drawing.Color.Red;
            this.txtMoneyRecipt.Location = new System.Drawing.Point(5, 26);
            this.txtMoneyRecipt.MaxLength = 11;
            this.txtMoneyRecipt.Name = "txtMoneyRecipt";
            this.txtMoneyRecipt.Size = new System.Drawing.Size(225, 31);
            this.txtMoneyRecipt.TabIndex = 218;
            this.txtMoneyRecipt.TextChanged += new System.EventHandler(this.txtMoneyRecipt_TextChanged);
            this.txtMoneyRecipt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMoneyRecipt_KeyUp);
            this.txtMoneyRecipt.Leave += new System.EventHandler(this.txtMoneyRecipt_Leave);
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.BackColor = System.Drawing.Color.Transparent;
            this.lblMr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMr.Location = new System.Drawing.Point(46, 8);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(108, 15);
            this.lblMr.TabIndex = 219;
            this.lblMr.Text = "Money Receipt  No";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(464, 11);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(34, 15);
            this.smartLabel2.TabIndex = 228;
            this.smartLabel2.Text = "HCN";
            // 
            // txtHCN
            // 
            this.txtHCN.BackColor = System.Drawing.Color.Linen;
            this.txtHCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHCN.Location = new System.Drawing.Point(467, 27);
            this.txtHCN.Multiline = true;
            this.txtHCN.Name = "txtHCN";
            this.txtHCN.ReadOnly = true;
            this.txtHCN.Size = new System.Drawing.Size(208, 26);
            this.txtHCN.TabIndex = 227;
            this.txtHCN.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(980, 11);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(29, 13);
            this.smartLabel1.TabIndex = 226;
            this.smartLabel1.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Linen;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAge.Location = new System.Drawing.Point(978, 29);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(282, 24);
            this.txtAge.TabIndex = 225;
            this.txtAge.TabStop = false;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(1268, 11);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(47, 15);
            this.smartLabel8.TabIndex = 224;
            this.smartLabel8.Text = "Gender";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.Linen;
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSex.Location = new System.Drawing.Point(1266, 29);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(158, 24);
            this.txtSex.TabIndex = 223;
            this.txtSex.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(682, 10);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(80, 15);
            this.smartLabel3.TabIndex = 222;
            this.smartLabel3.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPatientName.Location = new System.Drawing.Point(681, 27);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(291, 26);
            this.txtPatientName.TabIndex = 221;
            this.txtPatientName.TabStop = false;
            // 
            // frmMoneyReceiptLifeCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1437, 606);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtAdvice);
            this.isEnterTabAllow = true;
            this.Name = "frmMoneyReceiptLifeCycle";
            this.Load += new System.EventHandler(this.frmWorkSheet_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtAdvice, 0);
            this.Controls.SetChildIndex(this.txtComments, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientSearch;
        private AtiqsControlLibrary.SmartTextBox txtAdvice;
        private AtiqsControlLibrary.SmartTextBox txtComments;
        public System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.DataGridView dgvReportList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoneyRecipt;
        private AtiqsControlLibrary.SmartLabel lblMr;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHCN;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAge;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSex;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPatientName;
    }
}
