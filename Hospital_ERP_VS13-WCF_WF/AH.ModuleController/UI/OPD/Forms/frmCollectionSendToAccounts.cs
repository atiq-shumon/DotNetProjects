using AH.DUtility;
using AH.ModuleController.OPDSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmCollectionSendToAccounts : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        public frmCollectionSendToAccounts()
        {
            InitializeComponent();
        }

        private void btnShowAmount_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text != "" && dtpDate.Text != "")
            {
                AccountsPayment tktFee = opdSc.GetTicketFees(txtUserId.Text, dtpDate.Text);
                {
                    if (tktFee.TotalCollection != 0)
                    {
                        txtAmountInCash.Text = Convert.ToString( tktFee.CashAmount);
                        txtAmountInCredit.Text = Convert.ToString( tktFee.CreditCardAmount);
                        txtAmountInDebit.Text = Convert.ToString(tktFee.DebitCardAmount);
                        txtCollection.Text = Convert.ToString( tktFee.TotalCollection);
                        txtRefund.Text = Convert.ToString(tktFee.RefundAmount);
                        txtTotal.Text = Convert.ToString(tktFee.PaymentAmount);
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
            if (txtAmountInCash.Text != "" && txtAmountInCash.Text != null)
            {
                if (Convert.ToDouble(txtAmountInCash.Text) >= 0)
                {
                    if (txtTotal.Text != "" && txtTotal.Text != null)
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
                                short i = opdSc.InsertUserCloseRegister(tktFeeToAcc);
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
                            catch (System.ServiceModel.CommunicationException commp)
                            {
                                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Can not send empty amount to Accounts", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Sorry , Can not send the *Cash Amount* in Negative", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            #region collection old
            //if (txtAmountInCash.Text != "" || txtAmountInCash.Text != null)
            //{
            //    if (Convert.ToDouble(txtAmountInCash.Text) >= 0)
            //    {
            //        if (txtTotal.Text != "")
            //        {
            //            if (Convert.ToDecimal(txtTotal.Text) > 0)
            //            {
            //                List<string> vf = new List<string>() { "txtUserId", "dtpDate", "txtCollection", "txtRefund", };
            //                Control control = Utility.ReqFieldValidator(this, vf);
            //                if (control != null)
            //                {
            //                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    control.Focus();
            //                    return;
            //                }
            //                try
            //                {
            //                    //Ticket tktFeeToAcc = this.PopulateData();
            //                    AccountsPayment tktFeeToAcc = this.PopulateData();
            //                    short i = opdSc.InsertUserCloseRegister(tktFeeToAcc);
            //                    if (i == 0)
            //                    {
            //                        MessageBox.Show("Amount Sending failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Amount Sending Successfull", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                        txtRefund.Text = string.Empty;
            //                        txtCollection.Text = string.Empty;
            //                        txtTotal.Text = string.Empty;
            //                        txtRemarks.Text = string.Empty;
            //                        txtAmountInCash.Text = string.Empty;
            //                        txtAmountInCredit.Text = string.Empty;
            //                        txtAmountInDebit.Text = string.Empty;
            //                        return;
            //                    }
            //                }

            //                catch (Exception ex)
            //                {
            //                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    return;
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Can not send amount 0 to Accounts", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please Provide valid amount", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sorry , Can not send the *Cash Amount* in Negative", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            #endregion collection old
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
