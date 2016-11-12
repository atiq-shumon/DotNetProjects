namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmShiftSetup
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
            this.txtShiftID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtShiftTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtShiftTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.lvShift = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(145, 33);
            this.frmLabel.Text = "Shift Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvShift);
            this.pnlMain.Controls.Add(this.txtShiftID);
            this.pnlMain.Controls.Add(this.txtShiftTitle);
            this.pnlMain.Controls.Add(this.txtShiftTitleBeng);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtShiftID
            // 
            this.txtShiftID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtShiftID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShiftID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtShiftID.Location = new System.Drawing.Point(145, 159);
            this.txtShiftID.Name = "txtShiftID";
            this.txtShiftID.ReadOnly = true;
            this.txtShiftID.Size = new System.Drawing.Size(136, 24);
            this.txtShiftID.TabIndex = 0;
            this.txtShiftID.TabStop = false;
            // 
            // txtShiftTitle
            // 
            this.txtShiftTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShiftTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftTitle.Location = new System.Drawing.Point(145, 191);
            this.txtShiftTitle.MaxLength = 70;
            this.txtShiftTitle.Multiline = true;
            this.txtShiftTitle.Name = "txtShiftTitle";
            this.txtShiftTitle.Size = new System.Drawing.Size(400, 28);
            this.txtShiftTitle.TabIndex = 1;
            this.txtShiftTitle.TextChanged += new System.EventHandler(this.txtShiftTitle_TextChanged);
            // 
            // txtShiftTitleBeng
            // 
            this.txtShiftTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShiftTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftTitleBeng.Location = new System.Drawing.Point(145, 228);
            this.txtShiftTitleBeng.MaxLength = 70;
            this.txtShiftTitleBeng.Multiline = true;
            this.txtShiftTitleBeng.Name = "txtShiftTitleBeng";
            this.txtShiftTitleBeng.Size = new System.Drawing.Size(400, 26);
            this.txtShiftTitleBeng.TabIndex = 2;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(18, 233);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(121, 13);
            this.smartLabel3.TabIndex = 210;
            this.smartLabel3.Text = "Shift Title (Bangla) :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(69, 197);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(70, 13);
            this.smartLabel2.TabIndex = 209;
            this.smartLabel2.Text = "Shift Title :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(81, 165);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(58, 13);
            this.smartLabel1.TabIndex = 208;
            this.smartLabel1.Text = "Shift ID :";
            // 
            // lvShift
            // 
            this.lvShift.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvShift.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvShift.FullRowSelect = true;
            this.lvShift.GridLines = true;
            this.lvShift.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvShift.Location = new System.Drawing.Point(0, 276);
            this.lvShift.Name = "lvShift";
            this.lvShift.Size = new System.Drawing.Size(863, 359);
            this.lvShift.TabIndex = 213;
            this.lvShift.UseCompatibleStateImageBehavior = false;
            this.lvShift.View = System.Windows.Forms.View.Details;
            this.lvShift.SelectedIndexChanged += new System.EventHandler(this.lvShift_SelectedIndexChanged);
            this.lvShift.Click += new System.EventHandler(this.lvShift_Click);
            // 
            // frmShiftSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmShiftSetup";
            this.Load += new System.EventHandler(this.frmShiftSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartReadOnlyTextBox txtShiftID;
        private AtiqsControlLibrary.SmartTextBox txtShiftTitle;
        private AtiqsControlLibrary.SmartTextBox txtShiftTitleBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvShift;
    }
}
