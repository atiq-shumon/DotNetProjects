using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.DUtility;
using AH.ModuleController.APMSSR;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace AH.ModuleController.UI.APMS.Forms
{
    public partial class frmAppointPatientInfo : AH.Shared.UI.frmSmartFormStandard
    {
        private string tokenNo;
        private string departmentId;
        private string unitId;
        private string doctorId;
        private string startDate;
        private string endDate;
        private string appointmentDate;

        APMSWSClient clnt = new APMSWSClient();
        APMSSR.APMSWSClient apmssr = new APMSSR.APMSWSClient();

        public frmAppointPatientInfo(string departmentId, string unitId, string doctorId, string tokenNo, string startDate, string endDate, string appointmentDate)
        {
            this.tokenNo = tokenNo;
            this.departmentId = departmentId;
            this.unitId = unitId;
            this.doctorId = doctorId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.appointmentDate = appointmentDate;
            InitializeComponent();
        }


        private DataGridViewTextBoxColumn FormatColumns(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn Appointcolumn = new DataGridViewTextBoxColumn();
            Appointcolumn.DataPropertyName = pname;
            Appointcolumn.HeaderText = htext;
            Appointcolumn.DefaultCellStyle.ForeColor = Color.Black;
            Appointcolumn.DefaultCellStyle.BackColor = Color.White;
            Appointcolumn.Visible = true_false;
            Appointcolumn.DefaultCellStyle.Alignment = Algin;
            Appointcolumn.Width = cwidth;
            Appointcolumn.ReadOnly = true;
            Appointcolumn.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);
            Appointcolumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            return Appointcolumn;
        }

        List<string> oTimes = new List<string>();
        List<string> oDocTimes = new List<string>();
        int interval;
        private void frmAppointPatientInfo_Load(object sender, EventArgs e)
        {
            
                txtVisitorName.Focus();
                cboVisitorType.DisplayMember = "Value";
                cboVisitorType.ValueMember = "Key";
                cboVisitorType.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetVisitorTypes()), null);

                cboGender.DisplayMember = "Value";
                cboGender.ValueMember = "Key";
                cboGender.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetSexes()), null);

                cboCountry.DisplayMember = "Value";
                cboCountry.ValueMember = "Key";
                cboCountry.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetCountries()), null);

                cboStatus.DisplayMember = "Value";
                cboStatus.ValueMember = "Key";
                cboStatus.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetAppointmentStatus()), null);

                string var = tokenNo;
                string tokenno = Utility.GetStringPart(var, "\r");
                DateTime Date = DateTime.Parse(appointmentDate);
                string appointDate = Date.ToString("dd-MM-yyyy");

                List<OpdAppointment> oOpds = clnt.GetPatientInfo(departmentId, unitId, doctorId, tokenno, appointDate).ToList();
                for (int i = 0; i < oOpds.Count; i++)
                {
                    txtAppointmentID.Text = oOpds[i].TokenNo;
                    lblTokenNo.Text = oOpds[i].TokenNo;
                    lblHcn.Text = oOpds[i].Patient.HCN;
                    lblDate.Text = oOpds[i].AppointDate;
                    lblApproxTime.Text = oOpds[i].ApproxSTime;
                    //lblService.Text = oOpds[i].ServiceID;
                    lblVisitType.Text = oOpds[i].VisitType;
                    //lblDoctor.Text = oOpds[i].Doctor.Name;
                    lblBookingType.Text = oOpds[i].BookingType;
                    cboVisitorType.Text = oOpds[i].VisitorType;
                    txtVisitorName.Text = oOpds[i].Patient.Name;
                    txtVisitorAddress.Text = oOpds[i].Patient.Permanent_H_R_B;
                    cboGender.Text = oOpds[i].Patient.Sex;
                    nmrMobile.Text = oOpds[i].Patient.CellPhone;
                    txtEmail.Text = oOpds[i].Patient.Email;
                    nmrPhone.Text = oOpds[i].Patient.HomePhone;
                    cboCountry.Text = oOpds[i].Patient.Country;
                    nmrYear.Text = oOpds[i].Patient.AgeBreakDown.Year.ToString();
                    nmrMonth.Text = oOpds[i].Patient.AgeBreakDown.Month.ToString();
                    nmrDay.Text = oOpds[i].Patient.AgeBreakDown.Day.ToString();
                    //lblDoctor.Text = oOpds[i].Doctor.Name;

                }

      
        }

        public bool IsValidEmailAddress(string email)
        {
            if (Regex.IsMatch(email, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDeptID", "cboUnitID", "cboDoctorID", "txtVisitorName", "cboGender", "rdTextDepartmentId", "rdTextUnit", "rdTextDoctorId", "nmrYear" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                if (nmrMobile.Text != "")
                {
                    if (nmrMobile.TextLength != 11)
                    {
                        nmrMobile.Focus();
                        MessageBox.Show("Mobile number should be 11 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (txtEmail.Text != string.Empty)
                {                  
                    if (!Utility.IsValidEmail(txtEmail.Text))
                    {
                        MessageBox.Show("Your Email is incorrect,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();                    
                        return;
                    }              
                }
               
                OpdAppointment oOpdAppoint = this.EditPopulatePatientInfo();
                short i = clnt.UpdatePatientInformation(oOpdAppoint);

                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i == 1)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    this.Close();
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

        private OpdAppointment EditPopulatePatientInfo()
        {
            OpdAppointment oOpdAppoint = new OpdAppointment();

            oOpdAppoint.TokenNo = lblTokenNo.Text;
            oOpdAppoint.AppointDate = lblDate.Text;
            Patient oPat = new Patient();
            oPat.Name = txtVisitorName.Text;

            APMSSR.Age age = new APMSSR.Age();
            if (nmrYear.Text != "")
            {
                age.Year = int.Parse(nmrYear.Text);
            }
            else
            {
                age.Year = int.Parse("0");
            }
            if (nmrMonth.Text != "")
            {
                age.Month = int.Parse(nmrMonth.Text);
            }
            else
            {
                age.Month = int.Parse("0");
            }
            if (nmrDay.Text != "")
            {
                age.Day = int.Parse(nmrDay.Text);
            }
            else
            {
                age.Day = int.Parse("0");
            }
            oPat.AgeBreakDown = age;
            oPat.Country = cboCountry.SelectedValue.ToString();
            oPat.Email = txtEmail.Text;
            oPat.Sex = cboGender.SelectedValue.ToString();
            oPat.CellPhone = nmrMobile.Text;
            oPat.HomePhone = nmrPhone.Text;
            oPat.Permanent_H_R_B = txtVisitorAddress.Text;
            oPat.Status = char.Parse(cboStatus.SelectedValue.ToString());
            oOpdAppoint.Patient = oPat;

            Department oDept = new Department();
            oDept.DepartmentID = departmentId;
            oOpdAppoint.Department = oDept;

            DepartmentUnit oDTU = new DepartmentUnit();
            oDTU.UnitId = unitId;
            oOpdAppoint.DepartmentUnit = oDTU;

            Doctor oDoc = new Doctor();
            oDoc.ID = doctorId;
            oOpdAppoint.Doctor = oDoc;

            oOpdAppoint.VisitorType = cboVisitorType.SelectedValue.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oOpdAppoint.EntryParameter = ep;

            return oOpdAppoint;
        }
    }
}
