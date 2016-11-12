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
    public partial class frmVoucherDetails : AH.Shared.UI.frmSmartFormStandard
    {
        public string strDate { set; get; }
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public string Poststatus { set; get; }
        public int intVoucherType { get; set; }
        public frmVoucherDetails()
        {
            InitializeComponent();
        }

        #region "Function"
        private static string GetVoucherName(int intVoucherType)
        {
            string strVoucherName = "";
            if (intVoucherType == (int) Utility.VoucherType.vtPayment)
            {
                strVoucherName = "Payment Voucher List";
            }
            else if (intVoucherType == (int)Utility.VoucherType.vtReceipt)
            {
                strVoucherName = "Receipt Voucher List";
            }
            else if (intVoucherType == (int)Utility.VoucherType.vtJournal)
            {
                strVoucherName = "Journal Voucher List";
            }
            else if (intVoucherType == (int)Utility.VoucherType.vtContra)
            {
                strVoucherName = "Contra Voucher List";
            }
            return strVoucherName.ToString();
        }
        #endregion
        #region "Load List"
        private void LoadListView()
        {
            
            lvwVoucherDetails.Items.Clear();
            List<VoucherTransaction> objTran = accmSc.GetVoucherTransactionDetails(intVoucherType, strDate, strDate, Poststatus).ToList();
            foreach (VoucherTransaction tran in objTran)
            {
                ListViewItem itm = new ListViewItem(tran.strRefNo);
                itm.SubItems.Add(tran.strVoucherDate.ToString());
                //itm.SubItems.Add(tran.strBranchId);
                itm.SubItems.Add(tran.strLedgerName);
                itm.SubItems.Add(Convert.ToDouble(tran.dblNetDebitAmount).ToString());
                lvwVoucherDetails.Items.Add(itm);
            }
        }
        private void frmVoucherDetails_Load(object sender, EventArgs e)
        {
            frmLabel.Text= GetVoucherName(intVoucherType);
            LoadListView();
        }
        #endregion
        #region "Click"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwVoucherDetails.Items.Count == 0)
            {
                MessageBox.Show("Cannot Empty");
                return;
            }
           
                var strResponse = MessageBox.Show("Do U want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    short i = accmSc.DeleteVoucher(lvwVoucherDetails.FocusedItem.SubItems[0].Text.ToString(),intVoucherType);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                    }
                }
            }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (lvwVoucherDetails.SelectedItems.Count == 0)
            //{
            //    return;
            //}
            //frmVoucherDetails frm1 = new frmVoucherDetails();
            //frmVoucher frm = new frmVoucher();
            //frm.strVoucherNo = lvwVoucherDetails.FocusedItem.SubItems[0].Text.ToString();
            //frm.intVoucherType = intVoucherType;
            //frm.intMode = 1;
            //frm1.Dispose();
            //frm.ShowDialog();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lvwVoucherDetails.Items.Count > 0)
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.LedgerSingle;
                frm.strRefNo = lvwVoucherDetails.FocusedItem.SubItems[0].Text.ToString();
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
