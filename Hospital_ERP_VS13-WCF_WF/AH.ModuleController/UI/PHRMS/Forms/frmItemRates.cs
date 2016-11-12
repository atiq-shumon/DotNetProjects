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
using AH.ModuleController.UI.PHRMS.Reports.Viewer;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmItemRates : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        List<DrugMaster> rate;
        public frmItemRates()
        {
            InitializeComponent();
        }

        private void frmItemRates_Load(object sender, EventArgs e)
        {
            cboPharmacy.Select();
            cboPharmacy.DisplayMember = "Value";
            cboPharmacy.ValueMember = "Key";
            cboPharmacy.DataSource = new BindingSource(phrSr.GetPharmacyName("D"), null);

            cboDrugCompany.DisplayMember = "name";
            cboDrugCompany.ValueMember = "id";
            cboDrugCompany.DataSource = new BindingSource(phrSr.GetDrugCompanyDictionary(), null);
            
            txtProductionID.Select();

            FormatGridProd(dgvProduction);
            dgvProduction.Visible = false;

            formatListView();
            //LoadListView(cboDrugCompany.SelectedValue.ToString());
        }
        private void formatListView()
        {
            lvItemRates.CheckBoxes = false;
            lvItemRates.Columns.Add("ID",130,HorizontalAlignment.Left);
            lvItemRates.Columns.Add("Brand Name", 300, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("Generic Name", 220, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("Company", 205, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("CompanyID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("GroupID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("UnitID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("TypeID", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("CostPrice", 70, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("VAT", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("Disc.",0 , HorizontalAlignment.Left);
            lvItemRates.Columns.Add("RRate", 0, HorizontalAlignment.Left);
            lvItemRates.Columns.Add("MRP", 50, HorizontalAlignment.Left);
        }
        private void LoadListView(string compid)
        {
            lvItemRates.Items.Clear();

            rate = phrSr.GetDrugListCompanyWise(compid).ToList();
            int i = 0;

            foreach (DrugMaster rt in rate)
            {
                ListViewItem itm = new ListViewItem(rt.ID);
                itm.SubItems.Add(rt.Name);
                itm.SubItems.Add(rt.DrugGroup.Name);
                itm.SubItems.Add(rt.DrugCompany.Name);
                itm.SubItems.Add(rt.DrugCompany.ID);
                itm.SubItems.Add(rt.DrugGroup.ID);
                itm.SubItems.Add(rt.DrugUnit.ID);
                itm.SubItems.Add(rt.DrugPackType.ID);
                itm.SubItems.Add(rt.Urate.ToString());
                itm.SubItems.Add(rt.VAT.ToString());
                itm.SubItems.Add(rt.Discount.ToString());
                itm.SubItems.Add(rt.Rackrate.ToString());
                itm.SubItems.Add(rt.Slrate.ToString());
                lvItemRates.Items.Add(itm);
            }

        }
        private void RefreshGrid()
        {
            LoadListView(cboDrugCompany.SelectedValue.ToString());
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtURate", "txtvat", "txtDiscount" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            //if(IsMedicineDuplicate(lvItemRates,txtProductionName.Text))
            try
            {
                ItemRates rt = this.populateItemRate();
                short i = phrSr.SaveItemRates(rt);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    //btnNew.PerformClick();
                    txtProductionID.Select();
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
        private ItemRates populateItemRate()
        {
            ItemRates itm = new ItemRates();
            itm.Urate = Single.Parse(txtURate.Text);
            itm.VAT = 0;
            itm.Discount = 0;
            itm.Rackrate = 0;
            itm.Slrate = Single.Parse(txtSlRate.Text);

            Pharmacy phr = new Pharmacy();
            phr.PharmacyID = "01";
            itm.Pharmacy = phr;

            DrugMaster mas = new DrugMaster();
            mas.ID = txtProductionID.Text;
            

            DrugCompany dc = new DrugCompany();
            dc.ID = txtProductionCompanyID.Text;
            mas.DrugCompany = dc;

            DrugGroup dg = new DrugGroup();
            dg.ID = txtProductionGroupID.Text;
            mas.DrugGroup = dg;

            DrugUnit un = new DrugUnit();
            un.ID = txtProductionUnitID.Text;
            mas.DrugUnit = un;

            DrugPackType pac = new DrugPackType();
            pac.ID = txtProductionPacketID.Text;
            mas.DrugPackType = pac;

            itm.DrugMaster = mas;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            itm.EntryParameter = ep;


            return itm;
        }

        private void PrintReport()
        {
            frmReportViewer ofrmReportViewer = new frmReportViewer();
            ofrmReportViewer.selector = ViewerSelector.ItemRatesReport;
            ofrmReportViewer.ReportTitle = "Item Rates Report";
            ofrmReportViewer.ViewReport();

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
            colDrugTitle.Name = "Drug Name";
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
            colGroupTitle.Name = "Group";
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
            DataGridViewTextBoxColumn colRate = new DataGridViewTextBoxColumn();
            colRate.Name = "Rate";
            colRate.DataPropertyName = "Rate";
            colRate.Width = 50;
            dtv.Columns.Add(colRate);
            DataGridViewTextBoxColumn colVat = new DataGridViewTextBoxColumn();
            colVat.Name = "Vat";
            colVat.DataPropertyName = "Vat";
            colVat.Width = 50;
            dtv.Columns.Add(colVat);
            DataGridViewTextBoxColumn colDisc = new DataGridViewTextBoxColumn();
            colDisc.Name = "Disc";
            colDisc.DataPropertyName = "Disc";
            colDisc.Width = 50;
            dtv.Columns.Add(colDisc);
            DataGridViewTextBoxColumn colRackRate = new DataGridViewTextBoxColumn();
            colRackRate.Name = "RackRate";
            colRackRate.DataPropertyName = "RackRate";
            colRackRate.Width = 50;
            dtv.Columns.Add(colRackRate);
            DataGridViewTextBoxColumn colSlRate = new DataGridViewTextBoxColumn();
            colSlRate.Name = "SlRate";
            colSlRate.DataPropertyName = "SlRate";
            colSlRate.Width = 50;
            dtv.Columns.Add(colSlRate);
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
            //List<DrugMaster> oMedicines = new List<DrugMaster>();
            short index = 0;
            dgvProduction.Rows.Clear();
            dgvProduction.Visible = true;
            List<DrugMaster> test = new List<DrugMaster>();
            test.AddRange(phrSr.GetDrugMasterList(drugname).ToList());
           
            dgvProduction.DataSource = test.Select(data => new
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
                Vat = data.VAT,
                Disc = data.Discount,
                RackRate = data.Rackrate,
                SlRate = data.Slrate
            }).ToList();
            this.dgvProduction.Focus();
        }
        private void SearchListView(IEnumerable<DrugMaster> oResults, string searchString = "")
        {
            IEnumerable<DrugMaster> query;
            if (oResults != null)
            {
                if (!(searchString.Length > 0))
                {
                    query = oResults;
                }
                else
                {
                    query = (from oRes in oResults
                             where oRes.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select oRes);
                }

                lvItemRates.Items.Clear();
                foreach (DrugMaster dm in query)
                {
                    ListViewItem itm = new ListViewItem(dm.ID);
                    itm.SubItems.Add(dm.Name);
                    itm.SubItems.Add(dm.DrugGroup.Name);
                    itm.SubItems.Add(dm.DrugCompany.Name);
                    itm.SubItems.Add(dm.DrugCompany.ID);
                    itm.SubItems.Add(dm.DrugGroup.ID);
                    itm.SubItems.Add(dm.DrugUnit.ID);
                    itm.SubItems.Add(dm.DrugPackType.ID);
                    itm.SubItems.Add(dm.Urate.ToString());
                    itm.SubItems.Add(dm.VAT.ToString());
                    itm.SubItems.Add(dm.Discount.ToString());
                    itm.SubItems.Add(dm.Rackrate.ToString());
                    itm.SubItems.Add(dm.Slrate.ToString());
                    lvItemRates.Items.Add(itm);
                    //txtProductionID.Focus();
                }
                
            }
           
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        private void txtProductionID_KeyDown(object sender, KeyEventArgs e)
        {
            //int number2;

            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (int.TryParse(txtProductionID.Text, out number2))
            //    {
            //        txtProductionID.Select();
            //    }
            //    else
            //    {
            //        populateDataToGridDrug(dgvProduction, txtProductionID.Text);
            //        dgvProduction.Focus();
            //    }
            //}
            
            //if (e.KeyCode == Keys.Down)
            //{

            //    if (txtProductionID.Text.Length == 0)
            //    {
            //        MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
            //        return;
            //    }
            //    populateDatatoGrid(dgvProduction, txtProductionID.Text);
            //    dgvProduction.Focus();
            //    if (dgvProduction.RowCount == 0)
            //    {
            //        txtProductionID.Text = "";
            //        return;
            //    }

            //}
        }

        private void dgvProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            //setvaluesFromList(dgvProduction, sender);
        }
        private void setvaluesFromList(DataGridView dtv, object sender)
        {
            if (dtv.Rows.Count > 0)
            {
                int currentRow = dtv.CurrentRow.Index;
                //currentRow--;
                txtProductionID.Text = dtv["DRUGID", currentRow].Value.ToString();
                txtProductionName.Text = dtv["DRUG NAME", currentRow].Value.ToString();
                txtProductionCompanyID.Text = dtv["COMPANYID", currentRow].Value.ToString();
                txtProdCompName.Text = dtv["COMPANY", currentRow].Value.ToString();
                txtProductionGroupID.Text = dtv["GROUPID", currentRow].Value.ToString();
                txtProductGroupName.Text = dtv["GROUP", currentRow].Value.ToString();
                txtProductionUnitID.Text = dtv["UNITID", currentRow].Value.ToString();
                txtProductionPacketID.Text = dtv["TYPEID", currentRow].Value.ToString();
                txtURate.Text = dtv["Rate", currentRow].Value.ToString();
                txtvat.Text = dtv["Vat", currentRow].Value.ToString();
                txtDiscount.Text = dtv["Disc", currentRow].Value.ToString();
                txtRackRate.Text = dtv["RackRate", currentRow].Value.ToString();
                txtSlRate.Text = dtv["SlRate", currentRow].Value.ToString();
                dtv.Visible = false;
                txtProductionID.Focus();

            }
            else
            {
                dtv.Visible = false;
                txtProductionID.Focus();
            }

        }

        private void txtProductionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvItemRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItemRates.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvItemRates.SelectedItems[0];
                txtProductionID.Text = itm.SubItems[0].Text;
                txtProductionName.Text = itm.SubItems[1].Text;
                txtProductGroupName.Text = itm.SubItems[2].Text;
                txtProdCompName.Text = itm.SubItems[3].Text;
                txtProductionCompanyID.Text = itm.SubItems[4].Text;
                txtProductionGroupID.Text = itm.SubItems[5].Text;
                txtProductionUnitID.Text = itm.SubItems[6].Text;
                txtProductionPacketID.Text = itm.SubItems[7].Text;
                txtURate.Text = itm.SubItems[8].Text.ToString();
                txtvat.Text = itm.SubItems[9].Text.ToString();
                txtDiscount.Text = itm.SubItems[10].Text.ToString();
                txtRackRate.Text = itm.SubItems[11].Text.ToString();
                txtSlRate.Text = itm.SubItems[12].Text.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void smartLabel21_Click(object sender, EventArgs e)
        {

        }

        private void smartLabel4_Click(object sender, EventArgs e)
        {

        }

        private void cboPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintReport();
        }

        private void pnlMain_MouseClick(object sender, MouseEventArgs e)
        {
            dgvProduction.Visible = false;
        }

        private void dgvProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduction.Rows[e.RowIndex];
                
                txtProductionID.Text = row.Cells["DRUGID"].Value.ToString();
                txtProductionName.Text = row.Cells["DRUG NAME"].Value.ToString();
                txtProductionCompanyID.Text = row.Cells["COMPANYID"].Value.ToString();
                txtProdCompName.Text = row.Cells["COMPANY"].Value.ToString();
                txtProductionGroupID.Text = row.Cells["GROUPID"].Value.ToString();
                txtProductGroupName.Text = row.Cells["GROUP"].Value.ToString();
                txtProductionUnitID.Text = row.Cells["UNITID"].Value.ToString();
                txtProductionPacketID.Text = row.Cells["TYPEID"].Value.ToString();
                txtURate.Text = row.Cells["Rate"].Value.ToString();
                txtvat.Text = row.Cells["Vat"].Value.ToString();
                txtDiscount.Text = row.Cells["Disc"].Value.ToString();
                txtRackRate.Text = row.Cells["RackRate"].Value.ToString();
                txtSlRate.Text = row.Cells["SlRate"].Value.ToString();

                dgvProduction.Visible = false;

                txtProductionID.Focus();

            }
        }

        private void txtProductionID_KeyUp(object sender, KeyEventArgs e)
        {

           SearchListView(rate,txtProductionID.Text);
           //lvItemRates.Focus();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadListView(cboDrugCompany.SelectedValue.ToString());
        }
    }
}
