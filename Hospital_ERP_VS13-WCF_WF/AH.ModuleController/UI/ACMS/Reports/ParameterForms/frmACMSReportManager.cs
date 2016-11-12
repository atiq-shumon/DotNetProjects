using AH.ModuleController.UI.ACMS.Reports.Viewer;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AH.ModuleController.UI.ACMS.Reports.ParameterForms
{
    public partial class frmACMSReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        public frmACMSReportManager()
        {
            InitializeComponent();
        }

        public bool checkradio()
        {
            RadioButton[] radioButtons = new RadioButton[] { rdoAccessControl, rdoModuleID, rdoGroup };
            if (!radioButtons.Any(rb => rb.Checked))
            {
                return false;
            }
            return true;
        }
        private void AccessControlReport()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.ACMSAccessControl;
            ofrmReportViewerOPD.ParamField = txtParam1.Text.Trim().ToUpper().ToString();
            ofrmReportViewerOPD.ViewReport();
        }

        private void ACModuleReport()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.ACReportModuleID;
            ofrmReportViewerOPD.ParamField = txtParam1.Text.Trim().ToUpper().ToString();
            ofrmReportViewerOPD.ViewReport();
        }

        private void ACGroupReport()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.ACReportGroup;
            ofrmReportViewerOPD.ParamField = txtParam1.Text.Trim().ToUpper().ToString();
            ofrmReportViewerOPD.ViewReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!checkradio())
            {
                MessageBox.Show("Select any report option");
                return;
            }
            if (txtParam1.Text == "")
            {
                MessageBox.Show("Provide Search Content");
                txtParam1.Focus();
                return;
            }
            if (rdoAccessControl.Checked == true)
            {
                if (txtParam1.Text == "")
                {
                    MessageBox.Show("Provide Search Content");
                    txtParam1.Focus();
                    return;
                }
                AccessControlReport();
            }

            if (rdoModuleID.Checked == true)
            {
                if (txtParam1.Text == "")
                {
                    MessageBox.Show("Provide Search Content");
                    txtParam1.Focus();
                    return;
                }
                ACModuleReport();
            }

            if (rdoGroup.Checked == true)
            {
                if (txtParam1.Text == "")
                {
                    MessageBox.Show("Provide Search Content");
                    txtParam1.Focus();
                    return;
                }
                ACGroupReport();
            }
        }

        private void rdoAccessControl_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Employee ID";
            gbDateRange.Enabled = false;
        }

        private void frmACMSReportManager_Load(object sender, EventArgs e)
        {
            rdoAccessControl.Select();
        }

        private void smartRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Module ID";
            gbDateRange.Enabled = false;
            txtParam1.Text = "";
        }

        private void rdoGroup_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Group ID";
            gbDateRange.Enabled = false;
            txtParam1.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

    }
}
