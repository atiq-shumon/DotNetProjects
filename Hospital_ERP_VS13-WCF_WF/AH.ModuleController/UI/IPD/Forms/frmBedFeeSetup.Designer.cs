namespace AH.ModuleController.UI.IPD.Forms
{
    partial class frmBedFeeSetup
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
            this.txtAmount = new AtiqsControlLibrary.SmartNumericTextBox();
            this.cboBedType = new AtiqsControlLibrary.SmartComboBox();
            this.cboRevenueHeadGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDeptID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboRevenueHead = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboBuilding = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvBedFee = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnShow = new System.Windows.Forms.Button();
            this.cboBedFacilityType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(322, 10);
            this.frmLabel.Size = new System.Drawing.Size(186, 33);
            this.frmLabel.Text = "Bed Fee Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboBedFacilityType);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.lvBedFee);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.cboBedType);
            this.pnlMain.Controls.Add(this.cboRevenueHeadGroup);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboRevenueHead);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Location = new System.Drawing.Point(0, 59);
            this.pnlMain.Size = new System.Drawing.Size(876, 490);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(876, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(427, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 555);
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(540, 555);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(201, 555);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(762, 555);
            this.btnClose.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(651, 555);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(876, 25);
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(659, 94);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(85, 24);
            this.txtAmount.TabIndex = 5;
            // 
            // cboBedType
            // 
            this.cboBedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBedType.ForeColor = System.Drawing.Color.Blue;
            this.cboBedType.FormattingEnabled = true;
            this.cboBedType.Location = new System.Drawing.Point(13, 29);
            this.cboBedType.Name = "cboBedType";
            this.cboBedType.Size = new System.Drawing.Size(285, 26);
            this.cboBedType.TabIndex = 0;
            this.cboBedType.SelectedIndexChanged += new System.EventHandler(this.cboBedType_SelectedIndexChanged);
            // 
            // cboRevenueHeadGroup
            // 
            this.cboRevenueHeadGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRevenueHeadGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRevenueHeadGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboRevenueHeadGroup.FormattingEnabled = true;
            this.cboRevenueHeadGroup.Location = new System.Drawing.Point(11, 94);
            this.cboRevenueHeadGroup.Name = "cboRevenueHeadGroup";
            this.cboRevenueHeadGroup.Size = new System.Drawing.Size(287, 26);
            this.cboRevenueHeadGroup.TabIndex = 3;
            this.cboRevenueHeadGroup.Click += new System.EventHandler(this.cboRevenueHeadGroup_Click);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(83, 555);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(87, 18);
            this.smartLabel7.TabIndex = 62;
            this.smartLabel7.Text = "Department :";
            this.smartLabel7.Visible = false;
            // 
            // cboDeptID
            // 
            this.cboDeptID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptID.ForeColor = System.Drawing.Color.Blue;
            this.cboDeptID.FormattingEnabled = true;
            this.cboDeptID.Location = new System.Drawing.Point(86, 572);
            this.cboDeptID.Name = "cboDeptID";
            this.cboDeptID.Size = new System.Drawing.Size(73, 26);
            this.cboDeptID.TabIndex = 1;
            this.cboDeptID.Visible = false;
            this.cboDeptID.SelectedIndexChanged += new System.EventHandler(this.cboDeptID_SelectedIndexChanged);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(308, 73);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(103, 18);
            this.smartLabel6.TabIndex = 61;
            this.smartLabel6.Text = "Revenue Head :";
            // 
            // cboRevenueHead
            // 
            this.cboRevenueHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRevenueHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRevenueHead.ForeColor = System.Drawing.Color.Blue;
            this.cboRevenueHead.FormattingEnabled = true;
            this.cboRevenueHead.Location = new System.Drawing.Point(304, 94);
            this.cboRevenueHead.Name = "cboRevenueHead";
            this.cboRevenueHead.Size = new System.Drawing.Size(349, 26);
            this.cboRevenueHead.TabIndex = 4;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(13, 73);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(145, 18);
            this.smartLabel2.TabIndex = 60;
            this.smartLabel2.Text = "Revenue Head Group :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(13, 5);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(72, 18);
            this.smartLabel1.TabIndex = 59;
            this.smartLabel1.Text = "Bed Type :";
            // 
            // cboBuilding
            // 
            this.cboBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuilding.ForeColor = System.Drawing.Color.Blue;
            this.cboBuilding.FormattingEnabled = true;
            this.cboBuilding.Location = new System.Drawing.Point(21, 572);
            this.cboBuilding.Name = "cboBuilding";
            this.cboBuilding.Size = new System.Drawing.Size(55, 26);
            this.cboBuilding.TabIndex = 0;
            this.cboBuilding.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(21, 551);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(66, 18);
            this.smartLabel3.TabIndex = 64;
            this.smartLabel3.Text = "Building :";
            this.smartLabel3.Visible = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(656, 73);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(63, 18);
            this.smartLabel4.TabIndex = 65;
            this.smartLabel4.Text = "Amount :";
            // 
            // lvBedFee
            // 
            this.lvBedFee.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvBedFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBedFee.CheckBoxes = true;
            this.lvBedFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvBedFee.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBedFee.FullRowSelect = true;
            this.lvBedFee.GridLines = true;
            this.lvBedFee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvBedFee.Location = new System.Drawing.Point(1, 153);
            this.lvBedFee.Name = "lvBedFee";
            this.lvBedFee.Size = new System.Drawing.Size(870, 332);
            this.lvBedFee.TabIndex = 68;
            this.lvBedFee.TabStop = false;
            this.lvBedFee.UseCompatibleStateImageBehavior = false;
            this.lvBedFee.View = System.Windows.Forms.View.Details;
            this.lvBedFee.SelectedIndexChanged += new System.EventHandler(this.lvBedFee_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(659, 27);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(85, 28);
            this.btnShow.TabIndex = 2;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cboBedFacilityType
            // 
            this.cboBedFacilityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBedFacilityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBedFacilityType.ForeColor = System.Drawing.Color.Blue;
            this.cboBedFacilityType.FormattingEnabled = true;
            this.cboBedFacilityType.Location = new System.Drawing.Point(304, 29);
            this.cboBedFacilityType.Name = "cboBedFacilityType";
            this.cboBedFacilityType.Size = new System.Drawing.Size(349, 26);
            this.cboBedFacilityType.TabIndex = 1;
            this.cboBedFacilityType.SelectedIndexChanged += new System.EventHandler(this.cboBedFacilityType_SelectedIndexChanged);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(306, 8);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(112, 18);
            this.smartLabel5.TabIndex = 79;
            this.smartLabel5.Text = "Bed Facility Type";
            // 
            // frmBedFeeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(876, 623);
            this.Controls.Add(this.cboBuilding);
            this.Controls.Add(this.smartLabel3);
            this.Controls.Add(this.smartLabel7);
            this.Controls.Add(this.cboDeptID);
            this.isEnterTabAllow = true;
            this.Name = "frmBedFeeSetup";
            this.Load += new System.EventHandler(this.frmBedFeeSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.cboDeptID, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.smartLabel7, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.smartLabel3, 0);
            this.Controls.SetChildIndex(this.cboBuilding, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartNumericTextBox txtAmount;
        private AtiqsControlLibrary.SmartComboBox cboBedType;
        private AtiqsControlLibrary.SmartComboBox cboRevenueHeadGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboDeptID;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboRevenueHead;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboBuilding;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartListViewDetails lvBedFee;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartComboBox cboBedFacilityType;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
    }
}
