using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmPharmacyUsers : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmPharmacyUsers()
        {
            InitializeComponent();
        }

        private void smartTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPharmacyUsers_Load(object sender, EventArgs e)
        {
            cboPharmacyLocation.DisplayMember = "WhName";
            cboPharmacyLocation.ValueMember = "Whid";
            cboPharmacyLocation.DataSource = new BindingSource(phrSr.GetWarehouseTypewise("1","0"), null);
            FormatListView();
            LoadListView();
           
        }

        private void smartLabel1_Click(object sender, EventArgs e)
        {

        }

        private void smartTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cboPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtUserID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
           
            try
            {
                PharmacyUser usr = this.populatePharmacyUser();
                //DrugIssue mstr = this.populateDrugIssue();
                short i = phrSr.SavePharmacyUsers(usr);
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
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private PharmacyUser populatePharmacyUser()
        {
            PharmacyUser user = new PharmacyUser();
            user.UserID = txtUserID.Text;

           
            Warehouse owh = new Warehouse();
            owh.TypeID = cboPharmacyLocation.SelectedValue.ToString();
            user.Warehouse = owh;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            user.EntryParameter = ep;

            return user;

        }
        private void FormatListView()
        {
            lvPharmacyUser.CheckBoxes = false;

            lvPharmacyUser.Columns.Add("UserID",100,HorizontalAlignment.Left);
            lvPharmacyUser.Columns.Add("PharmacyID", 0, HorizontalAlignment.Left);
            lvPharmacyUser.Columns.Add("PharmacyName", 350, HorizontalAlignment.Left);

        }
        private void LoadListView()
        {
            lvPharmacyUser.Items.Clear();

            List<PharmacyUser> user = phrSr.GetUser().ToList();
            int i = 0;
            foreach (PharmacyUser tr in user)
            {
                ListViewItem itm = new ListViewItem(tr.UserID);
                itm.SubItems.Add(tr.Warehouse.TypeID);
                itm.SubItems.Add(tr.Warehouse.TypeName);
                lvPharmacyUser.Items.Add(itm);
            }
       }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvPharmacyUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPharmacyUser.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPharmacyUser.SelectedItems[0];
                txtUserID.Text = itm.SubItems[0].Text;
                cboPharmacyLocation.Text = itm.SubItems[2].Text;

            }
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "";
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas = phrSr.GetEmpMaster(txtUserID.Text);
                if (txtUserID.Text == "")
                {
                    lblInfo.Text = "";
                    return;
                }
                if (txtUserID.Text != "")
                {
                    if (txtUserID.Text == oEmpMas.EmpId)
                    {

                        lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                        //lblDept.Text = oEmpMas.Department.DepartmentID;
                    }

                    else
                    {
                        MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUserID.Select();
                    }
                }
            }
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = phrSr.GetEmpMaster(txtUserID.Text);
            if (txtUserID.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtUserID.Text != "")
            {
                if (txtUserID.Text == oEmpMas.EmpId)
                {

                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                    //lblDept.Text = oEmpMas.Department.DepartmentID;
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserID.Select();
                }
            }
        }
    }
}
