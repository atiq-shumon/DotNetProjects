using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;
using AH.ModuleController.UI.PHRMS.Reports.Viewer;
using AtiqsControlLibrary;
using System.Text.RegularExpressions;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmMRRTest : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        List<SCMTree> purchaseorder;
        private DateTimePicker oDateTimePicker;
        SmartDateTextBox dateBox = new SmartDateTextBox();
        string temp2;
        GroupBox dummy;
        int counter, currentSelection = 0;
        private int CurrentIndex;
        public frmMRRTest()
        {
            InitializeComponent();


            dummy = new GroupBox();
            dummy.Visible = false;
            dummy.Enabled = false;
            this.Controls.Add(dummy);
        }
        private void FormatData(DataGridView dtv)
        {

            dtv.AutoGenerateColumns = false;
            dtv.EditMode = DataGridViewEditMode.EditOnKeystroke;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            //dtv.DefaultCellStyle.Font = new Font("Garamond", 7F, GraphicsUnit.Pixel);
            DataGridViewTextBoxColumn Drugid = new DataGridViewTextBoxColumn();
            Drugid.Name = "Drugid";
            Drugid.DataPropertyName = "Drugid";
            Drugid.Width = 0;
            Drugid.Visible = false;
            dtv.Columns.Add(Drugid);
            DataGridViewTextBoxColumn drugname = new DataGridViewTextBoxColumn();
            drugname.Name = "Brand Name";
            drugname.DataPropertyName = "Drugname";
            drugname.Width = 250;
            drugname.Visible = true;
            drugname.ReadOnly = false;
            dtv.Columns.Add(drugname);

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

            DataGridViewTextBoxColumn groupname = new DataGridViewTextBoxColumn();
            groupname.Name = "Generic Name";
            groupname.DataPropertyName = "GroupName";
            groupname.Width = 280;
            groupname.Visible = true;
            groupname.ReadOnly = true;
            dtv.Columns.Add(groupname);

            DataGridViewTextBoxColumn compname = new DataGridViewTextBoxColumn();
            compname.Name = "CompanyName";
            compname.DataPropertyName = "CompanyName";
            compname.Width = 200;
            compname.Visible = true;
            compname.ReadOnly = true;
            dtv.Columns.Add(compname);

            DataGridViewTextBoxColumn UnitName = new DataGridViewTextBoxColumn();
            UnitName.Name = "UnitName";
            UnitName.DataPropertyName = "UnitName";
            UnitName.Width = 0;
            UnitName.Visible = false;
            UnitName.ReadOnly = true;
            dtv.Columns.Add(UnitName);

            DataGridViewTextBoxColumn TypeName = new DataGridViewTextBoxColumn();
            TypeName.Name = "TypeName";
            TypeName.DataPropertyName = "TypeName";
            TypeName.Width = 0;
            TypeName.Visible = false;
            TypeName.ReadOnly = true;
            dtv.Columns.Add(TypeName);

            DataGridViewTextBoxColumn ReqQty = new DataGridViewTextBoxColumn();
            ReqQty.Name = "ReqQty";
            ReqQty.DataPropertyName = "ReqQty";
            ReqQty.Width = 0;
            ReqQty.Visible = false;
            ReqQty.ReadOnly = true;
            dtv.Columns.Add(ReqQty);

            DataGridViewTextBoxColumn POQty = new DataGridViewTextBoxColumn();
            POQty.Name = "POQty";
            POQty.DataPropertyName = "POQty";
            POQty.Width = 60;
            POQty.Visible = true;
            POQty.ReadOnly = false;
            dtv.Columns.Add(POQty);

            DataGridViewTextBoxColumn colmrrqty = new DataGridViewTextBoxColumn();
            colmrrqty.Name = "GRNQty";
            colmrrqty.DataPropertyName = "GRNQty";
            colmrrqty.Width = 60;
            colmrrqty.Visible = true;
            colmrrqty.ReadOnly = false;
            dtv.Columns.Add(colmrrqty);

            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 70;
            colUrate.Visible = true;
            colUrate.ReadOnly = true;
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colslrate = new DataGridViewTextBoxColumn();
            colslrate.Name = "SaleRate";
            colslrate.DataPropertyName = "SaleRate";
            colslrate.Width = 60;
            colslrate.ReadOnly = true;
            dtv.Columns.Add(colslrate);

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



            DataGridViewTextBoxColumn colremqty = new DataGridViewTextBoxColumn();
            colremqty.Name = "RemQty";
            colremqty.DataPropertyName = "RemQty";
            colremqty.Width = 60;
            colremqty.Visible = true;
            colremqty.ReadOnly = true;
            dtv.Columns.Add(colremqty);


            // SmartDateTextBox smartDateTextBox = new SmartDateTextBox();

            DataGridViewTextBoxColumn ExpDate = new DataGridViewTextBoxColumn();
            ExpDate.Name = "ExpireDate";
            ExpDate.DataPropertyName = "ExpireDate";
            ExpDate.Width = 100;
            ExpDate.Visible = true;
            ExpDate.ReadOnly = true;
            dtv.Columns.Add(ExpDate);
            dtv.Columns[18].DefaultCellStyle.Format = "dd/MM/yyyy";



            DataGridViewTextBoxColumn colBatchNo = new DataGridViewTextBoxColumn();
            colBatchNo.Name = "BatchNo";
            colBatchNo.DataPropertyName = "BatchNo";
            colBatchNo.Width = 90;
            colBatchNo.Visible = true;
            colBatchNo.ReadOnly = false;
            dtv.Columns.Add(colBatchNo);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.Width = 55;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dtv.Columns.Add(Deletelink);

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Visible = false;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(21, checkBoxColumn);

        }
        private void frmMaterialReceive_Load(object sender, EventArgs e)
        {

            txtPOID.Select();
            cboCostCategoey.DisplayMember = "CategoryName";
            cboCostCategoey.ValueMember = "CategoryID";
            cboCostCategoey.DataSource = phrSr.GetCostcategory("CostcategoryTreeview", "", "").ToList();

            purchaseorder = phrSr.GetPONum().Select(c => new SCMTree { Date = c.PODate, ID = c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewPurchaseOrder, purchaseorder);

            FormatData(dgvPODetails);
            FormatData(dgvMrrDetails);
            //dgvPODetails.Columns[10].Visible = false;
            dgvPODetails.Columns["GRNQty"].Visible = false;
            dgvPODetails.Columns["ExpireDate"].Visible = false;
            dgvPODetails.Columns["BatchNo"].Visible = false;
            dgvPODetails.Columns["RemQty"].Visible = false;
            dgvPODetails.Columns[20].Visible = false;

            dgvMrrDetails.Controls.Add(dateBox);
            dateBox.Visible = false;

            dateBox.Leave += this.dateBox_ValueChanged;
            dateBox.KeyUp += this.dateBox_keyUP;
            dateBox.KeyDown += this.dateBox_keyDown;
          
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


        private void populateDataToGridDrug(DataGridView dtv, string poid)
        {
            short index = 0;
            dgvPODetails.Rows.Clear();
            dgvPODetails.Visible = true;
            List<PurchaseOrder> list = new List<PurchaseOrder>();
            list.Clear();
            list.AddRange(phrSr.GetPOList(poid).ToList());

            foreach (PurchaseOrder data in list)
            {
                string[] row = new string[]{ data.ItemsOrder.DrugMaster.ID,
                                             data.ItemsOrder.DrugMaster.Name,
                                             data.ItemsOrder.DrugMaster.DrugPackType.ID,
                                             data.ItemsOrder.DrugMaster.DrugUnit.ID,
                                             data.ItemsOrder.DrugMaster.DrugGroup.ID,
                                             data.ItemsOrder.DrugMaster.DrugCompany.ID,
                                             data.ItemsOrder.DrugMaster.DrugGroup.Name,
                                             data.ItemsOrder.DrugMaster.DrugCompany.Name,
                                             data.ItemsOrder.DrugMaster.DrugUnit.Name,
                                             data.ItemsOrder.DrugMaster.DrugPackType.Name,
                                             data.PurchaseRequisition.RequisitionQty.ToString(),
                                             data.ItemsOrder.POQty.ToString(),
                                             data.ItemsOrder.RemQty.ToString(),
                                             data.ItemsOrder.URate.ToString(),
                                             data.ItemsOrder.SlRate.ToString(),
                                             data.ItemsOrder.VAT.ToString(),
                                             data.ItemsOrder.Discount.ToString(),                                            
                                             data.ItemsOrder.RemQty.ToString()

                };
                AddRowsToCollection(dgvPODetails, row, index);
                index++;
            }

        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        private void LoadPODetailsByID()
        {

            txtPRNo.DataBindings.Clear();
            txtPharmacyID.DataBindings.Clear();
            txtPharmacyName.DataBindings.Clear();
            txtSupplierID.DataBindings.Clear();
            txtSupplierName.DataBindings.Clear();

            txtPharmacyID.DataBindings.Add("Text", phrSr.GetPOList(txtPOID.Text).ToList(), "Pharmacy.PharmacyID");
            txtPharmacyName.DataBindings.Add("Text", phrSr.GetPOList(txtPOID.Text).ToList(), "Pharmacy.PharmacyTitle");
            txtSupplierID.DataBindings.Add("Text", phrSr.GetPOList(txtPOID.Text).ToList(), "Supplier.ID");
            txtSupplierName.DataBindings.Add("Text", phrSr.GetPOList(txtPOID.Text).ToList(), "Supplier.Name");
            txtPRNo.DataBindings.Add("Text", phrSr.GetPOList(txtPOID.Text).ToList(), "PurchaseRequisition.ID");


        }

        private void PrintReport(string mrid)
        {
            frmReportViewer ofrmreportviewer = new frmReportViewer();
            ofrmreportviewer.selector = ViewerSelector.MrrReport;
            ofrmreportviewer.MrrID = mrid;
            ofrmreportviewer.ReportTitle = "GRN Report";
            ofrmreportviewer.ViewReport();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtChallanNo" };
            Control control = Utility.ReqFieldValidator(this, vf);
            string m = DateTime.Now.ToString("dd/MM/yyyy");

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            for (int i = 0; i < dgvMrrDetails.Rows.Count; i++)
            {
                if (dgvMrrDetails.Rows[i].Cells["Drugid"].Value == null ||
                   dgvMrrDetails.Rows[i].Cells["CompanyID"].Value == null ||
                   dgvMrrDetails.Rows[i].Cells["GroupID"].Value == null ||
                   dgvMrrDetails.Rows[i].Cells["UnitID"].Value == null ||
                   dgvMrrDetails.Rows[i].Cells["TypeID"].Value == null ||
                   dgvMrrDetails.Rows[i].Cells["POQty"].Value == null ||
                   dgvMrrDetails.Rows[i].Cells["GRNQty"].Value == null ||
                   dgvMrrDetails.Rows[i].Cells["Rate"].Value == null ||
                   dgvMrrDetails.Rows[i].Cells["Vat"].Value == null ||
                   dgvMrrDetails.Rows[i].Cells["Discount"].Value == null)
                {
                    MessageBox.Show("GRNDetails value cannot be null");
                    return;
                }
               

            }


            //if (Utility.ParseFloat(txtRemQty.Text) == 0)
            //{
            //    MessageBox.Show("All Item already has");
            //    return;
            //}

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
                    txtMrNo.Text = i.ToString();
                    PrintReport(i);
                    btnSave.Enabled = false;
                    txtPRNo.Text = string.Empty;                    
                    txtPOID.Text = string.Empty;
                    txtChallanNo.Text = string.Empty;
                    txtPharmacyID.Text = string.Empty;
                    txtPharmacyName.Text = string.Empty;
                    txtSupplierID.Text = string.Empty;
                    txtSupplierName.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
                    dgvPODetails.Rows.Clear();
                    dgvMrrDetails.Rows.Clear();
                    dateBox.Visible = false;
                    treeviewPurchaseOrder.Nodes.Clear();
                    List<SCMTree> purchaseorder = phrSr.GetPONum().Select(c => new SCMTree { Date = c.PODate, ID = c.ID }).ToList();
                    Utility.PopulateTreeSCM(treeviewPurchaseOrder, purchaseorder);
                    //btnNew.PerformClick();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private MaterialReceive populateMatReceive()
        {
            MaterialReceive mr = new MaterialReceive();
            //mr.PRID = txtPRID.Text;

            mr.TransactionType = "MO";
            mr.MRRDate = DateTime.Parse(txtMrrDate.Text);
            mr.MRRType = "1";


            mr.ChallanNo = txtChallanNo.Text;
            mr.ChallanDate = DateTime.Parse(txtChallanDate.Text);
            mr.VoucherNo = "1234";
            mr.Remarks = txtRemarks.Text;

            CostCategoryTreeview ocostcenter = new CostCategoryTreeview();
            ocostcenter.CategoryID = cboCostCategoey.SelectedValue.ToString();
            ocostcenter.CostCenterID = cboCostCenter.SelectedValue.ToString();
            mr.CostCategoryTreeview = ocostcenter;

            PurchaseOrder po = new PurchaseOrder();
            po.ID = txtPOID.Text;

            PurchaseRequisition oreq = new PurchaseRequisition();
            oreq.ID = txtPRNo.Text;
            po.PurchaseRequisition = oreq;

            mr.PurchaseOrder = po;



            Pharmacy phar = new Pharmacy();
            phar.PharmacyID = txtPharmacyID.Text;
            mr.Pharmacy = phar;

            Supplier supp = new Supplier();
            supp.ID = txtSupplierID.Text;
            mr.Supplier = supp;
            //CultureInfo us = new CultureInfo("en-US");   

            string MrrString = "";

            foreach (DataGridViewRow dr in dgvMrrDetails.Rows)
            {
                MrrString += dr.Cells[0].Value.ToString() + "," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[13].Value.ToString() + "," + dr.Cells[14].Value.ToString() + "," + dr.Cells[15].Value.ToString() + "," + dr.Cells[16].Value.ToString() + "," + dr.Cells[10].Value.ToString() + "," + dr.Cells[11].Value.ToString() + "," + dr.Cells[12].Value.ToString() + "," + dr.Cells[18].Value.ToString() + "," + dr.Cells[19].Value.ToString();
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

        private void dgvPODetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDrugid.Text = dgvPODetails.CurrentRow.Cells["Drugid"].Value.ToString();
            txtDrugName.Text = dgvPODetails.CurrentRow.Cells["Brand Name"].Value.ToString();
            txtGenericName.Text = dgvPODetails.CurrentRow.Cells["Generic Name"].Value.ToString();
            txtGrnQty.Text = dgvPODetails.CurrentRow.Cells["GRNQty"].Value.ToString();
            txtRemQty.Text = dgvPODetails.CurrentRow.Cells["RemQty"].Value.ToString();
            txtpurRate.Text = dgvPODetails.CurrentRow.Cells["Rate"].Value.ToString();
            txtSlrate.Text = dgvPODetails.CurrentRow.Cells["SaleRate"].Value.ToString();
            CurrentIndex = dgvPODetails.CurrentRow.Index;

        }


        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {

            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            dgvMrrDetails.CurrentCell.Value = txtDateTimePicker.Text.ToString();
        }


        private void txtDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            txtDateTimePicker.Visible = false;
        }

        private void treeviewPurchaseOrder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            string strPOID= treeviewPurchaseOrder.SelectedNode.Text;
            txtPOID.Text = "";
            txtPRNo.Text = string.Empty;
            txtPharmacyID.Text = string.Empty;
            txtPharmacyName.Text = string.Empty;
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtMrNo.Text = string.Empty;
            dgvPODetails.Rows.Clear();
            //txtPOID.Text = treeviewPurchaseOrder.SelectedNode.Text;

            foreach( SCMTree objscm in purchaseorder  )
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
      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtGrnQty.Text) <= 0)
            {
                MessageBox.Show("GRN Quantity cannot be zero");
                return;
            }
            if (float.Parse(txtpurRate.Text) > float.Parse(txtSlrate.Text))
            {
                MessageBox.Show("Sales Rate can not be less than Purchase Rate");
                return;
            }
            if (Convert.ToInt32(txtGrnQty.Text) > Convert.ToInt32(txtRemQty.Text))
            {
                MessageBox.Show("GRN Qty can not be more than  RemQty");
                return;
            }
            if (phrSr.VarifyDuplicateBatch(txtPharmacyID.Text, txtDrugid.Text, txtBatchId.Text) > 0)
            {
                MessageBox.Show("The Batchno of this Drug has already exist.", "Important Message");
                return;
            }
            if (txtBatchId.Text == "")
            {
                MessageBox.Show("Please fill Batch No");
                return;
            }
            if (Convert.ToString(txtBatchId.Text).Length > 12)
            {
                MessageBox.Show("Batch no must be 12 Digits Long!");
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
                                         txtGrnQty.Text,
                                         dgvPODetails.Rows[CurrentIndex].Cells[13].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[14].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[15].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[16].Value.ToString(),
                                         dgvPODetails.Rows[CurrentIndex].Cells[17].Value.ToString(),
                                         txtExpDatetimepicker.Text,
                                         txtBatchId.Text,
                                         dgvPODetails.Rows[CurrentIndex].Cells[20].Value.ToString()
                                     );
                dgvMrrDetails.Columns["checkBoxColumn"].Visible = false;
                dgvMrrDetails.Columns["POQty"].Visible = false;
                dgvMrrDetails.Columns["Rate"].Visible = false;
                dgvMrrDetails.Columns["CompanyName"].Visible = false;
                this.dgvMrrDetails.Focus();
            }
          else
            {
                dgvMrrDetails.CurrentRow.Cells[12].Value = txtGrnQty.Text;
                dgvMrrDetails.CurrentRow.Cells[18].Value = txtExpDatetimepicker.Text;
                dgvMrrDetails.CurrentRow.Cells[19].Value = txtBatchId.Text;
            }

        }

        private bool isDuplicateFound()
        {
            if (dgvMrrDetails.Rows.Count >0)
               foreach (DataGridViewRow row in dgvMrrDetails.Rows)
                {
                    if (row.Cells["Drugid"].Value.ToString() == txtDrugid.Text)
                    {
                        return true;
                    }
            
            }
            
           return false;

        }

        private void dgvMrrDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            populateDataToGridDrug(dgvPODetails, txtPOID.Text);
            LoadPODetailsByID();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPRNo.Text = string.Empty;
            txtMrNo.Text = string.Empty;
            txtPOID.Text = string.Empty;
            txtPharmacyID.Text = string.Empty;
            txtPharmacyName.Text = string.Empty;
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtChallanNo.Text = string.Empty;
            dgvPODetails.Rows.Clear();
            dgvMrrDetails.Rows.Clear();
            dateBox.Visible = false;
            //dgvMrrDetails.Refresh();
            btnSave.Enabled = true;
        }

        private void dgvMrrDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (e.ColumnIndex == dgvPODetails.Columns["GRNQty"].Index)
            //{
            //    dgvPODetails.Rows[e.RowIndex].ErrorText = "";
            //    int newInteger;

            //    // Don't try to validate the 'new row' until finished  
            //    // editing since there 
            //    // is not any point in validating its initial value. 
            //    if (dgvPODetails.Rows[e.RowIndex].IsNewRow) { return; }
            //    if (!int.TryParse(e.FormattedValue.ToString(),
            //        out newInteger) || newInteger < 0)
            //    {
            //        e.Cancel = true;
            //        dgvPODetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
            //    }
            //}
        }

        private void cboCostCategoey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCostCategoey.SelectedValue != null)
            {
                cboCostCenter.DisplayMember = "CostcenterName";
                cboCostCenter.ValueMember = "CostCenterID";
                cboCostCenter.DataSource = phrSr.GetCostcenter("CostcenterTreeview", cboCostCategoey.SelectedValue.ToString(), "").ToList();
            }
        }

        private void dgvMrrDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 20)
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

            //if (e.ColumnIndex == 0 && e.RowIndex != this.dgvPODetails.NewRowIndex)
            //{
            //    double d = double.Parse(e.Value.ToString());
            //    e.Value = d.ToString("0.00##");
            //}
        }

        private void dgvMrrDetails_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 18 && e.RowIndex >= 0)
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
            //if (e.ColumnIndex == 19 && e.RowIndex >= 0)
            //{
            //    dateBox.Text = " / /";
            //    dateBox.Visible = false;
            //}
            txtDrugid.Text = dgvMrrDetails.CurrentRow.Cells["Drugid"].Value.ToString();
            txtDrugName.Text = dgvMrrDetails.CurrentRow.Cells["Brand Name"].Value.ToString();
            txtGenericName.Text = dgvMrrDetails.CurrentRow.Cells["Generic Name"].Value.ToString();
            txtGrnQty.Text = dgvMrrDetails.CurrentRow.Cells["GRNQty"].Value.ToString();
            txtExpDatetimepicker.Text = dgvMrrDetails.CurrentRow.Cells["ExpireDate"].Value.ToString();
            txtBatchId.Text = dgvMrrDetails.CurrentRow.Cells["BatchNo"].Value.ToString();
        }

        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    System.Text.StringBuilder dateString = new System.Text.StringBuilder();
                    DateTime theDate = DateTime.Parse(formatting.Value.ToString());

                    dateString.Append(theDate.Day);
                    dateString.Append("/");
                    dateString.Append(theDate.Month);
                    dateString.Append("/");
                    dateString.Append(theDate.Year.ToString().Substring(2));
                    formatting.Value = dateString.ToString();
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    // Set to false in case there are other handlers interested trying to
                    // format this DataGridViewCellFormattingEventArgs instance.
                    formatting.FormattingApplied = false;
                }
            }
        }

        private void dgvMrrDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            if ((dgvMrrDetails.Focused) && (dgvMrrDetails.CurrentCell.ColumnIndex == 18))
            {
                dgvMrrDetails.CurrentCell.Value = dateBox.Text;
            }
        }

        private void dgvMrrDetails_Scroll(object sender, ScrollEventArgs e)
        {
            if (this.dateBox.Visible)
            {
                //we have to adjust the location for the MaskedTextBox while scrolling
                Rectangle rect = this.dgvMrrDetails.GetCellDisplayRectangle(
                    this.dgvMrrDetails.CurrentCell.ColumnIndex,
                    this.dgvMrrDetails.CurrentCell.RowIndex, true);
                this.dateBox.Location = rect.Location;
            }
        }

        private void chkboxPR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxPR.Checked == true)
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

        private void dgvMrrDetails_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
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
        }

        private void txtBatchId_Leave(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMrrDetails.Rows)
            {
                if (row.Cells["Drugid"].Value.ToString() == txtDrugid.Text)
                {
                    row.Cells["ExpireDate"].Value = txtExpDatetimepicker.Text;
                    row.Cells["BatchNo"].Value = txtBatchId.Text;

                }

            }
        }

        private void btnAddExpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMrrDetails.Rows)
            {
                if (row.Cells["Drugid"].Value.ToString() == txtDrugid.Text)
                {
                    row.Cells["ExpireDate"].Value = txtExpDatetimepicker.Text;
                    row.Cells["BatchNo"].Value = txtBatchId.Text;
                   
                }

            }
        }

        private void dgvPODetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                txtBatchId.Focus();
            }
        }

        private void txtBatchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnAdd.Focus();
            }
        }

       
    }
}




