
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
    public partial class frmAppointmentRegis : AH.Shared.UI.frmSmartFormStandard
    {
        APMSWSClient clnt = new APMSWSClient();
        APMSSR.APMSWSClient apmssr = new APMSSR.APMSWSClient();
        List<OPDDoctor> docList;
        string DepartmentUnit = "";
        string Doctor = "";
       // int interval;
        List<DoctorWeekDays> oDoctorDutyTiming = new List<DoctorWeekDays>();     
        public frmAppointmentRegis()
        {         
            InitializeComponent();
        }

        private DataGridViewTextBoxColumn FormatColumns(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn Appointcolumn = new DataGridViewTextBoxColumn();
            Appointcolumn.DataPropertyName = pname;
            Appointcolumn.Name = pname;
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
            if (cboDepartmentID.SelectedValue != "" && cboUnitID.SelectedValue != "")
            {
                cboDoctorID.DataSource = new BindingSource(Utility.VerifyDic(clnt.GetOPDDoctorsDict(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString())), null);
            }
            if (DepartmentUnit != "")
            {
                cboUnitID.Text = DepartmentUnit;
                DepartmentUnit = "";
            }
           
        }

        string date = "";
        List<string> oTDCs = new List<string>();
        List<string> oTimes = new List<string>();
        List<string> oDocTimes = new List<string>();

        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                if (dgvAppointment.Columns[e.ColumnIndex].Name != "Time")
                {
                    if (dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null
                               && dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null &&
                               dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Crimson)
                    {
                        List<string> oTimes = new List<string>();
                        oTimes.Clear();

                        for (int row = 0; row < dgvAppointment.Rows.Count; row++)
                        {
                            if (dgvAppointment.Rows[row].Cells[e.ColumnIndex - 1].Value != null)
                            {
                                oTimes.Add(dgvAppointment.Rows[row].Cells[e.ColumnIndex - 1].Value.ToString());
                            }
                            else
                            {
                                break;
                            }
                        }
                        frmAppointmentRegistration frmVisitReg = new frmAppointmentRegistration(dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString(),
                                                                                                Utility.GetStringPart(dgvAppointment.Columns[e.ColumnIndex].HeaderCell.Value.ToString(), "\r\n"),
                                                                                                cboDepartmentID.SelectedValue.ToString(),
                                                                                                cboUnitID.SelectedValue.ToString(),
                                                                                                cboDoctorID.SelectedValue.ToString(),
                                                                                                cboDepartmentID.Text.ToString(),
                                                                                                cboDoctorID.Text.ToString(),
                                                                                                cboUnitID.Text.ToString(),
                                                                                                dptStartDate.Value.ToString("dd/MM/yyyy"),
                                                                                                dptEndDate.Value.ToString("dd/MM/yyyy"), e.RowIndex + 1, oTimes);
                        frmVisitReg.ShowDialog();

                    }
                    if (dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null && dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null
                         && dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Crimson && dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor!=Color.GreenYellow)
                    {
                        frmAppointPatientInfo frmPat = new frmAppointPatientInfo(cboDepartmentID.SelectedValue.ToString(),
                            cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(),
                            dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),
                            dptStartDate.Value.ToString("dd/MM/yyyy"), dptEndDate.Value.ToString("dd/MM/yyyy"),
                            dgvAppointment.Columns[e.ColumnIndex].HeaderCell.Value.ToString());
                        frmPat.ShowDialog();
                    }
                    if (dgvAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Crimson)
                    {
                        MessageBox.Show("Prescription Complete!");
                    }
                    btnDisplay.PerformClick();
                    dgvAppointment.Rows[0].Cells[0].Selected = false;
                }
            }
               
        }

        private void DataGridRefresh(string startDate, string endDate)
        {         
            List<OpdAppointment> oPatTime = clnt.GetPatientName(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();
            for (int col = 0; col < dgvAppointment.Columns.Count; col++)
            {
                if (dgvAppointment.Columns[col].Name!="Time")
                {
                    string date = Utility.GetStringPart(dgvAppointment.Columns[col].HeaderCell.Value.ToString(), "\r\n");
                    for (int patTime = 0; patTime < oPatTime.Count; patTime++)
                    {
                        string patDate = oPatTime[patTime].AppointDate; ;
                        if (date== patDate)
                        {
                            string pattime = oPatTime[patTime].ApproxSTime;
                            for (int x = 0; x < dgvAppointment.Rows.Count; x++)
                            {
                                if (dgvAppointment.Rows[x].Cells[col - 1].Value!= null && dgvAppointment.Rows[x].Cells[col - 1].Value.ToString() != "")
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
   
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                dgvAppointment.DataSource = null;
                dgvAppointment.Columns.Clear();
                dgvAppointment.Rows.Clear();

                int v = 1;
                if (dptStartDate.Value >= DateTime.Now.Date && dptEndDate.Value >= DateTime.Now.Date)
                {
                    string startDate = dptStartDate.Value.ToString("dd/MM/yyyy");
                    string endDate = dptEndDate.Value.ToString("dd/MM/yyyy");
                    oDoctorDutyTiming.Clear();
                    List<DoctorWeekDays> odvd = clnt.GetDoctorVSTcal(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();

                    oDoctorDutyTiming = clnt.GetDoctorDutyTiming(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();

                    if (odvd.Count > 0)
                    {
                        for (int rcont = 0; rcont < odvd.Count; rcont++)
                        {
                            dgvAppointment.Columns.Add(FormatColumns("Time", "Time", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
                            dgvAppointment.Columns.Add(FormatColumns("", "", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));

                            date = odvd[rcont].VisitDate.ToString("dd-MM-yyyy") + "\r\n" + odvd[rcont].VisitDate.ToString("dddd");
                            dgvAppointment.Columns[rcont + v].HeaderCell.Value = date;
                            dgvAppointment.Columns[rcont].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvAppointment.Columns[rcont + v].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            v++;
                        }
                        Addtime(startDate, endDate);
                        DataGridRefresh(startDate, endDate);
                        ColourGrid();
                        //if(dgvAppointment.Columns.Count<3)
                        //{
                        TicketOkPatientList(Utility.GetStringPart(dgvAppointment.Columns[1].HeaderCell.Value.ToString(), "\r\n"));
                        // }

                        //if (dgvAppointment.Columns.Count < 3)
                        //{
                        prescribedPatient(Utility.GetStringPart(dgvAppointment.Columns[1].HeaderCell.Value.ToString(), "\r\n"));
                        // }

                    }

                    else
                    {
                        MessageBox.Show("Doctor is not available on this date range, Please check !!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dptStartDate.Select();
                    }
                }
                else
                {
                    MessageBox.Show("The date must be greater than or equal from today's date, Please check !!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Addtime(string startDate, string endDate)
        {
            for (int row = 0; row < 300; row++)
            {
                dgvAppointment.Rows.Add();
            }
            List<DoctorWeekDays> oDoctorDutyTiming = new List<DoctorWeekDays>();
             oDoctorDutyTiming = clnt.GetDoctorDutyTiming(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();          
            for (int col=0;col<dgvAppointment.Columns.Count;col++)
            {
                if(dgvAppointment.Columns[col].Name!="Time")
                {
                    string date = Utility.GetStringPart(dgvAppointment.Columns[col].HeaderCell.Value.ToString(), "\r\n");
                    for (int i = 0; i < oDoctorDutyTiming.Count; i++)
                    {
                        int r = 0;
                        if(date==oDoctorDutyTiming[i].VisitDate.ToString("dd-MM-yyyy"))
                        {
                            oDocTimes.Clear();

                            string vTime = oDoctorDutyTiming[i].StartTime.Trim();
                            DateTime Start = DateTime.Parse(vTime.Substring(0, 8));
                            DateTime End = DateTime.Parse(vTime.Substring(9, 8));
                            while (Start <= End)
                            {
                                oDocTimes.Add(Start.ToString("hh : mm tt"));
                                Start = Start.AddMinutes(oDoctorDutyTiming[i].Interval);
                            }
                            for(int row=0;row<dgvAppointment.Rows.Count;row++)
                            {
                                if(dgvAppointment.Rows[row].Cells[col-1].Value==null)
                                {
                                    r = row;
                                    break;
                                }
                            }
                            for(int t=0;t<oDocTimes.Count;t++)
                            {
                                dgvAppointment.Rows[r].Cells[col - 1].Value = oDocTimes[t].ToString();
                                r++;
                            }
                        }

                    }

                }
            }
           
            //List<DoctorWeekDays> oDoctorDutyTiming = clnt.GetDoctorDutyTiming(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();          
            //int c = 0;              
            //        for (int i = 0; i < oDoctorDutyTiming.Count; i++)
            //        {                       
            //            oDocTimes.Clear();

            //            string vTime = oDoctorDutyTiming[i].StartTime.Trim();
            //            DateTime Start = DateTime.Parse(vTime.Substring(0, 8));
            //            DateTime End = DateTime.Parse(vTime.Substring(9, 8));                     
            //            while (Start <= End)
            //            {                                           
            //                oDocTimes.Add(Start.ToString("hh : mm tt"));
            //                Start = Start.AddMinutes(oDoctorDutyTiming[i].Interval);
            //            }
            //            for (int y = 0; y < oDocTimes.Count; y++)
            //            {

            //                dgvAppointment.Rows[y].Cells[c].Value = oDocTimes[y].ToString();                         
            //            }
            //            c = c + 2;  
            //     }

        }
       private void ColourGrid()
       {
           for (int i = 0; i <dgvAppointment.Columns.Count; i++)
           {
               if (i % 2!= 0)
                   dgvAppointment.Columns[i].DefaultCellStyle.BackColor = Color.White;
               else
                   dgvAppointment.Columns[i].DefaultCellStyle.BackColor = Color.OldLace;

           }
           int maxRow = 0;
           for (int j = 0; j < dgvAppointment.Columns.Count-1 ; j++)
           {             
               if (dgvAppointment.Columns[j].Name=="Time")
               {
                   for (int i = 1; i < dgvAppointment.Rows .Count ; i++)
                   {
                       if (dgvAppointment.Rows[i].Cells[j].Value == null )
                       {
                           if (i > maxRow)
                           {
                               maxRow = Convert.ToInt16(i);  
                           }
                           break;
                       }
                   }
               }
              
           }
          // dgvAppointment.AllowUserToDeleteRows = true;
          // MessageBox.Show(maxRow.ToString());
           for (int i = dgvAppointment.Rows.Count-1; i > maxRow; i--)
           {
               dgvAppointment.Rows.RemoveAt(i);
           }
       }
       private void TicketOkPatientList(string AppointDate)
       {
           List<OpdAppointment> oPatTime = clnt.TicketOkPatientList(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(),
                                            AppointDate).ToList();
           if (oPatTime.Count > 0)
           {
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
       }
       private void prescribedPatient(string AppointDate)
       {
           List<OpdAppointment> oPatTime = clnt.PrescribePatientList(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(),
                                            AppointDate).ToList();
           if (oPatTime.Count > 0)
           {
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
                         where doctorName.Doctor.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)||
                         doctorName.Doctor.ID.Contains(searchString)
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
            lstTodayDoctorList.Columns.Add("Appoint Date", 90, HorizontalAlignment.Center);
            lstTodayDoctorList.Columns.Add("Day", 80, HorizontalAlignment.Center);
            lstTodayDoctorList.Columns.Add("Appoint Time", 200, HorizontalAlignment.Left);       
            lstTodayDoctorList.Columns.Add("Department Id", 0, HorizontalAlignment.Left);
            lstTodayDoctorList.Columns.Add("Department Name", 100, HorizontalAlignment.Left);
            lstTodayDoctorList.Columns.Add("Unit Id", 0, HorizontalAlignment.Left);
            lstTodayDoctorList.Columns.Add("Unit Name", 150, HorizontalAlignment.Left);           
        }      
        private void txtDoctorName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListDoctorList(docList, txtDoctorName.Text);
        }

        private void lstDoctorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Doctor = "";
                if (lstDoctorName.SelectedItems.Count > 0)
                {
                    ListViewItem itm = lstDoctorName.SelectedItems[0];
                    cboDepartmentID.Text = itm.SubItems[2].Text;

                    cboDoctorID.Text = itm.SubItems[1].Text;
                    txtDoctorName.Text = itm.SubItems[1].Text;
                    DepartmentUnit = itm.SubItems[5].Text;
                    Doctor = itm.SubItems[1].Text;
                    cboUnitID.Text = DepartmentUnit;
                }
                lstDoctorName.Visible = false;
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
            try
            {
                lstDoctorName.Visible = false;
                txtDoctorName.Text = "";
                lstTodayDoctorList.Visible = true;
                lstTodayDoctorList.Top = btnDocList.Top + btnDocList.Height;
                lstTodayDoctorList.Left = btnDocList.Left;
                LoadListViewDoctorList();
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
     //   string AppointTime = "";
        private void LoadListViewDoctorList()
        {
            lstTodayDoctorList.Items.Clear();
            List<DoctorWeekDays> oDoctorList = clnt.GetTodaysDoctorList().ToList();

            foreach (DoctorWeekDays oDoctor in oDoctorList)
            {
               // AppointTime = AppointTime+oDoctor.StartTime + "-" + oDoctor.EndTime;
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
            try
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
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
   
        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            lstDoctorName.Visible = false;
            lstTodayDoctorList.Visible = false;
        }

        private void dptStartDate_ValueChanged(object sender, EventArgs e)
        {
            if(dptStartDate.Value<DateTime.Now)
            {
                return;
            }
        }

        private void dptEndDate_ValueChanged(object sender, EventArgs e)
        {
            //if (dptEndDate.Value < DateTime.Now)
            //{
            //    return;
            //}
        }

        private void dgvAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txtDoctorName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
