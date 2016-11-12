namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmSpecimenSetup
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtSpecimenNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtSpecimenName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvSpec = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtSpecimenID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Text = "Specimen Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtSpecimenID);
            this.pnlMain.Controls.Add(this.lvSpec);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtSpecimenNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtSpecimenName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 504);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(415, 568);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(302, 568);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(528, 568);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(189, 568);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 568);
            this.btnClose.TabIndex = 25;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(639, 568);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 612);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(37, 101);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(153, 18);
            this.smartLabel3.TabIndex = 47;
            this.smartLabel3.Text = "Specimen Name(Beng) :";
            // 
            // txtSpecimenNameBeng
            // 
            this.txtSpecimenNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecimenNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecimenNameBeng.Location = new System.Drawing.Point(205, 98);
            this.txtSpecimenNameBeng.Name = "txtSpecimenNameBeng";
            this.txtSpecimenNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtSpecimenNameBeng.TabIndex = 2;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(122, 136);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 46;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(205, 136);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(395, 62);
            this.txtRemarks.TabIndex = 3;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(76, 62);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(114, 18);
            this.smartLabel2.TabIndex = 45;
            this.smartLabel2.Text = "Specimen Name :";
            // 
            // txtSpecimenName
            // 
            this.txtSpecimenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecimenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecimenName.Location = new System.Drawing.Point(205, 59);
            this.txtSpecimenName.Name = "txtSpecimenName";
            this.txtSpecimenName.Size = new System.Drawing.Size(395, 24);
            this.txtSpecimenName.TabIndex = 1;
            this.txtSpecimenName.TextChanged += new System.EventHandler(this.txtSpecimenName_TextChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(97, 23);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(93, 18);
            this.smartLabel1.TabIndex = 44;
            this.smartLabel1.Text = "Specimen ID :";
            // 
            // lvSpec
            // 
            this.lvSpec.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvSpec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSpec.CheckBoxes = true;
            this.lvSpec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSpec.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSpec.FullRowSelect = true;
            this.lvSpec.GridLines = true;
            this.lvSpec.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSpec.Location = new System.Drawing.Point(-1, 216);
            this.lvSpec.Name = "lvSpec";
            this.lvSpec.Size = new System.Drawing.Size(863, 290);
            this.lvSpec.TabIndex = 58;
            this.lvSpec.TabStop = false;
            this.lvSpec.UseCompatibleStateImageBehavior = false;
            this.lvSpec.View = System.Windows.Forms.View.Details;
            this.lvSpec.SelectedIndexChanged += new System.EventHandler(this.lvSpec_SelectedIndexChanged);
            this.lvSpec.Click += new System.EventHandler(this.lvSpec_Click);
            // 
            // txtSpecimenID
            // 
            this.txtSpecimenID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtSpecimenID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecimenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecimenID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSpecimenID.Location = new System.Drawing.Point(205, 16);
            this.txtSpecimenID.Name = "txtSpecimenID";
            this.txtSpecimenID.ReadOnly = true;
            this.txtSpecimenID.Size = new System.Drawing.Size(207, 24);
            this.txtSpecimenID.TabIndex = 59;
            this.txtSpecimenID.TabStop = false;
            // 
            // frmSpecimenSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 635);
            this.isEnterTabAllow = true;
            this.Name = "frmSpecimenSetup";
            this.Load += new System.EventHandler(this.frmSpecimenSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtSpecimenNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtSpecimenName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvSpec;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtSpecimenID;

    }
}
