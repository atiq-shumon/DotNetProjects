namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    partial class frmPatientDetails
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
            this.listPatientDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.lblCellPhoneNumber = new AtiqsControlLibrary.SmartLabel();
            this.txtPhoneNumber = new AtiqsControlLibrary.SmartNumericTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientName = new AtiqsControlLibrary.SmartTextBox();
            this.lblPatientName = new AtiqsControlLibrary.SmartLabel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFullInfo = new System.Windows.Forms.Button();
            this.txtFathersName = new AtiqsControlLibrary.SmartTextBox();
            this.lblMotherName = new AtiqsControlLibrary.SmartLabel();
            this.lblFatherName = new AtiqsControlLibrary.SmartLabel();
            this.txtDOB = new AtiqsControlLibrary.SmartDateTextBox();
            this.txtMothersName = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(338, 9);
            this.frmLabel.Size = new System.Drawing.Size(185, 33);
            this.frmLabel.Text = "Patient Search";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.listPatientDetails);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(863, 513);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(37, 587);
            this.btnEdit.Size = new System.Drawing.Size(11, 14);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 587);
            this.btnSave.Size = new System.Drawing.Size(11, 14);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(51, 587);
            this.btnDelete.Size = new System.Drawing.Size(11, 14);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(7, 587);
            this.btnNew.Size = new System.Drawing.Size(11, 14);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(733, 577);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(68, 587);
            this.btnPrint.Size = new System.Drawing.Size(11, 14);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 616);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // listPatientDetails
            // 
            this.listPatientDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.listPatientDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPatientDetails.CheckBoxes = true;
            this.listPatientDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listPatientDetails.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPatientDetails.FullRowSelect = true;
            this.listPatientDetails.GridLines = true;
            this.listPatientDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listPatientDetails.Location = new System.Drawing.Point(1, 150);
            this.listPatientDetails.Name = "listPatientDetails";
            this.listPatientDetails.Size = new System.Drawing.Size(859, 361);
            this.listPatientDetails.TabIndex = 18;
            this.listPatientDetails.UseCompatibleStateImageBehavior = false;
            this.listPatientDetails.View = System.Windows.Forms.View.Details;
            this.listPatientDetails.DoubleClick += new System.EventHandler(this.listPatientDetails_DoubleClick);
            // 
            // lblCellPhoneNumber
            // 
            this.lblCellPhoneNumber.AutoSize = true;
            this.lblCellPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCellPhoneNumber.Location = new System.Drawing.Point(50, 84);
            this.lblCellPhoneNumber.Name = "lblCellPhoneNumber";
            this.lblCellPhoneNumber.Size = new System.Drawing.Size(123, 13);
            this.lblCellPhoneNumber.TabIndex = 20;
            this.lblCellPhoneNumber.Text = "Cell Phone Number :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(184, 79);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(277, 24);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(500, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 43);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(184, 17);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(277, 24);
            this.txtPatientName.TabIndex = 1;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(81, 22);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(91, 13);
            this.lblPatientName.TabIndex = 19;
            this.lblPatientName.Text = "Patient Name :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::AH.ModuleController.Properties.Resources.Refresh_Icon;
            this.btnRefresh.Location = new System.Drawing.Point(631, 45);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(48, 42);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFullInfo
            // 
            this.btnFullInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFullInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFullInfo.ForeColor = System.Drawing.Color.White;
            this.btnFullInfo.Location = new System.Drawing.Point(699, 47);
            this.btnFullInfo.Name = "btnFullInfo";
            this.btnFullInfo.Size = new System.Drawing.Size(137, 40);
            this.btnFullInfo.TabIndex = 7;
            this.btnFullInfo.Text = "Full Information";
            this.btnFullInfo.UseVisualStyleBackColor = false;
            this.btnFullInfo.Click += new System.EventHandler(this.btnFullInfo_Click);
            // 
            // txtFathersName
            // 
            this.txtFathersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFathersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFathersName.Location = new System.Drawing.Point(184, 48);
            this.txtFathersName.Name = "txtFathersName";
            this.txtFathersName.Size = new System.Drawing.Size(277, 24);
            this.txtFathersName.TabIndex = 2;
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMotherName.Location = new System.Drawing.Point(129, 588);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(99, 13);
            this.lblMotherName.TabIndex = 98;
            this.lblMotherName.Text = "Mother\'s Name :";
            this.lblMotherName.Visible = false;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFatherName.Location = new System.Drawing.Point(77, 52);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(96, 13);
            this.lblFatherName.TabIndex = 97;
            this.lblFatherName.Text = "Father\'s Name :";
            // 
            // txtDOB
            // 
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDOB.Location = new System.Drawing.Point(184, 109);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(113, 24);
            this.txtDOB.TabIndex = 4;
            this.txtDOB.ValidatingType = typeof(System.DateTime);
            // 
            // txtMothersName
            // 
            this.txtMothersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMothersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMothersName.Location = new System.Drawing.Point(227, 583);
            this.txtMothersName.Name = "txtMothersName";
            this.txtMothersName.Size = new System.Drawing.Size(11, 24);
            this.txtMothersName.TabIndex = 108;
            this.txtMothersName.Visible = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(86, 114);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(87, 13);
            this.smartLabel2.TabIndex = 99;
            this.smartLabel2.Text = "Date of Birth :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.smartLabel2);
            this.groupBox2.Controls.Add(this.lblPatientName);
            this.groupBox2.Controls.Add(this.txtDOB);
            this.groupBox2.Controls.Add(this.lblCellPhoneNumber);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Controls.Add(this.txtFathersName);
            this.groupBox2.Controls.Add(this.txtPhoneNumber);
            this.groupBox2.Controls.Add(this.lblFatherName);
            this.groupBox2.Controls.Add(this.btnFullInfo);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 143);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            // 
            // frmPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 641);
            this.Controls.Add(this.txtMothersName);
            this.Controls.Add(this.lblMotherName);
            this.isEnterTabAllow = true;
            this.Name = "frmPatientDetails";
            this.Load += new System.EventHandler(this.frmPatientDetails_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.lblMotherName, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.txtMothersName, 0);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartListViewDetails listPatientDetails;
        private AtiqsControlLibrary.SmartNumericTextBox txtPhoneNumber;
        private AtiqsControlLibrary.SmartLabel lblCellPhoneNumber;
        private System.Windows.Forms.Button btnSearch;
        private AtiqsControlLibrary.SmartTextBox txtPatientName;
        private AtiqsControlLibrary.SmartLabel lblPatientName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFullInfo;
        private AtiqsControlLibrary.SmartTextBox txtFathersName;
        private AtiqsControlLibrary.SmartLabel lblMotherName;
        private AtiqsControlLibrary.SmartLabel lblFatherName;
        private AtiqsControlLibrary.SmartDateTextBox txtDOB;
        private AtiqsControlLibrary.SmartTextBox txtMothersName;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}