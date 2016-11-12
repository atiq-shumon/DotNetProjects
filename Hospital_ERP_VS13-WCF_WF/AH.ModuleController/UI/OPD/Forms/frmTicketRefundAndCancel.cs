using AH.DUtility;
using AH.ModuleController.OPDSR;
using AH.ModuleController.UI.OPD.Reports.Viewer;
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
    public partial class frmTicketRefundAndCancel : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdsr = new OPDSR.OPDWSClient();
        public frmTicketRefundAndCancel()
        {
            InitializeComponent();
        }

        string entry_by = "";
        string entry_by_name = "";
        private void btnShowTicketStatus_Click(object sender, EventArgs e)
        {
            clean();
            chkAccountFlag.Checked = false;

            if (txtTicketNo.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPrescriptionNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTicketNo.Focus();
                return;
            }
            string msg = opdsr.VerifyTicketNo(txtTicketNo.Text.ToUpper(), false);
            if (msg == "1" )
            {
                btnCancel.Enabled = true;
                btnRefund.Enabled = true;

                Ticket pat = opdsr.GetTicketStatusForRefundOrCancel(txtTicketNo.Text);

                entry_by = pat.EntryParameter.EntryBy;
                entry_by_name = pat.EntryParameter.EntryName;

                if (pat.TicketStatus != "V")
                {
                    txtHcn.Text = pat.Patient.HCN;

                    if (pat.TicketStatus == "N")
                    {
                        txtTicketStatus.Text = "New";
                    }

                    if (pat.TicketCategory == "N")
                    {
                        txtTktCatgry.Text = "Normal";
                    }
                    txtTktFee.Text = Convert.ToString(pat.TicketFee);
                    txtPaidInCash.Text = Convert.ToString(pat.FeeCashAmount);

                    if (pat.acc_close_flag == "1")
                    {
                        chkAccountFlag.Checked = true;
                    }
                    if (pat.acc_close_flag == "0")
                    {
                        chkAccountFlag.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("You can not CANCEL or REFUND ticket, when you are in VISITING state", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else 
            {
                MessageBox.Show(msg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCancel.Enabled = false;
                btnRefund.Enabled = false;
                txtTicketNo.Focus();
                return;
            }         
        }
        public void clean()
        {
            txtHcn.Text = string.Empty;
            txtTicketStatus.Text = string.Empty;
            txtTktCatgry.Text = string.Empty;
            txtTktFee.Text = string.Empty;
            txtPaidInCash.Text = string.Empty;
        }
        private void frmTicketRefundAndCancel_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnRefund.Enabled = false;
            chkAccountFlag.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            string userid = Utility.UserId;
            if (entry_by == userid)
            {
                if (txtTicketNo.Text != "" && txtHcn.Text != "")
                {

                    if (chkAccountFlag.Checked == true)
                    {
                        MessageBox.Show("Can not Cancel.Please refund the ticket", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (chkAccountFlag.Checked == false)
                    {
                        if (Convert.ToDouble(txtTktFee.Text) == Convert.ToDouble(txtPaidInCash.Text))
                        {
                            if (MessageBox.Show("Are you sure about the Cancellation of Ticket?", Utility.MessageCaptionMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {

                                short i = opdsr.CancelTicket(txtTicketNo.Text, userid);
                                if (i == 0)
                                {
                                    MessageBox.Show("Cancellation Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (i > 0)
                                {
                                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clean();
                                    btnCancel.Enabled = false;
                                    btnRefund.Enabled = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Can not Cancel the Ticket", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show( "User: " + entry_by_name +"( ID: "+ entry_by + ") "+ "have to cancel the ticket", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clean();
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (txtTicketNo.Text != "" && txtHcn.Text != "")
            {
                if (chkAccountFlag.Checked == false)
                {
                    MessageBox.Show("Can not Refund.Please Cancel the ticket", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (chkAccountFlag.Checked == true)
                {
                    if (Convert.ToDouble(txtTktFee.Text) == Convert.ToDouble(txtPaidInCash.Text))
                    {
                        Ticket tkt = PopulatePrescription();
                        string i = opdsr.RefundTicket(tkt);
                        if (i == "0")
                        {
                            MessageBox.Show("Refund Failed", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i != "")
                        {
                            txtRefundedTicketNo.Text = i;
                            MessageBox.Show("Refund Successfull", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clean();
                            OPDTicketRefund();
                            btnCancel.Enabled = false;
                            btnRefund.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can not Refund the Ticket", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        public void OPDTicketRefund()
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDRefundMR;
            ofrmReportViewerOPD.ParamField = txtRefundedTicketNo.Text;
            ofrmReportViewerOPD.ViewReport();
        }
        private Ticket PopulatePrescription()
        {
            Ticket Refundtkt = new Ticket();
            Refundtkt.TicketNo = txtTicketNo.Text;
            Refundtkt.PurposeID = Utility.GetPurposeCode(Utility.PurposeCode.PrescriptionFee);

            EntryParameter ep = new EntryParameter();
            ep.EntryBy    = Utility.UserId;
            ep.CompanyID  = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID  = Utility.MachineID;
            Refundtkt.EntryParameter = ep;
            return Refundtkt;
        }

        private void txtTicketNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTicketNo.Text.ToUpper().Length == Utility.ScanLength)
            {
                txtTicketNo.Text = txtTicketNo.Text.ToUpper();
            }
        }
    }
}
