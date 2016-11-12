namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    partial class frmStaffTypeSetup
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
            this.lvStaffType = new AtiqsControlLibrary.SmartListViewDetails();
            this.lblRemarks = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lblStaffTypeTitleBangla = new AtiqsControlLibrary.SmartLabel();
            this.txtStaffTypeTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.lblStaffTypeTitle = new AtiqsControlLibrary.SmartLabel();
            this.txtStaffTypeTitle = new AtiqsControlLibrary.SmartTextBox();
            this.lblTypeId = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeId = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblrequired = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(213, 33);
            this.frmLabel.Text = "Staff Type Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvStaffType);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(633, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(519, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 551);
            this.btnDelete.Size = new System.Drawing.Size(10, 17);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(405, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(24, 551);
            this.btnPrint.Size = new System.Drawing.Size(10, 17);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 594);
            // 
            // lvStaffType
            // 
            this.lvStaffType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvStaffType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStaffType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvStaffType.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStaffType.FullRowSelect = true;
            this.lvStaffType.GridLines = true;
            this.lvStaffType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStaffType.Location = new System.Drawing.Point(1, 316);
            this.lvStaffType.Name = "lvStaffType";
            this.lvStaffType.Size = new System.Drawing.Size(858, 316);
            this.lvStaffType.TabIndex = 21;
            this.lvStaffType.TabStop = false;
            this.lvStaffType.UseCompatibleStateImageBehavior = false;
            this.lvStaffType.View = System.Windows.Forms.View.Details;
            this.lvStaffType.SelectedIndexChanged += new System.EventHandler(this.lvStaffType_SelectedIndexChanged);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.Location = new System.Drawing.Point(158, 133);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(68, 18);
            this.lblRemarks.TabIndex = 20;
            this.lblRemarks.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(230, 129);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(471, 28);
            this.txtRemarks.TabIndex = 4;
            // 
            // lblStaffTypeTitleBangla
            // 
            this.lblStaffTypeTitleBangla.AutoSize = true;
            this.lblStaffTypeTitleBangla.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffTypeTitleBangla.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStaffTypeTitleBangla.Location = new System.Drawing.Point(73, 93);
            this.lblStaffTypeTitleBangla.Name = "lblStaffTypeTitleBangla";
            this.lblStaffTypeTitleBangla.Size = new System.Drawing.Size(153, 18);
            this.lblStaffTypeTitleBangla.TabIndex = 18;
            this.lblStaffTypeTitleBangla.Text = "Staff Type Title Bangla :";
            // 
            // txtStaffTypeTitleBeng
            // 
            this.txtStaffTypeTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffTypeTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffTypeTitleBeng.Location = new System.Drawing.Point(230, 89);
            this.txtStaffTypeTitleBeng.Multiline = true;
            this.txtStaffTypeTitleBeng.Name = "txtStaffTypeTitleBeng";
            this.txtStaffTypeTitleBeng.Size = new System.Drawing.Size(471, 28);
            this.txtStaffTypeTitleBeng.TabIndex = 3;
            // 
            // lblStaffTypeTitle
            // 
            this.lblStaffTypeTitle.AutoSize = true;
            this.lblStaffTypeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffTypeTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStaffTypeTitle.Location = new System.Drawing.Point(118, 53);
            this.lblStaffTypeTitle.Name = "lblStaffTypeTitle";
            this.lblStaffTypeTitle.Size = new System.Drawing.Size(108, 18);
            this.lblStaffTypeTitle.TabIndex = 17;
            this.lblStaffTypeTitle.Text = "Staff Type Title :";
            // 
            // txtStaffTypeTitle
            // 
            this.txtStaffTypeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffTypeTitle.Location = new System.Drawing.Point(230, 49);
            this.txtStaffTypeTitle.Multiline = true;
            this.txtStaffTypeTitle.Name = "txtStaffTypeTitle";
            this.txtStaffTypeTitle.Size = new System.Drawing.Size(471, 28);
            this.txtStaffTypeTitle.TabIndex = 2;
            this.txtStaffTypeTitle.TextChanged += new System.EventHandler(this.txtStaffTypeTitle_TextChanged);
            // 
            // lblTypeId
            // 
            this.lblTypeId.AutoSize = true;
            this.lblTypeId.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTypeId.Location = new System.Drawing.Point(162, 15);
            this.lblTypeId.Name = "lblTypeId";
            this.lblTypeId.Size = new System.Drawing.Size(64, 18);
            this.lblTypeId.TabIndex = 14;
            this.lblTypeId.Text = "Type ID :";
            // 
            // txtTypeId
            // 
            this.txtTypeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtTypeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTypeId.Location = new System.Drawing.Point(230, 11);
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.ReadOnly = true;
            this.txtTypeId.Size = new System.Drawing.Size(173, 24);
            this.txtTypeId.TabIndex = 1;
            this.txtTypeId.TabStop = false;
            // 
            // lblrequired
            // 
            this.lblrequired.AutoSize = true;
            this.lblrequired.BackColor = System.Drawing.Color.Transparent;
            this.lblrequired.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblrequired.ForeColor = System.Drawing.Color.Red;
            this.lblrequired.Location = new System.Drawing.Point(706, 51);
            this.lblrequired.Name = "lblrequired";
            this.lblrequired.Size = new System.Drawing.Size(21, 26);
            this.lblrequired.TabIndex = 94;
            this.lblrequired.Text = "*";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.ForeColor = System.Drawing.Color.Red;
            this.smartLabel1.Location = new System.Drawing.Point(706, 91);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(21, 26);
            this.smartLabel1.TabIndex = 95;
            this.smartLabel1.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.lblrequired);
            this.groupBox2.Controls.Add(this.lblRemarks);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.txtTypeId);
            this.groupBox2.Controls.Add(this.lblStaffTypeTitleBangla);
            this.groupBox2.Controls.Add(this.lblTypeId);
            this.groupBox2.Controls.Add(this.txtStaffTypeTitleBeng);
            this.groupBox2.Controls.Add(this.txtStaffTypeTitle);
            this.groupBox2.Controls.Add(this.lblStaffTypeTitle);
            this.groupBox2.Location = new System.Drawing.Point(4, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 165);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            // 
            // frmStaffTypeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(864, 619);
            this.isEnterTabAllow = true;
            this.Name = "frmStaffTypeSetup";
            this.Load += new System.EventHandler(this.frmStaffTypeSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvStaffType;
        private AtiqsControlLibrary.SmartLabel lblRemarks;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel lblStaffTypeTitleBangla;
        private AtiqsControlLibrary.SmartTextBox txtStaffTypeTitleBeng;
        private AtiqsControlLibrary.SmartLabel lblStaffTypeTitle;
        private AtiqsControlLibrary.SmartTextBox txtStaffTypeTitle;
        private AtiqsControlLibrary.SmartLabel lblTypeId;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtTypeId;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel lblrequired;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}