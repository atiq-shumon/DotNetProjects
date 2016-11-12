namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmProductServiceInformation
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
            this.btnapply = new System.Windows.Forms.Button();
            this.txtSLNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.DGS = new System.Windows.Forms.DataGridView();
            this.cboGroupName = new System.Windows.Forms.ComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.DGI = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGI)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(348, 9);
            this.frmLabel.Size = new System.Drawing.Size(369, 33);
            this.frmLabel.Text = "Product Servicing Information";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.DGI);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboGroupName);
            this.pnlMain.Controls.Add(this.DGS);
            this.pnlMain.Controls.Add(this.btnapply);
            this.pnlMain.Controls.Add(this.txtSLNo);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(1201, 794);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1202, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(740, 711);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(627, 711);
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(853, 711);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(514, 711);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1075, 711);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(964, 711);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 751);
            this.groupBox1.Size = new System.Drawing.Size(1202, 25);
            // 
            // btnapply
            // 
            this.btnapply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnapply.Location = new System.Drawing.Point(288, 164);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(32, 23);
            this.btnapply.TabIndex = 10;
            this.btnapply.Text = "..";
            this.btnapply.UseVisualStyleBackColor = false;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // txtSLNo
            // 
            this.txtSLNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSLNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNo.Location = new System.Drawing.Point(78, 164);
            this.txtSLNo.Name = "txtSLNo";
            this.txtSLNo.Size = new System.Drawing.Size(205, 24);
            this.txtSLNo.TabIndex = 9;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(24, 167);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(48, 13);
            this.smartLabel1.TabIndex = 8;
            this.smartLabel1.Text = "SL NO:";
            // 
            // DGS
            // 
            this.DGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DGS.Location = new System.Drawing.Point(11, 210);
            this.DGS.Name = "DGS";
            this.DGS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGS.Size = new System.Drawing.Size(1184, 485);
            this.DGS.TabIndex = 11;
            this.DGS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGS_CellClick);
            this.DGS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGS_CellContentClick);
            this.DGS.DoubleClick += new System.EventHandler(this.DGS_DoubleClick);
            // 
            // cboGroupName
            // 
            this.cboGroupName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupName.FormattingEnabled = true;
            this.cboGroupName.Location = new System.Drawing.Point(802, 166);
            this.cboGroupName.Name = "cboGroupName";
            this.cboGroupName.Size = new System.Drawing.Size(323, 24);
            this.cboGroupName.TabIndex = 15;
            this.cboGroupName.SelectedIndexChanged += new System.EventHandler(this.cboGroupName_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(702, 169);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(91, 13);
            this.smartLabel2.TabIndex = 16;
            this.smartLabel2.Text = "Group Name:";
            // 
            // DGI
            // 
            this.DGI.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DGI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DGI.Location = new System.Drawing.Point(12, 723);
            this.DGI.Name = "DGI";
            this.DGI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGI.Size = new System.Drawing.Size(1184, 65);
            this.DGI.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 700);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product Issue Information";
            // 
            // frmProductServiceInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1202, 776);
            this.isEnterTabAllow = true;
            this.Name = "frmProductServiceInformation";
            this.Load += new System.EventHandler(this.frmProductServiceInformation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnapply;
        private AtiqsControlLibrary.SmartTextBox txtSLNo;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.DataGridView DGS;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.ComboBox cboGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGI;
    }
}
