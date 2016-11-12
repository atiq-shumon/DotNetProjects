namespace AH.ModuleController.UI.ACCMS.Forms
{
    partial class frmCostCenter
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
            this.txtCostcenterName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtPurposeID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.lvPurpose = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtAccCode = new AtiqsControlLibrary.SmartTextBox();
            this.lstLedger = new System.Windows.Forms.ListBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.txtCodeAllo = new System.Windows.Forms.TextBox();
            this.btnTreeView = new System.Windows.Forms.Button();
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(306, 10);
            this.frmLabel.Size = new System.Drawing.Size(229, 33);
            this.frmLabel.TabIndex = 6;
            this.frmLabel.Text = "Cost Center Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.cboDepartmentGroup);
            this.pnlMain.Controls.Add(this.txtCodeAllo);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.lstLedger);
            this.pnlMain.Controls.Add(this.txtAccCode);
            this.pnlMain.Controls.Add(this.lvPurpose);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtPurposeNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtCostcenterName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtPurposeID);
            this.pnlMain.Location = new System.Drawing.Point(1, 66);
            this.pnlMain.Size = new System.Drawing.Size(863, 520);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(865, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(523, 594);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(410, 594);
            this.btnSave.TabIndex = 1;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(636, 594);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(297, 594);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(748, 594);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 596);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 637);
            this.groupBox1.Size = new System.Drawing.Size(865, 25);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(35, 2);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(156, 18);
            this.smartLabel3.TabIndex = 11;
            this.smartLabel3.Text = "Purpose Name (Bangla) :";
            this.smartLabel3.Visible = false;
            // 
            // txtPurposeNameBeng
            // 
            this.txtPurposeNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurposeNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurposeNameBeng.Location = new System.Drawing.Point(6, -1);
            this.txtPurposeNameBeng.Name = "txtPurposeNameBeng";
            this.txtPurposeNameBeng.Size = new System.Drawing.Size(192, 24);
            this.txtPurposeNameBeng.TabIndex = 8;
            this.txtPurposeNameBeng.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(239, 98);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(80, 18);
            this.smartLabel2.TabIndex = 10;
            this.smartLabel2.Text = "Unit Name :";
            // 
            // txtCostcenterName
            // 
            this.txtCostcenterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostcenterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostcenterName.Location = new System.Drawing.Point(328, 96);
            this.txtCostcenterName.Name = "txtCostcenterName";
            this.txtCostcenterName.Size = new System.Drawing.Size(413, 24);
            this.txtCostcenterName.TabIndex = 0;
            this.txtCostcenterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostcenterName_KeyPress);
            this.txtCostcenterName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCostcenterName_KeyUp);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(244, 7);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(77, 18);
            this.smartLabel1.TabIndex = 8;
            this.smartLabel1.Text = "Dep. Type :";
            // 
            // txtPurposeID
            // 
            this.txtPurposeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurposeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurposeID.Location = new System.Drawing.Point(329, 5);
            this.txtPurposeID.Name = "txtPurposeID";
            this.txtPurposeID.Size = new System.Drawing.Size(112, 24);
            this.txtPurposeID.TabIndex = 6;
            this.txtPurposeID.Visible = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(224, 129);
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
            this.lvPurpose.Location = new System.Drawing.Point(10, 172);
            this.lvPurpose.Name = "lvPurpose";
            this.lvPurpose.Size = new System.Drawing.Size(839, 334);
            this.lvPurpose.TabIndex = 3;
            this.lvPurpose.UseCompatibleStateImageBehavior = false;
            this.lvPurpose.View = System.Windows.Forms.View.Details;
            this.lvPurpose.SelectedIndexChanged += new System.EventHandler(this.lvPurpose_SelectedIndexChanged);
            // 
            // txtAccCode
            // 
            this.txtAccCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccCode.Location = new System.Drawing.Point(328, 127);
            this.txtAccCode.Name = "txtAccCode";
            this.txtAccCode.Size = new System.Drawing.Size(413, 24);
            this.txtAccCode.TabIndex = 1;
            this.txtAccCode.TextChanged += new System.EventHandler(this.txtAccCode_TextChanged);
            this.txtAccCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccCode_KeyDown);
            this.txtAccCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccCode_KeyPress);
            // 
            // lstLedger
            // 
            this.lstLedger.BackColor = System.Drawing.SystemColors.Info;
            this.lstLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLedger.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLedger.FormattingEnabled = true;
            this.lstLedger.ItemHeight = 16;
            this.lstLedger.Location = new System.Drawing.Point(326, 162);
            this.lstLedger.Name = "lstLedger";
            this.lstLedger.Size = new System.Drawing.Size(459, 178);
            this.lstLedger.TabIndex = 141;
            this.lstLedger.Visible = false;
            this.lstLedger.DoubleClick += new System.EventHandler(this.lstLedger_DoubleClick);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(191, 68);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(130, 18);
            this.smartLabel5.TabIndex = 142;
            this.smartLabel5.Text = "Department  Name :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(328, 65);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(413, 26);
            this.cboDepartment.TabIndex = 143;
            this.cboDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbocostcategoryName_KeyPress);
            // 
            // txtCodeAllo
            // 
            this.txtCodeAllo.Location = new System.Drawing.Point(10, 102);
            this.txtCodeAllo.Name = "txtCodeAllo";
            this.txtCodeAllo.Size = new System.Drawing.Size(100, 20);
            this.txtCodeAllo.TabIndex = 145;
            this.txtCodeAllo.Visible = false;
            // 
            // btnTreeView
            // 
            this.btnTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnTreeView.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeView.Location = new System.Drawing.Point(206, 595);
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Size = new System.Drawing.Size(87, 40);
            this.btnTreeView.TabIndex = 15;
            this.btnTreeView.Text = "Tree View";
            this.btnTreeView.UseVisualStyleBackColor = false;
            this.btnTreeView.Click += new System.EventHandler(this.btnTreeView_Click);
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(328, 35);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(413, 26);
            this.cboDepartmentGroup.TabIndex = 146;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            this.cboDepartmentGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDepartmentGroup_KeyPress);
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(228, 38);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(93, 18);
            this.smartLabel6.TabIndex = 147;
            this.smartLabel6.Text = "Group Name :";
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(328, 6);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(413, 26);
            this.cboDepartmentType.TabIndex = 148;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // frmCostCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(865, 662);
            this.Controls.Add(this.btnTreeView);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmCostCenter";
            this.Load += new System.EventHandler(this.frmPurposeSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnTreeView, 0);
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
        private AtiqsControlLibrary.SmartTextBox txtCostcenterName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtPurposeID;
        private AtiqsControlLibrary.SmartListViewDetails lvPurpose;
        private AtiqsControlLibrary.SmartTextBox txtAccCode;
        private System.Windows.Forms.ListBox lstLedger;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.TextBox txtCodeAllo;
        private System.Windows.Forms.Button btnTreeView;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
    }
}