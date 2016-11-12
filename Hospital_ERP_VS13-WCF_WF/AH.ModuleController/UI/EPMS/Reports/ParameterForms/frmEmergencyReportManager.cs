using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using AH.ModuleController.UI.DMS.Reports.Viewer;
using AH.ModuleController.UI.EPMS.Reports.Viewer;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using AH.DUtility;

namespace AH.ModuleController.UI.EPMS.Reports.ParameterForms
{
    public partial class frmEmergencyReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        DMSSR.DMSWSClient dmsSRClient = new DMSSR.DMSWSClient();
        public frmEmergencyReportManager()
        {
            InitializeComponent();
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }      

        # region EmergencyCollecionMRReprint
        public void EmergencyCollecion()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.EmergencyMR;
            ofrmReportViewer.MoneyReceiptNo = txtMRNo.Text;
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region EmergencyPrescriptionMRReprint
        public void EmergencyPrescription()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.EmergencyPrescription;
            ofrmReportViewer.MoneyReceiptNo = txtMRNo.Text;
            ofrmReportViewer.ViewReport();
        }
        #endregion
        
        private void btnPrint_Click(object sender, EventArgs e)
        {           
            //Emergency Collection
            if (rdoEmrColl.Checked == true)
            {
                EmergencyCollecion();
            }

            //Emergency Prescription
            if (rdoEmerPres.Checked == true)
            {
                EmergencyPrescription();
            }    

        }    
       
        public bool CheckDateOPtions()
        {
            if (cboDateType.Text != "")
            {
                if (cboDateType.Text != "None" && cboDateType.Text != "")
                {
                    DateTime startdate = Convert.ToDateTime(dtStartDate.Text);
                    DateTime enddate = Convert.ToDateTime(dtEndDate.Text);
                    if (startdate > enddate)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
             
        private void cboDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region DateLogic
            DateTime _dateTo = DateTime.Parse(DateTime.Now.ToString());
            string sTo = _dateTo.ToString("dd-MM-yyyy");
            dtEndDate.Text = sTo;

            if (cboDateType.Text == "No Date")
            {                
                dtStartDate.Text = "";
                dtEndDate.Text = "";

            }

            if (cboDateType.Text == "Today")
            {
                DateTime _dFrom = _dateTo.AddDays(0);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }
            if (cboDateType.Text == "Last One Week")
            {
                DateTime _dFrom = _dateTo.AddDays(-7);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last One Month")
            {
                DateTime _dFrom = _dateTo.AddDays(-30);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Three Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-3);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Six Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-6);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last One Year")
            {
                DateTime _dFrom = _dateTo.AddYears(-1);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }
            #endregion
        }

        private void rdoEmrColl_CheckedChanged(object sender, EventArgs e)
        {
            gbDateRange.Visible = false;
            lblParam1.Text = "Money Receipt No.";
        }

        private void txtMRNo_TextChanged(object sender, EventArgs e)
        {
            txtMRNo.CharacterCasing = CharacterCasing.Upper;
        }

        private void frmEmergencyReportManager_Load(object sender, EventArgs e)
        {
            rdoEmrColl.Checked = true;
        }

        private void rdoEmerPres_CheckedChanged(object sender, EventArgs e)
        {
            gbDateRange.Visible = false;
            lblParam1.Text = "Emergency Prescription No.";
        }        
      
    }
}

