namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmDrugPacketType
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
            this.lvDrugPacketType = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDrugPacketNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDrugPacketName = new AtiqsControlLibrary.SmartTextBox();
            this.txtPacketID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(677, 3);
            this.btnTopClose.TabStop = false;
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(270, 7);
            this.frmLabel.Size = new System.Drawing.Size(239, 33);
            this.frmLabel.Text = "Drug Dosage Form";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtPacketID);
            this.pnlMain.Controls.Add(this.lvDrugPacketType);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDrugPacketNameBang);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtDrugPacketName);
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Size = new System.Drawing.Size(754, 489);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(754, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(533, 544);
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(424, 544);
            this.btnSave.TabIndex = 3;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(71, 544);
            this.btnDelete.Size = new System.Drawing.Size(37, 39);
            this.btnDelete.TabStop = false;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(314, 544);
            this.btnNew.TabStop = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(642, 544);
            this.btnClose.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(124, 544);
            this.btnPrint.Size = new System.Drawing.Size(35, 39);
            this.btnPrint.TabStop = false;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 584);
            this.groupBox1.Size = new System.Drawing.Size(754, 23);
            // 
            // lvDrugPacketType
            // 
            this.lvDrugPacketType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDrugPacketType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDrugPacketType.CheckBoxes = true;
            this.lvDrugPacketType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDrugPacketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrugPacketType.FullRowSelect = true;
            this.lvDrugPacketType.GridLines = true;
            this.lvDrugPacketType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDrugPacketType.Location = new System.Drawing.Point(-1, 154);
            this.lvDrugPacketType.Name = "lvDrugPacketType";
            this.lvDrugPacketType.Size = new System.Drawing.Size(754, 335);
            this.lvDrugPacketType.TabIndex = 50;
            this.lvDrugPacketType.TabStop = false;
            this.lvDrugPacketType.UseCompatibleStateImageBehavior = false;
            this.lvDrugPacketType.View = System.Windows.Forms.View.Details;
            this.lvDrugPacketType.SelectedIndexChanged += new System.EventHandler(this.lvDrugPacketType_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(58, 95);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(65, 15);
            this.smartLabel7.TabIndex = 49;
            this.smartLabel7.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(138, 92);
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
            this.smartLabel3.Location = new System.Drawing.Point(22, 67);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(95, 15);
            this.smartLabel3.TabIndex = 47;
            this.smartLabel3.Text = "Name( Bangla) :";
            // 
            // txtDrugPacketNameBang
            // 
            this.txtDrugPacketNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugPacketNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugPacketNameBang.Location = new System.Drawing.Point(138, 64);
            this.txtDrugPacketNameBang.Name = "txtDrugPacketNameBang";
            this.txtDrugPacketNameBang.Size = new System.Drawing.Size(357, 24);
            this.txtDrugPacketNameBang.TabIndex = 1;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(75, 39);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(45, 15);
            this.smartLabel2.TabIndex = 45;
            this.smartLabel2.Text = "Name :";
            // 
            // txtDrugPacketName
            // 
            this.txtDrugPacketName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugPacketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugPacketName.Location = new System.Drawing.Point(138, 36);
            this.txtDrugPacketName.Name = "txtDrugPacketName";
            this.txtDrugPacketName.Size = new System.Drawing.Size(357, 24);
            this.txtDrugPacketName.TabIndex = 0;
            this.txtDrugPacketName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDrugPacketName_KeyUp);
            // 
            // txtPacketID
            // 
            this.txtPacketID.BackColor = System.Drawing.Color.Linen;
            this.txtPacketID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPacketID.Location = new System.Drawing.Point(138, 6);
            this.txtPacketID.Name = "txtPacketID";
            this.txtPacketID.ReadOnly = true;
            this.txtPacketID.Size = new System.Drawing.Size(172, 24);
            this.txtPacketID.TabIndex = 51;
            this.txtPacketID.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(96, 9);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(27, 15);
            this.smartLabel1.TabIndex = 72;
            this.smartLabel1.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(498, 38);
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
            this.label3.Location = new System.Drawing.Point(499, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 108;
            this.label3.Text = "*";
            // 
            // frmDrugPacketType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(754, 607);
            this.isEnterTabAllow = true;
            this.Name = "frmDrugPacketType";
            this.Load += new System.EventHandler(this.frmDrugPacketType_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvDrugPacketType;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDrugPacketNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDrugPacketName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPacketID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
