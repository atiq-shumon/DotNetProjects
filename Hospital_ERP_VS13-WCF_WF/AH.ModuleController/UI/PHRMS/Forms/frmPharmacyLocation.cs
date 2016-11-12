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
    public partial class frmPharmacyLocation : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmPharmacyLocation()
        {
            InitializeComponent();
        }

        private void smartLabel7_Click(object sender, EventArgs e)
        {

        }

        private void smartTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormatGrid()
        {
            lvPharmacyLocation.CheckBoxes = false;
            lvPharmacyLocation.Columns.Add("PhamrmacyLocationID", 0, HorizontalAlignment.Left);
            lvPharmacyLocation.Columns.Add("Building",150,HorizontalAlignment.Left);
            lvPharmacyLocation.Columns.Add("Floor",100,HorizontalAlignment.Left);
            lvPharmacyLocation.Columns.Add("Block",100,HorizontalAlignment.Left);
            lvPharmacyLocation.Columns.Add("PharmacyName",250,HorizontalAlignment.Left);
            lvPharmacyLocation.Columns.Add("Phone",100,HorizontalAlignment.Left);
            lvPharmacyLocation.Columns.Add("ContactPerson", 150, HorizontalAlignment.Left);
            lvPharmacyLocation.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvPharmacyLocation.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvPharmacyLocation.Items.Clear();
            List<Pharmacy> phloc = phrSr.GetPharmacyLocation().ToList();
            int i = 0;
            foreach (Pharmacy loc in phloc)
            {
                ListViewItem itm = new ListViewItem(loc.PharmacyID);
                itm.SubItems.Add(loc.Building.BuildingID);
                itm.SubItems.Add(loc.Building.Floors.ToString());
                itm.SubItems.Add(loc.Block);
                itm.SubItems.Add(loc.PharmacyTitle);
                itm.SubItems.Add(loc.Phone);
                itm.SubItems.Add(loc.ContactPerson);
                itm.SubItems.Add(loc.Priority);
                itm.SubItems.Add(loc.Remarks);
                lvPharmacyLocation.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPharmacyName", "txtContactPerson", "txtPhoneNo", "txtPriority", "txtBlockNo" };
            Control control = Utility.ReqFieldValidator(this,vf);


            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name)+Utility.Req,Utility.MessageCaptionMsg,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                control.Focus();
                cboBuilding.Select();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvPharmacyLocation,4,txtPharmacyName.Text))
            {
                MessageBox.Show("This pharmacy is already exist");
                return;
            }
            try
            {
                Pharmacy loc = this.populatePharmacy();
                short i = phrSr.SavePharmacyLocation(loc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnNew.PerformClick();
                    cboBuilding.Focus();
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
        private Pharmacy populatePharmacy()
        {
            Pharmacy lc = new Pharmacy();
            lc.PharmacyID = txtPharmacyLocID.Text;
            lc.PharmacyTitle = txtPharmacyName.Text;
            lc.Phone = txtPhoneNo.Text;
            lc.ContactPerson = txtContactPerson.Text;
            lc.Remarks = txtRemarks.Text;
            lc.Priority = txtPriority.Text;
            lc.Block = txtBlockNo.Text;

            Building bl = new Building();
            bl.BuildingID = cboBuilding.SelectedValue.ToString();
            bl.Floors = short.Parse(cboFloorNo.SelectedValue.ToString());
            lc.Building = bl;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            lc.EntryParameter = ep;

            return lc;
        }

        private void frmPharmacyLocation_Load(object sender, EventArgs e)
        {
            cboBuilding.Select();

            List<short> listvalues = phrSr.GetNumbers(0, 12).ToList();
            cboFloorNo.DataSource = listvalues;

            cboBuilding.DisplayMember = "Value";
            cboBuilding.ValueMember = "Key";
            cboBuilding.DataSource = new BindingSource(phrSr.GetBuildingDict("D"), null);

            FormatGrid();
            LoadListView();
        }

        private void lvPharmacyLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPharmacyLocation.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPharmacyLocation.SelectedItems[0];
                txtPharmacyLocID.Text = itm.SubItems[0].Text;
                cboBuilding.SelectedValue = itm.SubItems[1].Text;
                cboFloorNo.Text = itm.SubItems[2].Text;
                txtBlockNo.Text = itm.SubItems[3].Text;
                txtPharmacyName.Text = itm.SubItems[4].Text;
                txtPhoneNo.Text = itm.SubItems[5].Text;
                txtContactPerson.Text = itm.SubItems[6].Text;
                txtPriority.Text = itm.SubItems[7].Text;
                txtRemarks.Text = itm.SubItems[8].Text;
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPharmacyName", "txtContactPerson", "txtPhoneNo", "txtPriority", "txtBlockNo" };
            Control control = Utility.ReqFieldValidator(this, vf);


            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                cboBuilding.Select();
                return;
            }
            try
            {
                Pharmacy loc = this.populatePharmacy();
                short i = phrSr.UpdatePharmacyLocation(loc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    //btnNew.PerformClick();
                    cboBuilding.Focus();
                    btnSave.Enabled = false;
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
    }
}
