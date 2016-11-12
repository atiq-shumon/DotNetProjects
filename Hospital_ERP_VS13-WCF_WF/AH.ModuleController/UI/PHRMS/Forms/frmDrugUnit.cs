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
    public partial class frmDrugUnit : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        List<DrugUnit> drgr;
        public frmDrugUnit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDrugUnitName", "txtDrugUnitNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                txtDrugUnitName.Select();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvDrugUnit,1,txtDrugUnitName.Text))
            {
                MessageBox.Show("This Unit Name is a duplicate");
                return;
            }
            try
            {
                DrugUnit dr = this.populateDrugGroup();
                short i = phrSr.SaveDrugUnit(dr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtDrugUnitName.Select();
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
        private DrugUnit populateDrugGroup()
        {
            DrugUnit dgr = new DrugUnit();
            dgr.ID = txtDrugUnitID.Text;
            dgr.Name = txtDrugUnitName.Text;
            dgr.NameBeng = txtDrugUnitNameBang.Text;
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
          
            lvDrugUnit.CheckBoxes = false;
            lvDrugUnit.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvDrugUnit.Columns.Add("Name", 275, HorizontalAlignment.Left);
            lvDrugUnit.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvDrugUnit.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvDrugUnit.Items.Clear();
            drgr = phrSr.GetDrugUnit().ToList();
            int i = 0;
            foreach (DrugUnit dg in drgr)
            {
                ListViewItem itm = new ListViewItem(dg.ID);
                itm.SubItems.Add(dg.Name);
                itm.SubItems.Add(dg.NameBeng);
                itm.SubItems.Add(dg.Remarks);
                lvDrugUnit.Items.Add(itm);
            }

        }

        private void frmDrugUnit_Load(object sender, EventArgs e)
        {
            txtDrugUnitName.Select();
            FormatGrid();
            LoadListView();
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvDrugUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrugUnit.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDrugUnit.SelectedItems[0];
                txtDrugUnitID.Text = itm.SubItems[0].Text;
                txtDrugUnitName.Text = itm.SubItems[1].Text;
                txtDrugUnitNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDrugUnitName", "txtDrugUnitNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                txtDrugUnitName.Select();
                return;
            }
            try
            {
                DrugUnit dr = this.populateDrugGroup();
                short i = phrSr.UpdateDrugUnit(dr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtDrugUnitName.Select();
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
        private void SearchListView(IEnumerable<DrugUnit> oResults, string searchString = "")
        {
            IEnumerable<DrugUnit> query;
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

                lvDrugUnit.Items.Clear();
                foreach (DrugUnit dm in query)
                {
                    ListViewItem itm = new ListViewItem(dm.ID);
                    itm.SubItems.Add(dm.Name);
                    itm.SubItems.Add(dm.NameBeng);
                    itm.SubItems.Add(dm.Remarks);
                    lvDrugUnit.Items.Add(itm);
                }
            }

        }
        private void txtDrugUnitName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(drgr,txtDrugUnitName.Text);
        }

    }
}
