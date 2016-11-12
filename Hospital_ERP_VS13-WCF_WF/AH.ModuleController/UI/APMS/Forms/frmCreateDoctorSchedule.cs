
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
    public partial class frmCreateDoctorSchedule : AH.Shared.UI.frmSmartFormStandard
    {

        APMSWSClient clnt = new APMSWSClient();
        APMSSR.APMSWSClient apmssr = new APMSSR.APMSWSClient();
        public frmCreateDoctorSchedule()
        {
            InitializeComponent();
        }
        List<DoctorWeekDays> oDoctorDutyTiming;
        List<DoctorWeekDays> query;
        DateTimePicker oDateTimePicker;
        List<OPDDoctor> docList;
        DateTimePicker oDTime;
        DateTimePicker oDtp;
        string strDays = "";
        string firstTimeSlot = "";
        string secondTimeSlot = "";
        string thirdTimeSlot = "";
        string flag = "";
        string DepartmentUnit = "";
        string Doctor = "";
        private void frmDoctorDutyTiming_Load(object sender, EventArgs e)
        {
            
                cboDepartmentID.DisplayMember = "Value";
                cboDepartmentID.ValueMember = "Key";
                cboDepartmentID.DataSource = new BindingSource(Utility.VerifyDic(clnt.GetDepartmentsetup("D", Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);

                GridView(dgvDoctorSchedule);
                GridView(dgvDeleteSchedule);
                GridView(dgvUpdateSchedule);

                oDateTimePicker = new DateTimePicker();
                oDateTimePicker.Format = DateTimePickerFormat.Custom;
                oDateTimePicker.CustomFormat = "hh:mm tt";
                oDateTimePicker.Visible = false;
                oDateTimePicker.Width = 100;
                oDateTimePicker.Height = 80;
                oDateTimePicker.ShowUpDown = true;

                dgvDoctorSchedule.Controls.Add(oDateTimePicker);
                oDateTimePicker.ValueChanged += this.oDateTimePicker_ValueChanged;
                dgvDoctorSchedule.CellBeginEdit += this.dgvDoctorSchedule_CellBeginEdit;
                dgvDoctorSchedule.CellEndEdit += this.dgvDoctorSchedule_CellEndEdit;

                oDTime = new DateTimePicker();
                oDTime.Format = DateTimePickerFormat.Custom;
                oDTime.CustomFormat = "hh:mm tt";
                oDTime.Visible = false;
                oDTime.Width = 100;
                oDTime.Height = 80;
                oDTime.ShowUpDown = true;

                dgvUpdateSchedule.Controls.Add(oDTime);
                oDTime.ValueChanged += this.oDTime_ValueChanged;
                dgvUpdateSchedule.CellBeginEdit += this.dgvUpdateSchedule_CellBeginEdit;
                dgvUpdateSchedule.CellEndEdit += this.dgvUpdateSchedule_CellEndEdit;


                lblStartd.Text = dtpStartDate.Value.ToString("dd/MMM/yyyy");
                lblEndD.Text = dtpEndDate.Value.ToString("dd/MMM/yyyy");

                lblDoctorName.Visible = false;
                lblDateExist.Visible = false;
                lblUpDateExist.Visible = false;
                docList = clnt.GetOPDDoctors().ToList();
                FormatGrid();
                ListLoad(docList);
                lstDoctorName.BackColor = Color.SeaShell;
                lstDoctorName.ForeColor = Color.Blue;
                chkSameTime.Checked = false;
         
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
            if (DepartmentUnit != "")
            {
                cboUnitID.Text = DepartmentUnit;
                DepartmentUnit = "";
            }         
        }

        #region CreateGridAllUser
        public DataGridViewCheckBoxColumn FormatCheckBox(string pname, string htext, int cwidth, Boolean visibility, DataGridViewContentAlignment Algin, bool IsReadOnly, bool Isfrozen, string columnType)
        {
            DataGridViewCheckBoxColumn Ckbox = new DataGridViewCheckBoxColumn();
            Ckbox.DataPropertyName = pname;
            Ckbox.HeaderText = htext;
            Ckbox.Name = pname;
            Ckbox.DefaultCellStyle.ForeColor = Color.Black;
            Ckbox.DefaultCellStyle.BackColor = Color.White;
            Ckbox.Visible = visibility;
            Ckbox.DefaultCellStyle.Alignment = Algin;
            Ckbox.Width = cwidth - 1;
            Ckbox.ReadOnly = IsReadOnly;
            Ckbox.Frozen = Isfrozen;

            return Ckbox;

        }
        private DataGridViewTextBoxColumn FormatGrid(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn Deptcolumn = new DataGridViewTextBoxColumn();
            Deptcolumn.DataPropertyName = pname;
            Deptcolumn.Name = pname;
            Deptcolumn.HeaderText = htext;
            Deptcolumn.DefaultCellStyle.ForeColor = Color.Black;
            Deptcolumn.DefaultCellStyle.BackColor = Color.White;
            Deptcolumn.Visible = true_false;
            Deptcolumn.DefaultCellStyle.Alignment = Algin;
            Deptcolumn.Width = cwidth;
            Deptcolumn.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);
            Deptcolumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            return Deptcolumn;
        }
        private void GridView(DataGridView dgv)
        {
            dgv.Columns.Add(FormatCheckBox("CheckBox", "", 30, true, DataGridViewContentAlignment.BottomLeft, false, false, "checkbox"));
            dgv.Columns.Add(FormatGrid("Day", "Day", 105, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("sTime", "Start Time ", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("eTime", "End Time", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("Interval", "Interval ", 50, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));

            dgv.Columns.Add(FormatGrid("sTime", "Start Time ", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("eTime", "End Time", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("Interval", "Interval ", 50, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));

            dgv.Columns.Add(FormatGrid("sTime", "Start Time ", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("eTime", "End Time", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("Interval", "Interval ", 50, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;


            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[1].HeaderCell.Style.BackColor = Color.LightGreen;

            dgv.Columns[2].HeaderCell.Style.BackColor = Color.LightGreen;            
            dgv.Columns[3].HeaderCell.Style.BackColor = Color.LightGreen;
            dgv.Columns[4].HeaderCell.Style.BackColor = Color.LightGreen;
            ((DataGridViewTextBoxColumn)dgv.Columns[4]).MaxInputLength = 2;

            dgv.Columns[5].HeaderCell.Style.BackColor = Color.DodgerBlue;
            dgv.Columns[6].HeaderCell.Style.BackColor = Color.DodgerBlue;
            dgv.Columns[7].HeaderCell.Style.BackColor = Color.DodgerBlue;
            ((DataGridViewTextBoxColumn)dgv.Columns[7]).MaxInputLength = 2;
            dgv.Columns[8].HeaderCell.Style.BackColor = Color.DarkViolet;
            dgv.Columns[9].HeaderCell.Style.BackColor = Color.DarkViolet;
            dgv.Columns[10].HeaderCell.Style.BackColor = Color.DarkViolet;
            ((DataGridViewTextBoxColumn)dgv.Columns[10]).MaxInputLength = 2;

            for (int i = 0; i <= 6; i++)
            {
                dgv.Rows.Add();

            }

            dgv.Rows[0].Cells[1].Value = "Saturday";
            dgv.Rows[1].Cells[1].Value = "Sunday";
            dgv.Rows[2].Cells[1].Value = "Monday";
            dgv.Rows[3].Cells[1].Value = "Tuesday";
            dgv.Rows[4].Cells[1].Value = "Wednesday";
            dgv.Rows[5].Cells[1].Value = "Thursday";
            dgv.Rows[6].Cells[1].Value = "Friday";
           
        }
      
        #endregion

   
        private void dgvDoctorSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            dgvDoctorSchedule.CurrentRow.Cells[0].ReadOnly = false;
            dgvDoctorSchedule.CurrentRow.Cells[1].ReadOnly = true;
            if (e.ColumnIndex > 1 && e.RowIndex >= 0)   
            {
                    if (Convert.ToBoolean(dgvDoctorSchedule.CurrentRow.Cells[0].Value) == true)
                    {
                       if (dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null)
                       {
                           dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                           dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                       }
                       else
                       {
                           dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                           dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                       }
                    }
                    else
                    {
                        dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                        dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    }
             
            }
           
            dgvDoctorSchedule.CurrentRow.Cells[0].ReadOnly = false;
            dgvDoctorSchedule.CurrentRow.Cells[1].ReadOnly = true;
       
        }
        

        private void dgvDoctorSchedule_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {                
                if (Convert.ToBoolean(dgvDoctorSchedule.CurrentRow.Cells[0].Value) == true)
                {                     
                    if ((dgvDoctorSchedule.CurrentCell.ColumnIndex == 2) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 3) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 5) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 6) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 8) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 9))
                          {
                           
                            oDateTimePicker.Location = dgvDoctorSchedule.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                            oDateTimePicker.Visible = true;
                            if (dgvDoctorSchedule.CurrentCell.Value == null || dgvDoctorSchedule.CurrentCell.Value.ToString()=="")
                            {
                                oDateTimePicker.Value = Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss tt"));
                            }
                            else
                            {
                                oDateTimePicker.Value = Convert.ToDateTime(dgvDoctorSchedule.CurrentCell.Value);
                            }

                        }
                }
                else
                {
                    oDateTimePicker.Visible = false;                 
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvDoctorSchedule_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(dgvDoctorSchedule.CurrentRow.Cells[0].Value) == true)
                {
                    dgvDoctorSchedule.CurrentCell.ReadOnly = false;
                    if ((dgvDoctorSchedule.Focused) && (dgvDoctorSchedule.CurrentCell.ColumnIndex == 2) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 3) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 5) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 6) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 8) ||
                        (dgvDoctorSchedule.CurrentCell.ColumnIndex == 9))
                        {
                            dgvDoctorSchedule.CurrentCell.Value = oDateTimePicker.Value.ToString("hh:mm tt");
                        }

                }

                if (e.ColumnIndex == 4 || e.ColumnIndex == 7 || e.ColumnIndex == 10)
                {
                    int di = 0;
                    if (dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null
                        && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value != null)
                    {
                        TimeSpan diff = (DateTime.Parse(dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString()).
                               Subtract(DateTime.Parse(dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString())
                                   ));
                        di = int.Parse(diff.ToString("hh") + diff.ToString("mm"));
                        if (int.Parse(dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) > di)
                        {
                            // e.Cancel = true;
                            MessageBox.Show("Interval can not greater than time diffrence");
                            dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Selected = true;
                            dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                            dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                            return;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUpdateSchedule_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(dgvUpdateSchedule.CurrentRow.Cells[0].Value) == true)
                {
                    if ((dgvUpdateSchedule.Focused) && (dgvUpdateSchedule.CurrentCell.ColumnIndex == 2) ||
                    (dgvUpdateSchedule.CurrentCell.ColumnIndex == 3) ||
                    (dgvUpdateSchedule.CurrentCell.ColumnIndex == 5) ||
                    (dgvUpdateSchedule.CurrentCell.ColumnIndex == 6) ||
                    (dgvUpdateSchedule.CurrentCell.ColumnIndex == 8) ||
                    (dgvUpdateSchedule.CurrentCell.ColumnIndex == 9))
                    {
                        oDTime.Location = dgvUpdateSchedule.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                        oDTime.Visible = true;

                        if (dgvUpdateSchedule.CurrentCell.Value == null || dgvUpdateSchedule.CurrentCell.Value.ToString()=="")
                        {
                           oDTime.Value = Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss tt"));                          
                        }
                        else
                        {
                            oDTime.Value = Convert.ToDateTime(dgvUpdateSchedule.CurrentCell.Value);
                        }

                    }
                }
                else
                {
                    oDTime.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUpdateSchedule_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(dgvUpdateSchedule.CurrentRow.Cells[0].Value) == true)
                {
                    if ((dgvUpdateSchedule.Focused) && (dgvUpdateSchedule.CurrentCell.ColumnIndex == 2) ||
                        (dgvUpdateSchedule.CurrentCell.ColumnIndex == 3) ||
                        (dgvUpdateSchedule.CurrentCell.ColumnIndex == 5) ||
                        (dgvUpdateSchedule.CurrentCell.ColumnIndex == 6) ||
                        (dgvUpdateSchedule.CurrentCell.ColumnIndex == 8) ||
                        (dgvUpdateSchedule.CurrentCell.ColumnIndex == 9))
                    {
                        dgvUpdateSchedule.CurrentCell.Value = oDTime.Value.ToString("hh:mm tt");
                    }
                }

                if (e.ColumnIndex == 4 || e.ColumnIndex == 7 || e.ColumnIndex == 10)
                {
                    int di = 0;
                    if (dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null
                        && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value != null)
                    {
                        TimeSpan diff = (DateTime.Parse(dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString()).
                               Subtract(DateTime.Parse(dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString())
                                   ));
                        di = int.Parse(diff.ToString("hh") + diff.ToString("mm"));
                        if (int.Parse(dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) > di)
                        {
                            // e.Cancel = true;
                            MessageBox.Show("Interval can not greater than time diffrence");
                            dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Selected = true;
                            dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected =false;
                            dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                            return;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

      
        private void  oDateTimePicker_ValueChanged(object sender,EventArgs e)
        {
            //if (Convert.ToBoolean(dgvDoctorSchedule.CurrentRow.Cells[0].Value) == true)
            //{
            //    if ((dgvDoctorSchedule.Focused) && (dgvDoctorSchedule.CurrentCell.ColumnIndex == 2) ||
            //              (dgvDoctorSchedule.CurrentCell.ColumnIndex == 3) ||
            //              (dgvDoctorSchedule.CurrentCell.ColumnIndex == 5) ||
            //              (dgvDoctorSchedule.CurrentCell.ColumnIndex == 6) ||
            //              (dgvDoctorSchedule.CurrentCell.ColumnIndex == 8) ||
            //              (dgvDoctorSchedule.CurrentCell.ColumnIndex == 9))
            //    {

                    dgvDoctorSchedule.CurrentCell.Value = oDateTimePicker.Text;
            //    }
            //}
         
        }
       private void oDTime_ValueChanged(object sender, EventArgs e)
       {
           //if (Convert.ToBoolean(dgvUpdateSchedule.CurrentRow.Cells[0].Value) == true)
           // {
           //     if ((dgvUpdateSchedule.Focused) && (dgvUpdateSchedule.CurrentCell.ColumnIndex == 2) ||
           //            (dgvUpdateSchedule.CurrentCell.ColumnIndex == 3) ||
           //            (dgvUpdateSchedule.CurrentCell.ColumnIndex == 5) ||
           //            (dgvUpdateSchedule.CurrentCell.ColumnIndex == 6) ||
           //            (dgvUpdateSchedule.CurrentCell.ColumnIndex == 8) ||
           //            (dgvUpdateSchedule.CurrentCell.ColumnIndex == 9))
           //             {
                            dgvUpdateSchedule.CurrentCell.Value = oDTime.Text;
                        //}

            //}
        }
     

        private DoctorWeekDays PopulateDoctorTiming(DataGridView dgv)
        {
            strDays = "";firstTimeSlot = ""; secondTimeSlot = ""; thirdTimeSlot = "";

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

            oDWD.StartDate = dtpStartDate.Value.ToString("dd-MM-yyyy");
            oDWD.LastDate = dtpEndDate.Value.ToString("dd-MM-yyyy");

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDWD.EntryParameter = ep;

         for (int i = 0; i < dgv.Rows.Count; i++)
                {               
                    if (Convert.ToBoolean(dgv.Rows[i].Cells[0].Value) == true)
                    {

                        for (DateTime date = dtpStartDate.Value; date.Date <= dtpEndDate.Value; date = date.AddDays(1))
                            {
                                if (date.ToString("dddd") == dgv.Rows[i].Cells[1].Value.ToString())
                                {
                                    if (dgv.Rows[i].Cells[2].Value != null && dgv.Rows[i].Cells[2].Value.ToString() != string.Empty &&
                                       dgv.Rows[i].Cells[3].Value != null && dgv.Rows[i].Cells[3].Value.ToString() != string.Empty &&
                                       dgv.Rows[i].Cells[4].Value != null && dgv.Rows[i].Cells[4].Value.ToString() != string.Empty)
                                    {
                                        firstTimeSlot = firstTimeSlot + date.ToString("dd-MM-yyyy") + "+" +
                                                  dgv.Rows[i].Cells[2].Value.ToString() + "+" +
                                                  dgv.Rows[i].Cells[3].Value.ToString() + "+" +
                                                  dgv.Rows[i].Cells[4].Value.ToString() + ";";
                                    }
                                    if (dgv.Rows[i].Cells[5].Value != null && dgv.Rows[i].Cells[5].Value.ToString() != string.Empty &&
                                           dgv.Rows[i].Cells[6].Value != null && dgv.Rows[i].Cells[6].Value.ToString() != string.Empty &&
                                           dgv.Rows[i].Cells[7].Value != null && dgv.Rows[i].Cells[7].Value.ToString() != string.Empty)
                                    {
                                        secondTimeSlot = secondTimeSlot + date.ToString("dd-MM-yyyy") + "+" +
                                                  dgv.Rows[i].Cells[5].Value.ToString() + "+" +
                                                  dgv.Rows[i].Cells[6].Value.ToString() + "+" +
                                                  dgv.Rows[i].Cells[7].Value.ToString() + ";";
                                    }
                                    if (dgv.Rows[i].Cells[8].Value != null && dgv.Rows[i].Cells[8].Value.ToString()!=string.Empty &&
                                        dgv.Rows[i].Cells[9].Value != null && dgv.Rows[i].Cells[9].Value.ToString()!=string.Empty &&
                                        dgv.Rows[i].Cells[10].Value != null && dgv.Rows[i].Cells[10].Value.ToString()!=string.Empty)
                                    {
                                        thirdTimeSlot = thirdTimeSlot + date.ToString("dd-MM-yyyy") + "+" +
                                                  dgv.Rows[i].Cells[8].Value.ToString() + "+" +
                                                  dgv.Rows[i].Cells[9].Value.ToString() + "+" +
                                                  dgv.Rows[i].Cells[10].Value.ToString() + ";";
                                    }
                                }
                            }
                    
                   }
               
            }
      
            oDWD.DoctorTiming = firstTimeSlot + secondTimeSlot + thirdTimeSlot;
            return oDWD;
        }  
        private void dgvDoctorSchedule_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 6 || e.ColumnIndex == 9)
            {
                if (dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()!=string.Empty
                    && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value!=null && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value.ToString()!=string.Empty)
                  {
                      if (DateTime.Parse(dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value.ToString()) >= DateTime.Parse(dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                      {
                          MessageBox.Show("End Time Should Greater Than the Start time,Please check!");
                          e.Cancel = true;
                          dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                      }
                  }

            }
            if (e.ColumnIndex == 5 || e.ColumnIndex == 8)
            {
                if (dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != string.Empty  &&
                    dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value != null && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString()!=string.Empty)
                {
                    if (DateTime.Parse(dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) <= DateTime.Parse(dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString()))
                    {
                        MessageBox.Show("Time Already Exists,Please check!");
                        e.Cancel = true;
                        dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    }
                }
            }

            if (e.ColumnIndex == 4 || e.ColumnIndex == 7 || e.ColumnIndex==10)
            {
                if (dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString() != string.Empty
                        && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value != null && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString() != string.Empty)
                    {
                        int i;
                        //int di = 0;
                        if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                        {
                            e.Cancel = true;
                            MessageBox.Show("please enter numeric");
                            dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                        }
                       
                    }
                }
            }
        }

        private void dgvDoctorSchedule_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.dgvDoctorSchedule.CurrentCell = clickedCell;  // Select the clicked cell, for instance              
                    var relativeMousePosition = dgvDoctorSchedule.PointToClient(Cursor.Position);
                    mnClear.Show(dgvDoctorSchedule, relativeMousePosition);

                }
            }          
        }

        private void cboDoctorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDoctorName.Visible = true;
            lblDoctorName.Text = cboDoctorID.Text;
           // List<OPDDoctor> opdDoc = clnt.GetOPDDoctors().ToList();          
        }
    
        private void ShowDoctorSchedule()
        {
            try
            {
                dgvDoctorTiming.Columns.Clear();
                List<DoctorWeekDays> oDays = new List<DoctorWeekDays>();
                oDays.Clear();
                oDays = clnt.GetDoctorWeekDays(cboDoctorID.SelectedValue.ToString(),
                                             cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(),
                                             dtpStartDate.Value.ToString("dd-MM-yyyy"), dtpEndDate.Value.ToString("dd-MM-yyyy")).ToList();

                if (oDays.Count > 0)
                { /*****Create column with days name*****/
                    for (int j = 0; j < oDays.Count; j++)
                    {
                        dgvDoctorTiming.Columns.Add(FormatGrid("", "", 120, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
                        dgvDoctorTiming.Columns[j].HeaderCell.Value = oDays[j].WeekDayName.ToString();
                        dgvDoctorTiming.Columns[j].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dgvDoctorTiming.Columns[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvDoctorTiming.Columns[j].HeaderCell.Style.BackColor = Color.LightGreen;
                    }
                    if (dtpStartDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= DateTime.Now.Date)
                    {
                        List<DoctorWeekDays> oDoctorDutyTiming = clnt.GetDoctorDutyTiming(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(),
                                  dtpStartDate.Value.ToString("dd/MM/yyyy"), dtpEndDate.Value.ToString("dd/MM/yyyy")).ToList();


                        List<DoctorWeekDays> oDoctorDutyTimings = clnt.GetDoctorVSTcal(cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(),
                                  dtpStartDate.Value.ToString("dd/MM/yyyy"), dtpEndDate.Value.ToString("dd/MM/yyyy")).ToList();



                        /*****Fill cell with dates *****/
                        if (oDoctorDutyTiming.Count != 0)
                        {
                            for (int rcont = 0; rcont < oDoctorDutyTimings.Count; rcont++)
                            {
                                dgvDoctorTiming.Rows.Add();
                                dgvDoctorTiming.Rows[rcont].Height = dgvDoctorTiming.Rows[rcont].Height + 50;
                                for (int col = 0; col < dgvDoctorTiming.Columns.Count; col++)
                                {
                                    if (dgvDoctorTiming.Columns[col].HeaderCell.Value.ToString().Trim() == oDoctorDutyTimings[rcont].VisitDate.ToString("dddd").Trim())
                                    {
                                        dgvDoctorTiming.Rows[rcont].Cells[col].Value = oDoctorDutyTimings[rcont].VisitDate.ToString("dd-MM-yyyy");
                                        dgvDoctorTiming.Rows[rcont].Cells[col].Style.ForeColor = Color.Blue;
                                    }
                                }
                                dgvDoctorTiming.Rows[0].Cells[0].Selected = false;

                            }

                            /*****Fill cell with time *****/
                            string date = "";
                            for (int i = 0; i < oDoctorDutyTiming.Count; i++)
                            {
                                for (int rows = 0; rows < dgvDoctorTiming.Rows.Count; rows++)
                                {
                                    for (int col = 0; col < dgvDoctorTiming.Columns.Count; col++)
                                    {
                                        if (dgvDoctorTiming.Rows[rows].Cells[col].Value != null)
                                        {
                                            if (dgvDoctorTiming.Rows[rows].Cells[col].Value.ToString().Trim().Length > 13)
                                            {
                                                date = Utility.GetStringPart(dgvDoctorTiming.Rows[rows].Cells[col].Value.ToString().Trim(), "\r\n");
                                            }
                                            else
                                            {
                                                date = dgvDoctorTiming.Rows[rows].Cells[col].Value.ToString().Trim();
                                            }
                                            if (date == oDoctorDutyTiming[i].VisitDate.ToString("dd-MM-yyyy").Trim())
                                            {
                                                dgvDoctorTiming.Rows[rows].Cells[col].Value = dgvDoctorTiming.Rows[rows].Cells[col].Value + "\r\n" + oDoctorDutyTiming[i].StartTime;
                                            }
                                        }

                                    }

                                }

                            }

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Sorry, you dont have calander between this date range!");
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
            //dgvDoctorTiming.Visible = true;
            //ShowDoctorSchedule();
            //dgvDoctorSchedule.Visible = false;
            //label6.Visible = false;
            //lblStart.Text = dtpStartDate.Value.ToString("dd/MMM/yyyy");
            //lblEnd.Text = dtpEndDate.Value.ToString("dd/MMM/yyyy");
        }
        string date="";string time=""; string time1=""; string time2="";string  time3="";string temp="";
        private void dgvDoctorTiming_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.Value != null)
                {
                    if (!e.Handled)
                    {
                        e.Handled = true;
                        e.PaintBackground(e.CellBounds, dgvDoctorTiming.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected);
                    }
                    if ((e.PaintParts & DataGridViewPaintParts.ContentForeground) != DataGridViewPaintParts.None)
                    {
                        date = ""; time = ""; time1 = ""; time2 = ""; time3 = ""; temp = "";

                        string text = e.Value.ToString();
                        if (text.Trim().Length < 30 && text.Trim().Length > 10)
                        {
                            date = Utility.GetStringPart(text, "\r\n");
                            time1 = Utility.GetStringPart(text, "\r\n", true);
                        }
                        if (text.Trim().Length > 30 && text.Trim().Length < 50)
                        {
                            date = Utility.GetStringPart(text, "\r\n");
                            time = Utility.GetStringPart(text, "\r\n", false);
                            time1 = Utility.GetStringPart(time, "\r\n");
                            time2 = Utility.GetStringPart(time, "\r\n", true);
                        }
                        if (text.Trim().Length > 50)
                        {

                            date = Utility.GetStringPart(text, "\r\n");
                            time = Utility.GetStringPart(text, "\r\n", false);
                            time1 = Utility.GetStringPart(time, "\r\n");
                            temp = Utility.GetStringPart(time, "\r\n", false);
                            time2 = Utility.GetStringPart(temp, "\r\n");
                            time3 = Utility.GetStringPart(time, "\r\n", true);
                        }

                        Point pnt = new Point();
                        pnt.X = e.CellBounds.Location.X + 25;
                        pnt.Y = e.CellBounds.Location.Y + 10;

                        Rectangle rect1 = new Rectangle(pnt, e.CellBounds.Size);
                        using (Brush cellForeBrush = new SolidBrush(e.CellStyle.ForeColor))
                        {
                            e.Graphics.DrawString(date, e.CellStyle.Font, cellForeBrush, rect1);
                        }
                        rect1.Y += 15;
                        rect1.X -= 9;
                        e.Graphics.DrawString(time1, e.CellStyle.Font, Brushes.Crimson, rect1);
                        if (time2.ToString() != "")
                        {
                            rect1.Y += 15;
                            rect1.X -= 4;
                            using (Brush cellForeBrush = new SolidBrush(e.CellStyle.ForeColor))
                            {
                                e.Graphics.DrawString(time2, e.CellStyle.Font, Brushes.Teal, rect1);
                            }
                        }
                        if (time3.ToString() != "")
                        {
                            rect1.Y += 15;
                            rect1.X -= 3;
                            e.Graphics.DrawString(time3, e.CellStyle.Font, Brushes.Violet, rect1);
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

        private void mnClear_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dgvDoctorSchedule.CurrentCell.Value = "";
        }
        private void tbCalendar_SelectedIndexChanged(object sender, EventArgs e)
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
                if (tbCalendar.SelectedTab == tbCreateSchedule)
                {
                    DoctorWeekDays verify = this.PopulateVerifyDoctorSchedule();
                    short j = clnt.VerifyDoctorSchedule(verify);
                    if (j != 1)
                    {
                        lblDateExist.Visible = true;
                        lblDateExist.Text = "Calendar has already created on date range ! You can update or delete !";
                        dgvDoctorSchedule.ReadOnly = true;
                        // btnNew.PerformClick();
                        return;
                    }
                    else
                    {
                        lblDateExist.Visible = false;
                        dgvDoctorSchedule.ReadOnly = false;
                    }
                }
                if (tbCalendar.SelectedTab == tbShow)
                {

                    ShowDoctorSchedule();
                    lblStart.Text = dtpStartDate.Value.ToString("dd/MMM/yyyy");
                    lblEnd.Text = dtpEndDate.Value.ToString("dd/MMM/yyyy");
                }

                if (tbCalendar.SelectedTab == tbUpdate)
                {

                    if (!(dtpStartDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= dtpStartDate.Value))
                    {

                        MessageBox.Show("The date range should in future date , Please check !!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DoctorWeekDays verify = this.PopulateVerifyDoctorSchedule();
                    short j = clnt.VerifyDoctorSchedule(verify);
                    lblStatDate.Text = dtpStartDate.Value.ToString("dd/MMM/yyyy");
                    lblEndDate.Text = dtpEndDate.Value.ToString("dd/MMM/yyyy");
                    if (j == 1)
                    {
                        lblUpDateExist.Visible = true;
                        lblUpDateExist.Text = "Sorry, you dont have calander between this date range!";
                        dgvUpdateSchedule.ReadOnly = true;
                        return;
                    }
                    else
                    {
                        lblUpDateExist.Visible = false;
                        dgvUpdateSchedule.ReadOnly = false;
                        doctorWeekDays(dgvUpdateSchedule);
                    }



                }
                if (tbCalendar.SelectedTab == tbDelete)
                {
                    dgvDeleteSchedule.ReadOnly = true;
                    doctorWeekDays(dgvDeleteSchedule);
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

        private void doctorWeekDays(DataGridView dgv)
        {
            try
            {
                for (int rows = 0; rows < dgv.Rows.Count; rows++)
                {
                    dgv.Rows[rows].Cells[0].Value = false;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 2; j < dgv.ColumnCount; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null || dgv.Rows[i].Cells[j].Value != null)
                        {
                            dgv.Rows[i].Cells[j].Value = "";
                            // dgv.Rows[i].Cells[0].Value = false;
                        }
                    }
                }

                if (dtpStartDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= DateTime.Now.Date)
                {
                    List<DoctorWeekDays> oDays = new List<DoctorWeekDays>();
                    oDays.Clear();
                    oDays = clnt.GetDoctorWeekDays(cboDoctorID.SelectedValue.ToString(),
                                                 cboDepartmentID.SelectedValue.ToString(), cboUnitID.SelectedValue.ToString(),
                                                 dtpStartDate.Value.ToString("dd-MM-yyyy"), dtpEndDate.Value.ToString("dd-MM-yyyy")).ToList();

                    List<DoctorWeekDays> oDoctorDutyTimings = new List<DoctorWeekDays>();
                    oDoctorDutyTimings = clnt.GetDoctorDutyTiming(cboDepartmentID.SelectedValue.ToString(),
                                                             cboUnitID.SelectedValue.ToString(), cboDoctorID.SelectedValue.ToString(),
                                                             dtpStartDate.Value.ToString("dd/MM/yyyy"), dtpEndDate.Value.ToString("dd/MM/yyyy")).ToList();

                    for (int itm = 0; itm < oDays.Count; itm++)
                    {
                        for (int rows = 0; rows < dgv.Rows.Count; rows++)
                        {
                            if (dgv.Rows[rows].Cells[1].Value.ToString().Trim() == oDays[itm].WeekDayName.ToString().Trim())
                            {
                                dgv.Rows[rows].Cells[0].Value = true;
                            }

                        }

                    }
                    for (int rows = 0; rows < dgv.Rows.Count; rows++)
                    {
                        if (Convert.ToBoolean(dgv.Rows[rows].Cells[0].Value) == true)
                        {
                            DoctorTiming(dgv, rows, dgv.Rows[rows].Cells[1].Value.ToString(), oDoctorDutyTimings);
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

        private void DoctorTiming(DataGridView dgv, int row, string dayName, List<DoctorWeekDays> oDoctorDutyTimings)
        {
            try
            {
                if (oDoctorDutyTimings.Count > 0)
                {

                    if (!(dayName.Length > 0))
                    {
                        query = oDoctorDutyTimings;
                    }
                    else
                    {

                        query = (from timing in oDoctorDutyTimings
                                 where timing.VisitDate.ToString("dddd").Trim() == dayName.Trim()
                                 select timing).Distinct().ToList();

                    }

                    dgv.Rows[row].Cells[2].Value = Utility.GetStringPart(query[0].StartTime.ToString(), "-");
                    dgv.Rows[row].Cells[3].Value = Utility.GetStringPart(query[0].StartTime.ToString(), "-", true);
                    dgv.Rows[row].Cells[4].Value = query[0].Interval.ToString();
                    if (query.Count >= 2)
                    {
                        if (query[1].StartTime.ToString() != "")
                        {
                            dgv.Rows[row].Cells[5].Value = Utility.GetStringPart(query[1].StartTime.ToString(), "-");
                            dgv.Rows[row].Cells[6].Value = Utility.GetStringPart(query[1].StartTime.ToString(), "-", true);
                            dgv.Rows[row].Cells[7].Value = query[1].Interval.ToString();
                        }
                    }
                    if (query.Count >= 3)
                    {
                        dgv.Rows[row].Cells[8].Value = Utility.GetStringPart(query[2].StartTime.ToString(), "-");
                        dgv.Rows[row].Cells[9].Value = Utility.GetStringPart(query[2].StartTime.ToString(), "-", true);
                        dgv.Rows[row].Cells[10].Value = query[2].Interval.ToString();
                    }

                    for (int r = 0; r < dgv.Rows.Count; r++)
                    {
                        if (Convert.ToBoolean(dgv.Rows[r].Cells[0].Value) == true)
                        {
                            for (int i = 2; i < dgv.Columns.Count; i++)
                            {
                                if (dgv.Columns[i].Name != "Interval")
                                {
                                    for (int c = i + 1; c < dgv.Columns.Count; c++)
                                    {
                                        if (dgv.Rows[r].Cells[c].Value != null && dgv.Rows[r].Cells[i].Value != null)
                                        {
                                            if (dgv.Rows[r].Cells[i].Value.ToString().Trim() == dgv.Rows[r].Cells[c].Value.ToString().Trim())
                                            {
                                                dgv.Rows[r].Cells[c].Value = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (dgv.Rows[row].Cells[2].Value != null || dgv.Rows[row].Cells[2].Value.ToString() != "" && dgv.Rows[row].Cells[3].Value != null || dgv.Rows[row].Cells[3].Value.ToString() != "")
                {
                    dgv.Rows[row].Cells[4].Value = query[0].Interval.ToString();
                }
                else
                {
                    dgv.Rows[row].Cells[4].Value = "";

                }

                if (dgv.Rows[row].Cells[5].Value != null && dgv.Rows[row].Cells[5].Value.ToString() != "" && dgv.Rows[row].Cells[6].Value != null && dgv.Rows[row].Cells[6].Value.ToString() != "")
                {
                    dgv.Rows[row].Cells[7].Value = query[1].Interval.ToString();
                }
                else
                {
                    dgv.Rows[row].Cells[7].Value = "";

                }
                if (dgv.Rows[row].Cells[8].Value != null && dgv.Rows[row].Cells[8].Value.ToString() != "" && dgv.Rows[row].Cells[9].Value != null && dgv.Rows[row].Cells[9].Value.ToString() != "")
                {
                    dgv.Rows[row].Cells[10].Value = query[2].Interval.ToString();
                }
                else
                {
                    dgv.Rows[row].Cells[10].Value = "";

                }
                dgv.Rows[row].Cells[0].Selected = false;
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

        private void dgvUpdateSchedule_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 6 || e.ColumnIndex == 9)
                {
                    if (dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != ""

                        && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString() != "")
                    {
                        if (DateTime.Parse(dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString()) >= DateTime.Parse(dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                        {
                            MessageBox.Show("End Time Should Greater Than the Start time,Please check!");
                            e.Cancel = true;
                            dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                        }
                    }

                }
                if (e.ColumnIndex == 5 || e.ColumnIndex == 8)
                {
                    if (dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != string.Empty
                        && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value != null && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString() != string.Empty)
                    {
                        if (DateTime.Parse(dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) <= DateTime.Parse(dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString()))
                        {
                            MessageBox.Show("Time should greater than the previous time slot,Please check!");
                            e.Cancel = true;
                            dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                        }
                    }
                }

                if (e.ColumnIndex == 4 || e.ColumnIndex == 7 || e.ColumnIndex == 10)
                {
                    if (dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        if (dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString() != string.Empty
                            && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value != null && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString() != string.Empty)
                        {
                            int i;
                            //int di = 0;
                            if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                            {
                                e.Cancel = true;
                                MessageBox.Show("please enter numeric");
                                dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                            }

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


        private void mnuClear_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //oDTime.Visible = false;
            dgvUpdateSchedule.CurrentCell.Value = "";
        }

        private DoctorWeekDays PopulateVerifyDoctorSchedule()
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

            oDWD.StartDate = dtpStartDate.Value.ToString("dd-MM-yyyy");
            oDWD.LastDate = dtpEndDate.Value.ToString("dd-MM-yyyy");
            return oDWD;
        }
        int count;
        private void buttonCreate_Click(object sender, EventArgs e)
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
                TimeSpan diff = (DateTime.Parse(dtpEndDate.Value.ToString()).Subtract(DateTime.Parse(dtpStartDate.Value.ToString())));
                int difresult = diff.Days;

                if (!(dtpStartDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= dtpStartDate.Value))
                {
                    MessageBox.Show("The date range should in future date , Please check !!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }      
                count = 0;
                for (int i = 0; i < dgvDoctorSchedule.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvDoctorSchedule.Rows[i].Cells[0].Value) == true)
                    {
                        count++;
                    }
                }
                if (count > difresult)
                {
                    MessageBox.Show("Date diffrence should grater than number of week days", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpEndDate.Focus();
                    return;
                }
                for (int i = 0; i < dgvDoctorSchedule.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvDoctorSchedule.Rows[i].Cells[0].Value) == false)
                    {
                        for (int col = 2; col < dgvDoctorSchedule.Columns.Count; col++)
                        {
                            dgvDoctorSchedule.Rows[i].Cells[col].Value = "";
                        }
                    }
                }
                DoctorWeekDays verify = this.PopulateVerifyDoctorSchedule();
                short j = clnt.VerifyDoctorSchedule(verify);
                if (j == 1)
                {
                        bool check = CheckValidation(dgvDoctorSchedule);
                        if (check == false)
                        {
                            return;
                        }
                        oDateTimePicker.Visible = false;
                        try
                        {
                            DoctorWeekDays oDoctorTiming = this.PopulateDoctorTiming(dgvDoctorSchedule);
                            short i = clnt.SaveDoctorTiming(oDoctorTiming);

                            if (i == 1)
                            {
                                MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }                      
                            else
                            {
                                MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                }
              
                else
                {
                    MessageBox.Show("You have already this date range ! You can update or delete ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool check = CheckValidation(dgvDeleteSchedule);
            if (check == false)
            {
                return;
            }
            if (MessageBox.Show("Are You Sure to Parmanently Delete Calendar?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DoctorWeekDays oDoctorTiming = this.PopulateDoctorTiming(dgvDeleteSchedule);
                    short i = clnt.DeleteDoctorSchedule(oDoctorTiming);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (i == 1)
                    {
                        MessageBox.Show(Utility.DeleteMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                    }
                    else if (i == 2)
                    {
                        MessageBox.Show("Please check ,is there any patient on these time!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check = CheckValidation(dgvUpdateSchedule);
            if (check == false)
            {
                return;
            }
            oDTime.Visible = false;

            for (int i = 0; i < dgvUpdateSchedule.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvUpdateSchedule.Rows[i].Cells[0].Value) == false)
                {
                    for (int col = 2; col < dgvUpdateSchedule.Columns.Count; col++)
                    {
                        dgvUpdateSchedule.Rows[i].Cells[col].Value = "";
                    }
                }
            }
       

            try
            {
                DoctorWeekDays verify = this.PopulateVerifyDoctorSchedule();
                short j = clnt.VerifyDoctorSchedule(verify);
                if (j == 1)
                {
                    MessageBox.Show("First You need to create calendar during these date range!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DoctorWeekDays oDoctorTiming = this.PopulateDoctorTiming(dgvUpdateSchedule);
                short i = clnt.ModifyDoctorCalendar(oDoctorTiming);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i == 1)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbCalendar_SelectedIndexChanged(sender, e); 
                }
                else if (i == 2)
                {
                    MessageBox.Show("Please check ,is there any patient on these time!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool CheckValidation(DataGridView dgv)
        {
            flag = "";
            List<string> vf = new List<string>() { "cboDepartmentID", "cboUnitID", "cboDoctorID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            if (!(dtpStartDate.Value >= DateTime.Now.Date && dtpEndDate.Value >= DateTime.Now.Date &&  dtpStartDate.Value<=dtpEndDate.Value))
            {

                MessageBox.Show("The date range should in future date , Please check !!!!! ", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv.Rows[i].Cells[0].Value) == true)
                {
                    flag = "ok";
                    break;
                }
            }
            if(flag=="ok")
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgv.Rows[i].Cells[0].Value) == true)
                    {
                        if (dgv.Rows[i].Cells[2].Value == null || dgv.Rows[i].Cells[2].Value.ToString() ==string.Empty||
                            dgv.Rows[i].Cells[3].Value == null || dgv.Rows[i].Cells[3].Value.ToString() == string.Empty ||
                            dgv.Rows[i].Cells[4].Value == null || dgv.Rows[i].Cells[4].Value.ToString() ==string.Empty)
                        {
                            MessageBox.Show("First Time Slot Can not be null!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                           
                            return false;
                        }
                        if (dgv.Rows[i].Cells[5].Value != null && dgv.Rows[i].Cells[5].Value.ToString().Trim () != string.Empty)
                        {
                            if (dgv.Rows[i].Cells[5].Value == null || dgv.Rows[i].Cells[5].Value.ToString() == string.Empty ||
                            dgv.Rows[i].Cells[6].Value == null || dgv.Rows[i].Cells[6].Value.ToString() == string.Empty ||
                            dgv.Rows[i].Cells[7].Value == null || dgv.Rows[i].Cells[7].Value.ToString() == string.Empty)
                            {
                                MessageBox.Show("Second Time Slot Can not be null!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                        if (dgv.Rows[i].Cells[8].Value != null && dgv.Rows[i].Cells[8].Value.ToString().Trim()!=string.Empty)
                        {
                           if (dgv.Rows[i].Cells[8].Value == null || dgv.Rows[i].Cells[8].Value.ToString() == string.Empty ||
                           dgv.Rows[i].Cells[9].Value == null || dgv.Rows[i].Cells[9].Value.ToString() == string.Empty ||
                           dgv.Rows[i].Cells[10].Value == null || dgv.Rows[i].Cells[10].Value.ToString() == string.Empty)
                            {
                                MessageBox.Show("Third Time Slot Can not be null!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                    }

                }
                return true;
            }   
            else
            {
                MessageBox.Show("Please Select a day name !", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);           
                return false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblUpDateExist.Text = "";
            lblDateExist.Text = "";
            if (tbCalendar.SelectedTab == tbCreateSchedule)
            {
                for (int i = 0; i<dgvDoctorSchedule.Rows.Count; i++)
                {
                    for (int j = 2; j < dgvDoctorSchedule.ColumnCount; j++)
                    {
                        if(dgvDoctorSchedule.Rows[i].Cells[j].Value!=null ||dgvDoctorSchedule.Rows[i].Cells[j].Value!=null )
                        {
                            dgvDoctorSchedule.Rows[i].Cells[j].Value = "";
                            dgvDoctorSchedule.Rows[i].Cells[0].Value = false;
                        }
                    }
                }
            }
            if (tbCalendar.SelectedTab == tbUpdate)
            {
                for (int i = 0; i < dgvUpdateSchedule.Rows.Count; i++)
                {
                    for (int j = 2; j < dgvUpdateSchedule.ColumnCount; j++)
                    {
                        if (dgvUpdateSchedule.Rows[i].Cells[j].Value != null || dgvUpdateSchedule.Rows[i].Cells[j].Value != null)
                        {
                            dgvUpdateSchedule.Rows[i].Cells[j].Value = "";
                            dgvUpdateSchedule.Rows[i].Cells[0].Value = false;
                        }
                    }
                }
            }
            if (tbCalendar.SelectedTab == tbDelete)
            {
                for (int i = 0; i < dgvDeleteSchedule.Rows.Count; i++)
                {
                    for (int j = 2; j < dgvDeleteSchedule.ColumnCount; j++)
                    {
                        if (dgvDeleteSchedule.Rows[i].Cells[j].Value != null || dgvDeleteSchedule.Rows[i].Cells[j].Value != null)
                        {
                            dgvDeleteSchedule.Rows[i].Cells[j].Value = "";
                            dgvDeleteSchedule.Rows[i].Cells[0].Value = false;

                        }
                    }
                }
            }
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            //cboDepartmentID.Enabled = true;
            //cboUnitID.Enabled = true;
            //cboDoctorID.Enabled = true;
            //if (tbCalendar.SelectedTab == tbShow)
            //{
                dgvDoctorTiming.Columns.Clear();              
          //  }
        }
        private void FormatGrid()
        {
            lstDoctorName.CheckBoxes = false;
            lstDoctorName.Columns.Add("ID",60, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Doctor Name", 200, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Department Id", 0, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Department Name",0, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Unit Id", 0, HorizontalAlignment.Left);
            lstDoctorName.Columns.Add("Unit Name", 0, HorizontalAlignment.Left);

        }
        private void ListLoad(List<OPDDoctor> docList)
        {        
            lstDoctorName.Items.Clear();        
            foreach (OPDDoctor OpdDr in docList)
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
            lstDoctorName.Items.Clear();         
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

        private void txtDoctorName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListDoctorList(docList, txtDoctorName.Text);
        }

        private void lstDoctorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor = "";
            if (lstDoctorName.SelectedItems.Count > 0)
            {
                btnNew.PerformClick();
                ListViewItem itm = lstDoctorName.SelectedItems[0];
                cboDepartmentID.Text = itm.SubItems[2].Text;
                cboDoctorID.Text = itm.SubItems[1].Text;
               // txtDoctorName.Text = itm.SubItems[1].Text;
                DepartmentUnit = itm.SubItems[5].Text;
                Doctor = itm.SubItems[1].Text;
                cboUnitID.Text = DepartmentUnit;
                //cboDepartmentID.Enabled = false;
                //cboUnitID.Enabled = false;
                //cboDoctorID.Enabled = false;
               // btnRefresh.PerformClick();
            }           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbCalendar_SelectedIndexChanged(sender, e);
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

     

        private void dgvUpdateSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvUpdateSchedule.CurrentRow.Cells[1].ReadOnly = true;
            if (e.ColumnIndex > 1 && e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(dgvUpdateSchedule.CurrentRow.Cells[0].Value) == true)
                {
                    if (dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null)
                    {
                        dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                        dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    }
                    else
                    {
                        dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                        dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    }
                }
                else
                {
                    dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                    dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                }

            }
          
            dgvUpdateSchedule.CurrentRow.Cells[0].ReadOnly = false;
            dgvUpdateSchedule.CurrentRow.Cells[1].ReadOnly = true;

        }

    
        private void dgvUpdateSchedule_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //oDTime.Visible = false;
            //dgvDoctorSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
              //  && dgvUpdateSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()!=string.Empty)
            {
                if (e.Button == MouseButtons.Right)
                {
                    oDTime.Visible = false;
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.dgvUpdateSchedule.CurrentCell = clickedCell;  // Select the clicked cell, for instance              
                    var relativeMousePosition = dgvUpdateSchedule.PointToClient(Cursor.Position);
                    mnuClear.Show(dgvUpdateSchedule, relativeMousePosition);

                }
            }          
        }

        private void btnClearDateTimePicker_Click(object sender, EventArgs e)
        {
            if (dgvUpdateSchedule.Columns[5].Name == "sTime")
            {
                oDTime.Visible = false;
                dgvUpdateSchedule.Rows[0].Cells[5].Value = "";
            }

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        string FirstTime, SecondTime, Interval,Day;
        private void TakePreviousValue()
        {
            Day = ""; FirstTime = ""; SecondTime = ""; Interval = "";
            for (int row = 0; row < dgvDoctorSchedule.Rows.Count; row++)
            {
                if (Convert.ToBoolean(dgvDoctorSchedule.Rows[row].Cells[0].Value) == true && dgvDoctorSchedule.Rows[row].Cells[2].Value!=null &&
                    dgvDoctorSchedule.Rows[row].Cells[2].Value.ToString()!=string.Empty &&  dgvDoctorSchedule.Rows[row].Cells[3].Value!=null &&  
                    dgvDoctorSchedule.Rows[row].Cells[4].Value!=null)
                {
                     Day = dgvDoctorSchedule.Rows[row].Cells[0].ToString();
                     FirstTime = dgvDoctorSchedule.Rows[row].Cells[2].Value.ToString();
                     SecondTime= dgvDoctorSchedule.Rows[row].Cells[3].Value.ToString();
                     Interval  = dgvDoctorSchedule.Rows[row].Cells[4].Value.ToString();
                     break;
                }
            }
        }
        private void btnSame_Click(object sender, EventArgs e)
        {
            TakePreviousValue();
            for (int row = 0; row < dgvDoctorSchedule.Rows.Count; row++)
            {
                if (Convert.ToBoolean(dgvDoctorSchedule.Rows[row].Cells[0].Value) == true)
                {
                    Day = dgvDoctorSchedule.Rows[row].Cells[0].Value.ToString();
                    dgvDoctorSchedule.Rows[row].Cells[2].Value = FirstTime;
                    dgvDoctorSchedule.Rows[row].Cells[3].Value = SecondTime;
                    dgvDoctorSchedule.Rows[row].Cells[4].Value = Interval;
                }
            }
        }

        private void chkSameTime_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSameTime.Checked==true)
            {
                TakePreviousValue();       
                for (int row = 0; row < dgvDoctorSchedule.Rows.Count; row++)
                {
                    if (Convert.ToBoolean(dgvDoctorSchedule.Rows[row].Cells[0].Value) == true)
                    {
                        dgvDoctorSchedule.Rows[row].Cells[2].Value = FirstTime;
                        dgvDoctorSchedule.Rows[row].Cells[3].Value = SecondTime;
                        dgvDoctorSchedule.Rows[row].Cells[4].Value = Interval;
                    }
                }
            }
            if (chkSameTime.Checked == false)
            {
                for (int row = 0; row < dgvDoctorSchedule.Rows.Count; row++)
                {
                    dgvDoctorSchedule.Rows[row].Cells[0].Value = false;
                    dgvDoctorSchedule.Rows[row].Cells[2].Value = "";
                    dgvDoctorSchedule.Rows[row].Cells[3].Value = "";
                    dgvDoctorSchedule.Rows[row].Cells[4].Value = "";
                }
                for (int row = 0; row < dgvDoctorSchedule.Rows.Count; row++)
                {
                    if (dgvDoctorSchedule.Rows[row].Cells[0].ToString() == Day)
                    {
                        dgvDoctorSchedule.Rows[row].Cells[0].Value=true;
                        dgvDoctorSchedule.Rows[row].Cells[2].Value = FirstTime;
                        dgvDoctorSchedule.Rows[row].Cells[3].Value = SecondTime;
                        dgvDoctorSchedule.Rows[row].Cells[4].Value = Interval;
                    }
                }
            }
        }
        private void TakePreviousTimeForUpdate()
        {
            Day = ""; FirstTime = ""; SecondTime = ""; Interval = "";
            for (int row = 0; row < dgvDoctorSchedule.Rows.Count; row++)
            {
                if (Convert.ToBoolean(dgvUpdateSchedule.Rows[row].Cells[0].Value) == true && dgvUpdateSchedule.Rows[row].Cells[2].Value != null &&
                    dgvUpdateSchedule.Rows[row].Cells[2].Value.ToString() != string.Empty && dgvUpdateSchedule.Rows[row].Cells[3].Value != null &&
                    dgvUpdateSchedule.Rows[row].Cells[4].Value != null)
                {
                    Day = dgvUpdateSchedule.Rows[row].Cells[0].ToString();
                    FirstTime = dgvUpdateSchedule.Rows[row].Cells[2].Value.ToString();
                    SecondTime = dgvUpdateSchedule.Rows[row].Cells[3].Value.ToString();
                    Interval = dgvUpdateSchedule.Rows[row].Cells[4].Value.ToString();
                    break;
                }
            }
        }
        private void chkSameTimeUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSameTimeUpdate.Checked == true)
            {
                TakePreviousTimeForUpdate();
                for (int row = 0; row < dgvUpdateSchedule.Rows.Count; row++)
                {
                    if (Convert.ToBoolean(dgvUpdateSchedule.Rows[row].Cells[0].Value) == true)
                    {
                        dgvUpdateSchedule.Rows[row].Cells[2].Value = FirstTime;
                        dgvUpdateSchedule.Rows[row].Cells[3].Value = SecondTime;
                        dgvUpdateSchedule.Rows[row].Cells[4].Value = Interval;
                    }
                }
            }
            if (chkSameTimeUpdate.Checked == false)
            {
                for (int row = 0; row < dgvUpdateSchedule.Rows.Count; row++)
                {
                    dgvUpdateSchedule.Rows[row].Cells[0].Value = false;
                    dgvUpdateSchedule.Rows[row].Cells[2].Value = "";
                    dgvUpdateSchedule.Rows[row].Cells[3].Value = "";
                    dgvUpdateSchedule.Rows[row].Cells[4].Value = "";
                }
                for (int row = 0; row < dgvUpdateSchedule.Rows.Count; row++)
                {
                    if (dgvUpdateSchedule.Rows[row].Cells[0].ToString() == Day)
                    {
                        dgvUpdateSchedule.Rows[row].Cells[0].Value = true;
                        dgvUpdateSchedule.Rows[row].Cells[2].Value = FirstTime;
                        dgvUpdateSchedule.Rows[row].Cells[3].Value = SecondTime;
                        dgvUpdateSchedule.Rows[row].Cells[4].Value = Interval;
                    }
                }
            }
        }
    }
 }
