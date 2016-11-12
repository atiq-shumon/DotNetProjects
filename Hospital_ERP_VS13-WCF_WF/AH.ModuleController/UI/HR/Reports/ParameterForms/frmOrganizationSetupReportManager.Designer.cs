namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    partial class frmOrganizationSetupReportManager
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
            this.rdoDesignation = new AtiqsControlLibrary.SmartRadioButton();
            this.rdoDeptList = new AtiqsControlLibrary.SmartRadioButton();
            this.gbInformationControlls = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.rdoDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(638, 442);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(524, 442);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(136, 10);
            this.frmLabel.Size = new System.Drawing.Size(456, 32);
            this.frmLabel.Text = "Organization Setup Report Manager";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbInformationControlls);
            this.pnlMain.Controls.Add(this.rdoDepartment);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(748, 383);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(748, 57);
            // 
            // rdoDepartment
            // 
            this.rdoDepartment.Controls.Add(this.rdoDesignation);
            this.rdoDepartment.Controls.Add(this.rdoDeptList);
            this.rdoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDepartment.Location = new System.Drawing.Point(3, 18);
            this.rdoDepartment.Name = "rdoDepartment";
            this.rdoDepartment.Size = new System.Drawing.Size(186, 360);
            this.rdoDepartment.TabIndex = 20;
            this.rdoDepartment.TabStop = false;
            this.rdoDepartment.Text = "Report Option";
            // 
            // rdoDesignation
            // 
            this.rdoDesignation.AutoSize = true;
            this.rdoDesignation.BackColor = System.Drawing.Color.Transparent;
            this.rdoDesignation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDesignation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDesignation.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDesignation.ForeColor = System.Drawing.Color.Gray;
            this.rdoDesignation.Location = new System.Drawing.Point(6, 73);
            this.rdoDesignation.Name = "rdoDesignation";
            this.rdoDesignation.Size = new System.Drawing.Size(132, 22);
            this.rdoDesignation.TabIndex = 1;
            this.rdoDesignation.Text = "Designation List";
            this.rdoDesignation.UseVisualStyleBackColor = false;
            // 
            // rdoDeptList
            // 
            this.rdoDeptList.AutoSize = true;
            this.rdoDeptList.BackColor = System.Drawing.Color.Transparent;
            this.rdoDeptList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDeptList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDeptList.Font = new System.Drawing.Font("Georgia", 11F);
            this.rdoDeptList.ForeColor = System.Drawing.Color.Gray;
            this.rdoDeptList.Location = new System.Drawing.Point(6, 29);
            this.rdoDeptList.Name = "rdoDeptList";
            this.rdoDeptList.Size = new System.Drawing.Size(133, 22);
            this.rdoDeptList.TabIndex = 0;
            this.rdoDeptList.Text = "Department List";
            this.rdoDeptList.UseVisualStyleBackColor = false;
            // 
            // gbInformationControlls
            // 
            this.gbInformationControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationControlls.Location = new System.Drawing.Point(195, 18);
            this.gbInformationControlls.Name = "gbInformationControlls";
            this.gbInformationControlls.Size = new System.Drawing.Size(531, 60);
            this.gbInformationControlls.TabIndex = 21;
            this.gbInformationControlls.TabStop = false;
            this.gbInformationControlls.Text = "Information";
            // 
            // frmOrganizationSetupReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(748, 506);
            this.Name = "frmOrganizationSetupReportManager";
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.rdoDepartment.ResumeLayout(false);
            this.rdoDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rdoDepartment;
        private AtiqsControlLibrary.SmartRadioButton rdoDeptList;
        private System.Windows.Forms.GroupBox gbInformationControlls;
        private AtiqsControlLibrary.SmartRadioButton rdoDesignation;
    }
}
