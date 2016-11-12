namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmPanelSetup
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
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPanelNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.txtPanelName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lvPanel = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtPanelID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(343, 9);
            this.frmLabel.Size = new System.Drawing.Size(155, 33);
            this.frmLabel.Text = "Panel Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtPanelID);
            this.pnlMain.Controls.Add(this.lvPanel);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtPanelNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.txtPanelName);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 508);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(417, 572);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 572);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(530, 572);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(191, 572);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(752, 572);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(641, 572);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 612);
            this.groupBox1.Size = new System.Drawing.Size(863, 23);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(10, 106);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(127, 18);
            this.smartLabel3.TabIndex = 47;
            this.smartLabel3.Text = "Panel Name(Beng) :";
            // 
            // txtPanelNameBeng
            // 
            this.txtPanelNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanelNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanelNameBeng.Location = new System.Drawing.Point(173, 103);
            this.txtPanelNameBeng.Name = "txtPanelNameBeng";
            this.txtPanelNameBeng.Size = new System.Drawing.Size(395, 24);
            this.txtPanelNameBeng.TabIndex = 2;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(69, 141);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 46;
            this.smartLabel5.Text = "Remarks :";
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(70, 28);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(67, 18);
            this.smartLabel1.TabIndex = 44;
            this.smartLabel1.Text = "Panel ID :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(173, 141);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(395, 62);
            this.txtRemarks.TabIndex = 3;
            // 
            // txtPanelName
            // 
            this.txtPanelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanelName.Location = new System.Drawing.Point(173, 64);
            this.txtPanelName.Name = "txtPanelName";
            this.txtPanelName.Size = new System.Drawing.Size(395, 24);
            this.txtPanelName.TabIndex = 1;
            this.txtPanelName.TextChanged += new System.EventHandler(this.txtPanelName_TextChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(49, 67);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(88, 18);
            this.smartLabel2.TabIndex = 45;
            this.smartLabel2.Text = "Panel Name :";
            // 
            // lvPanel
            // 
            this.lvPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPanel.CheckBoxes = true;
            this.lvPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPanel.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPanel.FullRowSelect = true;
            this.lvPanel.GridLines = true;
            this.lvPanel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPanel.Location = new System.Drawing.Point(-1, 236);
            this.lvPanel.Name = "lvPanel";
            this.lvPanel.Size = new System.Drawing.Size(863, 267);
            this.lvPanel.TabIndex = 48;
            this.lvPanel.TabStop = false;
            this.lvPanel.UseCompatibleStateImageBehavior = false;
            this.lvPanel.View = System.Windows.Forms.View.Details;
            this.lvPanel.SelectedIndexChanged += new System.EventHandler(this.lvPanel_SelectedIndexChanged);
            this.lvPanel.Click += new System.EventHandler(this.lvPanel_Click);
            // 
            // txtPanelID
            // 
            this.txtPanelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(133)))));
            this.txtPanelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPanelID.Location = new System.Drawing.Point(173, 21);
            this.txtPanelID.Name = "txtPanelID";
            this.txtPanelID.ReadOnly = true;
            this.txtPanelID.Size = new System.Drawing.Size(181, 24);
            this.txtPanelID.TabIndex = 49;
            this.txtPanelID.TabStop = false;
            // 
            // frmPanelSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 635);
            this.isEnterTabAllow = true;
            this.Name = "frmPanelSetup";
            this.Load += new System.EventHandler(this.frmPanelSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtPanelNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartTextBox txtPanelName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvPanel;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtPanelID;
    }
}
