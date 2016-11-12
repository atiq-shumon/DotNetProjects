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
    public partial class frmTransferRequisition : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmTransferRequisition()
        {
            InitializeComponent();
        }
   
        private void frmPurchaseRequisition_Load(object sender, EventArgs e)
        {
            
            txtDepartment.Select();

            cboPharmacy.DisplayMember = "WhName";
            cboPharmacy.ValueMember = "Whid";
            cboPharmacy.DataSource = new BindingSource(phrSr.GetWhTypeforCentral("0061","1"), null);

            cboTransferPharmacy.DisplayMember = "WhName";
            cboTransferPharmacy.ValueMember = "Whid";
            cboTransferPharmacy.DataSource = new BindingSource(phrSr.GetWarehouseTypewise("1","0"), null);

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
            colDrugId.Name = "DRUGID";
            colDrugId.DataPropertyName = "DRUGID";
            colDrugId.Width = 0;
            colDrugId.Visible = false;
            dtv.Columns.Add(colDrugId);
            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn();
            colDrugTitle.Name = "Brand Name";
            colDrugTitle.DataPropertyName = "DRUGNAME";
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

            DataGridViewTextBoxColumn colpharmacy = new DataGridViewTextBoxColumn();
            colpharmacy.Name = "PharmacyName";
            colpharmacy.DataPropertyName = "PharmacyName";
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
            List<DrugMaster> oMedicines = new List<DrugMaster>();

            dgvProduction.Visible = true;
            List<DrugMaster> list = new List<DrugMaster>();
            list.AddRange(phrSr.GetDrugStockByGroup(groupname).ToList());

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
                PharmacyName = data.PharmacyName,
                StockQty = data.StockQty           
            }).ToList();
            this.dgvProduction.Focus();
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
        private void populateDataToGridDrug(DataGridView dtv, string drugname,string pharmacy)
        {
            List<DrugMaster> oMedicines = new List<DrugMaster>();

            dgvProduction.Visible = true;
            List<DrugMaster> list = new List<DrugMaster>();
            list.AddRange(phrSr.GetDrugStockByPharmacy(drugname,pharmacy).ToList());
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
                    PharmacyName = data.PharmacyName,
                    StockQty = data.StockQty
                }).ToList();
                this.dgvProduction.Focus();
            }
            else
            {
                dgvProduction.Visible = false;
                MessageBox.Show("There is no drug in this Pharmacy");
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
                txtPharmacy.Text = dtv["PharmacyName", currentRow + 1].Value.ToString();
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
                
                txtProductionID.Text = row.Cells["DRUGID"].Value.ToString();
                txtProductionName.Text = row.Cells["Brand Name"].Value.ToString();
                txtProductionCompanyID.Text = row.Cells["COMPANYID"].Value.ToString();
                
                txtProdCompName.Text = row.Cells["Company"].Value.ToString();
                txtProductionGroupID.Text = row.Cells["GROUPID"].Value.ToString();
                txtProdGroupName.Text = row.Cells["Generic Name"].Value.ToString();
                txtProductionUnitID.Text = row.Cells["UNITID"].Value.ToString();
                txtProductionPacketID.Text = row.Cells["TYPEID"].Value.ToString();
                txtPharmacy.Text = row.Cells["PharmacyName"].Value.ToString();
                txtQuantity.Text = row.Cells["StockQty"].Value.ToString();
                txtStock.Text = row.Cells["StockQty"].Value.ToString();
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
            lvItemList.Columns.Add("Company", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("ReqQty", 80, HorizontalAlignment.Left);
            lvItemList.Columns.Add("TRQty", 0, HorizontalAlignment.Left);
            lvItemList.Columns.Add("Pharmacy", 150, HorizontalAlignment.Left);
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
            itm.SubItems.Add(txtPharmacy.Text); 
            itm.SubItems.Add(txtStock.Text);            
            lvItemList.Items.Add(itm);
            
        }
        private void LoadListTRDetails(string trid)
        {
            long  Slno = 1;
            
            lvItemList.Items.Clear();

            List<TransferRequisition> opurchasereq;

            if(trid.Length != 0)
            {
                opurchasereq = phrSr.GetTRDetails(trid).ToList();
            }
            else
            {
                return;
            }
            foreach (TransferRequisition opr in opurchasereq)
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
                itm.SubItems.Add(opr.TrQty.ToString());
                itm.SubItems.Add(opr.TrrQty.ToString());
                itm.SubItems.Add("");
                Slno = Slno + 1;
                lvItemList.Items.Add(itm);
            }
        }
        private Boolean IsProductDuplicate(ListView vw, string key1,string key2)
        {
            foreach (ListViewItem itm in vw.Items)
            {
                if (itm.SubItems[1].Text == key1 && itm.SubItems[11].Text == key2)
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
            if (IsProductDuplicate(lvItemList, txtProductionID.Text, txtPharmacy.Text))
            {                
                foreach (ListViewItem itm in lvItemList.Items)
                {
                    
                    if (itm.SubItems[1].Text == txtProductionID.Text && itm.SubItems[11].Text == txtPharmacy.Text)
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
            if (cboPharmacy.SelectedValue.ToString() == cboTransferPharmacy.SelectedValue.ToString())
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
                    string i = phrSr.SaveTransferRequisition(oreq);
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
            owh.TypeID = cboPharmacy.SelectedValue.ToString();
            owh.ToTypeID = cboTransferPharmacy.SelectedValue.ToString();
            oreq.Warehouse = owh;
            

            string trString = "";
            foreach (ListViewItem itemRow in lvItemList.Items)
            {
                trString += itemRow.SubItems[1].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[5].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[9].Text + "," + itemRow.SubItems[9].Text;
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
            frmReportViewer ofrmreportviewer = new frmReportViewer();
            ofrmreportviewer.selector = ViewerSelector.PRReport;
            ofrmreportviewer.PRID = prid;
            ofrmreportviewer.ReportTitle = "PR Report";
            ofrmreportviewer.ViewReport();
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
                    populateDataToGridDrug(dgvProduction, txtProductionID.Text,cboPharmacy.SelectedValue.ToString());
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
                populateDataToGridDrug(dgvProduction, txtProductionID.Text, cboPharmacy.SelectedValue.ToString());
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
                cboPharmacy.Focus();
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
            //lvItemList.Items.Clear();
            //int vrfy = phrSr.VarifyPurchaseReqNo(txtPRID.Text);
            if (txtTRID.Text == "")
            {
                frmTransferReqNumList opur = new frmTransferReqNumList();
                opur.onAddAllButtonClicked = new frmTransferReqNumList.AddAllClick(AddDataToReqList);
                opur.ShowDialog();
                LoadListTRDetails(txtTRID.Text);
                cboPharmacy.DataBindings.Clear();
                cboTransferPharmacy.DataBindings.Clear();
                cboPharmacy.DataBindings.Add("SelectedValue", phrSr.GetTRDetails(txtTRID.Text).ToList(), "Warehouse.TypeID");
                cboTransferPharmacy.DataBindings.Add("SelectedValue", phrSr.GetTRDetails(txtTRID.Text).ToList(), "Warehouse.ToTypeID");
                txtTRID.Select();
            }
            //else if (vrfy == 0)
            //{
            //    MessageBox.Show("Please put valid PR No");
            //    txtPRID.Select();
            //    return;
            //}
            //else
            //{               
            //    LoadListPRDetails(txtPRID.Text);               
            //    cboPharmacy.DataBindings.Clear();                          
            //    txtDepartment.DataBindings.Clear();
            //    txtUnit.DataBindings.Clear();               
            //    txtDepartment.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Department.DepartmentID");
            //    txtUnit.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "DepartmentUnit.UnitId");
            //    cboPharmacy.DataBindings.Add("SelectedValue", phrSr.GetPRSearchDetails(txtPRID.Text).ToList(), "Pharmacy.PharmacyID");                
            //}
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
