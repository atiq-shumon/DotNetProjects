using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.UI.ACCMS.Reports.Viewer;
using AH.ModuleController.AccountsMSSR;

namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    public partial class frmACCMSReportLedger : AH.Shared.UI.frmSmartFormReportStandard
    {
        public string strSelection { get; set; }
        List<LedgerRO> objldr;
        DateTime dteFinancialyearform, dteFinancialyearTo;
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();
        public frmACCMSReportLedger()
        {
            InitializeComponent();
        }
        #region "Reports"
        private void GetBranchConfig()
        {
            cboCompany.ValueMember = "Key";
            cboCompany.DisplayMember = "Value";
            cboCompany.DataSource = new BindingSource(accmsc.GetBranchConfig("D"), null);
        }
        private void GetLedgerInformation(string strControl)
        {
            //cboLedgerName.ValueMember = "Key";
            //cboLedgerName.DisplayMember = "Value";
            //cboLedgerName.DataSource = new BindingSource(accmsc.GetLedgerInformation(strControl), null);

            //lstLedgerName.ValueMember = "key";
            //lstLedgerName.DisplayMember = "Value";
            //lstLedgerName.DataSource = new BindingSource(accmsc.GetLedgerInformation(strControl), null);


            DGLedger.Rows.Clear();
            objldr = accmsc.GetLedgerInformationGrid(strControl).ToList();
            int i = objldr.Count();
            int j = 0;
            if (i > 0)
            {
                foreach (LedgerRO ldr in objldr)
                {
                    DGLedger.Rows.Add(1);
                    DGLedger.Rows[j].Cells[0].Value = ldr.codeAllocation;
                    DGLedger.Rows[j].Cells[1].Value = ldr.strLedgerCode;
                    DGLedger.Rows[j].Cells[2].Value = ldr.strLedgerName;
                    j = j + 1;
                }
                DGLedger.AllowUserToAddRows = false;
            }
           


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

        private void frmACCMSReportLedger_Load(object sender, EventArgs e)
        {
          
            GetFiscalYear();
            GetBranchConfig();
            if (strSelection == "Ledger")
            {
                lblLabel.Text = "Ledger Code:";
                lblName.Text = "Ledger Name:";
                frmLabel.Text = "Ledger Wise Report";
                GetLedgerInformation(strSelection);
            }
            else if (strSelection == "Payable")
            {
                frmLabel.Text  = "Accounts Payable";
                lblLabel.Text = "Ledger Code:";
                lblName.Text = "Ledger Name:";
                //frmLabel.Text = "Ledger Wise Report";
                GetLedgerInformation(strSelection);
            }
            else
            {
                lblLabel.Text = "Group Code:";
                lblName.Text = "Group Name:";
                frmLabel.Text = "Group Wise Report";
                GetLedgerInformation(strSelection);
            }
            cboCompany.SelectedIndex = 1;

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (ValidateFields() == false)
            {
                return;
            }
            
            
            if (cboCompany.Text == "--Select--")
                {
                    MessageBox.Show("Cannot Empty");
                    cboCompany.Focus();
                }
            else if (cboLedgerName.Text == "--Select--")
                {
                    MessageBox.Show("Cannot Empty");
                    cboLedgerName.Focus();
               
                }
            else if (txtCodeAllocation.Text == "")
            {
                MessageBox.Show("Cannot Empty");
                txtCodeAllocation.Focus();
            }
            else
            {
                if (strSelection == "Ledger")
                {
                    frmReportViewer frm = new frmReportViewer();
                    frm.selector = ViewerSelector.LedgerReport;
                    //frm.WhereCondition = cboLedgerName.SelectedValue.ToString();
                    frm.WhereCondition = txtLCode.Text.ToString();
                    frm.LedgerName = cboLedgerName.Text.ToString();
                    frm.strBranchID = cboCompany.SelectedValue.ToString();
                    frm.strFromDate = dtStartDate.Text;
                    frm.strToDate = dtEndDate.Text;
                    frm.ShowDialog();
                }
                else if (strSelection == "Group")
                {
                    frmReportViewer frm = new frmReportViewer();
                    frm.selector = ViewerSelector.GroupReport;
                    //frm.WhereCondition = cboLedgerName.SelectedValue.ToString();
                    frm.WhereCondition = txtLCode.Text.ToString();
                    frm.LedgerName = cboLedgerName.Text.ToString();
                    frm.strBranchID = cboCompany.SelectedValue.ToString();
                    frm.strFromDate = dtStartDate.Text;
                    frm.strToDate = dtEndDate.Text;
                    frm.ShowDialog();
                }
                else if (strSelection == "Payable")
                {
                    frmReportViewer frm = new frmReportViewer();
                    frm.selector = ViewerSelector.Payable;
                    //frm.WhereCondition = cboLedgerName.SelectedValue.ToString();
                    frm.WhereCondition = txtLCode.Text.ToString();
                    frm.LedgerName = cboLedgerName.Text.ToString();
                    frm.strBranchID = cboCompany.SelectedValue.ToString();
                    frm.strFromDate = dtStartDate.Text;
                    frm.strToDate = dtEndDate.Text;
                    frm.ShowDialog();
                }



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
        private void cboLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dtStartDate.Focus();
            }
        }
        private void cboCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtCodeAllocation.Text = "";
                txtCodeAllocation.Focus();
            }
        }
        #endregion
        #region "Keyup"
        private void cboLedgerName_KeyUp(object sender, KeyEventArgs e)
        {

            int index;
            string actual;
            string found;
            if ((e.KeyCode == Keys.Back) ||
                    (e.KeyCode == Keys.Left) ||
                    (e.KeyCode == Keys.Right) ||
                    (e.KeyCode == Keys.Up) ||
                    (e.KeyCode == Keys.Down) ||
                    (e.KeyCode == Keys.Delete) ||
                    (e.KeyCode == Keys.PageUp) ||
                    (e.KeyCode == Keys.PageDown) ||
                    (e.KeyCode == Keys.Home) ||
                    (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cboLedgerName.Text;

            // Find the first match for the typed value.
            index = this.cboLedgerName.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {

                //this.cboLedgerName.SelectedValue.ToString();
                //found = this.cboLedgerName.Items[index].ToString();

                ////// Select this item from the list.
                //this.cboLedgerName.SelectedIndex = index;
                //cboLedgerName.SelectedItem = index;

                //// Select the portion of the text that was automatically
                //// added so that additional typing replaces it.
                //this.cboLedgerName.SelectionStart = actual.Length;
                //this.cboLedgerName.SelectionLength = found.Length;
            }
        }
        #endregion

        private void lstLedgerName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtLName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    if (lstLedgerName.SelectedItem != null)
            //    {
            //        lstLedgerName.SelectedIndex = lstLedgerName.SelectedIndex - 1;
            //    }
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    if (lstLedgerName.Items.Count - 1 > lstLedgerName.SelectedIndex)
            //    {
            //        lstLedgerName.SelectedIndex = lstLedgerName.SelectedIndex + 1;
            //    }
            //}

            DGLedger.Visible = true;
            txtLName.Text = "";
            txtLCode.Text = "";
            if (e.KeyCode == Keys.Up)
            {
                DGLedger.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                DGLedger.Focus();
            }

        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    if (lstLedgerName.Items.Count > 0)
            //    {
            //        txtLName.Text = lstLedgerName.Text;
            //        dtStartDate.Focus();
            //        lstLedgerName.Visible = false;
            //    }
            //}

            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtCodeAllocation.Text != "")
                {
                    DGLedger.Focus();
                }
                else
                {
                    DGLedger.Visible = false;
                    dtStartDate.Focus();

                }
            }

        }

        private void txtLName_KeyUp(object sender, KeyEventArgs e)
        {
            long result;
            int intCheck;
            if (long.TryParse(txtCodeAllocation.Text, out result))
            {
                intCheck = 0;
            }
            else
            {
                intCheck = 1;
            }

            SearchListView(objldr, intCheck, txtCodeAllocation.Text);
        }

        private void DGLedger_DoubleClick(object sender, EventArgs e)
        {
            if (DGLedger.SelectedRows.Count > 0)
            {
                int i = Convert.ToInt16(DGLedger.CurrentRow.Index.ToString());
                //if (Dg.Rows[i].Cells[0].Value.ToString() != "0")
                //{
                //txtLName.Text = DGLedger.Rows[i].Cells[1].Value.ToString();
                //txtLCode.Text = DGLedger.Rows[i].Cells[0].Value.ToString();
                //txtCodeAllocation.Text = DGLedger.Rows[i].Cells[2].Value.ToString();

                txtLCode.Text = DGLedger.Rows[i].Cells[1].Value.ToString();
                txtCodeAllocation.Text = DGLedger.Rows[i].Cells[0].Value.ToString();
                txtLName.Text = DGLedger.Rows[i].Cells[2].Value.ToString();


                DGLedger.Visible = false;
                //GetBankInformation();
                dtStartDate.Focus();
                
            }
        }


        private void SearchListView(IEnumerable<LedgerRO> tests, int intcheck, string searchString = "")
        {
            IEnumerable<LedgerRO> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                if (intcheck == 1)
                {
                    query = (from test in tests
                             where test.strLedgerName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select test);
                }
                else
                {
                    query = (from test in tests
                             where test.codeAllocation.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select test);
                }
            }

            DGLedger.Rows.Clear();
            try
            {
                int i = query.Count();
                int j = 0;
                if (i > 0)
                {
                    DGLedger.Rows.Add(i);
                    foreach (LedgerRO ldr in query)
                    {
                        //lstLedger.Items.Add(ldr.strLedgerName);
                        DGLedger.Rows[j].Cells[0].Value = ldr.codeAllocation;
                        DGLedger.Rows[j].Cells[1].Value = ldr.strLedgerCode;
                        DGLedger.Rows[j].Cells[2].Value = ldr.strLedgerName;
                        j = j + 1;
                    }
                    DGLedger.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void DGLedger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int i = Convert.ToInt16(DGLedger.CurrentRow.Index.ToString());
                
                txtLCode.Text = DGLedger.Rows[i].Cells[1].Value.ToString();
                txtCodeAllocation.Text = DGLedger.Rows[i].Cells[0].Value.ToString();
                txtLName.Text = DGLedger.Rows[i].Cells[2].Value.ToString();
                dtStartDate.Focus();
                DGLedger.Visible = false;
            }
        }









    }
}
