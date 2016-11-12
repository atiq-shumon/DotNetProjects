namespace AH.ModuleController.UI.NWMS
{
    partial class frmBedStatusChange
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboBedStatus = new AtiqsControlLibrary.SmartComboBox();
            this.txtBedTitle = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtBedID = new AtiqsControlLibrary.SmartTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(105, 9);
            this.frmLabel.Size = new System.Drawing.Size(239, 33);
            this.frmLabel.Text = "Bed Status Change";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(440, 211);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(440, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 291);
            this.btnEdit.Size = new System.Drawing.Size(14, 18);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 281);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "OK";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 281);
            this.btnDelete.Size = new System.Drawing.Size(10, 13);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(32, 291);
            this.btnNew.Size = new System.Drawing.Size(10, 18);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(308, 281);
            this.btnClose.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(26, 281);
            this.btnPrint.Size = new System.Drawing.Size(10, 13);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 321);
            this.groupBox1.Size = new System.Drawing.Size(440, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(86, 70);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(41, 13);
            this.smartLabel1.TabIndex = 2;
            this.smartLabel1.Text = "Bed : ";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(81, 132);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(59, 13);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Status  : ";
            // 
            // cboBedStatus
            // 
            this.cboBedStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBedStatus.ForeColor = System.Drawing.Color.Blue;
            this.cboBedStatus.FormattingEnabled = true;
            this.cboBedStatus.ItemHeight = 18;
            this.cboBedStatus.Items.AddRange(new object[] {
            "--Select--",
            "Clean",
            "Need To Clean",
            "Damaged",
            "Blocked"});
            this.cboBedStatus.Location = new System.Drawing.Point(157, 125);
            this.cboBedStatus.Name = "cboBedStatus";
            this.cboBedStatus.Size = new System.Drawing.Size(176, 26);
            this.cboBedStatus.TabIndex = 4;
            // 
            // txtBedTitle
            // 
            this.txtBedTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtBedTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBedTitle.Location = new System.Drawing.Point(157, 64);
            this.txtBedTitle.Name = "txtBedTitle";
            this.txtBedTitle.ReadOnly = true;
            this.txtBedTitle.Size = new System.Drawing.Size(176, 24);
            this.txtBedTitle.TabIndex = 5;
            this.txtBedTitle.TabStop = false;
            // 
            // txtBedID
            // 
            this.txtBedID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedID.Location = new System.Drawing.Point(157, 34);
            this.txtBedID.Name = "txtBedID";
            this.txtBedID.Size = new System.Drawing.Size(176, 24);
            this.txtBedID.TabIndex = 6;
            this.txtBedID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBedTitle);
            this.groupBox2.Controls.Add(this.txtBedID);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.cboBedStatus);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 205);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // frmBedStatusChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 346);
            this.isEnterTabAllow = true;
            this.Name = "frmBedStatusChange";
            this.Load += new System.EventHandler(this.frmBedStatusChange_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboBedStatus;
        public AtiqsControlLibrary.SmartTextBox txtBedID;
        public AtiqsControlLibrary.SmartReadOnlyTextBox txtBedTitle;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}