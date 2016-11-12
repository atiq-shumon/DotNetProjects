using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.OPDSR;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmOPDDoctor : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();

        List<OPDDoctor> oOPDDoctorList= new List<OPDDoctor>();

        List<Room> oRooms = new List<Room>();

        public frmOPDDoctor()
        {
            InitializeComponent();
        }
        string BuildingID = "01";
        string RmType = "07";
        OPDDoctor oOPDDoctor = new OPDDoctor();
        private void frmDoctorRoomSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            DepartmentCbo();
            GetNursesStationId();
            LoadDoctor();
            cboDepartment.Select();
            btnEdit.Enabled = false;
        }
        private void GetNursesStationId()
        {
            cboRoomGroup.ValueMember = "Key";
            cboRoomGroup.DisplayMember = "Value";
            cboRoomGroup.DataSource = new BindingSource(opdSc.GetNurseStationDic("D"), null); 
        }
        private void cboRoomGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomNo(cboRoomGroup.SelectedValue.ToString());
        }

        private void RoomNo(string roomGroup)
        {
            cboRoomNo.ValueMember = "RoomID";
            cboRoomNo.DisplayMember = "RoomNo";
            cboRoomNo.DataSource = opdSc.GetRoomGroupByID(cboRoomGroup.SelectedValue.ToString()).ToList();// oRooms;   
        }
        private void DepartmentCbo()
        {
            cboDepartment.DisplayMember = "Value";
            cboDepartment.ValueMember = "Key";
            cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical))), null);
        }
        private void UnitCbo()
        {

            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboDepartment.SelectedValue.ToString())), null);
            }
        }

        private void LoadDoctor()
        {
            if (cboDepartment.SelectedValue != null && cboUnit.SelectedValue != null)
            {
                cboDoctor.ValueMember = "Key";
                cboDoctor.DisplayMember = "Value";
                cboDoctor.DataSource = new BindingSource(opdSc.GetOPDDoctorDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()), null);
                //cboDoctor.DataSource = opdSc.GetOPDDoctorDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()).ToList();
            }
            //cboDoctor.DataSource = new BindingSource(Utility.VerifyDic(opdSc.GetOPDDoctorsDict(cboDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString())), null);     
        }

        private OPDDoctor PopulateObject()
        {

            oOPDDoctor.RoomGroup = cboRoomGroup.SelectedValue.ToString();

            Room oRoom = new Room();
            oRoom.RoomID = cboRoomNo.SelectedValue.ToString();
            oOPDDoctor.Room = oRoom;

            Department odept = new Department();
            odept.DepartmentID = cboDepartment.SelectedValue.ToString();      
            oOPDDoctor.Department = odept;

            DepartmentUnit deptUnit = new DepartmentUnit();
            deptUnit.UnitId = cboUnit.SelectedValue.ToString();
            deptUnit.UnitTitle = cboUnit.SelectedText.ToString();
            oOPDDoctor.DepartmentUnit = deptUnit;

           // oOPDDoctor.Unit = cboUnit.SelectedValue.ToString();

            Doctor oDoctor = new Doctor();
            oDoctor.ID = cboDoctor.SelectedValue.ToString();
            oDoctor.Name = cboDoctor.Text;
            oOPDDoctor.Doctor = oDoctor;

            DateTime var1 = dtpVStart.Value;
            string sub1 = var1.ToString("hh : mm tt");
            oOPDDoctor.VisStartTime = sub1;

            //oOPDDoctor.VisStartTime = dtpVStart.Value.ToString();

            DateTime var2 = dtpVisitEnd.Value;
            string sub2 = var2.ToString("hh : mm tt");
            oOPDDoctor.VisEndTime = sub2;
            //oOPDDoctor.VisEndTime = dtpVisitEnd.Value.ToString();

            //DateTime dt1 = DateTime.Parse(dtpVStart.Value.ToString());
            //DateTime dt2 = DateTime.Parse(dtpVisitEnd.Value.ToString());

            //oOPDDoctor.VisStartTime = dt1.ToString("hh : mm tt").ToString();
            //oOPDDoctor.VisEndTime = dt2.ToString("hh : mm tt").ToString();

            oOPDDoctor.VisFirst = txtFirstVisit.Text;
            oOPDDoctor.DrVisFirst = txtDrFirstVisit.Text;
            oOPDDoctor.VisSecond = txtSecondVisit.Text;
            oOPDDoctor.DrVisSecond = txtDrSecondVisit.Text;

            oOPDDoctor.VisThird = txtThirdVisit.Text;
            oOPDDoctor.DrVisThird = txtDrThirdVisit.Text;
            oOPDDoctor.VisFourth = txtFourthVisit.Text;
            oOPDDoctor.DrVisFourth = txtDrFourthVisit.Text;

            oOPDDoctor.RptVisit = txtRptVisit.Text;
            oOPDDoctor.DrRptVisit = txtDrRptVisit.Text;

            oOPDDoctor.VisitCycle = txtVisitCycle.Text;
            oOPDDoctor.MaxPatBar = txtMaxPat.Text;
            oOPDDoctor.AvgPatMin = txtAvgPatTime.Text;
            
            oOPDDoctor.DegreeLine1 = txtDegree1.Text; 
            oOPDDoctor.DegreeLine2 = txtDegree2.Text;  
            oOPDDoctor.DegreeLine3 = txtDegree3.Text;
            oOPDDoctor.DegreeLine4 = txtDegree4.Text;

            EntryParameter oEP = new EntryParameter();
            oEP.CompanyID = Utility.CompanyID;
            oEP.LocationID = Utility.LocationID; 
            oEP.MachineID = Utility.MachineID;
            oEP.EntryBy = Utility.UserId;

            oOPDDoctor.EntryParameter = oEP;

            oOPDDoctorList.Add(oOPDDoctor);

            return oOPDDoctor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDoctor", "cboRoomNo", "dtpVStart", "dtpVisitEnd", 
                                                    "txtFirstVisit", "txtSecondVisit", "txtThirdVisit", "txtFourthVisit", "txtRptVisit", 
                                                    "txtDrFirstVisit", "txtDrSecondVisit", "txtDrThirdVisit", "txtDrFourthVisit", "txtDrRptVisit",
                                                    "txtVisitCycle", "txtAvgPatTime", "txtMaxPat" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
           
            oOPDDoctorList = opdSc.InsertDoctorRoom(PopulateObject()).ToList();
            if (oOPDDoctorList.Count > 0)
                MessageBox.Show(Utility.InsertMsg,Utility.MessageSuccessCaption,MessageBoxButtons.OK,MessageBoxIcon.Information);

            lvlDocRoomSetup.Items.Clear();

            foreach (OPDDoctor oDSetup in oOPDDoctorList)
            {
                int RoomNo = Convert.ToInt16(oDSetup.Room.RoomNo);

                ListViewItem itm = new ListViewItem(oDSetup.RoomGroup);    //R Group
                itm.SubItems.Add(Convert.ToString(oDSetup.Room.RoomNo));   //R Number
                itm.SubItems.Add(Convert.ToString(oDSetup.Room.RoomID));
                itm.SubItems.Add(Convert.ToString(oDSetup.Department.DepartmentID));
         
                itm.SubItems.Add(Convert.ToString(oDSetup.DepartmentUnit.UnitId));
                itm.SubItems.Add(Convert.ToString(oDSetup.Doctor.ID));     //Dr ID
                itm.SubItems.Add(Convert.ToString(oDSetup.Doctor.Name));   //Dr Name

                //DateTime var1 = dtpVStart.Value;
                //string sub1 = var1.ToString("hh : mm tt");
                //oDSetup.VisStartTime = sub1;
                // string var = (var.ToString("hh : mm tt").toString();
                itm.SubItems.Add(oDSetup.VisStartTime); //Start Time

                //DateTime var2 = dtpVisitEnd.Value;
                //string sub2 = var2.ToString("hh : mm tt");
                //oDSetup.VisEndTime = sub2;
                itm.SubItems.Add(oDSetup.VisEndTime); //End Time

                itm.SubItems.Add(Convert.ToString(oDSetup.VisFirst));     //1st Visit
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisFirst));   //Dr 1st Visit
                itm.SubItems.Add(Convert.ToString(oDSetup.VisSecond));    //2nd Visit
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisSecond));  //Dr 2nd Visit

                itm.SubItems.Add(Convert.ToString(oDSetup.VisThird));     //3rd Visit
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisThird));   //Dr 3rd Visit
                itm.SubItems.Add(Convert.ToString(oDSetup.VisFourth));    //4th Visit
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisFourth));  //Dr 4th Visit

                itm.SubItems.Add(Convert.ToString(oDSetup.RptVisit));     //Rpt Visit
                itm.SubItems.Add(Convert.ToString(oDSetup.DrRptVisit));   //Dr Rpt Visit

                itm.SubItems.Add(Convert.ToString(oDSetup.VisitCycle));   //Visit Cycle
                itm.SubItems.Add(Convert.ToString(oDSetup.MaxPatBar));    //Max Pat Bar
                itm.SubItems.Add(Convert.ToString(oDSetup.AvgPatMin));    //Avg Pat Mins

                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine1));
                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine2));
                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine3));
                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine4));

                itm.SubItems.Add(Convert.ToString(oDSetup.EntryParameter.EntryDate)); //Entry Date
                itm.SubItems.Add(Convert.ToString(oDSetup.EntryParameter.EntryBy)); //Entry By

                lvlDocRoomSetup.Items.Add(itm);
            }
            
            this.lvlDocRoomSetup.View = View.Details;
            btnSave.Enabled = false;
            btnNew.PerformClick();
        }
        private void FormatGrid()
        {
            lvlDocRoomSetup.Columns.Add("Room Group", 100, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Room No", 0, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Room ID", 0, HorizontalAlignment.Left);

       
            lvlDocRoomSetup.Columns.Add("Department", 150, HorizontalAlignment.Left);

            lvlDocRoomSetup.Columns.Add("Unit", 150, HorizontalAlignment.Left);

            lvlDocRoomSetup.Columns.Add("Doctors ID", 0, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Doctors Name", 250, HorizontalAlignment.Left);

            lvlDocRoomSetup.Columns.Add("Start Time", 0, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("End Time", 0, HorizontalAlignment.Left);

            lvlDocRoomSetup.Columns.Add("1st Visit", 100, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Dr 1st Visit", 100, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("2nd Visit", 0, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Dr 2nd Visit", 0, HorizontalAlignment.Left);

            lvlDocRoomSetup.Columns.Add("3rd Visit", 0, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Dr 3rd Visit", 0, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("4th Visit", 0, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Dr 4th Visit", 0, HorizontalAlignment.Left);

            lvlDocRoomSetup.Columns.Add("Rpt Visit", 100, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Dr Rpt Visit", 100, HorizontalAlignment.Left);

            lvlDocRoomSetup.Columns.Add("Visit Cycle", 100, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Max Pat Bar", 100, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Avg Pat Mins", 100, HorizontalAlignment.Left);

            lvlDocRoomSetup.Columns.Add("Degree 1", 100, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Degree 2", 100, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Degree 3", 100, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Degree 4", 100, HorizontalAlignment.Left);

            lvlDocRoomSetup.Columns.Add("Entry Date", 0, HorizontalAlignment.Left);
            lvlDocRoomSetup.Columns.Add("Entry By", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvlDocRoomSetup.Items.Clear();

            oOPDDoctorList = opdSc.GetOPDDoctors().ToList();
   
            foreach (OPDDoctor oDSetup in oOPDDoctorList)
            {              
                int RoomNo = Convert.ToInt16(oDSetup.Room.RoomNo);

                ListViewItem itm = new ListViewItem(oDSetup.RoomGroup); //R Group //0

                itm.SubItems.Add(Convert.ToString(RoomNo)); //R Number //1

                itm.SubItems.Add(Convert.ToString(oDSetup.Room.RoomID)); //R Number //2

                
                itm.SubItems.Add(Convert.ToString(oDSetup.Department.DepartmentID));//3
                itm.SubItems.Add(Convert.ToString(oDSetup.DepartmentUnit.UnitTitle));//4

                itm.SubItems.Add(Convert.ToString(oDSetup.Doctor.ID)); //Dr Name //5
                itm.SubItems.Add(Convert.ToString(oDSetup.Doctor.Name)); //Dr Name  //6

                itm.SubItems.Add(Convert.ToString(oDSetup.VisStartTime)); //Start Time  //7
                itm.SubItems.Add(Convert.ToString(oDSetup.VisEndTime)); //End Time  //8 

                itm.SubItems.Add(Convert.ToString(oDSetup.VisFirst)); //1st Visit     //9
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisFirst)); //Dr 1st Visit   10
                itm.SubItems.Add(Convert.ToString(oDSetup.VisSecond));  //2nd Visit          11
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisSecond));  //Dr 2nd Visit  12

                itm.SubItems.Add(Convert.ToString(oDSetup.VisThird));  //3rd Visit  13
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisThird)); //Dr 3rd Visit 14
                itm.SubItems.Add(Convert.ToString(oDSetup.VisFourth)); //4th Visit 15
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisFourth)); //Dr 4th Visit 16

                itm.SubItems.Add(Convert.ToString(oDSetup.RptVisit));  //Rpt Visit  17
                itm.SubItems.Add(Convert.ToString(oDSetup.DrRptVisit));//Dr Rpt Visit  18

                itm.SubItems.Add(Convert.ToString(oDSetup.VisitCycle)); //Visit Cycle  19
                itm.SubItems.Add(Convert.ToString(oDSetup.MaxPatBar));  //Max Pat Bar 20
                itm.SubItems.Add(Convert.ToString(oDSetup.AvgPatMin));  //Avg Pat Mins  22

                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine1)); //23
                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine2)); //24
                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine3)); //25
                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine4)); //26

                itm.SubItems.Add(Convert.ToString(oDSetup.EntryParameter.EntryDate.ToString("dd-MM-yyyy"))); //Entry Date 27
                itm.SubItems.Add(Convert.ToString(oDSetup.EntryParameter.EntryBy)); //Entry By  28
               
                lvlDocRoomSetup.Items.Add(itm);
            }
            this.lvlDocRoomSetup.View = View.Details;
        }

        private void formatDateTimePicker()
        {
            dtpVStart.ShowUpDown = true;
            dtpVStart.CustomFormat = "HH:mm:ss";
            //dtpVStart.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpVStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            dtpVisitEnd.ShowUpDown = true;
            dtpVisitEnd.CustomFormat = "HH:mm:ss";
            //dtpVisitEnd.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpVisitEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }
       
       
        public class RefreshDataGrid
        {
            public string RoomGroup { get; set; }
            public string RoomNo { get; set; }
            public string RoomID { get; set; }
           
            public string Department { get; set; }
            public string Unit { get; set; }

            public string ID { get; set; }
            public string Name { get; set; }

            public string VisStartTime { get; set; }
            public string VisEndTime { get; set; }
            public string VisFirst { get; set; }
            public string DrVisFirst { get; set; }
            public string VisSecond { get; set; }
            public string DrVisSecond { get; set; }
            public string VisThird { get; set; }
            public string DrVisThird { get; set; }
            public string VisFourth { get; set; }
            public string DrVisFourth { get; set; }
            public string RptVisit { get; set; }
            public string DrRptVisit { get; set; }
            public string VisitCycle { get; set; }
            public string MaxPatBar { get; set; }
            public string AvgPatMin { get; set; }

            public string DegreeLine1 { get; set; }
            public string DegreeLine2 { get; set; }
            public string DegreeLine3 { get; set; }
            public string DegreeLine4 { get; set; }

            public string EntryBy { get; set; }
            public string EntryDate { get; set; }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {

            List<RefreshDataGrid> oRDGs = new List<RefreshDataGrid>();
            if (oOPDDoctorList.Count > 0)
            {
                for (int i = 0; i < oOPDDoctorList.Count; i++)
                {
                    if (oOPDDoctorList[i].RoomGroup == cboRoomGroup.SelectedValue.ToString())
                    {
                        RefreshDataGrid oRDG = new RefreshDataGrid();
                        int RN = Convert.ToInt16(oOPDDoctorList[i].Room.RoomNo);

                        oRDG.RoomGroup = oOPDDoctorList[i].RoomGroup;
                        oRDG.RoomNo = Convert.ToString(RN);
                        oRDG.RoomID = oOPDDoctorList[i].Room.RoomID;

                        oRDG.Department = oOPDDoctorList[i].Department.DepartmentID;
                        oRDG.Unit = oOPDDoctorList[i].DepartmentUnit.UnitTitle;

                        oRDG.ID = oOPDDoctorList[i].Doctor.ID;
                        oRDG.Name = oOPDDoctorList[i].Doctor.Name;


                        oRDG.VisStartTime = oOPDDoctorList[i].VisStartTime;
                        //oRDG.VisStartTime = Convert.ToString(oOPDDoctorList[i].VisStartTime);
                        //oRDG.VisEndTime = Convert.ToString(oOPDDoctorList[i].VisEndTime);
                        oRDG.VisEndTime = oOPDDoctorList[i].VisEndTime;

                        oRDG.VisFirst = oOPDDoctorList[i].VisFirst;
                        oRDG.DrVisFirst = oOPDDoctorList[i].DrVisFirst;
                        oRDG.VisSecond = oOPDDoctorList[i].VisSecond;
                        oRDG.DrVisSecond = oOPDDoctorList[i].DrVisSecond;

                        oRDG.VisThird = oOPDDoctorList[i].VisThird;
                        oRDG.DrVisThird = oOPDDoctorList[i].DrVisThird;
                        oRDG.VisFourth = oOPDDoctorList[i].VisFourth;
                        oRDG.DrVisFourth = oOPDDoctorList[i].DrVisFourth;

                        oRDG.RptVisit = oOPDDoctorList[i].RptVisit;
                        oRDG.DrRptVisit = oOPDDoctorList[i].DrRptVisit;

                        oRDG.VisitCycle = oOPDDoctorList[i].VisitCycle;
                        oRDG.MaxPatBar = oOPDDoctorList[i].MaxPatBar;
                        oRDG.AvgPatMin = oOPDDoctorList[i].AvgPatMin;

                        oRDG.DegreeLine1 = oOPDDoctorList[i].DegreeLine1;
                        oRDG.DegreeLine2 = oOPDDoctorList[i].DegreeLine2;
                        oRDG.DegreeLine3 = oOPDDoctorList[i].DegreeLine3;
                        oRDG.DegreeLine4 = oOPDDoctorList[i].DegreeLine4;

                        oRDG.EntryBy = oOPDDoctorList[i].EntryParameter.EntryBy;
                        oRDG.EntryDate = Convert.ToString(oOPDDoctorList[i].EntryParameter.EntryDate.ToString("dd-MM-yyyy"));

                        oRDGs.Add(oRDG);

                    }

                }
                lvlDocRoomSetup.Items.Clear();

                foreach (RefreshDataGrid oDSetup in oRDGs)
                {
                    ListViewItem itm = new ListViewItem(oDSetup.RoomGroup); //R Group
                    itm.SubItems.Add(oDSetup.RoomNo); //R Number
                    itm.SubItems.Add(oDSetup.RoomID); //R Number

                    itm.SubItems.Add(oDSetup.Department);
                    itm.SubItems.Add(oDSetup.Unit);

                    itm.SubItems.Add(oDSetup.ID);
                    itm.SubItems.Add(oDSetup.Name); //Dr Name

                    itm.SubItems.Add(oDSetup.VisStartTime); //Start Time
                    itm.SubItems.Add(oDSetup.VisEndTime); //End Time
                    itm.SubItems.Add(oDSetup.VisFirst); //1st Visit
                    itm.SubItems.Add(oDSetup.DrVisFirst); //Dr 1st Visit
                    itm.SubItems.Add(oDSetup.VisSecond);  //2nd Visit
                    itm.SubItems.Add(oDSetup.DrVisSecond);  //Dr 2nd Visit
                    itm.SubItems.Add(oDSetup.VisThird);  //3rd Visit
                    itm.SubItems.Add(oDSetup.DrVisThird); //Dr 3rd Visit
                    itm.SubItems.Add(oDSetup.VisFourth); //4th Visit
                    itm.SubItems.Add(oDSetup.DrVisFourth); //Dr 4th Visit
                    itm.SubItems.Add(oDSetup.RptVisit);  //Rpt Visit
                    itm.SubItems.Add(oDSetup.DrRptVisit);//Dr Rpt Visit
                    itm.SubItems.Add(oDSetup.VisitCycle);  //Visit Cycle
                    itm.SubItems.Add(oDSetup.MaxPatBar);  //Max Pat Bar
                    itm.SubItems.Add(oDSetup.AvgPatMin); //Avg Pat Mins

                    itm.SubItems.Add(oDSetup.DegreeLine1);
                    itm.SubItems.Add(oDSetup.DegreeLine2);
                    itm.SubItems.Add(oDSetup.DegreeLine3);
                    itm.SubItems.Add(oDSetup.DegreeLine4);

                    itm.SubItems.Add(oDSetup.EntryDate); //Entry Date
                    itm.SubItems.Add(oDSetup.EntryBy); //Entry By

                    lvlDocRoomSetup.Items.Add(itm);
                }
                this.lvlDocRoomSetup.View = View.Details;
            }
            else
            {
                MessageBox.Show("No Data Found ");
            }
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {   
            LoadDoctor();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                UnitCbo();
            }
            else
            {
                return;
            }        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() 
                                                { 
                                                  "cboDoctor", "cboRoomNo", "dtpVStart", "dtpVisitEnd", "txtFirstVisit", 
                                                  "txtSecondVisit", "txtThirdVisit", "txtFourthVisit", "txtRptVisit", 
                                                  "txtDrFirstVisit", "txtDrSecondVisit", "txtDrThirdVisit", "txtDrFourthVisit", 
                                                  "txtDrRptVisit", "txtVisitCycle", "txtAvgPatTime", "txtMaxPat" 
                                                };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            oOPDDoctorList = opdSc.InsertDoctorRoom(PopulateObject()).ToList();
            if (oOPDDoctorList.Count > 0)
               MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            lvlDocRoomSetup.Items.Clear();          
            foreach (OPDDoctor oDSetup in oOPDDoctorList)
            {
                int RoomNo = Convert.ToInt16(oDSetup.Room.RoomNo);

                ListViewItem itm = new ListViewItem(oDSetup.RoomGroup); //R Group         0
                itm.SubItems.Add(Convert.ToString(RoomNo)); //R Number       1
                itm.SubItems.Add(Convert.ToString(oDSetup.Room.RoomID)); //               2

                itm.SubItems.Add(Convert.ToString(oDSetup.Department.DepartmentID)); //   3
                itm.SubItems.Add(Convert.ToString(oDSetup.DepartmentUnit.UnitId));   //   4
                itm.SubItems.Add(Convert.ToString(oDSetup.Doctor.ID)); //Dr ID            5 
                itm.SubItems.Add(Convert.ToString(oDSetup.Doctor.Name)); //Dr Name        6

                itm.SubItems.Add(Convert.ToString(oDSetup.VisStartTime)); //Start Time    7
                itm.SubItems.Add(Convert.ToString(oDSetup.VisEndTime)); //End Time        8
                itm.SubItems.Add(Convert.ToString(oDSetup.VisFirst)); //1st Visit         9
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisFirst)); //Dr 1st Visit    10
                itm.SubItems.Add(Convert.ToString(oDSetup.VisSecond));  //2nd Visit       11
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisSecond));  //Dr 2nd Visit  12
                itm.SubItems.Add(Convert.ToString(oDSetup.VisThird));  //3rd Visit        13
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisThird)); //Dr 3rd Visit    14
                itm.SubItems.Add(Convert.ToString(oDSetup.VisFourth)); //4th Visit        15
                itm.SubItems.Add(Convert.ToString(oDSetup.DrVisFourth)); //Dr 4th Visit   16 
                itm.SubItems.Add(Convert.ToString(oDSetup.RptVisit));  //Rpt Visit        17
                itm.SubItems.Add(Convert.ToString(oDSetup.DrRptVisit));//Dr Rpt Visit     18
                itm.SubItems.Add(Convert.ToString(oDSetup.VisitCycle));  //Visit Cycle    19
                itm.SubItems.Add(Convert.ToString(oDSetup.MaxPatBar));  //Max Pat Bar     20
                itm.SubItems.Add(Convert.ToString(oDSetup.AvgPatMin)); //Avg Pat Mins     21

                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine1));  //              22
                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine2));  //              23
                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine3));  //              24
                itm.SubItems.Add(Convert.ToString(oDSetup.DegreeLine4));  //              25

                itm.SubItems.Add(Convert.ToString(oDSetup.EntryParameter.EntryDate)); //Entry Date  26
                itm.SubItems.Add(Convert.ToString(oDSetup.EntryParameter.EntryBy)); //Entry By      27

                lvlDocRoomSetup.Items.Add(itm);
            }
            this.lvlDocRoomSetup.View = View.Details;
            btnNew.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
    
        }

        private void lvlDocRoomSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            if (lvlDocRoomSetup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvlDocRoomSetup.SelectedItems[0];
                cboRoomGroup.SelectedValue = itm.SubItems[0].Text;
                cboRoomNo.Text = itm.SubItems[1].Text;
                cboDepartment.Text = itm.SubItems[3].Text;
                cboUnit.Text = itm.SubItems[4].Text;
                cboDoctor.Text = itm.SubItems[6].Text.Trim();

                dtpVStart.Text = itm.SubItems[7].Text;
                dtpVisitEnd.Text = itm.SubItems[8].Text;

                txtFirstVisit.Text = itm.SubItems[9].Text;
                txtDrFirstVisit.Text = itm.SubItems[10].Text;
                txtSecondVisit.Text = itm.SubItems[11].Text;
                txtDrSecondVisit.Text = itm.SubItems[12].Text;

                txtThirdVisit.Text = itm.SubItems[13].Text;
                txtDrThirdVisit.Text = itm.SubItems[14].Text;
                txtFourthVisit.Text = itm.SubItems[15].Text;
                txtDrFourthVisit.Text = itm.SubItems[16].Text;

                txtRptVisit.Text = itm.SubItems[17].Text;
                txtDrRptVisit.Text = itm.SubItems[18].Text;

                txtVisitCycle.Text = itm.SubItems[19].Text;
                txtMaxPat.Text = itm.SubItems[20].Text;
                txtAvgPatTime.Text = itm.SubItems[21].Text;

                txtDegree1.Text = itm.SubItems[22].Text;
                txtDegree2.Text = itm.SubItems[23].Text;
                txtDegree3.Text = itm.SubItems[24].Text;
                txtDegree4.Text = itm.SubItems[25].Text;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            LoadListView();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFirstVisit_TextChanged(object sender, EventArgs e)
        {
            txtSecondVisit.Text = txtFirstVisit.Text;
            txtThirdVisit.Text = txtFirstVisit.Text;
            txtFourthVisit.Text = txtFirstVisit.Text;
        }

        private void txtDrFirstVisit_TextChanged(object sender, EventArgs e)
        {
            txtDrSecondVisit.Text = txtDrFirstVisit.Text;
            txtDrThirdVisit.Text = txtDrFirstVisit.Text;
            txtDrFourthVisit.Text = txtDrFirstVisit.Text;
        }

        
    }
}
