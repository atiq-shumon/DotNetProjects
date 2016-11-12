namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmWeeklyChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeeklyChart));
            this.DG = new System.Windows.Forms.DataGridView();
            this.cbomealId = new System.Windows.Forms.ComboBox();
            this.cboSetmenuTypeID = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printCal = new System.Drawing.Printing.PrintDocument();
            this.Printpreview = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(360, 9);
            this.frmLabel.Size = new System.Drawing.Size(206, 33);
            this.frmLabel.Text = "Set Menu  Chart";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.cboSetmenuTypeID);
            this.pnlMain.Controls.Add(this.cbomealId);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Size = new System.Drawing.Size(1214, 801);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1217, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(412, 719);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 719);
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(525, 719);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(186, 719);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1097, 719);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(986, 719);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 758);
            this.groupBox1.Size = new System.Drawing.Size(1217, 25);
            // 
            // DG
            // 
            this.DG.BackgroundColor = System.Drawing.Color.Linen;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(7, 194);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(1197, 597);
            this.DG.TabIndex = 0;
            // 
            // cbomealId
            // 
            this.cbomealId.FormattingEnabled = true;
            this.cbomealId.Location = new System.Drawing.Point(45, 162);
            this.cbomealId.Name = "cbomealId";
            this.cbomealId.Size = new System.Drawing.Size(121, 21);
            this.cbomealId.TabIndex = 1;
            this.cbomealId.Visible = false;
            // 
            // cboSetmenuTypeID
            // 
            this.cboSetmenuTypeID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSetmenuTypeID.FormattingEnabled = true;
            this.cboSetmenuTypeID.Location = new System.Drawing.Point(335, 158);
            this.cboSetmenuTypeID.Name = "cboSetmenuTypeID";
            this.cboSetmenuTypeID.Size = new System.Drawing.Size(287, 22);
            this.cboSetmenuTypeID.TabIndex = 2;
            this.cboSetmenuTypeID.SelectedIndexChanged += new System.EventHandler(this.cboSetmenuTypeID_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShow.Location = new System.Drawing.Point(628, 157);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(38, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "..";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set Menu Type:";
            // 
            // printCal
            // 
            this.printCal.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printCal_BeginPrint);
            this.printCal.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCal_PrintPage);
            // 
            // Printpreview
            // 
            this.Printpreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Printpreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Printpreview.ClientSize = new System.Drawing.Size(400, 300);
            this.Printpreview.Enabled = true;
            this.Printpreview.Icon = ((System.Drawing.Icon)(resources.GetObject("Printpreview.Icon")));
            this.Printpreview.Name = "Printpreview";
            this.Printpreview.Visible = false;
            // 
            // frmWeeklyChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1217, 783);
            this.isEnterTabAllow = true;
            this.Name = "frmWeeklyChart";
            this.Load += new System.EventHandler(this.frmWeeklyChart_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.ComboBox cbomealId;
        private System.Windows.Forms.ComboBox cboSetmenuTypeID;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printCal;
        private System.Windows.Forms.PrintPreviewDialog Printpreview;
    }
}
