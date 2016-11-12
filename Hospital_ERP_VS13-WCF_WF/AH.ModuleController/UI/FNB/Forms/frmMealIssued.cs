using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;
using System.Collections.Generic;
using System;



namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmMealIssued : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        List<MealSetup> MealTime;
        public frmMealIssued()
        {
            InitializeComponent();
            timer1.Start();
        }



        private void GetEmpDetails(string strCardNo)
        {
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = fnbs.GetEmpMaster(strCardNo);

            if (txtEmpID.Text == oEmpMas.EmpId)
            {
                txtEmpName.Text = oEmpMas.FirstName;
                txtDepName.Text = oEmpMas.Department.DepartmentTitle;
                txtDesName.Text = oEmpMas.Designation.DesignationId;
                //txtUnitName.Text = oEmpMas.DepartmentUnit.UnitId;

            }
        }

        private void txtEmpID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                GetEmpDetails(txtEmpID.Text);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtweekdayno.Text = GetWeekday(txtWeekDayName.Text).ToString();
            txtsystemTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            string strParticulars = GetShiftingTimeSlot(Convert.ToDateTime(txtsystemTime.Text), MealTime);
            var results = strParticulars.Split(new string[] { "-" }, StringSplitOptions.None);

            txtParticulars.Text = results[0].ToString();
            txtParID.Text = results[1].ToString();
            
        }


        private static int GetWeekday(string strWeekName)
        {
            int inday = 0;
            if (strWeekName == "Sunday")
            {
                inday = 0;
            }
            else if (strWeekName == "Monday")
            {
                inday = 1;
            }

            else if (strWeekName == "Tuesday")
            {
                inday = 2;

            }
            else if (strWeekName == "Wednesday")
            {
                inday = 3;
            }
            else if (strWeekName == "Thursday")
            {
                inday = 4;
            }
            else if (strWeekName == "Friday")
            {
                inday = 5;
            }
            else if (strWeekName == "Saturday")
            {
                inday = 6;
            }

            return inday;

        }
        private static string GetWeekday(int inDay)
        {
            string strDay = "";
            if (inDay == 0)
            {
                strDay = "Sunday";
            }
            else if (inDay == 1)
            {
                strDay = "Monday";
            }

            else if (inDay == 2)
            {
                strDay = "Tuesday";

            }
            else if (inDay == 3)
            {
                strDay = "Wednesday";
            }
            else if (inDay == 4)
            {
                strDay = "Thursday";
            }
            else if (inDay == 5)
            {
                strDay = "Friday";
            }
            else if (inDay == 6)
            {
                strDay = "Saturday";
            }

            return strDay;

        }
        private static string GetShiftingTimeSlot(DateTime Intime, List<MealSetup> ds)
        {
            string starttime = "", endtime = "", particulars = "", ParId = "";

            foreach (MealSetup objmeal in ds)
            {
                starttime = objmeal.StartTime;
                endtime = objmeal.EndTime;
                particulars = objmeal.MealName;
                ParId = objmeal.MealID;

                DateTime BeginTime = DateTime.Parse(starttime);
                DateTime EndTime = DateTime.Parse(endtime);
                if ((Intime <= BeginTime || Intime < EndTime))
                {
                    return particulars + "-" + ParId;
                }

            }

            return particulars + "-" + ParId;
        }

        private void frmMealIssued_Load(object sender, EventArgs e)
        {
            txtWeekDayName.Text = DateTime.Today.ToString("dddd");
            txtweekdayno.Text = GetWeekday(txtWeekDayName.Text).ToString();
          

            MealTime = fnbs.GetMealTime().ToList();
            timer1.Interval = 500;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Cannot empty");
                txtEmpID.Focus();
                return;
            }
            try
            {
                DateTime dtedate = DateTime.Now;
                string strDate = dtedate.ToString("dd/MM/yyyy");

                short isSuccess = fnbs.UpdateIssue(txtEmpID.Text.ToString(), txtParID.Text.ToString(), strDate);
                if (isSuccess == 1)
                {
                    MessageBox.Show("Issue Success...");
                    txtEmpID.Text = "";
                    txtEmpName.Text = "";
                    txtDepName.Text = "";
                    txtDesName.Text = "";
                    txtEmpID.Focus();

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

        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char) Keys.Return)
            {
                btnSave.Focus();
            }
        }






















    }
}
