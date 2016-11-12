namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOTScheduling
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkOTCalender = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dteOTSchedulingDate = new System.Windows.Forms.DateTimePicker();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(186, 33);
            this.frmLabel.Text = "OT Scheduling";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.comboBox1);
            this.pnlMain.Size = new System.Drawing.Size(863, 477);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(863, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(412, 396);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 396);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(525, 396);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(186, 396);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(747, 396);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(636, 396);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 435);
            this.groupBox1.Size = new System.Drawing.Size(863, 25);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.chkOTCalender);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dteOTSchedulingDate);
            this.groupBox2.Location = new System.Drawing.Point(125, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(37, 189);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(120, 18);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "OT Dash Board";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(37, 151);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(107, 18);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "OT Bar Chart";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkOTCalender
            // 
            this.chkOTCalender.AutoSize = true;
            this.chkOTCalender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOTCalender.Location = new System.Drawing.Point(37, 116);
            this.chkOTCalender.Name = "chkOTCalender";
            this.chkOTCalender.Size = new System.Drawing.Size(104, 18);
            this.chkOTCalender.TabIndex = 2;
            this.chkOTCalender.Text = "OT Calender";
            this.chkOTCalender.UseVisualStyleBackColor = true;
            this.chkOTCalender.CheckedChanged += new System.EventHandler(this.chkOTCalender_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OT Date:";
            // 
            // dteOTSchedulingDate
            // 
            this.dteOTSchedulingDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteOTSchedulingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteOTSchedulingDate.Location = new System.Drawing.Point(224, 58);
            this.dteOTSchedulingDate.Name = "dteOTSchedulingDate";
            this.dteOTSchedulingDate.Size = new System.Drawing.Size(200, 22);
            this.dteOTSchedulingDate.TabIndex = 0;
            // 
            // frmOTScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(861, 469);
            this.isEnterTabAllow = true;
            this.Name = "frmOTScheduling";
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chkOTCalender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dteOTSchedulingDate;
        private System.Windows.Forms.Button button1;
    }
}
