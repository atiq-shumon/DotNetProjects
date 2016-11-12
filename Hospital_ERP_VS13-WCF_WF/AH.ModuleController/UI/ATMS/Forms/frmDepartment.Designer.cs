namespace AH.ModuleController.UI.ATMS.Forms
{
    partial class frmDepartment
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
            this.smartTextBox1 = new AtiqsControlLibrary.SmartTextBox();
            this.smartTextBox2 = new AtiqsControlLibrary.SmartTextBox();
            this.txtDepartmentID = new AtiqsControlLibrary.SmartTextBox();
            this.txtDepartmentName = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartListViewDetails1 = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(300, 9);
            this.frmLabel.Size = new System.Drawing.Size(324, 33);
            this.frmLabel.TabIndex = 8;
            this.frmLabel.Text = "Department Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartListViewDetails1);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtDepartmentName);
            this.pnlMain.Controls.Add(this.txtDepartmentID);
            this.pnlMain.Controls.Add(this.smartTextBox2);
            this.pnlMain.Controls.Add(this.smartTextBox1);
            // 
            // btnEdit
            // 
            this.btnEdit.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.TabIndex = 7;
            // 
            // smartTextBox1
            // 
            this.smartTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox1.Location = new System.Drawing.Point(0, 0);
            this.smartTextBox1.Name = "smartTextBox1";
            this.smartTextBox1.Size = new System.Drawing.Size(100, 24);
            this.smartTextBox1.TabIndex = 21;
            // 
            // smartTextBox2
            // 
            this.smartTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox2.Location = new System.Drawing.Point(0, 0);
            this.smartTextBox2.Name = "smartTextBox2";
            this.smartTextBox2.Size = new System.Drawing.Size(100, 24);
            this.smartTextBox2.TabIndex = 22;
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentID.Location = new System.Drawing.Point(292, 177);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(355, 24);
            this.txtDepartmentID.TabIndex = 0;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Location = new System.Drawing.Point(292, 208);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(355, 24);
            this.txtDepartmentName.TabIndex = 1;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(292, 238);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(355, 24);
            this.txtRemarks.TabIndex = 2;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel1.Location = new System.Drawing.Point(164, 180);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(115, 16);
            this.smartLabel1.TabIndex = 26;
            this.smartLabel1.Text = "Department ID :";
            this.smartLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel2.Location = new System.Drawing.Point(142, 211);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(137, 16);
            this.smartLabel2.TabIndex = 27;
            this.smartLabel2.Text = "Department Name :";
            this.smartLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartLabel3.Location = new System.Drawing.Point(206, 240);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(73, 16);
            this.smartLabel3.TabIndex = 28;
            this.smartLabel3.Text = "Remarks :";
            this.smartLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // smartListViewDetails1
            // 
            this.smartListViewDetails1.BackColor = System.Drawing.Color.LemonChiffon;
            this.smartListViewDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartListViewDetails1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smartListViewDetails1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartListViewDetails1.FullRowSelect = true;
            this.smartListViewDetails1.GridLines = true;
            this.smartListViewDetails1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.smartListViewDetails1.Location = new System.Drawing.Point(5, 279);
            this.smartListViewDetails1.Name = "smartListViewDetails1";
            this.smartListViewDetails1.Size = new System.Drawing.Size(843, 327);
            this.smartListViewDetails1.TabIndex = 3;
            this.smartListViewDetails1.UseCompatibleStateImageBehavior = false;
            this.smartListViewDetails1.View = System.Windows.Forms.View.Details;
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.Name = "frmDepartment";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails smartListViewDetails1;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtDepartmentName;
        private AtiqsControlLibrary.SmartTextBox txtDepartmentID;
        private AtiqsControlLibrary.SmartTextBox smartTextBox2;
        private AtiqsControlLibrary.SmartTextBox smartTextBox1;

    }
}
