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
    public partial class frmItemRates : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();

        public frmItemRates()
        {
            InitializeComponent();
        }

        private void frmItemRates_Load(object sender, EventArgs e)
        {
            txtItemID.Select();

            cboStoreLocation.ValueMember = "ID";
            cboStoreLocation.DisplayMember = "Name";
            cboStoreLocation.DataSource = new BindingSource(invSr.GetStoreLocation(),null);

            FormatData(dgvItem);
            dgvItem.Visible = false;

            formatListView();
            LoadListView();
        }
        private void FormatData(DataGridView dtv)
        {
            dtv.Height = 300;
            dtv.Width = 840;
            
            dtv.AutoGenerateColumns = false;
            dtv.Location = new Point(lvItemRates.Location.X, lvItemRates.Location.Y);

            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 0;
            itemid.Visible = false;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "ItemName";
            itemname.DataPropertyName = "ItemName";
            itemname.Width = 200;
            itemname.Visible = true;
            dtv.Columns.Add(itemname);
            DataGridViewTextBoxColumn compid = new DataGridViewTextBoxColumn();
            compid.Name = "CompanyID";
            compid.DataPropertyName = "CompanyID";
            compid.Width = 0;
            compid.Visible = false;
            dtv.Columns.Add(compid);
            DataGridViewTextBoxColumn compname = new DataGridViewTextBoxColumn();
            compname.Name = "CompanyName";
            compname.DataPropertyName = "CompanyName";
            compname.Width = 150;
            compname.Visible = true;
            dtv.Columns.Add(compname);
            DataGridViewTextBoxColumn groupid = new DataGridViewTextBoxColumn();
            groupid.Name = "GroupID";
            groupid.DataPropertyName = "GroupID";
            groupid.Width = 0;
            groupid.Visible = false;
            dtv.Columns.Add(groupid);
            DataGridViewTextBoxColumn groupname = new DataGridViewTextBoxColumn();
            groupname.Name = "GroupName";
            groupname.DataPropertyName = "GroupName";
            groupname.Width = 150;
            groupname.Visible = true;
            dtv.Columns.Add(groupname);
            DataGridViewTextBoxColumn typeid = new DataGridViewTextBoxColumn();
            typeid.Name = "TypeID";
            typeid.DataPropertyName = "TypeID";
            typeid.Width = 0;
            typeid.Visible = false;
            dtv.Columns.Add(typeid);
            DataGridViewTextBoxColumn typename = new DataGridViewTextBoxColumn();
            typename.Name = "TypeName";
            typename.DataPropertyName = "TypeName";
            typename.Width = 100;
            typename.Visible = true;
            dtv.Columns.Add(typename);
            DataGridViewTextBoxColumn unitid = new DataGridViewTextBoxColumn();
            unitid.Name = "UnitID";
            unitid.DataPropertyName = "UnitID";
            unitid.Width = 0;
            unitid.Visible = false;
            dtv.Columns.Add(unitid);
            DataGridViewTextBoxColumn unitname = new DataGridViewTextBoxColumn();
            unitname.Name = "UnitName";
            unitname.DataPropertyName = "UnitName";
            unitname.Width = 100;
            unitname.Visible = true;
            dtv.Columns.Add(unitname);
            DataGridViewTextBoxColumn modelid = new DataGridViewTextBoxColumn();
            modelid.Name = "ModelID";
            modelid.DataPropertyName = "ModelID";
            modelid.Width = 0;
            modelid.Visible = false;
            dtv.Columns.Add(modelid);
            DataGridViewTextBoxColumn modelname = new DataGridViewTextBoxColumn();
            modelname.Name = "ModelName";
            modelname.DataPropertyName = "ModelName";
            modelname.Width = 100;
            modelname.Visible = true;
            dtv.Columns.Add(modelname);
            DataGridViewTextBoxColumn brandid = new DataGridViewTextBoxColumn();
            brandid.Name = "BrandID";
            brandid.DataPropertyName = "BrandID";
            brandid.Width = 0;
            brandid.Visible = false;
            dtv.Columns.Add(brandid);
            DataGridViewTextBoxColumn brandname = new DataGridViewTextBoxColumn();
            brandname.Name = "BrandName";
            brandname.DataPropertyName = "BrandName";
            brandname.Width = 100;
            brandname.Visible = true;
            dtv.Columns.Add(brandname);


        }
        private void populateDataToGridItem(DataGridView dtv, string itemname,string storeid)
        {

            dgvItem.Visible = true;
            List<ItemMaster> list = new List<ItemMaster>();
            list.AddRange(invSr.GetItemsByName(itemname,storeid).ToList());

            dgvItem.DataSource = list.Select(data => new
            {
                ItemID = data.ID,
                ItemName = data.Name,
                CompanyID = data.Company.ID,
                CompanyName = data.Company.Name,
                GroupID = data.GroupDetails.ID,
                GroupName = data.GroupDetails.Name,
                TypeID = data.PacketType.ID,
                TypeName = data.PacketType.Name,
                UnitID = data.Units.ID,
                UnitName = data.Units.Name,
                ModelID = data.ModelSetup.ID,
                ModelName = data.ModelSetup.Name,
                BrandID = data.BrandSetup.ID,
                BrandName = data.BrandSetup.Name,

            }).ToList();
            this.dgvItem.Focus();
        }

        private void txtItemID_KeyDown(object sender, KeyEventArgs e)
        {
            int number2;

            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtItemID.Text, out number2))
                {
                    txtItemID.Text = string.Empty;
                    //txtQuantity.Select();
                }
                else
                {

                    populateDataToGridItem(dgvItem, txtItemID.Text,cboStoreLocation.SelectedValue.ToString());
                    dgvItem.Focus();
                }

            }

            if (e.KeyCode == Keys.Down)
            {

                if (txtItemID.Text.Length == 0)
                {
                    MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                    return;
                }
                populateDataToGridItem(dgvItem, txtItemID.Text, cboStoreLocation.SelectedValue.ToString());
                dgvItem.Focus();

            }
        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {
            if (dtv.Rows.Count > 0)
            {
                int currentRow = dtv.CurrentRow.Index;
                currentRow--;
                txtItemID.Text = dtv["ItemID", currentRow + 1].Value.ToString();
                txtItemName.Text = dtv["ItemName", currentRow + 1].Value.ToString();
                txtCompanyID.Text = dtv["CompanyID", currentRow + 1].Value.ToString();
                txtGroupID.Text = dtv["GroupID", currentRow + 1].Value.ToString();
                txtUnitID.Text = dtv["UnitID", currentRow + 1].Value.ToString();
                txtTypeID.Text = dtv["TypeID", currentRow + 1].Value.ToString();
                txtModelID.Text = dtv["ModelID", currentRow + 1].Value.ToString();
                txtBrandID.Text = dtv["BrandID", currentRow + 1].Value.ToString();
                txtGroupName.Text = dtv["GroupName", currentRow + 1].Value.ToString();
                txtCompanyName.Text = dtv["CompanyName", currentRow + 1].Value.ToString();
                txtBrandName.Text = dtv["BrandName", currentRow + 1].Value.ToString();
                txtModelName.Text = dtv["ModelName", currentRow + 1].Value.ToString();
                dtv.Visible = false;
                txtItemID.Focus();
            }
            else
            {
                dtv.Visible = false;
                txtItemID.Focus();
            }
        }

        private void dgvItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            setvaluesFromList(dgvItem,sender);
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            txtItemName.Text = string.Empty;
            txtCompanyID.Text = string.Empty;
            txtGroupID.Text = string.Empty;
            txtUnitID.Text = string.Empty;
            txtTypeID.Text = string.Empty;
            txtModelID.Text = string.Empty;
            txtBrandID.Text = string.Empty;
            txtGroupName.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtURate.Text = string.Empty;
            txtvat.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtRackRate.Text = string.Empty;
            txtSlRate.Text = string.Empty;
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvItem.Rows[e.RowIndex];

                txtItemID.Text = row.Cells["ItemID"].Value.ToString();
                txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                txtCompanyID.Text = row.Cells["CompanyID"].Value.ToString();
                txtGroupID.Text = row.Cells["GroupID"].Value.ToString();
                txtUnitID.Text = row.Cells["UnitID"].Value.ToString();
                txtTypeID.Text = row.Cells["TypeID"].Value.ToString();
                txtModelID.Text = row.Cells["ModelID"].Value.ToString();
                txtBrandID.Text = row.Cells["BrandID"].Value.ToString();
                txtGroupName.Text = row.Cells["GroupName"].Value.ToString();
                txtCompanyName.Text = row.Cells["CompanyName"].Value.ToString();
                txtBrandName.Text = row.Cells["BrandName"].Value.ToString();
                txtModelName.Text = row.Cells["ModelName"].Value.ToString();

                dgvItem.Visible = false;

                txtItemID.Focus();

            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            dgvItem.Visible = false;
        }
        private void RefreshGrid()
        {
            LoadListView();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtItemID", "txtItemName", "txtGroupName", "txtCompanyName", "txtURate", "txtvat", "txtDiscount", "txtRackRate", "txtSlRate" };
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (Utility.IsDuplicateFoundInList(lvItemRates, 1, txtItemName.Text))
            {
                MessageBox.Show("This Item is Already exist");
                txtItemID.Select();
                return;

            }
            
            try
            {
                ItemRates rt = this.populateItemRate();
                short i = invSr.SaveItemRates(rt);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnNew.PerformClick();
                    txtItemID.Select();
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
        private ItemRates populateItemRate()
        {
            ItemRates itm = new ItemRates();
            itm.Urate = Single.Parse(txtURate.Text);
            itm.VAT = Single.Parse(txtvat.Text);
            itm.Discount = Single.Parse(txtDiscount.Text);
            itm.Rackrate = Single.Parse(txtRackRate.Text);
            itm.Slrate = Single.Parse(txtSlRate.Text);

            StoreLocation ostore = new StoreLocation();
            ostore.ID = cboStoreLocation.SelectedValue.ToString();
            itm.StoreLocation = ostore;

            ItemMaster mas = new ItemMaster();
            mas.ID = txtItemID.Text;


            CompanySetup dc = new CompanySetup();
            dc.ID = txtCompanyID.Text;
            mas.Company = dc;

            GroupDetails dg = new GroupDetails();
            dg.ID = txtGroupID.Text;
            mas.GroupDetails = dg;

            Units un = new Units();
            un.ID = txtUnitID.Text;
            mas.Units = un;

            PacketType pac = new PacketType();
            pac.ID = txtTypeID.Text;
            mas.PacketType = pac;

            BrandSetup obrand = new BrandSetup();
            obrand.ID = txtBrandID.Text;
            mas.BrandSetup = obrand;

            ModelSetup omodel = new ModelSetup();
            omodel.ID = txtModelID.Text;
            mas.ModelSetup = omodel;

            itm.ItemMaster = mas;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            itm.EntryParameter = ep;


            return itm;
        }
        private void formatListView()
        {
            lvItemRates.CheckBoxes = false;
            lvItemRates.Columns.Add("ID", 130, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("Name", 240, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("Group", 205, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("Company", 170, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("CompanyID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("GroupID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("UnitID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("TypeID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("BrandID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("ModelID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("Rate", 50, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("VAT", 50, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("Disc.", 50, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("RRate", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("SlRate", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvItemRates.Items.Clear();

            List<ItemRates> rate = invSr.GetItemRates().ToList();
            int i = 0;

            foreach (ItemRates rt in rate)
            {
                ListViewItem itm = new ListViewItem(rt.ItemMaster.ID);
                itm.SubItems.Add(rt.ItemMaster.Name);
                itm.SubItems.Add(rt.ItemMaster.GroupDetails.Name);
                itm.SubItems.Add(rt.ItemMaster.Company.Name);
                itm.SubItems.Add(rt.ItemMaster.Company.ID);
                itm.SubItems.Add(rt.ItemMaster.GroupDetails.ID);
                itm.SubItems.Add(rt.ItemMaster.Units.ID);
                itm.SubItems.Add(rt.ItemMaster.PacketType.ID);
                itm.SubItems.Add(rt.ItemMaster.BrandSetup.ID);
                itm.SubItems.Add(rt.ItemMaster.ModelSetup.ID);
                itm.SubItems.Add(rt.Urate.ToString());
                itm.SubItems.Add(rt.VAT.ToString());
                itm.SubItems.Add(rt.Discount.ToString());
                itm.SubItems.Add(rt.Rackrate.ToString());
                itm.SubItems.Add(rt.Slrate.ToString());
                lvItemRates.Items.Add(itm);
            }

        }

        private void lvItemRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItemRates.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvItemRates.SelectedItems[0];
                txtItemID.Text = itm.SubItems[0].Text;
                txtItemName.Text = itm.SubItems[1].Text;
                txtGroupName.Text = itm.SubItems[2].Text;
                txtCompanyName.Text = itm.SubItems[3].Text;
                txtCompanyID.Text = itm.SubItems[4].Text;
                txtGroupID.Text = itm.SubItems[5].Text;
                txtUnitID.Text = itm.SubItems[6].Text;
                txtTypeID.Text = itm.SubItems[7].Text;
                txtBrandID.Text = itm.SubItems[8].Text;
                txtModelID.Text = itm.SubItems[9].Text;
                txtURate.Text = itm.SubItems[10].Text.ToString();
                txtvat.Text = itm.SubItems[11].Text.ToString();
                txtDiscount.Text = itm.SubItems[12].Text.ToString();
                txtRackRate.Text = itm.SubItems[13].Text.ToString();
                txtSlRate.Text = itm.SubItems[14].Text.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
