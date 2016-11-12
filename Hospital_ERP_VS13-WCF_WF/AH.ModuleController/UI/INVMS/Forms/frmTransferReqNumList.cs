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
    public partial class frmTransferReqNumList : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        List<string> list;
        public delegate void AddAllClick(List<TransferRequisition> items, object sender, EventArgs e);
        public AddAllClick onAddAllButtonClicked;
        public frmTransferReqNumList()
        {
            InitializeComponent();
        }
        private void FormatGrid(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;
            //dtv.Location = new Point(txtItemID.Location.X, txtItemID.Location.Y);

            DataGridViewTextBoxColumn colreqno = new DataGridViewTextBoxColumn();
            colreqno.Name = "RequisitionNo";
            colreqno.DataPropertyName = "RequisitionNo";
            colreqno.Width = 120;
            colreqno.Visible = true;
            colreqno.ReadOnly = true;
            dtv.Columns.Add(colreqno);

            DataGridViewTextBoxColumn colreqdate = new DataGridViewTextBoxColumn();
            colreqdate.Name = "RequisitionDate";
            colreqdate.DataPropertyName = "RequisitionDate";
            colreqdate.Width = 100;
            colreqdate.Visible = true;
            colreqdate.ReadOnly = true;
            dtv.Columns.Add(colreqdate);

            //DataGridViewTextBoxColumn colreqby = new DataGridViewTextBoxColumn();
            //colreqby.Name = "RequisitionBy";
            //colreqby.DataPropertyName = "RequisitionBy";
            //colreqby.Width = 200;
            //colreqby.Visible = true;
            //colreqby.ReadOnly = true;
            //dtv.Columns.Add(colreqby);

            DataGridViewTextBoxColumn colstoretype = new DataGridViewTextBoxColumn();
            colstoretype.Name = "FromPharmacy";
            colstoretype.DataPropertyName = "FromPharmacy";
            colstoretype.Width = 170;
            colstoretype.Visible = true;
            colstoretype.ReadOnly = true;
            dtv.Columns.Add(colstoretype);
        }
        private void PopulateDataToGrid(DataGridView dtv)
        {
            dtv.DefaultCellStyle.BackColor = Color.Bisque;
            short index = 0;

            dgvRequisitionList.Rows.Clear();
            List<TransferRequisition> list = new List<TransferRequisition>();
            list.Clear();
            list.AddRange(invSr.GetTRDetSearch().ToList());
            foreach (TransferRequisition data in list)
            {
                string[] row = new string[] { data.ID,
                                              data.RequisitionDate.ToString("dd/MM/yyyy"),                                              
                                              data.Warehouse.TypeName                                              
                                              };
                AddRowsToCollection(dgvRequisitionList, row, index);
                index++;

            }
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        private void frmPurchaseRequisitionList_Load(object sender, EventArgs e)
        {
            FormatGrid(dgvRequisitionList);
            PopulateDataToGrid(dgvRequisitionList);
        }
        private List<TransferRequisition> GetSelectedItem()
        {
            List<TransferRequisition> items = new List<TransferRequisition>();


            TransferRequisition itm = new TransferRequisition();
            itm.ID = dgvRequisitionList.CurrentRow.Cells[0].Value.ToString();

            items.Add(itm);
            //}
            return items;
        }

        private void dgvRequisitionList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (onAddAllButtonClicked != null)
                onAddAllButtonClicked(GetSelectedItem(), sender, e);

            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
