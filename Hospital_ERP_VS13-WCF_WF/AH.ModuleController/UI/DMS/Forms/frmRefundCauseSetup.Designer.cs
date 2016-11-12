﻿namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmRefundCauseSetup
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
            this.txtCauseID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtCauseNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtCauseName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lvCause = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(305, 9);
            this.frmLabel.Size = new System.Drawing.Size(255, 33);
            this.frmLabel.Text = "Refund Cause Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvCause);
            this.pnlMain.Controls.Add(this.txtCauseID);
            this.pnlMain.Controls.Add(this.txtCauseName);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtCauseNameBeng);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCauseID
            // 
            this.txtCauseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtCauseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCauseID.Location = new System.Drawing.Point(185, 157);
            this.txtCauseID.Name = "txtCauseID";
            this.txtCauseID.ReadOnly = true;
            this.txtCauseID.Size = new System.Drawing.Size(194, 24);
            this.txtCauseID.TabIndex = 74;
            this.txtCauseID.TabStop = false;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(38, 235);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(130, 18);
            this.smartLabel3.TabIndex = 73;
            this.smartLabel3.Text = "Cause Name(Beng) :";
            // 
            // txtCauseNameBeng
            // 
            this.txtCauseNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauseNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauseNameBeng.Location = new System.Drawing.Point(185, 232);
            this.txtCauseNameBeng.Name = "txtCauseNameBeng";
            this.txtCauseNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtCauseNameBeng.TabIndex = 68;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(100, 270);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 72;
            this.smartLabel5.Text = "Remarks :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(101, 157);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(67, 18);
            this.smartLabel1.TabIndex = 70;
            this.smartLabel1.Text = "CauseID :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(185, 270);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(395, 62);
            this.txtRemarks.TabIndex = 69;
            this.txtRemarks.Text = "N/A";
            // 
            // txtCauseName
            // 
            this.txtCauseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauseName.Location = new System.Drawing.Point(185, 193);
            this.txtCauseName.Name = "txtCauseName";
            this.txtCauseName.Size = new System.Drawing.Size(395, 24);
            this.txtCauseName.TabIndex = 67;
            this.txtCauseName.TextChanged += new System.EventHandler(this.txtCauseName_TextChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(77, 196);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(91, 18);
            this.smartLabel2.TabIndex = 71;
            this.smartLabel2.Text = "Cause Name :";
            // 
            // lvCause
            // 
            this.lvCause.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvCause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCause.CheckBoxes = true;
            this.lvCause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCause.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCause.FullRowSelect = true;
            this.lvCause.GridLines = true;
            this.lvCause.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCause.Location = new System.Drawing.Point(-5, 350);
            this.lvCause.Name = "lvCause";
            this.lvCause.Size = new System.Drawing.Size(863, 282);
            this.lvCause.TabIndex = 75;
            this.lvCause.TabStop = false;
            this.lvCause.UseCompatibleStateImageBehavior = false;
            this.lvCause.View = System.Windows.Forms.View.Details;
            this.lvCause.SelectedIndexChanged += new System.EventHandler(this.lvCause_SelectedIndexChanged);
            this.lvCause.Click += new System.EventHandler(this.lvCause_Click);
            // 
            // frmRefundCauseSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmRefundCauseSetup";
            this.Load += new System.EventHandler(this.frmRefundCauseSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartReadOnlyTextBox txtCauseID;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtCauseNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtCauseName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvCause;
    }
}