using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;

using System.Drawing.Imaging;


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmTestPayroll : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmTestPayroll()
        {
            InitializeComponent();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtFirstName", "txtMiddleName", "txtLastName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }     
            try
            {
               //// testpayroll oPay = this.PopulatePayroll();
               // short i = hmsSC.SaveTestPayroll();
               // if (i == 0)
               // {
               //     MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // }
               // else if (i > 0)
               // {
               //     MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
               //     btnNew.PerformClick();
               // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }


        //private testpayroll PopulatePayroll()
        //{
        //    testpayroll oPay = new testpayroll();
        //    //oPay.emp_id = "1";

        //    return oPay;
        //}
    }
}
