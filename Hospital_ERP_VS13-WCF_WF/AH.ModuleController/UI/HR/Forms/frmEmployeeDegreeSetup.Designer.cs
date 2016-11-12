namespace AH.ModuleController.UI.HR.Forms
{
    partial class frmEmployeeDegreeSetup
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
            this.txtEmpID = new AtiqsControlLibrary.SmartTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblInfo = new AtiqsControlLibrary.SmartLabel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtDegreeLine1 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegreeLine2 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegreeLine4 = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel5 = new AtiqsControlLibrary.SmartLabel();
            this.txtDegreeLine3 = new AtiqsControlLibrary.SmartTextBox();
            this.lvEmployeeDegree = new AtiqsControlLibrary.SmartListViewDetails();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(334, 9);
            this.frmLabel.Size = new System.Drawing.Size(299, 33);
            this.frmLabel.Text = "Employee Degree Setup";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvEmployeeDegree);
            this.pnlMain.Controls.Add(this.smartLabel4);
            this.pnlMain.Controls.Add(this.txtDegreeLine4);
            this.pnlMain.Controls.Add(this.smartLabel5);
            this.pnlMain.Controls.Add(this.txtDegreeLine3);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtDegreeLine2);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtDegreeLine1);
            this.pnlMain.Controls.Add(this.btnShowAll);
            this.pnlMain.Controls.Add(this.lblInfo);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtEmpID);
            this.pnlMain.Size = new System.Drawing.Size(991, 696);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(991, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(763, 615);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(650, 615);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(5, 614);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(537, 615);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(877, 615);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(116, 614);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 654);
            this.groupBox1.Size = new System.Drawing.Size(991, 25);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(14, 152);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(86, 13);
            this.smartLabel1.TabIndex = 3;
            this.smartLabel1.Text = "Employee ID :";
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(15, 170);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(107, 24);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.Leave += new System.EventHandler(this.txtEmpID_Leave);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(128, 169);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(58, 27);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(194, 170);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 13);
            this.lblInfo.TabIndex = 153;
            this.lblInfo.Text = "Info";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(769, 152);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(209, 27);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Show All Employee Degree";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Visible = false;
            // 
            // txtDegreeLine1
            // 
            this.txtDegreeLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegreeLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegreeLine1.Location = new System.Drawing.Point(15, 222);
            this.txtDegreeLine1.Multiline = true;
            this.txtDegreeLine1.Name = "txtDegreeLine1";
            this.txtDegreeLine1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDegreeLine1.Size = new System.Drawing.Size(472, 48);
            this.txtDegreeLine1.TabIndex = 4;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(14, 204);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(95, 13);
            this.smartLabel2.TabIndex = 156;
            this.smartLabel2.Text = "Degree Line 1 :";
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(504, 204);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(95, 13);
            this.smartLabel3.TabIndex = 158;
            this.smartLabel3.Text = "Degree Line 2 :";
            // 
            // txtDegreeLine2
            // 
            this.txtDegreeLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegreeLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegreeLine2.Location = new System.Drawing.Point(505, 222);
            this.txtDegreeLine2.Multiline = true;
            this.txtDegreeLine2.Name = "txtDegreeLine2";
            this.txtDegreeLine2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDegreeLine2.Size = new System.Drawing.Size(473, 48);
            this.txtDegreeLine2.TabIndex = 5;
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(504, 276);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(95, 13);
            this.smartLabel4.TabIndex = 162;
            this.smartLabel4.Text = "Degree Line 4 :";
            // 
            // txtDegreeLine4
            // 
            this.txtDegreeLine4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegreeLine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegreeLine4.Location = new System.Drawing.Point(505, 294);
            this.txtDegreeLine4.Multiline = true;
            this.txtDegreeLine4.Name = "txtDegreeLine4";
            this.txtDegreeLine4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDegreeLine4.Size = new System.Drawing.Size(473, 49);
            this.txtDegreeLine4.TabIndex = 7;
            // 
            // smartLabel5
            // 
            this.smartLabel5.AutoSize = true;
            this.smartLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.Location = new System.Drawing.Point(14, 276);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(95, 13);
            this.smartLabel5.TabIndex = 160;
            this.smartLabel5.Text = "Degree Line 3 :";
            // 
            // txtDegreeLine3
            // 
            this.txtDegreeLine3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegreeLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegreeLine3.Location = new System.Drawing.Point(15, 294);
            this.txtDegreeLine3.Multiline = true;
            this.txtDegreeLine3.Name = "txtDegreeLine3";
            this.txtDegreeLine3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDegreeLine3.Size = new System.Drawing.Size(472, 49);
            this.txtDegreeLine3.TabIndex = 6;
            // 
            // lvEmployeeDegree
            // 
            this.lvEmployeeDegree.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvEmployeeDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmployeeDegree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmployeeDegree.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployeeDegree.FullRowSelect = true;
            this.lvEmployeeDegree.GridLines = true;
            this.lvEmployeeDegree.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmployeeDegree.Location = new System.Drawing.Point(-1, 360);
            this.lvEmployeeDegree.Name = "lvEmployeeDegree";
            this.lvEmployeeDegree.Size = new System.Drawing.Size(991, 335);
            this.lvEmployeeDegree.TabIndex = 163;
            this.lvEmployeeDegree.UseCompatibleStateImageBehavior = false;
            this.lvEmployeeDegree.View = System.Windows.Forms.View.Details;
            this.lvEmployeeDegree.SelectedIndexChanged += new System.EventHandler(this.lvEmployeeDegree_SelectedIndexChanged);
            this.lvEmployeeDegree.Click += new System.EventHandler(this.lvEmployeeDegree_Click);
            // 
            // frmEmployeeDegreeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(991, 679);
            this.isEnterTabAllow = true;
            this.Name = "frmEmployeeDegreeSetup";
            this.Load += new System.EventHandler(this.frmEmployeeDegreeSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartTextBox txtEmpID;
        private System.Windows.Forms.Button btnShow;
        private AtiqsControlLibrary.SmartLabel lblInfo;
        private System.Windows.Forms.Button btnShowAll;
        private AtiqsControlLibrary.SmartTextBox txtDegreeLine1;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtDegreeLine2;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private AtiqsControlLibrary.SmartTextBox txtDegreeLine4;
        private AtiqsControlLibrary.SmartLabel smartLabel5;
        private AtiqsControlLibrary.SmartTextBox txtDegreeLine3;
        private AtiqsControlLibrary.SmartListViewDetails lvEmployeeDegree;
    }
}
