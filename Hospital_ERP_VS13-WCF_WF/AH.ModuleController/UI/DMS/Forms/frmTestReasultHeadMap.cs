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
    public partial class frmTestReasultHeadMap : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        private List<ResultHead> rshd;
        public frmTestReasultHeadMap()
        {
            InitializeComponent();
        }

        private void frmTestReasultHeadMap_Load(object sender, EventArgs e)
        {
            cboDeptID.DisplayMember = "Value";
            cboDeptID.ValueMember = "Key";
            cboDeptID.DataSource = new BindingSource(dmsSC.GetDepartments("D"), null);

            FormatGrid();
            FormatAssociatedGrid();
        }

        private void cboDeptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeptID.SelectedValue != "")
            {
                cboGroupID.DisplayMember = "Value";
                cboGroupID.ValueMember = "Key";
                cboGroupID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetDiagnGrpDeptWise("D", cboDeptID.SelectedValue.ToString())), null);
                if (cboGroupID.SelectedValue != null)
                {
                    cboMainID.DisplayMember = "Value";
                    cboMainID.ValueMember = "Key";
                    cboMainID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetMainDeptwise("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString())), null);
                }
            }
        }

        private void cboMainID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMainID.SelectedValue != null)
            {
                cboTestDet.DisplayMember = "Value";
                cboTestDet.ValueMember = "Key";
                cboTestDet.DataSource = new BindingSource(dmsSC.GetTestDetailDict("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString()), null);
            }
        }
        private void FormatGrid()
        {
            lvResultHead.Columns.Add("ID", 140, HorizontalAlignment.Left);           
            lvResultHead.Columns.Add("Head Name", 340, HorizontalAlignment.Left);
        }
        private void FormatAssociatedGrid()
        {
            lvAssociatedResultHead.Columns.Add("ID", 120, HorizontalAlignment.Left);
            lvAssociatedResultHead.Columns.Add("Head Name", 200, HorizontalAlignment.Left);
            lvAssociatedResultHead.Columns.Add("Head Group ID", 0, HorizontalAlignment.Left);
            lvAssociatedResultHead.Columns.Add("Head Group Name", 200, HorizontalAlignment.Left);
            lvAssociatedResultHead.Columns.Add("HD Grp Serial", 100, HorizontalAlignment.Left);
            lvAssociatedResultHead.Columns.Add("Serial", 100, HorizontalAlignment.Left);
        }
        private void LoadListView(string Section, string Group)
        {
            lvResultHead.Items.Clear();
            List<ResultHead> rshd = dmsSC.GetResultHdBySecGrp(Section, Group).ToList();
            foreach (ResultHead rsh in rshd)
            {
                ListViewItem itm = new ListViewItem(rsh.ResultHeadID);
                itm.SubItems.Add(rsh.ResultHeadTitle);
                lvResultHead.Items.Add(itm);
            }
        }
        private void LoadAssociatedListView(string TestDetail)
        {
            lvAssociatedResultHead.Items.Clear();
            List<ResultHead> rshd = dmsSC.GetResultHdMap(cboTestDet.SelectedValue.ToString()).ToList();
            foreach (ResultHead rsh in rshd)
            {
                ListViewItem itm = new ListViewItem(rsh.ResultHeadID);
                itm.SubItems.Add(rsh.ResultHeadTitle);
                itm.SubItems.Add(rsh.ResultGroup.ResultHeadGroupID);
                itm.SubItems.Add(rsh.ResultGroup.ResultHeadGroupTitle);
                itm.SubItems.Add(rsh.HdGrpSerial.ToString());
                itm.SubItems.Add(rsh.Serial.ToString());
                lvAssociatedResultHead.Items.Add(itm);
            }
        }
        private void RefreshResultHead(string TestDetail,string ReportGroup)
        {
            lvResultHead.Items.Clear();
            rshd = dmsSC.GetResultHdForMap(cboTestDet.SelectedValue.ToString(), txtRptGrpID.Text.ToString()).ToList();
            foreach (ResultHead rsh in rshd)
            {
                ListViewItem itm = new ListViewItem(rsh.ResultHeadID);
                itm.SubItems.Add(rsh.ResultHeadTitle);
                lvResultHead.Items.Add(itm);
            }
        }

        private Boolean checkDuplicate(string strRight)
        {
            for (int i = 0; i < lvAssociatedResultHead.Items.Count; i++)
            {
                string strDuplicate = lvAssociatedResultHead.Items[i].SubItems[1].Text.ToString() + lvAssociatedResultHead.Items[i].SubItems[3].Text.ToString();
                if (strRight == strDuplicate)
                {
                    MessageBox.Show("Cannot Move Duplicate Result Head For Same Result Head Group!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvResultHead.Items.Count; i++)
            {
                if (lvResultHead.Items[i].Checked == true)
                {                   
                    ListViewItem itm = new ListViewItem(lvResultHead.Items[i].SubItems[0].Text);
                    itm.SubItems.Add(lvResultHead.Items[i].SubItems[1].Text);
                    itm.SubItems.Add(cboHeadGroupID.SelectedValue.ToString());
                    itm.SubItems.Add(cboHeadGroupID.Text.ToString());
                    string strRitem = lvResultHead.Items[i].SubItems[1].Text.ToString() + cboHeadGroupID.Text.ToString();
                    if (checkDuplicate(strRitem))
                    {
                        return;
                    }
                    lvAssociatedResultHead.Items.Add(itm);
                    lvResultHead.Items[i].Checked = false;
                }
            }         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvAssociatedResultHead.Items.Count; i++)
            {
                if (lvAssociatedResultHead.Items[i].Checked == true)
                {
                    while (lvAssociatedResultHead.CheckedItems.Count > 0)
                    {
                        ListViewItem item = lvAssociatedResultHead.CheckedItems[0];
                        lvAssociatedResultHead.Items.Remove(item);                       
                    }
                    btnSave_Click(sender, e);                
                }
            }        
        }

         private ResultHead PopulateResHd()
            {
                string string1 = "";
                ResultHead reshd = new ResultHead();

                TestSub oTest = new TestSub();
                oTest.TestSubID = cboTestDet.SelectedValue.ToString();
                reshd.TestSub = oTest;                         

                ReportGroup rpt = new ReportGroup();
                rpt.ReportGroupID = txtRptGrpID.Text.ToString();
                reshd.ReportGroup = rpt;

                ResultHeadGroup rshdgr = new ResultHeadGroup();
                rshdgr.ResultHeadGroupID = cboHeadGroupID.SelectedValue.ToString();
                reshd.ResultGroup = rshdgr;

                for (int i = 0; i < lvAssociatedResultHead.Items.Count; i++)
                {
                    string1 += lvAssociatedResultHead.Items[i].SubItems[0].Text + ":" + lvAssociatedResultHead.Items[i].SubItems[2].Text + ":" + ";";
                }
                reshd.MachineString = string1;

                EntryParameter ep = new EntryParameter();
                ep.CompanyID = Utility.CompanyID;
                ep.EntryBy = Utility.UserId;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                reshd.EntryParameter = ep;
              
                return reshd;

        }

         private void btnSave_Click(object sender, EventArgs e)
         {
             List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboTestDet", "cboSection", "cboRptGroup"};
             Control control = Utility.ReqFieldValidator(this, vf);
             if (control != null)
             {
                 MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 control.Focus();
                 return;
             }
             try
             {

                 ResultHead reshd = this.PopulateResHd();
                 short i = dmsSC.SaveResultHeadMapping(reshd);
                 if (i == 0)
                 {
                     MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 else if (i > 0)
                 {
                     MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                     lvAssociatedResultHead.Items.Clear();
                     this.btnShow_Click(sender, e);
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

         private void btnShow_Click(object sender, EventArgs e)
         {
             lvResultHead.Items.Clear();
             if (cboTestDet.SelectedValue != null)
             {
                 LoadReportGrpWithHead(cboTestDet.SelectedValue.ToString());

                 List<ResultHead> rshd = dmsSC.GetHdByGrp(txtRptGrpID.Text.ToString()).ToList();
                 foreach (ResultHead rsh in rshd)
                 {
                     ListViewItem itm = new ListViewItem(rsh.ResultHeadID);
                     itm.SubItems.Add(rsh.ResultHeadTitle);
                     lvResultHead.Items.Add(itm);
                 }
             }
             if (cboTestDet.SelectedValue != null)
             {
                 RefreshResultHead(cboTestDet.SelectedValue.ToString(),txtRptGrpID.Text.ToString());
                 LoadAssociatedListView(cboTestDet.SelectedValue.ToString());
                 LoadResultHeadGroup();
             }
         }
         private void LoadResultHeadGroup()
         {
             cboHeadGroupID.DisplayMember = "Value";
             cboHeadGroupID.ValueMember = "key";
             cboHeadGroupID.DataSource = new BindingSource(dmsSC.GetGrpByDeptSecDic(cboDeptID.SelectedValue.ToString(),txtSecID.Text.ToString()), null);
         }
         private void btnEdit_Click(object sender, EventArgs e)
         {
             List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboTestDet", "cboSection", "cboRptGroup", "cboHeadGroupID" };
             Control control = Utility.ReqFieldValidator(this, vf);
             if (control != null)
             {
                 MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 control.Focus();
                 return;
             }
             try
             {

                 ResultHead reshd = this.PopulateResHd();
                 short i = dmsSC.UpdateResultHeadMapping(reshd);
                 if (i == 0)
                 {
                     MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 else if (i > 0)
                 {
                     MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                     lvAssociatedResultHead.Items.Clear();
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
         private void LoadReportGrpWithHead(string TestDetail)
         {
             if (cboTestDet.SelectedValue != null)
             {
                 List<ResultHead> rshd = new List<ResultHead>();
                 rshd = dmsSC.GetRprGrpByTest(cboTestDet.SelectedValue.ToString()).ToList();
                 foreach (ResultHead rsh in rshd)
                 {
                     txtRptGrpID.Text = rsh.ReportGroup.ReportGroupID;
                     txtRptGrpTitle.Text = rsh.ReportGroup.ReportGroupTitle;
                     txtCatagoryID.Text = rsh.ReportGroup.TestCategory.TestCategoryID;
                     txtCatagory.Text = rsh.ReportGroup.TestCategory.TestCategoryTitle;
                     txtPanelID.Text = rsh.ReportGroup.GroupPanel.PanelID;
                     txtPanelTitle.Text = rsh.ReportGroup.GroupPanel.PanelTitle;
                     txtSecID.Text = rsh.ReportGroup.ReportSection.ReportSectionID;
                     txtReportSection.Text = rsh.ReportGroup.ReportSection.ReportSectionTitle;
                 }
             }
            
         }
         private void btnAddResultHeadGrp_Click(object sender, EventArgs e)
         {
             frmResHeadGroup orehGrp = new frmResHeadGroup();
             if(cboDeptID.SelectedValue !="")
             {
                 orehGrp.DeptID = cboDeptID.SelectedValue.ToString();
                 if(txtSecID.Text!="")
                 {
                     orehGrp.SecID = txtSecID.Text.ToString();
                 }
             }
             orehGrp.ShowDialog();
         }

         private void btnRefreshResultHeadGrp_Click(object sender, EventArgs e)
         {
             LoadResultHeadGroup();
         }

         private void btnAddResultHead_Click(object sender, EventArgs e)
         {
            frmResHead oResh = new frmResHead();
            if(txtSecID.Text !="")
            {
                oResh.SecID = txtSecID.Text.ToString();
                if(txtRptGrpID.Text !="")
                {
                    oResh.GrpID = txtRptGrpID.Text.ToString();
                }
            }
             oResh.ShowDialog();
         }

         private void btnRefreshResultHead_Click(object sender, EventArgs e)
         {
             btnShow_Click(sender, e);
         }

         private void btnAddTestDet_Click(object sender, EventArgs e)
         {
             frmDiagnosticDetailSetup oDet = new frmDiagnosticDetailSetup();
             {
                 if (cboDeptID.SelectedValue != "")
                 {
                     oDet.Department = cboDeptID.SelectedValue.ToString();
                     if(cboGroupID.SelectedValue!="")
                     {
                         oDet.Group = cboGroupID.SelectedValue.ToString();
                         if(cboMainID.SelectedValue!="")
                         {
                             oDet.Main = cboMainID.SelectedValue.ToString();
                         }
                     }
                 }                
             }
             oDet.ShowDialog();
         }    
         private void chkTestList_CheckedChanged(object sender, EventArgs e)
         {
             for (int i = 0; i < lvResultHead.Items.Count; i++)
             {
                 if (chkTestList.Checked == true)
                 {
                     lvResultHead.Items[i].Checked = true;
                 }
                 if (chkTestList.Checked == false)
                 {
                     lvResultHead.Items[i].Checked = false;
                 }
             }
         }

         private void chkAssociatedTestList_CheckedChanged(object sender, EventArgs e)
         {
             for (int i = 0; i < lvAssociatedResultHead.Items.Count; i++)
             {
                 if (chkAssociatedTestList.Checked == true)
                 {
                     lvAssociatedResultHead.Items[i].Checked = true;
                 }
                 if (chkAssociatedTestList.Checked == false)
                 {
                     lvAssociatedResultHead.Items[i].Checked = false;
                 }
             }          
         }

         private void cboTestDet_SelectedIndexChanged(object sender, EventArgs e)
         {
             btnShow_Click(sender, e);
         }

         private void txtSearchResHead_KeyUp(object sender, KeyEventArgs e)
         {
             SearchListView(rshd, txtSearchResHead.Text);
         }
         private void SearchListView(IEnumerable<ResultHead> oResults, string searchString = "")
         {
             IEnumerable<ResultHead> query;
             if (oResults != null)
             {
                 if (!(searchString.Length > 0))
                 {
                     query = oResults;
                 }
                 else
                 {
                     query = (from oRes in oResults
                              where oRes.ResultHeadTitle.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                              select oRes);
                 }
                 lvResultHead.Items.Clear();
                 foreach (ResultHead dt in query)
                 {
                     ListViewItem itm = new ListViewItem(dt.ResultHeadID);
                     itm.SubItems.Add(dt.ResultHeadTitle.ToString());
                     lvResultHead.Items.Add(itm);
                 }
             }

         }

         private void txtSearchTest_TextChanged(object sender, EventArgs e)
         {
             cboTestDet.SelectedIndex = cboTestDet.FindString(txtSearchTest.Text);
         }
        
    }
}
