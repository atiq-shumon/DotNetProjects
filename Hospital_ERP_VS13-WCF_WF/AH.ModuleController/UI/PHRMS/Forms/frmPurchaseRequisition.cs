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
using AH.ModuleController.PHRMSSR;
using AH.ModuleController.UI.PHRMS.Reports.Viewer;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmPurchaseRequisition : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmPurchaseRequisition()
        {
            InitializeComponent();
        }
   
        private void frmPurchaseRequisition_Load(object sender, EventArgs e)
        {
            
            cboDepartment.Select();
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(phrSr.GetDepartmentsetupDic(null, Utility.UserDepartmentGroupID), null);

            cboCostCategoey.DisplayMember = "CategoryName";
            cboCostCategoey.ValueMember = "CategoryID";
            cboCostCategoey.DataSource = phrSr.GetCostcategory("CostcategoryTreeview", "", "").ToList();

            cboPharmacy.DisplayMember = "WhName";
            cboPharmacy.ValueMember = "Whid";
            cboPharmacy.DataSource = new BindingSource(phrSr.GetWhTypeforCentral("0061", "1"), null);

            cboDrugCompany.DisplayMember = "name";
            cboDrugCompany.ValueMember = "id";
            cboDrugCompany.DataSource = new BindingSource(phrSr.GetDrugCompanyDictionary(), null);

            txtRequisitionBy.Text = Utility.UserId;
            cboDepartment.Text = Utility.UserDepartment;
            cboUnit.Text = Utility.UserUnitTitle;

            FormatDataGridView(dgvSupplierList);
            dgvSupplierList.Visible = false;
 
            FormatGridProd(dgvProduction);
            dgvProduction.Visible = false;
            FormatGrid();
            cboDepartment.SelectedIndexChanged += new EventHandler(cboDepartment_SelectedIndexChanged);
        }

        private void txtRequisitionBy_Leave(object sender, EventArgs e)
        {
            

            lblInfo.Visible = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = phrSr.GetEmpMaster(txtRequisitionBy.Text);
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
                    
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRequisitionBy.Select();
                }
            }
        }

        private void txtRequisitionBy_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "";
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas = phrSr.GetEmpMaster(txtRequisitionBy.Text);
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
                        txtProductionID.Focus();
                    }

                    else
                    {
                        MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtProductionID.Focus();
                    }
                }
            }
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

        private void FormatGridProd(DataGridView dtv)
        {
            
            //dtv.ColumnHeadersVisible = false;
            dtv.Height = 300;
            dtv.Width = 660;
            //dtv.Location = new Point(10,20);
            dtv.AutoGenerateColumns = false;
            dtv.Location = new Point(lvItemList.Location.X, lvItemList.Location.Y);

         
            DataGridViewTextBoxColumn colDrugId = new DataGridViewTextBoxColumn();
            colDrugId.Name = "DRUGID";
            colDrugId.DataPropertyName = "DRUGID";
            colDrugId.Width = 0;
            colDrugId.Visible = false;
            dtv.Columns.Add(colDrugId);
            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn();
            colDrugTitle.Name = "Brand Name";
            colDrugTitle.DataPropertyName = "DRUGNAME";
            colDrugTitle.Width = 200;
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
            colCompanyTitle.Width = 150;
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
            colGroupTitle.Width = 150;
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
            colPackName.Width = 80;
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
            colUnitName.Width = 50;
            dtv.Columns.Add(colUnitName);

            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 0;
            colUrate.Visible = false;
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colvat = new DataGridViewTextBoxColumn();
            colvat.Name = "Vat";
            colvat.DataPropertyName = "Vat";
            colvat.Width = 0;
            colvat.Visible = false;
            dtv.Columns.Add(colvat);

            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Discount";
            colDiscount.DataPropertyName = "Discount";
            colDiscount.Width = 0;
            colDiscount.Visible = false;
            dtv.Columns.Add(colDiscount);

            DataGridViewTextBoxColumn colRackrate = new DataGridViewTextBoxColumn();
            colRackrate.Name = "Rackrate";
            colRackrate.DataPropertyName = "Rackrate";
            colRackrate.Width = 0;
            colRackrate.Visible = false;
            dtv.Columns.Add(colRackrate);

            DataGridViewTextBoxColumn colSlrate = new DataGridViewTextBoxColumn();
            colSlrate.Name = "SlRate";
            colSlrate.DataPropertyName = "SlRate";
            colSlrate.Width = 0;
            colSlrate.Visible = false;
            dtv.Columns.Add(colSlrate);

            DataGridViewTextBoxColumn colstock = new DataGridViewTextBoxColumn();
            colstock.Name = "Stock";
            colstock.DataPropertyName = "Stock";
            colstock.Width = 0;
            colstock.Visible = false;
            dtv.Columns.Add(colstock);

            
        }
        private void populateDataToGridDrug(DataGridView dtv, string drugname,string company)
        {
            List<DrugMaster> oMedicines = new List<DrugMaster>();

            dgvProduction.Visible = true;
            List<DrugMaster> list = new List<DrugMaster>();
            list.AddRange(phrSr.GetDrugMasterListCompanyWise(drugname,company).ToList());
            if (list.Count > 0)
            {
                dgvProduction.DataSource = list.Select(data => new
                {
                    
                    DRUGID = data.ID,
                    DRUGNAME = data.Name,
                    COMPANYID = data.DrugCompany.ID,
                    COMPANYNAME = data.DrugCompany.Name,
                    GROUPID = data.DrugGroup.ID,
                    GROUPNAME = data.DrugGroup.Name,
                    UNITID = data.DrugUnit.ID,
                    UNITNAME = data.DrugUnit.Name,
                    TYPEID = data.DrugPackType.ID,
                    PACKNAME = data.DrugPackType.Name,
                    Rate = data.Urate,
                    Vat = data.VAT,
                    Discount = data.Discount,
                    Rackrate = data.Rackrate,
                    SlRate = data.Slrate,
                    Stock = data.StockQty
                }).ToList();
                this.dgvProduction.Focus();
            }
            else
            {
                dgvProduction.Visible = false;
                MessageBox.Show("There is no item in this company");
                return;
            }
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
               
               
                txtProductionID.Text = dtv["DRUGID", currentRow + 1].Value.ToString();
                txtProductionName.Text = dtv["Brand Name", currentRow + 1].Value.ToString();
                txtProductionPacketID.Text = dtv["TYPEID", currentRow + 1].Value.ToString();
                txtProductionUnitID.Text = dtv["UNITID", currentRow + 1].Value.ToString();
                txtProductionGroupID.Text = dtv["GROUPID", currentRow + 1].Value.ToString();
                txtProdGroupName.Text = dtv["Generic Name", currentRow + 1].Value.ToString();
                txtProductionCompanyID.Text = dtv["COMPANYID", currentRow + 1].Value.ToString();
                txtProdCompName.Text = dtv["Company", currentRow + 1].Value.ToString();
                //txtProdUnitName.Text = dtv["Unit", currentRow + 1].Value.ToString();
                //txtProdPackName.Text = dtv["Unit Pack", currentRow + 1].Value.ToString();
                labelRate.Text = dtv["Rate", currentRow + 1].Value.ToString();
                labelVat.Text = dtv["Vat", currentRow + 1].Value.ToString();
                labelDiscount.Text = dtv["Discount", currentRow + 1].Value.ToString();
                labelRackrate.Text = dtv["Rackrate", currentRow + 1].Value.ToString();
                labelSlrate.Text = dtv["SlRate", currentRow + 1].Value.ToString();
                txtStock.Text = dtv["Stock", currentRow + 1].Value.ToString();
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
                
                txtProductionID.Text = row.Cells["DRUGID"].Value.ToString();
                txtProductionName.Text = row.Cells["Brand Name"].Value.ToString();
                txtProductionCompanyID.Text = row.Cells["COMPANYID"].Value.ToString();
                txtProdCompName.Text = row.Cells["Company"].Value.ToString();
                txtProductionGroupID.Text = row.Cells["GROUPID"].Value.ToString();
                txtProdGroupName.Text = row.Cells["Generic Name"].Value.ToString();
                txtProductionUnitID.Text = row.Cells["UNITID"].Value.ToString();
                txtProductionPacketID.Text = row.Cells["TYPEID"].Value.ToString();
                labelRate.Text = row.Cells["Rate"].Value.ToString();
                labelVat.Text = row.Cells["Vat"].Value.ToString();
                labelDiscount.Text = row.Cells["Discount"].Value.ToString();
                labelRackrate.Text = row.Cells["Rackrate"].Value.ToString();
                labelSlrate.Text = row.Cells["SlRate"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                dgvProduction.Visible = false;

                txtProductionID.Focus();

            }
        }
        private void FormatGrid()
        {
            lvItemList.Columns.Add("Slno", 50, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Drug ID", 90, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Brand Name", 250, HorizontalAlignment.Left);
            lvItemList.Columns.Add("PackageType", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Unit", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Group", 0, HorizontalAlignment.Left);
            //lvItemList.Columns.Add("Group", 200, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Item Company", 0, HorizontalAlignment.Left);
            //lvItemList.Columns.Add("Company", 200, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Generic Name", 350, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Company", 150, HorizontalAlignment.Left);
            lvItemList.Columns.Add("ReqQty", 80, HorizontalAlignment.Left);
            lvItemList.Columns.Add("RemQty", 0, HorizontalAlignment.Left);
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
            itm.SubItems.Add(txtProdGroupName.Text);
            itm.SubItems.Add(txtProdCompName.Text);
            itm.SubItems.Add(txtQuantity.Text);
            itm.SubItems.Add(txtQuantity.Text);
            itm.SubItems.Add(txtStock.Text);
            
            lvItemList.Items.Add(itm);
            
        }
        private void LoadListPRDetails(string prid)
        {
            long  Slno = 1;
            
            lvItemList.Items.Clear();

            List<PurchaseRequisition> opurchasereq;

            if(prid.Length != 0)
            {
                opurchasereq = phrSr.GetPRSearchDetails(prid).ToList();
            }
            else
            {
                return;
            }
            foreach(PurchaseRequisition opr in opurchasereq)
            {
                ListViewItem itm = new ListViewItem(Slno.ToString());
                itm.SubItems.Add(opr.DrugMaster.ID);               
                itm.SubItems.Add(opr.DrugMaster.Name);
                itm.SubItems.Add(opr.DrugMaster.DrugPackType.ID);
                itm.SubItems.Add(opr.DrugMaster.DrugUnit.ID);
                itm.SubItems.Add(opr.DrugMaster.DrugGroup.ID);
                itm.SubItems.Add(opr.DrugMaster.DrugCompany.ID);
                itm.SubItems.Add(opr.DrugMaster.DrugGroup.Name);
                itm.SubItems.Add(opr.DrugMaster.DrugCompany.Name);
                itm.SubItems.Add(opr.RequisitionQty.ToString());
                itm.SubItems.Add(opr.RemainingQty.ToString());
                itm.SubItems.Add(opr.DrugMaster.StockQty.ToString());
                Slno = Slno + 1;
                lvItemList.Items.Add(itm);
            }
        }
        private void FormatDataGridView(DataGridView dtv)
        {
            dtv.Height = 250;
            dtv.Width = 265;
            dtv.AutoGenerateColumns = false;
            dtv.Location = new Point(txtSupplierName.Location.X, txtSupplierName.Location.Y);

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "ID";
            ID.DataPropertyName = "ID";
            ID.Width = 0;
            ID.Visible = false;
            dtv.Columns.Add(ID);

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.Name = "Name";
            Name.DataPropertyName = "Name";
            Name.Width = 250;
            dtv.Columns.Add(Name);

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

            if (Utility.IsDuplicateFoundInList(lvItemList, 1, txtProductionID.Text))
            {
                //{
                //    MessageBox.Show("Already Item Exist");
                //    txtProductionID.Select();
                //    return;
                //}
                foreach (ListViewItem itm in lvItemList.Items)
                {
                    if (itm.SubItems[1].Text == txtProductionID.Text)
                    {
                        itm.SubItems[9].Text = txtQuantity.Text;
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
            //if (cboDepartment.SelectedIndex == 0)
            //{
            //    MessageBox.Show("--Please Select Department--");
            //    return;
            //}

            //if (cboUnit.SelectedIndex == 0)
            //{
            //    MessageBox.Show("--Please Select Unit--");
            //    return;
            //}
            //if (cboPharmacy.SelectedIndex == 0)
            //{
            //    MessageBox.Show("--Please Select Pharmacy--");
            //    return;
            //}
            if (phrSr.VarifyPurchaseReqNo(txtPRID.Text) > 0)
            {
                MessageBox.Show("This Requisition is already exist");
                return;
            }
            if (txtPRID.Text != string.Empty)
            {
                MessageBox.Show("Please clear Requisition No");
                return;
            }            
                try
                {
                    PurchaseRequisition oreq = this.populateRequisition();
                    string i = phrSr.SavePurchaseRequisition(oreq);
                    if (i == "0")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPRID.Text = i;
                        PrintReport(i);
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
        private PurchaseRequisition populateRequisition()
        {
            
            PurchaseRequisition oreq = new PurchaseRequisition();
            oreq.TransactionType = "PR";
            oreq.Priority = "1";
            oreq.DeliveryDate = DateTime.Parse(txtDeliveryDate.Text);
            oreq.RequisitionDate = DateTime.Now;
            oreq.RequisitionType = "P";
            oreq.RequisitionBy = txtRequisitionBy.Text;
            oreq.Remarks = txtRemarks.Text;
            oreq.DemandRequisition = "DR01125";

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            oreq.CostCategoryTreeview = ocostcenter;

            Department odept = new Department();
            odept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oreq.Department = odept;

            DepartmentUnit odeptunit = new DepartmentUnit();
            odeptunit.UnitId = cboUnit.SelectedValue.ToString();
            oreq.DepartmentUnit = odeptunit;

            Warehouse ophr = new Warehouse();
            ophr.TypeID = cboPharmacy.SelectedValue.ToString();
            oreq.Warehouse = ophr;

            Supplier osupplier = new Supplier();
            osupplier.ID = txtSupplier.Text;
            oreq.Supplier = osupplier;



            string drString = "";
            foreach (ListViewItem itemRow in lvItemList.Items)
            {
                drString += itemRow.SubItems[1].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[5].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[9].Text + "," + itemRow.SubItems[9].Text;
                drString += ";";
            }

            oreq.PrDetails = drString;

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
            frmReportViewer ofrmreportviewer = new frmReportViewer();
            ofrmreportviewer.selector = ViewerSelector.PRReport;
            ofrmreportviewer.PRID = prid;
            ofrmreportviewer.ReportTitle = "PR Report";
            ofrmreportviewer.ViewReport();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtRequisitionBy.Text = Utility.UserId;
            cboDepartment.Text = Utility.UserDepartment;
            cboUnit.Text = Utility.UserUnitTitle;
            lvItemList.Items.Clear();
            txtPRID.Text = string.Empty;
            txtProductionID.Text = string.Empty;
            txtProductionName.Text = string.Empty;
            txtQuantity.Text = string.Empty;          
            txtRemarks.Text = string.Empty;
            btnSave.Enabled = true;
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != null )
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(phrSr.GetDeptUnitDic(Utility.UserDepartmentGroupID, cboDepartment.SelectedValue.ToString())), null);
            }
            //cboUnit.Focus();
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
                    populateDataToGridDrug(dgvProduction, txtProductionID.Text,cboDrugCompany.SelectedValue.ToString());
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
                populateDataToGridDrug(dgvProduction, txtProductionID.Text,cboDrugCompany.SelectedValue.ToString());
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

        private void cboCostCategoey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCostCategoey.SelectedValue != null)
            {
                
                //CostCenterID,CostcenterName  
                cboCostCenter.DisplayMember = "CostcenterName";
                cboCostCenter.ValueMember = "CostCenterID";
                cboCostCenter.DataSource = phrSr.GetCostcenter("CostcenterTreeview", cboCostCategoey.SelectedValue.ToString(), "").ToList();
            }
        }

        private void smartLabel5_Click(object sender, EventArgs e)
        {

        }
        private void populateDatatoGrid(DataGridView dtv, string supname)
        {

            List<Supplier> list = new List<Supplier>();
            dgvSupplierList.Visible = true;

            list.AddRange(phrSr.GetSupplierListed(supname).ToList());
            dtv.DataSource = list.Select(data => new { data.ID, data.Name }).ToList();

        }
        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int outParse;
                if (int.TryParse(txtSupplier.Text, out outParse))
                {

                    txtRemarks.Select();
                }
                else
                {
                    populateDatatoGrid(dgvSupplierList, txtSupplier.Text);
                    this.dgvSupplierList.Focus();
                }
                if (dgvSupplierList.Rows.Count == 0)
                {
                    dgvSupplierList.Visible = false;
                    txtSupplier.Select();
                }
            }
            if (e.KeyCode == Keys.Down)
            {

                if (txtSupplier.Text.Length == 0)
                {
                    MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                    return;
                }
                populateDatatoGrid(dgvSupplierList, txtSupplier.Text);
                dgvSupplierList.Focus();
                if (dgvSupplierList.RowCount == 0)
                {
                    txtSupplier.Text = "";
                    return;
                }

            }
        }

        private void setvaluesfromGrid(DataGridView dtv, object sender)
        {



            if (dtv.Rows.Count > 0)
            {
                int currentRow = dtv.CurrentRow.Index;
                currentRow--;

                txtSupplier.Text = dtv["ID", currentRow + 1].Value.ToString();
                txtSupplierName.Text = dtv["Name", currentRow + 1].Value.ToString();
                dtv.Visible = false;
                txtSupplier.Focus();

            }
            else
            {
                dtv.Visible = false;
                txtSupplier.Focus();
            }

        }

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSupplierList.Rows[e.RowIndex];

                txtSupplier.Text = row.Cells["ID"].Value.ToString();
                txtSupplierName.Text = row.Cells["Name"].Value.ToString();
                dgvSupplierList.Visible = false;
                txtSupplier.Focus();
            }
        }

       
        private void dgvSupplierList_KeyPress(object sender, KeyPressEventArgs e)
        {
            setvaluesfromGrid(dgvSupplierList,sender);
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            txtSupplierName.Text = string.Empty;
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            dgvSupplierList.Visible = false;
            dgvProduction.Visible = false;
        }

        private void smartLabel2_Click(object sender, EventArgs e)
        {

        }
        private void UserID()
        {
            txtRequisitionBy.Text = Utility.UserId;
            lblInfo.Visible = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = phrSr.GetEmpMaster(txtRequisitionBy.Text);
            lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
        }
        private void txtRequisitionBy_TextChanged(object sender, EventArgs e)
        {
            UserID();
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
                txtQuantity.Text = itm.SubItems[9].Text;
                
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
            if (e.KeyChar == (char)Keys.Return)
            {
                cboDrugCompany.Focus();
            }
        }

        private void cboDrugCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtSupplier.Focus();
            }
        }

       

        private void cboUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboPharmacy.Focus();
            }
        }
        private void AddDataToReqList(List<PurchaseRequisition> tests, object sender, EventArgs e)
        {


            try
            {

                foreach (PurchaseRequisition ts in tests)
                {

                    txtPRID.Text = ts.ID;


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
            lvItemList.Items.Clear();
            int vrfy = phrSr.VarifyPurchaseReqNo(txtPRID.Text);
            if (txtPRID.Text == "")
            {
                frmPurchaseRequisitionList opur = new frmPurchaseRequisitionList();
                opur.onAddAllButtonClicked = new frmPurchaseRequisitionList.AddAllClick(AddDataToReqList);
                opur.ShowDialog();
                LoadListPRDetails(txtPRID.Text);
                cboPharmacy.DataBindings.Clear();
                cboDrugCompany.DataBindings.Clear();
                txtSupplier.DataBindings.Clear();
                txtSupplierName.DataBindings.Clear();
                cboDepartment.DataBindings.Clear();
                cboUnit.DataBindings.Clear();
                cboDepartment.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Department.DepartmentID");
                cboUnit.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "DepartmentUnit.UnitId");
                cboPharmacy.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Warehouse.TypeID");
                cboDrugCompany.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "DrugMaster.DrugCompany.ID");
                txtSupplier.DataBindings.Add("Text", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Supplier.ID");
                txtSupplierName.DataBindings.Add("Text", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Supplier.Name");
                txtPRID.Select();
            }
            else if (vrfy == 0)
            {
                MessageBox.Show("Please put valid PR No");
                txtPRID.Select();
                return;

            }
            else
            {
                
                LoadListPRDetails(txtPRID.Text);               
                cboPharmacy.DataBindings.Clear();
                cboDrugCompany.DataBindings.Clear();
                txtSupplier.DataBindings.Clear();
                txtSupplierName.DataBindings.Clear();               
                cboDepartment.DataBindings.Clear();
                cboUnit.DataBindings.Clear();               
                cboDepartment.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Department.DepartmentID");
                cboUnit.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "DepartmentUnit.UnitId");
                cboPharmacy.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Warehouse.TypeID");
                cboDrugCompany.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "DrugMaster.DrugCompany.ID");
                txtSupplier.DataBindings.Add("Text", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Supplier.ID");
                txtSupplierName.DataBindings.Add("Text", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Supplier.Name");
                
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRequisition();
            
        }

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRequisitionBy.Focus();
            }
        }
      
        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintReport(txtPRID.Text);
        }

        private void btnTR_Click(object sender, EventArgs e)
        {
            //frmTransferRequisition otr = new frmTransferRequisition();
            //otr.ShowDialog();
        }

        private void cboPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvItemList.Items.Clear();
        }

    }
}
