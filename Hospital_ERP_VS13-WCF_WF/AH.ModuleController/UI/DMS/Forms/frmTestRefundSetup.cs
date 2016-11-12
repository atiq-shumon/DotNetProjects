using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.DMSSR;
using AH.ModuleController.UI.DMS.Reports.Viewer;
using AH.Shared.UI;


namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmTestRefundSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public frmTestRefundSetup()
        {
            InitializeComponent();
        }

        private void cboPatientMr_Click(object sender, EventArgs e)
        {
            try
            {
                if (dmsSC.verifyMrno(txtMRNo.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMRNo.Select();
                    lvMRTests.Items.Clear();
                    btnNew.PerformClick();
                    return;

                }
                InPatient pat = dmsSC.GetCurrentPatient(txtMRNo.Text);
                if (pat.Name == null)
                {
                    MessageBox.Show("No Tests to Refund!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lvMRTests.Items.Clear();
                    btnNew.PerformClick();
                    return;
                }
                else
                {
                    LoadPatient(pat);
                    loadMRTests(txtMRNo.Text);
                    PreviousTestSummary();
                    txtNetAmount.Text = "";
                    txtNetPaid.Text = "";
                    txtReturnAmount.Text = "";
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
        private void LoadPatient(InPatient pat)
        {
            txtPatientName.Text = pat.Name.ToString();
            txtAgeYears.Text = pat.Age.Year.ToString();
            txtAgeMonths.Text = pat.Age.Month.ToString();
            txtAgeDays.Text = pat.Age.Day.ToString();
            txtAgeHours.Text = pat.Age.Hour.ToString();
            txtSex.Text = pat.Sex;
        }
        private void loadMRTests(string mrno)
        {
            try
            {
                lvMRTests.Items.Clear();
                List<TestFee> list = dmsSC.GetDmrTestForRefund(mrno).ToList();
                foreach (TestFee ts in list)
                {
                    ListViewItem itm = new ListViewItem(ts.TestSub.TestSubTitle);//0
                    itm.SubItems.Add(ts.TestSub.TestSubID);//1
                    itm.SubItems.Add(ts.TestSub.TestDepartment.DepartmentID);//2
                    itm.SubItems.Add(ts.TestSub.TestGroup.GroupId);//3
                    itm.SubItems.Add(ts.TestSub.ReportGroup.ReportGroupID);//4
                    itm.SubItems.Add(ts.TestSub.ReportGroup.ReportGroupTitle);//5
                    itm.SubItems.Add(ts.TestSub.PanelID);//6
                    itm.SubItems.Add(ts.TestSub.TestMainID);//7
                    itm.SubItems.Add(ts.TestSub.TestMainTitle);//8
                    itm.SubItems.Add(ts.FeeCategory.FeeCategoryID);//9
                    itm.SubItems.Add(ts.TestSub.Specimen.SpecimenID);//10
                    itm.SubItems.Add(ts.TestSub.LabRoom.RoomID); //11                
                    itm.SubItems.Add(ts.Fee.ToString());//12
                    itm.SubItems.Add(ts.DeptFee.ToString());//13
                    itm.SubItems.Add(ts.RefdFee.ToString());//14
                    itm.SubItems.Add(ts.DoctorFee.ToString());//15
                    itm.SubItems.Add(ts.Discount.ToString());//16
                    itm.SubItems.Add(ts.VAT.ToString());//17
                    itm.SubItems.Add(ts.TestSub.AccCloseFlag.ToString());//18
                    itm.SubItems.Add(ts.TestSub.SpecimenCollectionRoom.RoomID.ToString());//19

                    if (ts.TestSub.AccCloseFlag.ToString() == "0")
                    {
                        itm.ForeColor = Color.Navy;
                    }
                    lvMRTests.Items.Add(itm);
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
        private void FormatListView()
        {
            lvMRTests.Columns.Add("Requested Test", 450, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("test Code", 0, HorizontalAlignment.Left); //7
            lvMRTests.Columns.Add("DepartmentID", 0, HorizontalAlignment.Left); //4
            lvMRTests.Columns.Add("Group ID", 0, HorizontalAlignment.Left); //5
            lvMRTests.Columns.Add("Rpt grp Code", 0, HorizontalAlignment.Left); //3
            lvMRTests.Columns.Add("Report Group", 400, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("PnlCode", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("mainCode", 0, HorizontalAlignment.Left); //6
            lvMRTests.Columns.Add("Main Title", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("Fee Category", 0, HorizontalAlignment.Left); //8
            lvMRTests.Columns.Add("SpecimenID", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("LabRoomID", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("Fee", 0, HorizontalAlignment.Left); //9
            lvMRTests.Columns.Add("DeptFee", 0, HorizontalAlignment.Left); //10
            lvMRTests.Columns.Add("RefdFee", 0, HorizontalAlignment.Left); //11
            lvMRTests.Columns.Add("DoctorFee", 0, HorizontalAlignment.Left); //12
            lvMRTests.Columns.Add("Discount", 0, HorizontalAlignment.Left); //13
            lvMRTests.Columns.Add("vat", 0, HorizontalAlignment.Left); //14
            lvMRTests.Columns.Add("Acc", 0, HorizontalAlignment.Left);
            lvMRTests.Columns.Add("Spc Room ID", 0, HorizontalAlignment.Left); //1
        }

        private void txtMRNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMRNo.Text.Length == Utility.ScanLength)
            {
                cboPatientMr_Click(sender, e);
            }
        }
        private void frmTestRefundSetup_Load(object sender, EventArgs e)
        {
            cboCause.DisplayMember = "Value";
            cboCause.ValueMember = "Key";
            cboCause.DataSource = new BindingSource(dmsSC.GetRefundCauseDic("D"), null);

            txtMRNo.Select();
            FormatListView();
        }
        private void updateCollectedTestSummary()
        {
            double sum = 0;

            for (int i = 0; i < lvMRTests.Items.Count; ++i)
            {
                if (lvMRTests.Items[i].Checked == false)
                {
                    sum += Convert.ToDouble(lvMRTests.Items[i].SubItems[12].Text.ToString()) - Convert.ToDouble(lvMRTests.Items[i].SubItems[16].Text.ToString());
                }

            }
            txtNetAmount.Text = sum.ToString();          
        }

        private void PreviousTestSummary()
        {
            double sum = 0;

            for (int i = 0; i < lvMRTests.Items.Count; ++i)
            {             
                    sum += Convert.ToDouble(lvMRTests.Items[i].SubItems[12].Text.ToString()) - Convert.ToDouble(lvMRTests.Items[i].SubItems[16].Text.ToString());             
            }
            txtPreviousAmount.Text = sum.ToString();
        }      
        private DiagnosticMR PopulateTestForRefund()
        {
            string string1 = "";
            DiagnosticMR dmr = new DiagnosticMR();
            dmr.MRNo = txtMRNo.Text;
            dmr.ApprovalID = "0";
            dmr.RefundAmount =Convert.ToDouble(txtReturnAmount.Text.ToString());
            dmr.PurposeID = Utility.GetPurposeCode(Utility.PurposeCode.DiagnosticColl);
            for (int i = 0; i < lvMRTests.Items.Count; i++)
            {
                if (lvMRTests.Items[i].Checked == true)
                {
                    TestFee tfObj = new TestFee();
                    Room lr = new Room();
                    TestSub ts = new TestSub();
                    LabTechnologist lt = new LabTechnologist();
                    FeeCategory oFeeCat = new FeeCategory();                    

                    SpecimenCollectionRoom oSpc = new SpecimenCollectionRoom();
                    oSpc.RoomID = lvMRTests.Items[i].SubItems[19].Text;
                    ts.SpecimenCollectionRoom = oSpc;

                    lt.ID = "0";
                    ts.Technologist = lt;
                 
                    ReportGroup rpg = new ReportGroup();
                    rpg.ReportGroupID = lvMRTests.Items[i].SubItems[4].Text;
                    ts.ReportGroup = rpg;

                    Department dp = new Department();
                    dp.DepartmentID = lvMRTests.Items[i].SubItems[2].Text;
                    ts.TestDepartment = dp;

                    TestGroup tg = new TestGroup();
                    tg.GroupId = lvMRTests.Items[i].SubItems[3].Text;
                    ts.TestGroup = tg;
                    ts.TestMainID = lvMRTests.Items[i].SubItems[7].Text;
                    ts.TestSubID = lvMRTests.Items[i].SubItems[1].Text;
                    ts.PanelID = lvMRTests.Items[i].SubItems[6].Text;
                    ts.AccCloseFlag = lvMRTests.Items[i].SubItems[18].Text;
                    tfObj.TestSub = ts;

                    tfObj.Fee = decimal.Parse(lvMRTests.Items[i].SubItems[12].Text.ToString());
                    tfObj.DeptFee = decimal.Parse(lvMRTests.Items[i].SubItems[13].Text.ToString());
                    tfObj.RefdFee = decimal.Parse(lvMRTests.Items[i].SubItems[14].Text.ToString());
                    tfObj.DoctorFee = decimal.Parse(lvMRTests.Items[i].SubItems[15].Text.ToString());
                    tfObj.Discount = decimal.Parse(lvMRTests.Items[i].SubItems[16].Text.ToString());
                    tfObj.VAT = decimal.Parse(lvMRTests.Items[i].SubItems[17].Text.ToString());

                    oFeeCat.FeeCategoryID = lvMRTests.Items[i].SubItems[9].Text.ToString();
                    tfObj.FeeCategory = oFeeCat;

                    string1 += tfObj.TestSub.SpecimenCollectionRoom.RoomID + ":" + (tfObj.TestSub.Technologist.ID == "" ? "0" : tfObj.TestSub.Technologist.ID) + ":" + tfObj.TestSub.ReportGroup.ReportGroupID + ":" + tfObj.TestSub.TestDepartment.DepartmentID + ":" + tfObj.TestSub.TestGroup.GroupId + ":" + tfObj.TestSub.TestMainID + ":" + tfObj.TestSub.TestSubID + ":" + tfObj.FeeCategory.FeeCategoryID + ":" + tfObj.Fee + ":" + tfObj.DeptFee + ":" + tfObj.RefdFee + ":" + tfObj.DoctorFee + ":" + tfObj.Discount + ":" + tfObj.VAT + ":" + tfObj.FeeCategory + ":" + ";";                   
                }

            }
            dmr.TestString1 = string1;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            dmr.EntryParameter = ep;

            dmr.Remarks = "";

            return dmr;
        }     
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMRNo"};
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtReturnAmount.Text =="")
            {
                btnCalculate_Click(sender, e);
            }

            if (lvMRTests.Items.Count == 0)
            {
                MessageBox.Show("No Test to perform", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lvMRTests.CheckedItems.Count == 0)
            {
                MessageBox.Show("No Test selected", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lvMRTests.Focus();
                return;
            }
            for (int i = 0; i < lvMRTests.Items.Count; i++)
            {
                if (lvMRTests.Items[i].SubItems[18].Text == "0")
                {
                    MessageBox.Show("You are allowed to cancel the tests..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            for (int i = 0; i < lvMRTests.Items.Count; i++)
            {
                if (lvMRTests.Items[i].SubItems[19].Text == "I")
                {
                    MessageBox.Show("IPD MR is not Allowed Here..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (txtDueStatus.Text=="1")
            {
                MessageBox.Show("You Must Have to Pay The Previous Due For Refund", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDouble(txtReturnAmount.Text.ToString()) > Convert.ToDouble(txtNetPaid.Text.ToString()))
            {
                MessageBox.Show("Return Amount Can't be greater than Net Paid Amount..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {                       
                DiagnosticMR diagMrObj = this.PopulateTestForRefund();
                string i = dmsSC.SaveDiagnosticRefundMR(diagMrObj);
                txtMoneyReceiptNo.Text = i;              
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            printMR(txtMoneyReceiptNo.Text);
            btnNew.PerformClick();
            lvMRTests.Items.Clear();           
        }     
        private void printMR(string mrNo)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.RefundMoneyReceipt;
            vr.MoneyReceiptNo = mrNo;
            vr.ViewReport();
        }
        private void GetAdvanceAmount()
        {
            DiagnosticMR dmr = new DiagnosticMR();
            dmr = dmsSC.GetAdvance(txtMRNo.Text);
            txtDueStatus.Text = dmr.DueStatus.ToString();
            if (txtDueStatus.Text == "0")
            {
                decimal a = Math.Round(dmr.DiagnosticPayment.NetAmount, 0);
                txtNetPaid.Text = a.ToString();
            }
            if (txtDueStatus.Text == "1")
            {
                decimal a = Math.Round(dmr.DiagnosticPayment.Advance, 0);
                txtNetPaid.Text = a.ToString();
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvMRTests.CheckedItems.Count == 0)
                {
                    MessageBox.Show("No Test selected for Calculate Refund", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNetAmount.Text = "";
                    txtNetPaid.Text = "";
                    txtReturnAmount.Text = "";
                    return;
                }
                GetAdvanceAmount();
                updateCollectedTestSummary();
                double a = Math.Round(Convert.ToDouble(txtPreviousAmount.Text.ToString()) - Convert.ToDouble(txtNetAmount.Text.ToString()), 0);
                txtReturnAmount.Text = a.ToString();
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

        private void btnRefreshRefund_Click(object sender, EventArgs e)
        {
            cboCause.DisplayMember = "Value";
            cboCause.ValueMember = "Key";
            cboCause.DataSource = new BindingSource(dmsSC.GetRefundCauseDic("D"), null);
        }

        private void btnAddCause_Click(object sender, EventArgs e)
        {
            frmRefundCauseSetup oRefundCause = new frmRefundCauseSetup();
            oRefundCause.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lvMRTests.Items.Clear();
        }

        private void txtMRNo_TextChanged(object sender, EventArgs e)
        {
            txtMRNo.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
