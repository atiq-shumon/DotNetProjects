namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmFringeBenefitSetup
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
            this.components = new System.ComponentModel.Container();
            this.txtBenefitID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtSerial = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtBenefitTitle = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtBenefitTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lvBenefit = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboPeriod = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.chkQuantitive = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel20 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(315, 9);
            this.frmLabel.Size = new System.Drawing.Size(256, 33);
            this.frmLabel.Text = "Fringe Benefit Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.smartLabel20);
            this.pnlMain.Controls.Add(this.chkQuantitive);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboPeriod);
            this.pnlMain.Controls.Add(this.lvBenefit);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtBenefitTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtBenefitTitle);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(877, 510);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(877, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(649, 570);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(535, 570);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 573);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(421, 570);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(764, 570);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(143, 573);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 612);
            this.groupBox1.Size = new System.Drawing.Size(877, 23);
            // 
            // txtBenefitID
            // 
            this.txtBenefitID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtBenefitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBenefitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenefitID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBenefitID.Location = new System.Drawing.Point(352, 588);
            this.txtBenefitID.Name = "txtBenefitID";
            this.txtBenefitID.ReadOnly = true;
            this.txtBenefitID.Size = new System.Drawing.Size(36, 24);
            this.txtBenefitID.TabIndex = 0;
            this.txtBenefitID.TabStop = false;
            this.txtBenefitID.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(343, 572);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(72, 13);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Benefit ID :";
            this.smartLabel1.Visible = false;
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(276, 588);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(33, 24);
            this.txtSerial.TabIndex = 2;
            this.txtSerial.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(273, 573);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(47, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Serial :";
            this.smartLabel2.Visible = false;
            // 
            // txtBenefitTitle
            // 
            this.txtBenefitTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBenefitTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenefitTitle.Location = new System.Drawing.Point(182, 20);
            this.txtBenefitTitle.Name = "txtBenefitTitle";
            this.txtBenefitTitle.Size = new System.Drawing.Size(214, 24);
            this.txtBenefitTitle.TabIndex = 3;
            this.txtBenefitTitle.Text = " ";
            this.txtBenefitTitle.TextChanged += new System.EventHandler(this.txtBenefitTitle_TextChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(79, 26);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(91, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Benefit Name :";
            // 
            // txtBenefitTitleBeng
            // 
            this.txtBenefitTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBenefitTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenefitTitleBeng.Location = new System.Drawing.Point(182, 52);
            this.txtBenefitTitleBeng.Name = "txtBenefitTitleBeng";
            this.txtBenefitTitleBeng.Size = new System.Drawing.Size(214, 24);
            this.txtBenefitTitleBeng.TabIndex = 4;
            this.txtBenefitTitleBeng.Text = " ";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(32, 58);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(138, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Benefit Name(Bangla) :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(182, 125);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(425, 63);
            this.txtRemarks.TabIndex = 5;
            this.txtRemarks.Text = " ";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(106, 125);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(64, 13);
            this.smartLabel5.TabIndex = 9;
            this.smartLabel5.Text = "Remarks :";
            // 
            // lvBenefit
            // 
            this.lvBenefit.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvBenefit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBenefit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvBenefit.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBenefit.FullRowSelect = true;
            this.lvBenefit.GridLines = true;
            this.lvBenefit.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvBenefit.Location = new System.Drawing.Point(-1, 216);
            this.lvBenefit.Name = "lvBenefit";
            this.lvBenefit.Size = new System.Drawing.Size(877, 289);
            this.lvBenefit.TabIndex = 10;
            this.lvBenefit.UseCompatibleStateImageBehavior = false;
            this.lvBenefit.View = System.Windows.Forms.View.Details;
            this.lvBenefit.SelectedIndexChanged += new System.EventHandler(this.lvBenefit_SelectedIndexChanged);
            this.lvBenefit.Click += new System.EventHandler(this.lvBenefit_Click);
            // 
            // cboPeriod
            // 
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriod.ForeColor = System.Drawing.Color.Blue;
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(182, 86);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(215, 26);
            this.cboPeriod.TabIndex = 11;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(75, 93);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(95, 13);
            this.smartLabel6.TabIndex = 12;
            this.smartLabel6.Text = "Benefit Period :";
            // 
            // chkQuantitive
            // 
            this.chkQuantitive.AutoSize = true;
            this.chkQuantitive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkQuantitive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkQuantitive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuantitive.ForeColor = System.Drawing.Color.Black;
            this.chkQuantitive.Location = new System.Drawing.Point(442, 87);
            this.chkQuantitive.Name = "chkQuantitive";
            this.chkQuantitive.Size = new System.Drawing.Size(165, 22);
            this.chkQuantitive.TabIndex = 13;
            this.chkQuantitive.Text = "Is Quantitive Benefit ?";
            this.chkQuantitive.UseVisualStyleBackColor = true;
            // 
            // smartLabel20
            // 
            this.smartLabel20.AutoSize = true;
            this.smartLabel20.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel20.ForeColor = System.Drawing.Color.Red;
            this.smartLabel20.Location = new System.Drawing.Point(399, 20);
            this.smartLabel20.Name = "smartLabel20";
            this.smartLabel20.Size = new System.Drawing.Size(21, 22);
            this.smartLabel20.TabIndex = 155;
            this.smartLabel20.Text = "*";
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.ForeColor = System.Drawing.Color.Red;
            this.smartLabel7.Location = new System.Drawing.Point(399, 52);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(21, 22);
            this.smartLabel7.TabIndex = 156;
            this.smartLabel7.Text = "*";
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.ForeColor = System.Drawing.Color.Red;
            this.smartLabel8.Location = new System.Drawing.Point(399, 86);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(21, 22);
            this.smartLabel8.TabIndex = 157;
            this.smartLabel8.Text = "*";
            // 
            // frmFringeBenefitSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(877, 635);
            this.Controls.Add(this.smartLabel1);
            this.Controls.Add(this.smartLabel2);
            this.Controls.Add(this.txtBenefitID);
            this.Controls.Add(this.txtSerial);
            this.isEnterTabAllow = true;
            this.Name = "frmFringeBenefitSetup";
            this.Load += new System.EventHandler(this.frmFringeBenefitSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtSerial, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.txtBenefitID, 0);
            this.Controls.SetChildIndex(this.smartLabel2, 0);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartReadOnlyTextBox txtBenefitID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtBenefitTitle;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtBenefitTitleBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartListViewDetails lvBenefit;
        private AtiqsControlLibrary.SmartComboBox cboPeriod;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartCheckBox chkQuantitive;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartLabel smartLabel20;
    }
}
