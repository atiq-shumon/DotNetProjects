namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmMealSetupConfig
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
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtMealID = new AtiqsControlLibrary.SmartTextBox();
            this.lvwMealSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtMealName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(329, 9);
            this.frmLabel.Size = new System.Drawing.Size(314, 33);
            this.frmLabel.Text = "Meal Setup Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.EndTime);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.StartTime);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtMealID);
            this.pnlMain.Controls.Add(this.lvwMealSetup);
            this.pnlMain.Controls.Add(this.txtMealName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, -63);
            this.pnlMain.Size = new System.Drawing.Size(863, 576);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(633, 515);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 515);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 511);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(407, 515);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(747, 515);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(161, 511);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 556);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(278, 231);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(379, 24);
            this.txtRemarks.TabIndex = 18;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(208, 235);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(60, 13);
            this.smartLabel3.TabIndex = 17;
            this.smartLabel3.Text = "Remarks:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(213, 140);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(55, 13);
            this.smartLabel2.TabIndex = 16;
            this.smartLabel2.Text = "Meal ID:";
            this.smartLabel2.Visible = false;
            // 
            // txtMealID
            // 
            this.txtMealID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMealID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealID.Location = new System.Drawing.Point(278, 134);
            this.txtMealID.Name = "txtMealID";
            this.txtMealID.Size = new System.Drawing.Size(379, 24);
            this.txtMealID.TabIndex = 15;
            this.txtMealID.Visible = false;
            // 
            // lvwMealSetup
            // 
            this.lvwMealSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwMealSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwMealSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwMealSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMealSetup.FullRowSelect = true;
            this.lvwMealSetup.GridLines = true;
            this.lvwMealSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwMealSetup.Location = new System.Drawing.Point(7, 288);
            this.lvwMealSetup.Name = "lvwMealSetup";
            this.lvwMealSetup.Size = new System.Drawing.Size(847, 275);
            this.lvwMealSetup.TabIndex = 14;
            this.lvwMealSetup.UseCompatibleStateImageBehavior = false;
            this.lvwMealSetup.View = System.Windows.Forms.View.Details;
            this.lvwMealSetup.SelectedIndexChanged += new System.EventHandler(this.lvwMealSetup_SelectedIndexChanged);
            // 
            // txtMealName
            // 
            this.txtMealName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealName.Location = new System.Drawing.Point(278, 167);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(379, 24);
            this.txtMealName.TabIndex = 13;
            this.txtMealName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMealName_KeyPress);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(194, 171);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(74, 13);
            this.smartLabel1.TabIndex = 12;
            this.smartLabel1.Text = "Meal Name:";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(199, 203);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(69, 13);
            this.smartLabel4.TabIndex = 19;
            this.smartLabel4.Text = "Start Time:";
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "";
            this.StartTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTime.Location = new System.Drawing.Point(278, 200);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(141, 22);
            this.StartTime.TabIndex = 20;
            this.StartTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTime_KeyPress);
            // 
            // EndTime
            // 
            this.EndTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTime.Location = new System.Drawing.Point(521, 200);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(136, 22);
            this.EndTime.TabIndex = 22;
            this.EndTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EndTime_KeyPress);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(443, 203);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(64, 13);
            this.smartLabel5.TabIndex = 21;
            this.smartLabel5.Text = "End Time:";
            // 
            // frmMealSetupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 581);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmMealSetupConfig";
            this.Load += new System.EventHandler(this.frmMealSetupConfig_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtMealID;
        private AtiqsControlLibrary.SmartListViewDetails lvwMealSetup;
        private AtiqsControlLibrary.SmartTextBox txtMealName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.DateTimePicker EndTime;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.DateTimePicker StartTime;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
    }
}
