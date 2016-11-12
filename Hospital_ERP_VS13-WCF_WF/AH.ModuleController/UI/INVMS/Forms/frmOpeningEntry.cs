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
using System.Globalization;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmOpeningEntry : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        private string SupplierID,StoreID;
        List<ItemMaster> list;
        GroupBox dummy;

        public frmOpeningEntry(string SupplierID,string StoreID)
        {
            InitializeComponent();
            this.SupplierID = SupplierID;
            this.StoreID = StoreID;

            dummy = new GroupBox();
            dummy.Visible = false;
            dummy.Enabled = false;
            this.Controls.Add(dummy);
        }

        private void frmOpeningEntry_Load(object sender, EventArgs e)
        {
            cboCostCategoey.DisplayMember = "CategoryName";
            cboCostCategoey.ValueMember = "CategoryID";
            cboCostCategoey.DataSource = invSr.GetCostcategory("CostcategoryTreeview", "", "").ToList();

            cboStoreType.ValueMember = "strTypeID";
            cboStoreType.DisplayMember = "TypeTitle";
            cboStoreType.DataSource = new BindingSource(invSr.GetStoreType(), null);
            
            //cboStoreType.ValueMember = "strTypeID";
            //cboStoreType.DisplayMember = "TypeTitle";
            //cboStoreType.DataSource = new BindingSource(invSr.LoadStoreType(), null);
            
            txtSupplierID.Text = this.SupplierID;
            txtStoreID.Text = this.StoreID;
            txtItemID.Select();

            cboMrrNo.Enabled = false;
           
            FormatGridProd(dgvItem);
            dgvItem.Visible = false;

            FormatGrid();
        }

        private void FormatGridProd(DataGridView dtv)
        {
            dtv.Height = 300;
            dtv.Width = 840;
            
            dtv.AutoGenerateColumns = false;
            dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y + txtItemID.Height);

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
            DataGridViewTextBoxColumn storetype = new DataGridViewTextBoxColumn();
            storetype.Name = "StoreTypeID";
            storetype.DataPropertyName = "StoreTypeID";
            storetype.Width = 0;
            storetype.Visible = false;
            dtv.Columns.Add(storetype);
            DataGridViewTextBoxColumn majorgroup = new DataGridViewTextBoxColumn();
            majorgroup.Name = "MajorGroup";
            majorgroup.DataPropertyName = "MajorGroup";
            majorgroup.Width = 0;
            majorgroup.Visible = false;
            dtv.Columns.Add(majorgroup);

            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 100;
            colUrate.ReadOnly = true;
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colslrate = new DataGridViewTextBoxColumn();
            colslrate.Name = "SlRate";
            colslrate.DataPropertyName = "SlRate";
            colslrate.Width = 100;
            colslrate.ReadOnly = true;
            dtv.Columns.Add(colslrate);

            DataGridViewTextBoxColumn colVat = new DataGridViewTextBoxColumn();
            colVat.Name = "VAT";
            colVat.DataPropertyName = "VAT";
            colVat.Width = 80;
            colVat.ReadOnly = true;
            dtv.Columns.Add(colVat);

            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Discount";
            colDiscount.DataPropertyName = "Discount";
            colDiscount.Width = 80;
            colDiscount.ReadOnly = true;
            dtv.Columns.Add(colDiscount);

        }
        private void populateDataToGrid(DataGridView dtv, string itemname,string storeid)
        {
            dgvItem.Visible = true;
            list = new List<ItemMaster>();
            list.AddRange(invSr.GetItemsForOpening(itemname, storeid).ToList());
            if (list.Count > 0)
            {
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
                    StoreTypeID = data.StoreType.strTypeID,
                    MajorGroup = data.Majorgroup.MajorgrpID,
                    Rate = data.Urate,
                    SlRate = data.Slrate,
                    VAT = data.VAT,
                    Discount = data.Discount

                }).ToList();
                this.dgvItem.Focus();
            }


            else
            {
                dgvItem.Visible = false;
                MessageBox.Show("There is no item in this store");
                return;
            }

        }

        private void txtItemID_KeyDown(object sender, KeyEventArgs e)
        {
            int number2;

            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtItemID.Text, out number2))
                {

                    txtMrrQuantity.Select();
                }
                else
                {

                    populateDataToGrid(dgvItem, txtItemID.Text,cboStoreType.SelectedValue.ToString());
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
                populateDataToGrid(dgvItem, txtItemID.Text, cboStoreType.SelectedValue.ToString());
                dgvItem.Focus();

            }
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

                lvOpeningEntry.Items.Clear();
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
                    lvOpeningEntry.Items.Add(itm);
                }
            }

        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
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
                txtStoreType.Text = dtv["StoreTypeID", currentRow + 1].Value.ToString();
                txtMajorGroup.Text = dtv["MajorGroup", currentRow + 1].Value.ToString();
                //labelRate.Text = dtv["Rate", currentRow + 1].Value.ToString();
                txtPORate.Text = dtv["Rate", currentRow + 1].Value.ToString();
                txtSlRate.Text = dtv["SlRate", currentRow + 1].Value.ToString();
                //LabelVat.Text = dtv["Vat", currentRow + 1].Value.ToString();
                txtvat.Text = dtv["Vat", currentRow + 1].Value.ToString();
                //LabelDiscount.Text = dtv["Discount", currentRow + 1].Value.ToString();
                txtDiscount.Text = dtv["Discount", currentRow + 1].Value.ToString();
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
            txtMrrQuantity.Text = string.Empty;
            txtExpireDate.Text = string.Empty;
            txtPORate.Text = string.Empty;
            txtSlRate.Text = string.Empty;
            txtvat.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            labelRate.Text = "0";
            LabelVat.Text = "0";
            LabelDiscount.Text = "0";
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
                txtStoreType.Text = row.Cells["StoreTypeID"].Value.ToString();
                txtMajorGroup.Text = row.Cells["MajorGroup"].Value.ToString();
                txtPORate.Text = row.Cells["Rate"].Value.ToString();
                txtSlRate.Text = row.Cells["SlRate"].Value.ToString();
                //labelRate.Text = row.Cells["Rate"].Value.ToString();
                //LabelVat.Text = row.Cells["Vat"].Value.ToString();
                txtvat.Text = row.Cells["Vat"].Value.ToString();
                //LabelDiscount.Text = row.Cells["Discount"].Value.ToString();
                txtDiscount.Text = row.Cells["Discount"].Value.ToString();

                dgvItem.Visible = false;

                txtItemID.Focus();

            }
        }
        private void AmountSummary()
        {
            txtTotal.Text = (Utility.ParseFloat(txtMrrQuantity.Text) * Utility.ParseFloat(txtPORate.Text) + Utility.ParseFloat(txtvat.Text) - Utility.ParseFloat(txtDiscount.Text)).ToString();

        }

        private void txtMrrQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtMrrQuantity.Text.StartsWith("."))
            {
                txtMrrQuantity.Text = new string(txtMrrQuantity.Text.SkipWhile(c => c == '.').ToArray());
            }
            AmountSummary();
        }

        private void txtMrrQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            AmountSummary();
        }
        private void RefreshGrid()
        {

            txtItemID.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtPORate.Text = string.Empty;
            txtSlRate.Text = string.Empty;
            txtvat.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtMrrQuantity.Text = string.Empty;
            labelRate.Text = "0";
            LabelVat.Text = "0";
            LabelDiscount.Text = "0";
        }
        private void FormatGrid()
        {
            lvOpeningEntry.CheckBoxes = false;

            lvOpeningEntry.Columns.Add("Item ID", 100, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Item Name", 220, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("PackageType", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Unit", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("GroupID", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Group Name", 200, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("CompanyID", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("CompanyName", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("BrandID", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("BrandName", 220, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("ModelID", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("ModelName", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("StoreType", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("MajorGroup", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("PORate", 70, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("SlRate", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("VAT", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Disc", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("PR Quantity", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("PO Quantity", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Quantity", 70, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("ExpDate", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Total", 70, HorizontalAlignment.Left);

        }

        private void LoadListView()
        {

            ListViewItem itm = new ListViewItem(txtItemID.Text);
            itm.SubItems.Add(txtItemName.Text);
            itm.SubItems.Add(txtTypeID.Text);
            itm.SubItems.Add(txtUnitID.Text);
            itm.SubItems.Add(txtGroupID.Text);
            itm.SubItems.Add(txtGroupName.Text);
            itm.SubItems.Add(txtCompanyID.Text);
            itm.SubItems.Add(txtCompanyName.Text);
            itm.SubItems.Add(txtBrandID.Text);
            itm.SubItems.Add(txtBrandName.Text);
            itm.SubItems.Add(txtModelID.Text);
            itm.SubItems.Add(txtModelName.Text);
            itm.SubItems.Add(txtStoreType.Text);
            itm.SubItems.Add(txtMajorGroup.Text);
            itm.SubItems.Add(txtPORate.Text);
            itm.SubItems.Add(txtPORate.Text);
            itm.SubItems.Add(txtvat.Text);
            itm.SubItems.Add(txtDiscount.Text);
            itm.SubItems.Add("0");
            itm.SubItems.Add("0");
            itm.SubItems.Add(txtMrrQuantity.Text);
            itm.SubItems.Add(txtExpireDate.Text);
            itm.SubItems.Add(txtTotal.Text);            
            lvOpeningEntry.Items.Add(itm);

        }
        private void LoadListDetails(string mrrno)
        {
            lvOpeningEntry.Items.Clear();

            List<MaterialReceive> omatrec;

            if (mrrno.Length != 0)
            {
                omatrec = invSr.GetOpeningEntry(cboMrrNo.Text).ToList();
            }
            else
            {
                return;
            }

            int i = 0;

            foreach (MaterialReceive mat in omatrec)
            {
                ListViewItem itm = new ListViewItem(mat.ItemOrder.ItemMaster.ID);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.Name);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.PacketType.ID);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.Units.ID);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.GroupDetails.ID);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.GroupDetails.Name);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.Company.ID);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.Company.Name);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.BrandSetup.ID);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.BrandSetup.Name);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.ModelSetup.ID);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.ModelSetup.Name);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.StoreType.strTypeID);
                itm.SubItems.Add(mat.ItemOrder.ItemMaster.Majorgroup.MajorgrpID);
                itm.SubItems.Add(mat.ItemOrder.Rate.ToString());
                itm.SubItems.Add(mat.ItemOrder.SlRate.ToString());
                itm.SubItems.Add(mat.ItemOrder.VAT.ToString());
                itm.SubItems.Add(mat.ItemOrder.Discount.ToString());
                itm.SubItems.Add(mat.PurchaseRequisition.RequisitionQty.ToString());
                itm.SubItems.Add(mat.ItemOrder.POQty.ToString());
                itm.SubItems.Add(mat.MrrQuantity.ToString());
                itm.SubItems.Add(mat.ExpDate.ToString());
                lvOpeningEntry.Items.Add(itm);
            }

        }
        private void btnShowExist_Click(object sender, EventArgs e)
        {
            cboMrrNo.Enabled = true;
            cboMrrNo.DisplayMember = "ID";
            cboMrrNo.DataSource = invSr.GetMRRNumber();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {           
            btnSave.Enabled = true;
            cboMrrNo.Enabled = false;
            RefreshGrid();
            lvOpeningEntry.Items.Clear();
            txtItemID.Select();
        }

        private void cboMrrNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListDetails(cboMrrNo.SelectedValue.ToString());
        }

        private void lvOpeningEntry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOpeningEntry.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvOpeningEntry.SelectedItems[0];
                txtItemID.Text = itm.SubItems[0].Text;
                txtItemName.Text = itm.SubItems[1].Text;
                //txtGroupName.Text = itm.SubItems[5].Text;
                //txtCompanyName.Text = itm.SubItems[7].Text;
                txtPORate.Text = itm.SubItems[14].Text;
                txtSlRate.Text = itm.SubItems[15].Text;
                labelRate.Text = itm.SubItems[15].Text;
                txtvat.Text = itm.SubItems[16].Text;
                LabelVat.Text = itm.SubItems[16].Text;
                txtDiscount.Text = itm.SubItems[17].Text;
                LabelDiscount.Text = itm.SubItems[17].Text;
                txtMrrQuantity.Text = itm.SubItems[20].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                           
            //DateTime comparedate = DateTime.Now.Date;
            //DateTime expiredate = DateTime.Parse(txtExpireDate.Text, new CultureInfo("en-US").DateTimeFormat);
            //DateTime expiredate = Convert.ToDateTime(txtExpireDate.Text.Trim()).Date;
            string vrfy = invSr.VerifyOpeningItemID(txtItemID.Text, txtStoreID.Text);
            if (vrfy != "0")
            {
                MessageBox.Show("This Item is already opened");
                RefreshGrid();
                return;
            }
            if(string.IsNullOrEmpty(txtMrrQuantity.Text))
            {
                MessageBox.Show("Please fill GRNQty");
                txtMrrQuantity.Select();
                return;
            }
            if (Utility.ParseFloat(txtPORate.Text).ToString() == "0")
            {
                MessageBox.Show("Please put Item Rate");
                txtSlRate.Select();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvOpeningEntry, 0, txtItemID.Text))
            {
                MessageBox.Show("Already Exist");
                txtItemID.Select();
                return;
            }
            if (txtExpireDate.Text == "  /  /")
            {
                MessageBox.Show("Expire Date cannot be empty");
                return;
            }
            if (txtExpireDate.Text != "  /  /")
            {
                if (Convert.ToDateTime(txtExpireDate.Text) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    MessageBox.Show("Expire Date cannot be earlier than Current Date");
                    return;
                }
            }
                             
            txtItemID.Select();           
            LoadListView();
               
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvitem in lvOpeningEntry.SelectedItems)
            {
                lvOpeningEntry.Items.Remove(lvitem);
            }
            RefreshGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {  };
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            //if (cboStoreType.SelectedIndex == -1)
            //{
            //    MessageBox.Show("--Please Select StoreType--");
            //    return;
            //}
            if (lvOpeningEntry.Items.Count == 0)
            {
                MessageBox.Show("Please add an item");
                return;
            }
           
            try
            {
                MaterialReceive mo = this.populateMatReceive();
                string i = invSr.SaveMrrDetails(mo);
                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;                   
                    cboMrrNo.Enabled = false;
                    lvOpeningEntry.Items.Clear();
                    DG.Rows.Clear();
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
        private MaterialReceive populateMatReceive()
        {
            MaterialReceive mr = new MaterialReceive();
            mr.ID = cboMrrNo.Text;
            mr.MrrQuantity = Single.Parse(txtMrrQuantity.Text);
            mr.MrrFlag = 1;
            mr.TransactionType = "OP";
            mr.MrrDate = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
            mr.MrrType = "OP";

            mr.ChallanNo = "2345";
            mr.ChallanDate = DateTime.Parse(DateTime.Now.ToString());
            mr.VoucherNo = "1234";
            mr.Remarks = txtRemarks.Text;

            PurchaseRequisition oreq = new PurchaseRequisition();
            oreq.ID = "PR0125555";
            mr.PurchaseRequisition = oreq;

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            mr.CostCategoryTreeview = ocostcenter;

            ItemOrder order = new ItemOrder();
            order.RackRate = Single.Parse(txtSlRate.Text);
            order.VAT = Single.Parse(txtvat.Text);
            order.Discount = Single.Parse(txtDiscount.Text);
            mr.ItemOrder = order;

            PurchaseOrder po = new PurchaseOrder();
            po.ID = "OP0114-00008";
            mr.PurchaseOrder = po;

            StoreLocation str = new StoreLocation();
            str.ID = cboStoreLocation.SelectedValue.ToString();
            mr.StoreLocation  = str;

            Supplier supp = new Supplier();
            supp.ID = "000000";
            mr.Supplier = supp;

            string MrrString = "";
            foreach (ListViewItem itemRow in lvOpeningEntry.Items)
            {

                MrrString += itemRow.SubItems[0].Text + "," + itemRow.SubItems[2].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[8].Text + "," + itemRow.SubItems[10].Text + "," + itemRow.SubItems[12].Text + "," + itemRow.SubItems[13].Text + "," + itemRow.SubItems[14].Text + "," + itemRow.SubItems[15].Text + "," + itemRow.SubItems[16].Text + "," + itemRow.SubItems[17].Text + "," + itemRow.SubItems[18].Text + "," + itemRow.SubItems[19].Text + "," + itemRow.SubItems[20].Text + "," + itemRow.SubItems[21].Text;
                MrrString += ";";
            }
            mr.MrrDetails = MrrString;

            //mr.AssetTracker = "0121122";
            string assetstring = "";
            //int k=0;
            //k =  DG.Rows.Count - 1;

            foreach (DataGridViewRow drs in DG.Rows)
            {
                if (drs.Cells[12].Value != null)
                {
                    assetstring += drs.Cells[13].Value.ToString() + "," + drs.Cells[2].Value.ToString() + "," + drs.Cells[3].Value.ToString() + "," + drs.Cells[4].Value.ToString() + "," + drs.Cells[5].Value.ToString() + "," + drs.Cells[6].Value.ToString() + "," + drs.Cells[7].Value.ToString() + "," + drs.Cells[8].Value.ToString() + "," + drs.Cells[9].Value.ToString() + "," + drs.Cells[0].Value.ToString() + "," + drs.Cells[11].Value.ToString() + "," + drs.Cells[12].Value.ToString() + "," + drs.Cells[10].Value.ToString();
                    assetstring += ";";
                }
            }


            mr.AssetTracker = assetstring;
          

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            mr.EntryParameter = ep;

            return mr;
        }

        private void pnlMain_MouseClick(object sender, MouseEventArgs e)
        {
            dgvItem.Visible = false;
        }

        private void txtURate_TextChanged(object sender, EventArgs e)
        {
            AmountSummary();
        }

        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            if (txtvat.Text.StartsWith("."))
            {
                txtvat.Text = new string(txtvat.Text.SkipWhile(c => c == '.').ToArray());
            }
            AmountSummary();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text.StartsWith("."))
            {
                txtDiscount.Text = new string(txtDiscount.Text.SkipWhile(c => c == '.').ToArray());
            }
            AmountSummary();
        }

        private void txtMrrQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtURate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtvat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboCostCategoey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCostCategoey.SelectedValue != null)
            {

                cboCostCenter.DisplayMember = "CostcenterName";
                cboCostCenter.ValueMember = "CostCenterID";
                cboCostCenter.DataSource = invSr.GetAccountCostcenter("CostcenterTreeview", cboCostCategoey.SelectedValue.ToString(), "").ToList();

            }
        }
        private void InserAdd(string strItenName, long lngTotoalRow)
        {
            // DG.Rows.Add(lngTotoalRow);
            long inttotalRow = Convert.ToInt32(DG.Rows.Count + lngTotoalRow) + 1;
            DG.Rows.Add(inttotalRow);


        }

        private void InserAdd(string itemid, string item, string compid, string majorgrp, string storeid, string groupid, string unitid, string typeid, string modelid, string brandid, string expiredate, int lngqty)
        {
            int intRowcount = DG.Rows.Count - 1;
            DG.AllowUserToAddRows = true;
            DG.Rows.Add(lngqty);
            for (int i = intRowcount; i < (intRowcount + lngqty); i++)
            {
                DG[0, i].Value = itemid;
                DG[1, i].Value = item;
                DG[2, i].Value = compid;
                DG[3, i].Value = majorgrp;
                DG[4, i].Value = storeid;
                DG[5, i].Value = groupid;
                DG[6, i].Value = unitid;
                DG[7, i].Value = typeid;
                DG[8, i].Value = modelid;
                DG[9, i].Value = brandid;
                DG[10, i].Value = expiredate;
                //DG[10, i].Value = lngqty;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DG.Rows.Clear();
            int iRow = 0;
            int intTotalRow = 0;
            string itemid = "";
            string itemname = "";
            string compid = "";
            string majorgrp = "";
            string storeid = "";
            string groupid = "";
            string unitid = "";
            string typeid = "";
            string modelid = "";
            string brandid = "";
            string expiredate = "";

            for(iRow = 0; iRow < lvOpeningEntry.Items.Count; iRow++)
            {
                intTotalRow = Convert.ToInt32(lvOpeningEntry.Items[iRow].SubItems[19].Text);
                itemid = lvOpeningEntry.Items[iRow].SubItems[0].Text;
                itemname = lvOpeningEntry.Items[iRow].SubItems[1].Text;
                compid = lvOpeningEntry.Items[iRow].SubItems[6].Text;
                majorgrp = lvOpeningEntry.Items[iRow].SubItems[13].Text;
                storeid = lvOpeningEntry.Items[iRow].SubItems[12].Text;
                groupid = lvOpeningEntry.Items[iRow].SubItems[4].Text;
                unitid = lvOpeningEntry.Items[iRow].SubItems[3].Text;
                typeid = lvOpeningEntry.Items[iRow].SubItems[2].Text;
                modelid = lvOpeningEntry.Items[iRow].SubItems[10].Text;
                brandid = lvOpeningEntry.Items[iRow].SubItems[8].Text;
                expiredate = lvOpeningEntry.Items[iRow].SubItems[20].Text;
                InserAdd(itemid, itemname, compid, majorgrp, storeid, groupid, unitid, typeid, modelid, brandid, expiredate, intTotalRow);
            }
            Column12.DisplayMember = "Value";
            Column12.ValueMember = "Key";
            Column12.DataSource = new BindingSource(invSr.GetServiceProviderInfo("", ""), null);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            btnSave.Enabled = true;
            lvOpeningEntry.Items.Clear();
            DG.Rows.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void txtItemID_KeyUp(object sender, KeyEventArgs e)
        {
        //    dgvItem.Visible = true;
        //    long result;
        //    int intCheck;
        //    if (long.TryParse(txtItemID.Text, out result))
        //    {
        //        intCheck = 0;
        //    }
        //    else
        //    {
        //        intCheck = 1;
        //    }

        //    SearchListView(list, intCheck, txtItemID.Text);
        }

        private void txtPORate_TextChanged(object sender, EventArgs e)
        {
            if (txtPORate.Text.StartsWith("."))
            {
                txtPORate.Text = new string(txtPORate.Text.SkipWhile(c => c == '.').ToArray());
            }
            AmountSummary();
        }

        private void txtPORate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtExpireDate_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtExpireDate_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }


        public IFormatProvider _DateTimeFormatInfo { get; set; }

        private void cboStoreLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboStoreType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStoreType.SelectedValue != null)
            {
                cboStoreLocation.ValueMember = "ID";
                cboStoreLocation.DisplayMember = "Name";
                cboStoreLocation.DataSource = new BindingSource(invSr.GetStoreLocByType(cboStoreType.SelectedValue.ToString()), null);
            }
        }

        private void txtExpireDate_KeyDown_2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtvat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) e.Handled = true; 
        }

        private void txtvat_Validating(object sender, CancelEventArgs e)
        {
            //var box = (TextBox)sender;
            //decimal value;
            //if (decimal.TryParse(box.Text, out value)) errorProvider1.SetError(box, "");
            //else
            //{
            //    e.Cancel = true;
            //    box.SelectAll();
            //    errorProvider1.SetError(box, "Invalid number");
            //}
        }
    }
}
