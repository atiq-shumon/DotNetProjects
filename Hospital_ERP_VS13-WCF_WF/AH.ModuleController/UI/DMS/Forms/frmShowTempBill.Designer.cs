namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmShowTempBill
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
            this.lvDraftList = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtEntryBy = new AtiqsControlLibrary.SmartTextBox();
            this.cboPatientSearch = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(344, 10);
            this.frmLabel.Size = new System.Drawing.Size(123, 33);
            this.frmLabel.Text = "Draft List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvDraftList);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 501);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(417, 565);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 565);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(530, 565);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(191, 565);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(752, 565);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(641, 565);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 612);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // lvDraftList
            // 
            this.lvDraftList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDraftList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDraftList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDraftList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDraftList.FullRowSelect = true;
            this.lvDraftList.GridLines = true;
            this.lvDraftList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDraftList.Location = new System.Drawing.Point(-1, -1);
            this.lvDraftList.Name = "lvDraftList";
            this.lvDraftList.Size = new System.Drawing.Size(863, 497);
            this.lvDraftList.TabIndex = 1;
            this.lvDraftList.UseCompatibleStateImageBehavior = false;
            this.lvDraftList.View = System.Windows.Forms.View.Details;
            this.lvDraftList.SelectedIndexChanged += new System.EventHandler(this.lvDraftList_SelectedIndexChanged);
            this.lvDraftList.DoubleClick += new System.EventHandler(this.lvDraftList_DoubleClick);
            // 
            // txtEntryBy
            // 
            this.txtEntryBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryBy.Location = new System.Drawing.Point(21, 580);
            this.txtEntryBy.Name = "txtEntryBy";
            this.txtEntryBy.Size = new System.Drawing.Size(29, 24);
            this.txtEntryBy.TabIndex = 111;
            this.txtEntryBy.Visible = false;
            // 
            // cboPatientSearch
            // 
            this.cboPatientSearch.BackColor = System.Drawing.Color.Black;
            this.cboPatientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPatientSearch.ForeColor = System.Drawing.Color.White;
            this.cboPatientSearch.Location = new System.Drawing.Point(65, 576);
            this.cboPatientSearch.Name = "cboPatientSearch";
            this.cboPatientSearch.Size = new System.Drawing.Size(53, 30);
            this.cboPatientSearch.TabIndex = 112;
            this.cboPatientSearch.Text = "Find";
            this.cboPatientSearch.UseVisualStyleBackColor = false;
            this.cboPatientSearch.Visible = false;
            this.cboPatientSearch.Click += new System.EventHandler(this.cboPatientSearch_Click);
            // 
            // frmShowTempBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 635);
            this.Controls.Add(this.cboPatientSearch);
            this.Controls.Add(this.txtEntryBy);
            this.Name = "frmShowTempBill";
            this.Load += new System.EventHandler(this.frmShowTempBill_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.txtEntryBy, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.cboPatientSearch, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvDraftList;
        private AtiqsControlLibrary.SmartTextBox txtEntryBy;
        private System.Windows.Forms.Button cboPatientSearch;
    }
}
