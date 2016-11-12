namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmDeptUnitWiseReqAdvanceSearch
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
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel8 = new AtiqsControlLibrary.SmartLabel();
            this.treeviewItemIssue = new AtiqsControlLibrary.SmartTreeView();
            this.grpTree = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.grpTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(11, 3);
            this.frmLabel.Size = new System.Drawing.Size(352, 33);
            this.frmLabel.Text = "Advance Search(Requisition)";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.dtToDate);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.dtFromDate);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.grpTree);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel8);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Location = new System.Drawing.Point(0, 59);
            this.pnlMain.Size = new System.Drawing.Size(365, 589);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(365, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(98, 650);
            this.btnEdit.Size = new System.Drawing.Size(36, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(70, 650);
            this.btnSave.Size = new System.Drawing.Size(26, 39);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(140, 650);
            this.btnDelete.Size = new System.Drawing.Size(36, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 650);
            this.btnNew.Size = new System.Drawing.Size(49, 39);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(252, 654);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(182, 650);
            this.btnPrint.Size = new System.Drawing.Size(31, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 696);
            this.groupBox1.Size = new System.Drawing.Size(365, 25);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(95, 7);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(245, 26);
            this.cboDepartment.TabIndex = 156;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(11, 13);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(74, 15);
            this.smartLabel4.TabIndex = 157;
            this.smartLabel4.Text = "Department ";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(95, 38);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(245, 26);
            this.cboUnit.TabIndex = 294;
            // 
            // smartLabel8
            // 
            this.smartLabel8.AutoSize = true;
            this.smartLabel8.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel8.Location = new System.Drawing.Point(11, 44);
            this.smartLabel8.Name = "smartLabel8";
            this.smartLabel8.Size = new System.Drawing.Size(33, 15);
            this.smartLabel8.TabIndex = 295;
            this.smartLabel8.Text = "Unit ";
            // 
            // treeviewItemIssue
            // 
            this.treeviewItemIssue.BackColor = System.Drawing.Color.LightYellow;
            this.treeviewItemIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeviewItemIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeviewItemIssue.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeviewItemIssue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeviewItemIssue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.treeviewItemIssue.LineColor = System.Drawing.Color.Crimson;
            this.treeviewItemIssue.Location = new System.Drawing.Point(6, 21);
            this.treeviewItemIssue.Name = "treeviewItemIssue";
            this.treeviewItemIssue.Size = new System.Drawing.Size(239, 445);
            this.treeviewItemIssue.TabIndex = 220;
            // 
            // grpTree
            // 
            this.grpTree.Controls.Add(this.treeviewItemIssue);
            this.grpTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTree.ForeColor = System.Drawing.Color.Green;
            this.grpTree.Location = new System.Drawing.Point(14, 111);
            this.grpTree.Name = "grpTree";
            this.grpTree.Size = new System.Drawing.Size(254, 473);
            this.grpTree.TabIndex = 296;
            this.grpTree.TabStop = false;
            this.grpTree.Text = "Pending Requisition";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Wheat;
            this.btnSearch.Location = new System.Drawing.Point(199, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 297;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(108, 69);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(53, 13);
            this.smartLabel3.TabIndex = 301;
            this.smartLabel3.Text = "To Date";
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(106, 87);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(87, 20);
            this.dtToDate.TabIndex = 300;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(15, 69);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(65, 13);
            this.smartLabel2.TabIndex = 299;
            this.smartLabel2.Text = "From Date";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(13, 87);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(87, 20);
            this.dtFromDate.TabIndex = 298;
            // 
            // frmDeptUnitWiseReqAdvanceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(365, 721);
            this.isEnterTabAllow = true;
            this.Name = "frmDeptUnitWiseReqAdvanceSearch";
            this.Load += new System.EventHandler(this.frmDeptUnitWiseReqAdvanceSearch_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel8;
        private System.Windows.Forms.GroupBox grpTree;
        private AtiqsControlLibrary.SmartTreeView treeviewItemIssue;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.DateTimePicker dtFromDate;
    }
}
