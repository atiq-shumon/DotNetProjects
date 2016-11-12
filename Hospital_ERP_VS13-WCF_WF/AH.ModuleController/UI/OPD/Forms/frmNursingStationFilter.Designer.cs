namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmNursingStationFilter
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.cboRoomGroup = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(211, 9);
            this.frmLabel.Size = new System.Drawing.Size(264, 33);
            this.frmLabel.Text = "Nursing Station Filter";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboRoomGroup);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(665, 272);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(665, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(17, 350);
            this.btnEdit.Size = new System.Drawing.Size(17, 13);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ImageIndex = 8;
            this.btnSave.Location = new System.Drawing.Point(420, 336);
            this.btnSave.Size = new System.Drawing.Size(125, 39);
            this.btnSave.Text = "Proceed";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(27, 350);
            this.btnDelete.Size = new System.Drawing.Size(17, 13);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(7, 350);
            this.btnNew.Size = new System.Drawing.Size(17, 13);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(551, 336);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(36, 350);
            this.btnPrint.Size = new System.Drawing.Size(17, 13);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 377);
            this.groupBox1.Size = new System.Drawing.Size(665, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(103, 116);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(113, 16);
            this.smartLabel1.TabIndex = 5;
            this.smartLabel1.Text = "Nursing Station";
            // 
            // cboRoomGroup
            // 
            this.cboRoomGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomGroup.FormattingEnabled = true;
            this.cboRoomGroup.Location = new System.Drawing.Point(237, 111);
            this.cboRoomGroup.Name = "cboRoomGroup";
            this.cboRoomGroup.Size = new System.Drawing.Size(285, 26);
            this.cboRoomGroup.TabIndex = 6;
            // 
            // frmNursingStationFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 402);
            this.isEnterTabAllow = true;
            this.Name = "frmNursingStationFilter";
            this.Load += new System.EventHandler(this.frmNursingStationFilter_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboRoomGroup;
    }
}