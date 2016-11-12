namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmSalaryDetailsSetup
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
            this.txtAmount = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvScaleDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(250, 33);
            this.frmLabel.Text = "Salary Details Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvScaleDetails);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboHead);
            this.pnlMain.Controls.Add(this.cboScale);
            this.pnlMain.Controls.Add(this.cboGrade);
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.ForeColor = System.Drawing.Color.Blue;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(115, 13);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 26);
            this.cboGrade.TabIndex = 0;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // cboScale
            // 
            this.cboScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboScale.ForeColor = System.Drawing.Color.Blue;
            this.cboScale.FormattingEnabled = true;
            this.cboScale.Location = new System.Drawing.Point(115, 57);
            this.cboScale.Name = "cboScale";
            this.cboScale.Size = new System.Drawing.Size(121, 26);
            this.cboScale.TabIndex = 1;
            this.cboScale.SelectedIndexChanged += new System.EventHandler(this.cboScale_SelectedIndexChanged);
            // 
            // cboHead
            // 
            this.cboHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHead.ForeColor = System.Drawing.Color.Blue;
            this.cboHead.FormattingEnabled = true;
            this.cboHead.Location = new System.Drawing.Point(115, 100);
            this.cboHead.Name = "cboHead";
            this.cboHead.Size = new System.Drawing.Size(121, 26);
            this.cboHead.TabIndex = 2;
            this.cboHead.SelectedIndexChanged += new System.EventHandler(this.cboHead_SelectedIndexChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(19, 20);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(41, 13);
            this.smartLabel1.TabIndex = 3;
            this.smartLabel1.Text = "Grade";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(19, 64);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(39, 13);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "Scale";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(19, 107);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(76, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Salary Head";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(468, 46);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(213, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(385, 48);
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
            this.lvScaleDetails.Location = new System.Drawing.Point(-1, 237);
            this.lvScaleDetails.Name = "lvScaleDetails";
            this.lvScaleDetails.Size = new System.Drawing.Size(835, 266);
            this.lvScaleDetails.TabIndex = 8;
            this.lvScaleDetails.UseCompatibleStateImageBehavior = false;
            this.lvScaleDetails.View = System.Windows.Forms.View.Details;
            this.lvScaleDetails.SelectedIndexChanged += new System.EventHandler(this.lvScaleDetails_SelectedIndexChanged);
            // 
            // frmSalaryDetailsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 634);
            this.Name = "frmSalaryDetailsSetup";
            this.Load += new System.EventHandler(this.frmSalaryDetailsSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtAmount;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboHead;
        private AtiqsControlLibrary.SmartComboBox cboScale;
        private AtiqsControlLibrary.SmartComboBox cboGrade;
        private AtiqsControlLibrary.SmartListViewDetails lvScaleDetails;
    }
}
