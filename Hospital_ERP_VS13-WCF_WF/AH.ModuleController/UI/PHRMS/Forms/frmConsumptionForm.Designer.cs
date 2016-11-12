namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmConsumptionForm
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtConsumptionID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lvDrugConsumption = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtConsumptionNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtConsumptionName = new AtiqsControlLibrary.SmartTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(241, 33);
            this.frmLabel.Text = "Consumption Form";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtConsumptionID);
            this.pnlMain.Controls.Add(this.lvDrugConsumption);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtConsumptionNameBang);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtConsumptionName);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(638, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(529, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(37, 554);
            this.btnDelete.Size = new System.Drawing.Size(44, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(420, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(87, 554);
            this.btnPrint.Size = new System.Drawing.Size(41, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 599);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(97, 153);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(30, 18);
            this.smartLabel1.TabIndex = 54;
            this.smartLabel1.Text = "ID :";
            // 
            // txtConsumptionID
            // 
            this.txtConsumptionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtConsumptionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsumptionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumptionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtConsumptionID.Location = new System.Drawing.Point(137, 150);
            this.txtConsumptionID.Name = "txtConsumptionID";
            this.txtConsumptionID.ReadOnly = true;
            this.txtConsumptionID.Size = new System.Drawing.Size(172, 24);
            this.txtConsumptionID.TabIndex = 53;
            this.txtConsumptionID.TabStop = false;
            // 
            // lvDrugConsumption
            // 
            this.lvDrugConsumption.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDrugConsumption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDrugConsumption.CheckBoxes = true;
            this.lvDrugConsumption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDrugConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrugConsumption.FullRowSelect = true;
            this.lvDrugConsumption.GridLines = true;
            this.lvDrugConsumption.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDrugConsumption.Location = new System.Drawing.Point(-1, 289);
            this.lvDrugConsumption.Name = "lvDrugConsumption";
            this.lvDrugConsumption.Size = new System.Drawing.Size(863, 346);
            this.lvDrugConsumption.TabIndex = 52;
            this.lvDrugConsumption.TabStop = false;
            this.lvDrugConsumption.UseCompatibleStateImageBehavior = false;
            this.lvDrugConsumption.View = System.Windows.Forms.View.Details;
            this.lvDrugConsumption.SelectedIndexChanged += new System.EventHandler(this.lvDrugConsumption_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(59, 240);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(68, 18);
            this.smartLabel7.TabIndex = 51;
            this.smartLabel7.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(137, 237);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(424, 46);
            this.txtRemarks.TabIndex = 48;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(23, 211);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(104, 18);
            this.smartLabel3.TabIndex = 50;
            this.smartLabel3.Text = "Name( Bangla) :";
            // 
            // txtConsumptionNameBang
            // 
            this.txtConsumptionNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsumptionNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumptionNameBang.Location = new System.Drawing.Point(137, 208);
            this.txtConsumptionNameBang.Name = "txtConsumptionNameBang";
            this.txtConsumptionNameBang.Size = new System.Drawing.Size(357, 24);
            this.txtConsumptionNameBang.TabIndex = 47;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(76, 182);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(51, 18);
            this.smartLabel2.TabIndex = 49;
            this.smartLabel2.Text = "Name :";
            // 
            // txtConsumptionName
            // 
            this.txtConsumptionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsumptionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumptionName.Location = new System.Drawing.Point(137, 179);
            this.txtConsumptionName.Name = "txtConsumptionName";
            this.txtConsumptionName.Size = new System.Drawing.Size(357, 24);
            this.txtConsumptionName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(497, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 142;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(497, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 143;
            this.label3.Text = "*";
            // 
            // frmConsumptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 624);
            this.isEnterTabAllow = true;
            this.Name = "frmConsumptionForm";
            this.Load += new System.EventHandler(this.frmDrugConsumption_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtConsumptionID;
        private AtiqsControlLibrary.SmartListViewDetails lvDrugConsumption;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtConsumptionNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtConsumptionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
