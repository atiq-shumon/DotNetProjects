
//Developed by   : Shabnam
//Date           : 6-08-2014
//Purpose        : Appointment Availability Checking Form / Register Appointment


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.Shared.UI;
using AH.DUtility;
using System.Linq;
using AH.ModuleController.APMSSR;


namespace AH.ModuleController.UI.APMS.Forms
{
    public partial class frmAppointment : AH.Shared.UI.frmSmartFormStandard
    {
        APMSWSClient clnt = new APMSWSClient();
        APMSSR.APMSWSClient apmssr = new APMSSR.APMSWSClient();
        List<OPDDoctor> docList;
        string DepartmentUnit = "";
        string Doctor = "";
        int interval;
        public frmAppointment()
        {         
            InitializeComponent();
        }

        private DataGridViewTextBoxColumn FormatColumns(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn Appointcolumn = new DataGridViewTextBoxColumn();
            Appointcolumn.DataPropertyName = pname;
            Appointcolumn.HeaderText = htext;
            Appointcolumn.DefaultCellStyle.ForeColor = Color.Black;
            Appointcolumn.DefaultCellStyle.BackColor = Color.Silver;
            Appointcolumn.Visible = true_false;
            Appointcolumn.DefaultCellStyle.Alignment = Algin;
            Appointcolumn.Width = cwidth;
            Appointcolumn.ReadOnly = true;
            Appointcolumn.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);
            Appointcolumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewCellStyle style = dgvAppointment.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.DodgerBlue;
            style.ForeColor = Color.White;
           
            return Appointcolumn;

        }


        private void AssignAppointment_Grid()
        {
            dgvAppointment.Columns.Add(FormatColumns("", "", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.TopLeft));
            dgvAppointment.Columns.Add(FormatColumns("", "", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.TopLeft));
            dgvAppointment.Columns.Add(FormatColumns("", "", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.TopLeft));
            dgvAppointment.Columns.Add(FormatColumns("", "", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.TopLeft));
            dgvAppointment.Columns.Add(FormatColumns("", "", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.TopLeft));
            dgvAppointment.Columns.Add(FormatColumns("", "", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.TopLeft));
            dgvAppointment.Columns.Add(FormatColumns("", "", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.TopLeft));
            dgvAppointment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

        }
      
