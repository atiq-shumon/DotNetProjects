namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmWeeklySetmenu
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
            this.cboWeeksetup = new System.Windows.Forms.ComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cbomealId = new System.Windows.Forms.ComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvwWeekSetup = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtOldSetmenuID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboSetmenuTypeID = new System.Windows.Forms.ComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboMenuId = new System.Windows.Forms.ComboBox();
            this.txtOldWdayNo = new AtiqsControlLibrary.SmartTextBox();
            this.txtOldMealID = new AtiqsControlLibrary.SmartTextBox();
            this.txtOldFoodMenuID = new AtiqsControlLibrary.SmartTextBox();
            this.btnTypeRefresh = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnFoodRefMeal = new System.Windows.Forms.Button();
            this.btnMealID = new System.Windows.Forms.Button();
            this.btnRefFoodMneu = new System.Windows.Forms.Button();
            this.btnFoodMenu = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(260, 9);
            this.frmLabel.Size = new System.Drawing.Size(294, 33);
            this.frmLabel.Text = "Set Menu Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnshow);
            this.pnlMain.Controls.Add(this.btnRefFoodMneu);
            this.pnlMain.Controls.Add(this.btnFoodMenu);
            this.pnlMain.Controls.Add(this.btnFoodRefMeal);
            this.pnlMain.Controls.Add(this.btnMealID);
            this.pnlMain.Controls.Add(this.btnTypeRefresh);
            this.pnlMain.Controls.Add(this.btnType);
            this.pnlMain.Controls.Add(this.txtOldFoodMenuID);
            this.pnlMain.Controls.Add(this.txtOldMealID);
            this.pnlMain.Controls.Add(this.txtOldWdayNo);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboMenuId);
            this.pnlMain.Controls.Add(this.cboSetmenuTypeID);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtOldSetmenuID);
            this.pnlMain.Controls.Add(this.lvwWeekSetup);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cbomealId);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboWeeksetup);
            this.pnlMain.Size = new System.Drawing.Size(765, 687);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(765, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(544, 604);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(431, 604);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(-102, 605);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(318, 604);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(656, 605);
            this.btnClose.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(9, 605);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 661);
            this.groupBox1.Size = new System.Drawing.Size(765, 25);
            // 
            // cboWeeksetup
            // 
            this.cboWeeksetup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWeeksetup.FormattingEnabled = true;
            this.cboWeeksetup.Location = new System.Drawing.Point(243, 211);
            this.cboWeeksetup.Name = "cboWeeksetup";
            this.cboWeeksetup.Size = new System.Drawing.Size(350, 22);
            this.cboWeeksetup.TabIndex = 1;
            this.cboWeeksetup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboWeeksetup_KeyUp);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(162, 213);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(70, 13);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Week Day:";
            // 
            // cbomealId
            // 
            this.cbomealId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomealId.FormattingEnabled = true;
            this.cbomealId.Location = new System.Drawing.Point(243, 240);
            this.cbomealId.Name = "cbomealId";
            this.cbomealId.Size = new System.Drawing.Size(350, 22);
            this.cbomealId.TabIndex = 2;
            this.cbomealId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbomealId_KeyUp);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(177, 243);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(55, 13);
            this.smartLabel4.TabIndex = 7;
            this.smartLabel4.Text = "Meal ID:";
            // 
            // lvwWeekSetup
            // 
            this.lvwWeekSetup.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwWeekSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwWeekSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwWeekSetup.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwWeekSetup.FullRowSelect = true;
            this.lvwWeekSetup.GridLines = true;
            this.lvwWeekSetup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwWeekSetup.Location = new System.Drawing.Point(8, 321);
            this.lvwWeekSetup.Name = "lvwWeekSetup";
            this.lvwWeekSetup.Size = new System.Drawing.Size(747, 337);
            this.lvwWeekSetup.TabIndex = 3;
            this.lvwWeekSetup.UseCompatibleStateImageBehavior = false;
            this.lvwWeekSetup.View = System.Windows.Forms.View.Details;
            this.lvwWeekSetup.SelectedIndexChanged += new System.EventHandler(this.lvwWeekSetup_SelectedIndexChanged);
            // 
            // txtOldSetmenuID
            // 
            this.txtOldSetmenuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldSetmenuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldSetmenuID.Location = new System.Drawing.Point(54, 151);
            this.txtOldSetmenuID.Name = "txtOldSetmenuID";
            this.txtOldSetmenuID.Size = new System.Drawing.Size(135, 24);
            this.txtOldSetmenuID.TabIndex = 4;
            this.txtOldSetmenuID.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(118, 184);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(114, 13);
            this.smartLabel1.TabIndex = 16;
            this.smartLabel1.Text = "Set Menu Type ID:";
            // 
            // cboSetmenuTypeID
            // 
            this.cboSetmenuTypeID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSetmenuTypeID.FormattingEnabled = true;
            this.cboSetmenuTypeID.Location = new System.Drawing.Point(243, 182);
            this.cboSetmenuTypeID.Name = "cboSetmenuTypeID";
            this.cboSetmenuTypeID.Size = new System.Drawing.Size(350, 22);
            this.cboSetmenuTypeID.TabIndex = 0;
            this.cboSetmenuTypeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboSetmenuTypeID_KeyUp);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(142, 274);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(91, 13);
            this.smartLabel2.TabIndex = 18;
            this.smartLabel2.Text = "Food Menu ID:";
            // 
            // cboMenuId
            // 
            this.cboMenuId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMenuId.FormattingEnabled = true;
            this.cboMenuId.Location = new System.Drawing.Point(243, 271);
            this.cboMenuId.Name = "cboMenuId";
            this.cboMenuId.Size = new System.Drawing.Size(350, 22);
            this.cboMenuId.TabIndex = 3;
            this.cboMenuId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboMenuId_KeyUp);
            // 
            // txtOldWdayNo
            // 
            this.txtOldWdayNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldWdayNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldWdayNo.Location = new System.Drawing.Point(207, 152);
            this.txtOldWdayNo.Name = "txtOldWdayNo";
            this.txtOldWdayNo.Size = new System.Drawing.Size(135, 24);
            this.txtOldWdayNo.TabIndex = 19;
            this.txtOldWdayNo.Visible = false;
            // 
            // txtOldMealID
            // 
            this.txtOldMealID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldMealID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldMealID.Location = new System.Drawing.Point(360, 152);
            this.txtOldMealID.Name = "txtOldMealID";
            this.txtOldMealID.Size = new System.Drawing.Size(135, 24);
            this.txtOldMealID.TabIndex = 20;
            this.txtOldMealID.Visible = false;
            // 
            // txtOldFoodMenuID
            // 
            this.txtOldFoodMenuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldFoodMenuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldFoodMenuID.Location = new System.Drawing.Point(517, 151);
            this.txtOldFoodMenuID.Name = "txtOldFoodMenuID";
            this.txtOldFoodMenuID.Size = new System.Drawing.Size(135, 24);
            this.txtOldFoodMenuID.TabIndex = 21;
            this.txtOldFoodMenuID.Visible = false;
            // 
            // btnTypeRefresh
            // 
            this.btnTypeRefresh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTypeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnTypeRefresh.Location = new System.Drawing.Point(617, 179);
            this.btnTypeRefresh.Name = "btnTypeRefresh";
            this.btnTypeRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnTypeRefresh.TabIndex = 143;
            this.btnTypeRefresh.Text = "..";
            this.btnTypeRefresh.UseVisualStyleBackColor = false;
            this.btnTypeRefresh.Click += new System.EventHandler(this.btnTypeRefresh_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.ForestGreen;
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType.ForeColor = System.Drawing.Color.White;
            this.btnType.Location = new System.Drawing.Point(596, 179);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(19, 26);
            this.btnType.TabIndex = 142;
            this.btnType.Text = "+";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnFoodRefMeal
            // 
            this.btnFoodRefMeal.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnFoodRefMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodRefMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodRefMeal.ForeColor = System.Drawing.Color.Black;
            this.btnFoodRefMeal.Location = new System.Drawing.Point(617, 239);
            this.btnFoodRefMeal.Name = "btnFoodRefMeal";
            this.btnFoodRefMeal.Size = new System.Drawing.Size(24, 24);
            this.btnFoodRefMeal.TabIndex = 147;
            this.btnFoodRefMeal.Text = "..";
            this.btnFoodRefMeal.UseVisualStyleBackColor = false;
            this.btnFoodRefMeal.Click += new System.EventHandler(this.btnFoodRefMeal_Click);
            // 
            // btnMealID
            // 
            this.btnMealID.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMealID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMealID.ForeColor = System.Drawing.Color.White;
            this.btnMealID.Location = new System.Drawing.Point(596, 239);
            this.btnMealID.Name = "btnMealID";
            this.btnMealID.Size = new System.Drawing.Size(19, 26);
            this.btnMealID.TabIndex = 146;
            this.btnMealID.Text = "+";
            this.btnMealID.UseVisualStyleBackColor = false;
            this.btnMealID.Click += new System.EventHandler(this.btnMealID_Click);
            // 
            // btnRefFoodMneu
            // 
            this.btnRefFoodMneu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRefFoodMneu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefFoodMneu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefFoodMneu.ForeColor = System.Drawing.Color.Black;
            this.btnRefFoodMneu.Location = new System.Drawing.Point(618, 269);
            this.btnRefFoodMneu.Name = "btnRefFoodMneu";
            this.btnRefFoodMneu.Size = new System.Drawing.Size(24, 24);
            this.btnRefFoodMneu.TabIndex = 149;
            this.btnRefFoodMneu.Text = "..";
            this.btnRefFoodMneu.UseVisualStyleBackColor = false;
            this.btnRefFoodMneu.Click += new System.EventHandler(this.btnRefFoodMneu_Click);
            // 
            // btnFoodMenu
            // 
            this.btnFoodMenu.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFoodMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodMenu.ForeColor = System.Drawing.Color.White;
            this.btnFoodMenu.Location = new System.Drawing.Point(597, 269);
            this.btnFoodMenu.Name = "btnFoodMenu";
            this.btnFoodMenu.Size = new System.Drawing.Size(19, 26);
            this.btnFoodMenu.TabIndex = 148;
            this.btnFoodMenu.Text = "+";
            this.btnFoodMenu.UseVisualStyleBackColor = false;
            this.btnFoodMenu.Click += new System.EventHandler(this.btnFoodMenu_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.Location = new System.Drawing.Point(596, 208);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(45, 26);
            this.btnshow.TabIndex = 150;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // frmWeeklySetmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(765, 686);
            this.isEnterTabAllow = true;
            this.Name = "frmWeeklySetmenu";
            this.Load += new System.EventHandler(this.frmWeeklySetmenu_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.ComboBox cbomealId;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.ComboBox cboWeeksetup;
        private AtiqsControlLibrary.SmartListViewDetails lvwWeekSetup;
        private AtiqsControlLibrary.SmartTextBox txtOldSetmenuID;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.ComboBox cboSetmenuTypeID;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.ComboBox cboMenuId;
        private AtiqsControlLibrary.SmartTextBox txtOldFoodMenuID;
        private AtiqsControlLibrary.SmartTextBox txtOldMealID;
        private AtiqsControlLibrary.SmartTextBox txtOldWdayNo;
        private System.Windows.Forms.Button btnRefFoodMneu;
        private System.Windows.Forms.Button btnFoodMenu;
        private System.Windows.Forms.Button btnFoodRefMeal;
        private System.Windows.Forms.Button btnMealID;
        private System.Windows.Forms.Button btnTypeRefresh;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnshow;

    }
}
