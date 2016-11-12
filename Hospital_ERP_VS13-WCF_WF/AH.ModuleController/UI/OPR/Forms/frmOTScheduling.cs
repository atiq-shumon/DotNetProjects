using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmOTScheduling : AH.Shared.UI.frmSmartFormStandard
    {
        List<string> myCollection=new List<string>();
        public frmOTScheduling()
        {
            InitializeComponent();
        }

        private void chkOTCalender_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOTCalender.Checked==true )
            {
                //frmOTCalender frm = new frmOTCalender();
                //frm.dteOtDate = Convert.ToDateTime(dteOTSchedulingDate.Text);
                //frm.ShowDialog();
                //chkOTCalender.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOTPatient frm = new frmOTPatient(myCollection);
            frm.ShowDialog();
        }
    }
}
