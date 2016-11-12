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
    public partial class frmSearch : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public int intVoucherType { get; set; }
        public string strDate { set; get; }
        public string Poststatus { set; get; }
        public frmSearch(int vtype,string vDate,string post)
        {
            InitializeComponent();
            intVoucherType = vtype;
            strDate = vDate;
            Poststatus = post;
            formatSerach();
            LoadListView();
        }
        private void formatSerach()
        {
            lvwVoucherDetails.Clear();

            lvwVoucherDetails.Columns.Add("Voucher No", 120, HorizontalAlignment.Left);
            lvwVoucherDetails.Columns.Add("Voucher Date", 130, HorizontalAlignment.Left);
            lvwVoucherDetails.Columns.Add("Ledger Name", 230, HorizontalAlignment.Left);
            lvwVoucherDetails.Columns.Add("Net Amount", 120, HorizontalAlignment.Left);

        }
        private void LoadListView()
        {
           // lvwVoucherDetails.Items.Clear();
            //List<VoucherTransaction> objTran = accmSc.GetVoucherTransactionDetails(intVoucherType,dtev).ToList();
            //foreach (VoucherTransaction tran in objTran)
            //{
            //    ListViewItem itm = new ListViewItem(tran.strRefNo);
            //    itm.SubItems.Add(tran.strVoucherDate.ToString());
            //    //itm.SubItems.Add(tran.strBranchId);
            //    itm.SubItems.Add(tran.strLedgerName);
            //    itm.SubItems.Add(Convert.ToDouble(tran.dblNetDebitAmount).ToString());
            //    lvwVoucherDetails.Items.Add(itm);
            //}

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

        private void lvwVoucherDetails_DoubleClick(object sender, EventArgs e)
        {
            if (lvwVoucherDetails.SelectedItems.Count == 0)
            {
                return;
            }
            frmVoucher frm = new frmVoucher(lvwVoucherDetails.FocusedItem.SubItems[0].Text.ToString(), intVoucherType);
           // this.Dispose();
            
        }
    }
}
