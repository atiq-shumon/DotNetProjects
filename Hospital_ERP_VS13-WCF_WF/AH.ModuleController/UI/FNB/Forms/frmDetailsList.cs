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
using AH.ModuleController.UI.FNB.Reports.Viewer;
using AH.ModuleController.UI.FNB.Reports.ReportsUI;
using CrystalDecisions.CrystalReports.Engine;
namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmDetailsList : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public string Where, where1,type;


        public frmDetailsList()
        {
            InitializeComponent();
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
        private void FormaList()
        {
            lvwMenuItemSetup.CheckBoxes = false;
            lvwMenuItemSetup.Columns.Add("Meal Date", 200, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("wk_day_no", 200, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("Meal_id", 0, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("Setmenu Id", 0, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("Emp Id", 230, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("Bill", 0, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("Subsidy", 0, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("MealRegID", 0, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("BillRate", 0, HorizontalAlignment.Left);
            lvwMenuItemSetup.Columns.Add("Net Amount", 200, HorizontalAlignment.Left);

        }
        private void LoadListViewRegister(string Where, string where1)
        {
            try
            {

                lvwMenuItemSetup.Items.Clear();
                List<WeeklyEmpMealRegister> objempreg = fnbs.GetWeeklySetupregister(Where, where1).ToList();
                if (objempreg.Count > 0)
                {
                    foreach (WeeklyEmpMealRegister wr in objempreg)
                    {
                        ListViewItem itm = new ListViewItem(wr.MealDate);
                        itm.SubItems.Add(GetWeekday(Convert.ToInt16(wr.WeekDayNo)));
                        itm.SubItems.Add(wr.mealid);
                        itm.SubItems.Add(wr.Setmenuid);
                        itm.SubItems.Add(wr.empId);
                        itm.SubItems.Add(wr.Bill.ToString());
                        itm.SubItems.Add(wr.subsidy.ToString());
                        itm.SubItems.Add(wr.MealRegID.ToString());
                        //itm.SubItems.Add(wr.Billrate.ToString());
                        itm.SubItems.Add("0");
                        itm.SubItems.Add(wr.NetAmount.ToString());
                        lvwMenuItemSetup.Items.Add(itm);
                    }
                }
            }

            catch (System.ServiceModel.CommunicationException commp)
            {
                //  timer1.Stop();
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmDetailsList_Load(object sender, EventArgs e)
        {
            FormaList();
            frmLabel.Text = "Meal Register Details of " + type;
            LoadListViewRegister(Where,where1);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lvwMenuItemSetup.SelectedItems.Count > 0)
            {
                frmReportViewer frm = new frmReportViewer();
                ListViewItem itm = lvwMenuItemSetup.SelectedItems[0];
                frm.selector = ViewerSelector.BarcodeLevel;
                frm.Where = itm.SubItems[7].Text;
                frm.ShowDialog();
            }
        }
    }












}
