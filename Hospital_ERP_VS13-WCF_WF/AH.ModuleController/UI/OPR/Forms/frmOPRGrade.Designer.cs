namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOPRGrade
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
            this.txtGradeID = new AtiqsControlLibrary.SmartTextBox();
            this.txtGradetitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.Cboactive = new AtiqsControlLibrary.SmartComboBox();
            this.lvwGradeDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(254, 33);
            this.frmLabel.Text = "Grade Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.lvwGradeDetails);
            this.pnlMain.Controls.Add(this.Cboactive);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtGradetitle);
            this.pnlMain.Controls.Add(this.txtGradeID);
            this.pnlMain.Location = new System.Drawing.Point(0, 66);
            this.pnlMain.Size = new System.Drawing.Size(863, 495);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(317, 570);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(203, 570);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 570);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(89, 570);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(659, 570);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(545, 570);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 609);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // txtGradeID
            // 
            this.txtGradeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGradeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeID.Location = new System.Drawing.Point(280, 8);
            this.txtGradeID.Name = "txtGradeID";
            this.txtGradeID.Size = new System.Drawing.Size(334, 24);
            this.txtGradeID.TabIndex = 0;
            this.txtGradeID.Visible = false;
            // 
            // txtGradetitle
            // 
            this.txtGradetitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGradetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradetitle.Location = new System.Drawing.Point(280, 47);
            this.txtGradetitle.Name = "txtGradetitle";
            this.txtGradetitle.Size = new System.Drawing.Size(334, 24);
            this.txtGradetitle.TabIndex = 1;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(280, 87);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(334, 24);
            this.txtRemarks.TabIndex = 3;
            // 
            // Cboactive
            // 
            this.Cboactive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cboactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cboactive.ForeColor = System.Drawing.Color.Blue;
            this.Cboactive.FormattingEnabled = true;
            this.Cboactive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.Cboactive.Location = new System.Drawing.Point(280, 128);
            this.Cboactive.Name = "Cboactive";
            this.Cboactive.Size = new System.Drawing.Size(335, 26);
            this.Cboactive.TabIndex = 4;
            // 
            // lvwGradeDetails
            // 
            this.lvwGradeDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwGradeDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwGradeDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwGradeDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwGradeDetails.FullRowSelect = true;
            this.lvwGradeDetails.GridLines = true;
            this.lvwGradeDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwGradeDetails.Location = new System.Drawing.Point(3, 173);
            this.lvwGradeDetails.Name = "lvwGradeDetails";
            this.lvwGradeDetails.Size = new System.Drawing.Size(831, 314);
            this.lvwGradeDetails.TabIndex = 5;
            this.lvwGradeDetails.UseCompatibleStateImageBehavior = false;
            this.lvwGradeDetails.View = System.Windows.Forms.View.Details;
            this.lvwGradeDetails.SelectedIndexChanged += new System.EventHandler(this.lvwGradeDetails_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(197, 12);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(74, 16);
            this.smartLabel1.TabIndex = 6;
            this.smartLabel1.Text = "Grade ID:";
            this.smartLabel1.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(184, 47);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(90, 16);
            this.smartLabel2.TabIndex = 7;
            this.smartLabel2.Text = "Grade Title:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(196, 86);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(74, 16);
            this.smartLabel3.TabIndex = 8;
            this.smartLabel3.Text = "Remarks:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(214, 134);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(55, 16);
            this.smartLabel4.TabIndex = 9;
            this.smartLabel4.Text = "Status:";
            // 
            // frmOPRGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 634);
            this.Name = "frmOPRGrade";
            this.Load += new System.EventHandler(this.frmOPRGrade_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtGradeID;
        private AtiqsControlLibrary.SmartComboBox Cboactive;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtGradetitle;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwGradeDetails;
    }
}
