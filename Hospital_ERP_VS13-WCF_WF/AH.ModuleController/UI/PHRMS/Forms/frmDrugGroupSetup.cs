using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmDrugGroupSetup : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        List<DrugGroup> drgr;
        public frmDrugGroupSetup()
        {
            InitializeComponent();
        }

        private void lvDrug_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrugGroup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDrugGroup.SelectedItems[0];
                txtDrugGroupID.Text = itm.SubItems[0].Text;
                txtDrugGroupName.Text = itm.SubItems[1].Text;
                txtDrugGroupNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDrugGroupName", "txtDrugGroupNameBang"};
            Control control = Utility.ReqFieldValidator(this,vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvDrugGroup,1,txtDrugGroupName.Text))
            {
                MessageBox.Show("This Group Name is a duplicate");
                return;
            }
            try
            {
                DrugGroup dr = this.populateDrugGroup();
                short i = phrSr.SaveDrugGroup(dr);

                if(i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg,Utility.MessageCaptionMsg,MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
                else if(i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg,Utility.MessageCaptionMsg,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtDrugGroupName.Select();
                    RefreshGrid();
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
        private DrugGroup populateDrugGroup()
        {
            DrugGroup dgr = new DrugGroup();
            dgr.ID = txtDrugGroupID.Text;
            dgr.Name = txtDrugGroupName.Text;
            dgr.NameBeng = txtDrugGroupNameBang.Text;
            dgr.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            dgr.EntryParameter = ep;

            return dgr;
        }
        private void FormatGrid()
        {
            lvDrugGroup.CheckBoxes = false;
            lvDrugGroup.Columns.Add("ID",100,HorizontalAlignment.Left);
            lvDrugGroup.Columns.Add("Name",500,HorizontalAlignment.Left);
            lvDrugGroup.Columns.Add("NameBeng",0,HorizontalAlignment.Left);
            lvDrugGroup.Columns.Add("Remarks",150,HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvDrugGroup.Items.Clear();
            drgr = phrSr.GetDrugGroup().ToList();
            int i = 0;
            foreach (DrugGroup dg in drgr)
            {
                ListViewItem itm = new ListViewItem(dg.ID);
                itm.SubItems.Add(dg.Name);
                itm.SubItems.Add(dg.NameBeng);
                itm.SubItems.Add(dg.Remarks);
                lvDrugGroup.Items.Add(itm);
            }

        }

        private void frmDrugGroupSetup_Load(object sender, EventArgs e)
        {
            txtDrugGroupName.Select();

            FormatGrid();
            LoadListView();
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDrugGroupName", "txtDrugGroupNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                DrugGroup dr = this.populateDrugGroup();
                short i = phrSr.UpdateGroup(dr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtDrugGroupName.Select();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        private void SearchListView(IEnumerable<DrugGroup> oResults, string searchString = "")
        {
            IEnumerable<DrugGroup> query;
            if (oResults != null)
            {
                if (!(searchString.Length > 0))
                {
                    query = oResults;
                }
                else
                {
                    query = (from oRes in oResults
                             where oRes.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select oRes);
                }

                lvDrugGroup.Items.Clear();
                foreach (DrugGroup dm in query)
                {
                    ListViewItem itm = new ListViewItem(dm.ID);
                    itm.SubItems.Add(dm.Name);
                    itm.SubItems.Add(dm.NameBeng);                    
                    itm.SubItems.Add(dm.Remarks);
                    lvDrugGroup.Items.Add(itm);
                }
            }

        }
        private void txtDrugGroupName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(drgr, txtDrugGroupName.Text);
        }

    }
}
