namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOPRInformation
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
            this.cboOperationType = new AtiqsControlLibrary.SmartComboBox();
            this.smartTextBox1 = new AtiqsControlLibrary.SmartTextBox();
            this.txtOperationName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lvwOperationName = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtOtId = new AtiqsControlLibrary.SmartTextBox();
            this.OperatioinID = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(281, 33);
            this.frmLabel.TabIndex = 5;
            this.frmLabel.Text = "Operation Information";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.OperatioinID);
            this.pnlMain.Controls.Add(this.txtOtId);
            this.pnlMain.Controls.Add(this.lvwOperationName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtOperationName);
            this.pnlMain.Controls.Add(this.smartTextBox1);
            this.pnlMain.Controls.Add(this.cboOperationType);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.TabIndex = 2;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.TabIndex = 7;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 595);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(177, 238);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(114, 14);
            this.smartLabel1.TabIndex = 0;
            this.smartLabel1.Text = "Operation Type:";
            // 
            // cboOperationType
            // 
            this.cboOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperationType.ForeColor = System.Drawing.Color.Blue;
            this.cboOperationType.FormattingEnabled = true;
            this.cboOperationType.Location = new System.Drawing.Point(298, 235);
            this.cboOperationType.Name = "cboOperationType";
            this.cboOperationType.Size = new System.Drawing.Size(353, 26);
            this.cboOperationType.TabIndex = 1;
            this.cboOperationType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboOperationType_KeyPress);
            // 
            // smartTextBox1
            // 
            this.smartTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox1.Location = new System.Drawing.Point(0, 0);
            this.smartTextBox1.Name = "smartTextBox1";
            this.smartTextBox1.Size = new System.Drawing.Size(100, 24);
            this.smartTextBox1.TabIndex = 2;
            // 
            // txtOperationName
            // 
            this.txtOperationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOperationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperationName.Location = new System.Drawing.Point(298, 203);
            this.txtOperationName.Name = "txtOperationName";
            this.txtOperationName.Size = new System.Drawing.Size(353, 24);
            this.txtOperationName.TabIndex = 0;
            this.txtOperationName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOperationName_KeyPress);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(171, 205);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(120, 14);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "Operation Name:";
            // 
            // lvwOperationName
            // 
            this.lvwOperationName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwOperationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwOperationName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwOperationName.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwOperationName.FullRowSelect = true;
            this.lvwOperationName.GridLines = true;
            this.lvwOperationName.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwOperationName.Location = new System.Drawing.Point(6, 283);
            this.lvwOperationName.Name = "lvwOperationName";
            this.lvwOperationName.Size = new System.Drawing.Size(849, 345);
            this.lvwOperationName.TabIndex = 5;
            this.lvwOperationName.UseCompatibleStateImageBehavior = false;
            this.lvwOperationName.View = System.Windows.Forms.View.Details;
            this.lvwOperationName.SelectedIndexChanged += new System.EventHandler(this.lvwOperationName_SelectedIndexChanged);
            // 
            // txtOtId
            // 
            this.txtOtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtId.Location = new System.Drawing.Point(298, 170);
            this.txtOtId.Name = "txtOtId";
            this.txtOtId.ReadOnly = true;
            this.txtOtId.Size = new System.Drawing.Size(353, 24);
            this.txtOtId.TabIndex = 6;
            // 
            // OperatioinID
            // 
            this.OperatioinID.AutoSize = true;
            this.OperatioinID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.OperatioinID.Location = new System.Drawing.Point(188, 174);
            this.OperatioinID.Name = "OperatioinID";
            this.OperatioinID.Size = new System.Drawing.Size(98, 14);
            this.OperatioinID.TabIndex = 7;
            this.OperatioinID.Text = "Operation ID:";
            // 
            // frmOPRInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 620);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmOPRInformation";
            this.Load += new System.EventHandler(this.frmOPRInformation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwOperationName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtOperationName;
        private AtiqsControlLibrary.SmartTextBox smartTextBox1;
        private AtiqsControlLibrary.SmartComboBox cboOperationType;
        private AtiqsControlLibrary.SmartLabel OperatioinID;
        private AtiqsControlLibrary.SmartTextBox txtOtId;
    }
}
