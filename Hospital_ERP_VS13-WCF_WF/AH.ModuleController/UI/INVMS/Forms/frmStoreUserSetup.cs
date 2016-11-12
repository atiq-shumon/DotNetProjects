using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;


namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmStoreUserSetup : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmStoreUserSetup()
        {
            InitializeComponent();
        }

        private void frmStoreUserSetup_Load(object sender, EventArgs e)
        {
            txtEmpId.Select();

            cboStore.ValueMember = "ID";
            cboStore.DisplayMember = "Name";
            cboStore.DataSource = new BindingSource(invSr.GetStoreLocation(),null);

            lblInfo.Visible = false;

            FormatListView();
            LoadListView();
            btnEdit.Enabled = false;
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = invSr.GetEmpMaster(txtEmpId.Text);
            if (txtEmpId.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmpId.Text != "")
            {
                if (txtEmpId.Text == oEmpMas.EmpId)
                {

                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                    //lblDept.Text = oEmpMas.Department.DepartmentID;
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmpId.Select();
                }
            }
        }

        private void txtEmpId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboStore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = invSr.GetEmpMaster(txtEmpId.Text);

            List<string> vf = new List<string>() { "txtEmpId" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvStoreUser, 0, txtEmpId.Text))
            {
                MessageBox.Show("Employee already exist");
                return;
            }
            if (txtEmpId.Text != "")
            {
                if (txtEmpId.Text != oEmpMas.EmpId)
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmpId.Select();
                }
            }

            try
            {
                StoreUser usr = this.populateStoreUser();
                
                short i = invSr.SaveStoreUser(usr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnNew.PerformClick();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private StoreUser populateStoreUser()
        {
            StoreUser ostruser = new StoreUser();

            EmployeeMaster oemp = new EmployeeMaster();
            oemp.ID = txtEmpId.Text;
            ostruser.EmployeeMaster = oemp;

            StoreLocation oloc = new StoreLocation();
            oloc.ID = cboStore.SelectedValue.ToString();
            ostruser.StoreLocation = oloc;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ostruser.EntryParameter = ep;

            return ostruser;
        }
        private void FormatListView()
        {
            lvStoreUser.CheckBoxes = false;

            lvStoreUser.Columns.Add("Emp ID", 100, HorizontalAlignment.Left);
            lvStoreUser.Columns.Add("Emp Name", 100, HorizontalAlignment.Left);
            lvStoreUser.Columns.Add("StoreID", 0, HorizontalAlignment.Left);
            lvStoreUser.Columns.Add("StoreName", 250, HorizontalAlignment.Left);

        }
        private void LoadListView()
        {
            lvStoreUser.Items.Clear();

            List<StoreUser> user = invSr.GetStoreUser().ToList();
            int i = 0;
            foreach (StoreUser tr in user)
            {
                ListViewItem itm = new ListViewItem(tr.EmployeeMaster.ID);
                itm.SubItems.Add(tr.EmployeeMaster.FirstName);
                itm.SubItems.Add(tr.StoreLocation.ID);
                itm.SubItems.Add(tr.StoreLocation.Name);
                lvStoreUser.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvStoreUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            if (lvStoreUser.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvStoreUser.SelectedItems[0];
                txtEmpId.Text = itm.SubItems[0].Text;
                lblInfo.Text = itm.SubItems[1].Text;
                cboStore.Text = itm.SubItems[2].Text;
                cboStore.Text = itm.SubItems[3].Text;
            }
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }
        
    }
}
