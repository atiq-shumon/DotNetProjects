namespace AH.ModuleController.UI.OPR
{
    partial class frmChecklistconfig
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
            this.smartComboBox1 = new AtiqsControlLibrary.SmartComboBox();
            this.cboOperationType = new AtiqsControlLibrary.SmartComboBox();
            this.lvwItems = new AtiqsControlLibrary.SmartListViewDetails();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.DGdown = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtOTDate = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel6 = new AtiqsControlLibrary.SmartLabel();
            this.txtEndtime = new AtiqsControlLibrary.SmartTextBox();
            this.txtStarttime = new AtiqsControlLibrary.SmartTextBox();
            this.txtPatientName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.lvwLoadCheklist = new AtiqsControlLibrary.SmartListViewDetails();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.dteChecklistDate = new System.Windows.Forms.DateTimePicker();
            this.txtItemCode = new AtiqsControlLibrary.SmartTextBox();
            this.txtPatientRegNo = new AtiqsControlLibrary.SmartTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopClose
            // 
            this.btnTopClose.TabIndex = 10;
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(448, 8);
            this.frmLabel.Size = new System.Drawing.Size(286, 33);
            this.frmLabel.TabIndex = 9;
            this.frmLabel.Text = "Checklist Configuration";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.txtPatientRegNo);
            this.pnlMain.Controls.Add(this.dteChecklistDate);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.lvwLoadCheklist);
            this.pnlMain.Controls.Add(this.txtPatientName);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtStarttime);
            this.pnlMain.Controls.Add(this.txtEndtime);
            this.pnlMain.Controls.Add(this.smartLabel6);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtOTDate);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.DGdown);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.lvwItems);
            this.pnlMain.Controls.Add(this.cboOperationType);
            this.pnlMain.Controls.Add(this.smartComboBox1);
            this.pnlMain.Size = new System.Drawing.Size(1188, 809);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1192, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(479, 731);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 731);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(592, 731);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(253, 731);
            this.btnNew.TabIndex = 8;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(814, 731);
            this.btnClose.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(703, 731);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 773);
            this.groupBox1.Size = new System.Drawing.Size(1192, 25);
            // 
            // smartComboBox1
            // 
            this.smartComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smartComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartComboBox1.ForeColor = System.Drawing.Color.Blue;
            this.smartComboBox1.FormattingEnabled = true;
            this.smartComboBox1.Location = new System.Drawing.Point(0, 0);
            this.smartComboBox1.Name = "smartComboBox1";
            this.smartComboBox1.Size = new System.Drawing.Size(121, 26);
            this.smartComboBox1.TabIndex = 0;
            // 
            // cboOperationType
            // 
            this.cboOperationType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperationType.ForeColor = System.Drawing.Color.Blue;
            this.cboOperationType.FormattingEnabled = true;
            this.cboOperationType.Location = new System.Drawing.Point(144, 156);
            this.cboOperationType.Name = "cboOperationType";
            this.cboOperationType.Size = new System.Drawing.Size(262, 26);
            this.cboOperationType.TabIndex = 0;
            // 
            // lvwItems
            // 
            this.lvwItems.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwItems.CheckBoxes = true;
            this.lvwItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwItems.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwItems.FullRowSelect = true;
            this.lvwItems.GridLines = true;
            this.lvwItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwItems.Location = new System.Drawing.Point(11, 303);
            this.lvwItems.Name = "lvwItems";
            this.lvwItems.Size = new System.Drawing.Size(905, 259);
            this.lvwItems.TabIndex = 2;
            this.lvwItems.UseCompatibleStateImageBehavior = false;
            this.lvwItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Code";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 760;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.smartLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(16, 159);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(124, 16);
            this.smartLabel1.TabIndex = 7;
            this.smartLabel1.Text = "Operation Type:";
            // 
            // DGdown
            // 
            this.DGdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdown.Location = new System.Drawing.Point(15, 595);
            this.DGdown.Name = "DGdown";
            this.DGdown.Size = new System.Drawing.Size(904, 206);
            this.DGdown.TabIndex = 3;
            this.DGdown.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGdown_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(879, 564);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 28);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.smartLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(529, 158);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(63, 16);
            this.smartLabel2.TabIndex = 11;
            this.smartLabel2.Text = "Reg No:";
            // 
            // txtOTDate
            // 
            this.txtOTDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOTDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOTDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTDate.ForeColor = System.Drawing.Color.Blue;
            this.txtOTDate.Location = new System.Drawing.Point(598, 190);
            this.txtOTDate.Name = "txtOTDate";
            this.txtOTDate.ReadOnly = true;
            this.txtOTDate.Size = new System.Drawing.Size(262, 24);
            this.txtOTDate.TabIndex = 14;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(526, 193);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(66, 14);
            this.smartLabel4.TabIndex = 15;
            this.smartLabel4.Text = "OT Date:";
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(52, 263);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(88, 16);
            this.smartLabel5.TabIndex = 16;
            this.smartLabel5.Text = "Start Time:";
            // 
            // smartLabel6
            // 
            this.smartLabel6.AutoSize = true;
            this.smartLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.Location = new System.Drawing.Point(377, 262);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(72, 14);
            this.smartLabel6.TabIndex = 17;
            this.smartLabel6.Text = "End Time:";
            // 
            // txtEndtime
            // 
            this.txtEndtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEndtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndtime.ForeColor = System.Drawing.Color.Blue;
            this.txtEndtime.Location = new System.Drawing.Point(452, 259);
            this.txtEndtime.Name = "txtEndtime";
            this.txtEndtime.ReadOnly = true;
            this.txtEndtime.Size = new System.Drawing.Size(262, 24);
            this.txtEndtime.TabIndex = 18;
            // 
            // txtStarttime
            // 
            this.txtStarttime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStarttime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStarttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStarttime.ForeColor = System.Drawing.Color.Blue;
            this.txtStarttime.Location = new System.Drawing.Point(144, 259);
            this.txtStarttime.Name = "txtStarttime";
            this.txtStarttime.ReadOnly = true;
            this.txtStarttime.Size = new System.Drawing.Size(212, 24);
            this.txtStarttime.TabIndex = 19;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.Color.Red;
            this.txtPatientName.Location = new System.Drawing.Point(144, 231);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(784, 24);
            this.txtPatientName.TabIndex = 21;
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(39, 234);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(101, 14);
            this.smartLabel7.TabIndex = 20;
            this.smartLabel7.Text = "Patient Name:";
            // 
            // lvwLoadCheklist
            // 
            this.lvwLoadCheklist.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvwLoadCheklist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwLoadCheklist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvwLoadCheklist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvwLoadCheklist.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLoadCheklist.FullRowSelect = true;
            this.lvwLoadCheklist.GridLines = true;
            this.lvwLoadCheklist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwLoadCheklist.Location = new System.Drawing.Point(935, 150);
            this.lvwLoadCheklist.Name = "lvwLoadCheklist";
            this.lvwLoadCheklist.Size = new System.Drawing.Size(248, 650);
            this.lvwLoadCheklist.TabIndex = 22;
            this.lvwLoadCheklist.UseCompatibleStateImageBehavior = false;
            this.lvwLoadCheklist.View = System.Windows.Forms.View.Details;
            this.lvwLoadCheklist.SelectedIndexChanged += new System.EventHandler(this.lvwLoadCheklist_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Checklist No";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Reg No";
            this.columnHeader4.Width = 245;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(23, 197);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(115, 14);
            this.smartLabel3.TabIndex = 23;
            this.smartLabel3.Text = "Check List Date:";
            // 
            // dteChecklistDate
            // 
            this.dteChecklistDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteChecklistDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteChecklistDate.Location = new System.Drawing.Point(144, 194);
            this.dteChecklistDate.Name = "dteChecklistDate";
            this.dteChecklistDate.Size = new System.Drawing.Size(262, 26);
            this.dteChecklistDate.TabIndex = 24;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(20, 731);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 24);
            this.txtItemCode.TabIndex = 15;
            this.txtItemCode.Visible = false;
            // 
            // txtPatientRegNo
            // 
            this.txtPatientRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientRegNo.Location = new System.Drawing.Point(599, 157);
            this.txtPatientRegNo.Name = "txtPatientRegNo";
            this.txtPatientRegNo.Size = new System.Drawing.Size(255, 24);
            this.txtPatientRegNo.TabIndex = 25;
            this.txtPatientRegNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRegNo_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(858, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 26);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Serach";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmChecklistconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1192, 798);
            this.Controls.Add(this.txtItemCode);
            this.isEnterTabAllow = true;
            this.Name = "frmChecklistconfig";
            this.Load += new System.EventHandler(this.frmChecklistconfig_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtItemCode, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private System.Windows.Forms.Button button1;
        private AtiqsControlLibrary.SmartListViewDetails lvwItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private AtiqsControlLibrary.SmartComboBox cboOperationType;
        private AtiqsControlLibrary.SmartComboBox smartComboBox1;
        private System.Windows.Forms.DataGridView DGdown;
        private System.Windows.Forms.Button btnAdd;
        private AtiqsControlLibrary.SmartTextBox txtPatientName;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtStarttime;
        private AtiqsControlLibrary.SmartTextBox txtEndtime;
        private AtiqsControlLibrary.SmartLabel smartLabel6;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtOTDate;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartListViewDetails lvwLoadCheklist;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DateTimePicker dteChecklistDate;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtItemCode;
        private AtiqsControlLibrary.SmartTextBox txtPatientRegNo;
        private System.Windows.Forms.Button btnSearch;
    }
}
