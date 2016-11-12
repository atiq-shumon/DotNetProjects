namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmVistedPatientList
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
            this.lvTicketList = new AtiqsControlLibrary.SmartListViewDetails();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecord = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(242, 9);
            this.frmLabel.Size = new System.Drawing.Size(294, 33);
            this.frmLabel.Text = "Prescribed Patient\'s List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvTicketList);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(742, 443);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(742, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(41, 506);
            this.btnEdit.Size = new System.Drawing.Size(10, 14);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 506);
            this.btnSave.Size = new System.Drawing.Size(10, 14);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 506);
            this.btnDelete.Size = new System.Drawing.Size(10, 14);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(59, 506);
            this.btnNew.Size = new System.Drawing.Size(10, 14);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(622, 506);
            this.btnClose.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(25, 506);
            this.btnPrint.Size = new System.Drawing.Size(10, 14);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 547);
            this.groupBox1.Size = new System.Drawing.Size(742, 27);
            // 
            // lvTicketList
            // 
            this.lvTicketList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvTicketList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTicketList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTicketList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTicketList.FullRowSelect = true;
            this.lvTicketList.GridLines = true;
            this.lvTicketList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTicketList.Location = new System.Drawing.Point(0, -1);
            this.lvTicketList.Name = "lvTicketList";
            this.lvTicketList.Size = new System.Drawing.Size(740, 442);
            this.lvTicketList.TabIndex = 2;
            this.lvTicketList.UseCompatibleStateImageBehavior = false;
            this.lvTicketList.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(266, 516);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(202, 20);
            this.lblRecord.TabIndex = 16;
            this.lblRecord.Text = "Sorry, No Record Found";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVistedPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 574);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label1);
            this.isEnterTabAllow = true;
            this.Name = "frmVistedPatientList";
            this.Load += new System.EventHandler(this.frmVistedPatientList_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblRecord, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvTicketList;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartLabel lblRecord;
    }
}