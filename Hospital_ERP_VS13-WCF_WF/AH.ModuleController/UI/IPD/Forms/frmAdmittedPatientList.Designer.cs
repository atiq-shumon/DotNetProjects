namespace AH.ModuleController.UI.IPD.Forms
{
    partial class frmAdmittedPatientList
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
            this.lstAdmittedPatientList = new AtiqsControlLibrary.SmartListViewDetails();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPatientName = new AtiqsControlLibrary.SmartTextBox();
            this.cboPatDept = new AtiqsControlLibrary.SmartComboBox();
            this.cboFloorNo = new AtiqsControlLibrary.SmartComboBox();
            this.rdoNameWise = new System.Windows.Forms.RadioButton();
            this.rdoSearchByDepartment = new System.Windows.Forms.RadioButton();
            this.rdoFloorWise = new System.Windows.Forms.RadioButton();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.btnRrefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(411, 9);
            this.frmLabel.Size = new System.Drawing.Size(260, 33);
            this.frmLabel.Text = "Admitted Patient List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lstAdmittedPatientList);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(1113, 678);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1114, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(269, 742);
            this.btnEdit.Size = new System.Drawing.Size(14, 27);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 742);
            this.btnSave.Size = new System.Drawing.Size(14, 27);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(289, 742);
            this.btnDelete.Size = new System.Drawing.Size(21, 27);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(887, 742);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1001, 742);
            this.btnClose.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(316, 742);
            this.btnPrint.Size = new System.Drawing.Size(27, 27);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 787);
            this.groupBox1.Size = new System.Drawing.Size(1114, 25);
            // 
            // lstAdmittedPatientList
            // 
            this.lstAdmittedPatientList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstAdmittedPatientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAdmittedPatientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstAdmittedPatientList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAdmittedPatientList.FullRowSelect = true;
            this.lstAdmittedPatientList.GridLines = true;
            this.lstAdmittedPatientList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstAdmittedPatientList.Location = new System.Drawing.Point(0, 186);
            this.lstAdmittedPatientList.Name = "lstAdmittedPatientList";
            this.lstAdmittedPatientList.Size = new System.Drawing.Size(1108, 489);
            this.lstAdmittedPatientList.TabIndex = 0;
            this.lstAdmittedPatientList.UseCompatibleStateImageBehavior = false;
            this.lstAdmittedPatientList.View = System.Windows.Forms.View.Details;
            this.lstAdmittedPatientList.SelectedIndexChanged += new System.EventHandler(this.lstAdmittedPatientList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnRrefresh);
            this.groupBox2.Controls.Add(this.cboUnit);
            this.groupBox2.Controls.Add(this.cboFloorNo);
            this.groupBox2.Controls.Add(this.rdoFloorWise);
            this.groupBox2.Controls.Add(this.cboPatDept);
            this.groupBox2.Controls.Add(this.rdoSearchByDepartment);
            this.groupBox2.Controls.Add(this.rdoNameWise);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox2.Location = new System.Drawing.Point(3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Patient";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(420, 22);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(217, 24);
            this.txtPatientName.TabIndex = 0;
            this.txtPatientName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPatientName_KeyUp);
            // 
            // cboPatDept
            // 
            this.cboPatDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPatDept.ForeColor = System.Drawing.Color.Blue;
            this.cboPatDept.FormattingEnabled = true;
            this.cboPatDept.Location = new System.Drawing.Point(420, 68);
            this.cboPatDept.Name = "cboPatDept";
            this.cboPatDept.Size = new System.Drawing.Size(217, 26);
            this.cboPatDept.TabIndex = 1;
            this.cboPatDept.SelectedIndexChanged += new System.EventHandler(this.cboPatDept_SelectedIndexChanged);
            // 
            // cboFloorNo
            // 
            this.cboFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorNo.ForeColor = System.Drawing.Color.Blue;
            this.cboFloorNo.FormattingEnabled = true;
            this.cboFloorNo.Location = new System.Drawing.Point(420, 123);
            this.cboFloorNo.Name = "cboFloorNo";
            this.cboFloorNo.Size = new System.Drawing.Size(217, 26);
            this.cboFloorNo.TabIndex = 2;
            this.cboFloorNo.SelectedIndexChanged += new System.EventHandler(this.cboFloorNo_SelectedIndexChanged);
            // 
            // rdoNameWise
            // 
            this.rdoNameWise.AutoSize = true;
            this.rdoNameWise.ForeColor = System.Drawing.Color.DarkRed;
            this.rdoNameWise.Location = new System.Drawing.Point(241, 22);
            this.rdoNameWise.Name = "rdoNameWise";
            this.rdoNameWise.Size = new System.Drawing.Size(138, 22);
            this.rdoNameWise.TabIndex = 18;
            this.rdoNameWise.TabStop = true;
            this.rdoNameWise.Text = "Search By Name";
            this.rdoNameWise.UseVisualStyleBackColor = true;
            this.rdoNameWise.CheckedChanged += new System.EventHandler(this.rdoNameWise_CheckedChanged);
            // 
            // rdoSearchByDepartment
            // 
            this.rdoSearchByDepartment.AutoSize = true;
            this.rdoSearchByDepartment.ForeColor = System.Drawing.Color.Crimson;
            this.rdoSearchByDepartment.Location = new System.Drawing.Point(241, 68);
            this.rdoSearchByDepartment.Name = "rdoSearchByDepartment";
            this.rdoSearchByDepartment.Size = new System.Drawing.Size(175, 22);
            this.rdoSearchByDepartment.TabIndex = 19;
            this.rdoSearchByDepartment.TabStop = true;
            this.rdoSearchByDepartment.Text = "Search By Department";
            this.rdoSearchByDepartment.UseVisualStyleBackColor = true;
            this.rdoSearchByDepartment.CheckedChanged += new System.EventHandler(this.rdoSearchByDepartment_CheckedChanged);
            // 
            // rdoFloorWise
            // 
            this.rdoFloorWise.AutoSize = true;
            this.rdoFloorWise.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rdoFloorWise.Location = new System.Drawing.Point(241, 123);
            this.rdoFloorWise.Name = "rdoFloorWise";
            this.rdoFloorWise.Size = new System.Drawing.Size(171, 22);
            this.rdoFloorWise.TabIndex = 20;
            this.rdoFloorWise.TabStop = true;
            this.rdoFloorWise.Text = "Search By Floor Wise";
            this.rdoFloorWise.UseVisualStyleBackColor = true;
            this.rdoFloorWise.CheckedChanged += new System.EventHandler(this.rdoFloorWise_CheckedChanged);
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(664, 68);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(217, 26);
            this.cboUnit.TabIndex = 21;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // btnRrefresh
            // 
            this.btnRrefresh.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnRrefresh.ForeColor = System.Drawing.Color.Blue;
            this.btnRrefresh.Location = new System.Drawing.Point(664, 116);
            this.btnRrefresh.Name = "btnRrefresh";
            this.btnRrefresh.Size = new System.Drawing.Size(217, 31);
            this.btnRrefresh.TabIndex = 22;
            this.btnRrefresh.Text = "Refresh";
            this.btnRrefresh.UseVisualStyleBackColor = false;
            this.btnRrefresh.Click += new System.EventHandler(this.btnRrefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(723, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select Unit";
            // 
            // frmAdmittedPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1114, 812);
            this.isEnterTabAllow = true;
            this.Name = "frmAdmittedPatientList";
            this.Load += new System.EventHandler(this.frmAdmittedPatientList_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lstAdmittedPatientList;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartTextBox txtPatientName;
        private AtiqsControlLibrary.SmartComboBox cboPatDept;
        private AtiqsControlLibrary.SmartComboBox cboFloorNo;
        private System.Windows.Forms.RadioButton rdoSearchByDepartment;
        private System.Windows.Forms.RadioButton rdoNameWise;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private System.Windows.Forms.RadioButton rdoFloorWise;
        private System.Windows.Forms.Button btnRrefresh;
        private System.Windows.Forms.Label label1;
    }
}
