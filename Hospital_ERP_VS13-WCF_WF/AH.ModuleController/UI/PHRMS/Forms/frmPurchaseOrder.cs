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
    public partial class frmPurchaseOrder : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        List<SCMTree> purchaseRequisitions;
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }
       

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {

            txtPRNo.Select();
            purchaseRequisitions = phrSr.GetPRID().Select(c => new SCMTree {Date= c.RequisitionDate,ID= c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewPO, purchaseRequisitions);

            cboCostCategoey.DisplayMember = "CategoryName";
            cboCostCategoey.ValueMember = "CategoryID";
            cboCostCategoey.DataSource = phrSr.GetCostcategory("CostcategoryTreeview", "", "").ToList();

            cboPOType.DisplayMember = "Name";
            cboPOType.ValueMember = "ID";
            cboPOType.DataSource = phrSr.GetPOTypes();

            FormatTermsandConditions(dgvTermsandConditions);
            populateDataToGridForTerms(dgvTermsandConditions);

            FormatGridProd(dgvPRDetails);
            
            FormatGridProd(dgvPODetails);
            
            txtPODate.Text = DateTime.Now.ToString();
            dgvPRDetails.Columns[12].Visible = false;
            dgvPRDetails.Columns[13].Visible = false;
            dgvPRDetails.Columns[14].Visible = false;
            dgvPRDetails.Columns[15].Visible = false;
            dgvPRDetails.Columns[18].Visible = false;
            
        }       
        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
       
        }
        private void smartLabel11_Click(object sender, EventArgs e)
        {

        }
        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormatGridProd(DataGridView dtv)
        {
                      
            dtv.AutoGenerateColumns = false;
            dtv.EditMode = DataGridViewEditMode.EditOnKeystroke;
            //dtv.Location = new Point(lvPurchaseOrder.Location.X, lvPurchaseOrder.Location.Y);

            DataGridViewTextBoxColumn colDrugId = new DataGridViewTextBoxColumn();
            colDrugId.Name = "DRUGID";
            colDrugId.DataPropertyName = "DRUGID";
            colDrugId.Width = 0;
            colDrugId.Visible = false;
            dtv.Columns.Add(colDrugId);
            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn();
            colDrugTitle.Name = "Brand Name";
            colDrugTitle.DataPropertyName = "DRUGNAME";
            colDrugTitle.Width = 210;
            colDrugTitle.Visible = true;
            dtv.Columns.Add(colDrugTitle);

            DataGridViewTextBoxColumn colTypeID = new DataGridViewTextBoxColumn();
            colTypeID.Name = "TYPEID";
            colTypeID.DataPropertyName = "TYPEID";
            colTypeID.Width = 0;
            colTypeID.Visible = false;
            dtv.Columns.Add(colTypeID);

            DataGridViewTextBoxColumn colUnitID = new DataGridViewTextBoxColumn();
            colUnitID.Name = "UNITID";
            colUnitID.DataPropertyName = "UNITID";
            colUnitID.Width = 0;
            colUnitID.Visible = false;
            dtv.Columns.Add(colUnitID);

            DataGridViewTextBoxColumn colGroupID = new DataGridViewTextBoxColumn();
            colGroupID.Name = "GROUPID";
            colGroupID.DataPropertyName = "GROUPID";
            colGroupID.Width = 0;
            colGroupID.Visible = false;
            dtv.Columns.Add(colGroupID);

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
            
            DataGridViewTextBoxColumn colGroupTitle = new DataGridViewTextBoxColumn();
            colGroupTitle.Name = "Generic Name";
            colGroupTitle.DataPropertyName = "GROUPNAME";
            colGroupTitle.Width = 230;
            colGroupTitle.Visible = true;
            dtv.Columns.Add(colGroupTitle);

            DataGridViewTextBoxColumn colUnitName = new DataGridViewTextBoxColumn();
            colUnitName.Name = "Unit";
            colUnitName.DataPropertyName = "UNITNAME";
            colUnitName.Width = 0;
            colUnitName.Visible = false;
            dtv.Columns.Add(colUnitName);
           
            DataGridViewTextBoxColumn colPackName = new DataGridViewTextBoxColumn();
            colPackName.Name = "Unit Pack";
            colPackName.DataPropertyName = "PACKNAME";
            colPackName.Width = 0;
            colPackName.Visible = false;
            dtv.Columns.Add(colPackName);
                       

            DataGridViewTextBoxColumn POQuantity = new DataGridViewTextBoxColumn();
            POQuantity.Name = "ReqQty";
            POQuantity.DataPropertyName = "ReqQty";
            POQuantity.Width = 70;
            dtv.Columns.Add(POQuantity);

            DataGridViewTextBoxColumn RemQty = new DataGridViewTextBoxColumn();
            RemQty.Name = "RemQty";
            RemQty.DataPropertyName = "RemQty";
            RemQty.Width = 70;
            RemQty.ReadOnly = true;
            dtv.Columns.Add(RemQty);

            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 70;
            colUrate.DefaultCellStyle.Format = "0.00##";
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colamount = new DataGridViewTextBoxColumn();
            colamount.Name = "Amount";
            colamount.DataPropertyName = "Amount";
            colamount.Width = 80;
            colamount.ReadOnly = true;
            dtv.Columns.Add(colamount);

            DataGridViewTextBoxColumn colvat = new DataGridViewTextBoxColumn();
            colvat.Name = "Vat";
            colvat.DataPropertyName = "Vat";
            colvat.Width = 0;
            colvat.Visible = false;
            dtv.Columns.Add(colvat);

            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Disc";
            colDiscount.DataPropertyName = "Disc";
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
            checkBoxColumn.Width = 18;
            checkBoxColumn.Visible = true;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(19, checkBoxColumn);
        }

        private void populateDataToGridDrug(DataGridView dtv,string prid)
        {

            short index = 0;
            dgvPRDetails.Rows.Clear();
            dgvPRDetails.Visible = true;
            List<PurchaseRequisition> list = new List<PurchaseRequisition>();
            list.Clear();
            list.AddRange(phrSr.GetPRDetails(prid).ToList());

            foreach(PurchaseRequisition data in list)
            {
                string[] row = new string[] { data.DrugMaster.ID,
                                              data.DrugMaster.Name,
                                              data.DrugMaster.DrugPackType.ID,
                                              data.DrugMaster.DrugUnit.ID,
                                              data.DrugMaster.DrugGroup.ID,
                                              data.DrugMaster.DrugCompany.ID,
                                              data.DrugMaster.DrugCompany.Name,
                                              data.DrugMaster.DrugGroup.Name,
                                              data.DrugMaster.DrugUnit.Name,
                                              data.DrugMaster.DrugPackType.Name,
                                              data.RequisitionQty.ToString(),
                                              data.RemainingQty.ToString(),
                                              data.DrugMaster.Urate.ToString(),
                                              "0",
                                              data.DrugMaster.VAT.ToString(),
                                              data.DrugMaster.Discount.ToString(),
                                              data.DrugMaster.Rackrate.ToString(),
                                              data.DrugMaster.Slrate.ToString()

                };
                AddRowsToCollection(dgvPRDetails,row,index);
                index++;
            }
                      
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }
        private void dvProduction_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void AmountSummary()
        {
            //txtTotal.Text = (Utility.ParseFloat(txtPOQty.Text) * Utility.ParseFloat(txtURate.Text) + Utility.ParseFloat(txtvat.Text) - Utility.ParseFloat(txtDiscount.Text)).ToString();
        }

     

        private void dgvProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {
            //if (dtv.Rows.Count > 0)
            //{
            //    int currentRow = dtv.CurrentRow.Index;
            //    currentRow--;
            //    txtProductionID.Text = dtv["DRUGID", currentRow + 1].Value.ToString();
            //    txtProductionName.Text = dtv["DRUG NAME", currentRow + 1].Value.ToString();
            //    txtProductionPacketID.Text = dtv["TYPEID", currentRow + 1].Value.ToString();
            //    txtProductionUnitID.Text = dtv["UNITID", currentRow + 1].Value.ToString();
            //    txtProductionGroupID.Text = dtv["GROUPID", currentRow + 1].Value.ToString();
            //    txtProdGroupName.Text = dtv["Group", currentRow + 1].Value.ToString();
            //    txtProductionCompanyID.Text = dtv["COMPANYID", currentRow + 1].Value.ToString();
            //    txtProdCompName.Text = dtv["Company", currentRow + 1].Value.ToString();
            //    //txtProdUnitName.Text = dtv["Unit", currentRow + 1].Value.ToString();
            //    //txtProdPackName.Text = dtv["Unit Pack", currentRow + 1].Value.ToString();
            //    txtRate.Text = dtv["Rate", currentRow + 1].Value.ToString();
            //    labelVat.Text = dtv["Vat", currentRow + 1].Value.ToString();
            //    labelDiscount.Text = dtv["Discount", currentRow + 1].Value.ToString();
            //    labelRackrate.Text = dtv["Rackrate", currentRow + 1].Value.ToString();
            //    labelSlrate.Text = dtv["SlRate", currentRow + 1].Value.ToString();
            //    //dtv.Visible = false;
            //    txtProductionID.Focus();

            //}
            //else
            //{
            //    //dtv.Visible = false;
            //    txtProductionID.Focus();
            //}

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtPR", "txtSupplier", "txtDeliveryNote" };
            Control control = Utility.ReqFieldValidator(this, vf);
            
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(dgvPODetails.Rows.Count == 0)
            {
                MessageBox.Show("Please select Drugs");
                return;
            }
            if (txtDeliveryDate.Text == "  /  /" || Convert.ToDateTime(txtDeliveryDate.Text) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                MessageBox.Show("Delivery Date cannot be Empty");
                txtDeliveryDate.Select();
                return;
               
            }
           
            for (int i = 0; i < dgvPODetails.Rows.Count; i++)
            {
                if (dgvPODetails.Rows[i].Cells["DRUGID"].Value == null ||
                    dgvPODetails.Rows[i].Cells["COMPANYID"].Value == null ||
                    dgvPODetails.Rows[i].Cells["GROUPID"].Value == null ||
                    dgvPODetails.Rows[i].Cells["UNITID"].Value == null ||
                    dgvPODetails.Rows[i].Cells["TYPEID"].Value == null ||
                    dgvPODetails.Rows[i].Cells["ReqQty"].Value == null ||
                    dgvPODetails.Rows[i].Cells["Rate"].Value == null ||
                    dgvPODetails.Rows[i].Cells["Vat"].Value == null ||
                    dgvPODetails.Rows[i].Cells["Disc"].Value == null)
                {
                    MessageBox.Show("PODetails value cannot be null");
                    return;
                }
                if (Convert.ToInt32(dgvPODetails.Rows[i].Cells["ReqQty"].Value) <= 0)
                {
                    MessageBox.Show("Quantity cannot be or less than zero");
                    return;
                }
                if (float.Parse(dgvPODetails.Rows[i].Cells["Rate"].Value.ToString()) <= 0)
                {
                    MessageBox.Show("Rates cannot be or less than zero");
                    return;
                }
                if (Convert.ToInt32(dgvPODetails.Rows[i].Cells["ReqQty"].Value) > Convert.ToInt32(dgvPODetails.Rows[i].Cells["RemQty"].Value))
                {
                    MessageBox.Show("PO Qty can not be more than RemQty");
                    return;
                }
            }

            int icount = 0;
            foreach (DataGridViewRow row in dgvTermsandConditions.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    icount = icount + 1;

                }
            }
            if (icount < 1)
            {
                MessageBox.Show("Please select terms and conditions");
                return;
            }
            try
            {
               
                PurchaseOrder po = this.populatePurchaseOrder();
                string i = phrSr.SavePurchaseOrder(po);
                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else 
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPOID.Text = i;
                    PrintReport(i);
                    btnSave.Enabled = false;
                    chekbox.Checked = false;
                    dgvPRDetails.Rows.Clear();
                    dgvPODetails.Rows.Clear();
                    treeviewPO.Nodes.Clear();
                    List<SCMTree> purchaseRequisitions = phrSr.GetPRID().Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
                    Utility.PopulateTreeSCM(treeviewPO, purchaseRequisitions);
                    foreach (DataGridViewRow dr in dgvTermsandConditions.Rows)
                    {
                        dr.Cells[0].Value = false;//sıfırın
                    }

                    txtPRNo.Text = string.Empty;

                    txtPharmacyID.Text = string.Empty;
                    txtPharmacyName.Text = string.Empty;
                    txtSupplierID.Text = string.Empty;
                    txtSupplierName.Text = string.Empty;
                    txtDeliveryDate.Text = string.Empty;
                    txtDeliveryNote.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                    lblTotalItem.Text = "0";
                    lblNetTotal.Text = "0";
                    //RefreshGrid();
                    //btnNew.PerformClick();
                    //cboBuilding.Focus();
                    //lvPurchaseOrder.Items.Clear();
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
        private PurchaseOrder populatePurchaseOrder()
        {
            PurchaseOrder po = new PurchaseOrder();
            //po.PRId = txtPRNo.Text;
            po.TransactionType = "PO";
            po.Type = cboPOType.SelectedValue.ToString();            
            po.Remarks = txtRemarks.Text;
            po.PODate = DateTime.Parse(txtPODate.Text);
            po.Deliverydate = DateTime.Parse(txtDeliveryDate.Text);
            po.Deliverynote = txtDeliveryNote.Text;

            PurchaseRequisition oreq = new PurchaseRequisition();
            oreq.ID = txtPRNo.Text;

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            oreq.CostCategoryTreeview = ocostcenter;

            po.PurchaseRequisition = oreq;

            Warehouse ph = new Warehouse();
            ph.TypeID = txtPharmacyID.Text;
            po.Warehouse = ph;

            Supplier sp = new Supplier();
            sp.ID = txtSupplierID.Text;
            po.Supplier = sp;


            
            string prString = "";

            foreach (DataGridViewRow dr in dgvPODetails.Rows)
            {
                prString += dr.Cells[0].Value.ToString() + "," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[12].Value.ToString() + "," + dr.Cells[14].Value.ToString() + "," + dr.Cells[15].Value.ToString() + "," + dr.Cells[10].Value.ToString() + "," + dr.Cells[10].Value.ToString();
                prString += ";";
            }
           

            po.POString = prString;

            string termstring = "";

            for (int row = 0; row < dgvTermsandConditions.Rows.Count; row++)
            {

                if (Convert.ToBoolean(dgvTermsandConditions.Rows[row].Cells[0].Value) == true)
                {
                    termstring += dgvTermsandConditions.Rows[row].Cells[1].Value.ToString();
                    termstring += ":";
                }
                //}
            }

            po.TermsDetails = termstring;

            

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            po.EntryParameter = ep;

            return po;
        }
        private void PrintReport(string poid)
        {
            frmReportViewer ofrmreportviewer = new frmReportViewer();
            ofrmreportviewer.selector = ViewerSelector.PODetails;
            ofrmreportviewer.POID = poid;
            ofrmreportviewer.ReportTitle = "PURCHASE ORDER";
            ofrmreportviewer.ViewReport();
        }
       
        private void RefreshGrid()
        {
            //txtProductionID.Text = string.Empty;
            //txtProductionName.Text = string.Empty;
            //txtProductionPacketID.Text = string.Empty;
            //txtProductionUnitID.Text = string.Empty;
            //txtProductionGroupID.Text = string.Empty;
            //txtProductionCompanyID.Text = string.Empty;           
            ////txtExpDate.Text = string.Empty;
            //txtURate.Text = string.Empty;
            //txtvat.Text = string.Empty;
            //txtDiscount.Text = string.Empty;           
            //txtPOQty.Text = string.Empty;
            //txtTotal.Text = string.Empty;
        }
      
       
       
        private void smartLabel5_Click(object sender, EventArgs e)
        {

        }

        private void smartLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            AmountSummary();
        }

        private void txtURate_TextChanged(object sender, EventArgs e)
        {

            //if (Utility.ParseFloat(txtURate.Text) > Utility.ParseFloat(labelRate.Text))
            //{
            //    DialogResult Dgr = MessageBox.Show("Rate is more than The Item Rate " ,"Do you want to change ? ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //    if (Dgr == DialogResult.Yes)
            //    {
            //        ItemRates rt = this.populateItemRate();
            //        short i = phrSr.SaveItemRates(rt);
                   
            //    }
            //    else if(Dgr == DialogResult.No)
            //    {
            //        txtURate.Text = string.Empty;
            //    }
              
            //}
            //AmountSummary();
           
        }
       

        //private ItemRates populateItemRate()
        //{
        //    ItemRates itm = new ItemRates();
        //    itm.Urate = Single.Parse(txtURate.Text);
        //    itm.VAT = Single.Parse(labelVat.Text);
        //    itm.Discount = Single.Parse(labelDiscount.Text);
        //    itm.Rackrate = Single.Parse(labelRackrate.Text);
        //    itm.Slrate = Single.Parse(labelSlrate.Text);

        //    Pharmacy phr = new Pharmacy();
        //    phr.PharmacyID = "01";
        //    itm.Pharmacy = phr;

        //    DrugMaster mas = new DrugMaster();
        //    mas.ID = txtProductionID.Text;


        //    DrugCompany dc = new DrugCompany();
        //    dc.ID = txtProductionCompanyID.Text;
        //    mas.DrugCompany = dc;

        //    DrugGroup dg = new DrugGroup();
        //    dg.ID = txtProductionGroupID.Text;
        //    mas.DrugGroup = dg;

        //    DrugUnit un = new DrugUnit();
        //    un.ID = txtProductionUnitID.Text;
        //    mas.DrugUnit = un;

        //    DrugPackType pac = new DrugPackType();
        //    pac.ID = txtProductionPacketID.Text;
        //    mas.DrugPackType = pac;

        //    itm.DrugMaster = mas;

        //    EntryParameter ep = new EntryParameter();
        //    ep.CompanyID = Utility.CompanyID;
        //    ep.EntryBy = Utility.UserId;
        //    ep.LocationID = Utility.LocationID;
        //    ep.MachineID = Utility.MachineID;
        //    itm.EntryParameter = ep;


        //    return itm;
        //}
       
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            AmountSummary();
        }

        private void smartLabel25_Click(object sender, EventArgs e)
        {

        }

        private void txtPOQty_TextChanged(object sender, EventArgs e)
        {
            AmountSummary();
        }

       
        private void txtTotal_KeyUp(object sender, KeyEventArgs e)
        {
            AmountSummary();
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            AmountSummary();
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmItemRates rate = new frmItemRates();
            rate.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

       
        private void pnlMain_Click(object sender, EventArgs e)
        {
            dgvProduction.Visible = false;
        }

        private void txtSupplier_TextChanged_3(object sender, EventArgs e)
        {
            //txtSupplierName.Text = string.Empty;
        }

        private void dgvProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvSupplierList_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void LoadListData()
        {
            txtPharmacyID.DataBindings.Clear();
            txtPharmacyName.DataBindings.Clear();
            txtSupplierID.DataBindings.Clear();
            txtSupplierName.DataBindings.Clear();
            labelRate.DataBindings.Clear();
            txtPharmacyID.DataBindings.Add("Text", phrSr.GetPRDetails(txtPRNo.Text).ToList(), "Warehouse.TypeID");
            txtPharmacyName.DataBindings.Add("Text", phrSr.GetPRDetails(txtPRNo.Text).ToList(), "Warehouse.TypeName");
            txtSupplierID.DataBindings.Add("Text", phrSr.GetPRDetails(txtPRNo.Text).ToList(), "Supplier.ID");
            txtSupplierName.DataBindings.Add("Text", phrSr.GetPRDetails(txtPRNo.Text).ToList(), "Supplier.Name");
            labelRate.DataBindings.Add("Text", phrSr.GetPRDetails(txtPRNo.Text).ToList(), "DrugMaster.Urate");
        }
        private void trList2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //txtPRNo.Text = treeviewPO.SelectedNode.Text;
            //populateDataToGridDrug(dgvPRDetails,txtPRNo.Text);
            //LoadListData();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            
            dgvPODetails.Rows.Clear();

            //FormatData(dgvIssueReturn);
            //string message = string.Empty;
            foreach (DataGridViewRow row in dgvPRDetails.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    //foreach(DataGridViewRow oitem in dgvIssueDetails.Rows)
                    //{
                    for (int k = 0; k < dgvPRDetails.Rows.Count; k++)
                    {
                        if (Convert.ToBoolean(dgvPRDetails.Rows[k].Cells["checkBoxColumn"].Value) == true)
                        {
                            if (Convert.ToInt32(dgvPRDetails.Rows[k].Cells[11].Value.ToString()) == 0)
                            {
                                MessageBox.Show("Remaining quantity is zero");
                                return;
                            }

                        }
                    }
                    dgvPODetails.Rows.Add(row.Cells[0].Value.ToString(),
                                            row.Cells[1].Value.ToString(),
                                            row.Cells[2].Value.ToString(),
                                            row.Cells[3].Value.ToString(),
                                            row.Cells[4].Value.ToString(),
                                            row.Cells[5].Value.ToString(),
                                            row.Cells[6].Value.ToString(),
                                            row.Cells[7].Value.ToString(),
                                            row.Cells[8].Value.ToString(),
                                            row.Cells[9].Value.ToString(),
                                            row.Cells[11].Value.ToString(),
                                            row.Cells[11].Value.ToString(),
                                            row.Cells[12].Value.ToString(),
                                            row.Cells[13].Value.ToString(),
                                            row.Cells[14].Value.ToString(),
                                            row.Cells[15].Value.ToString(),
                                            row.Cells[16].Value.ToString(),
                                            row.Cells[17].Value.ToString(),
                                            row.Cells[18].Value.ToString()
                                        );
                    dgvPODetails.Columns["checkBoxColumn"].Visible = false;
                    dgvPODetails.Columns[6].Visible = false;
                    this.dgvPODetails.Focus();
                }
            }
            dgvPODetails.Columns["ReqQty"].HeaderText = "PO Qty";
            CalculateQty();
        }

        private void txtPRNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                populateDataToGridDrug(dgvPRDetails, txtPRNo.Text);
                LoadListData();
                //txtSupplier.Select();
            }
        }

        private void dgvPODetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (e.ColumnIndex == dgvPODetails.Columns["ReqQty"].Index)
            {
                dgvPODetails.Rows[e.RowIndex].ErrorText = "";
                int newInteger;

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgvPODetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (!int.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgvPODetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }
            //if (e.ColumnIndex == dgvPODetails.Columns["Rate"].Index)
            //{
            //    dgvPODetails.Rows[e.RowIndex].ErrorText = "";
            //    float newInteger;

            //    // Don't try to validate the 'new row' until finished  
            //    // editing since there 
            //    // is not any point in validating its initial value. 
            //    if (dgvPODetails.Rows[e.RowIndex].IsNewRow) { return; }
            //    if (!float.TryParse(e.FormattedValue.ToString(),
            //        out newInteger) || newInteger <= 0)
            //    {
            //        e.Cancel = true;
            //        dgvPODetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
            //    }
            //}
        }
        

        private void CalculateQty()
        {
            lblTotalItem.Text = dgvPODetails.Rows.Count.ToString();
            float sum = 0;
            for (int i = 0; i < dgvPODetails.Rows.Count; i++)
            {
                dgvPODetails.Rows[i].Cells[13].Value = float.Parse(dgvPODetails.Rows[i].Cells[10].Value.ToString()) * float.Parse(dgvPODetails.Rows[i].Cells[12].Value.ToString());
                sum += float.Parse(dgvPODetails.Rows[i].Cells[13].Value.ToString());
                lblNetTotal.Text = sum.ToString();
                //dgvPODetails.Rows[i].Cells[21].Value = Convert.ToInt32(dgvPODetails.Rows[i].Cells[15].Value) * Convert.ToInt32(dgvPODetails.Rows[i].Cells[17].Value) + Convert.ToInt32(dgvPODetails.Rows[i].Cells[19].Value) - Convert.ToInt32(dgvPODetails.Rows[i].Cells[20].Value);
            }
        }
        private void dgvPODetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //setvaluesFromList(dgvPODetails, sender);

            CalculateQty();
        }

        private void treeviewPO_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strPRID = treeviewPO.SelectedNode.Text;
           
            txtPRNo.Text = "";
            txtPRNo.Text = string.Empty;
            txtPharmacyID.Text = string.Empty;
            txtPharmacyName.Text = string.Empty;
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            dgvPRDetails.Rows.Clear();
           
            foreach (SCMTree objscm in purchaseRequisitions)
            {
                if (strPRID == objscm.ID)
                {
                    txtPRNo.Text = strPRID;
                    populateDataToGridDrug(dgvPRDetails, txtPRNo.Text);
                    LoadListData();
                }
            }
            btnSave.Enabled = true;           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow dr in dgvTermsandConditions.Rows)
            {
                dr.Cells[0].Value = false;//sıfırın
            }
            txtPOID.Text = string.Empty;
            txtPRNo.Text = string.Empty;
          
            txtPharmacyID.Text = string.Empty;
            txtPharmacyName.Text = string.Empty;
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtDeliveryDate.Text = string.Empty;
            txtDeliveryNote.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            dgvPRDetails.Rows.Clear();
            dgvPODetails.Rows.Clear();
            lblTotalItem.Text = "0";
            lblNetTotal.Text = "0";
            btnSave.Enabled = true;

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

        private void dgvPODetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 18)
            {
                int selRowIndex = e.RowIndex;
                if (selRowIndex < 0)
                {
                    dgvPODetails.Rows.Clear();
                }
                else
                {
                    dgvPODetails.Rows.RemoveAt(selRowIndex);
                }

            }
            CalculateQty();
        }

        private void txtSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void FormatTermsandConditions(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Visible = true;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(0, checkBoxColumn);



            //Rectangle rect = dtv.GetCellDisplayRectangle(0, -1, true);
            //rect.Y = 3;
            //rect.X = rect.Location.X + (rect.Width / 4);
            //CheckBox checkboxHeader = new CheckBox();
            //checkboxHeader.Name = "checkboxHeader";
            ////datagridview[0, 0].ToolTipText = "sdfsdf";
            //checkboxHeader.Size = new Size(18, 18);
            //// checkboxHeader.Location = rect.Location;
            //checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
            //dtv.Controls.Add(checkboxHeader);

            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "ID";
            colID.DataPropertyName = "ID";
            colID.Width = 0;
            colID.Visible = false;
            dtv.Columns.Add(colID);

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "Name";
            colName.DataPropertyName = "Name";
            colName.Width = 500;
            colName.Visible = true;
            dtv.Columns.Add(colName);

            DataGridViewTextBoxColumn colIsAutoSelected = new DataGridViewTextBoxColumn();
            colIsAutoSelected.Name = "IsAutoSelected";
            colIsAutoSelected.DataPropertyName = "IsAutoSelected";
            colIsAutoSelected.Width = 0;
            colIsAutoSelected.Visible = false;
            dtv.Columns.Add(colIsAutoSelected);

            DataGridViewTextBoxColumn colIsBold = new DataGridViewTextBoxColumn();
            colIsBold.Name = "colIsBold";
            colIsBold.DataPropertyName = "colIsBold";
            colIsBold.Width = 0;
            colIsBold.Visible = false;
            dtv.Columns.Add(colIsBold);

            DataGridViewTextBoxColumn colRemarks = new DataGridViewTextBoxColumn();
            colRemarks.Name = "Remarks";
            colRemarks.DataPropertyName = "Remarks";
            colRemarks.Width = 0;
            colRemarks.Visible = false;
            dtv.Columns.Add(colRemarks);

            DataGridViewTextBoxColumn colPriority = new DataGridViewTextBoxColumn();
            colPriority.Name = "Priority";
            colPriority.DataPropertyName = "Priority";
            colPriority.Width = 0;
            colPriority.Visible = false;
            dtv.Columns.Add(colPriority);


        }

        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox headerBox = ((CheckBox)dgvTermsandConditions.Controls.Find("checkboxHeader", true)[0]);
            //if (headerBox.Checked == true)
            //{
            //    //CheckBox headerBox = ((CheckBox)dgvTermsandConditions.Controls.Find("checkboxHeader", true)[0]);
            //    for (int i = 0; i == 0; i++)
            //    {
            //        Convert.ToBoolean(dgvTermsandConditions.Rows[i].Cells[0].Value = true);
            //    }
            //}
            //else

            //    {
            //        for (int i = 0; i < dgvTermsandConditions.RowCount; i++)
            //        {
            //             Convert.ToBoolean(dgvTermsandConditions.Rows[i].Cells[0].Value = false);
            //        }

            //    }
        }

        private void populateDataToGridForTerms(DataGridView dtv)
        {


            dgvTermsandConditions.Visible = true;
            List<TermsAndConditions> list = new List<TermsAndConditions>();
            list.AddRange(phrSr.GetTermsandCondition().ToList());

            dgvTermsandConditions.DataSource = list.Select(data => new
            {
                ID = data.ID,
                Name = data.Name,
                IsAutoSelected = data.IsAutoSelected

            }).ToList();
            this.dgvTermsandConditions.Focus();
        }

        private void dgvPODetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPODetails.Columns[e.ColumnIndex].Name.Equals("ReqQty"))
            {
                Int32 intValue;
                if (dgvPODetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (Int32.TryParse((String)e.Value, out intValue) &&
                    (intValue < 0))
                {

                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;

                }
            }
            if (dgvPODetails.Columns[e.ColumnIndex].Name.Equals("Rate"))
            {
                Int32 intValue;
                if (dgvPODetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (Int32.TryParse((String)e.Value, out intValue) &&
                    (intValue < 0))
                {

                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;

                }
            }
            if (dgvPODetails.Columns[e.ColumnIndex].Name.Equals("Vat"))
            {
                Int32 intValue;
                if (dgvPODetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (Int32.TryParse((String)e.Value, out intValue) &&
                    (intValue < 0))
                {

                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;

                }
            }
            if (e.ColumnIndex == 0 && e.RowIndex != this.dgvPODetails.NewRowIndex)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("0.00##");
            }
        }

        private void btnAddTerms_Click(object sender, EventArgs e)
        {
            frmTermsConditions otermsconditions = new frmTermsConditions();
            otermsconditions.ShowDialog();

        }

        private void btnRefreshTerms_Click(object sender, EventArgs e)
        {
            populateDataToGridForTerms(dgvTermsandConditions);
        }

        private void chekbox_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox.Checked==true)
            {
                //CheckBox headerBox = ((CheckBox)dgvTermsandConditions.Controls.Find("checkboxHeader", true)[0]);
                for (int i = 0;i < dgvTermsandConditions.RowCount; i++)
                {
                    Convert.ToBoolean(dgvTermsandConditions.Rows[i].Cells[0].Value = true);
                }
            }
            else
            {
                for (int i = 0; i < dgvTermsandConditions.RowCount; i++)
                {
                    Convert.ToBoolean(dgvTermsandConditions.Rows[i].Cells[0].Value = false);
                }

            }
        }

        private void dgvTermsandConditions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkboxPR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxPR.Checked == true)
            {

                //CheckBox headerBox = ((CheckBox)dgvTermsandConditions.Controls.Find("checkboxHeader", true)[0]);
                for (int i = 0; i < dgvPRDetails.RowCount; i++)
                {
                    Convert.ToBoolean(dgvPRDetails.Rows[i].Cells["checkBoxColumn"].Value = true);
                }
            }
            else
            {
                for (int i = 0; i < dgvPRDetails.RowCount; i++)
                {
                    Convert.ToBoolean(dgvPRDetails.Rows[i].Cells["checkBoxColumn"].Value = false);
                }

            }
        }
        
    }
}
