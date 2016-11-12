using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmOPRDashboard : AH.Shared.UI.frmSmartFormStandard
    {
        int direction = 1;
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        
        public frmOPRDashboard()
        {
            InitializeComponent();
            timer1.Start();
        }


        #region "FormLoad"
        private void frmOPRDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                this.Top = 70;
                lvwDasboard.Items.Clear();
                DisplayDashBord();
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
        #endregion
        #region "Dashboard"
        private void DisplayDashBord()
        {
            int intComplete = 0;
            int intEmergency = 0;
            int intCancel = 0;
            int intNormal = 0;
            try
            {
                lblDisplay.Text = "None";
                DateTime dtedate = Convert.ToDateTime(dteDashboardDate.Text.ToString());

                List<CalenderOT> objCal = new List<CalenderOT>();
                //objCal = accmSc.DisplayDashBoard("DisplayDashboard", dtedate.ToString("dd/MM/yyyy")).ToList();
                objCal = accmSc.DisplayDashBoard("DisplayDashboard", dtedate.ToString("dd/MM/yyyy")).ToList();
                if (objCal.Count > 0)
                {
                    lblDisplay.Text = "Schedule:";
                }
                foreach (CalenderOT cal in objCal)
                {
                    ListViewItem item = new ListViewItem();
                    if (cal.status == 0) //Normal
                    {
                        //item.Text = cal.RegNo + " -" + cal.Fromtime + " to " + cal.Totime;
                        item.Text = cal.RegNo + "|" + cal.ScheduleID;
                        lblDisplay.Text = lblDisplay.Text + "  " + cal.Fromtime + " to " + cal.Totime + " ";
                        intNormal = intNormal + 1;
                        item.ImageIndex = 8;
                        this.lvwDasboard.Items.Add(item);
                    }
                    else if (cal.status == 1) // Emergency
                    {
                        //item.Text = cal.RegNo + " -" + cal.Fromtime + " to " + cal.Totime;
                        item.Text = cal.RegNo + "|" + cal.ScheduleID;
                        lblDisplay.Text = lblDisplay.Text + " " + cal.Fromtime + " to " + cal.Totime;
                        intEmergency = intEmergency + 1;
                        item.ImageIndex = 7;
                        this.lvwDasboard.Items.Add(item);
                    }
                    else if (cal.status == 2) //Complete
                    {
                        //item.Text = cal.RegNo + " -" + cal.Fromtime + " to " + cal.Totime;
                        item.Text = cal.RegNo + "|" + cal.ScheduleID;
                        intComplete = intComplete + 1;
                        item.ImageIndex = 5;
                        this.lvwDasboard.Items.Add(item);
                    }
                    else if (cal.status == 3) //Cancel
                    {
                        //item.Text = cal.RegNo + " -" + cal.Fromtime + " to " + cal.Totime;
                        item.Text = cal.RegNo + "|" + cal.ScheduleID;
                        intCancel = intCancel + 1;
                        item.ImageIndex = 6;
                        this.lvwDasboard.Items.Add(item);
                    }
                }
                txtCancel.Text = intCancel.ToString();
                txtComplete.Text = intComplete.ToString();
                txtEmergency.Text = intEmergency.ToString();
                txtNormal.Text = intNormal.ToString();
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
        #endregion 
        #region"Timer"
        private void timer1_Tick(object sender, EventArgs e)

        {
            try
            {
                lblDisplay.Location = new Point(lblDisplay.Location.X + 1, lblDisplay.Location.Y);

                if (lblDisplay.Location.X > this.Width)
                {
                    lblDisplay.Location = new Point(0 - lblDisplay.Width, lblDisplay.Location.Y);
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

            //lblDisplay.Location = new Point(lblDisplay.Location.X + 1, lblDisplay.Location.Y);

            //if (lblDisplay.Location.X > this.Width)
            //{
            //    lblDisplay.Location = new Point(0 - lblDisplay.Width, lblDisplay.Location.Y);
            //}
            //lblDisplay.Location = new Point(lblDisplay.Location.X - 1, lblDisplay.Location.Y);

            //if (lblDisplay.Location.Y < this.Width)
            //{
            //    lblDisplay.Location = new Point(0 - lblDisplay.Width, lblDisplay.Location.X);
            //}
            //lblDisplay.Location = new Point(lblDisplay.Location.X - 1, lblDisplay.Location.Y);
            //if (lblDisplay.Location.Y <= this.Width)
            //{
            //    lblDisplay.Location = new Point(0 - lblDisplay.Width, lblDisplay.Location.X);
            //}
          
        }
        #endregion
        #region "Display"
        private void lblDisplay_Click(object sender, EventArgs e)
        {
            //DisplayDashBord();
        }
        private void dteDashboardDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lvwDasboard.Items.Clear();
                Clear();
                DisplayDashBord();
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
     
        private void DisplayRegInfo(string Where)
        {
            try
            {
                List<CalenderOT> cal = accmSc.DisplayPatregistration("DisplayPatientInfo", Where).ToList();
                foreach (CalenderOT objcal in cal)
                {
                    DateTime dtedate = Convert.ToDateTime(objcal.RegDate.ToString());
                    txtRegNo.Text = objcal.RegNo.ToString();
                    txtOTDate.Text = dtedate.ToString("dd/MM/yyyy");
                    txtRegName.Text = objcal.PatientName.ToString();
                    txtstarttime.Text = objcal.Fromtime.ToString();
                    txtEndtime.Text = objcal.Totime.ToString();
                    txtPackageName.Text = objcal.PackageName.ToString();
                    txtStatus.Text = objcal.status.ToString();
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
        private void DisplayDoctorsInfo(string Where)
        {
            //List<CalenderOT> cal = accmSc.DisplayPatregistration("DisplayPatientInfo", Where).ToList();
            int i = 0;
            try
            {
                List<CalenderOT> cal = accmSc.DisplayDoctorsInformation("DisplayDoctorsInfo", Where).ToList();
                foreach (CalenderOT objcal in cal)
                {
                    ListViewItem itm = new ListViewItem(objcal.DoctorsCode);
                    itm.SubItems.Add(objcal.doctorsName.ToString());
                    lvwDoctors.Items.Add(itm);
                    i = i + 1;
                }
                lblDoctorsTotal.Text = i.ToString();
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
        private void DisplayPackageInfo(string Where)
        {
            double dblAmount = 0;
            try
            {
                //List<CalenderOT> cal = accmSc.DisplayPatregistration("DisplayPatientInfo", Where).ToList();
                List<CalenderOT> cal = accmSc.DisplayPackageInformation("DisplayPackageInfo", Where).ToList();
                foreach (CalenderOT objcal in cal)
                {
                    ListViewItem itm = new ListViewItem(objcal.packageitem);
                    //itm.SubItems.Add(objcal.PackageName.ToString());
                    itm.SubItems.Add(objcal.packageitemRate.ToString());
                    dblAmount = dblAmount + Convert.ToDouble(objcal.packageitemRate.ToString());
                    lvwPackage.Items.Add(itm);
                }
                lblItemRate.Text = dblAmount.ToString();
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
        private void DisplayInchargeInfo(string Where)
        {
            //List<CalenderOT> cal = accmSc.DisplayPatregistration("DisplayPatientInfo", Where).ToList();
            try
            {
                List<CalenderOT> cal = accmSc.DisplayInchargeInformation("DisplayIncharge", Where).ToList();
                foreach (CalenderOT objcal in cal)
                {
                    txtInchargeName.Text = objcal.InchargeName.ToString();
                    txtTheaterName.Text = objcal.Thetername.ToString();
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
        #endregion
        #region "Clear"
        private void Clear()
        {
            txtRegNo.Text="";
            txtOTDate.Text=""; 
            txtRegName.Text="";
            txtstarttime.Text="";
            txtEndtime.Text="";
            txtPackageName.Text="";
            txtInchargeName.Text="";
            txtTheaterName.Text = "";
            lvwDoctors.Items.Clear();
            lvwPackage.Items.Clear();
            lblItemRate.Text = "0";
            lblDoctorsTotal.Text = "0";
        }
        #endregion
        #region "Selected Index"


        #endregion
        #region "Refresh"
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvwDasboard.Items.Clear();
            Clear();
            DisplayDashBord();
        }
        #endregion
        #region "Populated Calender"
        private CalenderOT PopulateCalender()
        {

            CalenderOT cal = new CalenderOT();
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            cal.EntryParameter = ep;
            return cal;
        }
        
        #endregion
        #region "Complete"
        private void mnuComplete_Click(object sender, EventArgs e)
        {
            CalenderOT objCal;
            var strResponse = MessageBox.Show("Do You Want to Complete the Operation?", "Ok Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (strResponse == DialogResult.Yes)
              {
                  string strname = lvwDasboard.SelectedItems[0].Text;
                  string strSchedulingID = strname.Substring(strname.LastIndexOf("|") + 1).Trim();
                  objCal = this.PopulateCalender();

                  string strHCN = "";
                  string strUnit = "";
                  string strDepID = "";
                  InPatient opjPat = accmSc.GetAdmittedPatient(txtRegNo.Text.ToString());
                  if (opjPat.HCN != null )
                  {
                      strHCN = opjPat.HCN.ToString();
                      strUnit = opjPat.Department.DepartmentID;
                      strDepID = opjPat.DepartmentUnit.UnitId;
                      string strSchedule = accmSc.UpdateOTstatus(strSchedulingID.ToString(), 2, strHCN, txtRegNo.Text.ToString(), strDepID, strUnit, Convert.ToInt64(lblItemRate.Text), objCal);
                      MessageBox.Show("OT Complete Success");
                      btnRefresh.PerformClick();
                  }
              }
        }
        private void mnuCancel_Click(object sender, EventArgs e)
        {
            CalenderOT objCal;
            if (txtStatus.Text.ToString() == "2")
            {
                MessageBox.Show ("Operation has done, So You Cannot Cancel");
                return ;
            }
            var strResponse = MessageBox.Show("Do You Want to Cancel the Operation?", "Ok Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {
                string strname = lvwDasboard.SelectedItems[0].Text;
                string strSchedulingID = strname.Substring(strname.LastIndexOf("|") + 1).Trim();
                objCal = this.PopulateCalender();

                string strSchedule = accmSc.UpdateOTstatus(strSchedulingID.ToString(), 3,"", txtRegNo.Text.ToString(),"","", Convert.ToInt64(lblItemRate.Text), objCal);
                MessageBox.Show("OT Cancel Success");
                btnRefresh.PerformClick();
            }
        }
        private void lvwDasboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Clear();
            if (lvwDasboard.SelectedItems.Count > 0)
            {
                lvwDoctors.Items.Clear();
                lvwPackage.Items.Clear();
                string strname = lvwDasboard.SelectedItems[0].Text;
                string strSchedulingID = strname.Substring(strname.LastIndexOf("|") + 1).Trim();
                DisplayRegInfo(strSchedulingID.ToString());
                DisplayDoctorsInfo(strSchedulingID.ToString());
                DisplayPackageInfo(strSchedulingID.ToString());
                DisplayInchargeInfo(strSchedulingID.ToString());
                //LoadListView();

          
        }
        }
        private void lvwDasboard_MouseDown(object sender, MouseEventArgs e)
        {
          
            if (e.Button == MouseButtons.Right)
            {
                var relativeMousePosition = lvwDasboard.PointToClient(Cursor.Position);
                this.mnuStrip.Show(lvwDasboard, relativeMousePosition);
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
