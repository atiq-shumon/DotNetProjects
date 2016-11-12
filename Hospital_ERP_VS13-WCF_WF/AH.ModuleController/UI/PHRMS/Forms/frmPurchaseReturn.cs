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

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmPurchaseReturn : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmPurchaseReturn()
        {
            InitializeComponent();
        }

        private void FormatGridProd(DataGridView dtv)
        {


            dtv.AutoGenerateColumns = false;
            dtv.AllowUserToAddRows = false;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "DrugID";
            itemid.DataPropertyName = "DrugID";
            itemid.Width = 0;
            itemid.Visible = false;
            dtv.Columns.Add(itemid);

            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "DrugName";
            itemname.DataPropertyName = "DrugName";
            itemname.Width = 230;
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
            
            DataGridViewTextBoxColumn groupname = new DataGridViewTextBoxColumn();
            groupname.Name = "Generic Name";
            groupname.DataPropertyName = "Group";
            groupname.Width = 150;
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

            DataGridViewTextBoxColumn ReturnQty = new DataGridViewTextBoxColumn();
            ReturnQty.Name = "ReturnQty";
            ReturnQty.DataPropertyName = "ReturnQty";
            ReturnQty.Width = 80;
            ReturnQty.Visible = true;
            ReturnQty.ReadOnly = false;
            dtv.Columns.Add(ReturnQty);

            DataGridViewTextBoxColumn POQuantity = new DataGridViewTextBoxColumn();
            POQuantity.Name = "POQuantity";
            POQuantity.DataPropertyName = "POQuantity";
            POQuantity.Width = 0;
            POQuantity.Visible = false;
            POQuantity.ReadOnly = true;
            dtv.Columns.Add(POQuantity);

            DataGridViewTextBoxColumn colMrrQty = new DataGridViewTextBoxColumn();
            colMrrQty.Name = "MrrQty";
            colMrrQty.DataPropertyName = "MrrQty";
            colMrrQty.Width = 80;
            colMrrQty.Visible = true;
            colMrrQty.ReadOnly = true;
            dtv.Columns.Add(colMrrQty);

            DataGridViewTextBoxColumn ExpDate = new DataGridViewTextBoxColumn();
            ExpDate.Name = "ExpireDate";
            ExpDate.DataPropertyName = "ExpireDate";
            ExpDate.Width = 80;
            ExpDate.Visible = true;
            ExpDate.ReadOnly = true;
            dtv.Columns.Add(ExpDate);

            DataGridViewTextBoxColumn colBatchID = new DataGridViewTextBoxColumn();
            colBatchID.Name = "Batch";
            colBatchID.DataPropertyName = "Batch";
            colBatchID.Width = 0;
            colBatchID.Visible = false;
            colBatchID.ReadOnly = true;
            dtv.Columns.Add(colBatchID);

            DataGridViewTextBoxColumn CompareQty = new DataGridViewTextBoxColumn();
            CompareQty.Name = "CompareQty";
            CompareQty.DataPropertyName = "CompareQty";
            CompareQty.Width = 0;
            CompareQty.Visible = false;
            CompareQty.ReadOnly = false;
            dtv.Columns.Add(CompareQty);

            DataGridViewTextBoxColumn colpharmacyid = new DataGridViewTextBoxColumn();
            colpharmacyid.Name = "PharmacyID";
            colpharmacyid.DataPropertyName = "PharmacyID";
            colpharmacyid.Width = 0;
            colpharmacyid.Visible = false;
            colpharmacyid.ReadOnly = true;
            dtv.Columns.Add(colpharmacyid);

            DataGridViewTextBoxColumn colpharmacy = new DataGridViewTextBoxColumn();
            colpharmacy.Name = "Pharmacy";
            colpharmacy.DataPropertyName = "Pharmacy";
            colpharmacy.Width = 0;
            colpharmacy.Visible = false;
            colpharmacy.ReadOnly = true;
            dtv.Columns.Add(colpharmacy);

            DataGridViewTextBoxColumn colmrrid = new DataGridViewTextBoxColumn();
            colmrrid.Name = "GRNNO";
            colmrrid.DataPropertyName = "GRNNO";
            colmrrid.Width = 0;
            colmrrid.Visible = false;
            colmrrid.ReadOnly = true;
            dtv.Columns.Add(colmrrid);

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
            checkBoxColumn.Visible = true;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(21, checkBoxColumn);
        }
        private void populateDataToGrid(DataGridView dtv, string mrid)
        {
            short index = 0;
            dtv.DefaultCellStyle.BackColor = Color.Bisque;
            dgvMrrDetails.Rows.Clear();
            dgvMrrDetails.Visible = true;
            List<MaterialReceive> list = new List<MaterialReceive>();
            list.Clear();
            list.AddRange(phrSr.GetMrrDetailsForPurchaseReturn(mrid).ToList());

            foreach(MaterialReceive data in list)
            {
                string[] row = new string[] { data.ItemsOrder.DrugMaster.ID,
                                              data.ItemsOrder.DrugMaster.Name,
                                              data.ItemsOrder.DrugMaster.DrugPackType.ID,
                                              data.ItemsOrder.DrugMaster.DrugUnit.ID,
                                              data.ItemsOrder.DrugMaster.DrugGroup.ID,
                                              data.ItemsOrder.DrugMaster.DrugCompany.ID,
                                              data.ItemsOrder.DrugMaster.DrugGroup.Name,
                                              data.ItemsOrder.DrugMaster.DrugCompany.Name,
                                              data.ItemsOrder.URate.ToString(),
                                              data.ItemsOrder.VAT.ToString(),
                                              data.ItemsOrder.Discount.ToString(),
                                              data.CompareQty.ToString(),
                                              data.ItemsOrder.POQty.ToString(),
                                              data.MRRQuantity.ToString(),
                                              data.ExpireDate.ToString("dd/MM/yyyy"),
                                              data.BatchNo,
                                              data.CompareQty.ToString(),
                                              data.Warehouse.TypeID,
                                              data.Warehouse.TypeName,
                                              data.MRRID
                };
                AddRowsToCollection(dgvMrrDetails,row,index);
                index++;
            }
            
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }
        private void frmPurchaseReturn_Load(object sender, EventArgs e)
        {


            FormatGridProd(dgvMrrDetails);
            FormatGridProd(dgvPurchaseReturn);
            dgvMrrDetails.Columns[20].Visible = false;
            //FormatData(dgvPODetails);
            //FormatData(dgvPurchaseReturn);
            //dgvPODetails.Visible = true;
             
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            LoadListData();
            populateDataToGrid(dgvMrrDetails, txtMrrID.Text);
            
        }
        private void LoadListData()
        {
            txtPOID.DataBindings.Clear();
            txtPharmacyID.DataBindings.Clear();
            txtPharmacyName.DataBindings.Clear();
            txtSupplierID.DataBindings.Clear();
            txtSupplierName.DataBindings.Clear();

            txtPharmacyID.DataBindings.Add("Text", phrSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "Warehouse.TypeID");
            txtPharmacyName.DataBindings.Add("Text", phrSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "Warehouse.TypeName");
            txtSupplierID.DataBindings.Add("Text", phrSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "Supplier.ID");
            txtSupplierName.DataBindings.Add("Text", phrSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "Supplier.Name");
            txtPOID.DataBindings.Add("Text", phrSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "PurchaseOrder.ID");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvPurchaseReturn.DefaultCellStyle.BackColor = Color.Aqua;
            dgvPurchaseReturn.Rows.Clear();


            foreach (DataGridViewRow row in dgvMrrDetails.Rows)
            {
                if (dgvMrrDetails.CurrentRow.Cells[0].Value != null)
                {
                    //int vrfy = phrSr.VarifyDrugForReturn(dgvMrrDetails.CurrentRow.Cells[0].Value.ToString());
                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                    if (isSelected)
                    {
                        for (int k = 0; k < dgvMrrDetails.Rows.Count - 1; k++)
                        {
                            if (Convert.ToBoolean(dgvMrrDetails.Rows[k].Cells["checkBoxColumn"].Value) == true)
                            {
                                if (phrSr.VarifyDrugForReturn(dgvMrrDetails.Rows[k].Cells[19].Value.ToString(), dgvMrrDetails.Rows[k].Cells[0].Value.ToString()) > 0)
                                {
                                    MessageBox.Show("This Product is already issued");
                                    return;
                                }

                            }
                        }

                        dgvPurchaseReturn.Rows.Add(row.Cells[0].Value.ToString(),
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
                                                row.Cells[20].Value.ToString()
                                            );
                        dgvPurchaseReturn.Columns["checkBoxColumn"].Visible = false;
                        //dgvPurchaseReturn.Columns[12].Visible = false;
                        //dgvPurchaseReturn.Columns[13].Visible = false;

                        this.dgvPurchaseReturn.Focus();
                    }
                }


            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dgvPurchaseReturn.Rows.Count == 0)
            {
                MessageBox.Show("Please Select Item ");
                return;
            }
            for (int i = 0; i < dgvPurchaseReturn.Rows.Count - 1; i++)
            {
                //float j = float.Parse(i.Cells["IssueQty"].Value.ToString()) - float.Parse(i.Cells["CompareQty"].Value.ToString());
                if (float.Parse(dgvPurchaseReturn.Rows[i].Cells["ReturnQty"].Value.ToString()) > float.Parse(dgvPurchaseReturn.Rows[i].Cells["CompareQty"].Value.ToString()))
                {
                    MessageBox.Show("Quantity Exceeded");
                    return;
                }
            }
          
            try
            {

                PurchaseReturn mstr = this.populatePurchaseReturn();
                string i = phrSr.SavePurchaseReturn(mstr);


                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturnID.Text = i;
                    btnSave.Enabled = false;
                    dgvMrrDetails.Rows.Clear();
                    dgvPurchaseReturn.Rows.Clear();
                    txtMrrID.Text = string.Empty;
                    txtReturnID.Text = string.Empty;
                    txtPharmacyID.Text = string.Empty;
                    txtPharmacyName.Text = string.Empty;
                    txtSupplierID.Text = string.Empty;
                    txtSupplierName.Text = string.Empty;
                    txtRemarks.Text = string.Empty;
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
        private PurchaseReturn populatePurchaseReturn()
        {
            PurchaseReturn oret = new PurchaseReturn();
                      
            oret.ReturnDate = DateTime.Parse(txtReturnDate.Text);
            oret.ReturnType = txtReturnTypeID.Text;
            oret.ReturnCause = txtRetCauseID.Text;
            oret.Remarks = txtRemarks.Text;

            Warehouse ophr = new Warehouse();
            ophr.TypeID = txtPharmacyID.Text;
            oret.Warehouse = ophr;

            PurchaseOrder po = new PurchaseOrder();
            po.ID = txtPOID.Text;
            oret.PurchaseOrder = po;

            MaterialReceive omaterialrec = new MaterialReceive();
            omaterialrec.MRRID = txtMrrID.Text;
            oret.MaterialReceive = omaterialrec;

            Supplier osupp = new Supplier();
            osupp.ID = txtSupplierID.Text;
            oret.Supplier = osupp;

            string IssueString = "";

            for (int i = 0; i < dgvPurchaseReturn.Rows.Count ; i++)
            {


                if (dgvPurchaseReturn.Rows[i].Cells[0].Value != null)
                    //IssueString += dr.Cells[0].Value.ToString() + "," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[7].Value.ToString() + "," + dr.Cells[8].Value.ToString() + "," + dr.Cells[9].Value.ToString() + "," + dr.Cells[14].Value.ToString() + "," + dr.Cells[15].Value.ToString() + "," + dr.Cells[16].Value.ToString() + "," + dr.Cells[17].Value.ToString() + "," + dr.Cells[18].Value.ToString() + "," + dr.Cells[19].Value.ToString() + "," + dr.Cells[20].Value.ToString() + "," + dr.Cells[21].Value.ToString();
                    IssueString += dgvPurchaseReturn.Rows[i].Cells[0].Value + "," + dgvPurchaseReturn.Rows[i].Cells[2].Value + "," + dgvPurchaseReturn.Rows[i].Cells[3].Value +
                                    "," + dgvPurchaseReturn.Rows[i].Cells[4].Value + "," + dgvPurchaseReturn.Rows[i].Cells[5].Value + "," + dgvPurchaseReturn.Rows[i].Cells[8].Value
                                    + "," + dgvPurchaseReturn.Rows[i].Cells[9].Value + "," + dgvPurchaseReturn.Rows[i].Cells[10].Value + "," +
                                    dgvPurchaseReturn.Rows[i].Cells[11].Value + "," + dgvPurchaseReturn.Rows[i].Cells[12].Value + "," + dgvPurchaseReturn.Rows[i].Cells[13].Value + "," +
                                   dgvPurchaseReturn.Rows[i].Cells[14].Value + "," + dgvPurchaseReturn.Rows[i].Cells[15].Value ;
                IssueString += ";";

                //v = v + 1;
            }
            oret.ReturnDetails = IssueString;


            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oret.EntryParameter = ep;


            return oret;
        }

        private void dgvPurchaseReturn_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgvPurchaseReturn.Columns["POQty"].Index)
            {
                dgvPurchaseReturn.Rows[e.RowIndex].ErrorText = "";
                int newInteger;

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgvPurchaseReturn.Rows[e.RowIndex].IsNewRow) { return; }
                if (!int.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgvPurchaseReturn.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }

        }

        private void treeviewPurchaseReturn_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtMrrID.Text = treeviewPurchaseReturn.SelectedNode.Text;
            LoadListData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvMrrDetails.Rows.Clear();
            dgvPurchaseReturn.Rows.Clear();
            txtMrrID.Text = string.Empty;
            txtReturnID.Text = string.Empty;
            txtPharmacyID.Text = string.Empty;
            txtPharmacyName.Text = string.Empty;
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }

        private void dgvPurchaseReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 20)
            {
                int selRowIndex = e.RowIndex;
                if (selRowIndex < 0)
                {
                    dgvPurchaseReturn.Rows.Clear();
                }
                else
                {
                    dgvPurchaseReturn.Rows.RemoveAt(selRowIndex);
                }

            }
        }
    }
}
