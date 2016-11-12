namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmClinicalFindingsValue
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
            this.lvClinicalFindingsVal = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtClinicalFindingValNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.txtClinicalFindingValName = new AtiqsControlLibrary.SmartTextBox();
            this.txtClinicalFindingValID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(273, 9);
            this.frmLabel.Size = new System.Drawing.Size(351, 33);
            this.frmLabel.Text = "Clinical Findings Value Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvClinicalFindingsVal);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(884, 536);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(884, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(654, 600);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(541, 600);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 616);
            this.btnDelete.Size = new System.Drawing.Size(15, 13);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(428, 600);
            this.btnNew.TabIndex = 6;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(767, 600);
            this.btnClose.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(24, 616);
            this.btnPrint.Size = new System.Drawing.Size(15, 13);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 640);
            this.groupBox1.Size = new System.Drawing.Size(884, 25);
            // 
            // lvClinicalFindingsVal
            // 
            this.lvClinicalFindingsVal.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvClinicalFindingsVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvClinicalFindingsVal.CheckBoxes = true;
            this.lvClinicalFindingsVal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvClinicalFindingsVal.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClinicalFindingsVal.FullRowSelect = true;
            this.lvClinicalFindingsVal.GridLines = true;
            this.lvClinicalFindingsVal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvClinicalFindingsVal.Location = new System.Drawing.Point(0, 176);
            this.lvClinicalFindingsVal.Name = "lvClinicalFindingsVal";
            this.lvClinicalFindingsVal.Size = new System.Drawing.Size(882, 358);
            this.lvClinicalFindingsVal.TabIndex = 78;
            this.lvClinicalFindingsVal.TabStop = false;
            this.lvClinicalFindingsVal.UseCompatibleStateImageBehavior = false;
            this.lvClinicalFindingsVal.View = System.Windows.Forms.View.Details;
            this.lvClinicalFindingsVal.SelectedIndexChanged += new System.EventHandler(this.lvClinicalFindingsVal_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(299, 110);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(507, 51);
            this.txtRemarks.TabIndex = 3;
            // 
            // txtClinicalFindingValNameBang
            // 
            this.txtClinicalFindingValNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinicalFindingValNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindingValNameBang.Location = new System.Drawing.Point(299, 77);
            this.txtClinicalFindingValNameBang.Name = "txtClinicalFindingValNameBang";
            this.txtClinicalFindingValNameBang.Size = new System.Drawing.Size(507, 24);
            this.txtClinicalFindingValNameBang.TabIndex = 2;
            // 
            // txtClinicalFindingValName
            // 
            this.txtClinicalFindingValName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinicalFindingValName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindingValName.Location = new System.Drawing.Point(299, 44);
            this.txtClinicalFindingValName.Name = "txtClinicalFindingValName";
            this.txtClinicalFindingValName.Size = new System.Drawing.Size(507, 24);
            this.txtClinicalFindingValName.TabIndex = 1;
            this.txtClinicalFindingValName.TextChanged += new System.EventHandler(this.txtClinicalFindingValName_TextChanged);
            this.txtClinicalFindingValName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClinicalFindingValName_KeyUp);
            this.txtClinicalFindingValName.Leave += new System.EventHandler(this.txtClinicalFindingValName_Leave);
            // 
            // txtClinicalFindingValID
            // 
            this.txtClinicalFindingValID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinicalFindingValID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindingValID.Location = new System.Drawing.Point(299, 11);
            this.txtClinicalFindingValID.Name = "txtClinicalFindingValID";
            this.txtClinicalFindingValID.ReadOnly = true;
            this.txtClinicalFindingValID.Size = new System.Drawing.Size(185, 24);
            this.txtClinicalFindingValID.TabIndex = 73;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(227, 114);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 77;
            this.smartLabel5.Text = "Remarks :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(54, 80);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(241, 18);
            this.smartLabel3.TabIndex = 76;
            this.smartLabel3.Text = "Clinical Finding Value Name( Bangla) :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(107, 46);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(188, 18);
            this.smartLabel2.TabIndex = 75;
            this.smartLabel2.Text = "Clinical Finding Value Name :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(128, 13);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(167, 18);
            this.smartLabel1.TabIndex = 74;
            this.smartLabel1.Text = "Clinical Finding Value ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.txtClinicalFindingValNameBang);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.txtClinicalFindingValName);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Controls.Add(this.txtClinicalFindingValID);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 169);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            // 
            // frmClinicalFindingsValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.isEnterTabAllow = true;
            this.Name = "frmClinicalFindingsValue";
            this.Load += new System.EventHandler(this.frmClinicalFindingsValue_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvClinicalFindingsVal;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtClinicalFindingValNameBang;
        private AtiqsControlLibrary.SmartTextBox txtClinicalFindingValName;
        private AtiqsControlLibrary.SmartTextBox txtClinicalFindingValID;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}