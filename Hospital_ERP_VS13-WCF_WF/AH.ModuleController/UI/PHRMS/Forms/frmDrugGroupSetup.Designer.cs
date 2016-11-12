namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmDrugGroupSetup
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
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDrugGroupNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDrugGroupName = new AtiqsControlLibrary.SmartTextBox();
            this.lvDrugGroup = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtDrugGroupID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(681, 3);
            this.btnTopClose.TabIndex = 180;
            this.btnTopClose.TabStop = false;
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(267, 6);
            this.frmLabel.Size = new System.Drawing.Size(180, 33);
            this.frmLabel.TabIndex = 40;
            this.frmLabel.Text = "Generic Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtDrugGroupID);
            this.pnlMain.Controls.Add(this.lvDrugGroup);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDrugGroupNameBang);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtDrugGroupName);
            this.pnlMain.Location = new System.Drawing.Point(0, 52);
            this.pnlMain.Size = new System.Drawing.Size(758, 504);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(761, 51);
            this.pnlTop.TabIndex = 25;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(537, 559);
            this.btnEdit.TabIndex = 110;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(427, 559);
            this.btnSave.TabIndex = 3;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(64, 559);
            this.btnDelete.Size = new System.Drawing.Size(43, 39);
            this.btnDelete.TabIndex = 105;
            this.btnDelete.TabStop = false;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(318, 559);
            this.btnNew.TabIndex = 108;
            this.btnNew.TabStop = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(646, 559);
            this.btnClose.TabIndex = 143;
            this.btnClose.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(139, 559);
            this.btnPrint.Size = new System.Drawing.Size(31, 39);
            this.btnPrint.TabIndex = 205;
            this.btnPrint.TabStop = false;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 600);
            this.groupBox1.Size = new System.Drawing.Size(761, 23);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(60, 107);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(65, 15);
            this.smartLabel7.TabIndex = 25;
            this.smartLabel7.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(138, 104);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(424, 56);
            this.txtRemarks.TabIndex = 2;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(24, 78);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(95, 15);
            this.smartLabel3.TabIndex = 23;
            this.smartLabel3.Text = "Name( Bangla) :";
            // 
            // txtDrugGroupNameBang
            // 
            this.txtDrugGroupNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugGroupNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugGroupNameBang.Location = new System.Drawing.Point(138, 75);
            this.txtDrugGroupNameBang.Name = "txtDrugGroupNameBang";
            this.txtDrugGroupNameBang.Size = new System.Drawing.Size(357, 24);
            this.txtDrugGroupNameBang.TabIndex = 1;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(77, 49);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(45, 15);
            this.smartLabel2.TabIndex = 21;
            this.smartLabel2.Text = "Name :";
            // 
            // txtDrugGroupName
            // 
            this.txtDrugGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugGroupName.Location = new System.Drawing.Point(138, 46);
            this.txtDrugGroupName.Name = "txtDrugGroupName";
            this.txtDrugGroupName.Size = new System.Drawing.Size(357, 24);
            this.txtDrugGroupName.TabIndex = 0;
            this.txtDrugGroupName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDrugGroupName_KeyUp);
            // 
            // lvDrugGroup
            // 
            this.lvDrugGroup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDrugGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDrugGroup.CheckBoxes = true;
            this.lvDrugGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDrugGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrugGroup.FullRowSelect = true;
            this.lvDrugGroup.GridLines = true;
            this.lvDrugGroup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDrugGroup.Location = new System.Drawing.Point(0, 166);
            this.lvDrugGroup.Name = "lvDrugGroup";
            this.lvDrugGroup.Size = new System.Drawing.Size(757, 337);
            this.lvDrugGroup.TabIndex = 43;
            this.lvDrugGroup.TabStop = false;
            this.lvDrugGroup.UseCompatibleStateImageBehavior = false;
            this.lvDrugGroup.View = System.Windows.Forms.View.Details;
            this.lvDrugGroup.SelectedIndexChanged += new System.EventHandler(this.lvDrug_SelectedIndexChanged);
            // 
            // txtDrugGroupID
            // 
            this.txtDrugGroupID.BackColor = System.Drawing.Color.Linen;
            this.txtDrugGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugGroupID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDrugGroupID.Location = new System.Drawing.Point(138, 17);
            this.txtDrugGroupID.Name = "txtDrugGroupID";
            this.txtDrugGroupID.ReadOnly = true;
            this.txtDrugGroupID.Size = new System.Drawing.Size(172, 24);
            this.txtDrugGroupID.TabIndex = 44;
            this.txtDrugGroupID.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(98, 20);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(27, 15);
            this.smartLabel1.TabIndex = 45;
            this.smartLabel1.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(498, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(498, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 108;
            this.label3.Text = "*";
            // 
            // frmDrugGroupSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(761, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmDrugGroupSetup";
            this.Load += new System.EventHandler(this.frmDrugGroupSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDrugGroupNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDrugGroupName;
        private AtiqsControlLibrary.SmartListViewDetails lvDrugGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDrugGroupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
