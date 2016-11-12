namespace AH.ModuleController.UI.IPD.Forms
{
    partial class frmCancelReasonSetup
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
            this.lstCancelReason = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtReasonNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtReasonName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtReasonID = new AtiqsControlLibrary.SmartTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(309, 9);
            this.frmLabel.Size = new System.Drawing.Size(263, 33);
            this.frmLabel.Text = "Cancel Reason Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.lstCancelReason);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtReasonNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtReasonName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtReasonID);
            this.pnlMain.Location = new System.Drawing.Point(-1, 54);
            this.pnlMain.Size = new System.Drawing.Size(865, 496);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(636, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(523, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(49, 557);
            this.btnDelete.Size = new System.Drawing.Size(34, 33);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(410, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(89, 565);
            this.btnPrint.Size = new System.Drawing.Size(34, 25);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 594);
            this.groupBox1.Size = new System.Drawing.Size(864, 23);
            // 
            // lstCancelReason
            // 
            this.lstCancelReason.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstCancelReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCancelReason.CheckBoxes = true;
            this.lstCancelReason.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCancelReason.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCancelReason.FullRowSelect = true;
            this.lstCancelReason.GridLines = true;
            this.lstCancelReason.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCancelReason.Location = new System.Drawing.Point(0, 198);
            this.lstCancelReason.Name = "lstCancelReason";
            this.lstCancelReason.Size = new System.Drawing.Size(862, 293);
            this.lstCancelReason.TabIndex = 51;
            this.lstCancelReason.UseCompatibleStateImageBehavior = false;
            this.lstCancelReason.View = System.Windows.Forms.View.Details;
            this.lstCancelReason.SelectedIndexChanged += new System.EventHandler(this.lstCancelReason_SelectedIndexChanged);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(92, 145);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(65, 15);
            this.smartLabel5.TabIndex = 50;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(172, 145);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(412, 46);
            this.txtRemarks.TabIndex = 46;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(22, 98);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(123, 15);
            this.smartLabel3.TabIndex = 49;
            this.smartLabel3.Text = "Type Name (Bangla) :";
            // 
            // txtReasonNameBeng
            // 
            this.txtReasonNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReasonNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonNameBeng.Location = new System.Drawing.Point(172, 95);
            this.txtReasonNameBeng.Name = "txtReasonNameBeng";
            this.txtReasonNameBeng.Size = new System.Drawing.Size(412, 24);
            this.txtReasonNameBeng.TabIndex = 45;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(75, 56);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(73, 15);
            this.smartLabel2.TabIndex = 48;
            this.smartLabel2.Text = "Type Name :";
            // 
            // txtReasonName
            // 
            this.txtReasonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReasonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonName.Location = new System.Drawing.Point(172, 53);
            this.txtReasonName.Name = "txtReasonName";
            this.txtReasonName.Size = new System.Drawing.Size(412, 24);
            this.txtReasonName.TabIndex = 44;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(96, 15);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(55, 15);
            this.smartLabel1.TabIndex = 47;
            this.smartLabel1.Text = "Type ID :";
            // 
            // txtReasonID
            // 
            this.txtReasonID.BackColor = System.Drawing.SystemColors.Window;
            this.txtReasonID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReasonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReasonID.Location = new System.Drawing.Point(172, 12);
            this.txtReasonID.Name = "txtReasonID";
            this.txtReasonID.Size = new System.Drawing.Size(112, 24);
            this.txtReasonID.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(587, 55);
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
            this.label1.Location = new System.Drawing.Point(587, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 194;
            this.label1.Text = "*";
            // 
            // frmCancelReasonSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 617);
            this.isEnterTabAllow = true;
            this.Name = "frmCancelReasonSetup";
            this.Load += new System.EventHandler(this.frmCancelReasonSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lstCancelReason;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtReasonNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtReasonName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtReasonID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
