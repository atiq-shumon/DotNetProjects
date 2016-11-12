using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

using AH.ModuleController.UI.HR.Reports.Viewer;

namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    public partial class frmAppointmentLetter : AH.Shared.UI.frmSmartFormReportStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmAppointmentLetter()
        {
            InitializeComponent();
        }
        public void GeneralEmployeeAppLetter()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.AppointmentLetterForGeneralEmployee;
            ofrmReportViewerHR.strParam = txtReffNumber.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void ContructualEmployeeAppLetter()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.AppointmentLetterForContractual;
            ofrmReportViewerHR.strParam = txtReffNumber.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void PhysicianEmployeeAppLetter()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.AppointmentLetterForPhysician;
            ofrmReportViewerHR.strParam = txtReffNumber.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdoAppForGeneral.Checked == true)
            {
                txtReffNumber.Focus();
                if (txtReffNumber.Text == "")
                {
                    MessageBox.Show("Please Provide Referrence Number as a Search Content");
                    txtReffNumber.Focus();
                    return;
                }
                GeneralEmployeeAppLetter();
            }
            if (rdoConAppLetter.Checked == true)
            {
                txtReffNumber.Focus();
                if (txtReffNumber.Text == "")
                {
                    MessageBox.Show("Please Provide Referrence Number as a Search Content");
                    txtReffNumber.Focus();
                    return;
                }
                ContructualEmployeeAppLetter();
            }

            if (rdoPhyAppLetter.Checked == true)
            {
                txtReffNumber.Focus();
                if (txtReffNumber.Text == "")
                {
                    MessageBox.Show("Please Provide Referrence Number as a Search Content");
                    txtReffNumber.Focus();
                    return;
                }
                PhysicianEmployeeAppLetter();
            }

        }

        private void frmAppointmentLetter_Load(object sender, EventArgs e)
        {
            rdoAppForGeneral.Checked = true;
        }

        private void rdoAppForGeneral_CheckedChanged(object sender, EventArgs e)
        {
            txtReffNumber.Focus();
        }

        private void rdoConAppLetter_CheckedChanged(object sender, EventArgs e)
        {
            txtReffNumber.Focus();
        }

        private void rdoPhyAppLetter_CheckedChanged(object sender, EventArgs e)
        {
            txtReffNumber.Focus();
        }
    }
}
