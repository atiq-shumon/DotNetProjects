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
    public partial class frmDemandRequisitionList : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        List<string> list;
        public delegate void AddAllClick(List<DemandRequisition> items, object sender, EventArgs e);
        public AddAllClick onAddAllButtonClicked;
        public frmDemandRequisitionList()
        {
            InitializeComponent();
        }

        private void frmDemandRequisitionList_Load(object sender, EventArgs e)
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(invSr.GetDepartmentsetupDic(null, Utility.UserDepartmentGroupID), null);

            cboDepartment.Text = Utility.UserDepartment;
            cboUnit.Text = Utility.UserUnitTitle;

            txtRequisitionBy.Text = Utility.UserId;

            cboDepartment.SelectedIndexChanged += new EventHandler(cboDepartment_SelectedIndexChanged_1);

            FormatGrid(dgvRequisitionList);

            PopulateDataToGrid(dgvRequisitionList,cboDepartment.SelectedValue.ToString(),cboUnit.SelectedValue.ToString());
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void cboDepartment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue.ToString() != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(invSr.GetDeptUnitDic(Utility.UserDepartmentGroupID, cboDepartment.SelectedValue.ToString())), null);
            }
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
            colstoretype.Name = "Store";
            colstoretype.DataPropertyName = "Store";
            colstoretype.Width = 170;
            colstoretype.Visible = true;
            colstoretype.ReadOnly = true;
            dtv.Columns.Add(colstoretype);
        }
        private void PopulateDataToGrid(DataGridView dtv, string deptid, string unitid)
        {
            dtv.DefaultCellStyle.BackColor = Color.Bisque;
            short index = 0;

            dgvRequisitionList.Rows.Clear();
            List<DemandRequisition> list = new List<DemandRequisition>();
            list.Clear();
            list.AddRange(invSr.GetDrDetailsDeptUnitWise(deptid,unitid).ToList());
            foreach (DemandRequisition data in list)
            {
                string[] row = new string[] { data.ID,
                                              data.RequisitionDate.ToString("dd/MM/yyyy"),
                                              data.RequisitionByName,
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
        private List<DemandRequisition> GetSelectedItem()
        {
            List<DemandRequisition> items = new List<DemandRequisition>();          
            DemandRequisition itm = new DemandRequisition();
            itm.ID = dgvRequisitionList.CurrentRow.Cells[0].Value.ToString();
            items.Add(itm);            
            return items;
        }
        private void dgvRequisitionList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvRequisitionList_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
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
