namespace AH.ModuleController.UI.ACMS.Forms
{
    partial class frmGetUserModule
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
            this.txtEmployeeID = new AtiqsControlLibrary.SmartTextBox();
            this.lvEmployeeAccessModule = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.btnShowModule = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(211, 33);
            this.frmLabel.Text = "User Module List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.btnShowModule);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.lvEmployeeAccessModule);
            this.pnlMain.Controls.Add(this.txtEmployeeID);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(859, 492);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(859, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(98, 562);
            this.btnEdit.Size = new System.Drawing.Size(10, 21);
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 552);
            this.btnSave.Size = new System.Drawing.Size(12, 39);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 552);
            this.btnDelete.Size = new System.Drawing.Size(26, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(619, 553);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(733, 553);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(129, 555);
            this.btnPrint.Size = new System.Drawing.Size(10, 21);
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 592);
            this.groupBox1.Size = new System.Drawing.Size(859, 23);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(77, 6);
            this.txtEmployeeID.MaxLength = 30;
            this.txtEmployeeID.Multiline = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(222, 30);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // lvEmployeeAccessModule
            // 
            this.lvEmployeeAccessModule.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvEmployeeAccessModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmployeeAccessModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmployeeAccessModule.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployeeAccessModule.FullRowSelect = true;
            this.lvEmployeeAccessModule.GridLines = true;
            this.lvEmployeeAccessModule.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmployeeAccessModule.Location = new System.Drawing.Point(-1, 53);
            this.lvEmployeeAccessModule.Name = "lvEmployeeAccessModule";
            this.lvEmployeeAccessModule.Size = new System.Drawing.Size(859, 438);
            this.lvEmployeeAccessModule.TabIndex = 16;
            this.lvEmployeeAccessModule.UseCompatibleStateImageBehavior = false;
            this.lvEmployeeAccessModule.View = System.Windows.Forms.View.Details;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(9, 13);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(58, 13);
            this.smartLabel1.TabIndex = 17;
            this.smartLabel1.Text = "User ID :";
            // 
            // btnShowModule
            // 
            this.btnShowModule.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowModule.ForeColor = System.Drawing.Color.White;
            this.btnShowModule.Location = new System.Drawing.Point(321, 6);
            this.btnShowModule.Name = "btnShowModule";
            this.btnShowModule.Size = new System.Drawing.Size(88, 31);
            this.btnShowModule.TabIndex = 2;
            this.btnShowModule.Text = "Show";
            this.btnShowModule.UseVisualStyleBackColor = false;
            this.btnShowModule.Click += new System.EventHandler(this.btnShowModule_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(303, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 194;
            this.label5.Text = "*";
            // 
            // frmGetUserModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(859, 615);
            this.isEnterTabAllow = true;
            this.Name = "frmGetUserModule";
            this.Load += new System.EventHandler(this.frmGetUserModule_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtEmployeeID;
        private AtiqsControlLibrary.SmartListViewDetails lvEmployeeAccessModule;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Button btnShowModule;
        private System.Windows.Forms.Label label5;
    }
}
