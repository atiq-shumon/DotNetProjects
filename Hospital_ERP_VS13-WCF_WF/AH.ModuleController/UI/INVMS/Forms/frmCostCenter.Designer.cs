namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmCostCenter
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtCostCenterID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lvCostCenter = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtCostCenterName = new AtiqsControlLibrary.SmartTextBox();
            this.cboIssueType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.cboAccCode = new AtiqsControlLibrary.SmartComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(359, 9);
            this.frmLabel.Size = new System.Drawing.Size(153, 33);
            this.frmLabel.Text = "Cost Center";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.cboAccCode);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboIssueType);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtCostCenterID);
            this.pnlMain.Controls.Add(this.lvCostCenter);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtCostCenterName);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(637, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(527, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(23, 554);
            this.btnDelete.Size = new System.Drawing.Size(43, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(417, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(87, 554);
            this.btnPrint.Size = new System.Drawing.Size(46, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 595);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(61, 180);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(27, 15);
            this.smartLabel1.TabIndex = 61;
            this.smartLabel1.Text = "ID :";
            // 
            // txtCostCenterID
            // 
            this.txtCostCenterID.BackColor = System.Drawing.Color.Linen;
            this.txtCostCenterID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostCenterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostCenterID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCostCenterID.Location = new System.Drawing.Point(155, 177);
            this.txtCostCenterID.Name = "txtCostCenterID";
            this.txtCostCenterID.ReadOnly = true;
            this.txtCostCenterID.Size = new System.Drawing.Size(226, 24);
            this.txtCostCenterID.TabIndex = 60;
            this.txtCostCenterID.TabStop = false;
            // 
            // lvCostCenter
            // 
            this.lvCostCenter.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvCostCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCostCenter.CheckBoxes = true;
            this.lvCostCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCostCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCostCenter.FullRowSelect = true;
            this.lvCostCenter.GridLines = true;
            this.lvCostCenter.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCostCenter.Location = new System.Drawing.Point(-1, 321);
            this.lvCostCenter.Name = "lvCostCenter";
            this.lvCostCenter.Size = new System.Drawing.Size(863, 313);
            this.lvCostCenter.TabIndex = 59;
            this.lvCostCenter.TabStop = false;
            this.lvCostCenter.UseCompatibleStateImageBehavior = false;
            this.lvCostCenter.View = System.Windows.Forms.View.Details;
            this.lvCostCenter.SelectedIndexChanged += new System.EventHandler(this.lvCostCenter_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(61, 262);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(65, 15);
            this.smartLabel7.TabIndex = 58;
            this.smartLabel7.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(155, 259);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(424, 56);
            this.txtRemarks.TabIndex = 56;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(61, 207);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(45, 15);
            this.smartLabel2.TabIndex = 57;
            this.smartLabel2.Text = "Name :";
            // 
            // txtCostCenterName
            // 
            this.txtCostCenterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostCenterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostCenterName.Location = new System.Drawing.Point(155, 204);
            this.txtCostCenterName.Name = "txtCostCenterName";
            this.txtCostCenterName.Size = new System.Drawing.Size(357, 24);
            this.txtCostCenterName.TabIndex = 55;
            // 
            // cboIssueType
            // 
            this.cboIssueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIssueType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIssueType.ForeColor = System.Drawing.Color.Blue;
            this.cboIssueType.FormattingEnabled = true;
            this.cboIssueType.Location = new System.Drawing.Point(155, 149);
            this.cboIssueType.Name = "cboIssueType";
            this.cboIssueType.Size = new System.Drawing.Size(226, 26);
            this.cboIssueType.TabIndex = 62;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(61, 153);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(71, 15);
            this.smartLabel3.TabIndex = 63;
            this.smartLabel3.Text = "Issue Type :";
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(61, 234);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(69, 15);
            this.smartLabel10.TabIndex = 96;
            this.smartLabel10.Text = "Acc_Code :";
            // 
            // cboAccCode
            // 
            this.cboAccCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAccCode.ForeColor = System.Drawing.Color.Blue;
            this.cboAccCode.FormattingEnabled = true;
            this.cboAccCode.Location = new System.Drawing.Point(155, 230);
            this.cboAccCode.Name = "cboAccCode";
            this.cboAccCode.Size = new System.Drawing.Size(134, 26);
            this.cboAccCode.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 97;
            this.label1.Text = "*";
            // 
            // frmCostCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 620);
            this.isEnterTabAllow = true;
            this.Name = "frmCostCenter";
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCostCenterID;
        private AtiqsControlLibrary.SmartListViewDetails lvCostCenter;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtCostCenterName;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox cboIssueType;
        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartComboBox cboAccCode;
        private System.Windows.Forms.Label label1;
    }
}
