namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmStepDetailsSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.cboLevels = new AtiqsControlLibrary.SmartComboBox();
            this.dgvSalaryHead = new AtiqsControlLibrary.SmartDataGridView();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboGrade = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboScale = new AtiqsControlLibrary.SmartComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryHead)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(158, 9);
            this.frmLabel.Size = new System.Drawing.Size(231, 33);
            this.frmLabel.Text = "Step Details Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnGenerate);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboScale);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboGrade);
            this.pnlMain.Controls.Add(this.dgvSalaryHead);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.cboLevels);
            this.pnlMain.Size = new System.Drawing.Size(570, 636);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(572, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 555);
            this.btnEdit.Size = new System.Drawing.Size(30, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(338, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 555);
            this.btnDelete.Size = new System.Drawing.Size(35, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(225, 555);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(452, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(72, 555);
            this.btnPrint.Size = new System.Drawing.Size(20, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(572, 25);
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(11, 154);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(38, 13);
            this.smartLabel8.TabIndex = 200;
            this.smartLabel8.Text = "Level";
            // 
            // cboLevels
            // 
            this.cboLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevels.ForeColor = System.Drawing.Color.Blue;
            this.cboLevels.FormattingEnabled = true;
            this.cboLevels.Location = new System.Drawing.Point(11, 172);
            this.cboLevels.Name = "cboLevels";
            this.cboLevels.Size = new System.Drawing.Size(211, 26);
            this.cboLevels.TabIndex = 199;
            this.cboLevels.SelectedIndexChanged += new System.EventHandler(this.cboLevels_SelectedIndexChanged);
            // 
            // dgvSalaryHead
            // 
            this.dgvSalaryHead.AllowUserToAddRows = false;
            this.dgvSalaryHead.AllowUserToDeleteRows = false;
            this.dgvSalaryHead.AllowUserToOrderColumns = true;
            this.dgvSalaryHead.AllowUserToResizeColumns = false;
            this.dgvSalaryHead.AllowUserToResizeRows = false;
            this.dgvSalaryHead.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalaryHead.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSalaryHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryHead.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaryHead.Location = new System.Drawing.Point(11, 273);
            this.dgvSalaryHead.MultiSelect = false;
            this.dgvSalaryHead.Name = "dgvSalaryHead";
            this.dgvSalaryHead.RowHeadersVisible = false;
            this.dgvSalaryHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaryHead.Size = new System.Drawing.Size(548, 358);
            this.dgvSalaryHead.TabIndex = 201;
            this.dgvSalaryHead.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryHead_CellLeave);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(228, 154);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(41, 13);
            this.smartLabel1.TabIndex = 203;
            this.smartLabel1.Text = "Grade";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.ForeColor = System.Drawing.Color.Blue;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(228, 172);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(127, 26);
            this.cboGrade.TabIndex = 202;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(360, 154);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(33, 13);
            this.smartLabel2.TabIndex = 205;
            this.smartLabel2.Text = "Step";
            // 
            // cboScale
            // 
            this.cboScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboScale.ForeColor = System.Drawing.Color.Blue;
            this.cboScale.FormattingEnabled = true;
            this.cboScale.Location = new System.Drawing.Point(360, 172);
            this.cboScale.Name = "cboScale";
            this.cboScale.Size = new System.Drawing.Size(121, 26);
            this.cboScale.TabIndex = 204;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(486, 172);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(73, 26);
            this.btnShow.TabIndex = 206;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(11, 205);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(39, 13);
            this.smartLabel4.TabIndex = 208;
            this.smartLabel4.Text = "Gross";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(11, 224);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(123, 24);
            this.txtAmount.TabIndex = 207;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(139, 222);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(84, 26);
            this.btnGenerate.TabIndex = 212;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmStepDetailsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(572, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmStepDetailsSetup";
            this.Load += new System.EventHandler(this.frmStepDetailsSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartComboBox cboLevels;
        private AtiqsControlLibrary.SmartDataGridView dgvSalaryHead;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboGrade;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboScale;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartNumericTextBox txtAmount;
        private System.Windows.Forms.Button btnGenerate;
    }
}
