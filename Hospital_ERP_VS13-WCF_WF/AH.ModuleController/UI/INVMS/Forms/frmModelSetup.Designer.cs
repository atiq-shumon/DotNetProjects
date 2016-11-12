namespace AH.ModuleController.UI.INVMS.Forms
{
    partial class frmModelSetup
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
            this.smartLabel1 = new AtiqsControlLibrary.SmartLabel();
            this.txtModelID = new AtiqsControlLibrary.SmartReadOnlyTextBox(this.components);
            this.lvModelDetails = new AtiqsControlLibrary.SmartListViewDetails();
            this.smartLabel7 = new AtiqsControlLibrary.SmartLabel();
            this.txtRemarks = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel3 = new AtiqsControlLibrary.SmartLabel();
            this.txtModelNameBang = new AtiqsControlLibrary.SmartTextBox();
            this.smartLabel2 = new AtiqsControlLibrary.SmartLabel();
            this.txtModelName = new AtiqsControlLibrary.SmartTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLabel
            // 
            this.frmLabel.Size = new System.Drawing.Size(173, 33);
            this.frmLabel.Text = "Model Details";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.smartLabel1);
            this.pnlMain.Controls.Add(this.txtModelID);
            this.pnlMain.Controls.Add(this.lvModelDetails);
            this.pnlMain.Controls.Add(this.smartLabel7);
            this.pnlMain.Controls.Add(this.txtRemarks);
            this.pnlMain.Controls.Add(this.smartLabel3);
            this.pnlMain.Controls.Add(this.txtModelNameBang);
            this.pnlMain.Controls.Add(this.smartLabel2);
            this.pnlMain.Controls.Add(this.txtModelName);
            this.pnlMain.Location = new System.Drawing.Point(0, 57);
            this.pnlMain.Size = new System.Drawing.Size(845, 508);
            // 
            // pnlTop
            // 
            this.pnlTop.Size = new System.Drawing.Size(845, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(623, 569);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(514, 569);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(48, 568);
            this.btnDelete.Size = new System.Drawing.Size(37, 39);
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(405, 569);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(733, 569);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(93, 569);
            this.btnPrint.Size = new System.Drawing.Size(29, 39);
            this.btnPrint.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 608);
            this.groupBox1.Size = new System.Drawing.Size(845, 23);
            // 
            // smartLabel1
            // 
            this.smartLabel1.AutoSize = true;
            this.smartLabel1.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.Location = new System.Drawing.Point(97, 19);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(27, 15);
            this.smartLabel1.TabIndex = 81;
            this.smartLabel1.Text = "ID :";
            // 
            // txtModelID
            // 
            this.txtModelID.BackColor = System.Drawing.Color.Linen;
            this.txtModelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtModelID.Location = new System.Drawing.Point(137, 16);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.ReadOnly = true;
            this.txtModelID.Size = new System.Drawing.Size(172, 24);
            this.txtModelID.TabIndex = 80;
            this.txtModelID.TabStop = false;
            // 
            // lvModelDetails
            // 
            this.lvModelDetails.BackColor = System.Drawing.Color.LemonChiffon;
            this.lvModelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvModelDetails.CheckBoxes = true;
            this.lvModelDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvModelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvModelDetails.FullRowSelect = true;
            this.lvModelDetails.GridLines = true;
            this.lvModelDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvModelDetails.Location = new System.Drawing.Point(-1, 165);
            this.lvModelDetails.Name = "lvModelDetails";
            this.lvModelDetails.Size = new System.Drawing.Size(844, 342);
            this.lvModelDetails.TabIndex = 79;
            this.lvModelDetails.TabStop = false;
            this.lvModelDetails.UseCompatibleStateImageBehavior = false;
            this.lvModelDetails.View = System.Windows.Forms.View.Details;
            this.lvModelDetails.SelectedIndexChanged += new System.EventHandler(this.lvModelDetails_SelectedIndexChanged);
            // 
            // smartLabel7
            // 
            this.smartLabel7.AutoSize = true;
            this.smartLabel7.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel7.Location = new System.Drawing.Point(59, 106);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(65, 15);
            this.smartLabel7.TabIndex = 78;
            this.smartLabel7.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(137, 103);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(424, 56);
            this.txtRemarks.TabIndex = 75;
            // 
            // smartLabel3
            // 
            this.smartLabel3.AutoSize = true;
            this.smartLabel3.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel3.Location = new System.Drawing.Point(23, 77);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(95, 15);
            this.smartLabel3.TabIndex = 77;
            this.smartLabel3.Text = "Name( Bangla) :";
            // 
            // txtModelNameBang
            // 
            this.txtModelNameBang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelNameBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelNameBang.Location = new System.Drawing.Point(137, 74);
            this.txtModelNameBang.Name = "txtModelNameBang";
            this.txtModelNameBang.Size = new System.Drawing.Size(357, 24);
            this.txtModelNameBang.TabIndex = 74;
            // 
            // smartLabel2
            // 
            this.smartLabel2.AutoSize = true;
            this.smartLabel2.BackColor = System.Drawing.Color.Transparent;
            this.smartLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.Location = new System.Drawing.Point(76, 48);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(45, 15);
            this.smartLabel2.TabIndex = 76;
            this.smartLabel2.Text = "Name :";
            // 
            // txtModelName
            // 
            this.txtModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.Location = new System.Drawing.Point(137, 45);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(357, 24);
            this.txtModelName.TabIndex = 73;
            // 
            // frmModelSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(845, 631);
            this.isEnterTabAllow = true;
            this.Name = "frmModelSetup";
            this.Load += new System.EventHandler(this.frmModelSetup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtiqsControlLibrary.SmartLabel smartLabel1;
        private AtiqsControlLibrary.SmartReadOnlyTextBox txtModelID;
        private AtiqsControlLibrary.SmartListViewDetails lvModelDetails;
        private AtiqsControlLibrary.SmartLabel smartLabel7;
        private AtiqsControlLibrary.SmartTextBox txtRemarks;
        private AtiqsControlLibrary.SmartLabel smartLabel3;
        private AtiqsControlLibrary.SmartTextBox txtModelNameBang;
        private AtiqsControlLibrary.SmartLabel smartLabel2;
        private AtiqsControlLibrary.SmartTextBox txtModelName;
    }
}
