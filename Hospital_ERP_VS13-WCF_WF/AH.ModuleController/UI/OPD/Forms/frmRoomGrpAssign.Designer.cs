namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmRoomGrpAssign
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
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.cboRoomNo = new AtiqsControlLibrary.SmartComboBox();
            this.lvlRoomGrpAssign = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnSearchByRoomGroup = new System.Windows.Forms.Button();
            this.lblNsStnId = new AtiqsControlLibrary.SmartLabel();
            this.cboNsStnId = new AtiqsControlLibrary.SmartComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(250, 33);
            this.frmLabel.Text = "Room Group Assign";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvlRoomGrpAssign);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(863, 491);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(123, 560);
            this.btnEdit.Size = new System.Drawing.Size(12, 14);
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(625, 554);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(139, 560);
            this.btnDelete.Size = new System.Drawing.Size(10, 13);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(512, 554);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(738, 554);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(152, 560);
            this.btnPrint.Size = new System.Drawing.Size(10, 13);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 596);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(7, 561);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(77, 13);
            this.smartLabel1.TabIndex = 2;
            this.smartLabel1.Text = "Room Group";
            this.smartLabel1.Visible = false;
            this.smartLabel1.Click += new System.EventHandler(this.smartLabel1_Click);
            // 
            // cboRoomGroup
            // 
            this.cboRoomGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomGroup.FormattingEnabled = true;
            this.cboRoomGroup.Location = new System.Drawing.Point(90, 554);
            this.cboRoomGroup.Name = "cboRoomGroup";
            this.cboRoomGroup.Size = new System.Drawing.Size(27, 26);
            this.cboRoomGroup.TabIndex = 3;
            this.cboRoomGroup.Visible = false;
            this.cboRoomGroup.SelectedIndexChanged += new System.EventHandler(this.cboRoomGroup_SelectedIndexChanged);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(598, 26);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(67, 13);
            this.smartLabel2.TabIndex = 4;
            this.smartLabel2.Text = "Room No :";
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomNo.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomNo.FormattingEnabled = true;
            this.cboRoomNo.Location = new System.Drawing.Point(669, 19);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.Size = new System.Drawing.Size(148, 26);
            this.cboRoomNo.TabIndex = 5;
            // 
            // lvlRoomGrpAssign
            // 
            this.lvlRoomGrpAssign.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvlRoomGrpAssign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlRoomGrpAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvlRoomGrpAssign.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlRoomGrpAssign.FullRowSelect = true;
            this.lvlRoomGrpAssign.GridLines = true;
            this.lvlRoomGrpAssign.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvlRoomGrpAssign.Location = new System.Drawing.Point(0, 69);
            this.lvlRoomGrpAssign.Name = "lvlRoomGrpAssign";
            this.lvlRoomGrpAssign.Size = new System.Drawing.Size(862, 421);
            this.lvlRoomGrpAssign.TabIndex = 11;
            this.lvlRoomGrpAssign.UseCompatibleStateImageBehavior = false;
            this.lvlRoomGrpAssign.View = System.Windows.Forms.View.Details;
            this.lvlRoomGrpAssign.SelectedIndexChanged += new System.EventHandler(this.lvlRoomGrpAssign_SelectedIndexChanged);
            // 
            // btnSearchByRoomGroup
            // 
            this.btnSearchByRoomGroup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchByRoomGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByRoomGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByRoomGroup.ForeColor = System.Drawing.Color.White;
            this.btnSearchByRoomGroup.Location = new System.Drawing.Point(339, 14);
            this.btnSearchByRoomGroup.Name = "btnSearchByRoomGroup";
            this.btnSearchByRoomGroup.Size = new System.Drawing.Size(57, 33);
            this.btnSearchByRoomGroup.TabIndex = 116;
            this.btnSearchByRoomGroup.Text = "Find";
            this.btnSearchByRoomGroup.UseVisualStyleBackColor = false;
            this.btnSearchByRoomGroup.Click += new System.EventHandler(this.btnSearchByRoomGroup_Click);
            // 
            // lblNsStnId
            // 
            this.lblNsStnId.AutoSize = true;
            this.lblNsStnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNsStnId.Location = new System.Drawing.Point(12, 24);
            this.lblNsStnId.Name = "lblNsStnId";
            this.lblNsStnId.Size = new System.Drawing.Size(119, 13);
            this.lblNsStnId.TabIndex = 117;
            this.lblNsStnId.Text = "Nursing Station ID :";
            // 
            // cboNsStnId
            // 
            this.cboNsStnId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNsStnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNsStnId.ForeColor = System.Drawing.Color.Blue;
            this.cboNsStnId.FormattingEnabled = true;
            this.cboNsStnId.Location = new System.Drawing.Point(137, 17);
            this.cboNsStnId.Name = "cboNsStnId";
            this.cboNsStnId.Size = new System.Drawing.Size(186, 26);
            this.cboNsStnId.TabIndex = 118;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(402, 14);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(178, 33);
            this.btnReload.TabIndex = 119;
            this.btnReload.Text = "Reload All";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.lblNsStnId);
            this.groupBox2.Controls.Add(this.cboNsStnId);
            this.groupBox2.Controls.Add(this.cboRoomNo);
            this.groupBox2.Controls.Add(this.btnSearchByRoomGroup);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 61);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            // 
            // frmRoomGrpAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(863, 621);
            this.Controls.Add(this.smartLabel1);
            this.Controls.Add(this.cboRoomGroup);
            this.isEnterTabAllow = true;
            this.Name = "frmRoomGrpAssign";
            this.Load += new System.EventHandler(this.frmRoomGrpAssign_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.cboRoomGroup, 0);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartComboBox cboRoomGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartComboBox cboRoomNo;
        private AtiqsControlLibrary.SmartListViewDetails lvlRoomGrpAssign;
        private System.Windows.Forms.Button btnSearchByRoomGroup;
        private AtiqsControlLibrary.SmartComboBox cboNsStnId;
        private AtiqsControlLibrary.SmartLabel lblNsStnId;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
