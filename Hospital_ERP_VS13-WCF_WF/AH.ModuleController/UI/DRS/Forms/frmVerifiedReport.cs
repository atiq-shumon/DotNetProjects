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
    public partial class frmVerifiedReport : AH.Shared.UI.frmSmartFormStandard
    {
        private string saveBtnText;
        DRSSR.DRSWSClient drsSc = new DRSSR.DRSWSClient();
        private string Rptgroup;
        public frmVerifiedReport(string Rptgroup)
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

                cboTest.DisplayMember = "Value";
                cboTest.ValueMember = "Key";
                cboTest.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary))), null);
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
                spccol = drsSc.GetReportListToVerify(rptSection, rptGroup).ToList();
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
        //    ListViewItem itm = lvUndeliveryList.SelectedItems[0];
            //if (cboDepartment.SelectedValue != "" && cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
            //{

                //if (cboRptGroup.SelectedValue.ToString() == "0021" && cboRptSection.SelectedValue.ToString() == "0004")
                //{
                //    frmStainReportResultEntry frmStain = new frmStainReportResultEntry("Pathology", "MicroBiology", "Stain Report", "0012", "0021", "0004", "V");
                //    frmStain.ShowDialog();
                //}

                //else if (cboRptGroup.SelectedValue.ToString() == "0020" && cboRptSection.SelectedValue.ToString() == "0004")
                //{
                //    if (cboDepartment.SelectedValue != "" && cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
                //    {
                //        frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "V");
                //        frmMicroBio.ShowDialog();
                //    }
                //}
                //else
                //{
                //    string mrID = "";//itm.SubItems[1].Text;
                //    // string specimanId = itm.SubItems[0].Text;
                //    saveBtnText = "Verified";
                //    frmDiagnosticResultVerification resE = new frmDiagnosticResultVerification(mrID, saveBtnText,
                //                                                                cboDepartment.Text,
                //                                                                cboRptGroup.Text,
                //                                                                cboRptSection.Text,
                //                                                                cboDepartment.SelectedValue.ToString(),
                //                                                                cboRptGroup.SelectedValue.ToString(),
                //                                                                cboRptSection.SelectedValue.ToString(), "V");
                //    resE.lbdDepartment.Text = cboDepartment.Text;
                //    resE.ShowDialog();
                //  //  btnPatientSearch.PerformClick();
                //}
         //   }

        }

        private void lvUndeliveryList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //if (lvUndeliveryList.SelectedItems.Count > 0)
           // //{
           //     ListViewItem itm = lvUndeliveryList.SelectedItems[0];

           //     if (cboRptGroup.SelectedValue.ToString() == "0021" && cboRptSection.SelectedValue.ToString() == "0004")
           //     {
           //         if (cboDepartment.SelectedValue != "" && cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
           //         {

           //             frmStainReportResultEntry frmStain = new frmStainReportResultEntry("Pathology", "MicroBiology", "Stain Report", "0012", "0021", "0004", "V");
           //             frmStain.ShowDialog();
           //         }
           //     }
           //     else if (cboRptGroup.SelectedValue.ToString() == "0020" && cboRptSection.SelectedValue.ToString() == "0004")
           //     {
           //         if (cboDepartment.SelectedValue != "" && cboRptSection.SelectedValue != "" && cboRptGroup.SelectedValue != "")
           //         {
           //             frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "V");
           //             frmMicroBio.ShowDialog();
           //         }
           //     }
           //     else
           //     {
           //         string mrID = itm.SubItems[1].Text;
           //      // string specimanId = itm.SubItems[0].Text;
           //         saveBtnText = "Verified";
           //         frmDiagnosticResultVerification resE = new frmDiagnosticResultVerification(mrID, saveBtnText,
           //                                                                     cboDepartment.Text,
           //                                                                     cboRptGroup.Text,
           //                                                                     cboRptSection.Text,
           //                                                                     cboDepartment.SelectedValue.ToString(),
           //                                                                     cboRptGroup.SelectedValue.ToString(),
           //                                                                     cboRptSection.SelectedValue.ToString(), "V");
           //         resE.lbdDepartment.Text = cboDepartment.Text;                    
           //         resE.ShowDialog();
           //         btnPatientSearch.PerformClick();                   
           //     }
           //// }

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

   
        private void cboTest_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;

            // Do nothing for certain keys, such as navigation keys.
            if ((e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                (e.KeyCode == Keys.Up) ||
                (e.KeyCode == Keys.Down) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.PageUp) ||
                (e.KeyCode == Keys.PageDown) ||
                (e.KeyCode == Keys.Home) ||
                (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cboTest.Text;

            // Find the first match for the typed value.
            index = this.cboTest.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboTest.Items[index].ToString();

                // Select this item from the list.
                this.cboTest.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboTest.SelectionStart = actual.Length;
                this.cboTest.SelectionLength = found.Length;
            }
            if (index == -1)
            {
              cboTest.Text = string.Empty;
            }
        }

        private void cboTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            cboTest.DroppedDown = true;
        }

        private void cboRptGroup_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;

            // Do nothing for certain keys, such as navigation keys.
            if ((e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                (e.KeyCode == Keys.Up) ||
                (e.KeyCode == Keys.Down) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.PageUp) ||
                (e.KeyCode == Keys.PageDown) ||
                (e.KeyCode == Keys.Home) ||
                (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cboRptGroup.Text;

            // Find the first match for the typed value.
            index = this.cboRptGroup.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboRptGroup.Items[index].ToString();

                // Select this item from the list.
                this.cboRptGroup.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboRptGroup.SelectionStart = actual.Length;
                this.cboRptGroup.SelectionLength = found.Length;
            }
            if (index == -1)
            {
                cboRptGroup.Text = string.Empty;
            }
        }

        private void cboRptGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            cboRptGroup.DroppedDown = true;
        }

        private void cboTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboTest.SelectedValue != "")
            //{
            //    cboRptSection.DisplayMember = "Value";
            //    cboRptSection.ValueMember = "Key";
            //    cboRptSection.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetRptSecSetup(cboTest.SelectedValue.ToString())), null);
            //}
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
                        frmStainReportResultEntry frmStain = new frmStainReportResultEntry("Pathology", "MicroBiology", "Stain Report", "0012", "0021", "0004", "V");
                        frmStain.ShowDialog();
                    }

                    else if (cboRptGroup.SelectedValue.ToString() == "0020" && cboRptSection.SelectedValue.ToString() == "0004")
                    {

                        frmMicroBiologyResultEntry frmMicroBio = new frmMicroBiologyResultEntry("Pathology", "MicroBiology", "Culture and Sensitivity Report", "0012", "0020", "0004", "V");
                        frmMicroBio.ShowDialog();

                    }
                    else
                    {
                        string mrID = "";
                        saveBtnText = "Verified";
                        frmDiagnosticResultVerification resE = new frmDiagnosticResultVerification(mrID, saveBtnText,
                                                                                    cboDepartment.Text,
                                                                                    cboRptGroup.Text,
                                                                                    cboRptSection.Text,
                                                                                    cboDepartment.SelectedValue.ToString(),
                                                                                    cboRptGroup.SelectedValue.ToString(),
                                                                                    cboRptSection.SelectedValue.ToString(), "V");
                        resE.lbdDepartment.Text = cboDepartment.Text;
                        resE.ShowDialog();

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

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
