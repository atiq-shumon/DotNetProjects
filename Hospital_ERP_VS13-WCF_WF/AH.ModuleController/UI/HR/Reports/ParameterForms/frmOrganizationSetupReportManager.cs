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
    public partial class frmOrganizationSetupReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmOrganizationSetupReportManager()
        {           
            InitializeComponent();
        }

        public void DEPT()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.departmentList;
            ofrmReportViewerHR.ViewReport();
        }

        public void DESIG()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.DesignationList;
            ofrmReportViewerHR.ViewReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdoDeptList.Checked == true)
            {
                DEPT();
            }
            if (rdoDesignation.Checked == true)
            {
                DESIG();
            }
        }     
    }
}
