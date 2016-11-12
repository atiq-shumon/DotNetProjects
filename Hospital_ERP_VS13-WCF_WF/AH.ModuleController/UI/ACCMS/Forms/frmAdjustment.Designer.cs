namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmAdjustment
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtLedgerName = new AtiqsControlLibrary.SmartTextBox();
            this.txtAdjustmentAmount = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.dteAdjustmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtLedgercode = new AtiqsControlLibrary.SmartTextBox();
            this.lvwFixedAssets = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRefNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtSerach = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(317, 9);
            this.frmLabel.Size = new System.Drawing.Size(304, 33);
            this.frmLabel.Text = "Fixed Assets Adjustment";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtSerach);
            this.pnlMain.Controls.Add(this.txtRefNo);
            this.pnlMain.Controls.Add(this.lvwFixedAssets);
            this.pnlMain.Controls.Add(this.txtLedgercode);
            this.pnlMain.Controls.Add(this.dteAdjustmentDate);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtAdjustmentAmount);
            this.pnlMain.Controls.Add(this.txtLedgerName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(863, 605);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(638, 522);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(529, 522);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(74, 522);
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(420, 522);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(747, 522);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(185, 522);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 567);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(224, 198);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(100, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Ledger Name:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(202, 237);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(122, 14);
            this.smartLabel2.TabIndex = 1;
            this.smartLabel2.Text = "Adjustment Date:";
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLedgerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLedgerName.Location = new System.Drawing.Point(334, 195);
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(374, 24);
            this.txtLedgerName.TabIndex = 2;
            this.txtLedgerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLedgerName_KeyPress);
            // 
            // txtAdjustmentAmount
            // 
            this.txtAdjustmentAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdjustmentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustmentAmount.Location = new System.Drawing.Point(334, 272);
            this.txtAdjustmentAmount.Name = "txtAdjustmentAmount";
            this.txtAdjustmentAmount.Size = new System.Drawing.Size(196, 24);
            this.txtAdjustmentAmount.TabIndex = 3;
            this.txtAdjustmentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdjustmentAmount_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(184, 275);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(141, 14);
            this.smartLabel3.TabIndex = 4;
            this.smartLabel3.Text = "Adjustment Amount:";
            // 
            // dteAdjustmentDate
            // 
            this.dteAdjustmentDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteAdjustmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteAdjustmentDate.Location = new System.Drawing.Point(334, 235);
            this.dteAdjustmentDate.Name = "dteAdjustmentDate";
            this.dteAdjustmentDate.Size = new System.Drawing.Size(200, 26);
            this.dteAdjustmentDate.TabIndex = 5;
            this.dteAdjustmentDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteAdjustmentDate_KeyPress);
            // 
            // txtLedgercode
            // 
            this.txtLedgercode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLedgercode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLedgercode.Location = new System.Drawing.Point(333, 165);
            this.txtLedgercode.Name = "txtLedgercode";
            this.txtLedgercode.Size = new System.Drawing.Size(374, 24);
            this.txtLedgercode.TabIndex = 6;
            this.txtLedgercode.Visible = false;
            // 
            // lvwFixedAssets
            // 
            this.lvwFixedAssets.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwFixedAssets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwFixedAssets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwFixedAssets.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFixedAssets.FullRowSelect = true;
            this.lvwFixedAssets.GridLines = true;
            this.lvwFixedAssets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFixedAssets.Location = new System.Drawing.Point(14, 360);
            this.lvwFixedAssets.Name = "lvwFixedAssets";
            this.lvwFixedAssets.Size = new System.Drawing.Size(838, 233);
            this.lvwFixedAssets.TabIndex = 7;
            this.lvwFixedAssets.UseCompatibleStateImageBehavior = false;
            this.lvwFixedAssets.View = System.Windows.Forms.View.Details;
            this.lvwFixedAssets.SelectedIndexChanged += new System.EventHandler(this.lvwFixedAssets_SelectedIndexChanged);
            // 
            // txtRefNo
            // 
            this.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.Location = new System.Drawing.Point(33, 150);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(122, 24);
            this.txtRefNo.TabIndex = 8;
            this.txtRefNo.Visible = false;
            // 
            // txtSerach
            // 
            this.txtSerach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerach.Location = new System.Drawing.Point(118, 330);
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.Size = new System.Drawing.Size(285, 24);
            this.txtSerach.TabIndex = 9;
            this.txtSerach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerach_KeyUp);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.smartLabel4.Location = new System.Drawing.Point(15, 333);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(100, 14);
            this.smartLabel4.TabIndex = 10;
            this.smartLabel4.Text = "Ledger Name:";
            // 
            // frmAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 592);
            this.KeyPreview = false;
            this.Name = "frmAdjustment";
            this.Load += new System.EventHandler(this.frmAdjustment_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.DateTimePicker dteAdjustmentDate;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtAdjustmentAmount;
        private AtiqsControlLibrary.SmartTextBox txtLedgerName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtLedgercode;
        private AtiqsControlLibrary.SmartListViewDetails lvwFixedAssets;
        private AtiqsControlLibrary.SmartTextBox txtRefNo;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtSerach;
    }
}
