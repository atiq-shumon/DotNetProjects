using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.IPDSR;
using AH.Shared.UI;
using AH.ModuleController.UI.IPD.Reports.Viewer;

namespace  AH.ModuleController.UI.IPD.Forms
{
    public partial class frmDischarge : AH.Shared.UI.frmSmartFormStandard
    {
        string dept, unit, bed, revHead="", hcn, serialno, regno;       
        int pamount = 0, pAdvance;
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        private string regNo;
        Int32 DayCountHour = 12;
        public frmDischarge(string regNo)
        {
            InitializeComponent();
            this.regNo = regNo;
        }
        PatientAdmissionUtility obj = new PatientAdmissionUtility();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string label = "Final Payment";
            string patNo = hcn;
            string patName = txtPatientName.Text;
            string purposeID=Utility.GetPurposeCode(Utility.PurposeCode.PrescriptionFee);
            string department = dept;            
            string departmentUnit = unit;      
            string reffDepartment = "N/A";
            string departmentReffUnit = "N/A";
            decimal departmentAmount = 300;
            decimal reffDepartmentAmount = 0;
            string totalAmount = txtTotal.Text;//txtPayable.Text;/
            string advance = txtAdvance.Text;
            string vat = "0";//((decimal.Parse(totalAmount)*4)/100).ToString();
            string discount = "0";// ((decimal.Parse(totalAmount) * 10) / 100).ToString();
            string discountBy = "";
            string paymentType = "0";
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

