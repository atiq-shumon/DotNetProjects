namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmVisitorsDetails
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
            this.lvwVisitorsDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtSearch = new AtiqsControlLibrary.SmartTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dteFDate = new System.Windows.Forms.DateTimePicker();
            this.dteTDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(188, 33);
            this.frmLabel.Text = "Visitors Details";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.dteTDate);
            this.pnlMain.Controls.Add(this.dteFDate);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.lvwVisitorsDetails);
            // 
            // btnEdit
            // 
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lvwVisitorsDetails
            // 
            this.lvwVisitorsDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwVisitorsDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwVisitorsDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwVisitorsDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwVisitorsDetails.FullRowSelect = true;
            this.lvwVisitorsDetails.GridLines = true;
            this.lvwVisitorsDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwVisitorsDetails.Location = new System.Drawing.Point(11, 194);
            this.lvwVisitorsDetails.Name = "lvwVisitorsDetails";
            this.lvwVisitorsDetails.Size = new System.Drawing.Size(846, 424);
            this.lvwVisitorsDetails.TabIndex = 0;
            this.lvwVisitorsDetails.UseCompatibleStateImageBehavior = false;
            this.lvwVisitorsDetails.View = System.Windows.Forms.View.Details;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.ForeColor = System.Drawing.Color.Blue;
            this.smartLabel3.Location = new System.Drawing.Point(22, 162);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(161, 13);
            this.smartLabel3.TabIndex = 56;
            this.smartLabel3.Text = "Transaction No for Search:";
            this.smartLabel3.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(100, 158);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(114, 24);
            this.txtSearch.TabIndex = 55;
            this.txtSearch.Visible = false;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dteFDate
            // 
            this.dteFDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFDate.Location = new System.Drawing.Point(318, 161);
            this.dteFDate.Name = "dteFDate";
            this.dteFDate.Size = new System.Drawing.Size(110, 21);
            this.dteFDate.TabIndex = 57;
            // 
            // dteTDate
            // 
            this.dteTDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTDate.Location = new System.Drawing.Point(494, 161);
            this.dteTDate.Name = "dteTDate";
            this.dteTDate.Size = new System.Drawing.Size(109, 21);
            this.dteTDate.TabIndex = 58;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShow.Location = new System.Drawing.Point(606, 159);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(36, 23);
            this.btnShow.TabIndex = 59;
            this.btnShow.Text = "..";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "From Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "To Date:";
            // 
            // frmVisitorsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.Controls.Add(this.button1);
            this.isEnterTabAllow = true;
            this.Name = "frmVisitorsDetails";
            this.Load += new System.EventHandler(this.frmVisitorsDetails_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwVisitorsDetails;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dteTDate;
        private System.Windows.Forms.DateTimePicker dteFDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
