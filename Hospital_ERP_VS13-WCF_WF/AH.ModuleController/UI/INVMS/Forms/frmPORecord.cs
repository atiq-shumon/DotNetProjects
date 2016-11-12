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
    public partial class frmPORecord : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();

        private System.Windows.Forms.DataGridView dataGridView1 = new DataGridView();
        public frmPORecord(string i)
        {
            
            InitializeComponent();
            txtItemID.Text = i;
        }

        private void FormatGrid(DataGridView dtv)
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
            itemname.Width = 250;
            itemname.Visible = true;
            itemname.ReadOnly = true;
            dtv.Columns.Add(itemname);

            DataGridViewTextBoxColumn colpoid = new DataGridViewTextBoxColumn();
            colpoid.Name = "POID";
            colpoid.DataPropertyName = "POID";
            colpoid.Width = 0;
            colpoid.Visible = false;
            colpoid.ReadOnly = true;
            dtv.Columns.Add(colpoid);

            DataGridViewTextBoxColumn colbatch = new DataGridViewTextBoxColumn();
            colbatch.Name = "Batch";
            colbatch.DataPropertyName = "Batch";
            colbatch.Width = 80;
            colbatch.Visible = true;
            colbatch.ReadOnly = true;
            dtv.Columns.Add(colbatch);

            DataGridViewTextBoxColumn colstock = new DataGridViewTextBoxColumn();
            colstock.Name = "StockQty";
            colstock.DataPropertyName = "StockQty";
            colstock.Width = 60;
            colstock.Visible = true;
            colstock.ReadOnly = true;
            dtv.Columns.Add(colstock);

            DataGridViewTextBoxColumn colpoqty = new DataGridViewTextBoxColumn();
            colpoqty.Name = "POQty";
            colpoqty.DataPropertyName = "POQty";
            colpoqty.Width = 60;
            colpoqty.Visible = true;
            colpoqty.ReadOnly = true;
            dtv.Columns.Add(colpoqty);

            DataGridViewTextBoxColumn colporate = new DataGridViewTextBoxColumn();
            colporate.Name = "PORate";
            colporate.DataPropertyName = "PORate";
            colporate.Width = 70;
            colporate.Visible = true;
            colporate.ReadOnly = true;
            dtv.Columns.Add(colporate);

            DataGridViewTextBoxColumn colpodate = new DataGridViewTextBoxColumn();
            colpodate.Name = "PODate";
            colpodate.DataPropertyName = "PODate";
            colpodate.Width = 80;
            colpodate.Visible = true;
            colpodate.ReadOnly = true;
            dtv.Columns.Add(colpodate);

            DataGridViewTextBoxColumn colsupplierid = new DataGridViewTextBoxColumn();
            colsupplierid.Name = "SupplierID";
            colsupplierid.DataPropertyName = "SupplierID";
            colsupplierid.Width = 0;
            colsupplierid.Visible = false;
            colsupplierid.ReadOnly = true;
            dtv.Columns.Add(colsupplierid);

            DataGridViewTextBoxColumn colsuppliername = new DataGridViewTextBoxColumn();
            colsuppliername.Name = "SupplierName";
            colsuppliername.DataPropertyName = "SupplierName";
            colsuppliername.Width = 230;
            colsuppliername.Visible = true;
            colsuppliername.ReadOnly = true;
            dtv.Columns.Add(colsuppliername);

        }

        private void frmPORecord_Load(object sender, EventArgs e)
        {
            //cboItemName.DisplayMember = "Name";
            //cboItemName.ValueMember = "ID";
            //cboItemName.DataSource = new BindingSource(invSr.GetItemMaster(),null);
            
            
            FormatGrid(dgvPORecord);
            PopulateDataToGridForPORecord(dgvPORecord, txtItemID.Text);
            //btnShow.PerformClick();
        }
        private void PopulateDataToGridForPORecord(DataGridView dtv, string itemid)
        {
            dtv.DefaultCellStyle.BackColor = Color.Bisque;
            short index = 0;

            dgvPORecord.Rows.Clear();
            List<PurchaseOrder> list = new List<PurchaseOrder>();
            list.Clear();
            list.AddRange(invSr.GetPORecord(itemid).ToList());
            foreach (PurchaseOrder data in list)
            {
                string[] row = new string[] { 
                                              
                                              data.ItemOrder.ItemMaster.ID,
                                              data.ItemOrder.ItemMaster.Name,
                                              data.ID, 
                                              data.ItemOrder.Batch,
                                              data.ItemOrder.StockQty.ToString(),
                                              data.ItemOrder.POQty.ToString(),
                                              data.ItemOrder.Rate.ToString(),
                                              data.PODate.ToString("dd/MM/yyyy"),
                                              data.Supplier.ID,
                                              data.Supplier.Name
                                              };
                AddRowsToCollection(dgvPORecord, row, index);
                index++;

            }
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            PopulateDataToGridForPORecord(dgvPORecord,txtItemID.Text);
        }
    }
}