            try
            {
                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, totalAmount, advance, vat, discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0,false);
                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {

            try
            {
                InPatient oInPat = this.PopulateDischarge((OPDPayment)PaymentObject(payment));
                string i = ipdSc.SavePatientForDischarge(oInPat);
                if (i=="0")
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrintDischargeBillSammary(i);
                    btnNew.PerformClick();
                   
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //btnNew.PerformClick();
            //txtRegNo.Focus();
            ////AH.MODEL.Payment.Payment paymentObject = payment;
            //ob.PatientCardIssue(paymentObject);
            //frmReportViewer vr = new frmReportViewer();
            //vr.selector = ViewerSelector.OPDTicket;
            //vr.PatientNo = txtPatientNo.Text;
            //vr.TicketNo = txtTicketNo.Text;
            //vr.ReportTitle = "OPD Prescription";
            //vr.ReportSecondParameter = "";
            //"Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            //vr.ViewReport();
            txtRegNo.Focus();

        }
        private OPDPayment PaymentObject(AH.Shared.MODEL.OPDPayment payment)
        {
            OPDPayment paymentObject = new OPDPayment();
            paymentObject.Advance = payment.Advance;
            paymentObject.Amount = payment.Amount;
            paymentObject.CompanyID = payment.CompanyID;
            paymentObject.ConsultantFee = payment.ConsultantFee;
            paymentObject.Department = payment.Department;
            paymentObject.DepartmentUnit = payment.DepartmentUnit;
            paymentObject.DeptAmount = payment.DeptAmount;
            paymentObject.Discount = payment.Discount;
            paymentObject.EntryBy = payment.EntryBy;
            paymentObject.EntryDate = payment.EntryDate;
            paymentObject.EntryName = payment.EntryName;
            paymentObject.HCN = payment.HCN;
            paymentObject.LocationID = payment.LocationID;
            paymentObject.MachineID = payment.LocationID;
            paymentObject.NetAmount = payment.NetAmount;
            paymentObject.PaymentDate = payment.PaymentDate;
            paymentObject.PaymentType = payment.PaymentType;
            paymentObject.PreviousDue = payment.PreviousDue;
            paymentObject.PurposeID = payment.PurposeID;
            paymentObject.PurposeTitle = payment.PurposeTitle;
            paymentObject.ReffDept = payment.ReffDept;
            paymentObject.ReffDeptAmount = payment.ReffDeptAmount;
            paymentObject.ReffDeptUnit = payment.ReffDeptUnit;
            paymentObject.RefferedFee = payment.RefferedFee;
            paymentObject.RegistrationNo = payment.RegistrationNo;
            paymentObject.Staff = payment.Staff;
            paymentObject.TransactionNo = payment.TransactionNo;
            paymentObject.VAT = payment.VAT;
            return paymentObject;
        }

        private InPatient PopulateDischarge(OPDPayment payment)
        {
            InPatient patObj = new InPatient();
            patObj.RegistrationNo = txtRegNo.Text;
          

            Department odept = new Department();
            odept.DepartmentID = dept ;
            patObj.Department = odept; 

            DepartmentUnit oUnit = new DepartmentUnit();
            oUnit.UnitId = unit;
            patObj.DepartmentUnit = oUnit;

            
            //Doctor docObj = new Doctor();
            //docObj.ID = cboDoctor.SelectedValue.ToString();


            OPDPayment opdObj = payment;
            patObj.Payment = opdObj;
         
            IPDSR.Age patAge = new IPDSR.Age();
            patAge.Year = int.Parse(txtAgeYears.Text);
            patAge.Month = int.Parse(txtAgeMonths.Text);
            patAge.Day = int.Parse(txtAgeDays.Text);
            patAge.Hour = int.Parse(txtAgeHours.Text);
            patObj.Age = patAge;
            patObj.DischargeType = cboDischargeType.SelectedValue.ToString();


            RevenueHead oRev = new RevenueHead();
            oRev.RevenueHeadString=revHead;
            patObj.RevenueHead = oRev;

            Bed obed=new Bed ();
            obed.BedNo = bed;
            obed.SerialNo = Convert.ToInt16(lvBedHistory.Items[0].SubItems[9].Text);
            patObj.Bed = obed;
            
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            patObj.EntryParameter = ep;
            patObj.StaffID = "0";


            return patObj;
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            string vrfy = ipdSc.VerifyInPatient(txtRegNo.Text);
            if (vrfy.Length > 0)
            {
                MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegNo.Focus();
                btnNew.PerformClick();
                return;
            }
            InPatient pat = ipdSc.GetPatientDetailsForDis(txtRegNo.Text);
            LoadPatient(pat);
      
            refreshGrid(txtRegNo.Text);
            txtTotal.Text = ipdSc.GetTotalAmountForDischarge(txtRegNo.Text).ToString();
            txtPayable.Text = (Convert.ToInt32(ipdSc.GetTotalAmountForDischarge(txtRegNo.Text)) - Convert.ToInt32(pAdvance)).ToString();
         
        }
       
        private void LoadPatient(InPatient pat)
        {         
            hcn = pat.HCN;
            txtPatientName.Text = pat.Name;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";
            txtSex.Text = pat.Sex;
            pAdvance = Convert.ToInt32(pat.Payment.Amount);
            txtAdvance.Text = pAdvance.ToString(); ;

        }


        private void refreshGrid(string regno)
        {
            obj.LoadListViewBed(lvBedHistory,regno);
            obj.LoadListViewDept(lvDepartmentHist,regno);
            LoadListViewDiag(regno);
            LoadListViewReport(regno);
        }
       
       
        private void FormatGridDiag()
        {
            lvDiagnostic.CheckBoxes = false;
            lvDiagnostic.Columns.Add("MR NO", 50, HorizontalAlignment.Center);
            lvDiagnostic.Columns.Add("Patient No", 150, HorizontalAlignment.Center);
            lvDiagnostic.Columns.Add("Test Group", 95, HorizontalAlignment.Center);
            lvDiagnostic.Columns.Add("Test Main", 120, HorizontalAlignment.Center);
            lvDiagnostic.Columns.Add("Test Details", 100, HorizontalAlignment.Center);
            lvDiagnostic.Columns.Add("Fee", 50, HorizontalAlignment.Center);
        }
       
        private void DeptUnit(string regno)
        {            
            List<InPatient> bdh = ipdSc.GetBedHist(regno).ToList();
            foreach (InPatient bdhs in bdh)
            {
                dept = bdhs.Department.DepartmentID.ToString();
                unit = bdhs.DepartmentUnit.UnitId.ToString();
                serialno = bdhs.Bed.SerialNo.ToString();
                bed = bdhs.Bed.BedNo.ToString();
            }
        }
        //        ListViewItem itm = new ListViewItem(bdhs.AdmissionDate.ToString("dd-MM-yyyy"));
        //        itm.SubItems.Add(bdhs.Bed.BedType.Title.ToString());
        //        itm.SubItems.Add(bdhs.Bed.BedNo.ToString());
        //        itm.SubItems.Add(bdhs.Ward.WardTitle.ToString());
        //        itm.SubItems.Add(bdhs.Department.DepartmentTitle.ToString());
        //        itm.SubItems.Add(bdhs.DischargeDate.ToString("dd-MM-yyyy"));
        //        if (((bdhs.DischargeDate - bdhs.AdmissionDate).Days).ToString() == "0")
        //        {
        //            itm.SubItems.Add("1");
        //        }
        //        else 
        //        {
        //            itm.SubItems.Add(((bdhs.DischargeDate - bdhs.AdmissionDate).Days).ToString());
        //        }
        //        itm.SubItems.Add(bdhs.Bed.BedChargesString.ToString());

        //        if (((bdhs.DischargeDate - bdhs.AdmissionDate).Days).ToString() == "0")
        //        {
        //            itm.SubItems.Add((bdhs.Bed.BedChargesString).ToString());
        //        }
        //        else
        //        {
        //            itm.SubItems.Add((Convert.ToInt32(bdhs.Bed.BedChargesString) * (Convert.ToInt32((bdhs.DischargeDate - bdhs.AdmissionDate).Days))).ToString());
        //        }
                                  
        //        lvBedHistory.Items.Add(itm);
            
        //    }
        //}
      
        private void LoadListViewDiag(string regno)
        {
            //lvDiagnostic.Items.Clear();

            //List<DiagnosticMR> diag = ipdSc.GetDiAHistory(regno).ToList();
            //foreach (DiagnosticMR dghs in diag)
            //{
            //    ListViewItem itm = new ListViewItem(dghs.MRNo.ToString());
            //    itm.SubItems.Add(dghs.Patient.HCN.ToString());
            //    itm.SubItems.Add(dghs.test.TestSub.TestGroup.ToString());
            //    itm.SubItems.Add(dghs.test.TestSub.TestMainTitle.ToString());
            //    itm.SubItems.Add(dghs.test.TestSub.TestSubTitle.ToString());
            //    itm.SubItems.Add(dghs.test.Fee.ToString());
            //    lvDiagnostic.Items.Add(itm);
            //}
        }
        private void LoadListViewReport(string regno)
        {
            lvRepGr.Items.Clear();

            List<RevenueHead> rvhds = ipdSc.GetDepartmentRevenue(regno).ToList();

            foreach (RevenueHead rv in rvhds)
            {
                ListViewItem itm = new ListViewItem(rv.Title);
                itm.SubItems.Add(rv.Amount.ToString());
                lvRepGr.Items.Add(itm);
                revHead = rv.ID + ',' + rv.RevenueHeadGroup.ID + ',' + rv.Amount.ToString() + ';' + revHead;
            }
        }
       
        private void frmDischarge_Load(object sender, EventArgs e)
        {
            obj.cboDischargeType(cboDischargeType);
            
            if (regNo == "D")
            {
                txtRegNo.Text = "";
            }
            else
            {
                txtRegNo.Text = regNo;
            }
            obj.FormatListBedForBedInformation(lvBedHistory);
            obj.FormatListDept(lvDepartmentHist);
            FormatGridDiag();
            obj.FormatGridReport(lvRepGr);
            txtRegNo.Select();
            //refreshGrid(txtPatientName.Text);        
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lvBedHistory.Clear();
            lvDepartmentHist.Clear();
            lvRepGr.Clear();
            txtRegNo.Enabled = true;
            txtRegNo.Focus();
            obj.FormatListBedForBedInformation(lvBedHistory);
            obj.FormatListDept(lvDepartmentHist);
            FormatGridDiag();
            obj.FormatGridReport(lvRepGr);
        }

        private void txtRegNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtRegNo.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }
        }
        private void PrintDischargeBillSammary(string regID)
        {

            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.DischargeBillSummary;
            vr.TransactionNo = regID;
            vr.ReportTitle = "Patient Discharge Bill Summary";
            //vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            vr.ViewReport();

        }

    }
}

