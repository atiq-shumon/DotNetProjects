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
    public partial class frmTrackingGroupwiseStock : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmTrackingGroupwiseStock()
        {
            InitializeComponent();
        }

        private void frmTrackingGroupwiseStock_Load(object sender, EventArgs e)
        {

            cboStoreType.ValueMember = "strTypeID";
            cboStoreType.DisplayMember = "TypeTitle";
            cboStoreType.DataSource = invSr.GetStoreType().ToList();

            FormatDataGridView(dgvItemList);
        }

        private void cboMajorGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMajorGroup.SelectedValue != null)
            {

                cboMinorGroup.DisplayMember = "Name";
                cboMinorGroup.ValueMember = "ID";
                cboMinorGroup.DataSource = invSr.GetGroupByMajorGrp(cboStoreType.SelectedValue.ToString(), cboMajorGroup.SelectedValue.ToString());
            }
        }

        private void cboStoreType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMajorGroup.ValueMember = "MajorgrpID";
            cboMajorGroup.DisplayMember = "Name";
            cboMajorGroup.DataSource = invSr.GetMajorGrpByStrtype(cboStoreType.SelectedValue.ToString());
        }

        private void FormatDataGridView(DataGridView dtv)
        {
            dtv.AutoGenerateColumns = false;

           
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
            
            DataGridViewTextBoxColumn colquantity = new DataGridViewTextBoxColumn();
            colquantity.Name = "Stock";
            colquantity.DataPropertyName = "Stock";
            colquantity.Width = 80;
            colquantity.Visible = true;
            colquantity.ReadOnly = true;
            dtv.Columns.Add(colquantity);
            DataGridViewTextBoxColumn collastpurchasedate = new DataGridViewTextBoxColumn();
            collastpurchasedate.Name = "PurchaseDate";
            collastpurchasedate.DataPropertyName = "PurchaseDate";
            collastpurchasedate.Width = 100;
            collastpurchasedate.Visible = true;
            collastpurchasedate.ReadOnly = true;
            dtv.Columns.Add(collastpurchasedate);

            DataGridViewTextBoxColumn collastpurchaserate = new DataGridViewTextBoxColumn();
            collastpurchaserate.Name = "PurchaseRate";
            collastpurchaserate.DataPropertyName = "PurchaseRate";
            collastpurchaserate.Width = 100;
            collastpurchaserate.Visible = true;
            collastpurchaserate.ReadOnly = true;
            dtv.Columns.Add(collastpurchaserate);

            DataGridViewTextBoxColumn collsupplier = new DataGridViewTextBoxColumn();
            collsupplier.Name = "Supplier";
            collsupplier.DataPropertyName = "Supplier";
            collsupplier.Width = 150;
            collsupplier.Visible = true;
            collsupplier.ReadOnly = true;
            dtv.Columns.Add(collsupplier);

        }
        private void PopulateDataToGrid(DataGridView dtv, string grpid)
        {
            
            //dtv.DefaultCellStyle.BackColor = Color.Bisque;
            short index = 0;
            dgvItemList.Rows.Clear();
            List<ItemMaster> list = new List<ItemMaster>();
            list.Clear();
            list.AddRange(invSr.GetItemStockList(grpid).ToList());
            foreach (ItemMaster data in list)
            {
                string[] row = new string[] { 
                                              data.ID,
                                              
                                              data.Name,
                                              data.StockQty.ToString(),
                                              data.Day.ToString("dd/MM/yyyy"),
                                              data.Urate.ToString(),
                                              data.Supplier.Name
                                              };
                AddRowsToCollection(dgvItemList, row, index);
                index++;

            }
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            PopulateDataToGrid(dgvItemList,cboMinorGroup.SelectedValue.ToString());
        }

    }
}
