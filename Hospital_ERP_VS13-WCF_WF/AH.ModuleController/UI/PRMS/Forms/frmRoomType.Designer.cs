namespace AH.ModuleController.UI.PRMS.Forms
{
    partial class frmRoomType
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
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeNameBeng = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeID = new AtiqsControlLibrary.SmartTextBox();
            this.lvRoomType = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(286, 9);
            this.frmLabel.Size = new System.Drawing.Size(227, 33);
            this.frmLabel.Text = "Room Type Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvRoomType);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtTypeNameBeng);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtTypeName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtTypeID);
            this.pnlMain.Location = new System.Drawing.Point(1, 58);
            this.pnlMain.Size = new System.Drawing.Size(842, 501);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(843, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(614, 565);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(501, 565);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 565);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(388, 565);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(728, 565);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(119, 565);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 604);
            this.groupBox1.Size = new System.Drawing.Size(843, 23);
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(83, 100);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(68, 18);
            this.smartLabel5.TabIndex = 20;
            this.smartLabel5.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(170, 100);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(412, 46);
            this.txtRemarks.TabIndex = 17;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(13, 75);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(138, 18);
            this.smartLabel3.TabIndex = 19;
            this.smartLabel3.Text = "Type Name (Bangla) :";
            // 
            // txtTypeNameBeng
            // 
            this.txtTypeNameBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeNameBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeNameBeng.Location = new System.Drawing.Point(170, 72);
            this.txtTypeNameBeng.Name = "txtTypeNameBeng";
            this.txtTypeNameBeng.Size = new System.Drawing.Size(412, 24);
            this.txtTypeNameBeng.TabIndex = 16;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(66, 48);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(85, 18);
            this.smartLabel2.TabIndex = 18;
            this.smartLabel2.Text = "Type Name :";
            // 
            // txtTypeName
            // 
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(170, 45);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(412, 24);
            this.txtTypeName.TabIndex = 14;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(87, 21);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(64, 18);
            this.smartLabel1.TabIndex = 15;
            this.smartLabel1.Text = "Type ID :";
            // 
            // txtTypeID
            // 
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.Location = new System.Drawing.Point(170, 18);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(112, 24);
            this.txtTypeID.TabIndex = 13;
            // 
            // lvRoomType
            // 
            this.lvRoomType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvRoomType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRoomType.CheckBoxes = true;
            this.lvRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvRoomType.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRoomType.FullRowSelect = true;
            this.lvRoomType.GridLines = true;
            this.lvRoomType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRoomType.Location = new System.Drawing.Point(1, 160);
            this.lvRoomType.Name = "lvRoomType";
            this.lvRoomType.Size = new System.Drawing.Size(839, 337);
            this.lvRoomType.TabIndex = 42;
            this.lvRoomType.UseCompatibleStateImageBehavior = false;
            this.lvRoomType.View = System.Windows.Forms.View.Details;
            this.lvRoomType.SelectedIndexChanged += new System.EventHandler(this.lvRoomType_SelectedIndexChanged);
            // 
            // frmRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(843, 627);
            this.isEnterTabAllow = true;
            this.Name = "frmRoomType";
            this.Load += new System.EventHandler(this.frmRoomType_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtTypeNameBeng;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtTypeName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtTypeID;
        private AtiqsControlLibrary.SmartListViewDetails lvRoomType;
    }
}
