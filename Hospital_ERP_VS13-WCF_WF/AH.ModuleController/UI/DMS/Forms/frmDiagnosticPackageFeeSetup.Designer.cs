namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmDiagnosticPackageFeeSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefreshPkg = new System.Windows.Forms.Button();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboDiagPkg = new AtiqsControlLibrary.SmartComboBox();
            this.dgvUnassignedTest = new AtiqsControlLibrary.SmartDataGridView();
            this.dgvAssignedTest = new AtiqsControlLibrary.SmartDataGridView();
            this.txtSearchTest = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPackageAmountSummary = new System.Windows.Forms.Label();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.lblTestAmountSummary = new System.Windows.Forms.Label();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnassignedTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedTest)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(407, 9);
            this.frmLabel.Size = new System.Drawing.Size(507, 33);
            this.frmLabel.Text = "Diagnostic Test Fee Setup Under Package";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.lblPackageAmountSummary);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtSearchTest);
            this.pnlMain.Controls.Add(this.dgvAssignedTest);
            this.pnlMain.Controls.Add(this.dgvUnassignedTest);
            this.pnlMain.Controls.Add(this.btnRefreshPkg);
            this.pnlMain.Controls.Add(this.btnAddPkg);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboDiagPkg);
            this.pnlMain.Size = new System.Drawing.Size(1352, 906);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1352, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 825);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1124, 825);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 825);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1011, 825);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1238, 825);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(231, 825);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 864);
            this.groupBox1.Size = new System.Drawing.Size(1352, 25);
            // 
            // btnRefreshPkg
            // 
            this.btnRefreshPkg.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshPkg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshPkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPkg.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPkg.Location = new System.Drawing.Point(998, 167);
            this.btnRefreshPkg.Name = "btnRefreshPkg";
            this.btnRefreshPkg.Size = new System.Drawing.Size(30, 28);
            this.btnRefreshPkg.TabIndex = 100;
            this.btnRefreshPkg.TabStop = false;
            this.btnRefreshPkg.Text = "..";
            this.btnRefreshPkg.UseVisualStyleBackColor = false;
            this.btnRefreshPkg.Click += new System.EventHandler(this.btnRefreshPkg_Click);
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPkg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPkg.ForeColor = System.Drawing.Color.White;
            this.btnAddPkg.Location = new System.Drawing.Point(962, 167);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(32, 28);
            this.btnAddPkg.TabIndex = 99;
            this.btnAddPkg.TabStop = false;
            this.btnAddPkg.Text = "+";
            this.btnAddPkg.UseVisualStyleBackColor = false;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(1032, 167);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(61, 28);
            this.btnShow.TabIndex = 98;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(534, 149);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(101, 13);
            this.smartLabel2.TabIndex = 97;
            this.smartLabel2.Text = "Package Name :";
            // 
            // cboDiagPkg
            // 
            this.cboDiagPkg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiagPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiagPkg.ForeColor = System.Drawing.Color.Blue;
            this.cboDiagPkg.FormattingEnabled = true;
            this.cboDiagPkg.Location = new System.Drawing.Point(536, 167);
            this.cboDiagPkg.Name = "cboDiagPkg";
            this.cboDiagPkg.Size = new System.Drawing.Size(423, 26);
            this.cboDiagPkg.TabIndex = 96;
            this.cboDiagPkg.SelectedIndexChanged += new System.EventHandler(this.cboDiagPkg_SelectedIndexChanged);
            // 
            // dgvUnassignedTest
            // 
            this.dgvUnassignedTest.AllowUserToAddRows = false;
            this.dgvUnassignedTest.AllowUserToDeleteRows = false;
            this.dgvUnassignedTest.AllowUserToOrderColumns = true;
            this.dgvUnassignedTest.AllowUserToResizeColumns = false;
            this.dgvUnassignedTest.AllowUserToResizeRows = false;
            this.dgvUnassignedTest.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnassignedTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUnassignedTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUnassignedTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnassignedTest.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUnassignedTest.Location = new System.Drawing.Point(1, 205);
            this.dgvUnassignedTest.MultiSelect = false;
            this.dgvUnassignedTest.Name = "dgvUnassignedTest";
            this.dgvUnassignedTest.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvUnassignedTest.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUnassignedTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnassignedTest.Size = new System.Drawing.Size(489, 696);
            this.dgvUnassignedTest.TabIndex = 184;
            // 
            // dgvAssignedTest
            // 
            this.dgvAssignedTest.AllowUserToAddRows = false;
            this.dgvAssignedTest.AllowUserToDeleteRows = false;
            this.dgvAssignedTest.AllowUserToOrderColumns = true;
            this.dgvAssignedTest.AllowUserToResizeColumns = false;
            this.dgvAssignedTest.AllowUserToResizeRows = false;
            this.dgvAssignedTest.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignedTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAssignedTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignedTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignedTest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignedTest.Location = new System.Drawing.Point(536, 205);
            this.dgvAssignedTest.MultiSelect = false;
            this.dgvAssignedTest.Name = "dgvAssignedTest";
            this.dgvAssignedTest.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvAssignedTest.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAssignedTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedTest.Size = new System.Drawing.Size(815, 696);
            this.dgvAssignedTest.TabIndex = 185;
            this.dgvAssignedTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedTest_CellClick);
            this.dgvAssignedTest.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedTest_CellEndEdit);
            this.dgvAssignedTest.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAssignedTest_CellValidating);
            // 
            // txtSearchTest
            // 
            this.txtSearchTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTest.Location = new System.Drawing.Point(3, 167);
            this.txtSearchTest.Name = "txtSearchTest";
            this.txtSearchTest.Size = new System.Drawing.Size(460, 24);
            this.txtSearchTest.TabIndex = 186;
            this.txtSearchTest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchTest_KeyUp);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(3, 149);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(182, 13);
            this.smartLabel1.TabIndex = 187;
            this.smartLabel1.Text = "Search Test Name From Here :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(493, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 696);
            this.panel2.TabIndex = 188;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(2, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 28);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPackageAmountSummary
            // 
            this.lblPackageAmountSummary.AutoSize = true;
            this.lblPackageAmountSummary.BackColor = System.Drawing.Color.White;
            this.lblPackageAmountSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageAmountSummary.ForeColor = System.Drawing.Color.Red;
            this.lblPackageAmountSummary.Location = new System.Drawing.Point(1104, 169);
            this.lblPackageAmountSummary.Name = "lblPackageAmountSummary";
            this.lblPackageAmountSummary.Size = new System.Drawing.Size(174, 24);
            this.lblPackageAmountSummary.TabIndex = 189;
            this.lblPackageAmountSummary.Text = " Package Amount";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(1100, 149);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(90, 13);
            this.smartLabel3.TabIndex = 190;
            this.smartLabel3.Text = "Package Fee :";
            // 
            // lblTestAmountSummary
            // 
            this.lblTestAmountSummary.AutoSize = true;
            this.lblTestAmountSummary.BackColor = System.Drawing.Color.White;
            this.lblTestAmountSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestAmountSummary.ForeColor = System.Drawing.Color.Red;
            this.lblTestAmountSummary.Location = new System.Drawing.Point(873, 840);
            this.lblTestAmountSummary.Name = "lblTestAmountSummary";
            this.lblTestAmountSummary.Size = new System.Drawing.Size(118, 24);
            this.lblTestAmountSummary.TabIndex = 190;
            this.lblTestAmountSummary.Text = "                  ";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(869, 822);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(65, 13);
            this.smartLabel5.TabIndex = 192;
            this.smartLabel5.Text = "Test Fee :";
            // 
            // frmDiagnosticPackageFeeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1352, 889);
            this.Controls.Add(this.smartLabel5);
            this.Controls.Add(this.lblTestAmountSummary);
            this.isEnterTabAllow = true;
            this.Name = "frmDiagnosticPackageFeeSetup";
            this.Load += new System.EventHandler(this.frmDiagnosticPackageFeeSetup_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.lblTestAmountSummary, 0);
            this.Controls.SetChildIndex(this.smartLabel5, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnassignedTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedTest)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshPkg;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboDiagPkg;
        private AtiqsControlLibrary.SmartDataGridView dgvUnassignedTest;
        private AtiqsControlLibrary.SmartDataGridView dgvAssignedTest;
        private AtiqsControlLibrary.SmartTextBox txtSearchTest;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPackageAmountSummary;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.Label lblTestAmountSummary;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
    }
}
