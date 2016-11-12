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
    public partial class frmDiagnosticDetailSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public string Department { set; get; }
        public string Group { set; get; }
        public string Main { set; get; }
        private List<TestSub> det;
        public frmDiagnosticDetailSetup()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboSection", "cboReportGroup", "cbocategoryID", "cboRoom", "txtTestDetailTitle", "txtTestDetailTitleBeng", "txtShortCode", "txtTestDetailTitleAlias", "cboMethod", "cboSpecimen", "cboSpcContainer", "cboSpecCollRoom", "txtSpcQty" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                TestSub tspobj = this.PopulateTestDetail();
                if (Utility.IsDuplicateFoundInList(lvDiagDet, 1, txtTestDetailTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Test Name!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTestDetailTitle.Focus();
                    return;
                }
                if (chkDays.Checked==false && chkHours.Checked==false)
                {
                    MessageBox.Show("Please Select The Report Delivery Time!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }             
                else
                {
                    short i = dmsSC.SaveTestDetail(tspobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString());
                        DialogResult msg = MessageBox.Show("Fee is not Assigned for this Test,Do You want to Assign Now???", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (msg == DialogResult.Yes)
                        {
                               frmDiagnosticFeeSetup oDiagFee = new frmDiagnosticFeeSetup();                        
                                oDiagFee.DepartmentID = cboDeptID.SelectedValue.ToString();
                                oDiagFee.GroupID = cboGroupID.SelectedValue.ToString();
                                oDiagFee.MainID = cboMainID.SelectedValue.ToString();
                                oDiagFee.ShowDialog();
                        }
                        if (msg == DialogResult.No)
                        {
                            return;
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

      
        private TestSub PopulateTestDetail()
        {
            TestSub tspObj = new TestSub();

            tspObj.TestSubID = txtTestDetailID.Text;
            tspObj.TestSubTitle = txtTestDetailTitle.Text;
            tspObj.TestSubTitleBeng = txtTestDetailTitleBeng.Text;
            tspObj.TestSubTitleAlias = txtTestDetailTitleAlias.Text;
            tspObj.ShortCode = txtShortCode.Text;
            
            TestGroup tg = new TestGroup();
            tg.GroupId = cboGroupID.SelectedValue.ToString();
            tspObj.TestGroup = tg;
            Department dept = new Department();
            dept.DepartmentID = cboDeptID.SelectedValue.ToString();
            tspObj.TestDepartment = dept; 
            tspObj.TestMainID = cboMainID.SelectedValue.ToString();

            ReportSection oRptSec = new ReportSection();
            oRptSec.ReportSectionID = cboSection.SelectedValue.ToString();
            tspObj.ReportSection = oRptSec;

            ReportGroup rgObj = new ReportGroup();
            rgObj.ReportGroupID = cboReportGroup.SelectedValue.ToString();
            tspObj.ReportGroup = rgObj;
          
            TestCategory tcatobj = new TestCategory();
            tcatobj.TestCategoryID = cbocategoryID.SelectedValue.ToString();
            tspObj.TestCategory = tcatobj;

            TestMethod oMet = new TestMethod();
            oMet.MethodID = cboMethod.SelectedValue.ToString();
            tspObj.TestMethod = oMet;

            Specimen oSpc = new Specimen();
            oSpc.SpecimenID = cboSpecimen.SelectedValue.ToString();
            tspObj.Specimen = oSpc;

            SpecimenCollectionRoom oSpcRoom = new SpecimenCollectionRoom();
            oSpcRoom.RoomID = cboSpecCollRoom.SelectedValue.ToString();
            tspObj.SpecimenCollectionRoom = oSpcRoom;

            SpecimenHolder oSpHol = new SpecimenHolder();
            oSpHol.HolderID = cboSpcContainer.SelectedValue.ToString();
            oSpHol.HolderQuantity = txtSpcQty.Text.ToString();
            tspObj.SpecimenHolder = oSpHol;
         
            LabRoom trm = new LabRoom();
            trm.RoomID = cboRoom.SelectedValue.ToString();
            tspObj.LabRoom = trm;

            if (chkPanel.Checked == true)
            {
                tspObj.PanelID = cboPanel.SelectedValue.ToString();
            }
            if (chkPanel.Checked == false)
            {
                tspObj.PanelID = "0";
            }
            if (chkDays.Checked == true)
            {
                tspObj.DeliveryAfter = short.Parse(cboDelAfterDays.Text);
                tspObj.DeliveryAfterHours = 0;
            }          
            if (chkHours.Checked == true)
            {
                tspObj.DeliveryAfter = 0;
                tspObj.DeliveryAfterHours = short.Parse(cboDelAfterHours.Text);
            }
            tspObj.PosSerial = txtPosSerial.Text.ToString();
          
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            if (chkActive.Checked == true)
            {
                ep.Active = "1";
            }
            if (chkActive.Checked == false)
            {
                ep.Active = "0";
            }
            tspObj.EParameter = ep;

            return tspObj;
        }
        private void frmDiagnosticDetailSetup_Load(object sender, EventArgs e)
        {
            try
            {
                List<short> listItems = dmsSC.GetNumbers(0, 31).ToList();
                cboDelAfterDays.DataSource = listItems;

                cboDeptID.DisplayMember = "Value";
                cboDeptID.ValueMember = "Key";
                cboDeptID.DataSource = new BindingSource(dmsSC.GetDepartments("D"), null);

                //cboReportGroup.DisplayMember = "Value";
                //cboReportGroup.ValueMember = "Key";
                //cboReportGroup.DataSource = new BindingSource(dmsSC.GetRptgrpDict("D"), null);

                cboSpecimen.DisplayMember = "Value";
                cboSpecimen.ValueMember = "Key";
                cboSpecimen.DataSource = new BindingSource(dmsSC.GetSpecDict("D"), null);

                cbocategoryID.DisplayMember = "Value";
                cbocategoryID.ValueMember = "Key";
                cbocategoryID.DataSource = new BindingSource(dmsSC.GetCategoryDict("D"), null);

                cboRoom.DisplayMember = "Value";
                cboRoom.ValueMember = "Key";
                cboRoom.DataSource = new BindingSource(dmsSC.GetRoomsDict("D"), null);

                cboSpecCollRoom.DisplayMember = "Value";
                cboSpecCollRoom.ValueMember = "Key";
                cboSpecCollRoom.DataSource = new BindingSource(dmsSC.GetRoomsDict("D"), null);

                cboPanel.DisplayMember = "PanelTitle";
                cboPanel.ValueMember = "PanelID";
                cboPanel.DataSource = dmsSC.GetPanelSetup().ToList();

                cboSpcContainer.DisplayMember = "Value";
                cboSpcContainer.ValueMember = "Key";
                cboSpcContainer.DataSource = new BindingSource(dmsSC.GetSpecHolderDict("D"), null);

                cboMethod.DisplayMember = "Value";
                cboMethod.ValueMember = "Key";
                cboMethod.DataSource = new BindingSource(dmsSC.GetMethod("D"), null);

                cboDelAfterHours.DisplayMember = "Value";
                cboDelAfterHours.ValueMember = "Key";
                cboDelAfterHours.DataSource = new BindingSource(Utility.GetNumbers(1, 24), null);

                if (Department != null)
                {
                    cboDeptID.SelectedValue = Department;
                    if (Group != null)
                    {
                        cboGroupID.SelectedValue = Group;
                        if (Main != null)
                        {
                            cboMainID.SelectedValue = Main;
                            btnShow_Click(sender, e);
                        }
                    }
                }

                FormatGrid();
                cboDeptID.Select();
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
        private void RefreshGrid(string deptid, string group, string main)
        {
            LoadListView(deptid, group, main);
        }
        private void FormatGrid()
        {
            lvDiagDet.CheckBoxes = false;
            lvDiagDet.Columns.Add("Test ID", 100, HorizontalAlignment.Center);
            lvDiagDet.Columns.Add("Test Name", 400, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Test Name(Bangla)", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Dept ID", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Grp ID", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Main ID", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Rpt Sec", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Rpt Grp", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Cat", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Lab Room", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Delivery After", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Panel", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Short Code", 250, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Alias Name", 250, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Delivery After Hours", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Specimen ID", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Specimen Title", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Specimen Coll Room ID", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Specimen Coll Room Tilte", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Specimen Holder ID", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Specimen Holder Title", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Container Quantity", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Test Method ID", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Test Method Title", 0, HorizontalAlignment.Left);
            lvDiagDet.Columns.Add("Pos Serial", 100, HorizontalAlignment.Center);
            lvDiagDet.Columns.Add("Active", 55, HorizontalAlignment.Center);
        } 
        private void LoadListView(string deptid, string group, string main)
        {
            lvDiagDet.Items.Clear();           
            if (deptid.Length != 0 || group.Length != 0 || main.Length != 0)
            {
                det = dmsSC.GetTestForDetailsSetup("A",deptid, group, main).ToList<TestSub>();
            }
            else
            {
                return;
            }
            foreach (TestSub dt in det)
            {
                ListViewItem itm = new ListViewItem(dt.TestSubID);
                itm.SubItems.Add(dt.TestSubTitle.ToString());
                itm.SubItems.Add(dt.TestSubTitleBeng.ToString());
                itm.SubItems.Add(dt.TestDepartment.DepartmentID);
                itm.SubItems.Add(dt.TestGroup.GroupId);
                itm.SubItems.Add(dt.TestMainID);
                itm.SubItems.Add(dt.ReportSection.ReportSectionID);
                itm.SubItems.Add(dt.ReportGroup.ReportGroupID);
                itm.SubItems.Add(dt.TestCategory.TestCategoryID);
                itm.SubItems.Add(dt.LabRoom.RoomID);
                itm.SubItems.Add(dt.DeliveryAfter.ToString());              
                itm.SubItems.Add(dt.PanelID);
                itm.SubItems.Add(dt.ShortCode);
                itm.SubItems.Add(dt.TestSubTitleAlias);
                itm.SubItems.Add(dt.DeliveryAfterHours.ToString());
                itm.SubItems.Add(dt.Specimen.SpecimenID);
                itm.SubItems.Add(dt.Specimen.SpecimenTitle);
                itm.SubItems.Add(dt.SpecimenCollectionRoom.RoomID);
                itm.SubItems.Add(dt.SpecimenCollectionRoom.RoomTitle);
                itm.SubItems.Add(dt.SpecimenHolder.HolderID);
                itm.SubItems.Add(dt.SpecimenHolder.HolderTitle);
                itm.SubItems.Add(dt.SpecimenHolder.HolderQuantity);
                itm.SubItems.Add(dt.TestMethod.MethodID);
                itm.SubItems.Add(dt.TestMethod.MethodTitle);
                itm.SubItems.Add(dt.PosSerial.ToString());
                itm.SubItems.Add(dt.EParameter.Active.ToString()); 
                lvDiagDet.Items.Add(itm);
            }
        }

        private void LoadListViewDetails(string deptid, string group, string main,string ReportSection,string ReportGroup)
        {
            lvDiagDet.Items.Clear();
            if (deptid.Length != 0 || group.Length != 0 || main.Length != 0 || ReportSection.Length != 0 || ReportGroup.Length != 0)
            {
                det = dmsSC.GetTestNameDetails(deptid, group, main, ReportSection, ReportGroup).ToList<TestSub>();
            }
            else
            {
                return;
            }
            foreach (TestSub dt in det)
            {
                ListViewItem itm = new ListViewItem(dt.TestSubID);
                itm.SubItems.Add(dt.TestSubTitle.ToString());
                itm.SubItems.Add(dt.TestSubTitleBeng.ToString());
                itm.SubItems.Add(dt.TestDepartment.DepartmentID);
                itm.SubItems.Add(dt.TestGroup.GroupId);
                itm.SubItems.Add(dt.TestMainID);
                itm.SubItems.Add(dt.ReportSection.ReportSectionID);
                itm.SubItems.Add(dt.ReportGroup.ReportGroupID);
                itm.SubItems.Add(dt.TestCategory.TestCategoryID);
                itm.SubItems.Add(dt.LabRoom.RoomID);
                itm.SubItems.Add(dt.DeliveryAfter.ToString());
                itm.SubItems.Add(dt.PanelID);
                itm.SubItems.Add(dt.ShortCode);
                itm.SubItems.Add(dt.TestSubTitleAlias);
                itm.SubItems.Add(dt.DeliveryAfterHours.ToString());
                itm.SubItems.Add(dt.Specimen.SpecimenID);
                itm.SubItems.Add(dt.Specimen.SpecimenTitle);
                itm.SubItems.Add(dt.SpecimenCollectionRoom.RoomID);
                itm.SubItems.Add(dt.SpecimenCollectionRoom.RoomTitle);
                itm.SubItems.Add(dt.SpecimenHolder.HolderID);
                itm.SubItems.Add(dt.SpecimenHolder.HolderTitle);
                itm.SubItems.Add(dt.SpecimenHolder.HolderQuantity);
                itm.SubItems.Add(dt.TestMethod.MethodID);
                itm.SubItems.Add(dt.TestMethod.MethodTitle);
                itm.SubItems.Add(dt.PosSerial.ToString());
                itm.SubItems.Add(dt.EParameter.Active.ToString());
                lvDiagDet.Items.Add(itm);
            }
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
                cboSection.DisplayMember = "Value";
                cboSection.ValueMember = "Key";
                cboSection.DataSource = new BindingSource(dmsSC.GetRptSecSetup(cboDeptID.SelectedValue.ToString()), null);
            }          
        }
        private void lvDiagDet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDiagDet.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDiagDet.SelectedItems[0];
                txtTestDetailID.Text = itm.SubItems[0].Text;
                txtTestDetailTitle.Text = itm.SubItems[1].Text;
                txtTestDetailTitleBeng.Text = itm.SubItems[2].Text;
                cboDeptID.SelectedValue = itm.SubItems[3].Text;
                cboGroupID.SelectedValue = itm.SubItems[4].Text;
                cboMainID.SelectedValue = itm.SubItems[5].Text;
                cboSection.SelectedValue = itm.SubItems[6].Text;
                cboReportGroup.SelectedValue = itm.SubItems[7].Text;
                cbocategoryID.SelectedValue = itm.SubItems[8].Text;
                cboRoom.SelectedValue = itm.SubItems[9].Text;
                cboDelAfterDays.Text = itm.SubItems[10].Text;            
                cboPanel.SelectedValue=itm.SubItems[11].Text.ToString();
                txtShortCode.Text = itm.SubItems[12].Text.ToString();
                txtTestDetailTitleAlias.Text = itm.SubItems[13].Text.ToString();
                cboDelAfterHours.Text = itm.SubItems[14].Text.ToString();
                cboSpecimen.SelectedValue = itm.SubItems[15].Text.ToString();
                cboSpecCollRoom.SelectedValue = itm.SubItems[17].Text.ToString();
                cboSpcContainer.SelectedValue = itm.SubItems[19].Text.ToString();
                txtSpcQty.Text = itm.SubItems[21].Text.ToString();
                cboMethod.SelectedValue = itm.SubItems[22].Text.ToString();
                txtPosSerial.Text = itm.SubItems[24].Text.ToString();
                if (itm.SubItems[25].Text == "1")
                {
                    chkActive.Checked = true;
                }
                if (itm.SubItems[25].Text == "0")
                {
                    chkActive.Checked = false;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboSection", "cboReportGroup", "cbocategoryID", "cboRoom", "txtTestDetailTitle", "txtTestDetailTitleBeng", "txtShortCode", "txtTestDetailTitleAlias", "cboMethod", "cboSpecimen", "cboSpcContainer", "cboSpecCollRoom", "txtSpcQty" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSC.VerifyTestDetail(txtTestDetailID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTestDetailID.Select();
                //btnNew.PerformClick();
                return;
            }        
            try
            {
                TestSub tspobj = this.PopulateTestDetail();
                if (chkDays.Checked == false && chkHours.Checked == false)
                {
                    MessageBox.Show("Please Select The Report Delivery Time!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                short i = dmsSC.UpdateTestDetail(tspobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString());                
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
            try
            {
                List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                LoadListView(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString());
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
        private void lvDiagDet_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;           
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            lvDiagDet.Items.Clear();
        }
        private void chkPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPanel.Checked == true)
            {
                cboPanel.Enabled = true;
                lblPanel.Enabled = true;
            }
            if (chkPanel.Checked == false)
            {
                cboPanel.Enabled = false;
                lblPanel.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPanelTestAssociation ofrm = new frmPanelTestAssociation();
            if (cboPanel.SelectedValue !=null)
            {
                ofrm.Panel = cboPanel.SelectedValue.ToString();
            }
            ofrm.ShowDialog();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboPanel.DisplayMember = "PanelTitle";
            cboPanel.ValueMember = "PanelID";
            cboPanel.DataSource = dmsSC.GetPanelSetup().ToList();
        }
        private void cbocategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbocategoryID.Text=="Panel")
            {
                chkPanel.Checked = true;
                chkPanel.Enabled = false;
            }
            else
            {
                chkPanel.Checked = false;
                chkPanel.Enabled = true;
            }
        }
        private void btnAddGrp_Click(object sender, EventArgs e)
        {
            frmDiagnosticGroupSetup oDiagGrp = new frmDiagnosticGroupSetup();
            if (cboDeptID.SelectedValue != "")
            {
                oDiagGrp.DepartmentId = cboDeptID.SelectedValue.ToString();
            }
            oDiagGrp.ShowDialog();
        }
        private void btnRefreshGrp_Click(object sender, EventArgs e)
        {
            if (cboDeptID.SelectedValue != "")
            {
                cboGroupID.DisplayMember = "Value";
                cboGroupID.ValueMember = "Key";
                cboGroupID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetDiagnGrpDeptWise("D", cboDeptID.SelectedValue.ToString())), null);              
            }
        }
        private void btnAddMain_Click(object sender, EventArgs e)
        {
            frmDiagnosticMainSetup oDiagMain = new frmDiagnosticMainSetup();
            if (cboDeptID.SelectedValue != "" && cboGroupID.SelectedValue != null)
            {
                oDiagMain.DepartmentID = cboDeptID.SelectedValue.ToString();
                oDiagMain.GroupID = cboGroupID.SelectedValue.ToString();
            }
                oDiagMain.ShowDialog();
        }

        private void btnRefreshMain_Click(object sender, EventArgs e)
        {
            if (cboDeptID.SelectedValue != "" && cboGroupID.SelectedValue != "")
            {
                cboMainID.DisplayMember = "Value";
                cboMainID.ValueMember = "Key";
                cboMainID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetMainDeptwise("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString())), null);
            }
        }

        private void cboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroupID.SelectedValue != "")
            {
                cboMainID.DisplayMember = "Value";
                cboMainID.ValueMember = "Key";
                cboMainID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetMainDeptwise("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString())), null);
            }
        }
        private void btnSpecimenAdd_Click(object sender, EventArgs e)
        {
            frmSpecimenSetup oSpc = new frmSpecimenSetup();
            oSpc.ShowDialog();
        }

        private void btnSpecimenRefresh_Click(object sender, EventArgs e)
        {
            cboSpecimen.DisplayMember = "Value";
            cboSpecimen.ValueMember = "Key";
            cboSpecimen.DataSource = new BindingSource(dmsSC.GetSpecDict("D"), null);
        }

        private void btnContainerAdd_Click(object sender, EventArgs e)
        {
            frmSpecimenHolder oSpHol = new frmSpecimenHolder();
            oSpHol.ShowDialog();
        }

        private void btnContainerRefresh_Click(object sender, EventArgs e)
        {
            cboSpcContainer.DisplayMember = "Value";
            cboSpcContainer.ValueMember = "Key";
            cboSpcContainer.DataSource = new BindingSource(dmsSC.GetSpecHolderDict("D"), null);
        }     
        private void AddRowsToSpecimenCollection(DataGridView dtv, string[] row)
        {
            DataGridViewRow rw = new DataGridViewRow();
            dtv.Rows.Insert(0, row);       
        }    
        private void chkDays_CheckedChanged(object sender, EventArgs e)
        {
            //if(chkDays.Checked==true)
            //{
            //    cboDelAfterDays.Enabled = true;
            //    cboDelAfterHours.Enabled = false;
            //    chkHours.Checked = false;
            //}
            //if (chkDays.Checked == false)
            //{
            //    cboDelAfterDays.Enabled = false;
            //    cboDelAfterHours.Enabled = false;
            //}
        }

        private void chkHours_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkHours.Checked == true)
            //{
            //    cboDelAfterDays.Enabled = false;
            //    cboDelAfterHours.Enabled = true;
            //    chkDays.Checked = false;
            //}
            //if (chkHours.Checked == false)
            //{
            //    cboDelAfterDays.Enabled = false;
            //    cboDelAfterHours.Enabled = false;
            //}
        }  
        private void lnkAddTestFee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDiagnosticFeeSetup oDiagFee = new frmDiagnosticFeeSetup();
            oDiagFee.ShowDialog();
        }

        private void btnAddMethod_Click(object sender, EventArgs e)
        {
            frmMethodSetup oMeth = new frmMethodSetup();
            oMeth.ShowDialog();
        }

        private void btnRefreshMethod_Click(object sender, EventArgs e)
        {
            cboMethod.DisplayMember = "Value";
            cboMethod.ValueMember = "Key";
            cboMethod.DataSource = new BindingSource(dmsSC.GetMethod("D"), null);
        }
        private void SearchListView(IEnumerable<TestSub> oResults, string searchString = "")
        {
            try
            {
                IEnumerable<TestSub> query;
                if (oResults != null)
                {
                    if (!(searchString.Length > 0))
                    {
                        query = oResults;
                    }
                    else
                    {
                        query = (from oRes in oResults
                                 where oRes.TestSubTitle.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                                 select oRes);
                    }
                    lvDiagDet.Items.Clear();
                    foreach (TestSub dt in query)
                    {
                        ListViewItem itm = new ListViewItem(dt.TestSubID);
                        itm.SubItems.Add(dt.TestSubTitle.ToString());
                        itm.SubItems.Add(dt.TestSubTitleBeng.ToString());
                        itm.SubItems.Add(dt.TestDepartment.DepartmentID);
                        itm.SubItems.Add(dt.TestGroup.GroupId);
                        itm.SubItems.Add(dt.TestMainID);
                        itm.SubItems.Add(dt.ReportSection.ReportSectionID);
                        itm.SubItems.Add(dt.ReportGroup.ReportGroupID);
                        itm.SubItems.Add(dt.TestCategory.TestCategoryID);
                        itm.SubItems.Add(dt.LabRoom.RoomID);
                        itm.SubItems.Add(dt.DeliveryAfter.ToString());
                        itm.SubItems.Add(dt.PanelID);
                        itm.SubItems.Add(dt.ShortCode);
                        itm.SubItems.Add(dt.TestSubTitleAlias);
                        itm.SubItems.Add(dt.DeliveryAfterHours.ToString());
                        itm.SubItems.Add(dt.Specimen.SpecimenID);
                        itm.SubItems.Add(dt.Specimen.SpecimenTitle);
                        itm.SubItems.Add(dt.SpecimenCollectionRoom.RoomID);
                        itm.SubItems.Add(dt.SpecimenCollectionRoom.RoomTitle);
                        itm.SubItems.Add(dt.SpecimenHolder.HolderID);
                        itm.SubItems.Add(dt.SpecimenHolder.HolderTitle);
                        itm.SubItems.Add(dt.SpecimenHolder.HolderQuantity);
                        itm.SubItems.Add(dt.TestMethod.MethodID);
                        itm.SubItems.Add(dt.TestMethod.MethodTitle);
                        itm.SubItems.Add(dt.PosSerial.ToString());
                        itm.SubItems.Add(dt.EParameter.Active.ToString());
                        lvDiagDet.Items.Add(itm);
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

        private void txtTestDetailTitle_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(det, txtTestDetailTitle.Text);
        }

        private void cboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSection.SelectedValue != "")
            {
                cboReportGroup.DisplayMember = "Value";
                cboReportGroup.ValueMember = "Key";
                cboReportGroup.DataSource = new BindingSource(dmsSC.GetRptgrpDic(cboSection.SelectedValue.ToString()), null);
            }
        }

        private void txtTestDetailTitle_TextChanged(object sender, EventArgs e)
        {
            txtTestDetailTitleBeng.Text = txtTestDetailTitle.Text;
        }

        private void btnNewShow_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboSection", "cboReportGroup" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                LoadListViewDetails(cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString(), cboSection.SelectedValue.ToString(), cboReportGroup.SelectedValue.ToString());
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
