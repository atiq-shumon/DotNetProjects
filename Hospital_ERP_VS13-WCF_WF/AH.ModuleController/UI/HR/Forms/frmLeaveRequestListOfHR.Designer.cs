﻿namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmLeaveRequestListOfHR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtApprovedByID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtApprovedName = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lblApproved = new AtiqsControlLibrary.SmartLabel();
            this.dgvLeaveReqstList = new AtiqsControlLibrary.SmartDataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveReqstList)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(533, 9);
            this.frmLabel.Size = new System.Drawing.Size(314, 33);
            this.frmLabel.Text = "Leave Request List Of HR";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtApprovedByID);
            this.pnlMain.Controls.Add(this.txtApprovedName);
            this.pnlMain.Controls.Add(this.lblApproved);
            this.pnlMain.Controls.Add(this.dgvLeaveReqstList);
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Size = new System.Drawing.Size(1356, 730);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1356, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(901, 790);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(788, 790);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(1014, 790);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(675, 790);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1236, 790);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(1125, 790);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 829);
            this.groupBox1.Size = new System.Drawing.Size(1356, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(117, 16);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(119, 13);
            this.smartLabel1.TabIndex = 200;
            this.smartLabel1.Text = "Approved By(Name)";
            // 
            // txtApprovedByID
            // 
            this.txtApprovedByID.BackColor = System.Drawing.Color.Linen;
            this.txtApprovedByID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprovedByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedByID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtApprovedByID.Location = new System.Drawing.Point(11, 35);
            this.txtApprovedByID.Name = "txtApprovedByID";
            this.txtApprovedByID.ReadOnly = true;
            this.txtApprovedByID.Size = new System.Drawing.Size(103, 24);
            this.txtApprovedByID.TabIndex = 199;
            this.txtApprovedByID.TabStop = false;
            // 
            // txtApprovedName
            // 
            this.txtApprovedName.BackColor = System.Drawing.Color.Linen;
            this.txtApprovedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprovedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtApprovedName.Location = new System.Drawing.Point(120, 35);
            this.txtApprovedName.Name = "txtApprovedName";
            this.txtApprovedName.ReadOnly = true;
            this.txtApprovedName.Size = new System.Drawing.Size(382, 24);
            this.txtApprovedName.TabIndex = 198;
            this.txtApprovedName.TabStop = false;
            // 
            // lblApproved
            // 
            this.lblApproved.AutoSize = true;
            this.lblApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApproved.Location = new System.Drawing.Point(10, 16);
            this.lblApproved.Name = "lblApproved";
            this.lblApproved.Size = new System.Drawing.Size(100, 13);
            this.lblApproved.TabIndex = 197;
            this.lblApproved.Text = "Approved By(ID)";
            // 
            // dgvLeaveReqstList
            // 
            this.dgvLeaveReqstList.AllowUserToAddRows = false;
            this.dgvLeaveReqstList.AllowUserToDeleteRows = false;
            this.dgvLeaveReqstList.AllowUserToOrderColumns = true;
            this.dgvLeaveReqstList.AllowUserToResizeColumns = false;
            this.dgvLeaveReqstList.AllowUserToResizeRows = false;
            this.dgvLeaveReqstList.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaveReqstList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLeaveReqstList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeaveReqstList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeaveReqstList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeaveReqstList.Location = new System.Drawing.Point(-1, 75);
            this.dgvLeaveReqstList.MultiSelect = false;
            this.dgvLeaveReqstList.Name = "dgvLeaveReqstList";
            this.dgvLeaveReqstList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvLeaveReqstList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeaveReqstList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveReqstList.Size = new System.Drawing.Size(1356, 650);
            this.dgvLeaveReqstList.TabIndex = 201;
            this.dgvLeaveReqstList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaveReqstList_CellClick);
            this.dgvLeaveReqstList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaveReqstList_CellDoubleClick);
            // 
            // frmLeaveRequestListOfHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1356, 854);
            this.isEnterTabAllow = true;
            this.Name = "frmLeaveRequestListOfHR";
            this.Activated += new System.EventHandler(this.frmLeaveRequestListOfHR_Activated);
            this.Load += new System.EventHandler(this.frmLeaveRequestListOfHR_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveReqstList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtApprovedByID;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtApprovedName;
        private AtiqsControlLibrary.SmartLabel lblApproved;
        private AtiqsControlLibrary.SmartDataGridView dgvLeaveReqstList;
    }
}