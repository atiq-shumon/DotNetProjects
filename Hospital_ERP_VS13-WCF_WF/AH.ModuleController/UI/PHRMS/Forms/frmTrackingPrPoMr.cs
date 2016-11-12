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
    public partial class frmTrackingPrPoMr : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmTrackingPrPoMr()
        {
            InitializeComponent();
        }

        private void frmTrackingPrPoMr_Load(object sender, EventArgs e)
        {
            cboPharmacy.DisplayMember = "Value";
            cboPharmacy.ValueMember = "Key";
            cboPharmacy.DataSource = new BindingSource(phrSr.GetPharmacyName("D"), null);

            FormatDataGridView(dgvReqDetails);
            FormatDataGridViewForPO(dgvPODetails);
            FormatDataGridViewForMrr(dgvMrrDetails);
        }
        private void FormatDataGridView(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;
            dtv.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn coldate = new DataGridViewTextBoxColumn();
            coldate.Name = "PR Date";
            coldate.DataPropertyName = "PR Date";
            coldate.Width = 90;
            coldate.Visible = true;
            coldate.ReadOnly = true;
            dtv.Columns.Add(coldate);
            DataGridViewTextBoxColumn colprno = new DataGridViewTextBoxColumn();
            colprno.Name = "PR No";
            colprno.DataPropertyName = "PR No";
            colprno.Width = 150;
            colprno.Visible = true;
            colprno.ReadOnly = true;
            dtv.Columns.Add(colprno);
            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ID";
            itemid.DataPropertyName = "ID";
            itemid.Width = 100;
            itemid.Visible = true;
            itemid.ReadOnly = true;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Brand Name";
            itemname.DataPropertyName = "Brand Name";
            itemname.Width = 300;
            itemname.Visible = true;
            itemname.ReadOnly = true;
            dtv.Columns.Add(itemname);
            DataGridViewTextBoxColumn colunit = new DataGridViewTextBoxColumn();
            colunit.Name = "Unit";
            colunit.DataPropertyName = "Unit";
            colunit.Width = 80;
            colunit.Visible = true;
            colunit.ReadOnly = true;
            dtv.Columns.Add(colunit);
            DataGridViewTextBoxColumn colquantity = new DataGridViewTextBoxColumn();
            colquantity.Name = "Qty";
            colquantity.DataPropertyName = "Qty";
            colquantity.Width = 80;
            colquantity.Visible = true;
            colquantity.ReadOnly = true;
            dtv.Columns.Add(colquantity);
        }
        private void FormatDataGridViewForPO(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;
            dtv.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn coldate = new DataGridViewTextBoxColumn();
            coldate.Name = "PO Date";
            coldate.DataPropertyName = "PO Date";
            coldate.Width = 90;
            coldate.Visible = true;
            coldate.ReadOnly = true;
            dtv.Columns.Add(coldate);
            DataGridViewTextBoxColumn colprno = new DataGridViewTextBoxColumn();
            colprno.Name = "PO No";
            colprno.DataPropertyName = "PO No";
            colprno.Width = 150;
            colprno.Visible = true;
            colprno.ReadOnly = true;
            dtv.Columns.Add(colprno);
            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ID";
            itemid.DataPropertyName = "ID";
            itemid.Width = 100;
            itemid.Visible = true;
            itemid.ReadOnly = true;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Brand Name";
            itemname.DataPropertyName = "Brand Name";
            itemname.Width = 300;
            itemname.Visible = true;
            itemname.ReadOnly = true;
            dtv.Columns.Add(itemname);
            DataGridViewTextBoxColumn colunit = new DataGridViewTextBoxColumn();
            colunit.Name = "Unit";
            colunit.DataPropertyName = "Unit";
            colunit.Width = 80;
            colunit.Visible = true;
            colunit.ReadOnly = true;
            dtv.Columns.Add(colunit);
            DataGridViewTextBoxColumn colquantity = new DataGridViewTextBoxColumn();
            colquantity.Name = "Qty";
            colquantity.DataPropertyName = "Qty";
            colquantity.Width = 80;
            colquantity.Visible = true;
            colquantity.ReadOnly = true;
            dtv.Columns.Add(colquantity);
            DataGridViewTextBoxColumn colrate = new DataGridViewTextBoxColumn();
            colrate.Name = "Rate";
            colrate.DataPropertyName = "Rate";
            colrate.Width = 80;
            colrate.Visible = true;
            colrate.ReadOnly = true;
            dtv.Columns.Add(colrate);
            DataGridViewTextBoxColumn colsupplier = new DataGridViewTextBoxColumn();
            colsupplier.Name = "Supplier";
            colsupplier.DataPropertyName = "Supplier";
            colsupplier.Width = 180;
            colsupplier.Visible = true;
            colsupplier.ReadOnly = true;
            dtv.Columns.Add(colsupplier);
        }
        private void FormatDataGridViewForMrr(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;
            dtv.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn coldate = new DataGridViewTextBoxColumn();
            coldate.Name = "GRN Date";
            coldate.DataPropertyName = "GRN Date";
            coldate.Width = 90;
            coldate.Visible = true;
            coldate.ReadOnly = true;
            dtv.Columns.Add(coldate);
            DataGridViewTextBoxColumn colprno = new DataGridViewTextBoxColumn();
            colprno.Name = "GRN No";
            colprno.DataPropertyName = "GRN No";
            colprno.Width = 150;
            colprno.Visible = true;
            colprno.ReadOnly = true;
            dtv.Columns.Add(colprno);
            DataGridViewTextBoxColumn itemid = new DataGridViewTextBoxColumn();
            itemid.Name = "ID";
            itemid.DataPropertyName = "ID";
            itemid.Width = 100;
            itemid.Visible = true;
            itemid.ReadOnly = true;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Brand Name";
            itemname.DataPropertyName = "Brand Name";
            itemname.Width = 300;
            itemname.Visible = true;
            itemname.ReadOnly = true;
            dtv.Columns.Add(itemname);
            DataGridViewTextBoxColumn colunit = new DataGridViewTextBoxColumn();
            colunit.Name = "Unit";
            colunit.DataPropertyName = "Unit";
            colunit.Width = 80;
            colunit.Visible = true;
            colunit.ReadOnly = true;
            dtv.Columns.Add(colunit);
            DataGridViewTextBoxColumn colquantity = new DataGridViewTextBoxColumn();
            colquantity.Name = "Qty";
            colquantity.DataPropertyName = "Qty";
            colquantity.Width = 80;
            colquantity.Visible = true;
            colquantity.ReadOnly = true;
            dtv.Columns.Add(colquantity);
            DataGridViewTextBoxColumn colrate = new DataGridViewTextBoxColumn();
            colrate.Name = "Rate";
            colrate.DataPropertyName = "Rate";
            colrate.Width = 80;
            colrate.Visible = true;
            colrate.ReadOnly = true;
            dtv.Columns.Add(colrate);
          
        }
        private void PopulateDataToGridForReq(DataGridView dtv,string strid,string startdate,string enddate)
        {
            //dtv.DefaultCellStyle.BackColor = Color.Bisque;
            short index = 0;
            dgvReqDetails.Rows.Clear();
            List<PurchaseRequisition> list = new List<PurchaseRequisition>();
            list.Clear();
            list.AddRange(phrSr.GetRequisitionTrack(strid, startdate, enddate).ToList());
            foreach(PurchaseRequisition data in list)
            {
                string[] row = new string[] { data.RequisitionDate.ToString("dd/MM/yyyy"),
                                              data.ID,
                                              data.DrugMaster.ID,
                                              data.DrugMaster.Name,
                                              data.DrugMaster.DrugUnit.Name,
                                              data.RequisitionQty.ToString()
                                              };
                AddRowsToCollection(dgvReqDetails, row, index);
                index++;

            }
        }
        private void PopulateDataToGridForPO(DataGridView dtv, string strid, string startdate, string enddate)
        {
            dtv.DefaultCellStyle.BackColor = Color.Bisque;
            short index = 0;

            dgvPODetails.Rows.Clear();
            List<PurchaseOrder> list = new List<PurchaseOrder>();
            list.Clear();
            list.AddRange(phrSr.GetPOTracking(strid, startdate, enddate).ToList());
            foreach (PurchaseOrder data in list)
            {
                string[] row = new string[] { data.PODate.ToString("dd/MM/yyyy"),
                                              data.ID,
                                              data.ItemsOrder.DrugMaster.ID,
                                              data.ItemsOrder.DrugMaster.Name,
                                              data.ItemsOrder.DrugMaster.DrugUnit.Name,
                                              data.ItemsOrder.POQty.ToString(),
                                              data.ItemsOrder.URate.ToString(),
                                              data.Supplier.Name
                                              };
                AddRowsToCollection(dgvPODetails, row, index);
                index++;

            }
        }
        private void PopulateDataToGridForPOByPrNo(DataGridView dtv, string prid)
        {
            dtv.DefaultCellStyle.BackColor = Color.Bisque;
            short index = 0;

            dgvPODetails.Rows.Clear();
            List<PurchaseOrder> list = new List<PurchaseOrder>();
            list.Clear();
            list.AddRange(phrSr.GetPOTrackingByPrId(prid).ToList());
            foreach (PurchaseOrder data in list)
            {
                string[] row = new string[] { data.PODate.ToString("dd/MM/yyyy"),
                                              data.ID,
                                              data.ItemsOrder.DrugMaster.ID,
                                              data.ItemsOrder.DrugMaster.Name,
                                              data.ItemsOrder.DrugMaster.DrugUnit.Name,
                                              data.ItemsOrder.POQty.ToString(),
                                              data.ItemsOrder.URate.ToString(),
                                              data.Supplier.Name
                                              };
                AddRowsToCollection(dgvPODetails, row, index);
                index++;

            }
        }
        private void PopulateDataToGridForMrr(DataGridView dtv, string strid, string startdate, string enddate)
        {
            dtv.DefaultCellStyle.BackColor = Color.Aqua;
            short index = 0;

            dgvMrrDetails.Rows.Clear();
            List<MaterialReceive> list = new List<MaterialReceive>();
            list.Clear();
            list.AddRange(phrSr.GetMrrTracking(strid, startdate, enddate).ToList());
            foreach (MaterialReceive data in list)
            {
                string[] row = new string[] { data.MRRDate.ToString("dd/MM/yyyy"),
                                              data.MRRID,
                                              data.ItemsOrder.DrugMaster.ID,
                                              data.ItemsOrder.DrugMaster.Name,
                                              data.ItemsOrder.DrugMaster.DrugUnit.Name,
                                              data.MRRQuantity.ToString(),
                                              data.ItemsOrder.URate.ToString(),
                                              
                                              };
                AddRowsToCollection(dgvMrrDetails, row, index);
                index++;

            }
        }
        private void PopulateDataToGridForMrrByPOID(DataGridView dtv, string poid)
        {
            dtv.DefaultCellStyle.BackColor = Color.Aqua;
            short index = 0;

            dgvMrrDetails.Rows.Clear();
            List<MaterialReceive> list = new List<MaterialReceive>();
            list.Clear();
            list.AddRange(phrSr.GetMrrTrackingByPONo(poid).ToList());
            foreach (MaterialReceive data in list)
            {
                string[] row = new string[] { data.MRRDate.ToString("dd/MM/yyyy"),
                                              data.MRRID,
                                              data.ItemsOrder.DrugMaster.ID,
                                              data.ItemsOrder.DrugMaster.Name,
                                              data.ItemsOrder.DrugMaster.DrugUnit.Name,
                                              data.MRRQuantity.ToString(),
                                              data.ItemsOrder.URate.ToString()
                                              
                                              };
                AddRowsToCollection(dgvMrrDetails, row, index);
                index++;

            }
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            PopulateDataToGridForReq(dgvReqDetails,cboPharmacy.SelectedValue.ToString(),dtFromDate.Text,dtToDate.Text);
            PopulateDataToGridForPO(dgvPODetails, cboPharmacy.SelectedValue.ToString(), dtFromDate.Text, dtToDate.Text);
            PopulateDataToGridForMrr(dgvMrrDetails, cboPharmacy.SelectedValue.ToString(), dtFromDate.Text, dtToDate.Text);
        }

        private void dgvReqDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

               PopulateDataToGridForPOByPrNo(dgvPODetails, dgvReqDetails.CurrentRow.Cells[1].Value.ToString());
         
               PopulateDataToGridForMrrByPOID(dgvMrrDetails, dgvReqDetails.CurrentRow.Cells[1].Value.ToString());
         
        }

        private void dgvPODetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateDataToGridForMrrByPOID(dgvMrrDetails,dgvPODetails.CurrentRow.Cells[1].Value.ToString());
        }
    }
}
