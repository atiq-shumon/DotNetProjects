using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;
//using AH.ModuleController.UI.PHRMS.Reports.Viewer;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmTransferRequisition : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmTransferRequisition()
        {
            InitializeComponent();
        }
   
        private void frmPurchaseRequisition_Load(object sender, EventArgs e)
        {
            
            txtDepartment.Select();

            cboStoreLocation.ValueMember = "Whid";
            cboStoreLocation.DisplayMember = "WhName";
            cboStoreLocation.DataSource = new BindingSource(invSr.GetWhTypeforSCM("0062", "1"), null);

            cboTransferStore.DisplayMember = "WhName";
            cboTransferStore.ValueMember = "Whid";
            cboTransferStore.DataSource = new BindingSource(invSr.GetWarehouseTypewise("0","1"), null);

            txtDepartment.Text = Utility.UserDepartID;
            txtUnit.Text = Utility.UserUnitID;            
            FormatGridProd(dgvProduction);
            dgvProduction.Visible = false;
            FormatGrid();
           
        }
        private void FormatGridProd(DataGridView dtv)
        {
            //dtv.ColumnHeadersVisible = false;
            dtv.Height = 250;
            dtv.Width = 750;

            dtv.Location = new Point(lvItemList.Location.X, lvItemList.Location.Y);
            dtv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDrugId = new DataGridViewTextBoxColumn();
            colDrugId.Name = "ITEMID";
            colDrugId.DataPropertyName = "ITEMID";
            colDrugId.Width = 0;
            colDrugId.Visible = false;
            dtv.Columns.Add(colDrugId);
            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn();
            colDrugTitle.Name = "Item Name";
            colDrugTitle.DataPropertyName = "ITEMNAME";
            colDrugTitle.Width = 190;
            colDrugTitle.Visible = true;
            dtv.Columns.Add(colDrugTitle);
            DataGridViewTextBoxColumn colCompanyID = new DataGridViewTextBoxColumn();
            colCompanyID.Name = "COMPANYID";
            colCompanyID.DataPropertyName = "COMPANYID";
            colCompanyID.Width = 0;
            colCompanyID.Visible = false;
            dtv.Columns.Add(colCompanyID);
            DataGridViewTextBoxColumn colCompanyTitle = new DataGridViewTextBoxColumn();
            colCompanyTitle.Name = "Company";
            colCompanyTitle.DataPropertyName = "COMPANYNAME";
            colCompanyTitle.Width = 220;
            colCompanyTitle.Visible = true;
            dtv.Columns.Add(colCompanyTitle);
            DataGridViewTextBoxColumn colGroupID = new DataGridViewTextBoxColumn();
            colGroupID.Name = "GROUPID";
            colGroupID.DataPropertyName = "GROUPID";
            colGroupID.Width = 0;
            colGroupID.Visible = false;
            dtv.Columns.Add(colGroupID);
            DataGridViewTextBoxColumn colGroupTitle = new DataGridViewTextBoxColumn();
            colGroupTitle.Name = "Generic Name";
            colGroupTitle.DataPropertyName = "GROUPNAME";
            colGroupTitle.Width = 130;
            colGroupTitle.Visible = true;
            dtv.Columns.Add(colGroupTitle);
            DataGridViewTextBoxColumn colTypeID = new DataGridViewTextBoxColumn();
            colTypeID.Name = "TYPEID";
            colTypeID.DataPropertyName = "TYPEID";
            colTypeID.Width = 0;
            colTypeID.Visible = false;
            dtv.Columns.Add(colTypeID);
            DataGridViewTextBoxColumn colPackName = new DataGridViewTextBoxColumn();
            colPackName.Name = "Unit Pack";
            colPackName.DataPropertyName = "PACKNAME";
            colPackName.Width = 0;
            colPackName.Visible = false;
            dtv.Columns.Add(colPackName);
            DataGridViewTextBoxColumn colUnitID = new DataGridViewTextBoxColumn();
            colUnitID.Name = "UNITID";
            colUnitID.DataPropertyName = "UNITID";
            colUnitID.Width = 0;
            colUnitID.Visible = false;
            dtv.Columns.Add(colUnitID);
            DataGridViewTextBoxColumn colUnitName = new DataGridViewTextBoxColumn();
            colUnitName.Name = "Unit";
            colUnitName.DataPropertyName = "UNITNAME";
            colUnitName.Width = 0;
            colUnitName.Visible = false;
            dtv.Columns.Add(colUnitName);
            DataGridViewTextBoxColumn colBrandID = new DataGridViewTextBoxColumn();
            colBrandID.Name = "BRANDID";
            colBrandID.DataPropertyName = "BRANDID";
            colBrandID.Width = 0;
            colBrandID.Visible = false;
            dtv.Columns.Add(colBrandID);
            DataGridViewTextBoxColumn colBrandName = new DataGridViewTextBoxColumn();
            colBrandName.Name = "BrandName";
            colBrandName.DataPropertyName = "BrandName";
            colBrandName.Width = 0;
            colBrandName.Visible = false;
            dtv.Columns.Add(colBrandName);
            DataGridViewTextBoxColumn colModelID = new DataGridViewTextBoxColumn();
            colModelID.Name = "ModelID";
            colModelID.DataPropertyName = "ModelID";
            colModelID.Width = 0;
            colModelID.Visible = false;
            dtv.Columns.Add(colModelID);
            DataGridViewTextBoxColumn colModelName = new DataGridViewTextBoxColumn();
            colModelName.Name = "ModelName";
            colModelName.DataPropertyName = "ModelName";
            colModelName.Width = 0;
            colModelName.Visible = false;
            dtv.Columns.Add(colModelName);
            DataGridViewTextBoxColumn colStoreTypeID = new DataGridViewTextBoxColumn();
            colStoreTypeID.Name = "StoreTypeID";
            colStoreTypeID.DataPropertyName = "StoreTypeID";
            colStoreTypeID.Width = 0;
            colStoreTypeID.Visible = false;
            dtv.Columns.Add(colStoreTypeID);
            DataGridViewTextBoxColumn colStoreTypeName = new DataGridViewTextBoxColumn();
            colStoreTypeName.Name = "StoreTypeName";
            colStoreTypeName.DataPropertyName = "StoreTypeName";
            colStoreTypeName.Width = 0;
            colStoreTypeName.Visible = false;
            dtv.Columns.Add(colStoreTypeName);
            DataGridViewTextBoxColumn colMajorGroupID = new DataGridViewTextBoxColumn();
            colMajorGroupID.Name = "MajorGroupID";
            colMajorGroupID.DataPropertyName = "MajorGroupID";
            colMajorGroupID.Width = 0;
            colMajorGroupID.Visible = false;
            dtv.Columns.Add(colMajorGroupID);
            DataGridViewTextBoxColumn colMajorGroupName = new DataGridViewTextBoxColumn();
            colMajorGroupName.Name = "MajorGroupName";
            colMajorGroupName.DataPropertyName = "MajorGroupName";
            colMajorGroupName.Width = 0;
            colMajorGroupName.Visible = false;
            dtv.Columns.Add(colMajorGroupName);
            DataGridViewTextBoxColumn colpharmacy = new DataGridViewTextBoxColumn();
            colpharmacy.Name = "StoreLocation";
            colpharmacy.DataPropertyName = "StoreLocation";
            colpharmacy.Width = 100;
            colpharmacy.Visible = true;
            dtv.Columns.Add(colpharmacy);
          
            DataGridViewTextBoxColumn colStockQty = new DataGridViewTextBoxColumn();
            colStockQty.Name = "StockQty";
            colStockQty.DataPropertyName = "StockQty";
            colStockQty.Width = 80;
            dtv.Columns.Add(colStockQty);
            dtv.Columns["StockQty"].DefaultCellStyle.ForeColor = Color.Red;
            dtv.Columns["StockQty"].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Bold);

          
        }

        private void populateDataToGridDrugByGroup(DataGridView dtv, string groupname)
        {
            //List<ItemMaster> oMedicines = new List<ItemMaster>();

            //dgvProduction.Visible = true;
            //List<ItemMaster> list = new List<ItemMaster>();
            //list.AddRange(phrSr.GetDrugStockByGroup(groupname).ToList());

            //dgvProduction.DataSource = list.Select(data => new
            //{
            //    DRUGID = data.ID,
            //    DRUGNAME = data.Name,
            //    COMPANYID = data.DrugCompany.ID,
            //    COMPANYNAME = data.DrugCompany.Name,
            //    GROUPID = data.DrugGroup.ID,
            //    GROUPNAME = data.DrugGroup.Name,
            //    TYPEID = data.DrugPackType.ID,
            //    PACKNAME = data.DrugPackType.Name,
            //    UNITID = data.DrugUnit.ID,
            //    UNITNAME = data.DrugUnit.Name,
            //    PharmacyName = data.PharmacyName,
            //    StockQty = data.StockQty           
            //}).ToList();
            //this.dgvProduction.Focus();
        }     

        private void cboReqType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtReqDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }       
        private void populateDataToGridDrug(DataGridView dtv, string itemname,string store)
        {
            //List<ItemMaster> oMedicines = new List<ItemMaster>();

            dgvProduction.Visible = true;
            List<ItemMaster> list = new List<ItemMaster>();
            list.AddRange(invSr.GetItemsByNameForTransfer(itemname, store).ToList());
          
                dgvProduction.DataSource = list.Select(data => new
                {
                    
                    ITEMID = data.ID,
                    ITEMNAME = data.Name,
                    COMPANYID = data.Company.ID,
                    COMPANYNAME = data.Company.Name,
                    GROUPID = data.GroupDetails.ID,
                    GROUPNAME = data.GroupDetails.Name,
                    UNITID = data.Units.ID,
                    UNITNAME = data.Units.Name,
                    TYPEID = data.PacketType.ID,
                    PACKNAME = data.PacketType.Name,
                    BRANDID = data.BrandSetup.ID,
                    BrandName = data.BrandSetup.Name,
                    ModelID = data.ModelSetup.ID,
                    ModelName = data.ModelSetup.Name,
                    StoreTypeID = data.StoreType.strTypeID,
                    StoreTypeName = data.StoreType.TypeTitle,
                    MajorGroupID = data.Majorgroup.MajorgrpID,
                    MajorGroupName = data.Majorgroup.Name,
                    StoreLocation = data.Warehouse.TypeName,
                    StockQty = data.StockQty
                }).ToList();
                this.dgvProduction.Focus();
            
            //else
            //{
            //    dgvProduction.Visible = false;
            //    MessageBox.Show("There is no drug in this Pharmacy");
            //    return;
            //}
            
        }

        private void txtProductionID_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {
           
            if (dtv.Rows.Count > 0)
            {
                int currentRow = dtv.CurrentRow.Index;
                currentRow--;


                txtProductionID.Text = dtv["ITEMID", currentRow + 1].Value.ToString();
                txtProductionName.Text = dtv["Item Name", currentRow + 1].Value.ToString();
                txtProductionPacketID.Text = dtv["TYPEID", currentRow + 1].Value.ToString();
                txtProductionUnitID.Text = dtv["UNITID", currentRow + 1].Value.ToString();
                txtProductionGroupID.Text = dtv["GROUPID", currentRow + 1].Value.ToString();  
                txtProductionCompanyID.Text = dtv["COMPANYID", currentRow + 1].Value.ToString();
                txtBrandID.Text = dtv["BRANDID", currentRow + 1].Value.ToString();
                txtModelID.Text = dtv["ModelID", currentRow + 1].Value.ToString();
                txtStoreTypeID.Text = dtv["StoreTypeID", currentRow + 1].Value.ToString();
                txtMajorGroupID.Text = dtv["MajorGroupID", currentRow + 1].Value.ToString();
                txtProdCompName.Text = dtv["Company", currentRow + 1].Value.ToString();                
                txtProdGroupName.Text = dtv["Generic Name", currentRow + 1].Value.ToString();                             
                txtStoreLocation.Text = dtv["StoreLocation", currentRow + 1].Value.ToString();
                txtQuantity.Text = dtv["StockQty", currentRow + 1].Value.ToString();
                txtStock.Text = dtv["StockQty", currentRow + 1].Value.ToString();
                dtv.Visible = false;
                txtProductionID.Focus();

            }
            else
            {
                dtv.Visible = false;
                txtProductionID.Focus();
            }

        }

        private void dgvProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            setvaluesFromList(dgvProduction, sender);
        }

        private void dgvProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduction.Rows[e.RowIndex];

                txtProductionID.Text = row.Cells["ITEMID"].Value.ToString();
                txtProductionName.Text = row.Cells["Item Name"].Value.ToString();
                txtProductionPacketID.Text = row.Cells["TYPEID"].Value.ToString();
                txtProductionUnitID.Text = row.Cells["UNITID"].Value.ToString();
                txtProductionGroupID.Text = row.Cells["GROUPID"].Value.ToString();
                txtProductionCompanyID.Text = row.Cells["COMPANYID"].Value.ToString();
                txtBrandID.Text = row.Cells["BRANDID"].Value.ToString();
                txtModelID.Text = row.Cells["ModelID"].Value.ToString();
                txtStoreTypeID.Text = row.Cells["StoreTypeID"].Value.ToString();
                txtMajorGroupID.Text = row.Cells["MajorGroupID"].Value.ToString();
                txtProdCompName.Text = row.Cells["Company"].Value.ToString();                
                txtProdGroupName.Text = row.Cells["Generic Name"].Value.ToString();               
                txtStoreLocation.Text = row.Cells["StoreLocation"].Value.ToString();
                txtQuantity.Text = row.Cells["StockQty"].Value.ToString();
                txtStock.Text = row.Cells["StockQty"].Value.ToString();
                dgvProduction.Visible = false;
                txtProductionID.Focus();

            }
        }
        private void FormatGrid()
        {
            lvItemList.Columns.Add("Slno", 50, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item ID", 90, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Name", 250, HorizontalAlignment.Left);
            lvItemList.Columns.Add("PackageType", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Unit", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Group", 0, HorizontalAlignment.Left);
            //lvItemList.Columns.Add("Group", 200, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Company", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Brand", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Model", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("StoreType", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("MajorGroup", 0, HorizontalAlignment.Left);
            //lvItemList.Columns.Add("Company", 200, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Generic Name", 350, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Company", 0, HorizontalAlignment.Left);
            
            lvItemList.Columns.Add("ReqQty", 80, HorizontalAlignment.Left);
            lvItemList.Columns.Add("TRQty", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("StoreLocation", 150, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Stock", 80, HorizontalAlignment.Left);
                     
        }
      

        private void LoadListView()
        {
            Double Slno = 1;
            if (lvItemList.Items.Count > 0)
            {

                foreach (ListViewItem Itm in lvItemList.Items)
                {
                    if (Itm.SubItems[0].Text != "")
                    {
                        Slno = Convert.ToDouble(Itm.SubItems[0].Text);
                    }
                    else
                    {
                        Slno = 1;
                    }
                    Slno = Slno + 1;
                   
                }
            }

            ListViewItem itm = new ListViewItem(Slno.ToString());
            itm.SubItems.Add(txtProductionID.Text);
            itm.SubItems.Add(txtProductionName.Text);
            itm.SubItems.Add(txtProductionPacketID.Text);
            itm.SubItems.Add(txtProductionUnitID.Text);
            itm.SubItems.Add(txtProductionGroupID.Text);
            itm.SubItems.Add(txtProductionCompanyID.Text);
            itm.SubItems.Add(txtBrandID.Text);
            itm.SubItems.Add(txtModelID.Text);
            itm.SubItems.Add(txtStoreTypeID.Text);
            itm.SubItems.Add(txtMajorGroupID.Text); 
            itm.SubItems.Add(txtProdGroupName.Text);
            itm.SubItems.Add(txtProdCompName.Text);
            itm.SubItems.Add(txtQuantity.Text);
            itm.SubItems.Add(txtQuantity.Text);
            itm.SubItems.Add(txtStoreLocation.Text); 
            itm.SubItems.Add(txtStock.Text);            
            lvItemList.Items.Add(itm);
            
        }
        private void LoadListTRDetails(string trid)
        {
            long Slno = 1;

            lvItemList.Items.Clear();

            List<TransferRequisition> opurchasereq;

            if (trid.Length != 0)
            {
                opurchasereq = invSr.GetTRDetails(trid).ToList();
            }
            else
            {
                return;
            }
            foreach (TransferRequisition opr in opurchasereq)
            {
                ListViewItem itm = new ListViewItem(Slno.ToString());
                itm.SubItems.Add(opr.ItemMaster.ID);
                itm.SubItems.Add(opr.ItemMaster.Name);
                itm.SubItems.Add(opr.ItemMaster.PacketType.ID);
                itm.SubItems.Add(opr.ItemMaster.Units.ID);
                itm.SubItems.Add(opr.ItemMaster.GroupDetails.ID);
                itm.SubItems.Add(opr.ItemMaster.Company.ID);
                itm.SubItems.Add(opr.ItemMaster.BrandSetup.ID);
                itm.SubItems.Add(opr.ItemMaster.ModelSetup.ID);
                itm.SubItems.Add(opr.ItemMaster.StoreType.strTypeID);
                itm.SubItems.Add(opr.ItemMaster.Majorgroup.MajorgrpID);
                itm.SubItems.Add(opr.ItemMaster.GroupDetails.Name);
                itm.SubItems.Add(opr.ItemMaster.Company.Name);
                itm.SubItems.Add(opr.TrQty.ToString());
                itm.SubItems.Add(opr.TrrQty.ToString());
                itm.SubItems.Add(opr.Warehouse.TypeName);
                itm.SubItems.Add(opr.StockQty.ToString());
                Slno = Slno + 1;
                lvItemList.Items.Add(itm);
            }
        }
        private Boolean IsProductDuplicate(ListView vw, string key1)
        {
            foreach (ListViewItem itm in vw.Items)
            {
                if (itm.SubItems[1].Text == key1)
                {

                    return true;
                }

            }
            return false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtProductionID", "txtProductionName", "txtQuantity" };
            Control control = Utility.ReqFieldValidator(this, vf);


            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                txtProductionID.Select();
                return;
            }
            if (float.Parse(txtQuantity.Text) > float.Parse(txtStock.Text))
            {
                MessageBox.Show("ReqQty can not be more than StockQty");
                txtQuantity.Select();
                return;
            }
            if (IsProductDuplicate(lvItemList, txtProductionID.Text))
            {                
                foreach (ListViewItem itm in lvItemList.Items)
                {
                    
                    if (itm.SubItems[1].Text == txtProductionID.Text)
                    {
                        itm.SubItems[13].Text = txtQuantity.Text;
                        txtProductionID.Select();
                    }

                }
                return;
            }
            LoadListView();
            txtProductionID.Text = string.Empty;
            txtProductionName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtProductionID.Select();
            
        }

        private void txtProductionName_TextChanged(object sender, EventArgs e)
        {
            txtQuantity.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtRequisitionBy", "txtSupplier", "txtSupplierName" };
            Control control = Utility.ReqFieldValidator(this, vf);
                        
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(lvItemList.Items.Count == 0)
            {
                MessageBox.Show("Please select some drugs");
                return;
            }
            if (cboStoreLocation.SelectedValue.ToString() == cboTransferStore.SelectedValue.ToString())
            {
                MessageBox.Show("Transfer Pharmacy can not be same as From Pharmcy");
                return;
            }
         
            //if (cboPharmacy.SelectedIndex == 0)
            //{
            //    MessageBox.Show("--Please Select Pharmacy--");
            //    return;
            //}
            //if (phrSr.VarifyPurchaseReqNo(txtTRID.Text) > 0)
            //{
            //    MessageBox.Show("This Requisition is already exist");
            //    return;
            //}
            if (txtTRID.Text != string.Empty)
            {
                MessageBox.Show("Please clear Requisition No");
                return;
            }            
                try
                {
                    TransferRequisition oreq = this.populateRequisition();
                    string i = invSr.SaveTransferRequisition(oreq);
                    if (i == "0")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTRID.Text = i;
                        //PrintReport(i);
                        btnSave.Enabled = false;
                        lvItemList.Items.Clear();
                        btnNew.PerformClick();
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
        private TransferRequisition populateRequisition()
        {

            TransferRequisition oreq = new TransferRequisition();
           
           
            oreq.RequisitionDate = DateTime.Now;
           
            oreq.Remarks = txtRemarks.Text;
           

            Department odept = new Department();
            odept.DepartmentID = txtDepartment.Text;
            oreq.Department = odept;

            DepartmentUnit odeptunit = new DepartmentUnit();
            odeptunit.UnitId = txtUnit.Text;
            oreq.DepartmentUnit = odeptunit;

            Warehouse owh = new Warehouse();
            owh.TypeID = cboStoreLocation.SelectedValue.ToString();
            owh.ToTypeID = cboTransferStore.SelectedValue.ToString();
            oreq.Warehouse = owh;
            

            string trString = "";
            foreach (ListViewItem itemRow in lvItemList.Items)
            {
                trString += itemRow.SubItems[1].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[5].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[7].Text + "," + itemRow.SubItems[8].Text + "," + itemRow.SubItems[9].Text + "," + itemRow.SubItems[10].Text + "," + itemRow.SubItems[13].Text + "," + itemRow.SubItems[13].Text;
                trString += ";";
            }

            oreq.TrDetails = trString;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oreq.EntryParameter = ep;

            return oreq;
        }
        private void PrintReport(string prid)
        {
            //frmReportViewer ofrmreportviewer = new frmReportViewer();
            //ofrmreportviewer.selector = ViewerSelector.PRReport;
            //ofrmreportviewer.PRID = prid;
            //ofrmreportviewer.ReportTitle = "PR Report";
            //ofrmreportviewer.ViewReport();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           
            txtDepartment.Text = Utility.UserDepartment;
            txtUnit.Text = Utility.UserUnitTitle;
            lvItemList.Items.Clear();
            txtTRID.Text = string.Empty;
            txtProductionID.Text = string.Empty;
            txtProductionName.Text = string.Empty;
            txtQuantity.Text = string.Empty;          
            txtRemarks.Text = string.Empty;
            btnSave.Enabled = true;
        }

       
        private void txtProductionID_KeyDown_1(object sender, KeyEventArgs e)
        {
            int number2;
          
           
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtProductionID.Text, out number2))
                {
                    txtQuantity.Select();
                }
                else
                {
                    populateDataToGridDrug(dgvProduction, txtProductionID.Text,cboStoreLocation.SelectedValue.ToString());
                    dgvProduction.Focus();
                }
                if (dgvProduction.Rows.Count == 0)
                {
                    dgvProduction.Visible = false;
                    txtProductionID.Select();
                    txtProductionName.Text = string.Empty;
                    txtQuantity.Text = string.Empty;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (txtProductionID.Text.Length == 0)
                {
                    MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                    return;
                }
                populateDataToGridDrug(dgvProduction, txtProductionID.Text, cboStoreLocation.SelectedValue.ToString());
                dgvProduction.Focus();
                //if (dgvProduction.RowCount == 0)
                //{
                //    txtProductionID.Text = "";
                //    return;
                //}
            }
        }

        private void btnCloseclk_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem lvitem in lvItemList.SelectedItems)
            {
                lvItemList.Items.Remove(lvitem);
            }
        }

       

        private void smartLabel5_Click(object sender, EventArgs e)
        {

        }
       
       

       

        private void pnlMain_Click(object sender, EventArgs e)
        {
            //dgvSupplierList.Visible = false;
            dgvProduction.Visible = false;
        }

        private void smartLabel2_Click(object sender, EventArgs e)
        {

        }
       
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void txtProductionID_TextChanged(object sender, EventArgs e)
        {
            if(txtProductionID.Text == "")
            {
                txtProductionName.Text = string.Empty;
                txtGenericName.Text = string.Empty;
                txtQuantity.Text = string.Empty;
            }
        }

        private void lvItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvItemList.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvItemList.SelectedItems[0];
                txtProductionID.Text = itm.SubItems[1].Text;
                txtProductionName.Text = itm.SubItems[2].Text;
                txtGenericName.Text = itm.SubItems[7].Text;
                txtQuantity.Text = itm.SubItems[13].Text;                
            }
        }

        private void cboDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    cboUnit.Focus();
            //}
        }

        private void cboPharmacy_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //{
                //cboDrugCompany.Focus();
            //}
        }

        private void cboDrugCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                
            }
        }
        private void cboUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboStoreLocation.Focus();
            }
        }
        private void AddDataToReqList(List<TransferRequisition> tests, object sender, EventArgs e)
        {


            try
            {

                foreach (TransferRequisition ts in tests)
                {
                    txtTRID.Text = ts.ID;
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
        private void SearchRequisition()
        {

            if (txtTRID.Text == "")
            {
                frmTransferReqNumList opur = new frmTransferReqNumList();
                opur.onAddAllButtonClicked = new frmTransferReqNumList.AddAllClick(AddDataToReqList);
                opur.ShowDialog();
                LoadListTRDetails(txtTRID.Text);
                cboStoreLocation.DataBindings.Clear();
                cboTransferStore.DataBindings.Clear();
                cboStoreLocation.DataBindings.Add("SelectedValue", invSr.GetTRDetails(txtTRID.Text).ToList(), "Warehouse.TypeID");
                cboTransferStore.DataBindings.Add("SelectedValue", invSr.GetTRDetails(txtTRID.Text).ToList(), "Warehouse.ToTypeID");
                txtTRID.Select();
            }
        }
            
          
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRequisition();
            
        }

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    txtRequisitionBy.Focus();
            //}
        }
      
        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintReport(txtTRID.Text);
        }

        private void txtGenericName_KeyDown(object sender, KeyEventArgs e)
        {
            int number2;
     
           
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtGenericName.Text, out number2))
                {
                    txtQuantity.Select();
                }
                else
                {

                    populateDataToGridDrugByGroup(dgvProduction, txtGenericName.Text);
                    dgvProduction.Focus();
                }
                if (dgvProduction.Rows.Count == 0)
                {
                    dgvProduction.Visible = false;
                    txtGenericName.Select();
                    txtProductionName.Text = string.Empty;
                    txtQuantity.Text = string.Empty;
                    //txtURate.Text = string.Empty;
                    //txtvat.Text = string.Empty;
                    //txtDiscount.Text = string.Empty;
                    //txtAmountSummary.Text = string.Empty;
                    //txtQuatityCompareText.Text = string.Empty;
                }
            }
            if (e.KeyCode == Keys.Down)
            {

                if (txtGenericName.Text.Length == 0)
                {
                    MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                    return;
                }
                populateDataToGridDrugByGroup(dgvProduction, txtGenericName.Text);
                dgvProduction.Focus();
            }
        }

        private void cboPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvItemList.Items.Clear();
        }

        private void smartLabel18_Click(object sender, EventArgs e)
        {

        }

        private void txtPRID_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
