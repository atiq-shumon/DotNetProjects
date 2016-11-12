using AH.ModuleController.ACMSSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

namespace AH.ModuleController.UI.ACMS.Reports.ParameterForms
{
    public partial class frmACMSSerach : AH.Shared.UI.frmSmartFormReportStandard
    {
        public delegate void PrintButtonClick(string returnString, Object sender, EventArgs e);
        public PrintButtonClick onPrintButtonClicked;
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();

        public frmACMSSerach()
        {
            InitializeComponent();
        }

        List<AccessControlRO> oACROs = new List<AccessControlRO>();
        public void StyleEmployeeGrid()
        {
            dgvACMS.ClearSelection();
            #region ColumnSize
            dgvACMS.Columns["Emp_ID"].Width = 50;
            dgvACMS.Columns["Nick_Name"].Width = 150;
            dgvACMS.Columns["ModuleName"].Width = 150;
            dgvACMS.Columns["Obj_Name"].Width = 150;
            dgvACMS.Columns["ObjType"].Width = 60;
            dgvACMS.Columns["Auth_Level"].Width = 130;
            dgvACMS.Columns["Grp_Title"].Width = 150;
            dgvACMS.Columns["Emp_ID"].HeaderText = "ID";
            dgvACMS.Columns["Nick_Name"].HeaderText = "Name";
            dgvACMS.Columns["ObjType"].HeaderText = "Type";
            dgvACMS.Columns["Auth_Level"].HeaderText = "Authentication Level";
            dgvACMS.Columns["Grp_Title"].HeaderText = "Group";

            #endregion
            #region ColumnVisibility
            dgvACMS.Columns["E_Mail"].Visible = false;
            dgvACMS.Columns["Grp_ID"].Visible = false;
            dgvACMS.Columns["Remarks"].Visible = false;
            dgvACMS.Columns["Module_ID"].Visible = false;
            dgvACMS.Columns["Obj_Type"].Visible = false;
            dgvACMS.Columns["Auth_Lvl"].Visible = false;
            dgvACMS.Columns["ModuleName"].Visible = false;
            #endregion
            #region Readonly
            dgvACMS.Columns["Emp_ID"].ReadOnly = true;
            dgvACMS.Columns["Nick_Name"].ReadOnly = true;
            dgvACMS.Columns["ModuleName"].ReadOnly = true;
            dgvACMS.Columns["Obj_Name"].ReadOnly = true;
            dgvACMS.Columns["ObjType"].ReadOnly = true;
            dgvACMS.Columns["Auth_Level"].ReadOnly = true;
            #endregion
            #region DisplayIndex
            dgvACMS.Columns["Emp_ID"].DisplayIndex = 1;
            dgvACMS.Columns["Nick_Name"].DisplayIndex = 2;
            dgvACMS.Columns["ModuleName"].DisplayIndex = 3;
            dgvACMS.Columns["Obj_Name"].DisplayIndex = 4;
            dgvACMS.Columns["ObjType"].DisplayIndex = 5;
            dgvACMS.Columns["Auth_Level"].DisplayIndex = 6;
            #endregion
        }  

        private void frmACMSSerach_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Select();
            btnPrint.Visible = false;
            dgvACMS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvACMS.MultiSelect = false;
            oACROs = clnt.GetUserAccessControl().ToList();
            if (oACROs.Count > 0)
            {
                dgvACMS.DataSource = null;
                dgvACMS.DataSource = oACROs;
                StyleEmployeeGrid();
            }
            if (oACROs.Count <= 0)
            {
                dgvACMS.DataSource = null; 
            }
        }


        private void dgvACMS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvACMS.CurrentRow != null)
            {
                int position = dgvACMS.CurrentRow.Index;
                string empid = dgvACMS.Rows[position].Cells["Emp_ID"].Value.ToString();

                if (onPrintButtonClicked != null)
                    onPrintButtonClicked(empid, sender, e);
                this.Dispose();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            dgvACMS.ClearSelection();
            dgvACMS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                for (int i = 0; i < (dgvACMS.Rows.Count); i++)
                {

                    if (dgvACMS.Rows[i].Cells["Nick_Name"].Value.ToString().
                               StartsWith(searchValue.ToString(), true,
                               CultureInfo.InvariantCulture))
                    {
                        dgvACMS.Rows[i].Cells[3].Selected = true;
                        return;
                    }
                }

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
