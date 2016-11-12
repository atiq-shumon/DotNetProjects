using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR; 
using AH.DUtility;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmDepartment : AH.Shared.UI.frmSmartFormStandard
    {
        
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        public frmDepartment()
        {
            InitializeComponent();
        }
        private bool validationfields()
        {
            if (txtDepartmentName.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private Department  PopulateDepartment()
        {
            Department Dept = new Department();
            if (txtDepartmentID.Text != "")
            {
                Dept.DepID = txtDepartmentID.Text;
            }
            Dept.DepName = txtDepartmentName.Text;
            Dept.Remarks = txtRemarks.Text;
            Dept.FormName = "Department";
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            Dept.EntryParameter = ep;
            return Dept;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationfields() == true)
            {
                MessageBox.Show("Empty field");
            }
            else 
            {
                var strResponse = MessageBox.Show("Do You want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    Department objDept= this.PopulateDepartment();
                    short i = atms.SaveDepartment(objDept);

                }
            }
            //loadList();
            //lblmode.Text = "You are in Add Mode";
            //mClear();

        }
    }
}
