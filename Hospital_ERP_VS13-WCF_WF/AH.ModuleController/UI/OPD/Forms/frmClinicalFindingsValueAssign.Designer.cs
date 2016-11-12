namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmClinicalFindingsValueAssign
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCFTree = new System.Windows.Forms.Button();
            this.dgvCFValues = new AtiqsControlLibrary.SmartDataGridView();
            this.btnCFValues = new System.Windows.Forms.Button();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtCFID = new AtiqsControlLibrary.SmartTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboFindingsValues = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.btnCFValueAdd = new System.Windows.Forms.Button();
            this.btnCFValueAssignRefresh = new System.Windows.Forms.Button();
            this.treeClinicalFindingsTree = new AH.ModuleController.TreeViewControl(this.components);
            this.txtCFTitle = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCFValues)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(205, 9);
            this.frmLabel.Size = new System.Drawing.Size(359, 33);
            this.frmLabel.Text = "Clinical Findings Value Assign";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Controls.Add(this.txtCFTitle);
            this.pnlMain.Controls.Add(this.btnCFValueAssignRefresh);
            this.pnlMain.Controls.Add(this.btnCFValueAdd);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.cboFindingsValues);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.btnCFValues);
            this.pnlMain.Controls.Add(this.dgvCFValues);
            this.pnlMain.Controls.Add(this.btnCFTree);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtCFID);
            this.pnlMain.Controls.Add(this.treeClinicalFindingsTree);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(734, 650);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(734, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(42, 728);
            this.btnEdit.Size = new System.Drawing.Size(16, 12);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(507, 711);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 729);
            this.btnDelete.Size = new System.Drawing.Size(16, 12);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(396, 711);
            this.btnNew.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(619, 711);
            this.btnClose.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(20, 729);
            this.btnPrint.Size = new System.Drawing.Size(16, 12);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 750);
            this.groupBox1.Size = new System.Drawing.Size(734, 25);
            // 
            // btnCFTree
            // 
            this.btnCFTree.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCFTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFTree.Location = new System.Drawing.Point(0, -1);
            this.btnCFTree.Name = "btnCFTree";
            this.btnCFTree.Size = new System.Drawing.Size(434, 28);
            this.btnCFTree.TabIndex = 1;
            this.btnCFTree.Text = "Clinical Findings Tree";
            this.btnCFTree.UseVisualStyleBackColor = false;
            this.btnCFTree.Click += new System.EventHandler(this.btnCFTree_Click);
            // 
            // dgvCFValues
            // 
            this.dgvCFValues.AllowUserToAddRows = false;
            this.dgvCFValues.AllowUserToDeleteRows = false;
            this.dgvCFValues.AllowUserToOrderColumns = true;
            this.dgvCFValues.AllowUserToResizeColumns = false;
            this.dgvCFValues.AllowUserToResizeRows = false;
            this.dgvCFValues.BackgroundColor = System.Drawing.Color.White;
            this.dgvCFValues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCFValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCFValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCFValues.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCFValues.Location = new System.Drawing.Point(440, 170);
            this.dgvCFValues.MultiSelect = false;
            this.dgvCFValues.Name = "dgvCFValues";
            this.dgvCFValues.ReadOnly = true;
            this.dgvCFValues.RowHeadersVisible = false;
            this.dgvCFValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCFValues.Size = new System.Drawing.Size(289, 477);
            this.dgvCFValues.TabIndex = 3;
            // 
            // btnCFValues
            // 
            this.btnCFValues.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCFValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFValues.Location = new System.Drawing.Point(438, -1);
            this.btnCFValues.Name = "btnCFValues";
            this.btnCFValues.Size = new System.Drawing.Size(294, 28);
            this.btnCFValues.TabIndex = 119;
            this.btnCFValues.Text = "Value Assign";
            this.btnCFValues.UseVisualStyleBackColor = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.ForeColor = System.Drawing.Color.Purple;
            this.smartLabel1.Location = new System.Drawing.Point(441, 32);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(122, 16);
            this.smartLabel1.TabIndex = 121;
            this.smartLabel1.Text = "Clinical Finding :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.ForeColor = System.Drawing.Color.Purple;
            this.smartLabel2.Location = new System.Drawing.Point(444, 137);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(186, 16);
            this.smartLabel2.TabIndex = 122;
            this.smartLabel2.Text = "Clinical Findings Values  :";
            // 
            // txtCFID
            // 
            this.txtCFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCFID.Location = new System.Drawing.Point(639, 28);
            this.txtCFID.Name = "txtCFID";
            this.txtCFID.Size = new System.Drawing.Size(32, 24);
            this.txtCFID.TabIndex = 121;
            this.txtCFID.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.Location = new System.Drawing.Point(433, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 650);
            this.panel3.TabIndex = 243;
            // 
            // cboFindingsValues
            // 
            this.cboFindingsValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFindingsValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFindingsValues.ForeColor = System.Drawing.Color.Blue;
            this.cboFindingsValues.FormattingEnabled = true;
            this.cboFindingsValues.Location = new System.Drawing.Point(440, 100);
            this.cboFindingsValues.Name = "cboFindingsValues";
            this.cboFindingsValues.Size = new System.Drawing.Size(289, 26);
            this.cboFindingsValues.TabIndex = 2;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.ForeColor = System.Drawing.Color.Purple;
            this.smartLabel3.Location = new System.Drawing.Point(444, 79);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(137, 16);
            this.smartLabel3.TabIndex = 248;
            this.smartLabel3.Text = "Assigned Values  :";
            // 
            // btnCFValueAdd
            // 
            this.btnCFValueAdd.BackColor = System.Drawing.Color.Navy;
            this.btnCFValueAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCFValueAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFValueAdd.ForeColor = System.Drawing.Color.White;
            this.btnCFValueAdd.Location = new System.Drawing.Point(647, 128);
            this.btnCFValueAdd.Name = "btnCFValueAdd";
            this.btnCFValueAdd.Size = new System.Drawing.Size(40, 38);
            this.btnCFValueAdd.TabIndex = 274;
            this.btnCFValueAdd.Text = "+";
            this.btnCFValueAdd.UseVisualStyleBackColor = false;
            this.btnCFValueAdd.Click += new System.EventHandler(this.btnCFValueAdd_Click);
            // 
            // btnCFValueAssignRefresh
            // 
            this.btnCFValueAssignRefresh.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCFValueAssignRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCFValueAssignRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnCFValueAssignRefresh.ForeColor = System.Drawing.Color.White;
            this.btnCFValueAssignRefresh.Location = new System.Drawing.Point(688, 128);
            this.btnCFValueAssignRefresh.Name = "btnCFValueAssignRefresh";
            this.btnCFValueAssignRefresh.Size = new System.Drawing.Size(40, 38);
            this.btnCFValueAssignRefresh.TabIndex = 275;
            this.btnCFValueAssignRefresh.Text = "...";
            this.btnCFValueAssignRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCFValueAssignRefresh.UseVisualStyleBackColor = false;
            this.btnCFValueAssignRefresh.Click += new System.EventHandler(this.btnCFValueAssignRefresh_Click);
            // 
            // treeClinicalFindingsTree
            // 
            this.treeClinicalFindingsTree.AutoBuildTree = true;
            this.treeClinicalFindingsTree.BackColor = System.Drawing.Color.Lavender;
            this.treeClinicalFindingsTree.DataSource = null;
            this.treeClinicalFindingsTree.DisplayMember = null;
            this.treeClinicalFindingsTree.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.treeClinicalFindingsTree.Location = new System.Drawing.Point(0, 26);
            this.treeClinicalFindingsTree.Name = "treeClinicalFindingsTree";
            this.treeClinicalFindingsTree.Size = new System.Drawing.Size(434, 622);
            this.treeClinicalFindingsTree.TabIndex = 245;
            this.treeClinicalFindingsTree.ValueMember = null;
            this.treeClinicalFindingsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeClinicalFindingsTree_AfterSelect);
            // 
            // txtCFTitle
            // 
            this.txtCFTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtCFTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCFTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCFTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCFTitle.Location = new System.Drawing.Point(440, 52);
            this.txtCFTitle.Name = "txtCFTitle";
            this.txtCFTitle.ReadOnly = true;
            this.txtCFTitle.Size = new System.Drawing.Size(289, 24);
            this.txtCFTitle.TabIndex = 276;
            this.txtCFTitle.TabStop = false;
            // 
            // frmClinicalFindingsValueAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 775);
            this.isEnterTabAllow = true;
            this.Name = "frmClinicalFindingsValueAssign";
            this.Load += new System.EventHandler(this.frmClinicalFindingsValueAssign_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCFValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCFTree;
 
        private System.Windows.Forms.Button btnCFValues;
        private AtiqsControlLibrary.SmartDataGridView dgvCFValues;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtCFID;
        private System.Windows.Forms.Panel panel3;
        private TreeViewControl treeClinicalFindingsTree;
        private AtiqsControlLibrary.SmartComboBox cboFindingsValues;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private System.Windows.Forms.Button btnCFValueAdd;
        private System.Windows.Forms.Button btnCFValueAssignRefresh;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCFTitle;
    }
}