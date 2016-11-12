namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmIssue
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.txtTagNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductCode = new AtiqsControlLibrary.SmartTextBox();
            this.txtProductName = new AtiqsControlLibrary.SmartTextBox();
            this.txtTotalQty = new AtiqsControlLibrary.SmartTextBox();
            this.txtIssueQty = new AtiqsControlLibrary.SmartTextBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboAssetsUser = new System.Windows.Forms.ComboBox();
            this.dteIssueDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smartLabel13 = new AtiqsControlLibrary.SmartLabel();
            this.txtSlNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtUnit = new AtiqsControlLibrary.SmartTextBox();
            this.txtModel = new AtiqsControlLibrary.SmartTextBox();
            this.txtBrancode = new AtiqsControlLibrary.SmartTextBox();
            this.txtGroupCode = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(180, 33);
            this.frmLabel.TabIndex = 9;
            this.frmLabel.Text = "Material Issue";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.dteIssueDate);
            this.pnlMain.Controls.Add(this.cboAssetsUser);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.txtIssueQty);
            this.pnlMain.Controls.Add(this.txtTotalQty);
            this.pnlMain.Controls.Add(this.txtProductName);
            this.pnlMain.Controls.Add(this.txtProductCode);
            this.pnlMain.Controls.Add(this.txtTagNo);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(863, 349);
            this.pnlMain.TabIndex = 11;
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(867, 58);
            this.pnlTop.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(8, 270);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(400, 270);
            this.btnSave.TabIndex = 7;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 270);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(180, 270);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(515, 270);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(235, 270);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 312);
            this.groupBox1.Size = new System.Drawing.Size(867, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(95, 176);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(68, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Tag No#:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(469, 176);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(100, 14);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Product Code:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(119, 219);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(43, 14);
            this.smartLabel3.TabIndex = 2;
            this.smartLabel3.Text = "Date:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(466, 219);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(105, 14);
            this.smartLabel4.TabIndex = 3;
            this.smartLabel4.Text = "Product Name:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(34, 257);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(132, 14);
            this.smartLabel5.TabIndex = 4;
            this.smartLabel5.Text = "Department Name:";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(479, 257);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(90, 14);
            this.smartLabel6.TabIndex = 5;
            this.smartLabel6.Text = "Assets User:";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(92, 292);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(73, 14);
            this.smartLabel7.TabIndex = 6;
            this.smartLabel7.Text = "Total Qty:";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(493, 292);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(76, 14);
            this.smartLabel8.TabIndex = 7;
            this.smartLabel8.Text = "Issue Qty:";
            // 
            // txtTagNo
            // 
            this.txtTagNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTagNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagNo.Location = new System.Drawing.Point(173, 176);
            this.txtTagNo.Name = "txtTagNo";
            this.txtTagNo.ReadOnly = true;
            this.txtTagNo.Size = new System.Drawing.Size(229, 24);
            this.txtTagNo.TabIndex = 0;
            this.txtTagNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTagNo_KeyPress);
            // 
            // txtProductCode
            // 
            this.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(577, 176);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(246, 24);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(577, 219);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(246, 24);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.Location = new System.Drawing.Point(173, 292);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.ReadOnly = true;
            this.txtTotalQty.Size = new System.Drawing.Size(100, 24);
            this.txtTotalQty.TabIndex = 11;
            // 
            // txtIssueQty
            // 
            this.txtIssueQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssueQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueQty.Location = new System.Drawing.Point(577, 292);
            this.txtIssueQty.Name = "txtIssueQty";
            this.txtIssueQty.Size = new System.Drawing.Size(120, 24);
            this.txtIssueQty.TabIndex = 6;
            this.txtIssueQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIssueQty_KeyPress);
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(173, 257);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(234, 24);
            this.cboDepartment.TabIndex = 4;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            this.cboDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDepartment_KeyPress);
            this.cboDepartment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboDepartment_KeyUp);
            // 
            // cboAssetsUser
            // 
            this.cboAssetsUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAssetsUser.FormattingEnabled = true;
            this.cboAssetsUser.Location = new System.Drawing.Point(577, 257);
            this.cboAssetsUser.Name = "cboAssetsUser";
            this.cboAssetsUser.Size = new System.Drawing.Size(246, 22);
            this.cboAssetsUser.TabIndex = 5;
            this.cboAssetsUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAssetsUser_KeyPress);
            this.cboAssetsUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboAssetsUser_KeyUp);
            // 
            // dteIssueDate
            // 
            this.dteIssueDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteIssueDate.Location = new System.Drawing.Point(173, 219);
            this.dteIssueDate.Name = "dteIssueDate";
            this.dteIssueDate.Size = new System.Drawing.Size(233, 23);
            this.dteIssueDate.TabIndex = 2;
            this.dteIssueDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteIssueDate_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.smartLabel13);
            this.groupBox2.Controls.Add(this.txtSlNo);
            this.groupBox2.Controls.Add(this.smartLabel12);
            this.groupBox2.Controls.Add(this.smartLabel11);
            this.groupBox2.Controls.Add(this.smartLabel10);
            this.groupBox2.Controls.Add(this.smartLabel9);
            this.groupBox2.Controls.Add(this.txtUnit);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtBrancode);
            this.groupBox2.Controls.Add(this.txtGroupCode);
            this.groupBox2.Location = new System.Drawing.Point(104, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 19);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // smartLabel13
            // 
            this.smartLabel13.AutoSize = true;
            this.smartLabel13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel13.Location = new System.Drawing.Point(48, 169);
            this.smartLabel13.Name = "smartLabel13";
            this.smartLabel13.Size = new System.Drawing.Size(51, 14);
            this.smartLabel13.TabIndex = 35;
            this.smartLabel13.Text = "SL No:";
            // 
            // txtSlNo
            // 
            this.txtSlNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlNo.Location = new System.Drawing.Point(125, 164);
            this.txtSlNo.Name = "txtSlNo";
            this.txtSlNo.Size = new System.Drawing.Size(229, 24);
            this.txtSlNo.TabIndex = 34;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(62, 139);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(37, 14);
            this.smartLabel12.TabIndex = 33;
            this.smartLabel12.Text = "unit:";
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(48, 109);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(51, 14);
            this.smartLabel11.TabIndex = 32;
            this.smartLabel11.Text = "Model:";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(13, 79);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(86, 14);
            this.smartLabel10.TabIndex = 31;
            this.smartLabel10.Text = "Brand code:";
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(10, 44);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(89, 14);
            this.smartLabel9.TabIndex = 30;
            this.smartLabel9.Text = "Group Code:";
            // 
            // txtUnit
            // 
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(125, 134);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(229, 24);
            this.txtUnit.TabIndex = 29;
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(125, 104);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(229, 24);
            this.txtModel.TabIndex = 28;
            // 
            // txtBrancode
            // 
            this.txtBrancode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrancode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrancode.Location = new System.Drawing.Point(125, 74);
            this.txtBrancode.Name = "txtBrancode";
            this.txtBrancode.Size = new System.Drawing.Size(229, 24);
            this.txtBrancode.TabIndex = 27;
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupCode.Location = new System.Drawing.Point(125, 44);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Size = new System.Drawing.Size(229, 24);
            this.txtGroupCode.TabIndex = 26;
            // 
            // frmIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(867, 337);
            this.KeyPreview = false;
            this.Name = "frmIssue";
            this.Load += new System.EventHandler(this.frmIssue_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dteIssueDate;
        private System.Windows.Forms.ComboBox cboAssetsUser;
        private System.Windows.Forms.ComboBox cboDepartment;
        private AtiqsControlLibrary.SmartTextBox txtIssueQty;
        private AtiqsControlLibrary.SmartTextBox txtTotalQty;
        private AtiqsControlLibrary.SmartTextBox txtProductName;
        private AtiqsControlLibrary.SmartTextBox txtProductCode;
        private AtiqsControlLibrary.SmartTextBox txtTagNo;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel13;
        private AtiqsControlLibrary.SmartTextBox txtSlNo;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartTextBox txtUnit;
        private AtiqsControlLibrary.SmartTextBox txtModel;
        private AtiqsControlLibrary.SmartTextBox txtBrancode;
        private AtiqsControlLibrary.SmartTextBox txtGroupCode;

    }
}
