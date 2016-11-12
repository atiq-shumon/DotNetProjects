namespace  AH.ModuleController.UI.IPD.Forms
{
    partial class frmAdmReasonAssign
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
            this.cboAdmResAssign = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvAdmResAssign = new AtiqsControlLibrary.SmartListViewDetails();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(268, 10);
            this.frmLabel.Size = new System.Drawing.Size(314, 33);
            this.frmLabel.Text = "Admission Reason Assign";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.lvAdmResAssign);
            this.pnlMain.Controls.Add(this.cboAdmResAssign);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(865, 458);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(865, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(638, 518);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(525, 518);
            this.btnSave.TabIndex = 2;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(74, 518);
            this.btnDelete.Size = new System.Drawing.Size(36, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(412, 518);
            this.btnNew.TabIndex = 18;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(752, 518);
            this.btnClose.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(32, 518);
            this.btnPrint.Size = new System.Drawing.Size(36, 34);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 558);
            this.groupBox1.Size = new System.Drawing.Size(865, 23);
            // 
            // cboAdmResAssign
            // 
            this.cboAdmResAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdmResAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdmResAssign.ForeColor = System.Drawing.Color.Blue;
            this.cboAdmResAssign.FormattingEnabled = true;
            this.cboAdmResAssign.Location = new System.Drawing.Point(452, 26);
            this.cboAdmResAssign.Name = "cboAdmResAssign";
            this.cboAdmResAssign.Size = new System.Drawing.Size(337, 26);
            this.cboAdmResAssign.TabIndex = 1;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(452, 5);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(115, 15);
            this.smartLabel1.TabIndex = 33;
            this.smartLabel1.Text = "Admission Reason :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(31, 26);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(322, 26);
            this.cboDepartment.TabIndex = 0;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(31, 5);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(78, 15);
            this.smartLabel4.TabIndex = 31;
            this.smartLabel4.Text = "Department :";
            // 
            // lvAdmResAssign
            // 
            this.lvAdmResAssign.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvAdmResAssign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAdmResAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAdmResAssign.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAdmResAssign.FullRowSelect = true;
            this.lvAdmResAssign.GridLines = true;
            this.lvAdmResAssign.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAdmResAssign.Location = new System.Drawing.Point(-1, 96);
            this.lvAdmResAssign.Name = "lvAdmResAssign";
            this.lvAdmResAssign.Size = new System.Drawing.Size(862, 358);
            this.lvAdmResAssign.TabIndex = 35;
            this.lvAdmResAssign.TabStop = false;
            this.lvAdmResAssign.UseCompatibleStateImageBehavior = false;
            this.lvAdmResAssign.View = System.Windows.Forms.View.Details;
            this.lvAdmResAssign.SelectedIndexChanged += new System.EventHandler(this.lvAdmResAssign_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(792, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 193;
            this.label3.Text = "*";
            // 
            // frmAdmReasonAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(865, 581);
            this.isEnterTabAllow = true;
            this.Name = "frmAdmReasonAssign";
            this.Load += new System.EventHandler(this.frmAdmReasonAssign_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboAdmResAssign;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartListViewDetails lvAdmResAssign;
        private System.Windows.Forms.Label label3;
    }
}
