using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmDrugPacketType : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        List<DrugPackType> drgr;
        public frmDrugPacketType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDrugPacketName", "txtDrugPacketNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                txtDrugPacketName.Select();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvDrugPacketType,1,txtDrugPacketName.Text))
            {
                MessageBox.Show("This Type Name is a duplicate");
                return;
            }
            try
            {
                DrugPackType dr = this.populateDrugGroup();
                short i = phrSr.SaveDrugPackType(dr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtDrugPacketName.Select();
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
        
        private DrugPackType populateDrugGroup()
        {
            DrugPackType dgr = new DrugPackType();
            dgr.ID = txtPacketID.Text;
            dgr.Name = txtDrugPacketName.Text;
            dgr.NameBeng = txtDrugPacketNameBang.Text;
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

            lvDrugPacketType.CheckBoxes = false;
            lvDrugPacketType.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvDrugPacketType.Columns.Add("Name", 275, HorizontalAlignment.Left);
            lvDrugPacketType.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvDrugPacketType.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvDrugPacketType.Items.Clear();
            drgr = phrSr.GetDrugPackType().ToList();
            int i = 0;
            foreach (DrugPackType dg in drgr)
            {
                ListViewItem itm = new ListViewItem(dg.ID);
                itm.SubItems.Add(dg.Name);
                itm.SubItems.Add(dg.NameBeng);
                itm.SubItems.Add(dg.Remarks);
                lvDrugPacketType.Items.Add(itm);
            }

        }

        private void frmDrugPacketType_Load(object sender, EventArgs e)
        {
            txtDrugPacketName.Select();
            FormatGrid();
            LoadListView();
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvDrugPacketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrugPacketType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDrugPacketType.SelectedItems[0];
                txtPacketID.Text = itm.SubItems[0].Text;
                txtDrugPacketName.Text = itm.SubItems[1].Text;
                txtDrugPacketNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDrugPacketName", "txtDrugPacketNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                txtDrugPacketName.Select();
                return;
            }
            try
            {
                DrugPackType dr = this.populateDrugGroup();
                short i = phrSr.UpdateDrugPackType(dr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtDrugPacketName.Select();
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
        private void SearchListView(IEnumerable<DrugPackType> oResults, string searchString = "")
        {
            IEnumerable<DrugPackType> query;
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

                lvDrugPacketType.Items.Clear();
                foreach (DrugPackType dm in query)
                {
                    ListViewItem itm = new ListViewItem(dm.ID);
                    itm.SubItems.Add(dm.Name);
                    itm.SubItems.Add(dm.NameBeng);
                    itm.SubItems.Add(dm.Remarks);
                    lvDrugPacketType.Items.Add(itm);
                }
            }

        }
        private void txtDrugPacketName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(drgr,txtDrugPacketName.Text);
        }
    }
}
