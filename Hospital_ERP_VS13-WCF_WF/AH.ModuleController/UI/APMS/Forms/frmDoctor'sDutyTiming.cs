
//Developed by   : Shabnam
//Date           : 13-09-2014
//Purpose        : Doctor Duty Timings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.APMSSR;
using AH.Shared.UI;
using AH.DUtility;

namespace AH.ModuleController.UI.APMS.Forms
{
    public partial class frmDoctorDutyTiming : AH.Shared.UI.frmSmartFormStandard
    {

        APMSWSClient clnt = new APMSWSClient();
        APMSSR.APMSWSClient apmssr = new APMSSR.APMSWSClient();
        public frmDoctorDutyTiming()
        {
            InitializeComponent();
        }

        private void frmDoctorDutyTiming_Load(object sender, EventArgs e)
        {
            cboDepartmentID.DisplayMember = "Value";
            cboDepartmentID.ValueMember = "Key";
            cboDepartmentID.DataSource = new BindingSource(Utility.VerifyDic(clnt.GetDepartmentsetup("D", Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);

            chkWeekDays.DataSource = new BindingSource(Utility.GetWeekDays(), null); 
            chkWeekDays.DisplayMember = "Value";
            chkWeekDays.ValueMember = "Key";
            btnProcess.Enabled = true;
            chkWeekDays.BackColor = Color.OldLace;
            chkWeekDays.ForeColor = Color.DarkBlue;

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

            if (cboDepartmentID.SelectedValue.ToString() != null && cboUnitID.SelectedValue.ToString() != null)         
            {
                cboDoctorID.DataSource = new BindingSource(Utility.VerifyDic(clnt.GetOPDDoctorsDict(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString())), null);
            }

        }
   
        private void GetDoctorWeekDays()
        {
            UncheckAllItems();
            List<DoctorWeekDays> oDays = clnt.GetDoctorWeekDays(cboDoctorID.SelectedValue.ToString(), cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), dtpStartDate.Value.ToString("dd-MM-yyyy"), dtpEndDate.Value.ToString("dd-MM-yyyy")).ToList();
            for (int j = 0; j < oDays.Count; j++)
            {
                string days = oDays[j].WeekDayName.ToString();
                for (int i = 0; i < chkWeekDays.Items.Count; i++)
                {
                    string str = chkWeekDays.Items[i].ToString().Substring(1, 1);
                    if (days == str)
                    {
                        chkWeekDays.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
        }

#region For Saving the Doctor Date
        string strDays = "";
        private void btnProcess_Click(object sender, EventArgs e)
        {
            strDays = "";
            //btnModify.Enabled = false;
            List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID"};
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }

                if (!(dtpStartDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= DateTime.Now.Date))
                {
                    MessageBox.Show("The date range should in future date , Please check !!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                //=====================================Save Week Days=======================//

                for (int index = 0; index < chkWeekDays.Items.Count; index++)
                {
                    if (chkWeekDays.GetItemChecked(index))
                    {
                        foreach (int indexChecked in chkWeekDays.CheckedIndices)
                        {
                            if (strDays != "")
                            {
                                strDays = indexChecked.ToString() + ":" + strDays;
                            }
                            if (strDays == "")
                            {
                                strDays = indexChecked.ToString() + ":";
                            }

                        }
                        try
                        {
                            //DoctorWeekDays dgobj = this.PopulateDoctorWeekDays();
                            //short i = clnt.SaveDoctorWeekDays(dgobj);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                  //=====================================Save Dates===============================//

                        try
                        {                          
                           // DoctorWeekDays dwd = this.PopulateDoctorVSTcal();
                           // short i = clnt.saveDoctorVSTcal(dwd);

                        
                           //if (i == 1)
                           // {
                           //     MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                            
                           //     btnShow.PerformClick();

                           // }
                           // else if (i == 2)
                           // {
                           //     MessageBox.Show("You have already this date range ! You can modify or delete ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           //     btnShow.PerformClick();                              
                           // }
                           //else
                           //{
                           //    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           //}

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        return;
                                              
                    }
                  
                }
           //  MessageBox.Show("Please Select Week Days!!!"); 
                
         }
#endregion

        private DoctorWeekDays PopulateDoctorVSTcal()
        {
            DateTime startDate = dtpStartDate.Value;
            string SD = startDate.ToString("dd-MM-yyyy");
            DateTime endDate = dtpEndDate.Value;
            string ED = endDate.ToString("dd-MM-yyyy");
            DoctorWeekDays oDwd = new DoctorWeekDays();
            oDwd.StartDate = SD;
            oDwd.LastDate = ED;

            Department oDept = new Department();
            oDept.DepartmentID = cboDepartmentID.SelectedValue.ToString();
            oDwd.Department = oDept;

            DepartmentUnit oDTU = new DepartmentUnit();
            oDTU.UnitId = cboUnitID.SelectedValue.ToString();
            oDwd.DepartmentUnit = oDTU;

            Doctor oDoc = new Doctor();
            oDoc.ID = cboDoctorID.SelectedValue.ToString();
            oDwd.Doctor = oDoc;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDwd.EntryParameter = ep;

            return oDwd;

        }
#region For Formating Grid
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


#endregion
        
//========================Get Week Day's Name  and Checked on Checked List Box If Day name Matched==============================================////////
        string date = "";
        string cbodate = "";
        int k = 0;
        private void btnShow_Click(object sender, EventArgs e)
        {
           
            List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
      
            cboWeekDays.Items.Clear();
       
//===============================Create Grid For Doctor Timing And Show Time From DB===============================================//

            dgvDutyTimings.Columns.Clear();
            dgvDutyTimings.DataSource = null;
            cboWeekDays.Items.Add("--Select--");
            cboWeekDays.SelectedIndex = 0;

            DateTime startD = dtpStartDate.Value;
            DateTime endD = dtpEndDate.Value;
            if (startD >= DateTime.Now.Date && endD >= DateTime.Now.Date)
            {

                string startDate = dtpStartDate.Value.ToString("dd/MM/yyyy");
                string endDate = dtpEndDate.Value.ToString("dd/MM/yyyy");

                List<DoctorWeekDays> odvd = clnt.GetDoctorVSTcal(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();
                if (odvd.Count != 0)
                {                
                    GetDoctorWeekDays();
                    List<DoctorWeekDays> oDoctorDutyTiming = clnt.GetDoctorDutyTiming(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate).ToList();
                    for (int rcont = 0; rcont < odvd.Count; rcont++)
                    {
                        dgvDutyTimings.Columns.Add(FormatColumns("", "", 120, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
                        dgvDutyTimings.Rows[0].Cells[0].Selected = false;

                        string sTo = odvd[rcont].VisitDate.ToString("dd-MM-yyyy");
                        string day = odvd[rcont].VisitDate.ToString("dddd");
                        date = sTo + "\r\n" + day;
                       // cbodate = sTo + "(" + day + ")";
                        dgvDutyTimings.Columns[rcont].HeaderCell.Value = date;
                        dgvDutyTimings.Columns[rcont].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        k = 0;
                        for (int i = 0; i < oDoctorDutyTiming.Count; i++)
                        {
                            string vDate = oDoctorDutyTiming[i].VisitDate.ToString("dd-MM-yyyy");
                            if (sTo == vDate)
                            {
                                dgvDutyTimings.Rows.Add();
                                dgvDutyTimings.Rows[k].Cells[rcont].Value = oDoctorDutyTiming[i].StartTime;
                                k++;
                            }
                        }
                       
                        cboWeekDays.Items.Add(date);
                        //btnProcess.Text = "Modify Calendar";
                    }
                    GetAppointedDate(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(), startDate, endDate);
                }
                //else
                //{
                //    MessageBox.Show("Please Save Doctor duty Date!!!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                //}
                
            }
            else
            {
                btnProcess.Enabled = true;
                MessageBox.Show("The date range should in future date , Please check !!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);              
            }
        }

        private void GetAppointedDate(string departmentId, string unitId,string doctorId,string startDate,string endDate)
        {
            List<OpdAppointment> oAppointDate = clnt.GetAppointedDate(departmentId, unitId, doctorId, startDate, endDate).ToList();
            for (int coll = 0; coll < dgvDutyTimings.ColumnCount; coll++)
            {
                for (int cnt = 0; cnt < oAppointDate.Count; cnt++)
                {
                    string date = dgvDutyTimings.Columns[coll].ToString();
                    if (oAppointDate[cnt].AppointDate == dgvDutyTimings.Columns[coll].ToString().Substring(0,10)) 
                    {
                        dgvDutyTimings.Columns[coll].HeaderCell.Style.BackColor = Color.Green;
                    }
                }

            }
        }
        private short GetRowNoToAdd(DataGridView dgvDutyTimings, short col,  DateTime dt1,DateTime dt2)
         {
                    short rowNo=0;
                    if (dgvDutyTimings.Rows[0].Cells[col].Value == null)
                       {
                           rowNo = 0;
                       }
                    else 
                        {
                            for (short i = 0; i < dgvDutyTimings.Rows.Count && dgvDutyTimings.Rows[i].Cells[col].Value != null; i++)
                            {
                                string str = dgvDutyTimings.Rows[i].Cells[col].Value.ToString();
                                DateTime sTime = DateTime.Parse(str.Substring(0, 10).ToString());
                                DateTime eTime = DateTime.Parse(str.Substring(11, 10).ToString());
                                if (Utility.TimeCompare(dt1, sTime, eTime) || Utility.TimeCompare(dt2, sTime, eTime))
                                {
                                    rowNo = -1;
                                    return rowNo;
                                }
                                else
                                {
                                    rowNo = i;
                                    ++rowNo;
                                }

                            }   
                        }

               return rowNo;
       }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboWeekDays.Text == "--Select--" || cboWeekDays.Text=="")
            {
                MessageBox.Show(Utility.getFMS(cboWeekDays.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboWeekDays.Focus();
                return;             
            }
         
            string value = cboWeekDays.SelectedItem.ToString();           
            string cboDate = Utility.GetStringPart(value, "\r\n", true);
            DateTime dt1 = DateTime.Parse(dtpStartTime.Value.ToString("hh : mm tt"));
            DateTime dt2 = DateTime.Parse(dtpEndTime.Value.ToString("hh : mm tt"));
            int var = int.Parse(dt1.ToString("hh : mm tt").Substring(4, 3));

            if (int.Parse(dt1.ToString("hh : mm tt").Substring(4, 3)) % 10 == 0 && int.Parse(dt2.ToString("hh : mm tt").Substring(4, 3))%10==0)
                {
                    if (dt1 < dt2)
                    {
                        dgvDutyTimings.Rows.Add();
                        for (short j = 0; j < dgvDutyTimings.Columns.Count; j++)
                        {
                            string vardt = dgvDutyTimings.Columns[j].HeaderCell.Value.ToString();                           
                            string dgvDate = Utility.GetStringPart(vardt, "\r\n", true);
                            if (cboDate == dgvDate)
                            {
                                short rowNo = GetRowNoToAdd(dgvDutyTimings, j, dt1, dt2);
                                if (rowNo == -1)
                                {                                  
                                    MessageBox.Show("Selected time range is already in the list, Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                                   
                                    return;
                                }
                                else
                                {                                   
                                    dgvDutyTimings.Rows[rowNo].Cells[j].Value = dt1.ToString("hh : mm tt") + "-" + dt2.ToString("hh : mm tt");
                                }  
                            }
                         }                       
                     }

                    else
                    {
                        MessageBox.Show("The end time must be greater than the start time, Please check !!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                       
                    }
                }
                else
                    MessageBox.Show("Please choose time like 10:00 or 10:10 or 10:30.....Pattern !!!!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //if (cboInterval.SelectedItem.ToString() == "")
            //{
            //    MessageBox.Show(Utility.getFMS(cboInterval.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cboInterval.Focus();
            //    return;
            //}
                   
      }

        private void cboWeekDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWeekDays.SelectedItem.ToString() != "Select--")
            {
                string value = cboWeekDays.SelectedItem.ToString();
                string cboDate = value.Substring(0, 10);

                for (int j = 0; j < dgvDutyTimings.Columns.Count; j++)
                {
                    string vardt = dgvDutyTimings.Columns[j].HeaderCell.Value.ToString();
                    string dgvDate = vardt.Substring(0, 10);

                    if (cboDate == dgvDate)
                    {
                        dgvDutyTimings.Columns[j].HeaderCell.Style.BackColor = Color.CornflowerBlue;
                    }

                    else
                    {
                        dgvDutyTimings.Columns[j].HeaderCell.Style.BackColor = Color.White;
                    }
                }
            }
        }

#region For Doctor Timing Save

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID","txtTimeInterval" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (cboWeekDays.SelectedItem.ToString() == "--Select--")
            {
                MessageBox.Show(Utility.getFMS(cboWeekDays.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboWeekDays.Focus();
                return;
            }
            for (int j = 0; j < dgvDutyTimings.Columns.Count; j++)
            {

                if (dgvDutyTimings.Rows[0].Cells[j].Value != null)
                {

                    try
                    {
                        DoctorWeekDays oDoctorTiming = this.PopulateDoctorTiming();
                        short i = clnt.SaveDoctorTiming(oDoctorTiming);

                        if (i == 0)
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i == 1)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnShow.PerformClick();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    return;
                }
            }
            MessageBox.Show("Please add time!");
        }

#endregion PopulateDoctorTiming

        private DoctorWeekDays PopulateDoctorTiming()
        {
            DoctorWeekDays oDWD = new DoctorWeekDays();

            Department deptID = new Department();
            deptID.DepartmentID = cboDepartmentID.SelectedValue.ToString();
            oDWD.Department = deptID;

            DepartmentUnit oDTU = new DepartmentUnit();
            oDTU.UnitId = cboUnitID.SelectedValue.ToString();
            oDWD.DepartmentUnit = oDTU;

            Doctor oDoc = new Doctor();
            oDoc.ID = cboDoctorID.SelectedValue.ToString();
            oDWD.Doctor = oDoc;

            oDWD.ServiceId = "c";
            oDWD.Interval = int.Parse(txtTimeInterval.Value.ToString());

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDWD.EntryParameter = ep;

            string string2 = "";
            for (int j = 0; j < dgvDutyTimings.Columns.Count; j++)
            {
                string vardt = dgvDutyTimings.Columns[j].HeaderCell.Value.ToString();
                string dgvDate = vardt.Substring(0, 10);

                if (dgvDutyTimings.Rows[0].Cells[j].Value != null)
                {
                    for (int i = 0; i < dgvDutyTimings.Rows.Count; i++)
                    {
                        if (dgvDutyTimings.Rows[i].Cells[j].Value != null)
                        {
                            string string1 = "";
                            string var1 = dgvDutyTimings.Rows[i].Cells[j].Value.ToString();
                            string var2 = var1.Substring(0, 10);
                            string var3 = var1.Substring(11, 10);
                            string1 = dgvDate + "+" + var2 + "+" + var3;
                            string2 = string1 + ";" + string2;                      
                        }
                    }
                }
            }
            oDWD.DoctorTiming = string2;
            return oDWD;
        }

        private void dgvDutyTimings_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && dgvDutyTimings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.dgvDutyTimings.CurrentCell = clickedCell;  // Select the clicked cell, for instance              
                    var relativeMousePosition = dgvDutyTimings.PointToClient(Cursor.Position);
                    mnDelete.Show(dgvDutyTimings, relativeMousePosition);

                }

            }                        
        }

       
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                DoctorWeekDays oDoctorTime = this.DeleteDoctorTiming();
                short i = clnt.DeleteDoctorTiming(oDoctorTime);


                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                }
                else if (i == 1)
                {
                    MessageBox.Show(Utility.DeleteMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnShow.PerformClick();

                }
                else if (i == 2)
                {
                    MessageBox.Show("Please check ,is there any patient on these time!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);               
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }
    
        string dateTime = "";
        string starTime = "";
        string endtime = "";
        private void dgvDutyTimings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvDutyTimings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string date = dgvDutyTimings.Columns[e.ColumnIndex].HeaderCell.Value.ToString();
                string time = dgvDutyTimings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                dateTime = date.Substring(0, 10);
                starTime = time.Substring(0, 10);
                endtime = time.Substring(11, 10);
            }
        }

        private DoctorWeekDays DeleteDoctorTiming()
        {
            DoctorWeekDays oDWD = new DoctorWeekDays();
            Department deptID = new Department();
            deptID.DepartmentID = cboDepartmentID.SelectedValue.ToString();
            oDWD.Department = deptID;

            DepartmentUnit oDTU = new DepartmentUnit();
            oDTU.UnitId = cboUnitID.SelectedValue.ToString();
            oDWD.DepartmentUnit = oDTU;

            Doctor oDoc = new Doctor();
            oDoc.ID = cboDoctorID.SelectedValue.ToString();
            oDWD.Doctor = oDoc;

            oDWD.StartDate=dateTime;
            oDWD.StartTime = starTime;
            oDWD.EndTime = endtime;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDWD.EntryParameter = ep;

            return oDWD;
 
        }

        private void chkWeekDays_Click(object sender, EventArgs e)
        {
            //foreach (int indexChecked in chkWeekDays.CheckedIndices)
            //{
            //    // The indexChecked variable contains the index of the item.
            //    MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
            //                    chkWeekDays.GetItemCheckState(indexChecked).ToString() + ".");
            //}
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int indexChecked in chkWeekDays.CheckedIndices)
            {          
                strDays = indexChecked.ToString() + ',' + strDays;
            }
            label3.Text = strDays;
        }
        private DoctorWeekDays PopulateModifyDoctorCalendar()
        {
           
            DoctorWeekDays oDWD = new DoctorWeekDays();

            oDWD.StartDate = dtpStartDate.Value.ToString("dd-MM-yyyy");
            oDWD.LastDate = dtpEndDate.Value.ToString("dd-MM-yyyy");        
            oDWD.WeekDayNO = strDays;

            Department deptID = new Department();
            deptID.DepartmentID = cboDepartmentID.SelectedValue.ToString();
            oDWD.Department = deptID;

            DepartmentUnit oDTU = new DepartmentUnit();
            oDTU.UnitId = cboUnitID.SelectedValue.ToString();
            oDWD.DepartmentUnit = oDTU;

            Doctor oDoc = new Doctor();
            oDoc.ID = cboDoctorID.SelectedValue.ToString();
            oDWD.Doctor = oDoc;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDWD.EntryParameter = ep;

            return oDWD;
        }

        private DoctorWeekDays PopulateDoctorWeekDays()
        {
            DoctorWeekDays oDWD = new DoctorWeekDays();
            oDWD.WeekDayNO = strDays;

            Department deptID = new Department();
            deptID.DepartmentID = cboDepartmentID.SelectedValue.ToString();
            oDWD.Department = deptID;

            DepartmentUnit oDTU = new DepartmentUnit();
            oDTU.UnitId = cboUnitID.SelectedValue.ToString();
            oDWD.DepartmentUnit = oDTU;

            Doctor oDoc = new Doctor();
            oDoc.ID = cboDoctorID.SelectedValue.ToString();
            oDWD.Doctor = oDoc;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDWD.EntryParameter = ep;

            return oDWD;
        }

        private void UncheckAllItems()
        {
            while (chkWeekDays.CheckedIndices.Count > 0)
                chkWeekDays.SetItemChecked(chkWeekDays.CheckedIndices[0], false);
        }


        private void btnNew_Click(object sender, EventArgs e)
        {                      
            dgvDutyTimings.Columns.Clear();
            dgvDutyTimings.Rows.Clear();
            UncheckAllItems();
        }

        private void btnDeleteCalendar_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (!(dtpStartDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= DateTime.Now.Date))
            {
                MessageBox.Show("The date range should in future date , Please check !!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           try
            {
                DoctorWeekDays oDoctorTime = this.PopulateDoctorVSTcal();
                short i = clnt.DeleteDoctorSchedule(oDoctorTime);

                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else if (i == 1)
                {
                    MessageBox.Show(Utility.DeleteMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UncheckAllItems();                  
                    btnShow.PerformClick();
                }
                else if (i == 2)
                {
                    MessageBox.Show("Please check ,is there any patient on these time!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnShow.PerformClick();
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }
        
        private void btnModify_Click(object sender, EventArgs e)
        {
            //btnProcess.Enabled = false;
            strDays = "";
            List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (!(dtpStartDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= DateTime.Now.Date))
            {
                MessageBox.Show("The date range should in future date , Please check !!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            for (int index = 0; index < chkWeekDays.Items.Count; index++)
                {
                    if (chkWeekDays.GetItemChecked(index))
                    {
                        foreach (int indexChecked in chkWeekDays.CheckedIndices)
                        {
                            if (strDays != "")
                            {
                                strDays = indexChecked.ToString() + ":" + strDays;
                            }
                            if (strDays == "")
                            {
                                strDays = indexChecked.ToString() + ":";
                            }

                        }
                        try
                        {
                         DoctorWeekDays oDocWekDays = this.PopulateModifyDoctorCalendar();
                        short vrfy = clnt.ModifyDoctorCalendar(oDocWekDays);
                        if (vrfy == 1)
                        {
                            MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnShow.PerformClick();
                        }
                        if (vrfy == 2)
                        {
                            MessageBox.Show("Please check ,is there any patient on these date!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        return;
                                              
                    }
                  
                }
          
                MessageBox.Show("Please select week days!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
        }

        private void mnDelete_Opening(object sender, CancelEventArgs e)
        {

        }
 
    }
}
