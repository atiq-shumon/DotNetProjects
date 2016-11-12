namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmColorCodeSetup
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
            this.txtColorID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtColorNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtColorName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvColorCode = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(221, 33);
            this.frmLabel.Text = "Color Code Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvColorCode);
            this.pnlMain.Controls.Add(this.txtColorID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtColorNameBeng);
            this.pnlMain.Controls.Add(this.txtColorName);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtRemarks);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(865, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(422, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(309, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(535, 555);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(196, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(757, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(646, 555);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 594);
            this.groupBox1.Size = new System.Drawing.Size(865, 25);
            // 
            // txtColorID
            // 
            this.txtColorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtColorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtColorID.Location = new System.Drawing.Point(216, 154);
            this.txtColorID.Name = "txtColorID";
            this.txtColorID.ReadOnly = true;
            this.txtColorID.Size = new System.Drawing.Size(146, 24);
            this.txtColorID.TabIndex = 83;
            this.txtColorID.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(85, 233);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(125, 18);
            this.smartLabel3.TabIndex = 82;
            this.smartLabel3.Text = "Color Name(Beng) :";
            // 
            // txtColorNameBeng
            // 
            this.txtColorNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColorNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorNameBeng.Location = new System.Drawing.Point(216, 230);
            this.txtColorNameBeng.Name = "txtColorNameBeng";
            this.txtColorNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtColorNameBeng.TabIndex = 77;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(142, 271);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 81;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(216, 268);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(395, 62);
            this.txtRemarks.TabIndex = 78;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(121, 194);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(89, 18);
            this.smartLabel2.TabIndex = 80;
            this.smartLabel2.Text = "Color  Name :";
            // 
            // txtColorName
            // 
            this.txtColorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorName.Location = new System.Drawing.Point(216, 191);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(395, 24);
            this.txtColorName.TabIndex = 76;
            this.txtColorName.TextChanged += new System.EventHandler(this.txtColorName_TextChanged);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(145, 156);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(65, 18);
            this.smartLabel1.TabIndex = 79;
            this.smartLabel1.Text = "Color ID :";
            // 
            // lvColorCode
            // 
            this.lvColorCode.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvColorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvColorCode.CheckBoxes = true;
            this.lvColorCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvColorCode.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvColorCode.FullRowSelect = true;
            this.lvColorCode.GridLines = true;
            this.lvColorCode.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvColorCode.Location = new System.Drawing.Point(-1, 345);
            this.lvColorCode.Name = "lvColorCode";
            this.lvColorCode.Size = new System.Drawing.Size(865, 290);
            this.lvColorCode.TabIndex = 84;
            this.lvColorCode.TabStop = false;
            this.lvColorCode.UseCompatibleStateImageBehavior = false;
            this.lvColorCode.View = System.Windows.Forms.View.Details;
            this.lvColorCode.SelectedIndexChanged += new System.EventHandler(this.lvColorCode_SelectedIndexChanged);
            this.lvColorCode.Click += new System.EventHandler(this.lvColorCode_Click);
            // 
            // frmColorCodeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(865, 619);
            this.isEnterTabAllow = true;
            this.Name = "frmColorCodeSetup";
            this.Load += new System.EventHandler(this.frmColorCodeSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartReadOnlyTextBox txtColorID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtColorNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtColorName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvColorCode;
    }
}
