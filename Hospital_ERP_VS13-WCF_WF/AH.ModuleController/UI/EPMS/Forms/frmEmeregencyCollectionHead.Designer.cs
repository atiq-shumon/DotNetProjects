namespace AH.ModuleController.UI.DMS.Forms
{
    partial class frmEmeregencyCollectionHead
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
            this.cboDepartmentGroup = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel22 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartmentType = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel21 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.cboUnit = new AtiqsControlLibrary.SmartComboBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.cboDepartment = new AtiqsControlLibrary.SmartComboBox();
            this.txtHeadID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.txtHeadTitle = new AtiqsControlLibrary.SmartTextBox();
            this.txtHeadTitleBeng = new AtiqsControlLibrary.SmartTextBox();
            this.txtPosSerial = new AtiqsControlLibrary.SmartNumericTextBox();
            this.chkDefault = new AtiqsControlLibrary.SmartCheckBox();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtHeadGroup = new AtiqsControlLibrary.SmartNumericTextBox();
            this.lvEmerCollHead = new AtiqsControlLibrary.SmartListViewDetails();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtFee = new AtiqsControlLibrary.SmartNumericTextBox();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.chkIsSelectable = new AtiqsControlLibrary.SmartCheckBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(356, 9);
            this.frmLabel.Size = new System.Drawing.Size(413, 33);
            this.frmLabel.Text = "Emergency Collection Head Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chkIsSelectable);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.txtFee);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.lvEmerCollHead);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.chkDefault);
            this.pnlMain.Controls.Add(this.txtPosSerial);
            this.pnlMain.Controls.Add(this.txtHeadTitleBeng);
            this.pnlMain.Controls.Add(this.txtHeadTitle);
            this.pnlMain.Controls.Add(this.cboDepartmentGroup);
            this.pnlMain.Controls.Add(this.smartLabel22);
            this.pnlMain.Controls.Add(this.cboDepartmentType);
            this.pnlMain.Controls.Add(this.smartLabel21);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.cboUnit);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.cboDepartment);
            this.pnlMain.Location = new System.Drawing.Point(1, -87);
            this.pnlMain.Size = new System.Drawing.Size(1124, 842);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1125, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(900, 761);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(787, 761);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 761);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(674, 761);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1014, 761);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(127, 761);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 804);
            this.groupBox1.Size = new System.Drawing.Size(1125, 25);
            // 
            // cboDepartmentGroup
            // 
            this.cboDepartmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentGroup.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentGroup.FormattingEnabled = true;
            this.cboDepartmentGroup.Location = new System.Drawing.Point(135, 173);
            this.cboDepartmentGroup.Name = "cboDepartmentGroup";
            this.cboDepartmentGroup.Size = new System.Drawing.Size(137, 26);
            this.cboDepartmentGroup.TabIndex = 200;
            this.cboDepartmentGroup.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentGroup_SelectedIndexChanged);
            // 
            // smartLabel22
            // 
            this.smartLabel22.AutoSize = true;
            this.smartLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel22.Location = new System.Drawing.Point(132, 153);
            this.smartLabel22.Name = "smartLabel22";
            this.smartLabel22.Size = new System.Drawing.Size(118, 13);
            this.smartLabel22.TabIndex = 205;
            this.smartLabel22.Text = "Department Group :";
            // 
            // cboDepartmentType
            // 
            this.cboDepartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentType.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartmentType.FormattingEnabled = true;
            this.cboDepartmentType.Location = new System.Drawing.Point(18, 173);
            this.cboDepartmentType.Name = "cboDepartmentType";
            this.cboDepartmentType.Size = new System.Drawing.Size(112, 26);
            this.cboDepartmentType.TabIndex = 199;
            this.cboDepartmentType.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentType_SelectedIndexChanged);
            // 
            // smartLabel21
            // 
            this.smartLabel21.AutoSize = true;
            this.smartLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel21.Location = new System.Drawing.Point(18, 153);
            this.smartLabel21.Name = "smartLabel21";
            this.smartLabel21.Size = new System.Drawing.Size(112, 13);
            this.smartLabel21.TabIndex = 204;
            this.smartLabel21.Text = "Department Type :";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(423, 153);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(38, 13);
            this.smartLabel5.TabIndex = 203;
            this.smartLabel5.Text = "Unit :";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.Blue;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(426, 173);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(73, 26);
            this.cboUnit.TabIndex = 201;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(280, 153);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(80, 13);
            this.smartLabel7.TabIndex = 202;
            this.smartLabel7.Text = "Department :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.Blue;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(280, 173);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(139, 26);
            this.cboDepartment.TabIndex = 198;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // txtHeadID
            // 
            this.txtHeadID.BackColor = System.Drawing.Color.Linen;
            this.txtHeadID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHeadID.Location = new System.Drawing.Point(353, 776);
            this.txtHeadID.Name = "txtHeadID";
            this.txtHeadID.ReadOnly = true;
            this.txtHeadID.Size = new System.Drawing.Size(92, 24);
            this.txtHeadID.TabIndex = 206;
            this.txtHeadID.TabStop = false;
            this.txtHeadID.Visible = false;
            // 
            // txtHeadTitle
            // 
            this.txtHeadTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadTitle.Location = new System.Drawing.Point(569, 173);
            this.txtHeadTitle.Multiline = true;
            this.txtHeadTitle.Name = "txtHeadTitle";
            this.txtHeadTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHeadTitle.Size = new System.Drawing.Size(542, 25);
            this.txtHeadTitle.TabIndex = 207;
            this.txtHeadTitle.TextChanged += new System.EventHandler(this.txtHeadTitle_TextChanged);
            this.txtHeadTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHeadTitle_KeyUp);
            // 
            // txtHeadTitleBeng
            // 
            this.txtHeadTitleBeng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadTitleBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadTitleBeng.Location = new System.Drawing.Point(18, 224);
            this.txtHeadTitleBeng.Multiline = true;
            this.txtHeadTitleBeng.Name = "txtHeadTitleBeng";
            this.txtHeadTitleBeng.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHeadTitleBeng.Size = new System.Drawing.Size(541, 26);
            this.txtHeadTitleBeng.TabIndex = 208;
            // 
            // txtPosSerial
            // 
            this.txtPosSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosSerial.Location = new System.Drawing.Point(717, 224);
            this.txtPosSerial.Name = "txtPosSerial";
            this.txtPosSerial.Size = new System.Drawing.Size(72, 24);
            this.txtPosSerial.TabIndex = 211;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefault.ForeColor = System.Drawing.Color.Black;
            this.chkDefault.Location = new System.Drawing.Point(798, 224);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(169, 22);
            this.chkDefault.TabIndex = 210;
            this.chkDefault.Text = "Is Default with Billing ?";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(467, 781);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(62, 13);
            this.smartLabel1.TabIndex = 211;
            this.smartLabel1.Text = "Head ID :";
            this.smartLabel1.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(566, 153);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(74, 13);
            this.smartLabel2.TabIndex = 212;
            this.smartLabel2.Text = "Head Title :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(15, 205);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(119, 13);
            this.smartLabel3.TabIndex = 213;
            this.smartLabel3.Text = "Head Title (Beng.) :";
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(717, 205);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(72, 13);
            this.smartLabel4.TabIndex = 214;
            this.smartLabel4.Text = "Pos Serial :";
            // 
            // txtHeadGroup
            // 
            this.txtHeadGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadGroup.Location = new System.Drawing.Point(241, 770);
            this.txtHeadGroup.Name = "txtHeadGroup";
            this.txtHeadGroup.Size = new System.Drawing.Size(85, 24);
            this.txtHeadGroup.TabIndex = 215;
            this.txtHeadGroup.Text = "0";
            this.txtHeadGroup.Visible = false;
            // 
            // lvEmerCollHead
            // 
            this.lvEmerCollHead.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvEmerCollHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmerCollHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmerCollHead.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmerCollHead.FullRowSelect = true;
            this.lvEmerCollHead.GridLines = true;
            this.lvEmerCollHead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmerCollHead.Location = new System.Drawing.Point(-1, 270);
            this.lvEmerCollHead.Name = "lvEmerCollHead";
            this.lvEmerCollHead.Size = new System.Drawing.Size(1124, 571);
            this.lvEmerCollHead.TabIndex = 215;
            this.lvEmerCollHead.UseCompatibleStateImageBehavior = false;
            this.lvEmerCollHead.View = System.Windows.Forms.View.Details;
            this.lvEmerCollHead.SelectedIndexChanged += new System.EventHandler(this.lvEmerCollHead_SelectedIndexChanged);
            this.lvEmerCollHead.Click += new System.EventHandler(this.lvEmerCollHead_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(502, 171);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(57, 26);
            this.btnShow.TabIndex = 216;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show Result Head";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtFee
            // 
            this.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(569, 224);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(143, 24);
            this.txtFee.TabIndex = 209;
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(566, 205);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(36, 13);
            this.smartLabel6.TabIndex = 218;
            this.smartLabel6.Text = "Fee :";
            // 
            // chkIsSelectable
            // 
            this.chkIsSelectable.AutoSize = true;
            this.chkIsSelectable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIsSelectable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkIsSelectable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsSelectable.ForeColor = System.Drawing.Color.Black;
            this.chkIsSelectable.Location = new System.Drawing.Point(979, 224);
            this.chkIsSelectable.Name = "chkIsSelectable";
            this.chkIsSelectable.Size = new System.Drawing.Size(119, 22);
            this.chkIsSelectable.TabIndex = 219;
            this.chkIsSelectable.Text = "Is Selectable ?";
            this.chkIsSelectable.UseVisualStyleBackColor = true;
            // 
            // frmEmeregencyCollectionHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1125, 829);
            this.Controls.Add(this.txtHeadGroup);
            this.Controls.Add(this.smartLabel1);
            this.Controls.Add(this.txtHeadID);
            this.isEnterTabAllow = true;
            this.Name = "frmEmeregencyCollectionHead";
            this.Load += new System.EventHandler(this.frmEmeregencyCollectionHead_Load);
            this.Controls.SetChildIndex(this.txtHeadID, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.smartLabel1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtHeadGroup, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartComboBox cboDepartmentGroup;
        private AtiqsControlLibrary.SmartLabel smartLabel22;
        private AtiqsControlLibrary.SmartComboBox cboDepartmentType;
        private AtiqsControlLibrary.SmartLabel smartLabel21;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartComboBox cboUnit;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartComboBox cboDepartment;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtHeadID;
        private AtiqsControlLibrary.SmartTextBox txtHeadTitleBeng;
        private AtiqsControlLibrary.SmartTextBox txtHeadTitle;
        private AtiqsControlLibrary.SmartCheckBox chkDefault;
        private AtiqsControlLibrary.SmartNumericTextBox txtPosSerial;
        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartNumericTextBox txtHeadGroup;
        private AtiqsControlLibrary.SmartListViewDetails lvEmerCollHead;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartNumericTextBox txtFee;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartCheckBox chkIsSelectable;
    }
}
