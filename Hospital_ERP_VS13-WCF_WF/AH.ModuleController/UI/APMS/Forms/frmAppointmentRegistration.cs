
//Developed by   : Shabnam
//Date           : 09-09-2014
//Purpose        : Patient Appointment Register 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.Shared.UI;
using AH.DUtility;
using AH.ModuleController.APMSSR;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace AH.ModuleController.UI.APMS.Forms
{
    public partial class frmAppointmentRegistration : AH.Shared.UI.frmSmartFormStandard
    {


        //public delegate void SaveButtonClick(string visitorName,string tokenNo, object sender, EventArgs e);
       // public SaveButtonClick onSaveButtonClicked;
       // private string tokenNo = "1";
        private string appointmentTime;      
        private string appointmentDate;
        private string departmentId;
        private string unitId;
        private string doctorId;
        private string departmentName;
        private string doctorName;
        private string unitName;
        private string startDate;
        private string endDate;
        private int tokenNo;
        private List<string> oTimes;
        APMSWSClient clnt = new APMSWSClient();
        APMSSR.APMSWSClient apmssr = new APMSSR.APMSWSClient();
        List<Patient> patList = new List<Patient>();
        public frmAppointmentRegistration(string appointmentTime,string appointmentDate, string departmentId, string unitId, string doctorId,
            string departmentName, string doctorName, string unitName, string startDate, string endDate,int tokenNo,List<string> oTimes)
        {
            this.appointmentTime = appointmentTime;          
            this.appointmentDate = appointmentDate;
            this.departmentId = departmentId;
            this.unitId = unitId;
            this.doctorId = doctorId;
            this.departmentName = departmentName;
            this.doctorName = doctorName;
            this.unitName = unitName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.tokenNo = tokenNo;
            this.oTimes = oTimes;
            InitializeComponent();
        }



        private DataGridViewTextBoxColumn FormatColumns(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn Appointcolumn = new DataGridViewTextBoxColumn();
            Appointcolumn.DataPropertyName = pname;
            Appointcolumn.Name = pname;
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

        private void FormatList()
        {        
            lstPatientList.Columns.Add("HCN", 112, HorizontalAlignment.Left);
            lstPatientList.Columns.Add("Patient Name ",210, HorizontalAlignment.Left);
            lstPatientList.Columns.Add("Phone Number", 120, HorizontalAlignment.Left);        
        }
        //List<string> oTimes = new List<string>();
        //List<string> oDocTimes = new List<string>();
        private void frmAppointmentRegistration_Load(object sender, EventArgs e)
        {
           
                txtHCN.Select();
                cboVisitType.DisplayMember = "Value";
                cboVisitType.ValueMember = "Key";
                cboVisitType.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetVisitTypes()), null);

                cboBookingType.DisplayMember = "Value";
                cboBookingType.ValueMember = "Key";
                cboBookingType.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetBookingTypes()), null);


                cboBookingMode.DisplayMember = "Value";
                cboBookingMode.ValueMember = "Key";
                cboBookingMode.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetBookingModes()), null);


                cboVisitorType.DisplayMember = "Value";
                cboVisitorType.ValueMember = "Key";
                cboVisitorType.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetVisitorTypes()), null);

                cboGender.DisplayMember = "Value";
                cboGender.ValueMember = "Key";
                cboGender.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetSexes()), null);

                //  if (cboCountry.SelectedIndex > 0) { cboCountry.Text = "<Select>"; }
                //else
                //{
                cboCountry.DisplayMember = "Value";
                cboCountry.ValueMember = "Key";
                cboCountry.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetCountries()), null);
                //}             
                lblStartTime.Text = appointmentTime;
                lblAppointDate.Text = appointmentDate;
                rdTextDepartmentId.Text = departmentName;
                rdTextUnit.Text = unitName;
                rdTextDoctorId.Text = doctorName;

                dgvAppointment.Columns.Clear();
                dgvAppointment.DataSource = null;

                dgvAppointment.Columns.Add(FormatColumns("Time", "Time", 90, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
                dgvAppointment.Columns.Add(FormatColumns("Date", "", 130, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));

                string date = (Convert.ToDateTime(appointmentDate)).ToString("dd-MM-yyyy") + "\r\n" + (Convert.ToDateTime(appointmentDate)).ToString("dddd");
                dgvAppointment.Columns["Date"].HeaderCell.Value = date;
                dgvAppointment.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for (int lst = 0; lst < oTimes.Count; lst++)
                {
                    dgvAppointment.Rows.Add();
                    dgvAppointment.Rows[lst].Cells[0].Value = oTimes[lst];
                }
                DataGridRefresh(appointmentDate);
                dgvAppointment.Columns[1].Width = 155;
                if (dgvAppointment.Columns.Count < 3)
                {
                    TicketOkPatientList(Utility.GetStringPart(dgvAppointment.Columns[1].HeaderCell.Value.ToString(), "\r\n"));
                }

                if (dgvAppointment.Columns.Count < 3)
                {
                    prescribedPatient(Utility.GetStringPart(dgvAppointment.Columns[1].HeaderCell.Value.ToString(), "\r\n"));
                }

                lstPatientList.Height = 100;
                lstPatientList.Width = 450;
                FormatList();
                lstPatientList.Visible = false;
         

        }
        private void TicketOkPatientList(string AppointDate)
        {
            List<OpdAppointment> oPatTime = clnt.TicketOkPatientList(departmentId, unitId, doctorId, startDate).ToList();
            for (int i = 0; i < dgvAppointment.Rows.Count; i++)
            {
                if (dgvAppointment.Rows[i].Cells[1].Value != null)
                {
                    string tokenNo = Utility.GetStringPart(dgvAppointment.Rows[i].Cells[1].Value.ToString(), "\r\n");
                    for (int lst = 0; lst < oPatTime.Count; lst++)
                    {
                        if (tokenNo == oPatTime[lst].TokenNo)
                        {
                            dgvAppointment.Rows[i].Cells[1].Style.BackColor = Color.GreenYellow;
                        }
                    }
                }
            }
        }
        private void prescribedPatient(string AppointDate)
        {
            List<OpdAppointment> oPatTime = clnt.PrescribePatientList(departmentId, unitId, doctorId, startDate).ToList();
                                         
            for (int i = 0; i < dgvAppointment.Rows.Count; i++)
            {
                if (dgvAppointment.Rows[i].Cells[1].Value != null)
                {
                    string tokenNo = Utility.GetStringPart(dgvAppointment.Rows[i].Cells[1].Value.ToString(), "\r\n");
                    for (int lst = 0; lst < oPatTime.Count; lst++)
                    {
                        if (tokenNo == oPatTime[lst].TokenNo)
                        {
                            dgvAppointment.Rows[i].Cells[1].Style.BackColor = Color.Crimson;
                            dgvAppointment.Rows[i].Cells[1].Style.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private void DataGridRefresh(string startDate)
        {
            List<OpdAppointment> oPatTime = clnt.SingleDayPatientList(departmentId, unitId, doctorId, startDate).ToList();
            for (int col = 0; col < dgvAppointment.Columns.Count; col++)
            {
                if (dgvAppointment.Columns[col].Name != "Time")
                {
                    string date = Utility.GetStringPart(dgvAppointment.Columns[col].HeaderCell.Value.ToString(), "\r\n");
                    for (int patTime = 0; patTime < oPatTime.Count; patTime++)
                    {
                        string patDate = oPatTime[patTime].AppointDate; ;
                        if (date == patDate)
                        {
                            string pattime = oPatTime[patTime].ApproxSTime;
                            for (int x = 0; x < dgvAppointment.Rows.Count; x++)
                            {
                                if (dgvAppointment.Rows[x].Cells[col - 1].Value != null && dgvAppointment.Rows[x].Cells[col - 1].Value.ToString() != "")
                                {
                                    if (pattime.Trim() == dgvAppointment.Rows[x].Cells[col - 1].Value.ToString().Trim())
                                    {
                                        dgvAppointment.Rows[x].Height = dgvAppointment.Rows[x].Height + 15;
                                        dgvAppointment.Rows[x].Cells[col].Value = oPatTime[patTime].TokenNo + "\r\n" + oPatTime[patTime].Patient.Name;
                                        dgvAppointment.Rows[x].Cells[col].Style.ForeColor = Color.Blue;
                                        dgvAppointment.Rows[x].Cells[col].Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
   

        public bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                return false;
            }
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
           // if (nmrYear.Text !=  && nmrMonth.Text == null && nmrDay.Text == null)
           // {
            List<string> vf = new List<string>() { "cboDeptID", "cboUnitID", "cboDoctorID", "txtVisitorName", "cboGender", "rdTextDepartmentId", "rdTextUnit", "rdTextDoctorId", "nmrYear", "lblStartTime", "txtVisitorAddress" };

                Control control = Utility.ReqFieldValidator(this, vf);

                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
           // }
            
            try
            {
                if (nmrMobile.Text != string.Empty)
                {
                    if (nmrMobile.TextLength != 11)
                    {
                        MessageBox.Show("Mobile number should be 11 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        nmrMobile.Focus();
                        return;
                    }
                }
                if (txtEmail.Text != string.Empty)
                {
                    bool emailvarification=IsValidEmailAddress(txtEmail.Text);
                    //if (!SavePreRequisit())
                    //{
                    //    return;
                    //}
                    //string email = txtEmail.Text;
                    //Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                    //Match match = regex.Match(email);
                    if (!emailvarification)
                    {                        
                        MessageBox.Show("Your Email is incorrect,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        //MessageBox.Show("Your Email is incorrect,Please Check!!!");
                        return;
                    }
                }
                if (txtHCN.Text.Length > 0)
                {
                    patList = clnt.GetPatientDetailsAppointment(txtHCN.Text).ToList();
                    if (patList.Count > 0)
                    {
                        LoadPatient(patList.First());
                    }

                    else
                    {
                        MessageBox.Show("Invalid HCN or Mobile Number,Please check!!");
                        btnNew.PerformClick();
                        return;
                    }
                }
                OpdAppointment oOpdAppoint = this.PopulatePatientInfo();
                short i = clnt.InsertOpdAppointment(oOpdAppoint);

                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i == 1)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridRefresh(appointmentDate);
                    btnNew.PerformClick();
                    txtHCN.Select();
                }
                else if (i == 2)
                {
                    MessageBox.Show("Already Patient is Appointed on this time ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 //   btnNew.PerformClick();
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

          //  this.Close();
           
        }
        private OpdAppointment PopulatePatientInfo()
        {
            OpdAppointment oOpdAppoint = new OpdAppointment();

            oOpdAppoint.VisitType = cboVisitType.SelectedValue.ToString();
            oOpdAppoint.ServiceID = "C";

            Department oDept = new Department();
            oDept.DepartmentID = departmentId;
            oOpdAppoint.Department = oDept;

            DepartmentUnit oDTU = new DepartmentUnit();
            oDTU.UnitId =unitId;
            oOpdAppoint.DepartmentUnit = oDTU;

            Doctor oDoc = new Doctor();
            oDoc.ID = doctorId;
            oOpdAppoint.Doctor = oDoc;

            oOpdAppoint.BookingType =cboBookingType.SelectedValue.ToString();
            oOpdAppoint.AppointmentMode = cboBookingMode.SelectedValue.ToString();

           
            Patient oPat = new Patient();
            oPat.Name = txtVisitorName.Text;

            APMSSR.Age age = new APMSSR.Age();
            if (nmrYear.Text != "")
            { age.Year = int.Parse(nmrYear.Text);
            }
            else
            { age.Year = int.Parse("0"); 
            }
            if (nmrMonth.Text!= "")
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

            oPat.GuardianName="R";
            oPat.CorporateID = "0";
            oPat.Country = cboCountry.SelectedValue.ToString();
            oPat.Email = txtEmail.Text;
            oPat.HCN = txtHCN.Text == "" ? "0" : txtHCN.Text;
            oPat.RelationWithGuardian = "G";
            oPat.Sex = cboGender.SelectedValue.ToString();
            oPat.CellPhone = nmrMobile.Text;
            oPat.HomePhone = nmrPhone.Text;
            oPat.Permanent_H_R_B = txtVisitorAddress.Text;
            oPat.Status =char.Parse("1");
            oOpdAppoint.Patient = oPat;

            oOpdAppoint.ApproxSTime =lblStartTime.Text;
            oOpdAppoint.ApproxETime = lblStartTime.Text;

            //DateTime Date = DateTime.Parse(appointmentDate);
            //string appointDate = Date.ToString("dd-MM-yyyy");

            oOpdAppoint.AppointDate = DateTime.Parse(appointmentDate).ToShortDateString();// dtDate.Value.ToShortDateString();
            oOpdAppoint.VisitorType=cboVisitorType.SelectedValue.ToString ();
            oOpdAppoint.TokenNo = tokenNo.ToString ();
            oOpdAppoint.PackageID = "0";
            oOpdAppoint.BatchID = "0";
            oOpdAppoint.StatusChangeCause = "Others";
            oOpdAppoint.AllowAutonotification = char .Parse ("1");
           
            oOpdAppoint.AppointmentType = "R";
          
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oOpdAppoint.EntryParameter = ep;

            return oOpdAppoint;
        }

        private void txtHCN_KeyUp(object sender, KeyEventArgs e)
        {
            nmrMobile.Text = "";
            if (txtHCN.Text.Length == Utility.ScanLength)
            {
                btnPatientFind_Click(sender, e);
            }

        }

        private void nmrMobile_KeyUp(object sender, KeyEventArgs e)
        {
            if (nmrMobile.Text.Length == 11)
            {
                btnPatientFind_Click(sender, e);
            }
        }
        private void LoadPatientLists()
        {
            lstPatientList.Items.Clear();                                                                                                                                                                
            if (patList.Count > 0)
            {             
                for (int i = 0; i < patList.Count; i++)
                {
                    ListViewItem itm = new ListViewItem(patList[i].HCN);                 
                    itm.SubItems.Add(patList[i].Name);
                    itm.SubItems.Add(patList[i].CellPhone);
                    lstPatientList.Items.Add(itm);

                }
            }

        }
        private void LoadPatient(Patient pat)
        {
            txtVisitorName.Text = pat.Name;
            txtVisitorAddress.Text = pat.Present_H_R_B;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            nmrYear.Text = age.Year.ToString();
            nmrMonth.Text = age.Month.ToString();
            nmrDay.Text = age.Day.ToString();

            if (pat.Sex == "Male")
            {
                cboGender.SelectedIndex = 0;
            }
            if (pat.Sex == "Female")
            {
                cboGender.SelectedIndex = 1;
            }
            if (pat.Sex == "Others")
            {
                cboGender.SelectedIndex = 2;
            }


            //if (pat.Sex == "F")
            //{
            //    cboGender.Text = "Female";
            //    cboGender.Enabled = false;
            //}
            //if (pat.Sex == "M")
            //{
            //    cboGender.Text = "Male";
            //    cboGender.Enabled = false;
            //}
            txtEmail.Text=pat.Email;
            cboCountry.Text=pat.Country;
            txtHCN.Text = pat.HCN;
            nmrMobile.Text = pat.CellPhone;
            nmrPhone.Text = pat.HomePhone;
            txtVisitorName.Enabled = false;
            nmrMonth.Enabled = false;
            nmrDay.Enabled = false;
            nmrYear.Enabled = false;
            txtDOB.Enabled = false;
            txtVisitorAddress.Enabled = false;
            cboCountry.Enabled = false;
            txtEmail.Enabled = false;
            nmrPhone.Enabled = false;
            cboGender.Enabled = false;

        }

        private void btnPatientFind_Click(object sender, EventArgs e)
        {                    
            if (nmrMobile.Text != string.Empty && txtHCN.Text=="")
            {
                if (nmrMobile.MaxLength == 11)
                {
                    patList.Clear();
                    patList = clnt.GetPatientDetailsAppointment(nmrMobile.Text).ToList();              
                }
            }
           
           if (txtHCN.Text != "" && nmrMobile.Text == "")
            {
                patList.Clear();
                patList = clnt.GetPatientDetailsAppointment(txtHCN.Text).ToList();
            }
           if (patList.Count == 0)
           {
               MessageBox.Show("No Match found ,Please check!!");              
               //btnNew.PerformClick();
               return;
           }
            if (patList.Count == 1)
            {
                LoadPatient(patList.First());
            }
            if (patList.Count>1)
            {
                lstPatientList.Visible = true;
                lstPatientList.Location = new Point(334, 3); 
                    
                    //panel1.SendToBack nmrMobile.Top + nmrMobile.Height;
                lstPatientList.Left = nmrMobile.Left;
                LoadPatientLists();
                nmrMobile.Text = "";
                //panel1.SendToBack();
                //panel4.SendToBack();
                //dgvAppointment.SendToBack();
                //lstPatientList.BringToFront();
            }
            //if (patList.Count > 0)
            //{
            //    LoadPatient(patList.First());
            //}
            //else
            //{
            //    MessageBox.Show("Invalid HCN or Mobile Number,Please check!!");
            //    btnNew.PerformClick();
            //    return;
            //}

        }

    
        private void btnNew_Click(object sender, EventArgs e)
        {
            rdTextDepartmentId.Text = departmentName;
            rdTextUnit.Text = unitName;
            rdTextDoctorId.Text = doctorName;
            txtHCN.Clear();
            nmrMobile.Clear();
            txtVisitorName.Clear();
            txtVisitorAddress.Clear();
            nmrYear.Clear();
            nmrMonth.Clear();
            nmrDay.Clear();
            txtEmail.Clear();
            nmrPhone.Clear();
            txtVisitorName.Enabled = true;
            nmrMonth.Enabled = true;
            nmrDay.Enabled = true;
            nmrYear.Enabled = true;
            txtDOB.Enabled = true;
            txtVisitorAddress.Enabled = true;
            cboCountry.Enabled = true;
            txtEmail.Enabled = true;
            cboGender.Enabled = true;
            nmrPhone.Enabled = true;
            cboGender.Enabled = true;
           // lstPatientList.Clear();
            lstPatientList.Items.Clear();
            lstPatientList.Visible = false;

            txtDOB.Text = "";
        }

      
        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvAppointment.Columns[e.ColumnIndex].Name != "Time")
                {
                    if (dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null && dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value != null)
                    {
                        lblStartTime.Text = "";
                        lblStartTime.Text = dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();
                        tokenNo = e.RowIndex + 1;
                        txtHCN.Focus();
                    }

                }
            }
        }

        private void dgvAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtHCN_Leave(object sender, EventArgs e)
        {
            txtHCN.Text = txtHCN.Text.ToUpper();
        }

      
        private void lblAproxTimeFrom_Click(object sender, EventArgs e)
        {

        }
        private DUtility.Age PopulateAge(string ageYears, string ageMonths, string ageDays)
        {
            DUtility.Age age = new DUtility.Age();
            age.Year = ageYears.Length > 0 ? int.Parse(ageYears) : 0;
            age.Month = ageMonths.Length > 0 ? int.Parse(ageMonths) : 0;
            age.Day = ageDays.Length > 0 ? int.Parse(ageDays) : 0;
            return age;
        }

        private void nmrYear_Leave(object sender, EventArgs e)
        {
            if (nmrYear.Text != "")
            {
                if (Convert.ToInt32(nmrYear.Text) < 150)
                {
                    DUtility.Age age = PopulateAge(nmrYear.Text, nmrMonth.Text, nmrDay.Text);
                    txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("Are you sure about the age???", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCN.Focus();
                    // nmrYear.Focus();
                }
            }

        }

        private void nmrMonth_Leave(object sender, EventArgs e)
        {
            if (nmrMonth.Text != "")
            {
                DUtility.Age age = PopulateAge(nmrYear.Text, nmrMonth.Text, nmrDay.Text);
                txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
                   
            }

        }

        private void nmrDay_Leave(object sender, EventArgs e)
        {
            if (nmrDay.Text != "")
            {
                DUtility.Age age = PopulateAge(nmrYear.Text, nmrMonth.Text, nmrDay.Text);
                txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");                 
            }
        }

        private void nmrYear_TextChanged(object sender, EventArgs e)
        {
            if (nmrYear.Text != "")
            {
                if (Convert.ToInt32(nmrYear.Text) < 150)
                {
                    DUtility.Age age = PopulateAge(nmrYear.Text, nmrMonth.Text, nmrDay.Text);
                    txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("Are you sure about the age???", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCN.Focus();              
                }
            }
        }

        private void nmrMonth_TextChanged(object sender, EventArgs e)
        {
            if (nmrMonth.Text != "")
            {
                DUtility.Age age = PopulateAge(nmrYear.Text, nmrMonth.Text, nmrDay.Text);
                txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");

            }

        }

        private void nmrDay_TextChanged(object sender, EventArgs e)
        {
            if (nmrDay.Text != "")
            {
                DUtility.Age age = PopulateAge(nmrYear.Text, nmrMonth.Text, nmrDay.Text);
                txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
            }

        }

        private void txtDOB_Validated(object sender, EventArgs e)
        {
            if (txtDOB.Text != "" && txtDOB.Text.Trim().Length == 10)
            {
                if (txtDOB.Text.Length == 10 && DateTime.Parse(txtDOB.Text.Trim()) <= DateTime.Now.Date)
                {                
                    AH.DUtility.Age age = Utility.CalculateAge(DateTime.Parse(txtDOB.Text));
                    nmrYear.Text = age.Year.ToString();
                    nmrMonth.Text = age.Month.ToString();
                    nmrDay.Text = age.Day.ToString();               
                }
                else
                {
                    MessageBox.Show("Invalid Date of Birth");
                    nmrYear.Text = "";
                    nmrMonth.Text = "";
                    nmrDay.Text = "";
                    txtDOB.Text = string.Empty;
                }
              
            }
            else
            {
                nmrYear.Text = "";
                nmrMonth.Text = "";
                nmrDay.Text = "";
            }

        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {
            //if (txtDOB.Text=="")
            //{
            //    nmrYear.Text = "";
            //    nmrMonth.Text = "";
            //    nmrDay.Text = "";
            //}
        }

        private void nmrMobile_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lstPatientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstPatientList.SelectedItems.Count > 0)
                {
                    nmrMobile.Text = "";
                    ListViewItem itm = lstPatientList.SelectedItems[0];
                    txtHCN.Text = itm.SubItems[0].Text;
                    lstPatientList.Visible = false;
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

        private void txtHCN_TextChanged(object sender, EventArgs e)
        {
            nmrMobile.Text = "";
            nmrMobile.Enabled = true;
            if (txtHCN.Text.Length == Utility.ScanLength)
            {
                txtHCN.Text = txtHCN.Text.ToUpper();
                btnPatientFind_Click(sender, e);
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            lstPatientList.Visible = false;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            lstPatientList.Visible = false;

        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            lstPatientList.Visible = false;
        }
        private void txtVisitorName_MouseClick(object sender, MouseEventArgs e)
        {
            lstPatientList.Visible = false;
        } 
   
    }
}
