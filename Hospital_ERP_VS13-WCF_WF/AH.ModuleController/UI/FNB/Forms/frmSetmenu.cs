using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;


namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmSetmenu : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public frmSetmenu()
        {
            InitializeComponent();
        }

        private void Format_GridUp()
        {
            DGUP.Columns.Add(Create_Grid_Column("Item Code", "Item Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(Create_Grid_Column("Item Name", "Item Name", 370, true, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(Create_Grid_Column("Unit Code", "Unit Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(Create_Grid_Column("Unit Name", "Unit Name", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(Create_Grid_Column("Brand Code", "Brand Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            //DG.Columns.Add(Create_Grid_Column("Brand Name", "Brand Name", 135, true, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(Create_Grid_Column("Model Code", "Model Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            //DG.Columns.Add(Create_Grid_Column("Model Name", "Model Name", 135, true, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(Create_Grid_Column("Qty.", "Qty.", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(Create_Grid_Column("Rate", "Rate", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DGUP.Columns.Add(Create_Grid_Column("Amount", "Amount", 100, true, DataGridViewContentAlignment.TopLeft, true));
            //DG.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 70, true, DataGridViewContentAlignment.TopCenter, true));
        }
        private void Format_GridDown()
        {
            DGdown.Columns.Add(Create_Grid_Column("Item Code", "Item Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Item Name", "Item Name", 370, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Unit Code", "Unit Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Unit Name", "Unit Name", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Brand Code", "Brand Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            //DG.Columns.Add(Create_Grid_Column("Brand Name", "Brand Name", 135, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Model Code", "Model Code", 0, false, DataGridViewContentAlignment.TopLeft, true));
            //DG.Columns.Add(Create_Grid_Column("Model Name", "Model Name", 135, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Qty.", "Qty.", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Rate", "Rate", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column("Amount", "Amount", 100, true, DataGridViewContentAlignment.TopLeft, true));
            DGdown.Columns.Add(Create_Grid_Column_button("Del", "Del", "Del", 70, true, DataGridViewContentAlignment.TopCenter, true));
        }


        public DataGridViewButtonColumn Create_Grid_Column_button(string pname, string htext, string btext, int cwidth, Boolean true_false,
            DataGridViewContentAlignment Align, Boolean read_only)
        {
            DataGridViewButtonColumn col0 = new DataGridViewButtonColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.Text = btext;
            col0.DefaultCellStyle.ForeColor = Color.Red;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }
        private DataGridViewTextBoxColumn Create_Grid_Column(string pname, string htext, int cwidth, Boolean true_false, DataGridViewContentAlignment Align,
                                                            Boolean read_only)
        {
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.DataPropertyName = pname;
            col0.HeaderText = htext;
            col0.DefaultCellStyle.ForeColor = Color.Black;
            col0.DefaultCellStyle.BackColor = Color.White;
            col0.Visible = true_false;
            col0.DefaultCellStyle.Alignment = Align;
            col0.Width = cwidth;
            col0.ReadOnly = read_only;
            return col0;
        }

        private void frmSetmenu_Load(object sender, EventArgs e)
        {
            Format_GridUp();
            Format_GridDown();
            cboGroupName.ValueMember = "Key";
            cboGroupName.DisplayMember = "Value";
            cboGroupName.DataSource = new BindingSource(fnbs.GetStockGroup(), null);
        }

    }
}
