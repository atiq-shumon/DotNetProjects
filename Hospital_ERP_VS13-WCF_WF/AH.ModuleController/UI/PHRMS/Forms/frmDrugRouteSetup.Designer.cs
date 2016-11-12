namespace AH.ModuleController.UI.PHRMS.Forms
{
    partial class frmDrugRouteSetup
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtRouteID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtRouteNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtRouteName = new AtiqsControlLibrary.SmartTextBox();
            this.lvDrugRoute = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(227, 33);
            this.frmLabel.Text = "Drug Route Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvDrugRoute);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtRouteID);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtRouteNameBang);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtRouteName);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(638, 555);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(529, 555);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 555);
            this.btnDelete.Size = new System.Drawing.Size(35, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(420, 555);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(65, 553);
            this.btnPrint.Size = new System.Drawing.Size(33, 39);
            this.btnPrint.Visible = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(82, 153);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(27, 15);
            this.smartLabel1.TabIndex = 62;
            this.smartLabel1.Text = "ID :";
            // 
            // txtRouteID
            // 
            this.txtRouteID.BackColor = System.Drawing.Color.Linen;
            this.txtRouteID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRouteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRouteID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRouteID.Location = new System.Drawing.Point(122, 150);
            this.txtRouteID.Name = "txtRouteID";
            this.txtRouteID.ReadOnly = true;
            this.txtRouteID.Size = new System.Drawing.Size(172, 24);
            this.txtRouteID.TabIndex = 61;
            this.txtRouteID.TabStop = false;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(44, 240);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(65, 15);
            this.smartLabel7.TabIndex = 60;
            this.smartLabel7.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(122, 237);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(424, 46);
            this.txtRemarks.TabIndex = 57;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(8, 211);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(95, 15);
            this.smartLabel3.TabIndex = 59;
            this.smartLabel3.Text = "Name( Bangla) :";
            // 
            // txtRouteNameBang
            // 
            this.txtRouteNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRouteNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRouteNameBang.Location = new System.Drawing.Point(122, 208);
            this.txtRouteNameBang.Name = "txtRouteNameBang";
            this.txtRouteNameBang.Size = new System.Drawing.Size(357, 24);
            this.txtRouteNameBang.TabIndex = 56;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(61, 182);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(45, 15);
            this.smartLabel2.TabIndex = 58;
            this.smartLabel2.Text = "Name :";
            // 
            // txtRouteName
            // 
            this.txtRouteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRouteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRouteName.Location = new System.Drawing.Point(122, 179);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(357, 24);
            this.txtRouteName.TabIndex = 55;
            // 
            // lvDrugRoute
            // 
            this.lvDrugRoute.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvDrugRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDrugRoute.CheckBoxes = true;
            this.lvDrugRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDrugRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrugRoute.FullRowSelect = true;
            this.lvDrugRoute.GridLines = true;
            this.lvDrugRoute.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDrugRoute.Location = new System.Drawing.Point(1, 288);
            this.lvDrugRoute.Name = "lvDrugRoute";
            this.lvDrugRoute.Size = new System.Drawing.Size(859, 346);
            this.lvDrugRoute.TabIndex = 63;
            this.lvDrugRoute.TabStop = false;
            this.lvDrugRoute.UseCompatibleStateImageBehavior = false;
            this.lvDrugRoute.View = System.Windows.Forms.View.Details;
            this.lvDrugRoute.SelectedIndexChanged += new System.EventHandler(this.lvDrugRoute_SelectedIndexChanged);
            // 
            // frmDrugRouteSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.isEnterTabAllow = true;
            this.Name = "frmDrugRouteSetup";
            this.Load += new System.EventHandler(this.frmDrugRouteSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtRouteID;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtRouteNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtRouteName;
        private AtiqsControlLibrary.SmartListViewDetails lvDrugRoute;
    }
}
