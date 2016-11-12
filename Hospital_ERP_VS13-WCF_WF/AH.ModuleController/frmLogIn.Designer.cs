namespace AH.ModuleController
{
    partial class frmLogIn
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
            this.atiqsLogInUserControl1 = new AtiqsControlLibrary.AtiqsLogInUserControl();
            this.SuspendLayout();
            // 
            // atiqsLogInUserControl1
            // 
            this.atiqsLogInUserControl1.AuthenticatedObjects = null;
            this.atiqsLogInUserControl1.BackColor = System.Drawing.Color.DimGray;
            this.atiqsLogInUserControl1.IsPrefilled = false;
            this.atiqsLogInUserControl1.Location = new System.Drawing.Point(402, 298);
            this.atiqsLogInUserControl1.LogInAs = null;
            this.atiqsLogInUserControl1.MismatchText = null;
            this.atiqsLogInUserControl1.ModuleName = null;
            this.atiqsLogInUserControl1.ModuleNames = null;
            this.atiqsLogInUserControl1.Name = "atiqsLogInUserControl1";
            this.atiqsLogInUserControl1.Password = null;
            this.atiqsLogInUserControl1.Size = new System.Drawing.Size(493, 491);
            this.atiqsLogInUserControl1.TabIndex = 0;
            this.atiqsLogInUserControl1.UserID = null;
            this.atiqsLogInUserControl1.btnLogIn_Clicked += new AtiqsControlLibrary.AtiqsLogInUserControl.LogInButtonClickHandler(this.atiqsLogInUserControl1_btnLogIn_Clicked_1);
            this.atiqsLogInUserControl1.Load += new System.EventHandler(this.atiqsLogInUserControl1_Load);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::AH.ModuleController.Properties.Resources.blurry_circles_abstract_hd_wallpaper_1920x1080_45281;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1303, 871);
            this.Controls.Add(this.atiqsLogInUserControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public AtiqsControlLibrary.AtiqsLogInUserControl atiqsLogInUserControl1;










    }
}