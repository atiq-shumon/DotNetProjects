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
    public partial class frmIssueRequisition : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        private string salesType;

        public frmIssueRequisition(string salesType)
        {
            InitializeComponent();
            this.salesType = salesType;
        }

        private void frmIssueRequisition_Load(object sender, EventArgs e)
        {
            cboSalesTypes.DisplayMember = "Value";
            cboSalesTypes.ValueMember = "Key";
            cboSalesTypes.DataSource = new BindingSource(Utility.GetSalesTypes(), null);

            cboStoreLocation.ValueMember = "ID";
            cboStoreLocation.DisplayMember = "Name";
            cboStoreLocation.DataSource = new BindingSource(invSr.GetStoreLocation(), null);

            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(invSr.GetDepartments("D"), null);

            //cboUnit.DisplayMember = "Value";
            //cboUnit.ValueMember = "Key";
            //cboUnit.DataSource = new BindingSource(invSr.GetDepartmentUnit("E"), null);

            txtIssueDate.Text = DateTime.Now.ToString();

            FormatForm(this.salesType);

            dgvItem.Visible = false;
            FormatData(dgvItem);

            FormatGrid();
        }
        private void FormatForm(string mode)
        {
            switch (mode)
            {
                case "O":

                    txtRegistrationNo.Visible = false;
                    lblNo.Visible = false;
                    btnShow.Visible = false;
                    pnlRegistration.Visible = false;
                    break;

                case "X":
                    lblNo.Text = "Registration No :";
                    txtRegistrationNo.Visible = true;
                    btnShow.Visible = true;
                    pnlRegistration.Visible = true;
                    //cboDepartment.Visible = false;
                    //cboEmpID.Visible = false;
                    //cboUnit.Visible = false;
                    //pnlRegistration.Location = cboDepartment.Location;
                    //txtHCN.Top = txtRegistrationNo.Top;
                    //txtHCN.Left = txtRegistrationNo.Left;
                    //txtHCN.Size = new Size(txtRegistrationNo.Size.Width, txtRegistrationNo.Size.Height);
                    break;
            }
        }
        private void FormatData(DataGridView dtv)
        {
            dtv.Height = 300;
            dtv.Width = 840;
            
            dtv.AutoGenerateColumns = false;
            dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 0;
            itemid.Visible = false;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Item";
            itemname.DataPropertyName = "Item";
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
            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 50;
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colVat = new DataGridViewTextBoxColumn();
            colVat.Name = "VAT";
            colVat.DataPropertyName = "VAT";
            colVat.Width = 50;
            dtv.Columns.Add(colVat);

            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Discount";
            colDiscount.DataPropertyName = "Discount";
            colDiscount.Width = 50;
            dtv.Columns.Add(colDiscount);
        }
        private void populateDataToGridItem(DataGridView dtv, string itemname,string storeid)
        {

            dgvItem.Visible = true;
            List<ItemMaster> list = new List<ItemMaster>();
            list.AddRange(invSr.GetItemsByName(itemname,storeid).ToList());

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
                Rate = data.Urate,
                VAT = data.VAT,
                Discount = data.Discount

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
                    //txtItemID.Text = string.Empty;
                    txtQuantity.Select();
                }
                else
                {
                    populateDataToGridItem(dgvItem, txtItemID.Text,cboStoreLocation.SelectedValue.ToString());
                    dgvItem.Focus();
                }
                if (dgvItem.Rows.Count == 0)
                {
                    dgvItem.Visible = false;
                    txtItemID.Select();
                    txtItemName.Text = string.Empty;
                    txtQuantity.Text = string.Empty;
                    txtURate.Text = string.Empty;
                    txtvat.Text = string.Empty;
                    txtDiscount.Text = string.Empty;
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
        private void AmountSummary()
        {

            txtAmountSummary.Text = (Utility.ParseFloat(txtQuantity.Text) * Utility.ParseFloat(txtURate.Text) + Utility.ParseFloat(txtvat.Text) - Utility.ParseFloat(txtDiscount.Text)).ToString();
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
                txtURate.Text = dtv["Rate", currentRow + 1].Value.ToString();
                txtvat.Text = dtv["VAT", currentRow + 1].Value.ToString();
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
            AmountSummary();
            txtQuantity.Select();
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
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
                txtURate.Text = row.Cells["Rate"].Value.ToString();
                txtvat.Text = row.Cells["VAT"].Value.ToString();
                txtDiscount.Text = row.Cells["Discount"].Value.ToString();
                

                dgvItem.Visible = false;
                txtQuantity.Select();
                //txtItemID.Focus();

            }
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            txtItemName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtURate.Text = string.Empty;
            txtvat.Text = string.Empty;
            txtDiscount.Text = string.Empty;
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            AmountSummary();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            //AmountSummary();

        }
        private void FormatGrid()
        {

            lvItemIssue.Columns.Add("ItemID", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Name", 400, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Type", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Type", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Unit", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Unit", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Group", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Group", 150, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Company", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Company", 150, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("BrandID", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("BrandName", 150, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("ModelID", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("ModelName", 150, HorizontalAlignment.Left);
            //lvItemIssue.Columns.Add("ReqQuantity", 70, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Quantity", 70, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Rate", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("VAT", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Discount", 0, HorizontalAlignment.Left);
            lvItemIssue.Columns.Add("Total", 0, HorizontalAlignment.Left);
            //lvItemIssue.Columns.Add("Stock", 0, HorizontalAlignment.Left);

        }
        private void LoadListView()
        {

            ListViewItem itm = new ListViewItem(txtItemID.Text);
            itm.SubItems.Add(txtItemName.Text);
            itm.SubItems.Add(txtTypeID.Text);
            itm.SubItems.Add(txtTypeName.Text);
            itm.SubItems.Add(txtUnitID.Text);
            itm.SubItems.Add(txtUnitName.Text);
            itm.SubItems.Add(txtGroupID.Text);
            itm.SubItems.Add(txtGroupName.Text);
            itm.SubItems.Add(txtCompanyID.Text);
            itm.SubItems.Add(txtCompanyName.Text);
            itm.SubItems.Add(txtBrandID.Text);
            itm.SubItems.Add(txtBrandName.Text);
            itm.SubItems.Add(txtModelID.Text);
            itm.SubItems.Add(txtModelName.Text);
            //itm.SubItems.Add("1000");
            itm.SubItems.Add(txtQuantity.Text);
            itm.SubItems.Add(txtURate.Text);
            itm.SubItems.Add(txtvat.Text);
            itm.SubItems.Add(txtDiscount.Text);
            itm.SubItems.Add(txtAmountSummary.Text);
            //itm.SubItems.Add(txtQuatityCompareText.Text);
            lvItemIssue.Items.Add(itm);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtItemName", "txtURate" };
            Control control = Utility.ReqFieldValidator(this, vf);


            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvItemIssue, 0, txtItemID.Text))
            {
                MessageBox.Show("Already Exist");
                return;
            }
            if (txtQuantity.Text == "0" || String.IsNullOrEmpty(txtQuantity.Text) || txtURate.Text == "0")
            {

                MessageBox.Show("Value must not be null or zero");
                txtQuantity.Select();
                return;
            }
            LoadListView();
        }

        private void btnCloseclk_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in lvItemIssue.SelectedItems)
            {
                lvItemIssue.Items.Remove(lvItem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtItemName", "txtReceivedBy", "txtRemarks" };
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            
            if (txtIssueDate.Text == "  /  /")
            {
                MessageBox.Show("Date cannot be Empty");
                return;
            }

            if (lvItemIssue.Items.Count == 0)
            {
                MessageBox.Show("Please choose an item");
                return;

            }
            try
            {

                IssueRequisition issueObj = this.populateDrugIssue();

                short i = invSr.SaveIssueRequisition(issueObj);


                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ResetField();
                    btnNew.PerformClick();
                    //lvDrugIssue.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private IssueRequisition populateDrugIssue()
        {
            IssueRequisition oitemissue = new IssueRequisition();
           
            oitemissue.ConsumptionHeadID = "0001";
            oitemissue.ConsumptionID = "0001";
            oitemissue.IRDate = DateTime.Parse(txtIssueDate.Text);
            oitemissue.IRType = cboSalesTypes.SelectedValue.ToString();
            oitemissue.RequisitionBy = txtReceivedBy.Text;
            oitemissue.Remarks = txtRemarks.Text;
            oitemissue.TransactionType = "CO";
            



            oitemissue.RegID = txtRegistrationNo.Text;
            oitemissue.Staff = "01245";
            oitemissue.HCN = "010124556";
            oitemissue.EmpID = "01254";

            Bed obed = new Bed();
            obed.BedNo = lblBedNo.Text;

            BedType obedtype = new BedType();
            obedtype.ID = lblBedType.Text;
            obed.BedType = obedtype;

            Ward oward = new Ward();
            oward.WardID = lblWard.Text;
            obed.Ward = oward;

            Room orm = new Room();
            orm.RoomID = lblRoom.Text;
            obed.Room = orm;

            oitemissue.Bed = obed;
            // oitemissue.Doctor = txtDoctor.Text;

            Department dpt = new Department();
            dpt.DepartmentID = cboDepartment.SelectedValue.ToString();
            oitemissue.Department = dpt;

            DepartmentUnit dunit = new DepartmentUnit();
            dunit.UnitId = cboUnit.SelectedValue.ToString();
            oitemissue.DepartmentUnit = dunit;

            Stock stk = new Stock();

            StoreLocation ostore = new StoreLocation();
            ostore.ID = cboStoreLocation.SelectedValue.ToString();
            stk.StoreLocaton = ostore;
            oitemissue.Stock = stk;
            //PurchaseOrder po = new PurchaseOrder();
            //po.ID = cboPurchaseOrder.Text;
            //po.PODate = DateTime.Parse(txtPODate.Text);
            //dr.PurchaseOrder = po;


            string IssueString = "";

            foreach (ListViewItem itemRow in lvItemIssue.Items)
            {

                IssueString += itemRow.SubItems[0].Text + "," + itemRow.SubItems[2].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[8].Text + "," + itemRow.SubItems[10].Text + "," + itemRow.SubItems[12].Text + "," + itemRow.SubItems[14].Text + "," + itemRow.SubItems[15].Text + "," + itemRow.SubItems[16].Text + "," + itemRow.SubItems[17].Text ;
                IssueString += ";";
            }
            oitemissue.IRDetails = IssueString;


            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oitemissue.EntryParameter = ep;

            return oitemissue;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
