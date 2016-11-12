using AH.DUtility;
//using AH.ModuleController.OPDSR;
using AH.ModuleController.FNBSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmCollectionSendToAccounts : AH.Shared.UI.frmSmartFormStandard
    {
        //FNBSR.FNBWSClient FNBSc = new FNBSR.FNBWSClient();

        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public frmCollectionSendToAccounts()
        {
            InitializeComponent();
        }

        private void btnShowAmount_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text != "" && dtpDate.Text != "")
            {
                AccountsPayment tktFee = fnbs.GetCollectionAmount(txtUserId.Text, dtpDate.Text);
                {
                    if (tktFee.TotalCollection.ToString() != "0" )
                    {
                        txtAmountInCash.Text =  Math.Round(tktFee.CashAmount,0).ToString() ;
                        txtAmountInCredit.Text = Math.Round(tktFee.CreditCardAmount,0).ToString();
                        txtAmountInDebit.Text = Math.Round(tktFee.DebitCardAmount,0).ToString();
                        txtCollection.Text = Math.Round(tktFee.TotalCollection,0).ToString();
                        txtRefund.Text = Math.Round(tktFee.RefundAmount,0).ToString();
                        txtTotal.Text = Math.Round(tktFee.TotalCollection,0).ToString();
                        
                    }
                        
                    else
                    {
                        MessageBox.Show("Sorry, No Record Found");
                    }
                }
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
            if (txtAmountInCash.Text =="")
            {
                return;
            }

            try
            {
                if (Convert.ToDouble(txtAmountInCash.Text) >= 0)
                {
                    if (txtTotal.Text != "")
                    {
                        if (Convert.ToDecimal(txtTotal.Text) > 0)
                        {
                            List<string> vf = new List<string>() { "txtUserId", "dtpDate", "txtCollection", "txtRefund", };
                            Control control = Utility.ReqFieldValidator(this, vf);
                            if (control != null)
                            {
                                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                control.Focus();
                                return;
                            }
                            try
                            {
                                //Ticket tktFeeToAcc = this.PopulateData();
                                AccountsPayment tktFeeToAcc = this.PopulateData();
                                short i = fnbs.InsertUserCloseRegister(tktFeeToAcc);
                                if (i == 0)
                                {
                                    MessageBox.Show("Amount Sending failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show("Amount Sending Successfull", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtRefund.Text = string.Empty;
                                    txtCollection.Text = string.Empty;
                                    txtTotal.Text = string.Empty;
                                    txtRemarks.Text = string.Empty;
                                    txtAmountInCash.Text = string.Empty;
                                    txtAmountInCredit.Text = string.Empty;
                                    txtAmountInDebit.Text = string.Empty;
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
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
                else
                {
                    MessageBox.Show("Sorry , Can not send the *Cash Amount* in Negative", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

       // private Ticket PopulateData()
         private AccountsPayment PopulateData()
        {
           // Ticket tktFee = new Ticket();
            AccountsPayment tktFee = new AccountsPayment();
            EntryParameter ep = new EntryParameter();

            tktFee.CashAmount =Convert.ToDouble(txtAmountInCash.Text);
            tktFee.CreditCardAmount = Convert.ToDouble(txtAmountInCredit.Text);
            tktFee.DebitCardAmount = Convert.ToDouble(txtAmountInDebit.Text);

            tktFee.PaymentAmount = Convert.ToDouble(txtTotal.Text);
            tktFee.Remarks = txtRemarks.Text;

            ep.EntryBy = txtUserId.Text;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tktFee.CollectionDate = dtpDate.Text;
            tktFee.EntryParameter = ep;
            return tktFee;
        }  
    }
}
