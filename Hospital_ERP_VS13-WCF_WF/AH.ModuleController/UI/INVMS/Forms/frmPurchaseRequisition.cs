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
using AH.ModuleController.UI.InvMS.Reports.Viewer;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmPurchaseRequisition : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        List<ItemMaster> list;

        public frmPurchaseRequisition()
        {
            InitializeComponent();
        }
        private void FormatData(DataGridView dtv)
        {
            dtv.Height = 300;
            dtv.Width = 840;
            
            dtv.AutoGenerateColumns = false;
            dtv.Location = new Point(grpPRDetails.Location.X, grpPRDetails.Location.Y);

            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 70;
            itemid.Visible = true;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Item";
            itemname.DataPropertyName = "Item";
            itemname.Width = 200;
            itemname.Visible = true;
            dtv.Columns.Add(itemname);
            DataGridViewTextBoxColumn colstock = new DataGridViewTextBoxColumn();
            colstock.Name = "StockQty";
            colstock.DataPropertyName = "StockQty";
            colstock.Width = 150;
            colstock.Visible = true;
            dtv.Columns.Add(colstock);
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
            dtv.Columns["StockQty"].DefaultCellStyle.ForeColor = Color.Red;
            dtv.Columns["StockQty"].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Bold);

        }

        private void FormatDataForPR(DataGridView dtv)
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
            itemname.Width = 300;
            itemname.Visible = true;
            itemname.ReadOnly = true;
            dtv.Columns.Add(itemname);
            DataGridViewTextBoxColumn colstock = new DataGridViewTextBoxColumn();
            colstock.Name = "StockQty";
            colstock.DataPropertyName = "StockQty";
            colstock.Width = 60;
            colstock.Visible = true;
            colstock.ReadOnly = true;
            dtv.Columns.Add(colstock);
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
            DataGridViewTextBoxColumn groupname = new DataGridViewTextBoxColumn();
            groupname.Name = "Group";
            groupname.DataPropertyName = "Group";
            groupname.Width = 250;
            groupname.Visible = true;
            groupname.ReadOnly = true;
            dtv.Columns.Add(groupname);

            DataGridViewTextBoxColumn compname = new DataGridViewTextBoxColumn();
            compname.Name = "Company";
            compname.DataPropertyName = "Company";
            compname.Width = 250;
            compname.Visible = true;
            compname.ReadOnly = true;
            dtv.Columns.Add(compname);


            DataGridViewTextBoxColumn brandname = new DataGridViewTextBoxColumn();
            brandname.Name = "Brand";
            brandname.DataPropertyName = "Brand";
            brandname.Width = 120;
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

            DataGridViewTextBoxColumn reqquantity = new DataGridViewTextBoxColumn();
            reqquantity.Name = "ReqQty";
            reqquantity.DataPropertyName = "ReqQuantity";
            reqquantity.Width = 70;
            reqquantity.Visible = true;
            reqquantity.ReadOnly = false;
            dtv.Columns.Add(reqquantity);

            DataGridViewTextBoxColumn coldept = new DataGridViewTextBoxColumn();
            coldept.Name = "Dept";
            coldept.DataPropertyName = "Dept";
            coldept.Width = 0;
            coldept.Visible = false;
            coldept.ReadOnly = false;
            dtv.Columns.Add(coldept);

            DataGridViewTextBoxColumn colunit = new DataGridViewTextBoxColumn();
            colunit.Name = "Unit";
            colunit.DataPropertyName = "unit";
            colunit.Width = 0;
            colunit.Visible = false;
            colunit.ReadOnly = false;
            dtv.Columns.Add(colunit);

            DataGridViewTextBoxColumn coldrno = new DataGridViewTextBoxColumn();
            coldrno.Name = "DR No";
            coldrno.DataPropertyName = "DR No";
            coldrno.Width = 100;
            coldrno.Visible = true;
            coldrno.ReadOnly = true;
            dtv.Columns.Add(coldrno);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.Width = 60;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dtv.Columns.Add(Deletelink);

            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.HeaderText = "";
            //checkBoxColumn.Width = 30;
            //checkBoxColumn.Visible = true;
            //checkBoxColumn.Name = "checkBoxColumn";
            //dtv.Columns.Insert(16, checkBoxColumn);

           
        }
        private void populateDataToGrid(DataGridView dtv, string itemname, string storetype)
        {


            dgvItem.Visible = true;
            list = new List<ItemMaster>();
            list.AddRange(invSr.GetItemsByName(itemname, storetype).ToList());
            if (list.Count > 0)
            {
                dgvItem.DataSource = list.Select(data => new
                {
                    ItemID = data.ID,
                    Item = data.Name,
                    StockQty = data.StockQty,
                    TYPEID = data.PacketType.ID,
                    UNITID = data.Units.ID,
                    GROUPID = data.GroupDetails.ID,
                    COMPANYID = data.Company.ID,
                    BrandID = data.BrandSetup.ID,
                    ModelID = data.ModelSetup.ID,
                    StoreTypeID = data.StoreType.strTypeID,
                    MajorGroup = data.Majorgroup.MajorgrpID,
                    GROUP = data.GroupDetails.Name,
                    COMPANY = data.Company.Name,
                    Type = data.PacketType.Name,
                    Unit = data.Units.Name,
                    Brand = data.BrandSetup.Name,
                    Model = data.ModelSetup.Name,
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
        private void SearchListView(IEnumerable<ItemMaster> tests, int intcheck, string searchString = "")
        {
            dgvItem.Visible = true;
            short index = 0;
            IEnumerable<ItemMaster> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                if (intcheck == 1)
                {
                    query = (from list in tests
                             where list.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select list);
                }
                else
                {
                    query = (from list in tests
                             where list.ID.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select list);
                }
            }

            dgvItem.Rows.Clear();
            int i = query.Count();
            int j = 0;
            if (i > 0)
            {
                dgvItem.Rows.Add(i);
                foreach (ItemMaster ldr in query)
                {
                    string[] row = new string[] { 
                                              ldr.ID,                                              
                                              ldr.Name,
                                              ldr.StockQty.ToString(),
                                              ldr.PacketType.ID,
                                              ldr.Units.ID,
                                              ldr.GroupDetails.ID,
                                              ldr.Company.ID,
                                              ldr.BrandSetup.ID,
                                              ldr.ModelSetup.ID,
                                              ldr.StoreType.strTypeID,
                                              ldr.Majorgroup.MajorgrpID,
                                              ldr.GroupDetails.Name,
                                              ldr.Company.Name,
                                              ldr.PacketType.Name,
                                              ldr.Units.Name,
                                              ldr.BrandSetup.Name,
                                              ldr.ModelSetup.Name
                                              };
                    AddRowsToCollection(dgvItem, row, index);
                    index++;
                    j = j + 1;
                }
                txtItemID.Select();
                //dgvItem.AllowUserToAddRows = false;
            }
        }
        private void LoadSerialNo()
        {
            int i = 1;
            foreach (DataGridViewRow row in dgvDRDetails.Rows)
            {
                row.Cells["SNo"].Value = i; 
                i++;
            }
        }
        private void frmPurchaseRequisition_Load(object sender, EventArgs e)
        {
                       
            cboPriority.SelectedIndex = 0;

            txtPRDate.Text = DateTime.Now.ToString();
            
            txtRequisitionBy.Text = Utility.UserId;
            
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(invSr.GetDepartments("D"), null);

            cboUnit.DataSource = null;

            cboStoreLocation.DataSource = null;

            cboStoreType.ValueMember = "strTypeID";
            cboStoreType.DisplayMember = "TypeTitle";
            cboStoreType.DataSource = new BindingSource(invSr.GetStoreType(), null);

            cboStoreLocation.ValueMember = "Whid";
            cboStoreLocation.DisplayMember = "WhName";
            cboStoreLocation.DataSource = new BindingSource(invSr.GetWhTypeforSCM("0062", "1"), null);

            cboCostCategoey.DisplayMember = "CategoryName";
            cboCostCategoey.ValueMember = "CategoryID";
            cboCostCategoey.DataSource = invSr.GetCostcategory("CostcategoryTreeview", "", "").ToList();

            FormatDataForPR(dgvDRDetails);
            FormatDataForPR(dgvPRDetails);
            FormatData(dgvItem);
            dgvItem.Visible = false;
            dgvDRDetails.Columns[15].Visible = false;

            txtQuantity.Text = "0";
                      
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRequisitionBy", "txtPriority", "cboCostCategoey", "cboCostCenter" };
            Control control = Utility.ReqFieldValidator(this, vf);
                        
            if (control != null )
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
          
            if (txtDeliveryDate.Text == "  /  /")
            {
                MessageBox.Show("Delivery Date cannot be Empty");
                txtDeliveryDate.Select();
                return;
            }
          
            if (dgvPRDetails.Rows.Count == 0)
            {
                MessageBox.Show("Please choose item from item list");
                txtItemID.Focus();
                return;
            }

            for (int k = 0; k < dgvPRDetails.Rows.Count;k++ )
            {
                //if (k > 50)
                //{
                //    MessageBox.Show("cc");
                //}
                
                //if (dgvPRDetails.Rows[k].Cells["ItemID"].Value == null || 
                //    dgvPRDetails.Rows[k].Cells["CompanyID"].Value == null || 
                //    dgvPRDetails.Rows[k].Cells["GroupID"].Value == null || 
                //    dgvPRDetails.Rows[k].Cells["UnitID"].Value == null || 
                //    dgvPRDetails.Rows[k].Cells["TypeID"].Value == null ||
                //    dgvPRDetails.Rows[k].Cells["ModelID"].Value == null ||
                //    dgvPRDetails.Rows[k].Cells["BrandID"].Value == null ||
                //    dgvPRDetails.Rows[k].Cells["StoreTypeID"].Value == null ||
                //    dgvPRDetails.Rows[k].Cells["MajorGroup"].Value == null ||
                //    dgvPRDetails.Rows[k].Cells["ReqQty"].Value == null)
                //{
                //    MessageBox.Show("Requisition details value cannot be null");
                //    return ;
                //}
                if (float.Parse(dgvPRDetails.Rows[k].Cells["ReqQty"].Value.ToString()) <= 0)
                {
                    MessageBox.Show("Requisition Quantity can not be zero");
                    return;
                }
            }


                if (invSr.VarifyPRForModify(txtPrId.Text) > 0)
                {
                    MessageBox.Show("This Requisition is already Ordered");
                    return;
                }

                else
                {
                    try
                    {
                        PurchaseRequisition oreq = this.populatePurchaseRequisition();
                        string i = invSr.SavePurchaseRequisition(oreq);
                        if (i == "0")
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPrId.Text = i;
                            PopulateDataToGridForReq(dgvPRDetails, txtPrId.Text);
                            btnSave.Enabled = false;
                            treeviewPurchaseRequisition.Nodes.Clear();
                            List<SCMTree> purchaseRequisitions = invSr.GetDrID().Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
                            Utility.PopulateTreeSCM(treeviewPurchaseRequisition, purchaseRequisitions);
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
        }
        private PurchaseRequisition ModifyPurchaseRequisition()
        {
            PurchaseRequisition oreq = new PurchaseRequisition();
            oreq.ID = txtPrId.Text;

            string alterprString = "";

            foreach (DataGridViewRow dr in dgvPRDetails.Rows)
            {
                alterprString += dr.Cells[0].Value.ToString() + "," + dr.Cells[15].Value.ToString();
                alterprString += ";";
            }
            oreq.AlterPrDetails = alterprString;
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
            ofrmreportviewer.selector = ViewerSelector.PrReport;
            ofrmreportviewer.PRID = prid;
            ofrmreportviewer.ReportTitle = "Purchase Requisition";
            ofrmreportviewer.ViewReport();
        }

        private PurchaseRequisition populatePurchaseRequisition()
        {
            
            PurchaseRequisition oreq = new PurchaseRequisition();
            if (txtPrId.Text != "")
            {
                oreq.ID = txtPrId.Text;
            }
            else
            {
                oreq.ID = "0";
            }
            oreq.TransactionType = "DR";

            if (cboPriority.Text == "Regular")
            {
                oreq.Priority = "R";
            }
            else
            {
                oreq.Priority = "U";
            }          
            oreq.DeliveryDate = DateTime.Parse(txtDeliveryDate.Text);
            oreq.RequisitionDate = DateTime.Parse(txtPRDate.Text);
            oreq.RequisitionType = "D";
            oreq.RequisitionBy = txtRequisitionBy.Text;
            oreq.Remarks = txtRemarks.Text;

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            oreq.CostCategoryTreeview = ocostcenter;

            StoreTypeSCM ostrtype = new StoreTypeSCM();
            ostrtype.strTypeID = cboStoreType.SelectedValue.ToString();
            oreq.StoreType = ostrtype;

            Warehouse ostore = new Warehouse();
            ostore.TypeID = cboStoreLocation.SelectedValue.ToString();
            oreq.Warehouse = ostore;

            string prString = "";
            foreach (DataGridViewRow dr in dgvPRDetails.Rows)
            {
                prString += dr.Cells[1].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[7].Value.ToString() + "," + dr.Cells[8].Value.ToString() + "," + dr.Cells[9].Value.ToString() + "," + dr.Cells[10].Value.ToString() + "," + dr.Cells[11].Value.ToString() + "," + dr.Cells[16].Value.ToString() + "," + dr.Cells[19].Value.ToString() + "," + dr.Cells[17].Value.ToString() + "," + dr.Cells[18].Value.ToString();
                prString += ";";
            }           
            oreq.PrDetails = prString;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oreq.EntryParameter = ep;
            return oreq;
        }
       
        

        private void lvItemList_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void dgvPRDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgvPRDetails.Columns["ReqQty"].Index)
            {
                dgvPRDetails.Rows[e.RowIndex].ErrorText = "";
                float newInteger;

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgvPRDetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (!float.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgvPRDetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }
        }

        private void treeviewPurchaseRequisition_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //txtDrID.Text = treeviewPurchaseRequisition.SelectedNode.Text;
            //LoadListViewByDrID();
            //populateDataToGrid(dgvDRDetails,txtDrID.Text);
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

        private void txtRequisitionBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (txtRequisitionBy.Text == "")
                //{
                //    MessageBox.Show("Please select Employee");
                //    return;
                //}
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
        }

        private void cboCostCategoey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCostCategoey.SelectedValue != null)
            {

                //CostCenterID,CostcenterName  
                cboCostCenter.DisplayMember = "CostcenterName";
                cboCostCenter.ValueMember = "CostCenterID";
                cboCostCenter.DataSource = invSr.GetAccountCostcenter("CostcenterTreeview", cboCostCategoey.SelectedValue.ToString(), "").ToList();
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            dgvPRDetails.Rows.Clear();

            foreach (DataGridViewRow row in dgvDRDetails.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    //foreach(DataGridViewRow oitem in dgvIssueDetails.Rows)
                    //{

                      dgvPRDetails.Rows.Add(row.Cells[0].Value.ToString(),
                                            row.Cells[1].Value.ToString(),
                                            row.Cells[2].Value.ToString(),
                                            row.Cells[3].Value.ToString(),
                                            row.Cells[4].Value.ToString(),
                                            row.Cells[5].Value.ToString(),
                                            row.Cells[6].Value.ToString(),
                                            row.Cells[7].Value.ToString(),
                                            row.Cells[8].Value.ToString(),
                                            row.Cells[9].Value.ToString(),
                                            row.Cells[10].Value.ToString(),
                                            row.Cells[11].Value.ToString(),
                                            row.Cells[12].Value.ToString(),
                                            row.Cells[13].Value.ToString(),
                                            row.Cells[14].Value.ToString()
                                            
                                        );
                    dgvPRDetails.Columns["checkBoxColumn"].Visible = false;
                    this.dgvPRDetails.Focus();
                }

            }
           
        }

        private void dgvPRDetails_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvPRDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 20)
            {
                int selRowIndex = e.RowIndex;
                if (selRowIndex < 0)
                {

                    dgvPRDetails.Rows.Clear();
                }
                else
                {
                    dgvPRDetails.Rows.RemoveAt(selRowIndex);
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtRequisitionBy.Text = Utility.UserId;
            UserID();
            btnSave.Enabled = true;
            dgvPRDetails.Rows.Clear();
            treeviewPurchaseRequisition.Nodes.Clear();
            List<SCMTree> purchaseRequisitions = invSr.GetDrID().Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewPurchaseRequisition, purchaseRequisitions);
            txtItemID.Focus();
        }

        private void txtItemID_KeyDown(object sender, KeyEventArgs e)
        {
           
            int number2;
            long result;
            int intCheck;
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtItemID.Text, out number2))
                {
                    
                    cboDepartment.Select();
                }
                else
                {
                    populateDataToGrid(dgvItem, txtItemID.Text, cboStoreType.SelectedValue.ToString());
                    txtItemID.Select();
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

        private void pnlMain_Click(object sender, EventArgs e)
        {
            dgvItem.Visible = false;
        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {
            if (dtv.Rows.Count > 0)
            {
                int currentRow = dtv.CurrentRow.Index;
                currentRow--;
                txtItemID.Text = dtv["ItemID", currentRow + 1].Value.ToString();
                txtItemName.Text = dtv["Item", currentRow + 1].Value.ToString();
                txtStockQty.Text = dtv["StockQty", currentRow + 1].Value.ToString();
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
                cboDepartment.Select();
            }
            else
            {
                dtv.Visible = false;
                cboDepartment.Select();
            }
        }

        private void dgvItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            setvaluesFromList(dgvItem, sender);
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvItem.Rows[e.RowIndex];

                txtItemID.Text = row.Cells["ItemID"].Value.ToString();
                txtItemName.Text = row.Cells["Item"].Value.ToString();
                txtStockQty.Text = row.Cells["StockQty"].Value.ToString();
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

                cboDepartment.Select();

            }
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
        private void ButtonAdd()
        {
            if (txtQuantity.Text == "0" || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Quantity Required");
                txtItemID.Select();
                return;
            }

            LoadListDataGridView();
        }
        private void LoadListDataGridView()
        {
           
            if (IsDuplicateFoundInList(dgvPRDetails, 1, txtItemID.Text))
            {
                MessageBox.Show("This Item is a duplicate");
                return;
            }
            short rowindex = 1;           
            int i = Convert.ToInt16(dgvPRDetails.Rows.Count);
            dgvPRDetails.Rows.Add(1);
            dgvPRDetails.Rows[i].Cells["ItemID"].Value = txtItemID.Text;
            dgvPRDetails.Rows[i].Cells["Item"].Value = txtItemName.Text;
            dgvPRDetails.Rows[i].Cells["StockQty"].Value = txtStockQty.Text;
            dgvPRDetails.Rows[i].Cells["CompanyID"].Value = txtCompanyID.Text;
            dgvPRDetails.Rows[i].Cells["GroupID"].Value = txtGroupID.Text;
            dgvPRDetails.Rows[i].Cells["UnitID"].Value = txtUnitID.Text;
            dgvPRDetails.Rows[i].Cells["TypeID"].Value = txtTypeID.Text;
            dgvPRDetails.Rows[i].Cells["ModelID"].Value = txtModelID.Text;
            dgvPRDetails.Rows[i].Cells["BrandID"].Value = txtBrandID.Text;
            dgvPRDetails.Rows[i].Cells["Group"].Value = txtGroupName.Text;
            dgvPRDetails.Rows[i].Cells["Company"].Value = txtCompanyName.Text;
            dgvPRDetails.Rows[i].Cells["Brand"].Value = txtBrandName.Text;
            dgvPRDetails.Rows[i].Cells["Model"].Value = txtModelName.Text;
            dgvPRDetails.Rows[i].Cells["StoreTypeID"].Value = txtStoreType.Text;
            dgvPRDetails.Rows[i].Cells["MajorGroup"].Value = txtMajorGroup.Text;
            dgvPRDetails.Rows[i].Cells["ReqQty"].Value = txtQuantity.Text;
            if (cboDepartment.SelectedValue != null)
            {
                dgvPRDetails.Rows[i].Cells["Dept"].Value = cboDepartment.SelectedValue.ToString();
            }
            else
            {
                dgvPRDetails.Rows[i].Cells["Dept"].Value = 0;

            }
            if (cboUnit.SelectedValue != null)
            {
                dgvPRDetails.Rows[i].Cells["Unit"].Value = cboUnit.SelectedValue.ToString();
            }
            else
            {
                dgvPRDetails.Rows[i].Cells["Unit"].Value = 0;
            }
            if (txtDrID.Text != null)
            {
                dgvPRDetails.Rows[i].Cells["DR No"].Value = txtDrID.Text;
            }
            else
            {
                dgvPRDetails.Rows[i].Cells["DR No"].Value = 0;
            }
            foreach (DataGridViewRow row in dgvPRDetails.Rows)
            {
                row.Cells["SNo"].Value = rowindex;
                rowindex++;
            }
   
            txtItemID.Select();
            RefreshList();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //ButtonAdd();
         
        }
        private void PopulateDataToGridForReq(DataGridView dtv, string prid)
        {
            dtv.DefaultCellStyle.BackColor = Color.Bisque;
            short index = 0,rowindex = 1;

            dgvPRDetails.Rows.Clear();
            List<PurchaseRequisition> list = new List<PurchaseRequisition>();
            list.Clear();
            list.AddRange(invSr.GetPRDetailsForPR(prid).ToList());
            foreach (PurchaseRequisition data in list)
            {
                string[] row = new string[] { rowindex.ToString(),
                                              data.ItemMaster.ID,
                                              data.ItemMaster.Name,   
                                              data.ItemMaster.StockQty.ToString(),
                                              data.ItemMaster.PacketType.ID,
                                              data.ItemMaster.Units.ID,
                                              data.ItemMaster.GroupDetails.ID,
                                              data.ItemMaster.Company.ID,
                                              data.ItemMaster.BrandSetup.ID,
                                              data.ItemMaster.ModelSetup.ID,
                                              data.ItemMaster.StoreType.strTypeID,
                                              data.ItemMaster.Majorgroup.MajorgrpID,
                                              data.ItemMaster.GroupDetails.Name,
                                              data.ItemMaster.Company.Name,
                                              data.ItemMaster.BrandSetup.Name,
                                              data.ItemMaster.ModelSetup.Name,                                              
                                              data.RequisitionQty.ToString(),
                                              data.Department.DepartmentID,
                                              data.DepartmentUnit.UnitId,
                                              data.DemandRequisition.ID
                                              //""
                                              //rowindex.ToString()
                                              };

                AddRowsToCollection(dgvPRDetails, row, index);
                index++;
                rowindex++;
            }
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void cboStoreType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboStoreType.SelectedValue != null)
            //{
            //    cboStoreLocation.ValueMember = "ID";
            //    cboStoreLocation.DisplayMember = "Name";
            //    cboStoreLocation.DataSource = new BindingSource(invSr.GetStoreLocByType(cboStoreType.SelectedValue.ToString()), null);
            //}
            dgvPRDetails.Rows.Clear();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.Text != "--Select--")
            {
                if (cboDepartment.Text != "")
                {
                    cboUnit.DisplayMember = "Value";
                    cboUnit.ValueMember = "Key";
                    cboUnit.DataSource = new BindingSource(Utility.VerifyDic(invSr.GetUnitDict(cboDepartment.SelectedValue.ToString())), null);
                }
            }
        }

        private void cboDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboUnit.Focus();
            }
        }
        private void cboUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtDrID.Focus();
            }
        }

        private void txtDrID_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
        private void txtRequisitionBy_TextChanged(object sender, EventArgs e)
        {
            UserID();           
        }
        private void AddDataToReqList(List<PurchaseRequisition> tests, object sender, EventArgs e)
        {
            try
            {
                foreach (PurchaseRequisition ts in tests)
                {
                    txtPrId.Text = ts.ID;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPRDetails.Rows.Clear();
           
            int vrfy = invSr.VarifyPurchaseReqNo(txtPrId.Text);
            if (txtPrId.Text == "")
            {
                
                string i = cboStoreType.SelectedValue.ToString();
                string j = cboStoreLocation.SelectedValue.ToString();
                frmPurchaseRequisitionList oreqlist = new frmPurchaseRequisitionList(i,j);
                oreqlist.onAddAllButtonClicked = new frmPurchaseRequisitionList.AddAllClick(AddDataToReqList);
                oreqlist.ShowDialog();
                if (invSr.VarifyPRForModify(txtPrId.Text) > 0)
                {
                    MessageBox.Show("This Requisition is already Ordered.", "Important Message");
                    //return;
                }
                PopulateDataToGridForReq(dgvPRDetails, txtPrId.Text);
                             
            }
            else if (vrfy == 0)
            {
                MessageBox.Show("Please put valid DR No");
                dgvPRDetails.Rows.Clear();
                txtPrId.Select();
                return;

            }
            else
            {
                if (invSr.VarifyPRForModify(txtPrId.Text) > 0)
                {
                    MessageBox.Show("This Requisition is already Ordered.", "Important Message");
                    //return;
                }
                PopulateDataToGridForReq(dgvPRDetails, txtPrId.Text);
                txtRemarks.Select();
            }
            
            
        }

        private void txtPrId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSearch.Select();
            }
        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    txt
            //}
        }

        private void txtDrID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtQuantity.Select();
            }
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

        private void btnItemStock_Click(object sender, EventArgs e)
        {
            frmItemStockList oitemstock = new frmItemStockList();
            oitemstock.ShowDialog();
        }
        
        private void txtItemID_KeyUp(object sender, KeyEventArgs e)
        {
            //long result;
            //int intCheck;
            //if (long.TryParse(txtItemID.Text, out result))
            //{
            //    intCheck = 0;
            //}
            //else
            //{
            //    intCheck = 1;
            //}

            //SearchListView(list, intCheck, txtItemID.Text);            
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
           
            ButtonAdd();
            //string itemid = txtItemID.Text;
            //foreach(ItemMaster itm in list)
            //{
            //    if(itemid == itm.ID)
            //    {
            //        ButtonAdd();                            
            //    }
               
            //}
            
        }

        private void dgvPRDetails_SelectionChanged(object sender, EventArgs e)
        {
                           
           
            
        }

        private void dgvPRDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemID.Text = dgvPRDetails.CurrentRow.Cells["ItemID"].Value.ToString();
            txtItemName.Text = dgvPRDetails.CurrentRow.Cells["Item"].Value.ToString();
            cboDepartment.SelectedValue = dgvPRDetails.CurrentRow.Cells["Dept"].Value.ToString();
            cboUnit.SelectedValue = dgvPRDetails.CurrentRow.Cells["Unit"].Value.ToString();
            txtDrID.Text = dgvPRDetails.CurrentRow.Cells["DR No"].Value.ToString();
            txtQuantity.Text = dgvPRDetails.CurrentRow.Cells["ReqQty"].Value.ToString();

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintReport(txtPrId.Text);
        }

        private void dgvPRDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dgvPRDetails_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            txtItemName.Text = string.Empty;
        }
        

    }
}
