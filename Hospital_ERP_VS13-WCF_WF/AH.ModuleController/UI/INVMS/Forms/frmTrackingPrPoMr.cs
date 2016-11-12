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
    public partial class frmTrackingPrPoMr : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmTrackingPrPoMr()
        {
            InitializeComponent();
        }

        private void frmTrackingPrPoMr_Load(object sender, EventArgs e)
        {
            cboStoreLocation.ValueMember = "Whid";
            cboStoreLocation.DisplayMember = "WhName";
            cboStoreLocation.DataSource = new BindingSource(invSr.GetWarehouse(), null);

            FormatDataGridView(dgvReqDetails);
            FormatDataGridViewForPO(dgvPODetails);
            FormatDataGridViewForMrr(dgvMrrDetails);
        }
        private void FormatDataGridView(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;

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
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 100;
            itemid.Visible = true;
            itemid.ReadOnly = true;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Item";
            itemname.DataPropertyName = "Item";
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
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 100;
            itemid.Visible = true;
            itemid.ReadOnly = true;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Item";
            itemname.DataPropertyName = "Item";
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
            itemid.Name = "ItemID";
            itemid.DataPropertyName = "ItemID";
            itemid.Width = 100;
            itemid.Visible = true;
            itemid.ReadOnly = true;
            dtv.Columns.Add(itemid);
            DataGridViewTextBoxColumn itemname = new DataGridViewTextBoxColumn();
            itemname.Name = "Item";
            itemname.DataPropertyName = "Item";
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
            list.AddRange(invSr.GetRequisitionTrack(strid, startdate, enddate).ToList());
            foreach(PurchaseRequisition data in list)
            {
                string[] row = new string[] { data.RequisitionDate.ToString("dd/MM/yyyy"),
                                              data.ID,
                                              data.ItemMaster.ID,
                                              data.ItemMaster.Name,
                                              data.ItemMaster.Units.Name,
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
            list.AddRange(invSr.GetPOTracking(strid, startdate, enddate).ToList());
            foreach (PurchaseOrder data in list)
            {
                string[] row = new string[] { data.PODate.ToString("dd/MM/yyyy"),
                                              data.ID,
                                              data.ItemOrder.ItemMaster.ID,
                                              data.ItemOrder.ItemMaster.Name,
                                              data.ItemOrder.ItemMaster.Units.Name,
                                              data.ItemOrder.POQty.ToString(),
                                              data.ItemOrder.Rate.ToString(),
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
            list.AddRange(invSr.GetPOTrackingByPrId(prid).ToList());
            foreach (PurchaseOrder data in list)
            {
                string[] row = new string[] { data.PODate.ToString("dd/MM/yyyy"),
                                              data.ID,
                                              data.ItemOrder.ItemMaster.ID,
                                              data.ItemOrder.ItemMaster.Name,
                                              data.ItemOrder.ItemMaster.Units.Name,
                                              data.ItemOrder.POQty.ToString(),
                                              data.ItemOrder.Rate.ToString(),
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
            list.AddRange(invSr.GetMrrTracking(strid, startdate, enddate).ToList());
            foreach (MaterialReceive data in list)
            {
                string[] row = new string[] { data.MrrDate.ToString("dd/MM/yyyy"),
                                              data.ID,
                                              data.ItemOrder.ItemMaster.ID,
                                              data.ItemOrder.ItemMaster.Name,
                                              data.ItemOrder.ItemMaster.Units.Name,
                                              data.MrrQuantity.ToString(),
                                              data.ItemOrder.Rate.ToString(),
                                              
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
            list.AddRange(invSr.GetMrrTrackingByPONo(poid).ToList());
            foreach (MaterialReceive data in list)
            {
                string[] row = new string[] { data.MrrDate.ToString("dd/MM/yyyy"),
                                              data.ID,
                                              data.ItemOrder.ItemMaster.ID,
                                              data.ItemOrder.ItemMaster.Name,
                                              data.ItemOrder.ItemMaster.Units.Name,
                                              data.MrrQuantity.ToString(),
                                              data.ItemOrder.Rate.ToString()
                                              
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
            PopulateDataToGridForReq(dgvReqDetails,cboStoreLocation.SelectedValue.ToString(),dtFromDate.Text,dtToDate.Text);
            PopulateDataToGridForPO(dgvPODetails, cboStoreLocation.SelectedValue.ToString(), dtFromDate.Text, dtToDate.Text);
            PopulateDataToGridForMrr(dgvMrrDetails, cboStoreLocation.SelectedValue.ToString(), dtFromDate.Text, dtToDate.Text);
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
