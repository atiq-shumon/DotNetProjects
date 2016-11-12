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
    public partial class frmResultEntryFilter : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsSc = new DRSSR.DRSWSClient();       
        public frmResultEntryFilter()
        {
            InitializeComponent();           
        }

        private void frmResultEntryFilter_Load(object sender, EventArgs e)
        {
           
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary))), null);
                cboDepartment.Text = lblDeptID.Text;
                cboDepartment.Enabled = false;
                cboDepartment.ForeColor = Color.Black;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboRptGroup.SelectedValue != null)
                {
                    if (cboRptGroup.SelectedValue.ToString() == "0021"
                      && cboRptSection.SelectedValue.ToString() == "0004")
                    {
                        if (cboDepartment.SelectedValue != "" && cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
                        {
                            frmStainReportResultEntry frmStain = new frmStainReportResultEntry("Pathology", "MicroBiology", "Stain Report", "0012", "0021", "0004", "E");
                            frmStain.ShowDialog();
                        }
                    }
                    else if (cboRptGroup.SelectedValue.ToString() == "0020" && cboRptSection.SelectedValue.ToString() == "0004")
                    {
                        if (cboDepartment.SelectedValue != "" && cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
                        {
                            frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "E");
                            frmMicroBio.ShowDialog();
                        }
                    }

                    else
                    {
                        if (cboDepartment.SelectedValue != "" && cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
                        {
                            frmManualDiagnosticResultEntry resE = new frmManualDiagnosticResultEntry(
                                                                cboDepartment.Text,
                                                                cboRptGroup.Text, cboRptSection.Text,
                                                                cboDepartment.SelectedValue.ToString(),
                                                                cboRptGroup.SelectedValue.ToString(),
                                                                cboRptSection.SelectedValue.ToString());
                            resE.Show();
                        }
                    }
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
