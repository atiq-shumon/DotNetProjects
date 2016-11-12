namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmDrugUnit
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
            this.lvDrugUnit = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDrugUnitNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDrugUnitName = new AtiqsControlLibrary.SmartTextBox();
            this.txtDrugUnitID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(676, 3);
            this.btnTopClose.TabStop = false;
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(285, 8);
            this.frmLabel.Text = "Drug Unit Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtDrugUnitID);
            this.pnlMain.Controls.Add(this.lvDrugUnit);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDrugUnitNameBang);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtDrugUnitName);
            this.pnlMain.Location = new System.Drawing.Point(0, 52);
            this.pnlMain.Size = new System.Drawing.Size(754, 512);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(754, 51);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(529, 570);
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 570);
            this.btnSave.TabIndex = 3;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(78, 570);
            this.btnDelete.Size = new System.Drawing.Size(25, 39);
            this.btnDelete.TabStop = false;
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(309, 570);
            this.btnNew.TabStop = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(639, 570);
            this.btnClose.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(126, 570);
            this.btnPrint.Size = new System.Drawing.Size(27, 39);
            this.btnPrint.TabStop = false;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Size = new System.Drawing.Size(754, 23);
            // 
            // lvDrugUnit
            // 
            this.lvDrugUnit.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDrugUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDrugUnit.CheckBoxes = true;
            this.lvDrugUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDrugUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrugUnit.FullRowSelect = true;
            this.lvDrugUnit.GridLines = true;
            this.lvDrugUnit.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDrugUnit.Location = new System.Drawing.Point(-1, 154);
            this.lvDrugUnit.Name = "lvDrugUnit";
            this.lvDrugUnit.Size = new System.Drawing.Size(754, 357);
            this.lvDrugUnit.TabIndex = 50;
            this.lvDrugUnit.TabStop = false;
            this.lvDrugUnit.UseCompatibleStateImageBehavior = false;
            this.lvDrugUnit.View = System.Windows.Forms.View.Details;
            this.lvDrugUnit.SelectedIndexChanged += new System.EventHandler(this.lvDrugUnit_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(57, 95);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(65, 15);
            this.smartLabel7.TabIndex = 49;
            this.smartLabel7.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(137, 92);
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
            this.smartLabel3.Location = new System.Drawing.Point(21, 67);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(95, 15);
            this.smartLabel3.TabIndex = 47;
            this.smartLabel3.Text = "Name( Bangla) :";
            // 
            // txtDrugUnitNameBang
            // 
            this.txtDrugUnitNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugUnitNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugUnitNameBang.Location = new System.Drawing.Point(137, 64);
            this.txtDrugUnitNameBang.Name = "txtDrugUnitNameBang";
            this.txtDrugUnitNameBang.Size = new System.Drawing.Size(357, 24);
            this.txtDrugUnitNameBang.TabIndex = 1;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(74, 38);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(45, 15);
            this.smartLabel2.TabIndex = 45;
            this.smartLabel2.Text = "Name :";
            // 
            // txtDrugUnitName
            // 
            this.txtDrugUnitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugUnitName.Location = new System.Drawing.Point(137, 35);
            this.txtDrugUnitName.Name = "txtDrugUnitName";
            this.txtDrugUnitName.Size = new System.Drawing.Size(357, 24);
            this.txtDrugUnitName.TabIndex = 0;
            this.txtDrugUnitName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDrugUnitName_KeyUp);
            // 
            // txtDrugUnitID
            // 
            this.txtDrugUnitID.BackColor = System.Drawing.Color.Linen;
            this.txtDrugUnitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrugUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugUnitID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDrugUnitID.Location = new System.Drawing.Point(137, 6);
            this.txtDrugUnitID.Name = "txtDrugUnitID";
            this.txtDrugUnitID.ReadOnly = true;
            this.txtDrugUnitID.Size = new System.Drawing.Size(173, 24);
            this.txtDrugUnitID.TabIndex = 51;
            this.txtDrugUnitID.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(95, 9);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(27, 15);
            this.smartLabel1.TabIndex = 52;
            this.smartLabel1.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(497, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 108;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(496, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "*";
            // 
            // frmDrugUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(754, 634);
            this.isEnterTabAllow = true;
            this.Name = "frmDrugUnit";
            this.Load += new System.EventHandler(this.frmDrugUnit_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvDrugUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDrugUnitNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDrugUnitName;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtDrugUnitID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
