namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmPostOfficeSetup
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboDistrict = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboThana = new AtiqsControlLibrary.SmartComboBox();
            this.txtPostOffice = new AtiqsControlLibrary.SmartTextBox();
            this.txtPostOfficeOld = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.lvPostOffice = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtPostCode = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtPostCodeOld = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(219, 33);
            this.frmLabel.Text = "Post Office Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtPostCode);
            this.pnlMain.Controls.Add(this.lvPostOffice);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtPostOffice);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboThana);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboDistrict);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(633, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 555);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(407, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(126, 555);
            this.btnPrint.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(11, 157);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(47, 13);
            this.smartLabel1.TabIndex = 3;
            this.smartLabel1.Text = "District";
            // 
            // cboDistrict
            // 
            this.cboDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrict.ForeColor = System.Drawing.Color.Blue;
            this.cboDistrict.FormattingEnabled = true;
            this.cboDistrict.Location = new System.Drawing.Point(11, 179);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Size = new System.Drawing.Size(187, 26);
            this.cboDistrict.TabIndex = 0;
            this.cboDistrict.SelectedIndexChanged += new System.EventHandler(this.cboDistrict_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(205, 157);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(43, 13);
            this.smartLabel2.TabIndex = 5;
            this.smartLabel2.Text = "Thana";
            // 
            // cboThana
            // 
            this.cboThana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThana.ForeColor = System.Drawing.Color.Blue;
            this.cboThana.FormattingEnabled = true;
            this.cboThana.Location = new System.Drawing.Point(205, 179);
            this.cboThana.Name = "cboThana";
            this.cboThana.Size = new System.Drawing.Size(209, 26);
            this.cboThana.TabIndex = 1;
            this.cboThana.SelectedIndexChanged += new System.EventHandler(this.cboThana_SelectedIndexChanged);
            // 
            // txtPostOffice
            // 
            this.txtPostOffice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostOffice.Location = new System.Drawing.Point(548, 179);
            this.txtPostOffice.Name = "txtPostOffice";
            this.txtPostOffice.Size = new System.Drawing.Size(306, 24);
            this.txtPostOffice.TabIndex = 2;
            // 
            // txtPostOfficeOld
            // 
            this.txtPostOfficeOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostOfficeOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostOfficeOld.Location = new System.Drawing.Point(240, 560);
            this.txtPostOfficeOld.Name = "txtPostOfficeOld";
            this.txtPostOfficeOld.Size = new System.Drawing.Size(47, 24);
            this.txtPostOfficeOld.TabIndex = 7;
            this.txtPostOfficeOld.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(545, 157);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(70, 13);
            this.smartLabel3.TabIndex = 7;
            this.smartLabel3.Text = "Post Office";
            // 
            // lvPostOffice
            // 
            this.lvPostOffice.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvPostOffice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPostOffice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPostOffice.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPostOffice.FullRowSelect = true;
            this.lvPostOffice.GridLines = true;
            this.lvPostOffice.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPostOffice.Location = new System.Drawing.Point(0, 224);
            this.lvPostOffice.Name = "lvPostOffice";
            this.lvPostOffice.Size = new System.Drawing.Size(863, 408);
            this.lvPostOffice.TabIndex = 8;
            this.lvPostOffice.UseCompatibleStateImageBehavior = false;
            this.lvPostOffice.View = System.Windows.Forms.View.Details;
            this.lvPostOffice.SelectedIndexChanged += new System.EventHandler(this.lvPostOffice_SelectedIndexChanged);
            this.lvPostOffice.Click += new System.EventHandler(this.lvPostOffice_Click);
            // 
            // txtPostCode
            // 
            this.txtPostCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostCode.Location = new System.Drawing.Point(420, 179);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(122, 24);
            this.txtPostCode.TabIndex = 9;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(417, 157);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(65, 13);
            this.smartLabel4.TabIndex = 10;
            this.smartLabel4.Text = "Post Code";
            // 
            // txtPostCodeOld
            // 
            this.txtPostCodeOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostCodeOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostCodeOld.Location = new System.Drawing.Point(293, 560);
            this.txtPostCodeOld.Name = "txtPostCodeOld";
            this.txtPostCodeOld.Size = new System.Drawing.Size(47, 24);
            this.txtPostCodeOld.TabIndex = 15;
            this.txtPostCodeOld.Visible = false;
            // 
            // frmPostOfficeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.Controls.Add(this.txtPostCodeOld);
            this.Controls.Add(this.txtPostOfficeOld);
            this.isEnterTabAllow = true;
            this.Name = "frmPostOfficeSetup";
            this.Load += new System.EventHandler(this.frmPostOfficeSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtPostOfficeOld, 0);
            this.Controls.SetChildIndex(this.txtPostCodeOld, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDistrict;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboThana;
        private AtiqsControlLibrary.SmartTextBox txtPostOffice;
        private AtiqsControlLibrary.SmartTextBox txtPostOfficeOld;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartListViewDetails lvPostOffice;
        private AtiqsControlLibrary.SmartNumericTextBox txtPostCode;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtPostCodeOld;
    }
}
