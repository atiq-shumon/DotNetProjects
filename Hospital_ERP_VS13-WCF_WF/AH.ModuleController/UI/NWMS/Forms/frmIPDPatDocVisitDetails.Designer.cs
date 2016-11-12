namespace AH.ModuleController.UI.NWMS.Forms
{
    partial class frmIPDPatDocVisitDetails
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
            this.lvIPDDoctors = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtPatRegNoIPD = new AtiqsControlLibrary.SmartTextBox();
            this.lblIRegNo = new AtiqsControlLibrary.SmartLabel();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(188, 9);
            this.frmLabel.Size = new System.Drawing.Size(403, 33);
            this.frmLabel.Text = "IPD Patients Doctors Visit Details";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvIPDDoctors);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(735, 492);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(735, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(24, 554);
            this.btnEdit.Size = new System.Drawing.Size(10, 10);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 554);
            this.btnSave.Size = new System.Drawing.Size(10, 10);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 567);
            this.btnDelete.Size = new System.Drawing.Size(10, 10);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(499, 553);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(613, 554);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(25, 567);
            this.btnPrint.Size = new System.Drawing.Size(10, 10);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(735, 25);
            // 
            // lvIPDDoctors
            // 
            this.lvIPDDoctors.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvIPDDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvIPDDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvIPDDoctors.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvIPDDoctors.FullRowSelect = true;
            this.lvIPDDoctors.GridLines = true;
            this.lvIPDDoctors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvIPDDoctors.Location = new System.Drawing.Point(0, 73);
            this.lvIPDDoctors.Name = "lvIPDDoctors";
            this.lvIPDDoctors.Size = new System.Drawing.Size(733, 417);
            this.lvIPDDoctors.TabIndex = 94;
            this.lvIPDDoctors.UseCompatibleStateImageBehavior = false;
            this.lvIPDDoctors.View = System.Windows.Forms.View.Details;
            // 
            // txtPatRegNoIPD
            // 
            this.txtPatRegNoIPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatRegNoIPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatRegNoIPD.Location = new System.Drawing.Point(281, 19);
            this.txtPatRegNoIPD.MaxLength = 11;
            this.txtPatRegNoIPD.Name = "txtPatRegNoIPD";
            this.txtPatRegNoIPD.Size = new System.Drawing.Size(144, 24);
            this.txtPatRegNoIPD.TabIndex = 91;
            // 
            // lblIRegNo
            // 
            this.lblIRegNo.AutoSize = true;
            this.lblIRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIRegNo.Location = new System.Drawing.Point(167, 23);
            this.lblIRegNo.Name = "lblIRegNo";
            this.lblIRegNo.Size = new System.Drawing.Size(112, 16);
            this.lblIRegNo.TabIndex = 93;
            this.lblIRegNo.Text = "Admission No :";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(449, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 35);
            this.btnFind.TabIndex = 92;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.lblIRegNo);
            this.groupBox2.Controls.Add(this.txtPatRegNoIPD);
            this.groupBox2.Location = new System.Drawing.Point(7, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 60);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            // 
            // frmIPDPatDocVisitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmIPDPatDocVisitDetails";
            this.Load += new System.EventHandler(this.frmIPDPatDocVisitDetails_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        private AtiqsControlLibrary.SmartLabel lblIRegNo;
        private AtiqsControlLibrary.SmartTextBox txtPatRegNoIPD;
        private AtiqsControlLibrary.SmartListViewDetails lvIPDDoctors;

    }
}