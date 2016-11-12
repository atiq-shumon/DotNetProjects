namespace AH.ModuleController.UI.FNB.Forms
{
    partial class frmfoodMenutype
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
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeID = new AtiqsControlLibrary.SmartTextBox();
            this.lvwFoodMenuType = new AtiqsControlLibrary.SmartListViewDetails();
            this.txtFoodMenuName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(213, 33);
            this.frmLabel.Text = "Food Menu Type";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtTypeID);
            this.pnlMain.Controls.Add(this.lvwFoodMenuType);
            this.pnlMain.Controls.Add(this.txtFoodMenuName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(636, 554);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(523, 554);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(-39, 544);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(410, 554);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(72, 544);
            this.btnPrint.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(278, 233);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(379, 24);
            this.txtRemarks.TabIndex = 25;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(203, 237);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(70, 14);
            this.smartLabel3.TabIndex = 24;
            this.smartLabel3.Text = "Remarks:";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(209, 169);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(64, 14);
            this.smartLabel2.TabIndex = 23;
            this.smartLabel2.Text = "Type ID:";
            this.smartLabel2.Visible = false;
            // 
            // txtTypeID
            // 
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.Location = new System.Drawing.Point(278, 163);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(379, 24);
            this.txtTypeID.TabIndex = 22;
            this.txtTypeID.Visible = false;
            // 
            // lvwFoodMenuType
            // 
            this.lvwFoodMenuType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwFoodMenuType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwFoodMenuType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwFoodMenuType.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFoodMenuType.FullRowSelect = true;
            this.lvwFoodMenuType.GridLines = true;
            this.lvwFoodMenuType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFoodMenuType.Location = new System.Drawing.Point(7, 280);
            this.lvwFoodMenuType.Name = "lvwFoodMenuType";
            this.lvwFoodMenuType.Size = new System.Drawing.Size(847, 323);
            this.lvwFoodMenuType.TabIndex = 21;
            this.lvwFoodMenuType.UseCompatibleStateImageBehavior = false;
            this.lvwFoodMenuType.View = System.Windows.Forms.View.Details;
            this.lvwFoodMenuType.SelectedIndexChanged += new System.EventHandler(this.lvwFoodMenuType_SelectedIndexChanged);
            // 
            // txtFoodMenuName
            // 
            this.txtFoodMenuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodMenuName.Location = new System.Drawing.Point(279, 196);
            this.txtFoodMenuName.Name = "txtFoodMenuName";
            this.txtFoodMenuName.Size = new System.Drawing.Size(379, 24);
            this.txtFoodMenuName.TabIndex = 20;
            this.txtFoodMenuName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodMenuName_KeyPress);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(148, 201);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(125, 14);
            this.smartLabel1.TabIndex = 19;
            this.smartLabel1.Text = "Food Menu Name:";
            // 
            // frmfoodMenutype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmfoodMenutype";
            this.Load += new System.EventHandler(this.frmfoodMenutype_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtTypeID;
        private AtiqsControlLibrary.SmartListViewDetails lvwFoodMenuType;
        private AtiqsControlLibrary.SmartTextBox txtFoodMenuName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
    }
}
