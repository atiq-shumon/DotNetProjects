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
using AH.ModuleController.UI.ACCMS.Reports.Viewer;


namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmVoucher : AH.Shared.UI.frmSmartFormStandard
    {
        public int intVoucherType { get; set; }
        private double mdblDebit;
        private double mdblCredit;
        private int intPos { set; get; }
        private long lngPos;
        public const string gcMaskDate = "  /  /";
        public string strVoucherNo{get;set;}
        public int intMode { get; set;}
        public string VoucherNo { get; set; }
        public string Postvoucher { get; set; }
        DateTime dteFinancialyearform, dteFinancialyearTo;
        private int rowIndex2;

        List<Ledgers> objldr;
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();

        #region "Voucher"
        public frmVoucher(string strVoucherNo="" , int intVtype=0)
        {
            InitializeComponent();
            VoucherNo = strVoucherNo;
            intVoucherType = intVtype;
            //GetEditDisplay(VoucherNo, intVtype);
        }
        private static string GetVoucherName(int intVoucherType)
        {
            string strVoucherName="";
            if (intVoucherType == (int)Utility.VoucherType.vtPayment)
            {
                strVoucherName = "Payment Voucher";
            }
            else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
            {
                strVoucherName = "Receipt Voucher";
            }
            else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
            {
                strVoucherName = "Journal Voucher";
            }
            else if (intVoucherType == (int)Utility.VoucherType.vtContra)
            {
                strVoucherName = "Contra Voucher";
            }
            return strVoucherName.ToString();
        }

        private void mloadType()
        {
            //Dictionary<string, string> Vtype = new Dictionary<string, string>();
            //Vtype.Add("1", "Cash Payment");
            //Vtype.Add("2", "Bank Payment");
            //Vtype.Add("3", "Cash Receipt");
            //Vtype.Add("4", "Bank Receipt");
            //Vtype.Add("5", "Journal");
            //Vtype.Add("6", "Contra");
            //cboVoucherMode.DataSource = new BindingSource(Vtype, null);
            //cboVoucherMode.DisplayMember = "Value";
            //cboVoucherMode.ValueMember = "Key";
        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            try
            {

                mloadType();
                GetBranchName();
                cboDrCr.Items.Clear();
                cboDrCr.Items.Add("Dr");
                cboDrCr.Items.Add("Cr");
                if (Postvoucher == "Y")
                {
                    chkPost.Visible = false;
                }
                else
                {
                    chkPost.Visible = true;
                }

                cboDrCr.Text = "Dr";
                cboVoucherMode.Select();
                formatSerach();
                GetFiscalYear();
            }

            catch (System.ServiceModel.CommunicationException commp)
            {
                
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void GetFiscalYear()
        {
            List<FinancialYear> objYear = accmSc.GetActiveFiscalYear().ToList();
            foreach (FinancialYear fy in objYear)
            {
                dteFinancialyearform = Convert.ToDateTime(fy.FinancialYearForm);
                dteFinancialyearTo = Convert.ToDateTime(fy.FinancialYearTo);
            }

        }

        private void GetVoucherDisplay(VoucherTransaction vouchertran)
        {
            txtVoucherNo.Text = vouchertran.strRefNo;
            dteVoucherDate.Text = vouchertran.strVoucherDate;
            cboBranchName.Text = vouchertran.strBranchName;
            txtNarration.Text = vouchertran.strNarration;           
            ListViewItem lvi = new ListViewItem();
            lvi.Text = vouchertran.strLedgerName;
            lvi.SubItems.Add(vouchertran.strSingleNarration);
            lvi.SubItems.Add(vouchertran.strChequeNo.ToString());
            lvi.SubItems.Add(vouchertran.strChequedate.ToString());
          
            lvi.SubItems.Add(vouchertran.strDrawnon.ToString());
            lvi.SubItems.Add(vouchertran.dblDebitamount.ToString());
            lvi.SubItems.Add(vouchertran.dblCreditAmount.ToString());
            lvi.SubItems.Add(vouchertran.strDrCr);
            lvwVoucher.Items.Add(lvi);
        }
        #endregion
        #region "Validation"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "dteVoucherDate" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            //if (cboBranchName.Text == "")
            //{
            //    MessageBox.Show(Utility.getFMS(cboBranchName.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cboBranchName.Focus();
            //    return false;
            //}
            if (intMode == 0)
            {
                //if (cboLedgerName.Text == "")
                //{
                //    MessageBox.Show(Utility.getFMS(cboLedgerName.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    cboLedgerName.Focus();
                //    return false;
                //}
            }
            if (dteVoucherDate.Text == "  /  /")
            {
                MessageBox.Show(Utility.getFMS(dteVoucherDate.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dteVoucherDate.Focus();
                return false;
            }

            if (Utility.val(txtTotalDebit.Text) != Utility.val(txtTotalCredit.Text))
            {
                MessageBox.Show("Total Amount mismatch","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboVoucherMode.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboVoucherMode.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVoucherMode.Focus();
                return false;
            }
            if (DGdown.Rows.Count > 1)
            {
                if (txtNetTotal.Text != "")
                {
                    if (txtNetTotal.Text != txtTotalDebit.Text)
                    {
                        MessageBox.Show("Total Amount Mismatch of Cost Center");
                        return false;
                    }
                }
            }
           
            if (Convert.ToDateTime(dteVoucherDate.Text.ToString()) < dteFinancialyearform)
            {
                MessageBox.Show("Check Your Financial Year,Financial Year Should be  " + dteFinancialyearform.ToString("dd/MM/yyyy") + " to " + dteFinancialyearTo.ToString("dd/MM/yyyy") );
                dteVoucherDate.Focus();
                return false;
            }

            if ((Convert.ToDateTime(dteVoucherDate.Text.ToString()) > dteFinancialyearTo))
            {
                MessageBox.Show("Check Your Financial Year,Financial Year Should be  " + dteFinancialyearform.ToString("dd/MM/yyyy") + " to " + dteFinancialyearTo.ToString("dd/MM/yyyy"));
                dteVoucherDate.Focus();
                return false;
            }



            return true;
        }
        #endregion
        #region "Keypress"
        private void mskChequeDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtDrawnon.Focus();
            }
        }
        private void txtChequeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtChequeNo.Text != "")
                {
                    mskChequeDate.Focus();
                }
                else
                {

                    if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                    {
                        if (cboDrCr.Text == "Dr")
                        {
                            txtDrAmount.Focus();
                        }
                        else
                        {
                            txtCrAmount.Focus();
                        }
                    }
                    else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
                    {
                        if (cboDrCr.Text == "Cr")
                        {
                            txtCrAmount.Focus();
                        }
                        else
                        {
                            txtDrAmount.Focus();
                        }
                    }


                }
            }
        }
        private void txtDrawnon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                {
                    if (cboDrCr.Text == "Dr")
                    {
                        txtDrAmount.Focus();
                    }
                    else
                    {
                        txtCrAmount.Focus();
                    }
                }
                else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
                {
                    if (cboDrCr.Text == "Cr")
                    {
                        txtCrAmount.Focus();
                    }
                    else
                    {
                        txtDrAmount.Focus();
                    }
                }
            }
        }
        
        private void txtNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }
        private double chekduplicate(string strledgerName)
        {
            int i;
            double dblAmount=0;
            for (i = 0; i < lvwVoucher.Items.Count; i++)
            {
                if (lvwVoucher.Items[i].SubItems[0].Text  == strledgerName)
                {
                    dblAmount = Convert.ToDouble(lvwVoucher.Items[i].SubItems[5].Text);
                    lvwVoucher.Items.RemoveAt(i);
                }
            }
            return dblAmount;
        }

        private void txtDrAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strLedgerCode="";
            string strCheckDate="";
            double dblNetDr=0;
           
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (mskChequeDate.Text != gcMaskDate)
                {
                    strCheckDate = mskChequeDate.Text;
                }

                if (strVoucherNo != "" && (int)intMode == 1)
                {
                    lvwVoucher.Items.RemoveAt((int)lngPos);
                }

                for (int i = 0; i < lvwVoucher.Items.Count; i++)
                {
                    if (lvwVoucher.Items[i].SubItems[0].Text.ToString() == txtLedger.Text.ToString())
                    {
                        dblNetDr = Convert.ToDouble(lvwVoucher.Items[i].SubItems[5].Text);
                        lvwVoucher.Items.RemoveAt(i);
                    }
                }
               
                    addItem(txtLedger.Text.ToString(), txtSingleNarration.Text.ToString(),
                            txtChequeNo.Text.ToString(), strCheckDate.ToString(),
                            txtDrawnon.Text.ToString(), Convert.ToDouble(txtDrAmount.Text.ToString())+dblNetDr, Convert.ToDouble(txtCrAmount.Text.ToString()),
                            cboDrCr.Text, strLedgerCode);

                LoadListView(txtLedger.Text);

                txtLedger.Text = "";
                txtSingleNarration.Text = "";
                txtDrAmount.Text = "0";
                txtCrAmount.Text = "0";
                txtChequeNo.Text = "";
                mskChequeDate.Text = "";
                txtDrawnon.Text = "";
                txtLedgerCode.Text = "";

                CalculateTotal();
                cboDrCr.Focus();
            }
        }
        private void txtCrAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strLedgerCode = "";
            string strCheckDate="";
            double dblNetCr = 0;
                if (e.KeyChar == (char)Keys.Return)
                {
                    if (mskChequeDate.Text != gcMaskDate)
                    {
                        strCheckDate = mskChequeDate.Text;
                    }
                    if (strVoucherNo != "" && (int)intMode == 1)
                    {
                        lvwVoucher.Items.RemoveAt((int)lngPos);
                    
                    }

                    for (int i = 0; i < lvwVoucher.Items.Count; i++)
                    {
                        if (lvwVoucher.Items[i].SubItems[0].Text.ToString() == txtLedger.Text.ToString())
                        {
                            dblNetCr = Convert.ToDouble(lvwVoucher.Items[i].SubItems[6].Text);
                            lvwVoucher.Items.RemoveAt(i);
                        }
                    }

                    addItem(txtLedger.Text.ToString(), txtSingleNarration.Text.ToString(), txtChequeNo.Text.ToString(),
                                strCheckDate, txtDrawnon.Text.ToString(), Convert.ToDouble(txtDrAmount.Text.ToString()),
                                Convert.ToDouble(txtCrAmount.Text.ToString())+ dblNetCr,cboDrCr.Text,strLedgerCode);

                    LoadListView(txtLedger.Text);
                   
                    txtSingleNarration.Text = "";
                    txtDrAmount.Text = "0";
                    txtCrAmount.Text = "0";
                    txtChequeNo.Text = "";
                    mskChequeDate.Text = "";
                    txtDrawnon.Text = "";
                    txtLedger.Text = "";
                    txtLedgerCode.Text = ""; 
                    CalculateTotal();
                    cboDrCr.Focus();
                }
        }

        private void LoadListView(string strCode)
        {
            int i = 0;
            int k = 0;
            double dblamount = 0;
            lblTotalAmount.Text = "0";
            List<CostCenterTransation> objCostTran = accmSc.DisplayCostcenterTransaction("DisplayCostcenterTran", strCode, "").ToList();
            i = objCostTran.Count();
            if (i > 0)
            {
                DGdown.Rows.Add(i);

                foreach (CostCenterTransation Cost in objCostTran)
                {
                    DGdown[0, k].Value = Cost.Categorycode;
                    DGdown[1, k].Value = Cost.CategoryTitle;
                    DGdown[2, k].Value = Cost.CostCenteCode;
                    DGdown[3, k].Value = Cost.CoatCenterName;
                    DGdown[4, k].Value = Cost.LedgerCode;
                    DGdown[5, k].Value = Cost.Amount;
                    dblamount = dblamount + Cost.Amount;
                    k = k + 1;
                }
                txtNetTotal.Text = dblamount.ToString();
            }
            else
            {
                DGUP.Rows.Clear();
                List<CostCenterTransation> objCost = accmSc.GetCostCenterTransaction("DisplayCostcenterLedger", strCode, "").ToList();

                i = objCost.Count();
                if (i > 0)
                {
                    DGUP.Rows.Add(i);
                }
                foreach (CostCenterTransation Cost in objCost)
                {
                    DGUP[1, k].Value = Cost.Categorycode;
                    DGUP[2, k].Value = Cost.CategoryTitle;
                    DGUP[3, k].Value = Cost.CostCenteCode;
                    DGUP[4, k].Value = Cost.CoatCenterName;
                    DGUP[5, k].Value = Cost.LedgerCode;
                    k = k + 1;
                }
            }
        }
        private void addItem(string strLegderName
                            ,string strSinleNarration
                            ,string strChechueNo
                            ,string strchequedate
                            ,string strDrawnOn
                            , double dblDrAmount
                            , double dblCrAmount,string strDrCr,string strLedgerCode)
         {
             if (strLegderName != "")
             {
                 ListViewItem lvi = new ListViewItem();
                 mdblDebit = mdblDebit + dblDrAmount;
                 mdblCredit = mdblCredit + dblCrAmount;
                 lvi.Text = strLegderName;
                 lvi.SubItems.Add(strSinleNarration);
                 lvi.SubItems.Add(strChechueNo);
                 lvi.SubItems.Add(strchequedate);
                 lvi.SubItems.Add(strDrawnOn);
                 lvi.SubItems.Add(dblDrAmount.ToString());
                 lvi.SubItems.Add(dblCrAmount.ToString());
                 lvi.SubItems.Add(strDrCr.ToString());
                 lvi.SubItems.Add(strLedgerCode.ToString());
                 lvwVoucher.Items.Add(lvi);
                 txtTotalDebit.Text = mdblDebit.ToString();
                 txtTotalCredit.Text = mdblCredit.ToString();
             }
         }
        private void txtVoucherNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar ==(char)Keys.Return)
            {
                dteVoucherDate.Focus();

            }
        }
        private void cboBranchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtLedger.Focus();
            }
        }
        private void cboLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                {

                    if (cboDrCr.Text == "Dr")
                    {
                        txtDrAmount.ReadOnly = false;
                        txtCrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtDrAmount.Focus();
                    }
                    else
                    {
                        txtCrAmount.ReadOnly = false;
                        txtDrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtCrAmount.Text = mdblDebit.ToString();
                        txtCrAmount.Focus();
                    }
                    List<Ledgers> objldr = accmSc.CheckBankLedger(txtLedger.Text.ToString()).ToList();
                    foreach (Ledgers ldr in objldr)
                    {
                        if (ldr.lngLegerGroup == 100)
                        {
                            grpBankInformation.Visible = true;
                        }
                        else
                        {
                            grpBankInformation.Visible = false;
                        }
                        txtSingleNarration.Focus();
                    }
                }
                else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
                {

                    if (cboDrCr.Text == "Dr")
                    {
                        txtDrAmount.ReadOnly = false;
                        txtCrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtDrAmount.Focus();
                    }
                    else
                    {
                        txtCrAmount.ReadOnly = false;
                        txtDrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtCrAmount.Text = mdblDebit.ToString();
                        txtCrAmount.Focus();
                    }
                    List<Ledgers> objldr = accmSc.CheckBankLedger(txtLedger.Text.ToString()).ToList();
                    foreach (Ledgers ldr in objldr)
                    {
                        if (ldr.lngLegerGroup == 100)
                        {
                            grpBankInformation.Visible = true;
                        }
                        else
                        {
                            grpBankInformation.Visible = false;
                        }
                        txtSingleNarration.Focus();
                    }

                }
                else if (intVoucherType == (int)Utility.VoucherType.vtContra)
                {
                    if (cboDrCr.Text == "Dr")
                    {
                        txtDrAmount.ReadOnly = false;
                        txtCrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtDrAmount.Focus();
                    }
                    else
                    {
                        txtCrAmount.ReadOnly = false;
                        txtDrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtCrAmount.Text = mdblDebit.ToString();
                        txtCrAmount.Focus();
                    }
                    List<Ledgers> objldr = accmSc.CheckBankLedger(txtLedger.Text.ToString()).ToList();
                    foreach (Ledgers ldr in objldr)
                    {
                        if (ldr.lngLegerGroup == 100)
                        {
                            grpBankInformation.Visible = true;
                        }
                        else
                        {
                            grpBankInformation.Visible = false;
                        }
                        txtSingleNarration.Focus();
                    }
                }
                else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
                {
                    if (cboDrCr.Text == "Dr")
                    {
                        txtDrAmount.ReadOnly = false;
                        txtCrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtDrAmount.Focus();
                    }
                    else
                    {
                        txtCrAmount.ReadOnly = false;
                        txtDrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtCrAmount.Text = mdblDebit.ToString();
                        txtCrAmount.Focus();
                    }
                    List<Ledgers> objldr = accmSc.CheckBankLedger(txtLedger.Text.ToString()).ToList();
                    foreach (Ledgers ldr in objldr)
                    {
                        if (ldr.lngLegerGroup == 100)
                        {
                            grpBankInformation.Visible = true;
                        }
                        else
                        {
                            grpBankInformation.Visible = false;
                        }
                        txtSingleNarration.Focus();
                    }
                }

            }
        }
        private void GetBankInformation()
        {
            if (intVoucherType == (int)Utility.VoucherType.vtPayment)
            {

                if (cboDrCr.Text == "Dr")
                {
                    txtDrAmount.ReadOnly = false;
                    txtCrAmount.ReadOnly = true;
                    txtDrAmount.Text = "0";
                    txtCrAmount.Text = "0";
                    txtDrAmount.Focus();
                }
                else
                {
                    txtCrAmount.ReadOnly = false;
                    txtDrAmount.ReadOnly = true;
                    txtDrAmount.Text = "0";
                    txtCrAmount.Text = "0";
                    txtCrAmount.Text = mdblDebit.ToString();
                    txtCrAmount.Focus();
                }
            }
            else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
            {
                if (cboDrCr.Text == "Dr")
                {
                    CalculateTotal();

                    txtDrAmount.ReadOnly = false;
                    txtCrAmount.ReadOnly = true;
                    txtDrAmount.Text = "0";
                    txtCrAmount.Text = "0";
                    txtDrAmount.Focus();
                    txtDrAmount.Text = mdblDebit.ToString();
                }
                else
                {
                    if (txtCrAmount.Text == "0")
                    {
                        txtCrAmount.ReadOnly = false;
                        txtDrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                    }
                    
                    txtCrAmount.Focus();
                }
            }
            else if (intVoucherType == (int)Utility.VoucherType.vtContra)
            {
                if (cboDrCr.Text == "Dr")
                {
                    txtDrAmount.ReadOnly = false;
                    txtCrAmount.ReadOnly = true;
                    txtDrAmount.Text = "0";
                    txtCrAmount.Text = "0";
                    txtDrAmount.Focus();
                }
                else
                {
                    txtCrAmount.ReadOnly = false;
                    txtDrAmount.ReadOnly = true;
                    txtDrAmount.Text = "0";
                    txtCrAmount.Text = "0";
                    txtCrAmount.Text = mdblDebit.ToString();
                    txtCrAmount.Focus();
                }
            }
            else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
            {
                if (cboDrCr.Text == "Dr")
                {
                    txtDrAmount.ReadOnly = false;
                    txtCrAmount.ReadOnly = true;
                    txtDrAmount.Text = "0";
                    txtCrAmount.Text = "0";
                    txtDrAmount.Focus();
                }
                else
                {
                    txtCrAmount.ReadOnly = false;
                    txtDrAmount.ReadOnly = true;
                    txtDrAmount.Text = "0";
                    txtCrAmount.Text = "0";
                    txtCrAmount.Text = mdblDebit.ToString();
                    txtCrAmount.Focus();
                }
            }

        }
        private void txtSingleNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {

                if (cboDrCr.Text == "Dr")
                {
                    txtDrAmount.ReadOnly = false;
                    txtCrAmount.ReadOnly = true;
                    txtDrAmount.Enabled = true;
                }
                else
                {
                    txtCrAmount.ReadOnly = false;
                    txtDrAmount.ReadOnly = true;
                    txtCrAmount.Enabled = true;
                }

                if (txtLedger.Text == "")
                {
                    txtNarration.Focus();
                    //lstLedger.Visible = false;
                    DGLedger.Visible = false;
                }
                else
                {
                    DGLedger.Visible = false;
                    GetBankInformation();
                    txtSingleNarration.Focus();
                }
                
                if (grpBankInformation.Enabled)
                {
                    txtChequeNo.Focus();
                }
                else
                {
                    if (cboDrCr.Text =="Dr" )
                    {
                        txtDrAmount.Focus();
                    }
                    else
                    {
                        txtCrAmount.Focus();
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            cboBranchName.SelectedValue = "0001";
            //cboBranchName.Text = cboBranchName.SelectedValue.ToString();
           // MessageBox.Show(cboVoucherMode.SelectedValue.ToString());
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                string strVoucherNo;
                short intCashFlow = 0;

                short K = 0;
                short j = 0;
                int intLedgerCount;
                string strReverseLedger = "";
                string strLedgerCode = "";
                intLedgerCount = lvwVoucher.Items.Count;
                if (intLedgerCount == 0)
                {
                    MessageBox.Show("No Vocuher Found");
                    return;
                }
                List<Ledgers> objLedgers = accmSc.GetLedegrCode(lvwVoucher.Items[0].SubItems[0].Text).ToList();
                foreach (Ledgers ldr in objLedgers)
                {
                    strLedgerCode = ldr.strLedgerCode;
                }
                VoucherTransaction objTran = this.PopulatevoucherTransaction(strLedgerCode,
                                                         "", "", "", "", 0, 0, "", intVoucherType, 0, "", 0, intMode);
                strVoucherNo = accmSc.SaveVoucherSetup("", objTran);
                if (strVoucherNo != "")
                {
                    for (int i = 0; i < lvwVoucher.Items.Count; i++)
                    {
                        if (intLedgerCount > 2)
                        {
                            strReverseLedger = "As Per Details";
                        }
                        else if (i == 0)
                        {
                            List<Ledgers> objLedgers1 = accmSc.GetLedegrCode(lvwVoucher.Items[1].SubItems[0].Text).ToList();
                            foreach (Ledgers ldr in objLedgers1)
                            {
                                strReverseLedger = ldr.strLedgerCode;
                            }
                            //strReverseLedger = lvwVoucher.Items[0].SubItems[0].Text;
                        }
                        else if (i == 1)
                        {
                            List<Ledgers> objLedgers2 = accmSc.GetLedegrCode(lvwVoucher.Items[0].SubItems[0].Text).ToList();
                            foreach (Ledgers ldr in objLedgers2)
                            {
                                strReverseLedger = ldr.strLedgerCode;
                            }
                            //strReverseLedger = lvwVoucher.Items[1].SubItems[0].Text;
                        }
                        List<Ledgers> objldr = accmSc.CheckBankLedger(lvwVoucher.Items[i].SubItems[0].Text.ToString()).ToList();
                        foreach (Ledgers ldr in objldr)
                        {
                            if (ldr.lngLegerGroup <= 101)
                            {
                                intCashFlow = 1;
                            }
                        }
                        List<Ledgers> objLedgers3 = accmSc.GetLedegrCode(lvwVoucher.Items[i].SubItems[0].Text).ToList();
                        foreach (Ledgers ldr in objLedgers3)
                        {
                            strLedgerCode = ldr.strLedgerCode;
                        }

                        VoucherTransaction objTran1 = this.PopulatevoucherTransaction(strLedgerCode.ToString(),
                                                                lvwVoucher.Items[i].SubItems[1].Text.ToString(), lvwVoucher.Items[i].SubItems[2].Text.ToString(),
                                                               lvwVoucher.Items[i].SubItems[3].Text.ToString(), lvwVoucher.Items[i].SubItems[4].Text.ToString(),
                                                               double.Parse(lvwVoucher.Items[i].SubItems[5].Text), double.Parse(lvwVoucher.Items[i].SubItems[6].Text),
                                                               lvwVoucher.Items[i].SubItems[7].Text.ToString(), intVoucherType, intCashFlow, strReverseLedger, i + 1, intMode);

                        j = accmSc.SaveVoucheChildrSetup(strVoucherNo, objTran1);
                    }

                    CostCenterTransation objCost = this.PopulateCostCenter();
                    for (int C = 0; C < DGdown.Rows.Count - 1; C++)
                    {

                        int k = accmSc.SaveCostCentertransaction(strVoucherNo, DGdown[0, C].Value.ToString(), dteVoucherDate.Text, DGdown[2, C].Value.ToString(),
                                                                      DGdown[4, C].Value.ToString(), Convert.ToDouble(DGdown[5, C].Value), objCost);
                    }

                }

                if (j == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (j > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtVoucherNo.Focus();
                    //lvwVoucher.Items.Clear();
                    txtVoucherNo.Text = strVoucherNo.ToString();
                    DGdown.Rows.Clear();
                    DGUP.Rows.Clear();
                    lvwVoucher.Items.Clear();
                    txtNetTotal.Text = "0";
                    lblTotalAmount.Text = "0";
                    txtTotalDebit.Text = "0";
                    txtTotalCredit.Text = "0";
                    txtVoucherNo.Text = "";
                    //GetVoucherAutoNo();
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

        private CostCenterTransation PopulateCostCenter()
        {
            CostCenterTransation objCost = new CostCenterTransation();
            objCost.TransactionCode = txtVoucherNo.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objCost.EntryParameter = ep;

            return objCost;
        }
        #endregion
        #region"Populated"
        private VoucherTransaction PopulatevoucherTransaction(string vstrLedgerName, string vstrSingleNarration, string vstrChequeNo, 
                                                                string vstrChequedate, string vstrDrawnon, double dblDrAmount, double dblCrAmount,
                                                                string strDRCR,int intVoucherType,int intCashFlow,string strReverseLedger,int voucherPosition,int mode)
        {
            VoucherTransaction  objtran = new VoucherTransaction();
            DateTime dte;
            dte= Convert.ToDateTime(dteVoucherDate.Text.ToString());
            //objtran.strRefNo = txtVoucherNo.Text;
            objtran.strVoucherDate = dteVoucherDate.Text;
            objtran.strBranchName = cboBranchName.Text;
            objtran.strLedgerName = vstrLedgerName;
            objtran.strSingleNarration = vstrSingleNarration;
            objtran.strChequeNo = vstrChequeNo;
            objtran.strChequedate = vstrChequedate;
            objtran.strDrawnon = vstrDrawnon;
            objtran.dblDebitamount = dblDrAmount;
            objtran.dblCreditAmount = dblCrAmount;
            objtran.vintVoucherType = intVoucherType;
            objtran.strNarration = txtNarration.Text;
            objtran.strDrCr = strDRCR;
            objtran.strReferseLedger = strReverseLedger;
            objtran.intVoucherPos = voucherPosition;
            objtran.dbleNetCreditAmount = Utility.val(txtTotalCredit.Text);
            objtran.strMonthID = dte.ToString("MMMyy").ToUpper();
            objtran.intCashflow = intCashFlow;
            objtran.intmodetype = mode;
            if (chkPost.Checked == true)
            {
             objtran.PostStatus  = "Y";
            }
            else
            {
                objtran.PostStatus = "N";
            }
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objtran.EntryParameter = ep;
            return objtran;
        }
        private void GetBranchName()
        {
            
            cboBranchName.DataSource = new BindingSource(accmSc.GetBraNewConfig("D"), null);
            cboBranchName.ValueMember = "Key";
            cboBranchName.DisplayMember = "Value";
        }

        private void SearchListView(IEnumerable<Ledgers> tests,int intcheck, string searchString = "")
        {
            IEnumerable<Ledgers> query;
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
                             where test.strLedgerCode.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
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
                       foreach (Ledgers ldr in query)
                       {
                           //lstLedger.Items.Add(ldr.strLedgerName);
                           DGLedger.Rows[j].Cells[0].Value = ldr.strLedgerCode;
                           DGLedger.Rows[j].Cells[1].Value = ldr.strLedgerName;
                           j = j + 1;
                       }
                       DGLedger.AllowUserToAddRows = false;
                   }
                   //if (i==0)
                   //{
                   //    //MessageBox.Show("No Records Found");
                   //    //txtLedgerCode.Focus();
                   //    return;
                   //}
               }
            catch (Exception ex)
               {
                   ex.ToString();
               }
        }


        private void GetLedgersNameDr()
        {

            DGLedger.Rows.Clear();
            objldr = accmSc.GetLedgersNameDr().ToList();
            int i = objldr.Count();
            int j = 0;
            if (i > 0)
            {
                foreach (Ledgers ldr in objldr)
                {
                    DGLedger.Rows.Add(1);
                    DGLedger.Rows[j].Cells[0].Value = ldr.strLedgerCode;
                    DGLedger.Rows[j].Cells[1].Value = ldr.strLedgerName;
                    j = j + 1;
                }
                DGLedger.AllowUserToAddRows = false;
            }
          
        }
        private void GetLedgers()
        {
            DGLedger.Rows.Clear();
            objldr = accmSc.GetAllLedgers().ToList();
            int i = objldr.Count();
            int j = 0;
            if (i > 0)
            {
                DGLedger.Rows.Add(i);
                foreach (Ledgers ldr in objldr)
                {
                    DGLedger.Rows[j].Cells[0].Value = ldr.strLedgerCode;
                    DGLedger.Rows[j].Cells[1].Value = ldr.strLedgerName;
                    j = j + 1;
                }
                DGLedger.AllowUserToAddRows = false;
            }

        }
        private void GetLedgersNameCr()
        {
           
            DGLedger.Rows.Clear();
             objldr = accmSc.GetLedgersNameCr().ToList();
            int i = objldr.Count();
            int j = 0;
            if (i > 0)
            {
                DGLedger.Rows.Add(i);
                foreach (Ledgers ldr in objldr)
                {
                    DGLedger.Rows[j].Cells[0].Value = ldr.strLedgerCode;
                    DGLedger.Rows[j].Cells[1].Value = ldr.strLedgerName;
                    j = j + 1;
                }
                DGLedger.AllowUserToAddRows = false;
            }

        }
#endregion
        #region "doubleclick"
        private void lvwVoucher_DoubleClick(object sender, EventArgs e)
        {
          
            if (lvwVoucher.SelectedItems.Count > 0)
            {
              

                txtLedger.Text = lvwVoucher.FocusedItem.SubItems[0].Text;
                txtSingleNarration.Text = lvwVoucher.FocusedItem.SubItems[1].Text;
                txtDrAmount.Text = lvwVoucher.FocusedItem.SubItems[5].Text;
                txtCrAmount.Text = lvwVoucher.FocusedItem.SubItems[6].Text;
                if (Utility.val(txtDrAmount.Text) > 0)
                {
                    txtDrAmount.ReadOnly = false;
                    txtDrAmount.Enabled = true; // Enabled true/False
                }
                else
                {
                    txtDrAmount.ReadOnly = false;
                    txtDrAmount.Enabled = false; // Enabled true/False
                }

                if (Utility.val(txtCrAmount.Text) > 0)
                {
                    txtCrAmount.ReadOnly = false;
                    txtCrAmount.Enabled = true;
                }
                else
                {
                    txtCrAmount.ReadOnly = false;
                    txtCrAmount.Enabled = false;
                }                   

                cboDrCr.Text = lvwVoucher.FocusedItem.SubItems[7].Text;
                txtChequeNo.Text = lvwVoucher.FocusedItem.SubItems[2].Text;
                mskChequeDate.Text = lvwVoucher.FocusedItem.SubItems[3].Text;
                txtDrawnon.Text = lvwVoucher.FocusedItem.SubItems[4].Text;
                if (txtChequeNo.Text != "")
                {
                    grpBankInformation.Enabled  = true;
                }
                else
                {
                    grpBankInformation.Enabled = false;
                }
                lngPos = lvwVoucher.FocusedItem.Index;
                strVoucherNo = "";
                var strResponse = MessageBox.Show("Do You  Want to Edit?", "Edit Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    txtLedger.Text = lvwVoucher.FocusedItem.Text;
                    txtDrAmount.Text = lvwVoucher.FocusedItem.SubItems[5].Text;
                    txtCrAmount.Text = lvwVoucher.FocusedItem.SubItems[6].Text;
                    lvwVoucher.Items.RemoveAt(lvwVoucher.FocusedItem.Index);
                    txtLedger.Focus();
                }
                //intMode = 1;
            }
           
            CalculateTotal();
            
        }
        #endregion
        #region "Calculatetotal"
        private void CalculateTotal()
        {
            double DrAmount = 0, CrAmount = 0;
            mdblDebit = 0;
            mdblCredit =0;
            foreach (ListViewItem lstItem in lvwVoucher.Items) // sum from listOpening as list View
            {
                DrAmount = DrAmount + double.Parse(lstItem.SubItems[5].Text); // Columns 5
                CrAmount = CrAmount + double.Parse(lstItem.SubItems[6].Text); //columns 6
            }
            mdblDebit = DrAmount;
            mdblCredit = CrAmount;
            if (intVoucherType == (int)Utility.VoucherType.vtPayment)
            {
                if (cboDrCr.Text=="Cr")
                {
                    mdblDebit = DrAmount - CrAmount;
                }
            }
            if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
            {
                if (cboDrCr.Text == "Dr")
                {
                    mdblDebit = CrAmount - DrAmount;
                }
            }


            txtTotalDebit.Text = DrAmount.ToString();
            txtTotalCredit.Text = CrAmount.ToString();
        }
        #endregion
        #region "Selected index Changed"
        #endregion 
        #region "Voucher Auto"
        private void GetVoucherAutoNo()
        {
            List<VoucherTransaction> objTran = accmSc.GetVoucherNo(intVoucherType).ToList();
            foreach (VoucherTransaction Tran in objTran)
            {
                txtVoucherNo.Text = Tran.strRefNo;
            }
        }
        #endregion
        #region "Click"
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            frmVoucher frm1 = new frmVoucher();
            frm1.Dispose();
            frmVoucherDetails frm = new frmVoucherDetails();
            frm.intVoucherType = intVoucherType;
            frm.Poststatus = Postvoucher;
            frm.strDate = dteVoucherDate.Text.ToString();
            frm.ShowDialog();
          
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnPrint.Enabled = false;
            btnSave.Enabled = true;
            txtTotalDebit.Text = "0";
            txtTotalCredit.Text = "0";
            //grpBankInformation.Visible = false;
            intMode = 0;
            dteVoucherDate.Text = "";
            cboBranchName.Text = "";
            txtLedger.Text = "";
            txtSingleNarration.Text = "";
            txtDrAmount.Text = "0";
            txtCrAmount.Text = "0";
            mskChequeDate.Text = "";
            txtDrawnon.Text = "";
            txtChequeNo.Text ="";
            lvwVoucher.Items.Clear();
            cboVoucherMode.Enabled = true;
            grpBankInformation.Enabled = false;
            //lstLedger.Visible = false;
            DGLedger.Visible = false;
            cboVoucherMode.Text = "";
            DGdown.Rows.Clear();
            DGUP.Rows.Clear();
            lblTotalAmount.Text = "0";
            txtNetTotal.Text = "0";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            short K = 0;
            int intLedgerCount;
            string strReverseLedger = "";
            string strLedgerCode = "";
            int j=0;
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                string strRefNo;
                short intCashFlow = 0;
                //var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (strResponse == DialogResult.Yes)
                //{

                intLedgerCount = lvwVoucher.Items.Count;
                List<Ledgers> objLedgers = accmSc.GetLedegrCode(lvwVoucher.Items[0].SubItems[0].Text).ToList();
                foreach (Ledgers ldr in objLedgers)
                {
                    strLedgerCode = ldr.strLedgerCode;
                }
                VoucherTransaction objTran = this.PopulatevoucherTransaction(strLedgerCode,
                                                         "", "", "", "", 0, 0, "", intVoucherType, 0, "", 0, intMode);
                strRefNo = accmSc.SaveVoucherSetup(txtVoucherNo.Text, objTran);
                //K = j;
                if (strRefNo != "")
                {
                    for (int i = 0; i < lvwVoucher.Items.Count; i++)
                    {
                        if (intLedgerCount > 2)
                        {
                            strReverseLedger = "As Per Details";
                        }
                        else if (i == 0)
                        {
                            List<Ledgers> objLedgers1 = accmSc.GetLedegrCode(lvwVoucher.Items[1].SubItems[0].Text).ToList();
                            foreach (Ledgers ldr in objLedgers1)
                            {
                                strReverseLedger = ldr.strLedgerCode;
                            }
                            //strReverseLedger = lvwVoucher.Items[0].SubItems[0].Text;

                        }
                        else if (i == 1)
                        {
                            List<Ledgers> objLedgers2 = accmSc.GetLedegrCode(lvwVoucher.Items[0].SubItems[0].Text).ToList();
                            foreach (Ledgers ldr in objLedgers2)
                            {
                                strReverseLedger = ldr.strLedgerCode;
                            }
                            //strReverseLedger = lvwVoucher.Items[1].SubItems[0].Text;

                        }
                        List<Ledgers> objldr = accmSc.CheckBankLedger(lvwVoucher.Items[i].SubItems[0].Text.ToString()).ToList();
                        foreach (Ledgers ldr in objldr)
                        {
                            if (ldr.lngLegerGroup <= 101)
                            {
                                intCashFlow = 1;
                            }
                        }
                        List<Ledgers> objLedgers3 = accmSc.GetLedegrCode(lvwVoucher.Items[i].SubItems[0].Text).ToList();
                        foreach (Ledgers ldr in objLedgers3)
                        {
                            strLedgerCode = ldr.strLedgerCode;
                        }

                        VoucherTransaction objTran1 = this.PopulatevoucherTransaction(strLedgerCode.ToString(),
                                                                lvwVoucher.Items[i].SubItems[1].Text.ToString(), lvwVoucher.Items[i].SubItems[2].Text.ToString(),
                                                               lvwVoucher.Items[i].SubItems[3].Text.ToString(), lvwVoucher.Items[i].SubItems[4].Text.ToString(),
                                                               double.Parse(lvwVoucher.Items[i].SubItems[5].Text), double.Parse(lvwVoucher.Items[i].SubItems[6].Text),
                                                               lvwVoucher.Items[i].SubItems[7].Text.ToString(), intVoucherType, intCashFlow, strReverseLedger, i + 1, intMode);

                        j = accmSc.SaveVoucheChildrSetup(txtVoucherNo.Text, objTran1);

                    }

                    CostCenterTransation objCost = this.PopulateCostCenter();
                    for (int C = 0; C < DGdown.Rows.Count - 1; C++)
                    {

                        int k = accmSc.UpdateCostCenterTran(strVoucherNo, DGdown[0, C].Value.ToString(), dteVoucherDate.Text, DGdown[2, C].Value.ToString(),
                                                                      DGdown[4, C].Value.ToString(), Convert.ToDouble(DGdown[5, C].Value), objCost);
                    }

                    if (j == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (j > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtVoucherNo.Focus();
                        grpBankInformation.Visible = true;
                        txtVoucherNo.Text = "";
                        //txtVoucherNo.Text = strVoucherNo.ToString();
                        DGdown.Rows.Clear();
                        DGUP.Rows.Clear();
                        lvwVoucher.Items.Clear();
                        txtNetTotal.Text = "0";
                        lblTotalAmount.Text = "0";
                        txtTotalDebit.Text = "0";
                        txtTotalCredit.Text = "0";
                        txtVoucherNo.Text = "";
                        btnEdit.Enabled = false;
                        btnSave.Enabled = true;
                    }
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
        #region  "Voucher"
        private void dteVoucherDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //cboBranchName.Focus();
                cboBranchName.SelectedValue=0;
                //txtLedger.Focus();
                txtLedgerCode.Focus();

            }
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            
            grpSerach.Visible = true;
            lvwSearch.Items.Clear();
            LoadListView();
        }
        private void formatSerach()
        {
            lvwSearch.Items.Clear();
            lvwSearch.Columns.Add("Voucher No", 120, HorizontalAlignment.Left);
            lvwSearch.Columns.Add("Voucher Date", 130, HorizontalAlignment.Left);
            lvwSearch.Columns.Add("Ledger Name", 230, HorizontalAlignment.Left);
            lvwSearch.Columns.Add("Net Amount", 120, HorizontalAlignment.Left);
            lvwSearch.Columns.Add("Entry by", 150, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            try
            {
                List<VoucherTransaction> objTran = accmSc.GetVoucherTransactionDetails(intVoucherType, dteVoucherDate.Text.ToString(), dteVoucherDate.Text.ToString(), Postvoucher).ToList();
                foreach (VoucherTransaction tran in objTran)
                {
                    ListViewItem itm = new ListViewItem(tran.strRefNo);
                    itm.SubItems.Add(tran.strVoucherDate.ToString());
                    itm.SubItems.Add(tran.strLedgerName);
                    itm.SubItems.Add(Convert.ToDouble(tran.dblNetDebitAmount).ToString());
                    itm.SubItems.Add(tran.entryby.ToString());
                    lvwSearch.Items.Add(itm);
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
        private   void GetEditDisplay(string strvNo,int vtype)
        {

            try
            {
                lvwSearch.Items.Clear();
                List<VoucherTransaction> objTran = accmSc.GetVoucherSearch(strvNo, vtype).ToList();
                foreach (VoucherTransaction tran in objTran)
                {
                    txtVoucherNo.Text = tran.strRefNo.ToString();
                    dteVoucherDate.Text = tran.strVoucherDate.ToString();
                    cboBranchName.Text = tran.strBranchName.ToString();
                    txtNarration.Text = tran.strNarration.ToString();
                    if (tran.PostStatus == "Y")
                    {
                        chkPost.Checked = true;
                    }
                    else
                    {
                        chkPost.Checked = false;
                    }
                    ListViewItem itm = new ListViewItem(tran.strLedgerName.ToString());
                    itm.SubItems.Add(tran.strSingleNarration.ToString());
                    itm.SubItems.Add(tran.strChequeNo.ToString());
                    itm.SubItems.Add(tran.strChequedate.ToString());
                    itm.SubItems.Add(tran.strDrawnon.ToString());
                    itm.SubItems.Add(tran.dblDebitamount.ToString());
                    itm.SubItems.Add(tran.dblCreditAmount.ToString());
                    itm.SubItems.Add(tran.strDrCr.ToString());
                    itm.SubItems.Add(tran.LedgerCode.ToString());
                    //itm.SubItems.Add(tran.LedgerCode.ToString());
                    //itm.SubItems.Add(Convert.ToDouble(tran.dblNetDebitAmount).ToString());
                    lvwVoucher.Items.Add(itm);
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
        private void lvwSearch_DoubleClick(object sender, EventArgs e)
        {
            if (lvwSearch.SelectedItems.Count == 0)
            {
                return;
            }
            lvwVoucher.Items.Clear();
            btnPrint.Enabled = true;
            intMode = 1;
            string strvNo = lvwSearch.FocusedItem.SubItems[0].Text.ToString();
            GetEditDisplay(strvNo, intVoucherType);
            LoadListView(strvNo);
            grpSerach.Visible = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            CalculateTotal();
            
        }
        public void GetArchievDisplay(string strvNo, int vtype)
        {

            try
            {
                lvwSearch.Items.Clear();
                if (vtype == 1)
                {
                    cboVoucherMode.Text = "Cash Payment";
                    //cboVoucherMode.SelectedItem = 1;

                }
                else if (vtype == 2)
                {
                    cboVoucherMode.Text = "Cash Receipt";
                    //cboVoucherMode.SelectedItem = 3;
                }
                else if (vtype == 3)
                {
                    cboVoucherMode.Text = "Journal";
                    //cboVoucherMode.SelectedItem = 5;
                }
                else if (vtype == 4)
                {
                    cboVoucherMode.Text = "Contra";
                    //cboVoucherMode.SelectedItem = 6;
                }
                List<VoucherTransaction> objTran = accmSc.GetVoucherSearch(strvNo, vtype).ToList();
                foreach (VoucherTransaction tran in objTran)
                {
                    txtVoucherNo.Text = tran.strRefNo.ToString();
                    dteVoucherDate.Text = tran.strVoucherDate.ToString();
                    cboBranchName.Text = tran.strBranchName.ToString();
                    txtNarration.Text = tran.strNarration.ToString();
                    ListViewItem itm = new ListViewItem(tran.strLedgerName.ToString());
                    itm.SubItems.Add(tran.strSingleNarration.ToString());
                    itm.SubItems.Add(tran.strChequeNo.ToString());
                    itm.SubItems.Add(tran.strChequedate.ToString());
                    itm.SubItems.Add(tran.strDrawnon.ToString());
                    itm.SubItems.Add(tran.dblDebitamount.ToString());
                    itm.SubItems.Add(tran.dblCreditAmount.ToString());
                    itm.SubItems.Add(tran.strDrCr.ToString());
                    itm.SubItems.Add(tran.LedgerCode.ToString());
                    lvwVoucher.Items.Add(itm);
                }
                grpSerach.Visible = false;
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                CalculateTotal();
                btnPrint.Enabled = true;
                intMode = 1;
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

        
        private void lblClose_Click(object sender, EventArgs e)
        {
            grpSerach.Visible = false;
        }
        private void mAddDetails()
        {
            try
            {

                if (cboVoucherMode.Text == "")
                {
                    MessageBox.Show(Utility.getFMS(cboVoucherMode.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboVoucherMode.Focus();
                }
                else
                {

                    if (cboVoucherMode.Text == "Cash Payment")
                    {
                        intVoucherType = 1;
                    }
                    else if (cboVoucherMode.Text == "Cash Receipt")
                    {
                        intVoucherType = 2;
                    }
                    else if (cboVoucherMode.Text == "Journal")
                    {
                        intVoucherType = 3;
                    }
                    else if (cboVoucherMode.Text == "Contra")
                    {
                        intVoucherType = 4;
                    }
                    else if (cboVoucherMode.Text == "Bank Payment")
                    {
                        intVoucherType = 1;
                    }
                    else if (cboVoucherMode.Text == "Bank Receipt")
                    {
                        intVoucherType = 2;
                    }

                    frmLabel.Text = GetVoucherName(intVoucherType);
                    if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                    {
                        cboDrCr.Text = "Dr";
                    }
                    else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
                    {
                        cboDrCr.Text = "Dr";
                    }
                    else
                    {
                        cboDrCr.Text = "Cr";
                    }
                    GetBranchName();
                    if (intVoucherType == (int)Utility.VoucherType.vtContra)
                    {
                        GetLedgersNameCr();
                    }
                    else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
                    {
                        GetLedgers();
                    }
                    else
                    {
                        GetLedgersNameDr();
                    }

                    //GetVoucherAutoNo();
                    if (strVoucherNo != "")
                    {
                        List<VoucherTransaction> Voucher = accmSc.GetdisplayvoucherDetails(strVoucherNo, intVoucherType).ToList();
                        foreach (VoucherTransaction vstr in Voucher)
                        {
                            GetVoucherDisplay(vstr);
                        }
                        CalculateTotal();
                    }
                    lvwVoucher.Items.Clear();
                    txtDrAmount.Text = "0";
                    txtCrAmount.Text = "0";
                    txtTotalDebit.Text = "0";
                    txtTotalCredit.Text = "0";
                    txtVoucherNo.Text = "";
                    dteVoucherDate.Focus();
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
        #region "Key"
        private void cboVoucherMode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dteVoucherDate.Focus();
            }
        }
        private void cboVoucherMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mAddDetails();
            if (cboVoucherMode.Text == "Bank Payment")
            {
                grpBankInformation.Enabled = true;
            }
            else if (cboVoucherMode.Text == "Bank Receipt")
            {
                grpBankInformation.Enabled = true;
            }
            else
            {
                grpBankInformation.Enabled = false;
            }
        }
        private void txtLedger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
               
                if (cboDrCr.Text == "Dr")
                {
                    txtDrAmount.ReadOnly = false;
                    txtCrAmount.ReadOnly = true;
                    txtDrAmount.Enabled = true;
                }
                else
                {
                    txtCrAmount.ReadOnly = false;
                    txtDrAmount.ReadOnly = true;
                    txtCrAmount.Enabled = true;
                }

                if (txtLedger.Text == "")
                {
                    txtNarration.Focus();
                    //lstLedger.Visible = false;
                    DGLedger.Visible = false;
                }
                else
                {
                    DGLedger.Visible = false;
                    GetBankInformation();
                    txtSingleNarration.Focus();
                }
              
                
            }
        }

        #endregion
        #region "Double Click"
        #endregion
        #region "Selected Change"
        private void cboDrCr_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                {
                    if (cboDrCr.Text == "Dr")
                    {
                        txtDrAmount.ReadOnly = false;
                        txtCrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtLedger.Text = "";
                        //cboLedgerName.Items.Clear();
                        GetLedgersNameDr();
                        txtLedgerCode.Focus();
                    }
                    else if (cboDrCr.Text == "Cr")
                    {
                        txtCrAmount.ReadOnly = false;
                        txtDrAmount.ReadOnly = true;
                        txtLedger.Text = "";
                        //cboLedgerName.Items.Clear();
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        GetLedgersNameCr();
                        txtLedgerCode.Focus();
                    }
                }

                else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
                {
                    if (cboDrCr.Text == "Cr")
                    {
                        txtDrAmount.ReadOnly = false;
                        txtCrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtLedger.Text = "";
                        //cboLedgerName.Items.Clear();
                        GetLedgersNameDr();
                        txtLedgerCode.Focus();
                    }
                    else if (cboDrCr.Text == "Dr")
                    {
                        txtCrAmount.ReadOnly = false;
                        txtDrAmount.ReadOnly = true;
                        txtLedger.Text = "";
                        //cboLedgerName.Items.Clear();
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        GetLedgersNameCr();
                        txtLedgerCode.Focus();
                    }
                }
                else if (intVoucherType == (int)Utility.VoucherType.vtContra)
                {
                    if (cboDrCr.Text == "Cr")
                    {
                        txtDrAmount.ReadOnly = false;
                        txtCrAmount.ReadOnly = true;
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        txtLedger.Text = "";
                        //cboLedgerName.Items.Clear();
                        GetLedgersNameCr();
                        txtLedgerCode.Focus();
                    }
                    else if (cboDrCr.Text == "Dr")
                    {
                        txtCrAmount.ReadOnly = false;
                        txtDrAmount.ReadOnly = true;
                        txtLedger.Text = "";
                        //cboLedgerName.Items.Clear();
                        txtDrAmount.Text = "0";
                        txtCrAmount.Text = "0";
                        GetLedgersNameCr();
                        txtLedgerCode.Focus();
                    }
                    else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
                    {
                        if (cboDrCr.Text == "Cr")
                        {
                            txtDrAmount.ReadOnly = false;
                            txtCrAmount.ReadOnly = true;
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            txtLedger.Text = "";
                            //cboLedgerName.Items.Clear();
                            GetLedgers();
                            txtLedgerCode.Focus();
                        }
                        else if (cboDrCr.Text == "Dr")
                        {
                            txtCrAmount.ReadOnly = false;
                            txtDrAmount.ReadOnly = true;
                            txtLedger.Text = "";
                            // cboLedgerName.Items.Clear();
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            GetLedgers();
                            txtLedgerCode.Focus();
                        }
                    }
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
        private void cboDrCr_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    if (intVoucherType == (int)Utility.VoucherType.vtPayment)
                    {
                        if (cboDrCr.Text == "Dr")
                        {
                            txtDrAmount.ReadOnly = false;
                            txtCrAmount.ReadOnly = true;
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            //cboLedgerName.Text = "";
                            //cboLedgerName.Items.Clear();
                            GetLedgersNameDr();
                            //cboLedgerName.Focus();
                            txtLedgerCode.Focus();
                        }
                        else if (cboDrCr.Text == "Cr")
                        {
                            txtCrAmount.ReadOnly = false;
                            txtDrAmount.ReadOnly = true;
                            //cboLedgerName.Text = "";
                            //cboLedgerName.Items.Clear();
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            GetLedgersNameCr();
                            //cboLedgerName.Focus();
                            txtLedgerCode.Focus();
                        }
                    }
                    else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
                    {
                        if (cboDrCr.Text == "Cr")
                        {
                            txtDrAmount.ReadOnly = false;
                            txtCrAmount.ReadOnly = true;
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            //cboLedgerName.Text = "";
                            //cboLedgerName.Items.Clear();
                            GetLedgersNameDr();
                            //cboLedgerName.Focus();
                            txtLedgerCode.Focus();
                        }
                        else if (cboDrCr.Text == "Dr")
                        {
                            txtCrAmount.ReadOnly = false;
                            txtDrAmount.ReadOnly = true;
                            //cboLedgerName.Text = "";
                            //cboLedgerName.Items.Clear();
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            GetLedgersNameCr();
                            //cboLedgerName.Focus();
                            txtLedgerCode.Focus();
                        }
                    }

                    else if (intVoucherType == (int)Utility.VoucherType.vtContra)
                    {
                        if (cboDrCr.Text == "Cr")
                        {
                            txtDrAmount.ReadOnly = false;
                            txtCrAmount.ReadOnly = true;
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            txtLedger.Text = "";
                            //cboLedgerName.Items.Clear();
                            GetLedgersNameCr();
                            txtLedgerCode.Focus();
                        }
                        else if (cboDrCr.Text == "Dr")
                        {
                            txtCrAmount.ReadOnly = false;
                            txtDrAmount.ReadOnly = true;
                            txtLedger.Text = "";
                            //cboLedgerName.Items.Clear();
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            GetLedgersNameCr();
                            txtLedgerCode.Focus();
                        }
                    }
                    else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
                    {
                        if (cboDrCr.Text == "Cr")
                        {
                            txtDrAmount.ReadOnly = false;
                            txtCrAmount.ReadOnly = true;
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            txtLedger.Text = "";
                            //cboLedgerName.Items.Clear();
                            GetLedgers();
                            txtLedgerCode.Focus();
                        }
                        else if (cboDrCr.Text == "Dr")
                        {
                            txtCrAmount.ReadOnly = false;
                            txtDrAmount.ReadOnly = true;
                            txtLedger.Text = "";
                            // cboLedgerName.Items.Clear();
                            txtDrAmount.Text = "0";
                            txtCrAmount.Text = "0";
                            GetLedgers();
                            txtLedgerCode.Focus();
                        }
                    }
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
        #region "Down"
        private void lvwVoucher_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    var relativeMousePosition = lvwVoucher.PointToClient(Cursor.Position);
            //    this.mnuCostCenter.Show(lvwVoucher, relativeMousePosition);
            //}
        }
        private void costCenterTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double dblAmount;
            if (btnEdit.Enabled)
            {
                txtLedger.Text = lvwVoucher.FocusedItem.SubItems[0].Text;
                txtSingleNarration.Text = lvwVoucher.FocusedItem.SubItems[1].Text;
                if (lvwVoucher.FocusedItem.SubItems[5].Text != "0" )
                {
                     dblAmount= Convert.ToDouble(lvwVoucher.FocusedItem.SubItems[5].Text);
                }
                else 
                {
                    dblAmount = Convert.ToDouble(lvwVoucher.FocusedItem.SubItems[6].Text);
                }
               
                frmCostCategoryTransaction frm = new frmCostCategoryTransaction();
                frm.strVoucherNo = txtVoucherNo.Text.ToString();
                frm.strLedgerName = lvwVoucher.FocusedItem.SubItems[0].Text;
                frm.dblAmount = dblAmount;
                frm.strLedgerCode = lvwVoucher.FocusedItem.SubItems[8].Text;
                frm.strTranDate = dteVoucherDate.Text.ToString();
                frm.ShowDialog();
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.Pvoucher;
            frm.intVoucherType = (int)(intVoucherType);
            frm.WhereCondition = txtVoucherNo.Text.ToString();
            frm.Where2 = Postvoucher;
            frm.strFromDate = dteVoucherDate.Text;
            frm.strToDate = dteVoucherDate.Text;
            frm.strBranchID = "0001";
            frm.strControls = "Individual";
            frm.ShowDialog();
        }
        #endregion
        #region "Plus"
        private void btnPlus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DGUP.RowCount; i++)
            {
                if (Convert.ToBoolean(DGUP.Rows[i].Cells[0].Value) == true)
                {
                    if (DGUP[1, i].Value != null)
                    {
                        mAdditem(DGUP[1, i].Value.ToString(), DGUP[2, i].Value.ToString(),
                                    DGUP[3, i].Value.ToString(), DGUP[4, i].Value.ToString(), DGUP[5, i].Value.ToString(), Convert.ToDouble(DGUP[6, i].Value));
                    }
                }
            }
        }
        #endregion
        #region "Additem"
        private void mAdditem(string strCatCode,string strCatName, string strCostCenterCode,string CostcenterName,string Lcode,double dblAmount)
        {
            int selRaw;
            string strDown = "";
            Boolean blngCheck = false;
            for (int j = 0; j < DGdown.RowCount; j++)
            {
                if (DGdown[3, j].Value != null)
                {
                    strDown = DGdown[3, j].Value.ToString();
                }
                if (CostcenterName == strDown.ToString())
                {
                    blngCheck = true;
                }

            }
            if (blngCheck == false)
            {

                DGdown.AllowUserToAddRows = true;
                selRaw = Convert.ToInt16(DGdown.RowCount.ToString());
                selRaw = selRaw - 1;
                DGdown.Rows.Add(1);
                for (int i = 1; i < DGdown.Rows.Count; i++)
                {
                    DGdown[0, selRaw].Value = strCatCode.ToString();
                    DGdown[1, selRaw].Value = strCatName.ToString();
                    DGdown[2, selRaw].Value = strCostCenterCode.ToString();
                    DGdown[3, selRaw].Value = CostcenterName.ToString();
                    DGdown[4, selRaw].Value = Lcode.ToString();
                    DGdown[5, selRaw].Value = dblAmount;
                }
            }
            calculateTotal();

        }
        #endregion
        #region "Cell content Click"
        private void DGdown_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int selRowIndex = e.RowIndex;
                if (DGdown.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    DGdown.Rows.RemoveAt(selRowIndex);
                }
                calculateTotal();
            }
        }
        #endregion
        #region "CalculateTotal"
        private void calculateTotal()
        {
            double dblAmount = 0;
            for (int i = 0; i < DGdown.Rows.Count - 1; i++)
            {
                dblAmount = dblAmount + Convert.ToDouble(DGdown[5, i].Value);
            }
            txtNetTotal.Text = dblAmount.ToString();
        }
        private void DGUP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double dblAmount = 0;
            for (int i = 0; i < DGUP.Rows.Count - 1; i++)
            {
                dblAmount = dblAmount + Convert.ToDouble(DGUP[6, i].Value);
               
            }
            lblTotalAmount.Text = dblAmount.ToString();
        }
        #endregion
        #region "Key event"

        private void txtLedgerCode_KeyDown(object sender, KeyEventArgs e)
        {
            DGLedger.Visible = true;
            txtLedger.Text = "";
            if (e.KeyCode == Keys.Up)
            {
                DGLedger.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                DGLedger.Focus();
            }
        }

        private void txtLedgerCode_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                long result;
                int intCheck;
                if (long.TryParse(txtLedgerCode.Text, out result))
                {
                    intCheck = 0;
                }
                else
                {
                    intCheck = 1;
                }

                SearchListView(objldr, intCheck, txtLedgerCode.Text);
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

        private void txtLedgerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                if (txtLedgerCode.Text != "")
                {
                    if (DGLedger.Rows.Count > 0)
                    {
                        DGLedger.Focus();
                    }
                    else
                    {
                        txtLedgerCode.Focus();
                    }
                }
            else
            {
                DGLedger.Visible = false;
                txtNarration.Focus();

            }

            }
        }

        private void DGLedger_DoubleClick(object sender, EventArgs e)
        {
            if (DGLedger.SelectedRows.Count > 0)
            {
                int i = Convert.ToInt16(DGLedger.CurrentRow.Index.ToString());
                //if (Dg.Rows[i].Cells[0].Value.ToString() != "0")
                //{
                txtLedgerCode.Text = DGLedger.Rows[i].Cells[0].Value.ToString();
                txtLedger.Text = DGLedger.Rows[i].Cells[1].Value.ToString();
                DGLedger.Visible = false;
                GetBankInformation();
                txtSingleNarration.Focus();
                //}
            }
        }

        private void DGLedger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int i = Convert.ToInt16(DGLedger.CurrentRow.Index.ToString());
                txtLedgerCode.Text = DGLedger.Rows[i].Cells[0].Value.ToString();
                txtLedger.Text = DGLedger.Rows[i].Cells[1].Value.ToString();
                txtSingleNarration.Focus();
                DGLedger.Visible = false;

            }
        }

        private void frmVoucher_Click(object sender, EventArgs e)
        {
            DGLedger.Visible = false;
        }


        #endregion

        private void txtLedgerCode_TextChanged(object sender, EventArgs e)
        {

        }














    }
}
