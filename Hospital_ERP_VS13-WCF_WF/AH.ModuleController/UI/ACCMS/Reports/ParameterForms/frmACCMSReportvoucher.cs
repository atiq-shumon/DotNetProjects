using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.ACCMS.Reports.Viewer;
using AH.DUtility;
using System.Linq;
using AH.ModuleController.AccountsMSSR;


namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    public partial class frmACCMSReportvoucher : AH.Shared.UI.frmSmartFormReportStandard
    {
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();
        DateTime dteFinancialyearform, dteFinancialyearTo;
        public int intvouchertype=0;
        public frmACCMSReportvoucher()
        {
            InitializeComponent();
        }
        #region "Reports"

        private bool ValidateFields()
        {
            if (Convert.ToDateTime(dtStartDate.Text.ToString()) < dteFinancialyearform)
            {
                MessageBox.Show("Check Your Financial Year,Financial Year Should be  " + dteFinancialyearform.ToString("dd/MM/yyyy") + " to " + dteFinancialyearTo.ToString("dd/MM/yyyy"));
                dtStartDate.Focus();
                return false;
            }

            if ((Convert.ToDateTime(dtEndDate.Text.ToString()) > dteFinancialyearTo))
            {
                MessageBox.Show("Check Your Financial Year,Financial Year Should be  " + dteFinancialyearform.ToString("dd/MM/yyyy") + " to " + dteFinancialyearTo.ToString("dd/MM/yyyy"));
                dtEndDate.Focus();
                return false;
            }

            if (cboCompany.Text =="--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboCompany.Focus();
                return false;
            }

            return true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (ValidateFields() == false)
            {
                return;
            }


            string strControlName="";
            GetVoucherType();
            if (optAll.Checked == true)
            {
                strControlName = "All";
            }
            else
            {
                strControlName = "Individual";
            }
            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.VoucherReport;
            frm.intVoucherType = (int)(intvouchertype);
            if (optIndividual.Checked == true)
            {
                frm.WhereCondition = cboVoucherNo.SelectedValue.ToString();
                frm.Where2 = "Y";
            }
            frm.strFromDate = dtStartDate.Text;
            frm.strToDate = dtEndDate.Text;
            frm.strBranchID = cboCompany.SelectedValue.ToString();
            frm.strControls = strControlName;
            frm.ShowDialog();
        }
        private void  GetVoucherType()
        {
            if (optPayment.Checked == true)
            {
                intvouchertype = (int)Utility.VoucherType.vtPayment;
            }
            else if (optReceipt.Checked == true)
            {
                intvouchertype = (int)Utility.VoucherType.vtReceipt;
            }
            else if (optJournal.Checked == true)
            {
                intvouchertype = (int)Utility.VoucherType.vtJournal;
            }
            else if (optJournal.Checked == true)
            {
                intvouchertype = (int)Utility.VoucherType.vtContra;
            }
        }
        private void optIndividual_CheckedChanged(object sender, EventArgs e)
        {
            grpIndivudual.Visible = true;
            GetVoucherType();
            GetvoucherNo();
        }
        private void GetvoucherNo()
        {
            cboVoucherNo.ValueMember = "Key";
            cboVoucherNo.DisplayMember = "Value";
            cboVoucherNo.DataSource = new BindingSource(accmsc.GetIndividualVoucherNo(intvouchertype), null);
        }
        private void GetBranchConfig()
        {
            cboCompany.ValueMember = "Key";
            cboCompany.DisplayMember = "Value";
            cboCompany.DataSource = new BindingSource(accmsc.GetBranchConfig("D"), null);

        }
        private void GetFiscalYear()
        {
            List<FinancialYear> objYear = accmsc.GetActiveFiscalYear().ToList();
            foreach (FinancialYear fy in objYear)
            {
                dteFinancialyearform = Convert.ToDateTime(fy.FinancialYearForm);
                dteFinancialyearTo = Convert.ToDateTime(fy.FinancialYearTo);
            }

        }
        private void optAll_CheckedChanged(object sender, EventArgs e)
        {
            grpIndivudual.Visible = false;
        }
        private void frmACCMSReportvoucher_Load(object sender, EventArgs e)
        {
            GetFiscalYear();
            GetBranchConfig();
            cboCompany.SelectedIndex = 1;
        }
        private void optReceipt_CheckedChanged(object sender, EventArgs e)
        {
            if (optIndividual.Checked==true)
            {
                GetVoucherType();
                GetvoucherNo();
            }
        }
        private void optJournal_CheckedChanged(object sender, EventArgs e)
        {
            if (optIndividual.Checked == true)
            {
                GetVoucherType();
                GetvoucherNo();
            }
        }
        private void optContra_CheckedChanged(object sender, EventArgs e)
        {
            if (optIndividual.Checked == true)
            {
                GetVoucherType();
                GetvoucherNo();
            }
        }
        private void optPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (optIndividual.Checked == true)
            {
                GetVoucherType();
                GetvoucherNo();
            }
        }
        #endregion
    }
}
