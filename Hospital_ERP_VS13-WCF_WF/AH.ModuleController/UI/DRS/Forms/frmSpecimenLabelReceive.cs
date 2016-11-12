using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmSpecimenLabelReceive : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsSc = new DRSSR.DRSWSClient();
        public frmSpecimenLabelReceive()
        {
            InitializeComponent();          
        }

        private void frmSpecimenLabelReceive_Load(object sender, EventArgs e)
        {          
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary))), null);       
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartment.SelectedValue != "" && cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
                {
                    frmSpecimenReceived resReceiv = new frmSpecimenReceived("mode");
                    resReceiv.txtDepartment.Text = cboDepartment.SelectedValue.ToString();
                    resReceiv.txtReportGroup.Text = cboRptGroup.SelectedValue.ToString();
                    resReceiv.ShowDialog();
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

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cboDepartment.SelectedValue != "")
            {
                cboRptSection.DisplayMember = "Value";
                cboRptSection.ValueMember = "Key";
                cboRptSection.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetRptSecSetup(cboDepartment.SelectedValue.ToString())), null);
            }

        }
        private void cboRptSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRptSection.SelectedValue != "")
            {
                cboRptGroup.DisplayMember = "Value";
                cboRptGroup.ValueMember = "Key";
                cboRptGroup.DataSource = new BindingSource(drsSc.GetRptgrpDic(cboRptSection.SelectedValue.ToString()), null);
            }
        }
    }
}
