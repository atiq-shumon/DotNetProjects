namespace AH.ModuleController.UI.DIET.Forms
{
    partial class frmWeeklyDietSetup
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
            this.txtDietMenu = new AtiqsControlLibrary.SmartTextBox();
            this.cboDayNo = new AtiqsControlLibrary.SmartComboBox();
            this.cboDietTypeID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboSetMenuID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvwWeeklyDiet = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtWeeklyDiet = new AtiqsControlLibrary.SmartTextBox();
            this.txtTime = new System.Windows.Forms.DateTimePicker();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(310, 8);
            this.frmLabel.Size = new System.Drawing.Size(230, 33);
            this.frmLabel.Text = "Weekly Diet Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtTime);
            this.pnlMain.Controls.Add(this.txtWeeklyDiet);
            this.pnlMain.Controls.Add(this.lvwWeeklyDiet);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboSetMenuID);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboDietTypeID);
            this.pnlMain.Controls.Add(this.cboDayNo);
            this.pnlMain.Controls.Add(this.txtDietMenu);
            this.pnlMain.Size = new System.Drawing.Size(855, 636);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(858, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(636, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(523, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(33, 553);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(410, 555);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(144, 553);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(858, 25);
            // 
            // txtDietMenu
            // 
            this.txtDietMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDietMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDietMenu.Location = new System.Drawing.Point(291, 168);
            this.txtDietMenu.Name = "txtDietMenu";
            this.txtDietMenu.Size = new System.Drawing.Size(362, 24);
            this.txtDietMenu.TabIndex = 0;
            this.txtDietMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDietMenu_KeyPress);
            // 
            // cboDayNo
            // 
            this.cboDayNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDayNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDayNo.ForeColor = System.Drawing.Color.Blue;
            this.cboDayNo.FormattingEnabled = true;
            this.cboDayNo.Location = new System.Drawing.Point(291, 198);
            this.cboDayNo.Name = "cboDayNo";
            this.cboDayNo.Size = new System.Drawing.Size(362, 26);
            this.cboDayNo.TabIndex = 1;
            this.cboDayNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDayNo_KeyPress);
            // 
            // cboDietTypeID
            // 
            this.cboDietTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDietTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDietTypeID.ForeColor = System.Drawing.Color.Blue;
            this.cboDietTypeID.FormattingEnabled = true;
            this.cboDietTypeID.Location = new System.Drawing.Point(291, 230);
            this.cboDietTypeID.Name = "cboDietTypeID";
            this.cboDietTypeID.Size = new System.Drawing.Size(362, 26);
            this.cboDietTypeID.TabIndex = 2;
            this.cboDietTypeID.SelectedIndexChanged += new System.EventHandler(this.cboDietTypeID_SelectedIndexChanged);
            this.cboDietTypeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDietTypeID_KeyPress);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(206, 172);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(78, 14);
            this.smartLabel1.TabIndex = 3;
            this.smartLabel1.Text = "Diet Menu:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(246, 202);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(38, 14);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "Day:";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(209, 233);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(75, 14);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Diet Type:";
            // 
            // cboSetMenuID
            // 
            this.cboSetMenuID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetMenuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSetMenuID.ForeColor = System.Drawing.Color.Blue;
            this.cboSetMenuID.FormattingEnabled = true;
            this.cboSetMenuID.Location = new System.Drawing.Point(291, 262);
            this.cboSetMenuID.Name = "cboSetMenuID";
            this.cboSetMenuID.Size = new System.Drawing.Size(362, 26);
            this.cboSetMenuID.TabIndex = 6;
            this.cboSetMenuID.SelectedIndexChanged += new System.EventHandler(this.cboSetMenuID_SelectedIndexChanged);
            this.cboSetMenuID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSetMenuID_KeyPress);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(177, 266);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(107, 14);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Diet Sub Menu:";
            // 
            // lvwWeeklyDiet
            // 
            this.lvwWeeklyDiet.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwWeeklyDiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwWeeklyDiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwWeeklyDiet.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwWeeklyDiet.FullRowSelect = true;
            this.lvwWeeklyDiet.GridLines = true;
            this.lvwWeeklyDiet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwWeeklyDiet.Location = new System.Drawing.Point(11, 321);
            this.lvwWeeklyDiet.Name = "lvwWeeklyDiet";
            this.lvwWeeklyDiet.Size = new System.Drawing.Size(837, 299);
            this.lvwWeeklyDiet.TabIndex = 8;
            this.lvwWeeklyDiet.UseCompatibleStateImageBehavior = false;
            this.lvwWeeklyDiet.View = System.Windows.Forms.View.Details;
            this.lvwWeeklyDiet.SelectedIndexChanged += new System.EventHandler(this.lvwWeeklyDiet_SelectedIndexChanged);
            // 
            // txtWeeklyDiet
            // 
            this.txtWeeklyDiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeeklyDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeeklyDiet.Location = new System.Drawing.Point(11, 266);
            this.txtWeeklyDiet.Name = "txtWeeklyDiet";
            this.txtWeeklyDiet.Size = new System.Drawing.Size(100, 24);
            this.txtWeeklyDiet.TabIndex = 9;
            this.txtWeeklyDiet.Visible = false;
            // 
            // txtTime
            // 
            this.txtTime.CustomFormat = "hh:mm tt";
            this.txtTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTime.Location = new System.Drawing.Point(291, 293);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(137, 22);
            this.txtTime.TabIndex = 10;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(240, 295);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(44, 14);
            this.smartLabel5.TabIndex = 11;
            this.smartLabel5.Text = "Time:";
            // 
            // frmWeeklyDietSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(858, 623);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmWeeklyDietSetup";
            this.Load += new System.EventHandler(this.frmWeeklyDietSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtDietMenu;
        private AtiqsControlLibrary.SmartListViewDetails lvwWeeklyDiet;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboSetMenuID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboDietTypeID;
        private AtiqsControlLibrary.SmartComboBox cboDayNo;
        private AtiqsControlLibrary.SmartTextBox txtWeeklyDiet;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.DateTimePicker txtTime;
    }
}
