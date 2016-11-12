using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AH.ModuleController.ACMSSR;
using AH.DUtility;

using System.Linq;

namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmUserObject : AH.Shared.UI.frmSmartFormStandard
    {

        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();

        List<ObjectSetup> oObjectSetupBOs = new List<ObjectSetup>();

        string Employee="";

        public frmUserObject()
        {
            InitializeComponent();
        }


        private void frmModuleObject_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Select();
            Employee = txtEmployeeID.Text;

            cboModuleObject.DisplayMember = "Value";
            cboModuleObject.ValueMember = "Key";
            cboModuleObject.DataSource = new BindingSource(Utility.GetModuleNames(), null);

            FormatGrid();
        }

        private ObjectSetup PopulateObject()
        {
            ObjectSetup oObjectSetupBO = new ObjectSetup();

            Module oModule = new Module();
            oModule.ModuleID = cboModuleObject.SelectedValue.ToString();     
            oObjectSetupBO.Module = oModule;


            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.Active = "1";
            oEntryParameter.Version = "1";
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oEntryParameter.EntryBy = Utility.UserId;

            oObjectSetupBO.EntryParameter = oEntryParameter;

            oObjectSetupBOs.Add(oObjectSetupBO);

            return oObjectSetupBO;
        }

        private void FormatGrid()
        {
            lvModuleObject.Columns.Add("Object ID", 200, HorizontalAlignment.Center);
            lvModuleObject.Columns.Add("Object Name", 250, HorizontalAlignment.Center);
            lvModuleObject.Columns.Add("Object Type", 200, HorizontalAlignment.Center);
            lvModuleObject.Columns.Add("Authentication Level", 150, HorizontalAlignment.Center);  
        }

        private void LoadListView(string empID, string moduleID)
        {
            lvModuleObject.Items.Clear();

            oObjectSetupBOs = clnt.GetUserObject(txtEmployeeID.Text,cboModuleObject.SelectedValue.ToString()).ToList();

            foreach (ObjectSetup i in oObjectSetupBOs)
            {
                ListViewItem itm = new ListViewItem(i.ObjID.ToString());    //(i.Module.ModuleID.ToString());             
                //itm.SubItems.Add(i.Module.ModuleID.ToString());
                //itm.SubItems.Add(i.ObjID.ToString());
                itm.SubItems.Add(i.ObjName.ToString());
                itm.SubItems.Add(i.ObjType.ToString());
                itm.SubItems.Add(i.AuthenticationLevel.ToString());

                lvModuleObject.Items.Add(itm);
            }

            this.lvModuleObject.View = View.Details; 
        }

        List<ObjectSetup> oGrids = new List<ObjectSetup>();


        private void btnShow_Click(object sender, EventArgs e)
        {

            AH.ModuleController.ACMSSR.EmployeeMaster oEmpMas = clnt.GetEmpoyee(txtEmployeeID.Text);
            if (txtEmployeeID.Text != oEmpMas.EmpId)
            {
                MessageBox.Show("Please put a valid employee id", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeID.Select();
                return;
            }


            LoadListView(txtEmployeeID.Text, cboModuleObject.SelectedValue.ToString());
           
            for (int rowcnt = 0; rowcnt < oObjectSetupBOs.Count; rowcnt++)
            {
                if (cboModuleObject.Text == oObjectSetupBOs[rowcnt].Module.ModuleID.ToString())
                {

                    ObjectSetup oGrid = new ObjectSetup();

                    oGrid.ObjID = oObjectSetupBOs[rowcnt].ObjID;
                    oGrid.ObjName = oObjectSetupBOs[rowcnt].ObjName;
                    oGrid.ObjType = oObjectSetupBOs[rowcnt].ObjType;
                    oGrid.ObjType = oObjectSetupBOs[rowcnt].AuthenticationLevel;

                    oGrids.Add(oGrid);  
                }
            }
            //lvModuleObject.Items.Clear();
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";


            if (txtEmployeeID.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmployeeID.Text != string.Empty)
            {
                AH.ModuleController.ACMSSR.EmployeeMaster oEmpMas = clnt.GetEmpoyee(txtEmployeeID.Text);

                if (txtEmployeeID.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName+ "\r\n"+ oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();
                    //txtUserName.Text = oEmpMas.FirstName;
                    //txtEmail.Text = oEmpMas.Email;
                }
                else
                {
                    MessageBox.Show("Please put a valid user id", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //  txtUID.Select();
                    return;
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lvModuleObject.Clear();
            lblInfo.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

    }
}
