using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.IPD.Reports.Viewer;
using AH.DUtility;
using AH.ModuleController.IPDSR;

namespace AH.ModuleController.UI.IPD.Reports.ParameterForms
{
    public partial class frmIPDReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmIPDReportManager()
        {
            InitializeComponent();
        }
        private void txtMoneyReceiptNo_TextChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Money Receipt";
            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            txtMoneyReceiptNo.Visible = true;
            txtReg_ID.Visible = false;
            txtTransNo.Visible = false;
            gbDateRange.Enabled = false;
        }

        public void AddmissionMoneyReceipt()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.AddmissionMoneyReceipt;
            ofrmReportViewer.TransactionNo = txtMoneyReceiptNo.Text;
            ofrmReportViewer.ReportTitle = "Advance Payment Receipt";
            ofrmReportViewer.ViewReport();
        }
        public void ReAdvanceMoneyReceipt()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.AddmissionMoneyReceipt;
            ofrmReportViewer.TransactionNo = txtTransNo.Text;
            ofrmReportViewer.ReportTitle = "Advance Payment Receipt";
            ofrmReportViewer.ViewReport();
        }
        public void AddmissionCard()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.AdmissionCard;
            ofrmReportViewer.TransactionNo = txtAdmissionCard.Text;
            ofrmReportViewer.ReportTitle = "Admission Card";
            ofrmReportViewer.ViewReport();
        }

        public void DischargeBillSummaryReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DischargeBillSummary;
            ofrmReportViewer.TransactionNo = txtReg_ID.Text;
            ofrmReportViewer.ViewReport();
        }
        public void DischargeDetailsBillReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DischargeBillDetails;
            ofrmReportViewer.TransactionNo = txtRegistrationId.Text;
            ofrmReportViewer.ReportTitle = "IPD Patient's Statement";
            ofrmReportViewer.ViewReport();
        }
        public void SpecimenDetReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.SpecimenDetailsReport;
            ofrmReportViewer.TransactionNo = txtTransNo.Text;
            ofrmReportViewer.ViewReport();
        }

        private void frmIPDReportManager_Load(object sender, EventArgs e)
        {
            rdoMoneyReceiptReport.Checked = true;
        }
        public void AdmittedPatientReportList()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.AdmittedPatientReport;
            ofrmReportViewer.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewer.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewer.ReportSecondParameter = ofrmReportViewer.GetDateRange();
            ofrmReportViewer.ViewReport();
        }
        public void DeathCertificate()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.DeathCertificate;
            ofrmReportViewer.TransactionNo = txtRegistrationId.Text;
            ofrmReportViewer.ViewReport();
        }
        public void BirthCertificate()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.BirthCertificate;
            ofrmReportViewer.TransactionNo = txtRegistrationId.Text;
            ofrmReportViewer.ViewReport();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdoMoneyReceiptReport.Checked == true)
            {
                List<AdmissionReportRO> oAdm = new List<AdmissionReportRO>();
                oAdm = ipdSc.GetAdmissionMoneyReceipt(txtMoneyReceiptNo.Text).ToList();
                if (oAdm.Count > 0)
                {
                    AddmissionMoneyReceipt();
                }
                else
                {
                    MessageBox.Show("Invalid Number!");
                    return;
                }
            }
            if (rdoDischargeBillSummaryReport.Checked == true)
            {
                //string vrfy = ipdSc.VerifyInPatient(txtReg_ID.Text);
                //if (vrfy.Length > 0)
                //{
                //    MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtReg_ID.Focus();
                //    return;
                //}
                DischargeBillSummaryReport();
            }

            if (rdoReadvanceMoneyRcpt.Checked == true)
            {
                ReAdvanceMoneyReceipt();
            }
            if (rdAdmissionCard.Checked == true)
            {
                AddmissionCard();
            }
            if (rdoDischargeDetailsBillRpt.Checked == true)
            {
                //string vrfy = ipdSc.VerifyInPatient(txtReg_ID.Text);
                //if (vrfy.Length > 0)
                //{
                //    MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtReg_ID.Focus();
                //    return;
                //}
                DischargeDetailsBillReport();
            }
            if (rdAdmittedReportList.Checked == true)
            {
                AdmittedPatientReportList();
            }
          
            if (rdoDeathCertificate.Checked == true)
            {
                DeathCertificate();
            }
            if (rdoBirthCertificate.Checked == true)
            {
                BirthCertificate();
            }
        }


        private void rdoMoneyReceiptReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam1.Text = "Money Receipt";
            lblParam1.Visible = true;
            lblParam2.Visible = false;
            lblParam3.Visible = false;
            txtMoneyReceiptNo.Visible = true;
            txtReg_ID.Visible = false;
            txtTransNo.Visible = false;
            gbDateRange.Enabled = false;
            lblAdmissionCard.Visible = false;
            txtAdmissionCard.Visible = false;
            lblDischargeBillDetailReport.Visible = false;
            txtRegistrationId.Visible = false;

        }

        private void rdoDischargeBillSummaryReport_CheckedChanged(object sender, EventArgs e)
        {
            lblParam2.Text = "Admission ID :";

            lblParam2.Visible = true;
            lblParam1.Visible = false;
            lblParam3.Visible = false;
            txtMoneyReceiptNo.Visible = false;
            txtReg_ID.Visible = true;
            txtTransNo.Visible = false;
            gbDateRange.Enabled = false;
            lblParam2.Visible = true;
            lblAdmissionCard.Visible = false;
            txtAdmissionCard.Visible = false;
            lblDischargeBillDetailReport.Visible = false;
            txtRegistrationId.Visible = false;
        }

        private void rdoReadvanceMoneyRcpt_CheckedChanged(object sender, EventArgs e)
        {
            lblParam3.Text = "Money Receipt";
            lblParam3.Visible = true;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            txtMoneyReceiptNo.Visible = false;
            txtReg_ID.Visible = false;
            txtTransNo.Visible = true;
            gbDateRange.Enabled = false;
            lblAdmissionCard.Visible = false;
            txtAdmissionCard.Visible = false;
            lblDischargeBillDetailReport.Visible = false;
            txtRegistrationId.Visible = false;
        }

   
        private void rdAdmissionCard_CheckedChanged(object sender, EventArgs e)
        {
            lblAdmissionCard.Text = "Admission ID :";
            txtAdmissionCard.Visible = true;
            lblAdmissionCard.Visible = true;
            lblParam3.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            txtMoneyReceiptNo.Visible = false;
            txtReg_ID.Visible = false;
            txtTransNo.Visible = false;
            gbDateRange.Enabled = false;
            lblDischargeBillDetailReport.Visible = false;
            txtRegistrationId.Visible = false;

        }

        private void txtRegistrationId_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoDischargeDetailsBillRpt_CheckedChanged(object sender, EventArgs e)
        {
            lblDischargeBillDetailReport.Text = "Admission ID :";
            lblDischargeBillDetailReport.Visible = true;
            txtRegistrationId.Visible = true;
            lblAdmissionCard.Visible = false;
            txtAdmissionCard.Visible = false;
            lblAdmissionCard.Visible = false;
            lblParam3.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            txtMoneyReceiptNo.Visible = false;
            txtReg_ID.Visible = false;
            txtTransNo.Visible = false;
            gbDateRange.Enabled = false;
        }

        private void rdAdmittedReportList_CheckedChanged(object sender, EventArgs e)
        {
            lblDischargeBillDetailReport.Visible = false;
            lblDischargeBillDetailReport.Visible = false;
            txtRegistrationId.Visible = false;
            lblAdmissionCard.Visible = false;
            txtAdmissionCard.Visible = false;
            lblAdmissionCard.Visible = false;
            lblParam3.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            txtMoneyReceiptNo.Visible = false;
            txtReg_ID.Visible = false;
            txtTransNo.Visible = false;
            gbDateRange.Enabled = true;
        }

        private void txtMoneyReceiptNo_Leave(object sender, EventArgs e)
        {
            txtMoneyReceiptNo.Text = txtMoneyReceiptNo.Text.ToUpper();
        }

        private void txtReg_ID_Leave(object sender, EventArgs e)
        {
            txtReg_ID.Text = txtReg_ID.Text.ToUpper();
        }

        private void txtTransNo_Leave(object sender, EventArgs e)
        {
            txtTransNo.Text = txtTransNo.Text.ToUpper();
        }

        private void txtAdmissionCard_Leave(object sender, EventArgs e)
        {
            txtAdmissionCard.Text = txtAdmissionCard.Text.ToUpper();
        }

        private void txtRegistrationId_Leave(object sender, EventArgs e)
        {
            txtRegistrationId.Text = txtRegistrationId.Text.ToUpper();
        }

        private void txtAdmissionCard_TextChanged(object sender, EventArgs e)
        {
            txtAdmissionCard.Text = txtAdmissionCard.Text.ToUpper();
        }

        private void txtMoneyReceiptNo_KeyUp(object sender, KeyEventArgs e)
        {
            txtMoneyReceiptNo.Text = txtMoneyReceiptNo.Text.ToUpper();
        }

        private void txtReg_ID_KeyUp(object sender, KeyEventArgs e)
        {
            txtReg_ID.Text = txtReg_ID.Text.ToUpper();
        }

        private void txtTransNo_KeyUp(object sender, KeyEventArgs e)
        {
            txtTransNo.Text=txtTransNo.Text.ToUpper();
        }

        private void txtAdmissionCard_KeyUp(object sender, KeyEventArgs e)
        {
            txtAdmissionCard.Text = txtAdmissionCard.Text.ToUpper();
        }

        private void txtRegistrationId_KeyUp(object sender, KeyEventArgs e)
        {
            txtRegistrationId.Text = txtRegistrationId.Text.ToUpper();
        }

        private void rdoDeathCertificate_CheckedChanged(object sender, EventArgs e)
        {
            lblDischargeBillDetailReport.Text = "Admission ID :";
            lblDischargeBillDetailReport.Visible = true;
            txtRegistrationId.Visible = true;
            lblAdmissionCard.Visible = false;
            txtAdmissionCard.Visible = false;
            lblAdmissionCard.Visible = false;
            lblParam3.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            txtMoneyReceiptNo.Visible = false;
            txtReg_ID.Visible = false;
            txtTransNo.Visible = false;
            gbDateRange.Enabled = false;
        }

        private void rdoBirthCertificate_CheckedChanged(object sender, EventArgs e)
        {
            lblDischargeBillDetailReport.Text = "Admission ID :";
            lblDischargeBillDetailReport.Visible = true;
            txtRegistrationId.Visible = true;
            lblAdmissionCard.Visible = false;
            txtAdmissionCard.Visible = false;
            lblAdmissionCard.Visible = false;
            lblParam3.Visible = false;
            lblParam1.Visible = false;
            lblParam2.Visible = false;
            txtMoneyReceiptNo.Visible = false;
            txtReg_ID.Visible = false;
            txtTransNo.Visible = false;
            gbDateRange.Enabled = false;
        }
 
    }
}
