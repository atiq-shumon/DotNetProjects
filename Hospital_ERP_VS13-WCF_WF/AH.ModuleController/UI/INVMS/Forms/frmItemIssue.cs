using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.UI.InvMS.Reports.Viewer;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmItemIssue : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        private string storeid, salesType;
        List<SCMTree> itemissue;
        GroupBox dummy;
        public int chkInt = 0;
        public bool chked = false;

        public frmItemIssue(string storeid,string salesType)
        {
            InitializeComponent();
            this.storeid = storeid;
            this.salesType = salesType;

            dummy = new GroupBox();
            dummy.Visible = false;
            dummy.Enabled = false;
            this.Controls.Add(dummy);
            
        }

        private void frmItemIssue_Load(object sender, EventArgs e)
        {
            itemissue = invSr.GetDrID().Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewItemIssue, itemissue);

            cboCostCategoey.DisplayMember = "CategoryName";
            cboCostCategoey.ValueMember = "CategoryID";
            cboCostCategoey.DataSource = invSr.GetCostcategory("CostcategoryTreeview", "", "").ToList();
            
            
            cboSalesTypes.DisplayMember = "Name";
            cboSalesTypes.ValueMember = "ID";
            cboSalesTypes.DataSource = new BindingSource(invSr.GetIssueType(), null);

            txtStoreID.Text = this.storeid;
            cboSalesTypes.SelectedValue = this.salesType;

            //cboDepartment.DisplayMember = "Value";
            //cboDepartment.ValueMember = "Key";
            //cboDepartment.DataSource = new BindingSource(invSr.GetDepartments("D"), null);

            //cboUnit.DisplayMember = "Value";
            //cboUnit.ValueMember = "Key";
            //cboUnit.DataSource = new BindingSource(invSr.GetDepartmentUnit("E"),null);

            txtIssueDate.Text = DateTime.Now.ToString();
            txtEmpId.Text = Utility.UserId;
          
            //lvItemIssue.LabelEdit = true;
            FormatForm(this.salesType);

            
            //dgvIssueDetails.Visible = true;
            dgvSerialNo.Visible = true;
            grpStockDet.Visible = false;
            btnAddItems.Visible = false;
            btnCloseStockDetails.Visible = false;
            //FormatData(dgvIssueDetails);
            
            FormatGridByIR();


            FormatData(dgvDemandReq);
            FormatData(dgvIssueDetails);
            FormatData(dgvStockDetails);
            dgvStockDetails.Columns[0].Visible = false;            
            
            //dgvStockDetails.Columns[11].Visible = false;
            dgvStockDetails.Columns[12].Visible = false;
            dgvStockDetails.Columns[13].Visible = false;
            dgvStockDetails.Columns[18].Visible = false;
            dgvStockDetails.Columns[19].Visible = false;
            dgvStockDetails.Columns[20].Visible = false;
            dgvStockDetails.Columns[21].Visible = false;
            dgvStockDetails.Columns[22].Visible = false;
            dgvStockDetails.Columns[26].Visible = false;
            dgvStockDetails.Columns[27].Visible = false;

            FormatDataForSerialNo(dgvSerialNo);
            FormatDataForSerialNo(dgvLoadSerialNo);
            dgvLoadSerialNo.Columns[1].Visible = false;
            dgvDemandReq.Columns[15].Visible = false;
            dgvDemandReq.Columns[18].Visible = false;
            dgvDemandReq.Columns[19].Visible = false;
            dgvDemandReq.Columns[20].Visible = false;
            dgvDemandReq.Columns[21].Visible = false;
            dgvDemandReq.Columns[22].Visible = false;
            dgvDemandReq.Columns[23].Visible = false;
            dgvDemandReq.Columns[24].Visible = false;
            dgvDemandReq.Columns[25].Visible = false;
            dgvDemandReq.Columns[26].Visible = false;
            dgvDemandReq.Columns[27].Visible = false;
            dgvDemandReq.Columns[28].Visible = false;
        }

     
        private void FormatForm(string mode)
        {
            switch (mode)
            {
                case "01":
                    lblNo.Text = "DR NO :";

                    txtDemandRequisition.Location = txtRegistrationNo.Location;
                    txtRegistrationNo.Visible = false;
                    
                    lblNo.Visible = true;
                    
                    pnlRegistration.Visible = false;
                    
                    
                    //cboIssueRequisition.DisplayMember  = "ID";
                    //cboIssueRequisition.DataSource = new BindingSource(invSr.GetIRNumbers(),null);
                    break;

                case "02":
                    lblNo.Text = "Registration No :";
                    txtRegistrationNo.Visible = true;
                   
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
            //dtv.Height = 300;
            //dtv.Width = 840;
            
            dtv.AutoGenerateColumns = false;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

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

            DataGridViewTextBoxColumn groupname = new DataGridViewTextBoxColumn();
            groupname.Name = "Group";
            groupname.DataPropertyName = "Group";
            groupname.Width = 180;
            groupname.Visible = true;
            groupname.ReadOnly = true;
            dtv.Columns.Add(groupname);

            DataGridViewTextBoxColumn compname = new DataGridViewTextBoxColumn();
            compname.Name = "Company";
            compname.DataPropertyName = "Company";
            compname.Width = 150;
            compname.Visible = true;
            compname.ReadOnly = true;
            dtv.Columns.Add(compname);


            DataGridViewTextBoxColumn brandname = new DataGridViewTextBoxColumn();
            brandname.Name = "Brand";
            brandname.DataPropertyName = "Brand";
            brandname.Width = 150;
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

            DataGridViewTextBoxColumn colStockQty = new DataGridViewTextBoxColumn();
            colStockQty.Name = "StockQty";
            colStockQty.DataPropertyName = "StockQty";
            colStockQty.Width = 70;
            colStockQty.ReadOnly = true;
            dtv.Columns.Add(colStockQty);
            dtv.Columns["StockQty"].DefaultCellStyle.ForeColor = Color.Red;
            dtv.Columns["StockQty"].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Bold);

            DataGridViewTextBoxColumn colissueqty = new DataGridViewTextBoxColumn();
            colissueqty.Name = "IssueQty";
            colissueqty.DataPropertyName = "IssueQty";
            colissueqty.Width = 70;
            colissueqty.Visible = true;
            colissueqty.ReadOnly = false;
            dtv.Columns.Add(colissueqty);

            DataGridViewTextBoxColumn ReqQuantity = new DataGridViewTextBoxColumn();
            ReqQuantity.Name = "ReqQty";
            ReqQuantity.DataPropertyName = "ReqQty";
            ReqQuantity.Width = 60;
            ReqQuantity.Visible = true;
            ReqQuantity.ReadOnly = true;
            dtv.Columns.Add(ReqQuantity);

            DataGridViewTextBoxColumn Quantity = new DataGridViewTextBoxColumn();
            Quantity.Name = "PendingReqQty";
            Quantity.DataPropertyName = "Qty";
            Quantity.Width = 65;
            Quantity.Visible = true;
            Quantity.ReadOnly = true;
            dtv.Columns.Add(Quantity);

            
            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 60;
            colUrate.ReadOnly = true;
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colamount = new DataGridViewTextBoxColumn();
            colamount.Name = "Amount";
            colamount.DataPropertyName = "Amount";
            colamount.Width = 60;
            colamount.ReadOnly = true;
            dtv.Columns.Add(colamount);

            DataGridViewTextBoxColumn colVat = new DataGridViewTextBoxColumn();
            colVat.Name = "VAT";
            colVat.DataPropertyName = "VAT";
            colVat.Width = 50;
            colVat.ReadOnly = true;
            dtv.Columns.Add(colVat);

            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Disc";
            colDiscount.DataPropertyName = "Disc";
            colDiscount.Width = 50;
            colDiscount.ReadOnly = true;
            dtv.Columns.Add(colDiscount);

            DataGridViewTextBoxColumn colremcalc = new DataGridViewTextBoxColumn();
            colremcalc.Name = "RemCalc";
            colremcalc.DataPropertyName = "RemCalc";
            colremcalc.Width = 0;
            colremcalc.Visible = false;
            colremcalc.ReadOnly = true;
            dtv.Columns.Add(colremcalc);

            DataGridViewTextBoxColumn colnetamount = new DataGridViewTextBoxColumn();
            colnetamount.Name = "NetAmount";
            colnetamount.DataPropertyName = "NetAmount";
            colnetamount.Width = 70;
            colnetamount.ReadOnly = true;
            dtv.Columns.Add(colnetamount);

            DataGridViewTextBoxColumn colbatchid = new DataGridViewTextBoxColumn();
            colbatchid.Name = "Batch";
            colbatchid.DataPropertyName = "Batch";
            colbatchid.Width = 80;
            colbatchid.ReadOnly = true;
            dtv.Columns.Add(colbatchid);

            DataGridViewTextBoxColumn colmrrid = new DataGridViewTextBoxColumn();
            colmrrid.Name = "GRNNO";
            colmrrid.DataPropertyName = "GRNNO";
            colmrrid.Width = 90;
            colmrrid.ReadOnly = true;
            dtv.Columns.Add(colmrrid);

            DataGridViewTextBoxColumn colexpiredate = new DataGridViewTextBoxColumn();
            colexpiredate.Name = "ExpireDate";
            colexpiredate.DataPropertyName = "ExpireDate";
            colexpiredate.Width = 80;
            colexpiredate.ReadOnly = true;
            dtv.Columns.Add(colexpiredate);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.Width = 60;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dtv.Columns.Add(Deletelink);

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Visible = true;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(28, checkBoxColumn);
            dtv.Columns["IssueQty"].DefaultCellStyle.ForeColor = Color.DarkCyan;
        }

        private void populateDataToGridForIssue(DataGridView dtv, string drid)
        {

            short index = 0;
            dgvDemandReq.Visible = true;
            dgvDemandReq.Rows.Clear();
            dgvIssueDetails.Rows.Clear();
            List<DemandRequisition> list = new List<DemandRequisition>();
            list.Clear();
            list.AddRange(invSr.GetDrDetails(drid).ToList());

            foreach (DemandRequisition data in list)
            {
                string[] row = new string[] { data.ItemMaster.ID,
                                              data.ItemMaster.Name,
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
                                              data.ItemMaster.StockQty.ToString(),
                                              data.DemandQty.ToString(),
                                              data.DemandQty.ToString(),
                                              data.RemainingQty.ToString(),                
                                              data.ItemMaster.Urate.ToString(),
                                              "0",
                                              data.ItemMaster.VAT.ToString(),
                                              data.ItemMaster.Discount.ToString(),
                                              data.RemainingQty.ToString(),
                                              "0"
                                              
            };
                AddRowsToCollection(dgvDemandReq, row, index);
                index++;
            }
            
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtReceivedBy", "cboCostCategoey", "cboCostCenter" };
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(dgvIssueDetails.Rows.Count == 0)
            {
                MessageBox.Show("Please Select Item ");
                return;
            }
            for (int k = 0; k < dgvIssueDetails.Rows.Count;k++ )
            {
                if (float.Parse(dgvIssueDetails.Rows[k].Cells["IssueQty"].Value.ToString()) == 0)
                {
                    MessageBox.Show("Issue Quantity can not be zero");
                    return;
                }
                if (Convert.ToDateTime(dgvIssueDetails.Rows[k].Cells["ExpireDate"].Value) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    MessageBox.Show("Expire Date cannot be earlier than Current Date");
                    return;
                }
            }
              
                if (txtIssueDate.Text == "  /  /")
                {
                    MessageBox.Show("Date cannot be Empty");
                    return;
                }
            //if (dgvLoadSerialNo.Rows.Count == 0)
            //{
            //    MessageBox.Show("Please select SerialNo");
            //    return;
            //}         
            //}
            //for (int i = 0; i < dgvIssueDetails.Rows.Count; i++)
            //{
            //    //if (float.Parse(dgvIssueDetails.Rows[i].Cells[16].Value.ToString()) == 0)
            //    //   {
            //    //    MessageBox.Show("Stock is Empty");
            //    //    return;
            //    //    }
            //    if (float.Parse(dgvIssueDetails.Rows[i].Cells["IssueQty"].Value.ToString()) > float.Parse(dgvIssueDetails.Rows[i].Cells["StockQty"].Value.ToString()))
            //    {
            //        MessageBox.Show("Qty cann't be more than StockQty");
            //        return;
            //    }
            //    //if (float.Parse(dgvIssueDetails.Rows[i].Cells["IssueQty"].Value.ToString()) > float.Parse(dgvIssueDetails.Rows[i].Cells["PendingReqQty"].Value.ToString()))
            //    //{
            //    //    MessageBox.Show("IssueQty cann't be more than PendingReqQty");
            //    //    return;
            //    //}

            //}
            try
            {

                ItemIssue issueObj = this.populateDrugIssue();

                string i = invSr.SaveItemIssue(issueObj);


                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    string firstPart = Utility.GetStringPart(i, "$");
                    txtIssueID.Text = firstPart;
                    PrintReport(firstPart);
                    string secondPart = Utility.GetStringPart(i, "$", true);
                    dgvIssueDetails.Rows.Clear();
                    dgvDemandReq.Rows.Clear();                 
                    txtEmpId.Text = Utility.UserId;                    
                    txtRemarks.Text = string.Empty;
                    txtWarehouseID.Text = string.Empty;
                    txtWarehouseName.Text = string.Empty;
                    //dgvSerialNo.Rows.Clear();
                    dgvLoadSerialNo.Rows.Clear();
                    treeviewItemIssue.Nodes.Clear();
                    List<SCMTree> itemissue = invSr.GetDrID().Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
                    Utility.PopulateTreeSCM(treeviewItemIssue, itemissue);
                    //lvDrugIssue.Items.Clear();
                    if (secondPart != "0")
                    {
                        MessageBox.Show("Complete");
                    }

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
        private void PrintReport(string issueid)
        {
            frmReportViewer ofrmreportviewer = new frmReportViewer();
            ofrmreportviewer.selector = ViewerSelector.IssueReport;
            ofrmreportviewer.issueid = issueid;
            ofrmreportviewer.ViewReport();
        }
        private ItemIssue populateDrugIssue()
        {
            ItemIssue oitemissue = new ItemIssue();
            
            //oitemissue.ConsumptionHeadID = "0001";
            oitemissue.ConsumptionID = "0001";
            oitemissue.IssueDate = DateTime.Parse(txtIssueDate.Text);
            oitemissue.IssueType = cboSalesTypes.SelectedValue.ToString();
            oitemissue.ReceivedBy = txtEmpId.Text;
            oitemissue.Remarks = txtRemarks.Text;
            oitemissue.TransactionType = "CO";

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            oitemissue.CostCategoryTreeview = ocostcenter;

            StoreTypeSCM ostrtype = new StoreTypeSCM();
            ostrtype.strTypeID = txtStoreType.Text;
            oitemissue.StoreTypeSCM = ostrtype;


            DemandRequisition ir = new DemandRequisition();
            ir.ID = txtDemandRequisition.Text;          
            oitemissue.DemandRequisition = ir;

            Warehouse owarehouse = new Warehouse();
            owarehouse.TypeID = "0062";
            owarehouse.ToTypeID = txtWarehouseID.Text;
            oitemissue.Warehouse = owarehouse;


            
            oitemissue.Doctor = "001";
            oitemissue.PrescriptionNo = "T115-0001";
            oitemissue.RegID = "P0115-555";
            oitemissue.Staff = "01245";
            oitemissue.HCN = "010124556";
           

            Bed obed = new Bed();
            obed.BedID = "001";

           
            Room orm = new Room();
            orm.RoomID = "001";
            obed.Room = orm;

            oitemissue.Bed = obed;
            //oitemissue.Doctor = txtDoctor.Text;

            Department dpt = new Department();
            dpt.DepartmentID = txtDeptID.Text;
            oitemissue.Department = dpt;

            DepartmentUnit dunit = new DepartmentUnit();
            dunit.UnitId = txtDeptUnitID.Text;
            oitemissue.DepartmentUnit = dunit;


           
            //PurchaseOrder po = new PurchaseOrder();
            //po.ID = cboPurchaseOrder.Text;
            //po.PODate = DateTime.Parse(txtPODate.Text);
            //dr.PurchaseOrder = po;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oitemissue.EntryParameter = ep;

            string IssueString = "";

            foreach (DataGridViewRow dr in dgvIssueDetails.Rows)
            {
                IssueString += dr.Cells[0].Value.ToString() + "," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[7].Value.ToString() + "," + dr.Cells[8].Value.ToString() + "," + dr.Cells[9].Value.ToString() + "," + dr.Cells[16].Value.ToString() + "," + dr.Cells[15].Value.ToString() + "," + dr.Cells[18].Value.ToString() + "," + dr.Cells[20].Value.ToString() + "," + dr.Cells[21].Value.ToString() + "," + dr.Cells[24].Value.ToString() + "," + dr.Cells[25].Value.ToString();
                IssueString += ";";
            }
            oitemissue.IssueDetails = IssueString;

            string assettrackerslno = "";

            foreach(DataGridViewRow sl in dgvLoadSerialNo.Rows)
            {
                assettrackerslno += sl.Cells[0].Value.ToString();
                assettrackerslno += ":";
            }

            oitemissue.AssetTrackerSerialNo = assettrackerslno;

            return oitemissue;
        }

      

     

       
      
        private void FormatGridByIR()
        {

            lvIrDetails.Columns.Add("Item ID", 90, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Item Name", 200, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("PackageType", 0, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Item Unit", 0, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Item Group", 0, HorizontalAlignment.Left);
            //lvItemList.Columns.Add("Group", 200, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Item Company", 0, HorizontalAlignment.Left);
            //lvItemList.Columns.Add("Company", 200, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Brand", 0, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Model", 0, HorizontalAlignment.Left);

            lvIrDetails.Columns.Add("Group", 200, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Company", 150, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Brand", 150, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Model", 150, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("ReqQuantity", 100, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("StockQuantity", 100, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Rate", 100, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("VAT", 100, HorizontalAlignment.Left);
            lvIrDetails.Columns.Add("Discount", 100, HorizontalAlignment.Left);
        }
        private void LoadListDetailsByIR()
        {

            lvIrDetails.Items.Clear();

            List<DemandRequisition> odemand = invSr.GetDrDetails(txtDemandRequisition.Text).ToList();
            int i = 0;

            foreach (DemandRequisition dem in odemand)
            {
                ListViewItem itm = new ListViewItem(dem.ItemMaster.ID);
                itm.SubItems.Add(dem.ItemMaster.Name);
                itm.SubItems.Add(dem.ItemMaster.PacketType.ID);
                itm.SubItems.Add(dem.ItemMaster.Units.ID);
                itm.SubItems.Add(dem.ItemMaster.GroupDetails.ID);
                itm.SubItems.Add(dem.ItemMaster.Company.ID);
                itm.SubItems.Add(dem.ItemMaster.BrandSetup.ID);
                itm.SubItems.Add(dem.ItemMaster.ModelSetup.ID);
                itm.SubItems.Add(dem.ItemMaster.GroupDetails.Name);
                itm.SubItems.Add(dem.ItemMaster.Company.Name);
                itm.SubItems.Add(dem.ItemMaster.BrandSetup.Name);
                itm.SubItems.Add(dem.ItemMaster.ModelSetup.Name);
                itm.SubItems.Add(dem.DemandQty.ToString());
                itm.SubItems.Add(dem.ItemMaster.StockQty.ToString());
                itm.SubItems.Add(dem.ItemMaster.Urate.ToString());
                itm.SubItems.Add(dem.ItemMaster.VAT.ToString());
                itm.SubItems.Add(dem.ItemMaster.Discount.ToString());
                lvIrDetails.Items.Add(itm);
            }

        }       
        private void trList_AfterSelect(object sender, TreeViewEventArgs e)
        {


        }
        private void LoadListItems()
        {
           
            txtDeptID.DataBindings.Clear();            
            txtDeptUnitID.DataBindings.Clear();
            txtDepartment.DataBindings.Clear();
            txtDepartmentUnit.DataBindings.Clear();
            txtWarehouseID.DataBindings.Clear();
            txtWarehouseName.DataBindings.Clear();
            txtStoreLocation.DataBindings.Clear();
            txtStoreType.DataBindings.Clear();
            txtStoreLocation.DataBindings.Add("Text", invSr.GetDrDetails(txtDemandRequisition.Text).ToList(), "Warehouse.TypeID");
            txtStoreType.DataBindings.Add("Text", invSr.GetDrDetails(txtDemandRequisition.Text).ToList(), "StoreTypeSCM.strTypeID");
            txtDeptID.DataBindings.Add("Text", invSr.GetDrDetails(txtDemandRequisition.Text).ToList(), "Department.DepartmentID");            
            txtDeptUnitID.DataBindings.Add("Text", invSr.GetDrDetails(txtDemandRequisition.Text).ToList(), "DepartmentUnit.UnitId");
            txtDepartment.DataBindings.Add("Text", invSr.GetDrDetails(txtDemandRequisition.Text).ToList(), "Department.DepartmentTitle");
            txtDepartmentUnit.DataBindings.Add("Text", invSr.GetDrDetails(txtDemandRequisition.Text).ToList(), "DepartmentUnit.UnitTitle");
            txtWarehouseID.DataBindings.Add("Text", invSr.GetDrDetails(txtDemandRequisition.Text).ToList(), "Warehouse.TypeID");
            txtWarehouseName.DataBindings.Add("Text", invSr.GetDrDetails(txtDemandRequisition.Text).ToList(), "Warehouse.TypeName");
        }
       
        private void lvIrDetails_MouseClick(object sender, MouseEventArgs e)
        {
            //foreach (ListViewItem item in lvIrDetails.Items)
            //{
            //    lvItemIssue.Items.Add((ListViewItem)item.Clone());
            //}

            dgvIssueDetails.Columns.Clear();
            FormatData(dgvIssueDetails);

            foreach (ListViewItem i in lvIrDetails.Items)
            {
                dgvIssueDetails.Rows.Add(i.SubItems[0].Text,
                                         i.SubItems[1].Text,
                                         i.SubItems[2].Text,
                                         i.SubItems[3].Text,
                                         i.SubItems[4].Text,
                                         i.SubItems[5].Text,
                                         i.SubItems[6].Text,
                                         i.SubItems[7].Text,
                                         i.SubItems[8].Text,
                                         i.SubItems[9].Text,
                                         i.SubItems[10].Text,
                                         i.SubItems[11].Text,
                                         i.SubItems[12].Text,
                                         i.SubItems[13].Text,
                                         i.SubItems[14].Text,
                                         i.SubItems[15].Text,
                                         i.SubItems[16].Text);

            }

            
        }

        private void dgvIssueDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (e.ColumnIndex == dgvIssueDetails.Columns["ReqQty"].Index)
            //{
            //    dgvIssueDetails.Rows[e.RowIndex].ErrorText = "";
            //    float newInteger;

            //    // Don't try to validate the 'new row' until finished  
            //    // editing since there 
            //    // is not any point in validating its initial value. 
            //    if (dgvIssueDetails.Rows[e.RowIndex].IsNewRow) { return; }
            //    if (!float.TryParse(e.FormattedValue.ToString(),
            //        out newInteger) || newInteger <= 0)
            //    {
            //        e.Cancel = true;
            //        dgvIssueDetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
            //    }
            //}

        }

        private void lvIrDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvIrDetails.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvIrDetails.SelectedItems[0];
                txtStock.Text = itm.SubItems[4].Text;
                txtRemQty.Text = itm.SubItems[3].Text;
            }
        }

        private void dgvIssueDetails_DoubleClick(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow  dv in dgvIssueDetails.SelectedRows)
            //{
            //    dgvIssueDetails.Rows.Remove(dv);
            //}
        }

        private void txtEmpId_Leave(object sender, EventArgs e)
        {
            
            lblInfo.Visible = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = invSr.GetEmpMaster(txtEmpId.Text);
            if (txtEmpId.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmpId.Text != "")
            {
                if (txtEmpId.Text == oEmpMas.EmpId)
                {

                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                    //lblDept.Text = oEmpMas.Department.DepartmentID;
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmpId.Select();
                }
            }

        }

        private void txtEmpId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (txtEmpId.Text == "")
                //{
                //    MessageBox.Show("Please select Employee");
                //    return;
                //}
                lblInfo.Visible = true;
                lblInfo.Text = "";
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas = invSr.GetEmpMaster(txtEmpId.Text);
                if (txtEmpId.Text == "")
                {
                    lblInfo.Text = "";
                    return;
                }
                if (txtEmpId.Text != "")
                {
                    if (txtEmpId.Text == oEmpMas.EmpId)
                    {

                        lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                        //lblDept.Text = oEmpMas.Department.DepartmentID;
                    }

                    else
                    {
                        MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmpId.Select();
                    }
                }

            }
        }

        private void txtReceivedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboSalesTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCostCenter.DataBindings.Clear();
            txtCostCenter.DataBindings.Add("Text", invSr.GetCostCenterByIssueType(cboSalesTypes.SelectedValue.ToString()), "CostCenterTitle");
        }

        private void txtDemandRequisition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            LoadListDetailsByIR();
        }

        private void treeviewItemIssue_AfterSelect(object sender, TreeViewEventArgs e)
        {
       
            txtDemandRequisition.Text = treeviewItemIssue.SelectedNode.Text;
            populateDataToGridForIssue(dgvDemandReq,txtDemandRequisition.Text);
            LoadListItems();
            btnSave.Enabled = true;
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

           
          
            dgvIssueDetails.Rows.Clear();

            foreach (DataGridViewRow row in dgvDemandReq.Rows)
            {
                
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    for (int i = 0; i < dgvDemandReq.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(dgvDemandReq.Rows[i].Cells["checkBoxColumn"].Value) == true)
                        {
                            if (float.Parse(dgvDemandReq.Rows[i].Cells[14].Value.ToString()) == 0)
                            {
                                MessageBox.Show("Stock is Empty");
                                return;
                            }
                        }


                    }

                   dgvIssueDetails.Rows.Add(row.Cells[0].Value.ToString(),
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
                                            row.Cells[14].Value.ToString(),
                                            0,
                                            row.Cells[16].Value.ToString(),
                                            row.Cells[17].Value.ToString(),
                                            row.Cells[18].Value.ToString(),
                                            row.Cells[19].Value.ToString(),
                                            row.Cells[20].Value.ToString(),
                                            row.Cells[21].Value.ToString(),
                                            row.Cells[22].Value.ToString()
                                        );
                    dgvIssueDetails.Columns["checkBoxColumn"].Visible = false;
                    dgvIssueDetails.Columns["PendingReqQty"].Visible = false;
                    this.dgvIssueDetails.Focus();
                }                

            }
            dgvIssueDetails.Columns["ReqQty"].HeaderText = "IssueQty";
           
            
        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {

            if (dgvIssueDetails.Rows.Count > 0)
            {

                int currentRow = dgvIssueDetails.CurrentRow.Index;
                currentRow--;
                //txtProductID.Text = dtv.CurrentRow.Cells["DRUGID"].Value.ToString();
                txtItemID.Text = dgvIssueDetails[0, currentRow + 1].Value.ToString();
            } 
           

        }
        private void FormatDataForSerialNo(DataGridView dtv)
        {
            //dtv.Height = 300;
            //dtv.Width = 840;

            //dtv.AutoGenerateColumns = false;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            

            DataGridViewTextBoxColumn serialno = new DataGridViewTextBoxColumn();
            serialno.Name = "serialno";
            serialno.DataPropertyName = "serialno";
            serialno.Width = 100;
            serialno.Visible = true;
            dtv.Columns.Add(serialno);
            dtv.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 0;
            itemid.Visible = false;
            dtv.Columns.Add(itemid);
            //dtv.Columns[1].DefaultCellStyle.ForeColor = Color.Black;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Visible = true;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(2, checkBoxColumn);
        }
        private void populateDataToGridForSerialNo(DataGridView dtv, string itemid)
        {
                
                //dgvSerialNo.Visible = true;
                List<AssetTrackerMaster> list = new List<AssetTrackerMaster>();
                list.AddRange(invSr.GetAssetTrackerSerialNo(itemid).ToList());

                dgvSerialNo.DataSource = list.Select(data => new
                {
                    
                    serialno = data.SerialNo,
                    ItemID = data.ItemMaster.ID

                }).ToList();
               
                //this.dgvSerialNo.Focus();
            

        }
     
        private void dgvIssueDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            setvaluesFromList(dgvIssueDetails, sender);
            populateDataToGridForSerialNo(dgvSerialNo, txtItemID.Text);
            //for (int i = 0; i < dgvIssueDetails.Rows.Count; i++)
            //{
            //    dgvIssueDetails.Rows[i].Cells[19].Value = float.Parse(dgvIssueDetails.Rows[i].Cells[15].Value.ToString()) * float.Parse(dgvIssueDetails.Rows[i].Cells[18].Value.ToString());
            //    dgvIssueDetails.Rows[i].Cells[23].Value = float.Parse(dgvIssueDetails.Rows[i].Cells[15].Value.ToString()) * float.Parse(dgvIssueDetails.Rows[i].Cells[18].Value.ToString()) + float.Parse(dgvIssueDetails.Rows[i].Cells[20].Value.ToString()) - float.Parse(dgvIssueDetails.Rows[i].Cells[21].Value.ToString());
            //}
            
            //dgvLoadSerialNo.Rows.Clear();                  
        }

        private bool Checkduplicate (string strSlNo)
        {
            
            for (int j = 0; j < dgvLoadSerialNo.Rows.Count ; j++)
            {
                if (strSlNo == dgvLoadSerialNo.Rows[j].Cells[0].Value)
                {
                    return  true ;
                }
            }
            return false;
            
        }

        private void btnAddSerial_Click(object sender, EventArgs e)
        {

            for (int k = 0; k <= dgvIssueDetails.Rows.Count-1; k++)
            {
                if (dgvIssueDetails.Rows[k].Cells[0].Value != "")
                {

                    if (CheckItemIssueQty(dgvIssueDetails.Rows[k].Cells[0].Value.ToString(), Convert.ToInt32(dgvIssueDetails.Rows[k].Cells[15].Value)))
                    {
                        MessageBox.Show("Please select serial number as Issue Quantity");
                        return;
                    }
                }
            }

           
            foreach (DataGridViewRow row in dgvSerialNo.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                  
                    if (Checkduplicate(row.Cells["serialno"].Value.ToString())==false)
                    {
                        dgvLoadSerialNo.Rows.Add(row.Cells["serialno"].Value.ToString());
                    }
                    dgvLoadSerialNo.Columns["checkBoxColumn"].Visible = false;
                    this.dgvSerialNo.Focus();
                }

            }
           
        }


        private bool CheckItemIssueQty(string strItemCode, int dblQty)
        {

            int i=1, intCount = 0;
        
            foreach (DataGridViewRow row in dgvSerialNo.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {

                    if (strItemCode == dgvSerialNo.Rows[i].Cells[2].Value.ToString())
                    {
                        intCount = intCount + 1;
                        
                    }
                }
            }
            if (intCount > 0)
            {
                if (intCount != dblQty)
                {

                    return true;
                }
            }

            return false;

        }

        private void dgvIssueDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
              
            if (e.ColumnIndex == 27)
            {
                int selRowIndex = e.RowIndex;
                if (selRowIndex < 0)
                {

                    dgvIssueDetails.Rows.Clear();
                }
                else
                {
                    dgvIssueDetails.Rows.RemoveAt(selRowIndex);
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtEmpId.Text = Utility.UserId;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            dgvDemandReq.Rows.Clear();
            txtDeptID.Text = string.Empty;
            txtDeptUnitID.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtDepartmentUnit.Text = string.Empty;
            txtWarehouseID.Text = string.Empty;
            txtWarehouseName.Text = string.Empty;

            dgvIssueDetails.Rows.Clear();
            
            //dgvLoadSerialNo.Rows.Clear();
            treeviewItemIssue.Nodes.Clear();
            List<SCMTree> itemissue = invSr.GetDrID().Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewItemIssue, itemissue);
        }

        private void dgvLoadSerialNo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvIssueDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != this.dgvIssueDetails.NewRowIndex)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("0.00##");
            }
        }
        private void UserID()
        {
            txtEmpId.Text = Utility.UserId;
            lblInfo.Visible = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = invSr.GetEmpMaster(txtEmpId.Text);
            lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
        }
        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            UserID();
        }

        private void dgvIssueDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvDemandReq_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string i = dgvDemandReq.CurrentRow.Cells[0].Value.ToString();
            //frmItemDetailsByBatch oitmdet = new frmItemDetailsByBatch(i);
            //oitmdet.ShowDialog();
            //grpStockDet.Visible = true;
            //btnAddItems.Visible = true;
            //btnCloseStockDetails.Visible = true;
            //grpStockDet.Height = 200;
            //grpStockDet.Width = 1080;
            //dgvStockDetails.Height = 170;
            //dgvStockDetails.Width = 1010;
            //populateDataToGridForStock(dgvStockDetails,dgvDemandReq.CurrentRow.Cells[0].Value.ToString(),txtDemandRequisition.Text);
            //btnAddItems.Location = new Point(grpStockDet.Location.X + 1020, grpStockDet.Location.Y+12);
            //btnCloseStockDetails.Location = new Point(grpStockDet.Location.X + 1020, grpStockDet.Location.Y + 40);
        }

       
        private void btnAddItems_Click(object sender, EventArgs e)
        {
            //dgvStockDetails.Rows.Clear();
            
            foreach (DataGridViewRow row in dgvStockDetails.Rows)
            {
                
                float sum = 0;
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    for (int i = 0; i < dgvStockDetails.Rows.Count; i++)
                    {
                        
                        if (Convert.ToBoolean(dgvStockDetails.Rows[i].Cells["checkBoxColumn"].Value) == true)
                        {

                            sum += float.Parse(dgvStockDetails.Rows[i].Cells["IssueQty"].Value.ToString());

                            lblTotalReq.Text = sum.ToString();
                            if (float.Parse(lblTotalReq.Text.ToString()) > float.Parse(dgvStockDetails.Rows[i].Cells["ReqQty"].Value.ToString()))
                            {
                                MessageBox.Show("IssueQty cann't be more than ReqQty");
                                return;
                            }

                            if (float.Parse(dgvStockDetails.Rows[i].Cells["StockQty"].Value.ToString()) == 0)
                            {
                                MessageBox.Show("Stock is Empty");
                                return;
                            }
                            if (float.Parse(dgvStockDetails.Rows[i].Cells["IssueQty"].Value.ToString()) > float.Parse(dgvStockDetails.Rows[i].Cells["StockQty"].Value.ToString()))
                            {
                                MessageBox.Show("IssueQty cann't be more than StockQty");
                                return;
                            }
                            if (float.Parse(dgvStockDetails.Rows[i].Cells["IssueQty"].Value.ToString()) > float.Parse(dgvStockDetails.Rows[i].Cells["RemCalc"].Value.ToString()))
                            {
                                MessageBox.Show("IssueQty cann't be more than PendingReqQty");
                                return;
                            }

                        }
                    }
                    for (int j = 0; j < dgvIssueDetails.Rows.Count; j++)
                    {
                        if (row.Cells[0].Value.ToString() == dgvIssueDetails.Rows[j].Cells[0].Value.ToString() && row.Cells[24].Value.ToString() == dgvIssueDetails.Rows[j].Cells[24].Value.ToString())
                        {
                            MessageBox.Show("This Item is Duplicate");
                            grpStockDet.Visible = false;
                            btnAddItems.Visible = false;
                            btnCloseStockDetails.Visible = false;
                            return;

                        }

                    }
                        dgvIssueDetails.Rows.Add(row.Cells[0].Value.ToString(),
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
                                                 row.Cells[14].Value.ToString(),
                                                 row.Cells[15].Value.ToString(),
                                                 row.Cells[16].Value.ToString(),
                                                 row.Cells[17].Value.ToString(),
                                                 row.Cells[18].Value.ToString(),
                                                 row.Cells[19].Value.ToString(),
                                                 row.Cells[20].Value.ToString(),
                                                 row.Cells[21].Value.ToString(),
                                                 row.Cells[22].Value.ToString(),
                                                 row.Cells[23].Value.ToString(),
                                                 row.Cells[24].Value.ToString(),
                                                 row.Cells[25].Value.ToString(),
                                                 row.Cells[26].Value.ToString()
                                             );
                        dgvIssueDetails.Columns["checkBoxColumn"].Visible = false;
                        
                        dgvIssueDetails.Columns["ItemID"].Visible = false;
                        dgvIssueDetails.Columns["PendingReqQty"].Visible = false;
                        dgvIssueDetails.Columns["Brand"].Visible = false;
                        dgvIssueDetails.Columns["ReqQty"].Visible = false;
                        dgvIssueDetails.Columns["Batch"].Visible = false;
                        dgvIssueDetails.Columns["GRNNO"].Visible = false;
                        dgvIssueDetails.Columns["ExpireDate"].Visible = false;
                        dgvIssueDetails.Columns["Company"].Visible = false;
                        this.dgvIssueDetails.Focus();
                    
                   
                }
            }
            //dgvIssueDetails.Columns["ReqQty"].HeaderText = "IssueQty";
            
            for (int i = 0; i < dgvIssueDetails.Rows.Count; i++)
            {
                dgvIssueDetails.Rows[i].Cells[19].Value = float.Parse(dgvIssueDetails.Rows[i].Cells[15].Value.ToString()) * float.Parse(dgvIssueDetails.Rows[i].Cells[18].Value.ToString());
                dgvIssueDetails.Rows[i].Cells[22].Value = float.Parse(dgvIssueDetails.Rows[i].Cells[15].Value.ToString()) * float.Parse(dgvIssueDetails.Rows[i].Cells[18].Value.ToString()) + float.Parse(dgvIssueDetails.Rows[i].Cells[20].Value.ToString()) - float.Parse(dgvIssueDetails.Rows[i].Cells[21].Value.ToString());
            }
            grpStockDet.Visible = false;
            btnAddItems.Visible = false;
            btnCloseStockDetails.Visible = false;
        }
        private void populateDataToGridForStock(DataGridView dtv, string itemid,string drid)
        {
            
            short index = 0;
            dgvStockDetails.Visible = true;
            dgvStockDetails.Rows.Clear();
            List<ItemOrder> list = new List<ItemOrder>();
            list.Clear();           
            list.AddRange(invSr.GetItemDetailsBatch(itemid, drid).ToList());      
           
            foreach (ItemOrder data in list)
            {
                string[] row = new string[] { data.ItemMaster.ID,
                                              data.ItemMaster.Name,
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
                                              data.StockQty.ToString(),
                                              data.ReqQty.ToString(),
                                              data.ReqQty.ToString(),
                                              data.RemQty.ToString(),                
                                              data.Rate.ToString(),
                                              "0",
                                              data.VAT.ToString(),
                                              data.Discount.ToString(),
                                              data.RemQty.ToString(),
                                              "0",
                                              data.Batch,
                                              data.MRRID,
                                              data.ExpireDate.ToString("dd/MM/yyyy")
                                              
            };
                AddRowsToCollection(dgvStockDetails, row, index);
                index++;
               // dgvStockDetails.Columns["ReqQty"].HeaderText = "IssueQty";
            }

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCloseStockDetails_Click(object sender, EventArgs e)
        {
            grpStockDet.Visible = false;
            dgvStockDetails.Visible = false;
            btnAddItems.Visible = false;
            btnCloseStockDetails.Visible = false;
        }

        private void dgvDemandReq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string i = dgvDemandReq.CurrentRow.Cells[0].Value.ToString();
            //frmItemDetailsByBatch oitmdet = new frmItemDetailsByBatch(i);
            //oitmdet.ShowDialog();
            grpStockDet.Visible = true;
            btnAddItems.Visible = true;
            btnCloseStockDetails.Visible = true;
            grpStockDet.Height = 200;
            grpStockDet.Width = 1080;
            dgvStockDetails.Height = 170;
            dgvStockDetails.Width = 1010;
            populateDataToGridForStock(dgvStockDetails, dgvDemandReq.CurrentRow.Cells[0].Value.ToString(), txtDemandRequisition.Text);
            btnAddItems.Location = new Point(grpStockDet.Location.X + 1020, grpStockDet.Location.Y + 12);
            btnCloseStockDetails.Location = new Point(grpStockDet.Location.X + 1020, grpStockDet.Location.Y + 40);
            dgvStockDetails.Columns["Amount"].Visible = false;
            dgvStockDetails.Columns["NetAmount"].Visible = false;
            dgvStockDetails.Columns["Brand"].Visible = false;
            dgvStockDetails.Columns["Company"].Visible = false;
            dgvStockDetails.Columns["ReqQty"].Visible = false;
        }

        private void dgvStockDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
           
        }

        private void dgvStockDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RemCalculation()
        {
            double dblRemQty = 0;
            for (int i = 0; i < dgvStockDetails.Rows.Count; i++)
            {
                if (i == 0)
                {
                    dblRemQty = float.Parse(dgvStockDetails.Rows[i].Cells["RemCalc"].Value.ToString()) - float.Parse(dgvStockDetails.Rows[i].Cells["IssueQty"].Value.ToString());
                }
                else
                {
                    dblRemQty = dblRemQty - float.Parse(dgvStockDetails.Rows[i].Cells["IssueQty"].Value.ToString());
                }
                dgvStockDetails.Rows[i].Cells["PendingReqQty"].Value = dblRemQty;


            }
        }
        private void dgvStockDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStockDetails.CurrentRow.Cells["IssueQty"].Value == null)
            {
                MessageBox.Show("IssueQty cannot be Null");
                return;
            }
            else
            {
                RemCalculation();
            }
        }

        private void dgvIssueDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvIssueDetails.Rows.Count; i++)
            {
                dgvIssueDetails.Rows[i].Cells[19].Value = float.Parse(dgvIssueDetails.Rows[i].Cells[15].Value.ToString()) * float.Parse(dgvIssueDetails.Rows[i].Cells[18].Value.ToString());
                dgvIssueDetails.Rows[i].Cells[23].Value = float.Parse(dgvIssueDetails.Rows[i].Cells[15].Value.ToString()) * float.Parse(dgvIssueDetails.Rows[i].Cells[18].Value.ToString()) + float.Parse(dgvIssueDetails.Rows[i].Cells[20].Value.ToString()) - float.Parse(dgvIssueDetails.Rows[i].Cells[21].Value.ToString());
            }
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            frmDeptUnitWiseReqAdvanceSearch oadvancesearch = new frmDeptUnitWiseReqAdvanceSearch();
            oadvancesearch.ShowDialog();
        }

        private void txtDemandRequisition_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                populateDataToGridForIssue(dgvDemandReq, txtDemandRequisition.Text);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
