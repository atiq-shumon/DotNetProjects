﻿using System;
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
    public partial class frmPurchaseRequisitionList : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        List<string> list;
        public delegate void AddAllClick(List<PurchaseRequisition> items, object sender, EventArgs e);
        public AddAllClick onAddAllButtonClicked;
        public frmPurchaseRequisitionList()
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

            DataGridViewTextBoxColumn colreqby = new DataGridViewTextBoxColumn();
            colreqby.Name = "RequisitionBy";
            colreqby.DataPropertyName = "RequisitionBy";
            colreqby.Width = 200;
            colreqby.Visible = true;
            colreqby.ReadOnly = true;
            dtv.Columns.Add(colreqby);

            DataGridViewTextBoxColumn colstoretype = new DataGridViewTextBoxColumn();
            colstoretype.Name = "Pharmacy";
            colstoretype.DataPropertyName = "Pharmacy";
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
            List<PurchaseRequisition> list = new List<PurchaseRequisition>();
            list.Clear();
            list.AddRange(phrSr.GetPRDetSearch().ToList());
            foreach (PurchaseRequisition data in list)
            {
                string[] row = new string[] { data.ID,
                                              data.RequisitionDate.ToString("dd/MM/yyyy"),
                                              data.RequisitionBy,
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
        private List<PurchaseRequisition> GetSelectedItem()
        {
            List<PurchaseRequisition> items = new List<PurchaseRequisition>();


            PurchaseRequisition itm = new PurchaseRequisition();
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