namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmOtMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtMap));
            this.btnOT1 = new System.Windows.Forms.Button();
            this.btnOT2 = new System.Windows.Forms.Button();
            this.btnOT3 = new System.Windows.Forms.Button();
            this.DG = new System.Windows.Forms.DataGridView();
            this.lblchart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.Controls.Add(this.lblchart);
            this.pnlMain.Controls.Add(this.DG);
            this.pnlMain.Controls.Add(this.btnOT3);
            this.pnlMain.Controls.Add(this.btnOT2);
            this.pnlMain.Controls.Add(this.btnOT1);
            this.pnlMain.Location = new System.Drawing.Point(0, -24);
            this.pnlMain.Size = new System.Drawing.Size(1783, 894);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(1783, 9);
            this.pnlTop.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1215, 857);
            this.btnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1102, 857);
            this.btnSave.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1328, 857);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(989, 857);
            this.btnNew.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1550, 857);
            this.btnClose.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1439, 857);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 896);
            this.groupBox1.Size = new System.Drawing.Size(1783, 25);
            this.groupBox1.Visible = false;
            // 
            // btnOT1
            // 
            this.btnOT1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOT1.Location = new System.Drawing.Point(627, 362);
            this.btnOT1.Name = "btnOT1";
            this.btnOT1.Size = new System.Drawing.Size(75, 34);
            this.btnOT1.TabIndex = 0;
            this.btnOT1.UseVisualStyleBackColor = false;
            this.btnOT1.Click += new System.EventHandler(this.btnOT1_Click);
            // 
            // btnOT2
            // 
            this.btnOT2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOT2.Location = new System.Drawing.Point(1079, 402);
            this.btnOT2.Name = "btnOT2";
            this.btnOT2.Size = new System.Drawing.Size(75, 34);
            this.btnOT2.TabIndex = 1;
            this.btnOT2.UseVisualStyleBackColor = false;
            this.btnOT2.Click += new System.EventHandler(this.btnOT2_Click);
            // 
            // btnOT3
            // 
            this.btnOT3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOT3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOT3.Location = new System.Drawing.Point(1438, 393);
            this.btnOT3.Name = "btnOT3";
            this.btnOT3.Size = new System.Drawing.Size(75, 34);
            this.btnOT3.TabIndex = 2;
            this.btnOT3.UseVisualStyleBackColor = false;
            this.btnOT3.Click += new System.EventHandler(this.btnOT3_Click);
            // 
            // DG
            // 
            this.DG.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DG.Location = new System.Drawing.Point(10, 55);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(1714, 115);
            this.DG.TabIndex = 3;
            // 
            // lblchart
            // 
            this.lblchart.AutoSize = true;
            this.lblchart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchart.ForeColor = System.Drawing.Color.Red;
            this.lblchart.Location = new System.Drawing.Point(746, 35);
            this.lblchart.Name = "lblchart";
            this.lblchart.Size = new System.Drawing.Size(43, 14);
            this.lblchart.TabIndex = 4;
            this.lblchart.Text = "Chart";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmOtMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1751, 886);
            this.Name = "frmOtMap";
            this.Load += new System.EventHandler(this.frmOtMap_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOT3;
        private System.Windows.Forms.Button btnOT2;
        private System.Windows.Forms.Button btnOT1;
        private System.Windows.Forms.Label lblchart;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
