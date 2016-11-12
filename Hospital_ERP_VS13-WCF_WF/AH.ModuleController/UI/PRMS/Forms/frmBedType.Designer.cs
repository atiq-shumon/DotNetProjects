namespace AH.ModuleController.UI.PRMS.Forms
{
    partial class frmBedType
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
            this.txtTypeID = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtTypeNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel12 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.lvBedType = new AtiqsControlLibrary.SmartListViewDetails();
            this.cboFacilityID = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel14 = new AtiqsControlLibrary.SmartLabel();
            this.cboSerialPriority = new AtiqsControlLibrary.SmartComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(416, 9);
            this.frmLabel.Size = new System.Drawing.Size(126, 33);
            this.frmLabel.Text = "Bed Type";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboSerialPriority);
            this.pnlMain.Controls.Add(this.smartLabel14);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.cboFacilityID);
            this.pnlMain.Controls.Add(this.lvBedType);
            this.pnlMain.Controls.Add(this.smartLabel12);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtTypeNameBang);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtTypeName);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtTypeID);
            this.pnlMain.Location = new System.Drawing.Point(1, 57);
            this.pnlMain.Size = new System.Drawing.Size(981, 570);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(982, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(755, 633);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(642, 633);
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 633);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(529, 633);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(869, 633);
            this.btnClose.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(214, 633);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 675);
            this.groupBox1.Size = new System.Drawing.Size(982, 23);
            // 
            // txtTypeID
            // 
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.Location = new System.Drawing.Point(10, 36);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(117, 24);
            this.txtTypeID.TabIndex = 0;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(10, 13);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(61, 18);
            this.smartLabel1.TabIndex = 1;
            this.smartLabel1.Text = "Type Id :";
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(130, 13);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(85, 18);
            this.smartLabel2.TabIndex = 3;
            this.smartLabel2.Text = "Type Name :";
            // 
            // txtTypeName
            // 
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(133, 36);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(407, 24);
            this.txtTypeName.TabIndex = 1;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(543, 13);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(135, 18);
            this.smartLabel3.TabIndex = 5;
            this.smartLabel3.Text = "Type Name(Bangla) :";
            // 
            // txtTypeNameBang
            // 
            this.txtTypeNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeNameBang.Location = new System.Drawing.Point(546, 36);
            this.txtTypeNameBang.Name = "txtTypeNameBang";
            this.txtTypeNameBang.Size = new System.Drawing.Size(422, 24);
            this.txtTypeNameBang.TabIndex = 2;
            // 
            // smartLabel12
            // 
            this.smartLabel12.AutoSize = true;
            this.smartLabel12.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel12.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel12.Location = new System.Drawing.Point(543, 68);
            this.smartLabel12.Name = "smartLabel12";
            this.smartLabel12.Size = new System.Drawing.Size(68, 18);
            this.smartLabel12.TabIndex = 27;
            this.smartLabel12.Text = "Remarks :";
            this.smartLabel12.Click += new System.EventHandler(this.smartLabel12_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(546, 89);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(422, 25);
            this.txtRemarks.TabIndex = 5;
            this.txtRemarks.TextChanged += new System.EventHandler(this.txtRemarks_TextChanged);
            // 
            // lvBedType
            // 
            this.lvBedType.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvBedType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBedType.CheckBoxes = true;
            this.lvBedType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvBedType.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBedType.FullRowSelect = true;
            this.lvBedType.GridLines = true;
            this.lvBedType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvBedType.Location = new System.Drawing.Point(1, 136);
            this.lvBedType.Name = "lvBedType";
            this.lvBedType.Size = new System.Drawing.Size(979, 433);
            this.lvBedType.TabIndex = 42;
            this.lvBedType.TabStop = false;
            this.lvBedType.UseCompatibleStateImageBehavior = false;
            this.lvBedType.View = System.Windows.Forms.View.Details;
            this.lvBedType.SelectedIndexChanged += new System.EventHandler(this.lvBedType_SelectedIndexChanged);
            // 
            // cboFacilityID
            // 
            this.cboFacilityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFacilityID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFacilityID.ForeColor = System.Drawing.Color.Blue;
            this.cboFacilityID.FormattingEnabled = true;
            this.cboFacilityID.Location = new System.Drawing.Point(10, 89);
            this.cboFacilityID.Name = "cboFacilityID";
            this.cboFacilityID.Size = new System.Drawing.Size(372, 26);
            this.cboFacilityID.TabIndex = 3;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(10, 68);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(57, 18);
            this.smartLabel4.TabIndex = 44;
            this.smartLabel4.Text = "Facility :";
            // 
            // smartLabel14
            // 
            this.smartLabel14.AutoSize = true;
            this.smartLabel14.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel14.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel14.Location = new System.Drawing.Point(385, 68);
            this.smartLabel14.Name = "smartLabel14";
            this.smartLabel14.Size = new System.Drawing.Size(96, 18);
            this.smartLabel14.TabIndex = 46;
            this.smartLabel14.Text = "Serial Priority :";
            // 
            // cboSerialPriority
            // 
            this.cboSerialPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSerialPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSerialPriority.ForeColor = System.Drawing.Color.Blue;
            this.cboSerialPriority.FormattingEnabled = true;
            this.cboSerialPriority.Location = new System.Drawing.Point(388, 89);
            this.cboSerialPriority.Name = "cboSerialPriority";
            this.cboSerialPriority.Size = new System.Drawing.Size(152, 26);
            this.cboSerialPriority.TabIndex = 4;
            // 
            // frmBedType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(982, 698);
            this.isEnterTabAllow = true;
            this.Name = "frmBedType";
            this.Load += new System.EventHandler(this.frmBedType_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtTypeNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtTypeName;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtTypeID;
        private AtiqsControlLibrary.SmartLabel smartLabel12;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartListViewDetails lvBedType;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartComboBox cboFacilityID;
        private AtiqsControlLibrary.SmartComboBox cboSerialPriority;
        private AtiqsControlLibrary.SmartLabel smartLabel14;
    }
}
