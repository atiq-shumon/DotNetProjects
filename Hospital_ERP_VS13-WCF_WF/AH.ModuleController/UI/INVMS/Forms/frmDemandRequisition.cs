using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.UI.InvMS.Reports.Viewer;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmDemandRequisition : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        

        public frmDemandRequisition()
        {
            InitializeComponent();
            
        }
        private void FormatGrid()
        {

            lvItemList.Columns.Add("Item ID", 90, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Name", 200, HorizontalAlignment.Left);
            lvItemList.Columns.Add("PackageType", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Unit", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Group", 0, HorizontalAlignment.Left);
            //lvItemList.Columns.Add("Group", 200, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Company", 0, HorizontalAlignment.Left);
            //lvItemList.Columns.Add("Company", 200, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Brand", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Model", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("StoreType", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("MajorGroup", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("DRQty", 70, HorizontalAlignment.Left);
            lvItemList.Columns.Add("RemQuantity", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Group", 220, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Company", 150, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Brand", 120, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Model", 100, HorizontalAlignment.Left);
            
        }
        private void FormatDataForDR(DataGridView dtv)
        {

            dtv.AutoGenerateColumns = false;
            //dtv.Location = new Point(dgvDRDetails.Location.X, dgvDRDetails.Location.Y);
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            DataGridViewTextBoxColumn colSlno = new DataGridViewTextBoxColumn();
            colSlno.Name = "SNo";
            colSlno.DataPropertyName = "SNo";
            colSlno.Width = 50;
            colSlno.Visible = true;
            colSlno.ReadOnly = false;
            dtv.Columns.Add(colSlno);

            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 0;
            itemid.Visible = false;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Item";
            itemname.DataPropertyName = "Item";
            itemname.Width = 400;
            itemname.Visible = true;
            itemname.ReadOnly = true;
            dtv.Columns.Add(itemname);
          
            DataGridViewTextBoxColumn typeid = new DataGridViewTextBoxColumn();
            typeid.Name = "TypeID";
            typeid.DataPropertyName = "TypeID";
            typeid.Width = 0;
            typeid.Visible = false;
            dtv.Columns.Add(typeid);
            DataGridViewTextBoxColumn unitid = new DataGridViewTextBoxColumn();
            unitid.Name = "UnitID";
            unitid.DataPropertyName = "UnitID";
            unitid.Width = 0;
            unitid.Visible = false;
            dtv.Columns.Add(unitid);
            DataGridViewTextBoxColumn groupid = new DataGridViewTextBoxColumn();
            groupid.Name = "GroupID";
            groupid.DataPropertyName = "GroupID";
            groupid.Width = 0;
            groupid.Visible = false;
            dtv.Columns.Add(groupid);
            DataGridViewTextBoxColumn compid = new DataGridViewTextBoxColumn();
            compid.Name = "CompanyID";
            compid.DataPropertyName = "CompanyID";
            compid.Width = 0;
            compid.Visible = false;
            dtv.Columns.Add(compid);
            DataGridViewTextBoxColumn brandid = new DataGridViewTextBoxColumn();
            brandid.Name = "BrandID";
            brandid.DataPropertyName = "BrandID";
            brandid.Width = 0;
            brandid.Visible = false;
            dtv.Columns.Add(brandid);
            DataGridViewTextBoxColumn modelid = new DataGridViewTextBoxColumn();
            modelid.Name = "ModelID";
            modelid.DataPropertyName = "ModelID";
            modelid.Width = 0;
            modelid.Visible = false;
            dtv.Columns.Add(modelid);

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

            DataGridViewTextBoxColumn reqquantity = new DataGridViewTextBoxColumn();
            reqquantity.Name = "DRQty";
            reqquantity.DataPropertyName = "DRQty";
            reqquantity.Width = 60;
            reqquantity.Visible = true;
            reqquantity.ReadOnly = false;
            dtv.Columns.Add(reqquantity);

            DataGridViewTextBoxColumn colremqty = new DataGridViewTextBoxColumn();
            colremqty.Name = "RemQty";
            colremqty.DataPropertyName = "RemQty";
            colremqty.Width = 0;
            colremqty.Visible = false;
            colremqty.ReadOnly = true;
            dtv.Columns.Add(colremqty);

            DataGridViewTextBoxColumn groupname = new DataGridViewTextBoxColumn();
            groupname.Name = "Group";
            groupname.DataPropertyName = "Group";
            groupname.Width = 200;
            groupname.Visible = true;
            groupname.ReadOnly = true;
            dtv.Columns.Add(groupname);

            DataGridViewTextBoxColumn compname = new DataGridViewTextBoxColumn();
            compname.Name = "Company";
            compname.DataPropertyName = "Company";
            compname.Width = 200;
            compname.Visible = true;
            compname.ReadOnly = true;
            dtv.Columns.Add(compname);

            DataGridViewTextBoxColumn brandname = new DataGridViewTextBoxColumn();
            brandname.Name = "Brand";
            brandname.DataPropertyName = "Brand";
            brandname.Width = 90;
            brandname.Visible = true;
            brandname.ReadOnly = true;
            dtv.Columns.Add(brandname);

            DataGridViewTextBoxColumn modelname = new DataGridViewTextBoxColumn();
            modelname.Name = "Model";
            modelname.DataPropertyName = "Model";
            modelname.Width = 0;
            modelname.Visible = false;
            modelname.ReadOnly = true;
            dtv.Columns.Add(modelname);

            DataGridViewTextBoxColumn colreqby = new DataGridViewTextBoxColumn();
            colreqby.Name = "ReqBy";
            colreqby.DataPropertyName = "ReqBy";
            colreqby.Width = 100;
            colreqby.Visible = true;
            colreqby.ReadOnly = true;
            dtv.Columns.Add(colreqby);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.Width = 60;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dtv.Columns.Add(Deletelink);

        }
        private void LoadListView()
        {
            
            ListViewItem itm = new ListViewItem(txtItemID.Text);
            itm.SubItems.Add(txtItemName.Text);
            itm.SubItems.Add(txtTypeID.Text);
            itm.SubItems.Add(txtUnitID.Text);
            itm.SubItems.Add(txtGroupID.Text);
            itm.SubItems.Add(txtCompanyID.Text);
            itm.SubItems.Add(txtBrandID.Text);
            itm.SubItems.Add(txtModelID.Text);
            itm.SubItems.Add(txtStoreType.Text);
            itm.SubItems.Add(txtMajorGroup.Text);
            itm.SubItems.Add(txtQuantity.Text);
            itm.SubItems.Add(txtQuantity.Text);
            itm.SubItems.Add(txtGroupName.Text);
            itm.SubItems.Add(txtCompanyName.Text);
            itm.SubItems.Add(txtBrandName.Text);
            itm.SubItems.Add(txtModelName.Text);            
            lvItemList.Items.Add(itm);
        }
        public bool IsDuplicateFoundInList(DataGridView lv, short columnIndex, string keyword)
        {
            for (int i = 0; i < lv.Rows.Count; i++)
            {

                DataGridViewRow item = lv.Rows[i];
                if (item.Cells[columnIndex].Value.ToString().ToUpper() == keyword.ToString().ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
        private void LoadListDataGridView()
        {
           
            if (IsDuplicateFoundInList(dgvDrDetails, 1, txtItemID.Text))
            {
                MessageBox.Show("This Item is a duplicate");
                return;
            }
            short rowindex = 1;  
            int i = Convert.ToInt16(dgvDrDetails.Rows.Count);
            dgvDrDetails.Rows.Add(1);
            dgvDrDetails.Rows[i].Cells["ItemID"].Value = txtItemID.Text;
            dgvDrDetails.Rows[i].Cells["Item"].Value = txtItemName.Text;            
            dgvDrDetails.Rows[i].Cells["CompanyID"].Value = txtCompanyID.Text;
            dgvDrDetails.Rows[i].Cells["GroupID"].Value = txtGroupID.Text;
            dgvDrDetails.Rows[i].Cells["UnitID"].Value = txtUnitID.Text;
            dgvDrDetails.Rows[i].Cells["TypeID"].Value = txtTypeID.Text;
            dgvDrDetails.Rows[i].Cells["ModelID"].Value = txtModelID.Text;
            dgvDrDetails.Rows[i].Cells["BrandID"].Value = txtBrandID.Text;
            dgvDrDetails.Rows[i].Cells["StoreTypeID"].Value = txtStoreType.Text;
            dgvDrDetails.Rows[i].Cells["MajorGroup"].Value = txtMajorGroup.Text;
            dgvDrDetails.Rows[i].Cells["Group"].Value = txtGroupName.Text;
            dgvDrDetails.Rows[i].Cells["Company"].Value = txtCompanyName.Text;
            dgvDrDetails.Rows[i].Cells["Brand"].Value = txtBrandName.Text;
            dgvDrDetails.Rows[i].Cells["Model"].Value = txtModelName.Text;
            dgvDrDetails.Rows[i].Cells["DRQty"].Value = txtQuantity.Text;
            dgvDrDetails.Rows[i].Cells["RemQty"].Value = txtQuantity.Text;
            dgvDrDetails.Rows[i].Cells["ReqBy"].Value = txtRequisitionBy.Text;
            foreach (DataGridViewRow row in dgvDrDetails.Rows)
            {
                row.Cells["SNo"].Value = rowindex;
                rowindex++;
            }
        }
        private void LoadListViewDrDetails(string drid)
        {           
            
            short index = 0, rowindex = 1;
            //dgvDrDetails.Visible = true;
            dgvDrDetails.Rows.Clear();
            List<DemandRequisition> list = new List<DemandRequisition>();
            list.Clear();
            list.AddRange(invSr.GetDrDetails(drid).ToList());
            foreach (DemandRequisition data in list)
            {
                string[] row = new string[] { rowindex.ToString(),
                                              data.ItemMaster.ID,                                              
                                              data.ItemMaster.Name,
                                              data.ItemMaster.PacketType.ID,
                                              data.ItemMaster.Units.ID,
                                              data.ItemMaster.GroupDetails.ID,
                                              data.ItemMaster.Company.ID,
                                              data.ItemMaster.BrandSetup.ID,
                                              data.ItemMaster.ModelSetup.ID,
                                              data.ItemMaster.StoreType.strTypeID,
                                              data.ItemMaster.Majorgroup.MajorgrpID,
                                              data.DemandQty.ToString(),
                                              data.RemainingQty.ToString(),
                                              data.ItemMaster.GroupDetails.Name,
                                              data.ItemMaster.Company.Name,
                                              data.ItemMaster.BrandSetup.Name,
                                              data.ItemMaster.ModelSetup.Name,
                                              data.RequisitionBy
                                              };
                AddRowsToCollection(dgvDrDetails, row, index);
                index++;
                rowindex++;
            }
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }
        private void ButtonAdd()
        {
            if(String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please put Quantity");
                return;
            }

            //LoadListView();
            LoadListDataGridView();
            txtItemID.Select();
            RefreshList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //ButtonAdd();
        }

        private void btnCloseclk_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in lvItemList.SelectedItems)
            {
                lvItemList.Items.Remove(lvItem);
            }
            txtItemID.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtRemainingQty.Text = string.Empty;
        }
        private void FormatData(DataGridView dtv)
        {
            dtv.Height = 300;
            dtv.Width = 1040;
            
            dtv.AutoGenerateColumns = false;
            dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y + txtItemID.Height);

            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 0;
            itemid.Visible = false;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Item";
            itemname.DataPropertyName = "Item";
            itemname.Width = 300;
            itemname.Visible = true;
            dtv.Columns.Add(itemname);
            DataGridViewTextBoxColumn compid = new DataGridViewTextBoxColumn();
            compid.Name = "CompanyID";
            compid.DataPropertyName = "CompanyID";
            compid.Width = 0;
            compid.Visible = false;
            dtv.Columns.Add(compid);
            DataGridViewTextBoxColumn compname = new DataGridViewTextBoxColumn();
            compname.Name = "Company";
            compname.DataPropertyName = "Company";
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
            groupname.Name = "Group";
            groupname.DataPropertyName = "Group";
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
            typename.Name = "Type";
            typename.DataPropertyName = "Type";
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
            unitname.Name = "Unit";
            unitname.DataPropertyName = "Unit";
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
            modelname.Name = "Model";
            modelname.DataPropertyName = "Model";
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
            brandname.Name = "Brand";
            brandname.DataPropertyName = "Brand";
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
            

        }
        private void populateDataToGridItem(DataGridView dtv, string itemname,string storeid)
        {
           
            dgvItem.Visible = true;
            List<ItemMaster> list = new List<ItemMaster>();
            list.AddRange(invSr.GetItemsByName(itemname,storeid).ToList());
            if (list.Count > 0)
            {
                dgvItem.DataSource = list.Select(data => new
                {
                    ItemID = data.ID,
                    Item = data.Name,
                    CompanyID = data.Company.ID,
                    Company = data.Company.Name,
                    GroupID = data.GroupDetails.ID,
                    Group = data.GroupDetails.Name,
                    TypeID = data.PacketType.ID,
                    Type = data.PacketType.Name,
                    UnitID = data.Units.ID,
                    Unit = data.Units.Name,
                    ModelID = data.ModelSetup.ID,
                    Model = data.ModelSetup.Name,
                    BrandID = data.BrandSetup.ID,
                    Brand = data.BrandSetup.Name,
                    StoreTypeID = data.StoreType.strTypeID,
                    MajorGroup = data.Majorgroup.MajorgrpID
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
                    
                    txtItemID.Select();
                }
                else
                {
                    populateDataToGridItem(dgvItem, txtItemID.Text,cboStoreType.SelectedValue.ToString());
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
                populateDataToGridItem(dgvItem, txtItemID.Text, cboStoreType.SelectedValue.ToString());
                dgvItem.Focus();
                
            }
        }

        private void frmDemandRequisition_Load(object sender, EventArgs e)
        {
            
            txtDrID.Select();

            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(invSr.GetDepartmentsetupDic(null, Utility.UserDepartmentGroupID), null);

            cboWarehouse.ValueMember = "TypeID";
            cboWarehouse.DisplayMember = "TypeName";
            cboWarehouse.DataSource = new BindingSource(invSr.GeHktwarehouse("D"), null);

            txtDRDate.Text = DateTime.Now.ToString(); 
            cboStoreType.ValueMember = "strTypeID";
            cboStoreType.DisplayMember = "TypeTitle";
            cboStoreType.DataSource = new BindingSource(invSr.LoadStoreType(), null);

            cboStoreLocation.DisplayMember = "WhName";
            cboStoreLocation.ValueMember = "Whid";
            cboStoreLocation.DataSource = new BindingSource(invSr.GetWarehouse(), null);

           
            FormatGrid();
            FormatDataForDR(dgvDrDetails);
            FormatData(dgvItem);
            dgvItem.Visible = false;

            cboDepartment.Text = Utility.UserDepartment;
            cboUnit.Text = Utility.UserUnitTitle;

            txtRequisitionBy.Text = Utility.UserId;            

            cboDepartment.SelectedIndexChanged += new EventHandler(cboDepartment_SelectedIndexChanged);
            cboDepartment.Enabled = false;
            cboUnit.Enabled = false;
           
        }

        private void lvItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {
            if (dtv.Rows.Count > 0)
            {
                int currentRow = dtv.CurrentRow.Index;
                currentRow--;
                txtItemID.Text = dtv["ItemID", currentRow + 1].Value.ToString();
                txtItemName.Text = dtv["Item", currentRow + 1].Value.ToString();
                txtCompanyID.Text = dtv["CompanyID", currentRow + 1].Value.ToString();
                txtGroupID.Text = dtv["GroupID", currentRow + 1].Value.ToString();
                txtUnitID.Text = dtv["UnitID", currentRow + 1].Value.ToString();
                txtTypeID.Text = dtv["TypeID", currentRow + 1].Value.ToString();
                txtModelID.Text = dtv["ModelID", currentRow + 1].Value.ToString();
                txtBrandID.Text = dtv["BrandID", currentRow + 1].Value.ToString();
                txtGroupName.Text = dtv["Group", currentRow + 1].Value.ToString();
                txtCompanyName.Text = dtv["Company", currentRow + 1].Value.ToString();
                txtBrandName.Text = dtv["Brand", currentRow + 1].Value.ToString();
                txtModelName.Text = dtv["Model", currentRow + 1].Value.ToString();
                txtStoreType.Text = dtv["StoreTypeID", currentRow + 1].Value.ToString();
                txtMajorGroup.Text = dtv["MajorGroup", currentRow + 1].Value.ToString();
                dtv.Visible = false;
                txtQuantity.Select();
            }
            else
            {
                dtv.Visible = false;
                txtQuantity.Select();
            }
        }
        private void dgvItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            txtItemName.Text = string.Empty;
            txtGroupName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }
        public void RefreshList()
        {
            txtItemID.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtCompanyID.Text = string.Empty;
            txtGroupID.Text = string.Empty;
            txtUnitID.Text = string.Empty;
            txtTypeID.Text = string.Empty;
            txtModelID.Text = string.Empty;
            txtBrandID.Text = string.Empty;
            txtStoreType.Text = string.Empty;
            txtMajorGroup.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRequisitionBy" };
            Control control = Utility.ReqFieldValidator(this, vf);
            

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (cboStoreLocation.SelectedIndex == -1)
            {
                MessageBox.Show("--Please Select Store--");
                return;
            }
            if (invSr.VarifyDemandReqNo(txtDrID.Text) > 0)
            {
                MessageBox.Show("This Requisition is already exist");
                return;
            }
            if(txtDrID.Text != string.Empty)
            {
                MessageBox.Show("Please clear Requisition No");
                return;
            }
           

            if (txtDRDate.Text == "  /  /")
            {
                MessageBox.Show("Date cannot be Empty");
                return;
            }
            
            for(int i = 0; i< dgvDrDetails.Rows.Count;i++)
            {
                if (dgvDrDetails.Rows[i].Cells["ItemID"].Value == null ||
                    dgvDrDetails.Rows[i].Cells["CompanyID"].Value == null ||
                    dgvDrDetails.Rows[i].Cells["GroupID"].Value == null ||
                    dgvDrDetails.Rows[i].Cells["UnitID"].Value == null ||
                    dgvDrDetails.Rows[i].Cells["TypeID"].Value == null ||
                    dgvDrDetails.Rows[i].Cells["ModelID"].Value == null ||
                    dgvDrDetails.Rows[i].Cells["BrandID"].Value == null ||
                    dgvDrDetails.Rows[i].Cells["StoreTypeID"].Value == null ||
                    dgvDrDetails.Rows[i].Cells["MajorGroup"].Value == null ||
                    dgvDrDetails.Rows[i].Cells["DRQty"].Value == null)
                {
                    MessageBox.Show("Requisition details value cannot be null");
                    return;
                }
                if (float.Parse(dgvDrDetails.Rows[i].Cells["DRQty"].Value.ToString()) <= 0)                
                {
                    MessageBox.Show("ReqQty can not less than or equal zero");
                    return;
                }
            }
            //if (lvItemList.Items.Count == 0)
            //{
            //    MessageBox.Show("--Please add Item--");
            //    return;
            //}
            try
            {

                DemandRequisition odemand = this.populateDemandRequisition();
                string i = invSr.SaveDemandRequisition(odemand);
                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else 
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    //RefreshGrid();
                    //btnNew.PerformClick();
                    txtDrID.Text = i;
                    //cboBuilding.Focus();
                    lvItemList.Items.Clear();
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
        private DemandRequisition populateDemandRequisition()
        {
            DemandRequisition odemand = new DemandRequisition();
            odemand.TransactionType = "DR";
            
            odemand.RequisitionDate = DateTime.Parse(txtDRDate.Text);
            odemand.RequisitionType = "D";
            odemand.RequisitionBy = txtRequisitionBy.Text;
            odemand.Remarks = txtRemarks.Text;

            Warehouse owarehouse = new Warehouse();
            owarehouse.TypeID = cboStoreLocation.SelectedValue.ToString();
            odemand.Warehouse = owarehouse;          
                
            Department odept = new Department();
            odept.DepartmentID = cboDepartment.SelectedValue.ToString();
            odemand.Department = odept;
            

            DepartmentUnit ounit = new DepartmentUnit();
            ounit.UnitId = cboUnit.SelectedValue.ToString();
            odemand.DepartmentUnit = ounit;
            
            StoreTypeSCM ostore = new StoreTypeSCM();
            ostore.strTypeID = cboStoreType.SelectedValue.ToString();
            odemand.StoreTypeSCM = ostore;

            
            string drString = "";

            foreach (DataGridViewRow dr in dgvDrDetails.Rows)
            {
                
                drString += dr.Cells[1].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[7].Value.ToString() + "," + dr.Cells[8].Value.ToString() + "," + dr.Cells[9].Value.ToString() + "," + dr.Cells[10].Value.ToString() + "," + dr.Cells[11].Value.ToString() + "," + dr.Cells[12].Value.ToString();
                drString += ";";
            }
            //foreach (ListViewItem itemRow in lvItemList.Items)
            //{
            //    drString += itemRow.SubItems[0].Text + "," + itemRow.SubItems[2].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[5].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[7].Text + "," + itemRow.SubItems[8].Text + "," + itemRow.SubItems[9].Text + "," + itemRow.SubItems[10].Text + "," + itemRow.SubItems[11].Text;
            //    drString += ";";
            //}
            odemand.ReqDetails = drString;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            odemand.EntryParameter = ep;
            return odemand;
        }
        private void PrintReport(string drid)
        {
            frmReportViewer ofrmreportviewer = new frmReportViewer();
            ofrmreportviewer.selector = ViewerSelector.DrReport;
            ofrmreportviewer.DRID = drid;
            ofrmreportviewer.ReportTitle = "Demand Requisition";
            ofrmreportviewer.ViewReport();
        }
        private void pnlMain_Click(object sender, EventArgs e)
        {
            dgvItem.Visible = false;
        }
       

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cboDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }            
        }

        private void cboStoreLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void txtRequisitionBy_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{TAB}");

            //}
        }

        private void cboDRType_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{TAB}");

            //}
        }

        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{TAB}");

            //}
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{TAB}");

            //}
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{TAB}");

            //}
        }

        private void lvItemList_DoubleClick(object sender, EventArgs e)
        {
            //foreach (ListViewItem lvItem in lvItemList.SelectedItems)
            //{
            //    lvItemList.Items.Remove(lvItem);
            //}
            //txtItemID.Text = string.Empty;
            //txtItemName.Text = string.Empty;
            //txtQuantity.Text = string.Empty;
            //txtRemainingQty.Text = string.Empty;
        }
        private void UserID()
        {
            txtRequisitionBy.Text = Utility.UserId;
            lblInfo.Visible = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = invSr.GetEmpMaster(txtRequisitionBy.Text);
            lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
        }
        private void txtRequisitionBy_Leave(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = invSr.GetEmpMaster(txtRequisitionBy.Text);
            if (txtRequisitionBy.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtRequisitionBy.Text != "")
            {
                if (txtRequisitionBy.Text == oEmpMas.EmpId)
                {

                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                    //lblDept.Text = oEmpMas.Department.DepartmentID;
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRequisitionBy.Select();
                }
            }
        }

        private void txtRequisitionBy_TextChanged(object sender, EventArgs e)
        {
            UserID();
        }

        private void cboStoreType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboStoreType.SelectedValue != null)
            //{
            //    cboStoreLocation.ValueMember = "ID";
            //    cboStoreLocation.DisplayMember = "Name";
            //    cboStoreLocation.DataSource = new BindingSource(invSr.GetStoreLocByType(cboStoreType.SelectedValue.ToString()), null);
            //}
            dgvDrDetails.Rows.Clear();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cboDepartment.SelectedValue.ToString() != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(invSr.GetDeptUnitDic(Utility.UserDepartmentGroupID, cboDepartment.SelectedValue.ToString())), null);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtRequisitionBy.Text = Utility.UserId;
            UserID();
            cboDepartment.Text = Utility.UserDepartment;
            cboUnit.Text = Utility.UserUnitTitle;
            dgvDrDetails.Rows.Clear();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            lvItemList.Items.Clear();
        }
        private void SearchRequisition()
        {
            lvItemList.Items.Clear();
            int vrfy = invSr.VarifyDemandReqNo(txtDrID.Text);

            if (txtDrID.Text == "")
            {
                frmDemandRequisitionList odemandlist = new frmDemandRequisitionList();
                odemandlist.onAddAllButtonClicked = new frmDemandRequisitionList.AddAllClick(AddDataToReqList);
                odemandlist.ShowDialog();
                //btnSearch.PerformClick();
                txtRemarks.DataBindings.Clear();
                cboStoreLocation.DataBindings.Clear();
                cboStoreType.DataBindings.Clear();
                txtRemarks.DataBindings.Add("Text", invSr.GetDrDetails(txtDrID.Text).ToList(), "Remarks");

                cboStoreLocation.DataBindings.Add("SelectedValue", invSr.GetDrDetails(txtDrID.Text).ToList(), "Warehouse.TypeID");

                cboStoreType.DataBindings.Add("SelectedValue", invSr.GetDrDetails(txtDrID.Text).ToList(), "StoreTypeSCM.strTypeID");

                //cboStoreType.SelectedIndexChanged += cboStoreType_SelectedIndexChanged;
                LoadListViewDrDetails(txtDrID.Text);
                txtDrID.Select();
            }
            else if (vrfy == 0)
            {
                MessageBox.Show("Please put valid DR No");
                dgvDrDetails.Rows.Clear();
                txtDrID.Text = "";
                cboWarehouse.DataBindings.Clear();
                cboStoreType.DataBindings.Clear(); ;
                cboStoreLocation.DataBindings.Clear();
                txtRemarks.Text = "";
                txtDrID.Select();
                return;

            }


            else
            {
                txtRemarks.DataBindings.Clear();
                cboStoreLocation.DataBindings.Clear();
                cboStoreType.DataBindings.Clear();
                txtRemarks.DataBindings.Add("Text", invSr.GetDrDetails(txtDrID.Text).ToList(), "Remarks");

                cboStoreLocation.DataBindings.Add("SelectedValue", invSr.GetDrDetails(txtDrID.Text).ToList(), "Warehouse.TypeID");

                cboStoreType.DataBindings.Add("SelectedValue", invSr.GetDrDetails(txtDrID.Text).ToList(), "StoreTypeSCM.strTypeID");

                cboStoreType.SelectedIndexChanged += cboStoreType_SelectedIndexChanged;
                LoadListViewDrDetails(txtDrID.Text);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            SearchRequisition();
            
        }
        private void AddDataToReqList(List<DemandRequisition> tests, object sender, EventArgs e)
        {


            try
            {

                foreach (DemandRequisition ts in tests)
                {
                    txtDrID.Text = ts.ID;
                }

                //Ticket tktObj = this.PopulateTicket(payment);
                //string i = opdsr.SaveOPDTicket(tktObj);
                //txtTicketNo.Text = i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtDrID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSearch.Select();
            }
        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Select();
            }
        }

       
        private void txtItemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    txtQuantity.Select();
            //}
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtItemID.Select();
            }
        }

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtItemID.Select();
            }
        }

        private void dgvItem_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvItem.Rows[e.RowIndex];
                txtItemID.Text = row.Cells["ItemID"].Value.ToString();
                txtItemName.Text = row.Cells["Item"].Value.ToString();
                txtCompanyID.Text = row.Cells["CompanyID"].Value.ToString();
                txtGroupID.Text = row.Cells["GroupID"].Value.ToString();
                txtUnitID.Text = row.Cells["UnitID"].Value.ToString();
                txtTypeID.Text = row.Cells["TypeID"].Value.ToString();
                txtModelID.Text = row.Cells["ModelID"].Value.ToString();
                txtBrandID.Text = row.Cells["BrandID"].Value.ToString();
                txtGroupName.Text = row.Cells["Group"].Value.ToString();
                txtCompanyName.Text = row.Cells["Company"].Value.ToString();
                txtBrandName.Text = row.Cells["Brand"].Value.ToString();
                txtModelName.Text = row.Cells["Model"].Value.ToString();
                txtStoreType.Text = row.Cells["StoreTypeID"].Value.ToString();
                txtMajorGroup.Text = row.Cells["MajorGroup"].Value.ToString();
                dgvItem.Visible = false;
                txtQuantity.Select();

            }
        }

        private void dgvItem_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            setvaluesFromList(dgvItem, sender);
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtItemID.Text.Length == 7 && Utility.IsNumeric(txtItemID.Text))
            {
                ButtonAdd();
            }
        }
        private void dgvDrDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 18)
            {
                int selRowIndex = e.RowIndex;
                if (selRowIndex < 0)
                {
                    dgvDrDetails.Rows.Clear();
                }
                else
                {
                    dgvDrDetails.Rows.RemoveAt(selRowIndex);
                }

            }
        }

        private void dgvDrDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDrDetails.CurrentRow.Cells["DRQty"].Value != null)
            {
                txtItemID.Text = dgvDrDetails.CurrentRow.Cells["ItemID"].Value.ToString();
                txtItemName.Text = dgvDrDetails.CurrentRow.Cells["Item"].Value.ToString();
                txtGroupName.Text = dgvDrDetails.CurrentRow.Cells["Group"].Value.ToString();
                txtQuantity.Text = dgvDrDetails.CurrentRow.Cells["DRQty"].Value.ToString();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintReport(txtDrID.Text);
        }
        private void SearchVerifyRQList()
        {
            lvItemList.Items.Clear();
            int vrfy = invSr.VarifyDemandReqNo(txtDrID.Text);

            if (txtDrID.Text == "")
            {
                frmDRVerifyList odemandlist = new frmDRVerifyList();
                odemandlist.onAddAllButtonClicked = new frmDRVerifyList.AddAllClick(AddDataToReqList);
                odemandlist.ShowDialog();
                //btnSearch.PerformClick();
                txtRemarks.DataBindings.Clear();
                cboWarehouse.DataBindings.Clear();
                cboStoreType.DataBindings.Clear();
                txtRemarks.DataBindings.Add("Text", invSr.GetDrDetails(txtDrID.Text).ToList(), "Remarks");

                cboWarehouse.DataBindings.Add("SelectedValue", invSr.GetDrDetails(txtDrID.Text).ToList(), "Warehouse.TypeID");

                cboStoreType.DataBindings.Add("SelectedValue", invSr.GetDrDetails(txtDrID.Text).ToList(), "StoreLocation.StoreType.strTypeID");

                cboStoreType.SelectedIndexChanged += cboStoreType_SelectedIndexChanged;
                LoadListViewDrDetails(txtDrID.Text);
                txtDrID.Select();
            }
            else if (vrfy == 0)
            {
                MessageBox.Show("Please put valid DR No");
                dgvDrDetails.Rows.Clear();
                txtDrID.Text = "";
                cboWarehouse.DataBindings.Clear();
                cboStoreType.DataBindings.Clear(); ;
                cboStoreLocation.DataBindings.Clear();
                txtRemarks.Text = "";
                txtDrID.Select();
                return;

            }
        }
        private void btnReqVerifyList_Click(object sender, EventArgs e)
        {
            //SearchVerifyRQList();

            frmDRVerifyList odemandlist = new frmDRVerifyList();
            odemandlist.onAddAllButtonClicked = new frmDRVerifyList.AddAllClick(AddDataToReqList);
            odemandlist.ShowDialog();
            txtRemarks.DataBindings.Clear();
            cboWarehouse.DataBindings.Clear();
            cboStoreType.DataBindings.Clear();
            txtRemarks.DataBindings.Add("Text", invSr.GetDrDetails(txtDrID.Text).ToList(), "Remarks");

            cboWarehouse.DataBindings.Add("SelectedValue", invSr.GetDrDetails(txtDrID.Text).ToList(), "Warehouse.TypeID");

            cboStoreType.DataBindings.Add("SelectedValue", invSr.GetDrDetails(txtDrID.Text).ToList(), "StoreLocation.StoreType.strTypeID");

            cboStoreType.SelectedIndexChanged += cboStoreType_SelectedIndexChanged;
            LoadListViewDrDetails(txtDrID.Text);
        }

        private void dgvDrDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDrDetails.Columns[e.ColumnIndex].Name.Equals("DRQty"))
            {
                double intValue;
                if (dgvDrDetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (double.TryParse((String)e.Value, out intValue) &&
                    (intValue < 0))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;
                }
            }
           
            ((DataGridViewTextBoxColumn)dgvDrDetails.Columns["DRQty"]).MaxInputLength = 6;
        }

        private void dgvDrDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgvDrDetails.Columns["DRQty"].Index) //this is numeric column
            {
                float i;
                if (!float.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Must be numeric");
                }
            }
        }
 

    }
}
