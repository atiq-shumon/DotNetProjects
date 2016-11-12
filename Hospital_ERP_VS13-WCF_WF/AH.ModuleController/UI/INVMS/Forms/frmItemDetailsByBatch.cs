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
    public partial class frmItemDetailsByBatch : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmItemDetailsByBatch(string i)
        {
            InitializeComponent();
            txtItemID.Text = i;
        }
        private void FormatGrid(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            DataGridViewTextBoxColumn colitemid = new DataGridViewTextBoxColumn();
            colitemid.Name = "ItemID";
            colitemid.DataPropertyName = "ItemID";
            colitemid.Width = 120;
            colitemid.Visible = true;
            colitemid.ReadOnly = true;
            dtv.Columns.Add(colitemid);

            DataGridViewTextBoxColumn colitemname = new DataGridViewTextBoxColumn();
            colitemname.Name = "Item";
            colitemname.DataPropertyName = "Item";
            colitemname.Width = 120;
            colitemname.Visible = true;
            colitemname.ReadOnly = true;
            dtv.Columns.Add(colitemname);

            DataGridViewTextBoxColumn colbatch = new DataGridViewTextBoxColumn();
            colbatch.Name = "Batch";
            colbatch.DataPropertyName = "Batch";
            colbatch.Width = 100;
            colbatch.Visible = true;
            colbatch.ReadOnly = true;
            dtv.Columns.Add(colbatch);

            DataGridViewTextBoxColumn colexpdate = new DataGridViewTextBoxColumn();
            colexpdate.Name = "ExpireDate";
            colexpdate.DataPropertyName = "ExpireDate";
            colexpdate.Width = 200;
            colexpdate.Visible = true;
            colexpdate.ReadOnly = true;
            dtv.Columns.Add(colexpdate);

            DataGridViewTextBoxColumn colstockqty = new DataGridViewTextBoxColumn();
            colstockqty.Name = "StockQty";
            colstockqty.DataPropertyName = "StockQty";
            colstockqty.Width = 170;
            colstockqty.Visible = true;
            colstockqty.ReadOnly = true;
            dtv.Columns.Add(colstockqty);

            DataGridViewTextBoxColumn colrate = new DataGridViewTextBoxColumn();
            colrate.Name = "Rate";
            colrate.DataPropertyName = "Rate";
            colrate.Width = 170;
            colrate.Visible = true;
            colrate.ReadOnly = true;
            dtv.Columns.Add(colrate);

            DataGridViewTextBoxColumn coltotal = new DataGridViewTextBoxColumn();
            coltotal.Name = "Total";
            coltotal.DataPropertyName = "Total";
            coltotal.Width = 170;
            coltotal.Visible = true;
            coltotal.ReadOnly = true;
            dtv.Columns.Add(coltotal);
        }
        private void PopulateDataToGrid(DataGridView dtv,string itemid)
        {
            //dtv.DefaultCellStyle.BackColor = Color.Bisque;
            //short index = 0;

            //dgvItemDet.Rows.Clear();
            //List<MaterialReceive> list = new List<MaterialReceive>();
            //list.Clear();
            //list.AddRange(invSr.GetItemDetailsBatch(itemid).ToList());

            //foreach(MaterialReceive data in list)
            //{
            //    string[] row = new string[] { data.ItemOrder.ItemMaster.ID,
            //                                  data.ItemOrder.ItemMaster.Name,
            //                                  data.BatchID,
            //                                  data.ExpDate.ToString(),
            //                                  data.ItemOrder.StockQty.ToString(),
            //                                  data.ItemOrder.Rate.ToString()
            //    };
            //    AddRowsToCollection(dgvItemDet,row,index);
            //    index++;
            //}
        }
        private void AddRowsToCollection(DataGridView dtv,string[] row,short index)
        {
            dtv.Rows.Insert(index,row);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmItemDetailsByBatch_Load(object sender, EventArgs e)
        {
            FormatGrid(dgvItemDet);
            PopulateDataToGrid(dgvItemDet,txtItemID.Text);
        }
    }
}
