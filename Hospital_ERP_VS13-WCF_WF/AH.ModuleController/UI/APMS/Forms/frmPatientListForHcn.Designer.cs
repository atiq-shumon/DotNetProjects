namespace AH.ModuleController.UI.APMS.Forms
{
    partial class frmPatientListForHcn
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
            this.lstPatientList = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtPatientMobile = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(294, 9);
            this.frmLabel.Size = new System.Drawing.Size(252, 33);
            this.frmLabel.Text = "Patient List For HCN";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtPatientMobile);
            this.pnlMain.Controls.Add(this.lstPatientList);
            this.pnlMain.Size = new System.Drawing.Size(869, 636);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(869, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(56, 555);
            this.btnEdit.Size = new System.Drawing.Size(10, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 555);
            this.btnSave.Size = new System.Drawing.Size(10, 39);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(72, 555);
            this.btnDelete.Size = new System.Drawing.Size(10, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(640, 555);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(751, 555);
            this.btnClose.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(88, 553);
            this.btnPrint.Size = new System.Drawing.Size(10, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 594);
            this.groupBox1.Size = new System.Drawing.Size(869, 25);
            // 
            // lstPatientList
            // 
            this.lstPatientList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstPatientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPatientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPatientList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPatientList.FullRowSelect = true;
            this.lstPatientList.GridLines = true;
            this.lstPatientList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPatientList.Location = new System.Drawing.Point(-1, 240);
            this.lstPatientList.Name = "lstPatientList";
            this.lstPatientList.Size = new System.Drawing.Size(868, 393);
            this.lstPatientList.TabIndex = 0;
            this.lstPatientList.UseCompatibleStateImageBehavior = false;
            this.lstPatientList.View = System.Windows.Forms.View.Details;
            // 
            // txtPatientMobile
            // 
            this.txtPatientMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientMobile.Location = new System.Drawing.Point(30, 191);
            this.txtPatientMobile.Name = "txtPatientMobile";
            this.txtPatientMobile.Size = new System.Drawing.Size(251, 24);
            this.txtPatientMobile.TabIndex = 0;
            this.txtPatientMobile.Enter += new System.EventHandler(this.txtPatientMobile_Enter);
            this.txtPatientMobile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPatientMobile_KeyUp);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(35, 169);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(156, 16);
            this.smartLabel1.TabIndex = 2;
            this.smartLabel1.Text = "Phone Number/Name";
            // 
            // frmPatientListForHcn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(869, 619);
            this.isEnterTabAllow = true;
            this.Name = "frmPatientListForHcn";
            this.Load += new System.EventHandler(this.frmPatientListForHcn_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lstPatientList;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtPatientMobile;
    }
}
