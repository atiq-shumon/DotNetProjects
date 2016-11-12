using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.Shared.UI;
using System.Linq;
using AH.ModuleController.UI.OPD.Reports.Viewer;
using AH.ModuleController.OPDSR;
using System.Globalization;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmOPDTicketIssue : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdsr = new OPDSR.OPDWSClient();
        private string NsStnID = "";

        List<OPDDoctor> oDrRoomAllocs = new List<OPDDoctor>();
        List<OpdAppointment> oAppointments;
        string PatChkOldNew = "";
          
        string PatCount = "";
        string PatMaxVDate = "";
        string DrTotalVisit = "";
        string DrPatBar = "";
        string visitCycle = "";

        List<OPDDoctor> oDoctors = new List<OPDDoctor>();
        //List<Doctor> oDoctors = new List<Doctor>();

        public frmOPDTicketIssue()
        {
            InitializeComponent();
            txtHCNNo.Focus();
        }

        //Fauzul 5 July 2014
        private void LoadDoctorandRoom()
        {

            oDrRoomAllocs = opdsr.GetOPDDoctors().ToList();
        }

        private void GetOPDDoc()
        {
     
            //if (cboDepartment.SelectedValue.ToString() == "" || cboUnit.SelectedValue.ToString() == "")
            //{
            //    //MessageBox.Show("Provide Department and Unit");
            //    return;
            //}
            cboDoctor.DisplayMember = "Value";
            cboDoctor.ValueMember = "Key";
            cboDoctor.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetOPDDoctorsDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString())), null); 
        }


        private void frmOPDTicketIssue_Load(object sender, EventArgs e)
        {
            txtStaff.Visible = false;
            txtFee.Visible = false;
            txtRoom.Visible = false;
            lblRoom.Visible = false;
            lblLastV.Text = "";
            lbldrtV.Text = "";
            lblmP.Text = "";

            txtStaff.Visible = false;
            txtStaff.Text = "0";
            txtAppointment.Text = "0";
            LoadDoctorandRoom();
            txtRoom.Enabled = false;

            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
            
            //cboUnit.DisplayMember = "Value";
            //cboUnit.ValueMember = "Key";
            //cboUnit.DataSource = new BindingSource(opdsr.GetUnitDict("D"), null);

            cboCaseID.DisplayMember = "Value";
            cboCaseID.ValueMember = "Key";
            cboCaseID.DataSource = new BindingSource(opdsr.GetDiseaseDict(""), null);

            cboTicketType.DisplayMember = "Value";
            cboTicketType.ValueMember = "Key";
            cboTicketType.DataSource = new BindingSource(opdsr.GetPrescriptionTypes(), null);
 
            cboDepartment.Enabled = false;
            cboUnit.Enabled = false;
            cboDoctor.Enabled = false;
            txtFrom.Enabled = false;
            txtTo.Enabled = false;
            this.ActiveControl = txtHCNNo;
            cboTicketType.SelectedIndex = 1;
        }

        private void smartNumericTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {    
            if (txtHCNNo.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHCNNo.Focus();
                return;
            };

            if (opdsr.VerifyPatientNo(txtHCNNo.Text) == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHCNNo.Focus();
                return;
            };

            Patient pat = opdsr.GetPatient(txtHCNNo.Text);
            oAppointments = opdsr.Appointment(txtHCNNo.Text).ToList(); ;
            LoadAppointmentToDropDownList(oAppointments);          
            
            LoadPatient(pat);
            cboTokenNo.Focus();
        }

        private void LoadAppointmentToDropDownList(List<OpdAppointment> oAppointments)
        {
            cboTokenNo.DisplayMember = "value";
            cboTokenNo.ValueMember = "key";
            //cboTokenNo.Items.Clear();
            Dictionary<string, string> appDictionary = new Dictionary<string, string>();
            appDictionary.Add("","--Select--");
            foreach (OpdAppointment oAppointment in oAppointments)
            {
                appDictionary.Add(oAppointment.AppointID, oAppointment.TokenNo);
            }
            cboTokenNo.DataSource = new BindingSource(appDictionary, null);
             
        }
        private void LoadAppointmentDetails(OpdAppointment Appointment)
        {
            cboDepartment.SelectedValue = Appointment.Department.DepartmentID;

            cboUnit.SelectedValue = Appointment.DepartmentUnit.UnitId;

            cboDoctor.SelectedValue = Appointment.Doctor.ID;
            txtAppointment.Text = Appointment.AppointID;
            //cboTokenNo.SelectedValue = Appointment.TokenNo;
            txtFrom.Text = Appointment.ApproxSTime;
            txtTo.Text = Appointment.ApproxETime;

        } 
       
        private void LoadPatient(Patient pat)
        {
            txtPatientName.Text = pat.Name;
            string Dob = pat.DOB.ToString("dd/MM/yyyy");

            if (Dob != "" && Dob.Length == 10 && DateTime.Parse(Dob) <= DateTime.Today)
            {
                AH.DUtility.Age age = Utility.CalculateAge(DateTime.Parse(Dob));
                txtAgeYears.Text = age.Year.ToString();
                txtAgeMonths.Text = age.Month.ToString();
                txtAgeDays.Text = age.Day.ToString();
            }
            else
            {
                txtAgeYears.Text = string.Empty;
                txtAgeMonths.Text = string.Empty;
                txtAgeDays.Text = string.Empty;
            }
            //if (Dob.Length == 10)
            //{
            //    //............b.date calculation.....//
            //    DateTime now = DateTime.Today;
            //    DateTime birthDate = DateTime.ParseExact(Dob, "dd/MM/yyyy", null);
            //    //get the difference in years
            //    TimeSpan ts = now.Date - birthDate.Date;
            //    int ageY = (ts.Days / 365);
            //    int daysleft1 = ts.Days - (ageY * 365);
            //    int ageM = (daysleft1 / 30);
            //    int daysleft2 = daysleft1 - (ageM * 30);
            //    int ageD = daysleft2;

            //    txtAgeYears.Text = ageY.ToString();
            //    txtAgeMonths.Text = ageM.ToString();
            //    txtAgeDays.Text = ageD.ToString();
            //}

            //DUtility.Age age = Utility.CalculateAge(pat.DOB);
            //txtAgeYears.Text = age.Year.ToString();
           // txtAgeMonths.Text = age.Month.ToString();
            //txtAgeDays.Text = age.Day.ToString();
            txtPresentAddress.Text = pat.Present_H_R_B + Utility.CrLf + Utility.CrLf + pat.PresentThana + ", " + pat.PresentDistrict;
        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void txtHCNNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHCNNo.Text.ToUpper().Length == Utility.ScanLength)
            {
                txtHCNNo.Text = txtHCNNo.Text.ToUpper();
                btnPatientSearch_Click(sender, e);
            }
          
        }

        public void OPDMoneyReceipt(string ticketNo)
        {
            frmReportViewer ofrmReportViewerOPD = new frmReportViewer();
            ofrmReportViewerOPD.selector = ViewerSelector.OPDMR;
            ofrmReportViewerOPD.ParamField = ticketNo;
            ofrmReportViewerOPD.ViewReport();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboTicketType", "cboTokenNo", "txtHCNNo", "cboCaseID", "cboDepartment", "cboUnit", "cboDoctor", "txtRoom", "txtFee" }; //"txtAppointment", "txtStaff" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (opdsr.VerifyPatientNo(txtHCNNo.Text) == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                txtHCNNo.Focus();
                return;
            };

            string label = "Payment for Prescription";
            string patNo = txtHCNNo.Text;
            string patName = txtPatientName.Text;
            string department = cboDepartment.SelectedValue.ToString();
            string departmentUnit = cboUnit.SelectedValue.ToString();
            string reffDepartment = "N/A";
            string departmentReffUnit = "N/A";
            decimal departmentAmount = 300;
            decimal reffDepartmentAmount = 0;
            decimal consultantFee = Convert.ToDecimal(txtConsultantFee.Text) ;
            string amount = txtFee.Text;
            string advance = "0";
            string vat = "0";
            string discount = "0";
            string discountBy = "0";
            string paymentType = "0";

            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.PrescriptionFee);
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            string RoomNo = txtRoom.Text;
            string AppID = txtAppointment.Text;  
            
            try
            {                
                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat, 
                                                discount, discountBy, department, reffDepartment, departmentUnit,
                                                departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate,
                                                paymentType, consultantFee,false);
                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                frm.Show();
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

        private object PaymentObject(AH.Shared.MODEL.OPDPayment payment)
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
            paymentObject.PaymentString = payment.PaymentString;
            return paymentObject;
        }

        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        { 
            try
            {
                Ticket tktObj = this.PopulateTicket((OPDPayment)PaymentObject(payment));
                string i = opdsr.SaveOPDTicket(tktObj);
                txtTicketNo.Text = i;
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    
            //txtPatientNo.Focus();
            //AGH.MODEL.Payment.Payment paymentObject = payment;
            //ob.PatientCardIssue(paymentObject);

            string tempTicket = "";
            tempTicket = txtTicketNo.Text;
           
            btnNew.PerformClick();
            cboTicketType.SelectedIndex = 1;
            OPDMoneyReceipt(tempTicket);
            
        }

        private Ticket PopulateTicket(OPDPayment payment)
        {
            Patient patObj = new Patient();

            patObj.HCN = txtHCNNo.Text;
            patObj.CaseID = cboCaseID.SelectedValue.ToString();


            Department dept = new Department();
            dept.DepartmentID = cboDepartment.SelectedValue.ToString();
            patObj.Department = dept;

            DepartmentUnit deptUnit = new DepartmentUnit();
            deptUnit.UnitId = cboUnit.SelectedValue.ToString();
            patObj.DepartmentUnit = deptUnit;

            if (patObj.StaffID != null)
            {
                patObj.StaffID = txtStaff.Text;
            }
            else
            {
                patObj.StaffID = "0";
            }

            Doctor docObj = new Doctor();
            docObj.ID = cboDoctor.SelectedValue.ToString();    

            OPDPayment opdObj = payment;      
            AH.ModuleController.OPDSR.Age age = new AH.ModuleController.OPDSR.Age();
            age.Year = int.Parse(txtAgeYears.Text);
            age.Month = int.Parse(txtAgeMonths.Text);
            age.Day = int.Parse(txtAgeDays.Text);
            age.Hour = 0; 

            Room oRoom = new Room();
            oRoom.RoomID = txtRoom.Text;    

            Ticket tkt = new Ticket();
            tkt.PatientAge = age;
            tkt.Patient = patObj;
            tkt.PatientPayment = opdObj;
            tkt.PatSerial = txtPatSerial.Text;
            tkt.Doctor = docObj;
            tkt.TicketType = cboTicketType.SelectedValue.ToString();
            tkt.TicketStatus = "N";// New;
            tkt.TicketCategory = "N"; // Normal
            tkt.CopyPrinted = "0";
            tkt.PreviousTicketNo = "";
            tkt.AppointmentID = txtAppointment.Text;
            tkt.Room = oRoom;
            tkt.NurseStationID = NsStnID;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;  
            tkt.EntryParameter = ep;  
            return tkt;
        }
          
        private void btnNew_Click(object sender, EventArgs e)
        {
            lblRoom.Visible = false ;
            txtHCNNo.Focus();
        }

        private void cboCaseID_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(opdsr.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboDepartment.SelectedValue.ToString())), null);
            }
            else
            {
                return;
            } 
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOPDDoc();
        }

        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFee.Text = "";
            txtRoom.Text = "";

            lbldrtV.Text = "";
            lblmP.Text = "";
            lblLastV.Text = "";

            if (oDrRoomAllocs.Count > 0) 
            {
                string RoomID = "";
                string RoomNo = "";
                for (int i = 0; i < oDrRoomAllocs.Count; i++)
                {
                    if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                    {
                        RoomID = oDrRoomAllocs[i].Room.RoomID.ToString();
                        RoomNo = oDrRoomAllocs[i].Room.RoomNo.ToString();
                        txtRoom.Text = RoomID;
                        lblRoom.Text = RoomNo;
                        lblRoom.Visible = true;
                        break;
                    }
                }
                txtRoom.Text = RoomID;
            }            
        }

       public void CheckFee()
        {
            if (PatMaxVDate != "")
            {
                lblLastV.Text = " Patient Last Visit: - " + " " + PatMaxVDate;
            }

            if (PatMaxVDate == "")
            {
                lblLastV.Text = "New Visit";
            }

            if (DrTotalVisit != "")
            {
                lbldrtV.Text = "Total Visit : - " + DrTotalVisit;
            }

            if (DrPatBar != "")
            {
                lblmP.Text = "Maximum Patient : - " + DrPatBar;
            }

            if (DrPatBar == "0")
            {
                for (int i = 0; i < oDrRoomAllocs.Count; i++)
                {
                    if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                    {
                        txtConsultantFee.Text = oDrRoomAllocs[i].DrVisFirst.ToString();
                        txtFee.Text = oDrRoomAllocs[i].VisFirst.ToString();
                    }
                }
            }

            if (DrPatBar == "1")
            {
                for (int i = 0; i < oDrRoomAllocs.Count; i++)
                {
                    if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                    {
                        txtConsultantFee.Text = oDrRoomAllocs[i].DrVisSecond.ToString();
                        txtFee.Text = oDrRoomAllocs[i].VisSecond.ToString();
                        break;
                    }
                }
            }
            if (DrPatBar == "2")
            {
                for (int i = 0; i < oDrRoomAllocs.Count; i++)
                {
                    if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                    {
                        txtConsultantFee.Text = oDrRoomAllocs[i].DrVisThird.ToString();
                        txtFee.Text = oDrRoomAllocs[i].VisThird.ToString();
                        break;
                    }
                }
            }

            if (DrPatBar == "3")
            {
                for (int i = 0; i < oDrRoomAllocs.Count; i++)
                {
                    if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                    {
                        txtConsultantFee.Text = oDrRoomAllocs[i].DrVisFourth.ToString();
                        txtFee.Text = oDrRoomAllocs[i].VisFourth.ToString();
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < oDrRoomAllocs.Count; i++)
                {
                    if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                    {
                        txtConsultantFee.Text = oDrRoomAllocs[i].DrVisFirst.ToString();
                        txtFee.Text = oDrRoomAllocs[i].VisFirst.ToString();
                    }
                }
            }
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            if (cboDoctor.SelectedValue == "")
            {
                MessageBox.Show("Provide Doctor Name");
                return;
            }

            PatChkOldNew = "";
            PatCount = "";
            PatMaxVDate = "";
            DrTotalVisit = "";
            DrPatBar = "";
            visitCycle = "";

            if (cboDoctor.SelectedValue == null)
            {
                MessageBox.Show("Please Select Doctor");
                cboDoctor.Select();
                return;
            }

            PatChkOldNew = opdsr.ChkPatOldNew(cboDoctor.SelectedValue.ToString(), txtHCNNo.Text).ToString();

            if (PatChkOldNew != "")
            {
                PatCount = PatChkOldNew.Split('~')[0];
                PatMaxVDate = PatChkOldNew.Split('~')[1];
                DrTotalVisit = PatChkOldNew.Split('~')[2];
                visitCycle = PatChkOldNew.Split('~')[5];
                txtPatSerial.Text = Convert.ToString(Convert.ToInt32(DrTotalVisit)+1);


                if (PatChkOldNew.Split('~')[3] != "")
                {
                    DrPatBar = PatChkOldNew.Split('~')[3];
                }

                else 
                {
                    DrPatBar = "0";
                }

                if (Convert.ToInt16(DrTotalVisit) >= Convert.ToInt16(DrPatBar))
                {
                    if (MessageBox.Show("You are Crossing Bar, Continue?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CheckFee();
                    }
                }

                if (Convert.ToInt16(DrTotalVisit) < Convert.ToInt16(DrPatBar))
                {
                    CheckFee();

                    if (PatMaxVDate != "")
                    {
                        lblLastV.Text = " Patient Last Visit :  " + " " + PatMaxVDate;
                    }

                    if (PatMaxVDate == "")
                    {
                        lblLastV.Text = "New Visit";
                    }

                    if (DrTotalVisit != "")
                    {
                        lbldrtV.Text = "Total Visit :  " + DrTotalVisit;
                    }

                    if (DrPatBar != "")
                    {
                        lblmP.Text = "Maximum Patient :  " + DrPatBar;
                    }

                    if (PatCount == "0")
                    {
                        for (int i = 0; i < oDrRoomAllocs.Count; i++)
                        {
                            if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                            {
                                txtConsultantFee.Text = oDrRoomAllocs[i].DrVisFirst.ToString();
                                txtFee.Text = oDrRoomAllocs[i].VisFirst.ToString();
                            }
                        }
                    }

                   // if (PatCount == "1")
                    if (Convert.ToInt32(PatCount) > 0)
                    {
                        for (int i = 0; i < oDrRoomAllocs.Count; i++)
                        {
                            if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                            {
                                string tempDocFirstVFee = oDrRoomAllocs[i].DrVisFirst.ToString();

                                string tempFirstVFee = oDrRoomAllocs[i].VisFirst.ToString();

                                DateTime dt =Convert.ToDateTime( DateTime.Parse(PatMaxVDate).ToString("dd/MM/yyyy"));

                                string date = Convert.ToString(dt) ;
                                AH.DUtility.Age Vdays = Utility.CalculateAge(DateTime.Parse(date));
                                int VisitDays= Convert.ToInt32(Vdays.Day);

                                if (VisitDays > Convert.ToInt32(visitCycle))
                                {
                                    txtConsultantFee.Text = oDrRoomAllocs[i].DrVisFirst.ToString();

                                    txtFee.Text = oDrRoomAllocs[i].VisFirst.ToString();
                                    break;
                                }
                                if (VisitDays >= 0 && VisitDays <= Convert.ToInt32(visitCycle))
                                {
                                    decimal TodaysFee = (Convert.ToDecimal(tempFirstVFee) / 2);

                                    decimal DoctorsTodaysFee = (Convert.ToDecimal(tempDocFirstVFee) / 2);

                                    txtConsultantFee.Text = Convert.ToString(DoctorsTodaysFee);     //oDrRoomAllocs[i].DrVisFirst.ToString();
                                    
                                    txtFee.Text = Convert.ToString(TodaysFee);                     //oDrRoomAllocs[i].VisFirst.ToString();
                                    break;

                                }

                               // txtConsultantFee.Text = oDrRoomAllocs[i].DrVisSecond.ToString();
                               // txtFee.Text = oDrRoomAllocs[i].VisSecond.ToString();
                                //break;
                            }
                        }
                    }

                    //if (PatCount == "2")
                    //{
                    //    for (int i = 0; i < oDrRoomAllocs.Count; i++)
                    //    {
                    //        if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                    //        {
                    //            txtConsultantFee.Text = oDrRoomAllocs[i].DrVisThird.ToString();
                    //            txtFee.Text = oDrRoomAllocs[i].VisThird.ToString();
                    //            break;
                    //        }
                    //    }
                    //}

                    //if (PatCount == "3")
                    //{
                    //    for (int i = 0; i < oDrRoomAllocs.Count; i++)
                    //    {
                    //        if (oDrRoomAllocs[i].Doctor.ID == cboDoctor.SelectedValue.ToString())
                    //        {
                    //            txtConsultantFee.Text = oDrRoomAllocs[i].DrVisFourth.ToString();
                    //            txtFee.Text = oDrRoomAllocs[i].VisFourth.ToString();
                    //            break;
                    //        }
                    //    }
                    //}
                }
           }
        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {
            //lblRoom.Text = txtRoom.Text;
            lblFee.Text = txtFee.Text;
        }

        private void cboTokenNo_SelectedIndexChanged(object sender, EventArgs e)
        {  
        if (cboTokenNo.SelectedValue.ToString()!= "" )
            {
                List<OpdAppointment> oApp = (from appoint in oAppointments
                                             where appoint.AppointID == cboTokenNo.SelectedValue.ToString()
                                             select appoint).ToList();
                LoadAppointmentDetails(oApp.First());
                btnFee_Click(sender, e);  
            }            
        }

        private void lblmP_Click(object sender, EventArgs e)
        {

        }

        private void btnToCase_Click(object sender, EventArgs e)
        {
            frmDiseaseCase ofrm = new frmDiseaseCase();
            ofrm.ShowDialog();
        }

        private void btnToCaseRefresh_Click(object sender, EventArgs e)
        {
            cboCaseID.DisplayMember = "Value";
            cboCaseID.ValueMember = "Key";
            cboCaseID.DataSource = new BindingSource(opdsr.GetDiseaseDict(""), null);
        }        
    }
}
