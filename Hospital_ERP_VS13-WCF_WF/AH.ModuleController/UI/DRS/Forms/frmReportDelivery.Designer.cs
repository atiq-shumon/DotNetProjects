namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmReportDelivery
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
            this.cboRptGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartTextBox1 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartComboBox1 = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartComboBox2 = new AtiqsControlLibrary.SmartComboBox();
            this.smartTextBox2 = new AtiqsControlLibrary.SmartTextBox();
            this.smartRadioButton1 = new AtiqsControlLibrary.SmartRadioButton();
            this.smartTextBox3 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lvUndeliveryList = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboPatientMr = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(731, 5);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(284, 6);
            this.frmLabel.Size = new System.Drawing.Size(197, 33);
            this.frmLabel.Text = "Report Delivery";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboPatientMr);
            this.pnlMain.Controls.Add(this.lvUndeliveryList);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartTextBox3);
            this.pnlMain.Controls.Add(this.smartRadioButton1);
            this.pnlMain.Controls.Add(this.smartTextBox2);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartComboBox2);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartComboBox1);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.smartTextBox1);
            this.pnlMain.Controls.Add(this.cboRptGroup);
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Size = new System.Drawing.Size(780, 426);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(781, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(356, 493);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(554, 493);
            this.btnSave.Text = "OK";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(126, 492);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(242, 492);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(668, 493);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(21, 492);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 532);
            this.groupBox1.Size = new System.Drawing.Size(781, 23);
            // 
            // cboRptGroup
            // 
            this.cboRptGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRptGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRptGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboRptGroup.FormattingEnabled = true;
            this.cboRptGroup.Location = new System.Drawing.Point(309, 31);
            this.cboRptGroup.Name = "cboRptGroup";
            this.cboRptGroup.Size = new System.Drawing.Size(250, 26);
            this.cboRptGroup.TabIndex = 0;
            // 
            // smartTextBox1
            // 
            this.smartTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox1.Location = new System.Drawing.Point(11, 124);
            this.smartTextBox1.Name = "smartTextBox1";
            this.smartTextBox1.Size = new System.Drawing.Size(17, 24);
            this.smartTextBox1.TabIndex = 1;
            this.smartTextBox1.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(306, 10);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(96, 18);
            this.smartLabel1.TabIndex = 2;
            this.smartLabel1.Text = "Report Group :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(8, 31);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(250, 26);
            this.cboDepartment.TabIndex = 3;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(8, 10);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(90, 18);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "Department  :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(8, 65);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(104, 18);
            this.smartLabel3.TabIndex = 6;
            this.smartLabel3.Text = "Delivery Mode :";
            // 
            // smartComboBox1
            // 
            this.smartComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smartComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartComboBox1.ForeColor = System.Drawing.Color.Blue;
            this.smartComboBox1.FormattingEnabled = true;
            this.smartComboBox1.Location = new System.Drawing.Point(11, 86);
            this.smartComboBox1.Name = "smartComboBox1";
            this.smartComboBox1.Size = new System.Drawing.Size(250, 26);
            this.smartComboBox1.TabIndex = 5;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(306, 64);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(88, 18);
            this.smartLabel4.TabIndex = 8;
            this.smartLabel4.Text = "Received By :";
            // 
            // smartComboBox2
            // 
            this.smartComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smartComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartComboBox2.ForeColor = System.Drawing.Color.Blue;
            this.smartComboBox2.FormattingEnabled = true;
            this.smartComboBox2.Location = new System.Drawing.Point(309, 85);
            this.smartComboBox2.Name = "smartComboBox2";
            this.smartComboBox2.Size = new System.Drawing.Size(250, 26);
            this.smartComboBox2.TabIndex = 7;
            // 
            // smartTextBox2
            // 
            this.smartTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox2.Location = new System.Drawing.Point(34, 124);
            this.smartTextBox2.Name = "smartTextBox2";
            this.smartTextBox2.Size = new System.Drawing.Size(21, 24);
            this.smartTextBox2.TabIndex = 9;
            this.smartTextBox2.Visible = false;
            // 
            // smartRadioButton1
            // 
            this.smartRadioButton1.AutoSize = true;
            this.smartRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.smartRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smartRadioButton1.Font = new System.Drawing.Font("Georgia", 11F);
            this.smartRadioButton1.ForeColor = System.Drawing.Color.Gray;
            this.smartRadioButton1.Location = new System.Drawing.Point(102, 126);
            this.smartRadioButton1.Name = "smartRadioButton1";
            this.smartRadioButton1.Size = new System.Drawing.Size(156, 22);
            this.smartRadioButton1.TabIndex = 10;
            this.smartRadioButton1.TabStop = true;
            this.smartRadioButton1.Text = "smartRadioButton1";
            this.smartRadioButton1.UseVisualStyleBackColor = false;
            this.smartRadioButton1.Visible = false;
            // 
            // smartTextBox3
            // 
            this.smartTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox3.Location = new System.Drawing.Point(583, 31);
            this.smartTextBox3.Multiline = true;
            this.smartTextBox3.Name = "smartTextBox3";
            this.smartTextBox3.Size = new System.Drawing.Size(184, 75);
            this.smartTextBox3.TabIndex = 11;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(583, 10);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(71, 18);
            this.smartLabel5.TabIndex = 12;
            this.smartLabel5.Text = "Remarks  :";
            // 
            // lvUndeliveryList
            // 
            this.lvUndeliveryList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvUndeliveryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUndeliveryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvUndeliveryList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvUndeliveryList.FullRowSelect = true;
            this.lvUndeliveryList.GridLines = true;
            this.lvUndeliveryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUndeliveryList.Location = new System.Drawing.Point(2, 154);
            this.lvUndeliveryList.Name = "lvUndeliveryList";
            this.lvUndeliveryList.Size = new System.Drawing.Size(776, 271);
            this.lvUndeliveryList.TabIndex = 13;
            this.lvUndeliveryList.UseCompatibleStateImageBehavior = false;
            this.lvUndeliveryList.View = System.Windows.Forms.View.Details;
            // 
            // cboPatientMr
            // 
            this.cboPatientMr.BackColor = System.Drawing.Color.RoyalBlue;
            this.cboPatientMr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPatientMr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPatientMr.ForeColor = System.Drawing.Color.White;
            this.cboPatientMr.Location = new System.Drawing.Point(696, 112);
            this.cboPatientMr.Name = "cboPatientMr";
            this.cboPatientMr.Size = new System.Drawing.Size(71, 34);
            this.cboPatientMr.TabIndex = 14;
            this.cboPatientMr.Text = "Show";
            this.cboPatientMr.UseVisualStyleBackColor = false;
            this.cboPatientMr.Click += new System.EventHandler(this.cboPatientMr_Click);
            // 
            // frmReportDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(781, 555);
            this.isEnterTabAllow = true;
            this.Name = "frmReportDelivery";
            this.Load += new System.EventHandler(this.frmReportDelivery_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboRptGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox smartTextBox1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox smartTextBox3;
        private AtiqsControlLibrary.SmartRadioButton smartRadioButton1;
        private AtiqsControlLibrary.SmartTextBox smartTextBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox smartComboBox2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartComboBox smartComboBox1;
        private AtiqsControlLibrary.SmartListViewDetails lvUndeliveryList;
        private System.Windows.Forms.Button cboPatientMr;
    }
}
