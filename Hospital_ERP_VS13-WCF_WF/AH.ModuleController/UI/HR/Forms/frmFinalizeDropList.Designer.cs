namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmFinalizeDropList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFinalizeGrid = new AtiqsControlLibrary.SmartDataGridView();
            this.txtFinalizeBy = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel18 = new AtiqsControlLibrary.SmartLabel();
            this.txtFinalizeByName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.dgvCompletedGrid = new AtiqsControlLibrary.SmartDataGridView();
            this.gbComplete = new System.Windows.Forms.GroupBox();
            this.gbPending = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboDropType = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedGrid)).BeginInit();
            this.gbComplete.SuspendLayout();
            this.gbPending.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(599, 9);
            this.frmLabel.Size = new System.Drawing.Size(216, 33);
            this.frmLabel.Text = "Finalize Drop List";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboDropType);
            this.pnlMain.Controls.Add(this.gbPending);
            this.pnlMain.Controls.Add(this.gbComplete);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtFinalizeByName);
            this.pnlMain.Controls.Add(this.smartLabel18);
            this.pnlMain.Controls.Add(this.txtFinalizeBy);
            this.pnlMain.Size = new System.Drawing.Size(1427, 886);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1427, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1041, 805);
            this.btnEdit.Size = new System.Drawing.Size(37, 39);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1200, 805);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(954, 805);
            this.btnDelete.Size = new System.Drawing.Size(39, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1087, 805);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1314, 805);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(999, 805);
            this.btnPrint.Size = new System.Drawing.Size(36, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 844);
            this.groupBox1.Size = new System.Drawing.Size(1427, 25);
            // 
            // dgvFinalizeGrid
            // 
            this.dgvFinalizeGrid.AllowUserToAddRows = false;
            this.dgvFinalizeGrid.AllowUserToDeleteRows = false;
            this.dgvFinalizeGrid.AllowUserToOrderColumns = true;
            this.dgvFinalizeGrid.AllowUserToResizeColumns = false;
            this.dgvFinalizeGrid.AllowUserToResizeRows = false;
            this.dgvFinalizeGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinalizeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvFinalizeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFinalizeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinalizeGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFinalizeGrid.Location = new System.Drawing.Point(5, 27);
            this.dgvFinalizeGrid.MultiSelect = false;
            this.dgvFinalizeGrid.Name = "dgvFinalizeGrid";
            this.dgvFinalizeGrid.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvFinalizeGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFinalizeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinalizeGrid.Size = new System.Drawing.Size(683, 656);
            this.dgvFinalizeGrid.TabIndex = 207;
            this.dgvFinalizeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinalizeGrid_CellClick);
            // 
            // txtFinalizeBy
            // 
            this.txtFinalizeBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalizeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalizeBy.Location = new System.Drawing.Point(218, 168);
            this.txtFinalizeBy.MaxLength = 45;
            this.txtFinalizeBy.Name = "txtFinalizeBy";
            this.txtFinalizeBy.Size = new System.Drawing.Size(110, 24);
            this.txtFinalizeBy.TabIndex = 0;
            this.txtFinalizeBy.Leave += new System.EventHandler(this.txtFinalizeBy_Leave);
            // 
            // smartLabel18
            // 
            this.smartLabel18.AutoSize = true;
            this.smartLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel18.Location = new System.Drawing.Point(217, 148);
            this.smartLabel18.Name = "smartLabel18";
            this.smartLabel18.Size = new System.Drawing.Size(105, 13);
            this.smartLabel18.TabIndex = 264;
            this.smartLabel18.Text = "Finalize By (ID)  :";
            // 
            // txtFinalizeByName
            // 
            this.txtFinalizeByName.BackColor = System.Drawing.Color.Linen;
            this.txtFinalizeByName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalizeByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalizeByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtFinalizeByName.Location = new System.Drawing.Point(334, 168);
            this.txtFinalizeByName.Name = "txtFinalizeByName";
            this.txtFinalizeByName.ReadOnly = true;
            this.txtFinalizeByName.Size = new System.Drawing.Size(363, 24);
            this.txtFinalizeByName.TabIndex = 1;
            this.txtFinalizeByName.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(331, 148);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(51, 13);
            this.smartLabel1.TabIndex = 266;
            this.smartLabel1.Text = "Name  :";
            // 
            // dgvCompletedGrid
            // 
            this.dgvCompletedGrid.AllowUserToAddRows = false;
            this.dgvCompletedGrid.AllowUserToDeleteRows = false;
            this.dgvCompletedGrid.AllowUserToOrderColumns = true;
            this.dgvCompletedGrid.AllowUserToResizeColumns = false;
            this.dgvCompletedGrid.AllowUserToResizeRows = false;
            this.dgvCompletedGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompletedGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCompletedGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCompletedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompletedGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCompletedGrid.Location = new System.Drawing.Point(6, 27);
            this.dgvCompletedGrid.MultiSelect = false;
            this.dgvCompletedGrid.Name = "dgvCompletedGrid";
            this.dgvCompletedGrid.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvCompletedGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCompletedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompletedGrid.Size = new System.Drawing.Size(704, 656);
            this.dgvCompletedGrid.TabIndex = 267;
            // 
            // gbComplete
            // 
            this.gbComplete.Controls.Add(this.dgvCompletedGrid);
            this.gbComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComplete.Location = new System.Drawing.Point(710, 198);
            this.gbComplete.Name = "gbComplete";
            this.gbComplete.Size = new System.Drawing.Size(716, 683);
            this.gbComplete.TabIndex = 268;
            this.gbComplete.TabStop = false;
            this.gbComplete.Text = "Completed Finalize List";
            // 
            // gbPending
            // 
            this.gbPending.Controls.Add(this.dgvFinalizeGrid);
            this.gbPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPending.Location = new System.Drawing.Point(3, 198);
            this.gbPending.Name = "gbPending";
            this.gbPending.Size = new System.Drawing.Size(694, 683);
            this.gbPending.TabIndex = 269;
            this.gbPending.TabStop = false;
            this.gbPending.Text = "Pending List For Finalized";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(153, 166);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(59, 29);
            this.btnShow.TabIndex = 275;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(8, 148);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(74, 13);
            this.smartLabel2.TabIndex = 274;
            this.smartLabel2.Text = "Drop Type :";
            // 
            // cboDropType
            // 
            this.cboDropType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDropType.ForeColor = System.Drawing.Color.Blue;
            this.cboDropType.FormattingEnabled = true;
            this.cboDropType.Location = new System.Drawing.Point(8, 168);
            this.cboDropType.Name = "cboDropType";
            this.cboDropType.Size = new System.Drawing.Size(140, 26);
            this.cboDropType.TabIndex = 273;
            // 
            // frmFinalizeDropList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1427, 869);
            this.isEnterTabAllow = true;
            this.Name = "frmFinalizeDropList";
            this.Load += new System.EventHandler(this.frmFinalizeDropList_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedGrid)).EndInit();
            this.gbComplete.ResumeLayout(false);
            this.gbPending.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartDataGridView dgvFinalizeGrid;
        private AtiqsControlLibrary.SmartTextBox txtFinalizeBy;
        private AtiqsControlLibrary.SmartLabel smartLabel18;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtFinalizeByName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartDataGridView dgvCompletedGrid;
        private System.Windows.Forms.GroupBox gbComplete;
        private System.Windows.Forms.GroupBox gbPending;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboDropType;
    }
}
