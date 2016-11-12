namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmResHeadUnit
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
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtResRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtResUnitNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtResUnitName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvResUnit = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtResUnitID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(213, 33);
            this.frmLabel.Text = "Result Head Unit";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtResUnitID);
            this.pnlMain.Controls.Add(this.lvResUnit);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtResRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtResUnitNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtResUnitName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 507);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(418, 571);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 571);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 571);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(192, 571);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(753, 571);
            this.btnClose.TabIndex = 25;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(642, 571);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 612);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(115, 149);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 20;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtResRemarks
            // 
            this.txtResRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResRemarks.Location = new System.Drawing.Point(189, 149);
            this.txtResRemarks.Multiline = true;
            this.txtResRemarks.Name = "txtResRemarks";
            this.txtResRemarks.Size = new System.Drawing.Size(412, 46);
            this.txtResRemarks.TabIndex = 3;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(50, 108);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(133, 18);
            this.smartLabel3.TabIndex = 19;
            this.smartLabel3.Text = "Unit Name (Bangla) :";
            // 
            // txtResUnitNameBeng
            // 
            this.txtResUnitNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResUnitNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResUnitNameBeng.Location = new System.Drawing.Point(189, 105);
            this.txtResUnitNameBeng.Name = "txtResUnitNameBeng";
            this.txtResUnitNameBeng.Size = new System.Drawing.Size(412, 24);
            this.txtResUnitNameBeng.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(103, 66);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(80, 18);
            this.smartLabel2.TabIndex = 18;
            this.smartLabel2.Text = "Unit Name :";
            // 
            // txtResUnitName
            // 
            this.txtResUnitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResUnitName.Location = new System.Drawing.Point(189, 63);
            this.txtResUnitName.Name = "txtResUnitName";
            this.txtResUnitName.Size = new System.Drawing.Size(412, 24);
            this.txtResUnitName.TabIndex = 1;
            this.txtResUnitName.TextChanged += new System.EventHandler(this.txtResUnitName_TextChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(124, 25);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(59, 18);
            this.smartLabel1.TabIndex = 15;
            this.smartLabel1.Text = "Unit ID :";
            // 
            // lvResUnit
            // 
            this.lvResUnit.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvResUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvResUnit.CheckBoxes = true;
            this.lvResUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvResUnit.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResUnit.FullRowSelect = true;
            this.lvResUnit.GridLines = true;
            this.lvResUnit.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResUnit.Location = new System.Drawing.Point(-1, 215);
            this.lvResUnit.Name = "lvResUnit";
            this.lvResUnit.Size = new System.Drawing.Size(863, 288);
            this.lvResUnit.TabIndex = 57;
            this.lvResUnit.TabStop = false;
            this.lvResUnit.UseCompatibleStateImageBehavior = false;
            this.lvResUnit.View = System.Windows.Forms.View.Details;
            this.lvResUnit.SelectedIndexChanged += new System.EventHandler(this.lvResUnit_SelectedIndexChanged);
            this.lvResUnit.Click += new System.EventHandler(this.lvResUnit_Click);
            // 
            // txtResUnitID
            // 
            this.txtResUnitID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtResUnitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResUnitID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtResUnitID.Location = new System.Drawing.Point(189, 18);
            this.txtResUnitID.Name = "txtResUnitID";
            this.txtResUnitID.ReadOnly = true;
            this.txtResUnitID.Size = new System.Drawing.Size(203, 24);
            this.txtResUnitID.TabIndex = 58;
            this.txtResUnitID.TabStop = false;
            // 
            // frmResHeadUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 635);
            this.isEnterTabAllow = true;
            this.Name = "frmResHeadUnit";
            this.Load += new System.EventHandler(this.frmResHeadUnit_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtResRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtResUnitNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtResUnitName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvResUnit;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtResUnitID;
    }
}
