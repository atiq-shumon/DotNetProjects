namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmPrintPatientLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbdDepartment = new System.Windows.Forms.Label();
            this.lblGrop = new System.Windows.Forms.Label();
            this.lblReportGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoneyRecipt = new System.Windows.Forms.TextBox();
            this.btnPatientDetails = new System.Windows.Forms.Button();
            this.lblMr = new AtiqsControlLibrary.SmartLabel();
            this.dgvReportList = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(942, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(244, 6);
            this.frmLabel.Size = new System.Drawing.Size(392, 33);
            this.frmLabel.Text = "Print Patient Label For Envelope";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvReportList);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(833, 379);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(833, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(30, 440);
            this.btnEdit.Size = new System.Drawing.Size(30, 25);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(74, 441);
            this.btnSave.Size = new System.Drawing.Size(10, 22);
            this.btnSave.TabIndex = 4;
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(4, 439);
            this.btnDelete.Size = new System.Drawing.Size(20, 25);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(601, 431);
            this.btnNew.Size = new System.Drawing.Size(108, 44);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(715, 431);
            this.btnClose.Size = new System.Drawing.Size(108, 44);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(90, 435);
            this.btnPrint.Size = new System.Drawing.Size(46, 34);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 475);
            this.groupBox1.Size = new System.Drawing.Size(833, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Department :";
            // 
            // lbdDepartment
            // 
            this.lbdDepartment.AutoSize = true;
            this.lbdDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdDepartment.ForeColor = System.Drawing.Color.Blue;
            this.lbdDepartment.Location = new System.Drawing.Point(120, 8);
            this.lbdDepartment.Name = "lbdDepartment";
            this.lbdDepartment.Size = new System.Drawing.Size(57, 20);
            this.lbdDepartment.TabIndex = 84;
            this.lbdDepartment.Text = "label3";
            // 
            // lblGrop
            // 
            this.lblGrop.AutoSize = true;
            this.lblGrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrop.Location = new System.Drawing.Point(542, 9);
            this.lblGrop.Name = "lblGrop";
            this.lblGrop.Size = new System.Drawing.Size(106, 20);
            this.lblGrop.TabIndex = 85;
            this.lblGrop.Text = "Report For :";
            // 
            // lblReportGroup
            // 
            this.lblReportGroup.AutoSize = true;
            this.lblReportGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportGroup.ForeColor = System.Drawing.Color.Blue;
            this.lblReportGroup.Location = new System.Drawing.Point(654, 11);
            this.lblReportGroup.Name = "lblReportGroup";
            this.lblReportGroup.Size = new System.Drawing.Size(57, 20);
            this.lblReportGroup.TabIndex = 86;
            this.lblReportGroup.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(-1, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 38);
            this.panel1.TabIndex = 87;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMoneyRecipt);
            this.panel2.Controls.Add(this.btnPatientDetails);
            this.panel2.Controls.Add(this.lblMr);
            this.panel2.Location = new System.Drawing.Point(4, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 80);
            this.panel2.TabIndex = 211;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(401, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 24);
            this.label5.TabIndex = 217;
            this.label5.Text = "*";
            // 
            // txtMoneyRecipt
            // 
            this.txtMoneyRecipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneyRecipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyRecipt.ForeColor = System.Drawing.Color.Red;
            this.txtMoneyRecipt.Location = new System.Drawing.Point(76, 29);
            this.txtMoneyRecipt.MaxLength = 12;
            this.txtMoneyRecipt.Name = "txtMoneyRecipt";
            this.txtMoneyRecipt.Size = new System.Drawing.Size(320, 31);
            this.txtMoneyRecipt.TabIndex = 205;
            this.txtMoneyRecipt.Leave += new System.EventHandler(this.txtMoneyRecipt_Leave);
            // 
            // btnPatientDetails
            // 
            this.btnPatientDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDetails.ForeColor = System.Drawing.Color.White;
            this.btnPatientDetails.Location = new System.Drawing.Point(434, 25);
            this.btnPatientDetails.Name = "btnPatientDetails";
            this.btnPatientDetails.Size = new System.Drawing.Size(320, 34);
            this.btnPatientDetails.TabIndex = 206;
            this.btnPatientDetails.Text = "Find";
            this.btnPatientDetails.UseVisualStyleBackColor = false;
            this.btnPatientDetails.Click += new System.EventHandler(this.btnPatientDetails_Click);
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.BackColor = System.Drawing.Color.Transparent;
            this.lblMr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMr.Location = new System.Drawing.Point(86, 6);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(108, 15);
            this.lblMr.TabIndex = 208;
            this.lblMr.Text = "Money Receipt  No";
            // 
            // dgvReportList
            // 
            this.dgvReportList.AllowUserToAddRows = false;
            this.dgvReportList.AllowUserToDeleteRows = false;
            this.dgvReportList.AllowUserToResizeColumns = false;
            this.dgvReportList.AllowUserToResizeRows = false;
            this.dgvReportList.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportList.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvReportList.Location = new System.Drawing.Point(3, 89);
            this.dgvReportList.Name = "dgvReportList";
            this.dgvReportList.RowHeadersVisible = false;
            this.dgvReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReportList.Size = new System.Drawing.Size(827, 286);
            this.dgvReportList.TabIndex = 212;
            this.dgvReportList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportList_CellClick);
            this.dgvReportList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportList_CellContentClick);
            // 
            // frmPrintPatientLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(833, 498);
            this.isEnterTabAllow = true;
            this.Name = "frmPrintPatientLabel";
            this.Load += new System.EventHandler(this.frmReportPrintInterface_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGrop;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblReportGroup;
        public System.Windows.Forms.Label lbdDepartment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReportList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoneyRecipt;
        private System.Windows.Forms.Button btnPatientDetails;
        private AtiqsControlLibrary.SmartLabel lblMr;
    }
}
