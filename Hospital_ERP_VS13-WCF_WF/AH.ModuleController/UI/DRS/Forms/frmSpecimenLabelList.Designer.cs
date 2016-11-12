namespace AH.ModuleController.UI.DRS.Forms
{
    partial class frmSpecimenLabelList
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
            this.lvSpecimenLabelList = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtAdvice = new AtiqsControlLibrary.SmartTextBox();
            this.txtComments = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(291, 10);
            this.frmLabel.Size = new System.Drawing.Size(247, 33);
            this.frmLabel.Text = "Specimen Label List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvSpecimenLabelList);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 507);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(418, 572);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 572);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 572);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(192, 572);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(753, 572);
            this.btnClose.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(642, 572);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Size = new System.Drawing.Size(864, 23);
            // 
            // lvSpecimenLabelList
            // 
            this.lvSpecimenLabelList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvSpecimenLabelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSpecimenLabelList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSpecimenLabelList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSpecimenLabelList.FullRowSelect = true;
            this.lvSpecimenLabelList.GridLines = true;
            this.lvSpecimenLabelList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSpecimenLabelList.Location = new System.Drawing.Point(1, 49);
            this.lvSpecimenLabelList.Name = "lvSpecimenLabelList";
            this.lvSpecimenLabelList.Size = new System.Drawing.Size(859, 455);
            this.lvSpecimenLabelList.TabIndex = 94;
            this.lvSpecimenLabelList.UseCompatibleStateImageBehavior = false;
            this.lvSpecimenLabelList.View = System.Windows.Forms.View.Details;
            this.lvSpecimenLabelList.SelectedIndexChanged += new System.EventHandler(this.lvSpecimenLabelList_SelectedIndexChanged);
            // 
            // txtAdvice
            // 
            this.txtAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(6, 581);
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(27, 24);
            this.txtAdvice.TabIndex = 15;
            this.txtAdvice.Visible = false;
            // 
            // txtComments
            // 
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(39, 581);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(27, 24);
            this.txtComments.TabIndex = 16;
            this.txtComments.Visible = false;
            // 
            // frmSpecimenLabelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 634);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtAdvice);
            this.isEnterTabAllow = true;
            this.Name = "frmSpecimenLabelList";
            this.Load += new System.EventHandler(this.frmSpecimenLabelList_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtAdvice, 0);
            this.Controls.SetChildIndex(this.txtComments, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvSpecimenLabelList;
        private AtiqsControlLibrary.SmartTextBox txtAdvice;
        private AtiqsControlLibrary.SmartTextBox txtComments;
    }
}
