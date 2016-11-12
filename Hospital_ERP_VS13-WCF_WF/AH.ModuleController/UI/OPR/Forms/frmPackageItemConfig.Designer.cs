namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmPackageItemConfig
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
            this.txtPackageItem = new AtiqsControlLibrary.SmartTextBox();
            this.smartTextBox2 = new AtiqsControlLibrary.SmartTextBox();
            this.txtpackageRate = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.lvwPackageItem = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtPackageCode = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtSubItem = new AtiqsControlLibrary.SmartTextBox();
            this.lstSubItem = new System.Windows.Forms.ListBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(238, 33);
            this.frmLabel.TabIndex = 9;
            this.frmLabel.Text = "Package Item Rate";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lstSubItem);
            this.pnlMain.Controls.Add(this.txtSubItem);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtPackageCode);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.lvwPackageItem);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtpackageRate);
            this.pnlMain.Controls.Add(this.smartTextBox2);
            this.pnlMain.Controls.Add(this.txtPackageItem);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Size = new System.Drawing.Size(863, 660);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(415, 578);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(302, 578);
            this.btnSave.TabIndex = 2;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(528, 578);
            this.btnDelete.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(189, 578);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 578);
            this.btnClose.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(639, 578);
            this.btnPrint.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 618);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(178, 192);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(107, 16);
            this.smartLabel1.TabIndex = 6;
            this.smartLabel1.Text = "Package Item:";
            // 
            // txtPackageItem
            // 
            this.txtPackageItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageItem.Location = new System.Drawing.Point(296, 189);
            this.txtPackageItem.Name = "txtPackageItem";
            this.txtPackageItem.Size = new System.Drawing.Size(373, 24);
            this.txtPackageItem.TabIndex = 0;
            this.txtPackageItem.TextChanged += new System.EventHandler(this.txtPackageItem_TextChanged);
            this.txtPackageItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPackageItem_KeyPress);
            // 
            // smartTextBox2
            // 
            this.smartTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smartTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartTextBox2.Location = new System.Drawing.Point(0, 0);
            this.smartTextBox2.Name = "smartTextBox2";
            this.smartTextBox2.Size = new System.Drawing.Size(100, 24);
            this.smartTextBox2.TabIndex = 17;
            // 
            // txtpackageRate
            // 
            this.txtpackageRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpackageRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpackageRate.Location = new System.Drawing.Point(794, 161);
            this.txtpackageRate.Name = "txtpackageRate";
            this.txtpackageRate.Size = new System.Drawing.Size(10, 24);
            this.txtpackageRate.TabIndex = 1;
            this.txtpackageRate.Visible = false;
            this.txtpackageRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpackageRate_KeyPress);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(716, 168);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(78, 16);
            this.smartLabel2.TabIndex = 19;
            this.smartLabel2.Text = "Item Rate:";
            this.smartLabel2.Visible = false;
            // 
            // lvwPackageItem
            // 
            this.lvwPackageItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwPackageItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwPackageItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwPackageItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPackageItem.FullRowSelect = true;
            this.lvwPackageItem.GridLines = true;
            this.lvwPackageItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwPackageItem.Location = new System.Drawing.Point(14, 219);
            this.lvwPackageItem.Name = "lvwPackageItem";
            this.lvwPackageItem.Size = new System.Drawing.Size(839, 431);
            this.lvwPackageItem.TabIndex = 8;
            this.lvwPackageItem.UseCompatibleStateImageBehavior = false;
            this.lvwPackageItem.View = System.Windows.Forms.View.Details;
            this.lvwPackageItem.SelectedIndexChanged += new System.EventHandler(this.lvwPackageItem_SelectedIndexChanged);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(220, 161);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(65, 16);
            this.smartLabel3.TabIndex = 20;
            this.smartLabel3.Text = "Item No:";
            // 
            // txtPackageCode
            // 
            this.txtPackageCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageCode.Location = new System.Drawing.Point(296, 159);
            this.txtPackageCode.Name = "txtPackageCode";
            this.txtPackageCode.ReadOnly = true;
            this.txtPackageCode.Size = new System.Drawing.Size(373, 24);
            this.txtPackageCode.TabIndex = 21;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(745, 190);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(72, 16);
            this.smartLabel4.TabIndex = 33;
            this.smartLabel4.Text = "Sub Item:";
            this.smartLabel4.Visible = false;
            // 
            // txtSubItem
            // 
            this.txtSubItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubItem.Location = new System.Drawing.Point(719, 161);
            this.txtSubItem.Name = "txtSubItem";
            this.txtSubItem.Size = new System.Drawing.Size(12, 24);
            this.txtSubItem.TabIndex = 34;
            this.txtSubItem.Visible = false;
            this.txtSubItem.TextChanged += new System.EventHandler(this.txtSubItem_TextChanged);
            this.txtSubItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubItem_KeyDown);
            this.txtSubItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubItem_KeyPress);
            // 
            // lstSubItem
            // 
            this.lstSubItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSubItem.FormattingEnabled = true;
            this.lstSubItem.Location = new System.Drawing.Point(685, 150);
            this.lstSubItem.Name = "lstSubItem";
            this.lstSubItem.Size = new System.Drawing.Size(79, 2);
            this.lstSubItem.TabIndex = 36;
            this.lstSubItem.Visible = false;
            this.lstSubItem.DoubleClick += new System.EventHandler(this.lstSubItem_DoubleClick);
            // 
            // frmPackageItemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 643);
            this.isEnterTabAllow = true;
            this.KeyPreview = false;
            this.Name = "frmPackageItemConfig";
            this.Load += new System.EventHandler(this.frmPackageItemConfig_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvwPackageItem;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtpackageRate;
        private AtiqsControlLibrary.SmartTextBox smartTextBox2;
        private AtiqsControlLibrary.SmartTextBox txtPackageItem;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtPackageCode;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtSubItem;
        private System.Windows.Forms.ListBox lstSubItem;
    }
}
