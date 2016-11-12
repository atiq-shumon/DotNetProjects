namespace AH.ModuleController.UI.ACMS.Forms
{
    partial class frmCreateObject
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
            this.txtObject = new AtiqsControlLibrary.SmartTextBox();
            this.cboModule = new AtiqsControlLibrary.SmartComboBox();
            this.lvObject = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboObjectType = new AtiqsControlLibrary.SmartComboBox();
            this.txtObjectID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtObjSerial = new AtiqsControlLibrary.SmartTextBox();
            this.txtModuleID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.Location = new System.Drawing.Point(790, 3);
            this.btnTopClose.Size = new System.Drawing.Size(42, 37);
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(381, 4);
            this.frmLabel.Size = new System.Drawing.Size(168, 33);
            this.frmLabel.Text = "Object Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.cboObjectType);
            this.pnlMain.Controls.Add(this.cboModule);
            this.pnlMain.Controls.Add(this.lvObject);
            this.pnlMain.Location = new System.Drawing.Point(2, 46);
            this.pnlMain.Size = new System.Drawing.Size(926, 531);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(928, 46);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(586, 583);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(473, 583);
            this.btnSave.TabIndex = 7;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(699, 583);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(360, 583);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(813, 583);
            this.btnClose.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(152, 583);
            this.btnPrint.Size = new System.Drawing.Size(47, 20);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 623);
            this.groupBox1.Size = new System.Drawing.Size(928, 23);
            // 
            // txtObject
            // 
            this.txtObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObject.Location = new System.Drawing.Point(493, 28);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(390, 24);
            this.txtObject.TabIndex = 5;
            this.txtObject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObject_KeyDown);
            // 
            // cboModule
            // 
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModule.ForeColor = System.Drawing.Color.Blue;
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboModule.Location = new System.Drawing.Point(92, 10);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(298, 26);
            this.cboModule.TabIndex = 1;
            this.cboModule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboModule_KeyDown);
            // 
            // lvObject
            // 
            this.lvObject.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvObject.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvObject.FullRowSelect = true;
            this.lvObject.GridLines = true;
            this.lvObject.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvObject.Location = new System.Drawing.Point(-2, 117);
            this.lvObject.Name = "lvObject";
            this.lvObject.Size = new System.Drawing.Size(928, 412);
            this.lvObject.TabIndex = 4;
            this.lvObject.UseCompatibleStateImageBehavior = false;
            this.lvObject.View = System.Windows.Forms.View.Details;
            this.lvObject.SelectedIndexChanged += new System.EventHandler(this.lvObject_SelectedIndexChanged);
            // 
            // cboObjectType
            // 
            this.cboObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboObjectType.ForeColor = System.Drawing.Color.Blue;
            this.cboObjectType.FormattingEnabled = true;
            this.cboObjectType.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboObjectType.Location = new System.Drawing.Point(495, 11);
            this.cboObjectType.Name = "cboObjectType";
            this.cboObjectType.Size = new System.Drawing.Size(280, 26);
            this.cboObjectType.TabIndex = 2;
            this.cboObjectType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboObjectType_KeyDown);
            // 
            // txtObjectID
            // 
            this.txtObjectID.BackColor = System.Drawing.Color.White;
            this.txtObjectID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjectID.ForeColor = System.Drawing.Color.Black;
            this.txtObjectID.Location = new System.Drawing.Point(125, 28);
            this.txtObjectID.Name = "txtObjectID";
            this.txtObjectID.Size = new System.Drawing.Size(339, 24);
            this.txtObjectID.TabIndex = 4;
            this.txtObjectID.TabStop = false;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(40, 15);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(48, 13);
            this.smartLabel1.TabIndex = 9;
            this.smartLabel1.Text = "Module";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(413, 15);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(76, 13);
            this.smartLabel2.TabIndex = 10;
            this.smartLabel2.Text = "Object Type";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(584, 12);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(73, 13);
            this.smartLabel3.TabIndex = 11;
            this.smartLabel3.Text = "Object Title";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(177, 12);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(156, 13);
            this.smartLabel4.TabIndex = 12;
            this.smartLabel4.Text = "Object ID as Used in Form";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(796, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(81, 31);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.smartLabel5);
            this.panel1.Controls.Add(this.txtObjectID);
            this.panel1.Controls.Add(this.txtObjSerial);
            this.panel1.Controls.Add(this.smartLabel4);
            this.panel1.Controls.Add(this.smartLabel3);
            this.panel1.Controls.Add(this.txtObject);
            this.panel1.Location = new System.Drawing.Point(-1, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 72);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(887, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 197;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(467, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 196;
            this.label3.Text = "*";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(22, 12);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(39, 13);
            this.smartLabel5.TabIndex = 17;
            this.smartLabel5.Text = "Serial";
            // 
            // txtObjSerial
            // 
            this.txtObjSerial.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtObjSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObjSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjSerial.Location = new System.Drawing.Point(16, 28);
            this.txtObjSerial.Name = "txtObjSerial";
            this.txtObjSerial.ReadOnly = true;
            this.txtObjSerial.Size = new System.Drawing.Size(103, 24);
            this.txtObjSerial.TabIndex = 3;
            // 
            // txtModuleID
            // 
            this.txtModuleID.Location = new System.Drawing.Point(20, 583);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(126, 20);
            this.txtModuleID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(391, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 194;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(778, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 195;
            this.label1.Text = "*";
            // 
            // frmCreateObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 646);
            this.Controls.Add(this.txtModuleID);
            this.isEnterTabAllow = true;
            this.Name = "frmCreateObject";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCreateObject_Load);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.txtModuleID, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails lvObject;
        private AtiqsControlLibrary.SmartComboBox cboModule;
        private AtiqsControlLibrary.SmartTextBox txtObject;
        private AtiqsControlLibrary.SmartComboBox cboObjectType;
        private AtiqsControlLibrary.SmartTextBox txtObjectID;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel1;
        private AtiqsControlLibrary.SmartTextBox txtObjSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private System.Windows.Forms.TextBox txtModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
