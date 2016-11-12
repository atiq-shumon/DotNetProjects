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
    public partial class frmTransferReceive : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
             
        public frmTransferReceive()
        {
            InitializeComponent();
        }
      
    
        private void PopulateTreeViewControl()
        {
            TreeNode parentNode;
            TreeNode childNode;
            
            List<PharmacyUser> pharmacylist = phrSr.GetUserByID(Utility.UserId).ToList();
           
            foreach (PharmacyUser pharmacy in pharmacylist)
            {
                parentNode = new TreeNode(pharmacy.Warehouse.TypeName);
                trList.Nodes.Add(parentNode);
                List<TransferRequisition> trid = phrSr.GetTRID(pharmacy.Warehouse.TypeID).ToList();
                foreach (TransferRequisition transfer in trid)
                {
                    childNode = parentNode.Nodes.Add(transfer.ID);                    
                }
                parentNode.Collapse();  
                
            }
        }
       

        private void frmTransferReceive_Load(object sender, EventArgs e)
        {
            PopulateTreeViewControl();
          
            txtPharmacy.DataBindings.Clear();
            
            txtPharmacy.DataBindings.Add("Text", phrSr.GetUserByID(Utility.UserId).ToList(), "Warehouse.TypeID");            
            FormatGridProd(dgvTRDetails);
            FormatGridProd(dgvStockDetails);
            FormatGridProd(dgvTransferReceive);
            dgvTRDetails.Columns["PharmacyID"].Visible = false;
            dgvTRDetails.Columns["Rate"].Visible = false;
            dgvTRDetails.Columns["SlRate"].Visible = false;
            dgvTRDetails.Columns["Vat"].Visible = false;
            dgvTRDetails.Columns["Disc"].Visible = false;
            dgvTRDetails.Columns["MRRID"].Visible = false;
            dgvTRDetails.Columns["BatchID"].Visible = false;
            dgvTRDetails.Columns["ExpireDate"].Visible = false;
            dgvTRDetails.Columns["checkBoxColumn"].Visible = false;
            dgvTRDetails.Columns[22].Visible = false;
            dgvTransferReceive.Columns["TrrQty"].ReadOnly = true;
            dgvStockDetails.Columns["PharmacyID"].Visible = false;
            grpStockDet.Visible = false;
            dgvStockDetails.Visible = false;
            btnAddItems.Visible = false;
            btnCloseStockDetails.Visible = false;

        }
        private void FormatGridProd(DataGridView dtv)
        {

            dtv.AutoGenerateColumns = false;
            //dtv.EditMode = DataGridViewEditMode.EditOnKeystroke;
            //dtv.Location = new Point(lvPurchaseOrder.Location.X, lvPurchaseOrder.Location.Y);

            DataGridViewTextBoxColumn colTrId = new DataGridViewTextBoxColumn();
            colTrId.Name = "TRID";
            colTrId.DataPropertyName = "TRID";
            colTrId.Width = 80;
            colTrId.Visible = true;
            dtv.Columns.Add(colTrId);

            DataGridViewTextBoxColumn colDrugId = new DataGridViewTextBoxColumn();
            colDrugId.Name = "DRUGID";
            colDrugId.DataPropertyName = "DRUGID";
            colDrugId.Width = 80;
            colDrugId.Visible = true;
            dtv.Columns.Add(colDrugId);
            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn();
            colDrugTitle.Name = "Brand Name";
            colDrugTitle.DataPropertyName = "DRUGNAME";
            colDrugTitle.Width = 210;
            colDrugTitle.ReadOnly = true;
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
            colCompanyTitle.Width = 200;
            colCompanyTitle.Visible = true;
            colCompanyTitle.ReadOnly = true;
            dtv.Columns.Add(colCompanyTitle);

            DataGridViewTextBoxColumn colGroupTitle = new DataGridViewTextBoxColumn();
            colGroupTitle.Name = "Generic Name";
            colGroupTitle.DataPropertyName = "GROUPNAME";
            colGroupTitle.Width = 230;
            colGroupTitle.Visible = true;
            colGroupTitle.ReadOnly = true;
            dtv.Columns.Add(colGroupTitle);

            DataGridViewTextBoxColumn colUnitName = new DataGridViewTextBoxColumn();
            colUnitName.Name = "Unit";
            colUnitName.DataPropertyName = "UNITNAME";
            colUnitName.Width = 0;
            colUnitName.Visible = false;
            colUnitName.ReadOnly = true;
            dtv.Columns.Add(colUnitName);

            DataGridViewTextBoxColumn colPackName = new DataGridViewTextBoxColumn();
            colPackName.Name = "Unit Pack";
            colPackName.DataPropertyName = "PACKNAME";
            colPackName.Width = 0;
            colPackName.Visible = false;
            colPackName.ReadOnly = true;
            dtv.Columns.Add(colPackName);

            DataGridViewTextBoxColumn colpharmacyid = new DataGridViewTextBoxColumn();
            colpharmacyid.Name = "PharmacyID";
            colpharmacyid.DataPropertyName = "PharmacyID";
            colpharmacyid.Width = 50;
            colpharmacyid.Visible = true;
            dtv.Columns.Add(colpharmacyid);

            DataGridViewTextBoxColumn colreqqty = new DataGridViewTextBoxColumn();
            colreqqty.Name = "ReqQty";
            colreqqty.DataPropertyName = "ReqQty";
            colreqqty.Width = 60;
            colreqqty.ReadOnly = true;
            dtv.Columns.Add(colreqqty);

            DataGridViewTextBoxColumn coltrrqty = new DataGridViewTextBoxColumn();
            coltrrqty.Name = "TrrQty";
            coltrrqty.DataPropertyName = "TrrQty";
            coltrrqty.Width = 60;
            coltrrqty.ReadOnly = false;
            coltrrqty.DefaultCellStyle.Format = "0.00##";
            dtv.Columns.Add(coltrrqty);

            DataGridViewTextBoxColumn colUrate = new DataGridViewTextBoxColumn();
            colUrate.Name = "Rate";
            colUrate.DataPropertyName = "Rate";
            colUrate.Width = 70;
            colUrate.DefaultCellStyle.Format = "0.00##";
            dtv.Columns.Add(colUrate);

            DataGridViewTextBoxColumn colSlrate = new DataGridViewTextBoxColumn();
            colSlrate.Name = "SlRate";
            colSlrate.DataPropertyName = "SlRate";
            colSlrate.Width = 70;
            colSlrate.Visible = true;
            dtv.Columns.Add(colSlrate);

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

            DataGridViewTextBoxColumn colMrrID = new DataGridViewTextBoxColumn();
            colMrrID.Name = "MRRID";
            colMrrID.DataPropertyName = "MRRID";
            colMrrID.Width = 70;
            colMrrID.Visible = true;
            dtv.Columns.Add(colMrrID);

            DataGridViewTextBoxColumn colBatchID = new DataGridViewTextBoxColumn();
            colBatchID.Name = "BatchID";
            colBatchID.DataPropertyName = "BatchID";
            colBatchID.Width = 70;
            colBatchID.ReadOnly = true;
            colBatchID.Visible = true;
            dtv.Columns.Add(colBatchID);

            DataGridViewTextBoxColumn colExpDate = new DataGridViewTextBoxColumn();
            colExpDate.Name = "ExpireDate";
            colExpDate.DataPropertyName = "ExpireDate";
            colExpDate.Width = 0;
            colExpDate.Visible = false;
            dtv.Columns.Add(colExpDate);

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 18;
            checkBoxColumn.Visible = true;
            checkBoxColumn.Name = "checkBoxColumn";
            dtv.Columns.Insert(21, checkBoxColumn);


            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.Width = 60;
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dtv.Columns.Add(Deletelink);

        }
        private void populateDataToGridDrug(DataGridView dtv, string trid)
        {

            short index = 0;
            dgvTRDetails.Rows.Clear();
            dgvTRDetails.Visible = true;
            List<TransferRequisition> list = new List<TransferRequisition>();
            list.Clear();
            list.AddRange(phrSr.GetTRDetails(trid).ToList());

            foreach (TransferRequisition data in list)
            {
                string[] row = new string[] { data.ID,
                                              data.DrugMaster.ID,
                                              data.DrugMaster.Name,
                                              data.DrugMaster.DrugPackType.ID,
                                              data.DrugMaster.DrugUnit.ID,
                                              data.DrugMaster.DrugGroup.ID,
                                              data.DrugMaster.DrugCompany.ID,
                                              data.DrugMaster.DrugCompany.Name,
                                              data.DrugMaster.DrugGroup.Name,
                                              data.DrugMaster.DrugUnit.Name,
                                              data.DrugMaster.DrugPackType.Name,
                                              data.Warehouse.TypeID,
                                              data.TrQty.ToString(),
                                              data.TrrQty.ToString()                                          
                };
                AddRowsToCollection(dgvTRDetails, row, index);
                index++;
            }          
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        private void trList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtTRID.Text = trList.SelectedNode.Text;
            populateDataToGridDrug(dgvTRDetails,txtTRID.Text);
            txtfromPharmacy.DataBindings.Clear();
            txttoPharmacy.DataBindings.Clear();
            txtFromPhar.DataBindings.Clear();
            txtToPhar.DataBindings.Clear();
            txtfromPharmacy.DataBindings.Add("Text", phrSr.GetTRDetails(txtTRID.Text).ToList(), "Warehouse.TypeID");
            txtFromPhar.DataBindings.Add("Text", phrSr.GetTRDetails(txtTRID.Text).ToList(), "Warehouse.TypeName");
            txttoPharmacy.DataBindings.Add("Text", phrSr.GetTRDetails(txtTRID.Text).ToList(), "Warehouse.ToTypeID");
            txtToPhar.DataBindings.Add("Text", phrSr.GetTRDetails(txtTRID.Text).ToList(), "Warehouse.ToTypeName");
            LoadListDataGrid();
            btnSave.Enabled = true;
            //if (dgvStockDetails.Rows.Count > 0)
            //{
            //    LoadListDataGrid();
            //}
            //else
            //{
            //    txtPR.Text = string.Empty;
            //    txtPO.Text = string.Empty;
            //    txtGRN.Text = string.Empty;
            //    txtTransNo.Text = string.Empty;
            //    txtChallanNo.Text = string.Empty;
            //    txtChallanDate.Text = string.Empty;
            //}
        }

        private void dgvTRDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string i = dgvDemandReq.CurrentRow.Cells[0].Value.ToString();
            //frmItemDetailsByBatch oitmdet = new frmItemDetailsByBatch(i);
            //oitmdet.ShowDialog();
            grpStockDet.Visible = true;
            btnAddItems.Visible = true;
            btnCloseStockDetails.Visible = true;
            grpStockDet.Height = 200;
            grpStockDet.Width = 850;
            dgvStockDetails.Height = 170;
            dgvStockDetails.Width = 780;
            populateDataToGridForStock(dgvStockDetails, dgvTRDetails.CurrentRow.Cells[0].Value.ToString(), dgvTRDetails.CurrentRow.Cells[1].Value.ToString(), dgvTRDetails.CurrentRow.Cells[11].Value.ToString());
            txtTrrQty.Text = dgvTRDetails.CurrentRow.Cells[13].Value.ToString();
            btnAddItems.Location = new Point(grpStockDet.Location.X + 795, grpStockDet.Location.Y + 12);
            btnCloseStockDetails.Location = new Point(grpStockDet.Location.X + 795, grpStockDet.Location.Y + 40);
            dgvStockDetails.Columns["PharmacyID"].Visible = false;
            dgvStockDetails.Columns["Rate"].Visible = false;
            dgvStockDetails.Columns["SlRate"].Visible = false;
            dgvStockDetails.Columns["Vat"].Visible = false;
            dgvStockDetails.Columns["Disc"].Visible = false;
            dgvStockDetails.Columns["MRRID"].Visible = false;
            dgvStockDetails.Columns["Company"].Visible = false;
            dgvStockDetails.Columns[22].Visible = false;
            
            
        }
        private void LoadListDataGrid()
        {
            
            txtPR.DataBindings.Clear();
            txtPO.DataBindings.Clear();
            txtGRN.DataBindings.Clear();
            txtTransNo.DataBindings.Clear();
            txtChallanNo.DataBindings.Clear();
            txtChallanDate.DataBindings.Clear();
            txtPR.DataBindings.Add("Text", phrSr.GetDrugDetailsBatch(dgvTRDetails.CurrentRow.Cells[0].Value.ToString(), dgvTRDetails.CurrentRow.Cells[1].Value.ToString(), dgvTRDetails.CurrentRow.Cells[11].Value.ToString()).ToList(), "PurchaseOrder.PurchaseRequisition.ID");
            txtPO.DataBindings.Add("Text", phrSr.GetDrugDetailsBatch(dgvTRDetails.CurrentRow.Cells[0].Value.ToString(), dgvTRDetails.CurrentRow.Cells[1].Value.ToString(), dgvTRDetails.CurrentRow.Cells[11].Value.ToString()).ToList(), "PurchaseOrder.ID");
            txtGRN.DataBindings.Add("Text", phrSr.GetDrugDetailsBatch(dgvTRDetails.CurrentRow.Cells[0].Value.ToString(), dgvTRDetails.CurrentRow.Cells[1].Value.ToString(), dgvTRDetails.CurrentRow.Cells[11].Value.ToString()).ToList(), "MRRID");
            txtTransNo.DataBindings.Add("Text", phrSr.GetDrugDetailsBatch(dgvTRDetails.CurrentRow.Cells[0].Value.ToString(), dgvTRDetails.CurrentRow.Cells[1].Value.ToString(), dgvTRDetails.CurrentRow.Cells[11].Value.ToString()).ToList(), "TransactionType");
            txtChallanNo.DataBindings.Add("Text", phrSr.GetDrugDetailsBatch(dgvTRDetails.CurrentRow.Cells[0].Value.ToString(), dgvTRDetails.CurrentRow.Cells[1].Value.ToString(), dgvTRDetails.CurrentRow.Cells[11].Value.ToString()).ToList(), "ChallanNo");
            txtChallanDate.DataBindings.Add("Text", phrSr.GetDrugDetailsBatch(dgvTRDetails.CurrentRow.Cells[0].Value.ToString(), dgvTRDetails.CurrentRow.Cells[1].Value.ToString(), dgvTRDetails.CurrentRow.Cells[11].Value.ToString()).ToList(), "ChallanDate");
        }
        private void populateDataToGridForStock(DataGridView dtv, string trid,string drugid,string pharmacyid)
        {

            short index = 0;
            dgvStockDetails.Visible = true;
            dgvStockDetails.Rows.Clear();
            List<MaterialReceive> list = new List<MaterialReceive>();
            list.Clear();
            list.AddRange(phrSr.GetDrugDetailsBatch(trid,drugid,pharmacyid).ToList());

            foreach (MaterialReceive data in list)
            {
                string[] row = new string[] { "",
                                              data.ItemsOrder.DrugMaster.ID,
                                              data.ItemsOrder.DrugMaster.Name,
                                              data.ItemsOrder.DrugMaster.DrugPackType.ID,
                                              data.ItemsOrder.DrugMaster.DrugUnit.ID,
                                              data.ItemsOrder.DrugMaster.DrugGroup.ID,
                                              data.ItemsOrder.DrugMaster.DrugCompany.ID,                                           
                                              data.ItemsOrder.DrugMaster.DrugCompany.Name,
                                              data.ItemsOrder.DrugMaster.DrugGroup.Name,
                                              data.ItemsOrder.DrugMaster.DrugUnit.Name,
                                              data.ItemsOrder.DrugMaster.DrugPackType.Name,   
                                              "",
                                              data.PurchaseOrder.PurchaseRequisition.RequisitionQty.ToString(),
                                              "0",                                               
                                              data.ItemsOrder.URate.ToString(),
                                              data.ItemsOrder.SlRate.ToString(),
                                              data.ItemsOrder.VAT.ToString(),
                                              data.ItemsOrder.Discount.ToString(),
                                              data.MRRID,
                                              data.BatchNo,
                                              data.ExpireDate.ToString("dd/MM/yyyy")
                                              //data.MRRID,
                                              //data.ExpireDate.ToString("dd/MM/yyyy")
                                              
            };
                AddRowsToCollection(dgvStockDetails, row, index);
                index++;
              
            }
            dgvStockDetails.Columns[0].Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnCloseStockDetails_Click(object sender, EventArgs e)
        {
            grpStockDet.Visible = false;
            dgvStockDetails.Visible = false;
            btnAddItems.Visible = false;
            btnCloseStockDetails.Visible = false;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {

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
                            sum += float.Parse(dgvStockDetails.Rows[i].Cells["TrrQty"].Value.ToString());

                            txtSumTrrQty.Text = sum.ToString();
                            //sum += float.Parse(dgvStockDetails.Rows[i].Cells["IssueQty"].Value.ToString());

                            //lblTotalReq.Text = sum.ToString();
                            //if (float.Parse(lblTotalReq.Text.ToString()) > float.Parse(dgvStockDetails.Rows[i].Cells["ReqQty"].Value.ToString()))
                            //{
                            //    MessageBox.Show("IssueQty cann't be more than ReqQty");
                            //    return;
                            //}
                            if (float.Parse(dgvStockDetails.Rows[i].Cells["TrrQty"].Value.ToString()) == 0)
                            {
                                MessageBox.Show("TrrQty can not be zero");
                                return;
                            }

                            if (float.Parse(txtSumTrrQty.Text) > float.Parse(txtTrrQty.Text))
                            {
                                MessageBox.Show("TrrQty cann't be more than RemQty");
                                return;
                            }
                            //if (float.Parse(dgvStockDetails.Rows[i].Cells["IssueQty"].Value.ToString()) > float.Parse(dgvStockDetails.Rows[i].Cells["RemCalc"].Value.ToString()))
                            //{
                            //    MessageBox.Show("IssueQty cann't be more than PendingReqQty");
                            //    return;
                            //}
                        }
                    }
                    for (int j = 0; j < dgvTransferReceive.Rows.Count; j++)
                    {
                        if (row.Cells[1].Value.ToString() == dgvTransferReceive.Rows[j].Cells[1].Value.ToString() && row.Cells[19].Value.ToString() == dgvTransferReceive.Rows[j].Cells[19].Value.ToString())
                        {
                            MessageBox.Show("This Item is Duplicate");
                            grpStockDet.Visible = false;
                            btnAddItems.Visible = false;
                            btnCloseStockDetails.Visible = false;
                            return;

                        }

                    }
                    dgvTransferReceive.Rows.Add(row.Cells[0].Value.ToString(),
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
                                             row.Cells[22].Value.ToString()
                                         );
                    dgvTransferReceive.Columns["checkBoxColumn"].Visible = false;
                    dgvTransferReceive.Columns["TRID"].Visible = false;
                    dgvTransferReceive.Columns["PharmacyID"].Visible = false;
                    dgvTransferReceive.Columns["Rate"].Visible = false;
                    dgvTransferReceive.Columns["SlRate"].Visible = false;
                    dgvTransferReceive.Columns["MRRID"].Visible = false;
                   
                    this.dgvTransferReceive.Focus();


                }
            }
            //dgvIssueDetails.Columns["ReqQty"].HeaderText = "IssueQty";
            //for (int i = 0; i < dgvIssueDetails.Rows.Count; i++)
            //{
            //    dgvIssueDetails.Rows[i].Cells[19].Value = float.Parse(dgvIssueDetails.Rows[i].Cells[15].Value.ToString()) * float.Parse(dgvIssueDetails.Rows[i].Cells[18].Value.ToString());
            //    dgvIssueDetails.Rows[i].Cells[22].Value = float.Parse(dgvIssueDetails.Rows[i].Cells[15].Value.ToString()) * float.Parse(dgvIssueDetails.Rows[i].Cells[18].Value.ToString()) + float.Parse(dgvIssueDetails.Rows[i].Cells[20].Value.ToString()) - float.Parse(dgvIssueDetails.Rows[i].Cells[21].Value.ToString());
            //}
            grpStockDet.Visible = false;
            btnAddItems.Visible = false;
            btnCloseStockDetails.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
            if (dgvTransferReceive.Rows.Count == 0)
            {
                MessageBox.Show("Please Select Item ");
                return;
            }
            //for (int k = 0; k < dgvTransferReceive.Rows.Count; k++)
            //{
                //if (float.Parse(dgvTransferReceive.Rows[k].Cells["IssueQty"].Value.ToString()) == 0)
                //{
                //    MessageBox.Show("Issue Quantity can not be zero");
                //    return;
                //}
                //if (Convert.ToDateTime(dgvTransferReceive.Rows[k].Cells["ExpireDate"].Value) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                //{
                //    MessageBox.Show("Expire Date cannot be earlier than Current Date");
                //    return;
                //}
            //}
            //if (txtIssueDate.Text == "  /  /")
            //{
            //    MessageBox.Show("Date cannot be Empty");
            //    return;
            //}

            try
            {

                TransferReceive issueObj = this.populateTransferReceive();

                string i = phrSr.SaveTransferReceive(issueObj);


                if (i == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    dgvTRDetails.Rows.Clear();
                    dgvTransferReceive.Rows.Clear();
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
        private TransferReceive populateTransferReceive()
        {
            TransferReceive otransfer = new TransferReceive();
            otransfer.TrrType = "1";
            otransfer.TrrDate = DateTime.Parse(txtTransactionDate.Text);
            otransfer.Remarks = txtRemarks.Text;

            TransferRequisition otr = new TransferRequisition();
            otr.ID = txtTRID.Text;
            otransfer.TransferRequisition = otr;

            Warehouse ophr = new Warehouse();
            ophr.TypeID = txtfromPharmacy.Text;
            ophr.ToTypeID = txttoPharmacy.Text;
            otransfer.Warehouse = ophr;

            MaterialReceive omr = new MaterialReceive();
            omr.MRRID = txtGRN.Text;
            omr.ChallanNo = txtChallanNo.Text;
            omr.ChallanDate = DateTime.Parse(txtChallanDate.Text);
            omr.VoucherNo = "1234";
            omr.TransactionType = txtTransNo.Text;
           
            PurchaseOrder opo = new PurchaseOrder();
            opo.ID = txtPO.Text;

            PurchaseRequisition opr = new PurchaseRequisition();
            opr.ID = txtPR.Text;
            opo.PurchaseRequisition = opr;
            omr.PurchaseOrder = opo;
            otransfer.MaterialReceive = omr;
            
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            otransfer.EntryParameter = ep;

            string trrstring = "";

            foreach (DataGridViewRow dr in dgvTransferReceive.Rows)
            {
                trrstring += dr.Cells[1].Value.ToString() + "," + dr.Cells[3].Value.ToString() + "," + dr.Cells[4].Value.ToString() + "," + dr.Cells[5].Value.ToString() + "," + dr.Cells[6].Value.ToString() + "," + dr.Cells[14].Value.ToString() + "," + dr.Cells[15].Value.ToString() + "," + dr.Cells[16].Value.ToString() + "," + dr.Cells[17].Value.ToString() + "," + dr.Cells[12].Value.ToString() + "," + dr.Cells[13].Value.ToString() + "," + dr.Cells[20].Value.ToString() + "," + dr.Cells[19].Value.ToString() ;
                trrstring += ";";
            }
            otransfer.TrrDetails = trrstring;

            return otransfer;
        }

        private void dgvStockDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgvStockDetails.Columns["TrrQty"].Index)
            {
                dgvStockDetails.Rows[e.RowIndex].ErrorText = "";
                float newInteger;

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgvStockDetails.Rows[e.RowIndex].IsNewRow) { return; }
                if (!float.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgvStockDetails.Rows[e.RowIndex].ErrorText = "the value must be a Positive integer";
                }
            }
        }

        private void dgvTransferReceive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTransferReceive_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 22)
            {
                int selRowIndex = e.RowIndex;
                if (selRowIndex < 0)
                {
                    dgvTransferReceive.Rows.Clear();
                }
                else
                {
                    dgvTransferReceive.Rows.RemoveAt(selRowIndex);
                }

            }
        }

    }
}
