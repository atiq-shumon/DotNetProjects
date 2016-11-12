using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmOpeningEntry : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        private string PharmacyID, SupplierID;
        GroupBox dummy;

        public frmOpeningEntry(string PharmacyID,string SupplierID)
        {
            InitializeComponent();
            this.PharmacyID = PharmacyID;
            this.SupplierID = SupplierID;

            dummy = new GroupBox();
            dummy.Visible = false;
            dummy.Enabled = false;
            this.Controls.Add(dummy);
        }
        private void FormatGridProd(DataGridView dtv)
        {
            dtv.Height = 210;
            dtv.Width = 650;

            dtv.Location = new Point(txtProductionID.Location.X, txtProductionID.Location.Y + txtProductionID.Height);
            dtv.AutoGenerateColumns = false;

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
            colUrate.Width = 50;
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colslrate = new DataGridViewTextBoxColumn();
            colslrate.Name = "SlRate";
            colslrate.DataPropertyName = "SlRate";
            colslrate.Width = 50;
            dtv.Columns.Add(colslrate);

            DataGridViewTextBoxColumn colVat = new DataGridViewTextBoxColumn();
            colVat.Name = "Vat";
            colVat.DataPropertyName = "Vat";
            colVat.Width = 0;
            colVat.Visible = false;
            dtv.Columns.Add(colVat);

            DataGridViewTextBoxColumn colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Discount";
            colDiscount.DataPropertyName = "Discount";
            colDiscount.Width = 0;
            colDiscount.Visible = false;
            dtv.Columns.Add(colDiscount);

        }
        private void populateDatatoGrid(DataGridView dtv, string supname)
        {
            dtv.Visible = true;
            List<Supplier> list = new List<Supplier>();
            list.AddRange(phrSr.GetSupplierListed(supname).ToList());
            dtv.DataSource = list.Select(data => new { data.ID, data.Name }).ToList();

        }

        private void populateDataToGridDrug(DataGridView dtv, string drugname)
        {
            List<DrugMaster> oMedicines = new List<DrugMaster>();

            dgvProduction.Visible = true;
            List<DrugMaster> list = new List<DrugMaster>();
            list.AddRange(phrSr.GetDrugMasterList(drugname).ToList());

            dgvProduction.DataSource = list.Select(data => new
            {
                DRUGID = data.ID,
                DRUGNAME = data.Name,
                COMPANYID = data.DrugCompany.ID,
                COMPANYNAME = data.DrugCompany.Name,
                GROUPID = data.DrugGroup.ID,
                GROUPNAME = data.DrugGroup.Name,
                TYPEID = data.DrugPackType.ID,
                PACKNAME = data.DrugPackType.Name,
                UNITID = data.DrugUnit.ID,
                UNITNAME = data.DrugUnit.Name,
                Rate = data.Urate,
                SlRate = data.Slrate,
                Vat = data.VAT,
                Discount = data.Discount
            }).ToList();
            this.dgvProduction.Focus();
        }
   


        private void txtProductionID_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
               

                    int outParse;
                    if (Int32.TryParse(txtProductionID.Text, out outParse))
                    {
                        // Do what you want to do if numeric
                        dgvProduction.Visible = false;
                        txtMrrQuantity.Focus();
                    }
                    else
                    {
                        populateDataToGridDrug(dgvProduction, txtProductionID.Text);
                        dgvProduction.Focus();
                    }
                    if (dgvProduction.Rows.Count == 0)
                    {
                        dgvProduction.Visible = false;
                        txtProductionID.Select();
                        txtProductionName.Text = string.Empty;
                        txtMrrQuantity.Text = string.Empty;
                        txtURate.Text = string.Empty;
                        txtvat.Text = string.Empty;
                        txtDiscount.Text = string.Empty;
                    }
                
            }
           if (e.KeyCode == Keys.Down)
            {
                
                if (txtProductionID.Text.Length == 0)
                {
                    MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                    return;
                }
                populateDatatoGrid(dgvProduction, txtProductionID.Text);
                dgvProduction.Focus();
                if (dgvProduction.RowCount == 0)
                {
                    txtProductionID.Text = "";
                    return;
                }

            }
          
        }

        private void dgvProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int i = dgvProduction.Rows.Count;
           


           
            setvaluesFromList(dgvProduction, sender);
        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {
            if (dtv.Rows.Count > 0)
            {
                int currentRow = dtv.CurrentRow.Index;
                currentRow--;
                txtProductionID.Text = dtv["DRUGID", currentRow+1].Value.ToString();
                txtProductionName.Text = dtv["Brand Name", currentRow + 1].Value.ToString();
                txtProductionCompanyID.Text = dtv["COMPANYID", currentRow+1].Value.ToString();
                txtProdCompName.Text = dtv["COMPANY", currentRow+1].Value.ToString();
                txtProductionGroupID.Text = dtv["GROUPID", currentRow+1].Value.ToString();
                txtProdGroupName.Text = dtv["Generic Name", currentRow + 1].Value.ToString();
                txtProductionUnitID.Text = dtv["UNITID", currentRow+1].Value.ToString();
                txtProductionPacketID.Text = dtv["TYPEID", currentRow+1].Value.ToString();
                labelRate.Text = dtv["Rate", currentRow + 1].Value.ToString();
                txtURate.Text = dtv["Rate", currentRow + 1].Value.ToString();
                txtSlrate.Text = dtv["SlRate", currentRow + 1].Value.ToString();
                LabelVat.Text = dtv["Vat",currentRow + 1].Value.ToString();
                txtvat.Text = dtv["Vat", currentRow + 1].Value.ToString();
                LabelDiscount.Text = dtv["Discount", currentRow + 1].Value.ToString();
                txtDiscount.Text = dtv["Discount", currentRow + 1].Value.ToString();
                dtv.Visible = false;
                txtProductionID.Focus();

            }
            else
            {
                dtv.Visible = false;
                txtProductionID.Focus();
            }

        }


        private void frmOpeningEntry_Load(object sender, EventArgs e)
        {
            txtPharmacyID.Text = this.PharmacyID;
            txtSupplierID.Text = this.SupplierID;
            txtProductionID.Select();

            
            cboMrrNo.Enabled = false;

            FormatGridProd(dgvProduction);
            dgvProduction.Visible = false;

            //txtMrrDate.Text = DateTime.Now.ToString();

            FormatGrid();

        }
        private void FormatGrid()
        {
            lvOpeningEntry.CheckBoxes = false;

            lvOpeningEntry.Columns.Add("Drug ID", 100, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Brand Name", 220, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Drug PackageType", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Drug Unit", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Drug GroupID", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Generic Name", 200, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Drug CompanyID", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Company Name", 220, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Rate", 70, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("SlRate", 70, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("VAT", 50, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Disc", 60, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("PR Quantity", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("PO Quantity", 0, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Quantity", 70, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("Total", 70, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("ExpDate", 70, HorizontalAlignment.Left);
            lvOpeningEntry.Columns.Add("BatchNo", 70, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            
                ListViewItem itm = new ListViewItem(txtProductionID.Text);
                itm.SubItems.Add(txtProductionName.Text);
                itm.SubItems.Add(txtProductionPacketID.Text);

                itm.SubItems.Add(txtProductionUnitID.Text);

                itm.SubItems.Add(txtProductionGroupID.Text);
                itm.SubItems.Add(txtProdGroupName.Text);
                itm.SubItems.Add(txtProductionCompanyID.Text);
                itm.SubItems.Add(txtProdCompName.Text);

                itm.SubItems.Add(txtURate.Text);
                itm.SubItems.Add(txtSlrate.Text);
                itm.SubItems.Add(txtvat.Text);
                itm.SubItems.Add(txtDiscount.Text);
                itm.SubItems.Add("0");
                itm.SubItems.Add("0");
                itm.SubItems.Add(txtMrrQuantity.Text);
                itm.SubItems.Add(txtTotal.Text);
                itm.SubItems.Add(txtExpireDate.Text);
                itm.SubItems.Add(txtBatch.Text);
                lvOpeningEntry.Items.Add(itm);
           
        }
        private void LoadListDetails(string mrrno)
        {
            lvOpeningEntry.Items.Clear();

            List<MaterialReceive> omatrec;  

            if (mrrno.Length != 0)
            {
                omatrec = phrSr.GetOpeningEntry(cboMrrNo.Text).ToList(); 
            }
            else
            {
                return;
            }

            int i = 0;

            foreach (MaterialReceive mat in omatrec)
            {
                ListViewItem itm = new ListViewItem(mat.ItemsOrder.DrugMaster.ID);
                itm.SubItems.Add(mat.ItemsOrder.DrugMaster.Name);
                itm.SubItems.Add(mat.ItemsOrder.DrugMaster.DrugPackType.ID);
                itm.SubItems.Add(mat.ItemsOrder.DrugMaster.DrugUnit.ID);
                itm.SubItems.Add(mat.ItemsOrder.DrugMaster.DrugGroup.ID);
                itm.SubItems.Add(mat.ItemsOrder.DrugMaster.DrugGroup.Name);
                itm.SubItems.Add(mat.ItemsOrder.DrugMaster.DrugCompany.ID);
                itm.SubItems.Add(mat.ItemsOrder.DrugMaster.DrugCompany.Name);
                itm.SubItems.Add(mat.ItemsOrder.URate.ToString());
                itm.SubItems.Add(mat.ItemsOrder.SlRate.ToString());
                itm.SubItems.Add(mat.ItemsOrder.VAT.ToString());
                itm.SubItems.Add(mat.ItemsOrder.Discount.ToString());
                itm.SubItems.Add("0");
                itm.SubItems.Add("0");
                itm.SubItems.Add(mat.MRRQuantity.ToString());
                float amountSumamry = float.Parse(mat.MRRQuantity.ToString()) * float.Parse(mat.ItemsOrder.URate.ToString()) + float.Parse(mat.ItemsOrder.VAT.ToString()) - float.Parse(mat.ItemsOrder.Discount.ToString());
                itm.SubItems.Add(amountSumamry.ToString());
                itm.SubItems.Add(mat.ExpireDate.ToString());
                itm.SubItems.Add(mat.BatchNo);
                lvOpeningEntry.Items.Add(itm);
            }

        }
        private void AmountSummary()
        {
            txtTotal.Text = (Utility.ParseFloat(txtMrrQuantity.Text) * Utility.ParseFloat(txtSlrate.Text) + Utility.ParseFloat(txtvat.Text) - Utility.ParseFloat(txtDiscount.Text)).ToString();
            
        }


        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            AmountSummary();
        }

        private void txtMrrQuantity_TextChanged(object sender, EventArgs e)
        {
            AmountSummary();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            AmountSummary();
        }

        private void smartNumericTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean IsProductDuplicate(ListView vw, string key)
        {
            foreach (ListViewItem itm in vw.Items)
            {
                if (itm.SubItems[0].Text == key)
                {

                    return true;
                }

            }
            return false;
        }
        private void RefreshGrid()
        {
                       
            txtProductionID.Text = string.Empty;
            txtProductionName.Text = string.Empty;
            txtURate.Text = string.Empty;
            txtSlrate.Text = string.Empty;
            txtvat.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtMrrQuantity.Text = string.Empty;
            txtBatch.Text = string.Empty;
            labelRate.Text = "0";
            LabelVat.Text = "0";
            LabelDiscount.Text = "0";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string vrfy = phrSr.VerifyOpeningDrugID(txtProductionID.Text, txtPharmacyID.Text);
            if (vrfy!="0")
            {
                MessageBox.Show("This Item is already opened");
                RefreshGrid();
                return;
            }
            if(string.IsNullOrEmpty(txtBatch.Text))
            {
                MessageBox.Show("Please put BatchNo");
                return;
            }
            //dateTimePicker1.Value = lvOpeningEntry.SelectedItems(0).SubItems(14).Text;
            if (Utility.ParseFloat(txtTotal.Text) > 0)
            {
                if (Utility.ParseFloat(txtURate.Text) == 0)
                {
                    MessageBox.Show("Please put item rate");
                    txtURate.Select();
                    return;
                }
                //lvOpeningEntry.SelectedItems[0].SubItems[13].Text = txtMrrQuantity.Text;
                if (IsProductDuplicate(lvOpeningEntry, txtProductionID.Text))
                {
                    MessageBox.Show("Already Exist");
                    txtProductionID.Select();
                    return;
                }

                LoadListView();
                //LoadListDetails();
                //RefreshGrid();

                txtProductionID.Select();
            }
            else
            {
                MessageBox.Show("Total Amount must be non-negative", "Caution");
            }
            ClearAfterInsert();
        }
        private void ClearAfterInsert()
        {
            
            txtProductionID.Text = string.Empty;
            txtProductionName.Text = string.Empty;
            txtMrrQuantity.Text = string.Empty;
            txtURate.Text = string.Empty;
            txtvat.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtTotal.Text = string.Empty;


        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            AmountSummary();
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
           
            try
            {
                MaterialReceive mo = this.populateMatReceive();
                string i = phrSr.SaveMaterialReceive(mo);
                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnNew.PerformClick();
                    cboMrrNo.Enabled = false;
                    //LoadListDetails(cboMrrNo.SelectedValue.ToString());
                    lvOpeningEntry.Items.Clear();
                    //RefreshGrid();
                    //txtChallanNo.Select();
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
            mr.MRRID = cboMrrNo.Text;
            //mr.MRRQuantity = Single.Parse(txtMrrQuantity.Text);
            //mr.PRID = "OP0114-00002";
            mr.OpeningFlag = 1;
            mr.TransactionType = "OP";
            mr.MRRDate = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
            mr.MRRType = "OP";
            
            mr.ChallanNo = "2345";
            mr.ChallanDate = DateTime.Parse(DateTime.Now.ToString());
            mr.VoucherNo = "1234";
            mr.Remarks = txtRemarks.Text;

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = "0000";
            ocostcenter.CostCenterID = "0000";
            mr.CostCategoryTreeview = ocostcenter;
            
            //ItemsOrder order = new ItemsOrder();
            //order.URate = Single.Parse(txtURate.Text);
            //order.VAT = Single.Parse(txtvat.Text);
            //order.Discount = Single.Parse(txtDiscount.Text);
            //mr.ItemsOrder = order;

            PurchaseOrder po = new PurchaseOrder();
            po.ID = "OP0114-00008";

            PurchaseRequisition oreq = new PurchaseRequisition();
            oreq.ID = "OP0114-00002";
            po.PurchaseRequisition = oreq;

            mr.PurchaseOrder = po;



            Pharmacy phar = new Pharmacy();
            phar.PharmacyID = txtPharmacyID.Text;
            mr.Pharmacy = phar;

            Supplier supp = new Supplier();
            supp.ID = txtSupplierID.Text;
            mr.Supplier = supp;
            
            string MrrString = "";
            foreach (ListViewItem itemRow in lvOpeningEntry.Items)
            {

                MrrString += itemRow.SubItems[0].Text + "," + itemRow.SubItems[2].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[8].Text + "," + itemRow.SubItems[9].Text + "," + itemRow.SubItems[10].Text + "," + itemRow.SubItems[11].Text + "," + itemRow.SubItems[12].Text + "," + itemRow.SubItems[12].Text + "," + itemRow.SubItems[14].Text + "," + itemRow.SubItems[16].Text + "," + itemRow.SubItems[17].Text;
                MrrString += ";";
            }
            mr.MRRDetails = MrrString;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            mr.EntryParameter = ep;

            return mr;
        }

        private void dgvProduction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void lvOpeningEntry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOpeningEntry.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvOpeningEntry.SelectedItems[0];
                txtProductionID.Text = itm.SubItems[0].Text;
                txtProductionName.Text = itm.SubItems[1].Text;
                txtProdGroupName.Text = itm.SubItems[5].Text;
                txtProdCompName.Text = itm.SubItems[7].Text;
                txtURate.Text = itm.SubItems[8].Text;
                labelRate.Text = itm.SubItems[8].Text;
                txtSlrate.Text = itm.SubItems[9].Text;
                txtvat.Text = itm.SubItems[10].Text;
                LabelVat.Text = itm.SubItems[10].Text;
                txtDiscount.Text = itm.SubItems[11].Text;
                LabelDiscount.Text = itm.SubItems[11].Text;
                txtMrrQuantity.Text = itm.SubItems[14].Text;
                txtTotal.Text = itm.SubItems[15].Text;
                txtExpireDate.Text = itm.SubItems[16].Text;
                txtBatch.Text = itm.SubItems[17].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialReceive mo = this.populateMatReceive();
                short i = phrSr.UpdateOpeningEntry(mo);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //btnNew.PerformClick();
                    //LoadListDetails();
                    //lvOpeningEntry.Items.Clear();
                    //RefreshGrid();
                    //txtChallanNo.Select();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPharmacyID.Text = this.PharmacyID;
            txtSupplierID.Text = this.SupplierID;            
        }

        private void txtMrrQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
            AmountSummary();
        }

        private void txtURate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
            AmountSummary();
        }

        private void txtvat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
            AmountSummary();
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
            AmountSummary();
        }

        private void cboMrrNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListDetails(cboMrrNo.SelectedValue.ToString());
        }

        private void txtProductionID_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtProductionID_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtProductionID_TextChanged(object sender, EventArgs e)
        {
            txtProductionName.Text = string.Empty;
            txtMrrQuantity.Text = string.Empty;
            txtURate.Text = string.Empty;
            txtvat.Text = string.Empty;
            txtDiscount.Text = string.Empty;
        }

      

        private void btnShowExist_Click(object sender, EventArgs e)
        {
            cboMrrNo.Enabled = true;
            cboMrrNo.DisplayMember = "MRRID";
            cboMrrNo.DataSource = phrSr.GetMRRNumber();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtPharmacyID.Text = this.PharmacyID;
            txtSupplierID.Text = this.SupplierID; 
            cboMrrNo.Enabled = false;
            RefreshGrid();
            lvOpeningEntry.Items.Clear();
            txtProductionID.Select();
        }

        private void dgvProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
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
                txtURate.Text = row.Cells["Rate"].Value.ToString();
                labelRate.Text = row.Cells["Rate"].Value.ToString();
                txtSlrate.Text = row.Cells["SlRate"].Value.ToString();
                LabelVat.Text = row.Cells["Vat"].Value.ToString();
                txtvat.Text = row.Cells["Vat"].Value.ToString();
                LabelDiscount.Text = row.Cells["Discount"].Value.ToString();
                txtDiscount.Text = row.Cells["Discount"].Value.ToString();
                dgvProduction.Visible = false;

                txtProductionID.Focus();

            }
        }
      
    }
}
