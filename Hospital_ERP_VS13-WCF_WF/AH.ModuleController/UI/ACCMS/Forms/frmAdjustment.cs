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
    public partial class frmAdjustment : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public string strLedgerName { set; get; }
        public string strLedgerCode { set; get; }
        List<FixedAssetsAdjustment> objFxd;
        
        public frmAdjustment()
        {
            InitializeComponent();
        }

        #region "FormLoad"
        private void frmAdjustment_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid();
                LoadListView();
                txtLedgercode.Text = strLedgerCode.ToString();
                txtLedgerName.Text = strLedgerName.ToString();
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
        #region "Grid"
        private void FormatGrid()
        {
            lvwFixedAssets.CheckBoxes = false;
            lvwFixedAssets.Columns.Add("RefNo", 200, HorizontalAlignment.Center);
            lvwFixedAssets.Columns.Add("Ledger Code", 0, HorizontalAlignment.Left);
            lvwFixedAssets.Columns.Add("LedgerName", 290, HorizontalAlignment.Left);
            lvwFixedAssets.Columns.Add("Ref. Date", 150, HorizontalAlignment.Left);
            lvwFixedAssets.Columns.Add("Amount", 200, HorizontalAlignment.Left);
        }
        private void SearchListView(IEnumerable<FixedAssetsAdjustment> tests, string searchString = "")
        {
            IEnumerable<FixedAssetsAdjustment> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                query = (from test in tests
                         where test.LedgerName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);

            }
            lvwFixedAssets.Items.Clear();
            foreach (FixedAssetsAdjustment fxd in query)
            {
                ListViewItem itm = new ListViewItem(fxd.RefNo);
                itm.SubItems.Add(fxd.Ledgercode);
                itm.SubItems.Add(fxd.LedgerName);
                itm.SubItems.Add(fxd.adjustmentdate);
                itm.SubItems.Add(fxd.adjustmentAmount.ToString());
                lvwFixedAssets.Items.Add(itm);
            }
        }
        #endregion 
        #region "Load"
        private void LoadListView()
        {

            try
            {
                lvwFixedAssets.Items.Clear();
                //MessageBox.Show("7");
                objFxd = accmSc.GetFixedAssetsAdjustment().ToList();
                //MessageBox.Show("8");
                if (objFxd.Count > 0)
                {
                    foreach (FixedAssetsAdjustment fxd in objFxd)
                    {
                        ListViewItem itm = new ListViewItem(fxd.RefNo);
                        itm.SubItems.Add(fxd.Ledgercode);
                        itm.SubItems.Add(fxd.LedgerName);
                        itm.SubItems.Add(fxd.adjustmentdate);
                        itm.SubItems.Add(fxd.adjustmentAmount.ToString());
                        lvwFixedAssets.Items.Add(itm);
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

        private FixedAssetsAdjustment PopulateFixedAssetsAdjustment()
        {

            FixedAssetsAdjustment objFxd = new FixedAssetsAdjustment();
            if (txtRefNo.Text !="")
            {
                objFxd.RefNo = txtRefNo.Text;
            }
            else
            {
                objFxd.RefNo = "";
            }
            
            objFxd.Ledgercode = txtLedgercode.Text;
            objFxd.adjustmentdate = dteAdjustmentDate.Text;
            objFxd.adjustmentAmount = Convert.ToDouble(txtAdjustmentAmount.Text);

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objFxd.EntryParameter = ep;
            return objFxd;
        }
        #endregion
        #region "Save/Edit/Delete"
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    FixedAssetsAdjustment objFxd = this.PopulateFixedAssetsAdjustment();
                    short i = accmSc.SaveAdjustment(objFxd);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        LoadListView();

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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    FixedAssetsAdjustment objFxd = this.PopulateFixedAssetsAdjustment();
                    short i = accmSc.UpdateAdjustment(objFxd);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
                        LoadListView();

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
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion 
        #region "SelectedChange"
        private void lvwFixedAssets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFixedAssets.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwFixedAssets.SelectedItems[0];
                txtRefNo.Text = itm.SubItems[0].Text;
                txtLedgercode.Text = itm.SubItems[1].Text;
                txtLedgerName.Text = itm.SubItems[2].Text;
                dteAdjustmentDate.Text = itm.SubItems[3].Text;
                txtAdjustmentAmount.Text = itm.SubItems[4].Text;
                txtLedgerName.Focus();
            }
        }
        #endregion 
        #region "Keypress"
        private void txtLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                dteAdjustmentDate.Focus();
            }
        }
        private void dteAdjustmentDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtAdjustmentAmount.Focus();
            }
        }
        private void txtAdjustmentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (btnSave.Enabled)
                {
                    btnSave.Focus();
                }
                else
                {
                    btnEdit.Focus();
                }

            }
        }
        #endregion 
        #region "Click"
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAdjustmentAmount.Text = "";
            txtLedgerName.Focus();
        }
        #endregion 
        #region "Keyup"
        private void txtSerach_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(objFxd, txtSerach.Text);
        }
        #endregion


    }
}
