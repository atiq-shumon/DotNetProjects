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
    public partial class frmPurchaseOrder : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        List<SCMTree> purchaseorder;
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }
        
        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {

            purchaseorder = invSr.GetPRID().Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewPurchaseOrder, purchaseorder);
            
            txtPODate.Text = DateTime.Now.ToString();
            txtRequisitionBy.Text = Utility.UserId;
          
            cboCostCategoey.DisplayMember = "CategoryName";
            cboCostCategoey.ValueMember = "CategoryID";
            cboCostCategoey.DataSource = invSr.GetCostcategory("CostcategoryTreeview", "", "").ToList();

            dgvSupplierList.Visible = false;
           
            FormatDataGridView(dgvSupplierList);
            FormatData(dgvSupplierList);
            FormatTermsandConditions(dgvTermsandConditions);
            populateDataToGridForTerms(dgvTermsandConditions);
            dgvSupplierList.Visible = false;
            txtSupplierName.Visible = false;
            //lblInfo.Visible = false;

            FormatDataForPO(dgvPRDetails);
            FormatDataForPO(dgvPODetails);
            dgvPRDetails.Columns[10].Visible = true;
            //dgvPRDetails.Columns[11].Visible = false;
            //dgvPRDetails.Columns[12].Visible = false;
            dgvPRDetails.Columns[17].Visible = false;
            dgvPRDetails.Columns[21].Visible = false;
            dgvPRDetails.Columns[22].Visible = false;
            dgvPRDetails.Columns[14].Visible = false;
            dgvPRDetails.Columns[18].Visible = false;
            dgvPRDetails.Columns[19].Visible = false;
            dgvPRDetails.Columns[20].Visible = false;           
            
            progressBar1.Visible = false;
        }

       
        private void FormatDataForPO(DataGridView dtv)
        {
            
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
            itemname.Width = 320;
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
            groupname.Width = 170;
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
            brandname.ReadOnly = false;
            dtv.Columns.Add(brandname);

            DataGridViewTextBoxColumn modelname = new DataGridViewTextBoxColumn();
            modelname.Name = "Model";
            modelname.DataPropertyName = "Model";
            modelname.Width = 0;
            modelname.Visible = false;
            modelname.ReadOnly = true;
            dtv.Columns.Add(modelname);

            DataGridViewTextBoxColumn poquantity = new DataGridViewTextBoxColumn();
            poquantity.Name = "POQty";
            poquantity.DataPropertyName = "POQty";
            poquantity.Width = 60;
            poquantity.Visible = true;
            poquantity.ReadOnly = false;
            dtv.Columns.Add(poquantity);
            dtv.Columns["POQty"].DefaultCellStyle.ForeColor = Color.DarkCyan;

            DataGridViewTextBoxColumn colreqQty = new DataGridViewTextBoxColumn();
            colreqQty.Name = "ReqQty";
            colreqQty.DataPropertyName = "ReqQty";
            colreqQty.Width = 60;
            colreqQty.Visible = true;
            colreqQty.ReadOnly = true;
            dtv.Columns.Add(colreqQty);

            DataGridViewTextBoxColumn remainquantity = new DataGridViewTextBoxColumn();
            remainquantity.Name = "RemQty";
            remainquantity.DataPropertyName = "RemainingQty";
            remainquantity.Width = 60;
            remainquantity.Visible = true;
            remainquantity.ReadOnly = true;
            dtv.Columns.Add(remainquantity);

            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 70;
            colUrate.ReadOnly = false;
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colamount = new DataGridViewTextBoxColumn();
            colamount.Name = "Amount";
            colamount.DataPropertyName = "Amount";
            colamount.Width = 80;
            colamount.ReadOnly = true;
            dtv.Columns.Add(colamount);

            DataGridViewTextBoxColumn colVat = new DataGridViewTextBoxColumn();
            colVat.Name = "VAT";
            colVat.DataPropertyName = "VAT";
            colVat.Width = 50;
            colVat.ReadOnly = false;
            dtv.Columns.Add(colVat);

            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Disc";
            colDiscount.DataPropertyName = "Disc";
            colDiscount.Width = 50;
            colDiscount.ReadOnly = false;
            dtv.Columns.Add(colDiscount);

            DataGridViewTextBoxColumn retquantity = new DataGridViewTextBoxColumn();
            retquantity.Name = "RetQuantity";
            retquantity.DataPropertyName = "RetQuantity";
            retquantity.Width = 0;
            retquantity.Visible = false;
            retquantity.ReadOnly = true;
            dtv.Columns.Add(retquantity);


            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.Width = 60;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dtv.Columns.Add(Deletelink);

            DataGridViewLinkColumn colpohistorylink = new DataGridViewLinkColumn();
            colpohistorylink.UseColumnTextForLinkValue = true;
            colpohistorylink.HeaderText = "PO History";
            colpohistorylink.DataPropertyName = "lnkColumn";
            colpohistorylink.Width = 60;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            colpohistorylink.Text = "History";
            dtv.Columns.Add(colpohistorylink);
            
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Visible = true;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(24, checkBoxColumn);
                       
        }

        private void populateDataToGridForPO(DataGridView dtv, string prid)
        {
            dtv.DefaultCellStyle.BackColor = Color.Bisque;
            short index = 0;
            dgvPRDetails.Visible = true;
            dgvPRDetails.Rows.Clear();
            List<PurchaseRequisition> list = new List<PurchaseRequisition>();
            list.Clear();
            list.AddRange(invSr.GetPRDetails(prid).ToList());
            foreach (PurchaseRequisition data in list)
            //dgvPRDetails.DataSource = list.Select(data => new
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
                                              //ReqQty = data.RequisitionQty,
                                              data.RemainingQty.ToString(),
                                              data.RequisitionQty.ToString(),
                                              data.RemainingQty.ToString(),
                                              data.ItemMaster.Urate.ToString(),
                                              "0",
                                              data.ItemMaster.VAT.ToString(),
                                              data.ItemMaster.Discount.ToString(),
                                              "0"

                 };
                //MrrQty = data.ItemOrder.RemQty,
                //Rate = data.ItemOrder.Rate,
                //Vat = data.ItemOrder.VAT,
                //Discount = data.ItemOrder.Discount,
                //ReqQty = data.PurchaseRequisition.RequisitionQty
                AddRowsToCollection(dgvPRDetails, row, index);
                index++;
                
            }
            
        
        }

        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void lvPurchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void FormatDataGridView(DataGridView dtv)
        {
            dtv.Height = 300;
            dtv.Width = 370;
            dtv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "ID";
            ID.DataPropertyName = "ID";
            ID.Width = 0;
            dtv.Columns.Add(ID);

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.Name = "Name";
            Name.DataPropertyName = "Name";
            Name.Width = 250;
            dtv.Columns.Add(Name);

        }
        private void FormatData(DataGridView dtv)
        {
            dtv.ColumnHeadersVisible = true;
            dtv.AllowUserToAddRows = false;
            dtv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtv.AutoGenerateColumns = false;

            dtv.Location = new Point(txtSupplier.Location.X, txtSupplier.Location.Y);

            dtv.Columns[0].Name = "ID";
            dtv.Columns[0].DataPropertyName = "ID";
            dtv.Columns[0].Width = 0;
            dtv.Columns[0].Visible = false;
            dtv.Columns[0].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);

            dtv.Columns[1].Name = "Name";
            dtv.Columns[1].DataPropertyName = "Name";
            dtv.Columns[1].Width = 370;
            dtv.Columns[1].Visible = true;
            dtv.Columns[1].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);

        }
        private void populateDatatoGrid(DataGridView dtv, string supname)
        {
            txtSupplierName.Visible = true;
            List<Supplier> list = new List<Supplier>();
            dgvSupplierList.Visible = true;

            list.AddRange(invSr.GetSupplierByName(supname).ToList());
            dtv.DataSource = list.Select(data => new { data.ID, data.Name }).ToList();
            this.dgvSupplierList.Focus();
        }

        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int outParse;
                if (int.TryParse(txtSupplier.Text, out outParse))
                {
                   
                    txtRequisitionBy.Select();
                }
                else
                {
                    populateDatatoGrid(dgvSupplierList, txtSupplier.Text);
                    this.dgvSupplierList.Focus();
                }
                //if (dgvSupplierList.Rows.Count == 0)
                //{
                //    dgvSupplierList.Visible = false;
                //    txtSupplier.Select();
                //}
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
               
            }
        }
        private void setvaluesfromGrid(DataGridView dtv, object sender)
        {
            txtSupplierName.Visible = true;
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

        private void dgvSupplierList_KeyPress(object sender, KeyPressEventArgs e)
        {
            setvaluesfromGrid(dgvSupplierList,sender);
        }

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupplierName.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSupplierList.Rows[e.RowIndex];

                txtSupplier.Text = row.Cells["ID"].Value.ToString();
                txtSupplierName.Text = row.Cells["Name"].Value.ToString();
                dgvSupplierList.Visible = false;
                txtSupplier.Focus();
            }
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            txtSupplierName.Text = string.Empty;
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPR", "txtSupplier", "txtDeliveryNote", "txtRequisitionBy" };
            Control control = Utility.ReqFieldValidator(this, vf);
                        
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(string.IsNullOrEmpty(txtSupplierName.Text))
            {
                MessageBox.Show("Please Select Supplier ");
                return;
            }
           
            if(dgvPODetails.Rows.Count == 0)
            {
                MessageBox.Show("Please Select Item ");
                return;
            }
            if (txtDeliveryDate.Text == "  /  /" || Convert.ToDateTime(txtDeliveryDate.Text) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                MessageBox.Show("Please put valid Delivery Date");
                txtDeliveryDate.Select();
                return;
            }
            for (int k = 0; k < dgvPODetails.Rows.Count; k++)
            {
                if (dgvPODetails.Rows[k].Cells["ItemID"].Value == null ||
                    dgvPODetails.Rows[k].Cells["CompanyID"].Value == null ||
                    dgvPODetails.Rows[k].Cells["GroupID"].Value == null ||
                    dgvPODetails.Rows[k].Cells["UnitID"].Value == null ||
                    dgvPODetails.Rows[k].Cells["TypeID"].Value == null ||
                    dgvPODetails.Rows[k].Cells["ModelID"].Value == null ||
                    dgvPODetails.Rows[k].Cells["BrandID"].Value == null ||
                    dgvPODetails.Rows[k].Cells["StoreTypeID"].Value == null ||
                    dgvPODetails.Rows[k].Cells["MajorGroup"].Value == null ||
                    dgvPODetails.Rows[k].Cells["POQty"].Value == null ||
                    dgvPODetails.Rows[k].Cells["Rate"].Value == null ||
                    dgvPODetails.Rows[k].Cells["Vat"].Value == null ||
                    dgvPODetails.Rows[k].Cells["Disc"].Value == null)
                {
                    MessageBox.Show("PODetails value cannot be null");
                    return;
                }
                if (float.Parse(dgvPODetails.Rows[k].Cells["POQty"].Value.ToString()) <= 0)
                {
                    MessageBox.Show("POQty can not be zero");
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
            if (icount <1)
            {
                MessageBox.Show("Please select terms and conditions");
                return;
            }

            for(int j = 0;j < dgvPODetails.Rows.Count;j++)
            {
                if (float.Parse(dgvPODetails.Rows[j].Cells["ReqQty"].Value.ToString()) <= 0)
                {
                    MessageBox.Show("Order quantity can not be or less than zero");
                    return;
                }
                if (float.Parse(dgvPODetails.Rows[j].Cells["POQty"].Value.ToString()) > float.Parse(dgvPODetails.Rows[j].Cells["RemQty"].Value.ToString()))
                {
                    MessageBox.Show("POQty can not be more than RemQty");
                    return;
                }
                if (float.Parse(dgvPODetails.Rows[j].Cells["Rate"].Value.ToString()) <= 0)
                {
                    MessageBox.Show("Rates can not be or less than zero");
                    return;
                }

            }
          
            try
            {

                PurchaseOrder po = this.populatePurchaseOrder();
               
                string i = invSr.SavePurchaseOrder(po);

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
                    dgvPODetails.Rows.Clear();
                    dgvPRDetails.Rows.Clear();
                    chkboxPR.Checked = false;
                    txtPR.Text = string.Empty;
                    txtDeliveryNote.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                    txtDeliveryDate.Text = string.Empty;
                    txtSupplier.Text = string.Empty;
                    txtSupplierName.Text = string.Empty;
                    lblNetTotal.Text = "0";
                    lblTotalItem.Text = "0";
                    //dgvPRDetails.Rows.RemoveAt(0);
                    treeviewPurchaseOrder.Nodes.Clear();
                    List<SCMTree> purchaseorder = invSr.GetPRID().Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
                    Utility.PopulateTreeSCM(treeviewPurchaseOrder, purchaseorder);
                    foreach (DataGridViewRow dr in dgvTermsandConditions.Rows)
                    {
                        dr.Cells[0].Value = false;      //sıfırın
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
        private PurchaseOrder populatePurchaseOrder()
        {
            PurchaseOrder po = new PurchaseOrder();
            po.ID = "0";
            po.TransactionType = "PO";
            po.POType = "1";
            po.Remarks = txtRemarks.Text;
            po.DeliveryNote = txtDeliveryNote.Text;
            po.PODate = DateTime.Parse(txtPODate.Text);
            po.DeliveryDate = DateTime.Parse(txtDeliveryDate.Text);
            po.PurchaseBy = txtRequisitionBy.Text;
           

            PurchaseRequisition oreq = new PurchaseRequisition();
            oreq.ID = txtPR.Text;

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            oreq.CostCategoryTreeview = ocostcenter;

            po.PurchaseRequisition = oreq;

            Warehouse ostore = new Warehouse();
            ostore.TypeID = txtStoreLocation.Text;
            po.Warehouse = ostore;

            StoreTypeSCM ostrtype = new StoreTypeSCM();
            ostrtype.strTypeID = txtStoreType.Text;
            po.StoreType = ostrtype;

            Supplier sp = new Supplier();
            sp.ID = txtSupplier.Text;
            po.Supplier = sp;

           
            
            string prString = "";
            foreach (DataGridViewRow dr in dgvPODetails.Rows)
            {

                prString += dr.Cells[0].Value.ToString() + "," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[7].Value.ToString() + "," + dr.Cells[8].Value.ToString() + "," + dr.Cells[9].Value.ToString() + "," + dr.Cells[17].Value.ToString() + "," + dr.Cells[19].Value.ToString() + "," + dr.Cells[20].Value.ToString() + "," + dr.Cells[14].Value.ToString() + "," + dr.Cells[14].Value.ToString() + "," + dr.Cells[21].Value.ToString();
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
            ofrmreportviewer.selector = ViewerSelector.POReport;
            ofrmreportviewer.POID = poid;
            ofrmreportviewer.ReportTitle = "PURCHASE ORDER";
            ofrmreportviewer.ViewReport();
        }

        private void lvPurchaseOrder_MouseClick(object sender, MouseEventArgs e)
        {
                       

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
                    out newInteger) || newInteger <= 0)
                {
                    e.Cancel = true;
                    dgvPODetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }
            if (e.ColumnIndex == dgvPODetails.Columns["Rate"].Index)
            {
                dgvPODetails.Rows[e.RowIndex].ErrorText = "";
                float newInteger;

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgvPODetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (!float.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger <= 0)
                {
                    e.Cancel = true;
                    dgvPODetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }
            if (e.ColumnIndex == dgvPODetails.Columns["VAT"].Index)
            {
                dgvPODetails.Rows[e.RowIndex].ErrorText = "";
                float newInteger;

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgvPODetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (!float.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgvPODetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }
            if (e.ColumnIndex == dgvPODetails.Columns["Disc"].Index)
            {
                dgvPODetails.Rows[e.RowIndex].ErrorText = "";
                float newInteger;

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgvPODetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (!float.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgvPODetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }
        }

        private void dgvPODetails_MouseClick(object sender, MouseEventArgs e)
        {
            //for (int i = 0; i < dgvPODetails.Rows.Count; i++)
            //{
            //    dgvPODetails.CurrentRow.Cells["RemQty"].Value = dgvPODetails.CurrentRow.Cells["ReqQty"].Value;
            //}
        }

        private void treeviewPurchaseOrder_AfterSelect(object sender, TreeViewEventArgs e)
        {
           string strPRID = treeviewPurchaseOrder.SelectedNode.Text;
           txtPR.Text = "";           
           txtSupplier.Text = string.Empty;
           txtSupplierName.Text = string.Empty;
           dgvPRDetails.Rows.Clear();
           foreach (SCMTree objscm in purchaseorder)
           {
               if (strPRID == objscm.ID)
               {
                   txtPR.Text = strPRID;
                   populateDataToGridForPO(dgvPRDetails, txtPR.Text);
                   LoadData();
               }
           }
           btnSave.Enabled = true;
           
        }
        private void LoadData()
        {            
            txtStoreType.DataBindings.Clear();
            txtStoreLocation.DataBindings.Clear();
            txtStoreLocation.DataBindings.Add("Text", invSr.GetPRDetails(txtPR.Text).ToList(), "Warehouse.TypeID");
            txtStoreType.DataBindings.Add("Text", invSr.GetPRDetails(txtPR.Text).ToList(), "ItemMaster.StoreType.strTypeID");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvPODetails.Rows.Clear();

            
            foreach (DataGridViewRow row in dgvPRDetails.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    for (int k = 0; k < dgvPRDetails.Rows.Count; k++)
                    {
                        if (Convert.ToBoolean(dgvPRDetails.Rows[k].Cells["checkBoxColumn"].Value) == true)
                        {
                            if (float.Parse(dgvPRDetails.Rows[k].Cells[15].Value.ToString()) == 0)
                            {
                                MessageBox.Show("Remaining quantity is zero");
                                return;
                            }
                        }
                    }
                    dgvPODetails.Rows.Add(row.Cells[0].Value,
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
                                            row.Cells[21].Value.ToString()
                                        );
                    dgvPODetails.Columns["checkBoxColumn"].Visible = false;
                    dgvPODetails.Columns["RemQty"].Visible = false;
                    dgvPODetails.Columns["ReqQty"].Visible = false;
                    //dgvPODetails.Columns["RemQty"].HeaderText = "POQty";
                    dgvPODetails.Columns[0].Visible = false;
                    dgvPODetails.Columns[11].Visible = false;
                    dgvPODetails.Columns[23].Visible = false;
                    this.dgvPODetails.Focus();
                }

            }
            //dgvPODetails.Columns["ReqQty"].HeaderText = "PO Qty";
            CalculateQty();
        }

        private void dgvPODetails_DoubleClick(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow dv in dgvPODetails.SelectedRows)
            //{
            //    dgvPODetails.Rows.Remove(dv);
            //}
        }

        private void dgvPODetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 22)
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            dgvPODetails.Rows.Clear();
            dgvPRDetails.Rows.Clear();
            lblTotalItem.Text = "0";
            lblNetTotal.Text = "0";
            chekbox.Checked = false;
            chkboxPR.Checked = false;
            txtDeliveryDate.Text = string.Empty;
            treeviewPurchaseOrder.Nodes.Clear();
            List<SCMTree> purchaseorder = invSr.GetPRID().Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewPurchaseOrder, purchaseorder);

            foreach (DataGridViewRow dr in dgvTermsandConditions.Rows)
            {
                dr.Cells[0].Value = false;//sıfırın
            }
            txtRequisitionBy.Text = Utility.UserId;
        }

        private void cboStoreType_SelectedIndexChanged(object sender, EventArgs e)
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


            CheckBox headerBox = ((CheckBox)dgvTermsandConditions.Controls.Find("checkboxHeader",true)[0]);
            //CheckBox headerBox = ((CheckBox)dgvTermsandConditions.Controls.Find("checkboxHeader", true)[0]);
            for (int i = 0; i < dgvTermsandConditions.RowCount; i++)
            {
                if (headerBox.Checked == true)
                {
                    dgvTermsandConditions.Rows[i].Cells[0].Value = true;
                }
                else if (headerBox.Checked == false)
                {
                    dgvTermsandConditions.Rows[i].Cells[0].Value = false;
                }
            }

        }
        private void populateDataToGridForTerms(DataGridView dtv)
        {


            dgvTermsandConditions.Visible = true;
            List<TermsAndConditions> list = new List<TermsAndConditions>();
            list.AddRange(invSr.GetTermsandCondition().ToList());

            dgvTermsandConditions.DataSource = list.Select(data => new
            {
                ID = data.ID,
                Name = data.Name,
                IsAutoSelected = data.IsAutoSelected

            }).ToList();
            this.dgvTermsandConditions.Focus();
        }

        private void txtRequisitionBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
        }

        private void smartLabel6_Click(object sender, EventArgs e)
        {

        }
        private void CalculateQty()
        {
            lblTotalItem.Text = dgvPODetails.Rows.Count.ToString();

            float sum = 0;
            for (int i = 0; i < dgvPODetails.Rows.Count; i++)
            {
                if (dgvPODetails.Rows[i].Cells["POQty"].Value != null)
                {
                    //dgvPODetails.Rows[i].Cells[18].Value = float.Parse(dgvPODetails.Rows[i].Cells[14].Value.ToString()) * float.Parse(dgvPODetails.Rows[i].Cells[17].Value.ToString());
                    dgvPODetails.Rows[i].Cells[18].Value = Math.Round(float.Parse(dgvPODetails.Rows[i].Cells[14].Value.ToString()) * float.Parse(dgvPODetails.Rows[i].Cells[17].Value.ToString()) + float.Parse(dgvPODetails.Rows[i].Cells[19].Value.ToString()) - float.Parse(dgvPODetails.Rows[i].Cells[20].Value.ToString()), 0);
                    sum += float.Parse(dgvPODetails.Rows[i].Cells[18].Value.ToString());
                    lblNetTotal.Text = Math.Round(Convert.ToDouble((sum)), 0).ToString();
                   
                }
                //dgvPODetails.Rows[i].Cells[21].Value = Convert.ToInt32(dgvPODetails.Rows[i].Cells[15].Value) * Convert.ToInt32(dgvPODetails.Rows[i].Cells[17].Value) + Convert.ToInt32(dgvPODetails.Rows[i].Cells[19].Value) - Convert.ToInt32(dgvPODetails.Rows[i].Cells[20].Value);
            }
        }
        private void dgvPODetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculateQty();
            
        }

        private void btnSupplierAdd_Click(object sender, EventArgs e)
        {
            frmSupplier osupplier = new frmSupplier();
            osupplier.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
        private void txtRequisitionBy_TextChanged(object sender, EventArgs e)
        {
            UserID();
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
            if (dgvPODetails.Columns[e.ColumnIndex].Name.Equals("VAT"))
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

        private void button1_Click(object sender, EventArgs e)
        {
            //frmPORecord oporecord = new frmPORecord();
            //oporecord.ShowDialog();
        }

        private void dgvPRDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex == (dgvPRDetails.Columns.Count))
            //{
            //    int i = int.Parse(dgvPRDetails.CurrentRow.Cells[0].Value.ToString());
            //    frmPORecord oporecord = new frmPORecord(i);
            //    oporecord.ShowDialog();
            //}
        }

        private void dgvPRDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvPRDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 23)
            {
                string i = dgvPRDetails.CurrentRow.Cells[0].Value.ToString();
                frmPORecord oporecord = new frmPORecord(i);
                oporecord.ShowDialog();
            }
        }

        private void btnAddTerms_Click(object sender, EventArgs e)
        {
            frmTermsandCondition otermscondition = new frmTermsandCondition();
            otermscondition.ShowDialog();
        }

        private void btnRefreshTerms_Click(object sender, EventArgs e)
        {
            populateDataToGridForTerms(dgvTermsandConditions);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            dgvSupplierList.Visible = false;
        }

        private void dgvPODetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateQty();
        }

        private void chekbox_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox.Checked == true)
            {
                //CheckBox headerBox = ((CheckBox)dgvTermsandConditions.Controls.Find("checkboxHeader", true)[0]);
                for (int i = 0; i < dgvTermsandConditions.RowCount; i++)
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

        private void btnItemStock_Click(object sender, EventArgs e)
        {
            frmItemStockList oitemstock = new frmItemStockList();
            oitemstock.ShowDialog();
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

        private void btnPOModifyTest_Click(object sender, EventArgs e)
        {
            frmPOModify omodify = new frmPOModify();
            omodify.ShowDialog();
        }

    }
}
