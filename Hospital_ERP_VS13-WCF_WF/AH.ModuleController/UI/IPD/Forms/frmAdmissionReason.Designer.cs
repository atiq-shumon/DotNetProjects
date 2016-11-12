namespace AH.ModuleController.UI.IPD.Forms
{
    partial class frmAdmissionReason
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtReasonNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtReasonName = new AtiqsControlLibrary.SmartTextBox();
            this.lvAdmRsn = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtMinStayDays = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtReasonID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(230, 33);
            this.frmLabel.Text = "Admission Reason";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtMinStayDays);
            this.pnlMain.Controls.Add(this.lvAdmRsn);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtReasonNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtReasonName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtReasonID);
            this.pnlMain.Size = new System.Drawing.Size(872, 531);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(873, 64);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(411, 22);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(298, 22);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(524, 22);
            this.btnDelete.TabIndex = 17;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(185, 22);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(746, 22);
            this.btnClose.TabIndex = 19;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(546, 537);
            this.btnPrint.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 581);
            this.groupBox1.Size = new System.Drawing.Size(873, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(19, 158);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(151, 18);
            this.smartLabel3.TabIndex = 11;
            this.smartLabel3.Text = "Reason Name (Bangla) :";
            // 
            // txtReasonNameBeng
            // 
            this.txtReasonNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReasonNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonNameBeng.Location = new System.Drawing.Point(187, 155);
            this.txtReasonNameBeng.Name = "txtReasonNameBeng";
            this.txtReasonNameBeng.Size = new System.Drawing.Size(412, 24);
            this.txtReasonNameBeng.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(72, 116);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(98, 18);
            this.smartLabel2.TabIndex = 10;
            this.smartLabel2.Text = "Reason Name :";
            // 
            // txtReasonName
            // 
            this.txtReasonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReasonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonName.Location = new System.Drawing.Point(187, 113);
            this.txtReasonName.Name = "txtReasonName";
            this.txtReasonName.Size = new System.Drawing.Size(412, 24);
            this.txtReasonName.TabIndex = 1;
            // 
            // lvAdmRsn
            // 
            this.lvAdmRsn.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvAdmRsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAdmRsn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAdmRsn.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAdmRsn.FullRowSelect = true;
            this.lvAdmRsn.GridLines = true;
            this.lvAdmRsn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAdmRsn.Location = new System.Drawing.Point(3, 195);
            this.lvAdmRsn.Name = "lvAdmRsn";
            this.lvAdmRsn.Size = new System.Drawing.Size(868, 331);
            this.lvAdmRsn.TabIndex = 12;
            this.lvAdmRsn.TabStop = false;
            this.lvAdmRsn.UseCompatibleStateImageBehavior = false;
            this.lvAdmRsn.View = System.Windows.Forms.View.Details;
            this.lvAdmRsn.SelectedIndexChanged += new System.EventHandler(this.lvAdmRsn_SelectedIndexChanged);
            // 
            // txtMinStayDays
            // 
            this.txtMinStayDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinStayDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinStayDays.Location = new System.Drawing.Point(711, 155);
            this.txtMinStayDays.Name = "txtMinStayDays";
            this.txtMinStayDays.Size = new System.Drawing.Size(100, 24);
            this.txtMinStayDays.TabIndex = 3;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(607, 156);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(102, 18);
            this.smartLabel4.TabIndex = 14;
            this.smartLabel4.Text = "Min Stay Days :";
            // 
            // txtReasonID
            // 
            this.txtReasonID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReasonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonID.Location = new System.Drawing.Point(187, 72);
            this.txtReasonID.Name = "txtReasonID";
            this.txtReasonID.Size = new System.Drawing.Size(112, 24);
            this.txtReasonID.TabIndex = 0;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(93, 75);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(77, 18);
            this.smartLabel1.TabIndex = 8;
            this.smartLabel1.Text = "Reason ID :";
            // 
            // frmAdmissionReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(873, 604);
            this.Name = "frmAdmissionReason";
            this.Load += new System.EventHandler(this.frmAdmissionReason_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtReasonNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtReasonName;
        private AtiqsControlLibrary.SmartListViewDetails lvAdmRsn;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartNumericTextBox txtMinStayDays;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtReasonID;
    }
}