namespace AH.ModuleController.UI.OPR.Forms
{
    partial class frmReminder
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
            this.txtReminder = new AtiqsControlLibrary.SmartTextBox();
            this.Starttimer = new System.Windows.Forms.Timer(this.components);
            this.txtDisplay = new AtiqsControlLibrary.SmartTextBox();
            this.SuspendLayout();
            // 
            // txtReminder
            // 
            this.txtReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtReminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReminder.Location = new System.Drawing.Point(3, -7);
            this.txtReminder.Multiline = true;
            this.txtReminder.Name = "txtReminder";
            this.txtReminder.ReadOnly = true;
            this.txtReminder.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReminder.Size = new System.Drawing.Size(287, 10);
            this.txtReminder.TabIndex = 0;
            this.txtReminder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDisplay.Location = new System.Drawing.Point(3, 6);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplay.Size = new System.Drawing.Size(269, 126);
            this.txtDisplay.TabIndex = 1;
            // 
            // frmReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(274, 135);
            this.ControlBox = false;
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtReminder);
            this.Name = "frmReminder";
            this.Load += new System.EventHandler(this.frmReminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtiqsControlLibrary.SmartTextBox txtReminder;
        private System.Windows.Forms.Timer Starttimer;
        private AtiqsControlLibrary.SmartTextBox txtDisplay;
    }
}