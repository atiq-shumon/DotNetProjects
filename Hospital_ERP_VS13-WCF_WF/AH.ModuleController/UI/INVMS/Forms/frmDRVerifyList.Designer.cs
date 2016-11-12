namespace AH.ModuleController.UI.INVMS.Forms
{

    partial class frmDRVerifyList
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
            this.dgvRequisitionList = new System.Windows.Forms.DataGridView();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.txtRequisitionBy = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitionList)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(172, 9);
            this.frmLabel.Size = new System.Drawing.Size(300, 33);
            this.frmLabel.Text = "Demand Requisition List";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvRequisitionList);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(650, 494);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(650, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(214, 557);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 550);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 557);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(244, 557);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(534, 557);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(307, 558);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(650, 25);
            // 
            // dgvRequisitionList
            // 
            this.dgvRequisitionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitionList.Location = new System.Drawing.Point(1, -1);
            this.dgvRequisitionList.Name = "dgvRequisitionList";
            this.dgvRequisitionList.Size = new System.Drawing.Size(645, 493);
            this.dgvRequisitionList.TabIndex = 0;
            this.dgvRequisitionList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisitionList_CellContentDoubleClick_1);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(6, 563);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(60, 26);
            this.cboDepartment.TabIndex = 1;
            this.cboDepartment.Visible = false;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged_1);
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(72, 565);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(50, 26);
            this.cboUnit.TabIndex = 2;
            this.cboUnit.Visible = false;
            // 
            // txtRequisitionBy
            // 
            this.txtRequisitionBy.BackColor = System.Drawing.Color.Linen;
            this.txtRequisitionBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequisitionBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequisitionBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRequisitionBy.Location = new System.Drawing.Point(434, 566);
            this.txtRequisitionBy.Name = "txtRequisitionBy";
            this.txtRequisitionBy.ReadOnly = true;
            this.txtRequisitionBy.Size = new System.Drawing.Size(51, 24);
            this.txtRequisitionBy.TabIndex = 3;
            this.txtRequisitionBy.TabStop = false;
            this.txtRequisitionBy.Visible = false;
            // 
            // frmDRVerifyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(650, 623);
            this.Controls.Add(this.txtRequisitionBy);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.cboDepartment);
            this.isEnterTabAllow = true;
            this.Name = "frmDRVerifyList";
            this.Load += new System.EventHandler(this.frmDemandRequisitionList_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.cboDepartment, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.cboUnit, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtRequisitionBy, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequisitionList;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRequisitionBy;
    }
}
