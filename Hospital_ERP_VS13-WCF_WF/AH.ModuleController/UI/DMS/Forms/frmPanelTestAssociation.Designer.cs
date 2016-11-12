namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmPanelTestAssociation
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
            this.cboPanel = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvTestList = new AtiqsControlLibrary.SmartListViewDetails();
            this.lvAssociatedList = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnNewClose = new System.Windows.Forms.Button();
            this.txtSearch = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.btnRefreshPanel = new System.Windows.Forms.Button();
            this.btnAddPanel = new System.Windows.Forms.Button();
            this.txtPanel = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(426, 9);
            this.frmLabel.Size = new System.Drawing.Size(278, 33);
            this.frmLabel.Text = "Panel Test Association";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtPanel);
            this.pnlMain.Controls.Add(this.btnRefreshPanel);
            this.pnlMain.Controls.Add(this.btnAddPanel);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.lvAssociatedList);
            this.pnlMain.Controls.Add(this.lvTestList);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.cboPanel);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(1195, 628);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1195, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(12, 691);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(966, 691);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(125, 691);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(853, 691);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(158, 691);
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(236, 691);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 732);
            this.groupBox1.Size = new System.Drawing.Size(1195, 25);
            // 
            // cboPanel
            // 
            this.cboPanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPanel.ForeColor = System.Drawing.Color.Blue;
            this.cboPanel.FormattingEnabled = true;
            this.cboPanel.Location = new System.Drawing.Point(615, 40);
            this.cboPanel.Name = "cboPanel";
            this.cboPanel.Size = new System.Drawing.Size(423, 26);
            this.cboPanel.TabIndex = 1;
            this.cboPanel.SelectedIndexChanged += new System.EventHandler(this.cboPanel_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(563, 40);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(47, 13);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "Panel :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(1111, 40);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(61, 28);
            this.btnShow.TabIndex = 78;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(533, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 546);
            this.panel2.TabIndex = 86;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(7, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 28);
            this.btnCancel.TabIndex = 88;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "<<";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(7, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvTestList
            // 
            this.lvTestList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvTestList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTestList.CheckBoxes = true;
            this.lvTestList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTestList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTestList.FullRowSelect = true;
            this.lvTestList.GridLines = true;
            this.lvTestList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTestList.Location = new System.Drawing.Point(-1, 81);
            this.lvTestList.Name = "lvTestList";
            this.lvTestList.Size = new System.Drawing.Size(535, 546);
            this.lvTestList.TabIndex = 87;
            this.lvTestList.UseCompatibleStateImageBehavior = false;
            this.lvTestList.View = System.Windows.Forms.View.Details;
            // 
            // lvAssociatedList
            // 
            this.lvAssociatedList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvAssociatedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAssociatedList.CheckBoxes = true;
            this.lvAssociatedList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAssociatedList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAssociatedList.FullRowSelect = true;
            this.lvAssociatedList.GridLines = true;
            this.lvAssociatedList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAssociatedList.Location = new System.Drawing.Point(617, 81);
            this.lvAssociatedList.Name = "lvAssociatedList";
            this.lvAssociatedList.Size = new System.Drawing.Size(577, 546);
            this.lvAssociatedList.TabIndex = 88;
            this.lvAssociatedList.UseCompatibleStateImageBehavior = false;
            this.lvAssociatedList.View = System.Windows.Forms.View.Details;
            // 
            // btnNewClose
            // 
            this.btnNewClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.btnNewClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClose.ForeColor = System.Drawing.Color.Navy;
            this.btnNewClose.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNewClose.ImageIndex = 5;
            this.btnNewClose.Location = new System.Drawing.Point(1080, 691);
            this.btnNewClose.Name = "btnNewClose";
            this.btnNewClose.Size = new System.Drawing.Size(108, 39);
            this.btnNewClose.TabIndex = 15;
            this.btnNewClose.Text = "Close";
            this.btnNewClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewClose.UseVisualStyleBackColor = false;
            this.btnNewClose.Click += new System.EventHandler(this.btnNewClose_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(98, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(436, 24);
            this.txtSearch.TabIndex = 89;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(8, 40);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(84, 13);
            this.smartLabel1.TabIndex = 90;
            this.smartLabel1.Text = "Search Test :";
            // 
            // btnRefreshPanel
            // 
            this.btnRefreshPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRefreshPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPanel.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPanel.Location = new System.Drawing.Point(1077, 40);
            this.btnRefreshPanel.Name = "btnRefreshPanel";
            this.btnRefreshPanel.Size = new System.Drawing.Size(30, 28);
            this.btnRefreshPanel.TabIndex = 95;
            this.btnRefreshPanel.TabStop = false;
            this.btnRefreshPanel.Text = "..";
            this.btnRefreshPanel.UseVisualStyleBackColor = false;
            this.btnRefreshPanel.Click += new System.EventHandler(this.btnRefreshPanel_Click);
            // 
            // btnAddPanel
            // 
            this.btnAddPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPanel.ForeColor = System.Drawing.Color.White;
            this.btnAddPanel.Location = new System.Drawing.Point(1041, 40);
            this.btnAddPanel.Name = "btnAddPanel";
            this.btnAddPanel.Size = new System.Drawing.Size(32, 28);
            this.btnAddPanel.TabIndex = 94;
            this.btnAddPanel.TabStop = false;
            this.btnAddPanel.Text = "+";
            this.btnAddPanel.UseVisualStyleBackColor = false;
            this.btnAddPanel.Click += new System.EventHandler(this.btnAddPanel_Click);
            // 
            // txtPanel
            // 
            this.txtPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanel.Location = new System.Drawing.Point(615, 6);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(567, 24);
            this.txtPanel.TabIndex = 96;
            this.txtPanel.TextChanged += new System.EventHandler(this.txtPanel_TextChanged);
            // 
            // frmPanelTestAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1195, 757);
            this.Controls.Add(this.btnNewClose);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmPanelTestAssociation";
            this.Load += new System.EventHandler(this.frmPanelTestAssociation_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnNewClose, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboPanel;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private AtiqsControlLibrary.SmartListViewDetails lvTestList;
        private AtiqsControlLibrary.SmartListViewDetails lvAssociatedList;
        public System.Windows.Forms.Button btnNewClose;
        private AtiqsControlLibrary.SmartTextBox txtSearch;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Button btnRefreshPanel;
        private System.Windows.Forms.Button btnAddPanel;
        private AtiqsControlLibrary.SmartTextBox txtPanel;
    }
}
