namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmMethodSetup
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
            this.lvMethod = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtMethodID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtMethodNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtMethodName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(180, 33);
            this.frmLabel.Text = "Method Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.lvMethod);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(420, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(533, 555);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(194, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(755, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(644, 555);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 597);
            // 
            // lvMethod
            // 
            this.lvMethod.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMethod.CheckBoxes = true;
            this.lvMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvMethod.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMethod.FullRowSelect = true;
            this.lvMethod.GridLines = true;
            this.lvMethod.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMethod.Location = new System.Drawing.Point(-1, 338);
            this.lvMethod.Name = "lvMethod";
            this.lvMethod.Size = new System.Drawing.Size(863, 297);
            this.lvMethod.TabIndex = 77;
            this.lvMethod.TabStop = false;
            this.lvMethod.UseCompatibleStateImageBehavior = false;
            this.lvMethod.View = System.Windows.Forms.View.Details;
            this.lvMethod.SelectedIndexChanged += new System.EventHandler(this.lvMethod_SelectedIndexChanged);
            this.lvMethod.Click += new System.EventHandler(this.lvMethod_Click);
            // 
            // txtMethodID
            // 
            this.txtMethodID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtMethodID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMethodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethodID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMethodID.Location = new System.Drawing.Point(281, 64);
            this.txtMethodID.Name = "txtMethodID";
            this.txtMethodID.ReadOnly = true;
            this.txtMethodID.Size = new System.Drawing.Size(146, 24);
            this.txtMethodID.TabIndex = 76;
            this.txtMethodID.TabStop = false;
            // 
            // txtMethodNameBeng
            // 
            this.txtMethodNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMethodNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethodNameBeng.Location = new System.Drawing.Point(281, 146);
            this.txtMethodNameBeng.Name = "txtMethodNameBeng";
            this.txtMethodNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtMethodNameBeng.TabIndex = 70;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(281, 184);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(395, 62);
            this.txtRemarks.TabIndex = 71;
            // 
            // txtMethodName
            // 
            this.txtMethodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMethodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethodName.Location = new System.Drawing.Point(281, 107);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(395, 24);
            this.txtMethodName.TabIndex = 69;
            this.txtMethodName.TextChanged += new System.EventHandler(this.txtMethodName_TextChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(122, 234);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(140, 18);
            this.smartLabel3.TabIndex = 81;
            this.smartLabel3.Text = "Method Name(Beng) :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(194, 272);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 80;
            this.smartLabel5.Text = "Remarks :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(161, 195);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(101, 18);
            this.smartLabel2.TabIndex = 79;
            this.smartLabel2.Text = "Method Name :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(182, 154);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(80, 18);
            this.smartLabel1.TabIndex = 78;
            this.smartLabel1.Text = "Method ID :";
            // 
            // frmMethodSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 622);
            this.Controls.Add(this.txtMethodID);
            this.Controls.Add(this.txtMethodNameBeng);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtMethodName);
            this.isEnterTabAllow = true;
            this.Name = "frmMethodSetup";
            this.Load += new System.EventHandler(this.frmMethodSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtMethodName, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.txtMethodNameBeng, 0);
            this.Controls.SetChildIndex(this.txtMethodID, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvMethod;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtMethodID;
        private AtiqsControlLibrary.SmartTextBox txtMethodNameBeng;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtMethodName;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
    }
}
