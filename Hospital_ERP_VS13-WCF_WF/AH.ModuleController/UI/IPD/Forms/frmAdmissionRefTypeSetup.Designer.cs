namespace AH.ModuleController.UI.IPD.Forms
{
    partial class frmAdmissionRefTypeSetup
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
            this.txtTypeTitle = new AtiqsControlLibrary.SmartTextBox();
            this.lblTypeTitle = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeTitleBangla = new AtiqsControlLibrary.SmartTextBox();
            this.lblTypeTitleBangla = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lstAdmissionReffSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRdTypeId = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(784, 4);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(255, 10);
            this.frmLabel.Size = new System.Drawing.Size(338, 33);
            this.frmLabel.Text = "Admission Reference Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtRdTypeId);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.lstAdmissionReffSetup);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtTypeTitleBangla);
            this.pnlMain.Controls.Add(this.lblTypeTitleBangla);
            this.pnlMain.Controls.Add(this.txtTypeTitle);
            this.pnlMain.Controls.Add(this.lblTypeTitle);
            this.pnlMain.Location = new System.Drawing.Point(-1, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 469);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(862, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(635, 533);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(522, 533);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(82, 534);
            this.btnDelete.Size = new System.Drawing.Size(43, 22);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(409, 533);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(749, 533);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(28, 536);
            this.btnPrint.Size = new System.Drawing.Size(48, 19);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 573);
            this.groupBox1.Size = new System.Drawing.Size(862, 23);
            // 
            // txtTypeTitle
            // 
            this.txtTypeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeTitle.Location = new System.Drawing.Point(155, 55);
            this.txtTypeTitle.Name = "txtTypeTitle";
            this.txtTypeTitle.Size = new System.Drawing.Size(253, 24);
            this.txtTypeTitle.TabIndex = 1;
            this.txtTypeTitle.TextChanged += new System.EventHandler(this.txtTypeTitle_TextChanged);
            // 
            // lblTypeTitle
            // 
            this.lblTypeTitle.AutoSize = true;
            this.lblTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTypeTitle.Location = new System.Drawing.Point(64, 55);
            this.lblTypeTitle.Name = "lblTypeTitle";
            this.lblTypeTitle.Size = new System.Drawing.Size(72, 13);
            this.lblTypeTitle.TabIndex = 29;
            this.lblTypeTitle.Text = "Type Title :";
            // 
            // txtTypeTitleBangla
            // 
            this.txtTypeTitleBangla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeTitleBangla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeTitleBangla.Location = new System.Drawing.Point(155, 95);
            this.txtTypeTitleBangla.Name = "txtTypeTitleBangla";
            this.txtTypeTitleBangla.Size = new System.Drawing.Size(253, 24);
            this.txtTypeTitleBangla.TabIndex = 2;
            // 
            // lblTypeTitleBangla
            // 
            this.lblTypeTitleBangla.AutoSize = true;
            this.lblTypeTitleBangla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTypeTitleBangla.Location = new System.Drawing.Point(9, 97);
            this.lblTypeTitleBangla.Name = "lblTypeTitleBangla";
            this.lblTypeTitleBangla.Size = new System.Drawing.Size(127, 13);
            this.lblTypeTitleBangla.TabIndex = 31;
            this.lblTypeTitleBangla.Text = "Type Title (Bangla ) :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(470, 13);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(387, 106);
            this.txtRemarks.TabIndex = 3;
            // 
            // lstAdmissionReffSetup
            // 
            this.lstAdmissionReffSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstAdmissionReffSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAdmissionReffSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstAdmissionReffSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAdmissionReffSetup.FullRowSelect = true;
            this.lstAdmissionReffSetup.GridLines = true;
            this.lstAdmissionReffSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstAdmissionReffSetup.Location = new System.Drawing.Point(-1, 142);
            this.lstAdmissionReffSetup.Name = "lstAdmissionReffSetup";
            this.lstAdmissionReffSetup.Size = new System.Drawing.Size(863, 322);
            this.lstAdmissionReffSetup.TabIndex = 34;
            this.lstAdmissionReffSetup.UseCompatibleStateImageBehavior = false;
            this.lstAdmissionReffSetup.View = System.Windows.Forms.View.Details;
            this.lstAdmissionReffSetup.SelectedIndexChanged += new System.EventHandler(this.lstAdmissionReffSetup_SelectedIndexChanged);
            // 
            // txtRdTypeId
            // 
            this.txtRdTypeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRdTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRdTypeId.Location = new System.Drawing.Point(155, 13);
            this.txtRdTypeId.MaxLength = 1;
            this.txtRdTypeId.Name = "txtRdTypeId";
            this.txtRdTypeId.Size = new System.Drawing.Size(119, 24);
            this.txtRdTypeId.TabIndex = 0;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(72, 13);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(64, 13);
            this.smartLabel1.TabIndex = 40;
            this.smartLabel1.Text = "Type ID : ";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(402, 15);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(64, 13);
            this.smartLabel2.TabIndex = 39;
            this.smartLabel2.Text = "Remarks :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(410, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 193;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(411, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 194;
            this.label1.Text = "*";
            // 
            // frmAdmissionRefTypeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(862, 596);
            this.isEnterTabAllow = true;
            this.Name = "frmAdmissionRefTypeSetup";
            this.Load += new System.EventHandler(this.frmAdmissionRefTypeSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lstAdmissionReffSetup;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtTypeTitleBangla;
        private AtiqsControlLibrary.SmartLabel lblTypeTitleBangla;
        private AtiqsControlLibrary.SmartTextBox txtTypeTitle;
        private AtiqsControlLibrary.SmartLabel lblTypeTitle;
        private AtiqsControlLibrary.SmartTextBox txtRdTypeId;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;

    }
}
