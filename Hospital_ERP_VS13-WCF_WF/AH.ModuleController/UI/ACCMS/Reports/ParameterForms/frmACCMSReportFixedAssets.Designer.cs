namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    partial class frmACCMSReportFixedAssets
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
            this.radStraightLine = new System.Windows.Forms.RadioButton();
            this.DGdown = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radRegister = new AtiqsControlLibrary.SmartRadioButton();
            this.radDetails = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(419, 297);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(305, 297);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(240, 9);
            this.frmLabel.Size = new System.Drawing.Size(172, 32);
            this.frmLabel.Text = "Fixed Assets ";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.DGdown);
            this.pnlMain.Controls.Add(this.radStraightLine);
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.lvlStartDate);
            this.pnlMain.Controls.Add(this.lvlEndDate);
            this.pnlMain.Size = new System.Drawing.Size(731, 241);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(546, 57);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(352, 105);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(161, 26);
            this.dtEndDate.TabIndex = 44;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(352, 69);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(161, 26);
            this.dtStartDate.TabIndex = 43;
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(254, 72);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(80, 14);
            this.lvlStartDate.TabIndex = 41;
            this.lvlStartDate.Text = "Start Date:";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(263, 110);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(71, 14);
            this.lvlEndDate.TabIndex = 42;
            this.lvlEndDate.Text = "End Date:";
            // 
            // radStraightLine
            // 
            this.radStraightLine.AutoSize = true;
            this.radStraightLine.Checked = true;
            this.radStraightLine.Location = new System.Drawing.Point(229, 9);
            this.radStraightLine.Name = "radStraightLine";
            this.radStraightLine.Size = new System.Drawing.Size(84, 17);
            this.radStraightLine.TabIndex = 45;
            this.radStraightLine.TabStop = true;
            this.radStraightLine.Text = "Straight Line";
            this.radStraightLine.UseVisualStyleBackColor = true;
            this.radStraightLine.Visible = false;
            // 
            // DGdown
            // 
            this.DGdown.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdown.Location = new System.Drawing.Point(319, 165);
            this.DGdown.Name = "DGdown";
            this.DGdown.Size = new System.Drawing.Size(161, 59);
            this.DGdown.TabIndex = 67;
            this.DGdown.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radRegister);
            this.groupBox2.Controls.Add(this.radDetails);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 139);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // radRegister
            // 
            this.radRegister.AutoSize = true;
            this.radRegister.Font = new System.Drawing.Font("Georgia", 11F);
            this.radRegister.ForeColor = System.Drawing.Color.Gray;
            this.radRegister.Location = new System.Drawing.Point(7, 90);
            this.radRegister.Name = "radRegister";
            this.radRegister.Size = new System.Drawing.Size(164, 22);
            this.radRegister.TabIndex = 1;
            this.radRegister.Text = "Fixed Assets Register";
            this.radRegister.UseVisualStyleBackColor = true;
            this.radRegister.Visible = false;
            // 
            // radDetails
            // 
            this.radDetails.AutoSize = true;
            this.radDetails.Checked = true;
            this.radDetails.Font = new System.Drawing.Font("Georgia", 11F);
            this.radDetails.ForeColor = System.Drawing.Color.Gray;
            this.radDetails.Location = new System.Drawing.Point(7, 37);
            this.radDetails.Name = "radDetails";
            this.radDetails.Size = new System.Drawing.Size(71, 22);
            this.radDetails.TabIndex = 0;
            this.radDetails.TabStop = true;
            this.radDetails.Text = "Details";
            this.radDetails.UseVisualStyleBackColor = true;
            // 
            // frmACCMSReportFixedAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 363);
            this.Name = "frmACCMSReportFixedAssets";
            this.Load += new System.EventHandler(this.frmACCMSReportFixedAssets_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private System.Windows.Forms.RadioButton radStraightLine;
        private System.Windows.Forms.DataGridView DGdown;
        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartRadioButton radRegister;
        private AtiqsControlLibrary.SmartRadioButton radDetails;
    }
}
