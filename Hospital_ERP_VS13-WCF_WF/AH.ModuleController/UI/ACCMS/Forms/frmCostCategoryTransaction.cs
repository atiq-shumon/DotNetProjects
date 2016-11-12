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

namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmCostCategoryTransaction : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public int J { get; set; }
        public string strVoucherNo { set; get; }
        public string strLedgerName { set; get; }
        public double dblAmount { set; get; }
        public string strLedgerCode { set; get; }
        public string strTranDate { set; get; }
        public frmCostCategoryTransaction()
        {
            InitializeComponent();
        }

        #region "Loadlist"
        private void LoadListView(string strLedgerCode)
        {
            try
            {
                int i = 0;
                int k = 0;
                double dblamount = 0;
                List<CostCenterTransation> objCostTran = accmSc.DisplayCostcenterTransaction("DisplayCostcenter", strVoucherNo, strLedgerCode).ToList();
                i = objCostTran.Count();
                if (i > 0)
                {
                    DG.Rows.Add(i);

                    foreach (CostCenterTransation Cost in objCostTran)
                    {
                        DG[0, k].Value = Cost.Categorycode;
                        DG[1, k].Value = Cost.CategoryTitle;
                        DG[2, k].Value = Cost.CostCenteCode;
                        DG[3, k].Value = Cost.CoatCenterName;
                        DG[4, k].Value = Cost.Amount;
                        dblamount = dblamount + Cost.Amount;
                        k = k + 1;
                    }
                    lblTotalAmount.Text = dblamount.ToString();
                }
                else
                {
                    List<CostCenterTransation> objCost = accmSc.GetCostCenterTransaction("GetCostcenter", strLedgerCode, "").ToList();

                    i = objCost.Count();
                    if (i > 0)
                    {
                        DG.Rows.Add(i);
                    }
                    foreach (CostCenterTransation Cost in objCost)
                    {
                        DG[0, k].Value = Cost.Categorycode;
                        DG[1, k].Value = Cost.CategoryTitle;
                        DG[2, k].Value = Cost.CostCenteCode;
                        DG[3, k].Value = Cost.CoatCenterName;
                        k = k + 1;
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
        private void frmCostCategoryTransaction_Load(object sender, EventArgs e)
        {
            lblLedgerName.Text = strLedgerName.ToString();
            lblAmount.Text = dblAmount.ToString();
            txtVoucherNo.Text = strVoucherNo.ToString();
            txtLedgerCode.Text = strLedgerCode.ToString();
            dteTransactiondate.Text = strTranDate.ToString();
            LoadListView(txtLedgerCode.Text);
            if(lblTotalAmount.Text =="0")
            {
                btnSave.Enabled = true ;
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
            }
        }
        #endregion
        #region "Save/Edit"
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (lblTotalAmount.Text != lblAmount.Text)
            {
               MessageBox.Show("Total Amount Mismatch");
               return ;
            }
            try
            {

                CostCenterTransation objCost = this.PopulateCostCenter();
                for (int i = 0; i < DG.Rows.Count - 1; i++)
                {

                    int k = accmSc.SaveCostCentertransaction(txtVoucherNo.Text, DG[0, i].Value.ToString(), strTranDate, DG[2, i].Value.ToString(),
                                                                 txtLedgerCode.Text.ToString(), Convert.ToDouble(DG[4, i].Value), objCost);
                    J = k;
                }

                if (J == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (J > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtVoucherNo.Focus();
                    this.Dispose();
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblTotalAmount.Text != lblAmount.Text)
            {
                MessageBox.Show("Total Amount Mismatch");
                return;
            }
            try
            {

                CostCenterTransation objCost = this.PopulateCostCenter();
                for (int i = 0; i < DG.Rows.Count - 1; i++)
                {

                    int k = accmSc.UpdateCostCenterTran(txtVoucherNo.Text, DG[0, i].Value.ToString(), strTranDate, DG[2, i].Value.ToString(),
                                                                 txtLedgerCode.Text.ToString(), Convert.ToDouble(DG[4, i].Value), objCost);
                    J = k;
                }

                if (J == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (J > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtVoucherNo.Focus();
                    this.Dispose();

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
        #region "CellEdit"
        private void DG_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double dblAmount=0;
            for (int i=0; i <  DG.Rows.Count-1;i++)
            {
                dblAmount = dblAmount + Convert.ToDouble(DG[4, i].Value);

            }
            lblTotalAmount.Text = dblAmount.ToString();
        }
        #endregion
        #region "Keypress"
        private void DG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                btnSave.Focus();

            }
        }
        #endregion

    }
}
