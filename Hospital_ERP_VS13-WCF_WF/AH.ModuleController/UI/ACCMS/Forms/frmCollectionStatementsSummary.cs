using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using AH.ModuleController.DMSSR;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;
using AH.Shared.UI;
//using AH.ModuleController.UI.DMS.Reports.Viewer;



namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmCollectionStatementsSummary : AH.Shared.UI.frmSmartFormStandard
    {

        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();

        public frmCollectionStatementsSummary()
        {
            InitializeComponent();
        }

        private void FormatGrid()
        {
            dgvCollection.ColumnCount = 6;
            this.dgvCollection.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvCollection.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);
            dgvCollection.Font = new Font("Tahoma", 12);
            dgvCollection.Columns[0].Name = "Purpose Code";
            dgvCollection.Columns[0].ReadOnly = true;
            dgvCollection.Columns[0].Width = 0;
            dgvCollection.Columns[0].Visible = false;
            dgvCollection.Columns[1].Name = "Purpose Title";
            dgvCollection.Columns[1].ReadOnly = true;
            dgvCollection.Columns[1].Width = 300;
            dgvCollection.Columns[2].Name = "Cash";
            dgvCollection.Columns[2].ReadOnly = true;
            dgvCollection.Columns[2].Width = 170;
            dgvCollection.Columns[3].Name = "Debit Card";
            dgvCollection.Columns[3].ReadOnly = true;
            dgvCollection.Columns[3].Width = 170;
            dgvCollection.Columns[4].Name = "Credit Card";
            dgvCollection.Columns[4].ReadOnly = true;
            dgvCollection.Columns[4].Width = 170;
            dgvCollection.Columns[5].Name = "Total Collection";
            dgvCollection.Columns[5].ReadOnly = true;
            dgvCollection.Columns[5].Width = 230;
        }

        private void frmCollectionStatementsSummary_Load(object sender, EventArgs e)
        {
            FormatGrid();
        }

        private void LoadGridView(string StartDate, string EndDate)
        {
            dgvCollection.Rows.Clear();
            int i = 0;
            List<OPDPayment> oAccounts = accmSc.GetCollectionSummary(dtCollStartDate.Text.ToString(), dtCollEndDate.Text.ToString()).ToList();
            if (oAccounts.Count > 0)
            {
                foreach (OPDPayment oAccount in oAccounts)
                {
                    dgvCollection.Rows.Add(1);
                    dgvCollection.Rows[i].Cells[0].Value = oAccount.PurposeID;
                    dgvCollection.Rows[i].Cells[1].Value = oAccount.PurposeTitle;
                    dgvCollection.Rows[i].Cells[2].Value = oAccount.CashAmount;
                    dgvCollection.Rows[i].Cells[3].Value = oAccount.DebitCardAmount;
                    dgvCollection.Rows[i].Cells[4].Value = oAccount.CreditCardAmount;
                    dgvCollection.Rows[i].Cells[5].Value = oAccount.NetAmount;
                    i = i + 1;
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "dtCollStartDate", "dtCollEndDate" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            LoadGridView(dtCollStartDate.Text.ToString(), dtCollEndDate.Text.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
