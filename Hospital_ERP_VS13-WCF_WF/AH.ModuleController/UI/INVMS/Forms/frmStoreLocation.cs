using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmStoreLocation : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();

        public frmStoreLocation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtStoreName", "txtContactPerson", "txtBlockNo", "txtPhoneNo", "txtPriority" };
            Control control = Utility.ReqFieldValidator(this,vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvStoreLocation,4,txtStoreName.Text))
            {
                MessageBox.Show("This store name already exist");
                return;
            }
            try
            {
                StoreLocation ostore = this.populateStoreLoc();
                short i = invSr.SaveStoreLocation(ostore);

                 if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtStoreName.Select();
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
        private StoreLocation populateStoreLoc()
        {
            StoreLocation ostore = new StoreLocation();
            ostore.ID = txtStoreID.Text;
            ostore.Name = txtStoreName.Text;
            ostore.Block = txtBlockNo.Text;
            ostore.Phone = txtPhoneNo.Text;
            ostore.ContactPerson = txtContactPerson.Text;
            ostore.Remarks = txtRemarks.Text;
            ostore.Priority = txtPriority.Text;

            StoreTypeSCM ostrtype = new StoreTypeSCM();
            ostrtype.strTypeID = cboStoreType.SelectedValue.ToString();
            ostore.StoreType = ostrtype;

            Building obuilding = new Building();
            obuilding.BuildingID = cboBuilding.SelectedValue.ToString();
            obuilding.Floors = short.Parse(cboFloorNo.SelectedValue.ToString());
            ostore.Building = obuilding;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ostore.EntryParameter = ep;

            return ostore;
        }

        private void frmStoreLocation_Load(object sender, EventArgs e)
        {
            List<short> listvalues = invSr.GetNumbers(0, 12).ToList();
            cboFloorNo.DataSource = listvalues;

            cboStoreType.ValueMember = "strTypeID";
            cboStoreType.DisplayMember = "TypeTitle";
            cboStoreType.DataSource = new BindingSource(invSr.GetStoreType(), null);

            cboBuilding.DisplayMember = "Value";
            cboBuilding.ValueMember = "Key";
            cboBuilding.DataSource = new BindingSource(invSr.GetBuildingDict("D"),null);

            FormatGrid();
            LoadListView();
            btnEdit.Enabled = false;
        }
        private void FormatGrid()
        {
            
            lvStoreLocation.CheckBoxes = false;
            lvStoreLocation.Columns.Add("LocationID", 0, HorizontalAlignment.Left);
            lvStoreLocation.Columns.Add("Building", 150, HorizontalAlignment.Left);
            lvStoreLocation.Columns.Add("Floor", 100, HorizontalAlignment.Left);
            lvStoreLocation.Columns.Add("Block", 100, HorizontalAlignment.Left);
            lvStoreLocation.Columns.Add("StoreType", 0, HorizontalAlignment.Left);
            lvStoreLocation.Columns.Add("StoreName", 250, HorizontalAlignment.Left);
            lvStoreLocation.Columns.Add("Phone", 100, HorizontalAlignment.Left);
            lvStoreLocation.Columns.Add("ContactPerson", 150, HorizontalAlignment.Left);
            lvStoreLocation.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvStoreLocation.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvStoreLocation.Items.Clear();
            List<StoreLocation> phloc = invSr.GetStoreLocation().ToList();
            int i = 0;
            foreach (StoreLocation loc in phloc)
            {
                ListViewItem itm = new ListViewItem(loc.ID);
                itm.SubItems.Add(loc.Building.BuildingTitle);
                itm.SubItems.Add(loc.Building.Floors.ToString());
                itm.SubItems.Add(loc.Block);
                itm.SubItems.Add(loc.StoreType.TypeTitle);
                itm.SubItems.Add(loc.Name);
                itm.SubItems.Add(loc.Phone);
                itm.SubItems.Add(loc.ContactPerson);
                itm.SubItems.Add(loc.Priority);
                itm.SubItems.Add(loc.Remarks);
                lvStoreLocation.Items.Add(itm);
            }
        }
        private void LoadListViewByStoreType(string strtype)
        {
            lvStoreLocation.Items.Clear();
            List<StoreLocation> phloc;
            if (strtype.Length != 0)
            {
                phloc = invSr.GetStoreLocByType(strtype).ToList();
            }
            else
            {
                return;
            }
            int i = 0;
            foreach (StoreLocation loc in phloc)
            {
                ListViewItem itm = new ListViewItem(loc.ID);
                itm.SubItems.Add(loc.Building.BuildingTitle);
                itm.SubItems.Add(loc.Building.Floors.ToString());
                itm.SubItems.Add(loc.Block);
                itm.SubItems.Add(loc.StoreType.TypeTitle);
                itm.SubItems.Add(loc.Name);
                itm.SubItems.Add(loc.Phone);
                itm.SubItems.Add(loc.ContactPerson);
                itm.SubItems.Add(loc.Priority);
                itm.SubItems.Add(loc.Remarks);
                lvStoreLocation.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvStoreLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStoreLocation.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvStoreLocation.SelectedItems[0];
                txtStoreID.Text = itm.SubItems[0].Text;
                cboBuilding.Text = itm.SubItems[1].Text;
                cboFloorNo.Text = itm.SubItems[2].Text;
                txtBlockNo.Text = itm.SubItems[3].Text;
                cboStoreType.Text = itm.SubItems[4].Text;
                txtStoreName.Text = itm.SubItems[5].Text;
                txtPhoneNo.Text = itm.SubItems[6].Text;
                txtContactPerson.Text = itm.SubItems[7].Text;
                txtPriority.Text = itm.SubItems[8].Text;
                txtRemarks.Text = itm.SubItems[9].Text;
            }
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                StoreLocation ostore = this.populateStoreLoc();
                short i = invSr.ModifyStoreLocation(ostore);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtStoreName.Select();
                    //RefreshGrid();
                    LoadListViewByStoreType(cboStoreType.SelectedValue.ToString());
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListViewByStoreType(cboStoreType.SelectedValue.ToString());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }
    }
}
