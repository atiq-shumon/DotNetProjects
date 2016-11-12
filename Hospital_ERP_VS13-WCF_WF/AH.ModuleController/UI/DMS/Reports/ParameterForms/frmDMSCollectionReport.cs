using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.DMS.Reports.Viewer;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using AH.DUtility;

namespace AH.ModuleController.UI.DMS.Reports.ParameterForms
{
    public partial class frmDMSCollectionReport : AH.Shared.UI.frmSmartFormReportStandard
    {
        DMSSR.DMSWSClient dmsSRClient = new DMSSR.DMSWSClient();
        public frmDMSCollectionReport()
        {
            InitializeComponent();
        }

        private void rdoTotalColl_CheckedChanged(object sender, EventArgs e)
        {
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;          
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
        }

        private void rdoUserWiseCollection_CheckedChanged(object sender, EventArgs e)
        {           
            txtEmpID.Visible = true;
            lblEmpID.Visible = true;           
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
        }

        private void rdoDueList_CheckedChanged(object sender, EventArgs e)
        {          
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
        }

        private void rdoVoucher_CheckedChanged(object sender, EventArgs e)
        {           
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = true;
            rdoUserWise.Visible = true;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
        }

        private void rdoDoctorWiseCollDet_CheckedChanged(object sender, EventArgs e)
        {            
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;          
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            gbDateRange.Visible = true;
            lblTicketType.Visible = true;
            cboTicketType.Visible = true;
        }

        private void rdoDoctorWiseCollSum_CheckedChanged(object sender, EventArgs e)
        {
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;           
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            gbDateRange.Visible = true;
            lblTicketType.Visible = true;
            cboTicketType.Visible = true;
        }

        # region AllDueList
        public void DueList()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DueList;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();

            ofrmReportViewer.ViewReport();
        }
        #endregion


        # region AllCollectionSummary
        public void AllCollectionSummary()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.AllCollectionSummary;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion
        
        # region TotalCollection
        public void TotalCollection()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.TotalCollection;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region UserWiseCollection
        public void UserWiseCollection()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.UserWiseCollection;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.EmpId = Utility.UserId;
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region UserWiseCashCollection
        public void UserWiseCashCollection()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.UserWiseCashCollection;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region IntegretedVoucherReport
        public void IntegretedVoucherReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.IntegretedVoucherReport;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.UserID = txtUserID.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion      

        # region DoctorWiseCollectionDetails
        public void DoctorWiseCollectionDetails()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DoctorWiseDiagnosticCollectionDetails;
            ofrmReportViewer.TicketType = cboTicketType.SelectedValue.ToString();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion

        # region DoctorWiseCollectionSummary
        public void DoctorWiseCollectionSummary()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DoctorWiseDiagnosticCollectionSummary;
            ofrmReportViewer.TicketType = cboTicketType.SelectedValue.ToString();
            ofrmReportViewer.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewer.Edate = dtEndDate.Text.ToString();
            ofrmReportViewer.ViewReport();
        }
        #endregion


        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Due List
            if (rdoDueList.Checked == true)
            {
                cboDateType.Focus();
                if (cboDateType.Text != "")
                {
                    DueList();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            //All Collection Summary
            if (rdoAllCollSummary.Checked == true)
            {
                cboDateType.Focus();
                if (cboDateType.Text != "")
                {
                    AllCollectionSummary();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            //Diagnostic Collection
            if (rdoTotalColl.Checked == true)
            {
                cboDateType.Focus();
                if (cboDateType.Text != "")
                {
                    TotalCollection();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            //User Wise Collection
            if (rdoUserWiseCollection.Checked == true)
            {

                if (cboDateType.Text != "")
                {
                    UserWiseCollection();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }

            //User Wise Cash Collection
            if (rdoUserWiseCash.Checked == true)
            {
                cboDateType.Focus();
                if (cboDateType.Text != "")
                {
                    UserWiseCashCollection();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            //Integreted Voucher Report
            if (rdoVoucher.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    IntegretedVoucherReport();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }          
            //Doctor Wise Collection Details
            if (rdoDoctorWiseCollDet.Checked == true)
            {
                if (cboTicketType.SelectedValue != "")
                {
                    if (cboDateType.Text != "")
                    {
                        DoctorWiseCollectionDetails();
                    }
                    else
                        MessageBox.Show("You must Have to Give Date Range");
                }
                else
                    MessageBox.Show("Please Select a Ticket Type to See Total Collection");
                cboTicketType.Focus();
            }
            //Doctor Wise Collection Summary
            if (rdoDoctorWiseCollSum.Checked == true)
            {
                if (cboTicketType.SelectedValue != "")
                {
                    if (cboDateType.Text != "")
                    {
                        DoctorWiseCollectionSummary();
                    }
                    else
                        MessageBox.Show("You must Have to Give Date Range");
                }
                else
                    MessageBox.Show("Please Select a Ticket Type to See Total Collection");
                cboTicketType.Focus();
            }
        }

        private void frmDMSCollectionReport_Load(object sender, EventArgs e)
        {
            cboTicketType.DisplayMember = "Value";
            cboTicketType.ValueMember = "Key";
            cboTicketType.DataSource = new BindingSource(dmsSRClient.GetPrescriptionTypes(), null);

            rdoTotalColl.Checked = true;
        }

        private void rdoUserWise_CheckedChanged(object sender, EventArgs e)
        {
            txtUserID.Enabled = true;
            lblUserID.Visible = true;
            txtUserID.Visible = true;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
            txtUserID.Focus();
        }

        private void cboDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region DateLogic
            DateTime _dateTo = DateTime.Parse(DateTime.Now.ToString());
            string sTo = _dateTo.ToString("dd-MM-yyyy");
            dtEndDate.Text = sTo;

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

        private void rdoUserWiseCollection_Click(object sender, EventArgs e)
        {
            txtEmpID.Text = Utility.UserId;
        }

        private void rdoVoucher_Click(object sender, EventArgs e)
        {
            rdoAll.Checked = true;
        }

        private void rdoUserWiseCash_CheckedChanged(object sender, EventArgs e)
        {           
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;           
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;            
        }

        private void rdoAllCollSummary_CheckedChanged(object sender, EventArgs e)
        {
            txtEmpID.Visible = false;
            lblEmpID.Visible = false;
            gbDateRange.Visible = true;
            rdoAll.Visible = false;
            rdoUserWise.Visible = false;
            lblUserID.Visible = false;
            txtUserID.Visible = false;
            lblTicketType.Visible = false;
            cboTicketType.Visible = false;
        }

    }
}
