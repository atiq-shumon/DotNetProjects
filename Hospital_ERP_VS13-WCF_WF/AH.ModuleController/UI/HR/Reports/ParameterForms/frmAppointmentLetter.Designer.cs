namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    partial class frmAppointmentLetter
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
            this.rdoDepartment = new System.Windows.Forms.GroupBox();
            this.rdoPhyAppLetter = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoConAppLetter = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoAppForGeneral = new AtiqsControlLibrary.SmartRadioButton();
            this.txtReffNumber = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(257, 32);
            this.frmLabel.Text = "Appointment Letter";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtReffNumber);
            this.pnlMain.Controls.Add(this.rdoDepartment);
            this.pnlMain.Size = new System.Drawing.Size(721, 383);
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoPhyAppLetter);
            this.rdoDepartment.Controls.Add(this.rdoConAppLetter);
            this.rdoDepartment.Controls.Add(this.rdoAppForGeneral);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(29, 5);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(277, 377);
            this.rdoDepartment.TabIndex = 20;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoPhyAppLetter
            // 
            this.rdoPhyAppLetter.AutoSize = true;
            this.rdoPhyAppLetter.BackColor = System.Drawing.Color.Transparent;
            this.rdoPhyAppLetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPhyAppLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPhyAppLetter.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoPhyAppLetter.ForeColor = System.Drawing.Color.Gray;
            this.rdoPhyAppLetter.Location = new System.Drawing.Point(6, 106);
            this.rdoPhyAppLetter.Name = "rdoPhyAppLetter";
            this.rdoPhyAppLetter.Size = new System.Drawing.Size(223, 22);
            this.rdoPhyAppLetter.TabIndex = 6;
            this.rdoPhyAppLetter.Text = "Physician Appointment Letter";
            this.rdoPhyAppLetter.UseVisualStyleBackColor = false;
            this.rdoPhyAppLetter.CheckedChanged += new System.EventHandler(this.rdoPhyAppLetter_CheckedChanged);
            // 
            // rdoConAppLetter
            // 
            this.rdoConAppLetter.AutoSize = true;
            this.rdoConAppLetter.BackColor = System.Drawing.Color.Transparent;
            this.rdoConAppLetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoConAppLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoConAppLetter.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoConAppLetter.ForeColor = System.Drawing.Color.Gray;
            this.rdoConAppLetter.Location = new System.Drawing.Point(6, 64);
            this.rdoConAppLetter.Name = "rdoConAppLetter";
            this.rdoConAppLetter.Size = new System.Drawing.Size(238, 22);
            this.rdoConAppLetter.TabIndex = 5;
            this.rdoConAppLetter.Text = "Contractual Appointment Letter";
            this.rdoConAppLetter.UseVisualStyleBackColor = false;
            this.rdoConAppLetter.CheckedChanged += new System.EventHandler(this.rdoConAppLetter_CheckedChanged);
            // 
            // rdoAppForGeneral
            // 
            this.rdoAppForGeneral.AutoSize = true;
            this.rdoAppForGeneral.BackColor = System.Drawing.Color.Transparent;
            this.rdoAppForGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAppForGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAppForGeneral.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoAppForGeneral.ForeColor = System.Drawing.Color.Gray;
            this.rdoAppForGeneral.Location = new System.Drawing.Point(6, 23);
            this.rdoAppForGeneral.Name = "rdoAppForGeneral";
            this.rdoAppForGeneral.Size = new System.Drawing.Size(212, 22);
            this.rdoAppForGeneral.TabIndex = 4;
            this.rdoAppForGeneral.Text = "General Appointment Letter";
            this.rdoAppForGeneral.UseVisualStyleBackColor = false;
            this.rdoAppForGeneral.CheckedChanged += new System.EventHandler(this.rdoAppForGeneral_CheckedChanged);
            // 
            // txtReffNumber
            // 
            this.txtReffNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReffNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReffNumber.Location = new System.Drawing.Point(443, 28);
            this.txtReffNumber.Name = "txtReffNumber";
            this.txtReffNumber.Size = new System.Drawing.Size(269, 24);
            this.txtReffNumber.TabIndex = 21;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(312, 34);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(125, 13);
            this.smartLabel1.TabIndex = 22;
            this.smartLabel1.Text = "Referrence Number :";
            // 
            // frmAppointmentLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 506);
            this.Name = "frmAppointmentLetter";
            this.Load += new System.EventHandler(this.frmAppointmentLetter_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.rdoDepartment.ResumeLayout(false);
            this.rdoDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rdoDepartment;
        private AtiqsControlLibrary.SmartRadioButton rdoAppForGeneral;
        private AtiqsControlLibrary.SmartTextBox txtReffNumber;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartRadioButton rdoConAppLetter;
        private AtiqsControlLibrary.SmartRadioButton rdoPhyAppLetter;
    }
}
