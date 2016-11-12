namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmPurposeSetup
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPurposeNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtPurposeName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtPurposeID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvPurpose = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtAccCode = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(306, 10);
            this.frmLabel.Size = new System.Drawing.Size(187, 33);
            this.frmLabel.Text = "Purpose Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtAccCode);
            this.pnlMain.Controls.Add(this.lvPurpose);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtPurposeNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtPurposeName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtPurposeID);
            this.pnlMain.Location = new System.Drawing.Point(1, 66);
            this.pnlMain.Size = new System.Drawing.Size(863, 507);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(413, 576);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 576);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(526, 576);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(187, 576);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(748, 576);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(637, 576);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 613);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(156, 91);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(156, 18);
            this.smartLabel3.TabIndex = 11;
            this.smartLabel3.Text = "Purpose Name (Bangla) :";
            // 
            // txtPurposeNameBeng
            // 
            this.txtPurposeNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurposeNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurposeNameBeng.Location = new System.Drawing.Point(329, 88);
            this.txtPurposeNameBeng.Name = "txtPurposeNameBeng";
            this.txtPurposeNameBeng.Size = new System.Drawing.Size(412, 24);
            this.txtPurposeNameBeng.TabIndex = 9;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(209, 49);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(103, 18);
            this.smartLabel2.TabIndex = 10;
            this.smartLabel2.Text = "Purpose Name :";
            // 
            // txtPurposeName
            // 
            this.txtPurposeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurposeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurposeName.Location = new System.Drawing.Point(329, 46);
            this.txtPurposeName.Name = "txtPurposeName";
            this.txtPurposeName.Size = new System.Drawing.Size(412, 24);
            this.txtPurposeName.TabIndex = 7;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(230, 8);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(82, 18);
            this.smartLabel1.TabIndex = 8;
            this.smartLabel1.Text = "Purpose ID :";
            // 
            // txtPurposeID
            // 
            this.txtPurposeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurposeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurposeID.Location = new System.Drawing.Point(329, 5);
            this.txtPurposeID.Name = "txtPurposeID";
            this.txtPurposeID.Size = new System.Drawing.Size(112, 24);
            this.txtPurposeID.TabIndex = 6;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(215, 130);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(97, 18);
            this.smartLabel4.TabIndex = 13;
            this.smartLabel4.Text = "Account Code :";
            // 
            // lvPurpose
            // 
            this.lvPurpose.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPurpose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPurpose.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPurpose.FullRowSelect = true;
            this.lvPurpose.GridLines = true;
            this.lvPurpose.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPurpose.Location = new System.Drawing.Point(10, 159);
            this.lvPurpose.Name = "lvPurpose";
            this.lvPurpose.Size = new System.Drawing.Size(839, 340);
            this.lvPurpose.TabIndex = 14;
            this.lvPurpose.UseCompatibleStateImageBehavior = false;
            this.lvPurpose.View = System.Windows.Forms.View.Details;
            this.lvPurpose.SelectedIndexChanged += new System.EventHandler(this.lvPurpose_SelectedIndexChanged);
            // 
            // txtAccCode
            // 
            this.txtAccCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccCode.Location = new System.Drawing.Point(329, 127);
            this.txtAccCode.Name = "txtAccCode";
            this.txtAccCode.Size = new System.Drawing.Size(412, 24);
            this.txtAccCode.TabIndex = 15;
            // 
            // frmPurposeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 638);
            this.Name = "frmPurposeSetup";
            this.Load += new System.EventHandler(this.frmPurposeSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtPurposeNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtPurposeName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtPurposeID;
        private AtiqsControlLibrary.SmartListViewDetails lvPurpose;
        private AtiqsControlLibrary.SmartTextBox txtAccCode;
    }
}