using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.ATMS.Reports.Viewer;
namespace AH.ModuleController.UI.ATMS.Reports.ParameterForms
{
    public partial class frmATMSReportstockinformation : AH.Shared.UI.frmSmartFormReportStandard
    {
        public frmATMSReportstockinformation()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string  i;
            if (radHouseKeeping.Checked )
            {
                i = "H";
            }
            else
            {
                i = "C";
            }

            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.StoreInformation;
            frm.WhereCondition = i;
            frm.strFromDate = dtStartDate.Text;
            frm.strToDate = dtEndDate.Text;
            frm.ShowDialog();
        }
    }
}
