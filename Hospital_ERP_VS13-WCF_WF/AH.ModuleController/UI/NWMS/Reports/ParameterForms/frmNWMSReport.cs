using AH.DUtility;
using AH.ModuleController.UI.NWMS.Reports.Viewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.NWMS.Reports.ParameterForms
{
    public partial class frmNWMSReport : AH.Shared.UI.frmSmartFormReportStandard
    {
        NWMSSR.NWMSWSClient nwmsSc = new NWMSSR.NWMSWSClient();

        public frmNWMSReport()
        {
            InitializeComponent();
        }

#region Declaration
        string TxtSearchCondition = "";
        string DateCondition = "";
        string FinalWhereCondition = "";
        string FieldName = "";
        string DateOptionMake = "";
        string DateFieldName = "";
        public string HCNReturn { set; get; }
#endregion
       
        private void rdoAdmtdPetDetail_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Admission ID";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            txtParam1.Text = string.Empty;
            txtParam1.Select();
            gbInformationControlls.Visible = true;
            gbDateRange.Visible = true;
            gbDateRange.Enabled = false;
            gbInformationControlls.Enabled = true;
        }

        private void rdoDateRange_CheckedChanged(object sender, EventArgs e)
        {
            gbDateRange.Visible = true;
            gbInformationControlls.Visible = true;
            gbInformationControlls.Enabled = false;
            gbDateRange.Enabled = true;
            txtParam1.Text = "";
           // HCNReturn = "";
            cboDateType.Select();
        }

        private void txtParam1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtParam1.Text.ToUpper().Length == Utility.ScanLength)
            {
                txtParam1.Text = txtParam1.Text.ToUpper();
            }
        }

        private void cboDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
#region DateLogic
            DateTime _dateTo = DateTime.Parse(DateTime.Now.ToString());
            string sTo = _dateTo.ToString("dd-MM-yyyy");
            dtEndDate.Text = sTo;

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!checkradio())
            {
                MessageBox.Show("Select any report option");
                return;
            }

            if (rdoDischargeSummary.Checked == true)
            {
                DischargeSummary();
            }
            if (rdoDischargeAdvice.Checked == true)
            {
                dischargeAdvice();
            }
            if (rdoDateRange.Checked == true)
            {
            }
            if (rdoDischargeSummary.Checked == true)
            {
               
            }
        }
        public void dischargeAdvice()
        {
            frmReportViewer ofrmRpt = new frmReportViewer();
            ofrmRpt.selector = ViewerSelector.DischargeAdvice;
            ofrmRpt.ParamField = txtParam1.Text;
            ofrmRpt.ViewReport();
        }
        public void DischargeSummary()
        {
            frmReportViewer ofrmRpt = new frmReportViewer();
            ofrmRpt.selector = ViewerSelector.DischargeSummary;
            ofrmRpt.ParamField = txtParam1.Text;
            ofrmRpt.ViewReport();
        }

        public bool checkradio()
        {
            RadioButton[] radioButtons = new RadioButton[] { rdoAdmtdPetDetail, rdoDateRange, rdoDischargeSummary, rdoDischargeAdvice }; 
            if (!radioButtons.Any(rb => rb.Checked))
            {
                return false;
            }
            return true;
        }

        private void frmNWMSReport_Load(object sender, EventArgs e)
        {
            dtStartDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dtEndDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            rdoDischargeSummary.Checked = true;
            cboDateType.SelectedIndex = 0;
        }

        public bool CheckDateOPtions()
        {
            if (cboDateType.Text != "")
            {
                if (cboDateType.Text != "None" && cboDateType.Text != "")
                {
                    DateTime startdate = DateTime.Parse(dtStartDate.Text);
                    DateTime enddate = DateTime.Parse(dtEndDate.Text);
                    if (startdate > enddate)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void rdoDischargeAdvice_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Admission ID";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            txtParam1.Text = string.Empty;
            txtParam1.Select();
            gbInformationControlls.Visible = true;
            gbDateRange.Visible = true;
            gbDateRange.Enabled = false;
            gbInformationControlls.Enabled = true;
        }

        private void rdoDischargeSummary_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Admission ID";
            lblParam1.Visible = true;
            txtParam1.Visible = true;
            txtParam1.Text = string.Empty;
            txtParam1.Select();
            gbInformationControlls.Visible = true;
            gbDateRange.Visible = true;
            gbDateRange.Enabled = false;
            gbInformationControlls.Enabled = true;
        }
    }
}
