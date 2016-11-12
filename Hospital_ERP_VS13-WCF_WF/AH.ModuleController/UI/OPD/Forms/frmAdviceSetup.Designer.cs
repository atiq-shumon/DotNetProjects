namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmAdviceSetup
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
            this.txtAdvice = new AtiqsControlLibrary.SmartTextBox();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.lvAdviceSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.txtAdviceID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(227, 33);
            this.frmLabel.Text = "OPD Advice Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvAdviceSetup);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(884, 534);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(884, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(652, 598);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 598);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(10, 619);
            this.btnDelete.Size = new System.Drawing.Size(16, 16);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(426, 598);
            this.btnNew.TabIndex = 6;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(767, 598);
            this.btnClose.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(26, 619);
            this.btnPrint.Size = new System.Drawing.Size(16, 16);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 640);
            this.groupBox1.Size = new System.Drawing.Size(884, 25);
            // 
            // txtAdvice
            // 
            this.txtAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(226, 44);
            this.txtAdvice.Multiline = true;
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(506, 60);
            this.txtAdvice.TabIndex = 2;
            this.txtAdvice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAdvice_KeyUp);
            this.txtAdvice.Leave += new System.EventHandler(this.txtAdvice_Leave);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(226, 112);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(506, 41);
            this.txtRemarks.TabIndex = 3;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(126, 17);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(75, 13);
            this.smartLabel1.TabIndex = 6;
            this.smartLabel1.Text = "Advice ID : ";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(126, 67);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(97, 13);
            this.smartLabel2.TabIndex = 7;
            this.smartLabel2.Text = "Advice Details :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(430, 16);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(84, 13);
            this.smartLabel4.TabIndex = 9;
            this.smartLabel4.Text = "Department : ";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(126, 123);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 13);
            this.smartLabel5.TabIndex = 10;
            this.smartLabel5.Text = "Remarks : ";
            // 
            // lvAdviceSetup
            // 
            this.lvAdviceSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvAdviceSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAdviceSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAdviceSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAdviceSetup.FullRowSelect = true;
            this.lvAdviceSetup.GridLines = true;
            this.lvAdviceSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAdviceSetup.Location = new System.Drawing.Point(0, 163);
            this.lvAdviceSetup.Name = "lvAdviceSetup";
            this.lvAdviceSetup.Size = new System.Drawing.Size(882, 369);
            this.lvAdviceSetup.TabIndex = 11;
            this.lvAdviceSetup.UseCompatibleStateImageBehavior = false;
            this.lvAdviceSetup.View = System.Windows.Forms.View.Details;
            this.lvAdviceSetup.Click += new System.EventHandler(this.lvAdviceSetup_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(515, 11);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(217, 26);
            this.cboDepartment.TabIndex = 1;
            // 
            // txtAdviceID
            // 
            this.txtAdviceID.BackColor = System.Drawing.Color.Linen;
            this.txtAdviceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdviceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAdviceID.Location = new System.Drawing.Point(226, 10);
            this.txtAdviceID.Name = "txtAdviceID";
            this.txtAdviceID.ReadOnly = true;
            this.txtAdviceID.Size = new System.Drawing.Size(180, 24);
            this.txtAdviceID.TabIndex = 14;
            this.txtAdviceID.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdvice);
            this.groupBox2.Controls.Add(this.txtAdviceID);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Controls.Add(this.cboDepartment);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.smartLabel5);
            this.groupBox2.Location = new System.Drawing.Point(3, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 161);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // frmAdviceSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.isEnterTabAllow = true;
            this.Name = "frmAdviceSetup";
            this.Load += new System.EventHandler(this.frmAdviceSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtAdvice;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartListViewDetails lvAdviceSetup;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtAdviceID;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
