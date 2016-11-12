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
    public partial class frmRevenueHead : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();
        public frmRevenueHead()
        {
            InitializeComponent();
        }

        #region "Formatgrid"
        private void FormatGrid()
        {
            lvRhgr.CheckBoxes = false;
            lvRhgr.Columns.Add("Type ID", 100, HorizontalAlignment.Center);
            lvRhgr.Columns.Add("Type Name", 600, HorizontalAlignment.Left);
            lvRhgr.Columns.Add("Type Name(Bangla)", 0, HorizontalAlignment.Left);
            lvRhgr.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvRhgr.Columns.Add("Remarks", 340, HorizontalAlignment.Left);
            lvRhgr.Columns.Add("Acccode", 0, HorizontalAlignment.Left);
            lvRhgr.Columns.Add("grCode", 0, HorizontalAlignment.Left);
        }
        #endregion
        #region "LedgerInformation"
        private void GetLedgerInformation(string strControl)
        {
            cboLedgerName.ValueMember = "Key";
            cboLedgerName.DisplayMember = "Value";
            //cboLedgerName.DataSource = new BindingSource(accmsc.GetLedgerInformation(strControl), null);
            cboLedgerName.DataSource = new BindingSource(accmsc.GetLedgerCodeAllocation(), null);
        }
        #endregion
        #region "GroupInformation"
        private void GetGroupInfo()
        {
            cboGrouptitle.ValueMember = "Key";
            cboGrouptitle.DisplayMember = "Value";
            cboGrouptitle.DataSource = new BindingSource(accmsc.GetRevenueGroup(), null);
        }
        #endregion
        #region "Poulated"
        private RevenueHead PopulateRevgr()
        {
            RevenueHead revobj = new RevenueHead();
            //lngRevenueGroup = cboGrouptitle.SelectedValue.ToString();
            if (txtRevHdID.Text != "")
            {
                revobj.ID = txtRevHdID.Text;
            }
            revobj.Title = txtRevHdName.Text;
            revobj.TitleBeng = txtRevHdName.Text;
            revobj.RevenueHeadString = cboGrouptitle.SelectedValue.ToString();
            revobj.RevenueAccountsCode = cboLedgerName.SelectedValue.ToString();
            //revobj.Priority = short.Parse(cboPriority.Text);
            revobj.Priority = 1;
            revobj.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            revobj.EntryParameter = ep;

            return revobj;
        }
        #endregion
        #region "LoadList"
        private void LoadListView()
        {
            lvRhgr.Items.Clear();

            List<RevenueHead> rvhdgr = accmsc.GetRevenueHead().ToList();
            int i = 0;
            foreach (RevenueHead rv in rvhdgr)
            {
                ListViewItem itm = new ListViewItem(rv.ID);
                itm.SubItems.Add(rv.Title);
                itm.SubItems.Add(rv.TitleBeng);
                itm.SubItems.Add(rv.Priority.ToString());
                itm.SubItems.Add(rv.Remarks);
                itm.SubItems.Add(rv.RevenueAccountsCode);
                itm.SubItems.Add(rv.RevenueHeadString);
                lvRhgr.Items.Add(itm);
            }
        }
        #endregion
        #region "FormLoad"
        private void frmRevenueHead_Load(object sender, EventArgs e)
        {
            FormatGrid();
            GetLedgerInformation("Costcenter");
            GetGroupInfo();
            LoadListView();
        }
        #endregion
        #region "Refresh" 
        private void RefreshGrid()
        {
            LoadListView();
        }
        #endregion
        #region "Save/Edit"
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRevHdName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                RevenueHead rvgr = this.PopulateRevgr();
                short i = accmsc.SaveRevenueHead(rvgr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtRevHdName.Focus();
                    RefreshGrid();
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
            List<string> vf = new List<string>() { "txtRevHdID", "txtRevHdName", "txtRevHdNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (accmsc.VerifyRevHdGr(txtRevHdID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRevHdID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                RevenueHead rvgr = this.PopulateRevgr();
                short i = accmsc.UpdateRevHead(rvgr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtRevHdName.Focus();
                    RefreshGrid();
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
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
        #region "SelectedIndex"
        private void lvRhgr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRhgr.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvRhgr.SelectedItems[0];
                txtRevHdID.Text = itm.SubItems[0].Text;
                txtRevHdName.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[4].Text;
                cboLedgerName.SelectedValue = itm.SubItems[5].Text;
                cboGrouptitle.SelectedValue = itm.SubItems[6].Text.ToString();
                
            }
        }
        #endregion
        #region "Click"
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtRevHdName.Focus();
            btnSave.Enabled = true ;
            btnEdit.Enabled = false;
        }
        #endregion
        #region "Keydown"
        private void cboLedgerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Z))
            {
                frmLedger frm = new frmLedger();
                frm.ShowDialog();
                GetLedgerInformation("Costcenter");

            }
        }
        #endregion


    }
}
