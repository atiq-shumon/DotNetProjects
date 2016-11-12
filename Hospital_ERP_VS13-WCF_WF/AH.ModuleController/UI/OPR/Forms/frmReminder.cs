using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmReminder : Form
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        #region "Display"
        public string strDisplay { set; get; }
        #endregion
        #region "Reminder"
        public frmReminder()
        {
            InitializeComponent();
            start();
            this.StartPosition = FormStartPosition.Manual;
        }
        #endregion
        #region "Start"
        void start()
        {
            
            GetDisplay();
            //if (txtDisplay.Text != "")
            //{
                Starttimer.Tick += new EventHandler(Popuptimer_Tick);
                Starttimer.Enabled = true;
                Starttimer.Interval = 8000;
                Starttimer.Start();
            //}
            //else
            //{
            //    Starttimer.Interval = 500;
            //}
        
        }
        #endregion
        #region "populated"
        private void Popuptimer_Tick(object sender, EventArgs e)
        {
            this.Close();
       }
        private void frmReminder_Load(object sender, EventArgs e)
        {
            //int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            //int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            //int x = 767;
            //int y = 24;
            Screen scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);
            //this.Location = new Point(x, y);
        }
        private void GetDisplay()
        {
           // bool blngChcek = false;
            List<CalenderOT> objCal = new List<CalenderOT>();
            //objCal = accmSc.DisplayDashBoard("DisplayDashboard", dtedate.ToString("dd/MM/yyyy")).ToList();
            objCal = accmSc.DisplayDashBoard("DisplayDashboard", DateTime.Now.ToString("dd/MM/yyyy")).ToList();
            if (objCal.Count > 0)
            {
                //if (blngChcek == false)
                //{
                    foreach (CalenderOT cal in objCal)
                    {
                        if ((cal.status == 0) || (cal.status ==1))
                        {
                            txtDisplay.Text = txtDisplay.Text + " Reg. No: " + cal.RegNo + Environment.NewLine + "OT Started On: " + cal.Fromtime + " to " + cal.Totime;
                           // blngChcek = true;
                        }
                    }
               // }
            }

        }
        #endregion
    }
}
