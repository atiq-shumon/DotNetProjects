namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmGroupConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroupConfig));
            this.txtGroupName = new AtiqsControlLibrary.SmartTextBox();
            this.cboNature = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.cboCashFlowType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvwGroupList = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtSlNo = new AtiqsControlLibrary.SmartTextBox();
            this.ChkPrimary = new System.Windows.Forms.CheckBox();
            this.cboUnder = new System.Windows.Forms.ComboBox();
            this.btnTreeView = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpSerach = new System.Windows.Forms.GroupBox();
            this.lstLedger = new System.Windows.Forms.ListBox();
            this.txtLedger = new AtiqsControlLibrary.SmartTextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.chkEdit = new AtiqsControlLibrary.SmartCheckBox();
            this.lblUnder = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.grpSerach.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(256, 33);
            this.frmLabel.TabIndex = 10;
            this.frmLabel.Text = "Group Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblUnder);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.lvwGroupList);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.grpSerach);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.cboUnder);
            this.pnlMain.Controls.Add(this.ChkPrimary);
            this.pnlMain.Controls.Add(this.txtSlNo);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboCashFlowType);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboNature);
            this.pnlMain.Controls.Add(this.txtGroupName);
            this.pnlMain.Location = new System.Drawing.Point(-2, 59);
            this.pnlMain.Size = new System.Drawing.Size(869, 96);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(867, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(516, 167);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(402, 167);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(630, 167);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(288, 167);
            this.btnNew.TabIndex = 6;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(744, 167);
            this.btnClose.TabIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(176, 167);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 216);
            this.groupBox1.Size = new System.Drawing.Size(867, 25);
            // 
            // txtGroupName
            // 
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Location = new System.Drawing.Point(334, 57);
            this.txtGroupName.MaxLength = 100;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(317, 24);
            this.txtGroupName.TabIndex = 0;
            this.txtGroupName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGroupName_KeyPress);
            this.txtGroupName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGroupName_KeyUp);
            // 
            // cboNature
            // 
            this.cboNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNature.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNature.ForeColor = System.Drawing.Color.Blue;
            this.cboNature.FormattingEnabled = true;
            this.cboNature.Items.AddRange(new object[] {
            "Assets",
            "Liabilities",
            "Income",
            "Expenses"});
            this.cboNature.Location = new System.Drawing.Point(834, 116);
            this.cboNature.Name = "cboNature";
            this.cboNature.Size = new System.Drawing.Size(317, 26);
            this.cboNature.TabIndex = 2;
            this.cboNature.Visible = false;
            this.cboNature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNature_KeyPress);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(264, 59);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(60, 20);
            this.smartLabel1.TabIndex = 6;
            this.smartLabel1.Text = "Name:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(776, 65);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(63, 20);
            this.smartLabel2.TabIndex = 7;
            this.smartLabel2.Text = "Under:";
            this.smartLabel2.Visible = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(756, 122);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(68, 20);
            this.smartLabel3.TabIndex = 8;
            this.smartLabel3.Text = "Nature:";
            this.smartLabel3.Visible = false;
            // 
            // cboCashFlowType
            // 
            this.cboCashFlowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCashFlowType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCashFlowType.ForeColor = System.Drawing.Color.Blue;
            this.cboCashFlowType.FormattingEnabled = true;
            this.cboCashFlowType.Items.AddRange(new object[] {
            "End of List",
            "Operating Activities",
            "Investing Activities",
            "Financing Activities"});
            this.cboCashFlowType.Location = new System.Drawing.Point(834, 147);
            this.cboCashFlowType.Name = "cboCashFlowType";
            this.cboCashFlowType.Size = new System.Drawing.Size(317, 26);
            this.cboCashFlowType.TabIndex = 3;
            this.cboCashFlowType.Visible = false;
            this.cboCashFlowType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCashFlowType_KeyPress);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(684, 154);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(140, 20);
            this.smartLabel4.TabIndex = 16;
            this.smartLabel4.Text = "Cash Flow Type:";
            this.smartLabel4.Visible = false;
            // 
            // lvwGroupList
            // 
            this.lvwGroupList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwGroupList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwGroupList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwGroupList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwGroupList.FullRowSelect = true;
            this.lvwGroupList.GridLines = true;
            this.lvwGroupList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwGroupList.Location = new System.Drawing.Point(9, 126);
            this.lvwGroupList.Name = "lvwGroupList";
            this.lvwGroupList.Size = new System.Drawing.Size(836, 326);
            this.lvwGroupList.TabIndex = 14;
            this.lvwGroupList.UseCompatibleStateImageBehavior = false;
            this.lvwGroupList.View = System.Windows.Forms.View.Details;
            this.lvwGroupList.SelectedIndexChanged += new System.EventHandler(this.lvwGroupList_SelectedIndexChanged);
            // 
            // txtSlNo
            // 
            this.txtSlNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlNo.Location = new System.Drawing.Point(14, 19);
            this.txtSlNo.Name = "txtSlNo";
            this.txtSlNo.Size = new System.Drawing.Size(100, 24);
            this.txtSlNo.TabIndex = 4;
            this.txtSlNo.Visible = false;
            // 
            // ChkPrimary
            // 
            this.ChkPrimary.AutoSize = true;
            this.ChkPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkPrimary.Location = new System.Drawing.Point(28, 56);
            this.ChkPrimary.Name = "ChkPrimary";
            this.ChkPrimary.Size = new System.Drawing.Size(84, 24);
            this.ChkPrimary.TabIndex = 17;
            this.ChkPrimary.Text = "Primary";
            this.ChkPrimary.UseVisualStyleBackColor = true;
            this.ChkPrimary.CheckedChanged += new System.EventHandler(this.ChkPrimary_CheckedChanged);
            // 
            // cboUnder
            // 
            this.cboUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnder.FormattingEnabled = true;
            this.cboUnder.Location = new System.Drawing.Point(900, 85);
            this.cboUnder.Name = "cboUnder";
            this.cboUnder.Size = new System.Drawing.Size(321, 26);
            this.cboUnder.TabIndex = 1;
            this.cboUnder.Visible = false;
            this.cboUnder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboUnder_KeyDown);
            this.cboUnder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUnder_KeyPress);
            // 
            // btnTreeView
            // 
            this.btnTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeView.ForeColor = System.Drawing.Color.Navy;
            this.btnTreeView.Location = new System.Drawing.Point(65, 167);
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Size = new System.Drawing.Size(108, 39);
            this.btnTreeView.TabIndex = 19;
            this.btnTreeView.Text = "TreeView";
            this.btnTreeView.UseVisualStyleBackColor = false;
            this.btnTreeView.Visible = false;
            this.btnTreeView.Click += new System.EventHandler(this.btnTreeView_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(676, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 26);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpSerach
            // 
            this.grpSerach.BackColor = System.Drawing.Color.Transparent;
            this.grpSerach.Controls.Add(this.lstLedger);
            this.grpSerach.Controls.Add(this.txtLedger);
            this.grpSerach.Controls.Add(this.lblClose);
            this.grpSerach.Location = new System.Drawing.Point(818, 34);
            this.grpSerach.Name = "grpSerach";
            this.grpSerach.Size = new System.Drawing.Size(16, 35);
            this.grpSerach.TabIndex = 137;
            this.grpSerach.TabStop = false;
            this.grpSerach.Visible = false;
            // 
            // lstLedger
            // 
            this.lstLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLedger.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLedger.FormattingEnabled = true;
            this.lstLedger.ItemHeight = 16;
            this.lstLedger.Location = new System.Drawing.Point(10, 46);
            this.lstLedger.Name = "lstLedger";
            this.lstLedger.Size = new System.Drawing.Size(501, 82);
            this.lstLedger.TabIndex = 50;
            this.lstLedger.Visible = false;
            this.lstLedger.DoubleClick += new System.EventHandler(this.lstLedger_DoubleClick);
            // 
            // txtLedger
            // 
            this.txtLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLedger.Location = new System.Drawing.Point(7, 19);
            this.txtLedger.Name = "txtLedger";
            this.txtLedger.Size = new System.Drawing.Size(502, 24);
            this.txtLedger.TabIndex = 48;
            this.txtLedger.TextChanged += new System.EventHandler(this.txtLedger_TextChanged);
            this.txtLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedger_KeyDown);
            this.txtLedger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLedger_KeyPress);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(514, 21);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 18);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(679, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 138;
            this.label1.Text = "Ctrl+F for Search";
            this.label1.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(106, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 24);
            this.txtSearch.TabIndex = 139;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(24, 97);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(75, 18);
            this.smartLabel5.TabIndex = 140;
            this.smartLabel5.Text = "Serach:";
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.BackColor = System.Drawing.Color.White;
            this.chkEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEdit.ForeColor = System.Drawing.Color.Black;
            this.chkEdit.Location = new System.Drawing.Point(29, 79);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(113, 22);
            this.chkEdit.TabIndex = 20;
            this.chkEdit.Text = "View Window";
            this.chkEdit.UseVisualStyleBackColor = false;
            this.chkEdit.Visible = false;
            this.chkEdit.CheckedChanged += new System.EventHandler(this.chkEdit_CheckedChanged);
            // 
            // lblUnder
            // 
            this.lblUnder.AutoSize = true;
            this.lblUnder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUnder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUnder.ForeColor = System.Drawing.Color.Red;
            this.lblUnder.Location = new System.Drawing.Point(289, 8);
            this.lblUnder.Name = "lblUnder";
            this.lblUnder.Size = new System.Drawing.Size(0, 16);
            this.lblUnder.TabIndex = 141;
            // 
            // frmGroupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(867, 241);
            this.Controls.Add(this.chkEdit);
            this.Controls.Add(this.btnTreeView);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmGroupConfig";
            this.Load += new System.EventHandler(this.frmGroupConfig_Load);
            this.Controls.SetChildIndex(this.btnTreeView, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.chkEdit, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpSerach.ResumeLayout(false);
            this.grpSerach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtGroupName;
        private AtiqsControlLibrary.SmartComboBox cboNature;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboCashFlowType;
        private AtiqsControlLibrary.SmartListViewDetails lvwGroupList;
        private AtiqsControlLibrary.SmartTextBox txtSlNo;
        private System.Windows.Forms.CheckBox ChkPrimary;
        private System.Windows.Forms.ComboBox cboUnder;
        private System.Windows.Forms.Button btnTreeView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpSerach;
        private System.Windows.Forms.ListBox lstLedger;
        private AtiqsControlLibrary.SmartTextBox txtLedger;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtSearch;
        private AtiqsControlLibrary.SmartCheckBox chkEdit;
        private AtiqsControlLibrary.SmartLabel lblUnder;
    }
}
