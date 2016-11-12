using AH.DUtility;
using AH.ModuleController.IPDSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmCollectionSendToAccounts : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmCollectionSendToAccounts()
        {
            InitializeComponent();
        }

        private void btnShowAmount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserId.Text != "")
                {
                    AccountsPayment oAccountPay = new AccountsPayment();

                    oAccountPay = ipdSc.GetCollectionToTransferAcc(txtUserId.Text);
                    {
                        if (oAccountPay.CashAmount.ToString() == "0" && oAccountPay.CreditCardAmount.ToString() == "0" && oAccountPay.DebitCardAmount.ToString() == "0")
                        {
                            MessageBox.Show("Sorry, No Record Found");
                        }

                        else
                        {
                            txtAmountInCash.Text = oAccountPay.CashAmount.ToString();
                            txtAmountInCredit.Text = oAccountPay.CreditCardAmount.ToString();
                            txtAmountInDebit.Text = oAccountPay.DebitCardAmount.ToString();
                            txtTotalAmount.Text = (oAccountPay.CashAmount + oAccountPay.CreditCardAmount + oAccountPay.DebitCardAmount).ToString();

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

        private void frmCollectionSendToAccounts_Load(object sender, EventArgs e)
        {         
                txtUserId.ReadOnly = true;
                EntryParameter ep = new EntryParameter();
                ep.EntryBy = Utility.UserId;
                txtUserId.Text = ep.EntryBy;
                dtpDate.Text = Convert.ToString(DateTime.Today);     
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTotalAmount.Text != "")
            {
                if (Convert.ToDecimal(txtTotalAmount.Text) > 0)
                {
                    List<string> vf = new List<string>() { "txtUserId", "txtTotalAmount", };
                    Control control = Utility.ReqFieldValidator(this, vf);
                    if (control != null)
                    {
                        MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return;
                    }
                    try
                    {
                        AccountsPayment oAccountPayment = this.PaymentObject();
                        short i = ipdSc.InsertUserCloseRegister(oAccountPayment);
                        if (i == 0)
                        {
                            MessageBox.Show("Amount Sending failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Amount Sending Successfull", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtRemarks.Text = string.Empty;
                            txtAmountInCash.Text = string.Empty;
                            txtAmountInCredit.Text = string.Empty;
                            txtAmountInDebit.Text = string.Empty;
                            txtTotalAmount.Text = string.Empty;
                            return;
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
                else
                {
                    MessageBox.Show("Can not send amount 0 to Accounts", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Provide valid amount", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       private AccountsPayment PaymentObject()
        {
            AccountsPayment oAccountsPayment = new AccountsPayment();
             oAccountsPayment.CashAmount=Convert.ToUInt64(txtAmountInCash.Text);
            oAccountsPayment.DebitCardAmount = Convert.ToUInt64(txtAmountInDebit.Text);
            oAccountsPayment.CreditCardAmount = Convert.ToUInt64(txtAmountInCredit.Text);
            oAccountsPayment.TotalCollection = Convert.ToUInt64(txtTotalAmount.Text);
            oAccountsPayment.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();

            ep.EntryBy = txtUserId.Text;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oAccountsPayment.EntryParameter = ep;
           
            return oAccountsPayment;
        }  
    }
}
