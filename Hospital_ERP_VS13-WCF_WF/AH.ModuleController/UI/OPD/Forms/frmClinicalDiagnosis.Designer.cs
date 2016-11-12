namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmClinicalDiagnosis
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
            this.lvClinicalDiag = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDiagNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtDiagName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtDiagID = new AtiqsControlLibrary.SmartTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(248, 33);
            this.frmLabel.Text = "Clinical Impressions";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvClinicalDiag);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(884, 537);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(884, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(652, 600);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 600);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 622);
            this.btnDelete.Size = new System.Drawing.Size(10, 10);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(426, 600);
            this.btnNew.TabIndex = 6;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(766, 600);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(25, 622);
            this.btnPrint.Size = new System.Drawing.Size(10, 10);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 640);
            this.groupBox1.Size = new System.Drawing.Size(884, 25);
            // 
            // lvClinicalDiag
            // 
            this.lvClinicalDiag.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvClinicalDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvClinicalDiag.CheckBoxes = true;
            this.lvClinicalDiag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvClinicalDiag.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClinicalDiag.FullRowSelect = true;
            this.lvClinicalDiag.GridLines = true;
            this.lvClinicalDiag.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvClinicalDiag.Location = new System.Drawing.Point(0, 190);
            this.lvClinicalDiag.Name = "lvClinicalDiag";
            this.lvClinicalDiag.Size = new System.Drawing.Size(882, 345);
            this.lvClinicalDiag.TabIndex = 61;
            this.lvClinicalDiag.TabStop = false;
            this.lvClinicalDiag.UseCompatibleStateImageBehavior = false;
            this.lvClinicalDiag.View = System.Windows.Forms.View.Details;
            this.lvClinicalDiag.SelectedIndexChanged += new System.EventHandler(this.lvClinicalDiag_SelectedIndexChanged);
            this.lvClinicalDiag.Click += new System.EventHandler(this.lvClinicalDiag_Click);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(224, 120);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(65, 15);
            this.smartLabel5.TabIndex = 60;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(296, 123);
            this.txtRemarks.MaxLength = 300;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(507, 51);
            this.txtRemarks.TabIndex = 3;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(62, 85);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(212, 15);
            this.smartLabel3.TabIndex = 59;
            this.smartLabel3.Text = "Clinical Impressions Name( Bangla) :";
            // 
            // txtDiagNameBang
            // 
            this.txtDiagNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagNameBang.Location = new System.Drawing.Point(296, 86);
            this.txtDiagNameBang.Name = "txtDiagNameBang";
            this.txtDiagNameBang.Size = new System.Drawing.Size(507, 24);
            this.txtDiagNameBang.TabIndex = 2;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(115, 50);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(162, 15);
            this.smartLabel2.TabIndex = 58;
            this.smartLabel2.Text = "Clinical Impressions Name :";
            // 
            // txtDiagName
            // 
            this.txtDiagName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagName.Location = new System.Drawing.Point(296, 49);
            this.txtDiagName.MaxLength = 70;
            this.txtDiagName.Name = "txtDiagName";
            this.txtDiagName.Size = new System.Drawing.Size(507, 24);
            this.txtDiagName.TabIndex = 1;
            this.txtDiagName.TextChanged += new System.EventHandler(this.txtDiagName_TextChanged);
            this.txtDiagName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiagName_KeyUp);
            this.txtDiagName.Leave += new System.EventHandler(this.txtDiagName_Leave);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(136, 15);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(144, 15);
            this.smartLabel1.TabIndex = 57;
            this.smartLabel1.Text = "Clinical Impressions ID :";
            // 
            // txtDiagID
            // 
            this.txtDiagID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagID.Location = new System.Drawing.Point(296, 12);
            this.txtDiagID.Name = "txtDiagID";
            this.txtDiagID.ReadOnly = true;
            this.txtDiagID.Size = new System.Drawing.Size(185, 24);
            this.txtDiagID.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.txtDiagID);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.txtDiagName);
            this.groupBox2.Controls.Add(this.smartLabel3);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.txtDiagNameBang);
            this.groupBox2.Location = new System.Drawing.Point(4, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 183);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // frmClinicalDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.isEnterTabAllow = true;
            this.Name = "frmClinicalDiagnosis";
            this.Load += new System.EventHandler(this.frmClinicalDiagnosis_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvClinicalDiag;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDiagNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtDiagName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtDiagID;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
