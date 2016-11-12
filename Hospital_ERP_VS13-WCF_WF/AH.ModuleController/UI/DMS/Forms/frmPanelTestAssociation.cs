using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DMSSR;
using AH.DUtility;
namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmPanelTestAssociation : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public string Panel { set; get; }
        private int CheckSave = 0;
        private List<TestFee> det;
        public frmPanelTestAssociation()
        {
            InitializeComponent();
        }
        private void FormatTestList()
        {
            lvTestList.Columns.Add("", 20, HorizontalAlignment.Left);
            lvTestList.Columns.Add("Test Name", 450, HorizontalAlignment.Left);
            lvTestList.Columns.Add("Dept ID", 0, HorizontalAlignment.Left);
            lvTestList.Columns.Add("Grp ID", 0, HorizontalAlignment.Left);
            lvTestList.Columns.Add("Main ID", 0, HorizontalAlignment.Left);
        }
        private void FormatAssociatedList()
        {
            lvAssociatedList.Columns.Add("", 20, HorizontalAlignment.Left);
            lvAssociatedList.Columns.Add("Test Name", 500, HorizontalAlignment.Left);
            lvAssociatedList.Columns.Add("Dept ID", 0, HorizontalAlignment.Left);
            lvAssociatedList.Columns.Add("Grp ID", 0, HorizontalAlignment.Left);
            lvAssociatedList.Columns.Add("Main ID", 0, HorizontalAlignment.Left);
        }
        private void LoadTestList()
        {
            if (cboPanel.SelectedValue != null)
            {
                lvTestList.Items.Clear();
                det = dmsSC.GetPanelTest(cboPanel.SelectedValue.ToString()).ToList();
                foreach (TestFee dt in det)
                {
                    ListViewItem itm = new ListViewItem(dt.TestSub.TestSubID);
                    itm.SubItems.Add(dt.TestSub.TestSubTitle.ToString());
                    itm.SubItems.Add(dt.TestSub.TestDepartment.DepartmentID);
                    itm.SubItems.Add(dt.TestSub.TestGroup.GroupId);
                    itm.SubItems.Add(dt.TestSub.TestMainID);
                    lvTestList.Items.Add(itm);
                }
            }   
        }

        private void SearchListView(IEnumerable<TestFee> tests,string searchString="")
        {
            IEnumerable<TestFee> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {               
                query = (from test in tests
                         where test.TestSub.TestSubTitle.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);
            
            }
            lvTestList.Items.Clear();
            foreach (TestFee dt in query)
            {
                ListViewItem itm = new ListViewItem(dt.TestSub.TestSubID);
                itm.SubItems.Add(dt.TestSub.TestSubTitle.ToString());
                itm.SubItems.Add(dt.TestSub.TestDepartment.DepartmentID);
                itm.SubItems.Add(dt.TestSub.TestGroup.GroupId);
                itm.SubItems.Add(dt.TestSub.TestMainID);
                lvTestList.Items.Add(itm);
            }  
        
        }
        private void LoadAssociatedTestList(string Panel)
        {
            if (cboPanel.SelectedValue != "")
            {
                lvAssociatedList.Items.Clear();
                List<TestFee> det = dmsSC.GetPanelTests(cboPanel.SelectedValue.ToString()).ToList();
                foreach (TestFee dt in det)
                {
                    ListViewItem itm = new ListViewItem(dt.TestSub.TestSubID);
                    itm.SubItems.Add(dt.TestSub.TestSubTitle.ToString());
                    itm.SubItems.Add(dt.TestSub.TestDepartment.DepartmentID);
                    itm.SubItems.Add(dt.TestSub.TestGroup.GroupId);
                    itm.SubItems.Add(dt.TestSub.TestMainID);
                    lvAssociatedList.Items.Add(itm);
                }
            }
        }
        private void RefreshGrid()
        {
            LoadTestList();
        }
        private void frmPanelTestAssociation_Load(object sender, EventArgs e)
        {
            try
            {
                cboPanel.DisplayMember = "PanelTitle";
                cboPanel.ValueMember = "PanelID";
                cboPanel.DataSource = dmsSC.GetPanelSetup().ToList();
                FormatTestList();
                FormatAssociatedList();
                RefreshGrid();
                if (Panel != null)
                {
                    cboPanel.SelectedValue = Panel;
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

        private TestSub PopulatePanelTests()
        {
            string string1 = "";
            TestSub oTestSub = new TestSub();
            oTestSub.PanelID = cboPanel.SelectedValue.ToString();
            for (int i = 0; i < lvAssociatedList.Items.Count; i++)
            {
                oTestSub.TestSubID = lvAssociatedList.Items[i].SubItems[0].Text;
                Department dept = new Department();
                dept.DepartmentID = lvAssociatedList.Items[i].SubItems[2].Text;
                oTestSub.TestDepartment = dept;
                oTestSub.TestMainID = lvAssociatedList.Items[i].SubItems[4].Text;

                TestGroup tg = new TestGroup();
                tg.GroupId = lvAssociatedList.Items[i].SubItems[3].Text;
                oTestSub.TestGroup = tg;
                oTestSub.PanelID = cboPanel.SelectedValue.ToString();
                string1 += lvAssociatedList.Items[i].SubItems[0].Text + ":" + lvAssociatedList.Items[i].SubItems[2].Text + ":" + lvAssociatedList.Items[i].SubItems[3].Text + ":" + lvAssociatedList.Items[i].SubItems[4].Text + ";";
                oTestSub.AllTest = string1;
            }
                EntryParameter ep = new EntryParameter();
                ep.CompanyID = Utility.CompanyID;
                ep.EntryBy = Utility.UserId;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                oTestSub.EParameter = ep;
            //}
            //oTestSub.AllTest = string1;
            return oTestSub;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                
                TestSub oTests = this.PopulatePanelTests();
                short i = dmsSC.InsertPanelTests(oTests);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CheckSave = 0;
                    lvAssociatedList.Items.Clear();
                    btnShow_Click(sender, e);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lvTestList.Items.Count; i++)
                {
                    if (lvTestList.Items[i].Checked == true)
                    {
                        ListViewItem itm = new ListViewItem(lvTestList.Items[i].SubItems[0].Text);
                        itm.SubItems.Add(lvTestList.Items[i].SubItems[1].Text);
                        itm.SubItems.Add(lvTestList.Items[i].SubItems[2].Text);
                        itm.SubItems.Add(lvTestList.Items[i].SubItems[3].Text);
                        itm.SubItems.Add(lvTestList.Items[i].SubItems[4].Text);
                        lvAssociatedList.Items.Add(itm);
                        CheckSave = 1;
                    }
                }
                while (lvTestList.CheckedItems.Count > 0)
                {
                    ListViewItem item = lvTestList.CheckedItems[0];
                    lvTestList.Items.Remove(item);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lvAssociatedList.Items.Count; i++)
                {
                    if (lvAssociatedList.Items[i].Checked == true)
                    {
                        ListViewItem itm = new ListViewItem(lvAssociatedList.Items[i].SubItems[0].Text);
                        itm.SubItems.Add(lvAssociatedList.Items[i].SubItems[1].Text);
                        itm.SubItems.Add(lvAssociatedList.Items[i].SubItems[2].Text);
                        itm.SubItems.Add(lvAssociatedList.Items[i].SubItems[3].Text);
                        itm.SubItems.Add(lvAssociatedList.Items[i].SubItems[4].Text);
                        lvTestList.Items.Add(itm);
                        CheckSave = 1;
                    }
                }
                while (lvAssociatedList.CheckedItems.Count > 0)
                {
                    ListViewItem item = lvAssociatedList.CheckedItems[0];
                    lvAssociatedList.Items.Remove(item);
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

        private void cboPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
            btnShow_Click(sender, e);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAssociatedTestList(cboPanel.SelectedValue.ToString());
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

        private void btnClose_Click(object sender, EventArgs e)
        {                    
        }

        private void btnNewClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckSave == 1)
                {
                    DialogResult msg = MessageBox.Show("File is not Saved,Do You want to Save Now???", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        btnSave.PerformClick();
                        this.Dispose();
                    }
                    if (msg == DialogResult.No)
                    {
                        this.Dispose();
                    }
                }
                if (CheckSave == 0)
                {
                    this.Dispose();
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

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(det, txtSearch.Text);
        }

        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            frmPanelSetup oPanel = new frmPanelSetup();
            oPanel.ShowDialog();
        }

        private void btnRefreshPanel_Click(object sender, EventArgs e)
        {
            cboPanel.DisplayMember = "PanelTitle";
            cboPanel.ValueMember = "PanelID";
            cboPanel.DataSource = dmsSC.GetPanelSetup().ToList();
        }

        private void txtPanel_TextChanged(object sender, EventArgs e)
        {
            cboPanel.SelectedIndex = cboPanel.FindString(txtPanel.Text);
        }
    }
}
