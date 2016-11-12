namespace AH.ModuleController.UI.ATMS.Reports.ParameterForms
{
    partial class frmATMSReportstockinformation
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
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lvlStartDate = new AtiqsControlLibrary.SmartLabel();
            this.lvlEndDate = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radCssd = new AtiqsControlLibrary.SmartRadioButton();
            this.radHouseKeeping = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(571, 304);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(457, 304);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(240, 9);
            this.frmLabel.Size = new System.Drawing.Size(230, 32);
            this.frmLabel.Text = "Store Information";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.lvlStartDate);
            this.pnlMain.Controls.Add(this.lvlEndDate);
            this.pnlMain.Size = new System.Drawing.Size(721, 245);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(393, 107);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(184, 26);
            this.dtEndDate.TabIndex = 26;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(393, 61);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(184, 26);
            this.dtStartDate.TabIndex = 25;
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(305, 66);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(71, 18);
            this.lvlStartDate.TabIndex = 23;
            this.lvlStartDate.Text = "Start Date:";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(309, 111);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(67, 18);
            this.lvlEndDate.TabIndex = 24;
            this.lvlEndDate.Text = "End Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radCssd);
            this.groupBox2.Controls.Add(this.radHouseKeeping);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 174);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // radCssd
            // 
            this.radCssd.AutoSize = true;
            this.radCssd.Font = new System.Drawing.Font("Georgia", 11F);
            this.radCssd.ForeColor = System.Drawing.Color.Gray;
            this.radCssd.Location = new System.Drawing.Point(38, 81);
            this.radCssd.Name = "radCssd";
            this.radCssd.Size = new System.Drawing.Size(63, 22);
            this.radCssd.TabIndex = 30;
            this.radCssd.Text = "CSSD";
            this.radCssd.UseVisualStyleBackColor = true;
            // 
            // radHouseKeeping
            // 
            this.radHouseKeeping.AutoSize = true;
            this.radHouseKeeping.Checked = true;
            this.radHouseKeeping.Font = new System.Drawing.Font("Georgia", 11F);
            this.radHouseKeeping.ForeColor = System.Drawing.Color.Gray;
            this.radHouseKeeping.Location = new System.Drawing.Point(38, 35);
            this.radHouseKeeping.Name = "radHouseKeeping";
            this.radHouseKeeping.Size = new System.Drawing.Size(125, 22);
            this.radHouseKeeping.TabIndex = 29;
            this.radHouseKeeping.TabStop = true;
            this.radHouseKeeping.Text = "House Keeping";
            this.radHouseKeeping.UseVisualStyleBackColor = true;
            // 
            // frmATMSReportstockinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 372);
            this.Name = "frmATMSReportstockinformation";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartRadioButton radCssd;
        private AtiqsControlLibrary.SmartRadioButton radHouseKeeping;
    }
}