        private void cboDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentID.SelectedValue != "")
            {
                cboUnitID.DisplayMember = "Value";
                cboUnitID.ValueMember = "Key";
                cboUnitID.DataSource = new BindingSource(Utility.VerifyDic(clnt.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboDepartmentID.SelectedValue.ToString())), null);
            }
        }

        private void cboUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDoctorID.DisplayMember = "value";
            cboDoctorID.ValueMember = "key";
            if (cboDepartmentID.SelectedValue!="" && cboUnitID.SelectedValue!="")
                cboDoctorID.DataSource = new BindingSource(Utility.VerifyDic(clnt.GetOPDDoctorsDict(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString())), null);

            
            if (DepartmentUnit != "")
            {
                cboUnitID.Text = DepartmentUnit;
            }         
        }

        string date = "";
        List<string> oTDCs = new List<string>();
        List<string> oTimes = new List<string>();
        List<string> oDocTimes = new List<string>();

        private void btnShow_Click(object sender, EventArgs e)
        {
           
            List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            bool isRowCreated = false;
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            oTimes.Clear();
            DateTime startD = dptStartDate.Value;
            DateTime endD = dptEndDate.Value;
            if (startD >= DateTime.Now.Date && endD >= DateTime.Now.Date)
            {
                dgvAppointment.TopLeftHeaderCell.Value = "Time";
                DateTime dt1 = DateTime.Parse("08:00AM");
                DateTime dt2 = DateTime.Parse("10:00PM");               
                while (dt1 <= dt2)
                {
                    oTimes.Add(dt1.ToString("hh : mm tt"));
                    dt1 = dt1.AddMinutes(interval);
                }

                dgvAppointment.Columns.Clear();
                dgvAppointment.Rows.Clear();
                dgvAppointment.DataSource = null;
            
                string startDate = dptStartDate.Value.ToString("dd/MM/yyyy");
                string endDate = dptEndDate.Value.ToString("dd/MM/yyyy");
                List<DoctorWeekDays> odvd = clnt.GetDoctorVSTcal(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();
                if (odvd.Count != 0)
                {
                    List<DoctorWeekDays> oDoctorDutyTiming = clnt.GetDoctorDutyTiming(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();
                    for (int rcont = 0; rcont < odvd.Count; rcont++)
                    {
                        dgvAppointment.Columns.Add(FormatColumns("", "", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
                        if(!isRowCreated){
                                for (int rcnt = 0; rcnt < oTimes.Count; rcnt++)
                                {
                                    dgvAppointment.Rows.Add();
                                    dgvAppointment.Rows[0].Cells[0].Selected = false;
                                    dgvAppointment.Rows[rcnt].HeaderCell.Value = oTimes[rcnt].ToString().Trim();
                                }
                                isRowCreated = true;
                        }
                        string sTo = odvd[rcont].VisitDate.ToString("dd-MM-yyyy");
                        string day = odvd[rcont].VisitDate.ToString("dddd");
                        date = sTo + "\r\n" + day;
                        dgvAppointment.Columns[rcont].HeaderCell.Value = date;

                        for (int i = 0; i < oDoctorDutyTiming.Count; i++)
                        {
                            string vDate = oDoctorDutyTiming[i].VisitDate.ToString("dd-MM-yyyy");
                            if (sTo == vDate)
                            {
                                oDocTimes.Clear();
                                string vTime = oDoctorDutyTiming[i].StartTime;
                                string StartTime = vTime.Substring(0, 10);
                                string EndTime = vTime.Substring(11, 10);
                                DateTime Start = DateTime.Parse(StartTime);
                                DateTime End = DateTime.Parse(EndTime);
                                while (Start <= End)
                                {
                                    oDocTimes.Add(Start.ToString("hh : mm tt"));
                                    Start = Start.AddMinutes(10);
                                }

                                for (int x = 0; x < oTimes.Count; x++)
                                {
                                    for (int y = 0; y < oDocTimes.Count; y++)
                                    {
                                        if (oTimes[x] == oDocTimes[y])
                                        {
                                            dgvAppointment.Rows[x].Cells[rcont].Style.BackColor = Color.White;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Doctor Schedule is not Assign on these days, Please check !!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                 
                }
            }
            else
            {
                MessageBox.Show("The end Date must be greater than the start Date, Please check !!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
        }

        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.White && dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    //frmAppointmentRegistration frmVisitReg = new frmAppointmentRegistration(dgvAppointment.Rows[e.RowIndex].HeaderCell.Value.ToString(), dgvAppointment.Columns[e.ColumnIndex].HeaderCell.Value.ToString(), cboDepartmentID.SelectedValue.ToString(),
                    //cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), cboDepartmentID.Text.ToString(), cboDoctorID.Text.ToString(), cboUnitID.Text.ToString(), dptStartDate.Value.ToString("dd/MM/yyyy"), dptEndDate.Value.ToString("dd/MM/yyyy"),1);
                    //frmVisitReg.ShowDialog();
                    //btnDisplay.PerformClick();
                    //dgvAppointment.CurrentCell = dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
                else if (dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.White && dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    frmAppointPatientInfo frmPat = new frmAppointPatientInfo(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), dptStartDate.Value.ToString("dd/MM/yyyy"), dptEndDate.Value.ToString("dd/MM/yyyy"), dgvAppointment.Columns[e.ColumnIndex].HeaderCell.Value.ToString());
                    frmPat.ShowDialog();
                    btnDisplay.PerformClick();
                }

                else if (dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "OFF TIME")
                {
                    dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = " ";
                }
                else
                {
                    dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "OFF TIME";
                }

            }
           
        }
       
        private void DataGridRefresh()
        {          
          
        }
   
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            bool isRowCreated = false;
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            dgvAppointment.DataSource = null;
            dgvAppointment.Columns.Clear();
            dgvAppointment.Rows.Clear();

            oTimes.Clear();        
            dgvAppointment.TopLeftHeaderCell.Value = "Time";
            dgvAppointment.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
            interval = clnt.GetDoctorTimingInterval(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), dptStartDate.Value.ToString("dd-MM-yyyy"), dptEndDate.Value.ToString("dd-MM-yyyy"));
            if (interval > 0)
            {
                DateTime dt1 = DateTime.Parse("08:00AM");
                DateTime dt2 = DateTime.Parse("10:00PM");
                while (dt1 <= dt2)
                {
                    oTimes.Add(dt1.ToString("hh : mm tt"));
                    dt1 = dt1.AddMinutes(interval);
                }
            }

            DateTime startD = dptStartDate.Value;
            DateTime endD = dptEndDate.Value;

            if (startD >= DateTime.Now.Date && endD >= DateTime.Now.Date)
            {

                string startDate = dptStartDate.Value.ToString("dd/MM/yyyy");
                string endDate = dptEndDate.Value.ToString("dd/MM/yyyy");

                List<DoctorWeekDays> odvd = clnt.GetDoctorVSTcal(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();
                List<DoctorWeekDays> oDoctorDutyTiming = clnt.GetDoctorDutyTiming(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();
                List<OpdAppointment> oPatTime = clnt.GetPatientName(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();
                if (odvd.Count != 0)
                {
                    for (int rcont = 0; rcont < odvd.Count; rcont++)
                    {

                        dgvAppointment.Columns.Add(FormatColumns("", "", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
                        if (!isRowCreated)
                        {
                            for (int rcnt = 0; rcnt < oTimes.Count; rcnt++)
                            {
                                dgvAppointment.Rows.Add();
                                dgvAppointment.Rows[0].Cells[0].Selected = false;
                                dgvAppointment.Rows[rcnt].HeaderCell.Value = oTimes[rcnt].ToString();
                              
                            }
                            isRowCreated = true;
                        }
                        string sTo = odvd[rcont].VisitDate.ToString("dd-MM-yyyy");
                        string day = odvd[rcont].VisitDate.ToString("dddd");
                        date = sTo + "\r\n" + day;
                        dgvAppointment.Columns[rcont].HeaderCell.Value = date;
                        dgvAppointment.Columns[rcont].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        for (int i = 0; i < oDoctorDutyTiming.Count; i++)
                        {
                            string vDate = oDoctorDutyTiming[i].VisitDate.ToString("dd-MM-yyyy");
                            if (sTo == vDate)
                            {
                                oDocTimes.Clear();
                                string vTime = oDoctorDutyTiming[i].StartTime.Trim();
                                string StartTime = vTime.Substring(0, 8);
                                string EndTime = vTime.Substring(9, 8);
                                DateTime Start = DateTime.Parse(StartTime);
                                DateTime End = DateTime.Parse(EndTime);
                                while (Start <= End)
                                {
                                    oDocTimes.Add(Start.ToString("hh : mm tt"));
                                    Start = Start.AddMinutes(interval);
                                }

                                for (int x = 0; x < oTimes.Count; x++)
                                {
                                    for (int y = 0; y < oDocTimes.Count; y++)
                                    {
                                        if (oTimes[x] == oDocTimes[y])
                                        {
                                            dgvAppointment.Rows[x].Cells[rcont].Style.BackColor = Color.White;
                                        }
                                    }
                                }
                            }
                        }
                        for (int patTime = 0; patTime < oPatTime.Count; patTime++)
                        {
                            string patDate = oPatTime[patTime].AppointDate;
                            if (sTo == patDate)
                            {
                                string pattime = oPatTime[patTime].ApproxSTime;
                                for (int x = 0; x < oTimes.Count; x++)
                                {
                                    if (pattime == oTimes[x])
                                    {
                                        dgvAppointment.Rows[x].Height = dgvAppointment.Rows[x].Height + 15;
                                        dgvAppointment.Rows[x].Cells[rcont].Value = oPatTime[patTime].TokenNo + "\r\n" + oPatTime[patTime].Patient.Name;
                                        dgvAppointment.Rows[x].Cells[rcont].Style.ForeColor = Color.Blue;      
                                        dgvAppointment.Rows[x].Cells[rcont].Style.Font = new Font("Tahoma", 10, FontStyle.Bold);                                            
                                    }
                                }
                            }
                        }
                    }
                }
                  
                else 
                    {
                        MessageBox.Show("Doctor is not available, Please check !!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                      
                    }
            }
            else
            {
                MessageBox.Show("The date must be greater than or equal from today's date, Please check !!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);              
            }
        }

    
        private void dgvAppointment_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "OFF TIME")
            {
                dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = " ";
            }
        }
     
        private void frmAppointment_Load(object sender, EventArgs e)
        {
            cboDepartmentID.DisplayMember = "Value";
            cboDepartmentID.ValueMember = "Key";
            cboDepartmentID.DataSource = new BindingSource(Utility.VerifyDic(clnt.GetDepartmentsetup("D", Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);

            docList = clnt.GetOPDDoctors().ToList();
            FormatGrid();
            FormatGridDoctorList();
            lstDoctorName.Visible = false;
            lstTodayDoctorList.Visible = false;
            lstDoctorName.Height = 200;
            lstDoctorName.Width = 600;
            lstTodayDoctorList.Height = 200;
            lstTodayDoctorList.Width = 800;
            txtDoctorName.Text = "";          
            
           
        }
        private void SearchListDoctorList(IEnumerable<OPDDoctor> docList, string searchString = "")
        {
            IEnumerable<OPDDoctor> query;
            if (!(searchString.Length > 0))
            {
                query = docList;
            }
            else
            {
                query = (from doctorName in docList
                         where doctorName.Doctor.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select doctorName);
            }
            lstTodayDoctorList.Visible = false;
            lstDoctorName.Items.Clear();
            lstDoctorName.Visible = true;
            lstDoctorName.Top = txtDoctorName.Top + txtDoctorName.Height;
            lstDoctorName.Left = txtDoctorName.Left;
            foreach (OPDDoctor OpdDr in query)
            {
                ListViewItem itm = new ListViewItem(OpdDr.Doctor.ID);             
                itm.SubItems.Add(OpdDr.Doctor.Name.ToString());
                itm.SubItems.Add(OpdDr.Department.DepartmentID.ToString());
                itm.SubItems.Add(OpdDr.Department.DepartmentTitle.ToString());
                itm.SubItems.Add(OpdDr.DepartmentUnit.UnitId.ToString());
                itm.SubItems.Add(OpdDr.DepartmentUnit.UnitTitle.ToString());           
                lstDoctorName.Items.Add(itm);
            }
        }
        private void FormatGrid()
        {
            lstDoctorName.CheckBoxes = false;
            lstDoctorName.Columns.Add("DoctorId", 0, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Doctor Name", 250, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Department Id", 0, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Department Name", 100, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Unit Id",0, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Unit Name", 150, HorizontalAlignment.Left);
         
        }
       private void FormatGridDoctorList()
        {
            lstTodayDoctorList.CheckBoxes = false;
            lstTodayDoctorList.Columns.Add("DoctorId", 0, HorizontalAlignment.Left);
            lstTodayDoctorList.Columns.Add("Doctor Name", 250, HorizontalAlignment.Left);
            lstTodayDoctorList.Columns.Add("Appoint Date", 100, HorizontalAlignment.Center);
            lstTodayDoctorList.Columns.Add("Day", 80, HorizontalAlignment.Center);
            lstTodayDoctorList.Columns.Add("Appoint Time", 90, HorizontalAlignment.Left);       
            lstTodayDoctorList.Columns.Add("Department Id", 0, HorizontalAlignment.Left);
            lstTodayDoctorList.Columns.Add("Department Name", 100, HorizontalAlignment.Left);
            lstTodayDoctorList.Columns.Add("Unit Id", 0, HorizontalAlignment.Left);
            lstTodayDoctorList.Columns.Add("Unit Name", 180, HorizontalAlignment.Left);           
        }      
        private void txtDoctorName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListDoctorList(docList, txtDoctorName.Text);
        }

        private void lstDoctorName_SelectedIndexChanged(object sender, EventArgs e)
        {
             Doctor = "";
            if (lstDoctorName.SelectedItems.Count > 0)
            {
                ListViewItem itm = lstDoctorName.SelectedItems[0];              
                cboDepartmentID.Text=itm.SubItems[2].Text;              
              
                cboDoctorID.Text= itm.SubItems[1].Text;
                txtDoctorName.Text = itm.SubItems[1].Text;
                DepartmentUnit = itm.SubItems[5].Text;
                Doctor = itm.SubItems[1].Text;
                cboUnitID.Text = DepartmentUnit;
            }
            lstDoctorName.Visible=false;
        }

        private void cboDoctorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Doctor != "")
            {
                cboDoctorID.Text = Doctor;
            }
        }
        private void txtDoctorName_Enter(object sender, EventArgs e)
        {
            SearchListDoctorList(docList, txtDoctorName.Text);
        }      
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            lstDoctorName.Visible = false;
            lstTodayDoctorList.Visible = false;
        }
    
        private void dgvAppointment_Click(object sender, EventArgs e)
        {
            lstDoctorName.Visible = false;
            lstTodayDoctorList.Visible = false;
        }

        private void btnDocList_Click(object sender, EventArgs e)
        {
            txtDoctorName.Text = "";
            lstDoctorName.Visible = false;
            lstTodayDoctorList.Visible = true;
            lstTodayDoctorList.Top = btnDocList.Top + btnDocList.Height;
            lstTodayDoctorList.Left = btnDocList.Left;              
            LoadListViewDoctorList();
        }
        private void LoadListViewDoctorList()
        {
            lstTodayDoctorList.Items.Clear();
            List<DoctorWeekDays> oDoctorList = clnt.GetTodaysDoctorList().ToList();

            foreach (DoctorWeekDays oDoctor in oDoctorList)
            {
                ListViewItem itm = new ListViewItem(oDoctor.Doctor.ID);               
                itm.SubItems.Add(oDoctor.Doctor.Name);
                itm.SubItems.Add(oDoctor.VisitDate.ToString("dd-MM-yyyy"));
                itm.SubItems.Add(oDoctor.WeekDayName);
                itm.SubItems.Add(oDoctor.StartTime + "-" + oDoctor.EndTime);
                lstTodayDoctorList.Items.Add(itm);
                itm.SubItems.Add(oDoctor.Department.DepartmentID);
                itm.SubItems.Add(oDoctor.Department.DepartmentTitle);
                itm.SubItems.Add(oDoctor.DepartmentUnit.UnitId);
                itm.SubItems.Add(oDoctor.DepartmentUnit.UnitTitle);
                 
            }

        }

        private void lstTodayDoctorList_SelectedIndexChanged(object sender, EventArgs e)
        {
          Doctor = "";
            if (lstTodayDoctorList.SelectedItems.Count > 0)
            {              
                ListViewItem itm = lstTodayDoctorList.SelectedItems[0];
                cboDepartmentID.Text = itm.SubItems[6].Text;
                cboDoctorID.Text = itm.SubItems[1].Text;         
                DepartmentUnit = itm.SubItems[8].Text;
                Doctor = itm.SubItems[1].Text;
                cboUnitID.Text = DepartmentUnit;               
            }
            btnDisplay.PerformClick();
            lstTodayDoctorList.Visible = false;
        }
   
        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            lstDoctorName.Visible = false;
            lstTodayDoctorList.Visible = false;
        }

        private void txtDoctorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dgvAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
