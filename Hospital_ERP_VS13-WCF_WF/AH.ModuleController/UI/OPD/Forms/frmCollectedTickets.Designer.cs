namespace AH.ModuleController.UI.OPD.Forms
{
    partial class frmCollectedTickets
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
            this.txtUserId = new AtiqsControlLibrary.SmartTextBox();
            this.lvTicketList = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.btnShowTicketList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.smartLabel4 = new AtiqsControlLibrary.SmartLabel();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Location = new System.Drawing.Point(180, 9);
            this.frmLabel.Size = new System.Drawing.Size(212, 33);
            this.frmLabel.Text = "Collected Tickets";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.lvTicketList);
            this.pnlMain.Location = new System.Drawing.Point(0, 58);
            this.pnlMain.Size = new System.Drawing.Size(555, 416);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(555, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(44, 492);
            this.btnEdit.Size = new System.Drawing.Size(10, 14);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 494);
            this.btnSave.Size = new System.Drawing.Size(10, 14);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 492);
            this.btnDelete.Size = new System.Drawing.Size(10, 14);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(62, 494);
            this.btnNew.Size = new System.Drawing.Size(10, 14);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(424, 476);
            this.btnClose.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(28, 492);
            this.btnPrint.Size = new System.Drawing.Size(10, 14);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 516);
            this.groupBox1.Size = new System.Drawing.Size(555, 27);
            // 
            // txtUserId
            // 
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(89, 23);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(121, 24);
            this.txtUserId.TabIndex = 0;
            // 
            // lvTicketList
            // 
            this.lvTicketList.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvTicketList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTicketList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTicketList.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTicketList.FullRowSelect = true;
            this.lvTicketList.GridLines = true;
            this.lvTicketList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTicketList.Location = new System.Drawing.Point(0, 69);
            this.lvTicketList.Name = "lvTicketList";
            this.lvTicketList.Size = new System.Drawing.Size(553, 345);
            this.lvTicketList.TabIndex = 2;
            this.lvTicketList.UseCompatibleStateImageBehavior = false;
            this.lvTicketList.View = System.Windows.Forms.View.Details;
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(22, 27);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(58, 13);
            this.smartLabel1.TabIndex = 3;
            this.smartLabel1.Text = "User ID :";
            // 
            // btnShowTicketList
            // 
            this.btnShowTicketList.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowTicketList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTicketList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTicketList.ForeColor = System.Drawing.Color.White;
            this.btnShowTicketList.Location = new System.Drawing.Point(421, 12);
            this.btnShowTicketList.Name = "btnShowTicketList";
            this.btnShowTicketList.Size = new System.Drawing.Size(108, 45);
            this.btnShowTicketList.TabIndex = 3;
            this.btnShowTicketList.Text = "Show";
            this.btnShowTicketList.UseVisualStyleBackColor = false;
            this.btnShowTicketList.Click += new System.EventHandler(this.btnShowTicketList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.smartLabel4);
            this.groupBox2.Controls.Add(this.txtUserId);
            this.groupBox2.Controls.Add(this.btnShowTicketList);
            this.groupBox2.Controls.Add(this.smartLabel1);
            this.groupBox2.Location = new System.Drawing.Point(1, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 65);
            this.groupBox2.TabIndex = 237;
            this.groupBox2.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(267, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(123, 26);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Value = new System.DateTime(2015, 5, 5, 16, 24, 0, 0);
            // 
            // smartLabel4
            // 
            this.smartLabel4.AutoSize = true;
            this.smartLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.Location = new System.Drawing.Point(222, 27);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(42, 13);
            this.smartLabel4.TabIndex = 238;
            this.smartLabel4.Text = "Date :";
            // 
            // frmCollectedTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 543);
            this.isEnterTabAllow = true;
            this.Name = "frmCollectedTickets";
            this.Load += new System.EventHandler(this.frmCollectedTickets_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartListViewDetails lvTicketList;
        private AtiqsControlLibrary.SmartTextBox txtUserId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowTicketList;
        private AtiqsControlLibrary.SmartLabel smartLabel4;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}