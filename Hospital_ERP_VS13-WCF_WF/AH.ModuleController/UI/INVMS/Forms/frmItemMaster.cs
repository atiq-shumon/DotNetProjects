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
    public partial class frmItemMaster : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        private List<ItemMaster> dmas;
        public frmItemMaster()
        {
            InitializeComponent();
        }

        private void frmItemMaster_Load(object sender, EventArgs e)
        {
            cboStoreType.Select();

            cboCompany.DisplayMember = "Name";
            cboCompany.ValueMember = "ID";
            cboCompany.DataSource = new BindingSource(invSr.GetCompanyDetails(), null);

            //cboGroup.DisplayMember = "Name";
            //cboGroup.ValueMember = "ID";
            //cboGroup.DataSource = new BindingSource(invSr.GetGroupDetails(),null);
            cboGroup.DataSource = null;

            cboUnit.DisplayMember = "Name";
            cboUnit.ValueMember = "ID";
            cboUnit.DataSource = new BindingSource(invSr.GetUnitSetup(),null);

            cboPacket.DisplayMember = "Name";
            cboPacket.ValueMember = "ID";
            cboPacket.DataSource = new BindingSource(invSr.GetPacketType(),null);

            cboModel.DisplayMember = "Name";
            cboModel.ValueMember = "ID";
            cboModel.DataSource = new BindingSource(invSr.GetModelDetails(),null);

            cboBrand.DisplayMember = "Name";
            cboBrand.ValueMember = "ID";
            cboBrand.DataSource = new BindingSource(invSr.GetBrandDetails(),null);

            cboStoreType.ValueMember = "strTypeID";
            cboStoreType.DisplayMember = "TypeTitle";
            cboStoreType.DataSource = invSr.LoadStoreType().ToList();

            cboMajorGroup.DataSource = null;
            //cboMajorGroup.ValueMember = "MajorgrpID";
            //cboMajorGroup.DisplayMember = "Name";
            //cboMajorGroup.DataSource = invSr.GetMajorGrp().ToList();

            FormatGrid();
            //LoadListView();
            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtItemName", "txtItemNameBeng", "txtReorderQty"};
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvItemMaster, 1, txtItemName.Text))
            {
                MessageBox.Show("This Item is already saved");
                btnNew.PerformClick();

                return;
            }
            if (cboMajorGroup.DataSource == null)
            {
                MessageBox.Show("Please select Group");

                return;
            }
            try
            {
                ItemMaster mstr = this.populateItemMaster();
                short i = invSr.SaveItemMaster(mstr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtItemName.Select();
                    RefreshGrid();
                    //txtDose.Text = "0 + 0 + 1";
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
        private ItemMaster populateItemMaster()
        {
            ItemMaster oitem = new ItemMaster();
            oitem.ID = txtItemID.Text;
            oitem.Name = txtItemName.Text;
            oitem.NameBeng = txtItemNameBeng.Text;
            oitem.Remarks = txtRemarks.Text;
            oitem.ReorderQty = int.Parse(txtReorderQty.Text);
            oitem.ReorderCycle = int.Parse(txtReorderCycle.Text);
            oitem.Priority = int.Parse("1");
            oitem.SerialPriority = int.Parse("1");
            //oitem.StoreType = cboStoreLocation.SelectedValue.ToString();

            oitem.IsExpDate = chkExpireDate.Checked ? "1" : "0";
            oitem.IsSerial = chkSerialReq.Checked ? "1" : "0";
            oitem.IsBillable = chkBillable.Checked ? "1" : "0";
            oitem.IsWarranty = chkWarrantyRequire.Checked ? "1" : "0";

            Majorgroup omajor = new Majorgroup();
            omajor.MajorgrpID = cboMajorGroup.SelectedValue.ToString();
            oitem.Majorgroup = omajor;
           

            CompanySetup ocompany = new CompanySetup();
            ocompany.ID = cboCompany.SelectedValue.ToString();
            oitem.Company = ocompany;

            GroupDetails ogroup = new GroupDetails();
            ogroup.ID = cboGroup.SelectedValue.ToString();
            oitem.GroupDetails = ogroup;

            Units ounit = new Units();
            ounit.ID = cboUnit.SelectedValue.ToString();
            oitem.Units = ounit;

            PacketType otype = new PacketType();
            otype.ID = cboPacket.SelectedValue.ToString();
            oitem.PacketType = otype;

            ModelSetup omodel = new ModelSetup();
            omodel.ID = cboModel.SelectedValue.ToString();
            oitem.ModelSetup = omodel;

            BrandSetup obrand = new BrandSetup();
            obrand.ID = cboBrand.SelectedValue.ToString();
            oitem.BrandSetup = obrand;


            StoreTypeSCM ostore = new StoreTypeSCM();
            ostore.strTypeID = cboStoreType.SelectedValue.ToString();
            oitem.StoreType = ostore;


            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oitem.EntryParameter = ep;

            return oitem;
        }
        private void FormatGrid()
        {
            
            lvItemMaster.CheckBoxes = false;
            lvItemMaster.Columns.Add("Item ID", 90, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Item Name", 350, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Item NameBeng", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Company", 200, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Group", 230, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Packet", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Unit", 70, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Model", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Brand", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("ReorderQuantity", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("ReorderCycle", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("SerialPriority", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("IsExpireDate", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("IsSerial", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("IsBillable", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("IsWarranty", 0, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("StoreName", 200, HorizontalAlignment.Left);
            lvItemMaster.Columns.Add("MajorGroup", 100, HorizontalAlignment.Left);
            
        }
        private void LoadListView()
        {
            lvItemMaster.Items.Clear();

            dmas = invSr.GetItemMaster().ToList();
            int i = 0;

            foreach (ItemMaster dm in dmas)
            {
                ListViewItem itm = new ListViewItem(dm.ID);
                itm.SubItems.Add(dm.Name);
                itm.SubItems.Add(dm.NameBeng);
                itm.SubItems.Add(dm.Company.Name);
                itm.SubItems.Add(dm.GroupDetails.Name);
                itm.SubItems.Add(dm.PacketType.Name);
                itm.SubItems.Add(dm.Units.Name);
                itm.SubItems.Add(dm.ModelSetup.Name);
                itm.SubItems.Add(dm.BrandSetup.Name);
                itm.SubItems.Add(dm.ReorderQty.ToString());
                itm.SubItems.Add(dm.ReorderCycle.ToString());
                itm.SubItems.Add(dm.Priority.ToString());
                itm.SubItems.Add(dm.SerialPriority.ToString());
                itm.SubItems.Add(dm.Remarks);
                itm.SubItems.Add(dm.IsExpDate);
                itm.SubItems.Add(dm.IsSerial);
                itm.SubItems.Add(dm.IsBillable);
                itm.SubItems.Add(dm.IsWarranty);
                itm.SubItems.Add(dm.StoreType.TypeTitle);
                itm.SubItems.Add(dm.Majorgroup.Name);
                lvItemMaster.Items.Add(itm);
            }

        }
        private void LoadListViewByGroup(string grpid)
        {
            lvItemMaster.Items.Clear();


            if (grpid.Length != 0)
            {
                dmas = invSr.GetItemMasterByGroup(grpid).ToList();
            }
            else
            {
                return;
            }
            

            foreach (ItemMaster dm in dmas)
            {
                ListViewItem itm = new ListViewItem(dm.ID);
                itm.SubItems.Add(dm.Name);
                itm.SubItems.Add(dm.NameBeng);
                itm.SubItems.Add(dm.Company.Name);
                itm.SubItems.Add(dm.GroupDetails.Name);
                itm.SubItems.Add(dm.PacketType.Name);
                itm.SubItems.Add(dm.Units.Name);
                itm.SubItems.Add(dm.ModelSetup.Name);
                itm.SubItems.Add(dm.BrandSetup.Name);
                itm.SubItems.Add(dm.ReorderQty.ToString());
                itm.SubItems.Add(dm.ReorderCycle.ToString());
                itm.SubItems.Add(dm.Priority.ToString());
                itm.SubItems.Add(dm.SerialPriority.ToString());
                itm.SubItems.Add(dm.Remarks);
                itm.SubItems.Add(dm.IsExpDate);
                itm.SubItems.Add(dm.IsSerial);
                itm.SubItems.Add(dm.IsBillable);
                itm.SubItems.Add(dm.IsWarranty);
                itm.SubItems.Add(dm.StoreType.TypeTitle);
                itm.SubItems.Add(dm.Majorgroup.Name);
                lvItemMaster.Items.Add(itm);
            }

        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvItemMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItemMaster.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvItemMaster.SelectedItems[0];
                txtItemID.Text = itm.SubItems[0].Text;
                txtItemName.Text = itm.SubItems[1].Text;
                txtItemNameBeng.Text = itm.SubItems[2].Text;
                cboCompany.Text = itm.SubItems[3].Text;
                cboGroup.Text = itm.SubItems[4].Text;
                cboPacket.Text = itm.SubItems[5].Text;
                cboUnit.Text = itm.SubItems[6].Text;
                cboModel.Text = itm.SubItems[7].Text;
                cboBrand.Text = itm.SubItems[8].Text;
                txtReorderQty.Text = itm.SubItems[9].Text;
                txtReorderCycle.Text = itm.SubItems[10].Text;
                txtPriority.Text = itm.SubItems[11].Text;
                txtSerialPriority.Text = itm.SubItems[12].Text;
                txtRemarks.Text = itm.SubItems[13].Text;
                chkExpireDate.Checked = itm.SubItems[14].Text == "1" ? true : false;
                chkSerialReq.Checked = itm.SubItems[15].Text == "1" ? true : false;
                chkBillable.Checked = itm.SubItems[16].Text == "1" ? true : false;
                chkWarrantyRequire.Checked = itm.SubItems[17].Text == "1" ? true : false;
                cboStoreType.Text = itm.SubItems[18].Text;
                cboMajorGroup.Text = itm.SubItems[19].Text;

              
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cboMajorGroup.DataSource == null)
            {
                MessageBox.Show("Please select Group");

                return;
            }
            try
            {
                ItemMaster mstr = this.populateItemMaster();
                short i = invSr.ModifyItemMaster(mstr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //RefreshGrid();
                    LoadListViewByGroup(cboGroup.SelectedValue.ToString());
                    txtItemName.Select();
                    //btnNew.PerformClick();
                    //txtDose.Text = "0 + 0 + 1";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCompanySetup ocompany = new frmCompanySetup();
            ocompany.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboCompany.DisplayMember = "Name";
            cboCompany.ValueMember = "ID";
            cboCompany.DataSource = new BindingSource(invSr.GetCompanyDetails(), null);

        }

        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            frmGroupSetup ogroup = new frmGroupSetup();
            ogroup.ShowDialog();
        }

        private void btnGroupRefresh_Click(object sender, EventArgs e)
        {
            cboGroup.DisplayMember = "Name";
            cboGroup.ValueMember = "ID";
            cboGroup.DataSource = new BindingSource(invSr.GetGroupDetails(), null);
        }

        private void btnUnitAdd_Click(object sender, EventArgs e)
        {
            frmUnitDetails ounit = new frmUnitDetails();
            ounit.ShowDialog();
        }

        private void btnUnitRefresh_Click(object sender, EventArgs e)
        {
            cboUnit.DisplayMember = "Name";
            cboUnit.ValueMember = "ID";
            cboUnit.DataSource = new BindingSource(invSr.GetUnitSetup(), null);
        }

        private void btnTypeAdd_Click(object sender, EventArgs e)
        {
            frmPacketType otype = new frmPacketType();
            otype.ShowDialog();
        }

        private void btnTypeRefresh_Click(object sender, EventArgs e)
        {
            cboPacket.DisplayMember = "Name";
            cboPacket.ValueMember = "ID";
            cboPacket.DataSource = new BindingSource(invSr.GetPacketType(), null);
        }

        private void btnModelAdd_Click(object sender, EventArgs e)
        {
            frmModelSetup omodel = new frmModelSetup();
            omodel.ShowDialog();
        }

        private void btnModelRefresh_Click(object sender, EventArgs e)
        {
            cboModel.DisplayMember = "Name";
            cboModel.ValueMember = "ID";
            cboModel.DataSource = new BindingSource(invSr.GetModelDetails(), null);
        }

        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            frmBrandSetup obrand = new frmBrandSetup();
            obrand.ShowDialog();
        }

        private void btnBrandRefresh_Click(object sender, EventArgs e)
        {
            cboBrand.DisplayMember = "Name";
            cboBrand.ValueMember = "ID";
            cboBrand.DataSource = new BindingSource(invSr.GetBrandDetails(), null);
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(cboMajorGroup.SelectedIndex == -1)
            {
                MessageBox.Show("--Please Select MajorGroup--");
                return;
            }
            if (cboGroup.SelectedIndex == -1)
            {
                MessageBox.Show("--Group Required--");
                cboGroup.Focus();
                return;
            }
            LoadListViewByGroup(cboGroup.SelectedValue.ToString());
        }

        private void cboStoreType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cboMajorGroup.ValueMember = "MajorgrpID";
            cboMajorGroup.DisplayMember = "Name";
            cboMajorGroup.DataSource = invSr.GetMajorGrpByStrtype(cboStoreType.SelectedValue.ToString());
        }

        private void cboMajorGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMajorGroup.SelectedValue != null)
            {
                cboGroup.DisplayMember = "Name";
                cboGroup.ValueMember = "ID";
                cboGroup.DataSource = invSr.GetGroupByMajorGrp(cboStoreType.SelectedValue.ToString(), cboMajorGroup.SelectedValue.ToString());
            }
        }

        private void cboStoreType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboMajorGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtItemNameBeng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtReorderQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboPacket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void chkExpireDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void chkSerialReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void chkBillable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void chkWarrantyRequire_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void btnMajorGroupAdd_Click(object sender, EventArgs e)
        {
            frmMajorGroup omajorgroup = new frmMajorGroup();
            omajorgroup.ShowDialog();
        }

        private void btnMajorGroupRefresh_Click(object sender, EventArgs e)
        {
            cboMajorGroup.ValueMember = "MajorgrpID";
            cboMajorGroup.DisplayMember = "Name";
            cboMajorGroup.DataSource = invSr.GetMajorGrpByStrtype(cboStoreType.SelectedValue.ToString()).ToList();
        }
        private void SearchListView(IEnumerable<ItemMaster> oResults, string searchString = "")
        {
            IEnumerable<ItemMaster> query;
            if (oResults != null)
            {
                if (!(searchString.Length > 0))
                {
                    query = oResults;
                }
                else
                {
                    query = (from oRes in oResults
                             where oRes.Name.ToUpper().Contains(searchString.ToUpper())
                             select oRes);
                }

                lvItemMaster.Items.Clear();
                foreach (ItemMaster dm in query)
                {
                    ListViewItem itm = new ListViewItem(dm.ID);
                    itm.SubItems.Add(dm.Name);
                    itm.SubItems.Add(dm.NameBeng);
                    itm.SubItems.Add(dm.Company.Name);
                    itm.SubItems.Add(dm.GroupDetails.Name);
                    itm.SubItems.Add(dm.PacketType.Name);
                    itm.SubItems.Add(dm.Units.Name);
                    itm.SubItems.Add(dm.ModelSetup.Name);
                    itm.SubItems.Add(dm.BrandSetup.Name);
                    itm.SubItems.Add(dm.ReorderQty.ToString());
                    itm.SubItems.Add(dm.ReorderCycle.ToString());
                    itm.SubItems.Add(dm.Priority.ToString());
                    itm.SubItems.Add(dm.SerialPriority.ToString());
                    itm.SubItems.Add(dm.Remarks);
                    itm.SubItems.Add(dm.IsExpDate);
                    itm.SubItems.Add(dm.IsSerial);
                    itm.SubItems.Add(dm.IsBillable);
                    itm.SubItems.Add(dm.IsWarranty);
                    itm.SubItems.Add(dm.StoreType.strTypeID);
                    itm.SubItems.Add(dm.Majorgroup.MajorgrpID);
                    lvItemMaster.Items.Add(itm);
                }
            }

        }

        private void txtItemName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(dmas, txtItemName.Text);
        }


      
    }
}
