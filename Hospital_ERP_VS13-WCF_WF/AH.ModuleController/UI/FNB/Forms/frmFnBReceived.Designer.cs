namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmFnBReceived
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
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.dtevDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.DG = new System.Windows.Forms.DataGridView();
            this.cboAgainstRefNo = new System.Windows.Forms.ComboBox();
            this.txtMrrNo = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboGroupName = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.lvwfnbReceived = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(293, 8);
            this.frmLabel.Size = new System.Drawing.Size(356, 33);
            this.frmLabel.Text = "Food && Beverage Requisition";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwfnbReceived);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboGroupName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtMrrNo);
            this.pnlMain.Controls.Add(this.cboAgainstRefNo);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Controls.Add(this.dtevDate);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Size = new System.Drawing.Size(1114, 715);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1114, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(412, 635);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 635);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(525, 635);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(186, 635);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(747, 635);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(636, 635);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 678);
            this.groupBox1.Size = new System.Drawing.Size(1114, 25);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(15, 165);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(101, 14);
            this.smartLabel4.TabIndex = 11;
            this.smartLabel4.Text = "Reference No:";
            // 
            // dtevDate
            // 
            this.dtevDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtevDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtevDate.Location = new System.Drawing.Point(125, 205);
            this.dtevDate.Name = "dtevDate";
            this.dtevDate.Size = new System.Drawing.Size(254, 23);
            this.dtevDate.TabIndex = 25;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(73, 208);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(43, 14);
            this.smartLabel6.TabIndex = 24;
            this.smartLabel6.Text = "Date:";
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(9, 261);
            this.DG.Name = "DG";
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(847, 372);
            this.DG.TabIndex = 26;
            // 
            // cboAgainstRefNo
            // 
            this.cboAgainstRefNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAgainstRefNo.FormattingEnabled = true;
            this.cboAgainstRefNo.Location = new System.Drawing.Point(566, 202);
            this.cboAgainstRefNo.Name = "cboAgainstRefNo";
            this.cboAgainstRefNo.Size = new System.Drawing.Size(254, 24);
            this.cboAgainstRefNo.TabIndex = 29;
            this.cboAgainstRefNo.SelectedIndexChanged += new System.EventHandler(this.cboAgainstRefNo_SelectedIndexChanged);
            // 
            // txtMrrNo
            // 
            this.txtMrrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMrrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrrNo.Location = new System.Drawing.Point(125, 165);
            this.txtMrrNo.Name = "txtMrrNo";
            this.txtMrrNo.Size = new System.Drawing.Size(254, 24);
            this.txtMrrNo.TabIndex = 30;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(497, 206);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(61, 14);
            this.smartLabel1.TabIndex = 31;
            this.smartLabel1.Text = "Mrr. No:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(464, 170);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(94, 14);
            this.smartLabel2.TabIndex = 33;
            this.smartLabel2.Text = "Group Name:";
            // 
            // cboGroupName
            // 
            this.cboGroupName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupName.FormattingEnabled = true;
            this.cboGroupName.Location = new System.Drawing.Point(566, 166);
            this.cboGroupName.Name = "cboGroupName";
            this.cboGroupName.Size = new System.Drawing.Size(254, 24);
            this.cboGroupName.TabIndex = 32;
            this.cboGroupName.SelectedIndexChanged += new System.EventHandler(this.cboGroupName_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(271, 658);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(284, 24);
            this.txtRemarks.TabIndex = 34;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(193, 661);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(70, 14);
            this.smartLabel3.TabIndex = 35;
            this.smartLabel3.Text = "Remarks:";
            // 
            // lvwfnbReceived
            // 
            this.lvwfnbReceived.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwfnbReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwfnbReceived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwfnbReceived.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwfnbReceived.FullRowSelect = true;
            this.lvwfnbReceived.GridLines = true;
            this.lvwfnbReceived.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwfnbReceived.Location = new System.Drawing.Point(865, 147);
            this.lvwfnbReceived.Name = "lvwfnbReceived";
            this.lvwfnbReceived.Size = new System.Drawing.Size(243, 561);
            this.lvwfnbReceived.TabIndex = 36;
            this.lvwfnbReceived.UseCompatibleStateImageBehavior = false;
            this.lvwfnbReceived.View = System.Windows.Forms.View.Details;
            this.lvwfnbReceived.SelectedIndexChanged += new System.EventHandler(this.lvwfnbReceived_SelectedIndexChanged);
            // 
            // frmFnBReceived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "frmFnBReceived";
            this.Load += new System.EventHandler(this.frmFnBReceived_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.DateTimePicker dtevDate;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.ComboBox cboAgainstRefNo;
        private AtiqsControlLibrary.SmartTextBox txtMrrNo;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.ComboBox cboGroupName;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartListViewDetails lvwfnbReceived;
    }
}
