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
    public partial class frmEmpMealRegister : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        List<MealSetup> MealTime;
        public int intAttncheck = 0;
        private String reportTitle = "";
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        private String secondParameter = "";
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public frmEmpMealRegister()
        {
            InitializeComponent();
            timer1.Start();
        }
        #region "Format"
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
        #endregion
        #region "Load"
        private void frmEmpMealRegister_Load(object sender, EventArgs e)
        {

            try
            {
                if (intAttncheck == 1)
                {
                    lblTotalAttn.Visible = true;
                    txtAttendance.Visible = true;
                }
                else
                {
                    lblTotalAttn.Visible = false;
                    txtAttendance.Visible = false;
                }

                txtWeekDayName.Text = DateTime.Today.ToString("dddd");
                txtweekdayno.Text = GetWeekday(txtWeekDayName.Text).ToString();
                FormaList();

                cboMealID.ValueMember = "Key";
                cboMealID.DisplayMember = "Value";
                cboMealID.DataSource = new BindingSource(fnbs.GetMealID(), null);

                MealTime = fnbs.GetMealTime().ToList();
                timer1.Interval = 500;
                timer1.Tick += new System.EventHandler(this.timer1_Tick);

                long lngTotalP = fnbs.GetTotalAttendance(DateTime.Today.ToString("dd/MM/yyyy"));

                if (lngTotalP > 0)
                {
                    txtAttendance.Text = lngTotalP.ToString();
                }

                //dteMealDate.Focus();
                txtEmpID.Focus();
                txtEmpID.Select();
            }

            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timer1.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

       }
        #endregion
        #region "Week"
        private  static int GetWeekday(string strWeekName)
        {
            int inday=0;
            if (strWeekName =="Sunday")
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
        private static string  GetWeekday(int inDay)
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

            else if (inDay ==  2)
            {
                 strDay = "Tuesday";

            }
            else if (inDay == 3)
            {
                 strDay = "Wednesday";
            }
            else if (inDay ==  4)
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
            string  starttime = "", endtime = "",particulars="",ParId="";
            if (ds != null)
            {
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
            }

           return particulars + "-" + ParId;
        }
        #endregion
       
        private void GetSetmenuSelecteditem(string strName)
        {
            try
            {
                List<WeeklyEmpMealRegister> objWH = fnbs.DisplaySetmenuDetails(strName.ToString()).ToList();
                if (objWH.Count > 0)
                {
                    foreach (WeeklyEmpMealRegister Wh in objWH)
                    {
                        if (Wh.Bill > 0)
                        {
                            //txtBill.Text = Wh.Bill.ToString();
                            //txtNetBillAmt.Text = Wh.Bill.ToString();
                            txtBillRate.Text = Wh.Bill.ToString();
                            //if (txtSubsidyPercentage.Text == "")
                            //{
                            //    txtSubsidyPercentage.Text = "0";
                            //}
                            //txtSubsidyAmount.Text = ((Convert.ToDouble(Wh.Bill) * Convert.ToDouble(txtSubsidyPercentage.Text)) / 100).ToString();
                        }
                    }
                }
            }

            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timer1.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtEmpID", "txtWeekDayName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (cboSetMenu.Text =="")
            {
                MessageBox.Show("Cannot Empty");
                cboSetMenu.Focus();
                return false;
            }

            if (DGUP.Rows.Count == 0)
            {
                MessageBox.Show("Cannot Empty");
                return false;
            }

            //if (txtTotal.Text == "0")
            //{
            //    MessageBox.Show("Net Amount Cannot be Zero");
            //    DGUP.Focus();
            //    return  false;
            //}

           
            return true;
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
                timer1.Stop();
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private WeeklyEmpMealRegister PopulateMealRegister()
        {
            WeeklyEmpMealRegister objFood = new WeeklyEmpMealRegister();

            if (txtsetmenuid.Text != "")
            {
                objFood.SetmenuItem = txtsetmenuid.Text;
            }
            else
            {
                objFood.Setmenuid = "";
            }
           
            DateTime dtedate = Convert.ToDateTime(dteMealDate.Value);
            objFood.MealDate = dtedate.ToString("dd/MM/yyyy");
            objFood.Setmenuid = cboSetMenu.SelectedValue.ToString();
            objFood.WeekDayNo = txtweekdayno.Text;
            objFood.mealid = cboMealID.SelectedValue.ToString();
            objFood.empId = txtEmpID.Text.ToString();
            if (txtMealRegID.Text.ToString() != "")
            {
                objFood.MealRegID = txtMealRegID.Text.ToString();
            }
            else
            {
                objFood.MealRegID = "";
            }

            if (txtSubsidyAmount.Text != "")
            {
                objFood.subsidy = Convert.ToDouble(txtSubsidyAmount.Text);
            }
            else
            {
                objFood.subsidy = 0;
            }

            if (txtBill.Text != "")
            {
                objFood.Bill = Convert.ToDouble(txtBill.Text);
            }
            else
            {
                objFood.Bill = 0;
            }

            objFood.Billrate = txtDisPer.Text;
            objFood.NetAmount = Convert.ToDouble(txtTotal.Text);
            

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objFood.EntryParameter = ep;
            return objFood;
        }
        #region "Click"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                //var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (strResponse == DialogResult.Yes)
                //{

                WeeklyEmpMealRegister objEr = this.PopulateMealRegister();
                if (chkSingleItem.Checked == false)
                {
                    string i = fnbs.InsertMealRegistermaster(objEr);
                    if (i == "")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        for (int k = 0; k < DGUP.Rows.Count; k++)
                        {
                            string setmenu;
                            double dblrate;
                            setmenu = DGUP.Rows[k].Cells[0].Value.ToString();
                            if (k == 1)
                            {
                                objEr.subsidy = 0;
                                objEr.NetAmount = 0;
                                objEr.Billrate = "0";
                            }
                            dblrate = Convert.ToDouble(DGUP.Rows[k].Cells[2].Value.ToString());

                            string strTest = fnbs.InsertMealRegister(i, setmenu, dblrate, objEr);

                        }



                        //LoadListViewRegister();
                        //frmReportViewer frm = new frmReportViewer();
                        //frm.selector = ViewerSelector.BarcodeLevel;
                        //frm.Where = i;
                        //frm.ShowDialog();

                        List<VisitorsSlipRO> objS = fnbs.GetEmpStaffItem(i, "", "").ToList();
                        if (objS.Count > 0)
                        {
                            ReportDocument rpt1;
                            rptBarcode rptBarcode = new rptBarcode();
                            rpt1 = (ReportDocument)rptBarcode;
                            this.reportTitle = "";
                            this.secondParameter = "";
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(fnbs.GetEmpStaffItem(i, "", "").ToList());
                            rpt1.SetParameterValue("CardNo", i);
                            rpt1.PrintToPrinter(1, false, 0, 0);
                            //crystalReportViewer1.ReportSource = rpt1;
                            //crystalReportViewer1.PrintReport();
                            //ShowReport(rpt1, this.isPrintDirect, " " + "");
                        }



                        cboSetMenu.Focus();
                        btnNew.PerformClick();
                        txtEmpID.Text = "";
                        txtEmpName.Text = "";
                        txtDepName.Text = "";
                        txtDesName.Text = "";
                        txtUnitName.Text = "";
                        //txtSubsidy.Text = "0";
                        txtBill.Text = "0";
                        txtSubsidyPercentage.Text = "0";
                        txtSubsidyAmount.Text = "0";
                        txtNetBillAmt.Text = "0";
                        txtBill.Text = "0";
                        txtNetBillAmt.Text = "0";
                        DGUP.Rows.Clear();
                        txtGridTotal.Text = "0";
                        txtTotal.Text = "0";
                        txtDisPer.Text = "";
                        txtEmpID.Focus();

                    }

                }
            }
            //}

            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void InitialiseLabels(ReportDocument rpt)
        {

            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyName"]).Text = Utility.GetCompanyName;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyAddress"]).Text = Utility.GetCompanyAddress;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyEmail"]).Text = Utility.GetCompanyEmail;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyPhone"]).Text = Utility.GetCompanyPhone;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtIT"]).Text = Utility.GetITDvnMsg;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyWeb"]).Text = Utility.GetCompanyWeb;
            if (ReportTitle != "")
            {
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtReportTitle"]).Text = this.ReportTitle;
            }
            if (ReportSecondParameter != "")
            {
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtSecondParameter"]).Text = this.secondParameter;
            }
            else
            {
                rpt.ReportDefinition.ReportObjects["txtSecondParameter"].ObjectFormat.EnableSuppress = true;
            }

        }

        private void mClear()
        {
            btnNew.PerformClick();
            //txtEmpID.Text = "";
            //txtEmpName.Text = "";
            //txtDepName.Text = "";
            //txtDesName.Text = "";
            //txtUnitName.Text = "";
            ////txtSubsidy.Text = "0";
            txtBill.Text = "0";
            txtSubsidyPercentage.Text = "0";
            txtSubsidyAmount.Text = "0";
            txtNetBillAmt.Text = "0";
            txtBill.Text = "0";
            txtNetBillAmt.Text = "0";
            DGUP.Rows.Clear();
            txtGridTotal.Text = "0";
            txtTotal.Text = "0";
            txtDisPer.Text = "";
           // txtEmpID.Focus();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtWeekDayName.Text = DateTime.Today.ToString("dddd");
            txtweekdayno.Text = GetWeekday(txtWeekDayName.Text).ToString();
            txtEmpID.Focus();
            txtBill.Text = "0";
            txtNetBillAmt.Text = "0";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
           
        }
        private void lvwMenuItemSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMenuItemSetup.SelectedItems.Count > 0)
            {
                //btnSave.Enabled = false;
                //btnEdit.Enabled = true;

                ListViewItem itm = lvwMenuItemSetup.SelectedItems[0];
                //dteMealDate.Text = itm.SubItems[0].Text;
                //cboMealID.SelectedValue = itm.SubItems[2].Text;
                //btnAdd.PerformClick();
                //txtsetmenuid.Text = itm.SubItems[3].Text;
                //cboSetMenu.SelectedValue = itm.SubItems[3].Text;
                //if (cboSetMenu.SelectedValue == null)
                //{
                //    chkSingleItem.Checked = true;
                //    cboSetMenu.SelectedValue = itm.SubItems[3].Text;
                //}
                //GetSetmenuSelecteditem(itm.SubItems[3].Text);
                ////cboEmpID.SelectedValue = itm.SubItems[4].Text;
                //txtEmpID.Text = itm.SubItems[4].Text;
                //txtBill.Text = itm.SubItems[5].Text;
                //txtSubsidyAmount.Text = itm.SubItems[6].Text;
                txtMealRegID.Text = itm.SubItems[7].Text;
                //txtDisPer.Text = itm.SubItems[8].Text;
                //txtTotal.Text =itm.SubItems[9].Text;
                //GetEmpDetails(txtEmpID.Text);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {

                WeeklyEmpMealRegister objEr = this.PopulateMealRegister();
                int i = fnbs.UpdateMealRegister(objEr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   // LoadListViewRegister();
                    //frmReportViewer frm = new frmReportViewer();
                    //frm.selector = ViewerSelector.BarcodeLevel;
                    //frm.Where = txtEmpID.Text;
                    //frm.ShowDialog();
                    cboSetMenu.Text = "";
                    cboSetMenu.Focus();
                    btnNew.PerformClick();
                    txtWeekDayName.Text = DateTime.Today.ToString("dddd");
                    txtweekdayno.Text = GetWeekday(txtWeekDayName.Text).ToString();
                    txtBill.Text = "0";
                    txtSubsidyAmount.Text = "0";
                    txtNetBillAmt.Text = "0";
                    txtBill.Text = "0";
                    txtNetBillAmt.Text = "0";
                }

            }
        }
        #endregion
        #region "Keypress"
        private void cboMealID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboSetMenu.Focus();
            }
        }
        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //if (btnSave.Enabled)
                //{
                //    btnSave.Focus();
                //}
                //else
                //{
                //    btnEdit.Focus();
                //}
                cboSetMenu.Focus();
            }
        }
        private void dteMealDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                //cboMealID.Focus();
                btnSave.Focus();
            }
        }
       

        private void cboEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtBill.Focus();
            }
        }

        private void txtBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }

        private void txtSubsidy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
               if (btnSave.Enabled)
               {
                   btnSave.Focus();
               }
               else
               {
                   btnEdit.Focus();
               }

            }
        }
        #endregion
        private void txtEmpID_KeyUp(object sender, KeyEventArgs e)
        {
            

           

            GetEmpDetails(txtEmpID.Text);
        }
        #region "Details"
        private void GetEmpDetails(string strCardNo)
        {
            DateTime dtedate = DateTime.Now;
            string strDate = dtedate.ToString("dd/MM/yyyy");
            txtEmpName.Text = "";
            txtDepName.Text = "";
            txtDesName.Text = "";
            txtUnitName.Text = "";
            mClear();
            EmployeeMaster oEmpMas = new EmployeeMaster();
         
            EmployeeJobInformation oEmpJobInfo = new EmployeeJobInformation();
            FoodSubsidy fs = new FoodSubsidy();
            oEmpMas = fnbs.GetEmpMaster(strCardNo);
            if (txtEmpID.Text == oEmpMas.EmpId)
            {
                List<Visitors> objVis = fnbs.CheckEmpID(txtEmpID.Text.ToString(), strDate, strDate).ToList();
                if (objVis.Count > 0)
                {
                    MessageBox.Show("Record is Already Saved of " + txtEmpID.Text.ToString());
                    txtEmpID.Text = "";
                    return;
                }

                txtEmpName.Text = oEmpMas.FirstName;
                txtDepName.Text = oEmpMas.Department.DepartmentTitle;
                txtDesName.Text = oEmpMas.Designation.DesignationId;
                txtUnitName.Text = oEmpMas.DepartmentUnit.UnitId;
                txtJobLevel.Text = oEmpMas.EmployeeJobInformation.Class;
                if (txtJobLevel.Text == "4" && cboMealID.SelectedValue  == "01")
                {
                    txtSubsidyAmount.Text = "15";
                }
                else
                {
                    txtSubsidyPercentage.Text = fnbs.GetFoodSubsidy(strCardNo).Percent.ToString();
                }

                if (cboSetMenu.Items.Count > 1)
                {
                    cboSetMenu.SelectedIndex = 1;
                    btnshow.PerformClick();
                    btnSave.PerformClick();
                }

            }
           
        }
        #endregion
        #region "Click"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtweekdayno.Text = GetWeekday(txtWeekDayName.Text).ToString();
            if (cboMealID.Text != "" && txtweekdayno.Text != "")
            {
               
                cboSetMenu.ValueMember = "Key";
                cboSetMenu.DisplayMember = "Value";
                cboSetMenu.DataSource = new BindingSource(fnbs.LoadSetmenu(cboMealID.SelectedValue.ToString(), txtweekdayno.Text.ToString()), null);

            }
        }
        #endregion
        #region "ValueChanged"
        private void dteMealDate_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion 
        #region "SelectedIndex"
        private void cboMealID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtweekdayno.Text = GetWeekday(txtWeekDayName.Text).ToString();
            if (cboMealID.Text != "" && txtweekdayno.Text != "")
            {
                cboSetMenu.ValueMember = "Key";
                cboSetMenu.DisplayMember = "Value";
                cboSetMenu.DataSource = new BindingSource(fnbs.LoadSetmenu(cboMealID.SelectedValue.ToString(), txtweekdayno.Text.ToString()), null);

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                //txtEmpID.Focus();
                txtweekdayno.Text = GetWeekday(txtWeekDayName.Text).ToString();
                txtsystemTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                string strParticulars = GetShiftingTimeSlot(Convert.ToDateTime(txtsystemTime.Text), MealTime);
                var results = strParticulars.Split(new string[] { "-" }, StringSplitOptions.None);

                txtParticulars.Text = results[0].ToString();
                txtParID.Text = results[1].ToString();
                cboMealID.SelectedValue = txtParID.Text.ToString();
                //GetSetmenuSelecteditem(txtParID.Text.ToString());
               // LoadListViewRegister(txtParID.Text, txtweekdayno.Text);
            }

            catch (System.ServiceModel.CommunicationException commp)
            {
                timer1.Stop();
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        #endregion

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.BarcodeLevel;
            frm.Where = txtMealRegID.Text;
            frm.ShowDialog();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            frmFoodMenuSetup objfrm = new frmFoodMenuSetup();
            objfrm.ShowDialog();
        }

         private void btnTypeRefresh_Click(object sender, EventArgs e)
        {
            cboMealID.ValueMember = "Key";
            cboMealID.DisplayMember = "Value";
            cboMealID.DataSource = new BindingSource(fnbs.GetMealID(), null);
        }

         private void txtDis_KeyPress(object sender, KeyPressEventArgs e)
         {
             //if (e.KeyChar == (char)Keys.Return)
             //{
             //    if (btnSave.Enabled)
             //    {
             //        btnSave.Focus();
             //    }
             //    else
             //    {
             //        btnEdit.Focus();
             //    }
             //}
         }

         private void txtDis_TextChanged(object sender, EventArgs e)
         {
             //txtNetAmount.Text = (dblDiscount(txtBill, txtNetAmount, txtNetBillAmt)).ToString();
         }

         #region "Discount Function"
         private static double dblDiscount(TextBox txtbill, TextBox txtdis, TextBox txtNetBill, TextBox txtSub)
         {
             double dblBillAmount = 0;

             try
             {
                 if (txtbill.Text == "")
                 {
                     txtbill.Text = "0";
                     dblBillAmount = 0;
                 }

                 if (txtNetBill.Text == "")
                 {
                     txtNetBill.Text = "0";
                 }

                 if (txtdis.Text == "")
                 {
                     txtdis.Text = "0";
                 }
                 if (txtbill.Text == "0")
                 {
                     txtbill.Text = txtNetBill.Text;
                 }
                 if (txtSub.Text == "0")
                 {
                     txtSub.Text = "0";
                 }

                 string strPer = Right(txtdis);
                 if (strPer == "%")
                 {
                     double dblPer = Convert.ToDouble(txtdis.Text.ToString().Replace("%", ""));
                     double dblBill = Convert.ToDouble(txtbill.Text) - Convert.ToDouble(txtSub.Text);
                     dblBillAmount = (dblPer * dblBill) / 100;
                     dblBillAmount = Math.Round(dblBillAmount, 0);
                 }
                 else
                 {
                     dblBillAmount = Convert.ToDouble(txtdis.Text.ToString().Replace("%", ""));
                 }
                 return Math.Round(((Convert.ToDouble(txtbill.Text) - Convert.ToDouble(txtSub.Text)) - dblBillAmount),0);
             }
             catch (Exception ex)
             {
                 return 0;
             }

         }

         private static string Right(TextBox txtdis)
         {
             return txtdis.ToString().Substring(txtdis.ToString().Length - 1);
         }

        #endregion

         private void txtDisPer_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == (char)Keys.Return)
             {
                 if (txtTotal.Text =="" || txtTotal.Text =="0" )
                 {
                     txtTotal.Text = (dblDiscount(txtBill, txtDisPer, txtNetBillAmt, txtSubsidyAmount)).ToString();
                 }


                 if (btnSave.Enabled)
                 {
                     btnSave.Focus();
                 }
                 else
                 {
                     btnEdit.Focus();
                 }
             }
         }

         private void txtDisPer_TextChanged(object sender, EventArgs e)
         {
             txtTotal.Text = (dblDiscount(txtGridTotal, txtDisPer, txtGridTotal, txtSubsidyAmount)).ToString();
         }

         private void chkSingleItem_CheckedChanged(object sender, EventArgs e)
         {
             try
             {

                 txtBill.Text = "0";
                 txtNetBillAmt.Text = "0";
                 //txtTotal.Text = "0";
                 //txtBillRate.Text = "0";
                 if (chkSingleItem.Checked == true)
                 {
                     //cboSetMenu.DataSource = fnbs.LoadFoodItemFromCat("").ToList();
                     //cboSetMenu.ValueMember = "FoodID";
                     //cboSetMenu.DisplayMember = "FoodName";

                     //cboSetMenu.DataSource = fnbs.LoadFoodItemFromCat("").ToList();
                     cboSetMenu.DataSource = fnbs.GetFoodID("").ToList();
                     cboSetMenu.ValueMember = "ItemID";
                     cboSetMenu.DisplayMember = "ItemName";
                 }
                 else
                 {
                     txtweekdayno.Text = GetWeekday(txtWeekDayName.Text).ToString();
                     if (cboMealID.Text != "" && txtweekdayno.Text != "")
                     {
                         cboSetMenu.DataSource = new BindingSource(fnbs.LoadSetmenu(cboMealID.SelectedValue.ToString(), txtweekdayno.Text.ToString()), null);
                         cboSetMenu.ValueMember = "Key";
                         cboSetMenu.DisplayMember = "Value";
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

         private void btnshow_Click(object sender, EventArgs e)
         {
             string strSingItem = "";
             try
             {
                 if (cboSetMenu.SelectedValue.ToString() != null && cboSetMenu.SelectedValue.ToString() != "")
                 {
                     if (chkSingleItem.Checked )
                     {
                         strSingItem = cboSetMenu.SelectedValue.ToString();
                     }
                     else
                     {
                         strSingItem = "";
                     }
                     mAdditem(cboSetMenu.SelectedValue.ToString(), cboSetMenu.Text.ToString(), Convert.ToDouble(txtBillRate.Text), strSingItem);
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
         private void mAdditem(string strMealID, string strMealName,double rate,string strSingleItem)
         {
             int selRaw;
             double  dblTotal = 0;
             string strDown = "";
             Boolean blngCheck = false;
             for (int j = 0; j < DGUP.RowCount; j++)
             {
                 if (DGUP[0, j].Value != null)
                 {
                     strDown = DGUP[0, j].Value.ToString();
                 }
                 if (strMealID == strDown.ToString())
                 {
                     blngCheck = true;
                 }

             }
             if (blngCheck == false)
             {

                 DGUP.AllowUserToAddRows = true;
                 selRaw = Convert.ToInt16(DGUP.RowCount.ToString());
                 selRaw = selRaw - 1;
                 DGUP.Rows.Add(1);
                 for (int i = 1; i < DGUP.Rows.Count; i++)
                 {
                     DGUP[0, selRaw].Value = strMealID.ToString();
                     DGUP[1, selRaw].Value = strMealName.ToString();
                     DGUP[2, selRaw].Value = rate.ToString();
                     //DGUP[4, selRaw].Value =strSingleItem;
                     dblTotal = dblTotal + Convert.ToDouble(rate.ToString());
                 }
                 txtGridTotal.Text = dblTotal.ToString();

                 //txtTotal.Text = (dblDiscount(txtGridTotal, txtDisPer, txtNetBillAmt, txtSubsidyAmount)).ToString();
                 //txtNetTotal.Text = intTotal.ToString();
             }
              CalculateTotal();
             
             
             if (txtSubsidyPercentage.Text == "")
             {
                 txtSubsidyPercentage.Text = "0";
             }

             if (txtSubsidyAmount.Text == "0")
             {
                 txtSubsidyAmount.Text = Math.Round(((Convert.ToDouble(txtGridTotal.Text) * Convert.ToDouble(txtSubsidyPercentage.Text)) / 100), 0).ToString();
             }
             else
             {
                 txtSubsidyAmount.Text = txtSubsidyAmount.Text;
             }



             txtTotal.Text = (dblDiscount(txtGridTotal, txtDisPer, txtNetBillAmt, txtSubsidyAmount)).ToString();
             DGUP.AllowUserToAddRows = false;
         }

        private void CalculateTotal()
         {
             double dblNetAmount = 0;
            for (int i=0;i < DGUP.Rows.Count;i++)
            {
                dblNetAmount = dblNetAmount + Convert.ToDouble(DGUP.Rows[i].Cells[2].Value);
            }
            txtGridTotal.Text = dblNetAmount.ToString();
            txtTotal.Text = (dblDiscount(txtGridTotal, txtDisPer, txtNetBillAmt, txtSubsidyAmount)).ToString();
         }
         private void DGUP_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
        
             if (e.ColumnIndex == 3)
             {
                 int selRowIndex = e.RowIndex;

                 if (DGUP.Rows[e.RowIndex].Cells[1].Value != null)
                 {
                     DGUP.Rows.RemoveAt(selRowIndex);
                     txtSubsidyAmount.Text = "0";
                     txtTotal.Text = "0";
                     CalculateTotal();
                 }
                 else
                 {
                     CalculateTotal();
                     txtSubsidyAmount.Text = "0";
                     txtTotal.Text = "0";
                 }
             }
         }

         private void btnClose_Click(object sender, EventArgs e)
         {

         }
           #region "Selectedindex"
         private void cboSetMenu_SelectedIndexChanged(object sender, EventArgs e)
         {
           
     
            if (chkSingleItem.Checked == false)
            {
                //txtTotal.Text = txtBill.Text.ToString();
                if (cboSetMenu.Text != "--Select--" && cboSetMenu.Text != "")
                {
                    GetSetmenuSelecteditem(cboSetMenu.SelectedValue.ToString());
                    txtTotal.Text = (dblDiscount(txtGridTotal, txtDisPer, txtNetBillAmt, txtSubsidyAmount)).ToString();
                }
            }
            else
            {
                //txtBill.Text = "0";
                //txtSubsidyAmount.Text = "0";
                //txtTotal.Text = "0";
                if (cboSetMenu.Text != "--Select--" && cboSetMenu.Text != "")
                {
                    List<FoodMaster> objFm = fnbs.GetItemRate(cboSetMenu.SelectedValue.ToString()).ToList();
                    if (objFm.Count > 0)
                    {
                        foreach (FoodMaster fm in objFm)
                        {
                            txtBillRate.Text = fm.Price.ToString();
                            //txtTotal.Text = txtBill.Text.ToString();
                          //  txtTotal.Text = (dblDiscount(txtGridTotal, txtDisPer, txtNetBillAmt, txtSubsidyAmount)).ToString();
                        }
                    }
                }
            }
        }
        #endregion

         private void cboSetMenu_KeyPress(object sender, KeyPressEventArgs e)
         {
            
            if (e.KeyChar == (char)Keys.Return)
            {

               // txtDis.Focus();
                btnshow.Focus();
                
            }
         }

         private void cboSetMenu_Click(object sender, EventArgs e)
         {
             //cboSetMenu.Focus();
         }

         private void btnDetails_Click(object sender, EventArgs e)
         {
             frmDetailsList frm = new frmDetailsList();
             frm.Where = txtParID.Text;
             frm.where1 = txtweekdayno.Text;
             frm.type = txtParticulars.Text;
             frm.ShowDialog();
         }

         //private void btnDetails_Click(object sender, EventArgs e)
         //{
         //    frmDetailsList frm = new frmDetailsList();
         //    frm.Where = txtParID.Text;
         //    frm.where1=txtweekdayno.Text;
         //    frm.type = txtParticulars.Text;
         //    frm.ShowDialog();
                 
         //}

        

        

       
         

        






    }
}
