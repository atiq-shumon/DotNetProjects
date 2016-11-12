using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmPurchaseReturn : AH.Shared.UI.frmSmartFormStandard
    {
        
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmPurchaseReturn()
        {
            InitializeComponent();
        }

        private void frmPurchaseReturn_Load(object sender, EventArgs e)
        {
            
            FormatGridProd(dgvMrrDetails);
            FormatGridProd(dgvPurchaseReturn);
            dgvMrrDetails.Columns[12].Visible = false;
            dgvMrrDetails.Columns[13].Visible = false;
           
            //dgvMrrDetails.Columns[17].Visible = false;
        }
        private void FormatGridProd(DataGridView dtv)
        {


            dtv.AutoGenerateColumns = false;
            dtv.AllowUserToAddRows = false;
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
            compname.Width = 0;
            compname.Visible = false;
            compname.ReadOnly = true;
            dtv.Columns.Add(compname);

            DataGridViewTextBoxColumn brandname = new DataGridViewTextBoxColumn();
            brandname.Name = "Brand";
            brandname.DataPropertyName = "Brand";
            brandname.Width = 100;
            brandname.Visible = true;
            brandname.ReadOnly = true;
            dtv.Columns.Add(brandname);

            DataGridViewTextBoxColumn modelname = new DataGridViewTextBoxColumn();
            modelname.Name = "Model";
            modelname.DataPropertyName = "Model";
            modelname.Width = 100;
            modelname.Visible = true;
            modelname.ReadOnly = true;
            dtv.Columns.Add(modelname);

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
            ReturnQty.Name = "RetQty";
            ReturnQty.DataPropertyName = "RetQty";
            ReturnQty.Width = 60;
            ReturnQty.Visible = true;
            ReturnQty.ReadOnly = false;
            dtv.Columns.Add(ReturnQty);

            DataGridViewTextBoxColumn POQuantity = new DataGridViewTextBoxColumn();
            POQuantity.Name = "POQty";
            POQuantity.DataPropertyName = "POQty";
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
            ExpDate.Width = 100;
            ExpDate.Visible = true;
            ExpDate.ReadOnly = true;
            dtv.Columns.Add(ExpDate);

            DataGridViewTextBoxColumn colGRNID = new DataGridViewTextBoxColumn();
            colGRNID.Name = "GRNNO";
            colGRNID.DataPropertyName = "GRNNO";
            colGRNID.Width = 120;
            colGRNID.Visible = true;
            colGRNID.ReadOnly = true;
            dtv.Columns.Add(colGRNID);

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


            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Visible = true;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(24, checkBoxColumn);
        }
        private void populateDataToGrid(DataGridView dtv, string mrid)
        {

            dtv.DefaultCellStyle.BackColor = Color.Bisque;

            short index = 0;

            dgvMrrDetails.Visible = true;
            dgvMrrDetails.Rows.Clear();
            List<MaterialReceive> list = new List<MaterialReceive>();
            //list.Clear();
            list.AddRange(invSr.GetMrrDetailsForPurchaseReturn(mrid).ToList());
            foreach (MaterialReceive data in list)
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
                                              data.ItemOrder.Rate.ToString(),
                                              data.ItemOrder.VAT.ToString(),
                                              data.ItemOrder.Discount.ToString(),
                                              data.ReturnQty.ToString(),
                                              data.ItemOrder.POQty.ToString(),
                                              data.MrrQuantity.ToString(),
                                              data.ExpDate.ToString("dd/MM/yyyy"),
                                              data.ID,
                                              data.BatchID,
                                              data.CompareQty.ToString()
               

            };
                AddRowsToCollection(dgvMrrDetails,row,index);
                index++;
            }
            
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }
        private void LoadPODetailsByID()
        {
            txtPOID.DataBindings.Clear();
          
            txtStoreID.DataBindings.Clear();
            txtStoreName.DataBindings.Clear();
            txtSupplierID.DataBindings.Clear();
            txtSupplierName.DataBindings.Clear();
            
            txtStoreID.DataBindings.Add("Text", invSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "StoreLocation.ID");
            txtStoreName.DataBindings.Add("Text", invSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "StoreLocation.Name");
            txtSupplierID.DataBindings.Add("Text", invSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "Supplier.ID");
            txtSupplierName.DataBindings.Add("Text", invSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "Supplier.Name");
            txtPOID.DataBindings.Add("Text", invSr.GetMrrDetailsForPurchaseReturn(txtMrrID.Text).ToList(), "PurchaseOrder.ID");
           
        }

        private void treeviewPurchaseReturn_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //txtPOID.Text = treeviewPurchaseReturn.SelectedNode.Text;
            //LoadPODetailsByID();
            //populateDataToGridDrug(dgvPODetails, txtPOID.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvMrrDetails.Rows.Count == 0)
            {
                MessageBox.Show("Please put GRN No");
                return;
            }
            dgvPurchaseReturn.DefaultCellStyle.BackColor = Color.Aqua;
            dgvPurchaseReturn.Rows.Clear();
           

            foreach (DataGridViewRow row in dgvMrrDetails.Rows)
            {
                if (dgvMrrDetails.CurrentRow.Cells[0].Value !=null)
                {

                
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {

                    for (int k = 0; k < dgvMrrDetails.Rows.Count-1; k++)
                    {
                        if (Convert.ToBoolean(dgvMrrDetails.Rows[k].Cells["checkBoxColumn"].Value) == true)
                        {
                            //int vrfy = invSr.VarifyItemForReturn(dgvMrrDetails.CurrentRow.Cells[0].Value.ToString());
                            if (invSr.VarifyItemForReturn(dgvMrrDetails.Rows[k].Cells[21].Value.ToString(),dgvMrrDetails.Rows[k].Cells[0].Value.ToString()) > 0)
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
                                               row.Cells[20].Value.ToString(),
                                               row.Cells[21].Value.ToString(),
                                               row.Cells[22].Value.ToString(),
                                               row.Cells[23].Value.ToString()
                                           );
                    dgvPurchaseReturn.Columns["checkBoxColumn"].Visible = false;
                    dgvPurchaseReturn.Columns[12].Visible = false;
                    dgvPurchaseReturn.Columns[13].Visible = false;

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
            if(dgvPurchaseReturn.Rows.Count == 0)
            {
                MessageBox.Show("Please Select Item ");
                return;
            }
            for (int i = 0; i < dgvPurchaseReturn.Rows.Count; i++)
            {
                //float j = float.Parse(i.Cells["IssueQty"].Value.ToString()) - float.Parse(i.Cells["CompareQty"].Value.ToString());
                if (float.Parse(dgvPurchaseReturn.Rows[i].Cells["RetQty"].Value.ToString()) > float.Parse(dgvPurchaseReturn.Rows[i].Cells["CompareQty"].Value.ToString()))
                {
                    MessageBox.Show("Quantity Exceeded");
                    return;
                }
            }

            try
            {

                PurchaseReturn mstr = this.populatePurchaseReturn();
                string i = invSr.SavePurchaseReturn(mstr);

                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturnID.Text = i;
                    dgvPurchaseReturn.Rows.Clear();
                    dgvMrrDetails.Rows.Clear();
                    txtMrrID.Text = string.Empty;
                    txtPOID.Text = string.Empty;
                    txtStoreID.Text = string.Empty;
                    txtStoreName.Text = string.Empty;
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
            //oret.ID = txtReturnID.Text;
            //oret.BatchNo = "01546";
            oret.ReturnDate = DateTime.Parse(txtReturnDate.Text);
            oret.ReturnType = txtReturnTypeID.Text;
            oret.ReturnCause = txtRetCauseID.Text;
            oret.Remarks = txtRemarks.Text;

            //Pharmacy ophr = new Pharmacy();
            //ophr.PharmacyID = txtPharmacyID.Text;
            //oret.Pharmacy = ophr;
            StoreLocation ostore = new StoreLocation();
            ostore.ID = txtStoreID.Text;
            oret.StoreLocation = ostore;

            PurchaseOrder po = new PurchaseOrder();
            po.ID = txtPOID.Text;
            oret.PurchaseOrder = po;

            MaterialReceive omaterialrec = new MaterialReceive();
            omaterialrec.ID = txtMrrID.Text;
            oret.MaterialReceive = omaterialrec;

            Supplier osupp = new Supplier();
            osupp.ID = txtSupplierID.Text;
            oret.Supplier = osupp;

            int v = 0;
            string IssueString = "";
           
            
            for (int i = 0; i < dgvPurchaseReturn.Rows.Count; i++ )
            {

                
                if (dgvPurchaseReturn.Rows[i].Cells[0].Value != null)
                    //IssueString += dr.Cells[0].Value.ToString() + "," + dr.Cells[2].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[7].Value.ToString() + "," + dr.Cells[8].Value.ToString() + "," + dr.Cells[9].Value.ToString() + "," + dr.Cells[14].Value.ToString() + "," + dr.Cells[15].Value.ToString() + "," + dr.Cells[16].Value.ToString() + "," + dr.Cells[17].Value.ToString() + "," + dr.Cells[18].Value.ToString() + "," + dr.Cells[19].Value.ToString() + "," + dr.Cells[20].Value.ToString() + "," + dr.Cells[21].Value.ToString();
                    IssueString += dgvPurchaseReturn.Rows[i].Cells[0].Value + "," + dgvPurchaseReturn.Rows[i].Cells[2].Value + "," + dgvPurchaseReturn.Rows[i].Cells[3].Value +
                                    "," + dgvPurchaseReturn.Rows[i].Cells[4].Value + "," + dgvPurchaseReturn.Rows[i].Cells[5].Value + "," + dgvPurchaseReturn.Rows[i].Cells[6].Value + "," +
                                    dgvPurchaseReturn.Rows[i].Cells[7].Value + "," + dgvPurchaseReturn.Rows[i].Cells[8].Value + "," + dgvPurchaseReturn.Rows[i].Cells[9].Value + "," + dgvPurchaseReturn.Rows[i].Cells[14].Value + "," +
                                    dgvPurchaseReturn.Rows[i].Cells[15].Value + "," + dgvPurchaseReturn.Rows[i].Cells[16].Value + "," + dgvPurchaseReturn.Rows[i].Cells[17].Value + "," +
                                   dgvPurchaseReturn.Rows[i].Cells[18].Value + "," + dgvPurchaseReturn.Rows[i].Cells[19].Value + "," + dgvPurchaseReturn.Rows[i].Cells[20].Value + "," + dgvPurchaseReturn.Rows[i].Cells[22].Value;
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

        private void smartLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtReturnID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            populateDataToGrid(dgvMrrDetails, txtMrrID.Text);
            LoadPODetailsByID();
        }

        private void txtMrrID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSearch.Select();
            }
        }

        private void txtReturnDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Select();
            }
        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtReturnDate.Select();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvMrrDetails.Rows.Clear();
            dgvPurchaseReturn.Rows.Clear();
            txtPOID.Text = string.Empty;
            txtStoreID.Text = string.Empty;
            txtStoreName.Text = string.Empty;
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }
    }
}
