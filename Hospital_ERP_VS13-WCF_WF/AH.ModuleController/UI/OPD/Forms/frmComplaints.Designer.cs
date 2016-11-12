namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmComplaints
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
            this.txtComplaints = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtComplaintsTitle = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtComplaintsTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvComplaints = new AtiqsControlLibrary.SmartListViewDetails();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(222, 33);
            this.frmLabel.Text = "Complaints Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvComplaints);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(884, 536);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(884, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(655, 600);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(542, 600);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(11, 618);
            this.btnDelete.Size = new System.Drawing.Size(14, 14);
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(429, 600);
            this.btnNew.TabIndex = 6;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(769, 600);
            this.btnClose.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(31, 618);
            this.btnPrint.Size = new System.Drawing.Size(14, 14);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 640);
            this.groupBox1.Size = new System.Drawing.Size(884, 25);
            // 
            // txtComplaints
            // 
            this.txtComplaints.BackColor = System.Drawing.Color.Linen;
            this.txtComplaints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplaints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtComplaints.Location = new System.Drawing.Point(289, 11);
            this.txtComplaints.Name = "txtComplaints";
            this.txtComplaints.ReadOnly = true;
            this.txtComplaints.Size = new System.Drawing.Size(173, 24);
            this.txtComplaints.TabIndex = 0;
            this.txtComplaints.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(126, 14);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 15);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Complaint ID :";
            // 
            // txtComplaintsTitle
            // 
            this.txtComplaintsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplaintsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplaintsTitle.Location = new System.Drawing.Point(289, 77);
            this.txtComplaintsTitle.MaxLength = 200;
            this.txtComplaintsTitle.Multiline = true;
            this.txtComplaintsTitle.Name = "txtComplaintsTitle";
            this.txtComplaintsTitle.Size = new System.Drawing.Size(471, 25);
            this.txtComplaintsTitle.TabIndex = 1;
            this.txtComplaintsTitle.TextChanged += new System.EventHandler(this.txtComplaintsTitle_TextChanged);
            this.txtComplaintsTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtComplaintsTitle_KeyUp);
            this.txtComplaintsTitle.Leave += new System.EventHandler(this.txtComplaintsTitle_Leave);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(126, 76);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(99, 15);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Complaint Title :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(126, 107);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(131, 15);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Complaint Title Beng :";
            // 
            // txtComplaintsTitleBeng
            // 
            this.txtComplaintsTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplaintsTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplaintsTitleBeng.Location = new System.Drawing.Point(289, 110);
            this.txtComplaintsTitleBeng.MaxLength = 200;
            this.txtComplaintsTitleBeng.Multiline = true;
            this.txtComplaintsTitleBeng.Name = "txtComplaintsTitleBeng";
            this.txtComplaintsTitleBeng.Size = new System.Drawing.Size(471, 25);
            this.txtComplaintsTitleBeng.TabIndex = 2;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(289, 43);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(350, 26);
            this.cboDepartment.TabIndex = 0;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(126, 45);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(78, 15);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Department :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(126, 138);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(65, 15);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(289, 143);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(471, 42);
            this.txtRemarks.TabIndex = 3;
            // 
            // lvComplaints
            // 
            this.lvComplaints.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvComplaints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvComplaints.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvComplaints.FullRowSelect = true;
            this.lvComplaints.GridLines = true;
            this.lvComplaints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvComplaints.Location = new System.Drawing.Point(0, 202);
            this.lvComplaints.Name = "lvComplaints";
            this.lvComplaints.Size = new System.Drawing.Size(882, 332);
            this.lvComplaints.TabIndex = 10;
            this.lvComplaints.TabStop = false;
            this.lvComplaints.UseCompatibleStateImageBehavior = false;
            this.lvComplaints.View = System.Windows.Forms.View.Details;
            this.lvComplaints.SelectedIndexChanged += new System.EventHandler(this.lvComplaints_SelectedIndexChanged);
            this.lvComplaints.Click += new System.EventHandler(this.lvComplaints_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.txtComplaints);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.txtComplaintsTitle);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.cboDepartment);
            this.groupBox2.Controls.Add(this.txtComplaintsTitleBeng);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Location = new System.Drawing.Point(4, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 194);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // frmComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.isEnterTabAllow = true;
            this.Name = "frmComplaints";
            this.Load += new System.EventHandler(this.frmComplaints_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtComplaintsTitleBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtComplaintsTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtComplaints;
        private AtiqsControlLibrary.SmartListViewDetails lvComplaints;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
