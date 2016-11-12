namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmDepartmentSetup
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
            this.txtDepartmentID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtDepartmentName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDeptNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvDept = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboDeptCatagory = new AtiqsControlLibrary.SmartComboBox();
            this.txtSerial1 = new AtiqsControlLibrary.SmartLabel();
            this.txtSerial = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(1088, 4);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(348, 3);
            this.frmLabel.Size = new System.Drawing.Size(232, 33);
            this.frmLabel.Text = "Department Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.lvDept);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDeptNameBang);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtDepartmentName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtDepartmentID);
            this.pnlMain.Location = new System.Drawing.Point(0, 53);
            this.pnlMain.Size = new System.Drawing.Size(962, 605);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(962, 53);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(724, 667);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(610, 668);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 665);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(496, 667);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(838, 667);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(130, 663);
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 709);
            this.groupBox1.Size = new System.Drawing.Size(962, 23);
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtDepartmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDepartmentID.Location = new System.Drawing.Point(192, 15);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.ReadOnly = true;
            this.txtDepartmentID.Size = new System.Drawing.Size(224, 24);
            this.txtDepartmentID.TabIndex = 0;
            this.txtDepartmentID.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(80, 15);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(106, 18);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Department  ID:";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Location = new System.Drawing.Point(192, 57);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(406, 24);
            this.txtDepartmentName.TabIndex = 0;
            this.txtDepartmentName.TextChanged += new System.EventHandler(this.txtDepartmentName_TextChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(61, 57);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(127, 18);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Department Name :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(8, 97);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(180, 18);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Department Name( Bangla) :";
            // 
            // txtDeptNameBang
            // 
            this.txtDeptNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptNameBang.Location = new System.Drawing.Point(192, 97);
            this.txtDeptNameBang.Name = "txtDeptNameBang";
            this.txtDeptNameBang.Size = new System.Drawing.Size(406, 24);
            this.txtDeptNameBang.TabIndex = 1;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(120, 137);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 12;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(192, 137);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(406, 51);
            this.txtRemarks.TabIndex = 2;
            // 
            // lvDept
            // 
            this.lvDept.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDept.CheckBoxes = true;
            this.lvDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDept.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDept.FullRowSelect = true;
            this.lvDept.GridLines = true;
            this.lvDept.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDept.Location = new System.Drawing.Point(-1, 209);
            this.lvDept.Name = "lvDept";
            this.lvDept.Size = new System.Drawing.Size(962, 391);
            this.lvDept.TabIndex = 41;
            this.lvDept.UseCompatibleStateImageBehavior = false;
            this.lvDept.View = System.Windows.Forms.View.Details;
            this.lvDept.SelectedIndexChanged += new System.EventHandler(this.lvDept_SelectedIndexChanged);
            this.lvDept.Click += new System.EventHandler(this.lvDept_Click);
            // 
            // cboDeptCatagory
            // 
            this.cboDeptCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptCatagory.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptCatagory.FormattingEnabled = true;
            this.cboDeptCatagory.Location = new System.Drawing.Point(268, 675);
            this.cboDeptCatagory.Name = "cboDeptCatagory";
            this.cboDeptCatagory.Size = new System.Drawing.Size(80, 26);
            this.cboDeptCatagory.TabIndex = 1;
            this.cboDeptCatagory.Visible = false;
            // 
            // txtSerial1
            // 
            this.txtSerial1.AutoSize = true;
            this.txtSerial1.BackColor = System.Drawing.Color.Transparent;
            this.txtSerial1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSerial1.Location = new System.Drawing.Point(195, 675);
            this.txtSerial1.Name = "txtSerial1";
            this.txtSerial1.Size = new System.Drawing.Size(67, 18);
            this.txtSerial1.TabIndex = 43;
            this.txtSerial1.Text = "Catagory :";
            this.txtSerial1.Visible = false;
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(130, 683);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(30, 24);
            this.txtSerial.TabIndex = 44;
            this.txtSerial.Visible = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(116, 662);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(49, 18);
            this.smartLabel6.TabIndex = 45;
            this.smartLabel6.Text = "Serial :";
            this.smartLabel6.Visible = false;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.ForeColor = System.Drawing.Color.Red;
            this.smartLabel9.Location = new System.Drawing.Point(600, 55);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(21, 22);
            this.smartLabel9.TabIndex = 194;
            this.smartLabel9.Text = "*";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.ForeColor = System.Drawing.Color.Red;
            this.smartLabel10.Location = new System.Drawing.Point(600, 95);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(21, 22);
            this.smartLabel10.TabIndex = 195;
            this.smartLabel10.Text = "*";
            // 
            // frmDepartmentSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(962, 732);
            this.Controls.Add(this.smartLabel6);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.txtSerial1);
            this.Controls.Add(this.cboDeptCatagory);
            this.isEnterTabAllow = true;
            this.Name = "frmDepartmentSetup";
            this.Load += new System.EventHandler(this.frmDepartmentSetup_Load);
            this.Controls.SetChildIndex(this.cboDeptCatagory, 0);
            this.Controls.SetChildIndex(this.txtSerial1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtSerial, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.smartLabel6, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDepartmentName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDepartmentID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDeptNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartListViewDetails lvDept;
        private AtiqsControlLibrary.SmartComboBox cboDeptCatagory;
        private AtiqsControlLibrary.SmartLabel txtSerial1;
        private AtiqsControlLibrary.SmartTextBox txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
    }
}
