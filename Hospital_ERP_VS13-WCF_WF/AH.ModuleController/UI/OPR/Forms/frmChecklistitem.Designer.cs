namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmChecklistitem
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
            this.label3 = new System.Windows.Forms.Label();
            this.lvwChecklistItem = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtchecklistitem = new AtiqsControlLibrary.SmartTextBox();
            this.txtItemCode = new AtiqsControlLibrary.SmartTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(308, 7);
            this.frmLabel.Size = new System.Drawing.Size(197, 33);
            this.frmLabel.TabIndex = 1;
            this.frmLabel.Text = "Check List Item";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtItemCode);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtchecklistitem);
            this.pnlMain.Controls.Add(this.lvwChecklistItem);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Size = new System.Drawing.Size(779, 611);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(785, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(327, 531);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 531);
            this.btnSave.TabIndex = 2;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(440, 531);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(101, 531);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(662, 531);
            this.btnClose.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(551, 531);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 573);
            this.groupBox1.Size = new System.Drawing.Size(785, 25);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Item Name:";
            // 
            // lvwChecklistItem
            // 
            this.lvwChecklistItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwChecklistItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwChecklistItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwChecklistItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwChecklistItem.FullRowSelect = true;
            this.lvwChecklistItem.GridLines = true;
            this.lvwChecklistItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwChecklistItem.Location = new System.Drawing.Point(14, 236);
            this.lvwChecklistItem.Name = "lvwChecklistItem";
            this.lvwChecklistItem.Size = new System.Drawing.Size(754, 360);
            this.lvwChecklistItem.TabIndex = 19;
            this.lvwChecklistItem.UseCompatibleStateImageBehavior = false;
            this.lvwChecklistItem.View = System.Windows.Forms.View.Details;
            this.lvwChecklistItem.SelectedIndexChanged += new System.EventHandler(this.lvwChecklistItem_SelectedIndexChanged);
            // 
            // txtchecklistitem
            // 
            this.txtchecklistitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtchecklistitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchecklistitem.Location = new System.Drawing.Point(250, 195);
            this.txtchecklistitem.Name = "txtchecklistitem";
            this.txtchecklistitem.Size = new System.Drawing.Size(405, 24);
            this.txtchecklistitem.TabIndex = 20;
            this.txtchecklistitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtchecklistitem_KeyPress);
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(250, 165);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(405, 24);
            this.txtItemCode.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Item Code:";
            // 
            // frmChecklistitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(785, 598);
            this.KeyPreview = false;
            this.Name = "frmChecklistitem";
            this.Load += new System.EventHandler(this.frmChecklistitem_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvwChecklistItem;
        private System.Windows.Forms.Label label3;
        private AtiqsControlLibrary.SmartTextBox txtchecklistitem;
        private AtiqsControlLibrary.SmartTextBox txtItemCode;
        private System.Windows.Forms.Label label1;
    }
}
