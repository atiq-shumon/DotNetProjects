using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmDoctorFilter : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdsr = new OPDSR.OPDWSClient();

        public frmDoctorFilter()
        {
            InitializeComponent();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string DocRoom = "";

            List<string> vf = new List<string>() { "cboDepartment", "cboUnit", "cboDoctor" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            DocRoom = opdsr.GetDrRoom(cboDoctor.SelectedValue.ToString()).ToString();

            frmPrescription pres = new frmPrescription(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(), cboDoctor.SelectedValue.ToString(), DocRoom);

            pres.ShowDialog();
        }

        private void frmDoctorFilter_Load(object sender, EventArgs e)
        {
            DepartmentCbo();
        }

        private void DepartmentCbo()
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
        }

        private void UnitCbo()
        {
            cboUnit.DisplayMember = "Value";
            cboUnit.ValueMember = "Key";
            cboUnit.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboDepartment.SelectedValue.ToString())), null);
        }
        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboDepartment.SelectedValue.ToString())), null);
            }
            else
            {
                return;
            }
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDoctor.DisplayMember = "Value";
            cboDoctor.ValueMember = "Key";
            cboDoctor.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetOPDDoctorsDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString())), null);
        }
    }
}