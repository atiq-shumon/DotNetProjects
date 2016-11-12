namespace AH.ModuleController.UI.OPR.Reports.ParameterForms
{
    partial class frmOPRReportsoperation
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
            this.radAll = new AtiqsControlLibrary.SmartRadioButton();
            this.radCancel = new AtiqsControlLibrary.SmartRadioButton();
            this.radComplete = new AtiqsControlLibrary.SmartRadioButton();
            this.radEmergency = new AtiqsControlLibrary.SmartRadioButton();
            this.radNormal = new AtiqsControlLibrary.SmartRadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(405, 275);
            this.btnClose.TabIndex = 41;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(291, 275);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(132, 8);
            this.frmLabel.Size = new System.Drawing.Size(291, 32);
            this.frmLabel.Text = "Operation Information";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.dtEndDate);
            this.pnlMain.Controls.Add(this.dtStartDate);
            this.pnlMain.Controls.Add(this.lvlStartDate);
            this.pnlMain.Controls.Add(this.lvlEndDate);
            this.pnlMain.Size = new System.Drawing.Size(604, 218);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(530, 57);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(316, 119);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(144, 26);
            this.dtEndDate.TabIndex = 39;
            this.dtEndDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtEndDate_KeyPress);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(316, 73);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(146, 26);
            this.dtStartDate.TabIndex = 38;
            this.dtStartDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtStartDate_KeyPress);
            // 
            // lvlStartDate
            // 
            this.lvlStartDate.AutoSize = true;
            this.lvlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlStartDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlStartDate.Location = new System.Drawing.Point(233, 73);
            this.lvlStartDate.Name = "lvlStartDate";
            this.lvlStartDate.Size = new System.Drawing.Size(71, 18);
            this.lvlStartDate.TabIndex = 36;
            this.lvlStartDate.Text = "Start Date:";
            // 
            // lvlEndDate
            // 
            this.lvlEndDate.AutoSize = true;
            this.lvlEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lvlEndDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvlEndDate.Location = new System.Drawing.Point(237, 122);
            this.lvlEndDate.Name = "lvlEndDate";
            this.lvlEndDate.Size = new System.Drawing.Size(67, 18);
            this.lvlEndDate.TabIndex = 37;
            this.lvlEndDate.Text = "End Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radAll);
            this.groupBox2.Controls.Add(this.radCancel);
            this.groupBox2.Controls.Add(this.radComplete);
            this.groupBox2.Controls.Add(this.radEmergency);
            this.groupBox2.Controls.Add(this.radNormal);
            this.groupBox2.Location = new System.Drawing.Point(34, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 203);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Font = new System.Drawing.Font("Georgia", 11F);
            this.radAll.ForeColor = System.Drawing.Color.Gray;
            this.radAll.Location = new System.Drawing.Point(23, 20);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(44, 22);
            this.radAll.TabIndex = 42;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // radCancel
            // 
            this.radCancel.AutoSize = true;
            this.radCancel.Font = new System.Drawing.Font("Georgia", 11F);
            this.radCancel.ForeColor = System.Drawing.Color.Gray;
            this.radCancel.Location = new System.Drawing.Point(23, 168);
            this.radCancel.Name = "radCancel";
            this.radCancel.Size = new System.Drawing.Size(71, 22);
            this.radCancel.TabIndex = 46;
            this.radCancel.Text = "Cancel";
            this.radCancel.UseVisualStyleBackColor = true;
            // 
            // radComplete
            // 
            this.radComplete.AutoSize = true;
            this.radComplete.Font = new System.Drawing.Font("Georgia", 11F);
            this.radComplete.ForeColor = System.Drawing.Color.Gray;
            this.radComplete.Location = new System.Drawing.Point(23, 127);
            this.radComplete.Name = "radComplete";
            this.radComplete.Size = new System.Drawing.Size(89, 22);
            this.radComplete.TabIndex = 45;
            this.radComplete.Text = "Complete";
            this.radComplete.UseVisualStyleBackColor = true;
            // 
            // radEmergency
            // 
            this.radEmergency.AutoSize = true;
            this.radEmergency.Font = new System.Drawing.Font("Georgia", 11F);
            this.radEmergency.ForeColor = System.Drawing.Color.Gray;
            this.radEmergency.Location = new System.Drawing.Point(23, 90);
            this.radEmergency.Name = "radEmergency";
            this.radEmergency.Size = new System.Drawing.Size(102, 22);
            this.radEmergency.TabIndex = 44;
            this.radEmergency.Text = "Emergency";
            this.radEmergency.UseVisualStyleBackColor = true;
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Font = new System.Drawing.Font("Georgia", 11F);
            this.radNormal.ForeColor = System.Drawing.Color.Gray;
            this.radNormal.Location = new System.Drawing.Point(23, 55);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(78, 22);
            this.radNormal.TabIndex = 43;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            // 
            // frmOPRReportsoperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(530, 345);
            this.KeyPreview = false;
            this.Name = "frmOPRReportsoperation";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private AtiqsControlLibrary.SmartRadioButton radCancel;
        private AtiqsControlLibrary.SmartRadioButton radComplete;
        private AtiqsControlLibrary.SmartRadioButton radEmergency;
        private AtiqsControlLibrary.SmartRadioButton radNormal;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private AtiqsControlLibrary.SmartLabel lvlStartDate;
        private AtiqsControlLibrary.SmartLabel lvlEndDate;
        private AtiqsControlLibrary.SmartRadioButton radAll;
    }
}
