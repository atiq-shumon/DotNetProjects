namespace AH.ModuleController.UI.NWMS.Forms
{
    partial class frmIPDDoctorFilter
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
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtPinCode = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboDoctor = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(241, 9);
            this.frmLabel.Size = new System.Drawing.Size(212, 33);
            this.frmLabel.Text = "IPD Doctor Filter";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboDepartmentGroup);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtPinCode);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboDoctor);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(694, 266);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(694, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(40, 343);
            this.btnEdit.Size = new System.Drawing.Size(15, 13);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 343);
            this.btnSave.Size = new System.Drawing.Size(15, 13);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(54, 343);
            this.btnDelete.Size = new System.Drawing.Size(15, 13);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(10, 343);
            this.btnNew.Size = new System.Drawing.Size(15, 13);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(574, 329);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.ImageIndex = 8;
            this.btnPrint.Location = new System.Drawing.Point(442, 329);
            this.btnPrint.Size = new System.Drawing.Size(126, 40);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Proceed";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 369);
            this.groupBox1.Size = new System.Drawing.Size(694, 25);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(132, 209);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(77, 17);
            this.smartLabel4.TabIndex = 15;
            this.smartLabel4.Text = "Pin Code :";
            // 
            // txtPinCode
            // 
            this.txtPinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPinCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.Location = new System.Drawing.Point(224, 205);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(370, 24);
            this.txtPinCode.TabIndex = 4;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(164, 134);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(45, 17);
            this.smartLabel3.TabIndex = 14;
            this.smartLabel3.Text = "Unit :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.Location = new System.Drawing.Point(224, 131);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(370, 26);
            this.cboUnit.TabIndex = 2;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(147, 172);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(62, 17);
            this.smartLabel2.TabIndex = 13;
            this.smartLabel2.Text = "Doctor :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(114, 97);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(95, 17);
            this.smartLabel1.TabIndex = 10;
            this.smartLabel1.Text = "Department :";
            // 
            // cboDoctor
            // 
            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctor.ForeColor = System.Drawing.Color.Blue;
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(224, 168);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(370, 26);
            this.cboDoctor.TabIndex = 3;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(224, 94);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(370, 26);
            this.cboDepartment.TabIndex = 1;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(224, 20);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(370, 26);
            this.cboDepartmentType.TabIndex = 62;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(78, 24);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(131, 17);
            this.smartLabel5.TabIndex = 63;
            this.smartLabel5.Text = "Department Type :";
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(224, 57);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(370, 26);
            this.cboDepartmentGroup.TabIndex = 60;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(69, 62);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(140, 17);
            this.smartLabel6.TabIndex = 61;
            this.smartLabel6.Text = "Department Group :";
            // 
            // frmIPDDoctorFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 394);
            this.isEnterTabAllow = true;
            this.Name = "frmIPDDoctorFilter";
            this.Load += new System.EventHandler(this.frmIPDDoctorFilter_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtPinCode;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDoctor;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
    }
}