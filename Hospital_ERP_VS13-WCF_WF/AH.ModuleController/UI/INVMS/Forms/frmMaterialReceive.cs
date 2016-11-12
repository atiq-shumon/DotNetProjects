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
using AtiqsControlLibrary;
using System.Text.RegularExpressions;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmMaterialReceive : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        private DateTimePicker oDateTimePicker;
        private int CurrentIndex;
        List<SCMTree> purchaseorder;
        SmartDateTextBox dateBox = new SmartDateTextBox();
        string temp2;
        GroupBox dummy;
        int counter, currentSelection = 0;
        private bool button1WasClicked = false;
        //public delegate void FormatData(DataGridView dtv);


        public frmMaterialReceive()
        {
            InitializeComponent();
        }
        private void frmMaterialReceive_Load(object sender, EventArgs e)
        {
            txtMrrDate.Text = DateTime.Now.ToString();

            purchaseorder = invSr.GetPONumbers().Select(c => new SCMTree { Date = c.PODate, ID = c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewPurchaseOrder, purchaseorder);

            cboCostCategoey.DisplayMember = "CategoryName";
            cboCostCategoey.ValueMember = "CategoryID";
            cboCostCategoey.DataSource = invSr.GetCostcategory("CostcategoryTreeview", "", "").ToList();

            FormatGridProd(dgvPODetails);
            FormatGridProd(dgvMrrDetails);
            dgvPODetails.Columns[16].Visible = false;
            dgvPODetails.Columns[24].Visible = false;
            dgvPODetails.Columns[23].Visible = false;
            progressBar1.Visible = false;

            dgvMrrDetails.Controls.Add(dateBox);
            dateBox.Visible = false;

            dateBox.Leave += this.dateBox_ValueChanged;
            dateBox.KeyUp += this.dateBox_keyUP;
            dateBox.KeyDown += this.dateBox_keyDown;
            //DG.AllowUserToAddRows = false;

        }
        private void dateBox_keyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode == Keys.NumPad0)
            {
                dateBox.Text = temp2;
                dateBox.Select();
                if (currentSelection == 3)
                {
                    dateBox.SelectionStart = currentSelection;
                }
                //temp.Select(6, 1);
                temp2 = "";
                //temp.SelectionLength = 0;
                // temp.SelectionStart = temp.Text.Length;

                //temp.SelectionStart = 0;
                //temp.Select();
            }
            temp2 = "";
        }
        private void dateBox_keyUP(object sender, KeyEventArgs e)
        {
            currentSelection = dateBox.SelectionStart;
            temp2 = dateBox.Text;
        }


        private void dateBox_ValueChanged(object sender, EventArgs e)
        {
            dgvMrrDetails.CurrentCell.Value = dateBox.Text;

        }
        private void AmountSummary()
        {
            //txtTotal.Text = (Utility.ParseFloat(txtMrrQuantity.Text) * Utility.ParseFloat(txtURate.Text) + Utility.ParseFloat(txtvat.Text) - Utility.ParseFloat(txtDiscount.Text)).ToString();
        }
     
        private void LoadPODetailsByID()
        {
            
            txtPRID.DataBindings.Clear();
            txtStoreID.DataBindings.Clear();
            txtStoreName.DataBindings.Clear();
            txtSupplierID.DataBindings.Clear();
            txtSupplierName.DataBindings.Clear();

            txtStoreID.DataBindings.Add("Text", invSr.GetPODetails(txtPOID.Text).ToList(), "Warehouse.TypeID");
            txtStoreName.DataBindings.Add("Text", invSr.GetPODetails(txtPOID.Text).ToList(), "Warehouse.TypeName");
            txtSupplierID.DataBindings.Add("Text", invSr.GetPODetails(txtPOID.Text).ToList(), "Supplier.ID");
            txtSupplierName.DataBindings.Add("Text", invSr.GetPODetails(txtPOID.Text).ToList(), "Supplier.Name");
            txtPRID.DataBindings.Add("Text", invSr.GetPODetails(txtPOID.Text).ToList(), "PurchaseRequisition.ID");

            txtStoreType.DataBindings.Clear();
            txtStoreType.DataBindings.Add("Text", invSr.GetPODetails(txtPOID.Text).ToList(), "ItemOrder.ItemMaster.StoreType.strTypeID");
            
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadPODetailsByID();
            //LoadListView();
        }

        private void lvMaterialReceive_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void RefreshGrid()
        {
            txtPRID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;            
            txtSupplierID.Text = string.Empty;
            txtChallanNo.Text = string.Empty;
            txtChallanDate.Text = string.Empty;
            txtVoucherNo.Text = string.Empty;
            txtMrrType.Text = string.Empty;
          
        }
        private void txtMrrQuantity_TextChanged(object sender, EventArgs e)
        {
            AmountSummary();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtChallanNo",  "cboCostCategoey", "cboCostCenter" };
            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            for (int i = 0; i < dgvMrrDetails.Rows.Count; i++)
            {
                if (dgvMrrDetails.Rows[i].Cells["ItemID"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["CompanyID"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["GroupID"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["UnitID"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["TypeID"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["ModelID"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["BrandID"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["StoreTypeID"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["MajorGroup"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["POQty"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["GRNQty"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["PORate"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["Vat"].Value == null &&
                    dgvMrrDetails.Rows[i].Cells["Disc"].Value == null)
                {
                    MessageBox.Show("GRN Details value cannot be null");
                    return;
                }
              

            }
            for (int k = 0; k < DG.Rows.Count -1; k++)
            {
                if (DG.Rows[k].Cells[12].Value == null)
                {
                    MessageBox.Show("Please fill Empty field");
                    return;
                }
                if (DG.Rows[k].Cells[10].Value == null)
                {
                    MessageBox.Show("Please Select Service Provoder");
                    return;
                }
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
                        txtMrrID.Text = i;                       
                        PrintReport(i);
                        //progressBar1.Visible = false;
                        btnSave.Enabled = false;
                        treeviewPurchaseOrder.Nodes.Clear();
                        dgvPODetails.Rows.Clear();
                        dgvMrrDetails.Rows.Clear();
                        dateBox.Visible = false;
                        chekbox.Checked = false;
                        txtItemID.Text = "";
                        txtItemName.Text = "";
                        txtGrnQty.Text = "";
                        txtRemQty.Text = "";
                        txtExpDatetimepicker.Text = "";
                        txtChallanNo.Text = string.Empty;
                        txtMrrType.Text = string.Empty;
                        txtRemarks.Text = string.Empty;
                        txtStoreID.Text = string.Empty;
                        txtStoreName.Text = string.Empty;
                        txtSupplierID.Text = string.Empty;
                        txtSupplierName.Text = string.Empty;
                        List<SCMTree> purchaseorder = invSr.GetPONumbers().Select(c => new SCMTree { Date = c.PODate, ID = c.ID }).ToList();
                        Utility.PopulateTreeSCM(treeviewPurchaseOrder, purchaseorder);
                        //for (int j = 0; j < dgvMrrDetails.Rows.Count; j++)
                        //{
                        //    if (Convert.ToInt32(dgvMrrDetails.Rows[j].Cells["IsSerial"].Value.ToString()) == 1)
                        //    {
                        //        frmAssetTracker oasset = new frmAssetTracker(i);
                        //        oasset.ShowDialog();
                        //    }

                        //}
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
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 10000;
            progressBar1.Minimum = 100;
            progressBar1.Step = 1;


            for (int j = 0; j < 10000; j++)
            {
                int percent = (int)(((double)(progressBar1.Value - progressBar1.Minimum) / (double)(progressBar1.Maximum - progressBar1.Minimum)) * 100);

                using (Graphics gr = progressBar1.CreateGraphics())
                {

                    gr.DrawString(percent.ToString() + "%",

                        SystemFonts.DefaultFont,

                        Brushes.Black,

                        new PointF(progressBar1.Width / 2 - (gr.MeasureString(percent.ToString() + "%",

                            SystemFonts.DefaultFont).Width / 2.0F),

                        progressBar1.Height / 2 - (gr.MeasureString(percent.ToString() + "%",

                            SystemFonts.DefaultFont).Height / 2.0F)));

                }

                //Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void PrintReport(string mrid)
        {
            frmReportViewer ofrmreportviewer = new frmReportViewer();
            ofrmreportviewer.selector = ViewerSelector.MrrReport;
            ofrmreportviewer.MrrID = mrid;
            ofrmreportviewer.ReportTitle = "MRR Report";
            ofrmreportviewer.ViewReport();
        }
        private MaterialReceive populateMatReceive()
        {
            MaterialReceive mr = new MaterialReceive();
            mr.ID = txtMrrID.Text;

            mr.TransactionType = "MO";
            mr.MrrDate = DateTime.Parse(txtMrrDate.Text);
            mr.MrrType = "1";
            //mr.MrrQuantity = Single.Parse(txtMrrQuantity.Text);
            mr.ChallanNo = txtChallanNo.Text;
            mr.ChallanDate = DateTime.Parse(txtChallanDate.Text);
            mr.VoucherNo = "V1234";
            mr.Remarks = txtRemarks.Text;

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            mr.CostCategoryTreeview = ocostcenter;

            PurchaseRequisition req = new PurchaseRequisition();
            req.ID = txtPRID.Text;
            mr.PurchaseRequisition = req;

            PurchaseOrder po = new PurchaseOrder();
            po.ID = txtPOID.Text;
            
            StoreTypeSCM strtype = new StoreTypeSCM();
            strtype.strTypeID = txtStoreType.Text;
            po.StoreType = strtype;
            mr.PurchaseOrder = po;

            Warehouse ostore = new Warehouse();
            ostore.TypeID = txtStoreID.Text;
            mr.Warehouse = ostore;

            Supplier supp = new Supplier();
            supp.ID = txtSupplierID.Text;
            mr.Supplier = supp;
            //CultureInfo us = new CultureInfo("en-US");   

            string MrrString = "";

            foreach (DataGridViewRow dr in dgvMrrDetails.Rows)
            {
                MrrString += dr.Cells[0].Value.ToString() + "," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[7].Value.ToString() + "," + dr.Cells[8].Value.ToString() + "," + dr.Cells[9].Value.ToString() + "," + dr.Cells[18].Value.ToString() + "," + dr.Cells[19].Value.ToString() + "," + dr.Cells[20].Value.ToString() + "," + dr.Cells[21].Value.ToString() + "," + dr.Cells[14].Value.ToString() + "," + dr.Cells[15].Value.ToString() + "," + dr.Cells[16].Value.ToString() + "," + dr.Cells[23].Value.ToString();
                MrrString += ";";
            }
            mr.MrrDetails = MrrString;

            if (DG.Rows.Count > 0)
            {
                string assetstring = "";

                foreach (DataGridViewRow drs in DG.Rows)
                {
                    if (drs.Cells[12].Value != null)
                    {
                        assetstring += drs.Cells[13].Value.ToString() + "," + drs.Cells[2].Value.ToString() + "," + drs.Cells[3].Value.ToString() + "," + drs.Cells[4].Value.ToString() + "," + drs.Cells[5].Value.ToString() + "," + drs.Cells[6].Value.ToString() + "," + drs.Cells[7].Value.ToString() + "," + drs.Cells[8].Value.ToString() + "," + drs.Cells[9].Value.ToString() + "," + drs.Cells[0].Value.ToString() + "," + drs.Cells[11].Value.ToString() + "," + drs.Cells[12].Value.ToString() + "," + drs.Cells[10].Value.ToString();
                        assetstring += ";";
                    }
                }

                mr.AssetTracker = assetstring;
            }
            else
            {
                mr.AssetTracker = "0";
            }

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            mr.EntryParameter = ep;

            return mr;
        }

        private void FormatGridProd(DataGridView dtv)
        {


            dtv.AutoGenerateColumns = false;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

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
            groupname.Width = 150;
            groupname.Visible = true;
            groupname.ReadOnly = true;
            dtv.Columns.Add(groupname);

            DataGridViewTextBoxColumn compname = new DataGridViewTextBoxColumn();
            compname.Name = "Company";
            compname.DataPropertyName = "Company";
            compname.Width = 140;
            compname.Visible = true;
            compname.ReadOnly = true;
            dtv.Columns.Add(compname);


            DataGridViewTextBoxColumn brandname = new DataGridViewTextBoxColumn();
            brandname.Name = "Brand";
            brandname.DataPropertyName = "Brand";
            brandname.Width = 0;
            brandname.Visible = false;
            brandname.ReadOnly = true;
            dtv.Columns.Add(brandname);

            DataGridViewTextBoxColumn modelname = new DataGridViewTextBoxColumn();
            modelname.Name = "Model";
            modelname.DataPropertyName = "Model";
            modelname.Width = 0;
            modelname.Visible = false;
            modelname.ReadOnly = true;
            dtv.Columns.Add(modelname);

            DataGridViewTextBoxColumn ReqQty = new DataGridViewTextBoxColumn();
            ReqQty.Name = "ReqQty";
            ReqQty.DataPropertyName = "ReqQty";
            ReqQty.Width = 0;
            ReqQty.Visible = false;
            ReqQty.ReadOnly = false;
            dtv.Columns.Add(ReqQty);

            DataGridViewTextBoxColumn POQuantity = new DataGridViewTextBoxColumn();
            POQuantity.Name = "POQty";
            POQuantity.DataPropertyName = "POQty";
            POQuantity.Width = 50;
            POQuantity.Visible = true;
            POQuantity.ReadOnly = true;
            dtv.Columns.Add(POQuantity);

            DataGridViewTextBoxColumn colMrrQty = new DataGridViewTextBoxColumn();
            colMrrQty.Name = "GRNQty";
            colMrrQty.DataPropertyName = "GRNQty";
            colMrrQty.Width = 70;
            colMrrQty.Visible = true;
            colMrrQty.ReadOnly = true;
            dtv.Columns.Add(colMrrQty);

            DataGridViewTextBoxColumn colremQty = new DataGridViewTextBoxColumn();
            colremQty.Name = "RemQty";
            colremQty.DataPropertyName = "RemQty";
            colremQty.Width = 60;
            colremQty.Visible = true;
            colremQty.ReadOnly = true;
            dtv.Columns.Add(colremQty);

            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "PORate";
            colUrate.DataPropertyName = "PORate";
            colUrate.Width = 60;
            colUrate.Visible = true;
            colUrate.ReadOnly = true;
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colsalerate = new DataGridViewTextBoxColumn();
            colsalerate.Name = "SaleRate";
            colsalerate.DataPropertyName = "SaleRate";
            colsalerate.Width = 0;
            colsalerate.Visible = false;
            colsalerate.ReadOnly = true;
            dtv.Columns.Add(colsalerate);

            DataGridViewTextBoxColumn colvat = new DataGridViewTextBoxColumn();
            colvat.Name = "Vat";
            colvat.DataPropertyName = "Vat";
            colvat.Width = 40;
            colvat.Visible = true;
            colvat.ReadOnly = true;
            dtv.Columns.Add(colvat);

            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Disc";
            colDiscount.DataPropertyName = "Disc";
            colDiscount.Width = 40;
            colDiscount.Visible = true;
            colDiscount.ReadOnly = true;
            dtv.Columns.Add(colDiscount);

            DataGridViewTextBoxColumn colIsSerial = new DataGridViewTextBoxColumn();
            colIsSerial.Name = "IsSerial";
            colIsSerial.DataPropertyName = "IsSerial";
            colIsSerial.Width = 0;
            colIsSerial.Visible = false;
            dtv.Columns.Add(colIsSerial);


            DataGridViewTextBoxColumn ExpDate = new DataGridViewTextBoxColumn();
            ExpDate.Name = "ExpireDate";
            ExpDate.DataPropertyName = "ExpireDate";
            ExpDate.Width = 80;
            ExpDate.Visible = true;
            ExpDate.ReadOnly = true;
            dtv.Columns.Add(ExpDate);
            dtv.Columns[23].DefaultCellStyle.Format = "dd/MM/yyyy";


            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.Width = 50;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dtv.Columns.Add(Deletelink);
            

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Visible = false;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(25, checkBoxColumn);
            
            //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //button.HeaderText = "";
            //button.Width = 30;
            //button.Visible = true;
            //button.Name = "Add";
            //dtv.Columns.Insert(20, button);
        }
        private void populateDataToGridDrug(DataGridView dtv, string poid)
        {
            short index = 0;
           
            dgvPODetails.Visible = true;
            dgvPODetails.Rows.Clear();
            
            List<PurchaseOrder> list = new List<PurchaseOrder>();
            list.Clear();
            list.AddRange(invSr.GetPODetails(poid).ToList());

            foreach (PurchaseOrder data in list)
            {
                string[] row = new string[] { data.ItemOrder.ItemMaster.ID,
                                              data.ItemOrder.ItemMaster.Name,
                                              data.ItemOrder.ItemMaster.PacketType.ID,
                                              data.ItemOrder.ItemMaster.Units.ID,
                                              data.ItemOrder.ItemMaster.GroupDetails.ID,
                                              data.ItemOrder.ItemMaster.Company.ID,
                                              data.ItemOrder.ItemMaster.BrandSetup.ID,
                                              data.ItemOrder.ItemMaster.ModelSetup.ID,
                                              data.ItemOrder.ItemMaster.StoreType.strTypeID,
                                              data.ItemOrder.ItemMaster.Majorgroup.MajorgrpID,
                                              data.ItemOrder.ItemMaster.GroupDetails.Name,
                                              data.ItemOrder.ItemMaster.Company.Name,
                                              data.ItemOrder.ItemMaster.BrandSetup.Name,
                                              data.ItemOrder.ItemMaster.ModelSetup.Name,
                                              data.PurchaseRequisition.RequisitionQty.ToString(),
                                              data.ItemOrder.POQty.ToString(),
                                              data.ItemOrder.RemQty.ToString(),
                                              data.ItemOrder.RemQty.ToString(),
                                              data.ItemOrder.Rate.ToString(),
                                              data.ItemOrder.Rate.ToString(),
                                              data.ItemOrder.VAT.ToString(),
                                              data.ItemOrder.Discount.ToString(),
                                              data.ItemOrder.ItemMaster.IsSerial
               //ReqQty = data.PurchaseRequisition.RequisitionQty
            };

                AddRowsToCollection(dgvPODetails,row,index);
                index++;
            }
           
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        private void treeviewPurchaseOrder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strPOID = treeviewPurchaseOrder.SelectedNode.Text;
            //txtPOID.Text = treeviewPurchaseOrder.SelectedNode.Text;
            txtPOID.Text = "";
            txtPRID.Text = string.Empty;
            txtStoreID.Text = string.Empty;
            txtStoreName.Text = string.Empty;
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            foreach (SCMTree objscm in purchaseorder)
            {
                if (strPOID == objscm.ID)
                {
                    txtPOID.Text = strPOID;
                    populateDataToGridDrug(dgvPODetails, txtPOID.Text);
                    LoadPODetailsByID();
                }
            }
            btnSave.Enabled = true;
            
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
           
                                                
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtItemID.Text = "";
            txtItemName.Text = "";           
            txtGrnQty.Text = "";
            txtRemQty.Text = "";
            txtExpDatetimepicker.Text = "";
            txtPRID.Text = string.Empty;
            txtStoreID.Text = string.Empty;
            txtStoreName.Text = string.Empty;
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;           
            dateBox.Visible = false;
            chekbox.Checked = false;
            txtPOID.Text = string.Empty;
            txtPRID.Text = string.Empty;
            treeviewPurchaseOrder.Nodes.Clear();
            dgvMrrDetails.Rows.Clear();
            dgvPODetails.Rows.Clear();
            //dgvPODetails.DataBindings.Clear();
            
            DG.Rows.Clear();
            List<SCMTree> purchaseorder = invSr.GetPONumbers().Select(c => new SCMTree { Date = c.PODate, ID = c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewPurchaseOrder, purchaseorder);
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            
        }

        private void dgvMrrDetails_DoubleClick(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow dv in dgvMrrDetails.SelectedRows)
            //{
            //    dgvMrrDetails.Rows.Remove(dv);
            //}
        }

        private void dgvMrrDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 24)
            {
              int selRowIndex = e.RowIndex;
                if (selRowIndex < 0)
                {
                    dgvMrrDetails.Rows.Clear();
                }
                else
                {
                    dgvMrrDetails.Rows.RemoveAt(selRowIndex);
                }

            }

        }

        private void dgvMrrDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //if (e.ColumnIndex == 23 && e.RowIndex >= 0)
            //{
            //    dateBox.Location = dgvMrrDetails.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
            //    dateBox.Visible = true;
            //    dateBox.Select();
            //    dateBox.Focus();
            //    // temp.KeyDown();
            //    if (dgvMrrDetails.CurrentCell.Value == null || dgvMrrDetails.CurrentCell.Value.ToString().Trim() == "" || dgvMrrDetails.CurrentCell.Value.ToString() == "  /  /    ")
            //    {
            //        //oDateTimePicker.Value = Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss tt"));
            //        dateBox.Text = " / /";
            //    }
            //    else
            //    {
            //        dateBox.Text = dgvMrrDetails.CurrentCell.Value.ToString();
            //    }

            //}
            //if (e.ColumnIndex == 24 && e.RowIndex >= 0)
            //{
            //    dateBox.Text = " / /";
            //    dateBox.Visible = false;
            //}
            txtItemID.Text = dgvMrrDetails.CurrentRow.Cells["ItemID"].Value.ToString();
            txtItemName.Text = dgvMrrDetails.CurrentRow.Cells["Item"].Value.ToString();
            txtGroupName.Text = dgvMrrDetails.CurrentRow.Cells["Group"].Value.ToString();
            txtGrnQty.Text = dgvMrrDetails.CurrentRow.Cells["GRNQty"].Value.ToString();
            txtExpDatetimepicker.Text = dgvMrrDetails.CurrentRow.Cells["ExpireDate"].Value.ToString();
            CurrentIndex = dgvPODetails.CurrentRow.Index;
        }
        
        private void InserAdd(string strItenName, long lngTotoalRow)
        {
           // DG.Rows.Add(lngTotoalRow);
            long inttotalRow = Convert.ToInt32(DG.Rows.Count + lngTotoalRow) + 1;
            DG.Rows.Add(inttotalRow);


        }

        private void InserAdd(string itemid,string item,string compid,string majorgrp,string storeid,string groupid,string unitid,string typeid,string modelid,string brandid,string expiredate, int lngqty)
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
            
            for (int i = 0; i < dgvMrrDetails.Rows.Count; i++)
            {
                if (float.Parse(dgvMrrDetails.Rows[i].Cells[16].Value.ToString()) > float.Parse(dgvMrrDetails.Rows[i].Cells[17].Value.ToString()))
                {
                    MessageBox.Show("Receive quantity can not be more than RemQty");
                    return;
                }
                if (float.Parse(dgvMrrDetails.Rows[i].Cells[16].Value.ToString()) == 0)
                {
                    MessageBox.Show("Receive quantity can not be zero");
                    return;
                }
                if ((String)dgvMrrDetails.Rows[i].Cells[23].Value == String.Empty)
                {
                    MessageBox.Show("Please fill Expire Date");
                    return;
                }
            }

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
            
            for (iRow = 0; iRow < dgvMrrDetails.Rows.Count; iRow++)
            //foreach(DataGridViewRow iRows in dgvMrrDetails.Rows)
            {
                intTotalRow = Convert.ToInt32(dgvMrrDetails.Rows[iRow].Cells[16].Value);
                itemid = dgvMrrDetails.Rows[iRow].Cells[0].Value.ToString();
                itemname = dgvMrrDetails.Rows[iRow].Cells[1].Value.ToString();
                compid = dgvMrrDetails.Rows[iRow].Cells[5].Value.ToString();
                majorgrp = dgvMrrDetails.Rows[iRow].Cells[9].Value.ToString();
                storeid = dgvMrrDetails.Rows[iRow].Cells[8].Value.ToString();
                groupid = dgvMrrDetails.Rows[iRow].Cells[4].Value.ToString();
                unitid = dgvMrrDetails.Rows[iRow].Cells[3].Value.ToString();
                typeid = dgvMrrDetails.Rows[iRow].Cells[2].Value.ToString();
                modelid = dgvMrrDetails.Rows[iRow].Cells[7].Value.ToString();
                brandid = dgvMrrDetails.Rows[iRow].Cells[6].Value.ToString();
                expiredate = dgvMrrDetails.Rows[iRow].Cells[23].Value.ToString();
                InserAdd(itemid, itemname, compid,majorgrp,storeid,groupid,unitid,typeid,modelid,brandid,expiredate,intTotalRow);
            }
            Column12.DisplayMember = "Value";
            Column12.ValueMember = "Key";
            Column12.DataSource = new BindingSource(invSr.GetServiceProviderInfo("",""),null);
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
               
               
        }

        private void dgvMrrDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgvMrrDetails.Columns["GRNQty"].Index) //this is numeric column
            {
                int i;
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Must be numeric");
                }
            }
            //if (e.ColumnIndex == dgvMrrDetails.Columns["GRNQty"].Index)
            //{
            //    dgvMrrDetails.Rows[e.RowIndex].ErrorText = "";
            //    int newInteger;

            //    // Don't try to validate the 'new row' until finished  
            //    // editing since there 
            //    // is not any point in validating its initial value. 
            //    if (dgvMrrDetails.Rows[e.RowIndex].IsNewRow) { return; }
            //    if (!int.TryParse(e.FormattedValue.ToString(),
            //        out newInteger) || newInteger <= 0)
            //    {
            //        e.Cancel = true;
            //        dgvMrrDetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
            //    }
            //}
        }

        private void dgvPODetails_SelectionChanged(object sender, EventArgs e)
        {
            txtItemID.Text = dgvPODetails.CurrentRow.Cells["ItemID"].Value.ToString();
            txtItemName.Text = dgvPODetails.CurrentRow.Cells["Item"].Value.ToString();
            txtGroupName.Text = dgvPODetails.CurrentRow.Cells["Group"].Value.ToString();
            txtGrnQty.Text = dgvPODetails.CurrentRow.Cells["GRNQty"].Value.ToString();
            txtRemQty.Text = dgvPODetails.CurrentRow.Cells["RemQty"].Value.ToString();
            txtpurRate.Text = dgvPODetails.CurrentRow.Cells["PORate"].Value.ToString();
            txtSlrate.Text = dgvPODetails.CurrentRow.Cells["SaleRate"].Value.ToString();
            CurrentIndex = dgvPODetails.CurrentRow.Index;
            txtGrnQty.Select();
        }
       
        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvMrrDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMrrDetails.Columns[e.ColumnIndex].Name.Equals("GRNQty"))
            {
                Int32 intValue;
                if (dgvMrrDetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (Int32.TryParse((String)e.Value, out intValue) &&
                    (intValue < 0))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;
                }
            }
        }

        private void chekbox_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox.Checked == true)
            {
                
                //CheckBox headerBox = ((CheckBox)dgvTermsandConditions.Controls.Find("checkboxHeader", true)[0]);
                for (int i = 0; i < dgvPODetails.RowCount; i++)
                {
                    Convert.ToBoolean(dgvPODetails.Rows[i].Cells["checkBoxColumn"].Value = true);
                }
            }
            else
            {
                for (int i = 0; i < dgvPODetails.RowCount; i++)
                {
                    Convert.ToBoolean(dgvPODetails.Rows[i].Cells["checkBoxColumn"].Value = false);
                }

            }
        }

        private void dgvPODetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemID.Text = dgvPODetails.CurrentRow.Cells["ItemID"].Value.ToString();
            txtItemName.Text = dgvPODetails.CurrentRow.Cells["Item"].Value.ToString();
            txtGroupName.Text = dgvPODetails.CurrentRow.Cells["Group"].Value.ToString();
            txtGrnQty.Text = dgvPODetails.CurrentRow.Cells["GRNQty"].Value.ToString();
            txtRemQty.Text = dgvPODetails.CurrentRow.Cells["RemQty"].Value.ToString();
            txtpurRate.Text = dgvPODetails.CurrentRow.Cells["PORate"].Value.ToString();
            txtSlrate.Text = dgvPODetails.CurrentRow.Cells["SaleRate"].Value.ToString();
            CurrentIndex = dgvPODetails.CurrentRow.Index;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (float.Parse(txtGrnQty.Text) <= 0)
            {
                MessageBox.Show("GRN Quantity cannot be zero");
                return;
            }
            if (float.Parse(txtpurRate.Text) > float.Parse(txtSlrate.Text))
            {
                MessageBox.Show("Sales Rate can not be less than Purchase Rate");
                return;
            }
            if (float.Parse(txtGrnQty.Text) > float.Parse(txtRemQty.Text))
            {
                MessageBox.Show("GRN Qty can not be more than  RemQty");
                return;
            }
           
            if (txtExpDatetimepicker.Text == "")
            {
                MessageBox.Show("Please fill Expire Date");
                return;
            }
            if (txtExpDatetimepicker.Text != "")
            {
                Regex r = new Regex(@"\d{2}/\d{2}/\d{4}");
                if (!r.IsMatch(txtExpDatetimepicker.Text))
                {
                    MessageBox.Show("Please provide correct date format:dd/mm/yyyy");

                    return;
                }
                if (Convert.ToDateTime(txtExpDatetimepicker.Text) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    MessageBox.Show("Expire Date cannot be earlier than Current Date");

                    return;

                }
            }
            if (!isDuplicateFound())
            {
                dgvMrrDetails.Rows.Add(dgvPODetails.Rows[CurrentIndex].Cells[0].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[1].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[2].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[3].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[4].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[5].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[6].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[7].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[8].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[9].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[10].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[11].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[12].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[13].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[14].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[15].Value.ToString(),
                                         txtGrnQty.Text,
                                         dgvPODetails.Rows[CurrentIndex].Cells[17].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[18].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[19].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[20].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[21].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[22].Value.ToString(),
                                         txtExpDatetimepicker.Text,                                   
                                         dgvPODetails.Rows[CurrentIndex].Cells[24].Value.ToString()
                                     );

                dgvMrrDetails.Columns["POQty"].Visible = false;
                //dgvMrrDetails.Columns["PORate"].Visible = false;
                dgvMrrDetails.Columns["Company"].Visible = false;
                this.dgvMrrDetails.Focus();
            }
            else
            {
                dgvMrrDetails.CurrentRow.Cells[16].Value = txtGrnQty.Text;
                dgvMrrDetails.CurrentRow.Cells[23].Value = txtExpDatetimepicker.Text;
                
            }
            dgvPODetails.Select();
        }
        private bool isDuplicateFound()
        {
            if (dgvMrrDetails.Rows.Count > 0)
                foreach (DataGridViewRow row in dgvMrrDetails.Rows)
                {
                    if (row.Cells[0].Value.ToString() == txtItemID.Text)
                    {
                        return true;
                    }

                }

            return false;

        }

        private void dgvMrrDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMrrDetails.Rows.Count > 0)
            {
                txtItemID.Text = dgvMrrDetails.CurrentRow.Cells["ItemID"].Value.ToString();
                txtItemName.Text = dgvMrrDetails.CurrentRow.Cells["Item"].Value.ToString();
                txtGroupName.Text = dgvMrrDetails.CurrentRow.Cells["Group"].Value.ToString();
                txtGrnQty.Text = dgvMrrDetails.CurrentRow.Cells["GRNQty"].Value.ToString();
                txtExpDatetimepicker.Text = dgvMrrDetails.CurrentRow.Cells["ExpireDate"].Value.ToString();
                //CurrentIndex = dgvPODetails.CurrentRow.Index;
            }
        }

        private void txtGrnQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtExpDatetimepicker.Focus();
            }
        }

        private void txtExpDatetimepicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnAdd.Focus();
            }
        }

    }
}
