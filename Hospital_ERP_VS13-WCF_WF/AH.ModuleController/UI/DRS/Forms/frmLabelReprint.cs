using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.DRSSR;
using AH.ModuleController.UI.DRS.Reports.Viewer;

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmLabelReprint : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient dsrclnt = new DRSSR.DRSWSClient();
        public frmLabelReprint()
        {
            InitializeComponent();
        }

        private void lvMRTests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmLabelReprint_Load(object sender, EventArgs e)
        {
           
                txtMRNo.Select();
                formatListView();
          
        }
        private void formatListView()
        {

            lvMRTests.Columns.Add("Requested Test", 600, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("test Code", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("DepartmentID", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("Group ID", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("Rpt grpCode", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("Report Group", 350, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("PnlCode", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("mainCode", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("Main Title", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("Fee Category", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("SpecimenID", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("LabRoomID", 0, HorizontalAlignment.Left);

        }
        private void loadMRTests(string specNo)
        {
            lvMRTests.Items.Clear();

            //List<TestFee> tsFee = dsrClnt.GetReportTest(txtMRNo.Text).ToList();
            List<TestFee> list = new List<TestFee>();
            list.AddRange(dsrclnt.GetSpcCollectedTest(specNo));


            // list=list.Select(data => new { data.TestSub.Room.RoomID, data.TestSub.Technologist.ID, data.TestSub.ReportGroup.ReportGroupID, data.TestSub.TestDepartment, data.TestSub.TestDepartmentTitle, data.TestGroup.GroupId, data.TestSub.TestSubTitle, data.TestSub.TestSubID, data.TestSub.Room.RoomTitle, data.Fee, data.DeptFee, data.DoctorFee, data.RefdFee, data.TestSub.TestMainID, data.TestSub.TestMainTitle, data.Discount, data.VAT }).ToList();


            foreach (TestFee ts in list)
            {
                ListViewItem itm = new ListViewItem(ts.TestSub.TestSubTitle);
                itm.SubItems.Add(ts.TestSub.TestSubID);
                itm.SubItems.Add(ts.TestSub.TestDepartment.DepartmentID);
                itm.SubItems.Add(ts.TestSub.TestGroup.GroupId);
                itm.SubItems.Add(ts.TestSub.ReportGroup.ReportGroupID);
                itm.SubItems.Add(ts.TestSub.ReportGroup.ReportGroupTitle);
                itm.SubItems.Add(ts.TestSub.PanelID);
                itm.SubItems.Add(ts.TestSub.TestMainID);
                itm.SubItems.Add(ts.TestSub.TestMainTitle);
                itm.SubItems.Add(ts.FeeCategory.FeeCategoryID);
                itm.SubItems.Add(ts.TestSub.Specimen.SpecimenID);
                itm.SubItems.Add(ts.TestSub.LabRoom.RoomID);
                lvMRTests.Items.Add(itm);
            }

        }
        private void ControlListViewUI(short mode)
        {

            switch (mode)
            {
                case 0:
                    for (int i = 0; i < lvMRTests.Items.Count; i++)
                    {
                        lvMRTests.Items[i].Checked = false;
                    }
                    break;
                case 1:
                    for (int i = 0; i < lvMRTests.Items.Count; i++)
                    {
                        lvMRTests.Items[i].Checked = true;
                    }
                    break;
                case 2:
                    for (int i = 0; i < lvMRTests.Items.Count; i++)
                    {
                        if (lvMRTests.Items[i].Checked == true)
                        {
                            lvMRTests.Items[i].BackColor = Color.Bisque;
                        }
                    }
                    break;
            }


        }

        private void cboPatientMr_Click(object sender, EventArgs e)
        {
            if (dsrclnt.verifyMrno(txtMRNo.Text) == "0")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMRNo.Select();
                btnNew.PerformClick();
                return;

            }

            InPatient pat = dsrclnt.GetCurrentPatient(txtMRNo.Text);
            LoadPatient(pat);

          //  loadMRTests(txtMRNo.Text);
            ControlListViewUI(1);
        }
        private void LoadPatient(InPatient pat)
        {
            txtPatientName.Text = pat.Name;
            txtHCN.Text = pat.HCN;
            txtRegNo.Text = pat.RegistrationNo;
            txtAgeYears.Text = pat.Age.Year.ToString();
            txtAgeMonths.Text = pat.Age.Month.ToString();
            txtAgeDays.Text = pat.Age.Day.ToString();
            txtAgeHours.Text = pat.Age.Hour.ToString();
            txtSex.Text = pat.Sex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtMRNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
