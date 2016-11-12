using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.FNB.Reports.Viewer;
using AH.ModuleController.FNBSR;
using AH.DUtility;



namespace AH.ModuleController.UI.FNB.Reports.ParameterForms
{
    public partial class frmRptMealRegister : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public frmRptMealRegister()
        {
            InitializeComponent();
        }

        private void frmRptMealRegister_Load(object sender, EventArgs e)
        {
            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);
             
        }

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
               cboDepartmentGroup.DisplayMember = "Value";
               cboDepartmentGroup.ValueMember = "Key";
               cboDepartmentGroup.DataSource = new BindingSource(fnbs.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
               
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string strGrpID="",strDepID="";
            int intAll = 0;
            if (chkAll.Checked==true)
            {
                intAll = 1;
            }
            else
            {
                intAll = 0;
            }
            strGrpID=cboDepartmentGroup.SelectedValue.ToString();
            strDepID=cboDepartment.SelectedValue.ToString();
            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.MonthWiseMEalReg;
            frm.Where = strGrpID;
            frm.where1 = strDepID;
            frm.strFromDate = mskFDate.Value.ToString("dd/MM/yyyy");
            frm.strToDate = mskTDate.Value.ToString("dd/MM/yyyy") ;
            frm.strParam = cboDepartmentType.Text;
            frm.intAll = intAll; 
            frm.ShowDialog();
        }

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(fnbs.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }

        
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            {
                cboDepartmentType.Enabled = false;
                cboDepartmentGroup.Enabled = false;
                cboDepartment.Enabled = false;
            }
            else
            {
                cboDepartmentType.Enabled = true;
                cboDepartmentGroup.Enabled = true;
                cboDepartment.Enabled = true;
            }
    
        }









    }
}
