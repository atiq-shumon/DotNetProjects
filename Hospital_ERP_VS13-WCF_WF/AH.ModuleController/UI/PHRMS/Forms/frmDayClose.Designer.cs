namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmDayClose
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
            this.cboPharmacy = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(624, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(304, 6);
            this.frmLabel.Size = new System.Drawing.Size(113, 33);
            this.frmLabel.Text = "Day End";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtDate);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboPharmacy);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(702, 232);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(702, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(240, 299);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 299);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(354, 299);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 299);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(582, 299);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(468, 299);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 338);
            this.groupBox1.Size = new System.Drawing.Size(702, 23);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(113, 38);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(69, 15);
            this.smartLabel1.TabIndex = 3;
            this.smartLabel1.Text = "Pharmacy :";
            // 
            // cboPharmacy
            // 
            this.cboPharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPharmacy.ForeColor = System.Drawing.Color.Blue;
            this.cboPharmacy.FormattingEnabled = true;
            this.cboPharmacy.Location = new System.Drawing.Point(226, 34);
            this.cboPharmacy.Name = "cboPharmacy";
            this.cboPharmacy.Size = new System.Drawing.Size(361, 26);
            this.cboPharmacy.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(119, 68);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(39, 15);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "Date :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(224, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Start Day Close";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDate.Location = new System.Drawing.Point(226, 65);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(86, 24);
            this.txtDate.TabIndex = 139;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // frmDayClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(699, 361);
            this.isEnterTabAllow = true;
            this.Name = "frmDayClose";
            this.Load += new System.EventHandler(this.frmDayClose_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboPharmacy;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartDateTextBox txtDate;
    }
}
