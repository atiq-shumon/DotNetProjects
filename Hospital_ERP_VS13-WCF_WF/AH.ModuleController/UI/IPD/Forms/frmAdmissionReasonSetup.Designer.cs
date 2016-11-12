namespace AH.ModuleController.UI.IPD.Forms
{
    partial class frmAdmissionReasonSetup
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
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtMinStayDays = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtMinStayDay = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lvAdmRsn = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtReasonNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtReasonName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtReasonID = new AtiqsControlLibrary.SmartTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(290, 9);
            this.frmLabel.Size = new System.Drawing.Size(306, 33);
            this.frmLabel.Text = "Admission Reason Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtMinStayDay);
            this.pnlMain.Controls.Add(this.lvAdmRsn);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtReasonNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtReasonName);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtReasonID);
            this.pnlMain.Location = new System.Drawing.Point(0, 2);
            this.pnlMain.Size = new System.Drawing.Size(863, 534);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(525, 545);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(413, 545);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 545);
            this.btnDelete.Size = new System.Drawing.Size(25, 39);
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(299, 545);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 545);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(639, 545);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 586);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(600, 130);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(102, 18);
            this.smartLabel4.TabIndex = 23;
            this.smartLabel4.Text = "Min Stay Days :";
            // 
            // txtMinStayDays
            // 
            this.txtMinStayDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinStayDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinStayDays.Location = new System.Drawing.Point(0, 0);
            this.txtMinStayDays.Name = "txtMinStayDays";
            this.txtMinStayDays.Size = new System.Drawing.Size(100, 24);
            this.txtMinStayDays.TabIndex = 0;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(598, 157);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(102, 18);
            this.smartLabel1.TabIndex = 23;
            this.smartLabel1.Text = "Min Stay Days :";
            // 
            // txtMinStayDay
            // 
            this.txtMinStayDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinStayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinStayDay.Location = new System.Drawing.Point(702, 156);
            this.txtMinStayDay.Name = "txtMinStayDay";
            this.txtMinStayDay.Size = new System.Drawing.Size(100, 24);
            this.txtMinStayDay.TabIndex = 3;
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
            this.lvAdmRsn.Location = new System.Drawing.Point(-1, 201);
            this.lvAdmRsn.Name = "lvAdmRsn";
            this.lvAdmRsn.Size = new System.Drawing.Size(863, 331);
            this.lvAdmRsn.TabIndex = 22;
            this.lvAdmRsn.TabStop = false;
            this.lvAdmRsn.UseCompatibleStateImageBehavior = false;
            this.lvAdmRsn.View = System.Windows.Forms.View.Details;
            this.lvAdmRsn.SelectedIndexChanged += new System.EventHandler(this.lvAdmRsn_SelectedIndexChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(10, 159);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(151, 18);
            this.smartLabel3.TabIndex = 21;
            this.smartLabel3.Text = "Reason Name (Bangla) :";
            // 
            // txtReasonNameBeng
            // 
            this.txtReasonNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReasonNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonNameBeng.Location = new System.Drawing.Point(178, 156);
            this.txtReasonNameBeng.Name = "txtReasonNameBeng";
            this.txtReasonNameBeng.Size = new System.Drawing.Size(412, 24);
            this.txtReasonNameBeng.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(63, 117);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(98, 18);
            this.smartLabel2.TabIndex = 20;
            this.smartLabel2.Text = "Reason Name :";
            // 
            // txtReasonName
            // 
            this.txtReasonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReasonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonName.Location = new System.Drawing.Point(178, 114);
            this.txtReasonName.Name = "txtReasonName";
            this.txtReasonName.Size = new System.Drawing.Size(412, 24);
            this.txtReasonName.TabIndex = 1;
            this.txtReasonName.TextChanged += new System.EventHandler(this.txtReasonName_TextChanged);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(84, 76);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(77, 18);
            this.smartLabel5.TabIndex = 19;
            this.smartLabel5.Text = "Reason ID :";
            // 
            // txtReasonID
            // 
            this.txtReasonID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReasonID.Enabled = false;
            this.txtReasonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonID.Location = new System.Drawing.Point(178, 73);
            this.txtReasonID.Name = "txtReasonID";
            this.txtReasonID.Size = new System.Drawing.Size(112, 24);
            this.txtReasonID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(595, 115);
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
            this.label1.Location = new System.Drawing.Point(808, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 194;
            this.label1.Text = "*";
            // 
            // frmAdmissionReasonSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 609);
            this.isEnterTabAllow = true;
            this.Name = "frmAdmissionReasonSetup";
            this.Load += new System.EventHandler(this.frmAdmissionReasonSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartNumericTextBox txtMinStayDays;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartNumericTextBox txtMinStayDay;
        private AtiqsControlLibrary.SmartListViewDetails lvAdmRsn;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtReasonNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtReasonName;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtReasonID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

    }
}
