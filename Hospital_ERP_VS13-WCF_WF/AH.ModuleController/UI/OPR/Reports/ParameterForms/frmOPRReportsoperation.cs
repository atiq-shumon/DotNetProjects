using AH.ModuleController.UI.OPR.Reports.Viewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AH.ModuleController.UI.OPR.Reports.ParameterForms
{
    public partial class frmOPRReportsoperation : AH.Shared.UI.frmSmartFormReportStandard
    {
        public frmOPRReportsoperation()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int Status = 0;

            if (radNormal.Checked)
            {
                Status = 0;
            }
            else if (radEmergency.Checked)
            {
                Status = 1;
            }
            else if (radComplete.Checked)
            {
                Status = 2;
            }
            else if (radCancel.Checked)
            {
                Status = 3;
            }
            else
            {
                Status = 4;
            }
            
            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.operationDetails;
            frm.StartDate = dtStartDate.Text.ToString();
            frm.EndDate = dtEndDate.Text.ToString();
            frm.intStatus = Status;
            frm.ShowDialog();

        }

        private void dtStartDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                dtEndDate.Focus();
            }
        }

        private void dtEndDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnPrint.Focus();
            }
        }
    }
}
