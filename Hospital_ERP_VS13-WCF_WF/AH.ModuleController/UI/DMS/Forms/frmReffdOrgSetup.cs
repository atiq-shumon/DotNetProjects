using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmReffdOrgSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        private List<RefdOrg> oRefdOrgs;
        public frmReffdOrgSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvReffOrg.CheckBoxes = false;
            lvReffOrg.Columns.Add("Org ID", 0, HorizontalAlignment.Center);
            lvReffOrg.Columns.Add("Organization Name", 250, HorizontalAlignment.Left);
            lvReffOrg.Columns.Add("Organization Name(Bangla)", 0, HorizontalAlignment.Left);
            lvReffOrg.Columns.Add("Address", 250, HorizontalAlignment.Left);
            lvReffOrg.Columns.Add("Phone", 150, HorizontalAlignment.Left);
            lvReffOrg.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lvReffOrg.Columns.Add("Web", 150, HorizontalAlignment.Left);
            lvReffOrg.Columns.Add("Remarks", 250, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvReffOrg.Items.Clear();
            oRefdOrgs = dmsSc.GetReffdOrg().ToList();
            foreach (RefdOrg oRefdOrg in oRefdOrgs)
            {
                ListViewItem itm = new ListViewItem(oRefdOrg.OrgID);
                itm.SubItems.Add(oRefdOrg.OrgTitle);
                itm.SubItems.Add(oRefdOrg.OrgTitleBeng);
                itm.SubItems.Add(oRefdOrg.Address);
                itm.SubItems.Add(oRefdOrg.Phone);
                itm.SubItems.Add(oRefdOrg.Email);
                itm.SubItems.Add(oRefdOrg.Web);
                itm.SubItems.Add(oRefdOrg.Remarks);
                lvReffOrg.Items.Add(itm);
            }
        }
        private void frmReffdOrgSetup_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid();
                LoadListView();
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

        private void lvReffOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvReffOrg.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvReffOrg.SelectedItems[0];
                txtOrgID.Text = itm.SubItems[0].Text;
                txtOrgName.Text = itm.SubItems[1].Text;
                txtOrgNameBeng.Text = itm.SubItems[2].Text;
                txtAddress.Text = itm.SubItems[3].Text;
                txtPhone.Text = itm.SubItems[4].Text;
                txtEmail.Text = itm.SubItems[5].Text;
                txtWeb.Text = itm.SubItems[6].Text;
                txtRemarks.Text = itm.SubItems[7].Text;
            }
        }

        private void lvReffOrg_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtOrgName_TextChanged(object sender, EventArgs e)
        {
            txtOrgNameBeng.Text = txtOrgName.Text;
        }
        private RefdOrg PopulateRefdOrgSetup()
        {
            RefdOrg oRefdOrg = new RefdOrg();
            oRefdOrg.OrgID = txtOrgID.Text;
            oRefdOrg.OrgTitle= txtOrgName.Text;
            oRefdOrg.OrgTitleBeng = txtOrgNameBeng.Text;
            oRefdOrg.Address = txtAddress.Text;
            oRefdOrg.Phone = txtPhone.Text;
            oRefdOrg.Email = txtEmail.Text;
            oRefdOrg.Web = txtWeb.Text;
            oRefdOrg.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oRefdOrg.EntryParameter = ep;
            return oRefdOrg;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtOrgName", "txtOrgNameBeng", "txtAddress" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                RefdOrg oRefdOrg = this.PopulateRefdOrgSetup();
                short i = dmsSc.SaveReffdOrg(oRefdOrg);
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
            List<string> vf = new List<string>() { "txtOrgID","txtOrgName", "txtOrgNameBeng", "txtAddress" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }           
            try
            {
                RefdOrg oRefdOrg = this.PopulateRefdOrgSetup();
                short i = dmsSc.UpdateReffdOrg(oRefdOrg);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    LoadListView();
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

        private void txtOrgName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(oRefdOrgs, txtOrgName.Text);
        }
        private void SearchListView(IEnumerable<RefdOrg> oResults, string searchString = "")
        {
            IEnumerable<RefdOrg> query;
            if (oResults != null)
            {
                if (!(searchString.Length > 0))
                {
                    query = oResults;
                }
                else
                {
                    query = (from oRes in oResults
                             where oRes.OrgTitle.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select oRes);
                }
                lvReffOrg.Items.Clear();
                foreach (RefdOrg oRefdOrg in query)
                 {
                    ListViewItem itm = new ListViewItem(oRefdOrg.OrgID);
                    itm.SubItems.Add(oRefdOrg.OrgTitle);
                    itm.SubItems.Add(oRefdOrg.OrgTitleBeng);
                    itm.SubItems.Add(oRefdOrg.Address);
                    itm.SubItems.Add(oRefdOrg.Phone);
                    itm.SubItems.Add(oRefdOrg.Email);
                    itm.SubItems.Add(oRefdOrg.Web);
                    itm.SubItems.Add(oRefdOrg.Remarks);
                    lvReffOrg.Items.Add(itm);
                }
            }

        }

    }
}
