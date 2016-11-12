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
    public partial class frmDeptUnitWiseReqAdvanceSearch : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        List<SCMTree> itemissue;
        public frmDeptUnitWiseReqAdvanceSearch()
        {
            InitializeComponent();
        }

        private void frmDeptUnitWiseReqAdvanceSearch_Load(object sender, EventArgs e)
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(invSr.GetDepartments("D"), null);

            cboDepartment.SelectedIndexChanged += new EventHandler(cboDepartment_SelectedIndexChanged);                  
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.Text != "--Select--")
            {
                if (cboDepartment.Text != "")
                {
                    cboUnit.DisplayMember = "Value";
                    cboUnit.ValueMember = "Key";
                    cboUnit.DataSource = new BindingSource(Utility.VerifyDic(invSr.GetUnitDict(cboDepartment.SelectedValue.ToString())), null);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            treeviewItemIssue.Nodes.Clear();
            itemissue = invSr.GetDrNODeptUnitwise(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString(),dtFromDate.Text,dtToDate.Text).Select(c => new SCMTree { Date = c.RequisitionDate, ID = c.ID }).ToList();
            Utility.PopulateTreeSCM(treeviewItemIssue, itemissue);    
        }
    }
}
