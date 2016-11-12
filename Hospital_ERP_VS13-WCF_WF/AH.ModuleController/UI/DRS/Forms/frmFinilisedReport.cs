using AH.DUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DRSSR;
using System.Linq;

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmFinilisedReport : AH.Shared.UI.frmSmartFormStandard
    {
        private string saveBtnText;
        DRSSR.DRSWSClient drsSc = new DRSSR.DRSWSClient();
        private string Rptgroup;
        public frmFinilisedReport(string Rptgroup)
        {
            this.Rptgroup = Rptgroup;
            InitializeComponent();
        }

        private void frmVerifiedReport_Load(object sender, EventArgs e)
        {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary))), null);

                cboDepartment.Text = lblDeptID.Text;
                cboDepartment.Enabled = false;
                cboDepartment.ForeColor = Color.Black;

                FormatGrid();
      

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


        private void FormatGrid()
        {
            lvUndeliveryList.CheckBoxes = false;
           // lvUndeliveryList.Columns.Add("SpecimenCollection ID", 200, HorizontalAlignment.Left);
            lvUndeliveryList.Columns.Add("HCN", 200, HorizontalAlignment.Left);
            lvUndeliveryList.Columns.Add("Money Receipt Number", 200, HorizontalAlignment.Left);
            lvUndeliveryList.Columns.Add("Patient Name", 300, HorizontalAlignment.Left);

        }
        private void LoadListView(string rptSection, string rptGroup)
        {
            lvUndeliveryList.Items.Clear();
            List<SpecimenCollection> spccol;

            if (rptSection.Length != 0)
            {
                spccol = drsSc.GetReportListToFinalised(rptSection, rptGroup).ToList();
            }
            else
            {
                return;
            }
           // int i = 0;

            foreach (SpecimenCollection spc in spccol)
            {
                ListViewItem itm = new ListViewItem(spc.Patient.HCN);            
                itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                itm.SubItems.Add(spc.Patient.Name);
                lvUndeliveryList.Items.Add(itm);
            }

        }
        private void RefreshGrid(string rptSection,string rptGroup)
        {
            LoadListView(rptSection,rptGroup);
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {          
            if (cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
            {
                LoadListView(cboRptSection.SelectedValue.ToString(),cboRptGroup.SelectedValue.ToString()); 
            }
        }

        private void lvUndeliveryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvUndeliveryList.SelectedItems.Count > 0)
            //{
            //    ListViewItem itm = lvUndeliveryList.SelectedItems[0];
            //     string resultID= itm.SubItems[2].Text;
            //     string  specimanId= itm.SubItems[0].Text;
            //     saveBtnText = "Verify";
            //     frmDiagnosticResultEntry resE = new frmDiagnosticResultEntry(resultID, specimanId,saveBtnText,cboDepartment.Text,cboRptGroup.Text);
            //     resE.lbdDepartment.Text = cboDepartment.Text;
            //     //resE.txtDepartment.Text = cboDepartment.SelectedValue.ToString();
            //     resE.lblReportGroup.Text = cboRptGroup.Text;
            //     resE.txtReportGroup.Text = cboRptGroup.SelectedValue.ToString();
            //     resE.Show();
            //     this.Close();

            //}
        }

        private void lvUndeliveryList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvUndeliveryList.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvUndeliveryList.SelectedItems[0];

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

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "cboDepartment", "cboRptSection", "cboRptGroup" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                if (cboDepartment.SelectedValue != "" && cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
                {
                    if (cboRptGroup.SelectedValue.ToString() == "0021" && cboRptSection.SelectedValue.ToString() == "0004")
                    {
                        frmStainReportResultEntry frmStain = new frmStainReportResultEntry("Pathology", "MicroBiology", "Stain Report", "0012", "0021", "0004", "F");
                        frmStain.ShowDialog();
                    }
                    else if (cboRptGroup.SelectedValue.ToString() == "0020" && cboRptSection.SelectedValue.ToString() == "0004")
                    {
                        frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "F");
                        frmMicroBio.ShowDialog();
                    }
                    else
                    {
                        string mrID = "";
                        saveBtnText = "Finalised";
                        frmDiagnosticResultVerification resE = new frmDiagnosticResultVerification(mrID, saveBtnText,
                                                                                    cboDepartment.Text,
                                                                                    cboRptGroup.Text,
                                                                                    cboRptSection.Text,
                                                                                    cboDepartment.SelectedValue.ToString(),
                                                                                    cboRptGroup.SelectedValue.ToString(),
                                                                                    cboRptSection.SelectedValue.ToString(), "F");
                        resE.lbdDepartment.Text = cboDepartment.Text;
                        resE.ShowDialog();
                        btnPatientSearch.PerformClick();
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
      
    }
}
