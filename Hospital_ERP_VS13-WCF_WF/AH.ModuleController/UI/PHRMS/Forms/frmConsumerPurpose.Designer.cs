namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmConsumerPurpose
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
            this.components = new System.ComponentModel.Container();
            this.smartLabel10 = new AtiqsControlLibrary.SmartLabel();
            this.cboAccCode = new AtiqsControlLibrary.SmartComboBox();
            this.txtPriority = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel9 = new AtiqsControlLibrary.SmartLabel();
            this.txtConsumptionName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel11 = new AtiqsControlLibrary.SmartLabel();
            this.lvConsumer = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtConsumptionID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.TabIndex = 30;
            this.btnClose.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.TabIndex = 20;
            this.btnDelete.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.TabStop = false;
            // 
            // btnTopClose
            // 
            this.btnTopClose.TabIndex = 40;
            this.btnTopClose.TabStop = false;
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(257, 10);
            this.frmLabel.Size = new System.Drawing.Size(271, 29);
            this.frmLabel.Text = "Consumption Purpose";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtConsumptionID);
            this.pnlMain.Controls.Add(this.lvConsumer);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel11);
            this.pnlMain.Controls.Add(this.smartLabel10);
            this.pnlMain.Controls.Add(this.cboAccCode);
            this.pnlMain.Controls.Add(this.txtPriority);
            this.pnlMain.Controls.Add(this.smartLabel9);
            this.pnlMain.Controls.Add(this.txtConsumptionName);
            this.pnlMain.Controls.Add(this.smartLabel4);
            // 
            // smartLabel10
            // 
            this.smartLabel10.AutoSize = true;
            this.smartLabel10.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel10.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel10.Location = new System.Drawing.Point(95, 78);
            this.smartLabel10.Name = "smartLabel10";
            this.smartLabel10.Size = new System.Drawing.Size(74, 18);
            this.smartLabel10.TabIndex = 66;
            this.smartLabel10.Text = "Acc_Code :";
            // 
            // cboAccCode
            // 
            this.cboAccCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAccCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAccCode.ForeColor = System.Drawing.Color.Blue;
            this.cboAccCode.FormattingEnabled = true;
            this.cboAccCode.Location = new System.Drawing.Point(188, 74);
            this.cboAccCode.Name = "cboAccCode";
            this.cboAccCode.Size = new System.Drawing.Size(221, 26);
            this.cboAccCode.TabIndex = 1;
            // 
            // txtPriority
            // 
            this.txtPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriority.Location = new System.Drawing.Point(479, 75);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(56, 24);
            this.txtPriority.TabIndex = 2;
            // 
            // smartLabel9
            // 
            this.smartLabel9.AutoSize = true;
            this.smartLabel9.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel9.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel9.Location = new System.Drawing.Point(415, 78);
            this.smartLabel9.Name = "smartLabel9";
            this.smartLabel9.Size = new System.Drawing.Size(58, 18);
            this.smartLabel9.TabIndex = 63;
            this.smartLabel9.Text = "Priority :";
            // 
            // txtConsumptionName
            // 
            this.txtConsumptionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsumptionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumptionName.Location = new System.Drawing.Point(188, 42);
            this.txtConsumptionName.Name = "txtConsumptionName";
            this.txtConsumptionName.Size = new System.Drawing.Size(347, 24);
            this.txtConsumptionName.TabIndex = 0;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(34, 45);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(135, 18);
            this.smartLabel4.TabIndex = 59;
            this.smartLabel4.Text = "Consumption Name :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(188, 107);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(347, 40);
            this.txtRemarks.TabIndex = 3;
            // 
            // smartLabel11
            // 
            this.smartLabel11.AutoSize = true;
            this.smartLabel11.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel11.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel11.Location = new System.Drawing.Point(101, 110);
            this.smartLabel11.Name = "smartLabel11";
            this.smartLabel11.Size = new System.Drawing.Size(68, 18);
            this.smartLabel11.TabIndex = 67;
            this.smartLabel11.Text = "Remarks :";
            // 
            // lvConsumer
            // 
            this.lvConsumer.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvConsumer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvConsumer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvConsumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConsumer.FullRowSelect = true;
            this.lvConsumer.GridLines = true;
            this.lvConsumer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvConsumer.Location = new System.Drawing.Point(-1, 153);
            this.lvConsumer.Name = "lvConsumer";
            this.lvConsumer.Size = new System.Drawing.Size(839, 350);
            this.lvConsumer.TabIndex = 69;
            this.lvConsumer.UseCompatibleStateImageBehavior = false;
            this.lvConsumer.View = System.Windows.Forms.View.Details;
            this.lvConsumer.SelectedIndexChanged += new System.EventHandler(this.lvConsumer_SelectedIndexChanged);
            // 
            // txtConsumptionID
            // 
            this.txtConsumptionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtConsumptionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsumptionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumptionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(195)))));
            this.txtConsumptionID.Location = new System.Drawing.Point(188, 11);
            this.txtConsumptionID.Name = "txtConsumptionID";
            this.txtConsumptionID.ReadOnly = true;
            this.txtConsumptionID.Size = new System.Drawing.Size(194, 24);
            this.txtConsumptionID.TabIndex = 70;
            this.txtConsumptionID.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(55, 14);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(114, 18);
            this.smartLabel1.TabIndex = 71;
            this.smartLabel1.Text = "Consumption ID :";
            // 
            // frmConsumerPurpose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 634);
            this.Name = "frmConsumerPurpose";
            this.Load += new System.EventHandler(this.frmConsumerPurpose_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel10;
        private AtiqsControlLibrary.SmartComboBox cboAccCode;
        private AtiqsControlLibrary.SmartNumericTextBox txtPriority;
        private AtiqsControlLibrary.SmartLabel smartLabel9;
        private AtiqsControlLibrary.SmartTextBox txtConsumptionName;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartListViewDetails lvConsumer;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel11;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtConsumptionID;
    }
}
