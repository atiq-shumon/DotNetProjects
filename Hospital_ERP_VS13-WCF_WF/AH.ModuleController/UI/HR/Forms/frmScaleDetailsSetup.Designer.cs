namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmScaleDetailsSetup
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
            this.cboGrade = new AtiqsControlLibrary.SmartComboBox();
            this.cboScale = new AtiqsControlLibrary.SmartComboBox();
            this.cboHead = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvScaleDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel83 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.cboLevels = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(784, 3);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(327, 9);
            this.frmLabel.Size = new System.Drawing.Size(231, 33);
            this.frmLabel.Text = "Step Details Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.cboLevels);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel83);
            this.pnlMain.Controls.Add(this.lvScaleDetails);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboHead);
            this.pnlMain.Controls.Add(this.cboScale);
            this.pnlMain.Controls.Add(this.cboGrade);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(863, 510);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(526, 570);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(412, 570);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 573);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(298, 570);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(752, 570);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(641, 570);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 615);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.ForeColor = System.Drawing.Color.Blue;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(183, 36);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(136, 26);
            this.cboGrade.TabIndex = 0;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // cboScale
            // 
            this.cboScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboScale.ForeColor = System.Drawing.Color.Blue;
            this.cboScale.FormattingEnabled = true;
            this.cboScale.Location = new System.Drawing.Point(347, 36);
            this.cboScale.Name = "cboScale";
            this.cboScale.Size = new System.Drawing.Size(117, 26);
            this.cboScale.TabIndex = 1;
            this.cboScale.SelectedIndexChanged += new System.EventHandler(this.cboScale_SelectedIndexChanged);
            // 
            // cboHead
            // 
            this.cboHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHead.ForeColor = System.Drawing.Color.Blue;
            this.cboHead.FormattingEnabled = true;
            this.cboHead.Location = new System.Drawing.Point(492, 36);
            this.cboHead.Name = "cboHead";
            this.cboHead.Size = new System.Drawing.Size(148, 26);
            this.cboHead.TabIndex = 2;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(183, 18);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(41, 13);
            this.smartLabel1.TabIndex = 3;
            this.smartLabel1.Text = "Grade";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(347, 18);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(33, 13);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "Step";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(492, 18);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(76, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Salary Head";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(667, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(162, 24);
            this.txtAmount.TabIndex = 3;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(667, 18);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(49, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Amount";
            // 
            // lvScaleDetails
            // 
            this.lvScaleDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvScaleDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvScaleDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvScaleDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvScaleDetails.FullRowSelect = true;
            this.lvScaleDetails.GridLines = true;
            this.lvScaleDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvScaleDetails.Location = new System.Drawing.Point(-1, 126);
            this.lvScaleDetails.Name = "lvScaleDetails";
            this.lvScaleDetails.Size = new System.Drawing.Size(863, 383);
            this.lvScaleDetails.TabIndex = 8;
            this.lvScaleDetails.UseCompatibleStateImageBehavior = false;
            this.lvScaleDetails.View = System.Windows.Forms.View.Details;
            this.lvScaleDetails.SelectedIndexChanged += new System.EventHandler(this.lvScaleDetails_SelectedIndexChanged);
            this.lvScaleDetails.Click += new System.EventHandler(this.lvScaleDetails_Click);
            // 
            // smartLabel83
            // 
            this.smartLabel83.AutoSize = true;
            this.smartLabel83.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel83.ForeColor = System.Drawing.Color.Red;
            this.smartLabel83.Location = new System.Drawing.Point(319, 37);
            this.smartLabel83.Name = "smartLabel83";
            this.smartLabel83.Size = new System.Drawing.Size(21, 22);
            this.smartLabel83.TabIndex = 193;
            this.smartLabel83.Text = "*";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.ForeColor = System.Drawing.Color.Red;
            this.smartLabel5.Location = new System.Drawing.Point(466, 37);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(21, 22);
            this.smartLabel5.TabIndex = 194;
            this.smartLabel5.Text = "*";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.ForeColor = System.Drawing.Color.Red;
            this.smartLabel6.Location = new System.Drawing.Point(643, 37);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(21, 22);
            this.smartLabel6.TabIndex = 195;
            this.smartLabel6.Text = "*";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.Red;
            this.smartLabel7.Location = new System.Drawing.Point(832, 38);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(21, 22);
            this.smartLabel7.TabIndex = 196;
            this.smartLabel7.Text = "*";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(7, 18);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(38, 13);
            this.smartLabel8.TabIndex = 198;
            this.smartLabel8.Text = "Level";
            this.smartLabel8.Click += new System.EventHandler(this.smartLabel8_Click);
            // 
            // cboLevels
            // 
            this.cboLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevels.ForeColor = System.Drawing.Color.Blue;
            this.cboLevels.FormattingEnabled = true;
            this.cboLevels.Location = new System.Drawing.Point(7, 36);
            this.cboLevels.Name = "cboLevels";
            this.cboLevels.Size = new System.Drawing.Size(169, 26);
            this.cboLevels.TabIndex = 197;
            this.cboLevels.SelectedIndexChanged += new System.EventHandler(this.cboLevels_SelectedIndexChanged);
            // 
            // frmScaleDetailsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 638);
            this.isEnterTabAllow = true;
            this.Name = "frmScaleDetailsSetup";
            this.Load += new System.EventHandler(this.frmSalaryDetailsSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartNumericTextBox txtAmount;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboHead;
        private AtiqsControlLibrary.SmartComboBox cboScale;
        private AtiqsControlLibrary.SmartComboBox cboGrade;
        private AtiqsControlLibrary.SmartListViewDetails lvScaleDetails;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel83;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartComboBox cboLevels;
    }
}
