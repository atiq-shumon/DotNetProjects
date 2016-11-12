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


namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmTestCancel : AH.Shared.UI.frmSmartFormStandard
    {

        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public frmTestCancel()
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
                    MessageBox.Show("No Tests to Cancel!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lvMRTests.Items.Clear();
                    txtPatientName.Text = "";
                    txtAgeYears.Text = "";
                    txtAgeMonths.Text = "";
                    txtAgeDays.Text = "";
                    txtAgeHours.Text = "";
                    txtSex.Text = "";
                    txtRemarks.Text = "";
                    txtAdvance.Text = "";
                    txtDue.Text = "";
                    txtTotal.Text = "";
                    txtCash.Text = "";
                    txtDebitCard.Text = "";
                    txtCreditCard.Text = "";
                    txtReferredDoctor.Text = "";
                    return;
                }
                else
                {
                    LoadPatient(pat);
                    LoadTotalAmount(txtMRNo.Text);
                    loadMRTests(txtMRNo.Text);
                    LoadReffDoctor(txtMRNo.Text);
                    CalculateTotal();
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
            txtPatientName.Text = pat.Name;          
            txtAgeYears.Text = pat.Age.Year.ToString();
            txtAgeMonths.Text = pat.Age.Month.ToString();
            txtAgeDays.Text = pat.Age.Day.ToString();
            txtAgeHours.Text = pat.Age.Hour.ToString();
            txtSex.Text = pat.Sex;
        }
         private void frmCollectionDelete_Load(object sender, EventArgs e)
         {
             try
             {
                 FormatListView();

                 cboCause.DisplayMember = "Value";
                 cboCause.ValueMember = "Key";
                 cboCause.DataSource = new BindingSource(dmsSC.GetCancelCauseDic("D"), null);

                 cboReffOrg.DisplayMember = "Value";
                 cboReffOrg.ValueMember = "Key";
                 cboReffOrg.DataSource = new BindingSource(dmsSC.GetReffdOrgDic("D"), null);

                 //CalculateTotal();

                 txtMRNo.Focus();
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
             lvMRTests.Columns.Add("Fee", 100, HorizontalAlignment.Left);
             lvMRTests.Columns.Add("DeptFee", 0, HorizontalAlignment.Left);
             lvMRTests.Columns.Add("RefdFee", 0, HorizontalAlignment.Left);
             lvMRTests.Columns.Add("DoctorFee", 0, HorizontalAlignment.Left);
             lvMRTests.Columns.Add("Disc", 60, HorizontalAlignment.Left);
             lvMRTests.Columns.Add("vat", 0, HorizontalAlignment.Left);
             lvMRTests.Columns.Add("Acc", 0, HorizontalAlignment.Left);
             lvMRTests.Columns.Add("Ticket", 0, HorizontalAlignment.Left);
         }

         private void LoadTotalAmount(string mrno)
         {
             try
             {
                 List<TestFee> oTests = dmsSC.GetTotalTestFee(mrno).ToList();
                 foreach (TestFee otest in oTests)
                 {
                     if (otest.DueStatus.ToString() == "1")
                     {
                         txtAdvance.Text = otest.Advance.ToString();
                         txtDue.Text = otest.Due.ToString();
                         txtTotal.Text = otest.NetPaid.ToString();
                         txtGross.Text = otest.NetPaid.ToString();
                         txtCash.Text = otest.AccountsPayment.CashAmount.ToString();
                         txtDebitCard.Text = otest.AccountsPayment.DebitCardAmount.ToString();
                         txtCreditCard.Text = otest.AccountsPayment.CreditCardAmount.ToString();
                         txtDueStatus.Text = otest.DueStatus.ToString();
                     }
                     if (otest.DueStatus.ToString() == "0")
                     {
                         txtAdvance.Text = Convert.ToDouble(Convert.ToDouble(otest.Advance.ToString()) + Convert.ToDouble(otest.Due.ToString())).ToString();
                         txtDue.Text = "0";
                         txtTotal.Text = otest.NetPaid.ToString();
                         txtGross.Text = otest.NetPaid.ToString();
                         txtCash.Text = otest.AccountsPayment.CashAmount.ToString();
                         txtDebitCard.Text = otest.AccountsPayment.DebitCardAmount.ToString();
                         txtCreditCard.Text = otest.AccountsPayment.CreditCardAmount.ToString();
                         txtDueStatus.Text = otest.DueStatus.ToString();
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

         private void LoadReffDoctor(string mrno)
         {
             try
             {
                 List<DiagnosticMR> oDiagnosticMRs = dmsSC.GetReffDoctor(mrno).ToList();
                 foreach (DiagnosticMR oDiagnosticMR in oDiagnosticMRs)
                 {
                     if (oDiagnosticMR.Prescription.TicketType == "S")
                     {
                         cboReffOrg.Enabled = false;
                         cboReffDoc.Enabled = false;
                         btnAddReffOrg.Enabled = false;
                         btnRefreshOrg.Enabled = false;
                         btnAddReffDoc.Enabled = false;
                         btnRefreshDoc.Enabled = false;
                         txtReferredDoctor.Enabled = true;
                         txtTicketType.Text = oDiagnosticMR.Prescription.TicketType;
                         txtReferredDoctor.Text = oDiagnosticMR.Remarks;
                     }
                     if (oDiagnosticMR.Prescription.TicketType == "X")
                     {
                         cboReffOrg.Enabled = true;
                         cboReffDoc.Enabled = true;
                         btnAddReffOrg.Enabled = true;
                         btnRefreshOrg.Enabled = true;
                         btnAddReffDoc.Enabled = true;
                         btnRefreshDoc.Enabled = true;
                         txtReferredDoctor.Enabled = false;
                         txtTicketType.Text = oDiagnosticMR.Prescription.TicketType;
                         cboReffOrg.SelectedValue = oDiagnosticMR.RefdOrg.OrgID.ToString();
                         cboReffDoc.SelectedValue = oDiagnosticMR.Doctor.ID.ToString();
                     }
                     if (oDiagnosticMR.Prescription.TicketType == "O")
                     {
                         cboReffOrg.Enabled = false;
                         cboReffDoc.Enabled = false;
                         btnAddReffOrg.Enabled = false;
                         btnRefreshOrg.Enabled = false;
                         btnAddReffDoc.Enabled = false;
                         btnRefreshDoc.Enabled = false;
                         txtReferredDoctor.Enabled = false;
                         btnUpdate.Enabled = false;
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


         private void loadMRTests(string mrno)
         {
             try
             {
                 lvMRTests.Items.Clear();
                 List<TestFee> list = dmsSC.GetDmrTestForCancel(mrno).ToList();
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
                     itm.SubItems.Add(ts.TestSub.TicketType.ToString());//19
                     if (ts.TestSub.AccCloseFlag.ToString() == "1")
                     {
                         itm.ForeColor = Color.OrangeRed;
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

         private DiagnosticMR PopulateTestCancel()
         {
             DiagnosticMR dmr = new DiagnosticMR();
             dmr.MRNo = txtMRNo.Text;
             dmr.RefundAmount =Convert.ToDouble(lblRefund.Text.ToString());
             dmr.Due = Convert.ToDouble(txtDue.Text.ToString());
             dmr.TestCancelCause = cboCause.SelectedValue.ToString();
             InPatient inObj = new InPatient();
             dmr.Patient = inObj;
             List<TestFee> tests = new List<TestFee>();
             for (int i = 0; i < lvMRTests.Items.Count; i++)
             {
                 if (lvMRTests.Items[i].Checked == true)
                 {
                     TestFee tfObj = new TestFee();
                     Room lr = new Room();
                     TestSub ts = new TestSub();
                     LabTechnologist lt = new LabTechnologist();

                     lr.RoomID = lvMRTests.Items[i].SubItems[11].Text;
                     ts.Room = lr;

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

                     FeeCategory oFeeCat = new FeeCategory();
                     oFeeCat.FeeCategoryID = lvMRTests.Items[i].SubItems[9].Text;
                     tfObj.FeeCategory = oFeeCat;

                     tfObj.Fee = decimal.Parse(lvMRTests.Items[i].SubItems[12].Text.ToString());
                     tfObj.DeptFee = decimal.Parse(lvMRTests.Items[i].SubItems[13].Text.ToString());
                     tfObj.RefdFee = decimal.Parse(lvMRTests.Items[i].SubItems[14].Text.ToString());
                     tfObj.DoctorFee = decimal.Parse(lvMRTests.Items[i].SubItems[15].Text.ToString());
                     tfObj.Discount = decimal.Parse(lvMRTests.Items[i].SubItems[16].Text.ToString());
                     tfObj.VAT = decimal.Parse(lvMRTests.Items[i].SubItems[17].Text.ToString());
                     tests.Add(tfObj);
                 }
                 
             }

             dmr.Tests = tests.ToArray<TestFee>();

             EntryParameter ep = new EntryParameter();
             ep.CompanyID = Utility.CompanyID;
             ep.EntryBy = Utility.UserId;
             ep.LocationID = Utility.LocationID;
             ep.MachineID = Utility.MachineID;
             dmr.EntryParameter = ep;

             return dmr;

         }

         private DiagnosticMR UpdateRefdDoctor()
         {           
                 DiagnosticMR dmr = new DiagnosticMR();
                 dmr.MRNo = txtMRNo.Text;
                 if (txtTicketType.Text == "S")
                 {
                     RefdOrg oReff = new RefdOrg();
                     oReff.OrgID = "0";
                     dmr.RefdOrg = oReff;
                     Doctor oDoc = new Doctor();
                     oDoc.ID = "0";
                     dmr.Doctor = oDoc;
                     dmr.Remarks = txtReferredDoctor.Text.ToString();
                 }
                 if (txtTicketType.Text == "X")
                 {
                     RefdOrg oReff = new RefdOrg();
                     oReff.OrgID = cboReffOrg.SelectedValue.ToString();
                     dmr.RefdOrg = oReff;
                     Doctor oDoc = new Doctor();
                     oDoc.ID = cboReffDoc.SelectedValue.ToString();
                     dmr.Doctor = oDoc;
                     dmr.Remarks = "";
                 }

                 EntryParameter ep = new EntryParameter();
                 ep.CompanyID = Utility.CompanyID;
                 ep.EntryBy = Utility.UserId;
                 ep.LocationID = Utility.LocationID;
                 ep.MachineID = Utility.MachineID;
                 dmr.EntryParameter = ep;

                 return dmr;      
            
         }
         private void btnSave_Click(object sender, EventArgs e)
         {
             List<string> vf = new List<string>() { "txtMRNo" };
             Control control = Utility.ReqFieldValidator(this, vf);

             if (control != null)
             {
                 MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 control.Focus();
                 return;
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
                 if (lvMRTests.Items[i].SubItems[18].Text == "1")
                 {
                     MessageBox.Show("Allready Posted in Accounts..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
             if (Convert.ToDouble(lblRefund.Text)>Convert.ToDouble(txtCash.Text))
             {
                 MessageBox.Show("Cancel is Not Allowed Because of Insufficient Cash", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
             
             if (txtDueStatus.Text == "0")
             {
                    try
                    {
                        DiagnosticMR mr = this.PopulateTestCancel();
                        string i = dmsSC.SaveTestCancel(mr);
                        if (i == "0")
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i != "0")
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lvMRTests.Items.Clear();
                            cboPatientMr_Click(sender, e);
                            printMR(txtMRNo.Text);
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

             if (txtDueStatus.Text == "1")
             {
                DialogResult msg = MessageBox.Show("Do You Want to Adjust Your Previous Due?", Utility.MessageCaptionMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (msg == DialogResult.Yes)
                {
                    if (Convert.ToDouble(txtDue.Text)>Convert.ToDouble(lblRefund.Text))
                    {
                        txtDue.Text = (Convert.ToDouble(txtDue.Text) - Convert.ToDouble(lblRefund.Text)).ToString();
                        lblRefund.Text = "0";
                    }
                    if (Convert.ToDouble(lblRefund.Text) > Convert.ToDouble(txtDue.Text))
                    {
                        lblRefund.Text = (Convert.ToDouble(lblRefund.Text) - Convert.ToDouble(txtDue.Text)).ToString();
                        txtDue.Text = "0";
                    }
                    try
                    {
                        DiagnosticMR mr = this.PopulateTestCancel();
                        string i = dmsSC.SaveTestCancel(mr);
                        if (i == "0")
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i != "0")
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lvMRTests.Items.Clear();
                            cboPatientMr_Click(sender, e);
                            printMR(txtMRNo.Text);
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

                if (msg == DialogResult.No)
                {
                    return;
                }

             }
            
         }
         private void printMR(string mrNo)
         {
             frmReportViewer vr = new frmReportViewer();
             vr.selector = ViewerSelector.DMSMoneyReceipt;
             vr.MoneyReceiptNo = txtMRNo.Text;
             vr.ViewReport();
         }
         private void txtMRNo_KeyUp(object sender, KeyEventArgs e)
         {
             if (txtMRNo.Text.Length == Utility.ScanLength)
                 {
                     cboPatientMr_Click(sender, e);
                 }
         }
         private void CalculateCashBack()
         {
             double dblCashBackamount = 0;
             for (int i = 0; i < lvMRTests.Items.Count; i++)
             {                
                 if (lvMRTests.Items[i].Checked == true)
                 {
                     dblCashBackamount = dblCashBackamount + Convert.ToDouble(lvMRTests.Items[i].SubItems[12].Text) - Convert.ToDouble(lvMRTests.Items[i].SubItems[16].Text);
                 }                
             }
             if (dblCashBackamount > 0)
             {
                 lblRefund.Text = dblCashBackamount.ToString();
                 lblCashBack.Text = Convert.ToDouble(Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(lblRefund.Text)).ToString();
             }
             if (lvMRTests.CheckedItems.Count == 0)
             {
                 lblRefund.Text = "0";
                 lblCashBack.Text = "0";
             }

         }
         private void CalculateTotal()
         {
             double dblNetamount = 0;
             for (int i = 0; i < lvMRTests.Items.Count; i++)
             {
                 if (lvMRTests.Items[i].Checked == false)
                 {
                     dblNetamount = dblNetamount + Convert.ToDouble(lvMRTests.Items[i].SubItems[12].Text) - Convert.ToDouble(lvMRTests.Items[i].SubItems[16].Text);
                 }                
             }
             if (dblNetamount > 0)
             {
                 txtTotal.Text = dblNetamount.ToString();
                 lblRefund.Text = "0";
                 lblCashBack.Text = "0";
             }
         }
         private void lvMRTests_ItemChecked(object sender, ItemCheckedEventArgs e)
         {
             CalculateCashBack();
         }

         private void btnNew_Click(object sender, EventArgs e)
         {
             lvMRTests.Items.Clear();
         }

         private void txtMRNo_TextChanged(object sender, EventArgs e)
         {
             txtMRNo.CharacterCasing = CharacterCasing.Upper;
         }
         private void cboReffOrg_SelectedIndexChanged(object sender, EventArgs e)
         {
             cboReffDoc.DisplayMember = "Value";
             cboReffDoc.ValueMember = "Key";
             cboReffDoc.DataSource = new BindingSource(dmsSC.GetReffdDocDic(cboReffOrg.SelectedValue.ToString()), null);
         }

         private void btnAddReffOrg_Click(object sender, EventArgs e)
         {
             frmReffdOrgSetup oReffOrg = new frmReffdOrgSetup();
             oReffOrg.ShowDialog();
         }

         private void btnRefreshOrg_Click(object sender, EventArgs e)
         {
             cboReffOrg.DisplayMember = "Value";
             cboReffOrg.ValueMember = "Key";
             cboReffOrg.DataSource = new BindingSource(dmsSC.GetReffdOrgDic("D"), null);
         }

         private void btnAddReffDoc_Click(object sender, EventArgs e)
         {
             frmReffdDocSetup oReffDoc = new frmReffdDocSetup();
             oReffDoc.ReffOrg = cboReffOrg.SelectedValue.ToString();
             oReffDoc.ShowDialog();
         }
         private void btnRefreshDoc_Click(object sender, EventArgs e)
         {
             cboReffDoc.DisplayMember = "Value";
             cboReffDoc.ValueMember = "Key";
             cboReffDoc.DataSource = new BindingSource(dmsSC.GetReffdDocDic(cboReffOrg.SelectedValue.ToString()), null);
         }
         private void btnUpdate_Click(object sender, EventArgs e)
         {
             try
             {
                 DiagnosticMR mr = this.UpdateRefdDoctor();
                 if(txtMRNo.Text=="")
                 {
                     MessageBox.Show("Please Put a Valid MR No.", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                 }
                 short i = dmsSC.UpdateReffDoctor(mr);
                 if (i == 0)
                 {
                     MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 else if (i > 0)
                 {
                     MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                     lvMRTests.Items.Clear();
                     cboPatientMr_Click(sender, e);
                     printMR(txtMRNo.Text);
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
