using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.ModuleController.UI.ACCMS.Reports.Viewer;

namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    public partial class frmACCMSReportBankReconcilation : AH.Shared.UI.frmSmartFormReportStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        DateTime dteFinancialyearform, dteFinancialyearTo;
        public frmACCMSReportBankReconcilation()
        {
            InitializeComponent();
        }

        #region "Form Load"
        private void frmACCMSReportBankReconcilation_Load(object sender, EventArgs e)
        {
            GetFiscalYear();
            cboLedgerName.ValueMember = "Key";
            cboLedgerName.DisplayMember = "Value";
            cboLedgerName.DataSource = new BindingSource(accmSc.GetLedgerNameBank(), null);
        }
        #endregion 
        #region "Print"
        private void GetFiscalYear()
        {
            List<FinancialYear> objYear = accmSc.GetActiveFiscalYear().ToList();
            foreach (FinancialYear fy in objYear)
            {
                dteFinancialyearform = Convert.ToDateTime(fy.FinancialYearForm);
                dteFinancialyearTo = Convert.ToDateTime(fy.FinancialYearTo);
            }

        }
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
            return true;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (ValidateFields() == false)
            {
                return;
            }
            
            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.BankReconcilation;
            frm.WhereCondition = cboLedgerName.SelectedValue.ToString();
            frm.Where2 = cboLedgerName.Text;
            frm.strFromDate = dtStartDate.Text;
            frm.strToDate = dtEndDate.Text;
            frm.ShowDialog();
        }
        #endregion

        private void cboLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                dtStartDate.Focus();
            }
        }

        private void dtStartDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
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
