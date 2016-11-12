using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;
using AH.ModuleController.UI.ACCMS.Reports.ParameterForms;
namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmBankReconcilation : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public frmBankReconcilation()
        {
            InitializeComponent();
        }
        #region "Grid"
        private DataGridViewTextBoxColumn Create_Grid_Column(string pname, string htext, int cwidth, Boolean true_false, DataGridViewContentAlignment Align,
                                                            Boolean read_only)
        {
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.DefaultCellStyle.ForeColor = Color.Black;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }
        private void GetLedgerInformation(string strControl)
        {
            cboLedgerName.ValueMember = "Key";
            cboLedgerName.DisplayMember = "Value";
            cboLedgerName.DataSource = new BindingSource(accmSc.GetLedgerNameBank(), null);
        }
        private void grid_column()
        {
            DG.Columns.Add(Create_Grid_Column("VoucherKey", "VoucherKey", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Date", "Date", 80, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("lCode", "lCode", 0, false, DataGridViewContentAlignment.TopLeft, false));
            DG.Columns.Add(Create_Grid_Column("Particulars", "Particulars", 160, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("To & by", "To & by", 70, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Voucher Type", "Voucher Type", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Voucher Name", "Voucher Name", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Checque No", "Checque No", 80, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Checque Date", "Checque Date", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Bank Date", "Bank Date", 90, true, DataGridViewContentAlignment.TopLeft, false));
            DG.Columns.Add(Create_Grid_Column("Deposit", "Deposit", 115, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Withdrawl", "Withdrawl", 115, true, DataGridViewContentAlignment.TopLeft, true));
            DG.Columns.Add(Create_Grid_Column("Bank Charge(%)", "Bank Charge(%)", 110, true, DataGridViewContentAlignment.TopCenter,false));
            DG.Columns.Add(Create_Grid_Column("Bank Charge Amount", "Bank Charge Amount", 130, true, DataGridViewContentAlignment.TopCenter, true));
        }
        private void frmBankReconcilation_Load(object sender, EventArgs e)
        {
            grid_column();
            GetLedgerInformation("Ledger");
        }
        #endregion
        #region "Rfresh"
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int i = 0;
            double dblNotReflectCredit = 0, dblTotalDebit = 0, dblNotReflectDebit = 0, dblTotalCredit = 0, dblCompanyBalanceDebit = 0, dblCompanyBalanceCredit=0;
            int intRcount;
            try
            {
                DG.Rows.Clear();
                uctxtNotBankDebit.Text = "0";
                uctxtCreditTotal.Text = "0";
                lblBankCharge.Text = "0";
                uctxtNotBankDebit.Text = "0";
                uctxtNotBankCredit.Text = "0";
                List<BankReconcilation> BnkRe = accmSc.GetBankReconcilation("BankReconcilation", cboLedgerName.SelectedValue.ToString(), dteFromDate.Text, dteToDate.Text).ToList();
                if (BnkRe.Count > 0)
                {
                    intRcount = BnkRe.Count;
                    DG.Rows.Add(intRcount);
                    foreach (BankReconcilation objBank in BnkRe)
                    {
                        DG.Rows[i].Cells[0].Value = objBank.voucherRefKey.ToString();
                        DG.Rows[i].Cells[1].Value = objBank.voucherDate.ToString();
                        string strParticulars = objBank.RefNo.ToString();
                        List<BankReconcilation> BnkParticulars = accmSc.GetParticulars("Particulars", objBank.RefNo.ToString(), objBank.VoucherToby.ToString()).ToList();
                        foreach (BankReconcilation bank in BnkParticulars)
                        {
                            DG.Rows[i].Cells[2].Value = bank.lcode;
                            DG.Rows[i].Cells[3].Value = bank.lName;
                        }
                        DG.Rows[i].Cells[4].Value = objBank.VoucherToby;
                        DG.Rows[i].Cells[5].Value = objBank.voucherType;
                        if (objBank.voucherType == "1")
                        {
                            DG.Rows[i].Cells[6].Value = "Payment";
                        }
                        else if (objBank.voucherType == "2")
                        {
                            DG.Rows[i].Cells[6].Value = "Receipt";
                        }
                        else if (objBank.voucherType == "3")
                        {
                            DG.Rows[i].Cells[6].Value = "Jounal";
                        }
                        else if (objBank.voucherType == "4")
                        {
                            DG.Rows[i].Cells[6].Value = "Contra";
                        }

                        DG.Rows[i].Cells[7].Value = objBank.chequeNo;
                        DG.Rows[i].Cells[8].Value = objBank.chequeDate;
                        DG.Rows[i].Cells[9].Value = objBank.BankDate;
                        DG.Rows[i].Cells[10].Value = objBank.DebitAmount;
                        dblTotalDebit = dblTotalDebit + objBank.DebitAmount;
                        DG.Rows[i].Cells[11].Value = objBank.CreditAmount;
                        dblTotalCredit = dblTotalCredit + objBank.CreditAmount;
                        dblNotReflectDebit = dblNotReflectDebit + Convert.ToDouble(objBank.DebitAmount);
                        dblNotReflectCredit = dblNotReflectCredit + Convert.ToDouble(objBank.CreditAmount);

                        DG.Rows[i].Cells[12].Value = 0;
                        DG.Rows[i].Cells[13].Value = 0;
                        //if ((DG.Rows[i].Cells[12].Value.ToString() !="" || DG.Rows[i].Cells[12].Value.ToString()  != "0"))
                        //{
                        //    DG.Rows[i].Cells[13].Value = Math.Round(Convert.ToDouble(objBank.DebitAmount) * Convert.ToDouble(DG.Rows[i].Cells[12].Value) / 100, 2);
                        //}
                       



                        if (i % 2 == 0)
                        {
                            DG.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                        }
                        else
                        {
                            DG.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
                        }
                        i = i + 1;
                    }

                    if (dblTotalDebit > dblTotalCredit)
                    {
                        dblCompanyBalanceDebit = dblTotalDebit - dblTotalCredit;
                        uctxtDebitTotal.Text = dblCompanyBalanceDebit.ToString();
                    }
                    if (dblTotalCredit > dblTotalDebit)
                    {
                        dblCompanyBalanceCredit = dblTotalCredit - dblTotalDebit;
                        uctxtCreditTotal.Text = dblCompanyBalanceCredit.ToString();
                    }
                    if (dblNotReflectDebit > 0)
                    {
                        uctxtNotBankDebit.Text = dblNotReflectDebit.ToString();
                    }
                    if (dblNotReflectCredit > 0)
                    {
                        uctxtNotBankCredit.Text = dblNotReflectCredit.ToString();
                    }
                    DG.Rows[1].Cells[12].Selected = true  ;
                    //DG.Rows[1].Cells[12].Selected = true;
                    //SendKeys.Send("TAB");
                    //SendKeys.Send("TAB");
                    //SendKeys.Send("TAB");
                    //SendKeys.Send("TAB");
                    //SendKeys.Send("TAB");



                }
            }

            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion
        #region "Keypress"
        private void cboLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Return)
            {
                dteFromDate.Focus();
            }
        }
        private void dteFromDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Return)
            {
                dteToDate.Focus();
            }
        }
        private void dteToDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Return)
            {
                btnRefresh.Focus();
            }
        }
        #endregion
        #region "Populated"
        private BankReconcilation PopulateBankReconcilation()
        {
            BankReconcilation objBr = new BankReconcilation();
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objBr.EntryParameter = ep;
            return objBr;
        }
        #endregion

        private bool  validatepost()
        {
            string strRefNo="";
            for (int intRow = 0; intRow < DG.Rows.Count - 1; intRow++)
            {
                strRefNo = DG.Rows[intRow].Cells[0].Value.ToString();
                List<BankReconcilation> BankR = accmSc.GetBankReconPost(strRefNo).ToList();
                foreach (BankReconcilation bk in BankR)
                {
                    if (bk.PostStatus=="Y")
                    {
                        return true;
                    }
                }

            }
            return false;
        }



        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        
        {
            short i=0,k=0;
            string strRefNo = "", strBID = "", strBrLCode = "", strLcode = "", strDate = "", strtoby = "", strChequeNo = "", strchequeDate = "", strBankDate = "", Post = "N";
            int intVtype = 0;
            double dblDr = 0, dblCr = 0, dblChildAmount = 0, dblBankcharge = 0, dblBankchargeAmount = 0, dblBankChargePer = 0;
            if (cboLedgerName.Text == "")
            {
                MessageBox.Show("LedgerName Cannot be Empty");
                cboLedgerName.Focus();
                return ;
            }
            if (validatepost() ==true)
            {
                MessageBox.Show("Bank Reconcilation is Already Posted");
                return;
            }
            for (int intRow = 0; intRow < DG.Rows.Count - 1; intRow++)
            {
                if (DG.Rows[intRow].Cells[12].Value.ToString() != null)
                {
                    dblBankChargePer = Convert.ToDouble(DG.Rows[intRow].Cells[12].Value.ToString());
                    if (DG.Rows[intRow].Cells[13].Value.ToString() == null)
                    {
                        MessageBox.Show("Bank Charge Amount Mismatch");
                        return;
                    }
                }
            }

            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                   

                    if (chkPosted.Checked==true)
                    {
                        Post = "Y";
                    }

                    BankReconcilation objBank = this.PopulateBankReconcilation();
                    for (int intRow = 0; intRow < DG.Rows.Count - 1; intRow++)
                    {
                        strBID = "0001";
                        strBrLCode = cboLedgerName.SelectedValue.ToString();
                        strRefNo = DG.Rows[intRow].Cells[0].Value.ToString();
                        strDate = DG.Rows[intRow].Cells[1].Value.ToString();
                        strLcode = DG.Rows[intRow].Cells[2].Value.ToString();
                        strtoby = DG.Rows[intRow].Cells[4].Value.ToString();
                        intVtype = Convert.ToInt16(DG.Rows[intRow].Cells[5].Value.ToString());
                        strChequeNo = DG.Rows[intRow].Cells[7].Value.ToString();
                        strchequeDate = DG.Rows[intRow].Cells[8].Value.ToString();

                        if (DG.Rows[intRow].Cells[9].Value != null)
                        {
                            strBankDate = DG.Rows[intRow].Cells[9].Value.ToString();
                        }
                        else
                        {
                            strBankDate = "";
                        }
                        dblDr = Convert.ToDouble(DG.Rows[intRow].Cells[10].Value);
                        dblCr = Convert.ToDouble(DG.Rows[intRow].Cells[11].Value);
                        dblChildAmount = dblDr + dblCr;

                        if (DG.Rows[intRow].Cells[12].Value.ToString() != null)
                        {
                            dblBankChargePer = Convert.ToDouble(DG.Rows[intRow].Cells[12].Value.ToString());
                        }
                        else
                        {
                            dblBankChargePer = 0;
                        }

                        dblBankcharge  = Convert.ToDouble(DG.Rows[intRow].Cells[13].Value);
                        dblBankchargeAmount = dblChildAmount - dblBankcharge;

                        i = accmSc.SaveBankReconcilationSetup(strRefNo.ToString(), strBID.ToString(),
                                                 Convert.ToInt16(intVtype), strDate, strBrLCode, strLcode.ToString(), Convert.ToDouble(dblDr),
                                                 Convert.ToDouble(dblCr), Convert.ToDouble(dblChildAmount), strtoby.ToString(),
                                                 strChequeNo.ToString(), strchequeDate.ToString(), strBankDate.ToString(), dblBankChargePer.ToString(), dblBankcharge, dblBankchargeAmount, Post, objBank);

                    }

                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        if (Convert.ToDouble(lblBankCharge.Text) > 0 || chkPosted.Checked == true)
                        {
                            string strPostDate = "";
                            strPostDate = DateTime.Now.ToString("dd/MM/yyyy");
                            k = accmSc.InsertIntegretedBr(strRefNo.ToString(), Convert.ToDouble(lblBankCharge.Text), 1, strPostDate,
                                    strBrLCode, "0000266", "", 7, objBank);// Integredted with Accounts  s



                            //'', 4000, 1, sysdate, '0000364', '0000266','', 7, '01', '01', '01', '01'
                        }
                        


                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        cboLedgerName.Focus();
                        DG.Rows.Clear();
                        uctxtDebitTotal.Text = "0";
                        uctxtNotBankDebit.Text = "0";
                        // uctxtBalanceBankDr.Text = "0";

                        uctxtCreditTotal.Text = "0";
                        uctxtNotBankCredit.Text = "0";
                        //uctxtBalanceBankCr.Text = "0";
                        lblBankCharge.Text = "0";
                        chkPosted.Checked = false;
                    }
                }
            }

            //catch (System.ServiceModel.CommunicationException commp)
            //{
            //    MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion
        #region "Print"
        private void btnPrint_Click(object sender, EventArgs e)
        {

            try
            {
                frmACCMSReportBankReconcilation frm = new frmACCMSReportBankReconcilation();
                frm.ShowDialog();
            }

            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

        private void DG_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            double dblNetBankCharges = 0;
            for (int i=0;i < DG.Rows.Count-1;i++ )
            {
                if ((DG.Rows[i].Cells[12].Value.ToString() != "" || DG.Rows[i].Cells[12].Value.ToString() != "0"))
                {
                    DG.Rows[i].Cells[13].Value = Math.Round(Convert.ToDouble(DG.Rows[i].Cells[10].Value.ToString()) * Convert.ToDouble(DG.Rows[i].Cells[12].Value.ToString()) / 100, 2);
                    dblNetBankCharges = dblNetBankCharges + Convert.ToDouble(DG.Rows[i].Cells[13].Value);
                }
                else
                {
                    DG.Rows[i].Cells[13].Value = 0;
                }
                
            }

            lblBankCharge.Text = Math.Round(dblNetBankCharges,2).ToString();


        }
    }
}
