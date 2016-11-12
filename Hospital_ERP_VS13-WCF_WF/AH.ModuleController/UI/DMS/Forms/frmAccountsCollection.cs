using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.DMSSR;
using AH.ModuleController.UI.ACCMS.Reports.Viewer;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmAccountsCollection : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        
        public frmAccountsCollection()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            dgvCollection.ColumnCount = 5;
            this.dgvCollection.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvCollection.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);
            dgvCollection.Font = new Font("Tahoma", 12); 
            dgvCollection.Columns[0].Name = "Cash Amount";
            dgvCollection.Columns[0].ReadOnly = true;
            dgvCollection.Columns[0].Width = 180;
            dgvCollection.Columns[1].Name = "Debit Card Amount";
            dgvCollection.Columns[1].ReadOnly = true;
            dgvCollection.Columns[1].Width = 180;
            dgvCollection.Columns[2].Name = "Credit Card Amount";
            dgvCollection.Columns[2].ReadOnly = true;
            dgvCollection.Columns[2].Width = 180;
            dgvCollection.Columns[3].Name = "Total Collection";
            dgvCollection.Columns[3].ReadOnly = true;
            dgvCollection.Columns[3].Width = 200;
            dgvCollection.Columns[4].Name = "Total Refund";
            dgvCollection.Columns[4].ReadOnly = true;
            dgvCollection.Columns[4].Width = 180;
        }
        private void frmAccountsCollection_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid();
                txtUserID.Text = Utility.UserId;
                txtUserName.Text = Utility.UserName;
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

        }
        private void LoadGridView(string CollectionDate,string UserID)
        {
            dgvCollection.Rows.Clear();
            int i = 0;
            double payment = 0;
            List<AccountsPayment> oAccounts = dmsSC.GetAccountsPayment(dtCollDate.Text.ToString(),txtUserID.Text.ToString()).ToList();
            if (oAccounts.Count > 0)
            {
                foreach (AccountsPayment oAccount in oAccounts)
                {
                    dgvCollection.Rows.Add(1);
                    dgvCollection.Rows[i].Cells[0].Value = oAccount.CashAmount;
                    dgvCollection.Rows[i].Cells[1].Value = oAccount.DebitCardAmount;
                    dgvCollection.Rows[i].Cells[2].Value = oAccount.CreditCardAmount;
                    dgvCollection.Rows[i].Cells[3].Value = oAccount.TotalCollection;
                    dgvCollection.Rows[i].Cells[4].Value = oAccount.RefundAmount;
                    payment =Convert.ToDouble(dgvCollection.Rows[i].Cells[3].Value) - Convert.ToDouble(dgvCollection.Rows[i].Cells[4].Value);
                    i = i + 1;
                }
                txtFinalPayment.Text = payment.ToString();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "dtCollDate", "txtEmpID" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                LoadGridView(dtCollDate.Text.ToString(), txtUserID.Text.ToString());
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

        private AccountsPayment PopulateAccountsPayment()
        {
            AccountsPayment oAccountObj = new AccountsPayment();
            for (int i = 0; i < dgvCollection.Rows.Count; i++)
            {
                oAccountObj.UserID = txtUserID.Text;
                oAccountObj.CashAmount =Convert.ToDouble(dgvCollection.Rows[i].Cells[0].Value.ToString());
                oAccountObj.CreditCardAmount = Convert.ToDouble(dgvCollection.Rows[i].Cells[2].Value.ToString());
                oAccountObj.DebitCardAmount = Convert.ToDouble(dgvCollection.Rows[i].Cells[1].Value.ToString());
                oAccountObj.PaymentAmount = Convert.ToDouble(txtFinalPayment.Text.ToString());
                oAccountObj.Remarks = txtRemarks.Text;
                oAccountObj.CollectionDate = dtCollDate.Text.ToString();
                EntryParameter ep = new EntryParameter();
                ep.EntryBy = Utility.UserId;
                ep.CompanyID = Utility.CompanyID;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                oAccountObj.EntryParameter = ep;
            }

            return oAccountObj;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(dgvCollection.Rows.Count==0)
            {
                MessageBox.Show("No Collection Have to Sent..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int FinalPayment =Convert.ToInt32(txtFinalPayment.Text.ToString());
            if (FinalPayment <= 0)
            {
                MessageBox.Show("No Collection!Please Wait For Collection..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < dgvCollection.Rows.Count; i++)
            {
                if(Convert.ToDouble(dgvCollection.Rows[i].Cells[0].Value)<0)
                {
                    MessageBox.Show("Please Wait For Cash Collection..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                AccountsPayment oAccountObj = this.PopulateAccountsPayment();
                string i = dmsSC.SaveAccountsPayment(oAccountObj);                                        
                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i != "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCollection.Rows.Clear();
                    btnShow_Click(sender, e);
                    txtVoucherNo.Text =i;
                    PrintVoucher(txtVoucherNo.Text);

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
           private void PrintVoucher(string VoucherNo)
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.Pvoucher;
                frm.intVoucherType = 2;
                frm.WhereCondition = VoucherNo.ToString();
                frm.Where2 = "N";
                frm.strFromDate = DateTime.Now.ToString("dd/MM/yyyy");
                frm.strToDate = DateTime.Now.ToString("dd/MM/yyyy");
                frm.strBranchID = "0001";
                frm.strControls = "Individual";
                frm.ShowDialog();
            }
        #region CashManagemnt
              
        private void UpdateTotalAmount(string OneThou,string FiveHun,string OneHun,string Fitfy,string Twenty,string Ten,string Five,string Two,string One)
        {
            double sum = 0;
            sum = Convert.ToDouble(OneThou.ToString()) + Convert.ToDouble(FiveHun.ToString()) + Convert.ToDouble(OneHun.ToString()) +
                  Convert.ToDouble(Fitfy.ToString()) + Convert.ToDouble(Twenty.ToString()) + Convert.ToDouble(Ten.ToString()) +
                  Convert.ToDouble(Five.ToString()) + Convert.ToDouble(Two.ToString()) + Convert.ToDouble(One.ToString());
            lblTotal.Text = sum.ToString();          
        }

        private void txt1000_TextChanged(object sender, EventArgs e)
        {
            if (txt1000.Text != "")
            {
                txtTotal1000.Text = (1000 * Convert.ToDouble(txt1000.Text.ToString())).ToString();
            }
            else
            {
                txtTotal1000.Text = "0";
            }
            UpdateTotalAmount(txtTotal1000.Text, "0", "0", "0", "0", "0", "0", "0", "0");
        }

        private void txt500_TextChanged(object sender, EventArgs e)
        {
            if (txt500.Text != "")
            {
                txtTotal500.Text = (500 * Convert.ToDouble(txt500.Text.ToString())).ToString();
            }
            else
            {
                txtTotal500.Text = "0";
            }
            UpdateTotalAmount(txtTotal1000.Text, txtTotal500.Text, "0", "0", "0", "0", "0", "0", "0");
        }

        private void txt100_TextChanged(object sender, EventArgs e)
        {
            if (txt100.Text != "")
            {
                txtTotal100.Text = (100 * Convert.ToDouble(txt100.Text.ToString())).ToString();
            }
            else
            {
                txtTotal100.Text = "0";
            }
            UpdateTotalAmount(txtTotal1000.Text, txtTotal500.Text, txtTotal100.Text, "0", "0", "0", "0", "0", "0");
        }

        private void txt50_TextChanged(object sender, EventArgs e)
        {
            if (txt50.Text != "")
            {
                txtTotal50.Text = (50 * Convert.ToDouble(txt50.Text.ToString())).ToString();
            }
            else
            {
                txtTotal50.Text = "0";
            }
            UpdateTotalAmount(txtTotal1000.Text, txtTotal500.Text, txtTotal100.Text, txtTotal50.Text, "0", "0", "0", "0", "0");
        }

        private void txt20_TextChanged(object sender, EventArgs e)
        {
            if (txt20.Text != "")
            {
                txtTotal20.Text = (20 * Convert.ToDouble(txt20.Text.ToString())).ToString();
            }
            else
            {
                txtTotal20.Text = "0";
            }
            UpdateTotalAmount(txtTotal1000.Text, txtTotal500.Text, txtTotal100.Text, txtTotal50.Text, txtTotal20.Text, "0", "0", "0", "0");
        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {
            if (txt10.Text != "")
            {
                txtTotal10.Text = (10 * Convert.ToDouble(txt10.Text.ToString())).ToString();
            }
            else
            {
                txtTotal10.Text = "0";
            }
            UpdateTotalAmount(txtTotal1000.Text, txtTotal500.Text, txtTotal100.Text, txtTotal50.Text, txtTotal20.Text, txtTotal10.Text, "0", "0", "0");
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            if (txt5.Text != "")
            {
                txtTotal5.Text = (5 * Convert.ToDouble(txt5.Text.ToString())).ToString();
            }
            else
            {
                txtTotal5.Text = "0";
            }
            UpdateTotalAmount(txtTotal1000.Text, txtTotal500.Text, txtTotal100.Text, txtTotal50.Text, txtTotal20.Text, txtTotal10.Text, txtTotal5.Text, "0", "0");
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                txtTotal2.Text = (2 * Convert.ToDouble(txt2.Text.ToString())).ToString();
            }
            else
            {
                txtTotal2.Text = "0";
            }
            UpdateTotalAmount(txtTotal1000.Text, txtTotal500.Text, txtTotal100.Text, txtTotal50.Text, txtTotal20.Text, txtTotal10.Text, txtTotal5.Text, txtTotal2.Text, "0");
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                txtTotal1.Text = (1 * Convert.ToDouble(txt1.Text.ToString())).ToString();
            }
            else
            {
                txtTotal1.Text = "0";
            }
            UpdateTotalAmount(txtTotal1000.Text, txtTotal500.Text, txtTotal100.Text, txtTotal50.Text, txtTotal20.Text, txtTotal10.Text, txtTotal5.Text, txtTotal2.Text, txtTotal1.Text);
        }
        #endregion

    }
}
