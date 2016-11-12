﻿namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmDayEnd
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
            this.txtDate = new AtiqsControlLibrary.SmartDateTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboStoreLocation = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(629, 5);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(272, 8);
            this.frmLabel.Size = new System.Drawing.Size(131, 33);
            this.frmLabel.Text = "Day Close";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtDate);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboStoreLocation);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(705, 272);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(706, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(246, 328);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 328);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(360, 328);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(18, 328);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(588, 328);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(474, 328);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 372);
            this.groupBox1.Size = new System.Drawing.Size(706, 23);
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDate.Location = new System.Drawing.Point(200, 98);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(86, 24);
            this.txtDate.TabIndex = 144;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(198, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 30);
            this.btnAdd.TabIndex = 143;
            this.btnAdd.Text = "Start Day Close";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(93, 101);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(43, 18);
            this.smartLabel2.TabIndex = 142;
            this.smartLabel2.Text = "Date :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(87, 71);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(99, 18);
            this.smartLabel1.TabIndex = 141;
            this.smartLabel1.Text = "Store Location :";
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreLocation.ForeColor = System.Drawing.Color.Blue;
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(200, 67);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(361, 26);
            this.cboStoreLocation.TabIndex = 140;
            // 
            // frmDayEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(706, 395);
            this.Name = "frmDayEnd";
            this.Load += new System.EventHandler(this.frmDayEnd_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartDateTextBox txtDate;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboStoreLocation;
    }
}
