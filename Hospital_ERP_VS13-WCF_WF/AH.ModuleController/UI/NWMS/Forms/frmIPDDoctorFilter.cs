using AH.DUtility;
using AH.ModuleController.UI.IPD.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.NWMS.Forms
{
    public partial class frmIPDDoctorFilter : AH.Shared.UI.frmSmartFormStandard
    {
       
        NWMSSR.NWMSWSClient nwbnch = new NWMSSR.NWMSWSClient();
        string mode = "";
        public frmIPDDoctorFilter(string mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void frmIPDDoctorFilter_Load(object sender, EventArgs e)
        {
            LoadDepartmentType();
            cboDepartmentType.SelectedIndex = 1;
        }
        private void LoadDepartmentType()
        {
            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);
        }
        private void DepartmentCbo()
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(nwbnch.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(nwbnch.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);
            }
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != null && cboUnit.SelectedValue != null)
            {
                cboDoctor.ValueMember = "Key";
                cboDoctor.DisplayMember = "Value";
                cboDoctor.DataSource = new BindingSource(nwbnch.GetIPDDoctorsDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()), null);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
          //  string DocRoom = "";

            List<string> vf = new List<string>() { "cboDepartment", "cboUnit", "cboDoctor" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
           // DocRoom = nwbnch.GetDrRoom(cboDoctor.SelectedValue.ToString()).ToString();

            frmInteractiveBedInformation frmInteractive = new frmInteractiveBedInformation(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboDoctor.SelectedValue.ToString(),mode);
            frmInteractive.ShowDialog();
        }

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(nwbnch.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(nwbnch.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }
    }
}
